using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Extensions.StackExchangeRedis;
using AiUo.Logging;
using AiUo;
using UGame.Lobby.Repository.ing;
using AiUo.Data;
using UGame.Lobby.Service.Caching.Activity.Regpay;
using Xxyy.Common;
using Xxyy.MQ.Bank;
using Xxyy.MQ.Xxyy;

namespace UGame.Lobby.Service.Services.Activity.Regpay
{
    public class RegpayService
    {

        private const int EXPIRE_Day = 1;

        /// <summary>
        /// 注册、首充用户基础数据缓存
        /// </summary>
        RegpayUserDCache _regpayUserDCache;

        Sa_regpay_userMO regpayUserMo = new();

        /// <summary>
        /// 用户全局第一次充值时调用
        /// </summary>
        /// <returns></returns>
        public async Task<RegpayFirstDto> FirstPay(UserFirstPayMsg ipo)
        {
            RegpayFirstDto ret = new RegpayFirstDto();

            LogUtil.Info($"FirstPay:ipo:{JsonConvert.SerializeObject(ipo)}");

            //验证参数
            if (!CheckFirstPayIpo(ipo, ret))
                return ret;

            var regpayUserEo = await GetRegpayUser(ipo.OperatorId, ipo.UserId);

            //如果没有数据，则流程异常，应在大厅初始化时写入sa_regpay_user
            if (regpayUserEo == null)
            {
                ret.Message = $"sa_regpay_user数据不存在.userId={ipo.UserId}";
                LogUtil.Info($"FirstPay:ipo:{JsonConvert.SerializeObject(ipo)},sa_regpay_user数据不存在.userId={ipo.UserId}");
                return ret;
            }

            if (regpayUserEo.IsFirstPay)
            {
                ret.Message = $"首充奖励重复发送";
                LogUtil.Info($"FirstPay:ipo:{JsonConvert.SerializeObject(ipo)},首充奖励重复发送");
                return ret;
            }

            var regpayConfigfield = RegpayConfigDCahce.GetField(ipo.OperatorId, ipo.CurrencyId);
            var regpayConfigDCahce = new RegpayConfigDCahce();
            var regpayConfig = await regpayConfigDCahce.GetOrLoadAsync(regpayConfigfield);

            if (!regpayConfig.HasValue)
            {
                ret.Message = $"sa_regpay_config未配置.OperatorId:{ipo.OperatorId},CurrencyId:{ipo.CurrencyId}";
                LogUtil.Info($"FirstPay:ipo:{JsonConvert.SerializeObject(ipo)},sa_regpay_config未配置.OperatorId:{ipo.OperatorId},CurrencyId:{ipo.CurrencyId}");
                return ret;
            }

            regpayUserEo.IsFirstPay = true;
            regpayUserEo.FirstPay = ipo.PayAmount >= regpayConfig.Value.FirstPayReward ? regpayConfig.Value.FirstPayReward : ipo.PayAmount;
            ipo.PayAmount = regpayUserEo.FirstPay;

            TransactionManager tm = new TransactionManager();
            try
            {
                ret.Success = await regpayUserMo.PutAsync("FirstPay = @FirstPay,SumPay = SumPay + @FirstPay1, IsFirstPay = 1", "IsFirstPay = 0 and UserId = @UserID", ipo.PayAmount, ipo.PayAmount, ipo.UserId) > 0;
                tm.Commit();
            }
            catch (Exception ex)
            {
                tm.Rollback();

                LogUtil.GetContextLogger().AddException(ex).AddMessage($"FirstPay更新首充奖励失败，exMessage:{ex.Message},request:{JsonConvert.SerializeObject(ipo)},regpayUserEo:{JsonConvert.SerializeObject(regpayUserEo)}");
            }

            if (ret.Success)
            {
                var afterRegpayUser = await _regpayUserDCache.GetOrLoadAsync(true, TimeSpan.FromDays(1));
                LogUtil.Info($"FirstPay:ipo:{JsonConvert.SerializeObject(ipo)},afterRegpayUser:{JsonConvert.SerializeObject(afterRegpayUser)}");
            }
            else
            {
                LogUtil.GetContextLogger().AddMessage($"FirstPay更新首充奖励失败，request:{JsonConvert.SerializeObject(ipo)},regpayUserEo:{JsonConvert.SerializeObject(regpayUserEo)}");
            }

            return ret;
        }

