using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class Sa_weeklycard_configPO
    {
        #region AiUo
        public static implicit operator Sa_weeklycard_configEO(Sa_weeklycard_configPO value)
        {
            if (value==null) return null;
            return new Sa_weeklycard_configEO
            {
		        OperatorID = value.OperatorID,
		        CurrencyID = value.CurrencyID,
		        WeeklyCardType = value.WeeklyCardType,
		        CountryId = value.CountryId,
		        VipMultip = value.VipMultip,
		        PayAmount = value.PayAmount,
		        FlowMultip = value.FlowMultip,
		        CountDown = value.CountDown,
            };
        }
        public static implicit operator Sa_weeklycard_configPO(Sa_weeklycard_configEO value)
        {
            if (value==null) return null;
            return new Sa_weeklycard_configPO
            {
		        OperatorID = value.OperatorID,
		        CurrencyID = value.CurrencyID,
		        WeeklyCardType = value.WeeklyCardType,
		        CountryId = value.CountryId,
		        VipMultip = value.VipMultip,
		        PayAmount = value.PayAmount,
		        FlowMultip = value.FlowMultip,
		        CountDown = value.CountDown,
            };
        }
        #endregion
    }
}