using Elasticsearch.Net.Specification.DanglingIndicesApi;
using Google.Protobuf.WellKnownTypes;
using UGame.Lobby.Service.Caching.Activity;
using UGame.Lobby.Service.Services.Init;
using UGame.Lobby.Common.Enum;
using UGame.Lobby.Repository.ing;
using System.ComponentModel;
using System.Reflection;
using AiUo;
using AiUo.Caching;
using AiUo.Collections;
using AiUo.Configuration;
using AiUo.Data;
using AiUo.Extensions.AutoMapper;
using AiUo.Logging;
using UGame.Lobby.Service.Caching;
using UGame.Lobby.Service.Caching.Notify;
using UGame.Lobby.Service.Caching.SCommon;
using UGame.Lobby.Service.Common;
using UGame.Lobby.Service.Services.Activity.WeeklyCard;
using UGame.Lobby.Service.Services.SCommon.Marquee;
using Xxyy.Common;
using Xxyy.Common.Caching;
using Xxyy.DAL;
//using Xxyy.DAL;

namespace UGame.Lobby.Service.Services.SCommon
{
    /// <summary>
    /// SCommonService
    /// </summary>
    public class SCommonService
    {
        private static string _imageBaseUrl;

        private LobbyOptionsSection _options;

        /// <summary>
        /// SCommonService
        /// </summary>
        public SCommonService()
        {
            _options = ConfigUtil.GetSection<LobbyOptionsSection>();
            _imageBaseUrl = _options.ImageBaseUrl;
        }

        /// <summary>
        /// Banner
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        public async Task<Dictionary<int, List<SCBannerDto>>> Banner(SCBannerIpo ipo)
        {
            var result = new Dictionary<int, List<SCBannerDto>>();

            var globalUserDCache = await GlobalUserDCache.Create(ipo.UserId);

            var userMode = await globalUserDCache.GetUserModeAsync();
            ipo.OperatorId = await globalUserDCache.GetOperatorIdAsync();
            ipo.CurrencyId = await globalUserDCache.GetCurrencyIdAsync();

            var bannerType = userMode == UserMode.Visitor ? 1 : 2;

            var weeklyCard = await new WeeklyCardService().GetWeeklyCardShow(ipo.UserId);

            foreach (var item in ipo.Position)
            {
                var cahce = new SCBannerDCache(bannerType, ipo.AppId, ipo.OperatorId, ipo.LangId, item);
                var ret = await cahce.GetAsync();

                if (ret.HasValue && ret.Value != null && ret.Value.Any())
                {
                    foreach (var retItem in ret.Value)
                    {
                        retItem.ImageUrl = LobbyUtil.GetIcon(retItem.ImageUrl);
                    }

                    switch (item)
                    {
                        case (int)BannerPosition.Pay:
                            ret.Value = await PayBanner(ret.Value, ipo);
                            break;
                        default: break;
                    }

                    result.Add(item, ret.Value);
                }
            }
            return result;
        }

        /// <summary>
        /// 充值页banner
        /// </summary>
        /// <param name="bannerDtoList"></param>
        /// <param name="ipo"></param>
        /// <returns></returns>
        private async Task<List<SCBannerDto>> PayBanner(List<SCBannerDto> bannerDtoList, SCBannerIpo ipo)
        {
            //获取l_activity_operator
            var operatorActivityEoList = await LobbyUtil.GetOperatorActivity(ipo.OperatorId, ipo.CurrencyId, false);
            var ret = new List<SCBannerDto>();
            var userActivityEoList = await new L_user_activityMO().GetAsync("UserId = @UserId", ipo.UserId);
            foreach (var item in bannerDtoList)
            {
                if (operatorActivityEoList.Any(d => d.Status && d.ActivityID == item.Code))
                {
                    //当前活动已完成
                    if (userActivityEoList.Any(d => d.ActivityId == item.Code && d.IsEnd))
                        continue;
                    
                    //如果l_user_activity不包含此活动
                    //或包含此活动并且当前活动未完成时
                    if (!userActivityEoList.Any(d => d.ActivityId == item.Code)
                        || userActivityEoList.Any(d => d.ActivityId == item.Code && !d.IsEnd))
                    {
                        ret.Add(item);
                        break;
                    }
                }
            }

            return ret;
        }


