using UGame.Lobby.Repository.ing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Caching;
using AiUo.Extensions.StackExchangeRedis;
using Xxyy.Common;

namespace UGame.Lobby.Service.Caching.Activity
{

    public class ActivityListDCache : RedisStringClient<List<ActivityEventEntity>>
    {
        private const int EXPIRE_MINUTE = 10;

        /// <summary>
        /// 运营商编码
        /// </summary>
        public string OperatorId { get; set; }

        /// <summary>
        /// 货币编码
        /// </summary>
        public string CurrencyId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="operatorId"></param>
        /// <param name="currencyId"></param>
        public ActivityListDCache(string operatorId, string currencyId)
        {
            this.OperatorId = operatorId;
            this.CurrencyId = currencyId;
            RedisKey = GetProjectGroupRedisKey("Activity", $"{this.OperatorId}|{this.CurrencyId}");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        protected override async Task<CacheValue<List<ActivityEventEntity>>> LoadValueWhenRedisNotExistsAsync()
        {
            var ret = new CacheValue<List<ActivityEventEntity>>();

            var sql = $@"select
	                    l_activity_operator.ActivityID,
	                    l_activity_operator.OperatorID,
	                    l_activity_operator.CurrencyID,
	                    l_activity_operator.CountryID,
	                    l_activity_operator.BeginDate,
	                    l_activity_operator.EndDate,
	                    l_activity_operator.OrderNum,
	                    l_activity_operator.`Status`,
	                    l_activity_operator.IsSendNotify,
	                    l_activity_operator.IsSendNotifyEmail,
	                    l_activity_operator.IsAllowEnd,
	                    l_activity_operator.IsAllowIndexRecommend,
	                    l_activity_operator.IsAllowPayRecommend,
	                    l_activity_operator.IsBonus,
	                    l_activity_event_operator.ActivityEventId as EventId
                    from l_activity_operator
                    inner join l_activity_event_operator
                    on l_activity_operator.OperatorID = l_activity_event_operator.OperatorID and l_activity_operator.ActivityID = l_activity_event_operator.ActivityID
                    where l_activity_operator.`Status` = 1
                    and l_activity_operator.OperatorID = @OperatorID
                    and l_activity_operator.CurrencyID = @CurrencyID
                    and @TimeNow BETWEEN l_activity_operator.BeginDate and l_activity_operator.EndDate
                    and l_activity_event_operator.`Status` = 1
                    order by l_activity_operator.OrderNum";


            ret.Value = await DbSink.MainDb.ExecSqlListAsync<ActivityEventEntity>(sql, this.OperatorId, this.CurrencyId, DateTime.UtcNow);
            
            ret.HasValue = ret.Value != null && ret.Value.Any();

            return ret;
        }

        /// <summary>
        /// GetAsync
        /// </summary>
        /// <returns></returns>
        public async Task<CacheValue<List<ActivityEventEntity>>> GetAsync()
        {
            return await GetOrLoadAsync(false, TimeSpan.FromDays(EXPIRE_MINUTE));
        }

        /// <summary>
        /// SetAsync
        /// </summary>
        /// <returns></returns>
        public async Task SetAsync()
        {
            await GetOrLoadAsync(true, TimeSpan.FromDays(EXPIRE_MINUTE));
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class ActivityEventEntity
    { 
        /// <summary>
        /// 活动编码
        /// </summary>
        public int ActivityID { get; set; }
        /// <summary>
        /// 运营商编码
        /// </summary>
        public string OperatorId { get; set; }
        /// <summary>
        /// 货币编码
        /// </summary>
        public string CurrencyId { get; set; }
        /// <summary>
        /// 活动描述
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 国家编码
        /// </summary>
        public string CountryId { get; set; }
        /// <summary>
        /// 活动起始日期
        /// </summary>
        public DateTime BeginDate { get; set; }
        /// <summary>
        /// 活动截止日期
        /// </summary>
        public DateTime EndDate { get; set; }
        /// <summary>
        /// 活动排序
        /// </summary>
        public int OrderNum { get; set; }
        /// <summary>
        /// 活动状态
        /// </summary>
        public bool Status { get; set; }
        /// <summary>
        /// 活动事件id
        /// </summary>
        public int EventId { get; set; }
        /// <summary>
        /// 是否发送弹框通知
        /// </summary>
        public bool IsSendNotify { get; set; }
        /// <summary>
        /// 是否发送站内邮箱通知
        /// </summary>
        public bool IsSendNotifyEmail { get; set; }
        /// <summary>
        /// 是否允许完成
        /// </summary>
        public bool IsAllowEnd { get; set; }
        /// <summary>
        /// 是否允许首页banner位推荐
        /// </summary>
        public bool IsAllowIndexRecommend { get; set; }
        /// <summary>
        /// 是否为充值页推荐的banner
        /// </summary>
        public bool IsAllowPayRecommend { get; set; }
        /// <summary>
        /// 0-真金1-bonus,如果s_operator.EnableBonus=false,则忽视当前值,统一为真金
        /// </summary>
        public bool IsBonus { get; set; }
    }

}
