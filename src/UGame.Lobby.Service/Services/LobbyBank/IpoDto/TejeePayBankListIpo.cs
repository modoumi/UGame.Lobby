

using UGame.Lobby.Common.Enum;
using System.Text.Json.Serialization;

namespace UGame.Lobby.Service.Services.LobbyBank.IpoDto
{
    public class ChannelBankListIpo : LobbyBaseIpo
    {

        /// <summary>
        /// 支付渠道枚举
        /// </summary>
        [JsonIgnore]
        public BraPayChannel BraPayChannel { get; set; }
    }
}
