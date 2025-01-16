using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class Sa_firstpay_user_configPO
    {
        #region AiUo
        public static implicit operator Sa_firstpay_user_configEO(Sa_firstpay_user_configPO value)
        {
            if (value==null) return null;
            return new Sa_firstpay_user_configEO
            {
		        UserID = value.UserID,
		        OperatorID = value.OperatorID,
		        CountryID = value.CountryID,
		        CurrencyID = value.CurrencyID,
		        RemainTimes = value.RemainTimes,
		        RecDate = value.RecDate,
		        UpdateTime = value.UpdateTime,
            };
        }
        public static implicit operator Sa_firstpay_user_configPO(Sa_firstpay_user_configEO value)
        {
            if (value==null) return null;
            return new Sa_firstpay_user_configPO
            {
		        UserID = value.UserID,
		        OperatorID = value.OperatorID,
		        CountryID = value.CountryID,
		        CurrencyID = value.CurrencyID,
		        RemainTimes = value.RemainTimes,
		        RecDate = value.RecDate,
		        UpdateTime = value.UpdateTime,
            };
        }
        #endregion
    }
}