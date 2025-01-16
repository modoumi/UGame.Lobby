using UGame.Lobby.Repository.ing;
using AiUo.Extensions.AutoMapper;

namespace UGame.Lobby.Service.Services.Home
{
    /// <summary>
    /// 查询一级游戏分类ipo
    /// </summary>
    public class CategoryListIpo : LobbyBaseIpo
    {

    }

    public class CategoryListDto : IMapFrom<L_categoryEO>,IMapFrom<L_categoryPO>
    {
        /// <summary>
        /// 一级游戏分类id
        /// </summary>
        public long CategoryId { get; set; }

        /// <summary>
        /// 一级游戏分类名称
        /// </summary>
        public string CategoryName { get; set; }

        /// <summary>
        /// 排序字段，优先级从小到大
        /// </summary>
        public int OrderNum { get; set; }

        /// <summary>
        /// 顶级分类类型
        /// </summary>
        public int TopLevelType { get; set; }

        public void MapFrom(L_categoryEO source)
        {
            this.CategoryName = source.Name;
        }

        public void MapFrom(L_categoryPO source)
        {
            this.CategoryName = source.Name;
        }
    }
}
