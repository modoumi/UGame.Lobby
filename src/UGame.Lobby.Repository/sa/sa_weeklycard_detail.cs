using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    ///<summary>
    ///1.7版周卡奖励明细
    ///</summary>
    [SugarTable("sa_weeklycard_detail")]
    public partial class Sa_weeklycard_detailPO
    {
           public Sa_weeklycard_detailPO(){

            this.WeeklyCardType =0;
            this.Bonus =0;
            this.FlowMultip =1.00f;
            this.CurrentCycleNumber =0;
            this.RecDate =DateTime.Now;

           }
           /// <summary>
           /// Desc:领取日期
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public DateTime DayId {get;set;}

           /// <summary>
           /// Desc:用户编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string UserId {get;set;}

           /// <summary>
           /// Desc:1-100档周卡2-50档周卡
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int WeeklyCardType {get;set;}

           /// <summary>
           /// Desc:奖励金额
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long Bonus {get;set;}

           /// <summary>
           /// Desc:流水倍数
           /// Default:1.00
           /// Nullable:False
           /// </summary>           
           public float FlowMultip {get;set;}

           /// <summary>
           /// Desc:当前第几天领奖
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int CurrentCycleNumber {get;set;}

           /// <summary>
           /// Desc:周卡起始日期
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime CycleStartDate {get;set;}

           /// <summary>
           /// Desc:周卡截止日期
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime CycleEndDate {get;set;}

           /// <summary>
           /// Desc:签到时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime RecDate {get;set;}

    }
}
