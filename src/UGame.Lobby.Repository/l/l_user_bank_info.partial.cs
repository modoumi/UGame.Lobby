using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class L_user_bank_infoPO
    {
        #region AiUo
        public static implicit operator L_user_bank_infoEO(L_user_bank_infoPO value)
        {
            if (value==null) return null;
            return new L_user_bank_infoEO
            {
		        UserBankID = value.UserBankID,
		        UserID = value.UserID,
		        CountryID = value.CountryID,
		        CurrencyID = value.CurrencyID,
		        BankType = value.BankType,
		        BankCode = value.BankCode,
		        BankName = value.BankName,
		        CardNo = value.CardNo,
		        UserName = value.UserName,
		        FirstName = value.FirstName,
		        LastName = value.LastName,
		        ExpiryDate = value.ExpiryDate,
		        CVV = value.CVV,
		        PhoneNumber = value.PhoneNumber,
		        Email = value.Email,
		        State = value.State,
		        City = value.City,
		        Street = value.Street,
		        PostalCode = value.PostalCode,
		        LastUsing = value.LastUsing,
		        RecDate = value.RecDate,
		        ModifyDate = value.ModifyDate,
            };
        }
        public static implicit operator L_user_bank_infoPO(L_user_bank_infoEO value)
        {
            if (value==null) return null;
            return new L_user_bank_infoPO
            {
		        UserBankID = value.UserBankID,
		        UserID = value.UserID,
		        CountryID = value.CountryID,
		        CurrencyID = value.CurrencyID,
		        BankType = value.BankType,
		        BankCode = value.BankCode,
		        BankName = value.BankName,
		        CardNo = value.CardNo,
		        UserName = value.UserName,
		        FirstName = value.FirstName,
		        LastName = value.LastName,
		        ExpiryDate = value.ExpiryDate,
		        CVV = value.CVV,
		        PhoneNumber = value.PhoneNumber,
		        Email = value.Email,
		        State = value.State,
		        City = value.City,
		        Street = value.Street,
		        PostalCode = value.PostalCode,
		        LastUsing = value.LastUsing,
		        RecDate = value.RecDate,
		        ModifyDate = value.ModifyDate,
            };
        }
        #endregion
    }
}