using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UGame.Lobby.Service.Commands.Activity.Base.Command;

namespace UGame.Lobby.Service.Commands.Activity.Base.Handler
{
    public interface INotifyCommandHandler<ReqT, ResT> : IRequestHandler<ReqT, ResT> where ReqT : INotifyCommand<ResT>
    {

    }
}
