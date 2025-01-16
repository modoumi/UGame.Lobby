using UGame.Lobby.Repository.ing;
using Org.BouncyCastle.Asn1.Mozilla;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using AiUo.AspNet;

namespace UGame.Lobby.Service.Services.Activity.SigninNew
{
    /// <summary>
    /// 签到列表ipo
    /// </summary>
    public class SigninNewListIpo : LobbyBaseIpo
    {
        /// <summary>
        /// 签到过程中用到的数据
        /// </summary>
        [JsonIgnore]
        public SigninNewProcessData ProcessData { get; set; }
    }

    /// <summary>
    /// 签到列表dto
    /// </summary>
    public class SigninNewListDto
    {
        /// <summary>
        /// 用户当天是否允许签到
        /// </summary>
        [DataMember(Order = 1)]
        public bool IsSignin { get; set; } = false;
        /// <summary>
        /// 用户当天可补签次数
        /// </summary>
        [DataMember(Order = 2)]
        public bool IsMissSignin { get; set; } = false;
        /// <summary>
        /// 漏签需要完成的充值
        /// </summary>
        public decimal MissSigninPayAmount { get; set; }

        /// <summary>
        /// 签到需要完成的充值金额
        /// </summary>
        public decimal SigninPayAmount { get; set; }
        /// <summary>
        /// 当前周期签到次数
        /// </summary>
        public int SigninTimes { get; set; } = 0;
        /// <summary>
        /// 当前周期上一次签到日期
        /// </summary>
        public string PreSigninDate { get; set; } = null;
        /// <summary>
        /// 【测试字段】服务器时间
        /// </summary>
        [JsonIgnore]
        public string ServerTime { get; set; }
        /// <summary>
        /// 【测试字段】UTC时间
        /// </summary>
        [JsonIgnore]
        public string UtcTime { get; set; }
        /// <summary>
        /// 【测试字段】运营商当地时间
        /// </summary>
        [JsonIgnore]
        public string LocalTime { get; set; }
        /// <summary>
        /// 【测试字段】本次签到周期起始日期
        /// </summary>
        [JsonIgnore]
        public string SigninCycleStartDate { get; set; }
        /// <summary>
        /// 【测试字段】本次签到周期截止日期
        /// </summary>
        [JsonIgnore]
        public string SigninCycleEndDate { get; set; }
        /// <summary>
        /// 签到列表
        /// </summary>
        public List<UserSignDetails> Items { get; set; } = new List<UserSignDetails>();
    }

    public class UserSignDetails
    {
        /// <summary>
        /// 用户编码
        /// </summary>
        public string UserId { get; set; }
        /// <summary>
        /// 是否选中
        /// </summary>
        public bool IsSelected { get; set; }
        /// <summary>
        /// 当前日期
        /// </summary>
        public string DayId { get; set; } = null;
        /// <summary>
        /// 当前周期标识
        /// </summary>
        public int DateNumber { get; set; }
        /// <summary>
        /// 当前日期返奖金额（已签到则为实际奖励金额，未签到、漏签为最大奖励金额）
        /// </summary>
        public decimal Reward { get; set; }

        public DateTime? RecDate { get; set; } = null;

        /// <summary>
        /// SigninStatus
        /// </summary>
        public int Status { get; set; }

        [JsonIgnore]
        public string StatusDesc
        {
            get
            {
                if (this.Status == 1)
                    return "已签到";
                if (this.Status == 2)
                    return "允许签到";
                if (this.Status == 3)
                    return "漏签";
                if (this.Status == 4)
                    return "不允许签到";
                return "状态异常是bug";
            }
        }
    }

    /// <summary>
    /// 签到ipo
    /// </summary>
    public class SigninNewIpo : LobbyBaseIpo
    {
        public string AppId { get; set; }

        /// <summary>
        /// 日期编号
        /// </summary>
        [RangeEx(1, 366, "", "DateNumber must be a correct integer between 1 and 366.")]
        public int DateNumber { get; set; } = 1;

        /// <summary>
        /// 签到过程中用到的数据
        /// </summary>
        [JsonIgnore]
        public SigninNewProcessData ProcessData { get; set; }
    }

    /// <summary>
    /// 签到dto
    /// </summary>
    public class SigninNewDto
    {
        public bool Status { get; set; } = false;

        public decimal RewardAmount { get; set; }

        public string StatusDesc { get; set; }
        [JsonIgnore]
        public string ServerTime { get; set; }
        [JsonIgnore]
        public string UtcTime { get; set; }
        [JsonIgnore]
        public string LocalTime { get; set; }
        [JsonIgnore]
        public string SigninCycleStartDate { get; set; }
        [JsonIgnore]
        public string SigninCycleEndDate { get; set; }
    }

    public class SigninNewProcessData
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
        /// <summary>
        /// 签到周期
        /// </summary>
        public int SigninCycle { get; set; }
        /// <summary>
        /// 签到周期起始日期
        /// </summary>
        public DateTime SigninCycleStartDate { get; set; }
        /// <summary>
        /// 签到周期截止日期
        /// </summary>
        public DateTime SigninCycleEndDate { get; set; }
        /// <summary>
        /// 用户最后一次签到明细（可能为null）
        /// </summary>
        public Sa_signin100012_detailEO UserLastDetailEo { get; set; }
        /// <summary>
        /// 用户最近一个签到周期明细
        /// </summary>
        public List<Sa_signin100012_detailEO> UserLastDetailEoList { get; set; }
        /// <summary>
        /// 签到配置
        /// </summary>
        public Sa_signin100012_configPO SigninConfigEo { get; set; }
        /// <summary>
        /// 签到配置List
        /// </summary>
        public List<Sa_signin100012_oddsPO> SigninOddsEoList { get; set; }
        /// <summary>
        /// 用户当天充值总金额
        /// </summary>
        public long UserDaySumPayAmount { get; set; }
        /// <summary>
        /// 用户当天是否允许签到
        /// </summary>
        public bool IsSignin { get; set; } = false;
        /// <summary>
        /// 用户当天是否允许补签
        /// </summary>
        public bool IsMissSignin { get; set; } = false;
        /// <summary>
        /// 用户当天可补签次数
        /// </summary>
        public long MissSigninTotalCount { get; set; } = 0;
    }


    /// <summary>
    /// 签到状态
    /// </summary>
    public enum SigninStatus
    {
        /// <summary>
        /// 预留状态
        /// </summary>
        None = 0,
        /// <summary>
        /// 已签到
        /// </summary>
        Signined = 1,
        /// <summary>
        /// 允许签到
        /// </summary>
        Allow = 2,
        /// <summary>
        /// 漏签
        /// </summary>
        MissSignin = 3,
        /// <summary>
        /// 不允许签到
        /// </summary>
        NoAllow = 4
    }


}
