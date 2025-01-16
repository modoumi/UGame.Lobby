using UGame.Lobby.Service.Dtos.Responses;
using UGame.Lobby.Service.Services.Vip;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using AiUo.AspNet;
using AiUo.AspNet.ClientSign;

namespace UGame.Lobby.WebAPI.Controllers
{
    /// <summary>
    /// VipController
    /// </summary>
    [EnableCors()]
    [ClientSignFilter()]
    public class VipController : AiUoControllerBase
    {
        private VipService _vipService = new();


        /// <summary>
        /// 获取用户vip相关信息
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        /// <exception cref="CustomException"></exception>
        [HttpPost]
        public async Task<UserVipInfoDto> GetVipInfo(UserVipInfoIpo ipo)
        {
            ipo.UserId = base.UserId;
            return await _vipService.GetVipInfo(ipo);
        }


        /// <summary>
        /// 获取vip等级数据
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<VipConfigDto> GetVipConfig(VipConfigIpo ipo)
        {
            ipo.UserId = base.UserId;
            return await _vipService.GetVipConfig(ipo);
        }

        /// <summary>
        /// 领取vip升级奖励
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<decimal> Receive(VipReceiveIpo ipo)
        {
            ipo.UserId = base.UserId;
            return await _vipService.ReceiveAsync(ipo);
        }
        [HttpPost]
        public async Task<List<VipBenefitResponse>> GetBenefitList(UserVipInfoIpo ipo)
        {
            ipo.UserId = base.UserId;
            return await _vipService.GetBenefitList(ipo);
        }
        [HttpPost]
        public async Task<List<VipRebateResponse>> GetRebateList(UserVipInfoIpo ipo)
        {
            ipo.UserId = base.UserId;
            return await _vipService.GetRebateList(ipo);
        }

        /// <summary>
        /// 领取vip中的日周月返奖
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<decimal> ReceiveRebateReward(VipRebateRewardIpo ipo)
        {
            ipo.UserId = base.UserId;
            return await _vipService.ReceiveRebateReward(ipo);
        }
    }
}
