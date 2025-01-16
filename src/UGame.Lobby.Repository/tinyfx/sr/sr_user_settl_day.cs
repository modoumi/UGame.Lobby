/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * AiUo代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/AiUo
 * 文档生成时间：2023-10-24 18: 04:54
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
	/// 用户每日结算数据
	/// 【表 sr_user_settl_day 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Sr_user_settl_dayEO : IRowMapper<Sr_user_settl_dayEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Sr_user_settl_dayEO()
		{
			this.BetSum = 0;
			this.WinSum = 0;
			this.AmountSum = 0;
			this.RecDate = DateTime.Now;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private DateTime _originalSumDay;
		/// <summary>
		/// 【数据库中的原始主键 SumDay 值的副本，用于主键值更新】
		/// </summary>
		public DateTime OriginalSumDay
		{
			get { return _originalSumDay; }
			set { HasOriginal = true; _originalSumDay = value; }
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
	        return new Dictionary<string, object>() { { "SumDay", SumDay },  { "CurrencyID", CurrencyID },  { "UserID", UserID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 用户编码(GUID)
		/// 【主键 varchar(38)】
		/// </summary>
		[DataMember(Order = 1)]
		public string UserID { get; set; }
		/// <summary>
		/// 货币类型
		/// 【主键 varchar(20)】
		/// </summary>
		[DataMember(Order = 2)]
		public string CurrencyID { get; set; }
		/// <summary>
		/// 统计日
		/// 【主键 date】
		/// </summary>
		[DataMember(Order = 3)]
		public DateTime SumDay { get; set; }
		/// <summary>
		/// 批次ID
		/// 【字段 varchar(38)】
		/// </summary>
		[DataMember(Order = 4)]
		public string BatchID { get; set; }
		/// <summary>
		/// 下注金额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 5)]
		public long BetSum { get; set; }
		/// <summary>
		/// 返奖金额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 6)]
		public long WinSum { get; set; }
		/// <summary>
		/// 收益金额（正负数）=返奖-下注
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 7)]
		public long AmountSum { get; set; }
		/// <summary>
		/// 记录时间
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
		public Sr_user_settl_dayEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Sr_user_settl_dayEO MapDataReader(IDataReader reader)
		{
		    Sr_user_settl_dayEO ret = new Sr_user_settl_dayEO();
			ret.UserID = reader.ToString("UserID");
			ret.OriginalUserID = ret.UserID;
			ret.CurrencyID = reader.ToString("CurrencyID");
			ret.OriginalCurrencyID = ret.CurrencyID;
			ret.SumDay = reader.ToDateTime("SumDay");
			ret.OriginalSumDay = ret.SumDay;
			ret.BatchID = reader.ToString("BatchID");
			ret.BetSum = reader.ToInt64("BetSum");
			ret.WinSum = reader.ToInt64("WinSum");
			ret.AmountSum = reader.ToInt64("AmountSum");
			ret.RecDate = reader.ToDateTime("RecDate");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 用户每日结算数据
	/// 【表 sr_user_settl_day 的操作类】
	/// </summary>
	[Obsolete]
	public class Sr_user_settl_dayMO : MySqlTableMO<Sr_user_settl_dayEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`sr_user_settl_day`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Sr_user_settl_dayMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Sr_user_settl_dayMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Sr_user_settl_dayMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Sr_user_settl_dayEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Sr_user_settl_dayEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Sr_user_settl_dayEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`UserID`, `CurrencyID`, `SumDay`, `BatchID`, `BetSum`, `WinSum`, `AmountSum`, `RecDate`) VALUE (@UserID, @CurrencyID, @SumDay, @BatchID, @BetSum, @WinSum, @AmountSum, @RecDate);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@SumDay", item.SumDay, MySqlDbType.Date),
				Database.CreateInParameter("@BatchID", item.BatchID != null ? item.BatchID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@BetSum", item.BetSum, MySqlDbType.Int64),
				Database.CreateInParameter("@WinSum", item.WinSum, MySqlDbType.Int64),
				Database.CreateInParameter("@AmountSum", item.AmountSum, MySqlDbType.Int64),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
			};
		}
		public int AddByBatch(IEnumerable<Sr_user_settl_dayEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Sr_user_settl_dayEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sr_user_settl_dayEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`UserID`, `CurrencyID`, `SumDay`, `BatchID`, `BetSum`, `WinSum`, `AmountSum`, `RecDate`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.UserID}','{item.CurrencyID}','{item.SumDay.ToString("yyyy-MM-dd HH:mm:ss")}','{item.BatchID}',{item.BetSum},{item.WinSum},{item.AmountSum},'{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
		/// /// <param name = "sumDay">统计日</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(DateTime sumDay, string currencyID, string userID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(sumDay, currencyID, userID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(DateTime sumDay, string currencyID, string userID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(sumDay, currencyID, userID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(DateTime sumDay, string currencyID, string userID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `SumDay` = @SumDay AND `CurrencyID` = @CurrencyID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SumDay", sumDay, MySqlDbType.Date),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Sr_user_settl_dayEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.SumDay, item.CurrencyID, item.UserID, tm_);
		}
		public async Task<int> RemoveAsync(Sr_user_settl_dayEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.SumDay, item.CurrencyID, item.UserID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByUserID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
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
			sql_ = $"DELETE FROM {TableName} WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByUserID
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
		#region RemoveBySumDay
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "sumDay">统计日</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveBySumDay(DateTime sumDay, TransactionManager tm_ = null)
		{
			RepairRemoveBySumDayData(sumDay, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveBySumDayAsync(DateTime sumDay, TransactionManager tm_ = null)
		{
			RepairRemoveBySumDayData(sumDay, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveBySumDayData(DateTime sumDay, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `SumDay` = @SumDay";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SumDay", sumDay, MySqlDbType.Date));
		}
		#endregion // RemoveBySumDay
		#region RemoveByBatchID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "batchID">批次ID</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByBatchID(string batchID, TransactionManager tm_ = null)
		{
			RepairRemoveByBatchIDData(batchID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByBatchIDAsync(string batchID, TransactionManager tm_ = null)
		{
			RepairRemoveByBatchIDData(batchID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByBatchIDData(string batchID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (batchID != null ? "`BatchID` = @BatchID" : "`BatchID` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (batchID != null)
				paras_.Add(Database.CreateInParameter("@BatchID", batchID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByBatchID
		#region RemoveByBetSum
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "betSum">下注金额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByBetSum(long betSum, TransactionManager tm_ = null)
		{
			RepairRemoveByBetSumData(betSum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByBetSumAsync(long betSum, TransactionManager tm_ = null)
		{
			RepairRemoveByBetSumData(betSum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByBetSumData(long betSum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `BetSum` = @BetSum";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetSum", betSum, MySqlDbType.Int64));
		}
		#endregion // RemoveByBetSum
		#region RemoveByWinSum
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "winSum">返奖金额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByWinSum(long winSum, TransactionManager tm_ = null)
		{
			RepairRemoveByWinSumData(winSum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByWinSumAsync(long winSum, TransactionManager tm_ = null)
		{
			RepairRemoveByWinSumData(winSum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByWinSumData(long winSum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `WinSum` = @WinSum";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinSum", winSum, MySqlDbType.Int64));
		}
		#endregion // RemoveByWinSum
		#region RemoveByAmountSum
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "amountSum">收益金额（正负数）=返奖-下注</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByAmountSum(long amountSum, TransactionManager tm_ = null)
		{
			RepairRemoveByAmountSumData(amountSum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByAmountSumAsync(long amountSum, TransactionManager tm_ = null)
		{
			RepairRemoveByAmountSumData(amountSum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByAmountSumData(long amountSum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `AmountSum` = @AmountSum";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@AmountSum", amountSum, MySqlDbType.Int64));
		}
		#endregion // RemoveByAmountSum
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
		public int Put(Sr_user_settl_dayEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Sr_user_settl_dayEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Sr_user_settl_dayEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UserID` = @UserID, `CurrencyID` = @CurrencyID, `SumDay` = @SumDay, `BatchID` = @BatchID, `BetSum` = @BetSum, `WinSum` = @WinSum, `AmountSum` = @AmountSum WHERE `SumDay` = @SumDay_Original AND `CurrencyID` = @CurrencyID_Original AND `UserID` = @UserID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@SumDay", item.SumDay, MySqlDbType.Date),
				Database.CreateInParameter("@BatchID", item.BatchID != null ? item.BatchID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@BetSum", item.BetSum, MySqlDbType.Int64),
				Database.CreateInParameter("@WinSum", item.WinSum, MySqlDbType.Int64),
				Database.CreateInParameter("@AmountSum", item.AmountSum, MySqlDbType.Int64),
				Database.CreateInParameter("@SumDay_Original", item.HasOriginal ? item.OriginalSumDay : item.SumDay, MySqlDbType.Date),
				Database.CreateInParameter("@CurrencyID_Original", item.HasOriginal ? item.OriginalCurrencyID : item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID_Original", item.HasOriginal ? item.OriginalUserID : item.UserID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Sr_user_settl_dayEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Sr_user_settl_dayEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "sumDay">统计日</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(DateTime sumDay, string currencyID, string userID, string set_, params object[] values_)
		{
			return Put(set_, "`SumDay` = @SumDay AND `CurrencyID` = @CurrencyID AND `UserID` = @UserID", ConcatValues(values_, sumDay, currencyID, userID));
		}
		public async Task<int> PutByPKAsync(DateTime sumDay, string currencyID, string userID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`SumDay` = @SumDay AND `CurrencyID` = @CurrencyID AND `UserID` = @UserID", ConcatValues(values_, sumDay, currencyID, userID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "sumDay">统计日</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(DateTime sumDay, string currencyID, string userID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`SumDay` = @SumDay AND `CurrencyID` = @CurrencyID AND `UserID` = @UserID", tm_, ConcatValues(values_, sumDay, currencyID, userID));
		}
		public async Task<int> PutByPKAsync(DateTime sumDay, string currencyID, string userID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`SumDay` = @SumDay AND `CurrencyID` = @CurrencyID AND `UserID` = @UserID", tm_, ConcatValues(values_, sumDay, currencyID, userID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "sumDay">统计日</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(DateTime sumDay, string currencyID, string userID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@SumDay", sumDay, MySqlDbType.Date),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`SumDay` = @SumDay AND `CurrencyID` = @CurrencyID AND `UserID` = @UserID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(DateTime sumDay, string currencyID, string userID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@SumDay", sumDay, MySqlDbType.Date),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`SumDay` = @SumDay AND `CurrencyID` = @CurrencyID AND `UserID` = @UserID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutUserID
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserID(string userID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserID` = @UserID";
			var parameter_ = Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutUserIDAsync(string userID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserID` = @UserID";
			var parameter_ = Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutUserID
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
		#region PutSumDay
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "sumDay">统计日</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSumDay(DateTime sumDay, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SumDay` = @SumDay";
			var parameter_ = Database.CreateInParameter("@SumDay", sumDay, MySqlDbType.Date);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutSumDayAsync(DateTime sumDay, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SumDay` = @SumDay";
			var parameter_ = Database.CreateInParameter("@SumDay", sumDay, MySqlDbType.Date);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutSumDay
		#region PutBatchID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "sumDay">统计日</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "batchID">批次ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBatchIDByPK(DateTime sumDay, string currencyID, string userID, string batchID, TransactionManager tm_ = null)
		{
			RepairPutBatchIDByPKData(sumDay, currencyID, userID, batchID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBatchIDByPKAsync(DateTime sumDay, string currencyID, string userID, string batchID, TransactionManager tm_ = null)
		{
			RepairPutBatchIDByPKData(sumDay, currencyID, userID, batchID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBatchIDByPKData(DateTime sumDay, string currencyID, string userID, string batchID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BatchID` = @BatchID  WHERE `SumDay` = @SumDay AND `CurrencyID` = @CurrencyID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BatchID", batchID != null ? batchID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@SumDay", sumDay, MySqlDbType.Date),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "batchID">批次ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBatchID(string batchID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BatchID` = @BatchID";
			var parameter_ = Database.CreateInParameter("@BatchID", batchID != null ? batchID : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutBatchIDAsync(string batchID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BatchID` = @BatchID";
			var parameter_ = Database.CreateInParameter("@BatchID", batchID != null ? batchID : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutBatchID
		#region PutBetSum
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "sumDay">统计日</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "betSum">下注金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBetSumByPK(DateTime sumDay, string currencyID, string userID, long betSum, TransactionManager tm_ = null)
		{
			RepairPutBetSumByPKData(sumDay, currencyID, userID, betSum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBetSumByPKAsync(DateTime sumDay, string currencyID, string userID, long betSum, TransactionManager tm_ = null)
		{
			RepairPutBetSumByPKData(sumDay, currencyID, userID, betSum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBetSumByPKData(DateTime sumDay, string currencyID, string userID, long betSum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BetSum` = @BetSum  WHERE `SumDay` = @SumDay AND `CurrencyID` = @CurrencyID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetSum", betSum, MySqlDbType.Int64),
				Database.CreateInParameter("@SumDay", sumDay, MySqlDbType.Date),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "betSum">下注金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBetSum(long betSum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BetSum` = @BetSum";
			var parameter_ = Database.CreateInParameter("@BetSum", betSum, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutBetSumAsync(long betSum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BetSum` = @BetSum";
			var parameter_ = Database.CreateInParameter("@BetSum", betSum, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutBetSum
		#region PutWinSum
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "sumDay">统计日</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "winSum">返奖金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWinSumByPK(DateTime sumDay, string currencyID, string userID, long winSum, TransactionManager tm_ = null)
		{
			RepairPutWinSumByPKData(sumDay, currencyID, userID, winSum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutWinSumByPKAsync(DateTime sumDay, string currencyID, string userID, long winSum, TransactionManager tm_ = null)
		{
			RepairPutWinSumByPKData(sumDay, currencyID, userID, winSum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutWinSumByPKData(DateTime sumDay, string currencyID, string userID, long winSum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `WinSum` = @WinSum  WHERE `SumDay` = @SumDay AND `CurrencyID` = @CurrencyID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@WinSum", winSum, MySqlDbType.Int64),
				Database.CreateInParameter("@SumDay", sumDay, MySqlDbType.Date),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "winSum">返奖金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWinSum(long winSum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `WinSum` = @WinSum";
			var parameter_ = Database.CreateInParameter("@WinSum", winSum, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutWinSumAsync(long winSum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `WinSum` = @WinSum";
			var parameter_ = Database.CreateInParameter("@WinSum", winSum, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutWinSum
		#region PutAmountSum
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "sumDay">统计日</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "amountSum">收益金额（正负数）=返奖-下注</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAmountSumByPK(DateTime sumDay, string currencyID, string userID, long amountSum, TransactionManager tm_ = null)
		{
			RepairPutAmountSumByPKData(sumDay, currencyID, userID, amountSum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAmountSumByPKAsync(DateTime sumDay, string currencyID, string userID, long amountSum, TransactionManager tm_ = null)
		{
			RepairPutAmountSumByPKData(sumDay, currencyID, userID, amountSum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutAmountSumByPKData(DateTime sumDay, string currencyID, string userID, long amountSum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `AmountSum` = @AmountSum  WHERE `SumDay` = @SumDay AND `CurrencyID` = @CurrencyID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AmountSum", amountSum, MySqlDbType.Int64),
				Database.CreateInParameter("@SumDay", sumDay, MySqlDbType.Date),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "amountSum">收益金额（正负数）=返奖-下注</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAmountSum(long amountSum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `AmountSum` = @AmountSum";
			var parameter_ = Database.CreateInParameter("@AmountSum", amountSum, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutAmountSumAsync(long amountSum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `AmountSum` = @AmountSum";
			var parameter_ = Database.CreateInParameter("@AmountSum", amountSum, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutAmountSum
		#region PutRecDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "sumDay">统计日</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(DateTime sumDay, string currencyID, string userID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(sumDay, currencyID, userID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(DateTime sumDay, string currencyID, string userID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(sumDay, currencyID, userID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(DateTime sumDay, string currencyID, string userID, DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `SumDay` = @SumDay AND `CurrencyID` = @CurrencyID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@SumDay", sumDay, MySqlDbType.Date),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
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
		public bool Set(Sr_user_settl_dayEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.SumDay, item.CurrencyID, item.UserID) == null)
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
		public async Task<bool> SetAsync(Sr_user_settl_dayEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.SumDay, item.CurrencyID, item.UserID) == null)
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
		/// /// <param name = "sumDay">统计日</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Sr_user_settl_dayEO GetByPK(DateTime sumDay, string currencyID, string userID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(sumDay, currencyID, userID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sr_user_settl_dayEO.MapDataReader);
		}
		public async Task<Sr_user_settl_dayEO> GetByPKAsync(DateTime sumDay, string currencyID, string userID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(sumDay, currencyID, userID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sr_user_settl_dayEO.MapDataReader);
		}
		private void RepairGetByPKData(DateTime sumDay, string currencyID, string userID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`SumDay` = @SumDay AND `CurrencyID` = @CurrencyID AND `UserID` = @UserID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SumDay", sumDay, MySqlDbType.Date),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 UserID（字段）
		/// </summary>
		/// /// <param name = "sumDay">统计日</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetUserIDByPK(DateTime sumDay, string currencyID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SumDay", sumDay, MySqlDbType.Date),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`UserID`", "`SumDay` = @SumDay AND `CurrencyID` = @CurrencyID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<string> GetUserIDByPKAsync(DateTime sumDay, string currencyID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SumDay", sumDay, MySqlDbType.Date),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`UserID`", "`SumDay` = @SumDay AND `CurrencyID` = @CurrencyID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CurrencyID（字段）
		/// </summary>
		/// /// <param name = "sumDay">统计日</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCurrencyIDByPK(DateTime sumDay, string currencyID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SumDay", sumDay, MySqlDbType.Date),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CurrencyID`", "`SumDay` = @SumDay AND `CurrencyID` = @CurrencyID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<string> GetCurrencyIDByPKAsync(DateTime sumDay, string currencyID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SumDay", sumDay, MySqlDbType.Date),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CurrencyID`", "`SumDay` = @SumDay AND `CurrencyID` = @CurrencyID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 SumDay（字段）
		/// </summary>
		/// /// <param name = "sumDay">统计日</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetSumDayByPK(DateTime sumDay, string currencyID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SumDay", sumDay, MySqlDbType.Date),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`SumDay`", "`SumDay` = @SumDay AND `CurrencyID` = @CurrencyID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<DateTime> GetSumDayByPKAsync(DateTime sumDay, string currencyID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SumDay", sumDay, MySqlDbType.Date),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`SumDay`", "`SumDay` = @SumDay AND `CurrencyID` = @CurrencyID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 BatchID（字段）
		/// </summary>
		/// /// <param name = "sumDay">统计日</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetBatchIDByPK(DateTime sumDay, string currencyID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SumDay", sumDay, MySqlDbType.Date),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`BatchID`", "`SumDay` = @SumDay AND `CurrencyID` = @CurrencyID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<string> GetBatchIDByPKAsync(DateTime sumDay, string currencyID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SumDay", sumDay, MySqlDbType.Date),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`BatchID`", "`SumDay` = @SumDay AND `CurrencyID` = @CurrencyID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 BetSum（字段）
		/// </summary>
		/// /// <param name = "sumDay">统计日</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetBetSumByPK(DateTime sumDay, string currencyID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SumDay", sumDay, MySqlDbType.Date),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`BetSum`", "`SumDay` = @SumDay AND `CurrencyID` = @CurrencyID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetBetSumByPKAsync(DateTime sumDay, string currencyID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SumDay", sumDay, MySqlDbType.Date),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`BetSum`", "`SumDay` = @SumDay AND `CurrencyID` = @CurrencyID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 WinSum（字段）
		/// </summary>
		/// /// <param name = "sumDay">统计日</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetWinSumByPK(DateTime sumDay, string currencyID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SumDay", sumDay, MySqlDbType.Date),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`WinSum`", "`SumDay` = @SumDay AND `CurrencyID` = @CurrencyID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetWinSumByPKAsync(DateTime sumDay, string currencyID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SumDay", sumDay, MySqlDbType.Date),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`WinSum`", "`SumDay` = @SumDay AND `CurrencyID` = @CurrencyID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 AmountSum（字段）
		/// </summary>
		/// /// <param name = "sumDay">统计日</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetAmountSumByPK(DateTime sumDay, string currencyID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SumDay", sumDay, MySqlDbType.Date),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`AmountSum`", "`SumDay` = @SumDay AND `CurrencyID` = @CurrencyID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetAmountSumByPKAsync(DateTime sumDay, string currencyID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SumDay", sumDay, MySqlDbType.Date),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`AmountSum`", "`SumDay` = @SumDay AND `CurrencyID` = @CurrencyID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "sumDay">统计日</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetRecDateByPK(DateTime sumDay, string currencyID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SumDay", sumDay, MySqlDbType.Date),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`RecDate`", "`SumDay` = @SumDay AND `CurrencyID` = @CurrencyID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<DateTime> GetRecDateByPKAsync(DateTime sumDay, string currencyID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SumDay", sumDay, MySqlDbType.Date),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`RecDate`", "`SumDay` = @SumDay AND `CurrencyID` = @CurrencyID AND `UserID` = @UserID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByUserID
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_settl_dayEO> GetByUserID(string userID)
		{
			return GetByUserID(userID, 0, string.Empty, null);
		}
		public async Task<List<Sr_user_settl_dayEO>> GetByUserIDAsync(string userID)
		{
			return await GetByUserIDAsync(userID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_settl_dayEO> GetByUserID(string userID, TransactionManager tm_)
		{
			return GetByUserID(userID, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_user_settl_dayEO>> GetByUserIDAsync(string userID, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_settl_dayEO> GetByUserID(string userID, int top_)
		{
			return GetByUserID(userID, top_, string.Empty, null);
		}
		public async Task<List<Sr_user_settl_dayEO>> GetByUserIDAsync(string userID, int top_)
		{
			return await GetByUserIDAsync(userID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_settl_dayEO> GetByUserID(string userID, int top_, TransactionManager tm_)
		{
			return GetByUserID(userID, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_user_settl_dayEO>> GetByUserIDAsync(string userID, int top_, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_settl_dayEO> GetByUserID(string userID, string sort_)
		{
			return GetByUserID(userID, 0, sort_, null);
		}
		public async Task<List<Sr_user_settl_dayEO>> GetByUserIDAsync(string userID, string sort_)
		{
			return await GetByUserIDAsync(userID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_settl_dayEO> GetByUserID(string userID, string sort_, TransactionManager tm_)
		{
			return GetByUserID(userID, 0, sort_, tm_);
		}
		public async Task<List<Sr_user_settl_dayEO>> GetByUserIDAsync(string userID, string sort_, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_settl_dayEO> GetByUserID(string userID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserID` = @UserID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_user_settl_dayEO.MapDataReader);
		}
		public async Task<List<Sr_user_settl_dayEO>> GetByUserIDAsync(string userID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserID` = @UserID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_user_settl_dayEO.MapDataReader);
		}
		#endregion // GetByUserID
		#region GetByCurrencyID
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_settl_dayEO> GetByCurrencyID(string currencyID)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, null);
		}
		public async Task<List<Sr_user_settl_dayEO>> GetByCurrencyIDAsync(string currencyID)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_settl_dayEO> GetByCurrencyID(string currencyID, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_user_settl_dayEO>> GetByCurrencyIDAsync(string currencyID, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_settl_dayEO> GetByCurrencyID(string currencyID, int top_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, null);
		}
		public async Task<List<Sr_user_settl_dayEO>> GetByCurrencyIDAsync(string currencyID, int top_)
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
		public List<Sr_user_settl_dayEO> GetByCurrencyID(string currencyID, int top_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_user_settl_dayEO>> GetByCurrencyIDAsync(string currencyID, int top_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_settl_dayEO> GetByCurrencyID(string currencyID, string sort_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, null);
		}
		public async Task<List<Sr_user_settl_dayEO>> GetByCurrencyIDAsync(string currencyID, string sort_)
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
		public List<Sr_user_settl_dayEO> GetByCurrencyID(string currencyID, string sort_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, tm_);
		}
		public async Task<List<Sr_user_settl_dayEO>> GetByCurrencyIDAsync(string currencyID, string sort_, TransactionManager tm_)
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
		public List<Sr_user_settl_dayEO> GetByCurrencyID(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_user_settl_dayEO.MapDataReader);
		}
		public async Task<List<Sr_user_settl_dayEO>> GetByCurrencyIDAsync(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_user_settl_dayEO.MapDataReader);
		}
		#endregion // GetByCurrencyID
		#region GetBySumDay
		
		/// <summary>
		/// 按 SumDay（字段） 查询
		/// </summary>
		/// /// <param name = "sumDay">统计日</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_settl_dayEO> GetBySumDay(DateTime sumDay)
		{
			return GetBySumDay(sumDay, 0, string.Empty, null);
		}
		public async Task<List<Sr_user_settl_dayEO>> GetBySumDayAsync(DateTime sumDay)
		{
			return await GetBySumDayAsync(sumDay, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SumDay（字段） 查询
		/// </summary>
		/// /// <param name = "sumDay">统计日</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_settl_dayEO> GetBySumDay(DateTime sumDay, TransactionManager tm_)
		{
			return GetBySumDay(sumDay, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_user_settl_dayEO>> GetBySumDayAsync(DateTime sumDay, TransactionManager tm_)
		{
			return await GetBySumDayAsync(sumDay, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SumDay（字段） 查询
		/// </summary>
		/// /// <param name = "sumDay">统计日</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_settl_dayEO> GetBySumDay(DateTime sumDay, int top_)
		{
			return GetBySumDay(sumDay, top_, string.Empty, null);
		}
		public async Task<List<Sr_user_settl_dayEO>> GetBySumDayAsync(DateTime sumDay, int top_)
		{
			return await GetBySumDayAsync(sumDay, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SumDay（字段） 查询
		/// </summary>
		/// /// <param name = "sumDay">统计日</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_settl_dayEO> GetBySumDay(DateTime sumDay, int top_, TransactionManager tm_)
		{
			return GetBySumDay(sumDay, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_user_settl_dayEO>> GetBySumDayAsync(DateTime sumDay, int top_, TransactionManager tm_)
		{
			return await GetBySumDayAsync(sumDay, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SumDay（字段） 查询
		/// </summary>
		/// /// <param name = "sumDay">统计日</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_settl_dayEO> GetBySumDay(DateTime sumDay, string sort_)
		{
			return GetBySumDay(sumDay, 0, sort_, null);
		}
		public async Task<List<Sr_user_settl_dayEO>> GetBySumDayAsync(DateTime sumDay, string sort_)
		{
			return await GetBySumDayAsync(sumDay, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 SumDay（字段） 查询
		/// </summary>
		/// /// <param name = "sumDay">统计日</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_settl_dayEO> GetBySumDay(DateTime sumDay, string sort_, TransactionManager tm_)
		{
			return GetBySumDay(sumDay, 0, sort_, tm_);
		}
		public async Task<List<Sr_user_settl_dayEO>> GetBySumDayAsync(DateTime sumDay, string sort_, TransactionManager tm_)
		{
			return await GetBySumDayAsync(sumDay, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 SumDay（字段） 查询
		/// </summary>
		/// /// <param name = "sumDay">统计日</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_settl_dayEO> GetBySumDay(DateTime sumDay, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SumDay` = @SumDay", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SumDay", sumDay, MySqlDbType.Date));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_user_settl_dayEO.MapDataReader);
		}
		public async Task<List<Sr_user_settl_dayEO>> GetBySumDayAsync(DateTime sumDay, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SumDay` = @SumDay", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SumDay", sumDay, MySqlDbType.Date));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_user_settl_dayEO.MapDataReader);
		}
		#endregion // GetBySumDay
		#region GetByBatchID
		
		/// <summary>
		/// 按 BatchID（字段） 查询
		/// </summary>
		/// /// <param name = "batchID">批次ID</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_settl_dayEO> GetByBatchID(string batchID)
		{
			return GetByBatchID(batchID, 0, string.Empty, null);
		}
		public async Task<List<Sr_user_settl_dayEO>> GetByBatchIDAsync(string batchID)
		{
			return await GetByBatchIDAsync(batchID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BatchID（字段） 查询
		/// </summary>
		/// /// <param name = "batchID">批次ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_settl_dayEO> GetByBatchID(string batchID, TransactionManager tm_)
		{
			return GetByBatchID(batchID, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_user_settl_dayEO>> GetByBatchIDAsync(string batchID, TransactionManager tm_)
		{
			return await GetByBatchIDAsync(batchID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BatchID（字段） 查询
		/// </summary>
		/// /// <param name = "batchID">批次ID</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_settl_dayEO> GetByBatchID(string batchID, int top_)
		{
			return GetByBatchID(batchID, top_, string.Empty, null);
		}
		public async Task<List<Sr_user_settl_dayEO>> GetByBatchIDAsync(string batchID, int top_)
		{
			return await GetByBatchIDAsync(batchID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BatchID（字段） 查询
		/// </summary>
		/// /// <param name = "batchID">批次ID</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_settl_dayEO> GetByBatchID(string batchID, int top_, TransactionManager tm_)
		{
			return GetByBatchID(batchID, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_user_settl_dayEO>> GetByBatchIDAsync(string batchID, int top_, TransactionManager tm_)
		{
			return await GetByBatchIDAsync(batchID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BatchID（字段） 查询
		/// </summary>
		/// /// <param name = "batchID">批次ID</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_settl_dayEO> GetByBatchID(string batchID, string sort_)
		{
			return GetByBatchID(batchID, 0, sort_, null);
		}
		public async Task<List<Sr_user_settl_dayEO>> GetByBatchIDAsync(string batchID, string sort_)
		{
			return await GetByBatchIDAsync(batchID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BatchID（字段） 查询
		/// </summary>
		/// /// <param name = "batchID">批次ID</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_settl_dayEO> GetByBatchID(string batchID, string sort_, TransactionManager tm_)
		{
			return GetByBatchID(batchID, 0, sort_, tm_);
		}
		public async Task<List<Sr_user_settl_dayEO>> GetByBatchIDAsync(string batchID, string sort_, TransactionManager tm_)
		{
			return await GetByBatchIDAsync(batchID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BatchID（字段） 查询
		/// </summary>
		/// /// <param name = "batchID">批次ID</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_settl_dayEO> GetByBatchID(string batchID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(batchID != null ? "`BatchID` = @BatchID" : "`BatchID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (batchID != null)
				paras_.Add(Database.CreateInParameter("@BatchID", batchID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_user_settl_dayEO.MapDataReader);
		}
		public async Task<List<Sr_user_settl_dayEO>> GetByBatchIDAsync(string batchID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(batchID != null ? "`BatchID` = @BatchID" : "`BatchID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (batchID != null)
				paras_.Add(Database.CreateInParameter("@BatchID", batchID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_user_settl_dayEO.MapDataReader);
		}
		#endregion // GetByBatchID
		#region GetByBetSum
		
		/// <summary>
		/// 按 BetSum（字段） 查询
		/// </summary>
		/// /// <param name = "betSum">下注金额</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_settl_dayEO> GetByBetSum(long betSum)
		{
			return GetByBetSum(betSum, 0, string.Empty, null);
		}
		public async Task<List<Sr_user_settl_dayEO>> GetByBetSumAsync(long betSum)
		{
			return await GetByBetSumAsync(betSum, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetSum（字段） 查询
		/// </summary>
		/// /// <param name = "betSum">下注金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_settl_dayEO> GetByBetSum(long betSum, TransactionManager tm_)
		{
			return GetByBetSum(betSum, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_user_settl_dayEO>> GetByBetSumAsync(long betSum, TransactionManager tm_)
		{
			return await GetByBetSumAsync(betSum, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetSum（字段） 查询
		/// </summary>
		/// /// <param name = "betSum">下注金额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_settl_dayEO> GetByBetSum(long betSum, int top_)
		{
			return GetByBetSum(betSum, top_, string.Empty, null);
		}
		public async Task<List<Sr_user_settl_dayEO>> GetByBetSumAsync(long betSum, int top_)
		{
			return await GetByBetSumAsync(betSum, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetSum（字段） 查询
		/// </summary>
		/// /// <param name = "betSum">下注金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_settl_dayEO> GetByBetSum(long betSum, int top_, TransactionManager tm_)
		{
			return GetByBetSum(betSum, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_user_settl_dayEO>> GetByBetSumAsync(long betSum, int top_, TransactionManager tm_)
		{
			return await GetByBetSumAsync(betSum, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetSum（字段） 查询
		/// </summary>
		/// /// <param name = "betSum">下注金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_settl_dayEO> GetByBetSum(long betSum, string sort_)
		{
			return GetByBetSum(betSum, 0, sort_, null);
		}
		public async Task<List<Sr_user_settl_dayEO>> GetByBetSumAsync(long betSum, string sort_)
		{
			return await GetByBetSumAsync(betSum, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BetSum（字段） 查询
		/// </summary>
		/// /// <param name = "betSum">下注金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_settl_dayEO> GetByBetSum(long betSum, string sort_, TransactionManager tm_)
		{
			return GetByBetSum(betSum, 0, sort_, tm_);
		}
		public async Task<List<Sr_user_settl_dayEO>> GetByBetSumAsync(long betSum, string sort_, TransactionManager tm_)
		{
			return await GetByBetSumAsync(betSum, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BetSum（字段） 查询
		/// </summary>
		/// /// <param name = "betSum">下注金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_settl_dayEO> GetByBetSum(long betSum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetSum` = @BetSum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetSum", betSum, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_user_settl_dayEO.MapDataReader);
		}
		public async Task<List<Sr_user_settl_dayEO>> GetByBetSumAsync(long betSum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetSum` = @BetSum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetSum", betSum, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_user_settl_dayEO.MapDataReader);
		}
		#endregion // GetByBetSum
		#region GetByWinSum
		
		/// <summary>
		/// 按 WinSum（字段） 查询
		/// </summary>
		/// /// <param name = "winSum">返奖金额</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_settl_dayEO> GetByWinSum(long winSum)
		{
			return GetByWinSum(winSum, 0, string.Empty, null);
		}
		public async Task<List<Sr_user_settl_dayEO>> GetByWinSumAsync(long winSum)
		{
			return await GetByWinSumAsync(winSum, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WinSum（字段） 查询
		/// </summary>
		/// /// <param name = "winSum">返奖金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_settl_dayEO> GetByWinSum(long winSum, TransactionManager tm_)
		{
			return GetByWinSum(winSum, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_user_settl_dayEO>> GetByWinSumAsync(long winSum, TransactionManager tm_)
		{
			return await GetByWinSumAsync(winSum, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WinSum（字段） 查询
		/// </summary>
		/// /// <param name = "winSum">返奖金额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_settl_dayEO> GetByWinSum(long winSum, int top_)
		{
			return GetByWinSum(winSum, top_, string.Empty, null);
		}
		public async Task<List<Sr_user_settl_dayEO>> GetByWinSumAsync(long winSum, int top_)
		{
			return await GetByWinSumAsync(winSum, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WinSum（字段） 查询
		/// </summary>
		/// /// <param name = "winSum">返奖金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_settl_dayEO> GetByWinSum(long winSum, int top_, TransactionManager tm_)
		{
			return GetByWinSum(winSum, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_user_settl_dayEO>> GetByWinSumAsync(long winSum, int top_, TransactionManager tm_)
		{
			return await GetByWinSumAsync(winSum, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WinSum（字段） 查询
		/// </summary>
		/// /// <param name = "winSum">返奖金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_settl_dayEO> GetByWinSum(long winSum, string sort_)
		{
			return GetByWinSum(winSum, 0, sort_, null);
		}
		public async Task<List<Sr_user_settl_dayEO>> GetByWinSumAsync(long winSum, string sort_)
		{
			return await GetByWinSumAsync(winSum, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 WinSum（字段） 查询
		/// </summary>
		/// /// <param name = "winSum">返奖金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_settl_dayEO> GetByWinSum(long winSum, string sort_, TransactionManager tm_)
		{
			return GetByWinSum(winSum, 0, sort_, tm_);
		}
		public async Task<List<Sr_user_settl_dayEO>> GetByWinSumAsync(long winSum, string sort_, TransactionManager tm_)
		{
			return await GetByWinSumAsync(winSum, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 WinSum（字段） 查询
		/// </summary>
		/// /// <param name = "winSum">返奖金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_settl_dayEO> GetByWinSum(long winSum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WinSum` = @WinSum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinSum", winSum, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_user_settl_dayEO.MapDataReader);
		}
		public async Task<List<Sr_user_settl_dayEO>> GetByWinSumAsync(long winSum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WinSum` = @WinSum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinSum", winSum, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_user_settl_dayEO.MapDataReader);
		}
		#endregion // GetByWinSum
		#region GetByAmountSum
		
		/// <summary>
		/// 按 AmountSum（字段） 查询
		/// </summary>
		/// /// <param name = "amountSum">收益金额（正负数）=返奖-下注</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_settl_dayEO> GetByAmountSum(long amountSum)
		{
			return GetByAmountSum(amountSum, 0, string.Empty, null);
		}
		public async Task<List<Sr_user_settl_dayEO>> GetByAmountSumAsync(long amountSum)
		{
			return await GetByAmountSumAsync(amountSum, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AmountSum（字段） 查询
		/// </summary>
		/// /// <param name = "amountSum">收益金额（正负数）=返奖-下注</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_settl_dayEO> GetByAmountSum(long amountSum, TransactionManager tm_)
		{
			return GetByAmountSum(amountSum, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_user_settl_dayEO>> GetByAmountSumAsync(long amountSum, TransactionManager tm_)
		{
			return await GetByAmountSumAsync(amountSum, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AmountSum（字段） 查询
		/// </summary>
		/// /// <param name = "amountSum">收益金额（正负数）=返奖-下注</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_settl_dayEO> GetByAmountSum(long amountSum, int top_)
		{
			return GetByAmountSum(amountSum, top_, string.Empty, null);
		}
		public async Task<List<Sr_user_settl_dayEO>> GetByAmountSumAsync(long amountSum, int top_)
		{
			return await GetByAmountSumAsync(amountSum, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AmountSum（字段） 查询
		/// </summary>
		/// /// <param name = "amountSum">收益金额（正负数）=返奖-下注</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_settl_dayEO> GetByAmountSum(long amountSum, int top_, TransactionManager tm_)
		{
			return GetByAmountSum(amountSum, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_user_settl_dayEO>> GetByAmountSumAsync(long amountSum, int top_, TransactionManager tm_)
		{
			return await GetByAmountSumAsync(amountSum, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AmountSum（字段） 查询
		/// </summary>
		/// /// <param name = "amountSum">收益金额（正负数）=返奖-下注</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_settl_dayEO> GetByAmountSum(long amountSum, string sort_)
		{
			return GetByAmountSum(amountSum, 0, sort_, null);
		}
		public async Task<List<Sr_user_settl_dayEO>> GetByAmountSumAsync(long amountSum, string sort_)
		{
			return await GetByAmountSumAsync(amountSum, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 AmountSum（字段） 查询
		/// </summary>
		/// /// <param name = "amountSum">收益金额（正负数）=返奖-下注</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_settl_dayEO> GetByAmountSum(long amountSum, string sort_, TransactionManager tm_)
		{
			return GetByAmountSum(amountSum, 0, sort_, tm_);
		}
		public async Task<List<Sr_user_settl_dayEO>> GetByAmountSumAsync(long amountSum, string sort_, TransactionManager tm_)
		{
			return await GetByAmountSumAsync(amountSum, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 AmountSum（字段） 查询
		/// </summary>
		/// /// <param name = "amountSum">收益金额（正负数）=返奖-下注</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_settl_dayEO> GetByAmountSum(long amountSum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`AmountSum` = @AmountSum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@AmountSum", amountSum, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_user_settl_dayEO.MapDataReader);
		}
		public async Task<List<Sr_user_settl_dayEO>> GetByAmountSumAsync(long amountSum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`AmountSum` = @AmountSum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@AmountSum", amountSum, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_user_settl_dayEO.MapDataReader);
		}
		#endregion // GetByAmountSum
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_settl_dayEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<Sr_user_settl_dayEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_settl_dayEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_user_settl_dayEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_settl_dayEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<Sr_user_settl_dayEO>> GetByRecDateAsync(DateTime recDate, int top_)
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
		public List<Sr_user_settl_dayEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_user_settl_dayEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_user_settl_dayEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<Sr_user_settl_dayEO>> GetByRecDateAsync(DateTime recDate, string sort_)
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
		public List<Sr_user_settl_dayEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<Sr_user_settl_dayEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
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
		public List<Sr_user_settl_dayEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_user_settl_dayEO.MapDataReader);
		}
		public async Task<List<Sr_user_settl_dayEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_user_settl_dayEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
