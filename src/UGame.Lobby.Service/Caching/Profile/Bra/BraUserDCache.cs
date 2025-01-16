using UGame.Lobby.Service.Services.Profile;
using UGame.Lobby.Repository.ing;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Caching;
using AiUo.Extensions.AutoMapper;
using AiUo.Extensions.StackExchangeRedis;
using Xxyy.Common;

namespace UGame.Lobby.Service.Caching.Profile.Bra
{
    public class BraUserDCache : RedisStringClient<L_bra_userEO>
    {
        private const int EXPIRE_DAY = 1;

        private string UserId { get; set; }

        public BraUserDCache(string userId)
        {
            UserId = userId;
            RedisKey = GetProjectRedisKey(userId);
        }

        protected override async Task<CacheValue<L_bra_userEO>> LoadValueWhenRedisNotExistsAsync()
        {
            var ret = new CacheValue<L_bra_userEO>();
            ret.Value = await new L_bra_userMO().GetSingleAsync("UserID = @UserID", UserId);
            ret.HasValue = ret.Value != null;
            return ret;
        }

        /// <summary>
        /// GetAsync
        /// </summary>
        /// <returns></returns>
        public async Task<L_bra_userEO> GetAsync()
        {
            L_bra_userEO ret = null;

            var cache = await GetOrLoadAsync(false, TimeSpan.FromDays(EXPIRE_DAY));

            if (cache.HasValue)
                ret = cache.Value;

            return ret;
        }

        /// <summary>
        /// SetAsync
        /// </summary>
        /// <returns></returns>
        public async Task SetAsync()
        {
            await GetOrLoadAsync(true, TimeSpan.FromDays(EXPIRE_DAY));
        }
    }
}