namespace UGame.Lobby.Service.Dtos.Responses;

public class VipRebateResponse
{
    public string RewardId { get; set; }
    public int ItemId { get; set; }
    public DateTime DayId { get; set; }
    public double RewardRate { get; set; }
    public string Title { get; set; }
    public string TipContent { get; set; }
    public long RewardAmount { get; set; }
    public DateTime BeginDate { get; set; }
    public DateTime EndDate { get; set; }
    public int Status { get; set; }
    public long NextRewardAmount { get; set; }
    public DateTime NextBeginDate { get; set; }
    public DateTime NextEndDate { get; set; }
}
