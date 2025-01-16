using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class V_l_query_inputPO
    {
        #region AiUo
        public static implicit operator V_l_query_inputEO(V_l_query_inputPO value)
        {
            if (value==null) return null;
            return new V_l_query_inputEO
            {
		        LangID = value.LangID,
		        KeyType = value.KeyType,
		        QueryKey = value.QueryKey,
		        AppID = value.AppID,
		        OperatorID = value.OperatorID,
            };
        }
        public static implicit operator V_l_query_inputPO(V_l_query_inputEO value)
        {
            if (value==null) return null;
            return new V_l_query_inputPO
            {
		        LangID = value.LangID,
		        KeyType = value.KeyType,
		        QueryKey = value.QueryKey,
		        AppID = value.AppID,
		        OperatorID = value.OperatorID,
            };
        }
        #endregion
    }
}