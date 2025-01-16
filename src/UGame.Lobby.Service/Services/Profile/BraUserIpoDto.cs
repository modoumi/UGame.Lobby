using UGame.Lobby.Repository.ing;
using AiUo.AspNet;
using AiUo.Extensions.AutoMapper;
using Xxyy.Banks.Client.BLL.Pandapay;

namespace UGame.Lobby.Service.Services.Profile
{
    public class BraUserIpo : LobbyBaseIpo, IMapTo<L_bra_userEO>, IMapTo<Xxyy.Banks.Client.BLL.Pandapay.XxyyPandapayIpo>
    {
        /// <summary>
        /// 应用编码
        /// </summary>
        public string AppId { get; set; }
        /// <summary>
        /// 税号对应的账户名
        /// </summary>
        [RequiredEx("", "AccName cannot be empty.")]
        public string AccName { get; set; }

        /// <summary>
        /// 税号
        /// </summary>
        [RequiredEx("", "TaxId cannot be empty.")]
        public string TaxId { get; set; }


        public void MapTo(L_bra_userEO destination)
        {
            
        }

        public void MapTo(XxyyPandapayIpo destination)
        {
            
        }
    }

    public class BraUserDto : IMapFrom<L_bra_userEO>
    {
        

        public void MapFrom(L_bra_userEO source)
        {
            
        }
    }
}
