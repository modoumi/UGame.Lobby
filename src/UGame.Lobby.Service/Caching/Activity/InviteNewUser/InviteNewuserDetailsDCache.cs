using UGame.Lobby.Service.Services.Profile;
using UGame.Lobby.Repository.ing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Caching;
using AiUo.Configuration;
using AiUo.Extensions.AutoMapper;
using AiUo.Extensions.StackExchangeRedis;
using Xxyy.Common;
using Xxyy.DAL;

namespace UGame.Lobby.Service.Caching.Activity.InviteNewUser
{
    /// <summary>
    /// InviteNewuserDetailsDCache
    /// </summary>
    public class InviteNewuserDetailsDCache : RedisStringClient<List<Sa_invite100011_detailEO>>
    {
        private const int EXPIRE_MINUTES = 10;

        private string UserId { get; set; }

        private int RewardType { get; set; }

        /// <summary>
        /// InviteNewuserDetailsDCache
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="rewardType"></param>
        public InviteNewuserDetailsDCache(string userId, int rewardType)
        {
            this.UserId = userId;
            this.RewardType = rewardType;
            RedisKey = GetProjectGroupRedisKey("Activity", $"{this.UserId}|{this.RewardType}");
        }

        /// <summary>
        /// LoadValueWhenRedisNotExistsAsync
        /// </summary>
        /// <returns></returns>
        protected override async Task<CacheValue<List<Sa_invite100011_detailEO>>> LoadValueWhenRedisNotExistsAsync()
        {
            var ret = new CacheValue<List<Sa_invite100011_detailEO>>();

            var searchTime = DateTime.UtcNow.AddDays(-90).ToString("yyyy-MM-dd 00:00:00");

            ret.Value = await new Sa_invite100011_detailMO().GetSortAsync("PUserID = @PUserID and RewardType = @RewardType and RecDate > @RecDate", " RecDate desc ", this.UserId, this.RewardType, searchTime);

            ret.HasValue = ret.Value != null && ret.Value.Any();

            return ret;
        }

        /// <summary>
        /// GetAsync
        /// </summary>
        /// <returns></returns>
        public async Task<List<Sa_invite100011_detailEO>> GetAsync()
        {
            var ret = new List<Sa_invite100011_detailEO>();

            var cacheData = await GetOrLoadAsync(ConfigUtil.Environment.IsDebug ? true : false, TimeSpan.FromMinutes(EXPIRE_MINUTES));

            if (cacheData.HasValue)
                ret = cacheData.Value;

            return ret;
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
