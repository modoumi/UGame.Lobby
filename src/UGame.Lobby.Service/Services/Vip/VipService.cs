using UGame.Lobby.Common.Enum;
using UGame.Lobby.Repository.ing;
using Newtonsoft.Json;
using SqlSugar;
using AiUo;
using AiUo.AspNet;
using AiUo.Data;
using AiUo.Data.SqlSugar;
using AiUo.DbCaching;
using AiUo.Extensions.AutoMapper;
using AiUo.Extensions.RabbitMQ;
using AiUo.Extensions.StackExchangeRedis;
using AiUo.Logging;
using AiUo.Text;
using UGame.Lobby.Service.Caching;
using UGame.Lobby.Service.Common;
using UGame.Lobby.Service.Dtos.Responses;
using UGame.Lobby.Service.Services.Cash;
using Xxyy.Common;
using Xxyy.Common.Caching;
using Xxyy.Common.Services;
using Xxyy.DAL;
using Xxyy.MQ.Lobby.Activity;

namespace UGame.Lobby.Service.Services.Vip;

public class VipService
{
    /// <summary>
    /// 获取用户vip相关信息
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    /// <exception cref="CustomException"></exception>
    public async Task<UserVipInfoDto> GetVipInfo(UserVipInfoIpo ipo)
    {
        var userEo = await DbUtil.GetRepository<S_userPO>().AsQueryable()
            .Where(d => d.UserID.Equals(ipo.UserId)).FirstAsync();

        if (userEo == null) return new UserVipInfoDto();

        var ret = new UserVipInfoDto
        {
            Vip = userEo.VIP,
            Point = userEo.Point.AToM(ipo.CurrencyId)
        };

        //获取vip配置
        var vipConfigList = LobbyDbCacheUtil.GetOperatorVipConfigList(ipo.OperatorId);
        if (!vipConfigList.Any()) return ret;
        //最高vip等级
        var vipMaxGrade = vipConfigList.Select(v => v.VipGrade).Max();
        //下一等级vip配置
        var nextVipGrade = userEo.VIP + 1 > vipMaxGrade ? userEo.VIP : userEo.VIP + 1;
        var nextVipConfig = vipConfigList.Where(_ => _.OperatorID == ipo.OperatorId && _.VipGrade == nextVipGrade).FirstOrDefault();
        var currVipConfig = vipConfigList.Where(_ => _.OperatorID == ipo.OperatorId && _.VipGrade == userEo.VIP).FirstOrDefault();
        if (currVipConfig == null || nextVipConfig == null) return ret;
        //下一级vip奖金
        ret.GradeReward = nextVipConfig.GradeReward.AToM(ipo.CurrencyId);
        //下一级最小打码量
        ret.NextGradeMinBet = nextVipConfig.BetMinAmount.AToM(ipo.CurrencyId);
        ret.CurrentGradeMinBet = currVipConfig.BetMinAmount.AToM(ipo.CurrencyId);

        if (userEo.VIP > 0)
        {
            ret.WeekReward = currVipConfig.WeekReward.AToM(ipo.CurrencyId);
            if (userEo.VIP < vipMaxGrade)
            {
                ret.UpgradeRequireBet = (nextVipConfig.BetMinAmount - currVipConfig.BetMinAmount).AToM(ipo.CurrencyId);
                ret.UpgradeHasBet = (userEo.Point - currVipConfig.BetMinAmount).AToM(ipo.CurrencyId);
            }
            else
            {
                ret.GradeReward = 0;
                ret.UpgradeRequireBet = userEo.Point.AToM(ipo.CurrencyId);
                ret.UpgradeHasBet = userEo.Point.AToM(ipo.CurrencyId);
            }

            var sOperatorEo = DbCacheUtil.GetOperator(ipo.OperatorId);
            if (sOperatorEo.OperatorVersion == (int)OperatorVersionsEnum.longVersion)
            {
                await VipinfoForLongVersion(ret, currVipConfig, ipo.UserId);
                ret.AllowCashAmount = ((long)ret.AllowCashAmount).AToM(ipo.CurrencyId);
                ret.CashAmountLimit = ((long)ret.CashAmountLimit).AToM(ipo.CurrencyId);
                var currentVipConfig = vipConfigList.Find(f => f.VipGrade == userEo.VIP);
                var maxVip = vipConfigList.Max(f => f.VipGrade);
                currentVipConfig ??= vipConfigList.FirstOrDefault(f => f.VipGrade == maxVip);
                ret.Rate = Convert.ToInt32(currentVipConfig.CashRate * 100);
                ret.Version = sOperatorEo.OperatorVersion;
            }
        }
        else
        {
            ret.WeekReward = 0;
            ret.UpgradeRequireBet = nextVipConfig.BetMinAmount.AToM(ipo.CurrencyId);
            ret.UpgradeHasBet = userEo.Point.AToM(ipo.CurrencyId);
        }

        ret.UpgradeHasBet = ret.UpgradeHasBet > ret.UpgradeRequireBet ? 0 : ret.UpgradeHasBet;

        return ret;
    }

