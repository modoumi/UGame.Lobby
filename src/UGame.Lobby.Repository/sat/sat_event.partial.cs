using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class Sat_eventPO
    {
        #region AiUo
        public static implicit operator Sat_eventEO(Sat_eventPO value)
        {
            if (value==null) return null;
            return new Sat_eventEO
            {
		        EventID = value.EventID,
		        EventType = value.EventType,
		        Name = value.Name,
            };
        }
        public static implicit operator Sat_eventPO(Sat_eventEO value)
        {
            if (value==null) return null;
            return new Sat_eventPO
            {
		        EventID = value.EventID,
		        EventType = value.EventType,
		        Name = value.Name,
            };
        }
        #endregion
    }
}