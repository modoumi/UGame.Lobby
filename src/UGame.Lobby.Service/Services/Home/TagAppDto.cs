using UGame.Lobby.Repository.ing;
using System.Runtime.Serialization;

namespace UGame.Lobby.Service.Services.Home;

public class TagAppDto : L_tagPO
{

    public string OperatorId { get; set; }

    /// <summary>
    /// 应用编码
    /// </summary>
    [DataMember(Order = 1)]
    public string AppId { get; set; }

    /// <summary>
    /// 小图
    /// </summary>
    [DataMember(Order = 2)]
    public string SmallIcon { get; set; }

    /// <summary>
    /// 中图
    /// </summary>
    [DataMember(Order = 3)]
    public string MiddleIcon { get; set; }

    /// <summary>
    /// 大图
    /// </summary>
    [DataMember(Order = 4)]
    public string BigIcon { get; set; }

    /// <summary>
    /// 应用标识
    /// 0、默认
    /// 1、Hot
    /// 2、New
    /// </summary>
    [DataMember(Order = 5)]
    public int Flag { get; set; }

    /// <summary>
    /// s_app.Status
    /// 0无效1有效2维护
    /// </summary>
    [DataMember(Order = 11)]
    public int Status { get; set; }

    /// <summary>
    /// 排序
    /// </summary>
    public int AppSequence { get; set; }

}
