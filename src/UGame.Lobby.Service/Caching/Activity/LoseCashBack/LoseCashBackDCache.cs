using UGame.Lobby.Service.Services.Home;
using UGame.Lobby.Repository.ing;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Caching;
using AiUo.Extensions.StackExchangeRedis;

namespace UGame.Lobby.Service.Caching.Activity.LoseCashBack
{

    public class LoseCashBackDCache : RedisStringClient<List<Sa_losecashback_configEO>>
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
        /// 
        /// </summary>
        /// <param name="operatorId"></param>
        /// <param name="currencyId"></param>
        public LoseCashBackDCache(string operatorId, string currencyId)
        {
            this.OperatorId = operatorId;
            this.CurrencyId = currencyId;
            RedisKey = GetProjectGroupRedisKey("Activity", $"{this.OperatorId}|{this.CurrencyId}");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        protected override async Task<CacheValue<List<Sa_losecashback_configEO>>> LoadValueWhenRedisNotExistsAsync()
        {
            var ret = new CacheValue<List<Sa_losecashback_configEO>>();
            ret.Value = await new Sa_losecashback_configMO().GetSortAsync("OperatorId = @OperatorId and CurrencyId = @CurrencyId", "ID", this.OperatorId, this.CurrencyId);

            ret.HasValue = ret.Value != null && ret.Value.Any();

            return ret;
        }

        public async Task<List<Sa_losecashback_configEO>> GetAsync()
        {
            var ret = new List<Sa_losecashback_configEO>();

            var cacheData = await GetOrLoadAsync(false, TimeSpan.FromDays(EXPIRE_DAY));

            if (cacheData.HasValue)
                return cacheData.Value;

            return ret;
        }

    }



}
