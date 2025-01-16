using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class Sm_message_detailPO
    {
        #region AiUo
        public static implicit operator Sm_message_detailEO(Sm_message_detailPO value)
        {
            if (value==null) return null;
            return new Sm_message_detailEO
            {
		        DetailID = value.DetailID,
		        MessageID = value.MessageID,
		        UserID = value.UserID,
		        Flag = value.Flag,
		        RecDate = value.RecDate,
		        UpdateTime = value.UpdateTime,
		        State = value.State,
            };
        }
        public static implicit operator Sm_message_detailPO(Sm_message_detailEO value)
        {
            if (value==null) return null;
            return new Sm_message_detailPO
            {
		        DetailID = value.DetailID,
		        MessageID = value.MessageID,
		        UserID = value.UserID,
		        Flag = value.Flag,
		        RecDate = value.RecDate,
		        UpdateTime = value.UpdateTime,
		        State = value.State,
            };
        }
        #endregion
    }
}