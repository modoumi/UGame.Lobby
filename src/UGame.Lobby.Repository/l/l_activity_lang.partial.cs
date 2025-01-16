using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class L_activity_langPO
    {
        #region AiUo
        public static implicit operator L_activity_langEO(L_activity_langPO value)
        {
            if (value==null) return null;
            return new L_activity_langEO
            {
		        ActivityID = value.ActivityID,
		        OperatorID = value.OperatorID,
		        LangID = value.LangID,
		        Kind = value.Kind,
		        Title = value.Title,
		        Img1 = value.Img1,
		        Img2 = value.Img2,
		        Img3 = value.Img3,
		        Img4 = value.Img4,
		        Img5 = value.Img5,
		        Mode = value.Mode,
		        Content = value.Content,
		        LinkUrl = value.LinkUrl,
		        IndexNologinLinkUrl = value.IndexNologinLinkUrl,
		        IndexloginLinkUrl = value.IndexloginLinkUrl,
		        OrderNum = value.OrderNum,
		        BeginDate = value.BeginDate,
		        EndDate = value.EndDate,
		        Status = value.Status,
            };
        }
        public static implicit operator L_activity_langPO(L_activity_langEO value)
        {
            if (value==null) return null;
            return new L_activity_langPO
            {
		        ActivityID = value.ActivityID,
		        OperatorID = value.OperatorID,
		        LangID = value.LangID,
		        Kind = value.Kind,
		        Title = value.Title,
		        Img1 = value.Img1,
		        Img2 = value.Img2,
		        Img3 = value.Img3,
		        Img4 = value.Img4,
		        Img5 = value.Img5,
		        Mode = value.Mode,
		        Content = value.Content,
		        LinkUrl = value.LinkUrl,
		        IndexNologinLinkUrl = value.IndexNologinLinkUrl,
		        IndexloginLinkUrl = value.IndexloginLinkUrl,
		        OrderNum = value.OrderNum,
		        BeginDate = value.BeginDate,
		        EndDate = value.EndDate,
		        Status = value.Status,
            };
        }
        #endregion
    }
}