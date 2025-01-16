/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * AiUo代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/AiUo
 * 文档生成时间：2023-10-24 18: 04:57
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
	/// 活动事件基础数据表
	/// 【表 l_activity_event_base 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class L_activity_event_baseEO : IRowMapper<L_activity_event_baseEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public L_activity_event_baseEO()
		{
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private int _originalActivityEventId;
		/// <summary>
		/// 【数据库中的原始主键 ActivityEventId 值的副本，用于主键值更新】
		/// </summary>
		public int OriginalActivityEventId
		{
			get { return _originalActivityEventId; }
			set { HasOriginal = true; _originalActivityEventId = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "ActivityEventId", ActivityEventId }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 活动事件id
		/// 【主键 int】
		/// </summary>
		[DataMember(Order = 1)]
		public int ActivityEventId { get; set; }
		/// <summary>
		/// 活动事件名称
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 2)]
		public string EventName { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public L_activity_event_baseEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static L_activity_event_baseEO MapDataReader(IDataReader reader)
		{
		    L_activity_event_baseEO ret = new L_activity_event_baseEO();
			ret.ActivityEventId = reader.ToInt32("ActivityEventId");
			ret.OriginalActivityEventId = ret.ActivityEventId;
			ret.EventName = reader.ToString("EventName");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 活动事件基础数据表
	/// 【表 l_activity_event_base 的操作类】
	/// </summary>
	[Obsolete]
	public class L_activity_event_baseMO : MySqlTableMO<L_activity_event_baseEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`l_activity_event_base`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public L_activity_event_baseMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public L_activity_event_baseMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public L_activity_event_baseMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(L_activity_event_baseEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			item.ActivityEventId = Database.ExecSqlScalar<int>(sql_, paras_, tm_); 
			return 1;
		}
		public override async Task<int> AddAsync(L_activity_event_baseEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			item.ActivityEventId = await Database.ExecSqlScalarAsync<int>(sql_, paras_, tm_); 
	        return 1;
		}
	    private void RepairAddData(L_activity_event_baseEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`EventName`) VALUE (@EventName);SELECT LAST_INSERT_ID();";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@EventName", item.EventName != null ? item.EventName : (object)DBNull.Value, MySqlDbType.VarChar),
			};
		}
		public int AddByBatch(IEnumerable<L_activity_event_baseEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<L_activity_event_baseEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<L_activity_event_baseEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`ActivityEventId`, `EventName`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"({item.ActivityEventId},'{item.EventName}'),");
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
		/// /// <param name = "activityEventId">活动事件id</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(int activityEventId, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(activityEventId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(int activityEventId, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(activityEventId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(int activityEventId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `ActivityEventId` = @ActivityEventId";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ActivityEventId", activityEventId, MySqlDbType.Int32),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(L_activity_event_baseEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.ActivityEventId, tm_);
		}
		public async Task<int> RemoveAsync(L_activity_event_baseEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.ActivityEventId, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByEventName
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "eventName">活动事件名称</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByEventName(string eventName, TransactionManager tm_ = null)
		{
			RepairRemoveByEventNameData(eventName, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByEventNameAsync(string eventName, TransactionManager tm_ = null)
		{
			RepairRemoveByEventNameData(eventName, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByEventNameData(string eventName, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (eventName != null ? "`EventName` = @EventName" : "`EventName` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (eventName != null)
				paras_.Add(Database.CreateInParameter("@EventName", eventName, MySqlDbType.VarChar));
		}
		#endregion // RemoveByEventName
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
		public int Put(L_activity_event_baseEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(L_activity_event_baseEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(L_activity_event_baseEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `EventName` = @EventName WHERE `ActivityEventId` = @ActivityEventId_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@EventName", item.EventName != null ? item.EventName : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ActivityEventId_Original", item.HasOriginal ? item.OriginalActivityEventId : item.ActivityEventId, MySqlDbType.Int32),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<L_activity_event_baseEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<L_activity_event_baseEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "activityEventId">活动事件id</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int activityEventId, string set_, params object[] values_)
		{
			return Put(set_, "`ActivityEventId` = @ActivityEventId", ConcatValues(values_, activityEventId));
		}
		public async Task<int> PutByPKAsync(int activityEventId, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`ActivityEventId` = @ActivityEventId", ConcatValues(values_, activityEventId));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "activityEventId">活动事件id</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int activityEventId, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`ActivityEventId` = @ActivityEventId", tm_, ConcatValues(values_, activityEventId));
		}
		public async Task<int> PutByPKAsync(int activityEventId, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`ActivityEventId` = @ActivityEventId", tm_, ConcatValues(values_, activityEventId));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "activityEventId">活动事件id</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int activityEventId, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@ActivityEventId", activityEventId, MySqlDbType.Int32),
	        };
			return Put(set_, "`ActivityEventId` = @ActivityEventId", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(int activityEventId, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@ActivityEventId", activityEventId, MySqlDbType.Int32),
	        };
			return await PutAsync(set_, "`ActivityEventId` = @ActivityEventId", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutEventName
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "activityEventId">活动事件id</param>
		/// /// <param name = "eventName">活动事件名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutEventNameByPK(int activityEventId, string eventName, TransactionManager tm_ = null)
		{
			RepairPutEventNameByPKData(activityEventId, eventName, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutEventNameByPKAsync(int activityEventId, string eventName, TransactionManager tm_ = null)
		{
			RepairPutEventNameByPKData(activityEventId, eventName, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutEventNameByPKData(int activityEventId, string eventName, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `EventName` = @EventName  WHERE `ActivityEventId` = @ActivityEventId";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@EventName", eventName != null ? eventName : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ActivityEventId", activityEventId, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "eventName">活动事件名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutEventName(string eventName, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `EventName` = @EventName";
			var parameter_ = Database.CreateInParameter("@EventName", eventName != null ? eventName : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutEventNameAsync(string eventName, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `EventName` = @EventName";
			var parameter_ = Database.CreateInParameter("@EventName", eventName != null ? eventName : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutEventName
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(L_activity_event_baseEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.ActivityEventId) == null)
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
		public async Task<bool> SetAsync(L_activity_event_baseEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.ActivityEventId) == null)
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
		/// /// <param name = "activityEventId">活动事件id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public L_activity_event_baseEO GetByPK(int activityEventId, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(activityEventId, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, L_activity_event_baseEO.MapDataReader);
		}
		public async Task<L_activity_event_baseEO> GetByPKAsync(int activityEventId, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(activityEventId, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, L_activity_event_baseEO.MapDataReader);
		}
		private void RepairGetByPKData(int activityEventId, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`ActivityEventId` = @ActivityEventId", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ActivityEventId", activityEventId, MySqlDbType.Int32),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 EventName（字段）
		/// </summary>
		/// /// <param name = "activityEventId">活动事件id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetEventNameByPK(int activityEventId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ActivityEventId", activityEventId, MySqlDbType.Int32),
			};
			return (string)GetScalar("`EventName`", "`ActivityEventId` = @ActivityEventId", paras_, tm_);
		}
		public async Task<string> GetEventNameByPKAsync(int activityEventId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ActivityEventId", activityEventId, MySqlDbType.Int32),
			};
			return (string)await GetScalarAsync("`EventName`", "`ActivityEventId` = @ActivityEventId", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByEventName
		
		/// <summary>
		/// 按 EventName（字段） 查询
		/// </summary>
		/// /// <param name = "eventName">活动事件名称</param>
		/// <return>实体对象集合</return>
		public List<L_activity_event_baseEO> GetByEventName(string eventName)
		{
			return GetByEventName(eventName, 0, string.Empty, null);
		}
		public async Task<List<L_activity_event_baseEO>> GetByEventNameAsync(string eventName)
		{
			return await GetByEventNameAsync(eventName, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 EventName（字段） 查询
		/// </summary>
		/// /// <param name = "eventName">活动事件名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_event_baseEO> GetByEventName(string eventName, TransactionManager tm_)
		{
			return GetByEventName(eventName, 0, string.Empty, tm_);
		}
		public async Task<List<L_activity_event_baseEO>> GetByEventNameAsync(string eventName, TransactionManager tm_)
		{
			return await GetByEventNameAsync(eventName, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 EventName（字段） 查询
		/// </summary>
		/// /// <param name = "eventName">活动事件名称</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_activity_event_baseEO> GetByEventName(string eventName, int top_)
		{
			return GetByEventName(eventName, top_, string.Empty, null);
		}
		public async Task<List<L_activity_event_baseEO>> GetByEventNameAsync(string eventName, int top_)
		{
			return await GetByEventNameAsync(eventName, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 EventName（字段） 查询
		/// </summary>
		/// /// <param name = "eventName">活动事件名称</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_event_baseEO> GetByEventName(string eventName, int top_, TransactionManager tm_)
		{
			return GetByEventName(eventName, top_, string.Empty, tm_);
		}
		public async Task<List<L_activity_event_baseEO>> GetByEventNameAsync(string eventName, int top_, TransactionManager tm_)
		{
			return await GetByEventNameAsync(eventName, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 EventName（字段） 查询
		/// </summary>
		/// /// <param name = "eventName">活动事件名称</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_activity_event_baseEO> GetByEventName(string eventName, string sort_)
		{
			return GetByEventName(eventName, 0, sort_, null);
		}
		public async Task<List<L_activity_event_baseEO>> GetByEventNameAsync(string eventName, string sort_)
		{
			return await GetByEventNameAsync(eventName, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 EventName（字段） 查询
		/// </summary>
		/// /// <param name = "eventName">活动事件名称</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_event_baseEO> GetByEventName(string eventName, string sort_, TransactionManager tm_)
		{
			return GetByEventName(eventName, 0, sort_, tm_);
		}
		public async Task<List<L_activity_event_baseEO>> GetByEventNameAsync(string eventName, string sort_, TransactionManager tm_)
		{
			return await GetByEventNameAsync(eventName, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 EventName（字段） 查询
		/// </summary>
		/// /// <param name = "eventName">活动事件名称</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_event_baseEO> GetByEventName(string eventName, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(eventName != null ? "`EventName` = @EventName" : "`EventName` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (eventName != null)
				paras_.Add(Database.CreateInParameter("@EventName", eventName, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_activity_event_baseEO.MapDataReader);
		}
		public async Task<List<L_activity_event_baseEO>> GetByEventNameAsync(string eventName, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(eventName != null ? "`EventName` = @EventName" : "`EventName` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (eventName != null)
				paras_.Add(Database.CreateInParameter("@EventName", eventName, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_activity_event_baseEO.MapDataReader);
		}
		#endregion // GetByEventName
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
