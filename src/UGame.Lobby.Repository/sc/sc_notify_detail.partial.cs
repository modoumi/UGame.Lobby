using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class Sc_notify_detailPO
    {
        #region AiUo
        public static implicit operator Sc_notify_detailEO(Sc_notify_detailPO value)
        {
            if (value==null) return null;
            return new Sc_notify_detailEO
            {
		        NotifyID = value.NotifyID,
		        LangID = value.LangID,
		        Title = value.Title,
		        ImageUrl = value.ImageUrl,
		        Content = value.Content,
		        LinkKind = value.LinkKind,
		        LinkUrl = value.LinkUrl,
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
        public static implicit operator Sc_notify_detailPO(Sc_notify_detailEO value)
        {
            if (value==null) return null;
            return new Sc_notify_detailPO
            {
		        NotifyID = value.NotifyID,
		        LangID = value.LangID,
		        Title = value.Title,
		        ImageUrl = value.ImageUrl,
		        Content = value.Content,
		        LinkKind = value.LinkKind,
		        LinkUrl = value.LinkUrl,
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