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
	/// 1.7版抽奖轮盘抽奖用户日充值、赠送次数表
	/// 【表 sa_roulette101001_user_day 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Sa_roulette101001_user_dayEO : IRowMapper<Sa_roulette101001_user_dayEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Sa_roulette101001_user_dayEO()
		{
			this.TotalPayAmount = 0;
			this.SumSendNum = 0;
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
		
		private DateTime _originalDayId;
		/// <summary>
		/// 【数据库中的原始主键 DayId 值的副本，用于主键值更新】
		/// </summary>
		public DateTime OriginalDayId
		{
			get { return _originalDayId; }
			set { HasOriginal = true; _originalDayId = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "UserID", UserID },  { "DayId", DayId }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 用户编码guid
		/// 【主键 varchar(36)】
		/// </summary>
		[DataMember(Order = 1)]
		public string UserID { get; set; }
		/// <summary>
		/// 奖励日期
		/// 【主键 date】
		/// </summary>
		[DataMember(Order = 2)]
		public DateTime DayId { get; set; }
		/// <summary>
		/// 当日充值总金额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 3)]
		public long TotalPayAmount { get; set; }
		/// <summary>
		/// 轮盘赠送次数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 4)]
		public int SumSendNum { get; set; }
		/// <summary>
		/// 记录时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 5)]
		public DateTime RecDate { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Sa_roulette101001_user_dayEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Sa_roulette101001_user_dayEO MapDataReader(IDataReader reader)
		{
		    Sa_roulette101001_user_dayEO ret = new Sa_roulette101001_user_dayEO();
			ret.UserID = reader.ToString("UserID");
			ret.OriginalUserID = ret.UserID;
			ret.DayId = reader.ToDateTime("DayId");
			ret.OriginalDayId = ret.DayId;
			ret.TotalPayAmount = reader.ToInt64("TotalPayAmount");
			ret.SumSendNum = reader.ToInt32("SumSendNum");
			ret.RecDate = reader.ToDateTime("RecDate");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 1.7版抽奖轮盘抽奖用户日充值、赠送次数表
	/// 【表 sa_roulette101001_user_day 的操作类】
	/// </summary>
	[Obsolete]
	public class Sa_roulette101001_user_dayMO : MySqlTableMO<Sa_roulette101001_user_dayEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`sa_roulette101001_user_day`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Sa_roulette101001_user_dayMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Sa_roulette101001_user_dayMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Sa_roulette101001_user_dayMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Sa_roulette101001_user_dayEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Sa_roulette101001_user_dayEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Sa_roulette101001_user_dayEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`UserID`, `DayId`, `TotalPayAmount`, `SumSendNum`, `RecDate`) VALUE (@UserID, @DayId, @TotalPayAmount, @SumSendNum, @RecDate);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@DayId", item.DayId, MySqlDbType.Date),
				Database.CreateInParameter("@TotalPayAmount", item.TotalPayAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@SumSendNum", item.SumSendNum, MySqlDbType.Int32),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
			};
		}
		public int AddByBatch(IEnumerable<Sa_roulette101001_user_dayEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Sa_roulette101001_user_dayEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sa_roulette101001_user_dayEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`UserID`, `DayId`, `TotalPayAmount`, `SumSendNum`, `RecDate`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.UserID}','{item.DayId.ToString("yyyy-MM-dd HH:mm:ss")}',{item.TotalPayAmount},{item.SumSendNum},'{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
		/// /// <param name = "userID">用户编码guid</param>
		/// /// <param name = "dayId">奖励日期</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string userID, DateTime dayId, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(userID, dayId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string userID, DateTime dayId, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(userID, dayId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string userID, DateTime dayId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `UserID` = @UserID AND `DayId` = @DayId";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Sa_roulette101001_user_dayEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.UserID, item.DayId, tm_);
		}
		public async Task<int> RemoveAsync(Sa_roulette101001_user_dayEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.UserID, item.DayId, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByUserID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "userID">用户编码guid</param>
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
		#region RemoveByDayId
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "dayId">奖励日期</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByDayId(DateTime dayId, TransactionManager tm_ = null)
		{
			RepairRemoveByDayIdData(dayId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByDayIdAsync(DateTime dayId, TransactionManager tm_ = null)
		{
			RepairRemoveByDayIdData(dayId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByDayIdData(DateTime dayId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `DayId` = @DayId";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date));
		}
		#endregion // RemoveByDayId
		#region RemoveByTotalPayAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "totalPayAmount">当日充值总金额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTotalPayAmount(long totalPayAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByTotalPayAmountData(totalPayAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTotalPayAmountAsync(long totalPayAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByTotalPayAmountData(totalPayAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTotalPayAmountData(long totalPayAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `TotalPayAmount` = @TotalPayAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalPayAmount", totalPayAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByTotalPayAmount
		#region RemoveBySumSendNum
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "sumSendNum">轮盘赠送次数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveBySumSendNum(int sumSendNum, TransactionManager tm_ = null)
		{
			RepairRemoveBySumSendNumData(sumSendNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveBySumSendNumAsync(int sumSendNum, TransactionManager tm_ = null)
		{
			RepairRemoveBySumSendNumData(sumSendNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveBySumSendNumData(int sumSendNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `SumSendNum` = @SumSendNum";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SumSendNum", sumSendNum, MySqlDbType.Int32));
		}
		#endregion // RemoveBySumSendNum
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
		public int Put(Sa_roulette101001_user_dayEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Sa_roulette101001_user_dayEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Sa_roulette101001_user_dayEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UserID` = @UserID, `DayId` = @DayId, `TotalPayAmount` = @TotalPayAmount, `SumSendNum` = @SumSendNum WHERE `UserID` = @UserID_Original AND `DayId` = @DayId_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@DayId", item.DayId, MySqlDbType.Date),
				Database.CreateInParameter("@TotalPayAmount", item.TotalPayAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@SumSendNum", item.SumSendNum, MySqlDbType.Int32),
				Database.CreateInParameter("@UserID_Original", item.HasOriginal ? item.OriginalUserID : item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@DayId_Original", item.HasOriginal ? item.OriginalDayId : item.DayId, MySqlDbType.Date),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Sa_roulette101001_user_dayEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Sa_roulette101001_user_dayEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "userID">用户编码guid</param>
		/// /// <param name = "dayId">奖励日期</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string userID, DateTime dayId, string set_, params object[] values_)
		{
			return Put(set_, "`UserID` = @UserID AND `DayId` = @DayId", ConcatValues(values_, userID, dayId));
		}
		public async Task<int> PutByPKAsync(string userID, DateTime dayId, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`UserID` = @UserID AND `DayId` = @DayId", ConcatValues(values_, userID, dayId));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "userID">用户编码guid</param>
		/// /// <param name = "dayId">奖励日期</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string userID, DateTime dayId, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`UserID` = @UserID AND `DayId` = @DayId", tm_, ConcatValues(values_, userID, dayId));
		}
		public async Task<int> PutByPKAsync(string userID, DateTime dayId, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`UserID` = @UserID AND `DayId` = @DayId", tm_, ConcatValues(values_, userID, dayId));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "userID">用户编码guid</param>
		/// /// <param name = "dayId">奖励日期</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string userID, DateTime dayId, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
	        };
			return Put(set_, "`UserID` = @UserID AND `DayId` = @DayId", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string userID, DateTime dayId, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
	        };
			return await PutAsync(set_, "`UserID` = @UserID AND `DayId` = @DayId", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutUserID
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "userID">用户编码guid</param>
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
		#region PutDayId
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "dayId">奖励日期</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutDayId(DateTime dayId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `DayId` = @DayId";
			var parameter_ = Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutDayIdAsync(DateTime dayId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `DayId` = @DayId";
			var parameter_ = Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutDayId
		#region PutTotalPayAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码guid</param>
		/// /// <param name = "dayId">奖励日期</param>
		/// /// <param name = "totalPayAmount">当日充值总金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTotalPayAmountByPK(string userID, DateTime dayId, long totalPayAmount, TransactionManager tm_ = null)
		{
			RepairPutTotalPayAmountByPKData(userID, dayId, totalPayAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTotalPayAmountByPKAsync(string userID, DateTime dayId, long totalPayAmount, TransactionManager tm_ = null)
		{
			RepairPutTotalPayAmountByPKData(userID, dayId, totalPayAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTotalPayAmountByPKData(string userID, DateTime dayId, long totalPayAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `TotalPayAmount` = @TotalPayAmount  WHERE `UserID` = @UserID AND `DayId` = @DayId";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TotalPayAmount", totalPayAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "totalPayAmount">当日充值总金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTotalPayAmount(long totalPayAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TotalPayAmount` = @TotalPayAmount";
			var parameter_ = Database.CreateInParameter("@TotalPayAmount", totalPayAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTotalPayAmountAsync(long totalPayAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TotalPayAmount` = @TotalPayAmount";
			var parameter_ = Database.CreateInParameter("@TotalPayAmount", totalPayAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTotalPayAmount
		#region PutSumSendNum
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码guid</param>
		/// /// <param name = "dayId">奖励日期</param>
		/// /// <param name = "sumSendNum">轮盘赠送次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSumSendNumByPK(string userID, DateTime dayId, int sumSendNum, TransactionManager tm_ = null)
		{
			RepairPutSumSendNumByPKData(userID, dayId, sumSendNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutSumSendNumByPKAsync(string userID, DateTime dayId, int sumSendNum, TransactionManager tm_ = null)
		{
			RepairPutSumSendNumByPKData(userID, dayId, sumSendNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutSumSendNumByPKData(string userID, DateTime dayId, int sumSendNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `SumSendNum` = @SumSendNum  WHERE `UserID` = @UserID AND `DayId` = @DayId";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SumSendNum", sumSendNum, MySqlDbType.Int32),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "sumSendNum">轮盘赠送次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSumSendNum(int sumSendNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SumSendNum` = @SumSendNum";
			var parameter_ = Database.CreateInParameter("@SumSendNum", sumSendNum, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutSumSendNumAsync(int sumSendNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SumSendNum` = @SumSendNum";
			var parameter_ = Database.CreateInParameter("@SumSendNum", sumSendNum, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutSumSendNum
		#region PutRecDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码guid</param>
		/// /// <param name = "dayId">奖励日期</param>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(string userID, DateTime dayId, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(userID, dayId, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(string userID, DateTime dayId, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(userID, dayId, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(string userID, DateTime dayId, DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `UserID` = @UserID AND `DayId` = @DayId";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
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
		public bool Set(Sa_roulette101001_user_dayEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.UserID, item.DayId) == null)
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
		public async Task<bool> SetAsync(Sa_roulette101001_user_dayEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.UserID, item.DayId) == null)
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
		/// /// <param name = "userID">用户编码guid</param>
		/// /// <param name = "dayId">奖励日期</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Sa_roulette101001_user_dayEO GetByPK(string userID, DateTime dayId, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(userID, dayId, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sa_roulette101001_user_dayEO.MapDataReader);
		}
		public async Task<Sa_roulette101001_user_dayEO> GetByPKAsync(string userID, DateTime dayId, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(userID, dayId, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sa_roulette101001_user_dayEO.MapDataReader);
		}
		private void RepairGetByPKData(string userID, DateTime dayId, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`UserID` = @UserID AND `DayId` = @DayId", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 UserID（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码guid</param>
		/// /// <param name = "dayId">奖励日期</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetUserIDByPK(string userID, DateTime dayId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
			};
			return (string)GetScalar("`UserID`", "`UserID` = @UserID AND `DayId` = @DayId", paras_, tm_);
		}
		public async Task<string> GetUserIDByPKAsync(string userID, DateTime dayId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
			};
			return (string)await GetScalarAsync("`UserID`", "`UserID` = @UserID AND `DayId` = @DayId", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 DayId（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码guid</param>
		/// /// <param name = "dayId">奖励日期</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetDayIdByPK(string userID, DateTime dayId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
			};
			return (DateTime)GetScalar("`DayId`", "`UserID` = @UserID AND `DayId` = @DayId", paras_, tm_);
		}
		public async Task<DateTime> GetDayIdByPKAsync(string userID, DateTime dayId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
			};
			return (DateTime)await GetScalarAsync("`DayId`", "`UserID` = @UserID AND `DayId` = @DayId", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 TotalPayAmount（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码guid</param>
		/// /// <param name = "dayId">奖励日期</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetTotalPayAmountByPK(string userID, DateTime dayId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
			};
			return (long)GetScalar("`TotalPayAmount`", "`UserID` = @UserID AND `DayId` = @DayId", paras_, tm_);
		}
		public async Task<long> GetTotalPayAmountByPKAsync(string userID, DateTime dayId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
			};
			return (long)await GetScalarAsync("`TotalPayAmount`", "`UserID` = @UserID AND `DayId` = @DayId", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 SumSendNum（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码guid</param>
		/// /// <param name = "dayId">奖励日期</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetSumSendNumByPK(string userID, DateTime dayId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
			};
			return (int)GetScalar("`SumSendNum`", "`UserID` = @UserID AND `DayId` = @DayId", paras_, tm_);
		}
		public async Task<int> GetSumSendNumByPKAsync(string userID, DateTime dayId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
			};
			return (int)await GetScalarAsync("`SumSendNum`", "`UserID` = @UserID AND `DayId` = @DayId", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码guid</param>
		/// /// <param name = "dayId">奖励日期</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetRecDateByPK(string userID, DateTime dayId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
			};
			return (DateTime)GetScalar("`RecDate`", "`UserID` = @UserID AND `DayId` = @DayId", paras_, tm_);
		}
		public async Task<DateTime> GetRecDateByPKAsync(string userID, DateTime dayId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
			};
			return (DateTime)await GetScalarAsync("`RecDate`", "`UserID` = @UserID AND `DayId` = @DayId", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByUserID
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码guid</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_user_dayEO> GetByUserID(string userID)
		{
			return GetByUserID(userID, 0, string.Empty, null);
		}
		public async Task<List<Sa_roulette101001_user_dayEO>> GetByUserIDAsync(string userID)
		{
			return await GetByUserIDAsync(userID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码guid</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_user_dayEO> GetByUserID(string userID, TransactionManager tm_)
		{
			return GetByUserID(userID, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette101001_user_dayEO>> GetByUserIDAsync(string userID, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码guid</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_user_dayEO> GetByUserID(string userID, int top_)
		{
			return GetByUserID(userID, top_, string.Empty, null);
		}
		public async Task<List<Sa_roulette101001_user_dayEO>> GetByUserIDAsync(string userID, int top_)
		{
			return await GetByUserIDAsync(userID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码guid</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_user_dayEO> GetByUserID(string userID, int top_, TransactionManager tm_)
		{
			return GetByUserID(userID, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette101001_user_dayEO>> GetByUserIDAsync(string userID, int top_, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码guid</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_user_dayEO> GetByUserID(string userID, string sort_)
		{
			return GetByUserID(userID, 0, sort_, null);
		}
		public async Task<List<Sa_roulette101001_user_dayEO>> GetByUserIDAsync(string userID, string sort_)
		{
			return await GetByUserIDAsync(userID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码guid</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_user_dayEO> GetByUserID(string userID, string sort_, TransactionManager tm_)
		{
			return GetByUserID(userID, 0, sort_, tm_);
		}
		public async Task<List<Sa_roulette101001_user_dayEO>> GetByUserIDAsync(string userID, string sort_, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码guid</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_user_dayEO> GetByUserID(string userID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserID` = @UserID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_roulette101001_user_dayEO.MapDataReader);
		}
		public async Task<List<Sa_roulette101001_user_dayEO>> GetByUserIDAsync(string userID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserID` = @UserID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_roulette101001_user_dayEO.MapDataReader);
		}
		#endregion // GetByUserID
		#region GetByDayId
		
		/// <summary>
		/// 按 DayId（字段） 查询
		/// </summary>
		/// /// <param name = "dayId">奖励日期</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_user_dayEO> GetByDayId(DateTime dayId)
		{
			return GetByDayId(dayId, 0, string.Empty, null);
		}
		public async Task<List<Sa_roulette101001_user_dayEO>> GetByDayIdAsync(DateTime dayId)
		{
			return await GetByDayIdAsync(dayId, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DayId（字段） 查询
		/// </summary>
		/// /// <param name = "dayId">奖励日期</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_user_dayEO> GetByDayId(DateTime dayId, TransactionManager tm_)
		{
			return GetByDayId(dayId, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette101001_user_dayEO>> GetByDayIdAsync(DateTime dayId, TransactionManager tm_)
		{
			return await GetByDayIdAsync(dayId, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DayId（字段） 查询
		/// </summary>
		/// /// <param name = "dayId">奖励日期</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_user_dayEO> GetByDayId(DateTime dayId, int top_)
		{
			return GetByDayId(dayId, top_, string.Empty, null);
		}
		public async Task<List<Sa_roulette101001_user_dayEO>> GetByDayIdAsync(DateTime dayId, int top_)
		{
			return await GetByDayIdAsync(dayId, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DayId（字段） 查询
		/// </summary>
		/// /// <param name = "dayId">奖励日期</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_user_dayEO> GetByDayId(DateTime dayId, int top_, TransactionManager tm_)
		{
			return GetByDayId(dayId, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette101001_user_dayEO>> GetByDayIdAsync(DateTime dayId, int top_, TransactionManager tm_)
		{
			return await GetByDayIdAsync(dayId, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DayId（字段） 查询
		/// </summary>
		/// /// <param name = "dayId">奖励日期</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_user_dayEO> GetByDayId(DateTime dayId, string sort_)
		{
			return GetByDayId(dayId, 0, sort_, null);
		}
		public async Task<List<Sa_roulette101001_user_dayEO>> GetByDayIdAsync(DateTime dayId, string sort_)
		{
			return await GetByDayIdAsync(dayId, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DayId（字段） 查询
		/// </summary>
		/// /// <param name = "dayId">奖励日期</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_user_dayEO> GetByDayId(DateTime dayId, string sort_, TransactionManager tm_)
		{
			return GetByDayId(dayId, 0, sort_, tm_);
		}
		public async Task<List<Sa_roulette101001_user_dayEO>> GetByDayIdAsync(DateTime dayId, string sort_, TransactionManager tm_)
		{
			return await GetByDayIdAsync(dayId, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DayId（字段） 查询
		/// </summary>
		/// /// <param name = "dayId">奖励日期</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_user_dayEO> GetByDayId(DateTime dayId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DayId` = @DayId", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_roulette101001_user_dayEO.MapDataReader);
		}
		public async Task<List<Sa_roulette101001_user_dayEO>> GetByDayIdAsync(DateTime dayId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DayId` = @DayId", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_roulette101001_user_dayEO.MapDataReader);
		}
		#endregion // GetByDayId
		#region GetByTotalPayAmount
		
		/// <summary>
		/// 按 TotalPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalPayAmount">当日充值总金额</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_user_dayEO> GetByTotalPayAmount(long totalPayAmount)
		{
			return GetByTotalPayAmount(totalPayAmount, 0, string.Empty, null);
		}
		public async Task<List<Sa_roulette101001_user_dayEO>> GetByTotalPayAmountAsync(long totalPayAmount)
		{
			return await GetByTotalPayAmountAsync(totalPayAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalPayAmount">当日充值总金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_user_dayEO> GetByTotalPayAmount(long totalPayAmount, TransactionManager tm_)
		{
			return GetByTotalPayAmount(totalPayAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette101001_user_dayEO>> GetByTotalPayAmountAsync(long totalPayAmount, TransactionManager tm_)
		{
			return await GetByTotalPayAmountAsync(totalPayAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalPayAmount">当日充值总金额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_user_dayEO> GetByTotalPayAmount(long totalPayAmount, int top_)
		{
			return GetByTotalPayAmount(totalPayAmount, top_, string.Empty, null);
		}
		public async Task<List<Sa_roulette101001_user_dayEO>> GetByTotalPayAmountAsync(long totalPayAmount, int top_)
		{
			return await GetByTotalPayAmountAsync(totalPayAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalPayAmount">当日充值总金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_user_dayEO> GetByTotalPayAmount(long totalPayAmount, int top_, TransactionManager tm_)
		{
			return GetByTotalPayAmount(totalPayAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette101001_user_dayEO>> GetByTotalPayAmountAsync(long totalPayAmount, int top_, TransactionManager tm_)
		{
			return await GetByTotalPayAmountAsync(totalPayAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalPayAmount">当日充值总金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_user_dayEO> GetByTotalPayAmount(long totalPayAmount, string sort_)
		{
			return GetByTotalPayAmount(totalPayAmount, 0, sort_, null);
		}
		public async Task<List<Sa_roulette101001_user_dayEO>> GetByTotalPayAmountAsync(long totalPayAmount, string sort_)
		{
			return await GetByTotalPayAmountAsync(totalPayAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 TotalPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalPayAmount">当日充值总金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_user_dayEO> GetByTotalPayAmount(long totalPayAmount, string sort_, TransactionManager tm_)
		{
			return GetByTotalPayAmount(totalPayAmount, 0, sort_, tm_);
		}
		public async Task<List<Sa_roulette101001_user_dayEO>> GetByTotalPayAmountAsync(long totalPayAmount, string sort_, TransactionManager tm_)
		{
			return await GetByTotalPayAmountAsync(totalPayAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 TotalPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalPayAmount">当日充值总金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_user_dayEO> GetByTotalPayAmount(long totalPayAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalPayAmount` = @TotalPayAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalPayAmount", totalPayAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_roulette101001_user_dayEO.MapDataReader);
		}
		public async Task<List<Sa_roulette101001_user_dayEO>> GetByTotalPayAmountAsync(long totalPayAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalPayAmount` = @TotalPayAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalPayAmount", totalPayAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_roulette101001_user_dayEO.MapDataReader);
		}
		#endregion // GetByTotalPayAmount
		#region GetBySumSendNum
		
		/// <summary>
		/// 按 SumSendNum（字段） 查询
		/// </summary>
		/// /// <param name = "sumSendNum">轮盘赠送次数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_user_dayEO> GetBySumSendNum(int sumSendNum)
		{
			return GetBySumSendNum(sumSendNum, 0, string.Empty, null);
		}
		public async Task<List<Sa_roulette101001_user_dayEO>> GetBySumSendNumAsync(int sumSendNum)
		{
			return await GetBySumSendNumAsync(sumSendNum, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SumSendNum（字段） 查询
		/// </summary>
		/// /// <param name = "sumSendNum">轮盘赠送次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_user_dayEO> GetBySumSendNum(int sumSendNum, TransactionManager tm_)
		{
			return GetBySumSendNum(sumSendNum, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette101001_user_dayEO>> GetBySumSendNumAsync(int sumSendNum, TransactionManager tm_)
		{
			return await GetBySumSendNumAsync(sumSendNum, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SumSendNum（字段） 查询
		/// </summary>
		/// /// <param name = "sumSendNum">轮盘赠送次数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_user_dayEO> GetBySumSendNum(int sumSendNum, int top_)
		{
			return GetBySumSendNum(sumSendNum, top_, string.Empty, null);
		}
		public async Task<List<Sa_roulette101001_user_dayEO>> GetBySumSendNumAsync(int sumSendNum, int top_)
		{
			return await GetBySumSendNumAsync(sumSendNum, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SumSendNum（字段） 查询
		/// </summary>
		/// /// <param name = "sumSendNum">轮盘赠送次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_user_dayEO> GetBySumSendNum(int sumSendNum, int top_, TransactionManager tm_)
		{
			return GetBySumSendNum(sumSendNum, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette101001_user_dayEO>> GetBySumSendNumAsync(int sumSendNum, int top_, TransactionManager tm_)
		{
			return await GetBySumSendNumAsync(sumSendNum, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SumSendNum（字段） 查询
		/// </summary>
		/// /// <param name = "sumSendNum">轮盘赠送次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_user_dayEO> GetBySumSendNum(int sumSendNum, string sort_)
		{
			return GetBySumSendNum(sumSendNum, 0, sort_, null);
		}
		public async Task<List<Sa_roulette101001_user_dayEO>> GetBySumSendNumAsync(int sumSendNum, string sort_)
		{
			return await GetBySumSendNumAsync(sumSendNum, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 SumSendNum（字段） 查询
		/// </summary>
		/// /// <param name = "sumSendNum">轮盘赠送次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_user_dayEO> GetBySumSendNum(int sumSendNum, string sort_, TransactionManager tm_)
		{
			return GetBySumSendNum(sumSendNum, 0, sort_, tm_);
		}
		public async Task<List<Sa_roulette101001_user_dayEO>> GetBySumSendNumAsync(int sumSendNum, string sort_, TransactionManager tm_)
		{
			return await GetBySumSendNumAsync(sumSendNum, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 SumSendNum（字段） 查询
		/// </summary>
		/// /// <param name = "sumSendNum">轮盘赠送次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_user_dayEO> GetBySumSendNum(int sumSendNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SumSendNum` = @SumSendNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SumSendNum", sumSendNum, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_roulette101001_user_dayEO.MapDataReader);
		}
		public async Task<List<Sa_roulette101001_user_dayEO>> GetBySumSendNumAsync(int sumSendNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SumSendNum` = @SumSendNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SumSendNum", sumSendNum, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_roulette101001_user_dayEO.MapDataReader);
		}
		#endregion // GetBySumSendNum
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_user_dayEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<Sa_roulette101001_user_dayEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_user_dayEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette101001_user_dayEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_user_dayEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<Sa_roulette101001_user_dayEO>> GetByRecDateAsync(DateTime recDate, int top_)
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
		public List<Sa_roulette101001_user_dayEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette101001_user_dayEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette101001_user_dayEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<Sa_roulette101001_user_dayEO>> GetByRecDateAsync(DateTime recDate, string sort_)
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
		public List<Sa_roulette101001_user_dayEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<Sa_roulette101001_user_dayEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
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
		public List<Sa_roulette101001_user_dayEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_roulette101001_user_dayEO.MapDataReader);
		}
		public async Task<List<Sa_roulette101001_user_dayEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_roulette101001_user_dayEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
