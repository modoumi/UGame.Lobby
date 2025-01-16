/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * AiUo代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/AiUo
 * 文档生成时间：2024-01-23 18: 29:13
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
	/// 【视图 v_l_category_detail 的实体类】
	/// </summary>
	[Serializable]
	[Obsolete]
	public class V_l_category_detailEO : IRowMapper<V_l_category_detailEO>
	{
		#region 所有字段
		/// <summary>
		/// 父节点ID
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 1)]
		public long ParentId { get; set; }
		/// <summary>
		/// 运营商编码(null为默认)
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 2)]
		public string OperatorID { get; set; }
		/// <summary>
		/// 排序（从小到大）
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 3)]
		public int CategoryOrderNum { get; set; }
		/// <summary>
		/// 显示模板
		/// 1、6*3
		/// 2、3*3
		/// 3、5*3
		/// 4、3*40
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 4)]
		public int Template { get; set; }
		/// <summary>
		/// 游戏分类图标
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 5)]
		public string CategoryIcon { get; set; }
		/// <summary>
		/// 语言代码
		/// 【字段 varchar(20)】
		/// </summary>
		[DataMember(Order = 6)]
		public string LangID { get; set; }
		/// <summary>
		/// 排序（从小到大）
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 7)]
		public int AppOrderNum { get; set; }
		/// <summary>
		/// 游戏分类
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 8)]
		public long CategoryID { get; set; }
		/// <summary>
		/// 分类名称
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 9)]
		public string CategoryName { get; set; }
		/// <summary>
		/// 应用编码
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 10)]
		public string AppID { get; set; }
		/// <summary>
		/// 应用标志 0-默认1-Hot2-New
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 11)]
		public int Flag { get; set; }
		/// <summary>
		/// 
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 12)]
		public string SmallIcon { get; set; }
		/// <summary>
		/// 
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 13)]
		public string MiddleIcon { get; set; }
		/// <summary>
		/// 
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 14)]
		public string BigIcon { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public V_l_category_detailEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static V_l_category_detailEO MapDataReader(IDataReader reader)
		{
		    V_l_category_detailEO ret = new V_l_category_detailEO();
			ret.ParentId = reader.ToInt64("ParentId");
			ret.OperatorID = reader.ToString("OperatorID");
			ret.CategoryOrderNum = reader.ToInt32("CategoryOrderNum");
			ret.Template = reader.ToInt32("Template");
			ret.CategoryIcon = reader.ToString("CategoryIcon");
			ret.LangID = reader.ToString("LangID");
			ret.AppOrderNum = reader.ToInt32("AppOrderNum");
			ret.CategoryID = reader.ToInt64("CategoryID");
			ret.CategoryName = reader.ToString("CategoryName");
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
	/// 【视图 v_l_category_detail 的操作类】
	/// </summary>
	[Obsolete]
	public class V_l_category_detailMO : MySqlViewMO<V_l_category_detailEO>
	{
		/// <summary>
		/// 视图名
		/// </summary>
	    public override string ViewName { get; set; } = "`v_l_category_detail`"; 
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public V_l_category_detailMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public V_l_category_detailMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public V_l_category_detailMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
		#region Get
		#region GetByParentId
		
		/// <summary>
		/// 按 ParentId（字段） 查询
		/// </summary>
		/// /// <param name = "parentId">父节点ID</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByParentId(long parentId)
		{
			return GetByParentId(parentId, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ParentId（字段） 查询
		/// </summary>
		/// /// <param name = "parentId">父节点ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByParentId(long parentId, TransactionManager tm_)
		{
			return GetByParentId(parentId, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ParentId（字段） 查询
		/// </summary>
		/// /// <param name = "parentId">父节点ID</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByParentId(long parentId, int top_)
		{
			return GetByParentId(parentId, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ParentId（字段） 查询
		/// </summary>
		/// /// <param name = "parentId">父节点ID</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByParentId(long parentId, int top_, TransactionManager tm_)
		{
			return GetByParentId(parentId, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ParentId（字段） 查询
		/// </summary>
		/// /// <param name = "parentId">父节点ID</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByParentId(long parentId, string sort_)
		{
			return GetByParentId(parentId, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ParentId（字段） 查询
		/// </summary>
		/// /// <param name = "parentId">父节点ID</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByParentId(long parentId, string sort_, TransactionManager tm_)
		{
			return GetByParentId(parentId, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ParentId（字段） 查询
		/// </summary>
		/// /// <param name = "parentId">父节点ID</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByParentId(long parentId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ParentId` = @ParentId", top_, sort_);
			var parameter_ = Database.CreateInParameter("@ParentId", parentId, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_l_category_detailEO.MapDataReader);
		}
		#endregion // GetByParentId
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码(null为默认)</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码(null为默认)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码(null为默认)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码(null为默认)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码(null为默认)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码(null为默认)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码(null为默认)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var parameter_ = Database.CreateInParameter("@OperatorID", operatorID != null ? operatorID : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_l_category_detailEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByCategoryOrderNum
		
		/// <summary>
		/// 按 CategoryOrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "categoryOrderNum">排序（从小到大）</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByCategoryOrderNum(int categoryOrderNum)
		{
			return GetByCategoryOrderNum(categoryOrderNum, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CategoryOrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "categoryOrderNum">排序（从小到大）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByCategoryOrderNum(int categoryOrderNum, TransactionManager tm_)
		{
			return GetByCategoryOrderNum(categoryOrderNum, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CategoryOrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "categoryOrderNum">排序（从小到大）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByCategoryOrderNum(int categoryOrderNum, int top_)
		{
			return GetByCategoryOrderNum(categoryOrderNum, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CategoryOrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "categoryOrderNum">排序（从小到大）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByCategoryOrderNum(int categoryOrderNum, int top_, TransactionManager tm_)
		{
			return GetByCategoryOrderNum(categoryOrderNum, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CategoryOrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "categoryOrderNum">排序（从小到大）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByCategoryOrderNum(int categoryOrderNum, string sort_)
		{
			return GetByCategoryOrderNum(categoryOrderNum, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CategoryOrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "categoryOrderNum">排序（从小到大）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByCategoryOrderNum(int categoryOrderNum, string sort_, TransactionManager tm_)
		{
			return GetByCategoryOrderNum(categoryOrderNum, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CategoryOrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "categoryOrderNum">排序（从小到大）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByCategoryOrderNum(int categoryOrderNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CategoryOrderNum` = @CategoryOrderNum", top_, sort_);
			var parameter_ = Database.CreateInParameter("@CategoryOrderNum", categoryOrderNum, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_l_category_detailEO.MapDataReader);
		}
		#endregion // GetByCategoryOrderNum
		#region GetByTemplate
		
		/// <summary>
		/// 按 Template（字段） 查询
		/// </summary>
		/// /// <param name = "template">显示模板</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByTemplate(int template)
		{
			return GetByTemplate(template, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Template（字段） 查询
		/// </summary>
		/// /// <param name = "template">显示模板</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByTemplate(int template, TransactionManager tm_)
		{
			return GetByTemplate(template, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Template（字段） 查询
		/// </summary>
		/// /// <param name = "template">显示模板</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByTemplate(int template, int top_)
		{
			return GetByTemplate(template, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Template（字段） 查询
		/// </summary>
		/// /// <param name = "template">显示模板</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByTemplate(int template, int top_, TransactionManager tm_)
		{
			return GetByTemplate(template, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Template（字段） 查询
		/// </summary>
		/// /// <param name = "template">显示模板</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByTemplate(int template, string sort_)
		{
			return GetByTemplate(template, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Template（字段） 查询
		/// </summary>
		/// /// <param name = "template">显示模板</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByTemplate(int template, string sort_, TransactionManager tm_)
		{
			return GetByTemplate(template, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Template（字段） 查询
		/// </summary>
		/// /// <param name = "template">显示模板</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByTemplate(int template, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Template` = @Template", top_, sort_);
			var parameter_ = Database.CreateInParameter("@Template", template, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_l_category_detailEO.MapDataReader);
		}
		#endregion // GetByTemplate
		#region GetByCategoryIcon
		
		/// <summary>
		/// 按 CategoryIcon（字段） 查询
		/// </summary>
		/// /// <param name = "categoryIcon">游戏分类图标</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByCategoryIcon(string categoryIcon)
		{
			return GetByCategoryIcon(categoryIcon, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CategoryIcon（字段） 查询
		/// </summary>
		/// /// <param name = "categoryIcon">游戏分类图标</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByCategoryIcon(string categoryIcon, TransactionManager tm_)
		{
			return GetByCategoryIcon(categoryIcon, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CategoryIcon（字段） 查询
		/// </summary>
		/// /// <param name = "categoryIcon">游戏分类图标</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByCategoryIcon(string categoryIcon, int top_)
		{
			return GetByCategoryIcon(categoryIcon, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CategoryIcon（字段） 查询
		/// </summary>
		/// /// <param name = "categoryIcon">游戏分类图标</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByCategoryIcon(string categoryIcon, int top_, TransactionManager tm_)
		{
			return GetByCategoryIcon(categoryIcon, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CategoryIcon（字段） 查询
		/// </summary>
		/// /// <param name = "categoryIcon">游戏分类图标</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByCategoryIcon(string categoryIcon, string sort_)
		{
			return GetByCategoryIcon(categoryIcon, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CategoryIcon（字段） 查询
		/// </summary>
		/// /// <param name = "categoryIcon">游戏分类图标</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByCategoryIcon(string categoryIcon, string sort_, TransactionManager tm_)
		{
			return GetByCategoryIcon(categoryIcon, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CategoryIcon（字段） 查询
		/// </summary>
		/// /// <param name = "categoryIcon">游戏分类图标</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByCategoryIcon(string categoryIcon, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CategoryIcon` = @CategoryIcon", top_, sort_);
			var parameter_ = Database.CreateInParameter("@CategoryIcon", categoryIcon, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_l_category_detailEO.MapDataReader);
		}
		#endregion // GetByCategoryIcon
		#region GetByLangID
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言代码</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByLangID(string langID)
		{
			return GetByLangID(langID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言代码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByLangID(string langID, TransactionManager tm_)
		{
			return GetByLangID(langID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言代码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByLangID(string langID, int top_)
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
		public List<V_l_category_detailEO> GetByLangID(string langID, int top_, TransactionManager tm_)
		{
			return GetByLangID(langID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言代码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByLangID(string langID, string sort_)
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
		public List<V_l_category_detailEO> GetByLangID(string langID, string sort_, TransactionManager tm_)
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
		public List<V_l_category_detailEO> GetByLangID(string langID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LangID` = @LangID", top_, sort_);
			var parameter_ = Database.CreateInParameter("@LangID", langID != null ? langID : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_l_category_detailEO.MapDataReader);
		}
		#endregion // GetByLangID
		#region GetByAppOrderNum
		
		/// <summary>
		/// 按 AppOrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "appOrderNum">排序（从小到大）</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByAppOrderNum(int appOrderNum)
		{
			return GetByAppOrderNum(appOrderNum, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AppOrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "appOrderNum">排序（从小到大）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByAppOrderNum(int appOrderNum, TransactionManager tm_)
		{
			return GetByAppOrderNum(appOrderNum, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppOrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "appOrderNum">排序（从小到大）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByAppOrderNum(int appOrderNum, int top_)
		{
			return GetByAppOrderNum(appOrderNum, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AppOrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "appOrderNum">排序（从小到大）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByAppOrderNum(int appOrderNum, int top_, TransactionManager tm_)
		{
			return GetByAppOrderNum(appOrderNum, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppOrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "appOrderNum">排序（从小到大）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByAppOrderNum(int appOrderNum, string sort_)
		{
			return GetByAppOrderNum(appOrderNum, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 AppOrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "appOrderNum">排序（从小到大）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByAppOrderNum(int appOrderNum, string sort_, TransactionManager tm_)
		{
			return GetByAppOrderNum(appOrderNum, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 AppOrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "appOrderNum">排序（从小到大）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByAppOrderNum(int appOrderNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`AppOrderNum` = @AppOrderNum", top_, sort_);
			var parameter_ = Database.CreateInParameter("@AppOrderNum", appOrderNum, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_l_category_detailEO.MapDataReader);
		}
		#endregion // GetByAppOrderNum
		#region GetByCategoryID
		
		/// <summary>
		/// 按 CategoryID（字段） 查询
		/// </summary>
		/// /// <param name = "categoryID">游戏分类</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByCategoryID(long categoryID)
		{
			return GetByCategoryID(categoryID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CategoryID（字段） 查询
		/// </summary>
		/// /// <param name = "categoryID">游戏分类</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByCategoryID(long categoryID, TransactionManager tm_)
		{
			return GetByCategoryID(categoryID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CategoryID（字段） 查询
		/// </summary>
		/// /// <param name = "categoryID">游戏分类</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByCategoryID(long categoryID, int top_)
		{
			return GetByCategoryID(categoryID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CategoryID（字段） 查询
		/// </summary>
		/// /// <param name = "categoryID">游戏分类</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByCategoryID(long categoryID, int top_, TransactionManager tm_)
		{
			return GetByCategoryID(categoryID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CategoryID（字段） 查询
		/// </summary>
		/// /// <param name = "categoryID">游戏分类</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByCategoryID(long categoryID, string sort_)
		{
			return GetByCategoryID(categoryID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CategoryID（字段） 查询
		/// </summary>
		/// /// <param name = "categoryID">游戏分类</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByCategoryID(long categoryID, string sort_, TransactionManager tm_)
		{
			return GetByCategoryID(categoryID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CategoryID（字段） 查询
		/// </summary>
		/// /// <param name = "categoryID">游戏分类</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByCategoryID(long categoryID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CategoryID` = @CategoryID", top_, sort_);
			var parameter_ = Database.CreateInParameter("@CategoryID", categoryID, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_l_category_detailEO.MapDataReader);
		}
		#endregion // GetByCategoryID
		#region GetByCategoryName
		
		/// <summary>
		/// 按 CategoryName（字段） 查询
		/// </summary>
		/// /// <param name = "categoryName">分类名称</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByCategoryName(string categoryName)
		{
			return GetByCategoryName(categoryName, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CategoryName（字段） 查询
		/// </summary>
		/// /// <param name = "categoryName">分类名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByCategoryName(string categoryName, TransactionManager tm_)
		{
			return GetByCategoryName(categoryName, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CategoryName（字段） 查询
		/// </summary>
		/// /// <param name = "categoryName">分类名称</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByCategoryName(string categoryName, int top_)
		{
			return GetByCategoryName(categoryName, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CategoryName（字段） 查询
		/// </summary>
		/// /// <param name = "categoryName">分类名称</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByCategoryName(string categoryName, int top_, TransactionManager tm_)
		{
			return GetByCategoryName(categoryName, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CategoryName（字段） 查询
		/// </summary>
		/// /// <param name = "categoryName">分类名称</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByCategoryName(string categoryName, string sort_)
		{
			return GetByCategoryName(categoryName, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CategoryName（字段） 查询
		/// </summary>
		/// /// <param name = "categoryName">分类名称</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByCategoryName(string categoryName, string sort_, TransactionManager tm_)
		{
			return GetByCategoryName(categoryName, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CategoryName（字段） 查询
		/// </summary>
		/// /// <param name = "categoryName">分类名称</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByCategoryName(string categoryName, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CategoryName` = @CategoryName", top_, sort_);
			var parameter_ = Database.CreateInParameter("@CategoryName", categoryName != null ? categoryName : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_l_category_detailEO.MapDataReader);
		}
		#endregion // GetByCategoryName
		#region GetByAppID
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByAppID(string appID)
		{
			return GetByAppID(appID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByAppID(string appID, TransactionManager tm_)
		{
			return GetByAppID(appID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByAppID(string appID, int top_)
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
		public List<V_l_category_detailEO> GetByAppID(string appID, int top_, TransactionManager tm_)
		{
			return GetByAppID(appID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByAppID(string appID, string sort_)
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
		public List<V_l_category_detailEO> GetByAppID(string appID, string sort_, TransactionManager tm_)
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
		public List<V_l_category_detailEO> GetByAppID(string appID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`AppID` = @AppID", top_, sort_);
			var parameter_ = Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_l_category_detailEO.MapDataReader);
		}
		#endregion // GetByAppID
		#region GetByFlag
		
		/// <summary>
		/// 按 Flag（字段） 查询
		/// </summary>
		/// /// <param name = "flag">应用标志 0-默认1-Hot2-New</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByFlag(int flag)
		{
			return GetByFlag(flag, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Flag（字段） 查询
		/// </summary>
		/// /// <param name = "flag">应用标志 0-默认1-Hot2-New</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByFlag(int flag, TransactionManager tm_)
		{
			return GetByFlag(flag, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Flag（字段） 查询
		/// </summary>
		/// /// <param name = "flag">应用标志 0-默认1-Hot2-New</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByFlag(int flag, int top_)
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
		public List<V_l_category_detailEO> GetByFlag(int flag, int top_, TransactionManager tm_)
		{
			return GetByFlag(flag, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Flag（字段） 查询
		/// </summary>
		/// /// <param name = "flag">应用标志 0-默认1-Hot2-New</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByFlag(int flag, string sort_)
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
		public List<V_l_category_detailEO> GetByFlag(int flag, string sort_, TransactionManager tm_)
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
		public List<V_l_category_detailEO> GetByFlag(int flag, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Flag` = @Flag", top_, sort_);
			var parameter_ = Database.CreateInParameter("@Flag", flag, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_l_category_detailEO.MapDataReader);
		}
		#endregion // GetByFlag
		#region GetBySmallIcon
		
		/// <summary>
		/// 按 SmallIcon（字段） 查询
		/// </summary>
		/// /// <param name = "smallIcon"></param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetBySmallIcon(string smallIcon)
		{
			return GetBySmallIcon(smallIcon, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SmallIcon（字段） 查询
		/// </summary>
		/// /// <param name = "smallIcon"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetBySmallIcon(string smallIcon, TransactionManager tm_)
		{
			return GetBySmallIcon(smallIcon, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SmallIcon（字段） 查询
		/// </summary>
		/// /// <param name = "smallIcon"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetBySmallIcon(string smallIcon, int top_)
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
		public List<V_l_category_detailEO> GetBySmallIcon(string smallIcon, int top_, TransactionManager tm_)
		{
			return GetBySmallIcon(smallIcon, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SmallIcon（字段） 查询
		/// </summary>
		/// /// <param name = "smallIcon"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetBySmallIcon(string smallIcon, string sort_)
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
		public List<V_l_category_detailEO> GetBySmallIcon(string smallIcon, string sort_, TransactionManager tm_)
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
		public List<V_l_category_detailEO> GetBySmallIcon(string smallIcon, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SmallIcon` = @SmallIcon", top_, sort_);
			var parameter_ = Database.CreateInParameter("@SmallIcon", smallIcon != null ? smallIcon : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_l_category_detailEO.MapDataReader);
		}
		#endregion // GetBySmallIcon
		#region GetByMiddleIcon
		
		/// <summary>
		/// 按 MiddleIcon（字段） 查询
		/// </summary>
		/// /// <param name = "middleIcon"></param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByMiddleIcon(string middleIcon)
		{
			return GetByMiddleIcon(middleIcon, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MiddleIcon（字段） 查询
		/// </summary>
		/// /// <param name = "middleIcon"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByMiddleIcon(string middleIcon, TransactionManager tm_)
		{
			return GetByMiddleIcon(middleIcon, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MiddleIcon（字段） 查询
		/// </summary>
		/// /// <param name = "middleIcon"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByMiddleIcon(string middleIcon, int top_)
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
		public List<V_l_category_detailEO> GetByMiddleIcon(string middleIcon, int top_, TransactionManager tm_)
		{
			return GetByMiddleIcon(middleIcon, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MiddleIcon（字段） 查询
		/// </summary>
		/// /// <param name = "middleIcon"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByMiddleIcon(string middleIcon, string sort_)
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
		public List<V_l_category_detailEO> GetByMiddleIcon(string middleIcon, string sort_, TransactionManager tm_)
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
		public List<V_l_category_detailEO> GetByMiddleIcon(string middleIcon, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`MiddleIcon` = @MiddleIcon", top_, sort_);
			var parameter_ = Database.CreateInParameter("@MiddleIcon", middleIcon != null ? middleIcon : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_l_category_detailEO.MapDataReader);
		}
		#endregion // GetByMiddleIcon
		#region GetByBigIcon
		
		/// <summary>
		/// 按 BigIcon（字段） 查询
		/// </summary>
		/// /// <param name = "bigIcon"></param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByBigIcon(string bigIcon)
		{
			return GetByBigIcon(bigIcon, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BigIcon（字段） 查询
		/// </summary>
		/// /// <param name = "bigIcon"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByBigIcon(string bigIcon, TransactionManager tm_)
		{
			return GetByBigIcon(bigIcon, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BigIcon（字段） 查询
		/// </summary>
		/// /// <param name = "bigIcon"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByBigIcon(string bigIcon, int top_)
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
		public List<V_l_category_detailEO> GetByBigIcon(string bigIcon, int top_, TransactionManager tm_)
		{
			return GetByBigIcon(bigIcon, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BigIcon（字段） 查询
		/// </summary>
		/// /// <param name = "bigIcon"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_l_category_detailEO> GetByBigIcon(string bigIcon, string sort_)
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
		public List<V_l_category_detailEO> GetByBigIcon(string bigIcon, string sort_, TransactionManager tm_)
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
		public List<V_l_category_detailEO> GetByBigIcon(string bigIcon, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BigIcon` = @BigIcon", top_, sort_);
			var parameter_ = Database.CreateInParameter("@BigIcon", bigIcon != null ? bigIcon : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_l_category_detailEO.MapDataReader);
		}
		#endregion // GetByBigIcon
		#endregion // Get
	}
	#endregion // MO
}
