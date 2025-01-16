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
	/// 充值金额配置
	/// 【表 l_pay_amount_config 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class L_pay_amount_configEO : IRowMapper<L_pay_amount_configEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public L_pay_amount_configEO()
		{
			this.ConfigID = "0";
			this.Channels = "0";
			this.PayAmount = 0;
			this.UserType = false;
			this.OrderNum = 0;
			this.IsSelected = false;
			this.HotFlag = 0;
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
		/// 充值渠道
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 5)]
		public string Channels { get; set; }
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
		/// 可用充值金额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 8)]
		public long PayAmount { get; set; }
		/// <summary>
		/// 0-未充值用户1-已充值用户
		/// 【字段 tinyint(1)】
		/// </summary>
		[DataMember(Order = 9)]
		public bool UserType { get; set; }
		/// <summary>
		/// 排序（从小到大）
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 10)]
		public int OrderNum { get; set; }
		/// <summary>
		/// 是否选中
		/// 【字段 tinyint(1)】
		/// </summary>
		[DataMember(Order = 11)]
		public bool IsSelected { get; set; }
		/// <summary>
		/// Hot角标
		/// 【字段 tinyint】
		/// </summary>
		[DataMember(Order = 12)]
		public int HotFlag { get; set; }
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
		public L_pay_amount_configEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static L_pay_amount_configEO MapDataReader(IDataReader reader)
		{
		    L_pay_amount_configEO ret = new L_pay_amount_configEO();
			ret.ConfigID = reader.ToString("ConfigID");
			ret.OriginalConfigID = ret.ConfigID;
			ret.OperatorID = reader.ToString("OperatorID");
			ret.CountryId = reader.ToString("CountryId");
			ret.CurrencyID = reader.ToString("CurrencyID");
			ret.Channels = reader.ToString("Channels");
			ret.ChannelsDesc = reader.ToString("ChannelsDesc");
			ret.SubChannel = reader.ToString("SubChannel");
			ret.PayAmount = reader.ToInt64("PayAmount");
			ret.UserType = reader.ToBoolean("UserType");
			ret.OrderNum = reader.ToInt32("OrderNum");
			ret.IsSelected = reader.ToBoolean("IsSelected");
			ret.HotFlag = reader.ToInt32("HotFlag");
			ret.RecDate = reader.ToDateTime("RecDate");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 充值金额配置
	/// 【表 l_pay_amount_config 的操作类】
	/// </summary>
	[Obsolete]
	public class L_pay_amount_configMO : MySqlTableMO<L_pay_amount_configEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`l_pay_amount_config`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public L_pay_amount_configMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public L_pay_amount_configMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public L_pay_amount_configMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(L_pay_amount_configEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(L_pay_amount_configEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(L_pay_amount_configEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`ConfigID`, `OperatorID`, `CountryId`, `CurrencyID`, `Channels`, `ChannelsDesc`, `SubChannel`, `PayAmount`, `UserType`, `OrderNum`, `IsSelected`, `HotFlag`, `RecDate`) VALUE (@ConfigID, @OperatorID, @CountryId, @CurrencyID, @Channels, @ChannelsDesc, @SubChannel, @PayAmount, @UserType, @OrderNum, @IsSelected, @HotFlag, @RecDate);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", item.ConfigID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryId", item.CountryId, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Channels", item.Channels, MySqlDbType.VarChar),
				Database.CreateInParameter("@ChannelsDesc", item.ChannelsDesc, MySqlDbType.VarChar),
				Database.CreateInParameter("@SubChannel", item.SubChannel != null ? item.SubChannel : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@PayAmount", item.PayAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@UserType", item.UserType, MySqlDbType.Byte),
				Database.CreateInParameter("@OrderNum", item.OrderNum, MySqlDbType.Int32),
				Database.CreateInParameter("@IsSelected", item.IsSelected, MySqlDbType.Byte),
				Database.CreateInParameter("@HotFlag", item.HotFlag, MySqlDbType.Byte),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
			};
		}
		public int AddByBatch(IEnumerable<L_pay_amount_configEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<L_pay_amount_configEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<L_pay_amount_configEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`ConfigID`, `OperatorID`, `CountryId`, `CurrencyID`, `Channels`, `ChannelsDesc`, `SubChannel`, `PayAmount`, `UserType`, `OrderNum`, `IsSelected`, `HotFlag`, `RecDate`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.ConfigID}','{item.OperatorID}','{item.CountryId}','{item.CurrencyID}','{item.Channels}','{item.ChannelsDesc}','{item.SubChannel}',{item.PayAmount},{item.UserType},{item.OrderNum},{item.IsSelected},{item.HotFlag},'{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
		public int Remove(L_pay_amount_configEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.ConfigID, tm_);
		}
		public async Task<int> RemoveAsync(L_pay_amount_configEO item, TransactionManager tm_ = null)
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
		/// /// <param name = "channels">充值渠道</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByChannels(string channels, TransactionManager tm_ = null)
		{
			RepairRemoveByChannelsData(channels, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByChannelsAsync(string channels, TransactionManager tm_ = null)
		{
			RepairRemoveByChannelsData(channels, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByChannelsData(string channels, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Channels` = @Channels";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Channels", channels, MySqlDbType.VarChar));
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
		#region RemoveByPayAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "payAmount">可用充值金额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPayAmount(long payAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByPayAmountData(payAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPayAmountAsync(long payAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByPayAmountData(payAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByPayAmountData(long payAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `PayAmount` = @PayAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PayAmount", payAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByPayAmount
		#region RemoveByUserType
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "userType">0-未充值用户1-已充值用户</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByUserType(bool userType, TransactionManager tm_ = null)
		{
			RepairRemoveByUserTypeData(userType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByUserTypeAsync(bool userType, TransactionManager tm_ = null)
		{
			RepairRemoveByUserTypeData(userType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByUserTypeData(bool userType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `UserType` = @UserType";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserType", userType, MySqlDbType.Byte));
		}
		#endregion // RemoveByUserType
		#region RemoveByOrderNum
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "orderNum">排序（从小到大）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByOrderNum(int orderNum, TransactionManager tm_ = null)
		{
			RepairRemoveByOrderNumData(orderNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByOrderNumAsync(int orderNum, TransactionManager tm_ = null)
		{
			RepairRemoveByOrderNumData(orderNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByOrderNumData(int orderNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `OrderNum` = @OrderNum";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OrderNum", orderNum, MySqlDbType.Int32));
		}
		#endregion // RemoveByOrderNum
		#region RemoveByIsSelected
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "isSelected">是否选中</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByIsSelected(bool isSelected, TransactionManager tm_ = null)
		{
			RepairRemoveByIsSelectedData(isSelected, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByIsSelectedAsync(bool isSelected, TransactionManager tm_ = null)
		{
			RepairRemoveByIsSelectedData(isSelected, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByIsSelectedData(bool isSelected, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `IsSelected` = @IsSelected";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsSelected", isSelected, MySqlDbType.Byte));
		}
		#endregion // RemoveByIsSelected
		#region RemoveByHotFlag
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "hotFlag">Hot角标</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByHotFlag(int hotFlag, TransactionManager tm_ = null)
		{
			RepairRemoveByHotFlagData(hotFlag, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByHotFlagAsync(int hotFlag, TransactionManager tm_ = null)
		{
			RepairRemoveByHotFlagData(hotFlag, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByHotFlagData(int hotFlag, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `HotFlag` = @HotFlag";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@HotFlag", hotFlag, MySqlDbType.Byte));
		}
		#endregion // RemoveByHotFlag
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
		public int Put(L_pay_amount_configEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(L_pay_amount_configEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(L_pay_amount_configEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ConfigID` = @ConfigID, `OperatorID` = @OperatorID, `CountryId` = @CountryId, `CurrencyID` = @CurrencyID, `Channels` = @Channels, `ChannelsDesc` = @ChannelsDesc, `SubChannel` = @SubChannel, `PayAmount` = @PayAmount, `UserType` = @UserType, `OrderNum` = @OrderNum, `IsSelected` = @IsSelected, `HotFlag` = @HotFlag WHERE `ConfigID` = @ConfigID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", item.ConfigID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryId", item.CountryId, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Channels", item.Channels, MySqlDbType.VarChar),
				Database.CreateInParameter("@ChannelsDesc", item.ChannelsDesc, MySqlDbType.VarChar),
				Database.CreateInParameter("@SubChannel", item.SubChannel != null ? item.SubChannel : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@PayAmount", item.PayAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@UserType", item.UserType, MySqlDbType.Byte),
				Database.CreateInParameter("@OrderNum", item.OrderNum, MySqlDbType.Int32),
				Database.CreateInParameter("@IsSelected", item.IsSelected, MySqlDbType.Byte),
				Database.CreateInParameter("@HotFlag", item.HotFlag, MySqlDbType.Byte),
				Database.CreateInParameter("@ConfigID_Original", item.HasOriginal ? item.OriginalConfigID : item.ConfigID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<L_pay_amount_configEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<L_pay_amount_configEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "channels">充值渠道</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutChannelsByPK(string configID, string channels, TransactionManager tm_ = null)
		{
			RepairPutChannelsByPKData(configID, channels, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutChannelsByPKAsync(string configID, string channels, TransactionManager tm_ = null)
		{
			RepairPutChannelsByPKData(configID, channels, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutChannelsByPKData(string configID, string channels, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Channels` = @Channels  WHERE `ConfigID` = @ConfigID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Channels", channels, MySqlDbType.VarChar),
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "channels">充值渠道</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutChannels(string channels, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Channels` = @Channels";
			var parameter_ = Database.CreateInParameter("@Channels", channels, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutChannelsAsync(string channels, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Channels` = @Channels";
			var parameter_ = Database.CreateInParameter("@Channels", channels, MySqlDbType.VarChar);
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
		#region PutPayAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "configID">主键GUID</param>
		/// /// <param name = "payAmount">可用充值金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPayAmountByPK(string configID, long payAmount, TransactionManager tm_ = null)
		{
			RepairPutPayAmountByPKData(configID, payAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutPayAmountByPKAsync(string configID, long payAmount, TransactionManager tm_ = null)
		{
			RepairPutPayAmountByPKData(configID, payAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutPayAmountByPKData(string configID, long payAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `PayAmount` = @PayAmount  WHERE `ConfigID` = @ConfigID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PayAmount", payAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "payAmount">可用充值金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPayAmount(long payAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PayAmount` = @PayAmount";
			var parameter_ = Database.CreateInParameter("@PayAmount", payAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutPayAmountAsync(long payAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PayAmount` = @PayAmount";
			var parameter_ = Database.CreateInParameter("@PayAmount", payAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutPayAmount
		#region PutUserType
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "configID">主键GUID</param>
		/// /// <param name = "userType">0-未充值用户1-已充值用户</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserTypeByPK(string configID, bool userType, TransactionManager tm_ = null)
		{
			RepairPutUserTypeByPKData(configID, userType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutUserTypeByPKAsync(string configID, bool userType, TransactionManager tm_ = null)
		{
			RepairPutUserTypeByPKData(configID, userType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutUserTypeByPKData(string configID, bool userType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UserType` = @UserType  WHERE `ConfigID` = @ConfigID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserType", userType, MySqlDbType.Byte),
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "userType">0-未充值用户1-已充值用户</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserType(bool userType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserType` = @UserType";
			var parameter_ = Database.CreateInParameter("@UserType", userType, MySqlDbType.Byte);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutUserTypeAsync(bool userType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserType` = @UserType";
			var parameter_ = Database.CreateInParameter("@UserType", userType, MySqlDbType.Byte);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutUserType
		#region PutOrderNum
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "configID">主键GUID</param>
		/// /// <param name = "orderNum">排序（从小到大）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOrderNumByPK(string configID, int orderNum, TransactionManager tm_ = null)
		{
			RepairPutOrderNumByPKData(configID, orderNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOrderNumByPKAsync(string configID, int orderNum, TransactionManager tm_ = null)
		{
			RepairPutOrderNumByPKData(configID, orderNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOrderNumByPKData(string configID, int orderNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OrderNum` = @OrderNum  WHERE `ConfigID` = @ConfigID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderNum", orderNum, MySqlDbType.Int32),
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "orderNum">排序（从小到大）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOrderNum(int orderNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OrderNum` = @OrderNum";
			var parameter_ = Database.CreateInParameter("@OrderNum", orderNum, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutOrderNumAsync(int orderNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OrderNum` = @OrderNum";
			var parameter_ = Database.CreateInParameter("@OrderNum", orderNum, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutOrderNum
		#region PutIsSelected
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "configID">主键GUID</param>
		/// /// <param name = "isSelected">是否选中</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsSelectedByPK(string configID, bool isSelected, TransactionManager tm_ = null)
		{
			RepairPutIsSelectedByPKData(configID, isSelected, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutIsSelectedByPKAsync(string configID, bool isSelected, TransactionManager tm_ = null)
		{
			RepairPutIsSelectedByPKData(configID, isSelected, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutIsSelectedByPKData(string configID, bool isSelected, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `IsSelected` = @IsSelected  WHERE `ConfigID` = @ConfigID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@IsSelected", isSelected, MySqlDbType.Byte),
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "isSelected">是否选中</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsSelected(bool isSelected, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsSelected` = @IsSelected";
			var parameter_ = Database.CreateInParameter("@IsSelected", isSelected, MySqlDbType.Byte);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutIsSelectedAsync(bool isSelected, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsSelected` = @IsSelected";
			var parameter_ = Database.CreateInParameter("@IsSelected", isSelected, MySqlDbType.Byte);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutIsSelected
		#region PutHotFlag
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "configID">主键GUID</param>
		/// /// <param name = "hotFlag">Hot角标</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutHotFlagByPK(string configID, int hotFlag, TransactionManager tm_ = null)
		{
			RepairPutHotFlagByPKData(configID, hotFlag, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutHotFlagByPKAsync(string configID, int hotFlag, TransactionManager tm_ = null)
		{
			RepairPutHotFlagByPKData(configID, hotFlag, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutHotFlagByPKData(string configID, int hotFlag, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `HotFlag` = @HotFlag  WHERE `ConfigID` = @ConfigID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@HotFlag", hotFlag, MySqlDbType.Byte),
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "hotFlag">Hot角标</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutHotFlag(int hotFlag, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `HotFlag` = @HotFlag";
			var parameter_ = Database.CreateInParameter("@HotFlag", hotFlag, MySqlDbType.Byte);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutHotFlagAsync(int hotFlag, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `HotFlag` = @HotFlag";
			var parameter_ = Database.CreateInParameter("@HotFlag", hotFlag, MySqlDbType.Byte);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutHotFlag
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
		public bool Set(L_pay_amount_configEO item, TransactionManager tm = null)
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
		public async Task<bool> SetAsync(L_pay_amount_configEO item, TransactionManager tm = null)
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
		public L_pay_amount_configEO GetByPK(string configID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(configID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, L_pay_amount_configEO.MapDataReader);
		}
		public async Task<L_pay_amount_configEO> GetByPKAsync(string configID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(configID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, L_pay_amount_configEO.MapDataReader);
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
		public string GetChannelsByPK(string configID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Channels`", "`ConfigID` = @ConfigID", paras_, tm_);
		}
		public async Task<string> GetChannelsByPKAsync(string configID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Channels`", "`ConfigID` = @ConfigID", paras_, tm_);
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
		/// 按主键查询 PayAmount（字段）
		/// </summary>
		/// /// <param name = "configID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetPayAmountByPK(string configID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`PayAmount`", "`ConfigID` = @ConfigID", paras_, tm_);
		}
		public async Task<long> GetPayAmountByPKAsync(string configID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`PayAmount`", "`ConfigID` = @ConfigID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 UserType（字段）
		/// </summary>
		/// /// <param name = "configID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public bool GetUserTypeByPK(string configID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
			return (bool)GetScalar("`UserType`", "`ConfigID` = @ConfigID", paras_, tm_);
		}
		public async Task<bool> GetUserTypeByPKAsync(string configID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
			return (bool)await GetScalarAsync("`UserType`", "`ConfigID` = @ConfigID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OrderNum（字段）
		/// </summary>
		/// /// <param name = "configID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetOrderNumByPK(string configID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`OrderNum`", "`ConfigID` = @ConfigID", paras_, tm_);
		}
		public async Task<int> GetOrderNumByPKAsync(string configID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`OrderNum`", "`ConfigID` = @ConfigID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 IsSelected（字段）
		/// </summary>
		/// /// <param name = "configID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public bool GetIsSelectedByPK(string configID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
			return (bool)GetScalar("`IsSelected`", "`ConfigID` = @ConfigID", paras_, tm_);
		}
		public async Task<bool> GetIsSelectedByPKAsync(string configID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
			return (bool)await GetScalarAsync("`IsSelected`", "`ConfigID` = @ConfigID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 HotFlag（字段）
		/// </summary>
		/// /// <param name = "configID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetHotFlagByPK(string configID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`HotFlag`", "`ConfigID` = @ConfigID", paras_, tm_);
		}
		public async Task<int> GetHotFlagByPKAsync(string configID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConfigID", configID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`HotFlag`", "`ConfigID` = @ConfigID", paras_, tm_);
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
		public List<L_pay_amount_configEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<L_pay_amount_configEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_pay_amount_configEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<L_pay_amount_configEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_pay_amount_configEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<L_pay_amount_configEO>> GetByOperatorIDAsync(string operatorID, int top_)
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
		public List<L_pay_amount_configEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<L_pay_amount_configEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_pay_amount_configEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<L_pay_amount_configEO>> GetByOperatorIDAsync(string operatorID, string sort_)
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
		public List<L_pay_amount_configEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<L_pay_amount_configEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
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
		public List<L_pay_amount_configEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_pay_amount_configEO.MapDataReader);
		}
		public async Task<List<L_pay_amount_configEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_pay_amount_configEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByCountryId
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <return>实体对象集合</return>
		public List<L_pay_amount_configEO> GetByCountryId(string countryId)
		{
			return GetByCountryId(countryId, 0, string.Empty, null);
		}
		public async Task<List<L_pay_amount_configEO>> GetByCountryIdAsync(string countryId)
		{
			return await GetByCountryIdAsync(countryId, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_pay_amount_configEO> GetByCountryId(string countryId, TransactionManager tm_)
		{
			return GetByCountryId(countryId, 0, string.Empty, tm_);
		}
		public async Task<List<L_pay_amount_configEO>> GetByCountryIdAsync(string countryId, TransactionManager tm_)
		{
			return await GetByCountryIdAsync(countryId, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_pay_amount_configEO> GetByCountryId(string countryId, int top_)
		{
			return GetByCountryId(countryId, top_, string.Empty, null);
		}
		public async Task<List<L_pay_amount_configEO>> GetByCountryIdAsync(string countryId, int top_)
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
		public List<L_pay_amount_configEO> GetByCountryId(string countryId, int top_, TransactionManager tm_)
		{
			return GetByCountryId(countryId, top_, string.Empty, tm_);
		}
		public async Task<List<L_pay_amount_configEO>> GetByCountryIdAsync(string countryId, int top_, TransactionManager tm_)
		{
			return await GetByCountryIdAsync(countryId, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_pay_amount_configEO> GetByCountryId(string countryId, string sort_)
		{
			return GetByCountryId(countryId, 0, sort_, null);
		}
		public async Task<List<L_pay_amount_configEO>> GetByCountryIdAsync(string countryId, string sort_)
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
		public List<L_pay_amount_configEO> GetByCountryId(string countryId, string sort_, TransactionManager tm_)
		{
			return GetByCountryId(countryId, 0, sort_, tm_);
		}
		public async Task<List<L_pay_amount_configEO>> GetByCountryIdAsync(string countryId, string sort_, TransactionManager tm_)
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
		public List<L_pay_amount_configEO> GetByCountryId(string countryId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CountryId` = @CountryId", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_pay_amount_configEO.MapDataReader);
		}
		public async Task<List<L_pay_amount_configEO>> GetByCountryIdAsync(string countryId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CountryId` = @CountryId", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_pay_amount_configEO.MapDataReader);
		}
		#endregion // GetByCountryId
		#region GetByCurrencyID
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <return>实体对象集合</return>
		public List<L_pay_amount_configEO> GetByCurrencyID(string currencyID)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, null);
		}
		public async Task<List<L_pay_amount_configEO>> GetByCurrencyIDAsync(string currencyID)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_pay_amount_configEO> GetByCurrencyID(string currencyID, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, tm_);
		}
		public async Task<List<L_pay_amount_configEO>> GetByCurrencyIDAsync(string currencyID, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_pay_amount_configEO> GetByCurrencyID(string currencyID, int top_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, null);
		}
		public async Task<List<L_pay_amount_configEO>> GetByCurrencyIDAsync(string currencyID, int top_)
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
		public List<L_pay_amount_configEO> GetByCurrencyID(string currencyID, int top_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, tm_);
		}
		public async Task<List<L_pay_amount_configEO>> GetByCurrencyIDAsync(string currencyID, int top_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_pay_amount_configEO> GetByCurrencyID(string currencyID, string sort_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, null);
		}
		public async Task<List<L_pay_amount_configEO>> GetByCurrencyIDAsync(string currencyID, string sort_)
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
		public List<L_pay_amount_configEO> GetByCurrencyID(string currencyID, string sort_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, tm_);
		}
		public async Task<List<L_pay_amount_configEO>> GetByCurrencyIDAsync(string currencyID, string sort_, TransactionManager tm_)
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
		public List<L_pay_amount_configEO> GetByCurrencyID(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_pay_amount_configEO.MapDataReader);
		}
		public async Task<List<L_pay_amount_configEO>> GetByCurrencyIDAsync(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_pay_amount_configEO.MapDataReader);
		}
		#endregion // GetByCurrencyID
		#region GetByChannels
		
		/// <summary>
		/// 按 Channels（字段） 查询
		/// </summary>
		/// /// <param name = "channels">充值渠道</param>
		/// <return>实体对象集合</return>
		public List<L_pay_amount_configEO> GetByChannels(string channels)
		{
			return GetByChannels(channels, 0, string.Empty, null);
		}
		public async Task<List<L_pay_amount_configEO>> GetByChannelsAsync(string channels)
		{
			return await GetByChannelsAsync(channels, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Channels（字段） 查询
		/// </summary>
		/// /// <param name = "channels">充值渠道</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_pay_amount_configEO> GetByChannels(string channels, TransactionManager tm_)
		{
			return GetByChannels(channels, 0, string.Empty, tm_);
		}
		public async Task<List<L_pay_amount_configEO>> GetByChannelsAsync(string channels, TransactionManager tm_)
		{
			return await GetByChannelsAsync(channels, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Channels（字段） 查询
		/// </summary>
		/// /// <param name = "channels">充值渠道</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_pay_amount_configEO> GetByChannels(string channels, int top_)
		{
			return GetByChannels(channels, top_, string.Empty, null);
		}
		public async Task<List<L_pay_amount_configEO>> GetByChannelsAsync(string channels, int top_)
		{
			return await GetByChannelsAsync(channels, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Channels（字段） 查询
		/// </summary>
		/// /// <param name = "channels">充值渠道</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_pay_amount_configEO> GetByChannels(string channels, int top_, TransactionManager tm_)
		{
			return GetByChannels(channels, top_, string.Empty, tm_);
		}
		public async Task<List<L_pay_amount_configEO>> GetByChannelsAsync(string channels, int top_, TransactionManager tm_)
		{
			return await GetByChannelsAsync(channels, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Channels（字段） 查询
		/// </summary>
		/// /// <param name = "channels">充值渠道</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_pay_amount_configEO> GetByChannels(string channels, string sort_)
		{
			return GetByChannels(channels, 0, sort_, null);
		}
		public async Task<List<L_pay_amount_configEO>> GetByChannelsAsync(string channels, string sort_)
		{
			return await GetByChannelsAsync(channels, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Channels（字段） 查询
		/// </summary>
		/// /// <param name = "channels">充值渠道</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_pay_amount_configEO> GetByChannels(string channels, string sort_, TransactionManager tm_)
		{
			return GetByChannels(channels, 0, sort_, tm_);
		}
		public async Task<List<L_pay_amount_configEO>> GetByChannelsAsync(string channels, string sort_, TransactionManager tm_)
		{
			return await GetByChannelsAsync(channels, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Channels（字段） 查询
		/// </summary>
		/// /// <param name = "channels">充值渠道</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_pay_amount_configEO> GetByChannels(string channels, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Channels` = @Channels", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Channels", channels, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_pay_amount_configEO.MapDataReader);
		}
		public async Task<List<L_pay_amount_configEO>> GetByChannelsAsync(string channels, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Channels` = @Channels", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Channels", channels, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_pay_amount_configEO.MapDataReader);
		}
		#endregion // GetByChannels
		#region GetByChannelsDesc
		
		/// <summary>
		/// 按 ChannelsDesc（字段） 查询
		/// </summary>
		/// /// <param name = "channelsDesc">充值渠道描述,对应channels</param>
		/// <return>实体对象集合</return>
		public List<L_pay_amount_configEO> GetByChannelsDesc(string channelsDesc)
		{
			return GetByChannelsDesc(channelsDesc, 0, string.Empty, null);
		}
		public async Task<List<L_pay_amount_configEO>> GetByChannelsDescAsync(string channelsDesc)
		{
			return await GetByChannelsDescAsync(channelsDesc, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ChannelsDesc（字段） 查询
		/// </summary>
		/// /// <param name = "channelsDesc">充值渠道描述,对应channels</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_pay_amount_configEO> GetByChannelsDesc(string channelsDesc, TransactionManager tm_)
		{
			return GetByChannelsDesc(channelsDesc, 0, string.Empty, tm_);
		}
		public async Task<List<L_pay_amount_configEO>> GetByChannelsDescAsync(string channelsDesc, TransactionManager tm_)
		{
			return await GetByChannelsDescAsync(channelsDesc, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ChannelsDesc（字段） 查询
		/// </summary>
		/// /// <param name = "channelsDesc">充值渠道描述,对应channels</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_pay_amount_configEO> GetByChannelsDesc(string channelsDesc, int top_)
		{
			return GetByChannelsDesc(channelsDesc, top_, string.Empty, null);
		}
		public async Task<List<L_pay_amount_configEO>> GetByChannelsDescAsync(string channelsDesc, int top_)
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
		public List<L_pay_amount_configEO> GetByChannelsDesc(string channelsDesc, int top_, TransactionManager tm_)
		{
			return GetByChannelsDesc(channelsDesc, top_, string.Empty, tm_);
		}
		public async Task<List<L_pay_amount_configEO>> GetByChannelsDescAsync(string channelsDesc, int top_, TransactionManager tm_)
		{
			return await GetByChannelsDescAsync(channelsDesc, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ChannelsDesc（字段） 查询
		/// </summary>
		/// /// <param name = "channelsDesc">充值渠道描述,对应channels</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_pay_amount_configEO> GetByChannelsDesc(string channelsDesc, string sort_)
		{
			return GetByChannelsDesc(channelsDesc, 0, sort_, null);
		}
		public async Task<List<L_pay_amount_configEO>> GetByChannelsDescAsync(string channelsDesc, string sort_)
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
		public List<L_pay_amount_configEO> GetByChannelsDesc(string channelsDesc, string sort_, TransactionManager tm_)
		{
			return GetByChannelsDesc(channelsDesc, 0, sort_, tm_);
		}
		public async Task<List<L_pay_amount_configEO>> GetByChannelsDescAsync(string channelsDesc, string sort_, TransactionManager tm_)
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
		public List<L_pay_amount_configEO> GetByChannelsDesc(string channelsDesc, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ChannelsDesc` = @ChannelsDesc", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ChannelsDesc", channelsDesc, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_pay_amount_configEO.MapDataReader);
		}
		public async Task<List<L_pay_amount_configEO>> GetByChannelsDescAsync(string channelsDesc, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ChannelsDesc` = @ChannelsDesc", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ChannelsDesc", channelsDesc, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_pay_amount_configEO.MapDataReader);
		}
		#endregion // GetByChannelsDesc
		#region GetBySubChannel
		
		/// <summary>
		/// 按 SubChannel（字段） 查询
		/// </summary>
		/// /// <param name = "subChannel">子通道(如加纳mtn-gh等)</param>
		/// <return>实体对象集合</return>
		public List<L_pay_amount_configEO> GetBySubChannel(string subChannel)
		{
			return GetBySubChannel(subChannel, 0, string.Empty, null);
		}
		public async Task<List<L_pay_amount_configEO>> GetBySubChannelAsync(string subChannel)
		{
			return await GetBySubChannelAsync(subChannel, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SubChannel（字段） 查询
		/// </summary>
		/// /// <param name = "subChannel">子通道(如加纳mtn-gh等)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_pay_amount_configEO> GetBySubChannel(string subChannel, TransactionManager tm_)
		{
			return GetBySubChannel(subChannel, 0, string.Empty, tm_);
		}
		public async Task<List<L_pay_amount_configEO>> GetBySubChannelAsync(string subChannel, TransactionManager tm_)
		{
			return await GetBySubChannelAsync(subChannel, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SubChannel（字段） 查询
		/// </summary>
		/// /// <param name = "subChannel">子通道(如加纳mtn-gh等)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_pay_amount_configEO> GetBySubChannel(string subChannel, int top_)
		{
			return GetBySubChannel(subChannel, top_, string.Empty, null);
		}
		public async Task<List<L_pay_amount_configEO>> GetBySubChannelAsync(string subChannel, int top_)
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
		public List<L_pay_amount_configEO> GetBySubChannel(string subChannel, int top_, TransactionManager tm_)
		{
			return GetBySubChannel(subChannel, top_, string.Empty, tm_);
		}
		public async Task<List<L_pay_amount_configEO>> GetBySubChannelAsync(string subChannel, int top_, TransactionManager tm_)
		{
			return await GetBySubChannelAsync(subChannel, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SubChannel（字段） 查询
		/// </summary>
		/// /// <param name = "subChannel">子通道(如加纳mtn-gh等)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_pay_amount_configEO> GetBySubChannel(string subChannel, string sort_)
		{
			return GetBySubChannel(subChannel, 0, sort_, null);
		}
		public async Task<List<L_pay_amount_configEO>> GetBySubChannelAsync(string subChannel, string sort_)
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
		public List<L_pay_amount_configEO> GetBySubChannel(string subChannel, string sort_, TransactionManager tm_)
		{
			return GetBySubChannel(subChannel, 0, sort_, tm_);
		}
		public async Task<List<L_pay_amount_configEO>> GetBySubChannelAsync(string subChannel, string sort_, TransactionManager tm_)
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
		public List<L_pay_amount_configEO> GetBySubChannel(string subChannel, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(subChannel != null ? "`SubChannel` = @SubChannel" : "`SubChannel` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (subChannel != null)
				paras_.Add(Database.CreateInParameter("@SubChannel", subChannel, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_pay_amount_configEO.MapDataReader);
		}
		public async Task<List<L_pay_amount_configEO>> GetBySubChannelAsync(string subChannel, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(subChannel != null ? "`SubChannel` = @SubChannel" : "`SubChannel` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (subChannel != null)
				paras_.Add(Database.CreateInParameter("@SubChannel", subChannel, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_pay_amount_configEO.MapDataReader);
		}
		#endregion // GetBySubChannel
		#region GetByPayAmount
		
		/// <summary>
		/// 按 PayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "payAmount">可用充值金额</param>
		/// <return>实体对象集合</return>
		public List<L_pay_amount_configEO> GetByPayAmount(long payAmount)
		{
			return GetByPayAmount(payAmount, 0, string.Empty, null);
		}
		public async Task<List<L_pay_amount_configEO>> GetByPayAmountAsync(long payAmount)
		{
			return await GetByPayAmountAsync(payAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "payAmount">可用充值金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_pay_amount_configEO> GetByPayAmount(long payAmount, TransactionManager tm_)
		{
			return GetByPayAmount(payAmount, 0, string.Empty, tm_);
		}
		public async Task<List<L_pay_amount_configEO>> GetByPayAmountAsync(long payAmount, TransactionManager tm_)
		{
			return await GetByPayAmountAsync(payAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "payAmount">可用充值金额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_pay_amount_configEO> GetByPayAmount(long payAmount, int top_)
		{
			return GetByPayAmount(payAmount, top_, string.Empty, null);
		}
		public async Task<List<L_pay_amount_configEO>> GetByPayAmountAsync(long payAmount, int top_)
		{
			return await GetByPayAmountAsync(payAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "payAmount">可用充值金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_pay_amount_configEO> GetByPayAmount(long payAmount, int top_, TransactionManager tm_)
		{
			return GetByPayAmount(payAmount, top_, string.Empty, tm_);
		}
		public async Task<List<L_pay_amount_configEO>> GetByPayAmountAsync(long payAmount, int top_, TransactionManager tm_)
		{
			return await GetByPayAmountAsync(payAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "payAmount">可用充值金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_pay_amount_configEO> GetByPayAmount(long payAmount, string sort_)
		{
			return GetByPayAmount(payAmount, 0, sort_, null);
		}
		public async Task<List<L_pay_amount_configEO>> GetByPayAmountAsync(long payAmount, string sort_)
		{
			return await GetByPayAmountAsync(payAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "payAmount">可用充值金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_pay_amount_configEO> GetByPayAmount(long payAmount, string sort_, TransactionManager tm_)
		{
			return GetByPayAmount(payAmount, 0, sort_, tm_);
		}
		public async Task<List<L_pay_amount_configEO>> GetByPayAmountAsync(long payAmount, string sort_, TransactionManager tm_)
		{
			return await GetByPayAmountAsync(payAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "payAmount">可用充值金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_pay_amount_configEO> GetByPayAmount(long payAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PayAmount` = @PayAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PayAmount", payAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, L_pay_amount_configEO.MapDataReader);
		}
		public async Task<List<L_pay_amount_configEO>> GetByPayAmountAsync(long payAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PayAmount` = @PayAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PayAmount", payAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_pay_amount_configEO.MapDataReader);
		}
		#endregion // GetByPayAmount
		#region GetByUserType
		
		/// <summary>
		/// 按 UserType（字段） 查询
		/// </summary>
		/// /// <param name = "userType">0-未充值用户1-已充值用户</param>
		/// <return>实体对象集合</return>
		public List<L_pay_amount_configEO> GetByUserType(bool userType)
		{
			return GetByUserType(userType, 0, string.Empty, null);
		}
		public async Task<List<L_pay_amount_configEO>> GetByUserTypeAsync(bool userType)
		{
			return await GetByUserTypeAsync(userType, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserType（字段） 查询
		/// </summary>
		/// /// <param name = "userType">0-未充值用户1-已充值用户</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_pay_amount_configEO> GetByUserType(bool userType, TransactionManager tm_)
		{
			return GetByUserType(userType, 0, string.Empty, tm_);
		}
		public async Task<List<L_pay_amount_configEO>> GetByUserTypeAsync(bool userType, TransactionManager tm_)
		{
			return await GetByUserTypeAsync(userType, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserType（字段） 查询
		/// </summary>
		/// /// <param name = "userType">0-未充值用户1-已充值用户</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_pay_amount_configEO> GetByUserType(bool userType, int top_)
		{
			return GetByUserType(userType, top_, string.Empty, null);
		}
		public async Task<List<L_pay_amount_configEO>> GetByUserTypeAsync(bool userType, int top_)
		{
			return await GetByUserTypeAsync(userType, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserType（字段） 查询
		/// </summary>
		/// /// <param name = "userType">0-未充值用户1-已充值用户</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_pay_amount_configEO> GetByUserType(bool userType, int top_, TransactionManager tm_)
		{
			return GetByUserType(userType, top_, string.Empty, tm_);
		}
		public async Task<List<L_pay_amount_configEO>> GetByUserTypeAsync(bool userType, int top_, TransactionManager tm_)
		{
			return await GetByUserTypeAsync(userType, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserType（字段） 查询
		/// </summary>
		/// /// <param name = "userType">0-未充值用户1-已充值用户</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_pay_amount_configEO> GetByUserType(bool userType, string sort_)
		{
			return GetByUserType(userType, 0, sort_, null);
		}
		public async Task<List<L_pay_amount_configEO>> GetByUserTypeAsync(bool userType, string sort_)
		{
			return await GetByUserTypeAsync(userType, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 UserType（字段） 查询
		/// </summary>
		/// /// <param name = "userType">0-未充值用户1-已充值用户</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_pay_amount_configEO> GetByUserType(bool userType, string sort_, TransactionManager tm_)
		{
			return GetByUserType(userType, 0, sort_, tm_);
		}
		public async Task<List<L_pay_amount_configEO>> GetByUserTypeAsync(bool userType, string sort_, TransactionManager tm_)
		{
			return await GetByUserTypeAsync(userType, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 UserType（字段） 查询
		/// </summary>
		/// /// <param name = "userType">0-未充值用户1-已充值用户</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_pay_amount_configEO> GetByUserType(bool userType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserType` = @UserType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserType", userType, MySqlDbType.Byte));
			return Database.ExecSqlList(sql_, paras_, tm_, L_pay_amount_configEO.MapDataReader);
		}
		public async Task<List<L_pay_amount_configEO>> GetByUserTypeAsync(bool userType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserType` = @UserType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserType", userType, MySqlDbType.Byte));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_pay_amount_configEO.MapDataReader);
		}
		#endregion // GetByUserType
		#region GetByOrderNum
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序（从小到大）</param>
		/// <return>实体对象集合</return>
		public List<L_pay_amount_configEO> GetByOrderNum(int orderNum)
		{
			return GetByOrderNum(orderNum, 0, string.Empty, null);
		}
		public async Task<List<L_pay_amount_configEO>> GetByOrderNumAsync(int orderNum)
		{
			return await GetByOrderNumAsync(orderNum, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序（从小到大）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_pay_amount_configEO> GetByOrderNum(int orderNum, TransactionManager tm_)
		{
			return GetByOrderNum(orderNum, 0, string.Empty, tm_);
		}
		public async Task<List<L_pay_amount_configEO>> GetByOrderNumAsync(int orderNum, TransactionManager tm_)
		{
			return await GetByOrderNumAsync(orderNum, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序（从小到大）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_pay_amount_configEO> GetByOrderNum(int orderNum, int top_)
		{
			return GetByOrderNum(orderNum, top_, string.Empty, null);
		}
		public async Task<List<L_pay_amount_configEO>> GetByOrderNumAsync(int orderNum, int top_)
		{
			return await GetByOrderNumAsync(orderNum, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序（从小到大）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_pay_amount_configEO> GetByOrderNum(int orderNum, int top_, TransactionManager tm_)
		{
			return GetByOrderNum(orderNum, top_, string.Empty, tm_);
		}
		public async Task<List<L_pay_amount_configEO>> GetByOrderNumAsync(int orderNum, int top_, TransactionManager tm_)
		{
			return await GetByOrderNumAsync(orderNum, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序（从小到大）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_pay_amount_configEO> GetByOrderNum(int orderNum, string sort_)
		{
			return GetByOrderNum(orderNum, 0, sort_, null);
		}
		public async Task<List<L_pay_amount_configEO>> GetByOrderNumAsync(int orderNum, string sort_)
		{
			return await GetByOrderNumAsync(orderNum, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序（从小到大）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_pay_amount_configEO> GetByOrderNum(int orderNum, string sort_, TransactionManager tm_)
		{
			return GetByOrderNum(orderNum, 0, sort_, tm_);
		}
		public async Task<List<L_pay_amount_configEO>> GetByOrderNumAsync(int orderNum, string sort_, TransactionManager tm_)
		{
			return await GetByOrderNumAsync(orderNum, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序（从小到大）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_pay_amount_configEO> GetByOrderNum(int orderNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OrderNum` = @OrderNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OrderNum", orderNum, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, L_pay_amount_configEO.MapDataReader);
		}
		public async Task<List<L_pay_amount_configEO>> GetByOrderNumAsync(int orderNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OrderNum` = @OrderNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OrderNum", orderNum, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_pay_amount_configEO.MapDataReader);
		}
		#endregion // GetByOrderNum
		#region GetByIsSelected
		
		/// <summary>
		/// 按 IsSelected（字段） 查询
		/// </summary>
		/// /// <param name = "isSelected">是否选中</param>
		/// <return>实体对象集合</return>
		public List<L_pay_amount_configEO> GetByIsSelected(bool isSelected)
		{
			return GetByIsSelected(isSelected, 0, string.Empty, null);
		}
		public async Task<List<L_pay_amount_configEO>> GetByIsSelectedAsync(bool isSelected)
		{
			return await GetByIsSelectedAsync(isSelected, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsSelected（字段） 查询
		/// </summary>
		/// /// <param name = "isSelected">是否选中</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_pay_amount_configEO> GetByIsSelected(bool isSelected, TransactionManager tm_)
		{
			return GetByIsSelected(isSelected, 0, string.Empty, tm_);
		}
		public async Task<List<L_pay_amount_configEO>> GetByIsSelectedAsync(bool isSelected, TransactionManager tm_)
		{
			return await GetByIsSelectedAsync(isSelected, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsSelected（字段） 查询
		/// </summary>
		/// /// <param name = "isSelected">是否选中</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_pay_amount_configEO> GetByIsSelected(bool isSelected, int top_)
		{
			return GetByIsSelected(isSelected, top_, string.Empty, null);
		}
		public async Task<List<L_pay_amount_configEO>> GetByIsSelectedAsync(bool isSelected, int top_)
		{
			return await GetByIsSelectedAsync(isSelected, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsSelected（字段） 查询
		/// </summary>
		/// /// <param name = "isSelected">是否选中</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_pay_amount_configEO> GetByIsSelected(bool isSelected, int top_, TransactionManager tm_)
		{
			return GetByIsSelected(isSelected, top_, string.Empty, tm_);
		}
		public async Task<List<L_pay_amount_configEO>> GetByIsSelectedAsync(bool isSelected, int top_, TransactionManager tm_)
		{
			return await GetByIsSelectedAsync(isSelected, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsSelected（字段） 查询
		/// </summary>
		/// /// <param name = "isSelected">是否选中</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_pay_amount_configEO> GetByIsSelected(bool isSelected, string sort_)
		{
			return GetByIsSelected(isSelected, 0, sort_, null);
		}
		public async Task<List<L_pay_amount_configEO>> GetByIsSelectedAsync(bool isSelected, string sort_)
		{
			return await GetByIsSelectedAsync(isSelected, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 IsSelected（字段） 查询
		/// </summary>
		/// /// <param name = "isSelected">是否选中</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_pay_amount_configEO> GetByIsSelected(bool isSelected, string sort_, TransactionManager tm_)
		{
			return GetByIsSelected(isSelected, 0, sort_, tm_);
		}
		public async Task<List<L_pay_amount_configEO>> GetByIsSelectedAsync(bool isSelected, string sort_, TransactionManager tm_)
		{
			return await GetByIsSelectedAsync(isSelected, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 IsSelected（字段） 查询
		/// </summary>
		/// /// <param name = "isSelected">是否选中</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_pay_amount_configEO> GetByIsSelected(bool isSelected, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsSelected` = @IsSelected", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsSelected", isSelected, MySqlDbType.Byte));
			return Database.ExecSqlList(sql_, paras_, tm_, L_pay_amount_configEO.MapDataReader);
		}
		public async Task<List<L_pay_amount_configEO>> GetByIsSelectedAsync(bool isSelected, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsSelected` = @IsSelected", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsSelected", isSelected, MySqlDbType.Byte));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_pay_amount_configEO.MapDataReader);
		}
		#endregion // GetByIsSelected
		#region GetByHotFlag
		
		/// <summary>
		/// 按 HotFlag（字段） 查询
		/// </summary>
		/// /// <param name = "hotFlag">Hot角标</param>
		/// <return>实体对象集合</return>
		public List<L_pay_amount_configEO> GetByHotFlag(int hotFlag)
		{
			return GetByHotFlag(hotFlag, 0, string.Empty, null);
		}
		public async Task<List<L_pay_amount_configEO>> GetByHotFlagAsync(int hotFlag)
		{
			return await GetByHotFlagAsync(hotFlag, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 HotFlag（字段） 查询
		/// </summary>
		/// /// <param name = "hotFlag">Hot角标</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_pay_amount_configEO> GetByHotFlag(int hotFlag, TransactionManager tm_)
		{
			return GetByHotFlag(hotFlag, 0, string.Empty, tm_);
		}
		public async Task<List<L_pay_amount_configEO>> GetByHotFlagAsync(int hotFlag, TransactionManager tm_)
		{
			return await GetByHotFlagAsync(hotFlag, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 HotFlag（字段） 查询
		/// </summary>
		/// /// <param name = "hotFlag">Hot角标</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_pay_amount_configEO> GetByHotFlag(int hotFlag, int top_)
		{
			return GetByHotFlag(hotFlag, top_, string.Empty, null);
		}
		public async Task<List<L_pay_amount_configEO>> GetByHotFlagAsync(int hotFlag, int top_)
		{
			return await GetByHotFlagAsync(hotFlag, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 HotFlag（字段） 查询
		/// </summary>
		/// /// <param name = "hotFlag">Hot角标</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_pay_amount_configEO> GetByHotFlag(int hotFlag, int top_, TransactionManager tm_)
		{
			return GetByHotFlag(hotFlag, top_, string.Empty, tm_);
		}
		public async Task<List<L_pay_amount_configEO>> GetByHotFlagAsync(int hotFlag, int top_, TransactionManager tm_)
		{
			return await GetByHotFlagAsync(hotFlag, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 HotFlag（字段） 查询
		/// </summary>
		/// /// <param name = "hotFlag">Hot角标</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_pay_amount_configEO> GetByHotFlag(int hotFlag, string sort_)
		{
			return GetByHotFlag(hotFlag, 0, sort_, null);
		}
		public async Task<List<L_pay_amount_configEO>> GetByHotFlagAsync(int hotFlag, string sort_)
		{
			return await GetByHotFlagAsync(hotFlag, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 HotFlag（字段） 查询
		/// </summary>
		/// /// <param name = "hotFlag">Hot角标</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_pay_amount_configEO> GetByHotFlag(int hotFlag, string sort_, TransactionManager tm_)
		{
			return GetByHotFlag(hotFlag, 0, sort_, tm_);
		}
		public async Task<List<L_pay_amount_configEO>> GetByHotFlagAsync(int hotFlag, string sort_, TransactionManager tm_)
		{
			return await GetByHotFlagAsync(hotFlag, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 HotFlag（字段） 查询
		/// </summary>
		/// /// <param name = "hotFlag">Hot角标</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_pay_amount_configEO> GetByHotFlag(int hotFlag, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`HotFlag` = @HotFlag", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@HotFlag", hotFlag, MySqlDbType.Byte));
			return Database.ExecSqlList(sql_, paras_, tm_, L_pay_amount_configEO.MapDataReader);
		}
		public async Task<List<L_pay_amount_configEO>> GetByHotFlagAsync(int hotFlag, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`HotFlag` = @HotFlag", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@HotFlag", hotFlag, MySqlDbType.Byte));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_pay_amount_configEO.MapDataReader);
		}
		#endregion // GetByHotFlag
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <return>实体对象集合</return>
		public List<L_pay_amount_configEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<L_pay_amount_configEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_pay_amount_configEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<L_pay_amount_configEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_pay_amount_configEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<L_pay_amount_configEO>> GetByRecDateAsync(DateTime recDate, int top_)
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
		public List<L_pay_amount_configEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<L_pay_amount_configEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_pay_amount_configEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<L_pay_amount_configEO>> GetByRecDateAsync(DateTime recDate, string sort_)
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
		public List<L_pay_amount_configEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<L_pay_amount_configEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
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
		public List<L_pay_amount_configEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, L_pay_amount_configEO.MapDataReader);
		}
		public async Task<List<L_pay_amount_configEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_pay_amount_configEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
