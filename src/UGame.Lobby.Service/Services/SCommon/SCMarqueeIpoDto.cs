using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.AspNet;

namespace UGame.Lobby.Service.Services.SCommon
{
    public class SCMarqueeIpo : LobbyBaseIpo
    {
        /// <summary>
        /// 应用编码
        /// </summary>
        [RequiredEx("", "AppId不能为空")]
        public string AppId { get; set; }
        /// <summary>
        /// 位置
        /// </summary>
        public int Position { get; set; }

        /// <summary>
        /// 轮播类型，0:文字，1:图片
        /// </summary>
        public int MarqueeType { get; set; }
    }

    public class SCMarqueeDto
    {
        public string MessageContent { get; set; }

        public string AppId { get; set; }

        public string AppName { get; set; }

        public string AppIcon { get; set; }

        public bool IsSupportBonus { get; set; }

        public decimal WinAmount { get; set; }

        public string UserNameOrMobile { get; set; }

        //public int Status { get; set; }
    }
}
