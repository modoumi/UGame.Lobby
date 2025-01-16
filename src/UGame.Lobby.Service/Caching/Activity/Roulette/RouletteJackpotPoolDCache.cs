using Google.Protobuf.WellKnownTypes;
using UGame.Lobby.Repository.ing;
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
    /// RouletteJackpotPoolDCache
    /// </summary>
    public class RouletteJackpotPoolDCache : RedisStringClient<Sa_roulette_poolEO>
    {
        private const int EXPIRE_MINUTES = 10;

        /// <summary>
        /// 运营商编码
        /// </summary>
        public string OperatorId { get; set; }

        /// <summary>
        /// 货币编码
        /// </summary>
        public string CurrencyId { get; set; }

        /// <summary>
        /// RouletteJackpotPoolDCache
        /// </summary>
        public RouletteJackpotPoolDCache(string operatorId, string currencyId)
        {
            this.OperatorId = operatorId;
            this.CurrencyId = currencyId;
            RedisKey = GetProjectGroupRedisKey("Activity", $"{this.OperatorId}|{this.CurrencyId}");
        }

        /// <summary>
        /// LoadValueWhenRedisNotExistsAsync
        /// </summary>
        /// <returns></returns>
        protected override async Task<CacheValue<Sa_roulette_poolEO>> LoadValueWhenRedisNotExistsAsync()
        {
            var ret = new CacheValue<Sa_roulette_poolEO>();

            var mo = new Sa_roulette_poolMO();

            ret.Value = await mo.GetSingleAsync($"OperatorID = @OperatorID and CurrencyId = @CurrencyId", this.OperatorId, this.CurrencyId);
            ret.HasValue = ret.Value != null;

            return ret;
        }

        /// <summary>
        /// GetAsync
        /// </summary>
        /// <returns></returns>
        public async Task<CacheValue<Sa_roulette_poolEO>> GetAsync()
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

}
