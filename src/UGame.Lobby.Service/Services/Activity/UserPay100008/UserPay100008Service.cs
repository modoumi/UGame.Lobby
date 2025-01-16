using UGame.Lobby.Service.Caching.Activity;
using UGame.Lobby.Service.Services.Activity.PayReward;
using UGame.Lobby.Common.Enum;
using UGame.Lobby.Repository.ing;
using Microsoft.Extensions.Logging;
using AiUo.Logging;
using UGame.Lobby.Service.Caching;
using UGame.Lobby.Service.Common;

namespace UGame.Lobby.Service.Services.Activity.UserPay100008
{
    public class UserPay100008Service
    {

        ILogger<UserPay100008Service> _logger;

        /// <summary>
        /// 构造方法
        /// </summary>
        public UserPay100008Service()
        {
            _logger = LogUtil.CreateLogger<UserPay100008Service>();
        }

        ///// <summary>
        ///// 获取每日充值激励活动充值赠金详情，100008
        ///// </summary>
        ///// <param name="operatorId"></param>
        ///// <param name="currencyId"></param>
        ///// <param name="payAmounts">充值金额列表</param>
        ///// <returns>multiple：赠金倍数，maximum：赠金上限，leastPayForReward：可获赠金的最小充值金额，reward：赠金额度</returns>
        //public async Task<(float multiple, long maximum, long leastPayForReward, Dictionary<long, long> rewards)> GetPayRewardDetail(string operatorId, string currencyId, List<long> payAmounts)
        //{
        //    (float multiple, long maximum, long leastPayForReward, Dictionary<long, long> rewards) ret = (0, 0, 0, new Dictionary<long, long>());

        //    //如果充值金额为空
        //    if (payAmounts == null || !payAmounts.Any()) return ret;

        //    //活动无效
        //    if (!await LobbyUtil.GetActivityIsValid(operatorId, currencyId, ActivityType.UserPay100008))
        //        return ret;

        //    //获取活动配置
        //    var userPayConfig = LobbyDbCacheUtil.GetUserPay100008Config(operatorId, currencyId);
        //    //未找到活动配置
        //    if (userPayConfig == null)
        //    {
        //        _logger.LogError($"UserPay100008Service.GetPayRewardDetail();活动缺少配置.OperatorId:{operatorId},CurrencyId:{currencyId}");
        //        return ret;
        //    }

        //    var userPayDetailConfig = LobbyDbCacheUtil.GetAllUserPay100008DetailConfigs(operatorId, currencyId);
        //    if (userPayDetailConfig == null || !userPayDetailConfig.Any())
        //        return ret;

        //    //提现赠送bonus需要的下注流水倍率
        //    ret.multiple = userPayConfig.FlowMultip;
        //    //赠送bonus上限
        //    ret.maximum = userPayConfig.SendBonusMax;
        //    //赠送bonus需要的充值金额
        //    ret.leastPayForReward = userPayConfig.PayAmountStart;

        //    foreach (var item in payAmounts)
        //    {
        //        var bonus = 0L;
        //        //充值金额 > 赠送bonus需要的最低充值金额
        //        if (item >= userPayConfig.PayAmountStart)
        //        {
        //            var detailConfig = userPayDetailConfig.Where(d => item >= d.PayAmountStart && item < d.PayAmountEnd).FirstOrDefault();

        //            if (detailConfig == null)
        //                continue;

        //            bonus = (long)(item * (decimal)userPayConfig.FlowMultip);
        //            bonus = bonus > userPayConfig.SendBonusMax ? userPayConfig.SendBonusMax : bonus;
        //        }
        //        //如果赠送的bonus大于上限
        //        ret.rewards.TryAdd(item, bonus);
        //    }

        //    return ret;

        //}

        /// <summary>
        /// 获取每日充值激励活动充值赠金详情，100008
        /// </summary>
        /// <param name="operatorId"></param>
        /// <param name="currencyId"></param>
        /// <param name="payAmounts">充值金额列表</param>
        /// <returns>multiple：赠金倍数，maximum：赠金上限，leastPayForReward：可获赠金的最小充值金额，reward：赠金额度</returns>
        public async Task<UserPay100008Data> GetPayRewardDetail(string operatorId, string currencyId, List<long> payAmounts)
        {
            var ret = new UserPay100008Data();

            //如果充值金额为空
            if (payAmounts == null || !payAmounts.Any()) return ret;

            //活动无效
            if (!await LobbyUtil.GetActivityIsValid(operatorId, currencyId, ActivityType.UserPay100008))
                return ret;

            //获取活动配置
            var userPayConfig = LobbyDbCacheUtil.GetUserPay100008Config(operatorId, currencyId);
            //未找到活动配置
            if (userPayConfig == null)
            {
                _logger.LogError($"UserPay100008Service.GetPayRewardDetail();活动缺少配置.OperatorId:{operatorId},CurrencyId:{currencyId}");
                return ret;
            }

            var userPayDetailConfig = LobbyDbCacheUtil.GetAllUserPay100008DetailConfigs(operatorId, currencyId);
            if (userPayDetailConfig == null || !userPayDetailConfig.Any())
                return ret;

            ret.FlowMultip = userPayConfig.FlowMultip;
            ret.MaxSendBonus = userPayConfig.SendBonusMax;
            ret.GetBonusMinAmountLimit = userPayConfig.PayAmountStart;
            ret.DayNumLimit = userPayConfig.DayNumLimit;

            foreach (var item in payAmounts)
            {
                var bonus = 0L;
                var rate = 0F;
                //充值金额 > 赠送bonus需要的最低充值金额
                if (item >= userPayConfig.PayAmountStart)
                {
                    var detailConfig = userPayDetailConfig.Where(d => item >= d.PayAmountStart && item < d.PayAmountEnd).FirstOrDefault();

                    if (detailConfig != null)
                    {
                        bonus = (long)(item * (decimal)detailConfig.SendBonusMultip);
                        bonus = bonus > userPayConfig.SendBonusMax ? userPayConfig.SendBonusMax : bonus;
                        rate = detailConfig.SendBonusMultip;
                    }
                }
                ret.Items.Add(new UserPay100008Item()
                {
                    PayAmount = item,
                    Bonus = bonus,
                    Rate = rate
                });
            }

            return ret;

        }

    }

    public class UserPay100008Data
    { 
        /// <summary>
        /// 流水倍率
        /// </summary>
        public float FlowMultip { get; set; }

        /// <summary>
        /// 最大赠送金额
        /// </summary>
        public long MaxSendBonus { get; set; }

        /// <summary>
        /// 获取bonus最小充值金额
        /// </summary>
        public long GetBonusMinAmountLimit { get; set; }

        /// <summary>
        /// 每日充值可享受优惠的次数
        /// </summary>
        public int DayNumLimit { get; set; }

        /// <summary>
        /// 赠送bonus明细
        /// </summary>
        public List<UserPay100008Item> Items { get; set; } = new List<UserPay100008Item>();
        
    }

    public class UserPay100008Item
    {
        /// <summary>
        /// 充值金额
        /// </summary>
        public long PayAmount { get; set; }
        /// <summary>
        /// 赠送bonus金额
        /// </summary>
        public long Bonus { get; set; }
        /// <summary>
        /// 赠送bonus比例
        /// </summary>
        public float Rate { get; set; } = 0;
    }

}
