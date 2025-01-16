using UGame.Lobby.Service.Services.Activity.InviteNewUser;
using UGame.Lobby.Service.Services.Activity.LoseCashBack;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using AiUo.AspNet;

namespace UGame.Lobby.WebAPI.Controllers.Activity
{
    /// <summary>
    /// LoseCashBackController
    /// </summary>
    [EnableCors()]
    public class LoseCashBackController : AiUoControllerBase
    {
        /// <summary>
        /// 输返活动-活动详情
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        public async Task<LoseCashBackDto> About(LoseCashBackIpo ipo)
        {
            ipo.UserId = base.UserId;
            return await new LoseCashBackService().About(ipo);
        }
    }
}
