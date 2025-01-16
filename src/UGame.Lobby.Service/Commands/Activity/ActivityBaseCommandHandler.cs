using EasyNetQ;
using UGame.Lobby.Common.Enum;
using MediatR;
using Newtonsoft.Json;
using AiUo;
using AiUo.Logging;
using UGame.Lobby.Service.Caching.Activity;
using UGame.Lobby.Service.Commands.Activity.BindMobile;
using UGame.Lobby.Service.Commands.Activity.InvitationNewUser100011;
using UGame.Lobby.Service.Commands.Activity.InviteUser100013;
using UGame.Lobby.Service.Commands.Activity.Register7;
using UGame.Lobby.Service.Commands.Activity.Roulette101001;
using UGame.Lobby.Service.Commands.Activity.UserFirstPay5;
using UGame.Lobby.Service.Commands.Activity.UserPay10008;
using UGame.Lobby.Service.Commands.Activity.WeeklyCard;
using Xxyy.MQ.Bank;
using Xxyy.MQ.Xxyy;

namespace UGame.Lobby.Service.Commands.Activity
{
    /// <summary>
    /// 
    /// </summary>
    public class ActivityBaseCommandHandler : IRequestHandler<ActivityBaseCommand, bool>
    {
        public async Task<bool> Handle(ActivityBaseCommand request, CancellationToken cancellationToken)
        {
            //参数校验
            if (!await CheckRequest(request))
            {
                LogUtil.Info($"Lobby_BLL_Commands_Activity_ActivityBaseCommandHandler_CheckRequest:{JsonConvert.SerializeObject(request)}");
                return false;
            }

            //校验EventId是否合法
            if (!await CheckEventId(request))
            {
                LogUtil.Info($"Lobby_BLL_Commands_Activity_ActivityBaseCommandHandler_CheckEventId:{JsonConvert.SerializeObject(request)}");
                return false;
            }

            //当前所有配置了事件的活动
            //同一个事件对应多个活动
            var activityList = await GetActivitList(request);

            if (activityList == null || !activityList.Any())
            {
                LogUtil.Info($"Lobby_BLL_Commands_Activity_ActivityBaseCommandHandler_GetActivitList:{JsonConvert.SerializeObject(request)}");
                return false;
            }

            foreach (var item in activityList.OrderByDescending(d => d.ActivityID))
            {
                if (request.EventId == (int)ActivityEvent.Register && item.EventId == (int)ActivityEvent.Register)
                    LogUtil.Info($"Lobby_BLL_Commands_Activity_ActivityBaseCommandHandler_Register_Item,request:{JsonConvert.SerializeObject(request)}.item:{JsonConvert.SerializeObject(item)}");

                if (request.EventId == item.EventId)
                    await SendCommand(request, item);
            }
            return true;
        }

