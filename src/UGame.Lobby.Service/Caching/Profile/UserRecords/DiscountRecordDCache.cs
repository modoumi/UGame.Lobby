using AiUo.Caching;
using AiUo.Extensions.StackExchangeRedis;
using Xxyy.DAL;

namespace UGame.Lobby.Service.Caching.Profile.UserRecords;

/// <summary>
/// DiscountRecordDCache
/// </summary>
public class DiscountRecordDCache : RedisHashExpireClient<List<S_requireflow_orderEO>>
{
    private const int EXPIRE_MINUTES = 5;

    private string _userId;

    /// <summary>
    /// DiscountRecordDCache
    /// </summary>
    /// <param name="userId"></param>
    public DiscountRecordDCache(string userId)
    {
        RedisKey = GetProjectRedisKey() + $":{userId}";
        _userId = userId;
    }

    /// <summary>
    /// GetField
    /// </summary>
    /// <param name="operatorId"></param>
    /// <param name="currencyId"></param>
    /// <returns></returns>
    public static string GetField(string operatorId, string currencyId) => $"{operatorId}|{currencyId}";

    /// <summary>
    /// LoadValueWhenRedisNotExistsAsync
    /// </summary>
    /// <param name="field"></param>
    /// <returns></returns>
    protected override async Task<CacheValue<CacheItem<List<S_requireflow_orderEO>>>> LoadValueWhenRedisNotExistsAsync(string field)
    {
        var ret = new CacheValue<CacheItem<List<S_requireflow_orderEO>>>();

        var keys = field.Split('|');
        //运营商编码
        var operatorId = keys[0];
        //货币编码
        var currencyId = keys[1];

        var time = DateTime.UtcNow.AddDays(-60).ToString("yyyy-MM-dd 00:00:00");
        var where = $"UserID = @UserID and OperatorID = @OperatorID and CurrencyID = @CurrencyID and IsBonus = 1 and RecDate >= @AppRequestTime";

        var value = await new S_requireflow_orderMO().GetAsync(where, _userId, operatorId, currencyId, time);

        ret.HasValue = value != null && value.Any();
        ret.Value = new CacheItem<List<S_requireflow_orderEO>>(value, TimeSpan.FromMinutes(EXPIRE_MINUTES));

        return ret;
    }

}
