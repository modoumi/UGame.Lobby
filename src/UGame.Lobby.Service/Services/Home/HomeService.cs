using UGame.Lobby.Common.Enum;
using UGame.Lobby.Repository.ing;
using SqlSugar;
using AiUo;
using AiUo.Collections;
using AiUo.Configuration;
using AiUo.Data;
using AiUo.Data.SqlSugar;
using AiUo.Extensions.AutoMapper;
using AiUo.Logging;
using UGame.Lobby.Service.Caching;
using UGame.Lobby.Service.Caching.Home;
using UGame.Lobby.Service.Caching.Pay;
using UGame.Lobby.Service.Common;
using UGame.Lobby.Service.Services.Activity.PayReward;
using UGame.Lobby.Service.Services.Activity.UserPay100008;
using UGame.Lobby.Service.Services.Activity.WeeklyCard;
using UGame.Lobby.Service.Services.Home.pay;
using UGame.Lobby.Service.Services.Init;
using Xxyy.Common;
using Xxyy.Common.Caching;

namespace UGame.Lobby.Service.Services.Home;

public class HomeService
{
    private static string _imageBaseUrl;

    private LobbyOptionsSection _options;

    public HomeService()
    {
        _options = ConfigUtil.GetSection<LobbyOptionsSection>();
        _imageBaseUrl = _options.ImageBaseUrl;
    }

    /// <summary>
    /// 获取一级分类
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    public async Task<List<CategoryListDto>> CategoryList(CategoryListIpo ipo)
    {
        var ret = new List<CategoryListDto>();

        var cache = await new CategoryFirstLevelDCache(ipo.OperatorId, ipo.LangId).GetAsync();
        if (!cache.HasValue) return ret;

        return cache.Value.Map<List<CategoryListDto>>();
    }

    /// <summary>
    /// 获取一级分类的游戏列表
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    public async Task<List<CategoryDetailDto>> CategoryDetail(CategoryDetailIpo ipo)
    {
        var ret = await new CategoryDetailDCache(ipo.OperatorId, ipo.LangId, ipo.CategoryID).GetAsync();

        if (!ret.HasValue) return new List<CategoryDetailDto>();

        var globalUserDCacheEx = GlobalUserDCacheEx.Create(ipo.UserId);

        var favorites = await globalUserDCacheEx.GetFavoriteAppIds();
        foreach (var item in ret.Value)
        {
            foreach (var app in item.Apps)
            {
                BuildAppDetailDto(app, ipo.OperatorId, ipo.LangId, favorites);
            }
            item.Apps = item.Apps.Where(d => d.Status > 0).ToList();
            item.Icon = GetIcon(item.Icon);
        }
        return ret.Value;
    }

    /// <summary>
    /// BuildAppDetailDto
    /// </summary>
    /// <param name="app"></param>
    /// <param name="operatorId"></param>
    /// <param name="langId"></param>
    /// <param name="userDavorites"></param>
    /// <returns></returns>
    /// <exception cref="CustomException"></exception>
    private AppDetailDto BuildAppDetailDto(AppDetailDto app, string operatorId, string langId, HashSet<string> userDavorites)
    {
        if (app == null) throw new CustomException("BuildCategoryMoreDto_app is null");

        var sAppEo = DbCacheUtil.GetApp(app.AppId, false);
        if (sAppEo == null || sAppEo.Status == 0) return app;

        app.Status = sAppEo.Status;
        var provider = DbCacheUtil.GetProvider(sAppEo.ProviderID, false);
        if (provider == null) return app;

        var operatorApp = DbCacheUtil.GetOperatorApp(operatorId, sAppEo.AppID, false);
        if (operatorApp == null) return app;

        var sAppLang = DbCacheUtil.GetAppLang(sAppEo.AppID, langId);
        if (sAppLang == null) return app;

        app.AppName = sAppLang.AppName;
        app.IsFavorite = userDavorites != null && userDavorites.Contains(app.AppId);
        app.IsSupportBonus = operatorApp.UseBonus;
        app.IsOwn = provider.ProviderType;
        app.EffectStatus = operatorApp.EffectStatus;
        app.Icon = GetIcon(app.Icon);
        app.SmallIcon = GetIcon(app.SmallIcon);
        app.MiddleIcon = GetIcon(app.MiddleIcon);
        app.BigIcon = GetIcon(app.BigIcon);

        return app;
    }

