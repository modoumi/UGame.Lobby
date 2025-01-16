using UGame.Lobby.Repository.ing;
using AiUo.Caching;
using AiUo.Extensions.StackExchangeRedis;

namespace UGame.Lobby.Service.Caching.Profile.UserRecords;

/// <summary>
/// DepositOrWithDrawRecordsDCache
/// </summary>
public class DepositOrWithDrawRecordsDCache : RedisHashExpireClient<List<Sb_bank_orderEO>>
{
    private const int EXPIRE_MINUTES = 5;

    private string _userId;

    /// <summary>
    /// DepositOrWithDrawRecordsDCache
    /// </summary>
    /// <param name="userId"></param>
    public DepositOrWithDrawRecordsDCache(string userId)
    {
        RedisKey = GetProjectRedisKey() + $":{userId}";
        _userId = userId;
    }

    /// <summary>
    /// LoadValueWhenRedisNotExistsAsync
    /// </summary>
    /// <param name="field"></param>
    /// <returns></returns>
    protected override async Task<CacheValue<CacheItem<List<Sb_bank_orderEO>>>> LoadValueWhenRedisNotExistsAsync(string field)
    {
        var ret = new CacheValue<CacheItem<List<Sb_bank_orderEO>>>();

        var keys = field.Split('|');
        //运营商编码
        var operatorId = keys[0];
        //货币编码
        var currencyId = keys[1];
        //充值or提现（1-充值;2-提现）
        var orderType = keys[2];

        var time = DateTime.UtcNow.AddDays(-90).ToString("yyyy-MM-dd 00:00:00");
        //只查询status = 1 or status = 2 or status = 3的数据，处理中or成功or失败
        var where = "UserID = @UserID and AppRequestTime >= @AppRequestTime and OrderType = @OrderType and CurrencyID = @CurrencyID and Status in(1,2,3)";
        var sort = "AppRequestTime desc";

        var value = await new Sb_bank_orderMO().GetSortAsync(where, sort, _userId, operatorId, currencyId, orderType, time);

        ret.HasValue = value != null && value.Any();
        ret.Value = new CacheItem<List<Sb_bank_orderEO>>(value, TimeSpan.FromMinutes(EXPIRE_MINUTES));

        return ret;
    }

}
