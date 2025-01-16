using UGame.Lobby.Repository.ing;
using System.Text.Json.Serialization;
using AiUo.Extensions.AutoMapper;
using Xxyy.Common;

namespace UGame.Lobby.Service.Services.Profile;

public class LoadInfoIpo : LobbyBaseIpo
{
    /// <summary>
    /// 提现渠道4-pandapay5-tejeepay
    /// </summary>
    public int? Channels { get; set; }

}

public class LoadInfoDto
{
    /// <summary>
    /// 渠道信息
    /// </summary>
    public List<ChannelInfoDto> ChannelInfo { get; set; }

    /// <summary>
    /// 用户信息
    /// </summary>
    public UserInfoDto UserInfo { get; set; }

    /// <summary>
    /// 流水信息
    /// </summary>
    public FlowInfoDto FlowInfo { get; set; }

}

/// <summary>
/// 流水订单信息
/// </summary>
public class FlowInfoDto
{
    /// <summary>
    /// 流水订单日期
    /// </summary>
    public DateTime? OrderDate { get; set; }

    /// <summary>
    /// 订单金额
    /// </summary>
    public decimal OrderAmount { get; set; }

    /// <summary>
    /// 流水的倍数
    /// </summary>
    public float FlowMultip { get; set; }

    /// <summary>
    /// 需要完成的流水
    /// </summary>
    public decimal RequireFlow { get; set; } = 0;

    /// <summary>
    /// 已完成的流水
    /// </summary>
    public decimal CompletedFlow { get; set; } = 0;
}

/// <summary>
/// 用户信息
/// </summary>
public class UserInfoDto
{
    /// <summary>
    /// 是否提现过（true首次提现，false-非首次提现）
    /// </summary>
    public bool IsFirstCash { get; set; }
    /// <summary>
    /// 手机号
    /// </summary>
    public string Mobile { get; set; }

    /// <summary>
    /// 邮件
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// 可提现金额
    /// </summary>
    public decimal CashMoney { get; set; }

    /// <summary>
    /// 用户银行信息
    /// </summary>
    public List<UserBankDto> BankInfo { get; set; }
}

/// <summary>
/// 用户银行信息
/// </summary>
public class UserBankDto : IMapFrom<L_bra_user_bankPO>
{
    public string UserBankID { get; set; }

    public string UserId { get; set; }

    public string BankCode { get; set; }

    public string BankName { get; set; }

    [JsonPropertyName("accName")]
    public string Name { get; set; }

    [JsonPropertyName("cardNo")]
    public string AccountNumber { get; set; }

    public string TaxId { get; set; }
    public void MapFrom(L_bra_user_bankPO source)
    {
        TaxId = source.TaxId;
    }
}

public class ChannelInfoDto : IMapFrom<Sc_cash_configPO>
{
    /// <summary>
    /// 运营商编码
    /// </summary>
    public string OperatorId { get; set; }

    /// <summary>
    /// 国家编码ISO 3166-1三位字母
    /// </summary>
    public string CountryId { get; set; }

    /// <summary>
    /// 货币类型
    /// </summary>
    public string CurrencyId { get; set; }

    /// <summary>
    /// 提现渠道4-pandapay5-tejeepay
    /// </summary>
    public int Channels { get; set; }

    /// <summary>
    /// 提现渠道描述,对应channels
    /// </summary>
    public string ChannelsDesc { get; set; }

    /// <summary>
    /// 当日最大限额
    /// </summary>
    public decimal DayCashMaxLimitAmount { get; set; }

    /// <summary>
    /// 最小提现金额
    /// </summary>
    public decimal MinAmount { get; set; }

    /// <summary>
    /// 最大提现金额
    /// </summary>
    public decimal MaxAmount { get; set; }


    public void MapFrom(Sc_cash_configPO source)
    {
        MinAmount = source.CashMaxAmount.AToM(source.CurrencyID);
        MaxAmount = source.CashMaxAmount.AToM(source.CurrencyID);
        DayCashMaxLimitAmount = source.DayCashMaxLimitAmount.AToM(source.CurrencyID);
    }
}