    /// <summary>
    /// 获取二级分类的游戏列表(分页,返回count=0表示结束分页)
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    public async Task<List<AppDetailDto>> CategoryMore(CategoryMoreIpo ipo)
    {
        var list = await new CategoryMoreDCache(ipo.OperatorId, ipo.LangId, ipo.CategoryID).GetAsync();

        if (!list.HasValue)
            return new List<AppDetailDto>();

        var pageSize = ipo.PageSize;
        var begin = ipo.PageIndex * pageSize;

        var ret = list.Value.Skip(pageSize * (ipo.PageIndex - 1)).Take(pageSize);
        var favorites = await GlobalUserDCacheEx.Create(ipo.UserId).GetFavoriteAppIds();
        foreach (var app in ret)
        {
            BuildAppDetailDto(app, ipo.OperatorId, ipo.LangId, favorites);
        }
        ret = ret.Where(d => d.Status > 0).ToList();
        return ret.ToList();
    }

    /// <summary>
    /// 获取一级分类中All Games游戏列表
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    public async Task<List<AppDetailDto>> FirstCategoryGames(CategoryFirstLevelGameIpo ipo)
    {
        var ret = new List<AppDetailDto>();

        var list = await new CategoryAllGamesDCache(ipo.OperatorId, ipo.LangId, ipo.categoryId).GetAsync();

        if (!list.HasValue)
            return new List<AppDetailDto>();

        ret = list.Value.Skip(ipo.PageSize * (ipo.PageIndex - 1)).Take(ipo.PageSize).ToList();

        var favorites = await GlobalUserDCacheEx.Create(ipo.UserId).GetFavoriteAppIds();

        foreach (var app in ret)
        {
            BuildAppDetailDto(app, ipo.OperatorId, ipo.LangId, favorites);
        }
        ret = ret.Where(d => d.Status > 0).ToList();
        return ret.ToList();
    }

    /// <summary>
    /// 获取一级分类中MyGame的游戏列表
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    public async Task<List<AppDetailDto>> CategoryMyGame(CategoryMyGameIpo ipo)
    {
        var userFavoriteRsp = DbUtil.GetRepository<V_l_user_favoritePO>();

        var list = await userFavoriteRsp.AsQueryable()
            .Where(d => d.UserID.Equals(ipo.UserId))
            .OrderByDescending(d => d.Type)
            .OrderByDescending(d => d.RecDate)
            .ToPageListAsync(ipo.PageIndex, ipo.PageSize);

        var favorites = await GlobalUserDCacheEx.Create(ipo.UserId).GetFavoriteAppIds();

        //如果用户收藏+用户玩过的游戏小于配置AppOptions.MyGameRandomAppNumber
        //则从相同OperatorId的游戏中推荐游戏，直到满足这个数量
        if (list.Count < ipo.MyGameRandomAppNumber)
        {
            var categoryDetailRsp = DbUtil.GetRepository<V_l_category_detailPO>();

            var randomAppList = await categoryDetailRsp.AsQueryable()
                .Where(d => d.Flag == 1 && d.OperatorID.Equals(ipo.OperatorId))
                .ToListAsync();


            if (randomAppList != null && randomAppList.Any())
            {
                foreach (var item in randomAppList)
                {
                    if (list.Count() == ipo.MyGameRandomAppNumber)
                        break;
                    if (!list.Any(d => d.AppID.Equals(item.AppID)))
                    {
                        list.Add(new V_l_user_favoritePO()
                        {
                            UserID = ipo.UserId,
                            Type = 0,
                            RecDate = DateTime.MinValue,
                            AppID = item.AppID,
                            Flag = item.Flag,
                            SmallIcon = item.SmallIcon,
                            MiddleIcon = item.MiddleIcon,
                            BigIcon = item.BigIcon
                        });
                    }
                }
            }
        }

        var ret = list.Map<List<AppDetailDto>>();

        foreach (var item in ret)
        {
            BuildAppDetailDto(item, ipo.OperatorId, ipo.LangId, favorites);
        }
        ret = ret.Where(d => d.Status > 0).ToList();
        return ret;
    }

    /// <summary>
    /// 获取关键字列表
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    public async Task<List<KeywordsDto>> Keywords(KeywordsIpo ipo)
    {
        var ret = new List<KeywordsDto>();
        var cacheValue = await new LKeywordsDCache(ipo.OperatorId, ipo.LangId).GetAsync();

        if (!cacheValue.HasValue)
            return new List<KeywordsDto>();

        return cacheValue.Value;
    }

