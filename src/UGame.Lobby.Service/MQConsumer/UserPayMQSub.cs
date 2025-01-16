using EasyNetQ;
using UGame.Lobby.Common.Enum;
using Lobby.Flow;
using Lobby.Flow.Services;
using MediatR;
using Newtonsoft.Json;
using AiUo;
using AiUo.BIZ.RabbitMQ;
using AiUo.Data.SqlSugar;
using AiUo.DbCaching;
using AiUo.Extensions.RabbitMQ;
using AiUo.Logging;
using UGame.Lobby.Service.Caching;
using UGame.Lobby.Service.Commands.Activity;
using Xxyy.Common;
using Xxyy.Common.Caching;
using Xxyy.DAL;
using Xxyy.MQ.Bank;
using Xxyy.MQ.Email;
using Xxyy.MQ.Xxyy;
using Xxyy.SMS;

namespace UGame.Lobby.Service.MQConsumer;

/// <summary>
/// 充值50%奖励活动
/// </summary>
public class UserPayMQSub : MQBizSubConsumer<UserPayMsg>
{
    

    public UserPayMQSub()
    {
        AddHandler(SendNotifyEmail);
        AddHandler(SendNotifySMS);
        //关于充值会触发的活动，只需要发送一次，业务代码在ActivityBaseCommandHandler中实现
        AddHandler(UpdatePayAwardData);
        AddHandler(UpdateSUserVip);
        AddHandler(AddRequireFlowOrder);
        ////计算可提现额
        //AddHandler(AddWithdrawConfigUser);
    }

    //private async Task AddWithdrawConfigUser(UserPayMsg msg, CancellationToken token)
    //{
    //    var withdrawUserService = WithdrawUserServiceFactory.Create();
    //    await withdrawUserService.DealUserPay(msg);
    //}

    public override MQSubscribeMode SubscribeMode => MQSubscribeMode.OneQueue;

    protected override void Configuration(ISubscriptionConfiguration config)
    {
    }

    protected override Task OnMessage(UserPayMsg message, CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }

    /// <summary>
    /// 发送充值短信通知
    /// </summary>
    /// <param name="message"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    /// <exception cref="CustomException"></exception>
    /// <exception cref="Exception"></exception>
    private async Task SendNotifySMS(UserPayMsg message, CancellationToken cancellationToken)
    {
        if (!message.IsAddBalance) return;

        try
        {
            var userDCache = await GlobalUserDCache.Create(message.UserId);
            var mobile = await userDCache.GetMobileAsync();

            //没有手机号不发送短信
            if (string.IsNullOrWhiteSpace(mobile)) return;

            //获取当前域名
            var operatorEo = DbCacheUtil.GetOperator(message.OperatorId);
            var lobbyUrl = operatorEo.MapDomain?.Split('|', StringSplitOptions.RemoveEmptyEntries).First();

            var req = new XxyySmsIpo
            {
                Mobile = mobile,
                TemplateId = (int)SmsTemplateIds.PayNotify,
                LangId = "pt",
                ContentArgs = new List<object> { lobbyUrl },
                OperatorId = message.OperatorId,
                AppId = message.AppId,
            };
            var rsp = await XxyySmsUtil.SendAsync(req);

            if (!rsp.Success) throw new Exception($"request:{JsonConvert.SerializeObject(req)}.response:{JsonConvert.SerializeObject(rsp)}");

            return;
        }
        catch (Exception ex)
        {
            if (ex is not CustomException)
            {
                LogUtil.GetContextLogger().AddException(ex).AddMessage($"UserPayMQSub.SendNotifySMS.发送充值短信失败.error:{ex.Message}.message:{JsonConvert.SerializeObject(message)}");
            }
            return;
        }
    }

    /// <summary>
    /// 发送站内邮件通知
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    private async Task SendNotifyEmail(UserPayMsg request, CancellationToken cancellationToken)
    {
        if (!request.IsAddBalance) return;

        string templateId = "DepositNotice800001";
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
            SenderId = "UserPayNotifyCommand",
            Content = JsonConvert.SerializeObject(new { domainUrl })
        });
    }

    private async Task UpdatePayAwardData(UserPayMsg message, CancellationToken cancellationToken)
    {
        LogUtil.GetContextLogger().AddMessage($"充值消息message:{JsonConvert.SerializeObject(message)}");
        var _mediator = DIUtil.GetService<IMediator>();
        var command = new ActivityBaseCommand
        {
            EventId = (int)ActivityEvent.Pay,
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
    public async Task UpdateSUserVip(UserPayMsg message, CancellationToken cancellationToken)
    {
        //长线版本，直接升级vip等级
        var sOperator = DbCacheUtil.GetOperator(message.OperatorId);
        if (sOperator.OperatorVersion == (int)OperatorVersionsEnum.longVersion)
        {
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

                if (vipConfigEo == null || vipConfigEo?.VipGrade <= userInfo.VIP) return;

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
    }

    private async Task AddRequireFlowOrder(UserPayMsg message, CancellationToken cancellationToken)
    {
        if (DbCacheUtil.GetCurrencyType(message.CurrencyId) != CurrencyType.Cash)
            return;

        //用户余额没变化时，不记录流水
        if (!message.IsAddBalance)
            return;

        // s_requireflow_order
        var flowService = FlowServiceFactory.CreateFlowService(message.UserId, message.AppId, message.OperatorId);
        await flowService.DealUserPayMsg(message);
    }
}
