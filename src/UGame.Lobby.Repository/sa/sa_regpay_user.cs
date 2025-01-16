using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    ///<summary>
    ///用户注册、首充奖励基础数据表（每个用户只可能存在一条记录）
    ///</summary>
    [SugarTable("sa_regpay_user")]
    public partial class Sa_regpay_userPO
    {
           public Sa_regpay_userPO(){

            this.SumPay =0;
            this.RegPay =0;
            this.FirstPay =0;
            this.RegPayReward =0;
            this.FirstPayReward =0;
            this.SumBet =0;
            this.ReturnRewards =0;
            this.IsRegPay =false;
            this.IsFirstPay =false;
            this.RecDate =DateTime.Now;

           }
           /// <summary>
           /// Desc:用户编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string UserID {get;set;}

           /// <summary>
           /// Desc:运营商编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string OperatorID {get;set;}

           /// <summary>
           /// Desc:国家编码ISO 3166-1三位字母
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? CountryId {get;set;}

           /// <summary>
           /// Desc:货币类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? CurrencyID {get;set;}

           /// <summary>
           /// Desc:奖金总额
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long SumPay {get;set;}

           /// <summary>
           /// Desc:注册奖金
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long RegPay {get;set;}

           /// <summary>
           /// Desc:首充奖金
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long FirstPay {get;set;}

           /// <summary>
           /// Desc:注册奖金发放总金额
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long RegPayReward {get;set;}

           /// <summary>
           /// Desc:首充奖金发放总金额
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long FirstPayReward {get;set;}

           /// <summary>
           /// Desc:未发放奖励的下注总额
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long SumBet {get;set;}

           /// <summary>
           /// Desc:当前应获得奖励金额
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long ReturnRewards {get;set;}

           /// <summary>
           /// Desc:是否发放过注册奖励
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public bool IsRegPay {get;set;}

           /// <summary>
           /// Desc:是否发放过首充奖励
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public bool IsFirstPay {get;set;}

           /// <summary>
           /// Desc:记录时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime RecDate {get;set;}

    }
}
