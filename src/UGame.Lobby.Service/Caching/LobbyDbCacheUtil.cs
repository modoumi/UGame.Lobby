using UGame.Lobby.Service.Caching.Home;
using UGame.Lobby.Repository.ing;
using SqlSugar;
using AiUo;
using AiUo.DbCaching;

namespace UGame.Lobby.Service.Caching;

public static class LobbyDbCacheUtil
{

    #region l_app

    public static L_appPO GetLApp(string appId, bool exceptionOnNull = true, string errorCode = null)
    {
        var ret = DbCachingUtil.GetSingle<L_appPO>(d => new { d.AppID }, new L_appPO
        {
            AppID = appId
        });

        if (ret == null)
        {
            if (exceptionOnNull)
            {
                if (string.IsNullOrEmpty(errorCode))
                {
                    throw new Exception("AppId不存在: " + appId);
                }

                throw new CustomException(errorCode, "AppId不存在: " + appId);
            }

            return null;
        }

        return ret;
    }

    #endregion

    #region sc_vip_config

    public static Sc_vip_configPO GetVipConfig(string operatorId, int vipGrade)
    {
        var list = GetOperatorVipConfigList(operatorId);

        if (list == null || !list.Any())
            throw new Exception($"sc_vip_config不存在定义1。operatorId:{operatorId}");

        var ret = list.Where(d => d.VipGrade == vipGrade).FirstOrDefault();

        if (ret == null)
            throw new Exception($"sc_vip_config不存在定义1。operatorId:{operatorId},vipGrade:{vipGrade}");

        return ret;
    }

    public static List<Sc_vip_configPO> GetOperatorVipConfigList(string operatorId)
    {
        var ret = DbCachingUtil.GetList<Sc_vip_configPO>(d => new { d.OperatorID }, new Sc_vip_configPO
        {
            OperatorID = operatorId,
        });

        if (ret == null || !ret.Any())
            return new List<Sc_vip_configPO>();

        return ret.OrderBy(d => d.VipGrade).ToList();
    }

    #endregion

    #region sa_userpay100008_config

    public static Sa_userpay100008_configPO GetUserPay100008Config(string operatorId, string currencyId)
    {
        var ret = DbCachingUtil.GetSingle<Sa_userpay100008_configPO>(d => new { d.OperatorID, d.CurrencyID }, new Sa_userpay100008_configPO
        {
            OperatorID = operatorId,
            CurrencyID = currencyId
        });

        if (ret == null)
            throw new Exception($"sa_userpay100008_config不存在定义。operatorId:{operatorId},currencyId:{currencyId}");

        return ret;
    }

    #endregion

    #region sa_userpay100008_detail_config 

    public static List<Sa_userpay100008_detail_configPO> GetAllUserPay100008DetailConfigs(string operatorId, string currencyId)
    {
        var ret = DbCachingUtil.GetList<Sa_userpay100008_detail_configPO>(d => new { d.OperatorID, d.CurrencyID }, new Sa_userpay100008_detail_configPO
        {
            OperatorID = operatorId,
            CurrencyID = currencyId
        });

        if (ret == null || !ret.Any())
            return new List<Sa_userpay100008_detail_configPO>();

        return ret;
    }

    #endregion


    #region l_activity_operator 

    public static List<L_activity_operatorPO> GetAllActivityOperator(string operatorId, string currencyId)
    {
        var ret = DbCachingUtil.GetList<L_activity_operatorPO>(d => new { d.OperatorID, d.CurrencyID }, new L_activity_operatorPO
        {
            OperatorID = operatorId,
            CurrencyID = currencyId
        });

        if (ret == null || !ret.Any())
            return new List<L_activity_operatorPO>();

        return ret;
    }

    #endregion

    #region l_pay_config

    public static List<L_pay_configPO> GetAllPayConfig(string operatorId, string currencyId)
    {
        var ret = DbCachingUtil.GetList<L_pay_configPO>(d => new { d.OperatorID, d.CurrencyID }, new L_pay_configPO
        {
            OperatorID = operatorId,
            CurrencyID = currencyId
        });

        if (ret == null || !ret.Any())
            return new List<L_pay_configPO>();

        return ret;
    }

    #endregion

    #region sc_cash_config 

    public static List<Sc_cash_configPO> GetAllCashConfig(string operatorId, string currencyId)
    {
        var ret = DbCachingUtil.GetList<Sc_cash_configPO>(d => new { d.OperatorID, d.CurrencyID }, new Sc_cash_configPO
        {
            OperatorID = operatorId,
            CurrencyID = currencyId
        });

        if (ret == null)
            throw new Exception($"sc_cash_config不存在定义。operatorId:{operatorId},currencyId:{currencyId}");

        return ret;
    }

    #endregion

    #region sa_invite100013_config

    public static Sa_invite100013_configPO GetInvite100013Config(string operatorId, string currencyId)
    {
        var ret = DbCachingUtil.GetSingle<Sa_invite100013_configPO>(d => new { d.OperatorID, d.CurrencyID }, new Sa_invite100013_configPO
        {
            OperatorID = operatorId,
            CurrencyID = currencyId
        });

        if (ret == null)
            throw new Exception($"sa_invite100013_config不存在定义。operatorId:{operatorId},currencyId:{currencyId}");

        return ret;
    }

