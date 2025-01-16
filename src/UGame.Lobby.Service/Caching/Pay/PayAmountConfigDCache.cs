using Google.Protobuf.WellKnownTypes;
using UGame.Lobby.Repository.ing;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Caching;
using AiUo.Data.SqlSugar;
using AiUo.Extensions.StackExchangeRedis;
using Xxyy.DAL;

namespace UGame.Lobby.Service.Caching.Pay
{

    /// <summary>
    /// 充值金额配置缓存
    /// </summary>
    public class PayAmountConfigDCache : RedisHashExpireClient<List<L_pay_amount_configPO>>
    {
        private const int EXPIRE_DAY = 1;

        public PayAmountConfigDCache()
        {
            RedisKey = GetProjectGroupRedisKey("PayConfig");
        }

        public static string GetField(string operatorId, string currencyId, int userType) => $"{operatorId}|{currencyId}|{userType}";

        protected override async Task<CacheValue<CacheItem<List<L_pay_amount_configPO>>>> LoadValueWhenRedisNotExistsAsync(string field)
        {
            var keys = field.Split('|');
            var operatorId = keys[0];
            var currencyId = keys[1];
            var userType = Convert.ToInt32(keys[2]) == 1 ? true : false;

            var value = await DbUtil.GetRepository<L_pay_amount_configPO>().AsQueryable()
                .Where(d => d.OperatorID.Equals(operatorId) && d.CurrencyID.Equals(currencyId) && d.UserType == userType)
                .ToListAsync();

            if (value == null || !value.Any())
                throw new Exception($"PayAmountConfig.The operatorId({operatorId}) and CurrencyId({currencyId}) and userType({userType}) data do not exist.");

            var ret = new CacheValue<CacheItem<List<L_pay_amount_configPO>>>();
            ret.HasValue = value != null && value.Any();
            ret.Value = new CacheItem<List<L_pay_amount_configPO>>(value, TimeSpan.FromDays(EXPIRE_DAY));

            return ret;

        }

        /// <summary>
        /// GetAsync
        /// </summary>
        /// <param name="operatorId">运营商编码</param>
        /// <param name="currencyId">货币编码</param>
        /// <param name="userType">0、未充值1、已充值</param>
        /// <returns></returns>
        public async Task<List<L_pay_amount_configPO>> GetAsync(string operatorId, string currencyId, int userType)
        {
            var ret = new List<L_pay_amount_configPO>();

            var field = GetField(operatorId, currencyId, userType);
            var payAmountConfigDCache = await GetOrLoadAsync(field);

            if (payAmountConfigDCache.HasValue)
                ret = payAmountConfigDCache.Value;

            return ret;
        }

    }


    //public class PayAmountConfigDCache : RedisHashExpireClient<List<L_pay_amount_configEO>>
    //{
    //    private const int EXPIRE_DAY = 1;

    //    public PayAmountConfigDCache()
    //    {
    //        RedisKey = GetProjectGroupRedisKey("PayConfig");
    //    }

    //    public static string GetField(string operatorId, string currencyId, int userType) => $"{operatorId}|{currencyId}|{userType}";

    //    protected override async Task<CacheValue<CacheItem<List<L_pay_amount_configEO>>>> LoadValueWhenRedisNotExistsAsync(string field)
    //    {
    //        var keys = field.Split('|');
    //        var operatorId = keys[0];
    //        var currencyId = keys[1];
    //        var userType = keys[2];

    //        var where = $"OperatorID = @OperatorID and CurrencyId = @CurrencyId and UserType = @UserType";
    //        var sort = "OrderNum";

    //        var value = await new L_pay_amount_configMO().GetSortAsync(where, sort, operatorId, currencyId, userType);

    //        if (value == null || !value.Any())
    //            throw new Exception($"PayAmountConfig.The operatorId({operatorId}) and CurrencyId({currencyId}) and userType({userType}) data do not exist.");

    //        var ret = new CacheValue<CacheItem<List<L_pay_amount_configEO>>>();
    //        ret.HasValue = value != null && value.Any();
    //        ret.Value = new CacheItem<List<L_pay_amount_configEO>>(value, TimeSpan.FromDays(EXPIRE_DAY));

    //        return ret;

    //    }

    //    /// <summary>
    //    /// GetAsync
    //    /// </summary>
    //    /// <param name="operatorId">运营商编码</param>
    //    /// <param name="currencyId">货币编码</param>
    //    /// <param name="userType">0、未充值1、已充值</param>
    //    /// <returns></returns>
    //    public async Task<List<L_pay_amount_configEO>> GetAsync(string operatorId, string currencyId, int userType)
    //    {
    //        var ret = new List<L_pay_amount_configEO>();

    //        var field = GetField(operatorId, currencyId, userType);
    //        var payAmountConfigDCache = await GetOrLoadAsync(field);

    //        if (payAmountConfigDCache.HasValue)
    //            ret = payAmountConfigDCache.Value;

    //        return ret;
    //    }

    //}

}
