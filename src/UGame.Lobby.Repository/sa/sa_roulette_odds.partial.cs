using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class Sa_roulette_oddsPO
    {
        #region AiUo
        public static implicit operator Sa_roulette_oddsEO(Sa_roulette_oddsPO value)
        {
            if (value==null) return null;
            return new Sa_roulette_oddsEO
            {
		        OddsID = value.OddsID,
		        OperatorID = value.OperatorID,
		        CountryID = value.CountryID,
		        CurrencyID = value.CurrencyID,
		        RaffleType = value.RaffleType,
		        UserType = value.UserType,
		        Level = value.Level,
		        RewardType = value.RewardType,
		        PreRewardType = value.PreRewardType,
		        RewardTypeDesc = value.RewardTypeDesc,
		        Position = value.Position,
		        Odds = value.Odds,
		        Multiple = value.Multiple,
		        OrderNum = value.OrderNum,
		        RecDate = value.RecDate,
            };
        }
        public static implicit operator Sa_roulette_oddsPO(Sa_roulette_oddsEO value)
        {
            if (value==null) return null;
            return new Sa_roulette_oddsPO
            {
		        OddsID = value.OddsID,
		        OperatorID = value.OperatorID,
		        CountryID = value.CountryID,
		        CurrencyID = value.CurrencyID,
		        RaffleType = value.RaffleType,
		        UserType = value.UserType,
		        Level = value.Level,
		        RewardType = value.RewardType,
		        PreRewardType = value.PreRewardType,
		        RewardTypeDesc = value.RewardTypeDesc,
		        Position = value.Position,
		        Odds = value.Odds,
		        Multiple = value.Multiple,
		        OrderNum = value.OrderNum,
		        RecDate = value.RecDate,
            };
        }
        #endregion
    }
}