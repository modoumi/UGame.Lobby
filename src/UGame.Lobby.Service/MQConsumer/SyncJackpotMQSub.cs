using EasyNetQ;
using UGame.Lobby.Repository.ing;
using Newtonsoft.Json;
using AiUo.BIZ.RabbitMQ;
using AiUo.Extensions.RabbitMQ;
using AiUo.Logging;
using UGame.Lobby.Service.Caching.Home;
using Xxyy.DAL;
using Xxyy.MQ.Game;

namespace UGame.Lobby.Service.MQConsumer;

public class SyncJackpotMQSub : MQBizSubConsumer<SyncJackpotMsg>
{
    public SyncJackpotMQSub()
    {
        AddHandler(Main);
    }

    public override MQSubscribeMode SubscribeMode => MQSubscribeMode.OneQueue;

    protected override void Configuration(ISubscriptionConfiguration config)
    {
    }

    protected override Task OnMessage(SyncJackpotMsg message, CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }

    private async Task Main(SyncJackpotMsg message, CancellationToken cancellationToken)
    {
        if (message == null)
        {
            LogUtil.Info($"lobby,SyncJackpotMQSub,meesage为空.message:{JsonConvert.SerializeObject(message)}");
        }

        if (string.IsNullOrWhiteSpace(message.CountryId))
        {
            var operatorEo = await new S_operatorMO().GetSingleAsync("OperatorID = @OperatorID and CurrencyID = @CurrencyID", message.OperatorId, message.CurrencyId);

            if (operatorEo == null)
            {
                LogUtil.Info($"lobby,SyncJackpotMQSub,s_operator为空.message:{JsonConvert.SerializeObject(message)}");
                return;
            }
            message.CountryId = operatorEo.CountryID;
        }

        //l_app_jackpot
        var appJackpotMo = new L_app_jackpotMO();
        //1、更新DB
        //获取l_app_jackpot
        var appJackpot = appJackpotMo.GetSingleAsync("OperatorId = @OperatorId and CurrencyId = @CurrencyId and AppId = @AppId", message.OperatorId, message.CurrencyId, message.AppId);

        //未找到相应的大厅应用奖池数据
        if (appJackpot == null)
        {
            LogUtil.Info($"lobby,SyncJackpotMQSub,未找到l_app_jackpot,message:{JsonConvert.SerializeObject(message)}");
            return;
        }

        //更新奖池
        await appJackpotMo.PutAsync("Jackpot = @Jackpot", "OperatorId = @OperatorId and CurrencyId = @CurrencyId and AppId = @AppId", message.Jackpot, message.OperatorId, message.CurrencyId, message.AppId);

        //2、更新redis
        await new LAppJackpotDCache(message.AppId, message.CountryId, message.OperatorId, message.CurrencyId).SetAsync();

        return;
    }
}
