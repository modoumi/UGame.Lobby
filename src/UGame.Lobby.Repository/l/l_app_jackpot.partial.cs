using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class L_app_jackpotPO
    {
        #region AiUo
        public static implicit operator L_app_jackpotEO(L_app_jackpotPO value)
        {
            if (value==null) return null;
            return new L_app_jackpotEO
            {
		        AppID = value.AppID,
		        CountryId = value.CountryId,
		        OperatorID = value.OperatorID,
		        CurrencyID = value.CurrencyID,
		        SourceField = value.SourceField,
		        SourceTable = value.SourceTable,
		        Jackpot = value.Jackpot,
            };
        }
        public static implicit operator L_app_jackpotPO(L_app_jackpotEO value)
        {
            if (value==null) return null;
            return new L_app_jackpotPO
            {
		        AppID = value.AppID,
		        CountryId = value.CountryId,
		        OperatorID = value.OperatorID,
		        CurrencyID = value.CurrencyID,
		        SourceField = value.SourceField,
		        SourceTable = value.SourceTable,
		        Jackpot = value.Jackpot,
            };
        }
        #endregion
    }
}