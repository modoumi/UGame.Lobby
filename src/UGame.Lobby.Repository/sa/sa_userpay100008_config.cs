using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    ///<summary>
    ///每日充值激励配置
    ///</summary>
    [SugarTable("sa_userpay100008_config")]
    public partial class Sa_userpay100008_configPO
    {
           public Sa_userpay100008_configPO(){

            this.PayAmountStart =0;
            this.SendBonusMax =0;
            this.DayNumLimit =0;
            this.FlowMultip =0.00f;
            this.RecDate =DateTime.Now;

           }
           /// <summary>
           /// Desc:运营商编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
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
           [SugarColumn(IsPrimaryKey=true)]
           public string CurrencyID {get;set;}

           /// <summary>
           /// Desc:赠送bonus起始充值金额
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long PayAmountStart {get;set;}

           /// <summary>
           /// Desc:赠送bonus上限
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long SendBonusMax {get;set;}

           /// <summary>
           /// Desc:每次奖励次数限制,0不限制
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int DayNumLimit {get;set;}

           /// <summary>
           /// Desc:提现流水倍数
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public float FlowMultip {get;set;}

           /// <summary>
           /// Desc:记录时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime RecDate {get;set;}

    }
}
