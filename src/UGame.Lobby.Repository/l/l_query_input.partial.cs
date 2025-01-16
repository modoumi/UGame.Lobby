using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class L_query_inputPO
    {
        #region AiUo
        public static implicit operator L_query_inputEO(L_query_inputPO value)
        {
            if (value==null) return null;
            return new L_query_inputEO
            {
		        QueryID = value.QueryID,
		        LangID = value.LangID,
		        KeyType = value.KeyType,
		        QueryKey = value.QueryKey,
		        AppID = value.AppID,
            };
        }
        public static implicit operator L_query_inputPO(L_query_inputEO value)
        {
            if (value==null) return null;
            return new L_query_inputPO
            {
		        QueryID = value.QueryID,
		        LangID = value.LangID,
		        KeyType = value.KeyType,
		        QueryKey = value.QueryKey,
		        AppID = value.AppID,
            };
        }
        #endregion
    }
}