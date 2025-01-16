using UGame.Lobby.Common.Enum;
using UGame.Lobby.Repository.ing;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using AiUo;
using AiUo.Collections;
using AiUo.Data;
using AiUo.Extensions.AutoMapper;
using AiUo.Extensions.RabbitMQ;
using AiUo.Logging;
using AiUo.Text;
using UGame.Lobby.Service.Caching;
using UGame.Lobby.Service.Caching.Activity.InviteNewUser;
using UGame.Lobby.Service.Common;
using Xxyy.Common;
using Xxyy.Common.Caching;
using Xxyy.Common.Services;
using Xxyy.MQ.Lobby.Activity;

namespace UGame.Lobby.Service.Services.Activity.InviteNewUser
{
    /// <summary>
    /// 好友邀请分享service
    /// </summary>
    public class InviteNewuserService
    {

        protected ILogger<InviteNewuserService> _logger;

        public InviteNewuserService()
        {
            _logger = LogUtil.CreateLogger<InviteNewuserService>();
        }

        /// <summary>
        /// 好友邀请分享-奖励明细
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        public async Task<List<InviteDetailsDto>> Details(InviteDetailsIpo ipo)
        {
            var ret = new List<InviteDetailsDto>();

            var cacheData = await new InviteNewuserDetailsDCache(ipo.UserId, ipo.Type).GetAsync();

            if (cacheData == null || !cacheData.Any())
                return ret;

            //查询排序
            cacheData = cacheData.OrderByDescending(d => d.RecDate).Skip((ipo.PageIndex - 1) * ipo.PageSize).Take(ipo.PageSize).ToList();

            ret = cacheData.Map<List<InviteDetailsDto>>();

            //获取用户显示名称
            foreach (var item in ret)
            {
                if (string.IsNullOrWhiteSpace(item.UserId))
                    continue;

                //var globalUserDCacheEx = GlobalUserDCacheEx.Create(item.UserId, item.CurrencyId);
                var globalUserDCache = await GlobalUserDCache.Create(item.UserId);
                var userMobile = await globalUserDCache.GetMobileAsync();
                if (!string.IsNullOrWhiteSpace(userMobile))
                {
                    item.UserAccount = userMobile;
                    continue;
                }
                var userName = await globalUserDCache.GetUsernameAsync();
                if (!string.IsNullOrWhiteSpace(userName))
                {
                    item.UserAccount = userName;
                }
            }

            return ret;
        }

        /// <summary>
        /// 好友邀请分享-活动详情100011
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        /// <exception cref="CustomException"></exception>
        public async Task<InviteConfigDto> About(InviteConfigIpo ipo)
        {
            var ret = new InviteConfigDto();

            var invitePayConfig = await new InvitePayConfigDCache(ipo.OperatorId, ipo.CurrencyId).GetAsync();
            var inviteNumConfig = await new InviteNumConfigDCache(ipo.OperatorId, ipo.CurrencyId).GetAsync();

            if (invitePayConfig.HasValue)
            {
                ret.PayBonus = invitePayConfig.Value.Map<List<InvitePayConfig>>();
                ret.PayFlowMultip = invitePayConfig.Value.FirstOrDefault().FlowMultip;
            }

            if (inviteNumConfig.HasValue)
            {
                ret.NumBonus = inviteNumConfig.Value.Map<List<InviteNumConfig>>();
                var numConfigItem = inviteNumConfig.Value.FirstOrDefault();
                ret.NumFlowMultip = numConfigItem.FlowMultip;
                ret.NumPayAmount = numConfigItem.PayCondition.AToM(numConfigItem.CurrencyID);
            }

            return ret;
        }

        /// <summary>
        /// 好友邀请分享-活动详情100013
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        public async Task<InviteConfigDto> About100013(InviteConfigIpo ipo)
        {
            var ret = new InviteConfigDto();

            var inviteNumConfig = LobbyDbCacheUtil.GetInviteNum100013Config(ipo.OperatorId, ipo.CurrencyId);
            var inviteConfig = LobbyDbCacheUtil.GetInvite100013Config(ipo.OperatorId, ipo.CurrencyId);

            if (inviteNumConfig != null && inviteNumConfig.Any())
            {
                ret.NumBonus = inviteNumConfig.OrderBy(d => d.ValidQuantity).Map<List<InviteNumConfig>>();
            }

            if (inviteConfig != null)
            {
                ret.BetLimit = inviteConfig.BetLimit.AToM(ipo.CurrencyId);
                ret.FlowMultip = inviteConfig.FlowMultip;
            }

            return ret;
        }

