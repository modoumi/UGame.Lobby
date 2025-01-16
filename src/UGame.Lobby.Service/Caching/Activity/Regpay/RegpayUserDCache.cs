using UGame.Lobby.Repository.ing;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Caching;
using AiUo.Extensions.StackExchangeRedis;

namespace UGame.Lobby.Service.Caching.Activity.Regpay
{
    public class RegpayUserDCache : RedisStringClient<Sa_regpay_userEO>
    {
        public string OperatorId { get; set; }

        public string UserId { get; set; }

        public RegpayUserDCache(string operatorId, string userId)
        {
            this.OperatorId = operatorId;
            this.UserId = userId;
            RedisKey = GetProjectGroupRedisKey("Activity", $"{operatorId}:{userId}"); 
        }

        /// <summary>
        /// LoadValueWhenRedisNotExistsAsync
        /// </summary>
        /// <returns></returns>
        protected override async Task<CacheValue<Sa_regpay_userEO>> LoadValueWhenRedisNotExistsAsync()
        {
            var ret = new CacheValue<Sa_regpay_userEO>();

            ret.Value = await new Sa_regpay_userMO().GetSingleAsync($"UserId = @UserId", UserId);
            ret.HasValue = ret.Value != null;

            return ret;
        }

    }
}
