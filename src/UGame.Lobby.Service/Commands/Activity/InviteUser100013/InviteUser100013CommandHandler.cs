using AutoMapper;
using CliWrap;
using EasyNetQ;
using EasyNetQ.Internals;
using UGame.Lobby.Service.Caching.Activity.InviteNewUser;
using UGame.Lobby.Service.Commands.Activity.InvitationNewUser100011;
using UGame.Lobby.Common.Enum;
using UGame.Lobby.Repository.ing;
using MediatR;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo;
using AiUo.Data;
using AiUo.Extensions.StackExchangeRedis;
using AiUo.Logging;
using AiUo.Text;
using UGame.Lobby.Service.Caching;
using Xxyy.Common;
using Xxyy.Common.Caching;
using Xxyy.DAL;
using Xxyy.MQ.Bank;
using Xxyy.MQ.Xxyy;

namespace UGame.Lobby.Service.Commands.Activity.InviteUser100013
{
    public class InviteUser100013CommandHandler : IRequestHandler<InviteUser100013Command, bool>
    {
        ILogger<InviteUser100013CommandHandler> _logger;

        private Sa_invite100013_userMO _inviteUserMo = new();

        private Sa_invite100013_detailMO _inviteDetailMo = new();

        public InviteUser100013CommandHandler()
        {
            _logger = LogUtil.CreateLogger<InviteUser100013CommandHandler>();
        }

        public async Task<bool> Handle(InviteUser100013Command command, CancellationToken cancellationToken)
        {

            if (!command.EventType.HasValue)
                _logger.LogError($"InviteUser100013CommandHandler.Handle.事件id为null.command:{JsonConvert.SerializeObject(command)}");

            if (command.EventType.Value == ActivityEvent.Pay)
            {
                return await PayHandle(command);
            }

            if (command.EventType.Value == ActivityEvent.Bet)
            {
                return await BetHandle(command);
            }

            return true;
        }

        /// <summary>
        /// 充值
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public async Task<bool> PayHandle(InviteUser100013Command command)
        {
            if (command.userPayMsg == null)
            {
                _logger.LogError($"InviteUser100013CommandHandler.PayHandle.充值消息为null.command:{JsonConvert.SerializeObject(command)}");
                return false;
            }

            var userPayMsg = command.userPayMsg;

            if (userPayMsg.ActivityIds != null && userPayMsg.ActivityIds.Any() && !userPayMsg.ActivityIds.Any(d => d.Equals(Convert.ToString((int)ActivityType.InviteNewUser100013))))
                return true;


            if (string.IsNullOrWhiteSpace(await GetCurrentUserPUserId(userPayMsg.UserId)))
            {
                return true;
            }

            var globalUserDCacheEx = GlobalUserDCacheEx.Create(userPayMsg.UserId, userPayMsg.CurrencyId);

            if (await globalUserDCacheEx.GetIsMeetPay100013Async())
            {
                return true;
            }

            TransactionManager tm = new TransactionManager();

            try
            {

                var inviteUserEo = await DbSink.MainDb.ExecSqlSingleAsync<Sa_invite100013_userEO>("select * from sa_invite100013_user where UserID = @UserID", tm, userPayMsg.UserId);

                if (inviteUserEo != null && inviteUserEo.IsMeetPayLimit)
                {
                    await globalUserDCacheEx.SetIsMeetPay100013Async();
                    tm.Commit();
                    return true;
                }
                
                //获取邀请人、被邀请人
                var userEo = await GetUserEo(userPayMsg.UserId, tm);

                //3、获取配置
                var inviteConfigEo = LobbyDbCacheUtil.GetInvite100013Config(userPayMsg.OperatorId, userPayMsg.CurrencyId);
                if (inviteConfigEo == null)
                    throw new Exception("sa_invite100013_config缺少配置.");

                if (inviteUserEo == null)
                {
                    inviteUserEo = await BuildInviteUserEo(userEo);
                    inviteUserEo.UserTotalPay = userPayMsg.PayAmount;
                    inviteUserEo.IsMeetPayLimit = userPayMsg.PayAmount > inviteConfigEo.PayLimit;

                    if (inviteConfigEo.BetLimit == 0)
                        inviteUserEo.IsMeetBetLimit = true;

                    await _inviteUserMo.AddAsync(inviteUserEo, tm, true);
                }
                else
                {
                    inviteUserEo.UserTotalPay += userPayMsg.PayAmount;
                    inviteUserEo.IsMeetPayLimit = inviteUserEo.UserTotalPay > inviteConfigEo.PayLimit;
                    inviteUserEo.UpdateTime = DateTime.UtcNow;
                    var set = "IsMeetPayLimit = @IsMeetPayLimit, UserTotalPay = @UserTotalPay, UpdateTime = @UpdateTime";

                    if (inviteConfigEo.BetLimit == 0)
                        set += ",IsMeetBetLimit = 1";

                    var where = "PUserID = @PUserID and UserID = @UserID";
                    await _inviteUserMo.PutAsync(
                                                set, 
                                                where, 
                                                tm, 
                                                inviteUserEo.IsMeetPayLimit, 
                                                inviteUserEo.UserTotalPay, 
                                                inviteUserEo.UpdateTime,
                                                userEo.pUserEo.UserID, 
                                                userEo.userEo.UserID);
                }


                tm.Commit();

                if (inviteConfigEo.BetLimit == 0)
                    await globalUserDCacheEx.SetIsMeetBet100013Async();

                //发送bonus奖励
                await SendBonus(userEo.pUserEo.UserID);

                return true;
            }
            catch (Exception ex)
            {
                tm.Rollback();
                if (ex is not CustomException)
                {
                    LogUtil.GetContextLogger().AddException(ex).AddMessage($"InviteUser100013CommandHandler.PayHandle.{ex.Message}.command:{JsonConvert.SerializeObject(command)}");
                }
                return false;
            }
        }

