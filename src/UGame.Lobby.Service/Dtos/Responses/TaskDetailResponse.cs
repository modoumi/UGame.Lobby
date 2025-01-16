namespace UGame.Lobby.Service.Dtos.Responses;

public class TaskDetailResponse
{
    public string DetailID { get; set; }
    public string UserID { get; set; }
    public int ItemID { get; set; }
    public decimal RewardAmount { get; set; }
    public string Template { get; set; }
    public int Sequence { get; set; }
    public int Status { get; set; }
}