    private async Task VipinfoForLongVersion(UserVipInfoDto dto, Sc_vip_configEO currVipConfig, string userId)
    {
        dto.CashNumLimit = currVipConfig.DayCashNumLimit;
        dto.CashAmountLimit = currVipConfig.DayCashAmountLimit;

        //整数有充值，负数有提现，上下加上vip等级的限制
        var userCashInfo = await new UserCashService().GetTotalCashNumOrAmount(userId);

        //当天可提现次数
        dto.AllowCashNum = dto.CashNumLimit - Convert.ToInt32(userCashInfo.sumCashNum);
        if (dto.AllowCashNum < 0)
            dto.AllowCashNum = 0;

        //当天可提现金额，当日提现额度-今日已提现的金额绝对值
        dto.AllowCashAmount = dto.CashAmountLimit - userCashInfo.sumCashAmount;
        if (dto.AllowCashAmount < 0)
            dto.AllowCashAmount = 0;
        if (dto.AllowCashAmount > currVipConfig.DayCashAmountLimit)
            dto.AllowCashAmount = currVipConfig.DayCashAmountLimit;
    }

    /// <summary>
    /// 获取vip等级数据
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    public async Task<VipConfigDto> GetVipConfig(VipConfigIpo ipo)
    {
        var sUserEo = await DbUtil.GetRepository<S_userPO>().AsQueryable().Where(d => d.UserID.Equals(ipo.UserId)).FirstAsync();

        var sUserExEo = await DbUtil.GetRepository<S_user_exPO>().AsQueryable().Where(d => d.UserID.Equals(ipo.UserId)).FirstAsync();

        var userVipDetailEoList = await DbUtil.GetRepository<Sc_vip_reward_detailPO>().AsQueryable()
            .Where(d => d.UserID.Equals(ipo.UserId) && d.RewardType == 1).ToListAsync();

        if (sUserEo == null || sUserExEo == null) return new VipConfigDto();

        ipo.OperatorId = sUserEo.OperatorID;
        ipo.CurrencyId = sUserEo.CurrencyID;

        //所有vip等级配置明细
        var vipConfigEoList = LobbyDbCacheUtil.GetOperatorVipConfigList(ipo.OperatorId);

        if (vipConfigEoList == null || !vipConfigEoList.Any())
            throw new CustomException(LobbyCodes.RS_UNKNOWN, $"Configuration not found.{ipo.OperatorId}|{ipo.CurrencyId}");

        var ret = new VipConfigDto
        {
            Items = vipConfigEoList.Map<List<VipConfigItem>>()
        };
        //当前用户vip等级配置
        ret.CurrVipConfig = ret.Items.FirstOrDefault(d => d.VipGrade == sUserEo.VIP);

        //当前版本
        var sOperator = DbCacheUtil.GetOperator(sUserEo.OperatorID);
        ret.Version = sOperator.OperatorVersion;
        ret.Point = sUserEo.Point.AToM(ipo.CurrencyId);
        ret.TotalPayAmount = sUserExEo.TotalPayAmount.AToM(ipo.CurrencyId);


        if (sOperator.OperatorVersion == (int)OperatorVersionsEnum.longVersion)
            await InitLongVersionVipConfig(ret, sUserEo, vipConfigEoList, userVipDetailEoList);

        return ret;
    }

