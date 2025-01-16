using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class Sa_signin100012_detailPO
    {
        #region AiUo
        public static implicit operator Sa_signin100012_detailEO(Sa_signin100012_detailPO value)
        {
            if (value==null) return null;
            return new Sa_signin100012_detailEO
            {
		        DayId = value.DayId,
		        UserID = value.UserID,
		        Reward = value.Reward,
		        CurrentCycleNumber = value.CurrentCycleNumber,
		        IsMissSignin = value.IsMissSignin,
		        MissSigninDate = value.MissSigninDate,
		        SigninCycleStartDate = value.SigninCycleStartDate,
		        SigninCycleEndDate = value.SigninCycleEndDate,
		        RecDate = value.RecDate,
            };
        }
        public static implicit operator Sa_signin100012_detailPO(Sa_signin100012_detailEO value)
        {
            if (value==null) return null;
            return new Sa_signin100012_detailPO
            {
		        DayId = value.DayId,
		        UserID = value.UserID,
		        Reward = value.Reward,
		        CurrentCycleNumber = value.CurrentCycleNumber,
		        IsMissSignin = value.IsMissSignin,
		        MissSigninDate = value.MissSigninDate,
		        SigninCycleStartDate = value.SigninCycleStartDate,
		        SigninCycleEndDate = value.SigninCycleEndDate,
		        RecDate = value.RecDate,
            };
        }
        #endregion
    }
}