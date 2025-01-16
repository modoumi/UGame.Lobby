using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class Sat_item_operatorPO
    {
        #region AiUo
        public static implicit operator Sat_item_operatorEO(Sat_item_operatorPO value)
        {
            if (value==null) return null;
            return new Sat_item_operatorEO
            {
		        ItemID = value.ItemID,
		        OperatorID = value.OperatorID,
		        CronExpr = value.CronExpr,
		        BeginDate = value.BeginDate,
		        EndDate = value.EndDate,
		        Status = value.Status,
		        RecDate = value.RecDate,
            };
        }
        public static implicit operator Sat_item_operatorPO(Sat_item_operatorEO value)
        {
            if (value==null) return null;
            return new Sat_item_operatorPO
            {
		        ItemID = value.ItemID,
		        OperatorID = value.OperatorID,
		        CronExpr = value.CronExpr,
		        BeginDate = value.BeginDate,
		        EndDate = value.EndDate,
		        Status = value.Status,
		        RecDate = value.RecDate,
            };
        }
        #endregion
    }
}