using UGame.Lobby.Service.Services.Activity.Signin;
using UGame.Lobby.Repository.ing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Caching;
using AiUo.Extensions.StackExchangeRedis;
using Xxyy.Common;
using Xxyy.DAL;

namespace UGame.Lobby.Service.Caching.Activity.Signin
{
    /// <summary>
    /// SigninBannerDCache
    /// </summary>
    public class SigninBannerDCache :  RedisStringClient<List<Sa_signin_bannerEO>>
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
        /// SigninBannerDCache
        /// </summary>
        /// <param name="operatorId"></param>
        /// <param name="currencyId"></param>
        public SigninBannerDCache(string operatorId, string currencyId)
        {
            this.OperatorId = operatorId;
            this.CurrencyId = currencyId;
            RedisKey = GetProjectGroupRedisKey("Activity", $"{operatorId}|{currencyId}");
        }

        /// <summary>
        /// LoadValueWhenRedisNotExistsAsync
        /// </summary>
        /// <returns></returns>
        protected override async Task<CacheValue<List<Sa_signin_bannerEO>>> LoadValueWhenRedisNotExistsAsync()
        {
            var ret = new CacheValue<List<Sa_signin_bannerEO>>();

            ret.Value = await new Sa_signin_bannerMO().GetAsync($"OperatorID = @OperatorID and CurrencyId = @CurrencyId and Status=1", OperatorId, CurrencyId);
            ret.HasValue = ret.Value != null && ret.Value.Any();

            return ret;
        }

        /// <summary>
        /// GetCache
        /// </summary>
        /// <returns></returns>
        public async Task<List<Sa_signin_bannerEO>> GetCache()
        {
            var ret = new List<Sa_signin_bannerEO>();
            var cache = await GetOrLoadAsync(false, TimeSpan.FromMinutes(EXPIRE_MINUTES));

            if (cache.HasValue)
                ret = cache.Value;

            return ret;
        }

        /// <summary>
        /// SetCache
        /// </summary>
        /// <returns></returns>
        public async Task SetCache()
        {
            await GetOrLoadAsync(true, TimeSpan.FromMinutes(EXPIRE_MINUTES));
        }
    }
}
