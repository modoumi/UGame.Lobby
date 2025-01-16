using EasyNetQ;
using Google.Protobuf.WellKnownTypes;
using UGame.Lobby.Service.Caching.Home;
using UGame.Lobby.Repository.ing;
using Newtonsoft.Json;
using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UGame.Lobby.Common.Enum;
using AiUo;
using AiUo.AspNet;
using AiUo.Configuration;
using AiUo.Data;
using AiUo.Extensions.AutoMapper;
using AiUo.Extensions.RabbitMQ;
using AiUo.Logging;
using AiUo.Text;
using UGame.Lobby.Service.Caching;
using UGame.Lobby.Service.Caching.Activity.Regpay;
using UGame.Lobby.Service.Common;
using UGame.Lobby.Service.Services.Home;
using Xxyy.Common;
using Xxyy.Common.Caching;
using Xxyy.Common.Services;
using Xxyy.DAL;

namespace UGame.Lobby.Service.Services.Activity.Regpay
{
    public class RegpayLobbyService
    {
        private Sa_regpay_userMO _regpayUserMo = new();

        private Sa_regpay_detailMO _regpayDetailMo = new();

        private S_currency_changeMO _currencyChangeMo = new();

        private RegpayConfigDCahce _regpayConfigDCache = new();

        private RegpayUserDCache _regpayUserDCache;

        private static string _imageBaseUrl;

        private LobbyOptionsSection _options;

        public RegpayLobbyService()
        {
            _options = ConfigUtil.GetSection<LobbyOptionsSection>();
            _imageBaseUrl = _options.ImageBaseUrl;
        }


        /// <summary>
        /// 新增注册、首充用户基础数据
        /// </summary>
        /// <param name="eo"></param>
        /// <returns></returns>
        public async Task<bool> AddRegUser(Sa_regpay_userEO eo)
        {
            return await _regpayUserMo.AddAsync(eo) > 0;
        }

        /// <summary>
        /// 获取注册、首充用户基础数据
        /// </summary>
        /// <returns></returns>
        public async Task<RegpayUserDto> RegpayUser(RegpayUserIpo ipo)
        {
            _regpayUserDCache = new RegpayUserDCache(ipo.OperatorId, ipo.UserId);
            var dCacheData = await _regpayUserDCache.GetOrLoadAsync();
            if (!dCacheData.HasValue)
                throw new CustomException($"RegpayUser:The userId({ipo.UserId}) data do not exist");
            var ret = dCacheData.Value.Map<RegpayUserDto>();

            var regpayConfigField = RegpayConfigDCahce.GetField(ipo.OperatorId, ipo.CurrencyId);
            var regpayConfigDCahce = new RegpayConfigDCahce();
            var regpayConfig = await regpayConfigDCahce.GetOrLoadAsync(regpayConfigField);
            if (!regpayConfig.HasValue)
                throw new CustomException($"RegpayUser:config do not exist.");

            ret.BetAmount = Math.Round(regpayConfig.Value.BetAmount.AToM(regpayConfig.Value.CurrencyID), 2, MidpointRounding.ToZero);

            return ret;
        }

        /// <summary>
        /// 获取注册、首充用户奖励记录
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        public async Task<List<RegpayDetailsDto>> RegpayDetails(RegpayDetailsIpo ipo)
        {
            var mo = new Sa_regpay_detailMO();

            var dbData = await mo.GetTopSortAsync("OperatorId = @OperatorId", 10, "RecDate desc", null, ipo.OperatorId);

            if (dbData == null || !dbData.Any())
                return new List<RegpayDetailsDto>();

            var ret = dbData.Map<List<RegpayDetailsDto>>();

            foreach (var item in ret)
            {
                GlobalUserDCacheEx globalUserDCacheEx = GlobalUserDCacheEx.Create(ipo.UserId, ipo.CurrencyId);

                var mobile = await globalUserDCacheEx.GetMobile();

                if (!string.IsNullOrWhiteSpace(mobile))
                    item.Mobile = mobile.HideFixedLength(mobile.Length, 3, 3, '*');

                var userName = await globalUserDCacheEx.GetUsername();

                if (!string.IsNullOrWhiteSpace(userName))
                    item.UserName = userName.HideFixedLength(userName.Length, 3, 3, '*');
            }

            return ret;
        }

