using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.AspNet;
using AiUo.Extensions.AutoMapper;
using AiUo.Serialization;
using Xxyy.Banks.Client.BLL;

namespace UGame.Lobby.Service.Services.Profile
{
    public class CashFeeIpo
    {
        [RequiredEx("", "UserId cannot be empty.")]
        public string UserId { get; set; }

        [RequiredEx("", "CountryId cannot be empty.")]
        public string CountryId { get; set; }

        [RequiredEx("", "CurrencyId cannot be empty.")]
        public string CurrencyId { get; set; }

        [RequiredEx("", "OperatorId cannot be empty.")]
        public string OperatorId { get; set; }

        [RangeEx(1,double.MaxValue,"", "Amount not valid")]
        public decimal Amount { get; set; }

        [RequiredEx("", "AppId cannot be empty.")]
        public string AppId { get; set; }
        public string LangId { get; set; }
        public JsonMeta AdditionalParameters { get; set; }
    }

    public class CashFeeDto : IMapFrom<CalcCashFeeDto>
    {
        public decimal Fee { get; set; }

        public void MapFrom(CalcCashFeeDto source)
        {
            this.Fee= source.Fee;
        }
    }
}
