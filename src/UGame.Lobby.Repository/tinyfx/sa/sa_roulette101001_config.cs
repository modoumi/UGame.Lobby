/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * AiUo代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/AiUo
 * 文档生成时间：2023-10-24 18: 05:11
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
	/// 1.7版抽奖轮盘配置
	/// 【表 sa_roulette101001_config 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Sa_roulette101001_configEO : IRowMapper<Sa_roulette101001_configEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Sa_roulette101001_configEO()
		{
			this.PayCondition = 0;
			this.PaySendNum = 0;
			this.DaySendNumLimit = 0;
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
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "OperatorID", OperatorID }, };
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
		/// 【字段 varchar(5)】
		/// </summary>
		[DataMember(Order = 3)]
		public string CurrencyID { get; set; }
		/// <summary>
		/// 充值条件
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 4)]
		public long PayCondition { get; set; }
		/// <summary>
		/// 满足充值条件赠送的充值次数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 5)]
		public int PaySendNum { get; set; }
		/// <summary>
		/// 每日赠送次数上限
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 6)]
		public int DaySendNumLimit { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Sa_roulette101001_configEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Sa_roulette101001_configEO MapDataReader(IDataReader reader)
		{
		    Sa_roulette101001_configEO ret = new Sa_roulette101001_configEO();
			ret.OperatorID = reader.ToString("OperatorID");
			ret.OriginalOperatorID = ret.OperatorID;
			ret.CountryId = reader.ToString("CountryId");
			ret.CurrencyID = reader.ToString("CurrencyID");
			ret.PayCondition = reader.ToInt64("PayCondition");
			ret.PaySendNum = reader.ToInt32("PaySendNum");
			ret.DaySendNumLimit = reader.ToInt32("DaySendNumLimit");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 1.7版抽奖轮盘配置
	/// 【表 sa_roulette101001_config 的操作类】
	/// </summary>
	[Obsolete]
	public class Sa_roulette101001_configMO : MySqlTableMO<Sa_roulette101001_configEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`sa_roulette101001_config`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Sa_roulette101001_configMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Sa_roulette101001_configMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Sa_roulette101001_configMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Sa_roulette101001_configEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Sa_roulette101001_configEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Sa_roulette101001_configEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`OperatorID`, `CountryId`, `CurrencyID`, `PayCondition`, `PaySendNum`, `DaySendNumLimit`) VALUE (@OperatorID, @CountryId, @CurrencyID, @PayCondition, @PaySendNum, @DaySendNumLimit);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryId", item.CountryId, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PayCondition", item.PayCondition, MySqlDbType.Int64),
				Database.CreateInParameter("@PaySendNum", item.PaySendNum, MySqlDbType.Int32),
				Database.CreateInParameter("@DaySendNumLimit", item.DaySendNumLimit, MySqlDbType.Int32),
			};
		}
		public int AddByBatch(IEnumerable<Sa_roulette101001_configEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Sa_roulette101001_configEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sa_roulette101001_configEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`OperatorID`, `CountryId`, `CurrencyID`, `PayCondition`, `PaySendNum`, `DaySendNumLimit`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.OperatorID}','{item.CountryId}','{item.CurrencyID}',{item.PayCondition},{item.PaySendNum},{item.DaySendNumLimit}),");
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
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string operatorID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(operatorID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string operatorID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(operatorID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string operatorID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Sa_roulette101001_configEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.OperatorID, tm_);
		}
		public async Task<int> RemoveAsync(Sa_roulette101001_configEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.OperatorID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
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
		#region RemoveByPayCondition
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "payCondition">充值条件</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPayCondition(long payCondition, TransactionManager tm_ = null)
		{
			RepairRemoveByPayConditionData(payCondition, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPayConditionAsync(long payCondition, TransactionManager tm_ = null)
		{
			RepairRemoveByPayConditionData(payCondition, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByPayConditionData(long payCondition, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `PayCondition` = @PayCondition";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PayCondition", payCondition, MySqlDbType.Int64));
		}
		#endregion // RemoveByPayCondition
		#region RemoveByPaySendNum
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "paySendNum">满足充值条件赠送的充值次数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPaySendNum(int paySendNum, TransactionManager tm_ = null)
		{
			RepairRemoveByPaySendNumData(paySendNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPaySendNumAsync(int paySendNum, TransactionManager tm_ = null)
		{
			RepairRemoveByPaySendNumData(paySendNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByPaySendNumData(int paySendNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `PaySendNum` = @PaySendNum";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PaySendNum", paySendNum, MySqlDbType.Int32));
		}
		#endregion // RemoveByPaySendNum
		#region RemoveByDaySendNumLimit
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "daySendNumLimit">每日赠送次数上限</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByDaySendNumLimit(int daySendNumLimit, TransactionManager tm_ = null)
		{
			RepairRemoveByDaySendNumLimitData(daySendNumLimit, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByDaySendNumLimitAsync(int daySendNumLimit, TransactionManager tm_ = null)
		{
			RepairRemoveByDaySendNumLimitData(daySendNumLimit, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByDaySendNumLimitData(int daySendNumLimit, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `DaySendNumLimit` = @DaySendNumLimit";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DaySendNumLimit", daySendNumLimit, MySqlDbType.Int32));
		}
		#endregion // RemoveByDaySendNumLimit
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
		public int Put(Sa_roulette101001_configEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Sa_roulette101001_configEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Sa_roulette101001_configEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID, `CountryId` = @CountryId, `CurrencyID` = @CurrencyID, `PayCondition` = @PayCondition, `PaySendNum` = @PaySendNum, `DaySendNumLimit` = @DaySendNumLimit WHERE `OperatorID` = @OperatorID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryId", item.CountryId, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PayCondition", item.PayCondition, MySqlDbType.Int64),
				Database.CreateInParameter("@PaySendNum", item.PaySendNum, MySqlDbType.Int32),
				Database.CreateInParameter("@DaySendNumLimit", item.DaySendNumLimit, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID_Original", item.HasOriginal ? item.OriginalOperatorID : item.OperatorID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Sa_roulette101001_configEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Sa_roulette101001_configEO> items, TransactionManager tm_ = null)
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
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string operatorID, string set_, params object[] values_)
		{
			return Put(set_, "`OperatorID` = @OperatorID", ConcatValues(values_, operatorID));
		}
		public async Task<int> PutByPKAsync(string operatorID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`OperatorID` = @OperatorID", ConcatValues(values_, operatorID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string operatorID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`OperatorID` = @OperatorID", tm_, ConcatValues(values_, operatorID));
		}
		public async Task<int> PutByPKAsync(string operatorID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`OperatorID` = @OperatorID", tm_, ConcatValues(values_, operatorID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string operatorID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`OperatorID` = @OperatorID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string operatorID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`OperatorID` = @OperatorID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutCountryId
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCountryIdByPK(string operatorID, string countryId, TransactionManager tm_ = null)
		{
			RepairPutCountryIdByPKData(operatorID, countryId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCountryIdByPKAsync(string operatorID, string countryId, TransactionManager tm_ = null)
		{
			RepairPutCountryIdByPKData(operatorID, countryId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCountryIdByPKData(string operatorID, string countryId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CountryId` = @CountryId  WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
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
		#region PutCurrencyID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCurrencyIDByPK(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(operatorID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCurrencyIDByPKAsync(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(operatorID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCurrencyIDByPKData(string operatorID, string currencyID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CurrencyID` = @CurrencyID  WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
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
		#region PutPayCondition
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "payCondition">充值条件</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPayConditionByPK(string operatorID, long payCondition, TransactionManager tm_ = null)
		{
			RepairPutPayConditionByPKData(operatorID, payCondition, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutPayConditionByPKAsync(string operatorID, long payCondition, TransactionManager tm_ = null)
		{
			RepairPutPayConditionByPKData(operatorID, payCondition, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutPayConditionByPKData(string operatorID, long payCondition, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `PayCondition` = @PayCondition  WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PayCondition", payCondition, MySqlDbType.Int64),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "payCondition">充值条件</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPayCondition(long payCondition, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PayCondition` = @PayCondition";
			var parameter_ = Database.CreateInParameter("@PayCondition", payCondition, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutPayConditionAsync(long payCondition, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PayCondition` = @PayCondition";
			var parameter_ = Database.CreateInParameter("@PayCondition", payCondition, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutPayCondition
		#region PutPaySendNum
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "paySendNum">满足充值条件赠送的充值次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPaySendNumByPK(string operatorID, int paySendNum, TransactionManager tm_ = null)
		{
			RepairPutPaySendNumByPKData(operatorID, paySendNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutPaySendNumByPKAsync(string operatorID, int paySendNum, TransactionManager tm_ = null)
		{
			RepairPutPaySendNumByPKData(operatorID, paySendNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutPaySendNumByPKData(string operatorID, int paySendNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `PaySendNum` = @PaySendNum  WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PaySendNum", paySendNum, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "paySendNum">满足充值条件赠送的充值次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPaySendNum(int paySendNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PaySendNum` = @PaySendNum";
			var parameter_ = Database.CreateInParameter("@PaySendNum", paySendNum, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutPaySendNumAsync(int paySendNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PaySendNum` = @PaySendNum";
			var parameter_ = Database.CreateInParameter("@PaySendNum", paySendNum, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutPaySendNum
		#region PutDaySendNumLimit
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "daySendNumLimit">每日赠送次数上限</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutDaySendNumLimitByPK(string operatorID, int daySendNumLimit, TransactionManager tm_ = null)
		{
			RepairPutDaySendNumLimitByPKData(operatorID, daySendNumLimit, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutDaySendNumLimitByPKAsync(string operatorID, int daySendNumLimit, TransactionManager tm_ = null)
		{
			RepairPutDaySendNumLimitByPKData(operatorID, daySendNumLimit, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutDaySendNumLimitByPKData(string operatorID, int daySendNumLimit, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `DaySendNumLimit` = @DaySendNumLimit  WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DaySendNumLimit", daySendNumLimit, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "daySendNumLimit">每日赠送次数上限</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutDaySendNumLimit(int daySendNumLimit, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `DaySendNumLimit` = @DaySendNumLimit";
			var parameter_ = Database.CreateInParameter("@DaySendNumLimit", daySendNumLimit, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutDaySendNumLimitAsync(int daySendNumLimit, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `DaySendNumLimit` = @DaySendNumLimit";
			var parameter_ = Database.CreateInParameter("@DaySendNumLimit", daySendNumLimit, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutDaySendNumLimit
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Sa_roulette101001_configEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.OperatorID) == null)
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
		public async Task<bool> SetAsync(Sa_roulette101001_configEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.OperatorID) == null)
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
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Sa_roulette101001_configEO GetByPK(string operatorID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(operatorID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sa_roulette101001_configEO.MapDataReader);
		}
		public async Task<Sa_roulette101001_configEO> GetByPKAsync(string operatorID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(operatorID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sa_roulette101001_configEO.MapDataReader);
		}
		private void RepairGetByPKData(string operatorID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 CountryId（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCountryIdByPK(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CountryId`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<string> GetCountryIdByPKAsync(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CountryId`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CurrencyID（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCurrencyIDByPK(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CurrencyID`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<string> GetCurrencyIDByPKAsync(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CurrencyID`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 PayCondition（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetPayConditionByPK(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`PayCondition`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<long> GetPayConditionByPKAsync(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`PayCondition`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 PaySendNum（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetPaySendNumByPK(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`PaySendNum`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<int> GetPaySendNumByPKAsync(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`PaySendNum`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 DaySendNumLimit（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetDaySendNumLimitByPK(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`DaySendNumLimit`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<int> GetDaySendNumLimitByPKAsync(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`DaySendNumLimit`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByCountryId
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_configEO> GetByCountryId(string countryId)
		{
			return GetByCountryId(countryId, 0, string.Empty, null);
		}
		public async Task<List<Sa_roulette101001_configEO>> GetByCountryIdAsync(string countryId)
		{
			return await GetByCountryIdAsync(countryId, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_configEO> GetByCountryId(string countryId, TransactionManager tm_)
		{
			return GetByCountryId(countryId, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette101001_configEO>> GetByCountryIdAsync(string countryId, TransactionManager tm_)
		{
			return await GetByCountryIdAsync(countryId, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_configEO> GetByCountryId(string countryId, int top_)
		{
			return GetByCountryId(countryId, top_, string.Empty, null);
		}
		public async Task<List<Sa_roulette101001_configEO>> GetByCountryIdAsync(string countryId, int top_)
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
		public List<Sa_roulette101001_configEO> GetByCountryId(string countryId, int top_, TransactionManager tm_)
		{
			return GetByCountryId(countryId, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette101001_configEO>> GetByCountryIdAsync(string countryId, int top_, TransactionManager tm_)
		{
			return await GetByCountryIdAsync(countryId, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_configEO> GetByCountryId(string countryId, string sort_)
		{
			return GetByCountryId(countryId, 0, sort_, null);
		}
		public async Task<List<Sa_roulette101001_configEO>> GetByCountryIdAsync(string countryId, string sort_)
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
		public List<Sa_roulette101001_configEO> GetByCountryId(string countryId, string sort_, TransactionManager tm_)
		{
			return GetByCountryId(countryId, 0, sort_, tm_);
		}
		public async Task<List<Sa_roulette101001_configEO>> GetByCountryIdAsync(string countryId, string sort_, TransactionManager tm_)
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
		public List<Sa_roulette101001_configEO> GetByCountryId(string countryId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CountryId` = @CountryId", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_roulette101001_configEO.MapDataReader);
		}
		public async Task<List<Sa_roulette101001_configEO>> GetByCountryIdAsync(string countryId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CountryId` = @CountryId", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_roulette101001_configEO.MapDataReader);
		}
		#endregion // GetByCountryId
		#region GetByCurrencyID
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_configEO> GetByCurrencyID(string currencyID)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, null);
		}
		public async Task<List<Sa_roulette101001_configEO>> GetByCurrencyIDAsync(string currencyID)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_configEO> GetByCurrencyID(string currencyID, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette101001_configEO>> GetByCurrencyIDAsync(string currencyID, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_configEO> GetByCurrencyID(string currencyID, int top_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, null);
		}
		public async Task<List<Sa_roulette101001_configEO>> GetByCurrencyIDAsync(string currencyID, int top_)
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
		public List<Sa_roulette101001_configEO> GetByCurrencyID(string currencyID, int top_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette101001_configEO>> GetByCurrencyIDAsync(string currencyID, int top_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_configEO> GetByCurrencyID(string currencyID, string sort_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, null);
		}
		public async Task<List<Sa_roulette101001_configEO>> GetByCurrencyIDAsync(string currencyID, string sort_)
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
		public List<Sa_roulette101001_configEO> GetByCurrencyID(string currencyID, string sort_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, tm_);
		}
		public async Task<List<Sa_roulette101001_configEO>> GetByCurrencyIDAsync(string currencyID, string sort_, TransactionManager tm_)
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
		public List<Sa_roulette101001_configEO> GetByCurrencyID(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_roulette101001_configEO.MapDataReader);
		}
		public async Task<List<Sa_roulette101001_configEO>> GetByCurrencyIDAsync(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_roulette101001_configEO.MapDataReader);
		}
		#endregion // GetByCurrencyID
		#region GetByPayCondition
		
		/// <summary>
		/// 按 PayCondition（字段） 查询
		/// </summary>
		/// /// <param name = "payCondition">充值条件</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_configEO> GetByPayCondition(long payCondition)
		{
			return GetByPayCondition(payCondition, 0, string.Empty, null);
		}
		public async Task<List<Sa_roulette101001_configEO>> GetByPayConditionAsync(long payCondition)
		{
			return await GetByPayConditionAsync(payCondition, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayCondition（字段） 查询
		/// </summary>
		/// /// <param name = "payCondition">充值条件</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_configEO> GetByPayCondition(long payCondition, TransactionManager tm_)
		{
			return GetByPayCondition(payCondition, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette101001_configEO>> GetByPayConditionAsync(long payCondition, TransactionManager tm_)
		{
			return await GetByPayConditionAsync(payCondition, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayCondition（字段） 查询
		/// </summary>
		/// /// <param name = "payCondition">充值条件</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_configEO> GetByPayCondition(long payCondition, int top_)
		{
			return GetByPayCondition(payCondition, top_, string.Empty, null);
		}
		public async Task<List<Sa_roulette101001_configEO>> GetByPayConditionAsync(long payCondition, int top_)
		{
			return await GetByPayConditionAsync(payCondition, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayCondition（字段） 查询
		/// </summary>
		/// /// <param name = "payCondition">充值条件</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_configEO> GetByPayCondition(long payCondition, int top_, TransactionManager tm_)
		{
			return GetByPayCondition(payCondition, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette101001_configEO>> GetByPayConditionAsync(long payCondition, int top_, TransactionManager tm_)
		{
			return await GetByPayConditionAsync(payCondition, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayCondition（字段） 查询
		/// </summary>
		/// /// <param name = "payCondition">充值条件</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_configEO> GetByPayCondition(long payCondition, string sort_)
		{
			return GetByPayCondition(payCondition, 0, sort_, null);
		}
		public async Task<List<Sa_roulette101001_configEO>> GetByPayConditionAsync(long payCondition, string sort_)
		{
			return await GetByPayConditionAsync(payCondition, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PayCondition（字段） 查询
		/// </summary>
		/// /// <param name = "payCondition">充值条件</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_configEO> GetByPayCondition(long payCondition, string sort_, TransactionManager tm_)
		{
			return GetByPayCondition(payCondition, 0, sort_, tm_);
		}
		public async Task<List<Sa_roulette101001_configEO>> GetByPayConditionAsync(long payCondition, string sort_, TransactionManager tm_)
		{
			return await GetByPayConditionAsync(payCondition, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PayCondition（字段） 查询
		/// </summary>
		/// /// <param name = "payCondition">充值条件</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_configEO> GetByPayCondition(long payCondition, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PayCondition` = @PayCondition", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PayCondition", payCondition, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_roulette101001_configEO.MapDataReader);
		}
		public async Task<List<Sa_roulette101001_configEO>> GetByPayConditionAsync(long payCondition, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PayCondition` = @PayCondition", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PayCondition", payCondition, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_roulette101001_configEO.MapDataReader);
		}
		#endregion // GetByPayCondition
		#region GetByPaySendNum
		
		/// <summary>
		/// 按 PaySendNum（字段） 查询
		/// </summary>
		/// /// <param name = "paySendNum">满足充值条件赠送的充值次数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_configEO> GetByPaySendNum(int paySendNum)
		{
			return GetByPaySendNum(paySendNum, 0, string.Empty, null);
		}
		public async Task<List<Sa_roulette101001_configEO>> GetByPaySendNumAsync(int paySendNum)
		{
			return await GetByPaySendNumAsync(paySendNum, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PaySendNum（字段） 查询
		/// </summary>
		/// /// <param name = "paySendNum">满足充值条件赠送的充值次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_configEO> GetByPaySendNum(int paySendNum, TransactionManager tm_)
		{
			return GetByPaySendNum(paySendNum, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette101001_configEO>> GetByPaySendNumAsync(int paySendNum, TransactionManager tm_)
		{
			return await GetByPaySendNumAsync(paySendNum, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PaySendNum（字段） 查询
		/// </summary>
		/// /// <param name = "paySendNum">满足充值条件赠送的充值次数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_configEO> GetByPaySendNum(int paySendNum, int top_)
		{
			return GetByPaySendNum(paySendNum, top_, string.Empty, null);
		}
		public async Task<List<Sa_roulette101001_configEO>> GetByPaySendNumAsync(int paySendNum, int top_)
		{
			return await GetByPaySendNumAsync(paySendNum, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PaySendNum（字段） 查询
		/// </summary>
		/// /// <param name = "paySendNum">满足充值条件赠送的充值次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_configEO> GetByPaySendNum(int paySendNum, int top_, TransactionManager tm_)
		{
			return GetByPaySendNum(paySendNum, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette101001_configEO>> GetByPaySendNumAsync(int paySendNum, int top_, TransactionManager tm_)
		{
			return await GetByPaySendNumAsync(paySendNum, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PaySendNum（字段） 查询
		/// </summary>
		/// /// <param name = "paySendNum">满足充值条件赠送的充值次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_configEO> GetByPaySendNum(int paySendNum, string sort_)
		{
			return GetByPaySendNum(paySendNum, 0, sort_, null);
		}
		public async Task<List<Sa_roulette101001_configEO>> GetByPaySendNumAsync(int paySendNum, string sort_)
		{
			return await GetByPaySendNumAsync(paySendNum, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PaySendNum（字段） 查询
		/// </summary>
		/// /// <param name = "paySendNum">满足充值条件赠送的充值次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_configEO> GetByPaySendNum(int paySendNum, string sort_, TransactionManager tm_)
		{
			return GetByPaySendNum(paySendNum, 0, sort_, tm_);
		}
		public async Task<List<Sa_roulette101001_configEO>> GetByPaySendNumAsync(int paySendNum, string sort_, TransactionManager tm_)
		{
			return await GetByPaySendNumAsync(paySendNum, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PaySendNum（字段） 查询
		/// </summary>
		/// /// <param name = "paySendNum">满足充值条件赠送的充值次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_configEO> GetByPaySendNum(int paySendNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PaySendNum` = @PaySendNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PaySendNum", paySendNum, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_roulette101001_configEO.MapDataReader);
		}
		public async Task<List<Sa_roulette101001_configEO>> GetByPaySendNumAsync(int paySendNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PaySendNum` = @PaySendNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PaySendNum", paySendNum, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_roulette101001_configEO.MapDataReader);
		}
		#endregion // GetByPaySendNum
		#region GetByDaySendNumLimit
		
		/// <summary>
		/// 按 DaySendNumLimit（字段） 查询
		/// </summary>
		/// /// <param name = "daySendNumLimit">每日赠送次数上限</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_configEO> GetByDaySendNumLimit(int daySendNumLimit)
		{
			return GetByDaySendNumLimit(daySendNumLimit, 0, string.Empty, null);
		}
		public async Task<List<Sa_roulette101001_configEO>> GetByDaySendNumLimitAsync(int daySendNumLimit)
		{
			return await GetByDaySendNumLimitAsync(daySendNumLimit, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DaySendNumLimit（字段） 查询
		/// </summary>
		/// /// <param name = "daySendNumLimit">每日赠送次数上限</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_configEO> GetByDaySendNumLimit(int daySendNumLimit, TransactionManager tm_)
		{
			return GetByDaySendNumLimit(daySendNumLimit, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette101001_configEO>> GetByDaySendNumLimitAsync(int daySendNumLimit, TransactionManager tm_)
		{
			return await GetByDaySendNumLimitAsync(daySendNumLimit, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DaySendNumLimit（字段） 查询
		/// </summary>
		/// /// <param name = "daySendNumLimit">每日赠送次数上限</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_configEO> GetByDaySendNumLimit(int daySendNumLimit, int top_)
		{
			return GetByDaySendNumLimit(daySendNumLimit, top_, string.Empty, null);
		}
		public async Task<List<Sa_roulette101001_configEO>> GetByDaySendNumLimitAsync(int daySendNumLimit, int top_)
		{
			return await GetByDaySendNumLimitAsync(daySendNumLimit, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DaySendNumLimit（字段） 查询
		/// </summary>
		/// /// <param name = "daySendNumLimit">每日赠送次数上限</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_configEO> GetByDaySendNumLimit(int daySendNumLimit, int top_, TransactionManager tm_)
		{
			return GetByDaySendNumLimit(daySendNumLimit, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette101001_configEO>> GetByDaySendNumLimitAsync(int daySendNumLimit, int top_, TransactionManager tm_)
		{
			return await GetByDaySendNumLimitAsync(daySendNumLimit, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DaySendNumLimit（字段） 查询
		/// </summary>
		/// /// <param name = "daySendNumLimit">每日赠送次数上限</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_configEO> GetByDaySendNumLimit(int daySendNumLimit, string sort_)
		{
			return GetByDaySendNumLimit(daySendNumLimit, 0, sort_, null);
		}
		public async Task<List<Sa_roulette101001_configEO>> GetByDaySendNumLimitAsync(int daySendNumLimit, string sort_)
		{
			return await GetByDaySendNumLimitAsync(daySendNumLimit, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DaySendNumLimit（字段） 查询
		/// </summary>
		/// /// <param name = "daySendNumLimit">每日赠送次数上限</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_configEO> GetByDaySendNumLimit(int daySendNumLimit, string sort_, TransactionManager tm_)
		{
			return GetByDaySendNumLimit(daySendNumLimit, 0, sort_, tm_);
		}
		public async Task<List<Sa_roulette101001_configEO>> GetByDaySendNumLimitAsync(int daySendNumLimit, string sort_, TransactionManager tm_)
		{
			return await GetByDaySendNumLimitAsync(daySendNumLimit, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DaySendNumLimit（字段） 查询
		/// </summary>
		/// /// <param name = "daySendNumLimit">每日赠送次数上限</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_configEO> GetByDaySendNumLimit(int daySendNumLimit, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DaySendNumLimit` = @DaySendNumLimit", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DaySendNumLimit", daySendNumLimit, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_roulette101001_configEO.MapDataReader);
		}
		public async Task<List<Sa_roulette101001_configEO>> GetByDaySendNumLimitAsync(int daySendNumLimit, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DaySendNumLimit` = @DaySendNumLimit", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DaySendNumLimit", daySendNumLimit, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_roulette101001_configEO.MapDataReader);
		}
		#endregion // GetByDaySendNumLimit
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
