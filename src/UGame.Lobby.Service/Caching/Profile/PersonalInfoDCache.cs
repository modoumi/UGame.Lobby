using UGame.Lobby.Repository.ing;
using AiUo.Caching;
using AiUo.Extensions.StackExchangeRedis;

namespace UGame.Lobby.Service.Caching.Profile;

/// <summary>
/// 运营商活动配置数据
/// </summary>
public class PersonalInfoDCache : RedisStringClient<L_user_infoEO>
{
    private const int EXPIRE_MINUTE = 10;

    private string UserId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="userId">用户编码</param>
    public PersonalInfoDCache(string userId)
    {
        this.UserId = userId;
        RedisKey = GetProjectGroupRedisKey("LUser", $"{this.UserId}");
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    protected override async Task<CacheValue<L_user_infoEO>> LoadValueWhenRedisNotExistsAsync()
    {
        var ret = new CacheValue<L_user_infoEO>
        {
            Value = await new L_user_infoMO().GetSingleAsync("UserID = @UserID", this.UserId)
        };

        ret.HasValue = ret.Value != null;

        return ret;
    }

    /// <summary>
    /// GetAsync
    /// </summary>
    /// <returns></returns>
    public async Task<CacheValue<L_user_infoEO>> GetAsync()
    {
        return await GetOrLoadAsync(false, TimeSpan.FromDays(EXPIRE_MINUTE));

    }

    /// <summary>
    /// SetAsync
    /// </summary>
    /// <returns></returns>
    public async Task SetAsync()
    {
        await GetOrLoadAsync(true, TimeSpan.FromDays(EXPIRE_MINUTE));
    }
}
