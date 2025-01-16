using UGame.Lobby.Service.Services.Activity.Roulette101001;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using AiUo.AspNet;
using AiUo.AspNet.ClientSign;
using AiUo.Extensions.StackExchangeRedis;
using Xxyy.Common;

namespace UGame.Lobby.WebAPI.Controllers.Activity
{

    /// <summary>
    /// RouletteNewController
    /// </summary>
    [EnableCors()]
    [ClientSignFilter()]
    public class RouletteNewController : AiUoControllerBase
    {

        private Roulette101001Service _service = new();

        /// <summary>
        /// 加载轮盘
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<Roulette101001LoadDto> Load(Roulette101001LoadIpo ipo)
        {
            ipo.UserId = base.UserId;
            return await _service.LoadAsync(ipo);
        }

        /// <summary>
        /// 抽奖
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<RouletteRaffleDto> Raffle(RouletteRaffleIpo ipo)
        {
            ipo.UserId = base.UserId;

            using (var redlock = await RedisUtil.LockAsync($"lobby:roulette101001:raffle:{ipo.UserId}", 5))
            {
                if (!redlock.IsLocked)
                {
                    redlock.Release();
                    throw new CustomException(CommonCodes.UserConcurrent, $"roulette101001,Raffle请求分布式锁失败.userId:{ipo.UserId}");
                }

                return await _service.Raffle(ipo);
            }
        }

    }
}
