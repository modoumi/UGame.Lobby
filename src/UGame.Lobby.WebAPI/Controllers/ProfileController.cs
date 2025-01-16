using UGame.Lobby.Service.Common;
using UGame.Lobby.Service.Services.LobbyBank;
using UGame.Lobby.Service.Services.LobbyBank.IpoDto;
using UGame.Lobby.Service.Services.Profile;
using UGame.Lobby.Service.Services.Profile.Bra;
using Lobby.Flow;
using Lobby.Flow.IpoDto;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using AiUo.AspNet;
using AiUo.AspNet.ClientSign;
using AiUo.Extensions.StackExchangeRedis;
using Xxyy.Common;
using BraUserIpo = UGame.Lobby.Service.Services.Profile.BraUserIpo;

namespace UGame.Lobby.WebAPI.Controllers;

/// <summary>
/// ProfileController
/// </summary>
[EnableCors()]
[ClientSignFilter()]
public class ProfileController : AiUoControllerBase
{

    private ProfileService _profileService = new();


    /// <summary>
    /// 提现页面加载
    /// </summary>
    /// <returns></returns>
    [HttpPost]
    public async Task<CashLoadDto> CashLoad(CashLoadIpo ipo)
    {
        ipo.UserId = base.UserId;
        return await _profileService.CashLoad(ipo);
    }


    /// <summary>
    /// 个人信息表单模板
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<List<PersonalInfoFormDto>> Form([FromBody] PersonalInfoFormIpo ipo)
    {
        ipo.UserId = base.UserId;
        return await _profileService.GetForm(ipo);
    }

    /// <summary>
    /// 获取个人信息
    /// </summary>
    /// <returns></returns>
    [HttpPost]
    public async Task<PersonalInfoDto> Info([FromBody] GetPersonIpo ipo)
    {
        ipo.UserId = base.UserId;
        return await _profileService.GetInfo(base.UserId);
    }

    /// <summary>
    /// 更新个人信息
    /// </summary>
    /// <returns></returns>
    [HttpPost]
    public async Task<PersonalInfoDto> Modify([FromBody] PersonalInfoIpo ipo)
    {
        ipo.UserId = base.UserId;
        return await _profileService.Modify(ipo);
    }

    ///// <summary>
    ///// 查询用户银行卡列表
    ///// </summary>
    ///// <param name="ipo"></param>
    ///// <returns></returns>
    ///// <exception cref="CustomException"></exception>
    //[HttpPost]
    //public async Task<List<BankInfosDto>> GetBanks([FromBody] GetBankInfosIpo ipo)
    //{
    //    ipo.UserId = base.UserId;
    //    return await _profileService.GetBanks(ipo);
    //}

    ///// <summary>
    ///// 用户添加\更新银行卡
    ///// </summary>
    ///// <param name="ipo"></param>
    ///// <returns></returns>
    //[HttpPost]
    //public async Task<bool> AddBank([FromBody] AddBankInfoIpo ipo)
    //{
    //    ipo.UserId = base.UserId;

    //    return await _profileService.AddBank(ipo);
    //}

    ///// <summary>
    ///// 获取一条银行卡信息
    ///// </summary>
    ///// <param name="ipo"></param>
    ///// <returns></returns>
    ///// <exception cref="CustomException"></exception>
    //[HttpPost]
    //public async Task<BankInfosDto> SingleBank([FromBody] GetBankInfosIpo ipo)
    //{
    //    ipo.UserId = base.UserId;
    //    return await _profileService.GetSingleBank(ipo);
    //}

    /// <summary>
    /// 获取手机钱包支付渠道（加纳）
    /// </summary>
    /// <returns></returns>
    [HttpPost]
    public async Task<List<string>> HubtelChannels(HubtelChannelsIpo ipo)
    {
        throw new CustomException(LobbyCodes.RS_ILLEGAL_REQUEST, "illegal request.");

        ipo.UserId = base.UserId;
    }

