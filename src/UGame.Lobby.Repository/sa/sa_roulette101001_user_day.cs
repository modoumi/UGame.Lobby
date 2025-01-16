using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    ///<summary>
    ///1.7版抽奖轮盘抽奖用户日充值、赠送次数表
    ///</summary>
    [SugarTable("sa_roulette101001_user_day")]
    public partial class Sa_roulette101001_user_dayPO
    {
           public Sa_roulette101001_user_dayPO(){

            this.TotalPayAmount =0;
            this.SumSendNum =0;
            this.RecDate =DateTime.Now;

           }
           /// <summary>
           /// Desc:用户编码guid
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string UserID {get;set;}

           /// <summary>
           /// Desc:奖励日期
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public DateTime DayId {get;set;}

           /// <summary>
           /// Desc:当日充值总金额
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long TotalPayAmount {get;set;}

           /// <summary>
           /// Desc:轮盘赠送次数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int SumSendNum {get;set;}

           /// <summary>
           /// Desc:记录时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime RecDate {get;set;}

    }
}
