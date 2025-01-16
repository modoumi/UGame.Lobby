using EasyNetQ;
using UGame.Lobby.Repository.ing;
using Newtonsoft.Json;
using AiUo;
using AiUo.BIZ.RabbitMQ;
using AiUo.Data;
using AiUo.Extensions.RabbitMQ;
using AiUo.Logging;
using UGame.Lobby.Service.Caching;
using Xxyy.Common.Caching;
using Xxyy.MQ.Lobby.Activity;

namespace UGame.Lobby.Service.MQConsumer;

public class UserActivityMQSub : MQBizSubConsumer<UserActivityMsg>
{

    private L_user_activityMO _userActivityMo = new();

    public UserActivityMQSub()
    {
        AddHandler(Main);
    }

    public override MQSubscribeMode SubscribeMode => MQSubscribeMode.OneQueue;

    protected override void Configuration(ISubscriptionConfiguration config)
    {
    }

    protected override Task OnMessage(UserActivityMsg message, CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }

    private async Task Main(UserActivityMsg message, CancellationToken cancellationToken)
    {
        if (message == null)
            return;

        TransactionManager tm = new TransactionManager();
        try
        {
            var globalUserDCache = await GlobalUserDCache.Create(message.UserId);
            var allActivityOperatorList = LobbyDbCacheUtil.GetAllActivityOperator(await globalUserDCache.GetOperatorIdAsync(),
                                                        await globalUserDCache.GetCurrencyIdAsync());
            if (allActivityOperatorList == null
                || !allActivityOperatorList.Any())
                throw new Exception("l_activity_operator未找到数据1.");

            var activityOperatorEo = allActivityOperatorList.Where(d => d.ActivityID == (int)message.ActivityType).FirstOrDefault();

            if (activityOperatorEo == null)
                throw new Exception("l_activity_operator未找到数据2.");

            var timeNow = DateTime.UtcNow;

            var userActivity = await _userActivityMo.GetSingleAsync("UserId = @UserId and ActivityId = @ActivityId", tm, message.UserId, (int)message.ActivityType);

            if (userActivity == null)
            {
                userActivity = new L_user_activityEO()
                {
                    UserID = message.UserId,
                    CountryID = await globalUserDCache.GetCountryIdAsync(),
                    CurrencyID = await globalUserDCache.GetCurrencyIdAsync(),
                    OperatorID = await globalUserDCache.GetOperatorIdAsync(),
                    UserKind = (int)await globalUserDCache.GetUserKindAsync(),
                    ActivityId = (int)message.ActivityType,
                    ActivityName = message.ActivityType.ToString(),
                    IsInvolved = true,
                    IsEnd = activityOperatorEo.IsAllowEnd && message.IsEnd,
                    RecDate = timeNow,
                    UpdateTime = timeNow
                };
                await _userActivityMo.AddAsync(userActivity, tm);
            }
            else
            {
                if (activityOperatorEo.IsAllowEnd && message.IsEnd)
                    await _userActivityMo.PutAsync("IsEnd = 1, UpdateTime = @UpdateTime", "UserId = @UserId and ActivityId = @ActivityId", tm, timeNow, message.UserId, (int)message.ActivityType);
            }

            tm.Commit();
        }
        catch (Exception ex)
        {
            tm.Rollback();
            if (ex is not CustomException)
            {
                LogUtil.GetContextLogger().AddException(ex).AddMessage($"UserActivityMQSub.Error:{ex.Message}.message:{JsonConvert.SerializeObject(message)}");
            }
            return;
        }
    }
}
