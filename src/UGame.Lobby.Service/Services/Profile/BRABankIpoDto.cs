using UGame.Lobby.Common.Enum;
using UGame.Lobby.Repository.ing;
using System.Text.Json.Serialization;
using AiUo;
using AiUo.AspNet;
using AiUo.Extensions.AutoMapper;

namespace UGame.Lobby.Service.Services.Profile
{
    /// <summary>
    /// 巴西添加银行卡ipo
    /// </summary>
    public class BRAAddBankIpo : LobbyBaseIpo
    {
        #region 公共参数

        /// <summary>
        /// 应用编码
        /// </summary>
        [RequiredEx("", "AppId cannot be empty.")]
        public string AppId { get; set; }

        /// <summary>
        /// 支付渠道编码4、pandapay;5、tejeepay
        /// </summary>
        public int Channels { get; set; }

        /// <summary>
        /// 支付渠道枚举
        /// </summary>
        [JsonIgnore]
        public BraPayChannel BraPayChannel { get; set; }

        /// <summary>
        /// 税号对应的账户名
        /// </summary>
        public string AccName { get; set; }

        /// <summary>
        /// 税号
        /// </summary>
        public string TaxId { get; set; }

        /// <summary>
        /// 密钥，可能是手机号、邮箱、随机码
        /// </summary>
        [RequiredEx("", "AppId cannot be empty.")]
        public string Key { get; set; }

        /// <summary>
        /// 巴西用户银行卡主键
        /// </summary>
        public string UserBankId { get; set; }

        #endregion

        #region tejeePay参数

        /// <summary>
        /// tejeePay method（0、CPF;1、CNPJ;2、PHONE;3、EMAIL;4、EVP）
        /// </summary>
        public int TejeePayMethod { get; set; } = 0;

        [JsonIgnore]
        public TejeePayMethod TejeePayMethodEnum { get; set; }

        #endregion
    }

    /// <summary>
    /// 巴西银行卡列表ipo
    /// </summary>
    public class BraBankQueryIpo : LobbyBaseIpo 
    {
        /// <summary>
        /// 银行卡id
        /// </summary>
        public string UserBankId { get; set; }

        /// <summary>
        /// 银行id集合
        /// </summary>
        public List<string> UserBankIds { get; set; }
    }

    /// <summary>
    /// 巴西银行卡列表dto
    /// </summary>
    public class BraBankQueryDto : IMapFrom<L_bra_user_bankEO>, IMapFrom<L_bra_user_bankPO>
    {
        public string UserBankID { get; set; }

        public string UserId { get; set; }

        public string BankCode { get; set; }

        public string BankName { get; set; }

        [JsonPropertyName("accName")]
        public string Name { get; set; }

        [JsonPropertyName("cardNo")]
        public string AccountNumber { get; set; }

        public string TaxId { get; set; }

        [JsonPropertyName("key")]
        public string KeyCode { get; set; }

        public bool LastUsing { get; set; }

        public int Channels { get; set; }

        [JsonIgnore]
        public DateTime RecDate { get; set; }

        /// <summary>
        /// tejeePay method（0、CPF;1、CNPJ;2、PHONE;3、EMAIL;4、EVP）
        /// </summary>
        public int TejeePayMethod { get; set; } = 0;


        public void MapFrom(L_bra_user_bankEO source)
        {
            if (!string.IsNullOrWhiteSpace(source.BankChannel))
            {
                var channel = source.BankChannel.ToEnumN<BraPayChannel>();
                if (channel.HasValue)
                    this.Channels = (int)channel.Value;

                if (channel.Value == BraPayChannel.tejeepay || channel.Value == BraPayChannel.letspay)
                {
                    var accountType = source.AccountType.ToEnumN<TejeePayMethod>();
                    if (accountType.HasValue)
                        this.TejeePayMethod = (int)accountType.Value;
                }
            }

        }

        public void MapFrom(L_bra_user_bankPO source)
        {
            if (!string.IsNullOrWhiteSpace(source.BankChannel))
            {
                var channel = source.BankChannel.ToEnumN<BraPayChannel>();
                if (channel.HasValue)
                    this.Channels = (int)channel.Value;

                if (channel.Value == BraPayChannel.tejeepay || channel.Value == BraPayChannel.letspay)
                {
                    var accountType = source.AccountType.ToEnumN<TejeePayMethod>();
                    if (accountType.HasValue)
                        this.TejeePayMethod = (int)accountType.Value;
                }
            }

        }
    }




}
