using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UGame.Lobby.Service.Commands.Activity
{
    /// <summary>
    /// 
    /// </summary>
    public class ActivityBaseCommand : IRequest<bool>
    {
        /// <summary>
        /// 事件类型
        /// </summary>
        public int EventId { get; set; }
        /// <summary>
        /// 运营商编码
        /// </summary>
        public string OperatorId { get; set; }
        /// <summary>
        /// 货币编码
        /// </summary>
        public string CurrencyId { get; set; }
        /// <summary>
        /// 事件参数
        /// </summary>
        public object Data { get; set; }
    }
}
