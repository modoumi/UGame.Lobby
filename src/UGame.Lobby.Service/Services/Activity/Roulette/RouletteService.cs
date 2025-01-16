using AiUo;
using AiUo.Data;
using Xxyy.Common.Services;
using UGame.Lobby.Repository.ing;
using Xxyy.Common;
using Xxyy.DAL;
using Xxyy.Common.Caching;
using AiUo.Extensions.StackExchangeRedis;
using AiUo.Extensions.AutoMapper;
using UGame.Lobby.Common.Enum;
using AiUo.Text;
using Xxyy.MQ.Xxyy;
using AiUo.Extensions.RabbitMQ;
using AiUo.Data.SqlSugar;
using UGame.Lobby.Service.Caching;
using UGame.Lobby.Service.Caching.Activity.Roulette;
using UGame.Lobby.Service.Caching.Home;
using UGame.Lobby.Service.Common;
using UGame.Lobby.Service.Services.Activity.Roulette.Process;

namespace UGame.Lobby.Service.Services.Activity.Roulette
{
    /// <summary>
    /// RouletteService
    /// </summary>
    public class RouletteService
    {
        private Sa_roulette_userMO _rouletteUserMo = new();

        private Sa_roulette_detailMO _rouletteDetailMo = new();

        private Sa_roulette_poolMO _roulettePoolMo = new();

        private S_currency_changeMO _currencyChangeMo = new();

        private RouletteUserDCache _rouletteUserDCache;

        private GlobalUserDCacheEx _globalUserDCacheEx;

        /// <summary>
        /// 初始化sa_roulette_user
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userMode"></param>
        /// <param name="userKind"></param>
        /// <param name="operatorId"></param>
        /// <param name="currencyId"></param>
        /// <returns></returns>
        public async Task<(bool success, string message)> InitRouletteUser(string userId, int userMode, int userKind, string operatorId, string currencyId)
        {
            (bool success, string message) ret = (false, "");

            var tm = new DbTransactionManager();
            try
            {
                Sa_roulette_userPO rouletteUser = null;

                tm.Begin();
                
                switch (userMode)
                {
                    //注册用户
                    case (int)UserMode.Register:
                        var configDCache = new RouletteConfigDCache(operatorId, currencyId);
                        var rouletteConfig = await configDCache.GetAsync();

                        rouletteUser = await GetRouletteUser(operatorId, userId);

                        //不存在写入
                        if (rouletteUser == null)
                        {
                            //初始化sa_roulette_user
                            rouletteUser = new Sa_roulette_userPO()
                            {
                                UserID = userId,
                                UserKind = userKind,
                                OperatorID = operatorId,
                                CurrencyID = currencyId,
                                IsRegPay = true,
                                Freespin = rouletteConfig.Value.RegisterFreespin,
                                RecDate = DateTime.UtcNow
                            };
                            await tm.GetRepository<Sa_roulette_userPO>().InsertAsync(rouletteUser);
                        }
                        //存在更新
                        else
                        {
                            await tm.GetRepository<Sa_roulette_userPO>().UpdateSetColumnsTrueAsync(d => new Sa_roulette_userPO() { IsRegPay = true, Freespin = rouletteConfig.Value.RegisterFreespin }, d => d.UserID.Equals(userId) && d.Freespin == 0 && !d.IsRegPay);
                        }

                        //写入sa_roulette_detail
                        var rouletteDetail = new Sa_roulette_detailPO()
                        {
                            DetailID = ObjectId.NewId(),
                            UserID = userId,
                            OperatorID = operatorId,
                            CurrencyID = currencyId,
                            DetailType = (int)RouletteDetailType.register,
                            Freespin = rouletteConfig.Value.RegisterFreespin,
                            RecDate = DateTime.UtcNow
                        };

                        await tm.GetRepository<Sa_roulette_detailPO>().InsertAsync(rouletteDetail);

                        break;
                    //非注册用户
                    default:
                        rouletteUser = new Sa_roulette_userPO()
                        {
                            UserID = userId,
                            UserKind = userKind,
                            OperatorID = operatorId,
                            CurrencyID = currencyId,
                            RecDate = DateTime.Now
                        };

                        var dbRouletteUser = await tm.GetRepository<Sa_roulette_userPO>().AsQueryable().Where(d => d.UserID.Equals(userId)).FirstAsync();

                        if (dbRouletteUser == null)
                            await tm.GetRepository<Sa_roulette_userPO>().InsertAsync(rouletteUser);
                        break;
                }
                tm.Commit();
                ret.success = true;
                ret.message = "sa_roulette_user数据初始化成功";
            }
            catch (Exception ex)
            {
                tm.Rollback();
                ret.message = ex.Message;
                return ret;
            }

            if (ret.success)
            {
                //更新sa_roulette_user缓存
                await SetRouletteUserDCache(operatorId, userId);

                //更新用户全局缓存
                await SetGlobalUserDCacheExHasRouletteUser(userId);
            }

            return ret;
        }


