using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UGame.Lobby.Service.Services.Activity.Roulette.Process
{
    interface IRouletteProcess
    {
        Task Execute(RouletteContext context);
    }

    internal abstract class RouletteProcessBase : IRouletteProcess
    {

        public abstract Task Execute(RouletteContext context);

    }


}
