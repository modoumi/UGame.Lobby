using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class L_keywordPO
    {
        #region AiUo
        public static implicit operator L_keywordEO(L_keywordPO value)
        {
            if (value==null) return null;
            return new L_keywordEO
            {
		        KeywordID = value.KeywordID,
		        OperatorID = value.OperatorID,
		        LangID = value.LangID,
		        Title = value.Title,
		        OrderNum = value.OrderNum,
		        KCID = value.KCID,
		        Status = value.Status,
		        RecDate = value.RecDate,
            };
        }
        public static implicit operator L_keywordPO(L_keywordEO value)
        {
            if (value==null) return null;
            return new L_keywordPO
            {
		        KeywordID = value.KeywordID,
		        OperatorID = value.OperatorID,
		        LangID = value.LangID,
		        Title = value.Title,
		        OrderNum = value.OrderNum,
		        KCID = value.KCID,
		        Status = value.Status,
		        RecDate = value.RecDate,
            };
        }
        #endregion
    }
}