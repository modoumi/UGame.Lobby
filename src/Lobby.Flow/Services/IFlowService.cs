using Lobby.Flow.IpoDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Data;
using Xxyy.Common.Services;
using Xxyy.MQ.Bank;
using Xxyy.MQ.Xxyy;

namespace Lobby.Flow
{
    public interface IFlowService
    {
        /// <summary>
        /// 用户充值时流水处理
        /// </summary>
        /// <returns></returns>
        Task DealUserPayMsg(UserPayMsg message);

        /// <summary>
        /// 用户下注时流水处理
        /// </summary>
        /// <returns></returns>
        Task DealUserBetMsg(UserBetMsg message);

        /// <summary>
        /// 用户货币变化时流水处理
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        Task DealCurrencyChangeMsg(CurrencyChangeMsg message);

        /// <summary>
        /// 发起提现
        /// </summary>
        /// <returns></returns>
        Task<FlowCashDto> RequestCash(FlowCashIpo flowIpo);

        /// <summary>
        /// 提现消息处理
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        Task DealUserCashMsg(UserCashMsg message);

        /// <summary>
        /// 获取可提现额
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="operatorId"></param>
        /// <returns></returns>
        Task<long> GetAllowCashAmount(string userId,string currencyId,TransactionManager tm=null);
    }
}