        #region 1.7版

        /// <summary>
        /// 加载活动数据
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        public async Task<InviteUser100013LoadDto> LoadAsync(InviteUser100013LoadIpo ipo)
        {
            var ret = new InviteUser100013LoadDto();

            //活动基础配置
            var inviteConfig = await new InviteUser100013ConfigDCache(ipo.OperatorId, ipo.CurrencyId).GetAsync();
            //活动有效人数对应的奖励配置
            var inviteNumConfig = await new InviteUser100013NumConfigDCache(ipo.OperatorId, ipo.CurrencyId).GetAsync();
            //用户活动奖励数据
            var cacheData = await new InviteUser100013DetailsDCache(ipo.UserId).GetAsync(true);

            ret.OperatorId = inviteConfig.OperatorID;
            ret.CurrencyId = inviteConfig.CurrencyID;
            ret.TotalBonus = inviteNumConfig.Sum(d => d.Bonus).AToM(ipo.CurrencyId);
            ret.TotalHaveReceived = cacheData.Where(d => d.ReceiveStatus).Sum(d => d.Bonus).AToM(ipo.CurrencyId);
            ret.TotalAllowReceive = cacheData.Where(d => !d.ReceiveStatus).Sum(d => d.Bonus).AToM(ipo.CurrencyId);
            var userMo = new Sa_invite100013_userMO();
            ret.TotalUser = await userMo.GetCountAsync("PUserID = @PUserID", ipo.UserId);
            ret.TotalValidUser = await userMo.GetCountAsync("PUserID = @PUserID and IsMeetPayLimit = 1 and IsMeetBetLimit = 1", ipo.UserId);
            ret.Items = await BuildInviteUser100013LoadItems(inviteNumConfig, cacheData, ret.TotalValidUser, ipo.UserId, inviteConfig);

            return ret;
        }

        /// <summary>
        /// BuildInviteUser100013LoadItem
        /// </summary>
        /// <param name="numConfigEos"></param>
        /// <param name="detailEos"></param>
        /// <param name="TotalValidUser"></param>
        /// <param name="userId"></param>
        /// <param name="configEo"></param>
        /// <returns></returns>
        private async Task<List<InviteUser100013LoadItem>> BuildInviteUser100013LoadItems(List<Sa_invitenum100013_configEO> numConfigEos, List<Sa_invite100013_detailEO> detailEos, long TotalValidUser, string userId, Sa_invite100013_configEO configEo)
        {
            var ret = new List<InviteUser100013LoadItem>();
            var addDetailEoList = new List<Sa_invite100013_detailEO>();
            foreach (var item in numConfigEos)
            {
                if (TotalValidUser >= item.ValidQuantity)
                {
                    var detailEo = detailEos.Where(d => d.ConfigID.Equals(item.ConfigID)).FirstOrDefault();
                    if (detailEo != null)
                    {
                        ret.Add(new InviteUser100013LoadItem()
                        {
                            DetailId = detailEo.DetailID,
                            Bonus = item.Bonus.AToM(item.CurrencyID),
                            NeedUsers = item.ValidQuantity,
                            AlreadyUsers = item.ValidQuantity,
                            ReceiveStatus = detailEo.ReceiveStatus ? ReceiveStatus100013.Received : ReceiveStatus100013.Receive
                        });
                    }
                    else
                    {
                        var objId = ObjectId.NewId();
                        ret.Add(new InviteUser100013LoadItem()
                        {
                            DetailId = objId,
                            Bonus = item.Bonus.AToM(item.CurrencyID),
                            NeedUsers = item.ValidQuantity,
                            AlreadyUsers = item.ValidQuantity,
                            ReceiveStatus = ReceiveStatus100013.Receive
                        });
                        addDetailEoList.Add(new Sa_invite100013_detailEO()
                        {
                            DetailID = objId,
                            UserID = userId,
                            ConfigID = item.ConfigID,
                            OperatorID = item.OperatorID,
                            CurrencyID = item.CurrencyID,
                            Bonus = item.Bonus,
                            FlowMultip = configEo.FlowMultip,
                            ReceiveStatus = false,
                            RecDate = DateTime.UtcNow
                        });
                    }
                }
                else
                {
                    var detailEo = detailEos.Where(d => d.ConfigID.Equals(item.ConfigID)).FirstOrDefault();
                    ret.Add(new InviteUser100013LoadItem()
                    {
                        DetailId = detailEo == null ? null : detailEo.DetailID,
                        Bonus = item.Bonus.AToM(item.CurrencyID),
                        NeedUsers = item.ValidQuantity,
                        AlreadyUsers = (int)TotalValidUser,
                        ReceiveStatus = ReceiveStatus100013.NotAllow
                    });
                }
            }

            if (addDetailEoList.Any())
            {
                TransactionManager tm = new TransactionManager();

                try
                {
                    await new Sa_invite100013_detailMO().AddByBatchAsync(addDetailEoList, addDetailEoList.Count(), tm);
                    tm.Commit();
                    return ret;
                }
                catch (Exception ex)
                {
                    tm.Rollback();
                    _logger.LogError($"InviteNewuser.BuildInviteUser100013LoadItems.error:{ex.Message}.");
                    return new List<InviteUser100013LoadItem>();
                }
            }

            return ret;
        }

