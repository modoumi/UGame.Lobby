using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class Sm_message_rewardPO
    {
        #region AiUo
        public static implicit operator Sm_message_rewardEO(Sm_message_rewardPO value)
        {
            if (value==null) return null;
            return new Sm_message_rewardEO
            {
		        RewardID = value.RewardID,
		        Amount = value.Amount,
		        LeastPayAmount = value.LeastPayAmount,
		        FlowMultip = value.FlowMultip,
		        RecDate = value.RecDate,
		        RewardType = value.RewardType,
		        ActivityType = value.ActivityType,
		        ActivityID = value.ActivityID,
		        SourceType = value.SourceType,
		        SourceTable = value.SourceTable,
		        SourceId = value.SourceId,
		        AmountType = value.AmountType,
            };
        }
        public static implicit operator Sm_message_rewardPO(Sm_message_rewardEO value)
        {
            if (value==null) return null;
            return new Sm_message_rewardPO
            {
		        RewardID = value.RewardID,
		        Amount = value.Amount,
		        LeastPayAmount = value.LeastPayAmount,
		        FlowMultip = value.FlowMultip,
		        RecDate = value.RecDate,
		        RewardType = value.RewardType,
		        ActivityType = value.ActivityType,
		        ActivityID = value.ActivityID,
		        SourceType = value.SourceType,
		        SourceTable = value.SourceTable,
		        SourceId = value.SourceId,
		        AmountType = value.AmountType,
            };
        }
        #endregion
    }
}