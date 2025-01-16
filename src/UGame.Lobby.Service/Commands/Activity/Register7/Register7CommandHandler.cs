using EasyNetQ;
using UGame.Lobby.Common.Enum;
using UGame.Lobby.Repository.ing;
using MediatR;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using AiUo;
using AiUo.Data;
using AiUo.Data.SqlSugar;
using AiUo.Extensions.RabbitMQ;
using AiUo.Logging;
using AiUo.Text;
using UGame.Lobby.Service.Caching.Activity;
using UGame.Lobby.Service.Caching.Activity.Register7;
using UGame.Lobby.Service.Commands.Activity.Base;
using UGame.Lobby.Service.Common;
using Xxyy.Common;
using Xxyy.Common.Services;
using Xxyy.MQ.Lobby.Activity;

namespace UGame.Lobby.Service.Commands.Activity.Register7
{
    public class Register7CommandHandler : IRequestHandler<Register7Command, bool>
    {
        ILogger<Register7CommandHandler> _logger;

        /// <summary>
        /// 构造方法
        /// </summary>
        public Register7CommandHandler()
        {
            _logger = LogUtil.CreateLogger<Register7CommandHandler>();
        }


        public async Task<bool> Handle(Register7Command request, CancellationToken cancellationToken)
        {
            var tm = new DbTransactionManager();
            var currencyChangeService = new CurrencyChange2Service(request.UserId);
            try
            {
                await tm.BeginAsync();

                //获取配置
                var field = Register7ConfigDCache.GetField(request.OperatorId, request.CurrencyId);
                var register7Config = await new Register7ConfigDCache().GetOrLoadAsync(field, true);
                if (!register7Config.HasValue)
                {
                    LogUtil.Info($"Lobby_BLL_Commands_Activity_Register7_Register7CommandHandler_1,request:{JsonConvert.SerializeObject(request)},sa_register100007_config配置不存在");
                    throw new Exception("sa_register100007_config配置不存在.");
                }

                if (!register7Config.Value.IsSendBonus || register7Config.Value.IPSendNum == 0)
                {
                    LogUtil.Info($"Lobby_BLL_Commands_Activity_Register7_Register7CommandHandler_2,request:{JsonConvert.SerializeObject(request)},sa_register100007_config配置当前运营商注册不需要赠送bonus,register7Config:{JsonConvert.SerializeObject(register7Config.Value)}");
                    throw new CustomException($"sa_register100007_config配置当前运营商注册不需要赠送bonus.");
                }

                if (string.IsNullOrWhiteSpace(request.UserIp))
                {
                    LogUtil.Info($"Lobby_BLL_Commands_Activity_Register7_Register7CommandHandler_3,request:{JsonConvert.SerializeObject(request)},userIp为空");
                    throw new Exception($"userIp为空.");
                }

                //当前ip送出的注册奖励次数
                //var ipSendNum = await DbUtil.GetRepository<Sa_ip_recordPO>()
                //    .AsQueryable()
                //    .Where(d => d.IpAddress.Equals(request.UserIp)
                //            && d.OperatorID.Equals(request.OperatorId)
                //            && d.CurrencyID.Equals(request.CurrencyId)
                //            && d.ActivityID == (int)ActivityType.Register7).CountAsync();
                var userIpDcache = new UserIpActivityDCache(request.OperatorId, (int)ActivityType.Register7);
                var ipSendNum =await userIpDcache.GetNum(request.UserIp);

                if (ipSendNum >= register7Config.Value.IPSendNum)
                {
                    LogUtil.Info($"Lobby_BLL_Commands_Activity_Register7_Register7CommandHandler_4,request:{JsonConvert.SerializeObject(request)},当前ip送出注册奖励已达到次数限制.{JsonConvert.SerializeObject(register7Config.Value)}");
                    throw new CustomException($"当前ip送出注册奖励已达到次数限制.{JsonConvert.SerializeObject(register7Config.Value)}");
                }

                //2、查sa_register100007_user
                var IsExistsUser = await DbUtil.GetRepository<Sa_register100007_userPO>()
                                        .AsQueryable()
                                        .Where(d => d.UserID.Equals(request.UserId))
                                        .CountAsync() > 0;

                if (IsExistsUser)
                {
                    LogUtil.Info($"Lobby_BLL_Commands_Activity_Register7_Register7CommandHandler_5,request:{JsonConvert.SerializeObject(request)},不可重复获取注册送bonus奖励");
                    throw new CustomException($"不可重复获取注册送bonus奖励.");
                }

                //3、写入sa_register100007_user
                await tm.GetRepository<Sa_register100007_userPO>().InsertAsync(new Sa_register100007_userPO()
                {
                    UserID = request.UserId,
                    OperatorID = request.OperatorId,
                    CountryId = request.CountryId,
                    CurrencyID = request.CurrencyId,
                    Bonus = register7Config.Value.SendBonus,
                    RecDate = DateTime.UtcNow
                });

                //4、写sa_ip_record
                await userIpDcache.AddNum(request.UserIp);
                //await tm.GetRepository<Sa_ip_recordPO>().InsertAsync(new Sa_ip_recordPO()
                //{
                //    ID = ObjectId.NewId(),
                //    ActivityID = (int)ActivityType.Register7,
                //    UserID = request.UserId,
                //    OperatorID = request.OperatorId,
                //    CountryId = request.CountryId,
                //    CurrencyID = request.CurrencyId,
                //    IpAddress = request.UserIp,
                //    Bonus = register7Config.Value.SendBonus,
                //    FlowMultip = register7Config.Value.FlowMultip,
                //    RecDate = DateTime.UtcNow
                //});

                //查询当前活动配置
                var activityOperator = await LobbyUtil.GetSingleActivityAsync(request.OperatorId, request.CurrencyId, ActivityType.Register7);
                if (activityOperator == null)
                {
                    LogUtil.Info($"Lobby_BLL_Commands_Activity_Register7_Register7CommandHandler_6,request:{JsonConvert.SerializeObject(request)},l_activity_operator表活动{(int)ActivityType.Register7}不存在.");
                    throw new Exception($@"l_activity_operator表活动{(int)ActivityType.Register7}不存在.");
                }

                var currencyChangeReq = new CurrencyChangeReq()
                {
                    UserId = request.UserId,
                    AppId = request.AppId,
                    OperatorId = request.OperatorId,
                    CurrencyId = request.CurrencyId,
                    Reason = "Register7注册送bonus",
                    Amount = register7Config.Value.SendBonus,
                    SourceType = (int)ActivityType.Register7,
                    SourceTable = "sa_register100007_user",
                    SourceId = request.UserId,
                    ChangeTime = DateTime.UtcNow,
                    ChangeBalance = activityOperator.IsBonus ? CurrencyChangeBalance.Bonus : CurrencyChangeBalance.Cash,
                    FlowMultip = register7Config.Value.FlowMultip,
                    DbTM = tm
                };

                //5、写s_currency_change
                var changeMsg = await currencyChangeService.Add(currencyChangeReq);

                await tm.CommitAsync();

                if (changeMsg != null)
                    await MQUtil.PublishAsync(changeMsg);

                await MQUtil.PublishAsync(new UserActivityMsg()
                {
                    UserId = request.UserId,
                    ActivityType = (int)ActivityType.Register7,
                    IsEnd = true
                });

                #region 发通知（弹框、邮件）

                if (register7Config.Value.IsSendBonus)
                {
                    #region 弹框通知

                    //写入Notify
                    var _mediator = DIUtil.GetService<IMediator>();
                    var notifyCommand = new Register7NotifyCommand();
                    notifyCommand.UserId = request.UserId;
                    notifyCommand.OperatorId = request.OperatorId;
                    notifyCommand.CountryId = request.CountryId;
                    notifyCommand.CurrencyId = request.CurrencyId;
                    notifyCommand.Bonus = register7Config.Value.SendBonus;
                    notifyCommand.FlowMultip = register7Config.Value.FlowMultip;
                    notifyCommand.AppId = request.AppId;
                    notifyCommand.ShowName = request.Mobile;
                    notifyCommand.IsSendNotify = request.IsSendNotify;
                    notifyCommand.IsSendNotifyEmail = request.IsSendNotifyEmail;
                    notifyCommand.RewardSourceId = request.UserId;
                    notifyCommand.RewardAmount = register7Config.Value.SendBonus;
                    notifyCommand.Parameters = new { RewardAmount = register7Config.Value.SendBonus.AToM(request.CurrencyId) };
                    await _mediator.Send(notifyCommand);

                    #endregion
                }

                #endregion

                return true;
            }
            catch (Exception ex)
            {
                LogUtil.Info($"Lobby_BLL_Commands_Activity_Register7_Register7CommandHandler,request:{JsonConvert.SerializeObject(request)},发送注册奖励失败:{JsonConvert.SerializeObject(ex)}");
                await tm.RollbackAsync();
                //if (ex is not CustomException)
                //{
                //    LogUtil.GetContextLogger().AddException(ex).AddMessage($"Register7CommandHandler.Error:{ex.Message}.request:{JsonConvert.SerializeObject(request)}");
                //}
                return false;
            }
        }


