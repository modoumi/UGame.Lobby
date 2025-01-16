using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UGame.Lobby.Service.Services.ActivityEngine
{
    public class ActivityAssistantService
    {

        public async Task<List<string>> ActivityAssistant(LobbyBaseIpo ipo)
        { 
            var activityEngine = new ActivityEngine();
            return await activityEngine.Execute(ipo);
        }

    }
}
