using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UGame.Lobby.Service.Services.Home.Sync
{
    /// <summary>
    /// 同步类型
    /// </summary>
    public enum SyncEnum
    {
        /// <summary>
        /// 账户余额
        /// </summary>
        balance = 1,

        /// <summary>
        /// 充值、提现订单号
        /// </summary>
        Order = 2,

        /// <summary>
        /// 活动
        /// </summary>
        Activity = 3,

        /// <summary>
        /// 破产保护
        /// </summary>
        Banky = 4
    }


    public class SyncIpo : LobbyBaseIpo
    {
        public List<SyncEnum> SyncTypes { get; set; }

        public string OrderId { get; set; }

        public int ActivityId { get; set; }
    }

    public class SyncDto
    {
        public Balance Balance { get; set; } = new Balance();

        public Order Order { get; set; } = new Order();

        public Activity Activity { get; set; } = new Activity();

        public Banky Banky { get; set; } = new Banky();
    }

    public class Balance
    {
        /// <summary>
        /// bonus余额
        /// </summary>
        public decimal Bonus { get; set; } = 0;

        /// <summary>
        /// 真金余额
        /// </summary>
        public decimal CashBalance { get; set; } = 0;

        /// <summary>
        /// 真金余额（s_user.Cash + s_user.Bonus）
        /// </summary>
        public decimal Cash { get; set; } = 0;
    }

    public class Order
    {
        public string OrderId { get; set; } = string.Empty;
        /// <summary>
        /// 状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理
        /// </summary>
        public int Status { get; set; } = 0;
    }

    public class Activity
    {
        /// <summary>
        /// 活动是否有效
        /// </summary>
        public bool IsValid { get; set; } = false;
        /// <summary>
        /// 活动编码
        /// </summary>
        public int ActivityId { get; set; } = 0;
        /// <summary>
        /// 活动给的固定奖励
        /// </summary>
        public decimal Bonus { get; set; } = 0;
        /// <summary>
        /// 是否IP地址限制
        /// </summary>
        public bool IsIpLimited { get; set; }
    }

    /// <summary>
    /// 破产保护
    /// </summary>
    public class Banky
    {
        /// <summary>
        /// 活动是否有效
        /// </summary>
        public bool IsValid { get; set; } = false;

        /// <summary>
        /// 剩余次数
        /// </summary>
        public int Times { get; set; } = 0;

        /// <summary>
        /// 剩余金额
        /// </summary>
        public decimal TotalAmount { get; set; } = 0;

        /// <summary>
        /// 类型,0-未知(默认值),1-Cash,2-Bonus
        /// </summary>
        public int? RefundType { get; set; } = 0;

        /// <summary>
        /// 返还金额
        /// </summary>
        public decimal RefundAmount { get; set; } = 0;

        /// <summary>
        /// DetailId
        /// </summary>
        public string? DetailId { get; set; } = null;
    }
}
