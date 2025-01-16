using UGame.Lobby.Service.Services;

namespace UGame.Lobby.Service.Dtos.Requests;

public class DeleteMessageRequest : LobbyBaseIpo
{
    public List<string> Ids { get; set; }
}
