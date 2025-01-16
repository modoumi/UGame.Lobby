using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Logging;
using TinyFx.Text;
using Xxyy.Common.Caching;
using Xxyy.Common.Services;
using Xxyy.Common;
using Xxyy.DAL;
using Xxyy.MQ.Bank;
using Xxyy.MQ.Xxyy;
using TinyFx.Data;
using Lobby.Flow.DAL;
using Lobby.Flow.Common;
using TinyFx;
using Newtonsoft.Json;
using TinyFx.AspNet;
using Lobby.Flow.Services;
using Elasticsearch.Net;
using Lobby.Flow.IpoDto;
using Lobby.Flow.Services.CashServices;

namespace Lobby.Flow
{
    /// <summary>
    /// 新的打码规则--对应operator.flowmode=3
    /// </summary>
    public class FlowModeThreeService : FlowCommonService,IFlowService
    {
        private readonly RequireFlowService _requireFlowService = new RequireFlowService();
        public FlowModeThreeService(string userId, string appId, string operatorId):base(userId,appId,operatorId)
        {
        }
        public async Task DealCurrencyChangeMsg(CurrencyChangeMsg message)
        {
            await _requireFlowService.AddRequireFlowOrder(message);
        }

        public override async Task DealUserBetMsg(UserBetMsg message)
        {
            if (message.CurrencyType != CurrencyType.Cash || (message.BetType == 1) || (message.BetType == 4 && message.ReferOrderIds.Count < 1))
                return;

            TransactionManager tm = new TransactionManager();
            try
            {
                //rollBack
                if (message.BetType == 4 && (message.WinAmount < 0 || message.BetAmount < 0))
                {
                    await HandleRollBack(message, _requireFlowMo, tm);
                }
                else
                {
                    if (message.BetBonus <= 0) return;
                    var toUpdateOrderList = new List<Xxyy.DAL.S_requireflow_orderEO>();
                    tm = tm == null ? new TransactionManager() : tm;
                    //s_requireflow_order
                    var currBonus = await _userSvc.GetBonus(tm);//当前账户的Bonus总额
                    var _totalFlow = (long)(message.BetBonus * (decimal)_sappEo.FlowRatio);
                    var orderList = await _requireFlowMo.GetSortAsync($"UserID='{message.UserId}' and Status=0", "RecDate asc", tm);
                    if (orderList != null && orderList.Any())
                    {
                        await AccumulateFlow(orderList, _totalFlow, currBonus, toUpdateOrderList);
                    }

                    if (toUpdateOrderList.Count > 0 && await _requireFlowMo.PutAsync(toUpdateOrderList, tm) < 1)
                        throw new Exception("Bet、Win后扣减流水订单中的bonus和真金失败");
                    if(toUpdateOrderList.Any(o => o.Status == 4))
                    {
                        var drawAmount = Math.Min(currBonus, toUpdateOrderList.Where(o=>o.Status==4).Sum(o=>o.OrderAmount));
                        var success =await _userSvc.UpdateBalance(message.CurrencyId,0,tm,-drawAmount);
                        if (!success)
                            throw new Exception($"流水完成更新用户真金账户余额失败");
                    }
                }

                tm.Commit();
            }
            catch (Exception)
            {
                tm.Rollback();
                throw;
            }
        }

        #region 流水相关私有方法【不区分Bonus和真金时，继承流水】

        /// <summary>
        /// 累计流水
        /// </summary>
        /// <param name="orderList"></param>
        /// <param name="flowAmount"></param>
        /// <param name="currBonus"></param>
        /// <param name="toUpdateList"></param>
        /// <returns></returns>
        private async Task<long> AccumulateFlow(List<Xxyy.DAL.S_requireflow_orderEO> orderList, long flowAmount, long currBonus, List<Xxyy.DAL.S_requireflow_orderEO> toUpdateList)
        {
            var _remainFlow = flowAmount;
            foreach (var _order in orderList)
            {
                _order.UpdateTime = DateTime.UtcNow;
                _order.EndBonus = currBonus;
                var _logInfo = $"【增加流水】用户Id：{_order.UserID},流水订单号：{_order.OrderID},所需完成的流水:{_order.RequireFlow},之前已完成的流水:{_order.CompletedFlow}";//本次流水计算日志

                if (_remainFlow > 0)
                {
                    var planCompleteFlow = _order.CompletedFlow + _remainFlow;
                    if (planCompleteFlow <= _order.RequireFlow)
                    {
                        _logInfo += $",本次增加流水:{_remainFlow}";
                        _order.CompletedFlow = planCompleteFlow;
                        if (planCompleteFlow == _order.RequireFlow)
                        {
                            _order.Status = 4;
                            _logInfo += ",流水完成";
                        }
                        toUpdateList.Add(_order);
                        _remainFlow = 0;
                        LogUtil.Debug(_logInfo);
                        break;
                    }
                    else
                    {
                        _logInfo += $",本次增加流水:{_order.RequireFlow - _order.CompletedFlow},流水完成";
                        _order.CompletedFlow = _order.RequireFlow;
                        _order.Status = 4;
                        _remainFlow = planCompleteFlow - _order.RequireFlow;//仍然有溢出流水
                        toUpdateList.Add(_order);
                    }
                }
                LogUtil.Debug(_logInfo);
            }
            return _remainFlow;
        }

