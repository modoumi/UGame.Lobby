using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class Sa_roulette_detailPO
    {
        #region AiUo
        public static implicit operator Sa_roulette_detailEO(Sa_roulette_detailPO value)
        {
            if (value==null) return null;
            return new Sa_roulette_detailEO
            {
		        DetailID = value.DetailID,
		        UserID = value.UserID,
		        Mobile = value.Mobile,
		        OperatorID = value.OperatorID,
		        CurrencyID = value.CurrencyID,
		        DetailType = value.DetailType,
		        PlanBet = value.PlanBet,
		        Amount = value.Amount,
		        Freespin = value.Freespin,
		        IsFreespin = value.IsFreespin,
		        FreespinNum = value.FreespinNum,
		        RaffleType = value.RaffleType,
		        UserType = value.UserType,
		        Level = value.Level,
		        RewardType = value.RewardType,
		        PreRewardType = value.PreRewardType,
		        Position = value.Position,
		        Multiple = value.Multiple,
		        Bonus = value.Bonus,
		        Status = value.Status,
		        RecDate = value.RecDate,
            };
        }
        public static implicit operator Sa_roulette_detailPO(Sa_roulette_detailEO value)
        {
            if (value==null) return null;
            return new Sa_roulette_detailPO
            {
		        DetailID = value.DetailID,
		        UserID = value.UserID,
		        Mobile = value.Mobile,
		        OperatorID = value.OperatorID,
		        CurrencyID = value.CurrencyID,
		        DetailType = value.DetailType,
		        PlanBet = value.PlanBet,
		        Amount = value.Amount,
		        Freespin = value.Freespin,
		        IsFreespin = value.IsFreespin,
		        FreespinNum = value.FreespinNum,
		        RaffleType = value.RaffleType,
		        UserType = value.UserType,
		        Level = value.Level,
		        RewardType = value.RewardType,
		        PreRewardType = value.PreRewardType,
		        Position = value.Position,
		        Multiple = value.Multiple,
		        Bonus = value.Bonus,
		        Status = value.Status,
		        RecDate = value.RecDate,
            };
        }
        #endregion
    }
}