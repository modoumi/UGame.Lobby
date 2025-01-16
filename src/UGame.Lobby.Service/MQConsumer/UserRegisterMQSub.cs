using UGame.Lobby.Common.Enum;
using UGame.Lobby.Repository.ing;
using MediatR;
using Newtonsoft.Json;
using AiUo;
using AiUo.BIZ.RabbitMQ;
using AiUo.Data;
using AiUo.Extensions.RabbitMQ;
using AiUo.Extensions.StackExchangeRedis;
using AiUo.Logging;
using UGame.Lobby.Service.Caching;
using UGame.Lobby.Service.Caching.Activity.Regpay;
using UGame.Lobby.Service.Commands.Activity;
using UGame.Lobby.Service.Common;
using UGame.Lobby.Service.Services.Activity.Roulette;
using Xxyy.Common;
using Xxyy.MQ.Xxyy;

namespace UGame.Lobby.Service.MQConsumer;


/// <summary>
/// 新用户注册
/// </summary>
public class UserRegisterMQSub : MQBizSubConsumer<UserRegisterMsg>
{

    private L_user_infoMO _userInfoMo = new();

    private Sa_regpay_userMO _regpayUserMo = new();

    private Sa_roulette_userMO _rouletteUserMo = new();

    private Sa_roulette_detailMO _rouletteDetailMo = new();

    private Sa_firstpay_user_configMO _firstpayUserConfigMO = new();

    private RouletteService _rouletteService = new();

    public override MQSubscribeMode SubscribeMode => MQSubscribeMode.OneQueue;

    protected override void Configuration(EasyNetQ.ISubscriptionConfiguration config)
    {
    }

    protected override Task OnMessage(UserRegisterMsg message, CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }

    /// <summary>
    /// UserRegisterMQSub
    /// </summary>
    public UserRegisterMQSub()
    {
        AddHandler(Main);
        //注册触发的活动
        //RegisterAction(AllActivityExecute);
    }


    private async Task Main(UserRegisterMsg message, CancellationToken cancellationToken)
    {
        LogUtil.Info($"Lobby_BLL_MQConsumer_UserRegisterMQSub_Main,message:{JsonConvert.SerializeObject(message)}");

        if (message == null)
        {
            LogUtil.Info($"Lobby:UserRegisterMQSub:message 为null");
            return;
        }


        using (var redlock = await RedisUtil.LockAsync($"lobby:UserRegisterMQSub:Main:{message.UserId}", 30))
        {
            if (!redlock.IsLocked)
            {
                redlock.Release();

                LogUtil.Info($"Lobby_BLL_MQConsumer_UserRegisterMQSub_repeat,注册消息重复:{JsonConvert.SerializeObject(message)}");
                throw new CustomException(LobbyCodes.RS_UNKNOWN, $"lobby:UGame.Lobby.Service.MQConsumer。UserRegisterMQSub:Main.注册消息重复.message:{JsonConvert.SerializeObject(message)}");
            }

            var retList = new List<MQResult>();

            GlobalUserDCacheEx globalUserDCacheEx = GlobalUserDCacheEx.Create(message.UserId);

            await AllActivityExecute(message);

            try
            {
                //初始化用户大厅数据, l_user_info
                var lUserInfo = Task.Factory.StartNew(() =>
                {
                    retList.Add(LUserInfo(message, globalUserDCacheEx));
                }, cancellationToken);

                //初始化用户充值活动数据,100004
                var payAwardConfig = Task.Factory.StartNew(() =>
                {
                    retList.Add(InitPayAwardConfig(message, globalUserDCacheEx));
                }, cancellationToken);

                Task.WaitAll(new Task[] { lUserInfo, payAwardConfig });

                if (retList.Any(d => !d.Success))
                {
                    LogUtil.GetContextLogger().AddMessage($"Lobby:UserRegisterMQSub,\nmessage:{JsonConvert.SerializeObject(message)}\nret:{JsonConvert.SerializeObject(retList)}");
                }
            }
            catch (Exception ex)
            {
                LogUtil.Info($"Lobby_BLL_MQConsumer_UserRegisterMQSub_Main_error,message:{JsonConvert.SerializeObject(message)}.retList:{JsonConvert.SerializeObject(retList)}");
            }

        }
    }

