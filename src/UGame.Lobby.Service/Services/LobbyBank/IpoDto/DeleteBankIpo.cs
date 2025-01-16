using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.AspNet;

namespace UGame.Lobby.Service.Services.LobbyBank.IpoDto
{
    public class DeleteBankIpo : LobbyBaseIpo
    {
        /// <summary>
        /// 
        /// </summary>
        [RequiredEx("", "UserBankId cannot be empty.")]
        public string UserBankId { get; set; }
    }
}
