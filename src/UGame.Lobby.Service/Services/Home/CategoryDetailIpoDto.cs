using AiUo.AspNet;

namespace UGame.Lobby.Service.Services.Home
{
    /// <summary>
    /// 获取一级分类的游戏列表
    /// </summary>
    public class CategoryDetailIpo : LobbyBaseIpo
    {
        /// <summary>
        /// 一级分类Id
        /// </summary>
        [RangeEx(1, int.MaxValue, "", "CategoryID must be a positive integer greater than 0.")]
        public int CategoryID { get; set; }
    }
    public class CategoryDetailDto
    {
        /// <summary>
        /// 分类Id
        /// </summary>
        public long CategoryID { get; set; }

        /// <summary>
        /// 分类名称
        /// </summary>
        public string CategoryName { get; set; }
        /// <summary>
        /// 模板类型
        /// 1、横向平铺
        /// 2、首个大图
        /// </summary>
        public int Template { get; set; }

        /// <summary>
        /// 当前分类是否有图标
        /// </summary>
        public bool HasIcon { get; set; } = false;

        /// <summary>
        /// 分类图标
        /// </summary>
        public string Icon { get; set; } = string.Empty;

        /// <summary>
        /// 游戏列表
        /// </summary>
        public List<AppDetailDto> Apps { get; set; }
    }
}
