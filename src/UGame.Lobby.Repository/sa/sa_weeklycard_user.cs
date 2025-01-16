using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    ///<summary>
    ///1.7版周卡用户表
    ///</summary>
    [SugarTable("sa_weeklycard_user")]
    public partial class Sa_weeklycard_userPO
    {
           public Sa_weeklycard_userPO(){

            this.WeeklyCardType =0;
            this.FlowMultip =1.00f;
            this.CountDownStart =DateTime.Now;
            this.IsBuyWeeklyCard =false;
            this.RecDate =DateTime.Now;

           }
           /// <summary>
           /// Desc:用户编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string UserId {get;set;}

           /// <summary>
           /// Desc:运营商编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string OperatorID {get;set;}

           /// <summary>
           /// Desc:货币类型
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string CurrencyID {get;set;}

           /// <summary>
           /// Desc:1-100档周卡2-50档周卡
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int WeeklyCardType {get;set;}

           /// <summary>
           /// Desc:对应的编码（根据FromMode变化）
			///                           FromMode=
			///                           0-运营商的新用户(s_operator)==> OperatorID
			///                           1-推广员获得的新用户（userid） ==> 邀请人的UserID
			///                           2-推广渠道通过url获得的新用户（s_channel_url) ==> CUrlID
			///                           3-推广渠道通过code获得的新用户（s_channel_code) ==> CCodeID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string FromId {get;set;}

           /// <summary>
           /// Desc:新用户来源方式
			///                           0-获得运营商的新用户(s_operator)
			///                           1-推广员获得的新用户（userid）
			///                           2-推广渠道通过url获得的新用户（s_channel_url)
			///                           3-推广渠道通过code获得的新用户（s_channel_code)
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int FromMode {get;set;}

           /// <summary>
           /// Desc:购买金额
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long PayAmount {get;set;}

           /// <summary>
           /// Desc:流水倍数
           /// Default:1.00
           /// Nullable:False
           /// </summary>           
           public float FlowMultip {get;set;}

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
           /// Desc:购买周卡倒计时开始时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime CountDownStart {get;set;}

           /// <summary>
           /// Desc:是否购买周卡
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public bool IsBuyWeeklyCard {get;set;}

           /// <summary>
           /// Desc:购买时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime RecDate {get;set;}

    }
}
