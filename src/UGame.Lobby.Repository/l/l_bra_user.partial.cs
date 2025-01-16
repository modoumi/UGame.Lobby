using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class L_bra_userPO
    {
        #region AiUo
        public static implicit operator L_bra_userEO(L_bra_userPO value)
        {
            if (value==null) return null;
            return new L_bra_userEO
            {
		        UserID = value.UserID,
		        OperatorID = value.OperatorID,
		        CountryID = value.CountryID,
		        CurrencyID = value.CurrencyID,
		        UserKind = value.UserKind,
		        AccName = value.AccName,
		        TaxId = value.TaxId,
		        RecDate = value.RecDate,
            };
        }
        public static implicit operator L_bra_userPO(L_bra_userEO value)
        {
            if (value==null) return null;
            return new L_bra_userPO
            {
		        UserID = value.UserID,
		        OperatorID = value.OperatorID,
		        CountryID = value.CountryID,
		        CurrencyID = value.CurrencyID,
		        UserKind = value.UserKind,
		        AccName = value.AccName,
		        TaxId = value.TaxId,
		        RecDate = value.RecDate,
            };
        }
        #endregion
    }
}