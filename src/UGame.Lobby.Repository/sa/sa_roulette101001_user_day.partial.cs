using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class Sa_roulette101001_user_dayPO
    {
        #region AiUo
        public static implicit operator Sa_roulette101001_user_dayEO(Sa_roulette101001_user_dayPO value)
        {
            if (value==null) return null;
            return new Sa_roulette101001_user_dayEO
            {
		        UserID = value.UserID,
		        DayId = value.DayId,
		        TotalPayAmount = value.TotalPayAmount,
		        SumSendNum = value.SumSendNum,
		        RecDate = value.RecDate,
            };
        }
        public static implicit operator Sa_roulette101001_user_dayPO(Sa_roulette101001_user_dayEO value)
        {
            if (value==null) return null;
            return new Sa_roulette101001_user_dayPO
            {
		        UserID = value.UserID,
		        DayId = value.DayId,
		        TotalPayAmount = value.TotalPayAmount,
		        SumSendNum = value.SumSendNum,
		        RecDate = value.RecDate,
            };
        }
        #endregion
    }
}