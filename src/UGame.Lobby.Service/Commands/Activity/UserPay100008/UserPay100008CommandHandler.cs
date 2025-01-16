using UGame.Lobby.Common.Enum;
using UGame.Lobby.Repository.ing;
using MediatR;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using SqlSugar;
using AiUo;
using AiUo.Data;
using AiUo.Data.SqlSugar;
using AiUo.Extensions.RabbitMQ;
using AiUo.Logging;
using UGame.Lobby.Service.Caching;
using UGame.Lobby.Service.Commands.Activity.Base;
using UGame.Lobby.Service.Common;
using Xxyy.Common;
using Xxyy.Common.Services;
using Xxyy.MQ.Lobby.Activity;

namespace UGame.Lobby.Service.Commands.Activity.UserPay10008
{
    public class UserPay100008CommandHandler : IRequestHandler<UserPay100008Command, bool>
    {
        ILogger<UserPay100008CommandHandler> _logger;

        public UserPay100008CommandHandler()
        {
            _logger = LogUtil.CreateLogger<UserPay100008CommandHandler>();
        }

        public async Task<bool> Handle(UserPay100008Command request, CancellationToken cancellationToken)
        {

            if (request.ActivityIds != null && request.ActivityIds.Any() && !request.ActivityIds.Any(d => d.Equals(Convert.ToString((int)ActivityType.UserPay100008))))
                return true;

            //如果选择不参加bonus赠送，则直接return
            if (request.ReceiveBonus != 1)
                throw new CustomException(LobbyCodes.RS_UNKNOWN, "用户选择了充值不接受bonus");

            var tm = new DbTransactionManager();

            try
            {
                await tm.BeginAsync();

                //查询当前充值订单是否重复
                var whereExpression = Expressionable.Create<Sa_userpay100008_userPO>()
                                                .And(d => d.UserID.Equals(request.UserId) && d.OrderID.Equals(request.OrderID))
                                                .ToExpression();
                var detail = await tm.GetRepository<Sa_userpay100008_userPO>().GetFirstAsync(whereExpression);
                if (detail != null)
                    throw new Exception($"消息重复，当前订单bonus已发放.");

                if (!await IsExcute(request))
                    throw new CustomException("活动100004未完成.活动100008不执行");

                var timeNow = DateTime.UtcNow;
                //全局用户缓存
                GlobalUserDCacheEx globalUserDCacheEx = GlobalUserDCacheEx.Create(request.UserId, request.CurrencyId);
                //账户余额非充值变化服务
                var currencyChangeService = new CurrencyChange2Service(request.UserId);

                //活动100008配置
                var userPayConfig = LobbyDbCacheUtil.GetUserPay100008Config(request.OperatorId, request.CurrencyId);
                if (userPayConfig == null)
                    throw new Exception($"UserPay100008CommandHandler.sa_userpay100008_config不存在。operatoryId:{request.OperatorId},currencyId:{request.CurrencyId}");

                //正式测试时删除
                if (request.PayAmount < userPayConfig.PayAmountStart)
                    throw new CustomException("不满足100008起始充值金额");

                //当地日期
                var localDate = timeNow.ToLocalTime(request.OperatorId).Date;
                //每天可以参加几次每日充值
                if (userPayConfig.DayNumLimit > 0)
                {
                    //用户当日参加此活动次数
                    var activityCount = await tm.GetRepository<Sa_userpay100008_userPO>().CountAsync(d => d.UserID.Equals(request.UserId) && d.DayId == localDate.Date);

                    if (activityCount >= userPayConfig.DayNumLimit)
                        throw new CustomException("当天充值享受100008优惠充值");
                }

                //充值金额奖励区间
                var userPayDetailConfig = LobbyDbCacheUtil.GetAllUserPay100008DetailConfigs(request.OperatorId, request.CurrencyId);
                if(userPayDetailConfig == null || !userPayDetailConfig.Any())
                    throw new Exception($"UserPay100008CommandHandler.sa_userpay100008_detail_config不存在。operatoryId:{request.OperatorId},currencyId:{request.CurrencyId}");

                var detailConfig = userPayDetailConfig.Where(d => request.PayAmount >= d.PayAmountStart && request.PayAmount < d.PayAmountEnd).FirstOrDefault();

                if(detailConfig == null)
                    throw new Exception($"UserPay100008CommandHandler.sa_userpay100008_detail_config不存在。operatoryId:{request.OperatorId},currencyId:{request.CurrencyId}");


                //需要赠送的bonus
                var sendBonus = (long)(request.PayAmount * (decimal)detailConfig.SendBonusMultip);

                if (sendBonus > userPayConfig.SendBonusMax)
                    sendBonus = userPayConfig.SendBonusMax;

                detail = new Sa_userpay100008_userPO()
                {
                    UserID = request.UserId,
                    OperatorID = request.OperatorId,
                    CountryId = request.CountryId,
                    CurrencyID = request.CurrencyId,
                    OrderID = request.OrderID,
                    Bonus = sendBonus,
                    FlowMultip = userPayConfig.FlowMultip,
                    UserKind = (int)await globalUserDCacheEx.GetUserKind(),
                    FromMode = await globalUserDCacheEx.GetFromMode(),
                    FromId = await globalUserDCacheEx.GetFromId(),
                    DayId = localDate.Date,
                    RecDate = DateTime.UtcNow
                };

                await tm.GetRepository<Sa_userpay100008_userPO>().InsertAsync(detail);

                //查询当前活动配置
                var activityOperator = await LobbyUtil.GetSingleActivityAsync(request.OperatorId, request.CurrencyId, ActivityType.UserPay100008);
                if (activityOperator == null)
                    throw new Exception($@"l_activity_operator表活动{(int)ActivityType.UserPay100008}不存在.");

                var currencyChangeReq = new CurrencyChangeReq()
                {
                    UserId = request.UserId,
                    AppId = "lobby",
                    OperatorId = request.OperatorId,
                    CurrencyId = request.CurrencyId,
                    //IsBonus = activityOperator.IsBonus,
                    ChangeBalance = activityOperator.IsBonus ? CurrencyChangeBalance.Bonus : CurrencyChangeBalance.Cash,
                    FlowMultip = userPayConfig.FlowMultip,// 所获赠金提现所需要的流水倍数
                    Reason = "每日充值激励赠送bonus",
                    Amount = detail.Bonus,
                    SourceType = (int)ActivityType.UserPay100008,
                    SourceTable = "sb_bank_order",
                    SourceId = request.OrderID,
                    ChangeTime = DateTime.UtcNow,
                    DbTM = tm
                };

                //写入用户账户变化表
                var changeMsg = await currencyChangeService.Add(currencyChangeReq);
                if (changeMsg == null)
                    throw new Exception($"currencyChangeService.Add(currencyChangeReq) Error.currencyChangeReq:{JsonConvert.SerializeObject(currencyChangeReq)}");

                await tm.CommitAsync();

                //发送用户账户变化消息
                await MQUtil.PublishAsync(changeMsg);

                await MQUtil.PublishAsync(new UserActivityMsg()
                {
                    UserId = request.UserId,
                    ActivityType = (int)ActivityType.UserPay100008
                });

                #region 发通知

                var _mediator = DIUtil.GetService<IMediator>();
                var command = new UserPay100008NotifyCommand()
                {
                    UserId = request.UserId,
                    OperatorId = request.OperatorId,
                    CountryId = request.CountryId,
                    CurrencyId = request.CurrencyId,
                    Bonus = detail.Bonus,
                    FlowMultip = userPayConfig.FlowMultip,
                    IsSendNotify = request.IsSendNotify,
                    IsSendNotifyEmail = request.IsSendNotifyEmail,
                    RewardSourceId = request.OrderID,
                    RewardAmount = detail.Bonus,
                    Parameters = new { RewardAmount = detail.Bonus.AToM(request.CurrencyId) }
                };
                await _mediator.Send(command);

                #endregion

                return true;
            }
            catch (Exception ex)
            {
                await tm.RollbackAsync();
                if (ex is not CustomException)
                {
                    LogUtil.GetContextLogger().AddException(ex).AddMessage($"UserPay100008CommandHandler.error:{ex.Message}.request:{JsonConvert.SerializeObject(request)}");
                }
                return false;
            }
        }


