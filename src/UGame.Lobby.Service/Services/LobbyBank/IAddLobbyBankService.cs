using UGame.Lobby.Service.Caching;
using UGame.Lobby.Service.Services.Activity.Roulette101001;
using UGame.Lobby.Service.Services.Cash;
using UGame.Lobby.Service.Services.Profile;
using UGame.Lobby.Common.Enum;
using UGame.Lobby.Repository.ing;
using Microsoft.AspNetCore.Localization;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo;
using AiUo.Data;
using AiUo.Data.SqlSugar;
using AiUo.Extensions.AutoMapper;
using AiUo.Logging;
using AiUo.Text;
using UGame.Lobby.Service.Caching.Profile.Bra;
using UGame.Lobby.Service.Common;
using UGame.Lobby.Service.Services.LobbyBank.IpoDto;
using Xxyy.Banks.Client.BLL.Letspay;
using Xxyy.Banks.Client.BLL.Tejeepay;
using Xxyy.Common;
using Xxyy.Common.Caching;

namespace UGame.Lobby.Service.Services.LobbyBank
{
    /// <summary>
    /// 添加lobby银行卡服务
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IAddLobbyBankService<T>
    {
        /// <summary>
        /// 添加lobbyBank参数校验
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        Task<bool> CheckIpo(T ipo);

        /// <summary>
        /// 添加银行卡
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        Task<bool> AddLobbyBank(T ipo);
    }

    public class AddLobbyBankServiceFactory<T>
    {

        public static IAddLobbyBankService<T> CreateService(string countryId)
        {
            switch (countryId)
            {
                case "MEX":
                    return new MEXAddLobbyBankService<T>();
                case "BRA":
                    return new BRAAddLobbyBankService<T>();
                default:
                    throw new CustomException(LobbyCodes.RS_PARAMETER_ERROR, $"Unsupported country code:{countryId}");
            }
        }
    }

