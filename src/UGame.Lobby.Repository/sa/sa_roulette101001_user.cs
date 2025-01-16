using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    ///<summary>
    ///1.7版,抽奖轮盘用户表
    ///</summary>
    [SugarTable("sa_roulette101001_user")]
    public partial class Sa_roulette101001_userPO
    {
           public Sa_roulette101001_userPO(){

            this.UserKind =0;
            this.FromMode =0;
            this.SpinNum =0;
            this.RecDate =DateTime.Now;

           }
           /// <summary>
           /// Desc:用户编码guid
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string UserID {get;set;}

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
           /// Desc:对应的编码（根据FromMode变化）
			///                           FromMode=
			///                           0-运营商的新用户(s_operator)==> OperatorID
			///                           1-推广员获得的新用户（userid） ==> 邀请人的UserID
			///                           2-推广渠道通过url获得的新用户（s_channel_url) ==> CUrlID
			///                           3-推广渠道通过code获得的新用户（s_channel_code) ==> CCodeID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string FromId {get;set;}

           /// <summary>
           /// Desc:新用户来源方式
			///                           0-获得运营商的新用户(s_operator)
			///                           1-推广员获得的新用户（userid）
			///                           2-推广渠道通过url获得的新用户（s_channel_url)
			///                           3-推广渠道通过code获得的新用户（s_channel_code)
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int FromMode {get;set;}

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
           /// Desc:可抽奖次数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int SpinNum {get;set;}

           /// <summary>
           /// Desc:记录时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime RecDate {get;set;}

    }
}
