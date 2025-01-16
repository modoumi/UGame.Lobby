/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * AiUo代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/AiUo
 * 文档生成时间：2024-01-23 18: 29:13
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
	/// app类别表
	/// 【表 l_category 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class L_categoryEO : IRowMapper<L_categoryEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public L_categoryEO()
		{
			this.OrderNum = 0;
			this.LevelNum = 0;
			this.Template = 0;
			this.RecDate = DateTime.Now;
			this.TopLevelType = 0;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private long _originalCategoryID;
		/// <summary>
		/// 【数据库中的原始主键 CategoryID 值的副本，用于主键值更新】
		/// </summary>
		public long OriginalCategoryID
		{
			get { return _originalCategoryID; }
			set { HasOriginal = true; _originalCategoryID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "CategoryID", CategoryID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 
		/// 【主键 bigint】
		/// </summary>
		[DataMember(Order = 1)]
		public long CategoryID { get; set; }
		/// <summary>
		/// 运营商编码(null为默认)
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
		/// 分类名称
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 4)]
		public string Name { get; set; }
		/// <summary>
		/// 排序（从小到大）
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 5)]
		public int OrderNum { get; set; }
		/// <summary>
		/// 分类级别1开始
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 6)]
		public int LevelNum { get; set; }
		/// <summary>
		/// 父节点ID
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 7)]
		public long? ParentId { get; set; }
		/// <summary>
		/// 显示模板
		/// 1、6*3
		/// 2、3*3
		/// 3、5*3
		/// 4、3*40
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 8)]
		public int Template { get; set; }
		/// <summary>
		/// 游戏分类图标
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 9)]
		public string CategoryIcon { get; set; }
		/// <summary>
		/// 记录时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 10)]
		public DateTime RecDate { get; set; }
		/// <summary>
		/// 顶级分类类型
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 11)]
		public int TopLevelType { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public L_categoryEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static L_categoryEO MapDataReader(IDataReader reader)
		{
		    L_categoryEO ret = new L_categoryEO();
			ret.CategoryID = reader.ToInt64("CategoryID");
			ret.OriginalCategoryID = ret.CategoryID;
			ret.OperatorID = reader.ToString("OperatorID");
			ret.LangID = reader.ToString("LangID");
			ret.Name = reader.ToString("Name");
			ret.OrderNum = reader.ToInt32("OrderNum");
			ret.LevelNum = reader.ToInt32("LevelNum");
			ret.ParentId = reader.ToInt64N("ParentId");
			ret.Template = reader.ToInt32("Template");
			ret.CategoryIcon = reader.ToString("CategoryIcon");
			ret.RecDate = reader.ToDateTime("RecDate");
			ret.TopLevelType = reader.ToInt32("TopLevelType");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// app类别表
	/// 【表 l_category 的操作类】
	/// </summary>
	[Obsolete]
	public class L_categoryMO : MySqlTableMO<L_categoryEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`l_category`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public L_categoryMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public L_categoryMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public L_categoryMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(L_categoryEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			item.CategoryID = Database.ExecSqlScalar<long>(sql_, paras_, tm_); 
			return 1;
		}
		public override async Task<int> AddAsync(L_categoryEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			item.CategoryID = await Database.ExecSqlScalarAsync<long>(sql_, paras_, tm_); 
	        return 1;
		}
	    private void RepairAddData(L_categoryEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`OperatorID`, `LangID`, `Name`, `OrderNum`, `LevelNum`, `ParentId`, `Template`, `CategoryIcon`, `RecDate`, `TopLevelType`) VALUE (@OperatorID, @LangID, @Name, @OrderNum, @LevelNum, @ParentId, @Template, @CategoryIcon, @RecDate, @TopLevelType);SELECT LAST_INSERT_ID();";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", item.OperatorID != null ? item.OperatorID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", item.LangID != null ? item.LangID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Name", item.Name != null ? item.Name : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OrderNum", item.OrderNum, MySqlDbType.Int32),
				Database.CreateInParameter("@LevelNum", item.LevelNum, MySqlDbType.Int32),
				Database.CreateInParameter("@ParentId", item.ParentId.HasValue ? item.ParentId.Value : (object)DBNull.Value, MySqlDbType.Int64),
				Database.CreateInParameter("@Template", item.Template, MySqlDbType.Int32),
				Database.CreateInParameter("@CategoryIcon", item.CategoryIcon, MySqlDbType.VarChar),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@TopLevelType", item.TopLevelType, MySqlDbType.Int32),
			};
		}
		public int AddByBatch(IEnumerable<L_categoryEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<L_categoryEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<L_categoryEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`CategoryID`, `OperatorID`, `LangID`, `Name`, `OrderNum`, `LevelNum`, `ParentId`, `Template`, `CategoryIcon`, `RecDate`, `TopLevelType`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"({item.CategoryID},'{item.OperatorID}','{item.LangID}','{item.Name}',{item.OrderNum},{item.LevelNum},{item.ParentId?.ToString()??null},{item.Template},'{item.CategoryIcon}','{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}',{item.TopLevelType}),");
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
		/// /// <param name = "categoryID"></param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(long categoryID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(categoryID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(long categoryID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(categoryID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(long categoryID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `CategoryID` = @CategoryID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CategoryID", categoryID, MySqlDbType.Int64),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(L_categoryEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.CategoryID, tm_);
		}
		public async Task<int> RemoveAsync(L_categoryEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.CategoryID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByOperatorID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "operatorID">运营商编码(null为默认)</param>
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
		#region RemoveByName
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "name">分类名称</param>
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
		#region RemoveByLevelNum
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "levelNum">分类级别1开始</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByLevelNum(int levelNum, TransactionManager tm_ = null)
		{
			RepairRemoveByLevelNumData(levelNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByLevelNumAsync(int levelNum, TransactionManager tm_ = null)
		{
			RepairRemoveByLevelNumData(levelNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByLevelNumData(int levelNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `LevelNum` = @LevelNum";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LevelNum", levelNum, MySqlDbType.Int32));
		}
		#endregion // RemoveByLevelNum
		#region RemoveByParentId
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "parentId">父节点ID</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByParentId(long? parentId, TransactionManager tm_ = null)
		{
			RepairRemoveByParentIdData(parentId.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByParentIdAsync(long? parentId, TransactionManager tm_ = null)
		{
			RepairRemoveByParentIdData(parentId.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByParentIdData(long? parentId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (parentId.HasValue ? "`ParentId` = @ParentId" : "`ParentId` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (parentId.HasValue)
				paras_.Add(Database.CreateInParameter("@ParentId", parentId.Value, MySqlDbType.Int64));
		}
		#endregion // RemoveByParentId
		#region RemoveByTemplate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "template">显示模板</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTemplate(int template, TransactionManager tm_ = null)
		{
			RepairRemoveByTemplateData(template, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTemplateAsync(int template, TransactionManager tm_ = null)
		{
			RepairRemoveByTemplateData(template, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTemplateData(int template, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Template` = @Template";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Template", template, MySqlDbType.Int32));
		}
		#endregion // RemoveByTemplate
		#region RemoveByCategoryIcon
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "categoryIcon">游戏分类图标</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCategoryIcon(string categoryIcon, TransactionManager tm_ = null)
		{
			RepairRemoveByCategoryIconData(categoryIcon, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCategoryIconAsync(string categoryIcon, TransactionManager tm_ = null)
		{
			RepairRemoveByCategoryIconData(categoryIcon, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCategoryIconData(string categoryIcon, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `CategoryIcon` = @CategoryIcon";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CategoryIcon", categoryIcon, MySqlDbType.VarChar));
		}
		#endregion // RemoveByCategoryIcon
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
		#region RemoveByTopLevelType
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "topLevelType">顶级分类类型</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTopLevelType(int topLevelType, TransactionManager tm_ = null)
		{
			RepairRemoveByTopLevelTypeData(topLevelType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTopLevelTypeAsync(int topLevelType, TransactionManager tm_ = null)
		{
			RepairRemoveByTopLevelTypeData(topLevelType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTopLevelTypeData(int topLevelType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `TopLevelType` = @TopLevelType";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TopLevelType", topLevelType, MySqlDbType.Int32));
		}
		#endregion // RemoveByTopLevelType
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
		public int Put(L_categoryEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(L_categoryEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(L_categoryEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID, `LangID` = @LangID, `Name` = @Name, `OrderNum` = @OrderNum, `LevelNum` = @LevelNum, `ParentId` = @ParentId, `Template` = @Template, `CategoryIcon` = @CategoryIcon, `TopLevelType` = @TopLevelType WHERE `CategoryID` = @CategoryID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", item.OperatorID != null ? item.OperatorID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", item.LangID != null ? item.LangID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Name", item.Name != null ? item.Name : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OrderNum", item.OrderNum, MySqlDbType.Int32),
				Database.CreateInParameter("@LevelNum", item.LevelNum, MySqlDbType.Int32),
				Database.CreateInParameter("@ParentId", item.ParentId.HasValue ? item.ParentId.Value : (object)DBNull.Value, MySqlDbType.Int64),
				Database.CreateInParameter("@Template", item.Template, MySqlDbType.Int32),
				Database.CreateInParameter("@CategoryIcon", item.CategoryIcon, MySqlDbType.VarChar),
				Database.CreateInParameter("@TopLevelType", item.TopLevelType, MySqlDbType.Int32),
				Database.CreateInParameter("@CategoryID_Original", item.HasOriginal ? item.OriginalCategoryID : item.CategoryID, MySqlDbType.Int64),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<L_categoryEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<L_categoryEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "categoryID"></param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(long categoryID, string set_, params object[] values_)
		{
			return Put(set_, "`CategoryID` = @CategoryID", ConcatValues(values_, categoryID));
		}
		public async Task<int> PutByPKAsync(long categoryID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`CategoryID` = @CategoryID", ConcatValues(values_, categoryID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "categoryID"></param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(long categoryID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`CategoryID` = @CategoryID", tm_, ConcatValues(values_, categoryID));
		}
		public async Task<int> PutByPKAsync(long categoryID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`CategoryID` = @CategoryID", tm_, ConcatValues(values_, categoryID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "categoryID"></param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(long categoryID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@CategoryID", categoryID, MySqlDbType.Int64),
	        };
			return Put(set_, "`CategoryID` = @CategoryID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(long categoryID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@CategoryID", categoryID, MySqlDbType.Int64),
	        };
			return await PutAsync(set_, "`CategoryID` = @CategoryID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutOperatorID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "categoryID"></param>
		/// /// <param name = "operatorID">运营商编码(null为默认)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorIDByPK(long categoryID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(categoryID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOperatorIDByPKAsync(long categoryID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(categoryID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOperatorIDByPKData(long categoryID, string operatorID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID  WHERE `CategoryID` = @CategoryID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID != null ? operatorID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CategoryID", categoryID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码(null为默认)</param>
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
		#region PutLangID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "categoryID"></param>
		/// /// <param name = "langID">语言代码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLangIDByPK(long categoryID, string langID, TransactionManager tm_ = null)
		{
			RepairPutLangIDByPKData(categoryID, langID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLangIDByPKAsync(long categoryID, string langID, TransactionManager tm_ = null)
		{
			RepairPutLangIDByPKData(categoryID, langID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLangIDByPKData(long categoryID, string langID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `LangID` = @LangID  WHERE `CategoryID` = @CategoryID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LangID", langID != null ? langID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CategoryID", categoryID, MySqlDbType.Int64),
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
		#region PutName
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "categoryID"></param>
		/// /// <param name = "name">分类名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutNameByPK(long categoryID, string name, TransactionManager tm_ = null)
		{
			RepairPutNameByPKData(categoryID, name, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutNameByPKAsync(long categoryID, string name, TransactionManager tm_ = null)
		{
			RepairPutNameByPKData(categoryID, name, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutNameByPKData(long categoryID, string name, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Name` = @Name  WHERE `CategoryID` = @CategoryID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Name", name != null ? name : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CategoryID", categoryID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "name">分类名称</param>
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
		#region PutOrderNum
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "categoryID"></param>
		/// /// <param name = "orderNum">排序（从小到大）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOrderNumByPK(long categoryID, int orderNum, TransactionManager tm_ = null)
		{
			RepairPutOrderNumByPKData(categoryID, orderNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOrderNumByPKAsync(long categoryID, int orderNum, TransactionManager tm_ = null)
		{
			RepairPutOrderNumByPKData(categoryID, orderNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOrderNumByPKData(long categoryID, int orderNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OrderNum` = @OrderNum  WHERE `CategoryID` = @CategoryID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderNum", orderNum, MySqlDbType.Int32),
				Database.CreateInParameter("@CategoryID", categoryID, MySqlDbType.Int64),
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
		#region PutLevelNum
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "categoryID"></param>
		/// /// <param name = "levelNum">分类级别1开始</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLevelNumByPK(long categoryID, int levelNum, TransactionManager tm_ = null)
		{
			RepairPutLevelNumByPKData(categoryID, levelNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLevelNumByPKAsync(long categoryID, int levelNum, TransactionManager tm_ = null)
		{
			RepairPutLevelNumByPKData(categoryID, levelNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLevelNumByPKData(long categoryID, int levelNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `LevelNum` = @LevelNum  WHERE `CategoryID` = @CategoryID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LevelNum", levelNum, MySqlDbType.Int32),
				Database.CreateInParameter("@CategoryID", categoryID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "levelNum">分类级别1开始</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLevelNum(int levelNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LevelNum` = @LevelNum";
			var parameter_ = Database.CreateInParameter("@LevelNum", levelNum, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutLevelNumAsync(int levelNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LevelNum` = @LevelNum";
			var parameter_ = Database.CreateInParameter("@LevelNum", levelNum, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutLevelNum
		#region PutParentId
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "categoryID"></param>
		/// /// <param name = "parentId">父节点ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutParentIdByPK(long categoryID, long? parentId, TransactionManager tm_ = null)
		{
			RepairPutParentIdByPKData(categoryID, parentId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutParentIdByPKAsync(long categoryID, long? parentId, TransactionManager tm_ = null)
		{
			RepairPutParentIdByPKData(categoryID, parentId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutParentIdByPKData(long categoryID, long? parentId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ParentId` = @ParentId  WHERE `CategoryID` = @CategoryID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ParentId", parentId.HasValue ? parentId.Value : (object)DBNull.Value, MySqlDbType.Int64),
				Database.CreateInParameter("@CategoryID", categoryID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "parentId">父节点ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutParentId(long? parentId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ParentId` = @ParentId";
			var parameter_ = Database.CreateInParameter("@ParentId", parentId.HasValue ? parentId.Value : (object)DBNull.Value, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutParentIdAsync(long? parentId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ParentId` = @ParentId";
			var parameter_ = Database.CreateInParameter("@ParentId", parentId.HasValue ? parentId.Value : (object)DBNull.Value, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutParentId
		#region PutTemplate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "categoryID"></param>
		/// /// <param name = "template">显示模板</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTemplateByPK(long categoryID, int template, TransactionManager tm_ = null)
		{
			RepairPutTemplateByPKData(categoryID, template, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTemplateByPKAsync(long categoryID, int template, TransactionManager tm_ = null)
		{
			RepairPutTemplateByPKData(categoryID, template, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTemplateByPKData(long categoryID, int template, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Template` = @Template  WHERE `CategoryID` = @CategoryID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Template", template, MySqlDbType.Int32),
				Database.CreateInParameter("@CategoryID", categoryID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "template">显示模板</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTemplate(int template, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Template` = @Template";
			var parameter_ = Database.CreateInParameter("@Template", template, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTemplateAsync(int template, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Template` = @Template";
			var parameter_ = Database.CreateInParameter("@Template", template, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTemplate
		#region PutCategoryIcon
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "categoryID"></param>
		/// /// <param name = "categoryIcon">游戏分类图标</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCategoryIconByPK(long categoryID, string categoryIcon, TransactionManager tm_ = null)
		{
			RepairPutCategoryIconByPKData(categoryID, categoryIcon, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCategoryIconByPKAsync(long categoryID, string categoryIcon, TransactionManager tm_ = null)
		{
			RepairPutCategoryIconByPKData(categoryID, categoryIcon, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCategoryIconByPKData(long categoryID, string categoryIcon, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CategoryIcon` = @CategoryIcon  WHERE `CategoryID` = @CategoryID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CategoryIcon", categoryIcon, MySqlDbType.VarChar),
				Database.CreateInParameter("@CategoryID", categoryID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "categoryIcon">游戏分类图标</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCategoryIcon(string categoryIcon, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CategoryIcon` = @CategoryIcon";
			var parameter_ = Database.CreateInParameter("@CategoryIcon", categoryIcon, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCategoryIconAsync(string categoryIcon, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CategoryIcon` = @CategoryIcon";
			var parameter_ = Database.CreateInParameter("@CategoryIcon", categoryIcon, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCategoryIcon
		#region PutRecDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "categoryID"></param>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(long categoryID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(categoryID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(long categoryID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(categoryID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(long categoryID, DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `CategoryID` = @CategoryID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@CategoryID", categoryID, MySqlDbType.Int64),
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
		#region PutTopLevelType
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "categoryID"></param>
		/// /// <param name = "topLevelType">顶级分类类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTopLevelTypeByPK(long categoryID, int topLevelType, TransactionManager tm_ = null)
		{
			RepairPutTopLevelTypeByPKData(categoryID, topLevelType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTopLevelTypeByPKAsync(long categoryID, int topLevelType, TransactionManager tm_ = null)
		{
			RepairPutTopLevelTypeByPKData(categoryID, topLevelType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTopLevelTypeByPKData(long categoryID, int topLevelType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `TopLevelType` = @TopLevelType  WHERE `CategoryID` = @CategoryID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TopLevelType", topLevelType, MySqlDbType.Int32),
				Database.CreateInParameter("@CategoryID", categoryID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "topLevelType">顶级分类类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTopLevelType(int topLevelType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TopLevelType` = @TopLevelType";
			var parameter_ = Database.CreateInParameter("@TopLevelType", topLevelType, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTopLevelTypeAsync(int topLevelType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TopLevelType` = @TopLevelType";
			var parameter_ = Database.CreateInParameter("@TopLevelType", topLevelType, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTopLevelType
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(L_categoryEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.CategoryID) == null)
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
		public async Task<bool> SetAsync(L_categoryEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.CategoryID) == null)
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
		/// /// <param name = "categoryID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public L_categoryEO GetByPK(long categoryID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(categoryID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, L_categoryEO.MapDataReader);
		}
		public async Task<L_categoryEO> GetByPKAsync(long categoryID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(categoryID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, L_categoryEO.MapDataReader);
		}
		private void RepairGetByPKData(long categoryID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`CategoryID` = @CategoryID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CategoryID", categoryID, MySqlDbType.Int64),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 OperatorID（字段）
		/// </summary>
		/// /// <param name = "categoryID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorIDByPK(long categoryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CategoryID", categoryID, MySqlDbType.Int64),
			};
			return (string)GetScalar("`OperatorID`", "`CategoryID` = @CategoryID", paras_, tm_);
		}
		public async Task<string> GetOperatorIDByPKAsync(long categoryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CategoryID", categoryID, MySqlDbType.Int64),
			};
			return (string)await GetScalarAsync("`OperatorID`", "`CategoryID` = @CategoryID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 LangID（字段）
		/// </summary>
		/// /// <param name = "categoryID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetLangIDByPK(long categoryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CategoryID", categoryID, MySqlDbType.Int64),
			};
			return (string)GetScalar("`LangID`", "`CategoryID` = @CategoryID", paras_, tm_);
		}
		public async Task<string> GetLangIDByPKAsync(long categoryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CategoryID", categoryID, MySqlDbType.Int64),
			};
			return (string)await GetScalarAsync("`LangID`", "`CategoryID` = @CategoryID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Name（字段）
		/// </summary>
		/// /// <param name = "categoryID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetNameByPK(long categoryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CategoryID", categoryID, MySqlDbType.Int64),
			};
			return (string)GetScalar("`Name`", "`CategoryID` = @CategoryID", paras_, tm_);
		}
		public async Task<string> GetNameByPKAsync(long categoryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CategoryID", categoryID, MySqlDbType.Int64),
			};
			return (string)await GetScalarAsync("`Name`", "`CategoryID` = @CategoryID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OrderNum（字段）
		/// </summary>
		/// /// <param name = "categoryID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetOrderNumByPK(long categoryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CategoryID", categoryID, MySqlDbType.Int64),
			};
			return (int)GetScalar("`OrderNum`", "`CategoryID` = @CategoryID", paras_, tm_);
		}
		public async Task<int> GetOrderNumByPKAsync(long categoryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CategoryID", categoryID, MySqlDbType.Int64),
			};
			return (int)await GetScalarAsync("`OrderNum`", "`CategoryID` = @CategoryID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 LevelNum（字段）
		/// </summary>
		/// /// <param name = "categoryID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetLevelNumByPK(long categoryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CategoryID", categoryID, MySqlDbType.Int64),
			};
			return (int)GetScalar("`LevelNum`", "`CategoryID` = @CategoryID", paras_, tm_);
		}
		public async Task<int> GetLevelNumByPKAsync(long categoryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CategoryID", categoryID, MySqlDbType.Int64),
			};
			return (int)await GetScalarAsync("`LevelNum`", "`CategoryID` = @CategoryID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ParentId（字段）
		/// </summary>
		/// /// <param name = "categoryID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long? GetParentIdByPK(long categoryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CategoryID", categoryID, MySqlDbType.Int64),
			};
			return (long?)GetScalar("`ParentId`", "`CategoryID` = @CategoryID", paras_, tm_);
		}
		public async Task<long?> GetParentIdByPKAsync(long categoryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CategoryID", categoryID, MySqlDbType.Int64),
			};
			return (long?)await GetScalarAsync("`ParentId`", "`CategoryID` = @CategoryID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Template（字段）
		/// </summary>
		/// /// <param name = "categoryID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetTemplateByPK(long categoryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CategoryID", categoryID, MySqlDbType.Int64),
			};
			return (int)GetScalar("`Template`", "`CategoryID` = @CategoryID", paras_, tm_);
		}
		public async Task<int> GetTemplateByPKAsync(long categoryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CategoryID", categoryID, MySqlDbType.Int64),
			};
			return (int)await GetScalarAsync("`Template`", "`CategoryID` = @CategoryID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CategoryIcon（字段）
		/// </summary>
		/// /// <param name = "categoryID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCategoryIconByPK(long categoryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CategoryID", categoryID, MySqlDbType.Int64),
			};
			return (string)GetScalar("`CategoryIcon`", "`CategoryID` = @CategoryID", paras_, tm_);
		}
		public async Task<string> GetCategoryIconByPKAsync(long categoryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CategoryID", categoryID, MySqlDbType.Int64),
			};
			return (string)await GetScalarAsync("`CategoryIcon`", "`CategoryID` = @CategoryID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "categoryID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetRecDateByPK(long categoryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CategoryID", categoryID, MySqlDbType.Int64),
			};
			return (DateTime)GetScalar("`RecDate`", "`CategoryID` = @CategoryID", paras_, tm_);
		}
		public async Task<DateTime> GetRecDateByPKAsync(long categoryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CategoryID", categoryID, MySqlDbType.Int64),
			};
			return (DateTime)await GetScalarAsync("`RecDate`", "`CategoryID` = @CategoryID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 TopLevelType（字段）
		/// </summary>
		/// /// <param name = "categoryID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetTopLevelTypeByPK(long categoryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CategoryID", categoryID, MySqlDbType.Int64),
			};
			return (int)GetScalar("`TopLevelType`", "`CategoryID` = @CategoryID", paras_, tm_);
		}
		public async Task<int> GetTopLevelTypeByPKAsync(long categoryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CategoryID", categoryID, MySqlDbType.Int64),
			};
			return (int)await GetScalarAsync("`TopLevelType`", "`CategoryID` = @CategoryID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码(null为默认)</param>
		/// <return>实体对象集合</return>
		public List<L_categoryEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<L_categoryEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码(null为默认)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_categoryEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<L_categoryEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码(null为默认)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_categoryEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<L_categoryEO>> GetByOperatorIDAsync(string operatorID, int top_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码(null为默认)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_categoryEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<L_categoryEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码(null为默认)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_categoryEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<L_categoryEO>> GetByOperatorIDAsync(string operatorID, string sort_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码(null为默认)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_categoryEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<L_categoryEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码(null为默认)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_categoryEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operatorID != null ? "`OperatorID` = @OperatorID" : "`OperatorID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operatorID != null)
				paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_categoryEO.MapDataReader);
		}
		public async Task<List<L_categoryEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operatorID != null ? "`OperatorID` = @OperatorID" : "`OperatorID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operatorID != null)
				paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_categoryEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByLangID
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言代码</param>
		/// <return>实体对象集合</return>
		public List<L_categoryEO> GetByLangID(string langID)
		{
			return GetByLangID(langID, 0, string.Empty, null);
		}
		public async Task<List<L_categoryEO>> GetByLangIDAsync(string langID)
		{
			return await GetByLangIDAsync(langID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言代码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_categoryEO> GetByLangID(string langID, TransactionManager tm_)
		{
			return GetByLangID(langID, 0, string.Empty, tm_);
		}
		public async Task<List<L_categoryEO>> GetByLangIDAsync(string langID, TransactionManager tm_)
		{
			return await GetByLangIDAsync(langID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言代码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_categoryEO> GetByLangID(string langID, int top_)
		{
			return GetByLangID(langID, top_, string.Empty, null);
		}
		public async Task<List<L_categoryEO>> GetByLangIDAsync(string langID, int top_)
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
		public List<L_categoryEO> GetByLangID(string langID, int top_, TransactionManager tm_)
		{
			return GetByLangID(langID, top_, string.Empty, tm_);
		}
		public async Task<List<L_categoryEO>> GetByLangIDAsync(string langID, int top_, TransactionManager tm_)
		{
			return await GetByLangIDAsync(langID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言代码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_categoryEO> GetByLangID(string langID, string sort_)
		{
			return GetByLangID(langID, 0, sort_, null);
		}
		public async Task<List<L_categoryEO>> GetByLangIDAsync(string langID, string sort_)
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
		public List<L_categoryEO> GetByLangID(string langID, string sort_, TransactionManager tm_)
		{
			return GetByLangID(langID, 0, sort_, tm_);
		}
		public async Task<List<L_categoryEO>> GetByLangIDAsync(string langID, string sort_, TransactionManager tm_)
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
		public List<L_categoryEO> GetByLangID(string langID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(langID != null ? "`LangID` = @LangID" : "`LangID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (langID != null)
				paras_.Add(Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_categoryEO.MapDataReader);
		}
		public async Task<List<L_categoryEO>> GetByLangIDAsync(string langID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(langID != null ? "`LangID` = @LangID" : "`LangID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (langID != null)
				paras_.Add(Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_categoryEO.MapDataReader);
		}
		#endregion // GetByLangID
		#region GetByName
		
		/// <summary>
		/// 按 Name（字段） 查询
		/// </summary>
		/// /// <param name = "name">分类名称</param>
		/// <return>实体对象集合</return>
		public List<L_categoryEO> GetByName(string name)
		{
			return GetByName(name, 0, string.Empty, null);
		}
		public async Task<List<L_categoryEO>> GetByNameAsync(string name)
		{
			return await GetByNameAsync(name, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Name（字段） 查询
		/// </summary>
		/// /// <param name = "name">分类名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_categoryEO> GetByName(string name, TransactionManager tm_)
		{
			return GetByName(name, 0, string.Empty, tm_);
		}
		public async Task<List<L_categoryEO>> GetByNameAsync(string name, TransactionManager tm_)
		{
			return await GetByNameAsync(name, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Name（字段） 查询
		/// </summary>
		/// /// <param name = "name">分类名称</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_categoryEO> GetByName(string name, int top_)
		{
			return GetByName(name, top_, string.Empty, null);
		}
		public async Task<List<L_categoryEO>> GetByNameAsync(string name, int top_)
		{
			return await GetByNameAsync(name, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Name（字段） 查询
		/// </summary>
		/// /// <param name = "name">分类名称</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_categoryEO> GetByName(string name, int top_, TransactionManager tm_)
		{
			return GetByName(name, top_, string.Empty, tm_);
		}
		public async Task<List<L_categoryEO>> GetByNameAsync(string name, int top_, TransactionManager tm_)
		{
			return await GetByNameAsync(name, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Name（字段） 查询
		/// </summary>
		/// /// <param name = "name">分类名称</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_categoryEO> GetByName(string name, string sort_)
		{
			return GetByName(name, 0, sort_, null);
		}
		public async Task<List<L_categoryEO>> GetByNameAsync(string name, string sort_)
		{
			return await GetByNameAsync(name, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Name（字段） 查询
		/// </summary>
		/// /// <param name = "name">分类名称</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_categoryEO> GetByName(string name, string sort_, TransactionManager tm_)
		{
			return GetByName(name, 0, sort_, tm_);
		}
		public async Task<List<L_categoryEO>> GetByNameAsync(string name, string sort_, TransactionManager tm_)
		{
			return await GetByNameAsync(name, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Name（字段） 查询
		/// </summary>
		/// /// <param name = "name">分类名称</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_categoryEO> GetByName(string name, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(name != null ? "`Name` = @Name" : "`Name` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (name != null)
				paras_.Add(Database.CreateInParameter("@Name", name, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_categoryEO.MapDataReader);
		}
		public async Task<List<L_categoryEO>> GetByNameAsync(string name, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(name != null ? "`Name` = @Name" : "`Name` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (name != null)
				paras_.Add(Database.CreateInParameter("@Name", name, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_categoryEO.MapDataReader);
		}
		#endregion // GetByName
		#region GetByOrderNum
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序（从小到大）</param>
		/// <return>实体对象集合</return>
		public List<L_categoryEO> GetByOrderNum(int orderNum)
		{
			return GetByOrderNum(orderNum, 0, string.Empty, null);
		}
		public async Task<List<L_categoryEO>> GetByOrderNumAsync(int orderNum)
		{
			return await GetByOrderNumAsync(orderNum, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序（从小到大）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_categoryEO> GetByOrderNum(int orderNum, TransactionManager tm_)
		{
			return GetByOrderNum(orderNum, 0, string.Empty, tm_);
		}
		public async Task<List<L_categoryEO>> GetByOrderNumAsync(int orderNum, TransactionManager tm_)
		{
			return await GetByOrderNumAsync(orderNum, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序（从小到大）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_categoryEO> GetByOrderNum(int orderNum, int top_)
		{
			return GetByOrderNum(orderNum, top_, string.Empty, null);
		}
		public async Task<List<L_categoryEO>> GetByOrderNumAsync(int orderNum, int top_)
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
		public List<L_categoryEO> GetByOrderNum(int orderNum, int top_, TransactionManager tm_)
		{
			return GetByOrderNum(orderNum, top_, string.Empty, tm_);
		}
		public async Task<List<L_categoryEO>> GetByOrderNumAsync(int orderNum, int top_, TransactionManager tm_)
		{
			return await GetByOrderNumAsync(orderNum, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序（从小到大）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_categoryEO> GetByOrderNum(int orderNum, string sort_)
		{
			return GetByOrderNum(orderNum, 0, sort_, null);
		}
		public async Task<List<L_categoryEO>> GetByOrderNumAsync(int orderNum, string sort_)
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
		public List<L_categoryEO> GetByOrderNum(int orderNum, string sort_, TransactionManager tm_)
		{
			return GetByOrderNum(orderNum, 0, sort_, tm_);
		}
		public async Task<List<L_categoryEO>> GetByOrderNumAsync(int orderNum, string sort_, TransactionManager tm_)
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
		public List<L_categoryEO> GetByOrderNum(int orderNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OrderNum` = @OrderNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OrderNum", orderNum, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, L_categoryEO.MapDataReader);
		}
		public async Task<List<L_categoryEO>> GetByOrderNumAsync(int orderNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OrderNum` = @OrderNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OrderNum", orderNum, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_categoryEO.MapDataReader);
		}
		#endregion // GetByOrderNum
		#region GetByLevelNum
		
		/// <summary>
		/// 按 LevelNum（字段） 查询
		/// </summary>
		/// /// <param name = "levelNum">分类级别1开始</param>
		/// <return>实体对象集合</return>
		public List<L_categoryEO> GetByLevelNum(int levelNum)
		{
			return GetByLevelNum(levelNum, 0, string.Empty, null);
		}
		public async Task<List<L_categoryEO>> GetByLevelNumAsync(int levelNum)
		{
			return await GetByLevelNumAsync(levelNum, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LevelNum（字段） 查询
		/// </summary>
		/// /// <param name = "levelNum">分类级别1开始</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_categoryEO> GetByLevelNum(int levelNum, TransactionManager tm_)
		{
			return GetByLevelNum(levelNum, 0, string.Empty, tm_);
		}
		public async Task<List<L_categoryEO>> GetByLevelNumAsync(int levelNum, TransactionManager tm_)
		{
			return await GetByLevelNumAsync(levelNum, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LevelNum（字段） 查询
		/// </summary>
		/// /// <param name = "levelNum">分类级别1开始</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_categoryEO> GetByLevelNum(int levelNum, int top_)
		{
			return GetByLevelNum(levelNum, top_, string.Empty, null);
		}
		public async Task<List<L_categoryEO>> GetByLevelNumAsync(int levelNum, int top_)
		{
			return await GetByLevelNumAsync(levelNum, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LevelNum（字段） 查询
		/// </summary>
		/// /// <param name = "levelNum">分类级别1开始</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_categoryEO> GetByLevelNum(int levelNum, int top_, TransactionManager tm_)
		{
			return GetByLevelNum(levelNum, top_, string.Empty, tm_);
		}
		public async Task<List<L_categoryEO>> GetByLevelNumAsync(int levelNum, int top_, TransactionManager tm_)
		{
			return await GetByLevelNumAsync(levelNum, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LevelNum（字段） 查询
		/// </summary>
		/// /// <param name = "levelNum">分类级别1开始</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_categoryEO> GetByLevelNum(int levelNum, string sort_)
		{
			return GetByLevelNum(levelNum, 0, sort_, null);
		}
		public async Task<List<L_categoryEO>> GetByLevelNumAsync(int levelNum, string sort_)
		{
			return await GetByLevelNumAsync(levelNum, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LevelNum（字段） 查询
		/// </summary>
		/// /// <param name = "levelNum">分类级别1开始</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_categoryEO> GetByLevelNum(int levelNum, string sort_, TransactionManager tm_)
		{
			return GetByLevelNum(levelNum, 0, sort_, tm_);
		}
		public async Task<List<L_categoryEO>> GetByLevelNumAsync(int levelNum, string sort_, TransactionManager tm_)
		{
			return await GetByLevelNumAsync(levelNum, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LevelNum（字段） 查询
		/// </summary>
		/// /// <param name = "levelNum">分类级别1开始</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_categoryEO> GetByLevelNum(int levelNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LevelNum` = @LevelNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LevelNum", levelNum, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, L_categoryEO.MapDataReader);
		}
		public async Task<List<L_categoryEO>> GetByLevelNumAsync(int levelNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LevelNum` = @LevelNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LevelNum", levelNum, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_categoryEO.MapDataReader);
		}
		#endregion // GetByLevelNum
		#region GetByParentId
		
		/// <summary>
		/// 按 ParentId（字段） 查询
		/// </summary>
		/// /// <param name = "parentId">父节点ID</param>
		/// <return>实体对象集合</return>
		public List<L_categoryEO> GetByParentId(long? parentId)
		{
			return GetByParentId(parentId, 0, string.Empty, null);
		}
		public async Task<List<L_categoryEO>> GetByParentIdAsync(long? parentId)
		{
			return await GetByParentIdAsync(parentId, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ParentId（字段） 查询
		/// </summary>
		/// /// <param name = "parentId">父节点ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_categoryEO> GetByParentId(long? parentId, TransactionManager tm_)
		{
			return GetByParentId(parentId, 0, string.Empty, tm_);
		}
		public async Task<List<L_categoryEO>> GetByParentIdAsync(long? parentId, TransactionManager tm_)
		{
			return await GetByParentIdAsync(parentId, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ParentId（字段） 查询
		/// </summary>
		/// /// <param name = "parentId">父节点ID</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_categoryEO> GetByParentId(long? parentId, int top_)
		{
			return GetByParentId(parentId, top_, string.Empty, null);
		}
		public async Task<List<L_categoryEO>> GetByParentIdAsync(long? parentId, int top_)
		{
			return await GetByParentIdAsync(parentId, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ParentId（字段） 查询
		/// </summary>
		/// /// <param name = "parentId">父节点ID</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_categoryEO> GetByParentId(long? parentId, int top_, TransactionManager tm_)
		{
			return GetByParentId(parentId, top_, string.Empty, tm_);
		}
		public async Task<List<L_categoryEO>> GetByParentIdAsync(long? parentId, int top_, TransactionManager tm_)
		{
			return await GetByParentIdAsync(parentId, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ParentId（字段） 查询
		/// </summary>
		/// /// <param name = "parentId">父节点ID</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_categoryEO> GetByParentId(long? parentId, string sort_)
		{
			return GetByParentId(parentId, 0, sort_, null);
		}
		public async Task<List<L_categoryEO>> GetByParentIdAsync(long? parentId, string sort_)
		{
			return await GetByParentIdAsync(parentId, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ParentId（字段） 查询
		/// </summary>
		/// /// <param name = "parentId">父节点ID</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_categoryEO> GetByParentId(long? parentId, string sort_, TransactionManager tm_)
		{
			return GetByParentId(parentId, 0, sort_, tm_);
		}
		public async Task<List<L_categoryEO>> GetByParentIdAsync(long? parentId, string sort_, TransactionManager tm_)
		{
			return await GetByParentIdAsync(parentId, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ParentId（字段） 查询
		/// </summary>
		/// /// <param name = "parentId">父节点ID</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_categoryEO> GetByParentId(long? parentId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(parentId.HasValue ? "`ParentId` = @ParentId" : "`ParentId` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (parentId.HasValue)
				paras_.Add(Database.CreateInParameter("@ParentId", parentId.Value, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, L_categoryEO.MapDataReader);
		}
		public async Task<List<L_categoryEO>> GetByParentIdAsync(long? parentId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(parentId.HasValue ? "`ParentId` = @ParentId" : "`ParentId` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (parentId.HasValue)
				paras_.Add(Database.CreateInParameter("@ParentId", parentId.Value, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_categoryEO.MapDataReader);
		}
		#endregion // GetByParentId
		#region GetByTemplate
		
		/// <summary>
		/// 按 Template（字段） 查询
		/// </summary>
		/// /// <param name = "template">显示模板</param>
		/// <return>实体对象集合</return>
		public List<L_categoryEO> GetByTemplate(int template)
		{
			return GetByTemplate(template, 0, string.Empty, null);
		}
		public async Task<List<L_categoryEO>> GetByTemplateAsync(int template)
		{
			return await GetByTemplateAsync(template, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Template（字段） 查询
		/// </summary>
		/// /// <param name = "template">显示模板</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_categoryEO> GetByTemplate(int template, TransactionManager tm_)
		{
			return GetByTemplate(template, 0, string.Empty, tm_);
		}
		public async Task<List<L_categoryEO>> GetByTemplateAsync(int template, TransactionManager tm_)
		{
			return await GetByTemplateAsync(template, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Template（字段） 查询
		/// </summary>
		/// /// <param name = "template">显示模板</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_categoryEO> GetByTemplate(int template, int top_)
		{
			return GetByTemplate(template, top_, string.Empty, null);
		}
		public async Task<List<L_categoryEO>> GetByTemplateAsync(int template, int top_)
		{
			return await GetByTemplateAsync(template, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Template（字段） 查询
		/// </summary>
		/// /// <param name = "template">显示模板</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_categoryEO> GetByTemplate(int template, int top_, TransactionManager tm_)
		{
			return GetByTemplate(template, top_, string.Empty, tm_);
		}
		public async Task<List<L_categoryEO>> GetByTemplateAsync(int template, int top_, TransactionManager tm_)
		{
			return await GetByTemplateAsync(template, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Template（字段） 查询
		/// </summary>
		/// /// <param name = "template">显示模板</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_categoryEO> GetByTemplate(int template, string sort_)
		{
			return GetByTemplate(template, 0, sort_, null);
		}
		public async Task<List<L_categoryEO>> GetByTemplateAsync(int template, string sort_)
		{
			return await GetByTemplateAsync(template, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Template（字段） 查询
		/// </summary>
		/// /// <param name = "template">显示模板</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_categoryEO> GetByTemplate(int template, string sort_, TransactionManager tm_)
		{
			return GetByTemplate(template, 0, sort_, tm_);
		}
		public async Task<List<L_categoryEO>> GetByTemplateAsync(int template, string sort_, TransactionManager tm_)
		{
			return await GetByTemplateAsync(template, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Template（字段） 查询
		/// </summary>
		/// /// <param name = "template">显示模板</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_categoryEO> GetByTemplate(int template, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Template` = @Template", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Template", template, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, L_categoryEO.MapDataReader);
		}
		public async Task<List<L_categoryEO>> GetByTemplateAsync(int template, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Template` = @Template", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Template", template, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_categoryEO.MapDataReader);
		}
		#endregion // GetByTemplate
		#region GetByCategoryIcon
		
		/// <summary>
		/// 按 CategoryIcon（字段） 查询
		/// </summary>
		/// /// <param name = "categoryIcon">游戏分类图标</param>
		/// <return>实体对象集合</return>
		public List<L_categoryEO> GetByCategoryIcon(string categoryIcon)
		{
			return GetByCategoryIcon(categoryIcon, 0, string.Empty, null);
		}
		public async Task<List<L_categoryEO>> GetByCategoryIconAsync(string categoryIcon)
		{
			return await GetByCategoryIconAsync(categoryIcon, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CategoryIcon（字段） 查询
		/// </summary>
		/// /// <param name = "categoryIcon">游戏分类图标</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_categoryEO> GetByCategoryIcon(string categoryIcon, TransactionManager tm_)
		{
			return GetByCategoryIcon(categoryIcon, 0, string.Empty, tm_);
		}
		public async Task<List<L_categoryEO>> GetByCategoryIconAsync(string categoryIcon, TransactionManager tm_)
		{
			return await GetByCategoryIconAsync(categoryIcon, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CategoryIcon（字段） 查询
		/// </summary>
		/// /// <param name = "categoryIcon">游戏分类图标</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_categoryEO> GetByCategoryIcon(string categoryIcon, int top_)
		{
			return GetByCategoryIcon(categoryIcon, top_, string.Empty, null);
		}
		public async Task<List<L_categoryEO>> GetByCategoryIconAsync(string categoryIcon, int top_)
		{
			return await GetByCategoryIconAsync(categoryIcon, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CategoryIcon（字段） 查询
		/// </summary>
		/// /// <param name = "categoryIcon">游戏分类图标</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_categoryEO> GetByCategoryIcon(string categoryIcon, int top_, TransactionManager tm_)
		{
			return GetByCategoryIcon(categoryIcon, top_, string.Empty, tm_);
		}
		public async Task<List<L_categoryEO>> GetByCategoryIconAsync(string categoryIcon, int top_, TransactionManager tm_)
		{
			return await GetByCategoryIconAsync(categoryIcon, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CategoryIcon（字段） 查询
		/// </summary>
		/// /// <param name = "categoryIcon">游戏分类图标</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_categoryEO> GetByCategoryIcon(string categoryIcon, string sort_)
		{
			return GetByCategoryIcon(categoryIcon, 0, sort_, null);
		}
		public async Task<List<L_categoryEO>> GetByCategoryIconAsync(string categoryIcon, string sort_)
		{
			return await GetByCategoryIconAsync(categoryIcon, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CategoryIcon（字段） 查询
		/// </summary>
		/// /// <param name = "categoryIcon">游戏分类图标</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_categoryEO> GetByCategoryIcon(string categoryIcon, string sort_, TransactionManager tm_)
		{
			return GetByCategoryIcon(categoryIcon, 0, sort_, tm_);
		}
		public async Task<List<L_categoryEO>> GetByCategoryIconAsync(string categoryIcon, string sort_, TransactionManager tm_)
		{
			return await GetByCategoryIconAsync(categoryIcon, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CategoryIcon（字段） 查询
		/// </summary>
		/// /// <param name = "categoryIcon">游戏分类图标</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_categoryEO> GetByCategoryIcon(string categoryIcon, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CategoryIcon` = @CategoryIcon", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CategoryIcon", categoryIcon, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_categoryEO.MapDataReader);
		}
		public async Task<List<L_categoryEO>> GetByCategoryIconAsync(string categoryIcon, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CategoryIcon` = @CategoryIcon", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CategoryIcon", categoryIcon, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_categoryEO.MapDataReader);
		}
		#endregion // GetByCategoryIcon
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <return>实体对象集合</return>
		public List<L_categoryEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<L_categoryEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_categoryEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<L_categoryEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_categoryEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<L_categoryEO>> GetByRecDateAsync(DateTime recDate, int top_)
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
		public List<L_categoryEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<L_categoryEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_categoryEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<L_categoryEO>> GetByRecDateAsync(DateTime recDate, string sort_)
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
		public List<L_categoryEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<L_categoryEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
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
		public List<L_categoryEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, L_categoryEO.MapDataReader);
		}
		public async Task<List<L_categoryEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_categoryEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#region GetByTopLevelType
		
		/// <summary>
		/// 按 TopLevelType（字段） 查询
		/// </summary>
		/// /// <param name = "topLevelType">顶级分类类型</param>
		/// <return>实体对象集合</return>
		public List<L_categoryEO> GetByTopLevelType(int topLevelType)
		{
			return GetByTopLevelType(topLevelType, 0, string.Empty, null);
		}
		public async Task<List<L_categoryEO>> GetByTopLevelTypeAsync(int topLevelType)
		{
			return await GetByTopLevelTypeAsync(topLevelType, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TopLevelType（字段） 查询
		/// </summary>
		/// /// <param name = "topLevelType">顶级分类类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_categoryEO> GetByTopLevelType(int topLevelType, TransactionManager tm_)
		{
			return GetByTopLevelType(topLevelType, 0, string.Empty, tm_);
		}
		public async Task<List<L_categoryEO>> GetByTopLevelTypeAsync(int topLevelType, TransactionManager tm_)
		{
			return await GetByTopLevelTypeAsync(topLevelType, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TopLevelType（字段） 查询
		/// </summary>
		/// /// <param name = "topLevelType">顶级分类类型</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_categoryEO> GetByTopLevelType(int topLevelType, int top_)
		{
			return GetByTopLevelType(topLevelType, top_, string.Empty, null);
		}
		public async Task<List<L_categoryEO>> GetByTopLevelTypeAsync(int topLevelType, int top_)
		{
			return await GetByTopLevelTypeAsync(topLevelType, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TopLevelType（字段） 查询
		/// </summary>
		/// /// <param name = "topLevelType">顶级分类类型</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_categoryEO> GetByTopLevelType(int topLevelType, int top_, TransactionManager tm_)
		{
			return GetByTopLevelType(topLevelType, top_, string.Empty, tm_);
		}
		public async Task<List<L_categoryEO>> GetByTopLevelTypeAsync(int topLevelType, int top_, TransactionManager tm_)
		{
			return await GetByTopLevelTypeAsync(topLevelType, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TopLevelType（字段） 查询
		/// </summary>
		/// /// <param name = "topLevelType">顶级分类类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_categoryEO> GetByTopLevelType(int topLevelType, string sort_)
		{
			return GetByTopLevelType(topLevelType, 0, sort_, null);
		}
		public async Task<List<L_categoryEO>> GetByTopLevelTypeAsync(int topLevelType, string sort_)
		{
			return await GetByTopLevelTypeAsync(topLevelType, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 TopLevelType（字段） 查询
		/// </summary>
		/// /// <param name = "topLevelType">顶级分类类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_categoryEO> GetByTopLevelType(int topLevelType, string sort_, TransactionManager tm_)
		{
			return GetByTopLevelType(topLevelType, 0, sort_, tm_);
		}
		public async Task<List<L_categoryEO>> GetByTopLevelTypeAsync(int topLevelType, string sort_, TransactionManager tm_)
		{
			return await GetByTopLevelTypeAsync(topLevelType, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 TopLevelType（字段） 查询
		/// </summary>
		/// /// <param name = "topLevelType">顶级分类类型</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_categoryEO> GetByTopLevelType(int topLevelType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TopLevelType` = @TopLevelType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TopLevelType", topLevelType, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, L_categoryEO.MapDataReader);
		}
		public async Task<List<L_categoryEO>> GetByTopLevelTypeAsync(int topLevelType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TopLevelType` = @TopLevelType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TopLevelType", topLevelType, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_categoryEO.MapDataReader);
		}
		#endregion // GetByTopLevelType
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