    /// <summary>
    /// 查询关键字获取游戏列表
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    public async Task<List<AppDetailDto>> QueryKeyword(QueryKeywordIpo ipo)
    {
        var ret = await new QueryKeywordDCache(ipo.OperatorId, ipo.KeywordID).GetAsync();

        var favorites = await GlobalUserDCacheEx.Create(ipo.UserId).GetFavoriteAppIds();
        foreach (var app in ret.Value)
        {
            BuildAppDetailDto(app, ipo.OperatorId, ipo.LangId, favorites);
        }
        return ret.Value.Where(d => d.Status > 0).ToList();
    }

    /// <summary>
    /// 查询用户输入获取游戏类表
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    public async Task<List<AppDetailDto>> QueryInput(QueryInputIpo ipo)
    {
        var rsp = DbUtil.GetRepository<V_l_query_inputPO>();

        var list = await rsp.AsQueryable()
            .Where(d => (string.IsNullOrWhiteSpace(d.LangID) || d.LangID.Equals(ipo.LangId)) && (string.IsNullOrWhiteSpace(d.OperatorID) || d.OperatorID.Equals(ipo.OperatorId)) && d.QueryKey.Contains(ipo.Input))
            .Skip((ipo.PageIndex - 1) * ipo.PageSize)
            .Take(ipo.PageSize)
            .ToListAsync();

        var ret = new List<AppDetailDto>();
        var favorites = await GlobalUserDCacheEx.Create(ipo.UserId).GetFavoriteAppIds();
        foreach (var item in list)
        {
            var lapp = LobbyDbCacheUtil.GetLApp(item.AppID, false);

            if (lapp == null)
                continue;

            var appDetailDto = new AppDetailDto()
            {
                AppId = item.AppID,
                Flag = lapp.Flag,
                SmallIcon = lapp.SmallIcon,
                MiddleIcon = lapp.MiddleIcon,
                BigIcon = lapp.BigIcon
            };

            appDetailDto.Icon = appDetailDto.BigIcon;
            if (string.IsNullOrWhiteSpace(appDetailDto.Icon))
                appDetailDto.Icon = appDetailDto.MiddleIcon;
            if (string.IsNullOrWhiteSpace(appDetailDto.Icon))
                appDetailDto.Icon = appDetailDto.SmallIcon;

            BuildAppDetailDto(appDetailDto, ipo.OperatorId, ipo.LangId, favorites);
            ret.Add(appDetailDto);
        }
        return ret.Where(d => d.Status > 0 && !string.IsNullOrWhiteSpace(d.Icon)).ToList();
    }

    /// <summary>
    /// 用户收藏或取消收藏游戏
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    public async Task Favorite(FavoriteIpo ipo)
    {
        var rsp = DbUtil.GetRepository<L_user_favoritePO>();

        var limitCount = 50; //收藏限制50条
        var list = await rsp.AsQueryable()
            .Where(d => d.UserID.Equals(ipo.UserId) && d.Type == 2)
            .OrderBy(d => d.RecDate)
            .ToListAsync();

        try
        {
            if (list.Any(d => d.AppID.Equals(ipo.AppId)))
            {
                await rsp.DeleteAsync(d => d.UserID.Equals(ipo.UserId) && d.AppID.Equals(ipo.AppId));
            }
            else
            {
                if (list.Count >= limitCount)
                {
                    var userId = list[0].UserID;
                    var appId = list[0].AppID;
                    await rsp.DeleteAsync(d => d.UserID.Equals(userId) && d.AppID.Equals(appId));
                }

                await rsp.InsertAsync(new L_user_favoritePO
                {
                    AppID = ipo.AppId,
                    UserID = ipo.UserId,
                    Type = 2,
                    RecDate = DateTime.UtcNow
                });
            }
            await GlobalUserDCacheEx.Create(ipo.UserId).SetFavoriteAppIds(null);
        }
        catch (Exception ex)
        {
            LogUtil.GetContextLogger()
                .AddException(ex)
                .AddMessage("lobby_HomeService_Favorite")
                .AddField("errorMessage", ex.Message);
        }

    }