        /// <summary>
        /// 领取注册、首充送的奖金
        /// </summary>
        /// <returns></returns>
        public async Task<RegpayReceiveBonusDto> RegpayReceiveBonus(RegpayReceiveBonusIpo ipo)
        {
            var ret = new RegpayReceiveBonusDto();

            var regpayConfigField = RegpayConfigDCahce.GetField(ipo.OperatorId, ipo.CurrencyId);

            var regpayConfig = (await _regpayConfigDCache.GetOrLoadAsync(regpayConfigField)).Value;

            TransactionManager tm = new TransactionManager();

            List<bool> resultList = new List<bool>();

            try
            {
                //获取s_user
                UserService commonUserService = new UserService(ipo.UserId);
                CurrencyChangeService currencyChangeService = new CurrencyChangeService(ipo.UserId);
                var userEo = await commonUserService.GetUserMo().GetByPKAsync(ipo.UserId);
                //1、先判断当前用户是否有可领取奖金（读库）
                var regpayUser = await _regpayUserMo.GetSingleAsync("UserID = @UserID", tm, ipo.UserId);

                if (regpayUser.ReturnRewards <= 0)
                {
                    throw new CustomException("No bonus available.");
                }

                var bonus = regpayUser.ReturnRewards;

                //2、一次性扣除扣除sa_regpay_user.SumPay
                resultList.Add(await _regpayUserMo.PutReturnRewardsByPKAsync(ipo.UserId, (long)0, tm) > 0);

                //3、写入注册、首充领奖记录sa_regpay_detail
                Sa_regpay_detailEO regpayDetails = new Sa_regpay_detailEO()
                {
                    DetailID = ObjectId.NewId(),
                    UserID = ipo.UserId,
                    OperatorID = ipo.OperatorId,
                    CountryId = ipo.CountryId,
                    CurrencyID = ipo.CurrencyId,
                    RewardAmount = bonus,
                    RecDate = DateTime.UtcNow
                };
                resultList.Add(await _regpayDetailMo.AddAsync(regpayDetails, tm) > 0);

                #region 原先逻辑
                //4、写入S_currency_change用户奖励变化表
                //S_currency_changeEO currencyChange = new S_currency_changeEO()
                //{
                //    ChangeID = ObjectId.NewId(),
                //    OperatorID = ipo.OperatorId,
                //    UserID = ipo.UserId,
                //    UserKind = userEo.UserKind,
                //    CurrencyID = ipo.CurrencyId,
                //    Reason = "注册、首充累计下注值发放奖励",
                //    PlanAmount = bonus,
                //    SourceTable = "sa_regpay_detail",
                //    SourceId = "DetailID",
                //    Status = 2,
                //    RecDate = DateTime.UtcNow,
                //    DealTime = DateTime.UtcNow,
                //    Amount = bonus,
                //    EndBalance = userEo.Cash + bonus
                //};

                //resultList.Add(await _currencyChangeMo.AddAsync(currencyChange, tm) > 0);

                //5、更新账户余额
                //resultList.Add(await commonUserService.UpdateBalance(ipo.CurrencyId, bonus, tm));
                #endregion

                //4.写入S_currency_change用户奖励变化表及更新账户余额
                var currencyChangeReq = new CurrencyChangeReq()
                {
                    UserId = ipo.UserId,
                    AppId = ipo.AppId,
                    OperatorId = ipo.OperatorId,
                    CurrencyId = ipo.CurrencyId,
                    //IsBonus = true,
                    ChangeBalance = CurrencyChangeBalance.Bonus,
                    FlowMultip = 1,//1倍流水
                    Reason = "注册、首充累计下注值发放奖励",
                    Amount = bonus,
                    SourceType = (int)ActivityType.RegPay,
                    SourceTable = "sa_regpay_detail",
                    SourceId = regpayDetails.DetailID,
                    ChangeTime = DateTime.UtcNow,
                    TM = tm
                };
                var changeMsg = await currencyChangeService.Add(currencyChangeReq);

                //5、清除累计下注值
                regpayUser = await _regpayUserMo.GetSingleAsync("UserID = @UserID", tm, ipo.UserId);
                if (regpayUser.SumPay == 0 && regpayUser.ReturnRewards == 0)
                    resultList.Add(await _regpayUserMo.PutAsync("SumBet = 0", "UserID = @UserID", tm, ipo.UserId) > 0);

                if (resultList.Any(d => !d))
                    throw new CustomException(LobbyCodes.RS_UNKNOWN, "Failed to distribute bonus.");
                
                tm.Commit();
                if (changeMsg != null)
                    await MQUtil.PublishAsync(changeMsg);

                RegpayUserDCache regpayUserDCache = new RegpayUserDCache(userEo.OperatorID, userEo.UserID);
                await regpayUserDCache.GetOrLoadAsync(true, TimeSpan.FromMinutes(5));

                ret.success = true;
            }
            catch (Exception ex)
            {
                tm.Rollback();

                if (ex is not CustomException)
                {
                    LogUtil.GetContextLogger().AddException(ex).AddMessage($"lobby:ReceiveBonus,发放奖励失败,ipo:{JsonConvert.SerializeObject(ipo)}");
                }

                return new RegpayReceiveBonusDto() { success = false, message = ex.Message };
            }

            return ret;
        }

        /// <summary>
        /// 注册、首充推荐游戏
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        public async Task<List<CategoryMoreDto>> RegpayGames(RegpayGamesIpo ipo)
        {
            var field = RegpayGamesDCache.GetField(ipo.OperatorId, ipo.LangId);
            RegpayGamesDCache regpayGamesDCache = new RegpayGamesDCache();

            var cacheData = await regpayGamesDCache.GetOrLoadAsync(field);

            if (!cacheData.HasValue)
                return new List<CategoryMoreDto>();

            var ret = cacheData.Value;

            var favorites = await GlobalUserDCacheEx.Create(ipo.UserId).GetFavoriteAppIds();
            foreach (var app in ret)
            {
                var appLang = DbCacheUtil.GetAppLang(app.AppId, ipo.LangId);
                app.AppName = appLang.AppName;
                app.IsFavorite = favorites.Contains(app.AppId);
                var sAppEo = DbCacheUtil.GetApp(app.AppId);
                app.SmallIcon = GetIcon(app.SmallIcon);
                app.MiddleIcon = GetIcon(app.MiddleIcon);
                app.BigIcon = GetIcon(app.BigIcon);
            }

            return ret;
        }

        private string GetIcon(string icon)
        {
            if (icon.StartsWith("http"))
                return icon;
            return _imageBaseUrl + icon;
        }
    }
}
