using EasyNetQ.Events;
using EasyNetQ.Logging;
using UGame.Lobby.Service.Commands.Activity.WeeklyCard;
using UGame.Lobby.Service.Services.Profile;
using UGame.Lobby.Common.Enum;
using UGame.Lobby.Repository.ing;
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
using UGame.Lobby.Service.Caching.Profile.Bra;
using UGame.Lobby.Service.Common;
using UGame.Lobby.Service.Services.LobbyBank.IpoDto;
using Xxyy.Banks.Client;
using Xxyy.Banks.Client.BLL.Letspay;
using Xxyy.Banks.Client.BLL.Tejeepay;
using Xxyy.Common.Caching;

namespace UGame.Lobby.Service.Services.LobbyBank
{
    public class LobbyBankService
    {

        public async Task<ChannelBankListDto> GetChannelBankListAsync(ChannelBankListIpo ipo)
        {
            var ret = new ChannelBankListDto();

            var globalUserDCache = await GlobalUserDCache.Create(ipo.UserId);
            ipo.OperatorId = await globalUserDCache.GetOperatorIdAsync();
            ipo.CurrencyId = await globalUserDCache.GetCurrencyIdAsync();
            ipo.CountryId = await globalUserDCache.GetCountryIdAsync();
            //获取充值、提现渠道
            ipo.BraPayChannel = await LobbyUtil.GetPayChannel(ipo.OperatorId, ipo.CurrencyId, ipo.CountryId);

            switch (ipo.BraPayChannel)
            {
                case BraPayChannel.tejeepay:
                    ret = await GetTejeePayBankListAsync(ipo);
                    break;
                case BraPayChannel.letspay:
                    ret = await GetLetsPayBankListAsync(ipo);
                    break;
                case BraPayChannel.mlpay:
                    break;
                case BraPayChannel.bfpay:
                    break;
                default:
                    throw new CustomException(LobbyCodes.RS_UNKNOWN, "pay channel error.");
            }

            return ret;
        }


        /// <summary>
        /// 获取tejeePay银行列表
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        /// <exception cref="CustomException"></exception>
        public async Task<ChannelBankListDto> GetTejeePayBankListAsync(ChannelBankListIpo ipo)
        {
            var ret = new ChannelBankListDto();

            try
            {
                var tejeePayClient = new TejeepayClient();

                var request = new XxyyTejeeBankListIpo() {
                    UserId = ipo.UserId,
                    AppId = ipo.AppId,
                    CountryId = ipo.CountryId
                };

                var response = await tejeePayClient.BankList(request);

                LogUtil.Info($"lobby_GetTejeePayBankListAsync,request:{JsonConvert.SerializeObject(request)},response:{JsonConvert.SerializeObject(response)}");

                if (!response.Success || response.Status != 200)
                {
                    LogUtil.GetContextLogger().AddMessage($"lobby_GetTejeePayBankListAsync,request:{JsonConvert.SerializeObject(request)},response:{JsonConvert.SerializeObject(response)}");
                    throw new CustomException(LobbyCodes.RS_TEJEEPAY_BANKLIST_ERROR, "tejeePay banklist failed.");
                }

                if (response.Result == null || !response.Result.Any())
                    return ret;

                ret.BankList = response.Result.Map<List<ChannelBankItem>>();
                return ret;
            }
            catch (Exception ex)
            {
                throw new CustomException(LobbyCodes.RS_TEJEEPAY_BANKLIST_ERROR, $"{ex.Message}");
            }
        }

