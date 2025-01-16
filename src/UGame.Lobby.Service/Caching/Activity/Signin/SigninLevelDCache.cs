using UGame.Lobby.Repository.ing;
using StackExchange.Redis;
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
    /// SigninLevelDCache
    /// </summary>
    public class SigninLevelDCache : RedisStringClient<List<Sa_signin_levelEO>>
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
        /// SigninLevelDCache
        /// </summary>
        /// <param name="operatorId"></param>
        /// <param name="currencyId"></param>
        public SigninLevelDCache(string operatorId, string currencyId)
        {
            this.OperatorId = operatorId;
            this.CurrencyId = currencyId;
            RedisKey = GetProjectGroupRedisKey("Activity", $"{operatorId}|{currencyId}");
        }

        /// <summary>
        /// LoadValueWhenRedisNotExistsAsync
        /// </summary>
        /// <returns></returns>
        protected override async Task<CacheValue<List<Sa_signin_levelEO>>> LoadValueWhenRedisNotExistsAsync()
        {
            var ret = new CacheValue<List<Sa_signin_levelEO>>();

            ret.Value = await new Sa_signin_levelMO().GetAsync($"OperatorID = @OperatorID and CurrencyId = @CurrencyId", OperatorId, CurrencyId);

            ret.HasValue = ret.Value != null && ret.Value.Any();

            return ret;
        }
    }
}

 
