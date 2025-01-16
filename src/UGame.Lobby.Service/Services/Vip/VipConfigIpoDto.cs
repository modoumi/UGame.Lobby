using UGame.Lobby.Repository.ing;
using AiUo.Extensions.AutoMapper;
using Xxyy.Common;

namespace UGame.Lobby.Service.Services.Vip;

public class VipConfigIpo : LobbyBaseIpo
{

}

public class VipConfigDto
{

    /// <summary>
    /// 0-默认版本
    /// 1-长线版本
    /// </summary>
    public int Version { get; set; } = 0;


    /// <summary>
    /// 当前vip积分
    /// </summary>
    public decimal Point { get; set; }

    /// <summary>
    /// 当前用户累计充值金额
    /// </summary>
    public decimal TotalPayAmount { get; set; }

    /// <summary>
    /// 当前用户对应的vip等级
    /// </summary>
    public VipConfigItem CurrVipConfig { get; set; }

    /// <summary>
    /// 所有等级段vip配置
    /// </summary>
    public List<VipConfigItem> Items { get; set; } = new List<VipConfigItem>();
}

public class VipConfigItem : IMapFrom<Sc_vip_configPO>
{
    /// <summary>
    /// vip等级
    /// </summary>
    public int VipGrade { get; set; }

    /// <summary>
    /// 当前等级最小充值金额
    /// </summary>
    public decimal CurrentGradeMinPay { get; set; }

    /// <summary>
    /// 当前等级最大充值金额
    /// </summary>
    public decimal CurrentGradeMaxPay { get; set; }

    /// <summary>
    /// 需要达到的最小下注额度
    /// </summary>
    public decimal BetMinAmount { get; set; }

    /// <summary>
    /// 需要达到的最大下注额度
    /// </summary>
    public decimal BetMaxAmount { get; set; }

    /// <summary>
    /// 升级奖励
    /// </summary>
    public decimal GradeReward { get; set; }

    /// <summary>
    /// 每周可享收益
    /// </summary>
    public decimal WeekReward { get; set; }

    /// <summary>
    /// 提现手续费
    /// </summary>
    public int Rate { get; set; }

    /// <summary>
    /// 当日提现次数上限
    /// </summary>
    public int CashNumLimit { get; set; }

    /// <summary>
    /// 当日提现金额上限
    /// </summary>
    public decimal CashAmountLimit { get; set; }

    public VipRewardStatusEnum Status { get; set; } = VipRewardStatusEnum.NoAllow;

    public void MapFrom(Sc_vip_configPO source)
    {
        CurrentGradeMinPay=source.PayStartAmount.AToM(source.CurrencyID);
        CurrentGradeMaxPay=source.PayEndAmount.AToM(source.CurrencyID);
        BetMinAmount = source.BetMinAmount.AToM(source.CurrencyID);
        BetMaxAmount = source.BetMaxAmount.AToM(source.CurrencyID);
        GradeReward = source.GradeReward.AToM(source.CurrencyID);
        WeekReward = source.WeekReward.AToM(source.CurrencyID);
        Rate = Convert.ToInt32(source.CashRate * 100);
        CashNumLimit = source.DayCashNumLimit;
        CashAmountLimit = source.DayCashAmountLimit.AToM(source.CurrencyID);
    }
}

public enum VipRewardStatusEnum
{
    /// <summary>
    /// 不允许
    /// </summary>
    NoAllow = 0,
    /// <summary>
    /// 允许
    /// </summary>
    Allow = 1,
    /// <summary>
    /// 已领取
    /// </summary>
    Received = 2
}
