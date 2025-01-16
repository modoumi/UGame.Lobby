using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class Sa_weeklycard_userPO
    {
        #region AiUo
        public static implicit operator Sa_weeklycard_userEO(Sa_weeklycard_userPO value)
        {
            if (value==null) return null;
            return new Sa_weeklycard_userEO
            {
		        UserId = value.UserId,
		        OperatorID = value.OperatorID,
		        CurrencyID = value.CurrencyID,
		        WeeklyCardType = value.WeeklyCardType,
		        FromId = value.FromId,
		        FromMode = value.FromMode,
		        PayAmount = value.PayAmount,
		        FlowMultip = value.FlowMultip,
		        CycleStartDate = value.CycleStartDate,
		        CycleEndDate = value.CycleEndDate,
		        CountDownStart = value.CountDownStart,
		        IsBuyWeeklyCard = value.IsBuyWeeklyCard,
		        RecDate = value.RecDate,
            };
        }
        public static implicit operator Sa_weeklycard_userPO(Sa_weeklycard_userEO value)
        {
            if (value==null) return null;
            return new Sa_weeklycard_userPO
            {
		        UserId = value.UserId,
		        OperatorID = value.OperatorID,
		        CurrencyID = value.CurrencyID,
		        WeeklyCardType = value.WeeklyCardType,
		        FromId = value.FromId,
		        FromMode = value.FromMode,
		        PayAmount = value.PayAmount,
		        FlowMultip = value.FlowMultip,
		        CycleStartDate = value.CycleStartDate,
		        CycleEndDate = value.CycleEndDate,
		        CountDownStart = value.CountDownStart,
		        IsBuyWeeklyCard = value.IsBuyWeeklyCard,
		        RecDate = value.RecDate,
            };
        }
        #endregion
    }
}