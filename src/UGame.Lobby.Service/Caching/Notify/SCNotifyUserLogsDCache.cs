using UGame.Lobby.Repository.ing;
using AiUo.Caching;
using AiUo.Extensions.StackExchangeRedis;

namespace UGame.Lobby.Service.Caching.Notify;

public class SCNotifyUserLogsDCache : RedisHashExpireClient<Sc_notify_user_logEO>
{
    private const int EXPIRE_HOURS = 1;

    private string UserId { get; set; }

    private Sc_notify_user_logMO _notifyUserLogMo = new();

    public SCNotifyUserLogsDCache(string userId)
    {
        UserId = userId;
        RedisKey = GetProjectGroupRedisKey("Notifys", UserId);
    }

    public static string GetField(string userId, string notifyId) => $"{userId}|{notifyId}";

    protected override async Task<CacheValue<CacheItem<Sc_notify_user_logEO>>> LoadValueWhenRedisNotExistsAsync(string field)
    {
        var ret = new CacheValue<CacheItem<Sc_notify_user_logEO>>
        {
            Value = new CacheItem<Sc_notify_user_logEO>()
        };

        var notifyUserLogEo = await _notifyUserLogMo.GetSingleAsync("UserId = @UserId", UserId);

        ret.HasValue = notifyUserLogEo != null;
        ret.Value = new CacheItem<Sc_notify_user_logEO>(notifyUserLogEo, TimeSpan.FromDays(EXPIRE_HOURS));

        return ret;
    }

    protected override async Task<CacheValue<Dictionary<string, CacheItem<Sc_notify_user_logEO>>>> LoadAllValuesWhenRedisNotExistsAsync()
    {
        var ret = new CacheValue<Dictionary<string, CacheItem<Sc_notify_user_logEO>>>
        {
            Value = new Dictionary<string, CacheItem<Sc_notify_user_logEO>>()
        };

        var notifyUsersEoList = await _notifyUserLogMo.GetAsync("UserId = @UserId", UserId);

        if (notifyUsersEoList != null && notifyUsersEoList.Any())
        {
            foreach (var item in notifyUsersEoList)
            {
                ret.Value.Add($"{item.UserID}|{item.NotifyID}", new CacheItem<Sc_notify_user_logEO>(item, TimeSpan.FromDays(EXPIRE_HOURS)));
            }
        }

        ret.HasValue = ret.Value.Count > 0;

        return ret;
    }

}
