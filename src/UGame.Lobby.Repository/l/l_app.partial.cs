using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class L_appPO
    {
        #region AiUo
        public static implicit operator L_appEO(L_appPO value)
        {
            if (value==null) return null;
            return new L_appEO
            {
		        PrimaryKeyID = value.PrimaryKeyID,
		        OperatorID = value.OperatorID,
		        AppID = value.AppID,
		        Flag = value.Flag,
		        SmallIcon = value.SmallIcon,
		        MiddleIcon = value.MiddleIcon,
		        BigIcon = value.BigIcon,
		        RouletteIcon = value.RouletteIcon,
		        MarqueeStatus = value.MarqueeStatus,
		        MarqueeIcon = value.MarqueeIcon,
            };
        }
        public static implicit operator L_appPO(L_appEO value)
        {
            if (value==null) return null;
            return new L_appPO
            {
		        PrimaryKeyID = value.PrimaryKeyID,
		        OperatorID = value.OperatorID,
		        AppID = value.AppID,
		        Flag = value.Flag,
		        SmallIcon = value.SmallIcon,
		        MiddleIcon = value.MiddleIcon,
		        BigIcon = value.BigIcon,
		        RouletteIcon = value.RouletteIcon,
		        MarqueeStatus = value.MarqueeStatus,
		        MarqueeIcon = value.MarqueeIcon,
            };
        }
        #endregion
    }
}