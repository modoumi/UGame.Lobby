using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class Sa_userpay100008_detail_configPO
    {
        #region AiUo
        public static implicit operator Sa_userpay100008_detail_configEO(Sa_userpay100008_detail_configPO value)
        {
            if (value==null) return null;
            return new Sa_userpay100008_detail_configEO
            {
		        DetailID = value.DetailID,
		        OperatorID = value.OperatorID,
		        CountryId = value.CountryId,
		        CurrencyID = value.CurrencyID,
		        PayAmountStart = value.PayAmountStart,
		        PayAmountEnd = value.PayAmountEnd,
		        SendBonusMultip = value.SendBonusMultip,
            };
        }
        public static implicit operator Sa_userpay100008_detail_configPO(Sa_userpay100008_detail_configEO value)
        {
            if (value==null) return null;
            return new Sa_userpay100008_detail_configPO
            {
		        DetailID = value.DetailID,
		        OperatorID = value.OperatorID,
		        CountryId = value.CountryId,
		        CurrencyID = value.CurrencyID,
		        PayAmountStart = value.PayAmountStart,
		        PayAmountEnd = value.PayAmountEnd,
		        SendBonusMultip = value.SendBonusMultip,
            };
        }
        #endregion
    }
}