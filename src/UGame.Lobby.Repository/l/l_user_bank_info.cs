using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    ///<summary>
    ///用户银行信息表
    ///</summary>
    [SugarTable("l_user_bank_info")]
    public partial class L_user_bank_infoPO
    {
           public L_user_bank_infoPO(){

            this.BankType =1;
            this.LastUsing =0;
            this.RecDate =DateTime.Now;
            this.ModifyDate =DateTime.Now;

           }
           /// <summary>
           /// Desc:唯一编码GUID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string UserBankID {get;set;}

           /// <summary>
           /// Desc:用户编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string UserID {get;set;}

           /// <summary>
           /// Desc:国家编码ISO 3166-1三位字母
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? CountryID {get;set;}

           /// <summary>
           /// Desc:货币类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? CurrencyID {get;set;}

           /// <summary>
           /// Desc:银行卡类型1-Visa;2-Spei
           /// Default:1
           /// Nullable:False
           /// </summary>           
           public int BankType {get;set;}

           /// <summary>
           /// Desc:银行编码(目前只有Spei在用)
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? BankCode {get;set;}

           /// <summary>
           /// Desc:银行名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? BankName {get;set;}

           /// <summary>
           /// Desc:银行卡号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? CardNo {get;set;}

           /// <summary>
           /// Desc:用户全名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? UserName {get;set;}

           /// <summary>
           /// Desc:用户名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? FirstName {get;set;}

           /// <summary>
           /// Desc:用户姓
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? LastName {get;set;}

           /// <summary>
           /// Desc:过期时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? ExpiryDate {get;set;}

           /// <summary>
           /// Desc:CVV
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? CVV {get;set;}

           /// <summary>
           /// Desc:电话号码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? PhoneNumber {get;set;}

           /// <summary>
           /// Desc:邮箱
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Email {get;set;}

           /// <summary>
           /// Desc:州
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? State {get;set;}

           /// <summary>
           /// Desc:城市
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? City {get;set;}

           /// <summary>
           /// Desc:街道
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Street {get;set;}

           /// <summary>
           /// Desc:邮编
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? PostalCode {get;set;}

           /// <summary>
           /// Desc:最后充值、提现使用的卡
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int LastUsing {get;set;}

           /// <summary>
           /// Desc:记录时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime RecDate {get;set;}

           /// <summary>
           /// Desc:更新时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime ModifyDate {get;set;}

    }
}
