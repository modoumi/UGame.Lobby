using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xxyy.MQ.Xxyy;

namespace UGame.Lobby.Service.Commands.Activity.Register7
{
    public class Register7Command : IRequest<bool>
    {
        public RegLoginType RegLoginType { get; set; }

        public string AppId { get; set; }

        public string OperatorId { get; set; }

        public string CountryId { get; set; }

        public string CurrencyId { get; set; }

        public int RegisterMode { get; set; }

        public string UserId { get; set; }

        public int UserKind { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public string Mobile { get; set; }

        public string Nickname { get; set; }

        public int FromMode { get; set; }

        public string FromId { get; set; }

        public string IMEI { get; set; }

        public string GAID { get; set; }

        public DateTime RegisterDate { get; set; }

        public string UserIp { get; set; }

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
