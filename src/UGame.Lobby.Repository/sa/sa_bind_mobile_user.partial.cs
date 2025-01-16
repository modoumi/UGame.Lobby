using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class Sa_bind_mobile_userPO
    {
        #region AiUo
        public static implicit operator Sa_bind_mobile_userEO(Sa_bind_mobile_userPO value)
        {
            if (value==null) return null;
            return new Sa_bind_mobile_userEO
            {
		        UserID = value.UserID,
		        OperatorID = value.OperatorID,
		        CountryId = value.CountryId,
		        CurrencyID = value.CurrencyID,
		        Bonus = value.Bonus,
		        RecDate = value.RecDate,
            };
        }
        public static implicit operator Sa_bind_mobile_userPO(Sa_bind_mobile_userEO value)
        {
            if (value==null) return null;
            return new Sa_bind_mobile_userPO
            {
		        UserID = value.UserID,
		        OperatorID = value.OperatorID,
		        CountryId = value.CountryId,
		        CurrencyID = value.CurrencyID,
		        Bonus = value.Bonus,
		        RecDate = value.RecDate,
            };
        }
        #endregion
    }
}