using UGame.Lobby.Common.Enum;
using UGame.Lobby.Repository.ing;
using MediatR;
using Newtonsoft.Json;
using AiUo;
using AiUo.Data;
using AiUo.Extensions.AutoMapper;
using AiUo.Extensions.RabbitMQ;
using AiUo.Extensions.StackExchangeRedis;
using AiUo.Logging;
using AiUo.Text;
using UGame.Lobby.Service.Caching;
using UGame.Lobby.Service.Caching.Activity.Signin;
using UGame.Lobby.Service.Commands.Activity.Signin;
using UGame.Lobby.Service.Common;
using Xxyy.Common;
using Xxyy.Common.Services;
using Xxyy.DAL;
using Xxyy.MQ.Lobby.Activity;

namespace UGame.Lobby.Service.Services.Activity.Signin
{
    public class SigninService
    {
        private Sa_signin_bannerMO _signinBannerMo = new();

        private Sa_signin_levelMO _signinLevelMo = new();

        private Sa_signin_recordMO _signinRecordMo = new();

        private S_user_dayMO _userDayMO = new();

        private Sa_signin_configMO _signConfigMO = new();
        //private SigninBannerDCache _signinBannerDCache;
        //private GlobalUserDCacheEx _globalUserDCacheEx;
        //private CommonUserService _commonUserService;
        //private int petAmount = 50;//下注金额
        private const int levelCount = 7;//周期
        //private static XxyyOperatorClient _xxyyClient = new(new XxyyOperatorOptions());

        /// <summary>
        /// 获取bannerlist
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        public async Task<List<SigninBannerDto>> GetBannerList(SigninBannerIpo ipo)
        {
            string operatorId = ipo.OperatorId;
            string userId = ipo.UserId;
            string currencyId = ipo.CurrencyId;
            //var field = SigninBannerDCache.GetField(operatorId, currencyId);
            var cacheData = await new SigninBannerDCache(operatorId, currencyId).GetOrLoadAsync();

            //var commonUserService = new CommonUserService(ipo.UserId);
            //var sUser = await commonUserService.GetUserEo();

            if (!cacheData.HasValue)
            {
                return new List<SigninBannerDto>
                {

                };

                //throw new CustomException("Data does not exist.");
            }

            return cacheData.Value.Map<List<SigninBannerDto>>();
            //if (sUser.UserMode == 1)
            //    cacheData.Value = rouletteConfig.Value.RegisterFreespin;
        }

