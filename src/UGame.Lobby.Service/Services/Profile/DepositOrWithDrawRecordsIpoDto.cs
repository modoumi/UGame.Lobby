using UGame.Lobby.Common.Enum;
using UGame.Lobby.Repository.ing;
using System.Text.Json.Serialization;
using AiUo;
using AiUo.AspNet;
using AiUo.Extensions.AutoMapper;
using Xxyy.Common;
using Xxyy.DAL;

namespace UGame.Lobby.Service.Services.Profile
{
    /// <summary>
    /// 充值、提现记录Ipo
    /// </summary>
    public class DepositOrWithDrawRecordsIpo : LobbyBaseIpo
    {
        /// <summary>
        /// 查询类型
        /// 1-充值
        /// 2-提现
        /// 3-bonus奖励记录
        /// </summary>
        public int Type { get; set; } = 1;

        /// <summary>
        /// 查询起始时间
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// 截止时间
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [RangeEx(1, int.MaxValue, "", "PageIndex must be a positive integer greater than 0.")]
        public int PageIndex { get; set; } = 1;

        /// <summary>
        /// 页大小
        /// </summary>
        [RangeEx(1, 10, "", "PageSize must be a correct integer between 1 and 10.")]
        public int PageSize { get; set; } = 5;
    }

    /// <summary>
    /// 充值、提现记录Dto
    /// </summary>
    public class DepositOrWithDrawRecordsDto : IMapFrom<Sb_bank_orderEO>
    {

        /// <summary>
        /// 银行编码
        /// </summary>
        [JsonIgnore]
        public string BankID { get; set; }

        /// <summary>
        /// 支付方式下的渠道
        /// </summary>
        [JsonIgnore]
        public int PaytypeChannel { get; set; }

        /// <summary>
        /// 支付方式0-综合1-visa2-spei
        /// </summary>
        [JsonIgnore]
        public int PaytypeID { get; set; }

        /// <summary>
        /// 充值、提现渠道
        /// </summary>
        public string ChannelName { get; set; }

        /// <summary>
        /// 订单编号
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// 发起时间
        /// </summary>
        public DateTime ApplyTime { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// 实际金额（正负数）
        /// </summary>
        public decimal Amount { get; set; }

        public void MapFrom(Sb_bank_orderEO source)
        {
            ApplyTime = source.AppRequestTime;
            Status = source.Status;
            if (source.OrderType == 1)
                Amount = source.Amount.AToM(source.CurrencyID);
            if (source.OrderType == 2)
                Amount = -source.Amount.AToM(source.CurrencyID);
        }
    }

    /// <summary>
    /// 充值记录缓存
    /// </summary>
    public class PayRecordsDCacheData
    {
        /// <summary>
        /// sb_bank_order.BankID,银行编码
        /// </summary>
        public string BankID { get; set; }

        /// <summary>
        /// sb_bank_order.PaytypeID,支付方式0-综合1-visa2-spei
        /// </summary>
        public int PaytypeID { get; set; }

        /// <summary>
        /// sb_bank_order.PaytypeChannel,支付方式下的渠道
        /// </summary>
        public int PaytypeChannel { get; set; }

        /// <summary>
        /// sb_bank_order.OrderId,订单编码
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// sb_bank_order.AppRequestTime,请求时间
        /// </summary>
        public DateTime AppRequestTime { get; set; }

        /// <summary>
        /// sb_bank_order.Status,状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理
        /// </summary>
        public int OrderStatus { get; set; }

        /// <summary>
        /// sb_bank_order.Amount,实际数量（正负数）
        /// </summary>
        public long OrderAmount { get; set; }

        /// <summary>
        /// 货币编码
        /// </summary>
        public string CurrencyId { get; set; }

        /// <summary>
        /// s_requireflow_order.CompletedFlow,当前已完成流水
        /// </summary>
        public long? CompletedFlowAmount { get; set; } = 0;

        /// <summary>
        /// s_requireflow_order.RequireFlow,提现所要达到的流水
        /// </summary>
        public long? RequireFlowAmount { get; set; } = 0;

        /// <summary>
        /// s_requireflow_order.RecDate,记录时间
        /// </summary>
        public DateTime? FlowOrderRecDate { get; set; }

        /// <summary>
        /// s_requireflow_order.UpdateTime,更新时间
        /// </summary>
        public DateTime? FlowOrderUpdateTime { get; set; }

        /// <summary>
        /// s_requireflow_order.Status,状态0-未完成1-完成
        /// </summary>
        public int? FlowOrderStatus { get; set; } = 0;

        /// <summary>
        /// s_requireflow_order.FlowMultip,要求的流水系数（倍数）
        /// </summary>
        public float? FlowMultip { get; set; } = 1;
    }

    /// <summary>
    /// 用户记录ipo
    /// </summary>
    public class UserRecordsIpo : LobbyBaseIpo
    {
        /// <summary>
        /// 起始时间
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// 截止时间
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [RangeEx(1, int.MaxValue, "", "PageIndex must be a positive integer greater than 0.")]
        public int PageIndex { get; set; } = 1;

