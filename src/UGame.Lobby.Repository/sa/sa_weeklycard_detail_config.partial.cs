using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class Sa_weeklycard_detail_configPO
    {
        #region AiUo
        public static implicit operator Sa_weeklycard_detail_configEO(Sa_weeklycard_detail_configPO value)
        {
            if (value==null) return null;
            return new Sa_weeklycard_detail_configEO
            {
		        ConfigID = value.ConfigID,
		        OperatorID = value.OperatorID,
		        CurrencyID = value.CurrencyID,
		        WeeklyCardType = value.WeeklyCardType,
		        CountryId = value.CountryId,
		        Bonus = value.Bonus,
		        FlowMultip = value.FlowMultip,
		        DateNumber = value.DateNumber,
		        IsStartDay = value.IsStartDay,
            };
        }
        public static implicit operator Sa_weeklycard_detail_configPO(Sa_weeklycard_detail_configEO value)
        {
            if (value==null) return null;
            return new Sa_weeklycard_detail_configPO
            {
		        ConfigID = value.ConfigID,
		        OperatorID = value.OperatorID,
		        CurrencyID = value.CurrencyID,
		        WeeklyCardType = value.WeeklyCardType,
		        CountryId = value.CountryId,
		        Bonus = value.Bonus,
		        FlowMultip = value.FlowMultip,
		        DateNumber = value.DateNumber,
		        IsStartDay = value.IsStartDay,
            };
        }
        #endregion
    }
}