        /// <summary>
        /// 用户下注结算后调用
        /// </summary>
        /// <returns></returns>
        public async Task<RegpayBetDto> RegpayBet(UserBetMsg ipo)
        {
            LogUtil.Info($"RegpayBet:ipo:{JsonConvert.SerializeObject(ipo)}");

            var ret = new RegpayBetDto();

            if (!CheckRegpayBetIpo(ipo, ret))
                return ret;

            if (!await CheckAppId(ipo))
            {
                ret.Success = true;
                ret.Message = $@"AppId不属于l_category.TopLevelType=1的分类中";
                return ret;
            }

            var regpayUser = await GetRegpayUser(ipo.OperatorId, ipo.UserId);

            if (regpayUser == null)
            {
                ret.Message = $@"RegpayBet:regpayUser为null.ipo:{JsonConvert.SerializeObject(ipo)}";
                return ret;
            }

            if (regpayUser.SumPay == 0)
            {
                ret.Success = true;
                ret.Message = $@"RegpayBet:暂无可发放奖励.ipo:{JsonConvert.SerializeObject(ipo)}";
                return ret;
            }

            //如果没有数据，则流程异常，应在大厅初始化时写入sa_regpay_user
            if (regpayUser == null)
            {
                ret.Message = $"sa_regpay_user数据不存在.userId={ipo.UserId}";
                LogUtil.Info($"RegpayBet:sa_regpay_user数据不存在");
                return ret;
            }

            //幸运轮盘活动上线后删除，用户未充值账户可能会有钱
            //if (!regpayUser.IsFirstPay)
            //{
            //    ret.Message = $"sa_regpay_user数据异常,未发放首充奖励就直接下注.userId={ipo.UserId}";
            //    LogUtil.Info($"RegpayBet:sa_regpay_user数据异常,未发放首充奖励就直接下注");
            //    return ret;
            //}

            var regpayConfigEo = await GetRegpayConfig(ipo.OperatorId, ipo.CurrencyId);

            if (regpayConfigEo == null)
            {
                ret.Message = $"sa_regpay_config数据不存在.operatorId:{ipo.OperatorId},currencyId:{ipo.CurrencyId}";
                LogUtil.Info($"RegpayBet:sa_regpay_config数据不存在.operatorId:{ipo.OperatorId},currencyId:{ipo.CurrencyId}");
                return ret;
            }

            TransactionManager tm = new TransactionManager();
            //累计下注金额
            long betAmount = regpayUser.SumBet + ipo.BetAmount;
            try
            {
                //如果累计下注金额不满足配置值
                if (betAmount < regpayConfigEo.BetAmount)
                {
                    ret.Success = await regpayUserMo.PutSumBetByPKAsync(ipo.UserId, betAmount, tm) > 0;
                }
                else
                {
                    //本次应该返奖金额
                    var nowReturnRewards = ((regpayUser.SumBet + ipo.BetAmount) / regpayConfigEo.BetAmount) * regpayConfigEo.BetReturnReward;

                    //累计下注金额
                    var nowSumBet = (regpayUser.SumBet + ipo.BetAmount) % regpayConfigEo.BetAmount;

                    regpayUser = await regpayUserMo.GetSingleAsync("OperatorID = @OperatorID and UserID = @UserID", tm, ipo.OperatorId, ipo.UserId);

                    if (nowReturnRewards >= regpayUser.SumPay)
                        nowReturnRewards = regpayUser.SumPay;

                    //更新返奖总额，应返金额
                    ret.Success = await regpayUserMo.PutAsync("SumPay = SumPay - @nowReturnRewards, ReturnRewards = ReturnRewards + @ReturnRewards, SumBet = @SumBet", "0 <= (SumPay - @whereNowReturnRewards) and UserID = @UserID", tm, nowReturnRewards, nowReturnRewards, nowSumBet, nowReturnRewards, ipo.UserId) > 0;
                }

                if (!ret.Success)
                    throw new CustomException($"累计下注值更新失败.ipo:{JsonConvert.SerializeObject(ipo)},regpayUser:{JsonConvert.SerializeObject(regpayUser)}");

                tm.Commit();
            }
            catch (Exception ex)
            {
                tm.Rollback();

                LogUtil.GetContextLogger().AddException(ex).AddMessage($"RegpayBet失败，exMessage:{ex.Message},request:{JsonConvert.SerializeObject(ipo)}");
                ret.Message = $"{ex.Message}";
                return ret;
            }

            if (ret.Success)
                await _regpayUserDCache.GetOrLoadAsync(true, TimeSpan.FromDays(1));

            return ret;
        }