        /// <summary>
        /// 签到服务
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        public async Task<SigninBonusDto> Signin(SigninBonusIpo ipo)
        {
            var activity = await LobbyUtil.GetActivityIsValid(ipo.OperatorId, ipo.CurrencyId, ActivityType.SignIn, ActivityEvent.SignIn);

            //活动已下架或过期
            if (!activity.IsValid)
                throw new CustomException(LobbyCodes.RS_ACTIVITY_EXPIRED);

            var localTime = DateTime.UtcNow.ToLocalTime(ipo.OperatorId);
            LogUtil.Info("localTime:" + localTime);

            SigninBonusDto result = null;
            using var lockObj = await RedisUtil.LockAsync($"Signin.{ipo.UserId}", 5);
            try
            {
                if (!lockObj.IsLocked)
                {
                    lockObj.Release();
                    throw new CustomException(CommonCodes.UserConcurrent, $"lobby:Signin:Request for lock failed.Key:Signin.{ipo.UserId}");
                }

                var isSignin = await IsSignin(ipo);
                if (isSignin.Item1 && isSignin.Item2 == 2) //已经签过到
                {
                    return new SigninBonusDto()
                    {
                        RewardAmount = isSignin.Item4,
                        SignTime = isSignin.Item3,
                        Status = isSignin.Item2,
                        Success = isSignin.Item1
                    };
                }

                //获取签到的等级
                var recordlist = await _signinRecordMo.GetTopSortAsync("UserId=@userId and BannerId=@bannerId and OperatorID=@operatorID", 15, "DayId desc", ipo.UserId, ipo.BannerID, ipo.OperatorId);
                var signlist = getSigninlist(localTime.Date, recordlist);
                var days = signlist.Count(x => x.Flag == true);
                var petAmount = await getPetAmount(ipo.OperatorId, ipo.CurrencyId, days + 1);

                #region 获取下注金额
                var bettingAmounts = await _userDayMO.GetTopSortAsync("DayID=@dayId and UserId=@userId and OperatorID=@operatorID", 1, "RecDate desc", ipo.DayId, ipo.UserId, ipo.OperatorId);
                //======================================================
                if (bettingAmounts == null || bettingAmounts.Count == 0)
                {
                    return new SigninBonusDto
                    {
                        Status = -1,
                        Success = false,
                        PettingAmount = petAmount,
                        Message = "system error:get betting amounts fail"
                    };
                }
                else
                {
                    //真金金额
                    var betAmount = (bettingAmounts[0].TotalBetAmount - bettingAmounts[0].TotalBetBonus);
                    var ba = betAmount.AToM(ipo.CurrencyId);

                    if (ba < petAmount)
                    {
                        return new SigninBonusDto()
                        {
                            Status = -1,
                            Success = false,
                            PettingAmount = petAmount,
                            Message = "user error:betting amounts is not match requirement"
                        };
                    }
                }
                #endregion

                var globalUserDCacheEx = GlobalUserDCacheEx.Create(ipo.UserId);

                var reward = await getRewards(ipo, days);
                var rewardAmount = reward.Item1;
                //如果没有签到
                var signTime = DateTime.UtcNow;
                TransactionManager tm = new TransactionManager();
                var signinRecord = new Sa_signin_recordEO()
                {
                    RecordID = ObjectId.NewId(),
                    BannerID = ipo.BannerID,
                    DayID = ipo.DayId,
                    RecDate = signTime,
                    Level = reward.Item2,
                    Amount = rewardAmount,
                    Flag = isSignin.Item2,
                    UserID = ipo.UserId,
                    UpdateDate = signTime,
                    CountryID = ipo.CountryId,
                    CurrencyID = ipo.CurrencyId,
                    OperatorID = ipo.OperatorId
                };
                var signRecord = signlist.FirstOrDefault();
                if (signRecord?.RecordId != null)
                {
                    signinRecord.OriginalRecordID = signRecord.RecordId;
                    rewardAmount = signRecord.Amount;
                }
                else
                {
                    _signinRecordMo.Add(signinRecord);
                }

                //领取领奖，添加到bounds
                try
                {
                    string field = SigninConfigDCache.GetField(ipo.OperatorId, ipo.CurrencyId);
                    var cacheData = await new SigninConfigDCache().GetOrLoadAsync(field);
                    var flowMultip = 1.0f;
                    if (cacheData.HasValue)
                    {
                        flowMultip = cacheData.Value?.FlowMultip ?? 1.0f;
                    }
                    else//存在更新
                    {
                        flowMultip = _signConfigMO.GetSingle("OperatorID=@OperatorID", ipo.OperatorId)?.FlowMultip ?? 1.0f;
                    }

                    var currencyChangeService = new CurrencyChangeService(ipo.UserId);

                    //查询当前活动配置
                    var activityOperator = await LobbyUtil.GetSingleActivityAsync(ipo.OperatorId, ipo.CurrencyId, ActivityType.SignIn);
                    if (activityOperator == null)
                        throw new Exception($@"l_activity_operator表活动{(int)ActivityType.LoseCashBack}不存在.");

                    var currencyChangeReq = new CurrencyChangeReq()
                    {
                        UserId = ipo.UserId,
                        Amount = (rewardAmount * 1.0M).MToA(ipo.CurrencyId),
                        AppId = ipo.AppId,
                        ChangeTime = DateTime.UtcNow,
                        CurrencyId = ipo.CurrencyId,
                        OperatorId = ipo.OperatorId,
                        //IsBonus = activityOperator.IsBonus,
                        ChangeBalance = activityOperator.IsBonus ? CurrencyChangeBalance.Bonus : CurrencyChangeBalance.Cash,
                        FlowMultip = flowMultip,
                        TM = tm,
                        Reason = "签到活动发放奖励",
                        SourceType = (int)ActivityType.SignIn,
                        SourceTable = "sa_signin_record",
                        SourceId = signinRecord.RecordID
                    };

                    var changeMsg = await currencyChangeService.Add(currencyChangeReq);
                    if (changeMsg != null)
                    {
                        signinRecord.Amount = rewardAmount;
                        signinRecord.Flag = 2;
                        signinRecord.UpdateDate = DateTime.UtcNow;
                        await _signinRecordMo.PutAsync(signinRecord, tm);

                        //更新用户活动状态
                        await LobbyUtil.UpdateUserActivity(ipo.UserId, ipo.OperatorId, ipo.CurrencyId, ActivityType.SignIn, tm);

                        tm.Commit();
                        await MQUtil.PublishAsync(changeMsg);
                        await MQUtil.PublishAsync(new UserActivityMsg()
                        {
                            UserId = ipo.UserId,
                            ActivityType = (int)ActivityType.SignIn
                        });
                        #region 发送弹框、站内邮件通知

                        var _mediator = DIUtil.GetService<IMediator>();
                        var notifyCommand = new SigninNotifyCommand();
                        notifyCommand.UserId = ipo.UserId;
                        notifyCommand.OperatorId = ipo.OperatorId;
                        notifyCommand.CountryId = ipo.CountryId;
                        notifyCommand.CurrencyId = ipo.CurrencyId;
                        notifyCommand.AppId = ipo.AppId;
                        notifyCommand.Bonus = (rewardAmount * 1.0M).MToA(ipo.CurrencyId);
                        notifyCommand.FlowMultip = flowMultip;
                        notifyCommand.IsSendNotify = activity.activityEntity.IsSendNotify;
                        notifyCommand.IsSendNotifyEmail = activity.activityEntity.IsSendNotifyEmail;
                        notifyCommand.RecordID = signinRecord.RecordID;
                        await _mediator.Send(notifyCommand);

                        #endregion

                        result = new SigninBonusDto()
                        {
                            RewardAmount = rewardAmount,
                            SignTime = signTime,
                            Status = 2,
                            Success = true,
                            Message = "add bounds success"
                        };
                    }
                    else
                    {
                        signinRecord.Amount = rewardAmount;
                        signinRecord.Flag = 1;
                        signinRecord.UpdateDate = DateTime.UtcNow;
                        await _signinRecordMo.PutAsync(signinRecord, tm);
                        tm.Commit();
                        result = new SigninBonusDto()
                        {
                            RewardAmount = rewardAmount,
                            SignTime = signTime,
                            Status = 1,
                            Success = false,
                            Message = "add bounds failed"
                        };
                    }
                }
                catch (Exception ex)
                {
                    tm.Rollback();

                    LogUtil.GetContextLogger().AddException(ex).AddMessage($"调用signin失败，exMessage:{ex.Message},request:{JsonConvert.SerializeObject(ipo)}");
                }
            }
            catch (Exception ex)
            {
                result = new SigninBonusDto()
                {
                    SignTime = default,
                    Status = 0,
                    Success = false,
                    Message = ex.Message
                };
            }
            finally
            {
                lockObj.Release();
            }
            return result;
        }


