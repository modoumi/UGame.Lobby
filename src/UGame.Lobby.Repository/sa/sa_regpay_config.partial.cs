using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class Sa_regpay_configPO
    {
        #region AiUo
        public static implicit operator Sa_regpay_configEO(Sa_regpay_configPO value)
        {
            if (value==null) return null;
            return new Sa_regpay_configEO
            {
		        OperatorID = value.OperatorID,
		        CountryId = value.CountryId,
		        CurrencyID = value.CurrencyID,
		        RegReward = value.RegReward,
		        FirstPayReward = value.FirstPayReward,
		        BetAmount = value.BetAmount,
		        BetReturnReward = value.BetReturnReward,
		        RecDate = value.RecDate,
            };
        }
        public static implicit operator Sa_regpay_configPO(Sa_regpay_configEO value)
        {
            if (value==null) return null;
            return new Sa_regpay_configPO
            {
		        OperatorID = value.OperatorID,
		        CountryId = value.CountryId,
		        CurrencyID = value.CurrencyID,
		        RegReward = value.RegReward,
		        FirstPayReward = value.FirstPayReward,
		        BetAmount = value.BetAmount,
		        BetReturnReward = value.BetReturnReward,
		        RecDate = value.RecDate,
            };
        }
        #endregion
    }
}