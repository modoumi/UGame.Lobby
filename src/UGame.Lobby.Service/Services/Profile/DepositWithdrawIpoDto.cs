using UGame.Lobby.Common.Enum;
using UGame.Lobby.Repository.ing;
using Lobby.Flow.Common;
using System.Text.Json.Serialization;
using AiUo.AspNet;
using AiUo.Extensions.AutoMapper;
using UGame.Lobby.Service.Services.Cash;
using Xxyy.Banks.Client.BLL;
using Xxyy.Banks.Client.BLL.Pandapay;
using Xxyy.Banks.Client.BLL.Tejeepay;
using Xxyy.Common;
using Xxyy.Common.Caching;
using Xxyy.Common.Services;
using Xxyy.DAL;

namespace UGame.Lobby.Service.Services.Profile
{
    /// <summary>
    /// 巴西充值ipo
    /// </summary>
    public class BraDepositIpo : LobbyBaseIpo, IMapTo<Xxyy.Banks.Client.BLL.Pandapay.XxyyPandapayIpo>
    {
        /// <summary>
        /// 应用编码
        /// </summary>
        [RequiredEx("", "AppId cannot be empty.")]
        public string AppId { get; set; }

        /// <summary>
        /// 充值金额
        /// </summary>
        [RegularExpressionEx("^(([1-9]{1}\\d*)|(0{1}))(\\.\\d{1,2})?$", "", "Pay Amount Integer or two decimal places.")]
        public decimal Amount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 客户姓名
        /// </summary>
        [JsonIgnore]
        public string AccName { get; set; }

        ///// <summary>
        ///// hubtel支付方式需要的通道（mtn-gh,vodafone-gh,tigo-gh）移动至AdditionalParameters
        ///// </summary>
        //public string HubtelChannel { get; set; }

        /// <summary>
        /// 税号
        /// </summary>
        [JsonIgnore]
        public string TaxId { get; set; }

        /// <summary>
        /// 支付渠道编码4、pandapay;5、tejeepay
        /// </summary>
        public int Channels { get; set; }

        /// <summary>
        /// 支付渠道枚举
        /// </summary>
        [JsonIgnore]
        public BraPayChannel BraPayChannel { get; set; }

        [JsonIgnore]
        public string UserIp { get; set; }

        /// <summary>
        /// 充值参与领取bonus状态，0不参与，1参与
        /// </summary>
        public int ReceiveBonus { get; set; } = 0;

        /// <summary>
        /// 活动编码集合
        /// </summary>
        [JsonIgnore]
        public List<int> ActivityIdList = new List<int>();

        /// <summary>
        /// 是否增加余额
        /// </summary>
        [JsonIgnore]
        public bool IsAddBalance { get; set; } = true;

        public dynamic Meta { get; set; }

        public Dictionary<string, object> AdditionalParameters { get; set; }

        public void MapTo(XxyyPandapayIpo destination)
        {
            this.UserIp = AspNetUtil.GetRemoteIpString();
        }
    }

    /// <summary>
    /// 巴西充值dto
    /// </summary>
    public class BraDepositDto : IMapFrom<Xxyy.Banks.Client.BLL.Pandapay.PandapayDto>
    {
        public string BarCode { get; set; }

        public string QRCode { get; set; }

        public string OrderId { get; set; }
        public string Channel { get; set; }
        /// <summary>
        /// 0.payurl 1.code
        /// </summary>
        public int Mode { get; set; }

        //public string PayUrl { get; set; }

        public void MapFrom(PandapayDto source)
        {

        }
    }

    /// <summary>
    /// 巴西提现ipo
    /// </summary>
    public class BraWithDrawIpo : LobbyBaseIpo
    {
        /// <summary>
        /// 应用编码
        /// </summary>
        [RequiredEx("", "AppId cannot be empty.")]
        public string AppId { get; set; }

        /// <summary>
        /// 提现金额
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string UserBankId { get; set; }

        /// <summary>
        /// 支付渠道编码4、pandapay;5、tejeepay
        /// </summary>
        public int Channels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 提现类型（0、CPF;1、CNPJ;2、PHONE;3、EMAIL;4、EVP）
        /// </summary>
        public TejeePayMethodEnum CashType { get; set; }

        /// <summary>
        /// 固定值：税号-对应巴西的CPF，无论那种提现方式都需要，11位数字不带横线，不能为空！
        /// </summary>
        public string TaxId { get; set; }

        /// <summary>
        /// 账户号码和CashType对应--如：CPF对应CPF号码，CNPJ-对应的CNPJ号码，Email对应邮箱地址，PHONE-对应手机号等
        /// </summary>
        public string AccountNo { get; set; }

        /// <summary>
        /// 支付渠道枚举
        /// </summary>
        [JsonIgnore]
        public BraPayChannel BraPayChannel { get; set; }

        /// <summary>
        /// 巴西用户税号、户名eo
        /// </summary>
        //[JsonIgnore]
        //public L_bra_userEO BraUserEo { get; set; }

        /// <summary>
        /// 巴西用户银行卡缓存
        /// </summary>
        [JsonIgnore]
        public List<L_bra_user_bankPO> BraUserBankEoList { get; set; }

        /// <summary>
        /// 提现使用的银行卡
        /// </summary>
        [JsonIgnore]
        public L_bra_user_bankPO BraUserBankEo { get; set; }

        /// <summary>
        /// s_user_ex
        /// </summary>
        [JsonIgnore]
        public S_user_exEO UserExEo { get; set; }

        /// <summary>
        /// s_user
        /// </summary>
        [JsonIgnore]
        public S_userPO UserEo { get; set; }

