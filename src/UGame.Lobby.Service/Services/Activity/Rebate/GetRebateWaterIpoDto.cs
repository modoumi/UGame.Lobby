namespace UGame.Lobby.Service.Services.Activity.Rebate;

public class RebateWaterRequest : LobbyBaseIpo
{
    /// <summary>
    /// 统计时间，UTC格式
    /// </summary>
    public DateTime? RebateDateUtc { get; set; }
    /// <summary>
    /// 频度，0:未知，1:每日，2:每周，3:每月
    /// </summary>
    public int Frequency { get; set; }
}

public class RebateWaterResponse
{
    public decimal TotalBetAmount { get; set; }
    public decimal RebateAmount { get; set; }
    public DateTime RewardTime { get; set; }
    public string SearchKey { get; set; }
}
