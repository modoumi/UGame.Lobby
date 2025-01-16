using CliWrap;
using UGame.Lobby.Service.Caching.Activity.Roulette;
using UGame.Lobby.Service.Services.Activity.Roulette;
using UGame.Lobby.Service.Services.Activity.Roulette.Process;
using UGame.Lobby.Common.Enum;
using UGame.Lobby.Repository.ing;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo;
using AiUo.Collections;
using AiUo.Data;
using AiUo.Extensions.AutoMapper;
using AiUo.Extensions.RabbitMQ;
using AiUo.Logging;
using AiUo.Randoms;
using AiUo.Text;
using UGame.Lobby.Service.Caching;
using UGame.Lobby.Service.Caching.Activity.Roulette101001;
using UGame.Lobby.Service.Common;
using Xxyy.Common;
using Xxyy.Common.Caching;
using Xxyy.Common.Services;
using Xxyy.MQ.Xxyy;

namespace UGame.Lobby.Service.Services.Activity.Roulette101001
{
    public class Roulette101001Service
    {

        ILogger<Roulette101001Service> _logger;

        public Roulette101001Service()
        {
            _logger = LogUtil.CreateLogger<Roulette101001Service>();
        }


        #region Load

        /// <summary>
        /// BuildLoadIpo
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        public async Task BuildLoadIpo(Roulette101001LoadIpo ipo)
        {
            ipo.GlobalUserDCacheEx = GlobalUserDCacheEx.Create(ipo.UserId);
            ipo.globalUserDCache = await GlobalUserDCache.Create(ipo.UserId);
        }

        /// <summary>
        /// 抽奖转盘基础数据
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        public async Task<Roulette101001LoadDto> LoadAsync(Roulette101001LoadIpo ipo)
        {
            var ret = new Roulette101001LoadDto();

            if (!await IsValidActivity(ipo.OperatorId, ipo.CurrencyId, ActivityType.Roulette101001))
                throw new CustomException(LobbyCodes.RS_ACTIVITY_EXPIRED);

            await BuildLoadIpo(ipo);

            var dCache = new Roulette101001OddsBaseDCache(ipo.OperatorId, ipo.CurrencyId);
            var dCacheData = await dCache.GetAsync();

            ret.Items = dCacheData.Map<List<RouletteItem>>();

            var configCache = new Roulette101001ConfigDCache(ipo.OperatorId, ipo.CurrencyId);
            var configCacheData = await configCache.GetAsync();
            ret.Config = configCacheData.Map<RouletteConfig>();

            await InitRouletteUser(ipo, ret);

            return ret;
        }

        /// <summary>
        /// 初始化roulette user
        /// </summary>
        /// <param name="ipo"></param>
        /// <param name="dto"></param>
        /// <returns></returns>
        /// <exception cref="CustomException"></exception>
        public async Task InitRouletteUser(Roulette101001LoadIpo ipo, Roulette101001LoadDto dto)
        {
            TransactionManager tm = new TransactionManager();

            try
            {
                var hasRouletteUser = await ipo.GlobalUserDCacheEx.GetHasRoulette101001UserAsync();

                var user = new Sa_roulette101001_userEO()
                {
                    UserID = ipo.UserId,
                    UserKind = (int)await ipo.globalUserDCache.GetUserKindAsync(),
                    FromId = await ipo.globalUserDCache.GetFromIdAsync(),
                    FromMode = await ipo.globalUserDCache.GetFromModeAsync(),
                    OperatorID = await ipo.globalUserDCache.GetOperatorIdAsync(),
                    CurrencyID = await ipo.globalUserDCache.GetCurrencyIdAsync(),
                    SpinNum = 0,
                    RecDate = DateTime.UtcNow
                };
                if (!hasRouletteUser)
                {
                    //初始化
                    await new Sa_roulette101001_userMO().AddAsync(user, tm, true);
                    dto.User = user.Map<RouletteUser>();
                }
                else
                {
                    //从缓存拿数据
                    var rouletteUserDCache = new Roulette101001UserDCache(ipo.OperatorId, ipo.UserId);
                    var rouletteUser = await rouletteUserDCache.GetAsync();

                    dto.User = rouletteUser.Map<RouletteUser>();
                }
                tm.Commit();
                //更新缓存
                await ipo.GlobalUserDCacheEx.SetHasRoulette101001UserAsync();
            }
            catch (Exception ex)
            {
                tm.Rollback();
                LogUtil.GetContextLogger().AddException(ex).AddMessage($"RouletteNewController.Load.ipo:{JsonConvert.SerializeObject(ipo)}.dto:{JsonConvert.SerializeObject(dto)}");
                throw new CustomException("Init user failed.");
            }
        }

