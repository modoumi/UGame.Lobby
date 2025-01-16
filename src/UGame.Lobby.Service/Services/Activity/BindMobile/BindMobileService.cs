using UGame.Lobby.Common.Enum;
using UGame.Lobby.Repository.ing;
using MediatR;
using AiUo;
using AiUo.Data;
using AiUo.Extensions.RabbitMQ;
using AiUo.Logging;
using UGame.Lobby.Service.Caching.Activity.BindMobile;
using UGame.Lobby.Service.Commands.Activity.Base;
using UGame.Lobby.Service.Common;
using Xxyy.Common;
using Xxyy.Common.Services;
using Xxyy.MQ.Lobby.Activity;

namespace UGame.Lobby.Service.Services.Activity.BindMobile
{
    /// <summary>
    /// BindMobileService
    /// </summary>
    public class BindMobileService
    {
        private UserService _commonUserService;

        private CurrencyChangeService _currencyChangeService;

        private Sa_bind_mobile_userMO _bindMobileUserMo = new();

        public async Task<bool> BindMobile(string userId, string appId, bool isSendNotify, bool isSendNotifyEmail)
        {
            //获取s_user
            _commonUserService = new UserService(userId);
            var sUser = await _commonUserService.GetUserMo().GetByPKAsync(userId);
            //用户未注册
            if (sUser.UserMode != (int)UserMode.Register)
                return false;
            //手机号为空
            if (string.IsNullOrWhiteSpace(sUser.Mobile))
                return false;
            //获取sa_bind_mobile_user
            var bindMobileUser = await _bindMobileUserMo.GetByPKAsync(userId, isForUpdate_: true);
            if (bindMobileUser != null)
                return false;

            //赠送手机号配置
            var field = BindMobileConfigDCache.GetField(sUser.OperatorID, sUser.CurrencyID);
            var bindMobileConfig = await new BindMobileConfigDCache().GetOrLoadAsync(field);

            TransactionManager tm = new TransactionManager();

            try
            {
                //绑定手机活动user
                bindMobileUser = new Sa_bind_mobile_userEO()
                {
                    UserID = sUser.UserID,
                    OperatorID = sUser.OperatorID,
                    CountryId = sUser.CountryID,
                    CurrencyID = sUser.CurrencyID,
                    Bonus = bindMobileConfig.Value.SendBonus,
                    RecDate = DateTime.UtcNow
                };
                //写入sa_bind_mobile_user
                await _bindMobileUserMo.AddAsync(bindMobileUser, tm);


                //更新用户活动状态
                await LobbyUtil.UpdateUserActivity(sUser.UserID, sUser.OperatorID, sUser.CurrencyID, ActivityType.BindMobile, tm);

                _currencyChangeService = new CurrencyChangeService(sUser.UserID);

                CurrencyChangeReq currencyChangeReq = null;

                //如果绑定手机号赠送bonus
                if (bindMobileConfig.Value.IsSendBonus)
                {
                    //查询当前活动配置
                    var activityOperator = await LobbyUtil.GetSingleActivityAsync(sUser.OperatorID, sUser.CurrencyID, ActivityType.BindMobile);
                    if (activityOperator == null)
                        throw new Exception($@"l_activity_operator表活动{(int)ActivityType.BindMobile}不存在.");

                    currencyChangeReq = new CurrencyChangeReq()
                    {
                        UserId = sUser.UserID,
                        AppId = appId,
                        OperatorId = sUser.OperatorID,
                        CurrencyId = sUser.CurrencyID,
                        Reason = $"绑定手机号送bonus:{bindMobileConfig.Value.SendBonus}",
                        Amount = bindMobileConfig.Value.SendBonus,
                        SourceType = (int)ActivityType.BindMobile,
                        SourceTable = "sa_bind_mobile_user",
                        SourceId = sUser.UserID,
                        ChangeTime = DateTime.UtcNow,
                        //IsBonus = activityOperator.IsBonus,
                        ChangeBalance = activityOperator.IsBonus ? CurrencyChangeBalance.Bonus : CurrencyChangeBalance.Cash,
                        FlowMultip = bindMobileConfig.Value.CashBetMultip,
                        TM = tm
                    };

                }

                //写入账号金额变化
                var changeMsg = await _currencyChangeService.Add(currencyChangeReq);

                tm.Commit();
                if (changeMsg != null)
                {
                    await MQUtil.PublishAsync(changeMsg);
                }

                await MQUtil.PublishAsync(new UserActivityMsg()
                {
                    UserId = sUser.UserID,
                    ActivityType = (int)ActivityType.BindMobile,
                    IsEnd = true
                });

                #region 发通知（弹框、邮件）

                if (bindMobileConfig.Value.IsSendBonus)
                {

                    #region 弹框通知

                    //写入Notify
                    var _mediator = DIUtil.GetService<IMediator>();
                    var notifyCommand = new BindMobileNotifyCommand();
                    notifyCommand.UserId = sUser.UserID;
                    notifyCommand.OperatorId = sUser.OperatorID;
                    notifyCommand.CountryId = sUser.CountryID;
                    notifyCommand.CurrencyId = sUser.CurrencyID;
                    notifyCommand.Bonus = bindMobileConfig.Value.SendBonus;
                    notifyCommand.FlowMultip = bindMobileConfig.Value.CashBetMultip;
                    notifyCommand.AppId = appId;
                    notifyCommand.ShowName = LobbyUtil.GetShowName(sUser);
                    notifyCommand.IsSendNotify = isSendNotify;
                    notifyCommand.IsSendNotifyEmail = isSendNotifyEmail;
                    notifyCommand.Parameters = new { RewardAmount = bindMobileConfig.Value.SendBonus.AToM(sUser.CurrencyID) };
                    await _mediator.Send(notifyCommand);

                    #endregion
                }

                #endregion

                return true;
            }
            catch (Exception ex)
            {
                tm.Rollback();
                if (ex is not CustomException)
                {
                    LogUtil.GetContextLogger().AddException(ex).AddMessage($"BindMobile,userId:{userId}");
                }
                return false;
            }
        }
    }
}