        //public async Task<bool> Handle(UserPay100008Command request, CancellationToken cancellationToken)
        //{

        //    if (request.ActivityIds != null && request.ActivityIds.Any() && !request.ActivityIds.Any(d => d.Equals(Convert.ToString((int)ActivityType.UserPay100008))))
        //        return true;

        //    TransactionManager tm = new TransactionManager();
        //    try
        //    {
        //        if (!await IsExcute(request))
        //            throw new CustomException("活动100004未完成.活动100008不执行");

        //        var timeNow = DateTime.UtcNow;
        //        //全局用户缓存
        //        GlobalUserDCacheEx globalUserDCacheEx = GlobalUserDCacheEx.Create(request.UserId, request.CurrencyId);
        //        //账户余额非充值变化服务
        //        CurrencyChangeService currencyChangeService = new CurrencyChangeService(request.UserId);
        //        //如果选择不参加bonus赠送，则直接return
        //        if (request.ReceiveBonus != 1)
        //            throw new CustomException(LobbyCodes.RS_UNKNOWN, "用户选择了充值不接受bonus");

        //        //1、根据PayTime查询当前充值是否送过bonus
        //        var sql = $@"select * from sa_userpay100008_user where UserID = @UserID and OrderId = @OrderId;";
        //        var detail = await DbSink.MainDb.ExecSqlSingleAsync<Sa_userpay100008_userEO>(sql, tm, request.UserId, request.OrderID);

