using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UGame.Lobby.Common.Enum;
using UGame.Lobby.Service.Commands.Activity.Base.Command;
using UGame.Lobby.Service.Commands.Activity.Base.Handler;

namespace UGame.Lobby.Service.Commands.Activity.Base
{
    public class BindMobileNotifyCommand : NotifyCommandBase
    {
        public BindMobileNotifyCommand() : base()
        {
            ActivityType = ActivityType.BindMobile;
            RewardFlagId = (int)ActivityType.BindMobile;
            RewardSourceTable = "sa_bind_mobile_user";
            SenderId = "BindMobileNotifyCommand";
        }
    }

    public class BindMobileNotifyCommandHandler : NotifyCommandHandlerBase<BindMobileNotifyCommand>
    {

    }

}
