using UGame.Lobby.Service.Services.Activity.Roulette;
using UGame.Lobby.Repository.ing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo;
using AiUo.Caching;
using AiUo.Collections;
using AiUo.Extensions.StackExchangeRedis;

namespace UGame.Lobby.Service.Caching.Activity.Roulette101001
{
    public class Roulette101001OddsBaseDCache : RedisStringClient<List<Sa_roulette101001_oddsEO>>
    {
        private const int EXPIRE_DAY = 1;

        /// <summary>
        /// 运营商编码
        /// </summary>
        public string OperatorId { get; set; }

        /// <summary>
        /// 货币编码
        /// </summary>
        public string CurrencyId { get; set; }

        /// <summary>
        /// RouletteOddsBaseDCache
        /// </summary>
        public Roulette101001OddsBaseDCache(string operatorId, string currencyId)
        {
            this.OperatorId = operatorId;
            this.CurrencyId = currencyId;
            RedisKey = GetProjectGroupRedisKey("Activity", $"{this.OperatorId}|{this.CurrencyId}");
        }

        /// <summary>
        /// LoadValueWhenRedisNotExistsAsync
        /// </summary>
        /// <returns></returns>
        protected override async Task<CacheValue<List<Sa_roulette101001_oddsEO>>> LoadValueWhenRedisNotExistsAsync()
        {
            var ret = new CacheValue<List<Sa_roulette101001_oddsEO>>();

            var mo = new Sa_roulette101001_oddsMO();

            ret.Value = await mo.GetSortAsync($"OperatorID = @OperatorID and CurrencyID = @CurrencyID", "Position", this.OperatorId, this.CurrencyId);

            ret.HasValue = ret.Value != null && ret.Value.Any();

            return ret;
        }

        /// <summary>
        /// GetAsync
        /// </summary>
        /// <returns></returns>
        public async Task<List<Sa_roulette101001_oddsEO>> GetAsync()
        {
            var cacheData = await GetOrLoadAsync(false, TimeSpan.FromDays(EXPIRE_DAY));
            if (!cacheData.HasValue)
                throw new CustomException($"Roulette101001OddsBaseDCache.The operatorId({this.OperatorId}) and CurrencyId({this.CurrencyId}) data do not exist.");

            return cacheData.Value;
        }

    }
}
