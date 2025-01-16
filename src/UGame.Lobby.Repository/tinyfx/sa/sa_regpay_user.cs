/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * AiUo代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/AiUo
 * 文档生成时间：2023-12-28 18: 19:41
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
	/// 用户注册、首充奖励基础数据表（每个用户只可能存在一条记录）
	/// 【表 sa_regpay_user 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Sa_regpay_userEO : IRowMapper<Sa_regpay_userEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Sa_regpay_userEO()
		{
			this.SumPay = 0;
			this.RegPay = 0;
			this.FirstPay = 0;
			this.RegPayReward = 0;
			this.FirstPayReward = 0;
			this.SumBet = 0;
			this.ReturnRewards = 0;
			this.IsRegPay = false;
			this.IsFirstPay = false;
			this.RecDate = DateTime.Now;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private string _originalUserID;
		/// <summary>
		/// 【数据库中的原始主键 UserID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalUserID
		{
			get { return _originalUserID; }
			set { HasOriginal = true; _originalUserID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "UserID", UserID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 用户编码
		/// 【主键 varchar(38)】
		/// </summary>
		[DataMember(Order = 1)]
		public string UserID { get; set; }
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
		/// 奖金总额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 5)]
		public long SumPay { get; set; }
		/// <summary>
		/// 注册奖金
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 6)]
		public long RegPay { get; set; }
		/// <summary>
		/// 首充奖金
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 7)]
		public long FirstPay { get; set; }
		/// <summary>
		/// 注册奖金发放总金额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 8)]
		public long RegPayReward { get; set; }
		/// <summary>
		/// 首充奖金发放总金额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 9)]
		public long FirstPayReward { get; set; }
		/// <summary>
		/// 未发放奖励的下注总额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 10)]
		public long SumBet { get; set; }
		/// <summary>
		/// 当前应获得奖励金额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 11)]
		public long ReturnRewards { get; set; }
		/// <summary>
		/// 是否发放过注册奖励
		/// 【字段 tinyint(1)】
		/// </summary>
		[DataMember(Order = 12)]
		public bool IsRegPay { get; set; }
		/// <summary>
		/// 是否发放过首充奖励
		/// 【字段 tinyint(1)】
		/// </summary>
		[DataMember(Order = 13)]
		public bool IsFirstPay { get; set; }
		/// <summary>
		/// 记录时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 14)]
		public DateTime RecDate { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Sa_regpay_userEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Sa_regpay_userEO MapDataReader(IDataReader reader)
		{
		    Sa_regpay_userEO ret = new Sa_regpay_userEO();
			ret.UserID = reader.ToString("UserID");
			ret.OriginalUserID = ret.UserID;
			ret.OperatorID = reader.ToString("OperatorID");
			ret.CountryId = reader.ToString("CountryId");
			ret.CurrencyID = reader.ToString("CurrencyID");
			ret.SumPay = reader.ToInt64("SumPay");
			ret.RegPay = reader.ToInt64("RegPay");
			ret.FirstPay = reader.ToInt64("FirstPay");
			ret.RegPayReward = reader.ToInt64("RegPayReward");
			ret.FirstPayReward = reader.ToInt64("FirstPayReward");
			ret.SumBet = reader.ToInt64("SumBet");
			ret.ReturnRewards = reader.ToInt64("ReturnRewards");
			ret.IsRegPay = reader.ToBoolean("IsRegPay");
			ret.IsFirstPay = reader.ToBoolean("IsFirstPay");
			ret.RecDate = reader.ToDateTime("RecDate");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 用户注册、首充奖励基础数据表（每个用户只可能存在一条记录）
	/// 【表 sa_regpay_user 的操作类】
	/// </summary>
	[Obsolete]
	public class Sa_regpay_userMO : MySqlTableMO<Sa_regpay_userEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`sa_regpay_user`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Sa_regpay_userMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Sa_regpay_userMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Sa_regpay_userMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Sa_regpay_userEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Sa_regpay_userEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Sa_regpay_userEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`UserID`, `OperatorID`, `CountryId`, `CurrencyID`, `SumPay`, `RegPay`, `FirstPay`, `RegPayReward`, `FirstPayReward`, `SumBet`, `ReturnRewards`, `IsRegPay`, `IsFirstPay`, `RecDate`) VALUE (@UserID, @OperatorID, @CountryId, @CurrencyID, @SumPay, @RegPay, @FirstPay, @RegPayReward, @FirstPayReward, @SumBet, @ReturnRewards, @IsRegPay, @IsFirstPay, @RecDate);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryId", item.CountryId != null ? item.CountryId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID != null ? item.CurrencyID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@SumPay", item.SumPay, MySqlDbType.Int64),
				Database.CreateInParameter("@RegPay", item.RegPay, MySqlDbType.Int64),
				Database.CreateInParameter("@FirstPay", item.FirstPay, MySqlDbType.Int64),
				Database.CreateInParameter("@RegPayReward", item.RegPayReward, MySqlDbType.Int64),
				Database.CreateInParameter("@FirstPayReward", item.FirstPayReward, MySqlDbType.Int64),
				Database.CreateInParameter("@SumBet", item.SumBet, MySqlDbType.Int64),
				Database.CreateInParameter("@ReturnRewards", item.ReturnRewards, MySqlDbType.Int64),
				Database.CreateInParameter("@IsRegPay", item.IsRegPay, MySqlDbType.Byte),
				Database.CreateInParameter("@IsFirstPay", item.IsFirstPay, MySqlDbType.Byte),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
			};
		}
		public int AddByBatch(IEnumerable<Sa_regpay_userEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Sa_regpay_userEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sa_regpay_userEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`UserID`, `OperatorID`, `CountryId`, `CurrencyID`, `SumPay`, `RegPay`, `FirstPay`, `RegPayReward`, `FirstPayReward`, `SumBet`, `ReturnRewards`, `IsRegPay`, `IsFirstPay`, `RecDate`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.UserID}','{item.OperatorID}','{item.CountryId}','{item.CurrencyID}',{item.SumPay},{item.RegPay},{item.FirstPay},{item.RegPayReward},{item.FirstPayReward},{item.SumBet},{item.ReturnRewards},{item.IsRegPay},{item.IsFirstPay},'{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string userID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(userID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string userID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(userID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string userID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Sa_regpay_userEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.UserID, tm_);
		}
		public async Task<int> RemoveAsync(Sa_regpay_userEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.UserID, tm_);
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
		#region RemoveBySumPay
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "sumPay">奖金总额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveBySumPay(long sumPay, TransactionManager tm_ = null)
		{
			RepairRemoveBySumPayData(sumPay, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveBySumPayAsync(long sumPay, TransactionManager tm_ = null)
		{
			RepairRemoveBySumPayData(sumPay, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveBySumPayData(long sumPay, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `SumPay` = @SumPay";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SumPay", sumPay, MySqlDbType.Int64));
		}
		#endregion // RemoveBySumPay
		#region RemoveByRegPay
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "regPay">注册奖金</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByRegPay(long regPay, TransactionManager tm_ = null)
		{
			RepairRemoveByRegPayData(regPay, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByRegPayAsync(long regPay, TransactionManager tm_ = null)
		{
			RepairRemoveByRegPayData(regPay, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByRegPayData(long regPay, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `RegPay` = @RegPay";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RegPay", regPay, MySqlDbType.Int64));
		}
		#endregion // RemoveByRegPay
		#region RemoveByFirstPay
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "firstPay">首充奖金</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByFirstPay(long firstPay, TransactionManager tm_ = null)
		{
			RepairRemoveByFirstPayData(firstPay, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByFirstPayAsync(long firstPay, TransactionManager tm_ = null)
		{
			RepairRemoveByFirstPayData(firstPay, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByFirstPayData(long firstPay, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `FirstPay` = @FirstPay";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FirstPay", firstPay, MySqlDbType.Int64));
		}
		#endregion // RemoveByFirstPay
		#region RemoveByRegPayReward
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "regPayReward">注册奖金发放总金额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByRegPayReward(long regPayReward, TransactionManager tm_ = null)
		{
			RepairRemoveByRegPayRewardData(regPayReward, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByRegPayRewardAsync(long regPayReward, TransactionManager tm_ = null)
		{
			RepairRemoveByRegPayRewardData(regPayReward, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByRegPayRewardData(long regPayReward, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `RegPayReward` = @RegPayReward";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RegPayReward", regPayReward, MySqlDbType.Int64));
		}
		#endregion // RemoveByRegPayReward
		#region RemoveByFirstPayReward
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "firstPayReward">首充奖金发放总金额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByFirstPayReward(long firstPayReward, TransactionManager tm_ = null)
		{
			RepairRemoveByFirstPayRewardData(firstPayReward, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByFirstPayRewardAsync(long firstPayReward, TransactionManager tm_ = null)
		{
			RepairRemoveByFirstPayRewardData(firstPayReward, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByFirstPayRewardData(long firstPayReward, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `FirstPayReward` = @FirstPayReward";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FirstPayReward", firstPayReward, MySqlDbType.Int64));
		}
		#endregion // RemoveByFirstPayReward
		#region RemoveBySumBet
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "sumBet">未发放奖励的下注总额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveBySumBet(long sumBet, TransactionManager tm_ = null)
		{
			RepairRemoveBySumBetData(sumBet, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveBySumBetAsync(long sumBet, TransactionManager tm_ = null)
		{
			RepairRemoveBySumBetData(sumBet, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveBySumBetData(long sumBet, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `SumBet` = @SumBet";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SumBet", sumBet, MySqlDbType.Int64));
		}
		#endregion // RemoveBySumBet
		#region RemoveByReturnRewards
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "returnRewards">当前应获得奖励金额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByReturnRewards(long returnRewards, TransactionManager tm_ = null)
		{
			RepairRemoveByReturnRewardsData(returnRewards, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByReturnRewardsAsync(long returnRewards, TransactionManager tm_ = null)
		{
			RepairRemoveByReturnRewardsData(returnRewards, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByReturnRewardsData(long returnRewards, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `ReturnRewards` = @ReturnRewards";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ReturnRewards", returnRewards, MySqlDbType.Int64));
		}
		#endregion // RemoveByReturnRewards
		#region RemoveByIsRegPay
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "isRegPay">是否发放过注册奖励</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByIsRegPay(bool isRegPay, TransactionManager tm_ = null)
		{
			RepairRemoveByIsRegPayData(isRegPay, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByIsRegPayAsync(bool isRegPay, TransactionManager tm_ = null)
		{
			RepairRemoveByIsRegPayData(isRegPay, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByIsRegPayData(bool isRegPay, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `IsRegPay` = @IsRegPay";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsRegPay", isRegPay, MySqlDbType.Byte));
		}
		#endregion // RemoveByIsRegPay
		#region RemoveByIsFirstPay
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "isFirstPay">是否发放过首充奖励</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByIsFirstPay(bool isFirstPay, TransactionManager tm_ = null)
		{
			RepairRemoveByIsFirstPayData(isFirstPay, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByIsFirstPayAsync(bool isFirstPay, TransactionManager tm_ = null)
		{
			RepairRemoveByIsFirstPayData(isFirstPay, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByIsFirstPayData(bool isFirstPay, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `IsFirstPay` = @IsFirstPay";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsFirstPay", isFirstPay, MySqlDbType.Byte));
		}
		#endregion // RemoveByIsFirstPay
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
		public int Put(Sa_regpay_userEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Sa_regpay_userEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Sa_regpay_userEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UserID` = @UserID, `OperatorID` = @OperatorID, `CountryId` = @CountryId, `CurrencyID` = @CurrencyID, `SumPay` = @SumPay, `RegPay` = @RegPay, `FirstPay` = @FirstPay, `RegPayReward` = @RegPayReward, `FirstPayReward` = @FirstPayReward, `SumBet` = @SumBet, `ReturnRewards` = @ReturnRewards, `IsRegPay` = @IsRegPay, `IsFirstPay` = @IsFirstPay WHERE `UserID` = @UserID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryId", item.CountryId != null ? item.CountryId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID != null ? item.CurrencyID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@SumPay", item.SumPay, MySqlDbType.Int64),
				Database.CreateInParameter("@RegPay", item.RegPay, MySqlDbType.Int64),
				Database.CreateInParameter("@FirstPay", item.FirstPay, MySqlDbType.Int64),
				Database.CreateInParameter("@RegPayReward", item.RegPayReward, MySqlDbType.Int64),
				Database.CreateInParameter("@FirstPayReward", item.FirstPayReward, MySqlDbType.Int64),
				Database.CreateInParameter("@SumBet", item.SumBet, MySqlDbType.Int64),
				Database.CreateInParameter("@ReturnRewards", item.ReturnRewards, MySqlDbType.Int64),
				Database.CreateInParameter("@IsRegPay", item.IsRegPay, MySqlDbType.Byte),
				Database.CreateInParameter("@IsFirstPay", item.IsFirstPay, MySqlDbType.Byte),
				Database.CreateInParameter("@UserID_Original", item.HasOriginal ? item.OriginalUserID : item.UserID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Sa_regpay_userEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Sa_regpay_userEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "userID">用户编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string userID, string set_, params object[] values_)
		{
			return Put(set_, "`UserID` = @UserID", ConcatValues(values_, userID));
		}
		public async Task<int> PutByPKAsync(string userID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`UserID` = @UserID", ConcatValues(values_, userID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string userID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`UserID` = @UserID", tm_, ConcatValues(values_, userID));
		}
		public async Task<int> PutByPKAsync(string userID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`UserID` = @UserID", tm_, ConcatValues(values_, userID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string userID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`UserID` = @UserID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string userID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`UserID` = @UserID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutOperatorID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorIDByPK(string userID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(userID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOperatorIDByPKAsync(string userID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(userID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOperatorIDByPKData(string userID, string operatorID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
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
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCountryIdByPK(string userID, string countryId, TransactionManager tm_ = null)
		{
			RepairPutCountryIdByPKData(userID, countryId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCountryIdByPKAsync(string userID, string countryId, TransactionManager tm_ = null)
		{
			RepairPutCountryIdByPKData(userID, countryId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCountryIdByPKData(string userID, string countryId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CountryId` = @CountryId  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryId", countryId != null ? countryId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
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
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCurrencyIDByPK(string userID, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(userID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCurrencyIDByPKAsync(string userID, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(userID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCurrencyIDByPKData(string userID, string currencyID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CurrencyID` = @CurrencyID  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CurrencyID", currencyID != null ? currencyID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
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
		#region PutSumPay
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "sumPay">奖金总额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSumPayByPK(string userID, long sumPay, TransactionManager tm_ = null)
		{
			RepairPutSumPayByPKData(userID, sumPay, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutSumPayByPKAsync(string userID, long sumPay, TransactionManager tm_ = null)
		{
			RepairPutSumPayByPKData(userID, sumPay, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutSumPayByPKData(string userID, long sumPay, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `SumPay` = @SumPay  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SumPay", sumPay, MySqlDbType.Int64),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "sumPay">奖金总额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSumPay(long sumPay, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SumPay` = @SumPay";
			var parameter_ = Database.CreateInParameter("@SumPay", sumPay, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutSumPayAsync(long sumPay, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SumPay` = @SumPay";
			var parameter_ = Database.CreateInParameter("@SumPay", sumPay, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutSumPay
		#region PutRegPay
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "regPay">注册奖金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRegPayByPK(string userID, long regPay, TransactionManager tm_ = null)
		{
			RepairPutRegPayByPKData(userID, regPay, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRegPayByPKAsync(string userID, long regPay, TransactionManager tm_ = null)
		{
			RepairPutRegPayByPKData(userID, regPay, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRegPayByPKData(string userID, long regPay, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RegPay` = @RegPay  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RegPay", regPay, MySqlDbType.Int64),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "regPay">注册奖金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRegPay(long regPay, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RegPay` = @RegPay";
			var parameter_ = Database.CreateInParameter("@RegPay", regPay, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutRegPayAsync(long regPay, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RegPay` = @RegPay";
			var parameter_ = Database.CreateInParameter("@RegPay", regPay, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutRegPay
		#region PutFirstPay
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "firstPay">首充奖金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFirstPayByPK(string userID, long firstPay, TransactionManager tm_ = null)
		{
			RepairPutFirstPayByPKData(userID, firstPay, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFirstPayByPKAsync(string userID, long firstPay, TransactionManager tm_ = null)
		{
			RepairPutFirstPayByPKData(userID, firstPay, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFirstPayByPKData(string userID, long firstPay, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `FirstPay` = @FirstPay  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@FirstPay", firstPay, MySqlDbType.Int64),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "firstPay">首充奖金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFirstPay(long firstPay, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FirstPay` = @FirstPay";
			var parameter_ = Database.CreateInParameter("@FirstPay", firstPay, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutFirstPayAsync(long firstPay, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FirstPay` = @FirstPay";
			var parameter_ = Database.CreateInParameter("@FirstPay", firstPay, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutFirstPay
		#region PutRegPayReward
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "regPayReward">注册奖金发放总金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRegPayRewardByPK(string userID, long regPayReward, TransactionManager tm_ = null)
		{
			RepairPutRegPayRewardByPKData(userID, regPayReward, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRegPayRewardByPKAsync(string userID, long regPayReward, TransactionManager tm_ = null)
		{
			RepairPutRegPayRewardByPKData(userID, regPayReward, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRegPayRewardByPKData(string userID, long regPayReward, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RegPayReward` = @RegPayReward  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RegPayReward", regPayReward, MySqlDbType.Int64),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "regPayReward">注册奖金发放总金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRegPayReward(long regPayReward, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RegPayReward` = @RegPayReward";
			var parameter_ = Database.CreateInParameter("@RegPayReward", regPayReward, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutRegPayRewardAsync(long regPayReward, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RegPayReward` = @RegPayReward";
			var parameter_ = Database.CreateInParameter("@RegPayReward", regPayReward, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutRegPayReward
		#region PutFirstPayReward
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "firstPayReward">首充奖金发放总金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFirstPayRewardByPK(string userID, long firstPayReward, TransactionManager tm_ = null)
		{
			RepairPutFirstPayRewardByPKData(userID, firstPayReward, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFirstPayRewardByPKAsync(string userID, long firstPayReward, TransactionManager tm_ = null)
		{
			RepairPutFirstPayRewardByPKData(userID, firstPayReward, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFirstPayRewardByPKData(string userID, long firstPayReward, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `FirstPayReward` = @FirstPayReward  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@FirstPayReward", firstPayReward, MySqlDbType.Int64),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "firstPayReward">首充奖金发放总金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFirstPayReward(long firstPayReward, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FirstPayReward` = @FirstPayReward";
			var parameter_ = Database.CreateInParameter("@FirstPayReward", firstPayReward, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutFirstPayRewardAsync(long firstPayReward, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FirstPayReward` = @FirstPayReward";
			var parameter_ = Database.CreateInParameter("@FirstPayReward", firstPayReward, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutFirstPayReward
		#region PutSumBet
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "sumBet">未发放奖励的下注总额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSumBetByPK(string userID, long sumBet, TransactionManager tm_ = null)
		{
			RepairPutSumBetByPKData(userID, sumBet, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutSumBetByPKAsync(string userID, long sumBet, TransactionManager tm_ = null)
		{
			RepairPutSumBetByPKData(userID, sumBet, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutSumBetByPKData(string userID, long sumBet, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `SumBet` = @SumBet  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SumBet", sumBet, MySqlDbType.Int64),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "sumBet">未发放奖励的下注总额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSumBet(long sumBet, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SumBet` = @SumBet";
			var parameter_ = Database.CreateInParameter("@SumBet", sumBet, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutSumBetAsync(long sumBet, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SumBet` = @SumBet";
			var parameter_ = Database.CreateInParameter("@SumBet", sumBet, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutSumBet
		#region PutReturnRewards
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "returnRewards">当前应获得奖励金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutReturnRewardsByPK(string userID, long returnRewards, TransactionManager tm_ = null)
		{
			RepairPutReturnRewardsByPKData(userID, returnRewards, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutReturnRewardsByPKAsync(string userID, long returnRewards, TransactionManager tm_ = null)
		{
			RepairPutReturnRewardsByPKData(userID, returnRewards, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutReturnRewardsByPKData(string userID, long returnRewards, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ReturnRewards` = @ReturnRewards  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ReturnRewards", returnRewards, MySqlDbType.Int64),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "returnRewards">当前应获得奖励金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutReturnRewards(long returnRewards, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ReturnRewards` = @ReturnRewards";
			var parameter_ = Database.CreateInParameter("@ReturnRewards", returnRewards, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutReturnRewardsAsync(long returnRewards, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ReturnRewards` = @ReturnRewards";
			var parameter_ = Database.CreateInParameter("@ReturnRewards", returnRewards, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutReturnRewards
		#region PutIsRegPay
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "isRegPay">是否发放过注册奖励</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsRegPayByPK(string userID, bool isRegPay, TransactionManager tm_ = null)
		{
			RepairPutIsRegPayByPKData(userID, isRegPay, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutIsRegPayByPKAsync(string userID, bool isRegPay, TransactionManager tm_ = null)
		{
			RepairPutIsRegPayByPKData(userID, isRegPay, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutIsRegPayByPKData(string userID, bool isRegPay, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `IsRegPay` = @IsRegPay  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@IsRegPay", isRegPay, MySqlDbType.Byte),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "isRegPay">是否发放过注册奖励</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsRegPay(bool isRegPay, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsRegPay` = @IsRegPay";
			var parameter_ = Database.CreateInParameter("@IsRegPay", isRegPay, MySqlDbType.Byte);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutIsRegPayAsync(bool isRegPay, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsRegPay` = @IsRegPay";
			var parameter_ = Database.CreateInParameter("@IsRegPay", isRegPay, MySqlDbType.Byte);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutIsRegPay
		#region PutIsFirstPay
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "isFirstPay">是否发放过首充奖励</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsFirstPayByPK(string userID, bool isFirstPay, TransactionManager tm_ = null)
		{
			RepairPutIsFirstPayByPKData(userID, isFirstPay, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutIsFirstPayByPKAsync(string userID, bool isFirstPay, TransactionManager tm_ = null)
		{
			RepairPutIsFirstPayByPKData(userID, isFirstPay, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutIsFirstPayByPKData(string userID, bool isFirstPay, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `IsFirstPay` = @IsFirstPay  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@IsFirstPay", isFirstPay, MySqlDbType.Byte),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "isFirstPay">是否发放过首充奖励</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsFirstPay(bool isFirstPay, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsFirstPay` = @IsFirstPay";
			var parameter_ = Database.CreateInParameter("@IsFirstPay", isFirstPay, MySqlDbType.Byte);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutIsFirstPayAsync(bool isFirstPay, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsFirstPay` = @IsFirstPay";
			var parameter_ = Database.CreateInParameter("@IsFirstPay", isFirstPay, MySqlDbType.Byte);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutIsFirstPay
		#region PutRecDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(string userID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(userID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(string userID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(userID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(string userID, DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
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
		public bool Set(Sa_regpay_userEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.UserID) == null)
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
		public async Task<bool> SetAsync(Sa_regpay_userEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.UserID) == null)
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
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Sa_regpay_userEO GetByPK(string userID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(userID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sa_regpay_userEO.MapDataReader);
		}
		public async Task<Sa_regpay_userEO> GetByPKAsync(string userID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(userID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sa_regpay_userEO.MapDataReader);
		}
		private void RepairGetByPKData(string userID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`UserID` = @UserID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 OperatorID（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorIDByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OperatorID`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<string> GetOperatorIDByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OperatorID`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CountryId（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCountryIdByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CountryId`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<string> GetCountryIdByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CountryId`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CurrencyID（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCurrencyIDByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CurrencyID`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<string> GetCurrencyIDByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CurrencyID`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 SumPay（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetSumPayByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`SumPay`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetSumPayByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`SumPay`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RegPay（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetRegPayByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`RegPay`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetRegPayByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`RegPay`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 FirstPay（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetFirstPayByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`FirstPay`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetFirstPayByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`FirstPay`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RegPayReward（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetRegPayRewardByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`RegPayReward`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetRegPayRewardByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`RegPayReward`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 FirstPayReward（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetFirstPayRewardByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`FirstPayReward`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetFirstPayRewardByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`FirstPayReward`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 SumBet（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetSumBetByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`SumBet`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetSumBetByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`SumBet`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ReturnRewards（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetReturnRewardsByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`ReturnRewards`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetReturnRewardsByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`ReturnRewards`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 IsRegPay（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public bool GetIsRegPayByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (bool)GetScalar("`IsRegPay`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<bool> GetIsRegPayByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (bool)await GetScalarAsync("`IsRegPay`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 IsFirstPay（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public bool GetIsFirstPayByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (bool)GetScalar("`IsFirstPay`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<bool> GetIsFirstPayByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (bool)await GetScalarAsync("`IsFirstPay`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetRecDateByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`RecDate`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<DateTime> GetRecDateByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`RecDate`", "`UserID` = @UserID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<Sa_regpay_userEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_regpay_userEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<Sa_regpay_userEO>> GetByOperatorIDAsync(string operatorID, int top_)
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
		public List<Sa_regpay_userEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_regpay_userEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<Sa_regpay_userEO>> GetByOperatorIDAsync(string operatorID, string sort_)
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
		public List<Sa_regpay_userEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<Sa_regpay_userEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
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
		public List<Sa_regpay_userEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_regpay_userEO.MapDataReader);
		}
		public async Task<List<Sa_regpay_userEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_regpay_userEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByCountryId
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetByCountryId(string countryId)
		{
			return GetByCountryId(countryId, 0, string.Empty, null);
		}
		public async Task<List<Sa_regpay_userEO>> GetByCountryIdAsync(string countryId)
		{
			return await GetByCountryIdAsync(countryId, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetByCountryId(string countryId, TransactionManager tm_)
		{
			return GetByCountryId(countryId, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_regpay_userEO>> GetByCountryIdAsync(string countryId, TransactionManager tm_)
		{
			return await GetByCountryIdAsync(countryId, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetByCountryId(string countryId, int top_)
		{
			return GetByCountryId(countryId, top_, string.Empty, null);
		}
		public async Task<List<Sa_regpay_userEO>> GetByCountryIdAsync(string countryId, int top_)
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
		public List<Sa_regpay_userEO> GetByCountryId(string countryId, int top_, TransactionManager tm_)
		{
			return GetByCountryId(countryId, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_regpay_userEO>> GetByCountryIdAsync(string countryId, int top_, TransactionManager tm_)
		{
			return await GetByCountryIdAsync(countryId, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetByCountryId(string countryId, string sort_)
		{
			return GetByCountryId(countryId, 0, sort_, null);
		}
		public async Task<List<Sa_regpay_userEO>> GetByCountryIdAsync(string countryId, string sort_)
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
		public List<Sa_regpay_userEO> GetByCountryId(string countryId, string sort_, TransactionManager tm_)
		{
			return GetByCountryId(countryId, 0, sort_, tm_);
		}
		public async Task<List<Sa_regpay_userEO>> GetByCountryIdAsync(string countryId, string sort_, TransactionManager tm_)
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
		public List<Sa_regpay_userEO> GetByCountryId(string countryId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(countryId != null ? "`CountryId` = @CountryId" : "`CountryId` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (countryId != null)
				paras_.Add(Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_regpay_userEO.MapDataReader);
		}
		public async Task<List<Sa_regpay_userEO>> GetByCountryIdAsync(string countryId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(countryId != null ? "`CountryId` = @CountryId" : "`CountryId` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (countryId != null)
				paras_.Add(Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_regpay_userEO.MapDataReader);
		}
		#endregion // GetByCountryId
		#region GetByCurrencyID
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetByCurrencyID(string currencyID)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, null);
		}
		public async Task<List<Sa_regpay_userEO>> GetByCurrencyIDAsync(string currencyID)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetByCurrencyID(string currencyID, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_regpay_userEO>> GetByCurrencyIDAsync(string currencyID, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetByCurrencyID(string currencyID, int top_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, null);
		}
		public async Task<List<Sa_regpay_userEO>> GetByCurrencyIDAsync(string currencyID, int top_)
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
		public List<Sa_regpay_userEO> GetByCurrencyID(string currencyID, int top_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_regpay_userEO>> GetByCurrencyIDAsync(string currencyID, int top_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetByCurrencyID(string currencyID, string sort_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, null);
		}
		public async Task<List<Sa_regpay_userEO>> GetByCurrencyIDAsync(string currencyID, string sort_)
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
		public List<Sa_regpay_userEO> GetByCurrencyID(string currencyID, string sort_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, tm_);
		}
		public async Task<List<Sa_regpay_userEO>> GetByCurrencyIDAsync(string currencyID, string sort_, TransactionManager tm_)
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
		public List<Sa_regpay_userEO> GetByCurrencyID(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(currencyID != null ? "`CurrencyID` = @CurrencyID" : "`CurrencyID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (currencyID != null)
				paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_regpay_userEO.MapDataReader);
		}
		public async Task<List<Sa_regpay_userEO>> GetByCurrencyIDAsync(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(currencyID != null ? "`CurrencyID` = @CurrencyID" : "`CurrencyID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (currencyID != null)
				paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_regpay_userEO.MapDataReader);
		}
		#endregion // GetByCurrencyID
		#region GetBySumPay
		
		/// <summary>
		/// 按 SumPay（字段） 查询
		/// </summary>
		/// /// <param name = "sumPay">奖金总额</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetBySumPay(long sumPay)
		{
			return GetBySumPay(sumPay, 0, string.Empty, null);
		}
		public async Task<List<Sa_regpay_userEO>> GetBySumPayAsync(long sumPay)
		{
			return await GetBySumPayAsync(sumPay, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SumPay（字段） 查询
		/// </summary>
		/// /// <param name = "sumPay">奖金总额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetBySumPay(long sumPay, TransactionManager tm_)
		{
			return GetBySumPay(sumPay, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_regpay_userEO>> GetBySumPayAsync(long sumPay, TransactionManager tm_)
		{
			return await GetBySumPayAsync(sumPay, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SumPay（字段） 查询
		/// </summary>
		/// /// <param name = "sumPay">奖金总额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetBySumPay(long sumPay, int top_)
		{
			return GetBySumPay(sumPay, top_, string.Empty, null);
		}
		public async Task<List<Sa_regpay_userEO>> GetBySumPayAsync(long sumPay, int top_)
		{
			return await GetBySumPayAsync(sumPay, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SumPay（字段） 查询
		/// </summary>
		/// /// <param name = "sumPay">奖金总额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetBySumPay(long sumPay, int top_, TransactionManager tm_)
		{
			return GetBySumPay(sumPay, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_regpay_userEO>> GetBySumPayAsync(long sumPay, int top_, TransactionManager tm_)
		{
			return await GetBySumPayAsync(sumPay, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SumPay（字段） 查询
		/// </summary>
		/// /// <param name = "sumPay">奖金总额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetBySumPay(long sumPay, string sort_)
		{
			return GetBySumPay(sumPay, 0, sort_, null);
		}
		public async Task<List<Sa_regpay_userEO>> GetBySumPayAsync(long sumPay, string sort_)
		{
			return await GetBySumPayAsync(sumPay, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 SumPay（字段） 查询
		/// </summary>
		/// /// <param name = "sumPay">奖金总额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetBySumPay(long sumPay, string sort_, TransactionManager tm_)
		{
			return GetBySumPay(sumPay, 0, sort_, tm_);
		}
		public async Task<List<Sa_regpay_userEO>> GetBySumPayAsync(long sumPay, string sort_, TransactionManager tm_)
		{
			return await GetBySumPayAsync(sumPay, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 SumPay（字段） 查询
		/// </summary>
		/// /// <param name = "sumPay">奖金总额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetBySumPay(long sumPay, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SumPay` = @SumPay", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SumPay", sumPay, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_regpay_userEO.MapDataReader);
		}
		public async Task<List<Sa_regpay_userEO>> GetBySumPayAsync(long sumPay, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SumPay` = @SumPay", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SumPay", sumPay, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_regpay_userEO.MapDataReader);
		}
		#endregion // GetBySumPay
		#region GetByRegPay
		
		/// <summary>
		/// 按 RegPay（字段） 查询
		/// </summary>
		/// /// <param name = "regPay">注册奖金</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetByRegPay(long regPay)
		{
			return GetByRegPay(regPay, 0, string.Empty, null);
		}
		public async Task<List<Sa_regpay_userEO>> GetByRegPayAsync(long regPay)
		{
			return await GetByRegPayAsync(regPay, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RegPay（字段） 查询
		/// </summary>
		/// /// <param name = "regPay">注册奖金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetByRegPay(long regPay, TransactionManager tm_)
		{
			return GetByRegPay(regPay, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_regpay_userEO>> GetByRegPayAsync(long regPay, TransactionManager tm_)
		{
			return await GetByRegPayAsync(regPay, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RegPay（字段） 查询
		/// </summary>
		/// /// <param name = "regPay">注册奖金</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetByRegPay(long regPay, int top_)
		{
			return GetByRegPay(regPay, top_, string.Empty, null);
		}
		public async Task<List<Sa_regpay_userEO>> GetByRegPayAsync(long regPay, int top_)
		{
			return await GetByRegPayAsync(regPay, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RegPay（字段） 查询
		/// </summary>
		/// /// <param name = "regPay">注册奖金</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetByRegPay(long regPay, int top_, TransactionManager tm_)
		{
			return GetByRegPay(regPay, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_regpay_userEO>> GetByRegPayAsync(long regPay, int top_, TransactionManager tm_)
		{
			return await GetByRegPayAsync(regPay, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RegPay（字段） 查询
		/// </summary>
		/// /// <param name = "regPay">注册奖金</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetByRegPay(long regPay, string sort_)
		{
			return GetByRegPay(regPay, 0, sort_, null);
		}
		public async Task<List<Sa_regpay_userEO>> GetByRegPayAsync(long regPay, string sort_)
		{
			return await GetByRegPayAsync(regPay, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RegPay（字段） 查询
		/// </summary>
		/// /// <param name = "regPay">注册奖金</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetByRegPay(long regPay, string sort_, TransactionManager tm_)
		{
			return GetByRegPay(regPay, 0, sort_, tm_);
		}
		public async Task<List<Sa_regpay_userEO>> GetByRegPayAsync(long regPay, string sort_, TransactionManager tm_)
		{
			return await GetByRegPayAsync(regPay, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RegPay（字段） 查询
		/// </summary>
		/// /// <param name = "regPay">注册奖金</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetByRegPay(long regPay, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RegPay` = @RegPay", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RegPay", regPay, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_regpay_userEO.MapDataReader);
		}
		public async Task<List<Sa_regpay_userEO>> GetByRegPayAsync(long regPay, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RegPay` = @RegPay", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RegPay", regPay, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_regpay_userEO.MapDataReader);
		}
		#endregion // GetByRegPay
		#region GetByFirstPay
		
		/// <summary>
		/// 按 FirstPay（字段） 查询
		/// </summary>
		/// /// <param name = "firstPay">首充奖金</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetByFirstPay(long firstPay)
		{
			return GetByFirstPay(firstPay, 0, string.Empty, null);
		}
		public async Task<List<Sa_regpay_userEO>> GetByFirstPayAsync(long firstPay)
		{
			return await GetByFirstPayAsync(firstPay, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FirstPay（字段） 查询
		/// </summary>
		/// /// <param name = "firstPay">首充奖金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetByFirstPay(long firstPay, TransactionManager tm_)
		{
			return GetByFirstPay(firstPay, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_regpay_userEO>> GetByFirstPayAsync(long firstPay, TransactionManager tm_)
		{
			return await GetByFirstPayAsync(firstPay, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FirstPay（字段） 查询
		/// </summary>
		/// /// <param name = "firstPay">首充奖金</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetByFirstPay(long firstPay, int top_)
		{
			return GetByFirstPay(firstPay, top_, string.Empty, null);
		}
		public async Task<List<Sa_regpay_userEO>> GetByFirstPayAsync(long firstPay, int top_)
		{
			return await GetByFirstPayAsync(firstPay, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FirstPay（字段） 查询
		/// </summary>
		/// /// <param name = "firstPay">首充奖金</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetByFirstPay(long firstPay, int top_, TransactionManager tm_)
		{
			return GetByFirstPay(firstPay, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_regpay_userEO>> GetByFirstPayAsync(long firstPay, int top_, TransactionManager tm_)
		{
			return await GetByFirstPayAsync(firstPay, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FirstPay（字段） 查询
		/// </summary>
		/// /// <param name = "firstPay">首充奖金</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetByFirstPay(long firstPay, string sort_)
		{
			return GetByFirstPay(firstPay, 0, sort_, null);
		}
		public async Task<List<Sa_regpay_userEO>> GetByFirstPayAsync(long firstPay, string sort_)
		{
			return await GetByFirstPayAsync(firstPay, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 FirstPay（字段） 查询
		/// </summary>
		/// /// <param name = "firstPay">首充奖金</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetByFirstPay(long firstPay, string sort_, TransactionManager tm_)
		{
			return GetByFirstPay(firstPay, 0, sort_, tm_);
		}
		public async Task<List<Sa_regpay_userEO>> GetByFirstPayAsync(long firstPay, string sort_, TransactionManager tm_)
		{
			return await GetByFirstPayAsync(firstPay, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 FirstPay（字段） 查询
		/// </summary>
		/// /// <param name = "firstPay">首充奖金</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetByFirstPay(long firstPay, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FirstPay` = @FirstPay", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FirstPay", firstPay, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_regpay_userEO.MapDataReader);
		}
		public async Task<List<Sa_regpay_userEO>> GetByFirstPayAsync(long firstPay, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FirstPay` = @FirstPay", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FirstPay", firstPay, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_regpay_userEO.MapDataReader);
		}
		#endregion // GetByFirstPay
		#region GetByRegPayReward
		
		/// <summary>
		/// 按 RegPayReward（字段） 查询
		/// </summary>
		/// /// <param name = "regPayReward">注册奖金发放总金额</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetByRegPayReward(long regPayReward)
		{
			return GetByRegPayReward(regPayReward, 0, string.Empty, null);
		}
		public async Task<List<Sa_regpay_userEO>> GetByRegPayRewardAsync(long regPayReward)
		{
			return await GetByRegPayRewardAsync(regPayReward, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RegPayReward（字段） 查询
		/// </summary>
		/// /// <param name = "regPayReward">注册奖金发放总金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetByRegPayReward(long regPayReward, TransactionManager tm_)
		{
			return GetByRegPayReward(regPayReward, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_regpay_userEO>> GetByRegPayRewardAsync(long regPayReward, TransactionManager tm_)
		{
			return await GetByRegPayRewardAsync(regPayReward, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RegPayReward（字段） 查询
		/// </summary>
		/// /// <param name = "regPayReward">注册奖金发放总金额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetByRegPayReward(long regPayReward, int top_)
		{
			return GetByRegPayReward(regPayReward, top_, string.Empty, null);
		}
		public async Task<List<Sa_regpay_userEO>> GetByRegPayRewardAsync(long regPayReward, int top_)
		{
			return await GetByRegPayRewardAsync(regPayReward, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RegPayReward（字段） 查询
		/// </summary>
		/// /// <param name = "regPayReward">注册奖金发放总金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetByRegPayReward(long regPayReward, int top_, TransactionManager tm_)
		{
			return GetByRegPayReward(regPayReward, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_regpay_userEO>> GetByRegPayRewardAsync(long regPayReward, int top_, TransactionManager tm_)
		{
			return await GetByRegPayRewardAsync(regPayReward, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RegPayReward（字段） 查询
		/// </summary>
		/// /// <param name = "regPayReward">注册奖金发放总金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetByRegPayReward(long regPayReward, string sort_)
		{
			return GetByRegPayReward(regPayReward, 0, sort_, null);
		}
		public async Task<List<Sa_regpay_userEO>> GetByRegPayRewardAsync(long regPayReward, string sort_)
		{
			return await GetByRegPayRewardAsync(regPayReward, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RegPayReward（字段） 查询
		/// </summary>
		/// /// <param name = "regPayReward">注册奖金发放总金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetByRegPayReward(long regPayReward, string sort_, TransactionManager tm_)
		{
			return GetByRegPayReward(regPayReward, 0, sort_, tm_);
		}
		public async Task<List<Sa_regpay_userEO>> GetByRegPayRewardAsync(long regPayReward, string sort_, TransactionManager tm_)
		{
			return await GetByRegPayRewardAsync(regPayReward, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RegPayReward（字段） 查询
		/// </summary>
		/// /// <param name = "regPayReward">注册奖金发放总金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetByRegPayReward(long regPayReward, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RegPayReward` = @RegPayReward", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RegPayReward", regPayReward, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_regpay_userEO.MapDataReader);
		}
		public async Task<List<Sa_regpay_userEO>> GetByRegPayRewardAsync(long regPayReward, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RegPayReward` = @RegPayReward", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RegPayReward", regPayReward, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_regpay_userEO.MapDataReader);
		}
		#endregion // GetByRegPayReward
		#region GetByFirstPayReward
		
		/// <summary>
		/// 按 FirstPayReward（字段） 查询
		/// </summary>
		/// /// <param name = "firstPayReward">首充奖金发放总金额</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetByFirstPayReward(long firstPayReward)
		{
			return GetByFirstPayReward(firstPayReward, 0, string.Empty, null);
		}
		public async Task<List<Sa_regpay_userEO>> GetByFirstPayRewardAsync(long firstPayReward)
		{
			return await GetByFirstPayRewardAsync(firstPayReward, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FirstPayReward（字段） 查询
		/// </summary>
		/// /// <param name = "firstPayReward">首充奖金发放总金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetByFirstPayReward(long firstPayReward, TransactionManager tm_)
		{
			return GetByFirstPayReward(firstPayReward, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_regpay_userEO>> GetByFirstPayRewardAsync(long firstPayReward, TransactionManager tm_)
		{
			return await GetByFirstPayRewardAsync(firstPayReward, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FirstPayReward（字段） 查询
		/// </summary>
		/// /// <param name = "firstPayReward">首充奖金发放总金额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetByFirstPayReward(long firstPayReward, int top_)
		{
			return GetByFirstPayReward(firstPayReward, top_, string.Empty, null);
		}
		public async Task<List<Sa_regpay_userEO>> GetByFirstPayRewardAsync(long firstPayReward, int top_)
		{
			return await GetByFirstPayRewardAsync(firstPayReward, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FirstPayReward（字段） 查询
		/// </summary>
		/// /// <param name = "firstPayReward">首充奖金发放总金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetByFirstPayReward(long firstPayReward, int top_, TransactionManager tm_)
		{
			return GetByFirstPayReward(firstPayReward, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_regpay_userEO>> GetByFirstPayRewardAsync(long firstPayReward, int top_, TransactionManager tm_)
		{
			return await GetByFirstPayRewardAsync(firstPayReward, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FirstPayReward（字段） 查询
		/// </summary>
		/// /// <param name = "firstPayReward">首充奖金发放总金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetByFirstPayReward(long firstPayReward, string sort_)
		{
			return GetByFirstPayReward(firstPayReward, 0, sort_, null);
		}
		public async Task<List<Sa_regpay_userEO>> GetByFirstPayRewardAsync(long firstPayReward, string sort_)
		{
			return await GetByFirstPayRewardAsync(firstPayReward, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 FirstPayReward（字段） 查询
		/// </summary>
		/// /// <param name = "firstPayReward">首充奖金发放总金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetByFirstPayReward(long firstPayReward, string sort_, TransactionManager tm_)
		{
			return GetByFirstPayReward(firstPayReward, 0, sort_, tm_);
		}
		public async Task<List<Sa_regpay_userEO>> GetByFirstPayRewardAsync(long firstPayReward, string sort_, TransactionManager tm_)
		{
			return await GetByFirstPayRewardAsync(firstPayReward, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 FirstPayReward（字段） 查询
		/// </summary>
		/// /// <param name = "firstPayReward">首充奖金发放总金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetByFirstPayReward(long firstPayReward, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FirstPayReward` = @FirstPayReward", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FirstPayReward", firstPayReward, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_regpay_userEO.MapDataReader);
		}
		public async Task<List<Sa_regpay_userEO>> GetByFirstPayRewardAsync(long firstPayReward, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FirstPayReward` = @FirstPayReward", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FirstPayReward", firstPayReward, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_regpay_userEO.MapDataReader);
		}
		#endregion // GetByFirstPayReward
		#region GetBySumBet
		
		/// <summary>
		/// 按 SumBet（字段） 查询
		/// </summary>
		/// /// <param name = "sumBet">未发放奖励的下注总额</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetBySumBet(long sumBet)
		{
			return GetBySumBet(sumBet, 0, string.Empty, null);
		}
		public async Task<List<Sa_regpay_userEO>> GetBySumBetAsync(long sumBet)
		{
			return await GetBySumBetAsync(sumBet, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SumBet（字段） 查询
		/// </summary>
		/// /// <param name = "sumBet">未发放奖励的下注总额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetBySumBet(long sumBet, TransactionManager tm_)
		{
			return GetBySumBet(sumBet, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_regpay_userEO>> GetBySumBetAsync(long sumBet, TransactionManager tm_)
		{
			return await GetBySumBetAsync(sumBet, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SumBet（字段） 查询
		/// </summary>
		/// /// <param name = "sumBet">未发放奖励的下注总额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetBySumBet(long sumBet, int top_)
		{
			return GetBySumBet(sumBet, top_, string.Empty, null);
		}
		public async Task<List<Sa_regpay_userEO>> GetBySumBetAsync(long sumBet, int top_)
		{
			return await GetBySumBetAsync(sumBet, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SumBet（字段） 查询
		/// </summary>
		/// /// <param name = "sumBet">未发放奖励的下注总额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetBySumBet(long sumBet, int top_, TransactionManager tm_)
		{
			return GetBySumBet(sumBet, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_regpay_userEO>> GetBySumBetAsync(long sumBet, int top_, TransactionManager tm_)
		{
			return await GetBySumBetAsync(sumBet, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SumBet（字段） 查询
		/// </summary>
		/// /// <param name = "sumBet">未发放奖励的下注总额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetBySumBet(long sumBet, string sort_)
		{
			return GetBySumBet(sumBet, 0, sort_, null);
		}
		public async Task<List<Sa_regpay_userEO>> GetBySumBetAsync(long sumBet, string sort_)
		{
			return await GetBySumBetAsync(sumBet, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 SumBet（字段） 查询
		/// </summary>
		/// /// <param name = "sumBet">未发放奖励的下注总额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetBySumBet(long sumBet, string sort_, TransactionManager tm_)
		{
			return GetBySumBet(sumBet, 0, sort_, tm_);
		}
		public async Task<List<Sa_regpay_userEO>> GetBySumBetAsync(long sumBet, string sort_, TransactionManager tm_)
		{
			return await GetBySumBetAsync(sumBet, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 SumBet（字段） 查询
		/// </summary>
		/// /// <param name = "sumBet">未发放奖励的下注总额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetBySumBet(long sumBet, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SumBet` = @SumBet", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SumBet", sumBet, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_regpay_userEO.MapDataReader);
		}
		public async Task<List<Sa_regpay_userEO>> GetBySumBetAsync(long sumBet, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SumBet` = @SumBet", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SumBet", sumBet, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_regpay_userEO.MapDataReader);
		}
		#endregion // GetBySumBet
		#region GetByReturnRewards
		
		/// <summary>
		/// 按 ReturnRewards（字段） 查询
		/// </summary>
		/// /// <param name = "returnRewards">当前应获得奖励金额</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetByReturnRewards(long returnRewards)
		{
			return GetByReturnRewards(returnRewards, 0, string.Empty, null);
		}
		public async Task<List<Sa_regpay_userEO>> GetByReturnRewardsAsync(long returnRewards)
		{
			return await GetByReturnRewardsAsync(returnRewards, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ReturnRewards（字段） 查询
		/// </summary>
		/// /// <param name = "returnRewards">当前应获得奖励金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetByReturnRewards(long returnRewards, TransactionManager tm_)
		{
			return GetByReturnRewards(returnRewards, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_regpay_userEO>> GetByReturnRewardsAsync(long returnRewards, TransactionManager tm_)
		{
			return await GetByReturnRewardsAsync(returnRewards, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ReturnRewards（字段） 查询
		/// </summary>
		/// /// <param name = "returnRewards">当前应获得奖励金额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetByReturnRewards(long returnRewards, int top_)
		{
			return GetByReturnRewards(returnRewards, top_, string.Empty, null);
		}
		public async Task<List<Sa_regpay_userEO>> GetByReturnRewardsAsync(long returnRewards, int top_)
		{
			return await GetByReturnRewardsAsync(returnRewards, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ReturnRewards（字段） 查询
		/// </summary>
		/// /// <param name = "returnRewards">当前应获得奖励金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetByReturnRewards(long returnRewards, int top_, TransactionManager tm_)
		{
			return GetByReturnRewards(returnRewards, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_regpay_userEO>> GetByReturnRewardsAsync(long returnRewards, int top_, TransactionManager tm_)
		{
			return await GetByReturnRewardsAsync(returnRewards, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ReturnRewards（字段） 查询
		/// </summary>
		/// /// <param name = "returnRewards">当前应获得奖励金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetByReturnRewards(long returnRewards, string sort_)
		{
			return GetByReturnRewards(returnRewards, 0, sort_, null);
		}
		public async Task<List<Sa_regpay_userEO>> GetByReturnRewardsAsync(long returnRewards, string sort_)
		{
			return await GetByReturnRewardsAsync(returnRewards, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ReturnRewards（字段） 查询
		/// </summary>
		/// /// <param name = "returnRewards">当前应获得奖励金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetByReturnRewards(long returnRewards, string sort_, TransactionManager tm_)
		{
			return GetByReturnRewards(returnRewards, 0, sort_, tm_);
		}
		public async Task<List<Sa_regpay_userEO>> GetByReturnRewardsAsync(long returnRewards, string sort_, TransactionManager tm_)
		{
			return await GetByReturnRewardsAsync(returnRewards, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ReturnRewards（字段） 查询
		/// </summary>
		/// /// <param name = "returnRewards">当前应获得奖励金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetByReturnRewards(long returnRewards, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ReturnRewards` = @ReturnRewards", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ReturnRewards", returnRewards, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_regpay_userEO.MapDataReader);
		}
		public async Task<List<Sa_regpay_userEO>> GetByReturnRewardsAsync(long returnRewards, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ReturnRewards` = @ReturnRewards", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ReturnRewards", returnRewards, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_regpay_userEO.MapDataReader);
		}
		#endregion // GetByReturnRewards
		#region GetByIsRegPay
		
		/// <summary>
		/// 按 IsRegPay（字段） 查询
		/// </summary>
		/// /// <param name = "isRegPay">是否发放过注册奖励</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetByIsRegPay(bool isRegPay)
		{
			return GetByIsRegPay(isRegPay, 0, string.Empty, null);
		}
		public async Task<List<Sa_regpay_userEO>> GetByIsRegPayAsync(bool isRegPay)
		{
			return await GetByIsRegPayAsync(isRegPay, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsRegPay（字段） 查询
		/// </summary>
		/// /// <param name = "isRegPay">是否发放过注册奖励</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetByIsRegPay(bool isRegPay, TransactionManager tm_)
		{
			return GetByIsRegPay(isRegPay, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_regpay_userEO>> GetByIsRegPayAsync(bool isRegPay, TransactionManager tm_)
		{
			return await GetByIsRegPayAsync(isRegPay, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsRegPay（字段） 查询
		/// </summary>
		/// /// <param name = "isRegPay">是否发放过注册奖励</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetByIsRegPay(bool isRegPay, int top_)
		{
			return GetByIsRegPay(isRegPay, top_, string.Empty, null);
		}
		public async Task<List<Sa_regpay_userEO>> GetByIsRegPayAsync(bool isRegPay, int top_)
		{
			return await GetByIsRegPayAsync(isRegPay, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsRegPay（字段） 查询
		/// </summary>
		/// /// <param name = "isRegPay">是否发放过注册奖励</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetByIsRegPay(bool isRegPay, int top_, TransactionManager tm_)
		{
			return GetByIsRegPay(isRegPay, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_regpay_userEO>> GetByIsRegPayAsync(bool isRegPay, int top_, TransactionManager tm_)
		{
			return await GetByIsRegPayAsync(isRegPay, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsRegPay（字段） 查询
		/// </summary>
		/// /// <param name = "isRegPay">是否发放过注册奖励</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetByIsRegPay(bool isRegPay, string sort_)
		{
			return GetByIsRegPay(isRegPay, 0, sort_, null);
		}
		public async Task<List<Sa_regpay_userEO>> GetByIsRegPayAsync(bool isRegPay, string sort_)
		{
			return await GetByIsRegPayAsync(isRegPay, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 IsRegPay（字段） 查询
		/// </summary>
		/// /// <param name = "isRegPay">是否发放过注册奖励</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetByIsRegPay(bool isRegPay, string sort_, TransactionManager tm_)
		{
			return GetByIsRegPay(isRegPay, 0, sort_, tm_);
		}
		public async Task<List<Sa_regpay_userEO>> GetByIsRegPayAsync(bool isRegPay, string sort_, TransactionManager tm_)
		{
			return await GetByIsRegPayAsync(isRegPay, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 IsRegPay（字段） 查询
		/// </summary>
		/// /// <param name = "isRegPay">是否发放过注册奖励</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetByIsRegPay(bool isRegPay, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsRegPay` = @IsRegPay", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsRegPay", isRegPay, MySqlDbType.Byte));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_regpay_userEO.MapDataReader);
		}
		public async Task<List<Sa_regpay_userEO>> GetByIsRegPayAsync(bool isRegPay, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsRegPay` = @IsRegPay", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsRegPay", isRegPay, MySqlDbType.Byte));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_regpay_userEO.MapDataReader);
		}
		#endregion // GetByIsRegPay
		#region GetByIsFirstPay
		
		/// <summary>
		/// 按 IsFirstPay（字段） 查询
		/// </summary>
		/// /// <param name = "isFirstPay">是否发放过首充奖励</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetByIsFirstPay(bool isFirstPay)
		{
			return GetByIsFirstPay(isFirstPay, 0, string.Empty, null);
		}
		public async Task<List<Sa_regpay_userEO>> GetByIsFirstPayAsync(bool isFirstPay)
		{
			return await GetByIsFirstPayAsync(isFirstPay, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsFirstPay（字段） 查询
		/// </summary>
		/// /// <param name = "isFirstPay">是否发放过首充奖励</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetByIsFirstPay(bool isFirstPay, TransactionManager tm_)
		{
			return GetByIsFirstPay(isFirstPay, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_regpay_userEO>> GetByIsFirstPayAsync(bool isFirstPay, TransactionManager tm_)
		{
			return await GetByIsFirstPayAsync(isFirstPay, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsFirstPay（字段） 查询
		/// </summary>
		/// /// <param name = "isFirstPay">是否发放过首充奖励</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetByIsFirstPay(bool isFirstPay, int top_)
		{
			return GetByIsFirstPay(isFirstPay, top_, string.Empty, null);
		}
		public async Task<List<Sa_regpay_userEO>> GetByIsFirstPayAsync(bool isFirstPay, int top_)
		{
			return await GetByIsFirstPayAsync(isFirstPay, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsFirstPay（字段） 查询
		/// </summary>
		/// /// <param name = "isFirstPay">是否发放过首充奖励</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetByIsFirstPay(bool isFirstPay, int top_, TransactionManager tm_)
		{
			return GetByIsFirstPay(isFirstPay, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_regpay_userEO>> GetByIsFirstPayAsync(bool isFirstPay, int top_, TransactionManager tm_)
		{
			return await GetByIsFirstPayAsync(isFirstPay, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsFirstPay（字段） 查询
		/// </summary>
		/// /// <param name = "isFirstPay">是否发放过首充奖励</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetByIsFirstPay(bool isFirstPay, string sort_)
		{
			return GetByIsFirstPay(isFirstPay, 0, sort_, null);
		}
		public async Task<List<Sa_regpay_userEO>> GetByIsFirstPayAsync(bool isFirstPay, string sort_)
		{
			return await GetByIsFirstPayAsync(isFirstPay, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 IsFirstPay（字段） 查询
		/// </summary>
		/// /// <param name = "isFirstPay">是否发放过首充奖励</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetByIsFirstPay(bool isFirstPay, string sort_, TransactionManager tm_)
		{
			return GetByIsFirstPay(isFirstPay, 0, sort_, tm_);
		}
		public async Task<List<Sa_regpay_userEO>> GetByIsFirstPayAsync(bool isFirstPay, string sort_, TransactionManager tm_)
		{
			return await GetByIsFirstPayAsync(isFirstPay, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 IsFirstPay（字段） 查询
		/// </summary>
		/// /// <param name = "isFirstPay">是否发放过首充奖励</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetByIsFirstPay(bool isFirstPay, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsFirstPay` = @IsFirstPay", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsFirstPay", isFirstPay, MySqlDbType.Byte));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_regpay_userEO.MapDataReader);
		}
		public async Task<List<Sa_regpay_userEO>> GetByIsFirstPayAsync(bool isFirstPay, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsFirstPay` = @IsFirstPay", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsFirstPay", isFirstPay, MySqlDbType.Byte));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_regpay_userEO.MapDataReader);
		}
		#endregion // GetByIsFirstPay
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<Sa_regpay_userEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_regpay_userEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<Sa_regpay_userEO>> GetByRecDateAsync(DateTime recDate, int top_)
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
		public List<Sa_regpay_userEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_regpay_userEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_regpay_userEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<Sa_regpay_userEO>> GetByRecDateAsync(DateTime recDate, string sort_)
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
		public List<Sa_regpay_userEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<Sa_regpay_userEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
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
		public List<Sa_regpay_userEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_regpay_userEO.MapDataReader);
		}
		public async Task<List<Sa_regpay_userEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_regpay_userEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
