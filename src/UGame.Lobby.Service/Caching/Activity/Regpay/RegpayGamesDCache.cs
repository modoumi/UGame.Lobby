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
using UGame.Lobby.Service.Services.Home;

namespace UGame.Lobby.Service.Caching.Activity.Regpay
{
    /// <summary>
    /// RegpayGamesDCache
    /// </summary>
    public class RegpayGamesDCache : RedisHashExpireClient<List<CategoryMoreDto>>
    {
        private const int EXPIRE_MINUTES = 5;

        /// <summary>
        /// RegpayGamesDCache
        /// </summary>
        public RegpayGamesDCache()
        {
            RedisKey = GetProjectGroupRedisKey("Activity");
        }

        /// <summary>
        /// GetField
        /// </summary>
        /// <param name="operatorId"></param>
        /// <param name="langId"></param>
        /// <returns></returns>
        public static string GetField(string operatorId, string langId) => $"{operatorId}|{langId}";

        /// <summary>
        /// LoadValueWhenRedisNotExistsAsync
        /// </summary>
        /// <param name="field"></param>
        /// <returns></returns>
        protected override async Task<CacheValue<CacheItem<List<CategoryMoreDto>>>> LoadValueWhenRedisNotExistsAsync(string field)
        {
            var ret = new CacheValue<CacheItem<List<CategoryMoreDto>>>();

            var keys = field.Split('|');

            var operatorId = keys[0];
            var langId = keys[1];

            SqlSink sqlSink = new SqlSink();
            var data = sqlSink.RegpayRecommendGames(operatorId, langId);

            ret.HasValue = data != null && data.Any();
            ret.Value = new CacheItem<List<CategoryMoreDto>>(data, TimeSpan.FromMinutes(EXPIRE_MINUTES));

            return ret;
        }
    }

}
