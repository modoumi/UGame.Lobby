using UGame.Lobby.Common.Enum;
using UGame.Lobby.Repository.ing;
using Newtonsoft.Json;
using AiUo;
using AiUo.Collections;
using AiUo.Configuration;
using AiUo.Data;
using AiUo.Logging;
using AiUo.Net;
using UGame.Lobby.Service.Caching;
using UGame.Lobby.Service.Caching.Activity;
using UGame.Lobby.Service.Caching.Notify;
using UGame.Lobby.Service.Caching.Pay;
using UGame.Lobby.Service.Caching.WithDraw;
using Xxyy.Common;
using Xxyy.Common.Caching;
using Xxyy.Common.Services;
using Xxyy.DAL;
using Xxyy.MQ.Lobby.Notify;

namespace UGame.Lobby.Service.Common
{
    public static class LobbyUtil
    {

        /// <summary>
        /// 发送邮件
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public static bool SendEmail(string content)
        {
            var _options = ConfigUtil.GetSection<LobbyOptionsSection>();

            try
            {
                var client = new SmtpClientEx("lobby");
                client.SendTo("lobby", $"lobby", content);
                return true;
            }
            catch (Exception ex)
            {
                LogUtil.GetContextLogger().AddException(ex).AddMessage($"lobby发送邮件失败,content:{content},error:{ex.Message}");
                return false;
            }
        }


        public static string GetIcon(string icon)
        {
            LobbyOptionsSection _options = ConfigUtil.GetSection<LobbyOptionsSection>();

            if (icon.StartsWith("http"))
                return icon;
            return _options.ImageBaseUrl + icon;
        }
        public static string GetImg(string icon)
        {
            LobbyOptionsSection _options = ConfigUtil.GetSection<LobbyOptionsSection>();

            if (icon.StartsWith("http"))
                return icon;
            if (!_options.MessageImgUrl.EndsWith("/"))
            {
                _options.MessageImgUrl += "/";
            }
            return _options.MessageImgUrl + icon;
        }

        /// <summary>
        /// 获取提现配置
        /// </summary>
        /// <param name="operatorId">运营商编码</param>
        /// <param name="currencyId">货币编码</param>
        /// <returns>提现审批起始金额、最小提现金额</returns>
        public static async Task<Sc_cash_configEO> GetCashConfig(string operatorId, string currencyId)
        {
            if (string.IsNullOrWhiteSpace(operatorId) || string.IsNullOrWhiteSpace(currencyId))
            {
                throw new CustomException("operatorId or currencyId is not empty.");
            }

            var field = CashConfigDCache.GetField(operatorId, currencyId);

            var cashConfig = await new CashConfigDCache().GetOrLoadAsync(field);

            if (!cashConfig.HasValue)
            {
                throw new CustomException("Withdraw Configuration not found");
            }

            return cashConfig.Value;
        }

        /// <summary>
        /// 写入通知（直接写入）
        /// </summary>
        /// <returns></returns>
        public static bool WriteNotify(List<Sc_notifyEO> notifyEOList, List<Sc_notify_userEO> notifyUserEoList, List<Sc_notify_detailEO> notifyDetailEoList)
        {
            TransactionManager tm = new TransactionManager();
            var notifyMo = new Sc_notifyMO();
            var notifyUserMo = new Sc_notify_userMO();
            var notifyDetailMo = new Sc_notify_detailMO();
            try
            {
                if (notifyEOList != null && notifyEOList.Any())
                {
                    foreach (var item in notifyEOList)
                        notifyMo.Add(item, tm);
                }
                if (notifyUserEoList != null && notifyUserEoList.Any())
                {
                    foreach (var item in notifyUserEoList)
                        notifyUserMo.Add(item, tm);
                }
                if (notifyDetailEoList != null && notifyDetailEoList.Any())
                {
                    foreach (var item in notifyDetailEoList)
                        notifyDetailMo.Add(item, tm);
                }
                tm.Commit();
                return true;
            }
            catch (Exception ex)
            {
                tm.Rollback();

                LogUtil.GetContextLogger().AddException(ex).AddMessage($"AddNotify,异常.notifyEOList:{JsonConvert.SerializeObject(notifyEOList)}.notifyUserEoList:{JsonConvert.SerializeObject(notifyUserEoList)}.notifyDetailEoList:{JsonConvert.SerializeObject(notifyDetailEoList)}");
                return false;
            }
        }



