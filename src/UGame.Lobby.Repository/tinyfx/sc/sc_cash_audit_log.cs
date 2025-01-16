/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * AiUo代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/AiUo
 * 文档生成时间：2023-10-24 18: 04:53
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
	/// 【表 sc_cash_audit_log 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Sc_cash_audit_logEO : IRowMapper<Sc_cash_audit_logEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Sc_cash_audit_logEO()
		{
			this.Action = 0;
			this.RecDate = DateTime.Now;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private string _originalAuditLogID;
		/// <summary>
		/// 【数据库中的原始主键 AuditLogID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalAuditLogID
		{
			get { return _originalAuditLogID; }
			set { HasOriginal = true; _originalAuditLogID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "AuditLogID", AuditLogID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// GUID
		/// 【主键 varchar(36)】
		/// </summary>
		[DataMember(Order = 1)]
		public string AuditLogID { get; set; }
		/// <summary>
		/// 主键guid
		/// 【字段 varchar(36)】
		/// </summary>
		[DataMember(Order = 2)]
		public string CashAuditID { get; set; }
		/// <summary>
		/// 操作0-提交申请1-审批通过2-审批拒绝
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 3)]
		public int Action { get; set; }
		/// <summary>
		/// 操作人ID
		/// 【字段 varchar(36)】
		/// </summary>
		[DataMember(Order = 4)]
		public string OperatorId { get; set; }
		/// <summary>
		/// 操作人
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 5)]
		public string OperatorName { get; set; }
		/// <summary>
		/// 记录时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 6)]
		public DateTime RecDate { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Sc_cash_audit_logEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Sc_cash_audit_logEO MapDataReader(IDataReader reader)
		{
		    Sc_cash_audit_logEO ret = new Sc_cash_audit_logEO();
			ret.AuditLogID = reader.ToString("AuditLogID");
			ret.OriginalAuditLogID = ret.AuditLogID;
			ret.CashAuditID = reader.ToString("CashAuditID");
			ret.Action = reader.ToInt32("Action");
			ret.OperatorId = reader.ToString("OperatorId");
			ret.OperatorName = reader.ToString("OperatorName");
			ret.RecDate = reader.ToDateTime("RecDate");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 
	/// 【表 sc_cash_audit_log 的操作类】
	/// </summary>
	[Obsolete]
	public class Sc_cash_audit_logMO : MySqlTableMO<Sc_cash_audit_logEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`sc_cash_audit_log`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Sc_cash_audit_logMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Sc_cash_audit_logMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Sc_cash_audit_logMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Sc_cash_audit_logEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Sc_cash_audit_logEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Sc_cash_audit_logEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`AuditLogID`, `CashAuditID`, `Action`, `OperatorId`, `OperatorName`, `RecDate`) VALUE (@AuditLogID, @CashAuditID, @Action, @OperatorId, @OperatorName, @RecDate);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AuditLogID", item.AuditLogID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CashAuditID", item.CashAuditID != null ? item.CashAuditID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Action", item.Action, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorId", item.OperatorId, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorName", item.OperatorName, MySqlDbType.VarChar),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
			};
		}
		public int AddByBatch(IEnumerable<Sc_cash_audit_logEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Sc_cash_audit_logEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sc_cash_audit_logEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`AuditLogID`, `CashAuditID`, `Action`, `OperatorId`, `OperatorName`, `RecDate`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.AuditLogID}','{item.CashAuditID}',{item.Action},'{item.OperatorId}','{item.OperatorName}','{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
		/// /// <param name = "auditLogID">GUID</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string auditLogID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(auditLogID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string auditLogID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(auditLogID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string auditLogID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `AuditLogID` = @AuditLogID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AuditLogID", auditLogID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Sc_cash_audit_logEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.AuditLogID, tm_);
		}
		public async Task<int> RemoveAsync(Sc_cash_audit_logEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.AuditLogID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByCashAuditID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "cashAuditID">主键guid</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCashAuditID(string cashAuditID, TransactionManager tm_ = null)
		{
			RepairRemoveByCashAuditIDData(cashAuditID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCashAuditIDAsync(string cashAuditID, TransactionManager tm_ = null)
		{
			RepairRemoveByCashAuditIDData(cashAuditID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCashAuditIDData(string cashAuditID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (cashAuditID != null ? "`CashAuditID` = @CashAuditID" : "`CashAuditID` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (cashAuditID != null)
				paras_.Add(Database.CreateInParameter("@CashAuditID", cashAuditID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByCashAuditID
		#region RemoveByAction
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "action">操作0-提交申请1-审批通过2-审批拒绝</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByAction(int action, TransactionManager tm_ = null)
		{
			RepairRemoveByActionData(action, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByActionAsync(int action, TransactionManager tm_ = null)
		{
			RepairRemoveByActionData(action, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByActionData(int action, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Action` = @Action";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Action", action, MySqlDbType.Int32));
		}
		#endregion // RemoveByAction
		#region RemoveByOperatorId
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "operatorId">操作人ID</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByOperatorId(string operatorId, TransactionManager tm_ = null)
		{
			RepairRemoveByOperatorIdData(operatorId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByOperatorIdAsync(string operatorId, TransactionManager tm_ = null)
		{
			RepairRemoveByOperatorIdData(operatorId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByOperatorIdData(string operatorId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `OperatorId` = @OperatorId";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorId", operatorId, MySqlDbType.VarChar));
		}
		#endregion // RemoveByOperatorId
		#region RemoveByOperatorName
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "operatorName">操作人</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByOperatorName(string operatorName, TransactionManager tm_ = null)
		{
			RepairRemoveByOperatorNameData(operatorName, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByOperatorNameAsync(string operatorName, TransactionManager tm_ = null)
		{
			RepairRemoveByOperatorNameData(operatorName, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByOperatorNameData(string operatorName, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `OperatorName` = @OperatorName";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorName", operatorName, MySqlDbType.VarChar));
		}
		#endregion // RemoveByOperatorName
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
		public int Put(Sc_cash_audit_logEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Sc_cash_audit_logEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Sc_cash_audit_logEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `AuditLogID` = @AuditLogID, `CashAuditID` = @CashAuditID, `Action` = @Action, `OperatorId` = @OperatorId, `OperatorName` = @OperatorName WHERE `AuditLogID` = @AuditLogID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AuditLogID", item.AuditLogID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CashAuditID", item.CashAuditID != null ? item.CashAuditID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Action", item.Action, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorId", item.OperatorId, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorName", item.OperatorName, MySqlDbType.VarChar),
				Database.CreateInParameter("@AuditLogID_Original", item.HasOriginal ? item.OriginalAuditLogID : item.AuditLogID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Sc_cash_audit_logEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Sc_cash_audit_logEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "auditLogID">GUID</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string auditLogID, string set_, params object[] values_)
		{
			return Put(set_, "`AuditLogID` = @AuditLogID", ConcatValues(values_, auditLogID));
		}
		public async Task<int> PutByPKAsync(string auditLogID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`AuditLogID` = @AuditLogID", ConcatValues(values_, auditLogID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "auditLogID">GUID</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string auditLogID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`AuditLogID` = @AuditLogID", tm_, ConcatValues(values_, auditLogID));
		}
		public async Task<int> PutByPKAsync(string auditLogID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`AuditLogID` = @AuditLogID", tm_, ConcatValues(values_, auditLogID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "auditLogID">GUID</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string auditLogID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@AuditLogID", auditLogID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`AuditLogID` = @AuditLogID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string auditLogID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@AuditLogID", auditLogID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`AuditLogID` = @AuditLogID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutCashAuditID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "auditLogID">GUID</param>
		/// /// <param name = "cashAuditID">主键guid</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCashAuditIDByPK(string auditLogID, string cashAuditID, TransactionManager tm_ = null)
		{
			RepairPutCashAuditIDByPKData(auditLogID, cashAuditID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCashAuditIDByPKAsync(string auditLogID, string cashAuditID, TransactionManager tm_ = null)
		{
			RepairPutCashAuditIDByPKData(auditLogID, cashAuditID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCashAuditIDByPKData(string auditLogID, string cashAuditID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CashAuditID` = @CashAuditID  WHERE `AuditLogID` = @AuditLogID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CashAuditID", cashAuditID != null ? cashAuditID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@AuditLogID", auditLogID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "cashAuditID">主键guid</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCashAuditID(string cashAuditID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CashAuditID` = @CashAuditID";
			var parameter_ = Database.CreateInParameter("@CashAuditID", cashAuditID != null ? cashAuditID : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCashAuditIDAsync(string cashAuditID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CashAuditID` = @CashAuditID";
			var parameter_ = Database.CreateInParameter("@CashAuditID", cashAuditID != null ? cashAuditID : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCashAuditID
		#region PutAction
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "auditLogID">GUID</param>
		/// /// <param name = "action">操作0-提交申请1-审批通过2-审批拒绝</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutActionByPK(string auditLogID, int action, TransactionManager tm_ = null)
		{
			RepairPutActionByPKData(auditLogID, action, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutActionByPKAsync(string auditLogID, int action, TransactionManager tm_ = null)
		{
			RepairPutActionByPKData(auditLogID, action, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutActionByPKData(string auditLogID, int action, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Action` = @Action  WHERE `AuditLogID` = @AuditLogID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Action", action, MySqlDbType.Int32),
				Database.CreateInParameter("@AuditLogID", auditLogID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "action">操作0-提交申请1-审批通过2-审批拒绝</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAction(int action, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Action` = @Action";
			var parameter_ = Database.CreateInParameter("@Action", action, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutActionAsync(int action, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Action` = @Action";
			var parameter_ = Database.CreateInParameter("@Action", action, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutAction
		#region PutOperatorId
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "auditLogID">GUID</param>
		/// /// <param name = "operatorId">操作人ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorIdByPK(string auditLogID, string operatorId, TransactionManager tm_ = null)
		{
			RepairPutOperatorIdByPKData(auditLogID, operatorId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOperatorIdByPKAsync(string auditLogID, string operatorId, TransactionManager tm_ = null)
		{
			RepairPutOperatorIdByPKData(auditLogID, operatorId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOperatorIdByPKData(string auditLogID, string operatorId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorId` = @OperatorId  WHERE `AuditLogID` = @AuditLogID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorId", operatorId, MySqlDbType.VarChar),
				Database.CreateInParameter("@AuditLogID", auditLogID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "operatorId">操作人ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorId(string operatorId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OperatorId` = @OperatorId";
			var parameter_ = Database.CreateInParameter("@OperatorId", operatorId, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutOperatorIdAsync(string operatorId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OperatorId` = @OperatorId";
			var parameter_ = Database.CreateInParameter("@OperatorId", operatorId, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutOperatorId
		#region PutOperatorName
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "auditLogID">GUID</param>
		/// /// <param name = "operatorName">操作人</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorNameByPK(string auditLogID, string operatorName, TransactionManager tm_ = null)
		{
			RepairPutOperatorNameByPKData(auditLogID, operatorName, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOperatorNameByPKAsync(string auditLogID, string operatorName, TransactionManager tm_ = null)
		{
			RepairPutOperatorNameByPKData(auditLogID, operatorName, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOperatorNameByPKData(string auditLogID, string operatorName, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorName` = @OperatorName  WHERE `AuditLogID` = @AuditLogID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorName", operatorName, MySqlDbType.VarChar),
				Database.CreateInParameter("@AuditLogID", auditLogID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "operatorName">操作人</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorName(string operatorName, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OperatorName` = @OperatorName";
			var parameter_ = Database.CreateInParameter("@OperatorName", operatorName, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutOperatorNameAsync(string operatorName, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OperatorName` = @OperatorName";
			var parameter_ = Database.CreateInParameter("@OperatorName", operatorName, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutOperatorName
		#region PutRecDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "auditLogID">GUID</param>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(string auditLogID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(auditLogID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(string auditLogID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(auditLogID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(string auditLogID, DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `AuditLogID` = @AuditLogID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@AuditLogID", auditLogID, MySqlDbType.VarChar),
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
		public bool Set(Sc_cash_audit_logEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.AuditLogID) == null)
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
		public async Task<bool> SetAsync(Sc_cash_audit_logEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.AuditLogID) == null)
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
		/// /// <param name = "auditLogID">GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Sc_cash_audit_logEO GetByPK(string auditLogID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(auditLogID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sc_cash_audit_logEO.MapDataReader);
		}
		public async Task<Sc_cash_audit_logEO> GetByPKAsync(string auditLogID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(auditLogID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sc_cash_audit_logEO.MapDataReader);
		}
		private void RepairGetByPKData(string auditLogID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`AuditLogID` = @AuditLogID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AuditLogID", auditLogID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 CashAuditID（字段）
		/// </summary>
		/// /// <param name = "auditLogID">GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCashAuditIDByPK(string auditLogID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AuditLogID", auditLogID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CashAuditID`", "`AuditLogID` = @AuditLogID", paras_, tm_);
		}
		public async Task<string> GetCashAuditIDByPKAsync(string auditLogID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AuditLogID", auditLogID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CashAuditID`", "`AuditLogID` = @AuditLogID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Action（字段）
		/// </summary>
		/// /// <param name = "auditLogID">GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetActionByPK(string auditLogID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AuditLogID", auditLogID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`Action`", "`AuditLogID` = @AuditLogID", paras_, tm_);
		}
		public async Task<int> GetActionByPKAsync(string auditLogID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AuditLogID", auditLogID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`Action`", "`AuditLogID` = @AuditLogID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OperatorId（字段）
		/// </summary>
		/// /// <param name = "auditLogID">GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorIdByPK(string auditLogID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AuditLogID", auditLogID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OperatorId`", "`AuditLogID` = @AuditLogID", paras_, tm_);
		}
		public async Task<string> GetOperatorIdByPKAsync(string auditLogID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AuditLogID", auditLogID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OperatorId`", "`AuditLogID` = @AuditLogID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OperatorName（字段）
		/// </summary>
		/// /// <param name = "auditLogID">GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorNameByPK(string auditLogID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AuditLogID", auditLogID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OperatorName`", "`AuditLogID` = @AuditLogID", paras_, tm_);
		}
		public async Task<string> GetOperatorNameByPKAsync(string auditLogID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AuditLogID", auditLogID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OperatorName`", "`AuditLogID` = @AuditLogID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "auditLogID">GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetRecDateByPK(string auditLogID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AuditLogID", auditLogID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`RecDate`", "`AuditLogID` = @AuditLogID", paras_, tm_);
		}
		public async Task<DateTime> GetRecDateByPKAsync(string auditLogID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AuditLogID", auditLogID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`RecDate`", "`AuditLogID` = @AuditLogID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByCashAuditID
		
		/// <summary>
		/// 按 CashAuditID（字段） 查询
		/// </summary>
		/// /// <param name = "cashAuditID">主键guid</param>
		/// <return>实体对象集合</return>
		public List<Sc_cash_audit_logEO> GetByCashAuditID(string cashAuditID)
		{
			return GetByCashAuditID(cashAuditID, 0, string.Empty, null);
		}
		public async Task<List<Sc_cash_audit_logEO>> GetByCashAuditIDAsync(string cashAuditID)
		{
			return await GetByCashAuditIDAsync(cashAuditID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CashAuditID（字段） 查询
		/// </summary>
		/// /// <param name = "cashAuditID">主键guid</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_cash_audit_logEO> GetByCashAuditID(string cashAuditID, TransactionManager tm_)
		{
			return GetByCashAuditID(cashAuditID, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_cash_audit_logEO>> GetByCashAuditIDAsync(string cashAuditID, TransactionManager tm_)
		{
			return await GetByCashAuditIDAsync(cashAuditID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CashAuditID（字段） 查询
		/// </summary>
		/// /// <param name = "cashAuditID">主键guid</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_cash_audit_logEO> GetByCashAuditID(string cashAuditID, int top_)
		{
			return GetByCashAuditID(cashAuditID, top_, string.Empty, null);
		}
		public async Task<List<Sc_cash_audit_logEO>> GetByCashAuditIDAsync(string cashAuditID, int top_)
		{
			return await GetByCashAuditIDAsync(cashAuditID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CashAuditID（字段） 查询
		/// </summary>
		/// /// <param name = "cashAuditID">主键guid</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_cash_audit_logEO> GetByCashAuditID(string cashAuditID, int top_, TransactionManager tm_)
		{
			return GetByCashAuditID(cashAuditID, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_cash_audit_logEO>> GetByCashAuditIDAsync(string cashAuditID, int top_, TransactionManager tm_)
		{
			return await GetByCashAuditIDAsync(cashAuditID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CashAuditID（字段） 查询
		/// </summary>
		/// /// <param name = "cashAuditID">主键guid</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_cash_audit_logEO> GetByCashAuditID(string cashAuditID, string sort_)
		{
			return GetByCashAuditID(cashAuditID, 0, sort_, null);
		}
		public async Task<List<Sc_cash_audit_logEO>> GetByCashAuditIDAsync(string cashAuditID, string sort_)
		{
			return await GetByCashAuditIDAsync(cashAuditID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CashAuditID（字段） 查询
		/// </summary>
		/// /// <param name = "cashAuditID">主键guid</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_cash_audit_logEO> GetByCashAuditID(string cashAuditID, string sort_, TransactionManager tm_)
		{
			return GetByCashAuditID(cashAuditID, 0, sort_, tm_);
		}
		public async Task<List<Sc_cash_audit_logEO>> GetByCashAuditIDAsync(string cashAuditID, string sort_, TransactionManager tm_)
		{
			return await GetByCashAuditIDAsync(cashAuditID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CashAuditID（字段） 查询
		/// </summary>
		/// /// <param name = "cashAuditID">主键guid</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_cash_audit_logEO> GetByCashAuditID(string cashAuditID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(cashAuditID != null ? "`CashAuditID` = @CashAuditID" : "`CashAuditID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (cashAuditID != null)
				paras_.Add(Database.CreateInParameter("@CashAuditID", cashAuditID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_cash_audit_logEO.MapDataReader);
		}
		public async Task<List<Sc_cash_audit_logEO>> GetByCashAuditIDAsync(string cashAuditID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(cashAuditID != null ? "`CashAuditID` = @CashAuditID" : "`CashAuditID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (cashAuditID != null)
				paras_.Add(Database.CreateInParameter("@CashAuditID", cashAuditID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_cash_audit_logEO.MapDataReader);
		}
		#endregion // GetByCashAuditID
		#region GetByAction
		
		/// <summary>
		/// 按 Action（字段） 查询
		/// </summary>
		/// /// <param name = "action">操作0-提交申请1-审批通过2-审批拒绝</param>
		/// <return>实体对象集合</return>
		public List<Sc_cash_audit_logEO> GetByAction(int action)
		{
			return GetByAction(action, 0, string.Empty, null);
		}
		public async Task<List<Sc_cash_audit_logEO>> GetByActionAsync(int action)
		{
			return await GetByActionAsync(action, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Action（字段） 查询
		/// </summary>
		/// /// <param name = "action">操作0-提交申请1-审批通过2-审批拒绝</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_cash_audit_logEO> GetByAction(int action, TransactionManager tm_)
		{
			return GetByAction(action, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_cash_audit_logEO>> GetByActionAsync(int action, TransactionManager tm_)
		{
			return await GetByActionAsync(action, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Action（字段） 查询
		/// </summary>
		/// /// <param name = "action">操作0-提交申请1-审批通过2-审批拒绝</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_cash_audit_logEO> GetByAction(int action, int top_)
		{
			return GetByAction(action, top_, string.Empty, null);
		}
		public async Task<List<Sc_cash_audit_logEO>> GetByActionAsync(int action, int top_)
		{
			return await GetByActionAsync(action, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Action（字段） 查询
		/// </summary>
		/// /// <param name = "action">操作0-提交申请1-审批通过2-审批拒绝</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_cash_audit_logEO> GetByAction(int action, int top_, TransactionManager tm_)
		{
			return GetByAction(action, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_cash_audit_logEO>> GetByActionAsync(int action, int top_, TransactionManager tm_)
		{
			return await GetByActionAsync(action, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Action（字段） 查询
		/// </summary>
		/// /// <param name = "action">操作0-提交申请1-审批通过2-审批拒绝</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_cash_audit_logEO> GetByAction(int action, string sort_)
		{
			return GetByAction(action, 0, sort_, null);
		}
		public async Task<List<Sc_cash_audit_logEO>> GetByActionAsync(int action, string sort_)
		{
			return await GetByActionAsync(action, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Action（字段） 查询
		/// </summary>
		/// /// <param name = "action">操作0-提交申请1-审批通过2-审批拒绝</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_cash_audit_logEO> GetByAction(int action, string sort_, TransactionManager tm_)
		{
			return GetByAction(action, 0, sort_, tm_);
		}
		public async Task<List<Sc_cash_audit_logEO>> GetByActionAsync(int action, string sort_, TransactionManager tm_)
		{
			return await GetByActionAsync(action, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Action（字段） 查询
		/// </summary>
		/// /// <param name = "action">操作0-提交申请1-审批通过2-审批拒绝</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_cash_audit_logEO> GetByAction(int action, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Action` = @Action", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Action", action, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_cash_audit_logEO.MapDataReader);
		}
		public async Task<List<Sc_cash_audit_logEO>> GetByActionAsync(int action, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Action` = @Action", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Action", action, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_cash_audit_logEO.MapDataReader);
		}
		#endregion // GetByAction
		#region GetByOperatorId
		
		/// <summary>
		/// 按 OperatorId（字段） 查询
		/// </summary>
		/// /// <param name = "operatorId">操作人ID</param>
		/// <return>实体对象集合</return>
		public List<Sc_cash_audit_logEO> GetByOperatorId(string operatorId)
		{
			return GetByOperatorId(operatorId, 0, string.Empty, null);
		}
		public async Task<List<Sc_cash_audit_logEO>> GetByOperatorIdAsync(string operatorId)
		{
			return await GetByOperatorIdAsync(operatorId, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorId（字段） 查询
		/// </summary>
		/// /// <param name = "operatorId">操作人ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_cash_audit_logEO> GetByOperatorId(string operatorId, TransactionManager tm_)
		{
			return GetByOperatorId(operatorId, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_cash_audit_logEO>> GetByOperatorIdAsync(string operatorId, TransactionManager tm_)
		{
			return await GetByOperatorIdAsync(operatorId, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorId（字段） 查询
		/// </summary>
		/// /// <param name = "operatorId">操作人ID</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_cash_audit_logEO> GetByOperatorId(string operatorId, int top_)
		{
			return GetByOperatorId(operatorId, top_, string.Empty, null);
		}
		public async Task<List<Sc_cash_audit_logEO>> GetByOperatorIdAsync(string operatorId, int top_)
		{
			return await GetByOperatorIdAsync(operatorId, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorId（字段） 查询
		/// </summary>
		/// /// <param name = "operatorId">操作人ID</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_cash_audit_logEO> GetByOperatorId(string operatorId, int top_, TransactionManager tm_)
		{
			return GetByOperatorId(operatorId, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_cash_audit_logEO>> GetByOperatorIdAsync(string operatorId, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIdAsync(operatorId, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorId（字段） 查询
		/// </summary>
		/// /// <param name = "operatorId">操作人ID</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_cash_audit_logEO> GetByOperatorId(string operatorId, string sort_)
		{
			return GetByOperatorId(operatorId, 0, sort_, null);
		}
		public async Task<List<Sc_cash_audit_logEO>> GetByOperatorIdAsync(string operatorId, string sort_)
		{
			return await GetByOperatorIdAsync(operatorId, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OperatorId（字段） 查询
		/// </summary>
		/// /// <param name = "operatorId">操作人ID</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_cash_audit_logEO> GetByOperatorId(string operatorId, string sort_, TransactionManager tm_)
		{
			return GetByOperatorId(operatorId, 0, sort_, tm_);
		}
		public async Task<List<Sc_cash_audit_logEO>> GetByOperatorIdAsync(string operatorId, string sort_, TransactionManager tm_)
		{
			return await GetByOperatorIdAsync(operatorId, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OperatorId（字段） 查询
		/// </summary>
		/// /// <param name = "operatorId">操作人ID</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_cash_audit_logEO> GetByOperatorId(string operatorId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorId` = @OperatorId", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorId", operatorId, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_cash_audit_logEO.MapDataReader);
		}
		public async Task<List<Sc_cash_audit_logEO>> GetByOperatorIdAsync(string operatorId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorId` = @OperatorId", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorId", operatorId, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_cash_audit_logEO.MapDataReader);
		}
		#endregion // GetByOperatorId
		#region GetByOperatorName
		
		/// <summary>
		/// 按 OperatorName（字段） 查询
		/// </summary>
		/// /// <param name = "operatorName">操作人</param>
		/// <return>实体对象集合</return>
		public List<Sc_cash_audit_logEO> GetByOperatorName(string operatorName)
		{
			return GetByOperatorName(operatorName, 0, string.Empty, null);
		}
		public async Task<List<Sc_cash_audit_logEO>> GetByOperatorNameAsync(string operatorName)
		{
			return await GetByOperatorNameAsync(operatorName, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorName（字段） 查询
		/// </summary>
		/// /// <param name = "operatorName">操作人</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_cash_audit_logEO> GetByOperatorName(string operatorName, TransactionManager tm_)
		{
			return GetByOperatorName(operatorName, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_cash_audit_logEO>> GetByOperatorNameAsync(string operatorName, TransactionManager tm_)
		{
			return await GetByOperatorNameAsync(operatorName, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorName（字段） 查询
		/// </summary>
		/// /// <param name = "operatorName">操作人</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_cash_audit_logEO> GetByOperatorName(string operatorName, int top_)
		{
			return GetByOperatorName(operatorName, top_, string.Empty, null);
		}
		public async Task<List<Sc_cash_audit_logEO>> GetByOperatorNameAsync(string operatorName, int top_)
		{
			return await GetByOperatorNameAsync(operatorName, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorName（字段） 查询
		/// </summary>
		/// /// <param name = "operatorName">操作人</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_cash_audit_logEO> GetByOperatorName(string operatorName, int top_, TransactionManager tm_)
		{
			return GetByOperatorName(operatorName, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_cash_audit_logEO>> GetByOperatorNameAsync(string operatorName, int top_, TransactionManager tm_)
		{
			return await GetByOperatorNameAsync(operatorName, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorName（字段） 查询
		/// </summary>
		/// /// <param name = "operatorName">操作人</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_cash_audit_logEO> GetByOperatorName(string operatorName, string sort_)
		{
			return GetByOperatorName(operatorName, 0, sort_, null);
		}
		public async Task<List<Sc_cash_audit_logEO>> GetByOperatorNameAsync(string operatorName, string sort_)
		{
			return await GetByOperatorNameAsync(operatorName, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OperatorName（字段） 查询
		/// </summary>
		/// /// <param name = "operatorName">操作人</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_cash_audit_logEO> GetByOperatorName(string operatorName, string sort_, TransactionManager tm_)
		{
			return GetByOperatorName(operatorName, 0, sort_, tm_);
		}
		public async Task<List<Sc_cash_audit_logEO>> GetByOperatorNameAsync(string operatorName, string sort_, TransactionManager tm_)
		{
			return await GetByOperatorNameAsync(operatorName, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OperatorName（字段） 查询
		/// </summary>
		/// /// <param name = "operatorName">操作人</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_cash_audit_logEO> GetByOperatorName(string operatorName, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorName` = @OperatorName", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorName", operatorName, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_cash_audit_logEO.MapDataReader);
		}
		public async Task<List<Sc_cash_audit_logEO>> GetByOperatorNameAsync(string operatorName, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorName` = @OperatorName", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorName", operatorName, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_cash_audit_logEO.MapDataReader);
		}
		#endregion // GetByOperatorName
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <return>实体对象集合</return>
		public List<Sc_cash_audit_logEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<Sc_cash_audit_logEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_cash_audit_logEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_cash_audit_logEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_cash_audit_logEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<Sc_cash_audit_logEO>> GetByRecDateAsync(DateTime recDate, int top_)
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
		public List<Sc_cash_audit_logEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_cash_audit_logEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_cash_audit_logEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<Sc_cash_audit_logEO>> GetByRecDateAsync(DateTime recDate, string sort_)
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
		public List<Sc_cash_audit_logEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<Sc_cash_audit_logEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
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
		public List<Sc_cash_audit_logEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_cash_audit_logEO.MapDataReader);
		}
		public async Task<List<Sc_cash_audit_logEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_cash_audit_logEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
