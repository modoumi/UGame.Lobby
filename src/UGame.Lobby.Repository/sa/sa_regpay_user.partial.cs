using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class Sa_regpay_userPO
    {
        #region AiUo
        public static implicit operator Sa_regpay_userEO(Sa_regpay_userPO value)
        {
            if (value==null) return null;
            return new Sa_regpay_userEO
            {
		        UserID = value.UserID,
		        OperatorID = value.OperatorID,
		        CountryId = value.CountryId,
		        CurrencyID = value.CurrencyID,
		        SumPay = value.SumPay,
		        RegPay = value.RegPay,
		        FirstPay = value.FirstPay,
		        RegPayReward = value.RegPayReward,
		        FirstPayReward = value.FirstPayReward,
		        SumBet = value.SumBet,
		        ReturnRewards = value.ReturnRewards,
		        IsRegPay = value.IsRegPay,
		        IsFirstPay = value.IsFirstPay,
		        RecDate = value.RecDate,
            };
        }
        public static implicit operator Sa_regpay_userPO(Sa_regpay_userEO value)
        {
            if (value==null) return null;
            return new Sa_regpay_userPO
            {
		        UserID = value.UserID,
		        OperatorID = value.OperatorID,
		        CountryId = value.CountryId,
		        CurrencyID = value.CurrencyID,
		        SumPay = value.SumPay,
		        RegPay = value.RegPay,
		        FirstPay = value.FirstPay,
		        RegPayReward = value.RegPayReward,
		        FirstPayReward = value.FirstPayReward,
		        SumBet = value.SumBet,
		        ReturnRewards = value.ReturnRewards,
		        IsRegPay = value.IsRegPay,
		        IsFirstPay = value.IsFirstPay,
		        RecDate = value.RecDate,
            };
        }
        #endregion
    }
}