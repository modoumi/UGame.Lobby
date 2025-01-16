using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class L_activity_event_basePO
    {
        #region AiUo
        public static implicit operator L_activity_event_baseEO(L_activity_event_basePO value)
        {
            if (value==null) return null;
            return new L_activity_event_baseEO
            {
		        ActivityEventId = value.ActivityEventId,
		        EventName = value.EventName,
            };
        }
        public static implicit operator L_activity_event_basePO(L_activity_event_baseEO value)
        {
            if (value==null) return null;
            return new L_activity_event_basePO
            {
		        ActivityEventId = value.ActivityEventId,
		        EventName = value.EventName,
            };
        }
        #endregion
    }
}