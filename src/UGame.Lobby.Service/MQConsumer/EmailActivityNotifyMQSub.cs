using EasyNetQ;
using UGame.Lobby.Common.Enum;
using UGame.Lobby.Repository.ing;
using Newtonsoft.Json;
using AiUo;
using AiUo.BIZ.RabbitMQ;
using AiUo.Data;
using AiUo.Extensions.RabbitMQ;
using AiUo.Extensions.StackExchangeRedis;
using AiUo.Logging;
using UGame.Lobby.Service.Common;
using Xxyy.Common;
using Xxyy.Common.Services;
using Xxyy.MQ.Lobby.Activity;
using Xxyy.MQ.Lobby.Notify;
using Xxyy.MQ.Xxyy;

namespace UGame.Lobby.Service.MQConsumer;

public class EmailActivityNotifyMQSub : MQBizSubConsumer<EmailActivityNotifyMsg>
{

    /// <summary>
    /// 构造方法
    /// </summary>
    public EmailActivityNotifyMQSub()
    {
        AddHandler(Handle);
    }

    public override MQSubscribeMode SubscribeMode => MQSubscribeMode.OneQueue;
    protected override void Configuration(ISubscriptionConfiguration config)
    {
    }
    protected override Task OnMessage(EmailActivityNotifyMsg message, CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }

    private async Task Handle(EmailActivityNotifyMsg message, CancellationToken cancellationToken)
    {
        try
        {
            switch (message.SourceType)
            {
                //输返活动
                case (int)ActivityType.LoseCashBack:
                    //更新领取状态
                    await LoseCashBackHandler(message);
                    break;
                case (int)ActivityType.Vip:
                case (int)ActivityType.VipWeek:
                    await VipRewardHandler(message);
                    break;
                //好友邀请分享
                case (int)ActivityType.InvitationNewUser100011:
                    await InviteNewUserHandler(message);
                    break;
                case (int)ActivityType.RebateWater:
                case (int)ActivityType.RebateWaterWeekly:
                case (int)ActivityType.RebateWaterMonthly:
                    await RebateWaterBackHandler(message);
                    break;
                case (int)ActivityType.InviteNewUser100013:
                    await InviteNewUser100013Handler(message);
                    break;
                default:
                    throw new CustomException($"未找到活动类型");
            }
        }
        catch (Exception ex)
        {
            if (ex is not CustomException)
            {
                LogUtil.GetContextLogger().AddException(ex).AddMessage($"ActivityNotifyEmailCommandHandler.request:{JsonConvert.SerializeObject(message)}");
            }
        }
    }
    /// <summary>
    /// 返水活动
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    private async Task<bool> RebateWaterBackHandler(EmailActivityNotifyMsg request)
    {
        using var lockObj = await RedisUtil.LockAsync($"RebateWater.{request.UserId}.{request.SourceId}", 5);
        if (!lockObj.IsLocked)
        {
            lockObj.Release();
            throw new CustomException(CommonCodes.UserConcurrent, $"lobby:RebateWaterBackHandler:Request for lock failed.Key:RebateWater.{request.UserId}.{request.SourceId}");
        }
        bool result = false;
        CurrencyChangeMsg changedMsg = null;
        TransactionManager tm = new TransactionManager();
        try
        {
            //查询当前活动配置
            var activityOperator = await LobbyUtil.GetSingleActivityAsync(request.OperatorId, request.CurrencyId, (ActivityType)request.SourceType);
            if (activityOperator == null)
                return false;

            var rebateUserDetailMo = new Sa_rebate_user_detailMO();
            var rebateDetailInfo = await rebateUserDetailMo.GetByPKAsync(request.SourceId);
            if (rebateDetailInfo != null && rebateDetailInfo.ReceiveStatus == 1)
                return false;

            var quartzConfigService = new Sa_rebate_quartz_configMO();
            var quartzConfigInfo = await quartzConfigService.GetSingleAsync("OperatorID=@OperatorID and CurrencyID=@CurrencyID and ActivityID=@ActivityID",
                 request.OperatorId, request.CurrencyId, request.SourceType);
            if (quartzConfigInfo == null)
                return false;

            //更新领取状态
            var updateTime = DateTime.UtcNow;
            var sql = $"update sa_rebate_user_detail set ReceiveStatus=1,UpdateTime='{updateTime:yyyy-MM-dd HH:mm:ss}' where DetailID='{request.SourceId}'";
            await rebateUserDetailMo.Database.ExecSqlNonQueryAsync(sql, tm);

            var currencyChangeService = new CurrencyChangeService(request.UserId);
            var changeBalanceType = activityOperator.IsBonus ? CurrencyChangeBalance.Bonus : CurrencyChangeBalance.Cash;
            //调用currencyChangeService
            var frequency = request.SourceType switch
            {
                2 => "每周",
                3 => "每月",
                _ => "每日"
            };
            var currencyChangeReq = new CurrencyChangeReq()
            {
                UserId = request.UserId,
                AppId = request.AppId,
                OperatorId = request.OperatorId,
                CurrencyId = request.CurrencyId,
                ChangeBalance = changeBalanceType,
                FlowMultip = request.FlowMultip,
                Reason = $"{frequency}返水奖励",
                Amount = rebateDetailInfo.RebateAmount,
                SourceType = request.SourceType,
                SourceTable = request.SourceTable,
                SourceId = request.SourceId,
                ChangeTime = updateTime,
                TM = tm
            };

            changedMsg = await currencyChangeService.Add(currencyChangeReq);
            if (changedMsg == null)
                throw new Exception("写入s_currency_change失败");
            tm.Commit();

            await MQUtil.PublishAsync(changedMsg);
            await MQUtil.PublishAsync(new UserActivityMsg()
            {
                UserId = request.UserId,
                ActivityType = request.SourceType
            });
            result = true;
        }
        catch (Exception ex)
        {
            tm.Rollback();
            LogUtil.GetContextLogger().AddException(ex)
                .AddField("Source", "RebateWaterBackHandler")
                .AddField("Request", JsonConvert.SerializeObject(request))
                .AddField("UserId", request.UserId);
            result = false;
        }
        return result;
    }

