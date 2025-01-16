using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    ///<summary>
    ///注册、首充配置表
    ///</summary>
    [SugarTable("sa_regpay_config")]
    public partial class Sa_regpay_configPO
    {
           public Sa_regpay_configPO(){

            this.RegReward =0;
            this.BetAmount =0;
            this.BetReturnReward =0;
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
           /// Nullable:True
           /// </summary>           
           public string? CountryId {get;set;}

           /// <summary>
           /// Desc:货币类型
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string CurrencyID {get;set;}

           /// <summary>
           /// Desc:注册奖励金额
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long RegReward {get;set;}

           /// <summary>
           /// Desc:首充奖励金额上限
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long FirstPayReward {get;set;}

           /// <summary>
           /// Desc:下注返奖上限金额
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long BetAmount {get;set;}

           /// <summary>
           /// Desc:下注返奖金额
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long BetReturnReward {get;set;}

           /// <summary>
           /// Desc:记录时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime RecDate {get;set;}

    }
}
