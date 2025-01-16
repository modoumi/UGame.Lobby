using UGame.Lobby.Common.Enum;
using UGame.Lobby.Repository.ing;
using Lobby.Flow;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Serilog;
using SqlSugar;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using AiUo;
using AiUo.AspNet;
using AiUo.Configuration;
using AiUo.Data;
using AiUo.Data.SqlSugar;
using AiUo.Extensions.AutoMapper;
using AiUo.Extensions.RabbitMQ;
using AiUo.Logging;
using AiUo.Reflection;
using AiUo.Text;
using UGame.Lobby.Service.Caching;
using UGame.Lobby.Service.Caching.Pay;
using UGame.Lobby.Service.Caching.Profile;
using UGame.Lobby.Service.Caching.Profile.Bra;
using UGame.Lobby.Service.Caching.Profile.UserBank;
using UGame.Lobby.Service.Caching.Profile.UserRecords;
using UGame.Lobby.Service.Caching.WithDraw;
using UGame.Lobby.Service.Common;
using UGame.Lobby.Service.Services.Cash;
using UGame.Lobby.Service.Services.Profile.Bra;
using UGame.Lobby.Service.Services.Validates;
using UGame.Lobby.Service.Services.Vip;
using Xxyy.Banks.Client;
using Xxyy.Banks.Client.BLL;
using Xxyy.Banks.Client.BLL.Bfpay;
using Xxyy.Banks.Client.BLL.Hubtel;
using Xxyy.Banks.Client.BLL.Letspay;
using Xxyy.Banks.Client.BLL.Mlpay;
using Xxyy.Banks.Client.BLL.Mongopay;
using Xxyy.Common;
using Xxyy.Common.Caching;
using Xxyy.Common.Services;
using Xxyy.DAL;

namespace UGame.Lobby.Service.Services.Profile;

public class ProfileService
{

    private static string _imageBaseUrl;

    private LobbyOptionsSection _options;

    /// <summary>
    /// SCommonService
    /// </summary>
    public ProfileService()
    {
        _options = ConfigUtil.GetSection<LobbyOptionsSection>();
        _imageBaseUrl = _options.ImageBaseUrl;
    }


    private static object _sync = new object();

    private static Dictionary<string, IValidateField> _validateFieldDic;
    private static Dictionary<string, IValidateField> ValidateFieldDic
    {
        get
        {
            if (_validateFieldDic == null)
            {
                lock (_sync)
                {
                    if (_validateFieldDic == null)
                    {
                        var values = new Dictionary<string, IValidateField>();

                        var types = Assembly.GetExecutingAssembly().GetTypes().Where(d => typeof(IValidateField).IsAssignableFrom(d) && !d.IsAbstract && d.IsClass).Select(d => d);

                        foreach (var item in types)
                        {
                            values.Add(item.Name.ToLower(), (IValidateField)Activator.CreateInstance(item));
                        }
                        _validateFieldDic = values;
                    }
                }
            }
            return _validateFieldDic;
        }
    }


    //private Xxyy.Common.Partners.XxyyBankClient _xxyyBankClient = new();

    private S_provider_orderMO _providerOrderMo = new();

    private L_user_infoMO _userInfoMo = new();

    private L_user_bank_infoMO _userBankInfoMo = new();

    private L_bra_user_bankMO _braUserBankMo = new();

    private L_bra_userMO _braUserMo = new();

    private S_currency_changeMO _currencyChangeMo = new();

    /// <summary>
    /// 提现页面加载
    /// </summary>
    /// <returns></returns>
    public async Task<CashLoadDto> CashLoad(CashLoadIpo ipo)
    {
        var ret = new CashLoadDto();
        ret.EnableBonus = DbCacheUtil.GetOperator(ipo.OperatorId).EnableBonus;

        var globalUserDCache = await GlobalUserDCache.Create(ipo.UserId);
        ipo.OperatorId = await globalUserDCache.GetOperatorIdAsync();
        ipo.CurrencyId = await globalUserDCache.GetCurrencyIdAsync();
        var hasCash = await globalUserDCache.GetHasCashAsync();

        if (hasCash)
            ret.AddBraBank.IsLockMethod = false;
        var flowService = FlowServiceFactory.CreateFlowService(ipo.UserId, ipo.AppId, ipo.OperatorId);

        var flowProgressRet = await flowService.GetFlowProgress();
        if (null == flowProgressRet.FlowOrder)
        {
            flowProgressRet.FlowOrder = new Flow.IpoDto.FlowProgressDto.ProgressRequireFlowOrder
            {
                CompletedFlow = 0,
                RequireFlow = 0
            };
        }
        ret.Flow.CashMoney = flowProgressRet.CashMoney;
        ret.Flow.CompletedFlow = flowProgressRet.FlowOrder.CompletedFlow;
        ret.Flow.RequireFlow = flowProgressRet.FlowOrder.RequireFlow;
        return ret;
    }


    /// <summary>
    /// 查询下注记录明细，（单位：天）
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    public async Task<BetRecordDto> BetRecordsDay(BetRecordDayIpo ipo)
    {
        var ret = new BetRecordDto();

        var userExEo = await DbSink.BuildUserExMo(ipo.UserId).GetSingleAsync("UserID = @UserID", ipo.UserId);

        //总下注
        ret.TotalBet = userExEo.TotalBetAmount.AToM(ipo.CurrencyId);
        //总返奖
        ret.TotalRewardReturn = userExEo.TotalWinAmount.AToM(ipo.CurrencyId);

        var cacheData = await new BetRecordDCache(ipo.UserId).Get();

        if (cacheData == null || !cacheData.Any())
        {
            ret.Items = cacheData
                .WhereIF(ipo.StartDate != null && ipo.EndDate != null, d => d.DayID >= ipo.StartDate.Value.ToLocalTime(ipo.OperatorId).Date
                && d.DayID <= ipo.EndDate.Value.ToLocalTime(ipo.OperatorId).Date)
                .Skip((ipo.PageIndex - 1) * ipo.PageSize)
                .Take(ipo.PageSize).Map<List<BetRecord>>();
            return ret;
        }

        ret.Items = cacheData
            .WhereIF(ipo.StartDate != null && ipo.EndDate != null, d => d.DayID >= ipo.StartDate.Value.ToLocalTime(ipo.OperatorId).Date
            && d.DayID <= ipo.EndDate.Value.ToLocalTime(ipo.OperatorId).Date)
            .Skip((ipo.PageIndex - 1) * ipo.PageSize)
            .Take(ipo.PageSize).Map<List<BetRecord>>();

        return ret;
    }

    /// <summary>
    /// 查询下注记录明细，（单位：每一笔下注）
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    public async Task<BetRecordDto> BetRecordsDetail(BetRecordDetailIpo ipo)
    {
        var ret = new BetRecordDto();

        var orderDetail = await DbUtil.GetRepository<S_provider_orderPO>().AsQueryable()
            .WhereIF(ipo.StartDate != default && ipo.EndDate != default, _ => _.UserID == ipo.UserId && _.RecDate >= ipo.StartDate.Value && _.RecDate < ipo.EndDate.Value
            && _.OperatorID == ipo.OperatorId && _.CurrencyID == ipo.CurrencyId && _.Status == 2)
            .WhereIF(ipo.StartDate == default && ipo.EndDate == default, _ => _.UserID == ipo.UserId && _.OperatorID == ipo.OperatorId && _.CurrencyID == ipo.CurrencyId && _.Status == 2)
            .OrderByDescending(_ => _.RecDate)
            .Skip((ipo.PageIndex - 1) * ipo.PageSize)
            .Take(ipo.PageSize).ToListAsync();

        ret.Items = orderDetail.Map<List<BetRecord>>();

        if (ret.Items != null && ret.Items.Any())
        {
            foreach (var item in ret.Items)
            {
                item.AppName = DbCacheUtil.GetAppLang(item.AppId, ipo.LangId).AppName;
            }
        }
        ret.TotalBet = ret.Items.Select(_ => _.Bet).Sum() + ret.Items.Select(_ => _.BetBonus).Sum();
        ret.TotalRewardReturn = ret.Items.Select(_ => _.Reward).Sum() + ret.Items.Select(_ => _.WinBonus).Sum();
        return ret;
    }

    #region 个人信息

    /// <summary>
    /// 生成个人信息表单
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    public async Task<List<PersonalInfoFormDto>> GetForm(PersonalInfoFormIpo ipo)
    {
        var personalInfoFormDCache = new PersonalInfoFormDCache(ipo.CountryId, ipo.LangId);
        var ret = await personalInfoFormDCache.GetAsync();

        if (!ret.HasValue)
            return new List<PersonalInfoFormDto>();

        return ret.Value;
    }

    /// <summary>
    /// 获取个人信息
    /// </summary>
    /// <param name="userId"></param>
    /// <returns></returns>
    public async Task<PersonalInfoDto> GetInfo(string userId)
    {
        var ret = await new PersonalInfoDCache(userId).GetAsync();

        if (!ret.HasValue) return new PersonalInfoDto();

        return ret.Value.Map<PersonalInfoDto>();
    }

    /// <summary>
    /// 更新个人信息
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    public async Task<PersonalInfoDto> Modify(PersonalInfoIpo ipo)
    {
        try
        {
            await Validate(ipo);

            //从缓存中获取当前用户个人信息
            var personalInfoDCache = new PersonalInfoDCache(ipo.UserId);
            var ret = await personalInfoDCache.GetAsync();
            //获取与当前国家、语言匹配的表单字段
            var personalInfoFormDCache = new PersonalInfoFormDCache(ipo.CountryId, ipo.LangId);
            var formRet = await personalInfoFormDCache.GetAsync();

            //更新的sql语句
            var modifySql = new StringBuilder();
            //sql参数化
            List<MySqlParameter> paramList = new List<MySqlParameter>();
            //反射获取ipo所有属性
            var propertyInfos = ipo.GetType().GetProperties();

            foreach (var item in propertyInfos)
            {
                //获取符合当前国家的表单模板
                var formItem = formRet.Value.Where(d => d.UIFieldID.ToLower().Equals(item.Name.ToLower())).FirstOrDefault();
                if (formItem != null)
                {
                    if (!formItem.IsAllowModify) continue;

                    var name = ReflectionUtil.GetPropertyValue(ipo, item.Name);
                    modifySql.Append($"{item.Name} = @{item.Name}");
                    if (!formItem.UIFieldID.Equals(formRet.Value.Last().UIFieldID))
                        modifySql.Append(",");

                    var value = ReflectionUtil.GetPropertyValue(ipo, item.Name);

                    if (formItem.DBType.HasValue && formItem.DBType == (int)FormDbType.datetime)
                        value = DateTime.ParseExact(value.ToString(), "dd-MM-yyyy", System.Globalization.CultureInfo.CurrentCulture);

                    paramList.Add(new MySqlParameter($"@{item.Name}", value));
                }
            }

            paramList.Add(new MySqlParameter($"@UserID", ipo.UserId));

            await _userInfoMo.PutAsync(modifySql.ToString(), "UserID = @UserID", paramList);

            //更新缓存
            await personalInfoDCache.SetAsync();

            ret = await personalInfoDCache.GetAsync();

            return ret.Value.Map<PersonalInfoDto>();
        }
        catch (Exception ex)
        {
            LogUtil.GetContextLogger().AddException(ex).AddMessage($"Modify.ipo:{JsonConvert.SerializeObject(ipo)}");
            throw new CustomException(LobbyCodes.RS_UNKNOWN, "Modify failed.");
        }
    }

    /// <summary>
    /// 验证表单
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    private static async Task Validate(PersonalInfoIpo ipo)
    {

        var propertyInfos = ipo.GetType().GetProperties();

        foreach (var item in propertyInfos)
        {
            if (ValidateFieldDic.ContainsKey(item.Name.ToLower() + "validate"))
            {
                await ValidateFieldDic[item.Name.ToLower() + "validate"].Check(ReflectionUtil.GetPropertyValue(ipo, item.Name).ToString(), ipo.CountryId);
            }
        }

    }

    #endregion

    #region 银行卡

    /// <summary>
    /// 用户添加银行卡
    /// </summary>
    /// <returns></returns>
    public async Task<bool> AddBank(AddBankInfoIpo ipo)
    {
        //获取缓存中的用户银行卡列表
        var userBanksDCache = new MexUserBanksDCache(ipo.OperatorId, ipo.UserId);
        var userBankData = await userBanksDCache.GetAsync();
        //获取Spei支持的银行卡列表
        var speiBanksDCache = SpeiBanksDCache.Create();
        var speiBanksData = await speiBanksDCache.GetOrLoadAsync();

        if (
            !string.IsNullOrWhiteSpace(ipo.BankCode)
            && speiBanksData != null
            && speiBanksData.HasValue
            && speiBanksData.Value.Any(d => d.BankCode.Equals(ipo.BankCode)
            && d.BankName.Equals(ipo.BankName))
        )
        {
            //支持Spei提现的银行
            ipo.BankType = 2;
        }

        var result = 0;

        //更新
        if (!string.IsNullOrWhiteSpace(ipo.UserBankID) && userBankData.Value != null && userBankData.Value.Any(d => d.UserBankID.Equals(ipo.UserBankID)))
        {
            var cacheUserBankInfo = userBankData.Value.Where(d => d.UserBankID.Equals(ipo.UserBankID)).FirstOrDefault();
            result = await _userBankInfoMo.PutAsync(ipo.Map<L_user_bank_infoEO>());
        }
        //添加
        else
        {
            ipo.UserBankID = ObjectId.NewId();
            result = await _userBankInfoMo.AddAsync(ipo.Map<L_user_bank_infoEO>());
        }

        //更新缓存
        if (result > 0)
            await userBanksDCache.GetOrLoadAsync(true);

        return result > 0;
    }

