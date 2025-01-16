using UGame.Lobby.Service.Services;

namespace UGame.Lobby.Service.Dtos.Requests;

public class LastMessageRequest : LobbyBaseIpo
{
    /// <summary>
    /// 页码，默认20
    /// </summary>
    public int PageSize { get; } = 20;
    /// <summary>
    /// 分页，第一页以1开始
    /// </summary>
    public int PageIndex { get; set; }
    /// <summary>
    /// 邮件类型0系统消息1最新动态2奖励邮件3私信
    /// </summary>
    public int Type { get; set; }
}