        /// <summary>
        /// 页大小
        /// </summary>
        [RangeEx(1, 10, "", "PageSize must be a correct integer between 1 and 10.")]
        public int PageSize { get; set; } = 5;
    }

    /// <summary>
    /// 提现记录dto
    /// </summary>
    public class PayCashRecordsDto : IMapFrom<Sb_bank_orderEO>, IMapFrom<PayRecordsDCacheData>, IMapFrom<S_requireflow_orderEO>, IMapFrom<Sc_cash_auditEO>, IMapFrom<S_currency_changeEO>
    {
        /// <summary>
        /// 银行编码（支付渠道）
        /// </summary>
        [JsonPropertyName("channelName")]
        public string BankID { get; set; }

        /// <summary>
        /// 支付方式下的渠道
        /// </summary>
        [JsonIgnore]
        public int PaytypeChannel { get; set; }

        /// <summary>
        /// 支付方式0-综合1-visa2-spei
        /// </summary>
        [JsonIgnore]
        public int PaytypeID { get; set; }

        /// <summary>
        /// 货币编码
        /// </summary>
        public string CurrencyId { get; set; }

        /// <summary>
        /// 订单编号
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// 发起时间
        /// </summary>
        public DateTime ApplyTime { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime UpdateTime { get; set; }

        /// <summary>
        /// 状态
        /// 充值：0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理
        /// 提现：0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理100-审核处理中102-审核拒绝103-审核异常待处理
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// 实际金额（正负数）
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// 已完成流水
        /// </summary>
        public decimal CompletedFlowMoney { get; set; } = 0;

        /// <summary>
        /// 提现所要达到的流水
        /// </summary>
        public decimal RequireFlowMoney { get; set; } = 0;

        /// <summary>
        /// 流水系数
        /// </summary>
        public float FlowMultip { get; set; } = 0;

        /// <summary>
        /// 充值
        /// </summary>
        /// <param name="source"></param>
        public void MapFrom(PayRecordsDCacheData source)
        {
            this.ApplyTime = new DateTime(source.AppRequestTime.Ticks, DateTimeKind.Utc);
            this.UpdateTime = this.ApplyTime;
            this.Amount = source.OrderAmount.AToM(source.CurrencyId);
            this.Status = source.OrderStatus;
            if (source.CompletedFlowAmount.HasValue)
                this.CompletedFlowMoney = source.CompletedFlowAmount.Value.AToM(source.CurrencyId);
            if (source.RequireFlowAmount.HasValue)
                this.RequireFlowMoney = source.RequireFlowAmount.Value.AToM(source.CurrencyId);
        }

        /// <summary>
        /// 提现
        /// </summary>
        /// <param name="source"></param>
        public void MapFrom(Sb_bank_orderEO source)
        {
            this.ApplyTime = new DateTime(source.AppRequestTime.Ticks, DateTimeKind.Utc);
            this.UpdateTime = this.ApplyTime;
            this.Amount = source.OrderType switch
            {
                1 => source.Amount.AToM(source.CurrencyID),
                2 => -source.Amount.AToM(source.CurrencyID),
                _ => source.Amount
            };
        }

        /// <summary>
        /// bonus奖励
        /// </summary>
        /// <param name="source"></param>
        public void MapFrom(S_requireflow_orderEO source)
        {
            this.ApplyTime = new DateTime(source.RecDate.Ticks, DateTimeKind.Utc);
            this.UpdateTime = new DateTime(source.UpdateTime.Ticks, DateTimeKind.Utc);
            this.Amount = source.OrderAmount.AToM(source.CurrencyID);
            this.CompletedFlowMoney = source.CompletedFlow.AToM(source.CurrencyID);
            this.RequireFlowMoney = source.RequireFlow.AToM(source.CurrencyID);

            if (source.Status > 1)
                this.Status = 2;

            var channelName = source.BonusSourceType.ToEnumN<ActivityType>();
            if (channelName.HasValue)
                this.BankID = channelName.ToString();
        }

        /// <summary>
        /// 提现，非审核成功的审批数据
        /// </summary>
        /// <param name="source"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void MapFrom(Sc_cash_auditEO source)
        {
            this.BankID = source.BankID;
            this.Status = source.Status switch
            {
                2 => 102, //审核拒绝
                //3 => 103, //审核异常待处理
                5 => 102, //失败
                _ => 100  //审核处理中
            };
            this.ApplyTime = new DateTime(source.ApplyTime.Ticks, DateTimeKind.Utc);
            this.UpdateTime = new DateTime(source.ApplyTime.Ticks, DateTimeKind.Utc);
            this.Amount = source.Amount.AToM(source.CurrencyID);
        }

        public void MapFrom(S_currency_changeEO source)
        {
            this.ApplyTime = new DateTime(source.RecDate.Ticks, DateTimeKind.Utc);
            this.UpdateTime = this.ApplyTime;
            if (source.DealTime.HasValue)
                this.UpdateTime = new DateTime(source.DealTime.Value.Ticks, DateTimeKind.Utc);

            this.Amount = source.Amount.AToM(source.CurrencyID);

            this.OrderId = source.ChangeID;
        }
    }
}