    /// <summary>
    /// 注册触发的活动
    /// </summary>
    /// <param name="message"></param>
    /// <returns></returns>
    private async Task AllActivityExecute(UserRegisterMsg message)
    {
        LogUtil.Info($"Lobby_BLL_MQConsumer_UserRegisterMQSub_AllActivityExecute,message:{JsonConvert.SerializeObject(message)}");
        var _mediator = DIUtil.GetService<IMediator>();
        var notifyCommand = new ActivityBaseCommand();
        notifyCommand.EventId = (int)ActivityEvent.Register;
        notifyCommand.OperatorId = message.OperatorId;
        notifyCommand.CurrencyId = message.CurrencyId;
        notifyCommand.Data = message;
        await _mediator.Send(notifyCommand);
    }

    /// <summary>
    /// l_user_info相关逻辑
    /// </summary>
    /// <param name="message"></param>
    /// <param name="globalUserDCacheEx"></param>
    /// <returns></returns>
    private MQResult LUserInfo(UserRegisterMsg message, GlobalUserDCacheEx globalUserDCacheEx)
    {
        var ret = new MQResult();

        if (!globalUserDCacheEx.GetHasLUserInfo().GetAwaiter().GetResult())
        {
            try
            {
                ret = new MQResult() { Message = "InitLUserInfo" };
                var userInfo = new L_user_infoEO()
                {
                    UserID = message.UserId,
                    OperatorID = message.OperatorId,
                    CountryID = message.CountryId,
                    CurrencyID = message.CurrencyId,
                    UserKind = message.UserKind,
                    NickName = message.Nickname,
                    RecDate = DateTime.UtcNow
                };

                _userInfoMo.Add(userInfo, useIgnore_: true);
                ret.Success = true;

                //缓存中设置当前用户已存在
                if (ret.Success)
                    globalUserDCacheEx.SetHasLUserInfo().GetAwaiter().GetResult();

                ret.Message = "LUserInfo.OK";
                return ret;
            }
            catch (Exception ex)
            {
                return new MQResult() { Success = false, Message = $"Lobby:UserRegisterMQSub,InitLUserInfo,Error:{ex.Message}" };
            }
        }
        else
        {
            if (!string.IsNullOrWhiteSpace(message.Mobile))
            { 
                //更新手机号
                ret = new MQResult() { Success = _userInfoMo.PutPhoneNumberByPK(message.UserId, message.Mobile) > 0, Message = "更新用户手机号" };
                return ret;
            }
            return new MQResult() { Success = true, Message = "手机号为空" };
        }
    }

    /// <summary>
    /// 初始化活动100001用户数据
    /// </summary>
    /// <param name="message"></param>
    /// <param name="globalUserDCacheEx"></param>
    /// <returns></returns>
    [Obsolete("活动短期内不会开启，开启时需要改代码")]
    private MQResult RegpayUser(UserRegisterMsg message, GlobalUserDCacheEx globalUserDCacheEx)
    {
        var ret = new MQResult();
        if (!globalUserDCacheEx.GetHasRegpayUser().GetAwaiter().GetResult())
        {
            //ret = await InitRegpayUser(message);
            try
            {
                RegpayUserDCache regpayUserDCache = new RegpayUserDCache(message.OperatorId, message.UserId);
                var regpayUser = regpayUserDCache.GetOrLoadAsync().GetAwaiter().GetResult();
                //有数据直接返回
                if (regpayUser.HasValue)
                {
                    return new MQResult() { Success = true, Message = "Lobby:UserRegisterMQSub,InitRegpayUser:sa_regpay_user数据已存在." };
                }

                var field = RegpayConfigDCahce.GetField(message.OperatorId, message.CurrencyId);
                var regpayConfigDCahce = new RegpayConfigDCahce();
                var regpayConfig = regpayConfigDCahce.GetOrLoadAsync(field).GetAwaiter().GetResult();

                if (regpayConfig == null)
                    return new MQResult() { Message = "Lobby:UserRegisterMQSub,InitRegpayUser:sa_regpay_config配置不存在." };

                var addEo = new Sa_regpay_userEO()
                {
                    UserID = message.UserId,
                    OperatorID = message.OperatorId,
                    CountryId = message.CountryId,
                    CurrencyID = message.CurrencyId,
                    SumPay = regpayConfig.Value.RegReward,
                    RegPay = regpayConfig.Value.RegReward,
                    IsRegPay = true,
                    RecDate = DateTime.UtcNow
                };

                _regpayUserMo.Add(addEo, useIgnore_: true);
                ret.Success = true;


                if (ret.Success)
                    globalUserDCacheEx.SetHasRegpayUser().GetAwaiter().GetResult();

                return ret;
            }
            catch (Exception ex)
            {
                return new MQResult() { Success = false, Message = $"Lobby:UserRegisterMQSub,InitRegpayUser,Error:{ex.Message}" };
            }
        }
        else
        {
            //有数据
            ret.Success = true;
        }
        return ret;
    }