        private static Sc_notifyEO BuildNotifyEo(Notify notify)
        {
            return new Sc_notifyEO()
            {
                NotifyID = notify.NotifyId,
                AppID = notify.AppId,
                OperatorID = notify.OperatorId,
                ActionAt = notify.ActionAt,
                ShowAt = notify.ShowAt,
                UserScope = notify.UserScope,
                Position = notify.Position,
                ShowTimes = notify.ShowTimes,
                ShowInterval = notify.ShowInterval,
                CloseInterval = notify.CloseInterval,
                OrderNum = notify.OrderNum,
                BeginDate = notify.BeginDate,
                EndDate = notify.BeginDate.AddDays(1),
                Status = notify.Status,
                RecDate = notify.RecDate
            };
        }

        private static Sc_notify_detailEO BuildNotifyDetailEo(NotifyDetail notifyDetail)
        {
            return new Sc_notify_detailEO()
            {
                NotifyID = notifyDetail.NotifyId,
                LangID = notifyDetail.LangId,
                Title = notifyDetail.Title,
                ImageUrl = notifyDetail.ImageUrl,
                Content = notifyDetail.Content,
                LinkKind = notifyDetail.LinkKind,
                LinkUrl = notifyDetail.LinkUrl
            };
        }

        /// <summary>
        /// MQ写入通知
        /// </summary>
        /// <param name="notifies"></param>
        /// <param name="notifyUsers"></param>
        /// <param name="notifyDetails"></param>
        /// <returns></returns>
        public static async Task<bool> WriteNotifyForMQ(List<Notify> notifies, List<NotifyUser> notifyUsers, List<NotifyDetail> notifyDetails)
        {
            var notifyMo = new Sc_notifyMO();
            var notifyUserMo = new Sc_notify_userMO();
            var notifyDetailMo = new Sc_notify_detailMO();
            TransactionManager tm = new TransactionManager();

            List<Sc_notifyEO> insertNotifyEoList = new List<Sc_notifyEO>();
            Sc_notifyEO insertNotifyEo = null;
            try
            {
                if (notifies != null && notifies.Any())
                {
                    foreach (var item in notifies)
                    {
                        insertNotifyEo = BuildNotifyEo(item);
                        insertNotifyEoList.Add(insertNotifyEo);

                        notifyMo.Add(insertNotifyEo, tm, useIgnore_: true);
                    }
                }
                if (notifyUsers != null && notifyUsers.Any())
                {
                    foreach (var item in notifyUsers)
                    {
                        notifyUserMo.Add(new Sc_notify_userEO()
                        {
                            NotifyID = item.NotifyId,
                            UserID = item.UserId
                        }, tm, useIgnore_: true);
                    }
                }
                if (notifyDetails != null && notifyDetails.Any())
                {
                    foreach (var item in notifyDetails)
                    {
                        notifyDetailMo.Add(BuildNotifyDetailEo(item), tm, useIgnore_: true);
                    }
                }
                tm.Commit();

                #region 更新缓存new

                foreach (var item in notifyUsers)
                {
                    insertNotifyEo = insertNotifyEoList.Where(d => d.NotifyID.Equals(item.NotifyId)).FirstOrDefault();
                    if (insertNotifyEo != null)
                    {
                        var notifyUsersDCache = new SCNotifyUsersDCache(item.UserId, insertNotifyEo.AppID, insertNotifyEo.ActionAt, insertNotifyEo.ShowAt, insertNotifyEo.OperatorID);
                        await notifyUsersDCache.ProcessSetAsync(item.NotifyId, insertNotifyEo);
                    }
                }

                #endregion

                #region 更新缓存

                //更新用户需要收到的通知缓存
                //foreach (var item in notifyUsers)
                //{
                //    var notifyUserDCache = new NotifyUserDCache(item.UserId);
                //    var notifyUserDCacheData = await notifyUserDCache.GetAsync();
                //    var notify = notifies.Where(d => d.NotifyId.Equals(item.NotifyId)).FirstOrDefault();
                //    if (notify != null)
                //    {
                //        if (notifyUserDCacheData != null && !notifyUserDCacheData.Any(d => d.NotifyID.Equals(notify.NotifyId)))
                //        {
                //            notifyUserDCacheData.Add(new V_sc_notify_userEO()
                //            {
                //                NotifyID = item.NotifyId,
                //                UserID = item.UserId,
                //                BeginDate = notify.BeginDate,
                //                EndDate = notify.EndDate
                //            });
                //            await notifyUserDCache.SetAsync(notifyUserDCacheData);
                //        }
                //    }
                //}
                ////更新缓存
                //var scNotifyDCacheData = (from notify in notifies
                //                          join notifyDetail in notifyDetails
                //                          on notify.NotifyId equals notifyDetail.NotifyId
                //                          select new V_sc_notify_detailEO
                //                          {
                //                              NotifyID = notify.NotifyId,
                //                              LangID = notifyDetail.LangId,
                //                              Title = notifyDetail.Title,
                //                              ImageUrl = notifyDetail.ImageUrl,
                //                              Content = notifyDetail.Content,
                //                              LinkKind = notifyDetail.LinkKind,
                //                              LinkUrl = notifyDetail.LinkUrl,
                //                              AppID = notify.AppId,
                //                              ActionAt = notify.ActionAt,
                //                              ShowAt = notify.ShowAt,
                //                              OperatorID = notify.OperatorId,
                //                              UserScope = notify.UserScope,
                //                              NotifyUsersCount = notify.NotifyUsersCount,
                //                              Position = notify.Position,
                //                              ShowTimes = notify.ShowTimes,
                //                              ShowInterval = notify.ShowInterval,
                //                              CloseInterval = notify.CloseInterval,
                //                              OrderNum = notify.OrderNum,
                //                              BeginDate = notify.BeginDate,
                //                              EndDate = notify.EndDate
                //                          }).ToList().GroupBy(d => new { d.AppID, d.ActionAt, d.ShowAt, d.OperatorID, d.LangID }).ToDictionary(d => d.Key, d => d.FirstOrDefault());

                //foreach (var item in scNotifyDCacheData)
                //{
                //    var cache = new SCNotifyDCache(item.Key.AppID, item.Key.ActionAt, item.Key.ShowAt, item.Key.OperatorID, item.Key.LangID);

                //    var data = await cache.GetAsync();

                //    var testDic = data.Value.GroupBy(d => d.NotifyID).ToDictionary(d => d.Key, d => d.ToList());

                //    foreach (var itemDic in testDic)
                //    {
                //        if (itemDic.Value.Count() > 1)
                //        {
                //            var notifyId = itemDic.Key;
                //        }
                //    }

                //    if (data.HasValue && item.Value != null && !data.Value.Any(d => d.NotifyID.Equals(item.Value.NotifyID)))
                //    {
                //        data.Value.Add(item.Value);
                //        await cache.SetAsync(data.Value);
                //    }
                //}

                #endregion

                return true;
            }
            catch (Exception ex)
            {
                tm.Rollback();

                LogUtil.GetContextLogger().AddException(ex).AddMessage($"AddNotify,异常.error:{ex.Message}.notifyEOList:{JsonConvert.SerializeObject(notifies)}.notifyUserEoList:{JsonConvert.SerializeObject(notifyUsers)}.notifyDetailEoList:{JsonConvert.SerializeObject(notifyDetails)}");

                return false;
            }
        }