    /// <summary>
    /// 获取活动数据
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    public async Task<List<ActivityDto>> GetActivitys(ActivityIpo ipo)
    {
        var ret = new List<ActivityDto>();

        var cache = new PromotionDCache($"{ipo.OperatorId}|{ipo.LangId}");
        var cacheValue = await cache.GetAsync();

        if (!cacheValue.HasValue)
            return ret;

        List<int> ignoreActivityKind = new List<int>();

        if (cacheValue.HasValue && cacheValue.Value.Any(d => d.Kind == (int)ActivityType.WeeklyCard))
        {
            var weeklyCard = await new WeeklyCardService().GetWeeklyCardShow(ipo.UserId);

            if (!weeklyCard.IsAllowShow)
            {
                foreach (var item in cacheValue.Value)
                {
                    if (item.Kind == (int)ActivityType.WeeklyCard)
                    {
                        ignoreActivityKind.Add(item.Kind);
                        break;
                    }
                }
            }
        }

        ret = cacheValue.Value.Where(d => !ignoreActivityKind.Contains(d.Kind)).Map<List<ActivityDto>>();

        var activityOperators = LobbyDbCacheUtil.GetAllActivityOperator(ipo.OperatorId, ipo.CurrencyId);

        if (activityOperators != null && activityOperators.Any())
            activityOperators = activityOperators.Where(d => d.Status).ToList();

        var removedActivities = new List<ActivityDto>();
        foreach (var item in ret)
        {
            if (!activityOperators.Exists(f => f.ActivityID == item.Kind))
                removedActivities.Add(item);
        }
        if (removedActivities.Count > 0)
            removedActivities.ForEach(f => ret.Remove(f));

        var retImgs = new List<string>();
        foreach (var item in ret)
        {
            item.Img1 = GetIcon(item.Img1);
            item.Img2 = GetIcon(item.Img2);
            item.Img3 = GetIcon(item.Img3);
            item.Img4 = GetIcon(item.Img4);

            retImgs = new List<string>();
            if (item.Imgs == null || !item.Imgs.Any())
                continue;
            foreach (var img in item.Imgs)
                retImgs.Add(GetIcon(img));


            item.Imgs = retImgs;
        }

        return ret;
    }

