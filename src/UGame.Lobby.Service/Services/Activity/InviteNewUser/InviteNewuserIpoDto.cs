using CliWrap.EventStream;
using UGame.Lobby.Service.Caching;
using UGame.Lobby.Repository.ing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using AiUo.AspNet;
using AiUo.Extensions.AutoMapper;
using Xxyy.Common;

namespace UGame.Lobby.Service.Services.Activity.InviteNewUser
{
    /// <summary>
    /// 查询获得奖励明细ipo
    /// </summary>
    public class InviteDetailsIpo : LobbyBaseIpo
    {
        /// <summary>
        /// 1-首存奖励
        /// 2-邀请好友数量月度奖励
        /// </summary>
        public int Type { get; set; } = 1;

        /// <summary>
        /// 当前页码
        /// 默认1
        /// </summary>
        [RangeEx(1, int.MaxValue, "", "PageIndex must be a positive integer greater than 0.")]
        public int PageIndex { get; set; } = 1;

        /// <summary>
        /// 页大小
        /// 默认10
        /// </summary>
        [RangeEx(1, 50, "", "PageSize must be a correct integer between 1 and 50.")]
        public int PageSize { get; set; } = 20;
    }

    /// <summary>
    /// 查询获得奖励明细dto
    /// </summary>
    public class InviteDetailsDto : IMapFrom<Sa_invite100011_detailEO>
    { 
        /// <summary>
        /// 好友账号
        /// </summary>
        public string UserAccount { get; set; }
        /// <summary>
        /// 注册日期
        /// </summary>
        public DateTime RegistDate { get; set; }
        /// <summary>
        /// 好友首存金额
        /// </summary>
        public decimal FirstPay { get; set; }
        /// <summary>
        /// 奖励金额
        /// </summary>
        public decimal Bonus { get; set; }
        /// <summary>
        /// 月份
        /// </summary>
        public string Month { get; set; }
        /// <summary>
        /// 有效人数
        /// </summary>
        public int ValidUserCount { get; set; }
        /// <summary>
        /// 发奖日期
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// 用户编码
        /// </summary>
        [JsonIgnore]
        public string UserId { get; set; }
        /// <summary>
        /// 货币编码
        /// </summary>
        [JsonIgnore]
        public string CurrencyId { get; set; }

        public void MapFrom(Sa_invite100011_detailEO source)
        {
            this.Bonus = source.Bonus.AToM(source.CurrencyID);
            if (source.MonthDate.HasValue)
                this.Month = source.MonthDate.Value.ToString("yyyy-MM");

            this.FirstPay = source.FirstPayAmount.Value.AToM(source.CurrencyID);

            this.Date = new DateTime(source.RecDate.Ticks, DateTimeKind.Utc);
            if(source.RegistDate.HasValue)
                this.RegistDate = new DateTime(source.RegistDate.Value.Ticks, DateTimeKind.Utc);
        }
    }

    /// <summary>
    /// 好友邀请分享活动详情ipo
    /// </summary>
    public class InviteConfigIpo : LobbyBaseIpo
    { 
        
    }

    /// <summary>
    /// 好友邀请分享活动详情dto
    /// </summary>
    public class InviteConfigDto
    {
        /// <summary>
        /// 首存金额奖励
        /// </summary>
        public List<InvitePayConfig> PayBonus { get; set; } = new List<InvitePayConfig>();
        /// <summary>
        /// 首存金额流水倍率
        /// </summary>
        public float PayFlowMultip { get; set; } = 1;
        /// <summary>
        /// 邀请好友数量奖励
        /// </summary>
        public List<InviteNumConfig> NumBonus { get; set; } = new List<InviteNumConfig>();
        /// <summary>
        /// 邀请好友数量奖励流水倍率
        /// </summary>
        public float NumFlowMultip { get; set; } = 1;
        /// <summary>
        /// 充值最低要求
        /// </summary>
        public decimal NumPayAmount { get; set; } = 500;
        /// <summary>
        /// 100013，有效人数判断条件之一，下注要求
        /// </summary>
        public decimal BetLimit { get; set; } = 0;
        /// <summary>
        /// 100013，奖励bonus需要的流水倍数
        /// </summary>
        public float FlowMultip { get; set; } = 1;
    }

    /// <summary>
    /// 首存金额奖励
    /// </summary>
    public class InvitePayConfig : IMapFrom<Sa_invitepay100011_configEO>
    {
        /// <summary>
        /// 首充金额
        /// </summary>
        public decimal FirstPay { get; set; }

        /// <summary>
        /// 奖励金额
        /// </summary>
        public decimal Bonus { get; set; }

        public void MapFrom(Sa_invitepay100011_configEO source)
        {
            this.FirstPay = source.PayAmountStart.AToM(source.CurrencyID);
            this.Bonus = source.Bonus.AToM(source.CurrencyID);
        }
    }

    /// <summary>
    /// 邀请好友数量奖励
    /// </summary>
    public class InviteNumConfig : IMapFrom<Sa_invitenum100011_configEO>, IMapFrom<Sa_invitenum100013_configEO>
    {
        /// <summary>
        /// 邀请数量
        /// </summary>
        public int Num { get; set; }

        /// <summary>
        /// 奖励金额
        /// </summary>
        public decimal Bonus { get; set; }

        public void MapFrom(Sa_invitenum100011_configEO source)
        {
            this.Num = source.UserNumStart;
            this.Bonus = source.Bonus.AToM(source.CurrencyID);
        }

        public void MapFrom(Sa_invitenum100013_configEO source)
        {
            this.Num = source.ValidQuantity;
            this.Bonus = source.Bonus.AToM(source.CurrencyID);
        }
    }

}
