using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class Sa_roulette101001_oddsPO
    {
        #region AiUo
        public static implicit operator Sa_roulette101001_oddsEO(Sa_roulette101001_oddsPO value)
        {
            if (value==null) return null;
            return new Sa_roulette101001_oddsEO
            {
		        OddsID = value.OddsID,
		        OperatorID = value.OperatorID,
		        CountryID = value.CountryID,
		        CurrencyID = value.CurrencyID,
		        RewardType = value.RewardType,
		        RewardTypeDesc = value.RewardTypeDesc,
		        Position = value.Position,
		        Odds = value.Odds,
		        Bonus = value.Bonus,
		        OrderNum = value.OrderNum,
		        FlowMultip = value.FlowMultip,
		        RecDate = value.RecDate,
            };
        }
        public static implicit operator Sa_roulette101001_oddsPO(Sa_roulette101001_oddsEO value)
        {
            if (value==null) return null;
            return new Sa_roulette101001_oddsPO
            {
		        OddsID = value.OddsID,
		        OperatorID = value.OperatorID,
		        CountryID = value.CountryID,
		        CurrencyID = value.CurrencyID,
		        RewardType = value.RewardType,
		        RewardTypeDesc = value.RewardTypeDesc,
		        Position = value.Position,
		        Odds = value.Odds,
		        Bonus = value.Bonus,
		        OrderNum = value.OrderNum,
		        FlowMultip = value.FlowMultip,
		        RecDate = value.RecDate,
            };
        }
        #endregion
    }
}