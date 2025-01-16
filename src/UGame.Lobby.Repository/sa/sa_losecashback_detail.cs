using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    ///<summary>
    ///输返活动用户领取详情表
    ///</summary>
    [SugarTable("sa_losecashback_detail")]
    public partial class Sa_losecashback_detailPO
    {
           public Sa_losecashback_detailPO(){

            this.RefundAmount =0;
            this.NotifyStatus =0;
            this.ReceiveStatus =0;
            this.FlowMultip =1.00f;
            this.RecDate =DateTime.Now;

           }
           /// <summary>
           /// Desc:主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string DetailID {get;set;}

           /// <summary>
           /// Desc:用户编码(GUID)
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string UserID {get;set;}

           /// <summary>
           /// Desc:输返的日期
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime DayID {get;set;}

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
           public string? CountryID {get;set;}

           /// <summary>
           /// Desc:货币类型（货币缩写RMB,USD）
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string CurrencyID {get;set;}

           /// <summary>
           /// Desc:输返的奖励金额
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long RefundAmount {get;set;}

           /// <summary>
           /// Desc:发送通知状态，0-未通知1-已通知
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int NotifyStatus {get;set;}

           /// <summary>
           /// Desc:用户领取状态，0-未领取1-已领取
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int ReceiveStatus {get;set;}

           /// <summary>
           /// Desc:赠金提现所需要的流水倍数
           /// Default:1.00
           /// Nullable:False
           /// </summary>           
           public float FlowMultip {get;set;}

           /// <summary>
           /// Desc:记录创建时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime RecDate {get;set;}

    }
}
