using UGame.Lobby.Service.Caching.Activity.InviteNewUser;
using UGame.Lobby.Service.Services.Activity.InviteNewUser;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo;
using AiUo.Extensions.AutoMapper;
using AiUo.Logging;
using UGame.Lobby.Service.Caching.Activity.LoseCashBack;

namespace UGame.Lobby.Service.Services.Activity.LoseCashBack
{
    /// <summary>
    /// 输返活动服务
    /// </summary>
    public class LoseCashBackService
    {
        protected ILogger<LoseCashBackService> _logger;

        public LoseCashBackService()
        {
            _logger = LogUtil.CreateLogger<LoseCashBackService>();
        }

        /// <summary>
        /// 输返活动100003
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        /// <exception cref="CustomException"></exception>
        public async Task<LoseCashBackDto> About(LoseCashBackIpo ipo)
        {
            var ret = new LoseCashBackDto();

            var loseCashBackEoList = await new LoseCashBackDCache(ipo.OperatorId, ipo.CurrencyId).GetAsync();

            if (loseCashBackEoList.Any())
                ret.Items = loseCashBackEoList.Map<List<LoseCashBackItem>>();

            if (ret.Items != null && ret.Items.Any())
            {
                foreach (var item in ret.Items.OrderByDescending(d => d.RangeMin))
                {
                    item.IsShowRangeMax = false;
                    item.RangeMax = 0;
                    item.RewardMax = item.MaxAmount;
                    break;
                }
            }

            return ret;
        }
    }
}