    /// <summary>
    /// 输返活动
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    private async Task<bool> LoseCashBackHandler(EmailActivityNotifyMsg request)
    {
        TransactionManager tm = new TransactionManager();

        try
        {
            var loseCashBackDetailMo = new Sa_losecashback_detailMO();

            var detail = await loseCashBackDetailMo.GetSingleAsync("DetailID = @DetailID", tm, request.SourceId);

            if (detail != null && detail.ReceiveStatus == 1)
            {
                throw new CustomException($"输返奖励重复领取");
            }
            //更新领取状态
            await loseCashBackDetailMo.PutReceiveStatusByPKAsync(request.SourceId, 1, tm);
            //更新l_user_activity
            await new L_user_activityMO().PutAsync("IsInvolved = 1", "UserID = @UserID and ActivityId = @ActivityId", tm, request.UserId, (int)ActivityType.LoseCashBack);

            var currencyChangeService = new CurrencyChangeService(request.UserId);

            //查询当前活动配置
            var activityOperator = await LobbyUtil.GetSingleActivityAsync(request.OperatorId, request.CurrencyId, ActivityType.LoseCashBack);
            if (activityOperator == null)
                throw new Exception($@"l_activity_operator表活动{(int)ActivityType.LoseCashBack}不存在.");

            //调用currencyChangeService
            var currencyChangeReq = new CurrencyChangeReq()
            {
                UserId = request.UserId,
                AppId = request.AppId,
                OperatorId = request.OperatorId,
                CurrencyId = request.CurrencyId,
                ChangeBalance = activityOperator.IsBonus ? CurrencyChangeBalance.Bonus : CurrencyChangeBalance.Cash,
                FlowMultip = request.FlowMultip,//不需要流水
                Reason = "输返活动返还",
                Amount = request.Amount.MToA(request.CurrencyId),
                SourceType = request.SourceType,
                SourceTable = request.SourceTable,
                SourceId = request.SourceId,
                ChangeTime = DateTime.UtcNow,
                TM = tm
            };
            var changeMsg = await currencyChangeService.Add(currencyChangeReq);
            if (changeMsg == null)
                throw new Exception("写入s_currency_change失败");

            tm.Commit();
            await MQUtil.PublishAsync(changeMsg);

            await MQUtil.PublishAsync(new UserActivityMsg()
            {
                UserId = request.UserId,
                ActivityType = (int)ActivityType.LoseCashBack
            });

            return true;
        }
        catch (Exception ex)
        {
            tm.Rollback();
            if (ex is not CustomException)
            {
                LogUtil.GetContextLogger().AddException(ex).AddMessage($"ActivityNotifyEmailCommandHandler.LoseCashBackHandler.request:{JsonConvert.SerializeObject(request)}");
            }
            return false;
        }
    }

