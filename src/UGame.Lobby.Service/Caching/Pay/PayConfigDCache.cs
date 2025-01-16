using UGame.Lobby.Repository.ing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Caching;
using AiUo.Data.SqlSugar;
using AiUo.Extensions.StackExchangeRedis;

namespace UGame.Lobby.Service.Caching.Pay
{
    /// <summary>
    /// 当前OperatorId下的所有数据
    /// </summary>
    public class PayConfigDCache : RedisHashExpireClient<List<L_pay_configPO>>
    {
        private const int EXPIRE_DAY = 1;

        public PayConfigDCache()
        {
            RedisKey = GetProjectGroupRedisKey("PayConfig");
        }

        public static string GetField(string operatorId, string currencyId) => $"{operatorId}|{currencyId}";


        protected override async Task<CacheValue<CacheItem<List<L_pay_configPO>>>> LoadValueWhenRedisNotExistsAsync(string field)
        {
            var keys = field.Split('|');
            var operatorId = keys[0];
            var currencyId = keys[1];

            var value = await DbUtil.GetRepository<L_pay_configPO>().AsQueryable()
                .Where(d => d.OperatorID.Equals(operatorId) && d.CurrencyID.Equals(currencyId))
                .ToListAsync();

            if (value == null)
                throw new Exception($"PayConfig.The operatorId({operatorId}) and CurrencyId({currencyId}) data do not exist.");

            var ret = new CacheValue<CacheItem<List<L_pay_configPO>>>();
            ret.HasValue = value != null && value.Any();
            ret.Value = new CacheItem<List<L_pay_configPO>>(value, TimeSpan.FromDays(EXPIRE_DAY));

            return ret;
        }

        /// <summary>
        /// GetAsync
        /// </summary>
        /// <param name="operatorId"></param>
        /// <param name="currencyId"></param>
        /// <returns></returns>
        public async Task<List<L_pay_configPO>> GetAsync(string operatorId, string currencyId)
        {
            var ret = new List<L_pay_configPO>();

            var field = GetField(operatorId, currencyId);
            var payConfigDCache = await GetOrLoadAsync(field);

            if (payConfigDCache.HasValue)
                ret = payConfigDCache.Value;

            return ret;
        }

    }
    //public class PayConfigDCache : RedisHashExpireClient<List<L_pay_configEO>>
    //{
    //    private const int EXPIRE_DAY = 1;

    //    public PayConfigDCache()
    //    {
    //        RedisKey = GetProjectGroupRedisKey("PayConfig");
    //    }

    //    public static string GetField(string operatorId, string currencyId) => $"{operatorId}|{currencyId}";


    //    protected override async Task<CacheValue<CacheItem<List<L_pay_configEO>>>> LoadValueWhenRedisNotExistsAsync(string field)
    //    {
    //        var keys = field.Split('|');
    //        var operatorId = keys[0];
    //        var currencyId = keys[1];

    //        var where = "OperatorID = @OperatorID and CurrencyId = @CurrencyId";

    //        var value = await new L_pay_configMO().GetAsync(where, operatorId, currencyId);
    //        if (value == null)
    //            throw new Exception($"PayConfig.The operatorId({operatorId}) and CurrencyId({currencyId}) data do not exist.");

    //        var ret = new CacheValue<CacheItem<List<L_pay_configEO>>>();
    //        ret.HasValue = value != null && value.Any();
    //        ret.Value = new CacheItem<List<L_pay_configEO>>(value, TimeSpan.FromDays(EXPIRE_DAY));

    //        return ret;
    //    }

    //    /// <summary>
    //    /// GetAsync
    //    /// </summary>
    //    /// <param name="operatorId"></param>
    //    /// <param name="currencyId"></param>
    //    /// <returns></returns>
    //    public async Task<List<L_pay_configEO>> GetAsync(string operatorId, string currencyId)
    //    {
    //        var ret = new List<L_pay_configEO>();

    //        var field = GetField(operatorId, currencyId);
    //        var payConfigDCache = await GetOrLoadAsync(field);

    //        if(payConfigDCache.HasValue)
    //            ret = payConfigDCache.Value;

    //        return ret;
    //    }

    //}

    public class BankErrorDCache : RedisHashClient<long>
    {
        public BankErrorDCache()
        {
            RedisKey = GetGlobalRedisKey();
        }
    }

}
