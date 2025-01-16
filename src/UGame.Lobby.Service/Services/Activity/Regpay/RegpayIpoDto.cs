using UGame.Lobby.Repository.ing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using AiUo.AspNet;
using AiUo.Extensions.AutoMapper;
using Xxyy.Common;
using Xxyy.DAL;

namespace UGame.Lobby.Service.Services.Activity.Regpay
{

    /// <summary>
    /// 获取充值、首充活动用户ipo
    /// </summary>
    public class RegpayUserIpo : LobbyBaseIpo
    {

        

    }

    /// <summary>
    /// 获取充值、首充活动用户dto
    /// </summary>
    public class RegpayUserDto : IMapFrom<Sa_regpay_userEO>
    {
        public string UserId { get; set; }

        public string OperatorId { get; set; }

        public string CountryId { get; set; }

        public string CurrencyId { get; set; }

        public decimal SumPay { get; set; }

        public decimal RegPay { get; set; }

        public decimal FirstPay { get; set; }

        public decimal SumBet { get; set; }


        public decimal ReturnRewards { get; set; }

        public bool IsRegpay { get; set; }

        public bool IsFirstPay { get; set; }

        public decimal BetAmount { get; set; }

        public void MapFrom(Sa_regpay_userEO source)
        {
            this.SumPay = Math.Round(source.SumPay.AToM(source.CurrencyID), 2, MidpointRounding.ToZero);
            this.RegPay = Math.Round(source.RegPay.AToM(source.CurrencyID), 2, MidpointRounding.ToZero);
            this.FirstPay = Math.Round(source.FirstPay.AToM(source.CurrencyID), 2, MidpointRounding.ToZero);
            this.SumBet = Math.Round(source.SumBet.AToM(source.CurrencyID), 2, MidpointRounding.ToZero);
            this.ReturnRewards = Math.Round(source.ReturnRewards.AToM(source.CurrencyID), 2, MidpointRounding.ToZero);
        }
    }

    /// <summary>
    /// 获取充值、首充活动奖励记录ipo
    /// </summary>
    public class RegpayDetailsIpo : LobbyBaseIpo
    { 
        
    }

    /// <summary>
    /// 获取充值、首充活动奖励记录dto
    /// </summary>
    public class RegpayDetailsDto : IMapFrom<Sa_regpay_detailEO>
    {
        [JsonIgnore]
        public string UserId { get; set; }
        [JsonIgnore]
        public string OperatorId { get; set; }
        [JsonIgnore]
        public string CountryId { get; set; }
        [JsonIgnore]
        public string CurrencyId { get; set; }

        public decimal RewardMoney { get; set; }

        public string Mobile { get; set; }

        public string UserName { get; set; }

        public void MapFrom(Sa_regpay_detailEO source)
        {
            this.RewardMoney = Math.Round(source.RewardAmount.AToM(source.CurrencyID), 2, MidpointRounding.ToZero);
        }
    }

    /// <summary>
    /// 领取充值、首充奖金ipo
    /// </summary>
    public class RegpayReceiveBonusIpo : LobbyBaseIpo
    {
        /// <summary>
        /// 应用编码
        /// </summary>
        [RequiredEx("", "AppId cannot be empty.")]
        public string AppId { get; set; }
    }

    /// <summary>
    /// 领取充值、首充奖金dto
    /// </summary>
    public class RegpayReceiveBonusDto
    { 
        /// <summary>
        /// 
        /// </summary>
        public bool success { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string message { get; set; }
    }


    public class RegpayGamesIpo : LobbyBaseIpo 
    {
        
    }



    public class RegpayFirstDto
    {
        /// <summary>
        /// 
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Message { get; set; }
    }


    public class RegpayBetDto
    {
        /// <summary>
        /// 
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Message { get; set; }
    }

}
