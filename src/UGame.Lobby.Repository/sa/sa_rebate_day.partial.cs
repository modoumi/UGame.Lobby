using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class Sa_rebate_dayPO
    {
        #region AiUo
        public static implicit operator Sa_rebate_dayEO(Sa_rebate_dayPO value)
        {
            if (value==null) return null;
            return new Sa_rebate_dayEO
            {
		        DayID = value.DayID,
		        UserID = value.UserID,
		        ActivityID = value.ActivityID,
		        OperatorID = value.OperatorID,
		        CurrencyID = value.CurrencyID,
		        FromMode = value.FromMode,
		        FromId = value.FromId,
		        UserKind = value.UserKind,
		        CountryID = value.CountryID,
		        TotalBetAmount = value.TotalBetAmount,
		        TotalBetBonus = value.TotalBetBonus,
		        EffectiveBetAmount = value.EffectiveBetAmount,
		        TotalWinAmount = value.TotalWinAmount,
		        TotalWinBonus = value.TotalWinBonus,
		        RecDate = value.RecDate,
		        UpdateTime = value.UpdateTime,
            };
        }
        public static implicit operator Sa_rebate_dayPO(Sa_rebate_dayEO value)
        {
            if (value==null) return null;
            return new Sa_rebate_dayPO
            {
		        DayID = value.DayID,
		        UserID = value.UserID,
		        ActivityID = value.ActivityID,
		        OperatorID = value.OperatorID,
		        CurrencyID = value.CurrencyID,
		        FromMode = value.FromMode,
		        FromId = value.FromId,
		        UserKind = value.UserKind,
		        CountryID = value.CountryID,
		        TotalBetAmount = value.TotalBetAmount,
		        TotalBetBonus = value.TotalBetBonus,
		        EffectiveBetAmount = value.EffectiveBetAmount,
		        TotalWinAmount = value.TotalWinAmount,
		        TotalWinBonus = value.TotalWinBonus,
		        RecDate = value.RecDate,
		        UpdateTime = value.UpdateTime,
            };
        }
        #endregion
    }
}