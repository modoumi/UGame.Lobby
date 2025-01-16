using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    ///<summary>
    ///用户每日结算数据
    ///</summary>
    [SugarTable("sr_user_settl_day")]
    public partial class Sr_user_settl_dayPO
    {
           public Sr_user_settl_dayPO(){

            this.BetSum =0;
            this.WinSum =0;
            this.AmountSum =0;
            this.RecDate =DateTime.Now;

           }
           /// <summary>
           /// Desc:用户编码(GUID)
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string UserID {get;set;}

           /// <summary>
           /// Desc:货币类型
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string CurrencyID {get;set;}

           /// <summary>
           /// Desc:统计日
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public DateTime SumDay {get;set;}

           /// <summary>
           /// Desc:批次ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? BatchID {get;set;}

           /// <summary>
           /// Desc:下注金额
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long BetSum {get;set;}

           /// <summary>
           /// Desc:返奖金额
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long WinSum {get;set;}

           /// <summary>
           /// Desc:收益金额（正负数）=返奖-下注
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long AmountSum {get;set;}

           /// <summary>
           /// Desc:记录时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime RecDate {get;set;}

    }
}
