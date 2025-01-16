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
    public class Register7NotifyCommand : NotifyCommandBase
    {
        public Register7NotifyCommand() : base()
        {
            ActivityType = ActivityType.Register7;
            RewardFlagId = (int)ActivityType.Register7;
            RewardSourceTable = "sa_register100007_user";
            SenderId = "Register7NotifyCommand";
        }
    }

    public class Register7NotifyCommandHandler : NotifyCommandHandlerBase<Register7NotifyCommand>
    {

    }

}
