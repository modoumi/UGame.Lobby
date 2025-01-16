
using UGame.Lobby.Service.Services.Activity.SigninNew;
using UGame.Lobby.Service.Services.Profile;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using AiUo.AspNet;
using AiUo.Extensions.StackExchangeRedis;
using Xxyy.Common;

namespace UGame.Lobby.WebAPI.Controllers.Activity
{
    /// <summary>
    /// SignInController
    /// </summary>
    [EnableCors()]
    public class SignInController : AiUoControllerBase
    {

        /// <summary>
        /// 签到列表加载
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<SigninNewListDto> Load(SigninNewListIpo ipo)
        {
            ipo.UserId = base.UserId;
            return await new SigninNewService().LoadAsync(ipo);
        }

        /// <summary>
        /// 签到
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<SigninNewDto> Execute(SigninNewIpo ipo)
        {
            ipo.UserId = base.UserId;
            using (var redlock = await RedisUtil.LockAsync($"lobby/SignIn/Execute{base.UserId}", 30))
            {
                if (!redlock.IsLocked)
                {
                    redlock.Release();
                    throw new CustomException(CommonCodes.UserConcurrent, $"SignIn/Execute.Request for lock failed.userId:{ipo.UserId}");
                }

                return await new SigninNewService().ExecuteAsync(ipo);
            }
        }
    }
}
