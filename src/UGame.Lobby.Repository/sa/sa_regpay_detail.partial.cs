using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class Sa_regpay_detailPO
    {
        #region AiUo
        public static implicit operator Sa_regpay_detailEO(Sa_regpay_detailPO value)
        {
            if (value==null) return null;
            return new Sa_regpay_detailEO
            {
		        DetailID = value.DetailID,
		        UserID = value.UserID,
		        OperatorID = value.OperatorID,
		        CountryId = value.CountryId,
		        CurrencyID = value.CurrencyID,
		        RewardAmount = value.RewardAmount,
		        RecDate = value.RecDate,
            };
        }
        public static implicit operator Sa_regpay_detailPO(Sa_regpay_detailEO value)
        {
            if (value==null) return null;
            return new Sa_regpay_detailPO
            {
		        DetailID = value.DetailID,
		        UserID = value.UserID,
		        OperatorID = value.OperatorID,
		        CountryId = value.CountryId,
		        CurrencyID = value.CurrencyID,
		        RewardAmount = value.RewardAmount,
		        RecDate = value.RecDate,
            };
        }
        #endregion
    }
}