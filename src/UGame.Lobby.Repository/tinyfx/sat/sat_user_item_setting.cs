/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * AiUo代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/AiUo
 * 文档生成时间：2023-10-24 18: 05:08
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
	/// 用户当前任务字段设置
	/// 【表 sat_user_item_setting 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Sat_user_item_settingEO : IRowMapper<Sat_user_item_settingEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Sat_user_item_settingEO()
		{
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
		
		private string _originalFieldName;
		/// <summary>
		/// 【数据库中的原始主键 FieldName 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalFieldName
		{
			get { return _originalFieldName; }
			set { HasOriginal = true; _originalFieldName = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "ItemID", ItemID },  { "FieldName", FieldName }, };
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
		/// 字段名称
		/// 【主键 varchar(50)】
		/// </summary>
		[DataMember(Order = 2)]
		public string FieldName { get; set; }
		/// <summary>
		/// 变量名称
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 3)]
		public string VariableName { get; set; }
		/// <summary>
		/// 字段描述
		/// 【字段 varchar(200)】
		/// </summary>
		[DataMember(Order = 4)]
		public string Description { get; set; }
		/// <summary>
		/// 排序
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 5)]
		public int? Sequence { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Sat_user_item_settingEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Sat_user_item_settingEO MapDataReader(IDataReader reader)
		{
		    Sat_user_item_settingEO ret = new Sat_user_item_settingEO();
			ret.ItemID = reader.ToInt32("ItemID");
			ret.OriginalItemID = ret.ItemID;
			ret.FieldName = reader.ToString("FieldName");
			ret.OriginalFieldName = ret.FieldName;
			ret.VariableName = reader.ToString("VariableName");
			ret.Description = reader.ToString("Description");
			ret.Sequence = reader.ToInt32N("Sequence");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 用户当前任务字段设置
	/// 【表 sat_user_item_setting 的操作类】
	/// </summary>
	[Obsolete]
	public class Sat_user_item_settingMO : MySqlTableMO<Sat_user_item_settingEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`sat_user_item_setting`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Sat_user_item_settingMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Sat_user_item_settingMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Sat_user_item_settingMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Sat_user_item_settingEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Sat_user_item_settingEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Sat_user_item_settingEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`ItemID`, `FieldName`, `VariableName`, `Description`, `Sequence`) VALUE (@ItemID, @FieldName, @VariableName, @Description, @Sequence);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", item.ItemID, MySqlDbType.Int32),
				Database.CreateInParameter("@FieldName", item.FieldName, MySqlDbType.VarChar),
				Database.CreateInParameter("@VariableName", item.VariableName != null ? item.VariableName : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Description", item.Description != null ? item.Description : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Sequence", item.Sequence.HasValue ? item.Sequence.Value : (object)DBNull.Value, MySqlDbType.Int32),
			};
		}
		public int AddByBatch(IEnumerable<Sat_user_item_settingEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Sat_user_item_settingEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sat_user_item_settingEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`ItemID`, `FieldName`, `VariableName`, `Description`, `Sequence`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"({item.ItemID},'{item.FieldName}','{item.VariableName}','{item.Description}',{item.Sequence?.ToString()??null}),");
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
		/// /// <param name = "fieldName">字段名称</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(int itemID, string fieldName, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(itemID, fieldName, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(int itemID, string fieldName, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(itemID, fieldName, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(int itemID, string fieldName, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `ItemID` = @ItemID AND `FieldName` = @FieldName";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@FieldName", fieldName, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Sat_user_item_settingEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.ItemID, item.FieldName, tm_);
		}
		public async Task<int> RemoveAsync(Sat_user_item_settingEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.ItemID, item.FieldName, tm_);
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
		#region RemoveByFieldName
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "fieldName">字段名称</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByFieldName(string fieldName, TransactionManager tm_ = null)
		{
			RepairRemoveByFieldNameData(fieldName, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByFieldNameAsync(string fieldName, TransactionManager tm_ = null)
		{
			RepairRemoveByFieldNameData(fieldName, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByFieldNameData(string fieldName, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `FieldName` = @FieldName";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FieldName", fieldName, MySqlDbType.VarChar));
		}
		#endregion // RemoveByFieldName
		#region RemoveByVariableName
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "variableName">变量名称</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByVariableName(string variableName, TransactionManager tm_ = null)
		{
			RepairRemoveByVariableNameData(variableName, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByVariableNameAsync(string variableName, TransactionManager tm_ = null)
		{
			RepairRemoveByVariableNameData(variableName, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByVariableNameData(string variableName, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (variableName != null ? "`VariableName` = @VariableName" : "`VariableName` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (variableName != null)
				paras_.Add(Database.CreateInParameter("@VariableName", variableName, MySqlDbType.VarChar));
		}
		#endregion // RemoveByVariableName
		#region RemoveByDescription
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "description">字段描述</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByDescription(string description, TransactionManager tm_ = null)
		{
			RepairRemoveByDescriptionData(description, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByDescriptionAsync(string description, TransactionManager tm_ = null)
		{
			RepairRemoveByDescriptionData(description, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByDescriptionData(string description, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (description != null ? "`Description` = @Description" : "`Description` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (description != null)
				paras_.Add(Database.CreateInParameter("@Description", description, MySqlDbType.VarChar));
		}
		#endregion // RemoveByDescription
		#region RemoveBySequence
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "sequence">排序</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveBySequence(int? sequence, TransactionManager tm_ = null)
		{
			RepairRemoveBySequenceData(sequence.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveBySequenceAsync(int? sequence, TransactionManager tm_ = null)
		{
			RepairRemoveBySequenceData(sequence.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveBySequenceData(int? sequence, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (sequence.HasValue ? "`Sequence` = @Sequence" : "`Sequence` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (sequence.HasValue)
				paras_.Add(Database.CreateInParameter("@Sequence", sequence.Value, MySqlDbType.Int32));
		}
		#endregion // RemoveBySequence
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
		public int Put(Sat_user_item_settingEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Sat_user_item_settingEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Sat_user_item_settingEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ItemID` = @ItemID, `FieldName` = @FieldName, `VariableName` = @VariableName, `Description` = @Description, `Sequence` = @Sequence WHERE `ItemID` = @ItemID_Original AND `FieldName` = @FieldName_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", item.ItemID, MySqlDbType.Int32),
				Database.CreateInParameter("@FieldName", item.FieldName, MySqlDbType.VarChar),
				Database.CreateInParameter("@VariableName", item.VariableName != null ? item.VariableName : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Description", item.Description != null ? item.Description : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Sequence", item.Sequence.HasValue ? item.Sequence.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemID_Original", item.HasOriginal ? item.OriginalItemID : item.ItemID, MySqlDbType.Int32),
				Database.CreateInParameter("@FieldName_Original", item.HasOriginal ? item.OriginalFieldName : item.FieldName, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Sat_user_item_settingEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Sat_user_item_settingEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "fieldName">字段名称</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int itemID, string fieldName, string set_, params object[] values_)
		{
			return Put(set_, "`ItemID` = @ItemID AND `FieldName` = @FieldName", ConcatValues(values_, itemID, fieldName));
		}
		public async Task<int> PutByPKAsync(int itemID, string fieldName, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`ItemID` = @ItemID AND `FieldName` = @FieldName", ConcatValues(values_, itemID, fieldName));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "fieldName">字段名称</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int itemID, string fieldName, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`ItemID` = @ItemID AND `FieldName` = @FieldName", tm_, ConcatValues(values_, itemID, fieldName));
		}
		public async Task<int> PutByPKAsync(int itemID, string fieldName, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`ItemID` = @ItemID AND `FieldName` = @FieldName", tm_, ConcatValues(values_, itemID, fieldName));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "fieldName">字段名称</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int itemID, string fieldName, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@FieldName", fieldName, MySqlDbType.VarChar),
	        };
			return Put(set_, "`ItemID` = @ItemID AND `FieldName` = @FieldName", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(int itemID, string fieldName, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@FieldName", fieldName, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`ItemID` = @ItemID AND `FieldName` = @FieldName", ConcatParameters(paras_, newParas_), tm_);
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
		#region PutFieldName
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "fieldName">字段名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFieldName(string fieldName, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FieldName` = @FieldName";
			var parameter_ = Database.CreateInParameter("@FieldName", fieldName, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutFieldNameAsync(string fieldName, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FieldName` = @FieldName";
			var parameter_ = Database.CreateInParameter("@FieldName", fieldName, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutFieldName
		#region PutVariableName
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "fieldName">字段名称</param>
		/// /// <param name = "variableName">变量名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutVariableNameByPK(int itemID, string fieldName, string variableName, TransactionManager tm_ = null)
		{
			RepairPutVariableNameByPKData(itemID, fieldName, variableName, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutVariableNameByPKAsync(int itemID, string fieldName, string variableName, TransactionManager tm_ = null)
		{
			RepairPutVariableNameByPKData(itemID, fieldName, variableName, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutVariableNameByPKData(int itemID, string fieldName, string variableName, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `VariableName` = @VariableName  WHERE `ItemID` = @ItemID AND `FieldName` = @FieldName";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@VariableName", variableName != null ? variableName : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@FieldName", fieldName, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "variableName">变量名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutVariableName(string variableName, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `VariableName` = @VariableName";
			var parameter_ = Database.CreateInParameter("@VariableName", variableName != null ? variableName : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutVariableNameAsync(string variableName, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `VariableName` = @VariableName";
			var parameter_ = Database.CreateInParameter("@VariableName", variableName != null ? variableName : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutVariableName
		#region PutDescription
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "fieldName">字段名称</param>
		/// /// <param name = "description">字段描述</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutDescriptionByPK(int itemID, string fieldName, string description, TransactionManager tm_ = null)
		{
			RepairPutDescriptionByPKData(itemID, fieldName, description, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutDescriptionByPKAsync(int itemID, string fieldName, string description, TransactionManager tm_ = null)
		{
			RepairPutDescriptionByPKData(itemID, fieldName, description, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutDescriptionByPKData(int itemID, string fieldName, string description, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Description` = @Description  WHERE `ItemID` = @ItemID AND `FieldName` = @FieldName";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Description", description != null ? description : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@FieldName", fieldName, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "description">字段描述</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutDescription(string description, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Description` = @Description";
			var parameter_ = Database.CreateInParameter("@Description", description != null ? description : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutDescriptionAsync(string description, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Description` = @Description";
			var parameter_ = Database.CreateInParameter("@Description", description != null ? description : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutDescription
		#region PutSequence
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "fieldName">字段名称</param>
		/// /// <param name = "sequence">排序</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSequenceByPK(int itemID, string fieldName, int? sequence, TransactionManager tm_ = null)
		{
			RepairPutSequenceByPKData(itemID, fieldName, sequence, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutSequenceByPKAsync(int itemID, string fieldName, int? sequence, TransactionManager tm_ = null)
		{
			RepairPutSequenceByPKData(itemID, fieldName, sequence, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutSequenceByPKData(int itemID, string fieldName, int? sequence, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Sequence` = @Sequence  WHERE `ItemID` = @ItemID AND `FieldName` = @FieldName";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Sequence", sequence.HasValue ? sequence.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@FieldName", fieldName, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "sequence">排序</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSequence(int? sequence, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Sequence` = @Sequence";
			var parameter_ = Database.CreateInParameter("@Sequence", sequence.HasValue ? sequence.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutSequenceAsync(int? sequence, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Sequence` = @Sequence";
			var parameter_ = Database.CreateInParameter("@Sequence", sequence.HasValue ? sequence.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutSequence
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Sat_user_item_settingEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.ItemID, item.FieldName) == null)
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
		public async Task<bool> SetAsync(Sat_user_item_settingEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.ItemID, item.FieldName) == null)
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
		/// /// <param name = "fieldName">字段名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Sat_user_item_settingEO GetByPK(int itemID, string fieldName, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(itemID, fieldName, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sat_user_item_settingEO.MapDataReader);
		}
		public async Task<Sat_user_item_settingEO> GetByPKAsync(int itemID, string fieldName, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(itemID, fieldName, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sat_user_item_settingEO.MapDataReader);
		}
		private void RepairGetByPKData(int itemID, string fieldName, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`ItemID` = @ItemID AND `FieldName` = @FieldName", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@FieldName", fieldName, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 ItemID（字段）
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "fieldName">字段名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetItemIDByPK(int itemID, string fieldName, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@FieldName", fieldName, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`ItemID`", "`ItemID` = @ItemID AND `FieldName` = @FieldName", paras_, tm_);
		}
		public async Task<int> GetItemIDByPKAsync(int itemID, string fieldName, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@FieldName", fieldName, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`ItemID`", "`ItemID` = @ItemID AND `FieldName` = @FieldName", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 FieldName（字段）
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "fieldName">字段名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetFieldNameByPK(int itemID, string fieldName, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@FieldName", fieldName, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`FieldName`", "`ItemID` = @ItemID AND `FieldName` = @FieldName", paras_, tm_);
		}
		public async Task<string> GetFieldNameByPKAsync(int itemID, string fieldName, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@FieldName", fieldName, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`FieldName`", "`ItemID` = @ItemID AND `FieldName` = @FieldName", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 VariableName（字段）
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "fieldName">字段名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetVariableNameByPK(int itemID, string fieldName, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@FieldName", fieldName, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`VariableName`", "`ItemID` = @ItemID AND `FieldName` = @FieldName", paras_, tm_);
		}
		public async Task<string> GetVariableNameByPKAsync(int itemID, string fieldName, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@FieldName", fieldName, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`VariableName`", "`ItemID` = @ItemID AND `FieldName` = @FieldName", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Description（字段）
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "fieldName">字段名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetDescriptionByPK(int itemID, string fieldName, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@FieldName", fieldName, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Description`", "`ItemID` = @ItemID AND `FieldName` = @FieldName", paras_, tm_);
		}
		public async Task<string> GetDescriptionByPKAsync(int itemID, string fieldName, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@FieldName", fieldName, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Description`", "`ItemID` = @ItemID AND `FieldName` = @FieldName", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Sequence（字段）
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "fieldName">字段名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int? GetSequenceByPK(int itemID, string fieldName, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@FieldName", fieldName, MySqlDbType.VarChar),
			};
			return (int?)GetScalar("`Sequence`", "`ItemID` = @ItemID AND `FieldName` = @FieldName", paras_, tm_);
		}
		public async Task<int?> GetSequenceByPKAsync(int itemID, string fieldName, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@FieldName", fieldName, MySqlDbType.VarChar),
			};
			return (int?)await GetScalarAsync("`Sequence`", "`ItemID` = @ItemID AND `FieldName` = @FieldName", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByItemID
		
		/// <summary>
		/// 按 ItemID（字段） 查询
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_item_settingEO> GetByItemID(int itemID)
		{
			return GetByItemID(itemID, 0, string.Empty, null);
		}
		public async Task<List<Sat_user_item_settingEO>> GetByItemIDAsync(int itemID)
		{
			return await GetByItemIDAsync(itemID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ItemID（字段） 查询
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_item_settingEO> GetByItemID(int itemID, TransactionManager tm_)
		{
			return GetByItemID(itemID, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_user_item_settingEO>> GetByItemIDAsync(int itemID, TransactionManager tm_)
		{
			return await GetByItemIDAsync(itemID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ItemID（字段） 查询
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_item_settingEO> GetByItemID(int itemID, int top_)
		{
			return GetByItemID(itemID, top_, string.Empty, null);
		}
		public async Task<List<Sat_user_item_settingEO>> GetByItemIDAsync(int itemID, int top_)
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
		public List<Sat_user_item_settingEO> GetByItemID(int itemID, int top_, TransactionManager tm_)
		{
			return GetByItemID(itemID, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_user_item_settingEO>> GetByItemIDAsync(int itemID, int top_, TransactionManager tm_)
		{
			return await GetByItemIDAsync(itemID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ItemID（字段） 查询
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_item_settingEO> GetByItemID(int itemID, string sort_)
		{
			return GetByItemID(itemID, 0, sort_, null);
		}
		public async Task<List<Sat_user_item_settingEO>> GetByItemIDAsync(int itemID, string sort_)
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
		public List<Sat_user_item_settingEO> GetByItemID(int itemID, string sort_, TransactionManager tm_)
		{
			return GetByItemID(itemID, 0, sort_, tm_);
		}
		public async Task<List<Sat_user_item_settingEO>> GetByItemIDAsync(int itemID, string sort_, TransactionManager tm_)
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
		public List<Sat_user_item_settingEO> GetByItemID(int itemID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ItemID` = @ItemID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_user_item_settingEO.MapDataReader);
		}
		public async Task<List<Sat_user_item_settingEO>> GetByItemIDAsync(int itemID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ItemID` = @ItemID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_user_item_settingEO.MapDataReader);
		}
		#endregion // GetByItemID
		#region GetByFieldName
		
		/// <summary>
		/// 按 FieldName（字段） 查询
		/// </summary>
		/// /// <param name = "fieldName">字段名称</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_item_settingEO> GetByFieldName(string fieldName)
		{
			return GetByFieldName(fieldName, 0, string.Empty, null);
		}
		public async Task<List<Sat_user_item_settingEO>> GetByFieldNameAsync(string fieldName)
		{
			return await GetByFieldNameAsync(fieldName, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FieldName（字段） 查询
		/// </summary>
		/// /// <param name = "fieldName">字段名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_item_settingEO> GetByFieldName(string fieldName, TransactionManager tm_)
		{
			return GetByFieldName(fieldName, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_user_item_settingEO>> GetByFieldNameAsync(string fieldName, TransactionManager tm_)
		{
			return await GetByFieldNameAsync(fieldName, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FieldName（字段） 查询
		/// </summary>
		/// /// <param name = "fieldName">字段名称</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_item_settingEO> GetByFieldName(string fieldName, int top_)
		{
			return GetByFieldName(fieldName, top_, string.Empty, null);
		}
		public async Task<List<Sat_user_item_settingEO>> GetByFieldNameAsync(string fieldName, int top_)
		{
			return await GetByFieldNameAsync(fieldName, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FieldName（字段） 查询
		/// </summary>
		/// /// <param name = "fieldName">字段名称</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_item_settingEO> GetByFieldName(string fieldName, int top_, TransactionManager tm_)
		{
			return GetByFieldName(fieldName, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_user_item_settingEO>> GetByFieldNameAsync(string fieldName, int top_, TransactionManager tm_)
		{
			return await GetByFieldNameAsync(fieldName, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FieldName（字段） 查询
		/// </summary>
		/// /// <param name = "fieldName">字段名称</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_item_settingEO> GetByFieldName(string fieldName, string sort_)
		{
			return GetByFieldName(fieldName, 0, sort_, null);
		}
		public async Task<List<Sat_user_item_settingEO>> GetByFieldNameAsync(string fieldName, string sort_)
		{
			return await GetByFieldNameAsync(fieldName, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 FieldName（字段） 查询
		/// </summary>
		/// /// <param name = "fieldName">字段名称</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_item_settingEO> GetByFieldName(string fieldName, string sort_, TransactionManager tm_)
		{
			return GetByFieldName(fieldName, 0, sort_, tm_);
		}
		public async Task<List<Sat_user_item_settingEO>> GetByFieldNameAsync(string fieldName, string sort_, TransactionManager tm_)
		{
			return await GetByFieldNameAsync(fieldName, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 FieldName（字段） 查询
		/// </summary>
		/// /// <param name = "fieldName">字段名称</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_item_settingEO> GetByFieldName(string fieldName, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FieldName` = @FieldName", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FieldName", fieldName, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_user_item_settingEO.MapDataReader);
		}
		public async Task<List<Sat_user_item_settingEO>> GetByFieldNameAsync(string fieldName, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FieldName` = @FieldName", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FieldName", fieldName, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_user_item_settingEO.MapDataReader);
		}
		#endregion // GetByFieldName
		#region GetByVariableName
		
		/// <summary>
		/// 按 VariableName（字段） 查询
		/// </summary>
		/// /// <param name = "variableName">变量名称</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_item_settingEO> GetByVariableName(string variableName)
		{
			return GetByVariableName(variableName, 0, string.Empty, null);
		}
		public async Task<List<Sat_user_item_settingEO>> GetByVariableNameAsync(string variableName)
		{
			return await GetByVariableNameAsync(variableName, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 VariableName（字段） 查询
		/// </summary>
		/// /// <param name = "variableName">变量名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_item_settingEO> GetByVariableName(string variableName, TransactionManager tm_)
		{
			return GetByVariableName(variableName, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_user_item_settingEO>> GetByVariableNameAsync(string variableName, TransactionManager tm_)
		{
			return await GetByVariableNameAsync(variableName, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 VariableName（字段） 查询
		/// </summary>
		/// /// <param name = "variableName">变量名称</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_item_settingEO> GetByVariableName(string variableName, int top_)
		{
			return GetByVariableName(variableName, top_, string.Empty, null);
		}
		public async Task<List<Sat_user_item_settingEO>> GetByVariableNameAsync(string variableName, int top_)
		{
			return await GetByVariableNameAsync(variableName, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 VariableName（字段） 查询
		/// </summary>
		/// /// <param name = "variableName">变量名称</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_item_settingEO> GetByVariableName(string variableName, int top_, TransactionManager tm_)
		{
			return GetByVariableName(variableName, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_user_item_settingEO>> GetByVariableNameAsync(string variableName, int top_, TransactionManager tm_)
		{
			return await GetByVariableNameAsync(variableName, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 VariableName（字段） 查询
		/// </summary>
		/// /// <param name = "variableName">变量名称</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_item_settingEO> GetByVariableName(string variableName, string sort_)
		{
			return GetByVariableName(variableName, 0, sort_, null);
		}
		public async Task<List<Sat_user_item_settingEO>> GetByVariableNameAsync(string variableName, string sort_)
		{
			return await GetByVariableNameAsync(variableName, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 VariableName（字段） 查询
		/// </summary>
		/// /// <param name = "variableName">变量名称</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_item_settingEO> GetByVariableName(string variableName, string sort_, TransactionManager tm_)
		{
			return GetByVariableName(variableName, 0, sort_, tm_);
		}
		public async Task<List<Sat_user_item_settingEO>> GetByVariableNameAsync(string variableName, string sort_, TransactionManager tm_)
		{
			return await GetByVariableNameAsync(variableName, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 VariableName（字段） 查询
		/// </summary>
		/// /// <param name = "variableName">变量名称</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_item_settingEO> GetByVariableName(string variableName, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(variableName != null ? "`VariableName` = @VariableName" : "`VariableName` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (variableName != null)
				paras_.Add(Database.CreateInParameter("@VariableName", variableName, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_user_item_settingEO.MapDataReader);
		}
		public async Task<List<Sat_user_item_settingEO>> GetByVariableNameAsync(string variableName, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(variableName != null ? "`VariableName` = @VariableName" : "`VariableName` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (variableName != null)
				paras_.Add(Database.CreateInParameter("@VariableName", variableName, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_user_item_settingEO.MapDataReader);
		}
		#endregion // GetByVariableName
		#region GetByDescription
		
		/// <summary>
		/// 按 Description（字段） 查询
		/// </summary>
		/// /// <param name = "description">字段描述</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_item_settingEO> GetByDescription(string description)
		{
			return GetByDescription(description, 0, string.Empty, null);
		}
		public async Task<List<Sat_user_item_settingEO>> GetByDescriptionAsync(string description)
		{
			return await GetByDescriptionAsync(description, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Description（字段） 查询
		/// </summary>
		/// /// <param name = "description">字段描述</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_item_settingEO> GetByDescription(string description, TransactionManager tm_)
		{
			return GetByDescription(description, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_user_item_settingEO>> GetByDescriptionAsync(string description, TransactionManager tm_)
		{
			return await GetByDescriptionAsync(description, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Description（字段） 查询
		/// </summary>
		/// /// <param name = "description">字段描述</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_item_settingEO> GetByDescription(string description, int top_)
		{
			return GetByDescription(description, top_, string.Empty, null);
		}
		public async Task<List<Sat_user_item_settingEO>> GetByDescriptionAsync(string description, int top_)
		{
			return await GetByDescriptionAsync(description, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Description（字段） 查询
		/// </summary>
		/// /// <param name = "description">字段描述</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_item_settingEO> GetByDescription(string description, int top_, TransactionManager tm_)
		{
			return GetByDescription(description, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_user_item_settingEO>> GetByDescriptionAsync(string description, int top_, TransactionManager tm_)
		{
			return await GetByDescriptionAsync(description, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Description（字段） 查询
		/// </summary>
		/// /// <param name = "description">字段描述</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_item_settingEO> GetByDescription(string description, string sort_)
		{
			return GetByDescription(description, 0, sort_, null);
		}
		public async Task<List<Sat_user_item_settingEO>> GetByDescriptionAsync(string description, string sort_)
		{
			return await GetByDescriptionAsync(description, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Description（字段） 查询
		/// </summary>
		/// /// <param name = "description">字段描述</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_item_settingEO> GetByDescription(string description, string sort_, TransactionManager tm_)
		{
			return GetByDescription(description, 0, sort_, tm_);
		}
		public async Task<List<Sat_user_item_settingEO>> GetByDescriptionAsync(string description, string sort_, TransactionManager tm_)
		{
			return await GetByDescriptionAsync(description, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Description（字段） 查询
		/// </summary>
		/// /// <param name = "description">字段描述</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_item_settingEO> GetByDescription(string description, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(description != null ? "`Description` = @Description" : "`Description` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (description != null)
				paras_.Add(Database.CreateInParameter("@Description", description, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_user_item_settingEO.MapDataReader);
		}
		public async Task<List<Sat_user_item_settingEO>> GetByDescriptionAsync(string description, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(description != null ? "`Description` = @Description" : "`Description` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (description != null)
				paras_.Add(Database.CreateInParameter("@Description", description, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_user_item_settingEO.MapDataReader);
		}
		#endregion // GetByDescription
		#region GetBySequence
		
		/// <summary>
		/// 按 Sequence（字段） 查询
		/// </summary>
		/// /// <param name = "sequence">排序</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_item_settingEO> GetBySequence(int? sequence)
		{
			return GetBySequence(sequence, 0, string.Empty, null);
		}
		public async Task<List<Sat_user_item_settingEO>> GetBySequenceAsync(int? sequence)
		{
			return await GetBySequenceAsync(sequence, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Sequence（字段） 查询
		/// </summary>
		/// /// <param name = "sequence">排序</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_item_settingEO> GetBySequence(int? sequence, TransactionManager tm_)
		{
			return GetBySequence(sequence, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_user_item_settingEO>> GetBySequenceAsync(int? sequence, TransactionManager tm_)
		{
			return await GetBySequenceAsync(sequence, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Sequence（字段） 查询
		/// </summary>
		/// /// <param name = "sequence">排序</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_item_settingEO> GetBySequence(int? sequence, int top_)
		{
			return GetBySequence(sequence, top_, string.Empty, null);
		}
		public async Task<List<Sat_user_item_settingEO>> GetBySequenceAsync(int? sequence, int top_)
		{
			return await GetBySequenceAsync(sequence, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Sequence（字段） 查询
		/// </summary>
		/// /// <param name = "sequence">排序</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_item_settingEO> GetBySequence(int? sequence, int top_, TransactionManager tm_)
		{
			return GetBySequence(sequence, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_user_item_settingEO>> GetBySequenceAsync(int? sequence, int top_, TransactionManager tm_)
		{
			return await GetBySequenceAsync(sequence, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Sequence（字段） 查询
		/// </summary>
		/// /// <param name = "sequence">排序</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_item_settingEO> GetBySequence(int? sequence, string sort_)
		{
			return GetBySequence(sequence, 0, sort_, null);
		}
		public async Task<List<Sat_user_item_settingEO>> GetBySequenceAsync(int? sequence, string sort_)
		{
			return await GetBySequenceAsync(sequence, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Sequence（字段） 查询
		/// </summary>
		/// /// <param name = "sequence">排序</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_item_settingEO> GetBySequence(int? sequence, string sort_, TransactionManager tm_)
		{
			return GetBySequence(sequence, 0, sort_, tm_);
		}
		public async Task<List<Sat_user_item_settingEO>> GetBySequenceAsync(int? sequence, string sort_, TransactionManager tm_)
		{
			return await GetBySequenceAsync(sequence, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Sequence（字段） 查询
		/// </summary>
		/// /// <param name = "sequence">排序</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_user_item_settingEO> GetBySequence(int? sequence, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(sequence.HasValue ? "`Sequence` = @Sequence" : "`Sequence` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (sequence.HasValue)
				paras_.Add(Database.CreateInParameter("@Sequence", sequence.Value, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_user_item_settingEO.MapDataReader);
		}
		public async Task<List<Sat_user_item_settingEO>> GetBySequenceAsync(int? sequence, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(sequence.HasValue ? "`Sequence` = @Sequence" : "`Sequence` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (sequence.HasValue)
				paras_.Add(Database.CreateInParameter("@Sequence", sequence.Value, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_user_item_settingEO.MapDataReader);
		}
		#endregion // GetBySequence
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
