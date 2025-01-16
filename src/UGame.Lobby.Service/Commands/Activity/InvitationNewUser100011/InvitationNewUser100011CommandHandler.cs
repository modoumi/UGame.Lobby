using UGame.Lobby.Service.Commands.Activity.Base.Command;
using UGame.Lobby.Service.Commands.Activity.UserPay10008;
using UGame.Lobby.Common.Enum;
using UGame.Lobby.Repository.ing;
using MediatR;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo;
using AiUo.Data;
using AiUo.Logging;
using AiUo.Text;
using UGame.Lobby.Service.Caching.Activity.InviteNewUser;
using UGame.Lobby.Service.Commands.Activity.Base;
using Xxyy.Common;
using Xxyy.MQ.Bank;
using Xxyy.Partners.Model;

namespace UGame.Lobby.Service.Commands.Activity.InvitationNewUser100011
{
    public class InvitationNewUser100011CommandHandler : IRequestHandler<InvitationNewUser100011Command, bool>
    {
        ILogger<InvitationNewUser100011CommandHandler> _logger;

        private Sa_invite100011_detailMO _inviteDetailMo = new();

        public InvitationNewUser100011CommandHandler()
        {
            _logger = LogUtil.CreateLogger<InvitationNewUser100011CommandHandler>();
        }


        public async Task<bool> Handle(InvitationNewUser100011Command request, CancellationToken cancellationToken)
        {
            if (request.ActivityIds != null && request.ActivityIds.Any() && !request.ActivityIds.Any(d => d.Equals(Convert.ToString((int)ActivityType.InvitationNewUser100011))))
                return true;

            _logger.LogInformation($@"InvitationNewUser100011CommandHandler.request:{JsonConvert.SerializeObject(request)}");

            //如果消息为空，并且非首次充值
            if (request == null || !request.IsFirst)
                return false;

            TransactionManager tm = new TransactionManager();
            try
            {
                //1、查询当前用户是否通过推广员注册
                var sUserEo = await DbSink.BuildUserMo(request.UserId).GetByPKAsync(request.UserId, tm);
                if (sUserEo == null || string.IsNullOrWhiteSpace(sUserEo.PUserID1))
                    throw new CustomException("用户不存在or当前用户属于自然注册用户.");

                //2、获取PUser
                var pUserEo = await DbSink.BuildUserMo(sUserEo.PUserID1).GetByPKAsync(sUserEo.PUserID1, tm);

                //3、判断是否收到同一笔充值消息
                var sql = $@"select * from sa_invite100011_detail where PUserID = @UserID and OrderId = @OrderId limit 1;";
                var detail = await DbSink.MainDb.ExecSqlSingleAsync<Sa_invite100011_detailEO>(sql, tm, pUserEo.UserID, request.OrderID);
                if (detail != null)
                    throw new Exception("重复充值消息.");

                //4、查询配置是否存在
                var cacheData = await new InvitePayConfigDCache(request.OperatorId, request.CurrencyId).GetAsync();
                if (!cacheData.HasValue || cacheData.Value == null || !cacheData.Value.Any())
                    throw new Exception("sa_invitepay100011_config缺少配置.");

                //5、奖励明细
                detail = new Sa_invite100011_detailEO()
                {
                    DetailID = ObjectId.NewId(),
                    OperatorID = request.OperatorId,
                    CountryId = request.CountryId,
                    CurrencyID = request.CurrencyId,
                    RewardType = 1,
                    PUserID = pUserEo.UserID,
                    PUserKind = pUserEo.UserKind,
                    Bonus = 0,
                    FlowMultip = cacheData.Value.FirstOrDefault().FlowMultip,
                    UserID = sUserEo.UserID,
                    UserKind = sUserEo.UserKind,
                    RegistDate = sUserEo.RegistDate.Value,
                    FirstPayAmount = request.PayAmount,
                    RecDate = DateTime.UtcNow,
                    OrderID = request.OrderID,
                    ReceiveStatus = true
                };

                //6、判断当前充值金额是否满足赠送bonus条件
                var bonusData = cacheData.Value.Where(d => request.PayAmount > d.PayAmountStart && request.PayAmount <= d.PayAmountEnd).OrderBy(d => d.PayAmountStart).FirstOrDefault();
                if (bonusData != null)
                {
                    detail.Bonus = bonusData.Bonus;
                    detail.ReceiveStatus = false;
                }

                await _inviteDetailMo.AddAsync(detail, tm);

                tm.Commit();

                if (detail.Bonus > 0)
                {
                    var _mediator = DIUtil.GetService<IMediator>();
                    var command = new InviteNewUser100011NotifyCommand()
                    {
                        UserId = pUserEo.UserID,
                        OperatorId = request.OperatorId,
                        CountryId = request.CountryId,
                        CurrencyId = request.CurrencyId,
                        Bonus = bonusData.Bonus,
                        FlowMultip = bonusData.FlowMultip,
                        IsSendNotify = request.IsSendNotify,
                        IsSendNotifyEmail = request.IsSendNotifyEmail,
                        RewardSourceId = detail.DetailID,
                        RewardAmount = bonusData.Bonus,
                        Parameters = new { RewardAmount = bonusData.Bonus.AToM(request.CurrencyId) }
                    };
                    await _mediator.Send(command);
                }

                return true;
            }
            catch (Exception ex)
            {
                tm.Rollback();

                if (ex is not CustomException)
                    _logger.LogError($@"InvitationNewUser100011CommandHandler.request:{JsonConvert.SerializeObject(request)}.error:{ex.Message}");

                return false;
            }
        }
    }
}
