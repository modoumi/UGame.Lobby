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
	/// 【视图 v_l_keyword_app 的实体类】
	/// </summary>
	[Serializable]
	[Obsolete]
	public class V_l_keyword_appEO : IRowMapper<V_l_keyword_appEO>
	{
		#region 所有字段
		/// <summary>
		/// 关键词编码
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 1)]
		public long KeywordID { get; set; }
		/// <summary>
		/// 
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 2)]
		public string PrimaryKeyID { get; set; }
		/// <summary>
		/// 运营商编码
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 3)]
		public string OperatorID { get; set; }
		/// <summary>
		/// 
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 4)]
		public string AppID { get; set; }
		/// <summary>
		/// 应用标志 0-默认1-Hot2-New
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 5)]
		public int Flag { get; set; }
		/// <summary>
		/// 
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 6)]
		public string SmallIcon { get; set; }
		/// <summary>
		/// 
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 7)]
		public string MiddleIcon { get; set; }
		/// <summary>
		/// 
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 8)]
		public string BigIcon { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public V_l_keyword_appEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static V_l_keyword_appEO MapDataReader(IDataReader reader)
		{
		    V_l_keyword_appEO ret = new V_l_keyword_appEO();
			ret.KeywordID = reader.ToInt64("KeywordID");
			ret.PrimaryKeyID = reader.ToString("PrimaryKeyID");
			ret.OperatorID = reader.ToString("OperatorID");
			ret.AppID = reader.ToString("AppID");
			ret.Flag = reader.ToInt32("Flag");
			ret.SmallIcon = reader.ToString("SmallIcon");
			ret.MiddleIcon = reader.ToString("MiddleIcon");
			ret.BigIcon = reader.ToString("BigIcon");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 
	/// 【视图 v_l_keyword_app 的操作类】
	/// </summary>
	[Obsolete]
	public class V_l_keyword_appMO : MySqlViewMO<V_l_keyword_appEO>
	{
		/// <summary>
		/// 视图名
		/// </summary>
	    public override string ViewName { get; set; } = "`v_l_keyword_app`"; 
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public V_l_keyword_appMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public V_l_keyword_appMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public V_l_keyword_appMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
		#region Get
		#region GetByKeywordID
		
		/// <summary>
		/// 按 KeywordID（字段） 查询
		/// </summary>
		/// /// <param name = "keywordID">关键词编码</param>
		/// <return>实体对象集合</return>
		public List<V_l_keyword_appEO> GetByKeywordID(long keywordID)
		{
			return GetByKeywordID(keywordID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 KeywordID（字段） 查询
		/// </summary>
		/// /// <param name = "keywordID">关键词编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_keyword_appEO> GetByKeywordID(long keywordID, TransactionManager tm_)
		{
			return GetByKeywordID(keywordID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 KeywordID（字段） 查询
		/// </summary>
		/// /// <param name = "keywordID">关键词编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_l_keyword_appEO> GetByKeywordID(long keywordID, int top_)
		{
			return GetByKeywordID(keywordID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 KeywordID（字段） 查询
		/// </summary>
		/// /// <param name = "keywordID">关键词编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_keyword_appEO> GetByKeywordID(long keywordID, int top_, TransactionManager tm_)
		{
			return GetByKeywordID(keywordID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 KeywordID（字段） 查询
		/// </summary>
		/// /// <param name = "keywordID">关键词编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_l_keyword_appEO> GetByKeywordID(long keywordID, string sort_)
		{
			return GetByKeywordID(keywordID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 KeywordID（字段） 查询
		/// </summary>
		/// /// <param name = "keywordID">关键词编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_keyword_appEO> GetByKeywordID(long keywordID, string sort_, TransactionManager tm_)
		{
			return GetByKeywordID(keywordID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 KeywordID（字段） 查询
		/// </summary>
		/// /// <param name = "keywordID">关键词编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_keyword_appEO> GetByKeywordID(long keywordID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`KeywordID` = @KeywordID", top_, sort_);
			var parameter_ = Database.CreateInParameter("@KeywordID", keywordID, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_l_keyword_appEO.MapDataReader);
		}
		#endregion // GetByKeywordID
		#region GetByPrimaryKeyID
		
		/// <summary>
		/// 按 PrimaryKeyID（字段） 查询
		/// </summary>
		/// /// <param name = "primaryKeyID"></param>
		/// <return>实体对象集合</return>
		public List<V_l_keyword_appEO> GetByPrimaryKeyID(string primaryKeyID)
		{
			return GetByPrimaryKeyID(primaryKeyID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PrimaryKeyID（字段） 查询
		/// </summary>
		/// /// <param name = "primaryKeyID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_keyword_appEO> GetByPrimaryKeyID(string primaryKeyID, TransactionManager tm_)
		{
			return GetByPrimaryKeyID(primaryKeyID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PrimaryKeyID（字段） 查询
		/// </summary>
		/// /// <param name = "primaryKeyID"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_l_keyword_appEO> GetByPrimaryKeyID(string primaryKeyID, int top_)
		{
			return GetByPrimaryKeyID(primaryKeyID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PrimaryKeyID（字段） 查询
		/// </summary>
		/// /// <param name = "primaryKeyID"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_keyword_appEO> GetByPrimaryKeyID(string primaryKeyID, int top_, TransactionManager tm_)
		{
			return GetByPrimaryKeyID(primaryKeyID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PrimaryKeyID（字段） 查询
		/// </summary>
		/// /// <param name = "primaryKeyID"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_l_keyword_appEO> GetByPrimaryKeyID(string primaryKeyID, string sort_)
		{
			return GetByPrimaryKeyID(primaryKeyID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PrimaryKeyID（字段） 查询
		/// </summary>
		/// /// <param name = "primaryKeyID"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_keyword_appEO> GetByPrimaryKeyID(string primaryKeyID, string sort_, TransactionManager tm_)
		{
			return GetByPrimaryKeyID(primaryKeyID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PrimaryKeyID（字段） 查询
		/// </summary>
		/// /// <param name = "primaryKeyID"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_keyword_appEO> GetByPrimaryKeyID(string primaryKeyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PrimaryKeyID` = @PrimaryKeyID", top_, sort_);
			var parameter_ = Database.CreateInParameter("@PrimaryKeyID", primaryKeyID, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_l_keyword_appEO.MapDataReader);
		}
		#endregion // GetByPrimaryKeyID
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <return>实体对象集合</return>
		public List<V_l_keyword_appEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_keyword_appEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_l_keyword_appEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_keyword_appEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_l_keyword_appEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_keyword_appEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_keyword_appEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var parameter_ = Database.CreateInParameter("@OperatorID", operatorID != null ? operatorID : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_l_keyword_appEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByAppID
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID"></param>
		/// <return>实体对象集合</return>
		public List<V_l_keyword_appEO> GetByAppID(string appID)
		{
			return GetByAppID(appID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_keyword_appEO> GetByAppID(string appID, TransactionManager tm_)
		{
			return GetByAppID(appID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_l_keyword_appEO> GetByAppID(string appID, int top_)
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
		public List<V_l_keyword_appEO> GetByAppID(string appID, int top_, TransactionManager tm_)
		{
			return GetByAppID(appID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_l_keyword_appEO> GetByAppID(string appID, string sort_)
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
		public List<V_l_keyword_appEO> GetByAppID(string appID, string sort_, TransactionManager tm_)
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
		public List<V_l_keyword_appEO> GetByAppID(string appID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`AppID` = @AppID", top_, sort_);
			var parameter_ = Database.CreateInParameter("@AppID", appID != null ? appID : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_l_keyword_appEO.MapDataReader);
		}
		#endregion // GetByAppID
		#region GetByFlag
		
		/// <summary>
		/// 按 Flag（字段） 查询
		/// </summary>
		/// /// <param name = "flag">应用标志 0-默认1-Hot2-New</param>
		/// <return>实体对象集合</return>
		public List<V_l_keyword_appEO> GetByFlag(int flag)
		{
			return GetByFlag(flag, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Flag（字段） 查询
		/// </summary>
		/// /// <param name = "flag">应用标志 0-默认1-Hot2-New</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_keyword_appEO> GetByFlag(int flag, TransactionManager tm_)
		{
			return GetByFlag(flag, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Flag（字段） 查询
		/// </summary>
		/// /// <param name = "flag">应用标志 0-默认1-Hot2-New</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_l_keyword_appEO> GetByFlag(int flag, int top_)
		{
			return GetByFlag(flag, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Flag（字段） 查询
		/// </summary>
		/// /// <param name = "flag">应用标志 0-默认1-Hot2-New</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_keyword_appEO> GetByFlag(int flag, int top_, TransactionManager tm_)
		{
			return GetByFlag(flag, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Flag（字段） 查询
		/// </summary>
		/// /// <param name = "flag">应用标志 0-默认1-Hot2-New</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_l_keyword_appEO> GetByFlag(int flag, string sort_)
		{
			return GetByFlag(flag, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Flag（字段） 查询
		/// </summary>
		/// /// <param name = "flag">应用标志 0-默认1-Hot2-New</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_keyword_appEO> GetByFlag(int flag, string sort_, TransactionManager tm_)
		{
			return GetByFlag(flag, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Flag（字段） 查询
		/// </summary>
		/// /// <param name = "flag">应用标志 0-默认1-Hot2-New</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_keyword_appEO> GetByFlag(int flag, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Flag` = @Flag", top_, sort_);
			var parameter_ = Database.CreateInParameter("@Flag", flag, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_l_keyword_appEO.MapDataReader);
		}
		#endregion // GetByFlag
		#region GetBySmallIcon
		
		/// <summary>
		/// 按 SmallIcon（字段） 查询
		/// </summary>
		/// /// <param name = "smallIcon"></param>
		/// <return>实体对象集合</return>
		public List<V_l_keyword_appEO> GetBySmallIcon(string smallIcon)
		{
			return GetBySmallIcon(smallIcon, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SmallIcon（字段） 查询
		/// </summary>
		/// /// <param name = "smallIcon"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_keyword_appEO> GetBySmallIcon(string smallIcon, TransactionManager tm_)
		{
			return GetBySmallIcon(smallIcon, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SmallIcon（字段） 查询
		/// </summary>
		/// /// <param name = "smallIcon"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_l_keyword_appEO> GetBySmallIcon(string smallIcon, int top_)
		{
			return GetBySmallIcon(smallIcon, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SmallIcon（字段） 查询
		/// </summary>
		/// /// <param name = "smallIcon"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_keyword_appEO> GetBySmallIcon(string smallIcon, int top_, TransactionManager tm_)
		{
			return GetBySmallIcon(smallIcon, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SmallIcon（字段） 查询
		/// </summary>
		/// /// <param name = "smallIcon"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_l_keyword_appEO> GetBySmallIcon(string smallIcon, string sort_)
		{
			return GetBySmallIcon(smallIcon, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 SmallIcon（字段） 查询
		/// </summary>
		/// /// <param name = "smallIcon"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_keyword_appEO> GetBySmallIcon(string smallIcon, string sort_, TransactionManager tm_)
		{
			return GetBySmallIcon(smallIcon, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 SmallIcon（字段） 查询
		/// </summary>
		/// /// <param name = "smallIcon"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_keyword_appEO> GetBySmallIcon(string smallIcon, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SmallIcon` = @SmallIcon", top_, sort_);
			var parameter_ = Database.CreateInParameter("@SmallIcon", smallIcon != null ? smallIcon : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_l_keyword_appEO.MapDataReader);
		}
		#endregion // GetBySmallIcon
		#region GetByMiddleIcon
		
		/// <summary>
		/// 按 MiddleIcon（字段） 查询
		/// </summary>
		/// /// <param name = "middleIcon"></param>
		/// <return>实体对象集合</return>
		public List<V_l_keyword_appEO> GetByMiddleIcon(string middleIcon)
		{
			return GetByMiddleIcon(middleIcon, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MiddleIcon（字段） 查询
		/// </summary>
		/// /// <param name = "middleIcon"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_keyword_appEO> GetByMiddleIcon(string middleIcon, TransactionManager tm_)
		{
			return GetByMiddleIcon(middleIcon, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MiddleIcon（字段） 查询
		/// </summary>
		/// /// <param name = "middleIcon"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_l_keyword_appEO> GetByMiddleIcon(string middleIcon, int top_)
		{
			return GetByMiddleIcon(middleIcon, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MiddleIcon（字段） 查询
		/// </summary>
		/// /// <param name = "middleIcon"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_keyword_appEO> GetByMiddleIcon(string middleIcon, int top_, TransactionManager tm_)
		{
			return GetByMiddleIcon(middleIcon, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MiddleIcon（字段） 查询
		/// </summary>
		/// /// <param name = "middleIcon"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_l_keyword_appEO> GetByMiddleIcon(string middleIcon, string sort_)
		{
			return GetByMiddleIcon(middleIcon, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 MiddleIcon（字段） 查询
		/// </summary>
		/// /// <param name = "middleIcon"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_keyword_appEO> GetByMiddleIcon(string middleIcon, string sort_, TransactionManager tm_)
		{
			return GetByMiddleIcon(middleIcon, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 MiddleIcon（字段） 查询
		/// </summary>
		/// /// <param name = "middleIcon"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_keyword_appEO> GetByMiddleIcon(string middleIcon, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`MiddleIcon` = @MiddleIcon", top_, sort_);
			var parameter_ = Database.CreateInParameter("@MiddleIcon", middleIcon != null ? middleIcon : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_l_keyword_appEO.MapDataReader);
		}
		#endregion // GetByMiddleIcon
		#region GetByBigIcon
		
		/// <summary>
		/// 按 BigIcon（字段） 查询
		/// </summary>
		/// /// <param name = "bigIcon"></param>
		/// <return>实体对象集合</return>
		public List<V_l_keyword_appEO> GetByBigIcon(string bigIcon)
		{
			return GetByBigIcon(bigIcon, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BigIcon（字段） 查询
		/// </summary>
		/// /// <param name = "bigIcon"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_keyword_appEO> GetByBigIcon(string bigIcon, TransactionManager tm_)
		{
			return GetByBigIcon(bigIcon, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BigIcon（字段） 查询
		/// </summary>
		/// /// <param name = "bigIcon"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_l_keyword_appEO> GetByBigIcon(string bigIcon, int top_)
		{
			return GetByBigIcon(bigIcon, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BigIcon（字段） 查询
		/// </summary>
		/// /// <param name = "bigIcon"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_keyword_appEO> GetByBigIcon(string bigIcon, int top_, TransactionManager tm_)
		{
			return GetByBigIcon(bigIcon, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BigIcon（字段） 查询
		/// </summary>
		/// /// <param name = "bigIcon"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_l_keyword_appEO> GetByBigIcon(string bigIcon, string sort_)
		{
			return GetByBigIcon(bigIcon, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BigIcon（字段） 查询
		/// </summary>
		/// /// <param name = "bigIcon"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_keyword_appEO> GetByBigIcon(string bigIcon, string sort_, TransactionManager tm_)
		{
			return GetByBigIcon(bigIcon, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BigIcon（字段） 查询
		/// </summary>
		/// /// <param name = "bigIcon"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_keyword_appEO> GetByBigIcon(string bigIcon, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BigIcon` = @BigIcon", top_, sort_);
			var parameter_ = Database.CreateInParameter("@BigIcon", bigIcon != null ? bigIcon : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_l_keyword_appEO.MapDataReader);
		}
		#endregion // GetByBigIcon
		#endregion // Get
	}
	#endregion // MO
}
