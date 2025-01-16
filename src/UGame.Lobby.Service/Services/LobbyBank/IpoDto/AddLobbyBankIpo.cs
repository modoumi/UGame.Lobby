using UGame.Lobby.Common.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using AiUo.AspNet;

namespace UGame.Lobby.Service.Services.LobbyBank.IpoDto
{
    public class AddLobbyBankIpo : LobbyBaseIpo
    {
        /// <summary>
        /// 支付渠道编码4、pandapay;5、tejeepay
        /// </summary>
        public int Channels { get; set; }

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
        public string Key { get; set; }

        /// <summary>
        /// 巴西用户银行卡主键（更新时使用）
        /// </summary>
        public string UserBankId { get; set; }

        /// <summary>
        /// 银行编码（墨西哥tejeepay使用）
        /// </summary>
        public string BankCode { get; set; }

        /// <summary>
        /// 银行名称（墨西哥tejeepay使用）
        /// </summary>
        public string BankName { get; set; }

        /// <summary>
        /// 巴西提现时候使用（tejeePay method（0、CPF;1、CNPJ;2、PHONE;3、EMAIL;4、EVP））
        /// </summary>
        public int TejeePayMethod { get; set; } = 0;

        /// <summary>
        /// TejeePayMethod枚举
        /// </summary>
        [JsonIgnore]
        public TejeePayMethod TejeePayMethodEnum { get; set; }

        /// <summary>
        /// 支付渠道枚举
        /// </summary>
        [JsonIgnore]
        public BraPayChannel BraPayChannel { get; set; }

    }
}
