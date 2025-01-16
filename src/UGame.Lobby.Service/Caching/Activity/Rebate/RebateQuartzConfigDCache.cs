using UGame.Lobby.Repository.ing;
using AiUo.Caching;
using AiUo.Extensions.StackExchangeRedis;

namespace UGame.Lobby.Service.Caching.Activity.Rebate
{
    public class RebateQuartzConfigDCache : RedisStringClient<List<Sa_rebate_quartz_configEO>>
    {
        private const int EXPIRE_MINUTES = 30;
        public string OperatorId { get; set; }
        public string CurrencyId { get; set; }
        public int ActivityId { get; set; }

        public RebateQuartzConfigDCache(string operatorId, string currencyId, int activityId)
        {
            OperatorId = operatorId;
            CurrencyId = currencyId;
            ActivityId = activityId;
            RedisKey = GetProjectGroupRedisKey("Rebate", $"{OperatorId}|{CurrencyId}|{ActivityId}");
        }
        public string GetField
        {
            get
            {
                return $"{OperatorId}|{CurrencyId}|{ActivityId}";
            }
        }

        protected override async Task<CacheValue<List<Sa_rebate_quartz_configEO>>> LoadValueWhenRedisNotExistsAsync()
        {
            var where = "(OperatorID=@OperatorID or OperatorID is null) and (CurrencyId=@CurrencyId or CurrencyId is null) and (ActivityId=@ActivityId or ActivityId is null)";
            var sort = "OperatorID asc, CurrencyId asc";
            var list = await new Sa_rebate_quartz_configMO().GetSortAsync(where, sort, OperatorId, CurrencyId, ActivityId);// AppId,
            var ret = new CacheValue<List<Sa_rebate_quartz_configEO>>();

            ret.HasValue = list != null && list.Any();
            ret.Value = list;
            base.Database.KeyExpire(RedisKey, TimeSpan.FromMinutes(EXPIRE_MINUTES));
            return ret;
        }

        /// <summary>
        /// GetAsync
        /// </summary>
        /// <returns></returns>
        public async Task<CacheValue<List<Sa_rebate_quartz_configEO>>> GetAsync()
        {
            return await GetOrLoadAsync(false, TimeSpan.FromMinutes(EXPIRE_MINUTES));
        }
    }
}
