using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    ///<summary>
    ///1.7版抽奖轮盘配置
    ///</summary>
    [SugarTable("sa_roulette101001_config")]
    public partial class Sa_roulette101001_configPO
    {
           public Sa_roulette101001_configPO(){

            this.PayCondition =0;
            this.PaySendNum =0;
            this.DaySendNumLimit =0;

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
           public string CurrencyID {get;set;}

           /// <summary>
           /// Desc:充值条件
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long PayCondition {get;set;}

           /// <summary>
           /// Desc:满足充值条件赠送的充值次数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int PaySendNum {get;set;}

           /// <summary>
           /// Desc:每日赠送次数上限
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int DaySendNumLimit {get;set;}

    }
}
