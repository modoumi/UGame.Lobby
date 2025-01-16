using UGame.Lobby.Repository.ing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Xxyy.DAL;

namespace UGame.Lobby.Service.Services.Activity.BindMobile
{
    /// <summary>
    /// 绑定手机领取奖励ipo
    /// </summary>
    public class BindMobileIpo : LobbyBaseIpo
    {
        /// <summary>
        /// 应用编码 
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// 用户ip
        /// </summary>
        public string UserIp { get; set; }

        [JsonIgnore]
        public Sa_bind_mobile_configEO BindMobileConfigEo { get; set; }

        [JsonIgnore]
        public Sa_bind_mobile_userEO BindMobileUserEo { get; set; }

        [JsonIgnore]
        public S_userEO SUserEo { get; set; }

        [JsonIgnore]
        public Sc_notifyEO NotifyEo { get; set; }

        [JsonIgnore]
        public Sc_notify_userEO NotifyUserEo { get; set; }

        [JsonIgnore]
        public Sc_notify_detailEO NotifyDetailEo { get; set; }
    }

    /// <summary>
    /// 绑定手机领取奖励dto
    /// </summary>
    public class BindMobileDto
    { 
        /// <summary>
        /// 账户余额
        /// </summary>
        public decimal Balance { get; set; }

        /// <summary>
        /// 真金
        /// </summary>
        public decimal Cash { get; set; }

        /// <summary>
        /// Bonus
        /// </summary>
        public decimal Bonus { get; set; }
    }
}
