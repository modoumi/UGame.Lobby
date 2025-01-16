using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class L_user_favoritePO
    {
        #region AiUo
        public static implicit operator L_user_favoriteEO(L_user_favoritePO value)
        {
            if (value==null) return null;
            return new L_user_favoriteEO
            {
		        UserID = value.UserID,
		        AppID = value.AppID,
		        Type = value.Type,
		        RecDate = value.RecDate,
            };
        }
        public static implicit operator L_user_favoritePO(L_user_favoriteEO value)
        {
            if (value==null) return null;
            return new L_user_favoritePO
            {
		        UserID = value.UserID,
		        AppID = value.AppID,
		        Type = value.Type,
		        RecDate = value.RecDate,
            };
        }
        #endregion
    }
}