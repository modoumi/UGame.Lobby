using Google.Protobuf.WellKnownTypes;
using UGame.Lobby.Service.Services.SCommon;
using UGame.Lobby.Repository.ing;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Caching;
using AiUo.Extensions.StackExchangeRedis;
using AiUo.Logging;
using Xxyy.DAL;

namespace UGame.Lobby.Service.Caching.SCommon
{
    public class SCNotifyDCache : RedisStringClient<List<V_sc_notify_detailEO>>
    {
        private const int EXPIRE_MINUTES = 720;

        public string AppId { get; set; }

        public int ActionAt { get; set; }

        public int ShowAt { get; set; }

        public string OperatorId { get; set; }

        public string LangId { get; set; }

        public SCNotifyDCache(string appId, int actionAt, int showAt, string operatorId, string langId)
        {
            this.AppId = appId;
            this.ActionAt = actionAt;
            this.ShowAt = showAt;
            this.OperatorId = operatorId;
            this.LangId = langId;
            RedisKey = GetProjectGroupRedisKey("Notifys", $"{this.AppId}|{this.ActionAt}|{this.ShowAt}|{this.OperatorId}|{this.LangId}");
        }

        protected override async Task<CacheValue<List<V_sc_notify_detailEO>>> LoadValueWhenRedisNotExistsAsync()
        {
            var ret = new CacheValue<List<V_sc_notify_detailEO>>();


            var where = $"@TimeNow BETWEEN BeginDate AND EndDate and AppID = @AppID and ActionAt = @ActionAt and 0 < ShowAt & @ShowAt and OperatorID = @OperatorID and LangID = @LangID";

            var sort = "OrderNum";
            ret.Value = await new V_sc_notify_detailMO().GetSortAsync(where, sort, DateTime.UtcNow, this.AppId, this.ActionAt, this.ShowAt, this.OperatorId, this.LangId);

            ret.HasValue = ret.Value != null && ret.Value.Any();

            return ret;
        }

        /// <summary>
        /// GetAsync
        /// </summary>
        /// <returns></returns>
        public async Task<CacheValue<List<V_sc_notify_detailEO>>> GetAsync()
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
