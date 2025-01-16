/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * AiUo代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/AiUo
 * 文档生成时间：2023-10-24 18: 04:53
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
	/// 用户所在应用的数据
	/// 【表 sc_user_app 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Sc_user_appEO : IRowMapper<Sc_user_appEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Sc_user_appEO()
		{
			this.GuideNum = 0;
			this.UserAppStatus = 0;
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
		
		private string _originalAppID;
		/// <summary>
		/// 【数据库中的原始主键 AppID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalAppID
		{
			get { return _originalAppID; }
			set { HasOriginal = true; _originalAppID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "UserID", UserID },  { "AppID", AppID }, };
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
		/// 应用编码
		/// 【主键 varchar(50)】
		/// </summary>
		[DataMember(Order = 2)]
		public string AppID { get; set; }
		/// <summary>
		/// 用户引导显示内容
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 3)]
		public int GuideNum { get; set; }
		/// <summary>
		/// 用户状态(0-未知1-正常2-异常）
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 4)]
		public int UserAppStatus { get; set; }
		/// <summary>
		/// 最后一次访问时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 5)]
		public DateTime? LastLoginDate { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Sc_user_appEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Sc_user_appEO MapDataReader(IDataReader reader)
		{
		    Sc_user_appEO ret = new Sc_user_appEO();
			ret.UserID = reader.ToString("UserID");
			ret.OriginalUserID = ret.UserID;
			ret.AppID = reader.ToString("AppID");
			ret.OriginalAppID = ret.AppID;
			ret.GuideNum = reader.ToInt32("GuideNum");
			ret.UserAppStatus = reader.ToInt32("UserAppStatus");
			ret.LastLoginDate = reader.ToDateTimeN("LastLoginDate");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 用户所在应用的数据
	/// 【表 sc_user_app 的操作类】
	/// </summary>
	[Obsolete]
	public class Sc_user_appMO : MySqlTableMO<Sc_user_appEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`sc_user_app`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Sc_user_appMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Sc_user_appMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Sc_user_appMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Sc_user_appEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Sc_user_appEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Sc_user_appEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`UserID`, `AppID`, `GuideNum`, `UserAppStatus`, `LastLoginDate`) VALUE (@UserID, @AppID, @GuideNum, @UserAppStatus, @LastLoginDate);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", item.AppID, MySqlDbType.VarChar),
				Database.CreateInParameter("@GuideNum", item.GuideNum, MySqlDbType.Int32),
				Database.CreateInParameter("@UserAppStatus", item.UserAppStatus, MySqlDbType.Int32),
				Database.CreateInParameter("@LastLoginDate", item.LastLoginDate.HasValue ? item.LastLoginDate.Value : (object)DBNull.Value, MySqlDbType.DateTime),
			};
		}
		public int AddByBatch(IEnumerable<Sc_user_appEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Sc_user_appEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sc_user_appEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`UserID`, `AppID`, `GuideNum`, `UserAppStatus`, `LastLoginDate`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.UserID}','{item.AppID}',{item.GuideNum},{item.UserAppStatus},'{item.LastLoginDate?.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string userID, string appID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(userID, appID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string userID, string appID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(userID, appID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string userID, string appID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `UserID` = @UserID AND `AppID` = @AppID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Sc_user_appEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.UserID, item.AppID, tm_);
		}
		public async Task<int> RemoveAsync(Sc_user_appEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.UserID, item.AppID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
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
		#region RemoveByAppID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByAppID(string appID, TransactionManager tm_ = null)
		{
			RepairRemoveByAppIDData(appID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByAppIDAsync(string appID, TransactionManager tm_ = null)
		{
			RepairRemoveByAppIDData(appID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByAppIDData(string appID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `AppID` = @AppID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByAppID
		#region RemoveByGuideNum
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "guideNum">用户引导显示内容</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByGuideNum(int guideNum, TransactionManager tm_ = null)
		{
			RepairRemoveByGuideNumData(guideNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByGuideNumAsync(int guideNum, TransactionManager tm_ = null)
		{
			RepairRemoveByGuideNumData(guideNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByGuideNumData(int guideNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `GuideNum` = @GuideNum";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@GuideNum", guideNum, MySqlDbType.Int32));
		}
		#endregion // RemoveByGuideNum
		#region RemoveByUserAppStatus
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "userAppStatus">用户状态(0-未知1-正常2-异常）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByUserAppStatus(int userAppStatus, TransactionManager tm_ = null)
		{
			RepairRemoveByUserAppStatusData(userAppStatus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByUserAppStatusAsync(int userAppStatus, TransactionManager tm_ = null)
		{
			RepairRemoveByUserAppStatusData(userAppStatus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByUserAppStatusData(int userAppStatus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `UserAppStatus` = @UserAppStatus";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserAppStatus", userAppStatus, MySqlDbType.Int32));
		}
		#endregion // RemoveByUserAppStatus
		#region RemoveByLastLoginDate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "lastLoginDate">最后一次访问时间</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByLastLoginDate(DateTime? lastLoginDate, TransactionManager tm_ = null)
		{
			RepairRemoveByLastLoginDateData(lastLoginDate.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByLastLoginDateAsync(DateTime? lastLoginDate, TransactionManager tm_ = null)
		{
			RepairRemoveByLastLoginDateData(lastLoginDate.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByLastLoginDateData(DateTime? lastLoginDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (lastLoginDate.HasValue ? "`LastLoginDate` = @LastLoginDate" : "`LastLoginDate` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (lastLoginDate.HasValue)
				paras_.Add(Database.CreateInParameter("@LastLoginDate", lastLoginDate.Value, MySqlDbType.DateTime));
		}
		#endregion // RemoveByLastLoginDate
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
		public int Put(Sc_user_appEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Sc_user_appEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Sc_user_appEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UserID` = @UserID, `AppID` = @AppID, `GuideNum` = @GuideNum, `UserAppStatus` = @UserAppStatus, `LastLoginDate` = @LastLoginDate WHERE `UserID` = @UserID_Original AND `AppID` = @AppID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", item.AppID, MySqlDbType.VarChar),
				Database.CreateInParameter("@GuideNum", item.GuideNum, MySqlDbType.Int32),
				Database.CreateInParameter("@UserAppStatus", item.UserAppStatus, MySqlDbType.Int32),
				Database.CreateInParameter("@LastLoginDate", item.LastLoginDate.HasValue ? item.LastLoginDate.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@UserID_Original", item.HasOriginal ? item.OriginalUserID : item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID_Original", item.HasOriginal ? item.OriginalAppID : item.AppID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Sc_user_appEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Sc_user_appEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string userID, string appID, string set_, params object[] values_)
		{
			return Put(set_, "`UserID` = @UserID AND `AppID` = @AppID", ConcatValues(values_, userID, appID));
		}
		public async Task<int> PutByPKAsync(string userID, string appID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`UserID` = @UserID AND `AppID` = @AppID", ConcatValues(values_, userID, appID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string userID, string appID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`UserID` = @UserID AND `AppID` = @AppID", tm_, ConcatValues(values_, userID, appID));
		}
		public async Task<int> PutByPKAsync(string userID, string appID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`UserID` = @UserID AND `AppID` = @AppID", tm_, ConcatValues(values_, userID, appID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string userID, string appID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`UserID` = @UserID AND `AppID` = @AppID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string userID, string appID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`UserID` = @UserID AND `AppID` = @AppID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
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
		#region PutAppID
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAppID(string appID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `AppID` = @AppID";
			var parameter_ = Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutAppIDAsync(string appID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `AppID` = @AppID";
			var parameter_ = Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutAppID
		#region PutGuideNum
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "guideNum">用户引导显示内容</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutGuideNumByPK(string userID, string appID, int guideNum, TransactionManager tm_ = null)
		{
			RepairPutGuideNumByPKData(userID, appID, guideNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutGuideNumByPKAsync(string userID, string appID, int guideNum, TransactionManager tm_ = null)
		{
			RepairPutGuideNumByPKData(userID, appID, guideNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutGuideNumByPKData(string userID, string appID, int guideNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `GuideNum` = @GuideNum  WHERE `UserID` = @UserID AND `AppID` = @AppID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@GuideNum", guideNum, MySqlDbType.Int32),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "guideNum">用户引导显示内容</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutGuideNum(int guideNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `GuideNum` = @GuideNum";
			var parameter_ = Database.CreateInParameter("@GuideNum", guideNum, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutGuideNumAsync(int guideNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `GuideNum` = @GuideNum";
			var parameter_ = Database.CreateInParameter("@GuideNum", guideNum, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutGuideNum
		#region PutUserAppStatus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "userAppStatus">用户状态(0-未知1-正常2-异常）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserAppStatusByPK(string userID, string appID, int userAppStatus, TransactionManager tm_ = null)
		{
			RepairPutUserAppStatusByPKData(userID, appID, userAppStatus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutUserAppStatusByPKAsync(string userID, string appID, int userAppStatus, TransactionManager tm_ = null)
		{
			RepairPutUserAppStatusByPKData(userID, appID, userAppStatus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutUserAppStatusByPKData(string userID, string appID, int userAppStatus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UserAppStatus` = @UserAppStatus  WHERE `UserID` = @UserID AND `AppID` = @AppID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserAppStatus", userAppStatus, MySqlDbType.Int32),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "userAppStatus">用户状态(0-未知1-正常2-异常）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserAppStatus(int userAppStatus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserAppStatus` = @UserAppStatus";
			var parameter_ = Database.CreateInParameter("@UserAppStatus", userAppStatus, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutUserAppStatusAsync(int userAppStatus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserAppStatus` = @UserAppStatus";
			var parameter_ = Database.CreateInParameter("@UserAppStatus", userAppStatus, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutUserAppStatus
		#region PutLastLoginDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "lastLoginDate">最后一次访问时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLastLoginDateByPK(string userID, string appID, DateTime? lastLoginDate, TransactionManager tm_ = null)
		{
			RepairPutLastLoginDateByPKData(userID, appID, lastLoginDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLastLoginDateByPKAsync(string userID, string appID, DateTime? lastLoginDate, TransactionManager tm_ = null)
		{
			RepairPutLastLoginDateByPKData(userID, appID, lastLoginDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLastLoginDateByPKData(string userID, string appID, DateTime? lastLoginDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `LastLoginDate` = @LastLoginDate  WHERE `UserID` = @UserID AND `AppID` = @AppID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LastLoginDate", lastLoginDate.HasValue ? lastLoginDate.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "lastLoginDate">最后一次访问时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLastLoginDate(DateTime? lastLoginDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LastLoginDate` = @LastLoginDate";
			var parameter_ = Database.CreateInParameter("@LastLoginDate", lastLoginDate.HasValue ? lastLoginDate.Value : (object)DBNull.Value, MySqlDbType.DateTime);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutLastLoginDateAsync(DateTime? lastLoginDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LastLoginDate` = @LastLoginDate";
			var parameter_ = Database.CreateInParameter("@LastLoginDate", lastLoginDate.HasValue ? lastLoginDate.Value : (object)DBNull.Value, MySqlDbType.DateTime);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutLastLoginDate
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Sc_user_appEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.UserID, item.AppID) == null)
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
		public async Task<bool> SetAsync(Sc_user_appEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.UserID, item.AppID) == null)
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
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Sc_user_appEO GetByPK(string userID, string appID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(userID, appID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sc_user_appEO.MapDataReader);
		}
		public async Task<Sc_user_appEO> GetByPKAsync(string userID, string appID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(userID, appID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sc_user_appEO.MapDataReader);
		}
		private void RepairGetByPKData(string userID, string appID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`UserID` = @UserID AND `AppID` = @AppID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 UserID（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetUserIDByPK(string userID, string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`UserID`", "`UserID` = @UserID AND `AppID` = @AppID", paras_, tm_);
		}
		public async Task<string> GetUserIDByPKAsync(string userID, string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`UserID`", "`UserID` = @UserID AND `AppID` = @AppID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 AppID（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetAppIDByPK(string userID, string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`AppID`", "`UserID` = @UserID AND `AppID` = @AppID", paras_, tm_);
		}
		public async Task<string> GetAppIDByPKAsync(string userID, string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`AppID`", "`UserID` = @UserID AND `AppID` = @AppID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 GuideNum（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetGuideNumByPK(string userID, string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`GuideNum`", "`UserID` = @UserID AND `AppID` = @AppID", paras_, tm_);
		}
		public async Task<int> GetGuideNumByPKAsync(string userID, string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`GuideNum`", "`UserID` = @UserID AND `AppID` = @AppID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 UserAppStatus（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetUserAppStatusByPK(string userID, string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`UserAppStatus`", "`UserID` = @UserID AND `AppID` = @AppID", paras_, tm_);
		}
		public async Task<int> GetUserAppStatusByPKAsync(string userID, string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`UserAppStatus`", "`UserID` = @UserID AND `AppID` = @AppID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 LastLoginDate（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime? GetLastLoginDateByPK(string userID, string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (DateTime?)GetScalar("`LastLoginDate`", "`UserID` = @UserID AND `AppID` = @AppID", paras_, tm_);
		}
		public async Task<DateTime?> GetLastLoginDateByPKAsync(string userID, string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (DateTime?)await GetScalarAsync("`LastLoginDate`", "`UserID` = @UserID AND `AppID` = @AppID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByUserID
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <return>实体对象集合</return>
		public List<Sc_user_appEO> GetByUserID(string userID)
		{
			return GetByUserID(userID, 0, string.Empty, null);
		}
		public async Task<List<Sc_user_appEO>> GetByUserIDAsync(string userID)
		{
			return await GetByUserIDAsync(userID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_user_appEO> GetByUserID(string userID, TransactionManager tm_)
		{
			return GetByUserID(userID, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_user_appEO>> GetByUserIDAsync(string userID, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_user_appEO> GetByUserID(string userID, int top_)
		{
			return GetByUserID(userID, top_, string.Empty, null);
		}
		public async Task<List<Sc_user_appEO>> GetByUserIDAsync(string userID, int top_)
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
		public List<Sc_user_appEO> GetByUserID(string userID, int top_, TransactionManager tm_)
		{
			return GetByUserID(userID, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_user_appEO>> GetByUserIDAsync(string userID, int top_, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_user_appEO> GetByUserID(string userID, string sort_)
		{
			return GetByUserID(userID, 0, sort_, null);
		}
		public async Task<List<Sc_user_appEO>> GetByUserIDAsync(string userID, string sort_)
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
		public List<Sc_user_appEO> GetByUserID(string userID, string sort_, TransactionManager tm_)
		{
			return GetByUserID(userID, 0, sort_, tm_);
		}
		public async Task<List<Sc_user_appEO>> GetByUserIDAsync(string userID, string sort_, TransactionManager tm_)
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
		public List<Sc_user_appEO> GetByUserID(string userID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserID` = @UserID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_user_appEO.MapDataReader);
		}
		public async Task<List<Sc_user_appEO>> GetByUserIDAsync(string userID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserID` = @UserID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_user_appEO.MapDataReader);
		}
		#endregion // GetByUserID
		#region GetByAppID
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <return>实体对象集合</return>
		public List<Sc_user_appEO> GetByAppID(string appID)
		{
			return GetByAppID(appID, 0, string.Empty, null);
		}
		public async Task<List<Sc_user_appEO>> GetByAppIDAsync(string appID)
		{
			return await GetByAppIDAsync(appID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_user_appEO> GetByAppID(string appID, TransactionManager tm_)
		{
			return GetByAppID(appID, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_user_appEO>> GetByAppIDAsync(string appID, TransactionManager tm_)
		{
			return await GetByAppIDAsync(appID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_user_appEO> GetByAppID(string appID, int top_)
		{
			return GetByAppID(appID, top_, string.Empty, null);
		}
		public async Task<List<Sc_user_appEO>> GetByAppIDAsync(string appID, int top_)
		{
			return await GetByAppIDAsync(appID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_user_appEO> GetByAppID(string appID, int top_, TransactionManager tm_)
		{
			return GetByAppID(appID, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_user_appEO>> GetByAppIDAsync(string appID, int top_, TransactionManager tm_)
		{
			return await GetByAppIDAsync(appID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_user_appEO> GetByAppID(string appID, string sort_)
		{
			return GetByAppID(appID, 0, sort_, null);
		}
		public async Task<List<Sc_user_appEO>> GetByAppIDAsync(string appID, string sort_)
		{
			return await GetByAppIDAsync(appID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_user_appEO> GetByAppID(string appID, string sort_, TransactionManager tm_)
		{
			return GetByAppID(appID, 0, sort_, tm_);
		}
		public async Task<List<Sc_user_appEO>> GetByAppIDAsync(string appID, string sort_, TransactionManager tm_)
		{
			return await GetByAppIDAsync(appID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_user_appEO> GetByAppID(string appID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`AppID` = @AppID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_user_appEO.MapDataReader);
		}
		public async Task<List<Sc_user_appEO>> GetByAppIDAsync(string appID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`AppID` = @AppID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_user_appEO.MapDataReader);
		}
		#endregion // GetByAppID
		#region GetByGuideNum
		
		/// <summary>
		/// 按 GuideNum（字段） 查询
		/// </summary>
		/// /// <param name = "guideNum">用户引导显示内容</param>
		/// <return>实体对象集合</return>
		public List<Sc_user_appEO> GetByGuideNum(int guideNum)
		{
			return GetByGuideNum(guideNum, 0, string.Empty, null);
		}
		public async Task<List<Sc_user_appEO>> GetByGuideNumAsync(int guideNum)
		{
			return await GetByGuideNumAsync(guideNum, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 GuideNum（字段） 查询
		/// </summary>
		/// /// <param name = "guideNum">用户引导显示内容</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_user_appEO> GetByGuideNum(int guideNum, TransactionManager tm_)
		{
			return GetByGuideNum(guideNum, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_user_appEO>> GetByGuideNumAsync(int guideNum, TransactionManager tm_)
		{
			return await GetByGuideNumAsync(guideNum, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 GuideNum（字段） 查询
		/// </summary>
		/// /// <param name = "guideNum">用户引导显示内容</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_user_appEO> GetByGuideNum(int guideNum, int top_)
		{
			return GetByGuideNum(guideNum, top_, string.Empty, null);
		}
		public async Task<List<Sc_user_appEO>> GetByGuideNumAsync(int guideNum, int top_)
		{
			return await GetByGuideNumAsync(guideNum, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 GuideNum（字段） 查询
		/// </summary>
		/// /// <param name = "guideNum">用户引导显示内容</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_user_appEO> GetByGuideNum(int guideNum, int top_, TransactionManager tm_)
		{
			return GetByGuideNum(guideNum, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_user_appEO>> GetByGuideNumAsync(int guideNum, int top_, TransactionManager tm_)
		{
			return await GetByGuideNumAsync(guideNum, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 GuideNum（字段） 查询
		/// </summary>
		/// /// <param name = "guideNum">用户引导显示内容</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_user_appEO> GetByGuideNum(int guideNum, string sort_)
		{
			return GetByGuideNum(guideNum, 0, sort_, null);
		}
		public async Task<List<Sc_user_appEO>> GetByGuideNumAsync(int guideNum, string sort_)
		{
			return await GetByGuideNumAsync(guideNum, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 GuideNum（字段） 查询
		/// </summary>
		/// /// <param name = "guideNum">用户引导显示内容</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_user_appEO> GetByGuideNum(int guideNum, string sort_, TransactionManager tm_)
		{
			return GetByGuideNum(guideNum, 0, sort_, tm_);
		}
		public async Task<List<Sc_user_appEO>> GetByGuideNumAsync(int guideNum, string sort_, TransactionManager tm_)
		{
			return await GetByGuideNumAsync(guideNum, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 GuideNum（字段） 查询
		/// </summary>
		/// /// <param name = "guideNum">用户引导显示内容</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_user_appEO> GetByGuideNum(int guideNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`GuideNum` = @GuideNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@GuideNum", guideNum, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_user_appEO.MapDataReader);
		}
		public async Task<List<Sc_user_appEO>> GetByGuideNumAsync(int guideNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`GuideNum` = @GuideNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@GuideNum", guideNum, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_user_appEO.MapDataReader);
		}
		#endregion // GetByGuideNum
		#region GetByUserAppStatus
		
		/// <summary>
		/// 按 UserAppStatus（字段） 查询
		/// </summary>
		/// /// <param name = "userAppStatus">用户状态(0-未知1-正常2-异常）</param>
		/// <return>实体对象集合</return>
		public List<Sc_user_appEO> GetByUserAppStatus(int userAppStatus)
		{
			return GetByUserAppStatus(userAppStatus, 0, string.Empty, null);
		}
		public async Task<List<Sc_user_appEO>> GetByUserAppStatusAsync(int userAppStatus)
		{
			return await GetByUserAppStatusAsync(userAppStatus, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserAppStatus（字段） 查询
		/// </summary>
		/// /// <param name = "userAppStatus">用户状态(0-未知1-正常2-异常）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_user_appEO> GetByUserAppStatus(int userAppStatus, TransactionManager tm_)
		{
			return GetByUserAppStatus(userAppStatus, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_user_appEO>> GetByUserAppStatusAsync(int userAppStatus, TransactionManager tm_)
		{
			return await GetByUserAppStatusAsync(userAppStatus, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserAppStatus（字段） 查询
		/// </summary>
		/// /// <param name = "userAppStatus">用户状态(0-未知1-正常2-异常）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_user_appEO> GetByUserAppStatus(int userAppStatus, int top_)
		{
			return GetByUserAppStatus(userAppStatus, top_, string.Empty, null);
		}
		public async Task<List<Sc_user_appEO>> GetByUserAppStatusAsync(int userAppStatus, int top_)
		{
			return await GetByUserAppStatusAsync(userAppStatus, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserAppStatus（字段） 查询
		/// </summary>
		/// /// <param name = "userAppStatus">用户状态(0-未知1-正常2-异常）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_user_appEO> GetByUserAppStatus(int userAppStatus, int top_, TransactionManager tm_)
		{
			return GetByUserAppStatus(userAppStatus, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_user_appEO>> GetByUserAppStatusAsync(int userAppStatus, int top_, TransactionManager tm_)
		{
			return await GetByUserAppStatusAsync(userAppStatus, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserAppStatus（字段） 查询
		/// </summary>
		/// /// <param name = "userAppStatus">用户状态(0-未知1-正常2-异常）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_user_appEO> GetByUserAppStatus(int userAppStatus, string sort_)
		{
			return GetByUserAppStatus(userAppStatus, 0, sort_, null);
		}
		public async Task<List<Sc_user_appEO>> GetByUserAppStatusAsync(int userAppStatus, string sort_)
		{
			return await GetByUserAppStatusAsync(userAppStatus, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 UserAppStatus（字段） 查询
		/// </summary>
		/// /// <param name = "userAppStatus">用户状态(0-未知1-正常2-异常）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_user_appEO> GetByUserAppStatus(int userAppStatus, string sort_, TransactionManager tm_)
		{
			return GetByUserAppStatus(userAppStatus, 0, sort_, tm_);
		}
		public async Task<List<Sc_user_appEO>> GetByUserAppStatusAsync(int userAppStatus, string sort_, TransactionManager tm_)
		{
			return await GetByUserAppStatusAsync(userAppStatus, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 UserAppStatus（字段） 查询
		/// </summary>
		/// /// <param name = "userAppStatus">用户状态(0-未知1-正常2-异常）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_user_appEO> GetByUserAppStatus(int userAppStatus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserAppStatus` = @UserAppStatus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserAppStatus", userAppStatus, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_user_appEO.MapDataReader);
		}
		public async Task<List<Sc_user_appEO>> GetByUserAppStatusAsync(int userAppStatus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserAppStatus` = @UserAppStatus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserAppStatus", userAppStatus, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_user_appEO.MapDataReader);
		}
		#endregion // GetByUserAppStatus
		#region GetByLastLoginDate
		
		/// <summary>
		/// 按 LastLoginDate（字段） 查询
		/// </summary>
		/// /// <param name = "lastLoginDate">最后一次访问时间</param>
		/// <return>实体对象集合</return>
		public List<Sc_user_appEO> GetByLastLoginDate(DateTime? lastLoginDate)
		{
			return GetByLastLoginDate(lastLoginDate, 0, string.Empty, null);
		}
		public async Task<List<Sc_user_appEO>> GetByLastLoginDateAsync(DateTime? lastLoginDate)
		{
			return await GetByLastLoginDateAsync(lastLoginDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LastLoginDate（字段） 查询
		/// </summary>
		/// /// <param name = "lastLoginDate">最后一次访问时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_user_appEO> GetByLastLoginDate(DateTime? lastLoginDate, TransactionManager tm_)
		{
			return GetByLastLoginDate(lastLoginDate, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_user_appEO>> GetByLastLoginDateAsync(DateTime? lastLoginDate, TransactionManager tm_)
		{
			return await GetByLastLoginDateAsync(lastLoginDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LastLoginDate（字段） 查询
		/// </summary>
		/// /// <param name = "lastLoginDate">最后一次访问时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_user_appEO> GetByLastLoginDate(DateTime? lastLoginDate, int top_)
		{
			return GetByLastLoginDate(lastLoginDate, top_, string.Empty, null);
		}
		public async Task<List<Sc_user_appEO>> GetByLastLoginDateAsync(DateTime? lastLoginDate, int top_)
		{
			return await GetByLastLoginDateAsync(lastLoginDate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LastLoginDate（字段） 查询
		/// </summary>
		/// /// <param name = "lastLoginDate">最后一次访问时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_user_appEO> GetByLastLoginDate(DateTime? lastLoginDate, int top_, TransactionManager tm_)
		{
			return GetByLastLoginDate(lastLoginDate, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_user_appEO>> GetByLastLoginDateAsync(DateTime? lastLoginDate, int top_, TransactionManager tm_)
		{
			return await GetByLastLoginDateAsync(lastLoginDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LastLoginDate（字段） 查询
		/// </summary>
		/// /// <param name = "lastLoginDate">最后一次访问时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_user_appEO> GetByLastLoginDate(DateTime? lastLoginDate, string sort_)
		{
			return GetByLastLoginDate(lastLoginDate, 0, sort_, null);
		}
		public async Task<List<Sc_user_appEO>> GetByLastLoginDateAsync(DateTime? lastLoginDate, string sort_)
		{
			return await GetByLastLoginDateAsync(lastLoginDate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LastLoginDate（字段） 查询
		/// </summary>
		/// /// <param name = "lastLoginDate">最后一次访问时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_user_appEO> GetByLastLoginDate(DateTime? lastLoginDate, string sort_, TransactionManager tm_)
		{
			return GetByLastLoginDate(lastLoginDate, 0, sort_, tm_);
		}
		public async Task<List<Sc_user_appEO>> GetByLastLoginDateAsync(DateTime? lastLoginDate, string sort_, TransactionManager tm_)
		{
			return await GetByLastLoginDateAsync(lastLoginDate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LastLoginDate（字段） 查询
		/// </summary>
		/// /// <param name = "lastLoginDate">最后一次访问时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_user_appEO> GetByLastLoginDate(DateTime? lastLoginDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(lastLoginDate.HasValue ? "`LastLoginDate` = @LastLoginDate" : "`LastLoginDate` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (lastLoginDate.HasValue)
				paras_.Add(Database.CreateInParameter("@LastLoginDate", lastLoginDate.Value, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_user_appEO.MapDataReader);
		}
		public async Task<List<Sc_user_appEO>> GetByLastLoginDateAsync(DateTime? lastLoginDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(lastLoginDate.HasValue ? "`LastLoginDate` = @LastLoginDate" : "`LastLoginDate` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (lastLoginDate.HasValue)
				paras_.Add(Database.CreateInParameter("@LastLoginDate", lastLoginDate.Value, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_user_appEO.MapDataReader);
		}
		#endregion // GetByLastLoginDate
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
