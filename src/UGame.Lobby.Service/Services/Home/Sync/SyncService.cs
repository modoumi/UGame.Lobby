using UGame.Lobby.Common.Enum;
using UGame.Lobby.Repository.ing;
using Microsoft.Extensions.Logging;
using AiUo;
using AiUo.AspNet;
using AiUo.Data.SqlSugar;
using AiUo.DbCaching;
using AiUo.Logging;
using UGame.Lobby.Service.Caching;
using UGame.Lobby.Service.Caching.Activity;
using UGame.Lobby.Service.Caching.Activity.Register7;
using UGame.Lobby.Service.Caching.Home;
using Xxyy.Common;
using Xxyy.Common.Caching;
using Xxyy.DAL;

namespace UGame.Lobby.Service.Services.Home.Sync
{

    public interface ISyncService
    {
        Task<bool> Search(SyncIpo syncEnums, SyncDto dto);
    }

    public class BalanceService : ISyncService
    {
        public async Task<bool> Search(SyncIpo ipo, SyncDto dto)
        {
            var sUserEo = await DbUtil.GetRepository<S_userPO>().AsQueryable()
                .Where(d => d.UserID.Equals(ipo.UserId))
                .FirstAsync();

            if (sUserEo == null)
                return false;

            dto.Balance = new Balance()
            {
                Cash = sUserEo.Cash.AToM(sUserEo.CurrencyID),
                Bonus = sUserEo.Bonus.AToM(sUserEo.CurrencyID),
                CashBalance = (sUserEo.Cash - sUserEo.Bonus).AToM(sUserEo.CurrencyID)
            };

            return true;
        }
    }

    public class OrderService : ISyncService
    {
        public async Task<bool> Search(SyncIpo ipo, SyncDto dto)
        {
            if (string.IsNullOrWhiteSpace(ipo.OrderId))
                return false;

            var orderEo = await DbUtil.GetRepository<Sb_bank_orderPO>().AsQueryable()
                .Where(d => d.OrderID.Equals(ipo.OrderId))
                .FirstAsync();

            if (orderEo == null)
                return false;

            dto.Order = new Order()
            {
                OrderId = orderEo.OrderID,
                Status = orderEo.Status
            };
            return true;
        }
    }

