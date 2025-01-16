using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class Sa_roulette_configPO
    {
        #region AiUo
        public static implicit operator Sa_roulette_configEO(Sa_roulette_configPO value)
        {
            if (value==null) return null;
            return new Sa_roulette_configEO
            {
		        OperatorID = value.OperatorID,
		        CountryId = value.CountryId,
		        CurrencyID = value.CurrencyID,
		        RegisterFreespin = value.RegisterFreespin,
		        FirstPayFreespin = value.FirstPayFreespin,
		        RaffleUsedFreespin = value.RaffleUsedFreespin,
		        RaffleCashAmount = value.RaffleCashAmount,
		        NewUserBetTag = value.NewUserBetTag,
		        NewUserMaxBonus = value.NewUserMaxBonus,
		        InGoldPool = value.InGoldPool,
		        InCashPool = value.InCashPool,
		        GGRInFreespinPool = value.GGRInFreespinPool,
		        RecommendGames = value.RecommendGames,
		        IsCashEnable = value.IsCashEnable,
		        TipPayRoundMin = value.TipPayRoundMin,
		        TipPayRoundMax = value.TipPayRoundMax,
		        RecDate = value.RecDate,
            };
        }
        public static implicit operator Sa_roulette_configPO(Sa_roulette_configEO value)
        {
            if (value==null) return null;
            return new Sa_roulette_configPO
            {
		        OperatorID = value.OperatorID,
		        CountryId = value.CountryId,
		        CurrencyID = value.CurrencyID,
		        RegisterFreespin = value.RegisterFreespin,
		        FirstPayFreespin = value.FirstPayFreespin,
		        RaffleUsedFreespin = value.RaffleUsedFreespin,
		        RaffleCashAmount = value.RaffleCashAmount,
		        NewUserBetTag = value.NewUserBetTag,
		        NewUserMaxBonus = value.NewUserMaxBonus,
		        InGoldPool = value.InGoldPool,
		        InCashPool = value.InCashPool,
		        GGRInFreespinPool = value.GGRInFreespinPool,
		        RecommendGames = value.RecommendGames,
		        IsCashEnable = value.IsCashEnable,
		        TipPayRoundMin = value.TipPayRoundMin,
		        TipPayRoundMax = value.TipPayRoundMax,
		        RecDate = value.RecDate,
            };
        }
        #endregion
    }
}