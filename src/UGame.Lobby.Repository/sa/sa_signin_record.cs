using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("sa_signin_record")]
    public partial class Sa_signin_recordPO
    {
           public Sa_signin_recordPO(){

            this.RecordID ="0";
            this.Level =1;
            this.Amount =0;

           }
           /// <summary>
           /// Desc:编号
           /// Default:0
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string RecordID {get;set;}

           /// <summary>
           /// Desc:banner编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? BannerID {get;set;}

           /// <summary>
           /// Desc:用户编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? UserID {get;set;}

           /// <summary>
           /// Desc:签到时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? DayID {get;set;}

           /// <summary>
           /// Desc:等级
           /// Default:1
           /// Nullable:True
           /// </summary>           
           public int? Level {get;set;}

           /// <summary>
           /// Desc:签到状态
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? Flag {get;set;}

           /// <summary>
           /// Desc:签到时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? RecDate {get;set;}

           /// <summary>
           /// Desc:获取奖励时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? UpdateDate {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? OperatorID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? CountryID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? CurrencyID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long Amount {get;set;}

    }
}
