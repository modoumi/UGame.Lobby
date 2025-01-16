//using UGame.Lobby.Service.Commands.Activity.Base;
//using UGame.Lobby.Common.Enum;
//using UGame.Lobby.Repository.ing;
//using MediatR;
//using Microsoft.Extensions.Logging;
//using Newtonsoft.Json;
//using AiUo;
//using AiUo.Data;
//using AiUo.Logging;
//using AiUo.Text;
//using Xxyy.Common;
//using Xxyy.Common.Caching;

//namespace UGame.Lobby.Service.Commands.Activity.Rebate
//{
//    public class RebateDotCommandHandler : IRequestHandler<RebateDotCommand, bool>
//    {
//        private ILogger<RebateDotCommandHandler> _logger;
//        private readonly Sa_rebate_user_detailMO rebateDetailMo = new();

//        /// <summary>
//        /// 构造方法
//        /// </summary>
//        public RebateDotCommandHandler()
//        {
//            _logger = LogUtil.CreateLogger<RebateDotCommandHandler>();
//        }

//        public async Task<bool> Handle(RebateDotCommand request, CancellationToken cancellationToken)
//        {
//            _logger.LogInformation($"RebateDotNotifyCommandHandler.request:{JsonConvert.SerializeObject(request)}");

//            string operaterId = request.OperatorID;
//            string appId = request.AppId;
//            string userId = request.UserId;
//            string currencyId = request.CurrencyId;

//            if (!DbCacheUtil.IsSupportActivityId(request.OperatorID, request.AppId, request.ActivityID.ToString()))
//                return true;

//            var operatorActivity = await new L_activity_operatorMO().GetSingleAsync("OperatorID=@OperatorID and CurrencyID=@CurrencyID and ActivityID=@ActivityID and Status=1",
//                request.OperatorID, request.CurrencyId, request.ActivityID);
//            if (operatorActivity == null)
//                return true;

//            var realtimeConfigMo = new Sa_rebate_realtime_configMO();
//            var rebateConfigInfos = await realtimeConfigMo.GetAsync("OperatorID=@OperatorID and CurrencyId=@CurrencyId and ActivityID=@ActivityID",
//                request.OperatorID, request.CurrencyId, request.ActivityID);

//            if (rebateConfigInfos == null || rebateConfigInfos.Count <= 0)
//                return true;

//<<<<<<< HEAD
//            decimal totalEffectiveBetAmount = default;
//            DateTime beginDate = default, endDate = default;
//            var dayId = request.BetTime.ToLocalTime(request.OperatorID).Date;
//            var sqlFilter = "select IFNULL(sum(EffectiveBetAmount),0) from `sa_rebate_day` where UserId=@userId and OperatorID=@operatorId and CurrencyID=@currencyId and ActivityID=@ActivityID";
//            switch ((ActivityType)operatorActivity.ActivityID)
//            {
//                case ActivityType.RebateDot:
//                    sqlFilter += $" and DayId=@DayId";
//                    totalEffectiveBetAmount = await DbSink.MainDb.ExecSqlScalarAsync<decimal>(
//                        sqlFilter, request.UserId, request.OperatorID, request.CurrencyId, request.ActivityID, dayId);
//                    break;
//                case ActivityType.RebateDotWeekly:
//                    beginDate = dayId.BeginDayOfWeek();
//                    endDate = beginDate.AddDays(7);
//                    sqlFilter += $" and DayId>=@BeginDate and DayId<@EndDate";
//                    dayId = beginDate;
//                    totalEffectiveBetAmount = await DbSink.MainDb.ExecSqlScalarAsync<decimal>(
//                        sqlFilter, request.UserId, request.OperatorID, request.CurrencyId, request.ActivityID, beginDate, endDate);
//                    break;
//                case ActivityType.RebateDotMonthly:
//                    beginDate = dayId.LastDayOfPrdviousMonth().AddDays(1);
//                    endDate = beginDate.AddMonths(1);
//                    dayId = beginDate;
//                    sqlFilter += $" and DayId>=@BeginDate and DayId<@EndDate";
//                    totalEffectiveBetAmount = await DbSink.MainDb.ExecSqlScalarAsync<decimal>(
//                        sqlFilter, request.UserId, request.OperatorID, request.CurrencyId, request.ActivityID, beginDate, endDate);
//                    break;
//            }
//=======
//            decimal totalEffectiveBetAmount = default;
//            DateTime beginDate = default, endDate = default;
//            var dayId = request.BetTime.ToLocalTime(request.OperatorID).Date;
//            var sqlFilter = "select IFNULL(sum(EffectiveBetAmount),0) from `sa_rebate_day` where UserId=@userId and OperatorID=@operatorId and CurrencyID=@currencyId and ActivityID=@ActivityID";
//            switch ((ActivityType)operatorActivity.ActivityID)
//            {
//                case ActivityType.RebateDot:
//                    sqlFilter += $" and DayId=@DayId";
//                    totalEffectiveBetAmount = await DbSink.MainDb.ExecSqlScalarAsync<decimal>(
//                        sqlFilter, request.UserId, request.OperatorID, request.CurrencyId, request.ActivityID, dayId);
//                    break;
//                case ActivityType.RebateDotWeekly:
//                    beginDate = dayId.BeginDayOfWeek();
//                    endDate = beginDate.AddDays(7);
//                    sqlFilter += $" and DayId>=@BeginDate and DayId<@EndDate";
//                    dayId = beginDate;
//                    totalEffectiveBetAmount = await DbSink.MainDb.ExecSqlScalarAsync<decimal>(
//                        sqlFilter, request.UserId, request.OperatorID, request.CurrencyId, request.ActivityID, beginDate, endDate);
//                    break;
//                case ActivityType.RebateDotMonthly:
//                    beginDate = dayId.LastDayOfPrdviousMonth().AddDays(1);
//                    endDate = beginDate.AddMonths(1);
//                    dayId = beginDate;
//                    sqlFilter += $" and DayId>=@BeginDate and DayId<@EndDate";
//                    totalEffectiveBetAmount = await DbSink.MainDb.ExecSqlScalarAsync<decimal>(
//                        sqlFilter, request.UserId, request.OperatorID, request.CurrencyId, request.ActivityID, beginDate, endDate);
//                    break;
//            }
//>>>>>>> release