        /// <summary>
        /// 获取签到等级
        /// </summary>
        /// <param name="operatorId"></param>
        /// <param name="currencyId"></param>
        /// <returns></returns>
        public async Task<List<SigninLevelDto>> GetSigninLevelList(string operatorId, string currencyId)
        {
            var cacheData = await new SigninLevelDCache(operatorId, currencyId).GetOrLoadAsync();

            //不存在写入
            if (cacheData.HasValue)
            {
                return cacheData.Value.Map<List<SigninLevelDto>>();
            }
            //存在更新
            else
            {
                var lst = await _signinLevelMo.GetAsync("operatorId=@operatorId and currencyId=@currencyId", operatorId, currencyId);
                return lst.Map<List<SigninLevelDto>>();
            }
        }

        ///// <summary>
        ///// 是否满足真金下注超过50
        ///// </summary>
        ///// <param name="ipo"></param>
        ///// <returns></returns>
        //public async Task<SigninPrizeDto> IsPrize(SigninPrizeIpo ipo)
        //{
        //    var bettingAmounts = await _userDayMO.GetTopSortAsync("DayID=@dayId and userId=@userId and OperatorID=@operatorID", 1, "RecDate desc", ipo.DayId, ipo.UserId, ipo.OperatorId);
        //    var betAmount = bettingAmounts.FirstOrDefault()?.TotalBetAmount ?? 0;
        //    var ba = (betAmount).AToM(ipo.CurrencyId);
        //    var pa = await getPetAmount(ipo.OperatorId, ipo.CurrencyId);
        //    return new SigninPrizeDto()
        //    {
        //        betAmount = ba,
        //        isMatch = ba >= pa,
        //        currentDate = DateTime.UtcNow.ToLocalTime(ipo.OperatorId)
        //    };
        //}
        /// <summary>
        /// 获取最近7天的签到列表
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        public async Task<SigninListDto> GetSignlist(SigninListIpo ipo)
        {
            var dto = new SigninListDto()
            {
                currentDate = DateTime.UtcNow.ToLocalTime(ipo.OperatorId)
            };
            var dayId = DateTime.UtcNow.ToLocalTime(ipo.OperatorId).Date;
            var recordlist = await _signinRecordMo.GetTopSortAsync("UserId=@userId and BannerId=@bannerId and OperatorID=@operatorID", 8, "DayId desc", ipo.UserId, ipo.BannerID, ipo.OperatorId);
            var signlist = getSigninlist(dayId, recordlist);
            dto.signlist = signlist;
            return dto;
        }

