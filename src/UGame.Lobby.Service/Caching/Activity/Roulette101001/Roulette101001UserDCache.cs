using UGame.Lobby.Repository.ing;
using AiUo.Caching;
using AiUo.Extensions.StackExchangeRedis;

namespace UGame.Lobby.Service.Caching.Activity.Roulette101001
{

    /// <summary>
    /// Roulette101001UserDCache
    /// </summary>
    public class Roulette101001UserDCache : RedisStringClient<Sa_roulette101001_userEO>
    {

        private const int EXPIRE_DAY = 1;

        /// <summary>
        /// 运营商编码
        /// </summary>
        public string OperatorId { get; set; }

        /// <summary>
        /// 用户编码
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// RouletteUserDCache
        /// </summary>
        /// <param name="operatorId"></param>
        /// <param name="userId"></param>
        public Roulette101001UserDCache(string operatorId, string userId)
        {
            this.OperatorId = operatorId;
            this.UserId = userId;
            RedisKey = GetProjectGroupRedisKey("Activity", $"{operatorId}:{userId}");
            Options.SlidingExpiration = TimeSpan.FromDays(EXPIRE_DAY);
        }

        /// <summary>
        /// LoadValueWhenRedisNotExistsAsync
        /// </summary>
        /// <returns></returns>
        protected override async Task<CacheValue<Sa_roulette101001_userEO>> LoadValueWhenRedisNotExistsAsync()
        {
            var ret = new CacheValue<Sa_roulette101001_userEO>();

            ret.Value = await new Sa_roulette101001_userMO().GetSingleAsync("UserId = @UserId", this.UserId);
            ret.HasValue = ret.Value != null;

            return ret;
        }


        /// <summary>
        /// GetAsync
        /// </summary>
        /// <returns></returns>
        public async Task<Sa_roulette101001_userEO> GetAsync()
        {
            var cache = await GetOrLoadAsync(false);

            if (!cache.HasValue)
                return null;

            return cache.Value;
        }

        /// <summary>
        /// SetAsync
        /// </summary>
        /// <returns></returns>
        public async Task SetAsync()
        {
            await GetOrLoadAsync(true);
        }
    }
}
