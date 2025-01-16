using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class Sc_notify_user_logPO
    {
        #region AiUo
        public static implicit operator Sc_notify_user_logEO(Sc_notify_user_logPO value)
        {
            if (value==null) return null;
            return new Sc_notify_user_logEO
            {
		        NotifyID = value.NotifyID,
		        UserID = value.UserID,
		        ShowCount = value.ShowCount,
		        LastShowDate = value.LastShowDate,
            };
        }
        public static implicit operator Sc_notify_user_logPO(Sc_notify_user_logEO value)
        {
            if (value==null) return null;
            return new Sc_notify_user_logPO
            {
		        NotifyID = value.NotifyID,
		        UserID = value.UserID,
		        ShowCount = value.ShowCount,
		        LastShowDate = value.LastShowDate,
            };
        }
        #endregion
    }
}