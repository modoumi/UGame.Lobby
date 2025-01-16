using UGame.Lobby.Service.Services;

namespace UGame.Lobby.Service.Dtos.Requests;

public class ReadMessageRequest : LobbyBaseIpo
{
    public List<string> Ids { get; set; }
}
public class DetailMessageRequest : LobbyBaseIpo
{
    public string MessageId { get; set; }
}