        //public async Task<bool> Handle1(Register7Command request, CancellationToken cancellationToken)
        //{
        //    TransactionManager tm = new TransactionManager();

        //    var ipRecordMo = new Sa_ip_recordMO();
        //    var register7UserMo = new Sa_register100007_userMO();
        //    var currencyChangeService = new CurrencyChangeService(request.UserId);
        //    try
        //    {
        //        //获取配置
        //        var field = Register7ConfigDCache.GetField(request.OperatorId, request.CurrencyId);
        //        var register7Config = await new Register7ConfigDCache().GetOrLoadAsync(field);
        //        if (!register7Config.HasValue)
        //            throw new Exception("sa_register100007_config配置不存在.");

        //        if (!register7Config.Value.IsSendBonus)
        //            throw new CustomException($"sa_register100007_config配置当前运营商注册不需要赠送bonus.");

        //        if (string.IsNullOrWhiteSpace(request.UserIp))
        //            throw new Exception($"userIp为空.");

        //        //1、查sa_ip_record
        //        var saIpRecordEo = await ipRecordMo.GetSingleAsync("IpAddress = @IpAddress and OperatorId = @OperatorId and CurrencyId = @CurrencyId and ActivityID = @ActivityID", tm, request.UserIp, request.OperatorId, request.CurrencyId, (int)UGame.Lobby.Common.Enum.ActivityType.Register7);

