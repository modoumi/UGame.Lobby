using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    ///<summary>
    ///好友邀请分享，奖励明细表
    ///</summary>
    [SugarTable("sa_invite100013_detail")]
    public partial class Sa_invite100013_detailPO
    {
           public Sa_invite100013_detailPO(){

            this.Bonus =0;
            this.FlowMultip =0.00f;
            this.ReceiveStatus =false;
            this.RecDate =DateTime.Now;

           }
           /// <summary>
           /// Desc:奖励明细ID，主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string DetailID {get;set;}

           /// <summary>
           /// Desc:用户编码（邀请人）
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string UserID {get;set;}

           /// <summary>
           /// Desc:sa_invitenum100013_config.ConfigID奖励配置ID,保证每条配置只能奖励一次
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ConfigID {get;set;}

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
           /// Desc:奖励金额
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long Bonus {get;set;}

           /// <summary>
           /// Desc:流水倍率
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public float FlowMultip {get;set;}

           /// <summary>
           /// Desc:奖励领取状态
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public bool ReceiveStatus {get;set;}

           /// <summary>
           /// Desc:记录时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime RecDate {get;set;}

    }
}
