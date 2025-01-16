using UGame.Lobby.Repository.ing;
using AiUo;
using AiUo.Caching;
using AiUo.Extensions.AutoMapper;
using AiUo.Extensions.StackExchangeRedis;
using UGame.Lobby.Service.Services.Profile;

namespace UGame.Lobby.Service.Caching.Profile;

/// <summary>
/// PersonalInfoFormDCache
/// </summary>
public class PersonalInfoFormDCache : RedisStringClient<List<PersonalInfoFormDto>>
{
    private const int EXPIRE_MINUTES = 10;

    /// <summary>
    /// 国家编码
    /// </summary>
    public string CountryId { get; set; }
    /// <summary>
    /// 语言编码
    /// </summary>
    public string LangId { get; set; }

    /// <summary>
    /// PersonalInfoFormDCache
    /// </summary>
    /// <param name="countryId"></param>
    /// <param name="langId"></param>
    public PersonalInfoFormDCache(string countryId, string langId)
    {
        this.CountryId = countryId;
        this.LangId = langId;
        RedisKey = GetProjectGroupRedisKey("LUser", $"{this.CountryId}|{this.LangId}");
    }

    /// <summary>
    /// LoadValueWhenRedisNotExistsAsync
    /// </summary>
    /// <returns></returns>
    /// <exception cref="CustomException"></exception>
    protected override async Task<CacheValue<List<PersonalInfoFormDto>>> LoadValueWhenRedisNotExistsAsync()
    {
        var mo = new L_user_info_field_langMO();

        var sort = "OrderNum";

        var items = await mo.GetSortAsync($"CountryID = @CountryID and LangID = @LangID", sort, this.CountryId, this.LangId);

        if (items == null || !items.Any())
            items = await mo.GetSortAsync($"CountryID = @CountryID and (LangID = '' or LangID = null)", sort, CountryId);

        if (items == null || !items.Any())
            throw new CustomException($"The countryId({this.CountryId}) and langId({this.LangId}) data do not exist");

        var ret = new CacheValue<List<PersonalInfoFormDto>>
        {
            Value = items.Map<List<PersonalInfoFormDto>>()
        };
        ret.HasValue = ret.Value != null && ret.Value.Any();

        return ret;
    }

    /// <summary>
    /// GetAsync
    /// </summary>
    /// <returns></returns>
    public async Task<CacheValue<List<PersonalInfoFormDto>>> GetAsync()
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
