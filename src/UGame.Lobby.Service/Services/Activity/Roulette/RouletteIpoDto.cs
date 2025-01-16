using UGame.Lobby.Service.Common;
using UGame.Lobby.Repository.ing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using AiUo;
using AiUo.AspNet;
using AiUo.Extensions.AutoMapper;
using Xxyy.Common;

namespace UGame.Lobby.Service.Services.Activity.Roulette
{


    public class RouletteIpo : LobbyBaseIpo
    {
        /// <summary>
        /// 应用编码
        /// </summary>
        [RequiredEx("", "AppId cannot be empty.")]
        public string AppId { get; set; }
    }


    public class RouletteDto
    {
        /// <summary>
        /// 是否为freespin
        /// </summary>
        public bool IsFreespin { get; set; } = false;

        /// <summary>
        /// 是否中奖
        /// </summary>
        public bool IsWin { get; set; } = false;

        /// <summary>
        /// 是否弹框充值提示
        /// </summary>
        public bool IsPayTip { get; set; } = false;

        /// <summary>
        /// 奖金
        /// </summary>
        public decimal WinAmount { get; set; } = 0;

        /// <summary>
        /// 用户明细
        /// </summary>
        public RouletteUserDataDto User { get; set; } = new RouletteUserDataDto();

        /// <summary>
        /// 奖励明细
        /// </summary>
        public RouletteOdds Roulette { get; set; } = new RouletteOdds();

        /// <summary>
        /// 推荐游戏
        /// </summary>
        public List<RouletteGamesDto> RecommendGames = new List<RouletteGamesDto>();
    }

    public class RouletteUserDataDto
    { 
        /// <summary>
        /// 用户编码
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// 用户余额
        /// </summary>
        public decimal Balance { get; set; }

        /// <summary>
        /// 当前用户剩余freespin次数
        /// </summary>
        public int Freespin { get; set; }

        /// <summary>
        /// 用户类型
        /// </summary>
        public int UserType { get; set; }
    }

    public class RouletteOdds : IMapFrom<RouletteOddsBaseDto>
    { 
        /// <summary>
        /// 抽奖类型
        /// </summary>
        [JsonIgnore]
        public int RaffleType { get; set; }

        /// <summary>
        /// 奖励等级
        /// </summary>
        public int Level { get; set; }

        /// <summary>
        /// 奖励类型1-无奖励2-真金3-二级抽奖A4-二级抽奖B
        /// </summary>
        public int RewardType { get; set; }

        /// <summary>
        /// 上一级奖励类型
        /// </summary>
        public int PreRewardType { get; set; }

        /// <summary>
        /// 位置
        /// </summary>
        public int Position { get; set; }

        /// <summary>
        /// 倍率
        /// </summary>
        public float Multiple { get; set; }

        /// <summary>
        /// 排序字段
        /// </summary>
        public int OrderNum { get; set; }

        /// <summary>
        /// 二级奖励
        /// </summary>
        public RouletteOdds Item { get; set; } = null;

        public void MapFrom(RouletteOddsBaseDto source)
        {
            
        }
    }


    public class RouletteDataDto
    { 
        
    }


    public class RouletteGamesIpo : LobbyBaseIpo { }

    public class RouletteGamesDto : IMapFrom<L_appEO>
    {
        /// <summary>
        /// 应用编码
        /// </summary>
        public string AppId { get; set; }
        /// <summary>
        /// 应用图片
        /// </summary>
        public string Icon { get; set; }
        /// <summary>
        /// 应用标识
        /// 0、默认
        /// 1、Hot
        /// 2、New
        /// </summary>
        public int Flag { get; set; }
        /// <summary>
        /// 应用名称
        /// </summary>
        public string AppName { get; set; }
        /// <summary>
        /// 当前用户是否收藏此应用
        /// </summary>
        public bool IsFavorite { get; set; }
        /// <summary>
        /// 当前应用Jackpot奖池
        /// 如果应用无Jackpot奖池则为空或null
        /// </summary>
        public string Jackpot { get; set; }

        public void MapFrom(L_appEO source)
        {
            this.Icon = source.RouletteIcon;
        }
    }

    public class RouletteOddsBaseIpo : LobbyBaseIpo { }

    public class RouletteOddsBaseDto 
    {
        [JsonIgnore]
        public string OperatorId { get; set; }

        [JsonIgnore]
        public string CountryId { get; set; }

        [JsonIgnore]
        public string CurrencyId { get; set; }

        [JsonIgnore]
        public int RaffleType { get; set; }

        [JsonIgnore]
        public int UserType { get; set; }

        public int Level { get; set; }

        public int RewardType { get; set; }

        public int PreRewardType { get; set; }
        
        public int RewardTypeDesc { get; set; }

        public int Position { get; set; }

        public float Multiple { get; set; }

        [JsonIgnore]
        public int Odds { get; set; }

        public int OrderNum { get; set; }

        public List<RouletteOddsBaseDto> Items { get; set; }
    }

    public class RouletteMarqueeIpo : LobbyBaseIpo
    {
        [RangeEx(1, 100, "", "PageSize must be a correct integer between 1 and 100.")]
        public int PageSize { get; set; }
    }

    /// <summary>
    /// 活动中奖播报
    /// </summary>
    public class RouletteMarqueeDto : IMapFrom<Sa_roulette_detailEO>
    {
        /// <summary>
        /// 货币编码
        /// </summary>
        public string CurrencyID { get; set; }

        /// <summary>
        /// 用户手机号
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 奖金
        /// </summary>
        public decimal Bonus { get; set; }

        public void MapFrom(Sa_roulette_detailEO source)
        {
            this.Mobile = source.Mobile.HideFixedLength(source.Mobile.Length, 3, 3, '*');
            this.Bonus = source.Bonus.AToM(source.CurrencyID);
        }
    }


}
