using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using AiUo;
using AiUo.AspNet;
using AiUo.Extensions.AutoMapper;
using Xxyy.Common;
using Xxyy.DAL;

namespace UGame.Lobby.Service.Services.Profile
{
    public class DiscountRecordIpo : LobbyBaseIpo
    {
        /// <summary>
        /// 起始时间
        /// </summary>
        public DateTime? StartDate { get; set; }
        /// <summary>
        /// 截止时间
        /// </summary>
        public DateTime? EndDate { get; set; }
        /// <summary>
        /// 当前页码
        /// </summary>
        [RangeEx(1, int.MaxValue, "", "PageIndex must be a positive integer greater than 0.")]
        public int PageIndex { get; set; } = 1;
        /// <summary>
        /// 页大小
        /// </summary>
        [RangeEx(1, 10, "", "PageSize must be a correct integer between 1 and 10.")]
        public int PageSize { get; set; } = 5;
    }

    public class DiscountRecordDto : IMapFrom<S_requireflow_orderEO>
    {
        /// <summary>
        /// 活动奖励订单编号
        /// </summary>
        public string OrderId { get; set; }
        /// <summary>
        /// 应用编码
        /// </summary>
        public string OperatorId { get; set; }
        /// <summary>
        /// 国家编码
        /// </summary>
        public string CountryId { get; set; }
        /// <summary>
        /// 货币编码
        /// </summary>
        public string CurrencyId { get; set; }
        /// <summary>
        /// 是否为赠金
        /// </summary>
        [JsonIgnore]
        public bool IsBonus { get; set; }
        /// <summary>
        /// 已完成流水
        /// </summary>
        public decimal CompletedFlowMoney { get; set; }
        /// <summary>
        /// 提现所要达到的流水
        /// </summary>
        public decimal RequireFlowMoney { get; set; }
        /// <summary>
        /// 记录时间
        /// </summary>
        public DateTime RecDate { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime UpdateTime { get; set; }
        /// <summary>
        /// 状态(0-未完成1-已完成2-END)
        /// </summary>
        public int Status { get; set; }
        /// <summary>
        /// 提现所要达到的流水
        /// </summary>
        [JsonIgnore]
        public long RequireFlow { get; set; }
        /// <summary>
        /// 当前已完成的流水
        /// </summary>
        [JsonIgnore]
        public long CompletedFlow { get; set; }

        /// <summary>
        /// 当前订单赠送的bonus金额
        /// </summary>
        public decimal Bonus { get; set; }

        /// <summary>
        /// 当前需要完成的流水倍数
        /// </summary>
        public float FlowMultip { get; set; }



        public void MapFrom(S_requireflow_orderEO source)
        {
            this.RequireFlowMoney = source.RequireFlow.AToM(source.CurrencyID);
            this.CompletedFlowMoney = source.CompletedFlow.AToM(source.CurrencyID);
            if (source.Status == 1 && source.CompletedFlow < source.RequireFlow)
            {
                source.Status = 2;
            }
            this.Bonus = source.OrderAmount.AToM(source.CurrencyID);

            this.RecDate = new DateTime(this.RecDate.Ticks, DateTimeKind.Utc);
            this.UpdateTime = new DateTime(this.UpdateTime.Ticks, DateTimeKind.Utc);
        }
    }

}
