using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.AspNet;

namespace UGame.Lobby.Service.Services.ActivityEngine
{
    public class ActivityEngineContext
    {

        public ActivityEngineContext(LobbyBaseIpo ipo)
        {
            this.UserId = ipo.UserId;
            this.OperatorId = ipo.OperatorId;
            this.CountryId = ipo.CountryId;
            this.CurrencyId = ipo.CurrencyId;
            this.LangId = ipo.LangId;
        }

        /// <summary>
        /// 用户编码
        /// </summary>
        public string UserId { get; set; }
        /// <summary>
        /// 运营商编码
        /// </summary>
        public string OperatorId { get; set; }
        /// <summary>
        /// 国家编码
        /// </summary>
        public string CountryId { get; set; }
        /// <summary>
        /// 货币编码
        /// </summary>
        public string CurrencyId { get; set; }
        /// <summary>
        /// 语言编码
        /// </summary>
        public string LangId { get; set; }

    }
}
