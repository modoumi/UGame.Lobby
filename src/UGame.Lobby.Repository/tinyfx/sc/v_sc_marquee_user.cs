/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * AiUo代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/AiUo
 * 文档生成时间：2023-07-08 14: 33:49
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
	/// 【视图 v_sc_marquee_user 的实体类】
	/// </summary>
	[Serializable]
	public class V_sc_marquee_userEO : IRowMapper<V_sc_marquee_userEO>
	{
		#region 所有字段
		/// <summary>
		/// 跑马灯编码GUID
		/// 【字段 varchar(38)】
		/// </summary>
		[DataMember(Order = 1)]
		public string MarqueeID { get; set; }
		/// <summary>
		/// 用户编码(GUID)
		/// 【字段 varchar(38)】
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
		public V_sc_marquee_userEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static V_sc_marquee_userEO MapDataReader(IDataReader reader)
		{
		    V_sc_marquee_userEO ret = new V_sc_marquee_userEO();
			ret.MarqueeID = reader.ToString("MarqueeID");
			ret.UserID = reader.ToString("UserID");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 
	/// 【视图 v_sc_marquee_user 的操作类】
	/// </summary>
	public class V_sc_marquee_userMO : MySqlViewMO<V_sc_marquee_userEO>
	{
		/// <summary>
		/// 视图名
		/// </summary>
	    public override string ViewName { get; set; } = "`v_sc_marquee_user`"; 
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public V_sc_marquee_userMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public V_sc_marquee_userMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public V_sc_marquee_userMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
		#region Get
		#region GetByMarqueeID
		
		/// <summary>
		/// 按 MarqueeID（字段） 查询
		/// </summary>
		/// /// <param name = "marqueeID">跑马灯编码GUID</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marquee_userEO> GetByMarqueeID(string marqueeID)
		{
			return GetByMarqueeID(marqueeID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MarqueeID（字段） 查询
		/// </summary>
		/// /// <param name = "marqueeID">跑马灯编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marquee_userEO> GetByMarqueeID(string marqueeID, TransactionManager tm_)
		{
			return GetByMarqueeID(marqueeID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MarqueeID（字段） 查询
		/// </summary>
		/// /// <param name = "marqueeID">跑马灯编码GUID</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marquee_userEO> GetByMarqueeID(string marqueeID, int top_)
		{
			return GetByMarqueeID(marqueeID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MarqueeID（字段） 查询
		/// </summary>
		/// /// <param name = "marqueeID">跑马灯编码GUID</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marquee_userEO> GetByMarqueeID(string marqueeID, int top_, TransactionManager tm_)
		{
			return GetByMarqueeID(marqueeID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MarqueeID（字段） 查询
		/// </summary>
		/// /// <param name = "marqueeID">跑马灯编码GUID</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marquee_userEO> GetByMarqueeID(string marqueeID, string sort_)
		{
			return GetByMarqueeID(marqueeID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 MarqueeID（字段） 查询
		/// </summary>
		/// /// <param name = "marqueeID">跑马灯编码GUID</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marquee_userEO> GetByMarqueeID(string marqueeID, string sort_, TransactionManager tm_)
		{
			return GetByMarqueeID(marqueeID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 MarqueeID（字段） 查询
		/// </summary>
		/// /// <param name = "marqueeID">跑马灯编码GUID</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marquee_userEO> GetByMarqueeID(string marqueeID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`MarqueeID` = @MarqueeID", top_, sort_);
			var parameter_ = Database.CreateInParameter("@MarqueeID", marqueeID, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sc_marquee_userEO.MapDataReader);
		}
		#endregion // GetByMarqueeID
		#region GetByUserID
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marquee_userEO> GetByUserID(string userID)
		{
			return GetByUserID(userID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marquee_userEO> GetByUserID(string userID, TransactionManager tm_)
		{
			return GetByUserID(userID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marquee_userEO> GetByUserID(string userID, int top_)
		{
			return GetByUserID(userID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marquee_userEO> GetByUserID(string userID, int top_, TransactionManager tm_)
		{
			return GetByUserID(userID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marquee_userEO> GetByUserID(string userID, string sort_)
		{
			return GetByUserID(userID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marquee_userEO> GetByUserID(string userID, string sort_, TransactionManager tm_)
		{
			return GetByUserID(userID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marquee_userEO> GetByUserID(string userID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserID` = @UserID", top_, sort_);
			var parameter_ = Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sc_marquee_userEO.MapDataReader);
		}
		#endregion // GetByUserID
		#endregion // Get
	}
	#endregion // MO
}
