
using AiUo.Extensions.AutoMapper;
using Xxyy.Banks.Client.BLL.Tejeepay;

namespace UGame.Lobby.Service.Services.LobbyBank.IpoDto
{


    public class ChannelBankListDto
    {
        public List<ChannelBankItem> BankList { get; set; } = new List<ChannelBankItem>();
    }


    public class ChannelBankItem : IMapFrom<Xxyy.Banks.Client.BLL.Tejeepay.BankCodeModel>, IMapFrom<Xxyy.Banks.Client.BankCodeModel>
    {
        public string BankCode { get; set; }

        public string BankName { get; set; }


        public void MapFrom(Xxyy.Banks.Client.BLL.Tejeepay.BankCodeModel source)
        {

        }

        public void MapFrom(Xxyy.Banks.Client.BankCodeModel source)
        {
            
        }
    }

}
