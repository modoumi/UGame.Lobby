using Google.Protobuf.WellKnownTypes;
using UGame.Lobby.Common.Enum;
using UGame.Lobby.Repository.ing;
using Newtonsoft.Json;
using AiUo;
using AiUo.AspNet;
using AiUo.Data.SqlSugar;
using AiUo.Extensions.AutoMapper;
using AiUo.Logging;
using UGame.Lobby.Service.Caching;
using UGame.Lobby.Service.Caching.Activity;
using UGame.Lobby.Service.Caching.Activity.BindMobile;
using UGame.Lobby.Service.Caching.Activity.Register7;
using UGame.Lobby.Service.Caching.Activity.Regpay;
using UGame.Lobby.Service.Caching.Activity.Roulette;
using UGame.Lobby.Service.Caching.SCommon;
using UGame.Lobby.Service.Common;
using UGame.Lobby.Service.Services.Activity.Roulette;
using UGame.Lobby.Service.Services.Activity.WeeklyCard;
using UGame.Lobby.Service.Services.Vip;
using Xxyy.Common;
using Xxyy.Common.Caching;
using Xxyy.Common.Services;
using Xxyy.DAL;
using Xxyy.Partners.Client;

namespace UGame.Lobby.Service.Services.Init
{
    /// <summary>
    /// InitService
    /// </summary>
    public class InitService
    {
        private L_user_infoMO _userInfoMo = new();

        private Xxyy.Partners.Client.XxyyProviderClient _providerClient = new();

        private RouletteService _rouletteService = new();

        private async Task ExecuteContext(LoadContext context)
        {
            //大厅用户数据
            await InitUserInfo(context);
            //注册、首充活动，100001
            //await InitRegpayUser(context);
            //绑定手机活动,100006
            //await InitBindMobile(context);
            //注册送bonus活动，100007，迁移至scommon
            //await InitRegister7(context);
            //幸运轮盘活动，100002
            //await InitRouletteUser(context);
            //用户邮件相关
            //await GetUserMessageInfo(context);
            //用户vip信息
            //await GetUserVipInfo(context);
            //首页浮窗
            await GetIndexFloatingWindows(context);
            //周卡
            await WeeklyCardExcute(context);
        }

        public async Task<LoadContext> BuildLoadContext(LoadIpo ipo)
        {
            var context = new LoadContext();
            context.GlobalUserDCache = await GlobalUserDCache.Create(ipo.UserId);
            ipo.OperatorId = await context.GlobalUserDCache.GetOperatorIdAsync();
            ipo.CountryId = await context.GlobalUserDCache.GetCountryIdAsync();
            ipo.CurrencyId = await context.GlobalUserDCache.GetCurrencyIdAsync();
            context.Ipo = ipo;
            //用户基本字段
            context.UserKind = await context.GlobalUserDCache.GetUserKindAsync();
            context.NickName = await context.GlobalUserDCache.GetNicknameAsync();
            context.Mobile = await context.GlobalUserDCache.GetMobileAsync();
            context.Email = await context.GlobalUserDCache.GetEmailAsync();
            context.UserMode = await context.GlobalUserDCache.GetUserModeAsync();

            //请求ip
            context.UserIp = AspNetUtil.GetRemoteIpString();
            context.GlobalUserDCacheEx = GlobalUserDCacheEx.Create(ipo.UserId, ipo.CurrencyId);

            //当前operatorId下全部活动，包含下架活动
            context.ActivityOperatorEoList = LobbyDbCacheUtil.GetAllActivityOperator(ipo.OperatorId, ipo.CurrencyId);

            var sOperator = DbCacheUtil.GetOperator(ipo.OperatorId);
            if (sOperator != null)
                context.Config.Version = sOperator.OperatorVersion;

            return context;
        }

        public async Task<LoadDto> Load(LoadIpo ipo)
        {
            var context = await BuildLoadContext(ipo);

            await ExecuteContext(context);

            var dto = context.Map<LoadDto>();

            return dto;
        }

