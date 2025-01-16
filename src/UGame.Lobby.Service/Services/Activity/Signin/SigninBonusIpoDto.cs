using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xxyy.Common;

namespace UGame.Lobby.Service.Services.Activity.Signin
{
    public class SigninBonusDto
    {
        /// <summary>
        /// -1 获取下注金额出错  
        /// 0 没有签到  
        /// 1 已经签到 但是没领取奖励  
        /// 2 已经签到 已经领取过奖励
        /// </summary>
        public int Status { get; set; }

        public bool Success { get; set; }

        public string Message { get; set; }

        public long RewardAmount { get; set; }

        public long PettingAmount { get; set; }

        public DateTime SignTime { get; set; }
    }

    public class SigninBonusIpo : LobbyBaseIpo
    {
        ///// <summary>
        ///// 本地的时间戳
        ///// </summary>
        //public string Timestamp { get; set; }

        //public DateTime UTCTime
        //{
        //    get
        //    {
        //        long dt = 0;
        //        if (this.Timestamp.Length == 13)
        //        {
        //            dt = long.Parse(this.Timestamp + "0000");
        //            var s = new DateTime(new DateTime(1970, 1, 1, 8, 0, 0).Ticks + dt, DateTimeKind.Utc);
        //            return s;

        //        }
        //        else
        //        {
        //            dt = long.Parse(this.Timestamp);
        //            return new DateTime(dt, DateTimeKind.Utc);
        //        }
        //    }
        //}

        public DateTime DayId
        {
            get
            {
                return DateTime.UtcNow.ToLocalTime(this.OperatorId).Date;
            }
        }
      
        [Required]
        public string BannerID { get; set; }
    }
}
