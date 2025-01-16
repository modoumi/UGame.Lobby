using UGame.Lobby.Common.Enum;
using UGame.Lobby.Repository.ing;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using AiUo;
using AiUo.Data;
using AiUo.Extensions.RabbitMQ;
using AiUo.Extensions.StackExchangeRedis;
using AiUo.Logging;
using UGame.Lobby.Service.Caching;
using UGame.Lobby.Service.Common;
using UGame.Lobby.Service.Services.Activity.Compensation.Dto;
using Xxyy.Common;
using Xxyy.Common.Caching;
using Xxyy.Common.Services;
using Xxyy.MQ.Lobby.Activity;

namespace UGame.Lobby.Service.Services.Activity.Compensation;

/// <summary>
/// 首充日输真金(包赔活动)
/// </summary>
public class CompensationService
{
    private readonly Sa_compensation_configMO _compensationConfigMO = new();
    private readonly Sa_compensation_userMO _compensationUserMO = new();
    private readonly ILogger<CompensationService> _logger;

    public CompensationService()
    {
        _logger = LogUtil.CreateLogger<CompensationService>();
    }

    /// <summary>
    /// 获取包赔信息
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public async Task<CompensationDto> LoadAsync(CompensationIpo input)
    {
        var result = new CompensationDto();

        var localNowDate = DateTime.UtcNow.ToLocalTime(input.OperatorId).Date;
        var yestDate = localNowDate.AddDays(-1);

        //今天充值金额、真金亏损金额(今日数据可能为空,没有返回默认值)
        var (payAmount, _) = await GetUserLoseAmount(localNowDate, input.UserId);

        var firstDeposit = await YesterdayIsFirstDeposit(input.UserId);
        //昨日不是首次充值,不可参加活动
        if (!firstDeposit) return result;

        var yestAmount = await GetUserLoseAmount(yestDate, input.UserId);
        //如果没有损失真金,不可参加活动
        if (yestAmount.loseAmount >= 0) return result;

        result.LoseAmount = Math.Abs(yestAmount.loseAmount.AToM(input.CurrencyId));
        result.Bonus = result.LoseAmount;
        result.PayAmount = Math.Abs(yestAmount.loseAmount.AToM(input.CurrencyId)) - payAmount.AToM(input.CurrencyId);

        var user = await InitCompensationUser(input.UserId);
        if (user == default) return result;

        //充值够了、超了昨日损失的、还需要充值时，都是可领取状态
        //根据金额走充值或者领取接口
        result.IsAllow = CompensationStatus.Allow;

        if (user.ReceiveStatus) result.IsAllow = CompensationStatus.Recived;

        return result;
    }

    /// <summary>
    /// 初始化用户包赔信息
    /// </summary>
    /// <param name="userId"></param>
    /// <returns></returns>
    public async Task<Sa_compensation_userEO> InitCompensationUser(string userId)
    {
        var globalUserDCacheEx = GlobalUserDCacheEx.Create(userId);
        if (await globalUserDCacheEx.GetHasCompensationUser())
            return await _compensationUserMO.GetSingleAsync("UserId=@UserId", userId);

        var globalUserDCache = await GlobalUserDCache.Create(userId);
        var operatorId = await globalUserDCache.GetOperatorIdAsync();

        var localDate = DateTime.UtcNow.ToLocalTime(operatorId).Date;

        var (payAmount, loseAmount) = await GetUserLoseAmount(localDate.AddDays(-1), userId);

        //如果没有损失真金、则不初始化
        if (loseAmount >= 0) return null;

        var compensationConfig = await _compensationConfigMO.GetSingleAsync("OperatorId=@OperatorId", operatorId);
        //运营商
        if (compensationConfig == null) return null;


        TransactionManager tm = new();
        try
        {
            var user = new Sa_compensation_userEO()
            {
                UserId = userId,
                OperatorID = await globalUserDCache.GetOperatorIdAsync(),
                CurrencyID = await globalUserDCache.GetCurrencyIdAsync(),
                FromId = await globalUserDCache.GetFromIdAsync(),
                FromMode = await globalUserDCache.GetFromModeAsync(),
                FirstDayPayAmount = payAmount,
                FirstDayLoseCashAmount = Math.Abs(loseAmount),
                ReceiveStatus = false,
                FlowMultip = compensationConfig.FlowMultip,//读取配置
                RecDate = DateTime.UtcNow
            };
            await _compensationUserMO.AddAsync(user, tm, useIgnore_: true);
            tm.Commit();
            await globalUserDCacheEx.SetHasCompensationUser();
            return user;
        }
        catch (Exception ex)
        {
            tm.Rollback();
            _logger.LogError($"初始化用户包赔信息，执行异常{ex.Message}");
            return null;
        }
    }

    /// <summary>
    /// 获取用户某一天充值真金、亏损真金
    /// </summary>
    /// <param name="date"></param>
    /// <param name="userId"></param>
    /// <returns></returns>
    public async Task<(long payAmount, long loseAmount)> GetUserLoseAmount(DateTime date, string userId)
    {
        (long payAmount, long loseAmount) result = (0, 0);

        var dayUserDCache = await DayUserDCache.Create(date, userId);
        result.payAmount = await dayUserDCache.GetPayAmount();

        //下注（真金+bonus）
        var betAmount = await dayUserDCache.GetBetAmount();
        //返奖（真金+bonus）
        var winAmount = await dayUserDCache.GetWinAmount();
        //bonus下注
        var winBonus = await dayUserDCache.GetWinBonus();
        //bonus返奖
        var betBonus = await dayUserDCache.GetBetBonus();
        //真金亏损金额
        var loseCashAmount = (winAmount - betAmount) - (winBonus - betBonus);

        if ((winAmount - betAmount) >= 0 && winBonus == 0 && betBonus == 0)
            result.loseAmount = 0;//没有损失真金    
        else if (loseCashAmount >= 0)
            result.loseAmount = 0;//没有损失真金    
        else
            result.loseAmount = loseCashAmount;//损失的真金
        return result;
    }

