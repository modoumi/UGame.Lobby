using UGame.Lobby.Service.Caching.Activity.Regpay;
using UGame.Lobby.Service.Common;
using UGame.Lobby.Repository.ing;
using Polly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using AiUo.AspNet;
using AiUo.Extensions.AutoMapper;
using UGame.Lobby.Service.Caching;
using UGame.Lobby.Service.Caching.Activity;
using UGame.Lobby.Service.Services.Vip;
using Xxyy.Common;
using Xxyy.Common.Caching;
using Xxyy.Common.Services;
using Xxyy.DAL;

namespace UGame.Lobby.Service.Services.Init
{
    public class LoadIpo : LobbyBaseIpo, IMapTo<UserVipInfoIpo>
    {
        /// <summary>
        /// 应用编码
        /// </summary>
        [RequiredEx("", "AppId cannot be empty.")]
        public string AppId { get; set; }

        /// <summary>
        /// s_user
        /// </summary>
        [JsonIgnore]
        public S_userEO SUserEo { get; set; }

        /// <summary>
        /// 请求ip
        /// </summary>
        [JsonIgnore]
        public string UserIp { get; set; }

        /// <summary>
        /// 当前运营商全部有效活动
        /// </summary>
        [JsonIgnore]
        public List<ActivityEventEntity> AllValidActivity { get; set; }

        /// <summary>
        /// 查询用户vip信息
        /// </summary>
        /// <param name="destination"></param>
        public void MapTo(UserVipInfoIpo destination)
        {
            
        }
    }


    public class LoadDto : IMapFrom<LoadContext>
    {
        /// <summary>
        /// 是否提示用户信息弹框
        /// </summary>
        public bool IsTipPersonalForm { get; set; }

        ////是否弹出注册、首充活动
        //public bool IsTipRegister { get; set; } = false;

        ///// <summary>
        ///// 是否绑定手机号
        ///// </summary>
        //public bool IsBindMobile { get; set; } = false;

        ///// <summary>
        ///// 绑定手机号活动相关字段
        ///// </summary>
        //public BindMobile BindMobile { get; set; } = new BindMobile();

        ///// <summary>
        ///// 活动100007
        ///// </summary>
        //public Register7 Register7 { get; set; } = new Register7();

        /// <summary>
        /// 用户ip
        /// </summary>
        public string UserIp 
        {
            get
            {
                return AspNetUtil.GetRemoteIpString();
            }
        }

        ///// <summary>
        ///// 用户余额信息
        ///// </summary>
        //public BalanceDto BalanceInfo { get; set; }

        ///// <summary>
        ///// 用户邮件相关
        ///// </summary>
        //public UserMessage UserMessageInfo { get; set; } = new UserMessage();

        ///// <summary>
        ///// 用户vip信息
        ///// </summary>
        //public UserVipInfoDto UserVipInfo { get; set; } = new UserVipInfoDto();

        /// <summary>
        /// 首页浮窗
        /// </summary>
        public List<IndexFloatingWindow> IndexFloatingWindows { get; set; } = new List<IndexFloatingWindow>();

        ///// <summary>
        ///// 首页弹框
        ///// </summary>
        //public List<PopupBox> IndexPopupBox { get; set; } = new List<PopupBox>();

        /// <summary>
        /// operator config
        /// </summary>
        public Config Config { get; set; } = new Config();

        /// <summary>
        /// 周卡
        /// </summary>
        public WeeklyCardConfig WeeklyCard { get; set; }

        public void MapFrom(LoadContext source)
        {
            
        }
    }

    public class LoadContext
    {

        public LoadIpo Ipo { get; set; }

