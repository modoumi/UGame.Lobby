using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class Sc_user_appPO
    {
        #region AiUo
        public static implicit operator Sc_user_appEO(Sc_user_appPO value)
        {
            if (value==null) return null;
            return new Sc_user_appEO
            {
		        UserID = value.UserID,
		        AppID = value.AppID,
		        GuideNum = value.GuideNum,
		        UserAppStatus = value.UserAppStatus,
		        LastLoginDate = value.LastLoginDate,
            };
        }
        public static implicit operator Sc_user_appPO(Sc_user_appEO value)
        {
            if (value==null) return null;
            return new Sc_user_appPO
            {
		        UserID = value.UserID,
		        AppID = value.AppID,
		        GuideNum = value.GuideNum,
		        UserAppStatus = value.UserAppStatus,
		        LastLoginDate = value.LastLoginDate,
            };
        }
        #endregion
    }
}