        /// <summary>
        /// 首充奖励发放
        /// </summary>
        /// <returns></returns>
        public async Task<bool> FirstPayBonus(string operatorId, string currencyId, string userId)
        {
            var ret = false;

            TransactionManager tm = new TransactionManager();

            try
            {
                var rouletteConfig = await GetRouletteConfig(operatorId, currencyId);

                //更新用户freespin次数
                await _rouletteUserMo.PutAsync("Freespin = Freespin + @Freespin, IsFirstPay = 1", "UserID = @UserID", tm, rouletteConfig.FirstPayFreespin, userId);

                //写入sa_roulette_detail
                var rouletteDetailEo = new Sa_roulette_detailEO()
                {
                    DetailID = ObjectId.NewId(),
                    UserID = userId,
                    OperatorID = operatorId,
                    CurrencyID = currencyId,
                    DetailType = (int)RouletteDetailType.firstPay,
                    Freespin = rouletteConfig.FirstPayFreespin,
                    RecDate = DateTime.UtcNow
                };
                await _rouletteDetailMo.AddAsync(rouletteDetailEo, tm);

                tm.Commit();

                ret = true;
            }
            catch (Exception ex)
            {
                tm.Rollback();
                return false;
            }

            if (ret)
            {
                //更新sa_roulette_user缓存
                await SetRouletteUserDCache(operatorId, userId);

                //更新用户全局缓存
                await SetGlobalUserDCacheExHasRouletteUser(userId);
            }

            return ret;
        }

        /// <summary>
        /// 获取活动配置
        /// </summary>
        /// <param name="operatorId"></param>
        /// <param name="currencyId"></param>
        /// <returns></returns>
        public async Task<Sa_roulette_configEO> GetRouletteConfig(string operatorId, string currencyId)
        {
            var configDCache = new RouletteConfigDCache(operatorId, currencyId);
            var rouletteConfig = await configDCache.GetAsync();

            return rouletteConfig.Value;
        }

        /// <summary>
        /// 更新sa_roulette_user缓存
        /// </summary>
        /// <param name="operatorId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task SetRouletteUserDCache(string operatorId, string userId)
        {
            _rouletteUserDCache = new RouletteUserDCache(operatorId, userId);
            await _rouletteUserDCache.SetAsync();
        }

        /// <summary>
        /// 更新GlobalUserDCacheEX.HasRouletteUser
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task SetGlobalUserDCacheExHasRouletteUser(string userId)
        {
            _globalUserDCacheEx = GlobalUserDCacheEx.Create(userId);
            await _globalUserDCacheEx.SetHasRouletteUserAsync();
        }

        /// <summary>
        /// 获取sa_roulette_userEo
        /// </summary>
        /// <returns></returns>
        public async Task<Sa_roulette_userEO> GetRouletteUser(string operatorId, string userId)
        {
            _rouletteUserDCache = new RouletteUserDCache(operatorId, userId);
            var ret = await _rouletteUserDCache.GetOrLoadAsync();
            if (ret.HasValue)
                return ret.Value;

            return await _rouletteUserMo.GetSingleAsync("UserID = @UserID", userId);
        }


