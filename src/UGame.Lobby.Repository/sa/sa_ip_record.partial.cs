using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class Sa_ip_recordPO
    {
        #region AiUo
        public static implicit operator Sa_ip_recordEO(Sa_ip_recordPO value)
        {
            if (value==null) return null;
            return new Sa_ip_recordEO
            {
		        ID = value.ID,
		        ActivityID = value.ActivityID,
		        UserID = value.UserID,
		        OperatorID = value.OperatorID,
		        CountryId = value.CountryId,
		        CurrencyID = value.CurrencyID,
		        IpAddress = value.IpAddress,
		        Bonus = value.Bonus,
		        FlowMultip = value.FlowMultip,
		        RecDate = value.RecDate,
            };
        }
        public static implicit operator Sa_ip_recordPO(Sa_ip_recordEO value)
        {
            if (value==null) return null;
            return new Sa_ip_recordPO
            {
		        ID = value.ID,
		        ActivityID = value.ActivityID,
		        UserID = value.UserID,
		        OperatorID = value.OperatorID,
		        CountryId = value.CountryId,
		        CurrencyID = value.CurrencyID,
		        IpAddress = value.IpAddress,
		        Bonus = value.Bonus,
		        FlowMultip = value.FlowMultip,
		        RecDate = value.RecDate,
            };
        }
        #endregion
    }
}