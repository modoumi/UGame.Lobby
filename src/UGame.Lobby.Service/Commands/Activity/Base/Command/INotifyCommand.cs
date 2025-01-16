using MediatR;

namespace UGame.Lobby.Service.Commands.Activity.Base.Command
{
    public interface INotifyCommand<T> : IRequest<T>
    {
        public string UserId { get; set; }

        public string OperatorId { get; set; }

        public string CountryId { get; set; }

        public string CurrencyId { get; set; }

        /// <summary>
        /// 是否发送弹框通知
        /// </summary>
        public bool IsSendNotify { get; set; }

        /// <summary>
        /// 是否发送站内邮件通知
        /// </summary>
        public bool IsSendNotifyEmail { get; set; }

        /// <summary>
        /// 发送通知后的回调
        /// </summary>
        public Func<string, Task<bool>> AfterNofifyFunc { get; set; }
    }
}