    /// <summary>
    /// 获取充值金额
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    public async Task<PayAmountConfigDto> GetPayAmounts(PayAmountConfigIpo ipo)
    {
        var ret = new PayAmountConfigDto();

        var globalUserDCache = await GlobalUserDCache.Create(ipo.UserId);
        ipo.OperatorId = await globalUserDCache.GetOperatorIdAsync();
        ipo.CurrencyId = await globalUserDCache.GetCurrencyIdAsync();
        ipo.CountryId = await globalUserDCache.GetCountryIdAsync();
        //获取用户是否充过值
        var userType = await globalUserDCache.GetHasPayAsync();

        //从缓存中获取支付成功率高的支付渠道,有可能为空
        var bankChannel = (int)(await LobbyUtil.GetPayChannel(ipo.OperatorId, ipo.CurrencyId, ipo.CountryId));

        var payConfigList = await new PayConfigDCache().GetAsync(ipo.OperatorId, ipo.CurrencyId);

        ret.Data = payConfigList.OrderBy(d => d.ChannelsGroup).GroupBy(d => d.ChannelsGroup).ToDictionary(d => d.Key, d => new ChannelsData());

        //可用充值金额
        var payAmountConfigList = await new PayAmountConfigDCache().GetAsync(ipo.OperatorId, ipo.CurrencyId, userType ? 1 : 0);

        var index = 0;

        //计算bonus
        List<long> payActivityAmountList = new();

        //获取PIX 1支付渠道
        foreach (var item in ret.Data)
        {
            var payConfigEo = payConfigList.Where(d => d.ChannelsGroup == item.Key).OrderByDescending(d => d.IsMainChannel).FirstOrDefault();

            //如果Global:BankError渠道名称异常，并且是PIX 1时
            if (bankChannel == 0 && index == 0)
                bankChannel = payConfigEo.Channels;

            var temp = payAmountConfigList.Where(d => d.Channels.Equals(index == 0 ? bankChannel.ToString() : payConfigEo.Channels.ToString())).ToList();

            item.Value.Channels = index == 0 ? bankChannel.ToEnum<BraPayChannel>().ToString() : payConfigEo.Channels.ToEnum<BraPayChannel>().ToString();

            item.Value.Channelimit = GetAmountLimit(payConfigEo, ipo);

            item.Value.Items = temp.OrderBy(d => d.OrderNum).Map<List<PayAmountConfigItem>>();

            payActivityAmountList.AddRange(temp.Select(d => d.PayAmount));

            index++;
        }

        //如果赠送bonus
        if (ipo.ReceiveBonus == 1)
        {
            payActivityAmountList = payActivityAmountList.Distinct().ToList();

            //计算100004需要赠送的bonus
            var payRewardResult = await new PayRewardService().GetPayRewardDetail(ipo.UserId, ipo.OperatorId, ipo.CurrencyId, payActivityAmountList);
            ret.frequency = payRewardResult.frequency;

            ret.maximum = payRewardResult.maximum.AToM(ipo.CurrencyId);

            foreach (var dataItem in ret.Data)
            {
                foreach (var item in dataItem.Value.Items)
                {
                    if (payRewardResult.rewards.TryGetValue(item.Amount.MToA(ipo.CurrencyId), out long bonus))
                    {
                        item.Bonus = bonus.AToM(ipo.CurrencyId);
                    }
                }
            }

            //如果100004不再赠送bonus，则计算100008赠送的bonus
            if (payRewardResult.frequency == 0)
            {
                //计算每日充值激励活动赠送bonus（活动100008）
                var userPay100008Ret = await new UserPay100008Service().GetPayRewardDetail(ipo.OperatorId, ipo.CurrencyId, payActivityAmountList);

                var isAddBonus = false;

                if (userPay100008Ret.DayNumLimit > 0)
                {
                    ret.PreferentialPayNumLimit = userPay100008Ret.DayNumLimit;
                    var localDate = DateTime.UtcNow.ToLocalTime(ipo.OperatorId).Date;
                    var activityCount = await new Sa_userpay100008_userMO().GetCountAsync("UserId = @UserId and DayId = @DayId", ipo.UserId, localDate);

                    if (activityCount < userPay100008Ret.DayNumLimit)
                        isAddBonus = true;
                }
                else
                    isAddBonus = true;

                if (isAddBonus)
                {
                    foreach (var dataItem in ret.Data)
                    {
                        foreach (var item in dataItem.Value.Items)
                        {
                            var item100008 = userPay100008Ret.Items.Where(d => d.PayAmount == item.Amount.MToA(ipo.CurrencyId)).FirstOrDefault();
                            if (item100008 != null)
                            {
                                item.Bonus += item100008.Bonus.AToM(ipo.CurrencyId);
                                item.Rate += item100008.Bonus > 0 ? (int)((decimal)item100008.Rate * 100) : 0;
                            }
                        }
                    }
                }
            }

        }

        foreach (var dataItem in ret.Data)
        {
            var isSelectedCount = dataItem.Value.Items.Where(d => d.IsSelected).Count();

            //如果没有设置默认选中，则默认选中最小充值金额
            if (isSelectedCount == 0)
            {
                foreach (var item in dataItem.Value.Items.OrderBy(d => d.OrderNum))
                {
                    item.IsSelected = true;
                    break;
                }
            }
            //如果存在多个金额选中，选中最大充值金额
            else if (isSelectedCount > 1)
            {
                var selectedAmount = 0M;
                foreach (var item in dataItem.Value.Items.OrderByDescending(d => d.OrderNum))
                {
                    if (selectedAmount > 0)
                    {
                        item.IsSelected = false;
                        continue;
                    }

                    if (item.IsSelected && selectedAmount == 0) selectedAmount = item.Amount;
                }
            }
        }

        var sOperator = DbCacheUtil.GetOperator(ipo.OperatorId);

        //计算优惠充值次数,这块需要在s_operator新增标识字段
        if (sOperator != null && sOperator.OperatorVersion == (int)OperatorVersionsEnum.longVersion)
        {
            ret.IsInputAmount = false;
            //获取活动配置
            var userPayConfig = LobbyDbCacheUtil.GetUserPay100008Config(ipo.OperatorId, ipo.CurrencyId);
            if (userPayConfig == null)
                throw new CustomException($"GetPayAmounts.sa_userpay100008_config不存在。operatoryId:{ipo.OperatorId},currencyId:{ipo.CurrencyId}");

            if (userPayConfig.DayNumLimit > 0)
            {
                ret.PreferentialPayNumLimit = userPayConfig.DayNumLimit;
                //用户当日参加此活动次数
                var localDate = DateTime.UtcNow.ToLocalTime(ipo.OperatorId).Date;
                var activityCount = await new Sa_userpay100008_userMO().GetCountAsync("UserId = @UserId and DayId = @DayId", ipo.UserId, localDate);
                if (activityCount < userPayConfig.DayNumLimit)
                    ret.PreferentialPayNumAllow = userPayConfig.DayNumLimit - (int)activityCount;
            }
        }

        return ret;
    }

