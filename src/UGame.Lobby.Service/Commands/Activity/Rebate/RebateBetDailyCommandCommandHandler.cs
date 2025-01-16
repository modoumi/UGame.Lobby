//using UGame.Lobby.Service.Services.Activity.Rebate;
//using MediatR;
//using Microsoft.Extensions.Logging;
//using AiUo;

//namespace UGame.Lobby.Service.Commands.Activity.Rebate;

//public class RebateBetDailyCommandCommandHandler : IRequestHandler<RebateBetDailyCommand, bool>
//{
//    private ILogger<RebateDotCommandHandler> _logger;
//    private IServiceProvider serviceProvider;
//    public RebateBetDailyCommandCommandHandler(IServiceProvider serviceProvider)
//    {
//        this.serviceProvider = serviceProvider;
//    }

//    public async Task<bool> Handle(RebateBetDailyCommand request, CancellationToken cancellationToken)
//    {
//        //_logger.LogInformation($"RebateBetCommandHandler.request:{JsonConvert.SerializeObject(request)}");
//        return true;
//        //var rebateService = DIUtil.GetService<RebateService>();
//        //rebateService.TryProcessMessage(request);
//        //return await request.Waiter.Task;

//        //string operaterId = request.OperatorID;
//        //string appId = request.AppId;
//        //string userId = request.UserId;

//        //string currencyId = request.CurrencyId;

//        //if (!DbCacheUtil.IsSupportActivityId(request.OperatorID, request.AppId, request.ActivityID.ToString()))
//        //    return true;

//        //int amountType = 0;
//        //var activityType = (ActivityType)request.ActivityID;
//        //var dayId = request.BetTime.ToLocalTime(request.OperatorID).Date;
//        //var rebateDotActivityIds = new int[] { (int)ActivityType.RebateDot, (int)ActivityType.RebateDotWeekly, (int)ActivityType.RebateDotMonthly };

//        //if (rebateDotActivityIds.Contains(request.ActivityID))
//        //{
//        //    var realtimeConfigMo = new Sa_rebate_realtime_configMO();
//        //    var realtimeConfigInfos = await realtimeConfigMo.GetTopSortAsync("OperatorID=@OperatorID and CurrencyId=@CurrencyId and ActivityID=@ActivityID",
//        //       1, "Level", request.OperatorID, request.CurrencyId, request.ActivityID);
//        //    if (realtimeConfigInfos == null || realtimeConfigInfos.Count == 0)
//        //        return true;
//        //    amountType = realtimeConfigInfos.FirstOrDefault().AmountType;
//        //}
//        //else
//        //{
//        //    var quartzConfigMo = new Sa_rebate_quartz_configMO();
//        //    var quartzConfigInfo = await quartzConfigMo.GetSingleAsync("OperatorID=@OperatorID and CurrencyId=@CurrencyId and ActivityID=@ActivityID",
//        //          request.OperatorID, request.CurrencyId, request.ActivityID);
//        //    if (quartzConfigInfo == null)
//        //        return true;
//        //    amountType = quartzConfigInfo.AmountType;
//        //}
//        //switch (activityType)
//        //{
//        //    case ActivityType.RebateDotWeekly:
//        //    case ActivityType.RebateWaterWeekly:
//        //        dayId = dayId.BeginDayOfWeek();
//        //        break;
//        //    case ActivityType.RebateDotMonthly:
//        //    case ActivityType.RebateWaterMonthly:
//        //        dayId = dayId.LastDayOfPrdviousMonth().AddDays(1);
//        //        break;
//        //}

//        //var effectiveBetAmount = amountType switch
//        //{
//        //    1 => request.BetBonus,
//        //    2 => request.BetAmount - request.BetBonus,
//        //    3 => request.BetAmount,
//        //    _ => request.BetAmount
//        //};