        /// <summary>
        /// 初始化l_user_info
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        private async Task InitUserInfo(LoadContext context)
        {
            //l_user_info表中是否存在当前用户数据
            var hasLUserInfo = await context.GlobalUserDCacheEx.GetHasLUserInfo();

            var lUserInfoRsp = DbUtil.GetRepository<L_user_infoPO>();

            var lUserInfoEo = await lUserInfoRsp.AsQueryable().Where(d => d.UserID.Equals(context.Ipo.UserId)).FirstAsync();

            try
            {
                //从l_user_info中查找此用户，如果没有则进行数据初始化
                if (!hasLUserInfo && lUserInfoEo == null)
                {
                    //保留一段时间，初始化数据部分已经由NewUserMQSub执行
                    var userInfo = new L_user_infoPO()
                    {
                        UserID = context.Ipo.UserId,
                        OperatorID = context.Ipo.OperatorId,
                        CountryID = context.Ipo.CountryId,
                        CurrencyID = context.Ipo.CurrencyId,
                        UserKind = (int)context.UserKind,
                        NickName = context.NickName,
                        PhoneNumber = context.Mobile,
                        Email = context.Email,
                        RecDate = DateTime.UtcNow
                    };
                    await lUserInfoRsp.InsertAsync(userInfo);
                    await context.GlobalUserDCacheEx.SetHasLUserInfo();
                }
                else
                {
                    switch (context.Ipo.CountryId)
                    {
                        case "MEX":
                            if (context.UserMode == UserMode.Register
                                && !string.IsNullOrWhiteSpace(lUserInfoEo.NickName)
                                && !string.IsNullOrWhiteSpace(lUserInfoEo.FirstName)
                                && !string.IsNullOrWhiteSpace(lUserInfoEo.LastName)
                                && lUserInfoEo.BirthDay.HasValue
                                && !string.IsNullOrWhiteSpace(lUserInfoEo.PhoneNumber)
                                && !string.IsNullOrWhiteSpace(lUserInfoEo.Email))
                                context.IsTipPersonalForm = false;
                            else
                                context.IsTipPersonalForm = true;
                            break;
                        case "BRA":
                            if (context.UserMode == UserMode.Register
                                && !string.IsNullOrWhiteSpace(lUserInfoEo.NickName)
                                && !string.IsNullOrWhiteSpace(lUserInfoEo.FirstName)
                                && !string.IsNullOrWhiteSpace(lUserInfoEo.LastName)
                                && lUserInfoEo.BirthDay.HasValue
                                && !string.IsNullOrWhiteSpace(lUserInfoEo.Email))
                                context.IsTipPersonalForm = false;
                            else
                                context.IsTipPersonalForm = true;
                            break;
                        default:
                            break;
                    }
                    await lUserInfoRsp.UpdateSetColumnsTrueAsync(d => new L_user_infoPO { PhoneNumber = context.Mobile }, d => d.UserID.Equals(context.Ipo.UserId));
                }
            }
            catch (Exception ex)
            {
                LogUtil.GetContextLogger().AddException(ex).AddMessage("lobby_load_InitUserInfo异常")
                    .AddField("HasLUserInfo_redis", hasLUserInfo)
                    .AddField("HasLlUserInfoEo_db", lUserInfoEo == null);
            }

            //如果是游客，则不提示完善个人信息弹框
            if (context.UserMode == UserMode.Visitor)
                context.IsTipPersonalForm = false;

        }