        //        if (saIpRecordEo != null)
        //            throw new CustomException($"当前ip已存在参加活动记录.");

        //        //2、查sa_register100007_user
        //        var register7 = await register7UserMo.GetByPKAsync(request.UserId, tm, isForUpdate_: true);
        //        if (register7 != null)
        //            throw new CustomException($"当前用户已存在.");

        //        //3、写sa_register100007_user
        //        await register7UserMo.AddAsync(new Sa_register100007_userEO()
        //        {
        //            UserID = request.UserId,
        //            OperatorID = request.OperatorId,
        //            CountryId = request.CountryId,
        //            CurrencyID = request.CurrencyId,
        //            Bonus = register7Config.Value.SendBonus,
        //            RecDate = DateTime.UtcNow
        //        }, tm, true);
        //        //4、写sa_ip_record
        //        await ipRecordMo.AddAsync(new Sa_ip_recordEO()
        //        {
        //            ID = ObjectId.NewId(),
        //            ActivityID = (int)UGame.Lobby.Common.Enum.ActivityType.Register7,
        //            UserID = request.UserId,
        //            OperatorID = request.OperatorId,
        //            CountryId = request.CountryId,
        //            CurrencyID = request.CurrencyId,
        //            IpAddress = request.UserIp,
        //            Bonus = register7Config.Value.SendBonus,
        //            FlowMultip = register7Config.Value.FlowMultip,
        //            RecDate = DateTime.UtcNow
        //        }, tm, true);

