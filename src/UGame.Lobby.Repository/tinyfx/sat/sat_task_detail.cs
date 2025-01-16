/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * AiUo代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/AiUo
 * 文档生成时间：2023-10-24 18: 05:10
 ******************************************************/
using System;
using System.Data;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using AiUo;
using AiUo.Data;
using MySql.Data.MySqlClient;
using System.Text;
using AiUo.Data.MySql;

namespace UGame.Lobby.Repository.ing
{
	#region EO
	/// <summary>
	/// 任务明细
	/// 【表 sat_task_detail 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Sat_task_detailEO : IRowMapper<Sat_task_detailEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Sat_task_detailEO()
		{
			this.Level = 0;
			this.RewardType = 0;
			this.IssueRule = 1;
			this.RewardAmount = 0;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private string _originalDetailID;
		/// <summary>
		/// 【数据库中的原始主键 DetailID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalDetailID
		{
			get { return _originalDetailID; }
			set { HasOriginal = true; _originalDetailID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "DetailID", DetailID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 明细ID
		/// 【主键 varchar(38)】
		/// </summary>
		[DataMember(Order = 1)]
		public string DetailID { get; set; }
		/// <summary>
		/// 用户编码(GUID)
		/// 【字段 varchar(38)】
		/// </summary>
		[DataMember(Order = 2)]
		public string UserID { get; set; }
		/// <summary>
		/// 工具编码
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 3)]
		public int ItemID { get; set; }
		/// <summary>
		/// 日期ID,针对循环类活动,通常是日期
		/// 【字段 date】
		/// </summary>
		[DataMember(Order = 4)]
		public DateTime DayID { get; set; }
		/// <summary>
		/// 等级
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 5)]
		public int Level { get; set; }
		/// <summary>
		/// 失效日期, 不包含此日期 utc格式
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 6)]
		public DateTime? Deadline { get; set; }
		/// <summary>
		/// 奖励类型 0-未知 1-Bonus 2-真金
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 7)]
		public int? RewardType { get; set; }
		/// <summary>
		/// 流水倍数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 8)]
		public int? FlowMultip { get; set; }
		/// <summary>
		/// 发放规则,0-未知 1-固定金额 2-按权重 3-随机抽取
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 9)]
		public int? IssueRule { get; set; }
		/// <summary>
		/// 奖励条件表达式, 有值才会执行规则,没有值则在对应action中进行处理
		/// 【字段 varchar(500)】
		/// </summary>
		[DataMember(Order = 10)]
		public string ConditionExpr { get; set; }
		/// <summary>
		/// 奖励的金额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 11)]
		public long RewardAmount { get; set; }
		/// <summary>
		/// 奖励行json
		/// 【字段 varchar(500)】
		/// </summary>
		[DataMember(Order = 12)]
		public string RewardLines { get; set; }
		/// <summary>
		/// 记录日期
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 13)]
		public DateTime RecDate { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Sat_task_detailEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Sat_task_detailEO MapDataReader(IDataReader reader)
		{
		    Sat_task_detailEO ret = new Sat_task_detailEO();
			ret.DetailID = reader.ToString("DetailID");
			ret.OriginalDetailID = ret.DetailID;
			ret.UserID = reader.ToString("UserID");
			ret.ItemID = reader.ToInt32("ItemID");
			ret.DayID = reader.ToDateTime("DayID");
			ret.Level = reader.ToInt32("Level");
			ret.Deadline = reader.ToDateTimeN("Deadline");
			ret.RewardType = reader.ToInt32N("RewardType");
			ret.FlowMultip = reader.ToInt32N("FlowMultip");
			ret.IssueRule = reader.ToInt32N("IssueRule");
			ret.ConditionExpr = reader.ToString("ConditionExpr");
			ret.RewardAmount = reader.ToInt64("RewardAmount");
			ret.RewardLines = reader.ToString("RewardLines");
			ret.RecDate = reader.ToDateTime("RecDate");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 任务明细
	/// 【表 sat_task_detail 的操作类】
	/// </summary>
	[Obsolete]
	public class Sat_task_detailMO : MySqlTableMO<Sat_task_detailEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`sat_task_detail`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Sat_task_detailMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Sat_task_detailMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Sat_task_detailMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Sat_task_detailEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Sat_task_detailEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Sat_task_detailEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`DetailID`, `UserID`, `ItemID`, `DayID`, `Level`, `Deadline`, `RewardType`, `FlowMultip`, `IssueRule`, `ConditionExpr`, `RewardAmount`, `RewardLines`, `RecDate`) VALUE (@DetailID, @UserID, @ItemID, @DayID, @Level, @Deadline, @RewardType, @FlowMultip, @IssueRule, @ConditionExpr, @RewardAmount, @RewardLines, @RecDate);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", item.DetailID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ItemID", item.ItemID, MySqlDbType.Int32),
				Database.CreateInParameter("@DayID", item.DayID, MySqlDbType.Date),
				Database.CreateInParameter("@Level", item.Level, MySqlDbType.Int32),
				Database.CreateInParameter("@Deadline", item.Deadline.HasValue ? item.Deadline.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@RewardType", item.RewardType.HasValue ? item.RewardType.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@FlowMultip", item.FlowMultip.HasValue ? item.FlowMultip.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@IssueRule", item.IssueRule.HasValue ? item.IssueRule.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@ConditionExpr", item.ConditionExpr != null ? item.ConditionExpr : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@RewardAmount", item.RewardAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@RewardLines", item.RewardLines != null ? item.RewardLines : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
			};
		}
		public int AddByBatch(IEnumerable<Sat_task_detailEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Sat_task_detailEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sat_task_detailEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`DetailID`, `UserID`, `ItemID`, `DayID`, `Level`, `Deadline`, `RewardType`, `FlowMultip`, `IssueRule`, `ConditionExpr`, `RewardAmount`, `RewardLines`, `RecDate`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.DetailID}','{item.UserID}',{item.ItemID},'{item.DayID.ToString("yyyy-MM-dd HH:mm:ss")}',{item.Level},'{item.Deadline?.ToString("yyyy-MM-dd HH:mm:ss")}',{item.RewardType?.ToString()??null},{item.FlowMultip?.ToString()??null},{item.IssueRule?.ToString()??null},'{item.ConditionExpr}',{item.RewardAmount},'{item.RewardLines}','{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}'),");
				if (count == batchCount)
				{
					count = 0;
					sql.Insert(0, insertSql);
					var ret = sql.ToString().TrimEnd(',');
					sql.Clear();
	                yield return ret;
				}
			}
			if (sql.Length > 0)
			{
	            sql.Insert(0, insertSql);
	            yield return sql.ToString().TrimEnd(',');
	        }
	    }
	    #endregion // Add
	    
		#region Remove
		#region RemoveByPK
		/// <summary>
		/// 按主键删除
		/// </summary>
		/// /// <param name = "detailID">明细ID</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string detailID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(detailID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(detailID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string detailID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Sat_task_detailEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.DetailID, tm_);
		}
		public async Task<int> RemoveAsync(Sat_task_detailEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.DetailID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByUserID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByUserID(string userID, TransactionManager tm_ = null)
		{
			RepairRemoveByUserIDData(userID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByUserIDAsync(string userID, TransactionManager tm_ = null)
		{
			RepairRemoveByUserIDData(userID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByUserIDData(string userID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByUserID
		#region RemoveByItemID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByItemID(int itemID, TransactionManager tm_ = null)
		{
			RepairRemoveByItemIDData(itemID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByItemIDAsync(int itemID, TransactionManager tm_ = null)
		{
			RepairRemoveByItemIDData(itemID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByItemIDData(int itemID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `ItemID` = @ItemID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32));
		}
		#endregion // RemoveByItemID
		#region RemoveByDayID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "dayID">日期ID,针对循环类活动,通常是日期</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByDayID(DateTime dayID, TransactionManager tm_ = null)
		{
			RepairRemoveByDayIDData(dayID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByDayIDAsync(DateTime dayID, TransactionManager tm_ = null)
		{
			RepairRemoveByDayIDData(dayID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByDayIDData(DateTime dayID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `DayID` = @DayID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date));
		}
		#endregion // RemoveByDayID
		#region RemoveByLevel
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "level">等级</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByLevel(int level, TransactionManager tm_ = null)
		{
			RepairRemoveByLevelData(level, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByLevelAsync(int level, TransactionManager tm_ = null)
		{
			RepairRemoveByLevelData(level, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByLevelData(int level, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Level` = @Level";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Level", level, MySqlDbType.Int32));
		}
		#endregion // RemoveByLevel
		#region RemoveByDeadline
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "deadline">失效日期, 不包含此日期 utc格式</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByDeadline(DateTime? deadline, TransactionManager tm_ = null)
		{
			RepairRemoveByDeadlineData(deadline.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByDeadlineAsync(DateTime? deadline, TransactionManager tm_ = null)
		{
			RepairRemoveByDeadlineData(deadline.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByDeadlineData(DateTime? deadline, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (deadline.HasValue ? "`Deadline` = @Deadline" : "`Deadline` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (deadline.HasValue)
				paras_.Add(Database.CreateInParameter("@Deadline", deadline.Value, MySqlDbType.DateTime));
		}
		#endregion // RemoveByDeadline
		#region RemoveByRewardType
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "rewardType">奖励类型 0-未知 1-Bonus 2-真金</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByRewardType(int? rewardType, TransactionManager tm_ = null)
		{
			RepairRemoveByRewardTypeData(rewardType.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByRewardTypeAsync(int? rewardType, TransactionManager tm_ = null)
		{
			RepairRemoveByRewardTypeData(rewardType.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByRewardTypeData(int? rewardType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (rewardType.HasValue ? "`RewardType` = @RewardType" : "`RewardType` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (rewardType.HasValue)
				paras_.Add(Database.CreateInParameter("@RewardType", rewardType.Value, MySqlDbType.Int32));
		}
		#endregion // RemoveByRewardType
		#region RemoveByFlowMultip
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "flowMultip">流水倍数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByFlowMultip(int? flowMultip, TransactionManager tm_ = null)
		{
			RepairRemoveByFlowMultipData(flowMultip.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByFlowMultipAsync(int? flowMultip, TransactionManager tm_ = null)
		{
			RepairRemoveByFlowMultipData(flowMultip.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByFlowMultipData(int? flowMultip, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (flowMultip.HasValue ? "`FlowMultip` = @FlowMultip" : "`FlowMultip` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (flowMultip.HasValue)
				paras_.Add(Database.CreateInParameter("@FlowMultip", flowMultip.Value, MySqlDbType.Int32));
		}
		#endregion // RemoveByFlowMultip
		#region RemoveByIssueRule
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "issueRule">发放规则,0-未知 1-固定金额 2-按权重 3-随机抽取</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByIssueRule(int? issueRule, TransactionManager tm_ = null)
		{
			RepairRemoveByIssueRuleData(issueRule.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByIssueRuleAsync(int? issueRule, TransactionManager tm_ = null)
		{
			RepairRemoveByIssueRuleData(issueRule.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByIssueRuleData(int? issueRule, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (issueRule.HasValue ? "`IssueRule` = @IssueRule" : "`IssueRule` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (issueRule.HasValue)
				paras_.Add(Database.CreateInParameter("@IssueRule", issueRule.Value, MySqlDbType.Int32));
		}
		#endregion // RemoveByIssueRule
		#region RemoveByConditionExpr
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "conditionExpr">奖励条件表达式, 有值才会执行规则,没有值则在对应action中进行处理</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByConditionExpr(string conditionExpr, TransactionManager tm_ = null)
		{
			RepairRemoveByConditionExprData(conditionExpr, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByConditionExprAsync(string conditionExpr, TransactionManager tm_ = null)
		{
			RepairRemoveByConditionExprData(conditionExpr, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByConditionExprData(string conditionExpr, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (conditionExpr != null ? "`ConditionExpr` = @ConditionExpr" : "`ConditionExpr` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (conditionExpr != null)
				paras_.Add(Database.CreateInParameter("@ConditionExpr", conditionExpr, MySqlDbType.VarChar));
		}
		#endregion // RemoveByConditionExpr
		#region RemoveByRewardAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "rewardAmount">奖励的金额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByRewardAmount(long rewardAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByRewardAmountData(rewardAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByRewardAmountAsync(long rewardAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByRewardAmountData(rewardAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByRewardAmountData(long rewardAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `RewardAmount` = @RewardAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RewardAmount", rewardAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByRewardAmount
		#region RemoveByRewardLines
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "rewardLines">奖励行json</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByRewardLines(string rewardLines, TransactionManager tm_ = null)
		{
			RepairRemoveByRewardLinesData(rewardLines, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByRewardLinesAsync(string rewardLines, TransactionManager tm_ = null)
		{
			RepairRemoveByRewardLinesData(rewardLines, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByRewardLinesData(string rewardLines, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (rewardLines != null ? "`RewardLines` = @RewardLines" : "`RewardLines` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (rewardLines != null)
				paras_.Add(Database.CreateInParameter("@RewardLines", rewardLines, MySqlDbType.VarChar));
		}
		#endregion // RemoveByRewardLines
		#region RemoveByRecDate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "recDate">记录日期</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByRecDate(DateTime recDate, TransactionManager tm_ = null)
		{
			RepairRemoveByRecDateData(recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByRecDateAsync(DateTime recDate, TransactionManager tm_ = null)
		{
			RepairRemoveByRecDateData(recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByRecDateData(DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `RecDate` = @RecDate";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
		}
		#endregion // RemoveByRecDate
		#endregion // RemoveByXXX
	    
		#region RemoveByFKOrUnique
		#region RemoveByUserIDAndDayIDAndItemID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "dayID">日期ID,针对循环类活动,通常是日期</param>
		/// /// <param name = "itemID">工具编码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByUserIDAndDayIDAndItemID(string userID, DateTime dayID, int itemID, TransactionManager tm_ = null)
		{
			RepiarRemoveByUserIDAndDayIDAndItemIDData(userID, dayID, itemID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByUserIDAndDayIDAndItemIDAsync(string userID, DateTime dayID, int itemID, TransactionManager tm_ = null)
		{
			RepiarRemoveByUserIDAndDayIDAndItemIDData(userID, dayID, itemID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByUserIDAndDayIDAndItemIDData(string userID, DateTime dayID, int itemID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `UserID` = @UserID AND `DayID` = @DayID AND `ItemID` = @ItemID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
			};
		}
		#endregion // RemoveByUserIDAndDayIDAndItemID
		#endregion // RemoveByFKOrUnique
		#endregion //Remove
	    
		#region Put
		#region PutItem
		/// <summary>
		/// 更新实体到数据库
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(Sat_task_detailEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Sat_task_detailEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Sat_task_detailEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `DetailID` = @DetailID, `UserID` = @UserID, `ItemID` = @ItemID, `DayID` = @DayID, `Level` = @Level, `Deadline` = @Deadline, `RewardType` = @RewardType, `FlowMultip` = @FlowMultip, `IssueRule` = @IssueRule, `ConditionExpr` = @ConditionExpr, `RewardAmount` = @RewardAmount, `RewardLines` = @RewardLines, `RecDate` = @RecDate WHERE `DetailID` = @DetailID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", item.DetailID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ItemID", item.ItemID, MySqlDbType.Int32),
				Database.CreateInParameter("@DayID", item.DayID, MySqlDbType.Date),
				Database.CreateInParameter("@Level", item.Level, MySqlDbType.Int32),
				Database.CreateInParameter("@Deadline", item.Deadline.HasValue ? item.Deadline.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@RewardType", item.RewardType.HasValue ? item.RewardType.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@FlowMultip", item.FlowMultip.HasValue ? item.FlowMultip.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@IssueRule", item.IssueRule.HasValue ? item.IssueRule.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@ConditionExpr", item.ConditionExpr != null ? item.ConditionExpr : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@RewardAmount", item.RewardAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@RewardLines", item.RewardLines != null ? item.RewardLines : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@DetailID_Original", item.HasOriginal ? item.OriginalDetailID : item.DetailID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Sat_task_detailEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Sat_task_detailEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += await PutAsync(item, tm_);
			}
			return ret;
		}
		#endregion // PutItem
		
		#region PutByPK
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "detailID">明细ID</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string detailID, string set_, params object[] values_)
		{
			return Put(set_, "`DetailID` = @DetailID", ConcatValues(values_, detailID));
		}
		public async Task<int> PutByPKAsync(string detailID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`DetailID` = @DetailID", ConcatValues(values_, detailID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "detailID">明细ID</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string detailID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`DetailID` = @DetailID", tm_, ConcatValues(values_, detailID));
		}
		public async Task<int> PutByPKAsync(string detailID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`DetailID` = @DetailID", tm_, ConcatValues(values_, detailID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "detailID">明细ID</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string detailID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`DetailID` = @DetailID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string detailID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`DetailID` = @DetailID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutUserID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID">明细ID</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserIDByPK(string detailID, string userID, TransactionManager tm_ = null)
		{
			RepairPutUserIDByPKData(detailID, userID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutUserIDByPKAsync(string detailID, string userID, TransactionManager tm_ = null)
		{
			RepairPutUserIDByPKData(detailID, userID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutUserIDByPKData(string detailID, string userID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UserID` = @UserID  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserID(string userID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserID` = @UserID";
			var parameter_ = Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutUserIDAsync(string userID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserID` = @UserID";
			var parameter_ = Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutUserID
		#region PutItemID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID">明细ID</param>
		/// /// <param name = "itemID">工具编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutItemIDByPK(string detailID, int itemID, TransactionManager tm_ = null)
		{
			RepairPutItemIDByPKData(detailID, itemID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutItemIDByPKAsync(string detailID, int itemID, TransactionManager tm_ = null)
		{
			RepairPutItemIDByPKData(detailID, itemID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutItemIDByPKData(string detailID, int itemID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ItemID` = @ItemID  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutItemID(int itemID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ItemID` = @ItemID";
			var parameter_ = Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutItemIDAsync(int itemID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ItemID` = @ItemID";
			var parameter_ = Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutItemID
		#region PutDayID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID">明细ID</param>
		/// /// <param name = "dayID">日期ID,针对循环类活动,通常是日期</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutDayIDByPK(string detailID, DateTime dayID, TransactionManager tm_ = null)
		{
			RepairPutDayIDByPKData(detailID, dayID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutDayIDByPKAsync(string detailID, DateTime dayID, TransactionManager tm_ = null)
		{
			RepairPutDayIDByPKData(detailID, dayID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutDayIDByPKData(string detailID, DateTime dayID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `DayID` = @DayID  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "dayID">日期ID,针对循环类活动,通常是日期</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutDayID(DateTime dayID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `DayID` = @DayID";
			var parameter_ = Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutDayIDAsync(DateTime dayID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `DayID` = @DayID";
			var parameter_ = Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutDayID
		#region PutLevel
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID">明细ID</param>
		/// /// <param name = "level">等级</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLevelByPK(string detailID, int level, TransactionManager tm_ = null)
		{
			RepairPutLevelByPKData(detailID, level, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLevelByPKAsync(string detailID, int level, TransactionManager tm_ = null)
		{
			RepairPutLevelByPKData(detailID, level, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLevelByPKData(string detailID, int level, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Level` = @Level  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Level", level, MySqlDbType.Int32),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "level">等级</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLevel(int level, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Level` = @Level";
			var parameter_ = Database.CreateInParameter("@Level", level, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutLevelAsync(int level, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Level` = @Level";
			var parameter_ = Database.CreateInParameter("@Level", level, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutLevel
		#region PutDeadline
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID">明细ID</param>
		/// /// <param name = "deadline">失效日期, 不包含此日期 utc格式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutDeadlineByPK(string detailID, DateTime? deadline, TransactionManager tm_ = null)
		{
			RepairPutDeadlineByPKData(detailID, deadline, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutDeadlineByPKAsync(string detailID, DateTime? deadline, TransactionManager tm_ = null)
		{
			RepairPutDeadlineByPKData(detailID, deadline, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutDeadlineByPKData(string detailID, DateTime? deadline, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Deadline` = @Deadline  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Deadline", deadline.HasValue ? deadline.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "deadline">失效日期, 不包含此日期 utc格式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutDeadline(DateTime? deadline, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Deadline` = @Deadline";
			var parameter_ = Database.CreateInParameter("@Deadline", deadline.HasValue ? deadline.Value : (object)DBNull.Value, MySqlDbType.DateTime);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutDeadlineAsync(DateTime? deadline, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Deadline` = @Deadline";
			var parameter_ = Database.CreateInParameter("@Deadline", deadline.HasValue ? deadline.Value : (object)DBNull.Value, MySqlDbType.DateTime);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutDeadline
		#region PutRewardType
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID">明细ID</param>
		/// /// <param name = "rewardType">奖励类型 0-未知 1-Bonus 2-真金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRewardTypeByPK(string detailID, int? rewardType, TransactionManager tm_ = null)
		{
			RepairPutRewardTypeByPKData(detailID, rewardType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRewardTypeByPKAsync(string detailID, int? rewardType, TransactionManager tm_ = null)
		{
			RepairPutRewardTypeByPKData(detailID, rewardType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRewardTypeByPKData(string detailID, int? rewardType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RewardType` = @RewardType  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RewardType", rewardType.HasValue ? rewardType.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "rewardType">奖励类型 0-未知 1-Bonus 2-真金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRewardType(int? rewardType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RewardType` = @RewardType";
			var parameter_ = Database.CreateInParameter("@RewardType", rewardType.HasValue ? rewardType.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutRewardTypeAsync(int? rewardType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RewardType` = @RewardType";
			var parameter_ = Database.CreateInParameter("@RewardType", rewardType.HasValue ? rewardType.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutRewardType
		#region PutFlowMultip
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID">明细ID</param>
		/// /// <param name = "flowMultip">流水倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFlowMultipByPK(string detailID, int? flowMultip, TransactionManager tm_ = null)
		{
			RepairPutFlowMultipByPKData(detailID, flowMultip, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFlowMultipByPKAsync(string detailID, int? flowMultip, TransactionManager tm_ = null)
		{
			RepairPutFlowMultipByPKData(detailID, flowMultip, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFlowMultipByPKData(string detailID, int? flowMultip, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `FlowMultip` = @FlowMultip  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@FlowMultip", flowMultip.HasValue ? flowMultip.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "flowMultip">流水倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFlowMultip(int? flowMultip, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FlowMultip` = @FlowMultip";
			var parameter_ = Database.CreateInParameter("@FlowMultip", flowMultip.HasValue ? flowMultip.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutFlowMultipAsync(int? flowMultip, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FlowMultip` = @FlowMultip";
			var parameter_ = Database.CreateInParameter("@FlowMultip", flowMultip.HasValue ? flowMultip.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutFlowMultip
		#region PutIssueRule
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID">明细ID</param>
		/// /// <param name = "issueRule">发放规则,0-未知 1-固定金额 2-按权重 3-随机抽取</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIssueRuleByPK(string detailID, int? issueRule, TransactionManager tm_ = null)
		{
			RepairPutIssueRuleByPKData(detailID, issueRule, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutIssueRuleByPKAsync(string detailID, int? issueRule, TransactionManager tm_ = null)
		{
			RepairPutIssueRuleByPKData(detailID, issueRule, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutIssueRuleByPKData(string detailID, int? issueRule, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `IssueRule` = @IssueRule  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@IssueRule", issueRule.HasValue ? issueRule.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "issueRule">发放规则,0-未知 1-固定金额 2-按权重 3-随机抽取</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIssueRule(int? issueRule, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IssueRule` = @IssueRule";
			var parameter_ = Database.CreateInParameter("@IssueRule", issueRule.HasValue ? issueRule.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutIssueRuleAsync(int? issueRule, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IssueRule` = @IssueRule";
			var parameter_ = Database.CreateInParameter("@IssueRule", issueRule.HasValue ? issueRule.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutIssueRule
		#region PutConditionExpr
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID">明细ID</param>
		/// /// <param name = "conditionExpr">奖励条件表达式, 有值才会执行规则,没有值则在对应action中进行处理</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutConditionExprByPK(string detailID, string conditionExpr, TransactionManager tm_ = null)
		{
			RepairPutConditionExprByPKData(detailID, conditionExpr, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutConditionExprByPKAsync(string detailID, string conditionExpr, TransactionManager tm_ = null)
		{
			RepairPutConditionExprByPKData(detailID, conditionExpr, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutConditionExprByPKData(string detailID, string conditionExpr, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ConditionExpr` = @ConditionExpr  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConditionExpr", conditionExpr != null ? conditionExpr : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "conditionExpr">奖励条件表达式, 有值才会执行规则,没有值则在对应action中进行处理</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutConditionExpr(string conditionExpr, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ConditionExpr` = @ConditionExpr";
			var parameter_ = Database.CreateInParameter("@ConditionExpr", conditionExpr != null ? conditionExpr : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutConditionExprAsync(string conditionExpr, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ConditionExpr` = @ConditionExpr";
			var parameter_ = Database.CreateInParameter("@ConditionExpr", conditionExpr != null ? conditionExpr : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutConditionExpr
		#region PutRewardAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID">明细ID</param>
		/// /// <param name = "rewardAmount">奖励的金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRewardAmountByPK(string detailID, long rewardAmount, TransactionManager tm_ = null)
		{
			RepairPutRewardAmountByPKData(detailID, rewardAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRewardAmountByPKAsync(string detailID, long rewardAmount, TransactionManager tm_ = null)
		{
			RepairPutRewardAmountByPKData(detailID, rewardAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRewardAmountByPKData(string detailID, long rewardAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RewardAmount` = @RewardAmount  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RewardAmount", rewardAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "rewardAmount">奖励的金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRewardAmount(long rewardAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RewardAmount` = @RewardAmount";
			var parameter_ = Database.CreateInParameter("@RewardAmount", rewardAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutRewardAmountAsync(long rewardAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RewardAmount` = @RewardAmount";
			var parameter_ = Database.CreateInParameter("@RewardAmount", rewardAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutRewardAmount
		#region PutRewardLines
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID">明细ID</param>
		/// /// <param name = "rewardLines">奖励行json</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRewardLinesByPK(string detailID, string rewardLines, TransactionManager tm_ = null)
		{
			RepairPutRewardLinesByPKData(detailID, rewardLines, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRewardLinesByPKAsync(string detailID, string rewardLines, TransactionManager tm_ = null)
		{
			RepairPutRewardLinesByPKData(detailID, rewardLines, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRewardLinesByPKData(string detailID, string rewardLines, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RewardLines` = @RewardLines  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RewardLines", rewardLines != null ? rewardLines : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "rewardLines">奖励行json</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRewardLines(string rewardLines, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RewardLines` = @RewardLines";
			var parameter_ = Database.CreateInParameter("@RewardLines", rewardLines != null ? rewardLines : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutRewardLinesAsync(string rewardLines, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RewardLines` = @RewardLines";
			var parameter_ = Database.CreateInParameter("@RewardLines", rewardLines != null ? rewardLines : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutRewardLines
		#region PutRecDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID">明细ID</param>
		/// /// <param name = "recDate">记录日期</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(string detailID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(detailID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(string detailID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(detailID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(string detailID, DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "recDate">记录日期</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDate(DateTime recDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate";
			var parameter_ = Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutRecDateAsync(DateTime recDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate";
			var parameter_ = Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutRecDate
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Sat_task_detailEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.DetailID) == null)
			{
				Add(item, tm);
			}
			else
			{
				Put(item, tm);
				ret = false;
			}
			return ret;
		}
		public async Task<bool> SetAsync(Sat_task_detailEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.DetailID) == null)
			{
				await AddAsync(item, tm);
			}
			else
			{
				await PutAsync(item, tm);
				ret = false;
			}
			return ret;
		}
		
		#endregion // Set
		
		#region Get
		#region GetByPK
		/// <summary>
		/// 按 PK（主键） 查询
		/// </summary>
		/// /// <param name = "detailID">明细ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Sat_task_detailEO GetByPK(string detailID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(detailID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sat_task_detailEO.MapDataReader);
		}
		public async Task<Sat_task_detailEO> GetByPKAsync(string detailID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(detailID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sat_task_detailEO.MapDataReader);
		}
		private void RepairGetByPKData(string detailID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`DetailID` = @DetailID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetByUnique
		/// <summary>
		/// 按【唯一索引】查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "dayID">日期ID,针对循环类活动,通常是日期</param>
		/// /// <param name = "itemID">工具编码</param>
		/// <param name="tm_">事务管理对象</param>
		public Sat_task_detailEO GetByUserIDAndDayIDAndItemID(string userID, DateTime dayID, int itemID, TransactionManager tm_ = null)
		{
			RepairGetByUserIDAndDayIDAndItemIDData(userID, dayID, itemID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sat_task_detailEO.MapDataReader);
		}
		public async Task<Sat_task_detailEO> GetByUserIDAndDayIDAndItemIDAsync(string userID, DateTime dayID, int itemID, TransactionManager tm_ = null)
		{
			RepairGetByUserIDAndDayIDAndItemIDData(userID, dayID, itemID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sat_task_detailEO.MapDataReader);
		}
		private void RepairGetByUserIDAndDayIDAndItemIDData(string userID, DateTime dayID, int itemID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = BuildSelectSQL("`UserID` = @UserID AND `DayID` = @DayID AND `ItemID` = @ItemID", 0, null);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
			};
		}
		#endregion // GetByUnique
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 UserID（字段）
		/// </summary>
		/// /// <param name = "detailID">明细ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetUserIDByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`UserID`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<string> GetUserIDByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`UserID`", "`DetailID` = @DetailID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ItemID（字段）
		/// </summary>
		/// /// <param name = "detailID">明细ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetItemIDByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`ItemID`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<int> GetItemIDByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`ItemID`", "`DetailID` = @DetailID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 DayID（字段）
		/// </summary>
		/// /// <param name = "detailID">明细ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetDayIDByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`DayID`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<DateTime> GetDayIDByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`DayID`", "`DetailID` = @DetailID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Level（字段）
		/// </summary>
		/// /// <param name = "detailID">明细ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetLevelByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`Level`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<int> GetLevelByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`Level`", "`DetailID` = @DetailID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Deadline（字段）
		/// </summary>
		/// /// <param name = "detailID">明细ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime? GetDeadlineByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (DateTime?)GetScalar("`Deadline`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<DateTime?> GetDeadlineByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (DateTime?)await GetScalarAsync("`Deadline`", "`DetailID` = @DetailID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RewardType（字段）
		/// </summary>
		/// /// <param name = "detailID">明细ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int? GetRewardTypeByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (int?)GetScalar("`RewardType`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<int?> GetRewardTypeByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (int?)await GetScalarAsync("`RewardType`", "`DetailID` = @DetailID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 FlowMultip（字段）
		/// </summary>
		/// /// <param name = "detailID">明细ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int? GetFlowMultipByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (int?)GetScalar("`FlowMultip`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<int?> GetFlowMultipByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (int?)await GetScalarAsync("`FlowMultip`", "`DetailID` = @DetailID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 IssueRule（字段）
		/// </summary>
		/// /// <param name = "detailID">明细ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int? GetIssueRuleByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (int?)GetScalar("`IssueRule`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<int?> GetIssueRuleByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (int?)await GetScalarAsync("`IssueRule`", "`DetailID` = @DetailID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ConditionExpr（字段）
		/// </summary>
		/// /// <param name = "detailID">明细ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetConditionExprByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`ConditionExpr`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<string> GetConditionExprByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`ConditionExpr`", "`DetailID` = @DetailID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RewardAmount（字段）
		/// </summary>
		/// /// <param name = "detailID">明细ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetRewardAmountByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`RewardAmount`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<long> GetRewardAmountByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`RewardAmount`", "`DetailID` = @DetailID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RewardLines（字段）
		/// </summary>
		/// /// <param name = "detailID">明细ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetRewardLinesByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`RewardLines`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<string> GetRewardLinesByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`RewardLines`", "`DetailID` = @DetailID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "detailID">明细ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetRecDateByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`RecDate`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<DateTime> GetRecDateByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`RecDate`", "`DetailID` = @DetailID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByUserID
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByUserID(string userID)
		{
			return GetByUserID(userID, 0, string.Empty, null);
		}
		public async Task<List<Sat_task_detailEO>> GetByUserIDAsync(string userID)
		{
			return await GetByUserIDAsync(userID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByUserID(string userID, TransactionManager tm_)
		{
			return GetByUserID(userID, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_task_detailEO>> GetByUserIDAsync(string userID, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByUserID(string userID, int top_)
		{
			return GetByUserID(userID, top_, string.Empty, null);
		}
		public async Task<List<Sat_task_detailEO>> GetByUserIDAsync(string userID, int top_)
		{
			return await GetByUserIDAsync(userID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByUserID(string userID, int top_, TransactionManager tm_)
		{
			return GetByUserID(userID, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_task_detailEO>> GetByUserIDAsync(string userID, int top_, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByUserID(string userID, string sort_)
		{
			return GetByUserID(userID, 0, sort_, null);
		}
		public async Task<List<Sat_task_detailEO>> GetByUserIDAsync(string userID, string sort_)
		{
			return await GetByUserIDAsync(userID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByUserID(string userID, string sort_, TransactionManager tm_)
		{
			return GetByUserID(userID, 0, sort_, tm_);
		}
		public async Task<List<Sat_task_detailEO>> GetByUserIDAsync(string userID, string sort_, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByUserID(string userID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserID` = @UserID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_task_detailEO.MapDataReader);
		}
		public async Task<List<Sat_task_detailEO>> GetByUserIDAsync(string userID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserID` = @UserID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_task_detailEO.MapDataReader);
		}
		#endregion // GetByUserID
		#region GetByItemID
		
		/// <summary>
		/// 按 ItemID（字段） 查询
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByItemID(int itemID)
		{
			return GetByItemID(itemID, 0, string.Empty, null);
		}
		public async Task<List<Sat_task_detailEO>> GetByItemIDAsync(int itemID)
		{
			return await GetByItemIDAsync(itemID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ItemID（字段） 查询
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByItemID(int itemID, TransactionManager tm_)
		{
			return GetByItemID(itemID, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_task_detailEO>> GetByItemIDAsync(int itemID, TransactionManager tm_)
		{
			return await GetByItemIDAsync(itemID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ItemID（字段） 查询
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByItemID(int itemID, int top_)
		{
			return GetByItemID(itemID, top_, string.Empty, null);
		}
		public async Task<List<Sat_task_detailEO>> GetByItemIDAsync(int itemID, int top_)
		{
			return await GetByItemIDAsync(itemID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ItemID（字段） 查询
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByItemID(int itemID, int top_, TransactionManager tm_)
		{
			return GetByItemID(itemID, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_task_detailEO>> GetByItemIDAsync(int itemID, int top_, TransactionManager tm_)
		{
			return await GetByItemIDAsync(itemID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ItemID（字段） 查询
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByItemID(int itemID, string sort_)
		{
			return GetByItemID(itemID, 0, sort_, null);
		}
		public async Task<List<Sat_task_detailEO>> GetByItemIDAsync(int itemID, string sort_)
		{
			return await GetByItemIDAsync(itemID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ItemID（字段） 查询
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByItemID(int itemID, string sort_, TransactionManager tm_)
		{
			return GetByItemID(itemID, 0, sort_, tm_);
		}
		public async Task<List<Sat_task_detailEO>> GetByItemIDAsync(int itemID, string sort_, TransactionManager tm_)
		{
			return await GetByItemIDAsync(itemID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ItemID（字段） 查询
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByItemID(int itemID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ItemID` = @ItemID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_task_detailEO.MapDataReader);
		}
		public async Task<List<Sat_task_detailEO>> GetByItemIDAsync(int itemID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ItemID` = @ItemID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_task_detailEO.MapDataReader);
		}
		#endregion // GetByItemID
		#region GetByDayID
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">日期ID,针对循环类活动,通常是日期</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByDayID(DateTime dayID)
		{
			return GetByDayID(dayID, 0, string.Empty, null);
		}
		public async Task<List<Sat_task_detailEO>> GetByDayIDAsync(DateTime dayID)
		{
			return await GetByDayIDAsync(dayID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">日期ID,针对循环类活动,通常是日期</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByDayID(DateTime dayID, TransactionManager tm_)
		{
			return GetByDayID(dayID, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_task_detailEO>> GetByDayIDAsync(DateTime dayID, TransactionManager tm_)
		{
			return await GetByDayIDAsync(dayID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">日期ID,针对循环类活动,通常是日期</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByDayID(DateTime dayID, int top_)
		{
			return GetByDayID(dayID, top_, string.Empty, null);
		}
		public async Task<List<Sat_task_detailEO>> GetByDayIDAsync(DateTime dayID, int top_)
		{
			return await GetByDayIDAsync(dayID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">日期ID,针对循环类活动,通常是日期</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByDayID(DateTime dayID, int top_, TransactionManager tm_)
		{
			return GetByDayID(dayID, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_task_detailEO>> GetByDayIDAsync(DateTime dayID, int top_, TransactionManager tm_)
		{
			return await GetByDayIDAsync(dayID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">日期ID,针对循环类活动,通常是日期</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByDayID(DateTime dayID, string sort_)
		{
			return GetByDayID(dayID, 0, sort_, null);
		}
		public async Task<List<Sat_task_detailEO>> GetByDayIDAsync(DateTime dayID, string sort_)
		{
			return await GetByDayIDAsync(dayID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">日期ID,针对循环类活动,通常是日期</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByDayID(DateTime dayID, string sort_, TransactionManager tm_)
		{
			return GetByDayID(dayID, 0, sort_, tm_);
		}
		public async Task<List<Sat_task_detailEO>> GetByDayIDAsync(DateTime dayID, string sort_, TransactionManager tm_)
		{
			return await GetByDayIDAsync(dayID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">日期ID,针对循环类活动,通常是日期</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByDayID(DateTime dayID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DayID` = @DayID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_task_detailEO.MapDataReader);
		}
		public async Task<List<Sat_task_detailEO>> GetByDayIDAsync(DateTime dayID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DayID` = @DayID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_task_detailEO.MapDataReader);
		}
		#endregion // GetByDayID
		#region GetByLevel
		
		/// <summary>
		/// 按 Level（字段） 查询
		/// </summary>
		/// /// <param name = "level">等级</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByLevel(int level)
		{
			return GetByLevel(level, 0, string.Empty, null);
		}
		public async Task<List<Sat_task_detailEO>> GetByLevelAsync(int level)
		{
			return await GetByLevelAsync(level, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Level（字段） 查询
		/// </summary>
		/// /// <param name = "level">等级</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByLevel(int level, TransactionManager tm_)
		{
			return GetByLevel(level, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_task_detailEO>> GetByLevelAsync(int level, TransactionManager tm_)
		{
			return await GetByLevelAsync(level, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Level（字段） 查询
		/// </summary>
		/// /// <param name = "level">等级</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByLevel(int level, int top_)
		{
			return GetByLevel(level, top_, string.Empty, null);
		}
		public async Task<List<Sat_task_detailEO>> GetByLevelAsync(int level, int top_)
		{
			return await GetByLevelAsync(level, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Level（字段） 查询
		/// </summary>
		/// /// <param name = "level">等级</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByLevel(int level, int top_, TransactionManager tm_)
		{
			return GetByLevel(level, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_task_detailEO>> GetByLevelAsync(int level, int top_, TransactionManager tm_)
		{
			return await GetByLevelAsync(level, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Level（字段） 查询
		/// </summary>
		/// /// <param name = "level">等级</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByLevel(int level, string sort_)
		{
			return GetByLevel(level, 0, sort_, null);
		}
		public async Task<List<Sat_task_detailEO>> GetByLevelAsync(int level, string sort_)
		{
			return await GetByLevelAsync(level, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Level（字段） 查询
		/// </summary>
		/// /// <param name = "level">等级</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByLevel(int level, string sort_, TransactionManager tm_)
		{
			return GetByLevel(level, 0, sort_, tm_);
		}
		public async Task<List<Sat_task_detailEO>> GetByLevelAsync(int level, string sort_, TransactionManager tm_)
		{
			return await GetByLevelAsync(level, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Level（字段） 查询
		/// </summary>
		/// /// <param name = "level">等级</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByLevel(int level, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Level` = @Level", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Level", level, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_task_detailEO.MapDataReader);
		}
		public async Task<List<Sat_task_detailEO>> GetByLevelAsync(int level, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Level` = @Level", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Level", level, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_task_detailEO.MapDataReader);
		}
		#endregion // GetByLevel
		#region GetByDeadline
		
		/// <summary>
		/// 按 Deadline（字段） 查询
		/// </summary>
		/// /// <param name = "deadline">失效日期, 不包含此日期 utc格式</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByDeadline(DateTime? deadline)
		{
			return GetByDeadline(deadline, 0, string.Empty, null);
		}
		public async Task<List<Sat_task_detailEO>> GetByDeadlineAsync(DateTime? deadline)
		{
			return await GetByDeadlineAsync(deadline, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Deadline（字段） 查询
		/// </summary>
		/// /// <param name = "deadline">失效日期, 不包含此日期 utc格式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByDeadline(DateTime? deadline, TransactionManager tm_)
		{
			return GetByDeadline(deadline, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_task_detailEO>> GetByDeadlineAsync(DateTime? deadline, TransactionManager tm_)
		{
			return await GetByDeadlineAsync(deadline, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Deadline（字段） 查询
		/// </summary>
		/// /// <param name = "deadline">失效日期, 不包含此日期 utc格式</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByDeadline(DateTime? deadline, int top_)
		{
			return GetByDeadline(deadline, top_, string.Empty, null);
		}
		public async Task<List<Sat_task_detailEO>> GetByDeadlineAsync(DateTime? deadline, int top_)
		{
			return await GetByDeadlineAsync(deadline, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Deadline（字段） 查询
		/// </summary>
		/// /// <param name = "deadline">失效日期, 不包含此日期 utc格式</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByDeadline(DateTime? deadline, int top_, TransactionManager tm_)
		{
			return GetByDeadline(deadline, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_task_detailEO>> GetByDeadlineAsync(DateTime? deadline, int top_, TransactionManager tm_)
		{
			return await GetByDeadlineAsync(deadline, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Deadline（字段） 查询
		/// </summary>
		/// /// <param name = "deadline">失效日期, 不包含此日期 utc格式</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByDeadline(DateTime? deadline, string sort_)
		{
			return GetByDeadline(deadline, 0, sort_, null);
		}
		public async Task<List<Sat_task_detailEO>> GetByDeadlineAsync(DateTime? deadline, string sort_)
		{
			return await GetByDeadlineAsync(deadline, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Deadline（字段） 查询
		/// </summary>
		/// /// <param name = "deadline">失效日期, 不包含此日期 utc格式</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByDeadline(DateTime? deadline, string sort_, TransactionManager tm_)
		{
			return GetByDeadline(deadline, 0, sort_, tm_);
		}
		public async Task<List<Sat_task_detailEO>> GetByDeadlineAsync(DateTime? deadline, string sort_, TransactionManager tm_)
		{
			return await GetByDeadlineAsync(deadline, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Deadline（字段） 查询
		/// </summary>
		/// /// <param name = "deadline">失效日期, 不包含此日期 utc格式</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByDeadline(DateTime? deadline, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(deadline.HasValue ? "`Deadline` = @Deadline" : "`Deadline` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (deadline.HasValue)
				paras_.Add(Database.CreateInParameter("@Deadline", deadline.Value, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_task_detailEO.MapDataReader);
		}
		public async Task<List<Sat_task_detailEO>> GetByDeadlineAsync(DateTime? deadline, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(deadline.HasValue ? "`Deadline` = @Deadline" : "`Deadline` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (deadline.HasValue)
				paras_.Add(Database.CreateInParameter("@Deadline", deadline.Value, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_task_detailEO.MapDataReader);
		}
		#endregion // GetByDeadline
		#region GetByRewardType
		
		/// <summary>
		/// 按 RewardType（字段） 查询
		/// </summary>
		/// /// <param name = "rewardType">奖励类型 0-未知 1-Bonus 2-真金</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByRewardType(int? rewardType)
		{
			return GetByRewardType(rewardType, 0, string.Empty, null);
		}
		public async Task<List<Sat_task_detailEO>> GetByRewardTypeAsync(int? rewardType)
		{
			return await GetByRewardTypeAsync(rewardType, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RewardType（字段） 查询
		/// </summary>
		/// /// <param name = "rewardType">奖励类型 0-未知 1-Bonus 2-真金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByRewardType(int? rewardType, TransactionManager tm_)
		{
			return GetByRewardType(rewardType, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_task_detailEO>> GetByRewardTypeAsync(int? rewardType, TransactionManager tm_)
		{
			return await GetByRewardTypeAsync(rewardType, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RewardType（字段） 查询
		/// </summary>
		/// /// <param name = "rewardType">奖励类型 0-未知 1-Bonus 2-真金</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByRewardType(int? rewardType, int top_)
		{
			return GetByRewardType(rewardType, top_, string.Empty, null);
		}
		public async Task<List<Sat_task_detailEO>> GetByRewardTypeAsync(int? rewardType, int top_)
		{
			return await GetByRewardTypeAsync(rewardType, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RewardType（字段） 查询
		/// </summary>
		/// /// <param name = "rewardType">奖励类型 0-未知 1-Bonus 2-真金</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByRewardType(int? rewardType, int top_, TransactionManager tm_)
		{
			return GetByRewardType(rewardType, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_task_detailEO>> GetByRewardTypeAsync(int? rewardType, int top_, TransactionManager tm_)
		{
			return await GetByRewardTypeAsync(rewardType, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RewardType（字段） 查询
		/// </summary>
		/// /// <param name = "rewardType">奖励类型 0-未知 1-Bonus 2-真金</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByRewardType(int? rewardType, string sort_)
		{
			return GetByRewardType(rewardType, 0, sort_, null);
		}
		public async Task<List<Sat_task_detailEO>> GetByRewardTypeAsync(int? rewardType, string sort_)
		{
			return await GetByRewardTypeAsync(rewardType, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RewardType（字段） 查询
		/// </summary>
		/// /// <param name = "rewardType">奖励类型 0-未知 1-Bonus 2-真金</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByRewardType(int? rewardType, string sort_, TransactionManager tm_)
		{
			return GetByRewardType(rewardType, 0, sort_, tm_);
		}
		public async Task<List<Sat_task_detailEO>> GetByRewardTypeAsync(int? rewardType, string sort_, TransactionManager tm_)
		{
			return await GetByRewardTypeAsync(rewardType, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RewardType（字段） 查询
		/// </summary>
		/// /// <param name = "rewardType">奖励类型 0-未知 1-Bonus 2-真金</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByRewardType(int? rewardType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(rewardType.HasValue ? "`RewardType` = @RewardType" : "`RewardType` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (rewardType.HasValue)
				paras_.Add(Database.CreateInParameter("@RewardType", rewardType.Value, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_task_detailEO.MapDataReader);
		}
		public async Task<List<Sat_task_detailEO>> GetByRewardTypeAsync(int? rewardType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(rewardType.HasValue ? "`RewardType` = @RewardType" : "`RewardType` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (rewardType.HasValue)
				paras_.Add(Database.CreateInParameter("@RewardType", rewardType.Value, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_task_detailEO.MapDataReader);
		}
		#endregion // GetByRewardType
		#region GetByFlowMultip
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">流水倍数</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByFlowMultip(int? flowMultip)
		{
			return GetByFlowMultip(flowMultip, 0, string.Empty, null);
		}
		public async Task<List<Sat_task_detailEO>> GetByFlowMultipAsync(int? flowMultip)
		{
			return await GetByFlowMultipAsync(flowMultip, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">流水倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByFlowMultip(int? flowMultip, TransactionManager tm_)
		{
			return GetByFlowMultip(flowMultip, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_task_detailEO>> GetByFlowMultipAsync(int? flowMultip, TransactionManager tm_)
		{
			return await GetByFlowMultipAsync(flowMultip, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">流水倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByFlowMultip(int? flowMultip, int top_)
		{
			return GetByFlowMultip(flowMultip, top_, string.Empty, null);
		}
		public async Task<List<Sat_task_detailEO>> GetByFlowMultipAsync(int? flowMultip, int top_)
		{
			return await GetByFlowMultipAsync(flowMultip, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">流水倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByFlowMultip(int? flowMultip, int top_, TransactionManager tm_)
		{
			return GetByFlowMultip(flowMultip, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_task_detailEO>> GetByFlowMultipAsync(int? flowMultip, int top_, TransactionManager tm_)
		{
			return await GetByFlowMultipAsync(flowMultip, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">流水倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByFlowMultip(int? flowMultip, string sort_)
		{
			return GetByFlowMultip(flowMultip, 0, sort_, null);
		}
		public async Task<List<Sat_task_detailEO>> GetByFlowMultipAsync(int? flowMultip, string sort_)
		{
			return await GetByFlowMultipAsync(flowMultip, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">流水倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByFlowMultip(int? flowMultip, string sort_, TransactionManager tm_)
		{
			return GetByFlowMultip(flowMultip, 0, sort_, tm_);
		}
		public async Task<List<Sat_task_detailEO>> GetByFlowMultipAsync(int? flowMultip, string sort_, TransactionManager tm_)
		{
			return await GetByFlowMultipAsync(flowMultip, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">流水倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByFlowMultip(int? flowMultip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(flowMultip.HasValue ? "`FlowMultip` = @FlowMultip" : "`FlowMultip` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (flowMultip.HasValue)
				paras_.Add(Database.CreateInParameter("@FlowMultip", flowMultip.Value, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_task_detailEO.MapDataReader);
		}
		public async Task<List<Sat_task_detailEO>> GetByFlowMultipAsync(int? flowMultip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(flowMultip.HasValue ? "`FlowMultip` = @FlowMultip" : "`FlowMultip` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (flowMultip.HasValue)
				paras_.Add(Database.CreateInParameter("@FlowMultip", flowMultip.Value, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_task_detailEO.MapDataReader);
		}
		#endregion // GetByFlowMultip
		#region GetByIssueRule
		
		/// <summary>
		/// 按 IssueRule（字段） 查询
		/// </summary>
		/// /// <param name = "issueRule">发放规则,0-未知 1-固定金额 2-按权重 3-随机抽取</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByIssueRule(int? issueRule)
		{
			return GetByIssueRule(issueRule, 0, string.Empty, null);
		}
		public async Task<List<Sat_task_detailEO>> GetByIssueRuleAsync(int? issueRule)
		{
			return await GetByIssueRuleAsync(issueRule, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IssueRule（字段） 查询
		/// </summary>
		/// /// <param name = "issueRule">发放规则,0-未知 1-固定金额 2-按权重 3-随机抽取</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByIssueRule(int? issueRule, TransactionManager tm_)
		{
			return GetByIssueRule(issueRule, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_task_detailEO>> GetByIssueRuleAsync(int? issueRule, TransactionManager tm_)
		{
			return await GetByIssueRuleAsync(issueRule, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IssueRule（字段） 查询
		/// </summary>
		/// /// <param name = "issueRule">发放规则,0-未知 1-固定金额 2-按权重 3-随机抽取</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByIssueRule(int? issueRule, int top_)
		{
			return GetByIssueRule(issueRule, top_, string.Empty, null);
		}
		public async Task<List<Sat_task_detailEO>> GetByIssueRuleAsync(int? issueRule, int top_)
		{
			return await GetByIssueRuleAsync(issueRule, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IssueRule（字段） 查询
		/// </summary>
		/// /// <param name = "issueRule">发放规则,0-未知 1-固定金额 2-按权重 3-随机抽取</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByIssueRule(int? issueRule, int top_, TransactionManager tm_)
		{
			return GetByIssueRule(issueRule, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_task_detailEO>> GetByIssueRuleAsync(int? issueRule, int top_, TransactionManager tm_)
		{
			return await GetByIssueRuleAsync(issueRule, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IssueRule（字段） 查询
		/// </summary>
		/// /// <param name = "issueRule">发放规则,0-未知 1-固定金额 2-按权重 3-随机抽取</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByIssueRule(int? issueRule, string sort_)
		{
			return GetByIssueRule(issueRule, 0, sort_, null);
		}
		public async Task<List<Sat_task_detailEO>> GetByIssueRuleAsync(int? issueRule, string sort_)
		{
			return await GetByIssueRuleAsync(issueRule, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 IssueRule（字段） 查询
		/// </summary>
		/// /// <param name = "issueRule">发放规则,0-未知 1-固定金额 2-按权重 3-随机抽取</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByIssueRule(int? issueRule, string sort_, TransactionManager tm_)
		{
			return GetByIssueRule(issueRule, 0, sort_, tm_);
		}
		public async Task<List<Sat_task_detailEO>> GetByIssueRuleAsync(int? issueRule, string sort_, TransactionManager tm_)
		{
			return await GetByIssueRuleAsync(issueRule, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 IssueRule（字段） 查询
		/// </summary>
		/// /// <param name = "issueRule">发放规则,0-未知 1-固定金额 2-按权重 3-随机抽取</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByIssueRule(int? issueRule, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(issueRule.HasValue ? "`IssueRule` = @IssueRule" : "`IssueRule` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (issueRule.HasValue)
				paras_.Add(Database.CreateInParameter("@IssueRule", issueRule.Value, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_task_detailEO.MapDataReader);
		}
		public async Task<List<Sat_task_detailEO>> GetByIssueRuleAsync(int? issueRule, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(issueRule.HasValue ? "`IssueRule` = @IssueRule" : "`IssueRule` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (issueRule.HasValue)
				paras_.Add(Database.CreateInParameter("@IssueRule", issueRule.Value, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_task_detailEO.MapDataReader);
		}
		#endregion // GetByIssueRule
		#region GetByConditionExpr
		
		/// <summary>
		/// 按 ConditionExpr（字段） 查询
		/// </summary>
		/// /// <param name = "conditionExpr">奖励条件表达式, 有值才会执行规则,没有值则在对应action中进行处理</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByConditionExpr(string conditionExpr)
		{
			return GetByConditionExpr(conditionExpr, 0, string.Empty, null);
		}
		public async Task<List<Sat_task_detailEO>> GetByConditionExprAsync(string conditionExpr)
		{
			return await GetByConditionExprAsync(conditionExpr, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ConditionExpr（字段） 查询
		/// </summary>
		/// /// <param name = "conditionExpr">奖励条件表达式, 有值才会执行规则,没有值则在对应action中进行处理</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByConditionExpr(string conditionExpr, TransactionManager tm_)
		{
			return GetByConditionExpr(conditionExpr, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_task_detailEO>> GetByConditionExprAsync(string conditionExpr, TransactionManager tm_)
		{
			return await GetByConditionExprAsync(conditionExpr, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ConditionExpr（字段） 查询
		/// </summary>
		/// /// <param name = "conditionExpr">奖励条件表达式, 有值才会执行规则,没有值则在对应action中进行处理</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByConditionExpr(string conditionExpr, int top_)
		{
			return GetByConditionExpr(conditionExpr, top_, string.Empty, null);
		}
		public async Task<List<Sat_task_detailEO>> GetByConditionExprAsync(string conditionExpr, int top_)
		{
			return await GetByConditionExprAsync(conditionExpr, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ConditionExpr（字段） 查询
		/// </summary>
		/// /// <param name = "conditionExpr">奖励条件表达式, 有值才会执行规则,没有值则在对应action中进行处理</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByConditionExpr(string conditionExpr, int top_, TransactionManager tm_)
		{
			return GetByConditionExpr(conditionExpr, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_task_detailEO>> GetByConditionExprAsync(string conditionExpr, int top_, TransactionManager tm_)
		{
			return await GetByConditionExprAsync(conditionExpr, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ConditionExpr（字段） 查询
		/// </summary>
		/// /// <param name = "conditionExpr">奖励条件表达式, 有值才会执行规则,没有值则在对应action中进行处理</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByConditionExpr(string conditionExpr, string sort_)
		{
			return GetByConditionExpr(conditionExpr, 0, sort_, null);
		}
		public async Task<List<Sat_task_detailEO>> GetByConditionExprAsync(string conditionExpr, string sort_)
		{
			return await GetByConditionExprAsync(conditionExpr, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ConditionExpr（字段） 查询
		/// </summary>
		/// /// <param name = "conditionExpr">奖励条件表达式, 有值才会执行规则,没有值则在对应action中进行处理</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByConditionExpr(string conditionExpr, string sort_, TransactionManager tm_)
		{
			return GetByConditionExpr(conditionExpr, 0, sort_, tm_);
		}
		public async Task<List<Sat_task_detailEO>> GetByConditionExprAsync(string conditionExpr, string sort_, TransactionManager tm_)
		{
			return await GetByConditionExprAsync(conditionExpr, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ConditionExpr（字段） 查询
		/// </summary>
		/// /// <param name = "conditionExpr">奖励条件表达式, 有值才会执行规则,没有值则在对应action中进行处理</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByConditionExpr(string conditionExpr, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(conditionExpr != null ? "`ConditionExpr` = @ConditionExpr" : "`ConditionExpr` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (conditionExpr != null)
				paras_.Add(Database.CreateInParameter("@ConditionExpr", conditionExpr, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_task_detailEO.MapDataReader);
		}
		public async Task<List<Sat_task_detailEO>> GetByConditionExprAsync(string conditionExpr, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(conditionExpr != null ? "`ConditionExpr` = @ConditionExpr" : "`ConditionExpr` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (conditionExpr != null)
				paras_.Add(Database.CreateInParameter("@ConditionExpr", conditionExpr, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_task_detailEO.MapDataReader);
		}
		#endregion // GetByConditionExpr
		#region GetByRewardAmount
		
		/// <summary>
		/// 按 RewardAmount（字段） 查询
		/// </summary>
		/// /// <param name = "rewardAmount">奖励的金额</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByRewardAmount(long rewardAmount)
		{
			return GetByRewardAmount(rewardAmount, 0, string.Empty, null);
		}
		public async Task<List<Sat_task_detailEO>> GetByRewardAmountAsync(long rewardAmount)
		{
			return await GetByRewardAmountAsync(rewardAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RewardAmount（字段） 查询
		/// </summary>
		/// /// <param name = "rewardAmount">奖励的金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByRewardAmount(long rewardAmount, TransactionManager tm_)
		{
			return GetByRewardAmount(rewardAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_task_detailEO>> GetByRewardAmountAsync(long rewardAmount, TransactionManager tm_)
		{
			return await GetByRewardAmountAsync(rewardAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RewardAmount（字段） 查询
		/// </summary>
		/// /// <param name = "rewardAmount">奖励的金额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByRewardAmount(long rewardAmount, int top_)
		{
			return GetByRewardAmount(rewardAmount, top_, string.Empty, null);
		}
		public async Task<List<Sat_task_detailEO>> GetByRewardAmountAsync(long rewardAmount, int top_)
		{
			return await GetByRewardAmountAsync(rewardAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RewardAmount（字段） 查询
		/// </summary>
		/// /// <param name = "rewardAmount">奖励的金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByRewardAmount(long rewardAmount, int top_, TransactionManager tm_)
		{
			return GetByRewardAmount(rewardAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_task_detailEO>> GetByRewardAmountAsync(long rewardAmount, int top_, TransactionManager tm_)
		{
			return await GetByRewardAmountAsync(rewardAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RewardAmount（字段） 查询
		/// </summary>
		/// /// <param name = "rewardAmount">奖励的金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByRewardAmount(long rewardAmount, string sort_)
		{
			return GetByRewardAmount(rewardAmount, 0, sort_, null);
		}
		public async Task<List<Sat_task_detailEO>> GetByRewardAmountAsync(long rewardAmount, string sort_)
		{
			return await GetByRewardAmountAsync(rewardAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RewardAmount（字段） 查询
		/// </summary>
		/// /// <param name = "rewardAmount">奖励的金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByRewardAmount(long rewardAmount, string sort_, TransactionManager tm_)
		{
			return GetByRewardAmount(rewardAmount, 0, sort_, tm_);
		}
		public async Task<List<Sat_task_detailEO>> GetByRewardAmountAsync(long rewardAmount, string sort_, TransactionManager tm_)
		{
			return await GetByRewardAmountAsync(rewardAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RewardAmount（字段） 查询
		/// </summary>
		/// /// <param name = "rewardAmount">奖励的金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByRewardAmount(long rewardAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RewardAmount` = @RewardAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RewardAmount", rewardAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_task_detailEO.MapDataReader);
		}
		public async Task<List<Sat_task_detailEO>> GetByRewardAmountAsync(long rewardAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RewardAmount` = @RewardAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RewardAmount", rewardAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_task_detailEO.MapDataReader);
		}
		#endregion // GetByRewardAmount
		#region GetByRewardLines
		
		/// <summary>
		/// 按 RewardLines（字段） 查询
		/// </summary>
		/// /// <param name = "rewardLines">奖励行json</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByRewardLines(string rewardLines)
		{
			return GetByRewardLines(rewardLines, 0, string.Empty, null);
		}
		public async Task<List<Sat_task_detailEO>> GetByRewardLinesAsync(string rewardLines)
		{
			return await GetByRewardLinesAsync(rewardLines, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RewardLines（字段） 查询
		/// </summary>
		/// /// <param name = "rewardLines">奖励行json</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByRewardLines(string rewardLines, TransactionManager tm_)
		{
			return GetByRewardLines(rewardLines, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_task_detailEO>> GetByRewardLinesAsync(string rewardLines, TransactionManager tm_)
		{
			return await GetByRewardLinesAsync(rewardLines, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RewardLines（字段） 查询
		/// </summary>
		/// /// <param name = "rewardLines">奖励行json</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByRewardLines(string rewardLines, int top_)
		{
			return GetByRewardLines(rewardLines, top_, string.Empty, null);
		}
		public async Task<List<Sat_task_detailEO>> GetByRewardLinesAsync(string rewardLines, int top_)
		{
			return await GetByRewardLinesAsync(rewardLines, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RewardLines（字段） 查询
		/// </summary>
		/// /// <param name = "rewardLines">奖励行json</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByRewardLines(string rewardLines, int top_, TransactionManager tm_)
		{
			return GetByRewardLines(rewardLines, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_task_detailEO>> GetByRewardLinesAsync(string rewardLines, int top_, TransactionManager tm_)
		{
			return await GetByRewardLinesAsync(rewardLines, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RewardLines（字段） 查询
		/// </summary>
		/// /// <param name = "rewardLines">奖励行json</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByRewardLines(string rewardLines, string sort_)
		{
			return GetByRewardLines(rewardLines, 0, sort_, null);
		}
		public async Task<List<Sat_task_detailEO>> GetByRewardLinesAsync(string rewardLines, string sort_)
		{
			return await GetByRewardLinesAsync(rewardLines, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RewardLines（字段） 查询
		/// </summary>
		/// /// <param name = "rewardLines">奖励行json</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByRewardLines(string rewardLines, string sort_, TransactionManager tm_)
		{
			return GetByRewardLines(rewardLines, 0, sort_, tm_);
		}
		public async Task<List<Sat_task_detailEO>> GetByRewardLinesAsync(string rewardLines, string sort_, TransactionManager tm_)
		{
			return await GetByRewardLinesAsync(rewardLines, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RewardLines（字段） 查询
		/// </summary>
		/// /// <param name = "rewardLines">奖励行json</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByRewardLines(string rewardLines, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(rewardLines != null ? "`RewardLines` = @RewardLines" : "`RewardLines` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (rewardLines != null)
				paras_.Add(Database.CreateInParameter("@RewardLines", rewardLines, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_task_detailEO.MapDataReader);
		}
		public async Task<List<Sat_task_detailEO>> GetByRewardLinesAsync(string rewardLines, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(rewardLines != null ? "`RewardLines` = @RewardLines" : "`RewardLines` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (rewardLines != null)
				paras_.Add(Database.CreateInParameter("@RewardLines", rewardLines, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_task_detailEO.MapDataReader);
		}
		#endregion // GetByRewardLines
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录日期</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<Sat_task_detailEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录日期</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_task_detailEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录日期</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<Sat_task_detailEO>> GetByRecDateAsync(DateTime recDate, int top_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录日期</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_task_detailEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录日期</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<Sat_task_detailEO>> GetByRecDateAsync(DateTime recDate, string sort_)
		{
			return await GetByRecDateAsync(recDate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录日期</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<Sat_task_detailEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录日期</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_detailEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_task_detailEO.MapDataReader);
		}
		public async Task<List<Sat_task_detailEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_task_detailEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
