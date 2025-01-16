using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class Sa_invite100013_detailPO
    {
        #region AiUo
        public static implicit operator Sa_invite100013_detailEO(Sa_invite100013_detailPO value)
        {
            if (value==null) return null;
            return new Sa_invite100013_detailEO
            {
		        DetailID = value.DetailID,
		        UserID = value.UserID,
		        ConfigID = value.ConfigID,
		        OperatorID = value.OperatorID,
		        CountryID = value.CountryID,
		        CurrencyID = value.CurrencyID,
		        Bonus = value.Bonus,
		        FlowMultip = value.FlowMultip,
		        ReceiveStatus = value.ReceiveStatus,
		        RecDate = value.RecDate,
            };
        }
        public static implicit operator Sa_invite100013_detailPO(Sa_invite100013_detailEO value)
        {
            if (value==null) return null;
            return new Sa_invite100013_detailPO
            {
		        DetailID = value.DetailID,
		        UserID = value.UserID,
		        ConfigID = value.ConfigID,
		        OperatorID = value.OperatorID,
		        CountryID = value.CountryID,
		        CurrencyID = value.CurrencyID,
		        Bonus = value.Bonus,
		        FlowMultip = value.FlowMultip,
		        ReceiveStatus = value.ReceiveStatus,
		        RecDate = value.RecDate,
            };
        }
        #endregion
    }
}