namespace UGame.Lobby.Service.Services.Vip;

public class UserVipInfoIpo : LobbyBaseIpo
{

}

public class UserVipInfoDto
{
    /// <summary>
    /// 当前vip等级
    /// </summary>
    public int Vip { get; set; }

    /// <summary>
    /// 当前vip积分
    /// </summary>
    public decimal Point { get; set; }

    /// <summary>
    /// 下一升级奖励
    /// </summary>
    public decimal GradeReward { get; set; }
    /// <summary>
    /// 当前vip等级的最小打码量
    /// </summary>
    public decimal CurrentGradeMinBet { get; set; }
    /// <summary>
    /// 下一升级最小打码量
    /// </summary>
    public decimal NextGradeMinBet { get; set; }

    /// <summary>
		/// 每周可享收益
		/// </summary>
    public decimal WeekReward { get; set; } = 0;

    /// <summary>
    /// 升级还需要投注额
    /// </summary>
    public decimal UpgradeRequireBet { get; set; }

    /// <summary>
    /// 升级已投注
    /// </summary>
    public decimal UpgradeHasBet { get; set; }

    /// <summary>
    /// 当日可提现次数上限
    /// </summary>
    public int CashNumLimit { get; set; } = 0;

    /// <summary>
    /// 当日可用提现次数
    /// </summary>
    public int AllowCashNum { get; set; } = 0;

    /// <summary>
    /// 提现手续费
    /// </summary>
    public float Rate { get; set; }

    /// <summary>
    /// 当日提现金额上限
    /// </summary>
    public decimal CashAmountLimit { get; set; }

    /// <summary>
    /// 当日可用提现金额
    /// </summary>
    public decimal AllowCashAmount { get; set; }

    /// <summary>
    /// 运营商版本
    /// 0 - 默认版本
    /// 1 - 长线版本
    /// </summary>
    public int Version { get; set; } = 0;

}
