using CliWrap;
using UGame.Lobby.Service.Commands.Activity.InviteUser100013;
using UGame.Lobby.Common.Enum;
using UGame.Lobby.Repository.ing;
using MediatR;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Org.BouncyCastle.Bcpg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo;
using AiUo.Data;
using AiUo.Extensions.StackExchangeRedis;
using AiUo.Logging;
using UGame.Lobby.Service.Caching;
using UGame.Lobby.Service.Caching.Activity.Roulette101001;
using UGame.Lobby.Service.Services.Activity.Roulette101001;
using Xxyy.Common;
using Xxyy.Common.Caching;

namespace UGame.Lobby.Service.Commands.Activity.Roulette101001
{
    public class Roulette101001CommandHandler : IRequestHandler<Roulette101001Command, bool>
    {

        ILogger<Roulette101001CommandHandler> _logger;

        private Sa_invite100013_userMO _inviteUserMo = new();

        public Roulette101001CommandHandler()
        {
            _logger = LogUtil.CreateLogger<Roulette101001CommandHandler>();
        }

        public async Task<bool> Handle(Roulette101001Command command, CancellationToken cancellationToken)
        {

            if (!command.EventType.HasValue)
                _logger.LogError($"InviteUser101001CommandHandler.Handle.事件id为null.command:{JsonConvert.SerializeObject(command)}");

            if (command.EventType.Value == ActivityEvent.Pay)
            {
                return await PayHandle(command);
            }

            return true;
        }


        /// <summary>
        /// 充值
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public async Task<bool> PayHandle(Roulette101001Command command)
        {
            if (command.userPayMsg == null)
            {
                _logger.LogError($"Roulette101001CommandHandler.PayHandle.充值消息为null.command:{JsonConvert.SerializeObject(command)}");
                return false;
            }

            Roulette101001Service service = new Roulette101001Service();

            var userPayMsg = command.userPayMsg;


            if (userPayMsg.ActivityIds != null && userPayMsg.ActivityIds.Any() && !userPayMsg.ActivityIds.Any(d => d.Equals(Convert.ToString((int)ActivityType.Roulette101001))))
                return true;

            var globaluserDCache = await GlobalUserDCache.Create(userPayMsg.UserId);
            var operatorId = await globaluserDCache.GetOperatorIdAsync();
            var currencyId = await globaluserDCache.GetCurrencyIdAsync();

            var utcNow = DateTime.UtcNow;
            var dayId = utcNow.ToLocalTime(operatorId).Date;

            var userDayMo = new Sa_roulette101001_user_dayMO();

            //轮盘配置
            var rouletteConfigDCache = new Roulette101001ConfigDCache(operatorId, currencyId);
            var rouletteConfigEo = await rouletteConfigDCache.GetAsync();

            var userDayEo = await userDayMo.GetSingleAsync("UserId = @UserId and DayId = @DayId", userPayMsg.UserId, dayId);
            if (userDayEo == null)
            {
                if (!await service.InitRouletteUserDay(userPayMsg.UserId))
                {
                    _logger.LogError($"Roulette101001CommandHandler.InitRouletteUserDay.command:{JsonConvert.SerializeObject(command)}");
                    return false;
                }
            }
            else
            {
                if (userDayEo.SumSendNum >= rouletteConfigEo.DaySendNumLimit)
                    return true;
            }

            var userMo = new Sa_roulette101001_userMO();

            var rouletteUserDCache = new Roulette101001UserDCache(operatorId, userPayMsg.UserId);
            var userEo = await rouletteUserDCache.GetAsync();
            if (userEo == null)
            {
                if (!await service.InitRouletteUser(userPayMsg.UserId))
                {
                    _logger.LogError($"Roulette101001CommandHandler.InitRouletteUser.command:{JsonConvert.SerializeObject(command)}");
                    return false;
                }
            }

            //当日充值总金额
            var totalPayAmount = 0L;
            //当日赠送总次数
            var sumSendNum = 0;
            //本次充值应赠送次数
            var currPaySendNum = 0;

            var tm = new TransactionManager();
            try
            {
                userDayEo = await userDayMo.GetSingleAsync("UserId = @UserId and DayId = @DayId", tm, userPayMsg.UserId, dayId);
                userEo = await userMo.GetSingleAsync("UserId = @UserId", tm, userPayMsg.UserId);

                //达到每日赠送数量上限，不再赠送
                if (userDayEo.SumSendNum >= rouletteConfigEo.DaySendNumLimit)
                    throw new CustomException($"用户已达到当日最大赠送次数");

                //当日充值总金额 = 当日历史充值总金额 + 本次充值金额
                totalPayAmount = userDayEo.TotalPayAmount + userPayMsg.PayAmount;

                //当日赠送总次数 = 当日充值总金额 / 赠送一次需要的充值金额
                sumSendNum = (int)(totalPayAmount / rouletteConfigEo.PayCondition);

                //当日赠送总次数 >= 当日赠送次数上限
                if (sumSendNum >= rouletteConfigEo.DaySendNumLimit)
                    sumSendNum = rouletteConfigEo.DaySendNumLimit;

                //本次充值赠送次数=当日赠送总次数 - 当日已经赠送总次数
                currPaySendNum = sumSendNum - userDayEo.SumSendNum;

                await userDayMo.PutAsync("TotalPayAmount = @TotalPayAmount,SumSendNum = SumSendNum + @SumSendNum", "UserId = @UserId and DayId = @DayId", tm, totalPayAmount, currPaySendNum, userPayMsg.UserId, dayId);

                await userMo.PutAsync("SpinNum = SpinNum + @SpinNum", "UserId = @UserId", tm, currPaySendNum, userPayMsg.UserId);

                tm.Commit();

                await rouletteUserDCache.KeyDeleteAsync();
                var globalUserDCacheEx = GlobalUserDCacheEx.Create(userPayMsg.UserId);
                await globalUserDCacheEx.SetHasRoulette101001UserAsync();

                return true;
            }
            catch (Exception ex)
            {
                tm.Rollback();
                if(ex is not CustomException)
                    _logger.LogError($"Roulette101001CommandHandler.PayHandle.error:{ex.Message}.command:{JsonConvert.SerializeObject(command)}");
                return false;
            }
        }


        private async Task<bool> InitRouletteUserDay(Roulette101001Command command)
        {
            var utcNow = DateTime.UtcNow;
            var dayId = DateTime.UtcNow.ToLocalTime(command.userPayMsg.OperatorId).Date;
            var tm = new TransactionManager();
            try
            {
                var userDayEo = new Sa_roulette101001_user_dayEO()
                {
                    UserID = command.userPayMsg.UserId,
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
                _logger.LogError($"Roulette101001CommandHandler.InitRouletteUserDay.error:{ex.Message}.command:{JsonConvert.SerializeObject(command)}");
                return false;
            }
        }

        private async Task<bool> InitRouletteUser(Roulette101001Command command)
        {
            var utcNow = DateTime.UtcNow;
            var dayId = DateTime.UtcNow.ToLocalTime(command.userPayMsg.OperatorId).Date;
            var tm = new TransactionManager();
            try
            {
                var userDayEo = new Sa_roulette101001_user_dayEO()
                {
                    UserID = command.userPayMsg.UserId,
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
                _logger.LogError($"Roulette101001CommandHandler.InitRouletteUserDay.error:{ex.Message}.command:{JsonConvert.SerializeObject(command)}");
                return false;
            }
        }
    }
}
