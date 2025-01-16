using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.AspNet;
using UGame.Lobby.Service.Common;

namespace UGame.Lobby.Service.Services.Activity.InviteNewUser
{

    #region Load

    public class InviteUser100013LoadIpo : LobbyBaseIpo
    {

    }

    public class InviteUser100013LoadDto
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
        /// 总共可领取奖金
        /// </summary>
        public decimal TotalBonus { get; set; }

        /// <summary>
        /// 已领取奖金
        /// </summary>
        public decimal TotalHaveReceived { get; set; }

        /// <summary>
        /// 可领取奖金
        /// </summary>
        public decimal TotalAllowReceive { get; set; }

        /// <summary>
        /// 已邀请人数
        /// </summary>
        public long TotalUser { get; set; }

        /// <summary>
        /// 已邀请有效人数
        /// </summary>
        public long TotalValidUser { get; set; }

        /// <summary>
        /// 奖励明细
        /// </summary>
        public List<InviteUser100013LoadItem> Items { get; set; } = new List<InviteUser100013LoadItem>();
    }

    public class InviteUser100013LoadItem
    {
        /// <summary>
        /// 奖励id，可能为null
        /// </summary>
        public string DetailId { get; set; }
        /// <summary>
        /// 奖金
        /// </summary>
        public decimal Bonus { get; set; }
        /// <summary>
        /// 需要邀请的有效用户数量
        /// </summary>
        public int NeedUsers { get; set; }
        /// <summary>
        /// 已经邀请的有效用户数量
        /// </summary>
        public int AlreadyUsers { get; set; }

        /// <summary>
        /// 领取状态
        /// </summary>
        public ReceiveStatus100013 ReceiveStatus { get; set; } = ReceiveStatus100013.NotAllow;

        public string ReceiveStatusDesc
        {
            get
            {
                return this.ReceiveStatus.ToString();
            }
        }

    }

    public enum ReceiveStatus100013
    {
        /// <summary>
        /// 不允许领取
        /// </summary>
        NotAllow = 0,

        /// <summary>
        /// 已领取
        /// </summary>
        Received = 1,

        /// <summary>
        /// 可领取
        /// </summary>
        Receive = 2
    }

    #endregion

    public class Execute100013Ipo : LobbyBaseIpo
    {
        /// <summary>
        /// 奖励Id
        /// </summary>
        [RequiredEx(LobbyCodes.RS_PARAMETER_ERROR, "DetailId cannot be empty")]
        public string DetailId { get; set; }
    }

    public class Execute100013Dto
    {
        /// <summary>
        /// 是否领取成功
        /// </summary>
        public bool IsSuccess { get; set; }

        /// <summary>
        /// 奖金
        /// </summary>
        public decimal Bonus { get; set; }
    }

}
