using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    ///<summary>
    ///1.7周卡明细配置
    ///</summary>
    [SugarTable("sa_weeklycard_detail_config")]
    public partial class Sa_weeklycard_detail_configPO
    {
           public Sa_weeklycard_detail_configPO(){

            this.WeeklyCardType =0;
            this.Bonus =0;
            this.FlowMultip =1.00f;

           }
           /// <summary>
           /// Desc:自增主键
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
           /// Desc:国家编码ISO 3166-1三位字母
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string CountryId {get;set;}

           /// <summary>
           /// Desc:奖金
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long Bonus {get;set;}

           /// <summary>
           /// Desc:流水倍数
           /// Default:1.00
           /// Nullable:False
           /// </summary>           
           public float FlowMultip {get;set;}

           /// <summary>
           /// Desc:日期编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int DateNumber {get;set;}

           /// <summary>
           /// Desc:是否为第一天
           /// Default:
           /// Nullable:False
           /// </summary>           
           public bool IsStartDay {get;set;}

    }
}