        public static string GetShowName(S_userEO user)
        {
            if (user == null)
                return string.Empty;

            if (!string.IsNullOrWhiteSpace(user.Mobile))
                return user.Mobile.HideFixedLength(user.Mobile.Length, 3, 3, '*');

            if (!string.IsNullOrWhiteSpace(user.Username))
                return user.Mobile.HideFixedLength(user.Username.Length, 3, 3, '*');

            return user.UserID.HideFixedLength(user.UserID.Length, 3, 3, '*');
        }

        /// <summary>
        /// 获取通知模板
        /// </summary>
        /// <param name="operatorId">运营商编码</param>
        /// <param name="currencyId">货币编码</param>
        /// <param name="activityType">活动类型</param>
        /// <param name="notifyType">1、弹框通知2、email</param>
        /// <returns></returns>
        public static async Task<List<Sa_notify_templateEO>> GetNotifyTemplate(string operatorId, string currencyId, int activityType, NotifyTypeEnum notifyType = NotifyTypeEnum.None)
        {
            //获取通知模板
            var tempField = NotifyTemplateDCache.GetField(operatorId, currencyId, activityType);
            var notifyTempEo = await new NotifyTemplateDCache().GetOrLoadAsync(tempField);

            if (notifyTempEo.HasValue)
            {
                return notifyTempEo.Value.Where(d => d.NotifyType == (int)notifyType).ToList();
            }
            return new List<Sa_notify_templateEO>();
        }

