using Google.Protobuf.WellKnownTypes;
using UGame.Lobby.Service.Services.Home;
using UGame.Lobby.Repository.ing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Caching;
using AiUo.Data.SqlSugar;
using AiUo.Extensions.AutoMapper;
using AiUo.Extensions.StackExchangeRedis;

namespace UGame.Lobby.Service.Caching.Home
{
    public class PromotionDCache : RedisStringClient<List<L_activity_langPO>>
    {
        private const int EXPIRE_MINUTES = 60;

        private string Keys { get; set; }

        public PromotionDCache(string keys)
        {
            this.Keys = keys;
            RedisKey = GetProjectRedisKey(this.Keys);
        }

        protected override async Task<CacheValue<List<L_activity_langPO>>> LoadValueWhenRedisNotExistsAsync()
        {
            //var ret = new CacheValue<List<L_activity_langEO>>();

            //var keys = this.Keys.Split('|');
            //var operatorId = keys[0];
            //var langId = keys[1];

            //ret.Value = await new L_activity_langMO().GetSortAsync($"OperatorId = @OperatorId and LangID = @LangID", "`Status` desc,OrderNum, EndDate desc", operatorId, langId);

            //ret.HasValue = ret.Value != null && ret.Value.Any();

            //return ret;

            var ret = new CacheValue<List<L_activity_langPO>>();

            var keys = this.Keys.Split('|');
            var operatorId = keys[0];
            var langId = keys[1];

            var sql = DbUtil.GetRepository<L_activity_langPO>().AsQueryable()
                .Where(d => d.OperatorID.Equals(operatorId) && d.LangID.Equals(langId))
                .OrderByDescending(d => d.Status)
                .OrderBy(d => d.OrderNum)
                .OrderByDescending(d => d.EndDate).ToSqlString();

            ret.Value = await DbUtil.GetRepository<L_activity_langPO>().AsQueryable()
                .Where(d => d.OperatorID.Equals(operatorId) && d.LangID.Equals(langId))
                .OrderByDescending(d => d.Status)
                .OrderBy(d => d.OrderNum)
                .OrderByDescending(d => d.EndDate)
                .ToListAsync();

            ret.HasValue = ret.Value != null && ret.Value.Any();

            return ret;
        }

        /// <summary>
        /// GetAsync
        /// </summary>
        /// <returns></returns>
        public async Task<CacheValue<List<L_activity_langPO>>> GetAsync()
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
