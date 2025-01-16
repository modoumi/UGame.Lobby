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
    /// RouletteConfigDCache
    /// </summary>
    public class RouletteConfigDCache : RedisStringClient<Sa_roulette_configEO>
    {
        private const int EXPIRE_MINUTES = 20;

        /// <summary>
        /// 运营商编码
        /// </summary>
        private string OperatorId { get; set; }

        /// <summary>
        /// 货币编码
        /// </summary>
        private string CurrencyId { get; set; }

        /// <summary>
        /// RouletteConfigDCache
        /// </summary>
        public RouletteConfigDCache(string operatorId, string currencyId)
        {
            this.OperatorId = operatorId;
            this.CurrencyId = currencyId;
            RedisKey = GetProjectGroupRedisKey("Activity",$"{this.OperatorId}|{this.CurrencyId}");
        }

        /// <summary>
        /// LoadValueWhenRedisNotExistsAsync
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        protected override async Task<CacheValue<Sa_roulette_configEO>> LoadValueWhenRedisNotExistsAsync()
        {
            var mo = new Sa_roulette_configMO();

            var ret = new CacheValue<Sa_roulette_configEO>();
            ret.Value = await mo.GetSingleAsync($"OperatorID = @OperatorID and CurrencyId = @CurrencyId", this.OperatorId, this.CurrencyId);

            ret.HasValue = ret.Value != null;

            return ret;
        }

        /// <summary>
        /// GetAsync
        /// </summary>
        /// <returns></returns>
        public async Task<CacheValue<Sa_roulette_configEO>> GetAsync()
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
