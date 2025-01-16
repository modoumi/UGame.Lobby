using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class Sb_bank_paytype_channelPO
    {
        #region AiUo
        public static implicit operator Sb_bank_paytype_channelEO(Sb_bank_paytype_channelPO value)
        {
            if (value==null) return null;
            return new Sb_bank_paytype_channelEO
            {
		        BankID = value.BankID,
		        PaytypeID = value.PaytypeID,
		        PaytypeChannel = value.PaytypeChannel,
		        ChannelName = value.ChannelName,
            };
        }
        public static implicit operator Sb_bank_paytype_channelPO(Sb_bank_paytype_channelEO value)
        {
            if (value==null) return null;
            return new Sb_bank_paytype_channelPO
            {
		        BankID = value.BankID,
		        PaytypeID = value.PaytypeID,
		        PaytypeChannel = value.PaytypeChannel,
		        ChannelName = value.ChannelName,
            };
        }
        #endregion
    }
}