using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    ///<summary>
    ///邀请人首充奖励明细
    ///</summary>
    [SugarTable("sa_invite100011_detail")]
    public partial class Sa_invite100011_detailPO
    {
           public Sa_invite100011_detailPO(){

            this.RewardType =0;
            this.PUserKind =0;
            this.Bonus =0;
            this.FlowMultip =0.00f;
            this.UserKind =0;
            this.FirstPayAmount =0;
            this.RecDate =DateTime.Now;
            this.ValidUserCount =0;
            this.ReceiveStatus =false;

           }
           /// <summary>
           /// Desc:主键guid
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string DetailID {get;set;}

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
           public string CountryId {get;set;}

           /// <summary>
           /// Desc:货币类型
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string CurrencyID {get;set;}

           /// <summary>
           /// Desc:0-预留值1-首充奖励2-邀请人数奖励
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int RewardType {get;set;}

           /// <summary>
           /// Desc:邀请人
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string PUserID {get;set;}

           /// <summary>
           /// Desc:邀请人用户类型
			///                           0-未知
			///                           1-普通用户
			///                           2-开发用户
			///                           3-线上测试用户（调用第三方扣减）
			///                           4-线上测试用户（不调用第三方扣减）
			///                           5-仿真用户
			///                           6-接口联调用户
			///                           9-管理员
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int PUserKind {get;set;}

           /// <summary>
           /// Desc:邀请人奖励金额
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long Bonus {get;set;}

           /// <summary>
           /// Desc:邀请人获得奖励金额需要完成的流水倍数
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public float FlowMultip {get;set;}

           /// <summary>
           /// Desc:被邀请人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? UserID {get;set;}

           /// <summary>
           /// Desc:被邀请人用户类型
			///                           0-未知
			///                           1-普通用户
			///                           2-开发用户
			///                           3-线上测试用户（调用第三方扣减）
			///                           4-线上测试用户（不调用第三方扣减）
			///                           5-仿真用户
			///                           6-接口联调用户
			///                           9-管理员
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? UserKind {get;set;}

           /// <summary>
           /// Desc:被邀请人注册时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? RegistDate {get;set;}

           /// <summary>
           /// Desc:被邀请人首次充值金额
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public long? FirstPayAmount {get;set;}

           /// <summary>
           /// Desc:记录时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime RecDate {get;set;}

           /// <summary>
           /// Desc:有效被邀请人用户数量
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? ValidUserCount {get;set;}

           /// <summary>
           /// Desc:月份
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? MonthDate {get;set;}

           /// <summary>
           /// Desc:sb_bank_order.OrderID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? OrderID {get;set;}

           /// <summary>
           /// Desc:领取状态
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public bool ReceiveStatus {get;set;}

    }
}
