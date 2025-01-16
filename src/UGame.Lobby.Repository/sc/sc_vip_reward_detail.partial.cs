using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class Sc_vip_reward_detailPO
    {
        #region AiUo
        public static implicit operator Sc_vip_reward_detailEO(Sc_vip_reward_detailPO value)
        {
            if (value==null) return null;
            return new Sc_vip_reward_detailEO
            {
		        DetailID = value.DetailID,
		        UserID = value.UserID,
		        UserKind = value.UserKind,
		        FromId = value.FromId,
		        FromMode = value.FromMode,
		        OperatorID = value.OperatorID,
		        CountryID = value.CountryID,
		        CurrencyID = value.CurrencyID,
		        VipGrade = value.VipGrade,
		        RewardAmount = value.RewardAmount,
		        RewardType = value.RewardType,
		        FlowMultip = value.FlowMultip,
		        RewardDate = value.RewardDate,
		        NotifyStatus = value.NotifyStatus,
		        ReceiveStatus = value.ReceiveStatus,
		        RecDate = value.RecDate,
            };
        }
        public static implicit operator Sc_vip_reward_detailPO(Sc_vip_reward_detailEO value)
        {
            if (value==null) return null;
            return new Sc_vip_reward_detailPO
            {
		        DetailID = value.DetailID,
		        UserID = value.UserID,
		        UserKind = value.UserKind,
		        FromId = value.FromId,
		        FromMode = value.FromMode,
		        OperatorID = value.OperatorID,
		        CountryID = value.CountryID,
		        CurrencyID = value.CurrencyID,
		        VipGrade = value.VipGrade,
		        RewardAmount = value.RewardAmount,
		        RewardType = value.RewardType,
		        FlowMultip = value.FlowMultip,
		        RewardDate = value.RewardDate,
		        NotifyStatus = value.NotifyStatus,
		        ReceiveStatus = value.ReceiveStatus,
		        RecDate = value.RecDate,
            };
        }
        #endregion
    }
}