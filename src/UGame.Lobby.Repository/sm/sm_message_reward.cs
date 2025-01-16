using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("sm_message_reward")]
    public partial class Sm_message_rewardPO
    {
           public Sm_message_rewardPO(){

            this.Amount =0.00m;
            this.LeastPayAmount =0;
            this.FlowMultip =0.00f;
            this.RecDate =DateTime.Now;
            this.RewardType =0;
            this.ActivityType =0;

           }
           /// <summary>
           /// Desc:编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string RewardID {get;set;}

           /// <summary>
           /// Desc:奖励金额
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal Amount {get;set;}

           /// <summary>
           /// Desc:送赠金的最少充值金额
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long LeastPayAmount {get;set;}

           /// <summary>
           /// Desc:赠金提现所需要的流水倍数
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public float FlowMultip {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime RecDate {get;set;}

           /// <summary>
           /// Desc:奖励类型1后台发送2活动发送
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int RewardType {get;set;}

           /// <summary>
           /// Desc:活动类型
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int ActivityType {get;set;}

           /// <summary>
           /// Desc:活动编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? ActivityID {get;set;}

           /// <summary>
           /// Desc:source类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? SourceType {get;set;}

           /// <summary>
           /// Desc:source表名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? SourceTable {get;set;}

           /// <summary>
           /// Desc:source表ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? SourceId {get;set;}

           /// <summary>
           /// Desc:1bouns2真金
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? AmountType {get;set;}

    }
}
