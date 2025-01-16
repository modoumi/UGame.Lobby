using UGame.Lobby.Common.Enum;
using UGame.Lobby.Repository.ing;
using Newtonsoft.Json;
using AiUo;
using AiUo.Data;
using AiUo.Extensions.AutoMapper;
using AiUo.Extensions.RabbitMQ;
using AiUo.Extensions.StackExchangeRedis;
using AiUo.Logging;
using UGame.Lobby.Service.Common;
using Xxyy.Common;
using Xxyy.Common.Services;
using Xxyy.MQ.Lobby.Activity;

namespace UGame.Lobby.Service.Services.Activity.Rebate
{
    public class RebateService
    {
        private readonly Sa_rebate_dayMO _rebateDayMo = new();
        private readonly Sa_rebate_user_detailMO _rebateUserDetailMo = new();
        private readonly Sa_rebate_realtime_configMO _rebateRealtimeConfigMo = new();

        #region 返点
        /// <summary>
        /// 获取返点配置
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        public async Task<List<RebateDotConfigDto>> GetRebateDotConfig(RebateDotConfigIpo ipo)
        {
            var data = await _rebateRealtimeConfigMo.GetAsync("OperatorId=@OperatorId and ActivityID=@ActivityID", ipo.OperatorId, ipo.ActivityId);
            return data.Map<List<RebateDotConfigDto>>();
        }