        public DateTime UtcNow { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// 请求ip
        /// </summary>
        public string UserIp { get; set; }

        public GlobalUserDCache GlobalUserDCache { get; set; }


        public UserKind UserKind { get; set; }

        public string NickName { get; set; }    

        public string Mobile { get; set; }

        public string Email { get; set; }

        public UserMode UserMode { get; set; }

        public GlobalUserDCacheEx GlobalUserDCacheEx { get; set; }

        /// <summary>
        /// 用户参加活动明细表
        /// </summary>
        public List<L_user_activityPO> UserActivityEoList { get; set; } = new List<L_user_activityPO>();

        /// <summary>
        /// 当前运营商配置的所有活动
        /// </summary>
        public List<L_activity_operatorPO> ActivityOperatorEoList { get; set; } = new List<L_activity_operatorPO>();

        /// <summary>
        /// 用户账户真金余额
        /// </summary>
        public string Balance { get; set; } = "0";

        /// <summary>
        /// 是否提示用户信息弹框
        /// </summary>
        public bool IsTipPersonalForm { get; set; }

        //是否弹出注册、首充活动
        public bool IsTipRegister { get; set; } = false;

        /// <summary>
        /// 是否绑定手机号
        /// </summary>
        public bool IsBindMobile { get; set; } = false;

        /// <summary>
        /// 绑定手机号活动相关字段
        /// </summary>
        public BindMobile BindMobile { get; set; } = new BindMobile();

        /// <summary>
        /// 活动100007
        /// </summary>
        public Register7 Register7 { get; set; } = new Register7();

        /// <summary>
        /// 用户邮件相关
        /// </summary>
        public UserMessage UserMessageInfo { get; set; } = new UserMessage();

        /// <summary>
        /// 用户vip信息
        /// </summary>
        public UserVipInfoDto UserVipInfo { get; set; } = new UserVipInfoDto();

        /// <summary>
        /// 首页浮窗
        /// </summary>
        public List<IndexFloatingWindow> IndexFloatingWindows { get; set; } = new List<IndexFloatingWindow>();

        /// <summary>
        /// 首页弹框
        /// </summary>
        public List<PopupBox> IndexPopupBox { get; set; } = new List<PopupBox>();

        /// <summary>
        /// operator config
        /// </summary>
        public Config Config { get; set; } = new Config();

        /// <summary>
        /// 周卡
        /// </summary>
        public WeeklyCardConfig WeeklyCard { get; set; } = new WeeklyCardConfig();
    }

    public class BindMobile
    {
        /// <summary>
        /// 是否有手机号
        /// </summary>
        public bool IsExistsMobile { get; set; } = false;
        /// <summary>
        /// 是否显示绑定手机号送bonus弹框
        /// </summary>
        public bool IsTipMobile { get; set; } = false;
        /// <summary>
        /// 发放bonus金额
        /// </summary>
        public decimal Bonus { get; set; } = 0;
    }

    /// <summary>
    /// 活动100007
    /// </summary>
    public class Register7
    {
        /// <summary>
        /// 是否显示register7送bonus弹框
        /// </summary>
        public bool IsTipRegister { get; set; } = false;

        /// <summary>
        /// 送bonus金额
        /// </summary>
        public decimal Bonus { get; set; } = 0;
    }

    /// <summary>
    /// 用户邮件相关
    /// </summary>
    public class UserMessage
    {
        /// <summary>
        /// 用户未读邮件数量
        /// </summary>
        public int UnReadMessageCount { get; set; } = 0;
    }

    /// <summary>
    /// 浮窗
    /// </summary>
    public class IndexFloatingWindow
    {
        public int Code { get; set; }
        /// <summary>
        /// 图片地址
        /// </summary>
        public string ImageUrl { get; set; }
        /// <summary>
        /// 链接
        /// </summary>
        public string LinkUrl { get; set; }
    }

    /// <summary>
    /// 首页弹框
    /// </summary>
    public class PopupBox
    { 
        public int Code { get; set; }
        /// <summary>
        /// 图片地址
        /// </summary>
        public string ImageUrl { get; set; }
        /// <summary>
        /// 链接地址
        /// </summary>
        public string LinkUrl { get; set; }
        /// <summary>
        /// 链接文字
        /// </summary>
        public string LinkContent { get; set; }
        /// <summary>
        /// 图片文字
        /// </summary>
        public string Content { get; set; }
    }

    /// <summary>
    /// operator config
    /// </summary>
    public class Config
    {
        public int Version { get; set; } = 0;
    }

    /// <summary>
    /// 周卡
    /// </summary>
    public class WeeklyCardConfig
    {
        /// <summary>
        /// 是否允许购买周卡
        /// </summary>
        public bool IsAllowBuy { get; set; } = false;

        /// <summary>
        /// 购买周卡倒计时
        /// </summary>
        public long CountDown { get; set; } = 0;
    }


}
