namespace UGame.Lobby.Service.Services.Init;

public class BalanceDto
{

    /// <summary>
    /// bonus余额
    /// </summary>
    public decimal Bonus { get; set; }

    /// <summary>
    /// 真金余额（s_user.Cash + s_user.Bonus）
    /// </summary>
    public decimal Cash { get; set; }

    /// <summary>
    /// 可提现金额
    /// </summary>
    public decimal WithDrawM { get; set; }

    public decimal OrderM { get; set; }

    /// <summary>
    /// 提现需要完成的流水
    /// </summary>
    public decimal RequireFlowMoney { get; set; }

    /// <summary>
    /// 最大提现金额
    /// </summary>
    public AmountLimit CashLimit { get; set; } = new AmountLimit();

    /// <summary>
    /// 充值提现金额限制
    /// </summary>
    public AmountLimit PayLimit { get; set; } = new AmountLimit();

    /// <summary>
    /// 是否启用bonus（用户是否有bonus账户）
    /// </summary>
    public bool EnableBonus { get; set; }
}

public class AmountLimit
{ 
    public decimal MinAmount { get; set; }

    public decimal MaxAmount { get; set; }
}