    /// <summary>
    /// vip领取奖励(升级奖励，周奖励)
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    private async Task<bool> VipRewardHandler(EmailActivityNotifyMsg request)
    {
        TransactionManager tm = new TransactionManager();
        try
        {
            Sc_vip_reward_detailMO _vipRewardDetailMO = new();
            var detail = await _vipRewardDetailMO.GetSingleAsync("DetailID=@DetailId", tm, request.SourceId);
            if (detail == null || detail.ReceiveStatus == 1)
            {
                tm.Rollback();
                return false;
            }
            await _vipRewardDetailMO.PutReceiveStatusByPKAsync(request.SourceId, 1, tm);
            var currencyChangeService = new CurrencyChangeService(request.UserId);
            var _reason = detail.RewardType == 1 ? $"升级vip{detail.VipGrade}发放升级奖励" : $"vip{detail.VipGrade}发放周奖励";
            var currencyChangeReq = new CurrencyChangeReq
            {
                UserId = request.UserId,
                AppId = request.AppId,
                OperatorId = request.OperatorId,
                CurrencyId = request.CurrencyId,
                ChangeBalance = CurrencyChangeBalance.Bonus,
                FlowMultip = detail.FlowMultip,// 所获赠金提现所需要的流水倍数
                Reason = _reason,
                Amount = detail.RewardAmount,
                SourceType = request.SourceType,
                SourceTable = request.SourceTable,
                SourceId = detail.DetailID,
                ChangeTime = DateTime.UtcNow,
                TM = tm
            };
            var changeMsg = await currencyChangeService.Add(currencyChangeReq);
            if (changeMsg == null)
                throw new Exception("vip奖励发放时，更新currencychange时失败");

            tm.Commit();
            await MQUtil.PublishAsync(changeMsg);

            return true;
        }
        catch (Exception ex)
        {
            tm.Rollback();
            if (ex is not CustomException)
            {
                LogUtil.GetContextLogger().AddException(ex).AddMessage($"ActivityNotifyEmailCommandHandler.VipRewardHandler.request:{JsonConvert.SerializeObject(request)}");
            }
            return false;
        }
    }

