using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class Sc_marquee_userPO
    {
        #region AiUo
        public static implicit operator Sc_marquee_userEO(Sc_marquee_userPO value)
        {
            if (value==null) return null;
            return new Sc_marquee_userEO
            {
		        MarqueeID = value.MarqueeID,
		        UserID = value.UserID,
            };
        }
        public static implicit operator Sc_marquee_userPO(Sc_marquee_userEO value)
        {
            if (value==null) return null;
            return new Sc_marquee_userPO
            {
		        MarqueeID = value.MarqueeID,
		        UserID = value.UserID,
            };
        }
        #endregion
    }
}