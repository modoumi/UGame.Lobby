using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    ///<summary>
    ///巴西用户
    ///</summary>
    [SugarTable("l_bra_user")]
    public partial class L_bra_userPO
    {
           public L_bra_userPO(){

            this.UserKind =0;
            this.RecDate =DateTime.Now;

           }
           /// <summary>
           /// Desc:用户编码
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
           /// Desc:用户类型
			///              0-未知
			///              1-普通用户
			///              2-开发用户
			///              3-线上测试用户（调用第三方扣减）
			///              4-线上测试用户（不调用第三方扣减）
			///              5-仿真用户
			///              6-接口联调用户
			///              9-管理员
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int UserKind {get;set;}

           /// <summary>
           /// Desc:税号对应的账户名
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string AccName {get;set;}

           /// <summary>
           /// Desc:税号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string TaxId {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime RecDate {get;set;}

    }
}
