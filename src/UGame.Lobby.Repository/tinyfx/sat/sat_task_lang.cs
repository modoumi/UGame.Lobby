/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * AiUo代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/AiUo
 * 文档生成时间：2023-10-24 18: 05:09
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
	/// 任务列表语言配置表
	/// 【表 sat_task_lang 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Sat_task_langEO : IRowMapper<Sat_task_langEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Sat_task_langEO()
		{
			this.Type = 0;
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
		
		private string _originalLangID;
		/// <summary>
		/// 【数据库中的原始主键 LangID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalLangID
		{
			get { return _originalLangID; }
			set { HasOriginal = true; _originalLangID = value; }
		}
		
		private int _originalType;
		/// <summary>
		/// 【数据库中的原始主键 Type 值的副本，用于主键值更新】
		/// </summary>
		public int OriginalType
		{
			get { return _originalType; }
			set { HasOriginal = true; _originalType = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "ItemID", ItemID },  { "LangID", LangID },  { "Type", Type }, };
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
		/// 语言
		/// 【主键 varchar(20)】
		/// </summary>
		[DataMember(Order = 2)]
		public string LangID { get; set; }
		/// <summary>
		/// 类型 0-未知 1-提示任务 2-完成任务
		/// 【主键 int】
		/// </summary>
		[DataMember(Order = 3)]
		public int Type { get; set; }
		/// <summary>
		/// 标题模板,模板变量 RewardAmount, MaxRewardAmount
		/// 【字段 text】
		/// </summary>
		[DataMember(Order = 4)]
		public string Template { get; set; }
		/// <summary>
		/// 记录日期
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 5)]
		public DateTime? RecDate { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Sat_task_langEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Sat_task_langEO MapDataReader(IDataReader reader)
		{
		    Sat_task_langEO ret = new Sat_task_langEO();
			ret.ItemID = reader.ToInt32("ItemID");
			ret.OriginalItemID = ret.ItemID;
			ret.LangID = reader.ToString("LangID");
			ret.OriginalLangID = ret.LangID;
			ret.Type = reader.ToInt32("Type");
			ret.OriginalType = ret.Type;
			ret.Template = reader.ToString("Template");
			ret.RecDate = reader.ToDateTimeN("RecDate");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 任务列表语言配置表
	/// 【表 sat_task_lang 的操作类】
	/// </summary>
	[Obsolete]
	public class Sat_task_langMO : MySqlTableMO<Sat_task_langEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`sat_task_lang`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Sat_task_langMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Sat_task_langMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Sat_task_langMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Sat_task_langEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Sat_task_langEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Sat_task_langEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`ItemID`, `LangID`, `Type`, `Template`, `RecDate`) VALUE (@ItemID, @LangID, @Type, @Template, @RecDate);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", item.ItemID, MySqlDbType.Int32),
				Database.CreateInParameter("@LangID", item.LangID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Type", item.Type, MySqlDbType.Int32),
				Database.CreateInParameter("@Template", item.Template != null ? item.Template : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@RecDate", item.RecDate.HasValue ? item.RecDate.Value : (object)DBNull.Value, MySqlDbType.DateTime),
			};
		}
		public int AddByBatch(IEnumerable<Sat_task_langEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Sat_task_langEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sat_task_langEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`ItemID`, `LangID`, `Type`, `Template`, `RecDate`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"({item.ItemID},'{item.LangID}',{item.Type},'{item.Template}','{item.RecDate?.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
		/// /// <param name = "langID">语言</param>
		/// /// <param name = "type">类型 0-未知 1-提示任务 2-完成任务</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(int itemID, string langID, int type, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(itemID, langID, type, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(int itemID, string langID, int type, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(itemID, langID, type, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(int itemID, string langID, int type, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `ItemID` = @ItemID AND `LangID` = @LangID AND `Type` = @Type";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Type", type, MySqlDbType.Int32),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Sat_task_langEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.ItemID, item.LangID, item.Type, tm_);
		}
		public async Task<int> RemoveAsync(Sat_task_langEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.ItemID, item.LangID, item.Type, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByItemID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByItemID(int itemID, TransactionManager tm_ = null)
		{
			RepairRemoveByItemIDData(itemID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByItemIDAsync(int itemID, TransactionManager tm_ = null)
		{
			RepairRemoveByItemIDData(itemID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByItemIDData(int itemID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `ItemID` = @ItemID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32));
		}
		#endregion // RemoveByItemID
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
		#region RemoveByType
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "type">类型 0-未知 1-提示任务 2-完成任务</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByType(int type, TransactionManager tm_ = null)
		{
			RepairRemoveByTypeData(type, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTypeAsync(int type, TransactionManager tm_ = null)
		{
			RepairRemoveByTypeData(type, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTypeData(int type, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Type` = @Type";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Type", type, MySqlDbType.Int32));
		}
		#endregion // RemoveByType
		#region RemoveByTemplate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "template">标题模板,模板变量 RewardAmount, MaxRewardAmount</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTemplate(string template, TransactionManager tm_ = null)
		{
			RepairRemoveByTemplateData(template, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTemplateAsync(string template, TransactionManager tm_ = null)
		{
			RepairRemoveByTemplateData(template, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTemplateData(string template, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (template != null ? "`Template` = @Template" : "`Template` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (template != null)
				paras_.Add(Database.CreateInParameter("@Template", template, MySqlDbType.Text));
		}
		#endregion // RemoveByTemplate
		#region RemoveByRecDate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "recDate">记录日期</param>
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
		public int Put(Sat_task_langEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Sat_task_langEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Sat_task_langEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ItemID` = @ItemID, `LangID` = @LangID, `Type` = @Type, `Template` = @Template, `RecDate` = @RecDate WHERE `ItemID` = @ItemID_Original AND `LangID` = @LangID_Original AND `Type` = @Type_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", item.ItemID, MySqlDbType.Int32),
				Database.CreateInParameter("@LangID", item.LangID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Type", item.Type, MySqlDbType.Int32),
				Database.CreateInParameter("@Template", item.Template != null ? item.Template : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@RecDate", item.RecDate.HasValue ? item.RecDate.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@ItemID_Original", item.HasOriginal ? item.OriginalItemID : item.ItemID, MySqlDbType.Int32),
				Database.CreateInParameter("@LangID_Original", item.HasOriginal ? item.OriginalLangID : item.LangID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Type_Original", item.HasOriginal ? item.OriginalType : item.Type, MySqlDbType.Int32),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Sat_task_langEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Sat_task_langEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "langID">语言</param>
		/// /// <param name = "type">类型 0-未知 1-提示任务 2-完成任务</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int itemID, string langID, int type, string set_, params object[] values_)
		{
			return Put(set_, "`ItemID` = @ItemID AND `LangID` = @LangID AND `Type` = @Type", ConcatValues(values_, itemID, langID, type));
		}
		public async Task<int> PutByPKAsync(int itemID, string langID, int type, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`ItemID` = @ItemID AND `LangID` = @LangID AND `Type` = @Type", ConcatValues(values_, itemID, langID, type));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "langID">语言</param>
		/// /// <param name = "type">类型 0-未知 1-提示任务 2-完成任务</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int itemID, string langID, int type, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`ItemID` = @ItemID AND `LangID` = @LangID AND `Type` = @Type", tm_, ConcatValues(values_, itemID, langID, type));
		}
		public async Task<int> PutByPKAsync(int itemID, string langID, int type, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`ItemID` = @ItemID AND `LangID` = @LangID AND `Type` = @Type", tm_, ConcatValues(values_, itemID, langID, type));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "langID">语言</param>
		/// /// <param name = "type">类型 0-未知 1-提示任务 2-完成任务</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int itemID, string langID, int type, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Type", type, MySqlDbType.Int32),
	        };
			return Put(set_, "`ItemID` = @ItemID AND `LangID` = @LangID AND `Type` = @Type", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(int itemID, string langID, int type, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Type", type, MySqlDbType.Int32),
	        };
			return await PutAsync(set_, "`ItemID` = @ItemID AND `LangID` = @LangID AND `Type` = @Type", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutItemID
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutItemID(int itemID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ItemID` = @ItemID";
			var parameter_ = Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutItemIDAsync(int itemID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ItemID` = @ItemID";
			var parameter_ = Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutItemID
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
		#region PutType
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "type">类型 0-未知 1-提示任务 2-完成任务</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutType(int type, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Type` = @Type";
			var parameter_ = Database.CreateInParameter("@Type", type, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTypeAsync(int type, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Type` = @Type";
			var parameter_ = Database.CreateInParameter("@Type", type, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutType
		#region PutTemplate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "langID">语言</param>
		/// /// <param name = "type">类型 0-未知 1-提示任务 2-完成任务</param>
		/// /// <param name = "template">标题模板,模板变量 RewardAmount, MaxRewardAmount</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTemplateByPK(int itemID, string langID, int type, string template, TransactionManager tm_ = null)
		{
			RepairPutTemplateByPKData(itemID, langID, type, template, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTemplateByPKAsync(int itemID, string langID, int type, string template, TransactionManager tm_ = null)
		{
			RepairPutTemplateByPKData(itemID, langID, type, template, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTemplateByPKData(int itemID, string langID, int type, string template, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Template` = @Template  WHERE `ItemID` = @ItemID AND `LangID` = @LangID AND `Type` = @Type";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Template", template != null ? template : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Type", type, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "template">标题模板,模板变量 RewardAmount, MaxRewardAmount</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTemplate(string template, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Template` = @Template";
			var parameter_ = Database.CreateInParameter("@Template", template != null ? template : (object)DBNull.Value, MySqlDbType.Text);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTemplateAsync(string template, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Template` = @Template";
			var parameter_ = Database.CreateInParameter("@Template", template != null ? template : (object)DBNull.Value, MySqlDbType.Text);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTemplate
		#region PutRecDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "langID">语言</param>
		/// /// <param name = "type">类型 0-未知 1-提示任务 2-完成任务</param>
		/// /// <param name = "recDate">记录日期</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(int itemID, string langID, int type, DateTime? recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(itemID, langID, type, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(int itemID, string langID, int type, DateTime? recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(itemID, langID, type, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(int itemID, string langID, int type, DateTime? recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `ItemID` = @ItemID AND `LangID` = @LangID AND `Type` = @Type";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate.HasValue ? recDate.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Type", type, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "recDate">记录日期</param>
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
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Sat_task_langEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.ItemID, item.LangID, item.Type) == null)
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
		public async Task<bool> SetAsync(Sat_task_langEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.ItemID, item.LangID, item.Type) == null)
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
		/// /// <param name = "langID">语言</param>
		/// /// <param name = "type">类型 0-未知 1-提示任务 2-完成任务</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Sat_task_langEO GetByPK(int itemID, string langID, int type, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(itemID, langID, type, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sat_task_langEO.MapDataReader);
		}
		public async Task<Sat_task_langEO> GetByPKAsync(int itemID, string langID, int type, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(itemID, langID, type, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sat_task_langEO.MapDataReader);
		}
		private void RepairGetByPKData(int itemID, string langID, int type, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`ItemID` = @ItemID AND `LangID` = @LangID AND `Type` = @Type", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Type", type, MySqlDbType.Int32),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 ItemID（字段）
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "langID">语言</param>
		/// /// <param name = "type">类型 0-未知 1-提示任务 2-完成任务</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetItemIDByPK(int itemID, string langID, int type, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Type", type, MySqlDbType.Int32),
			};
			return (int)GetScalar("`ItemID`", "`ItemID` = @ItemID AND `LangID` = @LangID AND `Type` = @Type", paras_, tm_);
		}
		public async Task<int> GetItemIDByPKAsync(int itemID, string langID, int type, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Type", type, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`ItemID`", "`ItemID` = @ItemID AND `LangID` = @LangID AND `Type` = @Type", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 LangID（字段）
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "langID">语言</param>
		/// /// <param name = "type">类型 0-未知 1-提示任务 2-完成任务</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetLangIDByPK(int itemID, string langID, int type, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Type", type, MySqlDbType.Int32),
			};
			return (string)GetScalar("`LangID`", "`ItemID` = @ItemID AND `LangID` = @LangID AND `Type` = @Type", paras_, tm_);
		}
		public async Task<string> GetLangIDByPKAsync(int itemID, string langID, int type, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Type", type, MySqlDbType.Int32),
			};
			return (string)await GetScalarAsync("`LangID`", "`ItemID` = @ItemID AND `LangID` = @LangID AND `Type` = @Type", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Type（字段）
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "langID">语言</param>
		/// /// <param name = "type">类型 0-未知 1-提示任务 2-完成任务</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetTypeByPK(int itemID, string langID, int type, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Type", type, MySqlDbType.Int32),
			};
			return (int)GetScalar("`Type`", "`ItemID` = @ItemID AND `LangID` = @LangID AND `Type` = @Type", paras_, tm_);
		}
		public async Task<int> GetTypeByPKAsync(int itemID, string langID, int type, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Type", type, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`Type`", "`ItemID` = @ItemID AND `LangID` = @LangID AND `Type` = @Type", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Template（字段）
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "langID">语言</param>
		/// /// <param name = "type">类型 0-未知 1-提示任务 2-完成任务</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetTemplateByPK(int itemID, string langID, int type, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Type", type, MySqlDbType.Int32),
			};
			return (string)GetScalar("`Template`", "`ItemID` = @ItemID AND `LangID` = @LangID AND `Type` = @Type", paras_, tm_);
		}
		public async Task<string> GetTemplateByPKAsync(int itemID, string langID, int type, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Type", type, MySqlDbType.Int32),
			};
			return (string)await GetScalarAsync("`Template`", "`ItemID` = @ItemID AND `LangID` = @LangID AND `Type` = @Type", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "langID">语言</param>
		/// /// <param name = "type">类型 0-未知 1-提示任务 2-完成任务</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime? GetRecDateByPK(int itemID, string langID, int type, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Type", type, MySqlDbType.Int32),
			};
			return (DateTime?)GetScalar("`RecDate`", "`ItemID` = @ItemID AND `LangID` = @LangID AND `Type` = @Type", paras_, tm_);
		}
		public async Task<DateTime?> GetRecDateByPKAsync(int itemID, string langID, int type, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Type", type, MySqlDbType.Int32),
			};
			return (DateTime?)await GetScalarAsync("`RecDate`", "`ItemID` = @ItemID AND `LangID` = @LangID AND `Type` = @Type", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByItemID
		
		/// <summary>
		/// 按 ItemID（字段） 查询
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_langEO> GetByItemID(int itemID)
		{
			return GetByItemID(itemID, 0, string.Empty, null);
		}
		public async Task<List<Sat_task_langEO>> GetByItemIDAsync(int itemID)
		{
			return await GetByItemIDAsync(itemID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ItemID（字段） 查询
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_langEO> GetByItemID(int itemID, TransactionManager tm_)
		{
			return GetByItemID(itemID, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_task_langEO>> GetByItemIDAsync(int itemID, TransactionManager tm_)
		{
			return await GetByItemIDAsync(itemID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ItemID（字段） 查询
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_langEO> GetByItemID(int itemID, int top_)
		{
			return GetByItemID(itemID, top_, string.Empty, null);
		}
		public async Task<List<Sat_task_langEO>> GetByItemIDAsync(int itemID, int top_)
		{
			return await GetByItemIDAsync(itemID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ItemID（字段） 查询
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_langEO> GetByItemID(int itemID, int top_, TransactionManager tm_)
		{
			return GetByItemID(itemID, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_task_langEO>> GetByItemIDAsync(int itemID, int top_, TransactionManager tm_)
		{
			return await GetByItemIDAsync(itemID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ItemID（字段） 查询
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_langEO> GetByItemID(int itemID, string sort_)
		{
			return GetByItemID(itemID, 0, sort_, null);
		}
		public async Task<List<Sat_task_langEO>> GetByItemIDAsync(int itemID, string sort_)
		{
			return await GetByItemIDAsync(itemID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ItemID（字段） 查询
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_langEO> GetByItemID(int itemID, string sort_, TransactionManager tm_)
		{
			return GetByItemID(itemID, 0, sort_, tm_);
		}
		public async Task<List<Sat_task_langEO>> GetByItemIDAsync(int itemID, string sort_, TransactionManager tm_)
		{
			return await GetByItemIDAsync(itemID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ItemID（字段） 查询
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_langEO> GetByItemID(int itemID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ItemID` = @ItemID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_task_langEO.MapDataReader);
		}
		public async Task<List<Sat_task_langEO>> GetByItemIDAsync(int itemID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ItemID` = @ItemID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_task_langEO.MapDataReader);
		}
		#endregion // GetByItemID
		#region GetByLangID
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_langEO> GetByLangID(string langID)
		{
			return GetByLangID(langID, 0, string.Empty, null);
		}
		public async Task<List<Sat_task_langEO>> GetByLangIDAsync(string langID)
		{
			return await GetByLangIDAsync(langID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_langEO> GetByLangID(string langID, TransactionManager tm_)
		{
			return GetByLangID(langID, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_task_langEO>> GetByLangIDAsync(string langID, TransactionManager tm_)
		{
			return await GetByLangIDAsync(langID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_langEO> GetByLangID(string langID, int top_)
		{
			return GetByLangID(langID, top_, string.Empty, null);
		}
		public async Task<List<Sat_task_langEO>> GetByLangIDAsync(string langID, int top_)
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
		public List<Sat_task_langEO> GetByLangID(string langID, int top_, TransactionManager tm_)
		{
			return GetByLangID(langID, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_task_langEO>> GetByLangIDAsync(string langID, int top_, TransactionManager tm_)
		{
			return await GetByLangIDAsync(langID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_langEO> GetByLangID(string langID, string sort_)
		{
			return GetByLangID(langID, 0, sort_, null);
		}
		public async Task<List<Sat_task_langEO>> GetByLangIDAsync(string langID, string sort_)
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
		public List<Sat_task_langEO> GetByLangID(string langID, string sort_, TransactionManager tm_)
		{
			return GetByLangID(langID, 0, sort_, tm_);
		}
		public async Task<List<Sat_task_langEO>> GetByLangIDAsync(string langID, string sort_, TransactionManager tm_)
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
		public List<Sat_task_langEO> GetByLangID(string langID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LangID` = @LangID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_task_langEO.MapDataReader);
		}
		public async Task<List<Sat_task_langEO>> GetByLangIDAsync(string langID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LangID` = @LangID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_task_langEO.MapDataReader);
		}
		#endregion // GetByLangID
		#region GetByType
		
		/// <summary>
		/// 按 Type（字段） 查询
		/// </summary>
		/// /// <param name = "type">类型 0-未知 1-提示任务 2-完成任务</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_langEO> GetByType(int type)
		{
			return GetByType(type, 0, string.Empty, null);
		}
		public async Task<List<Sat_task_langEO>> GetByTypeAsync(int type)
		{
			return await GetByTypeAsync(type, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Type（字段） 查询
		/// </summary>
		/// /// <param name = "type">类型 0-未知 1-提示任务 2-完成任务</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_langEO> GetByType(int type, TransactionManager tm_)
		{
			return GetByType(type, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_task_langEO>> GetByTypeAsync(int type, TransactionManager tm_)
		{
			return await GetByTypeAsync(type, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Type（字段） 查询
		/// </summary>
		/// /// <param name = "type">类型 0-未知 1-提示任务 2-完成任务</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_langEO> GetByType(int type, int top_)
		{
			return GetByType(type, top_, string.Empty, null);
		}
		public async Task<List<Sat_task_langEO>> GetByTypeAsync(int type, int top_)
		{
			return await GetByTypeAsync(type, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Type（字段） 查询
		/// </summary>
		/// /// <param name = "type">类型 0-未知 1-提示任务 2-完成任务</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_langEO> GetByType(int type, int top_, TransactionManager tm_)
		{
			return GetByType(type, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_task_langEO>> GetByTypeAsync(int type, int top_, TransactionManager tm_)
		{
			return await GetByTypeAsync(type, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Type（字段） 查询
		/// </summary>
		/// /// <param name = "type">类型 0-未知 1-提示任务 2-完成任务</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_langEO> GetByType(int type, string sort_)
		{
			return GetByType(type, 0, sort_, null);
		}
		public async Task<List<Sat_task_langEO>> GetByTypeAsync(int type, string sort_)
		{
			return await GetByTypeAsync(type, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Type（字段） 查询
		/// </summary>
		/// /// <param name = "type">类型 0-未知 1-提示任务 2-完成任务</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_langEO> GetByType(int type, string sort_, TransactionManager tm_)
		{
			return GetByType(type, 0, sort_, tm_);
		}
		public async Task<List<Sat_task_langEO>> GetByTypeAsync(int type, string sort_, TransactionManager tm_)
		{
			return await GetByTypeAsync(type, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Type（字段） 查询
		/// </summary>
		/// /// <param name = "type">类型 0-未知 1-提示任务 2-完成任务</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_langEO> GetByType(int type, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Type` = @Type", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Type", type, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_task_langEO.MapDataReader);
		}
		public async Task<List<Sat_task_langEO>> GetByTypeAsync(int type, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Type` = @Type", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Type", type, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_task_langEO.MapDataReader);
		}
		#endregion // GetByType
		#region GetByTemplate
		
		/// <summary>
		/// 按 Template（字段） 查询
		/// </summary>
		/// /// <param name = "template">标题模板,模板变量 RewardAmount, MaxRewardAmount</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_langEO> GetByTemplate(string template)
		{
			return GetByTemplate(template, 0, string.Empty, null);
		}
		public async Task<List<Sat_task_langEO>> GetByTemplateAsync(string template)
		{
			return await GetByTemplateAsync(template, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Template（字段） 查询
		/// </summary>
		/// /// <param name = "template">标题模板,模板变量 RewardAmount, MaxRewardAmount</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_langEO> GetByTemplate(string template, TransactionManager tm_)
		{
			return GetByTemplate(template, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_task_langEO>> GetByTemplateAsync(string template, TransactionManager tm_)
		{
			return await GetByTemplateAsync(template, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Template（字段） 查询
		/// </summary>
		/// /// <param name = "template">标题模板,模板变量 RewardAmount, MaxRewardAmount</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_langEO> GetByTemplate(string template, int top_)
		{
			return GetByTemplate(template, top_, string.Empty, null);
		}
		public async Task<List<Sat_task_langEO>> GetByTemplateAsync(string template, int top_)
		{
			return await GetByTemplateAsync(template, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Template（字段） 查询
		/// </summary>
		/// /// <param name = "template">标题模板,模板变量 RewardAmount, MaxRewardAmount</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_langEO> GetByTemplate(string template, int top_, TransactionManager tm_)
		{
			return GetByTemplate(template, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_task_langEO>> GetByTemplateAsync(string template, int top_, TransactionManager tm_)
		{
			return await GetByTemplateAsync(template, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Template（字段） 查询
		/// </summary>
		/// /// <param name = "template">标题模板,模板变量 RewardAmount, MaxRewardAmount</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_langEO> GetByTemplate(string template, string sort_)
		{
			return GetByTemplate(template, 0, sort_, null);
		}
		public async Task<List<Sat_task_langEO>> GetByTemplateAsync(string template, string sort_)
		{
			return await GetByTemplateAsync(template, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Template（字段） 查询
		/// </summary>
		/// /// <param name = "template">标题模板,模板变量 RewardAmount, MaxRewardAmount</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_langEO> GetByTemplate(string template, string sort_, TransactionManager tm_)
		{
			return GetByTemplate(template, 0, sort_, tm_);
		}
		public async Task<List<Sat_task_langEO>> GetByTemplateAsync(string template, string sort_, TransactionManager tm_)
		{
			return await GetByTemplateAsync(template, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Template（字段） 查询
		/// </summary>
		/// /// <param name = "template">标题模板,模板变量 RewardAmount, MaxRewardAmount</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_langEO> GetByTemplate(string template, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(template != null ? "`Template` = @Template" : "`Template` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (template != null)
				paras_.Add(Database.CreateInParameter("@Template", template, MySqlDbType.Text));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_task_langEO.MapDataReader);
		}
		public async Task<List<Sat_task_langEO>> GetByTemplateAsync(string template, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(template != null ? "`Template` = @Template" : "`Template` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (template != null)
				paras_.Add(Database.CreateInParameter("@Template", template, MySqlDbType.Text));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_task_langEO.MapDataReader);
		}
		#endregion // GetByTemplate
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录日期</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_langEO> GetByRecDate(DateTime? recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<Sat_task_langEO>> GetByRecDateAsync(DateTime? recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录日期</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_langEO> GetByRecDate(DateTime? recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_task_langEO>> GetByRecDateAsync(DateTime? recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录日期</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_langEO> GetByRecDate(DateTime? recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<Sat_task_langEO>> GetByRecDateAsync(DateTime? recDate, int top_)
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
		public List<Sat_task_langEO> GetByRecDate(DateTime? recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_task_langEO>> GetByRecDateAsync(DateTime? recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录日期</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_task_langEO> GetByRecDate(DateTime? recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<Sat_task_langEO>> GetByRecDateAsync(DateTime? recDate, string sort_)
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
		public List<Sat_task_langEO> GetByRecDate(DateTime? recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<Sat_task_langEO>> GetByRecDateAsync(DateTime? recDate, string sort_, TransactionManager tm_)
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
		public List<Sat_task_langEO> GetByRecDate(DateTime? recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(recDate.HasValue ? "`RecDate` = @RecDate" : "`RecDate` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (recDate.HasValue)
				paras_.Add(Database.CreateInParameter("@RecDate", recDate.Value, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_task_langEO.MapDataReader);
		}
		public async Task<List<Sat_task_langEO>> GetByRecDateAsync(DateTime? recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(recDate.HasValue ? "`RecDate` = @RecDate" : "`RecDate` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (recDate.HasValue)
				paras_.Add(Database.CreateInParameter("@RecDate", recDate.Value, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_task_langEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
