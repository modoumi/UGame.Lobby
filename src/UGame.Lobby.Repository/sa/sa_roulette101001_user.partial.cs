using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class Sa_roulette101001_userPO
    {
        #region AiUo
        public static implicit operator Sa_roulette101001_userEO(Sa_roulette101001_userPO value)
        {
            if (value==null) return null;
            return new Sa_roulette101001_userEO
            {
		        UserID = value.UserID,
		        UserKind = value.UserKind,
		        FromId = value.FromId,
		        FromMode = value.FromMode,
		        OperatorID = value.OperatorID,
		        CurrencyID = value.CurrencyID,
		        SpinNum = value.SpinNum,
		        RecDate = value.RecDate,
            };
        }
        public static implicit operator Sa_roulette101001_userPO(Sa_roulette101001_userEO value)
        {
            if (value==null) return null;
            return new Sa_roulette101001_userPO
            {
		        UserID = value.UserID,
		        UserKind = value.UserKind,
		        FromId = value.FromId,
		        FromMode = value.FromMode,
		        OperatorID = value.OperatorID,
		        CurrencyID = value.CurrencyID,
		        SpinNum = value.SpinNum,
		        RecDate = value.RecDate,
            };
        }
        #endregion
    }
}