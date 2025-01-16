using UGame.Lobby.Service.Common;
using UGame.Lobby.Common.Enum;
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
    internal class RouletteProcess : RouletteProcessBase
    {
        public override async Task Execute(RouletteContext context)
        {
            context.RouletteOdds = null;
            //抽奖计算是否中奖
            await Roulette(context);

            //如果当前用户是新用户，并且使用freespin，并且收益超过配置值则默认不中奖
            if (context.UserType == RouletteUserType.newUser 
                && context.IsFreeSpin 
                && context.RouletteUser.SumWinAmount >= context.RouletteConfig.NewUserMaxBonus)
                await RandomRouletteOdds(context);

            //不中奖or
            //1、奖池没钱
            //2、奖池小于奖励
            if(context.RoulettePool.FreespinPool == 0
                || context.RoulettePool.FreespinPool < (long)(context.RouletteConfig.RaffleCashAmount * context.RouletteOdds.Multiple))
                await RandomRouletteOdds(context);

            if (context.RouletteOdds.Multiple > 0)
                context.IsWin = true;

            if(context.IsWin)
                context.WinAmount = (long)(context.RouletteConfig.RaffleCashAmount * context.RouletteOdds.Multiple);

            return;
        }

        /// <summary>
        /// 当不满足中奖条件时，调用
        /// </summary>
        /// <returns></returns>
        private async Task RandomRouletteOdds(RouletteContext context)
        {
            //var randomOdds = context.RouletteOddsList.Where(d => d.Level == 1 && d.Multiple == 0 && d.RewardType == 1).ToList();
            //if (randomOdds != null && randomOdds.Any() && randomOdds.Count > 0)
            //{
            //    var random = RandomUtil.NextInt(1, 101);
            //    if (random % 2 == 0)
            //        context.RouletteOdds = randomOdds[0];
            //    else
            //        context.RouletteOdds = randomOdds.Last();
            //}
            //else
            //    context.RouletteOdds = randomOdds.FirstOrDefault();

            context.RouletteOdds = context.RouletteOddsList.Where(d => d.Multiple > 0).FirstOrDefault();
        }

        private async Task Roulette(RouletteContext context)
        {
            RandomUtil.DefaultProvider = RandomProviderFactory.CreateDefaultProvider();

            //中奖几率随机数
            var random = RandomUtil.NextInt(1, context.RouletteOddsList.Sum(d => d.Odds) + 1);

            var startNum = 1;
            foreach (var item in context.RouletteOddsList)
            {
                if (item.Odds == 0)
                    continue;
                if (random >= startNum && random <= (item.Odds + startNum - 1))
                {
                    context.RouletteOdds = item;
                    if (item.Items == null || !item.Items.Any())
                        break;
                    else
                    {
                        //中奖几率随机数
                        random = RandomUtil.NextInt(1, item.Items.Sum(d => d.Odds) + 1);
                        startNum = 1;
                        foreach (var itemNew in item.Items)
                        {
                            if (itemNew.Odds == 0)
                                continue;
                            if (random >= startNum && random <= (itemNew.Odds + startNum - 1))
                            {
                                context.RouletteOdds = itemNew;
                                break;
                            }
                            startNum += itemNew.Odds;
                        }
                        break;
                    }
                }
                startNum += item.Odds;
            }

            if (context.RouletteOdds == null)
                throw new CustomException("Roulette.Not found odds.");

            return;
        }

    }
}
