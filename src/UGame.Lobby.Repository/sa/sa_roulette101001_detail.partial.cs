using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class Sa_roulette101001_detailPO
    {
        #region AiUo
        public static implicit operator Sa_roulette101001_detailEO(Sa_roulette101001_detailPO value)
        {
            if (value==null) return null;
            return new Sa_roulette101001_detailEO
            {
		        DetailID = value.DetailID,
		        UserID = value.UserID,
		        DayId = value.DayId,
		        Mobile = value.Mobile,
		        OperatorID = value.OperatorID,
		        CurrencyID = value.CurrencyID,
		        EndSpinNum = value.EndSpinNum,
		        Amount = value.Amount,
		        RewardType = value.RewardType,
		        Position = value.Position,
		        Status = value.Status,
		        RecDate = value.RecDate,
            };
        }
        public static implicit operator Sa_roulette101001_detailPO(Sa_roulette101001_detailEO value)
        {
            if (value==null) return null;
            return new Sa_roulette101001_detailPO
            {
		        DetailID = value.DetailID,
		        UserID = value.UserID,
		        DayId = value.DayId,
		        Mobile = value.Mobile,
		        OperatorID = value.OperatorID,
		        CurrencyID = value.CurrencyID,
		        EndSpinNum = value.EndSpinNum,
		        Amount = value.Amount,
		        RewardType = value.RewardType,
		        Position = value.Position,
		        Status = value.Status,
		        RecDate = value.RecDate,
            };
        }
        #endregion
    }
}