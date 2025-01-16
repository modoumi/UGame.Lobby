using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class Sa_invitepay100011_configPO
    {
        #region AiUo
        public static implicit operator Sa_invitepay100011_configEO(Sa_invitepay100011_configPO value)
        {
            if (value==null) return null;
            return new Sa_invitepay100011_configEO
            {
		        ConfigID = value.ConfigID,
		        OperatorID = value.OperatorID,
		        CountryId = value.CountryId,
		        CurrencyID = value.CurrencyID,
		        PayAmountStart = value.PayAmountStart,
		        PayAmountEnd = value.PayAmountEnd,
		        Bonus = value.Bonus,
		        FlowMultip = value.FlowMultip,
            };
        }
        public static implicit operator Sa_invitepay100011_configPO(Sa_invitepay100011_configEO value)
        {
            if (value==null) return null;
            return new Sa_invitepay100011_configPO
            {
		        ConfigID = value.ConfigID,
		        OperatorID = value.OperatorID,
		        CountryId = value.CountryId,
		        CurrencyID = value.CurrencyID,
		        PayAmountStart = value.PayAmountStart,
		        PayAmountEnd = value.PayAmountEnd,
		        Bonus = value.Bonus,
		        FlowMultip = value.FlowMultip,
            };
        }
        #endregion
    }
}