        #endregion

        public async Task DealUserPayMsg(UserPayMsg message)
        {
            try
            {
                var cashFlowMultip = message.IsFirst
                    ? _operatorInfo.FirstPayFlowMultip
                    : _operatorInfo.PayFlowMultip;//充值的流水倍数
                if (cashFlowMultip <= 0) return;

                var balanceInfo = await _userSvc.GetBalanceInfo();
                var requireFlowEo = new Xxyy.DAL.S_requireflow_orderEO
                {
                    OrderID = ObjectId.NewId(),
                    ProviderID = null,
                    AppID = null,
                    OperatorID = message.OperatorId,
                    UserID = message.UserId,
                    UserKind = (int)await _userDCache.GetUserKindAsync(),
                    CountryID = await _userDCache.GetCountryIdAsync(),
                    CurrencyID = message.CurrencyId,
                    CurrencyType = (int)DbCacheUtil.GetCurrencyType(message.CurrencyId),
                    IsBonus = false,
                    FlowMultip = cashFlowMultip,
                    OrderAmount = message.PayAmount,
                    OrderRemain = message.PayAmount,
                    RequireFlow = message.PayAmount * cashFlowMultip,
                    EndBonus = balanceInfo.Bonus,
                    EndBalance = balanceInfo.Balance,
                    Status = 0,
                    RecDate = message.PayTime,
                    UpdateTime = message.PayTime,
                    SourceId = message.OrderID,
                    SourceTable = "sb_bank_order",
                    BonusSourceType = 400001,
                    BonusReason = "用户充值",
                    FromId = await _userDCache.GetFromIdAsync(),
                    FromMode = await _userDCache.GetFromModeAsync()
                };
                if (await _requireFlowMo.AddAsync(requireFlowEo) < 1)
                    throw new Exception("FlowNoInheritingNoCompletedService充值消费端，新增流水订单时出错");
            }
            catch (Exception ex)
            {
                LogUtil.Error(ex, "FlowNoInheritingNoCompletedService充值消费端，计算流水订单时出错");
            }
        }

        protected override async Task<CurrencyChangeMsg> ChangeAmount(BraWithDrawIpo ipo, TransactionManager tm = null)
        {
            (long changeAmount, long changeBonus) = await GetChangeAmount(ipo,tm);
            //写入S_currency_change用户奖励变化表
            var changeMsg = await ipo.CurrencyChangeServices.Change(new CurrencyChangeReq()
            {
                UserId = ipo.UserId,
                AppId = ipo.AppId,
                OperatorId = ipo.OperatorId,
                CurrencyId = ipo.CurrencyId,
                Reason = "提现审核预扣除",
                Amount = -changeAmount,
                SourceType = 2,
                SourceTable = "sc_cash_audit",
                SourceId = ipo.CashAuditId,
                ChangeTime = DateTime.UtcNow,
                TM = tm,
                ChangeBalance = CurrencyChangeBalance.FirstCash,
                BonusAmount=-changeBonus
            });
            return changeMsg;
        }

        private async Task<(long changeAmount, long changeBonus)> GetChangeAmount(BraWithDrawIpo ipo, TransactionManager tm = null)
        {
            var balanceInfo = await _userSvc.GetBalanceInfo(tm);
            long changeAmount = 0L,changeBonus = 0L;
            var drawAmount = ipo.Amount.MToA(ipo.CurrencyId);
            if (drawAmount > (balanceInfo.Balance - balanceInfo.Bonus))
                changeAmount = balanceInfo.Balance;
            else
                changeAmount = drawAmount + balanceInfo.Bonus;
            changeBonus = balanceInfo.Bonus;
            return (changeAmount,changeBonus);
        }

        protected override Task<BraPayChannelEnum> GetPayChannel(BraWithDrawIpo ipo) => Task.FromResult(ipo.Channels.ToEnum<BraPayChannelEnum>());