//        //var userDCache = await GlobalUserDCache.Create(request.UserId);
//        //try
//        //{
//        //    #region 更新流水记录
//        //    var entity = await rebateDayMo.GetSingleAsync("UserId=@userId and OperatorID=@operatorId and DayId=@dayId and CurrencyId=@currencyId and ActivityId=@ActivityId",
//        //         request.UserId, request.OperatorID, dayId, request.CurrencyId, request.ActivityID);
//        //    if (entity != null)
//        //    {
//        //        //bulkSql = $"UPDATE sa_rebate_day SET `TotalBetAmount`=`TotalBetAmount`+@TotalBetAmount{bulkinde},`TotalBetBonus`=`TotalBetBonus`+@TotalBetBonus,`EffectiveBetAmount`=`EffectiveBetAmount`+@EffectiveBetAmount,`TotalWinAmount`=`TotalWinAmount`+@TotalWinAmount,`TotalWinBonus`=`TotalWinBonus`+@TotalWinBonus{}";
//        //        //eo.TotalBetAmount += request.BetAmount;
//        //        //eo.TotalBetBonus += request.BetBonus;
//        //        //eo.TotalWinBonus += request.WinBonus;
//        //        //eo.TotalWinAmount += request.WinAmount;
//        //        //eo.EffectiveBetAmount += effectiveBetAmount;
//        //        //eo.UpdateTime = DateTime.UtcNow;
//        //        //await rebateDayMo.PutAsync(eo);
//        //        //取增加的值
//        //        entity.TotalBetAmount = request.BetAmount;
//        //        entity.TotalBetBonus = request.BetBonus;
//        //        entity.TotalWinBonus = request.WinBonus;
//        //        entity.TotalWinAmount = request.WinAmount;
//        //        entity.EffectiveBetAmount = effectiveBetAmount;
//        //        entity.UpdateTime = DateTime.UtcNow;
//        //    }
//        //    else
//        //    {
//        //        //3个应用同时消费下注消息有并发
//        //        //var sql = $"INSERT INTO `sa_rebate_day` (`DayID`, `UserID`, `OperatorID`, `CurrencyID`, `ActivityID`, `FromMode`, `FromId`, " +
//        //        //    "`UserKind`, `CountryID`, `TotalBetAmount`, `TotalBetBonus`, `EffectiveBetAmount`, `TotalWinAmount`, `TotalWinBonus`, `RecDate`," +
//        //        //    " `UpdateTime`) VALUES (@DayID{},@UserID,@OperatorID,@CurrencyID,@ActivityID,@FromMode,@FromId,@UserKind,@CountryID,@TotalBetAmount," +
//        //        //    "@TotalBetBonus,@EffectiveBetAmount,@TotalWinAmount,@TotalWinBonus,@RecDate,@UpdateTime) on duplicate key update " +
//        //        //    "`TotalBetAmount`=`TotalBetAmount`+@TotalBetAmount,`TotalBetBonus`=`TotalBetBonus`+@TotalBetBonus," +
//        //        //    "`EffectiveBetAmount`=`EffectiveBetAmount`+@EffectiveBetAmount,`TotalWinAmount`=`TotalWinAmount`+@TotalWinAmount," +
//        //        //    "`TotalWinBonus`=`TotalWinBonus`+@TotalWinBonus";
//        //        var fromMode = await userDCache.GetFromModeAsync();
//        //        var fromId = await userDCache.GetFromIdAsync();
//        //        var userKind = (int)await userDCache.GetUserKindAsync();
//        //        //await rebateDayMo.Database.ExecSqlNonQueryAsync(sql, dayId, request.UserId, request.OperatorId, request.CurrencyId, request.ActivityID,
//        //        //    fromMode, fromId, userKind, request.CountryId, request.BetAmount, request.BetBonus, effectiveBetAmount, request.WinAmount, request.WinBonus,
//        //        //    DateTime.UtcNow, DateTime.UtcNow);
//        //        entity = new Sa_rebate_dayEO
//        //        {
//        //            DayID = dayId,
//        //            UserID = request.UserId,
//        //            OperatorID = request.OperatorID,
//        //            CurrencyID = request.CurrencyId,
//        //            ActivityID = request.ActivityID,
//        //            FromMode = fromMode,
//        //            FromId = fromId,
//        //            UserKind = userKind,
//        //            CountryID = request.CountryId,
//        //            TotalBetAmount = request.BetAmount,
//        //            TotalBetBonus = request.BetBonus,
//        //            EffectiveBetAmount = effectiveBetAmount,
//        //            TotalWinAmount = request.WinAmount,
//        //            TotalWinBonus = request.WinBonus,
//        //            RecDate = DateTime.UtcNow,
//        //            UpdateTime = DateTime.UtcNow
//        //        };
//        //    }
//        //    #endregion
//        //}
//        //catch (Exception ex)
//        //{
//        //    if (ex is not CustomException)
//        //    {
//        //        LogUtil.Log(LogLevel.Error, ex.Message, ex);
//        //        throw;
//        //    }
//        //}
//        //return true;
//    }
//}
