using UGame.Lobby.Common.Enum;
using UGame.Lobby.Repository.ing;
using Newtonsoft.Json;
using Pipelines.Sockets.Unofficial.Arenas;
using AiUo;
using AiUo.Data;
using AiUo.Extensions.RabbitMQ;
using AiUo.Logging;
using AiUo.Randoms;
using UGame.Lobby.Service.Caching;
using UGame.Lobby.Service.Common;
using Xxyy.Common;
using Xxyy.Common.Caching;
using Xxyy.Common.Services;
using Xxyy.MQ.Lobby.Activity;

namespace UGame.Lobby.Service.Services.Activity.SigninNew
{
    public class SigninNewService
    {
        private Sa_signin100012_configMO _rewardConfigMo = new();

        private Sa_signin100012_detailMO _rewardDetailMo = new();

        #region 签到列表


        /// <summary>
        /// 签到列表
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        public async Task<SigninNewListDto> LoadAsync(SigninNewListIpo ipo)
        {
            //初始化参数
            await InitSigninNewListIpo(ipo);

            //重新计算周期
            if (await IsReset(ipo))
                return await ResetExcute(ipo);

            return await MainExcute(ipo);
        }

        /// <summary>
        /// 是否充值签到周期
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        public async Task<bool> IsReset(SigninNewListIpo ipo)
        {
            //1、用户没有签到数据
            //2、当前日期 > 用户最后一次签到周期截止日期
            //则需要重置签到
            if (ipo.ProcessData.UserLastDetailEo == null
                || ipo.ProcessData.CurrentDate > ipo.ProcessData.UserLastDetailEo.SigninCycleEndDate
                )
                return true;

            return false;
        }

        /// <summary>
        /// 重置
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        public async Task<SigninNewListDto> ResetExcute(SigninNewListIpo ipo)
        {
            var ret = new SigninNewListDto();
            ret.IsSignin = ipo.ProcessData.IsSignin;
            ret.IsMissSignin = ipo.ProcessData.IsMissSignin;
            ret.MissSigninPayAmount = ipo.ProcessData.SigninConfigEo.MissSigninPayAmount.AToM(ipo.CurrencyId);
            ret.SigninPayAmount = ipo.ProcessData.SigninConfigEo.SigninPayAmount.AToM(ipo.CurrencyId);
            ret.ServerTime = $"服务器时间：{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}";
            ret.UtcTime = $"UTC时间：{DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss")}";
            ret.LocalTime = $"运营商当地时间：{ipo.ProcessData.UtcTime.ToLocalTime(ipo.OperatorId).ToString("yyyy-MM-dd HH:mm:ss")}";
            ret.SigninCycleStartDate = $"本次签到周期起始日期：{ipo.ProcessData.SigninCycleStartDate.ToString("yyyy-MM-dd")}";
            ret.SigninCycleEndDate = $"本次签到周期截止日期：{ipo.ProcessData.SigninCycleEndDate.ToString("yyyy-MM-dd")}";

            var signinConfigEoList = ipo.ProcessData.SigninOddsEoList
                                                .OrderBy(d => d.DateNumber)
                                                .GroupBy(d => d.DateNumber)
                                                .ToDictionary(
                                                                d => d.Key,
                                                                d => d.OrderByDescending(d => d.Reward).FirstOrDefault()
                                                );

            var timeNow = ipo.ProcessData.CurrentDate.Date;

            var index = 1;
            foreach (var item in signinConfigEoList)
            {
                ret.Items.Add(new UserSignDetails()
                {
                    UserId = ipo.UserId,
                    IsSelected = timeNow == ipo.ProcessData.CurrentDate,
                    DayId = timeNow.ToString("yyyy-MM-dd"),
                    Reward = item.Value.Reward.AToM(item.Value.CurrencyID),
                    Status = item.Value.IsStartDay ? (int)SigninStatus.Allow : (int)SigninStatus.NoAllow,
                    DateNumber = index
                });
                timeNow = timeNow.AddDays(1);
                index++;
            }


