using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UGame.Lobby.Service.Commands.Activity.InvitationNewUser100011
{
    public class InvitationNewUser100011Command : IRequest<bool>
    {
        public string UserId { get; set; }

        public string AppId { get; set; }

        public int UserKind { get; set; }

        public DateTime PayTime { get; set; }

        public int PayType { get; set; }

        public long PayAmount { get; set; }

        public decimal UserFee { get; set; }

        public decimal OwnFee { get; set; }

        public string OperatorId { get; set; }

        public string CountryId { get; set; }

        public string CurrencyId { get; set; }

        public object Meta { get; set; }

        //
        // 摘要:
        //     充值参与领取bonus状态，1参与，2不参与
        public int ReceiveBonus { get; set; }

        //
        // 摘要:
        //     充值的订单号(sb_bank_order表）
        public string OrderID { get; set; }

        //
        // 摘要:
        //     是否首次充值
        public bool IsFirst { get; set; }
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
