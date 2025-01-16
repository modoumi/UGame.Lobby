using UGame.Lobby.Service.Common;
using UGame.Lobby.Service.Services;
using UGame.Lobby.Service.Services.Activity.BindMobile;
using UGame.Lobby.Service.Services.ActivityEngine;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using AiUo.AspNet;
using AiUo.Extensions.RabbitMQ;
using UGame.Lobby.Service.MQConsumer;
using Microsoft.AspNetCore.Authorization;
using Xxyy.MQ.Xxyy;
using Xxyy.Common;
using AiUo.AspNet.ClientSign;

namespace UGame.Lobby.WebAPI.Controllers
{
    /// <summary>
    /// BindMobileController
    /// </summary>
    [EnableCors()]
    [ClientSignFilter()]
    public class BindMobileController : AiUoControllerBase
    {

        /// <summary>
        /// 绑定手机领取奖励
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        /// <exception cref="CustomException"></exception>
        [HttpPost]
        public async Task<BindMobileDto> Bind(BindMobileIpo ipo)
        {
            throw new CustomException(LobbyCodes.RS_ILLEGAL_REQUEST, "illegal request.");

            //ipo.UserId = base.UserId;
            //return await new BindMobileService().Bind(ipo);
        }

        /// <summary>
        /// 测试大厅首页小助手
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<string> TestActivityEngine(LobbyBaseIpo ipo)
        {
            throw new CustomException(LobbyCodes.RS_ILLEGAL_REQUEST, "illegal request.");

            ipo.UserId = base.UserId;

            var service = new ActivityAssistantService();

            var ret = await service.ActivityAssistant(ipo);

            return JsonConvert.SerializeObject(ret);
        }

    }
}
