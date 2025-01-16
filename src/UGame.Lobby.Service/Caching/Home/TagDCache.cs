using UGame.Lobby.Repository.ing;
using AiUo.Caching;
using AiUo.Data.SqlSugar;
using AiUo.Extensions.StackExchangeRedis;

namespace UGame.Lobby.Service.Caching.Home;

/// <summary>
/// 标签缓存
/// </summary>
public class TagDCache : RedisStringClient<List<L_tagPO>>
{
    private const int EXPIRE_DAY = 1;
    private string OperatorId { get; set; }
    private string LangId { get; set; }

    public TagDCache(string operatorId, string langId)
    {
        OperatorId = operatorId;
        LangId = langId;
        RedisKey = GetProjectRedisKey($"{OperatorId}|{LangId}");
    }

    protected override async Task<CacheValue<List<L_tagPO>>> LoadValueWhenRedisNotExistsAsync()
    {
        var ret = new CacheValue<List<L_tagPO>>
        {
            Value = await DbUtil.GetRepository<L_tagPO>().AsQueryable()
            .Where(d =>d.OperatorID.Equals(OperatorId) && d.LangID.Equals(LangId))
            .ToListAsync()
        };

        ret.HasValue = ret.Value != null && ret.Value.Any();

        return ret;
    }

    /// <summary>
    /// GetAsync
    /// </summary>
    /// <returns></returns>
    public async Task<CacheValue<List<L_tagPO>>> GetAsync()
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