        //        //查询当前活动配置
        //        var activityOperator = await LobbyUtil.GetSingleActivityAsync(request.OperatorId, request.CurrencyId, ActivityType.Register7);
        //        if (activityOperator == null)
        //            throw new Exception($@"l_activity_operator表活动{(int)ActivityType.Register7}不存在.");

        //        var currencyChangeReq = new CurrencyChangeReq()
        //        {
        //            UserId = request.UserId,
        //            AppId = request.AppId,
        //            OperatorId = request.OperatorId,
        //            CurrencyId = request.CurrencyId,
        //            Reason = "Register7注册送bonus",
        //            Amount = register7Config.Value.SendBonus,
        //            SourceType = (int)UGame.Lobby.Common.Enum.ActivityType.Register7,
        //            SourceTable = "sa_register100007_user",
        //            SourceId = request.UserId,
        //            ChangeTime = DateTime.UtcNow,
        //            //IsBonus = activityOperator.IsBonus,
        //            ChangeBalance = activityOperator.IsBonus ? CurrencyChangeBalance.Bonus : CurrencyChangeBalance.Cash,
        //            FlowMultip = register7Config.Value.FlowMultip,
        //            TM = tm
        //        };

        //        //5、写s_currency_change
        //        var changeMsg = await currencyChangeService.Add(currencyChangeReq);

        //        //更新用户活动状态
        //        await LobbyUtil.UpdateUserActivity(request.UserId, request.OperatorId, request.CurrencyId, ActivityType.Register7, tm);

        //        tm.Commit();
        //        if (changeMsg != null)
        //            await MQUtil.PublishAsync(changeMsg);

        //        await MQUtil.PublishAsync(new UserActivityMsg()
        //        {
        //            UserId = request.UserId,
        //            ActivityType = (int)ActivityType.Register7,
        //            IsEnd = true
        //        });

        //        #region 发通知（弹框、邮件）

        //        if (register7Config.Value.IsSendBonus)
        //        {
        //            #region 弹框通知

        //            //写入Notify
        //            var _mediator = DIUtil.GetService<IMediator>();
        //            var notifyCommand = new Register7NotifyCommand();
        //            notifyCommand.UserId = request.UserId;
        //            notifyCommand.OperatorId = request.OperatorId;
        //            notifyCommand.CountryId = request.CountryId;
        //            notifyCommand.CurrencyId = request.CurrencyId;
        //            notifyCommand.Bonus = register7Config.Value.SendBonus;
        //            notifyCommand.FlowMultip = register7Config.Value.FlowMultip;
        //            notifyCommand.AppId = request.AppId;
        //            notifyCommand.ShowName = request.Mobile;
        //            notifyCommand.IsSendNotify = request.IsSendNotify;
        //            notifyCommand.IsSendNotifyEmail = request.IsSendNotifyEmail;
        //            notifyCommand.RewardSourceId = request.UserId;
        //            notifyCommand.RewardAmount = register7Config.Value.SendBonus;
        //            notifyCommand.Parameters = new { RewardAmount = register7Config.Value.SendBonus.AToM(request.CurrencyId) };
        //            await _mediator.Send(notifyCommand);

        //            #endregion
        //        }

        //        #endregion

        //    }
        //    catch (Exception ex)
        //    {
        //        tm.Rollback();
        //        if (ex is not CustomException)
        //        {
        //            LogUtil.GetContextLogger().AddException(ex).AddMessage($"Register7CommandHandler.Error:{ex.Message}.request:{JsonConvert.SerializeObject(request)}");
        //        }
        //        return false;
        //    }

        //    return true;
        //}
    }
}
