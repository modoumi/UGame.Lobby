/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * AiUo代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/AiUo
 * 文档生成时间：2023-10-24 18: 05:08
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
	/// 工具运营商表，描述运营商工具配置
	/// 【表 sat_item_operator 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Sat_item_operatorEO : IRowMapper<Sat_item_operatorEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Sat_item_operatorEO()
		{
			this.Status = 0;
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
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "ItemID", ItemID },  { "OperatorID", OperatorID }, };
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
		/// Cron表达式, 触发类型为自主定时时有效
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 3)]
		public string CronExpr { get; set; }
		/// <summary>
		/// 起始日期（默认2016-01-01）
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 4)]
		public DateTime BeginDate { get; set; }
		/// <summary>
		/// 截止日期（默认2099-01-01）
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 5)]
		public DateTime EndDate { get; set; }
		/// <summary>
		/// 状态(0-无效1-有效)
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 6)]
		public int Status { get; set; }
		/// <summary>
		/// 记录日期
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 7)]
		public DateTime RecDate { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Sat_item_operatorEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Sat_item_operatorEO MapDataReader(IDataReader reader)
		{
		    Sat_item_operatorEO ret = new Sat_item_operatorEO();
			ret.ItemID = reader.ToInt32("ItemID");
			ret.OriginalItemID = ret.ItemID;
			ret.OperatorID = reader.ToString("OperatorID");
			ret.OriginalOperatorID = ret.OperatorID;
			ret.CronExpr = reader.ToString("CronExpr");
			ret.BeginDate = reader.ToDateTime("BeginDate");
			ret.EndDate = reader.ToDateTime("EndDate");
			ret.Status = reader.ToInt32("Status");
			ret.RecDate = reader.ToDateTime("RecDate");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 工具运营商表，描述运营商工具配置
	/// 【表 sat_item_operator 的操作类】
	/// </summary>
	[Obsolete]
	public class Sat_item_operatorMO : MySqlTableMO<Sat_item_operatorEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`sat_item_operator`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Sat_item_operatorMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Sat_item_operatorMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Sat_item_operatorMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Sat_item_operatorEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Sat_item_operatorEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Sat_item_operatorEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`ItemID`, `OperatorID`, `CronExpr`, `BeginDate`, `EndDate`, `Status`, `RecDate`) VALUE (@ItemID, @OperatorID, @CronExpr, @BeginDate, @EndDate, @Status, @RecDate);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", item.ItemID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CronExpr", item.CronExpr != null ? item.CronExpr : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@BeginDate", item.BeginDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@EndDate", item.EndDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@Status", item.Status, MySqlDbType.Int32),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
			};
		}
		public int AddByBatch(IEnumerable<Sat_item_operatorEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Sat_item_operatorEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sat_item_operatorEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`ItemID`, `OperatorID`, `CronExpr`, `BeginDate`, `EndDate`, `Status`, `RecDate`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"({item.ItemID},'{item.OperatorID}','{item.CronExpr}','{item.BeginDate.ToString("yyyy-MM-dd HH:mm:ss")}','{item.EndDate.ToString("yyyy-MM-dd HH:mm:ss")}',{item.Status},'{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(int itemID, string operatorID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(itemID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(int itemID, string operatorID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(itemID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(int itemID, string operatorID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `ItemID` = @ItemID AND `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Sat_item_operatorEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.ItemID, item.OperatorID, tm_);
		}
		public async Task<int> RemoveAsync(Sat_item_operatorEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.ItemID, item.OperatorID, tm_);
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
		#region RemoveByCronExpr
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "cronExpr">Cron表达式, 触发类型为自主定时时有效</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCronExpr(string cronExpr, TransactionManager tm_ = null)
		{
			RepairRemoveByCronExprData(cronExpr, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCronExprAsync(string cronExpr, TransactionManager tm_ = null)
		{
			RepairRemoveByCronExprData(cronExpr, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCronExprData(string cronExpr, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (cronExpr != null ? "`CronExpr` = @CronExpr" : "`CronExpr` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (cronExpr != null)
				paras_.Add(Database.CreateInParameter("@CronExpr", cronExpr, MySqlDbType.VarChar));
		}
		#endregion // RemoveByCronExpr
		#region RemoveByBeginDate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "beginDate">起始日期（默认2016-01-01）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByBeginDate(DateTime beginDate, TransactionManager tm_ = null)
		{
			RepairRemoveByBeginDateData(beginDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByBeginDateAsync(DateTime beginDate, TransactionManager tm_ = null)
		{
			RepairRemoveByBeginDateData(beginDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByBeginDateData(DateTime beginDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `BeginDate` = @BeginDate";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BeginDate", beginDate, MySqlDbType.DateTime));
		}
		#endregion // RemoveByBeginDate
		#region RemoveByEndDate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "endDate">截止日期（默认2099-01-01）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByEndDate(DateTime endDate, TransactionManager tm_ = null)
		{
			RepairRemoveByEndDateData(endDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByEndDateAsync(DateTime endDate, TransactionManager tm_ = null)
		{
			RepairRemoveByEndDateData(endDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByEndDateData(DateTime endDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `EndDate` = @EndDate";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@EndDate", endDate, MySqlDbType.DateTime));
		}
		#endregion // RemoveByEndDate
		#region RemoveByStatus
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByStatus(int status, TransactionManager tm_ = null)
		{
			RepairRemoveByStatusData(status, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByStatusAsync(int status, TransactionManager tm_ = null)
		{
			RepairRemoveByStatusData(status, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByStatusData(int status, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Status` = @Status";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
		}
		#endregion // RemoveByStatus
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
		public int Put(Sat_item_operatorEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Sat_item_operatorEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Sat_item_operatorEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ItemID` = @ItemID, `OperatorID` = @OperatorID, `CronExpr` = @CronExpr, `BeginDate` = @BeginDate, `EndDate` = @EndDate, `Status` = @Status, `RecDate` = @RecDate WHERE `ItemID` = @ItemID_Original AND `OperatorID` = @OperatorID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", item.ItemID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CronExpr", item.CronExpr != null ? item.CronExpr : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@BeginDate", item.BeginDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@EndDate", item.EndDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@Status", item.Status, MySqlDbType.Int32),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@ItemID_Original", item.HasOriginal ? item.OriginalItemID : item.ItemID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID_Original", item.HasOriginal ? item.OriginalOperatorID : item.OperatorID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Sat_item_operatorEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Sat_item_operatorEO> items, TransactionManager tm_ = null)
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
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int itemID, string operatorID, string set_, params object[] values_)
		{
			return Put(set_, "`ItemID` = @ItemID AND `OperatorID` = @OperatorID", ConcatValues(values_, itemID, operatorID));
		}
		public async Task<int> PutByPKAsync(int itemID, string operatorID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`ItemID` = @ItemID AND `OperatorID` = @OperatorID", ConcatValues(values_, itemID, operatorID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int itemID, string operatorID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`ItemID` = @ItemID AND `OperatorID` = @OperatorID", tm_, ConcatValues(values_, itemID, operatorID));
		}
		public async Task<int> PutByPKAsync(int itemID, string operatorID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`ItemID` = @ItemID AND `OperatorID` = @OperatorID", tm_, ConcatValues(values_, itemID, operatorID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int itemID, string operatorID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`ItemID` = @ItemID AND `OperatorID` = @OperatorID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(int itemID, string operatorID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`ItemID` = @ItemID AND `OperatorID` = @OperatorID", ConcatParameters(paras_, newParas_), tm_);
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
		#region PutCronExpr
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "cronExpr">Cron表达式, 触发类型为自主定时时有效</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCronExprByPK(int itemID, string operatorID, string cronExpr, TransactionManager tm_ = null)
		{
			RepairPutCronExprByPKData(itemID, operatorID, cronExpr, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCronExprByPKAsync(int itemID, string operatorID, string cronExpr, TransactionManager tm_ = null)
		{
			RepairPutCronExprByPKData(itemID, operatorID, cronExpr, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCronExprByPKData(int itemID, string operatorID, string cronExpr, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CronExpr` = @CronExpr  WHERE `ItemID` = @ItemID AND `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CronExpr", cronExpr != null ? cronExpr : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "cronExpr">Cron表达式, 触发类型为自主定时时有效</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCronExpr(string cronExpr, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CronExpr` = @CronExpr";
			var parameter_ = Database.CreateInParameter("@CronExpr", cronExpr != null ? cronExpr : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCronExprAsync(string cronExpr, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CronExpr` = @CronExpr";
			var parameter_ = Database.CreateInParameter("@CronExpr", cronExpr != null ? cronExpr : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCronExpr
		#region PutBeginDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "beginDate">起始日期（默认2016-01-01）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBeginDateByPK(int itemID, string operatorID, DateTime beginDate, TransactionManager tm_ = null)
		{
			RepairPutBeginDateByPKData(itemID, operatorID, beginDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBeginDateByPKAsync(int itemID, string operatorID, DateTime beginDate, TransactionManager tm_ = null)
		{
			RepairPutBeginDateByPKData(itemID, operatorID, beginDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBeginDateByPKData(int itemID, string operatorID, DateTime beginDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BeginDate` = @BeginDate  WHERE `ItemID` = @ItemID AND `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BeginDate", beginDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "beginDate">起始日期（默认2016-01-01）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBeginDate(DateTime beginDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BeginDate` = @BeginDate";
			var parameter_ = Database.CreateInParameter("@BeginDate", beginDate, MySqlDbType.DateTime);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutBeginDateAsync(DateTime beginDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BeginDate` = @BeginDate";
			var parameter_ = Database.CreateInParameter("@BeginDate", beginDate, MySqlDbType.DateTime);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutBeginDate
		#region PutEndDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "endDate">截止日期（默认2099-01-01）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutEndDateByPK(int itemID, string operatorID, DateTime endDate, TransactionManager tm_ = null)
		{
			RepairPutEndDateByPKData(itemID, operatorID, endDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutEndDateByPKAsync(int itemID, string operatorID, DateTime endDate, TransactionManager tm_ = null)
		{
			RepairPutEndDateByPKData(itemID, operatorID, endDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutEndDateByPKData(int itemID, string operatorID, DateTime endDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `EndDate` = @EndDate  WHERE `ItemID` = @ItemID AND `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@EndDate", endDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "endDate">截止日期（默认2099-01-01）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutEndDate(DateTime endDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `EndDate` = @EndDate";
			var parameter_ = Database.CreateInParameter("@EndDate", endDate, MySqlDbType.DateTime);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutEndDateAsync(DateTime endDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `EndDate` = @EndDate";
			var parameter_ = Database.CreateInParameter("@EndDate", endDate, MySqlDbType.DateTime);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutEndDate
		#region PutStatus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutStatusByPK(int itemID, string operatorID, int status, TransactionManager tm_ = null)
		{
			RepairPutStatusByPKData(itemID, operatorID, status, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutStatusByPKAsync(int itemID, string operatorID, int status, TransactionManager tm_ = null)
		{
			RepairPutStatusByPKData(itemID, operatorID, status, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutStatusByPKData(int itemID, string operatorID, int status, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Status` = @Status  WHERE `ItemID` = @ItemID AND `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Status", status, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutStatus(int status, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Status` = @Status";
			var parameter_ = Database.CreateInParameter("@Status", status, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutStatusAsync(int status, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Status` = @Status";
			var parameter_ = Database.CreateInParameter("@Status", status, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutStatus
		#region PutRecDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "recDate">记录日期</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(int itemID, string operatorID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(itemID, operatorID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(int itemID, string operatorID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(itemID, operatorID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(int itemID, string operatorID, DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `ItemID` = @ItemID AND `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
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
		public bool Set(Sat_item_operatorEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.ItemID, item.OperatorID) == null)
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
		public async Task<bool> SetAsync(Sat_item_operatorEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.ItemID, item.OperatorID) == null)
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
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Sat_item_operatorEO GetByPK(int itemID, string operatorID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(itemID, operatorID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sat_item_operatorEO.MapDataReader);
		}
		public async Task<Sat_item_operatorEO> GetByPKAsync(int itemID, string operatorID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(itemID, operatorID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sat_item_operatorEO.MapDataReader);
		}
		private void RepairGetByPKData(int itemID, string operatorID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`ItemID` = @ItemID AND `OperatorID` = @OperatorID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 ItemID（字段）
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetItemIDByPK(int itemID, string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`ItemID`", "`ItemID` = @ItemID AND `OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<int> GetItemIDByPKAsync(int itemID, string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`ItemID`", "`ItemID` = @ItemID AND `OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OperatorID（字段）
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorIDByPK(int itemID, string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OperatorID`", "`ItemID` = @ItemID AND `OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<string> GetOperatorIDByPKAsync(int itemID, string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OperatorID`", "`ItemID` = @ItemID AND `OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CronExpr（字段）
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCronExprByPK(int itemID, string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CronExpr`", "`ItemID` = @ItemID AND `OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<string> GetCronExprByPKAsync(int itemID, string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CronExpr`", "`ItemID` = @ItemID AND `OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 BeginDate（字段）
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetBeginDateByPK(int itemID, string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`BeginDate`", "`ItemID` = @ItemID AND `OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<DateTime> GetBeginDateByPKAsync(int itemID, string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`BeginDate`", "`ItemID` = @ItemID AND `OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 EndDate（字段）
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetEndDateByPK(int itemID, string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`EndDate`", "`ItemID` = @ItemID AND `OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<DateTime> GetEndDateByPKAsync(int itemID, string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`EndDate`", "`ItemID` = @ItemID AND `OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Status（字段）
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetStatusByPK(int itemID, string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`Status`", "`ItemID` = @ItemID AND `OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<int> GetStatusByPKAsync(int itemID, string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`Status`", "`ItemID` = @ItemID AND `OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetRecDateByPK(int itemID, string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`RecDate`", "`ItemID` = @ItemID AND `OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<DateTime> GetRecDateByPKAsync(int itemID, string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`RecDate`", "`ItemID` = @ItemID AND `OperatorID` = @OperatorID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByItemID
		
		/// <summary>
		/// 按 ItemID（字段） 查询
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// <return>实体对象集合</return>
		public List<Sat_item_operatorEO> GetByItemID(int itemID)
		{
			return GetByItemID(itemID, 0, string.Empty, null);
		}
		public async Task<List<Sat_item_operatorEO>> GetByItemIDAsync(int itemID)
		{
			return await GetByItemIDAsync(itemID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ItemID（字段） 查询
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_item_operatorEO> GetByItemID(int itemID, TransactionManager tm_)
		{
			return GetByItemID(itemID, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_item_operatorEO>> GetByItemIDAsync(int itemID, TransactionManager tm_)
		{
			return await GetByItemIDAsync(itemID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ItemID（字段） 查询
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_item_operatorEO> GetByItemID(int itemID, int top_)
		{
			return GetByItemID(itemID, top_, string.Empty, null);
		}
		public async Task<List<Sat_item_operatorEO>> GetByItemIDAsync(int itemID, int top_)
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
		public List<Sat_item_operatorEO> GetByItemID(int itemID, int top_, TransactionManager tm_)
		{
			return GetByItemID(itemID, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_item_operatorEO>> GetByItemIDAsync(int itemID, int top_, TransactionManager tm_)
		{
			return await GetByItemIDAsync(itemID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ItemID（字段） 查询
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_item_operatorEO> GetByItemID(int itemID, string sort_)
		{
			return GetByItemID(itemID, 0, sort_, null);
		}
		public async Task<List<Sat_item_operatorEO>> GetByItemIDAsync(int itemID, string sort_)
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
		public List<Sat_item_operatorEO> GetByItemID(int itemID, string sort_, TransactionManager tm_)
		{
			return GetByItemID(itemID, 0, sort_, tm_);
		}
		public async Task<List<Sat_item_operatorEO>> GetByItemIDAsync(int itemID, string sort_, TransactionManager tm_)
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
		public List<Sat_item_operatorEO> GetByItemID(int itemID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ItemID` = @ItemID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_item_operatorEO.MapDataReader);
		}
		public async Task<List<Sat_item_operatorEO>> GetByItemIDAsync(int itemID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ItemID` = @ItemID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_item_operatorEO.MapDataReader);
		}
		#endregion // GetByItemID
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <return>实体对象集合</return>
		public List<Sat_item_operatorEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<Sat_item_operatorEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_item_operatorEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_item_operatorEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_item_operatorEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<Sat_item_operatorEO>> GetByOperatorIDAsync(string operatorID, int top_)
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
		public List<Sat_item_operatorEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_item_operatorEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_item_operatorEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<Sat_item_operatorEO>> GetByOperatorIDAsync(string operatorID, string sort_)
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
		public List<Sat_item_operatorEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<Sat_item_operatorEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
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
		public List<Sat_item_operatorEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_item_operatorEO.MapDataReader);
		}
		public async Task<List<Sat_item_operatorEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_item_operatorEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByCronExpr
		
		/// <summary>
		/// 按 CronExpr（字段） 查询
		/// </summary>
		/// /// <param name = "cronExpr">Cron表达式, 触发类型为自主定时时有效</param>
		/// <return>实体对象集合</return>
		public List<Sat_item_operatorEO> GetByCronExpr(string cronExpr)
		{
			return GetByCronExpr(cronExpr, 0, string.Empty, null);
		}
		public async Task<List<Sat_item_operatorEO>> GetByCronExprAsync(string cronExpr)
		{
			return await GetByCronExprAsync(cronExpr, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CronExpr（字段） 查询
		/// </summary>
		/// /// <param name = "cronExpr">Cron表达式, 触发类型为自主定时时有效</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_item_operatorEO> GetByCronExpr(string cronExpr, TransactionManager tm_)
		{
			return GetByCronExpr(cronExpr, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_item_operatorEO>> GetByCronExprAsync(string cronExpr, TransactionManager tm_)
		{
			return await GetByCronExprAsync(cronExpr, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CronExpr（字段） 查询
		/// </summary>
		/// /// <param name = "cronExpr">Cron表达式, 触发类型为自主定时时有效</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_item_operatorEO> GetByCronExpr(string cronExpr, int top_)
		{
			return GetByCronExpr(cronExpr, top_, string.Empty, null);
		}
		public async Task<List<Sat_item_operatorEO>> GetByCronExprAsync(string cronExpr, int top_)
		{
			return await GetByCronExprAsync(cronExpr, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CronExpr（字段） 查询
		/// </summary>
		/// /// <param name = "cronExpr">Cron表达式, 触发类型为自主定时时有效</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_item_operatorEO> GetByCronExpr(string cronExpr, int top_, TransactionManager tm_)
		{
			return GetByCronExpr(cronExpr, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_item_operatorEO>> GetByCronExprAsync(string cronExpr, int top_, TransactionManager tm_)
		{
			return await GetByCronExprAsync(cronExpr, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CronExpr（字段） 查询
		/// </summary>
		/// /// <param name = "cronExpr">Cron表达式, 触发类型为自主定时时有效</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_item_operatorEO> GetByCronExpr(string cronExpr, string sort_)
		{
			return GetByCronExpr(cronExpr, 0, sort_, null);
		}
		public async Task<List<Sat_item_operatorEO>> GetByCronExprAsync(string cronExpr, string sort_)
		{
			return await GetByCronExprAsync(cronExpr, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CronExpr（字段） 查询
		/// </summary>
		/// /// <param name = "cronExpr">Cron表达式, 触发类型为自主定时时有效</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_item_operatorEO> GetByCronExpr(string cronExpr, string sort_, TransactionManager tm_)
		{
			return GetByCronExpr(cronExpr, 0, sort_, tm_);
		}
		public async Task<List<Sat_item_operatorEO>> GetByCronExprAsync(string cronExpr, string sort_, TransactionManager tm_)
		{
			return await GetByCronExprAsync(cronExpr, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CronExpr（字段） 查询
		/// </summary>
		/// /// <param name = "cronExpr">Cron表达式, 触发类型为自主定时时有效</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_item_operatorEO> GetByCronExpr(string cronExpr, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(cronExpr != null ? "`CronExpr` = @CronExpr" : "`CronExpr` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (cronExpr != null)
				paras_.Add(Database.CreateInParameter("@CronExpr", cronExpr, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_item_operatorEO.MapDataReader);
		}
		public async Task<List<Sat_item_operatorEO>> GetByCronExprAsync(string cronExpr, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(cronExpr != null ? "`CronExpr` = @CronExpr" : "`CronExpr` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (cronExpr != null)
				paras_.Add(Database.CreateInParameter("@CronExpr", cronExpr, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_item_operatorEO.MapDataReader);
		}
		#endregion // GetByCronExpr
		#region GetByBeginDate
		
		/// <summary>
		/// 按 BeginDate（字段） 查询
		/// </summary>
		/// /// <param name = "beginDate">起始日期（默认2016-01-01）</param>
		/// <return>实体对象集合</return>
		public List<Sat_item_operatorEO> GetByBeginDate(DateTime beginDate)
		{
			return GetByBeginDate(beginDate, 0, string.Empty, null);
		}
		public async Task<List<Sat_item_operatorEO>> GetByBeginDateAsync(DateTime beginDate)
		{
			return await GetByBeginDateAsync(beginDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BeginDate（字段） 查询
		/// </summary>
		/// /// <param name = "beginDate">起始日期（默认2016-01-01）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_item_operatorEO> GetByBeginDate(DateTime beginDate, TransactionManager tm_)
		{
			return GetByBeginDate(beginDate, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_item_operatorEO>> GetByBeginDateAsync(DateTime beginDate, TransactionManager tm_)
		{
			return await GetByBeginDateAsync(beginDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BeginDate（字段） 查询
		/// </summary>
		/// /// <param name = "beginDate">起始日期（默认2016-01-01）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_item_operatorEO> GetByBeginDate(DateTime beginDate, int top_)
		{
			return GetByBeginDate(beginDate, top_, string.Empty, null);
		}
		public async Task<List<Sat_item_operatorEO>> GetByBeginDateAsync(DateTime beginDate, int top_)
		{
			return await GetByBeginDateAsync(beginDate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BeginDate（字段） 查询
		/// </summary>
		/// /// <param name = "beginDate">起始日期（默认2016-01-01）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_item_operatorEO> GetByBeginDate(DateTime beginDate, int top_, TransactionManager tm_)
		{
			return GetByBeginDate(beginDate, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_item_operatorEO>> GetByBeginDateAsync(DateTime beginDate, int top_, TransactionManager tm_)
		{
			return await GetByBeginDateAsync(beginDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BeginDate（字段） 查询
		/// </summary>
		/// /// <param name = "beginDate">起始日期（默认2016-01-01）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_item_operatorEO> GetByBeginDate(DateTime beginDate, string sort_)
		{
			return GetByBeginDate(beginDate, 0, sort_, null);
		}
		public async Task<List<Sat_item_operatorEO>> GetByBeginDateAsync(DateTime beginDate, string sort_)
		{
			return await GetByBeginDateAsync(beginDate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BeginDate（字段） 查询
		/// </summary>
		/// /// <param name = "beginDate">起始日期（默认2016-01-01）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_item_operatorEO> GetByBeginDate(DateTime beginDate, string sort_, TransactionManager tm_)
		{
			return GetByBeginDate(beginDate, 0, sort_, tm_);
		}
		public async Task<List<Sat_item_operatorEO>> GetByBeginDateAsync(DateTime beginDate, string sort_, TransactionManager tm_)
		{
			return await GetByBeginDateAsync(beginDate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BeginDate（字段） 查询
		/// </summary>
		/// /// <param name = "beginDate">起始日期（默认2016-01-01）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_item_operatorEO> GetByBeginDate(DateTime beginDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BeginDate` = @BeginDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BeginDate", beginDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_item_operatorEO.MapDataReader);
		}
		public async Task<List<Sat_item_operatorEO>> GetByBeginDateAsync(DateTime beginDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BeginDate` = @BeginDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BeginDate", beginDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_item_operatorEO.MapDataReader);
		}
		#endregion // GetByBeginDate
		#region GetByEndDate
		
		/// <summary>
		/// 按 EndDate（字段） 查询
		/// </summary>
		/// /// <param name = "endDate">截止日期（默认2099-01-01）</param>
		/// <return>实体对象集合</return>
		public List<Sat_item_operatorEO> GetByEndDate(DateTime endDate)
		{
			return GetByEndDate(endDate, 0, string.Empty, null);
		}
		public async Task<List<Sat_item_operatorEO>> GetByEndDateAsync(DateTime endDate)
		{
			return await GetByEndDateAsync(endDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 EndDate（字段） 查询
		/// </summary>
		/// /// <param name = "endDate">截止日期（默认2099-01-01）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_item_operatorEO> GetByEndDate(DateTime endDate, TransactionManager tm_)
		{
			return GetByEndDate(endDate, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_item_operatorEO>> GetByEndDateAsync(DateTime endDate, TransactionManager tm_)
		{
			return await GetByEndDateAsync(endDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 EndDate（字段） 查询
		/// </summary>
		/// /// <param name = "endDate">截止日期（默认2099-01-01）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_item_operatorEO> GetByEndDate(DateTime endDate, int top_)
		{
			return GetByEndDate(endDate, top_, string.Empty, null);
		}
		public async Task<List<Sat_item_operatorEO>> GetByEndDateAsync(DateTime endDate, int top_)
		{
			return await GetByEndDateAsync(endDate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 EndDate（字段） 查询
		/// </summary>
		/// /// <param name = "endDate">截止日期（默认2099-01-01）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_item_operatorEO> GetByEndDate(DateTime endDate, int top_, TransactionManager tm_)
		{
			return GetByEndDate(endDate, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_item_operatorEO>> GetByEndDateAsync(DateTime endDate, int top_, TransactionManager tm_)
		{
			return await GetByEndDateAsync(endDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 EndDate（字段） 查询
		/// </summary>
		/// /// <param name = "endDate">截止日期（默认2099-01-01）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_item_operatorEO> GetByEndDate(DateTime endDate, string sort_)
		{
			return GetByEndDate(endDate, 0, sort_, null);
		}
		public async Task<List<Sat_item_operatorEO>> GetByEndDateAsync(DateTime endDate, string sort_)
		{
			return await GetByEndDateAsync(endDate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 EndDate（字段） 查询
		/// </summary>
		/// /// <param name = "endDate">截止日期（默认2099-01-01）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_item_operatorEO> GetByEndDate(DateTime endDate, string sort_, TransactionManager tm_)
		{
			return GetByEndDate(endDate, 0, sort_, tm_);
		}
		public async Task<List<Sat_item_operatorEO>> GetByEndDateAsync(DateTime endDate, string sort_, TransactionManager tm_)
		{
			return await GetByEndDateAsync(endDate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 EndDate（字段） 查询
		/// </summary>
		/// /// <param name = "endDate">截止日期（默认2099-01-01）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_item_operatorEO> GetByEndDate(DateTime endDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`EndDate` = @EndDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@EndDate", endDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_item_operatorEO.MapDataReader);
		}
		public async Task<List<Sat_item_operatorEO>> GetByEndDateAsync(DateTime endDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`EndDate` = @EndDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@EndDate", endDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_item_operatorEO.MapDataReader);
		}
		#endregion // GetByEndDate
		#region GetByStatus
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <return>实体对象集合</return>
		public List<Sat_item_operatorEO> GetByStatus(int status)
		{
			return GetByStatus(status, 0, string.Empty, null);
		}
		public async Task<List<Sat_item_operatorEO>> GetByStatusAsync(int status)
		{
			return await GetByStatusAsync(status, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_item_operatorEO> GetByStatus(int status, TransactionManager tm_)
		{
			return GetByStatus(status, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_item_operatorEO>> GetByStatusAsync(int status, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_item_operatorEO> GetByStatus(int status, int top_)
		{
			return GetByStatus(status, top_, string.Empty, null);
		}
		public async Task<List<Sat_item_operatorEO>> GetByStatusAsync(int status, int top_)
		{
			return await GetByStatusAsync(status, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_item_operatorEO> GetByStatus(int status, int top_, TransactionManager tm_)
		{
			return GetByStatus(status, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_item_operatorEO>> GetByStatusAsync(int status, int top_, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_item_operatorEO> GetByStatus(int status, string sort_)
		{
			return GetByStatus(status, 0, sort_, null);
		}
		public async Task<List<Sat_item_operatorEO>> GetByStatusAsync(int status, string sort_)
		{
			return await GetByStatusAsync(status, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_item_operatorEO> GetByStatus(int status, string sort_, TransactionManager tm_)
		{
			return GetByStatus(status, 0, sort_, tm_);
		}
		public async Task<List<Sat_item_operatorEO>> GetByStatusAsync(int status, string sort_, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_item_operatorEO> GetByStatus(int status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_item_operatorEO.MapDataReader);
		}
		public async Task<List<Sat_item_operatorEO>> GetByStatusAsync(int status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_item_operatorEO.MapDataReader);
		}
		#endregion // GetByStatus
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录日期</param>
		/// <return>实体对象集合</return>
		public List<Sat_item_operatorEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<Sat_item_operatorEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录日期</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_item_operatorEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_item_operatorEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录日期</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_item_operatorEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<Sat_item_operatorEO>> GetByRecDateAsync(DateTime recDate, int top_)
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
		public List<Sat_item_operatorEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_item_operatorEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录日期</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_item_operatorEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<Sat_item_operatorEO>> GetByRecDateAsync(DateTime recDate, string sort_)
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
		public List<Sat_item_operatorEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<Sat_item_operatorEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
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
		public List<Sat_item_operatorEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_item_operatorEO.MapDataReader);
		}
		public async Task<List<Sat_item_operatorEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_item_operatorEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
