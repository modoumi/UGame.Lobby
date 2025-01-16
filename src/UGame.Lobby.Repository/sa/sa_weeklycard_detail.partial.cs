using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class Sa_weeklycard_detailPO
    {
        #region AiUo
        public static implicit operator Sa_weeklycard_detailEO(Sa_weeklycard_detailPO value)
        {
            if (value==null) return null;
            return new Sa_weeklycard_detailEO
            {
		        DayId = value.DayId,
		        UserId = value.UserId,
		        WeeklyCardType = value.WeeklyCardType,
		        Bonus = value.Bonus,
		        FlowMultip = value.FlowMultip,
		        CurrentCycleNumber = value.CurrentCycleNumber,
		        CycleStartDate = value.CycleStartDate,
		        CycleEndDate = value.CycleEndDate,
		        RecDate = value.RecDate,
            };
        }
        public static implicit operator Sa_weeklycard_detailPO(Sa_weeklycard_detailEO value)
        {
            if (value==null) return null;
            return new Sa_weeklycard_detailPO
            {
		        DayId = value.DayId,
		        UserId = value.UserId,
		        WeeklyCardType = value.WeeklyCardType,
		        Bonus = value.Bonus,
		        FlowMultip = value.FlowMultip,
		        CurrentCycleNumber = value.CurrentCycleNumber,
		        CycleStartDate = value.CycleStartDate,
		        CycleEndDate = value.CycleEndDate,
		        RecDate = value.RecDate,
            };
        }
        #endregion
    }
}