    /// <summary>
    /// 初始化用户充值活动数据
    /// </summary>
    /// <param name="message"></param>
    /// <param name="globalUserDCacheEx"></param>
    /// <returns></returns>
    private MQResult InitPayAwardConfig(UserRegisterMsg message, GlobalUserDCacheEx globalUserDCacheEx)
    {
        var ret = new MQResult();
        try
        {
            if (!globalUserDCacheEx.GetHasPayAwardConfig().GetAwaiter().GetResult())
            {
                Sa_firstpay_configMO _firstpayConfigMO = new();
                var payAwardConfig = _firstpayConfigMO.GetByPK(message.OperatorId, message.CurrencyId);
                if (payAwardConfig == null || payAwardConfig.TotalTimes <= 0 || string.IsNullOrWhiteSpace(payAwardConfig.PayMultipleList))
                {
                    ret.Success = true;
                }
                else
                {
                    var addEo = new Sa_firstpay_user_configEO()
                    {
                        UserID = message.UserId,
                        OperatorID = message.OperatorId,
                        CountryID = message.CountryId,
                        CurrencyID = message.CurrencyId,
                        RemainTimes = payAwardConfig.TotalTimes,
                        RecDate = DateTime.UtcNow,
                        UpdateTime = DateTime.UtcNow
                    };
                    ret.Success = _firstpayUserConfigMO.Add(addEo, null, true) > 0;
                    if (ret.Success)
                    {
                        ret.Message = "Lobby:UserRegisterMQSub,InitPayAwardConfig:已执行增加sa_firstpay_user_config操作.";
                        globalUserDCacheEx.SetHasPayAwardConfig().GetAwaiter().GetResult();
                    }
                }
            }
        }
        catch(Exception ex)
        {
            ret.Success = false;
            ret.Message = $"Lobby:UserRegisterMQSub,InitPayAwardConfig,Error:{ex.Message}";
        }
        return ret;
    }

    /// <summary>
    /// sa_roulette_user相关逻辑
    /// </summary>
    /// <param name="message"></param>
    /// <param name="globalUserDCacheEx"></param>
    /// <returns></returns>
    private MQResult RouletteUser(UserRegisterMsg message, GlobalUserDCacheEx globalUserDCacheEx)
    {
        var ret = new MQResult();

        var rouletteUser = _rouletteService.GetRouletteUser(message.OperatorId, message.UserId).Result;

        if (rouletteUser != null && rouletteUser.IsRegPay)
            return new MQResult() { Success = true, Message = "注册奖励已发放" };

        //如果用户不存在，则初始化，并发放注册奖励
        var initRouletteUser = _rouletteService.InitRouletteUser(message.UserId, (int)UserMode.Register, message.UserKind, message.OperatorId, message.CurrencyId).Result;

        ret.Success = initRouletteUser.success;
        ret.Message = initRouletteUser.message;

        if (ret.Success)
            globalUserDCacheEx.SetHasRouletteUserAsync().GetAwaiter().GetResult();

        return ret;
    }

    /// <summary>
    /// 初始化大厅l_user_info表
    /// </summary>
    /// <param name="message"></param>
    /// <returns></returns>
    private async Task<MQResult> InitLUserInfo(UserRegisterMsg message)
    {
        try
        {
            var ret = new MQResult() { Message = "InitLUserInfo" };
            var userInfo = new L_user_infoEO()
            {
                UserID = message.UserId,
                OperatorID = message.OperatorId,
                CountryID = message.CountryId,
                CurrencyID = message.CurrencyId,
                UserKind = message.UserKind,
                NickName = message.Nickname,
                RecDate = DateTime.UtcNow
            };

            ret.Success = await _userInfoMo.AddAsync(userInfo) > 0;

            if (!ret.Success)
            {
                LogUtil.GetContextLogger().AddMessage($"Lobby:NewUserMQSub,InitLUserInfo:写库失败。message:{JsonConvert.SerializeObject(message)}");
            }

            return ret;
        }
        catch (Exception ex)
        {
            return new MQResult() { Success = false, Message = $"Lobby:NewUserMQSub,InitLUserInfo,Error:{ex.Message}" };
        }
    }

