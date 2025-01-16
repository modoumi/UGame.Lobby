namespace UGame.Lobby.Service.Services.Activity.Rebate
{
    public class TakeRebateIpo : LobbyBaseIpo
    {
        public string DetailID { get; set; }

    }
    public class TakeRebateDto
    {
        public object data { get; set; }
        public bool success { get; set; }
        public string message { get; set; }
    }
}