    #region 加纳 充值、提现

    /// <summary>
    /// Hubtel充值（加纳）
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<DepositOrWithdrawDto> HubtelDeposit(DepositOrWithdrawIpo ipo)
    {
        throw new CustomException(LobbyCodes.RS_ILLEGAL_REQUEST, "illegal request.");

        ipo.UserId = base.UserId;
    }

    /// <summary>
    /// Hubtel提现（加纳）
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<DepositOrWithdrawDto> HubtelWithdraw(DepositOrWithdrawIpo ipo)
    {
        throw new CustomException(LobbyCodes.RS_ILLEGAL_REQUEST, "illegal request.");

        ipo.UserId = base.UserId;
    }

    #endregion


    #region 巴西

    /// <summary>
    /// 充值时补充用户tax信息
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    /// <exception cref="CustomException"></exception>
    [HttpPost]
    public async Task<string> AddBraUser(BraUserIpo ipo)
    {
        throw new CustomException(LobbyCodes.RS_ILLEGAL_REQUEST, "illegal request.");

        ipo.UserId = base.UserId;
    }

    ///// <summary>
    ///// 巴西添加、更新银行卡
    ///// </summary>
    ///// <param name="ipo"></param>
    ///// <returns></returns>
    //[HttpPost]
    //public async Task<bool> AddBraBank([FromBody] BRAAddBankIpo ipo)
    //{
    //    ipo.UserId = base.UserId;
    //    return await _profileService.AddBraBank(ipo);
    //}

    /// <summary>
    /// 添加、更新银行卡（兼容墨西哥 + 巴西）
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<bool> AddLobbyBank(AddLobbyBankIpo ipo)
    {
        ipo.UserId = base.UserId;
        return await new LobbyBankService().AddLobbyBank(ipo);
    }


    /// <summary>
    /// 获取单条银行卡信息
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<BraBankQueryDto> SingleBank(BraBankQueryIpo ipo)
    {
        ipo.UserId = base.UserId;
        return await _profileService.SingleBraBank(ipo);
    }

    /// <summary>
    /// 巴西银行卡列表
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<List<BraBankQueryDto>> GetBanks(BraBankQueryIpo ipo)
    {
        ipo.UserId = base.UserId;
        return await _profileService.GetBraBanks(ipo);
    }

    #region lobbyBank

    /// <summary>
    /// 获取支付渠道支持的银行列表
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<ChannelBankListDto> ChannelBankList(ChannelBankListIpo ipo)
    {
        ipo.UserId = base.UserId;
        return await new LobbyBankService().GetChannelBankListAsync(ipo);
    }

    /// <summary>
    /// 删除银行卡
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<bool> DeleteLobbyBank(DeleteBankIpo ipo)
    {
        ipo.UserId = base.UserId;
        return await new LobbyBankService().DeleteLobbyBank(ipo);
    }


    #endregion


    /// <summary>
    /// 充值
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<BraDepositDto> Deposit(BraDepositIpo ipo)
    {
        ipo.UserId = base.UserId;
        return await _profileService.DepositAsync(ipo);
    }

