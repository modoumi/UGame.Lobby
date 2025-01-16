using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    ///<summary>
    ///每日充值激励用户明细表
    ///</summary>
    [SugarTable("sa_userpay100008_user")]
    public partial class Sa_userpay100008_userPO
    {
           public Sa_userpay100008_userPO(){

            this.Bonus =0;
            this.FlowMultip =0.00f;
            this.UserKind =0;
            this.FromMode =0;
            this.RecDate =DateTime.Now;

           }
           /// <summary>
           /// Desc:用户编码(GUID)
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
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
           /// Desc:sb_bank_order.OrderID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string OrderID {get;set;}

           /// <summary>
           /// Desc:获得奖金
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long Bonus {get;set;}

           /// <summary>
           /// Desc:提现时候需要完成的下注流水倍数
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public float FlowMultip {get;set;}

           /// <summary>
           /// Desc:用户类型
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
           public int UserKind {get;set;}

           /// <summary>
           /// Desc:新用户来源方式
			///                           0-获得运营商的新用户(s_operator)
			///                           1-推广员获得的新用户（userid）
			///                           2-推广渠道通过url获得的新用户（s_channel_url)
			///                           3-推广渠道通过code获得的新用户（s_channel_code)
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int FromMode {get;set;}

           /// <summary>
           /// Desc:对应的编码（根据FromMode变化）
			///                           FromMode=
			///                           0-运营商的新用户(s_operator)==> OperatorID
			///                           1-推广员获得的新用户（userid） ==> 邀请人的UserID
			///                           2-推广渠道通过url获得的新用户（s_channel_url) ==> CUrlID
			///                           3-推广渠道通过code获得的新用户（s_channel_code) ==> CCodeID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? FromId {get;set;}

           /// <summary>
           /// Desc:充值日期,运营商当地日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? DayId {get;set;}

           /// <summary>
           /// Desc:记录时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime RecDate {get;set;}

    }
}
