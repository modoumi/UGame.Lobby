using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class Sa_signin100012_configPO
    {
        #region AiUo
        public static implicit operator Sa_signin100012_configEO(Sa_signin100012_configPO value)
        {
            if (value==null) return null;
            return new Sa_signin100012_configEO
            {
		        OperatorID = value.OperatorID,
		        CurrencyID = value.CurrencyID,
		        CountryID = value.CountryID,
		        FlowMultip = value.FlowMultip,
		        SigninPayAmount = value.SigninPayAmount,
		        MissSigninPayAmount = value.MissSigninPayAmount,
            };
        }
        public static implicit operator Sa_signin100012_configPO(Sa_signin100012_configEO value)
        {
            if (value==null) return null;
            return new Sa_signin100012_configPO
            {
		        OperatorID = value.OperatorID,
		        CurrencyID = value.CurrencyID,
		        CountryID = value.CountryID,
		        FlowMultip = value.FlowMultip,
		        SigninPayAmount = value.SigninPayAmount,
		        MissSigninPayAmount = value.MissSigninPayAmount,
            };
        }
        #endregion
    }
}