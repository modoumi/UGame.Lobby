using UGame.Lobby.Service.Common;
using UGame.Lobby.Repository.ing;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo;
using AiUo.Caching;
using AiUo.Extensions.StackExchangeRedis;

namespace UGame.Lobby.Service.Caching.Activity.Roulette101001
{
    public class Roulette101001ConfigDCache : RedisStringClient<Sa_roulette101001_configEO>
    {
        private const int EXPIRE_DAY = 1;

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
        public Roulette101001ConfigDCache(string operatorId, string currencyId)
        {
            this.OperatorId = operatorId;
            this.CurrencyId = currencyId;
            RedisKey = GetProjectGroupRedisKey("Activity", $"{this.OperatorId}|{this.CurrencyId}");
        }

        /// <summary>
        /// LoadValueWhenRedisNotExistsAsync
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        protected override async Task<CacheValue<Sa_roulette101001_configEO>> LoadValueWhenRedisNotExistsAsync()
        {
            var mo = new Sa_roulette101001_configMO();

            var ret = new CacheValue<Sa_roulette101001_configEO>();
            ret.Value = await mo.GetSingleAsync($"OperatorID = @OperatorID and CurrencyId = @CurrencyId", this.OperatorId, this.CurrencyId);

            ret.HasValue = ret.Value != null;

            return ret;
        }

        /// <summary>
        /// GetAsync
        /// </summary>
        /// <returns></returns>
        public async Task<Sa_roulette101001_configEO> GetAsync()
        {
            var cache = await GetOrLoadAsync(false, TimeSpan.FromDays(EXPIRE_DAY));

            if (!cache.HasValue)
                throw new CustomException($"Roulette101001ConfigDCache.The operatorId({this.OperatorId}) and CurrencyId({this.CurrencyId}) data do not exist.");

            return cache.Value;
        }
    }

}
