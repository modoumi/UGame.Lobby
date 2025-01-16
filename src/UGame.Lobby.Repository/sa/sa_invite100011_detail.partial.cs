using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class Sa_invite100011_detailPO
    {
        #region AiUo
        public static implicit operator Sa_invite100011_detailEO(Sa_invite100011_detailPO value)
        {
            if (value==null) return null;
            return new Sa_invite100011_detailEO
            {
		        DetailID = value.DetailID,
		        OperatorID = value.OperatorID,
		        CountryId = value.CountryId,
		        CurrencyID = value.CurrencyID,
		        RewardType = value.RewardType,
		        PUserID = value.PUserID,
		        PUserKind = value.PUserKind,
		        Bonus = value.Bonus,
		        FlowMultip = value.FlowMultip,
		        UserID = value.UserID,
		        UserKind = value.UserKind,
		        RegistDate = value.RegistDate,
		        FirstPayAmount = value.FirstPayAmount,
		        RecDate = value.RecDate,
		        ValidUserCount = value.ValidUserCount,
		        MonthDate = value.MonthDate,
		        OrderID = value.OrderID,
		        ReceiveStatus = value.ReceiveStatus,
            };
        }
        public static implicit operator Sa_invite100011_detailPO(Sa_invite100011_detailEO value)
        {
            if (value==null) return null;
            return new Sa_invite100011_detailPO
            {
		        DetailID = value.DetailID,
		        OperatorID = value.OperatorID,
		        CountryId = value.CountryId,
		        CurrencyID = value.CurrencyID,
		        RewardType = value.RewardType,
		        PUserID = value.PUserID,
		        PUserKind = value.PUserKind,
		        Bonus = value.Bonus,
		        FlowMultip = value.FlowMultip,
		        UserID = value.UserID,
		        UserKind = value.UserKind,
		        RegistDate = value.RegistDate,
		        FirstPayAmount = value.FirstPayAmount,
		        RecDate = value.RecDate,
		        ValidUserCount = value.ValidUserCount,
		        MonthDate = value.MonthDate,
		        OrderID = value.OrderID,
		        ReceiveStatus = value.ReceiveStatus,
            };
        }
        #endregion
    }
}