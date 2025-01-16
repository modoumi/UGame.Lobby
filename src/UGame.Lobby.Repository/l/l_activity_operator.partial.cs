using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class L_activity_operatorPO
    {
        #region AiUo
        public static implicit operator L_activity_operatorEO(L_activity_operatorPO value)
        {
            if (value==null) return null;
            return new L_activity_operatorEO
            {
		        ActivityID = value.ActivityID,
		        OperatorID = value.OperatorID,
		        CurrencyID = value.CurrencyID,
		        CountryID = value.CountryID,
		        BeginDate = value.BeginDate,
		        EndDate = value.EndDate,
		        OrderNum = value.OrderNum,
		        Status = value.Status,
		        IsSendNotify = value.IsSendNotify,
		        IsSendNotifyEmail = value.IsSendNotifyEmail,
		        IsAllowEnd = value.IsAllowEnd,
		        IsAllowIndexRecommend = value.IsAllowIndexRecommend,
		        IsAllowPayRecommend = value.IsAllowPayRecommend,
		        IsBonus = value.IsBonus,
            };
        }
        public static implicit operator L_activity_operatorPO(L_activity_operatorEO value)
        {
            if (value==null) return null;
            return new L_activity_operatorPO
            {
		        ActivityID = value.ActivityID,
		        OperatorID = value.OperatorID,
		        CurrencyID = value.CurrencyID,
		        CountryID = value.CountryID,
		        BeginDate = value.BeginDate,
		        EndDate = value.EndDate,
		        OrderNum = value.OrderNum,
		        Status = value.Status,
		        IsSendNotify = value.IsSendNotify,
		        IsSendNotifyEmail = value.IsSendNotifyEmail,
		        IsAllowEnd = value.IsAllowEnd,
		        IsAllowIndexRecommend = value.IsAllowIndexRecommend,
		        IsAllowPayRecommend = value.IsAllowPayRecommend,
		        IsBonus = value.IsBonus,
            };
        }
        #endregion
    }
}