        private async Task SendCommand(ActivityBaseCommand request, ActivityEventEntity activityEventEntity)
        {
            var _mediator = DIUtil.GetService<IMediator>();

            try
            {
                switch (activityEventEntity.ActivityID)
                {
                    //100002,绑定手机号
                    case (int)ActivityType.BindMobile:
                        var bindMobileCommand = JsonConvert.DeserializeObject<BindMobileCommand>(JsonConvert.SerializeObject(request.Data));
                        bindMobileCommand.IsSendNotify = activityEventEntity.IsSendNotify;
                        bindMobileCommand.IsSendNotifyEmail = activityEventEntity.IsSendNotifyEmail;
                        await _mediator.Send(bindMobileCommand);
                        break;
                    //100004,充值50% or 充值10% or 充值邮件通知（send后会触发100008）
                    case (int)ActivityType.UserFirstPay5:
                        var userFirstPay5Command = JsonConvert.DeserializeObject<PayRewardCommand>(JsonConvert.SerializeObject(request.Data));
                        userFirstPay5Command.IsSendNotify = activityEventEntity.IsSendNotify;
                        userFirstPay5Command.IsSendNotifyEmail = activityEventEntity.IsSendNotifyEmail;
                        await _mediator.Send(userFirstPay5Command);
                        break;
                    //100007,注册寄送bonus
                    case (int)ActivityType.Register7:
                        var register7Command = JsonConvert.DeserializeObject<Register7Command>(JsonConvert.SerializeObject(request.Data));
                        register7Command.IsSendNotify = activityEventEntity.IsSendNotify;
                        register7Command.IsSendNotifyEmail = activityEventEntity.IsSendNotifyEmail;
                        await _mediator.Send(register7Command);
                        break;
                    //100008，每日充值激励活动
                    case (int)ActivityType.UserPay100008:
                        var userPay100008Command = JsonConvert.DeserializeObject<UserPay100008Command>(JsonConvert.SerializeObject(request.Data));
                        userPay100008Command.IsSendNotify = activityEventEntity.IsSendNotify;
                        userPay100008Command.IsSendNotifyEmail = activityEventEntity.IsSendNotifyEmail;
                        await _mediator.Send(userPay100008Command);
                        break;
                    //100011,好友邀请分享
                    case (int)ActivityType.InvitationNewUser100011:
                        var invitationNewUser100011Command = JsonConvert.DeserializeObject<InvitationNewUser100011Command>(JsonConvert.SerializeObject(request.Data));
                        invitationNewUser100011Command.IsSendNotify = activityEventEntity.IsSendNotify;
                        invitationNewUser100011Command.IsSendNotifyEmail = activityEventEntity.IsSendNotifyEmail;
                        await _mediator.Send(invitationNewUser100011Command);
                        break;
                    //100013,新版好友邀请分享
                    case (int)ActivityType.InviteNewUser100013:
                        var inviteUser100013Command = new InviteUser100013Command();
                        inviteUser100013Command.IsSendNotify = activityEventEntity.IsSendNotify;
                        inviteUser100013Command.IsSendNotifyEmail = activityEventEntity.IsSendNotifyEmail;
                        if (activityEventEntity.EventId == (int)ActivityEvent.Pay)
                            inviteUser100013Command.userPayMsg = request.Data as UserPayMsg;
                        else if (activityEventEntity.EventId == (int)ActivityEvent.Bet)
                            inviteUser100013Command.userBetMsg = request.Data as UserBetMsg;
                        else
                            throw new Exception($"新版好友邀请分享，没有配置事件.");
                        inviteUser100013Command.EventType = activityEventEntity.EventId.ToEnumN<ActivityEvent>();
                        await _mediator.Send(inviteUser100013Command);
                        break;
                    //101001,1.7版抽奖轮盘
                    case (int)ActivityType.Roulette101001:
                        var roulette101001Command = new Roulette101001Command();
                        roulette101001Command.IsSendNotify = activityEventEntity.IsSendNotify;
                        roulette101001Command.IsSendNotifyEmail = activityEventEntity.IsSendNotifyEmail;
                        if (activityEventEntity.EventId == (int)ActivityEvent.Pay)
                            roulette101001Command.userPayMsg = request.Data as UserPayMsg;
                        else
                            throw new Exception($"1.7版抽奖轮盘，没有配置事件.");
                        roulette101001Command.EventType = activityEventEntity.EventId.ToEnumN<ActivityEvent>();
                        await _mediator.Send(roulette101001Command);
                        break;
                    //101002,1.7版周卡
                    case (int)ActivityType.WeeklyCard:
                        var weeklyCardCommand = new WeeklyCardCommand();
                        weeklyCardCommand.IsSendNotify = activityEventEntity.IsSendNotify;
                        weeklyCardCommand.IsSendNotifyEmail = activityEventEntity.IsSendNotifyEmail;
                        if (activityEventEntity.EventId == (int)ActivityEvent.Pay)
                            weeklyCardCommand.userPayMsg = request.Data as UserPayMsg;
                        else
                            throw new Exception($"1.7版周卡,没有配置事件.");
                        weeklyCardCommand.EventType = activityEventEntity.EventId.ToEnumN<ActivityEvent>();
                        await _mediator.Send(weeklyCardCommand);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                //LogUtil.GetContextLogger().AddException(ex).AddMessage($"ActivityBaseCommandHandler.SendCommand.activityEventEntity:{JsonConvert.SerializeObject(activityEventEntity)}.request:{JsonConvert.SerializeObject(request)}");
                LogUtil.Info($"ActivityBaseCommandHandler_SendCommand,activityEventEntity:{JsonConvert.SerializeObject(activityEventEntity)},request:{JsonConvert.SerializeObject(request)},error:{JsonConvert.SerializeObject(ex)}");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        private async Task<bool> CheckRequest(ActivityBaseCommand request)
        {
            if (request.EventId < 1) return false;

            if (string.IsNullOrWhiteSpace(request.OperatorId)
                || string.IsNullOrWhiteSpace(request.CurrencyId)
                )
                return false;

            return true;
        }

        /// <summary>
        /// 校验EventId是否合法
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        private async Task<bool> CheckEventId(ActivityBaseCommand request)
        {
            var cache = new ActivityEventDCache(request.OperatorId, request.CurrencyId);

            var cacheData = await cache.GetAsync();

            //如果事件未配置、或未找到对应的事件
            if (cacheData == null
                || !cacheData.HasValue
                || !cacheData.Value.Any(d => d.ActivityEventId == request.EventId)
                )
                return false;

            return true;
        }

        /// <summary>
        /// 获取有效期内并且开启的活动
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        private async Task<List<ActivityEventEntity>> GetActivitList(ActivityBaseCommand request)
        {
            var cache = new ActivityListDCache(request.OperatorId, request.CurrencyId);

            var cacheData = await cache.GetAsync();

            //如果未配置任何活动或活动全部已过期
            if (cacheData == null
                || !cacheData.HasValue)
                return new List<ActivityEventEntity>();

            return cacheData.Value;
        }

    }
}
