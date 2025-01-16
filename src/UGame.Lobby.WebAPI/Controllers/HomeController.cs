using UGame.Lobby.Service;
using UGame.Lobby.Service.Services.Home;
using UGame.Lobby.Service.Services.Home.pay;
using UGame.Lobby.Service.Services.Home.Sync;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using AiUo.AspNet;
using AiUo.AspNet.ClientSign;
using AiUo.Configuration;
using AiUo.Extensions.StackExchangeRedis;
using Xxyy.Common;

namespace UGame.Lobby.WebAPI.Controllers;

/// <summary>
/// HomeController
/// </summary>
[EnableCors()]
[ClientSignFilter()]
public class HomeController : AiUoControllerBase
{
    private readonly HomeService _homeSvc;
    private readonly LobbyOptionsSection _options;

    /// <summary>
    /// 构造函数
    /// </summary>
    public HomeController()
    {
        _homeSvc = new HomeService();
        _options = ConfigUtil.GetSection<LobbyOptionsSection>();
    }

    /// <summary>
    /// 取一级分类列表（不包含MyGame|for you）
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<List<CategoryListDto>> CategoryList(CategoryListIpo ipo)
    {
        ipo.UserId = base.UserId;
        return await _homeSvc.CategoryList(ipo);
    }

    /// <summary>
    /// 获取一级分类的游戏列表
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<List<CategoryDetailDto>> CategoryDetail(CategoryDetailIpo ipo)
    {
        ipo.UserId = base.UserId;
        return await _homeSvc.CategoryDetail(ipo);
    }

    /// <summary>
    /// 获取二级分类的游戏列表(分页,返回count=0表示结束分页)
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<List<AppDetailDto>> CategoryMore(CategoryMoreIpo ipo)
    {
        ipo.UserId = base.UserId;
        return await _homeSvc.CategoryMore(ipo);
    }

    /// <summary>
    /// 获取一级分类游戏列表
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<List<AppDetailDto>> FirstCategoryGames(CategoryFirstLevelGameIpo ipo)
    {
        ipo.UserId = base.UserId;
        return await _homeSvc.FirstCategoryGames(ipo);
    }

    /// <summary>
    /// 获取一级分类中MyGame的游戏列表
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<List<AppDetailDto>> CategoryMyGame(CategoryMyGameIpo ipo)
    {
        ipo.UserId = base.UserId;
        ipo.MyGameRandomAppNumber = Convert.ToInt32(_options.MyGameRandomAppNumber);

        return await _homeSvc.CategoryMyGame(ipo);
    }

    /// <summary>
    /// 获取关键字列表
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<List<KeywordsDto>> Keywords(KeywordsIpo ipo)
    {
        ipo.UserId = base.UserId;
        return await _homeSvc.Keywords(ipo);
    }

    /// <summary>
    /// 查询关键字获取游戏列表
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<List<AppDetailDto>> QueryKeyword(QueryKeywordIpo ipo)
    {
        ipo.UserId = base.UserId;
        return await _homeSvc.QueryKeyword(ipo);
    }

    /// <summary>
    /// 查询用户输入获取游戏类表
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<List<AppDetailDto>> QueryInput(QueryInputIpo ipo)
    {
        ipo.UserId = base.UserId;
        return await _homeSvc.QueryInput(ipo);
    }

    /// <summary>
    /// 用户收藏或取消收藏游戏
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<bool> Favorite(FavoriteIpo ipo)
    {
        ipo.UserId = base.UserId;

        using (var redlock = await RedisUtil.LockAsync($"lobby_home_Execute{base.UserId}", 30))
        {
            if (!redlock.IsLocked)
            {
                redlock.Release();
                throw new CustomException(CommonCodes.UserConcurrent, $"lobby_home_Execute.Request for lock failed.userId:{ipo.UserId}");
            }

            await _homeSvc.Favorite(ipo);
            return true;
        }

    }

    /// <summary>
    /// 获取活动中心数据
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<List<ActivityDto>> GetActivitys([FromBody] ActivityIpo ipo)
    {
        ipo.UserId = base.UserId;
        return await _homeSvc.GetActivitys(ipo);
    }

    /// <summary>
    /// 获取当前充值渠道可用充值金额
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    /// <exception cref="CustomException"></exception>
    [HttpPost]
    public async Task<PayAmountConfigDto> GetPayAmounts(PayAmountConfigIpo ipo)
    {
        ipo.UserId = base.UserId;
        return await _homeSvc.GetPayAmounts(ipo);
    }

    /// <summary>
    /// 获取hubtel当前充值渠道可用充值金额
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    /// <exception cref="CustomException"></exception>
    [HttpPost]
    public async Task<PayAmountConfigDto> GetHubtelPayAmounts(PayAmountConfigIpo ipo)
    {
        ipo.UserId = base.UserId;
        return await _homeSvc.GetHubtelPayAmounts(ipo);
    }

    /// <summary>
    /// 获取当前充值金额需要赠送的bonus
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    /// <exception cref="CustomException"></exception>
    [HttpPost]
    public async Task<decimal> GetPayBonus(PayAmountConfigIpo ipo)
    {
        ipo.UserId = base.UserId;
        return await _homeSvc.GetPayBonus(ipo);
    }

    /// <summary>
    /// 同步用户数据接口
    /// 1:同步余额信息
    /// 2:同步活动
    /// 4:同步破产保护数据
    /// </summary>
    /// <returns></returns>
    [HttpPost]
    public async Task<SyncDto> Sync(SyncIpo ipo)
    {
        ipo.UserId = base.UserId;
        return await new SyncService().Sync(ipo);
    }

    /// <summary>
    /// 获取标签列表
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<List<TagListDto>> TagList(TagListIpo ipo)
    {
        ipo.UserId = base.UserId;
        return await _homeSvc.TagList(ipo);
    }

    /// <summary>
    /// 获取标签游戏详情
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<List<TagDetailDto>> TagDetail(TagDetailIpo ipo)
    {
        ipo.UserId = base.UserId;
        return await _homeSvc.TagDetail(ipo);
    }

    /// <summary>
    /// 分页获取标签游戏详情
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<TagDetailByPageDto> GetTagDetailByPage(TagDetailByPageIpo ipo)
    {
        ipo.UserId = base.UserId;
        return await _homeSvc.GetTagDetailByPage(ipo);
    }

    /// <summary>
    /// 查询关键字获取游戏列表
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<List<AppDetailDto>> QueryByKeyword(QueryByKeywordIpo ipo)
    {
        ipo.UserId = base.UserId;
        return await _homeSvc.QueryByKeyword(ipo);
    }
}
