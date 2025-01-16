using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using AiUo;
using AiUo.Extensions.RabbitMQ;
using AiUo.Logging;
using AiUo.Text;
using UGame.Lobby.Service.Commands.Activity.Base.Command;
using UGame.Lobby.Service.Common;
using Xxyy.Common;
using Xxyy.MQ.Email;
using Xxyy.MQ.Lobby.Notify;

namespace UGame.Lobby.Service.Commands.Activity.Base.Handler
{
    public abstract class NotifyCommandHandlerBase<T> : INotifyCommandHandler<T, bool> where T : NotifyCommandBase
    {

        protected ILogger<NotifyCommandHandlerBase<T>> _logger;

        public NotifyCommandHandlerBase()
        {
            _logger = LogUtil.CreateLogger<NotifyCommandHandlerBase<T>>();
        }


        public virtual async Task<bool> Handle(T request, CancellationToken cancellationToken)
        {
            if (request.IsSendNotify)
            {
                //发送弹框通知
                await SendNotify(request);
            }

            if (request.IsSendNotifyEmail)
            {
                //发送邮件通知
                await SendNotifyEmail(request);
            }

            //回调
            //await request.AfterNofifyFunc(request.RewardSourceId);

            return true;
        }

        /// <summary>
        /// 发送弹框通知
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        private async Task<bool> SendNotify(NotifyCommandBase request)
        {
            var Notifies = new List<Notify>();
            var NotifyUsers = new List<NotifyUser>();
            var NotifyDetails = new List<NotifyDetail>();

            try
            {
                var notifyId = ObjectId.NewId();
                Notifies.Add(new Notify()
                {
                    NotifyId = notifyId,
                    AppId = request.AppId,
                    OperatorId = request.OperatorId,
                    ActionAt = 3, //登录后
                    ShowAt = 1, //首页
                    UserScope = 1, //指定用户
                    Position = 3, //底部
                    ShowTimes = 1,
                    ShowInterval = 0,
                    CloseInterval = 5,
                    OrderNum = 0, //排序
                    BeginDate = DateTime.UtcNow,
                    EndDate = DateTime.MaxValue.AddDays(-1),
                    Status = 1,
                    RecDate = DateTime.UtcNow
                });

                NotifyUsers.Add(new NotifyUser()
                {
                    NotifyId = notifyId,
                    UserId = request.UserId
                });

                //获取通知模板
                var notifyTempEo = await LobbyUtil.GetNotifyTemplate(request.OperatorId, request.CurrencyId, (int)request.ActivityType);

                if (!notifyTempEo.Any())
                {
                    LogUtil.GetContextLogger().AddMessage($"sa_notify_template配置不存在.OperatorId={request.OperatorId}|CurrencyId={request.CurrencyId}|ActivityType={(int)request.ActivityType}");
                    return false;
                }

                foreach (var item in notifyTempEo)
                {
                    NotifyDetails.Add(new NotifyDetail()
                    {
                        NotifyId = notifyId,
                        LangId = item.LangID,
                        Title = string.Empty,
                        ImageUrl = string.Empty,
                        Content = string.Format(item.Content, request.Bonus.AToM(request.CurrencyId), request.CurrencyId),
                        LinkKind = 0, //无连接
                        LinkUrl = string.Empty
                    });
                }

                await MQUtil.PublishAsync<NotifyMsg>(new NotifyMsg()
                {
                    Notifies = Notifies,
                    NotifyUsers = NotifyUsers,
                    NotifyDetails = NotifyDetails
                });

                return true;
            }
            catch (Exception ex)
            {
                if (ex is not CustomException)
                    _logger.LogError($"NotifyCommandHandlerBase.error:{ex.Message}.command:{JsonConvert.SerializeObject(request)}");
                return false;
            }
        }

        /// <summary>
        /// 发送站内邮件通知
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        private async Task<bool> SendNotifyEmail(NotifyCommandBase request)
        {
            string messageId = null;
            string templateKey = $"ActivityRewardNotice{(int)request.ActivityType}";
            if (request.IsReward)
            {
                await MQUtil.PublishAsync(new UserEmailMsg
                {
                    AppId = request.AppId,
                    DisplayTag = 2,
                    UserId = request.UserId,
                    TemplateKey = templateKey,
                    SenderId = request.SenderId,

                    SourceType = (int)request.ActivityType,
                    IsBouns = true,
                    RewardAmount = request.RewardAmount,
                    FlowMultip = (int)request.FlowMultip,
                    SourceTable = request.RewardSourceTable,
                    SourceId = request.RewardSourceId,
                    Content = JsonConvert.SerializeObject(request.Parameters),
                    OperatorId = request.OperatorId,
                    CountryId = request.CountryId,
                    CurrencyId = request.CurrencyId,
                });
            }
            else
            {
                await MQUtil.PublishAsync(new UserEmailMsg
                {
                    AppId = request.AppId,
                    DisplayTag = 1,
                    UserId = request.UserId,
                    TemplateKey = templateKey,
                    SenderId = request.SenderId,
                    Content = JsonConvert.SerializeObject(request.Parameters),
                    OperatorId = request.OperatorId,
                    CountryId = request.CountryId,
                    CurrencyId = request.CurrencyId,
                });
            }
            return !string.IsNullOrEmpty(messageId);
        }

    }
}
