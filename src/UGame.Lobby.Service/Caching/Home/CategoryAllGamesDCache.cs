using UGame.Lobby.Repository.ing;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Caching;
using AiUo.Data.SqlSugar;
using AiUo.Extensions.AutoMapper;
using AiUo.Extensions.StackExchangeRedis;
using UGame.Lobby.Service.Services.Home;

namespace UGame.Lobby.Service.Caching.Home
{
    public class CategoryAllGamesDCache : RedisStringClient<List<AppDetailDto>>
    {
        private const int EXPIRE_DAY = 1;

        private string OperatorId { get; set; }

        private string LangId { get; set; }

        private int CategoryId { get; set; }

        public CategoryAllGamesDCache(string operatorId, string langId, int categoryId)
        {
            this.OperatorId = operatorId;
            this.LangId = langId;
            this.CategoryId = categoryId;
            RedisKey = GetProjectRedisKey($"{this.OperatorId}|{this.LangId}|{this.CategoryId}");
        }

        protected override async Task<CacheValue<List<AppDetailDto>>> LoadValueWhenRedisNotExistsAsync()
        {
            var ret = new CacheValue<List<AppDetailDto>>();

            var items = await DbUtil.GetRepository<V_l_category_detailPO>().AsQueryable()
                .Where(d => d.ParentId == this.CategoryId && d.LangID.Equals(this.LangId) && d.OperatorID.Equals(this.OperatorId))
                .OrderBy(d => d.AppOrderNum)
                .ToListAsync();

            if (items == null || !items.Any())
            {
                items = await DbUtil.GetRepository<V_l_category_detailPO>().AsQueryable()
                    .Where(d => d.ParentId == this.CategoryId && string.IsNullOrWhiteSpace(d.LangID) && d.OperatorID.Equals(this.OperatorId))
                    .OrderBy(d => d.AppOrderNum)
                    .ToListAsync();
            }

            ret.Value = new List<AppDetailDto>();

            foreach (var item in items)
            {
                ret.Value.Add(item.Map<AppDetailDto>());
            }

            ret.HasValue = ret.Value != null && ret.Value.Any();

            return ret;
        }

        /// <summary>
        /// GetAsync
        /// </summary>
        /// <returns></returns>
        public async Task<CacheValue<List<AppDetailDto>>> GetAsync()
        {
            return await GetOrLoadAsync(false, TimeSpan.FromMinutes(EXPIRE_DAY));
        }

    }

}