    /// <summary>
    /// 添加lobby银行卡服务（墨西哥）
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MEXAddLobbyBankService<T> : IAddLobbyBankService<T>
    {
        public async Task<bool> CheckIpo(T t)
        {
            var ipo = t as AddLobbyBankIpo;

            if (string.IsNullOrWhiteSpace(ipo.AccName))
                throw new CustomException(LobbyCodes.RS_PARAMETER_ERROR, "AccName cannot be empty.");
            if (string.IsNullOrWhiteSpace(ipo.TaxId))
                throw new CustomException(LobbyCodes.RS_PARAMETER_ERROR, "TaxId cannot be empty.");
            if(ipo.TaxId.Length > 30)
                throw new CustomException(LobbyCodes.RS_PARAMETER_ERROR, "param TaxId must be less than 30 bits.");
            if (string.IsNullOrWhiteSpace(ipo.BankCode))
                throw new CustomException(LobbyCodes.RS_PARAMETER_ERROR, "BankCode cannot be empty.");
            if(string.IsNullOrWhiteSpace(ipo.BankName))
                throw new CustomException(LobbyCodes.RS_PARAMETER_ERROR, "BankName cannot be empty.");

            //获取充值、提现渠道
            ipo.BraPayChannel = await LobbyUtil.GetPayChannel(ipo.OperatorId, ipo.CurrencyId, ipo.CountryId);

            switch (ipo.BraPayChannel)
            {
                case BraPayChannel.tejeepay:
                    return await CheckTejeePayBankList(ipo);
                case BraPayChannel.letspay:
                    return await CheckLetsPayBankList(ipo);
                default:
                    throw new CustomException(LobbyCodes.RS_UNKNOWN, "pay channel error.");
            }
        }

        private async Task<bool> CheckTejeePayBankList(AddLobbyBankIpo ipo)
        {
            try
            {
                var tejeePayClient = new TejeepayClient();

                var request = new XxyyTejeeBankListIpo()
                {
                    UserId = ipo.UserId,
                    AppId = ipo.AppId,
                    CountryId = ipo.CountryId
                };

                var response = await tejeePayClient.BankList(request);

                var log = $"MEXAddLobbyBankService_CheckIpo_CheckTejeePayBankList从bank获取bankList,request:{JsonConvert.SerializeObject(request)},response:{JsonConvert.SerializeObject(response)}";

                LogUtil.Info($"MEXAddLobbyBankService_CheckIpo_CheckTejeePayBankList从bank获取bankList从bank获取bankList,request:{JsonConvert.SerializeObject(request)},response:{JsonConvert.SerializeObject(response)}");

                if (!response.Success || response.Status != 200)
                {
                    LogUtil.GetContextLogger().AddMessage($"MEXAddLobbyBankService_CheckIpo_CheckTejeePayBankList从bank获取bankList从bank获取bankList,request:{JsonConvert.SerializeObject(request)},response:{JsonConvert.SerializeObject(response)}");
                    throw new CustomException(LobbyCodes.RS_TEJEEPAY_BANKLIST_ERROR, "MEXAddLobbyBankService_CheckIpo_CheckTejeePayBankList从bank获取bankList,banklist failed.");
                }

                if (response.Result == null || !response.Result.Any())
                    throw new CustomException(LobbyCodes.RS_PARAMETER_ERROR, "MEXAddLobbyBankService_CheckIpo_CheckTejeePayBankList从bank获取bankList,banklist is empty.");

                if (response.Result.Any(d => d.BankCode.Equals(ipo.BankCode) && d.BankName.Equals(ipo.BankName)))
                    return true;

                return false;
            }
            catch (Exception ex)
            {
                throw new CustomException(LobbyCodes.RS_TEJEEPAY_BANKLIST_ERROR, $"{ex.Message}");
            }
        }

        private async Task<bool> CheckLetsPayBankList(AddLobbyBankIpo ipo)
        {
            try
            {
                var letsPayClient = new LetspayClient();

                var request = new Xxyy.Banks.Client.XxyyGetBankListIpo()
                {
                    UserId = ipo.UserId,
                    AppId = ipo.AppId,
                    CountryId = ipo.CountryId
                };

                var response = await letsPayClient.BankList(request);

                if (!response.Success || response.Status != 200)
                {
                    LogUtil.GetContextLogger().AddMessage($"MEXAddLobbyBankService_CheckIpo_CheckLetsPayBankList从bank获取bankList,request:{JsonConvert.SerializeObject(request)},response:{JsonConvert.SerializeObject(response)}");
                    throw new CustomException(LobbyCodes.RS_TEJEEPAY_BANKLIST_ERROR, "MEXAddLobbyBankService_CheckIpo_CheckLetsPayBankList从bank获取bankList,banklist failed.");
                }

                if (response.Result == null || !response.Result.Any())
                    throw new CustomException(LobbyCodes.RS_PARAMETER_ERROR, "MEXAddLobbyBankService_CheckIpo_CheckLetsPayBankList从bank获取bankList,banklist is empty.");

                if (response.Result.Any(d => d.BankCode.Equals(ipo.BankCode) && d.BankName.Equals(ipo.BankName)))
                    return true;

                return false;
            }
            catch (Exception ex)
            {
                throw new CustomException(LobbyCodes.RS_TEJEEPAY_BANKLIST_ERROR, $"{ex.Message}");
            }
        }

        public async Task<bool> AddLobbyBank(T t)
        {
            var ret = false;

            var ipo = t as AddLobbyBankIpo;

            //默认添加
            var IsInsert = true;
            if (!string.IsNullOrWhiteSpace(ipo.UserBankId))
                IsInsert = false;

            var tm = new DbTransactionManager();
            var globalUserDCache = await GlobalUserDCache.Create(ipo.UserId);

            try
            {
                tm.Begin();

                var BankChannel = ipo.BraPayChannel.ToString();

                //更新
                if (!IsInsert)
                {
                    var userBank = await tm.GetRepository<L_bra_user_bankPO>()
                        .AsQueryable()
                        .Where(d => d.UserID.Equals(ipo.UserId) && d.UserBankID.Equals(ipo.UserBankId))
                        .FirstAsync();

                    if (userBank == null)
                        throw new CustomException(LobbyCodes.RS_PARAMETER_ERROR, $"param userbankId error.");

                    userBank = await tm.GetRepository<L_bra_user_bankPO>()
                        .AsQueryable()
                        .Where(d => d.UserID.Equals(ipo.UserId) && d.TaxId.Equals(ipo.TaxId) && d.KeyCode.Equals(ipo.TaxId) && d.BankChannel.Equals(BankChannel))
                        .FirstAsync();

                    if (userBank != null)
                        throw new CustomException(LobbyCodes.RS_REPEAT_ADDITION, $"Repeat addition.");

                    await tm.GetRepository<L_bra_user_bankPO>()
                        .UpdateSetColumnsTrueAsync(d => new L_bra_user_bankPO()
                        {
                            Name = ipo.AccName,
                            TaxId = ipo.TaxId,
                            KeyCode = ipo.TaxId,
                            BankName = ipo.BankName,
                            BankCode = ipo.BankCode,
                            AccountNumber = ipo.TaxId
                        }, d => d.UserID.Equals(ipo.UserId) && d.UserBankID.Equals(ipo.UserBankId));
                }
                //添加
                else
                {
                    var userBank = await tm.GetRepository<L_bra_user_bankPO>()
                        .AsQueryable()
                        .Where(d => d.UserID.Equals(ipo.UserId) && d.TaxId.Equals(ipo.TaxId) && d.KeyCode.Equals(ipo.TaxId) && d.BankChannel.Equals(BankChannel))
                        .FirstAsync();

                    if (userBank != null)
                        throw new CustomException(LobbyCodes.RS_REPEAT_ADDITION, $"Repeat addition.");

                    var eo = new L_bra_user_bankPO()
                    {
                        UserBankID = ObjectId.NewId(),
                        BankChannel = BankChannel,
                        UserID = ipo.UserId,
                        UserKind = (int)await globalUserDCache.GetUserKindAsync(),
                        OperatorID = ipo.OperatorId,
                        CountryID = ipo.CountryId,
                        CurrencyID = ipo.CurrencyId,
                        TaxId = ipo.TaxId,
                        KeyCode = ipo.TaxId,
                        AccountType = ipo.BankCode,
                        Name = ipo.AccName,
                        OwnerType = string.Empty,
                        BankName = ipo.BankName,
                        BankCode = ipo.BankCode,
                        BranchCode = string.Empty,
                        AccountNumber = ipo.TaxId,
                        AccountStatus = string.Empty,
                        RecDate = DateTime.UtcNow
                    };

                    await tm.GetRepository<L_bra_user_bankPO>().InsertAsync(eo);
                }

                tm.Commit();

                await new BraUserBankDCache(ipo.OperatorId, ipo.UserId).KeyDeleteAsync();

                return true;
            }
            catch (Exception ex)
            {
                tm.Rollback();
                if (ex is not CustomException)
                {
                    LogUtil.GetContextLogger().AddException(ex).AddMessage($"MEXAddLobbyBankService.AddLobbyBank,ipo:{JsonConvert.SerializeObject(ipo)}");

                    throw new CustomException(LobbyCodes.RS_UNKNOWN, ex.Message);
                }
                else
                {
                    throw new CustomException(LobbyCodes.RS_REPEAT_ADDITION, $"AddBraBank,{ex.Message}");
                }
            }
        }
    }

