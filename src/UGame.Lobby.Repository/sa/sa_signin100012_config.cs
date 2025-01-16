using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("sa_signin100012_config")]
    public partial class Sa_signin100012_configPO
    {
           public Sa_signin100012_configPO(){


           }
           /// <summary>
           /// Desc:运营商编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string OperatorID {get;set;}

           /// <summary>
           /// Desc:货币类型
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string CurrencyID {get;set;}

           /// <summary>
           /// Desc:国家编码ISO 3166-1三位字母
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string CountryID {get;set;}

           /// <summary>
           /// Desc:流水倍数
           /// Default:
           /// Nullable:False
           /// </summary>           
           public float FlowMultip {get;set;}

           /// <summary>
           /// Desc:签到需要完成的充值金额
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long SigninPayAmount {get;set;}

           /// <summary>
           /// Desc:漏签需要完成的充值金额
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long MissSigninPayAmount {get;set;}

    }
}
