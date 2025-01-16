/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * AiUo代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/AiUo
 * 文档生成时间：2023-10-24 18: 05:09
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
	/// 好友邀请分享用户关系表
	/// 【表 sa_invite100013_user 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Sa_invite100013_userEO : IRowMapper<Sa_invite100013_userEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Sa_invite100013_userEO()
		{
			this.IsMeetPayLimit = false;
			this.UserTotalPay = 0;
			this.IsMeetBetLimit = false;
			this.UserTotalBet = 0;
			this.RecDate = DateTime.Now;
			this.UpdateTime = DateTime.Now;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private string _originalPUserID;
		/// <summary>
		/// 【数据库中的原始主键 PUserID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalPUserID
		{
			get { return _originalPUserID; }
			set { HasOriginal = true; _originalPUserID = value; }
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
	        return new Dictionary<string, object>() { { "PUserID", PUserID },  { "UserID", UserID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 邀请人用户编码
		/// 【主键 varchar(36)】
		/// </summary>
		[DataMember(Order = 1)]
		public string PUserID { get; set; }
		/// <summary>
		/// 邀请人运营商编码
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 2)]
		public string POperatorId { get; set; }
		/// <summary>
		/// 被邀请人用户编码
		/// 【主键 varchar(36)】
		/// </summary>
		[DataMember(Order = 3)]
		public string UserID { get; set; }
		/// <summary>
		/// 被邀请人运营商编码
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 4)]
		public string UOperatorId { get; set; }
		/// <summary>
		/// 是否达到充值要求
		/// 【字段 tinyint(1)】
		/// </summary>
		[DataMember(Order = 5)]
		public bool IsMeetPayLimit { get; set; }
		/// <summary>
		/// 被邀请人累计充值
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 6)]
		public long UserTotalPay { get; set; }
		/// <summary>
		/// 是否达到下注要求
		/// 【字段 tinyint(1)】
		/// </summary>
		[DataMember(Order = 7)]
		public bool IsMeetBetLimit { get; set; }
		/// <summary>
		/// 被邀请人累计下注金额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 8)]
		public long UserTotalBet { get; set; }
		/// <summary>
		/// 记录时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 9)]
		public DateTime RecDate { get; set; }
		/// <summary>
		/// 更新时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 10)]
		public DateTime UpdateTime { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Sa_invite100013_userEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Sa_invite100013_userEO MapDataReader(IDataReader reader)
		{
		    Sa_invite100013_userEO ret = new Sa_invite100013_userEO();
			ret.PUserID = reader.ToString("PUserID");
			ret.OriginalPUserID = ret.PUserID;
			ret.POperatorId = reader.ToString("POperatorId");
			ret.UserID = reader.ToString("UserID");
			ret.OriginalUserID = ret.UserID;
			ret.UOperatorId = reader.ToString("UOperatorId");
			ret.IsMeetPayLimit = reader.ToBoolean("IsMeetPayLimit");
			ret.UserTotalPay = reader.ToInt64("UserTotalPay");
			ret.IsMeetBetLimit = reader.ToBoolean("IsMeetBetLimit");
			ret.UserTotalBet = reader.ToInt64("UserTotalBet");
			ret.RecDate = reader.ToDateTime("RecDate");
			ret.UpdateTime = reader.ToDateTime("UpdateTime");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 好友邀请分享用户关系表
	/// 【表 sa_invite100013_user 的操作类】
	/// </summary>
	[Obsolete]
	public class Sa_invite100013_userMO : MySqlTableMO<Sa_invite100013_userEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`sa_invite100013_user`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Sa_invite100013_userMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Sa_invite100013_userMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Sa_invite100013_userMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Sa_invite100013_userEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Sa_invite100013_userEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Sa_invite100013_userEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`PUserID`, `POperatorId`, `UserID`, `UOperatorId`, `IsMeetPayLimit`, `UserTotalPay`, `IsMeetBetLimit`, `UserTotalBet`, `RecDate`, `UpdateTime`) VALUE (@PUserID, @POperatorId, @UserID, @UOperatorId, @IsMeetPayLimit, @UserTotalPay, @IsMeetBetLimit, @UserTotalBet, @RecDate, @UpdateTime);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PUserID", item.PUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@POperatorId", item.POperatorId, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UOperatorId", item.UOperatorId, MySqlDbType.VarChar),
				Database.CreateInParameter("@IsMeetPayLimit", item.IsMeetPayLimit, MySqlDbType.Byte),
				Database.CreateInParameter("@UserTotalPay", item.UserTotalPay, MySqlDbType.Int64),
				Database.CreateInParameter("@IsMeetBetLimit", item.IsMeetBetLimit, MySqlDbType.Byte),
				Database.CreateInParameter("@UserTotalBet", item.UserTotalBet, MySqlDbType.Int64),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@UpdateTime", item.UpdateTime, MySqlDbType.DateTime),
			};
		}
		public int AddByBatch(IEnumerable<Sa_invite100013_userEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Sa_invite100013_userEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sa_invite100013_userEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`PUserID`, `POperatorId`, `UserID`, `UOperatorId`, `IsMeetPayLimit`, `UserTotalPay`, `IsMeetBetLimit`, `UserTotalBet`, `RecDate`, `UpdateTime`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.PUserID}','{item.POperatorId}','{item.UserID}','{item.UOperatorId}',{item.IsMeetPayLimit},{item.UserTotalPay},{item.IsMeetBetLimit},{item.UserTotalBet},'{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}','{item.UpdateTime.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
		/// /// <param name = "pUserID">邀请人用户编码</param>
		/// /// <param name = "userID">被邀请人用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string pUserID, string userID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(pUserID, userID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string pUserID, string userID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(pUserID, userID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string pUserID, string userID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `PUserID` = @PUserID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Sa_invite100013_userEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.PUserID, item.UserID, tm_);
		}
		public async Task<int> RemoveAsync(Sa_invite100013_userEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.PUserID, item.UserID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByPUserID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "pUserID">邀请人用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPUserID(string pUserID, TransactionManager tm_ = null)
		{
			RepairRemoveByPUserIDData(pUserID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPUserIDAsync(string pUserID, TransactionManager tm_ = null)
		{
			RepairRemoveByPUserIDData(pUserID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByPUserIDData(string pUserID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `PUserID` = @PUserID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByPUserID
		#region RemoveByPOperatorId
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "pOperatorId">邀请人运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPOperatorId(string pOperatorId, TransactionManager tm_ = null)
		{
			RepairRemoveByPOperatorIdData(pOperatorId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPOperatorIdAsync(string pOperatorId, TransactionManager tm_ = null)
		{
			RepairRemoveByPOperatorIdData(pOperatorId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByPOperatorIdData(string pOperatorId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `POperatorId` = @POperatorId";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@POperatorId", pOperatorId, MySqlDbType.VarChar));
		}
		#endregion // RemoveByPOperatorId
		#region RemoveByUserID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "userID">被邀请人用户编码</param>
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
		#region RemoveByUOperatorId
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "uOperatorId">被邀请人运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByUOperatorId(string uOperatorId, TransactionManager tm_ = null)
		{
			RepairRemoveByUOperatorIdData(uOperatorId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByUOperatorIdAsync(string uOperatorId, TransactionManager tm_ = null)
		{
			RepairRemoveByUOperatorIdData(uOperatorId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByUOperatorIdData(string uOperatorId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `UOperatorId` = @UOperatorId";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UOperatorId", uOperatorId, MySqlDbType.VarChar));
		}
		#endregion // RemoveByUOperatorId
		#region RemoveByIsMeetPayLimit
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "isMeetPayLimit">是否达到充值要求</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByIsMeetPayLimit(bool isMeetPayLimit, TransactionManager tm_ = null)
		{
			RepairRemoveByIsMeetPayLimitData(isMeetPayLimit, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByIsMeetPayLimitAsync(bool isMeetPayLimit, TransactionManager tm_ = null)
		{
			RepairRemoveByIsMeetPayLimitData(isMeetPayLimit, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByIsMeetPayLimitData(bool isMeetPayLimit, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `IsMeetPayLimit` = @IsMeetPayLimit";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsMeetPayLimit", isMeetPayLimit, MySqlDbType.Byte));
		}
		#endregion // RemoveByIsMeetPayLimit
		#region RemoveByUserTotalPay
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "userTotalPay">被邀请人累计充值</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByUserTotalPay(long userTotalPay, TransactionManager tm_ = null)
		{
			RepairRemoveByUserTotalPayData(userTotalPay, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByUserTotalPayAsync(long userTotalPay, TransactionManager tm_ = null)
		{
			RepairRemoveByUserTotalPayData(userTotalPay, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByUserTotalPayData(long userTotalPay, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `UserTotalPay` = @UserTotalPay";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserTotalPay", userTotalPay, MySqlDbType.Int64));
		}
		#endregion // RemoveByUserTotalPay
		#region RemoveByIsMeetBetLimit
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "isMeetBetLimit">是否达到下注要求</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByIsMeetBetLimit(bool isMeetBetLimit, TransactionManager tm_ = null)
		{
			RepairRemoveByIsMeetBetLimitData(isMeetBetLimit, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByIsMeetBetLimitAsync(bool isMeetBetLimit, TransactionManager tm_ = null)
		{
			RepairRemoveByIsMeetBetLimitData(isMeetBetLimit, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByIsMeetBetLimitData(bool isMeetBetLimit, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `IsMeetBetLimit` = @IsMeetBetLimit";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsMeetBetLimit", isMeetBetLimit, MySqlDbType.Byte));
		}
		#endregion // RemoveByIsMeetBetLimit
		#region RemoveByUserTotalBet
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "userTotalBet">被邀请人累计下注金额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByUserTotalBet(long userTotalBet, TransactionManager tm_ = null)
		{
			RepairRemoveByUserTotalBetData(userTotalBet, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByUserTotalBetAsync(long userTotalBet, TransactionManager tm_ = null)
		{
			RepairRemoveByUserTotalBetData(userTotalBet, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByUserTotalBetData(long userTotalBet, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `UserTotalBet` = @UserTotalBet";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserTotalBet", userTotalBet, MySqlDbType.Int64));
		}
		#endregion // RemoveByUserTotalBet
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
		#region RemoveByUpdateTime
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "updateTime">更新时间</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByUpdateTime(DateTime updateTime, TransactionManager tm_ = null)
		{
			RepairRemoveByUpdateTimeData(updateTime, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByUpdateTimeAsync(DateTime updateTime, TransactionManager tm_ = null)
		{
			RepairRemoveByUpdateTimeData(updateTime, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByUpdateTimeData(DateTime updateTime, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `UpdateTime` = @UpdateTime";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UpdateTime", updateTime, MySqlDbType.DateTime));
		}
		#endregion // RemoveByUpdateTime
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
		public int Put(Sa_invite100013_userEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Sa_invite100013_userEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Sa_invite100013_userEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `PUserID` = @PUserID, `POperatorId` = @POperatorId, `UserID` = @UserID, `UOperatorId` = @UOperatorId, `IsMeetPayLimit` = @IsMeetPayLimit, `UserTotalPay` = @UserTotalPay, `IsMeetBetLimit` = @IsMeetBetLimit, `UserTotalBet` = @UserTotalBet WHERE `PUserID` = @PUserID_Original AND `UserID` = @UserID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PUserID", item.PUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@POperatorId", item.POperatorId, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UOperatorId", item.UOperatorId, MySqlDbType.VarChar),
				Database.CreateInParameter("@IsMeetPayLimit", item.IsMeetPayLimit, MySqlDbType.Byte),
				Database.CreateInParameter("@UserTotalPay", item.UserTotalPay, MySqlDbType.Int64),
				Database.CreateInParameter("@IsMeetBetLimit", item.IsMeetBetLimit, MySqlDbType.Byte),
				Database.CreateInParameter("@UserTotalBet", item.UserTotalBet, MySqlDbType.Int64),
				Database.CreateInParameter("@PUserID_Original", item.HasOriginal ? item.OriginalPUserID : item.PUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID_Original", item.HasOriginal ? item.OriginalUserID : item.UserID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Sa_invite100013_userEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Sa_invite100013_userEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "pUserID">邀请人用户编码</param>
		/// /// <param name = "userID">被邀请人用户编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string pUserID, string userID, string set_, params object[] values_)
		{
			return Put(set_, "`PUserID` = @PUserID AND `UserID` = @UserID", ConcatValues(values_, pUserID, userID));
		}
		public async Task<int> PutByPKAsync(string pUserID, string userID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`PUserID` = @PUserID AND `UserID` = @UserID", ConcatValues(values_, pUserID, userID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "pUserID">邀请人用户编码</param>
		/// /// <param name = "userID">被邀请人用户编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string pUserID, string userID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`PUserID` = @PUserID AND `UserID` = @UserID", tm_, ConcatValues(values_, pUserID, userID));
		}
		public async Task<int> PutByPKAsync(string pUserID, string userID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`PUserID` = @PUserID AND `UserID` = @UserID", tm_, ConcatValues(values_, pUserID, userID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "pUserID">邀请人用户编码</param>
		/// /// <param name = "userID">被邀请人用户编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string pUserID, string userID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`PUserID` = @PUserID AND `UserID` = @UserID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string pUserID, string userID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`PUserID` = @PUserID AND `UserID` = @UserID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutPUserID
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "pUserID">邀请人用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPUserID(string pUserID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PUserID` = @PUserID";
			var parameter_ = Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutPUserIDAsync(string pUserID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PUserID` = @PUserID";
			var parameter_ = Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutPUserID
		#region PutPOperatorId
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "pUserID">邀请人用户编码</param>
		/// /// <param name = "userID">被邀请人用户编码</param>
		/// /// <param name = "pOperatorId">邀请人运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPOperatorIdByPK(string pUserID, string userID, string pOperatorId, TransactionManager tm_ = null)
		{
			RepairPutPOperatorIdByPKData(pUserID, userID, pOperatorId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutPOperatorIdByPKAsync(string pUserID, string userID, string pOperatorId, TransactionManager tm_ = null)
		{
			RepairPutPOperatorIdByPKData(pUserID, userID, pOperatorId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutPOperatorIdByPKData(string pUserID, string userID, string pOperatorId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `POperatorId` = @POperatorId  WHERE `PUserID` = @PUserID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@POperatorId", pOperatorId, MySqlDbType.VarChar),
				Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "pOperatorId">邀请人运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPOperatorId(string pOperatorId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `POperatorId` = @POperatorId";
			var parameter_ = Database.CreateInParameter("@POperatorId", pOperatorId, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutPOperatorIdAsync(string pOperatorId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `POperatorId` = @POperatorId";
			var parameter_ = Database.CreateInParameter("@POperatorId", pOperatorId, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutPOperatorId
		#region PutUserID
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "userID">被邀请人用户编码</param>
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
		#region PutUOperatorId
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "pUserID">邀请人用户编码</param>
		/// /// <param name = "userID">被邀请人用户编码</param>
		/// /// <param name = "uOperatorId">被邀请人运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUOperatorIdByPK(string pUserID, string userID, string uOperatorId, TransactionManager tm_ = null)
		{
			RepairPutUOperatorIdByPKData(pUserID, userID, uOperatorId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutUOperatorIdByPKAsync(string pUserID, string userID, string uOperatorId, TransactionManager tm_ = null)
		{
			RepairPutUOperatorIdByPKData(pUserID, userID, uOperatorId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutUOperatorIdByPKData(string pUserID, string userID, string uOperatorId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UOperatorId` = @UOperatorId  WHERE `PUserID` = @PUserID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UOperatorId", uOperatorId, MySqlDbType.VarChar),
				Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "uOperatorId">被邀请人运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUOperatorId(string uOperatorId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UOperatorId` = @UOperatorId";
			var parameter_ = Database.CreateInParameter("@UOperatorId", uOperatorId, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutUOperatorIdAsync(string uOperatorId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UOperatorId` = @UOperatorId";
			var parameter_ = Database.CreateInParameter("@UOperatorId", uOperatorId, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutUOperatorId
		#region PutIsMeetPayLimit
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "pUserID">邀请人用户编码</param>
		/// /// <param name = "userID">被邀请人用户编码</param>
		/// /// <param name = "isMeetPayLimit">是否达到充值要求</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsMeetPayLimitByPK(string pUserID, string userID, bool isMeetPayLimit, TransactionManager tm_ = null)
		{
			RepairPutIsMeetPayLimitByPKData(pUserID, userID, isMeetPayLimit, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutIsMeetPayLimitByPKAsync(string pUserID, string userID, bool isMeetPayLimit, TransactionManager tm_ = null)
		{
			RepairPutIsMeetPayLimitByPKData(pUserID, userID, isMeetPayLimit, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutIsMeetPayLimitByPKData(string pUserID, string userID, bool isMeetPayLimit, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `IsMeetPayLimit` = @IsMeetPayLimit  WHERE `PUserID` = @PUserID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@IsMeetPayLimit", isMeetPayLimit, MySqlDbType.Byte),
				Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "isMeetPayLimit">是否达到充值要求</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsMeetPayLimit(bool isMeetPayLimit, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsMeetPayLimit` = @IsMeetPayLimit";
			var parameter_ = Database.CreateInParameter("@IsMeetPayLimit", isMeetPayLimit, MySqlDbType.Byte);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutIsMeetPayLimitAsync(bool isMeetPayLimit, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsMeetPayLimit` = @IsMeetPayLimit";
			var parameter_ = Database.CreateInParameter("@IsMeetPayLimit", isMeetPayLimit, MySqlDbType.Byte);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutIsMeetPayLimit
		#region PutUserTotalPay
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "pUserID">邀请人用户编码</param>
		/// /// <param name = "userID">被邀请人用户编码</param>
		/// /// <param name = "userTotalPay">被邀请人累计充值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserTotalPayByPK(string pUserID, string userID, long userTotalPay, TransactionManager tm_ = null)
		{
			RepairPutUserTotalPayByPKData(pUserID, userID, userTotalPay, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutUserTotalPayByPKAsync(string pUserID, string userID, long userTotalPay, TransactionManager tm_ = null)
		{
			RepairPutUserTotalPayByPKData(pUserID, userID, userTotalPay, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutUserTotalPayByPKData(string pUserID, string userID, long userTotalPay, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UserTotalPay` = @UserTotalPay  WHERE `PUserID` = @PUserID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserTotalPay", userTotalPay, MySqlDbType.Int64),
				Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "userTotalPay">被邀请人累计充值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserTotalPay(long userTotalPay, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserTotalPay` = @UserTotalPay";
			var parameter_ = Database.CreateInParameter("@UserTotalPay", userTotalPay, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutUserTotalPayAsync(long userTotalPay, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserTotalPay` = @UserTotalPay";
			var parameter_ = Database.CreateInParameter("@UserTotalPay", userTotalPay, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutUserTotalPay
		#region PutIsMeetBetLimit
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "pUserID">邀请人用户编码</param>
		/// /// <param name = "userID">被邀请人用户编码</param>
		/// /// <param name = "isMeetBetLimit">是否达到下注要求</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsMeetBetLimitByPK(string pUserID, string userID, bool isMeetBetLimit, TransactionManager tm_ = null)
		{
			RepairPutIsMeetBetLimitByPKData(pUserID, userID, isMeetBetLimit, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutIsMeetBetLimitByPKAsync(string pUserID, string userID, bool isMeetBetLimit, TransactionManager tm_ = null)
		{
			RepairPutIsMeetBetLimitByPKData(pUserID, userID, isMeetBetLimit, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutIsMeetBetLimitByPKData(string pUserID, string userID, bool isMeetBetLimit, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `IsMeetBetLimit` = @IsMeetBetLimit  WHERE `PUserID` = @PUserID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@IsMeetBetLimit", isMeetBetLimit, MySqlDbType.Byte),
				Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "isMeetBetLimit">是否达到下注要求</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsMeetBetLimit(bool isMeetBetLimit, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsMeetBetLimit` = @IsMeetBetLimit";
			var parameter_ = Database.CreateInParameter("@IsMeetBetLimit", isMeetBetLimit, MySqlDbType.Byte);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutIsMeetBetLimitAsync(bool isMeetBetLimit, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsMeetBetLimit` = @IsMeetBetLimit";
			var parameter_ = Database.CreateInParameter("@IsMeetBetLimit", isMeetBetLimit, MySqlDbType.Byte);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutIsMeetBetLimit
		#region PutUserTotalBet
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "pUserID">邀请人用户编码</param>
		/// /// <param name = "userID">被邀请人用户编码</param>
		/// /// <param name = "userTotalBet">被邀请人累计下注金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserTotalBetByPK(string pUserID, string userID, long userTotalBet, TransactionManager tm_ = null)
		{
			RepairPutUserTotalBetByPKData(pUserID, userID, userTotalBet, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutUserTotalBetByPKAsync(string pUserID, string userID, long userTotalBet, TransactionManager tm_ = null)
		{
			RepairPutUserTotalBetByPKData(pUserID, userID, userTotalBet, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutUserTotalBetByPKData(string pUserID, string userID, long userTotalBet, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UserTotalBet` = @UserTotalBet  WHERE `PUserID` = @PUserID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserTotalBet", userTotalBet, MySqlDbType.Int64),
				Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "userTotalBet">被邀请人累计下注金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserTotalBet(long userTotalBet, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserTotalBet` = @UserTotalBet";
			var parameter_ = Database.CreateInParameter("@UserTotalBet", userTotalBet, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutUserTotalBetAsync(long userTotalBet, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserTotalBet` = @UserTotalBet";
			var parameter_ = Database.CreateInParameter("@UserTotalBet", userTotalBet, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutUserTotalBet
		#region PutRecDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "pUserID">邀请人用户编码</param>
		/// /// <param name = "userID">被邀请人用户编码</param>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(string pUserID, string userID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(pUserID, userID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(string pUserID, string userID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(pUserID, userID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(string pUserID, string userID, DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `PUserID` = @PUserID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar),
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
		#region PutUpdateTime
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "pUserID">邀请人用户编码</param>
		/// /// <param name = "userID">被邀请人用户编码</param>
		/// /// <param name = "updateTime">更新时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUpdateTimeByPK(string pUserID, string userID, DateTime updateTime, TransactionManager tm_ = null)
		{
			RepairPutUpdateTimeByPKData(pUserID, userID, updateTime, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutUpdateTimeByPKAsync(string pUserID, string userID, DateTime updateTime, TransactionManager tm_ = null)
		{
			RepairPutUpdateTimeByPKData(pUserID, userID, updateTime, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutUpdateTimeByPKData(string pUserID, string userID, DateTime updateTime, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UpdateTime` = @UpdateTime  WHERE `PUserID` = @PUserID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UpdateTime", updateTime, MySqlDbType.DateTime),
				Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "updateTime">更新时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUpdateTime(DateTime updateTime, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UpdateTime` = @UpdateTime";
			var parameter_ = Database.CreateInParameter("@UpdateTime", updateTime, MySqlDbType.DateTime);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutUpdateTimeAsync(DateTime updateTime, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UpdateTime` = @UpdateTime";
			var parameter_ = Database.CreateInParameter("@UpdateTime", updateTime, MySqlDbType.DateTime);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutUpdateTime
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Sa_invite100013_userEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.PUserID, item.UserID) == null)
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
		public async Task<bool> SetAsync(Sa_invite100013_userEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.PUserID, item.UserID) == null)
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
		/// /// <param name = "pUserID">邀请人用户编码</param>
		/// /// <param name = "userID">被邀请人用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Sa_invite100013_userEO GetByPK(string pUserID, string userID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(pUserID, userID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sa_invite100013_userEO.MapDataReader);
		}
		public async Task<Sa_invite100013_userEO> GetByPKAsync(string pUserID, string userID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(pUserID, userID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sa_invite100013_userEO.MapDataReader);
		}
		private void RepairGetByPKData(string pUserID, string userID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`PUserID` = @PUserID AND `UserID` = @UserID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 PUserID（字段）
		/// </summary>
		/// /// <param name = "pUserID">邀请人用户编码</param>
		/// /// <param name = "userID">被邀请人用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetPUserIDByPK(string pUserID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`PUserID`", "`PUserID` = @PUserID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<string> GetPUserIDByPKAsync(string pUserID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`PUserID`", "`PUserID` = @PUserID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 POperatorId（字段）
		/// </summary>
		/// /// <param name = "pUserID">邀请人用户编码</param>
		/// /// <param name = "userID">被邀请人用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetPOperatorIdByPK(string pUserID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`POperatorId`", "`PUserID` = @PUserID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<string> GetPOperatorIdByPKAsync(string pUserID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`POperatorId`", "`PUserID` = @PUserID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 UserID（字段）
		/// </summary>
		/// /// <param name = "pUserID">邀请人用户编码</param>
		/// /// <param name = "userID">被邀请人用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetUserIDByPK(string pUserID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`UserID`", "`PUserID` = @PUserID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<string> GetUserIDByPKAsync(string pUserID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`UserID`", "`PUserID` = @PUserID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 UOperatorId（字段）
		/// </summary>
		/// /// <param name = "pUserID">邀请人用户编码</param>
		/// /// <param name = "userID">被邀请人用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetUOperatorIdByPK(string pUserID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`UOperatorId`", "`PUserID` = @PUserID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<string> GetUOperatorIdByPKAsync(string pUserID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`UOperatorId`", "`PUserID` = @PUserID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 IsMeetPayLimit（字段）
		/// </summary>
		/// /// <param name = "pUserID">邀请人用户编码</param>
		/// /// <param name = "userID">被邀请人用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public bool GetIsMeetPayLimitByPK(string pUserID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (bool)GetScalar("`IsMeetPayLimit`", "`PUserID` = @PUserID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<bool> GetIsMeetPayLimitByPKAsync(string pUserID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (bool)await GetScalarAsync("`IsMeetPayLimit`", "`PUserID` = @PUserID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 UserTotalPay（字段）
		/// </summary>
		/// /// <param name = "pUserID">邀请人用户编码</param>
		/// /// <param name = "userID">被邀请人用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetUserTotalPayByPK(string pUserID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`UserTotalPay`", "`PUserID` = @PUserID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetUserTotalPayByPKAsync(string pUserID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`UserTotalPay`", "`PUserID` = @PUserID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 IsMeetBetLimit（字段）
		/// </summary>
		/// /// <param name = "pUserID">邀请人用户编码</param>
		/// /// <param name = "userID">被邀请人用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public bool GetIsMeetBetLimitByPK(string pUserID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (bool)GetScalar("`IsMeetBetLimit`", "`PUserID` = @PUserID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<bool> GetIsMeetBetLimitByPKAsync(string pUserID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (bool)await GetScalarAsync("`IsMeetBetLimit`", "`PUserID` = @PUserID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 UserTotalBet（字段）
		/// </summary>
		/// /// <param name = "pUserID">邀请人用户编码</param>
		/// /// <param name = "userID">被邀请人用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetUserTotalBetByPK(string pUserID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`UserTotalBet`", "`PUserID` = @PUserID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetUserTotalBetByPKAsync(string pUserID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`UserTotalBet`", "`PUserID` = @PUserID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "pUserID">邀请人用户编码</param>
		/// /// <param name = "userID">被邀请人用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetRecDateByPK(string pUserID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`RecDate`", "`PUserID` = @PUserID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<DateTime> GetRecDateByPKAsync(string pUserID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`RecDate`", "`PUserID` = @PUserID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 UpdateTime（字段）
		/// </summary>
		/// /// <param name = "pUserID">邀请人用户编码</param>
		/// /// <param name = "userID">被邀请人用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetUpdateTimeByPK(string pUserID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`UpdateTime`", "`PUserID` = @PUserID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<DateTime> GetUpdateTimeByPKAsync(string pUserID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`UpdateTime`", "`PUserID` = @PUserID AND `UserID` = @UserID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByPUserID
		
		/// <summary>
		/// 按 PUserID（字段） 查询
		/// </summary>
		/// /// <param name = "pUserID">邀请人用户编码</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByPUserID(string pUserID)
		{
			return GetByPUserID(pUserID, 0, string.Empty, null);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByPUserIDAsync(string pUserID)
		{
			return await GetByPUserIDAsync(pUserID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PUserID（字段） 查询
		/// </summary>
		/// /// <param name = "pUserID">邀请人用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByPUserID(string pUserID, TransactionManager tm_)
		{
			return GetByPUserID(pUserID, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByPUserIDAsync(string pUserID, TransactionManager tm_)
		{
			return await GetByPUserIDAsync(pUserID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PUserID（字段） 查询
		/// </summary>
		/// /// <param name = "pUserID">邀请人用户编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByPUserID(string pUserID, int top_)
		{
			return GetByPUserID(pUserID, top_, string.Empty, null);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByPUserIDAsync(string pUserID, int top_)
		{
			return await GetByPUserIDAsync(pUserID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PUserID（字段） 查询
		/// </summary>
		/// /// <param name = "pUserID">邀请人用户编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByPUserID(string pUserID, int top_, TransactionManager tm_)
		{
			return GetByPUserID(pUserID, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByPUserIDAsync(string pUserID, int top_, TransactionManager tm_)
		{
			return await GetByPUserIDAsync(pUserID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PUserID（字段） 查询
		/// </summary>
		/// /// <param name = "pUserID">邀请人用户编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByPUserID(string pUserID, string sort_)
		{
			return GetByPUserID(pUserID, 0, sort_, null);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByPUserIDAsync(string pUserID, string sort_)
		{
			return await GetByPUserIDAsync(pUserID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PUserID（字段） 查询
		/// </summary>
		/// /// <param name = "pUserID">邀请人用户编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByPUserID(string pUserID, string sort_, TransactionManager tm_)
		{
			return GetByPUserID(pUserID, 0, sort_, tm_);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByPUserIDAsync(string pUserID, string sort_, TransactionManager tm_)
		{
			return await GetByPUserIDAsync(pUserID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PUserID（字段） 查询
		/// </summary>
		/// /// <param name = "pUserID">邀请人用户编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByPUserID(string pUserID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PUserID` = @PUserID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_invite100013_userEO.MapDataReader);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByPUserIDAsync(string pUserID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PUserID` = @PUserID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_invite100013_userEO.MapDataReader);
		}
		#endregion // GetByPUserID
		#region GetByPOperatorId
		
		/// <summary>
		/// 按 POperatorId（字段） 查询
		/// </summary>
		/// /// <param name = "pOperatorId">邀请人运营商编码</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByPOperatorId(string pOperatorId)
		{
			return GetByPOperatorId(pOperatorId, 0, string.Empty, null);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByPOperatorIdAsync(string pOperatorId)
		{
			return await GetByPOperatorIdAsync(pOperatorId, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 POperatorId（字段） 查询
		/// </summary>
		/// /// <param name = "pOperatorId">邀请人运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByPOperatorId(string pOperatorId, TransactionManager tm_)
		{
			return GetByPOperatorId(pOperatorId, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByPOperatorIdAsync(string pOperatorId, TransactionManager tm_)
		{
			return await GetByPOperatorIdAsync(pOperatorId, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 POperatorId（字段） 查询
		/// </summary>
		/// /// <param name = "pOperatorId">邀请人运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByPOperatorId(string pOperatorId, int top_)
		{
			return GetByPOperatorId(pOperatorId, top_, string.Empty, null);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByPOperatorIdAsync(string pOperatorId, int top_)
		{
			return await GetByPOperatorIdAsync(pOperatorId, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 POperatorId（字段） 查询
		/// </summary>
		/// /// <param name = "pOperatorId">邀请人运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByPOperatorId(string pOperatorId, int top_, TransactionManager tm_)
		{
			return GetByPOperatorId(pOperatorId, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByPOperatorIdAsync(string pOperatorId, int top_, TransactionManager tm_)
		{
			return await GetByPOperatorIdAsync(pOperatorId, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 POperatorId（字段） 查询
		/// </summary>
		/// /// <param name = "pOperatorId">邀请人运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByPOperatorId(string pOperatorId, string sort_)
		{
			return GetByPOperatorId(pOperatorId, 0, sort_, null);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByPOperatorIdAsync(string pOperatorId, string sort_)
		{
			return await GetByPOperatorIdAsync(pOperatorId, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 POperatorId（字段） 查询
		/// </summary>
		/// /// <param name = "pOperatorId">邀请人运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByPOperatorId(string pOperatorId, string sort_, TransactionManager tm_)
		{
			return GetByPOperatorId(pOperatorId, 0, sort_, tm_);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByPOperatorIdAsync(string pOperatorId, string sort_, TransactionManager tm_)
		{
			return await GetByPOperatorIdAsync(pOperatorId, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 POperatorId（字段） 查询
		/// </summary>
		/// /// <param name = "pOperatorId">邀请人运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByPOperatorId(string pOperatorId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`POperatorId` = @POperatorId", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@POperatorId", pOperatorId, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_invite100013_userEO.MapDataReader);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByPOperatorIdAsync(string pOperatorId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`POperatorId` = @POperatorId", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@POperatorId", pOperatorId, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_invite100013_userEO.MapDataReader);
		}
		#endregion // GetByPOperatorId
		#region GetByUserID
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">被邀请人用户编码</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByUserID(string userID)
		{
			return GetByUserID(userID, 0, string.Empty, null);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByUserIDAsync(string userID)
		{
			return await GetByUserIDAsync(userID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">被邀请人用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByUserID(string userID, TransactionManager tm_)
		{
			return GetByUserID(userID, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByUserIDAsync(string userID, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">被邀请人用户编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByUserID(string userID, int top_)
		{
			return GetByUserID(userID, top_, string.Empty, null);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByUserIDAsync(string userID, int top_)
		{
			return await GetByUserIDAsync(userID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">被邀请人用户编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByUserID(string userID, int top_, TransactionManager tm_)
		{
			return GetByUserID(userID, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByUserIDAsync(string userID, int top_, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">被邀请人用户编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByUserID(string userID, string sort_)
		{
			return GetByUserID(userID, 0, sort_, null);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByUserIDAsync(string userID, string sort_)
		{
			return await GetByUserIDAsync(userID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">被邀请人用户编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByUserID(string userID, string sort_, TransactionManager tm_)
		{
			return GetByUserID(userID, 0, sort_, tm_);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByUserIDAsync(string userID, string sort_, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">被邀请人用户编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByUserID(string userID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserID` = @UserID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_invite100013_userEO.MapDataReader);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByUserIDAsync(string userID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserID` = @UserID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_invite100013_userEO.MapDataReader);
		}
		#endregion // GetByUserID
		#region GetByUOperatorId
		
		/// <summary>
		/// 按 UOperatorId（字段） 查询
		/// </summary>
		/// /// <param name = "uOperatorId">被邀请人运营商编码</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByUOperatorId(string uOperatorId)
		{
			return GetByUOperatorId(uOperatorId, 0, string.Empty, null);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByUOperatorIdAsync(string uOperatorId)
		{
			return await GetByUOperatorIdAsync(uOperatorId, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UOperatorId（字段） 查询
		/// </summary>
		/// /// <param name = "uOperatorId">被邀请人运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByUOperatorId(string uOperatorId, TransactionManager tm_)
		{
			return GetByUOperatorId(uOperatorId, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByUOperatorIdAsync(string uOperatorId, TransactionManager tm_)
		{
			return await GetByUOperatorIdAsync(uOperatorId, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UOperatorId（字段） 查询
		/// </summary>
		/// /// <param name = "uOperatorId">被邀请人运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByUOperatorId(string uOperatorId, int top_)
		{
			return GetByUOperatorId(uOperatorId, top_, string.Empty, null);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByUOperatorIdAsync(string uOperatorId, int top_)
		{
			return await GetByUOperatorIdAsync(uOperatorId, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UOperatorId（字段） 查询
		/// </summary>
		/// /// <param name = "uOperatorId">被邀请人运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByUOperatorId(string uOperatorId, int top_, TransactionManager tm_)
		{
			return GetByUOperatorId(uOperatorId, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByUOperatorIdAsync(string uOperatorId, int top_, TransactionManager tm_)
		{
			return await GetByUOperatorIdAsync(uOperatorId, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UOperatorId（字段） 查询
		/// </summary>
		/// /// <param name = "uOperatorId">被邀请人运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByUOperatorId(string uOperatorId, string sort_)
		{
			return GetByUOperatorId(uOperatorId, 0, sort_, null);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByUOperatorIdAsync(string uOperatorId, string sort_)
		{
			return await GetByUOperatorIdAsync(uOperatorId, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 UOperatorId（字段） 查询
		/// </summary>
		/// /// <param name = "uOperatorId">被邀请人运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByUOperatorId(string uOperatorId, string sort_, TransactionManager tm_)
		{
			return GetByUOperatorId(uOperatorId, 0, sort_, tm_);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByUOperatorIdAsync(string uOperatorId, string sort_, TransactionManager tm_)
		{
			return await GetByUOperatorIdAsync(uOperatorId, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 UOperatorId（字段） 查询
		/// </summary>
		/// /// <param name = "uOperatorId">被邀请人运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByUOperatorId(string uOperatorId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UOperatorId` = @UOperatorId", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UOperatorId", uOperatorId, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_invite100013_userEO.MapDataReader);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByUOperatorIdAsync(string uOperatorId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UOperatorId` = @UOperatorId", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UOperatorId", uOperatorId, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_invite100013_userEO.MapDataReader);
		}
		#endregion // GetByUOperatorId
		#region GetByIsMeetPayLimit
		
		/// <summary>
		/// 按 IsMeetPayLimit（字段） 查询
		/// </summary>
		/// /// <param name = "isMeetPayLimit">是否达到充值要求</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByIsMeetPayLimit(bool isMeetPayLimit)
		{
			return GetByIsMeetPayLimit(isMeetPayLimit, 0, string.Empty, null);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByIsMeetPayLimitAsync(bool isMeetPayLimit)
		{
			return await GetByIsMeetPayLimitAsync(isMeetPayLimit, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsMeetPayLimit（字段） 查询
		/// </summary>
		/// /// <param name = "isMeetPayLimit">是否达到充值要求</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByIsMeetPayLimit(bool isMeetPayLimit, TransactionManager tm_)
		{
			return GetByIsMeetPayLimit(isMeetPayLimit, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByIsMeetPayLimitAsync(bool isMeetPayLimit, TransactionManager tm_)
		{
			return await GetByIsMeetPayLimitAsync(isMeetPayLimit, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsMeetPayLimit（字段） 查询
		/// </summary>
		/// /// <param name = "isMeetPayLimit">是否达到充值要求</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByIsMeetPayLimit(bool isMeetPayLimit, int top_)
		{
			return GetByIsMeetPayLimit(isMeetPayLimit, top_, string.Empty, null);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByIsMeetPayLimitAsync(bool isMeetPayLimit, int top_)
		{
			return await GetByIsMeetPayLimitAsync(isMeetPayLimit, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsMeetPayLimit（字段） 查询
		/// </summary>
		/// /// <param name = "isMeetPayLimit">是否达到充值要求</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByIsMeetPayLimit(bool isMeetPayLimit, int top_, TransactionManager tm_)
		{
			return GetByIsMeetPayLimit(isMeetPayLimit, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByIsMeetPayLimitAsync(bool isMeetPayLimit, int top_, TransactionManager tm_)
		{
			return await GetByIsMeetPayLimitAsync(isMeetPayLimit, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsMeetPayLimit（字段） 查询
		/// </summary>
		/// /// <param name = "isMeetPayLimit">是否达到充值要求</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByIsMeetPayLimit(bool isMeetPayLimit, string sort_)
		{
			return GetByIsMeetPayLimit(isMeetPayLimit, 0, sort_, null);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByIsMeetPayLimitAsync(bool isMeetPayLimit, string sort_)
		{
			return await GetByIsMeetPayLimitAsync(isMeetPayLimit, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 IsMeetPayLimit（字段） 查询
		/// </summary>
		/// /// <param name = "isMeetPayLimit">是否达到充值要求</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByIsMeetPayLimit(bool isMeetPayLimit, string sort_, TransactionManager tm_)
		{
			return GetByIsMeetPayLimit(isMeetPayLimit, 0, sort_, tm_);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByIsMeetPayLimitAsync(bool isMeetPayLimit, string sort_, TransactionManager tm_)
		{
			return await GetByIsMeetPayLimitAsync(isMeetPayLimit, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 IsMeetPayLimit（字段） 查询
		/// </summary>
		/// /// <param name = "isMeetPayLimit">是否达到充值要求</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByIsMeetPayLimit(bool isMeetPayLimit, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsMeetPayLimit` = @IsMeetPayLimit", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsMeetPayLimit", isMeetPayLimit, MySqlDbType.Byte));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_invite100013_userEO.MapDataReader);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByIsMeetPayLimitAsync(bool isMeetPayLimit, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsMeetPayLimit` = @IsMeetPayLimit", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsMeetPayLimit", isMeetPayLimit, MySqlDbType.Byte));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_invite100013_userEO.MapDataReader);
		}
		#endregion // GetByIsMeetPayLimit
		#region GetByUserTotalPay
		
		/// <summary>
		/// 按 UserTotalPay（字段） 查询
		/// </summary>
		/// /// <param name = "userTotalPay">被邀请人累计充值</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByUserTotalPay(long userTotalPay)
		{
			return GetByUserTotalPay(userTotalPay, 0, string.Empty, null);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByUserTotalPayAsync(long userTotalPay)
		{
			return await GetByUserTotalPayAsync(userTotalPay, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserTotalPay（字段） 查询
		/// </summary>
		/// /// <param name = "userTotalPay">被邀请人累计充值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByUserTotalPay(long userTotalPay, TransactionManager tm_)
		{
			return GetByUserTotalPay(userTotalPay, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByUserTotalPayAsync(long userTotalPay, TransactionManager tm_)
		{
			return await GetByUserTotalPayAsync(userTotalPay, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserTotalPay（字段） 查询
		/// </summary>
		/// /// <param name = "userTotalPay">被邀请人累计充值</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByUserTotalPay(long userTotalPay, int top_)
		{
			return GetByUserTotalPay(userTotalPay, top_, string.Empty, null);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByUserTotalPayAsync(long userTotalPay, int top_)
		{
			return await GetByUserTotalPayAsync(userTotalPay, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserTotalPay（字段） 查询
		/// </summary>
		/// /// <param name = "userTotalPay">被邀请人累计充值</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByUserTotalPay(long userTotalPay, int top_, TransactionManager tm_)
		{
			return GetByUserTotalPay(userTotalPay, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByUserTotalPayAsync(long userTotalPay, int top_, TransactionManager tm_)
		{
			return await GetByUserTotalPayAsync(userTotalPay, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserTotalPay（字段） 查询
		/// </summary>
		/// /// <param name = "userTotalPay">被邀请人累计充值</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByUserTotalPay(long userTotalPay, string sort_)
		{
			return GetByUserTotalPay(userTotalPay, 0, sort_, null);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByUserTotalPayAsync(long userTotalPay, string sort_)
		{
			return await GetByUserTotalPayAsync(userTotalPay, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 UserTotalPay（字段） 查询
		/// </summary>
		/// /// <param name = "userTotalPay">被邀请人累计充值</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByUserTotalPay(long userTotalPay, string sort_, TransactionManager tm_)
		{
			return GetByUserTotalPay(userTotalPay, 0, sort_, tm_);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByUserTotalPayAsync(long userTotalPay, string sort_, TransactionManager tm_)
		{
			return await GetByUserTotalPayAsync(userTotalPay, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 UserTotalPay（字段） 查询
		/// </summary>
		/// /// <param name = "userTotalPay">被邀请人累计充值</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByUserTotalPay(long userTotalPay, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserTotalPay` = @UserTotalPay", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserTotalPay", userTotalPay, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_invite100013_userEO.MapDataReader);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByUserTotalPayAsync(long userTotalPay, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserTotalPay` = @UserTotalPay", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserTotalPay", userTotalPay, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_invite100013_userEO.MapDataReader);
		}
		#endregion // GetByUserTotalPay
		#region GetByIsMeetBetLimit
		
		/// <summary>
		/// 按 IsMeetBetLimit（字段） 查询
		/// </summary>
		/// /// <param name = "isMeetBetLimit">是否达到下注要求</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByIsMeetBetLimit(bool isMeetBetLimit)
		{
			return GetByIsMeetBetLimit(isMeetBetLimit, 0, string.Empty, null);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByIsMeetBetLimitAsync(bool isMeetBetLimit)
		{
			return await GetByIsMeetBetLimitAsync(isMeetBetLimit, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsMeetBetLimit（字段） 查询
		/// </summary>
		/// /// <param name = "isMeetBetLimit">是否达到下注要求</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByIsMeetBetLimit(bool isMeetBetLimit, TransactionManager tm_)
		{
			return GetByIsMeetBetLimit(isMeetBetLimit, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByIsMeetBetLimitAsync(bool isMeetBetLimit, TransactionManager tm_)
		{
			return await GetByIsMeetBetLimitAsync(isMeetBetLimit, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsMeetBetLimit（字段） 查询
		/// </summary>
		/// /// <param name = "isMeetBetLimit">是否达到下注要求</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByIsMeetBetLimit(bool isMeetBetLimit, int top_)
		{
			return GetByIsMeetBetLimit(isMeetBetLimit, top_, string.Empty, null);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByIsMeetBetLimitAsync(bool isMeetBetLimit, int top_)
		{
			return await GetByIsMeetBetLimitAsync(isMeetBetLimit, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsMeetBetLimit（字段） 查询
		/// </summary>
		/// /// <param name = "isMeetBetLimit">是否达到下注要求</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByIsMeetBetLimit(bool isMeetBetLimit, int top_, TransactionManager tm_)
		{
			return GetByIsMeetBetLimit(isMeetBetLimit, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByIsMeetBetLimitAsync(bool isMeetBetLimit, int top_, TransactionManager tm_)
		{
			return await GetByIsMeetBetLimitAsync(isMeetBetLimit, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsMeetBetLimit（字段） 查询
		/// </summary>
		/// /// <param name = "isMeetBetLimit">是否达到下注要求</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByIsMeetBetLimit(bool isMeetBetLimit, string sort_)
		{
			return GetByIsMeetBetLimit(isMeetBetLimit, 0, sort_, null);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByIsMeetBetLimitAsync(bool isMeetBetLimit, string sort_)
		{
			return await GetByIsMeetBetLimitAsync(isMeetBetLimit, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 IsMeetBetLimit（字段） 查询
		/// </summary>
		/// /// <param name = "isMeetBetLimit">是否达到下注要求</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByIsMeetBetLimit(bool isMeetBetLimit, string sort_, TransactionManager tm_)
		{
			return GetByIsMeetBetLimit(isMeetBetLimit, 0, sort_, tm_);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByIsMeetBetLimitAsync(bool isMeetBetLimit, string sort_, TransactionManager tm_)
		{
			return await GetByIsMeetBetLimitAsync(isMeetBetLimit, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 IsMeetBetLimit（字段） 查询
		/// </summary>
		/// /// <param name = "isMeetBetLimit">是否达到下注要求</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByIsMeetBetLimit(bool isMeetBetLimit, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsMeetBetLimit` = @IsMeetBetLimit", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsMeetBetLimit", isMeetBetLimit, MySqlDbType.Byte));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_invite100013_userEO.MapDataReader);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByIsMeetBetLimitAsync(bool isMeetBetLimit, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsMeetBetLimit` = @IsMeetBetLimit", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsMeetBetLimit", isMeetBetLimit, MySqlDbType.Byte));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_invite100013_userEO.MapDataReader);
		}
		#endregion // GetByIsMeetBetLimit
		#region GetByUserTotalBet
		
		/// <summary>
		/// 按 UserTotalBet（字段） 查询
		/// </summary>
		/// /// <param name = "userTotalBet">被邀请人累计下注金额</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByUserTotalBet(long userTotalBet)
		{
			return GetByUserTotalBet(userTotalBet, 0, string.Empty, null);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByUserTotalBetAsync(long userTotalBet)
		{
			return await GetByUserTotalBetAsync(userTotalBet, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserTotalBet（字段） 查询
		/// </summary>
		/// /// <param name = "userTotalBet">被邀请人累计下注金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByUserTotalBet(long userTotalBet, TransactionManager tm_)
		{
			return GetByUserTotalBet(userTotalBet, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByUserTotalBetAsync(long userTotalBet, TransactionManager tm_)
		{
			return await GetByUserTotalBetAsync(userTotalBet, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserTotalBet（字段） 查询
		/// </summary>
		/// /// <param name = "userTotalBet">被邀请人累计下注金额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByUserTotalBet(long userTotalBet, int top_)
		{
			return GetByUserTotalBet(userTotalBet, top_, string.Empty, null);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByUserTotalBetAsync(long userTotalBet, int top_)
		{
			return await GetByUserTotalBetAsync(userTotalBet, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserTotalBet（字段） 查询
		/// </summary>
		/// /// <param name = "userTotalBet">被邀请人累计下注金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByUserTotalBet(long userTotalBet, int top_, TransactionManager tm_)
		{
			return GetByUserTotalBet(userTotalBet, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByUserTotalBetAsync(long userTotalBet, int top_, TransactionManager tm_)
		{
			return await GetByUserTotalBetAsync(userTotalBet, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserTotalBet（字段） 查询
		/// </summary>
		/// /// <param name = "userTotalBet">被邀请人累计下注金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByUserTotalBet(long userTotalBet, string sort_)
		{
			return GetByUserTotalBet(userTotalBet, 0, sort_, null);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByUserTotalBetAsync(long userTotalBet, string sort_)
		{
			return await GetByUserTotalBetAsync(userTotalBet, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 UserTotalBet（字段） 查询
		/// </summary>
		/// /// <param name = "userTotalBet">被邀请人累计下注金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByUserTotalBet(long userTotalBet, string sort_, TransactionManager tm_)
		{
			return GetByUserTotalBet(userTotalBet, 0, sort_, tm_);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByUserTotalBetAsync(long userTotalBet, string sort_, TransactionManager tm_)
		{
			return await GetByUserTotalBetAsync(userTotalBet, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 UserTotalBet（字段） 查询
		/// </summary>
		/// /// <param name = "userTotalBet">被邀请人累计下注金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByUserTotalBet(long userTotalBet, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserTotalBet` = @UserTotalBet", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserTotalBet", userTotalBet, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_invite100013_userEO.MapDataReader);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByUserTotalBetAsync(long userTotalBet, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserTotalBet` = @UserTotalBet", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserTotalBet", userTotalBet, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_invite100013_userEO.MapDataReader);
		}
		#endregion // GetByUserTotalBet
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByRecDateAsync(DateTime recDate, int top_)
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
		public List<Sa_invite100013_userEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByRecDateAsync(DateTime recDate, string sort_)
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
		public List<Sa_invite100013_userEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
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
		public List<Sa_invite100013_userEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_invite100013_userEO.MapDataReader);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_invite100013_userEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#region GetByUpdateTime
		
		/// <summary>
		/// 按 UpdateTime（字段） 查询
		/// </summary>
		/// /// <param name = "updateTime">更新时间</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByUpdateTime(DateTime updateTime)
		{
			return GetByUpdateTime(updateTime, 0, string.Empty, null);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByUpdateTimeAsync(DateTime updateTime)
		{
			return await GetByUpdateTimeAsync(updateTime, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UpdateTime（字段） 查询
		/// </summary>
		/// /// <param name = "updateTime">更新时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByUpdateTime(DateTime updateTime, TransactionManager tm_)
		{
			return GetByUpdateTime(updateTime, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByUpdateTimeAsync(DateTime updateTime, TransactionManager tm_)
		{
			return await GetByUpdateTimeAsync(updateTime, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UpdateTime（字段） 查询
		/// </summary>
		/// /// <param name = "updateTime">更新时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByUpdateTime(DateTime updateTime, int top_)
		{
			return GetByUpdateTime(updateTime, top_, string.Empty, null);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByUpdateTimeAsync(DateTime updateTime, int top_)
		{
			return await GetByUpdateTimeAsync(updateTime, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UpdateTime（字段） 查询
		/// </summary>
		/// /// <param name = "updateTime">更新时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByUpdateTime(DateTime updateTime, int top_, TransactionManager tm_)
		{
			return GetByUpdateTime(updateTime, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByUpdateTimeAsync(DateTime updateTime, int top_, TransactionManager tm_)
		{
			return await GetByUpdateTimeAsync(updateTime, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UpdateTime（字段） 查询
		/// </summary>
		/// /// <param name = "updateTime">更新时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByUpdateTime(DateTime updateTime, string sort_)
		{
			return GetByUpdateTime(updateTime, 0, sort_, null);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByUpdateTimeAsync(DateTime updateTime, string sort_)
		{
			return await GetByUpdateTimeAsync(updateTime, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 UpdateTime（字段） 查询
		/// </summary>
		/// /// <param name = "updateTime">更新时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByUpdateTime(DateTime updateTime, string sort_, TransactionManager tm_)
		{
			return GetByUpdateTime(updateTime, 0, sort_, tm_);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByUpdateTimeAsync(DateTime updateTime, string sort_, TransactionManager tm_)
		{
			return await GetByUpdateTimeAsync(updateTime, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 UpdateTime（字段） 查询
		/// </summary>
		/// /// <param name = "updateTime">更新时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_invite100013_userEO> GetByUpdateTime(DateTime updateTime, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UpdateTime` = @UpdateTime", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UpdateTime", updateTime, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_invite100013_userEO.MapDataReader);
		}
		public async Task<List<Sa_invite100013_userEO>> GetByUpdateTimeAsync(DateTime updateTime, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UpdateTime` = @UpdateTime", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UpdateTime", updateTime, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_invite100013_userEO.MapDataReader);
		}
		#endregion // GetByUpdateTime
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