        #endregion

        public async Task<Roulette101001Context> BuildRouletteContext(string userId)
        {
            var ret = new Roulette101001Context();
            ret.UserId = userId;
            ret.GlobalUserDCache = await GlobalUserDCache.Create(userId);
            ret.OperatorId = await ret.GlobalUserDCache.GetOperatorIdAsync();
            ret.CurrencyId = await ret.GlobalUserDCache.GetCurrencyIdAsync();
            //抽奖配置
            ret.RouletteConfigEo = await (new Roulette101001ConfigDCache(ret.OperatorId, ret.CurrencyId)).GetAsync();
            //用户
            ret.Roulette101001UserDCache = new Roulette101001UserDCache(ret.OperatorId, ret.UserId);
            ret.RouletteUserEo = await ret.Roulette101001UserDCache.GetAsync();
            if (ret.RouletteUserEo == null)
            {
                await InitRouletteUser(ret.UserId);
                ret.RouletteUserEo = await ret.Roulette101001UserDCache.GetAsync();
            }

            //概率配置
            ret.RouletteOddsEoList = await (new Roulette101001OddsBaseDCache(ret.OperatorId, ret.CurrencyId)).GetAsync();


            return ret;
        }

        public async Task<RouletteRaffleDto> Raffle(RouletteRaffleIpo ipo)
        {
            if (!await IsValidActivity(ipo.OperatorId, ipo.CurrencyId, ActivityType.Roulette101001))
                throw new CustomException(LobbyCodes.RS_ACTIVITY_EXPIRED);

            var context = await BuildRouletteContext(ipo.UserId);

            if(context.RouletteUserEo.SpinNum == 0)
                throw new CustomException(LobbyCodes.RS_ROULETTE101001_NO_SPIN, "no spin.");

            //抽奖逻辑
            await ExecuteContext(context);

            var tm = new TransactionManager();

            var DetailID = ObjectId.NewId();

            try
            {
                //写数据sa_roulette101001_detail
                var detail = new Sa_roulette101001_detailEO()
                {
                    DetailID = DetailID,
                    UserID = context.UserId,
                    DayId = DateTime.UtcNow.ToLocalTime(context.OperatorId).Date,
                    Mobile = await context.GlobalUserDCache.GetMobileAsync(),
                    OperatorID = context.OperatorId,
                    CurrencyID = context.CurrencyId,
                    Amount = context.RouletteOddsEo.Bonus,
                    RewardType = context.RouletteOddsEo.RewardType,
                    Position = context.RouletteOddsEo.Position,
                    Status = (int)OrderStatus.Initial,
                    RecDate = DateTime.UtcNow
                };

                await new Sa_roulette101001_detailMO().AddAsync(detail, tm);

                CurrencyChangeService currencyChangeService = new CurrencyChangeService(ipo.UserId);
                
                var currencyChangeReq = new CurrencyChangeReq()
                {
                    UserId = context.UserId,
                    AppId = ipo.AppId,
                    OperatorId = context.OperatorId,
                    CurrencyId = context.CurrencyId,
                    ChangeBalance = CurrencyChangeBalance.Bonus,
                    FlowMultip = context.RouletteOddsEo.FlowMultip,
                    Reason = "幸运轮盘101001",
                    Amount = context.WinAmount,
                    SourceType = (int)ActivityType.Roulette101001,
                    SourceTable = "sa_roulette101001_detail",
                    SourceId = detail.DetailID,
                    ChangeTime = DateTime.UtcNow,
                    TM = tm
                };


                var changeMsg = await currencyChangeService.Add(currencyChangeReq);
                if (changeMsg == null)
                    throw new Exception("写入s_currency_change失败");

                //更新sa_roulette_detail.Status
                await new Sa_roulette101001_detailMO().PutAsync("Status = @Status,EndSpinNum = @EndSpinNum", "DetailID = @DetailID and UserID = @UserID", tm, (int)OrderStatus.Success, context.RouletteUserEo.SpinNum - 1,DetailID,context.UserId);

                //更新sa_roulette101001_user.SpinNum
                await new Sa_roulette101001_userMO().PutAsync("SpinNum = SpinNum - 1", "UserId = @UserId and SpinNum - 1 >= 0", context.UserId);

                tm.Commit();

                //更新sa_roulette_user缓存
                context.RouletteUserEo = (await context.Roulette101001UserDCache.GetOrLoadAsync(true)).Value;
                context.IsTipPay = context.RouletteUserEo.SpinNum == 0;
                if (changeMsg != null)
                {
                    await MQUtil.PublishAsync(changeMsg);
                }
            }
            catch (Exception ex)
            {
                tm.Rollback();
                //更新订单状态
                await new Sa_roulette101001_detailMO().PutStatusByPKAsync(DetailID, (int)OrderStatus.Fail, null);
                throw new CustomException(LobbyCodes.RS_UNKNOWN, ex.Message);
            }

            return await BuildRouletteRaffleDto(context);
        }