    /// <summary>
    /// 获取用户银行卡列表
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public async Task<List<BankInfosDto>> GetBanks(GetBankInfosIpo ipo)
    {
        var userBanksDCache = new MexUserBanksDCache(ipo.OperatorId, ipo.UserId);

        var cacheData = await userBanksDCache.GetAsync();

        List<BankInfosDto> ret = null;

        if (cacheData.HasValue)
        {
            ret = cacheData.Value.Map<List<BankInfosDto>>();
            ret = ret.OrderByDescending(d => d.RecDate).ToList();
            switch (ipo.SortType)
            {
                case 2:
                    ret = ret.OrderByDescending(d => d.BankType).ThenByDescending(d => d.LastUsing).ThenByDescending(d => d.RecDate).ToList();
                    break;
                default:
                    ret = ret.OrderByDescending(d => d.LastUsing).ThenByDescending(d => d.RecDate).ToList();
                    break;
            }
        }

        return ret;
    }

    /// <summary>
    /// 获取一条银行卡信息
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    public async Task<BankInfosDto> GetSingleBank(GetBankInfosIpo ipo)
    {
        //获取缓存中的用户银行卡列表
        var userBanksDCache = new MexUserBanksDCache(ipo.OperatorId, ipo.UserId);
        var userBankData = await userBanksDCache.GetAsync();
        if (!userBankData.HasValue || !userBankData.Value.Any(d => d.UserBankID.Equals(ipo.UserBankId)))
            throw new Exception($"未找到银行卡信息.UserBankId:{ipo.UserBankId}");

        var ret = userBankData.Value.Where(d => d.UserBankID.Equals(ipo.UserBankId)).FirstOrDefault();

        return ret.Map<BankInfosDto>();

    }

    #endregion

    #region 巴西

    /// <summary>
    /// 充值时补充用户tax信息
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    public async Task<string> AddBraUser(BraUserIpo ipo)
    {
        var braUser = await new BraUserDCache(ipo.UserId).GetOrLoadAsync();

        if (braUser.HasValue)
            throw new CustomException("Data already exists.");

        var xxyyBankClient = new Xxyy.Banks.Client.BLL.Pandapay.PandapayClient();

        var response = await xxyyBankClient.PandaPay(ipo.Map<Xxyy.Banks.Client.BLL.Pandapay.XxyyPandapayIpo>());

        Log.Information($"AddBraUser,request:{JsonConvert.SerializeObject(ipo)},response:{JsonConvert.SerializeObject(response)}");

        if (!response.Status.Equals(ResponseCodes.RS_OK))
        {
            var exception = new CustomException($"request:{JsonConvert.SerializeObject(ipo)},response:{JsonConvert.SerializeObject(response)},status:{response.Status}");

            LogUtil.GetContextLogger().AddException(exception).AddMessage($"request:{JsonConvert.SerializeObject(ipo)},response:{JsonConvert.SerializeObject(response)},status:{response.Status}");

            throw new CustomException("AddBraUser,PandaPay failed.");
        }

        var mo = new L_bra_userMO();

        var success = await mo.AddAsync(ipo.Map<L_bra_userEO>()) > 0;
        if (!success)
            throw new CustomException("Add failed.");

        return response.Result.BarCode;
    }

    /// <summary>
    /// 获取充值、提现渠道
    /// </summary>
    /// <param name="operatorId"></param>
    /// <param name="currencyId"></param>
    /// <returns></returns>
    public async Task<BraPayChannel> GetPayChannel(string operatorId, string currencyId)
    {
        //默认渠道tejeepay
        var ret = BraPayChannel.tejeepay;
        //bank记录的所有支付记录成功or失败次数记录
        var bankErrorDic = await LobbyUtil.GetAllBankChannel();
        var payConfigEoList = await new PayConfigDCache().GetAsync(operatorId, currencyId);

        if (bankErrorDic == null || bankErrorDic.Count == 0 || bankErrorDic.Keys.Count == 0)
        {
            if (!payConfigEoList.Any())
                return ret;

            //默认取第一条主渠道
            var payConfigEo = payConfigEoList.Where(d => d.IsMainChannel)?.FirstOrDefault();
            //如果没有设置主渠道，则直接获取最新的支付渠道
            if (payConfigEo == null)
            {
                payConfigEo = payConfigEoList.OrderByDescending(d => d.Channels).FirstOrDefault();
            }

            var payConfigEoChannel = payConfigEo.ChannelsDesc.ToEnumN<BraPayChannel>();
            if (!payConfigEoChannel.HasValue)
                return ret;
            return payConfigEoChannel.Value;
        }
        else
        {
            if (!payConfigEoList.Any())
            {
                //值越小成功率越高
                var bankError = bankErrorDic.OrderBy(d => d.Value).First();
                var bankErrorEnum = bankError.Key.ToEnumN<BraPayChannel>();
                if (!bankErrorEnum.HasValue)
                    return ret;
                return bankErrorEnum.Value;
            }
            else
            {
                var payConfigChannel = payConfigEoList.Select(d => d.ChannelsDesc).Distinct().ToList();
                var existsChannel = false;
                foreach (var item in bankErrorDic.OrderBy(d => d.Value))
                {
                    var channel = item.Key.ToEnumN<BraPayChannel>();
                    if (!channel.HasValue)
                        continue;

                    if (payConfigChannel.Contains(item.Key))
                    {
                        ret = item.Key.ToEnum<BraPayChannel>();
                        existsChannel = true;
                        break;
                    }
                }
                if (!existsChannel)
                    return ret;
            }
        }

        return ret;
    }

    /// <summary>
    /// 获取充值、提现渠道
    /// </summary>
    /// <param name="operatorId"></param>
    /// <param name="currencyId"></param>
    /// <returns></returns>
    /// <exception cref="CustomException"></exception>
    //public async Task<BraPayChannel> GetBraPayChannel(string operatorId, string currencyId)
    //{
    //    var payChannel = await LobbyUtil.GetBankChannel(operatorId, currencyId);

    //    if (payChannel != 0)
    //        return payChannel.ToEnum<BraPayChannel>();

    //    var field = PayConfigDCache.GetField(operatorId, currencyId);

    //    var payConfigDCache = await new PayConfigDCache().GetOrLoadAsync(field);

    //    if (!payConfigDCache.HasValue)
    //        return BraPayChannel.tejeepay;

    //    //默认渠道
    //    var ret = BraPayChannel.tejeepay;

    //    if (payConfigDCache.HasValue)
    //    {
    //        //优先PIX 1,其次找主渠道，最后找最新的渠道
    //        var braPayChannel = payConfigDCache.Value.OrderBy(d => d.ChannelsGroup).OrderByDescending(d => d.IsMainChannel).OrderByDescending(d => d.Channels).FirstOrDefault().Channels.ToEnumN<BraPayChannel>();

    //        if (braPayChannel.HasValue)
    //            ret = braPayChannel.Value;
    //    }

    //    return ret;
    //}


    /// <summary>
    /// 添加、更新银行卡
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    public async Task<bool> AddBraBank(BRAAddBankIpo ipo)
    {
        var ret = false;

        ipo.BraPayChannel = await LobbyUtil.GetPayChannel(ipo.OperatorId, ipo.CurrencyId, ipo.CountryId);

        switch (ipo.BraPayChannel)
        {
            case BraPayChannel.pandapay:
                ret = false;
                //ret = await AddBraPandaPayBank(ipo);
                break;
            case BraPayChannel.tejeepay:
            case BraPayChannel.letspay:
                ret = await AddBraBankProcess(ipo);
                //ret = await AddBraTejeePayBank(ipo);
                break;
            default:
                throw new CustomException(LobbyCodes.RS_UNKNOWN, "AddBraBank channel error.");
        }
        return ret;
    }

