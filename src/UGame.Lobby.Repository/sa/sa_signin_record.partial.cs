using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class Sa_signin_recordPO
    {
        #region AiUo
        public static implicit operator Sa_signin_recordEO(Sa_signin_recordPO value)
        {
            if (value==null) return null;
            return new Sa_signin_recordEO
            {
		        RecordID = value.RecordID,
		        BannerID = value.BannerID,
		        UserID = value.UserID,
		        DayID = value.DayID,
		        Level = value.Level,
		        Flag = value.Flag,
		        RecDate = value.RecDate,
		        UpdateDate = value.UpdateDate,
		        OperatorID = value.OperatorID,
		        CountryID = value.CountryID,
		        CurrencyID = value.CurrencyID,
		        Amount = value.Amount,
            };
        }
        public static implicit operator Sa_signin_recordPO(Sa_signin_recordEO value)
        {
            if (value==null) return null;
            return new Sa_signin_recordPO
            {
		        RecordID = value.RecordID,
		        BannerID = value.BannerID,
		        UserID = value.UserID,
		        DayID = value.DayID,
		        Level = value.Level,
		        Flag = value.Flag,
		        RecDate = value.RecDate,
		        UpdateDate = value.UpdateDate,
		        OperatorID = value.OperatorID,
		        CountryID = value.CountryID,
		        CurrencyID = value.CurrencyID,
		        Amount = value.Amount,
            };
        }
        #endregion
    }
}