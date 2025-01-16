namespace UGame.Lobby.Service.Services.Vip
{

    public class VipReceiveIpo : LobbyBaseIpo
    {
        public int VipGrade { get; set; }
    }

    public class VipReceiveDto
    {
        public bool Status { get; set; } = false;

        public decimal Bonus { get; set; }
    }
    public class VipRebateRewardIpo : LobbyBaseIpo
    {
        public string RewardId { get; set; }
    }
}
