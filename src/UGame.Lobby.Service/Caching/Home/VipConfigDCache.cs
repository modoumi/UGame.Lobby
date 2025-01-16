using UGame.Lobby.Repository.ing;
using AiUo.Caching;
using AiUo.Data.SqlSugar;
using AiUo.Extensions.StackExchangeRedis;

namespace UGame.Lobby.Service.Caching.Home;

public class VipConfigDCache : RedisStringClient<List<Sc_vip_configPO>>
{
    private const int EXPIRE_DAY = 1;

    private string OperatorId { get; set; }

    public VipConfigDCache(string operatorId)
    {
        OperatorId = operatorId;

        RedisKey = GetProjectRedisKey($"{OperatorId}|VIP");
    }

    protected override async Task<CacheValue<List<Sc_vip_configPO>>> LoadValueWhenRedisNotExistsAsync()
    {
        var ret = new CacheValue<List<Sc_vip_configPO>>
        {
            Value = await DbUtil.GetRepository<Sc_vip_configPO>().AsQueryable()
            .Where(d => d.OperatorID.Equals(OperatorId))
            .ToListAsync()
        };

        ret.HasValue = ret.Value != null && ret.Value.Any();

        return ret;
    }

    /// <summary>
    /// GetAsync
    /// </summary>
    /// <returns></returns>
    public async Task<CacheValue<List<Sc_vip_configPO>>> GetAsync()
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
