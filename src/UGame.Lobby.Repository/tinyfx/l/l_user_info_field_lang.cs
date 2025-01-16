/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * AiUo代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/AiUo
 * 文档生成时间：2023-10-24 18: 04:51
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
	/// 用户信息字段国家多语言定义
	/// 【表 l_user_info_field_lang 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class L_user_info_field_langEO : IRowMapper<L_user_info_field_langEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public L_user_info_field_langEO()
		{
			this.IsRequired = 0;
			this.IsAllowModify = 0;
			this.OrderNum = 0;
			this.RecDate = DateTime.Now;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private string _originalCountryID;
		/// <summary>
		/// 【数据库中的原始主键 CountryID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalCountryID
		{
			get { return _originalCountryID; }
			set { HasOriginal = true; _originalCountryID = value; }
		}
		
		private string _originalUIFieldID;
		/// <summary>
		/// 【数据库中的原始主键 UIFieldID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalUIFieldID
		{
			get { return _originalUIFieldID; }
			set { HasOriginal = true; _originalUIFieldID = value; }
		}
		
		private string _originalLangID;
		/// <summary>
		/// 【数据库中的原始主键 LangID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalLangID
		{
			get { return _originalLangID; }
			set { HasOriginal = true; _originalLangID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "CountryID", CountryID },  { "UIFieldID", UIFieldID },  { "LangID", LangID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 用户字段主键（如：Username）
		/// 【主键 varchar(50)】
		/// </summary>
		[DataMember(Order = 1)]
		public string UIFieldID { get; set; }
		/// <summary>
		/// 国家编码ISO 3166-1三位字母
		/// 【主键 varchar(5)】
		/// </summary>
		[DataMember(Order = 2)]
		public string CountryID { get; set; }
		/// <summary>
		/// 语言
		/// 【主键 varchar(20)】
		/// </summary>
		[DataMember(Order = 3)]
		public string LangID { get; set; }
		/// <summary>
		/// 菜单显示标题
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 4)]
		public string Title { get; set; }
		/// <summary>
		/// 输入提示
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 5)]
		public string Placeholder { get; set; }
		/// <summary>
		/// 错误提示
		/// 【字段 varchar(100)】
		/// </summary>
		[DataMember(Order = 6)]
		public string ErrorMessage { get; set; }
		/// <summary>
		/// 是否必填
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 7)]
		public int IsRequired { get; set; }
		/// <summary>
		/// 是否允许修改
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 8)]
		public int IsAllowModify { get; set; }
		/// <summary>
		/// 排序，从小到大
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 9)]
		public int OrderNum { get; set; }
		/// <summary>
		/// 数据类型,1-datetime
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 10)]
		public int? DBType { get; set; }
		/// <summary>
		/// 记录时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 11)]
		public DateTime RecDate { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public L_user_info_field_langEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static L_user_info_field_langEO MapDataReader(IDataReader reader)
		{
		    L_user_info_field_langEO ret = new L_user_info_field_langEO();
			ret.UIFieldID = reader.ToString("UIFieldID");
			ret.OriginalUIFieldID = ret.UIFieldID;
			ret.CountryID = reader.ToString("CountryID");
			ret.OriginalCountryID = ret.CountryID;
			ret.LangID = reader.ToString("LangID");
			ret.OriginalLangID = ret.LangID;
			ret.Title = reader.ToString("Title");
			ret.Placeholder = reader.ToString("Placeholder");
			ret.ErrorMessage = reader.ToString("ErrorMessage");
			ret.IsRequired = reader.ToInt32("IsRequired");
			ret.IsAllowModify = reader.ToInt32("IsAllowModify");
			ret.OrderNum = reader.ToInt32("OrderNum");
			ret.DBType = reader.ToInt32N("DBType");
			ret.RecDate = reader.ToDateTime("RecDate");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 用户信息字段国家多语言定义
	/// 【表 l_user_info_field_lang 的操作类】
	/// </summary>
	[Obsolete]
	public class L_user_info_field_langMO : MySqlTableMO<L_user_info_field_langEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`l_user_info_field_lang`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public L_user_info_field_langMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public L_user_info_field_langMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public L_user_info_field_langMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(L_user_info_field_langEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(L_user_info_field_langEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(L_user_info_field_langEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`UIFieldID`, `CountryID`, `LangID`, `Title`, `Placeholder`, `ErrorMessage`, `IsRequired`, `IsAllowModify`, `OrderNum`, `DBType`, `RecDate`) VALUE (@UIFieldID, @CountryID, @LangID, @Title, @Placeholder, @ErrorMessage, @IsRequired, @IsAllowModify, @OrderNum, @DBType, @RecDate);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UIFieldID", item.UIFieldID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", item.CountryID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", item.LangID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Title", item.Title != null ? item.Title : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Placeholder", item.Placeholder != null ? item.Placeholder : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ErrorMessage", item.ErrorMessage != null ? item.ErrorMessage : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@IsRequired", item.IsRequired, MySqlDbType.Int32),
				Database.CreateInParameter("@IsAllowModify", item.IsAllowModify, MySqlDbType.Int32),
				Database.CreateInParameter("@OrderNum", item.OrderNum, MySqlDbType.Int32),
				Database.CreateInParameter("@DBType", item.DBType.HasValue ? item.DBType.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
			};
		}
		public int AddByBatch(IEnumerable<L_user_info_field_langEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<L_user_info_field_langEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<L_user_info_field_langEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`UIFieldID`, `CountryID`, `LangID`, `Title`, `Placeholder`, `ErrorMessage`, `IsRequired`, `IsAllowModify`, `OrderNum`, `DBType`, `RecDate`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.UIFieldID}','{item.CountryID}','{item.LangID}','{item.Title}','{item.Placeholder}','{item.ErrorMessage}',{item.IsRequired},{item.IsAllowModify},{item.OrderNum},{item.DBType?.ToString()??null},'{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// /// <param name = "uIFieldID">用户字段主键（如：Username）</param>
		/// /// <param name = "langID">语言</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string countryID, string uIFieldID, string langID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(countryID, uIFieldID, langID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string countryID, string uIFieldID, string langID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(countryID, uIFieldID, langID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string countryID, string uIFieldID, string langID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `CountryID` = @CountryID AND `UIFieldID` = @UIFieldID AND `LangID` = @LangID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UIFieldID", uIFieldID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(L_user_info_field_langEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.CountryID, item.UIFieldID, item.LangID, tm_);
		}
		public async Task<int> RemoveAsync(L_user_info_field_langEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.CountryID, item.UIFieldID, item.LangID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByUIFieldID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "uIFieldID">用户字段主键（如：Username）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByUIFieldID(string uIFieldID, TransactionManager tm_ = null)
		{
			RepairRemoveByUIFieldIDData(uIFieldID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByUIFieldIDAsync(string uIFieldID, TransactionManager tm_ = null)
		{
			RepairRemoveByUIFieldIDData(uIFieldID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByUIFieldIDData(string uIFieldID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `UIFieldID` = @UIFieldID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UIFieldID", uIFieldID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByUIFieldID
		#region RemoveByCountryID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
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
			sql_ = $"DELETE FROM {TableName} WHERE `CountryID` = @CountryID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByCountryID
		#region RemoveByLangID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "langID">语言</param>
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
		#region RemoveByTitle
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "title">菜单显示标题</param>
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
		#region RemoveByPlaceholder
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "placeholder">输入提示</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPlaceholder(string placeholder, TransactionManager tm_ = null)
		{
			RepairRemoveByPlaceholderData(placeholder, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPlaceholderAsync(string placeholder, TransactionManager tm_ = null)
		{
			RepairRemoveByPlaceholderData(placeholder, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByPlaceholderData(string placeholder, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (placeholder != null ? "`Placeholder` = @Placeholder" : "`Placeholder` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (placeholder != null)
				paras_.Add(Database.CreateInParameter("@Placeholder", placeholder, MySqlDbType.VarChar));
		}
		#endregion // RemoveByPlaceholder
		#region RemoveByErrorMessage
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "errorMessage">错误提示</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByErrorMessage(string errorMessage, TransactionManager tm_ = null)
		{
			RepairRemoveByErrorMessageData(errorMessage, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByErrorMessageAsync(string errorMessage, TransactionManager tm_ = null)
		{
			RepairRemoveByErrorMessageData(errorMessage, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByErrorMessageData(string errorMessage, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (errorMessage != null ? "`ErrorMessage` = @ErrorMessage" : "`ErrorMessage` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (errorMessage != null)
				paras_.Add(Database.CreateInParameter("@ErrorMessage", errorMessage, MySqlDbType.VarChar));
		}
		#endregion // RemoveByErrorMessage
		#region RemoveByIsRequired
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "isRequired">是否必填</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByIsRequired(int isRequired, TransactionManager tm_ = null)
		{
			RepairRemoveByIsRequiredData(isRequired, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByIsRequiredAsync(int isRequired, TransactionManager tm_ = null)
		{
			RepairRemoveByIsRequiredData(isRequired, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByIsRequiredData(int isRequired, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `IsRequired` = @IsRequired";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsRequired", isRequired, MySqlDbType.Int32));
		}
		#endregion // RemoveByIsRequired
		#region RemoveByIsAllowModify
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "isAllowModify">是否允许修改</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByIsAllowModify(int isAllowModify, TransactionManager tm_ = null)
		{
			RepairRemoveByIsAllowModifyData(isAllowModify, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByIsAllowModifyAsync(int isAllowModify, TransactionManager tm_ = null)
		{
			RepairRemoveByIsAllowModifyData(isAllowModify, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByIsAllowModifyData(int isAllowModify, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `IsAllowModify` = @IsAllowModify";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsAllowModify", isAllowModify, MySqlDbType.Int32));
		}
		#endregion // RemoveByIsAllowModify
		#region RemoveByOrderNum
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "orderNum">排序，从小到大</param>
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
		#region RemoveByDBType
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "dBType">数据类型,1-datetime</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByDBType(int? dBType, TransactionManager tm_ = null)
		{
			RepairRemoveByDBTypeData(dBType.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByDBTypeAsync(int? dBType, TransactionManager tm_ = null)
		{
			RepairRemoveByDBTypeData(dBType.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByDBTypeData(int? dBType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (dBType.HasValue ? "`DBType` = @DBType" : "`DBType` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (dBType.HasValue)
				paras_.Add(Database.CreateInParameter("@DBType", dBType.Value, MySqlDbType.Int32));
		}
		#endregion // RemoveByDBType
		#region RemoveByRecDate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
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
		public int Put(L_user_info_field_langEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(L_user_info_field_langEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(L_user_info_field_langEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UIFieldID` = @UIFieldID, `CountryID` = @CountryID, `LangID` = @LangID, `Title` = @Title, `Placeholder` = @Placeholder, `ErrorMessage` = @ErrorMessage, `IsRequired` = @IsRequired, `IsAllowModify` = @IsAllowModify, `OrderNum` = @OrderNum, `DBType` = @DBType WHERE `CountryID` = @CountryID_Original AND `UIFieldID` = @UIFieldID_Original AND `LangID` = @LangID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UIFieldID", item.UIFieldID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", item.CountryID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", item.LangID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Title", item.Title != null ? item.Title : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Placeholder", item.Placeholder != null ? item.Placeholder : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ErrorMessage", item.ErrorMessage != null ? item.ErrorMessage : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@IsRequired", item.IsRequired, MySqlDbType.Int32),
				Database.CreateInParameter("@IsAllowModify", item.IsAllowModify, MySqlDbType.Int32),
				Database.CreateInParameter("@OrderNum", item.OrderNum, MySqlDbType.Int32),
				Database.CreateInParameter("@DBType", item.DBType.HasValue ? item.DBType.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@CountryID_Original", item.HasOriginal ? item.OriginalCountryID : item.CountryID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UIFieldID_Original", item.HasOriginal ? item.OriginalUIFieldID : item.UIFieldID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID_Original", item.HasOriginal ? item.OriginalLangID : item.LangID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<L_user_info_field_langEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<L_user_info_field_langEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// /// <param name = "uIFieldID">用户字段主键（如：Username）</param>
		/// /// <param name = "langID">语言</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string countryID, string uIFieldID, string langID, string set_, params object[] values_)
		{
			return Put(set_, "`CountryID` = @CountryID AND `UIFieldID` = @UIFieldID AND `LangID` = @LangID", ConcatValues(values_, countryID, uIFieldID, langID));
		}
		public async Task<int> PutByPKAsync(string countryID, string uIFieldID, string langID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`CountryID` = @CountryID AND `UIFieldID` = @UIFieldID AND `LangID` = @LangID", ConcatValues(values_, countryID, uIFieldID, langID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// /// <param name = "uIFieldID">用户字段主键（如：Username）</param>
		/// /// <param name = "langID">语言</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string countryID, string uIFieldID, string langID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`CountryID` = @CountryID AND `UIFieldID` = @UIFieldID AND `LangID` = @LangID", tm_, ConcatValues(values_, countryID, uIFieldID, langID));
		}
		public async Task<int> PutByPKAsync(string countryID, string uIFieldID, string langID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`CountryID` = @CountryID AND `UIFieldID` = @UIFieldID AND `LangID` = @LangID", tm_, ConcatValues(values_, countryID, uIFieldID, langID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// /// <param name = "uIFieldID">用户字段主键（如：Username）</param>
		/// /// <param name = "langID">语言</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string countryID, string uIFieldID, string langID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UIFieldID", uIFieldID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`CountryID` = @CountryID AND `UIFieldID` = @UIFieldID AND `LangID` = @LangID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string countryID, string uIFieldID, string langID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UIFieldID", uIFieldID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`CountryID` = @CountryID AND `UIFieldID` = @UIFieldID AND `LangID` = @LangID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutUIFieldID
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "uIFieldID">用户字段主键（如：Username）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUIFieldID(string uIFieldID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UIFieldID` = @UIFieldID";
			var parameter_ = Database.CreateInParameter("@UIFieldID", uIFieldID, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutUIFieldIDAsync(string uIFieldID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UIFieldID` = @UIFieldID";
			var parameter_ = Database.CreateInParameter("@UIFieldID", uIFieldID, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutUIFieldID
		#region PutCountryID
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCountryID(string countryID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CountryID` = @CountryID";
			var parameter_ = Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCountryIDAsync(string countryID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CountryID` = @CountryID";
			var parameter_ = Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCountryID
		#region PutLangID
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "langID">语言</param>
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
		#region PutTitle
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// /// <param name = "uIFieldID">用户字段主键（如：Username）</param>
		/// /// <param name = "langID">语言</param>
		/// /// <param name = "title">菜单显示标题</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTitleByPK(string countryID, string uIFieldID, string langID, string title, TransactionManager tm_ = null)
		{
			RepairPutTitleByPKData(countryID, uIFieldID, langID, title, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTitleByPKAsync(string countryID, string uIFieldID, string langID, string title, TransactionManager tm_ = null)
		{
			RepairPutTitleByPKData(countryID, uIFieldID, langID, title, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTitleByPKData(string countryID, string uIFieldID, string langID, string title, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Title` = @Title  WHERE `CountryID` = @CountryID AND `UIFieldID` = @UIFieldID AND `LangID` = @LangID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Title", title != null ? title : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UIFieldID", uIFieldID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "title">菜单显示标题</param>
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
		#region PutPlaceholder
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// /// <param name = "uIFieldID">用户字段主键（如：Username）</param>
		/// /// <param name = "langID">语言</param>
		/// /// <param name = "placeholder">输入提示</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPlaceholderByPK(string countryID, string uIFieldID, string langID, string placeholder, TransactionManager tm_ = null)
		{
			RepairPutPlaceholderByPKData(countryID, uIFieldID, langID, placeholder, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutPlaceholderByPKAsync(string countryID, string uIFieldID, string langID, string placeholder, TransactionManager tm_ = null)
		{
			RepairPutPlaceholderByPKData(countryID, uIFieldID, langID, placeholder, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutPlaceholderByPKData(string countryID, string uIFieldID, string langID, string placeholder, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Placeholder` = @Placeholder  WHERE `CountryID` = @CountryID AND `UIFieldID` = @UIFieldID AND `LangID` = @LangID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Placeholder", placeholder != null ? placeholder : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UIFieldID", uIFieldID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "placeholder">输入提示</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPlaceholder(string placeholder, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Placeholder` = @Placeholder";
			var parameter_ = Database.CreateInParameter("@Placeholder", placeholder != null ? placeholder : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutPlaceholderAsync(string placeholder, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Placeholder` = @Placeholder";
			var parameter_ = Database.CreateInParameter("@Placeholder", placeholder != null ? placeholder : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutPlaceholder
		#region PutErrorMessage
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// /// <param name = "uIFieldID">用户字段主键（如：Username）</param>
		/// /// <param name = "langID">语言</param>
		/// /// <param name = "errorMessage">错误提示</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutErrorMessageByPK(string countryID, string uIFieldID, string langID, string errorMessage, TransactionManager tm_ = null)
		{
			RepairPutErrorMessageByPKData(countryID, uIFieldID, langID, errorMessage, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutErrorMessageByPKAsync(string countryID, string uIFieldID, string langID, string errorMessage, TransactionManager tm_ = null)
		{
			RepairPutErrorMessageByPKData(countryID, uIFieldID, langID, errorMessage, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutErrorMessageByPKData(string countryID, string uIFieldID, string langID, string errorMessage, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ErrorMessage` = @ErrorMessage  WHERE `CountryID` = @CountryID AND `UIFieldID` = @UIFieldID AND `LangID` = @LangID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ErrorMessage", errorMessage != null ? errorMessage : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UIFieldID", uIFieldID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "errorMessage">错误提示</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutErrorMessage(string errorMessage, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ErrorMessage` = @ErrorMessage";
			var parameter_ = Database.CreateInParameter("@ErrorMessage", errorMessage != null ? errorMessage : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutErrorMessageAsync(string errorMessage, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ErrorMessage` = @ErrorMessage";
			var parameter_ = Database.CreateInParameter("@ErrorMessage", errorMessage != null ? errorMessage : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutErrorMessage
		#region PutIsRequired
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// /// <param name = "uIFieldID">用户字段主键（如：Username）</param>
		/// /// <param name = "langID">语言</param>
		/// /// <param name = "isRequired">是否必填</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsRequiredByPK(string countryID, string uIFieldID, string langID, int isRequired, TransactionManager tm_ = null)
		{
			RepairPutIsRequiredByPKData(countryID, uIFieldID, langID, isRequired, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutIsRequiredByPKAsync(string countryID, string uIFieldID, string langID, int isRequired, TransactionManager tm_ = null)
		{
			RepairPutIsRequiredByPKData(countryID, uIFieldID, langID, isRequired, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutIsRequiredByPKData(string countryID, string uIFieldID, string langID, int isRequired, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `IsRequired` = @IsRequired  WHERE `CountryID` = @CountryID AND `UIFieldID` = @UIFieldID AND `LangID` = @LangID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@IsRequired", isRequired, MySqlDbType.Int32),
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UIFieldID", uIFieldID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "isRequired">是否必填</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsRequired(int isRequired, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsRequired` = @IsRequired";
			var parameter_ = Database.CreateInParameter("@IsRequired", isRequired, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutIsRequiredAsync(int isRequired, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsRequired` = @IsRequired";
			var parameter_ = Database.CreateInParameter("@IsRequired", isRequired, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutIsRequired
		#region PutIsAllowModify
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// /// <param name = "uIFieldID">用户字段主键（如：Username）</param>
		/// /// <param name = "langID">语言</param>
		/// /// <param name = "isAllowModify">是否允许修改</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsAllowModifyByPK(string countryID, string uIFieldID, string langID, int isAllowModify, TransactionManager tm_ = null)
		{
			RepairPutIsAllowModifyByPKData(countryID, uIFieldID, langID, isAllowModify, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutIsAllowModifyByPKAsync(string countryID, string uIFieldID, string langID, int isAllowModify, TransactionManager tm_ = null)
		{
			RepairPutIsAllowModifyByPKData(countryID, uIFieldID, langID, isAllowModify, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutIsAllowModifyByPKData(string countryID, string uIFieldID, string langID, int isAllowModify, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `IsAllowModify` = @IsAllowModify  WHERE `CountryID` = @CountryID AND `UIFieldID` = @UIFieldID AND `LangID` = @LangID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@IsAllowModify", isAllowModify, MySqlDbType.Int32),
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UIFieldID", uIFieldID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "isAllowModify">是否允许修改</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsAllowModify(int isAllowModify, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsAllowModify` = @IsAllowModify";
			var parameter_ = Database.CreateInParameter("@IsAllowModify", isAllowModify, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutIsAllowModifyAsync(int isAllowModify, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsAllowModify` = @IsAllowModify";
			var parameter_ = Database.CreateInParameter("@IsAllowModify", isAllowModify, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutIsAllowModify
		#region PutOrderNum
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// /// <param name = "uIFieldID">用户字段主键（如：Username）</param>
		/// /// <param name = "langID">语言</param>
		/// /// <param name = "orderNum">排序，从小到大</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOrderNumByPK(string countryID, string uIFieldID, string langID, int orderNum, TransactionManager tm_ = null)
		{
			RepairPutOrderNumByPKData(countryID, uIFieldID, langID, orderNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOrderNumByPKAsync(string countryID, string uIFieldID, string langID, int orderNum, TransactionManager tm_ = null)
		{
			RepairPutOrderNumByPKData(countryID, uIFieldID, langID, orderNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOrderNumByPKData(string countryID, string uIFieldID, string langID, int orderNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OrderNum` = @OrderNum  WHERE `CountryID` = @CountryID AND `UIFieldID` = @UIFieldID AND `LangID` = @LangID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderNum", orderNum, MySqlDbType.Int32),
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UIFieldID", uIFieldID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "orderNum">排序，从小到大</param>
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
		#region PutDBType
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// /// <param name = "uIFieldID">用户字段主键（如：Username）</param>
		/// /// <param name = "langID">语言</param>
		/// /// <param name = "dBType">数据类型,1-datetime</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutDBTypeByPK(string countryID, string uIFieldID, string langID, int? dBType, TransactionManager tm_ = null)
		{
			RepairPutDBTypeByPKData(countryID, uIFieldID, langID, dBType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutDBTypeByPKAsync(string countryID, string uIFieldID, string langID, int? dBType, TransactionManager tm_ = null)
		{
			RepairPutDBTypeByPKData(countryID, uIFieldID, langID, dBType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutDBTypeByPKData(string countryID, string uIFieldID, string langID, int? dBType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `DBType` = @DBType  WHERE `CountryID` = @CountryID AND `UIFieldID` = @UIFieldID AND `LangID` = @LangID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DBType", dBType.HasValue ? dBType.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UIFieldID", uIFieldID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "dBType">数据类型,1-datetime</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutDBType(int? dBType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `DBType` = @DBType";
			var parameter_ = Database.CreateInParameter("@DBType", dBType.HasValue ? dBType.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutDBTypeAsync(int? dBType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `DBType` = @DBType";
			var parameter_ = Database.CreateInParameter("@DBType", dBType.HasValue ? dBType.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutDBType
		#region PutRecDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// /// <param name = "uIFieldID">用户字段主键（如：Username）</param>
		/// /// <param name = "langID">语言</param>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(string countryID, string uIFieldID, string langID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(countryID, uIFieldID, langID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(string countryID, string uIFieldID, string langID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(countryID, uIFieldID, langID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(string countryID, string uIFieldID, string langID, DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `CountryID` = @CountryID AND `UIFieldID` = @UIFieldID AND `LangID` = @LangID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UIFieldID", uIFieldID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
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
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(L_user_info_field_langEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.CountryID, item.UIFieldID, item.LangID) == null)
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
		public async Task<bool> SetAsync(L_user_info_field_langEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.CountryID, item.UIFieldID, item.LangID) == null)
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
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// /// <param name = "uIFieldID">用户字段主键（如：Username）</param>
		/// /// <param name = "langID">语言</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public L_user_info_field_langEO GetByPK(string countryID, string uIFieldID, string langID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(countryID, uIFieldID, langID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, L_user_info_field_langEO.MapDataReader);
		}
		public async Task<L_user_info_field_langEO> GetByPKAsync(string countryID, string uIFieldID, string langID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(countryID, uIFieldID, langID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, L_user_info_field_langEO.MapDataReader);
		}
		private void RepairGetByPKData(string countryID, string uIFieldID, string langID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`CountryID` = @CountryID AND `UIFieldID` = @UIFieldID AND `LangID` = @LangID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UIFieldID", uIFieldID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 UIFieldID（字段）
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// /// <param name = "uIFieldID">用户字段主键（如：Username）</param>
		/// /// <param name = "langID">语言</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetUIFieldIDByPK(string countryID, string uIFieldID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UIFieldID", uIFieldID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`UIFieldID`", "`CountryID` = @CountryID AND `UIFieldID` = @UIFieldID AND `LangID` = @LangID", paras_, tm_);
		}
		public async Task<string> GetUIFieldIDByPKAsync(string countryID, string uIFieldID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UIFieldID", uIFieldID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`UIFieldID`", "`CountryID` = @CountryID AND `UIFieldID` = @UIFieldID AND `LangID` = @LangID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CountryID（字段）
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// /// <param name = "uIFieldID">用户字段主键（如：Username）</param>
		/// /// <param name = "langID">语言</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCountryIDByPK(string countryID, string uIFieldID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UIFieldID", uIFieldID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CountryID`", "`CountryID` = @CountryID AND `UIFieldID` = @UIFieldID AND `LangID` = @LangID", paras_, tm_);
		}
		public async Task<string> GetCountryIDByPKAsync(string countryID, string uIFieldID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UIFieldID", uIFieldID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CountryID`", "`CountryID` = @CountryID AND `UIFieldID` = @UIFieldID AND `LangID` = @LangID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 LangID（字段）
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// /// <param name = "uIFieldID">用户字段主键（如：Username）</param>
		/// /// <param name = "langID">语言</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetLangIDByPK(string countryID, string uIFieldID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UIFieldID", uIFieldID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`LangID`", "`CountryID` = @CountryID AND `UIFieldID` = @UIFieldID AND `LangID` = @LangID", paras_, tm_);
		}
		public async Task<string> GetLangIDByPKAsync(string countryID, string uIFieldID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UIFieldID", uIFieldID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`LangID`", "`CountryID` = @CountryID AND `UIFieldID` = @UIFieldID AND `LangID` = @LangID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Title（字段）
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// /// <param name = "uIFieldID">用户字段主键（如：Username）</param>
		/// /// <param name = "langID">语言</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetTitleByPK(string countryID, string uIFieldID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UIFieldID", uIFieldID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Title`", "`CountryID` = @CountryID AND `UIFieldID` = @UIFieldID AND `LangID` = @LangID", paras_, tm_);
		}
		public async Task<string> GetTitleByPKAsync(string countryID, string uIFieldID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UIFieldID", uIFieldID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Title`", "`CountryID` = @CountryID AND `UIFieldID` = @UIFieldID AND `LangID` = @LangID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Placeholder（字段）
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// /// <param name = "uIFieldID">用户字段主键（如：Username）</param>
		/// /// <param name = "langID">语言</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetPlaceholderByPK(string countryID, string uIFieldID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UIFieldID", uIFieldID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Placeholder`", "`CountryID` = @CountryID AND `UIFieldID` = @UIFieldID AND `LangID` = @LangID", paras_, tm_);
		}
		public async Task<string> GetPlaceholderByPKAsync(string countryID, string uIFieldID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UIFieldID", uIFieldID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Placeholder`", "`CountryID` = @CountryID AND `UIFieldID` = @UIFieldID AND `LangID` = @LangID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ErrorMessage（字段）
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// /// <param name = "uIFieldID">用户字段主键（如：Username）</param>
		/// /// <param name = "langID">语言</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetErrorMessageByPK(string countryID, string uIFieldID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UIFieldID", uIFieldID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`ErrorMessage`", "`CountryID` = @CountryID AND `UIFieldID` = @UIFieldID AND `LangID` = @LangID", paras_, tm_);
		}
		public async Task<string> GetErrorMessageByPKAsync(string countryID, string uIFieldID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UIFieldID", uIFieldID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`ErrorMessage`", "`CountryID` = @CountryID AND `UIFieldID` = @UIFieldID AND `LangID` = @LangID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 IsRequired（字段）
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// /// <param name = "uIFieldID">用户字段主键（如：Username）</param>
		/// /// <param name = "langID">语言</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetIsRequiredByPK(string countryID, string uIFieldID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UIFieldID", uIFieldID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`IsRequired`", "`CountryID` = @CountryID AND `UIFieldID` = @UIFieldID AND `LangID` = @LangID", paras_, tm_);
		}
		public async Task<int> GetIsRequiredByPKAsync(string countryID, string uIFieldID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UIFieldID", uIFieldID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`IsRequired`", "`CountryID` = @CountryID AND `UIFieldID` = @UIFieldID AND `LangID` = @LangID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 IsAllowModify（字段）
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// /// <param name = "uIFieldID">用户字段主键（如：Username）</param>
		/// /// <param name = "langID">语言</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetIsAllowModifyByPK(string countryID, string uIFieldID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UIFieldID", uIFieldID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`IsAllowModify`", "`CountryID` = @CountryID AND `UIFieldID` = @UIFieldID AND `LangID` = @LangID", paras_, tm_);
		}
		public async Task<int> GetIsAllowModifyByPKAsync(string countryID, string uIFieldID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UIFieldID", uIFieldID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`IsAllowModify`", "`CountryID` = @CountryID AND `UIFieldID` = @UIFieldID AND `LangID` = @LangID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OrderNum（字段）
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// /// <param name = "uIFieldID">用户字段主键（如：Username）</param>
		/// /// <param name = "langID">语言</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetOrderNumByPK(string countryID, string uIFieldID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UIFieldID", uIFieldID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`OrderNum`", "`CountryID` = @CountryID AND `UIFieldID` = @UIFieldID AND `LangID` = @LangID", paras_, tm_);
		}
		public async Task<int> GetOrderNumByPKAsync(string countryID, string uIFieldID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UIFieldID", uIFieldID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`OrderNum`", "`CountryID` = @CountryID AND `UIFieldID` = @UIFieldID AND `LangID` = @LangID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 DBType（字段）
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// /// <param name = "uIFieldID">用户字段主键（如：Username）</param>
		/// /// <param name = "langID">语言</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int? GetDBTypeByPK(string countryID, string uIFieldID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UIFieldID", uIFieldID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (int?)GetScalar("`DBType`", "`CountryID` = @CountryID AND `UIFieldID` = @UIFieldID AND `LangID` = @LangID", paras_, tm_);
		}
		public async Task<int?> GetDBTypeByPKAsync(string countryID, string uIFieldID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UIFieldID", uIFieldID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (int?)await GetScalarAsync("`DBType`", "`CountryID` = @CountryID AND `UIFieldID` = @UIFieldID AND `LangID` = @LangID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// /// <param name = "uIFieldID">用户字段主键（如：Username）</param>
		/// /// <param name = "langID">语言</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetRecDateByPK(string countryID, string uIFieldID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UIFieldID", uIFieldID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`RecDate`", "`CountryID` = @CountryID AND `UIFieldID` = @UIFieldID AND `LangID` = @LangID", paras_, tm_);
		}
		public async Task<DateTime> GetRecDateByPKAsync(string countryID, string uIFieldID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UIFieldID", uIFieldID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`RecDate`", "`CountryID` = @CountryID AND `UIFieldID` = @UIFieldID AND `LangID` = @LangID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByUIFieldID
		
		/// <summary>
		/// 按 UIFieldID（字段） 查询
		/// </summary>
		/// /// <param name = "uIFieldID">用户字段主键（如：Username）</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByUIFieldID(string uIFieldID)
		{
			return GetByUIFieldID(uIFieldID, 0, string.Empty, null);
		}
		public async Task<List<L_user_info_field_langEO>> GetByUIFieldIDAsync(string uIFieldID)
		{
			return await GetByUIFieldIDAsync(uIFieldID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UIFieldID（字段） 查询
		/// </summary>
		/// /// <param name = "uIFieldID">用户字段主键（如：Username）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByUIFieldID(string uIFieldID, TransactionManager tm_)
		{
			return GetByUIFieldID(uIFieldID, 0, string.Empty, tm_);
		}
		public async Task<List<L_user_info_field_langEO>> GetByUIFieldIDAsync(string uIFieldID, TransactionManager tm_)
		{
			return await GetByUIFieldIDAsync(uIFieldID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UIFieldID（字段） 查询
		/// </summary>
		/// /// <param name = "uIFieldID">用户字段主键（如：Username）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByUIFieldID(string uIFieldID, int top_)
		{
			return GetByUIFieldID(uIFieldID, top_, string.Empty, null);
		}
		public async Task<List<L_user_info_field_langEO>> GetByUIFieldIDAsync(string uIFieldID, int top_)
		{
			return await GetByUIFieldIDAsync(uIFieldID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UIFieldID（字段） 查询
		/// </summary>
		/// /// <param name = "uIFieldID">用户字段主键（如：Username）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByUIFieldID(string uIFieldID, int top_, TransactionManager tm_)
		{
			return GetByUIFieldID(uIFieldID, top_, string.Empty, tm_);
		}
		public async Task<List<L_user_info_field_langEO>> GetByUIFieldIDAsync(string uIFieldID, int top_, TransactionManager tm_)
		{
			return await GetByUIFieldIDAsync(uIFieldID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UIFieldID（字段） 查询
		/// </summary>
		/// /// <param name = "uIFieldID">用户字段主键（如：Username）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByUIFieldID(string uIFieldID, string sort_)
		{
			return GetByUIFieldID(uIFieldID, 0, sort_, null);
		}
		public async Task<List<L_user_info_field_langEO>> GetByUIFieldIDAsync(string uIFieldID, string sort_)
		{
			return await GetByUIFieldIDAsync(uIFieldID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 UIFieldID（字段） 查询
		/// </summary>
		/// /// <param name = "uIFieldID">用户字段主键（如：Username）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByUIFieldID(string uIFieldID, string sort_, TransactionManager tm_)
		{
			return GetByUIFieldID(uIFieldID, 0, sort_, tm_);
		}
		public async Task<List<L_user_info_field_langEO>> GetByUIFieldIDAsync(string uIFieldID, string sort_, TransactionManager tm_)
		{
			return await GetByUIFieldIDAsync(uIFieldID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 UIFieldID（字段） 查询
		/// </summary>
		/// /// <param name = "uIFieldID">用户字段主键（如：Username）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByUIFieldID(string uIFieldID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UIFieldID` = @UIFieldID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UIFieldID", uIFieldID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_user_info_field_langEO.MapDataReader);
		}
		public async Task<List<L_user_info_field_langEO>> GetByUIFieldIDAsync(string uIFieldID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UIFieldID` = @UIFieldID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UIFieldID", uIFieldID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_user_info_field_langEO.MapDataReader);
		}
		#endregion // GetByUIFieldID
		#region GetByCountryID
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByCountryID(string countryID)
		{
			return GetByCountryID(countryID, 0, string.Empty, null);
		}
		public async Task<List<L_user_info_field_langEO>> GetByCountryIDAsync(string countryID)
		{
			return await GetByCountryIDAsync(countryID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByCountryID(string countryID, TransactionManager tm_)
		{
			return GetByCountryID(countryID, 0, string.Empty, tm_);
		}
		public async Task<List<L_user_info_field_langEO>> GetByCountryIDAsync(string countryID, TransactionManager tm_)
		{
			return await GetByCountryIDAsync(countryID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByCountryID(string countryID, int top_)
		{
			return GetByCountryID(countryID, top_, string.Empty, null);
		}
		public async Task<List<L_user_info_field_langEO>> GetByCountryIDAsync(string countryID, int top_)
		{
			return await GetByCountryIDAsync(countryID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByCountryID(string countryID, int top_, TransactionManager tm_)
		{
			return GetByCountryID(countryID, top_, string.Empty, tm_);
		}
		public async Task<List<L_user_info_field_langEO>> GetByCountryIDAsync(string countryID, int top_, TransactionManager tm_)
		{
			return await GetByCountryIDAsync(countryID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByCountryID(string countryID, string sort_)
		{
			return GetByCountryID(countryID, 0, sort_, null);
		}
		public async Task<List<L_user_info_field_langEO>> GetByCountryIDAsync(string countryID, string sort_)
		{
			return await GetByCountryIDAsync(countryID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByCountryID(string countryID, string sort_, TransactionManager tm_)
		{
			return GetByCountryID(countryID, 0, sort_, tm_);
		}
		public async Task<List<L_user_info_field_langEO>> GetByCountryIDAsync(string countryID, string sort_, TransactionManager tm_)
		{
			return await GetByCountryIDAsync(countryID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByCountryID(string countryID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CountryID` = @CountryID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_user_info_field_langEO.MapDataReader);
		}
		public async Task<List<L_user_info_field_langEO>> GetByCountryIDAsync(string countryID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CountryID` = @CountryID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_user_info_field_langEO.MapDataReader);
		}
		#endregion // GetByCountryID
		#region GetByLangID
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByLangID(string langID)
		{
			return GetByLangID(langID, 0, string.Empty, null);
		}
		public async Task<List<L_user_info_field_langEO>> GetByLangIDAsync(string langID)
		{
			return await GetByLangIDAsync(langID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByLangID(string langID, TransactionManager tm_)
		{
			return GetByLangID(langID, 0, string.Empty, tm_);
		}
		public async Task<List<L_user_info_field_langEO>> GetByLangIDAsync(string langID, TransactionManager tm_)
		{
			return await GetByLangIDAsync(langID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByLangID(string langID, int top_)
		{
			return GetByLangID(langID, top_, string.Empty, null);
		}
		public async Task<List<L_user_info_field_langEO>> GetByLangIDAsync(string langID, int top_)
		{
			return await GetByLangIDAsync(langID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByLangID(string langID, int top_, TransactionManager tm_)
		{
			return GetByLangID(langID, top_, string.Empty, tm_);
		}
		public async Task<List<L_user_info_field_langEO>> GetByLangIDAsync(string langID, int top_, TransactionManager tm_)
		{
			return await GetByLangIDAsync(langID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByLangID(string langID, string sort_)
		{
			return GetByLangID(langID, 0, sort_, null);
		}
		public async Task<List<L_user_info_field_langEO>> GetByLangIDAsync(string langID, string sort_)
		{
			return await GetByLangIDAsync(langID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByLangID(string langID, string sort_, TransactionManager tm_)
		{
			return GetByLangID(langID, 0, sort_, tm_);
		}
		public async Task<List<L_user_info_field_langEO>> GetByLangIDAsync(string langID, string sort_, TransactionManager tm_)
		{
			return await GetByLangIDAsync(langID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByLangID(string langID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LangID` = @LangID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_user_info_field_langEO.MapDataReader);
		}
		public async Task<List<L_user_info_field_langEO>> GetByLangIDAsync(string langID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LangID` = @LangID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_user_info_field_langEO.MapDataReader);
		}
		#endregion // GetByLangID
		#region GetByTitle
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">菜单显示标题</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByTitle(string title)
		{
			return GetByTitle(title, 0, string.Empty, null);
		}
		public async Task<List<L_user_info_field_langEO>> GetByTitleAsync(string title)
		{
			return await GetByTitleAsync(title, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">菜单显示标题</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByTitle(string title, TransactionManager tm_)
		{
			return GetByTitle(title, 0, string.Empty, tm_);
		}
		public async Task<List<L_user_info_field_langEO>> GetByTitleAsync(string title, TransactionManager tm_)
		{
			return await GetByTitleAsync(title, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">菜单显示标题</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByTitle(string title, int top_)
		{
			return GetByTitle(title, top_, string.Empty, null);
		}
		public async Task<List<L_user_info_field_langEO>> GetByTitleAsync(string title, int top_)
		{
			return await GetByTitleAsync(title, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">菜单显示标题</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByTitle(string title, int top_, TransactionManager tm_)
		{
			return GetByTitle(title, top_, string.Empty, tm_);
		}
		public async Task<List<L_user_info_field_langEO>> GetByTitleAsync(string title, int top_, TransactionManager tm_)
		{
			return await GetByTitleAsync(title, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">菜单显示标题</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByTitle(string title, string sort_)
		{
			return GetByTitle(title, 0, sort_, null);
		}
		public async Task<List<L_user_info_field_langEO>> GetByTitleAsync(string title, string sort_)
		{
			return await GetByTitleAsync(title, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">菜单显示标题</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByTitle(string title, string sort_, TransactionManager tm_)
		{
			return GetByTitle(title, 0, sort_, tm_);
		}
		public async Task<List<L_user_info_field_langEO>> GetByTitleAsync(string title, string sort_, TransactionManager tm_)
		{
			return await GetByTitleAsync(title, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">菜单显示标题</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByTitle(string title, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(title != null ? "`Title` = @Title" : "`Title` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (title != null)
				paras_.Add(Database.CreateInParameter("@Title", title, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_user_info_field_langEO.MapDataReader);
		}
		public async Task<List<L_user_info_field_langEO>> GetByTitleAsync(string title, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(title != null ? "`Title` = @Title" : "`Title` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (title != null)
				paras_.Add(Database.CreateInParameter("@Title", title, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_user_info_field_langEO.MapDataReader);
		}
		#endregion // GetByTitle
		#region GetByPlaceholder
		
		/// <summary>
		/// 按 Placeholder（字段） 查询
		/// </summary>
		/// /// <param name = "placeholder">输入提示</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByPlaceholder(string placeholder)
		{
			return GetByPlaceholder(placeholder, 0, string.Empty, null);
		}
		public async Task<List<L_user_info_field_langEO>> GetByPlaceholderAsync(string placeholder)
		{
			return await GetByPlaceholderAsync(placeholder, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Placeholder（字段） 查询
		/// </summary>
		/// /// <param name = "placeholder">输入提示</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByPlaceholder(string placeholder, TransactionManager tm_)
		{
			return GetByPlaceholder(placeholder, 0, string.Empty, tm_);
		}
		public async Task<List<L_user_info_field_langEO>> GetByPlaceholderAsync(string placeholder, TransactionManager tm_)
		{
			return await GetByPlaceholderAsync(placeholder, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Placeholder（字段） 查询
		/// </summary>
		/// /// <param name = "placeholder">输入提示</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByPlaceholder(string placeholder, int top_)
		{
			return GetByPlaceholder(placeholder, top_, string.Empty, null);
		}
		public async Task<List<L_user_info_field_langEO>> GetByPlaceholderAsync(string placeholder, int top_)
		{
			return await GetByPlaceholderAsync(placeholder, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Placeholder（字段） 查询
		/// </summary>
		/// /// <param name = "placeholder">输入提示</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByPlaceholder(string placeholder, int top_, TransactionManager tm_)
		{
			return GetByPlaceholder(placeholder, top_, string.Empty, tm_);
		}
		public async Task<List<L_user_info_field_langEO>> GetByPlaceholderAsync(string placeholder, int top_, TransactionManager tm_)
		{
			return await GetByPlaceholderAsync(placeholder, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Placeholder（字段） 查询
		/// </summary>
		/// /// <param name = "placeholder">输入提示</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByPlaceholder(string placeholder, string sort_)
		{
			return GetByPlaceholder(placeholder, 0, sort_, null);
		}
		public async Task<List<L_user_info_field_langEO>> GetByPlaceholderAsync(string placeholder, string sort_)
		{
			return await GetByPlaceholderAsync(placeholder, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Placeholder（字段） 查询
		/// </summary>
		/// /// <param name = "placeholder">输入提示</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByPlaceholder(string placeholder, string sort_, TransactionManager tm_)
		{
			return GetByPlaceholder(placeholder, 0, sort_, tm_);
		}
		public async Task<List<L_user_info_field_langEO>> GetByPlaceholderAsync(string placeholder, string sort_, TransactionManager tm_)
		{
			return await GetByPlaceholderAsync(placeholder, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Placeholder（字段） 查询
		/// </summary>
		/// /// <param name = "placeholder">输入提示</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByPlaceholder(string placeholder, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(placeholder != null ? "`Placeholder` = @Placeholder" : "`Placeholder` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (placeholder != null)
				paras_.Add(Database.CreateInParameter("@Placeholder", placeholder, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_user_info_field_langEO.MapDataReader);
		}
		public async Task<List<L_user_info_field_langEO>> GetByPlaceholderAsync(string placeholder, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(placeholder != null ? "`Placeholder` = @Placeholder" : "`Placeholder` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (placeholder != null)
				paras_.Add(Database.CreateInParameter("@Placeholder", placeholder, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_user_info_field_langEO.MapDataReader);
		}
		#endregion // GetByPlaceholder
		#region GetByErrorMessage
		
		/// <summary>
		/// 按 ErrorMessage（字段） 查询
		/// </summary>
		/// /// <param name = "errorMessage">错误提示</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByErrorMessage(string errorMessage)
		{
			return GetByErrorMessage(errorMessage, 0, string.Empty, null);
		}
		public async Task<List<L_user_info_field_langEO>> GetByErrorMessageAsync(string errorMessage)
		{
			return await GetByErrorMessageAsync(errorMessage, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ErrorMessage（字段） 查询
		/// </summary>
		/// /// <param name = "errorMessage">错误提示</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByErrorMessage(string errorMessage, TransactionManager tm_)
		{
			return GetByErrorMessage(errorMessage, 0, string.Empty, tm_);
		}
		public async Task<List<L_user_info_field_langEO>> GetByErrorMessageAsync(string errorMessage, TransactionManager tm_)
		{
			return await GetByErrorMessageAsync(errorMessage, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ErrorMessage（字段） 查询
		/// </summary>
		/// /// <param name = "errorMessage">错误提示</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByErrorMessage(string errorMessage, int top_)
		{
			return GetByErrorMessage(errorMessage, top_, string.Empty, null);
		}
		public async Task<List<L_user_info_field_langEO>> GetByErrorMessageAsync(string errorMessage, int top_)
		{
			return await GetByErrorMessageAsync(errorMessage, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ErrorMessage（字段） 查询
		/// </summary>
		/// /// <param name = "errorMessage">错误提示</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByErrorMessage(string errorMessage, int top_, TransactionManager tm_)
		{
			return GetByErrorMessage(errorMessage, top_, string.Empty, tm_);
		}
		public async Task<List<L_user_info_field_langEO>> GetByErrorMessageAsync(string errorMessage, int top_, TransactionManager tm_)
		{
			return await GetByErrorMessageAsync(errorMessage, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ErrorMessage（字段） 查询
		/// </summary>
		/// /// <param name = "errorMessage">错误提示</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByErrorMessage(string errorMessage, string sort_)
		{
			return GetByErrorMessage(errorMessage, 0, sort_, null);
		}
		public async Task<List<L_user_info_field_langEO>> GetByErrorMessageAsync(string errorMessage, string sort_)
		{
			return await GetByErrorMessageAsync(errorMessage, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ErrorMessage（字段） 查询
		/// </summary>
		/// /// <param name = "errorMessage">错误提示</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByErrorMessage(string errorMessage, string sort_, TransactionManager tm_)
		{
			return GetByErrorMessage(errorMessage, 0, sort_, tm_);
		}
		public async Task<List<L_user_info_field_langEO>> GetByErrorMessageAsync(string errorMessage, string sort_, TransactionManager tm_)
		{
			return await GetByErrorMessageAsync(errorMessage, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ErrorMessage（字段） 查询
		/// </summary>
		/// /// <param name = "errorMessage">错误提示</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByErrorMessage(string errorMessage, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(errorMessage != null ? "`ErrorMessage` = @ErrorMessage" : "`ErrorMessage` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (errorMessage != null)
				paras_.Add(Database.CreateInParameter("@ErrorMessage", errorMessage, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_user_info_field_langEO.MapDataReader);
		}
		public async Task<List<L_user_info_field_langEO>> GetByErrorMessageAsync(string errorMessage, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(errorMessage != null ? "`ErrorMessage` = @ErrorMessage" : "`ErrorMessage` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (errorMessage != null)
				paras_.Add(Database.CreateInParameter("@ErrorMessage", errorMessage, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_user_info_field_langEO.MapDataReader);
		}
		#endregion // GetByErrorMessage
		#region GetByIsRequired
		
		/// <summary>
		/// 按 IsRequired（字段） 查询
		/// </summary>
		/// /// <param name = "isRequired">是否必填</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByIsRequired(int isRequired)
		{
			return GetByIsRequired(isRequired, 0, string.Empty, null);
		}
		public async Task<List<L_user_info_field_langEO>> GetByIsRequiredAsync(int isRequired)
		{
			return await GetByIsRequiredAsync(isRequired, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsRequired（字段） 查询
		/// </summary>
		/// /// <param name = "isRequired">是否必填</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByIsRequired(int isRequired, TransactionManager tm_)
		{
			return GetByIsRequired(isRequired, 0, string.Empty, tm_);
		}
		public async Task<List<L_user_info_field_langEO>> GetByIsRequiredAsync(int isRequired, TransactionManager tm_)
		{
			return await GetByIsRequiredAsync(isRequired, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsRequired（字段） 查询
		/// </summary>
		/// /// <param name = "isRequired">是否必填</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByIsRequired(int isRequired, int top_)
		{
			return GetByIsRequired(isRequired, top_, string.Empty, null);
		}
		public async Task<List<L_user_info_field_langEO>> GetByIsRequiredAsync(int isRequired, int top_)
		{
			return await GetByIsRequiredAsync(isRequired, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsRequired（字段） 查询
		/// </summary>
		/// /// <param name = "isRequired">是否必填</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByIsRequired(int isRequired, int top_, TransactionManager tm_)
		{
			return GetByIsRequired(isRequired, top_, string.Empty, tm_);
		}
		public async Task<List<L_user_info_field_langEO>> GetByIsRequiredAsync(int isRequired, int top_, TransactionManager tm_)
		{
			return await GetByIsRequiredAsync(isRequired, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsRequired（字段） 查询
		/// </summary>
		/// /// <param name = "isRequired">是否必填</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByIsRequired(int isRequired, string sort_)
		{
			return GetByIsRequired(isRequired, 0, sort_, null);
		}
		public async Task<List<L_user_info_field_langEO>> GetByIsRequiredAsync(int isRequired, string sort_)
		{
			return await GetByIsRequiredAsync(isRequired, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 IsRequired（字段） 查询
		/// </summary>
		/// /// <param name = "isRequired">是否必填</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByIsRequired(int isRequired, string sort_, TransactionManager tm_)
		{
			return GetByIsRequired(isRequired, 0, sort_, tm_);
		}
		public async Task<List<L_user_info_field_langEO>> GetByIsRequiredAsync(int isRequired, string sort_, TransactionManager tm_)
		{
			return await GetByIsRequiredAsync(isRequired, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 IsRequired（字段） 查询
		/// </summary>
		/// /// <param name = "isRequired">是否必填</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByIsRequired(int isRequired, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsRequired` = @IsRequired", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsRequired", isRequired, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, L_user_info_field_langEO.MapDataReader);
		}
		public async Task<List<L_user_info_field_langEO>> GetByIsRequiredAsync(int isRequired, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsRequired` = @IsRequired", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsRequired", isRequired, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_user_info_field_langEO.MapDataReader);
		}
		#endregion // GetByIsRequired
		#region GetByIsAllowModify
		
		/// <summary>
		/// 按 IsAllowModify（字段） 查询
		/// </summary>
		/// /// <param name = "isAllowModify">是否允许修改</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByIsAllowModify(int isAllowModify)
		{
			return GetByIsAllowModify(isAllowModify, 0, string.Empty, null);
		}
		public async Task<List<L_user_info_field_langEO>> GetByIsAllowModifyAsync(int isAllowModify)
		{
			return await GetByIsAllowModifyAsync(isAllowModify, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsAllowModify（字段） 查询
		/// </summary>
		/// /// <param name = "isAllowModify">是否允许修改</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByIsAllowModify(int isAllowModify, TransactionManager tm_)
		{
			return GetByIsAllowModify(isAllowModify, 0, string.Empty, tm_);
		}
		public async Task<List<L_user_info_field_langEO>> GetByIsAllowModifyAsync(int isAllowModify, TransactionManager tm_)
		{
			return await GetByIsAllowModifyAsync(isAllowModify, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsAllowModify（字段） 查询
		/// </summary>
		/// /// <param name = "isAllowModify">是否允许修改</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByIsAllowModify(int isAllowModify, int top_)
		{
			return GetByIsAllowModify(isAllowModify, top_, string.Empty, null);
		}
		public async Task<List<L_user_info_field_langEO>> GetByIsAllowModifyAsync(int isAllowModify, int top_)
		{
			return await GetByIsAllowModifyAsync(isAllowModify, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsAllowModify（字段） 查询
		/// </summary>
		/// /// <param name = "isAllowModify">是否允许修改</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByIsAllowModify(int isAllowModify, int top_, TransactionManager tm_)
		{
			return GetByIsAllowModify(isAllowModify, top_, string.Empty, tm_);
		}
		public async Task<List<L_user_info_field_langEO>> GetByIsAllowModifyAsync(int isAllowModify, int top_, TransactionManager tm_)
		{
			return await GetByIsAllowModifyAsync(isAllowModify, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsAllowModify（字段） 查询
		/// </summary>
		/// /// <param name = "isAllowModify">是否允许修改</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByIsAllowModify(int isAllowModify, string sort_)
		{
			return GetByIsAllowModify(isAllowModify, 0, sort_, null);
		}
		public async Task<List<L_user_info_field_langEO>> GetByIsAllowModifyAsync(int isAllowModify, string sort_)
		{
			return await GetByIsAllowModifyAsync(isAllowModify, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 IsAllowModify（字段） 查询
		/// </summary>
		/// /// <param name = "isAllowModify">是否允许修改</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByIsAllowModify(int isAllowModify, string sort_, TransactionManager tm_)
		{
			return GetByIsAllowModify(isAllowModify, 0, sort_, tm_);
		}
		public async Task<List<L_user_info_field_langEO>> GetByIsAllowModifyAsync(int isAllowModify, string sort_, TransactionManager tm_)
		{
			return await GetByIsAllowModifyAsync(isAllowModify, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 IsAllowModify（字段） 查询
		/// </summary>
		/// /// <param name = "isAllowModify">是否允许修改</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByIsAllowModify(int isAllowModify, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsAllowModify` = @IsAllowModify", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsAllowModify", isAllowModify, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, L_user_info_field_langEO.MapDataReader);
		}
		public async Task<List<L_user_info_field_langEO>> GetByIsAllowModifyAsync(int isAllowModify, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsAllowModify` = @IsAllowModify", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsAllowModify", isAllowModify, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_user_info_field_langEO.MapDataReader);
		}
		#endregion // GetByIsAllowModify
		#region GetByOrderNum
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序，从小到大</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByOrderNum(int orderNum)
		{
			return GetByOrderNum(orderNum, 0, string.Empty, null);
		}
		public async Task<List<L_user_info_field_langEO>> GetByOrderNumAsync(int orderNum)
		{
			return await GetByOrderNumAsync(orderNum, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序，从小到大</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByOrderNum(int orderNum, TransactionManager tm_)
		{
			return GetByOrderNum(orderNum, 0, string.Empty, tm_);
		}
		public async Task<List<L_user_info_field_langEO>> GetByOrderNumAsync(int orderNum, TransactionManager tm_)
		{
			return await GetByOrderNumAsync(orderNum, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序，从小到大</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByOrderNum(int orderNum, int top_)
		{
			return GetByOrderNum(orderNum, top_, string.Empty, null);
		}
		public async Task<List<L_user_info_field_langEO>> GetByOrderNumAsync(int orderNum, int top_)
		{
			return await GetByOrderNumAsync(orderNum, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序，从小到大</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByOrderNum(int orderNum, int top_, TransactionManager tm_)
		{
			return GetByOrderNum(orderNum, top_, string.Empty, tm_);
		}
		public async Task<List<L_user_info_field_langEO>> GetByOrderNumAsync(int orderNum, int top_, TransactionManager tm_)
		{
			return await GetByOrderNumAsync(orderNum, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序，从小到大</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByOrderNum(int orderNum, string sort_)
		{
			return GetByOrderNum(orderNum, 0, sort_, null);
		}
		public async Task<List<L_user_info_field_langEO>> GetByOrderNumAsync(int orderNum, string sort_)
		{
			return await GetByOrderNumAsync(orderNum, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序，从小到大</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByOrderNum(int orderNum, string sort_, TransactionManager tm_)
		{
			return GetByOrderNum(orderNum, 0, sort_, tm_);
		}
		public async Task<List<L_user_info_field_langEO>> GetByOrderNumAsync(int orderNum, string sort_, TransactionManager tm_)
		{
			return await GetByOrderNumAsync(orderNum, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序，从小到大</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByOrderNum(int orderNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OrderNum` = @OrderNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OrderNum", orderNum, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, L_user_info_field_langEO.MapDataReader);
		}
		public async Task<List<L_user_info_field_langEO>> GetByOrderNumAsync(int orderNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OrderNum` = @OrderNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OrderNum", orderNum, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_user_info_field_langEO.MapDataReader);
		}
		#endregion // GetByOrderNum
		#region GetByDBType
		
		/// <summary>
		/// 按 DBType（字段） 查询
		/// </summary>
		/// /// <param name = "dBType">数据类型,1-datetime</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByDBType(int? dBType)
		{
			return GetByDBType(dBType, 0, string.Empty, null);
		}
		public async Task<List<L_user_info_field_langEO>> GetByDBTypeAsync(int? dBType)
		{
			return await GetByDBTypeAsync(dBType, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DBType（字段） 查询
		/// </summary>
		/// /// <param name = "dBType">数据类型,1-datetime</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByDBType(int? dBType, TransactionManager tm_)
		{
			return GetByDBType(dBType, 0, string.Empty, tm_);
		}
		public async Task<List<L_user_info_field_langEO>> GetByDBTypeAsync(int? dBType, TransactionManager tm_)
		{
			return await GetByDBTypeAsync(dBType, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DBType（字段） 查询
		/// </summary>
		/// /// <param name = "dBType">数据类型,1-datetime</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByDBType(int? dBType, int top_)
		{
			return GetByDBType(dBType, top_, string.Empty, null);
		}
		public async Task<List<L_user_info_field_langEO>> GetByDBTypeAsync(int? dBType, int top_)
		{
			return await GetByDBTypeAsync(dBType, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DBType（字段） 查询
		/// </summary>
		/// /// <param name = "dBType">数据类型,1-datetime</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByDBType(int? dBType, int top_, TransactionManager tm_)
		{
			return GetByDBType(dBType, top_, string.Empty, tm_);
		}
		public async Task<List<L_user_info_field_langEO>> GetByDBTypeAsync(int? dBType, int top_, TransactionManager tm_)
		{
			return await GetByDBTypeAsync(dBType, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DBType（字段） 查询
		/// </summary>
		/// /// <param name = "dBType">数据类型,1-datetime</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByDBType(int? dBType, string sort_)
		{
			return GetByDBType(dBType, 0, sort_, null);
		}
		public async Task<List<L_user_info_field_langEO>> GetByDBTypeAsync(int? dBType, string sort_)
		{
			return await GetByDBTypeAsync(dBType, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DBType（字段） 查询
		/// </summary>
		/// /// <param name = "dBType">数据类型,1-datetime</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByDBType(int? dBType, string sort_, TransactionManager tm_)
		{
			return GetByDBType(dBType, 0, sort_, tm_);
		}
		public async Task<List<L_user_info_field_langEO>> GetByDBTypeAsync(int? dBType, string sort_, TransactionManager tm_)
		{
			return await GetByDBTypeAsync(dBType, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DBType（字段） 查询
		/// </summary>
		/// /// <param name = "dBType">数据类型,1-datetime</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByDBType(int? dBType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(dBType.HasValue ? "`DBType` = @DBType" : "`DBType` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (dBType.HasValue)
				paras_.Add(Database.CreateInParameter("@DBType", dBType.Value, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, L_user_info_field_langEO.MapDataReader);
		}
		public async Task<List<L_user_info_field_langEO>> GetByDBTypeAsync(int? dBType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(dBType.HasValue ? "`DBType` = @DBType" : "`DBType` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (dBType.HasValue)
				paras_.Add(Database.CreateInParameter("@DBType", dBType.Value, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_user_info_field_langEO.MapDataReader);
		}
		#endregion // GetByDBType
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<L_user_info_field_langEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<L_user_info_field_langEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<L_user_info_field_langEO>> GetByRecDateAsync(DateTime recDate, int top_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<L_user_info_field_langEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<L_user_info_field_langEO>> GetByRecDateAsync(DateTime recDate, string sort_)
		{
			return await GetByRecDateAsync(recDate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<L_user_info_field_langEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_user_info_field_langEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, L_user_info_field_langEO.MapDataReader);
		}
		public async Task<List<L_user_info_field_langEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_user_info_field_langEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
