using UGame.Lobby.Repository.ing;
using StackExchange.Redis;
using AiUo.Caching;
using AiUo.Extensions.StackExchangeRedis;
using Xxyy.Common;

namespace UGame.Lobby.Service.Caching.Notify;

public class SCNotifyUsersDCache : RedisHashExpireClient<Sc_notifyEO>
{
    private const int EXPIRE_HOURS = 1;

    private string UserId { get; set; }

    public string AppId { get; set; }

    public int ActionAt { get; set; }

    public int ShowAt { get; set; }

    public string OperatorId { get; set; }

    private Sc_notifyMO _notifyMO = new();

    public SCNotifyUsersDCache(string userId, string appId, int actionAt, int showAt, string operatorId)
    {
        UserId = userId;
        AppId = appId;
        ActionAt = actionAt;
        ShowAt = showAt;
        OperatorId = operatorId;
        RedisKey = GetProjectGroupRedisKey("Notifys", $"{userId}:{AppId}|{ActionAt}|{ShowAt}|{OperatorId}");
    }

    protected override async Task<CacheValue<CacheItem<Sc_notifyEO>>> LoadValueWhenRedisNotExistsAsync(string field)
    {
        var ret = new CacheValue<CacheItem<Sc_notifyEO>>();
        ret.Value = new CacheItem<Sc_notifyEO>();

        var sql = BuildSearchSql();

        var notifyEo = await DbSink.MainDb.ExecSqlSingleAsync<Sc_notifyEO>(sql, DateTime.UtcNow, AppId, ActionAt, ShowAt, UserId, field);

        ret.HasValue = notifyEo != null;
        ret.Value = new CacheItem<Sc_notifyEO>(notifyEo, TimeSpan.FromHours(EXPIRE_HOURS));

        return ret;
    }

    protected override async Task<CacheValue<Dictionary<string, CacheItem<Sc_notifyEO>>>> LoadAllValuesWhenRedisNotExistsAsync()
    {
        var ret = new CacheValue<Dictionary<string, CacheItem<Sc_notifyEO>>>();
        ret.Value = new Dictionary<string, CacheItem<Sc_notifyEO>>();

        var sql = BuildSearchSql(true);

        var notifyUsersEoList = await DbSink.MainDb.ExecSqlListAsync<Sc_notifyEO>(sql, DateTime.UtcNow, AppId, ActionAt, ShowAt, UserId);

        if (notifyUsersEoList != null && notifyUsersEoList.Any())
        {
            ret.Value = notifyUsersEoList.GroupBy(d => d.NotifyID).ToDictionary(d => d.Key, d => new CacheItem<Sc_notifyEO>(d.FirstOrDefault(), TimeSpan.FromHours(EXPIRE_HOURS)));

            //foreach (var item in notifyUsersEoList)
            //{
            //    ret.Value.Add(item.NotifyID, new CacheItem<Sc_notifyEO>(item, TimeSpan.FromHours(EXPIRE_HOURS)));
            //}
        }

        ret.HasValue = ret.Value.Count > 0;

        return ret;
    }

    private string BuildSearchSql(bool IsAll = false)
    {
        string sql = $@"select 
	                        notify.*
                        from sc_notify_user as notifyUser
                        left join sc_notify as notify
                        on notifyUser.NotifyID = notify.NotifyID
                        where notify.`Status` = 1
                        and @TimeNow BETWEEN notify.BeginDate and notify.EndDate
                        and notify.AppID = @AppID
                        and notify.ActionAt = @ActionAt
                        and 0 < ShowAt & @ShowAt
                        and notifyUser.UserID = @UserID";

        if (!IsAll)
            sql += " and notify.NotifyID = @NotifyID ";

        sql += " order by notify.RecDate desc ";

        return sql;
    }

    public async Task<bool> ProcessSetAsync(string field, Sc_notifyEO notifyEO)
    {
        return await SetAsync(field, notifyEO, TimeSpan.FromHours(EXPIRE_HOURS), false);
    }

}
