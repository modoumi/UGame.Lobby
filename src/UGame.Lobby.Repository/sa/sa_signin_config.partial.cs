using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class Sa_signin_configPO
    {
        #region AiUo
        public static implicit operator Sa_signin_configEO(Sa_signin_configPO value)
        {
            if (value==null) return null;
            return new Sa_signin_configEO
            {
		        ConfigID = value.ConfigID,
		        RecDate = value.RecDate,
		        OperatorID = value.OperatorID,
		        CountryID = value.CountryID,
		        CurrencyID = value.CurrencyID,
		        FlowMultip = value.FlowMultip,
            };
        }
        public static implicit operator Sa_signin_configPO(Sa_signin_configEO value)
        {
            if (value==null) return null;
            return new Sa_signin_configPO
            {
		        ConfigID = value.ConfigID,
		        RecDate = value.RecDate,
		        OperatorID = value.OperatorID,
		        CountryID = value.CountryID,
		        CurrencyID = value.CurrencyID,
		        FlowMultip = value.FlowMultip,
            };
        }
        #endregion
    }
}