        /// <summary>
        /// 获取签到倍数
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        public async Task<float> GetFlowMultip(SigninLevelIpo ipo)
        {
            var item = await _signConfigMO.GetSingleAsync("OperatorID=@operatorId", ipo.OperatorId);
            return item?.FlowMultip ?? 1;
        }

        /// <summary>
        /// 是否已经签到
        /// </summary>
        /// <returns></returns>
        private async Task<(bool, int, DateTime, long)> IsSignin(SigninBonusIpo ipo) //SigninBonusIpo ipo,
        {
            int n = 1;
            //DateTime beginTime = ipo.UTCTime.Date; //ipo.UTCTime.Date;
            //DateTime endTime = ipo.UTCTime.Date.AddDays(1).Date; // ipo.UTCTime.AddDays(1).Date;
            var recordlist = await _signinRecordMo.GetTopSortAsync("UserId=@userId and BannerId=@bannerId and OperatorID=@operatorID and DayId=@dayId", n, "RecDate desc", ipo.UserId, ipo.BannerID, ipo.OperatorId, ipo.DayId);
            var record = recordlist.FirstOrDefault();
            if (record != null)
            {
                DateTime serverTime = record.RecDate.Value;
                var localTime = serverTime.ToLocalTime(ipo.OperatorId);
                if (record.Flag > 0)
                {
                    return (true, 2, localTime, record.Amount);//已经签到 已经领取过奖励
                }
                else
                {
                    return (true, 1, localTime, 0);//已经签到 没有领取过奖励
                }
            }
            return (false, 0, DateTime.MinValue, 0); //没有签到
        }

