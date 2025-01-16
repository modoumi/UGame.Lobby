/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * AiUo代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/AiUo
 * 文档生成时间：2023-10-24 18: 05:15
 ******************************************************/
using System;
using System.Data;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using AiUo;
using AiUo.Data;
using MySql.Data.MySqlClient;
using AiUo.Data.MySql;

namespace UGame.Lobby.Repository.ing
{
	#region EO
	/// <summary>
	/// 
	/// 【视图 v_l_query_input 的实体类】
	/// </summary>
	[Serializable]
	[Obsolete]
	public class V_l_query_inputEO : IRowMapper<V_l_query_inputEO>
	{
		#region 所有字段
		/// <summary>
		/// 
		/// 【字段 varchar(5)】
		/// </summary>
		[DataMember(Order = 1)]
		public string LangID { get; set; }
		/// <summary>
		/// 
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 2)]
		public long KeyType { get; set; }
		/// <summary>
		/// 
		/// 【字段 varchar(100)】
		/// </summary>
		[DataMember(Order = 3)]
		public string QueryKey { get; set; }
		/// <summary>
		/// 
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 4)]
		public string AppID { get; set; }
		/// <summary>
		/// 
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 5)]
		public string OperatorID { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public V_l_query_inputEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static V_l_query_inputEO MapDataReader(IDataReader reader)
		{
		    V_l_query_inputEO ret = new V_l_query_inputEO();
			ret.LangID = reader.ToString("LangID");
			ret.KeyType = reader.ToInt64("KeyType");
			ret.QueryKey = reader.ToString("QueryKey");
			ret.AppID = reader.ToString("AppID");
			ret.OperatorID = reader.ToString("OperatorID");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 
	/// 【视图 v_l_query_input 的操作类】
	/// </summary>
	[Obsolete]
	public class V_l_query_inputMO : MySqlViewMO<V_l_query_inputEO>
	{
		/// <summary>
		/// 视图名
		/// </summary>
	    public override string ViewName { get; set; } = "`v_l_query_input`"; 
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public V_l_query_inputMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public V_l_query_inputMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public V_l_query_inputMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
		#region Get
		#region GetByLangID
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID"></param>
		/// <return>实体对象集合</return>
		public List<V_l_query_inputEO> GetByLangID(string langID)
		{
			return GetByLangID(langID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_query_inputEO> GetByLangID(string langID, TransactionManager tm_)
		{
			return GetByLangID(langID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_l_query_inputEO> GetByLangID(string langID, int top_)
		{
			return GetByLangID(langID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_query_inputEO> GetByLangID(string langID, int top_, TransactionManager tm_)
		{
			return GetByLangID(langID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_l_query_inputEO> GetByLangID(string langID, string sort_)
		{
			return GetByLangID(langID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_query_inputEO> GetByLangID(string langID, string sort_, TransactionManager tm_)
		{
			return GetByLangID(langID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_query_inputEO> GetByLangID(string langID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LangID` = @LangID", top_, sort_);
			var parameter_ = Database.CreateInParameter("@LangID", langID != null ? langID : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_l_query_inputEO.MapDataReader);
		}
		#endregion // GetByLangID
		#region GetByKeyType
		
		/// <summary>
		/// 按 KeyType（字段） 查询
		/// </summary>
		/// /// <param name = "keyType"></param>
		/// <return>实体对象集合</return>
		public List<V_l_query_inputEO> GetByKeyType(long keyType)
		{
			return GetByKeyType(keyType, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 KeyType（字段） 查询
		/// </summary>
		/// /// <param name = "keyType"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_query_inputEO> GetByKeyType(long keyType, TransactionManager tm_)
		{
			return GetByKeyType(keyType, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 KeyType（字段） 查询
		/// </summary>
		/// /// <param name = "keyType"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_l_query_inputEO> GetByKeyType(long keyType, int top_)
		{
			return GetByKeyType(keyType, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 KeyType（字段） 查询
		/// </summary>
		/// /// <param name = "keyType"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_query_inputEO> GetByKeyType(long keyType, int top_, TransactionManager tm_)
		{
			return GetByKeyType(keyType, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 KeyType（字段） 查询
		/// </summary>
		/// /// <param name = "keyType"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_l_query_inputEO> GetByKeyType(long keyType, string sort_)
		{
			return GetByKeyType(keyType, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 KeyType（字段） 查询
		/// </summary>
		/// /// <param name = "keyType"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_query_inputEO> GetByKeyType(long keyType, string sort_, TransactionManager tm_)
		{
			return GetByKeyType(keyType, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 KeyType（字段） 查询
		/// </summary>
		/// /// <param name = "keyType"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_query_inputEO> GetByKeyType(long keyType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`KeyType` = @KeyType", top_, sort_);
			var parameter_ = Database.CreateInParameter("@KeyType", keyType, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_l_query_inputEO.MapDataReader);
		}
		#endregion // GetByKeyType
		#region GetByQueryKey
		
		/// <summary>
		/// 按 QueryKey（字段） 查询
		/// </summary>
		/// /// <param name = "queryKey"></param>
		/// <return>实体对象集合</return>
		public List<V_l_query_inputEO> GetByQueryKey(string queryKey)
		{
			return GetByQueryKey(queryKey, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 QueryKey（字段） 查询
		/// </summary>
		/// /// <param name = "queryKey"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_query_inputEO> GetByQueryKey(string queryKey, TransactionManager tm_)
		{
			return GetByQueryKey(queryKey, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 QueryKey（字段） 查询
		/// </summary>
		/// /// <param name = "queryKey"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_l_query_inputEO> GetByQueryKey(string queryKey, int top_)
		{
			return GetByQueryKey(queryKey, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 QueryKey（字段） 查询
		/// </summary>
		/// /// <param name = "queryKey"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_query_inputEO> GetByQueryKey(string queryKey, int top_, TransactionManager tm_)
		{
			return GetByQueryKey(queryKey, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 QueryKey（字段） 查询
		/// </summary>
		/// /// <param name = "queryKey"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_l_query_inputEO> GetByQueryKey(string queryKey, string sort_)
		{
			return GetByQueryKey(queryKey, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 QueryKey（字段） 查询
		/// </summary>
		/// /// <param name = "queryKey"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_query_inputEO> GetByQueryKey(string queryKey, string sort_, TransactionManager tm_)
		{
			return GetByQueryKey(queryKey, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 QueryKey（字段） 查询
		/// </summary>
		/// /// <param name = "queryKey"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_query_inputEO> GetByQueryKey(string queryKey, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`QueryKey` = @QueryKey", top_, sort_);
			var parameter_ = Database.CreateInParameter("@QueryKey", queryKey != null ? queryKey : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_l_query_inputEO.MapDataReader);
		}
		#endregion // GetByQueryKey
		#region GetByAppID
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID"></param>
		/// <return>实体对象集合</return>
		public List<V_l_query_inputEO> GetByAppID(string appID)
		{
			return GetByAppID(appID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_query_inputEO> GetByAppID(string appID, TransactionManager tm_)
		{
			return GetByAppID(appID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_l_query_inputEO> GetByAppID(string appID, int top_)
		{
			return GetByAppID(appID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_query_inputEO> GetByAppID(string appID, int top_, TransactionManager tm_)
		{
			return GetByAppID(appID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_l_query_inputEO> GetByAppID(string appID, string sort_)
		{
			return GetByAppID(appID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_query_inputEO> GetByAppID(string appID, string sort_, TransactionManager tm_)
		{
			return GetByAppID(appID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_query_inputEO> GetByAppID(string appID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`AppID` = @AppID", top_, sort_);
			var parameter_ = Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_l_query_inputEO.MapDataReader);
		}
		#endregion // GetByAppID
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID"></param>
		/// <return>实体对象集合</return>
		public List<V_l_query_inputEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_query_inputEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_l_query_inputEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_query_inputEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_l_query_inputEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_query_inputEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_query_inputEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var parameter_ = Database.CreateInParameter("@OperatorID", operatorID != null ? operatorID : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_l_query_inputEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#endregion // Get
	}
	#endregion // MO
}
