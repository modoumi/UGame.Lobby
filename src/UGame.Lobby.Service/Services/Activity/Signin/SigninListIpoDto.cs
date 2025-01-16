using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UGame.Lobby.Service.Services.Activity.Signin
{
    public class SigninListIpo : LobbyBaseIpo
    {
        [Required]
        public string BannerID { get; set; }

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
    }

    public class SigninListDto
    {
        public DateTime currentDate
        { 
            get; 
            set; 
        }
        public List<SignRecord> signlist { get; set; } = new List<SignRecord>();
    }

    public class SignRecord
    {
        public SignRecord(DateTime DayId,  bool Flag, long amount,int level)
        {
            this.DayId = DayId;
            this.Flag = Flag;
            Amount = amount;
            this.Level = level;
        }
        public SignRecord() { }
        public DateTime DayId { get; set; }
        public bool Flag { get; set; }
        public long Amount { get; set; }

        public int Level { get; set; }

        public string RecordId { get; set; }
    }
}
