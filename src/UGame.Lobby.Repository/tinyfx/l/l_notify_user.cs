/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * AiUo代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/AiUo
 * 文档生成时间：2023-10-24 18: 04:50
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
	/// 通知具体用户
	/// 【表 l_notify_user 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class L_notify_userEO : IRowMapper<L_notify_userEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public L_notify_userEO()
		{
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
		
		private string _originalNotifyID;
		/// <summary>
		/// 【数据库中的原始主键 NotifyID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalNotifyID
		{
			get { return _originalNotifyID; }
			set { HasOriginal = true; _originalNotifyID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "UserID", UserID },  { "NotifyID", NotifyID }, };
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
		/// 【主键 varchar(38)】
		/// </summary>
		[DataMember(Order = 1)]
		public string NotifyID { get; set; }
		/// <summary>
		/// 用户编码
		/// 【主键 varchar(38)】
		/// </summary>
		[DataMember(Order = 2)]
		public string UserID { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public L_notify_userEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static L_notify_userEO MapDataReader(IDataReader reader)
		{
		    L_notify_userEO ret = new L_notify_userEO();
			ret.NotifyID = reader.ToString("NotifyID");
			ret.OriginalNotifyID = ret.NotifyID;
			ret.UserID = reader.ToString("UserID");
			ret.OriginalUserID = ret.UserID;
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 通知具体用户
	/// 【表 l_notify_user 的操作类】
	/// </summary>
	[Obsolete]
	public class L_notify_userMO : MySqlTableMO<L_notify_userEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`l_notify_user`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public L_notify_userMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public L_notify_userMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public L_notify_userMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(L_notify_userEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(L_notify_userEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(L_notify_userEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`NotifyID`, `UserID`) VALUE (@NotifyID, @UserID);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", item.NotifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
			};
		}
		public int AddByBatch(IEnumerable<L_notify_userEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<L_notify_userEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<L_notify_userEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`NotifyID`, `UserID`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.NotifyID}','{item.UserID}'),");
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
		/// /// <param name = "notifyID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string userID, string notifyID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(userID, notifyID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string userID, string notifyID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(userID, notifyID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string userID, string notifyID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `UserID` = @UserID AND `NotifyID` = @NotifyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(L_notify_userEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.UserID, item.NotifyID, tm_);
		}
		public async Task<int> RemoveAsync(L_notify_userEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.UserID, item.NotifyID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByNotifyID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByNotifyID(string notifyID, TransactionManager tm_ = null)
		{
			RepairRemoveByNotifyIDData(notifyID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByNotifyIDAsync(string notifyID, TransactionManager tm_ = null)
		{
			RepairRemoveByNotifyIDData(notifyID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByNotifyIDData(string notifyID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `NotifyID` = @NotifyID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByNotifyID
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
		public int Put(L_notify_userEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(L_notify_userEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(L_notify_userEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `NotifyID` = @NotifyID, `UserID` = @UserID WHERE `UserID` = @UserID_Original AND `NotifyID` = @NotifyID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", item.NotifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID_Original", item.HasOriginal ? item.OriginalUserID : item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@NotifyID_Original", item.HasOriginal ? item.OriginalNotifyID : item.NotifyID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<L_notify_userEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<L_notify_userEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "notifyID">主键GUID</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string userID, string notifyID, string set_, params object[] values_)
		{
			return Put(set_, "`UserID` = @UserID AND `NotifyID` = @NotifyID", ConcatValues(values_, userID, notifyID));
		}
		public async Task<int> PutByPKAsync(string userID, string notifyID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`UserID` = @UserID AND `NotifyID` = @NotifyID", ConcatValues(values_, userID, notifyID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "notifyID">主键GUID</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string userID, string notifyID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`UserID` = @UserID AND `NotifyID` = @NotifyID", tm_, ConcatValues(values_, userID, notifyID));
		}
		public async Task<int> PutByPKAsync(string userID, string notifyID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`UserID` = @UserID AND `NotifyID` = @NotifyID", tm_, ConcatValues(values_, userID, notifyID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "notifyID">主键GUID</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string userID, string notifyID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`UserID` = @UserID AND `NotifyID` = @NotifyID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string userID, string notifyID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`UserID` = @UserID AND `NotifyID` = @NotifyID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutNotifyID
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutNotifyID(string notifyID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `NotifyID` = @NotifyID";
			var parameter_ = Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutNotifyIDAsync(string notifyID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `NotifyID` = @NotifyID";
			var parameter_ = Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutNotifyID
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
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(L_notify_userEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.UserID, item.NotifyID) == null)
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
		public async Task<bool> SetAsync(L_notify_userEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.UserID, item.NotifyID) == null)
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
		/// /// <param name = "notifyID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public L_notify_userEO GetByPK(string userID, string notifyID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(userID, notifyID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, L_notify_userEO.MapDataReader);
		}
		public async Task<L_notify_userEO> GetByPKAsync(string userID, string notifyID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(userID, notifyID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, L_notify_userEO.MapDataReader);
		}
		private void RepairGetByPKData(string userID, string notifyID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`UserID` = @UserID AND `NotifyID` = @NotifyID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 NotifyID（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "notifyID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetNotifyIDByPK(string userID, string notifyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`NotifyID`", "`UserID` = @UserID AND `NotifyID` = @NotifyID", paras_, tm_);
		}
		public async Task<string> GetNotifyIDByPKAsync(string userID, string notifyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`NotifyID`", "`UserID` = @UserID AND `NotifyID` = @NotifyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 UserID（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "notifyID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetUserIDByPK(string userID, string notifyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`UserID`", "`UserID` = @UserID AND `NotifyID` = @NotifyID", paras_, tm_);
		}
		public async Task<string> GetUserIDByPKAsync(string userID, string notifyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`UserID`", "`UserID` = @UserID AND `NotifyID` = @NotifyID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByNotifyID
		
		/// <summary>
		/// 按 NotifyID（字段） 查询
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// <return>实体对象集合</return>
		public List<L_notify_userEO> GetByNotifyID(string notifyID)
		{
			return GetByNotifyID(notifyID, 0, string.Empty, null);
		}
		public async Task<List<L_notify_userEO>> GetByNotifyIDAsync(string notifyID)
		{
			return await GetByNotifyIDAsync(notifyID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NotifyID（字段） 查询
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_notify_userEO> GetByNotifyID(string notifyID, TransactionManager tm_)
		{
			return GetByNotifyID(notifyID, 0, string.Empty, tm_);
		}
		public async Task<List<L_notify_userEO>> GetByNotifyIDAsync(string notifyID, TransactionManager tm_)
		{
			return await GetByNotifyIDAsync(notifyID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NotifyID（字段） 查询
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_notify_userEO> GetByNotifyID(string notifyID, int top_)
		{
			return GetByNotifyID(notifyID, top_, string.Empty, null);
		}
		public async Task<List<L_notify_userEO>> GetByNotifyIDAsync(string notifyID, int top_)
		{
			return await GetByNotifyIDAsync(notifyID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NotifyID（字段） 查询
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_notify_userEO> GetByNotifyID(string notifyID, int top_, TransactionManager tm_)
		{
			return GetByNotifyID(notifyID, top_, string.Empty, tm_);
		}
		public async Task<List<L_notify_userEO>> GetByNotifyIDAsync(string notifyID, int top_, TransactionManager tm_)
		{
			return await GetByNotifyIDAsync(notifyID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NotifyID（字段） 查询
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_notify_userEO> GetByNotifyID(string notifyID, string sort_)
		{
			return GetByNotifyID(notifyID, 0, sort_, null);
		}
		public async Task<List<L_notify_userEO>> GetByNotifyIDAsync(string notifyID, string sort_)
		{
			return await GetByNotifyIDAsync(notifyID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 NotifyID（字段） 查询
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_notify_userEO> GetByNotifyID(string notifyID, string sort_, TransactionManager tm_)
		{
			return GetByNotifyID(notifyID, 0, sort_, tm_);
		}
		public async Task<List<L_notify_userEO>> GetByNotifyIDAsync(string notifyID, string sort_, TransactionManager tm_)
		{
			return await GetByNotifyIDAsync(notifyID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 NotifyID（字段） 查询
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_notify_userEO> GetByNotifyID(string notifyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`NotifyID` = @NotifyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_notify_userEO.MapDataReader);
		}
		public async Task<List<L_notify_userEO>> GetByNotifyIDAsync(string notifyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`NotifyID` = @NotifyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_notify_userEO.MapDataReader);
		}
		#endregion // GetByNotifyID
		#region GetByUserID
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <return>实体对象集合</return>
		public List<L_notify_userEO> GetByUserID(string userID)
		{
			return GetByUserID(userID, 0, string.Empty, null);
		}
		public async Task<List<L_notify_userEO>> GetByUserIDAsync(string userID)
		{
			return await GetByUserIDAsync(userID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_notify_userEO> GetByUserID(string userID, TransactionManager tm_)
		{
			return GetByUserID(userID, 0, string.Empty, tm_);
		}
		public async Task<List<L_notify_userEO>> GetByUserIDAsync(string userID, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_notify_userEO> GetByUserID(string userID, int top_)
		{
			return GetByUserID(userID, top_, string.Empty, null);
		}
		public async Task<List<L_notify_userEO>> GetByUserIDAsync(string userID, int top_)
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
		public List<L_notify_userEO> GetByUserID(string userID, int top_, TransactionManager tm_)
		{
			return GetByUserID(userID, top_, string.Empty, tm_);
		}
		public async Task<List<L_notify_userEO>> GetByUserIDAsync(string userID, int top_, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_notify_userEO> GetByUserID(string userID, string sort_)
		{
			return GetByUserID(userID, 0, sort_, null);
		}
		public async Task<List<L_notify_userEO>> GetByUserIDAsync(string userID, string sort_)
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
		public List<L_notify_userEO> GetByUserID(string userID, string sort_, TransactionManager tm_)
		{
			return GetByUserID(userID, 0, sort_, tm_);
		}
		public async Task<List<L_notify_userEO>> GetByUserIDAsync(string userID, string sort_, TransactionManager tm_)
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
		public List<L_notify_userEO> GetByUserID(string userID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserID` = @UserID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_notify_userEO.MapDataReader);
		}
		public async Task<List<L_notify_userEO>> GetByUserIDAsync(string userID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserID` = @UserID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_notify_userEO.MapDataReader);
		}
		#endregion // GetByUserID
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
