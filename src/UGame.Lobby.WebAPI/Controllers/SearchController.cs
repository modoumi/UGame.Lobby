using Lobby.BLL;
using Lobby.BLL.Services.Search;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TinyFx.AspNet;
using TinyFx.Configuration;

namespace Lobby.WebAPI.Controllers
{
    public class SearchController : TinyFxControllerBase
    {

        private LobbyOptionsSection _options;

        private SearchService _searchService = new();

        public SearchController()
        {
            _options = ConfigUtil.GetSection<LobbyOptionsSection>();
        }

        ///// <summary>
        ///// 游戏搜索页
        ///// </summary>
        ///// <returns></returns>
        //[HttpPost]
        //public async Task<List<SearchDto>> GetAll([FromBody]SearchIpo ipo)
        //{
        //    ipo.UserId = base.UserId;
        //    ipo.OperatorId = _options.OperatorId;

        //    return await _searchService.GetAll(ipo);
        //}

        /// <summary>
        /// ShowMore、AllGame使用，根据游戏类别查询
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<List<SearchDto>> More([FromBody]SearchIpo ipo)
        {
            ipo.UserId = base.UserId;
            ipo.OperatorId = _options.OperatorId;

            return await _searchService.GetByCategory(ipo);
        }

        /// <summary>
        /// 游戏标签查询
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<List<SearchDto>> Label([FromBody] SearchIpo ipo)
        {
            ipo.UserId = base.UserId;
            ipo.OperatorId = _options.OperatorId;

            return await _searchService.GeyByLabel(ipo);
        }

        /// <summary>
        /// 模糊查询
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<List<SearchDto>> Fuzzy([FromBody] SearchIpo ipo)
        {
            ipo.UserId = base.UserId;
            ipo.OperatorId = _options.OperatorId;

            return await _searchService.GetByFuzzy(ipo);
        }

        /// <summary>
        /// MyGame
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<List<SearchDto>> MyGame([FromBody] SearchIpo ipo)
        {
            ipo.UserId = base.UserId;
            ipo.OperatorId = _options.OperatorId;
            ipo.HotCategoryId = Convert.ToInt32(_options.HotCategoryId);
            ipo.MyGameCategoryName = _options.MyGameCategoryName;
            ipo.MyGameRandomAppNumber = Convert.ToInt32(_options.MyGameRandomAppNumber);

            return await _searchService.GetMyGame(ipo);
        }

    }
}