        /// <summary>
        /// 获取返点，根据参数配置的不同，同时支持活动入口和奖励中心入口
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GetRebateListDto> GetRebateDotList(RebateDotRequet request)
        {
            var rebateDate = request.RebateDateUtc ?? DateTime.UtcNow;
            var dayId = rebateDate.ToLocalTime(request.OperatorId).Date;

            DateTime beginDate = default;
            DateTime endDate = default;
            string detailSql = null, dailyBetSql = null;
            var parameters = new List<object> { request.UserId, request.OperatorId, request.CurrencyId };
            int activityId = 0;
            switch (request.Frequency)
            {
                case 2:
                    activityId = (int)ActivityType.RebateDotWeekly;
                    beginDate =DateTimeUtil.BeginDayOfWeek(dayId);
                    endDate = beginDate.AddDays(7);
                    detailSql = "UserId=@UserId and OperatorId=@OperatorId and CurrencyId=@CurrencyId and RebateType=1 and DayId>=@BeginDate and DayId<@EndDate and ActivityID=@ActivityID";
                    dailyBetSql = "UserId=@UserId and OperatorId=@OperatorId and CurrencyId=@CurrencyId and DayId>=@BeginDate and DayId<@EndDate and ActivityID=@ActivityID";
                    parameters.AddRange(new object[] { beginDate, endDate, activityId });
                    break;
                case 3:
                    activityId = (int)ActivityType.RebateDotMonthly;
                    beginDate = DateTimeUtil.LastDayOfPrdviousMonth(dayId).AddDays(1);
                    endDate = beginDate.AddMonths(1);
                    detailSql = "UserId=@UserId and OperatorId=@OperatorId and CurrencyId=@CurrencyId and RebateType=1 and DayId>=@BeginDate and DayId<@EndDate and ActivityID=@ActivityID";
                    dailyBetSql = "UserId=@UserId and OperatorId=@OperatorId and CurrencyId=@CurrencyId and DayId>=@BeginDate and DayId<@EndDate and ActivityID=@ActivityID";
                    parameters.AddRange(new object[] { beginDate, endDate, activityId });
                    break;
                default:
                    activityId = (int)ActivityType.RebateDot;
                    detailSql = "UserId=@UserId and OperatorId=@OperatorId and CurrencyId=@CurrencyId and RebateType=1 and DayId=@DayId and ActivityID=@ActivityID";
                    dailyBetSql = "UserId=@UserId and OperatorId=@OperatorId and CurrencyId=@CurrencyId and DayId=@DayId and ActivityID=@ActivityID";
                    parameters.AddRange(new object[] { dayId, activityId });
                    break;
            }
            var rebateDays = await _rebateDayMo.GetAsync(dailyBetSql, parameters.ToArray());
            var rebateDetails = await _rebateUserDetailMo.GetSortAsync(detailSql, "Level", parameters.ToArray());


            //var realtimeConfigInfoCache = new RebateRealTimeConfigDCache(request.OperatorId, request.CurrencyId, activityId);
            //var configInfoListCache = await realtimeConfigInfoCache.GetOrLoadAsync();
            //var configInfos = configInfoListCache.Value;
            var realtimeConfigInfoMo = new Sa_rebate_realtime_configMO();
            var configInfos = await realtimeConfigInfoMo.GetAsync("OperatorId=@OperatorId and CurrencyId=@CurrencyId and ActivityID=@ActivityID",
                   request.OperatorId, request.CurrencyId, activityId);

            var result = new GetRebateListDto { DotList = new List<RebateDotResponse>() };
            configInfos.Sort((x, y) => x.Level.CompareTo(y.Level));
            foreach (var configInfo in configInfos)
            {
                var freqDetail = rebateDetails.Find(f => f.Level == configInfo.Level);
                var response = new RebateDotResponse
                {
                    DetailID = freqDetail?.DetailID,
                    UserID = request.UserId,
                    OperatorID = request.OperatorId,
                    DayID = freqDetail?.DayID,
                    Level = configInfo.Level,
                    RebateType = 1,
                    Percent = 100,
                    BetMinAmount = configInfo.BetMinAmount.AToM(request.CurrencyId),
                    RebateAmount = freqDetail?.RebateAmount ?? 0,
                    RebateAmount3 = configInfo.RebateAmount.AToM(request.CurrencyId),
                    RecDate = freqDetail?.RecDate ?? DateTime.MinValue,
                    ReceiveStatus = freqDetail?.ReceiveStatus ?? 0
                };

                var totalBetAmount = rebateDays.Sum(f => f.EffectiveBetAmount);
                var totalBetMondey = totalBetAmount >= configInfo.BetMinAmount ?
                      configInfo.BetMinAmount.AToM(configInfo.CurrencyID) : totalBetAmount.AToM(configInfo.CurrencyID);
                response.CurrentBetAmount = totalBetMondey;
                response.TotalBetAmount = totalBetMondey;
                response.NeedBetAmount = configInfo.BetMinAmount.AToM(configInfo.CurrencyID);
                var percentage = (int)(totalBetAmount * 100 / configInfo.BetMinAmount);
                response.Percent = percentage > 100 ? 100 : percentage;
                result.DotList.Add(response);
            }
            result.TotalReward = rebateDetails.FindAll(f => f.ReceiveStatus == 0).Sum(f => f.RebateAmount).AToM(request.CurrencyId);
            return result;
        }
        /// <summary>
        /// 领取返点
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<TakeRebateDto> TakeRebate(TakeRebateIpo request)
        {
            TakeRebateDto dt = new TakeRebateDto();

            //查询当前活动配置
            var userDetail = await _rebateUserDetailMo.GetByPKAsync(request.DetailID);
            if (userDetail == null)
                throw new CustomException("rebate award is not exist");

            var activityOperator = await LobbyUtil.GetSingleActivityAsync(request.OperatorId, request.CurrencyId, (ActivityType)userDetail.ActivityID);
            if (activityOperator == null || !activityOperator.Status)
                throw new CustomException(LobbyCodes.RS_INVALID_ACTIVITY, $@"Invalid activity.");

            using var lockObj = await RedisUtil.LockAsync($"RebateDot.{request.UserId}.{request.DetailID}", 5);
            string detailId = request.DetailID;
            var tm = new TransactionManager();
            try
            {
                if (!lockObj.IsLocked)
                {
                    lockObj.Release();
                    throw new CustomException(CommonCodes.UserConcurrent, $"lobby:TakeRebate:Request for lock failed.Key:RebateDot.{request.UserId}.{request.DetailID}");
                }

                if (userDetail.ReceiveStatus == 1)
                    throw new CustomException("Incorrect claim");

                var updateTime = DateTime.UtcNow;
                var sql = $"update sa_rebate_user_detail set ReceiveStatus=1,UpdateTime='{updateTime:yyyy-MM-dd HH:mm:ss}' where DetailID='{userDetail.DetailID}'";
                await _rebateUserDetailMo.Database.ExecSqlNonQueryAsync(sql, tm);

                var rewardAmount = userDetail.RebateAmount;
                var flowMultip = userDetail.FlowMultip;
                var currencyChangeService = new CurrencyChangeService(request.UserId);

                var realtimeConfigInfo = await _rebateRealtimeConfigMo.GetSingleAsync("ActivityID=@ActivityID and OperatorId=@OperatorId and CurrencyId=@CurrencyId and Level=@Level",
                    userDetail.ActivityID, userDetail.OperatorID, userDetail.CurrencyID, userDetail.Level);

                var rewardType = activityOperator.IsBonus ? 1 : 2;
                var changeBalanceType = rewardType switch
                {
                    1 => CurrencyChangeBalance.Bonus,
                    2 => CurrencyChangeBalance.Cash,
                    _ => CurrencyChangeBalance.None
                };
                var currencyChangeReq = new CurrencyChangeReq()
                {
                    UserId = request.UserId,
                    Amount = rewardAmount,
                    AppId = request.AppId,
                    ChangeTime = updateTime,
                    CurrencyId = request.CurrencyId,
                    OperatorId = request.OperatorId,
                    ChangeBalance = changeBalanceType,
                    FlowMultip = flowMultip,
                    TM = tm,
                    Reason = "返点活动奖励",
                    SourceType = userDetail.ActivityID,
                    SourceTable = "Sa_rebate_user_detail",
                    SourceId = detailId
                };
                var changedMsg = await currencyChangeService.Add(currencyChangeReq);
                if (changedMsg == null)
                    throw new CustomException("写入s_currency_change失败");
                tm.Commit();

                await MQUtil.PublishAsync(changedMsg);
                await MQUtil.PublishAsync(new UserActivityMsg()
                {
                    UserId = request.UserId,
                    ActivityType = userDetail.ActivityID
                });

                dt.success = true;
                return dt;
            }
            catch (Exception ex)
            {
                tm.Rollback();
                if (ex is not CustomException)
                {
                    LogUtil.GetContextLogger().AddException(ex).AddMessage($"RebateService.TakeRebate.request:{JsonConvert.SerializeObject(request)}");
                }
                dt.success = false;
                dt.message = ex.Message;
            }
            finally
            {
                lockObj.Release();
            }
            return dt;
        }
        #endregion

