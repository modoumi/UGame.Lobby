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

    public class PayRewardNotifyCommand : NotifyCommandBase
    {
        public PayRewardNotifyCommand() : base()
        {
            ActivityType = ActivityType.UserFirstPay5;
            RewardFlagId = (int)ActivityType.UserFirstPay5;
            RewardSourceTable = "sa_firstpay_user_detail";
            SenderId = "PayRewardNotifyCommand";
        }
    }

    public class PayRewardNotifyCommandHandler : NotifyCommandHandlerBase<PayRewardNotifyCommand>
    {

    }

}
