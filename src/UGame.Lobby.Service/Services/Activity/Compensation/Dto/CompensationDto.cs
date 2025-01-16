namespace UGame.Lobby.Service.Services.Activity.Compensation.Dto;

public class CompensationDto
{
    /// <summary>
    /// 首日存款后损失的金额
    /// </summary>
    public decimal LoseAmount { get; set; }

    /// <summary>
    /// 首日可返还金额
    /// </summary>
    public decimal Bonus { get; set; }

    /// <summary>
    /// 领取奖励需要充值的金额
    /// </summary>
    public decimal PayAmount { get; set; }

    /// <summary>
    /// 是否可领取 0:不可领取,1:可领取, 2:已领取
    /// </summary>
    public CompensationStatus IsAllow { get; set; } = CompensationStatus.NoAllow;
}
