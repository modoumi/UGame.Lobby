/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * AiUo代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/AiUo
 * 文档生成时间：2023-10-24 18: 04:58
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
	/// 活动列表
	/// 【表 l_activity_lang 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class L_activity_langEO : IRowMapper<L_activity_langEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public L_activity_langEO()
		{
			this.Kind = 0;
			this.Mode = 0;
			this.OrderNum = 0;
			this.Status = 0;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private string _originalActivityID;
		/// <summary>
		/// 【数据库中的原始主键 ActivityID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalActivityID
		{
			get { return _originalActivityID; }
			set { HasOriginal = true; _originalActivityID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "ActivityID", ActivityID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 活动编码GUID
		/// 【主键 varchar(38)】
		/// </summary>
		[DataMember(Order = 1)]
		public string ActivityID { get; set; }
		/// <summary>
		/// 运营商编码
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
		/// 活动类型
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 4)]
		public int Kind { get; set; }
		/// <summary>
		/// 标题
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 5)]
		public string Title { get; set; }
		/// <summary>
		/// 图片1
		/// 【字段 varchar(500)】
		/// </summary>
		[DataMember(Order = 6)]
		public string Img1 { get; set; }
		/// <summary>
		/// 图片1
		/// 【字段 varchar(500)】
		/// </summary>
		[DataMember(Order = 7)]
		public string Img2 { get; set; }
		/// <summary>
		/// 图片1
		/// 【字段 varchar(500)】
		/// </summary>
		[DataMember(Order = 8)]
		public string Img3 { get; set; }
		/// <summary>
		/// 图片1
		/// 【字段 varchar(500)】
		/// </summary>
		[DataMember(Order = 9)]
		public string Img4 { get; set; }
		/// <summary>
		/// 图片1
		/// 【字段 varchar(500)】
		/// </summary>
		[DataMember(Order = 10)]
		public string Img5 { get; set; }
		/// <summary>
		/// 类型:0-位置1-图片2-html3-文字
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 11)]
		public int Mode { get; set; }
		/// <summary>
		/// 内容
		/// 【字段 text】
		/// </summary>
		[DataMember(Order = 12)]
		public string Content { get; set; }
		/// <summary>
		/// 链接地址
		/// 【字段 varchar(500)】
		/// </summary>
		[DataMember(Order = 13)]
		public string LinkUrl { get; set; }
		/// <summary>
		/// 首页未登录链接
		/// 【字段 varchar(100)】
		/// </summary>
		[DataMember(Order = 14)]
		public string IndexNologinLinkUrl { get; set; }
		/// <summary>
		/// 首页登录后链接
		/// 【字段 varchar(100)】
		/// </summary>
		[DataMember(Order = 15)]
		public string IndexloginLinkUrl { get; set; }
		/// <summary>
		/// 排序（从小到大）
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 16)]
		public int OrderNum { get; set; }
		/// <summary>
		/// 起始日期（默认2016-01-01）
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 17)]
		public DateTime BeginDate { get; set; }
		/// <summary>
		/// 截止日期（默认2099-01-01）
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 18)]
		public DateTime EndDate { get; set; }
		/// <summary>
		/// 状态(0-无效1-有效)
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 19)]
		public int Status { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public L_activity_langEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static L_activity_langEO MapDataReader(IDataReader reader)
		{
		    L_activity_langEO ret = new L_activity_langEO();
			ret.ActivityID = reader.ToString("ActivityID");
			ret.OriginalActivityID = ret.ActivityID;
			ret.OperatorID = reader.ToString("OperatorID");
			ret.LangID = reader.ToString("LangID");
			ret.Kind = reader.ToInt32("Kind");
			ret.Title = reader.ToString("Title");
			ret.Img1 = reader.ToString("Img1");
			ret.Img2 = reader.ToString("Img2");
			ret.Img3 = reader.ToString("Img3");
			ret.Img4 = reader.ToString("Img4");
			ret.Img5 = reader.ToString("Img5");
			ret.Mode = reader.ToInt32("Mode");
			ret.Content = reader.ToString("Content");
			ret.LinkUrl = reader.ToString("LinkUrl");
			ret.IndexNologinLinkUrl = reader.ToString("IndexNologinLinkUrl");
			ret.IndexloginLinkUrl = reader.ToString("IndexloginLinkUrl");
			ret.OrderNum = reader.ToInt32("OrderNum");
			ret.BeginDate = reader.ToDateTime("BeginDate");
			ret.EndDate = reader.ToDateTime("EndDate");
			ret.Status = reader.ToInt32("Status");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 活动列表
	/// 【表 l_activity_lang 的操作类】
	/// </summary>
	[Obsolete]
	public class L_activity_langMO : MySqlTableMO<L_activity_langEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`l_activity_lang`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public L_activity_langMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public L_activity_langMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public L_activity_langMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(L_activity_langEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(L_activity_langEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(L_activity_langEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`ActivityID`, `OperatorID`, `LangID`, `Kind`, `Title`, `Img1`, `Img2`, `Img3`, `Img4`, `Img5`, `Mode`, `Content`, `LinkUrl`, `IndexNologinLinkUrl`, `IndexloginLinkUrl`, `OrderNum`, `BeginDate`, `EndDate`, `Status`) VALUE (@ActivityID, @OperatorID, @LangID, @Kind, @Title, @Img1, @Img2, @Img3, @Img4, @Img5, @Mode, @Content, @LinkUrl, @IndexNologinLinkUrl, @IndexloginLinkUrl, @OrderNum, @BeginDate, @EndDate, @Status);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ActivityID", item.ActivityID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", item.LangID != null ? item.LangID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Kind", item.Kind, MySqlDbType.Int32),
				Database.CreateInParameter("@Title", item.Title != null ? item.Title : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Img1", item.Img1 != null ? item.Img1 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Img2", item.Img2 != null ? item.Img2 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Img3", item.Img3 != null ? item.Img3 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Img4", item.Img4 != null ? item.Img4 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Img5", item.Img5 != null ? item.Img5 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Mode", item.Mode, MySqlDbType.Int32),
				Database.CreateInParameter("@Content", item.Content != null ? item.Content : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@LinkUrl", item.LinkUrl != null ? item.LinkUrl : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@IndexNologinLinkUrl", item.IndexNologinLinkUrl, MySqlDbType.VarChar),
				Database.CreateInParameter("@IndexloginLinkUrl", item.IndexloginLinkUrl, MySqlDbType.VarChar),
				Database.CreateInParameter("@OrderNum", item.OrderNum, MySqlDbType.Int32),
				Database.CreateInParameter("@BeginDate", item.BeginDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@EndDate", item.EndDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@Status", item.Status, MySqlDbType.Int32),
			};
		}
		public int AddByBatch(IEnumerable<L_activity_langEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<L_activity_langEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<L_activity_langEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`ActivityID`, `OperatorID`, `LangID`, `Kind`, `Title`, `Img1`, `Img2`, `Img3`, `Img4`, `Img5`, `Mode`, `Content`, `LinkUrl`, `IndexNologinLinkUrl`, `IndexloginLinkUrl`, `OrderNum`, `BeginDate`, `EndDate`, `Status`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.ActivityID}','{item.OperatorID}','{item.LangID}',{item.Kind},'{item.Title}','{item.Img1}','{item.Img2}','{item.Img3}','{item.Img4}','{item.Img5}',{item.Mode},'{item.Content}','{item.LinkUrl}','{item.IndexNologinLinkUrl}','{item.IndexloginLinkUrl}',{item.OrderNum},'{item.BeginDate.ToString("yyyy-MM-dd HH:mm:ss")}','{item.EndDate.ToString("yyyy-MM-dd HH:mm:ss")}',{item.Status}),");
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
		/// /// <param name = "activityID">活动编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string activityID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(activityID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string activityID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(activityID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string activityID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `ActivityID` = @ActivityID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(L_activity_langEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.ActivityID, tm_);
		}
		public async Task<int> RemoveAsync(L_activity_langEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.ActivityID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByOperatorID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByOperatorID(string operatorID, TransactionManager tm_ = null)
		{
			RepairRemoveByOperatorIDData(operatorID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByOperatorIDAsync(string operatorID, TransactionManager tm_ = null)
		{
			RepairRemoveByOperatorIDData(operatorID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByOperatorIDData(string operatorID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByOperatorID
		#region RemoveByLangID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "langID">语言代码</param>
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
		#region RemoveByKind
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "kind">活动类型</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByKind(int kind, TransactionManager tm_ = null)
		{
			RepairRemoveByKindData(kind, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByKindAsync(int kind, TransactionManager tm_ = null)
		{
			RepairRemoveByKindData(kind, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByKindData(int kind, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Kind` = @Kind";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Kind", kind, MySqlDbType.Int32));
		}
		#endregion // RemoveByKind
		#region RemoveByTitle
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "title">标题</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTitle(string title, TransactionManager tm_ = null)
		{
			RepairRemoveByTitleData(title, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTitleAsync(string title, TransactionManager tm_ = null)
		{
			RepairRemoveByTitleData(title, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTitleData(string title, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (title != null ? "`Title` = @Title" : "`Title` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (title != null)
				paras_.Add(Database.CreateInParameter("@Title", title, MySqlDbType.VarChar));
		}
		#endregion // RemoveByTitle
		#region RemoveByImg1
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "img1">图片1</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByImg1(string img1, TransactionManager tm_ = null)
		{
			RepairRemoveByImg1Data(img1, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByImg1Async(string img1, TransactionManager tm_ = null)
		{
			RepairRemoveByImg1Data(img1, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByImg1Data(string img1, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (img1 != null ? "`Img1` = @Img1" : "`Img1` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (img1 != null)
				paras_.Add(Database.CreateInParameter("@Img1", img1, MySqlDbType.VarChar));
		}
		#endregion // RemoveByImg1
		#region RemoveByImg2
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "img2">图片1</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByImg2(string img2, TransactionManager tm_ = null)
		{
			RepairRemoveByImg2Data(img2, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByImg2Async(string img2, TransactionManager tm_ = null)
		{
			RepairRemoveByImg2Data(img2, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByImg2Data(string img2, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (img2 != null ? "`Img2` = @Img2" : "`Img2` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (img2 != null)
				paras_.Add(Database.CreateInParameter("@Img2", img2, MySqlDbType.VarChar));
		}
		#endregion // RemoveByImg2
		#region RemoveByImg3
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "img3">图片1</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByImg3(string img3, TransactionManager tm_ = null)
		{
			RepairRemoveByImg3Data(img3, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByImg3Async(string img3, TransactionManager tm_ = null)
		{
			RepairRemoveByImg3Data(img3, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByImg3Data(string img3, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (img3 != null ? "`Img3` = @Img3" : "`Img3` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (img3 != null)
				paras_.Add(Database.CreateInParameter("@Img3", img3, MySqlDbType.VarChar));
		}
		#endregion // RemoveByImg3
		#region RemoveByImg4
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "img4">图片1</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByImg4(string img4, TransactionManager tm_ = null)
		{
			RepairRemoveByImg4Data(img4, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByImg4Async(string img4, TransactionManager tm_ = null)
		{
			RepairRemoveByImg4Data(img4, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByImg4Data(string img4, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (img4 != null ? "`Img4` = @Img4" : "`Img4` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (img4 != null)
				paras_.Add(Database.CreateInParameter("@Img4", img4, MySqlDbType.VarChar));
		}
		#endregion // RemoveByImg4
		#region RemoveByImg5
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "img5">图片1</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByImg5(string img5, TransactionManager tm_ = null)
		{
			RepairRemoveByImg5Data(img5, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByImg5Async(string img5, TransactionManager tm_ = null)
		{
			RepairRemoveByImg5Data(img5, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByImg5Data(string img5, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (img5 != null ? "`Img5` = @Img5" : "`Img5` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (img5 != null)
				paras_.Add(Database.CreateInParameter("@Img5", img5, MySqlDbType.VarChar));
		}
		#endregion // RemoveByImg5
		#region RemoveByMode
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "mode">类型:0-位置1-图片2-html3-文字</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByMode(int mode, TransactionManager tm_ = null)
		{
			RepairRemoveByModeData(mode, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByModeAsync(int mode, TransactionManager tm_ = null)
		{
			RepairRemoveByModeData(mode, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByModeData(int mode, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Mode` = @Mode";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Mode", mode, MySqlDbType.Int32));
		}
		#endregion // RemoveByMode
		#region RemoveByContent
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "content">内容</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByContent(string content, TransactionManager tm_ = null)
		{
			RepairRemoveByContentData(content, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByContentAsync(string content, TransactionManager tm_ = null)
		{
			RepairRemoveByContentData(content, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByContentData(string content, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (content != null ? "`Content` = @Content" : "`Content` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (content != null)
				paras_.Add(Database.CreateInParameter("@Content", content, MySqlDbType.Text));
		}
		#endregion // RemoveByContent
		#region RemoveByLinkUrl
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "linkUrl">链接地址</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByLinkUrl(string linkUrl, TransactionManager tm_ = null)
		{
			RepairRemoveByLinkUrlData(linkUrl, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByLinkUrlAsync(string linkUrl, TransactionManager tm_ = null)
		{
			RepairRemoveByLinkUrlData(linkUrl, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByLinkUrlData(string linkUrl, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (linkUrl != null ? "`LinkUrl` = @LinkUrl" : "`LinkUrl` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (linkUrl != null)
				paras_.Add(Database.CreateInParameter("@LinkUrl", linkUrl, MySqlDbType.VarChar));
		}
		#endregion // RemoveByLinkUrl
		#region RemoveByIndexNologinLinkUrl
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "indexNologinLinkUrl">首页未登录链接</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByIndexNologinLinkUrl(string indexNologinLinkUrl, TransactionManager tm_ = null)
		{
			RepairRemoveByIndexNologinLinkUrlData(indexNologinLinkUrl, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByIndexNologinLinkUrlAsync(string indexNologinLinkUrl, TransactionManager tm_ = null)
		{
			RepairRemoveByIndexNologinLinkUrlData(indexNologinLinkUrl, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByIndexNologinLinkUrlData(string indexNologinLinkUrl, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `IndexNologinLinkUrl` = @IndexNologinLinkUrl";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IndexNologinLinkUrl", indexNologinLinkUrl, MySqlDbType.VarChar));
		}
		#endregion // RemoveByIndexNologinLinkUrl
		#region RemoveByIndexloginLinkUrl
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "indexloginLinkUrl">首页登录后链接</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByIndexloginLinkUrl(string indexloginLinkUrl, TransactionManager tm_ = null)
		{
			RepairRemoveByIndexloginLinkUrlData(indexloginLinkUrl, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByIndexloginLinkUrlAsync(string indexloginLinkUrl, TransactionManager tm_ = null)
		{
			RepairRemoveByIndexloginLinkUrlData(indexloginLinkUrl, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByIndexloginLinkUrlData(string indexloginLinkUrl, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `IndexloginLinkUrl` = @IndexloginLinkUrl";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IndexloginLinkUrl", indexloginLinkUrl, MySqlDbType.VarChar));
		}
		#endregion // RemoveByIndexloginLinkUrl
		#region RemoveByOrderNum
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "orderNum">排序（从小到大）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByOrderNum(int orderNum, TransactionManager tm_ = null)
		{
			RepairRemoveByOrderNumData(orderNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByOrderNumAsync(int orderNum, TransactionManager tm_ = null)
		{
			RepairRemoveByOrderNumData(orderNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByOrderNumData(int orderNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `OrderNum` = @OrderNum";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OrderNum", orderNum, MySqlDbType.Int32));
		}
		#endregion // RemoveByOrderNum
		#region RemoveByBeginDate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "beginDate">起始日期（默认2016-01-01）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByBeginDate(DateTime beginDate, TransactionManager tm_ = null)
		{
			RepairRemoveByBeginDateData(beginDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByBeginDateAsync(DateTime beginDate, TransactionManager tm_ = null)
		{
			RepairRemoveByBeginDateData(beginDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByBeginDateData(DateTime beginDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `BeginDate` = @BeginDate";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BeginDate", beginDate, MySqlDbType.DateTime));
		}
		#endregion // RemoveByBeginDate
		#region RemoveByEndDate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "endDate">截止日期（默认2099-01-01）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByEndDate(DateTime endDate, TransactionManager tm_ = null)
		{
			RepairRemoveByEndDateData(endDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByEndDateAsync(DateTime endDate, TransactionManager tm_ = null)
		{
			RepairRemoveByEndDateData(endDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByEndDateData(DateTime endDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `EndDate` = @EndDate";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@EndDate", endDate, MySqlDbType.DateTime));
		}
		#endregion // RemoveByEndDate
		#region RemoveByStatus
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByStatus(int status, TransactionManager tm_ = null)
		{
			RepairRemoveByStatusData(status, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByStatusAsync(int status, TransactionManager tm_ = null)
		{
			RepairRemoveByStatusData(status, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByStatusData(int status, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Status` = @Status";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
		}
		#endregion // RemoveByStatus
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
		public int Put(L_activity_langEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(L_activity_langEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(L_activity_langEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ActivityID` = @ActivityID, `OperatorID` = @OperatorID, `LangID` = @LangID, `Kind` = @Kind, `Title` = @Title, `Img1` = @Img1, `Img2` = @Img2, `Img3` = @Img3, `Img4` = @Img4, `Img5` = @Img5, `Mode` = @Mode, `Content` = @Content, `LinkUrl` = @LinkUrl, `IndexNologinLinkUrl` = @IndexNologinLinkUrl, `IndexloginLinkUrl` = @IndexloginLinkUrl, `OrderNum` = @OrderNum, `BeginDate` = @BeginDate, `EndDate` = @EndDate, `Status` = @Status WHERE `ActivityID` = @ActivityID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ActivityID", item.ActivityID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", item.LangID != null ? item.LangID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Kind", item.Kind, MySqlDbType.Int32),
				Database.CreateInParameter("@Title", item.Title != null ? item.Title : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Img1", item.Img1 != null ? item.Img1 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Img2", item.Img2 != null ? item.Img2 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Img3", item.Img3 != null ? item.Img3 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Img4", item.Img4 != null ? item.Img4 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Img5", item.Img5 != null ? item.Img5 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Mode", item.Mode, MySqlDbType.Int32),
				Database.CreateInParameter("@Content", item.Content != null ? item.Content : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@LinkUrl", item.LinkUrl != null ? item.LinkUrl : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@IndexNologinLinkUrl", item.IndexNologinLinkUrl, MySqlDbType.VarChar),
				Database.CreateInParameter("@IndexloginLinkUrl", item.IndexloginLinkUrl, MySqlDbType.VarChar),
				Database.CreateInParameter("@OrderNum", item.OrderNum, MySqlDbType.Int32),
				Database.CreateInParameter("@BeginDate", item.BeginDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@EndDate", item.EndDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@Status", item.Status, MySqlDbType.Int32),
				Database.CreateInParameter("@ActivityID_Original", item.HasOriginal ? item.OriginalActivityID : item.ActivityID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<L_activity_langEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<L_activity_langEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "activityID">活动编码GUID</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string activityID, string set_, params object[] values_)
		{
			return Put(set_, "`ActivityID` = @ActivityID", ConcatValues(values_, activityID));
		}
		public async Task<int> PutByPKAsync(string activityID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`ActivityID` = @ActivityID", ConcatValues(values_, activityID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "activityID">活动编码GUID</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string activityID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`ActivityID` = @ActivityID", tm_, ConcatValues(values_, activityID));
		}
		public async Task<int> PutByPKAsync(string activityID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`ActivityID` = @ActivityID", tm_, ConcatValues(values_, activityID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "activityID">活动编码GUID</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string activityID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`ActivityID` = @ActivityID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string activityID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`ActivityID` = @ActivityID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutOperatorID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "activityID">活动编码GUID</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorIDByPK(string activityID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(activityID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOperatorIDByPKAsync(string activityID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(activityID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOperatorIDByPKData(string activityID, string operatorID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID  WHERE `ActivityID` = @ActivityID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorID(string operatorID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID";
			var parameter_ = Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutOperatorIDAsync(string operatorID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID";
			var parameter_ = Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutOperatorID
		#region PutLangID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "activityID">活动编码GUID</param>
		/// /// <param name = "langID">语言代码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLangIDByPK(string activityID, string langID, TransactionManager tm_ = null)
		{
			RepairPutLangIDByPKData(activityID, langID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLangIDByPKAsync(string activityID, string langID, TransactionManager tm_ = null)
		{
			RepairPutLangIDByPKData(activityID, langID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLangIDByPKData(string activityID, string langID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `LangID` = @LangID  WHERE `ActivityID` = @ActivityID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LangID", langID != null ? langID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "langID">语言代码</param>
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
		#region PutKind
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "activityID">活动编码GUID</param>
		/// /// <param name = "kind">活动类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutKindByPK(string activityID, int kind, TransactionManager tm_ = null)
		{
			RepairPutKindByPKData(activityID, kind, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutKindByPKAsync(string activityID, int kind, TransactionManager tm_ = null)
		{
			RepairPutKindByPKData(activityID, kind, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutKindByPKData(string activityID, int kind, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Kind` = @Kind  WHERE `ActivityID` = @ActivityID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Kind", kind, MySqlDbType.Int32),
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "kind">活动类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutKind(int kind, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Kind` = @Kind";
			var parameter_ = Database.CreateInParameter("@Kind", kind, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutKindAsync(int kind, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Kind` = @Kind";
			var parameter_ = Database.CreateInParameter("@Kind", kind, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutKind
		#region PutTitle
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "activityID">活动编码GUID</param>
		/// /// <param name = "title">标题</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTitleByPK(string activityID, string title, TransactionManager tm_ = null)
		{
			RepairPutTitleByPKData(activityID, title, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTitleByPKAsync(string activityID, string title, TransactionManager tm_ = null)
		{
			RepairPutTitleByPKData(activityID, title, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTitleByPKData(string activityID, string title, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Title` = @Title  WHERE `ActivityID` = @ActivityID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Title", title != null ? title : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "title">标题</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTitle(string title, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Title` = @Title";
			var parameter_ = Database.CreateInParameter("@Title", title != null ? title : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTitleAsync(string title, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Title` = @Title";
			var parameter_ = Database.CreateInParameter("@Title", title != null ? title : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTitle
		#region PutImg1
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "activityID">活动编码GUID</param>
		/// /// <param name = "img1">图片1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutImg1ByPK(string activityID, string img1, TransactionManager tm_ = null)
		{
			RepairPutImg1ByPKData(activityID, img1, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutImg1ByPKAsync(string activityID, string img1, TransactionManager tm_ = null)
		{
			RepairPutImg1ByPKData(activityID, img1, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutImg1ByPKData(string activityID, string img1, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Img1` = @Img1  WHERE `ActivityID` = @ActivityID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Img1", img1 != null ? img1 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "img1">图片1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutImg1(string img1, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Img1` = @Img1";
			var parameter_ = Database.CreateInParameter("@Img1", img1 != null ? img1 : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutImg1Async(string img1, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Img1` = @Img1";
			var parameter_ = Database.CreateInParameter("@Img1", img1 != null ? img1 : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutImg1
		#region PutImg2
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "activityID">活动编码GUID</param>
		/// /// <param name = "img2">图片1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutImg2ByPK(string activityID, string img2, TransactionManager tm_ = null)
		{
			RepairPutImg2ByPKData(activityID, img2, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutImg2ByPKAsync(string activityID, string img2, TransactionManager tm_ = null)
		{
			RepairPutImg2ByPKData(activityID, img2, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutImg2ByPKData(string activityID, string img2, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Img2` = @Img2  WHERE `ActivityID` = @ActivityID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Img2", img2 != null ? img2 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "img2">图片1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutImg2(string img2, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Img2` = @Img2";
			var parameter_ = Database.CreateInParameter("@Img2", img2 != null ? img2 : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutImg2Async(string img2, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Img2` = @Img2";
			var parameter_ = Database.CreateInParameter("@Img2", img2 != null ? img2 : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutImg2
		#region PutImg3
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "activityID">活动编码GUID</param>
		/// /// <param name = "img3">图片1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutImg3ByPK(string activityID, string img3, TransactionManager tm_ = null)
		{
			RepairPutImg3ByPKData(activityID, img3, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutImg3ByPKAsync(string activityID, string img3, TransactionManager tm_ = null)
		{
			RepairPutImg3ByPKData(activityID, img3, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutImg3ByPKData(string activityID, string img3, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Img3` = @Img3  WHERE `ActivityID` = @ActivityID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Img3", img3 != null ? img3 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "img3">图片1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutImg3(string img3, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Img3` = @Img3";
			var parameter_ = Database.CreateInParameter("@Img3", img3 != null ? img3 : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutImg3Async(string img3, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Img3` = @Img3";
			var parameter_ = Database.CreateInParameter("@Img3", img3 != null ? img3 : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutImg3
		#region PutImg4
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "activityID">活动编码GUID</param>
		/// /// <param name = "img4">图片1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutImg4ByPK(string activityID, string img4, TransactionManager tm_ = null)
		{
			RepairPutImg4ByPKData(activityID, img4, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutImg4ByPKAsync(string activityID, string img4, TransactionManager tm_ = null)
		{
			RepairPutImg4ByPKData(activityID, img4, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutImg4ByPKData(string activityID, string img4, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Img4` = @Img4  WHERE `ActivityID` = @ActivityID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Img4", img4 != null ? img4 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "img4">图片1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutImg4(string img4, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Img4` = @Img4";
			var parameter_ = Database.CreateInParameter("@Img4", img4 != null ? img4 : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutImg4Async(string img4, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Img4` = @Img4";
			var parameter_ = Database.CreateInParameter("@Img4", img4 != null ? img4 : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutImg4
		#region PutImg5
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "activityID">活动编码GUID</param>
		/// /// <param name = "img5">图片1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutImg5ByPK(string activityID, string img5, TransactionManager tm_ = null)
		{
			RepairPutImg5ByPKData(activityID, img5, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutImg5ByPKAsync(string activityID, string img5, TransactionManager tm_ = null)
		{
			RepairPutImg5ByPKData(activityID, img5, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutImg5ByPKData(string activityID, string img5, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Img5` = @Img5  WHERE `ActivityID` = @ActivityID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Img5", img5 != null ? img5 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "img5">图片1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutImg5(string img5, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Img5` = @Img5";
			var parameter_ = Database.CreateInParameter("@Img5", img5 != null ? img5 : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutImg5Async(string img5, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Img5` = @Img5";
			var parameter_ = Database.CreateInParameter("@Img5", img5 != null ? img5 : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutImg5
		#region PutMode
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "activityID">活动编码GUID</param>
		/// /// <param name = "mode">类型:0-位置1-图片2-html3-文字</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutModeByPK(string activityID, int mode, TransactionManager tm_ = null)
		{
			RepairPutModeByPKData(activityID, mode, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutModeByPKAsync(string activityID, int mode, TransactionManager tm_ = null)
		{
			RepairPutModeByPKData(activityID, mode, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutModeByPKData(string activityID, int mode, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Mode` = @Mode  WHERE `ActivityID` = @ActivityID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Mode", mode, MySqlDbType.Int32),
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "mode">类型:0-位置1-图片2-html3-文字</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMode(int mode, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Mode` = @Mode";
			var parameter_ = Database.CreateInParameter("@Mode", mode, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutModeAsync(int mode, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Mode` = @Mode";
			var parameter_ = Database.CreateInParameter("@Mode", mode, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutMode
		#region PutContent
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "activityID">活动编码GUID</param>
		/// /// <param name = "content">内容</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutContentByPK(string activityID, string content, TransactionManager tm_ = null)
		{
			RepairPutContentByPKData(activityID, content, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutContentByPKAsync(string activityID, string content, TransactionManager tm_ = null)
		{
			RepairPutContentByPKData(activityID, content, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutContentByPKData(string activityID, string content, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Content` = @Content  WHERE `ActivityID` = @ActivityID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Content", content != null ? content : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "content">内容</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutContent(string content, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Content` = @Content";
			var parameter_ = Database.CreateInParameter("@Content", content != null ? content : (object)DBNull.Value, MySqlDbType.Text);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutContentAsync(string content, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Content` = @Content";
			var parameter_ = Database.CreateInParameter("@Content", content != null ? content : (object)DBNull.Value, MySqlDbType.Text);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutContent
		#region PutLinkUrl
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "activityID">活动编码GUID</param>
		/// /// <param name = "linkUrl">链接地址</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLinkUrlByPK(string activityID, string linkUrl, TransactionManager tm_ = null)
		{
			RepairPutLinkUrlByPKData(activityID, linkUrl, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLinkUrlByPKAsync(string activityID, string linkUrl, TransactionManager tm_ = null)
		{
			RepairPutLinkUrlByPKData(activityID, linkUrl, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLinkUrlByPKData(string activityID, string linkUrl, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `LinkUrl` = @LinkUrl  WHERE `ActivityID` = @ActivityID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LinkUrl", linkUrl != null ? linkUrl : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "linkUrl">链接地址</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLinkUrl(string linkUrl, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LinkUrl` = @LinkUrl";
			var parameter_ = Database.CreateInParameter("@LinkUrl", linkUrl != null ? linkUrl : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutLinkUrlAsync(string linkUrl, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LinkUrl` = @LinkUrl";
			var parameter_ = Database.CreateInParameter("@LinkUrl", linkUrl != null ? linkUrl : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutLinkUrl
		#region PutIndexNologinLinkUrl
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "activityID">活动编码GUID</param>
		/// /// <param name = "indexNologinLinkUrl">首页未登录链接</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIndexNologinLinkUrlByPK(string activityID, string indexNologinLinkUrl, TransactionManager tm_ = null)
		{
			RepairPutIndexNologinLinkUrlByPKData(activityID, indexNologinLinkUrl, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutIndexNologinLinkUrlByPKAsync(string activityID, string indexNologinLinkUrl, TransactionManager tm_ = null)
		{
			RepairPutIndexNologinLinkUrlByPKData(activityID, indexNologinLinkUrl, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutIndexNologinLinkUrlByPKData(string activityID, string indexNologinLinkUrl, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `IndexNologinLinkUrl` = @IndexNologinLinkUrl  WHERE `ActivityID` = @ActivityID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@IndexNologinLinkUrl", indexNologinLinkUrl, MySqlDbType.VarChar),
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "indexNologinLinkUrl">首页未登录链接</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIndexNologinLinkUrl(string indexNologinLinkUrl, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IndexNologinLinkUrl` = @IndexNologinLinkUrl";
			var parameter_ = Database.CreateInParameter("@IndexNologinLinkUrl", indexNologinLinkUrl, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutIndexNologinLinkUrlAsync(string indexNologinLinkUrl, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IndexNologinLinkUrl` = @IndexNologinLinkUrl";
			var parameter_ = Database.CreateInParameter("@IndexNologinLinkUrl", indexNologinLinkUrl, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutIndexNologinLinkUrl
		#region PutIndexloginLinkUrl
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "activityID">活动编码GUID</param>
		/// /// <param name = "indexloginLinkUrl">首页登录后链接</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIndexloginLinkUrlByPK(string activityID, string indexloginLinkUrl, TransactionManager tm_ = null)
		{
			RepairPutIndexloginLinkUrlByPKData(activityID, indexloginLinkUrl, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutIndexloginLinkUrlByPKAsync(string activityID, string indexloginLinkUrl, TransactionManager tm_ = null)
		{
			RepairPutIndexloginLinkUrlByPKData(activityID, indexloginLinkUrl, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutIndexloginLinkUrlByPKData(string activityID, string indexloginLinkUrl, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `IndexloginLinkUrl` = @IndexloginLinkUrl  WHERE `ActivityID` = @ActivityID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@IndexloginLinkUrl", indexloginLinkUrl, MySqlDbType.VarChar),
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "indexloginLinkUrl">首页登录后链接</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIndexloginLinkUrl(string indexloginLinkUrl, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IndexloginLinkUrl` = @IndexloginLinkUrl";
			var parameter_ = Database.CreateInParameter("@IndexloginLinkUrl", indexloginLinkUrl, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutIndexloginLinkUrlAsync(string indexloginLinkUrl, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IndexloginLinkUrl` = @IndexloginLinkUrl";
			var parameter_ = Database.CreateInParameter("@IndexloginLinkUrl", indexloginLinkUrl, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutIndexloginLinkUrl
		#region PutOrderNum
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "activityID">活动编码GUID</param>
		/// /// <param name = "orderNum">排序（从小到大）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOrderNumByPK(string activityID, int orderNum, TransactionManager tm_ = null)
		{
			RepairPutOrderNumByPKData(activityID, orderNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOrderNumByPKAsync(string activityID, int orderNum, TransactionManager tm_ = null)
		{
			RepairPutOrderNumByPKData(activityID, orderNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOrderNumByPKData(string activityID, int orderNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OrderNum` = @OrderNum  WHERE `ActivityID` = @ActivityID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderNum", orderNum, MySqlDbType.Int32),
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "orderNum">排序（从小到大）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOrderNum(int orderNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OrderNum` = @OrderNum";
			var parameter_ = Database.CreateInParameter("@OrderNum", orderNum, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutOrderNumAsync(int orderNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OrderNum` = @OrderNum";
			var parameter_ = Database.CreateInParameter("@OrderNum", orderNum, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutOrderNum
		#region PutBeginDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "activityID">活动编码GUID</param>
		/// /// <param name = "beginDate">起始日期（默认2016-01-01）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBeginDateByPK(string activityID, DateTime beginDate, TransactionManager tm_ = null)
		{
			RepairPutBeginDateByPKData(activityID, beginDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBeginDateByPKAsync(string activityID, DateTime beginDate, TransactionManager tm_ = null)
		{
			RepairPutBeginDateByPKData(activityID, beginDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBeginDateByPKData(string activityID, DateTime beginDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BeginDate` = @BeginDate  WHERE `ActivityID` = @ActivityID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BeginDate", beginDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "beginDate">起始日期（默认2016-01-01）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBeginDate(DateTime beginDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BeginDate` = @BeginDate";
			var parameter_ = Database.CreateInParameter("@BeginDate", beginDate, MySqlDbType.DateTime);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutBeginDateAsync(DateTime beginDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BeginDate` = @BeginDate";
			var parameter_ = Database.CreateInParameter("@BeginDate", beginDate, MySqlDbType.DateTime);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutBeginDate
		#region PutEndDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "activityID">活动编码GUID</param>
		/// /// <param name = "endDate">截止日期（默认2099-01-01）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutEndDateByPK(string activityID, DateTime endDate, TransactionManager tm_ = null)
		{
			RepairPutEndDateByPKData(activityID, endDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutEndDateByPKAsync(string activityID, DateTime endDate, TransactionManager tm_ = null)
		{
			RepairPutEndDateByPKData(activityID, endDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutEndDateByPKData(string activityID, DateTime endDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `EndDate` = @EndDate  WHERE `ActivityID` = @ActivityID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@EndDate", endDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "endDate">截止日期（默认2099-01-01）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutEndDate(DateTime endDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `EndDate` = @EndDate";
			var parameter_ = Database.CreateInParameter("@EndDate", endDate, MySqlDbType.DateTime);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutEndDateAsync(DateTime endDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `EndDate` = @EndDate";
			var parameter_ = Database.CreateInParameter("@EndDate", endDate, MySqlDbType.DateTime);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutEndDate
		#region PutStatus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "activityID">活动编码GUID</param>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutStatusByPK(string activityID, int status, TransactionManager tm_ = null)
		{
			RepairPutStatusByPKData(activityID, status, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutStatusByPKAsync(string activityID, int status, TransactionManager tm_ = null)
		{
			RepairPutStatusByPKData(activityID, status, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutStatusByPKData(string activityID, int status, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Status` = @Status  WHERE `ActivityID` = @ActivityID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Status", status, MySqlDbType.Int32),
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutStatus(int status, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Status` = @Status";
			var parameter_ = Database.CreateInParameter("@Status", status, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutStatusAsync(int status, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Status` = @Status";
			var parameter_ = Database.CreateInParameter("@Status", status, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutStatus
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(L_activity_langEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.ActivityID) == null)
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
		public async Task<bool> SetAsync(L_activity_langEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.ActivityID) == null)
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
		/// /// <param name = "activityID">活动编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public L_activity_langEO GetByPK(string activityID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(activityID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, L_activity_langEO.MapDataReader);
		}
		public async Task<L_activity_langEO> GetByPKAsync(string activityID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(activityID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, L_activity_langEO.MapDataReader);
		}
		private void RepairGetByPKData(string activityID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`ActivityID` = @ActivityID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 OperatorID（字段）
		/// </summary>
		/// /// <param name = "activityID">活动编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorIDByPK(string activityID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OperatorID`", "`ActivityID` = @ActivityID", paras_, tm_);
		}
		public async Task<string> GetOperatorIDByPKAsync(string activityID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OperatorID`", "`ActivityID` = @ActivityID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 LangID（字段）
		/// </summary>
		/// /// <param name = "activityID">活动编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetLangIDByPK(string activityID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`LangID`", "`ActivityID` = @ActivityID", paras_, tm_);
		}
		public async Task<string> GetLangIDByPKAsync(string activityID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`LangID`", "`ActivityID` = @ActivityID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Kind（字段）
		/// </summary>
		/// /// <param name = "activityID">活动编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetKindByPK(string activityID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`Kind`", "`ActivityID` = @ActivityID", paras_, tm_);
		}
		public async Task<int> GetKindByPKAsync(string activityID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`Kind`", "`ActivityID` = @ActivityID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Title（字段）
		/// </summary>
		/// /// <param name = "activityID">活动编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetTitleByPK(string activityID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Title`", "`ActivityID` = @ActivityID", paras_, tm_);
		}
		public async Task<string> GetTitleByPKAsync(string activityID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Title`", "`ActivityID` = @ActivityID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Img1（字段）
		/// </summary>
		/// /// <param name = "activityID">活动编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetImg1ByPK(string activityID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Img1`", "`ActivityID` = @ActivityID", paras_, tm_);
		}
		public async Task<string> GetImg1ByPKAsync(string activityID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Img1`", "`ActivityID` = @ActivityID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Img2（字段）
		/// </summary>
		/// /// <param name = "activityID">活动编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetImg2ByPK(string activityID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Img2`", "`ActivityID` = @ActivityID", paras_, tm_);
		}
		public async Task<string> GetImg2ByPKAsync(string activityID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Img2`", "`ActivityID` = @ActivityID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Img3（字段）
		/// </summary>
		/// /// <param name = "activityID">活动编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetImg3ByPK(string activityID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Img3`", "`ActivityID` = @ActivityID", paras_, tm_);
		}
		public async Task<string> GetImg3ByPKAsync(string activityID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Img3`", "`ActivityID` = @ActivityID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Img4（字段）
		/// </summary>
		/// /// <param name = "activityID">活动编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetImg4ByPK(string activityID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Img4`", "`ActivityID` = @ActivityID", paras_, tm_);
		}
		public async Task<string> GetImg4ByPKAsync(string activityID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Img4`", "`ActivityID` = @ActivityID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Img5（字段）
		/// </summary>
		/// /// <param name = "activityID">活动编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetImg5ByPK(string activityID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Img5`", "`ActivityID` = @ActivityID", paras_, tm_);
		}
		public async Task<string> GetImg5ByPKAsync(string activityID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Img5`", "`ActivityID` = @ActivityID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Mode（字段）
		/// </summary>
		/// /// <param name = "activityID">活动编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetModeByPK(string activityID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`Mode`", "`ActivityID` = @ActivityID", paras_, tm_);
		}
		public async Task<int> GetModeByPKAsync(string activityID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`Mode`", "`ActivityID` = @ActivityID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Content（字段）
		/// </summary>
		/// /// <param name = "activityID">活动编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetContentByPK(string activityID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Content`", "`ActivityID` = @ActivityID", paras_, tm_);
		}
		public async Task<string> GetContentByPKAsync(string activityID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Content`", "`ActivityID` = @ActivityID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 LinkUrl（字段）
		/// </summary>
		/// /// <param name = "activityID">活动编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetLinkUrlByPK(string activityID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`LinkUrl`", "`ActivityID` = @ActivityID", paras_, tm_);
		}
		public async Task<string> GetLinkUrlByPKAsync(string activityID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`LinkUrl`", "`ActivityID` = @ActivityID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 IndexNologinLinkUrl（字段）
		/// </summary>
		/// /// <param name = "activityID">活动编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetIndexNologinLinkUrlByPK(string activityID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`IndexNologinLinkUrl`", "`ActivityID` = @ActivityID", paras_, tm_);
		}
		public async Task<string> GetIndexNologinLinkUrlByPKAsync(string activityID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`IndexNologinLinkUrl`", "`ActivityID` = @ActivityID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 IndexloginLinkUrl（字段）
		/// </summary>
		/// /// <param name = "activityID">活动编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetIndexloginLinkUrlByPK(string activityID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`IndexloginLinkUrl`", "`ActivityID` = @ActivityID", paras_, tm_);
		}
		public async Task<string> GetIndexloginLinkUrlByPKAsync(string activityID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`IndexloginLinkUrl`", "`ActivityID` = @ActivityID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OrderNum（字段）
		/// </summary>
		/// /// <param name = "activityID">活动编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetOrderNumByPK(string activityID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`OrderNum`", "`ActivityID` = @ActivityID", paras_, tm_);
		}
		public async Task<int> GetOrderNumByPKAsync(string activityID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`OrderNum`", "`ActivityID` = @ActivityID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 BeginDate（字段）
		/// </summary>
		/// /// <param name = "activityID">活动编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetBeginDateByPK(string activityID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`BeginDate`", "`ActivityID` = @ActivityID", paras_, tm_);
		}
		public async Task<DateTime> GetBeginDateByPKAsync(string activityID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`BeginDate`", "`ActivityID` = @ActivityID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 EndDate（字段）
		/// </summary>
		/// /// <param name = "activityID">活动编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetEndDateByPK(string activityID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`EndDate`", "`ActivityID` = @ActivityID", paras_, tm_);
		}
		public async Task<DateTime> GetEndDateByPKAsync(string activityID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`EndDate`", "`ActivityID` = @ActivityID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Status（字段）
		/// </summary>
		/// /// <param name = "activityID">活动编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetStatusByPK(string activityID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`Status`", "`ActivityID` = @ActivityID", paras_, tm_);
		}
		public async Task<int> GetStatusByPKAsync(string activityID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ActivityID", activityID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`Status`", "`ActivityID` = @ActivityID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<L_activity_langEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<L_activity_langEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<L_activity_langEO>> GetByOperatorIDAsync(string operatorID, int top_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<L_activity_langEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<L_activity_langEO>> GetByOperatorIDAsync(string operatorID, string sort_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<L_activity_langEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_activity_langEO.MapDataReader);
		}
		public async Task<List<L_activity_langEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_activity_langEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByLangID
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言代码</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByLangID(string langID)
		{
			return GetByLangID(langID, 0, string.Empty, null);
		}
		public async Task<List<L_activity_langEO>> GetByLangIDAsync(string langID)
		{
			return await GetByLangIDAsync(langID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言代码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByLangID(string langID, TransactionManager tm_)
		{
			return GetByLangID(langID, 0, string.Empty, tm_);
		}
		public async Task<List<L_activity_langEO>> GetByLangIDAsync(string langID, TransactionManager tm_)
		{
			return await GetByLangIDAsync(langID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言代码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByLangID(string langID, int top_)
		{
			return GetByLangID(langID, top_, string.Empty, null);
		}
		public async Task<List<L_activity_langEO>> GetByLangIDAsync(string langID, int top_)
		{
			return await GetByLangIDAsync(langID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言代码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByLangID(string langID, int top_, TransactionManager tm_)
		{
			return GetByLangID(langID, top_, string.Empty, tm_);
		}
		public async Task<List<L_activity_langEO>> GetByLangIDAsync(string langID, int top_, TransactionManager tm_)
		{
			return await GetByLangIDAsync(langID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言代码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByLangID(string langID, string sort_)
		{
			return GetByLangID(langID, 0, sort_, null);
		}
		public async Task<List<L_activity_langEO>> GetByLangIDAsync(string langID, string sort_)
		{
			return await GetByLangIDAsync(langID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言代码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByLangID(string langID, string sort_, TransactionManager tm_)
		{
			return GetByLangID(langID, 0, sort_, tm_);
		}
		public async Task<List<L_activity_langEO>> GetByLangIDAsync(string langID, string sort_, TransactionManager tm_)
		{
			return await GetByLangIDAsync(langID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言代码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByLangID(string langID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(langID != null ? "`LangID` = @LangID" : "`LangID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (langID != null)
				paras_.Add(Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_activity_langEO.MapDataReader);
		}
		public async Task<List<L_activity_langEO>> GetByLangIDAsync(string langID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(langID != null ? "`LangID` = @LangID" : "`LangID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (langID != null)
				paras_.Add(Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_activity_langEO.MapDataReader);
		}
		#endregion // GetByLangID
		#region GetByKind
		
		/// <summary>
		/// 按 Kind（字段） 查询
		/// </summary>
		/// /// <param name = "kind">活动类型</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByKind(int kind)
		{
			return GetByKind(kind, 0, string.Empty, null);
		}
		public async Task<List<L_activity_langEO>> GetByKindAsync(int kind)
		{
			return await GetByKindAsync(kind, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Kind（字段） 查询
		/// </summary>
		/// /// <param name = "kind">活动类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByKind(int kind, TransactionManager tm_)
		{
			return GetByKind(kind, 0, string.Empty, tm_);
		}
		public async Task<List<L_activity_langEO>> GetByKindAsync(int kind, TransactionManager tm_)
		{
			return await GetByKindAsync(kind, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Kind（字段） 查询
		/// </summary>
		/// /// <param name = "kind">活动类型</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByKind(int kind, int top_)
		{
			return GetByKind(kind, top_, string.Empty, null);
		}
		public async Task<List<L_activity_langEO>> GetByKindAsync(int kind, int top_)
		{
			return await GetByKindAsync(kind, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Kind（字段） 查询
		/// </summary>
		/// /// <param name = "kind">活动类型</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByKind(int kind, int top_, TransactionManager tm_)
		{
			return GetByKind(kind, top_, string.Empty, tm_);
		}
		public async Task<List<L_activity_langEO>> GetByKindAsync(int kind, int top_, TransactionManager tm_)
		{
			return await GetByKindAsync(kind, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Kind（字段） 查询
		/// </summary>
		/// /// <param name = "kind">活动类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByKind(int kind, string sort_)
		{
			return GetByKind(kind, 0, sort_, null);
		}
		public async Task<List<L_activity_langEO>> GetByKindAsync(int kind, string sort_)
		{
			return await GetByKindAsync(kind, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Kind（字段） 查询
		/// </summary>
		/// /// <param name = "kind">活动类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByKind(int kind, string sort_, TransactionManager tm_)
		{
			return GetByKind(kind, 0, sort_, tm_);
		}
		public async Task<List<L_activity_langEO>> GetByKindAsync(int kind, string sort_, TransactionManager tm_)
		{
			return await GetByKindAsync(kind, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Kind（字段） 查询
		/// </summary>
		/// /// <param name = "kind">活动类型</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByKind(int kind, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Kind` = @Kind", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Kind", kind, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, L_activity_langEO.MapDataReader);
		}
		public async Task<List<L_activity_langEO>> GetByKindAsync(int kind, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Kind` = @Kind", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Kind", kind, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_activity_langEO.MapDataReader);
		}
		#endregion // GetByKind
		#region GetByTitle
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">标题</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByTitle(string title)
		{
			return GetByTitle(title, 0, string.Empty, null);
		}
		public async Task<List<L_activity_langEO>> GetByTitleAsync(string title)
		{
			return await GetByTitleAsync(title, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">标题</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByTitle(string title, TransactionManager tm_)
		{
			return GetByTitle(title, 0, string.Empty, tm_);
		}
		public async Task<List<L_activity_langEO>> GetByTitleAsync(string title, TransactionManager tm_)
		{
			return await GetByTitleAsync(title, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">标题</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByTitle(string title, int top_)
		{
			return GetByTitle(title, top_, string.Empty, null);
		}
		public async Task<List<L_activity_langEO>> GetByTitleAsync(string title, int top_)
		{
			return await GetByTitleAsync(title, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">标题</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByTitle(string title, int top_, TransactionManager tm_)
		{
			return GetByTitle(title, top_, string.Empty, tm_);
		}
		public async Task<List<L_activity_langEO>> GetByTitleAsync(string title, int top_, TransactionManager tm_)
		{
			return await GetByTitleAsync(title, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">标题</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByTitle(string title, string sort_)
		{
			return GetByTitle(title, 0, sort_, null);
		}
		public async Task<List<L_activity_langEO>> GetByTitleAsync(string title, string sort_)
		{
			return await GetByTitleAsync(title, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">标题</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByTitle(string title, string sort_, TransactionManager tm_)
		{
			return GetByTitle(title, 0, sort_, tm_);
		}
		public async Task<List<L_activity_langEO>> GetByTitleAsync(string title, string sort_, TransactionManager tm_)
		{
			return await GetByTitleAsync(title, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">标题</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByTitle(string title, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(title != null ? "`Title` = @Title" : "`Title` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (title != null)
				paras_.Add(Database.CreateInParameter("@Title", title, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_activity_langEO.MapDataReader);
		}
		public async Task<List<L_activity_langEO>> GetByTitleAsync(string title, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(title != null ? "`Title` = @Title" : "`Title` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (title != null)
				paras_.Add(Database.CreateInParameter("@Title", title, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_activity_langEO.MapDataReader);
		}
		#endregion // GetByTitle
		#region GetByImg1
		
		/// <summary>
		/// 按 Img1（字段） 查询
		/// </summary>
		/// /// <param name = "img1">图片1</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByImg1(string img1)
		{
			return GetByImg1(img1, 0, string.Empty, null);
		}
		public async Task<List<L_activity_langEO>> GetByImg1Async(string img1)
		{
			return await GetByImg1Async(img1, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Img1（字段） 查询
		/// </summary>
		/// /// <param name = "img1">图片1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByImg1(string img1, TransactionManager tm_)
		{
			return GetByImg1(img1, 0, string.Empty, tm_);
		}
		public async Task<List<L_activity_langEO>> GetByImg1Async(string img1, TransactionManager tm_)
		{
			return await GetByImg1Async(img1, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Img1（字段） 查询
		/// </summary>
		/// /// <param name = "img1">图片1</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByImg1(string img1, int top_)
		{
			return GetByImg1(img1, top_, string.Empty, null);
		}
		public async Task<List<L_activity_langEO>> GetByImg1Async(string img1, int top_)
		{
			return await GetByImg1Async(img1, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Img1（字段） 查询
		/// </summary>
		/// /// <param name = "img1">图片1</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByImg1(string img1, int top_, TransactionManager tm_)
		{
			return GetByImg1(img1, top_, string.Empty, tm_);
		}
		public async Task<List<L_activity_langEO>> GetByImg1Async(string img1, int top_, TransactionManager tm_)
		{
			return await GetByImg1Async(img1, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Img1（字段） 查询
		/// </summary>
		/// /// <param name = "img1">图片1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByImg1(string img1, string sort_)
		{
			return GetByImg1(img1, 0, sort_, null);
		}
		public async Task<List<L_activity_langEO>> GetByImg1Async(string img1, string sort_)
		{
			return await GetByImg1Async(img1, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Img1（字段） 查询
		/// </summary>
		/// /// <param name = "img1">图片1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByImg1(string img1, string sort_, TransactionManager tm_)
		{
			return GetByImg1(img1, 0, sort_, tm_);
		}
		public async Task<List<L_activity_langEO>> GetByImg1Async(string img1, string sort_, TransactionManager tm_)
		{
			return await GetByImg1Async(img1, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Img1（字段） 查询
		/// </summary>
		/// /// <param name = "img1">图片1</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByImg1(string img1, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(img1 != null ? "`Img1` = @Img1" : "`Img1` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (img1 != null)
				paras_.Add(Database.CreateInParameter("@Img1", img1, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_activity_langEO.MapDataReader);
		}
		public async Task<List<L_activity_langEO>> GetByImg1Async(string img1, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(img1 != null ? "`Img1` = @Img1" : "`Img1` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (img1 != null)
				paras_.Add(Database.CreateInParameter("@Img1", img1, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_activity_langEO.MapDataReader);
		}
		#endregion // GetByImg1
		#region GetByImg2
		
		/// <summary>
		/// 按 Img2（字段） 查询
		/// </summary>
		/// /// <param name = "img2">图片1</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByImg2(string img2)
		{
			return GetByImg2(img2, 0, string.Empty, null);
		}
		public async Task<List<L_activity_langEO>> GetByImg2Async(string img2)
		{
			return await GetByImg2Async(img2, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Img2（字段） 查询
		/// </summary>
		/// /// <param name = "img2">图片1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByImg2(string img2, TransactionManager tm_)
		{
			return GetByImg2(img2, 0, string.Empty, tm_);
		}
		public async Task<List<L_activity_langEO>> GetByImg2Async(string img2, TransactionManager tm_)
		{
			return await GetByImg2Async(img2, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Img2（字段） 查询
		/// </summary>
		/// /// <param name = "img2">图片1</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByImg2(string img2, int top_)
		{
			return GetByImg2(img2, top_, string.Empty, null);
		}
		public async Task<List<L_activity_langEO>> GetByImg2Async(string img2, int top_)
		{
			return await GetByImg2Async(img2, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Img2（字段） 查询
		/// </summary>
		/// /// <param name = "img2">图片1</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByImg2(string img2, int top_, TransactionManager tm_)
		{
			return GetByImg2(img2, top_, string.Empty, tm_);
		}
		public async Task<List<L_activity_langEO>> GetByImg2Async(string img2, int top_, TransactionManager tm_)
		{
			return await GetByImg2Async(img2, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Img2（字段） 查询
		/// </summary>
		/// /// <param name = "img2">图片1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByImg2(string img2, string sort_)
		{
			return GetByImg2(img2, 0, sort_, null);
		}
		public async Task<List<L_activity_langEO>> GetByImg2Async(string img2, string sort_)
		{
			return await GetByImg2Async(img2, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Img2（字段） 查询
		/// </summary>
		/// /// <param name = "img2">图片1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByImg2(string img2, string sort_, TransactionManager tm_)
		{
			return GetByImg2(img2, 0, sort_, tm_);
		}
		public async Task<List<L_activity_langEO>> GetByImg2Async(string img2, string sort_, TransactionManager tm_)
		{
			return await GetByImg2Async(img2, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Img2（字段） 查询
		/// </summary>
		/// /// <param name = "img2">图片1</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByImg2(string img2, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(img2 != null ? "`Img2` = @Img2" : "`Img2` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (img2 != null)
				paras_.Add(Database.CreateInParameter("@Img2", img2, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_activity_langEO.MapDataReader);
		}
		public async Task<List<L_activity_langEO>> GetByImg2Async(string img2, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(img2 != null ? "`Img2` = @Img2" : "`Img2` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (img2 != null)
				paras_.Add(Database.CreateInParameter("@Img2", img2, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_activity_langEO.MapDataReader);
		}
		#endregion // GetByImg2
		#region GetByImg3
		
		/// <summary>
		/// 按 Img3（字段） 查询
		/// </summary>
		/// /// <param name = "img3">图片1</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByImg3(string img3)
		{
			return GetByImg3(img3, 0, string.Empty, null);
		}
		public async Task<List<L_activity_langEO>> GetByImg3Async(string img3)
		{
			return await GetByImg3Async(img3, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Img3（字段） 查询
		/// </summary>
		/// /// <param name = "img3">图片1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByImg3(string img3, TransactionManager tm_)
		{
			return GetByImg3(img3, 0, string.Empty, tm_);
		}
		public async Task<List<L_activity_langEO>> GetByImg3Async(string img3, TransactionManager tm_)
		{
			return await GetByImg3Async(img3, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Img3（字段） 查询
		/// </summary>
		/// /// <param name = "img3">图片1</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByImg3(string img3, int top_)
		{
			return GetByImg3(img3, top_, string.Empty, null);
		}
		public async Task<List<L_activity_langEO>> GetByImg3Async(string img3, int top_)
		{
			return await GetByImg3Async(img3, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Img3（字段） 查询
		/// </summary>
		/// /// <param name = "img3">图片1</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByImg3(string img3, int top_, TransactionManager tm_)
		{
			return GetByImg3(img3, top_, string.Empty, tm_);
		}
		public async Task<List<L_activity_langEO>> GetByImg3Async(string img3, int top_, TransactionManager tm_)
		{
			return await GetByImg3Async(img3, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Img3（字段） 查询
		/// </summary>
		/// /// <param name = "img3">图片1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByImg3(string img3, string sort_)
		{
			return GetByImg3(img3, 0, sort_, null);
		}
		public async Task<List<L_activity_langEO>> GetByImg3Async(string img3, string sort_)
		{
			return await GetByImg3Async(img3, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Img3（字段） 查询
		/// </summary>
		/// /// <param name = "img3">图片1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByImg3(string img3, string sort_, TransactionManager tm_)
		{
			return GetByImg3(img3, 0, sort_, tm_);
		}
		public async Task<List<L_activity_langEO>> GetByImg3Async(string img3, string sort_, TransactionManager tm_)
		{
			return await GetByImg3Async(img3, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Img3（字段） 查询
		/// </summary>
		/// /// <param name = "img3">图片1</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByImg3(string img3, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(img3 != null ? "`Img3` = @Img3" : "`Img3` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (img3 != null)
				paras_.Add(Database.CreateInParameter("@Img3", img3, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_activity_langEO.MapDataReader);
		}
		public async Task<List<L_activity_langEO>> GetByImg3Async(string img3, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(img3 != null ? "`Img3` = @Img3" : "`Img3` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (img3 != null)
				paras_.Add(Database.CreateInParameter("@Img3", img3, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_activity_langEO.MapDataReader);
		}
		#endregion // GetByImg3
		#region GetByImg4
		
		/// <summary>
		/// 按 Img4（字段） 查询
		/// </summary>
		/// /// <param name = "img4">图片1</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByImg4(string img4)
		{
			return GetByImg4(img4, 0, string.Empty, null);
		}
		public async Task<List<L_activity_langEO>> GetByImg4Async(string img4)
		{
			return await GetByImg4Async(img4, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Img4（字段） 查询
		/// </summary>
		/// /// <param name = "img4">图片1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByImg4(string img4, TransactionManager tm_)
		{
			return GetByImg4(img4, 0, string.Empty, tm_);
		}
		public async Task<List<L_activity_langEO>> GetByImg4Async(string img4, TransactionManager tm_)
		{
			return await GetByImg4Async(img4, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Img4（字段） 查询
		/// </summary>
		/// /// <param name = "img4">图片1</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByImg4(string img4, int top_)
		{
			return GetByImg4(img4, top_, string.Empty, null);
		}
		public async Task<List<L_activity_langEO>> GetByImg4Async(string img4, int top_)
		{
			return await GetByImg4Async(img4, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Img4（字段） 查询
		/// </summary>
		/// /// <param name = "img4">图片1</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByImg4(string img4, int top_, TransactionManager tm_)
		{
			return GetByImg4(img4, top_, string.Empty, tm_);
		}
		public async Task<List<L_activity_langEO>> GetByImg4Async(string img4, int top_, TransactionManager tm_)
		{
			return await GetByImg4Async(img4, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Img4（字段） 查询
		/// </summary>
		/// /// <param name = "img4">图片1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByImg4(string img4, string sort_)
		{
			return GetByImg4(img4, 0, sort_, null);
		}
		public async Task<List<L_activity_langEO>> GetByImg4Async(string img4, string sort_)
		{
			return await GetByImg4Async(img4, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Img4（字段） 查询
		/// </summary>
		/// /// <param name = "img4">图片1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByImg4(string img4, string sort_, TransactionManager tm_)
		{
			return GetByImg4(img4, 0, sort_, tm_);
		}
		public async Task<List<L_activity_langEO>> GetByImg4Async(string img4, string sort_, TransactionManager tm_)
		{
			return await GetByImg4Async(img4, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Img4（字段） 查询
		/// </summary>
		/// /// <param name = "img4">图片1</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByImg4(string img4, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(img4 != null ? "`Img4` = @Img4" : "`Img4` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (img4 != null)
				paras_.Add(Database.CreateInParameter("@Img4", img4, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_activity_langEO.MapDataReader);
		}
		public async Task<List<L_activity_langEO>> GetByImg4Async(string img4, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(img4 != null ? "`Img4` = @Img4" : "`Img4` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (img4 != null)
				paras_.Add(Database.CreateInParameter("@Img4", img4, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_activity_langEO.MapDataReader);
		}
		#endregion // GetByImg4
		#region GetByImg5
		
		/// <summary>
		/// 按 Img5（字段） 查询
		/// </summary>
		/// /// <param name = "img5">图片1</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByImg5(string img5)
		{
			return GetByImg5(img5, 0, string.Empty, null);
		}
		public async Task<List<L_activity_langEO>> GetByImg5Async(string img5)
		{
			return await GetByImg5Async(img5, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Img5（字段） 查询
		/// </summary>
		/// /// <param name = "img5">图片1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByImg5(string img5, TransactionManager tm_)
		{
			return GetByImg5(img5, 0, string.Empty, tm_);
		}
		public async Task<List<L_activity_langEO>> GetByImg5Async(string img5, TransactionManager tm_)
		{
			return await GetByImg5Async(img5, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Img5（字段） 查询
		/// </summary>
		/// /// <param name = "img5">图片1</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByImg5(string img5, int top_)
		{
			return GetByImg5(img5, top_, string.Empty, null);
		}
		public async Task<List<L_activity_langEO>> GetByImg5Async(string img5, int top_)
		{
			return await GetByImg5Async(img5, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Img5（字段） 查询
		/// </summary>
		/// /// <param name = "img5">图片1</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByImg5(string img5, int top_, TransactionManager tm_)
		{
			return GetByImg5(img5, top_, string.Empty, tm_);
		}
		public async Task<List<L_activity_langEO>> GetByImg5Async(string img5, int top_, TransactionManager tm_)
		{
			return await GetByImg5Async(img5, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Img5（字段） 查询
		/// </summary>
		/// /// <param name = "img5">图片1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByImg5(string img5, string sort_)
		{
			return GetByImg5(img5, 0, sort_, null);
		}
		public async Task<List<L_activity_langEO>> GetByImg5Async(string img5, string sort_)
		{
			return await GetByImg5Async(img5, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Img5（字段） 查询
		/// </summary>
		/// /// <param name = "img5">图片1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByImg5(string img5, string sort_, TransactionManager tm_)
		{
			return GetByImg5(img5, 0, sort_, tm_);
		}
		public async Task<List<L_activity_langEO>> GetByImg5Async(string img5, string sort_, TransactionManager tm_)
		{
			return await GetByImg5Async(img5, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Img5（字段） 查询
		/// </summary>
		/// /// <param name = "img5">图片1</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByImg5(string img5, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(img5 != null ? "`Img5` = @Img5" : "`Img5` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (img5 != null)
				paras_.Add(Database.CreateInParameter("@Img5", img5, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_activity_langEO.MapDataReader);
		}
		public async Task<List<L_activity_langEO>> GetByImg5Async(string img5, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(img5 != null ? "`Img5` = @Img5" : "`Img5` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (img5 != null)
				paras_.Add(Database.CreateInParameter("@Img5", img5, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_activity_langEO.MapDataReader);
		}
		#endregion // GetByImg5
		#region GetByMode
		
		/// <summary>
		/// 按 Mode（字段） 查询
		/// </summary>
		/// /// <param name = "mode">类型:0-位置1-图片2-html3-文字</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByMode(int mode)
		{
			return GetByMode(mode, 0, string.Empty, null);
		}
		public async Task<List<L_activity_langEO>> GetByModeAsync(int mode)
		{
			return await GetByModeAsync(mode, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Mode（字段） 查询
		/// </summary>
		/// /// <param name = "mode">类型:0-位置1-图片2-html3-文字</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByMode(int mode, TransactionManager tm_)
		{
			return GetByMode(mode, 0, string.Empty, tm_);
		}
		public async Task<List<L_activity_langEO>> GetByModeAsync(int mode, TransactionManager tm_)
		{
			return await GetByModeAsync(mode, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Mode（字段） 查询
		/// </summary>
		/// /// <param name = "mode">类型:0-位置1-图片2-html3-文字</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByMode(int mode, int top_)
		{
			return GetByMode(mode, top_, string.Empty, null);
		}
		public async Task<List<L_activity_langEO>> GetByModeAsync(int mode, int top_)
		{
			return await GetByModeAsync(mode, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Mode（字段） 查询
		/// </summary>
		/// /// <param name = "mode">类型:0-位置1-图片2-html3-文字</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByMode(int mode, int top_, TransactionManager tm_)
		{
			return GetByMode(mode, top_, string.Empty, tm_);
		}
		public async Task<List<L_activity_langEO>> GetByModeAsync(int mode, int top_, TransactionManager tm_)
		{
			return await GetByModeAsync(mode, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Mode（字段） 查询
		/// </summary>
		/// /// <param name = "mode">类型:0-位置1-图片2-html3-文字</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByMode(int mode, string sort_)
		{
			return GetByMode(mode, 0, sort_, null);
		}
		public async Task<List<L_activity_langEO>> GetByModeAsync(int mode, string sort_)
		{
			return await GetByModeAsync(mode, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Mode（字段） 查询
		/// </summary>
		/// /// <param name = "mode">类型:0-位置1-图片2-html3-文字</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByMode(int mode, string sort_, TransactionManager tm_)
		{
			return GetByMode(mode, 0, sort_, tm_);
		}
		public async Task<List<L_activity_langEO>> GetByModeAsync(int mode, string sort_, TransactionManager tm_)
		{
			return await GetByModeAsync(mode, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Mode（字段） 查询
		/// </summary>
		/// /// <param name = "mode">类型:0-位置1-图片2-html3-文字</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByMode(int mode, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Mode` = @Mode", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Mode", mode, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, L_activity_langEO.MapDataReader);
		}
		public async Task<List<L_activity_langEO>> GetByModeAsync(int mode, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Mode` = @Mode", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Mode", mode, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_activity_langEO.MapDataReader);
		}
		#endregion // GetByMode
		#region GetByContent
		
		/// <summary>
		/// 按 Content（字段） 查询
		/// </summary>
		/// /// <param name = "content">内容</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByContent(string content)
		{
			return GetByContent(content, 0, string.Empty, null);
		}
		public async Task<List<L_activity_langEO>> GetByContentAsync(string content)
		{
			return await GetByContentAsync(content, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Content（字段） 查询
		/// </summary>
		/// /// <param name = "content">内容</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByContent(string content, TransactionManager tm_)
		{
			return GetByContent(content, 0, string.Empty, tm_);
		}
		public async Task<List<L_activity_langEO>> GetByContentAsync(string content, TransactionManager tm_)
		{
			return await GetByContentAsync(content, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Content（字段） 查询
		/// </summary>
		/// /// <param name = "content">内容</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByContent(string content, int top_)
		{
			return GetByContent(content, top_, string.Empty, null);
		}
		public async Task<List<L_activity_langEO>> GetByContentAsync(string content, int top_)
		{
			return await GetByContentAsync(content, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Content（字段） 查询
		/// </summary>
		/// /// <param name = "content">内容</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByContent(string content, int top_, TransactionManager tm_)
		{
			return GetByContent(content, top_, string.Empty, tm_);
		}
		public async Task<List<L_activity_langEO>> GetByContentAsync(string content, int top_, TransactionManager tm_)
		{
			return await GetByContentAsync(content, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Content（字段） 查询
		/// </summary>
		/// /// <param name = "content">内容</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByContent(string content, string sort_)
		{
			return GetByContent(content, 0, sort_, null);
		}
		public async Task<List<L_activity_langEO>> GetByContentAsync(string content, string sort_)
		{
			return await GetByContentAsync(content, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Content（字段） 查询
		/// </summary>
		/// /// <param name = "content">内容</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByContent(string content, string sort_, TransactionManager tm_)
		{
			return GetByContent(content, 0, sort_, tm_);
		}
		public async Task<List<L_activity_langEO>> GetByContentAsync(string content, string sort_, TransactionManager tm_)
		{
			return await GetByContentAsync(content, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Content（字段） 查询
		/// </summary>
		/// /// <param name = "content">内容</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByContent(string content, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(content != null ? "`Content` = @Content" : "`Content` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (content != null)
				paras_.Add(Database.CreateInParameter("@Content", content, MySqlDbType.Text));
			return Database.ExecSqlList(sql_, paras_, tm_, L_activity_langEO.MapDataReader);
		}
		public async Task<List<L_activity_langEO>> GetByContentAsync(string content, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(content != null ? "`Content` = @Content" : "`Content` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (content != null)
				paras_.Add(Database.CreateInParameter("@Content", content, MySqlDbType.Text));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_activity_langEO.MapDataReader);
		}
		#endregion // GetByContent
		#region GetByLinkUrl
		
		/// <summary>
		/// 按 LinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "linkUrl">链接地址</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByLinkUrl(string linkUrl)
		{
			return GetByLinkUrl(linkUrl, 0, string.Empty, null);
		}
		public async Task<List<L_activity_langEO>> GetByLinkUrlAsync(string linkUrl)
		{
			return await GetByLinkUrlAsync(linkUrl, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "linkUrl">链接地址</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByLinkUrl(string linkUrl, TransactionManager tm_)
		{
			return GetByLinkUrl(linkUrl, 0, string.Empty, tm_);
		}
		public async Task<List<L_activity_langEO>> GetByLinkUrlAsync(string linkUrl, TransactionManager tm_)
		{
			return await GetByLinkUrlAsync(linkUrl, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "linkUrl">链接地址</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByLinkUrl(string linkUrl, int top_)
		{
			return GetByLinkUrl(linkUrl, top_, string.Empty, null);
		}
		public async Task<List<L_activity_langEO>> GetByLinkUrlAsync(string linkUrl, int top_)
		{
			return await GetByLinkUrlAsync(linkUrl, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "linkUrl">链接地址</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByLinkUrl(string linkUrl, int top_, TransactionManager tm_)
		{
			return GetByLinkUrl(linkUrl, top_, string.Empty, tm_);
		}
		public async Task<List<L_activity_langEO>> GetByLinkUrlAsync(string linkUrl, int top_, TransactionManager tm_)
		{
			return await GetByLinkUrlAsync(linkUrl, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "linkUrl">链接地址</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByLinkUrl(string linkUrl, string sort_)
		{
			return GetByLinkUrl(linkUrl, 0, sort_, null);
		}
		public async Task<List<L_activity_langEO>> GetByLinkUrlAsync(string linkUrl, string sort_)
		{
			return await GetByLinkUrlAsync(linkUrl, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "linkUrl">链接地址</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByLinkUrl(string linkUrl, string sort_, TransactionManager tm_)
		{
			return GetByLinkUrl(linkUrl, 0, sort_, tm_);
		}
		public async Task<List<L_activity_langEO>> GetByLinkUrlAsync(string linkUrl, string sort_, TransactionManager tm_)
		{
			return await GetByLinkUrlAsync(linkUrl, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "linkUrl">链接地址</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByLinkUrl(string linkUrl, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(linkUrl != null ? "`LinkUrl` = @LinkUrl" : "`LinkUrl` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (linkUrl != null)
				paras_.Add(Database.CreateInParameter("@LinkUrl", linkUrl, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_activity_langEO.MapDataReader);
		}
		public async Task<List<L_activity_langEO>> GetByLinkUrlAsync(string linkUrl, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(linkUrl != null ? "`LinkUrl` = @LinkUrl" : "`LinkUrl` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (linkUrl != null)
				paras_.Add(Database.CreateInParameter("@LinkUrl", linkUrl, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_activity_langEO.MapDataReader);
		}
		#endregion // GetByLinkUrl
		#region GetByIndexNologinLinkUrl
		
		/// <summary>
		/// 按 IndexNologinLinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "indexNologinLinkUrl">首页未登录链接</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByIndexNologinLinkUrl(string indexNologinLinkUrl)
		{
			return GetByIndexNologinLinkUrl(indexNologinLinkUrl, 0, string.Empty, null);
		}
		public async Task<List<L_activity_langEO>> GetByIndexNologinLinkUrlAsync(string indexNologinLinkUrl)
		{
			return await GetByIndexNologinLinkUrlAsync(indexNologinLinkUrl, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IndexNologinLinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "indexNologinLinkUrl">首页未登录链接</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByIndexNologinLinkUrl(string indexNologinLinkUrl, TransactionManager tm_)
		{
			return GetByIndexNologinLinkUrl(indexNologinLinkUrl, 0, string.Empty, tm_);
		}
		public async Task<List<L_activity_langEO>> GetByIndexNologinLinkUrlAsync(string indexNologinLinkUrl, TransactionManager tm_)
		{
			return await GetByIndexNologinLinkUrlAsync(indexNologinLinkUrl, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IndexNologinLinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "indexNologinLinkUrl">首页未登录链接</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByIndexNologinLinkUrl(string indexNologinLinkUrl, int top_)
		{
			return GetByIndexNologinLinkUrl(indexNologinLinkUrl, top_, string.Empty, null);
		}
		public async Task<List<L_activity_langEO>> GetByIndexNologinLinkUrlAsync(string indexNologinLinkUrl, int top_)
		{
			return await GetByIndexNologinLinkUrlAsync(indexNologinLinkUrl, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IndexNologinLinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "indexNologinLinkUrl">首页未登录链接</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByIndexNologinLinkUrl(string indexNologinLinkUrl, int top_, TransactionManager tm_)
		{
			return GetByIndexNologinLinkUrl(indexNologinLinkUrl, top_, string.Empty, tm_);
		}
		public async Task<List<L_activity_langEO>> GetByIndexNologinLinkUrlAsync(string indexNologinLinkUrl, int top_, TransactionManager tm_)
		{
			return await GetByIndexNologinLinkUrlAsync(indexNologinLinkUrl, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IndexNologinLinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "indexNologinLinkUrl">首页未登录链接</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByIndexNologinLinkUrl(string indexNologinLinkUrl, string sort_)
		{
			return GetByIndexNologinLinkUrl(indexNologinLinkUrl, 0, sort_, null);
		}
		public async Task<List<L_activity_langEO>> GetByIndexNologinLinkUrlAsync(string indexNologinLinkUrl, string sort_)
		{
			return await GetByIndexNologinLinkUrlAsync(indexNologinLinkUrl, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 IndexNologinLinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "indexNologinLinkUrl">首页未登录链接</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByIndexNologinLinkUrl(string indexNologinLinkUrl, string sort_, TransactionManager tm_)
		{
			return GetByIndexNologinLinkUrl(indexNologinLinkUrl, 0, sort_, tm_);
		}
		public async Task<List<L_activity_langEO>> GetByIndexNologinLinkUrlAsync(string indexNologinLinkUrl, string sort_, TransactionManager tm_)
		{
			return await GetByIndexNologinLinkUrlAsync(indexNologinLinkUrl, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 IndexNologinLinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "indexNologinLinkUrl">首页未登录链接</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByIndexNologinLinkUrl(string indexNologinLinkUrl, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IndexNologinLinkUrl` = @IndexNologinLinkUrl", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IndexNologinLinkUrl", indexNologinLinkUrl, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_activity_langEO.MapDataReader);
		}
		public async Task<List<L_activity_langEO>> GetByIndexNologinLinkUrlAsync(string indexNologinLinkUrl, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IndexNologinLinkUrl` = @IndexNologinLinkUrl", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IndexNologinLinkUrl", indexNologinLinkUrl, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_activity_langEO.MapDataReader);
		}
		#endregion // GetByIndexNologinLinkUrl
		#region GetByIndexloginLinkUrl
		
		/// <summary>
		/// 按 IndexloginLinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "indexloginLinkUrl">首页登录后链接</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByIndexloginLinkUrl(string indexloginLinkUrl)
		{
			return GetByIndexloginLinkUrl(indexloginLinkUrl, 0, string.Empty, null);
		}
		public async Task<List<L_activity_langEO>> GetByIndexloginLinkUrlAsync(string indexloginLinkUrl)
		{
			return await GetByIndexloginLinkUrlAsync(indexloginLinkUrl, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IndexloginLinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "indexloginLinkUrl">首页登录后链接</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByIndexloginLinkUrl(string indexloginLinkUrl, TransactionManager tm_)
		{
			return GetByIndexloginLinkUrl(indexloginLinkUrl, 0, string.Empty, tm_);
		}
		public async Task<List<L_activity_langEO>> GetByIndexloginLinkUrlAsync(string indexloginLinkUrl, TransactionManager tm_)
		{
			return await GetByIndexloginLinkUrlAsync(indexloginLinkUrl, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IndexloginLinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "indexloginLinkUrl">首页登录后链接</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByIndexloginLinkUrl(string indexloginLinkUrl, int top_)
		{
			return GetByIndexloginLinkUrl(indexloginLinkUrl, top_, string.Empty, null);
		}
		public async Task<List<L_activity_langEO>> GetByIndexloginLinkUrlAsync(string indexloginLinkUrl, int top_)
		{
			return await GetByIndexloginLinkUrlAsync(indexloginLinkUrl, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IndexloginLinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "indexloginLinkUrl">首页登录后链接</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByIndexloginLinkUrl(string indexloginLinkUrl, int top_, TransactionManager tm_)
		{
			return GetByIndexloginLinkUrl(indexloginLinkUrl, top_, string.Empty, tm_);
		}
		public async Task<List<L_activity_langEO>> GetByIndexloginLinkUrlAsync(string indexloginLinkUrl, int top_, TransactionManager tm_)
		{
			return await GetByIndexloginLinkUrlAsync(indexloginLinkUrl, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IndexloginLinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "indexloginLinkUrl">首页登录后链接</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByIndexloginLinkUrl(string indexloginLinkUrl, string sort_)
		{
			return GetByIndexloginLinkUrl(indexloginLinkUrl, 0, sort_, null);
		}
		public async Task<List<L_activity_langEO>> GetByIndexloginLinkUrlAsync(string indexloginLinkUrl, string sort_)
		{
			return await GetByIndexloginLinkUrlAsync(indexloginLinkUrl, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 IndexloginLinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "indexloginLinkUrl">首页登录后链接</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByIndexloginLinkUrl(string indexloginLinkUrl, string sort_, TransactionManager tm_)
		{
			return GetByIndexloginLinkUrl(indexloginLinkUrl, 0, sort_, tm_);
		}
		public async Task<List<L_activity_langEO>> GetByIndexloginLinkUrlAsync(string indexloginLinkUrl, string sort_, TransactionManager tm_)
		{
			return await GetByIndexloginLinkUrlAsync(indexloginLinkUrl, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 IndexloginLinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "indexloginLinkUrl">首页登录后链接</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByIndexloginLinkUrl(string indexloginLinkUrl, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IndexloginLinkUrl` = @IndexloginLinkUrl", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IndexloginLinkUrl", indexloginLinkUrl, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_activity_langEO.MapDataReader);
		}
		public async Task<List<L_activity_langEO>> GetByIndexloginLinkUrlAsync(string indexloginLinkUrl, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IndexloginLinkUrl` = @IndexloginLinkUrl", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IndexloginLinkUrl", indexloginLinkUrl, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_activity_langEO.MapDataReader);
		}
		#endregion // GetByIndexloginLinkUrl
		#region GetByOrderNum
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序（从小到大）</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByOrderNum(int orderNum)
		{
			return GetByOrderNum(orderNum, 0, string.Empty, null);
		}
		public async Task<List<L_activity_langEO>> GetByOrderNumAsync(int orderNum)
		{
			return await GetByOrderNumAsync(orderNum, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序（从小到大）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByOrderNum(int orderNum, TransactionManager tm_)
		{
			return GetByOrderNum(orderNum, 0, string.Empty, tm_);
		}
		public async Task<List<L_activity_langEO>> GetByOrderNumAsync(int orderNum, TransactionManager tm_)
		{
			return await GetByOrderNumAsync(orderNum, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序（从小到大）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByOrderNum(int orderNum, int top_)
		{
			return GetByOrderNum(orderNum, top_, string.Empty, null);
		}
		public async Task<List<L_activity_langEO>> GetByOrderNumAsync(int orderNum, int top_)
		{
			return await GetByOrderNumAsync(orderNum, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序（从小到大）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByOrderNum(int orderNum, int top_, TransactionManager tm_)
		{
			return GetByOrderNum(orderNum, top_, string.Empty, tm_);
		}
		public async Task<List<L_activity_langEO>> GetByOrderNumAsync(int orderNum, int top_, TransactionManager tm_)
		{
			return await GetByOrderNumAsync(orderNum, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序（从小到大）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByOrderNum(int orderNum, string sort_)
		{
			return GetByOrderNum(orderNum, 0, sort_, null);
		}
		public async Task<List<L_activity_langEO>> GetByOrderNumAsync(int orderNum, string sort_)
		{
			return await GetByOrderNumAsync(orderNum, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序（从小到大）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByOrderNum(int orderNum, string sort_, TransactionManager tm_)
		{
			return GetByOrderNum(orderNum, 0, sort_, tm_);
		}
		public async Task<List<L_activity_langEO>> GetByOrderNumAsync(int orderNum, string sort_, TransactionManager tm_)
		{
			return await GetByOrderNumAsync(orderNum, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序（从小到大）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByOrderNum(int orderNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OrderNum` = @OrderNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OrderNum", orderNum, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, L_activity_langEO.MapDataReader);
		}
		public async Task<List<L_activity_langEO>> GetByOrderNumAsync(int orderNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OrderNum` = @OrderNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OrderNum", orderNum, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_activity_langEO.MapDataReader);
		}
		#endregion // GetByOrderNum
		#region GetByBeginDate
		
		/// <summary>
		/// 按 BeginDate（字段） 查询
		/// </summary>
		/// /// <param name = "beginDate">起始日期（默认2016-01-01）</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByBeginDate(DateTime beginDate)
		{
			return GetByBeginDate(beginDate, 0, string.Empty, null);
		}
		public async Task<List<L_activity_langEO>> GetByBeginDateAsync(DateTime beginDate)
		{
			return await GetByBeginDateAsync(beginDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BeginDate（字段） 查询
		/// </summary>
		/// /// <param name = "beginDate">起始日期（默认2016-01-01）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByBeginDate(DateTime beginDate, TransactionManager tm_)
		{
			return GetByBeginDate(beginDate, 0, string.Empty, tm_);
		}
		public async Task<List<L_activity_langEO>> GetByBeginDateAsync(DateTime beginDate, TransactionManager tm_)
		{
			return await GetByBeginDateAsync(beginDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BeginDate（字段） 查询
		/// </summary>
		/// /// <param name = "beginDate">起始日期（默认2016-01-01）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByBeginDate(DateTime beginDate, int top_)
		{
			return GetByBeginDate(beginDate, top_, string.Empty, null);
		}
		public async Task<List<L_activity_langEO>> GetByBeginDateAsync(DateTime beginDate, int top_)
		{
			return await GetByBeginDateAsync(beginDate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BeginDate（字段） 查询
		/// </summary>
		/// /// <param name = "beginDate">起始日期（默认2016-01-01）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByBeginDate(DateTime beginDate, int top_, TransactionManager tm_)
		{
			return GetByBeginDate(beginDate, top_, string.Empty, tm_);
		}
		public async Task<List<L_activity_langEO>> GetByBeginDateAsync(DateTime beginDate, int top_, TransactionManager tm_)
		{
			return await GetByBeginDateAsync(beginDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BeginDate（字段） 查询
		/// </summary>
		/// /// <param name = "beginDate">起始日期（默认2016-01-01）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByBeginDate(DateTime beginDate, string sort_)
		{
			return GetByBeginDate(beginDate, 0, sort_, null);
		}
		public async Task<List<L_activity_langEO>> GetByBeginDateAsync(DateTime beginDate, string sort_)
		{
			return await GetByBeginDateAsync(beginDate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BeginDate（字段） 查询
		/// </summary>
		/// /// <param name = "beginDate">起始日期（默认2016-01-01）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByBeginDate(DateTime beginDate, string sort_, TransactionManager tm_)
		{
			return GetByBeginDate(beginDate, 0, sort_, tm_);
		}
		public async Task<List<L_activity_langEO>> GetByBeginDateAsync(DateTime beginDate, string sort_, TransactionManager tm_)
		{
			return await GetByBeginDateAsync(beginDate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BeginDate（字段） 查询
		/// </summary>
		/// /// <param name = "beginDate">起始日期（默认2016-01-01）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByBeginDate(DateTime beginDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BeginDate` = @BeginDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BeginDate", beginDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, L_activity_langEO.MapDataReader);
		}
		public async Task<List<L_activity_langEO>> GetByBeginDateAsync(DateTime beginDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BeginDate` = @BeginDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BeginDate", beginDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_activity_langEO.MapDataReader);
		}
		#endregion // GetByBeginDate
		#region GetByEndDate
		
		/// <summary>
		/// 按 EndDate（字段） 查询
		/// </summary>
		/// /// <param name = "endDate">截止日期（默认2099-01-01）</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByEndDate(DateTime endDate)
		{
			return GetByEndDate(endDate, 0, string.Empty, null);
		}
		public async Task<List<L_activity_langEO>> GetByEndDateAsync(DateTime endDate)
		{
			return await GetByEndDateAsync(endDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 EndDate（字段） 查询
		/// </summary>
		/// /// <param name = "endDate">截止日期（默认2099-01-01）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByEndDate(DateTime endDate, TransactionManager tm_)
		{
			return GetByEndDate(endDate, 0, string.Empty, tm_);
		}
		public async Task<List<L_activity_langEO>> GetByEndDateAsync(DateTime endDate, TransactionManager tm_)
		{
			return await GetByEndDateAsync(endDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 EndDate（字段） 查询
		/// </summary>
		/// /// <param name = "endDate">截止日期（默认2099-01-01）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByEndDate(DateTime endDate, int top_)
		{
			return GetByEndDate(endDate, top_, string.Empty, null);
		}
		public async Task<List<L_activity_langEO>> GetByEndDateAsync(DateTime endDate, int top_)
		{
			return await GetByEndDateAsync(endDate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 EndDate（字段） 查询
		/// </summary>
		/// /// <param name = "endDate">截止日期（默认2099-01-01）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByEndDate(DateTime endDate, int top_, TransactionManager tm_)
		{
			return GetByEndDate(endDate, top_, string.Empty, tm_);
		}
		public async Task<List<L_activity_langEO>> GetByEndDateAsync(DateTime endDate, int top_, TransactionManager tm_)
		{
			return await GetByEndDateAsync(endDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 EndDate（字段） 查询
		/// </summary>
		/// /// <param name = "endDate">截止日期（默认2099-01-01）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByEndDate(DateTime endDate, string sort_)
		{
			return GetByEndDate(endDate, 0, sort_, null);
		}
		public async Task<List<L_activity_langEO>> GetByEndDateAsync(DateTime endDate, string sort_)
		{
			return await GetByEndDateAsync(endDate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 EndDate（字段） 查询
		/// </summary>
		/// /// <param name = "endDate">截止日期（默认2099-01-01）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByEndDate(DateTime endDate, string sort_, TransactionManager tm_)
		{
			return GetByEndDate(endDate, 0, sort_, tm_);
		}
		public async Task<List<L_activity_langEO>> GetByEndDateAsync(DateTime endDate, string sort_, TransactionManager tm_)
		{
			return await GetByEndDateAsync(endDate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 EndDate（字段） 查询
		/// </summary>
		/// /// <param name = "endDate">截止日期（默认2099-01-01）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByEndDate(DateTime endDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`EndDate` = @EndDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@EndDate", endDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, L_activity_langEO.MapDataReader);
		}
		public async Task<List<L_activity_langEO>> GetByEndDateAsync(DateTime endDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`EndDate` = @EndDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@EndDate", endDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_activity_langEO.MapDataReader);
		}
		#endregion // GetByEndDate
		#region GetByStatus
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByStatus(int status)
		{
			return GetByStatus(status, 0, string.Empty, null);
		}
		public async Task<List<L_activity_langEO>> GetByStatusAsync(int status)
		{
			return await GetByStatusAsync(status, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByStatus(int status, TransactionManager tm_)
		{
			return GetByStatus(status, 0, string.Empty, tm_);
		}
		public async Task<List<L_activity_langEO>> GetByStatusAsync(int status, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByStatus(int status, int top_)
		{
			return GetByStatus(status, top_, string.Empty, null);
		}
		public async Task<List<L_activity_langEO>> GetByStatusAsync(int status, int top_)
		{
			return await GetByStatusAsync(status, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByStatus(int status, int top_, TransactionManager tm_)
		{
			return GetByStatus(status, top_, string.Empty, tm_);
		}
		public async Task<List<L_activity_langEO>> GetByStatusAsync(int status, int top_, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByStatus(int status, string sort_)
		{
			return GetByStatus(status, 0, sort_, null);
		}
		public async Task<List<L_activity_langEO>> GetByStatusAsync(int status, string sort_)
		{
			return await GetByStatusAsync(status, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByStatus(int status, string sort_, TransactionManager tm_)
		{
			return GetByStatus(status, 0, sort_, tm_);
		}
		public async Task<List<L_activity_langEO>> GetByStatusAsync(int status, string sort_, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_activity_langEO> GetByStatus(int status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, L_activity_langEO.MapDataReader);
		}
		public async Task<List<L_activity_langEO>> GetByStatusAsync(int status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_activity_langEO.MapDataReader);
		}
		#endregion // GetByStatus
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
