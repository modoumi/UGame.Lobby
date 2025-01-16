using UGame.Lobby.Repository.ing;
using AiUo.Caching;
using AiUo.Extensions.StackExchangeRedis;

namespace UGame.Lobby.Service.Caching.Activity.Rebate
{
    public class RebateRealTimeConfigDCache : RedisStringClient<List<Sa_rebate_realtime_configEO>>
    {
        private const int EXPIRE_MINUTES = 30;
        public string OperatorId { get; set; }
        public string CurrencyId { get; set; }
        public int ActivityId { get; set; }

        public RebateRealTimeConfigDCache(string operatorId, string currencyId, int activityId)
        {
            OperatorId = operatorId;
            CurrencyId = currencyId;
            ActivityId = activityId;
            RedisKey = GetProjectGroupRedisKey("Rebate", $"{OperatorId}|{CurrencyId}|{activityId}");
        }
        public string GetField
        {
            get
            {
                return $"{OperatorId}|{CurrencyId}|{ActivityId}";
            }
        }
        protected override async Task<CacheValue<List<Sa_rebate_realtime_configEO>>> LoadValueWhenRedisNotExistsAsync()
        {
            var where = "(OperatorID=@OperatorID or OperatorID is null) and (CurrencyId=@CurrencyId or CurrencyId is null) and (ActivityId=@ActivityId or ActivityId is null)";
            var sort = "OperatorID asc,CurrencyId asc, level asc";
            var list = await new Sa_rebate_realtime_configMO().GetSortAsync(where, sort, OperatorId, CurrencyId, ActivityId);
            var ret = new CacheValue<List<Sa_rebate_realtime_configEO>>();

            ret.HasValue = list != null && list.Any();
            ret.Value = list;
            base.Database.KeyExpire(RedisKey, TimeSpan.FromMinutes(EXPIRE_MINUTES));
            return ret;
        }

        /// <summary>
        /// GetAsync
        /// </summary>
        /// <returns></returns>
        public async Task<CacheValue<List<Sa_rebate_realtime_configEO>>> GetAsync()
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
