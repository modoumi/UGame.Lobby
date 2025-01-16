using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UGame.Lobby.Service.Services.ActivityEngine
{

    public class BindMobileActivity : IActivityEngine
    {
        

        public async Task<string> Execute(ActivityEngineContext context)
        {
            return "绑定手机奖励已经发放，请前往邮箱领取奖励";
        }
    }
}
