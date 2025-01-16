using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    ///<summary>
    ///1.7版周卡配置
    ///</summary>
    [SugarTable("sa_weeklycard_config")]
    public partial class Sa_weeklycard_configPO
    {
           public Sa_weeklycard_configPO(){

            this.WeeklyCardType =0;
            this.VipMultip =1.00f;
            this.PayAmount =0;
            this.FlowMultip =1.00f;
            this.CountDown =0.0f;

           }
           /// <summary>
           /// Desc:运营商编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string OperatorID {get;set;}

           /// <summary>
           /// Desc:货币类型
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string CurrencyID {get;set;}

           /// <summary>
           /// Desc:1-100档周卡2-50档周卡
           /// Default:0
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int WeeklyCardType {get;set;}

           /// <summary>
           /// Desc:国家编码ISO 3166-1三位字母
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string CountryId {get;set;}

           /// <summary>
           /// Desc:vip加速倍率
           /// Default:1.00
           /// Nullable:False
           /// </summary>           
           public float VipMultip {get;set;}

           /// <summary>
           /// Desc:购买周卡需要的充值金额
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long PayAmount {get;set;}

           /// <summary>
           /// Desc:购买周卡充值金额需要完成的下注流水
           /// Default:1.00
           /// Nullable:False
           /// </summary>           
           public float FlowMultip {get;set;}

           /// <summary>
           /// Desc:从注册时间算起,购买周卡倒计时
           /// Default:0.0
           /// Nullable:False
           /// </summary>           
           public float CountDown {get;set;}

    }
}
