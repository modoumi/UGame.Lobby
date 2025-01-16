using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class Sc_notify_userPO
    {
        #region AiUo
        public static implicit operator Sc_notify_userEO(Sc_notify_userPO value)
        {
            if (value==null) return null;
            return new Sc_notify_userEO
            {
		        NotifyID = value.NotifyID,
		        UserID = value.UserID,
            };
        }
        public static implicit operator Sc_notify_userPO(Sc_notify_userEO value)
        {
            if (value==null) return null;
            return new Sc_notify_userPO
            {
		        NotifyID = value.NotifyID,
		        UserID = value.UserID,
            };
        }
        #endregion
    }
}