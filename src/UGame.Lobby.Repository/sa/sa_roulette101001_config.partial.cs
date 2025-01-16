using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class Sa_roulette101001_configPO
    {
        #region AiUo
        public static implicit operator Sa_roulette101001_configEO(Sa_roulette101001_configPO value)
        {
            if (value==null) return null;
            return new Sa_roulette101001_configEO
            {
		        OperatorID = value.OperatorID,
		        CountryId = value.CountryId,
		        CurrencyID = value.CurrencyID,
		        PayCondition = value.PayCondition,
		        PaySendNum = value.PaySendNum,
		        DaySendNumLimit = value.DaySendNumLimit,
            };
        }
        public static implicit operator Sa_roulette101001_configPO(Sa_roulette101001_configEO value)
        {
            if (value==null) return null;
            return new Sa_roulette101001_configPO
            {
		        OperatorID = value.OperatorID,
		        CountryId = value.CountryId,
		        CurrencyID = value.CurrencyID,
		        PayCondition = value.PayCondition,
		        PaySendNum = value.PaySendNum,
		        DaySendNumLimit = value.DaySendNumLimit,
            };
        }
        #endregion
    }
}