using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class Sa_userpay100008_configPO
    {
        #region AiUo
        public static implicit operator Sa_userpay100008_configEO(Sa_userpay100008_configPO value)
        {
            if (value==null) return null;
            return new Sa_userpay100008_configEO
            {
		        OperatorID = value.OperatorID,
		        CountryId = value.CountryId,
		        CurrencyID = value.CurrencyID,
		        PayAmountStart = value.PayAmountStart,
		        SendBonusMax = value.SendBonusMax,
		        DayNumLimit = value.DayNumLimit,
		        FlowMultip = value.FlowMultip,
		        RecDate = value.RecDate,
            };
        }
        public static implicit operator Sa_userpay100008_configPO(Sa_userpay100008_configEO value)
        {
            if (value==null) return null;
            return new Sa_userpay100008_configPO
            {
		        OperatorID = value.OperatorID,
		        CountryId = value.CountryId,
		        CurrencyID = value.CurrencyID,
		        PayAmountStart = value.PayAmountStart,
		        SendBonusMax = value.SendBonusMax,
		        DayNumLimit = value.DayNumLimit,
		        FlowMultip = value.FlowMultip,
		        RecDate = value.RecDate,
            };
        }
        #endregion
    }
}