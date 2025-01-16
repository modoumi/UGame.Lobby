using UGame.Lobby.Service.Common;
using UGame.Lobby.Service.Services.Activity.InviteNewUser;
using UGame.Lobby.Service.Services.Profile;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;
using AiUo.AspNet;
using AiUo.Extensions.StackExchangeRedis;
using AiUo.Logging;
using Xxyy.Common;

namespace UGame.Lobby.WebAPI.Controllers.Activity
{
    /// <summary>
    /// InviteNewuserController
    /// </summary>
    [EnableCors()]
    public class InviteNewuserController : AiUoControllerBase
    {

        private InviteNewuserService _service = new();

        /// <summary>
        /// 好友邀请分享-奖励明细
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<List<InviteDetailsDto>> Details(InviteDetailsIpo ipo)
        {
            ipo.UserId = base.UserId;
            return await new InviteNewuserService().Details(ipo);
        }

        /// <summary>
        /// 好友邀请分享-活动详情
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        public async Task<InviteConfigDto> About(InviteConfigIpo ipo)
        {
            ipo.UserId = base.UserId;
            return await new InviteNewuserService().About100013(ipo);
            //return await new InviteNewuserService().About(ipo);
        }

        #region 1.7版邀请好友赢bonus

        /// <summary>
        /// 加载活动数据
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<InviteUser100013LoadDto> Load(InviteUser100013LoadIpo ipo)
        {
            ipo.UserId = base.UserId;
            return await _service.LoadAsync(ipo);
        }

        /// <summary>
        /// 领取奖励
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<Execute100013Dto> Execute(Execute100013Ipo ipo)
        {
            ipo.UserId = base.UserId;

            using (var redlock = await RedisUtil.LockAsync($"lobby/InviteNewuser/Execute{base.UserId}", 30))
            {
                if (!redlock.IsLocked)
                {
                    redlock.Release();
                    throw new CustomException(CommonCodes.UserConcurrent, $"InviteNewuser.Execute.Request for lock failed.userId:{ipo.UserId}");
                }

                return await _service.ExecuteAsync(ipo);
            }
        }
        

        #endregion

    }
}
