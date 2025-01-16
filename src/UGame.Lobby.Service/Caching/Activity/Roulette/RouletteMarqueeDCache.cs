using UGame.Lobby.Repository.ing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Caching;
using AiUo.Extensions.AutoMapper;
using AiUo.Extensions.StackExchangeRedis;
using UGame.Lobby.Service.Services.Activity.Roulette;
using Xxyy.Common;

namespace UGame.Lobby.Service.Caching.Activity.Roulette
{
    /// <summary>
    /// RouletteMarqueeDCache
    /// </summary>
    public class RouletteMarqueeDCache : RedisStringClient<List<RouletteMarqueeDto>>
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
        /// RouletteMarqueeDCache
        /// </summary>
        public RouletteMarqueeDCache(string operatorId, string currencyId)
        {
            this.OperatorId = operatorId;
            this.CurrencyId = currencyId;
            RedisKey = GetProjectGroupRedisKey("Activity");
        }

        /// <summary>
        /// LoadValueWhenRedisNotExistsAsync
        /// </summary>
        /// <returns></returns>
        protected override async Task<CacheValue<List<RouletteMarqueeDto>>> LoadValueWhenRedisNotExistsAsync()
        {
            var ret = new CacheValue<List<RouletteMarqueeDto>>();

            var mo = new Sa_roulette_detailMO();

            var value = await mo.GetSortAsync($"OperatorID = @OperatorID and CurrencyID = @CurrencyID and Status = @Status and Bonus > 0", "RaffleType,UserType,`Level`,PreRewardType", this.OperatorId, this.CurrencyId, (int)OrderStatus.Success);

            ret.Value = value.Map<List<RouletteMarqueeDto>>();
            ret.HasValue = ret.Value != null && ret.Value.Any();

            return ret;
        }

        /// <summary>
        /// GetAsync
        /// </summary>
        /// <returns></returns>
        public async Task<CacheValue<List<RouletteMarqueeDto>>> GetAsync()
        {
            return await GetOrLoadAsync(false, TimeSpan.FromDays(EXPIRE_MINUTES));

        }

        /// <summary>
        /// SetAsync
        /// </summary>
        /// <returns></returns>
        public async Task SetAsync()
        {
            await GetOrLoadAsync(true, TimeSpan.FromDays(EXPIRE_MINUTES));
        }

    }

}