    /// <summary>
    /// 获取加纳hubtel充值金额
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    public async Task<PayAmountConfigDto> GetHubtelPayAmounts(PayAmountConfigIpo ipo)
    {
        var ret = new PayAmountConfigDto();

        var globalUserDCache = await GlobalUserDCache.Create(ipo.UserId);
        ipo.OperatorId = await globalUserDCache.GetOperatorIdAsync();
        ipo.CurrencyId = await globalUserDCache.GetCurrencyIdAsync();
        ipo.CountryId = await globalUserDCache.GetCountryIdAsync();
        //获取用户是否充过值
        var userType = await globalUserDCache.GetHasPayAsync();

        //从缓存中获取支付成功率高的支付渠道,有可能为空
        var bankChannel = (int)BraPayChannel.hubtel;//(int)(await LobbyUtil.GetPayChannel(ipo.OperatorId, ipo.CurrencyId, ipo.CountryId));

        var payConfigList = await new PayConfigDCache().GetAsync(ipo.OperatorId, ipo.CurrencyId);

        ret.Data = payConfigList.OrderBy(d => d.ChannelsGroup).GroupBy(d => d.ChannelsGroup).ToDictionary(d => d.Key, d => new ChannelsData());

        //可用充值金额
        var payAmountConfigList = await new PayAmountConfigDCache().GetAsync(ipo.OperatorId, ipo.CurrencyId, userType ? 1 : 0);

        var index = 0;

        //计算bonus
        List<long> payActivityAmountList = new();

        //获取PIX 1支付渠道
        foreach (var item in ret.Data)
        {
            var payConfigEo = payConfigList.Where(d => d.ChannelsGroup == item.Key).OrderByDescending(d => d.IsMainChannel).FirstOrDefault();

            var temp = payAmountConfigList.Where(d => d.SubChannel.Equals(payConfigEo.SubChannel)).ToList();

            item.Value.Channels = payConfigEo.SubChannel;

            item.Value.Channelimit = GetAmountLimit(payConfigEo, ipo);

            item.Value.Items = temp.OrderBy(d => d.OrderNum).Map<List<PayAmountConfigItem>>();

            payActivityAmountList.AddRange(temp.Select(d => d.PayAmount));

            index++;
        }

        //如果赠送bonus
        if (ipo.ReceiveBonus == 1)
        {
            payActivityAmountList = payActivityAmountList.Distinct().ToList();

            //计算100004需要赠送的bonus
            var payRewardResult = await new PayRewardService().GetPayRewardDetail(ipo.UserId, ipo.OperatorId, ipo.CurrencyId, payActivityAmountList);
            ret.frequency = payRewardResult.frequency;

            ret.maximum = payRewardResult.maximum.AToM(ipo.CurrencyId);

            foreach (var dataItem in ret.Data)
            {
                foreach (var item in dataItem.Value.Items)
                {
                    if (payRewardResult.rewards.TryGetValue(item.Amount.MToA(ipo.CurrencyId), out long bonus))
                    {
                        item.Bonus = bonus.AToM(ipo.CurrencyId);
                    }
                }
            }

            //如果100004不再赠送bonus，则计算100008赠送的bonus
            if (payRewardResult.frequency == 0)
            {
                //计算每日充值激励活动赠送bonus（活动100008）
                var userPay100008Ret = await new UserPay100008Service().GetPayRewardDetail(ipo.OperatorId, ipo.CurrencyId, payActivityAmountList);

                var isAddBonus = false;

                if (userPay100008Ret.DayNumLimit > 0)
                {
                    ret.PreferentialPayNumLimit = userPay100008Ret.DayNumLimit;
                    var localDate = DateTime.UtcNow.ToLocalTime(ipo.OperatorId).Date;
                    var activityCount = await new Sa_userpay100008_userMO().GetCountAsync("UserId = @UserId and DayId = @DayId", ipo.UserId, localDate);

                    if (activityCount < userPay100008Ret.DayNumLimit)
                        isAddBonus = true;
                }
                else
                    isAddBonus = true;

                if (isAddBonus)
                {
                    foreach (var dataItem in ret.Data)
                    {
                        foreach (var item in dataItem.Value.Items)
                        {
                            var item100008 = userPay100008Ret.Items.Where(d => d.PayAmount == item.Amount.MToA(ipo.CurrencyId)).FirstOrDefault();
                            if (item100008 != null)
                            {
                                item.Bonus += item100008.Bonus.AToM(ipo.CurrencyId);
                                item.Rate += item100008.Bonus > 0 ? (int)((decimal)item100008.Rate * 100) : 0;
                            }
                        }
                    }
                }
            }

        }

        foreach (var dataItem in ret.Data)
        {
            var isSelectedCount = dataItem.Value.Items.Where(d => d.IsSelected).Count();

            //如果没有设置默认选中，则默认选中最小充值金额
            if (isSelectedCount == 0)
            {
                foreach (var item in dataItem.Value.Items.OrderBy(d => d.OrderNum))
                {
                    item.IsSelected = true;
                    break;
                }
            }
            //如果存在多个金额选中，选中最大充值金额
            else if (isSelectedCount > 1)
            {
                var selectedAmount = 0M;
                foreach (var item in dataItem.Value.Items.OrderByDescending(d => d.OrderNum))
                {
                    if (selectedAmount > 0)
                    {
                        item.IsSelected = false;
                        continue;
                    }

                    if (item.IsSelected && selectedAmount == 0) selectedAmount = item.Amount;
                }
            }
        }

        var sOperator = DbCacheUtil.GetOperator(ipo.OperatorId);

        //计算优惠充值次数,这块需要在s_operator新增标识字段
        if (sOperator != null && sOperator.OperatorVersion == (int)OperatorVersionsEnum.longVersion)
        {
            ret.IsInputAmount = false;
            //获取活动配置
            var userPayConfig = LobbyDbCacheUtil.GetUserPay100008Config(ipo.OperatorId, ipo.CurrencyId);
            if (userPayConfig == null)
                throw new CustomException($"GetPayAmounts.sa_userpay100008_config不存在。operatoryId:{ipo.OperatorId},currencyId:{ipo.CurrencyId}");

            if (userPayConfig.DayNumLimit > 0)
            {
                ret.PreferentialPayNumLimit = userPayConfig.DayNumLimit;
                //用户当日参加此活动次数
                var localDate = DateTime.UtcNow.ToLocalTime(ipo.OperatorId).Date;
                var activityCount = await new Sa_userpay100008_userMO().GetCountAsync("UserId = @UserId and DayId = @DayId", ipo.UserId, localDate);
                if (activityCount < userPayConfig.DayNumLimit)
                    ret.PreferentialPayNumAllow = userPayConfig.DayNumLimit - (int)activityCount;
            }
        }

        return ret;
    }

