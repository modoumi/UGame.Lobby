using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    public partial class L_pay_configPO
    {
        #region AiUo
        public static implicit operator L_pay_configEO(L_pay_configPO value)
        {
            if (value==null) return null;
            return new L_pay_configEO
            {
		        ConfigID = value.ConfigID,
		        OperatorID = value.OperatorID,
		        CountryId = value.CountryId,
		        CurrencyID = value.CurrencyID,
		        Channels = value.Channels,
		        ChannelsDesc = value.ChannelsDesc,
		        SubChannel = value.SubChannel,
		        IsEnable = value.IsEnable,
		        IsMainChannel = value.IsMainChannel,
		        ChannelsGroup = value.ChannelsGroup,
		        MinAmount = value.MinAmount,
		        MaxAmount = value.MaxAmount,
		        RecDate = value.RecDate,
            };
        }
        public static implicit operator L_pay_configPO(L_pay_configEO value)
        {
            if (value==null) return null;
            return new L_pay_configPO
            {
		        ConfigID = value.ConfigID,
		        OperatorID = value.OperatorID,
		        CountryId = value.CountryId,
		        CurrencyID = value.CurrencyID,
		        Channels = value.Channels,
		        ChannelsDesc = value.ChannelsDesc,
		        SubChannel = value.SubChannel,
		        IsEnable = value.IsEnable,
		        IsMainChannel = value.IsMainChannel,
		        ChannelsGroup = value.ChannelsGroup,
		        MinAmount = value.MinAmount,
		        MaxAmount = value.MaxAmount,
		        RecDate = value.RecDate,
            };
        }
        #endregion
    }
}