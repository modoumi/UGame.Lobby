/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * AiUo代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/AiUo
 * 文档生成时间：2023-10-24 18: 04:59
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
	/// 拉新活动，用户当月拉新用户数量配置表
	/// 【表 sa_invitenum100011_config 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Sa_invitenum100011_configEO : IRowMapper<Sa_invitenum100011_configEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Sa_invitenum100011_configEO()
		{
			this.UserNumStart = 0;
			this.UserNumEnd = 0;
			this.Bonus = 0;
			this.PayCondition = 0;
			this.FlowMultip = 0.00f;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private string _originalConfigID;
		/// <summary>
		/// 【数据库中的原始主键 ConfigID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalConfigID
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
		/// 主键guid
		/// 【主键 varchar(36)】
		/// </summary>
		[DataMember(Order = 1)]
		public string ConfigID { get; set; }
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
		/// 【字段 varchar(5)】
		/// </summary>
		[DataMember(Order = 4)]
		public string CurrencyID { get; set; }
		/// <summary>
		/// 邀请用户数量起始值
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 5)]
		public int UserNumStart { get; set; }
		/// <summary>
		/// 邀请用户数量截止值
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 6)]
		public int UserNumEnd { get; set; }
		/// <summary>
		/// 奖励金额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 7)]
		public long Bonus { get; set; }
		/// <summary>
		/// 获取奖励需要满足的累计充值金额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 8)]
		public long PayCondition { get; set; }
		/// <summary>
		/// 提现时候需要完成的下注流水倍数
		/// 【字段 float(10,2)】
		/// </summary>
		[DataMember(Order = 9)]
		public float FlowMultip { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Sa_invitenum100011_configEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Sa_invitenum100011_configEO MapDataReader(IDataReader reader)
		{
		    Sa_invitenum100011_configEO ret = new Sa_invitenum100011_configEO();
			ret.ConfigID = reader.ToString("ConfigID");
			ret.OriginalConfigID = ret.ConfigID;
			ret.OperatorID = reader.ToString("OperatorID");
			ret.CountryId = reader.ToString("CountryId");
			ret.CurrencyID = reader.ToString("CurrencyID");
			ret.UserNumStart = reader.ToInt32("UserNumStart");
			ret.UserNumEnd = reader.ToInt32("UserNumEnd");
			ret.Bonus = reader.ToInt64("Bonus");
			ret.PayCondition = reader.ToInt64("PayCondition");
			ret.FlowMultip = reader.ToSingle("FlowMultip");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 拉新活动，用户当月拉新用户数量配置表
	/// 【表 sa_invitenum100011_config 的操作类】
	/// </summary>
	[Obsolete]
	public class Sa_invitenum100011_configMO : MySqlTableMO<Sa_invitenum100011_configEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`sa_invitenum100011_config`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Sa_invitenum100011_configMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Sa_invitenum100011_configMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Sa_invitenum100011_configMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Sa_invitenum100011_configEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Sa_invitenum100011_configEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Sa_invitenum100011_configEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`ConfigID`, `OperatorID`, `CountryId`, `CurrencyID`, `UserNumStart`, `UserNumEnd`, `Bonus`, `PayCondition`, `FlowMultip`) VALUE (@ConfigID, @OperatorID, @CountryId, @CurrencyID, @UserNumStart, @UserNumEnd, @Bonus, @PayCondition, @FlowMultip);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", item.ConfigID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryId", item.CountryId, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserNumStart", item.UserNumStart, MySqlDbType.Int32),
				Database.CreateInParameter("@UserNumEnd", item.UserNumEnd, MySqlDbType.Int32),
				Database.CreateInParameter("@Bonus", item.Bonus, MySqlDbType.Int64),
				Database.CreateInParameter("@PayCondition", item.PayCondition, MySqlDbType.Int64),
				Database.CreateInParameter("@FlowMultip", item.FlowMultip, MySqlDbType.Float),
			};
		}
		public int AddByBatch(IEnumerable<Sa_invitenum100011_configEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Sa_invitenum100011_configEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sa_invitenum100011_configEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`ConfigID`, `OperatorID`, `CountryId`, `CurrencyID`, `UserNumStart`, `UserNumEnd`, `Bonus`, `PayCondition`, `FlowMultip`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.ConfigID}','{item.OperatorID}','{item.CountryId}','{item.CurrencyID}',{item.UserNumStart},{item.UserNumEnd},{item.Bonus},{item.PayCondition},{item.FlowMultip}),");
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
		/// /// <param name = "configID">主键guid</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string configID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(configID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string configID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(configID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string configID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `ConfigID` = @ConfigID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Sa_invitenum100011_configEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.ConfigID, tm_);
		}
		public async Task<int> RemoveAsync(Sa_invitenum100011_configEO item, TransactionManager tm_ = null)
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
		#region RemoveByUserNumStart
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "userNumStart">邀请用户数量起始值</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByUserNumStart(int userNumStart, TransactionManager tm_ = null)
		{
			RepairRemoveByUserNumStartData(userNumStart, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByUserNumStartAsync(int userNumStart, TransactionManager tm_ = null)
		{
			RepairRemoveByUserNumStartData(userNumStart, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByUserNumStartData(int userNumStart, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `UserNumStart` = @UserNumStart";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserNumStart", userNumStart, MySqlDbType.Int32));
		}
		#endregion // RemoveByUserNumStart
		#region RemoveByUserNumEnd
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "userNumEnd">邀请用户数量截止值</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByUserNumEnd(int userNumEnd, TransactionManager tm_ = null)
		{
			RepairRemoveByUserNumEndData(userNumEnd, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByUserNumEndAsync(int userNumEnd, TransactionManager tm_ = null)
		{
			RepairRemoveByUserNumEndData(userNumEnd, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByUserNumEndData(int userNumEnd, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `UserNumEnd` = @UserNumEnd";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserNumEnd", userNumEnd, MySqlDbType.Int32));
		}
		#endregion // RemoveByUserNumEnd
		#region RemoveByBonus
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "bonus">奖励金额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByBonus(long bonus, TransactionManager tm_ = null)
		{
			RepairRemoveByBonusData(bonus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByBonusAsync(long bonus, TransactionManager tm_ = null)
		{
			RepairRemoveByBonusData(bonus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByBonusData(long bonus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Bonus` = @Bonus";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Bonus", bonus, MySqlDbType.Int64));
		}
		#endregion // RemoveByBonus
		#region RemoveByPayCondition
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "payCondition">获取奖励需要满足的累计充值金额</param>
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
		#region RemoveByFlowMultip
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "flowMultip">提现时候需要完成的下注流水倍数</param>
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
		public int Put(Sa_invitenum100011_configEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Sa_invitenum100011_configEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Sa_invitenum100011_configEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ConfigID` = @ConfigID, `OperatorID` = @OperatorID, `CountryId` = @CountryId, `CurrencyID` = @CurrencyID, `UserNumStart` = @UserNumStart, `UserNumEnd` = @UserNumEnd, `Bonus` = @Bonus, `PayCondition` = @PayCondition, `FlowMultip` = @FlowMultip WHERE `ConfigID` = @ConfigID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", item.ConfigID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryId", item.CountryId, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserNumStart", item.UserNumStart, MySqlDbType.Int32),
				Database.CreateInParameter("@UserNumEnd", item.UserNumEnd, MySqlDbType.Int32),
				Database.CreateInParameter("@Bonus", item.Bonus, MySqlDbType.Int64),
				Database.CreateInParameter("@PayCondition", item.PayCondition, MySqlDbType.Int64),
				Database.CreateInParameter("@FlowMultip", item.FlowMultip, MySqlDbType.Float),
				Database.CreateInParameter("@ConfigID_Original", item.HasOriginal ? item.OriginalConfigID : item.ConfigID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Sa_invitenum100011_configEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Sa_invitenum100011_configEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "configID">主键guid</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string configID, string set_, params object[] values_)
		{
			return Put(set_, "`ConfigID` = @ConfigID", ConcatValues(values_, configID));
		}
		public async Task<int> PutByPKAsync(string configID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`ConfigID` = @ConfigID", ConcatValues(values_, configID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "configID">主键guid</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string configID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`ConfigID` = @ConfigID", tm_, ConcatValues(values_, configID));
		}
		public async Task<int> PutByPKAsync(string configID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`ConfigID` = @ConfigID", tm_, ConcatValues(values_, configID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "configID">主键guid</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string configID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`ConfigID` = @ConfigID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string configID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`ConfigID` = @ConfigID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutOperatorID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "configID">主键guid</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorIDByPK(string configID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(configID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOperatorIDByPKAsync(string configID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(configID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOperatorIDByPKData(string configID, string operatorID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID  WHERE `ConfigID` = @ConfigID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
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
		/// /// <param name = "configID">主键guid</param>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCountryIdByPK(string configID, string countryId, TransactionManager tm_ = null)
		{
			RepairPutCountryIdByPKData(configID, countryId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCountryIdByPKAsync(string configID, string countryId, TransactionManager tm_ = null)
		{
			RepairPutCountryIdByPKData(configID, countryId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCountryIdByPKData(string configID, string countryId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CountryId` = @CountryId  WHERE `ConfigID` = @ConfigID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar),
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
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
		/// /// <param name = "configID">主键guid</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCurrencyIDByPK(string configID, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(configID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCurrencyIDByPKAsync(string configID, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(configID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCurrencyIDByPKData(string configID, string currencyID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CurrencyID` = @CurrencyID  WHERE `ConfigID` = @ConfigID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
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
		#region PutUserNumStart
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "configID">主键guid</param>
		/// /// <param name = "userNumStart">邀请用户数量起始值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserNumStartByPK(string configID, int userNumStart, TransactionManager tm_ = null)
		{
			RepairPutUserNumStartByPKData(configID, userNumStart, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutUserNumStartByPKAsync(string configID, int userNumStart, TransactionManager tm_ = null)
		{
			RepairPutUserNumStartByPKData(configID, userNumStart, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutUserNumStartByPKData(string configID, int userNumStart, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UserNumStart` = @UserNumStart  WHERE `ConfigID` = @ConfigID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserNumStart", userNumStart, MySqlDbType.Int32),
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "userNumStart">邀请用户数量起始值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserNumStart(int userNumStart, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserNumStart` = @UserNumStart";
			var parameter_ = Database.CreateInParameter("@UserNumStart", userNumStart, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutUserNumStartAsync(int userNumStart, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserNumStart` = @UserNumStart";
			var parameter_ = Database.CreateInParameter("@UserNumStart", userNumStart, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutUserNumStart
		#region PutUserNumEnd
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "configID">主键guid</param>
		/// /// <param name = "userNumEnd">邀请用户数量截止值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserNumEndByPK(string configID, int userNumEnd, TransactionManager tm_ = null)
		{
			RepairPutUserNumEndByPKData(configID, userNumEnd, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutUserNumEndByPKAsync(string configID, int userNumEnd, TransactionManager tm_ = null)
		{
			RepairPutUserNumEndByPKData(configID, userNumEnd, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutUserNumEndByPKData(string configID, int userNumEnd, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UserNumEnd` = @UserNumEnd  WHERE `ConfigID` = @ConfigID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserNumEnd", userNumEnd, MySqlDbType.Int32),
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "userNumEnd">邀请用户数量截止值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserNumEnd(int userNumEnd, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserNumEnd` = @UserNumEnd";
			var parameter_ = Database.CreateInParameter("@UserNumEnd", userNumEnd, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutUserNumEndAsync(int userNumEnd, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserNumEnd` = @UserNumEnd";
			var parameter_ = Database.CreateInParameter("@UserNumEnd", userNumEnd, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutUserNumEnd
		#region PutBonus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "configID">主键guid</param>
		/// /// <param name = "bonus">奖励金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBonusByPK(string configID, long bonus, TransactionManager tm_ = null)
		{
			RepairPutBonusByPKData(configID, bonus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBonusByPKAsync(string configID, long bonus, TransactionManager tm_ = null)
		{
			RepairPutBonusByPKData(configID, bonus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBonusByPKData(string configID, long bonus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Bonus` = @Bonus  WHERE `ConfigID` = @ConfigID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Bonus", bonus, MySqlDbType.Int64),
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "bonus">奖励金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBonus(long bonus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Bonus` = @Bonus";
			var parameter_ = Database.CreateInParameter("@Bonus", bonus, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutBonusAsync(long bonus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Bonus` = @Bonus";
			var parameter_ = Database.CreateInParameter("@Bonus", bonus, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutBonus
		#region PutPayCondition
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "configID">主键guid</param>
		/// /// <param name = "payCondition">获取奖励需要满足的累计充值金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPayConditionByPK(string configID, long payCondition, TransactionManager tm_ = null)
		{
			RepairPutPayConditionByPKData(configID, payCondition, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutPayConditionByPKAsync(string configID, long payCondition, TransactionManager tm_ = null)
		{
			RepairPutPayConditionByPKData(configID, payCondition, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutPayConditionByPKData(string configID, long payCondition, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `PayCondition` = @PayCondition  WHERE `ConfigID` = @ConfigID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PayCondition", payCondition, MySqlDbType.Int64),
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "payCondition">获取奖励需要满足的累计充值金额</param>
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
		#region PutFlowMultip
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "configID">主键guid</param>
		/// /// <param name = "flowMultip">提现时候需要完成的下注流水倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFlowMultipByPK(string configID, float flowMultip, TransactionManager tm_ = null)
		{
			RepairPutFlowMultipByPKData(configID, flowMultip, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFlowMultipByPKAsync(string configID, float flowMultip, TransactionManager tm_ = null)
		{
			RepairPutFlowMultipByPKData(configID, flowMultip, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFlowMultipByPKData(string configID, float flowMultip, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `FlowMultip` = @FlowMultip  WHERE `ConfigID` = @ConfigID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@FlowMultip", flowMultip, MySqlDbType.Float),
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "flowMultip">提现时候需要完成的下注流水倍数</param>
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
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Sa_invitenum100011_configEO item, TransactionManager tm = null)
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
		public async Task<bool> SetAsync(Sa_invitenum100011_configEO item, TransactionManager tm = null)
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
		/// /// <param name = "configID">主键guid</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Sa_invitenum100011_configEO GetByPK(string configID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(configID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sa_invitenum100011_configEO.MapDataReader);
		}
		public async Task<Sa_invitenum100011_configEO> GetByPKAsync(string configID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(configID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sa_invitenum100011_configEO.MapDataReader);
		}
		private void RepairGetByPKData(string configID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`ConfigID` = @ConfigID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 OperatorID（字段）
		/// </summary>
		/// /// <param name = "configID">主键guid</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorIDByPK(string configID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OperatorID`", "`ConfigID` = @ConfigID", paras_, tm_);
		}
		public async Task<string> GetOperatorIDByPKAsync(string configID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OperatorID`", "`ConfigID` = @ConfigID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CountryId（字段）
		/// </summary>
		/// /// <param name = "configID">主键guid</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCountryIdByPK(string configID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CountryId`", "`ConfigID` = @ConfigID", paras_, tm_);
		}
		public async Task<string> GetCountryIdByPKAsync(string configID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CountryId`", "`ConfigID` = @ConfigID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CurrencyID（字段）
		/// </summary>
		/// /// <param name = "configID">主键guid</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCurrencyIDByPK(string configID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CurrencyID`", "`ConfigID` = @ConfigID", paras_, tm_);
		}
		public async Task<string> GetCurrencyIDByPKAsync(string configID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CurrencyID`", "`ConfigID` = @ConfigID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 UserNumStart（字段）
		/// </summary>
		/// /// <param name = "configID">主键guid</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetUserNumStartByPK(string configID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`UserNumStart`", "`ConfigID` = @ConfigID", paras_, tm_);
		}
		public async Task<int> GetUserNumStartByPKAsync(string configID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`UserNumStart`", "`ConfigID` = @ConfigID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 UserNumEnd（字段）
		/// </summary>
		/// /// <param name = "configID">主键guid</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetUserNumEndByPK(string configID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`UserNumEnd`", "`ConfigID` = @ConfigID", paras_, tm_);
		}
		public async Task<int> GetUserNumEndByPKAsync(string configID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`UserNumEnd`", "`ConfigID` = @ConfigID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Bonus（字段）
		/// </summary>
		/// /// <param name = "configID">主键guid</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetBonusByPK(string configID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`Bonus`", "`ConfigID` = @ConfigID", paras_, tm_);
		}
		public async Task<long> GetBonusByPKAsync(string configID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`Bonus`", "`ConfigID` = @ConfigID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 PayCondition（字段）
		/// </summary>
		/// /// <param name = "configID">主键guid</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetPayConditionByPK(string configID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`PayCondition`", "`ConfigID` = @ConfigID", paras_, tm_);
		}
		public async Task<long> GetPayConditionByPKAsync(string configID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`PayCondition`", "`ConfigID` = @ConfigID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 FlowMultip（字段）
		/// </summary>
		/// /// <param name = "configID">主键guid</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public float GetFlowMultipByPK(string configID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
			return (float)GetScalar("`FlowMultip`", "`ConfigID` = @ConfigID", paras_, tm_);
		}
		public async Task<float> GetFlowMultipByPKAsync(string configID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
			return (float)await GetScalarAsync("`FlowMultip`", "`ConfigID` = @ConfigID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <return>实体对象集合</return>
		public List<Sa_invitenum100011_configEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<Sa_invitenum100011_configEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invitenum100011_configEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_invitenum100011_configEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_invitenum100011_configEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<Sa_invitenum100011_configEO>> GetByOperatorIDAsync(string operatorID, int top_)
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
		public List<Sa_invitenum100011_configEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_invitenum100011_configEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_invitenum100011_configEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<Sa_invitenum100011_configEO>> GetByOperatorIDAsync(string operatorID, string sort_)
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
		public List<Sa_invitenum100011_configEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<Sa_invitenum100011_configEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
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
		public List<Sa_invitenum100011_configEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_invitenum100011_configEO.MapDataReader);
		}
		public async Task<List<Sa_invitenum100011_configEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_invitenum100011_configEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByCountryId
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <return>实体对象集合</return>
		public List<Sa_invitenum100011_configEO> GetByCountryId(string countryId)
		{
			return GetByCountryId(countryId, 0, string.Empty, null);
		}
		public async Task<List<Sa_invitenum100011_configEO>> GetByCountryIdAsync(string countryId)
		{
			return await GetByCountryIdAsync(countryId, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invitenum100011_configEO> GetByCountryId(string countryId, TransactionManager tm_)
		{
			return GetByCountryId(countryId, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_invitenum100011_configEO>> GetByCountryIdAsync(string countryId, TransactionManager tm_)
		{
			return await GetByCountryIdAsync(countryId, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_invitenum100011_configEO> GetByCountryId(string countryId, int top_)
		{
			return GetByCountryId(countryId, top_, string.Empty, null);
		}
		public async Task<List<Sa_invitenum100011_configEO>> GetByCountryIdAsync(string countryId, int top_)
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
		public List<Sa_invitenum100011_configEO> GetByCountryId(string countryId, int top_, TransactionManager tm_)
		{
			return GetByCountryId(countryId, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_invitenum100011_configEO>> GetByCountryIdAsync(string countryId, int top_, TransactionManager tm_)
		{
			return await GetByCountryIdAsync(countryId, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_invitenum100011_configEO> GetByCountryId(string countryId, string sort_)
		{
			return GetByCountryId(countryId, 0, sort_, null);
		}
		public async Task<List<Sa_invitenum100011_configEO>> GetByCountryIdAsync(string countryId, string sort_)
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
		public List<Sa_invitenum100011_configEO> GetByCountryId(string countryId, string sort_, TransactionManager tm_)
		{
			return GetByCountryId(countryId, 0, sort_, tm_);
		}
		public async Task<List<Sa_invitenum100011_configEO>> GetByCountryIdAsync(string countryId, string sort_, TransactionManager tm_)
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
		public List<Sa_invitenum100011_configEO> GetByCountryId(string countryId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CountryId` = @CountryId", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_invitenum100011_configEO.MapDataReader);
		}
		public async Task<List<Sa_invitenum100011_configEO>> GetByCountryIdAsync(string countryId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CountryId` = @CountryId", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_invitenum100011_configEO.MapDataReader);
		}
		#endregion // GetByCountryId
		#region GetByCurrencyID
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <return>实体对象集合</return>
		public List<Sa_invitenum100011_configEO> GetByCurrencyID(string currencyID)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, null);
		}
		public async Task<List<Sa_invitenum100011_configEO>> GetByCurrencyIDAsync(string currencyID)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invitenum100011_configEO> GetByCurrencyID(string currencyID, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_invitenum100011_configEO>> GetByCurrencyIDAsync(string currencyID, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_invitenum100011_configEO> GetByCurrencyID(string currencyID, int top_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, null);
		}
		public async Task<List<Sa_invitenum100011_configEO>> GetByCurrencyIDAsync(string currencyID, int top_)
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
		public List<Sa_invitenum100011_configEO> GetByCurrencyID(string currencyID, int top_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_invitenum100011_configEO>> GetByCurrencyIDAsync(string currencyID, int top_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_invitenum100011_configEO> GetByCurrencyID(string currencyID, string sort_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, null);
		}
		public async Task<List<Sa_invitenum100011_configEO>> GetByCurrencyIDAsync(string currencyID, string sort_)
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
		public List<Sa_invitenum100011_configEO> GetByCurrencyID(string currencyID, string sort_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, tm_);
		}
		public async Task<List<Sa_invitenum100011_configEO>> GetByCurrencyIDAsync(string currencyID, string sort_, TransactionManager tm_)
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
		public List<Sa_invitenum100011_configEO> GetByCurrencyID(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_invitenum100011_configEO.MapDataReader);
		}
		public async Task<List<Sa_invitenum100011_configEO>> GetByCurrencyIDAsync(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_invitenum100011_configEO.MapDataReader);
		}
		#endregion // GetByCurrencyID
		#region GetByUserNumStart
		
		/// <summary>
		/// 按 UserNumStart（字段） 查询
		/// </summary>
		/// /// <param name = "userNumStart">邀请用户数量起始值</param>
		/// <return>实体对象集合</return>
		public List<Sa_invitenum100011_configEO> GetByUserNumStart(int userNumStart)
		{
			return GetByUserNumStart(userNumStart, 0, string.Empty, null);
		}
		public async Task<List<Sa_invitenum100011_configEO>> GetByUserNumStartAsync(int userNumStart)
		{
			return await GetByUserNumStartAsync(userNumStart, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserNumStart（字段） 查询
		/// </summary>
		/// /// <param name = "userNumStart">邀请用户数量起始值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invitenum100011_configEO> GetByUserNumStart(int userNumStart, TransactionManager tm_)
		{
			return GetByUserNumStart(userNumStart, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_invitenum100011_configEO>> GetByUserNumStartAsync(int userNumStart, TransactionManager tm_)
		{
			return await GetByUserNumStartAsync(userNumStart, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserNumStart（字段） 查询
		/// </summary>
		/// /// <param name = "userNumStart">邀请用户数量起始值</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_invitenum100011_configEO> GetByUserNumStart(int userNumStart, int top_)
		{
			return GetByUserNumStart(userNumStart, top_, string.Empty, null);
		}
		public async Task<List<Sa_invitenum100011_configEO>> GetByUserNumStartAsync(int userNumStart, int top_)
		{
			return await GetByUserNumStartAsync(userNumStart, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserNumStart（字段） 查询
		/// </summary>
		/// /// <param name = "userNumStart">邀请用户数量起始值</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invitenum100011_configEO> GetByUserNumStart(int userNumStart, int top_, TransactionManager tm_)
		{
			return GetByUserNumStart(userNumStart, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_invitenum100011_configEO>> GetByUserNumStartAsync(int userNumStart, int top_, TransactionManager tm_)
		{
			return await GetByUserNumStartAsync(userNumStart, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserNumStart（字段） 查询
		/// </summary>
		/// /// <param name = "userNumStart">邀请用户数量起始值</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_invitenum100011_configEO> GetByUserNumStart(int userNumStart, string sort_)
		{
			return GetByUserNumStart(userNumStart, 0, sort_, null);
		}
		public async Task<List<Sa_invitenum100011_configEO>> GetByUserNumStartAsync(int userNumStart, string sort_)
		{
			return await GetByUserNumStartAsync(userNumStart, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 UserNumStart（字段） 查询
		/// </summary>
		/// /// <param name = "userNumStart">邀请用户数量起始值</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invitenum100011_configEO> GetByUserNumStart(int userNumStart, string sort_, TransactionManager tm_)
		{
			return GetByUserNumStart(userNumStart, 0, sort_, tm_);
		}
		public async Task<List<Sa_invitenum100011_configEO>> GetByUserNumStartAsync(int userNumStart, string sort_, TransactionManager tm_)
		{
			return await GetByUserNumStartAsync(userNumStart, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 UserNumStart（字段） 查询
		/// </summary>
		/// /// <param name = "userNumStart">邀请用户数量起始值</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invitenum100011_configEO> GetByUserNumStart(int userNumStart, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserNumStart` = @UserNumStart", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserNumStart", userNumStart, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_invitenum100011_configEO.MapDataReader);
		}
		public async Task<List<Sa_invitenum100011_configEO>> GetByUserNumStartAsync(int userNumStart, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserNumStart` = @UserNumStart", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserNumStart", userNumStart, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_invitenum100011_configEO.MapDataReader);
		}
		#endregion // GetByUserNumStart
		#region GetByUserNumEnd
		
		/// <summary>
		/// 按 UserNumEnd（字段） 查询
		/// </summary>
		/// /// <param name = "userNumEnd">邀请用户数量截止值</param>
		/// <return>实体对象集合</return>
		public List<Sa_invitenum100011_configEO> GetByUserNumEnd(int userNumEnd)
		{
			return GetByUserNumEnd(userNumEnd, 0, string.Empty, null);
		}
		public async Task<List<Sa_invitenum100011_configEO>> GetByUserNumEndAsync(int userNumEnd)
		{
			return await GetByUserNumEndAsync(userNumEnd, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserNumEnd（字段） 查询
		/// </summary>
		/// /// <param name = "userNumEnd">邀请用户数量截止值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invitenum100011_configEO> GetByUserNumEnd(int userNumEnd, TransactionManager tm_)
		{
			return GetByUserNumEnd(userNumEnd, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_invitenum100011_configEO>> GetByUserNumEndAsync(int userNumEnd, TransactionManager tm_)
		{
			return await GetByUserNumEndAsync(userNumEnd, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserNumEnd（字段） 查询
		/// </summary>
		/// /// <param name = "userNumEnd">邀请用户数量截止值</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_invitenum100011_configEO> GetByUserNumEnd(int userNumEnd, int top_)
		{
			return GetByUserNumEnd(userNumEnd, top_, string.Empty, null);
		}
		public async Task<List<Sa_invitenum100011_configEO>> GetByUserNumEndAsync(int userNumEnd, int top_)
		{
			return await GetByUserNumEndAsync(userNumEnd, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserNumEnd（字段） 查询
		/// </summary>
		/// /// <param name = "userNumEnd">邀请用户数量截止值</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invitenum100011_configEO> GetByUserNumEnd(int userNumEnd, int top_, TransactionManager tm_)
		{
			return GetByUserNumEnd(userNumEnd, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_invitenum100011_configEO>> GetByUserNumEndAsync(int userNumEnd, int top_, TransactionManager tm_)
		{
			return await GetByUserNumEndAsync(userNumEnd, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserNumEnd（字段） 查询
		/// </summary>
		/// /// <param name = "userNumEnd">邀请用户数量截止值</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_invitenum100011_configEO> GetByUserNumEnd(int userNumEnd, string sort_)
		{
			return GetByUserNumEnd(userNumEnd, 0, sort_, null);
		}
		public async Task<List<Sa_invitenum100011_configEO>> GetByUserNumEndAsync(int userNumEnd, string sort_)
		{
			return await GetByUserNumEndAsync(userNumEnd, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 UserNumEnd（字段） 查询
		/// </summary>
		/// /// <param name = "userNumEnd">邀请用户数量截止值</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invitenum100011_configEO> GetByUserNumEnd(int userNumEnd, string sort_, TransactionManager tm_)
		{
			return GetByUserNumEnd(userNumEnd, 0, sort_, tm_);
		}
		public async Task<List<Sa_invitenum100011_configEO>> GetByUserNumEndAsync(int userNumEnd, string sort_, TransactionManager tm_)
		{
			return await GetByUserNumEndAsync(userNumEnd, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 UserNumEnd（字段） 查询
		/// </summary>
		/// /// <param name = "userNumEnd">邀请用户数量截止值</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invitenum100011_configEO> GetByUserNumEnd(int userNumEnd, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserNumEnd` = @UserNumEnd", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserNumEnd", userNumEnd, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_invitenum100011_configEO.MapDataReader);
		}
		public async Task<List<Sa_invitenum100011_configEO>> GetByUserNumEndAsync(int userNumEnd, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserNumEnd` = @UserNumEnd", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserNumEnd", userNumEnd, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_invitenum100011_configEO.MapDataReader);
		}
		#endregion // GetByUserNumEnd
		#region GetByBonus
		
		/// <summary>
		/// 按 Bonus（字段） 查询
		/// </summary>
		/// /// <param name = "bonus">奖励金额</param>
		/// <return>实体对象集合</return>
		public List<Sa_invitenum100011_configEO> GetByBonus(long bonus)
		{
			return GetByBonus(bonus, 0, string.Empty, null);
		}
		public async Task<List<Sa_invitenum100011_configEO>> GetByBonusAsync(long bonus)
		{
			return await GetByBonusAsync(bonus, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Bonus（字段） 查询
		/// </summary>
		/// /// <param name = "bonus">奖励金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invitenum100011_configEO> GetByBonus(long bonus, TransactionManager tm_)
		{
			return GetByBonus(bonus, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_invitenum100011_configEO>> GetByBonusAsync(long bonus, TransactionManager tm_)
		{
			return await GetByBonusAsync(bonus, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Bonus（字段） 查询
		/// </summary>
		/// /// <param name = "bonus">奖励金额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_invitenum100011_configEO> GetByBonus(long bonus, int top_)
		{
			return GetByBonus(bonus, top_, string.Empty, null);
		}
		public async Task<List<Sa_invitenum100011_configEO>> GetByBonusAsync(long bonus, int top_)
		{
			return await GetByBonusAsync(bonus, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Bonus（字段） 查询
		/// </summary>
		/// /// <param name = "bonus">奖励金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invitenum100011_configEO> GetByBonus(long bonus, int top_, TransactionManager tm_)
		{
			return GetByBonus(bonus, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_invitenum100011_configEO>> GetByBonusAsync(long bonus, int top_, TransactionManager tm_)
		{
			return await GetByBonusAsync(bonus, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Bonus（字段） 查询
		/// </summary>
		/// /// <param name = "bonus">奖励金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_invitenum100011_configEO> GetByBonus(long bonus, string sort_)
		{
			return GetByBonus(bonus, 0, sort_, null);
		}
		public async Task<List<Sa_invitenum100011_configEO>> GetByBonusAsync(long bonus, string sort_)
		{
			return await GetByBonusAsync(bonus, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Bonus（字段） 查询
		/// </summary>
		/// /// <param name = "bonus">奖励金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invitenum100011_configEO> GetByBonus(long bonus, string sort_, TransactionManager tm_)
		{
			return GetByBonus(bonus, 0, sort_, tm_);
		}
		public async Task<List<Sa_invitenum100011_configEO>> GetByBonusAsync(long bonus, string sort_, TransactionManager tm_)
		{
			return await GetByBonusAsync(bonus, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Bonus（字段） 查询
		/// </summary>
		/// /// <param name = "bonus">奖励金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invitenum100011_configEO> GetByBonus(long bonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Bonus` = @Bonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Bonus", bonus, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_invitenum100011_configEO.MapDataReader);
		}
		public async Task<List<Sa_invitenum100011_configEO>> GetByBonusAsync(long bonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Bonus` = @Bonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Bonus", bonus, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_invitenum100011_configEO.MapDataReader);
		}
		#endregion // GetByBonus
		#region GetByPayCondition
		
		/// <summary>
		/// 按 PayCondition（字段） 查询
		/// </summary>
		/// /// <param name = "payCondition">获取奖励需要满足的累计充值金额</param>
		/// <return>实体对象集合</return>
		public List<Sa_invitenum100011_configEO> GetByPayCondition(long payCondition)
		{
			return GetByPayCondition(payCondition, 0, string.Empty, null);
		}
		public async Task<List<Sa_invitenum100011_configEO>> GetByPayConditionAsync(long payCondition)
		{
			return await GetByPayConditionAsync(payCondition, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayCondition（字段） 查询
		/// </summary>
		/// /// <param name = "payCondition">获取奖励需要满足的累计充值金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invitenum100011_configEO> GetByPayCondition(long payCondition, TransactionManager tm_)
		{
			return GetByPayCondition(payCondition, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_invitenum100011_configEO>> GetByPayConditionAsync(long payCondition, TransactionManager tm_)
		{
			return await GetByPayConditionAsync(payCondition, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayCondition（字段） 查询
		/// </summary>
		/// /// <param name = "payCondition">获取奖励需要满足的累计充值金额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_invitenum100011_configEO> GetByPayCondition(long payCondition, int top_)
		{
			return GetByPayCondition(payCondition, top_, string.Empty, null);
		}
		public async Task<List<Sa_invitenum100011_configEO>> GetByPayConditionAsync(long payCondition, int top_)
		{
			return await GetByPayConditionAsync(payCondition, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayCondition（字段） 查询
		/// </summary>
		/// /// <param name = "payCondition">获取奖励需要满足的累计充值金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invitenum100011_configEO> GetByPayCondition(long payCondition, int top_, TransactionManager tm_)
		{
			return GetByPayCondition(payCondition, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_invitenum100011_configEO>> GetByPayConditionAsync(long payCondition, int top_, TransactionManager tm_)
		{
			return await GetByPayConditionAsync(payCondition, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayCondition（字段） 查询
		/// </summary>
		/// /// <param name = "payCondition">获取奖励需要满足的累计充值金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_invitenum100011_configEO> GetByPayCondition(long payCondition, string sort_)
		{
			return GetByPayCondition(payCondition, 0, sort_, null);
		}
		public async Task<List<Sa_invitenum100011_configEO>> GetByPayConditionAsync(long payCondition, string sort_)
		{
			return await GetByPayConditionAsync(payCondition, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PayCondition（字段） 查询
		/// </summary>
		/// /// <param name = "payCondition">获取奖励需要满足的累计充值金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invitenum100011_configEO> GetByPayCondition(long payCondition, string sort_, TransactionManager tm_)
		{
			return GetByPayCondition(payCondition, 0, sort_, tm_);
		}
		public async Task<List<Sa_invitenum100011_configEO>> GetByPayConditionAsync(long payCondition, string sort_, TransactionManager tm_)
		{
			return await GetByPayConditionAsync(payCondition, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PayCondition（字段） 查询
		/// </summary>
		/// /// <param name = "payCondition">获取奖励需要满足的累计充值金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invitenum100011_configEO> GetByPayCondition(long payCondition, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PayCondition` = @PayCondition", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PayCondition", payCondition, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_invitenum100011_configEO.MapDataReader);
		}
		public async Task<List<Sa_invitenum100011_configEO>> GetByPayConditionAsync(long payCondition, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PayCondition` = @PayCondition", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PayCondition", payCondition, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_invitenum100011_configEO.MapDataReader);
		}
		#endregion // GetByPayCondition
		#region GetByFlowMultip
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">提现时候需要完成的下注流水倍数</param>
		/// <return>实体对象集合</return>
		public List<Sa_invitenum100011_configEO> GetByFlowMultip(float flowMultip)
		{
			return GetByFlowMultip(flowMultip, 0, string.Empty, null);
		}
		public async Task<List<Sa_invitenum100011_configEO>> GetByFlowMultipAsync(float flowMultip)
		{
			return await GetByFlowMultipAsync(flowMultip, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">提现时候需要完成的下注流水倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invitenum100011_configEO> GetByFlowMultip(float flowMultip, TransactionManager tm_)
		{
			return GetByFlowMultip(flowMultip, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_invitenum100011_configEO>> GetByFlowMultipAsync(float flowMultip, TransactionManager tm_)
		{
			return await GetByFlowMultipAsync(flowMultip, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">提现时候需要完成的下注流水倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_invitenum100011_configEO> GetByFlowMultip(float flowMultip, int top_)
		{
			return GetByFlowMultip(flowMultip, top_, string.Empty, null);
		}
		public async Task<List<Sa_invitenum100011_configEO>> GetByFlowMultipAsync(float flowMultip, int top_)
		{
			return await GetByFlowMultipAsync(flowMultip, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">提现时候需要完成的下注流水倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invitenum100011_configEO> GetByFlowMultip(float flowMultip, int top_, TransactionManager tm_)
		{
			return GetByFlowMultip(flowMultip, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_invitenum100011_configEO>> GetByFlowMultipAsync(float flowMultip, int top_, TransactionManager tm_)
		{
			return await GetByFlowMultipAsync(flowMultip, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">提现时候需要完成的下注流水倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_invitenum100011_configEO> GetByFlowMultip(float flowMultip, string sort_)
		{
			return GetByFlowMultip(flowMultip, 0, sort_, null);
		}
		public async Task<List<Sa_invitenum100011_configEO>> GetByFlowMultipAsync(float flowMultip, string sort_)
		{
			return await GetByFlowMultipAsync(flowMultip, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">提现时候需要完成的下注流水倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invitenum100011_configEO> GetByFlowMultip(float flowMultip, string sort_, TransactionManager tm_)
		{
			return GetByFlowMultip(flowMultip, 0, sort_, tm_);
		}
		public async Task<List<Sa_invitenum100011_configEO>> GetByFlowMultipAsync(float flowMultip, string sort_, TransactionManager tm_)
		{
			return await GetByFlowMultipAsync(flowMultip, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">提现时候需要完成的下注流水倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invitenum100011_configEO> GetByFlowMultip(float flowMultip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FlowMultip` = @FlowMultip", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FlowMultip", flowMultip, MySqlDbType.Float));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_invitenum100011_configEO.MapDataReader);
		}
		public async Task<List<Sa_invitenum100011_configEO>> GetByFlowMultipAsync(float flowMultip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FlowMultip` = @FlowMultip", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FlowMultip", flowMultip, MySqlDbType.Float));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_invitenum100011_configEO.MapDataReader);
		}
		#endregion // GetByFlowMultip
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
