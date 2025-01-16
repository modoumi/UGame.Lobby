using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using AiUo.AspNet;

namespace UGame.Lobby.Service.Services.Home
{

    public class CategoryFirstLevelGameIpo : LobbyBaseIpo
    {
        /// <summary>
        /// 当前页码
        /// 默认1
        /// </summary>
        [RangeEx(1, int.MaxValue, "", "PageIndex must be a positive integer greater than 0.")]
        public int PageIndex { get; set; } = 1;
        /// <summary>
        /// 页大小
        /// 默认10
        /// </summary>
        [RangeEx(1, 50, "", "PageSize must be a correct integer between 1 and 50.")]
        public int PageSize { get; set; } = 50;

        /// <summary>
        /// 一级分类编码
        /// </summary>
        [RangeEx(0,int.MaxValue,"","")]
        public int categoryId { get; set; } = 0;
    }

}
