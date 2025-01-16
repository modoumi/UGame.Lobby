using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class L_category_appPO
    {
        #region AiUo
        public static implicit operator L_category_appEO(L_category_appPO value)
        {
            if (value==null) return null;
            return new L_category_appEO
            {
		        CategoryID = value.CategoryID,
		        AppID = value.AppID,
		        OrderNum = value.OrderNum,
		        ParentId = value.ParentId,
            };
        }
        public static implicit operator L_category_appPO(L_category_appEO value)
        {
            if (value==null) return null;
            return new L_category_appPO
            {
		        CategoryID = value.CategoryID,
		        AppID = value.AppID,
		        OrderNum = value.OrderNum,
		        ParentId = value.ParentId,
            };
        }
        #endregion
    }
}