        /// <summary>
        /// 获取当前活动是否有效
        /// </summary>
        /// <param name="operatorId">运营商编码</param>
        /// <param name="currencyId">货币编码</param>
        /// <param name="activityType">活动类型</param>
        /// <param name="activityEvent">事件类型</param>
        /// <returns></returns>
        public static async Task<(bool IsValid, ActivityEventEntity activityEntity)> GetActivityIsValid(string operatorId, string currencyId, ActivityType activityType, ActivityEvent activityEvent)
        {
            (bool IsValid, ActivityEventEntity activityEntity) ret = (false, null);


            var cache = new ActivityListDCache(operatorId, currencyId);

            var cacheData = await cache.GetAsync();

            //如果未配置任何活动或活动全部已过期
            if (cacheData == null || !cacheData.HasValue)
                return ret;

            ret.activityEntity = cacheData.Value.Where(d => d.Status && d.ActivityID == (int)activityType && d.EventId == (int)activityEvent).FirstOrDefault();

            if (ret.activityEntity != null)
                ret.IsValid = true;

            return ret;

        }

        /// <summary>
        /// 从本地缓存，获取当前活动是否有效
        /// </summary>
        /// <param name="operatorId"></param>
        /// <param name="currencyId"></param>
        /// <param name="activityType"></param>
        /// <returns></returns>
        public static async Task<bool> GetActivityIsValid(string operatorId, string currencyId, ActivityType activityType)
        {
            var allActivitys = LobbyDbCacheUtil.GetAllActivityOperator(operatorId, currencyId);

            if (allActivitys == null || !allActivitys.Any())
                return false;

            if (!allActivitys.Any(d => d.ActivityID == (int)activityType && d.Status))
                return false;

            return true;
        }

        /// <summary>
        /// 全部有效活动
        /// </summary>
        /// <param name="operatorId"></param>
        /// <param name="currencyId"></param>
        /// <returns></returns>
        public static async Task<List<ActivityEventEntity>> GetAllValidActivity(string operatorId, string currencyId)
        {
            var cache = new ActivityListDCache(operatorId, currencyId);

            var cacheData = await cache.GetAsync();

            //如果未配置任何活动或活动全部已过期
            if (cacheData == null
                || !cacheData.HasValue)
                return new List<ActivityEventEntity>();

            return cacheData.Value;
        }


        /// <summary>
        /// 查询当前运营商编码查询当天数据区间
        /// </summary>
        /// <param name="operatorId"></param>
        /// <returns></returns>
        public static (DateTime startTime, DateTime endTime) GetDBTimeInterval(string operatorId)
        {
            var utcTime = DateTime.UtcNow;
            (DateTime startTime, DateTime endTime) ret = new(utcTime, utcTime);

            var countryEo = DbCacheUtil.GetCountryByOperatorId(operatorId);
            var localTime = utcTime.AddHours(countryEo.TimeZone);
            var timeZoneAbs = Math.Abs(countryEo.TimeZone);

            ret.startTime = new DateTime(localTime.Year, localTime.Month, localTime.Day, timeZoneAbs, 0, 0);
            ret.endTime = ret.startTime.AddDays(1);

            return ret;
        }


        /// <summary>
        /// 获取可提现金额
        /// </summary>
        /// <returns></returns>
        public static async Task<long> GetAllowCashAmount(string userId, string currencyId, TransactionManager tm = null)
        {
            UserService userService = new UserService(userId);

            S_requireflow_orderMO requireflowOrderMo = userService.GetRequireflowOrderMo();

            long ret = 0;
            var requireFlowOrder = await requireflowOrderMo.GetSingleAsync("UserID = @UserID and Status = 0", tm, userId);

            if (requireFlowOrder == null)
                ret = await userService.GetBalance(currencyId, tm, true);

            return ret;
        }