        //        if (detail != null)
        //            throw new Exception($"消息重复，当前订单bonus已发放.");

        //        //活动100008配置
        //        var userPayConfig = LobbyDbCacheUtil.GetUserPay100008Config(request.OperatorId, request.CurrencyId);
        //        if (userPayConfig == null)
        //            throw new Exception($"UserPay100008CommandHandler.sa_userpay100008_config不存在。operatoryId:{request.OperatorId},currencyId:{request.CurrencyId}");

        //        if (request.PayAmount < userPayConfig.PayAmountStart)
        //            throw new CustomException("不满足100008起始充值金额");

        //        var localDate = timeNow.ToLocalTime(request.OperatorId).Date;

        //        if (userPayConfig.DayNumLimit > 0)
        //        {
        //            //用户当日参加此活动次数
        //            var activityCount = await _userPayMo.GetCountAsync("UserId = @UserId and DayId = @DayId", tm, request.UserId, localDate);
        //            if (activityCount >= userPayConfig.DayNumLimit)
        //                throw new CustomException("当天充值享受100008优惠充值");
        //        }

        //        //需要赠送的bonus
        //        var sendBonus = (long)(request.PayAmount * (decimal)userPayConfig.SendBonusMultip);

        //        if (sendBonus > userPayConfig.SendBonusMax)
        //            sendBonus = userPayConfig.SendBonusMax;

        //        detail = new Sa_userpay100008_userEO()
        //        {
        //            UserID = request.UserId,
        //            OperatorID = request.OperatorId,
        //            CountryId = request.CountryId,
        //            CurrencyID = request.CurrencyId,
        //            OrderID = request.OrderID,
        //            Bonus = sendBonus,
        //            FlowMultip = userPayConfig.FlowMultip,
        //            UserKind = (int)await globalUserDCacheEx.GetUserKind(),
        //            FromMode = await globalUserDCacheEx.GetFromMode(),
        //            FromId = await globalUserDCacheEx.GetFromId(),
        //            DayId = localDate.Date,
        //            RecDate = DateTime.UtcNow
        //        };

