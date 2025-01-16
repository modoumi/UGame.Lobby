using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    ///<summary>
    ///幸运轮盘奖励配置
    ///</summary>
    [SugarTable("sa_roulette_config")]
    public partial class Sa_roulette_configPO
    {
           public Sa_roulette_configPO(){

            this.RegisterFreespin =0;
            this.FirstPayFreespin =0;
            this.RaffleUsedFreespin =0;
            this.RaffleCashAmount =0;
            this.NewUserBetTag =0;
            this.NewUserMaxBonus =0;
            this.InGoldPool =0f;
            this.InCashPool =0f;
            this.GGRInFreespinPool =0f;
            this.IsCashEnable =false;
            this.TipPayRoundMin =0;
            this.TipPayRoundMax =0;
            this.RecDate =DateTime.Now;

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
           /// Desc:注册赠送freespin次数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int RegisterFreespin {get;set;}

           /// <summary>
           /// Desc:首充赠送freespin次数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int FirstPayFreespin {get;set;}

           /// <summary>
           /// Desc:抽奖消耗freespin数量
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int RaffleUsedFreespin {get;set;}

           /// <summary>
           /// Desc:抽奖金额-真金
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long RaffleCashAmount {get;set;}

           /// <summary>
           /// Desc:新用户下注标签,小于此值作为判定新用户的条件之一
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long NewUserBetTag {get;set;}

           /// <summary>
           /// Desc:新用户freespin时的奖励上限
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long NewUserMaxBonus {get;set;}

           /// <summary>
           /// Desc:真金抽奖进入freespin的比例
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public float InGoldPool {get;set;}

           /// <summary>
           /// Desc:真金抽奖进入真金奖池的比例
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public float InCashPool {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public float GGRInFreespinPool {get;set;}

           /// <summary>
           /// Desc:活动推荐的游戏AppId,多个以|分割
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string RecommendGames {get;set;}

           /// <summary>
           /// Desc:是否启用真金抽奖
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public bool IsCashEnable {get;set;}

           /// <summary>
           /// Desc:提示未充值用户充值,轮数下限
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int TipPayRoundMin {get;set;}

           /// <summary>
           /// Desc:提示未充值用户充值,轮数上限
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int TipPayRoundMax {get;set;}

           /// <summary>
           /// Desc:记录时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime RecDate {get;set;}

    }
}
