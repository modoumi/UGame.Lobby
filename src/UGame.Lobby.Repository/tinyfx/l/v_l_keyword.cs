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
	/// 【视图 v_l_keyword 的实体类】
	/// </summary>
	[Serializable]
	[Obsolete]
	public class V_l_keywordEO : IRowMapper<V_l_keywordEO>
	{
		#region 所有字段
		/// <summary>
		/// 
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 1)]
		public long KeywordID { get; set; }
		/// <summary>
		/// 运营商编码(null意味着默认)
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 2)]
		public string OperatorID { get; set; }
		/// <summary>
		/// 语言代码
		/// 【字段 varchar(20)】
		/// </summary>
		[DataMember(Order = 3)]
		public string LangID { get; set; }
		/// <summary>
		/// 关键字名称
		/// 【字段 varchar(100)】
		/// </summary>
		[DataMember(Order = 4)]
		public string Title { get; set; }
		/// <summary>
		/// 排序
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 5)]
		public int OrderNum { get; set; }
		/// <summary>
		/// 分类编码
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 6)]
		public long KCID { get; set; }
		/// <summary>
		/// 状态(0-无效1-有效)
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 7)]
		public int Status { get; set; }
		/// <summary>
		/// 记录时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 8)]
		public DateTime RecDate { get; set; }
		/// <summary>
		/// 名称
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 9)]
		public string KCName { get; set; }
		/// <summary>
		/// 排序
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 10)]
		public int KCOrderNum { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public V_l_keywordEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static V_l_keywordEO MapDataReader(IDataReader reader)
		{
		    V_l_keywordEO ret = new V_l_keywordEO();
			ret.KeywordID = reader.ToInt64("KeywordID");
			ret.OperatorID = reader.ToString("OperatorID");
			ret.LangID = reader.ToString("LangID");
			ret.Title = reader.ToString("Title");
			ret.OrderNum = reader.ToInt32("OrderNum");
			ret.KCID = reader.ToInt64("KCID");
			ret.Status = reader.ToInt32("Status");
			ret.RecDate = reader.ToDateTime("RecDate");
			ret.KCName = reader.ToString("KCName");
			ret.KCOrderNum = reader.ToInt32("KCOrderNum");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 
	/// 【视图 v_l_keyword 的操作类】
	/// </summary>
	[Obsolete]
	public class V_l_keywordMO : MySqlViewMO<V_l_keywordEO>
	{
		/// <summary>
		/// 视图名
		/// </summary>
	    public override string ViewName { get; set; } = "`v_l_keyword`"; 
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public V_l_keywordMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public V_l_keywordMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public V_l_keywordMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
		#region Get
		#region GetByKeywordID
		
		/// <summary>
		/// 按 KeywordID（字段） 查询
		/// </summary>
		/// /// <param name = "keywordID"></param>
		/// <return>实体对象集合</return>
		public List<V_l_keywordEO> GetByKeywordID(long keywordID)
		{
			return GetByKeywordID(keywordID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 KeywordID（字段） 查询
		/// </summary>
		/// /// <param name = "keywordID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_keywordEO> GetByKeywordID(long keywordID, TransactionManager tm_)
		{
			return GetByKeywordID(keywordID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 KeywordID（字段） 查询
		/// </summary>
		/// /// <param name = "keywordID"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_l_keywordEO> GetByKeywordID(long keywordID, int top_)
		{
			return GetByKeywordID(keywordID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 KeywordID（字段） 查询
		/// </summary>
		/// /// <param name = "keywordID"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_keywordEO> GetByKeywordID(long keywordID, int top_, TransactionManager tm_)
		{
			return GetByKeywordID(keywordID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 KeywordID（字段） 查询
		/// </summary>
		/// /// <param name = "keywordID"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_l_keywordEO> GetByKeywordID(long keywordID, string sort_)
		{
			return GetByKeywordID(keywordID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 KeywordID（字段） 查询
		/// </summary>
		/// /// <param name = "keywordID"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_keywordEO> GetByKeywordID(long keywordID, string sort_, TransactionManager tm_)
		{
			return GetByKeywordID(keywordID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 KeywordID（字段） 查询
		/// </summary>
		/// /// <param name = "keywordID"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_keywordEO> GetByKeywordID(long keywordID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`KeywordID` = @KeywordID", top_, sort_);
			var parameter_ = Database.CreateInParameter("@KeywordID", keywordID, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_l_keywordEO.MapDataReader);
		}
		#endregion // GetByKeywordID
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码(null意味着默认)</param>
		/// <return>实体对象集合</return>
		public List<V_l_keywordEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码(null意味着默认)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_keywordEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码(null意味着默认)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_l_keywordEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码(null意味着默认)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_keywordEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码(null意味着默认)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_l_keywordEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码(null意味着默认)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_keywordEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码(null意味着默认)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_keywordEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var parameter_ = Database.CreateInParameter("@OperatorID", operatorID != null ? operatorID : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_l_keywordEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByLangID
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言代码</param>
		/// <return>实体对象集合</return>
		public List<V_l_keywordEO> GetByLangID(string langID)
		{
			return GetByLangID(langID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言代码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_keywordEO> GetByLangID(string langID, TransactionManager tm_)
		{
			return GetByLangID(langID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言代码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_l_keywordEO> GetByLangID(string langID, int top_)
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
		public List<V_l_keywordEO> GetByLangID(string langID, int top_, TransactionManager tm_)
		{
			return GetByLangID(langID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言代码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_l_keywordEO> GetByLangID(string langID, string sort_)
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
		public List<V_l_keywordEO> GetByLangID(string langID, string sort_, TransactionManager tm_)
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
		public List<V_l_keywordEO> GetByLangID(string langID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LangID` = @LangID", top_, sort_);
			var parameter_ = Database.CreateInParameter("@LangID", langID != null ? langID : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_l_keywordEO.MapDataReader);
		}
		#endregion // GetByLangID
		#region GetByTitle
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">关键字名称</param>
		/// <return>实体对象集合</return>
		public List<V_l_keywordEO> GetByTitle(string title)
		{
			return GetByTitle(title, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">关键字名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_keywordEO> GetByTitle(string title, TransactionManager tm_)
		{
			return GetByTitle(title, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">关键字名称</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_l_keywordEO> GetByTitle(string title, int top_)
		{
			return GetByTitle(title, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">关键字名称</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_keywordEO> GetByTitle(string title, int top_, TransactionManager tm_)
		{
			return GetByTitle(title, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">关键字名称</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_l_keywordEO> GetByTitle(string title, string sort_)
		{
			return GetByTitle(title, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">关键字名称</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_keywordEO> GetByTitle(string title, string sort_, TransactionManager tm_)
		{
			return GetByTitle(title, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">关键字名称</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_keywordEO> GetByTitle(string title, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Title` = @Title", top_, sort_);
			var parameter_ = Database.CreateInParameter("@Title", title != null ? title : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_l_keywordEO.MapDataReader);
		}
		#endregion // GetByTitle
		#region GetByOrderNum
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序</param>
		/// <return>实体对象集合</return>
		public List<V_l_keywordEO> GetByOrderNum(int orderNum)
		{
			return GetByOrderNum(orderNum, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_keywordEO> GetByOrderNum(int orderNum, TransactionManager tm_)
		{
			return GetByOrderNum(orderNum, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_l_keywordEO> GetByOrderNum(int orderNum, int top_)
		{
			return GetByOrderNum(orderNum, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_keywordEO> GetByOrderNum(int orderNum, int top_, TransactionManager tm_)
		{
			return GetByOrderNum(orderNum, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_l_keywordEO> GetByOrderNum(int orderNum, string sort_)
		{
			return GetByOrderNum(orderNum, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_keywordEO> GetByOrderNum(int orderNum, string sort_, TransactionManager tm_)
		{
			return GetByOrderNum(orderNum, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_keywordEO> GetByOrderNum(int orderNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OrderNum` = @OrderNum", top_, sort_);
			var parameter_ = Database.CreateInParameter("@OrderNum", orderNum, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_l_keywordEO.MapDataReader);
		}
		#endregion // GetByOrderNum
		#region GetByKCID
		
		/// <summary>
		/// 按 KCID（字段） 查询
		/// </summary>
		/// /// <param name = "kCID">分类编码</param>
		/// <return>实体对象集合</return>
		public List<V_l_keywordEO> GetByKCID(long kCID)
		{
			return GetByKCID(kCID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 KCID（字段） 查询
		/// </summary>
		/// /// <param name = "kCID">分类编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_keywordEO> GetByKCID(long kCID, TransactionManager tm_)
		{
			return GetByKCID(kCID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 KCID（字段） 查询
		/// </summary>
		/// /// <param name = "kCID">分类编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_l_keywordEO> GetByKCID(long kCID, int top_)
		{
			return GetByKCID(kCID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 KCID（字段） 查询
		/// </summary>
		/// /// <param name = "kCID">分类编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_keywordEO> GetByKCID(long kCID, int top_, TransactionManager tm_)
		{
			return GetByKCID(kCID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 KCID（字段） 查询
		/// </summary>
		/// /// <param name = "kCID">分类编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_l_keywordEO> GetByKCID(long kCID, string sort_)
		{
			return GetByKCID(kCID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 KCID（字段） 查询
		/// </summary>
		/// /// <param name = "kCID">分类编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_keywordEO> GetByKCID(long kCID, string sort_, TransactionManager tm_)
		{
			return GetByKCID(kCID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 KCID（字段） 查询
		/// </summary>
		/// /// <param name = "kCID">分类编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_keywordEO> GetByKCID(long kCID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`KCID` = @KCID", top_, sort_);
			var parameter_ = Database.CreateInParameter("@KCID", kCID, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_l_keywordEO.MapDataReader);
		}
		#endregion // GetByKCID
		#region GetByStatus
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <return>实体对象集合</return>
		public List<V_l_keywordEO> GetByStatus(int status)
		{
			return GetByStatus(status, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_keywordEO> GetByStatus(int status, TransactionManager tm_)
		{
			return GetByStatus(status, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_l_keywordEO> GetByStatus(int status, int top_)
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
		public List<V_l_keywordEO> GetByStatus(int status, int top_, TransactionManager tm_)
		{
			return GetByStatus(status, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_l_keywordEO> GetByStatus(int status, string sort_)
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
		public List<V_l_keywordEO> GetByStatus(int status, string sort_, TransactionManager tm_)
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
		public List<V_l_keywordEO> GetByStatus(int status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
			var parameter_ = Database.CreateInParameter("@Status", status, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_l_keywordEO.MapDataReader);
		}
		#endregion // GetByStatus
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <return>实体对象集合</return>
		public List<V_l_keywordEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_keywordEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_l_keywordEO> GetByRecDate(DateTime recDate, int top_)
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
		public List<V_l_keywordEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_l_keywordEO> GetByRecDate(DateTime recDate, string sort_)
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
		public List<V_l_keywordEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
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
		public List<V_l_keywordEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var parameter_ = Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_l_keywordEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#region GetByKCName
		
		/// <summary>
		/// 按 KCName（字段） 查询
		/// </summary>
		/// /// <param name = "kCName">名称</param>
		/// <return>实体对象集合</return>
		public List<V_l_keywordEO> GetByKCName(string kCName)
		{
			return GetByKCName(kCName, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 KCName（字段） 查询
		/// </summary>
		/// /// <param name = "kCName">名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_keywordEO> GetByKCName(string kCName, TransactionManager tm_)
		{
			return GetByKCName(kCName, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 KCName（字段） 查询
		/// </summary>
		/// /// <param name = "kCName">名称</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_l_keywordEO> GetByKCName(string kCName, int top_)
		{
			return GetByKCName(kCName, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 KCName（字段） 查询
		/// </summary>
		/// /// <param name = "kCName">名称</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_keywordEO> GetByKCName(string kCName, int top_, TransactionManager tm_)
		{
			return GetByKCName(kCName, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 KCName（字段） 查询
		/// </summary>
		/// /// <param name = "kCName">名称</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_l_keywordEO> GetByKCName(string kCName, string sort_)
		{
			return GetByKCName(kCName, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 KCName（字段） 查询
		/// </summary>
		/// /// <param name = "kCName">名称</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_keywordEO> GetByKCName(string kCName, string sort_, TransactionManager tm_)
		{
			return GetByKCName(kCName, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 KCName（字段） 查询
		/// </summary>
		/// /// <param name = "kCName">名称</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_keywordEO> GetByKCName(string kCName, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`KCName` = @KCName", top_, sort_);
			var parameter_ = Database.CreateInParameter("@KCName", kCName != null ? kCName : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_l_keywordEO.MapDataReader);
		}
		#endregion // GetByKCName
		#region GetByKCOrderNum
		
		/// <summary>
		/// 按 KCOrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "kCOrderNum">排序</param>
		/// <return>实体对象集合</return>
		public List<V_l_keywordEO> GetByKCOrderNum(int kCOrderNum)
		{
			return GetByKCOrderNum(kCOrderNum, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 KCOrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "kCOrderNum">排序</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_keywordEO> GetByKCOrderNum(int kCOrderNum, TransactionManager tm_)
		{
			return GetByKCOrderNum(kCOrderNum, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 KCOrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "kCOrderNum">排序</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_l_keywordEO> GetByKCOrderNum(int kCOrderNum, int top_)
		{
			return GetByKCOrderNum(kCOrderNum, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 KCOrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "kCOrderNum">排序</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_keywordEO> GetByKCOrderNum(int kCOrderNum, int top_, TransactionManager tm_)
		{
			return GetByKCOrderNum(kCOrderNum, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 KCOrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "kCOrderNum">排序</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_l_keywordEO> GetByKCOrderNum(int kCOrderNum, string sort_)
		{
			return GetByKCOrderNum(kCOrderNum, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 KCOrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "kCOrderNum">排序</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_keywordEO> GetByKCOrderNum(int kCOrderNum, string sort_, TransactionManager tm_)
		{
			return GetByKCOrderNum(kCOrderNum, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 KCOrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "kCOrderNum">排序</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_l_keywordEO> GetByKCOrderNum(int kCOrderNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`KCOrderNum` = @KCOrderNum", top_, sort_);
			var parameter_ = Database.CreateInParameter("@KCOrderNum", kCOrderNum, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_l_keywordEO.MapDataReader);
		}
		#endregion // GetByKCOrderNum
		#endregion // Get
	}
	#endregion // MO
}
