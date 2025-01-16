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
    public class InviteNewUser100011NotifyCommand : NotifyCommandBase
    {

        public InviteNewUser100011NotifyCommand() : base()
        {
            ActivityType = ActivityType.InvitationNewUser100011;
            RewardFlagId = (int)ActivityType.InvitationNewUser100011;
            RewardSourceTable = "sa_invite100011_detail";
            SenderId = "InviteNewUser100011NotifyCommand";
            IsReward = true;
        }

    }

    public class InviteNewUser100011NotifyCommandHandler : NotifyCommandHandlerBase<InviteNewUser100011NotifyCommand>
    { 
        
    }

}
