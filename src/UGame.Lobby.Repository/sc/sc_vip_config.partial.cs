using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class Sc_vip_configPO
    {
        #region AiUo
        public static implicit operator Sc_vip_configEO(Sc_vip_configPO value)
        {
            if (value==null) return null;
            return new Sc_vip_configEO
            {
		        VipID = value.VipID,
		        OperatorID = value.OperatorID,
		        CountryID = value.CountryID,
		        CurrencyID = value.CurrencyID,
		        VipGrade = value.VipGrade,
		        BetMinAmount = value.BetMinAmount,
		        BetMaxAmount = value.BetMaxAmount,
		        PayStartAmount = value.PayStartAmount,
		        PayEndAmount = value.PayEndAmount,
		        GradeReward = value.GradeReward,
		        GradeFlowMultip = value.GradeFlowMultip,
		        WeekReward = value.WeekReward,
		        WeekFlowMultip = value.WeekFlowMultip,
		        CashRate = value.CashRate,
		        DayCashNumLimit = value.DayCashNumLimit,
		        DayCashAmountLimit = value.DayCashAmountLimit,
		        RecDate = value.RecDate,
            };
        }
        public static implicit operator Sc_vip_configPO(Sc_vip_configEO value)
        {
            if (value==null) return null;
            return new Sc_vip_configPO
            {
		        VipID = value.VipID,
		        OperatorID = value.OperatorID,
		        CountryID = value.CountryID,
		        CurrencyID = value.CurrencyID,
		        VipGrade = value.VipGrade,
		        BetMinAmount = value.BetMinAmount,
		        BetMaxAmount = value.BetMaxAmount,
		        PayStartAmount = value.PayStartAmount,
		        PayEndAmount = value.PayEndAmount,
		        GradeReward = value.GradeReward,
		        GradeFlowMultip = value.GradeFlowMultip,
		        WeekReward = value.WeekReward,
		        WeekFlowMultip = value.WeekFlowMultip,
		        CashRate = value.CashRate,
		        DayCashNumLimit = value.DayCashNumLimit,
		        DayCashAmountLimit = value.DayCashAmountLimit,
		        RecDate = value.RecDate,
            };
        }
        #endregion
    }
}