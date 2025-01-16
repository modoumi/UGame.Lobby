using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    ///<summary>
    ///幸运轮盘用户表
    ///</summary>
    [SugarTable("sa_roulette_user")]
    public partial class Sa_roulette_userPO
    {
           public Sa_roulette_userPO(){

            this.UserKind =0;
            this.Freespin =0;
            this.SumWinAmount =0;
            this.FreespinRound =0;
            this.IsRegPay =false;
            this.IsFirstPay =false;
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
           /// Desc:freespin次数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Freespin {get;set;}

           /// <summary>
           /// Desc:活动累计获得奖金
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long SumWinAmount {get;set;}

           /// <summary>
           /// Desc:freespin轮数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int FreespinRound {get;set;}

           /// <summary>
           /// Desc:是否发放过注册奖励
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public bool IsRegPay {get;set;}

           /// <summary>
           /// Desc:是否发放过首充奖励
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public bool IsFirstPay {get;set;}

           /// <summary>
           /// Desc:记录时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime RecDate {get;set;}

    }
}
