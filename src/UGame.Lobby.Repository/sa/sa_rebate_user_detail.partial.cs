using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class Sa_rebate_user_detailPO
    {
        #region AiUo
        public static implicit operator Sa_rebate_user_detailEO(Sa_rebate_user_detailPO value)
        {
            if (value==null) return null;
            return new Sa_rebate_user_detailEO
            {
		        DetailID = value.DetailID,
		        UserID = value.UserID,
		        DayID = value.DayID,
		        OperatorID = value.OperatorID,
		        CurrencyID = value.CurrencyID,
		        ActivityID = value.ActivityID,
		        FromMode = value.FromMode,
		        FromId = value.FromId,
		        UserKind = value.UserKind,
		        CountryID = value.CountryID,
		        RebateType = value.RebateType,
		        RebateAmount = value.RebateAmount,
		        FlowMultip = value.FlowMultip,
		        Level = value.Level,
		        NotifyStatus = value.NotifyStatus,
		        ReceiveStatus = value.ReceiveStatus,
		        RecDate = value.RecDate,
		        UpdateTime = value.UpdateTime,
		        RewardType = value.RewardType,
            };
        }
        public static implicit operator Sa_rebate_user_detailPO(Sa_rebate_user_detailEO value)
        {
            if (value==null) return null;
            return new Sa_rebate_user_detailPO
            {
		        DetailID = value.DetailID,
		        UserID = value.UserID,
		        DayID = value.DayID,
		        OperatorID = value.OperatorID,
		        CurrencyID = value.CurrencyID,
		        ActivityID = value.ActivityID,
		        FromMode = value.FromMode,
		        FromId = value.FromId,
		        UserKind = value.UserKind,
		        CountryID = value.CountryID,
		        RebateType = value.RebateType,
		        RebateAmount = value.RebateAmount,
		        FlowMultip = value.FlowMultip,
		        Level = value.Level,
		        NotifyStatus = value.NotifyStatus,
		        ReceiveStatus = value.ReceiveStatus,
		        RecDate = value.RecDate,
		        UpdateTime = value.UpdateTime,
		        RewardType = value.RewardType,
            };
        }
        #endregion
    }
}