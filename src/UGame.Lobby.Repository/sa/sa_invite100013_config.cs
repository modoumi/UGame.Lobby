using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    ///<summary>
    ///好友邀请分享配置表
    ///</summary>
    [SugarTable("sa_invite100013_config")]
    public partial class Sa_invite100013_configPO
    {
           public Sa_invite100013_configPO(){

            this.PayLimit =0;
            this.BetLimit =0;
            this.BetType =0;
            this.FlowMultip =0.00f;

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
           public string CountryID {get;set;}

           /// <summary>
           /// Desc:货币类型
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string CurrencyID {get;set;}

           /// <summary>
           /// Desc:充值限制
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long PayLimit {get;set;}

           /// <summary>
           /// Desc:下注限制
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long BetLimit {get;set;}

           /// <summary>
           /// Desc:下注类型0-真金+bonus1-真金2-bonus
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? BetType {get;set;}

           /// <summary>
           /// Desc:流水倍数
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public float FlowMultip {get;set;}

    }
}