        /// <summary>
        /// 幸运转盘推荐游戏
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        public async Task<List<RouletteGamesDto>> RouletteGames(RouletteGamesIpo ipo)
        {
            var rouletteGamesDCache = new RouletteGamesDCache(ipo.OperatorId, ipo.CurrencyId);

            var cacheData = await rouletteGamesDCache.GetAsync();

            if (!cacheData.HasValue)
                return new List<RouletteGamesDto>();

            var ret = cacheData.Value;

            var favorites = await GlobalUserDCacheEx.Create(ipo.UserId).GetFavoriteAppIds();
            foreach (var app in ret)
            {
                var appLang = DbCacheUtil.GetAppLang(app.AppId, ipo.LangId);
                app.AppName = appLang.AppName;
                app.IsFavorite = favorites.Contains(app.AppId);
                var sAppEo = DbCacheUtil.GetApp(app.AppId);
                if (sAppEo.HasJackpot)
                {
                    var scAppJackpot = await new LAppJackpotDCache(app.AppId, ipo.CountryId, ipo.OperatorId, ipo.CurrencyId).GetAsync();
                    if (scAppJackpot.HasValue)
                        app.Jackpot = string.Format("{0:N2}", Math.Round(scAppJackpot.Value.Jackpot.AToM(ipo.CurrencyId), 2, MidpointRounding.ToZero));
                }
                app.Icon = LobbyUtil.GetIcon(app.Icon);
            }

            return ret;
        }


        /// <summary>
        /// 幸运转盘基础数据
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        public async Task<List<RouletteOddsBaseDto>> RouletteBaseData(RouletteOddsBaseIpo ipo)
        {
            var rouletteOddsBaseDCache = new RouletteOddsBaseDCache(ipo.OperatorId, ipo.CurrencyId);
            var rouletteOddsBase = await rouletteOddsBaseDCache.GetAsync();

            if (!rouletteOddsBase.HasValue)
                return new List<RouletteOddsBaseDto>();

            return rouletteOddsBase.Value;
        }

