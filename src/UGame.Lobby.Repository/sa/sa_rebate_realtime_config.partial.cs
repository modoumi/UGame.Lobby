using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class Sa_rebate_realtime_configPO
    {
        #region AiUo
        public static implicit operator Sa_rebate_realtime_configEO(Sa_rebate_realtime_configPO value)
        {
            if (value==null) return null;
            return new Sa_rebate_realtime_configEO
            {
		        ConfigID = value.ConfigID,
		        OperatorID = value.OperatorID,
		        CurrencyID = value.CurrencyID,
		        ActivityID = value.ActivityID,
		        CountryID = value.CountryID,
		        BetMinAmount = value.BetMinAmount,
		        BetMaxAmount = value.BetMaxAmount,
		        RebateAmount = value.RebateAmount,
		        FlowMultip = value.FlowMultip,
		        RecDate = value.RecDate,
		        Level = value.Level,
		        AmountType = value.AmountType,
            };
        }
        public static implicit operator Sa_rebate_realtime_configPO(Sa_rebate_realtime_configEO value)
        {
            if (value==null) return null;
            return new Sa_rebate_realtime_configPO
            {
		        ConfigID = value.ConfigID,
		        OperatorID = value.OperatorID,
		        CurrencyID = value.CurrencyID,
		        ActivityID = value.ActivityID,
		        CountryID = value.CountryID,
		        BetMinAmount = value.BetMinAmount,
		        BetMaxAmount = value.BetMaxAmount,
		        RebateAmount = value.RebateAmount,
		        FlowMultip = value.FlowMultip,
		        RecDate = value.RecDate,
		        Level = value.Level,
		        AmountType = value.AmountType,
            };
        }
        #endregion
    }
}