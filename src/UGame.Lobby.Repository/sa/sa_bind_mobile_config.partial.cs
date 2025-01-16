using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class Sa_bind_mobile_configPO
    {
        #region AiUo
        public static implicit operator Sa_bind_mobile_configEO(Sa_bind_mobile_configPO value)
        {
            if (value==null) return null;
            return new Sa_bind_mobile_configEO
            {
		        OperatorID = value.OperatorID,
		        CountryId = value.CountryId,
		        CurrencyID = value.CurrencyID,
		        SendBonus = value.SendBonus,
		        CashBetMultip = value.CashBetMultip,
		        IsSendBonus = value.IsSendBonus,
		        RecDate = value.RecDate,
            };
        }
        public static implicit operator Sa_bind_mobile_configPO(Sa_bind_mobile_configEO value)
        {
            if (value==null) return null;
            return new Sa_bind_mobile_configPO
            {
		        OperatorID = value.OperatorID,
		        CountryId = value.CountryId,
		        CurrencyID = value.CurrencyID,
		        SendBonus = value.SendBonus,
		        CashBetMultip = value.CashBetMultip,
		        IsSendBonus = value.IsSendBonus,
		        RecDate = value.RecDate,
            };
        }
        #endregion
    }
}