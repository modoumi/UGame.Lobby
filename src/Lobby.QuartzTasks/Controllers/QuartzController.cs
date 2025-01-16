using Lobby.DAL.ing;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using TinyFx.AspNet;
using TinyFx.Security;
using Xxyy.Common;
using Xxyy.DAL;

namespace Lobby.QuartzTasks.Controllers
{
    /// <summary>
    /// QuartzController
    /// </summary>
    [ApiController]
    [Route("api/[controller]/[action]")]
    [IgnoreActionFilter]
    public class QuartzController : ControllerBase
    {
        /// <summary>
        /// 同步游戏JP奖池到lobby
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<QuartzApiResult> SyncJpToLobby([FromHeader] string token)
        {

            if (string.IsNullOrWhiteSpace(token))
                return new QuartzApiResult() { Success = false, Message = "token为空" };

            var obj = JwtUtil.ReadJwtToken(token);
            if (!obj.UserId.Equals("SyncJackpotToLobby"))
                return new QuartzApiResult() { Success = false, Message = "token不合法" };

            var appJackpotMo = new L_app_jackpotMO();
            var operatorAppMo = new S_operator_appMO();

            var appJackpotList = await appJackpotMo.GetAllAsync();

            if (appJackpotList == null || !appJackpotList.Any())
                return new QuartzApiResult() { Message = "l_app_jackpot中没有数据" };

            StringBuilder message = new StringBuilder();

            foreach (var item in appJackpotList)
            {
                var operatorApp = operatorAppMo.GetSingleAsync($"AppID = '{item.AppID}' and OperatorID = '{item.OperatorID}'");
                if (operatorApp == null)
                {
                    message.AppendLine($"s_operator_app中不存在AppID={item.AppID}并且OperatorID={item.OperatorID}的数据");
                    continue;
                }

                try
                {
                    var jackpotAmount = DbSink.GameDb.ExecSqlScalar<long?>($"select {item.SourceField} from {item.SourceTable} where OperatorID = '{item.OperatorID}' and CurrencyID = '{item.CurrencyID}'");

                    if (jackpotAmount.HasValue)
                    {
                        item.Jackpot = jackpotAmount.Value;
                        await appJackpotMo.PutAsync(item);
                        //await appJackpotMo.PutJackpotAsync((long)jackpotAmount);
                        continue;
                    }

                    message.AppendLine($"{item.SourceTable}中未找到数据，条件1：OperatorID={item.OperatorID} and CountryID = {item.CountryId} and CurrencyID = {item.CurrencyID}；条件2：OperatorID = {item.OperatorID} and CurrencyID = {item.CurrencyID}");
                }
                catch (Exception ex)
                {
                    message.AppendLine($"{item.SourceTable}，errorMessage:{ex.Message}");
                    continue;
                }
            }

            return new QuartzApiResult() { Success = true, Message = message.ToString() };
        }

        /// <summary>
        /// 用户下注记录统计
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<QuartzApiResult> BetRecords([FromHeader] string token)
        {
            if (string.IsNullOrWhiteSpace(token))
                return new QuartzApiResult() { Success = false, Message = "token为空" };

            var obj = JwtUtil.ReadJwtToken(token);
            if (!obj.UserId.Equals("BetRecords"))
                return new QuartzApiResult() { Success = false, Message = "token不合法" };

            var timeNow = DateTime.UtcNow.AddDays(-1);

            var startTime = timeNow.ToString("yyyy-MM-dd 00:00:00");
            var endTime = timeNow.AddDays(1).ToString("yyyy-MM-dd 00:00:00");

            //1、获取昨天有过下注记录的用户
            var selectUserIDsSql = $"select UserID,CurrencyID from s_provider_order where RecDate >= '{startTime}' and RecDate < '{endTime}' group by UserID,CurrencyID";
            var userIDsDBData = await DbSink.MainDb.ExecSqlListAsync<ProviderOrder>(selectUserIDsSql);

            if (userIDsDBData != null && userIDsDBData.Any())
            {
                List<Sr_user_settl_dayEO> insertList = new List<Sr_user_settl_dayEO>();
                foreach (var item in userIDsDBData)
                {
                    var dbData = new List<S_provider_orderEO>();
                    var insertItem = new Sr_user_settl_dayEO();
                    try
                    {
                        //循环读库
                        //2、从数据库获取当前用户昨天的下注记录明细
                        dbData = new S_provider_orderMO().Get($"UserID = '{item.UserID}' and CurrencyID = '{item.CurrencyID}'").ToList();
                        if (dbData != null && dbData.Any())
                        {
                            insertItem.UserID = item.UserID;
                            insertItem.CurrencyID = item.CurrencyID;
                            insertItem.SumDay = Convert.ToDateTime(timeNow.ToString("yyyy-MM-dd"));
                            insertItem.BetSum = dbData.Sum(d => d.PlanBet);
                            insertItem.WinSum = dbData.Sum(d => d.PlanWin);
                            insertItem.AmountSum = dbData.Sum(d => d.PlanAmount);
                            insertItem.RecDate = DateTime.UtcNow;
                            insertList.Add(insertItem);
                        }
                    }
                    catch (Exception)
                    {
                        //3、发邮件通知管理员异常了
                        continue;
                    }
                    //4、写库
                    if (insertList.Count >= 100 || insertItem.UserID.Equals(userIDsDBData.Last().UserID))
                    {
                        await new Sr_user_settl_dayMO().AddByBatchAsync(insertList, insertList.Count);
                        insertList.Clear();
                    }
                }
            }

            return new QuartzApiResult() { Success = true, Message = timeNow.ToString("yyyy-MM-dd") };
        }

    }

    /// <summary>
    /// ProviderOrder
    /// </summary>
    public class ProviderOrder
    {
        /// <summary>
        /// 用户编码
        /// </summary>
        public string UserID { get; set; } = string.Empty;
        /// <summary>
        /// 货币编码
        /// </summary>
        public string CurrencyID { get; set; } = string.Empty;
    }

    /// <summary>
    /// QuartzApiResult
    /// </summary>
    public class QuartzApiResult
    {
        /// <summary>
        /// 
        /// </summary>
        public bool Success { get; set; } = false;
        /// <summary>
        /// 
        /// </summary>
        public string Message { get; set; } = string.Empty;
    }
}
