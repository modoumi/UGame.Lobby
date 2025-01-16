using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class Sm_message_extendPO
    {
        #region AiUo
        public static implicit operator Sm_message_extendEO(Sm_message_extendPO value)
        {
            if (value==null) return null;
            return new Sm_message_extendEO
            {
		        ExtendID = value.ExtendID,
		        MessageID = value.MessageID,
		        LangID = value.LangID,
		        Title = value.Title,
		        Content = value.Content,
		        RecDate = value.RecDate,
		        UpdateTime = value.UpdateTime,
		        ImgURL = value.ImgURL,
		        HyperLink = value.HyperLink,
		        ExpireTime = value.ExpireTime,
		        Remark = value.Remark,
            };
        }
        public static implicit operator Sm_message_extendPO(Sm_message_extendEO value)
        {
            if (value==null) return null;
            return new Sm_message_extendPO
            {
		        ExtendID = value.ExtendID,
		        MessageID = value.MessageID,
		        LangID = value.LangID,
		        Title = value.Title,
		        Content = value.Content,
		        RecDate = value.RecDate,
		        UpdateTime = value.UpdateTime,
		        ImgURL = value.ImgURL,
		        HyperLink = value.HyperLink,
		        ExpireTime = value.ExpireTime,
		        Remark = value.Remark,
            };
        }
        #endregion
    }
}