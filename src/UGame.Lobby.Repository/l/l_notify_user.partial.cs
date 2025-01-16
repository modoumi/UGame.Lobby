using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class L_notify_userPO
    {
        #region AiUo
        public static implicit operator L_notify_userEO(L_notify_userPO value)
        {
            if (value==null) return null;
            return new L_notify_userEO
            {
		        NotifyID = value.NotifyID,
		        UserID = value.UserID,
            };
        }
        public static implicit operator L_notify_userPO(L_notify_userEO value)
        {
            if (value==null) return null;
            return new L_notify_userPO
            {
		        NotifyID = value.NotifyID,
		        UserID = value.UserID,
            };
        }
        #endregion
    }
}