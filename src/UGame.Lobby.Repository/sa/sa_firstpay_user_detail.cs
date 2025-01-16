using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    ///<summary>
    ///新用户首充50%奖励活动用户充值详情
    ///</summary>
    [SugarTable("sa_firstpay_user_detail")]
    public partial class Sa_firstpay_user_detailPO
    {
           public Sa_firstpay_user_detailPO(){

            this.PayAmount =0;
            this.BonusAmount =0;
            this.RemainTimes =0;
            this.NotifyStatus =0;
            this.ReceiveStatus =0;
            this.OrderId ="";
            this.RecDate =DateTime.Now;

           }
           /// <summary>
           /// Desc:主键ID
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
           /// Desc:充值金额
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long PayAmount {get;set;}

           /// <summary>
           /// Desc:获得赠金金额
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long BonusAmount {get;set;}

           /// <summary>
           /// Desc:剩余次数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int RemainTimes {get;set;}

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
           /// Desc:充值订单号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string OrderId {get;set;}

           /// <summary>
           /// Desc:记录创建时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime RecDate {get;set;}

    }
}
