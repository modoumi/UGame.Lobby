using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    ///<summary>
    ///签到周期奖励表
    ///</summary>
    [SugarTable("sa_signin100012_odds")]
    public partial class Sa_signin100012_oddsPO
    {
           public Sa_signin100012_oddsPO(){

            this.Reward =0;
            this.Odds =0;

           }
           /// <summary>
           /// Desc:自增主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int ConfigID {get;set;}

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
           /// Desc:国家编码ISO 3166-1三位字母
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string CountryId {get;set;}

           /// <summary>
           /// Desc:奖励
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long Reward {get;set;}

           /// <summary>
           /// Desc:中奖概率
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Odds {get;set;}

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
