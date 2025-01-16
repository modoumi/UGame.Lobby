using EasyNetQ.Events;
using UGame.Lobby.Repository.ing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using AiUo.AspNet;
using AiUo.Extensions.AutoMapper;
using UGame.Lobby.Service.Services.Profile;
using Xxyy.Common;

namespace UGame.Lobby.Service.Services.Activity.WeeklyCard
{
    public class WeeklyCardLoadIpo : LobbyBaseIpo
    {
        [JsonIgnore]
        public ProcessData ProcessData { get; set; }
    }

    public class WeeklyCardLoadDto
    {
        /// <summary>
        /// 用户是否购买了周卡
        /// </summary>
        public bool IsBuyWeeklyCard { get; set; } = false;

        /// <summary>
        /// 周卡类型
        /// </summary>
        public WeeklyCardTypeEnum WeeklyCardType { get; set; } = WeeklyCardTypeEnum.none;

        /// <summary>
        /// 周卡倒计时
        /// </summary>
        public double CountDown { get; set; } = 0;

        /// <summary>
        /// 【测试字段】服务器时间
        /// </summary>
        public string ServerTime { get; set; }
        /// <summary>
        /// 【测试字段】UTC时间
        /// </summary>
        public string UtcTime { get; set; }
        /// <summary>
        /// 【测试字段】运营商当地时间
        /// </summary>
        public string LocalTime { get; set; }

        public Dictionary<int, WeeklyCardLoadData> Data { get; set; } = new Dictionary<int, WeeklyCardLoadData>();
    }

    public class WeeklyCardLoadData
    {
        public WeeklyCardTypeEnum WeeklyCardType { get; set; }

        public bool IsSelected { get; set; } = false;
        /// <summary>
        /// 购买周卡需要的金额
        /// </summary>
        public decimal PayAmount { get; set; }
        /// <summary>
        /// 购买周卡后总返奖金
        /// </summary>
        public decimal SumBonus { get; set; }
        /// <summary>
        /// 签到周期
        /// </summary>
        public int Cycle { get; set; }

        /// <summary>
        /// 签到周期起始日期
        /// </summary>
        public DateTime CycleStartDate { get; set; }
        /// <summary>
        /// 签到周期截止日期
        /// </summary>
        public DateTime CycleEndDate { get; set; }

        public List<WeeklyCardLoadItem> Items { get; set; } = new List<WeeklyCardLoadItem>();
    }

    public class WeeklyCardLoadItem 
    { 
        public decimal Bonus { get; set; }

        public bool IsSelected { get; set; }

        /// <summary>
        /// 当前周期标识
        /// </summary>
        public int DateNumber { get; set; }

        public string CurrDate { get; set; }

        public ReceiveStatusEnum Status { get; set; } = ReceiveStatusEnum.NoAllow;

        public string StatusDesc
        {
            get {
                return this.Status.ToString();
            }
        }
    }

    public class ProcessData
    {
        /// <summary>
        /// 运营商编码
        /// </summary>
        public string OperatorId { get; set; }
        /// <summary>
        /// 货币编码
        /// </summary>
        public string CurrencyId { get; set; }
        /// <summary>
        /// 当前utc时间
        /// </summary>
        public DateTime UtcTime { get; set; }
        /// <summary>
        /// 当前日期
        /// </summary>
        public DateTime CurrentDate { get; set; }

        public Dictionary<int, WeeklyCardLoadData> Data { get; set; } = new Dictionary<int, WeeklyCardLoadData>();

        public Dictionary<int, Sa_weeklycard_configPO> ConfigEoDic { get; set; } = new Dictionary<int, Sa_weeklycard_configPO>();

        public Dictionary<int, List<Sa_weeklycard_detail_configPO>> DetailConfigEoListDic = new Dictionary<int, List<Sa_weeklycard_detail_configPO>>();

        public List<Sa_weeklycard_configPO> ConfigEoList { get; set; } = new List<Sa_weeklycard_configPO>();

        public Sa_weeklycard_userEO WeeklyCardUserEo { get; set; }

        /// <summary>
        /// 用户最近一个签到周期明细
        /// </summary>
        public List<Sa_weeklycard_detailEO> UserLastDetailEoList { get; set; } = new List<Sa_weeklycard_detailEO>();
        /// <summary>
        /// 签到配置List
        /// </summary>
        public List<Sa_weeklycard_detail_configPO> DetailConfigEoList { get; set; }
        /// <summary>
        /// 用户是否购买了周卡
        /// </summary>
        public bool IsBuyWeeklyCard { get; set; } = false;

        public WeeklyCardTypeEnum WeeklyCardType { get; set; } = WeeklyCardTypeEnum.none;

        /// <summary>
        /// 周卡倒计时
        /// </summary>
        public long CountDown { get; set; } = 0;

    }

    public enum ReceiveStatusEnum
    {
        /// <summary>
        /// 不允许
        /// </summary>
        NoAllow = 0,
        /// <summary>
        /// 允许
        /// </summary>
        Allow = 1,
        /// <summary>
        /// 已领取
        /// </summary>
        Received = 2
    }

    public enum WeeklyCardTypeEnum
    { 
        /// <summary>
        /// 默认值
        /// </summary>
        none = 0,
        /// <summary>
        /// 售价100档周卡
        /// </summary>
        WeeklyCardA = 1,

        /// <summary>
        /// 售价50档周卡
        /// </summary>
        WeeklyCardB = 2
    }


    public class WeeklyCardExecuteIpo : LobbyBaseIpo
    { 
        public string AppId { get; set; }

        ///// <summary>
        ///// 日期编号
        ///// </summary>
        //[RangeEx(1, 366, "", "DateNumber must be a correct integer between 1 and 366.")]
        //public int DateNumber { get; set; } = 1;

        [JsonIgnore]
        public ProcessData ProcessData { get; set; }
    }

    public class WeeklyCardExecuteDto
    {
        public bool Status { get; set; } = false;

        public decimal bonus { get; set; }


        /// <summary>
        /// 【测试字段】服务器时间
        /// </summary>
        public string ServerTime { get; set; }
        /// <summary>
        /// 【测试字段】UTC时间
        /// </summary>
        public string UtcTime { get; set; }
        /// <summary>
        /// 【测试字段】运营商当地时间
        /// </summary>
        public string LocalTime { get; set; }
        /// <summary>
        /// 【测试字段】本次周卡领取周期起始日期
        /// </summary>
        public string CycleStartDate { get; set; }
        /// <summary>
        /// 【测试字段】本次周卡领取周期截止日期
        /// </summary>
        public string CycleEndDate { get; set; }
    }

    public class WeeklyCardBraPayIpo : BraDepositIpo,IMapFrom<BraDepositDto>
    {
        public WeeklyCardTypeEnum WeeklyCardType { get; set; } = WeeklyCardTypeEnum.none;

        public void MapFrom(BraDepositDto source)
        {
            
        }
    }


    public class WeeklyCardBraPayDto : BraDepositDto, IMapFrom<BraDepositDto>
    {
        public void MapFrom(BraDepositDto source)
        {
            
        }
    }


    public class WeeklyCardShow
    {
        /// <summary>
        /// 是否显示周卡相关数据
        /// </summary>
        public bool IsAllowShow { get; set; } = false;

        /// <summary>
        /// 用户是否购买了周卡
        /// </summary>
        public bool IsBuyWeeklyCard { get; set; } = false;

        /// <summary>
        /// 周卡倒计时
        /// </summary>
        public long CountDown { get; set; }
    }

}
