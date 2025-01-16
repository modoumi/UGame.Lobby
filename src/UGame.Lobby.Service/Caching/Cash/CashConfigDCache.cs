using UGame.Lobby.Repository.ing;
using AiUo.Caching;
using AiUo.Data.SqlSugar;
using AiUo.Extensions.StackExchangeRedis;

namespace UGame.Lobby.Service.Caching.WithDraw;

/// <summary>
/// 提现配置缓存
/// </summary>
public class CashConfigDCache : RedisHashExpireClient<Sc_cash_configPO>
{
    private const int EXPIRE_DAY = 1;

    public CashConfigDCache()
    {
        RedisKey = GetProjectGroupRedisKey("CashConfig");
    }

    public static string GetField(string operatorId, string currencyId) => $"{operatorId}|{currencyId}";


    protected override async Task<CacheValue<CacheItem<Sc_cash_configPO>>> LoadValueWhenRedisNotExistsAsync(string field)
    {
        var ret = new CacheValue<CacheItem<Sc_cash_configPO>>
        {
            Value = new CacheItem<Sc_cash_configPO>()
        };

        var keys = field.Split('|');
        var operatorId = keys[0];
        var currencyId = keys[1];

        ret.Value.Value = await DbUtil.GetRepository<Sc_cash_configPO>().AsQueryable()
            .Where(_ => _.OperatorID == operatorId && _.CurrencyID == currencyId)
            .FirstAsync();

        if (ret.Value.Value == null)
            throw new Exception($"RouletteConfig.The operatorId({operatorId}) and CurrencyId({currencyId}) data do not exist.");

        ret.HasValue = ret.Value.Value != null;
        ret.Value = new CacheItem<Sc_cash_configPO>(ret.Value.Value, TimeSpan.FromDays(EXPIRE_DAY));

        return ret;
    }

}
