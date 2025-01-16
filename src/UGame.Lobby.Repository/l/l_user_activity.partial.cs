using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class L_user_activityPO
    {
        #region AiUo
        public static implicit operator L_user_activityEO(L_user_activityPO value)
        {
            if (value==null) return null;
            return new L_user_activityEO
            {
		        UserID = value.UserID,
		        CountryID = value.CountryID,
		        CurrencyID = value.CurrencyID,
		        OperatorID = value.OperatorID,
		        UserKind = value.UserKind,
		        ActivityId = value.ActivityId,
		        ActivityName = value.ActivityName,
		        IsInvolved = value.IsInvolved,
		        IsEnd = value.IsEnd,
		        RecDate = value.RecDate,
		        UpdateTime = value.UpdateTime,
            };
        }
        public static implicit operator L_user_activityPO(L_user_activityEO value)
        {
            if (value==null) return null;
            return new L_user_activityPO
            {
		        UserID = value.UserID,
		        CountryID = value.CountryID,
		        CurrencyID = value.CurrencyID,
		        OperatorID = value.OperatorID,
		        UserKind = value.UserKind,
		        ActivityId = value.ActivityId,
		        ActivityName = value.ActivityName,
		        IsInvolved = value.IsInvolved,
		        IsEnd = value.IsEnd,
		        RecDate = value.RecDate,
		        UpdateTime = value.UpdateTime,
            };
        }
        #endregion
    }
}