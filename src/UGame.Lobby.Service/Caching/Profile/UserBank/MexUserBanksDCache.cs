using UGame.Lobby.Repository.ing;
using AiUo.Caching;
using AiUo.Extensions.StackExchangeRedis;

namespace UGame.Lobby.Service.Caching.Profile.UserBank;

public class MexUserBanksDCache : RedisStringClient<List<L_user_bank_infoEO>>
{
    private const int EXPIRE_MINUTES = 5;

    private string OperatorId { get; set; }

    private string UserId { get; set; }

    public MexUserBanksDCache(string operatorId, string userId)
    {
        OperatorId = operatorId;
        UserId = userId;
        RedisKey = GetProjectGroupRedisKey("UserBank", $"{operatorId}:{userId}");
    }

    protected override async Task<CacheValue<List<L_user_bank_infoEO>>> LoadValueWhenRedisNotExistsAsync()
    {
        var ret = new CacheValue<List<L_user_bank_infoEO>>
        {
            Value = await new L_user_bank_infoMO().GetSortAsync("UserID = @UserID", "RecDate desc", UserId)
        };
        ret.HasValue = ret.Value != null && ret.Value.Any();

        return ret;
    }

    /// <summary>
    /// GetAsync
    /// </summary>
    /// <returns></returns>
    public async Task<CacheValue<List<L_user_bank_infoEO>>> GetAsync()
    {
        return await GetOrLoadAsync(false, TimeSpan.FromMinutes(EXPIRE_MINUTES));
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
