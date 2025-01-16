
using AiUo.Extensions.StackExchangeRedis;
using UGame.Lobby.Repository.ing;
using AiUo.Caching;

namespace UGame.Lobby.Service.Caching.Profile;

/// <summary>
/// Spei支持的银行卡缓存
/// </summary>
public class SpeiBanksDCache : RedisStringClient<List<Sb_mongopay_bankcodeEO>>
{
    private const int EXPIRE_DAY = 1;

    private static SpeiBanksDCache _instance = new SpeiBanksDCache();

    public static SpeiBanksDCache Create() => _instance;

    private SpeiBanksDCache()
    {
        RedisKey = GetProjectRedisKey();
    }

    protected override async Task<CacheValue<List<Sb_mongopay_bankcodeEO>>> LoadValueWhenRedisNotExistsAsync()
    {
        var ret = new CacheValue<List<Sb_mongopay_bankcodeEO>>();

        ret.Value = await new Sb_mongopay_bankcodeMO().GetSortAsync("1 = 1", "BankName");
        ret.HasValue = ret.Value != null && ret.Value.Any();

        return ret;
    }

    /// <summary>
    /// GetAsync
    /// </summary>
    /// <returns></returns>
    public async Task<CacheValue<List<Sb_mongopay_bankcodeEO>>> GetAsync()
    {
        return await GetOrLoadAsync(false, TimeSpan.FromDays(EXPIRE_DAY));
    }

    /// <summary>
    /// SetAsync
    /// </summary>
    /// <returns></returns>
    public async Task SetAsync()
    {
        await GetOrLoadAsync(true, TimeSpan.FromDays(EXPIRE_DAY));
    }
}
