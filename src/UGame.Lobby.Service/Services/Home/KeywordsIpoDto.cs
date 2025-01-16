using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.AspNet;

namespace UGame.Lobby.Service.Services.Home
{
    public class KeywordsIpo : LobbyBaseIpo
    {

    }
    public class KeywordsDto
    {
        /// <summary>
        /// 关键词分类编码
        /// </summary>
        public long KCId { get; set; }
        /// <summary>
        /// 关键词分类名称
        /// </summary>
        public string KCName { get; set; }
        /// <summary>
        /// 关键词列表
        /// </summary>
        public List<KeywordsItem> Keywords { get; set; }
    }
    public class KeywordsItem
    {
        /// <summary>
        /// 关键词编码
        /// </summary>
        public long KeywordId { get; set; }
        /// <summary>
        /// 关键词名称
        /// </summary>
        public string Title { get; set; }
    }
}
