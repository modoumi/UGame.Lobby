using UGame.Lobby.Repository.ing;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Caching;
using AiUo.Extensions.StackExchangeRedis;

namespace UGame.Lobby.Service.Caching.Activity.Roulette
{
    /// <summary>
    /// RouletteUserDCache
    /// </summary>
    public class RouletteUserDCache : RedisStringClient<Sa_roulette_userEO>
    {

        private const int EXPIRE_MINUTE = 10;

        /// <summary>
        /// 运营商编码
        /// </summary>
        public string OperatorId { get; set; }
        /// <summary>
        /// 用户编码
        /// </summary>
        public string UserId { get; set; }
        /// <summary>
        /// RouletteUserDCache
        /// </summary>
        /// <param name="operatorId"></param>
        /// <param name="userId"></param>
        public RouletteUserDCache(string operatorId, string userId)
        {
            this.OperatorId = operatorId;
            this.UserId = userId;
            RedisKey = GetProjectGroupRedisKey("Activity", $"{operatorId}:{userId}");
        }

        /// <summary>
        /// LoadValueWhenRedisNotExistsAsync
        /// </summary>
        /// <returns></returns>
        protected override async Task<CacheValue<Sa_roulette_userEO>> LoadValueWhenRedisNotExistsAsync()
        {
            var ret = new CacheValue<Sa_roulette_userEO>();

            ret.Value = await new Sa_roulette_userMO().GetSingleAsync("UserId = @UserId", this.UserId);
            ret.HasValue = ret.Value != null;

            return ret;
        }


        /// <summary>
        /// GetAsync
        /// </summary>
        /// <returns></returns>
        public async Task<CacheValue<Sa_roulette_userEO>> GetAsync()
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

}
