using UGame.Lobby.Repository.ing;
using AiUo.Caching;
using AiUo.Data.SqlSugar;
using AiUo.Extensions.StackExchangeRedis;

namespace UGame.Lobby.Service.Caching.Profile.UserRecords;

public class BetRecordDCache : RedisStringClient<List<Sr_user_dayPO>>
{
    private const int EXPIRE_MINUTES = 10;

    private string _userId;

    public BetRecordDCache(string userId)
    {
        _userId = userId;
        RedisKey = GetProjectGroupRedisKey("UserRecords", _userId);
    }

    protected override async Task<CacheValue<List<Sr_user_dayPO>>> LoadValueWhenRedisNotExistsAsync()
    {
        var dbList = await DbUtil.GetRepository<Sr_user_dayPO>().AsQueryable()
            .Where(_ => _.UserID == _userId && _.RecDate >= DateTime.UtcNow.AddDays(-90) && (_.BetAmount > 0 || _.WinAmount > 0))
            .OrderByDescending(_ => _.RecDate)
            .ToListAsync();

        var ret = new CacheValue<List<Sr_user_dayPO>>
        {
            HasValue = dbList != null && dbList.Any(),
            Value = dbList
        };

        return ret;
    }

    /// <summary>
    /// Get
    /// </summary>
    /// <returns></returns>
    public async Task<List<Sr_user_dayPO>> Get()
    {
        var ret = new List<Sr_user_dayPO>();

        var cache = await GetOrLoadAsync(false, TimeSpan.FromMinutes(EXPIRE_MINUTES));

        if (cache.HasValue)
            ret = cache.Value;

        return ret;
    }

    /// <summary>
    /// Set
    /// </summary>
    /// <returns></returns>
    public async Task Set()
    {
        await GetOrLoadAsync(true, TimeSpan.FromMinutes(EXPIRE_MINUTES));
    }
}
