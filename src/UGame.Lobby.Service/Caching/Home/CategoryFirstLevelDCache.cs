using UGame.Lobby.Repository.ing;
using AiUo.Caching;
using AiUo.Data.SqlSugar;
using AiUo.Extensions.StackExchangeRedis;

namespace UGame.Lobby.Service.Caching.Home
{
    /// <summary>
    /// 首页一级分类缓存
    /// </summary>
    public class CategoryFirstLevelDCache : RedisStringClient<List<L_categoryPO>>
    {
        private const int EXPIRE_MINUTES = 60;
        private string OperatorId { get; set; }
        private string LangId { get; set; }

        public CategoryFirstLevelDCache(string operatorId, string langId)
        {
            this.OperatorId = operatorId;
            this.LangId = langId;
            RedisKey = GetProjectRedisKey($"{this.OperatorId}|{this.LangId}");
        }

        protected override async Task<CacheValue<List<L_categoryPO>>> LoadValueWhenRedisNotExistsAsync()
        {
            var ret = new CacheValue<List<L_categoryPO>>
            {
                Value = await DbUtil.GetRepository<L_categoryPO>().AsQueryable()
                .Where(d => d.LevelNum == 1 && d.OperatorID.Equals(this.OperatorId) && d.LangID.Equals(this.LangId))
                .ToListAsync()
            };

            ret.HasValue = ret.Value != null && ret.Value.Any();

            return ret;
        }

        /// <summary>
        /// GetAsync
        /// </summary>
        /// <returns></returns>
        public async Task<CacheValue<List<L_categoryPO>>> GetAsync()
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
