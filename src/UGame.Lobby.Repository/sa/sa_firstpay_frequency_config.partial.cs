using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class Sa_firstpay_frequency_configPO
    {
        #region AiUo
        public static implicit operator Sa_firstpay_frequency_configEO(Sa_firstpay_frequency_configPO value)
        {
            if (value==null) return null;
            return new Sa_firstpay_frequency_configEO
            {
		        OperatorID = value.OperatorID,
		        CountryId = value.CountryId,
		        CurrencyID = value.CurrencyID,
		        SerialNumber = value.SerialNumber,
		        PayMin = value.PayMin,
		        PayMax = value.PayMax,
		        PayMultiple = value.PayMultiple,
		        RecDate = value.RecDate,
            };
        }
        public static implicit operator Sa_firstpay_frequency_configPO(Sa_firstpay_frequency_configEO value)
        {
            if (value==null) return null;
            return new Sa_firstpay_frequency_configPO
            {
		        OperatorID = value.OperatorID,
		        CountryId = value.CountryId,
		        CurrencyID = value.CurrencyID,
		        SerialNumber = value.SerialNumber,
		        PayMin = value.PayMin,
		        PayMax = value.PayMax,
		        PayMultiple = value.PayMultiple,
		        RecDate = value.RecDate,
            };
        }
        #endregion
    }
}