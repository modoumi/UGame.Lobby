using UGame.Lobby.Repository.ing;
using AiUo.Extensions.AutoMapper;

namespace UGame.Lobby.Service.Services.Activity.Rebate
{
    public class RebateDotRequet : LobbyBaseIpo
    {
        /// <summary>
        /// 获取返点日期
        /// </summary>
        public DateTime? RebateDateUtc { get; set; }
        /// <summary>
        /// 频度，0:未知，1:每日，2:每周，3:每月
        /// </summary>
        public int Frequency { get; set; }
    }

    public class GetRebateListDto
    {
        /// <summary>
        /// 总的奖励数
        /// </summary>
        public decimal TotalReward { get; set; }
        public List<RebateDotResponse> DotList { get; set; }
    }

    public class RebateDotResponse : IMapFrom<Sa_rebate_user_detailEO>
    {
        /// <summary>
        /// 活动奖励记录id
        /// 【主键 varchar(36)】
        /// </summary>
        public string DetailID { get; set; }
        /// <summary>
        /// 用户编码
        /// 【字段 varchar(36)】
        /// </summary>

        public string UserID { get; set; }
        /// <summary>
        /// 记录天
        /// 【字段 date】
        /// </summary>
        public DateTime? DayID { get; set; }

        /// <summary>
        /// 运营商编码
        /// 【字段 varchar(50)】
        /// </summary>
        public string OperatorID { get; set; }

        /// <summary>
        /// 返点类型0默认值，1返点，2返水
        /// 【字段 int】
        /// </summary>
        public int RebateType { get; set; }
        /// <summary>
        /// 返点金额
        /// 【字段 bigint】
        /// </summary>
        public long RebateAmount { get; set; }

        public decimal RebateAmount3 { get; set; }

        public decimal BetMinAmount { get; set; }

        //public string SearchKey { get; set; }

        /// <summary>
        /// 等级
        /// 【字段 int】
        /// </summary>
        public int Level { get; set; }

        ///// <summary>
        ///// 发送通知状态，0-未通知1-已通知
        ///// 【字段 int】
        ///// </summary>
        //public int NotifyStatus { get; set; }
        /// <summary>
        /// 用户领取状态，0-未领取1-已领取
        /// 【字段 int】
        /// </summary>
        public int ReceiveStatus { get; set; }
        /// <summary>
        /// 记录时间
        /// 【字段 datetime】
        /// </summary>
        public DateTime RecDate { get; set; }

        public int Percent { get; set; }

        /// <summary>
        /// 当前总下注额
        /// </summary>
        public decimal TotalBetAmount { get; set; }

        /// <summary>
        /// 当前下注额
        /// </summary>
        public decimal CurrentBetAmount { get; set; }

        /// <summary>
        /// 需要完成下注额
        /// </summary>
        public decimal NeedBetAmount { get; set; }

        public void MapFrom(Sa_rebate_user_detailEO source)
        {


        }
    }
}
