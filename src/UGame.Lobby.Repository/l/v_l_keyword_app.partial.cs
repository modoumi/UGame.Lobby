using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class V_l_keyword_appPO
    {
        #region AiUo
        public static implicit operator V_l_keyword_appEO(V_l_keyword_appPO value)
        {
            if (value==null) return null;
            return new V_l_keyword_appEO
            {
		        KeywordID = value.KeywordID,
		        PrimaryKeyID = value.PrimaryKeyID,
		        OperatorID = value.OperatorID,
		        AppID = value.AppID,
		        Flag = value.Flag,
		        SmallIcon = value.SmallIcon,
		        MiddleIcon = value.MiddleIcon,
		        BigIcon = value.BigIcon,
            };
        }
        public static implicit operator V_l_keyword_appPO(V_l_keyword_appEO value)
        {
            if (value==null) return null;
            return new V_l_keyword_appPO
            {
		        KeywordID = value.KeywordID,
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