/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * AiUo代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/AiUo
 * 文档生成时间：2024-06-18 15: 38:07
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
	/// 充值配置
	/// 【表 l_pay_config 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class L_pay_configEO : IRowMapper<L_pay_configEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public L_pay_configEO()
		{
			this.Channels = 0;
			this.IsEnable = false;
			this.IsMainChannel = false;
			this.ChannelsGroup = 0;
			this.MinAmount = 0;
			this.MaxAmount = 0;
			this.RecDate = DateTime.Now;
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
		/// 主键GUID
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
		/// 充值渠道4-pandapay5-tejeepay
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 5)]
		public int Channels { get; set; }
		/// <summary>
		/// 充值渠道描述,对应channels
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 6)]
		public string ChannelsDesc { get; set; }
		/// <summary>
		/// 子通道(如加纳mtn-gh等)
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 7)]
		public string SubChannel { get; set; }
		/// <summary>
		/// 是否启用，同一个operatorId只能启用一条
		/// 【字段 tinyint(1)】
		/// </summary>
		[DataMember(Order = 8)]
		public bool IsEnable { get; set; }
		/// <summary>
		/// 1-主渠道2-备用渠道
		/// 【字段 tinyint(1)】
		/// </summary>
		[DataMember(Order = 9)]
		public bool IsMainChannel { get; set; }
		/// <summary>
		/// 充值渠道组
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 10)]
		public int ChannelsGroup { get; set; }
		/// <summary>
		/// 最小充值金额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 11)]
		public long MinAmount { get; set; }
		/// <summary>
		/// 最大充值金额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 12)]
		public long MaxAmount { get; set; }
		/// <summary>
		/// 记录时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 13)]
		public DateTime RecDate { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public L_pay_configEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static L_pay_configEO MapDataReader(IDataReader reader)
		{
		    L_pay_configEO ret = new L_pay_configEO();
			ret.ConfigID = reader.ToString("ConfigID");
			ret.OriginalConfigID = ret.ConfigID;
			ret.OperatorID = reader.ToString("OperatorID");
			ret.CountryId = reader.ToString("CountryId");
			ret.CurrencyID = reader.ToString("CurrencyID");
			ret.Channels = reader.ToInt32("Channels");
			ret.ChannelsDesc = reader.ToString("ChannelsDesc");
			ret.SubChannel = reader.ToString("SubChannel");
			ret.IsEnable = reader.ToBoolean("IsEnable");
			ret.IsMainChannel = reader.ToBoolean("IsMainChannel");
			ret.ChannelsGroup = reader.ToInt32("ChannelsGroup");
			ret.MinAmount = reader.ToInt64("MinAmount");
			ret.MaxAmount = reader.ToInt64("MaxAmount");
			ret.RecDate = reader.ToDateTime("RecDate");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 充值配置
	/// 【表 l_pay_config 的操作类】
	/// </summary>
	[Obsolete]
	public class L_pay_configMO : MySqlTableMO<L_pay_configEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`l_pay_config`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public L_pay_configMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public L_pay_configMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public L_pay_configMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(L_pay_configEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(L_pay_configEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(L_pay_configEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`ConfigID`, `OperatorID`, `CountryId`, `CurrencyID`, `Channels`, `ChannelsDesc`, `SubChannel`, `IsEnable`, `IsMainChannel`, `ChannelsGroup`, `MinAmount`, `MaxAmount`, `RecDate`) VALUE (@ConfigID, @OperatorID, @CountryId, @CurrencyID, @Channels, @ChannelsDesc, @SubChannel, @IsEnable, @IsMainChannel, @ChannelsGroup, @MinAmount, @MaxAmount, @RecDate);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", item.ConfigID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryId", item.CountryId, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Channels", item.Channels, MySqlDbType.Int32),
				Database.CreateInParameter("@ChannelsDesc", item.ChannelsDesc, MySqlDbType.VarChar),
				Database.CreateInParameter("@SubChannel", item.SubChannel != null ? item.SubChannel : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@IsEnable", item.IsEnable, MySqlDbType.Byte),
				Database.CreateInParameter("@IsMainChannel", item.IsMainChannel, MySqlDbType.Byte),
				Database.CreateInParameter("@ChannelsGroup", item.ChannelsGroup, MySqlDbType.Int32),
				Database.CreateInParameter("@MinAmount", item.MinAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@MaxAmount", item.MaxAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
			};
		}
		public int AddByBatch(IEnumerable<L_pay_configEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<L_pay_configEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<L_pay_configEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`ConfigID`, `OperatorID`, `CountryId`, `CurrencyID`, `Channels`, `ChannelsDesc`, `SubChannel`, `IsEnable`, `IsMainChannel`, `ChannelsGroup`, `MinAmount`, `MaxAmount`, `RecDate`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.ConfigID}','{item.OperatorID}','{item.CountryId}','{item.CurrencyID}',{item.Channels},'{item.ChannelsDesc}','{item.SubChannel}',{item.IsEnable},{item.IsMainChannel},{item.ChannelsGroup},{item.MinAmount},{item.MaxAmount},'{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
		/// /// <param name = "configID">主键GUID</param>
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
		public int Remove(L_pay_configEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.ConfigID, tm_);
		}
		public async Task<int> RemoveAsync(L_pay_configEO item, TransactionManager tm_ = null)
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
		#region RemoveByChannels
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "channels">充值渠道4-pandapay5-tejeepay</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByChannels(int channels, TransactionManager tm_ = null)
		{
			RepairRemoveByChannelsData(channels, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByChannelsAsync(int channels, TransactionManager tm_ = null)
		{
			RepairRemoveByChannelsData(channels, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByChannelsData(int channels, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Channels` = @Channels";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Channels", channels, MySqlDbType.Int32));
		}
		#endregion // RemoveByChannels
		#region RemoveByChannelsDesc
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "channelsDesc">充值渠道描述,对应channels</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByChannelsDesc(string channelsDesc, TransactionManager tm_ = null)
		{
			RepairRemoveByChannelsDescData(channelsDesc, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByChannelsDescAsync(string channelsDesc, TransactionManager tm_ = null)
		{
			RepairRemoveByChannelsDescData(channelsDesc, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByChannelsDescData(string channelsDesc, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `ChannelsDesc` = @ChannelsDesc";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ChannelsDesc", channelsDesc, MySqlDbType.VarChar));
		}
		#endregion // RemoveByChannelsDesc
		#region RemoveBySubChannel
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "subChannel">子通道(如加纳mtn-gh等)</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveBySubChannel(string subChannel, TransactionManager tm_ = null)
		{
			RepairRemoveBySubChannelData(subChannel, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveBySubChannelAsync(string subChannel, TransactionManager tm_ = null)
		{
			RepairRemoveBySubChannelData(subChannel, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveBySubChannelData(string subChannel, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (subChannel != null ? "`SubChannel` = @SubChannel" : "`SubChannel` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (subChannel != null)
				paras_.Add(Database.CreateInParameter("@SubChannel", subChannel, MySqlDbType.VarChar));
		}
		#endregion // RemoveBySubChannel
		#region RemoveByIsEnable
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "isEnable">是否启用，同一个operatorId只能启用一条</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByIsEnable(bool isEnable, TransactionManager tm_ = null)
		{
			RepairRemoveByIsEnableData(isEnable, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByIsEnableAsync(bool isEnable, TransactionManager tm_ = null)
		{
			RepairRemoveByIsEnableData(isEnable, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByIsEnableData(bool isEnable, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `IsEnable` = @IsEnable";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsEnable", isEnable, MySqlDbType.Byte));
		}
		#endregion // RemoveByIsEnable
		#region RemoveByIsMainChannel
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "isMainChannel">1-主渠道2-备用渠道</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByIsMainChannel(bool isMainChannel, TransactionManager tm_ = null)
		{
			RepairRemoveByIsMainChannelData(isMainChannel, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByIsMainChannelAsync(bool isMainChannel, TransactionManager tm_ = null)
		{
			RepairRemoveByIsMainChannelData(isMainChannel, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByIsMainChannelData(bool isMainChannel, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `IsMainChannel` = @IsMainChannel";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsMainChannel", isMainChannel, MySqlDbType.Byte));
		}
		#endregion // RemoveByIsMainChannel
		#region RemoveByChannelsGroup
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "channelsGroup">充值渠道组</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByChannelsGroup(int channelsGroup, TransactionManager tm_ = null)
		{
			RepairRemoveByChannelsGroupData(channelsGroup, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByChannelsGroupAsync(int channelsGroup, TransactionManager tm_ = null)
		{
			RepairRemoveByChannelsGroupData(channelsGroup, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByChannelsGroupData(int channelsGroup, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `ChannelsGroup` = @ChannelsGroup";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ChannelsGroup", channelsGroup, MySqlDbType.Int32));
		}
		#endregion // RemoveByChannelsGroup
		#region RemoveByMinAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "minAmount">最小充值金额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByMinAmount(long minAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByMinAmountData(minAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByMinAmountAsync(long minAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByMinAmountData(minAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByMinAmountData(long minAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `MinAmount` = @MinAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MinAmount", minAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByMinAmount
		#region RemoveByMaxAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "maxAmount">最大充值金额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByMaxAmount(long maxAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByMaxAmountData(maxAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByMaxAmountAsync(long maxAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByMaxAmountData(maxAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByMaxAmountData(long maxAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `MaxAmount` = @MaxAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MaxAmount", maxAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByMaxAmount
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
		public int Put(L_pay_configEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(L_pay_configEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(L_pay_configEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ConfigID` = @ConfigID, `OperatorID` = @OperatorID, `CountryId` = @CountryId, `CurrencyID` = @CurrencyID, `Channels` = @Channels, `ChannelsDesc` = @ChannelsDesc, `SubChannel` = @SubChannel, `IsEnable` = @IsEnable, `IsMainChannel` = @IsMainChannel, `ChannelsGroup` = @ChannelsGroup, `MinAmount` = @MinAmount, `MaxAmount` = @MaxAmount WHERE `ConfigID` = @ConfigID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", item.ConfigID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryId", item.CountryId, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Channels", item.Channels, MySqlDbType.Int32),
				Database.CreateInParameter("@ChannelsDesc", item.ChannelsDesc, MySqlDbType.VarChar),
				Database.CreateInParameter("@SubChannel", item.SubChannel != null ? item.SubChannel : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@IsEnable", item.IsEnable, MySqlDbType.Byte),
				Database.CreateInParameter("@IsMainChannel", item.IsMainChannel, MySqlDbType.Byte),
				Database.CreateInParameter("@ChannelsGroup", item.ChannelsGroup, MySqlDbType.Int32),
				Database.CreateInParameter("@MinAmount", item.MinAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@MaxAmount", item.MaxAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@ConfigID_Original", item.HasOriginal ? item.OriginalConfigID : item.ConfigID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<L_pay_configEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<L_pay_configEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "configID">主键GUID</param>
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
		/// /// <param name = "configID">主键GUID</param>
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
		/// /// <param name = "configID">主键GUID</param>
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
		/// /// <param name = "configID">主键GUID</param>
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
		/// /// <param name = "configID">主键GUID</param>
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
		/// /// <param name = "configID">主键GUID</param>
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
		#region PutChannels
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "configID">主键GUID</param>
		/// /// <param name = "channels">充值渠道4-pandapay5-tejeepay</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutChannelsByPK(string configID, int channels, TransactionManager tm_ = null)
		{
			RepairPutChannelsByPKData(configID, channels, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutChannelsByPKAsync(string configID, int channels, TransactionManager tm_ = null)
		{
			RepairPutChannelsByPKData(configID, channels, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutChannelsByPKData(string configID, int channels, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Channels` = @Channels  WHERE `ConfigID` = @ConfigID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Channels", channels, MySqlDbType.Int32),
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "channels">充值渠道4-pandapay5-tejeepay</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutChannels(int channels, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Channels` = @Channels";
			var parameter_ = Database.CreateInParameter("@Channels", channels, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutChannelsAsync(int channels, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Channels` = @Channels";
			var parameter_ = Database.CreateInParameter("@Channels", channels, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutChannels
		#region PutChannelsDesc
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "configID">主键GUID</param>
		/// /// <param name = "channelsDesc">充值渠道描述,对应channels</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutChannelsDescByPK(string configID, string channelsDesc, TransactionManager tm_ = null)
		{
			RepairPutChannelsDescByPKData(configID, channelsDesc, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutChannelsDescByPKAsync(string configID, string channelsDesc, TransactionManager tm_ = null)
		{
			RepairPutChannelsDescByPKData(configID, channelsDesc, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutChannelsDescByPKData(string configID, string channelsDesc, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ChannelsDesc` = @ChannelsDesc  WHERE `ConfigID` = @ConfigID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChannelsDesc", channelsDesc, MySqlDbType.VarChar),
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "channelsDesc">充值渠道描述,对应channels</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutChannelsDesc(string channelsDesc, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ChannelsDesc` = @ChannelsDesc";
			var parameter_ = Database.CreateInParameter("@ChannelsDesc", channelsDesc, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutChannelsDescAsync(string channelsDesc, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ChannelsDesc` = @ChannelsDesc";
			var parameter_ = Database.CreateInParameter("@ChannelsDesc", channelsDesc, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutChannelsDesc
		#region PutSubChannel
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "configID">主键GUID</param>
		/// /// <param name = "subChannel">子通道(如加纳mtn-gh等)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSubChannelByPK(string configID, string subChannel, TransactionManager tm_ = null)
		{
			RepairPutSubChannelByPKData(configID, subChannel, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutSubChannelByPKAsync(string configID, string subChannel, TransactionManager tm_ = null)
		{
			RepairPutSubChannelByPKData(configID, subChannel, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutSubChannelByPKData(string configID, string subChannel, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `SubChannel` = @SubChannel  WHERE `ConfigID` = @ConfigID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SubChannel", subChannel != null ? subChannel : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "subChannel">子通道(如加纳mtn-gh等)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSubChannel(string subChannel, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SubChannel` = @SubChannel";
			var parameter_ = Database.CreateInParameter("@SubChannel", subChannel != null ? subChannel : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutSubChannelAsync(string subChannel, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SubChannel` = @SubChannel";
			var parameter_ = Database.CreateInParameter("@SubChannel", subChannel != null ? subChannel : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutSubChannel
		#region PutIsEnable
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "configID">主键GUID</param>
		/// /// <param name = "isEnable">是否启用，同一个operatorId只能启用一条</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsEnableByPK(string configID, bool isEnable, TransactionManager tm_ = null)
		{
			RepairPutIsEnableByPKData(configID, isEnable, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutIsEnableByPKAsync(string configID, bool isEnable, TransactionManager tm_ = null)
		{
			RepairPutIsEnableByPKData(configID, isEnable, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutIsEnableByPKData(string configID, bool isEnable, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `IsEnable` = @IsEnable  WHERE `ConfigID` = @ConfigID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@IsEnable", isEnable, MySqlDbType.Byte),
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "isEnable">是否启用，同一个operatorId只能启用一条</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsEnable(bool isEnable, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsEnable` = @IsEnable";
			var parameter_ = Database.CreateInParameter("@IsEnable", isEnable, MySqlDbType.Byte);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutIsEnableAsync(bool isEnable, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsEnable` = @IsEnable";
			var parameter_ = Database.CreateInParameter("@IsEnable", isEnable, MySqlDbType.Byte);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutIsEnable
		#region PutIsMainChannel
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "configID">主键GUID</param>
		/// /// <param name = "isMainChannel">1-主渠道2-备用渠道</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsMainChannelByPK(string configID, bool isMainChannel, TransactionManager tm_ = null)
		{
			RepairPutIsMainChannelByPKData(configID, isMainChannel, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutIsMainChannelByPKAsync(string configID, bool isMainChannel, TransactionManager tm_ = null)
		{
			RepairPutIsMainChannelByPKData(configID, isMainChannel, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutIsMainChannelByPKData(string configID, bool isMainChannel, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `IsMainChannel` = @IsMainChannel  WHERE `ConfigID` = @ConfigID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@IsMainChannel", isMainChannel, MySqlDbType.Byte),
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "isMainChannel">1-主渠道2-备用渠道</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsMainChannel(bool isMainChannel, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsMainChannel` = @IsMainChannel";
			var parameter_ = Database.CreateInParameter("@IsMainChannel", isMainChannel, MySqlDbType.Byte);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutIsMainChannelAsync(bool isMainChannel, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsMainChannel` = @IsMainChannel";
			var parameter_ = Database.CreateInParameter("@IsMainChannel", isMainChannel, MySqlDbType.Byte);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutIsMainChannel
		#region PutChannelsGroup
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "configID">主键GUID</param>
		/// /// <param name = "channelsGroup">充值渠道组</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutChannelsGroupByPK(string configID, int channelsGroup, TransactionManager tm_ = null)
		{
			RepairPutChannelsGroupByPKData(configID, channelsGroup, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutChannelsGroupByPKAsync(string configID, int channelsGroup, TransactionManager tm_ = null)
		{
			RepairPutChannelsGroupByPKData(configID, channelsGroup, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutChannelsGroupByPKData(string configID, int channelsGroup, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ChannelsGroup` = @ChannelsGroup  WHERE `ConfigID` = @ConfigID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChannelsGroup", channelsGroup, MySqlDbType.Int32),
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "channelsGroup">充值渠道组</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutChannelsGroup(int channelsGroup, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ChannelsGroup` = @ChannelsGroup";
			var parameter_ = Database.CreateInParameter("@ChannelsGroup", channelsGroup, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutChannelsGroupAsync(int channelsGroup, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ChannelsGroup` = @ChannelsGroup";
			var parameter_ = Database.CreateInParameter("@ChannelsGroup", channelsGroup, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutChannelsGroup
		#region PutMinAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "configID">主键GUID</param>
		/// /// <param name = "minAmount">最小充值金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMinAmountByPK(string configID, long minAmount, TransactionManager tm_ = null)
		{
			RepairPutMinAmountByPKData(configID, minAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutMinAmountByPKAsync(string configID, long minAmount, TransactionManager tm_ = null)
		{
			RepairPutMinAmountByPKData(configID, minAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutMinAmountByPKData(string configID, long minAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `MinAmount` = @MinAmount  WHERE `ConfigID` = @ConfigID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MinAmount", minAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "minAmount">最小充值金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMinAmount(long minAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MinAmount` = @MinAmount";
			var parameter_ = Database.CreateInParameter("@MinAmount", minAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutMinAmountAsync(long minAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MinAmount` = @MinAmount";
			var parameter_ = Database.CreateInParameter("@MinAmount", minAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutMinAmount
		#region PutMaxAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "configID">主键GUID</param>
		/// /// <param name = "maxAmount">最大充值金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMaxAmountByPK(string configID, long maxAmount, TransactionManager tm_ = null)
		{
			RepairPutMaxAmountByPKData(configID, maxAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutMaxAmountByPKAsync(string configID, long maxAmount, TransactionManager tm_ = null)
		{
			RepairPutMaxAmountByPKData(configID, maxAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutMaxAmountByPKData(string configID, long maxAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `MaxAmount` = @MaxAmount  WHERE `ConfigID` = @ConfigID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MaxAmount", maxAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "maxAmount">最大充值金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMaxAmount(long maxAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MaxAmount` = @MaxAmount";
			var parameter_ = Database.CreateInParameter("@MaxAmount", maxAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutMaxAmountAsync(long maxAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MaxAmount` = @MaxAmount";
			var parameter_ = Database.CreateInParameter("@MaxAmount", maxAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutMaxAmount
		#region PutRecDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "configID">主键GUID</param>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(string configID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(configID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(string configID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(configID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(string configID, DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `ConfigID` = @ConfigID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
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
		public bool Set(L_pay_configEO item, TransactionManager tm = null)
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
		public async Task<bool> SetAsync(L_pay_configEO item, TransactionManager tm = null)
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
		/// /// <param name = "configID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public L_pay_configEO GetByPK(string configID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(configID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, L_pay_configEO.MapDataReader);
		}
		public async Task<L_pay_configEO> GetByPKAsync(string configID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(configID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, L_pay_configEO.MapDataReader);
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
		/// /// <param name = "configID">主键GUID</param>
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
		/// /// <param name = "configID">主键GUID</param>
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
		/// /// <param name = "configID">主键GUID</param>
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
		/// 按主键查询 Channels（字段）
		/// </summary>
		/// /// <param name = "configID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetChannelsByPK(string configID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`Channels`", "`ConfigID` = @ConfigID", paras_, tm_);
		}
		public async Task<int> GetChannelsByPKAsync(string configID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`Channels`", "`ConfigID` = @ConfigID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ChannelsDesc（字段）
		/// </summary>
		/// /// <param name = "configID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetChannelsDescByPK(string configID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`ChannelsDesc`", "`ConfigID` = @ConfigID", paras_, tm_);
		}
		public async Task<string> GetChannelsDescByPKAsync(string configID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`ChannelsDesc`", "`ConfigID` = @ConfigID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 SubChannel（字段）
		/// </summary>
		/// /// <param name = "configID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetSubChannelByPK(string configID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`SubChannel`", "`ConfigID` = @ConfigID", paras_, tm_);
		}
		public async Task<string> GetSubChannelByPKAsync(string configID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`SubChannel`", "`ConfigID` = @ConfigID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 IsEnable（字段）
		/// </summary>
		/// /// <param name = "configID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public bool GetIsEnableByPK(string configID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
			return (bool)GetScalar("`IsEnable`", "`ConfigID` = @ConfigID", paras_, tm_);
		}
		public async Task<bool> GetIsEnableByPKAsync(string configID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
			return (bool)await GetScalarAsync("`IsEnable`", "`ConfigID` = @ConfigID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 IsMainChannel（字段）
		/// </summary>
		/// /// <param name = "configID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public bool GetIsMainChannelByPK(string configID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
			return (bool)GetScalar("`IsMainChannel`", "`ConfigID` = @ConfigID", paras_, tm_);
		}
		public async Task<bool> GetIsMainChannelByPKAsync(string configID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
			return (bool)await GetScalarAsync("`IsMainChannel`", "`ConfigID` = @ConfigID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ChannelsGroup（字段）
		/// </summary>
		/// /// <param name = "configID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetChannelsGroupByPK(string configID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`ChannelsGroup`", "`ConfigID` = @ConfigID", paras_, tm_);
		}
		public async Task<int> GetChannelsGroupByPKAsync(string configID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`ChannelsGroup`", "`ConfigID` = @ConfigID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 MinAmount（字段）
		/// </summary>
		/// /// <param name = "configID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetMinAmountByPK(string configID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`MinAmount`", "`ConfigID` = @ConfigID", paras_, tm_);
		}
		public async Task<long> GetMinAmountByPKAsync(string configID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`MinAmount`", "`ConfigID` = @ConfigID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 MaxAmount（字段）
		/// </summary>
		/// /// <param name = "configID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetMaxAmountByPK(string configID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`MaxAmount`", "`ConfigID` = @ConfigID", paras_, tm_);
		}
		public async Task<long> GetMaxAmountByPKAsync(string configID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`MaxAmount`", "`ConfigID` = @ConfigID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "configID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetRecDateByPK(string configID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`RecDate`", "`ConfigID` = @ConfigID", paras_, tm_);
		}
		public async Task<DateTime> GetRecDateByPKAsync(string configID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`RecDate`", "`ConfigID` = @ConfigID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<L_pay_configEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<L_pay_configEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<L_pay_configEO>> GetByOperatorIDAsync(string operatorID, int top_)
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
		public List<L_pay_configEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<L_pay_configEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<L_pay_configEO>> GetByOperatorIDAsync(string operatorID, string sort_)
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
		public List<L_pay_configEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<L_pay_configEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
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
		public List<L_pay_configEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_pay_configEO.MapDataReader);
		}
		public async Task<List<L_pay_configEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_pay_configEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByCountryId
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetByCountryId(string countryId)
		{
			return GetByCountryId(countryId, 0, string.Empty, null);
		}
		public async Task<List<L_pay_configEO>> GetByCountryIdAsync(string countryId)
		{
			return await GetByCountryIdAsync(countryId, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetByCountryId(string countryId, TransactionManager tm_)
		{
			return GetByCountryId(countryId, 0, string.Empty, tm_);
		}
		public async Task<List<L_pay_configEO>> GetByCountryIdAsync(string countryId, TransactionManager tm_)
		{
			return await GetByCountryIdAsync(countryId, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetByCountryId(string countryId, int top_)
		{
			return GetByCountryId(countryId, top_, string.Empty, null);
		}
		public async Task<List<L_pay_configEO>> GetByCountryIdAsync(string countryId, int top_)
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
		public List<L_pay_configEO> GetByCountryId(string countryId, int top_, TransactionManager tm_)
		{
			return GetByCountryId(countryId, top_, string.Empty, tm_);
		}
		public async Task<List<L_pay_configEO>> GetByCountryIdAsync(string countryId, int top_, TransactionManager tm_)
		{
			return await GetByCountryIdAsync(countryId, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetByCountryId(string countryId, string sort_)
		{
			return GetByCountryId(countryId, 0, sort_, null);
		}
		public async Task<List<L_pay_configEO>> GetByCountryIdAsync(string countryId, string sort_)
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
		public List<L_pay_configEO> GetByCountryId(string countryId, string sort_, TransactionManager tm_)
		{
			return GetByCountryId(countryId, 0, sort_, tm_);
		}
		public async Task<List<L_pay_configEO>> GetByCountryIdAsync(string countryId, string sort_, TransactionManager tm_)
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
		public List<L_pay_configEO> GetByCountryId(string countryId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CountryId` = @CountryId", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_pay_configEO.MapDataReader);
		}
		public async Task<List<L_pay_configEO>> GetByCountryIdAsync(string countryId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CountryId` = @CountryId", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_pay_configEO.MapDataReader);
		}
		#endregion // GetByCountryId
		#region GetByCurrencyID
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetByCurrencyID(string currencyID)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, null);
		}
		public async Task<List<L_pay_configEO>> GetByCurrencyIDAsync(string currencyID)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetByCurrencyID(string currencyID, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, tm_);
		}
		public async Task<List<L_pay_configEO>> GetByCurrencyIDAsync(string currencyID, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetByCurrencyID(string currencyID, int top_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, null);
		}
		public async Task<List<L_pay_configEO>> GetByCurrencyIDAsync(string currencyID, int top_)
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
		public List<L_pay_configEO> GetByCurrencyID(string currencyID, int top_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, tm_);
		}
		public async Task<List<L_pay_configEO>> GetByCurrencyIDAsync(string currencyID, int top_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetByCurrencyID(string currencyID, string sort_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, null);
		}
		public async Task<List<L_pay_configEO>> GetByCurrencyIDAsync(string currencyID, string sort_)
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
		public List<L_pay_configEO> GetByCurrencyID(string currencyID, string sort_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, tm_);
		}
		public async Task<List<L_pay_configEO>> GetByCurrencyIDAsync(string currencyID, string sort_, TransactionManager tm_)
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
		public List<L_pay_configEO> GetByCurrencyID(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_pay_configEO.MapDataReader);
		}
		public async Task<List<L_pay_configEO>> GetByCurrencyIDAsync(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_pay_configEO.MapDataReader);
		}
		#endregion // GetByCurrencyID
		#region GetByChannels
		
		/// <summary>
		/// 按 Channels（字段） 查询
		/// </summary>
		/// /// <param name = "channels">充值渠道4-pandapay5-tejeepay</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetByChannels(int channels)
		{
			return GetByChannels(channels, 0, string.Empty, null);
		}
		public async Task<List<L_pay_configEO>> GetByChannelsAsync(int channels)
		{
			return await GetByChannelsAsync(channels, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Channels（字段） 查询
		/// </summary>
		/// /// <param name = "channels">充值渠道4-pandapay5-tejeepay</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetByChannels(int channels, TransactionManager tm_)
		{
			return GetByChannels(channels, 0, string.Empty, tm_);
		}
		public async Task<List<L_pay_configEO>> GetByChannelsAsync(int channels, TransactionManager tm_)
		{
			return await GetByChannelsAsync(channels, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Channels（字段） 查询
		/// </summary>
		/// /// <param name = "channels">充值渠道4-pandapay5-tejeepay</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetByChannels(int channels, int top_)
		{
			return GetByChannels(channels, top_, string.Empty, null);
		}
		public async Task<List<L_pay_configEO>> GetByChannelsAsync(int channels, int top_)
		{
			return await GetByChannelsAsync(channels, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Channels（字段） 查询
		/// </summary>
		/// /// <param name = "channels">充值渠道4-pandapay5-tejeepay</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetByChannels(int channels, int top_, TransactionManager tm_)
		{
			return GetByChannels(channels, top_, string.Empty, tm_);
		}
		public async Task<List<L_pay_configEO>> GetByChannelsAsync(int channels, int top_, TransactionManager tm_)
		{
			return await GetByChannelsAsync(channels, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Channels（字段） 查询
		/// </summary>
		/// /// <param name = "channels">充值渠道4-pandapay5-tejeepay</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetByChannels(int channels, string sort_)
		{
			return GetByChannels(channels, 0, sort_, null);
		}
		public async Task<List<L_pay_configEO>> GetByChannelsAsync(int channels, string sort_)
		{
			return await GetByChannelsAsync(channels, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Channels（字段） 查询
		/// </summary>
		/// /// <param name = "channels">充值渠道4-pandapay5-tejeepay</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetByChannels(int channels, string sort_, TransactionManager tm_)
		{
			return GetByChannels(channels, 0, sort_, tm_);
		}
		public async Task<List<L_pay_configEO>> GetByChannelsAsync(int channels, string sort_, TransactionManager tm_)
		{
			return await GetByChannelsAsync(channels, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Channels（字段） 查询
		/// </summary>
		/// /// <param name = "channels">充值渠道4-pandapay5-tejeepay</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetByChannels(int channels, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Channels` = @Channels", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Channels", channels, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, L_pay_configEO.MapDataReader);
		}
		public async Task<List<L_pay_configEO>> GetByChannelsAsync(int channels, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Channels` = @Channels", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Channels", channels, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_pay_configEO.MapDataReader);
		}
		#endregion // GetByChannels
		#region GetByChannelsDesc
		
		/// <summary>
		/// 按 ChannelsDesc（字段） 查询
		/// </summary>
		/// /// <param name = "channelsDesc">充值渠道描述,对应channels</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetByChannelsDesc(string channelsDesc)
		{
			return GetByChannelsDesc(channelsDesc, 0, string.Empty, null);
		}
		public async Task<List<L_pay_configEO>> GetByChannelsDescAsync(string channelsDesc)
		{
			return await GetByChannelsDescAsync(channelsDesc, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ChannelsDesc（字段） 查询
		/// </summary>
		/// /// <param name = "channelsDesc">充值渠道描述,对应channels</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetByChannelsDesc(string channelsDesc, TransactionManager tm_)
		{
			return GetByChannelsDesc(channelsDesc, 0, string.Empty, tm_);
		}
		public async Task<List<L_pay_configEO>> GetByChannelsDescAsync(string channelsDesc, TransactionManager tm_)
		{
			return await GetByChannelsDescAsync(channelsDesc, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ChannelsDesc（字段） 查询
		/// </summary>
		/// /// <param name = "channelsDesc">充值渠道描述,对应channels</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetByChannelsDesc(string channelsDesc, int top_)
		{
			return GetByChannelsDesc(channelsDesc, top_, string.Empty, null);
		}
		public async Task<List<L_pay_configEO>> GetByChannelsDescAsync(string channelsDesc, int top_)
		{
			return await GetByChannelsDescAsync(channelsDesc, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ChannelsDesc（字段） 查询
		/// </summary>
		/// /// <param name = "channelsDesc">充值渠道描述,对应channels</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetByChannelsDesc(string channelsDesc, int top_, TransactionManager tm_)
		{
			return GetByChannelsDesc(channelsDesc, top_, string.Empty, tm_);
		}
		public async Task<List<L_pay_configEO>> GetByChannelsDescAsync(string channelsDesc, int top_, TransactionManager tm_)
		{
			return await GetByChannelsDescAsync(channelsDesc, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ChannelsDesc（字段） 查询
		/// </summary>
		/// /// <param name = "channelsDesc">充值渠道描述,对应channels</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetByChannelsDesc(string channelsDesc, string sort_)
		{
			return GetByChannelsDesc(channelsDesc, 0, sort_, null);
		}
		public async Task<List<L_pay_configEO>> GetByChannelsDescAsync(string channelsDesc, string sort_)
		{
			return await GetByChannelsDescAsync(channelsDesc, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ChannelsDesc（字段） 查询
		/// </summary>
		/// /// <param name = "channelsDesc">充值渠道描述,对应channels</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetByChannelsDesc(string channelsDesc, string sort_, TransactionManager tm_)
		{
			return GetByChannelsDesc(channelsDesc, 0, sort_, tm_);
		}
		public async Task<List<L_pay_configEO>> GetByChannelsDescAsync(string channelsDesc, string sort_, TransactionManager tm_)
		{
			return await GetByChannelsDescAsync(channelsDesc, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ChannelsDesc（字段） 查询
		/// </summary>
		/// /// <param name = "channelsDesc">充值渠道描述,对应channels</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetByChannelsDesc(string channelsDesc, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ChannelsDesc` = @ChannelsDesc", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ChannelsDesc", channelsDesc, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_pay_configEO.MapDataReader);
		}
		public async Task<List<L_pay_configEO>> GetByChannelsDescAsync(string channelsDesc, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ChannelsDesc` = @ChannelsDesc", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ChannelsDesc", channelsDesc, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_pay_configEO.MapDataReader);
		}
		#endregion // GetByChannelsDesc
		#region GetBySubChannel
		
		/// <summary>
		/// 按 SubChannel（字段） 查询
		/// </summary>
		/// /// <param name = "subChannel">子通道(如加纳mtn-gh等)</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetBySubChannel(string subChannel)
		{
			return GetBySubChannel(subChannel, 0, string.Empty, null);
		}
		public async Task<List<L_pay_configEO>> GetBySubChannelAsync(string subChannel)
		{
			return await GetBySubChannelAsync(subChannel, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SubChannel（字段） 查询
		/// </summary>
		/// /// <param name = "subChannel">子通道(如加纳mtn-gh等)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetBySubChannel(string subChannel, TransactionManager tm_)
		{
			return GetBySubChannel(subChannel, 0, string.Empty, tm_);
		}
		public async Task<List<L_pay_configEO>> GetBySubChannelAsync(string subChannel, TransactionManager tm_)
		{
			return await GetBySubChannelAsync(subChannel, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SubChannel（字段） 查询
		/// </summary>
		/// /// <param name = "subChannel">子通道(如加纳mtn-gh等)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetBySubChannel(string subChannel, int top_)
		{
			return GetBySubChannel(subChannel, top_, string.Empty, null);
		}
		public async Task<List<L_pay_configEO>> GetBySubChannelAsync(string subChannel, int top_)
		{
			return await GetBySubChannelAsync(subChannel, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SubChannel（字段） 查询
		/// </summary>
		/// /// <param name = "subChannel">子通道(如加纳mtn-gh等)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetBySubChannel(string subChannel, int top_, TransactionManager tm_)
		{
			return GetBySubChannel(subChannel, top_, string.Empty, tm_);
		}
		public async Task<List<L_pay_configEO>> GetBySubChannelAsync(string subChannel, int top_, TransactionManager tm_)
		{
			return await GetBySubChannelAsync(subChannel, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SubChannel（字段） 查询
		/// </summary>
		/// /// <param name = "subChannel">子通道(如加纳mtn-gh等)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetBySubChannel(string subChannel, string sort_)
		{
			return GetBySubChannel(subChannel, 0, sort_, null);
		}
		public async Task<List<L_pay_configEO>> GetBySubChannelAsync(string subChannel, string sort_)
		{
			return await GetBySubChannelAsync(subChannel, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 SubChannel（字段） 查询
		/// </summary>
		/// /// <param name = "subChannel">子通道(如加纳mtn-gh等)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetBySubChannel(string subChannel, string sort_, TransactionManager tm_)
		{
			return GetBySubChannel(subChannel, 0, sort_, tm_);
		}
		public async Task<List<L_pay_configEO>> GetBySubChannelAsync(string subChannel, string sort_, TransactionManager tm_)
		{
			return await GetBySubChannelAsync(subChannel, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 SubChannel（字段） 查询
		/// </summary>
		/// /// <param name = "subChannel">子通道(如加纳mtn-gh等)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetBySubChannel(string subChannel, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(subChannel != null ? "`SubChannel` = @SubChannel" : "`SubChannel` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (subChannel != null)
				paras_.Add(Database.CreateInParameter("@SubChannel", subChannel, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_pay_configEO.MapDataReader);
		}
		public async Task<List<L_pay_configEO>> GetBySubChannelAsync(string subChannel, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(subChannel != null ? "`SubChannel` = @SubChannel" : "`SubChannel` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (subChannel != null)
				paras_.Add(Database.CreateInParameter("@SubChannel", subChannel, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_pay_configEO.MapDataReader);
		}
		#endregion // GetBySubChannel
		#region GetByIsEnable
		
		/// <summary>
		/// 按 IsEnable（字段） 查询
		/// </summary>
		/// /// <param name = "isEnable">是否启用，同一个operatorId只能启用一条</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetByIsEnable(bool isEnable)
		{
			return GetByIsEnable(isEnable, 0, string.Empty, null);
		}
		public async Task<List<L_pay_configEO>> GetByIsEnableAsync(bool isEnable)
		{
			return await GetByIsEnableAsync(isEnable, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsEnable（字段） 查询
		/// </summary>
		/// /// <param name = "isEnable">是否启用，同一个operatorId只能启用一条</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetByIsEnable(bool isEnable, TransactionManager tm_)
		{
			return GetByIsEnable(isEnable, 0, string.Empty, tm_);
		}
		public async Task<List<L_pay_configEO>> GetByIsEnableAsync(bool isEnable, TransactionManager tm_)
		{
			return await GetByIsEnableAsync(isEnable, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsEnable（字段） 查询
		/// </summary>
		/// /// <param name = "isEnable">是否启用，同一个operatorId只能启用一条</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetByIsEnable(bool isEnable, int top_)
		{
			return GetByIsEnable(isEnable, top_, string.Empty, null);
		}
		public async Task<List<L_pay_configEO>> GetByIsEnableAsync(bool isEnable, int top_)
		{
			return await GetByIsEnableAsync(isEnable, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsEnable（字段） 查询
		/// </summary>
		/// /// <param name = "isEnable">是否启用，同一个operatorId只能启用一条</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetByIsEnable(bool isEnable, int top_, TransactionManager tm_)
		{
			return GetByIsEnable(isEnable, top_, string.Empty, tm_);
		}
		public async Task<List<L_pay_configEO>> GetByIsEnableAsync(bool isEnable, int top_, TransactionManager tm_)
		{
			return await GetByIsEnableAsync(isEnable, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsEnable（字段） 查询
		/// </summary>
		/// /// <param name = "isEnable">是否启用，同一个operatorId只能启用一条</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetByIsEnable(bool isEnable, string sort_)
		{
			return GetByIsEnable(isEnable, 0, sort_, null);
		}
		public async Task<List<L_pay_configEO>> GetByIsEnableAsync(bool isEnable, string sort_)
		{
			return await GetByIsEnableAsync(isEnable, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 IsEnable（字段） 查询
		/// </summary>
		/// /// <param name = "isEnable">是否启用，同一个operatorId只能启用一条</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetByIsEnable(bool isEnable, string sort_, TransactionManager tm_)
		{
			return GetByIsEnable(isEnable, 0, sort_, tm_);
		}
		public async Task<List<L_pay_configEO>> GetByIsEnableAsync(bool isEnable, string sort_, TransactionManager tm_)
		{
			return await GetByIsEnableAsync(isEnable, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 IsEnable（字段） 查询
		/// </summary>
		/// /// <param name = "isEnable">是否启用，同一个operatorId只能启用一条</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetByIsEnable(bool isEnable, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsEnable` = @IsEnable", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsEnable", isEnable, MySqlDbType.Byte));
			return Database.ExecSqlList(sql_, paras_, tm_, L_pay_configEO.MapDataReader);
		}
		public async Task<List<L_pay_configEO>> GetByIsEnableAsync(bool isEnable, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsEnable` = @IsEnable", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsEnable", isEnable, MySqlDbType.Byte));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_pay_configEO.MapDataReader);
		}
		#endregion // GetByIsEnable
		#region GetByIsMainChannel
		
		/// <summary>
		/// 按 IsMainChannel（字段） 查询
		/// </summary>
		/// /// <param name = "isMainChannel">1-主渠道2-备用渠道</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetByIsMainChannel(bool isMainChannel)
		{
			return GetByIsMainChannel(isMainChannel, 0, string.Empty, null);
		}
		public async Task<List<L_pay_configEO>> GetByIsMainChannelAsync(bool isMainChannel)
		{
			return await GetByIsMainChannelAsync(isMainChannel, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsMainChannel（字段） 查询
		/// </summary>
		/// /// <param name = "isMainChannel">1-主渠道2-备用渠道</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetByIsMainChannel(bool isMainChannel, TransactionManager tm_)
		{
			return GetByIsMainChannel(isMainChannel, 0, string.Empty, tm_);
		}
		public async Task<List<L_pay_configEO>> GetByIsMainChannelAsync(bool isMainChannel, TransactionManager tm_)
		{
			return await GetByIsMainChannelAsync(isMainChannel, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsMainChannel（字段） 查询
		/// </summary>
		/// /// <param name = "isMainChannel">1-主渠道2-备用渠道</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetByIsMainChannel(bool isMainChannel, int top_)
		{
			return GetByIsMainChannel(isMainChannel, top_, string.Empty, null);
		}
		public async Task<List<L_pay_configEO>> GetByIsMainChannelAsync(bool isMainChannel, int top_)
		{
			return await GetByIsMainChannelAsync(isMainChannel, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsMainChannel（字段） 查询
		/// </summary>
		/// /// <param name = "isMainChannel">1-主渠道2-备用渠道</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetByIsMainChannel(bool isMainChannel, int top_, TransactionManager tm_)
		{
			return GetByIsMainChannel(isMainChannel, top_, string.Empty, tm_);
		}
		public async Task<List<L_pay_configEO>> GetByIsMainChannelAsync(bool isMainChannel, int top_, TransactionManager tm_)
		{
			return await GetByIsMainChannelAsync(isMainChannel, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsMainChannel（字段） 查询
		/// </summary>
		/// /// <param name = "isMainChannel">1-主渠道2-备用渠道</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetByIsMainChannel(bool isMainChannel, string sort_)
		{
			return GetByIsMainChannel(isMainChannel, 0, sort_, null);
		}
		public async Task<List<L_pay_configEO>> GetByIsMainChannelAsync(bool isMainChannel, string sort_)
		{
			return await GetByIsMainChannelAsync(isMainChannel, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 IsMainChannel（字段） 查询
		/// </summary>
		/// /// <param name = "isMainChannel">1-主渠道2-备用渠道</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetByIsMainChannel(bool isMainChannel, string sort_, TransactionManager tm_)
		{
			return GetByIsMainChannel(isMainChannel, 0, sort_, tm_);
		}
		public async Task<List<L_pay_configEO>> GetByIsMainChannelAsync(bool isMainChannel, string sort_, TransactionManager tm_)
		{
			return await GetByIsMainChannelAsync(isMainChannel, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 IsMainChannel（字段） 查询
		/// </summary>
		/// /// <param name = "isMainChannel">1-主渠道2-备用渠道</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetByIsMainChannel(bool isMainChannel, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsMainChannel` = @IsMainChannel", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsMainChannel", isMainChannel, MySqlDbType.Byte));
			return Database.ExecSqlList(sql_, paras_, tm_, L_pay_configEO.MapDataReader);
		}
		public async Task<List<L_pay_configEO>> GetByIsMainChannelAsync(bool isMainChannel, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsMainChannel` = @IsMainChannel", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsMainChannel", isMainChannel, MySqlDbType.Byte));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_pay_configEO.MapDataReader);
		}
		#endregion // GetByIsMainChannel
		#region GetByChannelsGroup
		
		/// <summary>
		/// 按 ChannelsGroup（字段） 查询
		/// </summary>
		/// /// <param name = "channelsGroup">充值渠道组</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetByChannelsGroup(int channelsGroup)
		{
			return GetByChannelsGroup(channelsGroup, 0, string.Empty, null);
		}
		public async Task<List<L_pay_configEO>> GetByChannelsGroupAsync(int channelsGroup)
		{
			return await GetByChannelsGroupAsync(channelsGroup, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ChannelsGroup（字段） 查询
		/// </summary>
		/// /// <param name = "channelsGroup">充值渠道组</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetByChannelsGroup(int channelsGroup, TransactionManager tm_)
		{
			return GetByChannelsGroup(channelsGroup, 0, string.Empty, tm_);
		}
		public async Task<List<L_pay_configEO>> GetByChannelsGroupAsync(int channelsGroup, TransactionManager tm_)
		{
			return await GetByChannelsGroupAsync(channelsGroup, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ChannelsGroup（字段） 查询
		/// </summary>
		/// /// <param name = "channelsGroup">充值渠道组</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetByChannelsGroup(int channelsGroup, int top_)
		{
			return GetByChannelsGroup(channelsGroup, top_, string.Empty, null);
		}
		public async Task<List<L_pay_configEO>> GetByChannelsGroupAsync(int channelsGroup, int top_)
		{
			return await GetByChannelsGroupAsync(channelsGroup, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ChannelsGroup（字段） 查询
		/// </summary>
		/// /// <param name = "channelsGroup">充值渠道组</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetByChannelsGroup(int channelsGroup, int top_, TransactionManager tm_)
		{
			return GetByChannelsGroup(channelsGroup, top_, string.Empty, tm_);
		}
		public async Task<List<L_pay_configEO>> GetByChannelsGroupAsync(int channelsGroup, int top_, TransactionManager tm_)
		{
			return await GetByChannelsGroupAsync(channelsGroup, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ChannelsGroup（字段） 查询
		/// </summary>
		/// /// <param name = "channelsGroup">充值渠道组</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetByChannelsGroup(int channelsGroup, string sort_)
		{
			return GetByChannelsGroup(channelsGroup, 0, sort_, null);
		}
		public async Task<List<L_pay_configEO>> GetByChannelsGroupAsync(int channelsGroup, string sort_)
		{
			return await GetByChannelsGroupAsync(channelsGroup, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ChannelsGroup（字段） 查询
		/// </summary>
		/// /// <param name = "channelsGroup">充值渠道组</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetByChannelsGroup(int channelsGroup, string sort_, TransactionManager tm_)
		{
			return GetByChannelsGroup(channelsGroup, 0, sort_, tm_);
		}
		public async Task<List<L_pay_configEO>> GetByChannelsGroupAsync(int channelsGroup, string sort_, TransactionManager tm_)
		{
			return await GetByChannelsGroupAsync(channelsGroup, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ChannelsGroup（字段） 查询
		/// </summary>
		/// /// <param name = "channelsGroup">充值渠道组</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetByChannelsGroup(int channelsGroup, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ChannelsGroup` = @ChannelsGroup", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ChannelsGroup", channelsGroup, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, L_pay_configEO.MapDataReader);
		}
		public async Task<List<L_pay_configEO>> GetByChannelsGroupAsync(int channelsGroup, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ChannelsGroup` = @ChannelsGroup", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ChannelsGroup", channelsGroup, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_pay_configEO.MapDataReader);
		}
		#endregion // GetByChannelsGroup
		#region GetByMinAmount
		
		/// <summary>
		/// 按 MinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "minAmount">最小充值金额</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetByMinAmount(long minAmount)
		{
			return GetByMinAmount(minAmount, 0, string.Empty, null);
		}
		public async Task<List<L_pay_configEO>> GetByMinAmountAsync(long minAmount)
		{
			return await GetByMinAmountAsync(minAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "minAmount">最小充值金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetByMinAmount(long minAmount, TransactionManager tm_)
		{
			return GetByMinAmount(minAmount, 0, string.Empty, tm_);
		}
		public async Task<List<L_pay_configEO>> GetByMinAmountAsync(long minAmount, TransactionManager tm_)
		{
			return await GetByMinAmountAsync(minAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "minAmount">最小充值金额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetByMinAmount(long minAmount, int top_)
		{
			return GetByMinAmount(minAmount, top_, string.Empty, null);
		}
		public async Task<List<L_pay_configEO>> GetByMinAmountAsync(long minAmount, int top_)
		{
			return await GetByMinAmountAsync(minAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "minAmount">最小充值金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetByMinAmount(long minAmount, int top_, TransactionManager tm_)
		{
			return GetByMinAmount(minAmount, top_, string.Empty, tm_);
		}
		public async Task<List<L_pay_configEO>> GetByMinAmountAsync(long minAmount, int top_, TransactionManager tm_)
		{
			return await GetByMinAmountAsync(minAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "minAmount">最小充值金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetByMinAmount(long minAmount, string sort_)
		{
			return GetByMinAmount(minAmount, 0, sort_, null);
		}
		public async Task<List<L_pay_configEO>> GetByMinAmountAsync(long minAmount, string sort_)
		{
			return await GetByMinAmountAsync(minAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 MinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "minAmount">最小充值金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetByMinAmount(long minAmount, string sort_, TransactionManager tm_)
		{
			return GetByMinAmount(minAmount, 0, sort_, tm_);
		}
		public async Task<List<L_pay_configEO>> GetByMinAmountAsync(long minAmount, string sort_, TransactionManager tm_)
		{
			return await GetByMinAmountAsync(minAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 MinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "minAmount">最小充值金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetByMinAmount(long minAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`MinAmount` = @MinAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MinAmount", minAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, L_pay_configEO.MapDataReader);
		}
		public async Task<List<L_pay_configEO>> GetByMinAmountAsync(long minAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`MinAmount` = @MinAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MinAmount", minAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_pay_configEO.MapDataReader);
		}
		#endregion // GetByMinAmount
		#region GetByMaxAmount
		
		/// <summary>
		/// 按 MaxAmount（字段） 查询
		/// </summary>
		/// /// <param name = "maxAmount">最大充值金额</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetByMaxAmount(long maxAmount)
		{
			return GetByMaxAmount(maxAmount, 0, string.Empty, null);
		}
		public async Task<List<L_pay_configEO>> GetByMaxAmountAsync(long maxAmount)
		{
			return await GetByMaxAmountAsync(maxAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MaxAmount（字段） 查询
		/// </summary>
		/// /// <param name = "maxAmount">最大充值金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetByMaxAmount(long maxAmount, TransactionManager tm_)
		{
			return GetByMaxAmount(maxAmount, 0, string.Empty, tm_);
		}
		public async Task<List<L_pay_configEO>> GetByMaxAmountAsync(long maxAmount, TransactionManager tm_)
		{
			return await GetByMaxAmountAsync(maxAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MaxAmount（字段） 查询
		/// </summary>
		/// /// <param name = "maxAmount">最大充值金额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetByMaxAmount(long maxAmount, int top_)
		{
			return GetByMaxAmount(maxAmount, top_, string.Empty, null);
		}
		public async Task<List<L_pay_configEO>> GetByMaxAmountAsync(long maxAmount, int top_)
		{
			return await GetByMaxAmountAsync(maxAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MaxAmount（字段） 查询
		/// </summary>
		/// /// <param name = "maxAmount">最大充值金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetByMaxAmount(long maxAmount, int top_, TransactionManager tm_)
		{
			return GetByMaxAmount(maxAmount, top_, string.Empty, tm_);
		}
		public async Task<List<L_pay_configEO>> GetByMaxAmountAsync(long maxAmount, int top_, TransactionManager tm_)
		{
			return await GetByMaxAmountAsync(maxAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MaxAmount（字段） 查询
		/// </summary>
		/// /// <param name = "maxAmount">最大充值金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetByMaxAmount(long maxAmount, string sort_)
		{
			return GetByMaxAmount(maxAmount, 0, sort_, null);
		}
		public async Task<List<L_pay_configEO>> GetByMaxAmountAsync(long maxAmount, string sort_)
		{
			return await GetByMaxAmountAsync(maxAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 MaxAmount（字段） 查询
		/// </summary>
		/// /// <param name = "maxAmount">最大充值金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetByMaxAmount(long maxAmount, string sort_, TransactionManager tm_)
		{
			return GetByMaxAmount(maxAmount, 0, sort_, tm_);
		}
		public async Task<List<L_pay_configEO>> GetByMaxAmountAsync(long maxAmount, string sort_, TransactionManager tm_)
		{
			return await GetByMaxAmountAsync(maxAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 MaxAmount（字段） 查询
		/// </summary>
		/// /// <param name = "maxAmount">最大充值金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetByMaxAmount(long maxAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`MaxAmount` = @MaxAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MaxAmount", maxAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, L_pay_configEO.MapDataReader);
		}
		public async Task<List<L_pay_configEO>> GetByMaxAmountAsync(long maxAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`MaxAmount` = @MaxAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MaxAmount", maxAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_pay_configEO.MapDataReader);
		}
		#endregion // GetByMaxAmount
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<L_pay_configEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<L_pay_configEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<L_pay_configEO>> GetByRecDateAsync(DateTime recDate, int top_)
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
		public List<L_pay_configEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<L_pay_configEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_pay_configEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<L_pay_configEO>> GetByRecDateAsync(DateTime recDate, string sort_)
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
		public List<L_pay_configEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<L_pay_configEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
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
		public List<L_pay_configEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, L_pay_configEO.MapDataReader);
		}
		public async Task<List<L_pay_configEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_pay_configEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
