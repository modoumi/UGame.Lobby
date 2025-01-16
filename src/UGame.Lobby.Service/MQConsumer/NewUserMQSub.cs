using EasyNetQ;
using UGame.Lobby.Repository.ing;
using Newtonsoft.Json;
using AiUo.BIZ.RabbitMQ;
using AiUo.Data.SqlSugar;
using AiUo.Extensions.RabbitMQ;
using AiUo.Logging;
using UGame.Lobby.Service.Caching;
using UGame.Lobby.Service.Caching.Activity.Roulette;
using Xxyy.MQ.Xxyy;

namespace UGame.Lobby.Service.MQConsumer;

/// <summary>
/// 新用户
/// </summary>
public class NewUserMQSub : MQBizSubConsumer<NewUserMsg>
{
    private Sa_roulette_userMO _rouletteUserMo = new();

    public NewUserMQSub()
    {
        AddHandler(Main);
    }

    public override MQSubscribeMode SubscribeMode => MQSubscribeMode.OneQueue;

    protected override void Configuration(ISubscriptionConfiguration config)
    {
    }

    protected override Task OnMessage(NewUserMsg message, CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }

    /// <summary>
    /// 消息主入口
    /// </summary>
    /// <param name="message"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    private async Task Main(NewUserMsg message, CancellationToken cancellationToken)
    {
        if (message == null)
            LogUtil.Info($"Lobby:NewUserMQSub:message 为null");

        var retList = new List<MQResult>();
        var ret = new MQResult();

        GlobalUserDCacheEx globalUserDCacheEx = GlobalUserDCacheEx.Create(message.UserId);

        //如果l_user_info表不存在当前用户数据，则进行初始化
        if (!await globalUserDCacheEx.GetHasLUserInfo())
        {
            //初始化l_user_info
            ret = await InitLUserInfo(message);
            retList.Add(ret);

            //缓存中设置当前用户已存在
            if (ret.Success)
                await globalUserDCacheEx.SetHasLUserInfo();
        }

        if (retList.Any(d => !d.Success))
        {
            LogUtil.GetContextLogger().AddMessage($"Lobby:NewUserMQSub,\nmessage:{JsonConvert.SerializeObject(message)}\nret:{JsonConvert.SerializeObject(retList)}");
        }
    }

    /// <summary>
    /// 初始化l_user_info表
    /// </summary>
    /// <param name="message"></param>
    /// <returns></returns>
    private async Task<MQResult> InitLUserInfo(NewUserMsg message)
    {
        try
        {
            var ret = new MQResult() { Message = "InitLUserInfo" };

            var userInfo = new L_user_infoPO()
            {
                UserID = message.UserId,
                OperatorID = message.OperatorId,
                CountryID = message.CountryId,
                CurrencyID = message.CurrencyId,
                UserKind = message.UserKind,
                NickName = message.Nickname,
                RecDate = DateTime.UtcNow
            };

            await DbUtil.GetRepository<L_user_infoPO>().InsertAsync(userInfo);

            ret.Success = true;

            return ret;
        }
        catch (Exception ex)
        {
            return new MQResult() { Success = false, Message = $"Lobby_BLL_MQConsumer_NewUserMQSub_InitLUserInfo,Error:{ex.Message}" };
        }
    }


    /// <summary>
    /// 初始化sa_roulette_user
    /// </summary>
    /// <param name="message"></param>
    /// <returns></returns>
    private async Task<MQResult> InitRouletteUser(NewUserMsg message)
    {
        try
        {
            var ret = new MQResult() { Message = "InitRouletteUser" };
            var rouletteUser = new Sa_roulette_userEO()
            {
                UserID = message.UserId,
                UserKind = message.UserKind,
                OperatorID = message.OperatorId,
                CurrencyID = message.CurrencyId,
                RecDate = DateTime.UtcNow
            };

            ret.Success = await _rouletteUserMo.AddAsync(rouletteUser) > 0;

            if (ret.Success)
            {
                //写缓存
                var rouletteUserDCache = new RouletteUserDCache(message.OperatorId, message.UserId);
                await rouletteUserDCache.SetAsync();
            }

            return ret;
        }
        catch (Exception ex)
        {
            return new MQResult() { Success = false, Message = $"Lobby:NewUserMQSub,InitRouletteUser,Error:{ex.Message}" };
        }
    }
}
