/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * AiUo代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/AiUo
 * 文档生成时间：2023-10-24 18: 05:00
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
	/// 
	/// 【表 sm_message_reward 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Sm_message_rewardEO : IRowMapper<Sm_message_rewardEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Sm_message_rewardEO()
		{
			this.Amount = 0.00m;
			this.LeastPayAmount = 0;
			this.FlowMultip = 0.00f;
			this.RecDate = DateTime.Now;
			this.RewardType = 0;
			this.ActivityType = 0;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private string _originalRewardID;
		/// <summary>
		/// 【数据库中的原始主键 RewardID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalRewardID
		{
			get { return _originalRewardID; }
			set { HasOriginal = true; _originalRewardID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "RewardID", RewardID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 编号
		/// 【主键 varchar(36)】
		/// </summary>
		[DataMember(Order = 1)]
		public string RewardID { get; set; }
		/// <summary>
		/// 奖励金额
		/// 【字段 decimal(10,2)】
		/// </summary>
		[DataMember(Order = 2)]
		public decimal Amount { get; set; }
		/// <summary>
		/// 送赠金的最少充值金额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 3)]
		public long LeastPayAmount { get; set; }
		/// <summary>
		/// 赠金提现所需要的流水倍数
		/// 【字段 float(10,2)】
		/// </summary>
		[DataMember(Order = 4)]
		public float FlowMultip { get; set; }
		/// <summary>
		/// 创建时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 5)]
		public DateTime RecDate { get; set; }
		/// <summary>
		/// 奖励类型1后台发送2活动发送
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 6)]
		public int RewardType { get; set; }
		/// <summary>
		/// 活动类型
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 7)]
		public int ActivityType { get; set; }
		/// <summary>
		/// 活动编号
		/// 【字段 varchar(36)】
		/// </summary>
		[DataMember(Order = 8)]
		public string ActivityID { get; set; }
		/// <summary>
		/// source类型
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 9)]
		public int? SourceType { get; set; }
		/// <summary>
		/// source表名
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 10)]
		public string SourceTable { get; set; }
		/// <summary>
		/// source表ID
		/// 【字段 varchar(36)】
		/// </summary>
		[DataMember(Order = 11)]
		public string SourceId { get; set; }
		/// <summary>
		/// 1bouns2真金
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 12)]
		public int? AmountType { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Sm_message_rewardEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Sm_message_rewardEO MapDataReader(IDataReader reader)
		{
		    Sm_message_rewardEO ret = new Sm_message_rewardEO();
			ret.RewardID = reader.ToString("RewardID");
			ret.OriginalRewardID = ret.RewardID;
			ret.Amount = reader.ToDecimal("Amount");
			ret.LeastPayAmount = reader.ToInt64("LeastPayAmount");
			ret.FlowMultip = reader.ToSingle("FlowMultip");
			ret.RecDate = reader.ToDateTime("RecDate");
			ret.RewardType = reader.ToInt32("RewardType");
			ret.ActivityType = reader.ToInt32("ActivityType");
			ret.ActivityID = reader.ToString("ActivityID");
			ret.SourceType = reader.ToInt32N("SourceType");
			ret.SourceTable = reader.ToString("SourceTable");
			ret.SourceId = reader.ToString("SourceId");
			ret.AmountType = reader.ToInt32N("AmountType");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 
	/// 【表 sm_message_reward 的操作类】
	/// </summary>
	[Obsolete]
	public class Sm_message_rewardMO : MySqlTableMO<Sm_message_rewardEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`sm_message_reward`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Sm_message_rewardMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Sm_message_rewardMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Sm_message_rewardMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Sm_message_rewardEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Sm_message_rewardEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Sm_message_rewardEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`RewardID`, `Amount`, `LeastPayAmount`, `FlowMultip`, `RecDate`, `RewardType`, `ActivityType`, `ActivityID`, `SourceType`, `SourceTable`, `SourceId`, `AmountType`) VALUE (@RewardID, @Amount, @LeastPayAmount, @FlowMultip, @RecDate, @RewardType, @ActivityType, @ActivityID, @SourceType, @SourceTable, @SourceId, @AmountType);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RewardID", item.RewardID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Amount", item.Amount, MySqlDbType.NewDecimal),
				Database.CreateInParameter("@LeastPayAmount", item.LeastPayAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@FlowMultip", item.FlowMultip, MySqlDbType.Float),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@RewardType", item.RewardType, MySqlDbType.Int32),
				Database.CreateInParameter("@ActivityType", item.ActivityType, MySqlDbType.Int32),
				Database.CreateInParameter("@ActivityID", item.ActivityID != null ? item.ActivityID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@SourceType", item.SourceType.HasValue ? item.SourceType.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@SourceTable", item.SourceTable != null ? item.SourceTable : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@SourceId", item.SourceId != null ? item.SourceId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@AmountType", item.AmountType.HasValue ? item.AmountType.Value : (object)DBNull.Value, MySqlDbType.Int32),
			};
		}
		public int AddByBatch(IEnumerable<Sm_message_rewardEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Sm_message_rewardEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sm_message_rewardEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`RewardID`, `Amount`, `LeastPayAmount`, `FlowMultip`, `RecDate`, `RewardType`, `ActivityType`, `ActivityID`, `SourceType`, `SourceTable`, `SourceId`, `AmountType`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.RewardID}',{item.Amount},{item.LeastPayAmount},{item.FlowMultip},'{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}',{item.RewardType},{item.ActivityType},'{item.ActivityID}',{item.SourceType?.ToString()??null},'{item.SourceTable}','{item.SourceId}',{item.AmountType?.ToString()??null}),");
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
		/// /// <param name = "rewardID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string rewardID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(rewardID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string rewardID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(rewardID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string rewardID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `RewardID` = @RewardID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RewardID", rewardID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Sm_message_rewardEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.RewardID, tm_);
		}
		public async Task<int> RemoveAsync(Sm_message_rewardEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.RewardID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "amount">奖励金额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByAmount(decimal amount, TransactionManager tm_ = null)
		{
			RepairRemoveByAmountData(amount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByAmountAsync(decimal amount, TransactionManager tm_ = null)
		{
			RepairRemoveByAmountData(amount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByAmountData(decimal amount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Amount` = @Amount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Amount", amount, MySqlDbType.NewDecimal));
		}
		#endregion // RemoveByAmount
		#region RemoveByLeastPayAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "leastPayAmount">送赠金的最少充值金额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByLeastPayAmount(long leastPayAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByLeastPayAmountData(leastPayAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByLeastPayAmountAsync(long leastPayAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByLeastPayAmountData(leastPayAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByLeastPayAmountData(long leastPayAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `LeastPayAmount` = @LeastPayAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LeastPayAmount", leastPayAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByLeastPayAmount
		#region RemoveByFlowMultip
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "flowMultip">赠金提现所需要的流水倍数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByFlowMultip(float flowMultip, TransactionManager tm_ = null)
		{
			RepairRemoveByFlowMultipData(flowMultip, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByFlowMultipAsync(float flowMultip, TransactionManager tm_ = null)
		{
			RepairRemoveByFlowMultipData(flowMultip, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByFlowMultipData(float flowMultip, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `FlowMultip` = @FlowMultip";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FlowMultip", flowMultip, MySqlDbType.Float));
		}
		#endregion // RemoveByFlowMultip
		#region RemoveByRecDate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "recDate">创建时间</param>
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
		#region RemoveByRewardType
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "rewardType">奖励类型1后台发送2活动发送</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByRewardType(int rewardType, TransactionManager tm_ = null)
		{
			RepairRemoveByRewardTypeData(rewardType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByRewardTypeAsync(int rewardType, TransactionManager tm_ = null)
		{
			RepairRemoveByRewardTypeData(rewardType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByRewardTypeData(int rewardType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `RewardType` = @RewardType";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RewardType", rewardType, MySqlDbType.Int32));
		}
		#endregion // RemoveByRewardType
		#region RemoveByActivityType
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "activityType">活动类型</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByActivityType(int activityType, TransactionManager tm_ = null)
		{
			RepairRemoveByActivityTypeData(activityType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByActivityTypeAsync(int activityType, TransactionManager tm_ = null)
		{
			RepairRemoveByActivityTypeData(activityType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByActivityTypeData(int activityType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `ActivityType` = @ActivityType";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ActivityType", activityType, MySqlDbType.Int32));
		}
		#endregion // RemoveByActivityType
		#region RemoveByActivityID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "activityID">活动编号</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByActivityID(string activityID, TransactionManager tm_ = null)
		{
			RepairRemoveByActivityIDData(activityID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByActivityIDAsync(string activityID, TransactionManager tm_ = null)
		{
			RepairRemoveByActivityIDData(activityID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByActivityIDData(string activityID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (activityID != null ? "`ActivityID` = @ActivityID" : "`ActivityID` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (activityID != null)
				paras_.Add(Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByActivityID
		#region RemoveBySourceType
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "sourceType">source类型</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveBySourceType(int? sourceType, TransactionManager tm_ = null)
		{
			RepairRemoveBySourceTypeData(sourceType.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveBySourceTypeAsync(int? sourceType, TransactionManager tm_ = null)
		{
			RepairRemoveBySourceTypeData(sourceType.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveBySourceTypeData(int? sourceType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (sourceType.HasValue ? "`SourceType` = @SourceType" : "`SourceType` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (sourceType.HasValue)
				paras_.Add(Database.CreateInParameter("@SourceType", sourceType.Value, MySqlDbType.Int32));
		}
		#endregion // RemoveBySourceType
		#region RemoveBySourceTable
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "sourceTable">source表名</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveBySourceTable(string sourceTable, TransactionManager tm_ = null)
		{
			RepairRemoveBySourceTableData(sourceTable, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveBySourceTableAsync(string sourceTable, TransactionManager tm_ = null)
		{
			RepairRemoveBySourceTableData(sourceTable, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveBySourceTableData(string sourceTable, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (sourceTable != null ? "`SourceTable` = @SourceTable" : "`SourceTable` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (sourceTable != null)
				paras_.Add(Database.CreateInParameter("@SourceTable", sourceTable, MySqlDbType.VarChar));
		}
		#endregion // RemoveBySourceTable
		#region RemoveBySourceId
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "sourceId">source表ID</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveBySourceId(string sourceId, TransactionManager tm_ = null)
		{
			RepairRemoveBySourceIdData(sourceId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveBySourceIdAsync(string sourceId, TransactionManager tm_ = null)
		{
			RepairRemoveBySourceIdData(sourceId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveBySourceIdData(string sourceId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (sourceId != null ? "`SourceId` = @SourceId" : "`SourceId` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (sourceId != null)
				paras_.Add(Database.CreateInParameter("@SourceId", sourceId, MySqlDbType.VarChar));
		}
		#endregion // RemoveBySourceId
		#region RemoveByAmountType
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "amountType">1bouns2真金</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByAmountType(int? amountType, TransactionManager tm_ = null)
		{
			RepairRemoveByAmountTypeData(amountType.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByAmountTypeAsync(int? amountType, TransactionManager tm_ = null)
		{
			RepairRemoveByAmountTypeData(amountType.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByAmountTypeData(int? amountType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (amountType.HasValue ? "`AmountType` = @AmountType" : "`AmountType` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (amountType.HasValue)
				paras_.Add(Database.CreateInParameter("@AmountType", amountType.Value, MySqlDbType.Int32));
		}
		#endregion // RemoveByAmountType
		#endregion // RemoveByXXX
	    
		#region RemoveByFKOrUnique
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
		public int Put(Sm_message_rewardEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Sm_message_rewardEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Sm_message_rewardEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RewardID` = @RewardID, `Amount` = @Amount, `LeastPayAmount` = @LeastPayAmount, `FlowMultip` = @FlowMultip, `RewardType` = @RewardType, `ActivityType` = @ActivityType, `ActivityID` = @ActivityID, `SourceType` = @SourceType, `SourceTable` = @SourceTable, `SourceId` = @SourceId, `AmountType` = @AmountType WHERE `RewardID` = @RewardID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RewardID", item.RewardID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Amount", item.Amount, MySqlDbType.NewDecimal),
				Database.CreateInParameter("@LeastPayAmount", item.LeastPayAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@FlowMultip", item.FlowMultip, MySqlDbType.Float),
				Database.CreateInParameter("@RewardType", item.RewardType, MySqlDbType.Int32),
				Database.CreateInParameter("@ActivityType", item.ActivityType, MySqlDbType.Int32),
				Database.CreateInParameter("@ActivityID", item.ActivityID != null ? item.ActivityID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@SourceType", item.SourceType.HasValue ? item.SourceType.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@SourceTable", item.SourceTable != null ? item.SourceTable : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@SourceId", item.SourceId != null ? item.SourceId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@AmountType", item.AmountType.HasValue ? item.AmountType.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@RewardID_Original", item.HasOriginal ? item.OriginalRewardID : item.RewardID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Sm_message_rewardEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Sm_message_rewardEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "rewardID">编号</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string rewardID, string set_, params object[] values_)
		{
			return Put(set_, "`RewardID` = @RewardID", ConcatValues(values_, rewardID));
		}
		public async Task<int> PutByPKAsync(string rewardID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`RewardID` = @RewardID", ConcatValues(values_, rewardID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "rewardID">编号</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string rewardID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`RewardID` = @RewardID", tm_, ConcatValues(values_, rewardID));
		}
		public async Task<int> PutByPKAsync(string rewardID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`RewardID` = @RewardID", tm_, ConcatValues(values_, rewardID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "rewardID">编号</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string rewardID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@RewardID", rewardID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`RewardID` = @RewardID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string rewardID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@RewardID", rewardID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`RewardID` = @RewardID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "rewardID">编号</param>
		/// /// <param name = "amount">奖励金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAmountByPK(string rewardID, decimal amount, TransactionManager tm_ = null)
		{
			RepairPutAmountByPKData(rewardID, amount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAmountByPKAsync(string rewardID, decimal amount, TransactionManager tm_ = null)
		{
			RepairPutAmountByPKData(rewardID, amount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutAmountByPKData(string rewardID, decimal amount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Amount` = @Amount  WHERE `RewardID` = @RewardID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Amount", amount, MySqlDbType.NewDecimal),
				Database.CreateInParameter("@RewardID", rewardID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "amount">奖励金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAmount(decimal amount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Amount` = @Amount";
			var parameter_ = Database.CreateInParameter("@Amount", amount, MySqlDbType.NewDecimal);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutAmountAsync(decimal amount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Amount` = @Amount";
			var parameter_ = Database.CreateInParameter("@Amount", amount, MySqlDbType.NewDecimal);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutAmount
		#region PutLeastPayAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "rewardID">编号</param>
		/// /// <param name = "leastPayAmount">送赠金的最少充值金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLeastPayAmountByPK(string rewardID, long leastPayAmount, TransactionManager tm_ = null)
		{
			RepairPutLeastPayAmountByPKData(rewardID, leastPayAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLeastPayAmountByPKAsync(string rewardID, long leastPayAmount, TransactionManager tm_ = null)
		{
			RepairPutLeastPayAmountByPKData(rewardID, leastPayAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLeastPayAmountByPKData(string rewardID, long leastPayAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `LeastPayAmount` = @LeastPayAmount  WHERE `RewardID` = @RewardID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LeastPayAmount", leastPayAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@RewardID", rewardID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "leastPayAmount">送赠金的最少充值金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLeastPayAmount(long leastPayAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LeastPayAmount` = @LeastPayAmount";
			var parameter_ = Database.CreateInParameter("@LeastPayAmount", leastPayAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutLeastPayAmountAsync(long leastPayAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LeastPayAmount` = @LeastPayAmount";
			var parameter_ = Database.CreateInParameter("@LeastPayAmount", leastPayAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutLeastPayAmount
		#region PutFlowMultip
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "rewardID">编号</param>
		/// /// <param name = "flowMultip">赠金提现所需要的流水倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFlowMultipByPK(string rewardID, float flowMultip, TransactionManager tm_ = null)
		{
			RepairPutFlowMultipByPKData(rewardID, flowMultip, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFlowMultipByPKAsync(string rewardID, float flowMultip, TransactionManager tm_ = null)
		{
			RepairPutFlowMultipByPKData(rewardID, flowMultip, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFlowMultipByPKData(string rewardID, float flowMultip, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `FlowMultip` = @FlowMultip  WHERE `RewardID` = @RewardID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@FlowMultip", flowMultip, MySqlDbType.Float),
				Database.CreateInParameter("@RewardID", rewardID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "flowMultip">赠金提现所需要的流水倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFlowMultip(float flowMultip, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FlowMultip` = @FlowMultip";
			var parameter_ = Database.CreateInParameter("@FlowMultip", flowMultip, MySqlDbType.Float);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutFlowMultipAsync(float flowMultip, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FlowMultip` = @FlowMultip";
			var parameter_ = Database.CreateInParameter("@FlowMultip", flowMultip, MySqlDbType.Float);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutFlowMultip
		#region PutRecDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "rewardID">编号</param>
		/// /// <param name = "recDate">创建时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(string rewardID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(rewardID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(string rewardID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(rewardID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(string rewardID, DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `RewardID` = @RewardID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@RewardID", rewardID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "recDate">创建时间</param>
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
		#region PutRewardType
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "rewardID">编号</param>
		/// /// <param name = "rewardType">奖励类型1后台发送2活动发送</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRewardTypeByPK(string rewardID, int rewardType, TransactionManager tm_ = null)
		{
			RepairPutRewardTypeByPKData(rewardID, rewardType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRewardTypeByPKAsync(string rewardID, int rewardType, TransactionManager tm_ = null)
		{
			RepairPutRewardTypeByPKData(rewardID, rewardType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRewardTypeByPKData(string rewardID, int rewardType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RewardType` = @RewardType  WHERE `RewardID` = @RewardID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RewardType", rewardType, MySqlDbType.Int32),
				Database.CreateInParameter("@RewardID", rewardID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "rewardType">奖励类型1后台发送2活动发送</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRewardType(int rewardType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RewardType` = @RewardType";
			var parameter_ = Database.CreateInParameter("@RewardType", rewardType, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutRewardTypeAsync(int rewardType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RewardType` = @RewardType";
			var parameter_ = Database.CreateInParameter("@RewardType", rewardType, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutRewardType
		#region PutActivityType
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "rewardID">编号</param>
		/// /// <param name = "activityType">活动类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutActivityTypeByPK(string rewardID, int activityType, TransactionManager tm_ = null)
		{
			RepairPutActivityTypeByPKData(rewardID, activityType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutActivityTypeByPKAsync(string rewardID, int activityType, TransactionManager tm_ = null)
		{
			RepairPutActivityTypeByPKData(rewardID, activityType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutActivityTypeByPKData(string rewardID, int activityType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ActivityType` = @ActivityType  WHERE `RewardID` = @RewardID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ActivityType", activityType, MySqlDbType.Int32),
				Database.CreateInParameter("@RewardID", rewardID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "activityType">活动类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutActivityType(int activityType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ActivityType` = @ActivityType";
			var parameter_ = Database.CreateInParameter("@ActivityType", activityType, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutActivityTypeAsync(int activityType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ActivityType` = @ActivityType";
			var parameter_ = Database.CreateInParameter("@ActivityType", activityType, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutActivityType
		#region PutActivityID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "rewardID">编号</param>
		/// /// <param name = "activityID">活动编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutActivityIDByPK(string rewardID, string activityID, TransactionManager tm_ = null)
		{
			RepairPutActivityIDByPKData(rewardID, activityID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutActivityIDByPKAsync(string rewardID, string activityID, TransactionManager tm_ = null)
		{
			RepairPutActivityIDByPKData(rewardID, activityID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutActivityIDByPKData(string rewardID, string activityID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ActivityID` = @ActivityID  WHERE `RewardID` = @RewardID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ActivityID", activityID != null ? activityID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@RewardID", rewardID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "activityID">活动编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutActivityID(string activityID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ActivityID` = @ActivityID";
			var parameter_ = Database.CreateInParameter("@ActivityID", activityID != null ? activityID : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutActivityIDAsync(string activityID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ActivityID` = @ActivityID";
			var parameter_ = Database.CreateInParameter("@ActivityID", activityID != null ? activityID : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutActivityID
		#region PutSourceType
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "rewardID">编号</param>
		/// /// <param name = "sourceType">source类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSourceTypeByPK(string rewardID, int? sourceType, TransactionManager tm_ = null)
		{
			RepairPutSourceTypeByPKData(rewardID, sourceType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutSourceTypeByPKAsync(string rewardID, int? sourceType, TransactionManager tm_ = null)
		{
			RepairPutSourceTypeByPKData(rewardID, sourceType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutSourceTypeByPKData(string rewardID, int? sourceType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `SourceType` = @SourceType  WHERE `RewardID` = @RewardID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SourceType", sourceType.HasValue ? sourceType.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@RewardID", rewardID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "sourceType">source类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSourceType(int? sourceType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SourceType` = @SourceType";
			var parameter_ = Database.CreateInParameter("@SourceType", sourceType.HasValue ? sourceType.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutSourceTypeAsync(int? sourceType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SourceType` = @SourceType";
			var parameter_ = Database.CreateInParameter("@SourceType", sourceType.HasValue ? sourceType.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutSourceType
		#region PutSourceTable
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "rewardID">编号</param>
		/// /// <param name = "sourceTable">source表名</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSourceTableByPK(string rewardID, string sourceTable, TransactionManager tm_ = null)
		{
			RepairPutSourceTableByPKData(rewardID, sourceTable, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutSourceTableByPKAsync(string rewardID, string sourceTable, TransactionManager tm_ = null)
		{
			RepairPutSourceTableByPKData(rewardID, sourceTable, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutSourceTableByPKData(string rewardID, string sourceTable, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `SourceTable` = @SourceTable  WHERE `RewardID` = @RewardID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SourceTable", sourceTable != null ? sourceTable : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@RewardID", rewardID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "sourceTable">source表名</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSourceTable(string sourceTable, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SourceTable` = @SourceTable";
			var parameter_ = Database.CreateInParameter("@SourceTable", sourceTable != null ? sourceTable : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutSourceTableAsync(string sourceTable, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SourceTable` = @SourceTable";
			var parameter_ = Database.CreateInParameter("@SourceTable", sourceTable != null ? sourceTable : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutSourceTable
		#region PutSourceId
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "rewardID">编号</param>
		/// /// <param name = "sourceId">source表ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSourceIdByPK(string rewardID, string sourceId, TransactionManager tm_ = null)
		{
			RepairPutSourceIdByPKData(rewardID, sourceId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutSourceIdByPKAsync(string rewardID, string sourceId, TransactionManager tm_ = null)
		{
			RepairPutSourceIdByPKData(rewardID, sourceId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutSourceIdByPKData(string rewardID, string sourceId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `SourceId` = @SourceId  WHERE `RewardID` = @RewardID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SourceId", sourceId != null ? sourceId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@RewardID", rewardID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "sourceId">source表ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSourceId(string sourceId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SourceId` = @SourceId";
			var parameter_ = Database.CreateInParameter("@SourceId", sourceId != null ? sourceId : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutSourceIdAsync(string sourceId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SourceId` = @SourceId";
			var parameter_ = Database.CreateInParameter("@SourceId", sourceId != null ? sourceId : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutSourceId
		#region PutAmountType
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "rewardID">编号</param>
		/// /// <param name = "amountType">1bouns2真金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAmountTypeByPK(string rewardID, int? amountType, TransactionManager tm_ = null)
		{
			RepairPutAmountTypeByPKData(rewardID, amountType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAmountTypeByPKAsync(string rewardID, int? amountType, TransactionManager tm_ = null)
		{
			RepairPutAmountTypeByPKData(rewardID, amountType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutAmountTypeByPKData(string rewardID, int? amountType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `AmountType` = @AmountType  WHERE `RewardID` = @RewardID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AmountType", amountType.HasValue ? amountType.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@RewardID", rewardID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "amountType">1bouns2真金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAmountType(int? amountType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `AmountType` = @AmountType";
			var parameter_ = Database.CreateInParameter("@AmountType", amountType.HasValue ? amountType.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutAmountTypeAsync(int? amountType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `AmountType` = @AmountType";
			var parameter_ = Database.CreateInParameter("@AmountType", amountType.HasValue ? amountType.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutAmountType
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Sm_message_rewardEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.RewardID) == null)
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
		public async Task<bool> SetAsync(Sm_message_rewardEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.RewardID) == null)
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
		/// /// <param name = "rewardID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Sm_message_rewardEO GetByPK(string rewardID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(rewardID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sm_message_rewardEO.MapDataReader);
		}
		public async Task<Sm_message_rewardEO> GetByPKAsync(string rewardID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(rewardID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sm_message_rewardEO.MapDataReader);
		}
		private void RepairGetByPKData(string rewardID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`RewardID` = @RewardID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RewardID", rewardID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 Amount（字段）
		/// </summary>
		/// /// <param name = "rewardID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public decimal GetAmountByPK(string rewardID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RewardID", rewardID, MySqlDbType.VarChar),
			};
			return (decimal)GetScalar("`Amount`", "`RewardID` = @RewardID", paras_, tm_);
		}
		public async Task<decimal> GetAmountByPKAsync(string rewardID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RewardID", rewardID, MySqlDbType.VarChar),
			};
			return (decimal)await GetScalarAsync("`Amount`", "`RewardID` = @RewardID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 LeastPayAmount（字段）
		/// </summary>
		/// /// <param name = "rewardID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetLeastPayAmountByPK(string rewardID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RewardID", rewardID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`LeastPayAmount`", "`RewardID` = @RewardID", paras_, tm_);
		}
		public async Task<long> GetLeastPayAmountByPKAsync(string rewardID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RewardID", rewardID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`LeastPayAmount`", "`RewardID` = @RewardID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 FlowMultip（字段）
		/// </summary>
		/// /// <param name = "rewardID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public float GetFlowMultipByPK(string rewardID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RewardID", rewardID, MySqlDbType.VarChar),
			};
			return (float)GetScalar("`FlowMultip`", "`RewardID` = @RewardID", paras_, tm_);
		}
		public async Task<float> GetFlowMultipByPKAsync(string rewardID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RewardID", rewardID, MySqlDbType.VarChar),
			};
			return (float)await GetScalarAsync("`FlowMultip`", "`RewardID` = @RewardID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "rewardID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetRecDateByPK(string rewardID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RewardID", rewardID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`RecDate`", "`RewardID` = @RewardID", paras_, tm_);
		}
		public async Task<DateTime> GetRecDateByPKAsync(string rewardID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RewardID", rewardID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`RecDate`", "`RewardID` = @RewardID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RewardType（字段）
		/// </summary>
		/// /// <param name = "rewardID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetRewardTypeByPK(string rewardID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RewardID", rewardID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`RewardType`", "`RewardID` = @RewardID", paras_, tm_);
		}
		public async Task<int> GetRewardTypeByPKAsync(string rewardID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RewardID", rewardID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`RewardType`", "`RewardID` = @RewardID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ActivityType（字段）
		/// </summary>
		/// /// <param name = "rewardID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetActivityTypeByPK(string rewardID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RewardID", rewardID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`ActivityType`", "`RewardID` = @RewardID", paras_, tm_);
		}
		public async Task<int> GetActivityTypeByPKAsync(string rewardID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RewardID", rewardID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`ActivityType`", "`RewardID` = @RewardID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ActivityID（字段）
		/// </summary>
		/// /// <param name = "rewardID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetActivityIDByPK(string rewardID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RewardID", rewardID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`ActivityID`", "`RewardID` = @RewardID", paras_, tm_);
		}
		public async Task<string> GetActivityIDByPKAsync(string rewardID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RewardID", rewardID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`ActivityID`", "`RewardID` = @RewardID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 SourceType（字段）
		/// </summary>
		/// /// <param name = "rewardID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int? GetSourceTypeByPK(string rewardID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RewardID", rewardID, MySqlDbType.VarChar),
			};
			return (int?)GetScalar("`SourceType`", "`RewardID` = @RewardID", paras_, tm_);
		}
		public async Task<int?> GetSourceTypeByPKAsync(string rewardID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RewardID", rewardID, MySqlDbType.VarChar),
			};
			return (int?)await GetScalarAsync("`SourceType`", "`RewardID` = @RewardID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 SourceTable（字段）
		/// </summary>
		/// /// <param name = "rewardID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetSourceTableByPK(string rewardID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RewardID", rewardID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`SourceTable`", "`RewardID` = @RewardID", paras_, tm_);
		}
		public async Task<string> GetSourceTableByPKAsync(string rewardID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RewardID", rewardID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`SourceTable`", "`RewardID` = @RewardID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 SourceId（字段）
		/// </summary>
		/// /// <param name = "rewardID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetSourceIdByPK(string rewardID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RewardID", rewardID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`SourceId`", "`RewardID` = @RewardID", paras_, tm_);
		}
		public async Task<string> GetSourceIdByPKAsync(string rewardID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RewardID", rewardID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`SourceId`", "`RewardID` = @RewardID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 AmountType（字段）
		/// </summary>
		/// /// <param name = "rewardID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int? GetAmountTypeByPK(string rewardID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RewardID", rewardID, MySqlDbType.VarChar),
			};
			return (int?)GetScalar("`AmountType`", "`RewardID` = @RewardID", paras_, tm_);
		}
		public async Task<int?> GetAmountTypeByPKAsync(string rewardID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RewardID", rewardID, MySqlDbType.VarChar),
			};
			return (int?)await GetScalarAsync("`AmountType`", "`RewardID` = @RewardID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByAmount
		
		/// <summary>
		/// 按 Amount（字段） 查询
		/// </summary>
		/// /// <param name = "amount">奖励金额</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetByAmount(decimal amount)
		{
			return GetByAmount(amount, 0, string.Empty, null);
		}
		public async Task<List<Sm_message_rewardEO>> GetByAmountAsync(decimal amount)
		{
			return await GetByAmountAsync(amount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Amount（字段） 查询
		/// </summary>
		/// /// <param name = "amount">奖励金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetByAmount(decimal amount, TransactionManager tm_)
		{
			return GetByAmount(amount, 0, string.Empty, tm_);
		}
		public async Task<List<Sm_message_rewardEO>> GetByAmountAsync(decimal amount, TransactionManager tm_)
		{
			return await GetByAmountAsync(amount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Amount（字段） 查询
		/// </summary>
		/// /// <param name = "amount">奖励金额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetByAmount(decimal amount, int top_)
		{
			return GetByAmount(amount, top_, string.Empty, null);
		}
		public async Task<List<Sm_message_rewardEO>> GetByAmountAsync(decimal amount, int top_)
		{
			return await GetByAmountAsync(amount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Amount（字段） 查询
		/// </summary>
		/// /// <param name = "amount">奖励金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetByAmount(decimal amount, int top_, TransactionManager tm_)
		{
			return GetByAmount(amount, top_, string.Empty, tm_);
		}
		public async Task<List<Sm_message_rewardEO>> GetByAmountAsync(decimal amount, int top_, TransactionManager tm_)
		{
			return await GetByAmountAsync(amount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Amount（字段） 查询
		/// </summary>
		/// /// <param name = "amount">奖励金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetByAmount(decimal amount, string sort_)
		{
			return GetByAmount(amount, 0, sort_, null);
		}
		public async Task<List<Sm_message_rewardEO>> GetByAmountAsync(decimal amount, string sort_)
		{
			return await GetByAmountAsync(amount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Amount（字段） 查询
		/// </summary>
		/// /// <param name = "amount">奖励金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetByAmount(decimal amount, string sort_, TransactionManager tm_)
		{
			return GetByAmount(amount, 0, sort_, tm_);
		}
		public async Task<List<Sm_message_rewardEO>> GetByAmountAsync(decimal amount, string sort_, TransactionManager tm_)
		{
			return await GetByAmountAsync(amount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Amount（字段） 查询
		/// </summary>
		/// /// <param name = "amount">奖励金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetByAmount(decimal amount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Amount` = @Amount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Amount", amount, MySqlDbType.NewDecimal));
			return Database.ExecSqlList(sql_, paras_, tm_, Sm_message_rewardEO.MapDataReader);
		}
		public async Task<List<Sm_message_rewardEO>> GetByAmountAsync(decimal amount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Amount` = @Amount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Amount", amount, MySqlDbType.NewDecimal));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sm_message_rewardEO.MapDataReader);
		}
		#endregion // GetByAmount
		#region GetByLeastPayAmount
		
		/// <summary>
		/// 按 LeastPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "leastPayAmount">送赠金的最少充值金额</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetByLeastPayAmount(long leastPayAmount)
		{
			return GetByLeastPayAmount(leastPayAmount, 0, string.Empty, null);
		}
		public async Task<List<Sm_message_rewardEO>> GetByLeastPayAmountAsync(long leastPayAmount)
		{
			return await GetByLeastPayAmountAsync(leastPayAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LeastPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "leastPayAmount">送赠金的最少充值金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetByLeastPayAmount(long leastPayAmount, TransactionManager tm_)
		{
			return GetByLeastPayAmount(leastPayAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Sm_message_rewardEO>> GetByLeastPayAmountAsync(long leastPayAmount, TransactionManager tm_)
		{
			return await GetByLeastPayAmountAsync(leastPayAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LeastPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "leastPayAmount">送赠金的最少充值金额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetByLeastPayAmount(long leastPayAmount, int top_)
		{
			return GetByLeastPayAmount(leastPayAmount, top_, string.Empty, null);
		}
		public async Task<List<Sm_message_rewardEO>> GetByLeastPayAmountAsync(long leastPayAmount, int top_)
		{
			return await GetByLeastPayAmountAsync(leastPayAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LeastPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "leastPayAmount">送赠金的最少充值金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetByLeastPayAmount(long leastPayAmount, int top_, TransactionManager tm_)
		{
			return GetByLeastPayAmount(leastPayAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Sm_message_rewardEO>> GetByLeastPayAmountAsync(long leastPayAmount, int top_, TransactionManager tm_)
		{
			return await GetByLeastPayAmountAsync(leastPayAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LeastPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "leastPayAmount">送赠金的最少充值金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetByLeastPayAmount(long leastPayAmount, string sort_)
		{
			return GetByLeastPayAmount(leastPayAmount, 0, sort_, null);
		}
		public async Task<List<Sm_message_rewardEO>> GetByLeastPayAmountAsync(long leastPayAmount, string sort_)
		{
			return await GetByLeastPayAmountAsync(leastPayAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LeastPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "leastPayAmount">送赠金的最少充值金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetByLeastPayAmount(long leastPayAmount, string sort_, TransactionManager tm_)
		{
			return GetByLeastPayAmount(leastPayAmount, 0, sort_, tm_);
		}
		public async Task<List<Sm_message_rewardEO>> GetByLeastPayAmountAsync(long leastPayAmount, string sort_, TransactionManager tm_)
		{
			return await GetByLeastPayAmountAsync(leastPayAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LeastPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "leastPayAmount">送赠金的最少充值金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetByLeastPayAmount(long leastPayAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LeastPayAmount` = @LeastPayAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LeastPayAmount", leastPayAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sm_message_rewardEO.MapDataReader);
		}
		public async Task<List<Sm_message_rewardEO>> GetByLeastPayAmountAsync(long leastPayAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LeastPayAmount` = @LeastPayAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LeastPayAmount", leastPayAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sm_message_rewardEO.MapDataReader);
		}
		#endregion // GetByLeastPayAmount
		#region GetByFlowMultip
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">赠金提现所需要的流水倍数</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetByFlowMultip(float flowMultip)
		{
			return GetByFlowMultip(flowMultip, 0, string.Empty, null);
		}
		public async Task<List<Sm_message_rewardEO>> GetByFlowMultipAsync(float flowMultip)
		{
			return await GetByFlowMultipAsync(flowMultip, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">赠金提现所需要的流水倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetByFlowMultip(float flowMultip, TransactionManager tm_)
		{
			return GetByFlowMultip(flowMultip, 0, string.Empty, tm_);
		}
		public async Task<List<Sm_message_rewardEO>> GetByFlowMultipAsync(float flowMultip, TransactionManager tm_)
		{
			return await GetByFlowMultipAsync(flowMultip, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">赠金提现所需要的流水倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetByFlowMultip(float flowMultip, int top_)
		{
			return GetByFlowMultip(flowMultip, top_, string.Empty, null);
		}
		public async Task<List<Sm_message_rewardEO>> GetByFlowMultipAsync(float flowMultip, int top_)
		{
			return await GetByFlowMultipAsync(flowMultip, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">赠金提现所需要的流水倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetByFlowMultip(float flowMultip, int top_, TransactionManager tm_)
		{
			return GetByFlowMultip(flowMultip, top_, string.Empty, tm_);
		}
		public async Task<List<Sm_message_rewardEO>> GetByFlowMultipAsync(float flowMultip, int top_, TransactionManager tm_)
		{
			return await GetByFlowMultipAsync(flowMultip, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">赠金提现所需要的流水倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetByFlowMultip(float flowMultip, string sort_)
		{
			return GetByFlowMultip(flowMultip, 0, sort_, null);
		}
		public async Task<List<Sm_message_rewardEO>> GetByFlowMultipAsync(float flowMultip, string sort_)
		{
			return await GetByFlowMultipAsync(flowMultip, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">赠金提现所需要的流水倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetByFlowMultip(float flowMultip, string sort_, TransactionManager tm_)
		{
			return GetByFlowMultip(flowMultip, 0, sort_, tm_);
		}
		public async Task<List<Sm_message_rewardEO>> GetByFlowMultipAsync(float flowMultip, string sort_, TransactionManager tm_)
		{
			return await GetByFlowMultipAsync(flowMultip, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">赠金提现所需要的流水倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetByFlowMultip(float flowMultip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FlowMultip` = @FlowMultip", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FlowMultip", flowMultip, MySqlDbType.Float));
			return Database.ExecSqlList(sql_, paras_, tm_, Sm_message_rewardEO.MapDataReader);
		}
		public async Task<List<Sm_message_rewardEO>> GetByFlowMultipAsync(float flowMultip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FlowMultip` = @FlowMultip", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FlowMultip", flowMultip, MySqlDbType.Float));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sm_message_rewardEO.MapDataReader);
		}
		#endregion // GetByFlowMultip
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">创建时间</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<Sm_message_rewardEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">创建时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<Sm_message_rewardEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">创建时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<Sm_message_rewardEO>> GetByRecDateAsync(DateTime recDate, int top_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">创建时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<Sm_message_rewardEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">创建时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<Sm_message_rewardEO>> GetByRecDateAsync(DateTime recDate, string sort_)
		{
			return await GetByRecDateAsync(recDate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">创建时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<Sm_message_rewardEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">创建时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sm_message_rewardEO.MapDataReader);
		}
		public async Task<List<Sm_message_rewardEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sm_message_rewardEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#region GetByRewardType
		
		/// <summary>
		/// 按 RewardType（字段） 查询
		/// </summary>
		/// /// <param name = "rewardType">奖励类型1后台发送2活动发送</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetByRewardType(int rewardType)
		{
			return GetByRewardType(rewardType, 0, string.Empty, null);
		}
		public async Task<List<Sm_message_rewardEO>> GetByRewardTypeAsync(int rewardType)
		{
			return await GetByRewardTypeAsync(rewardType, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RewardType（字段） 查询
		/// </summary>
		/// /// <param name = "rewardType">奖励类型1后台发送2活动发送</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetByRewardType(int rewardType, TransactionManager tm_)
		{
			return GetByRewardType(rewardType, 0, string.Empty, tm_);
		}
		public async Task<List<Sm_message_rewardEO>> GetByRewardTypeAsync(int rewardType, TransactionManager tm_)
		{
			return await GetByRewardTypeAsync(rewardType, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RewardType（字段） 查询
		/// </summary>
		/// /// <param name = "rewardType">奖励类型1后台发送2活动发送</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetByRewardType(int rewardType, int top_)
		{
			return GetByRewardType(rewardType, top_, string.Empty, null);
		}
		public async Task<List<Sm_message_rewardEO>> GetByRewardTypeAsync(int rewardType, int top_)
		{
			return await GetByRewardTypeAsync(rewardType, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RewardType（字段） 查询
		/// </summary>
		/// /// <param name = "rewardType">奖励类型1后台发送2活动发送</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetByRewardType(int rewardType, int top_, TransactionManager tm_)
		{
			return GetByRewardType(rewardType, top_, string.Empty, tm_);
		}
		public async Task<List<Sm_message_rewardEO>> GetByRewardTypeAsync(int rewardType, int top_, TransactionManager tm_)
		{
			return await GetByRewardTypeAsync(rewardType, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RewardType（字段） 查询
		/// </summary>
		/// /// <param name = "rewardType">奖励类型1后台发送2活动发送</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetByRewardType(int rewardType, string sort_)
		{
			return GetByRewardType(rewardType, 0, sort_, null);
		}
		public async Task<List<Sm_message_rewardEO>> GetByRewardTypeAsync(int rewardType, string sort_)
		{
			return await GetByRewardTypeAsync(rewardType, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RewardType（字段） 查询
		/// </summary>
		/// /// <param name = "rewardType">奖励类型1后台发送2活动发送</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetByRewardType(int rewardType, string sort_, TransactionManager tm_)
		{
			return GetByRewardType(rewardType, 0, sort_, tm_);
		}
		public async Task<List<Sm_message_rewardEO>> GetByRewardTypeAsync(int rewardType, string sort_, TransactionManager tm_)
		{
			return await GetByRewardTypeAsync(rewardType, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RewardType（字段） 查询
		/// </summary>
		/// /// <param name = "rewardType">奖励类型1后台发送2活动发送</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetByRewardType(int rewardType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RewardType` = @RewardType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RewardType", rewardType, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sm_message_rewardEO.MapDataReader);
		}
		public async Task<List<Sm_message_rewardEO>> GetByRewardTypeAsync(int rewardType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RewardType` = @RewardType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RewardType", rewardType, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sm_message_rewardEO.MapDataReader);
		}
		#endregion // GetByRewardType
		#region GetByActivityType
		
		/// <summary>
		/// 按 ActivityType（字段） 查询
		/// </summary>
		/// /// <param name = "activityType">活动类型</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetByActivityType(int activityType)
		{
			return GetByActivityType(activityType, 0, string.Empty, null);
		}
		public async Task<List<Sm_message_rewardEO>> GetByActivityTypeAsync(int activityType)
		{
			return await GetByActivityTypeAsync(activityType, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ActivityType（字段） 查询
		/// </summary>
		/// /// <param name = "activityType">活动类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetByActivityType(int activityType, TransactionManager tm_)
		{
			return GetByActivityType(activityType, 0, string.Empty, tm_);
		}
		public async Task<List<Sm_message_rewardEO>> GetByActivityTypeAsync(int activityType, TransactionManager tm_)
		{
			return await GetByActivityTypeAsync(activityType, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ActivityType（字段） 查询
		/// </summary>
		/// /// <param name = "activityType">活动类型</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetByActivityType(int activityType, int top_)
		{
			return GetByActivityType(activityType, top_, string.Empty, null);
		}
		public async Task<List<Sm_message_rewardEO>> GetByActivityTypeAsync(int activityType, int top_)
		{
			return await GetByActivityTypeAsync(activityType, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ActivityType（字段） 查询
		/// </summary>
		/// /// <param name = "activityType">活动类型</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetByActivityType(int activityType, int top_, TransactionManager tm_)
		{
			return GetByActivityType(activityType, top_, string.Empty, tm_);
		}
		public async Task<List<Sm_message_rewardEO>> GetByActivityTypeAsync(int activityType, int top_, TransactionManager tm_)
		{
			return await GetByActivityTypeAsync(activityType, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ActivityType（字段） 查询
		/// </summary>
		/// /// <param name = "activityType">活动类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetByActivityType(int activityType, string sort_)
		{
			return GetByActivityType(activityType, 0, sort_, null);
		}
		public async Task<List<Sm_message_rewardEO>> GetByActivityTypeAsync(int activityType, string sort_)
		{
			return await GetByActivityTypeAsync(activityType, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ActivityType（字段） 查询
		/// </summary>
		/// /// <param name = "activityType">活动类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetByActivityType(int activityType, string sort_, TransactionManager tm_)
		{
			return GetByActivityType(activityType, 0, sort_, tm_);
		}
		public async Task<List<Sm_message_rewardEO>> GetByActivityTypeAsync(int activityType, string sort_, TransactionManager tm_)
		{
			return await GetByActivityTypeAsync(activityType, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ActivityType（字段） 查询
		/// </summary>
		/// /// <param name = "activityType">活动类型</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetByActivityType(int activityType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ActivityType` = @ActivityType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ActivityType", activityType, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sm_message_rewardEO.MapDataReader);
		}
		public async Task<List<Sm_message_rewardEO>> GetByActivityTypeAsync(int activityType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ActivityType` = @ActivityType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ActivityType", activityType, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sm_message_rewardEO.MapDataReader);
		}
		#endregion // GetByActivityType
		#region GetByActivityID
		
		/// <summary>
		/// 按 ActivityID（字段） 查询
		/// </summary>
		/// /// <param name = "activityID">活动编号</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetByActivityID(string activityID)
		{
			return GetByActivityID(activityID, 0, string.Empty, null);
		}
		public async Task<List<Sm_message_rewardEO>> GetByActivityIDAsync(string activityID)
		{
			return await GetByActivityIDAsync(activityID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ActivityID（字段） 查询
		/// </summary>
		/// /// <param name = "activityID">活动编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetByActivityID(string activityID, TransactionManager tm_)
		{
			return GetByActivityID(activityID, 0, string.Empty, tm_);
		}
		public async Task<List<Sm_message_rewardEO>> GetByActivityIDAsync(string activityID, TransactionManager tm_)
		{
			return await GetByActivityIDAsync(activityID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ActivityID（字段） 查询
		/// </summary>
		/// /// <param name = "activityID">活动编号</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetByActivityID(string activityID, int top_)
		{
			return GetByActivityID(activityID, top_, string.Empty, null);
		}
		public async Task<List<Sm_message_rewardEO>> GetByActivityIDAsync(string activityID, int top_)
		{
			return await GetByActivityIDAsync(activityID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ActivityID（字段） 查询
		/// </summary>
		/// /// <param name = "activityID">活动编号</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetByActivityID(string activityID, int top_, TransactionManager tm_)
		{
			return GetByActivityID(activityID, top_, string.Empty, tm_);
		}
		public async Task<List<Sm_message_rewardEO>> GetByActivityIDAsync(string activityID, int top_, TransactionManager tm_)
		{
			return await GetByActivityIDAsync(activityID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ActivityID（字段） 查询
		/// </summary>
		/// /// <param name = "activityID">活动编号</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetByActivityID(string activityID, string sort_)
		{
			return GetByActivityID(activityID, 0, sort_, null);
		}
		public async Task<List<Sm_message_rewardEO>> GetByActivityIDAsync(string activityID, string sort_)
		{
			return await GetByActivityIDAsync(activityID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ActivityID（字段） 查询
		/// </summary>
		/// /// <param name = "activityID">活动编号</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetByActivityID(string activityID, string sort_, TransactionManager tm_)
		{
			return GetByActivityID(activityID, 0, sort_, tm_);
		}
		public async Task<List<Sm_message_rewardEO>> GetByActivityIDAsync(string activityID, string sort_, TransactionManager tm_)
		{
			return await GetByActivityIDAsync(activityID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ActivityID（字段） 查询
		/// </summary>
		/// /// <param name = "activityID">活动编号</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetByActivityID(string activityID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(activityID != null ? "`ActivityID` = @ActivityID" : "`ActivityID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (activityID != null)
				paras_.Add(Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sm_message_rewardEO.MapDataReader);
		}
		public async Task<List<Sm_message_rewardEO>> GetByActivityIDAsync(string activityID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(activityID != null ? "`ActivityID` = @ActivityID" : "`ActivityID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (activityID != null)
				paras_.Add(Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sm_message_rewardEO.MapDataReader);
		}
		#endregion // GetByActivityID
		#region GetBySourceType
		
		/// <summary>
		/// 按 SourceType（字段） 查询
		/// </summary>
		/// /// <param name = "sourceType">source类型</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetBySourceType(int? sourceType)
		{
			return GetBySourceType(sourceType, 0, string.Empty, null);
		}
		public async Task<List<Sm_message_rewardEO>> GetBySourceTypeAsync(int? sourceType)
		{
			return await GetBySourceTypeAsync(sourceType, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SourceType（字段） 查询
		/// </summary>
		/// /// <param name = "sourceType">source类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetBySourceType(int? sourceType, TransactionManager tm_)
		{
			return GetBySourceType(sourceType, 0, string.Empty, tm_);
		}
		public async Task<List<Sm_message_rewardEO>> GetBySourceTypeAsync(int? sourceType, TransactionManager tm_)
		{
			return await GetBySourceTypeAsync(sourceType, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SourceType（字段） 查询
		/// </summary>
		/// /// <param name = "sourceType">source类型</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetBySourceType(int? sourceType, int top_)
		{
			return GetBySourceType(sourceType, top_, string.Empty, null);
		}
		public async Task<List<Sm_message_rewardEO>> GetBySourceTypeAsync(int? sourceType, int top_)
		{
			return await GetBySourceTypeAsync(sourceType, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SourceType（字段） 查询
		/// </summary>
		/// /// <param name = "sourceType">source类型</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetBySourceType(int? sourceType, int top_, TransactionManager tm_)
		{
			return GetBySourceType(sourceType, top_, string.Empty, tm_);
		}
		public async Task<List<Sm_message_rewardEO>> GetBySourceTypeAsync(int? sourceType, int top_, TransactionManager tm_)
		{
			return await GetBySourceTypeAsync(sourceType, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SourceType（字段） 查询
		/// </summary>
		/// /// <param name = "sourceType">source类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetBySourceType(int? sourceType, string sort_)
		{
			return GetBySourceType(sourceType, 0, sort_, null);
		}
		public async Task<List<Sm_message_rewardEO>> GetBySourceTypeAsync(int? sourceType, string sort_)
		{
			return await GetBySourceTypeAsync(sourceType, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 SourceType（字段） 查询
		/// </summary>
		/// /// <param name = "sourceType">source类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetBySourceType(int? sourceType, string sort_, TransactionManager tm_)
		{
			return GetBySourceType(sourceType, 0, sort_, tm_);
		}
		public async Task<List<Sm_message_rewardEO>> GetBySourceTypeAsync(int? sourceType, string sort_, TransactionManager tm_)
		{
			return await GetBySourceTypeAsync(sourceType, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 SourceType（字段） 查询
		/// </summary>
		/// /// <param name = "sourceType">source类型</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetBySourceType(int? sourceType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(sourceType.HasValue ? "`SourceType` = @SourceType" : "`SourceType` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (sourceType.HasValue)
				paras_.Add(Database.CreateInParameter("@SourceType", sourceType.Value, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sm_message_rewardEO.MapDataReader);
		}
		public async Task<List<Sm_message_rewardEO>> GetBySourceTypeAsync(int? sourceType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(sourceType.HasValue ? "`SourceType` = @SourceType" : "`SourceType` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (sourceType.HasValue)
				paras_.Add(Database.CreateInParameter("@SourceType", sourceType.Value, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sm_message_rewardEO.MapDataReader);
		}
		#endregion // GetBySourceType
		#region GetBySourceTable
		
		/// <summary>
		/// 按 SourceTable（字段） 查询
		/// </summary>
		/// /// <param name = "sourceTable">source表名</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetBySourceTable(string sourceTable)
		{
			return GetBySourceTable(sourceTable, 0, string.Empty, null);
		}
		public async Task<List<Sm_message_rewardEO>> GetBySourceTableAsync(string sourceTable)
		{
			return await GetBySourceTableAsync(sourceTable, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SourceTable（字段） 查询
		/// </summary>
		/// /// <param name = "sourceTable">source表名</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetBySourceTable(string sourceTable, TransactionManager tm_)
		{
			return GetBySourceTable(sourceTable, 0, string.Empty, tm_);
		}
		public async Task<List<Sm_message_rewardEO>> GetBySourceTableAsync(string sourceTable, TransactionManager tm_)
		{
			return await GetBySourceTableAsync(sourceTable, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SourceTable（字段） 查询
		/// </summary>
		/// /// <param name = "sourceTable">source表名</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetBySourceTable(string sourceTable, int top_)
		{
			return GetBySourceTable(sourceTable, top_, string.Empty, null);
		}
		public async Task<List<Sm_message_rewardEO>> GetBySourceTableAsync(string sourceTable, int top_)
		{
			return await GetBySourceTableAsync(sourceTable, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SourceTable（字段） 查询
		/// </summary>
		/// /// <param name = "sourceTable">source表名</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetBySourceTable(string sourceTable, int top_, TransactionManager tm_)
		{
			return GetBySourceTable(sourceTable, top_, string.Empty, tm_);
		}
		public async Task<List<Sm_message_rewardEO>> GetBySourceTableAsync(string sourceTable, int top_, TransactionManager tm_)
		{
			return await GetBySourceTableAsync(sourceTable, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SourceTable（字段） 查询
		/// </summary>
		/// /// <param name = "sourceTable">source表名</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetBySourceTable(string sourceTable, string sort_)
		{
			return GetBySourceTable(sourceTable, 0, sort_, null);
		}
		public async Task<List<Sm_message_rewardEO>> GetBySourceTableAsync(string sourceTable, string sort_)
		{
			return await GetBySourceTableAsync(sourceTable, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 SourceTable（字段） 查询
		/// </summary>
		/// /// <param name = "sourceTable">source表名</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetBySourceTable(string sourceTable, string sort_, TransactionManager tm_)
		{
			return GetBySourceTable(sourceTable, 0, sort_, tm_);
		}
		public async Task<List<Sm_message_rewardEO>> GetBySourceTableAsync(string sourceTable, string sort_, TransactionManager tm_)
		{
			return await GetBySourceTableAsync(sourceTable, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 SourceTable（字段） 查询
		/// </summary>
		/// /// <param name = "sourceTable">source表名</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetBySourceTable(string sourceTable, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(sourceTable != null ? "`SourceTable` = @SourceTable" : "`SourceTable` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (sourceTable != null)
				paras_.Add(Database.CreateInParameter("@SourceTable", sourceTable, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sm_message_rewardEO.MapDataReader);
		}
		public async Task<List<Sm_message_rewardEO>> GetBySourceTableAsync(string sourceTable, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(sourceTable != null ? "`SourceTable` = @SourceTable" : "`SourceTable` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (sourceTable != null)
				paras_.Add(Database.CreateInParameter("@SourceTable", sourceTable, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sm_message_rewardEO.MapDataReader);
		}
		#endregion // GetBySourceTable
		#region GetBySourceId
		
		/// <summary>
		/// 按 SourceId（字段） 查询
		/// </summary>
		/// /// <param name = "sourceId">source表ID</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetBySourceId(string sourceId)
		{
			return GetBySourceId(sourceId, 0, string.Empty, null);
		}
		public async Task<List<Sm_message_rewardEO>> GetBySourceIdAsync(string sourceId)
		{
			return await GetBySourceIdAsync(sourceId, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SourceId（字段） 查询
		/// </summary>
		/// /// <param name = "sourceId">source表ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetBySourceId(string sourceId, TransactionManager tm_)
		{
			return GetBySourceId(sourceId, 0, string.Empty, tm_);
		}
		public async Task<List<Sm_message_rewardEO>> GetBySourceIdAsync(string sourceId, TransactionManager tm_)
		{
			return await GetBySourceIdAsync(sourceId, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SourceId（字段） 查询
		/// </summary>
		/// /// <param name = "sourceId">source表ID</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetBySourceId(string sourceId, int top_)
		{
			return GetBySourceId(sourceId, top_, string.Empty, null);
		}
		public async Task<List<Sm_message_rewardEO>> GetBySourceIdAsync(string sourceId, int top_)
		{
			return await GetBySourceIdAsync(sourceId, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SourceId（字段） 查询
		/// </summary>
		/// /// <param name = "sourceId">source表ID</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetBySourceId(string sourceId, int top_, TransactionManager tm_)
		{
			return GetBySourceId(sourceId, top_, string.Empty, tm_);
		}
		public async Task<List<Sm_message_rewardEO>> GetBySourceIdAsync(string sourceId, int top_, TransactionManager tm_)
		{
			return await GetBySourceIdAsync(sourceId, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SourceId（字段） 查询
		/// </summary>
		/// /// <param name = "sourceId">source表ID</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetBySourceId(string sourceId, string sort_)
		{
			return GetBySourceId(sourceId, 0, sort_, null);
		}
		public async Task<List<Sm_message_rewardEO>> GetBySourceIdAsync(string sourceId, string sort_)
		{
			return await GetBySourceIdAsync(sourceId, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 SourceId（字段） 查询
		/// </summary>
		/// /// <param name = "sourceId">source表ID</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetBySourceId(string sourceId, string sort_, TransactionManager tm_)
		{
			return GetBySourceId(sourceId, 0, sort_, tm_);
		}
		public async Task<List<Sm_message_rewardEO>> GetBySourceIdAsync(string sourceId, string sort_, TransactionManager tm_)
		{
			return await GetBySourceIdAsync(sourceId, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 SourceId（字段） 查询
		/// </summary>
		/// /// <param name = "sourceId">source表ID</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetBySourceId(string sourceId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(sourceId != null ? "`SourceId` = @SourceId" : "`SourceId` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (sourceId != null)
				paras_.Add(Database.CreateInParameter("@SourceId", sourceId, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sm_message_rewardEO.MapDataReader);
		}
		public async Task<List<Sm_message_rewardEO>> GetBySourceIdAsync(string sourceId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(sourceId != null ? "`SourceId` = @SourceId" : "`SourceId` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (sourceId != null)
				paras_.Add(Database.CreateInParameter("@SourceId", sourceId, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sm_message_rewardEO.MapDataReader);
		}
		#endregion // GetBySourceId
		#region GetByAmountType
		
		/// <summary>
		/// 按 AmountType（字段） 查询
		/// </summary>
		/// /// <param name = "amountType">1bouns2真金</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetByAmountType(int? amountType)
		{
			return GetByAmountType(amountType, 0, string.Empty, null);
		}
		public async Task<List<Sm_message_rewardEO>> GetByAmountTypeAsync(int? amountType)
		{
			return await GetByAmountTypeAsync(amountType, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AmountType（字段） 查询
		/// </summary>
		/// /// <param name = "amountType">1bouns2真金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetByAmountType(int? amountType, TransactionManager tm_)
		{
			return GetByAmountType(amountType, 0, string.Empty, tm_);
		}
		public async Task<List<Sm_message_rewardEO>> GetByAmountTypeAsync(int? amountType, TransactionManager tm_)
		{
			return await GetByAmountTypeAsync(amountType, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AmountType（字段） 查询
		/// </summary>
		/// /// <param name = "amountType">1bouns2真金</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetByAmountType(int? amountType, int top_)
		{
			return GetByAmountType(amountType, top_, string.Empty, null);
		}
		public async Task<List<Sm_message_rewardEO>> GetByAmountTypeAsync(int? amountType, int top_)
		{
			return await GetByAmountTypeAsync(amountType, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AmountType（字段） 查询
		/// </summary>
		/// /// <param name = "amountType">1bouns2真金</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetByAmountType(int? amountType, int top_, TransactionManager tm_)
		{
			return GetByAmountType(amountType, top_, string.Empty, tm_);
		}
		public async Task<List<Sm_message_rewardEO>> GetByAmountTypeAsync(int? amountType, int top_, TransactionManager tm_)
		{
			return await GetByAmountTypeAsync(amountType, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AmountType（字段） 查询
		/// </summary>
		/// /// <param name = "amountType">1bouns2真金</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetByAmountType(int? amountType, string sort_)
		{
			return GetByAmountType(amountType, 0, sort_, null);
		}
		public async Task<List<Sm_message_rewardEO>> GetByAmountTypeAsync(int? amountType, string sort_)
		{
			return await GetByAmountTypeAsync(amountType, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 AmountType（字段） 查询
		/// </summary>
		/// /// <param name = "amountType">1bouns2真金</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetByAmountType(int? amountType, string sort_, TransactionManager tm_)
		{
			return GetByAmountType(amountType, 0, sort_, tm_);
		}
		public async Task<List<Sm_message_rewardEO>> GetByAmountTypeAsync(int? amountType, string sort_, TransactionManager tm_)
		{
			return await GetByAmountTypeAsync(amountType, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 AmountType（字段） 查询
		/// </summary>
		/// /// <param name = "amountType">1bouns2真金</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_rewardEO> GetByAmountType(int? amountType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(amountType.HasValue ? "`AmountType` = @AmountType" : "`AmountType` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (amountType.HasValue)
				paras_.Add(Database.CreateInParameter("@AmountType", amountType.Value, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sm_message_rewardEO.MapDataReader);
		}
		public async Task<List<Sm_message_rewardEO>> GetByAmountTypeAsync(int? amountType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(amountType.HasValue ? "`AmountType` = @AmountType" : "`AmountType` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (amountType.HasValue)
				paras_.Add(Database.CreateInParameter("@AmountType", amountType.Value, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sm_message_rewardEO.MapDataReader);
		}
		#endregion // GetByAmountType
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
