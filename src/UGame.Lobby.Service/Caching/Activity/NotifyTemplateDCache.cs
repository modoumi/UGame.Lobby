using Google.Protobuf.WellKnownTypes;
using UGame.Lobby.Repository.ing;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Caching;
using AiUo.Extensions.StackExchangeRedis;
using Xxyy.DAL;

namespace UGame.Lobby.Service.Caching.Activity
{

    /// <summary>
    /// 活动通知模板
    /// </summary>
    public class NotifyTemplateDCache : RedisHashExpireClient<List<Sa_notify_templateEO>>
    {
        private const int EXPIRE_DAY = 1;

        public NotifyTemplateDCache()
        {
            RedisKey = GetProjectGroupRedisKey("Notifys:Temp");
        }

        public static string GetField(string operatorId, string currencyId, int activityType) => $"{operatorId}|{currencyId}|{activityType}";

        protected override async Task<CacheValue<CacheItem<List<Sa_notify_templateEO>>>> LoadValueWhenRedisNotExistsAsync(string field)
        {
            var keys = field.Split('|');
            var operatorId = keys[0];
            var currencyId = keys[1];
            var activityType = keys[2];

            var ret = new CacheValue<CacheItem<List<Sa_notify_templateEO>>>();

            var dbList = await new Sa_notify_templateMO().GetAsync($"OperatorID = @OperatorID and CurrencyId = @CurrencyId and ActivityType = @ActivityType", operatorId, currencyId, activityType);

            ret.HasValue = dbList != null && dbList.Any();
            ret.Value = new CacheItem<List<Sa_notify_templateEO>>(dbList, TimeSpan.FromDays(EXPIRE_DAY));
            return ret;
        }

    }

}