        /// <summary>
        /// 初始化sa_regpay_user，活动100001
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        /// <exception cref="CustomException"></exception>
        private async Task<bool> InitRegpayUser(LoadContext context)
        {
            if (context.ActivityOperatorEoList == null
                || !context.ActivityOperatorEoList.Any()
                || !context.ActivityOperatorEoList.Any(d => d.ActivityID == (int)ActivityType.RegPay && d.Status)
                )
                return false;

            var hasRegpayUser = await context.GlobalUserDCacheEx.GetHasRegpayUser();
            if (hasRegpayUser)
            {
                return true;
            }

            //如果是注册用户
            if (context.UserMode == UserMode.Register)
            {
                RegpayUserDCache regpayUserDCache = new RegpayUserDCache(context.Ipo.OperatorId, context.Ipo.UserId);
                var regpayUser = await regpayUserDCache.GetOrLoadAsync();
                //有数据直接返回
                if (regpayUser.HasValue)
                {
                    if (regpayUser.Value.SumPay <= 0 && regpayUser.Value.ReturnRewards <= 0)
                        context.IsTipRegister = false;
                    else
                        context.IsTipRegister = true;

                    return true;
                }

                var field = RegpayConfigDCahce.GetField(context.Ipo.OperatorId, context.Ipo.CurrencyId);
                var regpayConfigDCahce = new RegpayConfigDCahce();
                var regpayConfig = await regpayConfigDCahce.GetOrLoadAsync(field);

                if (regpayConfig == null)
                    throw new CustomException($"regpay,The operatorId({context.Ipo.OperatorId}) and CurrencyId{context.Ipo.CurrencyId} data do not exist.");

                try
                {

                    var addEo = new Sa_regpay_userPO()
                    {
                        UserID = context.Ipo.UserId,
                        OperatorID = context.Ipo.OperatorId,
                        CountryId = context.Ipo.CountryId,
                        CurrencyID = context.Ipo.CurrencyId,
                        SumPay = regpayConfig.Value.RegReward,
                        RegPay = regpayConfig.Value.RegReward,
                        IsRegPay = true,
                        RecDate = DateTime.UtcNow
                    };

                    await DbUtil.GetRepository<Sa_regpay_userPO>().InsertAsync(addEo);

                    await context.GlobalUserDCacheEx.SetHasRegpayUser();
                }
                catch (Exception ex)
                {
                    LogUtil.GetContextLogger().AddException(ex).AddMessage("lobby_load_InitRegpayUser异常");
                }

                return true;
            }
            return false;
        }

        /// <summary>
        /// 初始化sa_bind_mobile_user，活动100006
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        private async Task InitBindMobile(LoadContext context)
        {
            if (context.ActivityOperatorEoList == null
                || !context.ActivityOperatorEoList.Any()
                || !context.ActivityOperatorEoList.Any(d => d.ActivityID == (int)ActivityType.BindMobile && d.Status)
                )
                return;

            //获取配置
            var field = BindMobileConfigDCache.GetField(context.Ipo.OperatorId, context.Ipo.CurrencyId);
            var bindMobileConfig = await new BindMobileConfigDCache().GetOrLoadAsync(field);

            //var saIpRecordEo = await DbUtil.GetRepository<Sa_ip_recordPO>().AsQueryable()
            //    .Where(d => d.IpAddress.Equals(context.UserIp) 
            //                && d.OperatorID.Equals(context.Ipo.OperatorId) 
            //                && d.CurrencyID.Equals(context.Ipo.CurrencyId) 
            //                && d.ActivityID == (int)ActivityType.BindMobile)
            //    .FirstAsync();
            var notExistIp =await new UserIpActivityDCache(context.Ipo.OperatorId,(int)ActivityType.BindMobile).GetNum(context.UserIp)==0;

            if (!string.IsNullOrWhiteSpace(context.Mobile))
                context.BindMobile.IsExistsMobile = true;

            //如果活动配置有效
            //并且送bonus
            //并且当前ip未参加绑定手机送bonus
            //并且ip有效
            //并且当前用户手机号为空
            if (bindMobileConfig.HasValue
                && bindMobileConfig.Value.IsSendBonus
                && notExistIp
                && !string.IsNullOrWhiteSpace(context.UserIp)
                && string.IsNullOrWhiteSpace(context.Mobile)
                )
            {
                context.BindMobile.IsTipMobile = true;
                context.BindMobile.Bonus = bindMobileConfig.Value.SendBonus.AToM(context.Ipo.CurrencyId);
            }

        }

