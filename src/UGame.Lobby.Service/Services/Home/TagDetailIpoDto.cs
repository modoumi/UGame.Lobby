namespace UGame.Lobby.Service.Services.Home;

/// <summary>
/// 获取标签游戏详情
/// </summary>
public class TagDetailIpo : LobbyBaseIpo
{
    /// <summary>
    /// 标签编号
    /// </summary>        
    public int TagCode { get; set; }
}

/// <summary>
/// 获取标签游戏详情
/// </summary>
public class TagDetailByPageIpo : LobbyBaseIpo
{
    /// <summary>
    /// 标签编号
    /// </summary>        
    public int TagCode { get; set; }

    /// <summary>
    /// 分页索引
    /// </summary>
    public int PageIndex { get; set; }

    /// <summary>
    /// 分页大小
    /// </summary>
    public int PageSize { get; set; }
}

/// <summary>
/// 
/// </summary>
public class TagDetailDto
{
    /// <summary>
    /// 标签编号
    /// </summary>
    public long TagCode { get; set; }

    /// <summary>
    /// 标签名称
    /// </summary>
    public string TagName { get; set; }

    /// <summary>
    /// 模板类型
    /// 1、横向平铺
    /// 2、首个大图
    /// </summary>
    public int Template { get; set; }

    /// <summary>
    /// 当前标签是否有图标
    /// </summary>
    public bool HasIcon { get; set; } = false;

    /// <summary>
    /// 标签图标
    /// </summary>
    public string Icon { get; set; } = string.Empty;

    /// <summary>
    /// 所有标签时,展示位置
    /// </summary>
    public int OrderNum { get; set; }

    /// <summary>
    /// 标签类型
    /// </summary>
    public int TagType { get; set; }

    /// <summary>
    /// 游戏列表
    /// </summary>
    public List<AppDetailDto> Apps { get; set; }
}

public class TagDetailByPageDto
{
    /// <summary>
    /// 总数
    /// </summary>
    public int TotalNum { get; set; }

    /// <summary>
    /// 游戏列表
    /// </summary>
    public List<AppDetailDto> Apps { get; set; }
}
