using UGame.Lobby.Repository.ing;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using AiUo.AspNet;
using AiUo.Extensions.AutoMapper;

namespace UGame.Lobby.Service.Services.Activity.Signin
{
    public class SigninBannerIpo : LobbyBaseIpo
    {
        /// <summary>
        /// 应用编码
        /// </summary>
        [RequiredEx("", "AppId cannot be empty.")]
        public string AppId { get; set; }
    }

    public class SigninBannerDto:IMapFrom<Sa_signin_bannerEO>
    {
      
        public string BannerID { get; set; }
     
        public string Title { get; set; }
     
        public string Summary { get; set; }
    
        public string PicPath { get; set; }
       
        public int? Status { get; set; }
   
        public int? Index { get; set; }

        public int? Type { get; set; }

        public string GoPage { get; set; }
    
        public DateTime? RecDate { get; set; }
      
        public string OperatorID { get; set; }
 
        public string CountryID { get; set; }
    
        public string CurrencyID { get; set; }

        public void MapFrom(Sa_signin_bannerEO source)
        {
            //throw new NotImplementedException();
        }
    }
}
