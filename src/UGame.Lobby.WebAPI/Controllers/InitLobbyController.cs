using UGame.Lobby.Service.Caching.Pay;
using UGame.Lobby.Service.Caching.WithDraw;
using UGame.Lobby.Service.Common;
using UGame.Lobby.Service.Services;
using UGame.Lobby.Service.Services.Init;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using AiUo.AspNet;
using AiUo.AspNet.ClientSign;
using AiUo.Data.SqlSugar;
using AiUo.Logging;
using Xxyy.Common;
using Xxyy.Common.Caching;
using Xxyy.DAL;

namespace UGame.Lobby.WebAPI.Controllers
{
    /// <summary>
    /// InitLobbyController
    /// </summary>
    [EnableCors()]
    [ClientSignFilter()]
    //[TypeFilter(typeof(CustomActionFilterAttribute))]
    public class InitLobbyController : AiUoControllerBase
    {
        private InitService _initService = new();

        /// <summary>
        /// 大厅load
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<LoadDto> Load(LoadIpo ipo)
        {
            ipo.UserId = base.UserId;
            return await _initService.Load(ipo);
        }

        /// <summary>
        /// 获取应用url
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<LobbyAppUrlDto> GetAppUrl(LobbyAppUrlIpo ipo)
        {
            ipo.UserId = base.UserId;
            return await _initService.GetAppUrl(ipo);
        }

        /// <summary>
        /// 获取用户余额
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<BalanceDto> GetBalance(LobbyBaseIpo ipo)
        {
            ipo.UserId = base.UserId;

            var ret = new BalanceDto();
            try
            {
                ret.EnableBonus = DbCacheUtil.GetOperator(ipo.OperatorId).EnableBonus;
                var sUserEo = await DbUtil.GetRepository<S_userPO>().AsQueryable()
                    .Where(d => d.UserID.Equals(ipo.UserId)).FirstAsync();

                if (sUserEo == null)
                    throw new CustomException(LobbyCodes.RS_UNREGISTER, "user does not exist.");

                //真金+bonus
                ret.Cash = sUserEo.Cash.AToM(sUserEo.CurrencyID);
                //bonus
                ret.Bonus = sUserEo.Bonus.AToM(sUserEo.CurrencyID);

                var globalUserDCache = await GlobalUserDCache.Create(ipo.UserId);
                //用户是否有过提现
                var userHasCash = await globalUserDCache.GetHasCashAsync();

                //提现最小、最大限制
                var cashConfigfield = CashConfigDCache.GetField(ipo.OperatorId, ipo.CurrencyId);
                var cashConfigDCache = await new CashConfigDCache().GetOrLoadAsync(cashConfigfield);
                if (cashConfigDCache.HasValue)
                {
                    ret.CashLimit = new AmountLimit()
                    {
                        MinAmount = !userHasCash ? cashConfigDCache.Value.FirstCashMinAmount.AToM(ipo.CurrencyId) : cashConfigDCache.Value.CashMinAmount.AToM(ipo.CurrencyId),
                        MaxAmount = cashConfigDCache.Value.CashMaxAmount.AToM(ipo.CurrencyId)
                    };
                }

                //充值最小、最大限制
                var payConfigfield = PayConfigDCache.GetField(ipo.OperatorId, ipo.CurrencyId);
                var payconfigDCache = await new PayConfigDCache().GetOrLoadAsync(payConfigfield);
                if (payconfigDCache.HasValue)
                {
                    var payConfig = payconfigDCache.Value.FirstOrDefault();

                    if (payConfig == null)
                        ret.PayLimit = new AmountLimit();
                    else
                        ret.PayLimit = new AmountLimit()
                        {
                            MinAmount = payConfig.MinAmount.AToM(ipo.CurrencyId),
                            MaxAmount = payConfig.MaxAmount.AToM(ipo.CurrencyId)
                        };
                }
            }
            catch (Exception ex)
            {
                if (ex is not CustomException)
                    LogUtil.GetContextLogger().AddException(ex).AddMessage($"InitLobbyController.GetBalance.ipo:{JsonConvert.SerializeObject(ipo)}");
            }

            return ret;
        }

    }
}
