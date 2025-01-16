using UGame.Lobby.Repository.ing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Caching;
using AiUo.Extensions.StackExchangeRedis;

namespace UGame.Lobby.Service.Caching.Activity
{
    /// <summary>
    /// 
    /// </summary>
    public class ActivityEventDCache : RedisStringClient<List<L_activity_event_operatorEO>>
    {
        private const int EXPIRE_MINUTES = 10;

        /// <summary>
        /// 运营商编码
        /// </summary>
        public string OperatorId { get; set; }

        /// <summary>
        /// 货币编码
        /// </summary>
        public string CurrencyId { get; set; }

        /// <summary>
        /// ActivityEventDCache
        /// </summary>
        /// <param name="operatorId"></param>
        /// <param name="currencyId"></param>
        public ActivityEventDCache(string operatorId, string currencyId)
        {
            this.OperatorId = operatorId;
            this.CurrencyId = currencyId;
            RedisKey = GetProjectGroupRedisKey("Activity", $"{this.OperatorId}|{this.CurrencyId}");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        protected override async Task<CacheValue<List<L_activity_event_operatorEO>>> LoadValueWhenRedisNotExistsAsync()
        {
            var ret = new CacheValue<List<L_activity_event_operatorEO>>();

            ret.Value = await new L_activity_event_operatorMO().GetSortAsync($"OperatorId = @OperatorId and CurrencyID = @CurrencyID and Status = 1", "ActivityEventId desc", this.OperatorId, this.CurrencyId);

            ret.HasValue = ret.Value != null && ret.Value.Any();

            return ret;
        }

        /// <summary>
        /// GetAsync
        /// </summary>
        /// <returns></returns>
        public async Task<CacheValue<List<L_activity_event_operatorEO>>> GetAsync()
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
