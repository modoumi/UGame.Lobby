using UGame.Lobby.Service.Services;

namespace UGame.Lobby.Service.Dtos.Requests;

public class ReceiveTaskRewardRequest: LobbyBaseIpo
{
    public string DetailId { get; set; }
}
