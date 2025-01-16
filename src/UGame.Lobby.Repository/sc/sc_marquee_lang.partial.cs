using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class Sc_marquee_langPO
    {
        #region AiUo
        public static implicit operator Sc_marquee_langEO(Sc_marquee_langPO value)
        {
            if (value==null) return null;
            return new Sc_marquee_langEO
            {
		        MarqueeID = value.MarqueeID,
		        LangID = value.LangID,
		        MessageContent = value.MessageContent,
            };
        }
        public static implicit operator Sc_marquee_langPO(Sc_marquee_langEO value)
        {
            if (value==null) return null;
            return new Sc_marquee_langPO
            {
		        MarqueeID = value.MarqueeID,
		        LangID = value.LangID,
		        MessageContent = value.MessageContent,
            };
        }
        #endregion
    }
}