//            var rebateConfigInfo = rebateConfigInfos.Find(x => totalEffectiveBetAmount < x.BetMaxAmount && totalEffectiveBetAmount >= x.BetMinAmount);
//            if (rebateConfigInfo == null)
//                return true;

//            var userDCache = await GlobalUserDCache.Create(request.UserId);
//            int rebateLevel = rebateConfigInfo.Level, levelIndex = 1;
//            sqlFilter = "DayId=@DayId and UserId=@userId and OperatorID=@operatorId and CurrencyID=@currencyId and Level<=@level and RebateType=1 and ActivityID=@ActivityID";
//            var existedRebateDetails = await rebateDetailMo.GetAsync(sqlFilter, dayId, request.UserId, request.OperatorID, request.CurrencyId, rebateLevel, request.ActivityID);

//            var lostRebateDetails = new List<Sa_rebate_user_detailEO>();
//            while (levelIndex <= rebateLevel)
//            {
//                if (!existedRebateDetails.Exists(f => f.Level == levelIndex))
//                {
//                    #region 增加返点明细
//                    var configInfo = rebateConfigInfos.Find(x => x.Level == levelIndex);
//                    var detailId = ObjectId.NewId();
//                    lostRebateDetails.Add(new Sa_rebate_user_detailEO
//                    {
//                        DetailID = detailId,
//                        ActivityID = request.ActivityID,
//                        CountryID = request.CountryId,
//                        OperatorID = request.OperatorID,
//                        CurrencyID = request.CurrencyId,
//                        DayID = dayId,
//                        FromMode = await userDCache.GetFromModeAsync(),
//                        FromId = await userDCache.GetFromIdAsync(),
//                        UserKind = (int)await userDCache.GetUserKindAsync(),
//                        RecDate = DateTime.UtcNow,
//                        UserID = request.UserId,
//                        FlowMultip = configInfo.FlowMultip,
//                        RebateAmount = configInfo.RebateAmount,
//                        Level = levelIndex,
//                        NotifyStatus = 0,
//                        RebateType = 1,
//                        RewardType = operatorActivity.IsBonus ? 1 : 2,
//                        ReceiveStatus = 0,
//                        UpdateTime = DateTime.UtcNow
//                    });
//                    #endregion
//                }
//                levelIndex++;
//            }

//            if (lostRebateDetails.Count > 0)
//            {
//                var tm = new TransactionManager();
//                try
//                {
//                    await rebateDetailMo.AddByBatchAsync(lostRebateDetails, 200, tm);
//                    tm.Commit();
//                }
//                catch (Exception ex)
//                {
//                    tm.Rollback();
//                    if (ex is not CustomException)
//                    {
//                        LogUtil.Log(LogLevel.Error, ex.Message, ex);
//                        throw;
//                    }
//                }

//                var _mediator = DIUtil.GetService<IMediator>();
//                var activityType = (ActivityType)request.ActivityID;
//                foreach (var rebateDetail in lostRebateDetails)
//                {
//                    var command = new RebateDotNotifyCommand()
//                    {
//                        UserId = rebateDetail.UserID,
//                        OperatorId = request.OperatorID,
//                        CountryId = request.CountryId,
//                        CurrencyId = request.CurrencyId,
//                        AppId = request.AppId,
//                        ActivityType = activityType,
//                        RewardFlagId = request.ActivityID,
//                        SenderId = $"RebateDot.{activityType}",
//                        RewardAmount = rebateDetail.RebateAmount,
//                        Bonus = rebateDetail.RebateType == 1 ? rebateDetail.RebateAmount : 0,
//                        FlowMultip = rebateDetail.FlowMultip,
//                        IsSendNotify = operatorActivity.IsSendNotify,
//                        IsSendNotifyEmail = operatorActivity.IsSendNotifyEmail,
//                        RewardSourceId = rebateDetail.DetailID
//                    };
//                    await _mediator.Send(command);
//                    rebateDetail.NotifyStatus = 1;
//                    rebateDetail.UpdateTime = DateTime.UtcNow;
//                }
//                await rebateDetailMo.PutAsync(lostRebateDetails);
//            }

//            return true;
//        }
//    }
//}
