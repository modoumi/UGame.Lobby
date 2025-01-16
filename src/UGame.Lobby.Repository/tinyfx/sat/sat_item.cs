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
	/// 工具总列表
	/// 【表 sat_item 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Sat_itemEO : IRowMapper<Sat_itemEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Sat_itemEO()
		{
			this.SourceTypeID = 0;
			this.TriggerType = 0;
			this.ItemType = 0;
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
		/// 工具名称
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 2)]
		public string Name { get; set; }
		/// <summary>
		/// 统计编码
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 3)]
		public int SourceTypeID { get; set; }
		/// <summary>
		/// 触发类型0 未知, 1消息, 2 自主定时,3 主动触发 API调用
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 4)]
		public int TriggerType { get; set; }
		/// <summary>
		/// 工具类型 0未知 1-循环类,2-可完成类
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 5)]
		public int ItemType { get; set; }
		/// <summary>
		/// 状态(0-无效1-有效)
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 6)]
		public int Status { get; set; }
		/// <summary>
		/// 记录日期
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 7)]
		public DateTime RecDate { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Sat_itemEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Sat_itemEO MapDataReader(IDataReader reader)
		{
		    Sat_itemEO ret = new Sat_itemEO();
			ret.ItemID = reader.ToInt32("ItemID");
			ret.OriginalItemID = ret.ItemID;
			ret.Name = reader.ToString("Name");
			ret.SourceTypeID = reader.ToInt32("SourceTypeID");
			ret.TriggerType = reader.ToInt32("TriggerType");
			ret.ItemType = reader.ToInt32("ItemType");
			ret.Status = reader.ToInt32("Status");
			ret.RecDate = reader.ToDateTime("RecDate");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 工具总列表
	/// 【表 sat_item 的操作类】
	/// </summary>
	[Obsolete]
	public class Sat_itemMO : MySqlTableMO<Sat_itemEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`sat_item`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Sat_itemMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Sat_itemMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Sat_itemMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Sat_itemEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Sat_itemEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Sat_itemEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`ItemID`, `Name`, `SourceTypeID`, `TriggerType`, `ItemType`, `Status`, `RecDate`) VALUE (@ItemID, @Name, @SourceTypeID, @TriggerType, @ItemType, @Status, @RecDate);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", item.ItemID, MySqlDbType.Int32),
				Database.CreateInParameter("@Name", item.Name != null ? item.Name : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@SourceTypeID", item.SourceTypeID, MySqlDbType.Int32),
				Database.CreateInParameter("@TriggerType", item.TriggerType, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemType", item.ItemType, MySqlDbType.Int32),
				Database.CreateInParameter("@Status", item.Status, MySqlDbType.Int32),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
			};
		}
		public int AddByBatch(IEnumerable<Sat_itemEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Sat_itemEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sat_itemEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`ItemID`, `Name`, `SourceTypeID`, `TriggerType`, `ItemType`, `Status`, `RecDate`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"({item.ItemID},'{item.Name}',{item.SourceTypeID},{item.TriggerType},{item.ItemType},{item.Status},'{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
		public int Remove(Sat_itemEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.ItemID, tm_);
		}
		public async Task<int> RemoveAsync(Sat_itemEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.ItemID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByName
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "name">工具名称</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByName(string name, TransactionManager tm_ = null)
		{
			RepairRemoveByNameData(name, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByNameAsync(string name, TransactionManager tm_ = null)
		{
			RepairRemoveByNameData(name, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByNameData(string name, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (name != null ? "`Name` = @Name" : "`Name` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (name != null)
				paras_.Add(Database.CreateInParameter("@Name", name, MySqlDbType.VarChar));
		}
		#endregion // RemoveByName
		#region RemoveBySourceTypeID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "sourceTypeID">统计编码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveBySourceTypeID(int sourceTypeID, TransactionManager tm_ = null)
		{
			RepairRemoveBySourceTypeIDData(sourceTypeID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveBySourceTypeIDAsync(int sourceTypeID, TransactionManager tm_ = null)
		{
			RepairRemoveBySourceTypeIDData(sourceTypeID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveBySourceTypeIDData(int sourceTypeID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `SourceTypeID` = @SourceTypeID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SourceTypeID", sourceTypeID, MySqlDbType.Int32));
		}
		#endregion // RemoveBySourceTypeID
		#region RemoveByTriggerType
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "triggerType">触发类型0 未知, 1消息, 2 自主定时,3 主动触发 API调用</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTriggerType(int triggerType, TransactionManager tm_ = null)
		{
			RepairRemoveByTriggerTypeData(triggerType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTriggerTypeAsync(int triggerType, TransactionManager tm_ = null)
		{
			RepairRemoveByTriggerTypeData(triggerType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTriggerTypeData(int triggerType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `TriggerType` = @TriggerType";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TriggerType", triggerType, MySqlDbType.Int32));
		}
		#endregion // RemoveByTriggerType
		#region RemoveByItemType
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "itemType">工具类型 0未知 1-循环类,2-可完成类</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByItemType(int itemType, TransactionManager tm_ = null)
		{
			RepairRemoveByItemTypeData(itemType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByItemTypeAsync(int itemType, TransactionManager tm_ = null)
		{
			RepairRemoveByItemTypeData(itemType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByItemTypeData(int itemType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `ItemType` = @ItemType";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ItemType", itemType, MySqlDbType.Int32));
		}
		#endregion // RemoveByItemType
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
		public int Put(Sat_itemEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Sat_itemEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Sat_itemEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ItemID` = @ItemID, `Name` = @Name, `SourceTypeID` = @SourceTypeID, `TriggerType` = @TriggerType, `ItemType` = @ItemType, `Status` = @Status, `RecDate` = @RecDate WHERE `ItemID` = @ItemID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", item.ItemID, MySqlDbType.Int32),
				Database.CreateInParameter("@Name", item.Name != null ? item.Name : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@SourceTypeID", item.SourceTypeID, MySqlDbType.Int32),
				Database.CreateInParameter("@TriggerType", item.TriggerType, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemType", item.ItemType, MySqlDbType.Int32),
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
		public int Put(IEnumerable<Sat_itemEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Sat_itemEO> items, TransactionManager tm_ = null)
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
		#region PutName
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "name">工具名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutNameByPK(int itemID, string name, TransactionManager tm_ = null)
		{
			RepairPutNameByPKData(itemID, name, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutNameByPKAsync(int itemID, string name, TransactionManager tm_ = null)
		{
			RepairPutNameByPKData(itemID, name, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutNameByPKData(int itemID, string name, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Name` = @Name  WHERE `ItemID` = @ItemID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Name", name != null ? name : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "name">工具名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutName(string name, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Name` = @Name";
			var parameter_ = Database.CreateInParameter("@Name", name != null ? name : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutNameAsync(string name, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Name` = @Name";
			var parameter_ = Database.CreateInParameter("@Name", name != null ? name : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutName
		#region PutSourceTypeID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "sourceTypeID">统计编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSourceTypeIDByPK(int itemID, int sourceTypeID, TransactionManager tm_ = null)
		{
			RepairPutSourceTypeIDByPKData(itemID, sourceTypeID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutSourceTypeIDByPKAsync(int itemID, int sourceTypeID, TransactionManager tm_ = null)
		{
			RepairPutSourceTypeIDByPKData(itemID, sourceTypeID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutSourceTypeIDByPKData(int itemID, int sourceTypeID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `SourceTypeID` = @SourceTypeID  WHERE `ItemID` = @ItemID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SourceTypeID", sourceTypeID, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "sourceTypeID">统计编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSourceTypeID(int sourceTypeID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SourceTypeID` = @SourceTypeID";
			var parameter_ = Database.CreateInParameter("@SourceTypeID", sourceTypeID, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutSourceTypeIDAsync(int sourceTypeID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SourceTypeID` = @SourceTypeID";
			var parameter_ = Database.CreateInParameter("@SourceTypeID", sourceTypeID, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutSourceTypeID
		#region PutTriggerType
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "triggerType">触发类型0 未知, 1消息, 2 自主定时,3 主动触发 API调用</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTriggerTypeByPK(int itemID, int triggerType, TransactionManager tm_ = null)
		{
			RepairPutTriggerTypeByPKData(itemID, triggerType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTriggerTypeByPKAsync(int itemID, int triggerType, TransactionManager tm_ = null)
		{
			RepairPutTriggerTypeByPKData(itemID, triggerType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTriggerTypeByPKData(int itemID, int triggerType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `TriggerType` = @TriggerType  WHERE `ItemID` = @ItemID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TriggerType", triggerType, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "triggerType">触发类型0 未知, 1消息, 2 自主定时,3 主动触发 API调用</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTriggerType(int triggerType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TriggerType` = @TriggerType";
			var parameter_ = Database.CreateInParameter("@TriggerType", triggerType, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTriggerTypeAsync(int triggerType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TriggerType` = @TriggerType";
			var parameter_ = Database.CreateInParameter("@TriggerType", triggerType, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTriggerType
		#region PutItemType
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// /// <param name = "itemType">工具类型 0未知 1-循环类,2-可完成类</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutItemTypeByPK(int itemID, int itemType, TransactionManager tm_ = null)
		{
			RepairPutItemTypeByPKData(itemID, itemType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutItemTypeByPKAsync(int itemID, int itemType, TransactionManager tm_ = null)
		{
			RepairPutItemTypeByPKData(itemID, itemType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutItemTypeByPKData(int itemID, int itemType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ItemType` = @ItemType  WHERE `ItemID` = @ItemID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemType", itemType, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "itemType">工具类型 0未知 1-循环类,2-可完成类</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutItemType(int itemType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ItemType` = @ItemType";
			var parameter_ = Database.CreateInParameter("@ItemType", itemType, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutItemTypeAsync(int itemType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ItemType` = @ItemType";
			var parameter_ = Database.CreateInParameter("@ItemType", itemType, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutItemType
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
		public bool Set(Sat_itemEO item, TransactionManager tm = null)
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
		public async Task<bool> SetAsync(Sat_itemEO item, TransactionManager tm = null)
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
		public Sat_itemEO GetByPK(int itemID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(itemID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sat_itemEO.MapDataReader);
		}
		public async Task<Sat_itemEO> GetByPKAsync(int itemID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(itemID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sat_itemEO.MapDataReader);
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
		/// 按主键查询 Name（字段）
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetNameByPK(int itemID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
			};
			return (string)GetScalar("`Name`", "`ItemID` = @ItemID", paras_, tm_);
		}
		public async Task<string> GetNameByPKAsync(int itemID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
			};
			return (string)await GetScalarAsync("`Name`", "`ItemID` = @ItemID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 SourceTypeID（字段）
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetSourceTypeIDByPK(int itemID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
			};
			return (int)GetScalar("`SourceTypeID`", "`ItemID` = @ItemID", paras_, tm_);
		}
		public async Task<int> GetSourceTypeIDByPKAsync(int itemID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`SourceTypeID`", "`ItemID` = @ItemID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 TriggerType（字段）
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetTriggerTypeByPK(int itemID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
			};
			return (int)GetScalar("`TriggerType`", "`ItemID` = @ItemID", paras_, tm_);
		}
		public async Task<int> GetTriggerTypeByPKAsync(int itemID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`TriggerType`", "`ItemID` = @ItemID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ItemType（字段）
		/// </summary>
		/// /// <param name = "itemID">工具编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetItemTypeByPK(int itemID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
			};
			return (int)GetScalar("`ItemType`", "`ItemID` = @ItemID", paras_, tm_);
		}
		public async Task<int> GetItemTypeByPKAsync(int itemID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`ItemType`", "`ItemID` = @ItemID", paras_, tm_);
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
		#region GetByName
		
		/// <summary>
		/// 按 Name（字段） 查询
		/// </summary>
		/// /// <param name = "name">工具名称</param>
		/// <return>实体对象集合</return>
		public List<Sat_itemEO> GetByName(string name)
		{
			return GetByName(name, 0, string.Empty, null);
		}
		public async Task<List<Sat_itemEO>> GetByNameAsync(string name)
		{
			return await GetByNameAsync(name, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Name（字段） 查询
		/// </summary>
		/// /// <param name = "name">工具名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_itemEO> GetByName(string name, TransactionManager tm_)
		{
			return GetByName(name, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_itemEO>> GetByNameAsync(string name, TransactionManager tm_)
		{
			return await GetByNameAsync(name, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Name（字段） 查询
		/// </summary>
		/// /// <param name = "name">工具名称</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_itemEO> GetByName(string name, int top_)
		{
			return GetByName(name, top_, string.Empty, null);
		}
		public async Task<List<Sat_itemEO>> GetByNameAsync(string name, int top_)
		{
			return await GetByNameAsync(name, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Name（字段） 查询
		/// </summary>
		/// /// <param name = "name">工具名称</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_itemEO> GetByName(string name, int top_, TransactionManager tm_)
		{
			return GetByName(name, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_itemEO>> GetByNameAsync(string name, int top_, TransactionManager tm_)
		{
			return await GetByNameAsync(name, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Name（字段） 查询
		/// </summary>
		/// /// <param name = "name">工具名称</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_itemEO> GetByName(string name, string sort_)
		{
			return GetByName(name, 0, sort_, null);
		}
		public async Task<List<Sat_itemEO>> GetByNameAsync(string name, string sort_)
		{
			return await GetByNameAsync(name, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Name（字段） 查询
		/// </summary>
		/// /// <param name = "name">工具名称</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_itemEO> GetByName(string name, string sort_, TransactionManager tm_)
		{
			return GetByName(name, 0, sort_, tm_);
		}
		public async Task<List<Sat_itemEO>> GetByNameAsync(string name, string sort_, TransactionManager tm_)
		{
			return await GetByNameAsync(name, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Name（字段） 查询
		/// </summary>
		/// /// <param name = "name">工具名称</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_itemEO> GetByName(string name, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(name != null ? "`Name` = @Name" : "`Name` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (name != null)
				paras_.Add(Database.CreateInParameter("@Name", name, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_itemEO.MapDataReader);
		}
		public async Task<List<Sat_itemEO>> GetByNameAsync(string name, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(name != null ? "`Name` = @Name" : "`Name` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (name != null)
				paras_.Add(Database.CreateInParameter("@Name", name, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_itemEO.MapDataReader);
		}
		#endregion // GetByName
		#region GetBySourceTypeID
		
		/// <summary>
		/// 按 SourceTypeID（字段） 查询
		/// </summary>
		/// /// <param name = "sourceTypeID">统计编码</param>
		/// <return>实体对象集合</return>
		public List<Sat_itemEO> GetBySourceTypeID(int sourceTypeID)
		{
			return GetBySourceTypeID(sourceTypeID, 0, string.Empty, null);
		}
		public async Task<List<Sat_itemEO>> GetBySourceTypeIDAsync(int sourceTypeID)
		{
			return await GetBySourceTypeIDAsync(sourceTypeID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SourceTypeID（字段） 查询
		/// </summary>
		/// /// <param name = "sourceTypeID">统计编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_itemEO> GetBySourceTypeID(int sourceTypeID, TransactionManager tm_)
		{
			return GetBySourceTypeID(sourceTypeID, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_itemEO>> GetBySourceTypeIDAsync(int sourceTypeID, TransactionManager tm_)
		{
			return await GetBySourceTypeIDAsync(sourceTypeID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SourceTypeID（字段） 查询
		/// </summary>
		/// /// <param name = "sourceTypeID">统计编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_itemEO> GetBySourceTypeID(int sourceTypeID, int top_)
		{
			return GetBySourceTypeID(sourceTypeID, top_, string.Empty, null);
		}
		public async Task<List<Sat_itemEO>> GetBySourceTypeIDAsync(int sourceTypeID, int top_)
		{
			return await GetBySourceTypeIDAsync(sourceTypeID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SourceTypeID（字段） 查询
		/// </summary>
		/// /// <param name = "sourceTypeID">统计编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_itemEO> GetBySourceTypeID(int sourceTypeID, int top_, TransactionManager tm_)
		{
			return GetBySourceTypeID(sourceTypeID, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_itemEO>> GetBySourceTypeIDAsync(int sourceTypeID, int top_, TransactionManager tm_)
		{
			return await GetBySourceTypeIDAsync(sourceTypeID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SourceTypeID（字段） 查询
		/// </summary>
		/// /// <param name = "sourceTypeID">统计编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_itemEO> GetBySourceTypeID(int sourceTypeID, string sort_)
		{
			return GetBySourceTypeID(sourceTypeID, 0, sort_, null);
		}
		public async Task<List<Sat_itemEO>> GetBySourceTypeIDAsync(int sourceTypeID, string sort_)
		{
			return await GetBySourceTypeIDAsync(sourceTypeID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 SourceTypeID（字段） 查询
		/// </summary>
		/// /// <param name = "sourceTypeID">统计编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_itemEO> GetBySourceTypeID(int sourceTypeID, string sort_, TransactionManager tm_)
		{
			return GetBySourceTypeID(sourceTypeID, 0, sort_, tm_);
		}
		public async Task<List<Sat_itemEO>> GetBySourceTypeIDAsync(int sourceTypeID, string sort_, TransactionManager tm_)
		{
			return await GetBySourceTypeIDAsync(sourceTypeID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 SourceTypeID（字段） 查询
		/// </summary>
		/// /// <param name = "sourceTypeID">统计编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_itemEO> GetBySourceTypeID(int sourceTypeID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SourceTypeID` = @SourceTypeID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SourceTypeID", sourceTypeID, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_itemEO.MapDataReader);
		}
		public async Task<List<Sat_itemEO>> GetBySourceTypeIDAsync(int sourceTypeID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SourceTypeID` = @SourceTypeID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SourceTypeID", sourceTypeID, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_itemEO.MapDataReader);
		}
		#endregion // GetBySourceTypeID
		#region GetByTriggerType
		
		/// <summary>
		/// 按 TriggerType（字段） 查询
		/// </summary>
		/// /// <param name = "triggerType">触发类型0 未知, 1消息, 2 自主定时,3 主动触发 API调用</param>
		/// <return>实体对象集合</return>
		public List<Sat_itemEO> GetByTriggerType(int triggerType)
		{
			return GetByTriggerType(triggerType, 0, string.Empty, null);
		}
		public async Task<List<Sat_itemEO>> GetByTriggerTypeAsync(int triggerType)
		{
			return await GetByTriggerTypeAsync(triggerType, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TriggerType（字段） 查询
		/// </summary>
		/// /// <param name = "triggerType">触发类型0 未知, 1消息, 2 自主定时,3 主动触发 API调用</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_itemEO> GetByTriggerType(int triggerType, TransactionManager tm_)
		{
			return GetByTriggerType(triggerType, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_itemEO>> GetByTriggerTypeAsync(int triggerType, TransactionManager tm_)
		{
			return await GetByTriggerTypeAsync(triggerType, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TriggerType（字段） 查询
		/// </summary>
		/// /// <param name = "triggerType">触发类型0 未知, 1消息, 2 自主定时,3 主动触发 API调用</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_itemEO> GetByTriggerType(int triggerType, int top_)
		{
			return GetByTriggerType(triggerType, top_, string.Empty, null);
		}
		public async Task<List<Sat_itemEO>> GetByTriggerTypeAsync(int triggerType, int top_)
		{
			return await GetByTriggerTypeAsync(triggerType, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TriggerType（字段） 查询
		/// </summary>
		/// /// <param name = "triggerType">触发类型0 未知, 1消息, 2 自主定时,3 主动触发 API调用</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_itemEO> GetByTriggerType(int triggerType, int top_, TransactionManager tm_)
		{
			return GetByTriggerType(triggerType, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_itemEO>> GetByTriggerTypeAsync(int triggerType, int top_, TransactionManager tm_)
		{
			return await GetByTriggerTypeAsync(triggerType, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TriggerType（字段） 查询
		/// </summary>
		/// /// <param name = "triggerType">触发类型0 未知, 1消息, 2 自主定时,3 主动触发 API调用</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_itemEO> GetByTriggerType(int triggerType, string sort_)
		{
			return GetByTriggerType(triggerType, 0, sort_, null);
		}
		public async Task<List<Sat_itemEO>> GetByTriggerTypeAsync(int triggerType, string sort_)
		{
			return await GetByTriggerTypeAsync(triggerType, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 TriggerType（字段） 查询
		/// </summary>
		/// /// <param name = "triggerType">触发类型0 未知, 1消息, 2 自主定时,3 主动触发 API调用</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_itemEO> GetByTriggerType(int triggerType, string sort_, TransactionManager tm_)
		{
			return GetByTriggerType(triggerType, 0, sort_, tm_);
		}
		public async Task<List<Sat_itemEO>> GetByTriggerTypeAsync(int triggerType, string sort_, TransactionManager tm_)
		{
			return await GetByTriggerTypeAsync(triggerType, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 TriggerType（字段） 查询
		/// </summary>
		/// /// <param name = "triggerType">触发类型0 未知, 1消息, 2 自主定时,3 主动触发 API调用</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_itemEO> GetByTriggerType(int triggerType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TriggerType` = @TriggerType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TriggerType", triggerType, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_itemEO.MapDataReader);
		}
		public async Task<List<Sat_itemEO>> GetByTriggerTypeAsync(int triggerType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TriggerType` = @TriggerType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TriggerType", triggerType, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_itemEO.MapDataReader);
		}
		#endregion // GetByTriggerType
		#region GetByItemType
		
		/// <summary>
		/// 按 ItemType（字段） 查询
		/// </summary>
		/// /// <param name = "itemType">工具类型 0未知 1-循环类,2-可完成类</param>
		/// <return>实体对象集合</return>
		public List<Sat_itemEO> GetByItemType(int itemType)
		{
			return GetByItemType(itemType, 0, string.Empty, null);
		}
		public async Task<List<Sat_itemEO>> GetByItemTypeAsync(int itemType)
		{
			return await GetByItemTypeAsync(itemType, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ItemType（字段） 查询
		/// </summary>
		/// /// <param name = "itemType">工具类型 0未知 1-循环类,2-可完成类</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_itemEO> GetByItemType(int itemType, TransactionManager tm_)
		{
			return GetByItemType(itemType, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_itemEO>> GetByItemTypeAsync(int itemType, TransactionManager tm_)
		{
			return await GetByItemTypeAsync(itemType, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ItemType（字段） 查询
		/// </summary>
		/// /// <param name = "itemType">工具类型 0未知 1-循环类,2-可完成类</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_itemEO> GetByItemType(int itemType, int top_)
		{
			return GetByItemType(itemType, top_, string.Empty, null);
		}
		public async Task<List<Sat_itemEO>> GetByItemTypeAsync(int itemType, int top_)
		{
			return await GetByItemTypeAsync(itemType, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ItemType（字段） 查询
		/// </summary>
		/// /// <param name = "itemType">工具类型 0未知 1-循环类,2-可完成类</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_itemEO> GetByItemType(int itemType, int top_, TransactionManager tm_)
		{
			return GetByItemType(itemType, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_itemEO>> GetByItemTypeAsync(int itemType, int top_, TransactionManager tm_)
		{
			return await GetByItemTypeAsync(itemType, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ItemType（字段） 查询
		/// </summary>
		/// /// <param name = "itemType">工具类型 0未知 1-循环类,2-可完成类</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_itemEO> GetByItemType(int itemType, string sort_)
		{
			return GetByItemType(itemType, 0, sort_, null);
		}
		public async Task<List<Sat_itemEO>> GetByItemTypeAsync(int itemType, string sort_)
		{
			return await GetByItemTypeAsync(itemType, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ItemType（字段） 查询
		/// </summary>
		/// /// <param name = "itemType">工具类型 0未知 1-循环类,2-可完成类</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_itemEO> GetByItemType(int itemType, string sort_, TransactionManager tm_)
		{
			return GetByItemType(itemType, 0, sort_, tm_);
		}
		public async Task<List<Sat_itemEO>> GetByItemTypeAsync(int itemType, string sort_, TransactionManager tm_)
		{
			return await GetByItemTypeAsync(itemType, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ItemType（字段） 查询
		/// </summary>
		/// /// <param name = "itemType">工具类型 0未知 1-循环类,2-可完成类</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_itemEO> GetByItemType(int itemType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ItemType` = @ItemType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ItemType", itemType, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_itemEO.MapDataReader);
		}
		public async Task<List<Sat_itemEO>> GetByItemTypeAsync(int itemType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ItemType` = @ItemType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ItemType", itemType, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_itemEO.MapDataReader);
		}
		#endregion // GetByItemType
		#region GetByStatus
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <return>实体对象集合</return>
		public List<Sat_itemEO> GetByStatus(int status)
		{
			return GetByStatus(status, 0, string.Empty, null);
		}
		public async Task<List<Sat_itemEO>> GetByStatusAsync(int status)
		{
			return await GetByStatusAsync(status, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_itemEO> GetByStatus(int status, TransactionManager tm_)
		{
			return GetByStatus(status, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_itemEO>> GetByStatusAsync(int status, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_itemEO> GetByStatus(int status, int top_)
		{
			return GetByStatus(status, top_, string.Empty, null);
		}
		public async Task<List<Sat_itemEO>> GetByStatusAsync(int status, int top_)
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
		public List<Sat_itemEO> GetByStatus(int status, int top_, TransactionManager tm_)
		{
			return GetByStatus(status, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_itemEO>> GetByStatusAsync(int status, int top_, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_itemEO> GetByStatus(int status, string sort_)
		{
			return GetByStatus(status, 0, sort_, null);
		}
		public async Task<List<Sat_itemEO>> GetByStatusAsync(int status, string sort_)
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
		public List<Sat_itemEO> GetByStatus(int status, string sort_, TransactionManager tm_)
		{
			return GetByStatus(status, 0, sort_, tm_);
		}
		public async Task<List<Sat_itemEO>> GetByStatusAsync(int status, string sort_, TransactionManager tm_)
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
		public List<Sat_itemEO> GetByStatus(int status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_itemEO.MapDataReader);
		}
		public async Task<List<Sat_itemEO>> GetByStatusAsync(int status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_itemEO.MapDataReader);
		}
		#endregion // GetByStatus
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录日期</param>
		/// <return>实体对象集合</return>
		public List<Sat_itemEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<Sat_itemEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录日期</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_itemEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_itemEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录日期</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_itemEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<Sat_itemEO>> GetByRecDateAsync(DateTime recDate, int top_)
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
		public List<Sat_itemEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_itemEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录日期</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_itemEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<Sat_itemEO>> GetByRecDateAsync(DateTime recDate, string sort_)
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
		public List<Sat_itemEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<Sat_itemEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
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
		public List<Sat_itemEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_itemEO.MapDataReader);
		}
		public async Task<List<Sat_itemEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_itemEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
