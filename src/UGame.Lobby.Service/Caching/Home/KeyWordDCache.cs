using UGame.Lobby.Common.Enum;
using UGame.Lobby.Repository.ing;
using SqlSugar;
using AiUo.Caching;
using AiUo.Collections;
using AiUo.DbCaching;
using AiUo.Extensions.StackExchangeRedis;
using UGame.Lobby.Service.Services.Home;
using Xxyy.DAL;

namespace UGame.Lobby.Service.Caching.Home;

public class KeyWordDCache : RedisStringClient<List<AppDetailDto>>
{
    private const int EXPIRE_DAY = 1;

    private string OperatorId { get; set; }

    private string LangId { get; set; }

    private string KeyWard { get; set; }

    public KeyWordDCache(string operatorId, string langId, string keyWord)
    {
        OperatorId = operatorId;
        LangId = langId;
        KeyWard = keyWord.ToLower();
        RedisKey = GetProjectRedisKey($"{OperatorId}|{LangId}|{KeyWard}");
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    protected override async Task<CacheValue<List<AppDetailDto>>> LoadValueWhenRedisNotExistsAsync()
    {
        var sTagEoCache = await new TagDCache(OperatorId, LangId).GetAsync();
        var lAppEoList = DbCachingUtil.GetAllList<L_appPO>();
        var sAppList = DbCachingUtil.GetAllList<S_appPO>().Where(_ => _.Status == (int)StatusEnum.Valid)
             .Select(_ => new AppDetailDto { AppId = _.AppID, AppName = _.AppName, Status = _.Status });

        var dic = new Dictionary<string, string>();
        foreach (var item in sAppList)
        {
            if (item.AppName.ToLower().Contains(KeyWard))
            {
                dic.Add(item.AppId, item.AppName.ToLower());
            }
        }
        var result = from sApp in sAppList
                     where dic.ContainsKey(sApp.AppId)
                     join lApp in lAppEoList on sApp.AppId equals lApp.AppID
                     select new AppDetailDto
                     {
                         AppId = sApp.AppId,
                         AppName = sApp.AppName,
                         Status = sApp.Status,
                         Icon = lApp.SmallIcon,
                         SmallIcon = lApp.SmallIcon,
                         MiddleIcon = lApp.MiddleIcon,
                         BigIcon = lApp.BigIcon,
                         Flag = lApp.Flag,
                     };


        var ret = new CacheValue<List<AppDetailDto>> { Value = result.ToList() };

        ret.HasValue = ret.Value != null && ret.Value.Any();
        return ret;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public async Task<CacheValue<List<AppDetailDto>>> GetAsync()
    {
        return await GetOrLoadAsync(false, TimeSpan.FromDays(EXPIRE_DAY));
    }

}