    #endregion

    #region sa_invitenum100013_config

    public static List<Sa_invitenum100013_configPO> GetInviteNum100013Config(string operatorId, string currencyId)
    {
        var ret = DbCachingUtil.GetList<Sa_invitenum100013_configPO>(d => new { d.OperatorID, d.CurrencyID }, new Sa_invitenum100013_configPO
        {
            OperatorID = operatorId,
            CurrencyID = currencyId
        });

        if (ret == null || !ret.Any())
            return new List<Sa_invitenum100013_configPO>();

        return ret;
    }

    #endregion

    #region sc_cash_condition_config

    public static List<Sc_cash_condition_configPO> GetAllCashConditionConfig(string operatorId, string currencyId)
    {
        var ret = DbCachingUtil.GetList<Sc_cash_condition_configPO>(d => new { d.OperatorID, d.CurrencyID }, new Sc_cash_condition_configPO
        {
            OperatorID = operatorId,
            CurrencyID = currencyId
        });

        if (ret == null || !ret.Any())
            return new List<Sc_cash_condition_configPO>();

        return ret;
    }

    #endregion

    #region sa_signin100012_config

    public static Sa_signin100012_configPO GetSignin100012Config(string operatorId, string currencyId)
    {
        var ret = DbCachingUtil.GetSingle<Sa_signin100012_configPO>(d => new { d.OperatorID, d.CurrencyID }, new Sa_signin100012_configPO
        {
            OperatorID = operatorId,
            CurrencyID = currencyId
        });
        if (ret == null)
            throw new Exception($"sa_signin100012_config不存在定义。operatorId:{operatorId},currencyId:{currencyId}");

        return ret;
    }

    #endregion

    #region sa_signin100012_odds

    public static List<Sa_signin100012_oddsPO> GetAllSignin100012Odds(string operatorId, string currencyId)
    {
        var ret = DbCachingUtil.GetList<Sa_signin100012_oddsPO>(d => new { d.OperatorID, d.CurrencyID }, new Sa_signin100012_oddsPO
        {
            OperatorID = operatorId,
            CurrencyID = currencyId
        });

        if (ret == null || !ret.Any())
            return new List<Sa_signin100012_oddsPO>();

        return ret.OrderBy(d => d.DateNumber).ThenBy(d => d.Reward).ToList();
    }

    #endregion

    #region sc_marquee_config

    public static Sc_marquee_configPO GetMarqueeConfig(string operatorId)
    {
        var ret = DbCachingUtil.GetSingle<Sc_marquee_configPO>(d => new { d.OperatorID }, new Sc_marquee_configPO
        {
            OperatorID = operatorId
        });

        if (ret == null)
            throw new Exception($"sc_marquee_config不存在定义。operatorId:{operatorId}");
        return ret;
    }

    #endregion

    #region sa_weeklycard_config

    public static List<Sa_weeklycard_configPO> GetWeeklyCardConfig(string operatorId, string currencyId)
    {
        var ret = DbCachingUtil.GetList<Sa_weeklycard_configPO>(d => new { d.OperatorID, d.CurrencyID }, new Sa_weeklycard_configPO
        {
            OperatorID = operatorId,
            CurrencyID = currencyId
        });

        if (ret == null || !ret.Any())
            return new List<Sa_weeklycard_configPO>();

        return ret;
    }

    #endregion

    #region sa_weeklycard_detail_config

    public static List<Sa_weeklycard_detail_configPO> GetAllWeeklyCardDetailConfigs(string operatorId, string currencyId)
    {
        var ret = DbCachingUtil.GetList<Sa_weeklycard_detail_configPO>(d => new { d.OperatorID, d.CurrencyID }, new Sa_weeklycard_detail_configPO
        {
            OperatorID = operatorId,
            CurrencyID = currencyId
        });

        if (ret == null || !ret.Any())
            return new List<Sa_weeklycard_detail_configPO>();

        return ret.OrderBy(d => d.WeeklyCardType).ThenBy(d => d.DateNumber).ThenBy(d => d.Bonus).ToList();
    }

    #endregion

    #region sb_bank_paytype_channelEO
    public static Sb_bank_paytype_channelPO GetBankPaytypeChannel(string bankId, int paytypeId, int channelId, bool excOnNull = true)
    {
        var ret = DbCachingUtil.GetSingle<Sb_bank_paytype_channelPO>(it => new
        { it.BankID, it.PaytypeID, it.PaytypeChannel }, new Sb_bank_paytype_channelPO
        {
            BankID = bankId,
            PaytypeID = paytypeId,
            PaytypeChannel = channelId

        });
        if (ret == null)
        {
            if (excOnNull)
                throw new Exception($"bankId:{bankId},channelId:{channelId}不存在!");
            return null;
        }
        return ret;
    }
    #endregion
}

