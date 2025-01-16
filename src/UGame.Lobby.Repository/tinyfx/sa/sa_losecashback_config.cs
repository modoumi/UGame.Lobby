/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * AiUo代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/AiUo
 * 文档生成时间：2023-10-24 18: 05:01
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
	/// 输返活动配置表
	/// 【表 sa_losecashback_config 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Sa_losecashback_configEO : IRowMapper<Sa_losecashback_configEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Sa_losecashback_configEO()
		{
			this.FlowMultip = 0.00f;
			this.RefundMax = 0;
			this.RecDate = DateTime.Now;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private long _originalID;
		/// <summary>
		/// 【数据库中的原始主键 ID 值的副本，用于主键值更新】
		/// </summary>
		public long OriginalID
		{
			get { return _originalID; }
			set { HasOriginal = true; _originalID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "ID", ID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 主键
		/// 【主键 bigint】
		/// </summary>
		[DataMember(Order = 1)]
		public long ID { get; set; }
		/// <summary>
		/// 运营商编码
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 2)]
		public string OperatorID { get; set; }
		/// <summary>
		/// 国家编码ISO 3166-1三位字母
		/// 【字段 varchar(5)】
		/// </summary>
		[DataMember(Order = 3)]
		public string CountryId { get; set; }
		/// <summary>
		/// 货币类型
		/// 【字段 varchar(20)】
		/// </summary>
		[DataMember(Order = 4)]
		public string CurrencyID { get; set; }
		/// <summary>
		/// 亏损货币下限
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 5)]
		public long RangeMin { get; set; }
		/// <summary>
		/// 亏损货币上限
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 6)]
		public long RangeMax { get; set; }
		/// <summary>
		/// 输返的倍数
		/// 【字段 float(10,2)】
		/// </summary>
		[DataMember(Order = 7)]
		public float RefundMultiple { get; set; }
		/// <summary>
		/// 赠金提现所需要的流水倍数
		/// 【字段 float(10,2)】
		/// </summary>
		[DataMember(Order = 8)]
		public float FlowMultip { get; set; }
		/// <summary>
		/// 最大返还金额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 9)]
		public long RefundMax { get; set; }
		/// <summary>
		/// 记录创建时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 10)]
		public DateTime RecDate { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Sa_losecashback_configEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Sa_losecashback_configEO MapDataReader(IDataReader reader)
		{
		    Sa_losecashback_configEO ret = new Sa_losecashback_configEO();
			ret.ID = reader.ToInt64("ID");
			ret.OriginalID = ret.ID;
			ret.OperatorID = reader.ToString("OperatorID");
			ret.CountryId = reader.ToString("CountryId");
			ret.CurrencyID = reader.ToString("CurrencyID");
			ret.RangeMin = reader.ToInt64("RangeMin");
			ret.RangeMax = reader.ToInt64("RangeMax");
			ret.RefundMultiple = reader.ToSingle("RefundMultiple");
			ret.FlowMultip = reader.ToSingle("FlowMultip");
			ret.RefundMax = reader.ToInt64("RefundMax");
			ret.RecDate = reader.ToDateTime("RecDate");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 输返活动配置表
	/// 【表 sa_losecashback_config 的操作类】
	/// </summary>
	[Obsolete]
	public class Sa_losecashback_configMO : MySqlTableMO<Sa_losecashback_configEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`sa_losecashback_config`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Sa_losecashback_configMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Sa_losecashback_configMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Sa_losecashback_configMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Sa_losecashback_configEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			item.ID = Database.ExecSqlScalar<long>(sql_, paras_, tm_); 
			return 1;
		}
		public override async Task<int> AddAsync(Sa_losecashback_configEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			item.ID = await Database.ExecSqlScalarAsync<long>(sql_, paras_, tm_); 
	        return 1;
		}
	    private void RepairAddData(Sa_losecashback_configEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`OperatorID`, `CountryId`, `CurrencyID`, `RangeMin`, `RangeMax`, `RefundMultiple`, `FlowMultip`, `RefundMax`, `RecDate`) VALUE (@OperatorID, @CountryId, @CurrencyID, @RangeMin, @RangeMax, @RefundMultiple, @FlowMultip, @RefundMax, @RecDate);SELECT LAST_INSERT_ID();";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryId", item.CountryId != null ? item.CountryId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID != null ? item.CurrencyID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@RangeMin", item.RangeMin, MySqlDbType.Int64),
				Database.CreateInParameter("@RangeMax", item.RangeMax, MySqlDbType.Int64),
				Database.CreateInParameter("@RefundMultiple", item.RefundMultiple, MySqlDbType.Float),
				Database.CreateInParameter("@FlowMultip", item.FlowMultip, MySqlDbType.Float),
				Database.CreateInParameter("@RefundMax", item.RefundMax, MySqlDbType.Int64),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
			};
		}
		public int AddByBatch(IEnumerable<Sa_losecashback_configEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Sa_losecashback_configEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sa_losecashback_configEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`ID`, `OperatorID`, `CountryId`, `CurrencyID`, `RangeMin`, `RangeMax`, `RefundMultiple`, `FlowMultip`, `RefundMax`, `RecDate`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"({item.ID},'{item.OperatorID}','{item.CountryId}','{item.CurrencyID}',{item.RangeMin},{item.RangeMax},{item.RefundMultiple},{item.FlowMultip},{item.RefundMax},'{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
		/// /// <param name = "iD">主键</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(long iD, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(iD, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(long iD, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(iD, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(long iD, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `ID` = @ID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ID", iD, MySqlDbType.Int64),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Sa_losecashback_configEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.ID, tm_);
		}
		public async Task<int> RemoveAsync(Sa_losecashback_configEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.ID, tm_);
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
		#region RemoveByCountryId
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCountryId(string countryId, TransactionManager tm_ = null)
		{
			RepairRemoveByCountryIdData(countryId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCountryIdAsync(string countryId, TransactionManager tm_ = null)
		{
			RepairRemoveByCountryIdData(countryId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCountryIdData(string countryId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (countryId != null ? "`CountryId` = @CountryId" : "`CountryId` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (countryId != null)
				paras_.Add(Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar));
		}
		#endregion // RemoveByCountryId
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
		#region RemoveByRangeMin
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "rangeMin">亏损货币下限</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByRangeMin(long rangeMin, TransactionManager tm_ = null)
		{
			RepairRemoveByRangeMinData(rangeMin, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByRangeMinAsync(long rangeMin, TransactionManager tm_ = null)
		{
			RepairRemoveByRangeMinData(rangeMin, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByRangeMinData(long rangeMin, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `RangeMin` = @RangeMin";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RangeMin", rangeMin, MySqlDbType.Int64));
		}
		#endregion // RemoveByRangeMin
		#region RemoveByRangeMax
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "rangeMax">亏损货币上限</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByRangeMax(long rangeMax, TransactionManager tm_ = null)
		{
			RepairRemoveByRangeMaxData(rangeMax, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByRangeMaxAsync(long rangeMax, TransactionManager tm_ = null)
		{
			RepairRemoveByRangeMaxData(rangeMax, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByRangeMaxData(long rangeMax, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `RangeMax` = @RangeMax";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RangeMax", rangeMax, MySqlDbType.Int64));
		}
		#endregion // RemoveByRangeMax
		#region RemoveByRefundMultiple
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "refundMultiple">输返的倍数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByRefundMultiple(float refundMultiple, TransactionManager tm_ = null)
		{
			RepairRemoveByRefundMultipleData(refundMultiple, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByRefundMultipleAsync(float refundMultiple, TransactionManager tm_ = null)
		{
			RepairRemoveByRefundMultipleData(refundMultiple, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByRefundMultipleData(float refundMultiple, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `RefundMultiple` = @RefundMultiple";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RefundMultiple", refundMultiple, MySqlDbType.Float));
		}
		#endregion // RemoveByRefundMultiple
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
		#region RemoveByRefundMax
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "refundMax">最大返还金额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByRefundMax(long refundMax, TransactionManager tm_ = null)
		{
			RepairRemoveByRefundMaxData(refundMax, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByRefundMaxAsync(long refundMax, TransactionManager tm_ = null)
		{
			RepairRemoveByRefundMaxData(refundMax, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByRefundMaxData(long refundMax, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `RefundMax` = @RefundMax";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RefundMax", refundMax, MySqlDbType.Int64));
		}
		#endregion // RemoveByRefundMax
		#region RemoveByRecDate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "recDate">记录创建时间</param>
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
		public int Put(Sa_losecashback_configEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Sa_losecashback_configEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Sa_losecashback_configEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID, `CountryId` = @CountryId, `CurrencyID` = @CurrencyID, `RangeMin` = @RangeMin, `RangeMax` = @RangeMax, `RefundMultiple` = @RefundMultiple, `FlowMultip` = @FlowMultip, `RefundMax` = @RefundMax WHERE `ID` = @ID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryId", item.CountryId != null ? item.CountryId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID != null ? item.CurrencyID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@RangeMin", item.RangeMin, MySqlDbType.Int64),
				Database.CreateInParameter("@RangeMax", item.RangeMax, MySqlDbType.Int64),
				Database.CreateInParameter("@RefundMultiple", item.RefundMultiple, MySqlDbType.Float),
				Database.CreateInParameter("@FlowMultip", item.FlowMultip, MySqlDbType.Float),
				Database.CreateInParameter("@RefundMax", item.RefundMax, MySqlDbType.Int64),
				Database.CreateInParameter("@ID_Original", item.HasOriginal ? item.OriginalID : item.ID, MySqlDbType.Int64),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Sa_losecashback_configEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Sa_losecashback_configEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "iD">主键</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(long iD, string set_, params object[] values_)
		{
			return Put(set_, "`ID` = @ID", ConcatValues(values_, iD));
		}
		public async Task<int> PutByPKAsync(long iD, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`ID` = @ID", ConcatValues(values_, iD));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "iD">主键</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(long iD, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`ID` = @ID", tm_, ConcatValues(values_, iD));
		}
		public async Task<int> PutByPKAsync(long iD, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`ID` = @ID", tm_, ConcatValues(values_, iD));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "iD">主键</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(long iD, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@ID", iD, MySqlDbType.Int64),
	        };
			return Put(set_, "`ID` = @ID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(long iD, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@ID", iD, MySqlDbType.Int64),
	        };
			return await PutAsync(set_, "`ID` = @ID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutOperatorID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "iD">主键</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorIDByPK(long iD, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(iD, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOperatorIDByPKAsync(long iD, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(iD, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOperatorIDByPKData(long iD, string operatorID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID  WHERE `ID` = @ID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ID", iD, MySqlDbType.Int64),
			};
		}
	 
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
		#region PutCountryId
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "iD">主键</param>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCountryIdByPK(long iD, string countryId, TransactionManager tm_ = null)
		{
			RepairPutCountryIdByPKData(iD, countryId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCountryIdByPKAsync(long iD, string countryId, TransactionManager tm_ = null)
		{
			RepairPutCountryIdByPKData(iD, countryId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCountryIdByPKData(long iD, string countryId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CountryId` = @CountryId  WHERE `ID` = @ID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryId", countryId != null ? countryId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ID", iD, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCountryId(string countryId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CountryId` = @CountryId";
			var parameter_ = Database.CreateInParameter("@CountryId", countryId != null ? countryId : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCountryIdAsync(string countryId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CountryId` = @CountryId";
			var parameter_ = Database.CreateInParameter("@CountryId", countryId != null ? countryId : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCountryId
		#region PutCurrencyID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "iD">主键</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCurrencyIDByPK(long iD, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(iD, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCurrencyIDByPKAsync(long iD, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(iD, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCurrencyIDByPKData(long iD, string currencyID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CurrencyID` = @CurrencyID  WHERE `ID` = @ID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CurrencyID", currencyID != null ? currencyID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ID", iD, MySqlDbType.Int64),
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
		#region PutRangeMin
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "iD">主键</param>
		/// /// <param name = "rangeMin">亏损货币下限</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRangeMinByPK(long iD, long rangeMin, TransactionManager tm_ = null)
		{
			RepairPutRangeMinByPKData(iD, rangeMin, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRangeMinByPKAsync(long iD, long rangeMin, TransactionManager tm_ = null)
		{
			RepairPutRangeMinByPKData(iD, rangeMin, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRangeMinByPKData(long iD, long rangeMin, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RangeMin` = @RangeMin  WHERE `ID` = @ID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RangeMin", rangeMin, MySqlDbType.Int64),
				Database.CreateInParameter("@ID", iD, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "rangeMin">亏损货币下限</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRangeMin(long rangeMin, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RangeMin` = @RangeMin";
			var parameter_ = Database.CreateInParameter("@RangeMin", rangeMin, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutRangeMinAsync(long rangeMin, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RangeMin` = @RangeMin";
			var parameter_ = Database.CreateInParameter("@RangeMin", rangeMin, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutRangeMin
		#region PutRangeMax
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "iD">主键</param>
		/// /// <param name = "rangeMax">亏损货币上限</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRangeMaxByPK(long iD, long rangeMax, TransactionManager tm_ = null)
		{
			RepairPutRangeMaxByPKData(iD, rangeMax, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRangeMaxByPKAsync(long iD, long rangeMax, TransactionManager tm_ = null)
		{
			RepairPutRangeMaxByPKData(iD, rangeMax, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRangeMaxByPKData(long iD, long rangeMax, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RangeMax` = @RangeMax  WHERE `ID` = @ID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RangeMax", rangeMax, MySqlDbType.Int64),
				Database.CreateInParameter("@ID", iD, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "rangeMax">亏损货币上限</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRangeMax(long rangeMax, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RangeMax` = @RangeMax";
			var parameter_ = Database.CreateInParameter("@RangeMax", rangeMax, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutRangeMaxAsync(long rangeMax, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RangeMax` = @RangeMax";
			var parameter_ = Database.CreateInParameter("@RangeMax", rangeMax, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutRangeMax
		#region PutRefundMultiple
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "iD">主键</param>
		/// /// <param name = "refundMultiple">输返的倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRefundMultipleByPK(long iD, float refundMultiple, TransactionManager tm_ = null)
		{
			RepairPutRefundMultipleByPKData(iD, refundMultiple, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRefundMultipleByPKAsync(long iD, float refundMultiple, TransactionManager tm_ = null)
		{
			RepairPutRefundMultipleByPKData(iD, refundMultiple, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRefundMultipleByPKData(long iD, float refundMultiple, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RefundMultiple` = @RefundMultiple  WHERE `ID` = @ID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RefundMultiple", refundMultiple, MySqlDbType.Float),
				Database.CreateInParameter("@ID", iD, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "refundMultiple">输返的倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRefundMultiple(float refundMultiple, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RefundMultiple` = @RefundMultiple";
			var parameter_ = Database.CreateInParameter("@RefundMultiple", refundMultiple, MySqlDbType.Float);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutRefundMultipleAsync(float refundMultiple, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RefundMultiple` = @RefundMultiple";
			var parameter_ = Database.CreateInParameter("@RefundMultiple", refundMultiple, MySqlDbType.Float);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutRefundMultiple
		#region PutFlowMultip
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "iD">主键</param>
		/// /// <param name = "flowMultip">赠金提现所需要的流水倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFlowMultipByPK(long iD, float flowMultip, TransactionManager tm_ = null)
		{
			RepairPutFlowMultipByPKData(iD, flowMultip, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFlowMultipByPKAsync(long iD, float flowMultip, TransactionManager tm_ = null)
		{
			RepairPutFlowMultipByPKData(iD, flowMultip, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFlowMultipByPKData(long iD, float flowMultip, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `FlowMultip` = @FlowMultip  WHERE `ID` = @ID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@FlowMultip", flowMultip, MySqlDbType.Float),
				Database.CreateInParameter("@ID", iD, MySqlDbType.Int64),
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
		#region PutRefundMax
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "iD">主键</param>
		/// /// <param name = "refundMax">最大返还金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRefundMaxByPK(long iD, long refundMax, TransactionManager tm_ = null)
		{
			RepairPutRefundMaxByPKData(iD, refundMax, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRefundMaxByPKAsync(long iD, long refundMax, TransactionManager tm_ = null)
		{
			RepairPutRefundMaxByPKData(iD, refundMax, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRefundMaxByPKData(long iD, long refundMax, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RefundMax` = @RefundMax  WHERE `ID` = @ID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RefundMax", refundMax, MySqlDbType.Int64),
				Database.CreateInParameter("@ID", iD, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "refundMax">最大返还金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRefundMax(long refundMax, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RefundMax` = @RefundMax";
			var parameter_ = Database.CreateInParameter("@RefundMax", refundMax, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutRefundMaxAsync(long refundMax, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RefundMax` = @RefundMax";
			var parameter_ = Database.CreateInParameter("@RefundMax", refundMax, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutRefundMax
		#region PutRecDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "iD">主键</param>
		/// /// <param name = "recDate">记录创建时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(long iD, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(iD, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(long iD, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(iD, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(long iD, DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `ID` = @ID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@ID", iD, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "recDate">记录创建时间</param>
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
		public bool Set(Sa_losecashback_configEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.ID) == null)
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
		public async Task<bool> SetAsync(Sa_losecashback_configEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.ID) == null)
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
		/// /// <param name = "iD">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Sa_losecashback_configEO GetByPK(long iD, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(iD, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sa_losecashback_configEO.MapDataReader);
		}
		public async Task<Sa_losecashback_configEO> GetByPKAsync(long iD, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(iD, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sa_losecashback_configEO.MapDataReader);
		}
		private void RepairGetByPKData(long iD, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`ID` = @ID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ID", iD, MySqlDbType.Int64),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 OperatorID（字段）
		/// </summary>
		/// /// <param name = "iD">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorIDByPK(long iD, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ID", iD, MySqlDbType.Int64),
			};
			return (string)GetScalar("`OperatorID`", "`ID` = @ID", paras_, tm_);
		}
		public async Task<string> GetOperatorIDByPKAsync(long iD, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ID", iD, MySqlDbType.Int64),
			};
			return (string)await GetScalarAsync("`OperatorID`", "`ID` = @ID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CountryId（字段）
		/// </summary>
		/// /// <param name = "iD">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCountryIdByPK(long iD, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ID", iD, MySqlDbType.Int64),
			};
			return (string)GetScalar("`CountryId`", "`ID` = @ID", paras_, tm_);
		}
		public async Task<string> GetCountryIdByPKAsync(long iD, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ID", iD, MySqlDbType.Int64),
			};
			return (string)await GetScalarAsync("`CountryId`", "`ID` = @ID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CurrencyID（字段）
		/// </summary>
		/// /// <param name = "iD">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCurrencyIDByPK(long iD, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ID", iD, MySqlDbType.Int64),
			};
			return (string)GetScalar("`CurrencyID`", "`ID` = @ID", paras_, tm_);
		}
		public async Task<string> GetCurrencyIDByPKAsync(long iD, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ID", iD, MySqlDbType.Int64),
			};
			return (string)await GetScalarAsync("`CurrencyID`", "`ID` = @ID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RangeMin（字段）
		/// </summary>
		/// /// <param name = "iD">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetRangeMinByPK(long iD, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ID", iD, MySqlDbType.Int64),
			};
			return (long)GetScalar("`RangeMin`", "`ID` = @ID", paras_, tm_);
		}
		public async Task<long> GetRangeMinByPKAsync(long iD, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ID", iD, MySqlDbType.Int64),
			};
			return (long)await GetScalarAsync("`RangeMin`", "`ID` = @ID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RangeMax（字段）
		/// </summary>
		/// /// <param name = "iD">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetRangeMaxByPK(long iD, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ID", iD, MySqlDbType.Int64),
			};
			return (long)GetScalar("`RangeMax`", "`ID` = @ID", paras_, tm_);
		}
		public async Task<long> GetRangeMaxByPKAsync(long iD, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ID", iD, MySqlDbType.Int64),
			};
			return (long)await GetScalarAsync("`RangeMax`", "`ID` = @ID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RefundMultiple（字段）
		/// </summary>
		/// /// <param name = "iD">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public float GetRefundMultipleByPK(long iD, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ID", iD, MySqlDbType.Int64),
			};
			return (float)GetScalar("`RefundMultiple`", "`ID` = @ID", paras_, tm_);
		}
		public async Task<float> GetRefundMultipleByPKAsync(long iD, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ID", iD, MySqlDbType.Int64),
			};
			return (float)await GetScalarAsync("`RefundMultiple`", "`ID` = @ID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 FlowMultip（字段）
		/// </summary>
		/// /// <param name = "iD">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public float GetFlowMultipByPK(long iD, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ID", iD, MySqlDbType.Int64),
			};
			return (float)GetScalar("`FlowMultip`", "`ID` = @ID", paras_, tm_);
		}
		public async Task<float> GetFlowMultipByPKAsync(long iD, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ID", iD, MySqlDbType.Int64),
			};
			return (float)await GetScalarAsync("`FlowMultip`", "`ID` = @ID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RefundMax（字段）
		/// </summary>
		/// /// <param name = "iD">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetRefundMaxByPK(long iD, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ID", iD, MySqlDbType.Int64),
			};
			return (long)GetScalar("`RefundMax`", "`ID` = @ID", paras_, tm_);
		}
		public async Task<long> GetRefundMaxByPKAsync(long iD, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ID", iD, MySqlDbType.Int64),
			};
			return (long)await GetScalarAsync("`RefundMax`", "`ID` = @ID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "iD">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetRecDateByPK(long iD, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ID", iD, MySqlDbType.Int64),
			};
			return (DateTime)GetScalar("`RecDate`", "`ID` = @ID", paras_, tm_);
		}
		public async Task<DateTime> GetRecDateByPKAsync(long iD, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ID", iD, MySqlDbType.Int64),
			};
			return (DateTime)await GetScalarAsync("`RecDate`", "`ID` = @ID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_configEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<Sa_losecashback_configEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_configEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_losecashback_configEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_configEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<Sa_losecashback_configEO>> GetByOperatorIDAsync(string operatorID, int top_)
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
		public List<Sa_losecashback_configEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_losecashback_configEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_configEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<Sa_losecashback_configEO>> GetByOperatorIDAsync(string operatorID, string sort_)
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
		public List<Sa_losecashback_configEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<Sa_losecashback_configEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
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
		public List<Sa_losecashback_configEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_losecashback_configEO.MapDataReader);
		}
		public async Task<List<Sa_losecashback_configEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_losecashback_configEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByCountryId
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_configEO> GetByCountryId(string countryId)
		{
			return GetByCountryId(countryId, 0, string.Empty, null);
		}
		public async Task<List<Sa_losecashback_configEO>> GetByCountryIdAsync(string countryId)
		{
			return await GetByCountryIdAsync(countryId, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_configEO> GetByCountryId(string countryId, TransactionManager tm_)
		{
			return GetByCountryId(countryId, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_losecashback_configEO>> GetByCountryIdAsync(string countryId, TransactionManager tm_)
		{
			return await GetByCountryIdAsync(countryId, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_configEO> GetByCountryId(string countryId, int top_)
		{
			return GetByCountryId(countryId, top_, string.Empty, null);
		}
		public async Task<List<Sa_losecashback_configEO>> GetByCountryIdAsync(string countryId, int top_)
		{
			return await GetByCountryIdAsync(countryId, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_configEO> GetByCountryId(string countryId, int top_, TransactionManager tm_)
		{
			return GetByCountryId(countryId, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_losecashback_configEO>> GetByCountryIdAsync(string countryId, int top_, TransactionManager tm_)
		{
			return await GetByCountryIdAsync(countryId, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_configEO> GetByCountryId(string countryId, string sort_)
		{
			return GetByCountryId(countryId, 0, sort_, null);
		}
		public async Task<List<Sa_losecashback_configEO>> GetByCountryIdAsync(string countryId, string sort_)
		{
			return await GetByCountryIdAsync(countryId, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_configEO> GetByCountryId(string countryId, string sort_, TransactionManager tm_)
		{
			return GetByCountryId(countryId, 0, sort_, tm_);
		}
		public async Task<List<Sa_losecashback_configEO>> GetByCountryIdAsync(string countryId, string sort_, TransactionManager tm_)
		{
			return await GetByCountryIdAsync(countryId, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_configEO> GetByCountryId(string countryId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(countryId != null ? "`CountryId` = @CountryId" : "`CountryId` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (countryId != null)
				paras_.Add(Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_losecashback_configEO.MapDataReader);
		}
		public async Task<List<Sa_losecashback_configEO>> GetByCountryIdAsync(string countryId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(countryId != null ? "`CountryId` = @CountryId" : "`CountryId` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (countryId != null)
				paras_.Add(Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_losecashback_configEO.MapDataReader);
		}
		#endregion // GetByCountryId
		#region GetByCurrencyID
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_configEO> GetByCurrencyID(string currencyID)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, null);
		}
		public async Task<List<Sa_losecashback_configEO>> GetByCurrencyIDAsync(string currencyID)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_configEO> GetByCurrencyID(string currencyID, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_losecashback_configEO>> GetByCurrencyIDAsync(string currencyID, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_configEO> GetByCurrencyID(string currencyID, int top_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, null);
		}
		public async Task<List<Sa_losecashback_configEO>> GetByCurrencyIDAsync(string currencyID, int top_)
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
		public List<Sa_losecashback_configEO> GetByCurrencyID(string currencyID, int top_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_losecashback_configEO>> GetByCurrencyIDAsync(string currencyID, int top_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_configEO> GetByCurrencyID(string currencyID, string sort_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, null);
		}
		public async Task<List<Sa_losecashback_configEO>> GetByCurrencyIDAsync(string currencyID, string sort_)
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
		public List<Sa_losecashback_configEO> GetByCurrencyID(string currencyID, string sort_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, tm_);
		}
		public async Task<List<Sa_losecashback_configEO>> GetByCurrencyIDAsync(string currencyID, string sort_, TransactionManager tm_)
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
		public List<Sa_losecashback_configEO> GetByCurrencyID(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(currencyID != null ? "`CurrencyID` = @CurrencyID" : "`CurrencyID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (currencyID != null)
				paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_losecashback_configEO.MapDataReader);
		}
		public async Task<List<Sa_losecashback_configEO>> GetByCurrencyIDAsync(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(currencyID != null ? "`CurrencyID` = @CurrencyID" : "`CurrencyID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (currencyID != null)
				paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_losecashback_configEO.MapDataReader);
		}
		#endregion // GetByCurrencyID
		#region GetByRangeMin
		
		/// <summary>
		/// 按 RangeMin（字段） 查询
		/// </summary>
		/// /// <param name = "rangeMin">亏损货币下限</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_configEO> GetByRangeMin(long rangeMin)
		{
			return GetByRangeMin(rangeMin, 0, string.Empty, null);
		}
		public async Task<List<Sa_losecashback_configEO>> GetByRangeMinAsync(long rangeMin)
		{
			return await GetByRangeMinAsync(rangeMin, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RangeMin（字段） 查询
		/// </summary>
		/// /// <param name = "rangeMin">亏损货币下限</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_configEO> GetByRangeMin(long rangeMin, TransactionManager tm_)
		{
			return GetByRangeMin(rangeMin, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_losecashback_configEO>> GetByRangeMinAsync(long rangeMin, TransactionManager tm_)
		{
			return await GetByRangeMinAsync(rangeMin, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RangeMin（字段） 查询
		/// </summary>
		/// /// <param name = "rangeMin">亏损货币下限</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_configEO> GetByRangeMin(long rangeMin, int top_)
		{
			return GetByRangeMin(rangeMin, top_, string.Empty, null);
		}
		public async Task<List<Sa_losecashback_configEO>> GetByRangeMinAsync(long rangeMin, int top_)
		{
			return await GetByRangeMinAsync(rangeMin, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RangeMin（字段） 查询
		/// </summary>
		/// /// <param name = "rangeMin">亏损货币下限</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_configEO> GetByRangeMin(long rangeMin, int top_, TransactionManager tm_)
		{
			return GetByRangeMin(rangeMin, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_losecashback_configEO>> GetByRangeMinAsync(long rangeMin, int top_, TransactionManager tm_)
		{
			return await GetByRangeMinAsync(rangeMin, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RangeMin（字段） 查询
		/// </summary>
		/// /// <param name = "rangeMin">亏损货币下限</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_configEO> GetByRangeMin(long rangeMin, string sort_)
		{
			return GetByRangeMin(rangeMin, 0, sort_, null);
		}
		public async Task<List<Sa_losecashback_configEO>> GetByRangeMinAsync(long rangeMin, string sort_)
		{
			return await GetByRangeMinAsync(rangeMin, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RangeMin（字段） 查询
		/// </summary>
		/// /// <param name = "rangeMin">亏损货币下限</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_configEO> GetByRangeMin(long rangeMin, string sort_, TransactionManager tm_)
		{
			return GetByRangeMin(rangeMin, 0, sort_, tm_);
		}
		public async Task<List<Sa_losecashback_configEO>> GetByRangeMinAsync(long rangeMin, string sort_, TransactionManager tm_)
		{
			return await GetByRangeMinAsync(rangeMin, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RangeMin（字段） 查询
		/// </summary>
		/// /// <param name = "rangeMin">亏损货币下限</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_configEO> GetByRangeMin(long rangeMin, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RangeMin` = @RangeMin", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RangeMin", rangeMin, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_losecashback_configEO.MapDataReader);
		}
		public async Task<List<Sa_losecashback_configEO>> GetByRangeMinAsync(long rangeMin, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RangeMin` = @RangeMin", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RangeMin", rangeMin, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_losecashback_configEO.MapDataReader);
		}
		#endregion // GetByRangeMin
		#region GetByRangeMax
		
		/// <summary>
		/// 按 RangeMax（字段） 查询
		/// </summary>
		/// /// <param name = "rangeMax">亏损货币上限</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_configEO> GetByRangeMax(long rangeMax)
		{
			return GetByRangeMax(rangeMax, 0, string.Empty, null);
		}
		public async Task<List<Sa_losecashback_configEO>> GetByRangeMaxAsync(long rangeMax)
		{
			return await GetByRangeMaxAsync(rangeMax, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RangeMax（字段） 查询
		/// </summary>
		/// /// <param name = "rangeMax">亏损货币上限</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_configEO> GetByRangeMax(long rangeMax, TransactionManager tm_)
		{
			return GetByRangeMax(rangeMax, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_losecashback_configEO>> GetByRangeMaxAsync(long rangeMax, TransactionManager tm_)
		{
			return await GetByRangeMaxAsync(rangeMax, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RangeMax（字段） 查询
		/// </summary>
		/// /// <param name = "rangeMax">亏损货币上限</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_configEO> GetByRangeMax(long rangeMax, int top_)
		{
			return GetByRangeMax(rangeMax, top_, string.Empty, null);
		}
		public async Task<List<Sa_losecashback_configEO>> GetByRangeMaxAsync(long rangeMax, int top_)
		{
			return await GetByRangeMaxAsync(rangeMax, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RangeMax（字段） 查询
		/// </summary>
		/// /// <param name = "rangeMax">亏损货币上限</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_configEO> GetByRangeMax(long rangeMax, int top_, TransactionManager tm_)
		{
			return GetByRangeMax(rangeMax, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_losecashback_configEO>> GetByRangeMaxAsync(long rangeMax, int top_, TransactionManager tm_)
		{
			return await GetByRangeMaxAsync(rangeMax, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RangeMax（字段） 查询
		/// </summary>
		/// /// <param name = "rangeMax">亏损货币上限</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_configEO> GetByRangeMax(long rangeMax, string sort_)
		{
			return GetByRangeMax(rangeMax, 0, sort_, null);
		}
		public async Task<List<Sa_losecashback_configEO>> GetByRangeMaxAsync(long rangeMax, string sort_)
		{
			return await GetByRangeMaxAsync(rangeMax, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RangeMax（字段） 查询
		/// </summary>
		/// /// <param name = "rangeMax">亏损货币上限</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_configEO> GetByRangeMax(long rangeMax, string sort_, TransactionManager tm_)
		{
			return GetByRangeMax(rangeMax, 0, sort_, tm_);
		}
		public async Task<List<Sa_losecashback_configEO>> GetByRangeMaxAsync(long rangeMax, string sort_, TransactionManager tm_)
		{
			return await GetByRangeMaxAsync(rangeMax, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RangeMax（字段） 查询
		/// </summary>
		/// /// <param name = "rangeMax">亏损货币上限</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_configEO> GetByRangeMax(long rangeMax, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RangeMax` = @RangeMax", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RangeMax", rangeMax, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_losecashback_configEO.MapDataReader);
		}
		public async Task<List<Sa_losecashback_configEO>> GetByRangeMaxAsync(long rangeMax, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RangeMax` = @RangeMax", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RangeMax", rangeMax, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_losecashback_configEO.MapDataReader);
		}
		#endregion // GetByRangeMax
		#region GetByRefundMultiple
		
		/// <summary>
		/// 按 RefundMultiple（字段） 查询
		/// </summary>
		/// /// <param name = "refundMultiple">输返的倍数</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_configEO> GetByRefundMultiple(float refundMultiple)
		{
			return GetByRefundMultiple(refundMultiple, 0, string.Empty, null);
		}
		public async Task<List<Sa_losecashback_configEO>> GetByRefundMultipleAsync(float refundMultiple)
		{
			return await GetByRefundMultipleAsync(refundMultiple, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RefundMultiple（字段） 查询
		/// </summary>
		/// /// <param name = "refundMultiple">输返的倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_configEO> GetByRefundMultiple(float refundMultiple, TransactionManager tm_)
		{
			return GetByRefundMultiple(refundMultiple, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_losecashback_configEO>> GetByRefundMultipleAsync(float refundMultiple, TransactionManager tm_)
		{
			return await GetByRefundMultipleAsync(refundMultiple, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RefundMultiple（字段） 查询
		/// </summary>
		/// /// <param name = "refundMultiple">输返的倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_configEO> GetByRefundMultiple(float refundMultiple, int top_)
		{
			return GetByRefundMultiple(refundMultiple, top_, string.Empty, null);
		}
		public async Task<List<Sa_losecashback_configEO>> GetByRefundMultipleAsync(float refundMultiple, int top_)
		{
			return await GetByRefundMultipleAsync(refundMultiple, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RefundMultiple（字段） 查询
		/// </summary>
		/// /// <param name = "refundMultiple">输返的倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_configEO> GetByRefundMultiple(float refundMultiple, int top_, TransactionManager tm_)
		{
			return GetByRefundMultiple(refundMultiple, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_losecashback_configEO>> GetByRefundMultipleAsync(float refundMultiple, int top_, TransactionManager tm_)
		{
			return await GetByRefundMultipleAsync(refundMultiple, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RefundMultiple（字段） 查询
		/// </summary>
		/// /// <param name = "refundMultiple">输返的倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_configEO> GetByRefundMultiple(float refundMultiple, string sort_)
		{
			return GetByRefundMultiple(refundMultiple, 0, sort_, null);
		}
		public async Task<List<Sa_losecashback_configEO>> GetByRefundMultipleAsync(float refundMultiple, string sort_)
		{
			return await GetByRefundMultipleAsync(refundMultiple, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RefundMultiple（字段） 查询
		/// </summary>
		/// /// <param name = "refundMultiple">输返的倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_configEO> GetByRefundMultiple(float refundMultiple, string sort_, TransactionManager tm_)
		{
			return GetByRefundMultiple(refundMultiple, 0, sort_, tm_);
		}
		public async Task<List<Sa_losecashback_configEO>> GetByRefundMultipleAsync(float refundMultiple, string sort_, TransactionManager tm_)
		{
			return await GetByRefundMultipleAsync(refundMultiple, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RefundMultiple（字段） 查询
		/// </summary>
		/// /// <param name = "refundMultiple">输返的倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_configEO> GetByRefundMultiple(float refundMultiple, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RefundMultiple` = @RefundMultiple", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RefundMultiple", refundMultiple, MySqlDbType.Float));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_losecashback_configEO.MapDataReader);
		}
		public async Task<List<Sa_losecashback_configEO>> GetByRefundMultipleAsync(float refundMultiple, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RefundMultiple` = @RefundMultiple", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RefundMultiple", refundMultiple, MySqlDbType.Float));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_losecashback_configEO.MapDataReader);
		}
		#endregion // GetByRefundMultiple
		#region GetByFlowMultip
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">赠金提现所需要的流水倍数</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_configEO> GetByFlowMultip(float flowMultip)
		{
			return GetByFlowMultip(flowMultip, 0, string.Empty, null);
		}
		public async Task<List<Sa_losecashback_configEO>> GetByFlowMultipAsync(float flowMultip)
		{
			return await GetByFlowMultipAsync(flowMultip, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">赠金提现所需要的流水倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_configEO> GetByFlowMultip(float flowMultip, TransactionManager tm_)
		{
			return GetByFlowMultip(flowMultip, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_losecashback_configEO>> GetByFlowMultipAsync(float flowMultip, TransactionManager tm_)
		{
			return await GetByFlowMultipAsync(flowMultip, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">赠金提现所需要的流水倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_configEO> GetByFlowMultip(float flowMultip, int top_)
		{
			return GetByFlowMultip(flowMultip, top_, string.Empty, null);
		}
		public async Task<List<Sa_losecashback_configEO>> GetByFlowMultipAsync(float flowMultip, int top_)
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
		public List<Sa_losecashback_configEO> GetByFlowMultip(float flowMultip, int top_, TransactionManager tm_)
		{
			return GetByFlowMultip(flowMultip, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_losecashback_configEO>> GetByFlowMultipAsync(float flowMultip, int top_, TransactionManager tm_)
		{
			return await GetByFlowMultipAsync(flowMultip, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">赠金提现所需要的流水倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_configEO> GetByFlowMultip(float flowMultip, string sort_)
		{
			return GetByFlowMultip(flowMultip, 0, sort_, null);
		}
		public async Task<List<Sa_losecashback_configEO>> GetByFlowMultipAsync(float flowMultip, string sort_)
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
		public List<Sa_losecashback_configEO> GetByFlowMultip(float flowMultip, string sort_, TransactionManager tm_)
		{
			return GetByFlowMultip(flowMultip, 0, sort_, tm_);
		}
		public async Task<List<Sa_losecashback_configEO>> GetByFlowMultipAsync(float flowMultip, string sort_, TransactionManager tm_)
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
		public List<Sa_losecashback_configEO> GetByFlowMultip(float flowMultip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FlowMultip` = @FlowMultip", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FlowMultip", flowMultip, MySqlDbType.Float));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_losecashback_configEO.MapDataReader);
		}
		public async Task<List<Sa_losecashback_configEO>> GetByFlowMultipAsync(float flowMultip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FlowMultip` = @FlowMultip", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FlowMultip", flowMultip, MySqlDbType.Float));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_losecashback_configEO.MapDataReader);
		}
		#endregion // GetByFlowMultip
		#region GetByRefundMax
		
		/// <summary>
		/// 按 RefundMax（字段） 查询
		/// </summary>
		/// /// <param name = "refundMax">最大返还金额</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_configEO> GetByRefundMax(long refundMax)
		{
			return GetByRefundMax(refundMax, 0, string.Empty, null);
		}
		public async Task<List<Sa_losecashback_configEO>> GetByRefundMaxAsync(long refundMax)
		{
			return await GetByRefundMaxAsync(refundMax, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RefundMax（字段） 查询
		/// </summary>
		/// /// <param name = "refundMax">最大返还金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_configEO> GetByRefundMax(long refundMax, TransactionManager tm_)
		{
			return GetByRefundMax(refundMax, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_losecashback_configEO>> GetByRefundMaxAsync(long refundMax, TransactionManager tm_)
		{
			return await GetByRefundMaxAsync(refundMax, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RefundMax（字段） 查询
		/// </summary>
		/// /// <param name = "refundMax">最大返还金额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_configEO> GetByRefundMax(long refundMax, int top_)
		{
			return GetByRefundMax(refundMax, top_, string.Empty, null);
		}
		public async Task<List<Sa_losecashback_configEO>> GetByRefundMaxAsync(long refundMax, int top_)
		{
			return await GetByRefundMaxAsync(refundMax, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RefundMax（字段） 查询
		/// </summary>
		/// /// <param name = "refundMax">最大返还金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_configEO> GetByRefundMax(long refundMax, int top_, TransactionManager tm_)
		{
			return GetByRefundMax(refundMax, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_losecashback_configEO>> GetByRefundMaxAsync(long refundMax, int top_, TransactionManager tm_)
		{
			return await GetByRefundMaxAsync(refundMax, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RefundMax（字段） 查询
		/// </summary>
		/// /// <param name = "refundMax">最大返还金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_configEO> GetByRefundMax(long refundMax, string sort_)
		{
			return GetByRefundMax(refundMax, 0, sort_, null);
		}
		public async Task<List<Sa_losecashback_configEO>> GetByRefundMaxAsync(long refundMax, string sort_)
		{
			return await GetByRefundMaxAsync(refundMax, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RefundMax（字段） 查询
		/// </summary>
		/// /// <param name = "refundMax">最大返还金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_configEO> GetByRefundMax(long refundMax, string sort_, TransactionManager tm_)
		{
			return GetByRefundMax(refundMax, 0, sort_, tm_);
		}
		public async Task<List<Sa_losecashback_configEO>> GetByRefundMaxAsync(long refundMax, string sort_, TransactionManager tm_)
		{
			return await GetByRefundMaxAsync(refundMax, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RefundMax（字段） 查询
		/// </summary>
		/// /// <param name = "refundMax">最大返还金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_configEO> GetByRefundMax(long refundMax, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RefundMax` = @RefundMax", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RefundMax", refundMax, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_losecashback_configEO.MapDataReader);
		}
		public async Task<List<Sa_losecashback_configEO>> GetByRefundMaxAsync(long refundMax, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RefundMax` = @RefundMax", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RefundMax", refundMax, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_losecashback_configEO.MapDataReader);
		}
		#endregion // GetByRefundMax
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录创建时间</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_configEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<Sa_losecashback_configEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录创建时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_configEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_losecashback_configEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录创建时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_configEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<Sa_losecashback_configEO>> GetByRecDateAsync(DateTime recDate, int top_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录创建时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_configEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_losecashback_configEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录创建时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_configEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<Sa_losecashback_configEO>> GetByRecDateAsync(DateTime recDate, string sort_)
		{
			return await GetByRecDateAsync(recDate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录创建时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_configEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<Sa_losecashback_configEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录创建时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_configEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_losecashback_configEO.MapDataReader);
		}
		public async Task<List<Sa_losecashback_configEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_losecashback_configEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
