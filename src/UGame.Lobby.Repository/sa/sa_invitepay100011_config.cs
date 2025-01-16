using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    ///<summary>
    ///拉新活动，邀请用户首存金额奖励配置表
    ///</summary>
    [SugarTable("sa_invitepay100011_config")]
    public partial class Sa_invitepay100011_configPO
    {
           public Sa_invitepay100011_configPO(){

            this.PayAmountStart =0;
            this.PayAmountEnd =0;
            this.Bonus =0;
            this.FlowMultip =0.00f;

           }
           /// <summary>
           /// Desc:主键guid
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
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
           public string CountryId {get;set;}

           /// <summary>
           /// Desc:货币类型
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string CurrencyID {get;set;}

           /// <summary>
           /// Desc:首存金额起始
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long PayAmountStart {get;set;}

           /// <summary>
           /// Desc:首存金额截止
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long PayAmountEnd {get;set;}

           /// <summary>
           /// Desc:奖励金额
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

    }
}
