using UGame.Lobby.Common.Enum;
using UGame.Lobby.Service.Commands.Activity.Base.Command;
using UGame.Lobby.Service.Commands.Activity.Base.Handler;

namespace UGame.Lobby.Service.Commands.Activity.Base
{


    public class UserPay100008NotifyCommand : NotifyCommandBase
    {
        public UserPay100008NotifyCommand() : base()
        {
            ActivityType = ActivityType.UserPay100008;
            RewardFlagId = (int)ActivityType.UserPay100008;
            RewardSourceTable = "sa_userpay100008_user";
            SenderId = "UserPay100008NotifyCommand";
        }
    }

    public class UserPay100008NotifyCommandHandler : NotifyCommandHandlerBase<UserPay100008NotifyCommand>
    { 
        
    }

}
