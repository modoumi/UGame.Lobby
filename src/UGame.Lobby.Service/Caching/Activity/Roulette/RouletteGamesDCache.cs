using UGame.Lobby.Service.Caching.Home;
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

namespace UGame.Lobby.Service.Caching.Activity.Roulette
{
    /// <summary>
    /// RouletteGamesDCache
    /// </summary>
    public class RouletteGamesDCache : RedisStringClient<List<RouletteGamesDto>>
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
        /// RouletteGamesDCache
        /// </summary>
        public RouletteGamesDCache(string operatorId, string currencyId)
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
        protected override async Task<CacheValue<List<RouletteGamesDto>>> LoadValueWhenRedisNotExistsAsync()
        {
            var ret = new CacheValue<List<RouletteGamesDto>>();

            var configDCache = new RouletteConfigDCache(this.OperatorId, this.CurrencyId);
            var rouletteConfig = await configDCache.GetAsync();

            if (!rouletteConfig.HasValue)
                throw new Exception($"RouletteGamesDCache.The operatorId({this.OperatorId}) and CurrencyId({this.CurrencyId}) data do not exist.");

            var appIds = rouletteConfig.Value.RecommendGames.Replace("|", "','");

            var mo = new L_appMO();

            var data = await mo.GetAsync($"AppID in ('{appIds}')");
            ret.Value = data.Map<List<RouletteGamesDto>>();
            ret.HasValue = ret.Value != null && ret.Value.Any();

            return ret;
        }

        /// <summary>
        /// GetAsync
        /// </summary>
        /// <returns></returns>
        public async Task<CacheValue<List<RouletteGamesDto>>> GetAsync()
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
