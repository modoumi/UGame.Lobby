using UGame.Lobby.Service.Services.Activity.Roulette;
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
    /// RouletteOddsDCache
    /// </summary>
    public class RouletteOddsDCache : RedisStringClient<List<Sa_roulette_oddsEO>>
    {
        private const int EXPIRE_MINUTES = 20;

        /// <summary>
        /// 运营商编码
        /// </summary>
        public string OperatorId { get; set; }
        /// <summary>
        /// 货币编码
        /// </summary>
        public string CurrencyId { get; set; }

        /// <summary>
        /// RouletteOddsDCache
        /// </summary>
        public RouletteOddsDCache(string operatorId, string currencyId)
        {
            this.OperatorId = operatorId;
            this.CurrencyId = currencyId;
            RedisKey = GetProjectGroupRedisKey("Activity", $"{this.OperatorId}|{this.CurrencyId}");
        }

        /// <summary>
        /// LoadValueWhenRedisNotExistsAsync
        /// </summary>
        /// <returns></returns>
        protected override async Task<CacheValue<List<Sa_roulette_oddsEO>>> LoadValueWhenRedisNotExistsAsync()
        {
            var ret = new CacheValue<List<Sa_roulette_oddsEO>>();

            ret.Value = await new Sa_roulette_oddsMO().GetSortAsync($"OperatorID = @OperatorID and CurrencyID = @CurrencyID", "RaffleType,UserType,`Level`,PreRewardType,OrderNum", this.OperatorId, this.CurrencyId);

            ret.HasValue = ret.Value != null && ret.Value.Any();

            return ret;
        }

        /// <summary>
        /// GetAsync
        /// </summary>
        /// <returns></returns>
        public async Task<CacheValue<List<Sa_roulette_oddsEO>>> GetAsync()
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