        #region 返水
        /// <summary>
        /// 获取返水
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<RebateWaterResponse> GetRebateWater(RebateWaterRequest request)
        {
            var response = new RebateWaterResponse() { SearchKey = "Slots" };
            var rebateDate = request.RebateDateUtc ?? DateTime.UtcNow;
            var dayId = rebateDate.ToLocalTime(request.OperatorId).Date;
            DateTime beginDate = default;
            DateTime endDate = default;
            string dailyBetSql = null;
            int activityID = 0;
            var parameters = new List<object> { request.UserId, request.OperatorId, request.CurrencyId };
            switch (request.Frequency)
            {
                case 2:
                    beginDate = DateTimeUtil.BeginDayOfWeek(dayId);
                    endDate = beginDate.AddDays(7);
                    activityID = (int)ActivityType.RebateWaterWeekly;
                    dailyBetSql = "UserId=@userId and OperatorId=@OperatorId and CurrencyId=@CurrencyId and DayId>=@BeginDate and DayId<@EndDate and ActivityID=@ActivityID";
                    parameters.AddRange(new object[] { beginDate, endDate, activityID });
                    break;
                case 3:
                    beginDate = DateTimeUtil.LastDayOfPrdviousMonth(dayId).AddDays(1);
                    endDate = beginDate.AddMonths(1);
                    activityID = (int)ActivityType.RebateWaterMonthly;
                    dailyBetSql = "UserId=@userId and OperatorId=@OperatorId and CurrencyId=@CurrencyId and DayId>=@BeginDate and DayId<@EndDate and ActivityID=@ActivityID";
                    parameters.AddRange(new object[] { beginDate, endDate, activityID });
                    break;
                default:
                    activityID = (int)ActivityType.RebateWater;
                    dailyBetSql = "UserId=@userId and OperatorId=@OperatorId and CurrencyId=@CurrencyId and DayId=@DayId and ActivityID=@ActivityID";
                    parameters.AddRange(new object[] { dayId, activityID });
                    break;
            }

            //var quartzConfig = new RebateQuartzConfigDCache(request.OperatorId, request.CurrencyId, activityID);
            //var quartzConfigInfoCache = await quartzConfig.GetOrLoadAsync();
            //var quartzConfigInfo = quartzConfigInfoCache.Value;
            var quarzConfigInfoMo = new Sa_rebate_quartz_configMO();
            var quartzConfigInfo = await quarzConfigInfoMo.GetSingleAsync("OperatorId=@OperatorId and CurrencyId=@CurrencyId and ActivityID=@ActivityID",
                  request.OperatorId, request.CurrencyId, activityID);

            var rebateDays = await _rebateDayMo.GetAsync(dailyBetSql, parameters.ToArray());
            if (rebateDays != null && rebateDays.Count > 0)
            {
                var rewardRatio = quartzConfigInfo.RewardRatio;
                var minAmount = quartzConfigInfo.MinAmount;
                var totalAmount = rebateDays.Sum(f => f.EffectiveBetAmount);
                response.TotalBetAmount = totalAmount.AToM(request.CurrencyId);
                var rebateAmount = this.GetRebateWaterAmount(request.CurrencyId, totalAmount, rewardRatio, minAmount);
                response.RebateAmount = rebateAmount;
                response.RewardTime = dayId.AddDays(1);
            }
            return response;
        }
        private decimal GetRebateWaterAmount(string currencyId, long totalAmount, float rewardRatio, long minAmount)
        {
            double expectedRebateAmount = totalAmount * rewardRatio;
            if (expectedRebateAmount < minAmount)
                return 0;

            //不足一元的小数部分舍弃
            var minUnitAmount = 1d.MToA(currencyId);
            var rebateAmount = (long)expectedRebateAmount / minUnitAmount * minUnitAmount;
            return rebateAmount.AToM(currencyId);
        }
        #endregion
    }
}
