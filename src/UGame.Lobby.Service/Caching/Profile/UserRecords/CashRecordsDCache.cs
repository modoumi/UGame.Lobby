using UGame.Lobby.Repository.ing;
using AiUo.Caching;
using AiUo.Extensions.AutoMapper;
using AiUo.Extensions.StackExchangeRedis;
using UGame.Lobby.Service.Services.Profile;

namespace UGame.Lobby.Service.Caching.Profile.UserRecords;

public class CashRecordsDCache : RedisStringClient<List<Sb_bank_orderEO>>
{
    private const int EXPIRE_MINUTES = 5;

    private string _userId;

    private DateTime _startTime;

    private DateTime _endTime;

    public CashRecordsDCache(string userId, DateTime startTime, DateTime endTime)
    {
        _userId = userId;
        _startTime = startTime;
        _endTime = endTime;
        RedisKey = GetProjectGroupRedisKey("UserRecords", _userId);
    }

    protected override async Task<CacheValue<List<Sb_bank_orderEO>>> LoadValueWhenRedisNotExistsAsync()
    {
        
        var where = "UserID = @UserID and AppRequestTime >= @StartTime and AppRequestTime <= @EndTime and OrderType = 2";
        var sort = "AppRequestTime desc";

        var dbList = await new Sb_bank_orderMO().GetSortAsync(where, sort, _userId, this._startTime, this._endTime);

        var ret = new CacheValue<List<Sb_bank_orderEO>>
        {
            HasValue = dbList != null && dbList.Any(),
            Value = dbList
        };

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

        if (cache.HasValue)
        {
            ret = cache.Value.Map<List<PayCashRecordsDto>>();
            foreach (var item in ret)
            {
                item.BankID = LobbyDbCacheUtil.GetBankPaytypeChannel(item.BankID,item.PaytypeID,item.PaytypeChannel,false)?.ChannelName;
            }
        }
        //非成功状态的提现审批数据
        ret.AddRange(await GetCashAudit());

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

    /// <summary>
    /// 非成功状态的提现审批数据
    /// </summary>
    /// <returns></returns>
    private async Task<List<PayCashRecordsDto>> GetCashAudit()
    {
        var ret = new List<PayCashRecordsDto>();

        var dbData = await new Sc_cash_auditMO().GetAsync("UserId = @UserId and Status <> 4 and ApplyTime >= @StartTime and ApplyTime < @EndTime and IsAudit=1", this._userId, this._startTime, this._endTime);


        if (dbData != null && dbData.Any())
            ret = dbData.Map<List<PayCashRecordsDto>>();

        return ret;
    }

}