        /// <summary>
        /// sc_cash_config
        /// </summary>
        [JsonIgnore]
        public Sc_cash_configEO CashConfigEo { get; set; }

        /// <summary>
        /// CommonUserService
        /// </summary>
        [JsonIgnore]
        public UserService CommonUserServices { get; set; }

        /// <summary>
        /// CurrencyChangeService
        /// </summary>
        [JsonIgnore]
        public CurrencyChangeService CurrencyChangeServices { get; set; }

        /// <summary>
        /// 数据查询起始时间
        /// </summary>
        public DateTime StartTime { get; set; }
        /// <summary>
        /// 数据查询截止时间
        /// </summary>
        public DateTime EndTime { get; set; }
        /// <summary>
        /// 用户当天提现总次数
        /// </summary>
        [JsonIgnore]
        public long SumCashNum { get; set; }
        /// <summary>
        /// 用户当天提现总额
        /// </summary>
        [JsonIgnore]
        public long SumCashAmount { get; set; }

        /// <summary>
        /// 用户提现审批中非拒绝状态的提现总额
        /// </summary>
        //[JsonIgnore]
        //public long UserAllAuditCashSumAmount { get; set; }

        //[JsonIgnore]
        //public SqlSink sqlSink { get; set; } = new SqlSink();

        [JsonIgnore]
        public GlobalUserDCache GlobalUserDCache { get; set; }

        /// <summary>
        /// 用户ip
        /// </summary>
        [JsonIgnore]
        public string UserIp { get; set; }

        /// <summary>
        /// 审核id
        /// </summary>
        [JsonIgnore]
        public string CashAuditId { get; set; }

        /// <summary>
        /// 提现审核条件配置
        /// </summary>
        [JsonIgnore]
        public List<Sc_cash_condition_configPO> CashConditionConfigEoList { get; set; } = new List<Sc_cash_condition_configPO>();

        [JsonIgnore]
        public V_s_operatorPO SOperatorEO { get; set; }

        /// <summary>
        /// 用户当前vip等级，目前只在长版本生效
        /// </summary>
        [JsonIgnore]
        public Sc_vip_configEO CurrVipConfig { get; set; } = null;
        [JsonIgnore]
        public float CashRate { get; set; }

        [JsonIgnore]
        public UserCashService UserCashService { get; set; } = new UserCashService();

        /// <summary>
        /// 用户历史提现次数、金额
        /// </summary>
        [JsonIgnore]
        public UserCashInfo HistoryUserCashInfo { get; set; } = new UserCashInfo();

        /// <summary>
        /// 用户当天提现次数、金额
        /// </summary>
        [JsonIgnore]
        public UserCashInfo UserCurrDayCashInfo { get; set; } = new UserCashInfo();

        /// <summary>
        /// 是否首次提现
        /// </summary>
        public bool IsFirstCash { get; set; } = false;
        public Dictionary<string, object> AdditionalParameters { get; set; }
    }

    /// <summary>
    /// 巴西提现dto
    /// </summary>
    public class BraWithDrawDto : LobbyBaseDto, IMapFrom<Xxyy.Banks.Client.BLL.Tejeepay.TejeeProxyPayDto>, IMapFrom<Xxyy.Banks.Client.BLL.BaseDto>
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
        /// 是否成功
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// 是否进入提现审核
        /// </summary>
        public bool IsAudit { get; set; } = false;

        public void MapFrom(BaseDto source)
        {
            this.Amount = source.Amount.AToM(source.CurrencyId);
        }

        public void MapFrom(TejeeProxyPayDto source)
        {
            this.Amount = source.Amount.AToM(source.CurrencyId);
        }
    }


    /// <summary>
    /// 巴西充值ipo（tejeePay）
    /// </summary>
    public class BraTejeePayDepositIpo : LobbyBaseIpo
    {
        /// <summary>
        /// 应用编码
        /// </summary>
        [RequiredEx("", "AppId cannot be empty.")]
        public string AppId { get; set; }

        /// <summary>
        /// 充值金额
        /// </summary>
        [RangeEx(100, 200000, "", "PageSize must be a correct integer between 1 and 200000.")]
        public decimal Amount { get; set; }
    }

    /// <summary>
    /// 巴西提现ipo（tejeePay）
    /// </summary>
    public class BraTejeePayWithDrawIpo : LobbyBaseIpo
    {
        /// <summary>
        /// 应用编码
        /// </summary>
        [RequiredEx("", "AppId cannot be empty.")]
        public string AppId { get; set; }

        /// <summary>
        /// 提现金额
        /// </summary>
        [RangeEx(100, 200000, "", "PageSize must be a correct integer between 1 and 200000.")]
        public decimal Amount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string UserBankId { get; set; }
    }

    /// <summary>
    /// 巴西提现dto
    /// </summary>
    public class BraTejeePayWithDrawDto : LobbyBaseDto, IMapFrom<Xxyy.Banks.Client.BLL.Tejeepay.TejeeProxyPayDto>
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
        [JsonIgnore]
        public object Meta { get; set; }
        /// <summary>
        /// 是否成功
        /// </summary>
        public bool Success { get; set; }

        public void MapFrom(TejeeProxyPayDto source)
        {
            Amount = source.Amount.AToM(source.CurrencyId);
        }
    }

    /// <summary>
    /// 用户充值、提下记录dto，用于体现过程中的数据载体
    /// </summary>
    public class UserPayCashDto
    {
        /// <summary>
        /// 总提现次数
        /// </summary>
        public long? SumCashCount { get; set; }

        /// <summary>
        /// 提现总金额
        /// </summary>
        public long? SumCashAmount { get; set; }
    }

}
