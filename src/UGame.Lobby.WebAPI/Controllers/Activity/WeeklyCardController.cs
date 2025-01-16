using UGame.Lobby.Service.Caching;
using UGame.Lobby.Service.Services;
using UGame.Lobby.Service.Services.Activity.SigninNew;
using UGame.Lobby.Service.Services.Activity.WeeklyCard;
using UGame.Lobby.Service.Services.Profile;
using Lobby.DAL.ing;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using SqlSugar;
using AiUo.AspNet;
using AiUo.Extensions.AutoMapper;
using AiUo.Extensions.StackExchangeRedis;
using Xxyy.Common;

namespace UGame.Lobby.WebAPI.Controllers.Activity
{

    /// <summary>
    /// SignInController
    /// </summary>
    [EnableCors()]
    public class WeeklyCardController : AiUoControllerBase
    {

        private WeeklyCardService _weeklyCardService = new();

        private ProfileService _profileService = new();

        /// <summary>
        /// 周卡加载
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<WeeklyCardLoadDto> Load(WeeklyCardLoadIpo ipo)
        {
            ipo.UserId = base.UserId;
            return await _weeklyCardService.LoadAsync(ipo);
        }

        /// <summary>
        /// 领取
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<WeeklyCardExecuteDto> Execute(WeeklyCardExecuteIpo ipo)
        {
            ipo.UserId = base.UserId;
            using (var redlock = await RedisUtil.LockAsync($"lobby/WeeklyCard/Execute{base.UserId}", 30))
            {
                if (!redlock.IsLocked)
                {
                    redlock.Release();
                    throw new CustomException(CommonCodes.UserConcurrent, $"WeeklyCard/Execute.Request for lock failed.userId:{ipo.UserId}");
                }

                return await _weeklyCardService.ExecuteAsync(ipo);
            }
        }

        /// <summary>
        /// 购买周卡
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<WeeklyCardBraPayDto> BraDeposit(WeeklyCardBraPayIpo ipo)
        {
            ipo.UserId = base.UserId;

            return await _weeklyCardService.BraDeposit(ipo);
        }

    }

}
