using UGame.Lobby.Repository.ing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Extensions.AutoMapper;
using Xxyy.Common;

namespace UGame.Lobby.Service.Services.Activity.LoseCashBack
{
    public class LoseCashBackIpo : LobbyBaseIpo
    {
        
    }

    public class LoseCashBackDto 
    {
        public List<LoseCashBackItem> Items { get; set; } = new List<LoseCashBackItem>();
    }

    public class LoseCashBackItem : IMapFrom<Sa_losecashback_configEO>
    {
        public decimal RangeMin { get; set; }

        public decimal RangeMax { get; set; }

        public decimal RewardMin { get; set; }

        public decimal RewardMax { get; set; }

        public bool IsShowRangeMax { get; set; } = true;

        public decimal MaxAmount { get; set; }

        public void MapFrom(Sa_losecashback_configEO source)
        {
            this.RangeMin = source.RangeMin.AToM(source.CurrencyID);
            this.RangeMax = source.RangeMax.AToM(source.CurrencyID);
            this.RewardMin = source.RangeMin.AToM(source.CurrencyID) * (decimal)source.RefundMultiple;
            this.RewardMax = source.RangeMax.AToM(source.CurrencyID) * (decimal)source.RefundMultiple;
            this.MaxAmount = source.RefundMax.AToM(source.CurrencyID);
        }
    }

}
