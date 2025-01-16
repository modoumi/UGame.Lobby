using UGame.Lobby.Repository.ing;
using AiUo.Caching;
using AiUo.Extensions.StackExchangeRedis;

namespace UGame.Lobby.Service.Caching.Profile;

/// <summary>
/// BankPaytypeChannelDCache
/// </summary>
public class BankPaytypeChannelDCache : RedisListClient<Sb_bank_paytype_channelEO>
{

    private const int EXPIRE_MINUTES = 5;
    private static BankPaytypeChannelDCache _instance = new BankPaytypeChannelDCache();
    public static BankPaytypeChannelDCache Create() => _instance;

    private BankPaytypeChannelDCache()
    {
        RedisKey = GetProjectRedisKey();
    }

    protected override async Task<CacheValue<IEnumerable<Sb_bank_paytype_channelEO>>> LoadAllValuesWhenRedisNotExistsAsync()
    {
        var ret = new CacheValue<IEnumerable<Sb_bank_paytype_channelEO>>
        {
            Value = await new Sb_bank_paytype_channelMO().GetAllAsync()
        };
        ret.HasValue = ret.Value != null && ret.Value.Any();

        return ret;
    }


    public async Task<IEnumerable<Sb_bank_paytype_channelEO>> GetCacheData()
    {
        var ret = await _instance.GetAllOrLoadAsync();

        if (!ret.HasValue)
            return new List<Sb_bank_paytype_channelEO>();

        base.Database.KeyExpire(RedisKey, TimeSpan.FromMinutes(EXPIRE_MINUTES));

        if (ret.HasValue)
            return ret.Value;

        return new List<Sb_bank_paytype_channelEO>();
    }
}
