using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class L_notifyPO
    {
        #region AiUo
        public static implicit operator L_notifyEO(L_notifyPO value)
        {
            if (value==null) return null;
            return new L_notifyEO
            {
		        NotifyID = value.NotifyID,
		        AppID = value.AppID,
		        ProviderId = value.ProviderId,
		        OperatorID = value.OperatorID,
		        ActionAt = value.ActionAt,
		        ShowAt = value.ShowAt,
		        Position = value.Position,
		        ShowInterval = value.ShowInterval,
		        ShowTimes = value.ShowTimes,
		        CloseInterval = value.CloseInterval,
		        OrderNum = value.OrderNum,
		        LinkKind = value.LinkKind,
		        LinkUrl = value.LinkUrl,
		        BeginDate = value.BeginDate,
		        EndDate = value.EndDate,
		        UserScope = value.UserScope,
		        ScopeValue = value.ScopeValue,
		        Status = value.Status,
		        RecDate = value.RecDate,
            };
        }
        public static implicit operator L_notifyPO(L_notifyEO value)
        {
            if (value==null) return null;
            return new L_notifyPO
            {
		        NotifyID = value.NotifyID,
		        AppID = value.AppID,
		        ProviderId = value.ProviderId,
		        OperatorID = value.OperatorID,
		        ActionAt = value.ActionAt,
		        ShowAt = value.ShowAt,
		        Position = value.Position,
		        ShowInterval = value.ShowInterval,
		        ShowTimes = value.ShowTimes,
		        CloseInterval = value.CloseInterval,
		        OrderNum = value.OrderNum,
		        LinkKind = value.LinkKind,
		        LinkUrl = value.LinkUrl,
		        BeginDate = value.BeginDate,
		        EndDate = value.EndDate,
		        UserScope = value.UserScope,
		        ScopeValue = value.ScopeValue,
		        Status = value.Status,
		        RecDate = value.RecDate,
            };
        }
        #endregion
    }
}