    /// <summary>
    /// 初始化注册、首充活动用户数据sa_regpay_user
    /// </summary>
    /// <param name="message"></param>
    /// <returns></returns>
    private async Task<MQResult> InitRegpayUser(UserRegisterMsg message)
    {
        var ret = new MQResult();
        try
        {
            RegpayUserDCache regpayUserDCache = new RegpayUserDCache(message.OperatorId, message.UserId);
            var regpayUser = await regpayUserDCache.GetOrLoadAsync();
            //有数据直接返回
            if (regpayUser.HasValue)
            {
                return new MQResult() { Success = true, Message = "Lobby:UserRegisterMQSub,InitRegpayUser:sa_regpay_user数据已存在." };
            }

            var field = RegpayConfigDCahce.GetField(message.OperatorId, message.CurrencyId);
            var regpayConfigDCahce = new RegpayConfigDCahce();
            var regpayConfig = await regpayConfigDCahce.GetOrLoadAsync(field);

            if (regpayConfig == null)
                return new MQResult() { Message = "Lobby:UserRegisterMQSub,InitRegpayUser:sa_regpay_config配置不存在." };

            var addEo = new Sa_regpay_userEO()
            {
                UserID = message.UserId,
                OperatorID = message.OperatorId,
                CountryId = message.CountryId,
                CurrencyID = message.CurrencyId,
                SumPay = regpayConfig.Value.RegReward,
                RegPay = regpayConfig.Value.RegReward,
                IsRegPay = true,
                RecDate = DateTime.UtcNow
            };

            ret.Success = await _regpayUserMo.AddAsync(addEo) > 0;
            ret.Message = "Lobby:UserRegisterMQSub,InitRegpayUser:已执行增加sa_regpay_user操作.";
            return ret;
        }
        catch (Exception ex)
        {
            return new MQResult() { Success = false, Message = $"Lobby:UserRegisterMQSub,InitRegpayUser,Error:{ex.Message}" };
        }
    }

    /// <summary>
    /// 初始化转盘活动用户数据
    /// </summary>
    /// <param name="message"></param>
    /// <returns></returns>
    private async Task<MQResult> InitRegRouletteUser(UserRegisterMsg message)
    {
        var ret = new MQResult();

        var rouletteUser = await _rouletteService.GetRouletteUser(message.OperatorId, message.UserId);

        if (rouletteUser != null && rouletteUser.IsRegPay)
            return new MQResult() { Success = true, Message = "注册奖励已发放" };

        //如果用户不存在，则初始化，并发放注册奖励
        var initRouletteUser = await _rouletteService.InitRouletteUser(message.UserId, (int)UserMode.Register, message.UserKind, message.OperatorId, message.CurrencyId);

        ret.Success = initRouletteUser.success;
        ret.Message = initRouletteUser.message;
        return ret;
    }

    /// <summary>
    /// 初始化用户活动数据
    /// </summary>
    /// <param name="message"></param>
    /// <returns></returns>
    private MQResult InitUserActivity(UserRegisterMsg message)
    {
        var activityList = LobbyDbCacheUtil.GetAllActivityOperator(message.OperatorId, message.CurrencyId);
        if (activityList == null || !activityList.Any())
            return new MQResult() { Success = false, Message = "InitUserActivity.l_activity_operator未配置数据." };

        var mo = new L_user_activityMO();

        var addEoList = new List<L_user_activityEO>();

        foreach (var item in activityList)
        {
            addEoList.Add(new L_user_activityEO()
            {
                UserID = message.UserId,
                CountryID = message.CountryId,
                CurrencyID = message.CurrencyId,
                OperatorID = message.OperatorId,
                UserKind = message.UserKind,
                ActivityId = item.ActivityID,
                ActivityName = item.ActivityID.ToEnumN<ActivityType>()?.ToString() ?? string.Empty,
                IsInvolved = false,
                RecDate = message.RegisterDate
            });
        }

        foreach (var item in addEoList)
        {
            mo.Add(item, useIgnore_: true);
        }

        return new MQResult() { Success = true, Message = "InitUserActivity.OK" };
    }

}
