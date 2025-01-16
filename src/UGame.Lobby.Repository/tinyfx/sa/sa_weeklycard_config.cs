/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * AiUo代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/AiUo
 * 文档生成时间：2023-12-28 17: 18:51
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
	/// 1.7版周卡配置
	/// 【表 sa_weeklycard_config 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Sa_weeklycard_configEO : IRowMapper<Sa_weeklycard_configEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Sa_weeklycard_configEO()
		{
			this.WeeklyCardType = 0;
			this.VipMultip = 1.00f;
			this.PayAmount = 0;
			this.FlowMultip = 1.00f;
			this.CountDown = 0.0f;
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
		
		private string _originalCurrencyID;
		/// <summary>
		/// 【数据库中的原始主键 CurrencyID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalCurrencyID
		{
			get { return _originalCurrencyID; }
			set { HasOriginal = true; _originalCurrencyID = value; }
		}
		
		private int _originalWeeklyCardType;
		/// <summary>
		/// 【数据库中的原始主键 WeeklyCardType 值的副本，用于主键值更新】
		/// </summary>
		public int OriginalWeeklyCardType
		{
			get { return _originalWeeklyCardType; }
			set { HasOriginal = true; _originalWeeklyCardType = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "OperatorID", OperatorID },  { "CurrencyID", CurrencyID },  { "WeeklyCardType", WeeklyCardType }, };
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
		/// 货币类型
		/// 【主键 varchar(5)】
		/// </summary>
		[DataMember(Order = 2)]
		public string CurrencyID { get; set; }
		/// <summary>
		/// 1-100档周卡2-50档周卡
		/// 【主键 int】
		/// </summary>
		[DataMember(Order = 3)]
		public int WeeklyCardType { get; set; }
		/// <summary>
		/// 国家编码ISO 3166-1三位字母
		/// 【字段 varchar(5)】
		/// </summary>
		[DataMember(Order = 4)]
		public string CountryId { get; set; }
		/// <summary>
		/// vip加速倍率
		/// 【字段 float(10,2)】
		/// </summary>
		[DataMember(Order = 5)]
		public float VipMultip { get; set; }
		/// <summary>
		/// 购买周卡需要的充值金额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 6)]
		public long PayAmount { get; set; }
		/// <summary>
		/// 购买周卡充值金额需要完成的下注流水
		/// 【字段 float(10,2)】
		/// </summary>
		[DataMember(Order = 7)]
		public float FlowMultip { get; set; }
		/// <summary>
		/// 从注册时间算起,购买周卡倒计时
		/// 【字段 float(10,1)】
		/// </summary>
		[DataMember(Order = 8)]
		public float CountDown { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Sa_weeklycard_configEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Sa_weeklycard_configEO MapDataReader(IDataReader reader)
		{
		    Sa_weeklycard_configEO ret = new Sa_weeklycard_configEO();
			ret.OperatorID = reader.ToString("OperatorID");
			ret.OriginalOperatorID = ret.OperatorID;
			ret.CurrencyID = reader.ToString("CurrencyID");
			ret.OriginalCurrencyID = ret.CurrencyID;
			ret.WeeklyCardType = reader.ToInt32("WeeklyCardType");
			ret.OriginalWeeklyCardType = ret.WeeklyCardType;
			ret.CountryId = reader.ToString("CountryId");
			ret.VipMultip = reader.ToSingle("VipMultip");
			ret.PayAmount = reader.ToInt64("PayAmount");
			ret.FlowMultip = reader.ToSingle("FlowMultip");
			ret.CountDown = reader.ToSingle("CountDown");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 1.7版周卡配置
	/// 【表 sa_weeklycard_config 的操作类】
	/// </summary>
	[Obsolete]
	public class Sa_weeklycard_configMO : MySqlTableMO<Sa_weeklycard_configEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`sa_weeklycard_config`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Sa_weeklycard_configMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Sa_weeklycard_configMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Sa_weeklycard_configMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Sa_weeklycard_configEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Sa_weeklycard_configEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Sa_weeklycard_configEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`OperatorID`, `CurrencyID`, `WeeklyCardType`, `CountryId`, `VipMultip`, `PayAmount`, `FlowMultip`, `CountDown`) VALUE (@OperatorID, @CurrencyID, @WeeklyCardType, @CountryId, @VipMultip, @PayAmount, @FlowMultip, @CountDown);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@WeeklyCardType", item.WeeklyCardType, MySqlDbType.Int32),
				Database.CreateInParameter("@CountryId", item.CountryId, MySqlDbType.VarChar),
				Database.CreateInParameter("@VipMultip", item.VipMultip, MySqlDbType.Float),
				Database.CreateInParameter("@PayAmount", item.PayAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@FlowMultip", item.FlowMultip, MySqlDbType.Float),
				Database.CreateInParameter("@CountDown", item.CountDown, MySqlDbType.Float),
			};
		}
		public int AddByBatch(IEnumerable<Sa_weeklycard_configEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Sa_weeklycard_configEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sa_weeklycard_configEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`OperatorID`, `CurrencyID`, `WeeklyCardType`, `CountryId`, `VipMultip`, `PayAmount`, `FlowMultip`, `CountDown`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.OperatorID}','{item.CurrencyID}',{item.WeeklyCardType},'{item.CountryId}',{item.VipMultip},{item.PayAmount},{item.FlowMultip},{item.CountDown}),");
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
		/// /// <param name = "currencyID">货币类型</param>
		/// /// <param name = "weeklyCardType">1-100档周卡2-50档周卡</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string operatorID, string currencyID, int weeklyCardType, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(operatorID, currencyID, weeklyCardType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string operatorID, string currencyID, int weeklyCardType, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(operatorID, currencyID, weeklyCardType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string operatorID, string currencyID, int weeklyCardType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID AND `WeeklyCardType` = @WeeklyCardType";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@WeeklyCardType", weeklyCardType, MySqlDbType.Int32),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Sa_weeklycard_configEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.OperatorID, item.CurrencyID, item.WeeklyCardType, tm_);
		}
		public async Task<int> RemoveAsync(Sa_weeklycard_configEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.OperatorID, item.CurrencyID, item.WeeklyCardType, tm_);
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
		#region RemoveByWeeklyCardType
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "weeklyCardType">1-100档周卡2-50档周卡</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByWeeklyCardType(int weeklyCardType, TransactionManager tm_ = null)
		{
			RepairRemoveByWeeklyCardTypeData(weeklyCardType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByWeeklyCardTypeAsync(int weeklyCardType, TransactionManager tm_ = null)
		{
			RepairRemoveByWeeklyCardTypeData(weeklyCardType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByWeeklyCardTypeData(int weeklyCardType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `WeeklyCardType` = @WeeklyCardType";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WeeklyCardType", weeklyCardType, MySqlDbType.Int32));
		}
		#endregion // RemoveByWeeklyCardType
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
		#region RemoveByVipMultip
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "vipMultip">vip加速倍率</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByVipMultip(float vipMultip, TransactionManager tm_ = null)
		{
			RepairRemoveByVipMultipData(vipMultip, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByVipMultipAsync(float vipMultip, TransactionManager tm_ = null)
		{
			RepairRemoveByVipMultipData(vipMultip, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByVipMultipData(float vipMultip, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `VipMultip` = @VipMultip";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@VipMultip", vipMultip, MySqlDbType.Float));
		}
		#endregion // RemoveByVipMultip
		#region RemoveByPayAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "payAmount">购买周卡需要的充值金额</param>
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
		#region RemoveByFlowMultip
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "flowMultip">购买周卡充值金额需要完成的下注流水</param>
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
		#region RemoveByCountDown
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "countDown">从注册时间算起,购买周卡倒计时</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCountDown(float countDown, TransactionManager tm_ = null)
		{
			RepairRemoveByCountDownData(countDown, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCountDownAsync(float countDown, TransactionManager tm_ = null)
		{
			RepairRemoveByCountDownData(countDown, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCountDownData(float countDown, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `CountDown` = @CountDown";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CountDown", countDown, MySqlDbType.Float));
		}
		#endregion // RemoveByCountDown
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
		public int Put(Sa_weeklycard_configEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Sa_weeklycard_configEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Sa_weeklycard_configEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID, `CurrencyID` = @CurrencyID, `WeeklyCardType` = @WeeklyCardType, `CountryId` = @CountryId, `VipMultip` = @VipMultip, `PayAmount` = @PayAmount, `FlowMultip` = @FlowMultip, `CountDown` = @CountDown WHERE `OperatorID` = @OperatorID_Original AND `CurrencyID` = @CurrencyID_Original AND `WeeklyCardType` = @WeeklyCardType_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@WeeklyCardType", item.WeeklyCardType, MySqlDbType.Int32),
				Database.CreateInParameter("@CountryId", item.CountryId, MySqlDbType.VarChar),
				Database.CreateInParameter("@VipMultip", item.VipMultip, MySqlDbType.Float),
				Database.CreateInParameter("@PayAmount", item.PayAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@FlowMultip", item.FlowMultip, MySqlDbType.Float),
				Database.CreateInParameter("@CountDown", item.CountDown, MySqlDbType.Float),
				Database.CreateInParameter("@OperatorID_Original", item.HasOriginal ? item.OriginalOperatorID : item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID_Original", item.HasOriginal ? item.OriginalCurrencyID : item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@WeeklyCardType_Original", item.HasOriginal ? item.OriginalWeeklyCardType : item.WeeklyCardType, MySqlDbType.Int32),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Sa_weeklycard_configEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Sa_weeklycard_configEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "currencyID">货币类型</param>
		/// /// <param name = "weeklyCardType">1-100档周卡2-50档周卡</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string operatorID, string currencyID, int weeklyCardType, string set_, params object[] values_)
		{
			return Put(set_, "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID AND `WeeklyCardType` = @WeeklyCardType", ConcatValues(values_, operatorID, currencyID, weeklyCardType));
		}
		public async Task<int> PutByPKAsync(string operatorID, string currencyID, int weeklyCardType, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID AND `WeeklyCardType` = @WeeklyCardType", ConcatValues(values_, operatorID, currencyID, weeklyCardType));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// /// <param name = "weeklyCardType">1-100档周卡2-50档周卡</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string operatorID, string currencyID, int weeklyCardType, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID AND `WeeklyCardType` = @WeeklyCardType", tm_, ConcatValues(values_, operatorID, currencyID, weeklyCardType));
		}
		public async Task<int> PutByPKAsync(string operatorID, string currencyID, int weeklyCardType, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID AND `WeeklyCardType` = @WeeklyCardType", tm_, ConcatValues(values_, operatorID, currencyID, weeklyCardType));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// /// <param name = "weeklyCardType">1-100档周卡2-50档周卡</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string operatorID, string currencyID, int weeklyCardType, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@WeeklyCardType", weeklyCardType, MySqlDbType.Int32),
	        };
			return Put(set_, "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID AND `WeeklyCardType` = @WeeklyCardType", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string operatorID, string currencyID, int weeklyCardType, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@WeeklyCardType", weeklyCardType, MySqlDbType.Int32),
	        };
			return await PutAsync(set_, "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID AND `WeeklyCardType` = @WeeklyCardType", ConcatParameters(paras_, newParas_), tm_);
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
		#region PutWeeklyCardType
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "weeklyCardType">1-100档周卡2-50档周卡</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWeeklyCardType(int weeklyCardType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `WeeklyCardType` = @WeeklyCardType";
			var parameter_ = Database.CreateInParameter("@WeeklyCardType", weeklyCardType, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutWeeklyCardTypeAsync(int weeklyCardType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `WeeklyCardType` = @WeeklyCardType";
			var parameter_ = Database.CreateInParameter("@WeeklyCardType", weeklyCardType, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutWeeklyCardType
		#region PutCountryId
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// /// <param name = "weeklyCardType">1-100档周卡2-50档周卡</param>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCountryIdByPK(string operatorID, string currencyID, int weeklyCardType, string countryId, TransactionManager tm_ = null)
		{
			RepairPutCountryIdByPKData(operatorID, currencyID, weeklyCardType, countryId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCountryIdByPKAsync(string operatorID, string currencyID, int weeklyCardType, string countryId, TransactionManager tm_ = null)
		{
			RepairPutCountryIdByPKData(operatorID, currencyID, weeklyCardType, countryId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCountryIdByPKData(string operatorID, string currencyID, int weeklyCardType, string countryId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CountryId` = @CountryId  WHERE `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID AND `WeeklyCardType` = @WeeklyCardType";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@WeeklyCardType", weeklyCardType, MySqlDbType.Int32),
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
		#region PutVipMultip
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// /// <param name = "weeklyCardType">1-100档周卡2-50档周卡</param>
		/// /// <param name = "vipMultip">vip加速倍率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutVipMultipByPK(string operatorID, string currencyID, int weeklyCardType, float vipMultip, TransactionManager tm_ = null)
		{
			RepairPutVipMultipByPKData(operatorID, currencyID, weeklyCardType, vipMultip, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutVipMultipByPKAsync(string operatorID, string currencyID, int weeklyCardType, float vipMultip, TransactionManager tm_ = null)
		{
			RepairPutVipMultipByPKData(operatorID, currencyID, weeklyCardType, vipMultip, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutVipMultipByPKData(string operatorID, string currencyID, int weeklyCardType, float vipMultip, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `VipMultip` = @VipMultip  WHERE `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID AND `WeeklyCardType` = @WeeklyCardType";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@VipMultip", vipMultip, MySqlDbType.Float),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@WeeklyCardType", weeklyCardType, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "vipMultip">vip加速倍率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutVipMultip(float vipMultip, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `VipMultip` = @VipMultip";
			var parameter_ = Database.CreateInParameter("@VipMultip", vipMultip, MySqlDbType.Float);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutVipMultipAsync(float vipMultip, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `VipMultip` = @VipMultip";
			var parameter_ = Database.CreateInParameter("@VipMultip", vipMultip, MySqlDbType.Float);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutVipMultip
		#region PutPayAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// /// <param name = "weeklyCardType">1-100档周卡2-50档周卡</param>
		/// /// <param name = "payAmount">购买周卡需要的充值金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPayAmountByPK(string operatorID, string currencyID, int weeklyCardType, long payAmount, TransactionManager tm_ = null)
		{
			RepairPutPayAmountByPKData(operatorID, currencyID, weeklyCardType, payAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutPayAmountByPKAsync(string operatorID, string currencyID, int weeklyCardType, long payAmount, TransactionManager tm_ = null)
		{
			RepairPutPayAmountByPKData(operatorID, currencyID, weeklyCardType, payAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutPayAmountByPKData(string operatorID, string currencyID, int weeklyCardType, long payAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `PayAmount` = @PayAmount  WHERE `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID AND `WeeklyCardType` = @WeeklyCardType";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PayAmount", payAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@WeeklyCardType", weeklyCardType, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "payAmount">购买周卡需要的充值金额</param>
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
		#region PutFlowMultip
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// /// <param name = "weeklyCardType">1-100档周卡2-50档周卡</param>
		/// /// <param name = "flowMultip">购买周卡充值金额需要完成的下注流水</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFlowMultipByPK(string operatorID, string currencyID, int weeklyCardType, float flowMultip, TransactionManager tm_ = null)
		{
			RepairPutFlowMultipByPKData(operatorID, currencyID, weeklyCardType, flowMultip, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFlowMultipByPKAsync(string operatorID, string currencyID, int weeklyCardType, float flowMultip, TransactionManager tm_ = null)
		{
			RepairPutFlowMultipByPKData(operatorID, currencyID, weeklyCardType, flowMultip, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFlowMultipByPKData(string operatorID, string currencyID, int weeklyCardType, float flowMultip, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `FlowMultip` = @FlowMultip  WHERE `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID AND `WeeklyCardType` = @WeeklyCardType";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@FlowMultip", flowMultip, MySqlDbType.Float),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@WeeklyCardType", weeklyCardType, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "flowMultip">购买周卡充值金额需要完成的下注流水</param>
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
		#region PutCountDown
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// /// <param name = "weeklyCardType">1-100档周卡2-50档周卡</param>
		/// /// <param name = "countDown">从注册时间算起,购买周卡倒计时</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCountDownByPK(string operatorID, string currencyID, int weeklyCardType, float countDown, TransactionManager tm_ = null)
		{
			RepairPutCountDownByPKData(operatorID, currencyID, weeklyCardType, countDown, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCountDownByPKAsync(string operatorID, string currencyID, int weeklyCardType, float countDown, TransactionManager tm_ = null)
		{
			RepairPutCountDownByPKData(operatorID, currencyID, weeklyCardType, countDown, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCountDownByPKData(string operatorID, string currencyID, int weeklyCardType, float countDown, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CountDown` = @CountDown  WHERE `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID AND `WeeklyCardType` = @WeeklyCardType";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountDown", countDown, MySqlDbType.Float),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@WeeklyCardType", weeklyCardType, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "countDown">从注册时间算起,购买周卡倒计时</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCountDown(float countDown, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CountDown` = @CountDown";
			var parameter_ = Database.CreateInParameter("@CountDown", countDown, MySqlDbType.Float);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCountDownAsync(float countDown, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CountDown` = @CountDown";
			var parameter_ = Database.CreateInParameter("@CountDown", countDown, MySqlDbType.Float);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCountDown
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Sa_weeklycard_configEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.OperatorID, item.CurrencyID, item.WeeklyCardType) == null)
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
		public async Task<bool> SetAsync(Sa_weeklycard_configEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.OperatorID, item.CurrencyID, item.WeeklyCardType) == null)
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
		/// /// <param name = "currencyID">货币类型</param>
		/// /// <param name = "weeklyCardType">1-100档周卡2-50档周卡</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Sa_weeklycard_configEO GetByPK(string operatorID, string currencyID, int weeklyCardType, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(operatorID, currencyID, weeklyCardType, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sa_weeklycard_configEO.MapDataReader);
		}
		public async Task<Sa_weeklycard_configEO> GetByPKAsync(string operatorID, string currencyID, int weeklyCardType, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(operatorID, currencyID, weeklyCardType, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sa_weeklycard_configEO.MapDataReader);
		}
		private void RepairGetByPKData(string operatorID, string currencyID, int weeklyCardType, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID AND `WeeklyCardType` = @WeeklyCardType", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@WeeklyCardType", weeklyCardType, MySqlDbType.Int32),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 OperatorID（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// /// <param name = "weeklyCardType">1-100档周卡2-50档周卡</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorIDByPK(string operatorID, string currencyID, int weeklyCardType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@WeeklyCardType", weeklyCardType, MySqlDbType.Int32),
			};
			return (string)GetScalar("`OperatorID`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID AND `WeeklyCardType` = @WeeklyCardType", paras_, tm_);
		}
		public async Task<string> GetOperatorIDByPKAsync(string operatorID, string currencyID, int weeklyCardType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@WeeklyCardType", weeklyCardType, MySqlDbType.Int32),
			};
			return (string)await GetScalarAsync("`OperatorID`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID AND `WeeklyCardType` = @WeeklyCardType", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CurrencyID（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// /// <param name = "weeklyCardType">1-100档周卡2-50档周卡</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCurrencyIDByPK(string operatorID, string currencyID, int weeklyCardType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@WeeklyCardType", weeklyCardType, MySqlDbType.Int32),
			};
			return (string)GetScalar("`CurrencyID`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID AND `WeeklyCardType` = @WeeklyCardType", paras_, tm_);
		}
		public async Task<string> GetCurrencyIDByPKAsync(string operatorID, string currencyID, int weeklyCardType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@WeeklyCardType", weeklyCardType, MySqlDbType.Int32),
			};
			return (string)await GetScalarAsync("`CurrencyID`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID AND `WeeklyCardType` = @WeeklyCardType", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 WeeklyCardType（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// /// <param name = "weeklyCardType">1-100档周卡2-50档周卡</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetWeeklyCardTypeByPK(string operatorID, string currencyID, int weeklyCardType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@WeeklyCardType", weeklyCardType, MySqlDbType.Int32),
			};
			return (int)GetScalar("`WeeklyCardType`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID AND `WeeklyCardType` = @WeeklyCardType", paras_, tm_);
		}
		public async Task<int> GetWeeklyCardTypeByPKAsync(string operatorID, string currencyID, int weeklyCardType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@WeeklyCardType", weeklyCardType, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`WeeklyCardType`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID AND `WeeklyCardType` = @WeeklyCardType", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CountryId（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// /// <param name = "weeklyCardType">1-100档周卡2-50档周卡</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCountryIdByPK(string operatorID, string currencyID, int weeklyCardType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@WeeklyCardType", weeklyCardType, MySqlDbType.Int32),
			};
			return (string)GetScalar("`CountryId`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID AND `WeeklyCardType` = @WeeklyCardType", paras_, tm_);
		}
		public async Task<string> GetCountryIdByPKAsync(string operatorID, string currencyID, int weeklyCardType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@WeeklyCardType", weeklyCardType, MySqlDbType.Int32),
			};
			return (string)await GetScalarAsync("`CountryId`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID AND `WeeklyCardType` = @WeeklyCardType", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 VipMultip（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// /// <param name = "weeklyCardType">1-100档周卡2-50档周卡</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public float GetVipMultipByPK(string operatorID, string currencyID, int weeklyCardType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@WeeklyCardType", weeklyCardType, MySqlDbType.Int32),
			};
			return (float)GetScalar("`VipMultip`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID AND `WeeklyCardType` = @WeeklyCardType", paras_, tm_);
		}
		public async Task<float> GetVipMultipByPKAsync(string operatorID, string currencyID, int weeklyCardType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@WeeklyCardType", weeklyCardType, MySqlDbType.Int32),
			};
			return (float)await GetScalarAsync("`VipMultip`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID AND `WeeklyCardType` = @WeeklyCardType", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 PayAmount（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// /// <param name = "weeklyCardType">1-100档周卡2-50档周卡</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetPayAmountByPK(string operatorID, string currencyID, int weeklyCardType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@WeeklyCardType", weeklyCardType, MySqlDbType.Int32),
			};
			return (long)GetScalar("`PayAmount`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID AND `WeeklyCardType` = @WeeklyCardType", paras_, tm_);
		}
		public async Task<long> GetPayAmountByPKAsync(string operatorID, string currencyID, int weeklyCardType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@WeeklyCardType", weeklyCardType, MySqlDbType.Int32),
			};
			return (long)await GetScalarAsync("`PayAmount`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID AND `WeeklyCardType` = @WeeklyCardType", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 FlowMultip（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// /// <param name = "weeklyCardType">1-100档周卡2-50档周卡</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public float GetFlowMultipByPK(string operatorID, string currencyID, int weeklyCardType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@WeeklyCardType", weeklyCardType, MySqlDbType.Int32),
			};
			return (float)GetScalar("`FlowMultip`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID AND `WeeklyCardType` = @WeeklyCardType", paras_, tm_);
		}
		public async Task<float> GetFlowMultipByPKAsync(string operatorID, string currencyID, int weeklyCardType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@WeeklyCardType", weeklyCardType, MySqlDbType.Int32),
			};
			return (float)await GetScalarAsync("`FlowMultip`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID AND `WeeklyCardType` = @WeeklyCardType", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CountDown（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// /// <param name = "weeklyCardType">1-100档周卡2-50档周卡</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public float GetCountDownByPK(string operatorID, string currencyID, int weeklyCardType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@WeeklyCardType", weeklyCardType, MySqlDbType.Int32),
			};
			return (float)GetScalar("`CountDown`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID AND `WeeklyCardType` = @WeeklyCardType", paras_, tm_);
		}
		public async Task<float> GetCountDownByPKAsync(string operatorID, string currencyID, int weeklyCardType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@WeeklyCardType", weeklyCardType, MySqlDbType.Int32),
			};
			return (float)await GetScalarAsync("`CountDown`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID AND `WeeklyCardType` = @WeeklyCardType", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_configEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<Sa_weeklycard_configEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_configEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_weeklycard_configEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_configEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<Sa_weeklycard_configEO>> GetByOperatorIDAsync(string operatorID, int top_)
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
		public List<Sa_weeklycard_configEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_weeklycard_configEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_configEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<Sa_weeklycard_configEO>> GetByOperatorIDAsync(string operatorID, string sort_)
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
		public List<Sa_weeklycard_configEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<Sa_weeklycard_configEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
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
		public List<Sa_weeklycard_configEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_weeklycard_configEO.MapDataReader);
		}
		public async Task<List<Sa_weeklycard_configEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_weeklycard_configEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByCurrencyID
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_configEO> GetByCurrencyID(string currencyID)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, null);
		}
		public async Task<List<Sa_weeklycard_configEO>> GetByCurrencyIDAsync(string currencyID)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_configEO> GetByCurrencyID(string currencyID, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_weeklycard_configEO>> GetByCurrencyIDAsync(string currencyID, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_configEO> GetByCurrencyID(string currencyID, int top_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, null);
		}
		public async Task<List<Sa_weeklycard_configEO>> GetByCurrencyIDAsync(string currencyID, int top_)
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
		public List<Sa_weeklycard_configEO> GetByCurrencyID(string currencyID, int top_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_weeklycard_configEO>> GetByCurrencyIDAsync(string currencyID, int top_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_configEO> GetByCurrencyID(string currencyID, string sort_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, null);
		}
		public async Task<List<Sa_weeklycard_configEO>> GetByCurrencyIDAsync(string currencyID, string sort_)
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
		public List<Sa_weeklycard_configEO> GetByCurrencyID(string currencyID, string sort_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, tm_);
		}
		public async Task<List<Sa_weeklycard_configEO>> GetByCurrencyIDAsync(string currencyID, string sort_, TransactionManager tm_)
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
		public List<Sa_weeklycard_configEO> GetByCurrencyID(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_weeklycard_configEO.MapDataReader);
		}
		public async Task<List<Sa_weeklycard_configEO>> GetByCurrencyIDAsync(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_weeklycard_configEO.MapDataReader);
		}
		#endregion // GetByCurrencyID
		#region GetByWeeklyCardType
		
		/// <summary>
		/// 按 WeeklyCardType（字段） 查询
		/// </summary>
		/// /// <param name = "weeklyCardType">1-100档周卡2-50档周卡</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_configEO> GetByWeeklyCardType(int weeklyCardType)
		{
			return GetByWeeklyCardType(weeklyCardType, 0, string.Empty, null);
		}
		public async Task<List<Sa_weeklycard_configEO>> GetByWeeklyCardTypeAsync(int weeklyCardType)
		{
			return await GetByWeeklyCardTypeAsync(weeklyCardType, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WeeklyCardType（字段） 查询
		/// </summary>
		/// /// <param name = "weeklyCardType">1-100档周卡2-50档周卡</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_configEO> GetByWeeklyCardType(int weeklyCardType, TransactionManager tm_)
		{
			return GetByWeeklyCardType(weeklyCardType, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_weeklycard_configEO>> GetByWeeklyCardTypeAsync(int weeklyCardType, TransactionManager tm_)
		{
			return await GetByWeeklyCardTypeAsync(weeklyCardType, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WeeklyCardType（字段） 查询
		/// </summary>
		/// /// <param name = "weeklyCardType">1-100档周卡2-50档周卡</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_configEO> GetByWeeklyCardType(int weeklyCardType, int top_)
		{
			return GetByWeeklyCardType(weeklyCardType, top_, string.Empty, null);
		}
		public async Task<List<Sa_weeklycard_configEO>> GetByWeeklyCardTypeAsync(int weeklyCardType, int top_)
		{
			return await GetByWeeklyCardTypeAsync(weeklyCardType, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WeeklyCardType（字段） 查询
		/// </summary>
		/// /// <param name = "weeklyCardType">1-100档周卡2-50档周卡</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_configEO> GetByWeeklyCardType(int weeklyCardType, int top_, TransactionManager tm_)
		{
			return GetByWeeklyCardType(weeklyCardType, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_weeklycard_configEO>> GetByWeeklyCardTypeAsync(int weeklyCardType, int top_, TransactionManager tm_)
		{
			return await GetByWeeklyCardTypeAsync(weeklyCardType, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WeeklyCardType（字段） 查询
		/// </summary>
		/// /// <param name = "weeklyCardType">1-100档周卡2-50档周卡</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_configEO> GetByWeeklyCardType(int weeklyCardType, string sort_)
		{
			return GetByWeeklyCardType(weeklyCardType, 0, sort_, null);
		}
		public async Task<List<Sa_weeklycard_configEO>> GetByWeeklyCardTypeAsync(int weeklyCardType, string sort_)
		{
			return await GetByWeeklyCardTypeAsync(weeklyCardType, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 WeeklyCardType（字段） 查询
		/// </summary>
		/// /// <param name = "weeklyCardType">1-100档周卡2-50档周卡</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_configEO> GetByWeeklyCardType(int weeklyCardType, string sort_, TransactionManager tm_)
		{
			return GetByWeeklyCardType(weeklyCardType, 0, sort_, tm_);
		}
		public async Task<List<Sa_weeklycard_configEO>> GetByWeeklyCardTypeAsync(int weeklyCardType, string sort_, TransactionManager tm_)
		{
			return await GetByWeeklyCardTypeAsync(weeklyCardType, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 WeeklyCardType（字段） 查询
		/// </summary>
		/// /// <param name = "weeklyCardType">1-100档周卡2-50档周卡</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_configEO> GetByWeeklyCardType(int weeklyCardType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WeeklyCardType` = @WeeklyCardType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WeeklyCardType", weeklyCardType, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_weeklycard_configEO.MapDataReader);
		}
		public async Task<List<Sa_weeklycard_configEO>> GetByWeeklyCardTypeAsync(int weeklyCardType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WeeklyCardType` = @WeeklyCardType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WeeklyCardType", weeklyCardType, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_weeklycard_configEO.MapDataReader);
		}
		#endregion // GetByWeeklyCardType
		#region GetByCountryId
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_configEO> GetByCountryId(string countryId)
		{
			return GetByCountryId(countryId, 0, string.Empty, null);
		}
		public async Task<List<Sa_weeklycard_configEO>> GetByCountryIdAsync(string countryId)
		{
			return await GetByCountryIdAsync(countryId, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_configEO> GetByCountryId(string countryId, TransactionManager tm_)
		{
			return GetByCountryId(countryId, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_weeklycard_configEO>> GetByCountryIdAsync(string countryId, TransactionManager tm_)
		{
			return await GetByCountryIdAsync(countryId, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_configEO> GetByCountryId(string countryId, int top_)
		{
			return GetByCountryId(countryId, top_, string.Empty, null);
		}
		public async Task<List<Sa_weeklycard_configEO>> GetByCountryIdAsync(string countryId, int top_)
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
		public List<Sa_weeklycard_configEO> GetByCountryId(string countryId, int top_, TransactionManager tm_)
		{
			return GetByCountryId(countryId, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_weeklycard_configEO>> GetByCountryIdAsync(string countryId, int top_, TransactionManager tm_)
		{
			return await GetByCountryIdAsync(countryId, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_configEO> GetByCountryId(string countryId, string sort_)
		{
			return GetByCountryId(countryId, 0, sort_, null);
		}
		public async Task<List<Sa_weeklycard_configEO>> GetByCountryIdAsync(string countryId, string sort_)
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
		public List<Sa_weeklycard_configEO> GetByCountryId(string countryId, string sort_, TransactionManager tm_)
		{
			return GetByCountryId(countryId, 0, sort_, tm_);
		}
		public async Task<List<Sa_weeklycard_configEO>> GetByCountryIdAsync(string countryId, string sort_, TransactionManager tm_)
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
		public List<Sa_weeklycard_configEO> GetByCountryId(string countryId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CountryId` = @CountryId", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_weeklycard_configEO.MapDataReader);
		}
		public async Task<List<Sa_weeklycard_configEO>> GetByCountryIdAsync(string countryId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CountryId` = @CountryId", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_weeklycard_configEO.MapDataReader);
		}
		#endregion // GetByCountryId
		#region GetByVipMultip
		
		/// <summary>
		/// 按 VipMultip（字段） 查询
		/// </summary>
		/// /// <param name = "vipMultip">vip加速倍率</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_configEO> GetByVipMultip(float vipMultip)
		{
			return GetByVipMultip(vipMultip, 0, string.Empty, null);
		}
		public async Task<List<Sa_weeklycard_configEO>> GetByVipMultipAsync(float vipMultip)
		{
			return await GetByVipMultipAsync(vipMultip, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 VipMultip（字段） 查询
		/// </summary>
		/// /// <param name = "vipMultip">vip加速倍率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_configEO> GetByVipMultip(float vipMultip, TransactionManager tm_)
		{
			return GetByVipMultip(vipMultip, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_weeklycard_configEO>> GetByVipMultipAsync(float vipMultip, TransactionManager tm_)
		{
			return await GetByVipMultipAsync(vipMultip, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 VipMultip（字段） 查询
		/// </summary>
		/// /// <param name = "vipMultip">vip加速倍率</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_configEO> GetByVipMultip(float vipMultip, int top_)
		{
			return GetByVipMultip(vipMultip, top_, string.Empty, null);
		}
		public async Task<List<Sa_weeklycard_configEO>> GetByVipMultipAsync(float vipMultip, int top_)
		{
			return await GetByVipMultipAsync(vipMultip, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 VipMultip（字段） 查询
		/// </summary>
		/// /// <param name = "vipMultip">vip加速倍率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_configEO> GetByVipMultip(float vipMultip, int top_, TransactionManager tm_)
		{
			return GetByVipMultip(vipMultip, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_weeklycard_configEO>> GetByVipMultipAsync(float vipMultip, int top_, TransactionManager tm_)
		{
			return await GetByVipMultipAsync(vipMultip, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 VipMultip（字段） 查询
		/// </summary>
		/// /// <param name = "vipMultip">vip加速倍率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_configEO> GetByVipMultip(float vipMultip, string sort_)
		{
			return GetByVipMultip(vipMultip, 0, sort_, null);
		}
		public async Task<List<Sa_weeklycard_configEO>> GetByVipMultipAsync(float vipMultip, string sort_)
		{
			return await GetByVipMultipAsync(vipMultip, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 VipMultip（字段） 查询
		/// </summary>
		/// /// <param name = "vipMultip">vip加速倍率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_configEO> GetByVipMultip(float vipMultip, string sort_, TransactionManager tm_)
		{
			return GetByVipMultip(vipMultip, 0, sort_, tm_);
		}
		public async Task<List<Sa_weeklycard_configEO>> GetByVipMultipAsync(float vipMultip, string sort_, TransactionManager tm_)
		{
			return await GetByVipMultipAsync(vipMultip, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 VipMultip（字段） 查询
		/// </summary>
		/// /// <param name = "vipMultip">vip加速倍率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_configEO> GetByVipMultip(float vipMultip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`VipMultip` = @VipMultip", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@VipMultip", vipMultip, MySqlDbType.Float));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_weeklycard_configEO.MapDataReader);
		}
		public async Task<List<Sa_weeklycard_configEO>> GetByVipMultipAsync(float vipMultip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`VipMultip` = @VipMultip", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@VipMultip", vipMultip, MySqlDbType.Float));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_weeklycard_configEO.MapDataReader);
		}
		#endregion // GetByVipMultip
		#region GetByPayAmount
		
		/// <summary>
		/// 按 PayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "payAmount">购买周卡需要的充值金额</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_configEO> GetByPayAmount(long payAmount)
		{
			return GetByPayAmount(payAmount, 0, string.Empty, null);
		}
		public async Task<List<Sa_weeklycard_configEO>> GetByPayAmountAsync(long payAmount)
		{
			return await GetByPayAmountAsync(payAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "payAmount">购买周卡需要的充值金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_configEO> GetByPayAmount(long payAmount, TransactionManager tm_)
		{
			return GetByPayAmount(payAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_weeklycard_configEO>> GetByPayAmountAsync(long payAmount, TransactionManager tm_)
		{
			return await GetByPayAmountAsync(payAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "payAmount">购买周卡需要的充值金额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_configEO> GetByPayAmount(long payAmount, int top_)
		{
			return GetByPayAmount(payAmount, top_, string.Empty, null);
		}
		public async Task<List<Sa_weeklycard_configEO>> GetByPayAmountAsync(long payAmount, int top_)
		{
			return await GetByPayAmountAsync(payAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "payAmount">购买周卡需要的充值金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_configEO> GetByPayAmount(long payAmount, int top_, TransactionManager tm_)
		{
			return GetByPayAmount(payAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_weeklycard_configEO>> GetByPayAmountAsync(long payAmount, int top_, TransactionManager tm_)
		{
			return await GetByPayAmountAsync(payAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "payAmount">购买周卡需要的充值金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_configEO> GetByPayAmount(long payAmount, string sort_)
		{
			return GetByPayAmount(payAmount, 0, sort_, null);
		}
		public async Task<List<Sa_weeklycard_configEO>> GetByPayAmountAsync(long payAmount, string sort_)
		{
			return await GetByPayAmountAsync(payAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "payAmount">购买周卡需要的充值金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_configEO> GetByPayAmount(long payAmount, string sort_, TransactionManager tm_)
		{
			return GetByPayAmount(payAmount, 0, sort_, tm_);
		}
		public async Task<List<Sa_weeklycard_configEO>> GetByPayAmountAsync(long payAmount, string sort_, TransactionManager tm_)
		{
			return await GetByPayAmountAsync(payAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "payAmount">购买周卡需要的充值金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_configEO> GetByPayAmount(long payAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PayAmount` = @PayAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PayAmount", payAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_weeklycard_configEO.MapDataReader);
		}
		public async Task<List<Sa_weeklycard_configEO>> GetByPayAmountAsync(long payAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PayAmount` = @PayAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PayAmount", payAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_weeklycard_configEO.MapDataReader);
		}
		#endregion // GetByPayAmount
		#region GetByFlowMultip
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">购买周卡充值金额需要完成的下注流水</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_configEO> GetByFlowMultip(float flowMultip)
		{
			return GetByFlowMultip(flowMultip, 0, string.Empty, null);
		}
		public async Task<List<Sa_weeklycard_configEO>> GetByFlowMultipAsync(float flowMultip)
		{
			return await GetByFlowMultipAsync(flowMultip, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">购买周卡充值金额需要完成的下注流水</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_configEO> GetByFlowMultip(float flowMultip, TransactionManager tm_)
		{
			return GetByFlowMultip(flowMultip, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_weeklycard_configEO>> GetByFlowMultipAsync(float flowMultip, TransactionManager tm_)
		{
			return await GetByFlowMultipAsync(flowMultip, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">购买周卡充值金额需要完成的下注流水</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_configEO> GetByFlowMultip(float flowMultip, int top_)
		{
			return GetByFlowMultip(flowMultip, top_, string.Empty, null);
		}
		public async Task<List<Sa_weeklycard_configEO>> GetByFlowMultipAsync(float flowMultip, int top_)
		{
			return await GetByFlowMultipAsync(flowMultip, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">购买周卡充值金额需要完成的下注流水</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_configEO> GetByFlowMultip(float flowMultip, int top_, TransactionManager tm_)
		{
			return GetByFlowMultip(flowMultip, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_weeklycard_configEO>> GetByFlowMultipAsync(float flowMultip, int top_, TransactionManager tm_)
		{
			return await GetByFlowMultipAsync(flowMultip, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">购买周卡充值金额需要完成的下注流水</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_configEO> GetByFlowMultip(float flowMultip, string sort_)
		{
			return GetByFlowMultip(flowMultip, 0, sort_, null);
		}
		public async Task<List<Sa_weeklycard_configEO>> GetByFlowMultipAsync(float flowMultip, string sort_)
		{
			return await GetByFlowMultipAsync(flowMultip, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">购买周卡充值金额需要完成的下注流水</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_configEO> GetByFlowMultip(float flowMultip, string sort_, TransactionManager tm_)
		{
			return GetByFlowMultip(flowMultip, 0, sort_, tm_);
		}
		public async Task<List<Sa_weeklycard_configEO>> GetByFlowMultipAsync(float flowMultip, string sort_, TransactionManager tm_)
		{
			return await GetByFlowMultipAsync(flowMultip, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">购买周卡充值金额需要完成的下注流水</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_configEO> GetByFlowMultip(float flowMultip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FlowMultip` = @FlowMultip", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FlowMultip", flowMultip, MySqlDbType.Float));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_weeklycard_configEO.MapDataReader);
		}
		public async Task<List<Sa_weeklycard_configEO>> GetByFlowMultipAsync(float flowMultip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FlowMultip` = @FlowMultip", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FlowMultip", flowMultip, MySqlDbType.Float));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_weeklycard_configEO.MapDataReader);
		}
		#endregion // GetByFlowMultip
		#region GetByCountDown
		
		/// <summary>
		/// 按 CountDown（字段） 查询
		/// </summary>
		/// /// <param name = "countDown">从注册时间算起,购买周卡倒计时</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_configEO> GetByCountDown(float countDown)
		{
			return GetByCountDown(countDown, 0, string.Empty, null);
		}
		public async Task<List<Sa_weeklycard_configEO>> GetByCountDownAsync(float countDown)
		{
			return await GetByCountDownAsync(countDown, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CountDown（字段） 查询
		/// </summary>
		/// /// <param name = "countDown">从注册时间算起,购买周卡倒计时</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_configEO> GetByCountDown(float countDown, TransactionManager tm_)
		{
			return GetByCountDown(countDown, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_weeklycard_configEO>> GetByCountDownAsync(float countDown, TransactionManager tm_)
		{
			return await GetByCountDownAsync(countDown, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountDown（字段） 查询
		/// </summary>
		/// /// <param name = "countDown">从注册时间算起,购买周卡倒计时</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_configEO> GetByCountDown(float countDown, int top_)
		{
			return GetByCountDown(countDown, top_, string.Empty, null);
		}
		public async Task<List<Sa_weeklycard_configEO>> GetByCountDownAsync(float countDown, int top_)
		{
			return await GetByCountDownAsync(countDown, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CountDown（字段） 查询
		/// </summary>
		/// /// <param name = "countDown">从注册时间算起,购买周卡倒计时</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_configEO> GetByCountDown(float countDown, int top_, TransactionManager tm_)
		{
			return GetByCountDown(countDown, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_weeklycard_configEO>> GetByCountDownAsync(float countDown, int top_, TransactionManager tm_)
		{
			return await GetByCountDownAsync(countDown, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountDown（字段） 查询
		/// </summary>
		/// /// <param name = "countDown">从注册时间算起,购买周卡倒计时</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_configEO> GetByCountDown(float countDown, string sort_)
		{
			return GetByCountDown(countDown, 0, sort_, null);
		}
		public async Task<List<Sa_weeklycard_configEO>> GetByCountDownAsync(float countDown, string sort_)
		{
			return await GetByCountDownAsync(countDown, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CountDown（字段） 查询
		/// </summary>
		/// /// <param name = "countDown">从注册时间算起,购买周卡倒计时</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_configEO> GetByCountDown(float countDown, string sort_, TransactionManager tm_)
		{
			return GetByCountDown(countDown, 0, sort_, tm_);
		}
		public async Task<List<Sa_weeklycard_configEO>> GetByCountDownAsync(float countDown, string sort_, TransactionManager tm_)
		{
			return await GetByCountDownAsync(countDown, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CountDown（字段） 查询
		/// </summary>
		/// /// <param name = "countDown">从注册时间算起,购买周卡倒计时</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_configEO> GetByCountDown(float countDown, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CountDown` = @CountDown", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CountDown", countDown, MySqlDbType.Float));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_weeklycard_configEO.MapDataReader);
		}
		public async Task<List<Sa_weeklycard_configEO>> GetByCountDownAsync(float countDown, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CountDown` = @CountDown", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CountDown", countDown, MySqlDbType.Float));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_weeklycard_configEO.MapDataReader);
		}
		#endregion // GetByCountDown
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
