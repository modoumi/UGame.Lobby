using UGame.Lobby.Common.Enum;
using Org.BouncyCastle.Asn1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Xxyy.Common;

namespace UGame.Lobby.Service.Services.Profile
{
    /// <summary>
    /// 获取用户当前可参加的第一个活动时的请求体
    /// </summary>
    public class UserCurrentActivityIpo : LobbyBaseIpo 
    {
        /// <summary>
        /// 等同于sc_banner.position
        /// 1、首页推荐
        /// 2、首页头部
        /// 3、汉堡栏
        /// 4、个人中心
        /// 5、充值
        /// </summary>
        public int RecommendType { get; set; } = 1;

        /// <summary>
        /// 用户类型
        /// </summary>
        [JsonIgnore]
        public UserMode UserMode { get; set; }
    }


    /// <summary>
    /// 获取用户当前可参加的第一个活动的返回值
    /// </summary>
    public class UserCurrentActivityDto
    {
        public int activityCode { get; set; } = 0;


        public string activityUrl { get; set; } = string.Empty;

        /// <summary>
        /// banner图片
        /// </summary>
        public string ImgUrl { get; set; } = string.Empty;

        public int LinkType { get; set; }

        public string LinkParams { get; set; }

        /// <summary>
        /// 活动是否允许完成
        /// </summary>
        [JsonIgnore]
        public bool IsAllowEnd { get; set; }
        /// <summary>
        /// 活动页链接
        /// </summary>
        [JsonIgnore]
        public string LinkUrl { get; set; }
        /// <summary>
        /// 首页未登录链接
        /// </summary>
        [JsonIgnore]
        public string IndexNologinLinkUrl { get; set; }
        /// <summary>
        /// 首页登录后链接
        /// </summary>
        [JsonIgnore]
        public string IndexLoginLinkUrl { get; set; }
    }
}
