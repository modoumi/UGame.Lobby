using UGame.Lobby.Service.Common;
using UGame.Lobby.Service.Services.Activity.Regpay;
using UGame.Lobby.Service.Services.Activity.Roulette;
using UGame.Lobby.Service.Services.Activity.Signin;
using UGame.Lobby.Service.Services.Home;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using AiUo.AspNet;
using AiUo.AspNet.ClientSign;
using AiUo.Extensions.StackExchangeRedis;
using Xxyy.Common;

namespace UGame.Lobby.WebAPI.Controllers
{
    /// <summary>
    /// ActivitysController
    /// </summary>
    [EnableCors()]
    [ClientSignFilter()]
    public class ActivitysController : AiUoControllerBase
    {
        private readonly RegpayLobbyService _regpayLobbyService = new();
        private readonly RouletteService _rouletteService = new();
        private readonly SigninService _signinService = new(); 

        #region 注册、首充活动

        /// <summary>
        /// 获取用户注册、首充活动基础数据
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<RegpayUserDto> RegpayUser(RegpayUserIpo ipo)
        {
            ipo.UserId = base.UserId;
            return await _regpayLobbyService.RegpayUser(ipo);
        }

        /// <summary>
        /// 获取用户注册、首充活动奖励记录
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        [HttpPost]
        public async Task<List<RegpayDetailsDto>> RegpayDetails(RegpayDetailsIpo ipo)
        {
            ipo.UserId = base.UserId;
            return await _regpayLobbyService.RegpayDetails(ipo);
        }

        /// <summary>
        /// 注册、首充活动领取奖励
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<RegpayReceiveBonusDto> RegpayBonus(RegpayReceiveBonusIpo ipo)
        {
            ipo.UserId = base.UserId;

            using (var redlock = await RedisUtil.LockAsync($"lobby:RegpayBonus:{base.UserId}", 10))
            {
                if (!redlock.IsLocked)
                {
                    redlock.Release();
                    throw new CustomException(CommonCodes.UserConcurrent, $"RegpayBonus.Request for lock failed.userId:{ipo.UserId}");
                }

                return await _regpayLobbyService.RegpayReceiveBonus(ipo);
            }
        }

        /// <summary>
        /// 注册、首充活动推荐游戏
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<List<CategoryMoreDto>> RegpayGames(RegpayGamesIpo ipo)
        {
            ipo.UserId = base.UserId;
            return await _regpayLobbyService.RegpayGames(ipo);
        }


        #endregion

        #region 幸运转盘

        /// <summary>
        /// spin
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        [HttpPost]
        public async Task<RouletteDto> Roulettes(RouletteIpo ipo)
        {
            throw new CustomException(LobbyCodes.RS_ILLEGAL_REQUEST, "illegal request.");

            ipo.UserId = base.UserId;
            return await _rouletteService.Roulettes(ipo);
        }

        /// <summary>
        /// 幸运转盘推荐游戏
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        [HttpPost]
        public async Task<List<RouletteGamesDto>> RouletteGames(RouletteGamesIpo ipo)
        {
            throw new CustomException(LobbyCodes.RS_ILLEGAL_REQUEST, "illegal request.");

            ipo.UserId = base.UserId;
            return await _rouletteService.RouletteGames(ipo);
        }

        /// <summary>
        /// 幸运转盘基础数据
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<List<RouletteOddsBaseDto>> RouletteBaseData(RouletteOddsBaseIpo ipo)
        {
            throw new CustomException(LobbyCodes.RS_ILLEGAL_REQUEST, "illegal request.");

            ipo.UserId = base.UserId;
            return await _rouletteService.RouletteBaseData(ipo);
        }

        /// <summary>
        /// 幸运转盘中奖播报
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<List<RouletteMarqueeDto>> RouletteMarquee(RouletteMarqueeIpo ipo)
        {
            throw new CustomException(LobbyCodes.RS_ILLEGAL_REQUEST, "illegal request.");

            ipo.UserId = base.UserId;
            return await _rouletteService.RouletteMarquee(ipo);
        }

        /// <summary>
        /// 获取用户活动数据
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<RouletteUserDto> GetRouletteUser(RouletteUserIpo ipo)
        {
            throw new CustomException(LobbyCodes.RS_ILLEGAL_REQUEST, "illegal request.");

            ipo.UserId = base.UserId;
            return await _rouletteService.GetRouletteUser(ipo);
        }

        #endregion

        #region 签到活动

        /// <summary>
        /// 获取签到列表
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        /// <exception cref="CustomException"></exception>
        [HttpPost]
        public async Task<SigninListDto> GetSignlist(SigninListIpo ipo)
        {
            ipo.UserId = base.UserId;
            return await _signinService.GetSignlist(ipo);
        }

        /// <summary>
        /// 签到
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        /// <exception cref="CustomException"></exception>
        [HttpPost]
        public async Task<SigninBonusDto> Signin(SigninBonusIpo ipo)
        {
            ipo.UserId = base.UserId;
            return await _signinService.Signin(ipo);
        }
        /// <summary>
        /// 获取签到倍数
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<float> GetFlowMultip(SigninLevelIpo ipo)
        {
            ipo.UserId = base.UserId;
            return await _signinService.GetFlowMultip(ipo);
        }
        /// <summary>
        /// 获取签到等级
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<List<SigninLevelDto>> GetSigninLevel(SigninLevelIpo ipo)
        {
            ipo.UserId = base.UserId;
            return await _signinService.GetSigninLevelList(ipo.OperatorId, ipo.CurrencyId);
        }
        #endregion
    }
}
