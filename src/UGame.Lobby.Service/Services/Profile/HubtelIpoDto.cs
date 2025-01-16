using System.Text.Json.Serialization;
using AiUo.AspNet;
using AiUo.Extensions.AutoMapper;
using AiUo.Text;

namespace UGame.Lobby.Service.Services.Profile
{
    public class HubtelChannelsIpo : LobbyBaseIpo
    {
        /// <summary>
        /// 应用编码
        /// </summary>
        [RequiredEx("", "AppId cannot be empty.")]
        public string AppId { get; set; }
        /// <summary>
        /// 银行id
        /// </summary>
        [JsonIgnore]
        public string BankId { get; set; }
        /// <summary>
        /// 请求id
        /// </summary>
        [JsonIgnore]
        public string RequestUUID { get; set; } = ObjectId.NewId();
    }

    /// <summary>
    /// 充值Or提现Ipo
    /// </summary>
    public class DepositOrWithdrawIpo : LobbyBaseIpo
    {
        /// <summary>
        /// 请求编码
        /// </summary>
        [JsonIgnore]
        public string RequestUUID { get; set; } = ObjectId.NewId();
        /// <summary>
        /// 应用编码
        /// </summary>
        [RequiredEx("", "AppId cannot be empty.")]
        public string AppId { get; set; }
        /// <summary>
        /// 银行编码
        /// </summary>
        [JsonIgnore]
        public string BankId { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        [JsonIgnore]
        public string Mobile { get; set; }
        /// <summary>
        /// 渠道编号
        /// </summary>
        [RequiredEx("", "Channel cannot be empty.")]
        public string Channel { get; set; }
        /// <summary>
        /// 充值金额
        /// </summary>
        [RangeEx(50, double.MaxValue, "", "Amount must be a positive integer greater than 50.")]
        public decimal Amount { get; set; }
        /// <summary>
        /// 当前引用OrderId
        /// 自有own应用不需要
        /// </summary>
        [JsonIgnore]
        public string AppOrderId { get; set; } = ObjectId.NewId();
        /// <summary>
        /// 请求备注
        /// </summary>
        [JsonIgnore]
        public string ReqComment { get; set; } = ObjectId.NewId();
    }

    public class DepositOrWithdrawDto 
    {
        public string RequestUUID { get; set; }
        public string UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>

        public string CurrencyId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public long Amount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public long Balance { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public string OrderId { get; set; }


        public string Status { get; set; }


        public string Message { get; set; }
        /// <summary>
        /// 扩展书
        /// </summary>
        public object Meta { get; set; }
    }

}