    /// <summary>
    /// 初始化vip奖励列表
    /// </summary>
    /// <param name="dto"></param>
    /// <returns></returns>
    public async Task InitLongVersionVipConfig(VipConfigDto dto, S_userPO sUserEo, List<Sc_vip_configPO> vipConfigEoList, List<Sc_vip_reward_detailPO> userVipDetailEoList)
    {
        //用户可领取奖励vip等级
        var rewardVipGrade = sUserEo.VIP;
        var vipConfigEo = vipConfigEoList.Find(d => sUserEo.Point >= d.BetMinAmount && sUserEo.Point < d.BetMaxAmount);
        if (vipConfigEo != null)
            rewardVipGrade = vipConfigEo.VipGrade;

        var drawableItems = dto.Items.FindAll(f => f.VipGrade <= rewardVipGrade);
        foreach (var item in drawableItems)
        {
            if (item.VipGrade > rewardVipGrade || item.GradeReward == 0)
                continue;

            var rewardDetail = userVipDetailEoList.Where(d => d.UserID == sUserEo.UserID
                  && d.VipGrade == item.VipGrade && d.RewardType == 1).FirstOrDefault();

            if (rewardDetail == null || rewardDetail.ReceiveStatus == 0)
                item.Status = VipRewardStatusEnum.Allow;
            else item.Status = VipRewardStatusEnum.Received;
        }
    }

    /// <summary>
    /// 领取vip升级奖励
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    public async Task<decimal> ReceiveAsync(VipReceiveIpo ipo)
    {
        using var lockObj = await RedisUtil.LockAsync($"VipReceive.{ipo.UserId}.{ipo.VipGrade}", 5);
        if (!lockObj.IsLocked)
        {
            lockObj.Release();
            throw new CustomException(CommonCodes.UserConcurrent, $"lobby:VipReceive:Request for lock failed.Key:VipReceive.{ipo.UserId}.{ipo.VipGrade}");
        }

        var globalUserDCache = await GlobalUserDCache.Create(ipo.UserId);
        ipo.OperatorId = await globalUserDCache.GetOperatorIdAsync();
        ipo.CurrencyId = await globalUserDCache.GetCurrencyIdAsync();

        //当前运营商所有vip等级配置
        var vipConfigEoList = LobbyDbCacheUtil.GetOperatorVipConfigList(ipo.OperatorId);
        if (vipConfigEoList == null || !vipConfigEoList.Any())
            throw new CustomException(LobbyCodes.RS_UNKNOWN, $"Configuration not found.{ipo.OperatorId}|{ipo.CurrencyId}");

        if (!vipConfigEoList.Any(d => d.VipGrade == ipo.VipGrade && d.GradeReward > 0)) return 0;

        var sUserEo = await DbUtil.GetRepository<S_userPO>().AsQueryable().Where(d => d.UserID.Equals(ipo.UserId)).FirstAsync();
        var vipRewardDetailEo = await DbUtil.GetRepository<Sc_vip_reward_detailPO>().AsQueryable()
            .Where(d => d.UserID == ipo.UserId && d.VipGrade == ipo.VipGrade).FirstAsync();

        if (sUserEo == null) return 0;

        //已领取
        if (vipRewardDetailEo != null && vipRewardDetailEo.ReceiveStatus == 1) return 0;

        //用户实际可领取vip升级奖励配置
        var vipConfigEo = vipConfigEoList.Where(d => sUserEo.Point >= d.BetMinAmount && sUserEo.Point < d.BetMaxAmount).FirstOrDefault();

        //领取奖励等级大于实际可领取等级
        if (ipo.VipGrade > vipConfigEo.VipGrade) return 0;

        vipConfigEo = vipConfigEoList.Where(d => d.VipGrade == ipo.VipGrade).FirstOrDefault();

        decimal result = 0;
        TransactionManager tm = new TransactionManager();
        var rewardDetailMo = new Sc_vip_reward_detailMO();
        var currencyChangeService = new CurrencyChangeService(ipo.UserId);
        try
        {
            var detailId = ObjectId.NewId();
            var utcNow = DateTime.UtcNow;

            //1、写入sa_weeklycard_deail
            await rewardDetailMo.AddAsync(new Sc_vip_reward_detailEO()
            {
                DetailID = detailId,
                UserID = ipo.UserId,
                UserKind = (int)await globalUserDCache.GetUserKindAsync(),
                FromId = await globalUserDCache.GetFromIdAsync(),
                FromMode = await globalUserDCache.GetFromModeAsync(),
                OperatorID = ipo.OperatorId,
                CountryID = await globalUserDCache.GetCountryIdAsync(),
                CurrencyID = ipo.CurrencyId,
                VipGrade = vipConfigEo.VipGrade,
                RewardAmount = vipConfigEo.GradeReward,
                RewardType = 1,
                NotifyStatus = 1,
                ReceiveStatus = 1,
                RecDate = utcNow,
                RewardDate = utcNow,
                FlowMultip = vipConfigEo.GradeFlowMultip
            }, tm);
            //2、写入货币变化

            var currencyChangeReq = new CurrencyChangeReq()
            {
                UserId = ipo.UserId,
                AppId = ipo.AppId,
                OperatorId = ipo.OperatorId,
                CurrencyId = ipo.CurrencyId,
                Reason = "vip升级奖励",
                Amount = vipConfigEo.GradeReward,
                SourceType = (int)ActivityType.Vip,
                SourceTable = "sc_vip_reward_detail",
                SourceId = detailId,
                ChangeTime = DateTime.UtcNow,
                ChangeBalance = CurrencyChangeBalance.Bonus,
                FlowMultip = vipConfigEo.GradeFlowMultip,
                TM = tm
            };

            //5、写s_currency_change
            var changeMsg = await currencyChangeService.Add(currencyChangeReq);
            if (changeMsg == null) throw new Exception("写入s_currency_change失败");

            tm.Commit();
            result = vipConfigEo.GradeReward.AToM(ipo.CurrencyId);

            await MQUtil.PublishAsync(changeMsg);

            return result;
        }
        catch (Exception ex)
        {
            tm.Rollback();
            LogUtil.GetContextLogger().AddException(ex).AddMessage($"ipo:{JsonConvert.SerializeObject(ipo)}");
            return 0;
        }
    }

