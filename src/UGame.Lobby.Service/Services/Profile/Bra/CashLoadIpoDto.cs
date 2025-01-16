namespace UGame.Lobby.Service.Services.Profile.Bra
{
    public class CashLoadIpo : LobbyBaseIpo
    {

    }

    public class CashLoadDto
    {
        /// <summary>
        /// 银行卡
        /// </summary>
        public AddBraBank AddBraBank { get; set; } = new AddBraBank();

        /// <summary>
        /// 流水
        /// </summary>
        public CashFlow Flow { get; set; } = new CashFlow();

        /// <summary>
        /// 提现限制
        /// </summary>
        public CashLimit CashLimit { get; set; } = new CashLimit();

        /// <summary>
        /// 是否启用bonus（用户是否有bonus账户）
        /// </summary>
        public bool EnableBonus { get; set; }
    }

    public class AddBraBank
    {
        /// <summary>
        /// CNPJ、PHONE、EMAIL、EVP是否锁定
        /// </summary>
        public bool IsLockMethod { get; set; } = true;
    }

    public class CashFlow
    {
        /// <summary>
        /// 可提现金额
        /// </summary>
        public decimal CashMoney { get; set; } = 0;
        /// <summary>
        /// 提现需要完成的流水
        /// </summary>
        public decimal RequireFlow { get; set; } = 0;
        /// <summary>
        /// 提现已完成的流水
        /// </summary>
        public decimal CompletedFlow { get; set; } = 0;
    }

    public class CashLimit
    {
        /// <summary>
        /// 最低提现金额
        /// </summary>
        public decimal MinAmount { get; set; } = 0;
        /// <summary>
        /// 最大提现金额
        /// </summary>
        public decimal MaxAmount { get; set; } = 0;
        /// <summary>
        /// 最大提现次数
        /// </summary>
        public int MaxNumLimit { get; set; } = 0;
    }

    public class CashUser
    {
        /// <summary>
        /// 当日剩余可提现次数
        /// </summary>
        public int AllowCashNum { get; set; } = 0;
        /// <summary>
        /// 当日剩余可提现金额
        /// </summary>
        public decimal AllowCashAmount { get; set; } = 0;
    }

}
