using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class Sa_losecashback_detailPO
    {
        #region AiUo
        public static implicit operator Sa_losecashback_detailEO(Sa_losecashback_detailPO value)
        {
            if (value==null) return null;
            return new Sa_losecashback_detailEO
            {
		        DetailID = value.DetailID,
		        UserID = value.UserID,
		        DayID = value.DayID,
		        OperatorID = value.OperatorID,
		        CountryID = value.CountryID,
		        CurrencyID = value.CurrencyID,
		        RefundAmount = value.RefundAmount,
		        NotifyStatus = value.NotifyStatus,
		        ReceiveStatus = value.ReceiveStatus,
		        FlowMultip = value.FlowMultip,
		        RecDate = value.RecDate,
            };
        }
        public static implicit operator Sa_losecashback_detailPO(Sa_losecashback_detailEO value)
        {
            if (value==null) return null;
            return new Sa_losecashback_detailPO
            {
		        DetailID = value.DetailID,
		        UserID = value.UserID,
		        DayID = value.DayID,
		        OperatorID = value.OperatorID,
		        CountryID = value.CountryID,
		        CurrencyID = value.CurrencyID,
		        RefundAmount = value.RefundAmount,
		        NotifyStatus = value.NotifyStatus,
		        ReceiveStatus = value.ReceiveStatus,
		        FlowMultip = value.FlowMultip,
		        RecDate = value.RecDate,
            };
        }
        #endregion
    }
}