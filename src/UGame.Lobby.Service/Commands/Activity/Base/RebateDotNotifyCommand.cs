using UGame.Lobby.Service.Commands.Activity.Base.Command;
using UGame.Lobby.Service.Commands.Activity.Base.Handler;

namespace UGame.Lobby.Service.Commands.Activity.Base;

public class RebateDotNotifyCommand : NotifyCommandBase
{
    public RebateDotNotifyCommand() : base()
    {
        RewardSourceTable = "sa_rebate_user_detail";       
        IsReward = true;
    }
}

public class RebateDotNotifyCommandHandler : NotifyCommandHandlerBase<RebateDotNotifyCommand>
{
}