        /// <summary>
        /// 幸运转盘
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        /// <exception cref="CustomException"></exception>
        public async Task<RouletteDto> Roulettes(RouletteIpo ipo)
        {
            var dto = new RouletteDto();

            var context = new RouletteContext(ipo);

            if (context.RouletteUser.Freespin == 0)
                throw new CustomException(LobbyCodes.RS_ROULETTE_NO_FREESPIN, "no freespin.");

            //是否要弹出充值提示
            await new RouletteTipPayProcess().Execute(context);

            //1、如果freespin次数为0，直接return
            if (context.RouletteUser.Freespin == 0)
                return await BuildRouletteDto(context);

            var LockKey = $"lobby:activity_roulette:{ipo.UserId}";
            using (var redlock = await RedisUtil.LockAsync(LockKey, 5))
            {
                if (!redlock.IsLocked)
                {
                    redlock.Release();
                    throw new CustomException(CommonCodes.UserConcurrent, $"SlotService请求分布式锁失败.userId:{ipo.UserId}");
                }

                await ExecuteContext(context);

                //写入sa_roulette_detail
                await AddRouletteDetail(context);

                var tm = new TransactionManager();

                List<bool> sqlRetList = new List<bool>();
                bool sqlRet = false;
                try
                {
                    //betwin  2023-05-15注释，从BetWin改为currencyChangeService
                    //await BetWin(context);
                    CurrencyChangeService currencyChangeService = new CurrencyChangeService(ipo.UserId);
                    CurrencyChangeMsg changeMsg = null;
                    var currencyChangeReq = new CurrencyChangeReq()
                    {
                        UserId = ipo.UserId,
                        AppId = ipo.AppId,
                        OperatorId = ipo.OperatorId,
                        CurrencyId = ipo.CurrencyId,
                        //IsBonus = true,
                        ChangeBalance = CurrencyChangeBalance.Bonus,
                        FlowMultip = 1,
                        Reason = "幸运轮盘",
                        Amount = context.WinAmount,
                        SourceType = (int)ActivityType.Roulette,
                        SourceTable = "sa_roulette_detail",
                        SourceId = context.DetailId,
                        ChangeTime = DateTime.UtcNow,
                        TM = tm
                    };

                    if (context.IsWin)
                    {
                        // 写入S_currency_change用户奖励变化表
                        changeMsg = await currencyChangeService.Add(currencyChangeReq);
                    }

                    if (context.IsFreeSpin)
                    {
                        //更新sa_roulette_user.Freespin
                        //如果提示充值弹窗，则重置FreespinRound
                        if (context.IsTipPay)
                        {
                            sqlRet = await _rouletteUserMo.PutAsync(
                                "Freespin = Freespin - @Freespin, FreespinRound = 0, SumWinAmount = SumWinAmount + @SumWinAmount",
                                "UserId = @UserID",
                                tm,
                                context.RouletteConfig.RaffleUsedFreespin,
                                context.WinAmount,
                                context.Ipo.UserId) > 0;
                            sqlRetList.Add(sqlRet);
                        }
                        else
                        {
                            sqlRet = await _rouletteUserMo.PutAsync(
                                "Freespin = Freespin - @Freespin, FreespinRound = FreespinRound + @FreespinRound,SumWinAmount = SumWinAmount + @SumWinAmount",
                                "UserId = @UserID",
                                tm,
                                context.RouletteConfig.RaffleUsedFreespin,
                                context.RouletteConfig.RaffleUsedFreespin,
                                context.WinAmount,
                                context.Ipo.UserId) > 0;
                            sqlRetList.Add(sqlRet);
                        }

                        //更新sa_roulette_detail.FreespinNum
                        sqlRet = await _rouletteDetailMo.PutAsync(
                            "FreespinNum = @FreespinNum",
                            "DetailID = @DetailID and UserID = @UserID",
                            tm,
                            context.RouletteUser.Freespin - context.RouletteConfig.RaffleUsedFreespin,
                            context.DetailId,
                            context.Ipo.UserId) > 0;
                        sqlRetList.Add(sqlRet);
                    }
                    else
                    {
                        //更新sa_roulette_pool
                        sqlRet = await _roulettePoolMo.PutAsync(
                            "GoldPool = GoldPool + @GoldPool, CashPool = CashPool + @CashPool",
                            "OperatorID = @OperatorID",
                            tm,
                            context.InFreespinPool,
                            context.InCashPool) > 0;
                        sqlRetList.Add(sqlRet);
                    }

                    //更新sa_roulette_detail.Status
                    sqlRet = await _rouletteDetailMo.PutAsync(
                        "Status = @Status",
                        "DetailID = @DetailID and UserID = @UserID",
                        tm,
                        (int)OrderStatus.Success,
                        context.DetailId,
                        context.Ipo.UserId) > 0;
                    sqlRetList.Add(sqlRet);

                    tm.Commit();

                    if (changeMsg != null)
                    {
                        await MQUtil.PublishAsync(changeMsg);
                    }

                    //更新sa_roulette_user缓存
                    context.RouletteUser = (await context.RouletteUserDCache.GetOrLoadAsync(true)).Value;
                }
                catch (Exception ex)
                {
                    tm.Rollback();
                    //更新订单状态
                    await _rouletteDetailMo.PutStatusByPKAsync(context.DetailId, (int)OrderStatus.Fail, null);
                    throw new CustomException(LobbyCodes.RS_UNKNOWN, ex.Message);
                }

            }

            return await BuildRouletteDto(context);
        }



        private async Task ExecuteContext(RouletteContext context)
        {
            await new RouletteInitOddsProcess().Execute(context);
            await new RouletteProcess().Execute(context);
        }


        private async Task<RouletteDto> BuildRouletteDto(RouletteContext context)
        {
            RouletteDto ret = new RouletteDto();
            ret.IsFreespin = context.IsFreeSpin;
            ret.IsWin = context.IsWin;
            ret.WinAmount = context.WinAmount.AToM(context.Ipo.CurrencyId);
            ret.User.UserId = context.Ipo.UserId;
            ret.User.Balance = (await context.CommonUserService.GetBalance(context.Ipo.CurrencyId, null)).AToM(context.Ipo.CurrencyId);
            ret.User.Freespin = context.RouletteUser.Freespin;
            ret.User.UserType = (int)context.UserType;

            if (context.RouletteOdds != null)
            {
                //一级奖励，内圈
                if (context.RouletteOdds.Level == 1)
                {
                    ret.Roulette = context.RouletteOdds.Map<RouletteOdds>();
                }
                //二级奖励
                if (context.RouletteOdds.Level == 2)
                {
                    ret.Roulette = context.RouletteOddsList.Where(d => d.RewardType == context.RouletteOdds.PreRewardType).FirstOrDefault().Map<RouletteOdds>();
                    ret.Roulette.Item = context.RouletteOdds.Map<RouletteOdds>();
                }
            }

            //ret.Roulette = context.RouletteOdds != null ? context.RouletteOdds.Map<RouletteOdds>() : null;
            ret.IsPayTip = context.IsTipPay;

            return ret;
        }