        private async Task ExecuteContext(Roulette101001Context context)
        {
            RandomUtil.DefaultProvider = RandomProviderFactory.CreateDefaultProvider();

            //中奖几率随机数
            var random = RandomUtil.NextInt(1, context.RouletteOddsEoList.Sum(d => d.Odds) + 1);

            var startNum = 1;
            foreach (var item in context.RouletteOddsEoList)
            {
                if (item.Odds == 0)
                    continue;
                if (random >= startNum && random <= (item.Odds + startNum - 1))
                {
                    context.RouletteOddsEo = item;
                    break;
                }
                startNum += item.Odds;
            }

            if (context.RouletteOddsEo == null)
                context.RouletteOddsEo = context.RouletteOddsEoList.Where(d => d.RewardType == 1).FirstOrDefault();

            if (context.RouletteOddsEo.Bonus > 0)
                context.IsWin = true;

            if (context.IsWin)
                context.WinAmount = context.RouletteOddsEo.Bonus;
        }


        public async Task<RouletteRaffleDto> BuildRouletteRaffleDto(Roulette101001Context context)
        {
            var ret = new RouletteRaffleDto();
            ret.IsWin = context.IsWin;
            ret.WinAmount = context.WinAmount.AToM(context.CurrencyId);
            ret.IsTipPay = context.IsTipPay; ;
            ret.Reward = context.RouletteOddsEo.Map<RouletteOddsResult>();
            return ret;
        }


        public async Task<bool> InitRouletteUserDay(string userId)
        {
            var globalUserDCache = await GlobalUserDCache.Create(userId);

            var utcNow = DateTime.UtcNow;
            var dayId = DateTime.UtcNow.ToLocalTime(await globalUserDCache.GetOperatorIdAsync()).Date;
            var tm = new TransactionManager();
            try
            {
                var userDayEo = new Sa_roulette101001_user_dayEO()
                {
                    UserID = userId,
                    DayId = dayId,
                    RecDate = utcNow
                };

                await new Sa_roulette101001_user_dayMO().AddAsync(userDayEo, tm, true);

                tm.Commit();
                return true;
            }
            catch (Exception ex)
            {
                tm.Rollback();
                _logger.LogError($"Roulette101001Service.InitRouletteUserDay.error:{ex.Message}.userId:{userId}");
                return false;
            }
        }

        public async Task<bool> InitRouletteUser(string userId)
        {
            var globalUserDCache = await GlobalUserDCache.Create(userId);

            var utcNow = DateTime.UtcNow;
            var dayId = DateTime.UtcNow.ToLocalTime(await globalUserDCache.GetOperatorIdAsync()).Date;
            var tm = new TransactionManager();
            try
            {
                var userEo = new Sa_roulette101001_userEO()
                {
                    UserID = userId,
                    UserKind = (int)await globalUserDCache.GetUserKindAsync(),
                    FromId = await globalUserDCache.GetFromIdAsync(),
                    FromMode = await globalUserDCache.GetFromModeAsync(),
                    OperatorID = await globalUserDCache.GetOperatorIdAsync(),
                    CurrencyID = await globalUserDCache.GetCurrencyIdAsync(),
                    RecDate = utcNow
                };

                await new Sa_roulette101001_userMO().AddAsync(userEo, tm, true);

                tm.Commit();
                return true;
            }
            catch (Exception ex)
            {
                tm.Rollback();
                _logger.LogError($"Roulette101001Service.InitRouletteUser.error:{ex.Message}.userId:{userId}");
                return false;
            }
        }

        private async Task<bool> IsValidActivity(string operatorId, string currencyId, ActivityType activityType)
        {
            //获取全部有效活动
            var activityOperator = await LobbyUtil.GetOperatorActivity(operatorId, currencyId);

            if (activityOperator == null
                || !activityOperator.Any()
                || !activityOperator.Any(d => d.ActivityID == (int)activityType && d.Status)
                )
                return false;

            return true; ;
        }

    }
}
