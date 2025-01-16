using UGame.Lobby.Repository.ing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Caching;
using AiUo.Extensions.StackExchangeRedis;

namespace UGame.Lobby.Service.Caching.Activity.InviteNewUser
{

    /// <summary>
    /// InviteUser100013ConfigDCache
    /// </summary>
    public class InviteUser100013ConfigDCache : RedisStringClient<Sa_invite100013_configEO>
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
        public InviteUser100013ConfigDCache(string operatorId, string currencyId)
        {
            this.OperatorId = operatorId;
            this.CurrencyId = currencyId;
            RedisKey = GetProjectGroupRedisKey("Activity", $"{this.OperatorId}|{this.CurrencyId}");
        }

        /// <summary>
        /// LoadValueWhenRedisNotExistsAsync
        /// </summary>
        /// <returns></returns>
        protected override async Task<CacheValue<Sa_invite100013_configEO>> LoadValueWhenRedisNotExistsAsync()
        {
            var ret = new CacheValue<Sa_invite100013_configEO>();

            ret.Value = await new Sa_invite100013_configMO().GetSingleAsync("OperatorId = @OperatorId and CurrencyId = @CurrencyId", this.OperatorId, this.CurrencyId);

            ret.HasValue = ret.Value != null;

            return ret;
        }

        /// <summary>
        /// GetAsync
        /// </summary>
        /// <returns></returns>
        public async Task<Sa_invite100013_configEO> GetAsync()
        {
            var cache = await GetOrLoadAsync(false, TimeSpan.FromDays(EXPIRE_DAY));

            if (cache.HasValue)
                return cache.Value;

            return new Sa_invite100013_configEO();
        }

    }

}
