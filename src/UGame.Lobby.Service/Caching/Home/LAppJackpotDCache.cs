
using Google.Protobuf.WellKnownTypes;
using UGame.Lobby.Repository.ing;
using System.Diagnostics;
using AiUo.Caching;
using AiUo.Extensions.StackExchangeRedis;
using Xxyy.DAL;

namespace UGame.Lobby.Service.Caching.Home
{
    public class LAppJackpotDCache : RedisStringClient<L_app_jackpotEO>
    {
        private const int EXPIRE_MINUTES = 60;

        private string AppId { get; set; }

        private string CountryId { get; set; }

        private string OperatorId { get; set; }

        private string CurrencyId { get; set; }

        public LAppJackpotDCache(string appId, string countryId, string operatorId, string currencyId)
        {
            this.AppId = appId;
            this.CountryId = countryId;
            this.OperatorId = operatorId;
            this.CurrencyId = currencyId;
            RedisKey = GetProjectRedisKey($"{this.AppId}|{this.CountryId}|{this.OperatorId}|{this.CurrencyId}");
        }

        protected override async Task<CacheValue<L_app_jackpotEO>> LoadValueWhenRedisNotExistsAsync()
        {
            var ret = new CacheValue<L_app_jackpotEO>();

            ret.Value = await new L_app_jackpotMO().GetSingleAsync($"AppId = @AppId and CountryID = @CountryID and OperatorID = @OperatorID and CurrencyID = @CurrencyID", this.AppId, this.CountryId, this.OperatorId, this.CurrencyId);
            ret.HasValue = ret.Value != null;

            return ret;
        }

        /// <summary>
        /// GetAsync
        /// </summary>
        /// <returns></returns>
        public async Task<CacheValue<L_app_jackpotEO>> GetAsync()
        {
            return await GetOrLoadAsync(false, TimeSpan.FromMinutes(EXPIRE_MINUTES));
        }

        /// <summary>
        /// SetAsync
        /// </summary>
        /// <returns></returns>
        public async Task SetAsync()
        {
            await GetOrLoadAsync(true, TimeSpan.FromMinutes(EXPIRE_MINUTES));
        }


    }

}
