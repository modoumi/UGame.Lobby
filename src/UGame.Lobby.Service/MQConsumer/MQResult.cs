namespace UGame.Lobby.Service.MQConsumer;

public class MQResult
{
    public bool Success { get; set; } = false;

    public string Message { get; set; } = string.Empty;
}