        #region 内部方法
        /// <summary>
        /// 回滚消息处理
        /// </summary>
        /// <returns></returns>
        private async Task HandleRollBack(UserBetMsg message, Xxyy.DAL.S_requireflow_orderMO requireFlowMo, TransactionManager tm)
        {
            if (message.BetType != 4) return;
            if (message.BetBonus < 0)
            {
                var rollbackBonus = (long)(message.BetBonus * _sappEo.FlowRatio);
                if (rollbackBonus == 0) return;
                var requireFlowOrders = await requireFlowMo.GetTopSortAsync($"UserID='{message.UserId}' and Status=0", 1, "UpdateTime desc", tm);
                if (requireFlowOrders == null || requireFlowOrders.Count < 1) return;
                if (await requireFlowMo.PutAsync("CompletedFlow+=@rollbackBonus", "OrderID=@OrderID", tm, rollbackBonus, requireFlowOrders[0].OrderID) < 1)
                    throw new Exception("RollBack后更新最近一条未完成的bonus流水订单失败");
            }
        }
        #endregion


        public override async Task DealUserCashMsg(UserCashMsg message)
        {
            var actionData = new CashAuditActionData
            {
                Action = (int)CashAuditStatusEnum.Success,
                Ipo = message,
                Dto = true,
                OperatorId = message.UserId,
                RequestTime = DateTime.UtcNow,
                TransType = 1
            };
            var tm = new TransactionManager();
            try
            {
                int rows = 0;
                if (message.Status==0)
                {
                        //1.
                        rows = await _cashAuditMo.PutAsync("Status=@status", "CashAuditID=@CashAuditID and Status<=@oldstatus", tm, (int)CashAuditStatusEnum.Success, message.AppOrderId, (int)CashAuditStatusEnum.Confirmation);
                        if (rows <= 0)
                            throw new Exception($"提现成功更新sc_cash_audit状态失败！CashAuditID:{message.AppOrderId},oldstatus:{(int)CashAuditStatusEnum.Confirmation},status:{(int)CashAuditStatusEnum.Success}");
                        //2.
                        rows = await _requireFlowMo.PutAsync("Status=4", $"UserID=@UserID and Status !=4", tm);
                        if (rows <= 0)
                            throw new Exception($"提现成功更新requireFlowOrder表失败！CashAuditID:{message.AppOrderId}");
                        //3.log
                        await FlowUtil.AddCashAuditLog(message.AppOrderId, null, true, actionData, null);
                }
                else
                {            
                    var cashAuditEo = await _cashAuditMo.GetByPKAsync(message.AppOrderId, tm);
                    if (null == cashAuditEo||cashAuditEo.Status>(int)CashAuditStatusEnum.Confirmation)
                        throw new Exception($"提现失败时没有找到该提现订单或该订单不是等待银行确认状态！CashAuditId:{message.AppOrderId},status:{cashAuditEo?.Status}");

                    //var userSvc = new UserService(message.UserId);
                    var ret = await _userSvc.UpdateBalance(message.CurrencyId, Math.Abs(cashAuditEo.AmountBalance), tm, Math.Abs(cashAuditEo.AmountBonus));
                    if (!ret)
                        throw new Exception($"提现失败时,更新s_user账户失败！CashAuditId:{message.AppOrderId}");
                    rows = await _cashAuditMo.PutAsync("Status=@status", "CashAuditID=@CashAuditID and Status=@oldstatus", tm,(int)CashAuditStatusEnum.Fail,cashAuditEo.CashAuditID,cashAuditEo.Status);
                    if (rows <= 0)
                        throw new Exception($"提现失败时，更新sc_cashaudit失败！CashAuditId:{message.AppOrderId}");

                    actionData.Action = (int)CashAuditStatusEnum.Fail;
                    await FlowUtil.AddCashAuditLog(message.AppOrderId, null, false, actionData, null);
                }
                tm.Commit();
            }
            catch (Exception ex)
            {
                tm.Rollback();
                LogUtil.Error(ex, "FlowNoInheritingNoCompletedService处理用户提现消息异常！");
                throw;
            }
        }

        /// <summary>
        /// 获取可提现额
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="currencyId"></param>
        /// <param name="tm"></param>
        /// <returns></returns>
        public override async Task<long> GetAllowCashAmount(string userId, string currencyId, TransactionManager tm = null)
        {
            //var requireFlowOrders = await _requireFlowMo.GetAsync($"UserID=@userid and Status=1", tm, userId);
            var balanceInfo = await _userSvc.GetBalanceInfo(tm, false);
            return balanceInfo.ValidAmount;
            //return balanceInfo.ValidAmount + Math.Min(balanceInfo.Bonus, requireFlowOrders?.Sum(o => o.OrderAmount) ?? 0);
        }
    }
}
