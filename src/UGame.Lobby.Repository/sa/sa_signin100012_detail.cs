using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    ///<summary>
    ///签到奖励明细
    ///</summary>
    [SugarTable("sa_signin100012_detail")]
    public partial class Sa_signin100012_detailPO
    {
           public Sa_signin100012_detailPO(){

            this.Reward =0;
            this.RecDate =DateTime.Now;

           }
           /// <summary>
           /// Desc:签到日期（operatorId当地时间）
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
           public string UserID {get;set;}

           /// <summary>
           /// Desc:奖励金额
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long Reward {get;set;}

           /// <summary>
           /// Desc:当前签到周期第几天
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int CurrentCycleNumber {get;set;}

           /// <summary>
           /// Desc:是否补签
           /// Default:
           /// Nullable:False
           /// </summary>           
           public bool IsMissSignin {get;set;}

           /// <summary>
           /// Desc:补签日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? MissSigninDate {get;set;}

           /// <summary>
           /// Desc:签到周期起始日期
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime SigninCycleStartDate {get;set;}

           /// <summary>
           /// Desc:签到周期截止日期
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime SigninCycleEndDate {get;set;}

           /// <summary>
           /// Desc:记录时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime RecDate {get;set;}

    }
}
