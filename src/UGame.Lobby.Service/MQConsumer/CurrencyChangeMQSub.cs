using EasyNetQ;
using Lobby.Flow;
using Lobby.Flow.Services;
using AiUo.BIZ.RabbitMQ;
using AiUo.Extensions.RabbitMQ;
using Xxyy.Common;
using Xxyy.Common.Caching;
using Xxyy.MQ.Xxyy;

namespace UGame.Lobby.Service.MQConsumer;

public class CurrencyChangeMQSub : MQBizSubConsumer<CurrencyChangeMsg>
{
    public CurrencyChangeMQSub()
    {
        AddHandler(AddRequireFlowOrder);
        ////计算可提现额-提现时
        //AddHandler(DealWithdrawUserWhenCash);
        ////计算可提现额-活动赠送真金
        //AddHandler(DealBalanceWhenActivity);
    }

    //private async Task DealBalanceWhenActivity(CurrencyChangeMsg msg, CancellationToken token)
    //{
    //    var withdrawUserSvc = WithdrawUserServiceFactory.Create();
    //    await withdrawUserSvc.DealCurrencyChange(msg);
    //}

    //private async Task DealWithdrawUserWhenCash(CurrencyChangeMsg msg, CancellationToken token)
    //{
    //    var withdrawUserSvc = WithdrawUserServiceFactory.Create();
    //    await withdrawUserSvc.DealUserCash(msg);
    //}

    public override MQSubscribeMode SubscribeMode => MQSubscribeMode.OneQueue;

    protected override void Configuration(ISubscriptionConfiguration config)
    {
    }

    protected override Task OnMessage(CurrencyChangeMsg message, CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }

    private async Task AddRequireFlowOrder(CurrencyChangeMsg message, CancellationToken cancellationToken)
    {
        //var currencyType = DbCacheUtil.GetCurrencyType(message.CurrencyId);

        //if (!(currencyType == CurrencyType.Cash && message.Amount > 0 && message.FlowMultip > 0))
        //    return;

        // s_requireflow_order
        var flowService = FlowServiceFactory.CreateFlowService(message.UserId, message.AppId, message.OperatorId);
        await flowService.DealCurrencyChangeMsg(message);
    }
}
