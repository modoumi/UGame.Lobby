using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class Sa_firstpay_configPO
    {
        #region AiUo
        public static implicit operator Sa_firstpay_configEO(Sa_firstpay_configPO value)
        {
            if (value==null) return null;
            return new Sa_firstpay_configEO
            {
		        OperatorID = value.OperatorID,
		        CountryId = value.CountryId,
		        CurrencyID = value.CurrencyID,
		        PayMultipleList = value.PayMultipleList,
		        MaximumList = value.MaximumList,
		        TotalTimes = value.TotalTimes,
		        LeastPayAmount = value.LeastPayAmount,
		        IsBonus = value.IsBonus,
		        FlowMultip = value.FlowMultip,
		        RecDate = value.RecDate,
            };
        }
        public static implicit operator Sa_firstpay_configPO(Sa_firstpay_configEO value)
        {
            if (value==null) return null;
            return new Sa_firstpay_configPO
            {
		        OperatorID = value.OperatorID,
		        CountryId = value.CountryId,
		        CurrencyID = value.CurrencyID,
		        PayMultipleList = value.PayMultipleList,
		        MaximumList = value.MaximumList,
		        TotalTimes = value.TotalTimes,
		        LeastPayAmount = value.LeastPayAmount,
		        IsBonus = value.IsBonus,
		        FlowMultip = value.FlowMultip,
		        RecDate = value.RecDate,
            };
        }
        #endregion
    }
}