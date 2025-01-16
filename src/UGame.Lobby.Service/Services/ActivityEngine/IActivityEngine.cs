using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UGame.Lobby.Service.Services.ActivityEngine
{
    internal interface IActivityEngine
    {
        Task<string> Execute(ActivityEngineContext context);
    }

    internal class ActivityEngine
    {
        private List<IActivityEngine> _activitys;

        public ActivityEngine() 
        {
            this.Init();
        }

        public void Init()
        {
            _activitys = new List<IActivityEngine>()
            {
                new BindMobileActivity()
            };
        }

        public async Task<List<string>> Execute(LobbyBaseIpo ipo)
        {
            var ret = new List<string>();
            var context = new ActivityEngineContext(ipo);
            foreach (var item in _activitys)
            {
                ret.Add(await item.Execute(context));
            }
            return ret;
        }

    }
}
