using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class Sa_firstpay_user_detailPO
    {
        #region AiUo
        public static implicit operator Sa_firstpay_user_detailEO(Sa_firstpay_user_detailPO value)
        {
            if (value==null) return null;
            return new Sa_firstpay_user_detailEO
            {
		        DetailID = value.DetailID,
		        UserID = value.UserID,
		        OperatorID = value.OperatorID,
		        CountryID = value.CountryID,
		        CurrencyID = value.CurrencyID,
		        PayAmount = value.PayAmount,
		        BonusAmount = value.BonusAmount,
		        RemainTimes = value.RemainTimes,
		        NotifyStatus = value.NotifyStatus,
		        ReceiveStatus = value.ReceiveStatus,
		        OrderId = value.OrderId,
		        RecDate = value.RecDate,
            };
        }
        public static implicit operator Sa_firstpay_user_detailPO(Sa_firstpay_user_detailEO value)
        {
            if (value==null) return null;
            return new Sa_firstpay_user_detailPO
            {
		        DetailID = value.DetailID,
		        UserID = value.UserID,
		        OperatorID = value.OperatorID,
		        CountryID = value.CountryID,
		        CurrencyID = value.CurrencyID,
		        PayAmount = value.PayAmount,
		        BonusAmount = value.BonusAmount,
		        RemainTimes = value.RemainTimes,
		        NotifyStatus = value.NotifyStatus,
		        ReceiveStatus = value.ReceiveStatus,
		        OrderId = value.OrderId,
		        RecDate = value.RecDate,
            };
        }
        #endregion
    }
}