        /// <summary>
        /// 写入sa_roulette_detail
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        private async Task AddRouletteDetail(RouletteContext context)
        {
            var rouletteDetail = new Sa_roulette_detailEO()
            {
                DetailID = context.DetailId,
                UserID = context.Ipo.UserId,
                Mobile = await context.globalUserDCacheEx.GetMobile(),
                OperatorID = context.Ipo.OperatorId,
                CurrencyID = context.Ipo.CurrencyId,
                DetailType = (int)RouletteDetailType.bet,
                PlanBet = context.BetAmount,
                IsFreespin = context.IsFreeSpin,
                RaffleType = context.RaffleType,
                UserType = (int)context.UserType,
                Level = context.RouletteOdds.Level,
                RewardType = context.RouletteOdds.RewardType,
                PreRewardType = context.RouletteOdds.PreRewardType,
                Position = context.RouletteOdds.Position,
                Multiple = context.RouletteOdds.Multiple,
                Status = (int)OrderStatus.Initial,
                RecDate = DateTime.UtcNow
            };

            if (context.IsWin)
            {
                if (context.IsFreeSpin)
                {
                    rouletteDetail.Amount = (long)(context.RouletteConfig.RaffleCashAmount * context.RouletteOdds.Multiple);
                }
                else
                {
                    //返奖-下注=账户实际变化数量
                    rouletteDetail.Amount = (long)(context.RouletteConfig.RaffleCashAmount * context.RouletteOdds.Multiple) - context.RouletteConfig.RaffleCashAmount;
                }
                rouletteDetail.Bonus = (long)(context.RouletteConfig.RaffleCashAmount * context.RouletteOdds.Multiple);
            }

            await _rouletteDetailMo.AddAsync(rouletteDetail);

            return;
        }

        /// <summary>
        /// 幸运转盘中奖播报
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        public async Task<List<RouletteMarqueeDto>> RouletteMarquee(RouletteMarqueeIpo ipo)
        {
            var rouletteMarqueeDCache = new RouletteMarqueeDCache(ipo.OperatorId, ipo.CurrencyId);

            var dCache = await rouletteMarqueeDCache.GetAsync();

            if (dCache.HasValue)
            {
                foreach (var item in dCache.Value)
                {
                    GlobalUserDCacheEx globalUserDCacheEx = GlobalUserDCacheEx.Create(ipo.UserId, ipo.CurrencyId);

                    var userName = await globalUserDCacheEx.GetUsername();

                    if (!string.IsNullOrWhiteSpace(userName))
                        item.UserName = userName.HideFixedLength(userName.Length, 3, 3, '*');
                }
            }

            return dCache.Value;
        }

        /// <summary>
        /// 获取用户活动数据
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        public async Task<RouletteUserDto> GetRouletteUser(RouletteUserIpo ipo)
        {
            _rouletteUserDCache = new RouletteUserDCache(ipo.OperatorId, ipo.UserId);
            var rouletteUserEo = await _rouletteUserDCache.GetAsync();
            //大厅未初始化完，需要给出默认值
            var commonUserService = new UserService(ipo.UserId);
            var sUser = await commonUserService.GetUserMo().GetByPKAsync(ipo.UserId);

            var configDCache = new RouletteConfigDCache(ipo.OperatorId, ipo.CurrencyId);
            var rouletteConfig = await configDCache.GetAsync();

            if (!rouletteUserEo.HasValue)
            {
                return new RouletteUserDto()
                {
                    UserId = ipo.UserId,
                    Freespin = rouletteConfig.Value.RegisterFreespin,
                    FreespinRound = 0
                };

                throw new CustomException("Data does not exist.");
            }

            if (sUser.UserMode == 1)
                rouletteUserEo.Value.Freespin = rouletteConfig.Value.RegisterFreespin;

            return rouletteUserEo.Value.Map<RouletteUserDto>();
        }


    }
}
