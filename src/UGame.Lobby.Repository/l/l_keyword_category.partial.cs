using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class L_keyword_categoryPO
    {
        #region AiUo
        public static implicit operator L_keyword_categoryEO(L_keyword_categoryPO value)
        {
            if (value==null) return null;
            return new L_keyword_categoryEO
            {
		        KCID = value.KCID,
		        KCName = value.KCName,
		        OrderNum = value.OrderNum,
		        OperatorId = value.OperatorId,
		        LangID = value.LangID,
            };
        }
        public static implicit operator L_keyword_categoryPO(L_keyword_categoryEO value)
        {
            if (value==null) return null;
            return new L_keyword_categoryPO
            {
		        KCID = value.KCID,
		        KCName = value.KCName,
		        OrderNum = value.OrderNum,
		        OperatorId = value.OperatorId,
		        LangID = value.LangID,
            };
        }
        #endregion
    }
}