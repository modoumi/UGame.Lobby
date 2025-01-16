using UGame.Lobby.Repository.ing;
using System.Text.Json.Serialization;
using AiUo.Extensions.AutoMapper;
using AiUo.Text;
using Xxyy.Banks.Client.BLL.Mongopay;

namespace UGame.Lobby.Service.Services.Profile
{
    /// <summary>
    /// 查询Spei支持的银行ipo
    /// </summary>
    public class SpeiBanksIpo : LobbyBaseIpo, IMapTo<XxyyMongoBankListIpo>
    {

        /// <summary>
        /// 应用appid编码
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// 每次请求的唯一编码
        /// </summary>
        [JsonIgnore]
        public string RequestUUID { get; set; } = ObjectId.NewId();

        /// <summary>
        /// 银行编码【此参数固定值为mongopay】
        /// </summary>
        [JsonIgnore]
        public string BankId { get; set; } = "mongopay";

        /// <summary>
        /// 扩展数据
        /// </summary>
        [JsonIgnore]
        public object Meta { get; set; }

        public void MapTo(XxyyMongoBankListIpo destination)
        {
            
        }
    }

    /// <summary>
    /// 查询Spei支持的银行dto
    /// </summary>
    public class SpeiBanksDto : IMapFrom<Sb_mongopay_bankcodeEO>
    {
        /// <summary>
        /// 银行代码
        /// sb_bank_code表BankCode
        /// </summary>
        public string BankCode { get; set; }

        /// <summary>
        /// 银行名称
        /// sb_bank_code表BankName
        /// </summary>
        public string BankName { get; set; }

        public void MapFrom(Sb_mongopay_bankcodeEO source)
        {

        }
    }

}
