using UGame.Lobby.Common.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Extensions.AutoMapper;
using Xxyy.MQ.Xxyy;

namespace UGame.Lobby.Service.Commands.Activity.Base.Command
{
    public abstract class NotifyCommandBase : INotifyCommand<bool>, IMapTo<NotifyRewardMsg>
    {
        public string UserId { get; set; }

        public string OperatorId { get; set; }

        public string CountryId { get; set; }

        public string CurrencyId { get; set; }

        public string AppId { get; set; } = "lobby";

        /// <summary>
        /// 是否发送弹框通知
        /// </summary>
        public bool IsSendNotify { get; set; }

        /// <summary>
        /// 是否发送站内邮件通知
        /// </summary>
        public bool IsSendNotifyEmail { get; set; }

        /// <summary>
        /// 活动类型
        /// </summary>
        public ActivityType ActivityType { get; set; }

        /// <summary>
        /// 提现时候需要完成的下注流水倍数
        /// </summary>
        public float FlowMultip { get; set; }

        #region 弹框通知

        /// <summary>
        /// 赠送bonus金额
        /// </summary>
        public long Bonus { get; set; }
        /// <summary>
        /// 显示名称
        /// </summary>
        public string ShowName { get; set; }

        #endregion

        #region 站内邮件通知

        /// <summary>
        /// 奖励金额
        /// </summary>
        public long RewardAmount { get; set; }

        /// <summary>
        /// 奖励原始表
        /// </summary>
        public string RewardSourceTable { get; set; }

        /// <summary>
        /// 奖励原始ID
        /// </summary>
        public string RewardSourceId { get; set; }

        /// <summary>
        /// 奖励标识ID
        /// </summary>
        public int RewardFlagId { get; set; }

        /// <summary>
        /// 邮件发送标识
        /// </summary>
        public string SenderId { get; set; }

        /// <summary>
        /// 是否在邮箱领取奖励
        /// </summary>
        public bool IsReward { get; set; } = false;
        /// <summary>
        /// 模板数据参数
        /// </summary>
        public object Parameters { get; set; }

        #endregion

        /// <summary>
        /// 发通知后的回调
        /// </summary>
        public Func<string, Task<bool>> AfterNofifyFunc { get; set; }

        public void MapTo(NotifyRewardMsg destination)
        {

        }
    }
}
