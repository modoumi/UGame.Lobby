using UGame.Lobby.Repository.ing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.AspNet;
using AiUo.Extensions.AutoMapper;
using Xxyy.DAL;

namespace UGame.Lobby.Service.Services.SCommon
{
    public class SCBannerIpo : LobbyBaseIpo
    {
        /// <summary>
        /// 应用编码
        /// </summary>
        [RequiredEx("", "AppId cannot be empty.")]
        public string AppId { get; set; }
        /// <summary>
        /// 位置
        /// </summary>
        public List<int> Position { get; set; } = new List<int>();
    }
    public class SCBannerDto : IMapFrom<Sc_bannerEO>
    {
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 提示信息
        /// </summary>
        public string Tip { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 图片链接
        /// </summary>
        public string ImageUrl { get; set; }
        /// <summary>
        /// 链接类型
        /// 1-相对地址
        /// 2-绝对地址
        /// 3-游戏地址
        /// </summary>
        public int LinkType { get; set; }
        /// <summary>
        /// 链接地址
        /// </summary>
        public string LinkUrl { get; set; }
        /// <summary>
        /// 链接参数（json串，暂无示例）
        /// </summary>
        public string LinkParams { get; set; }
        /// <summary>
        /// 位置
        /// </summary>
        public int Position { get; set; }
        /// <summary>
        /// 语言编码
        /// </summary>
        public string LangID { get; set; }

        /// <summary>
        /// 10000X活动；50000XVIP
        /// </summary>
        public int Code { get; set; }

        public void MapFrom(Sc_bannerEO source)
        {
            
        }
    }
}
