using UGame.Lobby.Common.Enum;
using MediatR;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using AiUo;
using AiUo.Extensions.RabbitMQ;
using AiUo.Logging;
using AiUo.Text;
using UGame.Lobby.Service.Common;
using Xxyy.Common;
using Xxyy.MQ.Lobby.Notify;

namespace UGame.Lobby.Service.Commands.Activity.Signin
{
    public class SigninNotifyCommandHandler : IRequestHandler<SigninNotifyCommand, bool>
    {
        ILogger<SigninNotifyCommandHandler> _logger;

        /// <summary>
        /// 构造方法
        /// </summary>
        public SigninNotifyCommandHandler()
        {
            _logger = LogUtil.CreateLogger<SigninNotifyCommandHandler>();
        }

        public async Task<bool> Handle(SigninNotifyCommand request, CancellationToken cancellationToken)
        {
            LogUtil.Info($"SigninNotifyCommandHandler.request:{JsonConvert.SerializeObject(request)}");

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

            return true;
        }

        /// <summary>
        /// 发送弹框通知
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        private async Task<bool> SendNotify(SigninNotifyCommand request)
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
                var notifyTempEo = await LobbyUtil.GetNotifyTemplate(request.OperatorId, request.CurrencyId, (int)ActivityType.SignIn);

                if (!notifyTempEo.Any())
                {
                    LogUtil.GetContextLogger().AddMessage($"sa_notify_template配置不存在.OperatorId={request.OperatorId}|CurrencyId={request.CurrencyId}|ActivityType={(int)ActivityType.BindMobile}");
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
                    _logger.LogError($"SigninNotifyCommandHandler.error:{ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// 发送站内邮件通知
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        private async Task<bool> SendNotifyEmail(SigninNotifyCommand request)
        {
            //老版签到，已经不用了，以下代码可以忽略
            var notifyTempEo = await LobbyUtil.GetNotifyTemplate(request.OperatorId, request.CurrencyId, (int)ActivityType.SignIn, NotifyTypeEnum.Email);

            var notifyEmailMsg = new NotifyEmailMsg();
            notifyEmailMsg.EmailMessages = new EmailMessage()
            {
                UserId = request.UserId,
                OperatorId = request.OperatorId,
                CountryId = request.CountryId,
                CurrencyId = request.CurrencyId,
                SenderID = "SigninNotifyCommandHandler",
                Type = 1,
                ExtendList = new List<MessageExtend>(),
                Reward = new MessageReward()
                {
                    Amount = request.Bonus.AToM(request.CurrencyId),
                    LeastPayAmount = 0,
                    FlowMultip = request.FlowMultip,
                    RewardType = 5,
                    ActivityID = ((int)ActivityType.SignIn).ToString(),
                    SourceType = (int)ActivityType.SignIn,
                    SourceTable = "sa_signin_record",
                    SourceId = request.RecordID
                }
            };

            foreach (var item in notifyTempEo)
            {
                notifyEmailMsg.EmailMessages.ExtendList.Add(new MessageExtend()
                {
                    Title = string.Format(item.Title, request.Bonus.AToM(request.CurrencyId), request.CurrencyId),
                    Content = string.Format(item.Content, request.Bonus.AToM(request.CurrencyId), request.CurrencyId),
                    LangID = item.LangID,
                    ImgURL = item.Img1,
                    HyperLink = item.LinkUrl,
                    Remark = string.Empty
                });
            }

            LogUtil.Info($"SigninNotifyCommandHandler.SendNotifyEmail:{JsonConvert.SerializeObject(request)}.message:{JsonConvert.SerializeObject(notifyEmailMsg)}");

            await MQUtil.PublishAsync(notifyEmailMsg);

            return true;
        }

    }
}