        //        //写入赠送bonus明细表
        //        await _userPayMo.AddAsync(detail, tm);

        //        //查询当前活动配置
        //        var activityOperator = await LobbyUtil.GetSingleActivityAsync(request.OperatorId, request.CurrencyId, ActivityType.UserPay100008);
        //        if (activityOperator == null)
        //            throw new Exception($@"l_activity_operator表活动{(int)ActivityType.UserPay100008}不存在.");

        //        var currencyChangeReq = new CurrencyChangeReq()
        //        {
        //            UserId = request.UserId,
        //            AppId = "lobby",
        //            OperatorId = request.OperatorId,
        //            CurrencyId = request.CurrencyId,
        //            //IsBonus = activityOperator.IsBonus,
        //            ChangeBalance = activityOperator.IsBonus ? CurrencyChangeBalance.Bonus : CurrencyChangeBalance.Cash,
        //            FlowMultip = userPayConfig.FlowMultip,// 所获赠金提现所需要的流水倍数
        //            Reason = "每日充值激励赠送bonus",
        //            Amount = detail.Bonus,
        //            SourceType = (int)UGame.Lobby.Common.Enum.ActivityType.UserPay100008,
        //            SourceTable = "sb_bank_order",
        //            SourceId = request.OrderID,
        //            ChangeTime = DateTime.UtcNow,
        //            TM = tm
        //        };

        //        //写入用户账户变化表
        //        var changeMsg = await currencyChangeService.Add(currencyChangeReq);
        //        if (changeMsg == null)
        //            throw new Exception($"currencyChangeService.Add(currencyChangeReq) Error.currencyChangeReq:{JsonConvert.SerializeObject(currencyChangeReq)}");

        //        tm.Commit();
        //        //发送用户账户变化消息
        //        await MQUtil.PublishAsync(changeMsg);

        //        await MQUtil.PublishAsync(new UserActivityMsg()
        //        {
        //            UserId = request.UserId,
        //            ActivityType = (int)ActivityType.UserPay100008
        //        });

        //        #region 发通知

        //        var _mediator = DIUtil.GetService<IMediator>();
        //        var command = new UserPay100008NotifyCommand()
        //        {
        //            UserId = request.UserId,
        //            OperatorId = request.OperatorId,
        //            CountryId = request.CountryId,
        //            CurrencyId = request.CurrencyId,
        //            Bonus = detail.Bonus,
        //            FlowMultip = userPayConfig.FlowMultip,
        //            IsSendNotify = request.IsSendNotify,
        //            IsSendNotifyEmail = request.IsSendNotifyEmail,
        //            RewardSourceId = request.OrderID,
        //            RewardAmount = detail.Bonus,
        //            Parameters = new { RewardAmount = detail.Bonus.AToM(request.CurrencyId) }
        //        };
        //        await _mediator.Send(command);

        //        #endregion

        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        tm.Rollback();
        //        if (ex is not CustomException)
        //        {
        //            LogUtil.GetContextLogger().AddException(ex).AddMessage($"UserPay100008CommandHandler.error:{ex.Message}.request:{JsonConvert.SerializeObject(request)}");
        //        }
        //        return false;
        //    }
        //}

        /// <summary>
        /// 是否执行100008活动
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        private async Task<bool> IsExcute(UserPay100008Command request)
        {
            var activity = await LobbyUtil.GetActivityIsValid(request.OperatorId, request.CurrencyId, ActivityType.UserFirstPay5, ActivityEvent.Pay);

            _logger.LogInformation($"UserPay100008CommandHandler.request:{JsonConvert.SerializeObject(request)}.Activity:{JsonConvert.SerializeObject(activity)}");

            //100004充值活动已下架或过期
            if (!activity.IsValid)
                return true;

            //判断活动100004是否执行完成
            var userConfig = await new Sa_firstpay_user_configMO().GetByPKAsync(request.UserId);

            if (userConfig != null && userConfig.RemainTimes == 0)
                return true;

            return false;
        }

    }
}
