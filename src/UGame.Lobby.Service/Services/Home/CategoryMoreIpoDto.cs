using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using AiUo.AspNet;

namespace UGame.Lobby.Service.Services.Home
{
    public class CategoryMoreIpo : LobbyBaseIpo
    {
        /// <summary>
        /// 分类Id
        /// </summary>
        public int CategoryID { get; set; }
        /// <summary>
        /// 当前页码
        /// 默认1
        /// </summary>
        [RangeEx(1,int.MaxValue,"", "PageIndex must be a positive integer greater than 0.")]
        public int PageIndex { get; set; } = 1;
        /// <summary>
        /// 页大小
        /// 默认5
        /// </summary>
        [RangeEx(1,50,"", "PageSize must be a correct integer between 1 and 50.")]
        public int PageSize { get; set; } = 10;
    }
    public class CategoryMoreDto : AppDetailDto
    {

    }

}
