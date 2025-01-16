/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * AiUo代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/AiUo
 * 文档生成时间：2023-10-24 18: 05:10
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
	/// 任务定义表，描述哪些活动可以做为任务以及对应描述配置
	/// 【表 sat_task 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Sat_taskEO : IRowMapper<Sat_taskEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Sat_taskEO()
		{
			this.Frequency = 0;
			this.ActionType = 0;
			this.Status = 0;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private int _originalItemID;
		/// <summary>
		/// 【数据库中的原始主键 ItemID 值的副本，用于主键值更新】
		/// </summary>
		public int OriginalItemID
		{
			get { return _originalItemID; }
			set { HasOriginal = true; _originalItemID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "ItemID", ItemID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 工具编码
		/// 【主键 int】
		/// </summary>
		[DataMember(Order = 1)]
		public int ItemID { get; set; }
		/// <summary>
		/// 任务分类,0-未知 1-充值类 2-下注类
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 2)]
		public int? Category { get; set; }
		/// <summary>
		/// 标签
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 3)]
		public string Tag { get; set; }
		/// <summary>
		/// 频度 0-非循环类 1-每日 2-每周 3-每月
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 4)]
		public int? Frequency { get; set; }
		/// <summary>
		/// 排序（从小到大）
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 5)]
		public int Sequence { get; set; }
		/// <summary>
		/// 链接地址(详细页面)
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 6)]
		public string LinkUrl { get; set; }
		/// <summary>
		/// 领取奖励类型 0-未知 1-本地方法调用 2-跳转连接
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 7)]
		public int ActionType { get; set; }
		/// <summary>
		/// 领取奖励行为,ActionType为本地方法调用时此值为类名/方法名, 为跳转链接时是链接地址
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 8)]
		public string ActionValue { get; set; }
		/// <summary>
		/// 状态(0-无效1-有效)
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 9)]
		public int Status { get; set; }
		/// <summary>
		/// 记录日期
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 10)]
		public DateTime RecDate { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Sat_taskEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Sat_taskEO MapDataReader(IDataReader reader)
		{
		    Sat_taskEO ret = new Sat_taskEO();
			ret.ItemID = reader.ToInt32("ItemID");
			ret.OriginalItemID = ret.ItemID;
			ret.Category = reader.ToInt32N("Category");
			ret.Tag = reader.ToString("Tag");
			ret.Frequency = reader.ToInt32N("Frequency");
			ret.Sequence = reader.ToInt32("Sequence");
			ret.LinkUrl = reader.ToString("LinkUrl");
			ret.ActionType = reader.ToInt32("ActionType");
			ret.ActionValue = reader.ToString("ActionValue");
			ret.Status = reader.ToInt32("Status");
			ret.RecDate = reader.ToDateTime("RecDate");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 任务定义表，描述哪些活动可以做为任务以及对应描述配置
	/// 【表 sat_task 的操作类】
	/// </summary>
	[Obsolete]
	public class Sat_taskMO : MySqlTableMO<Sat_taskEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`sat_task`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Sat_taskMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Sat_taskMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Sat_taskMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Sat_taskEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Sat_taskEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Sat_taskEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`ItemID`, `Category`, `Tag`, `Frequency`, `Sequence`, `LinkUrl`, `ActionType`, `ActionValue`, `Status`, `RecDate`) VALUE (@ItemID, @Category, @Tag, @Frequency, @Sequence, @LinkUrl, @ActionType, @ActionValue, @Status, @RecDate);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", item.ItemID, MySqlDbType.Int32),
				Database.CreateInParameter("@Category", item.Category.HasValue ? item.Category.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@Tag", item.Tag != null ? item.Tag : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Frequency", item.Frequency.HasValue ? item.Frequency.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@Sequence", item.Sequence, MySqlDbType.Int32),
				Database.CreateInParameter("@LinkUrl", item.LinkUrl != null ? item.LinkUrl : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ActionType", item.ActionType, MySqlDbType.Int32),
				Database.CreateInParameter("@ActionValue", item.ActionValue != null ? item.ActionValue : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Status", item.Status, MySqlDbType.Int32),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
			};
		}
		public int AddByBatch(IEnumerable<Sat_taskEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Sat_taskEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sat_taskEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`ItemID`, `Category`, `Tag`, `Frequency`, `Sequence`, `LinkUrl`, `ActionType`, `ActionValue`, `Status`, `RecDate`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"({item.ItemID},{item.Category?.ToString()??null},'{item.Tag}',{item.Frequency?.ToString()??null},{item.Sequence},'{item.LinkUrl}',{item.ActionType},'{item.ActionValue}',{item.Status},'{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
		/// /// <param name = "itemID">工具编码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(int itemID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(itemID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(int itemID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(itemID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(int itemID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `ItemID` = @ItemID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Sat_taskEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.ItemID, tm_);
		}
		public async Task<int> RemoveAsync(Sat_taskEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.ItemID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByCategory
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "category">任务分类,0-未知 1-充值类 2-下注类</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCategory(int? category, TransactionManager tm_ = null)
		{
			RepairRemoveByCategoryData(category.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCategoryAsync(int? category, TransactionManager tm_ = null)
		{
			RepairRemoveByCategoryData(category.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCategoryData(int? category, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (category.HasValue ? "`Category` = @Category" : "`Category` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (category.HasValue)
				paras_.Add(Database.CreateInParameter("@Category", category.Value, MySqlDbType.Int32));
		}
		#endregion // RemoveByCategory
		#region RemoveByTag
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "tag">标签</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTag(string tag, TransactionManager tm_ = null)
		{
			RepairRemoveByTagData(tag, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTagAsync(string tag, TransactionManager tm_ = null)
		{
			RepairRemoveByTagData(tag, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTagData(string tag, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (tag != null ? "`Tag` = @Tag" : "`Tag` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (tag != null)
				paras_.Add(Database.CreateInParameter("@Tag", tag, MySqlDbType.VarChar));
		}
		#endregion // RemoveByTag
		#region RemoveByFrequency
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "frequency">频度 0-非循环类 1-每日 2-每周 3-每月</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByFrequency(int? frequency, TransactionManager tm_ = null)
		{
			RepairRemoveByFrequencyData(frequency.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByFrequencyAsync(int? frequency, TransactionManager tm_ = null)
		{
			RepairRemoveByFrequencyData(frequency.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByFrequencyData(int? frequency, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (frequency.HasValue ? "`Frequency` = @Frequency" : "`Frequency` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (frequency.HasValue)
				paras_.Add(Database.CreateInParameter("@Frequency", frequency.Value, MySqlDbType.Int32));
		}
		#endregion // RemoveByFrequency
		#region RemoveBySequence
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "sequence">排序（从小到大）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveBySequence(int sequence, TransactionManager tm_ = null)
		{
			RepairRemoveBySequenceData(sequence, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveBySequenceAsync(int sequence, TransactionManager tm_ = null)
		{
			RepairRemoveBySequenceData(sequence, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveBySequenceData(int sequence, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Sequence` = @Sequence";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Sequence", sequence, MySqlDbType.Int32));
		}
		#endregion // RemoveBySequence
		#region RemoveByLinkUrl
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "linkUrl">链接地址(详细页面)</param>
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
		#region RemoveByActionType
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "actionType">领取奖励类型 0-未知 1-本地方法调用 2-跳转连接</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByActionType(int actionType, TransactionManager tm_ = null)
		{
			RepairRemoveByActionTypeData(actionType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByActionTypeAsync(int actionType, TransactionManager tm_ = null)
		{
			RepairRemoveByActionTypeData(actionType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByActionTypeData(int actionType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `ActionType` = @ActionType";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ActionType", actionType, MySqlDbType.Int32));
		}
		#endregion // RemoveByActionType
		#region RemoveByActionValue
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "actionValue">领取奖励行为,ActionType为本地方法调用时此值为类名/方法名, 为跳转链接时是链接地址</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByActionValue(string actionValue, TransactionManager tm_ = null)
		{
			RepairRemoveByActionValueData(actionValue, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByActionValueAsync(string actionValue, TransactionManager tm_ = null)
		{
			RepairRemoveByActionValueData(actionValue, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByActionValueData(string actionValue, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (actionValue != null ? "`ActionValue` = @ActionValue" : "`ActionValue` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (actionValue != null)
				paras_.Add(Database.CreateInParameter("@ActionValue", actionValue, MySqlDbType.VarChar));
		}
		#endregion // RemoveByActionValue
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
		#region RemoveByRecDate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "recDate">记录日期</param>
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
		public int Put(Sat_taskEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Sat_taskEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Sat_taskEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ItemID` = @ItemID, `Category` = @Category, `Tag` = @Tag, `Frequency` = @Frequency, `Sequence` = @Sequence, `LinkUrl` = @LinkUrl, `ActionType` = @ActionType, `ActionValue` = @ActionValue, `Status` = @Status, `RecDate` = @RecDate WHERE `ItemID` = @ItemID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", item.ItemID, MySqlDbType.Int32),
				Database.CreateInParameter("@Category", item.Category.HasValue ? item.Category.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@Tag", item.Tag != null ? item.Tag : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Frequency", item.Frequency.HasValue ? item.Frequency.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@Sequence", item.Sequence, MySqlDbType.Int32),
				Database.CreateInParameter("@LinkUrl", item.LinkUrl != null ? item.LinkUrl : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ActionType", item.ActionType, MySqlDbType.Int32),
				Database.CreateInParameter("@ActionValue", item.ActionValue != null ? item.ActionValue : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Status", item.Status, MySqlDbType.Int32),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@ItemID_Original", item.HasOriginal ? item.OriginalItemID : item.ItemID, MySqlDbType.Int32),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Sat_taskEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Sat_taskEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "itemID">工具编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int itemID, string set_, params object[] values_)
		{
			return Put(set_, "`ItemID` = @ItemID", ConcatValues(values_, itemID));
		}
		public async Task<int> PutByPKAsync(int itemID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`ItemID` = @ItemID", ConcatValues(values_, itemID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int itemID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`ItemID` = @ItemID", tm_, ConcatValues(values_, itemID));
		}
		public async Task<int> PutByPKAsync(int itemID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`ItemID` = @ItemID", tm_, ConcatValues(values_, itemID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int itemID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
	        };
			return Put(set_, "`ItemID` = @ItemID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(int itemID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
	        };
			return await PutAsync(set_, "`ItemID` = @ItemID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutCategory
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "category">任务分类,0-未知 1-充值类 2-下注类</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCategoryByPK(int itemID, int? category, TransactionManager tm_ = null)
		{
			RepairPutCategoryByPKData(itemID, category, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCategoryByPKAsync(int itemID, int? category, TransactionManager tm_ = null)
		{
			RepairPutCategoryByPKData(itemID, category, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCategoryByPKData(int itemID, int? category, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Category` = @Category  WHERE `ItemID` = @ItemID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Category", category.HasValue ? category.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "category">任务分类,0-未知 1-充值类 2-下注类</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCategory(int? category, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Category` = @Category";
			var parameter_ = Database.CreateInParameter("@Category", category.HasValue ? category.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCategoryAsync(int? category, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Category` = @Category";
			var parameter_ = Database.CreateInParameter("@Category", category.HasValue ? category.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCategory
		#region PutTag
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "tag">标签</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTagByPK(int itemID, string tag, TransactionManager tm_ = null)
		{
			RepairPutTagByPKData(itemID, tag, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTagByPKAsync(int itemID, string tag, TransactionManager tm_ = null)
		{
			RepairPutTagByPKData(itemID, tag, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTagByPKData(int itemID, string tag, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Tag` = @Tag  WHERE `ItemID` = @ItemID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Tag", tag != null ? tag : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "tag">标签</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTag(string tag, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Tag` = @Tag";
			var parameter_ = Database.CreateInParameter("@Tag", tag != null ? tag : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTagAsync(string tag, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Tag` = @Tag";
			var parameter_ = Database.CreateInParameter("@Tag", tag != null ? tag : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTag
		#region PutFrequency
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "frequency">频度 0-非循环类 1-每日 2-每周 3-每月</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFrequencyByPK(int itemID, int? frequency, TransactionManager tm_ = null)
		{
			RepairPutFrequencyByPKData(itemID, frequency, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFrequencyByPKAsync(int itemID, int? frequency, TransactionManager tm_ = null)
		{
			RepairPutFrequencyByPKData(itemID, frequency, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFrequencyByPKData(int itemID, int? frequency, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Frequency` = @Frequency  WHERE `ItemID` = @ItemID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Frequency", frequency.HasValue ? frequency.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "frequency">频度 0-非循环类 1-每日 2-每周 3-每月</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFrequency(int? frequency, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Frequency` = @Frequency";
			var parameter_ = Database.CreateInParameter("@Frequency", frequency.HasValue ? frequency.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutFrequencyAsync(int? frequency, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Frequency` = @Frequency";
			var parameter_ = Database.CreateInParameter("@Frequency", frequency.HasValue ? frequency.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutFrequency
		#region PutSequence
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "sequence">排序（从小到大）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSequenceByPK(int itemID, int sequence, TransactionManager tm_ = null)
		{
			RepairPutSequenceByPKData(itemID, sequence, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutSequenceByPKAsync(int itemID, int sequence, TransactionManager tm_ = null)
		{
			RepairPutSequenceByPKData(itemID, sequence, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutSequenceByPKData(int itemID, int sequence, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Sequence` = @Sequence  WHERE `ItemID` = @ItemID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Sequence", sequence, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "sequence">排序（从小到大）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSequence(int sequence, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Sequence` = @Sequence";
			var parameter_ = Database.CreateInParameter("@Sequence", sequence, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutSequenceAsync(int sequence, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Sequence` = @Sequence";
			var parameter_ = Database.CreateInParameter("@Sequence", sequence, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutSequence
		#region PutLinkUrl
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "linkUrl">链接地址(详细页面)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLinkUrlByPK(int itemID, string linkUrl, TransactionManager tm_ = null)
		{
			RepairPutLinkUrlByPKData(itemID, linkUrl, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLinkUrlByPKAsync(int itemID, string linkUrl, TransactionManager tm_ = null)
		{
			RepairPutLinkUrlByPKData(itemID, linkUrl, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLinkUrlByPKData(int itemID, string linkUrl, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `LinkUrl` = @LinkUrl  WHERE `ItemID` = @ItemID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LinkUrl", linkUrl != null ? linkUrl : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "linkUrl">链接地址(详细页面)</param>
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
		#region PutActionType
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "actionType">领取奖励类型 0-未知 1-本地方法调用 2-跳转连接</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutActionTypeByPK(int itemID, int actionType, TransactionManager tm_ = null)
		{
			RepairPutActionTypeByPKData(itemID, actionType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutActionTypeByPKAsync(int itemID, int actionType, TransactionManager tm_ = null)
		{
			RepairPutActionTypeByPKData(itemID, actionType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutActionTypeByPKData(int itemID, int actionType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ActionType` = @ActionType  WHERE `ItemID` = @ItemID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ActionType", actionType, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "actionType">领取奖励类型 0-未知 1-本地方法调用 2-跳转连接</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutActionType(int actionType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ActionType` = @ActionType";
			var parameter_ = Database.CreateInParameter("@ActionType", actionType, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutActionTypeAsync(int actionType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ActionType` = @ActionType";
			var parameter_ = Database.CreateInParameter("@ActionType", actionType, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutActionType
		#region PutActionValue
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "actionValue">领取奖励行为,ActionType为本地方法调用时此值为类名/方法名, 为跳转链接时是链接地址</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutActionValueByPK(int itemID, string actionValue, TransactionManager tm_ = null)
		{
			RepairPutActionValueByPKData(itemID, actionValue, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutActionValueByPKAsync(int itemID, string actionValue, TransactionManager tm_ = null)
		{
			RepairPutActionValueByPKData(itemID, actionValue, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutActionValueByPKData(int itemID, string actionValue, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ActionValue` = @ActionValue  WHERE `ItemID` = @ItemID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ActionValue", actionValue != null ? actionValue : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "actionValue">领取奖励行为,ActionType为本地方法调用时此值为类名/方法名, 为跳转链接时是链接地址</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutActionValue(string actionValue, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ActionValue` = @ActionValue";
			var parameter_ = Database.CreateInParameter("@ActionValue", actionValue != null ? actionValue : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutActionValueAsync(string actionValue, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ActionValue` = @ActionValue";
			var parameter_ = Database.CreateInParameter("@ActionValue", actionValue != null ? actionValue : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutActionValue
		#region PutStatus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutStatusByPK(int itemID, int status, TransactionManager tm_ = null)
		{
			RepairPutStatusByPKData(itemID, status, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutStatusByPKAsync(int itemID, int status, TransactionManager tm_ = null)
		{
			RepairPutStatusByPKData(itemID, status, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutStatusByPKData(int itemID, int status, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Status` = @Status  WHERE `ItemID` = @ItemID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Status", status, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
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
		#region PutRecDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "recDate">记录日期</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(int itemID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(itemID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(int itemID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(itemID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(int itemID, DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `ItemID` = @ItemID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "recDate">记录日期</param>
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
		public bool Set(Sat_taskEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.ItemID) == null)
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
		public async Task<bool> SetAsync(Sat_taskEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.ItemID) == null)
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
		/// /// <param name = "itemID">工具编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Sat_taskEO GetByPK(int itemID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(itemID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sat_taskEO.MapDataReader);
		}
		public async Task<Sat_taskEO> GetByPKAsync(int itemID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(itemID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sat_taskEO.MapDataReader);
		}
		private void RepairGetByPKData(int itemID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`ItemID` = @ItemID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 Category（字段）
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int? GetCategoryByPK(int itemID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
			};
			return (int?)GetScalar("`Category`", "`ItemID` = @ItemID", paras_, tm_);
		}
		public async Task<int?> GetCategoryByPKAsync(int itemID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
			};
			return (int?)await GetScalarAsync("`Category`", "`ItemID` = @ItemID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Tag（字段）
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetTagByPK(int itemID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
			};
			return (string)GetScalar("`Tag`", "`ItemID` = @ItemID", paras_, tm_);
		}
		public async Task<string> GetTagByPKAsync(int itemID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
			};
			return (string)await GetScalarAsync("`Tag`", "`ItemID` = @ItemID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Frequency（字段）
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int? GetFrequencyByPK(int itemID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
			};
			return (int?)GetScalar("`Frequency`", "`ItemID` = @ItemID", paras_, tm_);
		}
		public async Task<int?> GetFrequencyByPKAsync(int itemID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
			};
			return (int?)await GetScalarAsync("`Frequency`", "`ItemID` = @ItemID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Sequence（字段）
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetSequenceByPK(int itemID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
			};
			return (int)GetScalar("`Sequence`", "`ItemID` = @ItemID", paras_, tm_);
		}
		public async Task<int> GetSequenceByPKAsync(int itemID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`Sequence`", "`ItemID` = @ItemID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 LinkUrl（字段）
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetLinkUrlByPK(int itemID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
			};
			return (string)GetScalar("`LinkUrl`", "`ItemID` = @ItemID", paras_, tm_);
		}
		public async Task<string> GetLinkUrlByPKAsync(int itemID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
			};
			return (string)await GetScalarAsync("`LinkUrl`", "`ItemID` = @ItemID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ActionType（字段）
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetActionTypeByPK(int itemID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
			};
			return (int)GetScalar("`ActionType`", "`ItemID` = @ItemID", paras_, tm_);
		}
		public async Task<int> GetActionTypeByPKAsync(int itemID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`ActionType`", "`ItemID` = @ItemID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ActionValue（字段）
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetActionValueByPK(int itemID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
			};
			return (string)GetScalar("`ActionValue`", "`ItemID` = @ItemID", paras_, tm_);
		}
		public async Task<string> GetActionValueByPKAsync(int itemID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
			};
			return (string)await GetScalarAsync("`ActionValue`", "`ItemID` = @ItemID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Status（字段）
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetStatusByPK(int itemID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
			};
			return (int)GetScalar("`Status`", "`ItemID` = @ItemID", paras_, tm_);
		}
		public async Task<int> GetStatusByPKAsync(int itemID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`Status`", "`ItemID` = @ItemID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetRecDateByPK(int itemID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
			};
			return (DateTime)GetScalar("`RecDate`", "`ItemID` = @ItemID", paras_, tm_);
		}
		public async Task<DateTime> GetRecDateByPKAsync(int itemID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
			};
			return (DateTime)await GetScalarAsync("`RecDate`", "`ItemID` = @ItemID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByCategory
		
		/// <summary>
		/// 按 Category（字段） 查询
		/// </summary>
		/// /// <param name = "category">任务分类,0-未知 1-充值类 2-下注类</param>
		/// <return>实体对象集合</return>
		public List<Sat_taskEO> GetByCategory(int? category)
		{
			return GetByCategory(category, 0, string.Empty, null);
		}
		public async Task<List<Sat_taskEO>> GetByCategoryAsync(int? category)
		{
			return await GetByCategoryAsync(category, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Category（字段） 查询
		/// </summary>
		/// /// <param name = "category">任务分类,0-未知 1-充值类 2-下注类</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_taskEO> GetByCategory(int? category, TransactionManager tm_)
		{
			return GetByCategory(category, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_taskEO>> GetByCategoryAsync(int? category, TransactionManager tm_)
		{
			return await GetByCategoryAsync(category, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Category（字段） 查询
		/// </summary>
		/// /// <param name = "category">任务分类,0-未知 1-充值类 2-下注类</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_taskEO> GetByCategory(int? category, int top_)
		{
			return GetByCategory(category, top_, string.Empty, null);
		}
		public async Task<List<Sat_taskEO>> GetByCategoryAsync(int? category, int top_)
		{
			return await GetByCategoryAsync(category, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Category（字段） 查询
		/// </summary>
		/// /// <param name = "category">任务分类,0-未知 1-充值类 2-下注类</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_taskEO> GetByCategory(int? category, int top_, TransactionManager tm_)
		{
			return GetByCategory(category, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_taskEO>> GetByCategoryAsync(int? category, int top_, TransactionManager tm_)
		{
			return await GetByCategoryAsync(category, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Category（字段） 查询
		/// </summary>
		/// /// <param name = "category">任务分类,0-未知 1-充值类 2-下注类</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_taskEO> GetByCategory(int? category, string sort_)
		{
			return GetByCategory(category, 0, sort_, null);
		}
		public async Task<List<Sat_taskEO>> GetByCategoryAsync(int? category, string sort_)
		{
			return await GetByCategoryAsync(category, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Category（字段） 查询
		/// </summary>
		/// /// <param name = "category">任务分类,0-未知 1-充值类 2-下注类</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_taskEO> GetByCategory(int? category, string sort_, TransactionManager tm_)
		{
			return GetByCategory(category, 0, sort_, tm_);
		}
		public async Task<List<Sat_taskEO>> GetByCategoryAsync(int? category, string sort_, TransactionManager tm_)
		{
			return await GetByCategoryAsync(category, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Category（字段） 查询
		/// </summary>
		/// /// <param name = "category">任务分类,0-未知 1-充值类 2-下注类</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_taskEO> GetByCategory(int? category, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(category.HasValue ? "`Category` = @Category" : "`Category` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (category.HasValue)
				paras_.Add(Database.CreateInParameter("@Category", category.Value, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_taskEO.MapDataReader);
		}
		public async Task<List<Sat_taskEO>> GetByCategoryAsync(int? category, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(category.HasValue ? "`Category` = @Category" : "`Category` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (category.HasValue)
				paras_.Add(Database.CreateInParameter("@Category", category.Value, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_taskEO.MapDataReader);
		}
		#endregion // GetByCategory
		#region GetByTag
		
		/// <summary>
		/// 按 Tag（字段） 查询
		/// </summary>
		/// /// <param name = "tag">标签</param>
		/// <return>实体对象集合</return>
		public List<Sat_taskEO> GetByTag(string tag)
		{
			return GetByTag(tag, 0, string.Empty, null);
		}
		public async Task<List<Sat_taskEO>> GetByTagAsync(string tag)
		{
			return await GetByTagAsync(tag, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Tag（字段） 查询
		/// </summary>
		/// /// <param name = "tag">标签</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_taskEO> GetByTag(string tag, TransactionManager tm_)
		{
			return GetByTag(tag, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_taskEO>> GetByTagAsync(string tag, TransactionManager tm_)
		{
			return await GetByTagAsync(tag, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Tag（字段） 查询
		/// </summary>
		/// /// <param name = "tag">标签</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_taskEO> GetByTag(string tag, int top_)
		{
			return GetByTag(tag, top_, string.Empty, null);
		}
		public async Task<List<Sat_taskEO>> GetByTagAsync(string tag, int top_)
		{
			return await GetByTagAsync(tag, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Tag（字段） 查询
		/// </summary>
		/// /// <param name = "tag">标签</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_taskEO> GetByTag(string tag, int top_, TransactionManager tm_)
		{
			return GetByTag(tag, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_taskEO>> GetByTagAsync(string tag, int top_, TransactionManager tm_)
		{
			return await GetByTagAsync(tag, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Tag（字段） 查询
		/// </summary>
		/// /// <param name = "tag">标签</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_taskEO> GetByTag(string tag, string sort_)
		{
			return GetByTag(tag, 0, sort_, null);
		}
		public async Task<List<Sat_taskEO>> GetByTagAsync(string tag, string sort_)
		{
			return await GetByTagAsync(tag, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Tag（字段） 查询
		/// </summary>
		/// /// <param name = "tag">标签</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_taskEO> GetByTag(string tag, string sort_, TransactionManager tm_)
		{
			return GetByTag(tag, 0, sort_, tm_);
		}
		public async Task<List<Sat_taskEO>> GetByTagAsync(string tag, string sort_, TransactionManager tm_)
		{
			return await GetByTagAsync(tag, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Tag（字段） 查询
		/// </summary>
		/// /// <param name = "tag">标签</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_taskEO> GetByTag(string tag, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(tag != null ? "`Tag` = @Tag" : "`Tag` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (tag != null)
				paras_.Add(Database.CreateInParameter("@Tag", tag, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_taskEO.MapDataReader);
		}
		public async Task<List<Sat_taskEO>> GetByTagAsync(string tag, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(tag != null ? "`Tag` = @Tag" : "`Tag` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (tag != null)
				paras_.Add(Database.CreateInParameter("@Tag", tag, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_taskEO.MapDataReader);
		}
		#endregion // GetByTag
		#region GetByFrequency
		
		/// <summary>
		/// 按 Frequency（字段） 查询
		/// </summary>
		/// /// <param name = "frequency">频度 0-非循环类 1-每日 2-每周 3-每月</param>
		/// <return>实体对象集合</return>
		public List<Sat_taskEO> GetByFrequency(int? frequency)
		{
			return GetByFrequency(frequency, 0, string.Empty, null);
		}
		public async Task<List<Sat_taskEO>> GetByFrequencyAsync(int? frequency)
		{
			return await GetByFrequencyAsync(frequency, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Frequency（字段） 查询
		/// </summary>
		/// /// <param name = "frequency">频度 0-非循环类 1-每日 2-每周 3-每月</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_taskEO> GetByFrequency(int? frequency, TransactionManager tm_)
		{
			return GetByFrequency(frequency, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_taskEO>> GetByFrequencyAsync(int? frequency, TransactionManager tm_)
		{
			return await GetByFrequencyAsync(frequency, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Frequency（字段） 查询
		/// </summary>
		/// /// <param name = "frequency">频度 0-非循环类 1-每日 2-每周 3-每月</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_taskEO> GetByFrequency(int? frequency, int top_)
		{
			return GetByFrequency(frequency, top_, string.Empty, null);
		}
		public async Task<List<Sat_taskEO>> GetByFrequencyAsync(int? frequency, int top_)
		{
			return await GetByFrequencyAsync(frequency, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Frequency（字段） 查询
		/// </summary>
		/// /// <param name = "frequency">频度 0-非循环类 1-每日 2-每周 3-每月</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_taskEO> GetByFrequency(int? frequency, int top_, TransactionManager tm_)
		{
			return GetByFrequency(frequency, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_taskEO>> GetByFrequencyAsync(int? frequency, int top_, TransactionManager tm_)
		{
			return await GetByFrequencyAsync(frequency, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Frequency（字段） 查询
		/// </summary>
		/// /// <param name = "frequency">频度 0-非循环类 1-每日 2-每周 3-每月</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_taskEO> GetByFrequency(int? frequency, string sort_)
		{
			return GetByFrequency(frequency, 0, sort_, null);
		}
		public async Task<List<Sat_taskEO>> GetByFrequencyAsync(int? frequency, string sort_)
		{
			return await GetByFrequencyAsync(frequency, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Frequency（字段） 查询
		/// </summary>
		/// /// <param name = "frequency">频度 0-非循环类 1-每日 2-每周 3-每月</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_taskEO> GetByFrequency(int? frequency, string sort_, TransactionManager tm_)
		{
			return GetByFrequency(frequency, 0, sort_, tm_);
		}
		public async Task<List<Sat_taskEO>> GetByFrequencyAsync(int? frequency, string sort_, TransactionManager tm_)
		{
			return await GetByFrequencyAsync(frequency, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Frequency（字段） 查询
		/// </summary>
		/// /// <param name = "frequency">频度 0-非循环类 1-每日 2-每周 3-每月</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_taskEO> GetByFrequency(int? frequency, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(frequency.HasValue ? "`Frequency` = @Frequency" : "`Frequency` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (frequency.HasValue)
				paras_.Add(Database.CreateInParameter("@Frequency", frequency.Value, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_taskEO.MapDataReader);
		}
		public async Task<List<Sat_taskEO>> GetByFrequencyAsync(int? frequency, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(frequency.HasValue ? "`Frequency` = @Frequency" : "`Frequency` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (frequency.HasValue)
				paras_.Add(Database.CreateInParameter("@Frequency", frequency.Value, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_taskEO.MapDataReader);
		}
		#endregion // GetByFrequency
		#region GetBySequence
		
		/// <summary>
		/// 按 Sequence（字段） 查询
		/// </summary>
		/// /// <param name = "sequence">排序（从小到大）</param>
		/// <return>实体对象集合</return>
		public List<Sat_taskEO> GetBySequence(int sequence)
		{
			return GetBySequence(sequence, 0, string.Empty, null);
		}
		public async Task<List<Sat_taskEO>> GetBySequenceAsync(int sequence)
		{
			return await GetBySequenceAsync(sequence, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Sequence（字段） 查询
		/// </summary>
		/// /// <param name = "sequence">排序（从小到大）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_taskEO> GetBySequence(int sequence, TransactionManager tm_)
		{
			return GetBySequence(sequence, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_taskEO>> GetBySequenceAsync(int sequence, TransactionManager tm_)
		{
			return await GetBySequenceAsync(sequence, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Sequence（字段） 查询
		/// </summary>
		/// /// <param name = "sequence">排序（从小到大）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_taskEO> GetBySequence(int sequence, int top_)
		{
			return GetBySequence(sequence, top_, string.Empty, null);
		}
		public async Task<List<Sat_taskEO>> GetBySequenceAsync(int sequence, int top_)
		{
			return await GetBySequenceAsync(sequence, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Sequence（字段） 查询
		/// </summary>
		/// /// <param name = "sequence">排序（从小到大）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_taskEO> GetBySequence(int sequence, int top_, TransactionManager tm_)
		{
			return GetBySequence(sequence, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_taskEO>> GetBySequenceAsync(int sequence, int top_, TransactionManager tm_)
		{
			return await GetBySequenceAsync(sequence, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Sequence（字段） 查询
		/// </summary>
		/// /// <param name = "sequence">排序（从小到大）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_taskEO> GetBySequence(int sequence, string sort_)
		{
			return GetBySequence(sequence, 0, sort_, null);
		}
		public async Task<List<Sat_taskEO>> GetBySequenceAsync(int sequence, string sort_)
		{
			return await GetBySequenceAsync(sequence, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Sequence（字段） 查询
		/// </summary>
		/// /// <param name = "sequence">排序（从小到大）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_taskEO> GetBySequence(int sequence, string sort_, TransactionManager tm_)
		{
			return GetBySequence(sequence, 0, sort_, tm_);
		}
		public async Task<List<Sat_taskEO>> GetBySequenceAsync(int sequence, string sort_, TransactionManager tm_)
		{
			return await GetBySequenceAsync(sequence, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Sequence（字段） 查询
		/// </summary>
		/// /// <param name = "sequence">排序（从小到大）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_taskEO> GetBySequence(int sequence, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Sequence` = @Sequence", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Sequence", sequence, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_taskEO.MapDataReader);
		}
		public async Task<List<Sat_taskEO>> GetBySequenceAsync(int sequence, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Sequence` = @Sequence", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Sequence", sequence, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_taskEO.MapDataReader);
		}
		#endregion // GetBySequence
		#region GetByLinkUrl
		
		/// <summary>
		/// 按 LinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "linkUrl">链接地址(详细页面)</param>
		/// <return>实体对象集合</return>
		public List<Sat_taskEO> GetByLinkUrl(string linkUrl)
		{
			return GetByLinkUrl(linkUrl, 0, string.Empty, null);
		}
		public async Task<List<Sat_taskEO>> GetByLinkUrlAsync(string linkUrl)
		{
			return await GetByLinkUrlAsync(linkUrl, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "linkUrl">链接地址(详细页面)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_taskEO> GetByLinkUrl(string linkUrl, TransactionManager tm_)
		{
			return GetByLinkUrl(linkUrl, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_taskEO>> GetByLinkUrlAsync(string linkUrl, TransactionManager tm_)
		{
			return await GetByLinkUrlAsync(linkUrl, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "linkUrl">链接地址(详细页面)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_taskEO> GetByLinkUrl(string linkUrl, int top_)
		{
			return GetByLinkUrl(linkUrl, top_, string.Empty, null);
		}
		public async Task<List<Sat_taskEO>> GetByLinkUrlAsync(string linkUrl, int top_)
		{
			return await GetByLinkUrlAsync(linkUrl, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "linkUrl">链接地址(详细页面)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_taskEO> GetByLinkUrl(string linkUrl, int top_, TransactionManager tm_)
		{
			return GetByLinkUrl(linkUrl, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_taskEO>> GetByLinkUrlAsync(string linkUrl, int top_, TransactionManager tm_)
		{
			return await GetByLinkUrlAsync(linkUrl, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "linkUrl">链接地址(详细页面)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_taskEO> GetByLinkUrl(string linkUrl, string sort_)
		{
			return GetByLinkUrl(linkUrl, 0, sort_, null);
		}
		public async Task<List<Sat_taskEO>> GetByLinkUrlAsync(string linkUrl, string sort_)
		{
			return await GetByLinkUrlAsync(linkUrl, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "linkUrl">链接地址(详细页面)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_taskEO> GetByLinkUrl(string linkUrl, string sort_, TransactionManager tm_)
		{
			return GetByLinkUrl(linkUrl, 0, sort_, tm_);
		}
		public async Task<List<Sat_taskEO>> GetByLinkUrlAsync(string linkUrl, string sort_, TransactionManager tm_)
		{
			return await GetByLinkUrlAsync(linkUrl, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "linkUrl">链接地址(详细页面)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_taskEO> GetByLinkUrl(string linkUrl, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(linkUrl != null ? "`LinkUrl` = @LinkUrl" : "`LinkUrl` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (linkUrl != null)
				paras_.Add(Database.CreateInParameter("@LinkUrl", linkUrl, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_taskEO.MapDataReader);
		}
		public async Task<List<Sat_taskEO>> GetByLinkUrlAsync(string linkUrl, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(linkUrl != null ? "`LinkUrl` = @LinkUrl" : "`LinkUrl` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (linkUrl != null)
				paras_.Add(Database.CreateInParameter("@LinkUrl", linkUrl, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_taskEO.MapDataReader);
		}
		#endregion // GetByLinkUrl
		#region GetByActionType
		
		/// <summary>
		/// 按 ActionType（字段） 查询
		/// </summary>
		/// /// <param name = "actionType">领取奖励类型 0-未知 1-本地方法调用 2-跳转连接</param>
		/// <return>实体对象集合</return>
		public List<Sat_taskEO> GetByActionType(int actionType)
		{
			return GetByActionType(actionType, 0, string.Empty, null);
		}
		public async Task<List<Sat_taskEO>> GetByActionTypeAsync(int actionType)
		{
			return await GetByActionTypeAsync(actionType, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ActionType（字段） 查询
		/// </summary>
		/// /// <param name = "actionType">领取奖励类型 0-未知 1-本地方法调用 2-跳转连接</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_taskEO> GetByActionType(int actionType, TransactionManager tm_)
		{
			return GetByActionType(actionType, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_taskEO>> GetByActionTypeAsync(int actionType, TransactionManager tm_)
		{
			return await GetByActionTypeAsync(actionType, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ActionType（字段） 查询
		/// </summary>
		/// /// <param name = "actionType">领取奖励类型 0-未知 1-本地方法调用 2-跳转连接</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_taskEO> GetByActionType(int actionType, int top_)
		{
			return GetByActionType(actionType, top_, string.Empty, null);
		}
		public async Task<List<Sat_taskEO>> GetByActionTypeAsync(int actionType, int top_)
		{
			return await GetByActionTypeAsync(actionType, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ActionType（字段） 查询
		/// </summary>
		/// /// <param name = "actionType">领取奖励类型 0-未知 1-本地方法调用 2-跳转连接</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_taskEO> GetByActionType(int actionType, int top_, TransactionManager tm_)
		{
			return GetByActionType(actionType, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_taskEO>> GetByActionTypeAsync(int actionType, int top_, TransactionManager tm_)
		{
			return await GetByActionTypeAsync(actionType, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ActionType（字段） 查询
		/// </summary>
		/// /// <param name = "actionType">领取奖励类型 0-未知 1-本地方法调用 2-跳转连接</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_taskEO> GetByActionType(int actionType, string sort_)
		{
			return GetByActionType(actionType, 0, sort_, null);
		}
		public async Task<List<Sat_taskEO>> GetByActionTypeAsync(int actionType, string sort_)
		{
			return await GetByActionTypeAsync(actionType, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ActionType（字段） 查询
		/// </summary>
		/// /// <param name = "actionType">领取奖励类型 0-未知 1-本地方法调用 2-跳转连接</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_taskEO> GetByActionType(int actionType, string sort_, TransactionManager tm_)
		{
			return GetByActionType(actionType, 0, sort_, tm_);
		}
		public async Task<List<Sat_taskEO>> GetByActionTypeAsync(int actionType, string sort_, TransactionManager tm_)
		{
			return await GetByActionTypeAsync(actionType, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ActionType（字段） 查询
		/// </summary>
		/// /// <param name = "actionType">领取奖励类型 0-未知 1-本地方法调用 2-跳转连接</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_taskEO> GetByActionType(int actionType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ActionType` = @ActionType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ActionType", actionType, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_taskEO.MapDataReader);
		}
		public async Task<List<Sat_taskEO>> GetByActionTypeAsync(int actionType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ActionType` = @ActionType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ActionType", actionType, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_taskEO.MapDataReader);
		}
		#endregion // GetByActionType
		#region GetByActionValue
		
		/// <summary>
		/// 按 ActionValue（字段） 查询
		/// </summary>
		/// /// <param name = "actionValue">领取奖励行为,ActionType为本地方法调用时此值为类名/方法名, 为跳转链接时是链接地址</param>
		/// <return>实体对象集合</return>
		public List<Sat_taskEO> GetByActionValue(string actionValue)
		{
			return GetByActionValue(actionValue, 0, string.Empty, null);
		}
		public async Task<List<Sat_taskEO>> GetByActionValueAsync(string actionValue)
		{
			return await GetByActionValueAsync(actionValue, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ActionValue（字段） 查询
		/// </summary>
		/// /// <param name = "actionValue">领取奖励行为,ActionType为本地方法调用时此值为类名/方法名, 为跳转链接时是链接地址</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_taskEO> GetByActionValue(string actionValue, TransactionManager tm_)
		{
			return GetByActionValue(actionValue, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_taskEO>> GetByActionValueAsync(string actionValue, TransactionManager tm_)
		{
			return await GetByActionValueAsync(actionValue, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ActionValue（字段） 查询
		/// </summary>
		/// /// <param name = "actionValue">领取奖励行为,ActionType为本地方法调用时此值为类名/方法名, 为跳转链接时是链接地址</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_taskEO> GetByActionValue(string actionValue, int top_)
		{
			return GetByActionValue(actionValue, top_, string.Empty, null);
		}
		public async Task<List<Sat_taskEO>> GetByActionValueAsync(string actionValue, int top_)
		{
			return await GetByActionValueAsync(actionValue, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ActionValue（字段） 查询
		/// </summary>
		/// /// <param name = "actionValue">领取奖励行为,ActionType为本地方法调用时此值为类名/方法名, 为跳转链接时是链接地址</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_taskEO> GetByActionValue(string actionValue, int top_, TransactionManager tm_)
		{
			return GetByActionValue(actionValue, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_taskEO>> GetByActionValueAsync(string actionValue, int top_, TransactionManager tm_)
		{
			return await GetByActionValueAsync(actionValue, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ActionValue（字段） 查询
		/// </summary>
		/// /// <param name = "actionValue">领取奖励行为,ActionType为本地方法调用时此值为类名/方法名, 为跳转链接时是链接地址</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_taskEO> GetByActionValue(string actionValue, string sort_)
		{
			return GetByActionValue(actionValue, 0, sort_, null);
		}
		public async Task<List<Sat_taskEO>> GetByActionValueAsync(string actionValue, string sort_)
		{
			return await GetByActionValueAsync(actionValue, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ActionValue（字段） 查询
		/// </summary>
		/// /// <param name = "actionValue">领取奖励行为,ActionType为本地方法调用时此值为类名/方法名, 为跳转链接时是链接地址</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_taskEO> GetByActionValue(string actionValue, string sort_, TransactionManager tm_)
		{
			return GetByActionValue(actionValue, 0, sort_, tm_);
		}
		public async Task<List<Sat_taskEO>> GetByActionValueAsync(string actionValue, string sort_, TransactionManager tm_)
		{
			return await GetByActionValueAsync(actionValue, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ActionValue（字段） 查询
		/// </summary>
		/// /// <param name = "actionValue">领取奖励行为,ActionType为本地方法调用时此值为类名/方法名, 为跳转链接时是链接地址</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_taskEO> GetByActionValue(string actionValue, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(actionValue != null ? "`ActionValue` = @ActionValue" : "`ActionValue` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (actionValue != null)
				paras_.Add(Database.CreateInParameter("@ActionValue", actionValue, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_taskEO.MapDataReader);
		}
		public async Task<List<Sat_taskEO>> GetByActionValueAsync(string actionValue, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(actionValue != null ? "`ActionValue` = @ActionValue" : "`ActionValue` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (actionValue != null)
				paras_.Add(Database.CreateInParameter("@ActionValue", actionValue, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_taskEO.MapDataReader);
		}
		#endregion // GetByActionValue
		#region GetByStatus
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <return>实体对象集合</return>
		public List<Sat_taskEO> GetByStatus(int status)
		{
			return GetByStatus(status, 0, string.Empty, null);
		}
		public async Task<List<Sat_taskEO>> GetByStatusAsync(int status)
		{
			return await GetByStatusAsync(status, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_taskEO> GetByStatus(int status, TransactionManager tm_)
		{
			return GetByStatus(status, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_taskEO>> GetByStatusAsync(int status, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_taskEO> GetByStatus(int status, int top_)
		{
			return GetByStatus(status, top_, string.Empty, null);
		}
		public async Task<List<Sat_taskEO>> GetByStatusAsync(int status, int top_)
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
		public List<Sat_taskEO> GetByStatus(int status, int top_, TransactionManager tm_)
		{
			return GetByStatus(status, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_taskEO>> GetByStatusAsync(int status, int top_, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_taskEO> GetByStatus(int status, string sort_)
		{
			return GetByStatus(status, 0, sort_, null);
		}
		public async Task<List<Sat_taskEO>> GetByStatusAsync(int status, string sort_)
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
		public List<Sat_taskEO> GetByStatus(int status, string sort_, TransactionManager tm_)
		{
			return GetByStatus(status, 0, sort_, tm_);
		}
		public async Task<List<Sat_taskEO>> GetByStatusAsync(int status, string sort_, TransactionManager tm_)
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
		public List<Sat_taskEO> GetByStatus(int status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_taskEO.MapDataReader);
		}
		public async Task<List<Sat_taskEO>> GetByStatusAsync(int status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_taskEO.MapDataReader);
		}
		#endregion // GetByStatus
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录日期</param>
		/// <return>实体对象集合</return>
		public List<Sat_taskEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<Sat_taskEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录日期</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_taskEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_taskEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录日期</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_taskEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<Sat_taskEO>> GetByRecDateAsync(DateTime recDate, int top_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录日期</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_taskEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_taskEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录日期</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_taskEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<Sat_taskEO>> GetByRecDateAsync(DateTime recDate, string sort_)
		{
			return await GetByRecDateAsync(recDate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录日期</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_taskEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<Sat_taskEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录日期</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_taskEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_taskEO.MapDataReader);
		}
		public async Task<List<Sat_taskEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_taskEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
