using UGame.Lobby.Repository.ing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Extensions.AutoMapper;

namespace UGame.Lobby.Service.Services.Activity.Roulette
{
    public class RouletteUserIpo : LobbyBaseIpo
    {

    }

    public class RouletteUserDto : IMapFrom<Sa_roulette_userEO>
    { 
        /// <summary>
        /// 用户编码
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// 剩余freespin次数
        /// </summary>
        public int Freespin { get; set; }

        /// <summary>
        /// 当前freespin轮数
        /// </summary>
        public int FreespinRound { get; set; }

        public void MapFrom(Sa_roulette_userEO source)
        {
            
        }
    }
}
