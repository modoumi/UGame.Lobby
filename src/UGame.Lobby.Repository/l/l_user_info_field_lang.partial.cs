using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class L_user_info_field_langPO
    {
        #region AiUo
        public static implicit operator L_user_info_field_langEO(L_user_info_field_langPO value)
        {
            if (value==null) return null;
            return new L_user_info_field_langEO
            {
		        UIFieldID = value.UIFieldID,
		        CountryID = value.CountryID,
		        LangID = value.LangID,
		        Title = value.Title,
		        Placeholder = value.Placeholder,
		        ErrorMessage = value.ErrorMessage,
		        IsRequired = value.IsRequired,
		        IsAllowModify = value.IsAllowModify,
		        OrderNum = value.OrderNum,
		        DBType = value.DBType,
		        RecDate = value.RecDate,
            };
        }
        public static implicit operator L_user_info_field_langPO(L_user_info_field_langEO value)
        {
            if (value==null) return null;
            return new L_user_info_field_langPO
            {
		        UIFieldID = value.UIFieldID,
		        CountryID = value.CountryID,
		        LangID = value.LangID,
		        Title = value.Title,
		        Placeholder = value.Placeholder,
		        ErrorMessage = value.ErrorMessage,
		        IsRequired = value.IsRequired,
		        IsAllowModify = value.IsAllowModify,
		        OrderNum = value.OrderNum,
		        DBType = value.DBType,
		        RecDate = value.RecDate,
            };
        }
        #endregion
    }
}