using UGame.Lobby.Repository.ing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Caching;
using AiUo.Extensions.StackExchangeRedis;

namespace UGame.Lobby.Service.Caching.Activity.InviteNewUser
{
    public class InviteUser100013DetailsDCache : RedisStringClient<List<Sa_invite100013_detailEO>>
    {
        private const int EXPIRE_DAY = 1;

        private string UserId { get; set; }

        /// <summary>
        /// InviteUser100013DetailsDCache
        /// </summary>
        /// <param name="userId"></param>
        public InviteUser100013DetailsDCache(string userId)
        {
            this.UserId = userId;
            RedisKey = GetProjectGroupRedisKey("Activity", this.UserId);
        }

        protected override async Task<CacheValue<List<Sa_invite100013_detailEO>>> LoadValueWhenRedisNotExistsAsync()
        {
            var ret = new CacheValue<List<Sa_invite100013_detailEO>>();

            ret.Value = await new Sa_invite100013_detailMO().GetAsync("UserId = @UserId", this.UserId);
            ret.HasValue = ret.Value != null && ret.Value.Any();

            return ret;
        }

        /// <summary>
        /// GetAsync
        /// </summary>
        /// <returns></returns>
        public async Task<List<Sa_invite100013_detailEO>> GetAsync(bool enforce = false)
        {
            var cache = await GetOrLoadAsync(enforce, TimeSpan.FromDays(EXPIRE_DAY));

            if (cache.HasValue)
                return cache.Value;

            return new List<Sa_invite100013_detailEO>();
        }

    }
}
