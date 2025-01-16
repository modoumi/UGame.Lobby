using UGame.Lobby.Repository.ing;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using AiUo.Extensions.AutoMapper;

namespace UGame.Lobby.Service.Services.Home;

public class AppDetailDto : IMapFrom<TagAppDto>, IMapFrom<V_l_category_detailPO>, IMapFrom<V_l_user_favoritePO>, IMapFrom<V_l_keyword_appPO>
{
    /// <summary>
    /// 应用图片
    /// </summary>
    [DataMember(Order = 0)]
    public string Icon { get; set; }
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
    /// 应用名称
    /// </summary>
    [DataMember(Order = 6)]
    public string AppName { get; set; }

    /// <summary>
    /// 当前用户是否收藏此应用
    /// </summary>
    [DataMember(Order = 7)]
    public bool IsFavorite { get; set; }

    /// <summary>
    /// 当前应用Jackpot奖池
    /// 如果应用无Jackpot奖池则为空或null
    /// </summary>
    [DataMember(Order = 8)]
    public string Jackpot { get; set; } = null;

    /// <summary>
    /// 是否自研游戏
    /// </summary>
    [DataMember(Order = 9)]
    public int IsOwn { get; set; }

    /// <summary>
    /// 当前游戏是否支持bonus
    /// </summary>
    [DataMember(Order = 10)]
    public bool IsSupportBonus { get; set; }

    /// <summary>
    /// s_app.Status
    /// 0无效1有效2维护
    /// </summary>
    [DataMember(Order = 11)]
    public int Status { get; set; }

    /// <summary>
    /// 游戏入口效果标识 0-无 1-有
    /// </summary>
    [DataMember(Order = 12)]
    public int EffectStatus { get; set; }

    /// <summary>
    /// 游戏列表中游戏排序
    /// </summary>
    [JsonPropertyName("orderNum")]
    [DataMember(Order = 13)]
    public int AppSequence { get; set; }

    public void MapFrom(V_l_category_detailPO source)
    {
        this.Icon = source.BigIcon;
        if (string.IsNullOrWhiteSpace(this.Icon))
            this.Icon = source.MiddleIcon;
        if (string.IsNullOrWhiteSpace(this.Icon))
            this.Icon = source.SmallIcon;
    }

    public void MapFrom(TagAppDto source)
    {
        AppSequence = source.AppSequence;
        Icon = source.BigIcon;
        if (string.IsNullOrWhiteSpace(this.Icon))
            this.Icon = source.MiddleIcon;
        if (string.IsNullOrWhiteSpace(this.Icon))
            this.Icon = source.SmallIcon;
    }

    public void MapFrom(V_l_user_favoritePO source)
    {
        this.Icon = source.BigIcon;
        if (string.IsNullOrWhiteSpace(this.Icon))
            this.Icon = source.MiddleIcon;
        if (string.IsNullOrWhiteSpace(this.Icon))
            this.Icon = source.SmallIcon;
    }

    public void MapFrom(V_l_keyword_appPO source)
    {
        this.Icon = source.BigIcon;
        if (string.IsNullOrWhiteSpace(this.Icon))
            this.Icon = source.MiddleIcon;
        if (string.IsNullOrWhiteSpace(this.Icon))
            this.Icon = source.SmallIcon;
    }
}