    /// <summary>
    /// 获取当前充值金额需要赠送的bonus
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    public async Task<decimal> GetPayBonus(PayAmountConfigIpo ipo)
    {
        var ret = 0M;

        if (ipo.ReceiveBonus == 0)
            return ret;

        var globalUserDCache = await GlobalUserDCache.Create(ipo.UserId);
        ipo.OperatorId = await globalUserDCache.GetOperatorIdAsync();
        ipo.CountryId = await globalUserDCache.GetCountryIdAsync();
        ipo.CurrencyId = await globalUserDCache.GetCurrencyIdAsync();

        //墨西哥充值金额只能是正整数
        if (ipo.CountryId.Equals("MEX") && !StringUtil.IsPositiveInteger(ipo.Amount.ToString()))
        {
            throw new CustomException(LobbyCodes.RS_PARAMETER_ERROR, "param error.The recharge amount must be a positive integer");
        }

        //充值最小、最大限制
        var payConfigfield = PayConfigDCache.GetField(ipo.OperatorId, ipo.CurrencyId);
        var payconfigDCache = await new PayConfigDCache().GetOrLoadAsync(payConfigfield);
        if (payconfigDCache.HasValue)
        {
            var payConfig = payconfigDCache.Value.FirstOrDefault();

            if (payConfig != null)
            {
                if (
                    ipo.Amount < payConfig.MinAmount.AToM(ipo.CurrencyId)
                    || ipo.Amount > payConfig.MaxAmount.AToM(ipo.CurrencyId)
                    )
                    throw new CustomException(LobbyCodes.RS_PARAMETER_ERROR, "param error.Recharge amount is less than the minimum amount or greater than the maximum amount.");
            }
        }


        var payAmountList = new List<long>() { ipo.Amount.MToA(ipo.CurrencyId) };

        //计算充值送bonus活动赠送bonus（活动100004）
        var payRewardResult = await new PayRewardService().GetPayRewardDetail(ipo.UserId, ipo.OperatorId, ipo.CurrencyId, payAmountList);

        if (payRewardResult.rewards.TryGetValue(ipo.Amount.MToA(ipo.CurrencyId), out long bonus100004))
            ret = bonus100004.AToM(ipo.CurrencyId);

        if (payRewardResult.frequency == 0)
        {
            //计算100008活动赠送bonus（活动100008）
            var userPay100008Ret = await new UserPay100008Service().GetPayRewardDetail(ipo.OperatorId, ipo.CurrencyId, payAmountList);

            var isAddBonus = false;

            if (userPay100008Ret.DayNumLimit > 0)
            {
                var localDate = DateTime.UtcNow.ToLocalTime(ipo.OperatorId).Date;
                var activityCount = await DbUtil.GetRepository<Sa_userpay100008_userPO>()
                    .AsQueryable()
                    .Where(d => d.UserID.Equals(ipo.UserId) && d.DayId == localDate)
                    .CountAsync();

                if (activityCount < userPay100008Ret.DayNumLimit)
                    isAddBonus = true;
            }
            else
                isAddBonus = true;

            if (isAddBonus)
            {
                var item100008 = userPay100008Ret.Items.Where(d => d.PayAmount == ipo.Amount.MToA(ipo.CurrencyId)).FirstOrDefault();
                if (item100008 != null)
                    ret += item100008.Bonus.AToM(ipo.CurrencyId);
            }
            else
            {
                ret = 0;
            }
        }

        return ret;
    }

