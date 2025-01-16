/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * AiUo代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/AiUo
 * 文档生成时间：2023-10-24 18: 05:05
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
	/// 用户首充活动次序详情配置
	/// 【表 sa_firstpay_frequency_config 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Sa_firstpay_frequency_configEO : IRowMapper<Sa_firstpay_frequency_configEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Sa_firstpay_frequency_configEO()
		{
			this.SerialNumber = 1;
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
		
		private long _originalPayMin;
		/// <summary>
		/// 【数据库中的原始主键 PayMin 值的副本，用于主键值更新】
		/// </summary>
		public long OriginalPayMin
		{
			get { return _originalPayMin; }
			set { HasOriginal = true; _originalPayMin = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "OperatorID", OperatorID },  { "PayMin", PayMin }, };
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
		/// 国家编码ISO 3166-1三位字母
		/// 【字段 varchar(5)】
		/// </summary>
		[DataMember(Order = 2)]
		public string CountryId { get; set; }
		/// <summary>
		/// 货币类型
		/// 【字段 varchar(20)】
		/// </summary>
		[DataMember(Order = 3)]
		public string CurrencyID { get; set; }
		/// <summary>
		/// 充值序号(代表充值赠活动多次时的次数)
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 4)]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 充值金额下限
		/// 【主键 bigint】
		/// </summary>
		[DataMember(Order = 5)]
		public long PayMin { get; set; }
		/// <summary>
		/// 充值金额上限
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 6)]
		public long PayMax { get; set; }
		/// <summary>
		/// 充值赠金倍数
		/// 【字段 float(10,2)】
		/// </summary>
		[DataMember(Order = 7)]
		public float PayMultiple { get; set; }
		/// <summary>
		/// 记录创建时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 8)]
		public DateTime RecDate { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Sa_firstpay_frequency_configEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Sa_firstpay_frequency_configEO MapDataReader(IDataReader reader)
		{
		    Sa_firstpay_frequency_configEO ret = new Sa_firstpay_frequency_configEO();
			ret.OperatorID = reader.ToString("OperatorID");
			ret.OriginalOperatorID = ret.OperatorID;
			ret.CountryId = reader.ToString("CountryId");
			ret.CurrencyID = reader.ToString("CurrencyID");
			ret.SerialNumber = reader.ToInt32("SerialNumber");
			ret.PayMin = reader.ToInt64("PayMin");
			ret.OriginalPayMin = ret.PayMin;
			ret.PayMax = reader.ToInt64("PayMax");
			ret.PayMultiple = reader.ToSingle("PayMultiple");
			ret.RecDate = reader.ToDateTime("RecDate");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 用户首充活动次序详情配置
	/// 【表 sa_firstpay_frequency_config 的操作类】
	/// </summary>
	[Obsolete]
	public class Sa_firstpay_frequency_configMO : MySqlTableMO<Sa_firstpay_frequency_configEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`sa_firstpay_frequency_config`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Sa_firstpay_frequency_configMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Sa_firstpay_frequency_configMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Sa_firstpay_frequency_configMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Sa_firstpay_frequency_configEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Sa_firstpay_frequency_configEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Sa_firstpay_frequency_configEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`OperatorID`, `CountryId`, `CurrencyID`, `SerialNumber`, `PayMin`, `PayMax`, `PayMultiple`, `RecDate`) VALUE (@OperatorID, @CountryId, @CurrencyID, @SerialNumber, @PayMin, @PayMax, @PayMultiple, @RecDate);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryId", item.CountryId != null ? item.CountryId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@SerialNumber", item.SerialNumber, MySqlDbType.Int32),
				Database.CreateInParameter("@PayMin", item.PayMin, MySqlDbType.Int64),
				Database.CreateInParameter("@PayMax", item.PayMax, MySqlDbType.Int64),
				Database.CreateInParameter("@PayMultiple", item.PayMultiple, MySqlDbType.Float),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
			};
		}
		public int AddByBatch(IEnumerable<Sa_firstpay_frequency_configEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Sa_firstpay_frequency_configEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sa_firstpay_frequency_configEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`OperatorID`, `CountryId`, `CurrencyID`, `SerialNumber`, `PayMin`, `PayMax`, `PayMultiple`, `RecDate`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.OperatorID}','{item.CountryId}','{item.CurrencyID}',{item.SerialNumber},{item.PayMin},{item.PayMax},{item.PayMultiple},'{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
		/// /// <param name = "payMin">充值金额下限</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string operatorID, long payMin, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(operatorID, payMin, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string operatorID, long payMin, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(operatorID, payMin, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string operatorID, long payMin, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `OperatorID` = @OperatorID AND `PayMin` = @PayMin";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PayMin", payMin, MySqlDbType.Int64),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Sa_firstpay_frequency_configEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.OperatorID, item.PayMin, tm_);
		}
		public async Task<int> RemoveAsync(Sa_firstpay_frequency_configEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.OperatorID, item.PayMin, tm_);
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
			sql_ = $"DELETE FROM {TableName} WHERE `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByCurrencyID
		#region RemoveBySerialNumber
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "serialNumber">充值序号(代表充值赠活动多次时的次数)</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveBySerialNumber(int serialNumber, TransactionManager tm_ = null)
		{
			RepairRemoveBySerialNumberData(serialNumber, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveBySerialNumberAsync(int serialNumber, TransactionManager tm_ = null)
		{
			RepairRemoveBySerialNumberData(serialNumber, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveBySerialNumberData(int serialNumber, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `SerialNumber` = @SerialNumber";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SerialNumber", serialNumber, MySqlDbType.Int32));
		}
		#endregion // RemoveBySerialNumber
		#region RemoveByPayMin
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "payMin">充值金额下限</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPayMin(long payMin, TransactionManager tm_ = null)
		{
			RepairRemoveByPayMinData(payMin, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPayMinAsync(long payMin, TransactionManager tm_ = null)
		{
			RepairRemoveByPayMinData(payMin, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByPayMinData(long payMin, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `PayMin` = @PayMin";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PayMin", payMin, MySqlDbType.Int64));
		}
		#endregion // RemoveByPayMin
		#region RemoveByPayMax
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "payMax">充值金额上限</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPayMax(long payMax, TransactionManager tm_ = null)
		{
			RepairRemoveByPayMaxData(payMax, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPayMaxAsync(long payMax, TransactionManager tm_ = null)
		{
			RepairRemoveByPayMaxData(payMax, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByPayMaxData(long payMax, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `PayMax` = @PayMax";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PayMax", payMax, MySqlDbType.Int64));
		}
		#endregion // RemoveByPayMax
		#region RemoveByPayMultiple
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "payMultiple">充值赠金倍数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPayMultiple(float payMultiple, TransactionManager tm_ = null)
		{
			RepairRemoveByPayMultipleData(payMultiple, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPayMultipleAsync(float payMultiple, TransactionManager tm_ = null)
		{
			RepairRemoveByPayMultipleData(payMultiple, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByPayMultipleData(float payMultiple, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `PayMultiple` = @PayMultiple";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PayMultiple", payMultiple, MySqlDbType.Float));
		}
		#endregion // RemoveByPayMultiple
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
		public int Put(Sa_firstpay_frequency_configEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Sa_firstpay_frequency_configEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Sa_firstpay_frequency_configEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID, `CountryId` = @CountryId, `CurrencyID` = @CurrencyID, `SerialNumber` = @SerialNumber, `PayMin` = @PayMin, `PayMax` = @PayMax, `PayMultiple` = @PayMultiple WHERE `OperatorID` = @OperatorID_Original AND `PayMin` = @PayMin_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryId", item.CountryId != null ? item.CountryId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@SerialNumber", item.SerialNumber, MySqlDbType.Int32),
				Database.CreateInParameter("@PayMin", item.PayMin, MySqlDbType.Int64),
				Database.CreateInParameter("@PayMax", item.PayMax, MySqlDbType.Int64),
				Database.CreateInParameter("@PayMultiple", item.PayMultiple, MySqlDbType.Float),
				Database.CreateInParameter("@OperatorID_Original", item.HasOriginal ? item.OriginalOperatorID : item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PayMin_Original", item.HasOriginal ? item.OriginalPayMin : item.PayMin, MySqlDbType.Int64),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Sa_firstpay_frequency_configEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Sa_firstpay_frequency_configEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "payMin">充值金额下限</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string operatorID, long payMin, string set_, params object[] values_)
		{
			return Put(set_, "`OperatorID` = @OperatorID AND `PayMin` = @PayMin", ConcatValues(values_, operatorID, payMin));
		}
		public async Task<int> PutByPKAsync(string operatorID, long payMin, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`OperatorID` = @OperatorID AND `PayMin` = @PayMin", ConcatValues(values_, operatorID, payMin));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "payMin">充值金额下限</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string operatorID, long payMin, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`OperatorID` = @OperatorID AND `PayMin` = @PayMin", tm_, ConcatValues(values_, operatorID, payMin));
		}
		public async Task<int> PutByPKAsync(string operatorID, long payMin, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`OperatorID` = @OperatorID AND `PayMin` = @PayMin", tm_, ConcatValues(values_, operatorID, payMin));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "payMin">充值金额下限</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string operatorID, long payMin, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PayMin", payMin, MySqlDbType.Int64),
	        };
			return Put(set_, "`OperatorID` = @OperatorID AND `PayMin` = @PayMin", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string operatorID, long payMin, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PayMin", payMin, MySqlDbType.Int64),
	        };
			return await PutAsync(set_, "`OperatorID` = @OperatorID AND `PayMin` = @PayMin", ConcatParameters(paras_, newParas_), tm_);
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
		#region PutCountryId
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "payMin">充值金额下限</param>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCountryIdByPK(string operatorID, long payMin, string countryId, TransactionManager tm_ = null)
		{
			RepairPutCountryIdByPKData(operatorID, payMin, countryId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCountryIdByPKAsync(string operatorID, long payMin, string countryId, TransactionManager tm_ = null)
		{
			RepairPutCountryIdByPKData(operatorID, payMin, countryId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCountryIdByPKData(string operatorID, long payMin, string countryId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CountryId` = @CountryId  WHERE `OperatorID` = @OperatorID AND `PayMin` = @PayMin";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryId", countryId != null ? countryId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PayMin", payMin, MySqlDbType.Int64),
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
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "payMin">充值金额下限</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCurrencyIDByPK(string operatorID, long payMin, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(operatorID, payMin, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCurrencyIDByPKAsync(string operatorID, long payMin, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(operatorID, payMin, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCurrencyIDByPKData(string operatorID, long payMin, string currencyID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CurrencyID` = @CurrencyID  WHERE `OperatorID` = @OperatorID AND `PayMin` = @PayMin";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PayMin", payMin, MySqlDbType.Int64),
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
			var parameter_ = Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCurrencyIDAsync(string currencyID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CurrencyID` = @CurrencyID";
			var parameter_ = Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCurrencyID
		#region PutSerialNumber
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "payMin">充值金额下限</param>
		/// /// <param name = "serialNumber">充值序号(代表充值赠活动多次时的次数)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSerialNumberByPK(string operatorID, long payMin, int serialNumber, TransactionManager tm_ = null)
		{
			RepairPutSerialNumberByPKData(operatorID, payMin, serialNumber, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutSerialNumberByPKAsync(string operatorID, long payMin, int serialNumber, TransactionManager tm_ = null)
		{
			RepairPutSerialNumberByPKData(operatorID, payMin, serialNumber, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutSerialNumberByPKData(string operatorID, long payMin, int serialNumber, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `SerialNumber` = @SerialNumber  WHERE `OperatorID` = @OperatorID AND `PayMin` = @PayMin";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SerialNumber", serialNumber, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PayMin", payMin, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "serialNumber">充值序号(代表充值赠活动多次时的次数)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSerialNumber(int serialNumber, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SerialNumber` = @SerialNumber";
			var parameter_ = Database.CreateInParameter("@SerialNumber", serialNumber, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutSerialNumberAsync(int serialNumber, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SerialNumber` = @SerialNumber";
			var parameter_ = Database.CreateInParameter("@SerialNumber", serialNumber, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutSerialNumber
		#region PutPayMin
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "payMin">充值金额下限</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPayMin(long payMin, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PayMin` = @PayMin";
			var parameter_ = Database.CreateInParameter("@PayMin", payMin, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutPayMinAsync(long payMin, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PayMin` = @PayMin";
			var parameter_ = Database.CreateInParameter("@PayMin", payMin, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutPayMin
		#region PutPayMax
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "payMin">充值金额下限</param>
		/// /// <param name = "payMax">充值金额上限</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPayMaxByPK(string operatorID, long payMin, long payMax, TransactionManager tm_ = null)
		{
			RepairPutPayMaxByPKData(operatorID, payMin, payMax, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutPayMaxByPKAsync(string operatorID, long payMin, long payMax, TransactionManager tm_ = null)
		{
			RepairPutPayMaxByPKData(operatorID, payMin, payMax, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutPayMaxByPKData(string operatorID, long payMin, long payMax, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `PayMax` = @PayMax  WHERE `OperatorID` = @OperatorID AND `PayMin` = @PayMin";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PayMax", payMax, MySqlDbType.Int64),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PayMin", payMin, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "payMax">充值金额上限</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPayMax(long payMax, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PayMax` = @PayMax";
			var parameter_ = Database.CreateInParameter("@PayMax", payMax, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutPayMaxAsync(long payMax, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PayMax` = @PayMax";
			var parameter_ = Database.CreateInParameter("@PayMax", payMax, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutPayMax
		#region PutPayMultiple
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "payMin">充值金额下限</param>
		/// /// <param name = "payMultiple">充值赠金倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPayMultipleByPK(string operatorID, long payMin, float payMultiple, TransactionManager tm_ = null)
		{
			RepairPutPayMultipleByPKData(operatorID, payMin, payMultiple, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutPayMultipleByPKAsync(string operatorID, long payMin, float payMultiple, TransactionManager tm_ = null)
		{
			RepairPutPayMultipleByPKData(operatorID, payMin, payMultiple, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutPayMultipleByPKData(string operatorID, long payMin, float payMultiple, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `PayMultiple` = @PayMultiple  WHERE `OperatorID` = @OperatorID AND `PayMin` = @PayMin";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PayMultiple", payMultiple, MySqlDbType.Float),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PayMin", payMin, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "payMultiple">充值赠金倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPayMultiple(float payMultiple, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PayMultiple` = @PayMultiple";
			var parameter_ = Database.CreateInParameter("@PayMultiple", payMultiple, MySqlDbType.Float);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutPayMultipleAsync(float payMultiple, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PayMultiple` = @PayMultiple";
			var parameter_ = Database.CreateInParameter("@PayMultiple", payMultiple, MySqlDbType.Float);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutPayMultiple
		#region PutRecDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "payMin">充值金额下限</param>
		/// /// <param name = "recDate">记录创建时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(string operatorID, long payMin, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(operatorID, payMin, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(string operatorID, long payMin, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(operatorID, payMin, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(string operatorID, long payMin, DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `OperatorID` = @OperatorID AND `PayMin` = @PayMin";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PayMin", payMin, MySqlDbType.Int64),
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
		public bool Set(Sa_firstpay_frequency_configEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.OperatorID, item.PayMin) == null)
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
		public async Task<bool> SetAsync(Sa_firstpay_frequency_configEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.OperatorID, item.PayMin) == null)
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
		/// /// <param name = "payMin">充值金额下限</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Sa_firstpay_frequency_configEO GetByPK(string operatorID, long payMin, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(operatorID, payMin, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sa_firstpay_frequency_configEO.MapDataReader);
		}
		public async Task<Sa_firstpay_frequency_configEO> GetByPKAsync(string operatorID, long payMin, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(operatorID, payMin, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sa_firstpay_frequency_configEO.MapDataReader);
		}
		private void RepairGetByPKData(string operatorID, long payMin, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`OperatorID` = @OperatorID AND `PayMin` = @PayMin", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PayMin", payMin, MySqlDbType.Int64),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 OperatorID（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "payMin">充值金额下限</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorIDByPK(string operatorID, long payMin, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PayMin", payMin, MySqlDbType.Int64),
			};
			return (string)GetScalar("`OperatorID`", "`OperatorID` = @OperatorID AND `PayMin` = @PayMin", paras_, tm_);
		}
		public async Task<string> GetOperatorIDByPKAsync(string operatorID, long payMin, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PayMin", payMin, MySqlDbType.Int64),
			};
			return (string)await GetScalarAsync("`OperatorID`", "`OperatorID` = @OperatorID AND `PayMin` = @PayMin", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CountryId（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "payMin">充值金额下限</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCountryIdByPK(string operatorID, long payMin, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PayMin", payMin, MySqlDbType.Int64),
			};
			return (string)GetScalar("`CountryId`", "`OperatorID` = @OperatorID AND `PayMin` = @PayMin", paras_, tm_);
		}
		public async Task<string> GetCountryIdByPKAsync(string operatorID, long payMin, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PayMin", payMin, MySqlDbType.Int64),
			};
			return (string)await GetScalarAsync("`CountryId`", "`OperatorID` = @OperatorID AND `PayMin` = @PayMin", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CurrencyID（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "payMin">充值金额下限</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCurrencyIDByPK(string operatorID, long payMin, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PayMin", payMin, MySqlDbType.Int64),
			};
			return (string)GetScalar("`CurrencyID`", "`OperatorID` = @OperatorID AND `PayMin` = @PayMin", paras_, tm_);
		}
		public async Task<string> GetCurrencyIDByPKAsync(string operatorID, long payMin, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PayMin", payMin, MySqlDbType.Int64),
			};
			return (string)await GetScalarAsync("`CurrencyID`", "`OperatorID` = @OperatorID AND `PayMin` = @PayMin", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 SerialNumber（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "payMin">充值金额下限</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetSerialNumberByPK(string operatorID, long payMin, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PayMin", payMin, MySqlDbType.Int64),
			};
			return (int)GetScalar("`SerialNumber`", "`OperatorID` = @OperatorID AND `PayMin` = @PayMin", paras_, tm_);
		}
		public async Task<int> GetSerialNumberByPKAsync(string operatorID, long payMin, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PayMin", payMin, MySqlDbType.Int64),
			};
			return (int)await GetScalarAsync("`SerialNumber`", "`OperatorID` = @OperatorID AND `PayMin` = @PayMin", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 PayMin（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "payMin">充值金额下限</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetPayMinByPK(string operatorID, long payMin, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PayMin", payMin, MySqlDbType.Int64),
			};
			return (long)GetScalar("`PayMin`", "`OperatorID` = @OperatorID AND `PayMin` = @PayMin", paras_, tm_);
		}
		public async Task<long> GetPayMinByPKAsync(string operatorID, long payMin, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PayMin", payMin, MySqlDbType.Int64),
			};
			return (long)await GetScalarAsync("`PayMin`", "`OperatorID` = @OperatorID AND `PayMin` = @PayMin", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 PayMax（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "payMin">充值金额下限</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetPayMaxByPK(string operatorID, long payMin, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PayMin", payMin, MySqlDbType.Int64),
			};
			return (long)GetScalar("`PayMax`", "`OperatorID` = @OperatorID AND `PayMin` = @PayMin", paras_, tm_);
		}
		public async Task<long> GetPayMaxByPKAsync(string operatorID, long payMin, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PayMin", payMin, MySqlDbType.Int64),
			};
			return (long)await GetScalarAsync("`PayMax`", "`OperatorID` = @OperatorID AND `PayMin` = @PayMin", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 PayMultiple（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "payMin">充值金额下限</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public float GetPayMultipleByPK(string operatorID, long payMin, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PayMin", payMin, MySqlDbType.Int64),
			};
			return (float)GetScalar("`PayMultiple`", "`OperatorID` = @OperatorID AND `PayMin` = @PayMin", paras_, tm_);
		}
		public async Task<float> GetPayMultipleByPKAsync(string operatorID, long payMin, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PayMin", payMin, MySqlDbType.Int64),
			};
			return (float)await GetScalarAsync("`PayMultiple`", "`OperatorID` = @OperatorID AND `PayMin` = @PayMin", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "payMin">充值金额下限</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetRecDateByPK(string operatorID, long payMin, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PayMin", payMin, MySqlDbType.Int64),
			};
			return (DateTime)GetScalar("`RecDate`", "`OperatorID` = @OperatorID AND `PayMin` = @PayMin", paras_, tm_);
		}
		public async Task<DateTime> GetRecDateByPKAsync(string operatorID, long payMin, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PayMin", payMin, MySqlDbType.Int64),
			};
			return (DateTime)await GetScalarAsync("`RecDate`", "`OperatorID` = @OperatorID AND `PayMin` = @PayMin", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <return>实体对象集合</return>
		public List<Sa_firstpay_frequency_configEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<Sa_firstpay_frequency_configEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_firstpay_frequency_configEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_firstpay_frequency_configEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_firstpay_frequency_configEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<Sa_firstpay_frequency_configEO>> GetByOperatorIDAsync(string operatorID, int top_)
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
		public List<Sa_firstpay_frequency_configEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_firstpay_frequency_configEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_firstpay_frequency_configEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<Sa_firstpay_frequency_configEO>> GetByOperatorIDAsync(string operatorID, string sort_)
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
		public List<Sa_firstpay_frequency_configEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<Sa_firstpay_frequency_configEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
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
		public List<Sa_firstpay_frequency_configEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_firstpay_frequency_configEO.MapDataReader);
		}
		public async Task<List<Sa_firstpay_frequency_configEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_firstpay_frequency_configEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByCountryId
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <return>实体对象集合</return>
		public List<Sa_firstpay_frequency_configEO> GetByCountryId(string countryId)
		{
			return GetByCountryId(countryId, 0, string.Empty, null);
		}
		public async Task<List<Sa_firstpay_frequency_configEO>> GetByCountryIdAsync(string countryId)
		{
			return await GetByCountryIdAsync(countryId, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_firstpay_frequency_configEO> GetByCountryId(string countryId, TransactionManager tm_)
		{
			return GetByCountryId(countryId, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_firstpay_frequency_configEO>> GetByCountryIdAsync(string countryId, TransactionManager tm_)
		{
			return await GetByCountryIdAsync(countryId, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_firstpay_frequency_configEO> GetByCountryId(string countryId, int top_)
		{
			return GetByCountryId(countryId, top_, string.Empty, null);
		}
		public async Task<List<Sa_firstpay_frequency_configEO>> GetByCountryIdAsync(string countryId, int top_)
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
		public List<Sa_firstpay_frequency_configEO> GetByCountryId(string countryId, int top_, TransactionManager tm_)
		{
			return GetByCountryId(countryId, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_firstpay_frequency_configEO>> GetByCountryIdAsync(string countryId, int top_, TransactionManager tm_)
		{
			return await GetByCountryIdAsync(countryId, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_firstpay_frequency_configEO> GetByCountryId(string countryId, string sort_)
		{
			return GetByCountryId(countryId, 0, sort_, null);
		}
		public async Task<List<Sa_firstpay_frequency_configEO>> GetByCountryIdAsync(string countryId, string sort_)
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
		public List<Sa_firstpay_frequency_configEO> GetByCountryId(string countryId, string sort_, TransactionManager tm_)
		{
			return GetByCountryId(countryId, 0, sort_, tm_);
		}
		public async Task<List<Sa_firstpay_frequency_configEO>> GetByCountryIdAsync(string countryId, string sort_, TransactionManager tm_)
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
		public List<Sa_firstpay_frequency_configEO> GetByCountryId(string countryId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(countryId != null ? "`CountryId` = @CountryId" : "`CountryId` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (countryId != null)
				paras_.Add(Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_firstpay_frequency_configEO.MapDataReader);
		}
		public async Task<List<Sa_firstpay_frequency_configEO>> GetByCountryIdAsync(string countryId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(countryId != null ? "`CountryId` = @CountryId" : "`CountryId` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (countryId != null)
				paras_.Add(Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_firstpay_frequency_configEO.MapDataReader);
		}
		#endregion // GetByCountryId
		#region GetByCurrencyID
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <return>实体对象集合</return>
		public List<Sa_firstpay_frequency_configEO> GetByCurrencyID(string currencyID)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, null);
		}
		public async Task<List<Sa_firstpay_frequency_configEO>> GetByCurrencyIDAsync(string currencyID)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_firstpay_frequency_configEO> GetByCurrencyID(string currencyID, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_firstpay_frequency_configEO>> GetByCurrencyIDAsync(string currencyID, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_firstpay_frequency_configEO> GetByCurrencyID(string currencyID, int top_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, null);
		}
		public async Task<List<Sa_firstpay_frequency_configEO>> GetByCurrencyIDAsync(string currencyID, int top_)
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
		public List<Sa_firstpay_frequency_configEO> GetByCurrencyID(string currencyID, int top_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_firstpay_frequency_configEO>> GetByCurrencyIDAsync(string currencyID, int top_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_firstpay_frequency_configEO> GetByCurrencyID(string currencyID, string sort_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, null);
		}
		public async Task<List<Sa_firstpay_frequency_configEO>> GetByCurrencyIDAsync(string currencyID, string sort_)
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
		public List<Sa_firstpay_frequency_configEO> GetByCurrencyID(string currencyID, string sort_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, tm_);
		}
		public async Task<List<Sa_firstpay_frequency_configEO>> GetByCurrencyIDAsync(string currencyID, string sort_, TransactionManager tm_)
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
		public List<Sa_firstpay_frequency_configEO> GetByCurrencyID(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_firstpay_frequency_configEO.MapDataReader);
		}
		public async Task<List<Sa_firstpay_frequency_configEO>> GetByCurrencyIDAsync(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_firstpay_frequency_configEO.MapDataReader);
		}
		#endregion // GetByCurrencyID
		#region GetBySerialNumber
		
		/// <summary>
		/// 按 SerialNumber（字段） 查询
		/// </summary>
		/// /// <param name = "serialNumber">充值序号(代表充值赠活动多次时的次数)</param>
		/// <return>实体对象集合</return>
		public List<Sa_firstpay_frequency_configEO> GetBySerialNumber(int serialNumber)
		{
			return GetBySerialNumber(serialNumber, 0, string.Empty, null);
		}
		public async Task<List<Sa_firstpay_frequency_configEO>> GetBySerialNumberAsync(int serialNumber)
		{
			return await GetBySerialNumberAsync(serialNumber, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SerialNumber（字段） 查询
		/// </summary>
		/// /// <param name = "serialNumber">充值序号(代表充值赠活动多次时的次数)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_firstpay_frequency_configEO> GetBySerialNumber(int serialNumber, TransactionManager tm_)
		{
			return GetBySerialNumber(serialNumber, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_firstpay_frequency_configEO>> GetBySerialNumberAsync(int serialNumber, TransactionManager tm_)
		{
			return await GetBySerialNumberAsync(serialNumber, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SerialNumber（字段） 查询
		/// </summary>
		/// /// <param name = "serialNumber">充值序号(代表充值赠活动多次时的次数)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_firstpay_frequency_configEO> GetBySerialNumber(int serialNumber, int top_)
		{
			return GetBySerialNumber(serialNumber, top_, string.Empty, null);
		}
		public async Task<List<Sa_firstpay_frequency_configEO>> GetBySerialNumberAsync(int serialNumber, int top_)
		{
			return await GetBySerialNumberAsync(serialNumber, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SerialNumber（字段） 查询
		/// </summary>
		/// /// <param name = "serialNumber">充值序号(代表充值赠活动多次时的次数)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_firstpay_frequency_configEO> GetBySerialNumber(int serialNumber, int top_, TransactionManager tm_)
		{
			return GetBySerialNumber(serialNumber, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_firstpay_frequency_configEO>> GetBySerialNumberAsync(int serialNumber, int top_, TransactionManager tm_)
		{
			return await GetBySerialNumberAsync(serialNumber, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SerialNumber（字段） 查询
		/// </summary>
		/// /// <param name = "serialNumber">充值序号(代表充值赠活动多次时的次数)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_firstpay_frequency_configEO> GetBySerialNumber(int serialNumber, string sort_)
		{
			return GetBySerialNumber(serialNumber, 0, sort_, null);
		}
		public async Task<List<Sa_firstpay_frequency_configEO>> GetBySerialNumberAsync(int serialNumber, string sort_)
		{
			return await GetBySerialNumberAsync(serialNumber, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 SerialNumber（字段） 查询
		/// </summary>
		/// /// <param name = "serialNumber">充值序号(代表充值赠活动多次时的次数)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_firstpay_frequency_configEO> GetBySerialNumber(int serialNumber, string sort_, TransactionManager tm_)
		{
			return GetBySerialNumber(serialNumber, 0, sort_, tm_);
		}
		public async Task<List<Sa_firstpay_frequency_configEO>> GetBySerialNumberAsync(int serialNumber, string sort_, TransactionManager tm_)
		{
			return await GetBySerialNumberAsync(serialNumber, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 SerialNumber（字段） 查询
		/// </summary>
		/// /// <param name = "serialNumber">充值序号(代表充值赠活动多次时的次数)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_firstpay_frequency_configEO> GetBySerialNumber(int serialNumber, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SerialNumber` = @SerialNumber", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SerialNumber", serialNumber, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_firstpay_frequency_configEO.MapDataReader);
		}
		public async Task<List<Sa_firstpay_frequency_configEO>> GetBySerialNumberAsync(int serialNumber, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SerialNumber` = @SerialNumber", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SerialNumber", serialNumber, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_firstpay_frequency_configEO.MapDataReader);
		}
		#endregion // GetBySerialNumber
		#region GetByPayMin
		
		/// <summary>
		/// 按 PayMin（字段） 查询
		/// </summary>
		/// /// <param name = "payMin">充值金额下限</param>
		/// <return>实体对象集合</return>
		public List<Sa_firstpay_frequency_configEO> GetByPayMin(long payMin)
		{
			return GetByPayMin(payMin, 0, string.Empty, null);
		}
		public async Task<List<Sa_firstpay_frequency_configEO>> GetByPayMinAsync(long payMin)
		{
			return await GetByPayMinAsync(payMin, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayMin（字段） 查询
		/// </summary>
		/// /// <param name = "payMin">充值金额下限</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_firstpay_frequency_configEO> GetByPayMin(long payMin, TransactionManager tm_)
		{
			return GetByPayMin(payMin, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_firstpay_frequency_configEO>> GetByPayMinAsync(long payMin, TransactionManager tm_)
		{
			return await GetByPayMinAsync(payMin, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayMin（字段） 查询
		/// </summary>
		/// /// <param name = "payMin">充值金额下限</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_firstpay_frequency_configEO> GetByPayMin(long payMin, int top_)
		{
			return GetByPayMin(payMin, top_, string.Empty, null);
		}
		public async Task<List<Sa_firstpay_frequency_configEO>> GetByPayMinAsync(long payMin, int top_)
		{
			return await GetByPayMinAsync(payMin, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayMin（字段） 查询
		/// </summary>
		/// /// <param name = "payMin">充值金额下限</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_firstpay_frequency_configEO> GetByPayMin(long payMin, int top_, TransactionManager tm_)
		{
			return GetByPayMin(payMin, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_firstpay_frequency_configEO>> GetByPayMinAsync(long payMin, int top_, TransactionManager tm_)
		{
			return await GetByPayMinAsync(payMin, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayMin（字段） 查询
		/// </summary>
		/// /// <param name = "payMin">充值金额下限</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_firstpay_frequency_configEO> GetByPayMin(long payMin, string sort_)
		{
			return GetByPayMin(payMin, 0, sort_, null);
		}
		public async Task<List<Sa_firstpay_frequency_configEO>> GetByPayMinAsync(long payMin, string sort_)
		{
			return await GetByPayMinAsync(payMin, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PayMin（字段） 查询
		/// </summary>
		/// /// <param name = "payMin">充值金额下限</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_firstpay_frequency_configEO> GetByPayMin(long payMin, string sort_, TransactionManager tm_)
		{
			return GetByPayMin(payMin, 0, sort_, tm_);
		}
		public async Task<List<Sa_firstpay_frequency_configEO>> GetByPayMinAsync(long payMin, string sort_, TransactionManager tm_)
		{
			return await GetByPayMinAsync(payMin, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PayMin（字段） 查询
		/// </summary>
		/// /// <param name = "payMin">充值金额下限</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_firstpay_frequency_configEO> GetByPayMin(long payMin, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PayMin` = @PayMin", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PayMin", payMin, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_firstpay_frequency_configEO.MapDataReader);
		}
		public async Task<List<Sa_firstpay_frequency_configEO>> GetByPayMinAsync(long payMin, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PayMin` = @PayMin", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PayMin", payMin, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_firstpay_frequency_configEO.MapDataReader);
		}
		#endregion // GetByPayMin
		#region GetByPayMax
		
		/// <summary>
		/// 按 PayMax（字段） 查询
		/// </summary>
		/// /// <param name = "payMax">充值金额上限</param>
		/// <return>实体对象集合</return>
		public List<Sa_firstpay_frequency_configEO> GetByPayMax(long payMax)
		{
			return GetByPayMax(payMax, 0, string.Empty, null);
		}
		public async Task<List<Sa_firstpay_frequency_configEO>> GetByPayMaxAsync(long payMax)
		{
			return await GetByPayMaxAsync(payMax, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayMax（字段） 查询
		/// </summary>
		/// /// <param name = "payMax">充值金额上限</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_firstpay_frequency_configEO> GetByPayMax(long payMax, TransactionManager tm_)
		{
			return GetByPayMax(payMax, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_firstpay_frequency_configEO>> GetByPayMaxAsync(long payMax, TransactionManager tm_)
		{
			return await GetByPayMaxAsync(payMax, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayMax（字段） 查询
		/// </summary>
		/// /// <param name = "payMax">充值金额上限</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_firstpay_frequency_configEO> GetByPayMax(long payMax, int top_)
		{
			return GetByPayMax(payMax, top_, string.Empty, null);
		}
		public async Task<List<Sa_firstpay_frequency_configEO>> GetByPayMaxAsync(long payMax, int top_)
		{
			return await GetByPayMaxAsync(payMax, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayMax（字段） 查询
		/// </summary>
		/// /// <param name = "payMax">充值金额上限</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_firstpay_frequency_configEO> GetByPayMax(long payMax, int top_, TransactionManager tm_)
		{
			return GetByPayMax(payMax, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_firstpay_frequency_configEO>> GetByPayMaxAsync(long payMax, int top_, TransactionManager tm_)
		{
			return await GetByPayMaxAsync(payMax, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayMax（字段） 查询
		/// </summary>
		/// /// <param name = "payMax">充值金额上限</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_firstpay_frequency_configEO> GetByPayMax(long payMax, string sort_)
		{
			return GetByPayMax(payMax, 0, sort_, null);
		}
		public async Task<List<Sa_firstpay_frequency_configEO>> GetByPayMaxAsync(long payMax, string sort_)
		{
			return await GetByPayMaxAsync(payMax, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PayMax（字段） 查询
		/// </summary>
		/// /// <param name = "payMax">充值金额上限</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_firstpay_frequency_configEO> GetByPayMax(long payMax, string sort_, TransactionManager tm_)
		{
			return GetByPayMax(payMax, 0, sort_, tm_);
		}
		public async Task<List<Sa_firstpay_frequency_configEO>> GetByPayMaxAsync(long payMax, string sort_, TransactionManager tm_)
		{
			return await GetByPayMaxAsync(payMax, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PayMax（字段） 查询
		/// </summary>
		/// /// <param name = "payMax">充值金额上限</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_firstpay_frequency_configEO> GetByPayMax(long payMax, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PayMax` = @PayMax", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PayMax", payMax, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_firstpay_frequency_configEO.MapDataReader);
		}
		public async Task<List<Sa_firstpay_frequency_configEO>> GetByPayMaxAsync(long payMax, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PayMax` = @PayMax", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PayMax", payMax, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_firstpay_frequency_configEO.MapDataReader);
		}
		#endregion // GetByPayMax
		#region GetByPayMultiple
		
		/// <summary>
		/// 按 PayMultiple（字段） 查询
		/// </summary>
		/// /// <param name = "payMultiple">充值赠金倍数</param>
		/// <return>实体对象集合</return>
		public List<Sa_firstpay_frequency_configEO> GetByPayMultiple(float payMultiple)
		{
			return GetByPayMultiple(payMultiple, 0, string.Empty, null);
		}
		public async Task<List<Sa_firstpay_frequency_configEO>> GetByPayMultipleAsync(float payMultiple)
		{
			return await GetByPayMultipleAsync(payMultiple, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayMultiple（字段） 查询
		/// </summary>
		/// /// <param name = "payMultiple">充值赠金倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_firstpay_frequency_configEO> GetByPayMultiple(float payMultiple, TransactionManager tm_)
		{
			return GetByPayMultiple(payMultiple, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_firstpay_frequency_configEO>> GetByPayMultipleAsync(float payMultiple, TransactionManager tm_)
		{
			return await GetByPayMultipleAsync(payMultiple, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayMultiple（字段） 查询
		/// </summary>
		/// /// <param name = "payMultiple">充值赠金倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_firstpay_frequency_configEO> GetByPayMultiple(float payMultiple, int top_)
		{
			return GetByPayMultiple(payMultiple, top_, string.Empty, null);
		}
		public async Task<List<Sa_firstpay_frequency_configEO>> GetByPayMultipleAsync(float payMultiple, int top_)
		{
			return await GetByPayMultipleAsync(payMultiple, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayMultiple（字段） 查询
		/// </summary>
		/// /// <param name = "payMultiple">充值赠金倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_firstpay_frequency_configEO> GetByPayMultiple(float payMultiple, int top_, TransactionManager tm_)
		{
			return GetByPayMultiple(payMultiple, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_firstpay_frequency_configEO>> GetByPayMultipleAsync(float payMultiple, int top_, TransactionManager tm_)
		{
			return await GetByPayMultipleAsync(payMultiple, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayMultiple（字段） 查询
		/// </summary>
		/// /// <param name = "payMultiple">充值赠金倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_firstpay_frequency_configEO> GetByPayMultiple(float payMultiple, string sort_)
		{
			return GetByPayMultiple(payMultiple, 0, sort_, null);
		}
		public async Task<List<Sa_firstpay_frequency_configEO>> GetByPayMultipleAsync(float payMultiple, string sort_)
		{
			return await GetByPayMultipleAsync(payMultiple, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PayMultiple（字段） 查询
		/// </summary>
		/// /// <param name = "payMultiple">充值赠金倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_firstpay_frequency_configEO> GetByPayMultiple(float payMultiple, string sort_, TransactionManager tm_)
		{
			return GetByPayMultiple(payMultiple, 0, sort_, tm_);
		}
		public async Task<List<Sa_firstpay_frequency_configEO>> GetByPayMultipleAsync(float payMultiple, string sort_, TransactionManager tm_)
		{
			return await GetByPayMultipleAsync(payMultiple, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PayMultiple（字段） 查询
		/// </summary>
		/// /// <param name = "payMultiple">充值赠金倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_firstpay_frequency_configEO> GetByPayMultiple(float payMultiple, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PayMultiple` = @PayMultiple", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PayMultiple", payMultiple, MySqlDbType.Float));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_firstpay_frequency_configEO.MapDataReader);
		}
		public async Task<List<Sa_firstpay_frequency_configEO>> GetByPayMultipleAsync(float payMultiple, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PayMultiple` = @PayMultiple", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PayMultiple", payMultiple, MySqlDbType.Float));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_firstpay_frequency_configEO.MapDataReader);
		}
		#endregion // GetByPayMultiple
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录创建时间</param>
		/// <return>实体对象集合</return>
		public List<Sa_firstpay_frequency_configEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<Sa_firstpay_frequency_configEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录创建时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_firstpay_frequency_configEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_firstpay_frequency_configEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录创建时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_firstpay_frequency_configEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<Sa_firstpay_frequency_configEO>> GetByRecDateAsync(DateTime recDate, int top_)
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
		public List<Sa_firstpay_frequency_configEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_firstpay_frequency_configEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录创建时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_firstpay_frequency_configEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<Sa_firstpay_frequency_configEO>> GetByRecDateAsync(DateTime recDate, string sort_)
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
		public List<Sa_firstpay_frequency_configEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<Sa_firstpay_frequency_configEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
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
		public List<Sa_firstpay_frequency_configEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_firstpay_frequency_configEO.MapDataReader);
		}
		public async Task<List<Sa_firstpay_frequency_configEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_firstpay_frequency_configEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
