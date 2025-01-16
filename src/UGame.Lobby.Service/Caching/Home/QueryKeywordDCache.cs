using UGame.Lobby.Repository.ing;
using AiUo.Caching;
using AiUo.Data.SqlSugar;
using AiUo.Extensions.AutoMapper;
using AiUo.Extensions.StackExchangeRedis;
using UGame.Lobby.Service.Services.Home;

namespace UGame.Lobby.Service.Caching.Home;
public class QueryKeywordDCache : RedisStringClient<List<AppDetailDto>>
{
    private const int EXPIRE_MINUTES = 60;

    private string OperatorId { get; set; }

    private string KeywordId { get; set; }

    public QueryKeywordDCache(string operatorId, string keywordId)
    {
        this.OperatorId = operatorId;
        this.KeywordId = keywordId;
        RedisKey = GetProjectRedisKey($"{this.OperatorId}|{this.KeywordId}");
    }

    protected override async Task<CacheValue<List<AppDetailDto>>> LoadValueWhenRedisNotExistsAsync()
    {
        var ret = new CacheValue<List<AppDetailDto>>
        {
            Value = new List<AppDetailDto>()
        };

        long.TryParse(this.KeywordId, out long keywordId);

        var rsp = DbUtil.GetRepository<V_l_keyword_appPO>();

        var items = await rsp.AsQueryable()
            .Where(d => d.OperatorID.Equals(this.OperatorId) && d.KeywordID == keywordId)
            .ToListAsync();

        if (items == null || !items.Any())
        {
            items = await rsp.AsQueryable()
                .Where(d => string.IsNullOrWhiteSpace(d.OperatorID) && d.KeywordID == keywordId)
                .ToListAsync();
        }

        foreach (var item in items)
        {
            ret.Value.Add(item.Map<AppDetailDto>());
        }

        ret.HasValue = ret.Value != null && ret.Value.Any();

        return ret;
    }

    /// <summary>
    /// GetAsync
    /// </summary>
    /// <returns></returns>
    public async Task<CacheValue<List<AppDetailDto>>> GetAsync()
    {
        return await GetOrLoadAsync(false, TimeSpan.FromMinutes(EXPIRE_MINUTES));
    }

}
