/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * AiUo代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/AiUo
 * 文档生成时间：2023-10-24 18: 05:02
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
	/// 签到奖励明细
	/// 【表 sa_signin100012_detail 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Sa_signin100012_detailEO : IRowMapper<Sa_signin100012_detailEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Sa_signin100012_detailEO()
		{
			this.Reward = 0;
			this.RecDate = DateTime.Now;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private DateTime _originalDayId;
		/// <summary>
		/// 【数据库中的原始主键 DayId 值的副本，用于主键值更新】
		/// </summary>
		public DateTime OriginalDayId
		{
			get { return _originalDayId; }
			set { HasOriginal = true; _originalDayId = value; }
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
	        return new Dictionary<string, object>() { { "DayId", DayId },  { "UserID", UserID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 签到日期（operatorId当地时间）
		/// 【主键 date】
		/// </summary>
		[DataMember(Order = 1)]
		public DateTime DayId { get; set; }
		/// <summary>
		/// 用户编码
		/// 【主键 varchar(36)】
		/// </summary>
		[DataMember(Order = 2)]
		public string UserID { get; set; }
		/// <summary>
		/// 奖励金额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 3)]
		public long Reward { get; set; }
		/// <summary>
		/// 当前签到周期第几天
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 4)]
		public int CurrentCycleNumber { get; set; }
		/// <summary>
		/// 是否补签
		/// 【字段 tinyint(1)】
		/// </summary>
		[DataMember(Order = 5)]
		public bool IsMissSignin { get; set; }
		/// <summary>
		/// 补签日期
		/// 【字段 date】
		/// </summary>
		[DataMember(Order = 6)]
		public DateTime? MissSigninDate { get; set; }
		/// <summary>
		/// 签到周期起始日期
		/// 【字段 date】
		/// </summary>
		[DataMember(Order = 7)]
		public DateTime SigninCycleStartDate { get; set; }
		/// <summary>
		/// 签到周期截止日期
		/// 【字段 date】
		/// </summary>
		[DataMember(Order = 8)]
		public DateTime SigninCycleEndDate { get; set; }
		/// <summary>
		/// 记录时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 9)]
		public DateTime RecDate { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Sa_signin100012_detailEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Sa_signin100012_detailEO MapDataReader(IDataReader reader)
		{
		    Sa_signin100012_detailEO ret = new Sa_signin100012_detailEO();
			ret.DayId = reader.ToDateTime("DayId");
			ret.OriginalDayId = ret.DayId;
			ret.UserID = reader.ToString("UserID");
			ret.OriginalUserID = ret.UserID;
			ret.Reward = reader.ToInt64("Reward");
			ret.CurrentCycleNumber = reader.ToInt32("CurrentCycleNumber");
			ret.IsMissSignin = reader.ToBoolean("IsMissSignin");
			ret.MissSigninDate = reader.ToDateTimeN("MissSigninDate");
			ret.SigninCycleStartDate = reader.ToDateTime("SigninCycleStartDate");
			ret.SigninCycleEndDate = reader.ToDateTime("SigninCycleEndDate");
			ret.RecDate = reader.ToDateTime("RecDate");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 签到奖励明细
	/// 【表 sa_signin100012_detail 的操作类】
	/// </summary>
	[Obsolete]
	public class Sa_signin100012_detailMO : MySqlTableMO<Sa_signin100012_detailEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`sa_signin100012_detail`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Sa_signin100012_detailMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Sa_signin100012_detailMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Sa_signin100012_detailMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Sa_signin100012_detailEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Sa_signin100012_detailEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Sa_signin100012_detailEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`DayId`, `UserID`, `Reward`, `CurrentCycleNumber`, `IsMissSignin`, `MissSigninDate`, `SigninCycleStartDate`, `SigninCycleEndDate`, `RecDate`) VALUE (@DayId, @UserID, @Reward, @CurrentCycleNumber, @IsMissSignin, @MissSigninDate, @SigninCycleStartDate, @SigninCycleEndDate, @RecDate);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", item.DayId, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Reward", item.Reward, MySqlDbType.Int64),
				Database.CreateInParameter("@CurrentCycleNumber", item.CurrentCycleNumber, MySqlDbType.Int32),
				Database.CreateInParameter("@IsMissSignin", item.IsMissSignin, MySqlDbType.Byte),
				Database.CreateInParameter("@MissSigninDate", item.MissSigninDate.HasValue ? item.MissSigninDate.Value : (object)DBNull.Value, MySqlDbType.Date),
				Database.CreateInParameter("@SigninCycleStartDate", item.SigninCycleStartDate, MySqlDbType.Date),
				Database.CreateInParameter("@SigninCycleEndDate", item.SigninCycleEndDate, MySqlDbType.Date),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
			};
		}
		public int AddByBatch(IEnumerable<Sa_signin100012_detailEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Sa_signin100012_detailEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sa_signin100012_detailEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`DayId`, `UserID`, `Reward`, `CurrentCycleNumber`, `IsMissSignin`, `MissSigninDate`, `SigninCycleStartDate`, `SigninCycleEndDate`, `RecDate`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.DayId.ToString("yyyy-MM-dd HH:mm:ss")}','{item.UserID}',{item.Reward},{item.CurrentCycleNumber},{item.IsMissSignin},'{item.MissSigninDate?.ToString("yyyy-MM-dd HH:mm:ss")}','{item.SigninCycleStartDate.ToString("yyyy-MM-dd HH:mm:ss")}','{item.SigninCycleEndDate.ToString("yyyy-MM-dd HH:mm:ss")}','{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
		/// /// <param name = "dayId">签到日期（operatorId当地时间）</param>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(DateTime dayId, string userID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(dayId, userID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(DateTime dayId, string userID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(dayId, userID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(DateTime dayId, string userID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `DayId` = @DayId AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Sa_signin100012_detailEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.DayId, item.UserID, tm_);
		}
		public async Task<int> RemoveAsync(Sa_signin100012_detailEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.DayId, item.UserID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByDayId
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "dayId">签到日期（operatorId当地时间）</param>
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
		#region RemoveByUserID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
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
		#region RemoveByReward
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "reward">奖励金额</param>
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
		#region RemoveByCurrentCycleNumber
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "currentCycleNumber">当前签到周期第几天</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCurrentCycleNumber(int currentCycleNumber, TransactionManager tm_ = null)
		{
			RepairRemoveByCurrentCycleNumberData(currentCycleNumber, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCurrentCycleNumberAsync(int currentCycleNumber, TransactionManager tm_ = null)
		{
			RepairRemoveByCurrentCycleNumberData(currentCycleNumber, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCurrentCycleNumberData(int currentCycleNumber, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `CurrentCycleNumber` = @CurrentCycleNumber";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrentCycleNumber", currentCycleNumber, MySqlDbType.Int32));
		}
		#endregion // RemoveByCurrentCycleNumber
		#region RemoveByIsMissSignin
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "isMissSignin">是否补签</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByIsMissSignin(bool isMissSignin, TransactionManager tm_ = null)
		{
			RepairRemoveByIsMissSigninData(isMissSignin, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByIsMissSigninAsync(bool isMissSignin, TransactionManager tm_ = null)
		{
			RepairRemoveByIsMissSigninData(isMissSignin, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByIsMissSigninData(bool isMissSignin, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `IsMissSignin` = @IsMissSignin";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsMissSignin", isMissSignin, MySqlDbType.Byte));
		}
		#endregion // RemoveByIsMissSignin
		#region RemoveByMissSigninDate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "missSigninDate">补签日期</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByMissSigninDate(DateTime? missSigninDate, TransactionManager tm_ = null)
		{
			RepairRemoveByMissSigninDateData(missSigninDate.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByMissSigninDateAsync(DateTime? missSigninDate, TransactionManager tm_ = null)
		{
			RepairRemoveByMissSigninDateData(missSigninDate.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByMissSigninDateData(DateTime? missSigninDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (missSigninDate.HasValue ? "`MissSigninDate` = @MissSigninDate" : "`MissSigninDate` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (missSigninDate.HasValue)
				paras_.Add(Database.CreateInParameter("@MissSigninDate", missSigninDate.Value, MySqlDbType.Date));
		}
		#endregion // RemoveByMissSigninDate
		#region RemoveBySigninCycleStartDate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "signinCycleStartDate">签到周期起始日期</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveBySigninCycleStartDate(DateTime signinCycleStartDate, TransactionManager tm_ = null)
		{
			RepairRemoveBySigninCycleStartDateData(signinCycleStartDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveBySigninCycleStartDateAsync(DateTime signinCycleStartDate, TransactionManager tm_ = null)
		{
			RepairRemoveBySigninCycleStartDateData(signinCycleStartDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveBySigninCycleStartDateData(DateTime signinCycleStartDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `SigninCycleStartDate` = @SigninCycleStartDate";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SigninCycleStartDate", signinCycleStartDate, MySqlDbType.Date));
		}
		#endregion // RemoveBySigninCycleStartDate
		#region RemoveBySigninCycleEndDate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "signinCycleEndDate">签到周期截止日期</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveBySigninCycleEndDate(DateTime signinCycleEndDate, TransactionManager tm_ = null)
		{
			RepairRemoveBySigninCycleEndDateData(signinCycleEndDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveBySigninCycleEndDateAsync(DateTime signinCycleEndDate, TransactionManager tm_ = null)
		{
			RepairRemoveBySigninCycleEndDateData(signinCycleEndDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveBySigninCycleEndDateData(DateTime signinCycleEndDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `SigninCycleEndDate` = @SigninCycleEndDate";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SigninCycleEndDate", signinCycleEndDate, MySqlDbType.Date));
		}
		#endregion // RemoveBySigninCycleEndDate
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
		public int Put(Sa_signin100012_detailEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Sa_signin100012_detailEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Sa_signin100012_detailEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `DayId` = @DayId, `UserID` = @UserID, `Reward` = @Reward, `CurrentCycleNumber` = @CurrentCycleNumber, `IsMissSignin` = @IsMissSignin, `MissSigninDate` = @MissSigninDate, `SigninCycleStartDate` = @SigninCycleStartDate, `SigninCycleEndDate` = @SigninCycleEndDate WHERE `DayId` = @DayId_Original AND `UserID` = @UserID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", item.DayId, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Reward", item.Reward, MySqlDbType.Int64),
				Database.CreateInParameter("@CurrentCycleNumber", item.CurrentCycleNumber, MySqlDbType.Int32),
				Database.CreateInParameter("@IsMissSignin", item.IsMissSignin, MySqlDbType.Byte),
				Database.CreateInParameter("@MissSigninDate", item.MissSigninDate.HasValue ? item.MissSigninDate.Value : (object)DBNull.Value, MySqlDbType.Date),
				Database.CreateInParameter("@SigninCycleStartDate", item.SigninCycleStartDate, MySqlDbType.Date),
				Database.CreateInParameter("@SigninCycleEndDate", item.SigninCycleEndDate, MySqlDbType.Date),
				Database.CreateInParameter("@DayId_Original", item.HasOriginal ? item.OriginalDayId : item.DayId, MySqlDbType.Date),
				Database.CreateInParameter("@UserID_Original", item.HasOriginal ? item.OriginalUserID : item.UserID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Sa_signin100012_detailEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Sa_signin100012_detailEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "dayId">签到日期（operatorId当地时间）</param>
		/// /// <param name = "userID">用户编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(DateTime dayId, string userID, string set_, params object[] values_)
		{
			return Put(set_, "`DayId` = @DayId AND `UserID` = @UserID", ConcatValues(values_, dayId, userID));
		}
		public async Task<int> PutByPKAsync(DateTime dayId, string userID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`DayId` = @DayId AND `UserID` = @UserID", ConcatValues(values_, dayId, userID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "dayId">签到日期（operatorId当地时间）</param>
		/// /// <param name = "userID">用户编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(DateTime dayId, string userID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`DayId` = @DayId AND `UserID` = @UserID", tm_, ConcatValues(values_, dayId, userID));
		}
		public async Task<int> PutByPKAsync(DateTime dayId, string userID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`DayId` = @DayId AND `UserID` = @UserID", tm_, ConcatValues(values_, dayId, userID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "dayId">签到日期（operatorId当地时间）</param>
		/// /// <param name = "userID">用户编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(DateTime dayId, string userID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`DayId` = @DayId AND `UserID` = @UserID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(DateTime dayId, string userID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`DayId` = @DayId AND `UserID` = @UserID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutDayId
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "dayId">签到日期（operatorId当地时间）</param>
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
		#region PutUserID
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
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
		#region PutReward
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayId">签到日期（operatorId当地时间）</param>
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "reward">奖励金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRewardByPK(DateTime dayId, string userID, long reward, TransactionManager tm_ = null)
		{
			RepairPutRewardByPKData(dayId, userID, reward, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRewardByPKAsync(DateTime dayId, string userID, long reward, TransactionManager tm_ = null)
		{
			RepairPutRewardByPKData(dayId, userID, reward, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRewardByPKData(DateTime dayId, string userID, long reward, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Reward` = @Reward  WHERE `DayId` = @DayId AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Reward", reward, MySqlDbType.Int64),
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "reward">奖励金额</param>
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
		#region PutCurrentCycleNumber
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayId">签到日期（operatorId当地时间）</param>
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "currentCycleNumber">当前签到周期第几天</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCurrentCycleNumberByPK(DateTime dayId, string userID, int currentCycleNumber, TransactionManager tm_ = null)
		{
			RepairPutCurrentCycleNumberByPKData(dayId, userID, currentCycleNumber, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCurrentCycleNumberByPKAsync(DateTime dayId, string userID, int currentCycleNumber, TransactionManager tm_ = null)
		{
			RepairPutCurrentCycleNumberByPKData(dayId, userID, currentCycleNumber, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCurrentCycleNumberByPKData(DateTime dayId, string userID, int currentCycleNumber, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CurrentCycleNumber` = @CurrentCycleNumber  WHERE `DayId` = @DayId AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CurrentCycleNumber", currentCycleNumber, MySqlDbType.Int32),
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "currentCycleNumber">当前签到周期第几天</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCurrentCycleNumber(int currentCycleNumber, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CurrentCycleNumber` = @CurrentCycleNumber";
			var parameter_ = Database.CreateInParameter("@CurrentCycleNumber", currentCycleNumber, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCurrentCycleNumberAsync(int currentCycleNumber, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CurrentCycleNumber` = @CurrentCycleNumber";
			var parameter_ = Database.CreateInParameter("@CurrentCycleNumber", currentCycleNumber, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCurrentCycleNumber
		#region PutIsMissSignin
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayId">签到日期（operatorId当地时间）</param>
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "isMissSignin">是否补签</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsMissSigninByPK(DateTime dayId, string userID, bool isMissSignin, TransactionManager tm_ = null)
		{
			RepairPutIsMissSigninByPKData(dayId, userID, isMissSignin, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutIsMissSigninByPKAsync(DateTime dayId, string userID, bool isMissSignin, TransactionManager tm_ = null)
		{
			RepairPutIsMissSigninByPKData(dayId, userID, isMissSignin, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutIsMissSigninByPKData(DateTime dayId, string userID, bool isMissSignin, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `IsMissSignin` = @IsMissSignin  WHERE `DayId` = @DayId AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@IsMissSignin", isMissSignin, MySqlDbType.Byte),
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "isMissSignin">是否补签</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsMissSignin(bool isMissSignin, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsMissSignin` = @IsMissSignin";
			var parameter_ = Database.CreateInParameter("@IsMissSignin", isMissSignin, MySqlDbType.Byte);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutIsMissSigninAsync(bool isMissSignin, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsMissSignin` = @IsMissSignin";
			var parameter_ = Database.CreateInParameter("@IsMissSignin", isMissSignin, MySqlDbType.Byte);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutIsMissSignin
		#region PutMissSigninDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayId">签到日期（operatorId当地时间）</param>
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "missSigninDate">补签日期</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMissSigninDateByPK(DateTime dayId, string userID, DateTime? missSigninDate, TransactionManager tm_ = null)
		{
			RepairPutMissSigninDateByPKData(dayId, userID, missSigninDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutMissSigninDateByPKAsync(DateTime dayId, string userID, DateTime? missSigninDate, TransactionManager tm_ = null)
		{
			RepairPutMissSigninDateByPKData(dayId, userID, missSigninDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutMissSigninDateByPKData(DateTime dayId, string userID, DateTime? missSigninDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `MissSigninDate` = @MissSigninDate  WHERE `DayId` = @DayId AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MissSigninDate", missSigninDate.HasValue ? missSigninDate.Value : (object)DBNull.Value, MySqlDbType.Date),
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "missSigninDate">补签日期</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMissSigninDate(DateTime? missSigninDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MissSigninDate` = @MissSigninDate";
			var parameter_ = Database.CreateInParameter("@MissSigninDate", missSigninDate.HasValue ? missSigninDate.Value : (object)DBNull.Value, MySqlDbType.Date);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutMissSigninDateAsync(DateTime? missSigninDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MissSigninDate` = @MissSigninDate";
			var parameter_ = Database.CreateInParameter("@MissSigninDate", missSigninDate.HasValue ? missSigninDate.Value : (object)DBNull.Value, MySqlDbType.Date);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutMissSigninDate
		#region PutSigninCycleStartDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayId">签到日期（operatorId当地时间）</param>
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "signinCycleStartDate">签到周期起始日期</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSigninCycleStartDateByPK(DateTime dayId, string userID, DateTime signinCycleStartDate, TransactionManager tm_ = null)
		{
			RepairPutSigninCycleStartDateByPKData(dayId, userID, signinCycleStartDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutSigninCycleStartDateByPKAsync(DateTime dayId, string userID, DateTime signinCycleStartDate, TransactionManager tm_ = null)
		{
			RepairPutSigninCycleStartDateByPKData(dayId, userID, signinCycleStartDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutSigninCycleStartDateByPKData(DateTime dayId, string userID, DateTime signinCycleStartDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `SigninCycleStartDate` = @SigninCycleStartDate  WHERE `DayId` = @DayId AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SigninCycleStartDate", signinCycleStartDate, MySqlDbType.Date),
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "signinCycleStartDate">签到周期起始日期</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSigninCycleStartDate(DateTime signinCycleStartDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SigninCycleStartDate` = @SigninCycleStartDate";
			var parameter_ = Database.CreateInParameter("@SigninCycleStartDate", signinCycleStartDate, MySqlDbType.Date);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutSigninCycleStartDateAsync(DateTime signinCycleStartDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SigninCycleStartDate` = @SigninCycleStartDate";
			var parameter_ = Database.CreateInParameter("@SigninCycleStartDate", signinCycleStartDate, MySqlDbType.Date);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutSigninCycleStartDate
		#region PutSigninCycleEndDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayId">签到日期（operatorId当地时间）</param>
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "signinCycleEndDate">签到周期截止日期</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSigninCycleEndDateByPK(DateTime dayId, string userID, DateTime signinCycleEndDate, TransactionManager tm_ = null)
		{
			RepairPutSigninCycleEndDateByPKData(dayId, userID, signinCycleEndDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutSigninCycleEndDateByPKAsync(DateTime dayId, string userID, DateTime signinCycleEndDate, TransactionManager tm_ = null)
		{
			RepairPutSigninCycleEndDateByPKData(dayId, userID, signinCycleEndDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutSigninCycleEndDateByPKData(DateTime dayId, string userID, DateTime signinCycleEndDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `SigninCycleEndDate` = @SigninCycleEndDate  WHERE `DayId` = @DayId AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SigninCycleEndDate", signinCycleEndDate, MySqlDbType.Date),
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "signinCycleEndDate">签到周期截止日期</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSigninCycleEndDate(DateTime signinCycleEndDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SigninCycleEndDate` = @SigninCycleEndDate";
			var parameter_ = Database.CreateInParameter("@SigninCycleEndDate", signinCycleEndDate, MySqlDbType.Date);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutSigninCycleEndDateAsync(DateTime signinCycleEndDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SigninCycleEndDate` = @SigninCycleEndDate";
			var parameter_ = Database.CreateInParameter("@SigninCycleEndDate", signinCycleEndDate, MySqlDbType.Date);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutSigninCycleEndDate
		#region PutRecDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayId">签到日期（operatorId当地时间）</param>
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(DateTime dayId, string userID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(dayId, userID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(DateTime dayId, string userID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(dayId, userID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(DateTime dayId, string userID, DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `DayId` = @DayId AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
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
		public bool Set(Sa_signin100012_detailEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.DayId, item.UserID) == null)
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
		public async Task<bool> SetAsync(Sa_signin100012_detailEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.DayId, item.UserID) == null)
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
		/// /// <param name = "dayId">签到日期（operatorId当地时间）</param>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Sa_signin100012_detailEO GetByPK(DateTime dayId, string userID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(dayId, userID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sa_signin100012_detailEO.MapDataReader);
		}
		public async Task<Sa_signin100012_detailEO> GetByPKAsync(DateTime dayId, string userID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(dayId, userID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sa_signin100012_detailEO.MapDataReader);
		}
		private void RepairGetByPKData(DateTime dayId, string userID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`DayId` = @DayId AND `UserID` = @UserID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 DayId（字段）
		/// </summary>
		/// /// <param name = "dayId">签到日期（operatorId当地时间）</param>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetDayIdByPK(DateTime dayId, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`DayId`", "`DayId` = @DayId AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<DateTime> GetDayIdByPKAsync(DateTime dayId, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`DayId`", "`DayId` = @DayId AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 UserID（字段）
		/// </summary>
		/// /// <param name = "dayId">签到日期（operatorId当地时间）</param>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetUserIDByPK(DateTime dayId, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`UserID`", "`DayId` = @DayId AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<string> GetUserIDByPKAsync(DateTime dayId, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`UserID`", "`DayId` = @DayId AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Reward（字段）
		/// </summary>
		/// /// <param name = "dayId">签到日期（operatorId当地时间）</param>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetRewardByPK(DateTime dayId, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`Reward`", "`DayId` = @DayId AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetRewardByPKAsync(DateTime dayId, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`Reward`", "`DayId` = @DayId AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CurrentCycleNumber（字段）
		/// </summary>
		/// /// <param name = "dayId">签到日期（operatorId当地时间）</param>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetCurrentCycleNumberByPK(DateTime dayId, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`CurrentCycleNumber`", "`DayId` = @DayId AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<int> GetCurrentCycleNumberByPKAsync(DateTime dayId, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`CurrentCycleNumber`", "`DayId` = @DayId AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 IsMissSignin（字段）
		/// </summary>
		/// /// <param name = "dayId">签到日期（operatorId当地时间）</param>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public bool GetIsMissSigninByPK(DateTime dayId, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (bool)GetScalar("`IsMissSignin`", "`DayId` = @DayId AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<bool> GetIsMissSigninByPKAsync(DateTime dayId, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (bool)await GetScalarAsync("`IsMissSignin`", "`DayId` = @DayId AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 MissSigninDate（字段）
		/// </summary>
		/// /// <param name = "dayId">签到日期（operatorId当地时间）</param>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime? GetMissSigninDateByPK(DateTime dayId, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (DateTime?)GetScalar("`MissSigninDate`", "`DayId` = @DayId AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<DateTime?> GetMissSigninDateByPKAsync(DateTime dayId, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (DateTime?)await GetScalarAsync("`MissSigninDate`", "`DayId` = @DayId AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 SigninCycleStartDate（字段）
		/// </summary>
		/// /// <param name = "dayId">签到日期（operatorId当地时间）</param>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetSigninCycleStartDateByPK(DateTime dayId, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`SigninCycleStartDate`", "`DayId` = @DayId AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<DateTime> GetSigninCycleStartDateByPKAsync(DateTime dayId, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`SigninCycleStartDate`", "`DayId` = @DayId AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 SigninCycleEndDate（字段）
		/// </summary>
		/// /// <param name = "dayId">签到日期（operatorId当地时间）</param>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetSigninCycleEndDateByPK(DateTime dayId, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`SigninCycleEndDate`", "`DayId` = @DayId AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<DateTime> GetSigninCycleEndDateByPKAsync(DateTime dayId, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`SigninCycleEndDate`", "`DayId` = @DayId AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "dayId">签到日期（operatorId当地时间）</param>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetRecDateByPK(DateTime dayId, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`RecDate`", "`DayId` = @DayId AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<DateTime> GetRecDateByPKAsync(DateTime dayId, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`RecDate`", "`DayId` = @DayId AND `UserID` = @UserID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByDayId
		
		/// <summary>
		/// 按 DayId（字段） 查询
		/// </summary>
		/// /// <param name = "dayId">签到日期（operatorId当地时间）</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_detailEO> GetByDayId(DateTime dayId)
		{
			return GetByDayId(dayId, 0, string.Empty, null);
		}
		public async Task<List<Sa_signin100012_detailEO>> GetByDayIdAsync(DateTime dayId)
		{
			return await GetByDayIdAsync(dayId, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DayId（字段） 查询
		/// </summary>
		/// /// <param name = "dayId">签到日期（operatorId当地时间）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_detailEO> GetByDayId(DateTime dayId, TransactionManager tm_)
		{
			return GetByDayId(dayId, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_signin100012_detailEO>> GetByDayIdAsync(DateTime dayId, TransactionManager tm_)
		{
			return await GetByDayIdAsync(dayId, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DayId（字段） 查询
		/// </summary>
		/// /// <param name = "dayId">签到日期（operatorId当地时间）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_detailEO> GetByDayId(DateTime dayId, int top_)
		{
			return GetByDayId(dayId, top_, string.Empty, null);
		}
		public async Task<List<Sa_signin100012_detailEO>> GetByDayIdAsync(DateTime dayId, int top_)
		{
			return await GetByDayIdAsync(dayId, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DayId（字段） 查询
		/// </summary>
		/// /// <param name = "dayId">签到日期（operatorId当地时间）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_detailEO> GetByDayId(DateTime dayId, int top_, TransactionManager tm_)
		{
			return GetByDayId(dayId, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_signin100012_detailEO>> GetByDayIdAsync(DateTime dayId, int top_, TransactionManager tm_)
		{
			return await GetByDayIdAsync(dayId, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DayId（字段） 查询
		/// </summary>
		/// /// <param name = "dayId">签到日期（operatorId当地时间）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_detailEO> GetByDayId(DateTime dayId, string sort_)
		{
			return GetByDayId(dayId, 0, sort_, null);
		}
		public async Task<List<Sa_signin100012_detailEO>> GetByDayIdAsync(DateTime dayId, string sort_)
		{
			return await GetByDayIdAsync(dayId, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DayId（字段） 查询
		/// </summary>
		/// /// <param name = "dayId">签到日期（operatorId当地时间）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_detailEO> GetByDayId(DateTime dayId, string sort_, TransactionManager tm_)
		{
			return GetByDayId(dayId, 0, sort_, tm_);
		}
		public async Task<List<Sa_signin100012_detailEO>> GetByDayIdAsync(DateTime dayId, string sort_, TransactionManager tm_)
		{
			return await GetByDayIdAsync(dayId, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DayId（字段） 查询
		/// </summary>
		/// /// <param name = "dayId">签到日期（operatorId当地时间）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_detailEO> GetByDayId(DateTime dayId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DayId` = @DayId", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_signin100012_detailEO.MapDataReader);
		}
		public async Task<List<Sa_signin100012_detailEO>> GetByDayIdAsync(DateTime dayId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DayId` = @DayId", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_signin100012_detailEO.MapDataReader);
		}
		#endregion // GetByDayId
		#region GetByUserID
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_detailEO> GetByUserID(string userID)
		{
			return GetByUserID(userID, 0, string.Empty, null);
		}
		public async Task<List<Sa_signin100012_detailEO>> GetByUserIDAsync(string userID)
		{
			return await GetByUserIDAsync(userID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_detailEO> GetByUserID(string userID, TransactionManager tm_)
		{
			return GetByUserID(userID, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_signin100012_detailEO>> GetByUserIDAsync(string userID, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_detailEO> GetByUserID(string userID, int top_)
		{
			return GetByUserID(userID, top_, string.Empty, null);
		}
		public async Task<List<Sa_signin100012_detailEO>> GetByUserIDAsync(string userID, int top_)
		{
			return await GetByUserIDAsync(userID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_detailEO> GetByUserID(string userID, int top_, TransactionManager tm_)
		{
			return GetByUserID(userID, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_signin100012_detailEO>> GetByUserIDAsync(string userID, int top_, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_detailEO> GetByUserID(string userID, string sort_)
		{
			return GetByUserID(userID, 0, sort_, null);
		}
		public async Task<List<Sa_signin100012_detailEO>> GetByUserIDAsync(string userID, string sort_)
		{
			return await GetByUserIDAsync(userID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_detailEO> GetByUserID(string userID, string sort_, TransactionManager tm_)
		{
			return GetByUserID(userID, 0, sort_, tm_);
		}
		public async Task<List<Sa_signin100012_detailEO>> GetByUserIDAsync(string userID, string sort_, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_detailEO> GetByUserID(string userID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserID` = @UserID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_signin100012_detailEO.MapDataReader);
		}
		public async Task<List<Sa_signin100012_detailEO>> GetByUserIDAsync(string userID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserID` = @UserID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_signin100012_detailEO.MapDataReader);
		}
		#endregion // GetByUserID
		#region GetByReward
		
		/// <summary>
		/// 按 Reward（字段） 查询
		/// </summary>
		/// /// <param name = "reward">奖励金额</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_detailEO> GetByReward(long reward)
		{
			return GetByReward(reward, 0, string.Empty, null);
		}
		public async Task<List<Sa_signin100012_detailEO>> GetByRewardAsync(long reward)
		{
			return await GetByRewardAsync(reward, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Reward（字段） 查询
		/// </summary>
		/// /// <param name = "reward">奖励金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_detailEO> GetByReward(long reward, TransactionManager tm_)
		{
			return GetByReward(reward, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_signin100012_detailEO>> GetByRewardAsync(long reward, TransactionManager tm_)
		{
			return await GetByRewardAsync(reward, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Reward（字段） 查询
		/// </summary>
		/// /// <param name = "reward">奖励金额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_detailEO> GetByReward(long reward, int top_)
		{
			return GetByReward(reward, top_, string.Empty, null);
		}
		public async Task<List<Sa_signin100012_detailEO>> GetByRewardAsync(long reward, int top_)
		{
			return await GetByRewardAsync(reward, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Reward（字段） 查询
		/// </summary>
		/// /// <param name = "reward">奖励金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_detailEO> GetByReward(long reward, int top_, TransactionManager tm_)
		{
			return GetByReward(reward, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_signin100012_detailEO>> GetByRewardAsync(long reward, int top_, TransactionManager tm_)
		{
			return await GetByRewardAsync(reward, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Reward（字段） 查询
		/// </summary>
		/// /// <param name = "reward">奖励金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_detailEO> GetByReward(long reward, string sort_)
		{
			return GetByReward(reward, 0, sort_, null);
		}
		public async Task<List<Sa_signin100012_detailEO>> GetByRewardAsync(long reward, string sort_)
		{
			return await GetByRewardAsync(reward, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Reward（字段） 查询
		/// </summary>
		/// /// <param name = "reward">奖励金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_detailEO> GetByReward(long reward, string sort_, TransactionManager tm_)
		{
			return GetByReward(reward, 0, sort_, tm_);
		}
		public async Task<List<Sa_signin100012_detailEO>> GetByRewardAsync(long reward, string sort_, TransactionManager tm_)
		{
			return await GetByRewardAsync(reward, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Reward（字段） 查询
		/// </summary>
		/// /// <param name = "reward">奖励金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_detailEO> GetByReward(long reward, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Reward` = @Reward", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Reward", reward, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_signin100012_detailEO.MapDataReader);
		}
		public async Task<List<Sa_signin100012_detailEO>> GetByRewardAsync(long reward, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Reward` = @Reward", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Reward", reward, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_signin100012_detailEO.MapDataReader);
		}
		#endregion // GetByReward
		#region GetByCurrentCycleNumber
		
		/// <summary>
		/// 按 CurrentCycleNumber（字段） 查询
		/// </summary>
		/// /// <param name = "currentCycleNumber">当前签到周期第几天</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_detailEO> GetByCurrentCycleNumber(int currentCycleNumber)
		{
			return GetByCurrentCycleNumber(currentCycleNumber, 0, string.Empty, null);
		}
		public async Task<List<Sa_signin100012_detailEO>> GetByCurrentCycleNumberAsync(int currentCycleNumber)
		{
			return await GetByCurrentCycleNumberAsync(currentCycleNumber, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrentCycleNumber（字段） 查询
		/// </summary>
		/// /// <param name = "currentCycleNumber">当前签到周期第几天</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_detailEO> GetByCurrentCycleNumber(int currentCycleNumber, TransactionManager tm_)
		{
			return GetByCurrentCycleNumber(currentCycleNumber, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_signin100012_detailEO>> GetByCurrentCycleNumberAsync(int currentCycleNumber, TransactionManager tm_)
		{
			return await GetByCurrentCycleNumberAsync(currentCycleNumber, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrentCycleNumber（字段） 查询
		/// </summary>
		/// /// <param name = "currentCycleNumber">当前签到周期第几天</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_detailEO> GetByCurrentCycleNumber(int currentCycleNumber, int top_)
		{
			return GetByCurrentCycleNumber(currentCycleNumber, top_, string.Empty, null);
		}
		public async Task<List<Sa_signin100012_detailEO>> GetByCurrentCycleNumberAsync(int currentCycleNumber, int top_)
		{
			return await GetByCurrentCycleNumberAsync(currentCycleNumber, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrentCycleNumber（字段） 查询
		/// </summary>
		/// /// <param name = "currentCycleNumber">当前签到周期第几天</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_detailEO> GetByCurrentCycleNumber(int currentCycleNumber, int top_, TransactionManager tm_)
		{
			return GetByCurrentCycleNumber(currentCycleNumber, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_signin100012_detailEO>> GetByCurrentCycleNumberAsync(int currentCycleNumber, int top_, TransactionManager tm_)
		{
			return await GetByCurrentCycleNumberAsync(currentCycleNumber, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrentCycleNumber（字段） 查询
		/// </summary>
		/// /// <param name = "currentCycleNumber">当前签到周期第几天</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_detailEO> GetByCurrentCycleNumber(int currentCycleNumber, string sort_)
		{
			return GetByCurrentCycleNumber(currentCycleNumber, 0, sort_, null);
		}
		public async Task<List<Sa_signin100012_detailEO>> GetByCurrentCycleNumberAsync(int currentCycleNumber, string sort_)
		{
			return await GetByCurrentCycleNumberAsync(currentCycleNumber, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CurrentCycleNumber（字段） 查询
		/// </summary>
		/// /// <param name = "currentCycleNumber">当前签到周期第几天</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_detailEO> GetByCurrentCycleNumber(int currentCycleNumber, string sort_, TransactionManager tm_)
		{
			return GetByCurrentCycleNumber(currentCycleNumber, 0, sort_, tm_);
		}
		public async Task<List<Sa_signin100012_detailEO>> GetByCurrentCycleNumberAsync(int currentCycleNumber, string sort_, TransactionManager tm_)
		{
			return await GetByCurrentCycleNumberAsync(currentCycleNumber, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CurrentCycleNumber（字段） 查询
		/// </summary>
		/// /// <param name = "currentCycleNumber">当前签到周期第几天</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_detailEO> GetByCurrentCycleNumber(int currentCycleNumber, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrentCycleNumber` = @CurrentCycleNumber", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrentCycleNumber", currentCycleNumber, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_signin100012_detailEO.MapDataReader);
		}
		public async Task<List<Sa_signin100012_detailEO>> GetByCurrentCycleNumberAsync(int currentCycleNumber, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrentCycleNumber` = @CurrentCycleNumber", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrentCycleNumber", currentCycleNumber, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_signin100012_detailEO.MapDataReader);
		}
		#endregion // GetByCurrentCycleNumber
		#region GetByIsMissSignin
		
		/// <summary>
		/// 按 IsMissSignin（字段） 查询
		/// </summary>
		/// /// <param name = "isMissSignin">是否补签</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_detailEO> GetByIsMissSignin(bool isMissSignin)
		{
			return GetByIsMissSignin(isMissSignin, 0, string.Empty, null);
		}
		public async Task<List<Sa_signin100012_detailEO>> GetByIsMissSigninAsync(bool isMissSignin)
		{
			return await GetByIsMissSigninAsync(isMissSignin, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsMissSignin（字段） 查询
		/// </summary>
		/// /// <param name = "isMissSignin">是否补签</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_detailEO> GetByIsMissSignin(bool isMissSignin, TransactionManager tm_)
		{
			return GetByIsMissSignin(isMissSignin, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_signin100012_detailEO>> GetByIsMissSigninAsync(bool isMissSignin, TransactionManager tm_)
		{
			return await GetByIsMissSigninAsync(isMissSignin, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsMissSignin（字段） 查询
		/// </summary>
		/// /// <param name = "isMissSignin">是否补签</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_detailEO> GetByIsMissSignin(bool isMissSignin, int top_)
		{
			return GetByIsMissSignin(isMissSignin, top_, string.Empty, null);
		}
		public async Task<List<Sa_signin100012_detailEO>> GetByIsMissSigninAsync(bool isMissSignin, int top_)
		{
			return await GetByIsMissSigninAsync(isMissSignin, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsMissSignin（字段） 查询
		/// </summary>
		/// /// <param name = "isMissSignin">是否补签</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_detailEO> GetByIsMissSignin(bool isMissSignin, int top_, TransactionManager tm_)
		{
			return GetByIsMissSignin(isMissSignin, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_signin100012_detailEO>> GetByIsMissSigninAsync(bool isMissSignin, int top_, TransactionManager tm_)
		{
			return await GetByIsMissSigninAsync(isMissSignin, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsMissSignin（字段） 查询
		/// </summary>
		/// /// <param name = "isMissSignin">是否补签</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_detailEO> GetByIsMissSignin(bool isMissSignin, string sort_)
		{
			return GetByIsMissSignin(isMissSignin, 0, sort_, null);
		}
		public async Task<List<Sa_signin100012_detailEO>> GetByIsMissSigninAsync(bool isMissSignin, string sort_)
		{
			return await GetByIsMissSigninAsync(isMissSignin, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 IsMissSignin（字段） 查询
		/// </summary>
		/// /// <param name = "isMissSignin">是否补签</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_detailEO> GetByIsMissSignin(bool isMissSignin, string sort_, TransactionManager tm_)
		{
			return GetByIsMissSignin(isMissSignin, 0, sort_, tm_);
		}
		public async Task<List<Sa_signin100012_detailEO>> GetByIsMissSigninAsync(bool isMissSignin, string sort_, TransactionManager tm_)
		{
			return await GetByIsMissSigninAsync(isMissSignin, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 IsMissSignin（字段） 查询
		/// </summary>
		/// /// <param name = "isMissSignin">是否补签</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_detailEO> GetByIsMissSignin(bool isMissSignin, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsMissSignin` = @IsMissSignin", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsMissSignin", isMissSignin, MySqlDbType.Byte));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_signin100012_detailEO.MapDataReader);
		}
		public async Task<List<Sa_signin100012_detailEO>> GetByIsMissSigninAsync(bool isMissSignin, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsMissSignin` = @IsMissSignin", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsMissSignin", isMissSignin, MySqlDbType.Byte));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_signin100012_detailEO.MapDataReader);
		}
		#endregion // GetByIsMissSignin
		#region GetByMissSigninDate
		
		/// <summary>
		/// 按 MissSigninDate（字段） 查询
		/// </summary>
		/// /// <param name = "missSigninDate">补签日期</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_detailEO> GetByMissSigninDate(DateTime? missSigninDate)
		{
			return GetByMissSigninDate(missSigninDate, 0, string.Empty, null);
		}
		public async Task<List<Sa_signin100012_detailEO>> GetByMissSigninDateAsync(DateTime? missSigninDate)
		{
			return await GetByMissSigninDateAsync(missSigninDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MissSigninDate（字段） 查询
		/// </summary>
		/// /// <param name = "missSigninDate">补签日期</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_detailEO> GetByMissSigninDate(DateTime? missSigninDate, TransactionManager tm_)
		{
			return GetByMissSigninDate(missSigninDate, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_signin100012_detailEO>> GetByMissSigninDateAsync(DateTime? missSigninDate, TransactionManager tm_)
		{
			return await GetByMissSigninDateAsync(missSigninDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MissSigninDate（字段） 查询
		/// </summary>
		/// /// <param name = "missSigninDate">补签日期</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_detailEO> GetByMissSigninDate(DateTime? missSigninDate, int top_)
		{
			return GetByMissSigninDate(missSigninDate, top_, string.Empty, null);
		}
		public async Task<List<Sa_signin100012_detailEO>> GetByMissSigninDateAsync(DateTime? missSigninDate, int top_)
		{
			return await GetByMissSigninDateAsync(missSigninDate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MissSigninDate（字段） 查询
		/// </summary>
		/// /// <param name = "missSigninDate">补签日期</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_detailEO> GetByMissSigninDate(DateTime? missSigninDate, int top_, TransactionManager tm_)
		{
			return GetByMissSigninDate(missSigninDate, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_signin100012_detailEO>> GetByMissSigninDateAsync(DateTime? missSigninDate, int top_, TransactionManager tm_)
		{
			return await GetByMissSigninDateAsync(missSigninDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MissSigninDate（字段） 查询
		/// </summary>
		/// /// <param name = "missSigninDate">补签日期</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_detailEO> GetByMissSigninDate(DateTime? missSigninDate, string sort_)
		{
			return GetByMissSigninDate(missSigninDate, 0, sort_, null);
		}
		public async Task<List<Sa_signin100012_detailEO>> GetByMissSigninDateAsync(DateTime? missSigninDate, string sort_)
		{
			return await GetByMissSigninDateAsync(missSigninDate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 MissSigninDate（字段） 查询
		/// </summary>
		/// /// <param name = "missSigninDate">补签日期</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_detailEO> GetByMissSigninDate(DateTime? missSigninDate, string sort_, TransactionManager tm_)
		{
			return GetByMissSigninDate(missSigninDate, 0, sort_, tm_);
		}
		public async Task<List<Sa_signin100012_detailEO>> GetByMissSigninDateAsync(DateTime? missSigninDate, string sort_, TransactionManager tm_)
		{
			return await GetByMissSigninDateAsync(missSigninDate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 MissSigninDate（字段） 查询
		/// </summary>
		/// /// <param name = "missSigninDate">补签日期</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_detailEO> GetByMissSigninDate(DateTime? missSigninDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(missSigninDate.HasValue ? "`MissSigninDate` = @MissSigninDate" : "`MissSigninDate` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (missSigninDate.HasValue)
				paras_.Add(Database.CreateInParameter("@MissSigninDate", missSigninDate.Value, MySqlDbType.Date));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_signin100012_detailEO.MapDataReader);
		}
		public async Task<List<Sa_signin100012_detailEO>> GetByMissSigninDateAsync(DateTime? missSigninDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(missSigninDate.HasValue ? "`MissSigninDate` = @MissSigninDate" : "`MissSigninDate` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (missSigninDate.HasValue)
				paras_.Add(Database.CreateInParameter("@MissSigninDate", missSigninDate.Value, MySqlDbType.Date));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_signin100012_detailEO.MapDataReader);
		}
		#endregion // GetByMissSigninDate
		#region GetBySigninCycleStartDate
		
		/// <summary>
		/// 按 SigninCycleStartDate（字段） 查询
		/// </summary>
		/// /// <param name = "signinCycleStartDate">签到周期起始日期</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_detailEO> GetBySigninCycleStartDate(DateTime signinCycleStartDate)
		{
			return GetBySigninCycleStartDate(signinCycleStartDate, 0, string.Empty, null);
		}
		public async Task<List<Sa_signin100012_detailEO>> GetBySigninCycleStartDateAsync(DateTime signinCycleStartDate)
		{
			return await GetBySigninCycleStartDateAsync(signinCycleStartDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SigninCycleStartDate（字段） 查询
		/// </summary>
		/// /// <param name = "signinCycleStartDate">签到周期起始日期</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_detailEO> GetBySigninCycleStartDate(DateTime signinCycleStartDate, TransactionManager tm_)
		{
			return GetBySigninCycleStartDate(signinCycleStartDate, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_signin100012_detailEO>> GetBySigninCycleStartDateAsync(DateTime signinCycleStartDate, TransactionManager tm_)
		{
			return await GetBySigninCycleStartDateAsync(signinCycleStartDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SigninCycleStartDate（字段） 查询
		/// </summary>
		/// /// <param name = "signinCycleStartDate">签到周期起始日期</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_detailEO> GetBySigninCycleStartDate(DateTime signinCycleStartDate, int top_)
		{
			return GetBySigninCycleStartDate(signinCycleStartDate, top_, string.Empty, null);
		}
		public async Task<List<Sa_signin100012_detailEO>> GetBySigninCycleStartDateAsync(DateTime signinCycleStartDate, int top_)
		{
			return await GetBySigninCycleStartDateAsync(signinCycleStartDate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SigninCycleStartDate（字段） 查询
		/// </summary>
		/// /// <param name = "signinCycleStartDate">签到周期起始日期</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_detailEO> GetBySigninCycleStartDate(DateTime signinCycleStartDate, int top_, TransactionManager tm_)
		{
			return GetBySigninCycleStartDate(signinCycleStartDate, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_signin100012_detailEO>> GetBySigninCycleStartDateAsync(DateTime signinCycleStartDate, int top_, TransactionManager tm_)
		{
			return await GetBySigninCycleStartDateAsync(signinCycleStartDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SigninCycleStartDate（字段） 查询
		/// </summary>
		/// /// <param name = "signinCycleStartDate">签到周期起始日期</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_detailEO> GetBySigninCycleStartDate(DateTime signinCycleStartDate, string sort_)
		{
			return GetBySigninCycleStartDate(signinCycleStartDate, 0, sort_, null);
		}
		public async Task<List<Sa_signin100012_detailEO>> GetBySigninCycleStartDateAsync(DateTime signinCycleStartDate, string sort_)
		{
			return await GetBySigninCycleStartDateAsync(signinCycleStartDate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 SigninCycleStartDate（字段） 查询
		/// </summary>
		/// /// <param name = "signinCycleStartDate">签到周期起始日期</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_detailEO> GetBySigninCycleStartDate(DateTime signinCycleStartDate, string sort_, TransactionManager tm_)
		{
			return GetBySigninCycleStartDate(signinCycleStartDate, 0, sort_, tm_);
		}
		public async Task<List<Sa_signin100012_detailEO>> GetBySigninCycleStartDateAsync(DateTime signinCycleStartDate, string sort_, TransactionManager tm_)
		{
			return await GetBySigninCycleStartDateAsync(signinCycleStartDate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 SigninCycleStartDate（字段） 查询
		/// </summary>
		/// /// <param name = "signinCycleStartDate">签到周期起始日期</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_detailEO> GetBySigninCycleStartDate(DateTime signinCycleStartDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SigninCycleStartDate` = @SigninCycleStartDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SigninCycleStartDate", signinCycleStartDate, MySqlDbType.Date));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_signin100012_detailEO.MapDataReader);
		}
		public async Task<List<Sa_signin100012_detailEO>> GetBySigninCycleStartDateAsync(DateTime signinCycleStartDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SigninCycleStartDate` = @SigninCycleStartDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SigninCycleStartDate", signinCycleStartDate, MySqlDbType.Date));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_signin100012_detailEO.MapDataReader);
		}
		#endregion // GetBySigninCycleStartDate
		#region GetBySigninCycleEndDate
		
		/// <summary>
		/// 按 SigninCycleEndDate（字段） 查询
		/// </summary>
		/// /// <param name = "signinCycleEndDate">签到周期截止日期</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_detailEO> GetBySigninCycleEndDate(DateTime signinCycleEndDate)
		{
			return GetBySigninCycleEndDate(signinCycleEndDate, 0, string.Empty, null);
		}
		public async Task<List<Sa_signin100012_detailEO>> GetBySigninCycleEndDateAsync(DateTime signinCycleEndDate)
		{
			return await GetBySigninCycleEndDateAsync(signinCycleEndDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SigninCycleEndDate（字段） 查询
		/// </summary>
		/// /// <param name = "signinCycleEndDate">签到周期截止日期</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_detailEO> GetBySigninCycleEndDate(DateTime signinCycleEndDate, TransactionManager tm_)
		{
			return GetBySigninCycleEndDate(signinCycleEndDate, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_signin100012_detailEO>> GetBySigninCycleEndDateAsync(DateTime signinCycleEndDate, TransactionManager tm_)
		{
			return await GetBySigninCycleEndDateAsync(signinCycleEndDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SigninCycleEndDate（字段） 查询
		/// </summary>
		/// /// <param name = "signinCycleEndDate">签到周期截止日期</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_detailEO> GetBySigninCycleEndDate(DateTime signinCycleEndDate, int top_)
		{
			return GetBySigninCycleEndDate(signinCycleEndDate, top_, string.Empty, null);
		}
		public async Task<List<Sa_signin100012_detailEO>> GetBySigninCycleEndDateAsync(DateTime signinCycleEndDate, int top_)
		{
			return await GetBySigninCycleEndDateAsync(signinCycleEndDate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SigninCycleEndDate（字段） 查询
		/// </summary>
		/// /// <param name = "signinCycleEndDate">签到周期截止日期</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_detailEO> GetBySigninCycleEndDate(DateTime signinCycleEndDate, int top_, TransactionManager tm_)
		{
			return GetBySigninCycleEndDate(signinCycleEndDate, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_signin100012_detailEO>> GetBySigninCycleEndDateAsync(DateTime signinCycleEndDate, int top_, TransactionManager tm_)
		{
			return await GetBySigninCycleEndDateAsync(signinCycleEndDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SigninCycleEndDate（字段） 查询
		/// </summary>
		/// /// <param name = "signinCycleEndDate">签到周期截止日期</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_detailEO> GetBySigninCycleEndDate(DateTime signinCycleEndDate, string sort_)
		{
			return GetBySigninCycleEndDate(signinCycleEndDate, 0, sort_, null);
		}
		public async Task<List<Sa_signin100012_detailEO>> GetBySigninCycleEndDateAsync(DateTime signinCycleEndDate, string sort_)
		{
			return await GetBySigninCycleEndDateAsync(signinCycleEndDate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 SigninCycleEndDate（字段） 查询
		/// </summary>
		/// /// <param name = "signinCycleEndDate">签到周期截止日期</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_detailEO> GetBySigninCycleEndDate(DateTime signinCycleEndDate, string sort_, TransactionManager tm_)
		{
			return GetBySigninCycleEndDate(signinCycleEndDate, 0, sort_, tm_);
		}
		public async Task<List<Sa_signin100012_detailEO>> GetBySigninCycleEndDateAsync(DateTime signinCycleEndDate, string sort_, TransactionManager tm_)
		{
			return await GetBySigninCycleEndDateAsync(signinCycleEndDate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 SigninCycleEndDate（字段） 查询
		/// </summary>
		/// /// <param name = "signinCycleEndDate">签到周期截止日期</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_detailEO> GetBySigninCycleEndDate(DateTime signinCycleEndDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SigninCycleEndDate` = @SigninCycleEndDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SigninCycleEndDate", signinCycleEndDate, MySqlDbType.Date));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_signin100012_detailEO.MapDataReader);
		}
		public async Task<List<Sa_signin100012_detailEO>> GetBySigninCycleEndDateAsync(DateTime signinCycleEndDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SigninCycleEndDate` = @SigninCycleEndDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SigninCycleEndDate", signinCycleEndDate, MySqlDbType.Date));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_signin100012_detailEO.MapDataReader);
		}
		#endregion // GetBySigninCycleEndDate
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_detailEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<Sa_signin100012_detailEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_detailEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_signin100012_detailEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_detailEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<Sa_signin100012_detailEO>> GetByRecDateAsync(DateTime recDate, int top_)
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
		public List<Sa_signin100012_detailEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_signin100012_detailEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin100012_detailEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<Sa_signin100012_detailEO>> GetByRecDateAsync(DateTime recDate, string sort_)
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
		public List<Sa_signin100012_detailEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<Sa_signin100012_detailEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
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
		public List<Sa_signin100012_detailEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_signin100012_detailEO.MapDataReader);
		}
		public async Task<List<Sa_signin100012_detailEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_signin100012_detailEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
