using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UGame.Lobby.Service.Services.Profile.Bra
{
    public class BraUserIpo : LobbyBaseIpo
    {
        /// <summary>
        /// 税号对应的账户名
        /// </summary>
        public string AccName { get; set; }

        /// <summary>
        /// 税号
        /// </summary>
        public string TaxId { get; set; }
    }
}
