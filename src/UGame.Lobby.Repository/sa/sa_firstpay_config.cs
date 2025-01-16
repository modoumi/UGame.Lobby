using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    ///<summary>
    ///新用户首充500%奖励活动全局配置
    ///</summary>
    [SugarTable("sa_firstpay_config")]
    public partial class Sa_firstpay_configPO
    {
           public Sa_firstpay_configPO(){

            this.LeastPayAmount =50;
            this.IsBonus =true;
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
           /// Desc:每次充值赠金倍数，以|分隔(失效字段，移动到表sa_firstpay_frequency_config)
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string PayMultipleList {get;set;}

           /// <summary>
           /// Desc:每次可以领取的赠金的最高额度，以|分隔
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string MaximumList {get;set;}

           /// <summary>
           /// Desc:充值可获得赠金的总次数
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int TotalTimes {get;set;}

           /// <summary>
           /// Desc:送赠金的最少充值金额
           /// Default:50
           /// Nullable:False
           /// </summary>           
           public long LeastPayAmount {get;set;}

           /// <summary>
           /// Desc:赠金是否为bonus
           /// Default:1
           /// Nullable:False
           /// </summary>           
           public bool IsBonus {get;set;}

           /// <summary>
           /// Desc:赠金提现所需要的流水倍数
           /// Default:
           /// Nullable:False
           /// </summary>           
           public float FlowMultip {get;set;}

           /// <summary>
           /// Desc:记录创建时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime RecDate {get;set;}

    }
}
