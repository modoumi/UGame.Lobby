using EasyNetQ;
using Lobby.Flow;
using Newtonsoft.Json;
using AiUo;
using AiUo.BIZ.RabbitMQ;
using AiUo.DbCaching;
using AiUo.Extensions.RabbitMQ;
using AiUo.Logging;
using Xxyy.Common.Caching;
using Xxyy.DAL;
using Xxyy.MQ.Bank;
using Xxyy.MQ.Email;
using Xxyy.SMS;

namespace UGame.Lobby.Service.MQConsumer;

public class UserCashMQSub : MQBizSubConsumer<UserCashMsg>
{  

    public UserCashMQSub()
    {
        //关于活动的，只需要发送一次
        AddHandler(SendNotifyEmail);
        AddHandler(SendNotifySMS);
        AddHandler(UpdateCashAuditCommand);
    }

    public override MQSubscribeMode SubscribeMode => MQSubscribeMode.OneQueue;

    protected override void Configuration(ISubscriptionConfiguration config)
    {
    }

    protected override Task OnMessage(UserCashMsg message, CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }

    private async Task UpdateCashAuditCommand(UserCashMsg msg, CancellationToken token)
    {
        var cashService = FlowServiceFactory.CreateFlowService(msg.UserId, msg.AppId, msg.OperatorId);
        await cashService.DealUserCashMsg(msg);
    }


    /// <summary>
    /// 发送站内邮件通知
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    private async Task SendNotifyEmail(UserCashMsg request, CancellationToken cancellationToken)
    {
        if (request.Status != 0) return;
        string templateId = "WithdrawNotice900001";
        var userCache = await GlobalUserDCache.Create(request.UserId);
        var operatorId = await userCache.GetOperatorIdAsync();
        var domainUrl = await userCache.GetRegistClientUrlAsync();
        if (string.IsNullOrEmpty(domainUrl))
        {
            var sOperator = DbCachingUtil.GetSingle<S_operatorPO>(operatorId);
            var domainUrls = sOperator.MapDomain.Split('|');
            domainUrl = domainUrls[0];
        }
        else
        {
            var index = domainUrl.IndexOf("/", 8);
            domainUrl = domainUrl.Substring(0, index);
        }
        await MQUtil.PublishAsync(new UserEmailMsg
        {
            TemplateId = templateId,
            TemplateKey = templateId,
            UserId = request.UserId,
            AppId = request.AppId,
            DisplayTag = 1,
            SenderId = "UserCashNotifyCommand",
            Content = JsonConvert.SerializeObject(new { domainUrl })
        });
    }

    /// <summary>
    /// 发送提现成功通知
    /// </summary>
    /// <param name="message"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    private async Task SendNotifySMS(UserCashMsg message, CancellationToken cancellationToken)
    {
        if (message.Status != 0) return;
        try
        {
            var userDCache = await GlobalUserDCache.Create(message.UserId);
            var mobile = await userDCache.GetMobileAsync();

            //没有手机号不发送短信
            if (string.IsNullOrWhiteSpace(mobile))
                return;

            //获取当前域名
            var operatorEo = DbCacheUtil.GetOperator(message.OperatorId);
            var lobbyUrl = operatorEo.MapDomain.Split('|', StringSplitOptions.RemoveEmptyEntries).First();

            var req = new XxyySmsIpo
            {
                Mobile = mobile,
                TemplateId = (int)SmsTemplateIds.CashNotify,
                LangId = "pt",
                ContentArgs = new List<object> { lobbyUrl },
                OperatorId = message.OperatorId,
                AppId = message.AppId,
            };
            var rsp = await XxyySmsUtil.SendAsync(req);

            if (!rsp.Success)
                throw new Exception($"request:{JsonConvert.SerializeObject(req)}.response:{JsonConvert.SerializeObject(rsp)}");

            return;
        }
        catch (Exception ex)
        {
            if (ex is not CustomException)
            {
                LogUtil.GetContextLogger().AddException(ex).AddMessage($"UserPayMQSub.SendNotifySMS.发送提现短信失败.error:{ex.Message}.message:{JsonConvert.SerializeObject(message)}");
            }
            return;
        }
    }
}