    /// <summary>
    /// 领取包赔奖励(bonus)
    /// </summary>
    /// <returns></returns>
    public async Task<CompensationRecevieDto> RecevieAsync(CompensationRecevieIpo input)
    {

        using var lockObj = await RedisUtil.LockAsync($"Compensation.{input.UserId}", 20);
        if (!lockObj.IsLocked)
        {
            lockObj.Release();
            throw new CustomException(CommonCodes.UserConcurrent, $"lobby:RecevieAsync:Request for lock failed.Key:Compensation.{input.UserId}");
        }

        var result = new CompensationRecevieDto();

        var activity = await LobbyUtil.GetSingleActivityAsync(input.OperatorId, input.CurrencyId, ActivityType.Compensation);

        //活动已下架或过期
        if (activity == null || !activity.Status)
            throw new CustomException(LobbyCodes.RS_ACTIVITY_EXPIRED);

        var firstDeposit = await YesterdayIsFirstDeposit(input.UserId);
        //昨日不是首次充值,不可参加活动
        if (!firstDeposit)
        {
            result.Message = "Yesterday was not the first deposit";
            return result;
        }


        //用户数据
        var compensationUser = await _compensationUserMO.GetSingleAsync("UserId=@UserId", input.UserId);

        //已经领取过的不让领取
        if (compensationUser != default)
        {
            if (compensationUser.ReceiveStatus)
            {
                result.Message = "Already claimed";
                return result;
            }
        }


        var localNowDate = DateTime.UtcNow.ToLocalTime(input.OperatorId).Date;
        var nowAmount = await GetUserLoseAmount(localNowDate, input.UserId);

        //今日充值金额<首次充值当日真金负盈利,不可参加活动
        if (nowAmount.payAmount < Math.Abs(compensationUser.FirstDayLoseCashAmount))
        {
            result.Message = "Not enough deposit amount today";
            return result;
        }

        var compensationConfig = await _compensationConfigMO.GetSingleAsync("OperatorId=@OperatorId", input.OperatorId);

        //以上条件都满足，则触发包赔活动
        TransactionManager tm = new();
        var currencyChangeService = new CurrencyChangeService(input.UserId);
        try
        {
            //1、写入sa_compensation_user
            await _compensationUserMO.PutAsync("Bonus = @Bonus, ReceiveStatus = true, ReceiveDate = @ReceiveDate", "UserId = @UserId", tm, Math.Abs(compensationUser.FirstDayLoseCashAmount), DateTime.UtcNow, input.UserId);

            //2、写入货币变化
            var currencyChangeReq = new CurrencyChangeReq()
            {
                UserId = input.UserId,
                AppId = input.AppId,
                OperatorId = input.OperatorId,
                CurrencyId = input.CurrencyId,
                Reason = "1.8版本包赔",
                Amount = Math.Abs(compensationUser.FirstDayLoseCashAmount),
                SourceType = (int)ActivityType.Compensation,
                SourceTable = "sa_compensation_user",
                SourceId = input.UserId,
                ChangeTime = DateTime.UtcNow,
                ChangeBalance = activity.IsBonus ? CurrencyChangeBalance.Bonus : CurrencyChangeBalance.Cash,
                FlowMultip = compensationConfig.FlowMultip,//读取配置
                TM = tm
            };

            //5、写s_currency_change
            var changeMsg = await currencyChangeService.Add(currencyChangeReq);
            if (changeMsg == null) throw new Exception("写入s_currency_change失败");

            tm.Commit();
            result.IsSuccess = true;
            result.Bonus = Math.Abs(compensationUser.FirstDayLoseCashAmount.AToM(input.CurrencyId));

            await MQUtil.PublishAsync(changeMsg);

            await MQUtil.PublishAsync(new UserActivityMsg()
            {
                UserId = input.UserId,
                ActivityType = (int)ActivityType.Compensation
            });

            return result;
        }
        catch (Exception ex)
        {
            tm.Rollback();
            LogUtil.GetContextLogger().AddException(ex).AddMessage($"CompensationController.RecevieCompensation.ipo:{JsonConvert.SerializeObject(input)}");
            result.Bonus = 0;
            return result;
        }
    }

    /// <summary>
    /// 判断用户昨天是否首次充值
    /// </summary>
    /// <param name="userId"></param>
    /// <returns></returns>
    public async Task<bool> YesterdayIsFirstDeposit(string userId)
    {
        var sql = $@"select BankCallbackTime from sb_bank_order 
                        where UserID = @UserID 
                        and OrderType = 1 and `Status` = 2 
                        and IsAddBalance = 1 order by BankCallbackTime limit 1;";

        var bankCallbackTime = await DbSink.MainDb.ExecSqlScalarAsync<DateTime?>(sql, userId);
        if (bankCallbackTime == default) return false;

        var globalUserDCache = await GlobalUserDCache.Create(userId);
        var operatorId = await globalUserDCache.GetOperatorIdAsync();

        var firstDepositDate = bankCallbackTime.Value.ToLocalTime(operatorId).Date;
        var localNowDate = DateTime.UtcNow.ToLocalTime(operatorId).Date;
        var yestDate = localNowDate.AddDays(-1);

        return firstDepositDate == yestDate;
    }
}
