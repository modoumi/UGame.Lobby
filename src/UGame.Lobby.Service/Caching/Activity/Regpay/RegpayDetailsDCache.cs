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

namespace UGame.Lobby.Service.Caching.Activity.Regpay
{
    public class RegpayDetailsDCache : RedisStringClient<List<Sa_regpay_detailEO>>
    {
        public string OperatorId { get; set; }

        public string UserId { get; set; }

        public RegpayDetailsDCache(string operatorId, string userId)
        {
            this.OperatorId = operatorId;
            this.UserId = userId;
            RedisKey = GetProjectGroupRedisKey("Activity", $"{operatorId}:{userId}");
        }

        /// <summary>
        /// LoadValueWhenRedisNotExistsAsync
        /// </summary>
        /// <returns></returns>
        protected override async Task<CacheValue<List<Sa_regpay_detailEO>>> LoadValueWhenRedisNotExistsAsync()
        {
            var ret = new CacheValue<List<Sa_regpay_detailEO>>();

            ret.Value = await new Sa_regpay_detailMO().GetSortAsync("UserID = @UserID", "RecDate desc", UserId);
            ret.HasValue = ret.Value != null && ret.Value.Any();

            return ret;
        }

    }
}