    public async Task<List<VipBenefitResponse>> GetBenefitList(UserVipInfoIpo ipo)
    {
        var operatorInfo = DbCachingUtil.GetSingle<S_operatorPO>(f => f.OperatorID, ipo.OperatorId);
        if (operatorInfo == null || operatorInfo.OperatorVersion == 0)
            throw new CustomException("只支持长线版本");

        var result = new List<VipBenefitResponse>();
        var vipConfigInfos = DbCachingUtil.GetList<Sc_vip_configPO>(f => f.OperatorID, ipo.OperatorId);
        vipConfigInfos.Sort((x, y) => x.VipGrade.CompareTo(y.VipGrade));

        var itemIds = new int[] { 100030, 100031, 100032 };
        var allOperatorItems = DbCachingUtil.GetList<Sat_item_operatorPO>(f => f.OperatorID, ipo.OperatorId);
        var myOperatorItems = allOperatorItems.FindAll(f => f.Status == 1
            && f.OperatorID == ipo.OperatorId && itemIds.Contains(f.ItemID));

        var allItems = DbCachingUtil.GetAllList<Sat_itemPO>();
        var myItems = allItems.FindAll(f => f.Status == 1 && itemIds.Contains(f.ItemID));

        var allTasks = DbCachingUtil.GetAllList<Sat_taskPO>();
        var myTasks = allTasks.FindAll(f => f.Status == 1 && myItems.Exists(t => t.ItemID == f.ItemID)
            && myOperatorItems.Exists(t => t.ItemID == f.ItemID) && itemIds.Contains(f.ItemID));

        var rebateVips = await DbUtil.GetRepository<Sat_rebate_box_vipPO>().GetListAsync(f => f.OperatorID == ipo.OperatorId);
        if (myTasks != null && myTasks.Count > 0 && rebateVips != null && rebateVips.Count > 0)
        {
            vipConfigInfos.ForEach(f =>
            {
                var dailyRebateVip = rebateVips.Find(t => t.ItemID == 100030 && t.VipGrade == f.VipGrade);
                var weeklyRebateVip = rebateVips.Find(t => t.ItemID == 100031 && t.VipGrade == f.VipGrade);
                result.Add(new VipBenefitResponse
                {
                    VipGrade = f.VipGrade,
                    CashRate = (decimal)f.CashRate,
                    DailyRate = (decimal)(dailyRebateVip?.RewardRate ?? 0),
                    WeeklyRate = (decimal)(weeklyRebateVip?.RewardRate ?? 0)
                });
            });
        }
        return result;
    }

