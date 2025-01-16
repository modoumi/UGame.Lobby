using UGame.Lobby.Common.Enum;
using MediatR;
using AiUo.Extensions.AutoMapper;
using Xxyy.MQ.Xxyy;

namespace UGame.Lobby.Service.Commands.Activity.Rebate
{
    public class RebateDotCommand : IRequest<bool>, IMapTo<UserBetMsg>
    {
        public string OrderId { get; set; }
        public int ActivityID { get; set; }
        /// <summary>
        /// 用户编码
        /// </summary>
        public string UserId { get; set; }
        /// <summary>
        /// 运营商编码
        /// </summary>
        public string OperatorID { get; set; }
        /// <summary>
        /// 货币编码
        /// </summary>
        public string CurrencyId { get; set; }
        /// <summary>
        /// 国家编码
        /// </summary>
        public string CountryId { get; set; }
        /// <summary>
        /// 应用编码
        /// </summary>
        public string AppId { get; set; }
        /// <summary>
        /// 赠送bonus金额
        /// </summary>
        public long Amount { get; set; }

        /// <summary>
        /// 1bouns 2真金
        /// </summary>
        public int RewardType { get; set; }
        /// <summary>
        /// 提现时候需要完成的下注流水倍数
        /// </summary>
        public float FlowMultip { get; set; }
        /// <summary>
        /// 是否发送弹框通知
        /// </summary>
        public bool IsSendNotify { get; set; }
        /// <summary>
        /// 是否发送站内邮箱通知
        /// </summary>
        public bool IsSendNotifyEmail { get; set; }
        /// <summary>
        /// 0-真金1-bonus,如果s_operator.EnableBonus=false,则忽视当前值,统一为真金
        /// </summary>
        public bool IsBonus { get; set; }

        public string DetailId { get; set; }

        public DateTime BetTime { get; set; }
        public long BetAmount { get; set; }

        public long BetBonus { get; set; }

        public long WinAmount { get; set; }

        public long WinBonus { get; set; }

        public void MapTo(UserBetMsg destination)
        {

        }
    }
}