        ///// <summary>
        ///// 是否连续签到+签到等级+当天的签到信息
        ///// </summary>
        ///// <param name="dayId"></param>
        ///// <param name="userId"></param>
        ///// <param name="bannerId"></param>
        ///// <param name="operatorId"></param>
        ///// <returns></returns>
        //private async Task<(bool, int, Sa_signin_recordEO)> GetSigninInfo(DateTime dayId, string userId, string bannerId, string operatorId) 
        //{
        //    int n = 2;
        //    int level = 1;
        //    var recordlist = await _signinRecordMo.GetTopSortAsync("UserId=@userId and BannerId=@bannerId and OperatorID=@operatorID", n, "DayId desc", userId, bannerId, operatorId);
        //    int len = recordlist.Count;
        //    if (len > 0)
        //    {
        //        bool flag = true;
        //        if ((dayId - recordlist[0].DayID.Value).TotalDays <= 1)
        //        {
        //            flag = false;
        //        }
        //        else
        //        {
        //            for (int x = 0; x < len - 1; x++)
        //            {
        //                var r1 = recordlist[x];
        //                var r2 = recordlist[x + 1];
        //                TimeSpan ts = r1.DayID.Value - r2.DayID.Value;
        //                if (ts.TotalDays != 1)
        //                {
        //                    flag = false;
        //                    break;
        //                }
        //            }
        //        }
        //        var lastRecord = recordlist[len - 1];
        //        if (flag)
        //        {
        //            level = lastRecord.Level.Value + 1;
        //        }
        //        if (dayId == lastRecord.DayID)
        //            return (true, level, recordlist[len - 1]);
        //        else
        //            return (false, level, null);
        //    }
        //    else
        //    {
        //        return (false, level, null);
        //    }
        //}
        /// <summary>
        /// 是否连续签到
        /// </summary>
        /// <param name="dayId"></param>
        /// <param name="recordlist"></param>
        /// <returns></returns>
        private List<SignRecord> getSigninlist(DateTime dayId, List<Sa_signin_recordEO> recordlist)
        {
            List<SignRecord> signlist = new List<SignRecord>();
            int len = recordlist.Count;
            if (len > 0)
            {
                #region 注释
                //if ((dayId.Date - recordlist[0].DayID.Value).TotalDays > 1)
                //{
                //    //var t = recordlist.FirstOrDefault(x => x.DayID == dayId);
                //    //if (t != null)
                //    //{
                //    //    signlist.Add(new SignRecord() { DayId = dayId, Amount = t.Amount, Flag = t.Flag == 2, Level = t.Level.Value, RecordId = t.RecordID });
                //    //}
                //    //else
                //    //{
                //    //    signlist.Add(new SignRecord() { DayId = dayId, Amount = 0, Level = 0, Flag = false });
                //    //}
                //    //return signlist;
                //}
                //else
                //{
                //    //if (len > 1)
                //    //{
                //    //    for (int x = 0; x < len - 1; x++)
                //    //    {
                //    //        var r1 = recordlist[x];
                //    //        var r2 = recordlist[x + 1];
                //    //        signlist.Add(new SignRecord() { DayId = r1.DayID.Value, Amount = r1.Amount, Flag = r1.Flag == 2, Level = r1.Level.Value, RecordId = r1.RecordID });
                //    //        if ((r1.DayID.Value - r2.DayID.Value).TotalDays != 1)
                //    //        {
                //    //            break;
                //    //        }
                //    //    }
                //    //}
                //    //else
                //    //{
                //    //    var r0 = recordlist.FirstOrDefault();
                //    //    if (r0?.Flag == 2)
                //    //    {
                //    //        signlist.Add(new SignRecord() { DayId = r0.DayID.Value, Amount = r0.Amount, Flag = r0.Flag == 2, RecordId = r0.RecordID, Level = r0.Level.Value });
                //    //    }
                //    //}
                //}
                #endregion


                var dt = dayId.Date;
                for (int x = 0; x < recordlist.Count; x++)
                {
                    var t = recordlist[x];
                    var totalDays = (dt - t.DayID.Value).TotalDays;
                    if (totalDays < 0 || totalDays > 1)
                    {
                        continue;
                    }
                    if (totalDays == 0 || totalDays == 1)
                    {
                        signlist.Add(new SignRecord() { DayId = t.DayID.Value, Amount = t.Amount, Flag = t.Flag == 2, RecordId = t.RecordID, Level = t.Level.Value });
                    }
                    dt = t.DayID.Value;
                }

                signlist.RemoveAll(x => !x.Flag);

                if (!signlist.Exists(x => x.DayId == dayId))
                {
                    var t = recordlist.FirstOrDefault(x => x.DayID == dayId);
                    if (t != null)
                    {
                        signlist.Add(new SignRecord() { DayId = dayId, Amount = t.Amount, Flag = t.Flag == 2, RecordId = t.RecordID, Level = t.Level.Value });
                    }
                    else
                    {
                        signlist.Add(new SignRecord() { DayId = dayId, Amount = 0, Flag = false, Level = 0 });
                    }
                }
            }

            return signlist.OrderByDescending(x => x.DayId).ToList();


        }

        /// <summary>
        /// 获取随机金额
        /// </summary>
        /// <param name="ipo"></param>
        /// <param name="days"></param>
        /// <returns></returns>
        private async Task<(long, int)> getRewards(SigninBonusIpo ipo, int days)
        {
            var levellist = await GetSigninLevelList(ipo.OperatorId, ipo.CurrencyId);
            long rewardAmount = 0;
            //int level = 1
            //if (days >= levelCount)
            //{
            //    days = days % levelCount;
            //}
            //if (days >= 0 && days < 2) //0~1
            //{
            //    level = 1;
            //}
            //else if (days >= 2 && days < 6) //2~5
            //{
            //    level = 2;
            //}
            //else if (days == 6) //6
            //{
            //    level = 3;
            //}
            var dto = levellist.FirstOrDefault(x => x.Days == days + 1);
            //var dto = levellist.FirstOrDefault(x => x.Level == level);
            rewardAmount = new Random().Next(dto.MinMoney, dto.MaxMoney);
            return (rewardAmount, dto.Level);
        }


        /// <summary>
        /// 获取下注金额
        /// </summary>
        /// <param name="operatorId"></param>
        /// <param name="currencyId"></param>
        /// <param name="days"></param>
        /// <returns></returns>
        private async Task<int> getPetAmount(string operatorId, string currencyId, int days)
        {
            var cacheData = await new SigninAmountDCache(operatorId, currencyId, days).GetOrLoadAsync();
            if (cacheData.HasValue)
            {
                return cacheData.Value.PetMoney ?? 0;
            }
            else
            {
                var t = await _signinLevelMo.GetTopSortAsync("OperatorID=@operatorID and CurrencyId=@currencyId and Days=@days ", 1, "PetMoney asc", operatorId, currencyId, days);
                return t.FirstOrDefault()?.PetMoney ?? 0;
            }
        }


    }
}