    public async Task<List<VipRebateResponse>> GetRebateList(UserVipInfoIpo ipo)
    {
        var operatorInfo = DbCachingUtil.GetSingle<S_operatorPO>(f => f.OperatorID, ipo.OperatorId);
        if (operatorInfo == null || operatorInfo.OperatorVersion == 0)
            throw new CustomException("只支持长线版本");

        var allOperatorItems = DbCachingUtil.GetList<Sat_item_operatorPO>(f => f.OperatorID, ipo.OperatorId);
        var myOperatorItems = allOperatorItems.FindAll(f => f.Status == 1);
        if (myOperatorItems == null || myOperatorItems.Count == 0) return null;

        var allItems = DbCachingUtil.GetAllList<Sat_itemPO>();
        var myItems = allItems.FindAll(f => f.Status == 1);
        if (myItems == null || myItems.Count == 0) return null;

        var itemIds = new int[] { 100030, 100031, 100032 };
        var allTasks = DbCachingUtil.GetAllList<Sat_taskPO>();
        var myTasks = allTasks.FindAll(f => f.Status == 1 && myItems.Exists(t => t.ItemID == f.ItemID)
            && myOperatorItems.Exists(t => t.ItemID == f.ItemID) && itemIds.Contains(f.ItemID));
        if (myTasks == null || myTasks.Count == 0) return null;

        var userInfo = await DbUtil.GetRepository<S_userPO>()
            .GetFirstAsync(f => f.UserID == ipo.UserId);
        var vipGrade = userInfo.VIP;

        var itemLangs = await DbUtil.GetRepository<Sat_reward_center_item_langPO>()
            .GetListAsync(f => f.OperatorID == ipo.OperatorId && itemIds.Contains(f.ItemID) && f.LangID == ipo.LangId);

        var rebateConfigs = await DbUtil.GetRepository<Sat_rebate_box_configPO>()
            .GetListAsync(f => f.OperatorID == ipo.OperatorId && itemIds.Contains(f.ItemID));
        var rebateConfigLines = await DbUtil.GetRepository<Sat_rebate_box_config_linePO>()
            .GetListAsync(f => f.OperatorID == ipo.OperatorId && itemIds.Contains(f.ItemID));
        var rebateVips = await DbUtil.GetRepository<Sat_rebate_box_vipPO>()
           .GetListAsync(f => f.OperatorID == ipo.OperatorId && itemIds.Contains(f.ItemID) && f.VipGrade == vipGrade);

        //当前的日返是用昨天的数据生成
        var dayId = DateTime.UtcNow.ToLocalTime(ipo.OperatorId).Date;
        var weeklyDayId = DateTimeUtil.BeginDayOfWeek(dayId);
        var monthlyDayId = DateTimeUtil.LastDayOfPrdviousMonth(dayId).AddDays(1);

        var dailyItemIds = myTasks.FindAll(f => f.Frequency == 1).Select(f => f.ItemID).ToList();
        var weeklyItemIds = myTasks.FindAll(f => f.Frequency == 2).Select(f => f.ItemID).ToList();
        var monthlyItemIds = myTasks.FindAll(f => f.Frequency == 3).Select(f => f.ItemID).ToList();

        var rebateBoxCondition = Expressionable.Create<Sat_rebate_boxPO>()
            .OrIF(dailyItemIds.Count > 0, f => dailyItemIds.Contains(f.ItemID) && f.DayID == dayId)
            .OrIF(weeklyItemIds.Count > 0, f => weeklyItemIds.Contains(f.ItemID) && f.DayID == weeklyDayId)
            .OrIF(monthlyItemIds.Count > 0, f => monthlyItemIds.Contains(f.ItemID) && f.DayID == monthlyDayId)
            .And(f => f.UserID == ipo.UserId)
            .ToExpression();
        var rebateBoxs = await DbUtil.GetRepository<Sat_rebate_boxPO>().GetListAsync(rebateBoxCondition);

        var nextDayId = dayId.AddDays(1);
        var nextWeeklyDayId = weeklyDayId.AddDays(7);
        var nextMonthlyDayId = monthlyDayId.AddMonths(1);
        var nextRebateBoxCondition = Expressionable.Create<Sat_rebate_boxPO>()
           .OrIF(dailyItemIds.Count > 0, f => dailyItemIds.Contains(f.ItemID) && f.DayID >= nextDayId)
           .OrIF(weeklyItemIds.Count > 0, f => weeklyItemIds.Contains(f.ItemID) && f.DayID >= nextWeeklyDayId)
           .OrIF(monthlyItemIds.Count > 0, f => monthlyItemIds.Contains(f.ItemID) && f.DayID >= nextMonthlyDayId)
           .And(f => f.UserID == ipo.UserId)
           .ToExpression();
        var nextRebateBoxs = await DbUtil.GetRepository<Sat_rebate_boxPO>().GetListAsync(nextRebateBoxCondition);

        var result = new List<VipRebateResponse>();
        foreach (var myTask in myTasks)
        {
            DateTime taskDayId = default;
            DateTime nextTaskDayId = default;
            DateTime beginDate = default;
            DateTime endDate = default;
            DateTime nextBeginDate = default;
            DateTime nextEndDate = default;
            switch (myTask.ItemID)
            {
                case 100030:
                    taskDayId = dayId;
                    nextTaskDayId = taskDayId.AddDays(1);
                    beginDate = taskDayId.AddDays(-1);
                    endDate = taskDayId;
                    nextBeginDate = taskDayId;
                    nextEndDate = taskDayId.AddDays(1);
                    break;
                case 100031:
                    taskDayId = DateTimeUtil.BeginDayOfWeek(dayId);
                    nextTaskDayId = taskDayId.AddDays(7);
                    beginDate = taskDayId.AddDays(-7);
                    endDate = taskDayId;
                    nextBeginDate = taskDayId;
                    nextEndDate = taskDayId.AddDays(7);
                    break;
                case 100032:
                    taskDayId = DateTimeUtil.LastDayOfPrdviousMonth(dayId).AddDays(1);
                    nextTaskDayId = taskDayId.AddMonths(1);
                    beginDate = taskDayId.AddMonths(-1);
                    endDate = taskDayId;
                    nextBeginDate = taskDayId;
                    nextEndDate = taskDayId.AddMonths(1);
                    break;
            }
            var rebateBox = rebateBoxs.Find(f => f.ItemID == myTask.ItemID && f.DayID == taskDayId);
            var nextRebateBox = nextRebateBoxs.Find(f => f.ItemID == myTask.ItemID && f.DayID == nextTaskDayId);

            var myItemLang = itemLangs.Find(f => f.ItemID == myTask.ItemID && f.LangID == ipo.LangId);
            var rewardAmount = rebateBox?.RewardAmount.AToM(ipo.CurrencyId) ?? 0L;
            var nextRewardAmount = nextRebateBox?.RewardAmount.AToM(ipo.CurrencyId) ?? 0L;
            var myRebateConfig = rebateConfigs.Find(f => f.ItemID == myTask.ItemID);
            double rewardRate = 0;
            if (myRebateConfig.IsUseVip)
            {
                var myRebateVipConfig = rebateVips.Find(f => f.ItemID == myTask.ItemID);
                rewardRate = myRebateVipConfig.RewardRate;
            }
            else
            {
                var myRebateConfigLine = rebateConfigLines.Find(f => f.ItemID == myTask.ItemID);
                rewardRate = myRebateConfigLine.RewardRate;
            }
            result.Add(new VipRebateResponse
            {
                RewardId = rebateBox?.RewardID,
                ItemId = myTask.ItemID,
                Title = myItemLang.Title,
                TipContent = myItemLang.TipContent,
                RewardRate = rewardRate,
                DayId = taskDayId,
                BeginDate = beginDate,
                EndDate = endDate,
                RewardAmount = (long)rewardAmount,
                Status = rebateBox?.Status ?? 0,
                NextBeginDate = nextBeginDate,
                NextEndDate = nextEndDate,
                NextRewardAmount = (long)nextRewardAmount
            });
        }
        return result;
    }

