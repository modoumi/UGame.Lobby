using UGame.Lobby.Repository.ing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Caching;
using AiUo.Extensions.StackExchangeRedis;

namespace UGame.Lobby.Service.Caching.Activity.Signin
{
    /// <summary>
    /// SigninConfigDCache
    /// </summary>
    public class SigninConfigDCache : RedisHashExpireClient<Sa_signin_configEO>
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
        /// SigninConfigDCache
        /// </summary>
        public SigninConfigDCache()
        {
            RedisKey = GetProjectGroupRedisKey("Activity");
        }
        /// <summary>
        /// GetField
        /// </summary>
        /// <param name="operatorId"></param>
        /// <param name="currencyId"></param>
        /// <returns></returns>
        public static string GetField(string operatorId, string currencyId)
            => $"{operatorId}|{currencyId}";

        protected override async Task<CacheValue<CacheItem<Sa_signin_configEO>>> LoadValueWhenRedisNotExistsAsync(string field)
        {
            var ret = new CacheValue<CacheItem<Sa_signin_configEO>>();

            var keys = field.Split('|');
            var operatorId = keys[0];
            var currencyId = keys[1];

            var value = await new Sa_signin_configMO().GetSingleAsync($"OperatorID = @OperatorID and CurrencyId = @CurrencyId", operatorId, currencyId);

            ret.HasValue = value != null;
            ret.Value = new CacheItem<Sa_signin_configEO>(value, TimeSpan.FromMinutes(EXPIRE_MINUTES));

            return ret;
        }
    }
}