    public class ActivityService : ISyncService
    {
        public async Task<bool> Search(SyncIpo ipo, SyncDto dto)
        {
            var activityId = ipo.ActivityId.ToEnumN<ActivityType>();

            if (!activityId.HasValue)
                return false;

            if (activityId.Value != ActivityType.Register7 && activityId.Value != ActivityType.RegisterRewardTask)
                return false;

            //优先获取任务,如果任务没有开启，再取活动奖励
            var itemOperator = DbCachingUtil.GetSingle<Sat_item_operatorPO>(d => new { d.OperatorID, d.ItemID }, new Sat_item_operatorPO
            {
                OperatorID = ipo.OperatorId,
                ItemID = (int)ActivityType.RegisterRewardTask
            });
            if (itemOperator != null && itemOperator.Status == 1)
            {
                dto.Activity.IsValid = true;
                dto.Activity.ActivityId = (int)ActivityType.RegisterRewardTask;
                var taskReward = await DbUtil.GetRepository<Sat_task_rewardPO>()
                    .GetFirstAsync(f => f.OperatorID == ipo.OperatorId && f.ItemID == (int)ActivityType.RegisterRewardTask);
                if (taskReward == null)
                    return false;
                string userIp = null;
                try
                {
                    userIp = AspNetUtil.GetRemoteIpString();
                }
                catch
                {
                    //从消息队列过来的，无法获取IP地址，直接忽略，不生成任务
                    return false;
                }
                if (string.IsNullOrEmpty(userIp)) return false;
                var registerTasks = new int[] { 100007, 100039 };
                //如果受IP地址限制，直接返回false，并设置IsIpLimited，前端不显示弹窗
                //var count = await DbUtil.GetRepository<Sa_ip_recordPO>()
                //      .CountAsync(f => f.IpAddress == userIp && registerTasks.Contains(f.ActivityID) && f.OperatorID == ipo.OperatorId);
                var userIpActvity1 = new UserIpActivityDCache(ipo.OperatorId, 100007);
                var userIpActvity2 = new UserIpActivityDCache(ipo.OperatorId, 100039);
                var count = await userIpActvity1.GetNum(userIp) + await userIpActvity2.GetNum(userIp);
                if (count >= taskReward.IpLimits)
                {
                    dto.Activity.IsIpLimited = true;
                    return false;
                }

                if (taskReward.IssueRule == 1)
                    dto.Activity.Bonus = taskReward.RewardAmount.AToM(ipo.CurrencyId);
                else
                {
                    //权重或随机，都取最大金额
                    var maxRewardAmount = await DbUtil.GetRepository<Sat_task_reward_linePO>().AsQueryable()
                        .Where(f => f.OperatorID == ipo.OperatorId && f.ItemID == ipo.ActivityId)
                        .MaxAsync(f => f.RewardAmount);
                    dto.Activity.Bonus = maxRewardAmount.AToM(ipo.CurrencyId);
                }
                return true;
            }

            dto.Activity.ActivityId = ipo.ActivityId;
            var operatorActivityList = LobbyDbCacheUtil.GetAllActivityOperator(ipo.OperatorId, ipo.CurrencyId);

            if (!operatorActivityList.Any(d => d.Status && d.ActivityID == (int)activityId.Value))
                return false;

            dto.Activity.IsValid = true;

            switch (activityId.Value)
            {
                case ActivityType.Register7:
                    //获取配置
                    var field = Register7ConfigDCache.GetField(ipo.OperatorId, ipo.CurrencyId);
                    var register7Config = await new Register7ConfigDCache().GetOrLoadAsync(field);
                    if (!register7Config.HasValue)
                        return false;

                    if (!register7Config.Value.IsSendBonus)
                        return false;

                    dto.Activity.Bonus = register7Config.Value.SendBonus.AToM(ipo.CurrencyId);
                    break;
                default:
                    return false;
            }

            return true;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class BankyService : ISyncService
    {
        public async Task<bool> Search(SyncIpo ipo, SyncDto dto)
        {
            if (string.IsNullOrWhiteSpace(ipo.OperatorId)) return false;

            var bankyConfigDCache = new BankyConfigDCache(ipo.OperatorId);
            var bankyConfig = await bankyConfigDCache.GetAsync();
            if (bankyConfig == default || bankyConfig == null || bankyConfig.OperatorID == null)
                return false;

            var bankyUser = await DbUtil.GetRepository<Sa_banky_userPO>().AsQueryable()
                .Where(_ => _.OperatorID == ipo.OperatorId && _.UserID == ipo.UserId).FirstAsync();
            if (bankyUser == null)
            {
                dto.Banky = new Banky() { IsValid = bankyConfig.Status != 0 };
                return true;
            }

            var bankyDetail = await DbUtil.GetRepository<Sa_banky_detailPO>().AsQueryable()
                .Where(_ => _.OperatorID == ipo.OperatorId && _.UserID == ipo.UserId)
                .OrderByDescending(_ => _.RecDate).FirstAsync();

            if (bankyDetail == null)
            {
                dto.Banky = new Banky() { IsValid = bankyConfig.Status != 0 };
                return true;
            }

            dto.Banky = new Banky()
            {
                IsValid = bankyConfig.Status != 0,
                Times = bankyUser.Times,
                TotalAmount = bankyUser.TotalAmount.AToM(ipo.CurrencyId),
                RefundType = bankyDetail.RefundType,
                RefundAmount = bankyDetail.IsDisplay == 1 ? 0 : bankyDetail.RefundAmount.AToM(ipo.CurrencyId),
                DetailId = bankyDetail.IsDisplay == 1 ? null : bankyDetail.DetailID
            };
            return true;
        }
    }

    public class SyncService
    {
        ILogger<SyncService> _logger;

        public SyncService()
        {
            _logger = LogUtil.CreateLogger<SyncService>();
        }

        /// <summary>
        /// Sync
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        public async Task<SyncDto> Sync(SyncIpo ipo)
        {
            var ret = new SyncDto();

            if (!await CheckParams(ipo)) return ret;

            var globalUserDCache = await GlobalUserDCache.Create(ipo.UserId);
            ipo.OperatorId = await globalUserDCache.GetOperatorIdAsync();
            ipo.CurrencyId = await globalUserDCache.GetCurrencyIdAsync();

            foreach (var item in ipo.SyncTypes)
            {
                var syncService = BuildService(item);

                if (syncService == null) continue;

                await syncService.Search(ipo, ret);
            }
            return ret;
        }

        /// <summary>
        /// 校验参数
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        private async Task<bool> CheckParams(SyncIpo ipo)
        {
            if (ipo.SyncTypes == null || !ipo.SyncTypes.Any())
                return false;

            return true;
        }

        /// <summary>
        /// BuildService
        /// </summary>
        /// <param name="syncEnum"></param>
        /// <returns></returns>
        private ISyncService BuildService(SyncEnum syncEnum)
        {
            return syncEnum switch
            {
                SyncEnum.balance => new BalanceService(),
                SyncEnum.Order => new OrderService(),
                SyncEnum.Activity => new ActivityService(),
                SyncEnum.Banky => new BankyService(),
                _ => null
            };
        }
    }
}