    #region ===PGTADA===      

    /// <summary>
    /// 获取充值配置最大最小值
    /// </summary>
    /// <param name="payConfig"></param>
    /// <param name="ipo"></param>
    /// <returns></returns>
    public AmountLimit GetAmountLimit(L_pay_configPO payConfig, PayAmountConfigIpo ipo)
    {
        var amountLimit = new AmountLimit()
        {
            MinAmount = payConfig.MinAmount.AToM(ipo.CurrencyId),
            MaxAmount = payConfig.MaxAmount.AToM(ipo.CurrencyId)
        };
        return amountLimit;
    }

    /// <summary>
    /// 标签列表
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    public async Task<List<TagListDto>> TagList(TagListIpo ipo)
    {
        var cache = await new TagDCache(ipo.OperatorId, ipo.LangId).GetAsync();
        if (!cache.HasValue) return new List<TagListDto>();

        var ret = cache.Value.Where(_ => _.LevelNum == ipo.LevelNum)
            .OrderBy(_ => _.LevelOrderNum)
            .Map<List<TagListDto>>();

        ret.ForEach(_ =>
        {
            _.HasIcon = !string.IsNullOrWhiteSpace(_.Icon);
            _.SelectIcon = GetIcon(_.SelectIcon);
            _.Icon = GetIcon(_.Icon);
        });

        return ret;
    }

    /// <summary>
    /// 首页标签游戏详情
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    public async Task<List<TagDetailDto>> TagDetail(TagDetailIpo ipo)
    {
        var ret = await new TagDetailDCache(ipo.OperatorId, ipo.LangId, ipo.TagCode).GetAsync();

        if (!ret.HasValue) return new List<TagDetailDto>();

        foreach (var item in ret.Value)
        {
            foreach (var app in item.Apps)
            {
                BuildAppDetailDto(app, ipo.OperatorId, ipo.LangId, null);
            }
            item.Apps = item.Apps.Where(d => d.Status > 0).OrderBy(_ => _.AppSequence).ToList();
            item.Icon = GetIcon(item.Icon);
        }
        return ret.Value;
    }

    /// <summary>
    /// 分页查询标签下游戏详情
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    public async Task<TagDetailByPageDto> GetTagDetailByPage(TagDetailByPageIpo ipo)
    {
        var result = new TagDetailByPageDto();

        var ret = await new TagDetailDCache(ipo.OperatorId, ipo.LangId, ipo.TagCode).GetAsync();

        if (!ret.HasValue) return result;

        foreach (var item in ret.Value)
        {
            result.TotalNum = item.Apps.Count;
            result.Apps = item.Apps.OrderBy(_ => _.AppSequence)
                .Skip((ipo.PageIndex - 1) * ipo.PageSize)
                .Take(ipo.PageSize).ToList();

            foreach (var app in result.Apps)
            {
                BuildAppDetailDto(app, ipo.OperatorId, ipo.LangId, null);
            }
            item.Apps = item.Apps.Where(d => d.Status > 0).OrderBy(_ => _.AppSequence).ToList();
            item.Icon = GetIcon(item.Icon);
        }
        return result;
    }

    /// <summary>
    /// 搜索游戏列表
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    public async Task<List<AppDetailDto>> QueryByKeyword(QueryByKeywordIpo ipo)
    {
        var retList = await new KeyWordDCache(ipo.OperatorId, ipo.LangId, ipo.Keyword).GetAsync();

        if (!retList.HasValue) return new List<AppDetailDto>();

        var ret = new List<AppDetailDto>();
        foreach (var item in retList.Value)
        {
            try
            {
                BuildAppDetailDto(item, ipo.OperatorId, ipo.LangId, null);
                ret.Add(item);
            }
            catch (Exception ex)
            {
                LogUtil.GetContextLogger()
               .AddException(ex)
               .AddMessage("lobby_HomeService_QueryByKeyword")
               .AddField("errorMessage", ex.Message);
            }
        }
        return ret;
    }

    #endregion

    private static string GetIcon(string icon)
    {
        if (string.IsNullOrWhiteSpace(icon))
            return string.Empty;

        if (icon.StartsWith("http"))
            return icon;
        return _imageBaseUrl + icon;
    }
}