    /// <summary>
    /// 领取日周月返奖励
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    /// <exception cref="CustomException"></exception>
    public async Task<decimal> ReceiveRebateReward(VipRebateRewardIpo ipo)
    {
        if (string.IsNullOrEmpty(ipo.UserId))
            throw new CustomException($"参数不能为null，UserId");
        if (string.IsNullOrEmpty(ipo.OperatorId))
            throw new CustomException($"参数不能为null，OperatorId");
        if (string.IsNullOrEmpty(ipo.RewardId))
            throw new CustomException($"参数不能为null，RewardId");

        var sOperatorInfo = DbCachingUtil.GetSingle<S_operatorPO>(f => f.OperatorID, ipo.OperatorId);
        if (sOperatorInfo == null || sOperatorInfo.OperatorVersion != 1)
            throw new CustomException($"领取失败，非长线版本不开放，Versions：{sOperatorInfo.OperatorVersion}");

        //不存在或已领取
        var boxData = await DbUtil.GetRepository<Sat_rebate_boxPO>()
            .GetFirstAsync(f => f.UserID == ipo.UserId && f.RewardID == ipo.RewardId);

        //不是本人领取
        if (boxData.UserID != ipo.UserId)
            throw new CustomException($"领取失败，非本人领奖");

        if (boxData.Status > 1)
            throw new CustomException($"奖励已领取，Status:{boxData?.Status}");

        var dayId = DateTime.UtcNow.ToLocalTime(ipo.OperatorId).Date;
        if (boxData.DayID != dayId)
            throw new CustomException($"领奖日期不正确，不可领取，DayId:{boxData.DayID:yyyy-MM-dd}");

        using var lockObj = await RedisUtil.LockAsync($"ReceiveRebateVipBoxReward.{ipo.UserId}.{ipo.RewardId}", 20);
        if (!lockObj.IsLocked)
        {
            lockObj.Release();
            throw new CustomException(CommonCodes.UserConcurrent, $"Activities01:RewardCenterService.ReceiveRebateBoxReward:Request for lock failed.Key:ReceiveRebateBoxReward.{ipo.UserId}.{ipo.RewardId}");
        }

        decimal result = 0;
        var boxSetting = await DbUtil.GetRepository<Sat_rebate_box_configPO>()
            .GetSingleAsync(f => f.OperatorID == ipo.OperatorId && f.ItemID == boxData.ItemID);

        var tm = new DbTransactionManager();
        try
        {
            await tm.BeginAsync();
            boxData.Status = 2;
            boxData.UpdateTime = DateTime.UtcNow;
            await tm.GetRepository<Sat_rebate_boxPO>().AsUpdateable(boxData)
               .UpdateColumns("Status", "RedirectRewardAmount", "UpdateTime")
               .ExecuteCommandAsync();

            var currencyService = new CurrencyChange2Service(ipo.UserId);
            var currencyChangeReq = new CurrencyChangeReq();
            currencyChangeReq.UserId = ipo.UserId;
            currencyChangeReq.AppId = ipo.AppId;
            currencyChangeReq.OperatorId = ipo.OperatorId;
            currencyChangeReq.CurrencyId = ipo.CurrencyId;
            currencyChangeReq.UserIp = AspNetUtil.GetRemoteIpString();
            currencyChangeReq.Reason = $"VIP返奖宝箱{boxData.ItemID}活动，DetailId:{boxData.RewardID}";
            currencyChangeReq.Amount = boxData.RewardAmount;
            currencyChangeReq.SourceType = boxData.ItemID;
            currencyChangeReq.SourceTable = "sat_rebate_box";
            currencyChangeReq.SourceId = boxData.RewardID;
            currencyChangeReq.ChangeTime = DateTime.UtcNow;
            currencyChangeReq.ChangeBalance = boxData.IsBonus ? CurrencyChangeBalance.Bonus : CurrencyChangeBalance.Cash;
            currencyChangeReq.FlowMultip = boxData.FlowMultip;
            currencyChangeReq.DbTM = tm;
            var changeMsg = await currencyService.Add(currencyChangeReq);

            result = boxData.RewardAmount.AToM(ipo.CurrencyId);

            await tm.CommitAsync();

            await MQUtil.PublishAsync(changeMsg);
            await MQUtil.PublishAsync(new UserActivityMsg()
            {
                UserId = ipo.UserId,
                ActivityType = changeMsg.SourceType
            });
        }
        catch (Exception ex)
        {
            await tm.RollbackAsync();
            result = 0;
            LogUtil.GetContextLogger()
                .AddException(ex)
                .AddField("ReceiveBoxReward.Source", "RewardCenterService.ReceiveBoxReward")
                .AddField("ReceiveBoxReward.BoxData", JsonConvert.SerializeObject(boxData));
            Console.WriteLine($"ReceiveBoxReward Error, Detail:{ex},Request: {JsonConvert.SerializeObject(boxData)}");
            throw new CustomException("领取失败");
        }
        return result;
    }
}