    /// <summary>
    /// 提现
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<BraWithDrawDto> Withdraw(BraWithDrawIpo ipo)
    {
        ipo.UserId = base.UserId;
        using (var redlock = await RedisUtil.LockAsync($"lobby:WithDraw:{base.UserId}", 30))
        {
            if (!redlock.IsLocked)
            {
                redlock.Release();
                throw new CustomException(CommonCodes.UserConcurrent, $"WithDraw.Request for lock failed.userId:{ipo.UserId}");
            }
            var flowService = FlowServiceFactory.CreateFlowService(ipo.UserId, ipo.AppId, ipo.OperatorId);
            var flowIpo = new FlowCashIpo
            {
                AppId = ipo.AppId,
                OperatorId = ipo.OperatorId,
                UserId = ipo.UserId,
                Mobile=ipo.Mobile,
                Channel = "",
                Channels = ipo.Channels,
                Amount = ipo.Amount,
                CountryId = ipo.CountryId,
                CurrencyId = ipo.CurrencyId,
                LangId = ipo.LangId,
                UserBankId = ipo.UserBankId,
                AccountNo = ipo.AccountNo,
                CashType = ipo.CashType,
                TaxId = ipo.TaxId,
                AdditionalParameters=ipo.AdditionalParameters
            };
            var ret = await flowService.RequestCash(flowIpo);
            return new BraWithDrawDto
            {
                CurrencyId = ret.CurrencyId,
                CountryId = ret.CountryId,
                Amount = ret.Amount,
                Balance = ret.Balance,
                IsAudit = ret.IsAudit,
                Message = ret.Message,
                Meta = ret.Meta,
                OperatorId = ret.OperatorId,
                OrderId = ret.OrderId,
                RequestUUID = "",
                Status = ret.Status,
                Success = ret.Success,
                UserId = ret.UserId
            };
        }
    }

    /// <summary>
    /// 巴西充值
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    [HttpPost]
    [Obsolete("使用ProfileController.Pay")]
    public async Task<BraDepositDto> BraDeposit(BraDepositIpo ipo)
    {
        throw new CustomException(LobbyCodes.RS_ILLEGAL_REQUEST, "illegal request.");
        ipo.UserId = base.UserId;
        return await _profileService.BraDeposit(ipo);
    }

    /// <summary>
    /// 巴西提现
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    [HttpPost]
    [Obsolete("使用ProfileController.Cash")]
    public async Task<BraWithDrawDto> BraWithDraw(BraWithDrawIpo ipo)
    {
        throw new CustomException(LobbyCodes.RS_ILLEGAL_REQUEST, "illegal request.");
        ipo.UserId = base.UserId;
        using (var redlock = await RedisUtil.LockAsync($"lobby:BraWithDraw:{base.UserId}", 30))
        {
            if (!redlock.IsLocked)
            {
                redlock.Release();
                throw new CustomException(CommonCodes.UserConcurrent, $"BraWithDraw.Request for lock failed.userId:{ipo.UserId}");
            }

            return await _profileService.BraWithDraw(ipo);
        }
    }

    #endregion

    #region Spei

    /// <summary>
    /// Spei充值
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<SpeiDepositDto> SpeiDeposit(SpeiDepositIpo ipo)
    {
        throw new CustomException(LobbyCodes.RS_ILLEGAL_REQUEST, "illegal request.");
        ipo.UserId = base.UserId;
        return await _profileService.SpeiDeposit(ipo);
    }

    /// <summary>
    /// 提现确认
    /// </summary>
    /// <returns></returns>
    [HttpPost]
    public async Task<CashConfirmDto> CashConfirm(SpeiWithdrawIpo ipo)
    {
        ipo.UserId = base.UserId;
        return await _profileService.CashConfirm(ipo);
    }

    /// <summary>
    /// 提现手续费
    /// </summary>
    /// <returns></returns>
    [HttpPost]
    public async Task<CashFeeDto> CashFee(CashFeeIpo ipo)
    {
        //ipo.AdditionalParameters=ipo.AdditionalParameters!=null?JsonConvert.DeserializeObject<Dictionary<string,string>>(Convert.ToString(ipo.AdditionalParameters)):null;
        ipo.UserId = base.UserId;
        return await _profileService.CashFee(ipo);
    }

    /// <summary>
    /// Spei提现（审批版）
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<SpeiDepositOrWithdrawDto> SpeiWithdraw(SpeiWithdrawIpo ipo)
    {
        throw new CustomException(LobbyCodes.RS_ILLEGAL_REQUEST, "illegal request.");
        ipo.UserId = base.UserId;
        using (var redlock = await RedisUtil.LockAsync($"lobby:SpeiWithdraw:{base.UserId}", 20))
        {
            if (!redlock.IsLocked)
            {
                redlock.Release();
                throw new CustomException(CommonCodes.UserConcurrent, $"SpeiWithdraw.Request for lock failed.userId:{ipo.UserId}");
            }

            return await _profileService.SpeiWithdraw(ipo);
        }
    }