        /// <summary>
        /// 下注
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public async Task<bool> BetHandle(InviteUser100013Command command)
        {
            if (command.userBetMsg == null)
            {
                _logger.LogError($"InviteUser100013CommandHandler.BetHandle.下注消息为null.command:{JsonConvert.SerializeObject(command)}");
                return false;
            }

            var userBetMsg = command.userBetMsg;
            //只处理bet、betwin
            if (userBetMsg.BetType != 1 && userBetMsg.BetType != 3)
                return false;


            if (string.IsNullOrWhiteSpace(await GetCurrentUserPUserId(userBetMsg.UserId)))
            {
                return true;
            }

            var globalUserDCacheEx = GlobalUserDCacheEx.Create(userBetMsg.UserId, userBetMsg.CurrencyId);

            if (await globalUserDCacheEx.GetIsMeetBet100013Async())
            {
                return true;
            }

            TransactionManager tm = new TransactionManager();
            try
            {

                var inviteUserEo = await DbSink.MainDb.ExecSqlSingleAsync<Sa_invite100013_userEO>("select * from sa_invite100013_user where UserID = @UserID", tm, userBetMsg.UserId);

                if (inviteUserEo != null && inviteUserEo.IsMeetBetLimit)
                {
                    await globalUserDCacheEx.SetIsMeetBet100013Async();
                    tm.Commit();
                    return true;
                }


                //获取邀请人、被邀请人
                var userEo = await GetUserEo(userBetMsg.UserId, tm);

                //3、获取配置
                var inviteConfigEo = LobbyDbCacheUtil.GetInvite100013Config(userBetMsg.OperatorId, userBetMsg.CurrencyId);
                if (inviteConfigEo == null)
                    throw new Exception("sa_invite100013_config缺少配置.");

                var betAmount = inviteConfigEo.BetType switch
                {
                    1 => userBetMsg.BetAmount - userBetMsg.BetBonus,
                    2 => userBetMsg.BetBonus,
                    _ => userBetMsg.BetAmount
                };

                if (inviteUserEo == null)
                {
                    inviteUserEo = await BuildInviteUserEo(userEo);
                    inviteUserEo.UserTotalBet = betAmount;
                    inviteUserEo.IsMeetBetLimit = betAmount >= inviteConfigEo.BetLimit;

                    if (inviteConfigEo.PayLimit == 0)
                        inviteUserEo.IsMeetPayLimit = true;

                    await _inviteUserMo.AddAsync(inviteUserEo, tm, true);
                }
                else
                {
                    inviteUserEo.UserTotalBet += betAmount;
                    inviteUserEo.IsMeetBetLimit = inviteUserEo.UserTotalBet >= inviteConfigEo.BetLimit;
                    inviteUserEo.UpdateTime = DateTime.UtcNow;
                    var set = "IsMeetBetLimit = @IsMeetBetLimit, UserTotalBet = @UserTotalBet, UpdateTime = @UpdateTime";

                    if (inviteConfigEo.PayLimit == 0)
                        set += ", IsMeetPayLimit = 1";

                    var where = "PUserID = @PUserID and UserID = @UserID";
                    await _inviteUserMo.PutAsync(
                                                    set, 
                                                    where, 
                                                    tm, 
                                                    inviteUserEo.IsMeetBetLimit, 
                                                    inviteUserEo.UserTotalBet, 
                                                    inviteUserEo.UpdateTime, 
                                                    userEo.pUserEo.UserID, 
                                                    userEo.userEo.UserID);
                }

                tm.Commit();

                if (inviteConfigEo.PayLimit == 0)
                    await globalUserDCacheEx.SetIsMeetPay100013Async();

                //发送bonus奖励
                await SendBonus(userEo.pUserEo.UserID);

                return true;
            }
            catch (Exception ex)
            {
                tm.Rollback();
                if (ex is not CustomException)
                {
                    LogUtil.GetContextLogger().AddException(ex).AddMessage($"InviteUser100013CommandHandler.BetHandle.{ex.Message}.command:{JsonConvert.SerializeObject(command)}");
                }
                return false;
            }
        }

