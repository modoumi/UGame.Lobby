using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class Sa_register100007_configPO
    {
        #region AiUo
        public static implicit operator Sa_register100007_configEO(Sa_register100007_configPO value)
        {
            if (value==null) return null;
            return new Sa_register100007_configEO
            {
		        OperatorID = value.OperatorID,
		        CountryId = value.CountryId,
		        CurrencyID = value.CurrencyID,
		        SendBonus = value.SendBonus,
		        FlowMultip = value.FlowMultip,
		        IsSendBonus = value.IsSendBonus,
		        IPSendNum = value.IPSendNum,
		        RecDate = value.RecDate,
            };
        }
        public static implicit operator Sa_register100007_configPO(Sa_register100007_configEO value)
        {
            if (value==null) return null;
            return new Sa_register100007_configPO
            {
		        OperatorID = value.OperatorID,
		        CountryId = value.CountryId,
		        CurrencyID = value.CurrencyID,
		        SendBonus = value.SendBonus,
		        FlowMultip = value.FlowMultip,
		        IsSendBonus = value.IsSendBonus,
		        IPSendNum = value.IPSendNum,
		        RecDate = value.RecDate,
            };
        }
        #endregion
    }
}