using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class L_keyword_appPO
    {
        #region AiUo
        public static implicit operator L_keyword_appEO(L_keyword_appPO value)
        {
            if (value==null) return null;
            return new L_keyword_appEO
            {
		        KeywordID = value.KeywordID,
		        AppID = value.AppID,
            };
        }
        public static implicit operator L_keyword_appPO(L_keyword_appEO value)
        {
            if (value==null) return null;
            return new L_keyword_appPO
            {
		        KeywordID = value.KeywordID,
		        AppID = value.AppID,
            };
        }
        #endregion
    }
}