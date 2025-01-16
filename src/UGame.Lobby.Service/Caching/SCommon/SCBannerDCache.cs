using Google.Protobuf.WellKnownTypes;
using UGame.Lobby.Repository.ing;
using Microsoft.AspNetCore.Http.Features;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Caching;
using AiUo.Data;
using AiUo.Extensions.AutoMapper;
using AiUo.Extensions.StackExchangeRedis;
using UGame.Lobby.Service.Services.SCommon;
using Xxyy.DAL;

namespace UGame.Lobby.Service.Caching.SCommon
{

    public class SCBannerDCache : RedisStringClient<List<SCBannerDto>>
    {
        private const int EXPIRE_MINUTES = 60;

        /// <summary>
        /// banner类型
        /// 1-游客2-注册用户3-...
        /// </summary>
        private int BannerType { get; set; }
        /// <summary>
        /// 应用编码
        /// </summary>
        private string AppId { get; set; }
        /// <summary>
        /// 运营商编码
        /// </summary>
        private string OperatorId { get; set; }
        /// <summary>
        /// 语言编码
        /// </summary>
        private string LangId { get; set; }
        /// <summary>
        /// 位置
        /// </summary>
        public int Position { get; set; }


        public SCBannerDCache(int bannerType, string appId, string operatorId, string langId, int position)
        {
            this.BannerType = bannerType;
            this.AppId = appId;
            this.OperatorId = operatorId;
            this.LangId = langId;
            this.Position = position;

            RedisKey = GetProjectRedisKey($"{this.OperatorId}|{this.AppId}|{this.BannerType}|{this.LangId}|{this.Position}");
        }

        protected override async Task<CacheValue<List<SCBannerDto>>> LoadValueWhenRedisNotExistsAsync()
        {
            var mo = new Sc_bannerMO();

            var where = "BannerType = @BannerType and AppID = @AppID and Position = @Position and Status = 1 and OperatorID = @OperatorID and LangID = @LangID";

            var sort = "CONCAT(OperatorID,'|',LangID) desc, OrderNum";

            var list = await mo.GetSortAsync(where, sort, this.BannerType, this.AppId, this.Position, this.OperatorId, this.LangId);

            var ret = new CacheValue<List<SCBannerDto>>();
            ret.Value = list.Map<List<SCBannerDto>>();
            ret.HasValue = ret.Value != null && ret.Value.Any();

            return ret;
        }

        /// <summary>
        /// GetAsync
        /// </summary>
        /// <returns></returns>
        public async Task<CacheValue<List<SCBannerDto>>> GetAsync()
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
