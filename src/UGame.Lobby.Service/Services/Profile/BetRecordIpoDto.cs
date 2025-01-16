using UGame.Lobby.Repository.ing;
using AiUo.AspNet;
using AiUo.Extensions.AutoMapper;
using Xxyy.Common;
using Xxyy.DAL;

namespace UGame.Lobby.Service.Services.Profile;

public enum SearchDate
{
    /// <summary>
    /// 本周
    /// </summary>
    Week = 0,
    /// <summary>
    /// 上周
    /// </summary>
    LastWeek = 1,
    /// <summary>
    /// 本月
    /// </summary>
    Month = 2
}


public class BetRecordDayIpo : LobbyBaseIpo
{
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

public class BetRecordDetailIpo : LobbyBaseIpo
{
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
    [RangeEx(1, double.MaxValue, "", $"PageIndex must be a positive integer greater than 0.")]
    public int PageIndex { get; set; } = 1;
    /// <summary>
    /// 页大小
    /// </summary>
    [RangeEx(1, double.MaxValue, "", "PageSize must be a positive integer greater than 0.")]
    public int PageSize { get; set; } = 10;
}

/// <summary>
/// 下注记录ipo
/// </summary>
public class BetRecordIpo
{
    /// <summary>
    /// 用户id
    /// </summary>
    [RequiredEx("", "UserId cannot be empty.")]
    public string UserID { get; set; }

    /// <summary>
    /// OperatorId
    /// </summary>
    [RequiredEx("", "OperatorID cannot be empty.")]
    public string OperatorID { get; set; }

    /// <summary>
    /// 货币类型
    /// </summary>
    [RequiredEx("", "CurrencyID cannot be empty.")]
    public string CurrencyID { get; set; }
}

public class BetRecordDto
{
    /// <summary>
    /// 下注总额
    /// </summary>
    public decimal? TotalBet { get; set; } = 0;

    /// <summary>
    /// 返奖总额
    /// </summary>
    public decimal? TotalRewardReturn { get; set; } = 0;

    /// <summary>
    /// 下注记录
    /// </summary>
    public List<BetRecord> Items { get; set; } = new List<BetRecord>();
}

/// <summary>
/// 下注记录dto
/// </summary>
public class BetRecord : IMapFrom<S_provider_orderPO>, IMapFrom<Sr_user_dayPO>
{
    /// <summary>
    /// 应用编码
    /// </summary>
    public string AppId { get; set; }

    /// <summary>
    /// 应用名称
    /// </summary>
    public string AppName { get; set; }

    /// <summary>
    /// 统计日
    /// </summary>
    public string Date { get; set; }

    /// <summary>
    /// 最后更新时间
    /// </summary>
    public DateTime RecDate { get; set; }

    /// <summary>
    /// 真金下注金额
    /// </summary>
    public decimal Bet { get; set; }

    /// <summary>
    /// 真金返奖金额
    /// </summary>
    public decimal Reward { get; set; }

    /// <summary>
    /// 下注bonus
    /// </summary>
    public decimal BetBonus { get; set; }

    /// <summary>
    /// 返奖bonus
    /// </summary>
    public decimal WinBonus { get; set; }

    /// <summary>
    /// 下注类型
    /// 0-默认值，无意义
    /// 1-真金下注
    /// 2-bonus下注
    /// 3-真金+bonus组合下注
    /// </summary>
    public int BetType { get; set; } = 0;

    public void MapFrom(S_provider_orderPO source)
    {
        Date = source.RecDate.ToLocalTime(source.OperatorID).ToString("yyyy-MM-dd");
        this.RecDate = new DateTime(source.RecDate.Ticks, DateTimeKind.Utc);

        if (source.BetBonus == 0)
        {
            this.BetType = 1;
            this.Bet = source.PlanBet.AToM(source.CurrencyID);
            this.Reward = source.PlanWin.AToM(source.CurrencyID);
            this.BetBonus = source.BetBonus.AToM(source.CurrencyID);
            this.WinBonus = source.WinBonus.AToM(source.CurrencyID);
        }
        else if (source.BetBonus > 0 && source.BetBonus >= source.PlanBet)
        {
            this.BetType = 2;
            this.Bet = 0;
            this.Reward = 0;
            this.BetBonus = source.BetBonus.AToM(source.CurrencyID);
            this.WinBonus = source.WinBonus.AToM(source.CurrencyID);
        }
        else if (source.BetBonus > 0 && source.BetBonus < source.PlanBet)
        {
            this.BetType = 3;
            this.Bet = (source.PlanBet - source.BetBonus).AToM(source.CurrencyID);
            this.Reward = (source.PlanWin - source.WinBonus).AToM(source.CurrencyID);
            this.BetBonus = source.BetBonus.AToM(source.CurrencyID);
            this.WinBonus = source.WinBonus.AToM(source.CurrencyID);
        }
    }

    public void MapFrom(Sr_user_dayPO source)
    {
        this.Date = source.DayID.ToString("yyyy-MM-dd");
        this.RecDate = source.RecDate;
        this.Bet = (source.BetAmount).AToM(source.CurrencyID);
        this.Reward = (source.WinAmount).AToM(source.CurrencyID);
        this.BetBonus = source.BetBonus.AToM(source.CurrencyID);
        this.WinBonus = source.WinBonus.AToM(source.CurrencyID);
    }
}
