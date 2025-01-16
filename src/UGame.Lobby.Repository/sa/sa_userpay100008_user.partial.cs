using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class Sa_userpay100008_userPO
    {
        #region AiUo
        public static implicit operator Sa_userpay100008_userEO(Sa_userpay100008_userPO value)
        {
            if (value==null) return null;
            return new Sa_userpay100008_userEO
            {
		        UserID = value.UserID,
		        OperatorID = value.OperatorID,
		        CountryId = value.CountryId,
		        CurrencyID = value.CurrencyID,
		        OrderID = value.OrderID,
		        Bonus = value.Bonus,
		        FlowMultip = value.FlowMultip,
		        UserKind = value.UserKind,
		        FromMode = value.FromMode,
		        FromId = value.FromId,
		        DayId = value.DayId,
		        RecDate = value.RecDate,
            };
        }
        public static implicit operator Sa_userpay100008_userPO(Sa_userpay100008_userEO value)
        {
            if (value==null) return null;
            return new Sa_userpay100008_userPO
            {
		        UserID = value.UserID,
		        OperatorID = value.OperatorID,
		        CountryId = value.CountryId,
		        CurrencyID = value.CurrencyID,
		        OrderID = value.OrderID,
		        Bonus = value.Bonus,
		        FlowMultip = value.FlowMultip,
		        UserKind = value.UserKind,
		        FromMode = value.FromMode,
		        FromId = value.FromId,
		        DayId = value.DayId,
		        RecDate = value.RecDate,
            };
        }
        #endregion
    }
}