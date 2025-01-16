using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class Sa_roulette_userPO
    {
        #region AiUo
        public static implicit operator Sa_roulette_userEO(Sa_roulette_userPO value)
        {
            if (value==null) return null;
            return new Sa_roulette_userEO
            {
		        UserID = value.UserID,
		        UserKind = value.UserKind,
		        OperatorID = value.OperatorID,
		        CurrencyID = value.CurrencyID,
		        Freespin = value.Freespin,
		        SumWinAmount = value.SumWinAmount,
		        FreespinRound = value.FreespinRound,
		        IsRegPay = value.IsRegPay,
		        IsFirstPay = value.IsFirstPay,
		        RecDate = value.RecDate,
            };
        }
        public static implicit operator Sa_roulette_userPO(Sa_roulette_userEO value)
        {
            if (value==null) return null;
            return new Sa_roulette_userPO
            {
		        UserID = value.UserID,
		        UserKind = value.UserKind,
		        OperatorID = value.OperatorID,
		        CurrencyID = value.CurrencyID,
		        Freespin = value.Freespin,
		        SumWinAmount = value.SumWinAmount,
		        FreespinRound = value.FreespinRound,
		        IsRegPay = value.IsRegPay,
		        IsFirstPay = value.IsFirstPay,
		        RecDate = value.RecDate,
            };
        }
        #endregion
    }
}