        /// <summary>
        /// Marquee
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        public async Task<List<SCMarqueeDto>> Marquee(SCMarqueeIpo ipo)
        {
            SCMarqueeService marqueeService = new();
            var _marqueeDcache = new SCMarqueeDCache(ipo.OperatorId, ipo.LangId, ipo.MarqueeType);
            var retList = (await _marqueeDcache.GetAllOrLoadAsync()).Value.ToList();
            var marqueeConfig = LobbyDbCacheUtil.GetMarqueeConfig(ipo.OperatorId);
            var requireCount = marqueeConfig.TextMaxNumber;
            var excludeAppIds = new List<string>();

            if (ipo.MarqueeType == 1)
            {
                var picMarqueeApps = await marqueeService.GetMarqueePicApps(ipo.OperatorId);
                requireCount = picMarqueeApps.Count;
                excludeAppIds = retList.Select(r => r.AppId).ToList();//图片轮播时，排除已存在于缓存的游戏
            }
            if (retList.Count < requireCount)
            {
                var templateLang = await marqueeService.GetTemplateLang(ipo.MarqueeType, ipo.LangId);
                if (templateLang != null)
                {
                    var appendList = await marqueeService.GenerateFakeMarqueeDto(templateLang, ipo.OperatorId, requireCount - retList.Count, ipo.MarqueeType, excludeAppIds);
                    retList.AddRange(appendList);
                    foreach (var appendItem in appendList)
                    {
                        await _marqueeDcache.UpdateCache(appendItem);
                    }
                }
            }

            return retList;
        }

        public async Task<List<SCNotifyDto>> Notify(SCNotifyIpo ipo)
        {
            var ret = new List<SCNotifyDto>();

            //获取当前用户需要收到的通知
            var notifyUsersDCache = new SCNotifyUsersDCache(ipo.UserId, ipo.AppId, ipo.ActionAt, ipo.ShowAt, ipo.OperatorId);
            var notifyUsersDCacheData = await notifyUsersDCache.GetAllOrLoadAsync();
            var deleteFieldList = new List<string>();

            if (!notifyUsersDCacheData.HasValue)
                return ret;

            notifyUsersDCacheData.Value = notifyUsersDCacheData.Value.OrderByDescending(d => d.Key).ToDictionary(d => d.Key, d => d.Value);

            //当前用户已经收到的通知记录
            var notifyUserLogsDCache = new SCNotifyUserLogsDCache(ipo.UserId);
            var notifyUserLogsDCacheData = await notifyUserLogsDCache.GetAllOrLoadAsync();

            if (!notifyUserLogsDCacheData.HasValue)
                notifyUserLogsDCacheData.Value = new Dictionary<string, Sc_notify_user_logEO>();

            var utcTime = DateTime.UtcNow;
            var notifyUserLogMo = new Sc_notify_user_logMO();
            var notifyMo = new Sc_notifyMO();

            Sc_notify_user_logEO insertNotifyUserLogEo = null;
            var insertNotifyUserLogEoList = new List<Sc_notify_user_logEO>();

            //需要返回给前端的通知
            var retEntity = new List<Sc_notifyEO>();
            var limit = 5;

            TransactionManager tm = new TransactionManager();
            try
            {
                foreach (var item in notifyUsersDCacheData.Value)
                {
                    if (retEntity.Count >= limit)
                        break;

                    if (!notifyUserLogsDCacheData.Value.TryGetValue($"{ipo.UserId}|{item.Key}", out Sc_notify_user_logEO logItem))
                    {
                        logItem = new Sc_notify_user_logEO
                        {
                            NotifyID = item.Key,
                            UserID = ipo.UserId,
                            ShowCount = 1,
                            LastShowDate = utcTime
                        };
                    }
                    else
                        continue;

                    //写库
                    insertNotifyUserLogEo = new Sc_notify_user_logEO
                    {
                        NotifyID = item.Key,
                        UserID = ipo.UserId,
                        ShowCount = logItem.ShowCount,
                        LastShowDate = utcTime
                    };
                    await notifyUserLogMo.AddAsync(insertNotifyUserLogEo, tm);
                    insertNotifyUserLogEoList.Add(insertNotifyUserLogEo);

                    if (item.Value.NotifyUsersCount <= logItem.ShowCount)
                    {
                        await notifyMo.PutNotifyedUsersCountByPKAsync(item.Key, item.Value.NotifyUsersCount, tm);
                        await notifyMo.PutAsync("Status = 0", "NotifyID = @NotifyID and UserScope = 1 and NotifyUsersCount <= NotifyedUsersCount", tm, item.Key);
                        deleteFieldList.Add(item.Key);
                    }

                    retEntity.Add(item.Value);
                }

                tm.Commit();

                //更新NotifyUserLogsDCache
                foreach (var item in insertNotifyUserLogEoList)
                    await notifyUserLogsDCache.SetAsync($"{item.UserID}|{item.NotifyID}", item);
                
                //更新SCNotifyUsersDCache
                foreach (var item in deleteFieldList)
                    await notifyUsersDCache.DeleteAsync(item);

                ret = await BuildNotifyDto(retEntity, ipo.LangId);
            }
            catch (Exception ex)
            {
                tm.Rollback();
                if (ex is not CustomException)
                {
                    LogUtil.GetContextLogger().AddException(ex).AddMessage($"Notify.");
                }
                return ret;
            }

            return ret;
        }

