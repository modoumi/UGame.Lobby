using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    ///<summary>
    ///每日充值，充值赠送bonus区间配置表
    ///</summary>
    [SugarTable("sa_userpay100008_detail_config")]
    public partial class Sa_userpay100008_detail_configPO
    {
           public Sa_userpay100008_detail_configPO(){

            this.PayAmountStart =0;
            this.PayAmountEnd =0;
            this.SendBonusMultip =0.00f;

           }
           /// <summary>
           /// Desc:主键GUID
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
           /// Desc:充值金额起始值
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long PayAmountStart {get;set;}

           /// <summary>
           /// Desc:充值金额截止值
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long PayAmountEnd {get;set;}

           /// <summary>
           /// Desc:赠送bonus倍数
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public float SendBonusMultip {get;set;}

    }
}
