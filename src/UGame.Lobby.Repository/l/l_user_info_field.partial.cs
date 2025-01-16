using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class L_user_info_fieldPO
    {
        #region AiUo
        public static implicit operator L_user_info_fieldEO(L_user_info_fieldPO value)
        {
            if (value==null) return null;
            return new L_user_info_fieldEO
            {
		        UIFieldID = value.UIFieldID,
		        Name = value.Name,
            };
        }
        public static implicit operator L_user_info_fieldPO(L_user_info_fieldEO value)
        {
            if (value==null) return null;
            return new L_user_info_fieldPO
            {
		        UIFieldID = value.UIFieldID,
		        Name = value.Name,
            };
        }
        #endregion
    }
}