        /// <summary>
        /// 获取提现需要完成的流水金额
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="tm"></param>
        /// <returns></returns>
        public static async Task<long> GetSumRequireFlow(string userId, TransactionManager tm = null)
        {
            long ret = 0;

            var selectSql = $@"select  
	                                SUM(RequireFlow) - SUM(CompletedFlow)
                                from s_requireflow_order 
                                where UserID = @UserID
                                and `Status` = 0";

            var orderAmount = await DbSink.MainDb.ExecSqlScalarAsync<long?>(selectSql, tm, userId);

            if (orderAmount.HasValue)
                ret = orderAmount.Value;

            return ret;
        }

        /// <summary>
        /// 获取用户提现需要完成的流水、已完成的流水（只计算正常打码完成的、未完成的订单）
        /// </summary>
        /// <param name="userId"></param>
        /// <param name=""></param>
        /// <param name="tm"></param>
        /// <returns></returns>
        public static async Task<SumRequireFlow> GetRequireFlows(string userId, TransactionManager tm = null)
        {
            var ret = new SumRequireFlow();

            var selectSql = $@"select  
	                                SUM(RequireFlow) as requireFlow,
                                    SUM(CompletedFlow) as completedFlow
                                from s_requireflow_order 
                                where UserID = @UserID
                                and Status in (0,1)";

            ret = await DbSink.MainDb.ExecSqlSingleAsync<SumRequireFlow>(selectSql, tm, userId);

            return ret;
        }

        /// <summary>
        /// 获取当前运营商配置的所有活动
        /// </summary>
        /// <param name="operatorId">运营商编码</param>
        /// <param name="currencyId">货币编码</param>
        /// <param name="IsEnable">true只查开启中的活动，false查所有</param>
        /// <returns></returns>
        public static async Task<List<L_activity_operatorEO>> GetOperatorActivity(string operatorId, string currencyId, bool IsEnable = true)
        {
            var ret = new List<L_activity_operatorEO>();

            var cache = await new ActivityOperatorBaseDCache(operatorId, currencyId).GetAsync();

            if (cache.HasValue)
                ret = cache.Value;

            if (IsEnable)
                ret = cache.Value.Where(d => d.Status).ToList();

            return ret;
        }

        /// <summary>
        /// 更新用户活动状态
        /// </summary>
        /// <param name="userId">用户编码</param>
        /// <param name="operatorId">运营商编码</param>
        /// <param name="currencyId">货币编码</param>
        /// <param name="activityType">活动类型</param>
        /// <param name="tm"></param>
        /// <returns></returns>
        public static async Task<bool> UpdateUserActivity(string userId, string operatorId, string currencyId, ActivityType activityType, TransactionManager tm = null)
        {
            //获取全部有效活动
            var activityOperator = await GetOperatorActivity(operatorId, currencyId);
            //如果包含当前活动，并且活动允许结束
            if (activityOperator.Any(d => d.ActivityID == (int)activityType && d.IsAllowEnd))
            {
                await new L_user_activityMO().PutAsync("IsInvolved = 1", "UserID = @UserID and ActivityId = @ActivityId", tm, userId, (int)activityType);
            }

            return true;
        }

        /// <summary>
        /// 获取一条活动配置
        /// </summary>
        /// <param name="operatorId"></param>
        /// <param name="currencyId"></param>
        /// <param name="activityType"></param>
        /// <param name="tm"></param>
        /// <returns></returns>
        public static async Task<L_activity_operatorEO> GetSingleActivityAsync(string operatorId, string currencyId, ActivityType activityType, TransactionManager tm = null)
        {
            return await new L_activity_operatorMO().GetSingleAsync("ActivityID = @ActivityID and OperatorID = @OperatorID and CurrencyID = @CurrencyID and Status=1", (int)activityType, operatorId, currencyId);
        }



