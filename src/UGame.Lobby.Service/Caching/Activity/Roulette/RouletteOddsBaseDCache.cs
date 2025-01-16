using UGame.Lobby.Service.Services.Home;
using UGame.Lobby.Repository.ing;
using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Caching;
using AiUo.Extensions.StackExchangeRedis;
using UGame.Lobby.Service.Services.Activity.Roulette;
using Xxyy.Common;

namespace UGame.Lobby.Service.Caching.Activity.Roulette
{
    /// <summary>
    /// RouletteOddsBaseDCache
    /// </summary>
    public class RouletteOddsBaseDCache : RedisStringClient<List<RouletteOddsBaseDto>>
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
        /// RouletteOddsBaseDCache
        /// </summary>
        public RouletteOddsBaseDCache(string operatorId, string currencyId)
        {
            this.OperatorId = operatorId;
            this.CurrencyId = currencyId;
            RedisKey = GetProjectGroupRedisKey("Activity", $"{this.OperatorId}|{this.CurrencyId}");
        }

        /// <summary>
        /// LoadValueWhenRedisNotExistsAsync
        /// </summary>
        /// <returns></returns>
        protected override async Task<CacheValue<List<RouletteOddsBaseDto>>> LoadValueWhenRedisNotExistsAsync()
        {
            var ret = new CacheValue<List<RouletteOddsBaseDto>>();

            var mo = new Sa_roulette_oddsMO();

            var value = await mo.GetSortAsync($"OperatorID = @OperatorID and CurrencyID = @CurrencyID and RaffleType = 1 and UserType = 1", "Level,PreRewardType,OrderNum", this.OperatorId, this.CurrencyId);

            ret.Value = new List<RouletteOddsBaseDto>();
            foreach (var item in value)
            {
                var detailApp = GetDetailApp(item);

                if (item.PreRewardType == 0)
                {
                    detailApp.Items = new List<RouletteOddsBaseDto>();
                    ret.Value.Add(detailApp);
                }
                else
                {
                    var retItem = ret.Value.Where(d => d.RewardType == item.PreRewardType).FirstOrDefault();
                    retItem.Items.Add(detailApp);
                }
            }

            ret.HasValue = ret.Value != null && ret.Value.Any();

            return ret;
        }

        /// <summary>
        /// GetDetailApp
        /// </summary>
        /// <param name="eo"></param>
        /// <returns></returns>
        private RouletteOddsBaseDto GetDetailApp(Sa_roulette_oddsEO eo)
        {
            var ret = new RouletteOddsBaseDto
            {
                OperatorId = eo.OperatorID,
                CountryId = eo.CountryID,
                CurrencyId = eo.CurrencyID,
                RaffleType = eo.RaffleType,
                UserType = eo.UserType,
                Level = eo.Level,
                RewardType = eo.RewardType,
                PreRewardType = eo.PreRewardType,
                Position = eo.Position,
                Multiple = eo.Multiple,
                OrderNum = eo.OrderNum,
                Items = new List<RouletteOddsBaseDto>()
            };
            return ret;
        }

        /// <summary>
        /// GetAsync
        /// </summary>
        /// <returns></returns>
        public async Task<CacheValue<List<RouletteOddsBaseDto>>> GetAsync()
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
