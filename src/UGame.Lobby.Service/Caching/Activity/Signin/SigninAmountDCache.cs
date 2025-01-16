using UGame.Lobby.Repository.ing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Caching;
using AiUo.Extensions.StackExchangeRedis;

namespace UGame.Lobby.Service.Caching.Activity.Signin
{
    public class SigninAmountDCache : RedisStringClient<Sa_signin_levelEO>
    {
        private const int EXPIRE_MINUTES = 23;
        public string OperatorId { get; set; }

        public string CurrencyId { get; set; }

        public int Days { get; set; }

        public SigninAmountDCache(string operatorId, string currencyId, int days)
        {
            this.OperatorId = operatorId;
            this.CurrencyId = currencyId;
            this.Days = days;
            RedisKey = GetProjectGroupRedisKey("Activity", $"{operatorId}|{currencyId}");
        }

        protected override async Task<CacheValue<Sa_signin_levelEO>> LoadValueWhenRedisNotExistsAsync()
        {
            var ret = new CacheValue<Sa_signin_levelEO>();

            var value = await new Sa_signin_levelMO().GetTopSortAsync($"OperatorID = @OperatorID and CurrencyId = @CurrencyId and Days=@Days", 1, "PetMoney asc", OperatorId, CurrencyId, Days);

            ret.Value = value.FirstOrDefault();
            ret.HasValue = ret.Value != null;

            return ret;
        }
    }
}
