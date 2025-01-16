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
	/// 输出查询
	/// 【表 l_query_input 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class L_query_inputEO : IRowMapper<L_query_inputEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public L_query_inputEO()
		{
			this.KeyType = 1;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private string _originalQueryID;
		/// <summary>
		/// 【数据库中的原始主键 QueryID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalQueryID
		{
			get { return _originalQueryID; }
			set { HasOriginal = true; _originalQueryID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "QueryID", QueryID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 编码GUID
		/// 【主键 varchar(36)】
		/// </summary>
		[DataMember(Order = 1)]
		public string QueryID { get; set; }
		/// <summary>
		/// 语言
		/// 【字段 varchar(20)】
		/// </summary>
		[DataMember(Order = 2)]
		public string LangID { get; set; }
		/// <summary>
		/// 类型1-游戏名2-分类3-keyword
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 3)]
		public int KeyType { get; set; }
		/// <summary>
		/// 查询关键字
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 4)]
		public string QueryKey { get; set; }
		/// <summary>
		/// 应用编码
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 5)]
		public string AppID { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public L_query_inputEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static L_query_inputEO MapDataReader(IDataReader reader)
		{
		    L_query_inputEO ret = new L_query_inputEO();
			ret.QueryID = reader.ToString("QueryID");
			ret.OriginalQueryID = ret.QueryID;
			ret.LangID = reader.ToString("LangID");
			ret.KeyType = reader.ToInt32("KeyType");
			ret.QueryKey = reader.ToString("QueryKey");
			ret.AppID = reader.ToString("AppID");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 输出查询
	/// 【表 l_query_input 的操作类】
	/// </summary>
	[Obsolete]
	public class L_query_inputMO : MySqlTableMO<L_query_inputEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`l_query_input`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public L_query_inputMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public L_query_inputMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public L_query_inputMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(L_query_inputEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(L_query_inputEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(L_query_inputEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`QueryID`, `LangID`, `KeyType`, `QueryKey`, `AppID`) VALUE (@QueryID, @LangID, @KeyType, @QueryKey, @AppID);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@QueryID", item.QueryID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", item.LangID != null ? item.LangID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@KeyType", item.KeyType, MySqlDbType.Int32),
				Database.CreateInParameter("@QueryKey", item.QueryKey != null ? item.QueryKey : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", item.AppID, MySqlDbType.VarChar),
			};
		}
		public int AddByBatch(IEnumerable<L_query_inputEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<L_query_inputEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<L_query_inputEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`QueryID`, `LangID`, `KeyType`, `QueryKey`, `AppID`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.QueryID}','{item.LangID}',{item.KeyType},'{item.QueryKey}','{item.AppID}'),");
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
		/// /// <param name = "queryID">编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string queryID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(queryID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string queryID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(queryID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string queryID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `QueryID` = @QueryID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@QueryID", queryID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(L_query_inputEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.QueryID, tm_);
		}
		public async Task<int> RemoveAsync(L_query_inputEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.QueryID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByLangID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "langID">语言</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByLangID(string langID, TransactionManager tm_ = null)
		{
			RepairRemoveByLangIDData(langID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByLangIDAsync(string langID, TransactionManager tm_ = null)
		{
			RepairRemoveByLangIDData(langID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByLangIDData(string langID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (langID != null ? "`LangID` = @LangID" : "`LangID` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (langID != null)
				paras_.Add(Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByLangID
		#region RemoveByKeyType
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "keyType">类型1-游戏名2-分类3-keyword</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByKeyType(int keyType, TransactionManager tm_ = null)
		{
			RepairRemoveByKeyTypeData(keyType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByKeyTypeAsync(int keyType, TransactionManager tm_ = null)
		{
			RepairRemoveByKeyTypeData(keyType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByKeyTypeData(int keyType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `KeyType` = @KeyType";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@KeyType", keyType, MySqlDbType.Int32));
		}
		#endregion // RemoveByKeyType
		#region RemoveByQueryKey
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "queryKey">查询关键字</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByQueryKey(string queryKey, TransactionManager tm_ = null)
		{
			RepairRemoveByQueryKeyData(queryKey, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByQueryKeyAsync(string queryKey, TransactionManager tm_ = null)
		{
			RepairRemoveByQueryKeyData(queryKey, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByQueryKeyData(string queryKey, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (queryKey != null ? "`QueryKey` = @QueryKey" : "`QueryKey` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (queryKey != null)
				paras_.Add(Database.CreateInParameter("@QueryKey", queryKey, MySqlDbType.VarChar));
		}
		#endregion // RemoveByQueryKey
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
		public int Put(L_query_inputEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(L_query_inputEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(L_query_inputEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `QueryID` = @QueryID, `LangID` = @LangID, `KeyType` = @KeyType, `QueryKey` = @QueryKey, `AppID` = @AppID WHERE `QueryID` = @QueryID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@QueryID", item.QueryID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", item.LangID != null ? item.LangID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@KeyType", item.KeyType, MySqlDbType.Int32),
				Database.CreateInParameter("@QueryKey", item.QueryKey != null ? item.QueryKey : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", item.AppID, MySqlDbType.VarChar),
				Database.CreateInParameter("@QueryID_Original", item.HasOriginal ? item.OriginalQueryID : item.QueryID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<L_query_inputEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<L_query_inputEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "queryID">编码GUID</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string queryID, string set_, params object[] values_)
		{
			return Put(set_, "`QueryID` = @QueryID", ConcatValues(values_, queryID));
		}
		public async Task<int> PutByPKAsync(string queryID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`QueryID` = @QueryID", ConcatValues(values_, queryID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "queryID">编码GUID</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string queryID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`QueryID` = @QueryID", tm_, ConcatValues(values_, queryID));
		}
		public async Task<int> PutByPKAsync(string queryID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`QueryID` = @QueryID", tm_, ConcatValues(values_, queryID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "queryID">编码GUID</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string queryID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@QueryID", queryID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`QueryID` = @QueryID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string queryID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@QueryID", queryID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`QueryID` = @QueryID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutLangID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "queryID">编码GUID</param>
		/// /// <param name = "langID">语言</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLangIDByPK(string queryID, string langID, TransactionManager tm_ = null)
		{
			RepairPutLangIDByPKData(queryID, langID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLangIDByPKAsync(string queryID, string langID, TransactionManager tm_ = null)
		{
			RepairPutLangIDByPKData(queryID, langID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLangIDByPKData(string queryID, string langID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `LangID` = @LangID  WHERE `QueryID` = @QueryID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LangID", langID != null ? langID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@QueryID", queryID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "langID">语言</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLangID(string langID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LangID` = @LangID";
			var parameter_ = Database.CreateInParameter("@LangID", langID != null ? langID : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutLangIDAsync(string langID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LangID` = @LangID";
			var parameter_ = Database.CreateInParameter("@LangID", langID != null ? langID : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutLangID
		#region PutKeyType
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "queryID">编码GUID</param>
		/// /// <param name = "keyType">类型1-游戏名2-分类3-keyword</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutKeyTypeByPK(string queryID, int keyType, TransactionManager tm_ = null)
		{
			RepairPutKeyTypeByPKData(queryID, keyType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutKeyTypeByPKAsync(string queryID, int keyType, TransactionManager tm_ = null)
		{
			RepairPutKeyTypeByPKData(queryID, keyType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutKeyTypeByPKData(string queryID, int keyType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `KeyType` = @KeyType  WHERE `QueryID` = @QueryID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@KeyType", keyType, MySqlDbType.Int32),
				Database.CreateInParameter("@QueryID", queryID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "keyType">类型1-游戏名2-分类3-keyword</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutKeyType(int keyType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `KeyType` = @KeyType";
			var parameter_ = Database.CreateInParameter("@KeyType", keyType, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutKeyTypeAsync(int keyType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `KeyType` = @KeyType";
			var parameter_ = Database.CreateInParameter("@KeyType", keyType, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutKeyType
		#region PutQueryKey
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "queryID">编码GUID</param>
		/// /// <param name = "queryKey">查询关键字</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutQueryKeyByPK(string queryID, string queryKey, TransactionManager tm_ = null)
		{
			RepairPutQueryKeyByPKData(queryID, queryKey, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutQueryKeyByPKAsync(string queryID, string queryKey, TransactionManager tm_ = null)
		{
			RepairPutQueryKeyByPKData(queryID, queryKey, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutQueryKeyByPKData(string queryID, string queryKey, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `QueryKey` = @QueryKey  WHERE `QueryID` = @QueryID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@QueryKey", queryKey != null ? queryKey : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@QueryID", queryID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "queryKey">查询关键字</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutQueryKey(string queryKey, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `QueryKey` = @QueryKey";
			var parameter_ = Database.CreateInParameter("@QueryKey", queryKey != null ? queryKey : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutQueryKeyAsync(string queryKey, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `QueryKey` = @QueryKey";
			var parameter_ = Database.CreateInParameter("@QueryKey", queryKey != null ? queryKey : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutQueryKey
		#region PutAppID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "queryID">编码GUID</param>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAppIDByPK(string queryID, string appID, TransactionManager tm_ = null)
		{
			RepairPutAppIDByPKData(queryID, appID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAppIDByPKAsync(string queryID, string appID, TransactionManager tm_ = null)
		{
			RepairPutAppIDByPKData(queryID, appID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutAppIDByPKData(string queryID, string appID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `AppID` = @AppID  WHERE `QueryID` = @QueryID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@QueryID", queryID, MySqlDbType.VarChar),
			};
		}
	 
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
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(L_query_inputEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.QueryID) == null)
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
		public async Task<bool> SetAsync(L_query_inputEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.QueryID) == null)
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
		/// /// <param name = "queryID">编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public L_query_inputEO GetByPK(string queryID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(queryID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, L_query_inputEO.MapDataReader);
		}
		public async Task<L_query_inputEO> GetByPKAsync(string queryID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(queryID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, L_query_inputEO.MapDataReader);
		}
		private void RepairGetByPKData(string queryID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`QueryID` = @QueryID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@QueryID", queryID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 LangID（字段）
		/// </summary>
		/// /// <param name = "queryID">编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetLangIDByPK(string queryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@QueryID", queryID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`LangID`", "`QueryID` = @QueryID", paras_, tm_);
		}
		public async Task<string> GetLangIDByPKAsync(string queryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@QueryID", queryID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`LangID`", "`QueryID` = @QueryID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 KeyType（字段）
		/// </summary>
		/// /// <param name = "queryID">编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetKeyTypeByPK(string queryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@QueryID", queryID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`KeyType`", "`QueryID` = @QueryID", paras_, tm_);
		}
		public async Task<int> GetKeyTypeByPKAsync(string queryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@QueryID", queryID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`KeyType`", "`QueryID` = @QueryID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 QueryKey（字段）
		/// </summary>
		/// /// <param name = "queryID">编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetQueryKeyByPK(string queryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@QueryID", queryID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`QueryKey`", "`QueryID` = @QueryID", paras_, tm_);
		}
		public async Task<string> GetQueryKeyByPKAsync(string queryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@QueryID", queryID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`QueryKey`", "`QueryID` = @QueryID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 AppID（字段）
		/// </summary>
		/// /// <param name = "queryID">编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetAppIDByPK(string queryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@QueryID", queryID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`AppID`", "`QueryID` = @QueryID", paras_, tm_);
		}
		public async Task<string> GetAppIDByPKAsync(string queryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@QueryID", queryID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`AppID`", "`QueryID` = @QueryID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByLangID
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言</param>
		/// <return>实体对象集合</return>
		public List<L_query_inputEO> GetByLangID(string langID)
		{
			return GetByLangID(langID, 0, string.Empty, null);
		}
		public async Task<List<L_query_inputEO>> GetByLangIDAsync(string langID)
		{
			return await GetByLangIDAsync(langID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_query_inputEO> GetByLangID(string langID, TransactionManager tm_)
		{
			return GetByLangID(langID, 0, string.Empty, tm_);
		}
		public async Task<List<L_query_inputEO>> GetByLangIDAsync(string langID, TransactionManager tm_)
		{
			return await GetByLangIDAsync(langID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_query_inputEO> GetByLangID(string langID, int top_)
		{
			return GetByLangID(langID, top_, string.Empty, null);
		}
		public async Task<List<L_query_inputEO>> GetByLangIDAsync(string langID, int top_)
		{
			return await GetByLangIDAsync(langID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_query_inputEO> GetByLangID(string langID, int top_, TransactionManager tm_)
		{
			return GetByLangID(langID, top_, string.Empty, tm_);
		}
		public async Task<List<L_query_inputEO>> GetByLangIDAsync(string langID, int top_, TransactionManager tm_)
		{
			return await GetByLangIDAsync(langID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_query_inputEO> GetByLangID(string langID, string sort_)
		{
			return GetByLangID(langID, 0, sort_, null);
		}
		public async Task<List<L_query_inputEO>> GetByLangIDAsync(string langID, string sort_)
		{
			return await GetByLangIDAsync(langID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_query_inputEO> GetByLangID(string langID, string sort_, TransactionManager tm_)
		{
			return GetByLangID(langID, 0, sort_, tm_);
		}
		public async Task<List<L_query_inputEO>> GetByLangIDAsync(string langID, string sort_, TransactionManager tm_)
		{
			return await GetByLangIDAsync(langID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_query_inputEO> GetByLangID(string langID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(langID != null ? "`LangID` = @LangID" : "`LangID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (langID != null)
				paras_.Add(Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_query_inputEO.MapDataReader);
		}
		public async Task<List<L_query_inputEO>> GetByLangIDAsync(string langID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(langID != null ? "`LangID` = @LangID" : "`LangID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (langID != null)
				paras_.Add(Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_query_inputEO.MapDataReader);
		}
		#endregion // GetByLangID
		#region GetByKeyType
		
		/// <summary>
		/// 按 KeyType（字段） 查询
		/// </summary>
		/// /// <param name = "keyType">类型1-游戏名2-分类3-keyword</param>
		/// <return>实体对象集合</return>
		public List<L_query_inputEO> GetByKeyType(int keyType)
		{
			return GetByKeyType(keyType, 0, string.Empty, null);
		}
		public async Task<List<L_query_inputEO>> GetByKeyTypeAsync(int keyType)
		{
			return await GetByKeyTypeAsync(keyType, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 KeyType（字段） 查询
		/// </summary>
		/// /// <param name = "keyType">类型1-游戏名2-分类3-keyword</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_query_inputEO> GetByKeyType(int keyType, TransactionManager tm_)
		{
			return GetByKeyType(keyType, 0, string.Empty, tm_);
		}
		public async Task<List<L_query_inputEO>> GetByKeyTypeAsync(int keyType, TransactionManager tm_)
		{
			return await GetByKeyTypeAsync(keyType, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 KeyType（字段） 查询
		/// </summary>
		/// /// <param name = "keyType">类型1-游戏名2-分类3-keyword</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_query_inputEO> GetByKeyType(int keyType, int top_)
		{
			return GetByKeyType(keyType, top_, string.Empty, null);
		}
		public async Task<List<L_query_inputEO>> GetByKeyTypeAsync(int keyType, int top_)
		{
			return await GetByKeyTypeAsync(keyType, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 KeyType（字段） 查询
		/// </summary>
		/// /// <param name = "keyType">类型1-游戏名2-分类3-keyword</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_query_inputEO> GetByKeyType(int keyType, int top_, TransactionManager tm_)
		{
			return GetByKeyType(keyType, top_, string.Empty, tm_);
		}
		public async Task<List<L_query_inputEO>> GetByKeyTypeAsync(int keyType, int top_, TransactionManager tm_)
		{
			return await GetByKeyTypeAsync(keyType, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 KeyType（字段） 查询
		/// </summary>
		/// /// <param name = "keyType">类型1-游戏名2-分类3-keyword</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_query_inputEO> GetByKeyType(int keyType, string sort_)
		{
			return GetByKeyType(keyType, 0, sort_, null);
		}
		public async Task<List<L_query_inputEO>> GetByKeyTypeAsync(int keyType, string sort_)
		{
			return await GetByKeyTypeAsync(keyType, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 KeyType（字段） 查询
		/// </summary>
		/// /// <param name = "keyType">类型1-游戏名2-分类3-keyword</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_query_inputEO> GetByKeyType(int keyType, string sort_, TransactionManager tm_)
		{
			return GetByKeyType(keyType, 0, sort_, tm_);
		}
		public async Task<List<L_query_inputEO>> GetByKeyTypeAsync(int keyType, string sort_, TransactionManager tm_)
		{
			return await GetByKeyTypeAsync(keyType, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 KeyType（字段） 查询
		/// </summary>
		/// /// <param name = "keyType">类型1-游戏名2-分类3-keyword</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_query_inputEO> GetByKeyType(int keyType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`KeyType` = @KeyType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@KeyType", keyType, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, L_query_inputEO.MapDataReader);
		}
		public async Task<List<L_query_inputEO>> GetByKeyTypeAsync(int keyType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`KeyType` = @KeyType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@KeyType", keyType, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_query_inputEO.MapDataReader);
		}
		#endregion // GetByKeyType
		#region GetByQueryKey
		
		/// <summary>
		/// 按 QueryKey（字段） 查询
		/// </summary>
		/// /// <param name = "queryKey">查询关键字</param>
		/// <return>实体对象集合</return>
		public List<L_query_inputEO> GetByQueryKey(string queryKey)
		{
			return GetByQueryKey(queryKey, 0, string.Empty, null);
		}
		public async Task<List<L_query_inputEO>> GetByQueryKeyAsync(string queryKey)
		{
			return await GetByQueryKeyAsync(queryKey, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 QueryKey（字段） 查询
		/// </summary>
		/// /// <param name = "queryKey">查询关键字</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_query_inputEO> GetByQueryKey(string queryKey, TransactionManager tm_)
		{
			return GetByQueryKey(queryKey, 0, string.Empty, tm_);
		}
		public async Task<List<L_query_inputEO>> GetByQueryKeyAsync(string queryKey, TransactionManager tm_)
		{
			return await GetByQueryKeyAsync(queryKey, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 QueryKey（字段） 查询
		/// </summary>
		/// /// <param name = "queryKey">查询关键字</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_query_inputEO> GetByQueryKey(string queryKey, int top_)
		{
			return GetByQueryKey(queryKey, top_, string.Empty, null);
		}
		public async Task<List<L_query_inputEO>> GetByQueryKeyAsync(string queryKey, int top_)
		{
			return await GetByQueryKeyAsync(queryKey, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 QueryKey（字段） 查询
		/// </summary>
		/// /// <param name = "queryKey">查询关键字</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_query_inputEO> GetByQueryKey(string queryKey, int top_, TransactionManager tm_)
		{
			return GetByQueryKey(queryKey, top_, string.Empty, tm_);
		}
		public async Task<List<L_query_inputEO>> GetByQueryKeyAsync(string queryKey, int top_, TransactionManager tm_)
		{
			return await GetByQueryKeyAsync(queryKey, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 QueryKey（字段） 查询
		/// </summary>
		/// /// <param name = "queryKey">查询关键字</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_query_inputEO> GetByQueryKey(string queryKey, string sort_)
		{
			return GetByQueryKey(queryKey, 0, sort_, null);
		}
		public async Task<List<L_query_inputEO>> GetByQueryKeyAsync(string queryKey, string sort_)
		{
			return await GetByQueryKeyAsync(queryKey, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 QueryKey（字段） 查询
		/// </summary>
		/// /// <param name = "queryKey">查询关键字</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_query_inputEO> GetByQueryKey(string queryKey, string sort_, TransactionManager tm_)
		{
			return GetByQueryKey(queryKey, 0, sort_, tm_);
		}
		public async Task<List<L_query_inputEO>> GetByQueryKeyAsync(string queryKey, string sort_, TransactionManager tm_)
		{
			return await GetByQueryKeyAsync(queryKey, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 QueryKey（字段） 查询
		/// </summary>
		/// /// <param name = "queryKey">查询关键字</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_query_inputEO> GetByQueryKey(string queryKey, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(queryKey != null ? "`QueryKey` = @QueryKey" : "`QueryKey` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (queryKey != null)
				paras_.Add(Database.CreateInParameter("@QueryKey", queryKey, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_query_inputEO.MapDataReader);
		}
		public async Task<List<L_query_inputEO>> GetByQueryKeyAsync(string queryKey, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(queryKey != null ? "`QueryKey` = @QueryKey" : "`QueryKey` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (queryKey != null)
				paras_.Add(Database.CreateInParameter("@QueryKey", queryKey, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_query_inputEO.MapDataReader);
		}
		#endregion // GetByQueryKey
		#region GetByAppID
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <return>实体对象集合</return>
		public List<L_query_inputEO> GetByAppID(string appID)
		{
			return GetByAppID(appID, 0, string.Empty, null);
		}
		public async Task<List<L_query_inputEO>> GetByAppIDAsync(string appID)
		{
			return await GetByAppIDAsync(appID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_query_inputEO> GetByAppID(string appID, TransactionManager tm_)
		{
			return GetByAppID(appID, 0, string.Empty, tm_);
		}
		public async Task<List<L_query_inputEO>> GetByAppIDAsync(string appID, TransactionManager tm_)
		{
			return await GetByAppIDAsync(appID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_query_inputEO> GetByAppID(string appID, int top_)
		{
			return GetByAppID(appID, top_, string.Empty, null);
		}
		public async Task<List<L_query_inputEO>> GetByAppIDAsync(string appID, int top_)
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
		public List<L_query_inputEO> GetByAppID(string appID, int top_, TransactionManager tm_)
		{
			return GetByAppID(appID, top_, string.Empty, tm_);
		}
		public async Task<List<L_query_inputEO>> GetByAppIDAsync(string appID, int top_, TransactionManager tm_)
		{
			return await GetByAppIDAsync(appID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_query_inputEO> GetByAppID(string appID, string sort_)
		{
			return GetByAppID(appID, 0, sort_, null);
		}
		public async Task<List<L_query_inputEO>> GetByAppIDAsync(string appID, string sort_)
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
		public List<L_query_inputEO> GetByAppID(string appID, string sort_, TransactionManager tm_)
		{
			return GetByAppID(appID, 0, sort_, tm_);
		}
		public async Task<List<L_query_inputEO>> GetByAppIDAsync(string appID, string sort_, TransactionManager tm_)
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
		public List<L_query_inputEO> GetByAppID(string appID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`AppID` = @AppID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_query_inputEO.MapDataReader);
		}
		public async Task<List<L_query_inputEO>> GetByAppIDAsync(string appID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`AppID` = @AppID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_query_inputEO.MapDataReader);
		}
		#endregion // GetByAppID
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
