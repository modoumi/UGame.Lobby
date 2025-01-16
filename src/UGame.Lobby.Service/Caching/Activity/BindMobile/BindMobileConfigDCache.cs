using UGame.Lobby.Repository.ing;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Caching;
using AiUo.Extensions.StackExchangeRedis;

namespace UGame.Lobby.Service.Caching.Activity.BindMobile
{
    /// <summary>
    /// 绑定手机领取奖励配置
    /// </summary>
    public class BindMobileConfigDCache : RedisHashExpireClient<Sa_bind_mobile_configEO>
    {
        private const int EXPIRE_MINUTES = 5;

        /// <summary>
        /// BindMobileConfigDCache
        /// </summary>
        public BindMobileConfigDCache()
        {
            RedisKey = GetProjectGroupRedisKey("Activity");
        }

        /// <summary>
        /// GetField
        /// </summary>
        /// <param name="operatorId"></param>
        /// <param name="currencyId"></param>
        /// <returns></returns>
        public static string GetField(string operatorId, string currencyId) => $"{operatorId}|{currencyId}";

        /// <summary>
        /// LoadValueWhenRedisNotExistsAsync
        /// </summary>
        /// <param name="field"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        protected override async Task<CacheValue<CacheItem<Sa_bind_mobile_configEO>>> LoadValueWhenRedisNotExistsAsync(string field)
        {
            Sa_bind_mobile_configEO value = null;

            var keys = field.Split('|');
            var operatorId = keys[0];
            var currencyId = keys[1];

            value = await new Sa_bind_mobile_configMO().GetSingleAsync($"OperatorID = @OperatorID and CurrencyId = @CurrencyId", operatorId, currencyId);

            if (value == null)
                throw new Exception($"The operatorId({operatorId}) and CurrencyId({currencyId}) data do not exist.");

            var ret = new CacheValue<CacheItem<Sa_bind_mobile_configEO>>();
            ret.HasValue = value != null;
            ret.Value = new CacheItem<Sa_bind_mobile_configEO>(value, TimeSpan.FromMinutes(EXPIRE_MINUTES));

            return ret;
        }

    }

}
