using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    ///<summary>
    ///好友邀请分享，有效用户数量与奖励配置表
    ///</summary>
    [SugarTable("sa_invitenum100013_config")]
    public partial class Sa_invitenum100013_configPO
    {
           public Sa_invitenum100013_configPO(){

            this.ValidQuantity =0;
            this.OrderNum =0;
            this.Bonus =0;

           }
           /// <summary>
           /// Desc:主键guid
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
           /// Desc:国家编码ISO 3166-1三位字母
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string CountryID {get;set;}

           /// <summary>
           /// Desc:货币类型
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string CurrencyID {get;set;}

           /// <summary>
           /// Desc:邀请用户有效数量,大于等于此值则获得奖励
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int ValidQuantity {get;set;}

           /// <summary>
           /// Desc:排序字段
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int OrderNum {get;set;}

           /// <summary>
           /// Desc:奖励金额
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long Bonus {get;set;}

    }
}
