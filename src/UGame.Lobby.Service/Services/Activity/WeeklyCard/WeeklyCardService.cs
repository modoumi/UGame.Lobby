using UGame.Lobby.Common.Enum;
using UGame.Lobby.Repository.ing;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Pipelines.Sockets.Unofficial.Arenas;
using Serilog;
using SqlSugar;
using AiUo;
using AiUo.AspNet;
using AiUo.Data;
using AiUo.Data.SqlSugar;
using AiUo.Extensions.AutoMapper;
using AiUo.Extensions.RabbitMQ;
using AiUo.Logging;
using UGame.Lobby.Service.Caching;
using UGame.Lobby.Service.Common;
using UGame.Lobby.Service.Services.Profile;
using Xxyy.Banks.Client;
using Xxyy.Banks.Client.BLL.Letspay;
using Xxyy.Common;
using Xxyy.Common.Caching;
using Xxyy.Common.Services;
using Xxyy.MQ.Lobby.Activity;

namespace UGame.Lobby.Service.Services.Activity.WeeklyCard
{


    public class WeeklyCardService
    {
        private Sa_weeklycard_detailMO _detailMo = new();

        private Sa_weeklycard_userMO _weeklyCardUserMo = new();

        ILogger<WeeklyCardService> _logger;

        /// <summary>
        /// 构造方法
        /// </summary>
        public WeeklyCardService()
        {
            _logger = LogUtil.CreateLogger<WeeklyCardService>();
        }

        #region LoadAsync

        /// <summary>
        /// 周卡加载
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        public async Task<WeeklyCardLoadDto> LoadAsync(WeeklyCardLoadIpo ipo)
        {
            //初始化参数
            await InitLoadIpo(ipo);

            //重新计算周期
            if (await IsReset(ipo))
                return await ResetExcute(ipo);

            return await MainExcute(ipo);
        }

        private async Task InitLoadIpo(WeeklyCardLoadIpo ipo)
        {
            ipo.ProcessData = await GetProcessData(ipo.UserId);
        }

        /// <summary>
        /// 是否重置
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        public async Task<bool> IsReset(WeeklyCardLoadIpo ipo)
        {
            //1、用户没有购买周卡
            if (ipo.ProcessData.WeeklyCardUserEo == null || !ipo.ProcessData.IsBuyWeeklyCard)
                return true;

            return false;
        }

        /// <summary>
        /// 重置
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        public async Task<WeeklyCardLoadDto> ResetExcute(WeeklyCardLoadIpo ipo)
        {
            var ret = new WeeklyCardLoadDto();
            ret.ServerTime = $"服务器时间：{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}";
            ret.UtcTime = $"UTC时间：{DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss")}";
            ret.LocalTime = $"运营商当地时间：{ipo.ProcessData.UtcTime.ToLocalTime(ipo.OperatorId).ToString("yyyy-MM-dd HH:mm:ss")}";

            ret.WeeklyCardType = ipo.ProcessData.WeeklyCardType;
            ret.CountDown = ipo.ProcessData.CountDown;

            foreach (var item in ipo.ProcessData.ConfigEoDic)
            {
                var tempDetailConfigEoList = ipo.ProcessData.DetailConfigEoListDic[item.Key].OrderBy(d => d.DateNumber).ToList();

                if (tempDetailConfigEoList != null && tempDetailConfigEoList.Any())
                {
                    ret.Data.Add(item.Key, new WeeklyCardLoadData()
                    {
                        WeeklyCardType = item.Key.ToEnum<WeeklyCardTypeEnum>(),
                        IsSelected = item.Key == (int)WeeklyCardTypeEnum.WeeklyCardA,
                        PayAmount = item.Value.PayAmount.AToM(ipo.ProcessData.CurrencyId),
                        SumBonus = tempDetailConfigEoList.Sum(d => d.Bonus).AToM(ipo.ProcessData.CurrencyId),
                        Cycle = tempDetailConfigEoList.Count(),
                        CycleStartDate = ipo.ProcessData.CurrentDate,
                        CycleEndDate = ipo.ProcessData.CurrentDate.AddDays(tempDetailConfigEoList.Count() - 1).Date
                    });

                    var loadData = ret.Data[item.Key];
                    var dateNumber = 1;
                    var startDate = loadData.CycleStartDate;
                    foreach (var dataItem in tempDetailConfigEoList)
                    {
                        loadData.Items.Add(new WeeklyCardLoadItem()
                        {
                            Bonus = dataItem.Bonus.AToM(dataItem.CurrencyID),
                            //签到周期起始日期==当前日期时，选中
                            IsSelected = startDate == ipo.ProcessData.CurrentDate ? true : false,
                            DateNumber = dateNumber,
                            CurrDate = startDate.ToString("yyyy-MM-dd"),
                            Status = ReceiveStatusEnum.NoAllow
                        });
                        startDate = startDate.AddDays(1);
                        dateNumber++;
                    }
                }
            }

