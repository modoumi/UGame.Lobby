using EasyNetQ;
using UGame.Lobby.Common.Enum;
using UGame.Lobby.Repository.ing;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Logging;
using UGame.Lobby.Service.Common;

namespace UGame.Lobby.Service.Services.Activity.PayReward
{
    public class PayRewardService
    {
        private Sa_firstpay_configMO _firstpayConfigMO = new();
        private Sa_firstpay_user_configMO _firstpayUserConfigMO = new();
        private Sa_firstpay_frequency_configMO _firstpayFrequencyConfigMO = new();
        //ILogger<PayRewardService> _logger;

        /// <summary>
        /// 构造方法
        /// </summary>
        public PayRewardService()
        {
            //_logger = LogUtil.CreateLogger<PayRewardService>();
        }

        /// <summary>
        /// 获取充值赠金详情
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="operatorId"></param>
        /// <param name="currencyId"></param>
        /// <param name="payAmounts">充值金额列表</param>
        /// <returns>frequency:本次充值的赠金次数，multiple：赠金倍数，maximum：赠金上限，leastPayForReward：可获赠金的最小充值金额，reward：赠金额度</returns>
        public async Task<(int frequency, long maximum, Dictionary<long, long> rewards)> GetPayRewardDetail(string userID, string operatorId, string currencyId, List<long> payAmounts)
        {
            int _frequency = 0;
            //float _multiple = 0;
            long _maximum = 0;
            //long _leastPayForReward = 0;
            Dictionary<long, long> _rewards = new Dictionary<long, long>();

            if(!await LobbyUtil.GetActivityIsValid(operatorId,currencyId,ActivityType.UserFirstPay5))
                return (_frequency, _maximum, _rewards);

            var userPayAwardConfig = await _firstpayUserConfigMO.GetByPKAsync(userID);
            if (userPayAwardConfig == null || userPayAwardConfig.RemainTimes <= 0) { return (_frequency, _maximum, _rewards); }

            var payAwardConfig = await _firstpayConfigMO.GetByPKAsync(operatorId, currencyId);
            if (payAwardConfig == null || payAwardConfig.TotalTimes <= 0 || string.IsNullOrWhiteSpace(payAwardConfig.MaximumList))
            {
                LogUtil.GetContextLogger().AddMessage($"运营商id:{operatorId}，货币类型:{currencyId}，尚未配置充值赠金倍数或者赠金限额。");
                //_logger.LogError($"运营商id:{operatorId}，货币类型:{currencyId}，尚未配置充值赠金倍数或者赠金限额。");
                return (_frequency, _maximum, _rewards);
            }

            //充值可获得赠金的总次数
            var payRewardTotalTimes = payAwardConfig.TotalTimes;//充值可获得赠金的总次数
            //当前最大赠送金额
            var currMaxBonus = Convert.ToInt64(payAwardConfig.MaximumList);
            //首充配置
            var rewardFirstFrequencyConfig = await _firstpayFrequencyConfigMO.GetAsync($"OperatorID=@OperatorID and SerialNumber=@serialNamuber", operatorId, 1);
            if (rewardFirstFrequencyConfig == null || !rewardFirstFrequencyConfig.Any())
            {
                LogUtil.GetContextLogger().AddMessage($"运营商id:{operatorId}，货币类型:{currencyId}，充值赠金倍数配置有误。");
                //_logger.LogError($"运营商id:{operatorId}，货币类型:{currencyId}，充值赠金倍数配置有误。");
                return (_frequency, _maximum, _rewards);
            }

            foreach (var payAmount in payAmounts)
            {
                var curHitRewardConfig = rewardFirstFrequencyConfig.Where(r => payAmount >= r.PayMin && payAmount < r.PayMax).FirstOrDefault();

                if (curHitRewardConfig == null)
                {
                    _rewards.TryAdd(payAmount, 0L);
                    continue;
                }

                var curMultiple = curHitRewardConfig.PayMultiple;
                var tmpBonus = (long)(payAmount * (decimal)curMultiple);
                var bonus = tmpBonus > currMaxBonus ? currMaxBonus : tmpBonus;
                _rewards.TryAdd(payAmount, (long)bonus);
            }
            return (userPayAwardConfig.RemainTimes, currMaxBonus, _rewards);


            //var payRewardTotalTimes = payAwardConfig.TotalTimes;//充值可获得赠金的总次数
            ////var multipleList = payAwardConfig.PayMultipleList.Split('|');
            //var maximumList = payAwardConfig.MaximumList.Split('|');
            //if (maximumList.Length < 1)
            //{
            //    _logger.LogError($"运营商id:{operatorId}，货币类型:{currencyId}，充值赠金倍数或者赠金限额配置有误。");
            //    return (_frequency, _maximum, _rewards);
            //}

            //var tmpIdx = Math.Abs(userPayAwardConfig.RemainTimes - payRewardTotalTimes);
            //var idxConfig = tmpIdx > maximumList.Length - 1 ? maximumList.Length - 1 : tmpIdx;
            ////var curMultipleStr = multipleList[idxConfig];//当前充值对应的赠金倍数
            //var curMaximumStr = string.IsNullOrWhiteSpace(maximumList[idxConfig]) ? maximumList[0] : maximumList[idxConfig];//当前充值对应的赠金最高限额
            //var rewardFirstFrequencyConfig = await _firstpayFrequencyConfigMO.GetAsync($"OperatorID=@OperatorID and SerialNumber=@serialNamuber", operatorId, 1);//首次充值详情配置
            //if (rewardFirstFrequencyConfig == null || !rewardFirstFrequencyConfig.Any())
            //{
            //    _logger.LogError($"运营商id:{operatorId}，货币类型:{currencyId}，充值赠金倍数配置有误。");
            //    return (_frequency, _maximum, _rewards);
            //}
            //var rewardFrequencyConfig = await _firstpayFrequencyConfigMO.GetAsync($"OperatorID=@OperatorID and SerialNumber=@serialNamuber", operatorId, idxConfig + 1);//充值次序详情配置
            //if (rewardFrequencyConfig == null || !rewardFrequencyConfig.Any()) rewardFrequencyConfig = rewardFirstFrequencyConfig;




            //if (long.TryParse(curMaximumStr, out var curMaximum))
            //{
            //    //_leastPayForReward = payAwardConfig.LeastPayAmount;
            //    foreach (var payAmount in payAmounts)
            //    {
            //        var curHitRewardConfig = rewardFrequencyConfig.Where(r => payAmount >= r.PayMin && payAmount < r.PayMax).First();
            //        var curMultiple = curHitRewardConfig.PayMultiple;
            //        var tmpBonus = (long)(payAmount * (decimal)curMultiple);
            //        var bonus = tmpBonus > curMaximum ? curMaximum : tmpBonus;
            //        _rewards.TryAdd(payAmount, (long)bonus);
            //    }
            //    return (idxConfig + 1, curMaximum, _rewards);
            //}
            //else
            //{
            //    return (_frequency, _maximum, _rewards);
            //}
        }
    }
}
