using UGame.Lobby.Repository.ing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Caching;
using AiUo.Extensions.StackExchangeRedis;
using Xxyy.Common;

namespace UGame.Lobby.Service.Caching.Activity.Regpay
{

    public class TopLevelTypeGameDCache : RedisHashExpireClient<List<string>>
    {
        private const int EXPIRE_HOUR = 5;

        public TopLevelTypeGameDCache()
        {
            RedisKey = GetProjectGroupRedisKey("Activity");
        }

        /// <summary>
        /// LoadValueWhenRedisNotExistsAsync
        /// </summary>
        /// <param name="field"></param>
        /// <returns></returns>
        protected override async Task<CacheValue<CacheItem<List<string>>>> LoadValueWhenRedisNotExistsAsync(string field)
        {
            var ret = new CacheValue<CacheItem<List<string>>>();

            var value = await DbSink.MainDb.ExecSqlListAsync<string>($@"select AppID from l_category_app 
                                                                where ParentID in(
                                                                select CategoryID from l_category 
                                                                where TopLevelType = 1
                                                                and OperatorID = @OperatorID
                                                                )
                                                                group by AppID", field);
            ret.HasValue = value != null && value.Any();
            ret.Value = new CacheItem<List<string>>(value, TimeSpan.FromHours(EXPIRE_HOUR));

            return ret;
        }

    }

}
