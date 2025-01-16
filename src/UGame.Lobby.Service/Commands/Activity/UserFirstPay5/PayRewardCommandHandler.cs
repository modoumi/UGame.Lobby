using UGame.Lobby.Common.Enum;
using UGame.Lobby.Repository.ing;
using MediatR;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using AiUo;
using AiUo.Data;
using AiUo.Extensions.RabbitMQ;
using AiUo.Logging;
using AiUo.Text;
using UGame.Lobby.Service.Caching;
using UGame.Lobby.Service.Commands.Activity.Base;
using UGame.Lobby.Service.Common;
using UGame.Lobby.Service.Services.Activity.PayReward;
using Xxyy.Common;
using Xxyy.Common.Services;
using Xxyy.MQ.Lobby.Activity;

namespace UGame.Lobby.Service.Commands.Activity.UserFirstPay5
{

    public class PayRewardCommandHandler : IRequestHandler<PayRewardCommand, bool>
    {
        //ILogger<PayRewardCommandHandler> _logger;

        private Sa_firstpay_configMO _firstpayConfigMO = new();
        private Sa_firstpay_user_configMO _firstpayUserConfigMO = new();
        private Sa_firstpay_user_detailMO _firstpayUserDetailMO = new();
        private PayRewardService _payRewardService = new();

        /// <summary>
        /// 构造方法
        /// </summary>
        public PayRewardCommandHandler()
        {
            //_logger = LogUtil.CreateLogger<PayRewardCommandHandler>();
        }





        public async Task<bool> Handle(PayRewardCommand request, CancellationToken cancellationToken)
        {

            LogUtil.GetContextLogger().AddMessage($"lobby.PayRewardCommandHandler.Handle.request:{JsonConvert.SerializeObject(request)}");

            if (request.ActivityIds != null && request.ActivityIds.Any() && !request.ActivityIds.Any(d => d.Equals(Convert.ToString((int)ActivityType.UserFirstPay5))))
                return true;

            TransactionManager tm = new TransactionManager();
            try
            {
                if (request.ReceiveBonus != 1)
                    throw new CustomException(LobbyCodes.RS_UNKNOWN, "用户选择了充值不接受bonus");

                var rewardDetail = await _payRewardService.GetPayRewardDetail(request.UserId, request.OperatorId, request.CurrencyId, new List<long> { request.PayAmount });
                if (rewardDetail.frequency > 0)
                {
                    var payAwardConfig = await _firstpayConfigMO.GetByPKAsync(request.OperatorId, request.CurrencyId, tm, isForUpdate_: true);
                    CurrencyChangeService currencyChangeService = new CurrencyChangeService(request.UserId);
                    var bonus = rewardDetail.rewards[request.PayAmount];
                    if (bonus <= 0) { tm.Rollback(); return false; }
                    var userConfigSet = "RemainTimes=RemainTimes-1 ";

                    var userRewardDetail = new Sa_firstpay_user_detailEO()
                    {
                        DetailID = ObjectId.NewId(),
                        UserID = request.UserId,
                        OperatorID = request.OperatorId,
                        CountryID = request.CountryId,
                        CurrencyID = request.CurrencyId,
                        PayAmount = request.PayAmount,
                        BonusAmount = bonus,
                        //RemainTimes = payAwardConfig.TotalTimes - rewardDetail.frequency,
                        RemainTimes = rewardDetail.frequency - 1,
                        NotifyStatus = 0,
                        RecDate = DateTime.UtcNow,
                        ReceiveStatus = 1,
                        OrderId = request.OrderID
                    };

                    if ((await _firstpayUserDetailMO.AddAsync(userRewardDetail, tm)) < 1)
                        throw new Exception($"用户ID：{request.UserId}，充值领取赠金时，新增sa_firstpay_user_detail失败。");

                    //查询当前活动配置
                    var activityOperator = await LobbyUtil.GetSingleActivityAsync(request.OperatorId, request.CurrencyId, ActivityType.UserFirstPay5);
                    if (activityOperator == null)
                        throw new Exception($@"l_activity_operator表活动{(int)ActivityType.UserFirstPay5}不存在.");

                    var currencyChangeReq = new CurrencyChangeReq()
                    {
                        UserId = request.UserId,
                        AppId = "lobby",
                        OperatorId = request.OperatorId,
                        CurrencyId = request.CurrencyId,
                        //IsBonus = activityOperator.IsBonus,
                        ChangeBalance = activityOperator.IsBonus ? CurrencyChangeBalance.Bonus : CurrencyChangeBalance.Cash,
                        FlowMultip = payAwardConfig.FlowMultip,// 所获赠金提现所需要的流水倍数
                        Reason = "新用户充值50%奖励发放奖励",
                        Amount = (long)bonus,
                        SourceType = (int)ActivityType.UserFirstPay5,
                        SourceTable = "sb_bank_order",
                        SourceId = request.OrderID,
                        ChangeTime = DateTime.UtcNow,
                        TM = tm
                    };

                    var changeMsg = await currencyChangeService.Add(currencyChangeReq);
                    if (changeMsg == null)
                        throw new Exception($"用户ID：{request.UserId}，充值领取赠金时，新增s_requireflow_order流水订单，及s_currency_change失败。");

                    if (await _firstpayUserConfigMO.PutByPKAsync(request.UserId, userConfigSet, tm) < 1)
                        throw new Exception($"用户ID：{request.UserId}，充值领取赠金时，更新赠金领取次数失败。");

                    var globalUserDCacheEx = GlobalUserDCacheEx.Create(request.UserId);

                    //更新l_user_activity.IsInvolved
                    if (userRewardDetail.RemainTimes == 0)
                    {
                        //更新用户活动状态
                        await LobbyUtil.UpdateUserActivity(request.UserId, request.OperatorId, request.CurrencyId, ActivityType.UserFirstPay5, tm);
                    }


                    tm.Commit();
                    //await currencyChangeService.PublishMQ(currencyChangeReq);
                    await MQUtil.PublishAsync(changeMsg);

                    await MQUtil.PublishAsync(new UserActivityMsg()
                    {
                        UserId = request.UserId,
                        ActivityType = (int)ActivityType.UserFirstPay5,
                        IsEnd = userRewardDetail.RemainTimes == 0
                    });

                    #region 发通知

                    IMediator _mediator = DIUtil.GetService<IMediator>();
                    PayRewardNotifyCommand notifyCommand = new PayRewardNotifyCommand();
                    notifyCommand.UserId = request.UserId;
                    notifyCommand.OperatorId = request.OperatorId;
                    notifyCommand.CountryId = request.CountryId;
                    notifyCommand.CurrencyId = request.CurrencyId;
                    notifyCommand.Bonus = bonus;
                    notifyCommand.FlowMultip = payAwardConfig.FlowMultip;
                    notifyCommand.RewardSourceId = userRewardDetail.DetailID;
                    notifyCommand.IsSendNotify = request.IsSendNotify;
                    notifyCommand.IsSendNotifyEmail = request.IsSendNotifyEmail;
                    notifyCommand.Parameters = new { RewardAmount = bonus.AToM(request.CurrencyId) };
                    await _mediator.Send(notifyCommand);

                    #endregion

                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                tm.Rollback();
                if (ex is not CustomException)
                {
                    LogUtil.GetContextLogger().AddException(ex).AddMessage($"PayRewardCommandHandler.用户ID：{request.UserId}，运营商id:{request.OperatorId}，货币类型:{request.CurrencyId}，充值送赠金时出现异常：{ex.Message}");
                }
                return false;
            }
        }
    }
}
