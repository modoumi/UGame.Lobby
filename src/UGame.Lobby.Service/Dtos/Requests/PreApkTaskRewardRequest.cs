using UGame.Lobby.Service.Services;

namespace UGame.Lobby.Service.Dtos.Requests;

public class PreApkTaskRewardRequest : LobbyBaseIpo
{
    /// <summary>
    /// 记录Id
    /// </summary>
    public string DetailId { get; set; }

    /// <summary>
    /// 设备Id
    /// </summary>
    public string DeviceId { get; set; }
}
