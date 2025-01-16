using UGame.Lobby.Repository.ing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using AiUo.Extensions.AutoMapper;
using UGame.Lobby.Service.Caching;
using Xxyy.Common;
using Xxyy.Common.Caching;

namespace UGame.Lobby.Service.Services.Activity.Roulette101001
{
    public class Roulette101001LoadIpo : LobbyBaseIpo
    {
        [JsonIgnore]
        public GlobalUserDCacheEx GlobalUserDCacheEx { get; set; }

        [JsonIgnore]
        public GlobalUserDCache globalUserDCache { get; set; }
    }

    public class Roulette101001LoadDto
    {
        public RouletteConfig Config { get; set; }

        public RouletteUser User { get; set; }

        public List<RouletteItem> Items { get; set; } = new List<RouletteItem>();
    }

    public class RouletteConfig : IMapFrom<Sa_roulette101001_configEO>
    { 
        public string OperatorId { get; set; }

        public string CountryId { get; set; }

        public string CurrencyId { get; set; }

        public decimal PayCondition { get; set; }

        public int DayNumLimit { get; set; }

        public void MapFrom(Sa_roulette101001_configEO source)
        {
            this.PayCondition = source.PayCondition.AToM(source.CurrencyID);
            this.DayNumLimit = source.DaySendNumLimit;
        }
    }

    public class RouletteUser : IMapFrom<Sa_roulette101001_userEO>
    { 
        public string UserId { get; set; }

        public int SpinNum { get; set; }

        public void MapFrom(Sa_roulette101001_userEO source)
        {
            
        }
    }

    public class RouletteItem : IMapFrom<Sa_roulette101001_oddsEO>
    { 
        public int RewardType { get; set; }
        
        public int Position { get; set; }

        public decimal Bonus { get; set; }

        public void MapFrom(Sa_roulette101001_oddsEO source)
        {
            this.Bonus = source.Bonus.AToM(source.CurrencyID);
        }

        public string RewardTypeDesc 
        {
            get 
            {
                if (RewardType == 1)
                    return "无奖励";
                if (RewardType == 2)
                    return "bonus";
                if (RewardType == 3)
                    return "手机";
                if (RewardType == 4)
                    return "汽车";
                return "配置异常";
            }
        }
    }

    

}
