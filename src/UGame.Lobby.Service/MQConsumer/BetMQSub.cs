using EasyNetQ;
using UGame.Lobby.Common.Enum;
using Lobby.Flow;
using Lobby.Flow.Services;
using MediatR;
using AiUo;
using AiUo.BIZ.RabbitMQ;
using AiUo.Data.SqlSugar;
using AiUo.Extensions.RabbitMQ;
using UGame.Lobby.Service.Caching;
using UGame.Lobby.Service.Commands.Activity;
using Xxyy.Common;
using Xxyy.Common.Caching;
using Xxyy.DAL;
using Xxyy.MQ.Xxyy;

namespace UGame.Lobby.Service.MQConsumer;

/// <summary>
/// 下注结算后消费端
/// </summary>
public class BetMQSub : MQBizSubConsumer<UserBetMsg>
{
    public override MQSubscribeMode SubscribeMode => MQSubscribeMode.OneQueue;

    public BetMQSub()
    {
        AddHandler(UpdateSRequireFlow);
        AddHandler(UpdateSUserVip1);
        //注册触发的活动
        AddHandler(AllActivityExecute);
        ////计算可提现额
        //AddHandler(AddWithdrawConfigUser);
    }

    //private async Task AddWithdrawConfigUser(UserBetMsg msg, CancellationToken token)
    //{
    //    var withdrawUserService = WithdrawUserServiceFactory.Create();
    //    await withdrawUserService.DealUserBet(msg);
    //}

    /// <summary>
    /// 下注触发的活动
    /// </summary>
    /// <param name="message"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    private async Task AllActivityExecute(UserBetMsg message, CancellationToken cancellationToken)
    {
        var _mediator = DIUtil.GetService<IMediator>();
        var command = new ActivityBaseCommand
        {
            EventId = (int)ActivityEvent.Bet,
            OperatorId = message.OperatorId,
            CurrencyId = message.CurrencyId,
            Data = message
        };
        await _mediator.Send(command);
    }

    /// <summary>
    /// 更新VIP相关
    /// </summary>
    /// <param name="message"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task UpdateSUserVip1(UserBetMsg message, CancellationToken cancellationToken)
    {
        if (message.BetType != 1 && message.BetType != 3) return;

        //长线版本，直接升级vip等级
        var sOperator = DbCacheUtil.GetOperator(message.OperatorId);
        if (sOperator.OperatorVersion == (int)OperatorVersionsEnum.longVersion)
        {
            //长线版本，真金+Bonus都作为vip升级的point
            var userSet = $"Point=Point+{message.BetAmount}";
            await DbSink.BuildUserMo(message.UserId).PutByPKAsync(message.UserId, userSet);

            //所有vip等级配置明细
            var vipConfigEoList = LobbyDbCacheUtil.GetOperatorVipConfigList(message.OperatorId);
            var userExInfo = await DbUtil.GetRepository<S_user_exPO>().GetFirstAsync(f => f.UserID == message.UserId);
            var userInfo = await DbUtil.GetRepository<S_userPO>().GetFirstAsync(f => f.UserID == message.UserId);
            var fromVipGrade = userInfo.VIP;
            var topVipGrade = 0;
            if (vipConfigEoList != null && vipConfigEoList.Count > 0)
            {
                var vipConfigEo = vipConfigEoList.Where
                    (_ => userInfo.Point >= _.BetMinAmount && userExInfo.TotalPayAmount >= _.PayStartAmount)
                    .OrderByDescending(_ => _.VipGrade)
                    .FirstOrDefault();

                if (vipConfigEo == null) return;

                userInfo.VIP = vipConfigEo.VipGrade;
                await DbUtil.UpdateAsync<S_userPO>(it => new S_userPO { VIP = vipConfigEo.VipGrade }, it => it.UserID == message.UserId);
                topVipGrade = vipConfigEo.VipGrade;
            }
            //长线版本发送vip升级消息
            await MQUtil.PublishAsync(new VipUpgradeMsg
            {
                UserId = message.UserId,
                Point = userInfo.Point,
                VipFrom = fromVipGrade,
                VipTo = topVipGrade,
                UpgradeTime = DateTime.UtcNow
            });
        }
        else
        {
            //短线版本，只有真金作为vip升级的point
            var betCash = message.BetAmount - message.BetBonus;
            if (betCash <= 0) return;
            var userSet = $"Point=Point+{betCash}";
            await DbSink.BuildUserMo(message.UserId).PutByPKAsync(message.UserId, userSet);
        }
    }

    /// <summary>
    /// 更新用户订单流水
    /// </summary>
    /// <param name="message"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    private async Task UpdateSRequireFlow(UserBetMsg message, CancellationToken cancellationToken)
    {
        //计算流水
        var flowService = FlowServiceFactory.CreateFlowService(message.UserId, message.AppId, message.OperatorId);
        await flowService.DealUserBetMsg(message);
    }

    protected override void Configuration(ISubscriptionConfiguration config)
    {
    }

    protected override Task OnMessage(UserBetMsg message, CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}
