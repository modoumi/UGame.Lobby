using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class Sc_templPO
    {
        #region AiUo
        public static implicit operator Sc_templEO(Sc_templPO value)
        {
            if (value==null) return null;
            return new Sc_templEO
            {
		        SCTemplateID = value.SCTemplateID,
		        TemplateType = value.TemplateType,
		        Title = value.Title,
		        ParamsTypeName = value.ParamsTypeName,
		        ParamsNameSpace = value.ParamsNameSpace,
		        Note = value.Note,
            };
        }
        public static implicit operator Sc_templPO(Sc_templEO value)
        {
            if (value==null) return null;
            return new Sc_templPO
            {
		        SCTemplateID = value.SCTemplateID,
		        TemplateType = value.TemplateType,
		        Title = value.Title,
		        ParamsTypeName = value.ParamsTypeName,
		        ParamsNameSpace = value.ParamsNameSpace,
		        Note = value.Note,
            };
        }
        #endregion
    }
}