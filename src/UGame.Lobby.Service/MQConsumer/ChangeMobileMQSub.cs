using EasyNetQ;
using UGame.Lobby.Common.Enum;
using MediatR;
using Newtonsoft.Json;
using AiUo;
using AiUo.BIZ.RabbitMQ;
using AiUo.Extensions.RabbitMQ;
using AiUo.Logging;
using UGame.Lobby.Service.Commands.Activity;
using Xxyy.MQ.Xxyy;

namespace UGame.Lobby.Service.MQConsumer;

/// <summary>
/// 手机号绑定、变更消费端
/// </summary>
public class ChangeMobileMQSub : MQBizSubConsumer<ChangeMobileMsg>
{
    public override MQSubscribeMode SubscribeMode => MQSubscribeMode.OneQueue;

    /// <summary>
    /// 
    /// </summary>
    public ChangeMobileMQSub()
    {
        AddHandler(Main);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="message"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    private async Task Main(ChangeMobileMsg message, CancellationToken cancellationToken)
    {
        LogUtil.Info($"lobby.ChangeMobileMQSub.message:{JsonConvert.SerializeObject(message)}");
        if (!await CheckMsg(message))
            return;

        var _mediator = DIUtil.GetService<IMediator>();
        var notifyCommand = new ActivityBaseCommand();
        notifyCommand.EventId = (int)ActivityEvent.BindMobile;
        notifyCommand.OperatorId = message.OperatorId;
        notifyCommand.CurrencyId = message.CurrencyId;
        notifyCommand.Data = message;
        await _mediator.Send(notifyCommand);
    }

    /// <summary>
    /// 校验消息参数
    /// </summary>
    /// <param name="message"></param>
    /// <returns></returns>
    private async Task<bool> CheckMsg(ChangeMobileMsg message)
    {
        if (message == null
            || string.IsNullOrWhiteSpace(message.UserId)
            || string.IsNullOrWhiteSpace(message.OperatorId)
            || string.IsNullOrWhiteSpace(message.CountryId)
            || string.IsNullOrWhiteSpace(message.CurrencyId)
            || string.IsNullOrWhiteSpace(message.Mobile)
            )
            return false;
        return true;
    }

    protected override void Configuration(ISubscriptionConfiguration config)
    {
    }

    protected override Task OnMessage(ChangeMobileMsg message, CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}
