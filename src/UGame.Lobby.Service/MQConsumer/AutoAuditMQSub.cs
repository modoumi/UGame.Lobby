using EasyNetQ;
using Lobby.Flow;
using AiUo.BIZ.RabbitMQ;
using AiUo.Extensions.RabbitMQ;
using Xxyy.MQ.Lobby;

namespace UGame.Lobby.Service.MQConsumer
{
    public class AutoAuditMQSub : MQBizSubConsumer<AutoAuditMsg>
    {
        public override MQSubscribeMode SubscribeMode => MQSubscribeMode.OneQueue;

        public AutoAuditMQSub()
        {
            AddHandler(AutoAuditRefuseAfter24Hours);
        }

        private async Task AutoAuditRefuseAfter24Hours(AutoAuditMsg msg, CancellationToken token)
        {
            var flowSvc = FlowServiceFactory.CreateFlowService(msg.UserId,msg.AppId,msg.OperatorId);
            await flowSvc.AutoReturnAfter24Hours(msg);
        }

        protected override void Configuration(ISubscriptionConfiguration config)
        {
            
        }

        protected override Task OnMessage(AutoAuditMsg message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
