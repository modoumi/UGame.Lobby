using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class Sc_notifyPO
    {
        #region AiUo
        public static implicit operator Sc_notifyEO(Sc_notifyPO value)
        {
            if (value==null) return null;
            return new Sc_notifyEO
            {
		        NotifyID = value.NotifyID,
		        AppID = value.AppID,
		        OperatorID = value.OperatorID,
		        ActionAt = value.ActionAt,
		        ShowAt = value.ShowAt,
		        UserScope = value.UserScope,
		        NotifyUsersCount = value.NotifyUsersCount,
		        NotifyedUsersCount = value.NotifyedUsersCount,
		        Position = value.Position,
		        ShowTimes = value.ShowTimes,
		        ShowInterval = value.ShowInterval,
		        CloseInterval = value.CloseInterval,
		        OrderNum = value.OrderNum,
		        BeginDate = value.BeginDate,
		        EndDate = value.EndDate,
		        Status = value.Status,
		        RecDate = value.RecDate,
            };
        }
        public static implicit operator Sc_notifyPO(Sc_notifyEO value)
        {
            if (value==null) return null;
            return new Sc_notifyPO
            {
		        NotifyID = value.NotifyID,
		        AppID = value.AppID,
		        OperatorID = value.OperatorID,
		        ActionAt = value.ActionAt,
		        ShowAt = value.ShowAt,
		        UserScope = value.UserScope,
		        NotifyUsersCount = value.NotifyUsersCount,
		        NotifyedUsersCount = value.NotifyedUsersCount,
		        Position = value.Position,
		        ShowTimes = value.ShowTimes,
		        ShowInterval = value.ShowInterval,
		        CloseInterval = value.CloseInterval,
		        OrderNum = value.OrderNum,
		        BeginDate = value.BeginDate,
		        EndDate = value.EndDate,
		        Status = value.Status,
		        RecDate = value.RecDate,
            };
        }
        #endregion
    }
}