    /// <summary>
    /// 校验添加银行卡参数
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    private async Task<bool> CheckBraAddBankParam(BRAAddBankIpo ipo)
    {
        if (string.IsNullOrWhiteSpace(ipo.AccName))
            throw new CustomException(LobbyCodes.RS_PARAMETER_ERROR, "AccName cannot be empty.");
        if (string.IsNullOrWhiteSpace(ipo.TaxId))
            throw new CustomException(LobbyCodes.RS_PARAMETER_ERROR, "TaxId cannot be empty.");
        if (string.IsNullOrWhiteSpace(ipo.Key))
            throw new CustomException(LobbyCodes.RS_PARAMETER_ERROR, "Key cannot be empty.");

        switch (ipo.BraPayChannel)
        {
            case BraPayChannel.pandapay:
                return true;
            case BraPayChannel.tejeepay:
            case BraPayChannel.letspay:
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
    }

    #region 添加银行卡（pandapay)

    /// <summary>
    /// pandapay添加银行卡主逻辑
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    /// <exception cref="CustomException"></exception>
    private async Task<bool> AddBraPandaPayBank(BRAAddBankIpo ipo)
    {
        var ret = false;

        if (!await CheckBraAddBankParam(ipo))
            throw new CustomException(LobbyCodes.RS_PARAMETER_ERROR, "param error.");

        var checkKeyRet = await CheckBraBankKey(ipo);

        //验证key是否有效
        if (!checkKeyRet.success)
            throw new CustomException(ResponseCodes.RS_UNKNOWN, "Invalid key.");

        //获取缓存中的用户银行卡列表
        var braUserBankDCache = new BraUserBankDCache(ipo.OperatorId, ipo.UserId);
        var userBankData = await braUserBankDCache.GetOrLoadAsync();

        //获取巴西用户
        var braUserDCache = new BraUserDCache(ipo.UserId);
        var braUser = await braUserDCache.GetOrLoadAsync();

        var result = false;

        TransactionManager tm = new TransactionManager();

        try
        {
            if (!string.IsNullOrWhiteSpace(ipo.UserBankId)
            && userBankData.Value != null
            && userBankData.Value.Any(d => d.UserBankID.Equals(ipo.UserBankId)))
            {
                var cacheUserBankInfo = userBankData.Value.Where(d => d.UserBankID.Equals(ipo.UserBankId)).FirstOrDefault();

                var braUserBank = await _braUserBankMo.GetSingleAsync("UserID = @UserID and KeyCode = @KeyCode", tm, ipo.UserId, ipo.Key);

                if (braUserBank != null && !braUserBank.UserBankID.Equals(ipo.UserBankId))
                    throw new CustomException(ResponseCodes.RS_UNKNOWN, $"Repeat addition.");

                //await _braUserBankMo.PutAsync("Name = @Name, TaxId = @TaxId", "UserID = @UserID", tm, ipo.AccName, ipo.TaxId, ipo.UserId);

                await _braUserBankMo.PutAsync("Name = @Name, TaxId = @TaxId, KeyCode = @Keys", "UserID = @UserID and UserBankID = @UserBankID", tm, ipo.AccName, ipo.TaxId, ipo.Key, ipo.UserId, ipo.UserBankId);

                await _braUserMo.PutAsync("AccName = @AccName, TaxId = @TaxId", "UserId = @UserId", tm, ipo.AccName, ipo.TaxId, ipo.UserId);
            }
            //添加
            else
            {
                var braUserBank = await _braUserBankMo.GetSingleAsync("UserID = @UserID and KeyCode = @KeyCode", tm, ipo.UserId, ipo.Key);

                if (braUserBank != null)
                    throw new CustomException(ResponseCodes.RS_UNKNOWN, $"Repeat addition.");

                var globalUserDCache = GlobalUserDCacheEx.Create(ipo.UserId, ipo.CurrencyId);
                var eo = new L_bra_user_bankEO()
                {
                    UserBankID = ObjectId.NewId(),
                    BankChannel = ipo.Channels.ToEnumN<BraPayChannel>()?.ToString(),
                    UserID = ipo.UserId,
                    UserKind = (int)await globalUserDCache.GetUserKind(),
                    OperatorID = ipo.OperatorId,
                    CountryID = ipo.CountryId,
                    CurrencyID = ipo.CurrencyId,
                    TaxId = ipo.TaxId,
                    KeyCode = ipo.Key,
                    AccountType = checkKeyRet.QueryDictKeyResponse.accountType,
                    Name = ipo.AccName,
                    OwnerType = checkKeyRet.QueryDictKeyResponse.ownerType,
                    BankName = checkKeyRet.QueryDictKeyResponse.bankName,
                    BankCode = checkKeyRet.QueryDictKeyResponse.bankCode,
                    BranchCode = checkKeyRet.QueryDictKeyResponse.branchCode,
                    AccountNumber = checkKeyRet.QueryDictKeyResponse.accountNumber,
                    AccountStatus = checkKeyRet.QueryDictKeyResponse.status,
                    RecDate = DateTime.UtcNow
                };
                await _braUserBankMo.AddAsync(eo, tm);

                if (!braUser.HasValue)
                {
                    //如果l_bra_user没数据，则写入
                    var braUserMo = new L_bra_userMO();
                    var braUserEo = new L_bra_userEO()
                    {
                        UserID = ipo.UserId,
                        OperatorID = ipo.OperatorId,
                        CountryID = ipo.CountryId,
                        CurrencyID = ipo.CurrencyId,
                        UserKind = (int)await globalUserDCache.GetUserKind(),
                        AccName = ipo.AccName,
                        TaxId = ipo.TaxId
                    };
                    await braUserMo.AddAsync(braUserEo, tm);
                }
                else
                {
                    await _braUserMo.PutAsync("AccName = @AccName,TaxId = @TaxId", "UserID = @UserID", tm, checkKeyRet.QueryDictKeyResponse.name, checkKeyRet.QueryDictKeyResponse.taxId, ipo.UserId);
                }
            }

            tm.Commit();
            result = true;
        }
        catch (Exception ex)
        {
            tm.Rollback();
            throw new CustomException(ResponseCodes.RS_UNKNOWN, $"AddBraBank,{ex.Message}");
        }

        if (result)
        {
            //更新缓存
            await braUserBankDCache.KeyDeleteAsync();
            await braUserDCache.SetAsync();
            ret = true;
        }
        else
            throw new CustomException(ResponseCodes.RS_UNKNOWN, "failed.");

        return ret;
    }

    /// <summary>
    /// 校验key
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    private async Task<(bool success, Xxyy.Banks.Client.BLL.Pandapay.QueryDictKeyItemModel QueryDictKeyResponse)> CheckBraBankKey(BRAAddBankIpo ipo)
    {
        (bool success, Xxyy.Banks.Client.BLL.Pandapay.QueryDictKeyItemModel QueryDictKeyResponse) ret = (false, null);

        var request = new Xxyy.Banks.Client.BLL.Pandapay.XxyyQueryDictKeyIpo()
        {
            QueryKey = ipo.Key,
            UserId = ipo.UserId,
            AppId = ipo.AppId,
            CurrencyId = ipo.CurrencyId
        };

        LogUtil.Info($"CheckBraBankKey,request:{JsonConvert.SerializeObject(request)}");

        var xxyyBankClient = new Xxyy.Banks.Client.BLL.Pandapay.PandapayClient();

        var response = await xxyyBankClient.QueryDictKey(request);

        LogUtil.Info($"CheckBraBankKey,request:{JsonConvert.SerializeObject(request)},response:{JsonConvert.SerializeObject(response)}");

        if (response.Status != 200 || !response.Result.Status.Equals(ResponseCodes.RS_OK))
        {
            return ret;
        }

        ret.success = true;
        ret.QueryDictKeyResponse = response.Result.Data;

        return ret;
    }

    #endregion

    #region 添加银行卡（tejeePay）

    private async Task<bool> AddBraBankProcess(BRAAddBankIpo ipo)
    {
        var ret = false;

        //校验参数
        if (!await CheckBraAddBankParam(ipo))
            throw new CustomException(LobbyCodes.RS_PARAMETER_ERROR, "param error.");
        ipo.TejeePayMethodEnum = ipo.TejeePayMethod.ToEnum<TejeePayMethod>();

        //获取缓存中的用户银行卡列表
        var braUserBankDCache = new BraUserBankDCache(ipo.OperatorId, ipo.UserId);
        var userBankData = await braUserBankDCache.GetOrLoadAsync();

        var result = false;

        //全局用户缓存
        var globalUserDCache = await GlobalUserDCache.Create(ipo.UserId);

        TransactionManager tm = new TransactionManager();

        try
        {
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

                var where = "UserID = @UserID and TaxId = @TaxId and KeyCode = @KeyCode and Name = @Name and BankChannel = @BankChannel";
                var braUserBank = await _braUserBankMo.GetSingleAsync(where, tm, ipo.UserId, ipo.TaxId, ipo.Key, ipo.AccName, ipo.BraPayChannel.ToString());

                if (braUserBank != null)
                    throw new CustomException(LobbyCodes.RS_REPEAT_ADDITION, $"Repeat addition.");

                var set = "Name = @Name, TaxId = @TaxId, KeyCode = @Keys, AccountType = @AccountType, AccountNumber = @AccountNumber";
                where = "UserID = @UserID and UserBankID = @UserBankID";
                await _braUserBankMo.PutAsync(set, where, tm, ipo.AccName, ipo.TaxId, ipo.Key, ipo.TejeePayMethodEnum.ToString(), ipo.Key, ipo.UserId, ipo.UserBankId);
            }
            //添加
            else
            {
                var where = "UserID = @UserID and TaxId = @TaxId and KeyCode = @KeyCode and Name = @Name and BankChannel = @BankChannel";

                var braUserBank = await _braUserBankMo.GetSingleAsync(where, tm, ipo.UserId, ipo.TaxId, ipo.Key, ipo.AccName, ipo.BraPayChannel.ToString());

                if (braUserBank != null)
                    throw new CustomException(LobbyCodes.RS_REPEAT_ADDITION, $"Repeat addition.");

                var eo = new L_bra_user_bankEO()
                {
                    UserBankID = ObjectId.NewId(),
                    BankChannel = ipo.BraPayChannel.ToString(),
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
                await _braUserBankMo.AddAsync(eo, tm, useIgnore_: true);
            }

            tm.Commit();
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
            throw new CustomException(ResponseCodes.RS_UNKNOWN, $"AddBraBank,{ex.Message}");
        }

        if (result)
        {
            //更新缓存
            await braUserBankDCache.KeyDeleteAsync();
            ret = true;
        }
        else
            throw new CustomException(ResponseCodes.RS_UNKNOWN, "failed.");

        return ret;
    }

    /// <summary>
    /// pandapay添加银行卡主逻辑
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    /// <exception cref="CustomException"></exception>
    private async Task<bool> AddBraTejeePayBank(BRAAddBankIpo ipo)
    {
        var ret = false;

        //校验参数
        if (!await CheckBraAddBankParam(ipo))
            throw new CustomException(LobbyCodes.RS_PARAMETER_ERROR, "param error.");

        //获取缓存中的用户银行卡列表
        var braUserBankDCache = new BraUserBankDCache(ipo.OperatorId, ipo.UserId);
        var userBankData = await braUserBankDCache.GetOrLoadAsync();

        //获取巴西用户
        var braUserDCache = new BraUserDCache(ipo.UserId);
        var braUser = await braUserDCache.GetOrLoadAsync();

        var result = false;

        //全局用户缓存
        var globalUserDCache = await GlobalUserDCache.Create(ipo.UserId);

        TransactionManager tm = new TransactionManager();

        try
        {
            if (!string.IsNullOrWhiteSpace(ipo.UserBankId)
            && userBankData.Value != null
            && userBankData.Value.Any(d => d.UserBankID.Equals(ipo.UserBankId)))
            {
                var tejeePayMethod = ipo.TejeePayMethod.ToEnum<TejeePayMethod>();

                if (userBankData.Value.Any(d => d.UserID.Equals(ipo.UserId)
                                            && d.KeyCode.Equals(ipo.Key)
                                            && d.AccountType.Equals(tejeePayMethod.ToString())
                                            && !d.UserBankID.Equals(ipo.UserBankId)
                ))
                    throw new CustomException(LobbyCodes.RS_REPEAT_ADDITION, $"Repeat addition.");

                var braUserBank = await _braUserBankMo.GetSingleAsync("UserID = @UserID and TaxId = @TaxId and KeyCode = @KeyCode and Name = @Name and BankChannel = @BankChannel", tm, ipo.UserId, ipo.TaxId, ipo.Key, ipo.AccName, ipo.BraPayChannel.ToString());

                if (braUserBank != null)
                    throw new CustomException(LobbyCodes.RS_REPEAT_ADDITION, $"Repeat addition.");


                await _braUserBankMo.PutAsync("Name = @Name, TaxId = @TaxId, KeyCode = @Keys, AccountType = @AccountType, AccountNumber = @AccountNumber", "UserID = @UserID and UserBankID = @UserBankID", tm, ipo.AccName, ipo.TaxId, ipo.Key, tejeePayMethod.ToString(), ipo.Key, ipo.UserId, ipo.UserBankId);

                await _braUserMo.PutAsync("AccName = @AccName, TaxId = @TaxId", "UserId = @UserId", tm, ipo.AccName, ipo.TaxId, ipo.UserId);
            }
            //添加
            else
            {
                var where = "UserID = @UserID and TaxId = @TaxId and KeyCode = @KeyCode and Name = @Name and BankChannel = @BankChannel";

                var braUserBank = await _braUserBankMo.GetSingleAsync(where, tm, ipo.UserId, ipo.TaxId, ipo.Key, ipo.AccName, ipo.BraPayChannel.ToString());

                if (braUserBank != null)
                    throw new CustomException(LobbyCodes.RS_REPEAT_ADDITION, $"Repeat addition.");

                var eo = new L_bra_user_bankEO()
                {
                    UserBankID = ObjectId.NewId(),
                    BankChannel = ipo.BraPayChannel.ToString(),
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
                await _braUserBankMo.AddAsync(eo, tm, useIgnore_: true);

                if (!braUser.HasValue)
                {
                    //如果l_bra_user没数据，则写入
                    var braUserMo = new L_bra_userMO();
                    var braUserEo = new L_bra_userEO()
                    {
                        UserID = ipo.UserId,
                        OperatorID = ipo.OperatorId,
                        CountryID = ipo.CountryId,
                        CurrencyID = ipo.CurrencyId,
                        UserKind = (int)await globalUserDCache.GetUserKindAsync(),
                        AccName = ipo.AccName,
                        TaxId = ipo.TaxId
                    };
                    await braUserMo.AddAsync(braUserEo, tm, useIgnore_: true);
                }
                else
                {
                    await _braUserMo.PutAsync("AccName = @AccName,TaxId = @TaxId", "UserID = @UserID", tm, ipo.AccName, ipo.TaxId, ipo.UserId);
                }
            }

            tm.Commit();
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
            throw new CustomException(ResponseCodes.RS_UNKNOWN, $"AddBraBank,{ex.Message}");
        }

        if (result)
        {
            //更新缓存
            await braUserBankDCache.KeyDeleteAsync();
            await braUserDCache.SetAsync();
            ret = true;
        }
        else
            throw new CustomException(ResponseCodes.RS_UNKNOWN, "failed.");

        return ret;
    }

    #endregion

    /// <summary>
    /// 巴西银行卡列表
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    public async Task<List<BraBankQueryDto>> GetBraBanks(BraBankQueryIpo ipo)
    {
        var userBanksDCache = new BraUserBankDCache(ipo.OperatorId, ipo.UserId);

        var cacheData = await userBanksDCache.GetAsync();

        List<BraBankQueryDto> ret = null;

        if (cacheData.HasValue)
        {
            if (ipo.UserBankIds != null && ipo.UserBankIds.Any(d => !string.IsNullOrWhiteSpace(d)))
            {
                cacheData.Value = cacheData.Value.Where(d => ipo.UserBankIds.Contains(d.UserBankID)).ToList();
            }

            ret = cacheData.Value.Map<List<BraBankQueryDto>>();
            ret = ret.OrderByDescending(d => d.RecDate).ToList();
            ret = ret.OrderByDescending(d => d.LastUsing).ThenByDescending(d => d.RecDate).ToList();
        }

        return ret;
    }

    /// <summary>
    /// 获取单条巴西银行卡
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    /// <exception cref="CustomException"></exception>
    public async Task<BraBankQueryDto> SingleBraBank(BraBankQueryIpo ipo)
    {
        if (string.IsNullOrWhiteSpace(ipo.UserBankId))
            throw new CustomException("UserBankId cannot be empty.");

        var userBanksDCache = new BraUserBankDCache(ipo.OperatorId, ipo.UserId);

        var cacheData = await userBanksDCache.GetOrLoadAsync();

        if (!cacheData.HasValue)
            return null;

        var ret = cacheData.Value.Where(d => d.UserBankID.Equals(ipo.UserBankId)).FirstOrDefault();

        return ret.Map<BraBankQueryDto>();
    }

    /// <summary>
    /// 充值（巴西 + 墨西哥）
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    public async Task<BraDepositDto> DepositAsync(BraDepositIpo ipo)
    {
        var ret = new BraDepositDto();

        var globalUserDCache = await GlobalUserDCache.Create(ipo.UserId);
        ipo.OperatorId = await globalUserDCache.GetOperatorIdAsync();
        ipo.CurrencyId = await globalUserDCache.GetCurrencyIdAsync();
        ipo.CountryId = await globalUserDCache.GetCountryIdAsync();

        //校验参数
        await CheckPayParam(ipo);

        //获取充值、提现渠道
        ipo.BraPayChannel = await LobbyUtil.GetPayChannel(ipo.OperatorId, ipo.CurrencyId, ipo.CountryId);

        switch (ipo.BraPayChannel)
        {
            case BraPayChannel.pandapay:
                throw new CustomException(LobbyCodes.RS_UNKNOWN, "pay channel error.");
            case BraPayChannel.tejeepay:
                ret = await TejeePay(ipo);
                break;
            case BraPayChannel.letspay:
                ret = await LetsPay(ipo);
                break;
            case BraPayChannel.mlpay:
                ret = await MlPay(ipo);
                break;
            case BraPayChannel.bfpay:
                ret = await BfPay(ipo);
                break;
            case BraPayChannel.hubtel:
                ret = await HubtelPay(ipo);
                break;
            default:
                throw new CustomException(LobbyCodes.RS_UNKNOWN, "pay channel error.");
        }
        ret.Channel = ipo.BraPayChannel.ToString();
        return ret;
    }

    private async Task<BraDepositDto> HubtelPay(BraDepositIpo ipo)
    {
        if(string.IsNullOrWhiteSpace(ipo.Mobile))
            throw new CustomException(LobbyCodes.RS_PAY_ERROR, "sorry,mobile can not empty");
        var ret = new BraDepositDto();
        //try
        //{
            var globalUserDCache = await GlobalUserDCache.Create(ipo.UserId);
            var phone = ipo.Mobile;
            var countryId = await globalUserDCache.GetCountryIdAsync();
            var callingCode = DbCacheUtil.GetCountry(countryId).CallingCode;
            if(!phone.StartsWith(callingCode)||phone.Length<12)
            {
                phone = $"{callingCode}{phone}";
            }
            var hubtelChannel = ipo.AdditionalParameters?.GetValueOrDefault("hubtelChannel", "").ToString();
            if(string.IsNullOrWhiteSpace(hubtelChannel))
                throw new CustomException(LobbyCodes.RS_PAY_ERROR, "hubtel channel can not empty.");
            var request = new XxyyHubtelPayIpo
            {
                Mobile = phone,
                Channel = hubtelChannel,//"mtn-gh"
                Amount = ipo.Amount.MToA(ipo.CurrencyId),
                AppId = ipo.AppId,
                CurrencyId = ipo.CurrencyId,
                ReceiveBonus = ipo.ReceiveBonus,
                UserId = ipo.UserId,
                UserIp = AspNetUtil.GetRemoteIpString(),
                CountryId = countryId,
                ActivityIds = ipo.ActivityIdList.Map<List<string>>(),
                IsAddBalance = ipo.IsAddBalance,
                Meta= JsonConvert.DeserializeObject(Convert.ToString(ipo.Meta))
            };
            var response = await new HubtelClient().Pay(request);
            //LogUtil.Info($"deposit充值（hubtel）,request:{JsonConvert.SerializeObject(request)},response:{JsonConvert.SerializeObject(response)}");
            var logger = LogUtil.GetContextLogger()
                .SetLevel(Microsoft.Extensions.Logging.LogLevel.Information)
                .AddMessage($"{request.Mobile}通过hubtel,{hubtelChannel}充值，amount:{ipo.Amount}")
                .AddField("lobby.req", SerializerUtil.SerializeJsonNet(request))
                .AddField("lobby.ret", SerializerUtil.SerializeJsonNet(response));

            if (response == null
                || response.Status != 200
                || !response.Result.Status.Equals(Xxyy.Banks.Client.ResponseCodes.RS_OK))
            {
                logger.SetLevel(Microsoft.Extensions.Logging.LogLevel.Error);
            //LogUtil.Error($"deposit充值（hubtel）失败,request:{JsonConvert.SerializeObject(request)},response:{JsonConvert.SerializeObject(response)}");
                var errMsg = "deposit,hubtel failed.";
                if(!string.IsNullOrWhiteSpace(response?.Result?.Message))
                    errMsg = response.Result.Message;
                
                throw new CustomException(LobbyCodes.RS_PAY_ERROR, errMsg);
            }
            ret.Mode = 0;
            ret.OrderId = response.Result.OrderId;
            return ret;
        //}
        //catch (Exception ex)
        //{
        //    throw new CustomException(LobbyCodes.RS_PAY_ERROR, $"{ex.Message}");
        //}
    }

    /// <summary>
    /// 巴西提现
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    public async Task<BraWithDrawDto> WithdrawAsync(BraWithDrawIpo ipo)
    {
        var ret = new BraWithDrawDto();

        ipo.BraPayChannel = await LobbyUtil.GetPayChannel(ipo.OperatorId, ipo.CurrencyId, ipo.CountryId);

        switch (ipo.BraPayChannel)
        {
            case BraPayChannel.pandapay:
                throw new CustomException(LobbyCodes.RS_UNKNOWN, "cash channel error.");
            case BraPayChannel.tejeepay:
            case BraPayChannel.letspay:
            case BraPayChannel.mlpay:
                ret = await BraTejeePayWithDraw(ipo);
                break;
            default:
                throw new CustomException(LobbyCodes.RS_UNKNOWN, "cash channel error.");
        }
        return ret;
    }

    /// <summary>
    /// 校验充值参数
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    /// <exception cref="CustomException"></exception>
    public async Task CheckPayParam(BraDepositIpo ipo)
    {
        //需要验证充值金额
        if (ipo.Amount == 0)
            throw new CustomException(LobbyCodes.RS_PARAMETER_ERROR, "Illegal recharge amount.");

        var field = PayConfigDCache.GetField(ipo.OperatorId, ipo.CurrencyId);

        var payConfigDCache = await new PayConfigDCache().GetOrLoadAsync(field);

        if (!payConfigDCache.HasValue)
            throw new CustomException(LobbyCodes.RS_PARAMETER_ERROR, "param error.");

        var payConfig = payConfigDCache.Value.FirstOrDefault();

        if (
            ipo.Amount < payConfig.MinAmount.AToM(ipo.CurrencyId)
            || ipo.Amount > payConfig.MaxAmount.AToM(ipo.CurrencyId)
            )
            throw new CustomException(LobbyCodes.RS_PARAMETER_ERROR, "param error.");

        //墨西哥充值金额只能是正整数
        if (ipo.CountryId.Equals("MEX") && !StringUtil.IsPositiveInteger(ipo.Amount.ToString()))
        {
            throw new CustomException(LobbyCodes.RS_PARAMETER_ERROR, "param error.The recharge amount must be a positive integer");
        }

    }

    /// <summary>
    /// 巴西充值
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    [Obsolete("使用ProfileService.PayAsync")]
    public async Task<BraDepositDto> BraDeposit(BraDepositIpo ipo)
    {
        var ret = new BraDepositDto();

        ipo.BraPayChannel = await LobbyUtil.GetPayChannel(ipo.OperatorId, ipo.CurrencyId, ipo.CountryId);

        switch (ipo.BraPayChannel)
        {
            case BraPayChannel.pandapay:
                throw new CustomException(LobbyCodes.RS_UNKNOWN, "pay channel error.");
            //ret = await BraPandapayDeposit(ipo);
            //break;
            case BraPayChannel.tejeepay:
            case BraPayChannel.letspay:
                ret = await BraTejeePayDeposit(ipo);
                break;
            default:
                throw new CustomException(LobbyCodes.RS_UNKNOWN, "pay channel error.");
        }
        return ret;
    }

    /// <summary>
    /// 巴西提现
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    [Obsolete("使用ProfileService.CashAsync")]
    public async Task<BraWithDrawDto> BraWithDraw(BraWithDrawIpo ipo)
    {
        var ret = new BraWithDrawDto();

        ipo.BraPayChannel = await LobbyUtil.GetPayChannel(ipo.OperatorId, ipo.CurrencyId, ipo.CountryId);

        switch (ipo.BraPayChannel)
        {
            case BraPayChannel.pandapay:
                //ret = await BraPandapayWithDraw(ipo);
                throw new CustomException(LobbyCodes.RS_UNKNOWN, "BraWithDraw channel error.");
            case BraPayChannel.tejeepay:
            case BraPayChannel.letspay:
                ret = await BraTejeePayWithDraw(ipo);
                break;
            default:
                throw new CustomException(LobbyCodes.RS_UNKNOWN, "BraWithDraw channel error.");
        }
        return ret;
    }

    #region 巴西充值、提现

    /// <summary>
    /// 校验用户税号、户名是否存在
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    /// <exception cref="CustomException"></exception>
    private async Task CheckBraUser(BraWithDrawIpo ipo)
    {
        //巴西用户税号等信息
        var braUserDCache = new BraUserDCache(ipo.UserId);
        var braUser = await braUserDCache.GetOrLoadAsync();

        if (!braUser.HasValue)
            throw new CustomException(ResponseCodes.RS_UNKNOWN, "user does not exist.");

        //ipo.BraUserEo = braUser.Value;
    }

    /// <summary>
    /// 校验银行卡
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    /// <exception cref="CustomException"></exception>
    private async Task CheckBraUserBank(BraWithDrawIpo ipo)
    {
        var braUserBankDCache = new BraUserBankDCache(ipo.OperatorId, ipo.UserId);
        var braUserBank = await braUserBankDCache.GetOrLoadAsync();

        if (!braUserBank.HasValue)
            throw new CustomException(ResponseCodes.RS_UNKNOWN, "No bank card added.");

        if (!braUserBank.Value.Any(d => d.UserBankID.Equals(ipo.UserBankId)))
            throw new CustomException(ResponseCodes.RS_UNKNOWN, "Bank card not found.");

        ipo.BraUserBankEoList = braUserBank.Value;
        ipo.BraUserBankEo = braUserBank.Value.Where(d => d.UserBankID.Equals(ipo.UserBankId)).FirstOrDefault();

        //if (!ipo.BraUserBankEo.BankChannel.Equals(ipo.BraPayChannel.ToString()))
        //    throw new CustomException(ResponseCodes.RS_UNKNOWN, "BankId and Channels do not match.");
    }

    private async Task CheckUserEx(BraWithDrawIpo ipo)
    {

        var userExMo = DbSink.BuildUserExMo(ipo.UserId);

        var userExEo = await userExMo.GetSingleAsync("UserID = @UserID", ipo.UserId);

        if (userExEo == null)
            throw new CustomException(ResponseCodes.RS_UNKNOWN, "Data does not exist.");

        ipo.UserExEo = userExEo;
    }


    #region pandaPay

    /// <summary>
    /// 充值（pandaPay）
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    /// <exception cref="CustomException"></exception>
    private async Task<BraDepositDto> BraPandapayDeposit(BraDepositIpo ipo)
    {
        ipo.AccName = "default";
        ipo.TaxId = "default";

        var xxyyBankClient = new Xxyy.Banks.Client.BLL.Pandapay.PandapayClient();

        var response = await xxyyBankClient.PandaPay(ipo.Map<Xxyy.Banks.Client.BLL.Pandapay.XxyyPandapayIpo>());

        Log.Information($"Bra充值（pandapay）,request:{JsonConvert.SerializeObject(ipo)},response:{JsonConvert.SerializeObject(response)}");

        if (response.Status != 200 || !response.Result.Status.Equals(ResponseCodes.RS_OK))
        {
            LogUtil.GetContextLogger().AddMessage($"Bra充值（pandapay）失败,request:{JsonConvert.SerializeObject(ipo.Map<Xxyy.Banks.Client.BLL.Pandapay.XxyyPandapayIpo>())},response:{JsonConvert.SerializeObject(response)}");

            throw new CustomException(LobbyCodes.RS_PAY_ERROR, "BraDeposit,PandaPay failed.");
        }

        var ret = new BraDepositDto();
        ret.BarCode = response.Result.BarCode;
        ret.OrderId = response.Result.OrderId;

        return ret;
    }

    #endregion

    #region tejeePay

    public async Task<BraDepositDto> TejeePay(BraDepositIpo ipo)
    {
        var ret = new BraDepositDto();

        try
        {
            var globalUserDCache = await GlobalUserDCache.Create(ipo.UserId);
            var request = new Xxyy.Banks.Client.BLL.Tejeepay.XxyyTejeeCommonPayIpo()
            {
                Amount = ipo.Amount.MToA(ipo.CurrencyId),
                UserId = ipo.UserId,
                AppId = ipo.AppId,
                CurrencyId = ipo.CurrencyId,
                UserIp = AspNetUtil.GetRemoteIpString(),
                ReceiveBonus = ipo.ReceiveBonus,
                Meta = JsonConvert.DeserializeObject(Convert.ToString(ipo.Meta)),
                ActivityIds = ipo.ActivityIdList.Map<List<string>>(),
                IsAddBalance = ipo.IsAddBalance,
                Phone = await globalUserDCache.GetMobileAsync(),
                Name = await globalUserDCache.GetUsernameAsync(),
                Email = await globalUserDCache.GetEmailAsync(),
                CountryId = await globalUserDCache.GetCountryIdAsync()
            };

            var xxyyBankClient = new Xxyy.Banks.Client.BLL.Tejeepay.TejeepayClient();

            var response = await xxyyBankClient.TejeePay(request);

            var requestStr = JsonConvert.SerializeObject(request);
            var responseStr = JsonConvert.SerializeObject(response);

            LogUtil.Info($"deposit充值（tejeePay）,request:{JsonConvert.SerializeObject(request)},response:{JsonConvert.SerializeObject(response)}");

            if (response.Status != 200 || !response.Result.Status.Equals(ResponseCodes.RS_OK))
            {
                LogUtil.Error($"deposit充值（tejeePay）失败,request:{JsonConvert.SerializeObject(request)},response:{JsonConvert.SerializeObject(response)}");
                throw new CustomException(LobbyCodes.RS_PAY_ERROR, "deposit,tejeePay failed.");
            }
            ret.QRCode = response.Result.payUrl;
            ret.OrderId = response.Result.OrderId;
            //ret.PayUrl= response.Result.payUrl;
            ret.Mode = (response.Result?.payUrl?.StartsWith("http", StringComparison.OrdinalIgnoreCase) ?? false) ? 0 : 1;
            return ret;
        }
        catch (Exception ex)
        {
            throw new CustomException(LobbyCodes.RS_PAY_ERROR, $"{ex.Message}");
        }
    }

    public async Task<BraDepositDto> MlPay(BraDepositIpo ipo)
    {
        var ret = new BraDepositDto();

        try
        {
            var globalUserDCache = await GlobalUserDCache.Create(ipo.UserId);
            var email = await globalUserDCache.GetEmailAsync();
            var name = await globalUserDCache.GetUsernameAsync();
            var phone = await globalUserDCache.GetMobileAsync();
            var countryId = await globalUserDCache.GetCountryIdAsync();
            var request = new XxyyMlpayPayIpo()
            {
                Email = string.IsNullOrWhiteSpace(email) ? "test@lucro777.com" : email,
                Name = string.IsNullOrWhiteSpace(name) ? "name777" : name,
                Phone = string.IsNullOrWhiteSpace(phone) ? "12345678901" : phone,
                Amount = ipo.Amount.MToA(ipo.CurrencyId),
                UserId = ipo.UserId,
                AppId = ipo.AppId,
                CurrencyId = ipo.CurrencyId,
                ReceiveBonus = ipo.ReceiveBonus,
                UserIp = AspNetUtil.GetRemoteIpString(),
                Meta = JsonConvert.DeserializeObject(Convert.ToString(ipo.Meta)),
                ActivityIds = ipo.ActivityIdList.Map<List<string>>(),
                IsAddBalance = ipo.IsAddBalance,
                CountryId = countryId,
                TaxId = ipo.TaxId
            };
            var response = await new MlpayClient().MlpayPay(request);

            LogUtil.Info($"deposit充值（mlpay）,request:{JsonConvert.SerializeObject(request)},response:{JsonConvert.SerializeObject(response)}");

            if (response == null
                || response.Status != 200
                || !response.Result.Status.Equals(Xxyy.Banks.Client.ResponseCodes.RS_OK))
            {
                LogUtil.Error($"deposit充值（mlpay）失败,request:{JsonConvert.SerializeObject(request)},response:{JsonConvert.SerializeObject(response)}");
                throw new CustomException(LobbyCodes.RS_PAY_ERROR, "deposit,mlpay failed.");
            }

            //if (countryId.Equals("MEX"))
            //    ret.QRCode = response.Result.payUrl;
            //else
            ret.QRCode = response.Result.payUrl;
            ret.OrderId = response.Result.OrderId;
            //ret.PayUrl = response.Result.payUrl;
            return ret;
        }
        catch (Exception ex)
        {
            throw new CustomException(LobbyCodes.RS_PAY_ERROR, $"{ex.Message}");
        }
    }

    public async Task<BraDepositDto> BfPay(BraDepositIpo ipo)
    {
        var ret = new BraDepositDto();

        try
        {
            var globalUserDCache = await GlobalUserDCache.Create(ipo.UserId);
            var email = await globalUserDCache.GetEmailAsync();
            var name = await globalUserDCache.GetUsernameAsync();
            var phone = await globalUserDCache.GetMobileAsync();
            var countryId = await globalUserDCache.GetCountryIdAsync();
            var request = new XxyyBfpayPayIpo()
            {
                Email = string.IsNullOrWhiteSpace(email) ? "test@lucro777.com" : email,
                Name = string.IsNullOrWhiteSpace(name) ? "name777" : name,
                Phone = string.IsNullOrWhiteSpace(phone) ? "12345678901" : phone,
                Amount = ipo.Amount.MToA(ipo.CurrencyId),
                UserId = ipo.UserId,
                AppId = ipo.AppId,
                CurrencyId = ipo.CurrencyId,
                ReceiveBonus = ipo.ReceiveBonus,
                UserIp = AspNetUtil.GetRemoteIpString(),
                Meta = JsonConvert.DeserializeObject(Convert.ToString(ipo.Meta)),
                ActivityIds = ipo.ActivityIdList.Map<List<string>>(),
                IsAddBalance = ipo.IsAddBalance,
                CountryId = countryId,
                TaxId = ipo.TaxId
            };
            var response = await new BfpayClient().BfpayPay(request);

            LogUtil.Info($"deposit充值（bfpay）,request:{JsonConvert.SerializeObject(request)},response:{JsonConvert.SerializeObject(response)}");

            if (response == null
                || response.Status != 200
                || !response.Result.Status.Equals(Xxyy.Banks.Client.ResponseCodes.RS_OK))
            {
                LogUtil.Error($"deposit充值（bfpay）失败,request:{JsonConvert.SerializeObject(request)},response:{JsonConvert.SerializeObject(response)}");
                throw new CustomException(LobbyCodes.RS_PAY_ERROR, "deposit,bfpay failed.");
            }

            //if (countryId.Equals("MEX"))
            //    ret.QRCode = response.Result.payUrl;
            //else
            ret.Mode = 0;
            ret.QRCode = response.Result.payUrl;
            ret.OrderId = response.Result.OrderId;
            //ret.PayUrl = response.Result.payUrl;
            return ret;
        }
        catch (Exception ex)
        {
            throw new CustomException(LobbyCodes.RS_PAY_ERROR, $"{ex.Message}");
        }
    }

    public async Task<BraDepositDto> LetsPay(BraDepositIpo ipo)
    {
        var ret = new BraDepositDto();

        try
        {
            var globalUserDCache = await GlobalUserDCache.Create(ipo.UserId);
            var email = await globalUserDCache.GetEmailAsync();
            var name = await globalUserDCache.GetUsernameAsync();
            var phone = await globalUserDCache.GetMobileAsync();
            var countryId = await globalUserDCache.GetCountryIdAsync();
            var request = new XxyyLetsCommonPayIpo()
            {
                email = string.IsNullOrWhiteSpace(email) ? "test@lucro777.com" : email,
                name = string.IsNullOrWhiteSpace(name) ? "name777" : name,
                phone = string.IsNullOrWhiteSpace(phone) ? "12345678901" : phone,
                Amount = ipo.Amount.MToA(ipo.CurrencyId),
                UserId = ipo.UserId,
                AppId = ipo.AppId,
                CurrencyId = ipo.CurrencyId,
                ReceiveBonus = ipo.ReceiveBonus,
                UserIp = AspNetUtil.GetRemoteIpString(),
                Meta = JsonConvert.DeserializeObject(Convert.ToString(ipo.Meta)),
                ActivityIds = ipo.ActivityIdList.Map<List<string>>(),
                IsAddBalance = ipo.IsAddBalance,
                CountryId = await globalUserDCache.GetCountryIdAsync()
            };

            ApiResult<LetsCommonPayDto> response = null;

            switch (countryId)
            {
                case "MEX":
                    response = await new LetspayClient().LetsPayMex(request);
                    break;
                case "BRA":
                    response = await new LetspayClient().LetsPay(request);
                    break;
                default:
                    LogUtil.Info($"deposit充值（letspay）,request:{JsonConvert.SerializeObject(request)},用户国家编码异常:{countryId}");
                    throw new CustomException("Abnormal country code");
            }

            LogUtil.Info($"deposit充值（letspay）,request:{JsonConvert.SerializeObject(request)},response:{JsonConvert.SerializeObject(response)}");

            if (response == null
                || response.Status != 200
                || !response.Result.Status.Equals(Xxyy.Banks.Client.ResponseCodes.RS_OK))
            {
                LogUtil.Error($"deposit充值（letspay）失败,request:{JsonConvert.SerializeObject(request)},response:{JsonConvert.SerializeObject(response)}");
                throw new CustomException(LobbyCodes.RS_PAY_ERROR, $"deposit,letspay failed.");
            }

            if (countryId.Equals("MEX"))
            {
                ret.QRCode = response.Result.payUrl;
                // ret.PayUrl = response.Result.payUrl;
            }
            else
            {
                ret.QRCode = response.Result.code;
                ret.Mode = 1;
            }
            ret.OrderId = response.Result.OrderId;
            return ret;
        }
        catch (Exception ex)
        {
            throw new CustomException(LobbyCodes.RS_PAY_ERROR, $"{ex.Message}");
        }
    }

    /// <summary>
    /// 巴西充值（tejeePay）
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    public async Task<BraDepositDto> BraTejeePayDeposit(BraDepositIpo ipo)
    {

        var ret = new BraDepositDto();

        try
        {
            var globalUserDCache = await GlobalUserDCache.Create(ipo.UserId);
            if (ipo.BraPayChannel == BraPayChannel.tejeepay)
            {
                var request = new Xxyy.Banks.Client.BLL.Tejeepay.XxyyTejeeCommonPayIpo()
                {
                    Amount = ipo.Amount.MToA(ipo.CurrencyId),
                    //RequestUUID = ObjectId.NewId(),
                    UserId = ipo.UserId,
                    AppId = ipo.AppId,
                    CurrencyId = ipo.CurrencyId,
                    UserIp = AspNetUtil.GetRemoteIpString(),
                    ReceiveBonus = ipo.ReceiveBonus,
                    Meta = JsonConvert.DeserializeObject(Convert.ToString(ipo.Meta)),
                    ActivityIds = ipo.ActivityIdList.Map<List<string>>(),
                    IsAddBalance = ipo.IsAddBalance,
                    Phone = await globalUserDCache.GetMobileAsync(),
                    Name = await globalUserDCache.GetUsernameAsync(),
                    Email = await globalUserDCache.GetEmailAsync()
                };

                var xxyyBankClient = new Xxyy.Banks.Client.BLL.Tejeepay.TejeepayClient();

                var response = await xxyyBankClient.TejeePay(request);

                Log.Information($"Bra充值（tejeePay）,request:{JsonConvert.SerializeObject(request)},response:{JsonConvert.SerializeObject(response)}");

                if (response.Status != 200 || !response.Result.Status.Equals(ResponseCodes.RS_OK))
                {
                    LogUtil.Error($"Bra充值（tejeePay）失败,request:{JsonConvert.SerializeObject(request)},response:{JsonConvert.SerializeObject(response)}");
                    throw new CustomException(LobbyCodes.RS_PAY_ERROR, "BraDeposit,tejeePay failed.");
                }
                ret.QRCode = response.Result.payUrl;
                ret.OrderId = response.Result.OrderId;
            }
            else if (ipo.BraPayChannel == BraPayChannel.letspay)
            {
                var email = await globalUserDCache.GetEmailAsync();
                var name = await globalUserDCache.GetUsernameAsync();
                var phone = await globalUserDCache.GetMobileAsync();
                var request = new XxyyLetsCommonPayIpo()
                {
                    email = string.IsNullOrWhiteSpace(email) ? "test@lucro777.com" : email,
                    name = string.IsNullOrWhiteSpace(name) ? "name777" : name,
                    phone = string.IsNullOrWhiteSpace(phone) ? "12345678901" : phone,
                    Amount = ipo.Amount.MToA(ipo.CurrencyId),
                    UserId = ipo.UserId,
                    AppId = ipo.AppId,
                    CurrencyId = ipo.CurrencyId,
                    ReceiveBonus = ipo.ReceiveBonus,
                    UserIp = AspNetUtil.GetRemoteIpString(),
                    Meta = JsonConvert.DeserializeObject(Convert.ToString(ipo.Meta)),
                    ActivityIds = ipo.ActivityIdList.Map<List<string>>(),
                    IsAddBalance = ipo.IsAddBalance
                };
                var response = await new Xxyy.Banks.Client.BLL.Letspay.LetspayClient().LetsPay(request);

                Log.Information($"Bra充值（letspay）,request:{JsonConvert.SerializeObject(request)},response:{JsonConvert.SerializeObject(response)}");

                if (response.Status != 200 || !response.Result.Status.Equals(Xxyy.Banks.Client.ResponseCodes.RS_OK))
                {
                    LogUtil.Error($"Bra充值（letspay）失败,request:{JsonConvert.SerializeObject(request)},response:{JsonConvert.SerializeObject(response)}");
                    throw new CustomException(LobbyCodes.RS_PAY_ERROR, "BraDeposit,letspay failed.");
                }

                ret.QRCode = response.Result.code;
                ret.OrderId = response.Result.code;
            }
            else
            {
                throw new CustomException(LobbyCodes.RS_PAY_ERROR, $"BraDeposit error.channel:{ipo.BraPayChannel.ToString()}");
            }
        }
        catch (Exception ex)
        {
            throw new CustomException(LobbyCodes.RS_PAY_ERROR, $"{ex.Message}");
        }

        return ret;
    }

    private async Task<BraWithDrawIpo> BuildBraWithDrawIpo(BraWithDrawIpo ipo)
    {
        ipo.GlobalUserDCache = await GlobalUserDCache.Create(ipo.UserId);
        ipo.OperatorId = await ipo.GlobalUserDCache.GetOperatorIdAsync();
        ipo.CurrencyId = await ipo.GlobalUserDCache.GetCurrencyIdAsync();
        ipo.CountryId = await ipo.GlobalUserDCache.GetCountryIdAsync();

        //校验用户税号、户名是否存在
        //await CheckBraUser(ipo);

        //校验银行卡
        await CheckBraUserBank(ipo);

        //校验s_user_ex是否存在用户数据
        await CheckUserEx(ipo);

        ipo.CommonUserServices = new Xxyy.Common.Services.UserService(ipo.UserId);
        ipo.CurrencyChangeServices = new CurrencyChangeService(ipo.UserId);
        ipo.UserEo = await DbSink.BuildUserMo(ipo.UserId).GetByPKAsync(ipo.UserId);

        ipo.UserIp = AspNetUtil.GetRemoteIpString();

        ipo.CashAuditId = ObjectId.NewId();

        ipo.CashConditionConfigEoList = LobbyDbCacheUtil.GetAllCashConditionConfig(ipo.OperatorId, ipo.CurrencyId);

        ipo.SOperatorEO = DbCacheUtil.GetOperator(ipo.OperatorId);

        return ipo;
    }

    /// <summary>
    /// 创建Sc_cash_auditEO
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    private async Task<Sc_cash_auditEO> BuildCashAuditEo(BraWithDrawIpo ipo)
    {
        object requestParam = null;
        if (ipo.BraPayChannel == BraPayChannel.letspay)
        {
            requestParam = new XxyyLetsProxyPayIpo()
            {
                cashAuditId = ipo.CashAuditId,
                accountName = ipo.BraUserBankEo.Name,
                accountNo = ipo.BraUserBankEo.AccountNumber,
                bankCode = ipo.CountryId.Equals("MEX") ? ipo.BraUserBankEo.BankCode : ipo.BraUserBankEo.AccountType,
                email = string.IsNullOrWhiteSpace(ipo.UserEo.Email) ? "test@lucro777.com" : ipo.UserEo.Email,
                phone = string.IsNullOrWhiteSpace(ipo.UserEo.Mobile) ? "12345678901" : ipo.UserEo.Mobile,
                cpf = ipo.BraUserBankEo.AccountNumber,
                Amount = (long)ipo.Amount,
                UserId = ipo.UserId,
                AppId = ipo.AppId,
                CurrencyId = ipo.CurrencyId,
                UserIp = ipo.UserIp,
                //如果是长线版本，是需要扣除手续费的，根据当前的vip等级捞取对应的手续费配置
                CashRate = (decimal)ipo.CashRate,
                CountryId = ipo.CountryId,
                taxId = ipo.BraUserBankEo.TaxId,
                mode = "bank"
            };
        }
        else if (ipo.BraPayChannel == BraPayChannel.mlpay)
        {
            requestParam = new XxyyMlpayCashIpo()
            {
                CashAuditId = ipo.CashAuditId,
                AccountName = ipo.BraUserBankEo.Name,
                AccountNo = ipo.BraUserBankEo.AccountNumber,
                BankCode = ipo.CountryId.Equals("MEX") ? ipo.BraUserBankEo.BankCode : ipo.BraUserBankEo.AccountType,
                Email = string.IsNullOrWhiteSpace(ipo.UserEo.Email) ? "test@lucro777.com" : ipo.UserEo.Email,
                Phone = string.IsNullOrWhiteSpace(ipo.UserEo.Mobile) ? "12345678901" : ipo.UserEo.Mobile,
                Amount = (long)ipo.Amount,
                UserId = ipo.UserId,
                AppId = ipo.AppId,
                CurrencyId = ipo.CurrencyId,
                UserIp = ipo.UserIp,
                //如果是长线版本，是需要扣除手续费的，根据当前的vip等级捞取对应的手续费配置
                CashRate = (decimal)ipo.CashRate,
                CountryId = ipo.CountryId,
                TaxId = ipo.BraUserBankEo.TaxId
            };
        }
        else
        {


            switch (ipo.CountryId)
            {
                case "BRA":
                    requestParam = new Xxyy.Banks.Client.BLL.Tejeepay.XxyyTejeeProxyPayIpo()
                    {
                        UserId = ipo.UserId,
                        AppId = ipo.AppId,
                        CurrencyId = ipo.CurrencyId,
                        Amount = (long)ipo.Amount,
                        UserIp = AspNetUtil.GetRemoteIpString(),
                        Mobile = await ipo.GlobalUserDCache.GetMobileAsync(),
                        Email = await ipo.GlobalUserDCache.GetEmailAsync(),
                        CashRate = (decimal)ipo.CashRate,
                        BankCardNo = ipo.BraUserBankEo.AccountNumber,
                        BankCardName = ipo.BraUserBankEo.Name,
                        BankCode = ipo.BraUserBankEo.BankCode,
                        BizEnum = 0,
                        CertType = (int)ipo.BraUserBankEo.AccountType.ToEnumN<TejeePayMethod>(),
                        CertId = ipo.BraUserBankEo.AccountNumber,
                        CashAuditId = ipo.CashAuditId,
                        CountryId = ipo.CountryId
                    };
                    break;
                case "MEX":
                    requestParam = new Xxyy.Banks.Client.BLL.Tejeepay.XxyyTejeeProxyPayIpo()
                    {
                        UserId = ipo.UserId,
                        AppId = ipo.AppId,
                        CurrencyId = ipo.CurrencyId,
                        Amount = (long)ipo.Amount,
                        UserIp = AspNetUtil.GetRemoteIpString(),
                        Mobile = await ipo.GlobalUserDCache.GetMobileAsync(),
                        Email = await ipo.GlobalUserDCache.GetEmailAsync(),
                        CashRate = (decimal)ipo.CashRate,
                        BankCardNo = ipo.BraUserBankEo.AccountNumber,
                        BankCardName = ipo.BraUserBankEo.Name,
                        BankCode = ipo.BraUserBankEo.BankCode,
                        BizEnum = 1,
                        CashAuditId = ipo.CashAuditId,
                        CountryId = ipo.CountryId
                    };
                    break;
                default:
                    break;
            }
        }

        return new Sc_cash_auditEO()
        {
            CashAuditID = ipo.CashAuditId,
            UserID = ipo.UserId,
            OperatorID = ipo.OperatorId,
            CountryID = ipo.CountryId,
            CurrencyID = ipo.CurrencyId,
            AppID = ipo.AppId,
            Mobile = ipo.UserEo.Mobile,
            Amount = (long)ipo.Amount,
            BankCode = ipo.BraUserBankEo.BankCode,
            BankName = ipo.BraUserBankEo.BankName,
            AccName = ipo.BraUserBankEo.Name,
            AccNumber = ipo.BraUserBankEo.AccountNumber,
            Status = 0,
            Paytype = (int)ipo.BraPayChannel,
            BankID = ipo.BraPayChannel.ToString(),
            RequestParam = JsonConvert.SerializeObject(requestParam),
            ApplyTime = DateTime.UtcNow,
            FromMode = ipo.UserEo.FromMode,
            FromId = ipo.UserEo.FromId,
            //如果是长线版本，是需要扣除手续费的，根据当前的vip等级捞取对应的手续费配置
            CashRate = ipo.CashRate
        };
    }

    /// <summary>
    /// tejee直接提现
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    /// <exception cref="CustomException"></exception>
    private async Task<BraWithDrawDto> TejeeCash(BraWithDrawIpo ipo)
    {
        var ret = new BraWithDrawDto();

        var globalUserDCache = await GlobalUserDCache.Create(ipo.UserId);

        var request = new Xxyy.Banks.Client.BLL.Tejeepay.XxyyTejeeProxyPayIpo()
        {
            UserId = ipo.UserId,
            AppId = ipo.AppId,
            CurrencyId = ipo.CurrencyId,
            Amount = ipo.Amount.MToA(ipo.CurrencyId),
            UserIp = AspNetUtil.GetRemoteIpString(),
            Mobile = await globalUserDCache.GetMobileAsync(),
            Email = await globalUserDCache.GetEmailAsync(),
            CashRate = (decimal)ipo.CashRate,
            BankCardNo = ipo.BraUserBankEo.AccountNumber,
            BankCardName = ipo.BraUserBankEo.Name,
            BankCode = ipo.BraUserBankEo.BankCode,
            CountryId = ipo.CountryId
        };

        switch (ipo.CountryId)
        {
            case "BRA":
                request.BizEnum = 0;
                request.CertType = (int)ipo.BraUserBankEo.AccountType.ToEnumN<TejeePayMethod>();
                request.CertId = ipo.BraUserBankEo.AccountNumber;
                break;
            case "MEX":
                request.BizEnum = 1;
                break;
            default:
                break;
        }

        var xxyyBankClient = new Xxyy.Banks.Client.BLL.Tejeepay.TejeepayClient();

        var response = await xxyyBankClient.TejeeCash(request);

        LogUtil.Info($"tejeePay提现.request:{JsonConvert.SerializeObject(ipo)},response:{JsonConvert.SerializeObject(response)}");

        if (response.Status != 200 || !response.Result.Status.Equals("SUCCESS"))
        {
            LogUtil.Error($"tejeePay提现.request:{JsonConvert.SerializeObject(ipo)},response:{JsonConvert.SerializeObject(response)}");

            throw new CustomException(LobbyCodes.RS_CASH_ERROR, response.Message);
        }

        ret = response.Result.Map<BraWithDrawDto>();
        ret.Success = true;
        return ret;
    }

    /// <summary>
    /// letspay直接提现
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    /// <exception cref="CustomException"></exception>
    private async Task<BraWithDrawDto> LetspayCash(BraWithDrawIpo ipo)
    {
        var ret = new BraWithDrawDto();
        var request = new Xxyy.Banks.Client.BLL.Letspay.XxyyLetsProxyPayIpo()
        {
            accountName = ipo.BraUserBankEo.Name,
            accountNo = ipo.BraUserBankEo.AccountNumber,
            bankCode = ipo.BraUserBankEo.AccountType,
            email = string.IsNullOrWhiteSpace(ipo.UserEo.Email) ? "test@lucro777.com" : ipo.UserEo.Email,
            phone = string.IsNullOrWhiteSpace(ipo.UserEo.Mobile) ? "12345678901" : ipo.UserEo.Mobile,
            cpf = ipo.BraUserBankEo.AccountNumber,
            Amount = ipo.Amount.MToA(ipo.CurrencyId),
            UserId = ipo.UserId,
            AppId = ipo.AppId,
            CurrencyId = ipo.CurrencyId,
            UserIp = AspNetUtil.GetRemoteIpString(),
            CashRate = (decimal)ipo.CashRate,
            CountryId = ipo.CountryId,
            taxId = ipo.BraUserBankEo.TaxId,
            mode = "bank"
        };

        ApiResult<BaseDto> response = null;

        switch (ipo.CountryId)
        {
            case "MEX":
                response = await new Xxyy.Banks.Client.BLL.Letspay.LetspayClient().LetsCashMex(request);
                break;
            case "BRA":
                response = await new Xxyy.Banks.Client.BLL.Letspay.LetspayClient().LetsCash(request);
                break;
            default:
                LogUtil.Info($"bra提现（bra提现letspay）,request:{JsonConvert.SerializeObject(request)},用户国家编码异常:{ipo.CountryId}");
                throw new CustomException("Abnormal country code");
        }

        LogUtil.Info($"bra提现letspay.request:{JsonConvert.SerializeObject(ipo)},response:{JsonConvert.SerializeObject(response)}");

        if (response == null
            || response.Status != 200
            || !response.Result.Status.Equals(Xxyy.Banks.Client.ResponseCodes.RS_OK))
        {
            LogUtil.Error($"bra提现（bra提现letspay）.request:{JsonConvert.SerializeObject(ipo)},response:{JsonConvert.SerializeObject(response)}");

            throw new CustomException(LobbyCodes.RS_CASH_ERROR, response.Result.Message);
        }

        ret = response.Result.Map<BraWithDrawDto>();
        ret.Success = true;
        return ret;
    }

    /// <summary>
    /// mlpay直接提现
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    /// <exception cref="CustomException"></exception>
    private async Task<BraWithDrawDto> MlpayCash(BraWithDrawIpo ipo)
    {
        var ret = new BraWithDrawDto();
        var request = new Xxyy.Banks.Client.BLL.Mlpay.XxyyMlpayCashIpo()
        {
            AccountName = ipo.BraUserBankEo.Name,
            AccountNo = ipo.BraUserBankEo.AccountNumber,
            BankCode = ipo.BraUserBankEo.AccountType,
            Email = string.IsNullOrWhiteSpace(ipo.UserEo.Email) ? "test@lucro777.com" : ipo.UserEo.Email,
            Phone = string.IsNullOrWhiteSpace(ipo.UserEo.Mobile) ? "12345678901" : ipo.UserEo.Mobile,
            //Cpf = ipo.BraUserBankEo.AccountNumber,
            Amount = ipo.Amount.MToA(ipo.CurrencyId),
            UserId = ipo.UserId,
            AppId = ipo.AppId,
            CurrencyId = ipo.CurrencyId,
            UserIp = AspNetUtil.GetRemoteIpString(),
            CashRate = (decimal)ipo.CashRate,
            CountryId = ipo.CountryId,
            TaxId = ipo.BraUserBankEo.TaxId
        };

        var response = await new Xxyy.Banks.Client.BLL.Mlpay.MlpayClient().MlpayCash(request);

        LogUtil.Info($"bra提现mlpay.request:{JsonConvert.SerializeObject(ipo)},response:{JsonConvert.SerializeObject(response)}");

        if (response == null
            || response.Status != 200
            || !response.Result.Status.Equals(Xxyy.Banks.Client.ResponseCodes.RS_OK))
        {
            LogUtil.Error($"bra提现（bra提现mlpay）.request:{JsonConvert.SerializeObject(ipo)},response:{JsonConvert.SerializeObject(response)}");

            throw new CustomException(LobbyCodes.RS_CASH_ERROR, response.Result.Message);
        }

        ret = response.Result.Map<BraWithDrawDto>();
        ret.Success = true;
        return ret;
    }

    /// <summary>
    /// 巴西提现（tejeePay）
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    public async Task<BraWithDrawDto> BraTejeePayWithDraw(BraWithDrawIpo ipo)
    {
        var ret = new BraWithDrawDto();

        //初始化ipo，并验证用户基本信息
        await BuildBraWithDrawIpo(ipo);

        //墨西哥充值金额只能是正整数
        if (ipo.CountryId.Equals("MEX") && !StringUtil.IsPositiveInteger(ipo.Amount.ToString()))
        {
            throw new CustomException(LobbyCodes.RS_PARAMETER_ERROR, "withdraw.param error.The recharge amount must be a positive integer");
        }


        var cashService = CashServiceFactory<BraWithDrawIpo>.CreateCashService(ipo.OperatorId, ipo.CurrencyId);

        //校验是否满足提现条件
        await cashService.CheckCashCondition(ipo);

        //是否需要审批
        if (await cashService.IsAudit(ipo))
        {
            ret.IsAudit = true;

            TransactionManager tm = new TransactionManager();

            try
            {
                ipo.Amount = ipo.Amount.MToA(ipo.CurrencyId);

                var cashAuditEo = await BuildCashAuditEo(ipo);
                var addCashAuditRet = await new Sc_cash_auditMO().AddAsync(cashAuditEo, tm);

                //3、写入S_currency_change用户奖励变化表
                var changeMsg = await ipo.CurrencyChangeServices.Add(new CurrencyChangeReq()
                {
                    UserId = ipo.UserId,
                    AppId = ipo.AppId,
                    OperatorId = ipo.OperatorId,
                    CurrencyId = ipo.CurrencyId,
                    Reason = "提现审核预扣除",
                    Amount = cashAuditEo.Amount * -1,
                    SourceType = 2,
                    SourceTable = "sc_cash_audit",
                    SourceId = cashAuditEo.CashAuditID,
                    ChangeTime = DateTime.UtcNow,
                    TM = tm,
                    ChangeBalance = CurrencyChangeBalance.FirstBonus
                });

                if (addCashAuditRet <= 0) throw new CustomException("cash failed.");

                ret.Success = true;
                tm.Commit();

                if (changeMsg != null) await MQUtil.PublishAsync(changeMsg);
            }
            catch (Exception ex)
            {
                tm.Rollback();
                ret.Success = false;
                ret.Message = ex.Message;

                if (ex is CustomException)
                    throw new CustomException(LobbyCodes.RS_UNKNOWN, ex.Message);
                else
                    LogUtil.Error($"braWithdraw.提交提款审批失败，ipo:{JsonConvert.SerializeObject(ipo)},errorMsg:{ex.Message}");
            }
            return ret;
        }
        else
        {
            try
            {
                if (ipo.BraPayChannel == BraPayChannel.tejeepay)
                    return await TejeeCash(ipo);
                else if (ipo.BraPayChannel == BraPayChannel.letspay)
                    return await LetspayCash(ipo);
                else if (ipo.BraPayChannel == BraPayChannel.mlpay)
                    return await MlpayCash(ipo);
                else
                    throw new CustomException(LobbyCodes.RS_CASH_ERROR, $"Channels error.channel:{ipo.BraPayChannel.ToString()}");
            }
            catch (Exception ex)
            {
                throw new CustomException(LobbyCodes.RS_CASH_ERROR, $"direct cash error:{ex.Message}");
            }
        }
    }

    #endregion

    #endregion

    #endregion

    #region hubtel 加纳手机钱包

    /// <summary>
    /// 获取手机钱包支付渠道
    /// </summary>
    /// <returns></returns>
    public async Task<List<string>> HubtelChannels(HubtelChannelsIpo ipo)
    {
        //var response = await _xxyyBankClient.GetHubtelChannels(ipo.Map<Xxyy.Common.Partners.Banks.HubtelChannelsClientIpo>());
        //if (!response.Status.Equals(ResponseCodes.RS_OK))
        //    throw new Exception($"获取手机钱包支付渠道失败.ipo:{JsonConvert.SerializeObject(ipo)},status:{response.Status}");

        //return response.Channels.ToList();

        return new List<string>();
    }

    /// <summary>
    /// Hubtel充值
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    public async Task<DepositOrWithdrawDto> HubtelDeposit(DepositOrWithdrawIpo ipo)
    {
        //从缓存中获取当前用户个人信息
        //var personalInfoDCache = new PersonalInfoDCache(ipo.UserId);
        //var ret = await personalInfoDCache.GetAsync();
        //if (!ret.HasValue)
        //    throw new CustomException("illegal request.");

        //ipo.Mobile = ret.Value.PhoneNumber;
        //ipo.Amount = ipo.Amount.MToA(ipo.CurrencyId);

        //var response = await _xxyyBankClient.HubtelPay(ipo.Map<Xxyy.Common.Partners.Banks.HubtelPayClientIpo>());

        //if (!response.Status.Equals(ResponseCodes.RS_OK))
        //    throw new Exception($"Hubtel充值失败.原因:{response.Message}ipo:{JsonConvert.SerializeObject(ipo)},status:{response.Status}");

        //return response.Map<DepositOrWithdrawDto>();

        return new DepositOrWithdrawDto();
    }

    /// <summary>
    /// Hubtel提现
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    public async Task<DepositOrWithdrawDto> HubtelWithdraw(DepositOrWithdrawIpo ipo)
    {
        //从缓存中获取当前用户个人信息
        //var personalInfoDCache = new PersonalInfoDCache(ipo.UserId);
        //var ret = await personalInfoDCache.GetAsync();
        //if (!ret.HasValue)
        //    throw new CustomException("illegal request.");

        //ipo.Mobile = ret.Value.PhoneNumber;
        //ipo.Amount = ipo.Amount.MToA(ipo.CurrencyId);

        //var response = await _xxyyBankClient.HubtelCash(ipo.Map<Xxyy.Common.Partners.Banks.HubtelCashClientIpo>());

        //if (!response.Status.Equals(ResponseCodes.RS_OK))
        //    throw new Exception($"Hubtel提现失败.ipo:{JsonConvert.SerializeObject(ipo)},status:{response.Status}");

        //return response.Map<DepositOrWithdrawDto>();
        return new DepositOrWithdrawDto();
    }

    #endregion

    #region SPEI充值、提现

    /// <summary>
    /// Spei充值
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    public async Task<SpeiDepositDto> SpeiDeposit(SpeiDepositIpo ipo)
    {
        Xxyy.Banks.Client.BLL.Mongopay.MongopayDto response = null;
        try
        {
            var xxyyBankClient = new Xxyy.Banks.Client.BLL.Mongopay.MongopayClient();

            response = (await xxyyBankClient.SpeiPay(ipo.Map<Xxyy.Banks.Client.BLL.Mongopay.XxyyMongopayIpo>())).Result;
        }
        catch (Exception ex)
        {
            throw new CustomException(ex.Message);
        }

        Log.Information($"Spei充值,request:{JsonConvert.SerializeObject(ipo)},response:{JsonConvert.SerializeObject(response)}");

        if (!response.Status.Equals(ResponseCodes.RS_OK))
        {
            var exception = new Exception($"{response.Status}");

            LogUtil.GetContextLogger().AddMessage($"Spei充值,request:{JsonConvert.SerializeObject(ipo)},response:{JsonConvert.SerializeObject(response)}");

            throw exception;
        }

        return response.Map<SpeiDepositDto>();

    }

    /// <summary>
    /// 提现服务费
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    public async Task<CashConfirmDto> CashConfirm(SpeiWithdrawIpo ipo)
    {
        var ret = new CashConfirmDto();

        var payChannels = await LobbyUtil.GetPayChannel(ipo.OperatorId, ipo.CurrencyId, ipo.CountryId);

        XxyyCalcCashFeeIpo request = new Xxyy.Banks.Client.BLL.XxyyCalcCashFeeIpo()
        {
            //RequestUUID = ObjectId.NewId(),
            UserId = ipo.UserId,
            AppId = ipo.AppId,
            CurrencyId = ipo.CurrencyId,
            BankId = payChannels.ToString(),
            CountryId = ipo.CountryId,
            //UserIp = AspNetUtil.GetRemoteIpString(),
            Amount = ipo.Amount.MToA(ipo.CurrencyId),
            AdditionalParameters= ipo.AdditionalParameters
        };
        ApiResult<CalcCashFeeDto> response = new ApiResult<CalcCashFeeDto>();

        if(payChannels== BraPayChannel.pandapay)
        {
            throw new CustomException(LobbyCodes.RS_UNKNOWN, "Unsupported payment channels.");
        }
        response = await new Xxyy.Banks.Client.BLL.BaseClient().CashFee(request);
        //if (payChannels == BraPayChannel.mlpay || payChannels == BraPayChannel.letspay || payChannels == BraPayChannel.tejeepay || payChannels == BraPayChannel.bfpay)
        //{
        //    response = await new Xxyy.Banks.Client.BLL.BaseClient().CashFee(request);
        //}
        //else
        //{
        //    throw new CustomException(LobbyCodes.RS_UNKNOWN, "Unsupported payment channels.");
        //}

        LogUtil.Info($"提现确认.request:{JsonConvert.SerializeObject(request)},response:{JsonConvert.SerializeObject(response)}");

        if (response.Status != 200 || !response.Result.Status.Equals("success"))
        {

            LogUtil.GetContextLogger().AddMessage($"提现确认.request:{JsonConvert.SerializeObject(request)},response:{JsonConvert.SerializeObject(response)}");

            throw new CustomException(LobbyCodes.RS_CASH_ERROR, response.Message);
        }

        ret = response.Result.Map<CashConfirmDto>();

        var userExEO = await DbSink.BuildUserExMo(ipo.UserId).GetSingleAsync("UserID = @UserID", ipo.UserId);

        //提现配置
        var cashConfig = await LobbyUtil.GetCashConfig(ipo.OperatorId, ipo.CurrencyId);

        if (cashConfig.CashPayAmount > 0 && userExEO.TotalPayAmount < cashConfig.CashPayAmount)
        {
            ret.Data.IsMinPay = false;
            ret.Data.MinPay = cashConfig.CashPayAmount.AToM(ipo.CurrencyId);
        }

        return ret;
    }

    public async Task<CashFeeDto> CashFee(CashFeeIpo ipo)
    {
        var ret = new CashFeeDto();

        var payChannels = await LobbyUtil.GetPayChannel(ipo.OperatorId, ipo.CurrencyId, ipo.CountryId);
        //用户当前vip等级配置
        var userEo = await DbSink.BuildUserMo(ipo.UserId).GetByPKAsync(ipo.UserId);
        //var vipConfigList = LobbyDbCacheUtil.GetOperatorVipConfigList(ipo.OperatorId);
        var currVipConfig = Lobby.Flow.Caching.DbCacheUtil.GetVipConfigNoException(ipo.OperatorId,userEo.VIP); //vipConfigList.Where(d => d.VipGrade == userEo.VIP).FirstOrDefault();
        var cashRate =(decimal)(currVipConfig?.CashRate??0f);
        XxyyCalcCashFeeIpo request = new Xxyy.Banks.Client.BLL.XxyyCalcCashFeeIpo()
        {
            //RequestUUID = ObjectId.NewId(),
            UserId = ipo.UserId,
            AppId = ipo.AppId,
            CurrencyId = ipo.CurrencyId,
            BankId = payChannels.ToString(),
            CountryId = ipo.CountryId,
            CashRate= cashRate,
            //UserIp = AspNetUtil.GetRemoteIpString(),
            Amount = ipo.Amount.MToA(ipo.CurrencyId),
            AdditionalParameters = ipo.AdditionalParameters
        };
        var response = await new Xxyy.Banks.Client.BLL.BaseClient().CashFee(request);
        ret = response.Result.Map<CashFeeDto>();
        return ret;
    }

    /// <summary>
    /// Spei提现
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    public async Task<SpeiDepositOrWithdrawDto> SpeiWithdraw(SpeiWithdrawIpo ipo)
    {
        var ret = new SpeiDepositOrWithdrawDto();

        var userExMo = DbSink.BuildUserExMo(ipo.UserId);

        var userExEo = await userExMo.GetSingleAsync("UserID = @UserID", ipo.UserId);

        if (userExEo == null)
            throw new CustomException(ResponseCodes.RS_UNKNOWN, "Data does not exist.", result: ret);

        //如果用户下注总额小于充值总额，则不允许发起提现
        if (userExEo.TotalBetAmount < userExEo.TotalPayAmount)
            throw new CustomException(ResponseCodes.RS_UNKNOWN, "Withdrawal not allowed.", result: ret);

        //提现审批校验
        var cashConfig = await LobbyUtil.GetCashConfig(ipo.OperatorId, ipo.CurrencyId);
        //如果提现金额小于最低提现金额
        if (ipo.Amount < cashConfig.CashMinAmount.AToM(ipo.CurrencyId))
            throw new CustomException(ResponseCodes.RS_UNKNOWN, $"Minimum amount {cashConfig.CashMinAmount}.");

        ////不允许提现情况
        ////1、下注总额 < 最低提现配置
        ////2、充值总额 < 最低充值总额
        ////3、下注总额 < 最低充值总额
        ////4、下注总额 < 充值总额
        if (userExEo.TotalBetAmount < cashConfig.CashMinAmount ||
            userExEo.TotalPayAmount < cashConfig.CashPayAmount ||
            userExEo.TotalBetAmount < cashConfig.CashPayAmount ||
            userExEo.TotalBetAmount < userExEo.TotalPayAmount)
            throw new CustomException(ResponseCodes.RS_UNKNOWN, "Condition not met.");

        Xxyy.Common.Services.UserService userService = new Xxyy.Common.Services.UserService(ipo.UserId);
        var userMo = userService.GetUserMo();
        var userEo = await userMo.GetByPKAsync(ipo.UserId);

        CurrencyChangeService currencyChangeService = new CurrencyChangeService(ipo.UserId);


        if (ipo.Amount.MToA(ipo.CurrencyId) > userEo.Cash)
            throw new CustomException(CommonCodes.RS_NOT_ENOUGH_MONEY, "Sorry, your credit is running low.", result: ret);

        //大于等于配置值的提现需要审批
        if (ipo.Amount >= cashConfig.AuditStartAmount.AToM(ipo.CurrencyId))
        {
            List<bool> resultList = new List<bool>();

            var cashAuditMo = new Sc_cash_auditMO();

            TransactionManager tm = new TransactionManager();

            try
            {
                userEo = await userMo.GetByPKAsync(ipo.UserId);
                //1、更新用户余额，预扣除
                //resultList.Add(await commonUserService.UpdateBalance(ipo.CurrencyId, ipo.Amount.MToA(ipo.CurrencyId) * -1, tm));
                //2、写入提现审核
                var cashAuditId = ObjectId.NewId();
                ipo.Amount = ipo.Amount.MToA(ipo.CurrencyId);
                var requestParam = ipo.Map<XxyyMongoCashIpo>();
                requestParam.CashAuditId = cashAuditId;
                //requestParam.AppOrderId = ObjectId.NewId();
                //requestParam.BankId = "mongopay";
                var cashAuditEo = new Sc_cash_auditEO()
                {
                    CashAuditID = cashAuditId,
                    UserID = ipo.UserId,
                    OperatorID = ipo.OperatorId,
                    CountryID = ipo.CountryId,
                    CurrencyID = ipo.CurrencyId,
                    AppID = ipo.AppId,
                    Mobile = userEo.Mobile,
                    Amount = (long)ipo.Amount,
                    BankCode = ipo.BankCode,
                    BankName = ipo.AccName,
                    AccName = ipo.AccName,
                    AccNumber = ipo.AccNumber,
                    Status = 0,
                    Paytype = (int)Xxyy.Banks.Client.ClientPayTypeEnum.Spei,
                    BankID = "mongopay",
                    RequestParam = JsonConvert.SerializeObject(requestParam),
                    ApplyTime = DateTime.UtcNow
                };
                resultList.Add(await cashAuditMo.AddAsync(cashAuditEo, tm) > 0);
                //3、写入S_currency_change用户奖励变化表


                var changeMsg = await currencyChangeService.Add(new CurrencyChangeReq()
                {
                    UserId = ipo.UserId,
                    AppId = ipo.AppId,
                    OperatorId = ipo.OperatorId,
                    CurrencyId = ipo.CurrencyId,
                    Reason = "提现审核预扣除",
                    Amount = cashAuditEo.Amount * -1,
                    SourceType = 2,
                    SourceTable = "sc_cash_audit",
                    SourceId = cashAuditEo.CashAuditID,
                    ChangeTime = DateTime.UtcNow,
                    TM = tm,
                    ChangeBalance = CurrencyChangeBalance.FirstBonus
                });

                if (resultList.Any(d => !d))
                    throw new CustomException("cash failed.");

                ret.Success = true;
                tm.Commit();
                if (changeMsg != null)
                    await MQUtil.PublishAsync(changeMsg);
            }
            catch (Exception ex)
            {
                tm.Rollback();
                ret.Success = false;
                ret.Message = ex.Message;
                LogUtil.Error($"SpeiWithdraw,提交提款审批失败，ipo:{JsonConvert.SerializeObject(ipo)},errorMsg:{ex.Message}");
            }
            return ret;
        }
        else
        {
            ipo.Amount = ipo.Amount.MToA(ipo.CurrencyId);
            var xxyyBankClient = new Xxyy.Banks.Client.BLL.Mongopay.MongopayClient();
            var response = await xxyyBankClient.SpeiCash(ipo.Map<XxyyMongoCashIpo>());

            LogUtil.Info($"Spei提现,request:{JsonConvert.SerializeObject(ipo)},response:{JsonConvert.SerializeObject(response)}");

            if (!response.Status.Equals(ResponseCodes.RS_OK))
            {
                var exception = new Exception($"{response.Status}");

                LogUtil.GetContextLogger().AddMessage($"Spei提现,request:{JsonConvert.SerializeObject(ipo)},response:{JsonConvert.SerializeObject(response)}");

                throw exception;
            }

            return response.Result.Map<SpeiDepositOrWithdrawDto>();
        }
    }

    /// <summary>
    /// 获取Spei支持的银行列表
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    public async Task<List<SpeiBanksDto>> SpeiBanks(SpeiBanksIpo ipo)
    {
        var speiBanksDCache = SpeiBanksDCache.Create();
        var cacheData = await speiBanksDCache.GetOrLoadAsync();

        if (cacheData == null || !cacheData.HasValue || !cacheData.Value.Any())
            return new List<SpeiBanksDto>();

        return cacheData.Map<List<SpeiBanksDto>>();
    }

    #endregion

    #region 充值、提现订单

    /// <summary>
    /// 获取订单信息
    /// </summary>
    /// <returns></returns>
    public async Task<OrderDto> GetOrder(OrderIpo ipo)
    {
        var xxyyBankClient = new Xxyy.Banks.Client.BLL.Tejeepay.TejeepayClient();

        var order = await xxyyBankClient.GetOrder(ipo.Map<Xxyy.Banks.Client.BLL.XxyyGetOrderIpo>());

        if (order.Status != 200 || !order.Result.Status.Equals(ResponseCodes.RS_OK))
            throw new CustomException(LobbyCodes.RS_UNKNOWN, $"GetOrderError.statue:{order.Status}");

        Log.Information($"GetOrder,request:{JsonConvert.SerializeObject(ipo)},response:{JsonConvert.SerializeObject(order)}");

        return order.Result.Map<OrderDto>();
    }

    #endregion


    #region 充值、提现记录

    /// <summary>
    /// 充值、提现记录
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    public async Task<List<PayCashRecordsDto>> DepositWithDrawRecords(DepositOrWithDrawRecordsIpo ipo)
    {
        if (ipo.Type == 1)
        {
            var ret = await new PayRecordsDCache(ipo.UserId, ipo.StartDate.Value, ipo.EndDate.Value).GetAsync(true);

            if (ret == null || !ret.Any()) return ret;

            ret = ret.Where(d => d.ApplyTime >= ipo.StartDate && d.ApplyTime < ipo.EndDate)
                .OrderBy(d => d.Status)
                .ThenBy(d => d.ApplyTime)
                .Skip((ipo.PageIndex - 1) * ipo.PageSize)
                .Take(ipo.PageSize)
                .ToList();

            return ret;
        }
        if (ipo.Type == 2)
        {
            var ret = await new CashRecordsDCache(ipo.UserId, ipo.StartDate.Value, ipo.EndDate.Value).GetAsync(true);

            if (ret == null || !ret.Any()) return ret;

            //查询排序
            ret = ret.Where(d => d.ApplyTime >= ipo.StartDate && d.ApplyTime < ipo.EndDate)
                .OrderBy(d => d.Status)
                .ThenBy(d => d.ApplyTime)
                .Skip((ipo.PageIndex - 1) * ipo.PageSize)
                .Take(ipo.PageSize)
                .ToList();

            return ret;
        }

        if (ipo.Type == 3)
        {
            var ret = await new BonusRecordDCache(ipo.UserId, ipo.StartDate.Value, ipo.EndDate.Value).GetAsync(true);

            if (ret == null || !ret.Any()) return ret;

            //查询排序
            ret = ret.Where(d => d.ApplyTime >= ipo.StartDate && d.ApplyTime < ipo.EndDate)
                .OrderBy(d => d.Status)
                .ThenBy(d => d.ApplyTime)
                .Skip((ipo.PageIndex - 1) * ipo.PageSize)
                .Take(ipo.PageSize)
                .ToList();

            return ret;
        }

        return new List<PayCashRecordsDto>();
    }

    #endregion


    #region DiscountRecords 

    /// <summary>
    /// 奖励记录
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    public async Task<List<DiscountRecordDto>> DiscountRecords(DiscountRecordIpo ipo)
    {
        return new List<DiscountRecordDto>();

        //var field = DiscountRecordDCache.GetField(ipo.OperatorId, ipo.CurrencyId);
        //var discountRecords = new DiscountRecordDCache(ipo.UserId);

        //var dCacheData = discountRecords.GetOrLoad(field);

        //if (!dCacheData.HasValue)
        //    return null;

        //var ret = new List<DiscountRecordDto>();

        ////查询
        //ret = dCacheData.Value.Where(d => d.RecDate >= ipo.StartDate && d.RecDate < ipo.EndDate).Map<List<DiscountRecordDto>>();
        ////排序
        //ret = ret.OrderBy(d => d.Status).ThenBy(d => d.UpdateTime).Skip((ipo.PageIndex - 1) * ipo.PageSize).Take(ipo.PageSize).ToList();

        //return ret;
    }

    #endregion

    #region 充值、提现、bonus奖励、下注记录

    /// <summary>
    /// 充值记录
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    public async Task<List<PayCashRecordsDto>> PayRecords(UserRecordsIpo ipo)
    {
        if (ipo.StartDate == default || ipo.EndDate == default)
        {
            ipo.EndDate = DateTime.UtcNow;
            ipo.StartDate = DateTime.UtcNow.AddDays(-90);
        }
        var ret = await new PayRecordsDCache(ipo.UserId, ipo.StartDate.Value, ipo.EndDate.Value).GetAsync(true);

        if (ret == null || !ret.Any()) return ret;

        ret = ret.WhereIF(ipo.StartDate != null && ipo.EndDate != null, d => d.ApplyTime >= ipo.StartDate && d.ApplyTime <= ipo.EndDate)
            .OrderByDescending(d => d.ApplyTime)
            .Skip((ipo.PageIndex - 1) * ipo.PageSize)
            .Take(ipo.PageSize)
            .ToList();

        return ret;
    }

    /// <summary>
    /// 提现记录
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    public async Task<List<PayCashRecordsDto>> CashRecords(UserRecordsIpo ipo)
    {
        if (ipo.StartDate == null || ipo.EndDate == null)
        {
            ipo.EndDate = DateTime.UtcNow;
            ipo.StartDate = DateTime.UtcNow.AddDays(-90);
        }
        var ret = await new CashRecordsDCache(ipo.UserId, ipo.StartDate.Value, ipo.EndDate.Value).GetAsync(true);

        if (ret == null || !ret.Any()) return ret;

        //查询排序
        ret = ret.WhereIF(ipo.StartDate != null && ipo.EndDate != null, d => d.ApplyTime >= ipo.StartDate && d.ApplyTime <= ipo.EndDate)
            .OrderByDescending(d => d.ApplyTime)
            .Skip((ipo.PageIndex - 1) * ipo.PageSize)
            .Take(ipo.PageSize)
            .ToList();

        return ret;
    }

    /// <summary>
    /// Bonus奖励记录
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    public async Task<List<PayCashRecordsDto>> BonusRecords(UserRecordsIpo ipo)
    {
        if (ipo.StartDate == null || ipo.EndDate == null)
        {
            ipo.EndDate = DateTime.UtcNow;
            ipo.StartDate = DateTime.UtcNow.AddDays(-90);
        }
        var ret = await new BonusRecordDCache(ipo.UserId, ipo.StartDate.Value, ipo.EndDate.Value).GetAsync(true);

        if (ret == null || !ret.Any()) return ret;

        //查询排序
        ret = ret.WhereIF(ipo.StartDate != null && ipo.EndDate != null, d => d.ApplyTime >= ipo.StartDate && d.ApplyTime <= ipo.EndDate)
            .OrderByDescending(d => d.ApplyTime)
            .Skip((ipo.PageIndex - 1) * ipo.PageSize)
            .Take(ipo.PageSize)
            .ToList();

        return ret;
    }

    /// <summary>
    /// 获取用户vip相关信息
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    /// <exception cref="CustomException"></exception>
    public async Task<UserVipInfoDto> GetVipInfo(UserVipInfoIpo ipo)
    {
        var userSvc = new Xxyy.Common.Services.UserService(ipo.UserId);
        var userMo = userSvc.GetUserMo();
        if (userMo == null)
            throw new CustomException(LobbyCodes.RS_ILLEGAL_REQUEST, "illegal request.");
        var userInfo = await userMo.GetByPKAsync(ipo.UserId);
        var ret = new UserVipInfoDto
        {
            Vip = userInfo.VIP,
            Point = userInfo.Point.AToM(ipo.CurrencyId)
        };

        var vipConfigList = LobbyDbCacheUtil.GetOperatorVipConfigList(ipo.OperatorId);
        var vipMaxGrade = vipConfigList.Select(v => v.VipGrade).Max();//最高vip等级
        var nextVipConfig = LobbyDbCacheUtil.GetVipConfig(ipo.OperatorId, userInfo.VIP + 1 > vipMaxGrade ? userInfo.VIP : userInfo.VIP + 1);
        ret.GradeReward = nextVipConfig.GradeReward.AToM(ipo.CurrencyId);
        if (userInfo.VIP > 0)
        {
            var currVipConfig = LobbyDbCacheUtil.GetVipConfig(ipo.OperatorId, userInfo.VIP);
            ret.WeekReward = currVipConfig.WeekReward.AToM(ipo.CurrencyId);
            if (userInfo.VIP < vipMaxGrade)
            {
                ret.UpgradeRequireBet = (nextVipConfig.BetMinAmount - currVipConfig.BetMinAmount).AToM(ipo.CurrencyId);
                ret.UpgradeHasBet = (userInfo.Point - currVipConfig.BetMinAmount).AToM(ipo.CurrencyId);
            }
            else
            {
                ret.GradeReward = 0;
                ret.UpgradeRequireBet = userInfo.Point.AToM(ipo.CurrencyId);
                ret.UpgradeHasBet = userInfo.Point.AToM(ipo.CurrencyId);
            }
        }
        else
        {
            ret.WeekReward = 0;
            ret.UpgradeRequireBet = nextVipConfig.BetMinAmount.AToM(ipo.CurrencyId);
            ret.UpgradeHasBet = userInfo.Point.AToM(ipo.CurrencyId);
        }

        ret.UpgradeHasBet = ret.UpgradeHasBet > ret.UpgradeRequireBet ? 0 : ret.UpgradeHasBet;

        return ret;
    }

    #endregion

    #region ==PGTADA提现渠道==

    /// <summary>
    /// PGTADA提现页面加载
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    public async Task<LoadInfoDto> LoadInfo(LoadInfoIpo ipo)
    {
        var loadInfoDto = new LoadInfoDto();
        var globalUserDCache = await GlobalUserDCache.Create(ipo.UserId);
        ipo.OperatorId = await globalUserDCache.GetOperatorIdAsync();
        ipo.CurrencyId = await globalUserDCache.GetCurrencyIdAsync();
        ipo.CountryId = await globalUserDCache.GetCountryIdAsync();

        //从缓存获取提现渠道信息列表        
        loadInfoDto.ChannelInfo = await GeChannelInfoAsync(ipo, globalUserDCache);

        //获取用户最新流水订单信息
        var flowService = FlowServiceFactory.CreateFlowService(ipo.UserId, ipo.AppId, ipo.OperatorId);
        var flowProgressRet = await flowService.GetFlowProgress();
        loadInfoDto.FlowInfo = null == flowProgressRet.FlowOrder ? new FlowInfoDto { 
              OrderDate=null
        } : new FlowInfoDto
        {
            OrderDate = flowProgressRet.FlowOrder.OrderDate,
            FlowMultip = flowProgressRet.FlowOrder.FlowMultip,
            OrderAmount = flowProgressRet.FlowOrder.OrderAmount,
            CompletedFlow = flowProgressRet.FlowOrder.CompletedFlow,
            RequireFlow = flowProgressRet.FlowOrder.RequireFlow,
        };

        //获取用户信息(包含银行信息)
        loadInfoDto.UserInfo = await GetUserInfoAsync(ipo, globalUserDCache);
        loadInfoDto.UserInfo.CashMoney = flowProgressRet.CashMoney;

        return loadInfoDto;
    }

    /// <summary>
    /// 获取提现渠道信息
    /// </summary>
    /// <param name="ipo"></param>
    /// <param name="globalUserDCache"></param>
    /// <returns></returns>
    private static async Task<List<ChannelInfoDto>> GeChannelInfoAsync(LoadInfoIpo ipo, GlobalUserDCache globalUserDCache)
    {
        //用户是否有过提现
        var channelList = new List<BraPayChannel> { BraPayChannel.tejeepay, BraPayChannel.letspay, BraPayChannel.mlpay };
        var userHasCash = await globalUserDCache.GetHasCashAsync();
        var cashConfigfield = CashConfigDCache.GetField(ipo.OperatorId, ipo.CurrencyId);
        var cashConfigDCache = await new CashConfigDCache().GetOrLoadAsync(cashConfigfield);

        var cashLimitList = new List<ChannelInfoDto>();
        if (cashConfigDCache.HasValue)
        {
            foreach (var item in channelList)
            {
                var cashLimit = cashConfigDCache.Value.Map<ChannelInfoDto>();
                cashLimit.Channels = (int)item;
                cashLimit.ChannelsDesc = Enum.GetName(item);
                cashLimit.MinAmount = !userHasCash ? cashConfigDCache.Value.FirstCashMinAmount.AToM(ipo.CurrencyId) : cashConfigDCache.Value.CashMinAmount.AToM(ipo.CurrencyId);
                cashLimit.MaxAmount = cashConfigDCache.Value.CashMaxAmount.AToM(ipo.CurrencyId);
                cashLimitList.Add(cashLimit);
            }
        };
        return cashLimitList;
    }

    /// <summary>
    /// 获取用户信息(包含银行信息)
    /// </summary>
    /// <param name="ipo"></param>
    /// <param name="globalUserDCache"></param>
    /// <returns></returns>
    private static async Task<UserInfoDto> GetUserInfoAsync(LoadInfoIpo ipo, GlobalUserDCache globalUserDCache)
    {
        var mobile = await globalUserDCache.GetMobileAsync();
        var email = await globalUserDCache.GetEmailAsync();
        var hasCash = await globalUserDCache.GetHasCashAsync();
        var userBank = await new BraUserBankDCache(ipo.OperatorId, ipo.UserId).GetAsync();
        var userSvc = new User2Service(ipo.UserId);
        return new UserInfoDto
        {
            IsFirstCash = !hasCash && (await userSvc.GetBonus()) > 0,
            Mobile = mobile,
            Email = email,
            BankInfo = userBank.Value?.Map<List<UserBankDto>>()
        };
    }

    /// <summary>
    /// 获取用户最新流水订单信息(弃用)
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    private static async Task<FlowInfoDto> GetFlowInfoAsync(LoadInfoIpo ipo)
    {
        var flowOrder = await DbUtil.GetRepository<S_requireflow_orderPO>().AsQueryable()
            .Where(_ => _.UserID == ipo.UserId && _.Status == (int)RequireflowEnum.Initial)
            .OrderBy(_ => _.RecDate)
            .FirstAsync();
        if (null == flowOrder) return null;
        return new FlowInfoDto
        {
            OrderDate = flowOrder.RecDate,
            FlowMultip = flowOrder.FlowMultip,
            OrderAmount = flowOrder.OrderAmount.AToM(ipo.CurrencyId),
            CompletedFlow = flowOrder.CompletedFlow.AToM(ipo.CurrencyId),
            RequireFlow = flowOrder.RequireFlow.AToM(ipo.CurrencyId),
        };
    }

    #endregion

}
