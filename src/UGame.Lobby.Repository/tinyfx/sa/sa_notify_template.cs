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
	/// 活动通知模板
	/// 【表 sa_notify_template 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Sa_notify_templateEO : IRowMapper<Sa_notify_templateEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Sa_notify_templateEO()
		{
			this.NotifyType = 0;
			this.ActivityType = 0;
			this.Status = false;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private string _originalTempID;
		/// <summary>
		/// 【数据库中的原始主键 TempID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalTempID
		{
			get { return _originalTempID; }
			set { HasOriginal = true; _originalTempID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "TempID", TempID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 模板ID
		/// 【主键 varchar(36)】
		/// </summary>
		[DataMember(Order = 1)]
		public string TempID { get; set; }
		/// <summary>
		/// 运营商编码
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 2)]
		public string OperatorID { get; set; }
		/// <summary>
		/// 国家编码ISO 3166-1三位字母
		/// 【字段 varchar(5)】
		/// </summary>
		[DataMember(Order = 3)]
		public string CountryId { get; set; }
		/// <summary>
		/// 货币类型
		/// 【字段 varchar(5)】
		/// </summary>
		[DataMember(Order = 4)]
		public string CurrencyID { get; set; }
		/// <summary>
		/// 语言代码
		/// 【字段 varchar(20)】
		/// </summary>
		[DataMember(Order = 5)]
		public string LangID { get; set; }
		/// <summary>
		/// 通知类型0-默认1-活动2-站内Email
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 6)]
		public int NotifyType { get; set; }
		/// <summary>
		/// 活动类型100001-注册、首充活动100002-幸运转盘100003-输返活动100004-新用户首充5奖励100005-签到活动100006-绑定手机领取奖励
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 7)]
		public int ActivityType { get; set; }
		/// <summary>
		/// 标题
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 8)]
		public string Title { get; set; }
		/// <summary>
		/// 图片1
		/// 【字段 varchar(500)】
		/// </summary>
		[DataMember(Order = 9)]
		public string Img1 { get; set; }
		/// <summary>
		/// 图片1
		/// 【字段 varchar(500)】
		/// </summary>
		[DataMember(Order = 10)]
		public string Img2 { get; set; }
		/// <summary>
		/// 图片1
		/// 【字段 varchar(500)】
		/// </summary>
		[DataMember(Order = 11)]
		public string Img3 { get; set; }
		/// <summary>
		/// 图片1
		/// 【字段 varchar(500)】
		/// </summary>
		[DataMember(Order = 12)]
		public string Img4 { get; set; }
		/// <summary>
		/// 图片1
		/// 【字段 varchar(500)】
		/// </summary>
		[DataMember(Order = 13)]
		public string Img5 { get; set; }
		/// <summary>
		/// 类型:0-位置1-图片2-html3-文字
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 14)]
		public int? Mode { get; set; }
		/// <summary>
		/// 消息内容
		/// 【字段 varchar(1000)】
		/// </summary>
		[DataMember(Order = 15)]
		public string Content { get; set; }
		/// <summary>
		/// 链接地址
		/// 【字段 varchar(500)】
		/// </summary>
		[DataMember(Order = 16)]
		public string LinkUrl { get; set; }
		/// <summary>
		/// 是否启用
		/// 【字段 tinyint(1)】
		/// </summary>
		[DataMember(Order = 17)]
		public bool Status { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Sa_notify_templateEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Sa_notify_templateEO MapDataReader(IDataReader reader)
		{
		    Sa_notify_templateEO ret = new Sa_notify_templateEO();
			ret.TempID = reader.ToString("TempID");
			ret.OriginalTempID = ret.TempID;
			ret.OperatorID = reader.ToString("OperatorID");
			ret.CountryId = reader.ToString("CountryId");
			ret.CurrencyID = reader.ToString("CurrencyID");
			ret.LangID = reader.ToString("LangID");
			ret.NotifyType = reader.ToInt32("NotifyType");
			ret.ActivityType = reader.ToInt32("ActivityType");
			ret.Title = reader.ToString("Title");
			ret.Img1 = reader.ToString("Img1");
			ret.Img2 = reader.ToString("Img2");
			ret.Img3 = reader.ToString("Img3");
			ret.Img4 = reader.ToString("Img4");
			ret.Img5 = reader.ToString("Img5");
			ret.Mode = reader.ToInt32N("Mode");
			ret.Content = reader.ToString("Content");
			ret.LinkUrl = reader.ToString("LinkUrl");
			ret.Status = reader.ToBoolean("Status");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 活动通知模板
	/// 【表 sa_notify_template 的操作类】
	/// </summary>
	[Obsolete]
	public class Sa_notify_templateMO : MySqlTableMO<Sa_notify_templateEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`sa_notify_template`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Sa_notify_templateMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Sa_notify_templateMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Sa_notify_templateMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Sa_notify_templateEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Sa_notify_templateEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Sa_notify_templateEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`TempID`, `OperatorID`, `CountryId`, `CurrencyID`, `LangID`, `NotifyType`, `ActivityType`, `Title`, `Img1`, `Img2`, `Img3`, `Img4`, `Img5`, `Mode`, `Content`, `LinkUrl`, `Status`) VALUE (@TempID, @OperatorID, @CountryId, @CurrencyID, @LangID, @NotifyType, @ActivityType, @Title, @Img1, @Img2, @Img3, @Img4, @Img5, @Mode, @Content, @LinkUrl, @Status);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TempID", item.TempID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryId", item.CountryId, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", item.LangID, MySqlDbType.VarChar),
				Database.CreateInParameter("@NotifyType", item.NotifyType, MySqlDbType.Int32),
				Database.CreateInParameter("@ActivityType", item.ActivityType, MySqlDbType.Int32),
				Database.CreateInParameter("@Title", item.Title != null ? item.Title : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Img1", item.Img1 != null ? item.Img1 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Img2", item.Img2 != null ? item.Img2 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Img3", item.Img3 != null ? item.Img3 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Img4", item.Img4 != null ? item.Img4 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Img5", item.Img5 != null ? item.Img5 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Mode", item.Mode.HasValue ? item.Mode.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@Content", item.Content != null ? item.Content : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@LinkUrl", item.LinkUrl != null ? item.LinkUrl : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Status", item.Status, MySqlDbType.Byte),
			};
		}
		public int AddByBatch(IEnumerable<Sa_notify_templateEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Sa_notify_templateEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sa_notify_templateEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`TempID`, `OperatorID`, `CountryId`, `CurrencyID`, `LangID`, `NotifyType`, `ActivityType`, `Title`, `Img1`, `Img2`, `Img3`, `Img4`, `Img5`, `Mode`, `Content`, `LinkUrl`, `Status`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.TempID}','{item.OperatorID}','{item.CountryId}','{item.CurrencyID}','{item.LangID}',{item.NotifyType},{item.ActivityType},'{item.Title}','{item.Img1}','{item.Img2}','{item.Img3}','{item.Img4}','{item.Img5}',{item.Mode?.ToString()??null},'{item.Content}','{item.LinkUrl}',{item.Status}),");
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
		/// /// <param name = "tempID">模板ID</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string tempID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(tempID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string tempID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(tempID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string tempID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `TempID` = @TempID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TempID", tempID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Sa_notify_templateEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.TempID, tm_);
		}
		public async Task<int> RemoveAsync(Sa_notify_templateEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.TempID, tm_);
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
		#region RemoveByCountryId
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCountryId(string countryId, TransactionManager tm_ = null)
		{
			RepairRemoveByCountryIdData(countryId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCountryIdAsync(string countryId, TransactionManager tm_ = null)
		{
			RepairRemoveByCountryIdData(countryId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCountryIdData(string countryId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `CountryId` = @CountryId";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar));
		}
		#endregion // RemoveByCountryId
		#region RemoveByCurrencyID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
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
			sql_ = $"DELETE FROM {TableName} WHERE `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByCurrencyID
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
			sql_ = $"DELETE FROM {TableName} WHERE `LangID` = @LangID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByLangID
		#region RemoveByNotifyType
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "notifyType">通知类型0-默认1-活动2-站内Email</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByNotifyType(int notifyType, TransactionManager tm_ = null)
		{
			RepairRemoveByNotifyTypeData(notifyType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByNotifyTypeAsync(int notifyType, TransactionManager tm_ = null)
		{
			RepairRemoveByNotifyTypeData(notifyType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByNotifyTypeData(int notifyType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `NotifyType` = @NotifyType";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@NotifyType", notifyType, MySqlDbType.Int32));
		}
		#endregion // RemoveByNotifyType
		#region RemoveByActivityType
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "activityType">活动类型100001-注册、首充活动100002-幸运转盘100003-输返活动100004-新用户首充5奖励100005-签到活动100006-绑定手机领取奖励</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByActivityType(int activityType, TransactionManager tm_ = null)
		{
			RepairRemoveByActivityTypeData(activityType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByActivityTypeAsync(int activityType, TransactionManager tm_ = null)
		{
			RepairRemoveByActivityTypeData(activityType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByActivityTypeData(int activityType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `ActivityType` = @ActivityType";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ActivityType", activityType, MySqlDbType.Int32));
		}
		#endregion // RemoveByActivityType
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
		public int RemoveByMode(int? mode, TransactionManager tm_ = null)
		{
			RepairRemoveByModeData(mode.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByModeAsync(int? mode, TransactionManager tm_ = null)
		{
			RepairRemoveByModeData(mode.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByModeData(int? mode, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (mode.HasValue ? "`Mode` = @Mode" : "`Mode` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (mode.HasValue)
				paras_.Add(Database.CreateInParameter("@Mode", mode.Value, MySqlDbType.Int32));
		}
		#endregion // RemoveByMode
		#region RemoveByContent
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "content">消息内容</param>
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
		#region RemoveByStatus
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "status">是否启用</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByStatus(bool status, TransactionManager tm_ = null)
		{
			RepairRemoveByStatusData(status, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByStatusAsync(bool status, TransactionManager tm_ = null)
		{
			RepairRemoveByStatusData(status, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByStatusData(bool status, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Status` = @Status";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Byte));
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
		public int Put(Sa_notify_templateEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Sa_notify_templateEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Sa_notify_templateEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `TempID` = @TempID, `OperatorID` = @OperatorID, `CountryId` = @CountryId, `CurrencyID` = @CurrencyID, `LangID` = @LangID, `NotifyType` = @NotifyType, `ActivityType` = @ActivityType, `Title` = @Title, `Img1` = @Img1, `Img2` = @Img2, `Img3` = @Img3, `Img4` = @Img4, `Img5` = @Img5, `Mode` = @Mode, `Content` = @Content, `LinkUrl` = @LinkUrl, `Status` = @Status WHERE `TempID` = @TempID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TempID", item.TempID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryId", item.CountryId, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", item.LangID, MySqlDbType.VarChar),
				Database.CreateInParameter("@NotifyType", item.NotifyType, MySqlDbType.Int32),
				Database.CreateInParameter("@ActivityType", item.ActivityType, MySqlDbType.Int32),
				Database.CreateInParameter("@Title", item.Title != null ? item.Title : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Img1", item.Img1 != null ? item.Img1 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Img2", item.Img2 != null ? item.Img2 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Img3", item.Img3 != null ? item.Img3 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Img4", item.Img4 != null ? item.Img4 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Img5", item.Img5 != null ? item.Img5 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Mode", item.Mode.HasValue ? item.Mode.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@Content", item.Content != null ? item.Content : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@LinkUrl", item.LinkUrl != null ? item.LinkUrl : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Status", item.Status, MySqlDbType.Byte),
				Database.CreateInParameter("@TempID_Original", item.HasOriginal ? item.OriginalTempID : item.TempID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Sa_notify_templateEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Sa_notify_templateEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "tempID">模板ID</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string tempID, string set_, params object[] values_)
		{
			return Put(set_, "`TempID` = @TempID", ConcatValues(values_, tempID));
		}
		public async Task<int> PutByPKAsync(string tempID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`TempID` = @TempID", ConcatValues(values_, tempID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "tempID">模板ID</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string tempID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`TempID` = @TempID", tm_, ConcatValues(values_, tempID));
		}
		public async Task<int> PutByPKAsync(string tempID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`TempID` = @TempID", tm_, ConcatValues(values_, tempID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "tempID">模板ID</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string tempID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@TempID", tempID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`TempID` = @TempID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string tempID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@TempID", tempID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`TempID` = @TempID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutOperatorID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "tempID">模板ID</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorIDByPK(string tempID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(tempID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOperatorIDByPKAsync(string tempID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(tempID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOperatorIDByPKData(string tempID, string operatorID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID  WHERE `TempID` = @TempID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@TempID", tempID, MySqlDbType.VarChar),
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
		#region PutCountryId
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "tempID">模板ID</param>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCountryIdByPK(string tempID, string countryId, TransactionManager tm_ = null)
		{
			RepairPutCountryIdByPKData(tempID, countryId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCountryIdByPKAsync(string tempID, string countryId, TransactionManager tm_ = null)
		{
			RepairPutCountryIdByPKData(tempID, countryId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCountryIdByPKData(string tempID, string countryId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CountryId` = @CountryId  WHERE `TempID` = @TempID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar),
				Database.CreateInParameter("@TempID", tempID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCountryId(string countryId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CountryId` = @CountryId";
			var parameter_ = Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCountryIdAsync(string countryId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CountryId` = @CountryId";
			var parameter_ = Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCountryId
		#region PutCurrencyID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "tempID">模板ID</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCurrencyIDByPK(string tempID, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(tempID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCurrencyIDByPKAsync(string tempID, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(tempID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCurrencyIDByPKData(string tempID, string currencyID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CurrencyID` = @CurrencyID  WHERE `TempID` = @TempID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@TempID", tempID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCurrencyID(string currencyID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CurrencyID` = @CurrencyID";
			var parameter_ = Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCurrencyIDAsync(string currencyID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CurrencyID` = @CurrencyID";
			var parameter_ = Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCurrencyID
		#region PutLangID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "tempID">模板ID</param>
		/// /// <param name = "langID">语言代码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLangIDByPK(string tempID, string langID, TransactionManager tm_ = null)
		{
			RepairPutLangIDByPKData(tempID, langID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLangIDByPKAsync(string tempID, string langID, TransactionManager tm_ = null)
		{
			RepairPutLangIDByPKData(tempID, langID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLangIDByPKData(string tempID, string langID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `LangID` = @LangID  WHERE `TempID` = @TempID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
				Database.CreateInParameter("@TempID", tempID, MySqlDbType.VarChar),
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
			var parameter_ = Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutLangIDAsync(string langID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LangID` = @LangID";
			var parameter_ = Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutLangID
		#region PutNotifyType
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "tempID">模板ID</param>
		/// /// <param name = "notifyType">通知类型0-默认1-活动2-站内Email</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutNotifyTypeByPK(string tempID, int notifyType, TransactionManager tm_ = null)
		{
			RepairPutNotifyTypeByPKData(tempID, notifyType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutNotifyTypeByPKAsync(string tempID, int notifyType, TransactionManager tm_ = null)
		{
			RepairPutNotifyTypeByPKData(tempID, notifyType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutNotifyTypeByPKData(string tempID, int notifyType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `NotifyType` = @NotifyType  WHERE `TempID` = @TempID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyType", notifyType, MySqlDbType.Int32),
				Database.CreateInParameter("@TempID", tempID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "notifyType">通知类型0-默认1-活动2-站内Email</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutNotifyType(int notifyType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `NotifyType` = @NotifyType";
			var parameter_ = Database.CreateInParameter("@NotifyType", notifyType, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutNotifyTypeAsync(int notifyType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `NotifyType` = @NotifyType";
			var parameter_ = Database.CreateInParameter("@NotifyType", notifyType, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutNotifyType
		#region PutActivityType
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "tempID">模板ID</param>
		/// /// <param name = "activityType">活动类型100001-注册、首充活动100002-幸运转盘100003-输返活动100004-新用户首充5奖励100005-签到活动100006-绑定手机领取奖励</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutActivityTypeByPK(string tempID, int activityType, TransactionManager tm_ = null)
		{
			RepairPutActivityTypeByPKData(tempID, activityType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutActivityTypeByPKAsync(string tempID, int activityType, TransactionManager tm_ = null)
		{
			RepairPutActivityTypeByPKData(tempID, activityType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutActivityTypeByPKData(string tempID, int activityType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ActivityType` = @ActivityType  WHERE `TempID` = @TempID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ActivityType", activityType, MySqlDbType.Int32),
				Database.CreateInParameter("@TempID", tempID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "activityType">活动类型100001-注册、首充活动100002-幸运转盘100003-输返活动100004-新用户首充5奖励100005-签到活动100006-绑定手机领取奖励</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutActivityType(int activityType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ActivityType` = @ActivityType";
			var parameter_ = Database.CreateInParameter("@ActivityType", activityType, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutActivityTypeAsync(int activityType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ActivityType` = @ActivityType";
			var parameter_ = Database.CreateInParameter("@ActivityType", activityType, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutActivityType
		#region PutTitle
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "tempID">模板ID</param>
		/// /// <param name = "title">标题</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTitleByPK(string tempID, string title, TransactionManager tm_ = null)
		{
			RepairPutTitleByPKData(tempID, title, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTitleByPKAsync(string tempID, string title, TransactionManager tm_ = null)
		{
			RepairPutTitleByPKData(tempID, title, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTitleByPKData(string tempID, string title, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Title` = @Title  WHERE `TempID` = @TempID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Title", title != null ? title : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@TempID", tempID, MySqlDbType.VarChar),
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
		/// /// <param name = "tempID">模板ID</param>
		/// /// <param name = "img1">图片1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutImg1ByPK(string tempID, string img1, TransactionManager tm_ = null)
		{
			RepairPutImg1ByPKData(tempID, img1, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutImg1ByPKAsync(string tempID, string img1, TransactionManager tm_ = null)
		{
			RepairPutImg1ByPKData(tempID, img1, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutImg1ByPKData(string tempID, string img1, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Img1` = @Img1  WHERE `TempID` = @TempID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Img1", img1 != null ? img1 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@TempID", tempID, MySqlDbType.VarChar),
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
		/// /// <param name = "tempID">模板ID</param>
		/// /// <param name = "img2">图片1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutImg2ByPK(string tempID, string img2, TransactionManager tm_ = null)
		{
			RepairPutImg2ByPKData(tempID, img2, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutImg2ByPKAsync(string tempID, string img2, TransactionManager tm_ = null)
		{
			RepairPutImg2ByPKData(tempID, img2, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutImg2ByPKData(string tempID, string img2, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Img2` = @Img2  WHERE `TempID` = @TempID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Img2", img2 != null ? img2 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@TempID", tempID, MySqlDbType.VarChar),
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
		/// /// <param name = "tempID">模板ID</param>
		/// /// <param name = "img3">图片1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutImg3ByPK(string tempID, string img3, TransactionManager tm_ = null)
		{
			RepairPutImg3ByPKData(tempID, img3, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutImg3ByPKAsync(string tempID, string img3, TransactionManager tm_ = null)
		{
			RepairPutImg3ByPKData(tempID, img3, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutImg3ByPKData(string tempID, string img3, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Img3` = @Img3  WHERE `TempID` = @TempID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Img3", img3 != null ? img3 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@TempID", tempID, MySqlDbType.VarChar),
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
		/// /// <param name = "tempID">模板ID</param>
		/// /// <param name = "img4">图片1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutImg4ByPK(string tempID, string img4, TransactionManager tm_ = null)
		{
			RepairPutImg4ByPKData(tempID, img4, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutImg4ByPKAsync(string tempID, string img4, TransactionManager tm_ = null)
		{
			RepairPutImg4ByPKData(tempID, img4, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutImg4ByPKData(string tempID, string img4, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Img4` = @Img4  WHERE `TempID` = @TempID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Img4", img4 != null ? img4 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@TempID", tempID, MySqlDbType.VarChar),
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
		/// /// <param name = "tempID">模板ID</param>
		/// /// <param name = "img5">图片1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutImg5ByPK(string tempID, string img5, TransactionManager tm_ = null)
		{
			RepairPutImg5ByPKData(tempID, img5, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutImg5ByPKAsync(string tempID, string img5, TransactionManager tm_ = null)
		{
			RepairPutImg5ByPKData(tempID, img5, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutImg5ByPKData(string tempID, string img5, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Img5` = @Img5  WHERE `TempID` = @TempID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Img5", img5 != null ? img5 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@TempID", tempID, MySqlDbType.VarChar),
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
		/// /// <param name = "tempID">模板ID</param>
		/// /// <param name = "mode">类型:0-位置1-图片2-html3-文字</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutModeByPK(string tempID, int? mode, TransactionManager tm_ = null)
		{
			RepairPutModeByPKData(tempID, mode, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutModeByPKAsync(string tempID, int? mode, TransactionManager tm_ = null)
		{
			RepairPutModeByPKData(tempID, mode, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutModeByPKData(string tempID, int? mode, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Mode` = @Mode  WHERE `TempID` = @TempID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Mode", mode.HasValue ? mode.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@TempID", tempID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "mode">类型:0-位置1-图片2-html3-文字</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMode(int? mode, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Mode` = @Mode";
			var parameter_ = Database.CreateInParameter("@Mode", mode.HasValue ? mode.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutModeAsync(int? mode, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Mode` = @Mode";
			var parameter_ = Database.CreateInParameter("@Mode", mode.HasValue ? mode.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutMode
		#region PutContent
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "tempID">模板ID</param>
		/// /// <param name = "content">消息内容</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutContentByPK(string tempID, string content, TransactionManager tm_ = null)
		{
			RepairPutContentByPKData(tempID, content, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutContentByPKAsync(string tempID, string content, TransactionManager tm_ = null)
		{
			RepairPutContentByPKData(tempID, content, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutContentByPKData(string tempID, string content, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Content` = @Content  WHERE `TempID` = @TempID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Content", content != null ? content : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@TempID", tempID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "content">消息内容</param>
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
		#region PutLinkUrl
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "tempID">模板ID</param>
		/// /// <param name = "linkUrl">链接地址</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLinkUrlByPK(string tempID, string linkUrl, TransactionManager tm_ = null)
		{
			RepairPutLinkUrlByPKData(tempID, linkUrl, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLinkUrlByPKAsync(string tempID, string linkUrl, TransactionManager tm_ = null)
		{
			RepairPutLinkUrlByPKData(tempID, linkUrl, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLinkUrlByPKData(string tempID, string linkUrl, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `LinkUrl` = @LinkUrl  WHERE `TempID` = @TempID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LinkUrl", linkUrl != null ? linkUrl : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@TempID", tempID, MySqlDbType.VarChar),
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
		#region PutStatus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "tempID">模板ID</param>
		/// /// <param name = "status">是否启用</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutStatusByPK(string tempID, bool status, TransactionManager tm_ = null)
		{
			RepairPutStatusByPKData(tempID, status, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutStatusByPKAsync(string tempID, bool status, TransactionManager tm_ = null)
		{
			RepairPutStatusByPKData(tempID, status, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutStatusByPKData(string tempID, bool status, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Status` = @Status  WHERE `TempID` = @TempID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Status", status, MySqlDbType.Byte),
				Database.CreateInParameter("@TempID", tempID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "status">是否启用</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutStatus(bool status, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Status` = @Status";
			var parameter_ = Database.CreateInParameter("@Status", status, MySqlDbType.Byte);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutStatusAsync(bool status, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Status` = @Status";
			var parameter_ = Database.CreateInParameter("@Status", status, MySqlDbType.Byte);
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
		public bool Set(Sa_notify_templateEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.TempID) == null)
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
		public async Task<bool> SetAsync(Sa_notify_templateEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.TempID) == null)
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
		/// /// <param name = "tempID">模板ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Sa_notify_templateEO GetByPK(string tempID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(tempID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sa_notify_templateEO.MapDataReader);
		}
		public async Task<Sa_notify_templateEO> GetByPKAsync(string tempID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(tempID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sa_notify_templateEO.MapDataReader);
		}
		private void RepairGetByPKData(string tempID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`TempID` = @TempID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TempID", tempID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 OperatorID（字段）
		/// </summary>
		/// /// <param name = "tempID">模板ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorIDByPK(string tempID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TempID", tempID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OperatorID`", "`TempID` = @TempID", paras_, tm_);
		}
		public async Task<string> GetOperatorIDByPKAsync(string tempID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TempID", tempID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OperatorID`", "`TempID` = @TempID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CountryId（字段）
		/// </summary>
		/// /// <param name = "tempID">模板ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCountryIdByPK(string tempID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TempID", tempID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CountryId`", "`TempID` = @TempID", paras_, tm_);
		}
		public async Task<string> GetCountryIdByPKAsync(string tempID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TempID", tempID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CountryId`", "`TempID` = @TempID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CurrencyID（字段）
		/// </summary>
		/// /// <param name = "tempID">模板ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCurrencyIDByPK(string tempID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TempID", tempID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CurrencyID`", "`TempID` = @TempID", paras_, tm_);
		}
		public async Task<string> GetCurrencyIDByPKAsync(string tempID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TempID", tempID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CurrencyID`", "`TempID` = @TempID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 LangID（字段）
		/// </summary>
		/// /// <param name = "tempID">模板ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetLangIDByPK(string tempID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TempID", tempID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`LangID`", "`TempID` = @TempID", paras_, tm_);
		}
		public async Task<string> GetLangIDByPKAsync(string tempID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TempID", tempID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`LangID`", "`TempID` = @TempID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 NotifyType（字段）
		/// </summary>
		/// /// <param name = "tempID">模板ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetNotifyTypeByPK(string tempID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TempID", tempID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`NotifyType`", "`TempID` = @TempID", paras_, tm_);
		}
		public async Task<int> GetNotifyTypeByPKAsync(string tempID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TempID", tempID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`NotifyType`", "`TempID` = @TempID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ActivityType（字段）
		/// </summary>
		/// /// <param name = "tempID">模板ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetActivityTypeByPK(string tempID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TempID", tempID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`ActivityType`", "`TempID` = @TempID", paras_, tm_);
		}
		public async Task<int> GetActivityTypeByPKAsync(string tempID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TempID", tempID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`ActivityType`", "`TempID` = @TempID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Title（字段）
		/// </summary>
		/// /// <param name = "tempID">模板ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetTitleByPK(string tempID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TempID", tempID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Title`", "`TempID` = @TempID", paras_, tm_);
		}
		public async Task<string> GetTitleByPKAsync(string tempID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TempID", tempID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Title`", "`TempID` = @TempID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Img1（字段）
		/// </summary>
		/// /// <param name = "tempID">模板ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetImg1ByPK(string tempID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TempID", tempID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Img1`", "`TempID` = @TempID", paras_, tm_);
		}
		public async Task<string> GetImg1ByPKAsync(string tempID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TempID", tempID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Img1`", "`TempID` = @TempID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Img2（字段）
		/// </summary>
		/// /// <param name = "tempID">模板ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetImg2ByPK(string tempID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TempID", tempID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Img2`", "`TempID` = @TempID", paras_, tm_);
		}
		public async Task<string> GetImg2ByPKAsync(string tempID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TempID", tempID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Img2`", "`TempID` = @TempID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Img3（字段）
		/// </summary>
		/// /// <param name = "tempID">模板ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetImg3ByPK(string tempID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TempID", tempID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Img3`", "`TempID` = @TempID", paras_, tm_);
		}
		public async Task<string> GetImg3ByPKAsync(string tempID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TempID", tempID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Img3`", "`TempID` = @TempID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Img4（字段）
		/// </summary>
		/// /// <param name = "tempID">模板ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetImg4ByPK(string tempID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TempID", tempID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Img4`", "`TempID` = @TempID", paras_, tm_);
		}
		public async Task<string> GetImg4ByPKAsync(string tempID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TempID", tempID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Img4`", "`TempID` = @TempID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Img5（字段）
		/// </summary>
		/// /// <param name = "tempID">模板ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetImg5ByPK(string tempID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TempID", tempID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Img5`", "`TempID` = @TempID", paras_, tm_);
		}
		public async Task<string> GetImg5ByPKAsync(string tempID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TempID", tempID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Img5`", "`TempID` = @TempID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Mode（字段）
		/// </summary>
		/// /// <param name = "tempID">模板ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int? GetModeByPK(string tempID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TempID", tempID, MySqlDbType.VarChar),
			};
			return (int?)GetScalar("`Mode`", "`TempID` = @TempID", paras_, tm_);
		}
		public async Task<int?> GetModeByPKAsync(string tempID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TempID", tempID, MySqlDbType.VarChar),
			};
			return (int?)await GetScalarAsync("`Mode`", "`TempID` = @TempID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Content（字段）
		/// </summary>
		/// /// <param name = "tempID">模板ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetContentByPK(string tempID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TempID", tempID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Content`", "`TempID` = @TempID", paras_, tm_);
		}
		public async Task<string> GetContentByPKAsync(string tempID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TempID", tempID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Content`", "`TempID` = @TempID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 LinkUrl（字段）
		/// </summary>
		/// /// <param name = "tempID">模板ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetLinkUrlByPK(string tempID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TempID", tempID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`LinkUrl`", "`TempID` = @TempID", paras_, tm_);
		}
		public async Task<string> GetLinkUrlByPKAsync(string tempID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TempID", tempID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`LinkUrl`", "`TempID` = @TempID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Status（字段）
		/// </summary>
		/// /// <param name = "tempID">模板ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public bool GetStatusByPK(string tempID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TempID", tempID, MySqlDbType.VarChar),
			};
			return (bool)GetScalar("`Status`", "`TempID` = @TempID", paras_, tm_);
		}
		public async Task<bool> GetStatusByPKAsync(string tempID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TempID", tempID, MySqlDbType.VarChar),
			};
			return (bool)await GetScalarAsync("`Status`", "`TempID` = @TempID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<Sa_notify_templateEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_notify_templateEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<Sa_notify_templateEO>> GetByOperatorIDAsync(string operatorID, int top_)
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
		public List<Sa_notify_templateEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_notify_templateEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<Sa_notify_templateEO>> GetByOperatorIDAsync(string operatorID, string sort_)
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
		public List<Sa_notify_templateEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<Sa_notify_templateEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
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
		public List<Sa_notify_templateEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_notify_templateEO.MapDataReader);
		}
		public async Task<List<Sa_notify_templateEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_notify_templateEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByCountryId
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByCountryId(string countryId)
		{
			return GetByCountryId(countryId, 0, string.Empty, null);
		}
		public async Task<List<Sa_notify_templateEO>> GetByCountryIdAsync(string countryId)
		{
			return await GetByCountryIdAsync(countryId, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByCountryId(string countryId, TransactionManager tm_)
		{
			return GetByCountryId(countryId, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_notify_templateEO>> GetByCountryIdAsync(string countryId, TransactionManager tm_)
		{
			return await GetByCountryIdAsync(countryId, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByCountryId(string countryId, int top_)
		{
			return GetByCountryId(countryId, top_, string.Empty, null);
		}
		public async Task<List<Sa_notify_templateEO>> GetByCountryIdAsync(string countryId, int top_)
		{
			return await GetByCountryIdAsync(countryId, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByCountryId(string countryId, int top_, TransactionManager tm_)
		{
			return GetByCountryId(countryId, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_notify_templateEO>> GetByCountryIdAsync(string countryId, int top_, TransactionManager tm_)
		{
			return await GetByCountryIdAsync(countryId, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByCountryId(string countryId, string sort_)
		{
			return GetByCountryId(countryId, 0, sort_, null);
		}
		public async Task<List<Sa_notify_templateEO>> GetByCountryIdAsync(string countryId, string sort_)
		{
			return await GetByCountryIdAsync(countryId, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByCountryId(string countryId, string sort_, TransactionManager tm_)
		{
			return GetByCountryId(countryId, 0, sort_, tm_);
		}
		public async Task<List<Sa_notify_templateEO>> GetByCountryIdAsync(string countryId, string sort_, TransactionManager tm_)
		{
			return await GetByCountryIdAsync(countryId, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByCountryId(string countryId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CountryId` = @CountryId", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_notify_templateEO.MapDataReader);
		}
		public async Task<List<Sa_notify_templateEO>> GetByCountryIdAsync(string countryId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CountryId` = @CountryId", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_notify_templateEO.MapDataReader);
		}
		#endregion // GetByCountryId
		#region GetByCurrencyID
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByCurrencyID(string currencyID)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, null);
		}
		public async Task<List<Sa_notify_templateEO>> GetByCurrencyIDAsync(string currencyID)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByCurrencyID(string currencyID, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_notify_templateEO>> GetByCurrencyIDAsync(string currencyID, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByCurrencyID(string currencyID, int top_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, null);
		}
		public async Task<List<Sa_notify_templateEO>> GetByCurrencyIDAsync(string currencyID, int top_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByCurrencyID(string currencyID, int top_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_notify_templateEO>> GetByCurrencyIDAsync(string currencyID, int top_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByCurrencyID(string currencyID, string sort_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, null);
		}
		public async Task<List<Sa_notify_templateEO>> GetByCurrencyIDAsync(string currencyID, string sort_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByCurrencyID(string currencyID, string sort_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, tm_);
		}
		public async Task<List<Sa_notify_templateEO>> GetByCurrencyIDAsync(string currencyID, string sort_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByCurrencyID(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_notify_templateEO.MapDataReader);
		}
		public async Task<List<Sa_notify_templateEO>> GetByCurrencyIDAsync(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_notify_templateEO.MapDataReader);
		}
		#endregion // GetByCurrencyID
		#region GetByLangID
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言代码</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByLangID(string langID)
		{
			return GetByLangID(langID, 0, string.Empty, null);
		}
		public async Task<List<Sa_notify_templateEO>> GetByLangIDAsync(string langID)
		{
			return await GetByLangIDAsync(langID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言代码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByLangID(string langID, TransactionManager tm_)
		{
			return GetByLangID(langID, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_notify_templateEO>> GetByLangIDAsync(string langID, TransactionManager tm_)
		{
			return await GetByLangIDAsync(langID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言代码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByLangID(string langID, int top_)
		{
			return GetByLangID(langID, top_, string.Empty, null);
		}
		public async Task<List<Sa_notify_templateEO>> GetByLangIDAsync(string langID, int top_)
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
		public List<Sa_notify_templateEO> GetByLangID(string langID, int top_, TransactionManager tm_)
		{
			return GetByLangID(langID, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_notify_templateEO>> GetByLangIDAsync(string langID, int top_, TransactionManager tm_)
		{
			return await GetByLangIDAsync(langID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言代码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByLangID(string langID, string sort_)
		{
			return GetByLangID(langID, 0, sort_, null);
		}
		public async Task<List<Sa_notify_templateEO>> GetByLangIDAsync(string langID, string sort_)
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
		public List<Sa_notify_templateEO> GetByLangID(string langID, string sort_, TransactionManager tm_)
		{
			return GetByLangID(langID, 0, sort_, tm_);
		}
		public async Task<List<Sa_notify_templateEO>> GetByLangIDAsync(string langID, string sort_, TransactionManager tm_)
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
		public List<Sa_notify_templateEO> GetByLangID(string langID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LangID` = @LangID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_notify_templateEO.MapDataReader);
		}
		public async Task<List<Sa_notify_templateEO>> GetByLangIDAsync(string langID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LangID` = @LangID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_notify_templateEO.MapDataReader);
		}
		#endregion // GetByLangID
		#region GetByNotifyType
		
		/// <summary>
		/// 按 NotifyType（字段） 查询
		/// </summary>
		/// /// <param name = "notifyType">通知类型0-默认1-活动2-站内Email</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByNotifyType(int notifyType)
		{
			return GetByNotifyType(notifyType, 0, string.Empty, null);
		}
		public async Task<List<Sa_notify_templateEO>> GetByNotifyTypeAsync(int notifyType)
		{
			return await GetByNotifyTypeAsync(notifyType, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NotifyType（字段） 查询
		/// </summary>
		/// /// <param name = "notifyType">通知类型0-默认1-活动2-站内Email</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByNotifyType(int notifyType, TransactionManager tm_)
		{
			return GetByNotifyType(notifyType, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_notify_templateEO>> GetByNotifyTypeAsync(int notifyType, TransactionManager tm_)
		{
			return await GetByNotifyTypeAsync(notifyType, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NotifyType（字段） 查询
		/// </summary>
		/// /// <param name = "notifyType">通知类型0-默认1-活动2-站内Email</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByNotifyType(int notifyType, int top_)
		{
			return GetByNotifyType(notifyType, top_, string.Empty, null);
		}
		public async Task<List<Sa_notify_templateEO>> GetByNotifyTypeAsync(int notifyType, int top_)
		{
			return await GetByNotifyTypeAsync(notifyType, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NotifyType（字段） 查询
		/// </summary>
		/// /// <param name = "notifyType">通知类型0-默认1-活动2-站内Email</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByNotifyType(int notifyType, int top_, TransactionManager tm_)
		{
			return GetByNotifyType(notifyType, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_notify_templateEO>> GetByNotifyTypeAsync(int notifyType, int top_, TransactionManager tm_)
		{
			return await GetByNotifyTypeAsync(notifyType, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NotifyType（字段） 查询
		/// </summary>
		/// /// <param name = "notifyType">通知类型0-默认1-活动2-站内Email</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByNotifyType(int notifyType, string sort_)
		{
			return GetByNotifyType(notifyType, 0, sort_, null);
		}
		public async Task<List<Sa_notify_templateEO>> GetByNotifyTypeAsync(int notifyType, string sort_)
		{
			return await GetByNotifyTypeAsync(notifyType, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 NotifyType（字段） 查询
		/// </summary>
		/// /// <param name = "notifyType">通知类型0-默认1-活动2-站内Email</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByNotifyType(int notifyType, string sort_, TransactionManager tm_)
		{
			return GetByNotifyType(notifyType, 0, sort_, tm_);
		}
		public async Task<List<Sa_notify_templateEO>> GetByNotifyTypeAsync(int notifyType, string sort_, TransactionManager tm_)
		{
			return await GetByNotifyTypeAsync(notifyType, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 NotifyType（字段） 查询
		/// </summary>
		/// /// <param name = "notifyType">通知类型0-默认1-活动2-站内Email</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByNotifyType(int notifyType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`NotifyType` = @NotifyType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@NotifyType", notifyType, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_notify_templateEO.MapDataReader);
		}
		public async Task<List<Sa_notify_templateEO>> GetByNotifyTypeAsync(int notifyType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`NotifyType` = @NotifyType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@NotifyType", notifyType, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_notify_templateEO.MapDataReader);
		}
		#endregion // GetByNotifyType
		#region GetByActivityType
		
		/// <summary>
		/// 按 ActivityType（字段） 查询
		/// </summary>
		/// /// <param name = "activityType">活动类型100001-注册、首充活动100002-幸运转盘100003-输返活动100004-新用户首充5奖励100005-签到活动100006-绑定手机领取奖励</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByActivityType(int activityType)
		{
			return GetByActivityType(activityType, 0, string.Empty, null);
		}
		public async Task<List<Sa_notify_templateEO>> GetByActivityTypeAsync(int activityType)
		{
			return await GetByActivityTypeAsync(activityType, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ActivityType（字段） 查询
		/// </summary>
		/// /// <param name = "activityType">活动类型100001-注册、首充活动100002-幸运转盘100003-输返活动100004-新用户首充5奖励100005-签到活动100006-绑定手机领取奖励</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByActivityType(int activityType, TransactionManager tm_)
		{
			return GetByActivityType(activityType, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_notify_templateEO>> GetByActivityTypeAsync(int activityType, TransactionManager tm_)
		{
			return await GetByActivityTypeAsync(activityType, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ActivityType（字段） 查询
		/// </summary>
		/// /// <param name = "activityType">活动类型100001-注册、首充活动100002-幸运转盘100003-输返活动100004-新用户首充5奖励100005-签到活动100006-绑定手机领取奖励</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByActivityType(int activityType, int top_)
		{
			return GetByActivityType(activityType, top_, string.Empty, null);
		}
		public async Task<List<Sa_notify_templateEO>> GetByActivityTypeAsync(int activityType, int top_)
		{
			return await GetByActivityTypeAsync(activityType, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ActivityType（字段） 查询
		/// </summary>
		/// /// <param name = "activityType">活动类型100001-注册、首充活动100002-幸运转盘100003-输返活动100004-新用户首充5奖励100005-签到活动100006-绑定手机领取奖励</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByActivityType(int activityType, int top_, TransactionManager tm_)
		{
			return GetByActivityType(activityType, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_notify_templateEO>> GetByActivityTypeAsync(int activityType, int top_, TransactionManager tm_)
		{
			return await GetByActivityTypeAsync(activityType, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ActivityType（字段） 查询
		/// </summary>
		/// /// <param name = "activityType">活动类型100001-注册、首充活动100002-幸运转盘100003-输返活动100004-新用户首充5奖励100005-签到活动100006-绑定手机领取奖励</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByActivityType(int activityType, string sort_)
		{
			return GetByActivityType(activityType, 0, sort_, null);
		}
		public async Task<List<Sa_notify_templateEO>> GetByActivityTypeAsync(int activityType, string sort_)
		{
			return await GetByActivityTypeAsync(activityType, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ActivityType（字段） 查询
		/// </summary>
		/// /// <param name = "activityType">活动类型100001-注册、首充活动100002-幸运转盘100003-输返活动100004-新用户首充5奖励100005-签到活动100006-绑定手机领取奖励</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByActivityType(int activityType, string sort_, TransactionManager tm_)
		{
			return GetByActivityType(activityType, 0, sort_, tm_);
		}
		public async Task<List<Sa_notify_templateEO>> GetByActivityTypeAsync(int activityType, string sort_, TransactionManager tm_)
		{
			return await GetByActivityTypeAsync(activityType, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ActivityType（字段） 查询
		/// </summary>
		/// /// <param name = "activityType">活动类型100001-注册、首充活动100002-幸运转盘100003-输返活动100004-新用户首充5奖励100005-签到活动100006-绑定手机领取奖励</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByActivityType(int activityType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ActivityType` = @ActivityType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ActivityType", activityType, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_notify_templateEO.MapDataReader);
		}
		public async Task<List<Sa_notify_templateEO>> GetByActivityTypeAsync(int activityType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ActivityType` = @ActivityType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ActivityType", activityType, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_notify_templateEO.MapDataReader);
		}
		#endregion // GetByActivityType
		#region GetByTitle
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">标题</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByTitle(string title)
		{
			return GetByTitle(title, 0, string.Empty, null);
		}
		public async Task<List<Sa_notify_templateEO>> GetByTitleAsync(string title)
		{
			return await GetByTitleAsync(title, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">标题</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByTitle(string title, TransactionManager tm_)
		{
			return GetByTitle(title, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_notify_templateEO>> GetByTitleAsync(string title, TransactionManager tm_)
		{
			return await GetByTitleAsync(title, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">标题</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByTitle(string title, int top_)
		{
			return GetByTitle(title, top_, string.Empty, null);
		}
		public async Task<List<Sa_notify_templateEO>> GetByTitleAsync(string title, int top_)
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
		public List<Sa_notify_templateEO> GetByTitle(string title, int top_, TransactionManager tm_)
		{
			return GetByTitle(title, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_notify_templateEO>> GetByTitleAsync(string title, int top_, TransactionManager tm_)
		{
			return await GetByTitleAsync(title, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">标题</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByTitle(string title, string sort_)
		{
			return GetByTitle(title, 0, sort_, null);
		}
		public async Task<List<Sa_notify_templateEO>> GetByTitleAsync(string title, string sort_)
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
		public List<Sa_notify_templateEO> GetByTitle(string title, string sort_, TransactionManager tm_)
		{
			return GetByTitle(title, 0, sort_, tm_);
		}
		public async Task<List<Sa_notify_templateEO>> GetByTitleAsync(string title, string sort_, TransactionManager tm_)
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
		public List<Sa_notify_templateEO> GetByTitle(string title, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(title != null ? "`Title` = @Title" : "`Title` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (title != null)
				paras_.Add(Database.CreateInParameter("@Title", title, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_notify_templateEO.MapDataReader);
		}
		public async Task<List<Sa_notify_templateEO>> GetByTitleAsync(string title, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(title != null ? "`Title` = @Title" : "`Title` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (title != null)
				paras_.Add(Database.CreateInParameter("@Title", title, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_notify_templateEO.MapDataReader);
		}
		#endregion // GetByTitle
		#region GetByImg1
		
		/// <summary>
		/// 按 Img1（字段） 查询
		/// </summary>
		/// /// <param name = "img1">图片1</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByImg1(string img1)
		{
			return GetByImg1(img1, 0, string.Empty, null);
		}
		public async Task<List<Sa_notify_templateEO>> GetByImg1Async(string img1)
		{
			return await GetByImg1Async(img1, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Img1（字段） 查询
		/// </summary>
		/// /// <param name = "img1">图片1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByImg1(string img1, TransactionManager tm_)
		{
			return GetByImg1(img1, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_notify_templateEO>> GetByImg1Async(string img1, TransactionManager tm_)
		{
			return await GetByImg1Async(img1, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Img1（字段） 查询
		/// </summary>
		/// /// <param name = "img1">图片1</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByImg1(string img1, int top_)
		{
			return GetByImg1(img1, top_, string.Empty, null);
		}
		public async Task<List<Sa_notify_templateEO>> GetByImg1Async(string img1, int top_)
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
		public List<Sa_notify_templateEO> GetByImg1(string img1, int top_, TransactionManager tm_)
		{
			return GetByImg1(img1, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_notify_templateEO>> GetByImg1Async(string img1, int top_, TransactionManager tm_)
		{
			return await GetByImg1Async(img1, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Img1（字段） 查询
		/// </summary>
		/// /// <param name = "img1">图片1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByImg1(string img1, string sort_)
		{
			return GetByImg1(img1, 0, sort_, null);
		}
		public async Task<List<Sa_notify_templateEO>> GetByImg1Async(string img1, string sort_)
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
		public List<Sa_notify_templateEO> GetByImg1(string img1, string sort_, TransactionManager tm_)
		{
			return GetByImg1(img1, 0, sort_, tm_);
		}
		public async Task<List<Sa_notify_templateEO>> GetByImg1Async(string img1, string sort_, TransactionManager tm_)
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
		public List<Sa_notify_templateEO> GetByImg1(string img1, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(img1 != null ? "`Img1` = @Img1" : "`Img1` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (img1 != null)
				paras_.Add(Database.CreateInParameter("@Img1", img1, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_notify_templateEO.MapDataReader);
		}
		public async Task<List<Sa_notify_templateEO>> GetByImg1Async(string img1, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(img1 != null ? "`Img1` = @Img1" : "`Img1` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (img1 != null)
				paras_.Add(Database.CreateInParameter("@Img1", img1, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_notify_templateEO.MapDataReader);
		}
		#endregion // GetByImg1
		#region GetByImg2
		
		/// <summary>
		/// 按 Img2（字段） 查询
		/// </summary>
		/// /// <param name = "img2">图片1</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByImg2(string img2)
		{
			return GetByImg2(img2, 0, string.Empty, null);
		}
		public async Task<List<Sa_notify_templateEO>> GetByImg2Async(string img2)
		{
			return await GetByImg2Async(img2, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Img2（字段） 查询
		/// </summary>
		/// /// <param name = "img2">图片1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByImg2(string img2, TransactionManager tm_)
		{
			return GetByImg2(img2, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_notify_templateEO>> GetByImg2Async(string img2, TransactionManager tm_)
		{
			return await GetByImg2Async(img2, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Img2（字段） 查询
		/// </summary>
		/// /// <param name = "img2">图片1</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByImg2(string img2, int top_)
		{
			return GetByImg2(img2, top_, string.Empty, null);
		}
		public async Task<List<Sa_notify_templateEO>> GetByImg2Async(string img2, int top_)
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
		public List<Sa_notify_templateEO> GetByImg2(string img2, int top_, TransactionManager tm_)
		{
			return GetByImg2(img2, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_notify_templateEO>> GetByImg2Async(string img2, int top_, TransactionManager tm_)
		{
			return await GetByImg2Async(img2, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Img2（字段） 查询
		/// </summary>
		/// /// <param name = "img2">图片1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByImg2(string img2, string sort_)
		{
			return GetByImg2(img2, 0, sort_, null);
		}
		public async Task<List<Sa_notify_templateEO>> GetByImg2Async(string img2, string sort_)
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
		public List<Sa_notify_templateEO> GetByImg2(string img2, string sort_, TransactionManager tm_)
		{
			return GetByImg2(img2, 0, sort_, tm_);
		}
		public async Task<List<Sa_notify_templateEO>> GetByImg2Async(string img2, string sort_, TransactionManager tm_)
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
		public List<Sa_notify_templateEO> GetByImg2(string img2, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(img2 != null ? "`Img2` = @Img2" : "`Img2` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (img2 != null)
				paras_.Add(Database.CreateInParameter("@Img2", img2, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_notify_templateEO.MapDataReader);
		}
		public async Task<List<Sa_notify_templateEO>> GetByImg2Async(string img2, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(img2 != null ? "`Img2` = @Img2" : "`Img2` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (img2 != null)
				paras_.Add(Database.CreateInParameter("@Img2", img2, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_notify_templateEO.MapDataReader);
		}
		#endregion // GetByImg2
		#region GetByImg3
		
		/// <summary>
		/// 按 Img3（字段） 查询
		/// </summary>
		/// /// <param name = "img3">图片1</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByImg3(string img3)
		{
			return GetByImg3(img3, 0, string.Empty, null);
		}
		public async Task<List<Sa_notify_templateEO>> GetByImg3Async(string img3)
		{
			return await GetByImg3Async(img3, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Img3（字段） 查询
		/// </summary>
		/// /// <param name = "img3">图片1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByImg3(string img3, TransactionManager tm_)
		{
			return GetByImg3(img3, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_notify_templateEO>> GetByImg3Async(string img3, TransactionManager tm_)
		{
			return await GetByImg3Async(img3, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Img3（字段） 查询
		/// </summary>
		/// /// <param name = "img3">图片1</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByImg3(string img3, int top_)
		{
			return GetByImg3(img3, top_, string.Empty, null);
		}
		public async Task<List<Sa_notify_templateEO>> GetByImg3Async(string img3, int top_)
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
		public List<Sa_notify_templateEO> GetByImg3(string img3, int top_, TransactionManager tm_)
		{
			return GetByImg3(img3, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_notify_templateEO>> GetByImg3Async(string img3, int top_, TransactionManager tm_)
		{
			return await GetByImg3Async(img3, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Img3（字段） 查询
		/// </summary>
		/// /// <param name = "img3">图片1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByImg3(string img3, string sort_)
		{
			return GetByImg3(img3, 0, sort_, null);
		}
		public async Task<List<Sa_notify_templateEO>> GetByImg3Async(string img3, string sort_)
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
		public List<Sa_notify_templateEO> GetByImg3(string img3, string sort_, TransactionManager tm_)
		{
			return GetByImg3(img3, 0, sort_, tm_);
		}
		public async Task<List<Sa_notify_templateEO>> GetByImg3Async(string img3, string sort_, TransactionManager tm_)
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
		public List<Sa_notify_templateEO> GetByImg3(string img3, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(img3 != null ? "`Img3` = @Img3" : "`Img3` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (img3 != null)
				paras_.Add(Database.CreateInParameter("@Img3", img3, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_notify_templateEO.MapDataReader);
		}
		public async Task<List<Sa_notify_templateEO>> GetByImg3Async(string img3, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(img3 != null ? "`Img3` = @Img3" : "`Img3` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (img3 != null)
				paras_.Add(Database.CreateInParameter("@Img3", img3, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_notify_templateEO.MapDataReader);
		}
		#endregion // GetByImg3
		#region GetByImg4
		
		/// <summary>
		/// 按 Img4（字段） 查询
		/// </summary>
		/// /// <param name = "img4">图片1</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByImg4(string img4)
		{
			return GetByImg4(img4, 0, string.Empty, null);
		}
		public async Task<List<Sa_notify_templateEO>> GetByImg4Async(string img4)
		{
			return await GetByImg4Async(img4, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Img4（字段） 查询
		/// </summary>
		/// /// <param name = "img4">图片1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByImg4(string img4, TransactionManager tm_)
		{
			return GetByImg4(img4, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_notify_templateEO>> GetByImg4Async(string img4, TransactionManager tm_)
		{
			return await GetByImg4Async(img4, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Img4（字段） 查询
		/// </summary>
		/// /// <param name = "img4">图片1</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByImg4(string img4, int top_)
		{
			return GetByImg4(img4, top_, string.Empty, null);
		}
		public async Task<List<Sa_notify_templateEO>> GetByImg4Async(string img4, int top_)
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
		public List<Sa_notify_templateEO> GetByImg4(string img4, int top_, TransactionManager tm_)
		{
			return GetByImg4(img4, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_notify_templateEO>> GetByImg4Async(string img4, int top_, TransactionManager tm_)
		{
			return await GetByImg4Async(img4, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Img4（字段） 查询
		/// </summary>
		/// /// <param name = "img4">图片1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByImg4(string img4, string sort_)
		{
			return GetByImg4(img4, 0, sort_, null);
		}
		public async Task<List<Sa_notify_templateEO>> GetByImg4Async(string img4, string sort_)
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
		public List<Sa_notify_templateEO> GetByImg4(string img4, string sort_, TransactionManager tm_)
		{
			return GetByImg4(img4, 0, sort_, tm_);
		}
		public async Task<List<Sa_notify_templateEO>> GetByImg4Async(string img4, string sort_, TransactionManager tm_)
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
		public List<Sa_notify_templateEO> GetByImg4(string img4, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(img4 != null ? "`Img4` = @Img4" : "`Img4` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (img4 != null)
				paras_.Add(Database.CreateInParameter("@Img4", img4, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_notify_templateEO.MapDataReader);
		}
		public async Task<List<Sa_notify_templateEO>> GetByImg4Async(string img4, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(img4 != null ? "`Img4` = @Img4" : "`Img4` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (img4 != null)
				paras_.Add(Database.CreateInParameter("@Img4", img4, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_notify_templateEO.MapDataReader);
		}
		#endregion // GetByImg4
		#region GetByImg5
		
		/// <summary>
		/// 按 Img5（字段） 查询
		/// </summary>
		/// /// <param name = "img5">图片1</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByImg5(string img5)
		{
			return GetByImg5(img5, 0, string.Empty, null);
		}
		public async Task<List<Sa_notify_templateEO>> GetByImg5Async(string img5)
		{
			return await GetByImg5Async(img5, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Img5（字段） 查询
		/// </summary>
		/// /// <param name = "img5">图片1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByImg5(string img5, TransactionManager tm_)
		{
			return GetByImg5(img5, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_notify_templateEO>> GetByImg5Async(string img5, TransactionManager tm_)
		{
			return await GetByImg5Async(img5, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Img5（字段） 查询
		/// </summary>
		/// /// <param name = "img5">图片1</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByImg5(string img5, int top_)
		{
			return GetByImg5(img5, top_, string.Empty, null);
		}
		public async Task<List<Sa_notify_templateEO>> GetByImg5Async(string img5, int top_)
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
		public List<Sa_notify_templateEO> GetByImg5(string img5, int top_, TransactionManager tm_)
		{
			return GetByImg5(img5, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_notify_templateEO>> GetByImg5Async(string img5, int top_, TransactionManager tm_)
		{
			return await GetByImg5Async(img5, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Img5（字段） 查询
		/// </summary>
		/// /// <param name = "img5">图片1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByImg5(string img5, string sort_)
		{
			return GetByImg5(img5, 0, sort_, null);
		}
		public async Task<List<Sa_notify_templateEO>> GetByImg5Async(string img5, string sort_)
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
		public List<Sa_notify_templateEO> GetByImg5(string img5, string sort_, TransactionManager tm_)
		{
			return GetByImg5(img5, 0, sort_, tm_);
		}
		public async Task<List<Sa_notify_templateEO>> GetByImg5Async(string img5, string sort_, TransactionManager tm_)
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
		public List<Sa_notify_templateEO> GetByImg5(string img5, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(img5 != null ? "`Img5` = @Img5" : "`Img5` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (img5 != null)
				paras_.Add(Database.CreateInParameter("@Img5", img5, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_notify_templateEO.MapDataReader);
		}
		public async Task<List<Sa_notify_templateEO>> GetByImg5Async(string img5, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(img5 != null ? "`Img5` = @Img5" : "`Img5` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (img5 != null)
				paras_.Add(Database.CreateInParameter("@Img5", img5, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_notify_templateEO.MapDataReader);
		}
		#endregion // GetByImg5
		#region GetByMode
		
		/// <summary>
		/// 按 Mode（字段） 查询
		/// </summary>
		/// /// <param name = "mode">类型:0-位置1-图片2-html3-文字</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByMode(int? mode)
		{
			return GetByMode(mode, 0, string.Empty, null);
		}
		public async Task<List<Sa_notify_templateEO>> GetByModeAsync(int? mode)
		{
			return await GetByModeAsync(mode, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Mode（字段） 查询
		/// </summary>
		/// /// <param name = "mode">类型:0-位置1-图片2-html3-文字</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByMode(int? mode, TransactionManager tm_)
		{
			return GetByMode(mode, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_notify_templateEO>> GetByModeAsync(int? mode, TransactionManager tm_)
		{
			return await GetByModeAsync(mode, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Mode（字段） 查询
		/// </summary>
		/// /// <param name = "mode">类型:0-位置1-图片2-html3-文字</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByMode(int? mode, int top_)
		{
			return GetByMode(mode, top_, string.Empty, null);
		}
		public async Task<List<Sa_notify_templateEO>> GetByModeAsync(int? mode, int top_)
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
		public List<Sa_notify_templateEO> GetByMode(int? mode, int top_, TransactionManager tm_)
		{
			return GetByMode(mode, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_notify_templateEO>> GetByModeAsync(int? mode, int top_, TransactionManager tm_)
		{
			return await GetByModeAsync(mode, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Mode（字段） 查询
		/// </summary>
		/// /// <param name = "mode">类型:0-位置1-图片2-html3-文字</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByMode(int? mode, string sort_)
		{
			return GetByMode(mode, 0, sort_, null);
		}
		public async Task<List<Sa_notify_templateEO>> GetByModeAsync(int? mode, string sort_)
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
		public List<Sa_notify_templateEO> GetByMode(int? mode, string sort_, TransactionManager tm_)
		{
			return GetByMode(mode, 0, sort_, tm_);
		}
		public async Task<List<Sa_notify_templateEO>> GetByModeAsync(int? mode, string sort_, TransactionManager tm_)
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
		public List<Sa_notify_templateEO> GetByMode(int? mode, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(mode.HasValue ? "`Mode` = @Mode" : "`Mode` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (mode.HasValue)
				paras_.Add(Database.CreateInParameter("@Mode", mode.Value, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_notify_templateEO.MapDataReader);
		}
		public async Task<List<Sa_notify_templateEO>> GetByModeAsync(int? mode, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(mode.HasValue ? "`Mode` = @Mode" : "`Mode` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (mode.HasValue)
				paras_.Add(Database.CreateInParameter("@Mode", mode.Value, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_notify_templateEO.MapDataReader);
		}
		#endregion // GetByMode
		#region GetByContent
		
		/// <summary>
		/// 按 Content（字段） 查询
		/// </summary>
		/// /// <param name = "content">消息内容</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByContent(string content)
		{
			return GetByContent(content, 0, string.Empty, null);
		}
		public async Task<List<Sa_notify_templateEO>> GetByContentAsync(string content)
		{
			return await GetByContentAsync(content, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Content（字段） 查询
		/// </summary>
		/// /// <param name = "content">消息内容</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByContent(string content, TransactionManager tm_)
		{
			return GetByContent(content, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_notify_templateEO>> GetByContentAsync(string content, TransactionManager tm_)
		{
			return await GetByContentAsync(content, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Content（字段） 查询
		/// </summary>
		/// /// <param name = "content">消息内容</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByContent(string content, int top_)
		{
			return GetByContent(content, top_, string.Empty, null);
		}
		public async Task<List<Sa_notify_templateEO>> GetByContentAsync(string content, int top_)
		{
			return await GetByContentAsync(content, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Content（字段） 查询
		/// </summary>
		/// /// <param name = "content">消息内容</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByContent(string content, int top_, TransactionManager tm_)
		{
			return GetByContent(content, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_notify_templateEO>> GetByContentAsync(string content, int top_, TransactionManager tm_)
		{
			return await GetByContentAsync(content, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Content（字段） 查询
		/// </summary>
		/// /// <param name = "content">消息内容</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByContent(string content, string sort_)
		{
			return GetByContent(content, 0, sort_, null);
		}
		public async Task<List<Sa_notify_templateEO>> GetByContentAsync(string content, string sort_)
		{
			return await GetByContentAsync(content, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Content（字段） 查询
		/// </summary>
		/// /// <param name = "content">消息内容</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByContent(string content, string sort_, TransactionManager tm_)
		{
			return GetByContent(content, 0, sort_, tm_);
		}
		public async Task<List<Sa_notify_templateEO>> GetByContentAsync(string content, string sort_, TransactionManager tm_)
		{
			return await GetByContentAsync(content, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Content（字段） 查询
		/// </summary>
		/// /// <param name = "content">消息内容</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByContent(string content, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(content != null ? "`Content` = @Content" : "`Content` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (content != null)
				paras_.Add(Database.CreateInParameter("@Content", content, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_notify_templateEO.MapDataReader);
		}
		public async Task<List<Sa_notify_templateEO>> GetByContentAsync(string content, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(content != null ? "`Content` = @Content" : "`Content` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (content != null)
				paras_.Add(Database.CreateInParameter("@Content", content, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_notify_templateEO.MapDataReader);
		}
		#endregion // GetByContent
		#region GetByLinkUrl
		
		/// <summary>
		/// 按 LinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "linkUrl">链接地址</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByLinkUrl(string linkUrl)
		{
			return GetByLinkUrl(linkUrl, 0, string.Empty, null);
		}
		public async Task<List<Sa_notify_templateEO>> GetByLinkUrlAsync(string linkUrl)
		{
			return await GetByLinkUrlAsync(linkUrl, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "linkUrl">链接地址</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByLinkUrl(string linkUrl, TransactionManager tm_)
		{
			return GetByLinkUrl(linkUrl, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_notify_templateEO>> GetByLinkUrlAsync(string linkUrl, TransactionManager tm_)
		{
			return await GetByLinkUrlAsync(linkUrl, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "linkUrl">链接地址</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByLinkUrl(string linkUrl, int top_)
		{
			return GetByLinkUrl(linkUrl, top_, string.Empty, null);
		}
		public async Task<List<Sa_notify_templateEO>> GetByLinkUrlAsync(string linkUrl, int top_)
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
		public List<Sa_notify_templateEO> GetByLinkUrl(string linkUrl, int top_, TransactionManager tm_)
		{
			return GetByLinkUrl(linkUrl, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_notify_templateEO>> GetByLinkUrlAsync(string linkUrl, int top_, TransactionManager tm_)
		{
			return await GetByLinkUrlAsync(linkUrl, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "linkUrl">链接地址</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByLinkUrl(string linkUrl, string sort_)
		{
			return GetByLinkUrl(linkUrl, 0, sort_, null);
		}
		public async Task<List<Sa_notify_templateEO>> GetByLinkUrlAsync(string linkUrl, string sort_)
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
		public List<Sa_notify_templateEO> GetByLinkUrl(string linkUrl, string sort_, TransactionManager tm_)
		{
			return GetByLinkUrl(linkUrl, 0, sort_, tm_);
		}
		public async Task<List<Sa_notify_templateEO>> GetByLinkUrlAsync(string linkUrl, string sort_, TransactionManager tm_)
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
		public List<Sa_notify_templateEO> GetByLinkUrl(string linkUrl, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(linkUrl != null ? "`LinkUrl` = @LinkUrl" : "`LinkUrl` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (linkUrl != null)
				paras_.Add(Database.CreateInParameter("@LinkUrl", linkUrl, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_notify_templateEO.MapDataReader);
		}
		public async Task<List<Sa_notify_templateEO>> GetByLinkUrlAsync(string linkUrl, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(linkUrl != null ? "`LinkUrl` = @LinkUrl" : "`LinkUrl` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (linkUrl != null)
				paras_.Add(Database.CreateInParameter("@LinkUrl", linkUrl, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_notify_templateEO.MapDataReader);
		}
		#endregion // GetByLinkUrl
		#region GetByStatus
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">是否启用</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByStatus(bool status)
		{
			return GetByStatus(status, 0, string.Empty, null);
		}
		public async Task<List<Sa_notify_templateEO>> GetByStatusAsync(bool status)
		{
			return await GetByStatusAsync(status, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">是否启用</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByStatus(bool status, TransactionManager tm_)
		{
			return GetByStatus(status, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_notify_templateEO>> GetByStatusAsync(bool status, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">是否启用</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByStatus(bool status, int top_)
		{
			return GetByStatus(status, top_, string.Empty, null);
		}
		public async Task<List<Sa_notify_templateEO>> GetByStatusAsync(bool status, int top_)
		{
			return await GetByStatusAsync(status, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">是否启用</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByStatus(bool status, int top_, TransactionManager tm_)
		{
			return GetByStatus(status, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_notify_templateEO>> GetByStatusAsync(bool status, int top_, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">是否启用</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByStatus(bool status, string sort_)
		{
			return GetByStatus(status, 0, sort_, null);
		}
		public async Task<List<Sa_notify_templateEO>> GetByStatusAsync(bool status, string sort_)
		{
			return await GetByStatusAsync(status, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">是否启用</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByStatus(bool status, string sort_, TransactionManager tm_)
		{
			return GetByStatus(status, 0, sort_, tm_);
		}
		public async Task<List<Sa_notify_templateEO>> GetByStatusAsync(bool status, string sort_, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">是否启用</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_notify_templateEO> GetByStatus(bool status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Byte));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_notify_templateEO.MapDataReader);
		}
		public async Task<List<Sa_notify_templateEO>> GetByStatusAsync(bool status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Byte));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_notify_templateEO.MapDataReader);
		}
		#endregion // GetByStatus
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
