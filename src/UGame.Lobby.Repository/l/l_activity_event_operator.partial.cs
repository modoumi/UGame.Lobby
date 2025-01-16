using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class L_activity_event_operatorPO
    {
        #region AiUo
        public static implicit operator L_activity_event_operatorEO(L_activity_event_operatorPO value)
        {
            if (value==null) return null;
            return new L_activity_event_operatorEO
            {
		        OperatorID = value.OperatorID,
		        ActivityID = value.ActivityID,
		        ActivityEventId = value.ActivityEventId,
		        CountryID = value.CountryID,
		        CurrencyID = value.CurrencyID,
		        Status = value.Status,
		        RecDate = value.RecDate,
            };
        }
        public static implicit operator L_activity_event_operatorPO(L_activity_event_operatorEO value)
        {
            if (value==null) return null;
            return new L_activity_event_operatorPO
            {
		        OperatorID = value.OperatorID,
		        ActivityID = value.ActivityID,
		        ActivityEventId = value.ActivityEventId,
		        CountryID = value.CountryID,
		        CurrencyID = value.CurrencyID,
		        Status = value.Status,
		        RecDate = value.RecDate,
            };
        }
        #endregion
    }
}