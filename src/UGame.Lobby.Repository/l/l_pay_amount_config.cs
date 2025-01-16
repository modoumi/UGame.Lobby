using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    ///<summary>
    ///充值金额配置
    ///</summary>
    [SugarTable("l_pay_amount_config")]
    public partial class L_pay_amount_configPO
    {
           public L_pay_amount_configPO(){

            this.ConfigID ="0";
            this.Channels ="0";
            this.PayAmount =0;
            this.UserType =false;
            this.OrderNum =0;
            this.IsSelected =false;
            this.HotFlag =0;
            this.RecDate =DateTime.Now;

           }
           /// <summary>
           /// Desc:主键GUID
           /// Default:0
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
           /// Desc:充值渠道
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public string Channels {get;set;}

           /// <summary>
           /// Desc:充值渠道描述,对应channels
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ChannelsDesc {get;set;}

           /// <summary>
           /// Desc:子通道(如加纳mtn-gh等)
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SubChannel {get;set;}

           /// <summary>
           /// Desc:可用充值金额
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long PayAmount {get;set;}

           /// <summary>
           /// Desc:0-未充值用户1-已充值用户
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public bool UserType {get;set;}

           /// <summary>
           /// Desc:排序（从小到大）
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int OrderNum {get;set;}

           /// <summary>
           /// Desc:是否选中
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public bool IsSelected {get;set;}

           /// <summary>
           /// Desc:Hot角标
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int HotFlag {get;set;}

           /// <summary>
           /// Desc:记录时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime RecDate {get;set;}

    }
}
