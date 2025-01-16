using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using AiUo.AspNet;

namespace UGame.Lobby.Service.Services.Home
{
    public class CategoryMyGameIpo : LobbyBaseIpo
    {
        /// <summary>
        /// 当前页码
        /// 默认1
        /// </summary>
        [RangeEx(1, int.MaxValue, "", "PageIndex must be a positive integer greater than 0.")]
        public int PageIndex { get; set; } = 1;
        /// <summary>
        /// 页大小
        /// 默认5
        /// </summary>
        [RangeEx(1, 50, "", "PageSize must be a correct integer between 1 and 50.")]
        public int PageSize { get; set; } = 10;

        /// <summary>
        /// 后端使用，前端不需要传
        /// </summary>
        [JsonIgnore]
        public int MyGameRandomAppNumber { get; set; }
    }
}
