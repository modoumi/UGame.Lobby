using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class Sm_messagePO
    {
        #region AiUo
        public static implicit operator Sm_messageEO(Sm_messagePO value)
        {
            if (value==null) return null;
            return new Sm_messageEO
            {
		        MessageID = value.MessageID,
		        SenderID = value.SenderID,
		        Type = value.Type,
		        State = value.State,
		        RecDate = value.RecDate,
		        UpdateTime = value.UpdateTime,
		        RewardID = value.RewardID,
            };
        }
        public static implicit operator Sm_messagePO(Sm_messageEO value)
        {
            if (value==null) return null;
            return new Sm_messagePO
            {
		        MessageID = value.MessageID,
		        SenderID = value.SenderID,
		        Type = value.Type,
		        State = value.State,
		        RecDate = value.RecDate,
		        UpdateTime = value.UpdateTime,
		        RewardID = value.RewardID,
            };
        }
        #endregion
    }
}