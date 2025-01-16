using UGame.Lobby.Repository.ing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo;
using UGame.Lobby.Service.Caching.Activity.Roulette;
using Xxyy.Common;

namespace UGame.Lobby.Service.Services.Activity.Roulette.Process
{
    internal class RouletteInitOddsProcess : RouletteProcessBase
    {
        public override async Task Execute(RouletteContext context)
        {
            var rouletteOddsDCache = new RouletteOddsDCache(context.Ipo.OperatorId, context.Ipo.CurrencyId);
            var rouletteOdds = await rouletteOddsDCache.GetAsync();
            if (!rouletteOdds.HasValue)
                throw new CustomException("RouletteOdds.Data is not exists.");


            context.RouletteOddsList = GetRouletteOddsList(rouletteOdds.Value.Where(d => d.RaffleType == context.RaffleType && d.UserType == (int)context.UserType).ToList());

            if(context.RouletteOddsList == null || !context.RouletteOddsList.Any())
                throw new CustomException("RouletteOdds.Data is not exists.");
        }

        private List<RouletteOddsBaseDto> GetRouletteOddsList(List<Sa_roulette_oddsEO> eoList)
        {
            eoList = eoList.OrderBy(d => d.Level).ThenBy(d => d.PreRewardType).ThenBy(d => d.OrderNum).ToList();

            var ret = new List<RouletteOddsBaseDto>();

            foreach (var item in eoList)
            {
                var detailApp = GetDetailApp(item);

                if (item.PreRewardType == 0)
                {
                    detailApp.Items = new List<RouletteOddsBaseDto>();
                    ret.Add(detailApp);
                }
                else
                {
                    var retItem = ret.Where(d => d.RewardType == item.PreRewardType).FirstOrDefault();
                    retItem.Items.Add(detailApp);
                }
            }

            return ret;
        }

        private RouletteOddsBaseDto GetDetailApp(Sa_roulette_oddsEO eo)
        {
            var ret = new RouletteOddsBaseDto
            {
                OperatorId = eo.OperatorID,
                CountryId = eo.CountryID,
                CurrencyId = eo.CurrencyID,
                RaffleType = eo.RaffleType,
                UserType = eo.UserType,
                Level = eo.Level,
                RewardType = eo.RewardType,
                PreRewardType = eo.PreRewardType,
                Position = eo.Position,
                Odds = eo.Odds,
                Multiple = eo.Multiple,
                OrderNum = eo.OrderNum
            };
            return ret;
        }
    }
}
