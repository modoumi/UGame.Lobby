using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    ///<summary>
    ///用户首充活动次序详情配置
    ///</summary>
    [SugarTable("sa_firstpay_frequency_config")]
    public partial class Sa_firstpay_frequency_configPO
    {
           public Sa_firstpay_frequency_configPO(){

            this.SerialNumber =1;
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
           public string CurrencyID {get;set;}

           /// <summary>
           /// Desc:充值序号(代表充值赠活动多次时的次数)
           /// Default:1
           /// Nullable:False
           /// </summary>           
           public int SerialNumber {get;set;}

           /// <summary>
           /// Desc:充值金额下限
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public long PayMin {get;set;}

           /// <summary>
           /// Desc:充值金额上限
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long PayMax {get;set;}

           /// <summary>
           /// Desc:充值赠金倍数
           /// Default:
           /// Nullable:False
           /// </summary>           
           public float PayMultiple {get;set;}

           /// <summary>
           /// Desc:记录创建时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime RecDate {get;set;}

    }
}
