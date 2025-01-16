using AiUo.Caching;
using AiUo.Extensions.AutoMapper;
using AiUo.Extensions.StackExchangeRedis;
using UGame.Lobby.Service.Services.Profile;
using Xxyy.DAL;

namespace UGame.Lobby.Service.Caching.Profile.UserRecords;

public class BonusRecordDCache : RedisStringClient<List<S_currency_changeEO>>
{
    private const int EXPIRE_MINUTES = 5;

    private readonly string _userId;

    private readonly DateTime? _startTime;

    private readonly DateTime? _endTime;

    public BonusRecordDCache(string userId, DateTime startTime, DateTime endTime)
    {
        _userId = userId;
        _startTime = startTime;
        _endTime = endTime;
        RedisKey = GetProjectGroupRedisKey("UserRecords", _userId);
    }

    protected override async Task<CacheValue<List<S_currency_changeEO>>> LoadValueWhenRedisNotExistsAsync()
    {
        var where = "UserID = @UserID and RecDate >= @StartTime and RecDate <= @EndTime and Amount > 0";

        var currencyChangeMo = new S_currency_changeMO();

        var ret = new CacheValue<List<S_currency_changeEO>>
        {
            Value = await currencyChangeMo.GetAsync(where, this._userId, this._startTime, this._endTime)
        };
        ret.HasValue = ret.Value != null && ret.Value.Any();

        return ret;
    }

    /// <summary>
    /// GetAsync
    /// </summary>
    /// <param name="isCache"></param>
    /// <returns></returns>
    public async Task<List<PayCashRecordsDto>> GetAsync(bool isCache = false)
    {
        var ret = new List<PayCashRecordsDto>();

        var cache = await GetOrLoadAsync(isCache, TimeSpan.FromMinutes(EXPIRE_MINUTES));

        if (cache.HasValue) ret = cache.Value.Map<List<PayCashRecordsDto>>();

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
