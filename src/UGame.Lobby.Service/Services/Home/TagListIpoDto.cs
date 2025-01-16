using UGame.Lobby.Common.Enum;
using UGame.Lobby.Repository.ing;
using AiUo.Extensions.AutoMapper;

namespace UGame.Lobby.Service.Services.Home;

/// <summary>
/// 查询一级游戏分类ipo
/// </summary>
public class TagListIpo : LobbyBaseIpo
{
    /// <summary>
    /// 标签层级1:首页标签,2:二级页面标签,0:默认级别
    /// </summary>
    public int LevelNum { get; set; }
}

public class TagListDto : IMapFrom<L_tagPO>
{
    /// <summary>
    /// 标签编号
    /// </summary>
    public int TagCode { get; set; }

    /// <summary>
    /// 标签名称
    /// </summary>
    public string TagName { get; set; }

    /// <summary>
    /// 标签类型
    /// </summary>
    public TagTypeEnum TagType { get; set; }

    /// <summary>
    /// 当前标签是否有图标
    /// </summary>
    public bool HasIcon { get; set; } = false;

    /// <summary>
    /// 标签图标
    /// </summary>
    public string Icon { get; set; } = string.Empty;

    /// <summary>
    /// 选中标签图标
    /// </summary>
    public string SelectIcon { get; set; } = string.Empty;

    /// <summary>
    /// 等级
    /// </summary>
    public int LevelNum { get; set; }

    /// <summary>
    /// 等级排序
    /// </summary>
    public int LevelOrderNum { get; set; }

    /// <summary>
    /// 标签跳转路径
    /// </summary>
    public string TagUrl { get; set; }

    public void MapFrom(L_tagPO source)
    {
        TagName = source.Name;
        Icon = source.TagIcon;
    }
}
