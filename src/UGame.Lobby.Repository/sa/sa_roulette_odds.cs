using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    ///<summary>
    ///幸运轮盘抽奖概率
    ///</summary>
    [SugarTable("sa_roulette_odds")]
    public partial class Sa_roulette_oddsPO
    {
           public Sa_roulette_oddsPO(){

            this.RaffleType =0;
            this.UserType =0;
            this.Level =0;
            this.RewardType =0;
            this.PreRewardType =0;
            this.Position =0;
            this.Odds =0;
            this.Multiple =0f;
            this.OrderNum =0;
            this.RecDate =DateTime.Now;

           }
           /// <summary>
           /// Desc:主键GUID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string OddsID {get;set;}

           /// <summary>
           /// Desc:运营商编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string OperatorID {get;set;}

           /// <summary>
           /// Desc:国家编码ISO 3166-1三位字母
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string CountryID {get;set;}

           /// <summary>
           /// Desc:货币类型
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string CurrencyID {get;set;}

           /// <summary>
           /// Desc:抽奖类型1-freespin2-真金
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int RaffleType {get;set;}

           /// <summary>
           /// Desc:抽奖用户类型1-新用户2-盈利用户3-亏损用户
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int UserType {get;set;}

           /// <summary>
           /// Desc:抽奖等级1-基础奖励2-二级奖励
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Level {get;set;}

           /// <summary>
           /// Desc:奖励类型1-无奖励2-真金3-二级抽奖A4-二级抽奖B
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int RewardType {get;set;}

           /// <summary>
           /// Desc:上一级奖励类型
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int PreRewardType {get;set;}

           /// <summary>
           /// Desc:奖励描述
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? RewardTypeDesc {get;set;}

           /// <summary>
           /// Desc:位置
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Position {get;set;}

           /// <summary>
           /// Desc:概率
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Odds {get;set;}

           /// <summary>
           /// Desc:倍率
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public float Multiple {get;set;}

           /// <summary>
           /// Desc:排序（从小到大）
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int OrderNum {get;set;}

           /// <summary>
           /// Desc:记录时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime RecDate {get;set;}

    }
}
