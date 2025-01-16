using UGame.Lobby.Repository.ing;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Caching;
using AiUo.Extensions.StackExchangeRedis;

namespace UGame.Lobby.Service.Caching.Activity.Regpay
{
    public class RegpayConfigDCahce : RedisHashExpireClient<Sa_regpay_configEO>
    {
        private const int EXPIRE_MINUTES = 5;

        public RegpayConfigDCahce()
        {
            RedisKey = GetProjectGroupRedisKey("Activity");
        }

        public static string GetField(string operatorId, string currencyId)
            => $"{operatorId}|{currencyId}";

        protected override async Task<CacheValue<CacheItem<Sa_regpay_configEO>>> LoadValueWhenRedisNotExistsAsync(string field)
        {
            Sa_regpay_configEO value = null;

            var keys = field.Split('|');
            var operatorId = keys[0];
            var currencyId = keys[1];

            value = await new Sa_regpay_configMO().GetSingleAsync($"OperatorID = @OperatorID and CurrencyId = @CurrencyId", operatorId, currencyId);

            if (value == null)
                throw new Exception($"The operatorId({operatorId}) and CurrencyId({currencyId}) data do not exist.");

            var ret = new CacheValue<CacheItem<Sa_regpay_configEO>>();
            ret.HasValue = value != null;
            ret.Value = new CacheItem<Sa_regpay_configEO>(value, TimeSpan.FromMinutes(EXPIRE_MINUTES));

            return ret;
        }

    }
}
