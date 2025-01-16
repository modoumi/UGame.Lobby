using UGame.Lobby.Common.Enum;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xxyy.MQ.Bank;
using Xxyy.MQ.Xxyy;

namespace UGame.Lobby.Service.Commands.Activity.Roulette101001
{
    public class Roulette101001Command : IRequest<bool>
    {
        public UserPayMsg userPayMsg { get; set; } = null;

        public ActivityEvent? EventType { get; set; }

        /// <summary>
        /// 是否发送弹框通知
        /// </summary>
        public bool IsSendNotify { get; set; }
        /// <summary>
        /// 是否发送站内邮箱通知
        /// </summary>
        public bool IsSendNotifyEmail { get; set; }
    }
}
