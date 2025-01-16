using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class L_dictsPO
    {
        #region AiUo
        public static implicit operator L_dictsEO(L_dictsPO value)
        {
            if (value==null) return null;
            return new L_dictsEO
            {
		        DictID = value.DictID,
		        Category = value.Category,
		        Title = value.Title,
		        Type = value.Type,
		        Value = value.Value,
            };
        }
        public static implicit operator L_dictsPO(L_dictsEO value)
        {
            if (value==null) return null;
            return new L_dictsPO
            {
		        DictID = value.DictID,
		        Category = value.Category,
		        Title = value.Title,
		        Type = value.Type,
		        Value = value.Value,
            };
        }
        #endregion
    }
}