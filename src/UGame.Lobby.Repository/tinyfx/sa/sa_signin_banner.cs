/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * AiUo代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/AiUo
 * 文档生成时间：2023-06-02 13: 35:02
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
	/// 
	/// 【表 sa_signin_banner 的实体类】
	/// </summary>
	[DataContract]
	public class Sa_signin_bannerEO : IRowMapper<Sa_signin_bannerEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Sa_signin_bannerEO()
		{
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private string _originalBannerID;
		/// <summary>
		/// 【数据库中的原始主键 BannerID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalBannerID
		{
			get { return _originalBannerID; }
			set { HasOriginal = true; _originalBannerID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "BannerID", BannerID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// id
		/// 【主键 varchar(36)】
		/// </summary>
		[DataMember(Order = 1)]
		public string BannerID { get; set; }
		/// <summary>
		/// 标题
		/// 【字段 varchar(100)】
		/// </summary>
		[DataMember(Order = 2)]
		public string Title { get; set; }
		/// <summary>
		/// 摘要
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 3)]
		public string Summary { get; set; }
		/// <summary>
		/// 图片相对路径
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 4)]
		public string PicPath { get; set; }
		/// <summary>
		/// 是否有效
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 5)]
		public int? Status { get; set; }
		/// <summary>
		/// 排序
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 6)]
		public int? Index { get; set; }
		/// <summary>
		/// 类型1banner2活动中心3支付中心
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 7)]
		public int? Type { get; set; }
		/// <summary>
		/// 跳转的页面
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 8)]
		public string GoPage { get; set; }
		/// <summary>
		/// 添加时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 9)]
		public DateTime? RecDate { get; set; }
		/// <summary>
		/// 
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 10)]
		public string OperatorID { get; set; }
		/// <summary>
		/// 
		/// 【字段 varchar(5)】
		/// </summary>
		[DataMember(Order = 11)]
		public string CountryID { get; set; }
		/// <summary>
		/// 
		/// 【字段 varchar(5)】
		/// </summary>
		[DataMember(Order = 12)]
		public string CurrencyID { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Sa_signin_bannerEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Sa_signin_bannerEO MapDataReader(IDataReader reader)
		{
		    Sa_signin_bannerEO ret = new Sa_signin_bannerEO();
			ret.BannerID = reader.ToString("BannerID");
			ret.OriginalBannerID = ret.BannerID;
			ret.Title = reader.ToString("Title");
			ret.Summary = reader.ToString("Summary");
			ret.PicPath = reader.ToString("PicPath");
			ret.Status = reader.ToInt32N("Status");
			ret.Index = reader.ToInt32N("Index");
			ret.Type = reader.ToInt32N("Type");
			ret.GoPage = reader.ToString("GoPage");
			ret.RecDate = reader.ToDateTimeN("RecDate");
			ret.OperatorID = reader.ToString("OperatorID");
			ret.CountryID = reader.ToString("CountryID");
			ret.CurrencyID = reader.ToString("CurrencyID");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 
	/// 【表 sa_signin_banner 的操作类】
	/// </summary>
	public class Sa_signin_bannerMO : MySqlTableMO<Sa_signin_bannerEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`sa_signin_banner`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Sa_signin_bannerMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Sa_signin_bannerMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Sa_signin_bannerMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Sa_signin_bannerEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Sa_signin_bannerEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Sa_signin_bannerEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`BannerID`, `Title`, `Summary`, `PicPath`, `Status`, `Index`, `Type`, `GoPage`, `RecDate`, `OperatorID`, `CountryID`, `CurrencyID`) VALUE (@BannerID, @Title, @Summary, @PicPath, @Status, @Index, @Type, @GoPage, @RecDate, @OperatorID, @CountryID, @CurrencyID);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BannerID", item.BannerID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Title", item.Title != null ? item.Title : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Summary", item.Summary != null ? item.Summary : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@PicPath", item.PicPath != null ? item.PicPath : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Status", item.Status.HasValue ? item.Status.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@Index", item.Index.HasValue ? item.Index.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@Type", item.Type.HasValue ? item.Type.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@GoPage", item.GoPage != null ? item.GoPage : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@RecDate", item.RecDate.HasValue ? item.RecDate.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@OperatorID", item.OperatorID != null ? item.OperatorID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", item.CountryID != null ? item.CountryID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID != null ? item.CurrencyID : (object)DBNull.Value, MySqlDbType.VarChar),
			};
		}
		public int AddByBatch(IEnumerable<Sa_signin_bannerEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Sa_signin_bannerEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sa_signin_bannerEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`BannerID`, `Title`, `Summary`, `PicPath`, `Status`, `Index`, `Type`, `GoPage`, `RecDate`, `OperatorID`, `CountryID`, `CurrencyID`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.BannerID}','{item.Title}','{item.Summary}','{item.PicPath}',{item.Status?.ToString()??null},{item.Index?.ToString()??null},{item.Type?.ToString()??null},'{item.GoPage}','{item.RecDate?.ToString("yyyy-MM-dd HH:mm:ss")}','{item.OperatorID}','{item.CountryID}','{item.CurrencyID}'),");
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
		/// /// <param name = "bannerID">id</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string bannerID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(bannerID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string bannerID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(bannerID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string bannerID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `BannerID` = @BannerID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Sa_signin_bannerEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.BannerID, tm_);
		}
		public async Task<int> RemoveAsync(Sa_signin_bannerEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.BannerID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
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
		#region RemoveBySummary
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "summary">摘要</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveBySummary(string summary, TransactionManager tm_ = null)
		{
			RepairRemoveBySummaryData(summary, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveBySummaryAsync(string summary, TransactionManager tm_ = null)
		{
			RepairRemoveBySummaryData(summary, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveBySummaryData(string summary, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (summary != null ? "`Summary` = @Summary" : "`Summary` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (summary != null)
				paras_.Add(Database.CreateInParameter("@Summary", summary, MySqlDbType.VarChar));
		}
		#endregion // RemoveBySummary
		#region RemoveByPicPath
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "picPath">图片相对路径</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPicPath(string picPath, TransactionManager tm_ = null)
		{
			RepairRemoveByPicPathData(picPath, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPicPathAsync(string picPath, TransactionManager tm_ = null)
		{
			RepairRemoveByPicPathData(picPath, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByPicPathData(string picPath, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (picPath != null ? "`PicPath` = @PicPath" : "`PicPath` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (picPath != null)
				paras_.Add(Database.CreateInParameter("@PicPath", picPath, MySqlDbType.VarChar));
		}
		#endregion // RemoveByPicPath
		#region RemoveByStatus
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "status">是否有效</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByStatus(int? status, TransactionManager tm_ = null)
		{
			RepairRemoveByStatusData(status.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByStatusAsync(int? status, TransactionManager tm_ = null)
		{
			RepairRemoveByStatusData(status.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByStatusData(int? status, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (status.HasValue ? "`Status` = @Status" : "`Status` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (status.HasValue)
				paras_.Add(Database.CreateInParameter("@Status", status.Value, MySqlDbType.Int32));
		}
		#endregion // RemoveByStatus
		#region RemoveByIndex
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "index">排序</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByIndex(int? index, TransactionManager tm_ = null)
		{
			RepairRemoveByIndexData(index.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByIndexAsync(int? index, TransactionManager tm_ = null)
		{
			RepairRemoveByIndexData(index.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByIndexData(int? index, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (index.HasValue ? "`Index` = @Index" : "`Index` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (index.HasValue)
				paras_.Add(Database.CreateInParameter("@Index", index.Value, MySqlDbType.Int32));
		}
		#endregion // RemoveByIndex
		#region RemoveByType
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "type">类型1banner2活动中心3支付中心</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByType(int? type, TransactionManager tm_ = null)
		{
			RepairRemoveByTypeData(type.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTypeAsync(int? type, TransactionManager tm_ = null)
		{
			RepairRemoveByTypeData(type.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTypeData(int? type, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (type.HasValue ? "`Type` = @Type" : "`Type` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (type.HasValue)
				paras_.Add(Database.CreateInParameter("@Type", type.Value, MySqlDbType.Int32));
		}
		#endregion // RemoveByType
		#region RemoveByGoPage
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "goPage">跳转的页面</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByGoPage(string goPage, TransactionManager tm_ = null)
		{
			RepairRemoveByGoPageData(goPage, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByGoPageAsync(string goPage, TransactionManager tm_ = null)
		{
			RepairRemoveByGoPageData(goPage, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByGoPageData(string goPage, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (goPage != null ? "`GoPage` = @GoPage" : "`GoPage` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (goPage != null)
				paras_.Add(Database.CreateInParameter("@GoPage", goPage, MySqlDbType.VarChar));
		}
		#endregion // RemoveByGoPage
		#region RemoveByRecDate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "recDate">添加时间</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByRecDate(DateTime? recDate, TransactionManager tm_ = null)
		{
			RepairRemoveByRecDateData(recDate.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByRecDateAsync(DateTime? recDate, TransactionManager tm_ = null)
		{
			RepairRemoveByRecDateData(recDate.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByRecDateData(DateTime? recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (recDate.HasValue ? "`RecDate` = @RecDate" : "`RecDate` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (recDate.HasValue)
				paras_.Add(Database.CreateInParameter("@RecDate", recDate.Value, MySqlDbType.DateTime));
		}
		#endregion // RemoveByRecDate
		#region RemoveByOperatorID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "operatorID"></param>
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
			sql_ = $"DELETE FROM {TableName} WHERE " + (operatorID != null ? "`OperatorID` = @OperatorID" : "`OperatorID` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (operatorID != null)
				paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByOperatorID
		#region RemoveByCountryID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "countryID"></param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCountryID(string countryID, TransactionManager tm_ = null)
		{
			RepairRemoveByCountryIDData(countryID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCountryIDAsync(string countryID, TransactionManager tm_ = null)
		{
			RepairRemoveByCountryIDData(countryID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCountryIDData(string countryID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (countryID != null ? "`CountryID` = @CountryID" : "`CountryID` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (countryID != null)
				paras_.Add(Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByCountryID
		#region RemoveByCurrencyID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "currencyID"></param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCurrencyID(string currencyID, TransactionManager tm_ = null)
		{
			RepairRemoveByCurrencyIDData(currencyID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCurrencyIDAsync(string currencyID, TransactionManager tm_ = null)
		{
			RepairRemoveByCurrencyIDData(currencyID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCurrencyIDData(string currencyID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (currencyID != null ? "`CurrencyID` = @CurrencyID" : "`CurrencyID` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (currencyID != null)
				paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByCurrencyID
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
		public int Put(Sa_signin_bannerEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Sa_signin_bannerEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Sa_signin_bannerEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BannerID` = @BannerID, `Title` = @Title, `Summary` = @Summary, `PicPath` = @PicPath, `Status` = @Status, `Index` = @Index, `Type` = @Type, `GoPage` = @GoPage, `RecDate` = @RecDate, `OperatorID` = @OperatorID, `CountryID` = @CountryID, `CurrencyID` = @CurrencyID WHERE `BannerID` = @BannerID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BannerID", item.BannerID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Title", item.Title != null ? item.Title : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Summary", item.Summary != null ? item.Summary : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@PicPath", item.PicPath != null ? item.PicPath : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Status", item.Status.HasValue ? item.Status.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@Index", item.Index.HasValue ? item.Index.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@Type", item.Type.HasValue ? item.Type.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@GoPage", item.GoPage != null ? item.GoPage : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@RecDate", item.RecDate.HasValue ? item.RecDate.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@OperatorID", item.OperatorID != null ? item.OperatorID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", item.CountryID != null ? item.CountryID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID != null ? item.CurrencyID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@BannerID_Original", item.HasOriginal ? item.OriginalBannerID : item.BannerID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Sa_signin_bannerEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Sa_signin_bannerEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "bannerID">id</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string bannerID, string set_, params object[] values_)
		{
			return Put(set_, "`BannerID` = @BannerID", ConcatValues(values_, bannerID));
		}
		public async Task<int> PutByPKAsync(string bannerID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`BannerID` = @BannerID", ConcatValues(values_, bannerID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "bannerID">id</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string bannerID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`BannerID` = @BannerID", tm_, ConcatValues(values_, bannerID));
		}
		public async Task<int> PutByPKAsync(string bannerID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`BannerID` = @BannerID", tm_, ConcatValues(values_, bannerID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "bannerID">id</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string bannerID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`BannerID` = @BannerID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string bannerID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`BannerID` = @BannerID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutTitle
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "bannerID">id</param>
		/// /// <param name = "title">标题</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTitleByPK(string bannerID, string title, TransactionManager tm_ = null)
		{
			RepairPutTitleByPKData(bannerID, title, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTitleByPKAsync(string bannerID, string title, TransactionManager tm_ = null)
		{
			RepairPutTitleByPKData(bannerID, title, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTitleByPKData(string bannerID, string title, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Title` = @Title  WHERE `BannerID` = @BannerID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Title", title != null ? title : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
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
		#region PutSummary
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "bannerID">id</param>
		/// /// <param name = "summary">摘要</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSummaryByPK(string bannerID, string summary, TransactionManager tm_ = null)
		{
			RepairPutSummaryByPKData(bannerID, summary, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutSummaryByPKAsync(string bannerID, string summary, TransactionManager tm_ = null)
		{
			RepairPutSummaryByPKData(bannerID, summary, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutSummaryByPKData(string bannerID, string summary, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Summary` = @Summary  WHERE `BannerID` = @BannerID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Summary", summary != null ? summary : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "summary">摘要</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSummary(string summary, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Summary` = @Summary";
			var parameter_ = Database.CreateInParameter("@Summary", summary != null ? summary : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutSummaryAsync(string summary, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Summary` = @Summary";
			var parameter_ = Database.CreateInParameter("@Summary", summary != null ? summary : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutSummary
		#region PutPicPath
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "bannerID">id</param>
		/// /// <param name = "picPath">图片相对路径</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPicPathByPK(string bannerID, string picPath, TransactionManager tm_ = null)
		{
			RepairPutPicPathByPKData(bannerID, picPath, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutPicPathByPKAsync(string bannerID, string picPath, TransactionManager tm_ = null)
		{
			RepairPutPicPathByPKData(bannerID, picPath, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutPicPathByPKData(string bannerID, string picPath, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `PicPath` = @PicPath  WHERE `BannerID` = @BannerID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PicPath", picPath != null ? picPath : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "picPath">图片相对路径</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPicPath(string picPath, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PicPath` = @PicPath";
			var parameter_ = Database.CreateInParameter("@PicPath", picPath != null ? picPath : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutPicPathAsync(string picPath, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PicPath` = @PicPath";
			var parameter_ = Database.CreateInParameter("@PicPath", picPath != null ? picPath : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutPicPath
		#region PutStatus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "bannerID">id</param>
		/// /// <param name = "status">是否有效</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutStatusByPK(string bannerID, int? status, TransactionManager tm_ = null)
		{
			RepairPutStatusByPKData(bannerID, status, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutStatusByPKAsync(string bannerID, int? status, TransactionManager tm_ = null)
		{
			RepairPutStatusByPKData(bannerID, status, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutStatusByPKData(string bannerID, int? status, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Status` = @Status  WHERE `BannerID` = @BannerID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Status", status.HasValue ? status.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "status">是否有效</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutStatus(int? status, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Status` = @Status";
			var parameter_ = Database.CreateInParameter("@Status", status.HasValue ? status.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutStatusAsync(int? status, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Status` = @Status";
			var parameter_ = Database.CreateInParameter("@Status", status.HasValue ? status.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutStatus
		#region PutIndex
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "bannerID">id</param>
		/// /// <param name = "index">排序</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIndexByPK(string bannerID, int? index, TransactionManager tm_ = null)
		{
			RepairPutIndexByPKData(bannerID, index, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutIndexByPKAsync(string bannerID, int? index, TransactionManager tm_ = null)
		{
			RepairPutIndexByPKData(bannerID, index, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutIndexByPKData(string bannerID, int? index, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Index` = @Index  WHERE `BannerID` = @BannerID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Index", index.HasValue ? index.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "index">排序</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIndex(int? index, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Index` = @Index";
			var parameter_ = Database.CreateInParameter("@Index", index.HasValue ? index.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutIndexAsync(int? index, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Index` = @Index";
			var parameter_ = Database.CreateInParameter("@Index", index.HasValue ? index.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutIndex
		#region PutType
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "bannerID">id</param>
		/// /// <param name = "type">类型1banner2活动中心3支付中心</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTypeByPK(string bannerID, int? type, TransactionManager tm_ = null)
		{
			RepairPutTypeByPKData(bannerID, type, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTypeByPKAsync(string bannerID, int? type, TransactionManager tm_ = null)
		{
			RepairPutTypeByPKData(bannerID, type, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTypeByPKData(string bannerID, int? type, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Type` = @Type  WHERE `BannerID` = @BannerID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Type", type.HasValue ? type.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "type">类型1banner2活动中心3支付中心</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutType(int? type, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Type` = @Type";
			var parameter_ = Database.CreateInParameter("@Type", type.HasValue ? type.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTypeAsync(int? type, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Type` = @Type";
			var parameter_ = Database.CreateInParameter("@Type", type.HasValue ? type.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutType
		#region PutGoPage
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "bannerID">id</param>
		/// /// <param name = "goPage">跳转的页面</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutGoPageByPK(string bannerID, string goPage, TransactionManager tm_ = null)
		{
			RepairPutGoPageByPKData(bannerID, goPage, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutGoPageByPKAsync(string bannerID, string goPage, TransactionManager tm_ = null)
		{
			RepairPutGoPageByPKData(bannerID, goPage, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutGoPageByPKData(string bannerID, string goPage, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `GoPage` = @GoPage  WHERE `BannerID` = @BannerID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@GoPage", goPage != null ? goPage : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "goPage">跳转的页面</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutGoPage(string goPage, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `GoPage` = @GoPage";
			var parameter_ = Database.CreateInParameter("@GoPage", goPage != null ? goPage : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutGoPageAsync(string goPage, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `GoPage` = @GoPage";
			var parameter_ = Database.CreateInParameter("@GoPage", goPage != null ? goPage : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutGoPage
		#region PutRecDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "bannerID">id</param>
		/// /// <param name = "recDate">添加时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(string bannerID, DateTime? recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(bannerID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(string bannerID, DateTime? recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(bannerID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(string bannerID, DateTime? recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `BannerID` = @BannerID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate.HasValue ? recDate.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "recDate">添加时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDate(DateTime? recDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate";
			var parameter_ = Database.CreateInParameter("@RecDate", recDate.HasValue ? recDate.Value : (object)DBNull.Value, MySqlDbType.DateTime);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutRecDateAsync(DateTime? recDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate";
			var parameter_ = Database.CreateInParameter("@RecDate", recDate.HasValue ? recDate.Value : (object)DBNull.Value, MySqlDbType.DateTime);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutRecDate
		#region PutOperatorID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "bannerID">id</param>
		/// /// <param name = "operatorID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorIDByPK(string bannerID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(bannerID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOperatorIDByPKAsync(string bannerID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(bannerID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOperatorIDByPKData(string bannerID, string operatorID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID  WHERE `BannerID` = @BannerID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID != null ? operatorID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "operatorID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorID(string operatorID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID";
			var parameter_ = Database.CreateInParameter("@OperatorID", operatorID != null ? operatorID : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutOperatorIDAsync(string operatorID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID";
			var parameter_ = Database.CreateInParameter("@OperatorID", operatorID != null ? operatorID : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutOperatorID
		#region PutCountryID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "bannerID">id</param>
		/// /// <param name = "countryID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCountryIDByPK(string bannerID, string countryID, TransactionManager tm_ = null)
		{
			RepairPutCountryIDByPKData(bannerID, countryID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCountryIDByPKAsync(string bannerID, string countryID, TransactionManager tm_ = null)
		{
			RepairPutCountryIDByPKData(bannerID, countryID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCountryIDByPKData(string bannerID, string countryID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CountryID` = @CountryID  WHERE `BannerID` = @BannerID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryID", countryID != null ? countryID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "countryID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCountryID(string countryID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CountryID` = @CountryID";
			var parameter_ = Database.CreateInParameter("@CountryID", countryID != null ? countryID : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCountryIDAsync(string countryID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CountryID` = @CountryID";
			var parameter_ = Database.CreateInParameter("@CountryID", countryID != null ? countryID : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCountryID
		#region PutCurrencyID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "bannerID">id</param>
		/// /// <param name = "currencyID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCurrencyIDByPK(string bannerID, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(bannerID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCurrencyIDByPKAsync(string bannerID, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(bannerID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCurrencyIDByPKData(string bannerID, string currencyID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CurrencyID` = @CurrencyID  WHERE `BannerID` = @BannerID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CurrencyID", currencyID != null ? currencyID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "currencyID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCurrencyID(string currencyID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CurrencyID` = @CurrencyID";
			var parameter_ = Database.CreateInParameter("@CurrencyID", currencyID != null ? currencyID : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCurrencyIDAsync(string currencyID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CurrencyID` = @CurrencyID";
			var parameter_ = Database.CreateInParameter("@CurrencyID", currencyID != null ? currencyID : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCurrencyID
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Sa_signin_bannerEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.BannerID) == null)
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
		public async Task<bool> SetAsync(Sa_signin_bannerEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.BannerID) == null)
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
		/// /// <param name = "bannerID">id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Sa_signin_bannerEO GetByPK(string bannerID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(bannerID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sa_signin_bannerEO.MapDataReader);
		}
		public async Task<Sa_signin_bannerEO> GetByPKAsync(string bannerID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(bannerID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sa_signin_bannerEO.MapDataReader);
		}
		private void RepairGetByPKData(string bannerID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false)
		{
			sql_ = BuildSelectSQL("`BannerID` = @BannerID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 Title（字段）
		/// </summary>
		/// /// <param name = "bannerID">id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetTitleByPK(string bannerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Title`", "`BannerID` = @BannerID", paras_, tm_);
		}
		public async Task<string> GetTitleByPKAsync(string bannerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Title`", "`BannerID` = @BannerID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Summary（字段）
		/// </summary>
		/// /// <param name = "bannerID">id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetSummaryByPK(string bannerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Summary`", "`BannerID` = @BannerID", paras_, tm_);
		}
		public async Task<string> GetSummaryByPKAsync(string bannerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Summary`", "`BannerID` = @BannerID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 PicPath（字段）
		/// </summary>
		/// /// <param name = "bannerID">id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetPicPathByPK(string bannerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`PicPath`", "`BannerID` = @BannerID", paras_, tm_);
		}
		public async Task<string> GetPicPathByPKAsync(string bannerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`PicPath`", "`BannerID` = @BannerID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Status（字段）
		/// </summary>
		/// /// <param name = "bannerID">id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int? GetStatusByPK(string bannerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
			return (int?)GetScalar("`Status`", "`BannerID` = @BannerID", paras_, tm_);
		}
		public async Task<int?> GetStatusByPKAsync(string bannerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
			return (int?)await GetScalarAsync("`Status`", "`BannerID` = @BannerID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Index（字段）
		/// </summary>
		/// /// <param name = "bannerID">id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int? GetIndexByPK(string bannerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
			return (int?)GetScalar("`Index`", "`BannerID` = @BannerID", paras_, tm_);
		}
		public async Task<int?> GetIndexByPKAsync(string bannerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
			return (int?)await GetScalarAsync("`Index`", "`BannerID` = @BannerID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Type（字段）
		/// </summary>
		/// /// <param name = "bannerID">id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int? GetTypeByPK(string bannerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
			return (int?)GetScalar("`Type`", "`BannerID` = @BannerID", paras_, tm_);
		}
		public async Task<int?> GetTypeByPKAsync(string bannerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
			return (int?)await GetScalarAsync("`Type`", "`BannerID` = @BannerID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 GoPage（字段）
		/// </summary>
		/// /// <param name = "bannerID">id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetGoPageByPK(string bannerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`GoPage`", "`BannerID` = @BannerID", paras_, tm_);
		}
		public async Task<string> GetGoPageByPKAsync(string bannerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`GoPage`", "`BannerID` = @BannerID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "bannerID">id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime? GetRecDateByPK(string bannerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
			return (DateTime?)GetScalar("`RecDate`", "`BannerID` = @BannerID", paras_, tm_);
		}
		public async Task<DateTime?> GetRecDateByPKAsync(string bannerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
			return (DateTime?)await GetScalarAsync("`RecDate`", "`BannerID` = @BannerID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OperatorID（字段）
		/// </summary>
		/// /// <param name = "bannerID">id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorIDByPK(string bannerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OperatorID`", "`BannerID` = @BannerID", paras_, tm_);
		}
		public async Task<string> GetOperatorIDByPKAsync(string bannerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OperatorID`", "`BannerID` = @BannerID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CountryID（字段）
		/// </summary>
		/// /// <param name = "bannerID">id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCountryIDByPK(string bannerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CountryID`", "`BannerID` = @BannerID", paras_, tm_);
		}
		public async Task<string> GetCountryIDByPKAsync(string bannerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CountryID`", "`BannerID` = @BannerID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CurrencyID（字段）
		/// </summary>
		/// /// <param name = "bannerID">id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCurrencyIDByPK(string bannerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CurrencyID`", "`BannerID` = @BannerID", paras_, tm_);
		}
		public async Task<string> GetCurrencyIDByPKAsync(string bannerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CurrencyID`", "`BannerID` = @BannerID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByTitle
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">标题</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByTitle(string title)
		{
			return GetByTitle(title, 0, string.Empty, null);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByTitleAsync(string title)
		{
			return await GetByTitleAsync(title, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">标题</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByTitle(string title, TransactionManager tm_)
		{
			return GetByTitle(title, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByTitleAsync(string title, TransactionManager tm_)
		{
			return await GetByTitleAsync(title, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">标题</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByTitle(string title, int top_)
		{
			return GetByTitle(title, top_, string.Empty, null);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByTitleAsync(string title, int top_)
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
		public List<Sa_signin_bannerEO> GetByTitle(string title, int top_, TransactionManager tm_)
		{
			return GetByTitle(title, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByTitleAsync(string title, int top_, TransactionManager tm_)
		{
			return await GetByTitleAsync(title, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">标题</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByTitle(string title, string sort_)
		{
			return GetByTitle(title, 0, sort_, null);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByTitleAsync(string title, string sort_)
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
		public List<Sa_signin_bannerEO> GetByTitle(string title, string sort_, TransactionManager tm_)
		{
			return GetByTitle(title, 0, sort_, tm_);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByTitleAsync(string title, string sort_, TransactionManager tm_)
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
		public List<Sa_signin_bannerEO> GetByTitle(string title, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(title != null ? "`Title` = @Title" : "`Title` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (title != null)
				paras_.Add(Database.CreateInParameter("@Title", title, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_signin_bannerEO.MapDataReader);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByTitleAsync(string title, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(title != null ? "`Title` = @Title" : "`Title` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (title != null)
				paras_.Add(Database.CreateInParameter("@Title", title, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_signin_bannerEO.MapDataReader);
		}
		#endregion // GetByTitle
		#region GetBySummary
		
		/// <summary>
		/// 按 Summary（字段） 查询
		/// </summary>
		/// /// <param name = "summary">摘要</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetBySummary(string summary)
		{
			return GetBySummary(summary, 0, string.Empty, null);
		}
		public async Task<List<Sa_signin_bannerEO>> GetBySummaryAsync(string summary)
		{
			return await GetBySummaryAsync(summary, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Summary（字段） 查询
		/// </summary>
		/// /// <param name = "summary">摘要</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetBySummary(string summary, TransactionManager tm_)
		{
			return GetBySummary(summary, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_signin_bannerEO>> GetBySummaryAsync(string summary, TransactionManager tm_)
		{
			return await GetBySummaryAsync(summary, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Summary（字段） 查询
		/// </summary>
		/// /// <param name = "summary">摘要</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetBySummary(string summary, int top_)
		{
			return GetBySummary(summary, top_, string.Empty, null);
		}
		public async Task<List<Sa_signin_bannerEO>> GetBySummaryAsync(string summary, int top_)
		{
			return await GetBySummaryAsync(summary, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Summary（字段） 查询
		/// </summary>
		/// /// <param name = "summary">摘要</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetBySummary(string summary, int top_, TransactionManager tm_)
		{
			return GetBySummary(summary, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_signin_bannerEO>> GetBySummaryAsync(string summary, int top_, TransactionManager tm_)
		{
			return await GetBySummaryAsync(summary, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Summary（字段） 查询
		/// </summary>
		/// /// <param name = "summary">摘要</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetBySummary(string summary, string sort_)
		{
			return GetBySummary(summary, 0, sort_, null);
		}
		public async Task<List<Sa_signin_bannerEO>> GetBySummaryAsync(string summary, string sort_)
		{
			return await GetBySummaryAsync(summary, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Summary（字段） 查询
		/// </summary>
		/// /// <param name = "summary">摘要</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetBySummary(string summary, string sort_, TransactionManager tm_)
		{
			return GetBySummary(summary, 0, sort_, tm_);
		}
		public async Task<List<Sa_signin_bannerEO>> GetBySummaryAsync(string summary, string sort_, TransactionManager tm_)
		{
			return await GetBySummaryAsync(summary, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Summary（字段） 查询
		/// </summary>
		/// /// <param name = "summary">摘要</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetBySummary(string summary, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(summary != null ? "`Summary` = @Summary" : "`Summary` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (summary != null)
				paras_.Add(Database.CreateInParameter("@Summary", summary, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_signin_bannerEO.MapDataReader);
		}
		public async Task<List<Sa_signin_bannerEO>> GetBySummaryAsync(string summary, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(summary != null ? "`Summary` = @Summary" : "`Summary` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (summary != null)
				paras_.Add(Database.CreateInParameter("@Summary", summary, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_signin_bannerEO.MapDataReader);
		}
		#endregion // GetBySummary
		#region GetByPicPath
		
		/// <summary>
		/// 按 PicPath（字段） 查询
		/// </summary>
		/// /// <param name = "picPath">图片相对路径</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByPicPath(string picPath)
		{
			return GetByPicPath(picPath, 0, string.Empty, null);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByPicPathAsync(string picPath)
		{
			return await GetByPicPathAsync(picPath, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PicPath（字段） 查询
		/// </summary>
		/// /// <param name = "picPath">图片相对路径</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByPicPath(string picPath, TransactionManager tm_)
		{
			return GetByPicPath(picPath, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByPicPathAsync(string picPath, TransactionManager tm_)
		{
			return await GetByPicPathAsync(picPath, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PicPath（字段） 查询
		/// </summary>
		/// /// <param name = "picPath">图片相对路径</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByPicPath(string picPath, int top_)
		{
			return GetByPicPath(picPath, top_, string.Empty, null);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByPicPathAsync(string picPath, int top_)
		{
			return await GetByPicPathAsync(picPath, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PicPath（字段） 查询
		/// </summary>
		/// /// <param name = "picPath">图片相对路径</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByPicPath(string picPath, int top_, TransactionManager tm_)
		{
			return GetByPicPath(picPath, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByPicPathAsync(string picPath, int top_, TransactionManager tm_)
		{
			return await GetByPicPathAsync(picPath, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PicPath（字段） 查询
		/// </summary>
		/// /// <param name = "picPath">图片相对路径</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByPicPath(string picPath, string sort_)
		{
			return GetByPicPath(picPath, 0, sort_, null);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByPicPathAsync(string picPath, string sort_)
		{
			return await GetByPicPathAsync(picPath, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PicPath（字段） 查询
		/// </summary>
		/// /// <param name = "picPath">图片相对路径</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByPicPath(string picPath, string sort_, TransactionManager tm_)
		{
			return GetByPicPath(picPath, 0, sort_, tm_);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByPicPathAsync(string picPath, string sort_, TransactionManager tm_)
		{
			return await GetByPicPathAsync(picPath, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PicPath（字段） 查询
		/// </summary>
		/// /// <param name = "picPath">图片相对路径</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByPicPath(string picPath, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(picPath != null ? "`PicPath` = @PicPath" : "`PicPath` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (picPath != null)
				paras_.Add(Database.CreateInParameter("@PicPath", picPath, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_signin_bannerEO.MapDataReader);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByPicPathAsync(string picPath, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(picPath != null ? "`PicPath` = @PicPath" : "`PicPath` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (picPath != null)
				paras_.Add(Database.CreateInParameter("@PicPath", picPath, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_signin_bannerEO.MapDataReader);
		}
		#endregion // GetByPicPath
		#region GetByStatus
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">是否有效</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByStatus(int? status)
		{
			return GetByStatus(status, 0, string.Empty, null);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByStatusAsync(int? status)
		{
			return await GetByStatusAsync(status, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">是否有效</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByStatus(int? status, TransactionManager tm_)
		{
			return GetByStatus(status, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByStatusAsync(int? status, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">是否有效</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByStatus(int? status, int top_)
		{
			return GetByStatus(status, top_, string.Empty, null);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByStatusAsync(int? status, int top_)
		{
			return await GetByStatusAsync(status, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">是否有效</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByStatus(int? status, int top_, TransactionManager tm_)
		{
			return GetByStatus(status, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByStatusAsync(int? status, int top_, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">是否有效</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByStatus(int? status, string sort_)
		{
			return GetByStatus(status, 0, sort_, null);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByStatusAsync(int? status, string sort_)
		{
			return await GetByStatusAsync(status, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">是否有效</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByStatus(int? status, string sort_, TransactionManager tm_)
		{
			return GetByStatus(status, 0, sort_, tm_);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByStatusAsync(int? status, string sort_, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">是否有效</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByStatus(int? status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(status.HasValue ? "`Status` = @Status" : "`Status` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (status.HasValue)
				paras_.Add(Database.CreateInParameter("@Status", status.Value, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_signin_bannerEO.MapDataReader);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByStatusAsync(int? status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(status.HasValue ? "`Status` = @Status" : "`Status` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (status.HasValue)
				paras_.Add(Database.CreateInParameter("@Status", status.Value, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_signin_bannerEO.MapDataReader);
		}
		#endregion // GetByStatus
		#region GetByIndex
		
		/// <summary>
		/// 按 Index（字段） 查询
		/// </summary>
		/// /// <param name = "index">排序</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByIndex(int? index)
		{
			return GetByIndex(index, 0, string.Empty, null);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByIndexAsync(int? index)
		{
			return await GetByIndexAsync(index, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Index（字段） 查询
		/// </summary>
		/// /// <param name = "index">排序</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByIndex(int? index, TransactionManager tm_)
		{
			return GetByIndex(index, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByIndexAsync(int? index, TransactionManager tm_)
		{
			return await GetByIndexAsync(index, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Index（字段） 查询
		/// </summary>
		/// /// <param name = "index">排序</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByIndex(int? index, int top_)
		{
			return GetByIndex(index, top_, string.Empty, null);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByIndexAsync(int? index, int top_)
		{
			return await GetByIndexAsync(index, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Index（字段） 查询
		/// </summary>
		/// /// <param name = "index">排序</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByIndex(int? index, int top_, TransactionManager tm_)
		{
			return GetByIndex(index, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByIndexAsync(int? index, int top_, TransactionManager tm_)
		{
			return await GetByIndexAsync(index, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Index（字段） 查询
		/// </summary>
		/// /// <param name = "index">排序</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByIndex(int? index, string sort_)
		{
			return GetByIndex(index, 0, sort_, null);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByIndexAsync(int? index, string sort_)
		{
			return await GetByIndexAsync(index, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Index（字段） 查询
		/// </summary>
		/// /// <param name = "index">排序</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByIndex(int? index, string sort_, TransactionManager tm_)
		{
			return GetByIndex(index, 0, sort_, tm_);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByIndexAsync(int? index, string sort_, TransactionManager tm_)
		{
			return await GetByIndexAsync(index, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Index（字段） 查询
		/// </summary>
		/// /// <param name = "index">排序</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByIndex(int? index, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(index.HasValue ? "`Index` = @Index" : "`Index` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (index.HasValue)
				paras_.Add(Database.CreateInParameter("@Index", index.Value, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_signin_bannerEO.MapDataReader);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByIndexAsync(int? index, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(index.HasValue ? "`Index` = @Index" : "`Index` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (index.HasValue)
				paras_.Add(Database.CreateInParameter("@Index", index.Value, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_signin_bannerEO.MapDataReader);
		}
		#endregion // GetByIndex
		#region GetByType
		
		/// <summary>
		/// 按 Type（字段） 查询
		/// </summary>
		/// /// <param name = "type">类型1banner2活动中心3支付中心</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByType(int? type)
		{
			return GetByType(type, 0, string.Empty, null);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByTypeAsync(int? type)
		{
			return await GetByTypeAsync(type, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Type（字段） 查询
		/// </summary>
		/// /// <param name = "type">类型1banner2活动中心3支付中心</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByType(int? type, TransactionManager tm_)
		{
			return GetByType(type, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByTypeAsync(int? type, TransactionManager tm_)
		{
			return await GetByTypeAsync(type, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Type（字段） 查询
		/// </summary>
		/// /// <param name = "type">类型1banner2活动中心3支付中心</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByType(int? type, int top_)
		{
			return GetByType(type, top_, string.Empty, null);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByTypeAsync(int? type, int top_)
		{
			return await GetByTypeAsync(type, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Type（字段） 查询
		/// </summary>
		/// /// <param name = "type">类型1banner2活动中心3支付中心</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByType(int? type, int top_, TransactionManager tm_)
		{
			return GetByType(type, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByTypeAsync(int? type, int top_, TransactionManager tm_)
		{
			return await GetByTypeAsync(type, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Type（字段） 查询
		/// </summary>
		/// /// <param name = "type">类型1banner2活动中心3支付中心</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByType(int? type, string sort_)
		{
			return GetByType(type, 0, sort_, null);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByTypeAsync(int? type, string sort_)
		{
			return await GetByTypeAsync(type, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Type（字段） 查询
		/// </summary>
		/// /// <param name = "type">类型1banner2活动中心3支付中心</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByType(int? type, string sort_, TransactionManager tm_)
		{
			return GetByType(type, 0, sort_, tm_);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByTypeAsync(int? type, string sort_, TransactionManager tm_)
		{
			return await GetByTypeAsync(type, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Type（字段） 查询
		/// </summary>
		/// /// <param name = "type">类型1banner2活动中心3支付中心</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByType(int? type, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(type.HasValue ? "`Type` = @Type" : "`Type` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (type.HasValue)
				paras_.Add(Database.CreateInParameter("@Type", type.Value, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_signin_bannerEO.MapDataReader);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByTypeAsync(int? type, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(type.HasValue ? "`Type` = @Type" : "`Type` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (type.HasValue)
				paras_.Add(Database.CreateInParameter("@Type", type.Value, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_signin_bannerEO.MapDataReader);
		}
		#endregion // GetByType
		#region GetByGoPage
		
		/// <summary>
		/// 按 GoPage（字段） 查询
		/// </summary>
		/// /// <param name = "goPage">跳转的页面</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByGoPage(string goPage)
		{
			return GetByGoPage(goPage, 0, string.Empty, null);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByGoPageAsync(string goPage)
		{
			return await GetByGoPageAsync(goPage, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 GoPage（字段） 查询
		/// </summary>
		/// /// <param name = "goPage">跳转的页面</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByGoPage(string goPage, TransactionManager tm_)
		{
			return GetByGoPage(goPage, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByGoPageAsync(string goPage, TransactionManager tm_)
		{
			return await GetByGoPageAsync(goPage, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 GoPage（字段） 查询
		/// </summary>
		/// /// <param name = "goPage">跳转的页面</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByGoPage(string goPage, int top_)
		{
			return GetByGoPage(goPage, top_, string.Empty, null);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByGoPageAsync(string goPage, int top_)
		{
			return await GetByGoPageAsync(goPage, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 GoPage（字段） 查询
		/// </summary>
		/// /// <param name = "goPage">跳转的页面</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByGoPage(string goPage, int top_, TransactionManager tm_)
		{
			return GetByGoPage(goPage, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByGoPageAsync(string goPage, int top_, TransactionManager tm_)
		{
			return await GetByGoPageAsync(goPage, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 GoPage（字段） 查询
		/// </summary>
		/// /// <param name = "goPage">跳转的页面</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByGoPage(string goPage, string sort_)
		{
			return GetByGoPage(goPage, 0, sort_, null);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByGoPageAsync(string goPage, string sort_)
		{
			return await GetByGoPageAsync(goPage, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 GoPage（字段） 查询
		/// </summary>
		/// /// <param name = "goPage">跳转的页面</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByGoPage(string goPage, string sort_, TransactionManager tm_)
		{
			return GetByGoPage(goPage, 0, sort_, tm_);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByGoPageAsync(string goPage, string sort_, TransactionManager tm_)
		{
			return await GetByGoPageAsync(goPage, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 GoPage（字段） 查询
		/// </summary>
		/// /// <param name = "goPage">跳转的页面</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByGoPage(string goPage, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(goPage != null ? "`GoPage` = @GoPage" : "`GoPage` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (goPage != null)
				paras_.Add(Database.CreateInParameter("@GoPage", goPage, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_signin_bannerEO.MapDataReader);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByGoPageAsync(string goPage, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(goPage != null ? "`GoPage` = @GoPage" : "`GoPage` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (goPage != null)
				paras_.Add(Database.CreateInParameter("@GoPage", goPage, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_signin_bannerEO.MapDataReader);
		}
		#endregion // GetByGoPage
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">添加时间</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByRecDate(DateTime? recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByRecDateAsync(DateTime? recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">添加时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByRecDate(DateTime? recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByRecDateAsync(DateTime? recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">添加时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByRecDate(DateTime? recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByRecDateAsync(DateTime? recDate, int top_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">添加时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByRecDate(DateTime? recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByRecDateAsync(DateTime? recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">添加时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByRecDate(DateTime? recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByRecDateAsync(DateTime? recDate, string sort_)
		{
			return await GetByRecDateAsync(recDate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">添加时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByRecDate(DateTime? recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByRecDateAsync(DateTime? recDate, string sort_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">添加时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByRecDate(DateTime? recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(recDate.HasValue ? "`RecDate` = @RecDate" : "`RecDate` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (recDate.HasValue)
				paras_.Add(Database.CreateInParameter("@RecDate", recDate.Value, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_signin_bannerEO.MapDataReader);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByRecDateAsync(DateTime? recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(recDate.HasValue ? "`RecDate` = @RecDate" : "`RecDate` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (recDate.HasValue)
				paras_.Add(Database.CreateInParameter("@RecDate", recDate.Value, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_signin_bannerEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID"></param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByOperatorIDAsync(string operatorID, int top_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByOperatorIDAsync(string operatorID, string sort_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operatorID != null ? "`OperatorID` = @OperatorID" : "`OperatorID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operatorID != null)
				paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_signin_bannerEO.MapDataReader);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operatorID != null ? "`OperatorID` = @OperatorID" : "`OperatorID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operatorID != null)
				paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_signin_bannerEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByCountryID
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID"></param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByCountryID(string countryID)
		{
			return GetByCountryID(countryID, 0, string.Empty, null);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByCountryIDAsync(string countryID)
		{
			return await GetByCountryIDAsync(countryID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByCountryID(string countryID, TransactionManager tm_)
		{
			return GetByCountryID(countryID, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByCountryIDAsync(string countryID, TransactionManager tm_)
		{
			return await GetByCountryIDAsync(countryID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByCountryID(string countryID, int top_)
		{
			return GetByCountryID(countryID, top_, string.Empty, null);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByCountryIDAsync(string countryID, int top_)
		{
			return await GetByCountryIDAsync(countryID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByCountryID(string countryID, int top_, TransactionManager tm_)
		{
			return GetByCountryID(countryID, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByCountryIDAsync(string countryID, int top_, TransactionManager tm_)
		{
			return await GetByCountryIDAsync(countryID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByCountryID(string countryID, string sort_)
		{
			return GetByCountryID(countryID, 0, sort_, null);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByCountryIDAsync(string countryID, string sort_)
		{
			return await GetByCountryIDAsync(countryID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByCountryID(string countryID, string sort_, TransactionManager tm_)
		{
			return GetByCountryID(countryID, 0, sort_, tm_);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByCountryIDAsync(string countryID, string sort_, TransactionManager tm_)
		{
			return await GetByCountryIDAsync(countryID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByCountryID(string countryID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(countryID != null ? "`CountryID` = @CountryID" : "`CountryID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (countryID != null)
				paras_.Add(Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_signin_bannerEO.MapDataReader);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByCountryIDAsync(string countryID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(countryID != null ? "`CountryID` = @CountryID" : "`CountryID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (countryID != null)
				paras_.Add(Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_signin_bannerEO.MapDataReader);
		}
		#endregion // GetByCountryID
		#region GetByCurrencyID
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID"></param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByCurrencyID(string currencyID)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, null);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByCurrencyIDAsync(string currencyID)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByCurrencyID(string currencyID, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByCurrencyIDAsync(string currencyID, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByCurrencyID(string currencyID, int top_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, null);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByCurrencyIDAsync(string currencyID, int top_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByCurrencyID(string currencyID, int top_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByCurrencyIDAsync(string currencyID, int top_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByCurrencyID(string currencyID, string sort_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, null);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByCurrencyIDAsync(string currencyID, string sort_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByCurrencyID(string currencyID, string sort_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, tm_);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByCurrencyIDAsync(string currencyID, string sort_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_bannerEO> GetByCurrencyID(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(currencyID != null ? "`CurrencyID` = @CurrencyID" : "`CurrencyID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (currencyID != null)
				paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_signin_bannerEO.MapDataReader);
		}
		public async Task<List<Sa_signin_bannerEO>> GetByCurrencyIDAsync(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(currencyID != null ? "`CurrencyID` = @CurrencyID" : "`CurrencyID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (currencyID != null)
				paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_signin_bannerEO.MapDataReader);
		}
		#endregion // GetByCurrencyID
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
