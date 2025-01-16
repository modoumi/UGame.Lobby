using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xxyy.Common;

namespace UGame.Lobby.Service.Services.Activity.Signin
{
    public class SigninPrizeIpo : LobbyBaseIpo
    {
        ///// <summary>
        ///// 本地当前时间
        ///// </summary>
        //public long Timestamp { get; set; }

        //public DateTime UTCTime
        //{
        //    get
        //    {
        //        return new DateTime(this.Timestamp, DateTimeKind.Utc);
        //    } 
        //}

        public DateTime DayId
        {
            get
            {
                return DateTime.UtcNow.ToLocalTime(this.OperatorId);
            }
        }
    }

    public class SigninPrizeDto 
    {
        public bool isMatch { get; set; }
      
        public decimal betAmount { get; set; }

        public DateTime currentDate { get; set; }
    }
}