    /// <summary>
    /// 添加lobby银行卡服务（巴西）
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BRAAddLobbyBankService<T> : IAddLobbyBankService<T>
    {
        public async Task<bool> CheckIpo(T t)
        {
            var ipo = t as AddLobbyBankIpo;

            if (string.IsNullOrWhiteSpace(ipo.AccName))
                throw new CustomException(LobbyCodes.RS_PARAMETER_ERROR, "AccName cannot be empty.");
            if (string.IsNullOrWhiteSpace(ipo.TaxId))
                throw new CustomException(LobbyCodes.RS_PARAMETER_ERROR, "TaxId cannot be empty.");
            if (string.IsNullOrWhiteSpace(ipo.Key))
                throw new CustomException(LobbyCodes.RS_PARAMETER_ERROR, "Key cannot be empty.");

            switch (ipo.BraPayChannel)
            {
                case BraPayChannel.hubtel:
                case BraPayChannel.pandapay:
                    return false;
                case BraPayChannel.tejeepay:
                case BraPayChannel.letspay:
                case BraPayChannel.bfpay:
                case BraPayChannel.mlpay:
                    var tejeePayMethod = ipo.TejeePayMethod.ToEnumN<TejeePayMethod>();
                    if (!tejeePayMethod.HasValue)
                        throw new CustomException(LobbyCodes.RS_PARAMETER_ERROR, "param tejeePayMethod error.");
                    switch (tejeePayMethod)
                    {
                        case TejeePayMethod.CPF:
                            if (ipo.Key.Length != 11)
                                throw new CustomException(LobbyCodes.RS_PARAMETER_ERROR, "param CPF is 11 bits.");
                            if (!ipo.TaxId.Equals(ipo.Key))
                                throw new CustomException(LobbyCodes.RS_PARAMETER_ERROR, "param TaxId must be consistent with CPF.");
                            break;
                        case TejeePayMethod.CNPJ:
                            if (ipo.Key.Length != 14)
                                throw new CustomException(LobbyCodes.RS_PARAMETER_ERROR, "param CNPJ is 14 bits.");
                            break;
                        case TejeePayMethod.PHONE:
                            if (ipo.Key.Length != 11)
                                throw new CustomException(LobbyCodes.RS_PARAMETER_ERROR, "param PHONE is 11 bits.");
                            break;
                        case TejeePayMethod.EMAIL:
                            if (!StringUtil.IsEmail(ipo.Key))
                                throw new CustomException(LobbyCodes.RS_PARAMETER_ERROR, "param Email is illegal.");
                            break;
                        default:
                            break;
                    }
                    return true;
                default:
                    throw new CustomException(LobbyCodes.RS_PARAMETER_ERROR, "prams error4.");
            }

            return false;
        }

        public async Task<bool> AddLobbyBank(T t)
        {
            var ret = false;

            var ipo = t as AddLobbyBankIpo;

            ipo.TejeePayMethodEnum = ipo.TejeePayMethod.ToEnum<TejeePayMethod>();

            //获取缓存中的用户银行卡列表
            var braUserBankDCache = new BraUserBankDCache(ipo.OperatorId, ipo.UserId);
            var userBankData = await braUserBankDCache.GetOrLoadAsync();

            var result = false;

            //全局用户缓存
            var globalUserDCache = await GlobalUserDCache.Create(ipo.UserId);

            var tm = new DbTransactionManager();

            try
            {
                tm.Begin();

                var BankChannel = ipo.BraPayChannel.ToString();

                if (!string.IsNullOrWhiteSpace(ipo.UserBankId)
                && userBankData.Value != null
                && userBankData.Value.Any(d => d.UserBankID.Equals(ipo.UserBankId)))
                {

                    if (userBankData.Value.Any(d => d.UserID.Equals(ipo.UserId)
                                                && d.KeyCode.Equals(ipo.Key)
                                                && d.AccountType.Equals(ipo.TejeePayMethodEnum.ToString())
                                                && !d.UserBankID.Equals(ipo.UserBankId)
                    ))
                        throw new CustomException(LobbyCodes.RS_REPEAT_ADDITION, $"Repeat addition.");

                    var braUserBank = await tm.GetRepository<L_bra_user_bankPO>()
                        .AsQueryable()
                        .Where(d => d.UserID.Equals(ipo.UserId) && d.TaxId.Equals(ipo.TaxId) && d.KeyCode.Equals(ipo.Key) && d.BankChannel.Equals(BankChannel))
                        .FirstAsync();

                    if (braUserBank != null)
                        throw new CustomException(LobbyCodes.RS_REPEAT_ADDITION, $"Repeat addition.");

                    await tm.GetRepository<L_bra_user_bankPO>()
                        .UpdateSetColumnsTrueAsync(d => new L_bra_user_bankPO()
                        {
                            Name = ipo.AccName,
                            TaxId = ipo.TaxId,
                            KeyCode = ipo.Key,
                            AccountType = ipo.TejeePayMethodEnum.ToString(),
                            AccountNumber = ipo.Key
                        }, d => d.UserID.Equals(ipo.UserId) && d.UserBankID.Equals(ipo.UserBankId));
                }
                //添加
                else
                {
                    var braUserBank = await tm.GetRepository<L_bra_user_bankPO>()
                        .AsQueryable()
                        .Where(d => d.UserID.Equals(ipo.UserId) && d.TaxId.Equals(ipo.TaxId) && d.KeyCode.Equals(ipo.Key) && d.BankChannel.Equals(BankChannel))
                        .FirstAsync();

                    if (braUserBank != null)
                        throw new CustomException(LobbyCodes.RS_REPEAT_ADDITION, $"Repeat addition.");

                    var eo = new L_bra_user_bankPO()
                    {
                        UserBankID = ObjectId.NewId(),
                        BankChannel = BankChannel,
                        UserID = ipo.UserId,
                        UserKind = (int)await globalUserDCache.GetUserKindAsync(),
                        OperatorID = ipo.OperatorId,
                        CountryID = ipo.CountryId,
                        CurrencyID = ipo.CurrencyId,
                        TaxId = ipo.TaxId,
                        KeyCode = ipo.Key,
                        AccountType = ipo.TejeePayMethod.ToEnumN<TejeePayMethod>()?.ToString(),
                        Name = ipo.AccName,
                        OwnerType = string.Empty,
                        BankName = string.Empty,
                        BankCode = string.Empty,
                        BranchCode = string.Empty,
                        AccountNumber = ipo.Key,
                        AccountStatus = string.Empty,
                        RecDate = DateTime.UtcNow
                    };

                    await tm.GetRepository<L_bra_user_bankPO>().InsertAsync(eo);
                }

                tm.Commit();

                await new BraUserBankDCache(ipo.OperatorId, ipo.UserId).KeyDeleteAsync();

                result = true;
            }
            catch (Exception ex)
            {
                tm.Rollback();
                if (ex is CustomException)
                {
                    var exception = ex as CustomException;
                    throw new CustomException(LobbyCodes.RS_REPEAT_ADDITION, $"AddBraBank,{ex.Message}");
                }
                throw new CustomException(LobbyCodes.RS_UNKNOWN, $"AddBraBank,{ex.Message}");
            }

            if (result)
            {
                //更新缓存
                await braUserBankDCache.KeyDeleteAsync();
                ret = true;
            }
            else
                throw new CustomException(LobbyCodes.RS_UNKNOWN, "failed.");

            return ret;
        }
    }

}
