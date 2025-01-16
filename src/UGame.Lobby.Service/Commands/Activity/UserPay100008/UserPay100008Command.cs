using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UGame.Lobby.Service.Commands.Activity.UserPay10008
{
    public class UserPay100008Command : IRequest<bool>
    {
        /// <summary>
        /// 
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int UserKind { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime PayTime { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public int PayType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public long PayAmount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal UserFee { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal OwnFee { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string OperatorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CountryId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CurrencyId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public object Meta { get; set; }

        /// <summary>
        /// 充值参与领取bonus状态，0不参与，1参与
        /// </summary>
        public int ReceiveBonus { get; set; }

        /// <summary>
        /// 充值的订单号(sb_bank_order表）
        /// </summary>
        public string OrderID { get; set; }
        /// <summary>
        /// 是否发送弹框通知
        /// </summary>
        public bool IsSendNotify { get; set; }
        /// <summary>
        /// 是否发送站内邮箱通知
        /// </summary>
        public bool IsSendNotifyEmail { get; set; }
        /// <summary>
        /// 活动id集合
        /// </summary>
        public List<string> ActivityIds { get; set; }
    }
}
