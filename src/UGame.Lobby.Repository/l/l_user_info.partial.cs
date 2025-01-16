using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class L_user_infoPO
    {
        #region AiUo
        public static implicit operator L_user_infoEO(L_user_infoPO value)
        {
            if (value==null) return null;
            return new L_user_infoEO
            {
		        UserID = value.UserID,
		        OperatorID = value.OperatorID,
		        CountryID = value.CountryID,
		        CurrencyID = value.CurrencyID,
		        UserKind = value.UserKind,
		        NickName = value.NickName,
		        FirstName = value.FirstName,
		        LastName = value.LastName,
		        BirthDay = value.BirthDay,
		        IDCard = value.IDCard,
		        PhoneNumber = value.PhoneNumber,
		        Email = value.Email,
		        Address = value.Address,
		        RecDate = value.RecDate,
            };
        }
        public static implicit operator L_user_infoPO(L_user_infoEO value)
        {
            if (value==null) return null;
            return new L_user_infoPO
            {
		        UserID = value.UserID,
		        OperatorID = value.OperatorID,
		        CountryID = value.CountryID,
		        CurrencyID = value.CurrencyID,
		        UserKind = value.UserKind,
		        NickName = value.NickName,
		        FirstName = value.FirstName,
		        LastName = value.LastName,
		        BirthDay = value.BirthDay,
		        IDCard = value.IDCard,
		        PhoneNumber = value.PhoneNumber,
		        Email = value.Email,
		        Address = value.Address,
		        RecDate = value.RecDate,
            };
        }
        #endregion
    }
}