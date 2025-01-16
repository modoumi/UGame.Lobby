using System.Text.Json.Serialization;
using AiUo.AspNet;
using AiUo.Extensions.AutoMapper;
using AiUo.Text;
using Xxyy.Banks.Client;
using Xxyy.Banks.Client.BLL;
using Xxyy.Common;

namespace UGame.Lobby.Service.Services.Profile
{
    public class OrderIpo : LobbyBaseIpo, IMapTo<XxyyGetOrderIpo>
    {
        /// <summary>
        /// 应用编码
        /// </summary>
        [RequiredEx("", "AppId不可为空")]
        public string AppId { get; set; }
        /// <summary>
        /// 订单编号
        /// </summary>
        [RequiredEx("", "OrderId不可为空")]
        public string OrderId { get; set; }

        public string RequestUUID { get; set; } = ObjectId.NewId();
        /// <summary>
        /// 扩展数据
        /// </summary>
        public object Meta { get; set; }

        public void MapTo(XxyyGetOrderIpo destination)
        {
            
        }
    }

    public class OrderDto : IMapFrom<Xxyy.Banks.Client.BLL.GetOrderDto>
    {
        /// <summary>
        /// 订单编号
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// 用户 编号
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// 应用编码
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
		/// 应用提供商编码
		/// </summary>
        public string ProviderId { get; set; }

        /// <summary>
        /// 运营商编码
        /// </summary>
        public string OperatorId { get; set; }

        /// <summary>
        /// 我方承担的手续费
        /// </summary>
        [JsonIgnore]
        public decimal OwnFee { get; set; }

        /// <summary>
        /// 用户承担的手续费
        /// </summary>
        [JsonIgnore]
        public decimal UserFee { get; set; }

        /// <summary>
        /// 用户实际收到或者实际支付的金额
        /// </summary>
        [JsonIgnore]
        public decimal UserMoney { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        public BankOrderStatusClientEnum OrderStatus { get; set; }

        /// <summary>
        /// 充值、返现
        /// </summary>
        public ClientOrderTypeEnum OrderType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonIgnore]
        public ClientPayTypeEnum PaytypeID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int PaytypeChannel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ChannelName { get; set; }

        /// <summary>
        /// 货币编码
        /// </summary>
        public string CurrencyId { get; set; }
        /// <summary>
        /// 计划变化金额（正负数）
        /// 【字段 bigint】
        /// </summary>
        [JsonIgnore]
        public long PlanAmount { get; set; }

        /// <summary>
        /// 实际数量
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonIgnore]
        public string Status { get; set; }


        /// <summary>
        /// 下单时间
        /// </summary>
        public DateTime RecDate { get; set; }



        public string StatusDesc
        {
            get
            {
                var ret = OrderStatus.ToString();
                switch (OrderStatus)
                {
                    case BankOrderStatusClientEnum.Initial:
                        ret = "订单初始化";
                        break;
                    case BankOrderStatusClientEnum.Processing:
                        ret = "处理中";
                        break;
                    case BankOrderStatusClientEnum.Success:
                        ret = "成功";
                        break;
                    case BankOrderStatusClientEnum.Fail:
                        ret = "失败";
                        break;
                    case BankOrderStatusClientEnum.Rollback:
                        ret = "已回滚";
                        break;
                    case BankOrderStatusClientEnum.Exception:
                        ret = "异常且需处理";
                        break;
                    case BankOrderStatusClientEnum.ExceptionHandled:
                        ret = "异常已处理";
                        break;
                }
                return ret;
            }
            set
            {
                StatusDesc = value;
            }
        }

        public void MapFrom(GetOrderDto source)
        {
            Amount = source.Amount.AToM(source.CurrencyId);
        }
    }

}
