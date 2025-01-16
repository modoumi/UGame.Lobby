/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * AiUo代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/AiUo
 * 文档生成时间：2023-10-24 18: 05:16
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
	/// 【视图 v_sc_marquee 的实体类】
	/// </summary>
	[Serializable]
	[Obsolete]
	public class V_sc_marqueeEO : IRowMapper<V_sc_marqueeEO>
	{
		#region 所有字段
		/// <summary>
		/// 跑马灯编码GUID
		/// 【字段 varchar(38)】
		/// </summary>
		[DataMember(Order = 1)]
		public string MarqueeID { get; set; }
		/// <summary>
		/// 应用编码
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 2)]
		public string AppID { get; set; }
		/// <summary>
		/// 使用位置（app客户端分别自定义）
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 3)]
		public int Position { get; set; }
		/// <summary>
		/// 运营商编码（null意味着默认）
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 4)]
		public string OperatorID { get; set; }
		/// <summary>
		/// 模板编码
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 5)]
		public int SCTemplateID { get; set; }
		/// <summary>
		/// 模板参数值
		/// 【字段 text】
		/// </summary>
		[DataMember(Order = 6)]
		public string SCTemplateParams { get; set; }
		/// <summary>
		/// 跳转路径
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 7)]
		public string LinkUrl { get; set; }
		/// <summary>
		/// 状态(0-无效1-有效)
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 8)]
		public int Status { get; set; }
		/// <summary>
		/// 记录时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 9)]
		public DateTime RecDate { get; set; }
		/// <summary>
		/// 语言代码
		/// 【字段 varchar(20)】
		/// </summary>
		[DataMember(Order = 10)]
		public string LangID { get; set; }
		/// <summary>
		/// 参数对应的实体类
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 11)]
		public string ParamsTypeName { get; set; }
		/// <summary>
		/// 应用程序集
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 12)]
		public string ParamsNameSpace { get; set; }
		/// <summary>
		/// 内容，如:恭喜{userId}你获得{amount}金额
		/// 【字段 text】
		/// </summary>
		[DataMember(Order = 13)]
		public string Content { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public V_sc_marqueeEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static V_sc_marqueeEO MapDataReader(IDataReader reader)
		{
		    V_sc_marqueeEO ret = new V_sc_marqueeEO();
			ret.MarqueeID = reader.ToString("MarqueeID");
			ret.AppID = reader.ToString("AppID");
			ret.Position = reader.ToInt32("Position");
			ret.OperatorID = reader.ToString("OperatorID");
			ret.SCTemplateID = reader.ToInt32("SCTemplateID");
			ret.SCTemplateParams = reader.ToString("SCTemplateParams");
			ret.LinkUrl = reader.ToString("LinkUrl");
			ret.Status = reader.ToInt32("Status");
			ret.RecDate = reader.ToDateTime("RecDate");
			ret.LangID = reader.ToString("LangID");
			ret.ParamsTypeName = reader.ToString("ParamsTypeName");
			ret.ParamsNameSpace = reader.ToString("ParamsNameSpace");
			ret.Content = reader.ToString("Content");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 
	/// 【视图 v_sc_marquee 的操作类】
	/// </summary>
	[Obsolete]
	public class V_sc_marqueeMO : MySqlViewMO<V_sc_marqueeEO>
	{
		/// <summary>
		/// 视图名
		/// </summary>
	    public override string ViewName { get; set; } = "`v_sc_marquee`"; 
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public V_sc_marqueeMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public V_sc_marqueeMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public V_sc_marqueeMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
		#region Get
		#region GetByMarqueeID
		
		/// <summary>
		/// 按 MarqueeID（字段） 查询
		/// </summary>
		/// /// <param name = "marqueeID">跑马灯编码GUID</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByMarqueeID(string marqueeID)
		{
			return GetByMarqueeID(marqueeID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MarqueeID（字段） 查询
		/// </summary>
		/// /// <param name = "marqueeID">跑马灯编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByMarqueeID(string marqueeID, TransactionManager tm_)
		{
			return GetByMarqueeID(marqueeID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MarqueeID（字段） 查询
		/// </summary>
		/// /// <param name = "marqueeID">跑马灯编码GUID</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByMarqueeID(string marqueeID, int top_)
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
		public List<V_sc_marqueeEO> GetByMarqueeID(string marqueeID, int top_, TransactionManager tm_)
		{
			return GetByMarqueeID(marqueeID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MarqueeID（字段） 查询
		/// </summary>
		/// /// <param name = "marqueeID">跑马灯编码GUID</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByMarqueeID(string marqueeID, string sort_)
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
		public List<V_sc_marqueeEO> GetByMarqueeID(string marqueeID, string sort_, TransactionManager tm_)
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
		public List<V_sc_marqueeEO> GetByMarqueeID(string marqueeID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`MarqueeID` = @MarqueeID", top_, sort_);
			var parameter_ = Database.CreateInParameter("@MarqueeID", marqueeID, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sc_marqueeEO.MapDataReader);
		}
		#endregion // GetByMarqueeID
		#region GetByAppID
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByAppID(string appID)
		{
			return GetByAppID(appID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByAppID(string appID, TransactionManager tm_)
		{
			return GetByAppID(appID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByAppID(string appID, int top_)
		{
			return GetByAppID(appID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByAppID(string appID, int top_, TransactionManager tm_)
		{
			return GetByAppID(appID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByAppID(string appID, string sort_)
		{
			return GetByAppID(appID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByAppID(string appID, string sort_, TransactionManager tm_)
		{
			return GetByAppID(appID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByAppID(string appID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`AppID` = @AppID", top_, sort_);
			var parameter_ = Database.CreateInParameter("@AppID", appID != null ? appID : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sc_marqueeEO.MapDataReader);
		}
		#endregion // GetByAppID
		#region GetByPosition
		
		/// <summary>
		/// 按 Position（字段） 查询
		/// </summary>
		/// /// <param name = "position">使用位置（app客户端分别自定义）</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByPosition(int position)
		{
			return GetByPosition(position, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Position（字段） 查询
		/// </summary>
		/// /// <param name = "position">使用位置（app客户端分别自定义）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByPosition(int position, TransactionManager tm_)
		{
			return GetByPosition(position, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Position（字段） 查询
		/// </summary>
		/// /// <param name = "position">使用位置（app客户端分别自定义）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByPosition(int position, int top_)
		{
			return GetByPosition(position, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Position（字段） 查询
		/// </summary>
		/// /// <param name = "position">使用位置（app客户端分别自定义）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByPosition(int position, int top_, TransactionManager tm_)
		{
			return GetByPosition(position, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Position（字段） 查询
		/// </summary>
		/// /// <param name = "position">使用位置（app客户端分别自定义）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByPosition(int position, string sort_)
		{
			return GetByPosition(position, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Position（字段） 查询
		/// </summary>
		/// /// <param name = "position">使用位置（app客户端分别自定义）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByPosition(int position, string sort_, TransactionManager tm_)
		{
			return GetByPosition(position, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Position（字段） 查询
		/// </summary>
		/// /// <param name = "position">使用位置（app客户端分别自定义）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByPosition(int position, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Position` = @Position", top_, sort_);
			var parameter_ = Database.CreateInParameter("@Position", position, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sc_marqueeEO.MapDataReader);
		}
		#endregion // GetByPosition
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（null意味着默认）</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（null意味着默认）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（null意味着默认）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（null意味着默认）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（null意味着默认）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（null意味着默认）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（null意味着默认）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var parameter_ = Database.CreateInParameter("@OperatorID", operatorID != null ? operatorID : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sc_marqueeEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetBySCTemplateID
		
		/// <summary>
		/// 按 SCTemplateID（字段） 查询
		/// </summary>
		/// /// <param name = "sCTemplateID">模板编码</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetBySCTemplateID(int sCTemplateID)
		{
			return GetBySCTemplateID(sCTemplateID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SCTemplateID（字段） 查询
		/// </summary>
		/// /// <param name = "sCTemplateID">模板编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetBySCTemplateID(int sCTemplateID, TransactionManager tm_)
		{
			return GetBySCTemplateID(sCTemplateID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SCTemplateID（字段） 查询
		/// </summary>
		/// /// <param name = "sCTemplateID">模板编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetBySCTemplateID(int sCTemplateID, int top_)
		{
			return GetBySCTemplateID(sCTemplateID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SCTemplateID（字段） 查询
		/// </summary>
		/// /// <param name = "sCTemplateID">模板编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetBySCTemplateID(int sCTemplateID, int top_, TransactionManager tm_)
		{
			return GetBySCTemplateID(sCTemplateID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SCTemplateID（字段） 查询
		/// </summary>
		/// /// <param name = "sCTemplateID">模板编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetBySCTemplateID(int sCTemplateID, string sort_)
		{
			return GetBySCTemplateID(sCTemplateID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 SCTemplateID（字段） 查询
		/// </summary>
		/// /// <param name = "sCTemplateID">模板编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetBySCTemplateID(int sCTemplateID, string sort_, TransactionManager tm_)
		{
			return GetBySCTemplateID(sCTemplateID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 SCTemplateID（字段） 查询
		/// </summary>
		/// /// <param name = "sCTemplateID">模板编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetBySCTemplateID(int sCTemplateID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SCTemplateID` = @SCTemplateID", top_, sort_);
			var parameter_ = Database.CreateInParameter("@SCTemplateID", sCTemplateID, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sc_marqueeEO.MapDataReader);
		}
		#endregion // GetBySCTemplateID
		#region GetBySCTemplateParams
		
		/// <summary>
		/// 按 SCTemplateParams（字段） 查询
		/// </summary>
		/// /// <param name = "sCTemplateParams">模板参数值</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetBySCTemplateParams(string sCTemplateParams)
		{
			return GetBySCTemplateParams(sCTemplateParams, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SCTemplateParams（字段） 查询
		/// </summary>
		/// /// <param name = "sCTemplateParams">模板参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetBySCTemplateParams(string sCTemplateParams, TransactionManager tm_)
		{
			return GetBySCTemplateParams(sCTemplateParams, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SCTemplateParams（字段） 查询
		/// </summary>
		/// /// <param name = "sCTemplateParams">模板参数值</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetBySCTemplateParams(string sCTemplateParams, int top_)
		{
			return GetBySCTemplateParams(sCTemplateParams, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SCTemplateParams（字段） 查询
		/// </summary>
		/// /// <param name = "sCTemplateParams">模板参数值</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetBySCTemplateParams(string sCTemplateParams, int top_, TransactionManager tm_)
		{
			return GetBySCTemplateParams(sCTemplateParams, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SCTemplateParams（字段） 查询
		/// </summary>
		/// /// <param name = "sCTemplateParams">模板参数值</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetBySCTemplateParams(string sCTemplateParams, string sort_)
		{
			return GetBySCTemplateParams(sCTemplateParams, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 SCTemplateParams（字段） 查询
		/// </summary>
		/// /// <param name = "sCTemplateParams">模板参数值</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetBySCTemplateParams(string sCTemplateParams, string sort_, TransactionManager tm_)
		{
			return GetBySCTemplateParams(sCTemplateParams, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 SCTemplateParams（字段） 查询
		/// </summary>
		/// /// <param name = "sCTemplateParams">模板参数值</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetBySCTemplateParams(string sCTemplateParams, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SCTemplateParams` = @SCTemplateParams", top_, sort_);
			var parameter_ = Database.CreateInParameter("@SCTemplateParams", sCTemplateParams != null ? sCTemplateParams : (object)DBNull.Value, MySqlDbType.Text);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sc_marqueeEO.MapDataReader);
		}
		#endregion // GetBySCTemplateParams
		#region GetByLinkUrl
		
		/// <summary>
		/// 按 LinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "linkUrl">跳转路径</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByLinkUrl(string linkUrl)
		{
			return GetByLinkUrl(linkUrl, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "linkUrl">跳转路径</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByLinkUrl(string linkUrl, TransactionManager tm_)
		{
			return GetByLinkUrl(linkUrl, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "linkUrl">跳转路径</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByLinkUrl(string linkUrl, int top_)
		{
			return GetByLinkUrl(linkUrl, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "linkUrl">跳转路径</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByLinkUrl(string linkUrl, int top_, TransactionManager tm_)
		{
			return GetByLinkUrl(linkUrl, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "linkUrl">跳转路径</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByLinkUrl(string linkUrl, string sort_)
		{
			return GetByLinkUrl(linkUrl, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "linkUrl">跳转路径</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByLinkUrl(string linkUrl, string sort_, TransactionManager tm_)
		{
			return GetByLinkUrl(linkUrl, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "linkUrl">跳转路径</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByLinkUrl(string linkUrl, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LinkUrl` = @LinkUrl", top_, sort_);
			var parameter_ = Database.CreateInParameter("@LinkUrl", linkUrl != null ? linkUrl : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sc_marqueeEO.MapDataReader);
		}
		#endregion // GetByLinkUrl
		#region GetByStatus
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByStatus(int status)
		{
			return GetByStatus(status, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByStatus(int status, TransactionManager tm_)
		{
			return GetByStatus(status, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByStatus(int status, int top_)
		{
			return GetByStatus(status, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByStatus(int status, int top_, TransactionManager tm_)
		{
			return GetByStatus(status, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByStatus(int status, string sort_)
		{
			return GetByStatus(status, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByStatus(int status, string sort_, TransactionManager tm_)
		{
			return GetByStatus(status, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByStatus(int status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
			var parameter_ = Database.CreateInParameter("@Status", status, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sc_marqueeEO.MapDataReader);
		}
		#endregion // GetByStatus
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByRecDate(DateTime recDate, int top_)
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
		public List<V_sc_marqueeEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByRecDate(DateTime recDate, string sort_)
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
		public List<V_sc_marqueeEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
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
		public List<V_sc_marqueeEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var parameter_ = Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sc_marqueeEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#region GetByLangID
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言代码</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByLangID(string langID)
		{
			return GetByLangID(langID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言代码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByLangID(string langID, TransactionManager tm_)
		{
			return GetByLangID(langID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言代码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByLangID(string langID, int top_)
		{
			return GetByLangID(langID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言代码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByLangID(string langID, int top_, TransactionManager tm_)
		{
			return GetByLangID(langID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言代码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByLangID(string langID, string sort_)
		{
			return GetByLangID(langID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言代码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByLangID(string langID, string sort_, TransactionManager tm_)
		{
			return GetByLangID(langID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言代码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByLangID(string langID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LangID` = @LangID", top_, sort_);
			var parameter_ = Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sc_marqueeEO.MapDataReader);
		}
		#endregion // GetByLangID
		#region GetByParamsTypeName
		
		/// <summary>
		/// 按 ParamsTypeName（字段） 查询
		/// </summary>
		/// /// <param name = "paramsTypeName">参数对应的实体类</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByParamsTypeName(string paramsTypeName)
		{
			return GetByParamsTypeName(paramsTypeName, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ParamsTypeName（字段） 查询
		/// </summary>
		/// /// <param name = "paramsTypeName">参数对应的实体类</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByParamsTypeName(string paramsTypeName, TransactionManager tm_)
		{
			return GetByParamsTypeName(paramsTypeName, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ParamsTypeName（字段） 查询
		/// </summary>
		/// /// <param name = "paramsTypeName">参数对应的实体类</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByParamsTypeName(string paramsTypeName, int top_)
		{
			return GetByParamsTypeName(paramsTypeName, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ParamsTypeName（字段） 查询
		/// </summary>
		/// /// <param name = "paramsTypeName">参数对应的实体类</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByParamsTypeName(string paramsTypeName, int top_, TransactionManager tm_)
		{
			return GetByParamsTypeName(paramsTypeName, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ParamsTypeName（字段） 查询
		/// </summary>
		/// /// <param name = "paramsTypeName">参数对应的实体类</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByParamsTypeName(string paramsTypeName, string sort_)
		{
			return GetByParamsTypeName(paramsTypeName, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ParamsTypeName（字段） 查询
		/// </summary>
		/// /// <param name = "paramsTypeName">参数对应的实体类</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByParamsTypeName(string paramsTypeName, string sort_, TransactionManager tm_)
		{
			return GetByParamsTypeName(paramsTypeName, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ParamsTypeName（字段） 查询
		/// </summary>
		/// /// <param name = "paramsTypeName">参数对应的实体类</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByParamsTypeName(string paramsTypeName, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ParamsTypeName` = @ParamsTypeName", top_, sort_);
			var parameter_ = Database.CreateInParameter("@ParamsTypeName", paramsTypeName != null ? paramsTypeName : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sc_marqueeEO.MapDataReader);
		}
		#endregion // GetByParamsTypeName
		#region GetByParamsNameSpace
		
		/// <summary>
		/// 按 ParamsNameSpace（字段） 查询
		/// </summary>
		/// /// <param name = "paramsNameSpace">应用程序集</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByParamsNameSpace(string paramsNameSpace)
		{
			return GetByParamsNameSpace(paramsNameSpace, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ParamsNameSpace（字段） 查询
		/// </summary>
		/// /// <param name = "paramsNameSpace">应用程序集</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByParamsNameSpace(string paramsNameSpace, TransactionManager tm_)
		{
			return GetByParamsNameSpace(paramsNameSpace, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ParamsNameSpace（字段） 查询
		/// </summary>
		/// /// <param name = "paramsNameSpace">应用程序集</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByParamsNameSpace(string paramsNameSpace, int top_)
		{
			return GetByParamsNameSpace(paramsNameSpace, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ParamsNameSpace（字段） 查询
		/// </summary>
		/// /// <param name = "paramsNameSpace">应用程序集</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByParamsNameSpace(string paramsNameSpace, int top_, TransactionManager tm_)
		{
			return GetByParamsNameSpace(paramsNameSpace, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ParamsNameSpace（字段） 查询
		/// </summary>
		/// /// <param name = "paramsNameSpace">应用程序集</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByParamsNameSpace(string paramsNameSpace, string sort_)
		{
			return GetByParamsNameSpace(paramsNameSpace, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ParamsNameSpace（字段） 查询
		/// </summary>
		/// /// <param name = "paramsNameSpace">应用程序集</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByParamsNameSpace(string paramsNameSpace, string sort_, TransactionManager tm_)
		{
			return GetByParamsNameSpace(paramsNameSpace, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ParamsNameSpace（字段） 查询
		/// </summary>
		/// /// <param name = "paramsNameSpace">应用程序集</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByParamsNameSpace(string paramsNameSpace, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ParamsNameSpace` = @ParamsNameSpace", top_, sort_);
			var parameter_ = Database.CreateInParameter("@ParamsNameSpace", paramsNameSpace != null ? paramsNameSpace : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sc_marqueeEO.MapDataReader);
		}
		#endregion // GetByParamsNameSpace
		#region GetByContent
		
		/// <summary>
		/// 按 Content（字段） 查询
		/// </summary>
		/// /// <param name = "content">内容，如:恭喜{userId}你获得{amount}金额</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByContent(string content)
		{
			return GetByContent(content, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Content（字段） 查询
		/// </summary>
		/// /// <param name = "content">内容，如:恭喜{userId}你获得{amount}金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByContent(string content, TransactionManager tm_)
		{
			return GetByContent(content, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Content（字段） 查询
		/// </summary>
		/// /// <param name = "content">内容，如:恭喜{userId}你获得{amount}金额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByContent(string content, int top_)
		{
			return GetByContent(content, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Content（字段） 查询
		/// </summary>
		/// /// <param name = "content">内容，如:恭喜{userId}你获得{amount}金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByContent(string content, int top_, TransactionManager tm_)
		{
			return GetByContent(content, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Content（字段） 查询
		/// </summary>
		/// /// <param name = "content">内容，如:恭喜{userId}你获得{amount}金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByContent(string content, string sort_)
		{
			return GetByContent(content, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Content（字段） 查询
		/// </summary>
		/// /// <param name = "content">内容，如:恭喜{userId}你获得{amount}金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByContent(string content, string sort_, TransactionManager tm_)
		{
			return GetByContent(content, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Content（字段） 查询
		/// </summary>
		/// /// <param name = "content">内容，如:恭喜{userId}你获得{amount}金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_marqueeEO> GetByContent(string content, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Content` = @Content", top_, sort_);
			var parameter_ = Database.CreateInParameter("@Content", content != null ? content : (object)DBNull.Value, MySqlDbType.Text);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sc_marqueeEO.MapDataReader);
		}
		#endregion // GetByContent
		#endregion // Get
	}
	#endregion // MO
}