        /// <summary>
        /// 领取奖励
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        public async Task<Execute100013Dto> ExecuteAsync(Execute100013Ipo ipo)
        {
            var ret = new Execute100013Dto();

            var activity = await LobbyUtil.GetSingleActivityAsync(ipo.OperatorId, ipo.CurrencyId, ActivityType.InviteNewUser100013);

            //活动已下架或过期
            if (activity == null || !activity.Status)
                throw new CustomException(LobbyCodes.RS_ACTIVITY_EXPIRED);

            //用户活动奖励数据
            var cacheData = await new InviteUser100013DetailsDCache(ipo.UserId).GetAsync(true);
            if (cacheData == null || !cacheData.Any(d => d.DetailID.Equals(ipo.DetailId)))
                throw new CustomException(LobbyCodes.RS_UNKNOWN, "Data does not exist.");

            var detailEo = cacheData.Where(d => d.DetailID.Equals(ipo.DetailId)).FirstOrDefault();

            if (detailEo.ReceiveStatus)
                throw new CustomException(LobbyCodes.RS_DATA_ALREADY_EXISTS, "Repeated claim");

            TransactionManager tm = new TransactionManager();

            var currencyChangeService = new CurrencyChangeService(ipo.UserId);

            //活动基础配置
            var inviteConfig = await new InviteUser100013ConfigDCache(ipo.OperatorId, ipo.CurrencyId).GetAsync();

            try
            {
                var currencyChangeReq = new CurrencyChangeReq()
                {
                    UserId = ipo.UserId,
                    AppId = ipo.AppId,
                    OperatorId = ipo.OperatorId,
                    CurrencyId = ipo.CurrencyId,
                    Reason = "1.7邀请好友赢奖励",
                    Amount = detailEo.Bonus,
                    SourceType = (int)ActivityType.InviteNewUser100013,
                    SourceTable = "sa_invite100013_detail",
                    SourceId = ipo.DetailId,
                    ChangeTime = DateTime.UtcNow,
                    ChangeBalance = activity.IsBonus ? CurrencyChangeBalance.Bonus : CurrencyChangeBalance.Cash,
                    FlowMultip = inviteConfig.FlowMultip,
                    TM = tm
                };

                //5、写s_currency_change
                var changeMsg = await currencyChangeService.Add(currencyChangeReq);
                if (changeMsg == null)
                    throw new Exception($"Failed to write to s_currency_change.req:{JsonConvert.SerializeObject(currencyChangeReq)}");

                await new Sa_invite100013_detailMO().PutReceiveStatusByPKAsync(ipo.DetailId, true, tm);

                tm.Commit();

                await MQUtil.PublishAsync(changeMsg);

                await MQUtil.PublishAsync(new UserActivityMsg()
                {
                    UserId = ipo.UserId,
                    ActivityType = (int)ActivityType.InviteNewUser100013
                });

                ret.IsSuccess = true;
                ret.Bonus = detailEo.Bonus.AToM(detailEo.CurrencyID);

                //删除缓存
                await new InviteUser100013DetailsDCache(ipo.UserId).KeyDeleteAsync();

                return ret;
            }
            catch (Exception ex)
            {
                tm.Rollback();
                LogUtil.GetContextLogger().AddException(ex).AddMessage($"InviteNewuserController.Execute.ipo:{JsonConvert.SerializeObject(ipo)}");
                throw new CustomException(ex.Message);
            }
        }
        #endregion
    }
}
