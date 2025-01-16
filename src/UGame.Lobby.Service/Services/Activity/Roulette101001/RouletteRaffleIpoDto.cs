using UGame.Lobby.Repository.ing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using AiUo.Extensions.AutoMapper;
using UGame.Lobby.Service.Caching.Activity.Roulette101001;
using Xxyy.Common;
using Xxyy.Common.Caching;

namespace UGame.Lobby.Service.Services.Activity.Roulette101001
{
    public class RouletteRaffleIpo : LobbyBaseIpo
    {

        

    }

    public class RouletteRaffleDto
    {
        public bool IsWin { get; set; }

        public decimal WinAmount { get; set; }
        /// <summary>
        /// 是否提示充值
        /// </summary>
        public bool IsTipPay { get; set; } = false;
        public RouletteOddsResult Reward { get; set; }
    }

    public class RouletteOddsResult : IMapFrom<Sa_roulette101001_oddsEO>
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


    public class Roulette101001Context
    {
        public string UserId { get; set; }
        public string OperatorId { get; set; }

        public string CurrencyId { get; set; }

        public Roulette101001UserDCache Roulette101001UserDCache { get; set; }

        public Sa_roulette101001_userEO RouletteUserEo { get; set; }

        public Sa_roulette101001_configEO RouletteConfigEo { get; set; }

        public GlobalUserDCache GlobalUserDCache { get; set; }

        public List<Sa_roulette101001_oddsEO> RouletteOddsEoList { get; set; }

        public Sa_roulette101001_oddsEO RouletteOddsEo { get; set; }

        public bool IsWin { get; set; }

        public long WinAmount { get; set; }

        public bool IsTipPay { get; set; } = false;

        /// <summary>
        /// 用户当天充值总金额
        /// </summary>
        public long UserDaySumPayAmount { get; set; }
    }

}
