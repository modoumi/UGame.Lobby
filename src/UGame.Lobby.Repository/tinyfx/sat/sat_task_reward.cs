/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * AiUo代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/AiUo
 * 文档生成时间：2024-01-12 19: 25:08
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
	/// 任务奖励定义表
	/// 【表 sat_task_reward 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Sat_task_rewardEO : IRowMapper<Sat_task_rewardEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Sat_task_rewardEO()
		{
			this.Level = 0;
			this.RewardType = 0;
			this.IssueRule = 1;
			this.IpLimits = 500;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private int _originalItemID;
		/// <summary>
		/// 【数据库中的原始主键 ItemID 值的副本，用于主键值更新】
		/// </summary>
		public int OriginalItemID
		{
			get { return _originalItemID; }
			set { HasOriginal = true; _originalItemID = value; }
		}
		
		private string _originalOperatorID;
		/// <summary>
		/// 【数据库中的原始主键 OperatorID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalOperatorID
		{
			get { return _originalOperatorID; }
			set { HasOriginal = true; _originalOperatorID = value; }
		}
		
		private int _originalLevel;
		/// <summary>
		/// 【数据库中的原始主键 Level 值的副本，用于主键值更新】
		/// </summary>
		public int OriginalLevel
		{
			get { return _originalLevel; }
			set { HasOriginal = true; _originalLevel = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "ItemID", ItemID },  { "OperatorID", OperatorID },  { "Level", Level }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 工具编码
		/// 【主键 int】
		/// </summary>
		[DataMember(Order = 1)]
		public int ItemID { get; set; }
		/// <summary>
		/// 运营商编码
		/// 【主键 varchar(50)】
		/// </summary>
		[DataMember(Order = 2)]
		public string OperatorID { get; set; }
		/// <summary>
		/// 等级
		/// 【主键 int】
		/// </summary>
		[DataMember(Order = 3)]
		public int Level { get; set; }
		/// <summary>
		/// 奖励类型 0-未知 1-Bonus 2-真金
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 4)]
		public int RewardType { get; set; }
		/// <summary>
		/// 流水倍数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 5)]
		public int FlowMultip { get; set; }
		/// <summary>
		/// 发放规则,0-未知 1-固定金额 2-按权重 3-随机抽取
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 6)]
		public int IssueRule { get; set; }
		/// <summary>
		/// 奖励条件表达式, 有值才会执行规则,没有值则在对应action中进行处理
		/// 【字段 varchar(500)】
		/// </summary>
		[DataMember(Order = 7)]
		public string ConditionExpr { get; set; }
		/// <summary>
		/// 条件参数, json格式, 用于任务中心显示
		/// 【字段 varchar(500)】
		/// </summary>
		[DataMember(Order = 8)]
		public string JsonParameters { get; set; }
		/// <summary>
		/// 奖励金额, 发放规则为固定金额时有效
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 9)]
		public long RewardAmount { get; set; }
		/// <summary>
		/// IP地址限制
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 10)]
		public int IpLimits { get; set; }
		/// <summary>
		/// 进度最大值 钱是Money，除以10000后的数字
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 11)]
		public int MaxValue { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Sat_task_rewardEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Sat_task_rewardEO MapDataReader(IDataReader reader)
		{
		    Sat_task_rewardEO ret = new Sat_task_rewardEO();
			ret.ItemID = reader.ToInt32("ItemID");
			ret.OriginalItemID = ret.ItemID;
			ret.OperatorID = reader.ToString("OperatorID");
			ret.OriginalOperatorID = ret.OperatorID;
			ret.Level = reader.ToInt32("Level");
			ret.OriginalLevel = ret.Level;
			ret.RewardType = reader.ToInt32("RewardType");
			ret.FlowMultip = reader.ToInt32("FlowMultip");
			ret.IssueRule = reader.ToInt32("IssueRule");
			ret.ConditionExpr = reader.ToString("ConditionExpr");
			ret.JsonParameters = reader.ToString("JsonParameters");
			ret.RewardAmount = reader.ToInt64("RewardAmount");
			ret.IpLimits = reader.ToInt32("IpLimits");
			ret.MaxValue = reader.ToInt32("MaxValue");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 任务奖励定义表
	/// 【表 sat_task_reward 的操作类】
	/// </summary>
	[Obsolete]
	public class Sat_task_rewardMO : MySqlTableMO<Sat_task_rewardEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`sat_task_reward`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Sat_task_rewardMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Sat_task_rewardMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Sat_task_rewardMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Sat_task_rewardEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Sat_task_rewardEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Sat_task_rewardEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`ItemID`, `OperatorID`, `Level`, `RewardType`, `FlowMultip`, `IssueRule`, `ConditionExpr`, `JsonParameters`, `RewardAmount`, `IpLimits`, `MaxValue`) VALUE (@ItemID, @OperatorID, @Level, @RewardType, @FlowMultip, @IssueRule, @ConditionExpr, @JsonParameters, @RewardAmount, @IpLimits, @MaxValue);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", item.ItemID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Level", item.Level, MySqlDbType.Int32),
				Database.CreateInParameter("@RewardType", item.RewardType, MySqlDbType.Int32),
				Database.CreateInParameter("@FlowMultip", item.FlowMultip, MySqlDbType.Int32),
				Database.CreateInParameter("@IssueRule", item.IssueRule, MySqlDbType.Int32),
				Database.CreateInParameter("@ConditionExpr", item.ConditionExpr != null ? item.ConditionExpr : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@JsonParameters", item.JsonParameters != null ? item.JsonParameters : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@RewardAmount", item.RewardAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@IpLimits", item.IpLimits, MySqlDbType.Int32),
				Database.CreateInParameter("@MaxValue", item.MaxValue, MySqlDbType.Int32),
			};
		}
		public int AddByBatch(IEnumerable<Sat_task_rewardEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Sat_task_rewardEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sat_task_rewardEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`ItemID`, `OperatorID`, `Level`, `RewardType`, `FlowMultip`, `IssueRule`, `ConditionExpr`, `JsonParameters`, `RewardAmount`, `IpLimits`, `MaxValue`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"({item.ItemID},'{item.OperatorID}',{item.Level},{item.RewardType},{item.FlowMultip},{item.IssueRule},'{item.ConditionExpr}','{item.JsonParameters}',{item.RewardAmount},{item.IpLimits},{item.MaxValue}),");
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
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "level">等级</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(int itemID, string operatorID, int level, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(itemID, operatorID, level, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(int itemID, string operatorID, int level, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(itemID, operatorID, level, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(int itemID, string operatorID, int level, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `ItemID` = @ItemID AND `OperatorID` = @OperatorID AND `Level` = @Level";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Level", level, MySqlDbType.Int32),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Sat_task_rewardEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.ItemID, item.OperatorID, item.Level, tm_);
		}
		public async Task<int> RemoveAsync(Sat_task_rewardEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.ItemID, item.OperatorID, item.Level, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
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
		#region RemoveByOperatorID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByOperatorID(string operatorID, TransactionManager tm_ = null)
		{
			RepairRemoveByOperatorIDData(operatorID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByOperatorIDAsync(string operatorID, TransactionManager tm_ = null)
		{
			RepairRemoveByOperatorIDData(operatorID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByOperatorIDData(string operatorID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByOperatorID
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
		#region RemoveByRewardType
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "rewardType">奖励类型 0-未知 1-Bonus 2-真金</param>
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
		#region RemoveByFlowMultip
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "flowMultip">流水倍数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByFlowMultip(int flowMultip, TransactionManager tm_ = null)
		{
			RepairRemoveByFlowMultipData(flowMultip, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByFlowMultipAsync(int flowMultip, TransactionManager tm_ = null)
		{
			RepairRemoveByFlowMultipData(flowMultip, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByFlowMultipData(int flowMultip, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `FlowMultip` = @FlowMultip";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FlowMultip", flowMultip, MySqlDbType.Int32));
		}
		#endregion // RemoveByFlowMultip
		#region RemoveByIssueRule
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "issueRule">发放规则,0-未知 1-固定金额 2-按权重 3-随机抽取</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByIssueRule(int issueRule, TransactionManager tm_ = null)
		{
			RepairRemoveByIssueRuleData(issueRule, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByIssueRuleAsync(int issueRule, TransactionManager tm_ = null)
		{
			RepairRemoveByIssueRuleData(issueRule, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByIssueRuleData(int issueRule, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `IssueRule` = @IssueRule";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IssueRule", issueRule, MySqlDbType.Int32));
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
		#region RemoveByJsonParameters
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "jsonParameters">条件参数, json格式, 用于任务中心显示</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByJsonParameters(string jsonParameters, TransactionManager tm_ = null)
		{
			RepairRemoveByJsonParametersData(jsonParameters, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByJsonParametersAsync(string jsonParameters, TransactionManager tm_ = null)
		{
			RepairRemoveByJsonParametersData(jsonParameters, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByJsonParametersData(string jsonParameters, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (jsonParameters != null ? "`JsonParameters` = @JsonParameters" : "`JsonParameters` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (jsonParameters != null)
				paras_.Add(Database.CreateInParameter("@JsonParameters", jsonParameters, MySqlDbType.VarChar));
		}
		#endregion // RemoveByJsonParameters
		#region RemoveByRewardAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "rewardAmount">奖励金额, 发放规则为固定金额时有效</param>
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
		#region RemoveByIpLimits
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "ipLimits">IP地址限制</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByIpLimits(int ipLimits, TransactionManager tm_ = null)
		{
			RepairRemoveByIpLimitsData(ipLimits, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByIpLimitsAsync(int ipLimits, TransactionManager tm_ = null)
		{
			RepairRemoveByIpLimitsData(ipLimits, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByIpLimitsData(int ipLimits, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `IpLimits` = @IpLimits";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IpLimits", ipLimits, MySqlDbType.Int32));
		}
		#endregion // RemoveByIpLimits
		#region RemoveByMaxValue
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "maxValue">进度最大值 钱是Money，除以10000后的数字</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByMaxValue(int maxValue, TransactionManager tm_ = null)
		{
			RepairRemoveByMaxValueData(maxValue, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByMaxValueAsync(int maxValue, TransactionManager tm_ = null)
		{
			RepairRemoveByMaxValueData(maxValue, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByMaxValueData(int maxValue, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `MaxValue` = @MaxValue";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MaxValue", maxValue, MySqlDbType.Int32));
		}
		#endregion // RemoveByMaxValue
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
		public int Put(Sat_task_rewardEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Sat_task_rewardEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Sat_task_rewardEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ItemID` = @ItemID, `OperatorID` = @OperatorID, `Level` = @Level, `RewardType` = @RewardType, `FlowMultip` = @FlowMultip, `IssueRule` = @IssueRule, `ConditionExpr` = @ConditionExpr, `JsonParameters` = @JsonParameters, `RewardAmount` = @RewardAmount, `IpLimits` = @IpLimits, `MaxValue` = @MaxValue WHERE `ItemID` = @ItemID_Original AND `OperatorID` = @OperatorID_Original AND `Level` = @Level_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", item.ItemID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Level", item.Level, MySqlDbType.Int32),
				Database.CreateInParameter("@RewardType", item.RewardType, MySqlDbType.Int32),
				Database.CreateInParameter("@FlowMultip", item.FlowMultip, MySqlDbType.Int32),
				Database.CreateInParameter("@IssueRule", item.IssueRule, MySqlDbType.Int32),
				Database.CreateInParameter("@ConditionExpr", item.ConditionExpr != null ? item.ConditionExpr : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@JsonParameters", item.JsonParameters != null ? item.JsonParameters : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@RewardAmount", item.RewardAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@IpLimits", item.IpLimits, MySqlDbType.Int32),
				Database.CreateInParameter("@MaxValue", item.MaxValue, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemID_Original", item.HasOriginal ? item.OriginalItemID : item.ItemID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID_Original", item.HasOriginal ? item.OriginalOperatorID : item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Level_Original", item.HasOriginal ? item.OriginalLevel : item.Level, MySqlDbType.Int32),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Sat_task_rewardEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Sat_task_rewardEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "level">等级</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int itemID, string operatorID, int level, string set_, params object[] values_)
		{
			return Put(set_, "`ItemID` = @ItemID AND `OperatorID` = @OperatorID AND `Level` = @Level", ConcatValues(values_, itemID, operatorID, level));
		}
		public async Task<int> PutByPKAsync(int itemID, string operatorID, int level, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`ItemID` = @ItemID AND `OperatorID` = @OperatorID AND `Level` = @Level", ConcatValues(values_, itemID, operatorID, level));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "level">等级</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int itemID, string operatorID, int level, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`ItemID` = @ItemID AND `OperatorID` = @OperatorID AND `Level` = @Level", tm_, ConcatValues(values_, itemID, operatorID, level));
		}
		public async Task<int> PutByPKAsync(int itemID, string operatorID, int level, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`ItemID` = @ItemID AND `OperatorID` = @OperatorID AND `Level` = @Level", tm_, ConcatValues(values_, itemID, operatorID, level));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "level">等级</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int itemID, string operatorID, int level, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Level", level, MySqlDbType.Int32),
	        };
			return Put(set_, "`ItemID` = @ItemID AND `OperatorID` = @OperatorID AND `Level` = @Level", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(int itemID, string operatorID, int level, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Level", level, MySqlDbType.Int32),
	        };
			return await PutAsync(set_, "`ItemID` = @ItemID AND `OperatorID` = @OperatorID AND `Level` = @Level", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutItemID
	 
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
		#region PutOperatorID
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorID(string operatorID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID";
			var parameter_ = Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutOperatorIDAsync(string operatorID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID";
			var parameter_ = Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutOperatorID
		#region PutLevel
	 
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
		#region PutRewardType
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "level">等级</param>
		/// /// <param name = "rewardType">奖励类型 0-未知 1-Bonus 2-真金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRewardTypeByPK(int itemID, string operatorID, int level, int rewardType, TransactionManager tm_ = null)
		{
			RepairPutRewardTypeByPKData(itemID, operatorID, level, rewardType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRewardTypeByPKAsync(int itemID, string operatorID, int level, int rewardType, TransactionManager tm_ = null)
		{
			RepairPutRewardTypeByPKData(itemID, operatorID, level, rewardType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRewardTypeByPKData(int itemID, string operatorID, int level, int rewardType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RewardType` = @RewardType  WHERE `ItemID` = @ItemID AND `OperatorID` = @OperatorID AND `Level` = @Level";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RewardType", rewardType, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Level", level, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "rewardType">奖励类型 0-未知 1-Bonus 2-真金</param>
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
		#region PutFlowMultip
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "level">等级</param>
		/// /// <param name = "flowMultip">流水倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFlowMultipByPK(int itemID, string operatorID, int level, int flowMultip, TransactionManager tm_ = null)
		{
			RepairPutFlowMultipByPKData(itemID, operatorID, level, flowMultip, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFlowMultipByPKAsync(int itemID, string operatorID, int level, int flowMultip, TransactionManager tm_ = null)
		{
			RepairPutFlowMultipByPKData(itemID, operatorID, level, flowMultip, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFlowMultipByPKData(int itemID, string operatorID, int level, int flowMultip, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `FlowMultip` = @FlowMultip  WHERE `ItemID` = @ItemID AND `OperatorID` = @OperatorID AND `Level` = @Level";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@FlowMultip", flowMultip, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Level", level, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "flowMultip">流水倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFlowMultip(int flowMultip, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FlowMultip` = @FlowMultip";
			var parameter_ = Database.CreateInParameter("@FlowMultip", flowMultip, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutFlowMultipAsync(int flowMultip, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FlowMultip` = @FlowMultip";
			var parameter_ = Database.CreateInParameter("@FlowMultip", flowMultip, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutFlowMultip
		#region PutIssueRule
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "level">等级</param>
		/// /// <param name = "issueRule">发放规则,0-未知 1-固定金额 2-按权重 3-随机抽取</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIssueRuleByPK(int itemID, string operatorID, int level, int issueRule, TransactionManager tm_ = null)
		{
			RepairPutIssueRuleByPKData(itemID, operatorID, level, issueRule, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutIssueRuleByPKAsync(int itemID, string operatorID, int level, int issueRule, TransactionManager tm_ = null)
		{
			RepairPutIssueRuleByPKData(itemID, operatorID, level, issueRule, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutIssueRuleByPKData(int itemID, string operatorID, int level, int issueRule, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `IssueRule` = @IssueRule  WHERE `ItemID` = @ItemID AND `OperatorID` = @OperatorID AND `Level` = @Level";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@IssueRule", issueRule, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Level", level, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "issueRule">发放规则,0-未知 1-固定金额 2-按权重 3-随机抽取</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIssueRule(int issueRule, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IssueRule` = @IssueRule";
			var parameter_ = Database.CreateInParameter("@IssueRule", issueRule, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutIssueRuleAsync(int issueRule, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IssueRule` = @IssueRule";
			var parameter_ = Database.CreateInParameter("@IssueRule", issueRule, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutIssueRule
		#region PutConditionExpr
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "level">等级</param>
		/// /// <param name = "conditionExpr">奖励条件表达式, 有值才会执行规则,没有值则在对应action中进行处理</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutConditionExprByPK(int itemID, string operatorID, int level, string conditionExpr, TransactionManager tm_ = null)
		{
			RepairPutConditionExprByPKData(itemID, operatorID, level, conditionExpr, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutConditionExprByPKAsync(int itemID, string operatorID, int level, string conditionExpr, TransactionManager tm_ = null)
		{
			RepairPutConditionExprByPKData(itemID, operatorID, level, conditionExpr, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutConditionExprByPKData(int itemID, string operatorID, int level, string conditionExpr, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ConditionExpr` = @ConditionExpr  WHERE `ItemID` = @ItemID AND `OperatorID` = @OperatorID AND `Level` = @Level";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConditionExpr", conditionExpr != null ? conditionExpr : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Level", level, MySqlDbType.Int32),
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
		#region PutJsonParameters
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "level">等级</param>
		/// /// <param name = "jsonParameters">条件参数, json格式, 用于任务中心显示</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutJsonParametersByPK(int itemID, string operatorID, int level, string jsonParameters, TransactionManager tm_ = null)
		{
			RepairPutJsonParametersByPKData(itemID, operatorID, level, jsonParameters, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutJsonParametersByPKAsync(int itemID, string operatorID, int level, string jsonParameters, TransactionManager tm_ = null)
		{
			RepairPutJsonParametersByPKData(itemID, operatorID, level, jsonParameters, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutJsonParametersByPKData(int itemID, string operatorID, int level, string jsonParameters, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `JsonParameters` = @JsonParameters  WHERE `ItemID` = @ItemID AND `OperatorID` = @OperatorID AND `Level` = @Level";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@JsonParameters", jsonParameters != null ? jsonParameters : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Level", level, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "jsonParameters">条件参数, json格式, 用于任务中心显示</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutJsonParameters(string jsonParameters, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `JsonParameters` = @JsonParameters";
			var parameter_ = Database.CreateInParameter("@JsonParameters", jsonParameters != null ? jsonParameters : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutJsonParametersAsync(string jsonParameters, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `JsonParameters` = @JsonParameters";
			var parameter_ = Database.CreateInParameter("@JsonParameters", jsonParameters != null ? jsonParameters : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutJsonParameters
		#region PutRewardAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "level">等级</param>
		/// /// <param name = "rewardAmount">奖励金额, 发放规则为固定金额时有效</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRewardAmountByPK(int itemID, string operatorID, int level, long rewardAmount, TransactionManager tm_ = null)
		{
			RepairPutRewardAmountByPKData(itemID, operatorID, level, rewardAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRewardAmountByPKAsync(int itemID, string operatorID, int level, long rewardAmount, TransactionManager tm_ = null)
		{
			RepairPutRewardAmountByPKData(itemID, operatorID, level, rewardAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRewardAmountByPKData(int itemID, string operatorID, int level, long rewardAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RewardAmount` = @RewardAmount  WHERE `ItemID` = @ItemID AND `OperatorID` = @OperatorID AND `Level` = @Level";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RewardAmount", rewardAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Level", level, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "rewardAmount">奖励金额, 发放规则为固定金额时有效</param>
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
		#region PutIpLimits
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "level">等级</param>
		/// /// <param name = "ipLimits">IP地址限制</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIpLimitsByPK(int itemID, string operatorID, int level, int ipLimits, TransactionManager tm_ = null)
		{
			RepairPutIpLimitsByPKData(itemID, operatorID, level, ipLimits, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutIpLimitsByPKAsync(int itemID, string operatorID, int level, int ipLimits, TransactionManager tm_ = null)
		{
			RepairPutIpLimitsByPKData(itemID, operatorID, level, ipLimits, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutIpLimitsByPKData(int itemID, string operatorID, int level, int ipLimits, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `IpLimits` = @IpLimits  WHERE `ItemID` = @ItemID AND `OperatorID` = @OperatorID AND `Level` = @Level";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@IpLimits", ipLimits, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Level", level, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "ipLimits">IP地址限制</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIpLimits(int ipLimits, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IpLimits` = @IpLimits";
			var parameter_ = Database.CreateInParameter("@IpLimits", ipLimits, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutIpLimitsAsync(int ipLimits, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IpLimits` = @IpLimits";
			var parameter_ = Database.CreateInParameter("@IpLimits", ipLimits, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutIpLimits
		#region PutMaxValue
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "level">等级</param>
		/// /// <param name = "maxValue">进度最大值 钱是Money，除以10000后的数字</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMaxValueByPK(int itemID, string operatorID, int level, int maxValue, TransactionManager tm_ = null)
		{
			RepairPutMaxValueByPKData(itemID, operatorID, level, maxValue, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutMaxValueByPKAsync(int itemID, string operatorID, int level, int maxValue, TransactionManager tm_ = null)
		{
			RepairPutMaxValueByPKData(itemID, operatorID, level, maxValue, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutMaxValueByPKData(int itemID, string operatorID, int level, int maxValue, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `MaxValue` = @MaxValue  WHERE `ItemID` = @ItemID AND `OperatorID` = @OperatorID AND `Level` = @Level";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MaxValue", maxValue, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Level", level, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "maxValue">进度最大值 钱是Money，除以10000后的数字</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMaxValue(int maxValue, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MaxValue` = @MaxValue";
			var parameter_ = Database.CreateInParameter("@MaxValue", maxValue, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutMaxValueAsync(int maxValue, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MaxValue` = @MaxValue";
			var parameter_ = Database.CreateInParameter("@MaxValue", maxValue, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutMaxValue
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Sat_task_rewardEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.ItemID, item.OperatorID, item.Level) == null)
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
		public async Task<bool> SetAsync(Sat_task_rewardEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.ItemID, item.OperatorID, item.Level) == null)
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
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "level">等级</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Sat_task_rewardEO GetByPK(int itemID, string operatorID, int level, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(itemID, operatorID, level, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sat_task_rewardEO.MapDataReader);
		}
		public async Task<Sat_task_rewardEO> GetByPKAsync(int itemID, string operatorID, int level, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(itemID, operatorID, level, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sat_task_rewardEO.MapDataReader);
		}
		private void RepairGetByPKData(int itemID, string operatorID, int level, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`ItemID` = @ItemID AND `OperatorID` = @OperatorID AND `Level` = @Level", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Level", level, MySqlDbType.Int32),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 ItemID（字段）
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "level">等级</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetItemIDByPK(int itemID, string operatorID, int level, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Level", level, MySqlDbType.Int32),
			};
			return (int)GetScalar("`ItemID`", "`ItemID` = @ItemID AND `OperatorID` = @OperatorID AND `Level` = @Level", paras_, tm_);
		}
		public async Task<int> GetItemIDByPKAsync(int itemID, string operatorID, int level, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Level", level, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`ItemID`", "`ItemID` = @ItemID AND `OperatorID` = @OperatorID AND `Level` = @Level", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OperatorID（字段）
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "level">等级</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorIDByPK(int itemID, string operatorID, int level, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Level", level, MySqlDbType.Int32),
			};
			return (string)GetScalar("`OperatorID`", "`ItemID` = @ItemID AND `OperatorID` = @OperatorID AND `Level` = @Level", paras_, tm_);
		}
		public async Task<string> GetOperatorIDByPKAsync(int itemID, string operatorID, int level, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Level", level, MySqlDbType.Int32),
			};
			return (string)await GetScalarAsync("`OperatorID`", "`ItemID` = @ItemID AND `OperatorID` = @OperatorID AND `Level` = @Level", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Level（字段）
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "level">等级</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetLevelByPK(int itemID, string operatorID, int level, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Level", level, MySqlDbType.Int32),
			};
			return (int)GetScalar("`Level`", "`ItemID` = @ItemID AND `OperatorID` = @OperatorID AND `Level` = @Level", paras_, tm_);
		}
		public async Task<int> GetLevelByPKAsync(int itemID, string operatorID, int level, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Level", level, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`Level`", "`ItemID` = @ItemID AND `OperatorID` = @OperatorID AND `Level` = @Level", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RewardType（字段）
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "level">等级</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetRewardTypeByPK(int itemID, string operatorID, int level, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Level", level, MySqlDbType.Int32),
			};
			return (int)GetScalar("`RewardType`", "`ItemID` = @ItemID AND `OperatorID` = @OperatorID AND `Level` = @Level", paras_, tm_);
		}
		public async Task<int> GetRewardTypeByPKAsync(int itemID, string operatorID, int level, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Level", level, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`RewardType`", "`ItemID` = @ItemID AND `OperatorID` = @OperatorID AND `Level` = @Level", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 FlowMultip（字段）
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "level">等级</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetFlowMultipByPK(int itemID, string operatorID, int level, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Level", level, MySqlDbType.Int32),
			};
			return (int)GetScalar("`FlowMultip`", "`ItemID` = @ItemID AND `OperatorID` = @OperatorID AND `Level` = @Level", paras_, tm_);
		}
		public async Task<int> GetFlowMultipByPKAsync(int itemID, string operatorID, int level, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Level", level, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`FlowMultip`", "`ItemID` = @ItemID AND `OperatorID` = @OperatorID AND `Level` = @Level", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 IssueRule（字段）
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "level">等级</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetIssueRuleByPK(int itemID, string operatorID, int level, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Level", level, MySqlDbType.Int32),
			};
			return (int)GetScalar("`IssueRule`", "`ItemID` = @ItemID AND `OperatorID` = @OperatorID AND `Level` = @Level", paras_, tm_);
		}
		public async Task<int> GetIssueRuleByPKAsync(int itemID, string operatorID, int level, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Level", level, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`IssueRule`", "`ItemID` = @ItemID AND `OperatorID` = @OperatorID AND `Level` = @Level", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ConditionExpr（字段）
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "level">等级</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetConditionExprByPK(int itemID, string operatorID, int level, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Level", level, MySqlDbType.Int32),
			};
			return (string)GetScalar("`ConditionExpr`", "`ItemID` = @ItemID AND `OperatorID` = @OperatorID AND `Level` = @Level", paras_, tm_);
		}
		public async Task<string> GetConditionExprByPKAsync(int itemID, string operatorID, int level, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Level", level, MySqlDbType.Int32),
			};
			return (string)await GetScalarAsync("`ConditionExpr`", "`ItemID` = @ItemID AND `OperatorID` = @OperatorID AND `Level` = @Level", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 JsonParameters（字段）
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "level">等级</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetJsonParametersByPK(int itemID, string operatorID, int level, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Level", level, MySqlDbType.Int32),
			};
			return (string)GetScalar("`JsonParameters`", "`ItemID` = @ItemID AND `OperatorID` = @OperatorID AND `Level` = @Level", paras_, tm_);
		}
		public async Task<string> GetJsonParametersByPKAsync(int itemID, string operatorID, int level, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Level", level, MySqlDbType.Int32),
			};
			return (string)await GetScalarAsync("`JsonParameters`", "`ItemID` = @ItemID AND `OperatorID` = @OperatorID AND `Level` = @Level", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RewardAmount（字段）
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "level">等级</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetRewardAmountByPK(int itemID, string operatorID, int level, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Level", level, MySqlDbType.Int32),
			};
			return (long)GetScalar("`RewardAmount`", "`ItemID` = @ItemID AND `OperatorID` = @OperatorID AND `Level` = @Level", paras_, tm_);
		}
		public async Task<long> GetRewardAmountByPKAsync(int itemID, string operatorID, int level, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Level", level, MySqlDbType.Int32),
			};
			return (long)await GetScalarAsync("`RewardAmount`", "`ItemID` = @ItemID AND `OperatorID` = @OperatorID AND `Level` = @Level", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 IpLimits（字段）
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "level">等级</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetIpLimitsByPK(int itemID, string operatorID, int level, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Level", level, MySqlDbType.Int32),
			};
			return (int)GetScalar("`IpLimits`", "`ItemID` = @ItemID AND `OperatorID` = @OperatorID AND `Level` = @Level", paras_, tm_);
		}
		public async Task<int> GetIpLimitsByPKAsync(int itemID, string operatorID, int level, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Level", level, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`IpLimits`", "`ItemID` = @ItemID AND `OperatorID` = @OperatorID AND `Level` = @Level", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 MaxValue（字段）
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "level">等级</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetMaxValueByPK(int itemID, string operatorID, int level, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Level", level, MySqlDbType.Int32),
			};
			return (int)GetScalar("`MaxValue`", "`ItemID` = @ItemID AND `OperatorID` = @OperatorID AND `Level` = @Level", paras_, tm_);
		}
		public async Task<int> GetMaxValueByPKAsync(int itemID, string operatorID, int level, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Level", level, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`MaxValue`", "`ItemID` = @ItemID AND `OperatorID` = @OperatorID AND `Level` = @Level", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByItemID
		
		/// <summary>
		/// 按 ItemID（字段） 查询
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_rewardEO> GetByItemID(int itemID)
		{
			return GetByItemID(itemID, 0, string.Empty, null);
		}
		public async Task<List<Sat_task_rewardEO>> GetByItemIDAsync(int itemID)
		{
			return await GetByItemIDAsync(itemID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ItemID（字段） 查询
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_rewardEO> GetByItemID(int itemID, TransactionManager tm_)
		{
			return GetByItemID(itemID, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_task_rewardEO>> GetByItemIDAsync(int itemID, TransactionManager tm_)
		{
			return await GetByItemIDAsync(itemID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ItemID（字段） 查询
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_rewardEO> GetByItemID(int itemID, int top_)
		{
			return GetByItemID(itemID, top_, string.Empty, null);
		}
		public async Task<List<Sat_task_rewardEO>> GetByItemIDAsync(int itemID, int top_)
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
		public List<Sat_task_rewardEO> GetByItemID(int itemID, int top_, TransactionManager tm_)
		{
			return GetByItemID(itemID, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_task_rewardEO>> GetByItemIDAsync(int itemID, int top_, TransactionManager tm_)
		{
			return await GetByItemIDAsync(itemID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ItemID（字段） 查询
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_rewardEO> GetByItemID(int itemID, string sort_)
		{
			return GetByItemID(itemID, 0, sort_, null);
		}
		public async Task<List<Sat_task_rewardEO>> GetByItemIDAsync(int itemID, string sort_)
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
		public List<Sat_task_rewardEO> GetByItemID(int itemID, string sort_, TransactionManager tm_)
		{
			return GetByItemID(itemID, 0, sort_, tm_);
		}
		public async Task<List<Sat_task_rewardEO>> GetByItemIDAsync(int itemID, string sort_, TransactionManager tm_)
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
		public List<Sat_task_rewardEO> GetByItemID(int itemID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ItemID` = @ItemID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_task_rewardEO.MapDataReader);
		}
		public async Task<List<Sat_task_rewardEO>> GetByItemIDAsync(int itemID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ItemID` = @ItemID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_task_rewardEO.MapDataReader);
		}
		#endregion // GetByItemID
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_rewardEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<Sat_task_rewardEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_rewardEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_task_rewardEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_rewardEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<Sat_task_rewardEO>> GetByOperatorIDAsync(string operatorID, int top_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_rewardEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_task_rewardEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_rewardEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<Sat_task_rewardEO>> GetByOperatorIDAsync(string operatorID, string sort_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_rewardEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<Sat_task_rewardEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_rewardEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_task_rewardEO.MapDataReader);
		}
		public async Task<List<Sat_task_rewardEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_task_rewardEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByLevel
		
		/// <summary>
		/// 按 Level（字段） 查询
		/// </summary>
		/// /// <param name = "level">等级</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_rewardEO> GetByLevel(int level)
		{
			return GetByLevel(level, 0, string.Empty, null);
		}
		public async Task<List<Sat_task_rewardEO>> GetByLevelAsync(int level)
		{
			return await GetByLevelAsync(level, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Level（字段） 查询
		/// </summary>
		/// /// <param name = "level">等级</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_rewardEO> GetByLevel(int level, TransactionManager tm_)
		{
			return GetByLevel(level, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_task_rewardEO>> GetByLevelAsync(int level, TransactionManager tm_)
		{
			return await GetByLevelAsync(level, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Level（字段） 查询
		/// </summary>
		/// /// <param name = "level">等级</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_rewardEO> GetByLevel(int level, int top_)
		{
			return GetByLevel(level, top_, string.Empty, null);
		}
		public async Task<List<Sat_task_rewardEO>> GetByLevelAsync(int level, int top_)
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
		public List<Sat_task_rewardEO> GetByLevel(int level, int top_, TransactionManager tm_)
		{
			return GetByLevel(level, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_task_rewardEO>> GetByLevelAsync(int level, int top_, TransactionManager tm_)
		{
			return await GetByLevelAsync(level, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Level（字段） 查询
		/// </summary>
		/// /// <param name = "level">等级</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_rewardEO> GetByLevel(int level, string sort_)
		{
			return GetByLevel(level, 0, sort_, null);
		}
		public async Task<List<Sat_task_rewardEO>> GetByLevelAsync(int level, string sort_)
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
		public List<Sat_task_rewardEO> GetByLevel(int level, string sort_, TransactionManager tm_)
		{
			return GetByLevel(level, 0, sort_, tm_);
		}
		public async Task<List<Sat_task_rewardEO>> GetByLevelAsync(int level, string sort_, TransactionManager tm_)
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
		public List<Sat_task_rewardEO> GetByLevel(int level, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Level` = @Level", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Level", level, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_task_rewardEO.MapDataReader);
		}
		public async Task<List<Sat_task_rewardEO>> GetByLevelAsync(int level, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Level` = @Level", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Level", level, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_task_rewardEO.MapDataReader);
		}
		#endregion // GetByLevel
		#region GetByRewardType
		
		/// <summary>
		/// 按 RewardType（字段） 查询
		/// </summary>
		/// /// <param name = "rewardType">奖励类型 0-未知 1-Bonus 2-真金</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_rewardEO> GetByRewardType(int rewardType)
		{
			return GetByRewardType(rewardType, 0, string.Empty, null);
		}
		public async Task<List<Sat_task_rewardEO>> GetByRewardTypeAsync(int rewardType)
		{
			return await GetByRewardTypeAsync(rewardType, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RewardType（字段） 查询
		/// </summary>
		/// /// <param name = "rewardType">奖励类型 0-未知 1-Bonus 2-真金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_rewardEO> GetByRewardType(int rewardType, TransactionManager tm_)
		{
			return GetByRewardType(rewardType, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_task_rewardEO>> GetByRewardTypeAsync(int rewardType, TransactionManager tm_)
		{
			return await GetByRewardTypeAsync(rewardType, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RewardType（字段） 查询
		/// </summary>
		/// /// <param name = "rewardType">奖励类型 0-未知 1-Bonus 2-真金</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_rewardEO> GetByRewardType(int rewardType, int top_)
		{
			return GetByRewardType(rewardType, top_, string.Empty, null);
		}
		public async Task<List<Sat_task_rewardEO>> GetByRewardTypeAsync(int rewardType, int top_)
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
		public List<Sat_task_rewardEO> GetByRewardType(int rewardType, int top_, TransactionManager tm_)
		{
			return GetByRewardType(rewardType, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_task_rewardEO>> GetByRewardTypeAsync(int rewardType, int top_, TransactionManager tm_)
		{
			return await GetByRewardTypeAsync(rewardType, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RewardType（字段） 查询
		/// </summary>
		/// /// <param name = "rewardType">奖励类型 0-未知 1-Bonus 2-真金</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_rewardEO> GetByRewardType(int rewardType, string sort_)
		{
			return GetByRewardType(rewardType, 0, sort_, null);
		}
		public async Task<List<Sat_task_rewardEO>> GetByRewardTypeAsync(int rewardType, string sort_)
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
		public List<Sat_task_rewardEO> GetByRewardType(int rewardType, string sort_, TransactionManager tm_)
		{
			return GetByRewardType(rewardType, 0, sort_, tm_);
		}
		public async Task<List<Sat_task_rewardEO>> GetByRewardTypeAsync(int rewardType, string sort_, TransactionManager tm_)
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
		public List<Sat_task_rewardEO> GetByRewardType(int rewardType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RewardType` = @RewardType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RewardType", rewardType, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_task_rewardEO.MapDataReader);
		}
		public async Task<List<Sat_task_rewardEO>> GetByRewardTypeAsync(int rewardType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RewardType` = @RewardType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RewardType", rewardType, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_task_rewardEO.MapDataReader);
		}
		#endregion // GetByRewardType
		#region GetByFlowMultip
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">流水倍数</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_rewardEO> GetByFlowMultip(int flowMultip)
		{
			return GetByFlowMultip(flowMultip, 0, string.Empty, null);
		}
		public async Task<List<Sat_task_rewardEO>> GetByFlowMultipAsync(int flowMultip)
		{
			return await GetByFlowMultipAsync(flowMultip, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">流水倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_rewardEO> GetByFlowMultip(int flowMultip, TransactionManager tm_)
		{
			return GetByFlowMultip(flowMultip, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_task_rewardEO>> GetByFlowMultipAsync(int flowMultip, TransactionManager tm_)
		{
			return await GetByFlowMultipAsync(flowMultip, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">流水倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_rewardEO> GetByFlowMultip(int flowMultip, int top_)
		{
			return GetByFlowMultip(flowMultip, top_, string.Empty, null);
		}
		public async Task<List<Sat_task_rewardEO>> GetByFlowMultipAsync(int flowMultip, int top_)
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
		public List<Sat_task_rewardEO> GetByFlowMultip(int flowMultip, int top_, TransactionManager tm_)
		{
			return GetByFlowMultip(flowMultip, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_task_rewardEO>> GetByFlowMultipAsync(int flowMultip, int top_, TransactionManager tm_)
		{
			return await GetByFlowMultipAsync(flowMultip, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">流水倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_rewardEO> GetByFlowMultip(int flowMultip, string sort_)
		{
			return GetByFlowMultip(flowMultip, 0, sort_, null);
		}
		public async Task<List<Sat_task_rewardEO>> GetByFlowMultipAsync(int flowMultip, string sort_)
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
		public List<Sat_task_rewardEO> GetByFlowMultip(int flowMultip, string sort_, TransactionManager tm_)
		{
			return GetByFlowMultip(flowMultip, 0, sort_, tm_);
		}
		public async Task<List<Sat_task_rewardEO>> GetByFlowMultipAsync(int flowMultip, string sort_, TransactionManager tm_)
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
		public List<Sat_task_rewardEO> GetByFlowMultip(int flowMultip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FlowMultip` = @FlowMultip", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FlowMultip", flowMultip, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_task_rewardEO.MapDataReader);
		}
		public async Task<List<Sat_task_rewardEO>> GetByFlowMultipAsync(int flowMultip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FlowMultip` = @FlowMultip", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FlowMultip", flowMultip, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_task_rewardEO.MapDataReader);
		}
		#endregion // GetByFlowMultip
		#region GetByIssueRule
		
		/// <summary>
		/// 按 IssueRule（字段） 查询
		/// </summary>
		/// /// <param name = "issueRule">发放规则,0-未知 1-固定金额 2-按权重 3-随机抽取</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_rewardEO> GetByIssueRule(int issueRule)
		{
			return GetByIssueRule(issueRule, 0, string.Empty, null);
		}
		public async Task<List<Sat_task_rewardEO>> GetByIssueRuleAsync(int issueRule)
		{
			return await GetByIssueRuleAsync(issueRule, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IssueRule（字段） 查询
		/// </summary>
		/// /// <param name = "issueRule">发放规则,0-未知 1-固定金额 2-按权重 3-随机抽取</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_rewardEO> GetByIssueRule(int issueRule, TransactionManager tm_)
		{
			return GetByIssueRule(issueRule, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_task_rewardEO>> GetByIssueRuleAsync(int issueRule, TransactionManager tm_)
		{
			return await GetByIssueRuleAsync(issueRule, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IssueRule（字段） 查询
		/// </summary>
		/// /// <param name = "issueRule">发放规则,0-未知 1-固定金额 2-按权重 3-随机抽取</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_rewardEO> GetByIssueRule(int issueRule, int top_)
		{
			return GetByIssueRule(issueRule, top_, string.Empty, null);
		}
		public async Task<List<Sat_task_rewardEO>> GetByIssueRuleAsync(int issueRule, int top_)
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
		public List<Sat_task_rewardEO> GetByIssueRule(int issueRule, int top_, TransactionManager tm_)
		{
			return GetByIssueRule(issueRule, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_task_rewardEO>> GetByIssueRuleAsync(int issueRule, int top_, TransactionManager tm_)
		{
			return await GetByIssueRuleAsync(issueRule, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IssueRule（字段） 查询
		/// </summary>
		/// /// <param name = "issueRule">发放规则,0-未知 1-固定金额 2-按权重 3-随机抽取</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_rewardEO> GetByIssueRule(int issueRule, string sort_)
		{
			return GetByIssueRule(issueRule, 0, sort_, null);
		}
		public async Task<List<Sat_task_rewardEO>> GetByIssueRuleAsync(int issueRule, string sort_)
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
		public List<Sat_task_rewardEO> GetByIssueRule(int issueRule, string sort_, TransactionManager tm_)
		{
			return GetByIssueRule(issueRule, 0, sort_, tm_);
		}
		public async Task<List<Sat_task_rewardEO>> GetByIssueRuleAsync(int issueRule, string sort_, TransactionManager tm_)
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
		public List<Sat_task_rewardEO> GetByIssueRule(int issueRule, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IssueRule` = @IssueRule", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IssueRule", issueRule, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_task_rewardEO.MapDataReader);
		}
		public async Task<List<Sat_task_rewardEO>> GetByIssueRuleAsync(int issueRule, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IssueRule` = @IssueRule", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IssueRule", issueRule, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_task_rewardEO.MapDataReader);
		}
		#endregion // GetByIssueRule
		#region GetByConditionExpr
		
		/// <summary>
		/// 按 ConditionExpr（字段） 查询
		/// </summary>
		/// /// <param name = "conditionExpr">奖励条件表达式, 有值才会执行规则,没有值则在对应action中进行处理</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_rewardEO> GetByConditionExpr(string conditionExpr)
		{
			return GetByConditionExpr(conditionExpr, 0, string.Empty, null);
		}
		public async Task<List<Sat_task_rewardEO>> GetByConditionExprAsync(string conditionExpr)
		{
			return await GetByConditionExprAsync(conditionExpr, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ConditionExpr（字段） 查询
		/// </summary>
		/// /// <param name = "conditionExpr">奖励条件表达式, 有值才会执行规则,没有值则在对应action中进行处理</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_rewardEO> GetByConditionExpr(string conditionExpr, TransactionManager tm_)
		{
			return GetByConditionExpr(conditionExpr, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_task_rewardEO>> GetByConditionExprAsync(string conditionExpr, TransactionManager tm_)
		{
			return await GetByConditionExprAsync(conditionExpr, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ConditionExpr（字段） 查询
		/// </summary>
		/// /// <param name = "conditionExpr">奖励条件表达式, 有值才会执行规则,没有值则在对应action中进行处理</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_rewardEO> GetByConditionExpr(string conditionExpr, int top_)
		{
			return GetByConditionExpr(conditionExpr, top_, string.Empty, null);
		}
		public async Task<List<Sat_task_rewardEO>> GetByConditionExprAsync(string conditionExpr, int top_)
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
		public List<Sat_task_rewardEO> GetByConditionExpr(string conditionExpr, int top_, TransactionManager tm_)
		{
			return GetByConditionExpr(conditionExpr, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_task_rewardEO>> GetByConditionExprAsync(string conditionExpr, int top_, TransactionManager tm_)
		{
			return await GetByConditionExprAsync(conditionExpr, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ConditionExpr（字段） 查询
		/// </summary>
		/// /// <param name = "conditionExpr">奖励条件表达式, 有值才会执行规则,没有值则在对应action中进行处理</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_rewardEO> GetByConditionExpr(string conditionExpr, string sort_)
		{
			return GetByConditionExpr(conditionExpr, 0, sort_, null);
		}
		public async Task<List<Sat_task_rewardEO>> GetByConditionExprAsync(string conditionExpr, string sort_)
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
		public List<Sat_task_rewardEO> GetByConditionExpr(string conditionExpr, string sort_, TransactionManager tm_)
		{
			return GetByConditionExpr(conditionExpr, 0, sort_, tm_);
		}
		public async Task<List<Sat_task_rewardEO>> GetByConditionExprAsync(string conditionExpr, string sort_, TransactionManager tm_)
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
		public List<Sat_task_rewardEO> GetByConditionExpr(string conditionExpr, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(conditionExpr != null ? "`ConditionExpr` = @ConditionExpr" : "`ConditionExpr` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (conditionExpr != null)
				paras_.Add(Database.CreateInParameter("@ConditionExpr", conditionExpr, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_task_rewardEO.MapDataReader);
		}
		public async Task<List<Sat_task_rewardEO>> GetByConditionExprAsync(string conditionExpr, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(conditionExpr != null ? "`ConditionExpr` = @ConditionExpr" : "`ConditionExpr` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (conditionExpr != null)
				paras_.Add(Database.CreateInParameter("@ConditionExpr", conditionExpr, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_task_rewardEO.MapDataReader);
		}
		#endregion // GetByConditionExpr
		#region GetByJsonParameters
		
		/// <summary>
		/// 按 JsonParameters（字段） 查询
		/// </summary>
		/// /// <param name = "jsonParameters">条件参数, json格式, 用于任务中心显示</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_rewardEO> GetByJsonParameters(string jsonParameters)
		{
			return GetByJsonParameters(jsonParameters, 0, string.Empty, null);
		}
		public async Task<List<Sat_task_rewardEO>> GetByJsonParametersAsync(string jsonParameters)
		{
			return await GetByJsonParametersAsync(jsonParameters, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 JsonParameters（字段） 查询
		/// </summary>
		/// /// <param name = "jsonParameters">条件参数, json格式, 用于任务中心显示</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_rewardEO> GetByJsonParameters(string jsonParameters, TransactionManager tm_)
		{
			return GetByJsonParameters(jsonParameters, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_task_rewardEO>> GetByJsonParametersAsync(string jsonParameters, TransactionManager tm_)
		{
			return await GetByJsonParametersAsync(jsonParameters, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 JsonParameters（字段） 查询
		/// </summary>
		/// /// <param name = "jsonParameters">条件参数, json格式, 用于任务中心显示</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_rewardEO> GetByJsonParameters(string jsonParameters, int top_)
		{
			return GetByJsonParameters(jsonParameters, top_, string.Empty, null);
		}
		public async Task<List<Sat_task_rewardEO>> GetByJsonParametersAsync(string jsonParameters, int top_)
		{
			return await GetByJsonParametersAsync(jsonParameters, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 JsonParameters（字段） 查询
		/// </summary>
		/// /// <param name = "jsonParameters">条件参数, json格式, 用于任务中心显示</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_rewardEO> GetByJsonParameters(string jsonParameters, int top_, TransactionManager tm_)
		{
			return GetByJsonParameters(jsonParameters, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_task_rewardEO>> GetByJsonParametersAsync(string jsonParameters, int top_, TransactionManager tm_)
		{
			return await GetByJsonParametersAsync(jsonParameters, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 JsonParameters（字段） 查询
		/// </summary>
		/// /// <param name = "jsonParameters">条件参数, json格式, 用于任务中心显示</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_rewardEO> GetByJsonParameters(string jsonParameters, string sort_)
		{
			return GetByJsonParameters(jsonParameters, 0, sort_, null);
		}
		public async Task<List<Sat_task_rewardEO>> GetByJsonParametersAsync(string jsonParameters, string sort_)
		{
			return await GetByJsonParametersAsync(jsonParameters, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 JsonParameters（字段） 查询
		/// </summary>
		/// /// <param name = "jsonParameters">条件参数, json格式, 用于任务中心显示</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_rewardEO> GetByJsonParameters(string jsonParameters, string sort_, TransactionManager tm_)
		{
			return GetByJsonParameters(jsonParameters, 0, sort_, tm_);
		}
		public async Task<List<Sat_task_rewardEO>> GetByJsonParametersAsync(string jsonParameters, string sort_, TransactionManager tm_)
		{
			return await GetByJsonParametersAsync(jsonParameters, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 JsonParameters（字段） 查询
		/// </summary>
		/// /// <param name = "jsonParameters">条件参数, json格式, 用于任务中心显示</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_rewardEO> GetByJsonParameters(string jsonParameters, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(jsonParameters != null ? "`JsonParameters` = @JsonParameters" : "`JsonParameters` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (jsonParameters != null)
				paras_.Add(Database.CreateInParameter("@JsonParameters", jsonParameters, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_task_rewardEO.MapDataReader);
		}
		public async Task<List<Sat_task_rewardEO>> GetByJsonParametersAsync(string jsonParameters, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(jsonParameters != null ? "`JsonParameters` = @JsonParameters" : "`JsonParameters` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (jsonParameters != null)
				paras_.Add(Database.CreateInParameter("@JsonParameters", jsonParameters, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_task_rewardEO.MapDataReader);
		}
		#endregion // GetByJsonParameters
		#region GetByRewardAmount
		
		/// <summary>
		/// 按 RewardAmount（字段） 查询
		/// </summary>
		/// /// <param name = "rewardAmount">奖励金额, 发放规则为固定金额时有效</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_rewardEO> GetByRewardAmount(long rewardAmount)
		{
			return GetByRewardAmount(rewardAmount, 0, string.Empty, null);
		}
		public async Task<List<Sat_task_rewardEO>> GetByRewardAmountAsync(long rewardAmount)
		{
			return await GetByRewardAmountAsync(rewardAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RewardAmount（字段） 查询
		/// </summary>
		/// /// <param name = "rewardAmount">奖励金额, 发放规则为固定金额时有效</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_rewardEO> GetByRewardAmount(long rewardAmount, TransactionManager tm_)
		{
			return GetByRewardAmount(rewardAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_task_rewardEO>> GetByRewardAmountAsync(long rewardAmount, TransactionManager tm_)
		{
			return await GetByRewardAmountAsync(rewardAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RewardAmount（字段） 查询
		/// </summary>
		/// /// <param name = "rewardAmount">奖励金额, 发放规则为固定金额时有效</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_rewardEO> GetByRewardAmount(long rewardAmount, int top_)
		{
			return GetByRewardAmount(rewardAmount, top_, string.Empty, null);
		}
		public async Task<List<Sat_task_rewardEO>> GetByRewardAmountAsync(long rewardAmount, int top_)
		{
			return await GetByRewardAmountAsync(rewardAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RewardAmount（字段） 查询
		/// </summary>
		/// /// <param name = "rewardAmount">奖励金额, 发放规则为固定金额时有效</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_rewardEO> GetByRewardAmount(long rewardAmount, int top_, TransactionManager tm_)
		{
			return GetByRewardAmount(rewardAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_task_rewardEO>> GetByRewardAmountAsync(long rewardAmount, int top_, TransactionManager tm_)
		{
			return await GetByRewardAmountAsync(rewardAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RewardAmount（字段） 查询
		/// </summary>
		/// /// <param name = "rewardAmount">奖励金额, 发放规则为固定金额时有效</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_rewardEO> GetByRewardAmount(long rewardAmount, string sort_)
		{
			return GetByRewardAmount(rewardAmount, 0, sort_, null);
		}
		public async Task<List<Sat_task_rewardEO>> GetByRewardAmountAsync(long rewardAmount, string sort_)
		{
			return await GetByRewardAmountAsync(rewardAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RewardAmount（字段） 查询
		/// </summary>
		/// /// <param name = "rewardAmount">奖励金额, 发放规则为固定金额时有效</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_rewardEO> GetByRewardAmount(long rewardAmount, string sort_, TransactionManager tm_)
		{
			return GetByRewardAmount(rewardAmount, 0, sort_, tm_);
		}
		public async Task<List<Sat_task_rewardEO>> GetByRewardAmountAsync(long rewardAmount, string sort_, TransactionManager tm_)
		{
			return await GetByRewardAmountAsync(rewardAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RewardAmount（字段） 查询
		/// </summary>
		/// /// <param name = "rewardAmount">奖励金额, 发放规则为固定金额时有效</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_rewardEO> GetByRewardAmount(long rewardAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RewardAmount` = @RewardAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RewardAmount", rewardAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_task_rewardEO.MapDataReader);
		}
		public async Task<List<Sat_task_rewardEO>> GetByRewardAmountAsync(long rewardAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RewardAmount` = @RewardAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RewardAmount", rewardAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_task_rewardEO.MapDataReader);
		}
		#endregion // GetByRewardAmount
		#region GetByIpLimits
		
		/// <summary>
		/// 按 IpLimits（字段） 查询
		/// </summary>
		/// /// <param name = "ipLimits">IP地址限制</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_rewardEO> GetByIpLimits(int ipLimits)
		{
			return GetByIpLimits(ipLimits, 0, string.Empty, null);
		}
		public async Task<List<Sat_task_rewardEO>> GetByIpLimitsAsync(int ipLimits)
		{
			return await GetByIpLimitsAsync(ipLimits, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IpLimits（字段） 查询
		/// </summary>
		/// /// <param name = "ipLimits">IP地址限制</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_rewardEO> GetByIpLimits(int ipLimits, TransactionManager tm_)
		{
			return GetByIpLimits(ipLimits, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_task_rewardEO>> GetByIpLimitsAsync(int ipLimits, TransactionManager tm_)
		{
			return await GetByIpLimitsAsync(ipLimits, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IpLimits（字段） 查询
		/// </summary>
		/// /// <param name = "ipLimits">IP地址限制</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_rewardEO> GetByIpLimits(int ipLimits, int top_)
		{
			return GetByIpLimits(ipLimits, top_, string.Empty, null);
		}
		public async Task<List<Sat_task_rewardEO>> GetByIpLimitsAsync(int ipLimits, int top_)
		{
			return await GetByIpLimitsAsync(ipLimits, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IpLimits（字段） 查询
		/// </summary>
		/// /// <param name = "ipLimits">IP地址限制</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_rewardEO> GetByIpLimits(int ipLimits, int top_, TransactionManager tm_)
		{
			return GetByIpLimits(ipLimits, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_task_rewardEO>> GetByIpLimitsAsync(int ipLimits, int top_, TransactionManager tm_)
		{
			return await GetByIpLimitsAsync(ipLimits, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IpLimits（字段） 查询
		/// </summary>
		/// /// <param name = "ipLimits">IP地址限制</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_rewardEO> GetByIpLimits(int ipLimits, string sort_)
		{
			return GetByIpLimits(ipLimits, 0, sort_, null);
		}
		public async Task<List<Sat_task_rewardEO>> GetByIpLimitsAsync(int ipLimits, string sort_)
		{
			return await GetByIpLimitsAsync(ipLimits, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 IpLimits（字段） 查询
		/// </summary>
		/// /// <param name = "ipLimits">IP地址限制</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_rewardEO> GetByIpLimits(int ipLimits, string sort_, TransactionManager tm_)
		{
			return GetByIpLimits(ipLimits, 0, sort_, tm_);
		}
		public async Task<List<Sat_task_rewardEO>> GetByIpLimitsAsync(int ipLimits, string sort_, TransactionManager tm_)
		{
			return await GetByIpLimitsAsync(ipLimits, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 IpLimits（字段） 查询
		/// </summary>
		/// /// <param name = "ipLimits">IP地址限制</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_rewardEO> GetByIpLimits(int ipLimits, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IpLimits` = @IpLimits", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IpLimits", ipLimits, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_task_rewardEO.MapDataReader);
		}
		public async Task<List<Sat_task_rewardEO>> GetByIpLimitsAsync(int ipLimits, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IpLimits` = @IpLimits", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IpLimits", ipLimits, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_task_rewardEO.MapDataReader);
		}
		#endregion // GetByIpLimits
		#region GetByMaxValue
		
		/// <summary>
		/// 按 MaxValue（字段） 查询
		/// </summary>
		/// /// <param name = "maxValue">进度最大值 钱是Money，除以10000后的数字</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_rewardEO> GetByMaxValue(int maxValue)
		{
			return GetByMaxValue(maxValue, 0, string.Empty, null);
		}
		public async Task<List<Sat_task_rewardEO>> GetByMaxValueAsync(int maxValue)
		{
			return await GetByMaxValueAsync(maxValue, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MaxValue（字段） 查询
		/// </summary>
		/// /// <param name = "maxValue">进度最大值 钱是Money，除以10000后的数字</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_rewardEO> GetByMaxValue(int maxValue, TransactionManager tm_)
		{
			return GetByMaxValue(maxValue, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_task_rewardEO>> GetByMaxValueAsync(int maxValue, TransactionManager tm_)
		{
			return await GetByMaxValueAsync(maxValue, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MaxValue（字段） 查询
		/// </summary>
		/// /// <param name = "maxValue">进度最大值 钱是Money，除以10000后的数字</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_rewardEO> GetByMaxValue(int maxValue, int top_)
		{
			return GetByMaxValue(maxValue, top_, string.Empty, null);
		}
		public async Task<List<Sat_task_rewardEO>> GetByMaxValueAsync(int maxValue, int top_)
		{
			return await GetByMaxValueAsync(maxValue, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MaxValue（字段） 查询
		/// </summary>
		/// /// <param name = "maxValue">进度最大值 钱是Money，除以10000后的数字</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_rewardEO> GetByMaxValue(int maxValue, int top_, TransactionManager tm_)
		{
			return GetByMaxValue(maxValue, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_task_rewardEO>> GetByMaxValueAsync(int maxValue, int top_, TransactionManager tm_)
		{
			return await GetByMaxValueAsync(maxValue, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MaxValue（字段） 查询
		/// </summary>
		/// /// <param name = "maxValue">进度最大值 钱是Money，除以10000后的数字</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_rewardEO> GetByMaxValue(int maxValue, string sort_)
		{
			return GetByMaxValue(maxValue, 0, sort_, null);
		}
		public async Task<List<Sat_task_rewardEO>> GetByMaxValueAsync(int maxValue, string sort_)
		{
			return await GetByMaxValueAsync(maxValue, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 MaxValue（字段） 查询
		/// </summary>
		/// /// <param name = "maxValue">进度最大值 钱是Money，除以10000后的数字</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_rewardEO> GetByMaxValue(int maxValue, string sort_, TransactionManager tm_)
		{
			return GetByMaxValue(maxValue, 0, sort_, tm_);
		}
		public async Task<List<Sat_task_rewardEO>> GetByMaxValueAsync(int maxValue, string sort_, TransactionManager tm_)
		{
			return await GetByMaxValueAsync(maxValue, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 MaxValue（字段） 查询
		/// </summary>
		/// /// <param name = "maxValue">进度最大值 钱是Money，除以10000后的数字</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_rewardEO> GetByMaxValue(int maxValue, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`MaxValue` = @MaxValue", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MaxValue", maxValue, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_task_rewardEO.MapDataReader);
		}
		public async Task<List<Sat_task_rewardEO>> GetByMaxValueAsync(int maxValue, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`MaxValue` = @MaxValue", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MaxValue", maxValue, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_task_rewardEO.MapDataReader);
		}
		#endregion // GetByMaxValue
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
