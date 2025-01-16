using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class Sa_roulette_poolPO
    {
        #region AiUo
        public static implicit operator Sa_roulette_poolEO(Sa_roulette_poolPO value)
        {
            if (value==null) return null;
            return new Sa_roulette_poolEO
            {
		        OperatorID = value.OperatorID,
		        CountryId = value.CountryId,
		        CurrencyID = value.CurrencyID,
		        FreespinPool = value.FreespinPool,
		        CashPool = value.CashPool,
		        RecDate = value.RecDate,
            };
        }
        public static implicit operator Sa_roulette_poolPO(Sa_roulette_poolEO value)
        {
            if (value==null) return null;
            return new Sa_roulette_poolPO
            {
		        OperatorID = value.OperatorID,
		        CountryId = value.CountryId,
		        CurrencyID = value.CurrencyID,
		        FreespinPool = value.FreespinPool,
		        CashPool = value.CashPool,
		        RecDate = value.RecDate,
            };
        }
        #endregion
    }
}