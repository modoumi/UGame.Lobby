/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * AiUo代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/AiUo
 * 文档生成时间：2023-10-24 18: 04:49
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
	/// app的jackpot
	/// 【表 l_app_jackpot 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class L_app_jackpotEO : IRowMapper<L_app_jackpotEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public L_app_jackpotEO()
		{
			this.Jackpot = 0;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private string _originalAppID;
		/// <summary>
		/// 【数据库中的原始主键 AppID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalAppID
		{
			get { return _originalAppID; }
			set { HasOriginal = true; _originalAppID = value; }
		}
		
		private string _originalCountryId;
		/// <summary>
		/// 【数据库中的原始主键 CountryId 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalCountryId
		{
			get { return _originalCountryId; }
			set { HasOriginal = true; _originalCountryId = value; }
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
		
		private string _originalCurrencyID;
		/// <summary>
		/// 【数据库中的原始主键 CurrencyID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalCurrencyID
		{
			get { return _originalCurrencyID; }
			set { HasOriginal = true; _originalCurrencyID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "AppID", AppID },  { "CountryId", CountryId },  { "OperatorID", OperatorID },  { "CurrencyID", CurrencyID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 应用编码
		/// 【主键 varchar(50)】
		/// </summary>
		[DataMember(Order = 1)]
		public string AppID { get; set; }
		/// <summary>
		/// 国家编码ISO 3166-1三位字母
		/// 【主键 varchar(5)】
		/// </summary>
		[DataMember(Order = 2)]
		public string CountryId { get; set; }
		/// <summary>
		/// 运营商编码
		/// 【主键 varchar(50)】
		/// </summary>
		[DataMember(Order = 3)]
		public string OperatorID { get; set; }
		/// <summary>
		/// 货币类型
		/// 【主键 varchar(5)】
		/// </summary>
		[DataMember(Order = 4)]
		public string CurrencyID { get; set; }
		/// <summary>
		/// 源表jackpot字段名
		/// 【字段 varchar(100)】
		/// </summary>
		[DataMember(Order = 5)]
		public string SourceField { get; set; }
		/// <summary>
		/// 源表名
		/// 【字段 varchar(100)】
		/// </summary>
		[DataMember(Order = 6)]
		public string SourceTable { get; set; }
		/// <summary>
		/// jackpot值
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 7)]
		public long Jackpot { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public L_app_jackpotEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static L_app_jackpotEO MapDataReader(IDataReader reader)
		{
		    L_app_jackpotEO ret = new L_app_jackpotEO();
			ret.AppID = reader.ToString("AppID");
			ret.OriginalAppID = ret.AppID;
			ret.CountryId = reader.ToString("CountryId");
			ret.OriginalCountryId = ret.CountryId;
			ret.OperatorID = reader.ToString("OperatorID");
			ret.OriginalOperatorID = ret.OperatorID;
			ret.CurrencyID = reader.ToString("CurrencyID");
			ret.OriginalCurrencyID = ret.CurrencyID;
			ret.SourceField = reader.ToString("SourceField");
			ret.SourceTable = reader.ToString("SourceTable");
			ret.Jackpot = reader.ToInt64("Jackpot");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// app的jackpot
	/// 【表 l_app_jackpot 的操作类】
	/// </summary>
	[Obsolete]
	public class L_app_jackpotMO : MySqlTableMO<L_app_jackpotEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`l_app_jackpot`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public L_app_jackpotMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public L_app_jackpotMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public L_app_jackpotMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(L_app_jackpotEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(L_app_jackpotEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(L_app_jackpotEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`AppID`, `CountryId`, `OperatorID`, `CurrencyID`, `SourceField`, `SourceTable`, `Jackpot`) VALUE (@AppID, @CountryId, @OperatorID, @CurrencyID, @SourceField, @SourceTable, @Jackpot);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", item.AppID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryId", item.CountryId, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@SourceField", item.SourceField, MySqlDbType.VarChar),
				Database.CreateInParameter("@SourceTable", item.SourceTable, MySqlDbType.VarChar),
				Database.CreateInParameter("@Jackpot", item.Jackpot, MySqlDbType.Int64),
			};
		}
		public int AddByBatch(IEnumerable<L_app_jackpotEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<L_app_jackpotEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<L_app_jackpotEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`AppID`, `CountryId`, `OperatorID`, `CurrencyID`, `SourceField`, `SourceTable`, `Jackpot`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.AppID}','{item.CountryId}','{item.OperatorID}','{item.CurrencyID}','{item.SourceField}','{item.SourceTable}',{item.Jackpot}),");
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
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string appID, string countryId, string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(appID, countryId, operatorID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string appID, string countryId, string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(appID, countryId, operatorID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string appID, string countryId, string operatorID, string currencyID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `AppID` = @AppID AND `CountryId` = @CountryId AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(L_app_jackpotEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.AppID, item.CountryId, item.OperatorID, item.CurrencyID, tm_);
		}
		public async Task<int> RemoveAsync(L_app_jackpotEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.AppID, item.CountryId, item.OperatorID, item.CurrencyID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByAppID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByAppID(string appID, TransactionManager tm_ = null)
		{
			RepairRemoveByAppIDData(appID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByAppIDAsync(string appID, TransactionManager tm_ = null)
		{
			RepairRemoveByAppIDData(appID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByAppIDData(string appID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `AppID` = @AppID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByAppID
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
			sql_ = $"DELETE FROM {TableName} WHERE `CountryId` = @CountryId";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar));
		}
		#endregion // RemoveByCountryId
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
		#region RemoveBySourceField
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "sourceField">源表jackpot字段名</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveBySourceField(string sourceField, TransactionManager tm_ = null)
		{
			RepairRemoveBySourceFieldData(sourceField, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveBySourceFieldAsync(string sourceField, TransactionManager tm_ = null)
		{
			RepairRemoveBySourceFieldData(sourceField, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveBySourceFieldData(string sourceField, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `SourceField` = @SourceField";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SourceField", sourceField, MySqlDbType.VarChar));
		}
		#endregion // RemoveBySourceField
		#region RemoveBySourceTable
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "sourceTable">源表名</param>
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
			sql_ = $"DELETE FROM {TableName} WHERE `SourceTable` = @SourceTable";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SourceTable", sourceTable, MySqlDbType.VarChar));
		}
		#endregion // RemoveBySourceTable
		#region RemoveByJackpot
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "jackpot">jackpot值</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByJackpot(long jackpot, TransactionManager tm_ = null)
		{
			RepairRemoveByJackpotData(jackpot, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByJackpotAsync(long jackpot, TransactionManager tm_ = null)
		{
			RepairRemoveByJackpotData(jackpot, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByJackpotData(long jackpot, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Jackpot` = @Jackpot";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Jackpot", jackpot, MySqlDbType.Int64));
		}
		#endregion // RemoveByJackpot
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
		public int Put(L_app_jackpotEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(L_app_jackpotEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(L_app_jackpotEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `AppID` = @AppID, `CountryId` = @CountryId, `OperatorID` = @OperatorID, `CurrencyID` = @CurrencyID, `SourceField` = @SourceField, `SourceTable` = @SourceTable, `Jackpot` = @Jackpot WHERE `AppID` = @AppID_Original AND `CountryId` = @CountryId_Original AND `OperatorID` = @OperatorID_Original AND `CurrencyID` = @CurrencyID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", item.AppID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryId", item.CountryId, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@SourceField", item.SourceField, MySqlDbType.VarChar),
				Database.CreateInParameter("@SourceTable", item.SourceTable, MySqlDbType.VarChar),
				Database.CreateInParameter("@Jackpot", item.Jackpot, MySqlDbType.Int64),
				Database.CreateInParameter("@AppID_Original", item.HasOriginal ? item.OriginalAppID : item.AppID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryId_Original", item.HasOriginal ? item.OriginalCountryId : item.CountryId, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID_Original", item.HasOriginal ? item.OriginalOperatorID : item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID_Original", item.HasOriginal ? item.OriginalCurrencyID : item.CurrencyID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<L_app_jackpotEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<L_app_jackpotEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string appID, string countryId, string operatorID, string currencyID, string set_, params object[] values_)
		{
			return Put(set_, "`AppID` = @AppID AND `CountryId` = @CountryId AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", ConcatValues(values_, appID, countryId, operatorID, currencyID));
		}
		public async Task<int> PutByPKAsync(string appID, string countryId, string operatorID, string currencyID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`AppID` = @AppID AND `CountryId` = @CountryId AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", ConcatValues(values_, appID, countryId, operatorID, currencyID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string appID, string countryId, string operatorID, string currencyID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`AppID` = @AppID AND `CountryId` = @CountryId AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", tm_, ConcatValues(values_, appID, countryId, operatorID, currencyID));
		}
		public async Task<int> PutByPKAsync(string appID, string countryId, string operatorID, string currencyID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`AppID` = @AppID AND `CountryId` = @CountryId AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", tm_, ConcatValues(values_, appID, countryId, operatorID, currencyID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string appID, string countryId, string operatorID, string currencyID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`AppID` = @AppID AND `CountryId` = @CountryId AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string appID, string countryId, string operatorID, string currencyID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`AppID` = @AppID AND `CountryId` = @CountryId AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutAppID
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAppID(string appID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `AppID` = @AppID";
			var parameter_ = Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutAppIDAsync(string appID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `AppID` = @AppID";
			var parameter_ = Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutAppID
		#region PutCountryId
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCountryId(string countryId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CountryId` = @CountryId";
			var parameter_ = Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCountryIdAsync(string countryId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CountryId` = @CountryId";
			var parameter_ = Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCountryId
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
		#region PutCurrencyID
	 
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
		#region PutSourceField
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// /// <param name = "sourceField">源表jackpot字段名</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSourceFieldByPK(string appID, string countryId, string operatorID, string currencyID, string sourceField, TransactionManager tm_ = null)
		{
			RepairPutSourceFieldByPKData(appID, countryId, operatorID, currencyID, sourceField, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutSourceFieldByPKAsync(string appID, string countryId, string operatorID, string currencyID, string sourceField, TransactionManager tm_ = null)
		{
			RepairPutSourceFieldByPKData(appID, countryId, operatorID, currencyID, sourceField, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutSourceFieldByPKData(string appID, string countryId, string operatorID, string currencyID, string sourceField, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `SourceField` = @SourceField  WHERE `AppID` = @AppID AND `CountryId` = @CountryId AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SourceField", sourceField, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "sourceField">源表jackpot字段名</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSourceField(string sourceField, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SourceField` = @SourceField";
			var parameter_ = Database.CreateInParameter("@SourceField", sourceField, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutSourceFieldAsync(string sourceField, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SourceField` = @SourceField";
			var parameter_ = Database.CreateInParameter("@SourceField", sourceField, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutSourceField
		#region PutSourceTable
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// /// <param name = "sourceTable">源表名</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSourceTableByPK(string appID, string countryId, string operatorID, string currencyID, string sourceTable, TransactionManager tm_ = null)
		{
			RepairPutSourceTableByPKData(appID, countryId, operatorID, currencyID, sourceTable, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutSourceTableByPKAsync(string appID, string countryId, string operatorID, string currencyID, string sourceTable, TransactionManager tm_ = null)
		{
			RepairPutSourceTableByPKData(appID, countryId, operatorID, currencyID, sourceTable, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutSourceTableByPKData(string appID, string countryId, string operatorID, string currencyID, string sourceTable, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `SourceTable` = @SourceTable  WHERE `AppID` = @AppID AND `CountryId` = @CountryId AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SourceTable", sourceTable, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "sourceTable">源表名</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSourceTable(string sourceTable, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SourceTable` = @SourceTable";
			var parameter_ = Database.CreateInParameter("@SourceTable", sourceTable, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutSourceTableAsync(string sourceTable, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SourceTable` = @SourceTable";
			var parameter_ = Database.CreateInParameter("@SourceTable", sourceTable, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutSourceTable
		#region PutJackpot
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// /// <param name = "jackpot">jackpot值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutJackpotByPK(string appID, string countryId, string operatorID, string currencyID, long jackpot, TransactionManager tm_ = null)
		{
			RepairPutJackpotByPKData(appID, countryId, operatorID, currencyID, jackpot, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutJackpotByPKAsync(string appID, string countryId, string operatorID, string currencyID, long jackpot, TransactionManager tm_ = null)
		{
			RepairPutJackpotByPKData(appID, countryId, operatorID, currencyID, jackpot, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutJackpotByPKData(string appID, string countryId, string operatorID, string currencyID, long jackpot, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Jackpot` = @Jackpot  WHERE `AppID` = @AppID AND `CountryId` = @CountryId AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Jackpot", jackpot, MySqlDbType.Int64),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "jackpot">jackpot值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutJackpot(long jackpot, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Jackpot` = @Jackpot";
			var parameter_ = Database.CreateInParameter("@Jackpot", jackpot, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutJackpotAsync(long jackpot, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Jackpot` = @Jackpot";
			var parameter_ = Database.CreateInParameter("@Jackpot", jackpot, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutJackpot
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(L_app_jackpotEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.AppID, item.CountryId, item.OperatorID, item.CurrencyID) == null)
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
		public async Task<bool> SetAsync(L_app_jackpotEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.AppID, item.CountryId, item.OperatorID, item.CurrencyID) == null)
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
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public L_app_jackpotEO GetByPK(string appID, string countryId, string operatorID, string currencyID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(appID, countryId, operatorID, currencyID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, L_app_jackpotEO.MapDataReader);
		}
		public async Task<L_app_jackpotEO> GetByPKAsync(string appID, string countryId, string operatorID, string currencyID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(appID, countryId, operatorID, currencyID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, L_app_jackpotEO.MapDataReader);
		}
		private void RepairGetByPKData(string appID, string countryId, string operatorID, string currencyID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`AppID` = @AppID AND `CountryId` = @CountryId AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 AppID（字段）
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetAppIDByPK(string appID, string countryId, string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`AppID`", "`AppID` = @AppID AND `CountryId` = @CountryId AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<string> GetAppIDByPKAsync(string appID, string countryId, string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`AppID`", "`AppID` = @AppID AND `CountryId` = @CountryId AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CountryId（字段）
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCountryIdByPK(string appID, string countryId, string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CountryId`", "`AppID` = @AppID AND `CountryId` = @CountryId AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<string> GetCountryIdByPKAsync(string appID, string countryId, string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CountryId`", "`AppID` = @AppID AND `CountryId` = @CountryId AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OperatorID（字段）
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorIDByPK(string appID, string countryId, string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OperatorID`", "`AppID` = @AppID AND `CountryId` = @CountryId AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<string> GetOperatorIDByPKAsync(string appID, string countryId, string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OperatorID`", "`AppID` = @AppID AND `CountryId` = @CountryId AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CurrencyID（字段）
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCurrencyIDByPK(string appID, string countryId, string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CurrencyID`", "`AppID` = @AppID AND `CountryId` = @CountryId AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<string> GetCurrencyIDByPKAsync(string appID, string countryId, string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CurrencyID`", "`AppID` = @AppID AND `CountryId` = @CountryId AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 SourceField（字段）
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetSourceFieldByPK(string appID, string countryId, string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`SourceField`", "`AppID` = @AppID AND `CountryId` = @CountryId AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<string> GetSourceFieldByPKAsync(string appID, string countryId, string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`SourceField`", "`AppID` = @AppID AND `CountryId` = @CountryId AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 SourceTable（字段）
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetSourceTableByPK(string appID, string countryId, string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`SourceTable`", "`AppID` = @AppID AND `CountryId` = @CountryId AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<string> GetSourceTableByPKAsync(string appID, string countryId, string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`SourceTable`", "`AppID` = @AppID AND `CountryId` = @CountryId AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Jackpot（字段）
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetJackpotByPK(string appID, string countryId, string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`Jackpot`", "`AppID` = @AppID AND `CountryId` = @CountryId AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<long> GetJackpotByPKAsync(string appID, string countryId, string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`Jackpot`", "`AppID` = @AppID AND `CountryId` = @CountryId AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByAppID
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <return>实体对象集合</return>
		public List<L_app_jackpotEO> GetByAppID(string appID)
		{
			return GetByAppID(appID, 0, string.Empty, null);
		}
		public async Task<List<L_app_jackpotEO>> GetByAppIDAsync(string appID)
		{
			return await GetByAppIDAsync(appID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_app_jackpotEO> GetByAppID(string appID, TransactionManager tm_)
		{
			return GetByAppID(appID, 0, string.Empty, tm_);
		}
		public async Task<List<L_app_jackpotEO>> GetByAppIDAsync(string appID, TransactionManager tm_)
		{
			return await GetByAppIDAsync(appID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_app_jackpotEO> GetByAppID(string appID, int top_)
		{
			return GetByAppID(appID, top_, string.Empty, null);
		}
		public async Task<List<L_app_jackpotEO>> GetByAppIDAsync(string appID, int top_)
		{
			return await GetByAppIDAsync(appID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_app_jackpotEO> GetByAppID(string appID, int top_, TransactionManager tm_)
		{
			return GetByAppID(appID, top_, string.Empty, tm_);
		}
		public async Task<List<L_app_jackpotEO>> GetByAppIDAsync(string appID, int top_, TransactionManager tm_)
		{
			return await GetByAppIDAsync(appID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_app_jackpotEO> GetByAppID(string appID, string sort_)
		{
			return GetByAppID(appID, 0, sort_, null);
		}
		public async Task<List<L_app_jackpotEO>> GetByAppIDAsync(string appID, string sort_)
		{
			return await GetByAppIDAsync(appID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_app_jackpotEO> GetByAppID(string appID, string sort_, TransactionManager tm_)
		{
			return GetByAppID(appID, 0, sort_, tm_);
		}
		public async Task<List<L_app_jackpotEO>> GetByAppIDAsync(string appID, string sort_, TransactionManager tm_)
		{
			return await GetByAppIDAsync(appID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_app_jackpotEO> GetByAppID(string appID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`AppID` = @AppID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_app_jackpotEO.MapDataReader);
		}
		public async Task<List<L_app_jackpotEO>> GetByAppIDAsync(string appID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`AppID` = @AppID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_app_jackpotEO.MapDataReader);
		}
		#endregion // GetByAppID
		#region GetByCountryId
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <return>实体对象集合</return>
		public List<L_app_jackpotEO> GetByCountryId(string countryId)
		{
			return GetByCountryId(countryId, 0, string.Empty, null);
		}
		public async Task<List<L_app_jackpotEO>> GetByCountryIdAsync(string countryId)
		{
			return await GetByCountryIdAsync(countryId, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_app_jackpotEO> GetByCountryId(string countryId, TransactionManager tm_)
		{
			return GetByCountryId(countryId, 0, string.Empty, tm_);
		}
		public async Task<List<L_app_jackpotEO>> GetByCountryIdAsync(string countryId, TransactionManager tm_)
		{
			return await GetByCountryIdAsync(countryId, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_app_jackpotEO> GetByCountryId(string countryId, int top_)
		{
			return GetByCountryId(countryId, top_, string.Empty, null);
		}
		public async Task<List<L_app_jackpotEO>> GetByCountryIdAsync(string countryId, int top_)
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
		public List<L_app_jackpotEO> GetByCountryId(string countryId, int top_, TransactionManager tm_)
		{
			return GetByCountryId(countryId, top_, string.Empty, tm_);
		}
		public async Task<List<L_app_jackpotEO>> GetByCountryIdAsync(string countryId, int top_, TransactionManager tm_)
		{
			return await GetByCountryIdAsync(countryId, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_app_jackpotEO> GetByCountryId(string countryId, string sort_)
		{
			return GetByCountryId(countryId, 0, sort_, null);
		}
		public async Task<List<L_app_jackpotEO>> GetByCountryIdAsync(string countryId, string sort_)
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
		public List<L_app_jackpotEO> GetByCountryId(string countryId, string sort_, TransactionManager tm_)
		{
			return GetByCountryId(countryId, 0, sort_, tm_);
		}
		public async Task<List<L_app_jackpotEO>> GetByCountryIdAsync(string countryId, string sort_, TransactionManager tm_)
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
		public List<L_app_jackpotEO> GetByCountryId(string countryId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CountryId` = @CountryId", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_app_jackpotEO.MapDataReader);
		}
		public async Task<List<L_app_jackpotEO>> GetByCountryIdAsync(string countryId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CountryId` = @CountryId", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_app_jackpotEO.MapDataReader);
		}
		#endregion // GetByCountryId
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <return>实体对象集合</return>
		public List<L_app_jackpotEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<L_app_jackpotEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_app_jackpotEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<L_app_jackpotEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_app_jackpotEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<L_app_jackpotEO>> GetByOperatorIDAsync(string operatorID, int top_)
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
		public List<L_app_jackpotEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<L_app_jackpotEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_app_jackpotEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<L_app_jackpotEO>> GetByOperatorIDAsync(string operatorID, string sort_)
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
		public List<L_app_jackpotEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<L_app_jackpotEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
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
		public List<L_app_jackpotEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_app_jackpotEO.MapDataReader);
		}
		public async Task<List<L_app_jackpotEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_app_jackpotEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByCurrencyID
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <return>实体对象集合</return>
		public List<L_app_jackpotEO> GetByCurrencyID(string currencyID)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, null);
		}
		public async Task<List<L_app_jackpotEO>> GetByCurrencyIDAsync(string currencyID)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_app_jackpotEO> GetByCurrencyID(string currencyID, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, tm_);
		}
		public async Task<List<L_app_jackpotEO>> GetByCurrencyIDAsync(string currencyID, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_app_jackpotEO> GetByCurrencyID(string currencyID, int top_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, null);
		}
		public async Task<List<L_app_jackpotEO>> GetByCurrencyIDAsync(string currencyID, int top_)
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
		public List<L_app_jackpotEO> GetByCurrencyID(string currencyID, int top_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, tm_);
		}
		public async Task<List<L_app_jackpotEO>> GetByCurrencyIDAsync(string currencyID, int top_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_app_jackpotEO> GetByCurrencyID(string currencyID, string sort_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, null);
		}
		public async Task<List<L_app_jackpotEO>> GetByCurrencyIDAsync(string currencyID, string sort_)
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
		public List<L_app_jackpotEO> GetByCurrencyID(string currencyID, string sort_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, tm_);
		}
		public async Task<List<L_app_jackpotEO>> GetByCurrencyIDAsync(string currencyID, string sort_, TransactionManager tm_)
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
		public List<L_app_jackpotEO> GetByCurrencyID(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_app_jackpotEO.MapDataReader);
		}
		public async Task<List<L_app_jackpotEO>> GetByCurrencyIDAsync(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_app_jackpotEO.MapDataReader);
		}
		#endregion // GetByCurrencyID
		#region GetBySourceField
		
		/// <summary>
		/// 按 SourceField（字段） 查询
		/// </summary>
		/// /// <param name = "sourceField">源表jackpot字段名</param>
		/// <return>实体对象集合</return>
		public List<L_app_jackpotEO> GetBySourceField(string sourceField)
		{
			return GetBySourceField(sourceField, 0, string.Empty, null);
		}
		public async Task<List<L_app_jackpotEO>> GetBySourceFieldAsync(string sourceField)
		{
			return await GetBySourceFieldAsync(sourceField, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SourceField（字段） 查询
		/// </summary>
		/// /// <param name = "sourceField">源表jackpot字段名</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_app_jackpotEO> GetBySourceField(string sourceField, TransactionManager tm_)
		{
			return GetBySourceField(sourceField, 0, string.Empty, tm_);
		}
		public async Task<List<L_app_jackpotEO>> GetBySourceFieldAsync(string sourceField, TransactionManager tm_)
		{
			return await GetBySourceFieldAsync(sourceField, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SourceField（字段） 查询
		/// </summary>
		/// /// <param name = "sourceField">源表jackpot字段名</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_app_jackpotEO> GetBySourceField(string sourceField, int top_)
		{
			return GetBySourceField(sourceField, top_, string.Empty, null);
		}
		public async Task<List<L_app_jackpotEO>> GetBySourceFieldAsync(string sourceField, int top_)
		{
			return await GetBySourceFieldAsync(sourceField, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SourceField（字段） 查询
		/// </summary>
		/// /// <param name = "sourceField">源表jackpot字段名</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_app_jackpotEO> GetBySourceField(string sourceField, int top_, TransactionManager tm_)
		{
			return GetBySourceField(sourceField, top_, string.Empty, tm_);
		}
		public async Task<List<L_app_jackpotEO>> GetBySourceFieldAsync(string sourceField, int top_, TransactionManager tm_)
		{
			return await GetBySourceFieldAsync(sourceField, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SourceField（字段） 查询
		/// </summary>
		/// /// <param name = "sourceField">源表jackpot字段名</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_app_jackpotEO> GetBySourceField(string sourceField, string sort_)
		{
			return GetBySourceField(sourceField, 0, sort_, null);
		}
		public async Task<List<L_app_jackpotEO>> GetBySourceFieldAsync(string sourceField, string sort_)
		{
			return await GetBySourceFieldAsync(sourceField, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 SourceField（字段） 查询
		/// </summary>
		/// /// <param name = "sourceField">源表jackpot字段名</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_app_jackpotEO> GetBySourceField(string sourceField, string sort_, TransactionManager tm_)
		{
			return GetBySourceField(sourceField, 0, sort_, tm_);
		}
		public async Task<List<L_app_jackpotEO>> GetBySourceFieldAsync(string sourceField, string sort_, TransactionManager tm_)
		{
			return await GetBySourceFieldAsync(sourceField, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 SourceField（字段） 查询
		/// </summary>
		/// /// <param name = "sourceField">源表jackpot字段名</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_app_jackpotEO> GetBySourceField(string sourceField, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SourceField` = @SourceField", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SourceField", sourceField, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_app_jackpotEO.MapDataReader);
		}
		public async Task<List<L_app_jackpotEO>> GetBySourceFieldAsync(string sourceField, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SourceField` = @SourceField", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SourceField", sourceField, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_app_jackpotEO.MapDataReader);
		}
		#endregion // GetBySourceField
		#region GetBySourceTable
		
		/// <summary>
		/// 按 SourceTable（字段） 查询
		/// </summary>
		/// /// <param name = "sourceTable">源表名</param>
		/// <return>实体对象集合</return>
		public List<L_app_jackpotEO> GetBySourceTable(string sourceTable)
		{
			return GetBySourceTable(sourceTable, 0, string.Empty, null);
		}
		public async Task<List<L_app_jackpotEO>> GetBySourceTableAsync(string sourceTable)
		{
			return await GetBySourceTableAsync(sourceTable, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SourceTable（字段） 查询
		/// </summary>
		/// /// <param name = "sourceTable">源表名</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_app_jackpotEO> GetBySourceTable(string sourceTable, TransactionManager tm_)
		{
			return GetBySourceTable(sourceTable, 0, string.Empty, tm_);
		}
		public async Task<List<L_app_jackpotEO>> GetBySourceTableAsync(string sourceTable, TransactionManager tm_)
		{
			return await GetBySourceTableAsync(sourceTable, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SourceTable（字段） 查询
		/// </summary>
		/// /// <param name = "sourceTable">源表名</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_app_jackpotEO> GetBySourceTable(string sourceTable, int top_)
		{
			return GetBySourceTable(sourceTable, top_, string.Empty, null);
		}
		public async Task<List<L_app_jackpotEO>> GetBySourceTableAsync(string sourceTable, int top_)
		{
			return await GetBySourceTableAsync(sourceTable, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SourceTable（字段） 查询
		/// </summary>
		/// /// <param name = "sourceTable">源表名</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_app_jackpotEO> GetBySourceTable(string sourceTable, int top_, TransactionManager tm_)
		{
			return GetBySourceTable(sourceTable, top_, string.Empty, tm_);
		}
		public async Task<List<L_app_jackpotEO>> GetBySourceTableAsync(string sourceTable, int top_, TransactionManager tm_)
		{
			return await GetBySourceTableAsync(sourceTable, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SourceTable（字段） 查询
		/// </summary>
		/// /// <param name = "sourceTable">源表名</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_app_jackpotEO> GetBySourceTable(string sourceTable, string sort_)
		{
			return GetBySourceTable(sourceTable, 0, sort_, null);
		}
		public async Task<List<L_app_jackpotEO>> GetBySourceTableAsync(string sourceTable, string sort_)
		{
			return await GetBySourceTableAsync(sourceTable, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 SourceTable（字段） 查询
		/// </summary>
		/// /// <param name = "sourceTable">源表名</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_app_jackpotEO> GetBySourceTable(string sourceTable, string sort_, TransactionManager tm_)
		{
			return GetBySourceTable(sourceTable, 0, sort_, tm_);
		}
		public async Task<List<L_app_jackpotEO>> GetBySourceTableAsync(string sourceTable, string sort_, TransactionManager tm_)
		{
			return await GetBySourceTableAsync(sourceTable, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 SourceTable（字段） 查询
		/// </summary>
		/// /// <param name = "sourceTable">源表名</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_app_jackpotEO> GetBySourceTable(string sourceTable, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SourceTable` = @SourceTable", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SourceTable", sourceTable, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_app_jackpotEO.MapDataReader);
		}
		public async Task<List<L_app_jackpotEO>> GetBySourceTableAsync(string sourceTable, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SourceTable` = @SourceTable", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SourceTable", sourceTable, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_app_jackpotEO.MapDataReader);
		}
		#endregion // GetBySourceTable
		#region GetByJackpot
		
		/// <summary>
		/// 按 Jackpot（字段） 查询
		/// </summary>
		/// /// <param name = "jackpot">jackpot值</param>
		/// <return>实体对象集合</return>
		public List<L_app_jackpotEO> GetByJackpot(long jackpot)
		{
			return GetByJackpot(jackpot, 0, string.Empty, null);
		}
		public async Task<List<L_app_jackpotEO>> GetByJackpotAsync(long jackpot)
		{
			return await GetByJackpotAsync(jackpot, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Jackpot（字段） 查询
		/// </summary>
		/// /// <param name = "jackpot">jackpot值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_app_jackpotEO> GetByJackpot(long jackpot, TransactionManager tm_)
		{
			return GetByJackpot(jackpot, 0, string.Empty, tm_);
		}
		public async Task<List<L_app_jackpotEO>> GetByJackpotAsync(long jackpot, TransactionManager tm_)
		{
			return await GetByJackpotAsync(jackpot, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Jackpot（字段） 查询
		/// </summary>
		/// /// <param name = "jackpot">jackpot值</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_app_jackpotEO> GetByJackpot(long jackpot, int top_)
		{
			return GetByJackpot(jackpot, top_, string.Empty, null);
		}
		public async Task<List<L_app_jackpotEO>> GetByJackpotAsync(long jackpot, int top_)
		{
			return await GetByJackpotAsync(jackpot, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Jackpot（字段） 查询
		/// </summary>
		/// /// <param name = "jackpot">jackpot值</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_app_jackpotEO> GetByJackpot(long jackpot, int top_, TransactionManager tm_)
		{
			return GetByJackpot(jackpot, top_, string.Empty, tm_);
		}
		public async Task<List<L_app_jackpotEO>> GetByJackpotAsync(long jackpot, int top_, TransactionManager tm_)
		{
			return await GetByJackpotAsync(jackpot, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Jackpot（字段） 查询
		/// </summary>
		/// /// <param name = "jackpot">jackpot值</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_app_jackpotEO> GetByJackpot(long jackpot, string sort_)
		{
			return GetByJackpot(jackpot, 0, sort_, null);
		}
		public async Task<List<L_app_jackpotEO>> GetByJackpotAsync(long jackpot, string sort_)
		{
			return await GetByJackpotAsync(jackpot, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Jackpot（字段） 查询
		/// </summary>
		/// /// <param name = "jackpot">jackpot值</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_app_jackpotEO> GetByJackpot(long jackpot, string sort_, TransactionManager tm_)
		{
			return GetByJackpot(jackpot, 0, sort_, tm_);
		}
		public async Task<List<L_app_jackpotEO>> GetByJackpotAsync(long jackpot, string sort_, TransactionManager tm_)
		{
			return await GetByJackpotAsync(jackpot, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Jackpot（字段） 查询
		/// </summary>
		/// /// <param name = "jackpot">jackpot值</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_app_jackpotEO> GetByJackpot(long jackpot, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Jackpot` = @Jackpot", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Jackpot", jackpot, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, L_app_jackpotEO.MapDataReader);
		}
		public async Task<List<L_app_jackpotEO>> GetByJackpotAsync(long jackpot, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Jackpot` = @Jackpot", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Jackpot", jackpot, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_app_jackpotEO.MapDataReader);
		}
		#endregion // GetByJackpot
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
