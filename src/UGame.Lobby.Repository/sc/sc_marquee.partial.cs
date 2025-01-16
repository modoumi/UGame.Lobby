using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class Sc_marqueePO
    {
        #region AiUo
        public static implicit operator Sc_marqueeEO(Sc_marqueePO value)
        {
            if (value==null) return null;
            return new Sc_marqueeEO
            {
		        MarqueeID = value.MarqueeID,
		        AppID = value.AppID,
		        Position = value.Position,
		        OperatorID = value.OperatorID,
		        SCTemplateID = value.SCTemplateID,
		        SCTemplateParams = value.SCTemplateParams,
		        LinkUrl = value.LinkUrl,
		        Status = value.Status,
		        Flag = value.Flag,
		        MarqueeType = value.MarqueeType,
		        RecDate = value.RecDate,
            };
        }
        public static implicit operator Sc_marqueePO(Sc_marqueeEO value)
        {
            if (value==null) return null;
            return new Sc_marqueePO
            {
		        MarqueeID = value.MarqueeID,
		        AppID = value.AppID,
		        Position = value.Position,
		        OperatorID = value.OperatorID,
		        SCTemplateID = value.SCTemplateID,
		        SCTemplateParams = value.SCTemplateParams,
		        LinkUrl = value.LinkUrl,
		        Status = value.Status,
		        Flag = value.Flag,
		        MarqueeType = value.MarqueeType,
		        RecDate = value.RecDate,
            };
        }
        #endregion
    }
}