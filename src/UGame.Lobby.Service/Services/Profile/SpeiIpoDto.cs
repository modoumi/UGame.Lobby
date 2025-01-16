using System.Text.Json.Serialization;
using AiUo.AspNet;
using AiUo.Extensions.AutoMapper;
using AiUo.Serialization;
using AiUo.Text;
using Xxyy.Banks.Client;
using Xxyy.Banks.Client.BLL;
using Xxyy.Banks.Client.BLL.Mongopay;
using Xxyy.Common;

namespace UGame.Lobby.Service.Services.Profile
{
    public class SpeiDepositIpo : LobbyBaseIpo, IMapTo<XxyyMongopayIpo>
    {
        /// <summary>
        /// 请求编码
        /// </summary>
        [JsonIgnore]
        public string RequestUUID { get; set; } = ObjectId.NewId();
        /// <summary>
        /// 应用编码
        /// </summary>
        [RequiredEx("", "AppId不可为空")]
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

        public void MapTo(XxyyMongopayIpo destination)
        {
            
        }
    }

    public class SpeiWithdrawIpo : SpeiDepositIpo, IMapTo<Xxyy.Banks.Client.BLL.Mongopay.XxyyMongoCashIpo>
    {
        /// <summary>
        /// 提现金额
        /// </summary>
        public decimal Amount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [RequiredEx("", "Name cannot be empty.")]
        public string Name { get; set; }

        [JsonIgnore]
        public string AccName
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(Name))
                    return Name;
                return string.Empty;
            }
            set
            {
                value = Name;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string IDNo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Birthday { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// 收款银行代码：见附录
        /// </summary>
        public string BankCode { get; set; }

        /// <summary>
        /// 收款银行账号
        /// </summary>
        [RequiredEx("", "BankNumber cannot be empty.")]
        public string BankNumber { get; set; }

        [JsonIgnore]
        public string AccNumber
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(BankNumber))
                    return BankNumber;
                return string.Empty;
            }
            set
            {
                value = BankNumber;
            }
        }

        public JsonMeta AdditionalParameters { get; set; }

        public void MapTo(XxyyMongoCashIpo destination)
        {
            
        }
    }

    public class SpeiDepositDto : IMapFrom<MongopayDto>
    {
        /// <summary>
        /// 每次请求的唯一标识
        /// </summary>
        public string RequestUUID { get; set; }
        /// <summary>
        /// 用户唯一标识
        /// </summary>
        public string UserId { get; set; }
        /// <summary>
        /// 货币编码
        /// </summary>
        public string CurrencyId { get; set; }
        /// <summary>
        /// 金额
        /// </summary>
        public decimal Amount { get; set; }
        /// <summary>
        /// 账户余额
        /// </summary>
        public decimal Balance { get; set; }
        /// <summary>
        /// 订单id
        /// </summary>
        public string OrderId { get; set; }
        /// <summary>
        /// SPEI创建的虚拟账号
        /// </summary>
        public string VaNumber { get; set; }
        /// <summary>
        /// 状态描述
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// 扩展书
        /// </summary>
        public object Meta { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// 是否成功
        /// </summary>
        public bool Success { get; set; }

        public void MapFrom(MongopayDto source)
        {
            Amount = source.Amount.AToM(source.CurrencyId);
            Balance = source.Balance.AToM(source.CurrencyId);
            Success = source.Status.Equals(ResponseCodes.RS_OK) ? true : false;
        }
    }

    public class SpeiDepositOrWithdrawDto : IMapFrom<MongopayDto>, IMapFrom<Xxyy.Banks.Client.BLL.BaseDto>
    {
        /// <summary>
        /// 每次请求的唯一标识
        /// </summary>
        public string RequestUUID { get; set; }
        /// <summary>
        /// 用户编码
        /// </summary>
        public string UserId { get; set; }
        /// <summary>
        /// 货币编码
        /// </summary>
        public string CurrencyId { get; set; }
        /// <summary>
        /// 充值金额
        /// </summary>
        public decimal Amount { get; set; }
        /// <summary>
        /// 账户余额
        /// </summary>
        public long Balance { get; set; }
        /// <summary>
        /// 订单编码
        /// </summary>
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
        /// 描述
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// 创建的虚拟账号
        /// </summary>
        public string VaNumber { get; set; }
        /// <summary>
        /// 是否成功
        /// </summary>
        public bool Success { get; set; }

        public void MapFrom(BaseDto source)
        {
            Amount = source.Amount.AToM(source.CurrencyId);
            Success = source.Status.Equals(ResponseCodes.RS_OK) ? true : false;
        }

        public void MapFrom(MongopayDto source)
        {
            Amount = source.Amount.AToM(source.CurrencyId);
        }
    }


    public class CashConfirmDto : IMapFrom<CalcCashFeeDto>
    {

        /// <summary>
        /// 服务费
        /// </summary>
        public decimal ServiceCharge { get; set; }

        public CashConfirmData Data { get; set; } = new CashConfirmData();

        public void MapFrom(CalcCashFeeDto source)
        {
            this.ServiceCharge = source.Fee;
        }
    }

    public class CashConfirmData
    {
        /// <summary>
        /// 是否满足最低充值金额
        /// </summary>
        public bool IsMinPay { get; set; } = true;
        /// <summary>
        /// 最低充值金额
        /// </summary>
        public decimal MinPay { get; set; } = 0;
    }
}
