using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    ///<summary>
    ///幸运轮盘抽奖明细
    ///</summary>
    [SugarTable("sa_roulette_detail")]
    public partial class Sa_roulette_detailPO
    {
           public Sa_roulette_detailPO(){

            this.DetailType =0;
            this.PlanBet =0;
            this.Amount =0;
            this.Freespin =0;
            this.IsFreespin =false;
            this.FreespinNum =0;
            this.RaffleType =0;
            this.UserType =0;
            this.Level =0;
            this.RewardType =0;
            this.PreRewardType =0;
            this.Position =0;
            this.Multiple =0f;
            this.Bonus =0;
            this.Status =0;
            this.RecDate =DateTime.Now;

           }
           /// <summary>
           /// Desc:主键GUID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string DetailID {get;set;}

           /// <summary>
           /// Desc:用户编码guid
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string UserID {get;set;}

           /// <summary>
           /// Desc:手机号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Mobile {get;set;}

           /// <summary>
           /// Desc:运营商编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string OperatorID {get;set;}

           /// <summary>
           /// Desc:货币类型
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string CurrencyID {get;set;}

           /// <summary>
           /// Desc:1-注册赠送2-首充赠送3-下注
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int DetailType {get;set;}

           /// <summary>
           /// Desc:计划下注数量
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long PlanBet {get;set;}

           /// <summary>
           /// Desc:实际账户变化数量（正负数）
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long Amount {get;set;}

           /// <summary>
           /// Desc:注册、首充赠送freespin次数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Freespin {get;set;}

           /// <summary>
           /// Desc:是否为freespin
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public bool IsFreespin {get;set;}

           /// <summary>
           /// Desc:freespin剩余数量
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int FreespinNum {get;set;}

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
           /// Desc:位置
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Position {get;set;}

           /// <summary>
           /// Desc:倍率
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public float Multiple {get;set;}

           /// <summary>
           /// Desc:奖金
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long Bonus {get;set;}

           /// <summary>
           /// Desc:状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Status {get;set;}

           /// <summary>
           /// Desc:记录时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime RecDate {get;set;}

    }
}