        private async Task<Sa_regpay_userEO> GetRegpayUser(string operatorId, string userId)
        {
            _regpayUserDCache = new RegpayUserDCache(operatorId, userId);
            var regUserEo = await _regpayUserDCache.GetOrLoadAsync();
            if (!regUserEo.HasValue)
                return null;
            return regUserEo.Value;
        }

        private async Task<Sa_regpay_configEO> GetRegpayConfig(string opertorId, string currencyId)
        {
            var field = RegpayConfigDCahce.GetField(opertorId, currencyId);
            var regpayConfigDCahce = new RegpayConfigDCahce();
            var regpayConfigEo = await regpayConfigDCahce.GetOrLoadAsync(field);
            return regpayConfigEo.Value;
        }

        /// <summary>
        /// 验证当前游戏是否积累下注值
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        private async Task<bool> CheckAppId(UserBetMsg ipo)
        {
            TopLevelTypeGameDCache topLevelTypeGameDCache = new TopLevelTypeGameDCache();
            var data = await topLevelTypeGameDCache.GetOrLoadAsync(ipo.OperatorId);

            if (data.HasValue && data.Value.Any(d => d.Equals(ipo.AppId)))
                return true;

            return false;
        }


        /// <summary>
        /// FirstPay参数校验
        /// </summary>
        /// <param name="ipo"></param>
        /// <param name="dto"></param>
        /// <returns></returns>
        private bool CheckFirstPayIpo(UserFirstPayMsg ipo, RegpayFirstDto dto)
        {
            if (string.IsNullOrWhiteSpace(ipo.UserId))
            {
                dto.Message = "userId 为空";
                LogUtil.Info("FirstPay,userId 为空");
                return false;
            }

            if (string.IsNullOrWhiteSpace(ipo.OperatorId))
            {
                dto.Message = "OperatorId 为空";
                LogUtil.Info("FirstPay,OperatorId 为空");
                return false;
            }

            if (string.IsNullOrWhiteSpace(ipo.CountryId))
            {
                dto.Message = "CountryId 为空";
                LogUtil.Info("FirstPay,CountryId 为空");
                return false;
            }

            if (string.IsNullOrWhiteSpace(ipo.CurrencyId))
            {
                dto.Message = "CurrencyId 为空";
                LogUtil.Info("FirstPay,CurrencyId 为空");
                return false;
            }

            if (ipo.PayAmount <= 0)
            {
                dto.Message = "FirstPay 小于等于0";
                LogUtil.Info("FirstPay,FirstPay 小于等于0");
                return false;
            }

            return true;
        }

        /// <summary>
        /// RegpayBet参数校验
        /// </summary>
        /// <param name="ipo"></param>
        /// <param name="dto"></param>
        /// <returns></returns>
        private bool CheckRegpayBetIpo(UserBetMsg ipo, RegpayBetDto dto)
        {
            if (string.IsNullOrWhiteSpace(ipo.UserId))
            {
                dto.Message = "userId 为空";
                LogUtil.Info("RegpayBet,userId 为空");
                return false;
            }

            if (string.IsNullOrWhiteSpace(ipo.OperatorId))
            {
                dto.Message = "OperatorId 为空";
                LogUtil.Info("RegpayBet,OperatorId 为空");
                return false;
            }

            if (string.IsNullOrWhiteSpace(ipo.CountryId))
            {
                dto.Message = "CountryId 为空";
                LogUtil.Info("RegpayBet,CountryId 为空");
                return false;
            }

            if (string.IsNullOrWhiteSpace(ipo.CurrencyId))
            {
                dto.Message = "CurrencyId 为空";
                LogUtil.Info("RegpayBet,CurrencyId 为空");
                return false;
            }

            if (ipo.BetAmount <= 0)
            {
                dto.Message = "BetAmount 小于等于0";
                LogUtil.Info("RegpayBet,BetAmount 小于等于0");
                return false;
            }

            if (string.IsNullOrWhiteSpace(ipo.AppId))
            {
                dto.Message = "AppID 为空";
                LogUtil.Info("RegpayBet,AppID 为空");
                return false;
            }

            return true;
        }

    }
}
