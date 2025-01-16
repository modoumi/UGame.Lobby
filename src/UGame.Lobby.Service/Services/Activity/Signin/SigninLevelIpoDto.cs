using UGame.Lobby.Repository.ing;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using AiUo.Extensions.AutoMapper;

namespace UGame.Lobby.Service.Services.Activity.Signin
{
    public class SigninLevelIpo : LobbyBaseIpo
    {

    }

    public class SigninLevelDto : IMapFrom<Sa_signin_levelEO>
    {

        public int LevelID { get; set; }

        public string PicPath { get; set; }

        public string Name { get; set; }

        public int MinMoney { get; set; }

        public int MaxMoney { get; set; }

        public int PetMoney { get; set; }

        public int Index { get; set; }

        public int Level { get; set; } = 0;

        public int Days { get; set; } = 0;

        public void MapFrom(Sa_signin_levelEO source)
        {

        }
    }
}
