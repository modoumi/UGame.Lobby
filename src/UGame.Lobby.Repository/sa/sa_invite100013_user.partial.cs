using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class Sa_invite100013_userPO
    {
        #region AiUo
        public static implicit operator Sa_invite100013_userEO(Sa_invite100013_userPO value)
        {
            if (value==null) return null;
            return new Sa_invite100013_userEO
            {
		        PUserID = value.PUserID,
		        POperatorId = value.POperatorId,
		        UserID = value.UserID,
		        UOperatorId = value.UOperatorId,
		        IsMeetPayLimit = value.IsMeetPayLimit,
		        UserTotalPay = value.UserTotalPay,
		        IsMeetBetLimit = value.IsMeetBetLimit,
		        UserTotalBet = value.UserTotalBet,
		        RecDate = value.RecDate,
		        UpdateTime = value.UpdateTime,
            };
        }
        public static implicit operator Sa_invite100013_userPO(Sa_invite100013_userEO value)
        {
            if (value==null) return null;
            return new Sa_invite100013_userPO
            {
		        PUserID = value.PUserID,
		        POperatorId = value.POperatorId,
		        UserID = value.UserID,
		        UOperatorId = value.UOperatorId,
		        IsMeetPayLimit = value.IsMeetPayLimit,
		        UserTotalPay = value.UserTotalPay,
		        IsMeetBetLimit = value.IsMeetBetLimit,
		        UserTotalBet = value.UserTotalBet,
		        RecDate = value.RecDate,
		        UpdateTime = value.UpdateTime,
            };
        }
        #endregion
    }
}