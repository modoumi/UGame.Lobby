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
    /// Invite100011DCache
    /// </summary>
    public class InvitePayConfigDCache : RedisStringClient<List<Sa_invitepay100011_configEO>>
    {
        private const int EXPIRE_MINUTE = 10;

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
        public InvitePayConfigDCache(string operatorId, string currencyId)
        {
            this.OperatorId = operatorId;
            this.CurrencyId = currencyId;
            RedisKey = GetProjectGroupRedisKey("Activity", $"{this.OperatorId}|{this.CurrencyId}");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        protected override async Task<CacheValue<List<Sa_invitepay100011_configEO>>> LoadValueWhenRedisNotExistsAsync()
        {
            var ret = new CacheValue<List<Sa_invitepay100011_configEO>>();

            ret.Value = await new Sa_invitepay100011_configMO().GetSortAsync("OperatorId = @OperatorId and CurrencyId = @CurrencyId","PayAmountStart", this.OperatorId, this.CurrencyId);

            ret.HasValue = ret.Value != null && ret.Value.Any();

            return ret;
        }

        /// <summary>
        /// GetAsync
        /// </summary>
        /// <returns></returns>
        public async Task<CacheValue<List<Sa_invitepay100011_configEO>>> GetAsync()
        {
            return await GetOrLoadAsync(false, TimeSpan.FromDays(EXPIRE_MINUTE));
        }

        /// <summary>
        /// SetAsync
        /// </summary>
        /// <returns></returns>
        public async Task SetAsync()
        {
            await GetOrLoadAsync(true, TimeSpan.FromDays(EXPIRE_MINUTE));
        }

    }
}