        /// <summary>
        /// 查询用户当天充值总额
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="operatorId"></param>
        /// <returns></returns>
        public static async Task<long> UserCurrentDaySumPay(string userId, string operatorId)
        {
            var timeInterval = GetDBTimeInterval(operatorId);

            var sql = $@"select sum(Amount) from sb_bank_order 
                                where OrderType = 1 
                                and `Status` = 2 
                                and UserID = @UserId
                                and BankCallbackTime >= @StartTime
                                and BankCallbackTime < @endTime;";

            //判断是否满足补签的充值要求
            var SumPayAmount = await DbSink.MainDb.ExecSqlScalarAsync<long?>(sql, userId, timeInterval.startTime, timeInterval.endTime);

            if (SumPayAmount.HasValue)
                return SumPayAmount.Value;

            return 0;
        }

        /// <summary>
        /// 获取bank成功率最高的支付渠道
        /// </summary>
        /// <returns></returns>
        public static async Task<Dictionary<string, long>> GetAllBankChannel()
        { 
            var ret = new Dictionary<string, long>();

            try
            {
                //bank端支付渠道成功率权重
                return await new BankErrorDCache().GetAllAsync();
            }
            catch (Exception ex)
            {
                LogUtil.GetContextLogger().AddException(ex).AddMessage($"LobbyUtil.GetAllBankChannel.从缓存获取BankError异常");
                return ret;
            }
        }

        /// <summary>
        /// 获取充值、提现渠道
        /// </summary>
        /// <param name="operatorId"></param>
        /// <param name="currencyId"></param>
        /// <param name="countryId"></param>
        /// <returns></returns>
        public static async Task<BraPayChannel> GetPayChannel(string operatorId, string currencyId, string countryId)
        {
            //默认渠道tejeepay
            var ret = BraPayChannel.letspay;
            switch (countryId)
            {
                case "MEX":
                    ret = BraPayChannel.letspay;
                    break;
                default:
                    break;
            }
            //bank记录的所有支付记录成功or失败次数记录
            var bankErrorDic = await LobbyUtil.GetAllBankChannel();
            var payConfigEoList = await new PayConfigDCache().GetAsync(operatorId, currencyId);

            //bank缓存没有数据
            if (bankErrorDic == null || bankErrorDic.Count == 0 || bankErrorDic.Keys.Count == 0)
            {
                if (!payConfigEoList.Any())
                    return ret;

                //默认取第一条主渠道
                var payConfigEo = payConfigEoList.Where(d => d.IsMainChannel)?.FirstOrDefault();
                //如果没有设置主渠道，则直接获取最新的支付渠道
                if (payConfigEo == null)
                {
                    payConfigEo = payConfigEoList.OrderByDescending(d => d.Channels).FirstOrDefault();
                }

                var payConfigEoChannel = payConfigEo.ChannelsDesc.ToEnumN<BraPayChannel>();
                if (!payConfigEoChannel.HasValue)
                    return ret;
                return payConfigEoChannel.Value;
            }
            //bank缓存有数据
            else
            {
                //如果大厅缺少支付渠道配置，则从缓存拿成功率最高的支付渠道
                if (!payConfigEoList.Any())
                {
                    //值越小成功率越高
                    var bankError = bankErrorDic.OrderBy(d => d.Value).First();
                    var bankErrorEnum = bankError.Key.ToEnumN<BraPayChannel>();
                    if (!bankErrorEnum.HasValue)
                        return ret;
                    return bankErrorEnum.Value;
                }
                else
                {
                    var payConfigChannel = payConfigEoList.Select(d => d.ChannelsDesc).Distinct().ToList();
                    var existsChannel = false;
                    foreach (var item in bankErrorDic.OrderBy(d => d.Value))
                    {
                        var channel = item.Key.ToEnumN<BraPayChannel>();
                        if (!channel.HasValue)
                            continue;

                        if (payConfigChannel.Contains(item.Key))
                        {
                            ret = item.Key.ToEnum<BraPayChannel>();
                            existsChannel = true;
                            break;
                        }
                    }
                    if (!existsChannel)
                        return ret;
                }
            }

            return ret;
        }

    }

    /// <summary>
    /// 流水聚合
    /// </summary>
    public class SumRequireFlow
    {
        public long? RequireFlow { get; set; } = 0;

        public long? CompletedFlow { get; set; } = 0;
    }

}