        /// <summary>
        /// 初始化sa_register100007_user，活动100007
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        private async Task InitRegister7(LoadContext context)
        {
            if (context.ActivityOperatorEoList == null
                || !context.ActivityOperatorEoList.Any()
                || !context.ActivityOperatorEoList.Any(d => d.ActivityID == (int)ActivityType.Register7 && d.Status)
                )
                return;

            //获取配置
            var field = Register7ConfigDCache.GetField(context.Ipo.OperatorId, context.Ipo.CurrencyId);
            var register7Config = await new Register7ConfigDCache().GetOrLoadAsync(field);

            //var saIpRecordEo = await new Sa_ip_recordMO().GetSingleAsync("IpAddress = @IpAddress and OperatorId = @OperatorId and CurrencyId = @CurrencyId and ActivityID = @ActivityID", context.UserIp, context.Ipo.OperatorId, context.Ipo.CurrencyId, (int)ActivityType.Register7);
            var notExistIp = await new UserIpActivityDCache(context.Ipo.OperatorId, (int)ActivityType.Register7).GetNum(context.UserIp) == 0;

            //如果是游客
            //并且有配置
            //并且当前ip未参加register7送bonus
            //并且ip有效
            if (context.UserMode == UserMode.Visitor
                && register7Config.HasValue
                && register7Config.Value.IsSendBonus
                && notExistIp
                && !string.IsNullOrWhiteSpace(context.UserIp)
                )
            {
                context.Register7.IsTipRegister = true;
                context.Register7.Bonus = register7Config.Value.SendBonus.AToM(context.Ipo.CurrencyId);
            }

        }

        /// <summary>
        /// 初始化sa_roulette_user，活动100002
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        private async Task<bool> InitRouletteUser(LoadContext context)
        {
            if (context.ActivityOperatorEoList == null
                || !context.ActivityOperatorEoList.Any()
                || !context.ActivityOperatorEoList.Any(d => d.ActivityID == (int)ActivityType.Roulette && d.Status)
                )
                return false;

            //有数据，直接返回
            if (await context.GlobalUserDCacheEx.GetHasRouletteUserAsync())
            {
                //写缓存
                var rouletteUserDCache = new RouletteUserDCache(context.Ipo.OperatorId, context.Ipo.UserId);
                var rouletteUser = await rouletteUserDCache.GetAsync();
                if (rouletteUser.HasValue && rouletteUser.Value.IsRegPay)
                    return true;
            }

            //初始化sa_roulette_user
            var initRouletteUserRet = await _rouletteService.InitRouletteUser(context.Ipo.UserId, (int)context.UserMode, (int)context.UserKind, context.Ipo.OperatorId, context.Ipo.CurrencyId);

            if (!initRouletteUserRet.success)
            {
                LogUtil.GetContextLogger().AddMessage($"Lobby:Load:InitRouletteUser,error:{initRouletteUserRet.message}");
            }

            return initRouletteUserRet.success;
        }

        /// <summary>
        /// 获取用户未读邮件数量
        /// </summary>
        /// <returns></returns>
        private async Task GetUserMessageInfo(LoadContext context)
        {
            context.UserMessageInfo.UnReadMessageCount = 0;// await new EmailService().LastMessageCount(context.Ipo.UserId);
        }

        private async Task GetUserVipInfo(LoadContext context)
        {
            context.UserVipInfo = new UserVipInfoDto();// await new ProfileService().GetVipInfo(context.Ipo.Map<UserVipInfoIpo>());
        }

        /// <summary>
        /// 首页浮窗
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        private async Task GetIndexFloatingWindows(LoadContext context)
        {
            if (context.UserMode == UserMode.Visitor)
                return;
            //用户类型
            var bannerType = context.UserMode == UserMode.Visitor ? 1 : 2;

            //获取banner position=6
            var bannerCache = new SCBannerDCache(bannerType, context.Ipo.AppId, context.Ipo.OperatorId, context.Ipo.LangId, (int)BannerPosition.IndexFloatingWindow);

            var bannerData = await bannerCache.GetAsync();

            if (!bannerData.HasValue)
                return;

            if (context.UserActivityEoList == null || !context.UserActivityEoList.Any())
                context.UserActivityEoList = await DbUtil.GetRepository<L_user_activityPO>().AsQueryable().Where(d => d.UserID.Equals(context.Ipo.UserId)).ToListAsync();

            foreach (var item in bannerData.Value)
            {
                var floatingWindow = new IndexFloatingWindow()
                {
                    Code = item.Code,
                    ImageUrl = LobbyUtil.GetIcon(item.ImageUrl),
                    LinkUrl = item.LinkUrl
                };

                //有效活动
                if (context.ActivityOperatorEoList.Any(d => d.Status && d.ActivityID == item.Code))
                {
                    if (context.UserActivityEoList.Any(d => d.ActivityId == item.Code && d.IsEnd))
                        continue;
                    //如果l_user_activity不包含此活动
                    //或包含此活动并且当前活动未完成时
                    if (!context.UserActivityEoList.Any(d => d.ActivityId == item.Code)
                        || context.UserActivityEoList.Any(d => d.ActivityId == item.Code && !d.IsEnd))
                    {
                        context.IndexFloatingWindows.Add(floatingWindow);
                        continue;
                    }
                }
                //非活动弹框
                context.IndexFloatingWindows.Add(floatingWindow);
            }
        }

