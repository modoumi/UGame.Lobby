using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class Sc_app_currency_chipsPO
    {
        #region AiUo
        public static implicit operator Sc_app_currency_chipsEO(Sc_app_currency_chipsPO value)
        {
            if (value==null) return null;
            return new Sc_app_currency_chipsEO
            {
		        AppID = value.AppID,
		        CurrencyID = value.CurrencyID,
		        Chips = value.Chips,
            };
        }
        public static implicit operator Sc_app_currency_chipsPO(Sc_app_currency_chipsEO value)
        {
            if (value==null) return null;
            return new Sc_app_currency_chipsPO
            {
		        AppID = value.AppID,
		        CurrencyID = value.CurrencyID,
		        Chips = value.Chips,
            };
        }
        #endregion
    }
}