using UGame.Lobby.Service.Caching.Activity.Roulette;
using UGame.Lobby.Repository.ing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo;
using AiUo.Randoms;

namespace UGame.Lobby.Service.Services.Activity.Roulette.Process
{
    internal class RouletteTipPayProcess : RouletteProcessBase
    {
        public override async Task Execute(RouletteContext context)
        {
            context.IsTipPay = await CheckIsTipPay(context);
        }



        /// <summary>
        /// 验证是否弹出充值送freespin提示
        /// </summary>
        /// <returns></returns>
        private async Task<bool> CheckIsTipPay(RouletteContext context)
        {
            //如果已完成首充，则不会再提示
            if (context.RouletteUser.IsFirstPay)
                return false;

            //如果当前freespin轮数 >= 配置最大提示轮数
            if (context.FreespinRound >= context.RouletteConfig.TipPayRoundMax)
                return true;

            //如果用户freespin=0，并且FreespinRound > 0
            if (context.RouletteUser.Freespin == 0 && context.FreespinRound > 0)
                return true;

            //如果当前freespin轮数 >= 提示充值轮数下限，并且，当前freespin轮数 < 提示充值轮数上限，50%几率弹出充值提示
            if (context.FreespinRound >= context.RouletteConfig.TipPayRoundMin && context.FreespinRound < context.RouletteConfig.TipPayRoundMax)
            {
                return RandomUtil.IsOdds((decimal)0.5, 100);
            }

            return false;
        }
    }

}