            return ret;
        }

        /// <summary>
        /// 初始化签到列表ipo
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        /// <exception cref="CustomException"></exception>
        public async Task InitSigninNewListIpo(SigninNewListIpo ipo)
        {
            ipo.ProcessData = await GetProcessData(ipo.UserId);
        }

        /// <summary>
        /// 签到列表数据组装
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        public async Task<SigninNewListDto> MainExcute(SigninNewListIpo ipo)
        {
            var ret = new SigninNewListDto();
            ret.IsSignin = ipo.ProcessData.IsSignin;
            ret.IsMissSignin = ipo.ProcessData.IsMissSignin;
            ret.MissSigninPayAmount = ipo.ProcessData.SigninConfigEo.MissSigninPayAmount.AToM(ipo.CurrencyId);
            ret.SigninPayAmount = ipo.ProcessData.SigninConfigEo.SigninPayAmount.AToM(ipo.CurrencyId);
            ret.SigninTimes = ipo.ProcessData.UserLastDetailEoList.Count();
            ret.PreSigninDate = ipo.ProcessData.UserLastDetailEo?.DayId.ToString("yyyy-MM-dd");
            ret.ServerTime = $"服务器时间：{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}";
            ret.UtcTime = $"UTC时间：{DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss")}";
            ret.LocalTime = $"运营商当地时间：{ipo.ProcessData.UtcTime.ToLocalTime(ipo.OperatorId).ToString("yyyy-MM-dd HH:mm:ss")}";
            ret.SigninCycleStartDate = $"本次签到周期起始日期：{ipo.ProcessData.SigninCycleStartDate.ToString("yyyy-MM-dd")}";
            ret.SigninCycleEndDate = $"本次签到周期截止日期：{ipo.ProcessData.SigninCycleEndDate.ToString("yyyy-MM-dd")}";

            //获取签到周期内，每一天奖励值最高的配置数据集合
            var signinOddsEoList = ipo.ProcessData.SigninOddsEoList
                                                .OrderBy(d => d.DateNumber)
                                                .GroupBy(d => d.DateNumber)
                                                .ToDictionary(
                                                                d => d.Key,
                                                                d => d.OrderByDescending(d => d.Reward).ToList().FirstOrDefault()
                                                );
            //签到状态
            var signinStatus = SigninStatus.None;
            //当前周期内可签到日期
            var timeNow = ipo.ProcessData.SigninCycleStartDate.Date;
            //当前周期签到明细
            Sa_signin100012_detailEO rewardDetail = null;
            //当前周期签到日期对应的奖励配置
            Sa_signin100012_oddsEO signinConfigEo = null;
            for (int i = 0; i < ipo.ProcessData.SigninCycle; i++)
            {
                //当前周期签到明细
                rewardDetail = ipo.ProcessData.UserLastDetailEoList.Where(d => d.DayId == timeNow).FirstOrDefault();

                if (timeNow > ipo.ProcessData.CurrentDate.Date)
                    signinStatus = SigninStatus.NoAllow;
                else if (timeNow == ipo.ProcessData.CurrentDate.Date)
                    signinStatus = rewardDetail == null ? SigninStatus.Allow : SigninStatus.Signined;
                else
                    signinStatus = rewardDetail == null ? SigninStatus.MissSignin : SigninStatus.Signined;

                //当前周期签到日期对应的奖励配置
                signinConfigEo = signinOddsEoList.ElementAt(i).Value;
                ret.Items.Add(new UserSignDetails()
                {
                    UserId = ipo.UserId,
                    IsSelected = timeNow == ipo.ProcessData.CurrentDate,
                    DayId = timeNow.ToString("yyyy-MM-dd"),
                    DateNumber = i + 1,
                    Reward = rewardDetail != null ? rewardDetail.Reward.AToM(ipo.CurrencyId) : signinConfigEo.Reward.AToM(signinConfigEo.CurrencyID),
                    RecDate = rewardDetail != null ? new DateTime(rewardDetail.RecDate.Ticks, DateTimeKind.Utc) : null,
                    Status = (int)signinStatus
                });
                //可签到日期 + 1
                timeNow = timeNow.AddDays(1);
            }

            return ret;
        }

        #endregion


        public async Task<SigninNewProcessData> GetProcessData(string userId)
        {
            var globalUserDCache = await GlobalUserDCache.Create(userId);
            var processData = new SigninNewProcessData();
            //运营商编码
            processData.OperatorId = await globalUserDCache.GetOperatorIdAsync();
            //货币编码
            processData.CurrencyId = await globalUserDCache.GetCurrencyIdAsync();
            //签到概率配置List
            processData.SigninOddsEoList = LobbyDbCacheUtil.GetAllSignin100012Odds(processData.OperatorId, processData.CurrencyId);
            if (processData.SigninOddsEoList == null || !processData.SigninOddsEoList.Any())
                throw new CustomException($"odds is missing configuration.{processData.OperatorId}|{processData.CurrencyId}");
            //签到配置
            processData.SigninConfigEo = LobbyDbCacheUtil.GetSignin100012Config(processData.OperatorId, processData.CurrencyId);
            if (processData.SigninConfigEo == null)
                throw new CustomException($"config is missing configuration.{processData.OperatorId}|{processData.CurrencyId}");
            //签到周期
            processData.SigninCycle = processData.SigninOddsEoList.GroupBy(d => d.DateNumber).ToList().Count();
            //当前utc时间
            processData.UtcTime = DateTime.UtcNow;
            //当前日期
            processData.CurrentDate = processData.UtcTime.ToLocalTime(processData.OperatorId).Date;
            //当前周期起始日期
            processData.SigninCycleStartDate = processData.CurrentDate;
            //当前周期截止日期
            processData.SigninCycleEndDate = processData.CurrentDate.AddDays(processData.SigninCycle - 1).Date;
            //用户最后一次签到明细
            processData.UserLastDetailEo= (await _rewardDetailMo.GetTopSortAsync("UserId = @UserId", 1, "DayId desc", userId)).FirstOrDefault();
            if (processData.UserLastDetailEo != null && processData.CurrentDate <= processData.UserLastDetailEo.SigninCycleEndDate)
            {
                processData.SigninCycleStartDate = processData.UserLastDetailEo.SigninCycleStartDate;
                processData.SigninCycleEndDate = processData.UserLastDetailEo.SigninCycleEndDate;
            }
            //用户最近一个签到周期明细
            processData.UserLastDetailEoList = await _rewardDetailMo.GetAsync("UserId = @UserId and DayId >= @StartDate and DayId <= @EndDate", userId, processData.SigninCycleStartDate, processData.SigninCycleEndDate);

            //用户当天充值总金额
            processData.UserDaySumPayAmount = await LobbyUtil.UserCurrentDaySumPay(userId, processData.OperatorId);
            //当天是否允许签到 = 当天充值总额 > 签到需要的充值金额
            processData.IsSignin = processData.UserDaySumPayAmount >= processData.SigninConfigEo.SigninPayAmount;
            //当前可补签次数 = 当天充值总额 / 补签需要的充值金额
            processData.MissSigninTotalCount = processData.UserDaySumPayAmount / processData.SigninConfigEo.MissSigninPayAmount;
            //当天是否允许补签
            processData.IsMissSignin = processData.MissSigninTotalCount > 0;

            return processData;
        }


        public async Task<SigninNewDto> ExecuteAsync(SigninNewIpo ipo)
        {
            var ret = new SigninNewDto();

            var activity = await LobbyUtil.GetSingleActivityAsync(ipo.OperatorId, ipo.CurrencyId, ActivityType.Signin_15);

            //活动已下架或过期
            if (activity == null || !activity.Status)
                throw new CustomException(LobbyCodes.RS_ACTIVITY_EXPIRED);


            var globalUserDCache = await GlobalUserDCache.Create(ipo.UserId);
            var operatorId = await globalUserDCache.GetOperatorIdAsync();
            var currencyId = await globalUserDCache.GetCurrencyIdAsync();

            //下注过程中的数据
            ipo.ProcessData = await GetProcessData(ipo.UserId);
            ret.ServerTime = $"服务器时间：{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}";
            ret.UtcTime = $"UTC时间：{DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss")}";
            ret.LocalTime = $"运营商当地时间：{ipo.ProcessData.UtcTime.ToLocalTime(operatorId).ToString("yyyy-MM-dd HH:mm:ss")}";
            ret.SigninCycleStartDate = $"本次签到周期起始日期：{ipo.ProcessData.SigninCycleStartDate.ToString("yyyy-MM-dd")}";
            ret.SigninCycleEndDate = $"本次签到周期截止日期：{ipo.ProcessData.SigninCycleEndDate.ToString("yyyy-MM-dd")}";

            if (ipo.DateNumber > ipo.ProcessData.SigninCycle)
                return ret;

            //签到日期
            var signinDate = ipo.ProcessData.SigninCycleStartDate;
            
            for (int i = 0; i < ipo.ProcessData.SigninCycle; i++)
            {
                if (ipo.DateNumber == i + 1)
                    break;

                signinDate = signinDate.AddDays(1).Date;
            }

            //签到日期签到明细
            var rewardDetailEo = ipo.ProcessData.UserLastDetailEoList.Where(d => d.DayId == signinDate).FirstOrDefault();

            //签到状态
            var signinStatus = SigninStatus.None;

            if (rewardDetailEo != null)
            {
                signinStatus = SigninStatus.Signined;
                ret.StatusDesc = signinStatus.ToString();
                return ret;
            }
            else
            {
                if (signinDate > ipo.ProcessData.CurrentDate)
                {
                    signinStatus = SigninStatus.NoAllow;
                    ret.StatusDesc = signinStatus.ToString();
                    return ret;
                }
                else if (signinDate == ipo.ProcessData.CurrentDate)
                {
                    signinStatus = SigninStatus.Allow;
                    if (!ipo.ProcessData.IsSignin)
                    {
                        //不满足签到需要的充值金额
                        throw new CustomException(LobbyCodes.RS_NOT_PAYLIMIT, "Not meeting the recharge amount.", result: ipo.ProcessData.SigninConfigEo.SigninPayAmount.AToM(ipo.ProcessData.CurrencyId));
                    }
                }
                else
                {
                    signinStatus = SigninStatus.MissSignin;
                    if (!ipo.ProcessData.IsMissSignin)
                    {
                        //不满足补签需要的充值金额
                        throw new CustomException(LobbyCodes.RS_NOT_PAYLIMIT, "Not meeting the recharge amount.", result: ipo.ProcessData.SigninConfigEo.MissSigninPayAmount.AToM(ipo.ProcessData.CurrencyId));
                    }
                }
            }


            //当天不允许签到
            if (!ipo.ProcessData.IsSignin)
            {
                return ret;
            }


            //签到周期内每一天对应的配置 key=签到序号 value=签到奖励+签到配置
            var signinOddsEoListDic = ipo.ProcessData.SigninOddsEoList
                                            .OrderBy(d => d.DateNumber)
                                            .GroupBy(d => d.DateNumber)
                                            .ToDictionary(
                                                            d => d.Key,
                                                            d => d.OrderByDescending(d => d.Reward).ToList()
                                            );

            //补签
            if (signinStatus == SigninStatus.MissSignin)
            {
                //用户当天未充值
                if (ipo.ProcessData.UserDaySumPayAmount == 0)
                    return ret;

                //当天补签次数
                var missSigninCount = 0;
                if (ipo.ProcessData.UserLastDetailEoList != null 
                    && ipo.ProcessData.UserLastDetailEoList.Any())
                    missSigninCount = ipo.ProcessData.UserLastDetailEoList.Where(d => d.IsMissSignin && d.MissSigninDate == ipo.ProcessData.CurrentDate).Count();

                //当天补签次数 >= 当天可补签次数
                if (missSigninCount >= ipo.ProcessData.MissSigninTotalCount)
                    throw new CustomException(LobbyCodes.RS_NOT_PAYLIMIT, "Not meeting the recharge amount.", result: ipo.ProcessData.SigninConfigEo.MissSigninPayAmount.AToM(ipo.ProcessData.CurrencyId));
            }

            TransactionManager tm = new TransactionManager();

            var currencyChangeService = new CurrencyChangeService(ipo.UserId);
            try
            {
                //签到日对应的配置
                var signinOddsEoList = signinOddsEoListDic.ElementAt(ipo.DateNumber - 1).Value;
                //流水倍数
                var flowMultip = 0F;
                //中奖几率随机数
                var random = RandomUtil.NextInt(1, signinOddsEoList.Sum(d => d.Odds) + 1);
                var startNum = 1;
                foreach (var item in signinOddsEoList)
                {
                    if (item.Odds == 0)
                        continue;
                    if (random >= startNum && random <= (item.Odds + startNum - 1))
                    {
                        ret.RewardAmount = item.Reward.AToM(item.CurrencyID);
                        flowMultip = ipo.ProcessData.SigninConfigEo.FlowMultip;
                        break;
                    }
                    startNum += item.Odds;
                }

                //配置异常，奖励金额为0
                if (ret.RewardAmount == 0)
                    throw new CustomException("sa_signin100012_config Configuration exception.");

                await _rewardDetailMo.AddAsync(new Sa_signin100012_detailEO()
                {
                    DayId = signinDate,
                    UserID = ipo.UserId,
                    Reward = ret.RewardAmount.MToA(ipo.CurrencyId),
                    CurrentCycleNumber = ipo.DateNumber,
                    IsMissSignin = signinStatus == SigninStatus.MissSignin,
                    MissSigninDate = signinStatus == SigninStatus.MissSignin ? ipo.ProcessData.CurrentDate : null,
                    SigninCycleStartDate = ipo.ProcessData.SigninCycleStartDate,
                    SigninCycleEndDate = ipo.ProcessData.SigninCycleEndDate,
                    RecDate = DateTime.UtcNow
                }, tm);

                var currencyChangeReq = new CurrencyChangeReq()
                {
                    UserId = ipo.UserId,
                    AppId = ipo.AppId,
                    OperatorId = ipo.OperatorId,
                    CurrencyId = ipo.CurrencyId,
                    Reason = "1.5签到",
                    Amount = ret.RewardAmount.MToA(ipo.CurrencyId),
                    SourceType = (int)ActivityType.Signin_15,
                    SourceTable = "signin_reward_detail",
                    SourceId = $"{signinDate}|{ipo.UserId}",
                    ChangeTime = DateTime.UtcNow,
                    ChangeBalance = activity.IsBonus ? CurrencyChangeBalance.Bonus : CurrencyChangeBalance.Cash,
                    FlowMultip = flowMultip,
                    TM = tm
                };

                //5、写s_currency_change
                var changeMsg = await currencyChangeService.Add(currencyChangeReq);
                if (changeMsg == null)
                    throw new Exception("写入s_currency_change失败");

                tm.Commit();
                ret.Status = true;

                await MQUtil.PublishAsync(changeMsg);

                await MQUtil.PublishAsync(new UserActivityMsg()
                {
                    UserId = ipo.UserId,
                    ActivityType = (int)ActivityType.Signin_15
                });

                return ret;
            }
            catch (Exception ex)
            {
                tm.Rollback();
                LogUtil.GetContextLogger().AddException(ex).AddMessage($"SignInController.Execute.ipo:{JsonConvert.SerializeObject(ipo)}");
                ret.RewardAmount = 0;
                return ret;
            }
        }

    }

}
