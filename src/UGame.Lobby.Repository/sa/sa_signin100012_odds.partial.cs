using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class Sa_signin100012_oddsPO
    {
        #region AiUo
        public static implicit operator Sa_signin100012_oddsEO(Sa_signin100012_oddsPO value)
        {
            if (value==null) return null;
            return new Sa_signin100012_oddsEO
            {
		        ConfigID = value.ConfigID,
		        OperatorID = value.OperatorID,
		        CurrencyID = value.CurrencyID,
		        CountryId = value.CountryId,
		        Reward = value.Reward,
		        Odds = value.Odds,
		        DateNumber = value.DateNumber,
		        IsStartDay = value.IsStartDay,
            };
        }
        public static implicit operator Sa_signin100012_oddsPO(Sa_signin100012_oddsEO value)
        {
            if (value==null) return null;
            return new Sa_signin100012_oddsPO
            {
		        ConfigID = value.ConfigID,
		        OperatorID = value.OperatorID,
		        CurrencyID = value.CurrencyID,
		        CountryId = value.CountryId,
		        Reward = value.Reward,
		        Odds = value.Odds,
		        DateNumber = value.DateNumber,
		        IsStartDay = value.IsStartDay,
            };
        }
        #endregion
    }
}