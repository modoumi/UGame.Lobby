/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * AiUo代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/AiUo
 * 文档生成时间：2023-10-24 18: 05:03
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
	/// 签到周期奖励表
	/// 【表 sa_signin100012_odds 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Sa_signin100012_oddsEO : IRowMapper<Sa_signin100012_oddsEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Sa_signin100012_oddsEO()
		{
			this.Reward = 0;
			this.Odds = 0;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private int _originalConfigID;
		/// <summary>
		/// 【数据库中的原始主键 ConfigID 值的副本，用于主键值更新】
		/// </summary>
		public int OriginalConfigID
		{
			get { return _originalConfigID; }
			set { HasOriginal = true; _originalConfigID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "ConfigID", ConfigID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 自增主键
		/// 【主键 int】
		/// </summary>
		[DataMember(Order = 1)]
		public int ConfigID { get; set; }
		/// <summary>
		/// 运营商编码
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 2)]
		public string OperatorID { get; set; }
		/// <summary>
		/// 货币类型
		/// 【字段 varchar(5)】
		/// </summary>
		[DataMember(Order = 3)]
		public string CurrencyID { get; set; }
		/// <summary>
		/// 国家编码ISO 3166-1三位字母
		/// 【字段 varchar(5)】
		/// </summary>
		[DataMember(Order = 4)]
		public string CountryId { get; set; }
		/// <summary>
		/// 奖励
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 5)]
		public long Reward { get; set; }
		/// <summary>
		/// 中奖概率
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 6)]
		public int Odds { get; set; }
		/// <summary>
		/// 日期编号
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 7)]
		public int DateNumber { get; set; }
		/// <summary>
		/// 是否为第一天
		/// 【字段 tinyint(1)】
		/// </summary>
		[DataMember(Order = 8)]
		public bool IsStartDay { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Sa_signin100012_oddsEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Sa_signin100012_oddsEO MapDataReader(IDataReader reader)
		{
		    Sa_signin100012_oddsEO ret = new Sa_signin100012_oddsEO();
			ret.ConfigID = reader.ToInt32("ConfigID");
			ret.OriginalConfigID = ret.ConfigID;
			ret.OperatorID = reader.ToString("OperatorID");
			ret.CurrencyID = reader.ToString("CurrencyID");
			ret.CountryId = reader.ToString("CountryId");
			ret.Reward = reader.ToInt64("Reward");
			ret.Odds = reader.ToInt32("Odds");
			ret.DateNumber = reader.ToInt32("DateNumber");
			ret.IsStartDay = reader.ToBoolean("IsStartDay");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 签到周期奖励表
	/// 【表 sa_signin100012_odds 的操作类】
	/// </summary>
	[Obsolete]
	public class Sa_signin100012_oddsMO : MySqlTableMO<Sa_signin100012_oddsEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`sa_signin100012_odds`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Sa_signin100012_oddsMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Sa_signin100012_oddsMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Sa_signin100012_oddsMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Sa_signin100012_oddsEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			item.ConfigID = Database.ExecSqlScalar<int>(sql_, paras_, tm_); 
			return 1;
		}
		public override async Task<int> AddAsync(Sa_signin100012_oddsEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			item.ConfigID = await Database.ExecSqlScalarAsync<int>(sql_, paras_, tm_); 
	        return 1;
		}
	    private void RepairAddData(Sa_signin100012_oddsEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`OperatorID`, `CurrencyID`, `CountryId`, `Reward`, `Odds`, `DateNumber`, `IsStartDay`) VALUE (@OperatorID, @CurrencyID, @CountryId, @Reward, @Odds, @DateNumber, @IsStartDay);SELECT LAST_INSERT_ID();";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryId", item.CountryId, MySqlDbType.VarChar),
				Database.CreateInParameter("@Reward", item.Reward, MySqlDbType.Int64),
				Database.CreateInParameter("@Odds", item.Odds, MySqlDbType.Int32),
				Database.CreateInParameter("@DateNumber", item.DateNumber, MySqlDbType.Int32),
				Database.CreateInParameter("@IsStartDay", item.IsStartDay, MySqlDbType.Byte),
			};
		}
		public int AddByBatch(IEnumerable<Sa_signin100012_oddsEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Sa_signin100012_oddsEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sa_signin100012_oddsEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`ConfigID`, `OperatorID`, `CurrencyID`, `CountryId`, `Reward`, `Odds`, `DateNumber`, `IsStartDay`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"({item.ConfigID},'{item.OperatorID}','{item.CurrencyID}','{item.CountryId}',{item.Reward},{item.Odds},{item.DateNumber},{item.IsStartDay}),");
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
		/// /// <param name = "configID">自增主键</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(int configID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(configID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(int configID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(configID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(int configID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `ConfigID` = @ConfigID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.Int32),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Sa_signin100012_oddsEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.ConfigID, tm_);
		}
		public async Task<int> RemoveAsync(Sa_signin100012_oddsEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.ConfigID, tm_);
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
		#region RemoveByReward
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "reward">奖励</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByReward(long reward, TransactionManager tm_ = null)
		{
			RepairRemoveByRewardData(reward, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByRewardAsync(long reward, TransactionManager tm_ = null)
		{
			RepairRemoveByRewardData(reward, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByRewardData(long reward, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Reward` = @Reward";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Reward", reward, MySqlDbType.Int64));
		}
		#endregion // RemoveByReward
		#region RemoveByOdds
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "odds">中奖概率</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByOdds(int odds, TransactionManager tm_ = null)
		{
			RepairRemoveByOddsData(odds, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByOddsAsync(int odds, TransactionManager tm_ = null)
		{
			RepairRemoveByOddsData(odds, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByOddsData(int odds, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Odds` = @Odds";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Odds", odds, MySqlDbType.Int32));
		}
		#endregion // RemoveByOdds
		#region RemoveByDateNumber
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "dateNumber">日期编号</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByDateNumber(int dateNumber, TransactionManager tm_ = null)
		{
			RepairRemoveByDateNumberData(dateNumber, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByDateNumberAsync(int dateNumber, TransactionManager tm_ = null)
		{
			RepairRemoveByDateNumberData(dateNumber, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByDateNumberData(int dateNumber, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `DateNumber` = @DateNumber";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DateNumber", dateNumber, MySqlDbType.Int32));
		}
		#endregion // RemoveByDateNumber
		#region RemoveByIsStartDay
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "isStartDay">是否为第一天</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByIsStartDay(bool isStartDay, TransactionManager tm_ = null)
		{
			RepairRemoveByIsStartDayData(isStartDay, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByIsStartDayAsync(bool isStartDay, TransactionManager tm_ = null)
		{
			RepairRemoveByIsStartDayData(isStartDay, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByIsStartDayData(bool isStartDay, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `IsStartDay` = @IsStartDay";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsStartDay", isStartDay, MySqlDbType.Byte));
		}
		#endregion // RemoveByIsStartDay
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
		public int Put(Sa_signin100012_oddsEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Sa_signin100012_oddsEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Sa_signin100012_oddsEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID, `CurrencyID` = @CurrencyID, `CountryId` = @CountryId, `Reward` = @Reward, `Odds` = @Odds, `DateNumber` = @DateNumber, `IsStartDay` = @IsStartDay WHERE `ConfigID` = @ConfigID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryId", item.CountryId, MySqlDbType.VarChar),
				Database.CreateInParameter("@Reward", item.Reward, MySqlDbType.Int64),
				Database.CreateInParameter("@Odds", item.Odds, MySqlDbType.Int32),
				Database.CreateInParameter("@DateNumber", item.DateNumber, MySqlDbType.Int32),
				Database.CreateInParameter("@IsStartDay", item.IsStartDay, MySqlDbType.Byte),
				Database.CreateInParameter("@ConfigID_Original", item.HasOriginal ? item.OriginalConfigID : item.ConfigID, MySqlDbType.Int32),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Sa_signin100012_oddsEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Sa_signin100012_oddsEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "configID">自增主键</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int configID, string set_, params object[] values_)
		{
			return Put(set_, "`ConfigID` = @ConfigID", ConcatValues(values_, configID));
		}
		public async Task<int> PutByPKAsync(int configID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`ConfigID` = @ConfigID", ConcatValues(values_, configID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "configID">自增主键</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int configID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`ConfigID` = @ConfigID", tm_, ConcatValues(values_, configID));
		}
		public async Task<int> PutByPKAsync(int configID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`ConfigID` = @ConfigID", tm_, ConcatValues(values_, configID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "configID">自增主键</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int configID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.Int32),
	        };
			return Put(set_, "`ConfigID` = @ConfigID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(int configID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.Int32),
	        };
			return await PutAsync(set_, "`ConfigID` = @ConfigID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutOperatorID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "configID">自增主键</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorIDByPK(int configID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(configID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOperatorIDByPKAsync(int configID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(configID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOperatorIDByPKData(int configID, string operatorID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID  WHERE `ConfigID` = @ConfigID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.Int32),
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
		#region PutCurrencyID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "configID">自增主键</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCurrencyIDByPK(int configID, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(configID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCurrencyIDByPKAsync(int configID, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(configID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCurrencyIDByPKData(int configID, string currencyID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CurrencyID` = @CurrencyID  WHERE `ConfigID` = @ConfigID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.Int32),
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
		#region PutCountryId
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "configID">自增主键</param>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCountryIdByPK(int configID, string countryId, TransactionManager tm_ = null)
		{
			RepairPutCountryIdByPKData(configID, countryId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCountryIdByPKAsync(int configID, string countryId, TransactionManager tm_ = null)
		{
			RepairPutCountryIdByPKData(configID, countryId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCountryIdByPKData(int configID, string countryId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CountryId` = @CountryId  WHERE `ConfigID` = @ConfigID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar),
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.Int32),
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
		#region PutReward
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "configID">自增主键</param>
		/// /// <param name = "reward">奖励</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRewardByPK(int configID, long reward, TransactionManager tm_ = null)
		{
			RepairPutRewardByPKData(configID, reward, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRewardByPKAsync(int configID, long reward, TransactionManager tm_ = null)
		{
			RepairPutRewardByPKData(configID, reward, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRewardByPKData(int configID, long reward, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Reward` = @Reward  WHERE `ConfigID` = @ConfigID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Reward", reward, MySqlDbType.Int64),
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "reward">奖励</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutReward(long reward, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Reward` = @Reward";
			var parameter_ = Database.CreateInParameter("@Reward", reward, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutRewardAsync(long reward, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Reward` = @Reward";
			var parameter_ = Database.CreateInParameter("@Reward", reward, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutReward
		#region PutOdds
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "configID">自增主键</param>
		/// /// <param name = "odds">中奖概率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOddsByPK(int configID, int odds, TransactionManager tm_ = null)
		{
			RepairPutOddsByPKData(configID, odds, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOddsByPKAsync(int configID, int odds, TransactionManager tm_ = null)
		{
			RepairPutOddsByPKData(configID, odds, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOddsByPKData(int configID, int odds, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Odds` = @Odds  WHERE `ConfigID` = @ConfigID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Odds", odds, MySqlDbType.Int32),
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "odds">中奖概率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOdds(int odds, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Odds` = @Odds";
			var parameter_ = Database.CreateInParameter("@Odds", odds, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutOddsAsync(int odds, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Odds` = @Odds";
			var parameter_ = Database.CreateInParameter("@Odds", odds, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutOdds
		#region PutDateNumber
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "configID">自增主键</param>
		/// /// <param name = "dateNumber">日期编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutDateNumberByPK(int configID, int dateNumber, TransactionManager tm_ = null)
		{
			RepairPutDateNumberByPKData(configID, dateNumber, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutDateNumberByPKAsync(int configID, int dateNumber, TransactionManager tm_ = null)
		{
			RepairPutDateNumberByPKData(configID, dateNumber, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutDateNumberByPKData(int configID, int dateNumber, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `DateNumber` = @DateNumber  WHERE `ConfigID` = @ConfigID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DateNumber", dateNumber, MySqlDbType.Int32),
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "dateNumber">日期编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutDateNumber(int dateNumber, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `DateNumber` = @DateNumber";
			var parameter_ = Database.CreateInParameter("@DateNumber", dateNumber, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutDateNumberAsync(int dateNumber, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `DateNumber` = @DateNumber";
			var parameter_ = Database.CreateInParameter("@DateNumber", dateNumber, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutDateNumber
		#region PutIsStartDay
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "configID">自增主键</param>
		/// /// <param name = "isStartDay">是否为第一天</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsStartDayByPK(int configID, bool isStartDay, TransactionManager tm_ = null)
		{
			RepairPutIsStartDayByPKData(configID, isStartDay, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutIsStartDayByPKAsync(int configID, bool isStartDay, TransactionManager tm_ = null)
		{
			RepairPutIsStartDayByPKData(configID, isStartDay, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutIsStartDayByPKData(int configID, bool isStartDay, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `IsStartDay` = @IsStartDay  WHERE `ConfigID` = @ConfigID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@IsStartDay", isStartDay, MySqlDbType.Byte),
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "isStartDay">是否为第一天</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsStartDay(bool isStartDay, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsStartDay` = @IsStartDay";
			var parameter_ = Database.CreateInParameter("@IsStartDay", isStartDay, MySqlDbType.Byte);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutIsStartDayAsync(bool isStartDay, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsStartDay` = @IsStartDay";
			var parameter_ = Database.CreateInParameter("@IsStartDay", isStartDay, MySqlDbType.Byte);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutIsStartDay
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Sa_signin100012_oddsEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.ConfigID) == null)
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
		public async Task<bool> SetAsync(Sa_signin100012_oddsEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.ConfigID) == null)
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
		/// /// <param name = "configID">自增主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Sa_signin100012_oddsEO GetByPK(int configID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(configID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sa_signin100012_oddsEO.MapDataReader);
		}
		public async Task<Sa_signin100012_oddsEO> GetByPKAsync(int configID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(configID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sa_signin100012_oddsEO.MapDataReader);
		}
		private void RepairGetByPKData(int configID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`ConfigID` = @ConfigID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.Int32),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 OperatorID（字段）
		/// </summary>
		/// /// <param name = "configID">自增主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorIDByPK(int configID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.Int32),
			};
			return (string)GetScalar("`OperatorID`", "`ConfigID` = @ConfigID", paras_, tm_);
		}
		public async Task<string> GetOperatorIDByPKAsync(int configID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.Int32),
			};
			return (string)await GetScalarAsync("`OperatorID`", "`ConfigID` = @ConfigID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CurrencyID（字段）
		/// </summary>
		/// /// <param name = "configID">自增主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCurrencyIDByPK(int configID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.Int32),
			};
			return (string)GetScalar("`CurrencyID`", "`ConfigID` = @ConfigID", paras_, tm_);
		}
		public async Task<string> GetCurrencyIDByPKAsync(int configID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.Int32),
			};
			return (string)await GetScalarAsync("`CurrencyID`", "`ConfigID` = @ConfigID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CountryId（字段）
		/// </summary>
		/// /// <param name = "configID">自增主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCountryIdByPK(int configID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.Int32),
			};
			return (string)GetScalar("`CountryId`", "`ConfigID` = @ConfigID", paras_, tm_);
		}
		public async Task<string> GetCountryIdByPKAsync(int configID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.Int32),
			};
			return (string)await GetScalarAsync("`CountryId`", "`ConfigID` = @ConfigID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Reward（字段）
		/// </summary>
		/// /// <param name = "configID">自增主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetRewardByPK(int configID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.Int32),
			};
			return (long)GetScalar("`Reward`", "`ConfigID` = @ConfigID", paras_, tm_);
		}
		public async Task<long> GetRewardByPKAsync(int configID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.Int32),
			};
			return (long)await GetScalarAsync("`Reward`", "`ConfigID` = @ConfigID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Odds（字段）
		/// </summary>
		/// /// <param name = "configID">自增主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetOddsByPK(int configID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.Int32),
			};
			return (int)GetScalar("`Odds`", "`ConfigID` = @ConfigID", paras_, tm_);
		}
		public async Task<int> GetOddsByPKAsync(int configID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`Odds`", "`ConfigID` = @ConfigID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 DateNumber（字段）
		/// </summary>
		/// /// <param name = "configID">自增主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetDateNumberByPK(int configID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.Int32),
			};
			return (int)GetScalar("`DateNumber`", "`ConfigID` = @ConfigID", paras_, tm_);
		}
		public async Task<int> GetDateNumberByPKAsync(int configID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`DateNumber`", "`ConfigID` = @ConfigID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 IsStartDay（字段）
		/// </summary>
		/// /// <param name = "configID">自增主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public bool GetIsStartDayByPK(int configID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.Int32),
			};
			return (bool)GetScalar("`IsStartDay`", "`ConfigID` = @ConfigID", paras_, tm_);
		}
		public async Task<bool> GetIsStartDayByPKAsync(int configID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.Int32),
			};
			return (bool)await GetScalarAsync("`IsStartDay`", "`ConfigID` = @ConfigID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_oddsEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<Sa_signin100012_oddsEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_oddsEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_signin100012_oddsEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_oddsEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<Sa_signin100012_oddsEO>> GetByOperatorIDAsync(string operatorID, int top_)
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
		public List<Sa_signin100012_oddsEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_signin100012_oddsEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_oddsEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<Sa_signin100012_oddsEO>> GetByOperatorIDAsync(string operatorID, string sort_)
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
		public List<Sa_signin100012_oddsEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<Sa_signin100012_oddsEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
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
		public List<Sa_signin100012_oddsEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_signin100012_oddsEO.MapDataReader);
		}
		public async Task<List<Sa_signin100012_oddsEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_signin100012_oddsEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByCurrencyID
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_oddsEO> GetByCurrencyID(string currencyID)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, null);
		}
		public async Task<List<Sa_signin100012_oddsEO>> GetByCurrencyIDAsync(string currencyID)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_oddsEO> GetByCurrencyID(string currencyID, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_signin100012_oddsEO>> GetByCurrencyIDAsync(string currencyID, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_oddsEO> GetByCurrencyID(string currencyID, int top_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, null);
		}
		public async Task<List<Sa_signin100012_oddsEO>> GetByCurrencyIDAsync(string currencyID, int top_)
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
		public List<Sa_signin100012_oddsEO> GetByCurrencyID(string currencyID, int top_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_signin100012_oddsEO>> GetByCurrencyIDAsync(string currencyID, int top_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_oddsEO> GetByCurrencyID(string currencyID, string sort_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, null);
		}
		public async Task<List<Sa_signin100012_oddsEO>> GetByCurrencyIDAsync(string currencyID, string sort_)
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
		public List<Sa_signin100012_oddsEO> GetByCurrencyID(string currencyID, string sort_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, tm_);
		}
		public async Task<List<Sa_signin100012_oddsEO>> GetByCurrencyIDAsync(string currencyID, string sort_, TransactionManager tm_)
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
		public List<Sa_signin100012_oddsEO> GetByCurrencyID(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_signin100012_oddsEO.MapDataReader);
		}
		public async Task<List<Sa_signin100012_oddsEO>> GetByCurrencyIDAsync(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_signin100012_oddsEO.MapDataReader);
		}
		#endregion // GetByCurrencyID
		#region GetByCountryId
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_oddsEO> GetByCountryId(string countryId)
		{
			return GetByCountryId(countryId, 0, string.Empty, null);
		}
		public async Task<List<Sa_signin100012_oddsEO>> GetByCountryIdAsync(string countryId)
		{
			return await GetByCountryIdAsync(countryId, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_oddsEO> GetByCountryId(string countryId, TransactionManager tm_)
		{
			return GetByCountryId(countryId, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_signin100012_oddsEO>> GetByCountryIdAsync(string countryId, TransactionManager tm_)
		{
			return await GetByCountryIdAsync(countryId, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_oddsEO> GetByCountryId(string countryId, int top_)
		{
			return GetByCountryId(countryId, top_, string.Empty, null);
		}
		public async Task<List<Sa_signin100012_oddsEO>> GetByCountryIdAsync(string countryId, int top_)
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
		public List<Sa_signin100012_oddsEO> GetByCountryId(string countryId, int top_, TransactionManager tm_)
		{
			return GetByCountryId(countryId, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_signin100012_oddsEO>> GetByCountryIdAsync(string countryId, int top_, TransactionManager tm_)
		{
			return await GetByCountryIdAsync(countryId, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_oddsEO> GetByCountryId(string countryId, string sort_)
		{
			return GetByCountryId(countryId, 0, sort_, null);
		}
		public async Task<List<Sa_signin100012_oddsEO>> GetByCountryIdAsync(string countryId, string sort_)
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
		public List<Sa_signin100012_oddsEO> GetByCountryId(string countryId, string sort_, TransactionManager tm_)
		{
			return GetByCountryId(countryId, 0, sort_, tm_);
		}
		public async Task<List<Sa_signin100012_oddsEO>> GetByCountryIdAsync(string countryId, string sort_, TransactionManager tm_)
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
		public List<Sa_signin100012_oddsEO> GetByCountryId(string countryId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CountryId` = @CountryId", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_signin100012_oddsEO.MapDataReader);
		}
		public async Task<List<Sa_signin100012_oddsEO>> GetByCountryIdAsync(string countryId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CountryId` = @CountryId", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_signin100012_oddsEO.MapDataReader);
		}
		#endregion // GetByCountryId
		#region GetByReward
		
		/// <summary>
		/// 按 Reward（字段） 查询
		/// </summary>
		/// /// <param name = "reward">奖励</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_oddsEO> GetByReward(long reward)
		{
			return GetByReward(reward, 0, string.Empty, null);
		}
		public async Task<List<Sa_signin100012_oddsEO>> GetByRewardAsync(long reward)
		{
			return await GetByRewardAsync(reward, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Reward（字段） 查询
		/// </summary>
		/// /// <param name = "reward">奖励</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_oddsEO> GetByReward(long reward, TransactionManager tm_)
		{
			return GetByReward(reward, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_signin100012_oddsEO>> GetByRewardAsync(long reward, TransactionManager tm_)
		{
			return await GetByRewardAsync(reward, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Reward（字段） 查询
		/// </summary>
		/// /// <param name = "reward">奖励</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_oddsEO> GetByReward(long reward, int top_)
		{
			return GetByReward(reward, top_, string.Empty, null);
		}
		public async Task<List<Sa_signin100012_oddsEO>> GetByRewardAsync(long reward, int top_)
		{
			return await GetByRewardAsync(reward, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Reward（字段） 查询
		/// </summary>
		/// /// <param name = "reward">奖励</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_oddsEO> GetByReward(long reward, int top_, TransactionManager tm_)
		{
			return GetByReward(reward, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_signin100012_oddsEO>> GetByRewardAsync(long reward, int top_, TransactionManager tm_)
		{
			return await GetByRewardAsync(reward, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Reward（字段） 查询
		/// </summary>
		/// /// <param name = "reward">奖励</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_oddsEO> GetByReward(long reward, string sort_)
		{
			return GetByReward(reward, 0, sort_, null);
		}
		public async Task<List<Sa_signin100012_oddsEO>> GetByRewardAsync(long reward, string sort_)
		{
			return await GetByRewardAsync(reward, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Reward（字段） 查询
		/// </summary>
		/// /// <param name = "reward">奖励</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_oddsEO> GetByReward(long reward, string sort_, TransactionManager tm_)
		{
			return GetByReward(reward, 0, sort_, tm_);
		}
		public async Task<List<Sa_signin100012_oddsEO>> GetByRewardAsync(long reward, string sort_, TransactionManager tm_)
		{
			return await GetByRewardAsync(reward, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Reward（字段） 查询
		/// </summary>
		/// /// <param name = "reward">奖励</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_oddsEO> GetByReward(long reward, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Reward` = @Reward", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Reward", reward, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_signin100012_oddsEO.MapDataReader);
		}
		public async Task<List<Sa_signin100012_oddsEO>> GetByRewardAsync(long reward, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Reward` = @Reward", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Reward", reward, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_signin100012_oddsEO.MapDataReader);
		}
		#endregion // GetByReward
		#region GetByOdds
		
		/// <summary>
		/// 按 Odds（字段） 查询
		/// </summary>
		/// /// <param name = "odds">中奖概率</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_oddsEO> GetByOdds(int odds)
		{
			return GetByOdds(odds, 0, string.Empty, null);
		}
		public async Task<List<Sa_signin100012_oddsEO>> GetByOddsAsync(int odds)
		{
			return await GetByOddsAsync(odds, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Odds（字段） 查询
		/// </summary>
		/// /// <param name = "odds">中奖概率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_oddsEO> GetByOdds(int odds, TransactionManager tm_)
		{
			return GetByOdds(odds, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_signin100012_oddsEO>> GetByOddsAsync(int odds, TransactionManager tm_)
		{
			return await GetByOddsAsync(odds, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Odds（字段） 查询
		/// </summary>
		/// /// <param name = "odds">中奖概率</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_oddsEO> GetByOdds(int odds, int top_)
		{
			return GetByOdds(odds, top_, string.Empty, null);
		}
		public async Task<List<Sa_signin100012_oddsEO>> GetByOddsAsync(int odds, int top_)
		{
			return await GetByOddsAsync(odds, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Odds（字段） 查询
		/// </summary>
		/// /// <param name = "odds">中奖概率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_oddsEO> GetByOdds(int odds, int top_, TransactionManager tm_)
		{
			return GetByOdds(odds, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_signin100012_oddsEO>> GetByOddsAsync(int odds, int top_, TransactionManager tm_)
		{
			return await GetByOddsAsync(odds, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Odds（字段） 查询
		/// </summary>
		/// /// <param name = "odds">中奖概率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_oddsEO> GetByOdds(int odds, string sort_)
		{
			return GetByOdds(odds, 0, sort_, null);
		}
		public async Task<List<Sa_signin100012_oddsEO>> GetByOddsAsync(int odds, string sort_)
		{
			return await GetByOddsAsync(odds, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Odds（字段） 查询
		/// </summary>
		/// /// <param name = "odds">中奖概率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_oddsEO> GetByOdds(int odds, string sort_, TransactionManager tm_)
		{
			return GetByOdds(odds, 0, sort_, tm_);
		}
		public async Task<List<Sa_signin100012_oddsEO>> GetByOddsAsync(int odds, string sort_, TransactionManager tm_)
		{
			return await GetByOddsAsync(odds, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Odds（字段） 查询
		/// </summary>
		/// /// <param name = "odds">中奖概率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_oddsEO> GetByOdds(int odds, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Odds` = @Odds", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Odds", odds, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_signin100012_oddsEO.MapDataReader);
		}
		public async Task<List<Sa_signin100012_oddsEO>> GetByOddsAsync(int odds, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Odds` = @Odds", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Odds", odds, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_signin100012_oddsEO.MapDataReader);
		}
		#endregion // GetByOdds
		#region GetByDateNumber
		
		/// <summary>
		/// 按 DateNumber（字段） 查询
		/// </summary>
		/// /// <param name = "dateNumber">日期编号</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_oddsEO> GetByDateNumber(int dateNumber)
		{
			return GetByDateNumber(dateNumber, 0, string.Empty, null);
		}
		public async Task<List<Sa_signin100012_oddsEO>> GetByDateNumberAsync(int dateNumber)
		{
			return await GetByDateNumberAsync(dateNumber, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DateNumber（字段） 查询
		/// </summary>
		/// /// <param name = "dateNumber">日期编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_oddsEO> GetByDateNumber(int dateNumber, TransactionManager tm_)
		{
			return GetByDateNumber(dateNumber, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_signin100012_oddsEO>> GetByDateNumberAsync(int dateNumber, TransactionManager tm_)
		{
			return await GetByDateNumberAsync(dateNumber, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DateNumber（字段） 查询
		/// </summary>
		/// /// <param name = "dateNumber">日期编号</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_oddsEO> GetByDateNumber(int dateNumber, int top_)
		{
			return GetByDateNumber(dateNumber, top_, string.Empty, null);
		}
		public async Task<List<Sa_signin100012_oddsEO>> GetByDateNumberAsync(int dateNumber, int top_)
		{
			return await GetByDateNumberAsync(dateNumber, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DateNumber（字段） 查询
		/// </summary>
		/// /// <param name = "dateNumber">日期编号</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_oddsEO> GetByDateNumber(int dateNumber, int top_, TransactionManager tm_)
		{
			return GetByDateNumber(dateNumber, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_signin100012_oddsEO>> GetByDateNumberAsync(int dateNumber, int top_, TransactionManager tm_)
		{
			return await GetByDateNumberAsync(dateNumber, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DateNumber（字段） 查询
		/// </summary>
		/// /// <param name = "dateNumber">日期编号</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_oddsEO> GetByDateNumber(int dateNumber, string sort_)
		{
			return GetByDateNumber(dateNumber, 0, sort_, null);
		}
		public async Task<List<Sa_signin100012_oddsEO>> GetByDateNumberAsync(int dateNumber, string sort_)
		{
			return await GetByDateNumberAsync(dateNumber, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DateNumber（字段） 查询
		/// </summary>
		/// /// <param name = "dateNumber">日期编号</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_oddsEO> GetByDateNumber(int dateNumber, string sort_, TransactionManager tm_)
		{
			return GetByDateNumber(dateNumber, 0, sort_, tm_);
		}
		public async Task<List<Sa_signin100012_oddsEO>> GetByDateNumberAsync(int dateNumber, string sort_, TransactionManager tm_)
		{
			return await GetByDateNumberAsync(dateNumber, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DateNumber（字段） 查询
		/// </summary>
		/// /// <param name = "dateNumber">日期编号</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_oddsEO> GetByDateNumber(int dateNumber, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DateNumber` = @DateNumber", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DateNumber", dateNumber, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_signin100012_oddsEO.MapDataReader);
		}
		public async Task<List<Sa_signin100012_oddsEO>> GetByDateNumberAsync(int dateNumber, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DateNumber` = @DateNumber", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DateNumber", dateNumber, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_signin100012_oddsEO.MapDataReader);
		}
		#endregion // GetByDateNumber
		#region GetByIsStartDay
		
		/// <summary>
		/// 按 IsStartDay（字段） 查询
		/// </summary>
		/// /// <param name = "isStartDay">是否为第一天</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_oddsEO> GetByIsStartDay(bool isStartDay)
		{
			return GetByIsStartDay(isStartDay, 0, string.Empty, null);
		}
		public async Task<List<Sa_signin100012_oddsEO>> GetByIsStartDayAsync(bool isStartDay)
		{
			return await GetByIsStartDayAsync(isStartDay, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsStartDay（字段） 查询
		/// </summary>
		/// /// <param name = "isStartDay">是否为第一天</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_oddsEO> GetByIsStartDay(bool isStartDay, TransactionManager tm_)
		{
			return GetByIsStartDay(isStartDay, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_signin100012_oddsEO>> GetByIsStartDayAsync(bool isStartDay, TransactionManager tm_)
		{
			return await GetByIsStartDayAsync(isStartDay, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsStartDay（字段） 查询
		/// </summary>
		/// /// <param name = "isStartDay">是否为第一天</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_oddsEO> GetByIsStartDay(bool isStartDay, int top_)
		{
			return GetByIsStartDay(isStartDay, top_, string.Empty, null);
		}
		public async Task<List<Sa_signin100012_oddsEO>> GetByIsStartDayAsync(bool isStartDay, int top_)
		{
			return await GetByIsStartDayAsync(isStartDay, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsStartDay（字段） 查询
		/// </summary>
		/// /// <param name = "isStartDay">是否为第一天</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_oddsEO> GetByIsStartDay(bool isStartDay, int top_, TransactionManager tm_)
		{
			return GetByIsStartDay(isStartDay, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_signin100012_oddsEO>> GetByIsStartDayAsync(bool isStartDay, int top_, TransactionManager tm_)
		{
			return await GetByIsStartDayAsync(isStartDay, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsStartDay（字段） 查询
		/// </summary>
		/// /// <param name = "isStartDay">是否为第一天</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_oddsEO> GetByIsStartDay(bool isStartDay, string sort_)
		{
			return GetByIsStartDay(isStartDay, 0, sort_, null);
		}
		public async Task<List<Sa_signin100012_oddsEO>> GetByIsStartDayAsync(bool isStartDay, string sort_)
		{
			return await GetByIsStartDayAsync(isStartDay, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 IsStartDay（字段） 查询
		/// </summary>
		/// /// <param name = "isStartDay">是否为第一天</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_oddsEO> GetByIsStartDay(bool isStartDay, string sort_, TransactionManager tm_)
		{
			return GetByIsStartDay(isStartDay, 0, sort_, tm_);
		}
		public async Task<List<Sa_signin100012_oddsEO>> GetByIsStartDayAsync(bool isStartDay, string sort_, TransactionManager tm_)
		{
			return await GetByIsStartDayAsync(isStartDay, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 IsStartDay（字段） 查询
		/// </summary>
		/// /// <param name = "isStartDay">是否为第一天</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_oddsEO> GetByIsStartDay(bool isStartDay, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsStartDay` = @IsStartDay", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsStartDay", isStartDay, MySqlDbType.Byte));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_signin100012_oddsEO.MapDataReader);
		}
		public async Task<List<Sa_signin100012_oddsEO>> GetByIsStartDayAsync(bool isStartDay, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsStartDay` = @IsStartDay", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsStartDay", isStartDay, MySqlDbType.Byte));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_signin100012_oddsEO.MapDataReader);
		}
		#endregion // GetByIsStartDay
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
