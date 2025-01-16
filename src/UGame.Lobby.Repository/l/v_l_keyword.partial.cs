using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class V_l_keywordPO
    {
        #region AiUo
        public static implicit operator V_l_keywordEO(V_l_keywordPO value)
        {
            if (value==null) return null;
            return new V_l_keywordEO
            {
		        KeywordID = value.KeywordID,
		        OperatorID = value.OperatorID,
		        LangID = value.LangID,
		        Title = value.Title,
		        OrderNum = value.OrderNum,
		        KCID = value.KCID,
		        Status = value.Status,
		        RecDate = value.RecDate,
		        KCName = value.KCName,
		        KCOrderNum = value.KCOrderNum,
            };
        }
        public static implicit operator V_l_keywordPO(V_l_keywordEO value)
        {
            if (value==null) return null;
            return new V_l_keywordPO
            {
		        KeywordID = value.KeywordID,
		        OperatorID = value.OperatorID,
		        LangID = value.LangID,
		        Title = value.Title,
		        OrderNum = value.OrderNum,
		        KCID = value.KCID,
		        Status = value.Status,
		        RecDate = value.RecDate,
		        KCName = value.KCName,
		        KCOrderNum = value.KCOrderNum,
            };
        }
        #endregion
    }
}