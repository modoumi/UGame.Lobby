/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * AiUo代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/AiUo
 * 文档生成时间：2023-10-24 18: 04:56
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
	/// 【表 sm_message_extend 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Sm_message_extendEO : IRowMapper<Sm_message_extendEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Sm_message_extendEO()
		{
			this.RecDate = DateTime.Now;
			this.UpdateTime = DateTime.Now;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private string _originalExtendID;
		/// <summary>
		/// 【数据库中的原始主键 ExtendID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalExtendID
		{
			get { return _originalExtendID; }
			set { HasOriginal = true; _originalExtendID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "ExtendID", ExtendID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 编号
		/// 【主键 varchar(36)】
		/// </summary>
		[DataMember(Order = 1)]
		public string ExtendID { get; set; }
		/// <summary>
		/// 邮件编号
		/// 【字段 varchar(36)】
		/// </summary>
		[DataMember(Order = 2)]
		public string MessageID { get; set; }
		/// <summary>
		/// 语种
		/// 【字段 varchar(5)】
		/// </summary>
		[DataMember(Order = 3)]
		public string LangID { get; set; }
		/// <summary>
		/// 标题
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 4)]
		public string Title { get; set; }
		/// <summary>
		/// 内容
		/// 【字段 varchar(2048)】
		/// </summary>
		[DataMember(Order = 5)]
		public string Content { get; set; }
		/// <summary>
		/// 创建时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 6)]
		public DateTime RecDate { get; set; }
		/// <summary>
		/// 修改时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 7)]
		public DateTime UpdateTime { get; set; }
		/// <summary>
		/// 广告图
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 8)]
		public string ImgURL { get; set; }
		/// <summary>
		/// 跳转链接
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 9)]
		public string HyperLink { get; set; }
		/// <summary>
		/// 过期时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 10)]
		public DateTime? ExpireTime { get; set; }
		/// <summary>
		/// 备注
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 11)]
		public string Remark { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Sm_message_extendEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Sm_message_extendEO MapDataReader(IDataReader reader)
		{
		    Sm_message_extendEO ret = new Sm_message_extendEO();
			ret.ExtendID = reader.ToString("ExtendID");
			ret.OriginalExtendID = ret.ExtendID;
			ret.MessageID = reader.ToString("MessageID");
			ret.LangID = reader.ToString("LangID");
			ret.Title = reader.ToString("Title");
			ret.Content = reader.ToString("Content");
			ret.RecDate = reader.ToDateTime("RecDate");
			ret.UpdateTime = reader.ToDateTime("UpdateTime");
			ret.ImgURL = reader.ToString("ImgURL");
			ret.HyperLink = reader.ToString("HyperLink");
			ret.ExpireTime = reader.ToDateTimeN("ExpireTime");
			ret.Remark = reader.ToString("Remark");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 
	/// 【表 sm_message_extend 的操作类】
	/// </summary>
	[Obsolete]
	public class Sm_message_extendMO : MySqlTableMO<Sm_message_extendEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`sm_message_extend`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Sm_message_extendMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Sm_message_extendMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Sm_message_extendMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Sm_message_extendEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Sm_message_extendEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Sm_message_extendEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`ExtendID`, `MessageID`, `LangID`, `Title`, `Content`, `RecDate`, `UpdateTime`, `ImgURL`, `HyperLink`, `ExpireTime`, `Remark`) VALUE (@ExtendID, @MessageID, @LangID, @Title, @Content, @RecDate, @UpdateTime, @ImgURL, @HyperLink, @ExpireTime, @Remark);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ExtendID", item.ExtendID, MySqlDbType.VarChar),
				Database.CreateInParameter("@MessageID", item.MessageID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", item.LangID != null ? item.LangID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Title", item.Title != null ? item.Title : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Content", item.Content != null ? item.Content : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@UpdateTime", item.UpdateTime, MySqlDbType.DateTime),
				Database.CreateInParameter("@ImgURL", item.ImgURL != null ? item.ImgURL : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@HyperLink", item.HyperLink != null ? item.HyperLink : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ExpireTime", item.ExpireTime.HasValue ? item.ExpireTime.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@Remark", item.Remark != null ? item.Remark : (object)DBNull.Value, MySqlDbType.VarChar),
			};
		}
		public int AddByBatch(IEnumerable<Sm_message_extendEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Sm_message_extendEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sm_message_extendEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`ExtendID`, `MessageID`, `LangID`, `Title`, `Content`, `RecDate`, `UpdateTime`, `ImgURL`, `HyperLink`, `ExpireTime`, `Remark`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.ExtendID}','{item.MessageID}','{item.LangID}','{item.Title}','{item.Content}','{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}','{item.UpdateTime.ToString("yyyy-MM-dd HH:mm:ss")}','{item.ImgURL}','{item.HyperLink}','{item.ExpireTime?.ToString("yyyy-MM-dd HH:mm:ss")}','{item.Remark}'),");
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
		/// /// <param name = "extendID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string extendID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(extendID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string extendID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(extendID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string extendID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `ExtendID` = @ExtendID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ExtendID", extendID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Sm_message_extendEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.ExtendID, tm_);
		}
		public async Task<int> RemoveAsync(Sm_message_extendEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.ExtendID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByMessageID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "messageID">邮件编号</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByMessageID(string messageID, TransactionManager tm_ = null)
		{
			RepairRemoveByMessageIDData(messageID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByMessageIDAsync(string messageID, TransactionManager tm_ = null)
		{
			RepairRemoveByMessageIDData(messageID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByMessageIDData(string messageID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `MessageID` = @MessageID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByMessageID
		#region RemoveByLangID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "langID">语种</param>
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
				paras_.Add(Database.CreateInParameter("@Content", content, MySqlDbType.VarChar));
		}
		#endregion // RemoveByContent
		#region RemoveByRecDate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "recDate">创建时间</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByRecDate(DateTime recDate, TransactionManager tm_ = null)
		{
			RepairRemoveByRecDateData(recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByRecDateAsync(DateTime recDate, TransactionManager tm_ = null)
		{
			RepairRemoveByRecDateData(recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByRecDateData(DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `RecDate` = @RecDate";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
		}
		#endregion // RemoveByRecDate
		#region RemoveByUpdateTime
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "updateTime">修改时间</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByUpdateTime(DateTime updateTime, TransactionManager tm_ = null)
		{
			RepairRemoveByUpdateTimeData(updateTime, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByUpdateTimeAsync(DateTime updateTime, TransactionManager tm_ = null)
		{
			RepairRemoveByUpdateTimeData(updateTime, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByUpdateTimeData(DateTime updateTime, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `UpdateTime` = @UpdateTime";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UpdateTime", updateTime, MySqlDbType.DateTime));
		}
		#endregion // RemoveByUpdateTime
		#region RemoveByImgURL
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "imgURL">广告图</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByImgURL(string imgURL, TransactionManager tm_ = null)
		{
			RepairRemoveByImgURLData(imgURL, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByImgURLAsync(string imgURL, TransactionManager tm_ = null)
		{
			RepairRemoveByImgURLData(imgURL, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByImgURLData(string imgURL, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (imgURL != null ? "`ImgURL` = @ImgURL" : "`ImgURL` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (imgURL != null)
				paras_.Add(Database.CreateInParameter("@ImgURL", imgURL, MySqlDbType.VarChar));
		}
		#endregion // RemoveByImgURL
		#region RemoveByHyperLink
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "hyperLink">跳转链接</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByHyperLink(string hyperLink, TransactionManager tm_ = null)
		{
			RepairRemoveByHyperLinkData(hyperLink, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByHyperLinkAsync(string hyperLink, TransactionManager tm_ = null)
		{
			RepairRemoveByHyperLinkData(hyperLink, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByHyperLinkData(string hyperLink, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (hyperLink != null ? "`HyperLink` = @HyperLink" : "`HyperLink` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (hyperLink != null)
				paras_.Add(Database.CreateInParameter("@HyperLink", hyperLink, MySqlDbType.VarChar));
		}
		#endregion // RemoveByHyperLink
		#region RemoveByExpireTime
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "expireTime">过期时间</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByExpireTime(DateTime? expireTime, TransactionManager tm_ = null)
		{
			RepairRemoveByExpireTimeData(expireTime.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByExpireTimeAsync(DateTime? expireTime, TransactionManager tm_ = null)
		{
			RepairRemoveByExpireTimeData(expireTime.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByExpireTimeData(DateTime? expireTime, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (expireTime.HasValue ? "`ExpireTime` = @ExpireTime" : "`ExpireTime` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (expireTime.HasValue)
				paras_.Add(Database.CreateInParameter("@ExpireTime", expireTime.Value, MySqlDbType.DateTime));
		}
		#endregion // RemoveByExpireTime
		#region RemoveByRemark
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "remark">备注</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByRemark(string remark, TransactionManager tm_ = null)
		{
			RepairRemoveByRemarkData(remark, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByRemarkAsync(string remark, TransactionManager tm_ = null)
		{
			RepairRemoveByRemarkData(remark, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByRemarkData(string remark, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (remark != null ? "`Remark` = @Remark" : "`Remark` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (remark != null)
				paras_.Add(Database.CreateInParameter("@Remark", remark, MySqlDbType.VarChar));
		}
		#endregion // RemoveByRemark
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
		public int Put(Sm_message_extendEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Sm_message_extendEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Sm_message_extendEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ExtendID` = @ExtendID, `MessageID` = @MessageID, `LangID` = @LangID, `Title` = @Title, `Content` = @Content, `ImgURL` = @ImgURL, `HyperLink` = @HyperLink, `ExpireTime` = @ExpireTime, `Remark` = @Remark WHERE `ExtendID` = @ExtendID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ExtendID", item.ExtendID, MySqlDbType.VarChar),
				Database.CreateInParameter("@MessageID", item.MessageID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", item.LangID != null ? item.LangID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Title", item.Title != null ? item.Title : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Content", item.Content != null ? item.Content : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ImgURL", item.ImgURL != null ? item.ImgURL : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@HyperLink", item.HyperLink != null ? item.HyperLink : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ExpireTime", item.ExpireTime.HasValue ? item.ExpireTime.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@Remark", item.Remark != null ? item.Remark : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ExtendID_Original", item.HasOriginal ? item.OriginalExtendID : item.ExtendID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Sm_message_extendEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Sm_message_extendEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "extendID">编号</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string extendID, string set_, params object[] values_)
		{
			return Put(set_, "`ExtendID` = @ExtendID", ConcatValues(values_, extendID));
		}
		public async Task<int> PutByPKAsync(string extendID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`ExtendID` = @ExtendID", ConcatValues(values_, extendID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "extendID">编号</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string extendID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`ExtendID` = @ExtendID", tm_, ConcatValues(values_, extendID));
		}
		public async Task<int> PutByPKAsync(string extendID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`ExtendID` = @ExtendID", tm_, ConcatValues(values_, extendID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "extendID">编号</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string extendID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@ExtendID", extendID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`ExtendID` = @ExtendID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string extendID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@ExtendID", extendID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`ExtendID` = @ExtendID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutMessageID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "extendID">编号</param>
		/// /// <param name = "messageID">邮件编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMessageIDByPK(string extendID, string messageID, TransactionManager tm_ = null)
		{
			RepairPutMessageIDByPKData(extendID, messageID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutMessageIDByPKAsync(string extendID, string messageID, TransactionManager tm_ = null)
		{
			RepairPutMessageIDByPKData(extendID, messageID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutMessageIDByPKData(string extendID, string messageID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `MessageID` = @MessageID  WHERE `ExtendID` = @ExtendID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ExtendID", extendID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "messageID">邮件编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMessageID(string messageID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MessageID` = @MessageID";
			var parameter_ = Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutMessageIDAsync(string messageID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MessageID` = @MessageID";
			var parameter_ = Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutMessageID
		#region PutLangID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "extendID">编号</param>
		/// /// <param name = "langID">语种</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLangIDByPK(string extendID, string langID, TransactionManager tm_ = null)
		{
			RepairPutLangIDByPKData(extendID, langID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLangIDByPKAsync(string extendID, string langID, TransactionManager tm_ = null)
		{
			RepairPutLangIDByPKData(extendID, langID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLangIDByPKData(string extendID, string langID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `LangID` = @LangID  WHERE `ExtendID` = @ExtendID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LangID", langID != null ? langID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ExtendID", extendID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "langID">语种</param>
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
		#region PutTitle
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "extendID">编号</param>
		/// /// <param name = "title">标题</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTitleByPK(string extendID, string title, TransactionManager tm_ = null)
		{
			RepairPutTitleByPKData(extendID, title, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTitleByPKAsync(string extendID, string title, TransactionManager tm_ = null)
		{
			RepairPutTitleByPKData(extendID, title, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTitleByPKData(string extendID, string title, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Title` = @Title  WHERE `ExtendID` = @ExtendID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Title", title != null ? title : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ExtendID", extendID, MySqlDbType.VarChar),
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
		#region PutContent
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "extendID">编号</param>
		/// /// <param name = "content">内容</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutContentByPK(string extendID, string content, TransactionManager tm_ = null)
		{
			RepairPutContentByPKData(extendID, content, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutContentByPKAsync(string extendID, string content, TransactionManager tm_ = null)
		{
			RepairPutContentByPKData(extendID, content, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutContentByPKData(string extendID, string content, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Content` = @Content  WHERE `ExtendID` = @ExtendID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Content", content != null ? content : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ExtendID", extendID, MySqlDbType.VarChar),
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
			var parameter_ = Database.CreateInParameter("@Content", content != null ? content : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutContentAsync(string content, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Content` = @Content";
			var parameter_ = Database.CreateInParameter("@Content", content != null ? content : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutContent
		#region PutRecDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "extendID">编号</param>
		/// /// <param name = "recDate">创建时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(string extendID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(extendID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(string extendID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(extendID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(string extendID, DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `ExtendID` = @ExtendID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@ExtendID", extendID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "recDate">创建时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDate(DateTime recDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate";
			var parameter_ = Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutRecDateAsync(DateTime recDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate";
			var parameter_ = Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutRecDate
		#region PutUpdateTime
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "extendID">编号</param>
		/// /// <param name = "updateTime">修改时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUpdateTimeByPK(string extendID, DateTime updateTime, TransactionManager tm_ = null)
		{
			RepairPutUpdateTimeByPKData(extendID, updateTime, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutUpdateTimeByPKAsync(string extendID, DateTime updateTime, TransactionManager tm_ = null)
		{
			RepairPutUpdateTimeByPKData(extendID, updateTime, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutUpdateTimeByPKData(string extendID, DateTime updateTime, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UpdateTime` = @UpdateTime  WHERE `ExtendID` = @ExtendID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UpdateTime", updateTime, MySqlDbType.DateTime),
				Database.CreateInParameter("@ExtendID", extendID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "updateTime">修改时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUpdateTime(DateTime updateTime, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UpdateTime` = @UpdateTime";
			var parameter_ = Database.CreateInParameter("@UpdateTime", updateTime, MySqlDbType.DateTime);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutUpdateTimeAsync(DateTime updateTime, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UpdateTime` = @UpdateTime";
			var parameter_ = Database.CreateInParameter("@UpdateTime", updateTime, MySqlDbType.DateTime);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutUpdateTime
		#region PutImgURL
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "extendID">编号</param>
		/// /// <param name = "imgURL">广告图</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutImgURLByPK(string extendID, string imgURL, TransactionManager tm_ = null)
		{
			RepairPutImgURLByPKData(extendID, imgURL, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutImgURLByPKAsync(string extendID, string imgURL, TransactionManager tm_ = null)
		{
			RepairPutImgURLByPKData(extendID, imgURL, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutImgURLByPKData(string extendID, string imgURL, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ImgURL` = @ImgURL  WHERE `ExtendID` = @ExtendID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ImgURL", imgURL != null ? imgURL : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ExtendID", extendID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "imgURL">广告图</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutImgURL(string imgURL, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ImgURL` = @ImgURL";
			var parameter_ = Database.CreateInParameter("@ImgURL", imgURL != null ? imgURL : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutImgURLAsync(string imgURL, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ImgURL` = @ImgURL";
			var parameter_ = Database.CreateInParameter("@ImgURL", imgURL != null ? imgURL : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutImgURL
		#region PutHyperLink
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "extendID">编号</param>
		/// /// <param name = "hyperLink">跳转链接</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutHyperLinkByPK(string extendID, string hyperLink, TransactionManager tm_ = null)
		{
			RepairPutHyperLinkByPKData(extendID, hyperLink, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutHyperLinkByPKAsync(string extendID, string hyperLink, TransactionManager tm_ = null)
		{
			RepairPutHyperLinkByPKData(extendID, hyperLink, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutHyperLinkByPKData(string extendID, string hyperLink, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `HyperLink` = @HyperLink  WHERE `ExtendID` = @ExtendID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@HyperLink", hyperLink != null ? hyperLink : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ExtendID", extendID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "hyperLink">跳转链接</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutHyperLink(string hyperLink, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `HyperLink` = @HyperLink";
			var parameter_ = Database.CreateInParameter("@HyperLink", hyperLink != null ? hyperLink : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutHyperLinkAsync(string hyperLink, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `HyperLink` = @HyperLink";
			var parameter_ = Database.CreateInParameter("@HyperLink", hyperLink != null ? hyperLink : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutHyperLink
		#region PutExpireTime
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "extendID">编号</param>
		/// /// <param name = "expireTime">过期时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutExpireTimeByPK(string extendID, DateTime? expireTime, TransactionManager tm_ = null)
		{
			RepairPutExpireTimeByPKData(extendID, expireTime, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutExpireTimeByPKAsync(string extendID, DateTime? expireTime, TransactionManager tm_ = null)
		{
			RepairPutExpireTimeByPKData(extendID, expireTime, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutExpireTimeByPKData(string extendID, DateTime? expireTime, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ExpireTime` = @ExpireTime  WHERE `ExtendID` = @ExtendID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ExpireTime", expireTime.HasValue ? expireTime.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@ExtendID", extendID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "expireTime">过期时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutExpireTime(DateTime? expireTime, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ExpireTime` = @ExpireTime";
			var parameter_ = Database.CreateInParameter("@ExpireTime", expireTime.HasValue ? expireTime.Value : (object)DBNull.Value, MySqlDbType.DateTime);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutExpireTimeAsync(DateTime? expireTime, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ExpireTime` = @ExpireTime";
			var parameter_ = Database.CreateInParameter("@ExpireTime", expireTime.HasValue ? expireTime.Value : (object)DBNull.Value, MySqlDbType.DateTime);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutExpireTime
		#region PutRemark
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "extendID">编号</param>
		/// /// <param name = "remark">备注</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRemarkByPK(string extendID, string remark, TransactionManager tm_ = null)
		{
			RepairPutRemarkByPKData(extendID, remark, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRemarkByPKAsync(string extendID, string remark, TransactionManager tm_ = null)
		{
			RepairPutRemarkByPKData(extendID, remark, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRemarkByPKData(string extendID, string remark, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Remark` = @Remark  WHERE `ExtendID` = @ExtendID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Remark", remark != null ? remark : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ExtendID", extendID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "remark">备注</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRemark(string remark, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Remark` = @Remark";
			var parameter_ = Database.CreateInParameter("@Remark", remark != null ? remark : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutRemarkAsync(string remark, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Remark` = @Remark";
			var parameter_ = Database.CreateInParameter("@Remark", remark != null ? remark : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutRemark
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Sm_message_extendEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.ExtendID) == null)
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
		public async Task<bool> SetAsync(Sm_message_extendEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.ExtendID) == null)
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
		/// /// <param name = "extendID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Sm_message_extendEO GetByPK(string extendID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(extendID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sm_message_extendEO.MapDataReader);
		}
		public async Task<Sm_message_extendEO> GetByPKAsync(string extendID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(extendID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sm_message_extendEO.MapDataReader);
		}
		private void RepairGetByPKData(string extendID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`ExtendID` = @ExtendID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ExtendID", extendID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 MessageID（字段）
		/// </summary>
		/// /// <param name = "extendID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetMessageIDByPK(string extendID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ExtendID", extendID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`MessageID`", "`ExtendID` = @ExtendID", paras_, tm_);
		}
		public async Task<string> GetMessageIDByPKAsync(string extendID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ExtendID", extendID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`MessageID`", "`ExtendID` = @ExtendID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 LangID（字段）
		/// </summary>
		/// /// <param name = "extendID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetLangIDByPK(string extendID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ExtendID", extendID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`LangID`", "`ExtendID` = @ExtendID", paras_, tm_);
		}
		public async Task<string> GetLangIDByPKAsync(string extendID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ExtendID", extendID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`LangID`", "`ExtendID` = @ExtendID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Title（字段）
		/// </summary>
		/// /// <param name = "extendID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetTitleByPK(string extendID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ExtendID", extendID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Title`", "`ExtendID` = @ExtendID", paras_, tm_);
		}
		public async Task<string> GetTitleByPKAsync(string extendID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ExtendID", extendID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Title`", "`ExtendID` = @ExtendID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Content（字段）
		/// </summary>
		/// /// <param name = "extendID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetContentByPK(string extendID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ExtendID", extendID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Content`", "`ExtendID` = @ExtendID", paras_, tm_);
		}
		public async Task<string> GetContentByPKAsync(string extendID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ExtendID", extendID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Content`", "`ExtendID` = @ExtendID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "extendID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetRecDateByPK(string extendID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ExtendID", extendID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`RecDate`", "`ExtendID` = @ExtendID", paras_, tm_);
		}
		public async Task<DateTime> GetRecDateByPKAsync(string extendID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ExtendID", extendID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`RecDate`", "`ExtendID` = @ExtendID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 UpdateTime（字段）
		/// </summary>
		/// /// <param name = "extendID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetUpdateTimeByPK(string extendID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ExtendID", extendID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`UpdateTime`", "`ExtendID` = @ExtendID", paras_, tm_);
		}
		public async Task<DateTime> GetUpdateTimeByPKAsync(string extendID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ExtendID", extendID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`UpdateTime`", "`ExtendID` = @ExtendID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ImgURL（字段）
		/// </summary>
		/// /// <param name = "extendID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetImgURLByPK(string extendID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ExtendID", extendID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`ImgURL`", "`ExtendID` = @ExtendID", paras_, tm_);
		}
		public async Task<string> GetImgURLByPKAsync(string extendID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ExtendID", extendID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`ImgURL`", "`ExtendID` = @ExtendID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 HyperLink（字段）
		/// </summary>
		/// /// <param name = "extendID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetHyperLinkByPK(string extendID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ExtendID", extendID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`HyperLink`", "`ExtendID` = @ExtendID", paras_, tm_);
		}
		public async Task<string> GetHyperLinkByPKAsync(string extendID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ExtendID", extendID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`HyperLink`", "`ExtendID` = @ExtendID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ExpireTime（字段）
		/// </summary>
		/// /// <param name = "extendID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime? GetExpireTimeByPK(string extendID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ExtendID", extendID, MySqlDbType.VarChar),
			};
			return (DateTime?)GetScalar("`ExpireTime`", "`ExtendID` = @ExtendID", paras_, tm_);
		}
		public async Task<DateTime?> GetExpireTimeByPKAsync(string extendID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ExtendID", extendID, MySqlDbType.VarChar),
			};
			return (DateTime?)await GetScalarAsync("`ExpireTime`", "`ExtendID` = @ExtendID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Remark（字段）
		/// </summary>
		/// /// <param name = "extendID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetRemarkByPK(string extendID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ExtendID", extendID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Remark`", "`ExtendID` = @ExtendID", paras_, tm_);
		}
		public async Task<string> GetRemarkByPKAsync(string extendID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ExtendID", extendID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Remark`", "`ExtendID` = @ExtendID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByMessageID
		
		/// <summary>
		/// 按 MessageID（字段） 查询
		/// </summary>
		/// /// <param name = "messageID">邮件编号</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_extendEO> GetByMessageID(string messageID)
		{
			return GetByMessageID(messageID, 0, string.Empty, null);
		}
		public async Task<List<Sm_message_extendEO>> GetByMessageIDAsync(string messageID)
		{
			return await GetByMessageIDAsync(messageID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MessageID（字段） 查询
		/// </summary>
		/// /// <param name = "messageID">邮件编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_extendEO> GetByMessageID(string messageID, TransactionManager tm_)
		{
			return GetByMessageID(messageID, 0, string.Empty, tm_);
		}
		public async Task<List<Sm_message_extendEO>> GetByMessageIDAsync(string messageID, TransactionManager tm_)
		{
			return await GetByMessageIDAsync(messageID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MessageID（字段） 查询
		/// </summary>
		/// /// <param name = "messageID">邮件编号</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_extendEO> GetByMessageID(string messageID, int top_)
		{
			return GetByMessageID(messageID, top_, string.Empty, null);
		}
		public async Task<List<Sm_message_extendEO>> GetByMessageIDAsync(string messageID, int top_)
		{
			return await GetByMessageIDAsync(messageID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MessageID（字段） 查询
		/// </summary>
		/// /// <param name = "messageID">邮件编号</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_extendEO> GetByMessageID(string messageID, int top_, TransactionManager tm_)
		{
			return GetByMessageID(messageID, top_, string.Empty, tm_);
		}
		public async Task<List<Sm_message_extendEO>> GetByMessageIDAsync(string messageID, int top_, TransactionManager tm_)
		{
			return await GetByMessageIDAsync(messageID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MessageID（字段） 查询
		/// </summary>
		/// /// <param name = "messageID">邮件编号</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_extendEO> GetByMessageID(string messageID, string sort_)
		{
			return GetByMessageID(messageID, 0, sort_, null);
		}
		public async Task<List<Sm_message_extendEO>> GetByMessageIDAsync(string messageID, string sort_)
		{
			return await GetByMessageIDAsync(messageID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 MessageID（字段） 查询
		/// </summary>
		/// /// <param name = "messageID">邮件编号</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_extendEO> GetByMessageID(string messageID, string sort_, TransactionManager tm_)
		{
			return GetByMessageID(messageID, 0, sort_, tm_);
		}
		public async Task<List<Sm_message_extendEO>> GetByMessageIDAsync(string messageID, string sort_, TransactionManager tm_)
		{
			return await GetByMessageIDAsync(messageID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 MessageID（字段） 查询
		/// </summary>
		/// /// <param name = "messageID">邮件编号</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_extendEO> GetByMessageID(string messageID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`MessageID` = @MessageID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sm_message_extendEO.MapDataReader);
		}
		public async Task<List<Sm_message_extendEO>> GetByMessageIDAsync(string messageID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`MessageID` = @MessageID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sm_message_extendEO.MapDataReader);
		}
		#endregion // GetByMessageID
		#region GetByLangID
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语种</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_extendEO> GetByLangID(string langID)
		{
			return GetByLangID(langID, 0, string.Empty, null);
		}
		public async Task<List<Sm_message_extendEO>> GetByLangIDAsync(string langID)
		{
			return await GetByLangIDAsync(langID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语种</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_extendEO> GetByLangID(string langID, TransactionManager tm_)
		{
			return GetByLangID(langID, 0, string.Empty, tm_);
		}
		public async Task<List<Sm_message_extendEO>> GetByLangIDAsync(string langID, TransactionManager tm_)
		{
			return await GetByLangIDAsync(langID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语种</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_extendEO> GetByLangID(string langID, int top_)
		{
			return GetByLangID(langID, top_, string.Empty, null);
		}
		public async Task<List<Sm_message_extendEO>> GetByLangIDAsync(string langID, int top_)
		{
			return await GetByLangIDAsync(langID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语种</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_extendEO> GetByLangID(string langID, int top_, TransactionManager tm_)
		{
			return GetByLangID(langID, top_, string.Empty, tm_);
		}
		public async Task<List<Sm_message_extendEO>> GetByLangIDAsync(string langID, int top_, TransactionManager tm_)
		{
			return await GetByLangIDAsync(langID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语种</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_extendEO> GetByLangID(string langID, string sort_)
		{
			return GetByLangID(langID, 0, sort_, null);
		}
		public async Task<List<Sm_message_extendEO>> GetByLangIDAsync(string langID, string sort_)
		{
			return await GetByLangIDAsync(langID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语种</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_extendEO> GetByLangID(string langID, string sort_, TransactionManager tm_)
		{
			return GetByLangID(langID, 0, sort_, tm_);
		}
		public async Task<List<Sm_message_extendEO>> GetByLangIDAsync(string langID, string sort_, TransactionManager tm_)
		{
			return await GetByLangIDAsync(langID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语种</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_extendEO> GetByLangID(string langID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(langID != null ? "`LangID` = @LangID" : "`LangID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (langID != null)
				paras_.Add(Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sm_message_extendEO.MapDataReader);
		}
		public async Task<List<Sm_message_extendEO>> GetByLangIDAsync(string langID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(langID != null ? "`LangID` = @LangID" : "`LangID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (langID != null)
				paras_.Add(Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sm_message_extendEO.MapDataReader);
		}
		#endregion // GetByLangID
		#region GetByTitle
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">标题</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_extendEO> GetByTitle(string title)
		{
			return GetByTitle(title, 0, string.Empty, null);
		}
		public async Task<List<Sm_message_extendEO>> GetByTitleAsync(string title)
		{
			return await GetByTitleAsync(title, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">标题</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_extendEO> GetByTitle(string title, TransactionManager tm_)
		{
			return GetByTitle(title, 0, string.Empty, tm_);
		}
		public async Task<List<Sm_message_extendEO>> GetByTitleAsync(string title, TransactionManager tm_)
		{
			return await GetByTitleAsync(title, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">标题</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_extendEO> GetByTitle(string title, int top_)
		{
			return GetByTitle(title, top_, string.Empty, null);
		}
		public async Task<List<Sm_message_extendEO>> GetByTitleAsync(string title, int top_)
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
		public List<Sm_message_extendEO> GetByTitle(string title, int top_, TransactionManager tm_)
		{
			return GetByTitle(title, top_, string.Empty, tm_);
		}
		public async Task<List<Sm_message_extendEO>> GetByTitleAsync(string title, int top_, TransactionManager tm_)
		{
			return await GetByTitleAsync(title, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">标题</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_extendEO> GetByTitle(string title, string sort_)
		{
			return GetByTitle(title, 0, sort_, null);
		}
		public async Task<List<Sm_message_extendEO>> GetByTitleAsync(string title, string sort_)
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
		public List<Sm_message_extendEO> GetByTitle(string title, string sort_, TransactionManager tm_)
		{
			return GetByTitle(title, 0, sort_, tm_);
		}
		public async Task<List<Sm_message_extendEO>> GetByTitleAsync(string title, string sort_, TransactionManager tm_)
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
		public List<Sm_message_extendEO> GetByTitle(string title, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(title != null ? "`Title` = @Title" : "`Title` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (title != null)
				paras_.Add(Database.CreateInParameter("@Title", title, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sm_message_extendEO.MapDataReader);
		}
		public async Task<List<Sm_message_extendEO>> GetByTitleAsync(string title, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(title != null ? "`Title` = @Title" : "`Title` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (title != null)
				paras_.Add(Database.CreateInParameter("@Title", title, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sm_message_extendEO.MapDataReader);
		}
		#endregion // GetByTitle
		#region GetByContent
		
		/// <summary>
		/// 按 Content（字段） 查询
		/// </summary>
		/// /// <param name = "content">内容</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_extendEO> GetByContent(string content)
		{
			return GetByContent(content, 0, string.Empty, null);
		}
		public async Task<List<Sm_message_extendEO>> GetByContentAsync(string content)
		{
			return await GetByContentAsync(content, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Content（字段） 查询
		/// </summary>
		/// /// <param name = "content">内容</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_extendEO> GetByContent(string content, TransactionManager tm_)
		{
			return GetByContent(content, 0, string.Empty, tm_);
		}
		public async Task<List<Sm_message_extendEO>> GetByContentAsync(string content, TransactionManager tm_)
		{
			return await GetByContentAsync(content, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Content（字段） 查询
		/// </summary>
		/// /// <param name = "content">内容</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_extendEO> GetByContent(string content, int top_)
		{
			return GetByContent(content, top_, string.Empty, null);
		}
		public async Task<List<Sm_message_extendEO>> GetByContentAsync(string content, int top_)
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
		public List<Sm_message_extendEO> GetByContent(string content, int top_, TransactionManager tm_)
		{
			return GetByContent(content, top_, string.Empty, tm_);
		}
		public async Task<List<Sm_message_extendEO>> GetByContentAsync(string content, int top_, TransactionManager tm_)
		{
			return await GetByContentAsync(content, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Content（字段） 查询
		/// </summary>
		/// /// <param name = "content">内容</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_extendEO> GetByContent(string content, string sort_)
		{
			return GetByContent(content, 0, sort_, null);
		}
		public async Task<List<Sm_message_extendEO>> GetByContentAsync(string content, string sort_)
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
		public List<Sm_message_extendEO> GetByContent(string content, string sort_, TransactionManager tm_)
		{
			return GetByContent(content, 0, sort_, tm_);
		}
		public async Task<List<Sm_message_extendEO>> GetByContentAsync(string content, string sort_, TransactionManager tm_)
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
		public List<Sm_message_extendEO> GetByContent(string content, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(content != null ? "`Content` = @Content" : "`Content` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (content != null)
				paras_.Add(Database.CreateInParameter("@Content", content, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sm_message_extendEO.MapDataReader);
		}
		public async Task<List<Sm_message_extendEO>> GetByContentAsync(string content, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(content != null ? "`Content` = @Content" : "`Content` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (content != null)
				paras_.Add(Database.CreateInParameter("@Content", content, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sm_message_extendEO.MapDataReader);
		}
		#endregion // GetByContent
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">创建时间</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_extendEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<Sm_message_extendEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">创建时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_extendEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<Sm_message_extendEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">创建时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_extendEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<Sm_message_extendEO>> GetByRecDateAsync(DateTime recDate, int top_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">创建时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_extendEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<Sm_message_extendEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">创建时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_extendEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<Sm_message_extendEO>> GetByRecDateAsync(DateTime recDate, string sort_)
		{
			return await GetByRecDateAsync(recDate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">创建时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_extendEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<Sm_message_extendEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">创建时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_extendEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sm_message_extendEO.MapDataReader);
		}
		public async Task<List<Sm_message_extendEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sm_message_extendEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#region GetByUpdateTime
		
		/// <summary>
		/// 按 UpdateTime（字段） 查询
		/// </summary>
		/// /// <param name = "updateTime">修改时间</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_extendEO> GetByUpdateTime(DateTime updateTime)
		{
			return GetByUpdateTime(updateTime, 0, string.Empty, null);
		}
		public async Task<List<Sm_message_extendEO>> GetByUpdateTimeAsync(DateTime updateTime)
		{
			return await GetByUpdateTimeAsync(updateTime, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UpdateTime（字段） 查询
		/// </summary>
		/// /// <param name = "updateTime">修改时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_extendEO> GetByUpdateTime(DateTime updateTime, TransactionManager tm_)
		{
			return GetByUpdateTime(updateTime, 0, string.Empty, tm_);
		}
		public async Task<List<Sm_message_extendEO>> GetByUpdateTimeAsync(DateTime updateTime, TransactionManager tm_)
		{
			return await GetByUpdateTimeAsync(updateTime, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UpdateTime（字段） 查询
		/// </summary>
		/// /// <param name = "updateTime">修改时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_extendEO> GetByUpdateTime(DateTime updateTime, int top_)
		{
			return GetByUpdateTime(updateTime, top_, string.Empty, null);
		}
		public async Task<List<Sm_message_extendEO>> GetByUpdateTimeAsync(DateTime updateTime, int top_)
		{
			return await GetByUpdateTimeAsync(updateTime, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UpdateTime（字段） 查询
		/// </summary>
		/// /// <param name = "updateTime">修改时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_extendEO> GetByUpdateTime(DateTime updateTime, int top_, TransactionManager tm_)
		{
			return GetByUpdateTime(updateTime, top_, string.Empty, tm_);
		}
		public async Task<List<Sm_message_extendEO>> GetByUpdateTimeAsync(DateTime updateTime, int top_, TransactionManager tm_)
		{
			return await GetByUpdateTimeAsync(updateTime, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UpdateTime（字段） 查询
		/// </summary>
		/// /// <param name = "updateTime">修改时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_extendEO> GetByUpdateTime(DateTime updateTime, string sort_)
		{
			return GetByUpdateTime(updateTime, 0, sort_, null);
		}
		public async Task<List<Sm_message_extendEO>> GetByUpdateTimeAsync(DateTime updateTime, string sort_)
		{
			return await GetByUpdateTimeAsync(updateTime, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 UpdateTime（字段） 查询
		/// </summary>
		/// /// <param name = "updateTime">修改时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_extendEO> GetByUpdateTime(DateTime updateTime, string sort_, TransactionManager tm_)
		{
			return GetByUpdateTime(updateTime, 0, sort_, tm_);
		}
		public async Task<List<Sm_message_extendEO>> GetByUpdateTimeAsync(DateTime updateTime, string sort_, TransactionManager tm_)
		{
			return await GetByUpdateTimeAsync(updateTime, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 UpdateTime（字段） 查询
		/// </summary>
		/// /// <param name = "updateTime">修改时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_extendEO> GetByUpdateTime(DateTime updateTime, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UpdateTime` = @UpdateTime", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UpdateTime", updateTime, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sm_message_extendEO.MapDataReader);
		}
		public async Task<List<Sm_message_extendEO>> GetByUpdateTimeAsync(DateTime updateTime, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UpdateTime` = @UpdateTime", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UpdateTime", updateTime, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sm_message_extendEO.MapDataReader);
		}
		#endregion // GetByUpdateTime
		#region GetByImgURL
		
		/// <summary>
		/// 按 ImgURL（字段） 查询
		/// </summary>
		/// /// <param name = "imgURL">广告图</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_extendEO> GetByImgURL(string imgURL)
		{
			return GetByImgURL(imgURL, 0, string.Empty, null);
		}
		public async Task<List<Sm_message_extendEO>> GetByImgURLAsync(string imgURL)
		{
			return await GetByImgURLAsync(imgURL, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ImgURL（字段） 查询
		/// </summary>
		/// /// <param name = "imgURL">广告图</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_extendEO> GetByImgURL(string imgURL, TransactionManager tm_)
		{
			return GetByImgURL(imgURL, 0, string.Empty, tm_);
		}
		public async Task<List<Sm_message_extendEO>> GetByImgURLAsync(string imgURL, TransactionManager tm_)
		{
			return await GetByImgURLAsync(imgURL, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ImgURL（字段） 查询
		/// </summary>
		/// /// <param name = "imgURL">广告图</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_extendEO> GetByImgURL(string imgURL, int top_)
		{
			return GetByImgURL(imgURL, top_, string.Empty, null);
		}
		public async Task<List<Sm_message_extendEO>> GetByImgURLAsync(string imgURL, int top_)
		{
			return await GetByImgURLAsync(imgURL, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ImgURL（字段） 查询
		/// </summary>
		/// /// <param name = "imgURL">广告图</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_extendEO> GetByImgURL(string imgURL, int top_, TransactionManager tm_)
		{
			return GetByImgURL(imgURL, top_, string.Empty, tm_);
		}
		public async Task<List<Sm_message_extendEO>> GetByImgURLAsync(string imgURL, int top_, TransactionManager tm_)
		{
			return await GetByImgURLAsync(imgURL, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ImgURL（字段） 查询
		/// </summary>
		/// /// <param name = "imgURL">广告图</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_extendEO> GetByImgURL(string imgURL, string sort_)
		{
			return GetByImgURL(imgURL, 0, sort_, null);
		}
		public async Task<List<Sm_message_extendEO>> GetByImgURLAsync(string imgURL, string sort_)
		{
			return await GetByImgURLAsync(imgURL, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ImgURL（字段） 查询
		/// </summary>
		/// /// <param name = "imgURL">广告图</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_extendEO> GetByImgURL(string imgURL, string sort_, TransactionManager tm_)
		{
			return GetByImgURL(imgURL, 0, sort_, tm_);
		}
		public async Task<List<Sm_message_extendEO>> GetByImgURLAsync(string imgURL, string sort_, TransactionManager tm_)
		{
			return await GetByImgURLAsync(imgURL, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ImgURL（字段） 查询
		/// </summary>
		/// /// <param name = "imgURL">广告图</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_extendEO> GetByImgURL(string imgURL, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(imgURL != null ? "`ImgURL` = @ImgURL" : "`ImgURL` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (imgURL != null)
				paras_.Add(Database.CreateInParameter("@ImgURL", imgURL, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sm_message_extendEO.MapDataReader);
		}
		public async Task<List<Sm_message_extendEO>> GetByImgURLAsync(string imgURL, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(imgURL != null ? "`ImgURL` = @ImgURL" : "`ImgURL` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (imgURL != null)
				paras_.Add(Database.CreateInParameter("@ImgURL", imgURL, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sm_message_extendEO.MapDataReader);
		}
		#endregion // GetByImgURL
		#region GetByHyperLink
		
		/// <summary>
		/// 按 HyperLink（字段） 查询
		/// </summary>
		/// /// <param name = "hyperLink">跳转链接</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_extendEO> GetByHyperLink(string hyperLink)
		{
			return GetByHyperLink(hyperLink, 0, string.Empty, null);
		}
		public async Task<List<Sm_message_extendEO>> GetByHyperLinkAsync(string hyperLink)
		{
			return await GetByHyperLinkAsync(hyperLink, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 HyperLink（字段） 查询
		/// </summary>
		/// /// <param name = "hyperLink">跳转链接</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_extendEO> GetByHyperLink(string hyperLink, TransactionManager tm_)
		{
			return GetByHyperLink(hyperLink, 0, string.Empty, tm_);
		}
		public async Task<List<Sm_message_extendEO>> GetByHyperLinkAsync(string hyperLink, TransactionManager tm_)
		{
			return await GetByHyperLinkAsync(hyperLink, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 HyperLink（字段） 查询
		/// </summary>
		/// /// <param name = "hyperLink">跳转链接</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_extendEO> GetByHyperLink(string hyperLink, int top_)
		{
			return GetByHyperLink(hyperLink, top_, string.Empty, null);
		}
		public async Task<List<Sm_message_extendEO>> GetByHyperLinkAsync(string hyperLink, int top_)
		{
			return await GetByHyperLinkAsync(hyperLink, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 HyperLink（字段） 查询
		/// </summary>
		/// /// <param name = "hyperLink">跳转链接</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_extendEO> GetByHyperLink(string hyperLink, int top_, TransactionManager tm_)
		{
			return GetByHyperLink(hyperLink, top_, string.Empty, tm_);
		}
		public async Task<List<Sm_message_extendEO>> GetByHyperLinkAsync(string hyperLink, int top_, TransactionManager tm_)
		{
			return await GetByHyperLinkAsync(hyperLink, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 HyperLink（字段） 查询
		/// </summary>
		/// /// <param name = "hyperLink">跳转链接</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_extendEO> GetByHyperLink(string hyperLink, string sort_)
		{
			return GetByHyperLink(hyperLink, 0, sort_, null);
		}
		public async Task<List<Sm_message_extendEO>> GetByHyperLinkAsync(string hyperLink, string sort_)
		{
			return await GetByHyperLinkAsync(hyperLink, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 HyperLink（字段） 查询
		/// </summary>
		/// /// <param name = "hyperLink">跳转链接</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_extendEO> GetByHyperLink(string hyperLink, string sort_, TransactionManager tm_)
		{
			return GetByHyperLink(hyperLink, 0, sort_, tm_);
		}
		public async Task<List<Sm_message_extendEO>> GetByHyperLinkAsync(string hyperLink, string sort_, TransactionManager tm_)
		{
			return await GetByHyperLinkAsync(hyperLink, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 HyperLink（字段） 查询
		/// </summary>
		/// /// <param name = "hyperLink">跳转链接</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_extendEO> GetByHyperLink(string hyperLink, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(hyperLink != null ? "`HyperLink` = @HyperLink" : "`HyperLink` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (hyperLink != null)
				paras_.Add(Database.CreateInParameter("@HyperLink", hyperLink, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sm_message_extendEO.MapDataReader);
		}
		public async Task<List<Sm_message_extendEO>> GetByHyperLinkAsync(string hyperLink, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(hyperLink != null ? "`HyperLink` = @HyperLink" : "`HyperLink` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (hyperLink != null)
				paras_.Add(Database.CreateInParameter("@HyperLink", hyperLink, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sm_message_extendEO.MapDataReader);
		}
		#endregion // GetByHyperLink
		#region GetByExpireTime
		
		/// <summary>
		/// 按 ExpireTime（字段） 查询
		/// </summary>
		/// /// <param name = "expireTime">过期时间</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_extendEO> GetByExpireTime(DateTime? expireTime)
		{
			return GetByExpireTime(expireTime, 0, string.Empty, null);
		}
		public async Task<List<Sm_message_extendEO>> GetByExpireTimeAsync(DateTime? expireTime)
		{
			return await GetByExpireTimeAsync(expireTime, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ExpireTime（字段） 查询
		/// </summary>
		/// /// <param name = "expireTime">过期时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_extendEO> GetByExpireTime(DateTime? expireTime, TransactionManager tm_)
		{
			return GetByExpireTime(expireTime, 0, string.Empty, tm_);
		}
		public async Task<List<Sm_message_extendEO>> GetByExpireTimeAsync(DateTime? expireTime, TransactionManager tm_)
		{
			return await GetByExpireTimeAsync(expireTime, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ExpireTime（字段） 查询
		/// </summary>
		/// /// <param name = "expireTime">过期时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_extendEO> GetByExpireTime(DateTime? expireTime, int top_)
		{
			return GetByExpireTime(expireTime, top_, string.Empty, null);
		}
		public async Task<List<Sm_message_extendEO>> GetByExpireTimeAsync(DateTime? expireTime, int top_)
		{
			return await GetByExpireTimeAsync(expireTime, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ExpireTime（字段） 查询
		/// </summary>
		/// /// <param name = "expireTime">过期时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_extendEO> GetByExpireTime(DateTime? expireTime, int top_, TransactionManager tm_)
		{
			return GetByExpireTime(expireTime, top_, string.Empty, tm_);
		}
		public async Task<List<Sm_message_extendEO>> GetByExpireTimeAsync(DateTime? expireTime, int top_, TransactionManager tm_)
		{
			return await GetByExpireTimeAsync(expireTime, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ExpireTime（字段） 查询
		/// </summary>
		/// /// <param name = "expireTime">过期时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_extendEO> GetByExpireTime(DateTime? expireTime, string sort_)
		{
			return GetByExpireTime(expireTime, 0, sort_, null);
		}
		public async Task<List<Sm_message_extendEO>> GetByExpireTimeAsync(DateTime? expireTime, string sort_)
		{
			return await GetByExpireTimeAsync(expireTime, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ExpireTime（字段） 查询
		/// </summary>
		/// /// <param name = "expireTime">过期时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_extendEO> GetByExpireTime(DateTime? expireTime, string sort_, TransactionManager tm_)
		{
			return GetByExpireTime(expireTime, 0, sort_, tm_);
		}
		public async Task<List<Sm_message_extendEO>> GetByExpireTimeAsync(DateTime? expireTime, string sort_, TransactionManager tm_)
		{
			return await GetByExpireTimeAsync(expireTime, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ExpireTime（字段） 查询
		/// </summary>
		/// /// <param name = "expireTime">过期时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_extendEO> GetByExpireTime(DateTime? expireTime, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(expireTime.HasValue ? "`ExpireTime` = @ExpireTime" : "`ExpireTime` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (expireTime.HasValue)
				paras_.Add(Database.CreateInParameter("@ExpireTime", expireTime.Value, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sm_message_extendEO.MapDataReader);
		}
		public async Task<List<Sm_message_extendEO>> GetByExpireTimeAsync(DateTime? expireTime, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(expireTime.HasValue ? "`ExpireTime` = @ExpireTime" : "`ExpireTime` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (expireTime.HasValue)
				paras_.Add(Database.CreateInParameter("@ExpireTime", expireTime.Value, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sm_message_extendEO.MapDataReader);
		}
		#endregion // GetByExpireTime
		#region GetByRemark
		
		/// <summary>
		/// 按 Remark（字段） 查询
		/// </summary>
		/// /// <param name = "remark">备注</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_extendEO> GetByRemark(string remark)
		{
			return GetByRemark(remark, 0, string.Empty, null);
		}
		public async Task<List<Sm_message_extendEO>> GetByRemarkAsync(string remark)
		{
			return await GetByRemarkAsync(remark, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Remark（字段） 查询
		/// </summary>
		/// /// <param name = "remark">备注</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_extendEO> GetByRemark(string remark, TransactionManager tm_)
		{
			return GetByRemark(remark, 0, string.Empty, tm_);
		}
		public async Task<List<Sm_message_extendEO>> GetByRemarkAsync(string remark, TransactionManager tm_)
		{
			return await GetByRemarkAsync(remark, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Remark（字段） 查询
		/// </summary>
		/// /// <param name = "remark">备注</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_extendEO> GetByRemark(string remark, int top_)
		{
			return GetByRemark(remark, top_, string.Empty, null);
		}
		public async Task<List<Sm_message_extendEO>> GetByRemarkAsync(string remark, int top_)
		{
			return await GetByRemarkAsync(remark, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Remark（字段） 查询
		/// </summary>
		/// /// <param name = "remark">备注</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_extendEO> GetByRemark(string remark, int top_, TransactionManager tm_)
		{
			return GetByRemark(remark, top_, string.Empty, tm_);
		}
		public async Task<List<Sm_message_extendEO>> GetByRemarkAsync(string remark, int top_, TransactionManager tm_)
		{
			return await GetByRemarkAsync(remark, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Remark（字段） 查询
		/// </summary>
		/// /// <param name = "remark">备注</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_extendEO> GetByRemark(string remark, string sort_)
		{
			return GetByRemark(remark, 0, sort_, null);
		}
		public async Task<List<Sm_message_extendEO>> GetByRemarkAsync(string remark, string sort_)
		{
			return await GetByRemarkAsync(remark, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Remark（字段） 查询
		/// </summary>
		/// /// <param name = "remark">备注</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_extendEO> GetByRemark(string remark, string sort_, TransactionManager tm_)
		{
			return GetByRemark(remark, 0, sort_, tm_);
		}
		public async Task<List<Sm_message_extendEO>> GetByRemarkAsync(string remark, string sort_, TransactionManager tm_)
		{
			return await GetByRemarkAsync(remark, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Remark（字段） 查询
		/// </summary>
		/// /// <param name = "remark">备注</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_extendEO> GetByRemark(string remark, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(remark != null ? "`Remark` = @Remark" : "`Remark` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (remark != null)
				paras_.Add(Database.CreateInParameter("@Remark", remark, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sm_message_extendEO.MapDataReader);
		}
		public async Task<List<Sm_message_extendEO>> GetByRemarkAsync(string remark, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(remark != null ? "`Remark` = @Remark" : "`Remark` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (remark != null)
				paras_.Add(Database.CreateInParameter("@Remark", remark, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sm_message_extendEO.MapDataReader);
		}
		#endregion // GetByRemark
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
