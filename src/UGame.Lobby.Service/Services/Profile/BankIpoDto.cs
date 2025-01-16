using UGame.Lobby.Repository.ing;
using System.Text.Json.Serialization;
using AiUo.AspNet;
using AiUo.Extensions.AutoMapper;

namespace UGame.Lobby.Service.Services.Profile
{
    /// <summary>
    /// 添加银行卡ipo
    /// </summary>
    public class AddBankInfoIpo : LobbyBaseIpo, IMapTo<L_user_bank_infoEO>, IMapTo<SpeiBanksIpo>
    {
        /// <summary>
        /// 应用编码
        /// </summary>
        [RequiredEx("", "AppId cann't be empty.")]
        public string AppId { get; set; }
        /// <summary>
        /// 用户银行卡id
        /// </summary>
        public string UserBankID { get; set; }
        /// <summary>
        /// 银行卡类型
        /// 1-Visa
        /// 2-Spei
        /// </summary>
        [JsonIgnore]
        public int BankType { get; set; } = 1;
        /// <summary>
        /// 银行编码（目前只有Spei在用）
        /// </summary>
        [RequiredEx("", "BankCode cann't be empty.")]
        public string BankCode { get; set; } = string.Empty;
        /// <summary>
        /// 银行名称
        /// </summary>
        [RequiredEx("", "BankName cann't be empty.")]
        public string BankName { get; set; } = string.Empty;
        /// <summary>
        /// 用户名
        /// </summary>
        [RequiredEx("", "UserName cann't be empty.")]
        public string UserName { get; set; }
        /// <summary>
        /// FirstName
        /// </summary>
        public string FirstName { get; set; } = string.Empty;
        /// <summary>
        /// LastName
        /// </summary>
        public string LastName { get; set; } = string.Empty;
        /// <summary>
        /// 银行卡号
        /// </summary>
        [RequiredEx("", "CardNo cann't be empty.")]
        [RegularExpressionEx("^\\d{16,18}$", "", "The format of the bank card number is 16 to 18 digits.")]
        public string CardNo { get; set; }
        /// <summary>
        /// 过期日期
        /// </summary>
        [RegularExpressionEx("^((0([1-9]))|(1(0|1|2)))(-|/)\\d{4}$", "", "The format of ExpiryDate should be MM/yyyy or MM-yyyy.")]
        public string ExpiryDate { get; set; }
        /// <summary>
        /// CVV
        /// </summary>
        public string CVV { get; set; }
        /// <summary>
        /// 最后充值、提现使用的卡
        /// </summary>
        [JsonIgnore]
        public bool LastUsing { get; set; }
        /// <summary>
        /// 记录时间
        /// </summary>
        [JsonIgnore]
        public DateTime RecDate { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonIgnore]
        public DateTime ModifyDate { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// 添加银行卡类型
        /// 1、普通添加
        /// 2、充值时添加
        /// </summary>
        public int AddBankType { get; set; } = 1;

        public void MapTo(L_user_bank_infoEO destination)
        {
            destination.ExpiryDate = ExpiryDate;
        }

        public void MapTo(SpeiBanksIpo destination)
        {
            destination.AppId = AppId;
        }
    }

    /// <summary>
    /// 用户银行卡列表ipo
    /// </summary>
    public class GetBankInfosIpo : LobbyBaseIpo
    {
        /// <summary>
        /// 应用编码
        /// </summary>
        [RequiredEx("", "AppId cannot be empty.")]
        public string AppId { get; set; }
        /// <summary>
        /// 银行编码
        /// </summary>
        public string UserBankId { get; set; }
        /// <summary>
        /// 排序类型
        /// 0、优先最近使用的银行卡顺序，其次更新时间
        /// 1、优先是否支持Spei、其次最近使用的银行卡、最后更新时间
        /// </summary>
        public int SortType { get; set; } = 0;
    }

    /// <summary>
    /// 用户银行卡列表dto
    /// </summary>
    public class BankInfosDto : IMapFrom<L_user_bank_infoEO>
    {
        /// <summary>
        /// 用户银行卡id
        /// </summary>
        public string UserBankID { get; set; }
        /// <summary>
        /// 银行卡类型
        /// 1-Visa
        /// 2-Spei
        /// </summary>
        public int BankType { get; set; } = 1;
        /// <summary>
        /// 银行编码（目前只有Spei在用）
        /// </summary>
        public string BankCode { get; set; } = string.Empty;
        /// <summary>
        /// 银行名称
        /// </summary>
        public string BankName { get; set; } = string.Empty;
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// FirstName
        /// </summary>
        public string FirstName { get; set; } = string.Empty;
        /// <summary>
        /// LastName
        /// </summary>
        public string LastName { get; set; } = string.Empty;
        /// <summary>
        /// 银行卡号
        /// </summary>
        public string CardNo { get; set; }
        /// <summary>
        /// 过期日期
        /// </summary>
        public string ExpiryDate { get; set; }
        /// <summary>
        /// CVV
        /// </summary>
        public string CVV { get; set; }
        /// <summary>
        /// 最后充值、提现使用的卡
        /// </summary>
        public bool LastUsing { get; set; }
        /// <summary>
        /// 记录时间
        /// </summary>
        [JsonIgnore]
        public DateTime RecDate { get; set; }

        public void MapFrom(L_user_bank_infoEO source)
        {

        }
    }
}
