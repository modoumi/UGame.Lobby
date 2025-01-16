using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class Sa_notify_templatePO
    {
        #region AiUo
        public static implicit operator Sa_notify_templateEO(Sa_notify_templatePO value)
        {
            if (value==null) return null;
            return new Sa_notify_templateEO
            {
		        TempID = value.TempID,
		        OperatorID = value.OperatorID,
		        CountryId = value.CountryId,
		        CurrencyID = value.CurrencyID,
		        LangID = value.LangID,
		        NotifyType = value.NotifyType,
		        ActivityType = value.ActivityType,
		        Title = value.Title,
		        Img1 = value.Img1,
		        Img2 = value.Img2,
		        Img3 = value.Img3,
		        Img4 = value.Img4,
		        Img5 = value.Img5,
		        Mode = value.Mode,
		        Content = value.Content,
		        LinkUrl = value.LinkUrl,
		        Status = value.Status,
            };
        }
        public static implicit operator Sa_notify_templatePO(Sa_notify_templateEO value)
        {
            if (value==null) return null;
            return new Sa_notify_templatePO
            {
		        TempID = value.TempID,
		        OperatorID = value.OperatorID,
		        CountryId = value.CountryId,
		        CurrencyID = value.CurrencyID,
		        LangID = value.LangID,
		        NotifyType = value.NotifyType,
		        ActivityType = value.ActivityType,
		        Title = value.Title,
		        Img1 = value.Img1,
		        Img2 = value.Img2,
		        Img3 = value.Img3,
		        Img4 = value.Img4,
		        Img5 = value.Img5,
		        Mode = value.Mode,
		        Content = value.Content,
		        LinkUrl = value.LinkUrl,
		        Status = value.Status,
            };
        }
        #endregion
    }
}