using UGame.Lobby.Repository.ing;
using System.Collections.Concurrent;
using AiUo.Data.SqlSugar;
using Xxyy.Common;
using Xxyy.Common.Caching;

namespace UGame.Lobby.Service.Caching;

public class GlobalUserDCacheEx
{
    private string _userId;
    private GlobalUserDCache _dcache;
    private static ConcurrentDictionary<string, GlobalUserDCacheEx> _cache = new();
    public static GlobalUserDCacheEx Create(string userId, string currencyID = null)
    {
        return _cache.GetOrAdd(userId, new GlobalUserDCacheEx(userId, currencyID));
    }

    private GlobalUserDCacheEx(string userId, string currencyId)
    {
        _userId = userId;
        _dcache = new GlobalUserDCache(userId);
    }

    private const string Key_LoginDays = "LoginDays"; //连续登录天数
    public async Task<int> GetLoginDays() => await _dcache.GetOrDefaultAsync(Key_LoginDays, 0);

    #region FavoriteAppIds
    /// <summary>
    /// 用户收藏的appIds
    /// </summary>
    private const string Key_FavoriteAppIds = "Lobby_FavoriteAppIds";
    public async Task<HashSet<string>> GetFavoriteAppIds()
    {
        var ret = await _dcache.GetOrDefaultAsync<HashSet<string>>(Key_FavoriteAppIds, null);
        if (ret == null)
        {
            ret = new HashSet<string>();
            var items = DbUtil.GetRepository<L_user_favoritePO>().AsQueryable()
                .Where(d => d.UserID.Equals(_userId) && d.Type == 2)
                .ToList();
            foreach (var item in items)
                ret.Add(item.AppID);
            await _dcache.SetAsync(Key_FavoriteAppIds, ret, TimeSpan.FromMinutes(5));
        }
        return ret;
    }
    public Task SetFavoriteAppIds(HashSet<string> value)
    {
        return _dcache.SetAsync(Key_FavoriteAppIds, value);
    }
    #endregion

    #region l_user_info是否存在用户

    private const string Key_HasLUserInfo = "Lobby_HasLUserInfo";
    public async Task<bool> GetHasLUserInfo() => await _dcache.GetOrDefaultAsync(Key_HasLUserInfo, false);
    public async Task<bool> SetHasLUserInfo() => await _dcache.SetAsync(Key_HasLUserInfo, true);

    #endregion

    #region sa_regpay_user是否存在用户

    private const string Key_HasRegpayUser = "Lobby_HasRegpayUser";
    public async Task<bool> GetHasRegpayUser() => await _dcache.GetOrDefaultAsync(Key_HasRegpayUser, false);
    public async Task<bool> SetHasRegpayUser() => await _dcache.SetAsync(Key_HasRegpayUser, true);

    #endregion

    #region sa_roulette_user是否存在用户

    private const string Key_HasRouletteUser = "Lobby_HasRouletteUser";
    /// <summary>
    /// GetHasRouletteUserAsync
    /// </summary>
    /// <returns></returns>
    public async Task<bool> GetHasRouletteUserAsync() => await _dcache.GetOrDefaultAsync(Key_HasRouletteUser, false);
    /// <summary>
    /// SetHasRouletteUser
    /// </summary>
    /// <returns></returns>
    public async Task<bool> SetHasRouletteUserAsync() => await _dcache.SetAsync(Key_HasRouletteUser, true);

    #endregion

    #region 用户手机号

    private const string Key_Mobile = "Mobile"; //连续登录天数
    public async Task<string> GetMobile() => await _dcache.GetOrDefaultAsync<string>(Key_Mobile, null);

    #endregion

    #region UserKind

    private const string Key_UserKind = "UserKind";
    public async Task<UserKind> GetUserKind() => await _dcache.GetOrExceptionAsync<UserKind>(Key_UserKind);

    #endregion

    #region 是否已添加新用户首充500%奖励活动配置
    private const string Key_HasPayAwardConfig = "Lobby_HasPayAwardConfig";
    public async Task<bool> GetHasPayAwardConfig() => await _dcache.GetOrDefaultAsync(Key_HasPayAwardConfig, false);
    public async Task<bool> SetHasPayAwardConfig() => await _dcache.SetAsync(Key_HasPayAwardConfig, true);
    #endregion
    #region 用户Username

    private const string Key_Username = "Username";
    public async Task<string> GetUsername() => await _dcache.GetOrExceptionAsync<string>(Key_Username);

    #endregion

    #region UserMode

    /// <summary>
    /// 获取用户类型
    /// </summary>
    /// <returns></returns>
    public async Task<UserMode> GetUserMode() => await _dcache.GetUserModeAsync();

    #endregion

    #region FromMode

    public async Task<int> GetFromMode() => await _dcache.GetFromModeAsync();

    #endregion

    #region FromId

    public async Task<string> GetFromId() => await _dcache.GetFromIdAsync();

    #endregion

    #region 活动100013

    private const string Key_IsMeetPay_100013 = "Lobby_IsMeetPay_100013";
    public async Task<bool> GetIsMeetPay100013Async() => await _dcache.GetOrDefaultAsync(Key_IsMeetPay_100013, false);
    public async Task<bool> SetIsMeetPay100013Async() => await _dcache.SetAsync(Key_IsMeetPay_100013, true);

    private const string Key_IsMeetBet_100013 = "Lobby_IsMeetBet_100013";
    public async Task<bool> GetIsMeetBet100013Async() => await _dcache.GetOrDefaultAsync(Key_IsMeetBet_100013, false);
    public async Task<bool> SetIsMeetBet100013Async() => await _dcache.SetAsync(Key_IsMeetBet_100013, true);

    #endregion

    #region 活动101001

    private const string Key_HasRoulette101001User = "Lobby_HasRoulette101001User";
    public async Task<bool> GetHasRoulette101001UserAsync() => await _dcache.GetOrDefaultAsync(Key_HasRoulette101001User, false);
    public async Task<bool> SetHasRoulette101001UserAsync() => await _dcache.SetAsync(Key_HasRoulette101001User, true);

    #endregion

    #region 活动101003 包赔活动

    private const string Key_HashCompensationUser = "Lobby_HashCompensationUser";

    public async Task<bool> GetHasCompensationUser() => await _dcache.GetOrDefaultAsync(Key_HashCompensationUser, false);

    public async Task<bool> SetHasCompensationUser() => await _dcache.SetAsync(Key_HashCompensationUser, true);

    #endregion

}
