using MediatR;
using Microsoft.Extensions.Logging;
using AiUo.Logging;
using UGame.Lobby.Service.Services.Activity.BindMobile;

namespace UGame.Lobby.Service.Commands.Activity.BindMobile
{
    public class BindMobileCommandHandler : IRequestHandler<BindMobileCommand, bool>
    {
        ILogger<BindMobileCommandHandler> _logger;

        /// <summary>
        /// 构造方法
        /// </summary>
        public BindMobileCommandHandler()
        {
            _logger = LogUtil.CreateLogger<BindMobileCommandHandler>();
        }

        public async Task<bool> Handle(BindMobileCommand request, CancellationToken cancellationToken)
        {
            await new BindMobileService().BindMobile(request.UserId, request.AppId, request.IsSendNotify, request.IsSendNotifyEmail);

            return true;
        }
    }
}
