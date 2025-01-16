using UGame.Lobby.Repository.ing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Caching;
using AiUo.Data.SqlSugar;
using AiUo.Extensions.StackExchangeRedis;

namespace UGame.Lobby.Service.Caching.Activity.Register7
{

    public class Register7ConfigDCache : RedisHashExpireClient<Sa_register100007_configPO>
    {
        private const int EXPIRE_MINUTES = 5;

        public Register7ConfigDCache()
        {
            RedisKey = GetProjectGroupRedisKey("Activity");
        }

        public static string GetField(string operatorId, string currencyId) => $"{operatorId}|{currencyId}";

        protected override async Task<CacheValue<CacheItem<Sa_register100007_configPO>>> LoadValueWhenRedisNotExistsAsync(string field)
        {
            var keys = field.Split('|');
            var operatorId = keys[0];
            var currencyId = keys[1];

            var value = await DbUtil.GetRepository<Sa_register100007_configPO>()
                .AsQueryable()
                .Where(d => d.OperatorID.Equals(operatorId) && d.CurrencyID.Equals(currencyId)).FirstAsync();

            var ret = new CacheValue<CacheItem<Sa_register100007_configPO>>();
            ret.HasValue = value != null;
            ret.Value = new CacheItem<Sa_register100007_configPO>(value, TimeSpan.FromMinutes(EXPIRE_MINUTES));

            return ret;
        }

    }

}
