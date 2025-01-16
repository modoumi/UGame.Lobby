using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    ///<summary>
    ///拉新活动，用户当月拉新用户数量配置表
    ///</summary>
    [SugarTable("sa_invitenum100011_config")]
    public partial class Sa_invitenum100011_configPO
    {
           public Sa_invitenum100011_configPO(){

            this.UserNumStart =0;
            this.UserNumEnd =0;
            this.Bonus =0;
            this.PayCondition =0;
            this.FlowMultip =0.00f;

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
           public string CountryId {get;set;}

           /// <summary>
           /// Desc:货币类型
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string CurrencyID {get;set;}

           /// <summary>
           /// Desc:邀请用户数量起始值
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int UserNumStart {get;set;}

           /// <summary>
           /// Desc:邀请用户数量截止值
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int UserNumEnd {get;set;}

           /// <summary>
           /// Desc:奖励金额
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long Bonus {get;set;}

           /// <summary>
           /// Desc:获取奖励需要满足的累计充值金额
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long PayCondition {get;set;}

           /// <summary>
           /// Desc:提现时候需要完成的下注流水倍数
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public float FlowMultip {get;set;}

    }
}
