using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    ///<summary>
    ///奖池表
    ///</summary>
    [SugarTable("sa_roulette_pool")]
    public partial class Sa_roulette_poolPO
    {
           public Sa_roulette_poolPO(){

            this.FreespinPool =0;
            this.CashPool =0;
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
           /// Desc:Freespin奖池
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long FreespinPool {get;set;}

           /// <summary>
           /// Desc:真金奖池
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long CashPool {get;set;}

           /// <summary>
           /// Desc:记录时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime RecDate {get;set;}

    }
}
