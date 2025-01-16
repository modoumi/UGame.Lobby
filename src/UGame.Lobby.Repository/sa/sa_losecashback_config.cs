using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    ///<summary>
    ///输返活动配置表
    ///</summary>
    [SugarTable("sa_losecashback_config")]
    public partial class Sa_losecashback_configPO
    {
           public Sa_losecashback_configPO(){

            this.FlowMultip =0.00f;
            this.RefundMax =0;
            this.RecDate =DateTime.Now;

           }
           /// <summary>
           /// Desc:主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public long ID {get;set;}

           /// <summary>
           /// Desc:运营商编码
           /// Default:
           /// Nullable:False
           /// </summary>           
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
           /// Nullable:True
           /// </summary>           
           public string? CurrencyID {get;set;}

           /// <summary>
           /// Desc:亏损货币下限
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long RangeMin {get;set;}

           /// <summary>
           /// Desc:亏损货币上限
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long RangeMax {get;set;}

           /// <summary>
           /// Desc:输返的倍数
           /// Default:
           /// Nullable:False
           /// </summary>           
           public float RefundMultiple {get;set;}

           /// <summary>
           /// Desc:赠金提现所需要的流水倍数
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public float FlowMultip {get;set;}

           /// <summary>
           /// Desc:最大返还金额
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long RefundMax {get;set;}

           /// <summary>
           /// Desc:记录创建时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime RecDate {get;set;}

    }
}
