using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    ///<summary>
    ///好友邀请分享用户关系表
    ///</summary>
    [SugarTable("sa_invite100013_user")]
    public partial class Sa_invite100013_userPO
    {
           public Sa_invite100013_userPO(){

            this.POperatorId ="";
            this.UOperatorId ="";
            this.IsMeetPayLimit =false;
            this.UserTotalPay =0;
            this.IsMeetBetLimit =false;
            this.UserTotalBet =0;
            this.RecDate =DateTime.Now;
            this.UpdateTime =DateTime.Now;

           }
           /// <summary>
           /// Desc:邀请人用户编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string PUserID {get;set;}

           /// <summary>
           /// Desc:邀请人运营商编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string POperatorId {get;set;}

           /// <summary>
           /// Desc:被邀请人用户编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string UserID {get;set;}

           /// <summary>
           /// Desc:被邀请人运营商编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string UOperatorId {get;set;}

           /// <summary>
           /// Desc:是否达到充值要求
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public bool IsMeetPayLimit {get;set;}

           /// <summary>
           /// Desc:被邀请人累计充值
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long UserTotalPay {get;set;}

           /// <summary>
           /// Desc:是否达到下注要求
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public bool IsMeetBetLimit {get;set;}

           /// <summary>
           /// Desc:被邀请人累计下注金额
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long UserTotalBet {get;set;}

           /// <summary>
           /// Desc:记录时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime RecDate {get;set;}

           /// <summary>
           /// Desc:更新时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime UpdateTime {get;set;}

    }
}
