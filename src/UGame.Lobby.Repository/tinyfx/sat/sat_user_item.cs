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
	/// 
	/// 【表 sat_user_item 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Sat_user_itemEO : IRowMapper<Sat_user_itemEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Sat_user_itemEO()
		{
			this.Level = 0;
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
		/// 
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
		/// 失效时间, UTC格式有时间,不包含此日期
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 6)]
		public DateTime Deadline { get; set; }
		/// <summary>
		/// 状态 0-进行中 1-已完成未领取 2-已领取 3-已完成
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 7)]
		public int Status { get; set; }
		/// <summary>
		/// 
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 8)]
		public string Value1 { get; set; }
		/// <summary>
		/// 
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 9)]
		public string Value2 { get; set; }
		/// <summary>
		/// 
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 10)]
		public string Value3 { get; set; }
		/// <summary>
		/// 
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 11)]
		public string Value4 { get; set; }
		/// <summary>
		/// 
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 12)]
		public string Value5 { get; set; }
		/// <summary>
		/// 
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 13)]
		public string Value6 { get; set; }
		/// <summary>
		/// 
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 14)]
		public string Value7 { get; set; }
		/// <summary>
		/// 
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 15)]
		public string Value8 { get; set; }
		/// <summary>
		/// 
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 16)]
		public string Value9 { get; set; }
		/// <summary>
		/// 
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 17)]
		public string Value10 { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Sat_user_itemEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Sat_user_itemEO MapDataReader(IDataReader reader)
		{
		    Sat_user_itemEO ret = new Sat_user_itemEO();
			ret.DetailID = reader.ToString("DetailID");
			ret.OriginalDetailID = ret.DetailID;
			ret.UserID = reader.ToString("UserID");
			ret.ItemID = reader.ToInt32("ItemID");
			ret.DayID = reader.ToDateTime("DayID");
			ret.Level = reader.ToInt32("Level");
			ret.Deadline = reader.ToDateTime("Deadline");
			ret.Status = reader.ToInt32("Status");
			ret.Value1 = reader.ToString("Value1");
			ret.Value2 = reader.ToString("Value2");
			ret.Value3 = reader.ToString("Value3");
			ret.Value4 = reader.ToString("Value4");
			ret.Value5 = reader.ToString("Value5");
			ret.Value6 = reader.ToString("Value6");
			ret.Value7 = reader.ToString("Value7");
			ret.Value8 = reader.ToString("Value8");
			ret.Value9 = reader.ToString("Value9");
			ret.Value10 = reader.ToString("Value10");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 
	/// 【表 sat_user_item 的操作类】
	/// </summary>
	[Obsolete]
	public class Sat_user_itemMO : MySqlTableMO<Sat_user_itemEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`sat_user_item`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Sat_user_itemMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Sat_user_itemMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Sat_user_itemMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Sat_user_itemEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Sat_user_itemEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Sat_user_itemEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`DetailID`, `UserID`, `ItemID`, `DayID`, `Level`, `Deadline`, `Status`, `Value1`, `Value2`, `Value3`, `Value4`, `Value5`, `Value6`, `Value7`, `Value8`, `Value9`, `Value10`) VALUE (@DetailID, @UserID, @ItemID, @DayID, @Level, @Deadline, @Status, @Value1, @Value2, @Value3, @Value4, @Value5, @Value6, @Value7, @Value8, @Value9, @Value10);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", item.DetailID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ItemID", item.ItemID, MySqlDbType.Int32),
				Database.CreateInParameter("@DayID", item.DayID, MySqlDbType.Date),
				Database.CreateInParameter("@Level", item.Level, MySqlDbType.Int32),
				Database.CreateInParameter("@Deadline", item.Deadline, MySqlDbType.DateTime),
				Database.CreateInParameter("@Status", item.Status, MySqlDbType.Int32),
				Database.CreateInParameter("@Value1", item.Value1 != null ? item.Value1 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Value2", item.Value2 != null ? item.Value2 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Value3", item.Value3 != null ? item.Value3 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Value4", item.Value4 != null ? item.Value4 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Value5", item.Value5 != null ? item.Value5 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Value6", item.Value6 != null ? item.Value6 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Value7", item.Value7 != null ? item.Value7 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Value8", item.Value8 != null ? item.Value8 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Value9", item.Value9 != null ? item.Value9 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Value10", item.Value10 != null ? item.Value10 : (object)DBNull.Value, MySqlDbType.VarChar),
			};
		}
		public int AddByBatch(IEnumerable<Sat_user_itemEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Sat_user_itemEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sat_user_itemEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`DetailID`, `UserID`, `ItemID`, `DayID`, `Level`, `Deadline`, `Status`, `Value1`, `Value2`, `Value3`, `Value4`, `Value5`, `Value6`, `Value7`, `Value8`, `Value9`, `Value10`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.DetailID}','{item.UserID}',{item.ItemID},'{item.DayID.ToString("yyyy-MM-dd HH:mm:ss")}',{item.Level},'{item.Deadline.ToString("yyyy-MM-dd HH:mm:ss")}',{item.Status},'{item.Value1}','{item.Value2}','{item.Value3}','{item.Value4}','{item.Value5}','{item.Value6}','{item.Value7}','{item.Value8}','{item.Value9}','{item.Value10}'),");
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
		/// /// <param name = "detailID"></param>
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
		public int Remove(Sat_user_itemEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.DetailID, tm_);
		}
		public async Task<int> RemoveAsync(Sat_user_itemEO item, TransactionManager tm_ = null)
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
		/// /// <param name = "deadline">失效时间, UTC格式有时间,不包含此日期</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByDeadline(DateTime deadline, TransactionManager tm_ = null)
		{
			RepairRemoveByDeadlineData(deadline, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByDeadlineAsync(DateTime deadline, TransactionManager tm_ = null)
		{
			RepairRemoveByDeadlineData(deadline, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByDeadlineData(DateTime deadline, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Deadline` = @Deadline";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Deadline", deadline, MySqlDbType.DateTime));
		}
		#endregion // RemoveByDeadline
		#region RemoveByStatus
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "status">状态 0-进行中 1-已完成未领取 2-已领取 3-已完成</param>
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
		#region RemoveByValue1
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "value1"></param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByValue1(string value1, TransactionManager tm_ = null)
		{
			RepairRemoveByValue1Data(value1, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByValue1Async(string value1, TransactionManager tm_ = null)
		{
			RepairRemoveByValue1Data(value1, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByValue1Data(string value1, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (value1 != null ? "`Value1` = @Value1" : "`Value1` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (value1 != null)
				paras_.Add(Database.CreateInParameter("@Value1", value1, MySqlDbType.VarChar));
		}
		#endregion // RemoveByValue1
		#region RemoveByValue2
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "value2"></param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByValue2(string value2, TransactionManager tm_ = null)
		{
			RepairRemoveByValue2Data(value2, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByValue2Async(string value2, TransactionManager tm_ = null)
		{
			RepairRemoveByValue2Data(value2, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByValue2Data(string value2, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (value2 != null ? "`Value2` = @Value2" : "`Value2` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (value2 != null)
				paras_.Add(Database.CreateInParameter("@Value2", value2, MySqlDbType.VarChar));
		}
		#endregion // RemoveByValue2
		#region RemoveByValue3
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "value3"></param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByValue3(string value3, TransactionManager tm_ = null)
		{
			RepairRemoveByValue3Data(value3, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByValue3Async(string value3, TransactionManager tm_ = null)
		{
			RepairRemoveByValue3Data(value3, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByValue3Data(string value3, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (value3 != null ? "`Value3` = @Value3" : "`Value3` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (value3 != null)
				paras_.Add(Database.CreateInParameter("@Value3", value3, MySqlDbType.VarChar));
		}
		#endregion // RemoveByValue3
		#region RemoveByValue4
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "value4"></param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByValue4(string value4, TransactionManager tm_ = null)
		{
			RepairRemoveByValue4Data(value4, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByValue4Async(string value4, TransactionManager tm_ = null)
		{
			RepairRemoveByValue4Data(value4, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByValue4Data(string value4, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (value4 != null ? "`Value4` = @Value4" : "`Value4` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (value4 != null)
				paras_.Add(Database.CreateInParameter("@Value4", value4, MySqlDbType.VarChar));
		}
		#endregion // RemoveByValue4
		#region RemoveByValue5
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "value5"></param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByValue5(string value5, TransactionManager tm_ = null)
		{
			RepairRemoveByValue5Data(value5, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByValue5Async(string value5, TransactionManager tm_ = null)
		{
			RepairRemoveByValue5Data(value5, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByValue5Data(string value5, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (value5 != null ? "`Value5` = @Value5" : "`Value5` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (value5 != null)
				paras_.Add(Database.CreateInParameter("@Value5", value5, MySqlDbType.VarChar));
		}
		#endregion // RemoveByValue5
		#region RemoveByValue6
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "value6"></param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByValue6(string value6, TransactionManager tm_ = null)
		{
			RepairRemoveByValue6Data(value6, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByValue6Async(string value6, TransactionManager tm_ = null)
		{
			RepairRemoveByValue6Data(value6, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByValue6Data(string value6, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (value6 != null ? "`Value6` = @Value6" : "`Value6` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (value6 != null)
				paras_.Add(Database.CreateInParameter("@Value6", value6, MySqlDbType.VarChar));
		}
		#endregion // RemoveByValue6
		#region RemoveByValue7
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "value7"></param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByValue7(string value7, TransactionManager tm_ = null)
		{
			RepairRemoveByValue7Data(value7, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByValue7Async(string value7, TransactionManager tm_ = null)
		{
			RepairRemoveByValue7Data(value7, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByValue7Data(string value7, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (value7 != null ? "`Value7` = @Value7" : "`Value7` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (value7 != null)
				paras_.Add(Database.CreateInParameter("@Value7", value7, MySqlDbType.VarChar));
		}
		#endregion // RemoveByValue7
		#region RemoveByValue8
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "value8"></param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByValue8(string value8, TransactionManager tm_ = null)
		{
			RepairRemoveByValue8Data(value8, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByValue8Async(string value8, TransactionManager tm_ = null)
		{
			RepairRemoveByValue8Data(value8, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByValue8Data(string value8, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (value8 != null ? "`Value8` = @Value8" : "`Value8` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (value8 != null)
				paras_.Add(Database.CreateInParameter("@Value8", value8, MySqlDbType.VarChar));
		}
		#endregion // RemoveByValue8
		#region RemoveByValue9
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "value9"></param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByValue9(string value9, TransactionManager tm_ = null)
		{
			RepairRemoveByValue9Data(value9, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByValue9Async(string value9, TransactionManager tm_ = null)
		{
			RepairRemoveByValue9Data(value9, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByValue9Data(string value9, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (value9 != null ? "`Value9` = @Value9" : "`Value9` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (value9 != null)
				paras_.Add(Database.CreateInParameter("@Value9", value9, MySqlDbType.VarChar));
		}
		#endregion // RemoveByValue9
		#region RemoveByValue10
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "value10"></param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByValue10(string value10, TransactionManager tm_ = null)
		{
			RepairRemoveByValue10Data(value10, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByValue10Async(string value10, TransactionManager tm_ = null)
		{
			RepairRemoveByValue10Data(value10, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByValue10Data(string value10, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (value10 != null ? "`Value10` = @Value10" : "`Value10` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (value10 != null)
				paras_.Add(Database.CreateInParameter("@Value10", value10, MySqlDbType.VarChar));
		}
		#endregion // RemoveByValue10
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
		public int Put(Sat_user_itemEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Sat_user_itemEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Sat_user_itemEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `DetailID` = @DetailID, `UserID` = @UserID, `ItemID` = @ItemID, `DayID` = @DayID, `Level` = @Level, `Deadline` = @Deadline, `Status` = @Status, `Value1` = @Value1, `Value2` = @Value2, `Value3` = @Value3, `Value4` = @Value4, `Value5` = @Value5, `Value6` = @Value6, `Value7` = @Value7, `Value8` = @Value8, `Value9` = @Value9, `Value10` = @Value10 WHERE `DetailID` = @DetailID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", item.DetailID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ItemID", item.ItemID, MySqlDbType.Int32),
				Database.CreateInParameter("@DayID", item.DayID, MySqlDbType.Date),
				Database.CreateInParameter("@Level", item.Level, MySqlDbType.Int32),
				Database.CreateInParameter("@Deadline", item.Deadline, MySqlDbType.DateTime),
				Database.CreateInParameter("@Status", item.Status, MySqlDbType.Int32),
				Database.CreateInParameter("@Value1", item.Value1 != null ? item.Value1 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Value2", item.Value2 != null ? item.Value2 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Value3", item.Value3 != null ? item.Value3 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Value4", item.Value4 != null ? item.Value4 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Value5", item.Value5 != null ? item.Value5 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Value6", item.Value6 != null ? item.Value6 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Value7", item.Value7 != null ? item.Value7 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Value8", item.Value8 != null ? item.Value8 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Value9", item.Value9 != null ? item.Value9 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Value10", item.Value10 != null ? item.Value10 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@DetailID_Original", item.HasOriginal ? item.OriginalDetailID : item.DetailID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Sat_user_itemEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Sat_user_itemEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "detailID"></param>
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
		/// /// <param name = "detailID"></param>
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
		/// /// <param name = "detailID"></param>
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
		/// /// <param name = "detailID"></param>
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
		/// /// <param name = "detailID"></param>
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
		/// /// <param name = "detailID"></param>
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
		/// /// <param name = "detailID"></param>
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
		/// /// <param name = "detailID"></param>
		/// /// <param name = "deadline">失效时间, UTC格式有时间,不包含此日期</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutDeadlineByPK(string detailID, DateTime deadline, TransactionManager tm_ = null)
		{
			RepairPutDeadlineByPKData(detailID, deadline, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutDeadlineByPKAsync(string detailID, DateTime deadline, TransactionManager tm_ = null)
		{
			RepairPutDeadlineByPKData(detailID, deadline, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutDeadlineByPKData(string detailID, DateTime deadline, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Deadline` = @Deadline  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Deadline", deadline, MySqlDbType.DateTime),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "deadline">失效时间, UTC格式有时间,不包含此日期</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutDeadline(DateTime deadline, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Deadline` = @Deadline";
			var parameter_ = Database.CreateInParameter("@Deadline", deadline, MySqlDbType.DateTime);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutDeadlineAsync(DateTime deadline, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Deadline` = @Deadline";
			var parameter_ = Database.CreateInParameter("@Deadline", deadline, MySqlDbType.DateTime);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutDeadline
		#region PutStatus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID"></param>
		/// /// <param name = "status">状态 0-进行中 1-已完成未领取 2-已领取 3-已完成</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutStatusByPK(string detailID, int status, TransactionManager tm_ = null)
		{
			RepairPutStatusByPKData(detailID, status, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutStatusByPKAsync(string detailID, int status, TransactionManager tm_ = null)
		{
			RepairPutStatusByPKData(detailID, status, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutStatusByPKData(string detailID, int status, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Status` = @Status  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Status", status, MySqlDbType.Int32),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "status">状态 0-进行中 1-已完成未领取 2-已领取 3-已完成</param>
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
		#region PutValue1
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID"></param>
		/// /// <param name = "value1"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutValue1ByPK(string detailID, string value1, TransactionManager tm_ = null)
		{
			RepairPutValue1ByPKData(detailID, value1, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutValue1ByPKAsync(string detailID, string value1, TransactionManager tm_ = null)
		{
			RepairPutValue1ByPKData(detailID, value1, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutValue1ByPKData(string detailID, string value1, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Value1` = @Value1  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Value1", value1 != null ? value1 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "value1"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutValue1(string value1, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Value1` = @Value1";
			var parameter_ = Database.CreateInParameter("@Value1", value1 != null ? value1 : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutValue1Async(string value1, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Value1` = @Value1";
			var parameter_ = Database.CreateInParameter("@Value1", value1 != null ? value1 : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutValue1
		#region PutValue2
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID"></param>
		/// /// <param name = "value2"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutValue2ByPK(string detailID, string value2, TransactionManager tm_ = null)
		{
			RepairPutValue2ByPKData(detailID, value2, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutValue2ByPKAsync(string detailID, string value2, TransactionManager tm_ = null)
		{
			RepairPutValue2ByPKData(detailID, value2, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutValue2ByPKData(string detailID, string value2, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Value2` = @Value2  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Value2", value2 != null ? value2 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "value2"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutValue2(string value2, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Value2` = @Value2";
			var parameter_ = Database.CreateInParameter("@Value2", value2 != null ? value2 : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutValue2Async(string value2, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Value2` = @Value2";
			var parameter_ = Database.CreateInParameter("@Value2", value2 != null ? value2 : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutValue2
		#region PutValue3
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID"></param>
		/// /// <param name = "value3"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutValue3ByPK(string detailID, string value3, TransactionManager tm_ = null)
		{
			RepairPutValue3ByPKData(detailID, value3, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutValue3ByPKAsync(string detailID, string value3, TransactionManager tm_ = null)
		{
			RepairPutValue3ByPKData(detailID, value3, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutValue3ByPKData(string detailID, string value3, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Value3` = @Value3  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Value3", value3 != null ? value3 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "value3"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutValue3(string value3, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Value3` = @Value3";
			var parameter_ = Database.CreateInParameter("@Value3", value3 != null ? value3 : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutValue3Async(string value3, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Value3` = @Value3";
			var parameter_ = Database.CreateInParameter("@Value3", value3 != null ? value3 : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutValue3
		#region PutValue4
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID"></param>
		/// /// <param name = "value4"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutValue4ByPK(string detailID, string value4, TransactionManager tm_ = null)
		{
			RepairPutValue4ByPKData(detailID, value4, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutValue4ByPKAsync(string detailID, string value4, TransactionManager tm_ = null)
		{
			RepairPutValue4ByPKData(detailID, value4, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutValue4ByPKData(string detailID, string value4, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Value4` = @Value4  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Value4", value4 != null ? value4 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "value4"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutValue4(string value4, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Value4` = @Value4";
			var parameter_ = Database.CreateInParameter("@Value4", value4 != null ? value4 : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutValue4Async(string value4, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Value4` = @Value4";
			var parameter_ = Database.CreateInParameter("@Value4", value4 != null ? value4 : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutValue4
		#region PutValue5
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID"></param>
		/// /// <param name = "value5"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutValue5ByPK(string detailID, string value5, TransactionManager tm_ = null)
		{
			RepairPutValue5ByPKData(detailID, value5, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutValue5ByPKAsync(string detailID, string value5, TransactionManager tm_ = null)
		{
			RepairPutValue5ByPKData(detailID, value5, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutValue5ByPKData(string detailID, string value5, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Value5` = @Value5  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Value5", value5 != null ? value5 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "value5"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutValue5(string value5, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Value5` = @Value5";
			var parameter_ = Database.CreateInParameter("@Value5", value5 != null ? value5 : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutValue5Async(string value5, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Value5` = @Value5";
			var parameter_ = Database.CreateInParameter("@Value5", value5 != null ? value5 : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutValue5
		#region PutValue6
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID"></param>
		/// /// <param name = "value6"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutValue6ByPK(string detailID, string value6, TransactionManager tm_ = null)
		{
			RepairPutValue6ByPKData(detailID, value6, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutValue6ByPKAsync(string detailID, string value6, TransactionManager tm_ = null)
		{
			RepairPutValue6ByPKData(detailID, value6, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutValue6ByPKData(string detailID, string value6, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Value6` = @Value6  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Value6", value6 != null ? value6 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "value6"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutValue6(string value6, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Value6` = @Value6";
			var parameter_ = Database.CreateInParameter("@Value6", value6 != null ? value6 : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutValue6Async(string value6, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Value6` = @Value6";
			var parameter_ = Database.CreateInParameter("@Value6", value6 != null ? value6 : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutValue6
		#region PutValue7
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID"></param>
		/// /// <param name = "value7"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutValue7ByPK(string detailID, string value7, TransactionManager tm_ = null)
		{
			RepairPutValue7ByPKData(detailID, value7, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutValue7ByPKAsync(string detailID, string value7, TransactionManager tm_ = null)
		{
			RepairPutValue7ByPKData(detailID, value7, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutValue7ByPKData(string detailID, string value7, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Value7` = @Value7  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Value7", value7 != null ? value7 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "value7"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutValue7(string value7, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Value7` = @Value7";
			var parameter_ = Database.CreateInParameter("@Value7", value7 != null ? value7 : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutValue7Async(string value7, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Value7` = @Value7";
			var parameter_ = Database.CreateInParameter("@Value7", value7 != null ? value7 : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutValue7
		#region PutValue8
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID"></param>
		/// /// <param name = "value8"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutValue8ByPK(string detailID, string value8, TransactionManager tm_ = null)
		{
			RepairPutValue8ByPKData(detailID, value8, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutValue8ByPKAsync(string detailID, string value8, TransactionManager tm_ = null)
		{
			RepairPutValue8ByPKData(detailID, value8, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutValue8ByPKData(string detailID, string value8, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Value8` = @Value8  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Value8", value8 != null ? value8 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "value8"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutValue8(string value8, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Value8` = @Value8";
			var parameter_ = Database.CreateInParameter("@Value8", value8 != null ? value8 : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutValue8Async(string value8, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Value8` = @Value8";
			var parameter_ = Database.CreateInParameter("@Value8", value8 != null ? value8 : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutValue8
		#region PutValue9
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID"></param>
		/// /// <param name = "value9"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutValue9ByPK(string detailID, string value9, TransactionManager tm_ = null)
		{
			RepairPutValue9ByPKData(detailID, value9, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutValue9ByPKAsync(string detailID, string value9, TransactionManager tm_ = null)
		{
			RepairPutValue9ByPKData(detailID, value9, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutValue9ByPKData(string detailID, string value9, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Value9` = @Value9  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Value9", value9 != null ? value9 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "value9"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutValue9(string value9, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Value9` = @Value9";
			var parameter_ = Database.CreateInParameter("@Value9", value9 != null ? value9 : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutValue9Async(string value9, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Value9` = @Value9";
			var parameter_ = Database.CreateInParameter("@Value9", value9 != null ? value9 : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutValue9
		#region PutValue10
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID"></param>
		/// /// <param name = "value10"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutValue10ByPK(string detailID, string value10, TransactionManager tm_ = null)
		{
			RepairPutValue10ByPKData(detailID, value10, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutValue10ByPKAsync(string detailID, string value10, TransactionManager tm_ = null)
		{
			RepairPutValue10ByPKData(detailID, value10, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutValue10ByPKData(string detailID, string value10, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Value10` = @Value10  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Value10", value10 != null ? value10 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "value10"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutValue10(string value10, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Value10` = @Value10";
			var parameter_ = Database.CreateInParameter("@Value10", value10 != null ? value10 : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutValue10Async(string value10, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Value10` = @Value10";
			var parameter_ = Database.CreateInParameter("@Value10", value10 != null ? value10 : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutValue10
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Sat_user_itemEO item, TransactionManager tm = null)
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
		public async Task<bool> SetAsync(Sat_user_itemEO item, TransactionManager tm = null)
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
		/// /// <param name = "detailID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Sat_user_itemEO GetByPK(string detailID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(detailID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sat_user_itemEO.MapDataReader);
		}
		public async Task<Sat_user_itemEO> GetByPKAsync(string detailID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(detailID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sat_user_itemEO.MapDataReader);
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
		public Sat_user_itemEO GetByUserIDAndDayIDAndItemID(string userID, DateTime dayID, int itemID, TransactionManager tm_ = null)
		{
			RepairGetByUserIDAndDayIDAndItemIDData(userID, dayID, itemID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sat_user_itemEO.MapDataReader);
		}
		public async Task<Sat_user_itemEO> GetByUserIDAndDayIDAndItemIDAsync(string userID, DateTime dayID, int itemID, TransactionManager tm_ = null)
		{
			RepairGetByUserIDAndDayIDAndItemIDData(userID, dayID, itemID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sat_user_itemEO.MapDataReader);
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
		/// /// <param name = "detailID"></param>
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
		/// /// <param name = "detailID"></param>
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
		/// /// <param name = "detailID"></param>
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
		/// /// <param name = "detailID"></param>
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
		/// /// <param name = "detailID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetDeadlineByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`Deadline`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<DateTime> GetDeadlineByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`Deadline`", "`DetailID` = @DetailID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Status（字段）
		/// </summary>
		/// /// <param name = "detailID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetStatusByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`Status`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<int> GetStatusByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`Status`", "`DetailID` = @DetailID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Value1（字段）
		/// </summary>
		/// /// <param name = "detailID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetValue1ByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Value1`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<string> GetValue1ByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Value1`", "`DetailID` = @DetailID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Value2（字段）
		/// </summary>
		/// /// <param name = "detailID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetValue2ByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Value2`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<string> GetValue2ByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Value2`", "`DetailID` = @DetailID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Value3（字段）
		/// </summary>
		/// /// <param name = "detailID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetValue3ByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Value3`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<string> GetValue3ByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Value3`", "`DetailID` = @DetailID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Value4（字段）
		/// </summary>
		/// /// <param name = "detailID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetValue4ByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Value4`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<string> GetValue4ByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Value4`", "`DetailID` = @DetailID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Value5（字段）
		/// </summary>
		/// /// <param name = "detailID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetValue5ByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Value5`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<string> GetValue5ByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Value5`", "`DetailID` = @DetailID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Value6（字段）
		/// </summary>
		/// /// <param name = "detailID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetValue6ByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Value6`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<string> GetValue6ByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Value6`", "`DetailID` = @DetailID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Value7（字段）
		/// </summary>
		/// /// <param name = "detailID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetValue7ByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Value7`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<string> GetValue7ByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Value7`", "`DetailID` = @DetailID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Value8（字段）
		/// </summary>
		/// /// <param name = "detailID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetValue8ByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Value8`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<string> GetValue8ByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Value8`", "`DetailID` = @DetailID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Value9（字段）
		/// </summary>
		/// /// <param name = "detailID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetValue9ByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Value9`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<string> GetValue9ByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Value9`", "`DetailID` = @DetailID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Value10（字段）
		/// </summary>
		/// /// <param name = "detailID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetValue10ByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Value10`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<string> GetValue10ByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Value10`", "`DetailID` = @DetailID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByUserID
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByUserID(string userID)
		{
			return GetByUserID(userID, 0, string.Empty, null);
		}
		public async Task<List<Sat_user_itemEO>> GetByUserIDAsync(string userID)
		{
			return await GetByUserIDAsync(userID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByUserID(string userID, TransactionManager tm_)
		{
			return GetByUserID(userID, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_user_itemEO>> GetByUserIDAsync(string userID, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByUserID(string userID, int top_)
		{
			return GetByUserID(userID, top_, string.Empty, null);
		}
		public async Task<List<Sat_user_itemEO>> GetByUserIDAsync(string userID, int top_)
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
		public List<Sat_user_itemEO> GetByUserID(string userID, int top_, TransactionManager tm_)
		{
			return GetByUserID(userID, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_user_itemEO>> GetByUserIDAsync(string userID, int top_, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByUserID(string userID, string sort_)
		{
			return GetByUserID(userID, 0, sort_, null);
		}
		public async Task<List<Sat_user_itemEO>> GetByUserIDAsync(string userID, string sort_)
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
		public List<Sat_user_itemEO> GetByUserID(string userID, string sort_, TransactionManager tm_)
		{
			return GetByUserID(userID, 0, sort_, tm_);
		}
		public async Task<List<Sat_user_itemEO>> GetByUserIDAsync(string userID, string sort_, TransactionManager tm_)
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
		public List<Sat_user_itemEO> GetByUserID(string userID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserID` = @UserID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_user_itemEO.MapDataReader);
		}
		public async Task<List<Sat_user_itemEO>> GetByUserIDAsync(string userID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserID` = @UserID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_user_itemEO.MapDataReader);
		}
		#endregion // GetByUserID
		#region GetByItemID
		
		/// <summary>
		/// 按 ItemID（字段） 查询
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByItemID(int itemID)
		{
			return GetByItemID(itemID, 0, string.Empty, null);
		}
		public async Task<List<Sat_user_itemEO>> GetByItemIDAsync(int itemID)
		{
			return await GetByItemIDAsync(itemID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ItemID（字段） 查询
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByItemID(int itemID, TransactionManager tm_)
		{
			return GetByItemID(itemID, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_user_itemEO>> GetByItemIDAsync(int itemID, TransactionManager tm_)
		{
			return await GetByItemIDAsync(itemID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ItemID（字段） 查询
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByItemID(int itemID, int top_)
		{
			return GetByItemID(itemID, top_, string.Empty, null);
		}
		public async Task<List<Sat_user_itemEO>> GetByItemIDAsync(int itemID, int top_)
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
		public List<Sat_user_itemEO> GetByItemID(int itemID, int top_, TransactionManager tm_)
		{
			return GetByItemID(itemID, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_user_itemEO>> GetByItemIDAsync(int itemID, int top_, TransactionManager tm_)
		{
			return await GetByItemIDAsync(itemID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ItemID（字段） 查询
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByItemID(int itemID, string sort_)
		{
			return GetByItemID(itemID, 0, sort_, null);
		}
		public async Task<List<Sat_user_itemEO>> GetByItemIDAsync(int itemID, string sort_)
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
		public List<Sat_user_itemEO> GetByItemID(int itemID, string sort_, TransactionManager tm_)
		{
			return GetByItemID(itemID, 0, sort_, tm_);
		}
		public async Task<List<Sat_user_itemEO>> GetByItemIDAsync(int itemID, string sort_, TransactionManager tm_)
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
		public List<Sat_user_itemEO> GetByItemID(int itemID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ItemID` = @ItemID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_user_itemEO.MapDataReader);
		}
		public async Task<List<Sat_user_itemEO>> GetByItemIDAsync(int itemID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ItemID` = @ItemID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_user_itemEO.MapDataReader);
		}
		#endregion // GetByItemID
		#region GetByDayID
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">日期ID,针对循环类活动,通常是日期</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByDayID(DateTime dayID)
		{
			return GetByDayID(dayID, 0, string.Empty, null);
		}
		public async Task<List<Sat_user_itemEO>> GetByDayIDAsync(DateTime dayID)
		{
			return await GetByDayIDAsync(dayID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">日期ID,针对循环类活动,通常是日期</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByDayID(DateTime dayID, TransactionManager tm_)
		{
			return GetByDayID(dayID, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_user_itemEO>> GetByDayIDAsync(DateTime dayID, TransactionManager tm_)
		{
			return await GetByDayIDAsync(dayID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">日期ID,针对循环类活动,通常是日期</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByDayID(DateTime dayID, int top_)
		{
			return GetByDayID(dayID, top_, string.Empty, null);
		}
		public async Task<List<Sat_user_itemEO>> GetByDayIDAsync(DateTime dayID, int top_)
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
		public List<Sat_user_itemEO> GetByDayID(DateTime dayID, int top_, TransactionManager tm_)
		{
			return GetByDayID(dayID, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_user_itemEO>> GetByDayIDAsync(DateTime dayID, int top_, TransactionManager tm_)
		{
			return await GetByDayIDAsync(dayID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">日期ID,针对循环类活动,通常是日期</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByDayID(DateTime dayID, string sort_)
		{
			return GetByDayID(dayID, 0, sort_, null);
		}
		public async Task<List<Sat_user_itemEO>> GetByDayIDAsync(DateTime dayID, string sort_)
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
		public List<Sat_user_itemEO> GetByDayID(DateTime dayID, string sort_, TransactionManager tm_)
		{
			return GetByDayID(dayID, 0, sort_, tm_);
		}
		public async Task<List<Sat_user_itemEO>> GetByDayIDAsync(DateTime dayID, string sort_, TransactionManager tm_)
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
		public List<Sat_user_itemEO> GetByDayID(DateTime dayID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DayID` = @DayID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_user_itemEO.MapDataReader);
		}
		public async Task<List<Sat_user_itemEO>> GetByDayIDAsync(DateTime dayID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DayID` = @DayID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_user_itemEO.MapDataReader);
		}
		#endregion // GetByDayID
		#region GetByLevel
		
		/// <summary>
		/// 按 Level（字段） 查询
		/// </summary>
		/// /// <param name = "level">等级</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByLevel(int level)
		{
			return GetByLevel(level, 0, string.Empty, null);
		}
		public async Task<List<Sat_user_itemEO>> GetByLevelAsync(int level)
		{
			return await GetByLevelAsync(level, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Level（字段） 查询
		/// </summary>
		/// /// <param name = "level">等级</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByLevel(int level, TransactionManager tm_)
		{
			return GetByLevel(level, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_user_itemEO>> GetByLevelAsync(int level, TransactionManager tm_)
		{
			return await GetByLevelAsync(level, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Level（字段） 查询
		/// </summary>
		/// /// <param name = "level">等级</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByLevel(int level, int top_)
		{
			return GetByLevel(level, top_, string.Empty, null);
		}
		public async Task<List<Sat_user_itemEO>> GetByLevelAsync(int level, int top_)
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
		public List<Sat_user_itemEO> GetByLevel(int level, int top_, TransactionManager tm_)
		{
			return GetByLevel(level, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_user_itemEO>> GetByLevelAsync(int level, int top_, TransactionManager tm_)
		{
			return await GetByLevelAsync(level, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Level（字段） 查询
		/// </summary>
		/// /// <param name = "level">等级</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByLevel(int level, string sort_)
		{
			return GetByLevel(level, 0, sort_, null);
		}
		public async Task<List<Sat_user_itemEO>> GetByLevelAsync(int level, string sort_)
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
		public List<Sat_user_itemEO> GetByLevel(int level, string sort_, TransactionManager tm_)
		{
			return GetByLevel(level, 0, sort_, tm_);
		}
		public async Task<List<Sat_user_itemEO>> GetByLevelAsync(int level, string sort_, TransactionManager tm_)
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
		public List<Sat_user_itemEO> GetByLevel(int level, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Level` = @Level", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Level", level, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_user_itemEO.MapDataReader);
		}
		public async Task<List<Sat_user_itemEO>> GetByLevelAsync(int level, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Level` = @Level", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Level", level, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_user_itemEO.MapDataReader);
		}
		#endregion // GetByLevel
		#region GetByDeadline
		
		/// <summary>
		/// 按 Deadline（字段） 查询
		/// </summary>
		/// /// <param name = "deadline">失效时间, UTC格式有时间,不包含此日期</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByDeadline(DateTime deadline)
		{
			return GetByDeadline(deadline, 0, string.Empty, null);
		}
		public async Task<List<Sat_user_itemEO>> GetByDeadlineAsync(DateTime deadline)
		{
			return await GetByDeadlineAsync(deadline, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Deadline（字段） 查询
		/// </summary>
		/// /// <param name = "deadline">失效时间, UTC格式有时间,不包含此日期</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByDeadline(DateTime deadline, TransactionManager tm_)
		{
			return GetByDeadline(deadline, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_user_itemEO>> GetByDeadlineAsync(DateTime deadline, TransactionManager tm_)
		{
			return await GetByDeadlineAsync(deadline, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Deadline（字段） 查询
		/// </summary>
		/// /// <param name = "deadline">失效时间, UTC格式有时间,不包含此日期</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByDeadline(DateTime deadline, int top_)
		{
			return GetByDeadline(deadline, top_, string.Empty, null);
		}
		public async Task<List<Sat_user_itemEO>> GetByDeadlineAsync(DateTime deadline, int top_)
		{
			return await GetByDeadlineAsync(deadline, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Deadline（字段） 查询
		/// </summary>
		/// /// <param name = "deadline">失效时间, UTC格式有时间,不包含此日期</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByDeadline(DateTime deadline, int top_, TransactionManager tm_)
		{
			return GetByDeadline(deadline, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_user_itemEO>> GetByDeadlineAsync(DateTime deadline, int top_, TransactionManager tm_)
		{
			return await GetByDeadlineAsync(deadline, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Deadline（字段） 查询
		/// </summary>
		/// /// <param name = "deadline">失效时间, UTC格式有时间,不包含此日期</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByDeadline(DateTime deadline, string sort_)
		{
			return GetByDeadline(deadline, 0, sort_, null);
		}
		public async Task<List<Sat_user_itemEO>> GetByDeadlineAsync(DateTime deadline, string sort_)
		{
			return await GetByDeadlineAsync(deadline, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Deadline（字段） 查询
		/// </summary>
		/// /// <param name = "deadline">失效时间, UTC格式有时间,不包含此日期</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByDeadline(DateTime deadline, string sort_, TransactionManager tm_)
		{
			return GetByDeadline(deadline, 0, sort_, tm_);
		}
		public async Task<List<Sat_user_itemEO>> GetByDeadlineAsync(DateTime deadline, string sort_, TransactionManager tm_)
		{
			return await GetByDeadlineAsync(deadline, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Deadline（字段） 查询
		/// </summary>
		/// /// <param name = "deadline">失效时间, UTC格式有时间,不包含此日期</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByDeadline(DateTime deadline, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Deadline` = @Deadline", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Deadline", deadline, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_user_itemEO.MapDataReader);
		}
		public async Task<List<Sat_user_itemEO>> GetByDeadlineAsync(DateTime deadline, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Deadline` = @Deadline", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Deadline", deadline, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_user_itemEO.MapDataReader);
		}
		#endregion // GetByDeadline
		#region GetByStatus
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态 0-进行中 1-已完成未领取 2-已领取 3-已完成</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByStatus(int status)
		{
			return GetByStatus(status, 0, string.Empty, null);
		}
		public async Task<List<Sat_user_itemEO>> GetByStatusAsync(int status)
		{
			return await GetByStatusAsync(status, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态 0-进行中 1-已完成未领取 2-已领取 3-已完成</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByStatus(int status, TransactionManager tm_)
		{
			return GetByStatus(status, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_user_itemEO>> GetByStatusAsync(int status, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态 0-进行中 1-已完成未领取 2-已领取 3-已完成</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByStatus(int status, int top_)
		{
			return GetByStatus(status, top_, string.Empty, null);
		}
		public async Task<List<Sat_user_itemEO>> GetByStatusAsync(int status, int top_)
		{
			return await GetByStatusAsync(status, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态 0-进行中 1-已完成未领取 2-已领取 3-已完成</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByStatus(int status, int top_, TransactionManager tm_)
		{
			return GetByStatus(status, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_user_itemEO>> GetByStatusAsync(int status, int top_, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态 0-进行中 1-已完成未领取 2-已领取 3-已完成</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByStatus(int status, string sort_)
		{
			return GetByStatus(status, 0, sort_, null);
		}
		public async Task<List<Sat_user_itemEO>> GetByStatusAsync(int status, string sort_)
		{
			return await GetByStatusAsync(status, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态 0-进行中 1-已完成未领取 2-已领取 3-已完成</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByStatus(int status, string sort_, TransactionManager tm_)
		{
			return GetByStatus(status, 0, sort_, tm_);
		}
		public async Task<List<Sat_user_itemEO>> GetByStatusAsync(int status, string sort_, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态 0-进行中 1-已完成未领取 2-已领取 3-已完成</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByStatus(int status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_user_itemEO.MapDataReader);
		}
		public async Task<List<Sat_user_itemEO>> GetByStatusAsync(int status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_user_itemEO.MapDataReader);
		}
		#endregion // GetByStatus
		#region GetByValue1
		
		/// <summary>
		/// 按 Value1（字段） 查询
		/// </summary>
		/// /// <param name = "value1"></param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue1(string value1)
		{
			return GetByValue1(value1, 0, string.Empty, null);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue1Async(string value1)
		{
			return await GetByValue1Async(value1, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Value1（字段） 查询
		/// </summary>
		/// /// <param name = "value1"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue1(string value1, TransactionManager tm_)
		{
			return GetByValue1(value1, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue1Async(string value1, TransactionManager tm_)
		{
			return await GetByValue1Async(value1, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Value1（字段） 查询
		/// </summary>
		/// /// <param name = "value1"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue1(string value1, int top_)
		{
			return GetByValue1(value1, top_, string.Empty, null);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue1Async(string value1, int top_)
		{
			return await GetByValue1Async(value1, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Value1（字段） 查询
		/// </summary>
		/// /// <param name = "value1"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue1(string value1, int top_, TransactionManager tm_)
		{
			return GetByValue1(value1, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue1Async(string value1, int top_, TransactionManager tm_)
		{
			return await GetByValue1Async(value1, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Value1（字段） 查询
		/// </summary>
		/// /// <param name = "value1"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue1(string value1, string sort_)
		{
			return GetByValue1(value1, 0, sort_, null);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue1Async(string value1, string sort_)
		{
			return await GetByValue1Async(value1, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Value1（字段） 查询
		/// </summary>
		/// /// <param name = "value1"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue1(string value1, string sort_, TransactionManager tm_)
		{
			return GetByValue1(value1, 0, sort_, tm_);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue1Async(string value1, string sort_, TransactionManager tm_)
		{
			return await GetByValue1Async(value1, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Value1（字段） 查询
		/// </summary>
		/// /// <param name = "value1"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue1(string value1, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(value1 != null ? "`Value1` = @Value1" : "`Value1` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (value1 != null)
				paras_.Add(Database.CreateInParameter("@Value1", value1, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_user_itemEO.MapDataReader);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue1Async(string value1, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(value1 != null ? "`Value1` = @Value1" : "`Value1` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (value1 != null)
				paras_.Add(Database.CreateInParameter("@Value1", value1, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_user_itemEO.MapDataReader);
		}
		#endregion // GetByValue1
		#region GetByValue2
		
		/// <summary>
		/// 按 Value2（字段） 查询
		/// </summary>
		/// /// <param name = "value2"></param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue2(string value2)
		{
			return GetByValue2(value2, 0, string.Empty, null);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue2Async(string value2)
		{
			return await GetByValue2Async(value2, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Value2（字段） 查询
		/// </summary>
		/// /// <param name = "value2"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue2(string value2, TransactionManager tm_)
		{
			return GetByValue2(value2, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue2Async(string value2, TransactionManager tm_)
		{
			return await GetByValue2Async(value2, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Value2（字段） 查询
		/// </summary>
		/// /// <param name = "value2"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue2(string value2, int top_)
		{
			return GetByValue2(value2, top_, string.Empty, null);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue2Async(string value2, int top_)
		{
			return await GetByValue2Async(value2, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Value2（字段） 查询
		/// </summary>
		/// /// <param name = "value2"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue2(string value2, int top_, TransactionManager tm_)
		{
			return GetByValue2(value2, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue2Async(string value2, int top_, TransactionManager tm_)
		{
			return await GetByValue2Async(value2, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Value2（字段） 查询
		/// </summary>
		/// /// <param name = "value2"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue2(string value2, string sort_)
		{
			return GetByValue2(value2, 0, sort_, null);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue2Async(string value2, string sort_)
		{
			return await GetByValue2Async(value2, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Value2（字段） 查询
		/// </summary>
		/// /// <param name = "value2"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue2(string value2, string sort_, TransactionManager tm_)
		{
			return GetByValue2(value2, 0, sort_, tm_);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue2Async(string value2, string sort_, TransactionManager tm_)
		{
			return await GetByValue2Async(value2, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Value2（字段） 查询
		/// </summary>
		/// /// <param name = "value2"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue2(string value2, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(value2 != null ? "`Value2` = @Value2" : "`Value2` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (value2 != null)
				paras_.Add(Database.CreateInParameter("@Value2", value2, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_user_itemEO.MapDataReader);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue2Async(string value2, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(value2 != null ? "`Value2` = @Value2" : "`Value2` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (value2 != null)
				paras_.Add(Database.CreateInParameter("@Value2", value2, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_user_itemEO.MapDataReader);
		}
		#endregion // GetByValue2
		#region GetByValue3
		
		/// <summary>
		/// 按 Value3（字段） 查询
		/// </summary>
		/// /// <param name = "value3"></param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue3(string value3)
		{
			return GetByValue3(value3, 0, string.Empty, null);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue3Async(string value3)
		{
			return await GetByValue3Async(value3, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Value3（字段） 查询
		/// </summary>
		/// /// <param name = "value3"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue3(string value3, TransactionManager tm_)
		{
			return GetByValue3(value3, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue3Async(string value3, TransactionManager tm_)
		{
			return await GetByValue3Async(value3, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Value3（字段） 查询
		/// </summary>
		/// /// <param name = "value3"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue3(string value3, int top_)
		{
			return GetByValue3(value3, top_, string.Empty, null);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue3Async(string value3, int top_)
		{
			return await GetByValue3Async(value3, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Value3（字段） 查询
		/// </summary>
		/// /// <param name = "value3"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue3(string value3, int top_, TransactionManager tm_)
		{
			return GetByValue3(value3, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue3Async(string value3, int top_, TransactionManager tm_)
		{
			return await GetByValue3Async(value3, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Value3（字段） 查询
		/// </summary>
		/// /// <param name = "value3"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue3(string value3, string sort_)
		{
			return GetByValue3(value3, 0, sort_, null);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue3Async(string value3, string sort_)
		{
			return await GetByValue3Async(value3, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Value3（字段） 查询
		/// </summary>
		/// /// <param name = "value3"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue3(string value3, string sort_, TransactionManager tm_)
		{
			return GetByValue3(value3, 0, sort_, tm_);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue3Async(string value3, string sort_, TransactionManager tm_)
		{
			return await GetByValue3Async(value3, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Value3（字段） 查询
		/// </summary>
		/// /// <param name = "value3"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue3(string value3, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(value3 != null ? "`Value3` = @Value3" : "`Value3` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (value3 != null)
				paras_.Add(Database.CreateInParameter("@Value3", value3, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_user_itemEO.MapDataReader);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue3Async(string value3, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(value3 != null ? "`Value3` = @Value3" : "`Value3` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (value3 != null)
				paras_.Add(Database.CreateInParameter("@Value3", value3, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_user_itemEO.MapDataReader);
		}
		#endregion // GetByValue3
		#region GetByValue4
		
		/// <summary>
		/// 按 Value4（字段） 查询
		/// </summary>
		/// /// <param name = "value4"></param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue4(string value4)
		{
			return GetByValue4(value4, 0, string.Empty, null);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue4Async(string value4)
		{
			return await GetByValue4Async(value4, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Value4（字段） 查询
		/// </summary>
		/// /// <param name = "value4"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue4(string value4, TransactionManager tm_)
		{
			return GetByValue4(value4, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue4Async(string value4, TransactionManager tm_)
		{
			return await GetByValue4Async(value4, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Value4（字段） 查询
		/// </summary>
		/// /// <param name = "value4"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue4(string value4, int top_)
		{
			return GetByValue4(value4, top_, string.Empty, null);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue4Async(string value4, int top_)
		{
			return await GetByValue4Async(value4, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Value4（字段） 查询
		/// </summary>
		/// /// <param name = "value4"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue4(string value4, int top_, TransactionManager tm_)
		{
			return GetByValue4(value4, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue4Async(string value4, int top_, TransactionManager tm_)
		{
			return await GetByValue4Async(value4, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Value4（字段） 查询
		/// </summary>
		/// /// <param name = "value4"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue4(string value4, string sort_)
		{
			return GetByValue4(value4, 0, sort_, null);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue4Async(string value4, string sort_)
		{
			return await GetByValue4Async(value4, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Value4（字段） 查询
		/// </summary>
		/// /// <param name = "value4"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue4(string value4, string sort_, TransactionManager tm_)
		{
			return GetByValue4(value4, 0, sort_, tm_);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue4Async(string value4, string sort_, TransactionManager tm_)
		{
			return await GetByValue4Async(value4, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Value4（字段） 查询
		/// </summary>
		/// /// <param name = "value4"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue4(string value4, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(value4 != null ? "`Value4` = @Value4" : "`Value4` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (value4 != null)
				paras_.Add(Database.CreateInParameter("@Value4", value4, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_user_itemEO.MapDataReader);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue4Async(string value4, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(value4 != null ? "`Value4` = @Value4" : "`Value4` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (value4 != null)
				paras_.Add(Database.CreateInParameter("@Value4", value4, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_user_itemEO.MapDataReader);
		}
		#endregion // GetByValue4
		#region GetByValue5
		
		/// <summary>
		/// 按 Value5（字段） 查询
		/// </summary>
		/// /// <param name = "value5"></param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue5(string value5)
		{
			return GetByValue5(value5, 0, string.Empty, null);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue5Async(string value5)
		{
			return await GetByValue5Async(value5, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Value5（字段） 查询
		/// </summary>
		/// /// <param name = "value5"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue5(string value5, TransactionManager tm_)
		{
			return GetByValue5(value5, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue5Async(string value5, TransactionManager tm_)
		{
			return await GetByValue5Async(value5, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Value5（字段） 查询
		/// </summary>
		/// /// <param name = "value5"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue5(string value5, int top_)
		{
			return GetByValue5(value5, top_, string.Empty, null);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue5Async(string value5, int top_)
		{
			return await GetByValue5Async(value5, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Value5（字段） 查询
		/// </summary>
		/// /// <param name = "value5"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue5(string value5, int top_, TransactionManager tm_)
		{
			return GetByValue5(value5, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue5Async(string value5, int top_, TransactionManager tm_)
		{
			return await GetByValue5Async(value5, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Value5（字段） 查询
		/// </summary>
		/// /// <param name = "value5"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue5(string value5, string sort_)
		{
			return GetByValue5(value5, 0, sort_, null);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue5Async(string value5, string sort_)
		{
			return await GetByValue5Async(value5, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Value5（字段） 查询
		/// </summary>
		/// /// <param name = "value5"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue5(string value5, string sort_, TransactionManager tm_)
		{
			return GetByValue5(value5, 0, sort_, tm_);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue5Async(string value5, string sort_, TransactionManager tm_)
		{
			return await GetByValue5Async(value5, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Value5（字段） 查询
		/// </summary>
		/// /// <param name = "value5"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue5(string value5, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(value5 != null ? "`Value5` = @Value5" : "`Value5` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (value5 != null)
				paras_.Add(Database.CreateInParameter("@Value5", value5, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_user_itemEO.MapDataReader);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue5Async(string value5, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(value5 != null ? "`Value5` = @Value5" : "`Value5` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (value5 != null)
				paras_.Add(Database.CreateInParameter("@Value5", value5, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_user_itemEO.MapDataReader);
		}
		#endregion // GetByValue5
		#region GetByValue6
		
		/// <summary>
		/// 按 Value6（字段） 查询
		/// </summary>
		/// /// <param name = "value6"></param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue6(string value6)
		{
			return GetByValue6(value6, 0, string.Empty, null);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue6Async(string value6)
		{
			return await GetByValue6Async(value6, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Value6（字段） 查询
		/// </summary>
		/// /// <param name = "value6"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue6(string value6, TransactionManager tm_)
		{
			return GetByValue6(value6, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue6Async(string value6, TransactionManager tm_)
		{
			return await GetByValue6Async(value6, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Value6（字段） 查询
		/// </summary>
		/// /// <param name = "value6"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue6(string value6, int top_)
		{
			return GetByValue6(value6, top_, string.Empty, null);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue6Async(string value6, int top_)
		{
			return await GetByValue6Async(value6, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Value6（字段） 查询
		/// </summary>
		/// /// <param name = "value6"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue6(string value6, int top_, TransactionManager tm_)
		{
			return GetByValue6(value6, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue6Async(string value6, int top_, TransactionManager tm_)
		{
			return await GetByValue6Async(value6, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Value6（字段） 查询
		/// </summary>
		/// /// <param name = "value6"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue6(string value6, string sort_)
		{
			return GetByValue6(value6, 0, sort_, null);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue6Async(string value6, string sort_)
		{
			return await GetByValue6Async(value6, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Value6（字段） 查询
		/// </summary>
		/// /// <param name = "value6"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue6(string value6, string sort_, TransactionManager tm_)
		{
			return GetByValue6(value6, 0, sort_, tm_);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue6Async(string value6, string sort_, TransactionManager tm_)
		{
			return await GetByValue6Async(value6, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Value6（字段） 查询
		/// </summary>
		/// /// <param name = "value6"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue6(string value6, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(value6 != null ? "`Value6` = @Value6" : "`Value6` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (value6 != null)
				paras_.Add(Database.CreateInParameter("@Value6", value6, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_user_itemEO.MapDataReader);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue6Async(string value6, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(value6 != null ? "`Value6` = @Value6" : "`Value6` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (value6 != null)
				paras_.Add(Database.CreateInParameter("@Value6", value6, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_user_itemEO.MapDataReader);
		}
		#endregion // GetByValue6
		#region GetByValue7
		
		/// <summary>
		/// 按 Value7（字段） 查询
		/// </summary>
		/// /// <param name = "value7"></param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue7(string value7)
		{
			return GetByValue7(value7, 0, string.Empty, null);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue7Async(string value7)
		{
			return await GetByValue7Async(value7, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Value7（字段） 查询
		/// </summary>
		/// /// <param name = "value7"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue7(string value7, TransactionManager tm_)
		{
			return GetByValue7(value7, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue7Async(string value7, TransactionManager tm_)
		{
			return await GetByValue7Async(value7, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Value7（字段） 查询
		/// </summary>
		/// /// <param name = "value7"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue7(string value7, int top_)
		{
			return GetByValue7(value7, top_, string.Empty, null);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue7Async(string value7, int top_)
		{
			return await GetByValue7Async(value7, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Value7（字段） 查询
		/// </summary>
		/// /// <param name = "value7"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue7(string value7, int top_, TransactionManager tm_)
		{
			return GetByValue7(value7, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue7Async(string value7, int top_, TransactionManager tm_)
		{
			return await GetByValue7Async(value7, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Value7（字段） 查询
		/// </summary>
		/// /// <param name = "value7"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue7(string value7, string sort_)
		{
			return GetByValue7(value7, 0, sort_, null);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue7Async(string value7, string sort_)
		{
			return await GetByValue7Async(value7, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Value7（字段） 查询
		/// </summary>
		/// /// <param name = "value7"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue7(string value7, string sort_, TransactionManager tm_)
		{
			return GetByValue7(value7, 0, sort_, tm_);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue7Async(string value7, string sort_, TransactionManager tm_)
		{
			return await GetByValue7Async(value7, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Value7（字段） 查询
		/// </summary>
		/// /// <param name = "value7"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue7(string value7, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(value7 != null ? "`Value7` = @Value7" : "`Value7` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (value7 != null)
				paras_.Add(Database.CreateInParameter("@Value7", value7, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_user_itemEO.MapDataReader);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue7Async(string value7, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(value7 != null ? "`Value7` = @Value7" : "`Value7` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (value7 != null)
				paras_.Add(Database.CreateInParameter("@Value7", value7, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_user_itemEO.MapDataReader);
		}
		#endregion // GetByValue7
		#region GetByValue8
		
		/// <summary>
		/// 按 Value8（字段） 查询
		/// </summary>
		/// /// <param name = "value8"></param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue8(string value8)
		{
			return GetByValue8(value8, 0, string.Empty, null);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue8Async(string value8)
		{
			return await GetByValue8Async(value8, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Value8（字段） 查询
		/// </summary>
		/// /// <param name = "value8"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue8(string value8, TransactionManager tm_)
		{
			return GetByValue8(value8, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue8Async(string value8, TransactionManager tm_)
		{
			return await GetByValue8Async(value8, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Value8（字段） 查询
		/// </summary>
		/// /// <param name = "value8"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue8(string value8, int top_)
		{
			return GetByValue8(value8, top_, string.Empty, null);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue8Async(string value8, int top_)
		{
			return await GetByValue8Async(value8, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Value8（字段） 查询
		/// </summary>
		/// /// <param name = "value8"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue8(string value8, int top_, TransactionManager tm_)
		{
			return GetByValue8(value8, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue8Async(string value8, int top_, TransactionManager tm_)
		{
			return await GetByValue8Async(value8, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Value8（字段） 查询
		/// </summary>
		/// /// <param name = "value8"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue8(string value8, string sort_)
		{
			return GetByValue8(value8, 0, sort_, null);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue8Async(string value8, string sort_)
		{
			return await GetByValue8Async(value8, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Value8（字段） 查询
		/// </summary>
		/// /// <param name = "value8"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue8(string value8, string sort_, TransactionManager tm_)
		{
			return GetByValue8(value8, 0, sort_, tm_);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue8Async(string value8, string sort_, TransactionManager tm_)
		{
			return await GetByValue8Async(value8, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Value8（字段） 查询
		/// </summary>
		/// /// <param name = "value8"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue8(string value8, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(value8 != null ? "`Value8` = @Value8" : "`Value8` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (value8 != null)
				paras_.Add(Database.CreateInParameter("@Value8", value8, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_user_itemEO.MapDataReader);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue8Async(string value8, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(value8 != null ? "`Value8` = @Value8" : "`Value8` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (value8 != null)
				paras_.Add(Database.CreateInParameter("@Value8", value8, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_user_itemEO.MapDataReader);
		}
		#endregion // GetByValue8
		#region GetByValue9
		
		/// <summary>
		/// 按 Value9（字段） 查询
		/// </summary>
		/// /// <param name = "value9"></param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue9(string value9)
		{
			return GetByValue9(value9, 0, string.Empty, null);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue9Async(string value9)
		{
			return await GetByValue9Async(value9, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Value9（字段） 查询
		/// </summary>
		/// /// <param name = "value9"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue9(string value9, TransactionManager tm_)
		{
			return GetByValue9(value9, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue9Async(string value9, TransactionManager tm_)
		{
			return await GetByValue9Async(value9, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Value9（字段） 查询
		/// </summary>
		/// /// <param name = "value9"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue9(string value9, int top_)
		{
			return GetByValue9(value9, top_, string.Empty, null);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue9Async(string value9, int top_)
		{
			return await GetByValue9Async(value9, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Value9（字段） 查询
		/// </summary>
		/// /// <param name = "value9"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue9(string value9, int top_, TransactionManager tm_)
		{
			return GetByValue9(value9, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue9Async(string value9, int top_, TransactionManager tm_)
		{
			return await GetByValue9Async(value9, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Value9（字段） 查询
		/// </summary>
		/// /// <param name = "value9"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue9(string value9, string sort_)
		{
			return GetByValue9(value9, 0, sort_, null);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue9Async(string value9, string sort_)
		{
			return await GetByValue9Async(value9, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Value9（字段） 查询
		/// </summary>
		/// /// <param name = "value9"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue9(string value9, string sort_, TransactionManager tm_)
		{
			return GetByValue9(value9, 0, sort_, tm_);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue9Async(string value9, string sort_, TransactionManager tm_)
		{
			return await GetByValue9Async(value9, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Value9（字段） 查询
		/// </summary>
		/// /// <param name = "value9"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue9(string value9, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(value9 != null ? "`Value9` = @Value9" : "`Value9` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (value9 != null)
				paras_.Add(Database.CreateInParameter("@Value9", value9, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_user_itemEO.MapDataReader);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue9Async(string value9, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(value9 != null ? "`Value9` = @Value9" : "`Value9` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (value9 != null)
				paras_.Add(Database.CreateInParameter("@Value9", value9, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_user_itemEO.MapDataReader);
		}
		#endregion // GetByValue9
		#region GetByValue10
		
		/// <summary>
		/// 按 Value10（字段） 查询
		/// </summary>
		/// /// <param name = "value10"></param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue10(string value10)
		{
			return GetByValue10(value10, 0, string.Empty, null);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue10Async(string value10)
		{
			return await GetByValue10Async(value10, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Value10（字段） 查询
		/// </summary>
		/// /// <param name = "value10"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue10(string value10, TransactionManager tm_)
		{
			return GetByValue10(value10, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue10Async(string value10, TransactionManager tm_)
		{
			return await GetByValue10Async(value10, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Value10（字段） 查询
		/// </summary>
		/// /// <param name = "value10"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue10(string value10, int top_)
		{
			return GetByValue10(value10, top_, string.Empty, null);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue10Async(string value10, int top_)
		{
			return await GetByValue10Async(value10, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Value10（字段） 查询
		/// </summary>
		/// /// <param name = "value10"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue10(string value10, int top_, TransactionManager tm_)
		{
			return GetByValue10(value10, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue10Async(string value10, int top_, TransactionManager tm_)
		{
			return await GetByValue10Async(value10, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Value10（字段） 查询
		/// </summary>
		/// /// <param name = "value10"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue10(string value10, string sort_)
		{
			return GetByValue10(value10, 0, sort_, null);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue10Async(string value10, string sort_)
		{
			return await GetByValue10Async(value10, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Value10（字段） 查询
		/// </summary>
		/// /// <param name = "value10"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue10(string value10, string sort_, TransactionManager tm_)
		{
			return GetByValue10(value10, 0, sort_, tm_);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue10Async(string value10, string sort_, TransactionManager tm_)
		{
			return await GetByValue10Async(value10, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Value10（字段） 查询
		/// </summary>
		/// /// <param name = "value10"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_itemEO> GetByValue10(string value10, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(value10 != null ? "`Value10` = @Value10" : "`Value10` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (value10 != null)
				paras_.Add(Database.CreateInParameter("@Value10", value10, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_user_itemEO.MapDataReader);
		}
		public async Task<List<Sat_user_itemEO>> GetByValue10Async(string value10, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(value10 != null ? "`Value10` = @Value10" : "`Value10` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (value10 != null)
				paras_.Add(Database.CreateInParameter("@Value10", value10, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_user_itemEO.MapDataReader);
		}
		#endregion // GetByValue10
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
