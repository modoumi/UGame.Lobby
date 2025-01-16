using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Extensions.StackExchangeRedis;

namespace UGame.Lobby.Service.Caching.Activity
{
    public class UserIpActivityDCache : RedisHashClient<long>
    {
        public int ActivityId { get; set; }
        public string OperatorId { get; set; }
        public UserIpActivityDCache(string operatorId, int activityId)
        {
            OperatorId = operatorId;
            ActivityId = activityId;
            RedisKey = GetProjectRedisKey($"{operatorId}:{activityId}");
        }

        public async Task<long> GetNum(string userIp)
        {
            return await GetOrDefaultAsync(userIp, 0);
        }

        public async Task<long> AddNum(string userIp)
        {
            return await IncerementAsync(userIp);
        }
    }
}
