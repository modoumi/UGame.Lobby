using UGame.Lobby.Common.Enum;
using UGame.Lobby.Repository.ing;
using AiUo;
using AiUo.Text;
using UGame.Lobby.Service.Caching;
using UGame.Lobby.Service.Caching.Activity.Roulette;
using Xxyy.Common.Services;
using Xxyy.DAL;

namespace UGame.Lobby.Service.Services.Activity.Roulette
{
    public class RouletteContext 
    {
        /// <summary>
        /// 下注ipo
        /// </summary>
        public RouletteIpo Ipo { get; set; }

        public string AppId { get; set; } = "activity_roulette";

        /// <summary>
        /// 活动配置数据
        /// </summary>
        public Sa_roulette_configEO RouletteConfig { get; set; }

        /// <summary>
        /// 活动用户
        /// </summary>
        public Sa_roulette_userEO RouletteUser { get; set; }

        /// <summary>
        /// 是否为freespin
        /// </summary>
        public bool IsFreeSpin { get; set; } = false;

        /// <summary>
        /// 是否中奖
        /// </summary>
        public bool IsWin { get; set; } = false;

        /// <summary>
        /// 抽奖类型1-freespin2-真金
        /// </summary>
        public int RaffleType { get; set; }

        /// <summary>
        /// 下注值
        /// </summary>
        public long BetAmount { get; set; }

        /// <summary>
        /// 返奖值
        /// </summary>
        public long WinAmount { get; set; }

        /// <summary>
        /// freespin当前轮数
        /// </summary>
        public int FreespinRound { get; set; }

        /// <summary>
        /// 是否提示充值
        /// </summary>
        public bool IsTipPay { get; set; }

        /// <summary>
        /// s_user_ex
        /// </summary>
        public S_user_exEO UserEx { get; set; }

        /// <summary>
        /// 用户全局缓存
        /// </summary>
        public GlobalUserDCacheEx globalUserDCacheEx { get; set; }

        /// <summary>
        /// 用户类型
        /// </summary>
        public RouletteUserType UserType { get; set; }

        /// <summary>
        /// 下注值进入freespin奖池的金额
        /// </summary>
        public long InFreespinPool { get; set; }

        /// <summary>
        /// 下注值进入真金奖池的金额
        /// </summary>
        public long InCashPool { get; set; }

        /// <summary>
        /// 本次抽奖概率池
        /// </summary>
        public List<RouletteOddsBaseDto> RouletteOddsList { get; set; }

        /// <summary>
        /// 本次抽奖概率
        /// </summary>
        public RouletteOddsBaseDto RouletteOdds { get; set; }

        /// <summary>
        /// 活动详情Id
        /// </summary>
        public string DetailId { get; set; } = ObjectId.NewId();

        /// <summary>
        /// RouletteUserDCache
        /// </summary>
        public RouletteUserDCache RouletteUserDCache { get; set; }

        /// <summary>
        /// 用户common服务
        /// </summary>
        public UserService CommonUserService { get; set; }

        /// <summary>
        /// 奖池
        /// </summary>
        public Sa_roulette_poolEO RoulettePool { get; set; }

        /// <summary>
        /// RouletteContext
        /// </summary>
        /// <param name="ipo"></param>
        /// <exception cref="CustomException"></exception>
        public RouletteContext(RouletteIpo ipo)
        {
            this.Ipo = ipo;
            this.CommonUserService = new UserService(ipo.UserId);
            var configDCache = new RouletteConfigDCache(ipo.OperatorId, ipo.CurrencyId);
            var rouletteConfig = configDCache.GetAsync().GetAwaiter().GetResult();
            if (!rouletteConfig.HasValue)
                throw new CustomException("RouletteConfig.Data is not exists.");
            this.RouletteConfig = rouletteConfig.Value;

            this.RouletteUserDCache = new RouletteUserDCache(ipo.OperatorId, ipo.UserId);
            var rouletteUser = this.RouletteUserDCache.GetAsync().GetAwaiter().GetResult();
            if(!rouletteUser.HasValue)
                throw new CustomException("RouletteUser.Data is not exists.");
            this.RouletteUser = rouletteUser.Value;

            this.IsFreeSpin = this.RouletteUser.Freespin > 0;

            this.RaffleType = this.IsFreeSpin ? 1 : 2;

            this.BetAmount = IsFreeSpin ? 0 : this.RouletteConfig.RaffleCashAmount;

            this.UserEx = this.CommonUserService.GetUserExMo().GetByPK(ipo.UserId);

            this.globalUserDCacheEx = GlobalUserDCacheEx.Create(this.UserEx.UserID);

            this.UserType = GetRouletteUserType(this.UserEx, this.RouletteConfig);

            this.InFreespinPool = this.IsFreeSpin ? 0 : (long)(this.RouletteConfig.RaffleCashAmount * this.RouletteConfig.InGoldPool);

            this.InCashPool = this.IsFreeSpin ? 0 : (long)(this.RouletteConfig.RaffleCashAmount * this.RouletteConfig.InCashPool);

            this.FreespinRound = this.RouletteUser.Freespin > 0 ? this.RouletteUser.FreespinRound + this.RouletteConfig.RaffleUsedFreespin : this.RouletteUser.FreespinRound;

            var roulettePoolDCache = new RouletteJackpotPoolDCache(ipo.OperatorId, ipo.CurrencyId);
            var roulettePool = roulettePoolDCache.GetAsync().GetAwaiter().GetResult();
            if(!roulettePool.HasValue)
                throw new CustomException("RoulettePool.Data is not exists.");
            this.RoulettePool = roulettePool.Value;
        }


        /// <summary>
        /// 获取用户类型
        /// </summary>
        /// <param name="userEx"></param>
        /// <param name="rouletteConfig"></param>
        /// <returns></returns>
        /// <exception cref="CustomException"></exception>
        private RouletteUserType GetRouletteUserType(S_user_exEO userEx, Sa_roulette_configEO rouletteConfig)
        {
            //新用户
            if (userEx.TotalPayAmount == 0 && userEx.TotalBetAmount < rouletteConfig.NewUserBetTag)
                return RouletteUserType.newUser;
            //亏损用户：累计下注-累计返奖-活动赠送 > 0
            if (userEx.TotalBetAmount - userEx.TotalWinAmount - userEx.TotalChangeAmount > 0)
                return RouletteUserType.lossUser;
            //盈利用户：累计下注-累计返奖-活动赠送 <= 0
            if (userEx.TotalBetAmount - userEx.TotalWinAmount - userEx.TotalChangeAmount <= 0)
                return RouletteUserType.profitUser;
            //不存在的用户类型
            throw new CustomException("not found user.");
        }

        

    }
}