    /// <summary>
    /// 好友邀请分享
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    private async Task<bool> InviteNewUserHandler(EmailActivityNotifyMsg request)
    {
        TransactionManager tm = new TransactionManager();
        try
        {
            //1、查询当前奖励是否已被领取
            var inviteDetailMo = new Sa_invite100011_detailMO();
            var detail = await inviteDetailMo.GetByPKAsync(request.SourceId, tm, true);

            if (detail == null || detail.ReceiveStatus)
                throw new CustomException(LobbyCodes.RS_UNKNOWN, $@"重复领取奖励");

            //2、更新领取状态
            await inviteDetailMo.PutReceiveStatusByPKAsync(request.SourceId, true, tm);

            //3、查询当前活动配置
            var activityOperator = await new L_activity_operatorMO().GetSingleAsync("ActivityID = @ActivityID and OperatorID = @OperatorID and CurrencyID = @CurrencyID", (int)ActivityType.InvitationNewUser100011, request.OperatorId, request.CurrencyId);
            if (activityOperator == null)
                throw new Exception($@"l_activity_operator表活动不存在.");

            //4、CurrencyChangeService.Add
            var currencyChangeService = new CurrencyChangeService(request.UserId);
            var currencyChangeReq = new CurrencyChangeReq
            {
                UserId = request.UserId,
                AppId = request.AppId,
                OperatorId = request.OperatorId,
                CurrencyId = request.CurrencyId,
                //IsBonus = activityOperator.IsBonus,
                ChangeBalance = activityOperator.IsBonus ? CurrencyChangeBalance.Bonus : CurrencyChangeBalance.Cash,
                FlowMultip = detail.FlowMultip,
                Reason = detail.RewardType == 1 ? "好友邀请分享-充值奖励" : "好友邀请分享-邀请好友数量月奖励",
                Amount = detail.Bonus,
                SourceType = request.SourceType,
                SourceTable = request.SourceTable,
                SourceId = detail.DetailID,
                ChangeTime = DateTime.UtcNow,
                TM = tm
            };

            var changeMsg = await currencyChangeService.Add(currencyChangeReq);
            if (changeMsg == null)
                throw new Exception("currencyChangeService.Add失败");

            //5、CurrencyChangeService.PublishMQ
            //await currencyChangeService.PublishMQ(currencyChangeReq);
            await MQUtil.PublishAsync(changeMsg);

            await MQUtil.PublishAsync(new UserActivityMsg()
            {
                UserId = request.UserId,
                ActivityType = (int)ActivityType.InvitationNewUser100011
            });

            tm.Commit();
            return true;
        }
        catch (Exception ex)
        {
            tm.Rollback();
            if (ex is not CustomException)
            {
                LogUtil.GetContextLogger().AddException(ex).AddMessage($"ActivityNotifyEmailCommandHandler.100011.request:{JsonConvert.SerializeObject(request)}");
            }
            return false;
        }
    }

    /// <summary>
    /// 新版好友邀请分享
    /// </summary>
    /// <returns></returns>
    private async Task<bool> InviteNewUser100013Handler(EmailActivityNotifyMsg request)
    {
        TransactionManager tm = new TransactionManager();
        try
        {
            //1、查询当前奖励是否已被领取
            var inviteDetailMo = new Sa_invite100013_detailMO();
            var detail = await inviteDetailMo.GetByPKAsync(request.SourceId, tm, true);

            if (detail == null || detail.ReceiveStatus)
                throw new CustomException(LobbyCodes.RS_UNKNOWN, $@"重复领取奖励");

            //2、更新领取状态
            await inviteDetailMo.PutReceiveStatusByPKAsync(request.SourceId, true, tm);

            //3、查询当前活动配置
            var activityOperator = await new L_activity_operatorMO().GetSingleAsync("ActivityID = @ActivityID and OperatorID = @OperatorID and CurrencyID = @CurrencyID", (int)ActivityType.InviteNewUser100013, request.OperatorId, request.CurrencyId);
            if (activityOperator == null)
                throw new Exception($@"l_activity_operator表活动不存在.");

            //4、CurrencyChangeService.Add
            var currencyChangeService = new CurrencyChangeService(request.UserId);
            var currencyChangeReq = new CurrencyChangeReq
            {
                UserId = request.UserId,
                AppId = request.AppId,
                OperatorId = request.OperatorId,
                CurrencyId = request.CurrencyId,
                ChangeBalance = activityOperator.IsBonus ? CurrencyChangeBalance.Bonus : CurrencyChangeBalance.Cash,
                FlowMultip = detail.FlowMultip,
                Reason = "好友邀请分享-邀请好友数量奖励",
                Amount = detail.Bonus,
                SourceType = request.SourceType,
                SourceTable = request.SourceTable,
                SourceId = detail.DetailID,
                ChangeTime = DateTime.UtcNow,
                TM = tm
            };

            var changeMsg = await currencyChangeService.Add(currencyChangeReq);
            if (changeMsg == null)
                throw new Exception("currencyChangeService.Add失败");

            tm.Commit();

            await MQUtil.PublishAsync(changeMsg);

            return true;
        }
        catch (Exception ex)
        {
            tm.Rollback();
            if (ex is not CustomException)
            {
                LogUtil.GetContextLogger().AddException(ex).AddMessage($"ActivityNotifyEmailCommandHandler.InviteNewUser100013Handler.request:{JsonConvert.SerializeObject(request)}");
            }
            return false;
        }
    }
}
