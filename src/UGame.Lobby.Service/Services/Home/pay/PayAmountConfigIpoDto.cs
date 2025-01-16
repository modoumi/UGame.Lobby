using UGame.Lobby.Repository.ing;
using System.Text.Json.Serialization;
using AiUo.AspNet;
using AiUo.Extensions.AutoMapper;
using UGame.Lobby.Service.Services.Init;
using Xxyy.Common;

namespace UGame.Lobby.Service.Services.Home.pay;

/// <summary>
/// 充值金额ipo
/// </summary>
public class PayAmountConfigIpo : LobbyBaseIpo
{
    /// <summary>
    /// 应用编码
    /// </summary>
    public string AppId { get; set; }

    /// <summary>
    /// 充值金额
    /// </summary>
    //[RegularExpressionEx("^(([1-9]{1}\\d{1,6})|(0{1,7}))(\\.\\d{1,2})?$", "", "Pay Amount Integer or two decimal places.")]
    [RegularExpressionEx("^(([1-9]{1}\\d*)|(0{1}))(\\.\\d{1,2})?$", "", "Pay Amount Integer or two decimal places.")]
    public decimal Amount { get; set; }

    /// <summary>
    /// 充值参与领取bonus状态，0不参与，1参与
    /// </summary>
    public int ReceiveBonus { get; set; } = 0;
}

/// <summary>
/// 充值金额dto
/// </summary>
public class PayAmountConfigDto
{
    /// <summary>
    /// 本次充值的赠金次数，当前第几次充值
    /// </summary>
    public int frequency { get; set; } = 0;

    /// <summary>
    /// 奖励bonus的最小充值金额
    /// </summary>
    public decimal leastPayForReward { get; set; } = 0;

    /// <summary>
    /// 赠金倍数
    /// </summary>
    public float multiple { get; set; } = 0;

    /// <summary>
    /// 赠金上限
    /// </summary>
    public decimal maximum { get; set; } = 0;

    /// <summary>
    /// 是否允许手动输入金额
    /// </summary>
    public bool IsInputAmount { get; set; } = true;

    /// <summary>
    /// 长线版本bonus加成
    /// </summary>
    public int Rate { get; set; }

    public Dictionary<int, ChannelsData> Data { get; set; } = new Dictionary<int, ChannelsData>();

    /// <summary>
    /// 最大优惠充值次数
    /// </summary>
    public int PreferentialPayNumLimit { get; set; }

    /// <summary>
    /// 可用优惠充值次数
    /// </summary>
    public int PreferentialPayNumAllow { get; set; }
}

/// <summary>
/// PayAmountConfigItem
/// </summary>
public class PayAmountConfigItem : IMapFrom<L_pay_amount_configEO>, IMapFrom<L_pay_amount_configPO>
{
    [JsonIgnore]
    public string OperatorId { get; set; }

    [JsonIgnore]
    public string CountryId { get; set; }

    [JsonIgnore]
    public string CurrencyId { get; set; }

    [JsonIgnore]
    public string Channels { get; set; }

    public decimal Amount { get; set; }

    public decimal Bonus { get; set; }

    public decimal Rate { get; set; }

    public int OrderNum { get; set; }

    public bool IsSelected { get; set; }

    public bool HotFlag { get; set; }

    public void MapFrom(L_pay_amount_configEO source)
    {
        this.Amount = source.PayAmount.AToM(source.CurrencyID);
    }

    public void MapFrom(L_pay_amount_configPO source)
    {
        this.Amount = source.PayAmount.AToM(source.CurrencyID);
    }
}

public class ChannelsData
{
    public string Channels { get; set; }

    public AmountLimit Channelimit { get; set; }

    public List<PayAmountConfigItem> Items { get; set; } = new();
}
