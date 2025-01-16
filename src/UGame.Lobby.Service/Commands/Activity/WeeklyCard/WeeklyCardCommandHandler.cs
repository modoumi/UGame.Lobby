using UGame.Lobby.Service.Commands.Activity.InviteUser100013;
using UGame.Lobby.Service.Services.Activity.WeeklyCard;
using UGame.Lobby.Common.Enum;
using UGame.Lobby.Repository.ing;
using MediatR;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Org.BouncyCastle.Asn1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo;
using AiUo.Data;
using AiUo.Logging;
using UGame.Lobby.Service.Caching;
using Xxyy.Common;
using Xxyy.Common.Caching;
using Xxyy.MQ.Bank;

namespace UGame.Lobby.Service.Commands.Activity.WeeklyCard
{


    public class WeeklyCardCommandHandler : IRequestHandler<WeeklyCardCommand, bool>
    {
        ILogger<WeeklyCardCommandHandler> _logger;

        private Sa_weeklycard_userMO _weeklyCardUserMo = new();

        private Sa_weeklycard_detailMO _weeklyCardDetailMo = new();

        public WeeklyCardCommandHandler()
        {
            _logger = LogUtil.CreateLogger<WeeklyCardCommandHandler>();
        }

        public async Task<bool> Handle(WeeklyCardCommand command, CancellationToken cancellationToken)
        {

            if (!command.EventType.HasValue)
                _logger.LogError($"InviteUser100013CommandHandler.Handle.事件id为null.command:{JsonConvert.SerializeObject(command)}");

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
        public async Task<bool> PayHandle(WeeklyCardCommand command)
        {
            if (command.userPayMsg == null)
            {
                _logger.LogError($"WeeklyCardCommandHandler.PayHandle.充值消息为null.command:{JsonConvert.SerializeObject(command)}");
                return false;
            }

            var userPayMsg = command.userPayMsg;

            if (userPayMsg.ActivityIds == null || !userPayMsg.ActivityIds.Any() || !userPayMsg.ActivityIds.Any(d => d.Equals(Convert.ToString((int)ActivityType.WeeklyCard))))
                return true;

            var globalUserDCache = await GlobalUserDCache.Create(userPayMsg.UserId);
            var operatorId = await globalUserDCache.GetOperatorIdAsync();
            var currencyId = await globalUserDCache.GetCurrencyIdAsync();

            //configEoList
            var configEoList = LobbyDbCacheUtil.GetWeeklyCardConfig(userPayMsg.OperatorId, userPayMsg.CurrencyId);
            if (configEoList == null || !configEoList.Any())
                throw new CustomException($"config is missing configuration1.{userPayMsg.OperatorId}|{userPayMsg.CurrencyId}");

            //属于当前充值金额的周卡
            var configEo = configEoList.Where(d => d.PayAmount == userPayMsg.PayAmount).FirstOrDefault();
            if(configEo == null)
                throw new Exception($"周卡购买金额有误.config is missing configuration2.{userPayMsg.OperatorId}|{userPayMsg.CurrencyId}");

            //detail配置List
            var detailConfigEoList = LobbyDbCacheUtil.GetAllWeeklyCardDetailConfigs(userPayMsg.OperatorId, userPayMsg.CurrencyId);
            if (detailConfigEoList == null || !detailConfigEoList.Any())
                throw new CustomException($"detail config is missing configuration1.{userPayMsg.OperatorId}|{userPayMsg.CurrencyId}");

            var currDetailConfigEoList = detailConfigEoList.Where(d => d.WeeklyCardType == configEo.WeeklyCardType).ToList();

            if(currDetailConfigEoList == null || !currDetailConfigEoList.Any())
                throw new CustomException($"detail config is missing configuration2.{userPayMsg.OperatorId}|{userPayMsg.CurrencyId}");

            var utcTime = DateTime.UtcNow;
            var localDate = utcTime.ToLocalTime(userPayMsg.OperatorId).Date;

            TransactionManager tm = new TransactionManager();

            try
            {
                var weeklyCardUserEo = await _weeklyCardUserMo.GetSingleAsync("UserId = @UserId", tm, userPayMsg.UserId);

                if (weeklyCardUserEo == null)
                {
                    await _weeklyCardUserMo.AddAsync(new Sa_weeklycard_userEO()
                    {
                        UserId = userPayMsg.UserId,
                        OperatorID = userPayMsg.OperatorId,
                        CurrencyID = userPayMsg.CurrencyId,
                        WeeklyCardType = configEo.WeeklyCardType,
                        FromId = await globalUserDCache.GetFromIdAsync(),
                        FromMode = await globalUserDCache.GetFromModeAsync(),
                        PayAmount = configEo.PayAmount,
                        FlowMultip = configEo.FlowMultip,
                        CycleStartDate = localDate,
                        CycleEndDate = localDate.AddDays(currDetailConfigEoList.Count() - 1),
                        CountDownStart = utcTime.AddHours(-configEo.CountDown),
                        IsBuyWeeklyCard = true,
                        RecDate = utcTime
                    });
                }
                else
                {
                    if (weeklyCardUserEo.IsBuyWeeklyCard)
                        throw new CustomException($"用户已经购买了周卡");

                    var set = "PayAmount = @PayAmount, FlowMultip = @FlowMultip, CycleStartDate = @CycleStartDate, CycleEndDate = @CycleEndDate, CountDownStart = @CountDownStart, IsBuyWeeklyCard = @IsBuyWeeklyCard, WeeklyCardType = @WeeklyCardType";
                    var where = "UserId = @UserId";

                    await _weeklyCardUserMo.PutAsync(set, 
                                                        where, 
                                                        tm, 
                                                        configEo.PayAmount, 
                                                        configEo.FlowMultip, 
                                                        localDate, 
                                                        localDate.AddDays(currDetailConfigEoList.Count() - 1),
                                                        utcTime.AddHours(-configEo.CountDown),
                                                        true, 
                                                        configEo.WeeklyCardType,
                                                        userPayMsg.UserId);
                }

                tm.Commit();

                return true;
            }
            catch (Exception ex)
            {
                tm.Rollback();
                if(ex is not CustomException)
                    _logger.LogError($"WeeklyCardCommandHandler.PayHandle.error:{ex.Message}.userPayMsg:{JsonConvert.SerializeObject(userPayMsg)}");
                return false;
            }
        }

    }
}
