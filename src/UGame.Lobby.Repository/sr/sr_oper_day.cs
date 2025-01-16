using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    ///<summary>
    ///每日统计数据（每天统计）
    ///</summary>
    [SugarTable("sr_oper_day")]
    public partial class Sr_oper_dayPO
    {
           public Sr_oper_dayPO(){

            this.NewUsers =0;
            this.LoginUsers =0;
            this.RegUsers =0;
            this.CashUsers =0;
            this.PayUsers =0;
            this.BetUsers =0;
            this.TotalBalance =0;
            this.BetAmount =0;
            this.BetBonus =0;
            this.WinBonus =0;
            this.NewBetUsers =0;
            this.NewUserBetAmount =0;
            this.NewUserBetBonus =0;
            this.NewUserWinBonus =0;
            this.WinAmount =0;
            this.PayNotBetUsers =0;
            this.DOU_FirstPayUsers =0;
            this.DNU_RepayUsers =0;
            this.RepeatConsumersD1 =0;
            this.RepeatConsumersD5 =0;
            this.RepeatConsumersD10 =0;
            this.RepeatConsumersD15 =0;
            this.DNU_FirstPayAmount =0;
            this.DOU_FirstPayAmount =0;
            this.DOU_FirstPayTotalAmount =0;
            this.NewCashUsers =0;
            this.NewPayUsers =0;
            this.PayOwnFee =0.00m;
            this.PayUserFee =0.00m;
            this.NewUserPayAmount =0;
            this.PayAmount =0;
            this.CashOwnFee =0.00m;
            this.CashUserFee =0.00m;
            this.NewUserCashAmount =0;
            this.NewUserWinAmount =0;
            this.CashAmount =0;
            this.BonusRecUsers =0;
            this.BonusAmount =0;
            this.BonusUseAmount =0;
            this.BonusRemainAmount =0;
            this.BonusUnlockAmount =0;
            this.CashAuditAmount =0;
            this.CashRefuseAmount =0;
            this.CashPassAmount =0;
            this.CashFailAmount =0;
            this.ProfitAmount =0;
            this.PromotionFeeAmount =0;
            this.NewARUP =0f;
            this.ARUP =0f;
            this.RetentionD1 =0f;
            this.RetentionD3 =0f;
            this.RetentionD7 =0f;
            this.RetentionD14 =0f;
            this.RetentionD15 =0f;
            this.RetentionD20 =0f;
            this.RetentionD30 =0f;
            this.RegRetentionD1 =0f;
            this.RegRetentionD3 =0f;
            this.RegRetentionD7 =0f;
            this.RegRetentionD15 =0f;
            this.RegRetentionD30 =0f;
            this.PayRetentionD1 =0f;
            this.PayRetentionD2 =0f;
            this.PayRetentionD3 =0f;
            this.PayRetentionD4 =0f;
            this.PayRetentionD5 =0f;
            this.PayRetentionD6 =0f;
            this.PayRetentionD7 =0f;
            this.PayRetentionD14 =0f;
            this.PayRetentionD20 =0f;
            this.PayRetentionD30 =0f;
            this.DNU_GGR1 =0;
            this.DNU_GGR2 =0;
            this.DNU_GGR3 =0;
            this.DNU_GGR4 =0;
            this.DNU_GGR5 =0;
            this.DNU_GGR6 =0;
            this.DNU_GGR7 =0;
            this.DNU_GGR8 =0;
            this.DNU_GGR9 =0;
            this.DNU_GGR10 =0;
            this.DNU_GGR11 =0;
            this.DNU_GGR12 =0;
            this.DNU_GGR13 =0;
            this.DNU_GGR14 =0;
            this.DNU_GGR15 =0;
            this.DNU_GGR16 =0;
            this.DNU_GGR17 =0;
            this.DNU_GGR18 =0;
            this.DNU_GGR19 =0;
            this.DNU_GGR20 =0;
            this.DNU_GGR21 =0;
            this.DNU_GGR22 =0;
            this.DNU_GGR23 =0;
            this.DNU_GGR24 =0;
            this.DNU_GGR25 =0;
            this.DNU_GGR26 =0;
            this.DNU_GGR27 =0;
            this.DNU_GGR28 =0;
            this.DNU_GGR29 =0;
            this.DNU_GGR30 =0;
            this.Lose10 =0;
            this.Lose10_100 =0;
            this.Lose100_500 =0;
            this.Lose500_1000 =0;
            this.Lose1000_3000 =0;
            this.Lose3000_5000 =0;
            this.Lose5000_10000 =0;
            this.Lose10000_50000 =0;
            this.Lose50000 =0;
            this.Win10 =0;
            this.Win10_100 =0;
            this.Win100_500 =0;
            this.Win500_1000 =0;
            this.Win1000_3000 =0;
            this.Win3000_5000 =0;
            this.Win5000_10000 =0;
            this.Win10000_50000 =0;
            this.Win50000 =0;
            this.TotalBalanceCalcTime =DateTime.Now;
            this.BetD1 =0f;
            this.RecDate =DateTime.Now;

           }
           /// <summary>
           /// Desc:统计日
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public DateTime DayID {get;set;}

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
           /// Nullable:True
           /// </summary>           
           public string? CountryID {get;set;}

           /// <summary>
           /// Desc:货币类型（货币缩写USD）
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string CurrencyID {get;set;}

           /// <summary>
           /// Desc:新增用户数DNU
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int NewUsers {get;set;}

           /// <summary>
           /// Desc:登录用户DAU
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int LoginUsers {get;set;}

           /// <summary>
           /// Desc:注册用户数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int RegUsers {get;set;}

           /// <summary>
           /// Desc:提现用户数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int CashUsers {get;set;}

           /// <summary>
           /// Desc:充值用户数PU
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int PayUsers {get;set;}

           /// <summary>
           /// Desc:下注用户数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int BetUsers {get;set;}

           /// <summary>
           /// Desc:当日所有账户总存量
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long TotalBalance {get;set;}

           /// <summary>
           /// Desc:下注数量
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long BetAmount {get;set;}

           /// <summary>
           /// Desc:下注时扣除的bonus
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long BetBonus {get;set;}

           /// <summary>
           /// Desc:返奖时增加的bonus
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long WinBonus {get;set;}

           /// <summary>
           /// Desc:新下注用户数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int NewBetUsers {get;set;}

           /// <summary>
           /// Desc:新用户下注额
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long NewUserBetAmount {get;set;}

           /// <summary>
           /// Desc:新用户下注的bonus
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long NewUserBetBonus {get;set;}

           /// <summary>
           /// Desc:新用户返奖bonus
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long NewUserWinBonus {get;set;}

           /// <summary>
           /// Desc:返奖数量
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long WinAmount {get;set;}

           /// <summary>
           /// Desc:充值未下注用户数量
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int PayNotBetUsers {get;set;}

           /// <summary>
           /// Desc:当日首充(历史未充值)的老用户数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int DOU_FirstPayUsers {get;set;}

           /// <summary>
           /// Desc:DNU复充用户数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int DNU_RepayUsers {get;set;}

           /// <summary>
           /// Desc:回流用户
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int RepeatConsumersD1 {get;set;}

           /// <summary>
           /// Desc:回流用户(5日）
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int RepeatConsumersD5 {get;set;}

           /// <summary>
           /// Desc:回流用户(10日)
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int RepeatConsumersD10 {get;set;}

           /// <summary>
           /// Desc:回流用户(15日)
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int RepeatConsumersD15 {get;set;}

           /// <summary>
           /// Desc:DNU首充金额
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long DNU_FirstPayAmount {get;set;}

           /// <summary>
           /// Desc:老用户当日首充的累计金额
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long DOU_FirstPayAmount {get;set;}

           /// <summary>
           /// Desc:首充老用户（历史未有充值）当日累计充值额
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long DOU_FirstPayTotalAmount {get;set;}

           /// <summary>
           /// Desc:新提现用户数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int NewCashUsers {get;set;}

           /// <summary>
           /// Desc:新充值用户数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int NewPayUsers {get;set;}

           /// <summary>
           /// Desc:充值我方手续费
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal PayOwnFee {get;set;}

           /// <summary>
           /// Desc:充值用户手续费
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal PayUserFee {get;set;}

           /// <summary>
           /// Desc:新用户充值额
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long NewUserPayAmount {get;set;}

           /// <summary>
           /// Desc:充值数量
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long PayAmount {get;set;}

           /// <summary>
           /// Desc:提现我方手续费
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal CashOwnFee {get;set;}

           /// <summary>
           /// Desc:提现用户手续费
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal CashUserFee {get;set;}

           /// <summary>
           /// Desc:新用户提现额
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long NewUserCashAmount {get;set;}

           /// <summary>
           /// Desc:新用户返奖额
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long NewUserWinAmount {get;set;}

           /// <summary>
           /// Desc:提现数量
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long CashAmount {get;set;}

           /// <summary>
           /// Desc:bonus领取人数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int BonusRecUsers {get;set;}

           /// <summary>
           /// Desc:bonus发放总量
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long BonusAmount {get;set;}

           /// <summary>
           /// Desc:bonus消耗总量
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long BonusUseAmount {get;set;}

           /// <summary>
           /// Desc:bonus存量
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long BonusRemainAmount {get;set;}

           /// <summary>
           /// Desc:bonus解锁金额
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long BonusUnlockAmount {get;set;}

           /// <summary>
           /// Desc:提审现金额度
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long CashAuditAmount {get;set;}

           /// <summary>
           /// Desc:拒审现金额度
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long CashRefuseAmount {get;set;}

           /// <summary>
           /// Desc:通过成功额度
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long CashPassAmount {get;set;}

           /// <summary>
           /// Desc:失败金额
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long CashFailAmount {get;set;}

           /// <summary>
           /// Desc:盈利数量GGR（下注-返奖-活动）
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long ProfitAmount {get;set;}

           /// <summary>
           /// Desc:活动成本sum（s_currency_change.Amount）
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long PromotionFeeAmount {get;set;}

           /// <summary>
           /// Desc:新用户ARUP（新下注用户数/新用户下注-返奖总额）
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public float NewARUP {get;set;}

           /// <summary>
           /// Desc:ARUP
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public float ARUP {get;set;}

           /// <summary>
           /// Desc:1日留存率
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public float RetentionD1 {get;set;}

           /// <summary>
           /// Desc:3日留存率
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public float RetentionD3 {get;set;}

           /// <summary>
           /// Desc:7日留存率
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public float RetentionD7 {get;set;}

           /// <summary>
           /// Desc:14日留存率
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public float RetentionD14 {get;set;}

           /// <summary>
           /// Desc:15日留存率
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public float RetentionD15 {get;set;}

           /// <summary>
           /// Desc:20日留存率
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public float RetentionD20 {get;set;}

           /// <summary>
           /// Desc:30日留存率
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public float RetentionD30 {get;set;}

           /// <summary>
           /// Desc:注册1日留存率
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public float RegRetentionD1 {get;set;}

           /// <summary>
           /// Desc:1日留存率
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public float RegRetentionD3 {get;set;}

           /// <summary>
           /// Desc:1日留存率
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public float RegRetentionD7 {get;set;}

           /// <summary>
           /// Desc:1日留存率
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public float RegRetentionD15 {get;set;}

           /// <summary>
           /// Desc:1日留存率
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public float RegRetentionD30 {get;set;}

           /// <summary>
           /// Desc:充值1日留存率
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public float PayRetentionD1 {get;set;}

           /// <summary>
           /// Desc:充值2日留存率
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public float PayRetentionD2 {get;set;}

           /// <summary>
           /// Desc:充值3日留存率
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public float PayRetentionD3 {get;set;}

           /// <summary>
           /// Desc:充值4日留存率
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public float PayRetentionD4 {get;set;}

           /// <summary>
           /// Desc:充值5日留存率
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public float PayRetentionD5 {get;set;}

           /// <summary>
           /// Desc:充值6日留存率
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public float PayRetentionD6 {get;set;}

           /// <summary>
           /// Desc:充值7日留存率
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public float PayRetentionD7 {get;set;}

           /// <summary>
           /// Desc:充值14日留存率
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public float PayRetentionD14 {get;set;}

           /// <summary>
           /// Desc:充值20日留存率
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public float PayRetentionD20 {get;set;}

           /// <summary>
           /// Desc:充值30日留存率
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public float PayRetentionD30 {get;set;}

           /// <summary>
           /// Desc:DNU_GGR1
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long DNU_GGR1 {get;set;}

           /// <summary>
           /// Desc:DNU_GGR2
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long DNU_GGR2 {get;set;}

           /// <summary>
           /// Desc:DNU_GGR3
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long DNU_GGR3 {get;set;}

           /// <summary>
           /// Desc:DNU_GGR4
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long DNU_GGR4 {get;set;}

           /// <summary>
           /// Desc:DNU_GGR5
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long DNU_GGR5 {get;set;}

           /// <summary>
           /// Desc:DNU_GGR6
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long DNU_GGR6 {get;set;}

           /// <summary>
           /// Desc:DNU_GGR7
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long DNU_GGR7 {get;set;}

           /// <summary>
           /// Desc:DNU_GGR8
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long DNU_GGR8 {get;set;}

           /// <summary>
           /// Desc:DNU_GGR9
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long DNU_GGR9 {get;set;}

           /// <summary>
           /// Desc:DNU_GGR10
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long DNU_GGR10 {get;set;}

           /// <summary>
           /// Desc:DNU_GGR11
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long DNU_GGR11 {get;set;}

           /// <summary>
           /// Desc:DNU_GGR12
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long DNU_GGR12 {get;set;}

           /// <summary>
           /// Desc:DNU_GGR13
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long DNU_GGR13 {get;set;}

           /// <summary>
           /// Desc:DNU_GGR14
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long DNU_GGR14 {get;set;}

           /// <summary>
           /// Desc:DNU_GGR15
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long DNU_GGR15 {get;set;}

           /// <summary>
           /// Desc:DNU_GGR16
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long DNU_GGR16 {get;set;}

           /// <summary>
           /// Desc:DNU_GGR17
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long DNU_GGR17 {get;set;}

           /// <summary>
           /// Desc:DNU_GGR18
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long DNU_GGR18 {get;set;}

           /// <summary>
           /// Desc:DNU_GGR19
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long DNU_GGR19 {get;set;}

           /// <summary>
           /// Desc:DNU_GGR20
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long DNU_GGR20 {get;set;}

           /// <summary>
           /// Desc:DNU_GGR21
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long DNU_GGR21 {get;set;}

           /// <summary>
           /// Desc:DNU_GGR22
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long DNU_GGR22 {get;set;}

           /// <summary>
           /// Desc:DNU_GGR23
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long DNU_GGR23 {get;set;}

           /// <summary>
           /// Desc:DNU_GGR24
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long DNU_GGR24 {get;set;}

           /// <summary>
           /// Desc:DNU_GGR25
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long DNU_GGR25 {get;set;}

           /// <summary>
           /// Desc:DNU_GGR26
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long DNU_GGR26 {get;set;}

           /// <summary>
           /// Desc:DNU_GGR27
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long DNU_GGR27 {get;set;}

           /// <summary>
           /// Desc:DNU_GGR28
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long DNU_GGR28 {get;set;}

           /// <summary>
           /// Desc:DNU_GGR29
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long DNU_GGR29 {get;set;}

           /// <summary>
           /// Desc:DNU_GGR30
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long DNU_GGR30 {get;set;}

           /// <summary>
           /// Desc:输10
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Lose10 {get;set;}

           /// <summary>
           /// Desc:输10-100人数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Lose10_100 {get;set;}

           /// <summary>
           /// Desc:输10-100人数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Lose100_500 {get;set;}

           /// <summary>
           /// Desc:输10-100人数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Lose500_1000 {get;set;}

           /// <summary>
           /// Desc:输10-100人数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Lose1000_3000 {get;set;}

           /// <summary>
           /// Desc:输10-100人数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Lose3000_5000 {get;set;}

           /// <summary>
           /// Desc:输10-100人数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Lose5000_10000 {get;set;}

           /// <summary>
           /// Desc:输10-100人数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Lose10000_50000 {get;set;}

           /// <summary>
           /// Desc:输10-100人数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Lose50000 {get;set;}

           /// <summary>
           /// Desc:输10
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Win10 {get;set;}

           /// <summary>
           /// Desc:输10-100人数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Win10_100 {get;set;}

           /// <summary>
           /// Desc:输10-100人数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Win100_500 {get;set;}

           /// <summary>
           /// Desc:输10-100人数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Win500_1000 {get;set;}

           /// <summary>
           /// Desc:输10-100人数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Win1000_3000 {get;set;}

           /// <summary>
           /// Desc:输10-100人数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Win3000_5000 {get;set;}

           /// <summary>
           /// Desc:输10-100人数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Win5000_10000 {get;set;}

           /// <summary>
           /// Desc:输10-100人数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Win10000_50000 {get;set;}

           /// <summary>
           /// Desc:输10-100人数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Win50000 {get;set;}

           /// <summary>
           /// Desc:账户存量查询时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime TotalBalanceCalcTime {get;set;}

           /// <summary>
           /// Desc:下注一日留存
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public float BetD1 {get;set;}

           /// <summary>
           /// Desc:记录时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime RecDate {get;set;}

    }
}
