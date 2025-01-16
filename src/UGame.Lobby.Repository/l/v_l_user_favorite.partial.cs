using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class V_l_user_favoritePO
    {
        #region AiUo
        public static implicit operator V_l_user_favoriteEO(V_l_user_favoritePO value)
        {
            if (value==null) return null;
            return new V_l_user_favoriteEO
            {
		        UserID = value.UserID,
		        Type = value.Type,
		        RecDate = value.RecDate,
		        PrimaryKeyID = value.PrimaryKeyID,
		        OperatorID = value.OperatorID,
		        AppID = value.AppID,
		        Flag = value.Flag,
		        SmallIcon = value.SmallIcon,
		        MiddleIcon = value.MiddleIcon,
		        BigIcon = value.BigIcon,
            };
        }
        public static implicit operator V_l_user_favoritePO(V_l_user_favoriteEO value)
        {
            if (value==null) return null;
            return new V_l_user_favoritePO
            {
		        UserID = value.UserID,
		        Type = value.Type,
		        RecDate = value.RecDate,
		        PrimaryKeyID = value.PrimaryKeyID,
		        OperatorID = value.OperatorID,
		        AppID = value.AppID,
		        Flag = value.Flag,
		        SmallIcon = value.SmallIcon,
		        MiddleIcon = value.MiddleIcon,
		        BigIcon = value.BigIcon,
            };
        }
        #endregion
    }
}