
using UGame.Lobby.Service.Services.Activity.Roulette;
using UGame.Lobby.Service.Services.Profile;
using System.Text;
using AiUo.Data;
using UGame.Lobby.Service.Services.Home;
using Xxyy.Common;

namespace UGame.Lobby.Service
{
    public class SqlSink
    {


        #region 注册、首充活动推荐游戏

        /// <summary>
        /// 注册、首充活动推荐游戏
        /// </summary>
        /// <param name="OperatorId"></param>
        /// <param name="langId"></param>
        /// <returns></returns>
        public List<CategoryMoreDto> RegpayRecommendGames(string OperatorId, string langId)
        {
            string sql = $@"select
	                            l_app.AppID,
	                            l_app.SmallIcon,
	                            l_app.MiddleIcon,
	                            l_app.BigIcon,
	                            l_app.Flag
                            from l_app
                            inner join 
                            (select * from l_category_app 
                            where ParentID = (select CategoryID from l_category where TopLevelType = 1 and OperatorID = @OperatorID and (LangId = @LangId or LangId is null))
                            order by CategoryID,OrderNum
                            limit 3) as temp
                            on l_app.AppID = temp.AppID";

            return DbSink.MainDb.ExecSqlList<CategoryMoreDto>(sql, OperatorId, langId);
        }


        #endregion


        #region 获取用户当天提现次数（当天提现成功金额 + 审核处理中、成功状态的）

        /// <summary>
        /// 获取用户当天提现次数
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public async Task<long> GetUserDayCashSumCount(string userId, DateTime startTime, DateTime endTime)
        {
            var ret = 0L;

            //直接提款次数
            var data = await DbSink.MainDb.ExecSqlScalarAsync<long?>($@"select
	                                                                        count(*) as SumCashCount
                                                                        from sb_bank_order 
                                                                        where UserID = @UserID
                                                                        and OrderType = 2
                                                                        and RecDate >= @startTime
                                                                        and RecDate < @endTime;", userId, startTime, endTime);
            if (data.HasValue)
                ret += data.Value;

            //sc_cash_audit 当天所有状态的提现
            data = await DbSink.MainDb.ExecSqlScalarAsync<long?>($@"select 
	                                                                    count(*) as SumCashCount
                                                                    from sc_cash_audit 
                                                                    where UserID = @UserID
                                                                    and `Status` < 2
                                                                    and ApplyTime >= @startTime 
                                                                    and ApplyTime < @endTime", userId, startTime, endTime);
            if (data.HasValue)
                ret += data.Value;

            return ret;
        }

        #endregion

        #region 获取用户当天提现总额（当天提现成功金额 + 审核处理中、成功状态的）

        /// <summary>
        /// 获取用户当天提现总额
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public async Task<long> GetUserDayCashSumAmount(string userId, DateTime startTime, DateTime endTime)
        {
            var ret = 0L;

            //已经提款成功
            var data = await DbSink.MainDb.ExecSqlScalarAsync<long?>($@"select	
	                                                                        SUM(ABS(Amount)) as SumCashAmount
                                                                        from sb_bank_order 
                                                                        where UserID = @UserID
                                                                        and OrderType = 2
                                                                        and `Status` <= 2
                                                                        and IsAuditOrder=0
                                                                        and RecDate >= @startTime
                                                                        and RecDate < @endTime;", userId, startTime, endTime);

            if (data.HasValue)
                ret += data.Value;

            //审核中的提款金额（不等于拒绝的都计算在内）
            data = await DbSink.MainDb.ExecSqlScalarAsync<long?>($@"select 
	                                                                    SUM(ABS(Amount)) as SumCashAmount
                                                                    from sc_cash_audit 
                                                                    where UserID = @UserID 
                                                                    and `Status` < 2
                                                                    and ApplyTime >= @startTime 
                                                                    and ApplyTime < @endTime", userId, startTime, endTime);

            if (data.HasValue)
                ret += data.Value;

            return ret;
        }

        #endregion

        #region 获取用户当天审批中非拒绝状态的提现总额

        /// <summary>
        /// 获取用户当天审批中非拒绝状态的提现总额
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public async Task<long> GetUserAllAuditCashSumAmount(string userId, DateTime startTime, DateTime endTime)
        {
            var ret = 0L;

            //审核中的提款金额（不等于拒绝的都计算在内）
            var data = await DbSink.MainDb.ExecSqlScalarAsync<long?>($@"select 
	                                                                    SUM(Amount) as SumCashAmount
                                                                    from sc_cash_audit 
                                                                    where UserID = @UserID 
                                                                    and `Status` <> 2", userId);

            if (data.HasValue)
                ret += Math.Abs(data.Value);

            return ret;
        }

        #endregion

    }



}
