/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * AiUo代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/AiUo
 * 文档生成时间：2023-10-24 18: 04:58
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
	/// 运营商活动事件关系表
	/// 【表 l_activity_event_operator 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class L_activity_event_operatorEO : IRowMapper<L_activity_event_operatorEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public L_activity_event_operatorEO()
		{
			this.Status = false;
			this.RecDate = DateTime.Now;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private string _originalOperatorID;
		/// <summary>
		/// 【数据库中的原始主键 OperatorID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalOperatorID
		{
			get { return _originalOperatorID; }
			set { HasOriginal = true; _originalOperatorID = value; }
		}
		
		private int _originalActivityID;
		/// <summary>
		/// 【数据库中的原始主键 ActivityID 值的副本，用于主键值更新】
		/// </summary>
		public int OriginalActivityID
		{
			get { return _originalActivityID; }
			set { HasOriginal = true; _originalActivityID = value; }
		}
		
		private int _originalActivityEventId;
		/// <summary>
		/// 【数据库中的原始主键 ActivityEventId 值的副本，用于主键值更新】
		/// </summary>
		public int OriginalActivityEventId
		{
			get { return _originalActivityEventId; }
			set { HasOriginal = true; _originalActivityEventId = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "OperatorID", OperatorID },  { "ActivityID", ActivityID },  { "ActivityEventId", ActivityEventId }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 运营商编码
		/// 【主键 varchar(50)】
		/// </summary>
		[DataMember(Order = 1)]
		public string OperatorID { get; set; }
		/// <summary>
		/// 活动id
		/// 【主键 int】
		/// </summary>
		[DataMember(Order = 2)]
		public int ActivityID { get; set; }
		/// <summary>
		/// 活动事件id
		/// 【主键 int】
		/// </summary>
		[DataMember(Order = 3)]
		public int ActivityEventId { get; set; }
		/// <summary>
		/// 国家编码ISO 3166-1三位字母
		/// 【字段 varchar(5)】
		/// </summary>
		[DataMember(Order = 4)]
		public string CountryID { get; set; }
		/// <summary>
		/// 货币类型
		/// 【字段 varchar(20)】
		/// </summary>
		[DataMember(Order = 5)]
		public string CurrencyID { get; set; }
		/// <summary>
		/// 状态(0-无效1-有效)
		/// 【字段 tinyint(1)】
		/// </summary>
		[DataMember(Order = 6)]
		public bool Status { get; set; }
		/// <summary>
		/// 记录时间
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
		public L_activity_event_operatorEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static L_activity_event_operatorEO MapDataReader(IDataReader reader)
		{
		    L_activity_event_operatorEO ret = new L_activity_event_operatorEO();
			ret.OperatorID = reader.ToString("OperatorID");
			ret.OriginalOperatorID = ret.OperatorID;
			ret.ActivityID = reader.ToInt32("ActivityID");
			ret.OriginalActivityID = ret.ActivityID;
			ret.ActivityEventId = reader.ToInt32("ActivityEventId");
			ret.OriginalActivityEventId = ret.ActivityEventId;
			ret.CountryID = reader.ToString("CountryID");
			ret.CurrencyID = reader.ToString("CurrencyID");
			ret.Status = reader.ToBoolean("Status");
			ret.RecDate = reader.ToDateTime("RecDate");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 运营商活动事件关系表
	/// 【表 l_activity_event_operator 的操作类】
	/// </summary>
	[Obsolete]
	public class L_activity_event_operatorMO : MySqlTableMO<L_activity_event_operatorEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`l_activity_event_operator`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public L_activity_event_operatorMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public L_activity_event_operatorMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public L_activity_event_operatorMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(L_activity_event_operatorEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(L_activity_event_operatorEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(L_activity_event_operatorEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`OperatorID`, `ActivityID`, `ActivityEventId`, `CountryID`, `CurrencyID`, `Status`, `RecDate`) VALUE (@OperatorID, @ActivityID, @ActivityEventId, @CountryID, @CurrencyID, @Status, @RecDate);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ActivityID", item.ActivityID, MySqlDbType.Int32),
				Database.CreateInParameter("@ActivityEventId", item.ActivityEventId, MySqlDbType.Int32),
				Database.CreateInParameter("@CountryID", item.CountryID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID != null ? item.CurrencyID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Status", item.Status, MySqlDbType.Byte),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
			};
		}
		public int AddByBatch(IEnumerable<L_activity_event_operatorEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<L_activity_event_operatorEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<L_activity_event_operatorEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`OperatorID`, `ActivityID`, `ActivityEventId`, `CountryID`, `CurrencyID`, `Status`, `RecDate`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.OperatorID}',{item.ActivityID},{item.ActivityEventId},'{item.CountryID}','{item.CurrencyID}',{item.Status},'{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "activityID">活动id</param>
		/// /// <param name = "activityEventId">活动事件id</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string operatorID, int activityID, int activityEventId, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(operatorID, activityID, activityEventId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string operatorID, int activityID, int activityEventId, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(operatorID, activityID, activityEventId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string operatorID, int activityID, int activityEventId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `OperatorID` = @OperatorID AND `ActivityID` = @ActivityID AND `ActivityEventId` = @ActivityEventId";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.Int32),
				Database.CreateInParameter("@ActivityEventId", activityEventId, MySqlDbType.Int32),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(L_activity_event_operatorEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.OperatorID, item.ActivityID, item.ActivityEventId, tm_);
		}
		public async Task<int> RemoveAsync(L_activity_event_operatorEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.OperatorID, item.ActivityID, item.ActivityEventId, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
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
		#region RemoveByActivityID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "activityID">活动id</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByActivityID(int activityID, TransactionManager tm_ = null)
		{
			RepairRemoveByActivityIDData(activityID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByActivityIDAsync(int activityID, TransactionManager tm_ = null)
		{
			RepairRemoveByActivityIDData(activityID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByActivityIDData(int activityID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `ActivityID` = @ActivityID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.Int32));
		}
		#endregion // RemoveByActivityID
		#region RemoveByActivityEventId
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "activityEventId">活动事件id</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByActivityEventId(int activityEventId, TransactionManager tm_ = null)
		{
			RepairRemoveByActivityEventIdData(activityEventId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByActivityEventIdAsync(int activityEventId, TransactionManager tm_ = null)
		{
			RepairRemoveByActivityEventIdData(activityEventId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByActivityEventIdData(int activityEventId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `ActivityEventId` = @ActivityEventId";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ActivityEventId", activityEventId, MySqlDbType.Int32));
		}
		#endregion // RemoveByActivityEventId
		#region RemoveByCountryID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCountryID(string countryID, TransactionManager tm_ = null)
		{
			RepairRemoveByCountryIDData(countryID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCountryIDAsync(string countryID, TransactionManager tm_ = null)
		{
			RepairRemoveByCountryIDData(countryID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCountryIDData(string countryID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `CountryID` = @CountryID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByCountryID
		#region RemoveByCurrencyID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCurrencyID(string currencyID, TransactionManager tm_ = null)
		{
			RepairRemoveByCurrencyIDData(currencyID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCurrencyIDAsync(string currencyID, TransactionManager tm_ = null)
		{
			RepairRemoveByCurrencyIDData(currencyID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCurrencyIDData(string currencyID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (currencyID != null ? "`CurrencyID` = @CurrencyID" : "`CurrencyID` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (currencyID != null)
				paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByCurrencyID
		#region RemoveByStatus
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByStatus(bool status, TransactionManager tm_ = null)
		{
			RepairRemoveByStatusData(status, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByStatusAsync(bool status, TransactionManager tm_ = null)
		{
			RepairRemoveByStatusData(status, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByStatusData(bool status, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Status` = @Status";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Byte));
		}
		#endregion // RemoveByStatus
		#region RemoveByRecDate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
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
		public int Put(L_activity_event_operatorEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(L_activity_event_operatorEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(L_activity_event_operatorEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID, `ActivityID` = @ActivityID, `ActivityEventId` = @ActivityEventId, `CountryID` = @CountryID, `CurrencyID` = @CurrencyID, `Status` = @Status WHERE `OperatorID` = @OperatorID_Original AND `ActivityID` = @ActivityID_Original AND `ActivityEventId` = @ActivityEventId_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ActivityID", item.ActivityID, MySqlDbType.Int32),
				Database.CreateInParameter("@ActivityEventId", item.ActivityEventId, MySqlDbType.Int32),
				Database.CreateInParameter("@CountryID", item.CountryID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID != null ? item.CurrencyID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Status", item.Status, MySqlDbType.Byte),
				Database.CreateInParameter("@OperatorID_Original", item.HasOriginal ? item.OriginalOperatorID : item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ActivityID_Original", item.HasOriginal ? item.OriginalActivityID : item.ActivityID, MySqlDbType.Int32),
				Database.CreateInParameter("@ActivityEventId_Original", item.HasOriginal ? item.OriginalActivityEventId : item.ActivityEventId, MySqlDbType.Int32),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<L_activity_event_operatorEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<L_activity_event_operatorEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "activityID">活动id</param>
		/// /// <param name = "activityEventId">活动事件id</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string operatorID, int activityID, int activityEventId, string set_, params object[] values_)
		{
			return Put(set_, "`OperatorID` = @OperatorID AND `ActivityID` = @ActivityID AND `ActivityEventId` = @ActivityEventId", ConcatValues(values_, operatorID, activityID, activityEventId));
		}
		public async Task<int> PutByPKAsync(string operatorID, int activityID, int activityEventId, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`OperatorID` = @OperatorID AND `ActivityID` = @ActivityID AND `ActivityEventId` = @ActivityEventId", ConcatValues(values_, operatorID, activityID, activityEventId));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "activityID">活动id</param>
		/// /// <param name = "activityEventId">活动事件id</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string operatorID, int activityID, int activityEventId, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`OperatorID` = @OperatorID AND `ActivityID` = @ActivityID AND `ActivityEventId` = @ActivityEventId", tm_, ConcatValues(values_, operatorID, activityID, activityEventId));
		}
		public async Task<int> PutByPKAsync(string operatorID, int activityID, int activityEventId, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`OperatorID` = @OperatorID AND `ActivityID` = @ActivityID AND `ActivityEventId` = @ActivityEventId", tm_, ConcatValues(values_, operatorID, activityID, activityEventId));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "activityID">活动id</param>
		/// /// <param name = "activityEventId">活动事件id</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string operatorID, int activityID, int activityEventId, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.Int32),
				Database.CreateInParameter("@ActivityEventId", activityEventId, MySqlDbType.Int32),
	        };
			return Put(set_, "`OperatorID` = @OperatorID AND `ActivityID` = @ActivityID AND `ActivityEventId` = @ActivityEventId", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string operatorID, int activityID, int activityEventId, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.Int32),
				Database.CreateInParameter("@ActivityEventId", activityEventId, MySqlDbType.Int32),
	        };
			return await PutAsync(set_, "`OperatorID` = @OperatorID AND `ActivityID` = @ActivityID AND `ActivityEventId` = @ActivityEventId", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
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
		#region PutActivityID
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "activityID">活动id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutActivityID(int activityID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ActivityID` = @ActivityID";
			var parameter_ = Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutActivityIDAsync(int activityID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ActivityID` = @ActivityID";
			var parameter_ = Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutActivityID
		#region PutActivityEventId
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "activityEventId">活动事件id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutActivityEventId(int activityEventId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ActivityEventId` = @ActivityEventId";
			var parameter_ = Database.CreateInParameter("@ActivityEventId", activityEventId, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutActivityEventIdAsync(int activityEventId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ActivityEventId` = @ActivityEventId";
			var parameter_ = Database.CreateInParameter("@ActivityEventId", activityEventId, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutActivityEventId
		#region PutCountryID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "activityID">活动id</param>
		/// /// <param name = "activityEventId">活动事件id</param>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCountryIDByPK(string operatorID, int activityID, int activityEventId, string countryID, TransactionManager tm_ = null)
		{
			RepairPutCountryIDByPKData(operatorID, activityID, activityEventId, countryID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCountryIDByPKAsync(string operatorID, int activityID, int activityEventId, string countryID, TransactionManager tm_ = null)
		{
			RepairPutCountryIDByPKData(operatorID, activityID, activityEventId, countryID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCountryIDByPKData(string operatorID, int activityID, int activityEventId, string countryID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CountryID` = @CountryID  WHERE `OperatorID` = @OperatorID AND `ActivityID` = @ActivityID AND `ActivityEventId` = @ActivityEventId";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.Int32),
				Database.CreateInParameter("@ActivityEventId", activityEventId, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCountryID(string countryID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CountryID` = @CountryID";
			var parameter_ = Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCountryIDAsync(string countryID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CountryID` = @CountryID";
			var parameter_ = Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCountryID
		#region PutCurrencyID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "activityID">活动id</param>
		/// /// <param name = "activityEventId">活动事件id</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCurrencyIDByPK(string operatorID, int activityID, int activityEventId, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(operatorID, activityID, activityEventId, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCurrencyIDByPKAsync(string operatorID, int activityID, int activityEventId, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(operatorID, activityID, activityEventId, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCurrencyIDByPKData(string operatorID, int activityID, int activityEventId, string currencyID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CurrencyID` = @CurrencyID  WHERE `OperatorID` = @OperatorID AND `ActivityID` = @ActivityID AND `ActivityEventId` = @ActivityEventId";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CurrencyID", currencyID != null ? currencyID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.Int32),
				Database.CreateInParameter("@ActivityEventId", activityEventId, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCurrencyID(string currencyID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CurrencyID` = @CurrencyID";
			var parameter_ = Database.CreateInParameter("@CurrencyID", currencyID != null ? currencyID : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCurrencyIDAsync(string currencyID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CurrencyID` = @CurrencyID";
			var parameter_ = Database.CreateInParameter("@CurrencyID", currencyID != null ? currencyID : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCurrencyID
		#region PutStatus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "activityID">活动id</param>
		/// /// <param name = "activityEventId">活动事件id</param>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutStatusByPK(string operatorID, int activityID, int activityEventId, bool status, TransactionManager tm_ = null)
		{
			RepairPutStatusByPKData(operatorID, activityID, activityEventId, status, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutStatusByPKAsync(string operatorID, int activityID, int activityEventId, bool status, TransactionManager tm_ = null)
		{
			RepairPutStatusByPKData(operatorID, activityID, activityEventId, status, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutStatusByPKData(string operatorID, int activityID, int activityEventId, bool status, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Status` = @Status  WHERE `OperatorID` = @OperatorID AND `ActivityID` = @ActivityID AND `ActivityEventId` = @ActivityEventId";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Status", status, MySqlDbType.Byte),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.Int32),
				Database.CreateInParameter("@ActivityEventId", activityEventId, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutStatus(bool status, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Status` = @Status";
			var parameter_ = Database.CreateInParameter("@Status", status, MySqlDbType.Byte);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutStatusAsync(bool status, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Status` = @Status";
			var parameter_ = Database.CreateInParameter("@Status", status, MySqlDbType.Byte);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutStatus
		#region PutRecDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "activityID">活动id</param>
		/// /// <param name = "activityEventId">活动事件id</param>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(string operatorID, int activityID, int activityEventId, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(operatorID, activityID, activityEventId, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(string operatorID, int activityID, int activityEventId, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(operatorID, activityID, activityEventId, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(string operatorID, int activityID, int activityEventId, DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `OperatorID` = @OperatorID AND `ActivityID` = @ActivityID AND `ActivityEventId` = @ActivityEventId";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.Int32),
				Database.CreateInParameter("@ActivityEventId", activityEventId, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
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
		public bool Set(L_activity_event_operatorEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.OperatorID, item.ActivityID, item.ActivityEventId) == null)
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
		public async Task<bool> SetAsync(L_activity_event_operatorEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.OperatorID, item.ActivityID, item.ActivityEventId) == null)
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
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "activityID">活动id</param>
		/// /// <param name = "activityEventId">活动事件id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public L_activity_event_operatorEO GetByPK(string operatorID, int activityID, int activityEventId, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(operatorID, activityID, activityEventId, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, L_activity_event_operatorEO.MapDataReader);
		}
		public async Task<L_activity_event_operatorEO> GetByPKAsync(string operatorID, int activityID, int activityEventId, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(operatorID, activityID, activityEventId, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, L_activity_event_operatorEO.MapDataReader);
		}
		private void RepairGetByPKData(string operatorID, int activityID, int activityEventId, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`OperatorID` = @OperatorID AND `ActivityID` = @ActivityID AND `ActivityEventId` = @ActivityEventId", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.Int32),
				Database.CreateInParameter("@ActivityEventId", activityEventId, MySqlDbType.Int32),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 OperatorID（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "activityID">活动id</param>
		/// /// <param name = "activityEventId">活动事件id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorIDByPK(string operatorID, int activityID, int activityEventId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.Int32),
				Database.CreateInParameter("@ActivityEventId", activityEventId, MySqlDbType.Int32),
			};
			return (string)GetScalar("`OperatorID`", "`OperatorID` = @OperatorID AND `ActivityID` = @ActivityID AND `ActivityEventId` = @ActivityEventId", paras_, tm_);
		}
		public async Task<string> GetOperatorIDByPKAsync(string operatorID, int activityID, int activityEventId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.Int32),
				Database.CreateInParameter("@ActivityEventId", activityEventId, MySqlDbType.Int32),
			};
			return (string)await GetScalarAsync("`OperatorID`", "`OperatorID` = @OperatorID AND `ActivityID` = @ActivityID AND `ActivityEventId` = @ActivityEventId", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ActivityID（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "activityID">活动id</param>
		/// /// <param name = "activityEventId">活动事件id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetActivityIDByPK(string operatorID, int activityID, int activityEventId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.Int32),
				Database.CreateInParameter("@ActivityEventId", activityEventId, MySqlDbType.Int32),
			};
			return (int)GetScalar("`ActivityID`", "`OperatorID` = @OperatorID AND `ActivityID` = @ActivityID AND `ActivityEventId` = @ActivityEventId", paras_, tm_);
		}
		public async Task<int> GetActivityIDByPKAsync(string operatorID, int activityID, int activityEventId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.Int32),
				Database.CreateInParameter("@ActivityEventId", activityEventId, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`ActivityID`", "`OperatorID` = @OperatorID AND `ActivityID` = @ActivityID AND `ActivityEventId` = @ActivityEventId", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ActivityEventId（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "activityID">活动id</param>
		/// /// <param name = "activityEventId">活动事件id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetActivityEventIdByPK(string operatorID, int activityID, int activityEventId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.Int32),
				Database.CreateInParameter("@ActivityEventId", activityEventId, MySqlDbType.Int32),
			};
			return (int)GetScalar("`ActivityEventId`", "`OperatorID` = @OperatorID AND `ActivityID` = @ActivityID AND `ActivityEventId` = @ActivityEventId", paras_, tm_);
		}
		public async Task<int> GetActivityEventIdByPKAsync(string operatorID, int activityID, int activityEventId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.Int32),
				Database.CreateInParameter("@ActivityEventId", activityEventId, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`ActivityEventId`", "`OperatorID` = @OperatorID AND `ActivityID` = @ActivityID AND `ActivityEventId` = @ActivityEventId", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CountryID（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "activityID">活动id</param>
		/// /// <param name = "activityEventId">活动事件id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCountryIDByPK(string operatorID, int activityID, int activityEventId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.Int32),
				Database.CreateInParameter("@ActivityEventId", activityEventId, MySqlDbType.Int32),
			};
			return (string)GetScalar("`CountryID`", "`OperatorID` = @OperatorID AND `ActivityID` = @ActivityID AND `ActivityEventId` = @ActivityEventId", paras_, tm_);
		}
		public async Task<string> GetCountryIDByPKAsync(string operatorID, int activityID, int activityEventId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.Int32),
				Database.CreateInParameter("@ActivityEventId", activityEventId, MySqlDbType.Int32),
			};
			return (string)await GetScalarAsync("`CountryID`", "`OperatorID` = @OperatorID AND `ActivityID` = @ActivityID AND `ActivityEventId` = @ActivityEventId", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CurrencyID（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "activityID">活动id</param>
		/// /// <param name = "activityEventId">活动事件id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCurrencyIDByPK(string operatorID, int activityID, int activityEventId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.Int32),
				Database.CreateInParameter("@ActivityEventId", activityEventId, MySqlDbType.Int32),
			};
			return (string)GetScalar("`CurrencyID`", "`OperatorID` = @OperatorID AND `ActivityID` = @ActivityID AND `ActivityEventId` = @ActivityEventId", paras_, tm_);
		}
		public async Task<string> GetCurrencyIDByPKAsync(string operatorID, int activityID, int activityEventId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.Int32),
				Database.CreateInParameter("@ActivityEventId", activityEventId, MySqlDbType.Int32),
			};
			return (string)await GetScalarAsync("`CurrencyID`", "`OperatorID` = @OperatorID AND `ActivityID` = @ActivityID AND `ActivityEventId` = @ActivityEventId", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Status（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "activityID">活动id</param>
		/// /// <param name = "activityEventId">活动事件id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public bool GetStatusByPK(string operatorID, int activityID, int activityEventId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.Int32),
				Database.CreateInParameter("@ActivityEventId", activityEventId, MySqlDbType.Int32),
			};
			return (bool)GetScalar("`Status`", "`OperatorID` = @OperatorID AND `ActivityID` = @ActivityID AND `ActivityEventId` = @ActivityEventId", paras_, tm_);
		}
		public async Task<bool> GetStatusByPKAsync(string operatorID, int activityID, int activityEventId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.Int32),
				Database.CreateInParameter("@ActivityEventId", activityEventId, MySqlDbType.Int32),
			};
			return (bool)await GetScalarAsync("`Status`", "`OperatorID` = @OperatorID AND `ActivityID` = @ActivityID AND `ActivityEventId` = @ActivityEventId", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "activityID">活动id</param>
		/// /// <param name = "activityEventId">活动事件id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetRecDateByPK(string operatorID, int activityID, int activityEventId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.Int32),
				Database.CreateInParameter("@ActivityEventId", activityEventId, MySqlDbType.Int32),
			};
			return (DateTime)GetScalar("`RecDate`", "`OperatorID` = @OperatorID AND `ActivityID` = @ActivityID AND `ActivityEventId` = @ActivityEventId", paras_, tm_);
		}
		public async Task<DateTime> GetRecDateByPKAsync(string operatorID, int activityID, int activityEventId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.Int32),
				Database.CreateInParameter("@ActivityEventId", activityEventId, MySqlDbType.Int32),
			};
			return (DateTime)await GetScalarAsync("`RecDate`", "`OperatorID` = @OperatorID AND `ActivityID` = @ActivityID AND `ActivityEventId` = @ActivityEventId", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <return>实体对象集合</return>
		public List<L_activity_event_operatorEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<L_activity_event_operatorEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_event_operatorEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<L_activity_event_operatorEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_activity_event_operatorEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<L_activity_event_operatorEO>> GetByOperatorIDAsync(string operatorID, int top_)
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
		public List<L_activity_event_operatorEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<L_activity_event_operatorEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_activity_event_operatorEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<L_activity_event_operatorEO>> GetByOperatorIDAsync(string operatorID, string sort_)
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
		public List<L_activity_event_operatorEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<L_activity_event_operatorEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
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
		public List<L_activity_event_operatorEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_activity_event_operatorEO.MapDataReader);
		}
		public async Task<List<L_activity_event_operatorEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_activity_event_operatorEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByActivityID
		
		/// <summary>
		/// 按 ActivityID（字段） 查询
		/// </summary>
		/// /// <param name = "activityID">活动id</param>
		/// <return>实体对象集合</return>
		public List<L_activity_event_operatorEO> GetByActivityID(int activityID)
		{
			return GetByActivityID(activityID, 0, string.Empty, null);
		}
		public async Task<List<L_activity_event_operatorEO>> GetByActivityIDAsync(int activityID)
		{
			return await GetByActivityIDAsync(activityID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ActivityID（字段） 查询
		/// </summary>
		/// /// <param name = "activityID">活动id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_event_operatorEO> GetByActivityID(int activityID, TransactionManager tm_)
		{
			return GetByActivityID(activityID, 0, string.Empty, tm_);
		}
		public async Task<List<L_activity_event_operatorEO>> GetByActivityIDAsync(int activityID, TransactionManager tm_)
		{
			return await GetByActivityIDAsync(activityID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ActivityID（字段） 查询
		/// </summary>
		/// /// <param name = "activityID">活动id</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_activity_event_operatorEO> GetByActivityID(int activityID, int top_)
		{
			return GetByActivityID(activityID, top_, string.Empty, null);
		}
		public async Task<List<L_activity_event_operatorEO>> GetByActivityIDAsync(int activityID, int top_)
		{
			return await GetByActivityIDAsync(activityID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ActivityID（字段） 查询
		/// </summary>
		/// /// <param name = "activityID">活动id</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_event_operatorEO> GetByActivityID(int activityID, int top_, TransactionManager tm_)
		{
			return GetByActivityID(activityID, top_, string.Empty, tm_);
		}
		public async Task<List<L_activity_event_operatorEO>> GetByActivityIDAsync(int activityID, int top_, TransactionManager tm_)
		{
			return await GetByActivityIDAsync(activityID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ActivityID（字段） 查询
		/// </summary>
		/// /// <param name = "activityID">活动id</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_activity_event_operatorEO> GetByActivityID(int activityID, string sort_)
		{
			return GetByActivityID(activityID, 0, sort_, null);
		}
		public async Task<List<L_activity_event_operatorEO>> GetByActivityIDAsync(int activityID, string sort_)
		{
			return await GetByActivityIDAsync(activityID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ActivityID（字段） 查询
		/// </summary>
		/// /// <param name = "activityID">活动id</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_event_operatorEO> GetByActivityID(int activityID, string sort_, TransactionManager tm_)
		{
			return GetByActivityID(activityID, 0, sort_, tm_);
		}
		public async Task<List<L_activity_event_operatorEO>> GetByActivityIDAsync(int activityID, string sort_, TransactionManager tm_)
		{
			return await GetByActivityIDAsync(activityID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ActivityID（字段） 查询
		/// </summary>
		/// /// <param name = "activityID">活动id</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_event_operatorEO> GetByActivityID(int activityID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ActivityID` = @ActivityID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, L_activity_event_operatorEO.MapDataReader);
		}
		public async Task<List<L_activity_event_operatorEO>> GetByActivityIDAsync(int activityID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ActivityID` = @ActivityID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_activity_event_operatorEO.MapDataReader);
		}
		#endregion // GetByActivityID
		#region GetByActivityEventId
		
		/// <summary>
		/// 按 ActivityEventId（字段） 查询
		/// </summary>
		/// /// <param name = "activityEventId">活动事件id</param>
		/// <return>实体对象集合</return>
		public List<L_activity_event_operatorEO> GetByActivityEventId(int activityEventId)
		{
			return GetByActivityEventId(activityEventId, 0, string.Empty, null);
		}
		public async Task<List<L_activity_event_operatorEO>> GetByActivityEventIdAsync(int activityEventId)
		{
			return await GetByActivityEventIdAsync(activityEventId, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ActivityEventId（字段） 查询
		/// </summary>
		/// /// <param name = "activityEventId">活动事件id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_event_operatorEO> GetByActivityEventId(int activityEventId, TransactionManager tm_)
		{
			return GetByActivityEventId(activityEventId, 0, string.Empty, tm_);
		}
		public async Task<List<L_activity_event_operatorEO>> GetByActivityEventIdAsync(int activityEventId, TransactionManager tm_)
		{
			return await GetByActivityEventIdAsync(activityEventId, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ActivityEventId（字段） 查询
		/// </summary>
		/// /// <param name = "activityEventId">活动事件id</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_activity_event_operatorEO> GetByActivityEventId(int activityEventId, int top_)
		{
			return GetByActivityEventId(activityEventId, top_, string.Empty, null);
		}
		public async Task<List<L_activity_event_operatorEO>> GetByActivityEventIdAsync(int activityEventId, int top_)
		{
			return await GetByActivityEventIdAsync(activityEventId, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ActivityEventId（字段） 查询
		/// </summary>
		/// /// <param name = "activityEventId">活动事件id</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_event_operatorEO> GetByActivityEventId(int activityEventId, int top_, TransactionManager tm_)
		{
			return GetByActivityEventId(activityEventId, top_, string.Empty, tm_);
		}
		public async Task<List<L_activity_event_operatorEO>> GetByActivityEventIdAsync(int activityEventId, int top_, TransactionManager tm_)
		{
			return await GetByActivityEventIdAsync(activityEventId, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ActivityEventId（字段） 查询
		/// </summary>
		/// /// <param name = "activityEventId">活动事件id</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_activity_event_operatorEO> GetByActivityEventId(int activityEventId, string sort_)
		{
			return GetByActivityEventId(activityEventId, 0, sort_, null);
		}
		public async Task<List<L_activity_event_operatorEO>> GetByActivityEventIdAsync(int activityEventId, string sort_)
		{
			return await GetByActivityEventIdAsync(activityEventId, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ActivityEventId（字段） 查询
		/// </summary>
		/// /// <param name = "activityEventId">活动事件id</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_event_operatorEO> GetByActivityEventId(int activityEventId, string sort_, TransactionManager tm_)
		{
			return GetByActivityEventId(activityEventId, 0, sort_, tm_);
		}
		public async Task<List<L_activity_event_operatorEO>> GetByActivityEventIdAsync(int activityEventId, string sort_, TransactionManager tm_)
		{
			return await GetByActivityEventIdAsync(activityEventId, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ActivityEventId（字段） 查询
		/// </summary>
		/// /// <param name = "activityEventId">活动事件id</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_event_operatorEO> GetByActivityEventId(int activityEventId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ActivityEventId` = @ActivityEventId", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ActivityEventId", activityEventId, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, L_activity_event_operatorEO.MapDataReader);
		}
		public async Task<List<L_activity_event_operatorEO>> GetByActivityEventIdAsync(int activityEventId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ActivityEventId` = @ActivityEventId", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ActivityEventId", activityEventId, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_activity_event_operatorEO.MapDataReader);
		}
		#endregion // GetByActivityEventId
		#region GetByCountryID
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <return>实体对象集合</return>
		public List<L_activity_event_operatorEO> GetByCountryID(string countryID)
		{
			return GetByCountryID(countryID, 0, string.Empty, null);
		}
		public async Task<List<L_activity_event_operatorEO>> GetByCountryIDAsync(string countryID)
		{
			return await GetByCountryIDAsync(countryID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_event_operatorEO> GetByCountryID(string countryID, TransactionManager tm_)
		{
			return GetByCountryID(countryID, 0, string.Empty, tm_);
		}
		public async Task<List<L_activity_event_operatorEO>> GetByCountryIDAsync(string countryID, TransactionManager tm_)
		{
			return await GetByCountryIDAsync(countryID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_activity_event_operatorEO> GetByCountryID(string countryID, int top_)
		{
			return GetByCountryID(countryID, top_, string.Empty, null);
		}
		public async Task<List<L_activity_event_operatorEO>> GetByCountryIDAsync(string countryID, int top_)
		{
			return await GetByCountryIDAsync(countryID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_event_operatorEO> GetByCountryID(string countryID, int top_, TransactionManager tm_)
		{
			return GetByCountryID(countryID, top_, string.Empty, tm_);
		}
		public async Task<List<L_activity_event_operatorEO>> GetByCountryIDAsync(string countryID, int top_, TransactionManager tm_)
		{
			return await GetByCountryIDAsync(countryID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_activity_event_operatorEO> GetByCountryID(string countryID, string sort_)
		{
			return GetByCountryID(countryID, 0, sort_, null);
		}
		public async Task<List<L_activity_event_operatorEO>> GetByCountryIDAsync(string countryID, string sort_)
		{
			return await GetByCountryIDAsync(countryID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_event_operatorEO> GetByCountryID(string countryID, string sort_, TransactionManager tm_)
		{
			return GetByCountryID(countryID, 0, sort_, tm_);
		}
		public async Task<List<L_activity_event_operatorEO>> GetByCountryIDAsync(string countryID, string sort_, TransactionManager tm_)
		{
			return await GetByCountryIDAsync(countryID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_event_operatorEO> GetByCountryID(string countryID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CountryID` = @CountryID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_activity_event_operatorEO.MapDataReader);
		}
		public async Task<List<L_activity_event_operatorEO>> GetByCountryIDAsync(string countryID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CountryID` = @CountryID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_activity_event_operatorEO.MapDataReader);
		}
		#endregion // GetByCountryID
		#region GetByCurrencyID
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <return>实体对象集合</return>
		public List<L_activity_event_operatorEO> GetByCurrencyID(string currencyID)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, null);
		}
		public async Task<List<L_activity_event_operatorEO>> GetByCurrencyIDAsync(string currencyID)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_event_operatorEO> GetByCurrencyID(string currencyID, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, tm_);
		}
		public async Task<List<L_activity_event_operatorEO>> GetByCurrencyIDAsync(string currencyID, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_activity_event_operatorEO> GetByCurrencyID(string currencyID, int top_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, null);
		}
		public async Task<List<L_activity_event_operatorEO>> GetByCurrencyIDAsync(string currencyID, int top_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_event_operatorEO> GetByCurrencyID(string currencyID, int top_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, tm_);
		}
		public async Task<List<L_activity_event_operatorEO>> GetByCurrencyIDAsync(string currencyID, int top_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_activity_event_operatorEO> GetByCurrencyID(string currencyID, string sort_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, null);
		}
		public async Task<List<L_activity_event_operatorEO>> GetByCurrencyIDAsync(string currencyID, string sort_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_event_operatorEO> GetByCurrencyID(string currencyID, string sort_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, tm_);
		}
		public async Task<List<L_activity_event_operatorEO>> GetByCurrencyIDAsync(string currencyID, string sort_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_event_operatorEO> GetByCurrencyID(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(currencyID != null ? "`CurrencyID` = @CurrencyID" : "`CurrencyID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (currencyID != null)
				paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_activity_event_operatorEO.MapDataReader);
		}
		public async Task<List<L_activity_event_operatorEO>> GetByCurrencyIDAsync(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(currencyID != null ? "`CurrencyID` = @CurrencyID" : "`CurrencyID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (currencyID != null)
				paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_activity_event_operatorEO.MapDataReader);
		}
		#endregion // GetByCurrencyID
		#region GetByStatus
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <return>实体对象集合</return>
		public List<L_activity_event_operatorEO> GetByStatus(bool status)
		{
			return GetByStatus(status, 0, string.Empty, null);
		}
		public async Task<List<L_activity_event_operatorEO>> GetByStatusAsync(bool status)
		{
			return await GetByStatusAsync(status, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_event_operatorEO> GetByStatus(bool status, TransactionManager tm_)
		{
			return GetByStatus(status, 0, string.Empty, tm_);
		}
		public async Task<List<L_activity_event_operatorEO>> GetByStatusAsync(bool status, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_activity_event_operatorEO> GetByStatus(bool status, int top_)
		{
			return GetByStatus(status, top_, string.Empty, null);
		}
		public async Task<List<L_activity_event_operatorEO>> GetByStatusAsync(bool status, int top_)
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
		public List<L_activity_event_operatorEO> GetByStatus(bool status, int top_, TransactionManager tm_)
		{
			return GetByStatus(status, top_, string.Empty, tm_);
		}
		public async Task<List<L_activity_event_operatorEO>> GetByStatusAsync(bool status, int top_, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_activity_event_operatorEO> GetByStatus(bool status, string sort_)
		{
			return GetByStatus(status, 0, sort_, null);
		}
		public async Task<List<L_activity_event_operatorEO>> GetByStatusAsync(bool status, string sort_)
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
		public List<L_activity_event_operatorEO> GetByStatus(bool status, string sort_, TransactionManager tm_)
		{
			return GetByStatus(status, 0, sort_, tm_);
		}
		public async Task<List<L_activity_event_operatorEO>> GetByStatusAsync(bool status, string sort_, TransactionManager tm_)
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
		public List<L_activity_event_operatorEO> GetByStatus(bool status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Byte));
			return Database.ExecSqlList(sql_, paras_, tm_, L_activity_event_operatorEO.MapDataReader);
		}
		public async Task<List<L_activity_event_operatorEO>> GetByStatusAsync(bool status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Byte));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_activity_event_operatorEO.MapDataReader);
		}
		#endregion // GetByStatus
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <return>实体对象集合</return>
		public List<L_activity_event_operatorEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<L_activity_event_operatorEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_event_operatorEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<L_activity_event_operatorEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_activity_event_operatorEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<L_activity_event_operatorEO>> GetByRecDateAsync(DateTime recDate, int top_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_event_operatorEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<L_activity_event_operatorEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_activity_event_operatorEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<L_activity_event_operatorEO>> GetByRecDateAsync(DateTime recDate, string sort_)
		{
			return await GetByRecDateAsync(recDate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_event_operatorEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<L_activity_event_operatorEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_event_operatorEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, L_activity_event_operatorEO.MapDataReader);
		}
		public async Task<List<L_activity_event_operatorEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_activity_event_operatorEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
