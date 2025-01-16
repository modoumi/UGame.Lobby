using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class V_l_category_detailPO
    {
        #region AiUo
        public static implicit operator V_l_category_detailEO(V_l_category_detailPO value)
        {
            if (value==null) return null;
            return new V_l_category_detailEO
            {
		        ParentId = value.ParentId,
		        OperatorID = value.OperatorID,
		        CategoryOrderNum = value.CategoryOrderNum,
		        Template = value.Template,
		        CategoryIcon = value.CategoryIcon,
		        LangID = value.LangID,
		        AppOrderNum = value.AppOrderNum,
		        CategoryID = value.CategoryID,
		        CategoryName = value.CategoryName,
		        AppID = value.AppID,
		        Flag = value.Flag,
		        SmallIcon = value.SmallIcon,
		        MiddleIcon = value.MiddleIcon,
		        BigIcon = value.BigIcon,
            };
        }
        public static implicit operator V_l_category_detailPO(V_l_category_detailEO value)
        {
            if (value==null) return null;
            return new V_l_category_detailPO
            {
		        ParentId = value.ParentId,
		        OperatorID = value.OperatorID,
		        CategoryOrderNum = value.CategoryOrderNum,
		        Template = value.Template,
		        CategoryIcon = value.CategoryIcon,
		        LangID = value.LangID,
		        AppOrderNum = value.AppOrderNum,
		        CategoryID = value.CategoryID,
		        CategoryName = value.CategoryName,
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