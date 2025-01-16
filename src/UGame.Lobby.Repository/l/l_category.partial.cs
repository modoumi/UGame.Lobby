using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class L_categoryPO
    {
        #region AiUo
        public static implicit operator L_categoryEO(L_categoryPO value)
        {
            if (value==null) return null;
            return new L_categoryEO
            {
		        CategoryID = value.CategoryID,
		        OperatorID = value.OperatorID,
		        LangID = value.LangID,
		        Name = value.Name,
		        OrderNum = value.OrderNum,
		        LevelNum = value.LevelNum,
		        ParentId = value.ParentId,
		        Template = value.Template,
		        CategoryIcon = value.CategoryIcon,
		        RecDate = value.RecDate,
		        TopLevelType = value.TopLevelType,
            };
        }
        public static implicit operator L_categoryPO(L_categoryEO value)
        {
            if (value==null) return null;
            return new L_categoryPO
            {
		        CategoryID = value.CategoryID,
		        OperatorID = value.OperatorID,
		        LangID = value.LangID,
		        Name = value.Name,
		        OrderNum = value.OrderNum,
		        LevelNum = value.LevelNum,
		        ParentId = value.ParentId,
		        Template = value.Template,
		        CategoryIcon = value.CategoryIcon,
		        RecDate = value.RecDate,
		        TopLevelType = value.TopLevelType,
            };
        }
        #endregion
    }
}