        /// <summary>
        /// 周卡
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        private async Task WeeklyCardExcute(LoadContext context)
        {
            //周卡
            var weeklyCardShow = await new WeeklyCardService().GetWeeklyCardShow(context.Ipo.UserId);

            context.WeeklyCard = new WeeklyCardConfig()
            {
                IsAllowBuy = weeklyCardShow.IsAllowShow,
                CountDown = weeklyCardShow.CountDown
            };
        }


        /// <summary>
        /// 获取应用url
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        public async Task<LobbyAppUrlDto> GetAppUrl(LobbyAppUrlIpo ipo)
        {
            //从s_operator_app中获取当前appId，如果s_operator_app.CashLimit > 0 && s_user.Cash > s_operator_app.CashLimit
            var operatorApp = DbCacheUtil.GetOperatorApp(ipo.OperatorId, ipo.AppId, false);

            //当前运营商中不存在当前appid
            if (operatorApp == null)
            {
                LogUtil.GetContextLogger().AddMessage("lobby_InitLobby_GetAppUrl")
                    .AddField("ipo", JsonConvert.SerializeObject(ipo))
                    .AddField("errorMessage", $"s_operator_app不存在定义。operatorId: {ipo.OperatorId},appId:{ipo.AppId}");
                throw new CustomException(LobbyCodes.RS_OPERATOR_EXISTS_APP, $"{ipo.AppId} does not exist in {ipo.OperatorId}");
            }

            var userExEo = await DbSink.BuildUserExMo(ipo.UserId).GetByPKAsync(ipo.UserId);
            if (userExEo == null)
                throw new CustomException(LobbyCodes.RS_UNKNOWN, $"user does not exist.");

            //当前用户充值总金额
            var userTotalPayAmount = userExEo.TotalPayAmount;

            var sUserEo = await DbUtil.GetRepository<S_userPO>().AsQueryable().Where(d => d.UserID.Equals(ipo.UserId)).FirstAsync();

            if (sUserEo.UserKind != (int)UserKind.Tester)
            {
                //如果进入当前app对用户充值数量有要求，并且用户充值金额不满足时
                if (operatorApp.PayLimit > 0 && userTotalPayAmount.AToM(ipo.CurrencyId) < operatorApp.PayLimit)
                    throw new CustomException(LobbyCodes.RS_NOT_ENOUGH_MONEY, $"Insufficient user recharge quantity.", result: operatorApp.PayLimit);

                //如果当前用户余额小于进入app设置的最低金额
                if (operatorApp.CashLimit > 0 && sUserEo.Cash.AToM(ipo.CurrencyId) < operatorApp.CashLimit)
                    throw new CustomException(LobbyCodes.RS_NOT_ENOUGH_MONEY, $"User balance is less than the app's minimum limit fund.", result: operatorApp.CashLimit);
            }

            try
            {
                var _response = await _providerClient.AppUrl(ipo.Map<XxyyAppUrlIpo>());
                if (_response == null || !_response.Success)
                    throw new CustomException($"ProviderClient的AppUrl接口异常.{JsonConvert.SerializeObject(ipo)},response:{JsonConvert.SerializeObject(_response)}");
                return _response.Result.Map<LobbyAppUrlDto>();

            }
            catch (Exception ex)
            {
                LogUtil.GetContextLogger().AddException(ex).AddMessage($"AppUrl接口异常，ipo:{JsonConvert.SerializeObject(ipo)}");
                return null;
            }
        }

    }
}