        private async Task<string> GetCurrentUserPUserId(string userId)
        {
            var globalUserDCache = await GlobalUserDCache.Create(userId);
            return await globalUserDCache.GetPUserID1Async();
        }

        /// <summary>
        /// 获取邀请人、被邀请人
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="tm"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        /// <exception cref="CustomException"></exception>
        private async Task<(S_userEO userEo, S_userEO pUserEo)> GetUserEo(string userId, TransactionManager tm)
        {
            (S_userEO userEo, S_userEO pUserEo) ret = (null,null);

            //查询当前用户是否通过推广员注册
            var userEo = await DbSink.BuildUserMo(userId).GetByPKAsync(userId, tm);
            if (userEo == null)
                throw new Exception("充值用户不存在.");
            if (string.IsNullOrWhiteSpace(userEo.PUserID1))
                throw new CustomException("充值用户属于自然注册用户.");
            ret.userEo = userEo;

            //2、获取PUser
            var pUserEo = await DbSink.BuildUserMo(userEo.PUserID1).GetByPKAsync(userEo.PUserID1, tm);
            if (pUserEo == null)
                throw new Exception("找不到充值用户的邀请人.");

            ret.pUserEo = pUserEo;

            return ret;
        }

        /// <summary>
        /// build sa_invite100013_userEO
        /// </summary>
        /// <param name="userEo"></param>
        /// <returns></returns>
        private async Task<Sa_invite100013_userEO> BuildInviteUserEo((S_userEO userEo, S_userEO pUserEo) userEo)
        {
            var ret = new Sa_invite100013_userEO()
            {
                PUserID = userEo.pUserEo.UserID,
                POperatorId = userEo.pUserEo.OperatorID,
                UserID = userEo.userEo.UserID,
                UOperatorId = userEo.userEo.OperatorID,
                RecDate = DateTime.UtcNow,
                UpdateTime = DateTime.UtcNow
            };
            return ret;
        }


        /// <summary>
        /// 发奖
        /// </summary>
        /// <param name="pUserId"></param>
        /// <returns></returns>
        private async Task<bool> SendBonus(string pUserId)
        {
            var ret = false;

            TransactionManager tm = new TransactionManager();

            try
            {
                var globalUserDCache = await GlobalUserDCache.Create(pUserId);
                var operatorId = await globalUserDCache.GetOperatorIdAsync();
                var currencyId = await globalUserDCache.GetCurrencyIdAsync();
                var validUser = await _inviteUserMo.GetCountAsync("PUserId = @PUserId and IsMeetPayLimit = 1 and IsMeetBetLimit = 1", tm, pUserId);
                if (validUser == 0)
                {
                    tm.Rollback();
                    return ret;
                }

                var configEo = LobbyDbCacheUtil.GetInvite100013Config(operatorId, currencyId);
                if (configEo == null)
                    throw new CustomException($"sa_invite100013_config缺少配置.operatorId:{operatorId},currencyId:{currencyId}");

                var inviteNumConfig = LobbyDbCacheUtil.GetInviteNum100013Config(operatorId, currencyId);

                if (inviteNumConfig == null || !inviteNumConfig.Any())
                    throw new CustomException($"sa_invitenum100013_config缺少配置.operatorId:{operatorId},currencyId:{currencyId}");

                var detailEoList = await _inviteDetailMo.GetAsync("UserID = @UserID", tm, pUserId);

                var addDetailEoList = new List<Sa_invite100013_detailEO>();
                var utcNow = DateTime.UtcNow;
                foreach (var item in inviteNumConfig.OrderBy(d => d.ValidQuantity).ToList())
                {
                    if (detailEoList.Any(d => d.ConfigID.Equals(item.ConfigID)))
                        continue;

                    if (validUser >= item.ValidQuantity)
                    {
                        addDetailEoList.Add(new Sa_invite100013_detailEO()
                        {
                            DetailID = ObjectId.NewId(),
                            UserID = pUserId,
                            ConfigID = item.ConfigID,
                            OperatorID = operatorId,
                            CurrencyID = currencyId,
                            Bonus = item.Bonus,
                            FlowMultip = configEo.FlowMultip,
                            ReceiveStatus = false,
                            RecDate = utcNow
                        });
                    }
                }

                if (addDetailEoList.Any())
                {
                    await _inviteDetailMo.AddByBatchAsync(addDetailEoList, addDetailEoList.Count(), tm);
                }

                tm.Commit();
                return true;
            }
            catch (Exception ex)
            {
                tm.Rollback();
                LogUtil.GetContextLogger().AddException(ex).AddMessage($"InviteUser100013CommandHandler.SendBonus.error:{ex.Message}.pUserId:{pUserId}");
                return false;
            }
        }

    }
}
