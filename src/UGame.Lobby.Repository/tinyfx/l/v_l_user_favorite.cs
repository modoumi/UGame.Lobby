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
	/// 【视图 v_l_user_favorite 的实体类】
	/// </summary>
	[Serializable]
	[Obsolete]
	public class V_l_user_favoriteEO : IRowMapper<V_l_user_favoriteEO>
	{
		#region 所有字段
		/// <summary>
		/// 用户编码
		/// 【字段 varchar(38)】
		/// </summary>
		[DataMember(Order = 1)]
		public string UserID { get; set; }
		/// <summary>
		/// 类型1-玩过的（10条）2-收藏（20）
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 2)]
		public int Type { get; set; }
		/// <summary>
		/// 记录时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 3)]
		public DateTime RecDate { get; set; }
		/// <summary>
		/// 
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 4)]
		public string PrimaryKeyID { get; set; }
		/// <summary>
		/// 运营商编码
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 5)]
		public string OperatorID { get; set; }
		/// <summary>
		/// 
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 6)]
		public string AppID { get; set; }
		/// <summary>
		/// 应用标志 0-默认1-Hot2-New
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 7)]
		public int Flag { get; set; }
		/// <summary>
		/// 
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 8)]
		public string SmallIcon { get; set; }
		/// <summary>
		/// 
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 9)]
		public string MiddleIcon { get; set; }
		/// <summary>
		/// 
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 10)]
		public string BigIcon { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public V_l_user_favoriteEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static V_l_user_favoriteEO MapDataReader(IDataReader reader)
		{
		    V_l_user_favoriteEO ret = new V_l_user_favoriteEO();
			ret.UserID = reader.ToString("UserID");
			ret.Type = reader.ToInt32("Type");
			ret.RecDate = reader.ToDateTime("RecDate");
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
	/// 【视图 v_l_user_favorite 的操作类】
	/// </summary>
	[Obsolete]
	public class V_l_user_favoriteMO : MySqlViewMO<V_l_user_favoriteEO>
	{
		/// <summary>
		/// 视图名
		/// </summary>
	    public override string ViewName { get; set; } = "`v_l_user_favorite`"; 
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public V_l_user_favoriteMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public V_l_user_favoriteMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public V_l_user_favoriteMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
		#region Get
		#region GetByUserID
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <return>实体对象集合</return>
		public List<V_l_user_favoriteEO> GetByUserID(string userID)
		{
			return GetByUserID(userID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_user_favoriteEO> GetByUserID(string userID, TransactionManager tm_)
		{
			return GetByUserID(userID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_l_user_favoriteEO> GetByUserID(string userID, int top_)
		{
			return GetByUserID(userID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_user_favoriteEO> GetByUserID(string userID, int top_, TransactionManager tm_)
		{
			return GetByUserID(userID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_l_user_favoriteEO> GetByUserID(string userID, string sort_)
		{
			return GetByUserID(userID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_user_favoriteEO> GetByUserID(string userID, string sort_, TransactionManager tm_)
		{
			return GetByUserID(userID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_user_favoriteEO> GetByUserID(string userID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserID` = @UserID", top_, sort_);
			var parameter_ = Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_l_user_favoriteEO.MapDataReader);
		}
		#endregion // GetByUserID
		#region GetByType
		
		/// <summary>
		/// 按 Type（字段） 查询
		/// </summary>
		/// /// <param name = "type">类型1-玩过的（10条）2-收藏（20）</param>
		/// <return>实体对象集合</return>
		public List<V_l_user_favoriteEO> GetByType(int type)
		{
			return GetByType(type, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Type（字段） 查询
		/// </summary>
		/// /// <param name = "type">类型1-玩过的（10条）2-收藏（20）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_user_favoriteEO> GetByType(int type, TransactionManager tm_)
		{
			return GetByType(type, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Type（字段） 查询
		/// </summary>
		/// /// <param name = "type">类型1-玩过的（10条）2-收藏（20）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_l_user_favoriteEO> GetByType(int type, int top_)
		{
			return GetByType(type, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Type（字段） 查询
		/// </summary>
		/// /// <param name = "type">类型1-玩过的（10条）2-收藏（20）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_user_favoriteEO> GetByType(int type, int top_, TransactionManager tm_)
		{
			return GetByType(type, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Type（字段） 查询
		/// </summary>
		/// /// <param name = "type">类型1-玩过的（10条）2-收藏（20）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_l_user_favoriteEO> GetByType(int type, string sort_)
		{
			return GetByType(type, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Type（字段） 查询
		/// </summary>
		/// /// <param name = "type">类型1-玩过的（10条）2-收藏（20）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_user_favoriteEO> GetByType(int type, string sort_, TransactionManager tm_)
		{
			return GetByType(type, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Type（字段） 查询
		/// </summary>
		/// /// <param name = "type">类型1-玩过的（10条）2-收藏（20）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_user_favoriteEO> GetByType(int type, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Type` = @Type", top_, sort_);
			var parameter_ = Database.CreateInParameter("@Type", type, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_l_user_favoriteEO.MapDataReader);
		}
		#endregion // GetByType
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <return>实体对象集合</return>
		public List<V_l_user_favoriteEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_user_favoriteEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_l_user_favoriteEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_user_favoriteEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_l_user_favoriteEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_user_favoriteEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_user_favoriteEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var parameter_ = Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_l_user_favoriteEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#region GetByPrimaryKeyID
		
		/// <summary>
		/// 按 PrimaryKeyID（字段） 查询
		/// </summary>
		/// /// <param name = "primaryKeyID"></param>
		/// <return>实体对象集合</return>
		public List<V_l_user_favoriteEO> GetByPrimaryKeyID(string primaryKeyID)
		{
			return GetByPrimaryKeyID(primaryKeyID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PrimaryKeyID（字段） 查询
		/// </summary>
		/// /// <param name = "primaryKeyID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_user_favoriteEO> GetByPrimaryKeyID(string primaryKeyID, TransactionManager tm_)
		{
			return GetByPrimaryKeyID(primaryKeyID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PrimaryKeyID（字段） 查询
		/// </summary>
		/// /// <param name = "primaryKeyID"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_l_user_favoriteEO> GetByPrimaryKeyID(string primaryKeyID, int top_)
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
		public List<V_l_user_favoriteEO> GetByPrimaryKeyID(string primaryKeyID, int top_, TransactionManager tm_)
		{
			return GetByPrimaryKeyID(primaryKeyID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PrimaryKeyID（字段） 查询
		/// </summary>
		/// /// <param name = "primaryKeyID"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_l_user_favoriteEO> GetByPrimaryKeyID(string primaryKeyID, string sort_)
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
		public List<V_l_user_favoriteEO> GetByPrimaryKeyID(string primaryKeyID, string sort_, TransactionManager tm_)
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
		public List<V_l_user_favoriteEO> GetByPrimaryKeyID(string primaryKeyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PrimaryKeyID` = @PrimaryKeyID", top_, sort_);
			var parameter_ = Database.CreateInParameter("@PrimaryKeyID", primaryKeyID, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_l_user_favoriteEO.MapDataReader);
		}
		#endregion // GetByPrimaryKeyID
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <return>实体对象集合</return>
		public List<V_l_user_favoriteEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_user_favoriteEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_l_user_favoriteEO> GetByOperatorID(string operatorID, int top_)
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
		public List<V_l_user_favoriteEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_l_user_favoriteEO> GetByOperatorID(string operatorID, string sort_)
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
		public List<V_l_user_favoriteEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
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
		public List<V_l_user_favoriteEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var parameter_ = Database.CreateInParameter("@OperatorID", operatorID != null ? operatorID : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_l_user_favoriteEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByAppID
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID"></param>
		/// <return>实体对象集合</return>
		public List<V_l_user_favoriteEO> GetByAppID(string appID)
		{
			return GetByAppID(appID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_user_favoriteEO> GetByAppID(string appID, TransactionManager tm_)
		{
			return GetByAppID(appID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_l_user_favoriteEO> GetByAppID(string appID, int top_)
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
		public List<V_l_user_favoriteEO> GetByAppID(string appID, int top_, TransactionManager tm_)
		{
			return GetByAppID(appID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_l_user_favoriteEO> GetByAppID(string appID, string sort_)
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
		public List<V_l_user_favoriteEO> GetByAppID(string appID, string sort_, TransactionManager tm_)
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
		public List<V_l_user_favoriteEO> GetByAppID(string appID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`AppID` = @AppID", top_, sort_);
			var parameter_ = Database.CreateInParameter("@AppID", appID != null ? appID : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_l_user_favoriteEO.MapDataReader);
		}
		#endregion // GetByAppID
		#region GetByFlag
		
		/// <summary>
		/// 按 Flag（字段） 查询
		/// </summary>
		/// /// <param name = "flag">应用标志 0-默认1-Hot2-New</param>
		/// <return>实体对象集合</return>
		public List<V_l_user_favoriteEO> GetByFlag(int flag)
		{
			return GetByFlag(flag, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Flag（字段） 查询
		/// </summary>
		/// /// <param name = "flag">应用标志 0-默认1-Hot2-New</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_user_favoriteEO> GetByFlag(int flag, TransactionManager tm_)
		{
			return GetByFlag(flag, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Flag（字段） 查询
		/// </summary>
		/// /// <param name = "flag">应用标志 0-默认1-Hot2-New</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_l_user_favoriteEO> GetByFlag(int flag, int top_)
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
		public List<V_l_user_favoriteEO> GetByFlag(int flag, int top_, TransactionManager tm_)
		{
			return GetByFlag(flag, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Flag（字段） 查询
		/// </summary>
		/// /// <param name = "flag">应用标志 0-默认1-Hot2-New</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_l_user_favoriteEO> GetByFlag(int flag, string sort_)
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
		public List<V_l_user_favoriteEO> GetByFlag(int flag, string sort_, TransactionManager tm_)
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
		public List<V_l_user_favoriteEO> GetByFlag(int flag, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Flag` = @Flag", top_, sort_);
			var parameter_ = Database.CreateInParameter("@Flag", flag, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_l_user_favoriteEO.MapDataReader);
		}
		#endregion // GetByFlag
		#region GetBySmallIcon
		
		/// <summary>
		/// 按 SmallIcon（字段） 查询
		/// </summary>
		/// /// <param name = "smallIcon"></param>
		/// <return>实体对象集合</return>
		public List<V_l_user_favoriteEO> GetBySmallIcon(string smallIcon)
		{
			return GetBySmallIcon(smallIcon, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SmallIcon（字段） 查询
		/// </summary>
		/// /// <param name = "smallIcon"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_user_favoriteEO> GetBySmallIcon(string smallIcon, TransactionManager tm_)
		{
			return GetBySmallIcon(smallIcon, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SmallIcon（字段） 查询
		/// </summary>
		/// /// <param name = "smallIcon"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_l_user_favoriteEO> GetBySmallIcon(string smallIcon, int top_)
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
		public List<V_l_user_favoriteEO> GetBySmallIcon(string smallIcon, int top_, TransactionManager tm_)
		{
			return GetBySmallIcon(smallIcon, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SmallIcon（字段） 查询
		/// </summary>
		/// /// <param name = "smallIcon"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_l_user_favoriteEO> GetBySmallIcon(string smallIcon, string sort_)
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
		public List<V_l_user_favoriteEO> GetBySmallIcon(string smallIcon, string sort_, TransactionManager tm_)
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
		public List<V_l_user_favoriteEO> GetBySmallIcon(string smallIcon, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SmallIcon` = @SmallIcon", top_, sort_);
			var parameter_ = Database.CreateInParameter("@SmallIcon", smallIcon != null ? smallIcon : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_l_user_favoriteEO.MapDataReader);
		}
		#endregion // GetBySmallIcon
		#region GetByMiddleIcon
		
		/// <summary>
		/// 按 MiddleIcon（字段） 查询
		/// </summary>
		/// /// <param name = "middleIcon"></param>
		/// <return>实体对象集合</return>
		public List<V_l_user_favoriteEO> GetByMiddleIcon(string middleIcon)
		{
			return GetByMiddleIcon(middleIcon, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MiddleIcon（字段） 查询
		/// </summary>
		/// /// <param name = "middleIcon"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_user_favoriteEO> GetByMiddleIcon(string middleIcon, TransactionManager tm_)
		{
			return GetByMiddleIcon(middleIcon, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MiddleIcon（字段） 查询
		/// </summary>
		/// /// <param name = "middleIcon"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_l_user_favoriteEO> GetByMiddleIcon(string middleIcon, int top_)
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
		public List<V_l_user_favoriteEO> GetByMiddleIcon(string middleIcon, int top_, TransactionManager tm_)
		{
			return GetByMiddleIcon(middleIcon, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MiddleIcon（字段） 查询
		/// </summary>
		/// /// <param name = "middleIcon"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_l_user_favoriteEO> GetByMiddleIcon(string middleIcon, string sort_)
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
		public List<V_l_user_favoriteEO> GetByMiddleIcon(string middleIcon, string sort_, TransactionManager tm_)
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
		public List<V_l_user_favoriteEO> GetByMiddleIcon(string middleIcon, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`MiddleIcon` = @MiddleIcon", top_, sort_);
			var parameter_ = Database.CreateInParameter("@MiddleIcon", middleIcon != null ? middleIcon : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_l_user_favoriteEO.MapDataReader);
		}
		#endregion // GetByMiddleIcon
		#region GetByBigIcon
		
		/// <summary>
		/// 按 BigIcon（字段） 查询
		/// </summary>
		/// /// <param name = "bigIcon"></param>
		/// <return>实体对象集合</return>
		public List<V_l_user_favoriteEO> GetByBigIcon(string bigIcon)
		{
			return GetByBigIcon(bigIcon, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BigIcon（字段） 查询
		/// </summary>
		/// /// <param name = "bigIcon"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_user_favoriteEO> GetByBigIcon(string bigIcon, TransactionManager tm_)
		{
			return GetByBigIcon(bigIcon, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BigIcon（字段） 查询
		/// </summary>
		/// /// <param name = "bigIcon"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_l_user_favoriteEO> GetByBigIcon(string bigIcon, int top_)
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
		public List<V_l_user_favoriteEO> GetByBigIcon(string bigIcon, int top_, TransactionManager tm_)
		{
			return GetByBigIcon(bigIcon, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BigIcon（字段） 查询
		/// </summary>
		/// /// <param name = "bigIcon"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_l_user_favoriteEO> GetByBigIcon(string bigIcon, string sort_)
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
		public List<V_l_user_favoriteEO> GetByBigIcon(string bigIcon, string sort_, TransactionManager tm_)
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
		public List<V_l_user_favoriteEO> GetByBigIcon(string bigIcon, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BigIcon` = @BigIcon", top_, sort_);
			var parameter_ = Database.CreateInParameter("@BigIcon", bigIcon != null ? bigIcon : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_l_user_favoriteEO.MapDataReader);
		}
		#endregion // GetByBigIcon
		#endregion // Get
	}
	#endregion // MO
}