        /// <summary>
        /// 获取letsPay银行列表
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        /// <exception cref="CustomException"></exception>
        public async Task<ChannelBankListDto> GetLetsPayBankListAsync(ChannelBankListIpo ipo)
        {
            var ret = new ChannelBankListDto();

            try
            {
                var letsPayClient = new LetspayClient();

                var request = new XxyyGetBankListIpo()
                {
                    UserId = ipo.UserId,
                    AppId = ipo.AppId,
                    CountryId = ipo.CountryId
                };

                var response = await letsPayClient.BankList(request);

                LogUtil.Info($"lobby_GetLetsPayBankListAsync,request:{JsonConvert.SerializeObject(request)},response:{JsonConvert.SerializeObject(response)}");

                if (!response.Success || response.Status != 200)
                {
                    LogUtil.GetContextLogger().AddMessage($"lobby_GetLetsPayBankListAsync,request:{JsonConvert.SerializeObject(request)},response:{JsonConvert.SerializeObject(response)}");
                    throw new CustomException(LobbyCodes.RS_LETSPAY_BANKLIST_ERROR, "tejeePay banklist failed.");
                }

                if (response.Result == null || !response.Result.Any())
                    return ret;

                ret.BankList = response.Result.Map<List<ChannelBankItem>>();
                return ret;
            }
            catch (Exception ex)
            {
                throw new CustomException(LobbyCodes.RS_LETSPAY_BANKLIST_ERROR, $"{ex.Message}");
            }
        }

        /// <summary>
        /// 添加、更新银行卡（兼容墨西哥 + 巴西）
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        public async Task<bool> AddLobbyBank(AddLobbyBankIpo ipo)
        {
            var ret = false;
            var globalUserDCache = await GlobalUserDCache.Create(ipo.UserId);
            ipo.OperatorId = await globalUserDCache.GetOperatorIdAsync();
            ipo.CountryId = await globalUserDCache.GetCountryIdAsync();
            ipo.CurrencyId = await globalUserDCache.GetCurrencyIdAsync();

            ipo.BraPayChannel = await LobbyUtil.GetPayChannel(ipo.OperatorId, ipo.CurrencyId, ipo.CountryId);

            var addLobbyBankService = AddLobbyBankServiceFactory<AddLobbyBankIpo>.CreateService(ipo.CountryId);

            if (!await addLobbyBankService.CheckIpo(ipo))
                return false;

            switch (ipo.BraPayChannel)
            {
                //目前不支持pandaPay（墨西哥 + 巴西）
                case BraPayChannel.hubtel:
                case BraPayChannel.pandapay:
                    ret = false;
                    break;
                case BraPayChannel.tejeepay:
                case BraPayChannel.letspay:
                case BraPayChannel.mlpay:
                case BraPayChannel.bfpay:
                    ret = await addLobbyBankService.AddLobbyBank(ipo);
                    break;
                default:
                    throw new CustomException(LobbyCodes.RS_UNKNOWN, "AddBraBank channel error.");
            }
            return ret;
        }

        /// <summary>
        /// 删除银行卡
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        public async Task<bool> DeleteLobbyBank(DeleteBankIpo ipo)
        {
            var globalUserDCache = await GlobalUserDCache.Create(ipo.UserId);
            ipo.OperatorId = await globalUserDCache.GetOperatorIdAsync();
            ipo.CurrencyId = await globalUserDCache.GetCurrencyIdAsync();

            var tm = new DbTransactionManager();

            try
            {
                tm.Begin();

                await tm.GetRepository<L_bra_user_bankPO>()
                    .DeleteAsync(d => d.UserID.Equals(ipo.UserId) 
                                        && d.UserBankID.Equals(ipo.UserBankId) 
                                        && d.OperatorID.Equals(ipo.OperatorId) 
                                        && d.CurrencyID.Equals(ipo.CurrencyId)
                    );

                tm.Commit();

                await new BraUserBankDCache(ipo.OperatorId, ipo.UserId).KeyDeleteAsync();

                return true;
            }
            catch (Exception ex)
            {
                tm.Rollback();
                LogUtil.GetContextLogger().AddException(ex).AddMessage("LobbyBankService.DeleteLobbyBank,error.");
                throw new CustomException("delete error.");
            }
        }

    }
}