    /// <summary>
    /// 获取Spei支持的银行列表
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<List<SpeiBanksDto>> SpeiBanks(SpeiBanksIpo ipo)
    {
        throw new CustomException(LobbyCodes.RS_ILLEGAL_REQUEST, "illegal request.");
        ipo.UserId = base.UserId;
        return await _profileService.SpeiBanks(ipo);
    }

    #endregion

    /// <summary>
    /// 获取订单信息
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<OrderDto> GetOrder(OrderIpo ipo)
    {
        ipo.UserId = base.UserId;
        return await _profileService.GetOrder(ipo);
    }

    #region 充值、提现、bonus奖励、下注记录

    /// <summary>
    /// 用户充值记录
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<List<PayCashRecordsDto>> PayRecords(UserRecordsIpo ipo)
    {
        ipo.UserId = base.UserId;
        if (ipo.StartDate != null || ipo.EndDate != null)
            await CheckRecords(ipo.StartDate, ipo.EndDate);

        return await _profileService.PayRecords(ipo);
    }

    /// <summary>
    /// 用户提现记录
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<List<PayCashRecordsDto>> CashRecords(UserRecordsIpo ipo)
    {
        ipo.UserId = base.UserId;
        if (ipo.StartDate != null && ipo.EndDate != null)
            await CheckRecords(ipo.StartDate, ipo.EndDate);

        return await _profileService.CashRecords(ipo);
    }

    /// <summary>
    /// Bonus奖励记录
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<List<PayCashRecordsDto>> BonusRecords(UserRecordsIpo ipo)
    {
        ipo.UserId = base.UserId;
        if (ipo.StartDate != null && ipo.EndDate != null)
            await CheckRecords(ipo.StartDate, ipo.EndDate);

        return await _profileService.BonusRecords(ipo);
    }

    /// <summary>
    /// 查询下注记录明细，（单位：天）
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<BetRecordDto> BetRecordsDay(BetRecordDayIpo ipo)
    {
        ipo.UserId = base.UserId;
        if (ipo.StartDate != null && ipo.EndDate != null)
            await CheckRecords(ipo.StartDate, ipo.EndDate);

        return await _profileService.BetRecordsDay(ipo);
    }

    /// <summary>
    /// 查询下注记录明细，（单位：每一笔下注）
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<BetRecordDto> BetRecordsDetail(BetRecordDetailIpo ipo)
    {
        ipo.UserId = base.UserId;

        if (ipo.StartDate != null && ipo.EndDate != null)
            await CheckRecords(ipo.StartDate, ipo.EndDate);

        return await _profileService.BetRecordsDetail(ipo);
    }

    /// <summary>
    /// 校验充值、提现、bonus奖励、下注记录日期参数
    /// </summary>
    /// <param name="startDate"></param>
    /// <param name="endDate"></param>
    /// <param name="maxDay">最大查询数据的天数</param>
    /// <returns></returns>
    /// <exception cref="CustomException"></exception>
    private async Task CheckRecords(DateTime? startDate, DateTime? endDate, int maxDay = 90)
    {
        if (!startDate.HasValue || !endDate.HasValue ||
            startDate.Value > endDate.Value ||
            (endDate.Value - startDate.Value).TotalDays > maxDay)
            throw new CustomException(LobbyCodes.RS_PARAMETER_ERROR, "StartDate or EndDate param error.");
    }

    #endregion

    #region ==PGTADA提现渠道信息==

    /// <summary>
    /// 获取提现渠道、用户信息、提现金额及流水额度
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<LoadInfoDto> LoadInfo(LoadInfoIpo ipo)
    {
        ipo.UserId = base.UserId;
        return await _profileService.LoadInfo(ipo);
    }

    #endregion
}