        private async Task<List<SCNotifyDto>> BuildNotifyDto(List<Sc_notifyEO> list,string langId)
        {
            var notifyIds = string.Join("','", list.Select(d => d.NotifyID).ToList());
            var notifyDetailEoList = await new Sc_notify_detailMO().GetAsync($"LangId = @LangId and NotifyID in('{notifyIds}')", langId);


            Sc_notify_detailEO notifyDetail = null;
            var ret = new List<SCNotifyDto>();
            foreach (var item in list)
            {
                notifyDetail = notifyDetailEoList.Where(d => d.NotifyID.Equals(item.NotifyID)).FirstOrDefault();
                if (notifyDetail != null)
                {
                    ret.Add(new SCNotifyDto()
                    {
                        NotifyId = item.NotifyID,
                        Position = item.Position,
                        CloseInterval = item.CloseInterval,
                        LinkKind = notifyDetail.LinkKind,
                        LinkUrl = notifyDetail.LinkUrl,
                        Title = notifyDetail.Title,
                        Content = notifyDetail.Content,
                        ImageUrl = notifyDetail.ImageUrl
                    });
                }
            }

            return ret;
        }


        /// <summary>
        /// Notify
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        //public async Task<List<SCNotifyDto>> Notify(SCNotifyIpo ipo)
        //{
        //    var ret = new List<SCNotifyDto>();

        //    var listDCache = new SCNotifyDCache(ipo.AppId, ipo.ActionAt, ipo.ShowAt, ipo.OperatorId, ipo.LangId);
        //    var list = await listDCache.GetAsync();

        //    if (list.HasValue)
        //    {
        //        TransactionManager tm = new TransactionManager();

        //        try
        //        {
        //            //当前用户已经收到的通知记录
        //            var notifyUserLogsDCache = new NotifyUserLogsDCache(ipo.UserId);
        //            var notifyUserLogs = await notifyUserLogsDCache.GetAsync();

        //            //所有当前用户需要收到的通知
        //            var notifyUsers = await new NotifyUserDCache(ipo.UserId).GetAsync();

        //            var mo = new Sc_notify_user_logMO();
        //            var timeNow = DateTime.UtcNow;
        //            foreach (var item in list.Value)
        //            {
        //                //如果notify通知指定用户，且不包含当前用户，则跳过
        //                if (item.UserScope == 1 && !notifyUsers.Any(d => d.NotifyID.Equals(item.NotifyID)))
        //                    continue;

        //                var logItem = notifyUserLogs.Where(d => d.NotifyID.Equals(item.NotifyID)).FirstOrDefault();

        //                if (logItem == null)
        //                {
        //                    logItem = new Sc_notify_user_logEO
        //                    {
        //                        NotifyID = item.NotifyID,
        //                        UserID = ipo.UserId,
        //                        ShowCount = 1,
        //                        LastShowDate = timeNow
        //                    };
        //                    item.NotifyedUsersCount = 1;
        //                }
        //                else
        //                {
        //                    logItem.ShowCount += 1;
        //                    item.NotifyedUsersCount += 1;
        //                }

        //                if (logItem.ShowCount > item.ShowTimes
        //                    || ((timeNow - logItem.LastShowDate).TotalMinutes < item.ShowInterval && logItem.ShowCount > 1))
        //                    continue;

        //                logItem.LastShowDate = timeNow;

        //                //写库
        //                var scNotifyUserLogEo = new Sc_notify_user_logEO
        //                {
        //                    NotifyID = item.NotifyID,
        //                    UserID = ipo.UserId,
        //                    ShowCount = logItem.ShowCount,
        //                    LastShowDate = timeNow
        //                };
        //                await mo.AddAsync(scNotifyUserLogEo, tm, useIgnore_: true);


        //                ret.Add(item.Map<SCNotifyDto>());

        //                //更新当前用户已经收到的通知记录
        //                notifyUserLogs.Add(scNotifyUserLogEo);
        //                await notifyUserLogsDCache.SetAsync(notifyUserLogs);
        //            }

        //            var notifyMo = new Sc_notifyMO();
        //            //更新通知状态
        //            foreach (var item in ret)
        //            {
        //                await notifyMo.PutNotifyedUsersCountByPKAsync(item.NotifyId, item.NotifyedUsersCount + 1, tm);
        //                await notifyMo.PutAsync("Status = 0", "NotifyID = @NotifyID and UserScope = 1 and NotifyUsersCount <= NotifyedUsersCount", tm, item.NotifyId);
        //             }

        //            tm.Commit();

        //            //更新缓存
        //            foreach (var item in ret)
        //            {
        //                if (item.IsUpdateCache && list.Value.Any(d => d.NotifyID.Equals(item.NotifyId)))
        //                {
        //                    list.Value.Remove(list.Value.Where(d => d.NotifyID.Equals(item.NotifyId)).FirstOrDefault());
        //                }
        //            }

        //            if (ret.Any(d => d.IsUpdateCache))
        //            {
        //                await listDCache.SetAsync(list.Value);
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            tm.Rollback();
        //            if (ex is not CustomException)
        //                LogUtil.Error($"Notify.error:{ex.Message}");
        //            return new List<SCNotifyDto>();
        //        }
        //    }

        //    return ret;
        //}

        private string GetImg(string icon)
        {
            if (icon.StartsWith("http"))
                return icon;
            return _imageBaseUrl + icon;
        }
    }
}
