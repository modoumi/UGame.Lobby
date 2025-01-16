using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class L_notify_detailPO
    {
        #region AiUo
        public static implicit operator L_notify_detailEO(L_notify_detailPO value)
        {
            if (value==null) return null;
            return new L_notify_detailEO
            {
		        NotifyID = value.NotifyID,
		        LangID = value.LangID,
		        Title = value.Title,
		        Content = value.Content,
		        Txt1 = value.Txt1,
		        Txt2 = value.Txt2,
		        Txt3 = value.Txt3,
		        Txt4 = value.Txt4,
		        Txt5 = value.Txt5,
		        Img1 = value.Img1,
		        Img2 = value.Img2,
		        Img3 = value.Img3,
		        Img4 = value.Img4,
		        Img5 = value.Img5,
            };
        }
        public static implicit operator L_notify_detailPO(L_notify_detailEO value)
        {
            if (value==null) return null;
            return new L_notify_detailPO
            {
		        NotifyID = value.NotifyID,
		        LangID = value.LangID,
		        Title = value.Title,
		        Content = value.Content,
		        Txt1 = value.Txt1,
		        Txt2 = value.Txt2,
		        Txt3 = value.Txt3,
		        Txt4 = value.Txt4,
		        Txt5 = value.Txt5,
		        Img1 = value.Img1,
		        Img2 = value.Img2,
		        Img3 = value.Img3,
		        Img4 = value.Img4,
		        Img5 = value.Img5,
            };
        }
        #endregion
    }
}