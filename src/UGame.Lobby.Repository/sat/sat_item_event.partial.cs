using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class Sat_item_eventPO
    {
        #region AiUo
        public static implicit operator Sat_item_eventEO(Sat_item_eventPO value)
        {
            if (value==null) return null;
            return new Sat_item_eventEO
            {
		        ItemID = value.ItemID,
		        EventID = value.EventID,
            };
        }
        public static implicit operator Sat_item_eventPO(Sat_item_eventEO value)
        {
            if (value==null) return null;
            return new Sat_item_eventPO
            {
		        ItemID = value.ItemID,
		        EventID = value.EventID,
            };
        }
        #endregion
    }
}