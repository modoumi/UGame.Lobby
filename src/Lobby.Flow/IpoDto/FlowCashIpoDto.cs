using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Extensions.AutoMapper;
using Xxyy.Banks.Client.BLL;
using Xxyy.Banks.Client.BLL.Tejeepay;
using Xxyy.Common;

namespace Lobby.Flow.IpoDto
{
    public class FlowCashIpo:FlowBaseIpo
    {  
        public string Channel { get; set; }
        public int Channels { get; set; }
        public decimal Amount { get; set; }
        public string UserBankId { get; set; }
    }

    public class FlowCashDto : FlowBaseDto
    {
        /// <summary>
        /// 充值金额
        /// </summary>
        public decimal Amount { get; set; }
        /// <summary>
        /// 账户余额
        /// </summary>
        public long Balance { get; set; }

        public string OrderId { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 扩展书
        /// </summary>
        public object Meta { get; set; }

        /// <summary>
        /// 是否进入提现审核
        /// </summary>
        public bool IsAudit { get; set; } = false;

    }
}
