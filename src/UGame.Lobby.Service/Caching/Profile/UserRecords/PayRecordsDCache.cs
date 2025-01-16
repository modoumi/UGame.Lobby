using UGame.Lobby.Repository.ing;
using AiUo.Caching;
using AiUo.Extensions.AutoMapper;
using AiUo.Extensions.StackExchangeRedis;
using UGame.Lobby.Service.Services.Profile;

namespace UGame.Lobby.Service.Caching.Profile.UserRecords;

public class PayRecordsDCache : RedisStringClient<List<Sb_bank_orderEO>>
{
    private const int EXPIRE_MINUTES = 5;

    private readonly string _userId;

    private readonly DateTime _startTime;

    private readonly DateTime _endTime;

    public PayRecordsDCache(string userId, DateTime startTime, DateTime endTime)
    {
        _userId = userId;
        _startTime = startTime;
        _endTime = endTime;
        RedisKey = GetProjectGroupRedisKey("UserRecords", _userId);
    }

    protected override async Task<CacheValue<List<Sb_bank_orderEO>>> LoadValueWhenRedisNotExistsAsync()
    {
        var bankOrderMo = new Sb_bank_orderMO();

        var where = "UserId = @UserId and AppRequestTime >= @StartTime and AppRequestTime <= @EndTime and OrderType = 1";

        var ret = new CacheValue<List<Sb_bank_orderEO>>
        {
            Value = await bankOrderMo.GetAsync(where, this._userId, this._startTime, this._endTime)
        };
        ret.HasValue = ret.Value != null && ret.Value.Any();

        return ret;
    }

    /// <summary>
    /// GetAsync
    /// </summary>
    /// <param name="isCache">是否使用缓存</param>
    /// <returns></returns>
    public async Task<List<PayCashRecordsDto>> GetAsync(bool isCache = false)
    {
        var ret = new List<PayCashRecordsDto>();

        var cache = await GetOrLoadAsync(isCache, TimeSpan.FromMinutes(EXPIRE_MINUTES));

        if (cache.HasValue)
        {
            ret = cache.Value.Map<List<PayCashRecordsDto>>();
            foreach (var item in ret)
            {
                item.BankID = LobbyDbCacheUtil.GetBankPaytypeChannel(item.BankID, item.PaytypeID, item.PaytypeChannel, false)?.ChannelName;
            }
        }
        return ret;
    }

    /// <summary>
    /// SetAsync
    /// </summary>
    /// <returns></returns>
    public async Task SetAsync()
    {
        await GetOrLoadAsync(true, TimeSpan.FromMinutes(EXPIRE_MINUTES));
    }
}
