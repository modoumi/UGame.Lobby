using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    ///<summary>
    ///用户国家个人信息
    ///</summary>
    [SugarTable("l_user_info")]
    public partial class L_user_infoPO
    {
           public L_user_infoPO(){

            this.UserKind =0;
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
           /// Desc:用户类型0-未知1-普通用户2-开发用户3-线上测试用户（调用第三方扣减）4-线上测试用户（不调用第三方扣减）5-仿真用户6-接口联调用户9-管理员
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int UserKind {get;set;}

           /// <summary>
           /// Desc:用户昵称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? NickName {get;set;}

           /// <summary>
           /// Desc:First Name
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? FirstName {get;set;}

           /// <summary>
           /// Desc:Last Name
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? LastName {get;set;}

           /// <summary>
           /// Desc:生日
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? BirthDay {get;set;}

           /// <summary>
           /// Desc:证件号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? IDCard {get;set;}

           /// <summary>
           /// Desc:手机号
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
           /// Desc:地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Address {get;set;}

           /// <summary>
           /// Desc:记录时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime RecDate {get;set;}

    }
}