            return ret;
        }

        public async Task<WeeklyCardLoadDto> MainExcute(WeeklyCardLoadIpo ipo)
        {
            var ret = new WeeklyCardLoadDto();
            ret.ServerTime = $"服务器时间：{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}";
            ret.UtcTime = $"UTC时间：{DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss")}";
            ret.LocalTime = $"运营商当地时间：{ipo.ProcessData.UtcTime.ToLocalTime(ipo.OperatorId).ToString("yyyy-MM-dd HH:mm:ss")}";

            ret.IsBuyWeeklyCard = ipo.ProcessData.IsBuyWeeklyCard;
            ret.WeeklyCardType = ipo.ProcessData.WeeklyCardType;
            ret.CountDown = ipo.ProcessData.CountDown;

            foreach (var item in ipo.ProcessData.ConfigEoDic)
            {
                var tempDetailConfigEoList = ipo.ProcessData.DetailConfigEoListDic[item.Key].OrderBy(d => d.DateNumber).ToList();

                if (tempDetailConfigEoList != null && tempDetailConfigEoList.Any())
                {
                    ret.Data.Add(item.Key, new WeeklyCardLoadData()
                    {
                        WeeklyCardType = item.Key.ToEnum<WeeklyCardTypeEnum>(),
                        IsSelected = item.Key == ipo.ProcessData.WeeklyCardUserEo.WeeklyCardType,
                        PayAmount = item.Value.PayAmount.AToM(ipo.ProcessData.CurrencyId),
                        SumBonus = tempDetailConfigEoList.Sum(d => d.Bonus).AToM(ipo.ProcessData.CurrencyId),
                        Cycle = tempDetailConfigEoList.Count(),
                        CycleStartDate = ipo.ProcessData.WeeklyCardUserEo.CycleStartDate,
                        CycleEndDate = ipo.ProcessData.WeeklyCardUserEo.CycleStartDate.AddDays(tempDetailConfigEoList.Count() - 1).Date
                    });

                    var loadData = ret.Data[item.Key];
                    var dateNumber = 1;
                    var startDate = loadData.CycleStartDate;
                    Sa_weeklycard_detailEO detailEo = null;
                    foreach (var dataItem in tempDetailConfigEoList)
                    {
                        var receiveStatusEnum = ReceiveStatusEnum.NoAllow;

                        if (loadData.IsSelected)
                        {
                            //当前周卡领取周期明细
                            detailEo = ipo.ProcessData.UserLastDetailEoList.Where(d => d.DayId == startDate).FirstOrDefault();

                            if (detailEo != null)
                                receiveStatusEnum = ReceiveStatusEnum.Received;
                            else
                            {
                                if (startDate == ipo.ProcessData.CurrentDate)
                                    receiveStatusEnum = ReceiveStatusEnum.Allow;
                            }
                        }

                        loadData.Items.Add(new WeeklyCardLoadItem()
                        {
                            Bonus = dataItem.Bonus.AToM(dataItem.CurrencyID),
                            //签到周期起始日期==当前日期时，选中
                            IsSelected = (loadData.IsSelected && startDate == ipo.ProcessData.CurrentDate) ? true : false,
                            DateNumber = dateNumber,
                            CurrDate = startDate.ToString("yyyy-MM-dd"),
                            Status = receiveStatusEnum
                        });
                        startDate = startDate.AddDays(1);
                        dateNumber++;
                    }
                }
            }

            return ret;
        }

        #endregion

        public async Task<ProcessData> GetProcessData(string userId)
        {
            var globalUserDCache = await GlobalUserDCache.Create(userId);
            var processData = new ProcessData();

            //运营商编码
            processData.OperatorId = await globalUserDCache.GetOperatorIdAsync();
            //货币编码
            processData.CurrencyId = await globalUserDCache.GetCurrencyIdAsync();
            //config
            processData.ConfigEoList = LobbyDbCacheUtil.GetWeeklyCardConfig(processData.OperatorId, processData.CurrencyId);
            if (processData.ConfigEoList == null || !processData.ConfigEoList.Any())
                throw new CustomException($"config is missing configuration.{processData.OperatorId}|{processData.CurrencyId}");

            //detail配置List
            processData.DetailConfigEoList = LobbyDbCacheUtil.GetAllWeeklyCardDetailConfigs(processData.OperatorId, processData.CurrencyId);

            if (processData.DetailConfigEoList == null || !processData.DetailConfigEoList.Any())
                throw new CustomException($"detail config is missing configuration.{processData.OperatorId}|{processData.CurrencyId}");

            //不同类型卡片配置字典
            processData.ConfigEoDic = processData.ConfigEoList.ToDictionary(d => d.WeeklyCardType, d => d);

            //不同类型卡片奖励明细配置字典
            processData.DetailConfigEoListDic = processData.DetailConfigEoList.OrderBy(d => d.WeeklyCardType).GroupBy(d => d.WeeklyCardType).ToDictionary(d => d.Key, d => d.OrderBy(d => d.DateNumber).ThenBy(d => d.Bonus).ToList());

            //当前utc时间
            processData.UtcTime = DateTime.UtcNow;
            //当前日期
            processData.CurrentDate = processData.UtcTime.ToLocalTime(processData.OperatorId).Date;

            //用户最后一次购买周卡
            processData.WeeklyCardUserEo = (await _weeklyCardUserMo.GetTopSortAsync("UserId = @UserId", 1, "RecDate desc", userId)).FirstOrDefault();

            if (processData.WeeklyCardUserEo != null)
            {
                processData.IsBuyWeeklyCard = processData.WeeklyCardUserEo.IsBuyWeeklyCard;
                processData.WeeklyCardType = processData.WeeklyCardUserEo.WeeklyCardType.ToEnum<WeeklyCardTypeEnum>();
                if (processData.IsBuyWeeklyCard)
                {
                    //用户周卡领取明细
                    processData.UserLastDetailEoList = await _detailMo.GetAsync("UserId = @UserId and DayId >= @StartDate and DayId <= @EndDate", userId, processData.WeeklyCardUserEo.CycleStartDate, processData.WeeklyCardUserEo.CycleEndDate);
                }
            }
            else
            {
                //初始化周卡用户
                await InitWeeklyCardUser(userId);
            }
                

            var weeklyCardShow = await GetWeeklyCardShow(userId);

            processData.CountDown = weeklyCardShow.CountDown;

            return processData;
        }


        public async Task<WeeklyCardExecuteDto> ExecuteAsync(WeeklyCardExecuteIpo ipo)
        {
            var ret = new WeeklyCardExecuteDto();

            var activity = await LobbyUtil.GetSingleActivityAsync(ipo.OperatorId, ipo.CurrencyId, ActivityType.WeeklyCard);

            //活动已下架或过期
            if (activity == null || !activity.Status)
                throw new CustomException(LobbyCodes.RS_ACTIVITY_EXPIRED);

            ipo.ProcessData = await GetProcessData(ipo.UserId);

            ret.ServerTime = $"服务器时间：{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}";
            ret.UtcTime = $"UTC时间：{DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss")}";
            ret.LocalTime = $"运营商当地时间：{ipo.ProcessData.UtcTime.ToLocalTime(ipo.ProcessData.OperatorId).ToString("yyyy-MM-dd HH:mm:ss")}";

            //没买周卡，不让领
            if (!ipo.ProcessData.IsBuyWeeklyCard)
                return ret;

            //当前日期已领取，不让领
            if (ipo.ProcessData.UserLastDetailEoList.Any(d => d.DayId == ipo.ProcessData.CurrentDate))
                return ret;

            //当前日期大于周卡最大领取日期，不让领
            if (ipo.ProcessData.CurrentDate > ipo.ProcessData.WeeklyCardUserEo.CycleEndDate)
                return ret;

            //当前周卡起始日期
            var cycleStartDate = ipo.ProcessData.WeeklyCardUserEo.CycleStartDate;
            //当前领取属于第几天
            var dateNumber = 1;
            for (DateTime startDate = ipo.ProcessData.WeeklyCardUserEo.CycleStartDate;
                startDate <= ipo.ProcessData.WeeklyCardUserEo.CycleEndDate;
                startDate = startDate.AddDays(1)
                )
            {
                if (startDate == ipo.ProcessData.CurrentDate)
                    break;

                dateNumber++;
            }


            TransactionManager tm = new TransactionManager();

            var currencyChangeService = new CurrencyChangeService(ipo.UserId);
            try
            {
                var detailConfigEo = ipo.ProcessData.DetailConfigEoList.Where(d => d.WeeklyCardType == (int)ipo.ProcessData.WeeklyCardType).ElementAt(dateNumber - 1);
                //1、写入sa_weeklycard_deail
                await _detailMo.AddAsync(new Sa_weeklycard_detailEO()
                {
                    DayId = ipo.ProcessData.CurrentDate,
                    UserId = ipo.UserId,
                    WeeklyCardType = (int)ipo.ProcessData.WeeklyCardType,
                    Bonus = detailConfigEo.Bonus,
                    FlowMultip = detailConfigEo.FlowMultip,
                    CurrentCycleNumber = dateNumber,
                    CycleStartDate = ipo.ProcessData.WeeklyCardUserEo.CycleStartDate,
                    CycleEndDate = ipo.ProcessData.WeeklyCardUserEo.CycleEndDate,
                    RecDate = ipo.ProcessData.UtcTime
                }, tm);
                //2、写入货币变化
                var currencyChangeReq = new CurrencyChangeReq()
                {
                    UserId = ipo.UserId,
                    AppId = ipo.AppId,
                    OperatorId = ipo.ProcessData.OperatorId,
                    CurrencyId = ipo.ProcessData.CurrencyId,
                    Reason = "1.7版本周卡",
                    Amount = detailConfigEo.Bonus,
                    SourceType = (int)ActivityType.WeeklyCard,
                    SourceTable = "sa_weeklycard_detail",
                    SourceId = $"{ipo.ProcessData.CurrentDate}|{ipo.UserId}",
                    ChangeTime = DateTime.UtcNow,
                    ChangeBalance = activity.IsBonus ? CurrencyChangeBalance.Bonus : CurrencyChangeBalance.Cash,
                    FlowMultip = detailConfigEo.FlowMultip,
                    TM = tm
                };

                //5、写s_currency_change
                var changeMsg = await currencyChangeService.Add(currencyChangeReq);
                if (changeMsg == null)
                    throw new Exception("写入s_currency_change失败");

                tm.Commit();
                ret.Status = true;
                ret.bonus = detailConfigEo.Bonus.AToM(detailConfigEo.CurrencyID);

                await MQUtil.PublishAsync(changeMsg);

                await MQUtil.PublishAsync(new UserActivityMsg()
                {
                    UserId = ipo.UserId,
                    ActivityType = (int)ActivityType.WeeklyCard
                });

                return ret;
            }
            catch (Exception ex)
            {
                tm.Rollback();
                LogUtil.GetContextLogger().AddException(ex).AddMessage($"WeeklyCardController.Execute.ipo:{JsonConvert.SerializeObject(ipo)}");
                ret.bonus = 0;
                return ret;
            }
        }


        /// <summary>
        /// 购买周卡
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<WeeklyCardBraPayDto> BraDeposit(WeeklyCardBraPayIpo ipo)
        {
            var globalUserDCache = await GlobalUserDCache.Create(ipo.UserId);
            ipo.OperatorId = await globalUserDCache.GetOperatorIdAsync();
            ipo.CurrencyId = await globalUserDCache.GetCurrencyIdAsync();
            ipo.CountryId = await globalUserDCache.GetCountryIdAsync();

            var activity = await LobbyUtil.GetSingleActivityAsync(ipo.OperatorId, ipo.CurrencyId, ActivityType.WeeklyCard);

            //活动已下架或过期
            if (activity == null || !activity.Status)
                throw new CustomException(LobbyCodes.RS_ACTIVITY_EXPIRED);

            //config
            var configEoList = LobbyDbCacheUtil.GetWeeklyCardConfig(ipo.OperatorId, ipo.CurrencyId);
            if (configEoList == null || !configEoList.Any())
                throw new CustomException($"config is missing configuration1.{ipo.OperatorId}|{ipo.CurrencyId}");

            var configEo = configEoList.Where(d => d.WeeklyCardType == (int)ipo.WeeklyCardType).FirstOrDefault();

            if (configEo == null)
                throw new CustomException($"config is missing configuration2.{ipo.OperatorId}|{ipo.CurrencyId}");

            //获取sa_weeklycard_user
            var weeklyCardUserEo = await _weeklyCardUserMo.GetSingleAsync("UserId = @UserId", ipo.UserId);
            if(weeklyCardUserEo != null && weeklyCardUserEo.IsBuyWeeklyCard)
                throw new CustomException($"User has purchased a weekly card.{ipo.UserId}");

            ipo.Amount = configEo.PayAmount.AToM(ipo.CurrencyId);
            ipo.ReceiveBonus = 0;
            ipo.ActivityIdList.Add((int)ActivityType.WeeklyCard);
            ipo.IsAddBalance = false;
            ipo.BraPayChannel = await LobbyUtil.GetPayChannel(ipo.OperatorId, ipo.CurrencyId, ipo.CountryId);

            var ret = new WeeklyCardBraPayDto();

            switch (ipo.BraPayChannel)
            {
                case BraPayChannel.tejeepay:
                    ret = (await new ProfileService().TejeePay(ipo.Map<BraDepositIpo>())).Map<WeeklyCardBraPayDto>();
                    break;
                case BraPayChannel.letspay:
                    ret = (await new ProfileService().LetsPay(ipo.Map<BraDepositIpo>())).Map<WeeklyCardBraPayDto>();
                    break;
                case BraPayChannel.bfpay:
                    ret = (await new ProfileService().BfPay(ipo.Map<BraDepositIpo>())).Map<WeeklyCardBraPayDto>();
                    break;
                default:
                    throw new CustomException(LobbyCodes.RS_UNKNOWN, "AddBraBank channel error.");
            }
            return ret;
        }


        private async Task<WeeklyCardBraPayDto> WeeklyCardPay(WeeklyCardBraPayIpo ipo)
        {
            //需要验证充值金额
            if (ipo.Amount == 0)
                throw new CustomException(LobbyCodes.RS_PARAMETER_ERROR, "Illegal recharge amount.");

            var ret = new WeeklyCardBraPayDto();

            try
            {
                var globalUserDCache = await GlobalUserDCache.Create(ipo.UserId);
                if (ipo.BraPayChannel == BraPayChannel.tejeepay)
                {
                    var request = new Xxyy.Banks.Client.BLL.Tejeepay.XxyyTejeeCommonPayIpo()
                    {
                        Amount = ipo.Amount.MToA(ipo.CurrencyId),
                        UserId = ipo.UserId,
                        AppId = ipo.AppId,
                        CurrencyId = ipo.CurrencyId,
                        UserIp = AspNetUtil.GetRemoteIpString(),
                        ReceiveBonus = ipo.ReceiveBonus,
                        Meta = JsonConvert.DeserializeObject(Convert.ToString(ipo.Meta)),
                        ActivityIds = ipo.ActivityIdList.Map<List<string>>(),
                        IsAddBalance = ipo.IsAddBalance,
                        Phone = await globalUserDCache.GetMobileAsync(),
                        Name = await globalUserDCache.GetUsernameAsync(),
                        Email = await globalUserDCache.GetEmailAsync()
                    };

                    var xxyyBankClient = new Xxyy.Banks.Client.BLL.Tejeepay.TejeepayClient();

                    var response = await xxyyBankClient.TejeePay(request);

                    Log.Information($"Bra充值（tejeePay）,request:{JsonConvert.SerializeObject(request)},response:{JsonConvert.SerializeObject(response)}");

                    if (response.Status != 200 || !response.Result.Status.Equals(ResponseCodes.RS_OK))
                    {
                        LogUtil.Error($"Bra充值（tejeePay）失败,request:{JsonConvert.SerializeObject(request)},response:{JsonConvert.SerializeObject(response)}");
                        throw new CustomException(LobbyCodes.RS_PAY_ERROR, "BraDeposit,tejeePay failed.");
                    }
                    ret.QRCode = response.Result.payUrl;
                    ret.OrderId = response.Result.OrderId;
                }
                else if (ipo.BraPayChannel == BraPayChannel.letspay)
                {
                    var email = await globalUserDCache.GetEmailAsync();
                    var name = await globalUserDCache.GetUsernameAsync();
                    var phone = await globalUserDCache.GetMobileAsync();
                    var request = new XxyyLetsCommonPayIpo()
                    {
                        email = string.IsNullOrWhiteSpace(email) ? "test@lucro777.com" : email,
                        name = string.IsNullOrWhiteSpace(name) ? "name777" : name,
                        phone = string.IsNullOrWhiteSpace(phone) ? "12345678901" : phone,
                        Amount = ipo.Amount.MToA(ipo.CurrencyId),
                        UserId = ipo.UserId,
                        AppId = ipo.AppId,
                        CurrencyId = ipo.CurrencyId,
                        ReceiveBonus = ipo.ReceiveBonus,
                        UserIp = AspNetUtil.GetRemoteIpString(),
                        Meta = JsonConvert.DeserializeObject(Convert.ToString(ipo.Meta)),
                        ActivityIds = ipo.ActivityIdList.Map<List<string>>(),
                        IsAddBalance = ipo.IsAddBalance
                    };
                    var response = await new Xxyy.Banks.Client.BLL.Letspay.LetspayClient().LetsPay(request);

                    Log.Information($"Bra充值（letspay）,request:{JsonConvert.SerializeObject(request)},response:{JsonConvert.SerializeObject(response)}");

                    if (response.Status != 200 || !response.Result.Status.Equals(Xxyy.Banks.Client.ResponseCodes.RS_OK))
                    {
                        LogUtil.Error($"Bra充值（letspay）失败,request:{JsonConvert.SerializeObject(request)},response:{JsonConvert.SerializeObject(response)}");
                        throw new CustomException(LobbyCodes.RS_PAY_ERROR, "BraDeposit,letspay failed.");
                    }

                    ret.QRCode = response.Result.code;
                    ret.OrderId = response.Result.code;
                }
                else
                {
                    throw new CustomException(LobbyCodes.RS_PAY_ERROR, $"BraDeposit error.channel:{ipo.BraPayChannel.ToString()}");
                }
            }
            catch (Exception ex)
            {
                throw new CustomException(LobbyCodes.RS_PAY_ERROR, $"{ex.Message}");
            }

            return ret;
        }



        public async Task<WeeklyCardShow> GetWeeklyCardShow(string userId)
        {
            var ret = new WeeklyCardShow();
            //用户全局缓存
            var globalUserDCache = await GlobalUserDCache.Create(userId);
            //用户类型（游客、注册用户）
            var userMode = await globalUserDCache.GetUserModeAsync();
            if (userMode != UserMode.Register)
                return ret;

            //运营商编码
            var operatorId = await globalUserDCache.GetOperatorIdAsync();
            //货币编码
            var currencyId = await globalUserDCache.GetCurrencyIdAsync();

            var allActivity = LobbyDbCacheUtil.GetAllActivityOperator(operatorId, currencyId).Where(d => d.Status).ToList();

            if (!allActivity.Any(d => d.ActivityID == (int)ActivityType.WeeklyCard))
                return ret;

            //用户注册时间
            var registDate = await globalUserDCache.GetRegistDateAsync();

            //用户购买周卡记录
            var weeklyCardUser = await DbUtil.GetRepository<Sa_weeklycard_userPO>().AsQueryable().Where(d => d.UserId.Equals(userId)).FirstAsync();

            //utc时间
            var utcTime = DateTime.UtcNow;
            //当地日期
            var localDate = utcTime.ToLocalTime(operatorId).Date;

            if (weeklyCardUser == null)
            {
                ret.IsAllowShow = true;
                ret.CountDown = 0;
            }
            else
            {
                //已经购买周卡
                if (weeklyCardUser.IsBuyWeeklyCard)
                {
                    //当地日期在周卡领取周期内时，显示入口
                    if (localDate < weeklyCardUser.CycleEndDate.AddDays(1).Date)
                    {
                        ret.IsAllowShow = true;
                        ret.IsBuyWeeklyCard = true;
                    }
                }
                else
                {
                    //周卡配置
                    var weeklyCardConfigEoList = LobbyDbCacheUtil.GetWeeklyCardConfig(operatorId, currencyId);
                    //周卡倒计时
                    var countDown = weeklyCardConfigEoList.Max(d => d.CountDown);
                    //未购买周卡，并且倒计时开始日期+配置值 > utc时间
                    if (weeklyCardUser.CountDownStart.AddHours(countDown) > utcTime)
                    {
                        ret.IsAllowShow = true;
                        ret.CountDown = Convert.ToInt64((weeklyCardUser.CountDownStart.AddHours(countDown) - DateTime.UtcNow).TotalSeconds);
                    }
                }

            }

            return ret;
        }


        /// <summary>
        /// 初始化周卡用户
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<bool> InitWeeklyCardUser(string userId)
        {
            var globalUserDCache = await GlobalUserDCache.Create(userId);

            //游客不初始化
            var userMode = await globalUserDCache.GetUserModeAsync();
            if (userMode != UserMode.Register)
                return false;

            var operatorId = await globalUserDCache.GetOperatorIdAsync();
            var currencyId = await globalUserDCache.GetCurrencyIdAsync();
            var utcNow = DateTime.UtcNow;
            var localDate = utcNow.ToLocalTime(operatorId);

            TransactionManager tm = new TransactionManager();

            try
            {
                //获取是否存在用户
                var weeklyCardUserEo = await _weeklyCardUserMo.GetSingleAsync("UserId = @UserId", tm, userId);
                //不存在则初始化
                if (weeklyCardUserEo == null)
                {
                    await _weeklyCardUserMo.AddAsync(new Sa_weeklycard_userEO()
                    {
                        UserId = userId,
                        OperatorID = operatorId,
                        CurrencyID = currencyId,
                        WeeklyCardType = (int)WeeklyCardTypeEnum.none,
                        FromId = await globalUserDCache.GetFromIdAsync(),
                        FromMode = await globalUserDCache.GetFromModeAsync(),
                        PayAmount = 0,
                        FlowMultip = 1,
                        CycleStartDate = localDate.Date,
                        CycleEndDate = localDate.Date,
                        CountDownStart = DateTime.UtcNow,
                        IsBuyWeeklyCard = false,
                        RecDate = utcNow
                    }, tm);
                }
                tm.Commit();
                return true;
            }
            catch (Exception ex)
            {
                tm.Rollback();
                LogUtil.GetContextLogger().AddException(ex).AddMessage($"WeeklyCardService.InitWeeklyCardUser.userId:{userId}");
                return false;
            }
        }

    }

}
