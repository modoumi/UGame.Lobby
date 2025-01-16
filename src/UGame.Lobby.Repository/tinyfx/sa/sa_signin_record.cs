/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * AiUo代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/AiUo
 * 文档生成时间：2023-10-24 18: 04:55
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
	/// 
	/// 【表 sa_signin_record 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Sa_signin_recordEO : IRowMapper<Sa_signin_recordEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Sa_signin_recordEO()
		{
			this.RecordID = "0";
			this.Level = 1;
			this.Amount = 0;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private string _originalRecordID;
		/// <summary>
		/// 【数据库中的原始主键 RecordID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalRecordID
		{
			get { return _originalRecordID; }
			set { HasOriginal = true; _originalRecordID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "RecordID", RecordID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 编号
		/// 【主键 varchar(36)】
		/// </summary>
		[DataMember(Order = 1)]
		public string RecordID { get; set; }
		/// <summary>
		/// banner编号
		/// 【字段 varchar(36)】
		/// </summary>
		[DataMember(Order = 2)]
		public string BannerID { get; set; }
		/// <summary>
		/// 用户编号
		/// 【字段 varchar(36)】
		/// </summary>
		[DataMember(Order = 3)]
		public string UserID { get; set; }
		/// <summary>
		/// 签到时间
		/// 【字段 date】
		/// </summary>
		[DataMember(Order = 4)]
		public DateTime? DayID { get; set; }
		/// <summary>
		/// 等级
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 5)]
		public int? Level { get; set; }
		/// <summary>
		/// 签到状态
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 6)]
		public int? Flag { get; set; }
		/// <summary>
		/// 签到时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 7)]
		public DateTime? RecDate { get; set; }
		/// <summary>
		/// 获取奖励时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 8)]
		public DateTime? UpdateDate { get; set; }
		/// <summary>
		/// 
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 9)]
		public string OperatorID { get; set; }
		/// <summary>
		/// 
		/// 【字段 varchar(5)】
		/// </summary>
		[DataMember(Order = 10)]
		public string CountryID { get; set; }
		/// <summary>
		/// 
		/// 【字段 varchar(5)】
		/// </summary>
		[DataMember(Order = 11)]
		public string CurrencyID { get; set; }
		/// <summary>
		/// 
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 12)]
		public long Amount { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Sa_signin_recordEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Sa_signin_recordEO MapDataReader(IDataReader reader)
		{
		    Sa_signin_recordEO ret = new Sa_signin_recordEO();
			ret.RecordID = reader.ToString("RecordID");
			ret.OriginalRecordID = ret.RecordID;
			ret.BannerID = reader.ToString("BannerID");
			ret.UserID = reader.ToString("UserID");
			ret.DayID = reader.ToDateTimeN("DayID");
			ret.Level = reader.ToInt32N("Level");
			ret.Flag = reader.ToInt32N("Flag");
			ret.RecDate = reader.ToDateTimeN("RecDate");
			ret.UpdateDate = reader.ToDateTimeN("UpdateDate");
			ret.OperatorID = reader.ToString("OperatorID");
			ret.CountryID = reader.ToString("CountryID");
			ret.CurrencyID = reader.ToString("CurrencyID");
			ret.Amount = reader.ToInt64("Amount");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 
	/// 【表 sa_signin_record 的操作类】
	/// </summary>
	[Obsolete]
	public class Sa_signin_recordMO : MySqlTableMO<Sa_signin_recordEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`sa_signin_record`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Sa_signin_recordMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Sa_signin_recordMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Sa_signin_recordMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Sa_signin_recordEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Sa_signin_recordEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Sa_signin_recordEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`RecordID`, `BannerID`, `UserID`, `DayID`, `Level`, `Flag`, `RecDate`, `UpdateDate`, `OperatorID`, `CountryID`, `CurrencyID`, `Amount`) VALUE (@RecordID, @BannerID, @UserID, @DayID, @Level, @Flag, @RecDate, @UpdateDate, @OperatorID, @CountryID, @CurrencyID, @Amount);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecordID", item.RecordID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BannerID", item.BannerID != null ? item.BannerID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", item.UserID != null ? item.UserID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@DayID", item.DayID.HasValue ? item.DayID.Value : (object)DBNull.Value, MySqlDbType.Date),
				Database.CreateInParameter("@Level", item.Level.HasValue ? item.Level.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@Flag", item.Flag.HasValue ? item.Flag.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@RecDate", item.RecDate.HasValue ? item.RecDate.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@UpdateDate", item.UpdateDate.HasValue ? item.UpdateDate.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@OperatorID", item.OperatorID != null ? item.OperatorID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", item.CountryID != null ? item.CountryID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID != null ? item.CurrencyID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Amount", item.Amount, MySqlDbType.Int64),
			};
		}
		public int AddByBatch(IEnumerable<Sa_signin_recordEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Sa_signin_recordEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sa_signin_recordEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`RecordID`, `BannerID`, `UserID`, `DayID`, `Level`, `Flag`, `RecDate`, `UpdateDate`, `OperatorID`, `CountryID`, `CurrencyID`, `Amount`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.RecordID}','{item.BannerID}','{item.UserID}','{item.DayID?.ToString("yyyy-MM-dd HH:mm:ss")}',{item.Level?.ToString()??null},{item.Flag?.ToString()??null},'{item.RecDate?.ToString("yyyy-MM-dd HH:mm:ss")}','{item.UpdateDate?.ToString("yyyy-MM-dd HH:mm:ss")}','{item.OperatorID}','{item.CountryID}','{item.CurrencyID}',{item.Amount}),");
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
		/// /// <param name = "recordID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string recordID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(recordID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string recordID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(recordID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string recordID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `RecordID` = @RecordID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecordID", recordID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Sa_signin_recordEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.RecordID, tm_);
		}
		public async Task<int> RemoveAsync(Sa_signin_recordEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.RecordID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByBannerID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "bannerID">banner编号</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByBannerID(string bannerID, TransactionManager tm_ = null)
		{
			RepairRemoveByBannerIDData(bannerID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByBannerIDAsync(string bannerID, TransactionManager tm_ = null)
		{
			RepairRemoveByBannerIDData(bannerID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByBannerIDData(string bannerID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (bannerID != null ? "`BannerID` = @BannerID" : "`BannerID` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (bannerID != null)
				paras_.Add(Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByBannerID
		#region RemoveByUserID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "userID">用户编号</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByUserID(string userID, TransactionManager tm_ = null)
		{
			RepairRemoveByUserIDData(userID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByUserIDAsync(string userID, TransactionManager tm_ = null)
		{
			RepairRemoveByUserIDData(userID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByUserIDData(string userID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (userID != null ? "`UserID` = @UserID" : "`UserID` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (userID != null)
				paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByUserID
		#region RemoveByDayID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "dayID">签到时间</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByDayID(DateTime? dayID, TransactionManager tm_ = null)
		{
			RepairRemoveByDayIDData(dayID.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByDayIDAsync(DateTime? dayID, TransactionManager tm_ = null)
		{
			RepairRemoveByDayIDData(dayID.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByDayIDData(DateTime? dayID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (dayID.HasValue ? "`DayID` = @DayID" : "`DayID` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (dayID.HasValue)
				paras_.Add(Database.CreateInParameter("@DayID", dayID.Value, MySqlDbType.Date));
		}
		#endregion // RemoveByDayID
		#region RemoveByLevel
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "level">等级</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByLevel(int? level, TransactionManager tm_ = null)
		{
			RepairRemoveByLevelData(level.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByLevelAsync(int? level, TransactionManager tm_ = null)
		{
			RepairRemoveByLevelData(level.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByLevelData(int? level, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (level.HasValue ? "`Level` = @Level" : "`Level` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (level.HasValue)
				paras_.Add(Database.CreateInParameter("@Level", level.Value, MySqlDbType.Int32));
		}
		#endregion // RemoveByLevel
		#region RemoveByFlag
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "flag">签到状态</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByFlag(int? flag, TransactionManager tm_ = null)
		{
			RepairRemoveByFlagData(flag.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByFlagAsync(int? flag, TransactionManager tm_ = null)
		{
			RepairRemoveByFlagData(flag.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByFlagData(int? flag, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (flag.HasValue ? "`Flag` = @Flag" : "`Flag` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (flag.HasValue)
				paras_.Add(Database.CreateInParameter("@Flag", flag.Value, MySqlDbType.Int32));
		}
		#endregion // RemoveByFlag
		#region RemoveByRecDate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "recDate">签到时间</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByRecDate(DateTime? recDate, TransactionManager tm_ = null)
		{
			RepairRemoveByRecDateData(recDate.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByRecDateAsync(DateTime? recDate, TransactionManager tm_ = null)
		{
			RepairRemoveByRecDateData(recDate.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByRecDateData(DateTime? recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (recDate.HasValue ? "`RecDate` = @RecDate" : "`RecDate` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (recDate.HasValue)
				paras_.Add(Database.CreateInParameter("@RecDate", recDate.Value, MySqlDbType.DateTime));
		}
		#endregion // RemoveByRecDate
		#region RemoveByUpdateDate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "updateDate">获取奖励时间</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByUpdateDate(DateTime? updateDate, TransactionManager tm_ = null)
		{
			RepairRemoveByUpdateDateData(updateDate.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByUpdateDateAsync(DateTime? updateDate, TransactionManager tm_ = null)
		{
			RepairRemoveByUpdateDateData(updateDate.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByUpdateDateData(DateTime? updateDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (updateDate.HasValue ? "`UpdateDate` = @UpdateDate" : "`UpdateDate` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (updateDate.HasValue)
				paras_.Add(Database.CreateInParameter("@UpdateDate", updateDate.Value, MySqlDbType.DateTime));
		}
		#endregion // RemoveByUpdateDate
		#region RemoveByOperatorID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "operatorID"></param>
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
			sql_ = $"DELETE FROM {TableName} WHERE " + (operatorID != null ? "`OperatorID` = @OperatorID" : "`OperatorID` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (operatorID != null)
				paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByOperatorID
		#region RemoveByCountryID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "countryID"></param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCountryID(string countryID, TransactionManager tm_ = null)
		{
			RepairRemoveByCountryIDData(countryID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCountryIDAsync(string countryID, TransactionManager tm_ = null)
		{
			RepairRemoveByCountryIDData(countryID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCountryIDData(string countryID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (countryID != null ? "`CountryID` = @CountryID" : "`CountryID` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (countryID != null)
				paras_.Add(Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByCountryID
		#region RemoveByCurrencyID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "currencyID"></param>
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
		#region RemoveByAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "amount"></param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByAmount(long amount, TransactionManager tm_ = null)
		{
			RepairRemoveByAmountData(amount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByAmountAsync(long amount, TransactionManager tm_ = null)
		{
			RepairRemoveByAmountData(amount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByAmountData(long amount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Amount` = @Amount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Amount", amount, MySqlDbType.Int64));
		}
		#endregion // RemoveByAmount
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
		public int Put(Sa_signin_recordEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Sa_signin_recordEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Sa_signin_recordEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecordID` = @RecordID, `BannerID` = @BannerID, `UserID` = @UserID, `DayID` = @DayID, `Level` = @Level, `Flag` = @Flag, `RecDate` = @RecDate, `UpdateDate` = @UpdateDate, `OperatorID` = @OperatorID, `CountryID` = @CountryID, `CurrencyID` = @CurrencyID, `Amount` = @Amount WHERE `RecordID` = @RecordID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecordID", item.RecordID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BannerID", item.BannerID != null ? item.BannerID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", item.UserID != null ? item.UserID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@DayID", item.DayID.HasValue ? item.DayID.Value : (object)DBNull.Value, MySqlDbType.Date),
				Database.CreateInParameter("@Level", item.Level.HasValue ? item.Level.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@Flag", item.Flag.HasValue ? item.Flag.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@RecDate", item.RecDate.HasValue ? item.RecDate.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@UpdateDate", item.UpdateDate.HasValue ? item.UpdateDate.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@OperatorID", item.OperatorID != null ? item.OperatorID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", item.CountryID != null ? item.CountryID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID != null ? item.CurrencyID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Amount", item.Amount, MySqlDbType.Int64),
				Database.CreateInParameter("@RecordID_Original", item.HasOriginal ? item.OriginalRecordID : item.RecordID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Sa_signin_recordEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Sa_signin_recordEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "recordID">编号</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string recordID, string set_, params object[] values_)
		{
			return Put(set_, "`RecordID` = @RecordID", ConcatValues(values_, recordID));
		}
		public async Task<int> PutByPKAsync(string recordID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`RecordID` = @RecordID", ConcatValues(values_, recordID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "recordID">编号</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string recordID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`RecordID` = @RecordID", tm_, ConcatValues(values_, recordID));
		}
		public async Task<int> PutByPKAsync(string recordID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`RecordID` = @RecordID", tm_, ConcatValues(values_, recordID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "recordID">编号</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string recordID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@RecordID", recordID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`RecordID` = @RecordID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string recordID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@RecordID", recordID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`RecordID` = @RecordID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutBannerID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "recordID">编号</param>
		/// /// <param name = "bannerID">banner编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBannerIDByPK(string recordID, string bannerID, TransactionManager tm_ = null)
		{
			RepairPutBannerIDByPKData(recordID, bannerID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBannerIDByPKAsync(string recordID, string bannerID, TransactionManager tm_ = null)
		{
			RepairPutBannerIDByPKData(recordID, bannerID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBannerIDByPKData(string recordID, string bannerID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BannerID` = @BannerID  WHERE `RecordID` = @RecordID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BannerID", bannerID != null ? bannerID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@RecordID", recordID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "bannerID">banner编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBannerID(string bannerID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BannerID` = @BannerID";
			var parameter_ = Database.CreateInParameter("@BannerID", bannerID != null ? bannerID : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutBannerIDAsync(string bannerID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BannerID` = @BannerID";
			var parameter_ = Database.CreateInParameter("@BannerID", bannerID != null ? bannerID : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutBannerID
		#region PutUserID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "recordID">编号</param>
		/// /// <param name = "userID">用户编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserIDByPK(string recordID, string userID, TransactionManager tm_ = null)
		{
			RepairPutUserIDByPKData(recordID, userID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutUserIDByPKAsync(string recordID, string userID, TransactionManager tm_ = null)
		{
			RepairPutUserIDByPKData(recordID, userID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutUserIDByPKData(string recordID, string userID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UserID` = @UserID  WHERE `RecordID` = @RecordID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID != null ? userID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@RecordID", recordID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "userID">用户编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserID(string userID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserID` = @UserID";
			var parameter_ = Database.CreateInParameter("@UserID", userID != null ? userID : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutUserIDAsync(string userID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserID` = @UserID";
			var parameter_ = Database.CreateInParameter("@UserID", userID != null ? userID : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutUserID
		#region PutDayID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "recordID">编号</param>
		/// /// <param name = "dayID">签到时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutDayIDByPK(string recordID, DateTime? dayID, TransactionManager tm_ = null)
		{
			RepairPutDayIDByPKData(recordID, dayID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutDayIDByPKAsync(string recordID, DateTime? dayID, TransactionManager tm_ = null)
		{
			RepairPutDayIDByPKData(recordID, dayID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutDayIDByPKData(string recordID, DateTime? dayID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `DayID` = @DayID  WHERE `RecordID` = @RecordID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID.HasValue ? dayID.Value : (object)DBNull.Value, MySqlDbType.Date),
				Database.CreateInParameter("@RecordID", recordID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "dayID">签到时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutDayID(DateTime? dayID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `DayID` = @DayID";
			var parameter_ = Database.CreateInParameter("@DayID", dayID.HasValue ? dayID.Value : (object)DBNull.Value, MySqlDbType.Date);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutDayIDAsync(DateTime? dayID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `DayID` = @DayID";
			var parameter_ = Database.CreateInParameter("@DayID", dayID.HasValue ? dayID.Value : (object)DBNull.Value, MySqlDbType.Date);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutDayID
		#region PutLevel
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "recordID">编号</param>
		/// /// <param name = "level">等级</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLevelByPK(string recordID, int? level, TransactionManager tm_ = null)
		{
			RepairPutLevelByPKData(recordID, level, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLevelByPKAsync(string recordID, int? level, TransactionManager tm_ = null)
		{
			RepairPutLevelByPKData(recordID, level, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLevelByPKData(string recordID, int? level, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Level` = @Level  WHERE `RecordID` = @RecordID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Level", level.HasValue ? level.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@RecordID", recordID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "level">等级</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLevel(int? level, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Level` = @Level";
			var parameter_ = Database.CreateInParameter("@Level", level.HasValue ? level.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutLevelAsync(int? level, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Level` = @Level";
			var parameter_ = Database.CreateInParameter("@Level", level.HasValue ? level.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutLevel
		#region PutFlag
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "recordID">编号</param>
		/// /// <param name = "flag">签到状态</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFlagByPK(string recordID, int? flag, TransactionManager tm_ = null)
		{
			RepairPutFlagByPKData(recordID, flag, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFlagByPKAsync(string recordID, int? flag, TransactionManager tm_ = null)
		{
			RepairPutFlagByPKData(recordID, flag, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFlagByPKData(string recordID, int? flag, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Flag` = @Flag  WHERE `RecordID` = @RecordID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Flag", flag.HasValue ? flag.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@RecordID", recordID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "flag">签到状态</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFlag(int? flag, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Flag` = @Flag";
			var parameter_ = Database.CreateInParameter("@Flag", flag.HasValue ? flag.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutFlagAsync(int? flag, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Flag` = @Flag";
			var parameter_ = Database.CreateInParameter("@Flag", flag.HasValue ? flag.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutFlag
		#region PutRecDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "recordID">编号</param>
		/// /// <param name = "recDate">签到时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(string recordID, DateTime? recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(recordID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(string recordID, DateTime? recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(recordID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(string recordID, DateTime? recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `RecordID` = @RecordID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate.HasValue ? recDate.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@RecordID", recordID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "recDate">签到时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDate(DateTime? recDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate";
			var parameter_ = Database.CreateInParameter("@RecDate", recDate.HasValue ? recDate.Value : (object)DBNull.Value, MySqlDbType.DateTime);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutRecDateAsync(DateTime? recDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate";
			var parameter_ = Database.CreateInParameter("@RecDate", recDate.HasValue ? recDate.Value : (object)DBNull.Value, MySqlDbType.DateTime);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutRecDate
		#region PutUpdateDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "recordID">编号</param>
		/// /// <param name = "updateDate">获取奖励时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUpdateDateByPK(string recordID, DateTime? updateDate, TransactionManager tm_ = null)
		{
			RepairPutUpdateDateByPKData(recordID, updateDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutUpdateDateByPKAsync(string recordID, DateTime? updateDate, TransactionManager tm_ = null)
		{
			RepairPutUpdateDateByPKData(recordID, updateDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutUpdateDateByPKData(string recordID, DateTime? updateDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UpdateDate` = @UpdateDate  WHERE `RecordID` = @RecordID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UpdateDate", updateDate.HasValue ? updateDate.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@RecordID", recordID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "updateDate">获取奖励时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUpdateDate(DateTime? updateDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UpdateDate` = @UpdateDate";
			var parameter_ = Database.CreateInParameter("@UpdateDate", updateDate.HasValue ? updateDate.Value : (object)DBNull.Value, MySqlDbType.DateTime);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutUpdateDateAsync(DateTime? updateDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UpdateDate` = @UpdateDate";
			var parameter_ = Database.CreateInParameter("@UpdateDate", updateDate.HasValue ? updateDate.Value : (object)DBNull.Value, MySqlDbType.DateTime);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutUpdateDate
		#region PutOperatorID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "recordID">编号</param>
		/// /// <param name = "operatorID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorIDByPK(string recordID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(recordID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOperatorIDByPKAsync(string recordID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(recordID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOperatorIDByPKData(string recordID, string operatorID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID  WHERE `RecordID` = @RecordID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID != null ? operatorID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@RecordID", recordID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "operatorID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorID(string operatorID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID";
			var parameter_ = Database.CreateInParameter("@OperatorID", operatorID != null ? operatorID : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutOperatorIDAsync(string operatorID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID";
			var parameter_ = Database.CreateInParameter("@OperatorID", operatorID != null ? operatorID : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutOperatorID
		#region PutCountryID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "recordID">编号</param>
		/// /// <param name = "countryID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCountryIDByPK(string recordID, string countryID, TransactionManager tm_ = null)
		{
			RepairPutCountryIDByPKData(recordID, countryID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCountryIDByPKAsync(string recordID, string countryID, TransactionManager tm_ = null)
		{
			RepairPutCountryIDByPKData(recordID, countryID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCountryIDByPKData(string recordID, string countryID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CountryID` = @CountryID  WHERE `RecordID` = @RecordID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryID", countryID != null ? countryID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@RecordID", recordID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "countryID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCountryID(string countryID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CountryID` = @CountryID";
			var parameter_ = Database.CreateInParameter("@CountryID", countryID != null ? countryID : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCountryIDAsync(string countryID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CountryID` = @CountryID";
			var parameter_ = Database.CreateInParameter("@CountryID", countryID != null ? countryID : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCountryID
		#region PutCurrencyID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "recordID">编号</param>
		/// /// <param name = "currencyID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCurrencyIDByPK(string recordID, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(recordID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCurrencyIDByPKAsync(string recordID, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(recordID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCurrencyIDByPKData(string recordID, string currencyID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CurrencyID` = @CurrencyID  WHERE `RecordID` = @RecordID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CurrencyID", currencyID != null ? currencyID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@RecordID", recordID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "currencyID"></param>
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
		#region PutAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "recordID">编号</param>
		/// /// <param name = "amount"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAmountByPK(string recordID, long amount, TransactionManager tm_ = null)
		{
			RepairPutAmountByPKData(recordID, amount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAmountByPKAsync(string recordID, long amount, TransactionManager tm_ = null)
		{
			RepairPutAmountByPKData(recordID, amount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutAmountByPKData(string recordID, long amount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Amount` = @Amount  WHERE `RecordID` = @RecordID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Amount", amount, MySqlDbType.Int64),
				Database.CreateInParameter("@RecordID", recordID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "amount"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAmount(long amount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Amount` = @Amount";
			var parameter_ = Database.CreateInParameter("@Amount", amount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutAmountAsync(long amount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Amount` = @Amount";
			var parameter_ = Database.CreateInParameter("@Amount", amount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutAmount
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Sa_signin_recordEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.RecordID) == null)
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
		public async Task<bool> SetAsync(Sa_signin_recordEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.RecordID) == null)
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
		/// /// <param name = "recordID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Sa_signin_recordEO GetByPK(string recordID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(recordID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sa_signin_recordEO.MapDataReader);
		}
		public async Task<Sa_signin_recordEO> GetByPKAsync(string recordID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(recordID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sa_signin_recordEO.MapDataReader);
		}
		private void RepairGetByPKData(string recordID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`RecordID` = @RecordID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecordID", recordID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 BannerID（字段）
		/// </summary>
		/// /// <param name = "recordID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetBannerIDByPK(string recordID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecordID", recordID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`BannerID`", "`RecordID` = @RecordID", paras_, tm_);
		}
		public async Task<string> GetBannerIDByPKAsync(string recordID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecordID", recordID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`BannerID`", "`RecordID` = @RecordID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 UserID（字段）
		/// </summary>
		/// /// <param name = "recordID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetUserIDByPK(string recordID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecordID", recordID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`UserID`", "`RecordID` = @RecordID", paras_, tm_);
		}
		public async Task<string> GetUserIDByPKAsync(string recordID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecordID", recordID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`UserID`", "`RecordID` = @RecordID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 DayID（字段）
		/// </summary>
		/// /// <param name = "recordID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime? GetDayIDByPK(string recordID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecordID", recordID, MySqlDbType.VarChar),
			};
			return (DateTime?)GetScalar("`DayID`", "`RecordID` = @RecordID", paras_, tm_);
		}
		public async Task<DateTime?> GetDayIDByPKAsync(string recordID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecordID", recordID, MySqlDbType.VarChar),
			};
			return (DateTime?)await GetScalarAsync("`DayID`", "`RecordID` = @RecordID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Level（字段）
		/// </summary>
		/// /// <param name = "recordID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int? GetLevelByPK(string recordID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecordID", recordID, MySqlDbType.VarChar),
			};
			return (int?)GetScalar("`Level`", "`RecordID` = @RecordID", paras_, tm_);
		}
		public async Task<int?> GetLevelByPKAsync(string recordID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecordID", recordID, MySqlDbType.VarChar),
			};
			return (int?)await GetScalarAsync("`Level`", "`RecordID` = @RecordID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Flag（字段）
		/// </summary>
		/// /// <param name = "recordID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int? GetFlagByPK(string recordID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecordID", recordID, MySqlDbType.VarChar),
			};
			return (int?)GetScalar("`Flag`", "`RecordID` = @RecordID", paras_, tm_);
		}
		public async Task<int?> GetFlagByPKAsync(string recordID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecordID", recordID, MySqlDbType.VarChar),
			};
			return (int?)await GetScalarAsync("`Flag`", "`RecordID` = @RecordID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "recordID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime? GetRecDateByPK(string recordID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecordID", recordID, MySqlDbType.VarChar),
			};
			return (DateTime?)GetScalar("`RecDate`", "`RecordID` = @RecordID", paras_, tm_);
		}
		public async Task<DateTime?> GetRecDateByPKAsync(string recordID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecordID", recordID, MySqlDbType.VarChar),
			};
			return (DateTime?)await GetScalarAsync("`RecDate`", "`RecordID` = @RecordID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 UpdateDate（字段）
		/// </summary>
		/// /// <param name = "recordID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime? GetUpdateDateByPK(string recordID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecordID", recordID, MySqlDbType.VarChar),
			};
			return (DateTime?)GetScalar("`UpdateDate`", "`RecordID` = @RecordID", paras_, tm_);
		}
		public async Task<DateTime?> GetUpdateDateByPKAsync(string recordID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecordID", recordID, MySqlDbType.VarChar),
			};
			return (DateTime?)await GetScalarAsync("`UpdateDate`", "`RecordID` = @RecordID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OperatorID（字段）
		/// </summary>
		/// /// <param name = "recordID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorIDByPK(string recordID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecordID", recordID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OperatorID`", "`RecordID` = @RecordID", paras_, tm_);
		}
		public async Task<string> GetOperatorIDByPKAsync(string recordID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecordID", recordID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OperatorID`", "`RecordID` = @RecordID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CountryID（字段）
		/// </summary>
		/// /// <param name = "recordID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCountryIDByPK(string recordID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecordID", recordID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CountryID`", "`RecordID` = @RecordID", paras_, tm_);
		}
		public async Task<string> GetCountryIDByPKAsync(string recordID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecordID", recordID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CountryID`", "`RecordID` = @RecordID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CurrencyID（字段）
		/// </summary>
		/// /// <param name = "recordID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCurrencyIDByPK(string recordID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecordID", recordID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CurrencyID`", "`RecordID` = @RecordID", paras_, tm_);
		}
		public async Task<string> GetCurrencyIDByPKAsync(string recordID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecordID", recordID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CurrencyID`", "`RecordID` = @RecordID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Amount（字段）
		/// </summary>
		/// /// <param name = "recordID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetAmountByPK(string recordID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecordID", recordID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`Amount`", "`RecordID` = @RecordID", paras_, tm_);
		}
		public async Task<long> GetAmountByPKAsync(string recordID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecordID", recordID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`Amount`", "`RecordID` = @RecordID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByBannerID
		
		/// <summary>
		/// 按 BannerID（字段） 查询
		/// </summary>
		/// /// <param name = "bannerID">banner编号</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByBannerID(string bannerID)
		{
			return GetByBannerID(bannerID, 0, string.Empty, null);
		}
		public async Task<List<Sa_signin_recordEO>> GetByBannerIDAsync(string bannerID)
		{
			return await GetByBannerIDAsync(bannerID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BannerID（字段） 查询
		/// </summary>
		/// /// <param name = "bannerID">banner编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByBannerID(string bannerID, TransactionManager tm_)
		{
			return GetByBannerID(bannerID, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_signin_recordEO>> GetByBannerIDAsync(string bannerID, TransactionManager tm_)
		{
			return await GetByBannerIDAsync(bannerID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BannerID（字段） 查询
		/// </summary>
		/// /// <param name = "bannerID">banner编号</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByBannerID(string bannerID, int top_)
		{
			return GetByBannerID(bannerID, top_, string.Empty, null);
		}
		public async Task<List<Sa_signin_recordEO>> GetByBannerIDAsync(string bannerID, int top_)
		{
			return await GetByBannerIDAsync(bannerID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BannerID（字段） 查询
		/// </summary>
		/// /// <param name = "bannerID">banner编号</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByBannerID(string bannerID, int top_, TransactionManager tm_)
		{
			return GetByBannerID(bannerID, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_signin_recordEO>> GetByBannerIDAsync(string bannerID, int top_, TransactionManager tm_)
		{
			return await GetByBannerIDAsync(bannerID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BannerID（字段） 查询
		/// </summary>
		/// /// <param name = "bannerID">banner编号</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByBannerID(string bannerID, string sort_)
		{
			return GetByBannerID(bannerID, 0, sort_, null);
		}
		public async Task<List<Sa_signin_recordEO>> GetByBannerIDAsync(string bannerID, string sort_)
		{
			return await GetByBannerIDAsync(bannerID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BannerID（字段） 查询
		/// </summary>
		/// /// <param name = "bannerID">banner编号</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByBannerID(string bannerID, string sort_, TransactionManager tm_)
		{
			return GetByBannerID(bannerID, 0, sort_, tm_);
		}
		public async Task<List<Sa_signin_recordEO>> GetByBannerIDAsync(string bannerID, string sort_, TransactionManager tm_)
		{
			return await GetByBannerIDAsync(bannerID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BannerID（字段） 查询
		/// </summary>
		/// /// <param name = "bannerID">banner编号</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByBannerID(string bannerID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(bannerID != null ? "`BannerID` = @BannerID" : "`BannerID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (bannerID != null)
				paras_.Add(Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_signin_recordEO.MapDataReader);
		}
		public async Task<List<Sa_signin_recordEO>> GetByBannerIDAsync(string bannerID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(bannerID != null ? "`BannerID` = @BannerID" : "`BannerID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (bannerID != null)
				paras_.Add(Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_signin_recordEO.MapDataReader);
		}
		#endregion // GetByBannerID
		#region GetByUserID
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编号</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByUserID(string userID)
		{
			return GetByUserID(userID, 0, string.Empty, null);
		}
		public async Task<List<Sa_signin_recordEO>> GetByUserIDAsync(string userID)
		{
			return await GetByUserIDAsync(userID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByUserID(string userID, TransactionManager tm_)
		{
			return GetByUserID(userID, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_signin_recordEO>> GetByUserIDAsync(string userID, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编号</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByUserID(string userID, int top_)
		{
			return GetByUserID(userID, top_, string.Empty, null);
		}
		public async Task<List<Sa_signin_recordEO>> GetByUserIDAsync(string userID, int top_)
		{
			return await GetByUserIDAsync(userID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编号</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByUserID(string userID, int top_, TransactionManager tm_)
		{
			return GetByUserID(userID, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_signin_recordEO>> GetByUserIDAsync(string userID, int top_, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编号</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByUserID(string userID, string sort_)
		{
			return GetByUserID(userID, 0, sort_, null);
		}
		public async Task<List<Sa_signin_recordEO>> GetByUserIDAsync(string userID, string sort_)
		{
			return await GetByUserIDAsync(userID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编号</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByUserID(string userID, string sort_, TransactionManager tm_)
		{
			return GetByUserID(userID, 0, sort_, tm_);
		}
		public async Task<List<Sa_signin_recordEO>> GetByUserIDAsync(string userID, string sort_, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编号</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByUserID(string userID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(userID != null ? "`UserID` = @UserID" : "`UserID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (userID != null)
				paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_signin_recordEO.MapDataReader);
		}
		public async Task<List<Sa_signin_recordEO>> GetByUserIDAsync(string userID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(userID != null ? "`UserID` = @UserID" : "`UserID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (userID != null)
				paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_signin_recordEO.MapDataReader);
		}
		#endregion // GetByUserID
		#region GetByDayID
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">签到时间</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByDayID(DateTime? dayID)
		{
			return GetByDayID(dayID, 0, string.Empty, null);
		}
		public async Task<List<Sa_signin_recordEO>> GetByDayIDAsync(DateTime? dayID)
		{
			return await GetByDayIDAsync(dayID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">签到时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByDayID(DateTime? dayID, TransactionManager tm_)
		{
			return GetByDayID(dayID, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_signin_recordEO>> GetByDayIDAsync(DateTime? dayID, TransactionManager tm_)
		{
			return await GetByDayIDAsync(dayID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">签到时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByDayID(DateTime? dayID, int top_)
		{
			return GetByDayID(dayID, top_, string.Empty, null);
		}
		public async Task<List<Sa_signin_recordEO>> GetByDayIDAsync(DateTime? dayID, int top_)
		{
			return await GetByDayIDAsync(dayID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">签到时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByDayID(DateTime? dayID, int top_, TransactionManager tm_)
		{
			return GetByDayID(dayID, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_signin_recordEO>> GetByDayIDAsync(DateTime? dayID, int top_, TransactionManager tm_)
		{
			return await GetByDayIDAsync(dayID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">签到时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByDayID(DateTime? dayID, string sort_)
		{
			return GetByDayID(dayID, 0, sort_, null);
		}
		public async Task<List<Sa_signin_recordEO>> GetByDayIDAsync(DateTime? dayID, string sort_)
		{
			return await GetByDayIDAsync(dayID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">签到时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByDayID(DateTime? dayID, string sort_, TransactionManager tm_)
		{
			return GetByDayID(dayID, 0, sort_, tm_);
		}
		public async Task<List<Sa_signin_recordEO>> GetByDayIDAsync(DateTime? dayID, string sort_, TransactionManager tm_)
		{
			return await GetByDayIDAsync(dayID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">签到时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByDayID(DateTime? dayID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(dayID.HasValue ? "`DayID` = @DayID" : "`DayID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (dayID.HasValue)
				paras_.Add(Database.CreateInParameter("@DayID", dayID.Value, MySqlDbType.Date));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_signin_recordEO.MapDataReader);
		}
		public async Task<List<Sa_signin_recordEO>> GetByDayIDAsync(DateTime? dayID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(dayID.HasValue ? "`DayID` = @DayID" : "`DayID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (dayID.HasValue)
				paras_.Add(Database.CreateInParameter("@DayID", dayID.Value, MySqlDbType.Date));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_signin_recordEO.MapDataReader);
		}
		#endregion // GetByDayID
		#region GetByLevel
		
		/// <summary>
		/// 按 Level（字段） 查询
		/// </summary>
		/// /// <param name = "level">等级</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByLevel(int? level)
		{
			return GetByLevel(level, 0, string.Empty, null);
		}
		public async Task<List<Sa_signin_recordEO>> GetByLevelAsync(int? level)
		{
			return await GetByLevelAsync(level, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Level（字段） 查询
		/// </summary>
		/// /// <param name = "level">等级</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByLevel(int? level, TransactionManager tm_)
		{
			return GetByLevel(level, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_signin_recordEO>> GetByLevelAsync(int? level, TransactionManager tm_)
		{
			return await GetByLevelAsync(level, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Level（字段） 查询
		/// </summary>
		/// /// <param name = "level">等级</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByLevel(int? level, int top_)
		{
			return GetByLevel(level, top_, string.Empty, null);
		}
		public async Task<List<Sa_signin_recordEO>> GetByLevelAsync(int? level, int top_)
		{
			return await GetByLevelAsync(level, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Level（字段） 查询
		/// </summary>
		/// /// <param name = "level">等级</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByLevel(int? level, int top_, TransactionManager tm_)
		{
			return GetByLevel(level, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_signin_recordEO>> GetByLevelAsync(int? level, int top_, TransactionManager tm_)
		{
			return await GetByLevelAsync(level, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Level（字段） 查询
		/// </summary>
		/// /// <param name = "level">等级</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByLevel(int? level, string sort_)
		{
			return GetByLevel(level, 0, sort_, null);
		}
		public async Task<List<Sa_signin_recordEO>> GetByLevelAsync(int? level, string sort_)
		{
			return await GetByLevelAsync(level, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Level（字段） 查询
		/// </summary>
		/// /// <param name = "level">等级</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByLevel(int? level, string sort_, TransactionManager tm_)
		{
			return GetByLevel(level, 0, sort_, tm_);
		}
		public async Task<List<Sa_signin_recordEO>> GetByLevelAsync(int? level, string sort_, TransactionManager tm_)
		{
			return await GetByLevelAsync(level, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Level（字段） 查询
		/// </summary>
		/// /// <param name = "level">等级</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByLevel(int? level, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(level.HasValue ? "`Level` = @Level" : "`Level` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (level.HasValue)
				paras_.Add(Database.CreateInParameter("@Level", level.Value, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_signin_recordEO.MapDataReader);
		}
		public async Task<List<Sa_signin_recordEO>> GetByLevelAsync(int? level, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(level.HasValue ? "`Level` = @Level" : "`Level` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (level.HasValue)
				paras_.Add(Database.CreateInParameter("@Level", level.Value, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_signin_recordEO.MapDataReader);
		}
		#endregion // GetByLevel
		#region GetByFlag
		
		/// <summary>
		/// 按 Flag（字段） 查询
		/// </summary>
		/// /// <param name = "flag">签到状态</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByFlag(int? flag)
		{
			return GetByFlag(flag, 0, string.Empty, null);
		}
		public async Task<List<Sa_signin_recordEO>> GetByFlagAsync(int? flag)
		{
			return await GetByFlagAsync(flag, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Flag（字段） 查询
		/// </summary>
		/// /// <param name = "flag">签到状态</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByFlag(int? flag, TransactionManager tm_)
		{
			return GetByFlag(flag, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_signin_recordEO>> GetByFlagAsync(int? flag, TransactionManager tm_)
		{
			return await GetByFlagAsync(flag, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Flag（字段） 查询
		/// </summary>
		/// /// <param name = "flag">签到状态</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByFlag(int? flag, int top_)
		{
			return GetByFlag(flag, top_, string.Empty, null);
		}
		public async Task<List<Sa_signin_recordEO>> GetByFlagAsync(int? flag, int top_)
		{
			return await GetByFlagAsync(flag, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Flag（字段） 查询
		/// </summary>
		/// /// <param name = "flag">签到状态</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByFlag(int? flag, int top_, TransactionManager tm_)
		{
			return GetByFlag(flag, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_signin_recordEO>> GetByFlagAsync(int? flag, int top_, TransactionManager tm_)
		{
			return await GetByFlagAsync(flag, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Flag（字段） 查询
		/// </summary>
		/// /// <param name = "flag">签到状态</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByFlag(int? flag, string sort_)
		{
			return GetByFlag(flag, 0, sort_, null);
		}
		public async Task<List<Sa_signin_recordEO>> GetByFlagAsync(int? flag, string sort_)
		{
			return await GetByFlagAsync(flag, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Flag（字段） 查询
		/// </summary>
		/// /// <param name = "flag">签到状态</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByFlag(int? flag, string sort_, TransactionManager tm_)
		{
			return GetByFlag(flag, 0, sort_, tm_);
		}
		public async Task<List<Sa_signin_recordEO>> GetByFlagAsync(int? flag, string sort_, TransactionManager tm_)
		{
			return await GetByFlagAsync(flag, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Flag（字段） 查询
		/// </summary>
		/// /// <param name = "flag">签到状态</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByFlag(int? flag, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(flag.HasValue ? "`Flag` = @Flag" : "`Flag` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (flag.HasValue)
				paras_.Add(Database.CreateInParameter("@Flag", flag.Value, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_signin_recordEO.MapDataReader);
		}
		public async Task<List<Sa_signin_recordEO>> GetByFlagAsync(int? flag, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(flag.HasValue ? "`Flag` = @Flag" : "`Flag` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (flag.HasValue)
				paras_.Add(Database.CreateInParameter("@Flag", flag.Value, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_signin_recordEO.MapDataReader);
		}
		#endregion // GetByFlag
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">签到时间</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByRecDate(DateTime? recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<Sa_signin_recordEO>> GetByRecDateAsync(DateTime? recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">签到时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByRecDate(DateTime? recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_signin_recordEO>> GetByRecDateAsync(DateTime? recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">签到时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByRecDate(DateTime? recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<Sa_signin_recordEO>> GetByRecDateAsync(DateTime? recDate, int top_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">签到时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByRecDate(DateTime? recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_signin_recordEO>> GetByRecDateAsync(DateTime? recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">签到时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByRecDate(DateTime? recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<Sa_signin_recordEO>> GetByRecDateAsync(DateTime? recDate, string sort_)
		{
			return await GetByRecDateAsync(recDate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">签到时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByRecDate(DateTime? recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<Sa_signin_recordEO>> GetByRecDateAsync(DateTime? recDate, string sort_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">签到时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByRecDate(DateTime? recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(recDate.HasValue ? "`RecDate` = @RecDate" : "`RecDate` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (recDate.HasValue)
				paras_.Add(Database.CreateInParameter("@RecDate", recDate.Value, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_signin_recordEO.MapDataReader);
		}
		public async Task<List<Sa_signin_recordEO>> GetByRecDateAsync(DateTime? recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(recDate.HasValue ? "`RecDate` = @RecDate" : "`RecDate` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (recDate.HasValue)
				paras_.Add(Database.CreateInParameter("@RecDate", recDate.Value, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_signin_recordEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#region GetByUpdateDate
		
		/// <summary>
		/// 按 UpdateDate（字段） 查询
		/// </summary>
		/// /// <param name = "updateDate">获取奖励时间</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByUpdateDate(DateTime? updateDate)
		{
			return GetByUpdateDate(updateDate, 0, string.Empty, null);
		}
		public async Task<List<Sa_signin_recordEO>> GetByUpdateDateAsync(DateTime? updateDate)
		{
			return await GetByUpdateDateAsync(updateDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UpdateDate（字段） 查询
		/// </summary>
		/// /// <param name = "updateDate">获取奖励时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByUpdateDate(DateTime? updateDate, TransactionManager tm_)
		{
			return GetByUpdateDate(updateDate, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_signin_recordEO>> GetByUpdateDateAsync(DateTime? updateDate, TransactionManager tm_)
		{
			return await GetByUpdateDateAsync(updateDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UpdateDate（字段） 查询
		/// </summary>
		/// /// <param name = "updateDate">获取奖励时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByUpdateDate(DateTime? updateDate, int top_)
		{
			return GetByUpdateDate(updateDate, top_, string.Empty, null);
		}
		public async Task<List<Sa_signin_recordEO>> GetByUpdateDateAsync(DateTime? updateDate, int top_)
		{
			return await GetByUpdateDateAsync(updateDate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UpdateDate（字段） 查询
		/// </summary>
		/// /// <param name = "updateDate">获取奖励时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByUpdateDate(DateTime? updateDate, int top_, TransactionManager tm_)
		{
			return GetByUpdateDate(updateDate, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_signin_recordEO>> GetByUpdateDateAsync(DateTime? updateDate, int top_, TransactionManager tm_)
		{
			return await GetByUpdateDateAsync(updateDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UpdateDate（字段） 查询
		/// </summary>
		/// /// <param name = "updateDate">获取奖励时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByUpdateDate(DateTime? updateDate, string sort_)
		{
			return GetByUpdateDate(updateDate, 0, sort_, null);
		}
		public async Task<List<Sa_signin_recordEO>> GetByUpdateDateAsync(DateTime? updateDate, string sort_)
		{
			return await GetByUpdateDateAsync(updateDate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 UpdateDate（字段） 查询
		/// </summary>
		/// /// <param name = "updateDate">获取奖励时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByUpdateDate(DateTime? updateDate, string sort_, TransactionManager tm_)
		{
			return GetByUpdateDate(updateDate, 0, sort_, tm_);
		}
		public async Task<List<Sa_signin_recordEO>> GetByUpdateDateAsync(DateTime? updateDate, string sort_, TransactionManager tm_)
		{
			return await GetByUpdateDateAsync(updateDate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 UpdateDate（字段） 查询
		/// </summary>
		/// /// <param name = "updateDate">获取奖励时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByUpdateDate(DateTime? updateDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(updateDate.HasValue ? "`UpdateDate` = @UpdateDate" : "`UpdateDate` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (updateDate.HasValue)
				paras_.Add(Database.CreateInParameter("@UpdateDate", updateDate.Value, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_signin_recordEO.MapDataReader);
		}
		public async Task<List<Sa_signin_recordEO>> GetByUpdateDateAsync(DateTime? updateDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(updateDate.HasValue ? "`UpdateDate` = @UpdateDate" : "`UpdateDate` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (updateDate.HasValue)
				paras_.Add(Database.CreateInParameter("@UpdateDate", updateDate.Value, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_signin_recordEO.MapDataReader);
		}
		#endregion // GetByUpdateDate
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID"></param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<Sa_signin_recordEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_signin_recordEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<Sa_signin_recordEO>> GetByOperatorIDAsync(string operatorID, int top_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_signin_recordEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<Sa_signin_recordEO>> GetByOperatorIDAsync(string operatorID, string sort_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<Sa_signin_recordEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operatorID != null ? "`OperatorID` = @OperatorID" : "`OperatorID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operatorID != null)
				paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_signin_recordEO.MapDataReader);
		}
		public async Task<List<Sa_signin_recordEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operatorID != null ? "`OperatorID` = @OperatorID" : "`OperatorID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operatorID != null)
				paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_signin_recordEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByCountryID
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID"></param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByCountryID(string countryID)
		{
			return GetByCountryID(countryID, 0, string.Empty, null);
		}
		public async Task<List<Sa_signin_recordEO>> GetByCountryIDAsync(string countryID)
		{
			return await GetByCountryIDAsync(countryID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByCountryID(string countryID, TransactionManager tm_)
		{
			return GetByCountryID(countryID, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_signin_recordEO>> GetByCountryIDAsync(string countryID, TransactionManager tm_)
		{
			return await GetByCountryIDAsync(countryID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByCountryID(string countryID, int top_)
		{
			return GetByCountryID(countryID, top_, string.Empty, null);
		}
		public async Task<List<Sa_signin_recordEO>> GetByCountryIDAsync(string countryID, int top_)
		{
			return await GetByCountryIDAsync(countryID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByCountryID(string countryID, int top_, TransactionManager tm_)
		{
			return GetByCountryID(countryID, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_signin_recordEO>> GetByCountryIDAsync(string countryID, int top_, TransactionManager tm_)
		{
			return await GetByCountryIDAsync(countryID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByCountryID(string countryID, string sort_)
		{
			return GetByCountryID(countryID, 0, sort_, null);
		}
		public async Task<List<Sa_signin_recordEO>> GetByCountryIDAsync(string countryID, string sort_)
		{
			return await GetByCountryIDAsync(countryID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByCountryID(string countryID, string sort_, TransactionManager tm_)
		{
			return GetByCountryID(countryID, 0, sort_, tm_);
		}
		public async Task<List<Sa_signin_recordEO>> GetByCountryIDAsync(string countryID, string sort_, TransactionManager tm_)
		{
			return await GetByCountryIDAsync(countryID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByCountryID(string countryID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(countryID != null ? "`CountryID` = @CountryID" : "`CountryID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (countryID != null)
				paras_.Add(Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_signin_recordEO.MapDataReader);
		}
		public async Task<List<Sa_signin_recordEO>> GetByCountryIDAsync(string countryID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(countryID != null ? "`CountryID` = @CountryID" : "`CountryID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (countryID != null)
				paras_.Add(Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_signin_recordEO.MapDataReader);
		}
		#endregion // GetByCountryID
		#region GetByCurrencyID
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID"></param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByCurrencyID(string currencyID)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, null);
		}
		public async Task<List<Sa_signin_recordEO>> GetByCurrencyIDAsync(string currencyID)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByCurrencyID(string currencyID, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_signin_recordEO>> GetByCurrencyIDAsync(string currencyID, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByCurrencyID(string currencyID, int top_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, null);
		}
		public async Task<List<Sa_signin_recordEO>> GetByCurrencyIDAsync(string currencyID, int top_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByCurrencyID(string currencyID, int top_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_signin_recordEO>> GetByCurrencyIDAsync(string currencyID, int top_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByCurrencyID(string currencyID, string sort_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, null);
		}
		public async Task<List<Sa_signin_recordEO>> GetByCurrencyIDAsync(string currencyID, string sort_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByCurrencyID(string currencyID, string sort_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, tm_);
		}
		public async Task<List<Sa_signin_recordEO>> GetByCurrencyIDAsync(string currencyID, string sort_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByCurrencyID(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(currencyID != null ? "`CurrencyID` = @CurrencyID" : "`CurrencyID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (currencyID != null)
				paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_signin_recordEO.MapDataReader);
		}
		public async Task<List<Sa_signin_recordEO>> GetByCurrencyIDAsync(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(currencyID != null ? "`CurrencyID` = @CurrencyID" : "`CurrencyID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (currencyID != null)
				paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_signin_recordEO.MapDataReader);
		}
		#endregion // GetByCurrencyID
		#region GetByAmount
		
		/// <summary>
		/// 按 Amount（字段） 查询
		/// </summary>
		/// /// <param name = "amount"></param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByAmount(long amount)
		{
			return GetByAmount(amount, 0, string.Empty, null);
		}
		public async Task<List<Sa_signin_recordEO>> GetByAmountAsync(long amount)
		{
			return await GetByAmountAsync(amount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Amount（字段） 查询
		/// </summary>
		/// /// <param name = "amount"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByAmount(long amount, TransactionManager tm_)
		{
			return GetByAmount(amount, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_signin_recordEO>> GetByAmountAsync(long amount, TransactionManager tm_)
		{
			return await GetByAmountAsync(amount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Amount（字段） 查询
		/// </summary>
		/// /// <param name = "amount"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByAmount(long amount, int top_)
		{
			return GetByAmount(amount, top_, string.Empty, null);
		}
		public async Task<List<Sa_signin_recordEO>> GetByAmountAsync(long amount, int top_)
		{
			return await GetByAmountAsync(amount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Amount（字段） 查询
		/// </summary>
		/// /// <param name = "amount"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByAmount(long amount, int top_, TransactionManager tm_)
		{
			return GetByAmount(amount, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_signin_recordEO>> GetByAmountAsync(long amount, int top_, TransactionManager tm_)
		{
			return await GetByAmountAsync(amount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Amount（字段） 查询
		/// </summary>
		/// /// <param name = "amount"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByAmount(long amount, string sort_)
		{
			return GetByAmount(amount, 0, sort_, null);
		}
		public async Task<List<Sa_signin_recordEO>> GetByAmountAsync(long amount, string sort_)
		{
			return await GetByAmountAsync(amount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Amount（字段） 查询
		/// </summary>
		/// /// <param name = "amount"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByAmount(long amount, string sort_, TransactionManager tm_)
		{
			return GetByAmount(amount, 0, sort_, tm_);
		}
		public async Task<List<Sa_signin_recordEO>> GetByAmountAsync(long amount, string sort_, TransactionManager tm_)
		{
			return await GetByAmountAsync(amount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Amount（字段） 查询
		/// </summary>
		/// /// <param name = "amount"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_recordEO> GetByAmount(long amount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Amount` = @Amount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Amount", amount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_signin_recordEO.MapDataReader);
		}
		public async Task<List<Sa_signin_recordEO>> GetByAmountAsync(long amount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Amount` = @Amount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Amount", amount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_signin_recordEO.MapDataReader);
		}
		#endregion // GetByAmount
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
