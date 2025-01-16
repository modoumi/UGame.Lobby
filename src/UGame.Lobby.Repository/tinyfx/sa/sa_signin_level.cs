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
	/// 【表 sa_signin_level 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Sa_signin_levelEO : IRowMapper<Sa_signin_levelEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Sa_signin_levelEO()
		{
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private int _originalLevelID;
		/// <summary>
		/// 【数据库中的原始主键 LevelID 值的副本，用于主键值更新】
		/// </summary>
		public int OriginalLevelID
		{
			get { return _originalLevelID; }
			set { HasOriginal = true; _originalLevelID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "LevelID", LevelID }, };
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
		/// 【主键 int】
		/// </summary>
		[DataMember(Order = 1)]
		public int LevelID { get; set; }
		/// <summary>
		/// 图片相对路径
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 2)]
		public string PicPath { get; set; }
		/// <summary>
		/// 名称
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 3)]
		public string Name { get; set; }
		/// <summary>
		/// 最小金额
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 4)]
		public int? MinMoney { get; set; }
		/// <summary>
		/// 最大金额
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 5)]
		public int? MaxMoney { get; set; }
		/// <summary>
		/// 下注金额
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 6)]
		public int? PetMoney { get; set; }
		/// <summary>
		/// 排序
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 7)]
		public int? Index { get; set; }
		/// <summary>
		/// 
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 8)]
		public string OperatorID { get; set; }
		/// <summary>
		/// 
		/// 【字段 varchar(5)】
		/// </summary>
		[DataMember(Order = 9)]
		public string CurrencyId { get; set; }
		/// <summary>
		/// 
		/// 【字段 varchar(5)】
		/// </summary>
		[DataMember(Order = 10)]
		public string CountryID { get; set; }
		/// <summary>
		/// 等级
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 11)]
		public int? Level { get; set; }
		/// <summary>
		/// 连续天数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 12)]
		public int? Days { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Sa_signin_levelEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Sa_signin_levelEO MapDataReader(IDataReader reader)
		{
		    Sa_signin_levelEO ret = new Sa_signin_levelEO();
			ret.LevelID = reader.ToInt32("LevelID");
			ret.OriginalLevelID = ret.LevelID;
			ret.PicPath = reader.ToString("PicPath");
			ret.Name = reader.ToString("Name");
			ret.MinMoney = reader.ToInt32N("MinMoney");
			ret.MaxMoney = reader.ToInt32N("MaxMoney");
			ret.PetMoney = reader.ToInt32N("PetMoney");
			ret.Index = reader.ToInt32N("Index");
			ret.OperatorID = reader.ToString("OperatorID");
			ret.CurrencyId = reader.ToString("CurrencyId");
			ret.CountryID = reader.ToString("CountryID");
			ret.Level = reader.ToInt32N("Level");
			ret.Days = reader.ToInt32N("Days");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 
	/// 【表 sa_signin_level 的操作类】
	/// </summary>
	[Obsolete]
	public class Sa_signin_levelMO : MySqlTableMO<Sa_signin_levelEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`sa_signin_level`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Sa_signin_levelMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Sa_signin_levelMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Sa_signin_levelMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Sa_signin_levelEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Sa_signin_levelEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Sa_signin_levelEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`LevelID`, `PicPath`, `Name`, `MinMoney`, `MaxMoney`, `PetMoney`, `Index`, `OperatorID`, `CurrencyId`, `CountryID`, `Level`, `Days`) VALUE (@LevelID, @PicPath, @Name, @MinMoney, @MaxMoney, @PetMoney, @Index, @OperatorID, @CurrencyId, @CountryID, @Level, @Days);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LevelID", item.LevelID, MySqlDbType.Int32),
				Database.CreateInParameter("@PicPath", item.PicPath != null ? item.PicPath : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Name", item.Name != null ? item.Name : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@MinMoney", item.MinMoney.HasValue ? item.MinMoney.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@MaxMoney", item.MaxMoney.HasValue ? item.MaxMoney.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@PetMoney", item.PetMoney.HasValue ? item.PetMoney.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@Index", item.Index.HasValue ? item.Index.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", item.OperatorID != null ? item.OperatorID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyId", item.CurrencyId != null ? item.CurrencyId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", item.CountryID != null ? item.CountryID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Level", item.Level.HasValue ? item.Level.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@Days", item.Days.HasValue ? item.Days.Value : (object)DBNull.Value, MySqlDbType.Int32),
			};
		}
		public int AddByBatch(IEnumerable<Sa_signin_levelEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Sa_signin_levelEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sa_signin_levelEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`LevelID`, `PicPath`, `Name`, `MinMoney`, `MaxMoney`, `PetMoney`, `Index`, `OperatorID`, `CurrencyId`, `CountryID`, `Level`, `Days`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"({item.LevelID},'{item.PicPath}','{item.Name}',{item.MinMoney?.ToString()??null},{item.MaxMoney?.ToString()??null},{item.PetMoney?.ToString()??null},{item.Index?.ToString()??null},'{item.OperatorID}','{item.CurrencyId}','{item.CountryID}',{item.Level?.ToString()??null},{item.Days?.ToString()??null}),");
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
		/// /// <param name = "levelID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(int levelID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(levelID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(int levelID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(levelID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(int levelID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `LevelID` = @LevelID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LevelID", levelID, MySqlDbType.Int32),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Sa_signin_levelEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.LevelID, tm_);
		}
		public async Task<int> RemoveAsync(Sa_signin_levelEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.LevelID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
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
		#region RemoveByName
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "name">名称</param>
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
		#region RemoveByMinMoney
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "minMoney">最小金额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByMinMoney(int? minMoney, TransactionManager tm_ = null)
		{
			RepairRemoveByMinMoneyData(minMoney.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByMinMoneyAsync(int? minMoney, TransactionManager tm_ = null)
		{
			RepairRemoveByMinMoneyData(minMoney.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByMinMoneyData(int? minMoney, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (minMoney.HasValue ? "`MinMoney` = @MinMoney" : "`MinMoney` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (minMoney.HasValue)
				paras_.Add(Database.CreateInParameter("@MinMoney", minMoney.Value, MySqlDbType.Int32));
		}
		#endregion // RemoveByMinMoney
		#region RemoveByMaxMoney
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "maxMoney">最大金额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByMaxMoney(int? maxMoney, TransactionManager tm_ = null)
		{
			RepairRemoveByMaxMoneyData(maxMoney.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByMaxMoneyAsync(int? maxMoney, TransactionManager tm_ = null)
		{
			RepairRemoveByMaxMoneyData(maxMoney.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByMaxMoneyData(int? maxMoney, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (maxMoney.HasValue ? "`MaxMoney` = @MaxMoney" : "`MaxMoney` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (maxMoney.HasValue)
				paras_.Add(Database.CreateInParameter("@MaxMoney", maxMoney.Value, MySqlDbType.Int32));
		}
		#endregion // RemoveByMaxMoney
		#region RemoveByPetMoney
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "petMoney">下注金额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPetMoney(int? petMoney, TransactionManager tm_ = null)
		{
			RepairRemoveByPetMoneyData(petMoney.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPetMoneyAsync(int? petMoney, TransactionManager tm_ = null)
		{
			RepairRemoveByPetMoneyData(petMoney.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByPetMoneyData(int? petMoney, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (petMoney.HasValue ? "`PetMoney` = @PetMoney" : "`PetMoney` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (petMoney.HasValue)
				paras_.Add(Database.CreateInParameter("@PetMoney", petMoney.Value, MySqlDbType.Int32));
		}
		#endregion // RemoveByPetMoney
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
		#region RemoveByCurrencyId
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "currencyId"></param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCurrencyId(string currencyId, TransactionManager tm_ = null)
		{
			RepairRemoveByCurrencyIdData(currencyId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCurrencyIdAsync(string currencyId, TransactionManager tm_ = null)
		{
			RepairRemoveByCurrencyIdData(currencyId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCurrencyIdData(string currencyId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (currencyId != null ? "`CurrencyId` = @CurrencyId" : "`CurrencyId` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (currencyId != null)
				paras_.Add(Database.CreateInParameter("@CurrencyId", currencyId, MySqlDbType.VarChar));
		}
		#endregion // RemoveByCurrencyId
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
		#region RemoveByLevel
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "level">等级</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByLevel(int? level, TransactionManager tm_ = null)
		{
			RepairRemoveByLevelData(level.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByLevelAsync(int? level, TransactionManager tm_ = null)
		{
			RepairRemoveByLevelData(level.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByLevelData(int? level, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (level.HasValue ? "`Level` = @Level" : "`Level` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (level.HasValue)
				paras_.Add(Database.CreateInParameter("@Level", level.Value, MySqlDbType.Int32));
		}
		#endregion // RemoveByLevel
		#region RemoveByDays
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "days">连续天数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByDays(int? days, TransactionManager tm_ = null)
		{
			RepairRemoveByDaysData(days.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByDaysAsync(int? days, TransactionManager tm_ = null)
		{
			RepairRemoveByDaysData(days.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByDaysData(int? days, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (days.HasValue ? "`Days` = @Days" : "`Days` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (days.HasValue)
				paras_.Add(Database.CreateInParameter("@Days", days.Value, MySqlDbType.Int32));
		}
		#endregion // RemoveByDays
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
		public int Put(Sa_signin_levelEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Sa_signin_levelEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Sa_signin_levelEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `LevelID` = @LevelID, `PicPath` = @PicPath, `Name` = @Name, `MinMoney` = @MinMoney, `MaxMoney` = @MaxMoney, `PetMoney` = @PetMoney, `Index` = @Index, `OperatorID` = @OperatorID, `CurrencyId` = @CurrencyId, `CountryID` = @CountryID, `Level` = @Level, `Days` = @Days WHERE `LevelID` = @LevelID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LevelID", item.LevelID, MySqlDbType.Int32),
				Database.CreateInParameter("@PicPath", item.PicPath != null ? item.PicPath : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Name", item.Name != null ? item.Name : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@MinMoney", item.MinMoney.HasValue ? item.MinMoney.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@MaxMoney", item.MaxMoney.HasValue ? item.MaxMoney.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@PetMoney", item.PetMoney.HasValue ? item.PetMoney.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@Index", item.Index.HasValue ? item.Index.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", item.OperatorID != null ? item.OperatorID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyId", item.CurrencyId != null ? item.CurrencyId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", item.CountryID != null ? item.CountryID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Level", item.Level.HasValue ? item.Level.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@Days", item.Days.HasValue ? item.Days.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@LevelID_Original", item.HasOriginal ? item.OriginalLevelID : item.LevelID, MySqlDbType.Int32),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Sa_signin_levelEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Sa_signin_levelEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "levelID">编号</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int levelID, string set_, params object[] values_)
		{
			return Put(set_, "`LevelID` = @LevelID", ConcatValues(values_, levelID));
		}
		public async Task<int> PutByPKAsync(int levelID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`LevelID` = @LevelID", ConcatValues(values_, levelID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "levelID">编号</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int levelID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`LevelID` = @LevelID", tm_, ConcatValues(values_, levelID));
		}
		public async Task<int> PutByPKAsync(int levelID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`LevelID` = @LevelID", tm_, ConcatValues(values_, levelID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "levelID">编号</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int levelID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@LevelID", levelID, MySqlDbType.Int32),
	        };
			return Put(set_, "`LevelID` = @LevelID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(int levelID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@LevelID", levelID, MySqlDbType.Int32),
	        };
			return await PutAsync(set_, "`LevelID` = @LevelID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutPicPath
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "levelID">编号</param>
		/// /// <param name = "picPath">图片相对路径</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPicPathByPK(int levelID, string picPath, TransactionManager tm_ = null)
		{
			RepairPutPicPathByPKData(levelID, picPath, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutPicPathByPKAsync(int levelID, string picPath, TransactionManager tm_ = null)
		{
			RepairPutPicPathByPKData(levelID, picPath, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutPicPathByPKData(int levelID, string picPath, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `PicPath` = @PicPath  WHERE `LevelID` = @LevelID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PicPath", picPath != null ? picPath : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@LevelID", levelID, MySqlDbType.Int32),
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
		#region PutName
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "levelID">编号</param>
		/// /// <param name = "name">名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutNameByPK(int levelID, string name, TransactionManager tm_ = null)
		{
			RepairPutNameByPKData(levelID, name, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutNameByPKAsync(int levelID, string name, TransactionManager tm_ = null)
		{
			RepairPutNameByPKData(levelID, name, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutNameByPKData(int levelID, string name, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Name` = @Name  WHERE `LevelID` = @LevelID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Name", name != null ? name : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@LevelID", levelID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "name">名称</param>
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
		#region PutMinMoney
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "levelID">编号</param>
		/// /// <param name = "minMoney">最小金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMinMoneyByPK(int levelID, int? minMoney, TransactionManager tm_ = null)
		{
			RepairPutMinMoneyByPKData(levelID, minMoney, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutMinMoneyByPKAsync(int levelID, int? minMoney, TransactionManager tm_ = null)
		{
			RepairPutMinMoneyByPKData(levelID, minMoney, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutMinMoneyByPKData(int levelID, int? minMoney, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `MinMoney` = @MinMoney  WHERE `LevelID` = @LevelID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MinMoney", minMoney.HasValue ? minMoney.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@LevelID", levelID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "minMoney">最小金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMinMoney(int? minMoney, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MinMoney` = @MinMoney";
			var parameter_ = Database.CreateInParameter("@MinMoney", minMoney.HasValue ? minMoney.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutMinMoneyAsync(int? minMoney, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MinMoney` = @MinMoney";
			var parameter_ = Database.CreateInParameter("@MinMoney", minMoney.HasValue ? minMoney.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutMinMoney
		#region PutMaxMoney
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "levelID">编号</param>
		/// /// <param name = "maxMoney">最大金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMaxMoneyByPK(int levelID, int? maxMoney, TransactionManager tm_ = null)
		{
			RepairPutMaxMoneyByPKData(levelID, maxMoney, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutMaxMoneyByPKAsync(int levelID, int? maxMoney, TransactionManager tm_ = null)
		{
			RepairPutMaxMoneyByPKData(levelID, maxMoney, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutMaxMoneyByPKData(int levelID, int? maxMoney, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `MaxMoney` = @MaxMoney  WHERE `LevelID` = @LevelID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MaxMoney", maxMoney.HasValue ? maxMoney.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@LevelID", levelID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "maxMoney">最大金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMaxMoney(int? maxMoney, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MaxMoney` = @MaxMoney";
			var parameter_ = Database.CreateInParameter("@MaxMoney", maxMoney.HasValue ? maxMoney.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutMaxMoneyAsync(int? maxMoney, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MaxMoney` = @MaxMoney";
			var parameter_ = Database.CreateInParameter("@MaxMoney", maxMoney.HasValue ? maxMoney.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutMaxMoney
		#region PutPetMoney
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "levelID">编号</param>
		/// /// <param name = "petMoney">下注金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPetMoneyByPK(int levelID, int? petMoney, TransactionManager tm_ = null)
		{
			RepairPutPetMoneyByPKData(levelID, petMoney, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutPetMoneyByPKAsync(int levelID, int? petMoney, TransactionManager tm_ = null)
		{
			RepairPutPetMoneyByPKData(levelID, petMoney, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutPetMoneyByPKData(int levelID, int? petMoney, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `PetMoney` = @PetMoney  WHERE `LevelID` = @LevelID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PetMoney", petMoney.HasValue ? petMoney.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@LevelID", levelID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "petMoney">下注金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPetMoney(int? petMoney, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PetMoney` = @PetMoney";
			var parameter_ = Database.CreateInParameter("@PetMoney", petMoney.HasValue ? petMoney.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutPetMoneyAsync(int? petMoney, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PetMoney` = @PetMoney";
			var parameter_ = Database.CreateInParameter("@PetMoney", petMoney.HasValue ? petMoney.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutPetMoney
		#region PutIndex
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "levelID">编号</param>
		/// /// <param name = "index">排序</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIndexByPK(int levelID, int? index, TransactionManager tm_ = null)
		{
			RepairPutIndexByPKData(levelID, index, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutIndexByPKAsync(int levelID, int? index, TransactionManager tm_ = null)
		{
			RepairPutIndexByPKData(levelID, index, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutIndexByPKData(int levelID, int? index, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Index` = @Index  WHERE `LevelID` = @LevelID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Index", index.HasValue ? index.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@LevelID", levelID, MySqlDbType.Int32),
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
		#region PutOperatorID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "levelID">编号</param>
		/// /// <param name = "operatorID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorIDByPK(int levelID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(levelID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOperatorIDByPKAsync(int levelID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(levelID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOperatorIDByPKData(int levelID, string operatorID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID  WHERE `LevelID` = @LevelID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID != null ? operatorID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@LevelID", levelID, MySqlDbType.Int32),
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
		#region PutCurrencyId
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "levelID">编号</param>
		/// /// <param name = "currencyId"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCurrencyIdByPK(int levelID, string currencyId, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIdByPKData(levelID, currencyId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCurrencyIdByPKAsync(int levelID, string currencyId, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIdByPKData(levelID, currencyId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCurrencyIdByPKData(int levelID, string currencyId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CurrencyId` = @CurrencyId  WHERE `LevelID` = @LevelID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CurrencyId", currencyId != null ? currencyId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@LevelID", levelID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "currencyId"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCurrencyId(string currencyId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CurrencyId` = @CurrencyId";
			var parameter_ = Database.CreateInParameter("@CurrencyId", currencyId != null ? currencyId : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCurrencyIdAsync(string currencyId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CurrencyId` = @CurrencyId";
			var parameter_ = Database.CreateInParameter("@CurrencyId", currencyId != null ? currencyId : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCurrencyId
		#region PutCountryID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "levelID">编号</param>
		/// /// <param name = "countryID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCountryIDByPK(int levelID, string countryID, TransactionManager tm_ = null)
		{
			RepairPutCountryIDByPKData(levelID, countryID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCountryIDByPKAsync(int levelID, string countryID, TransactionManager tm_ = null)
		{
			RepairPutCountryIDByPKData(levelID, countryID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCountryIDByPKData(int levelID, string countryID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CountryID` = @CountryID  WHERE `LevelID` = @LevelID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryID", countryID != null ? countryID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@LevelID", levelID, MySqlDbType.Int32),
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
		#region PutLevel
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "levelID">编号</param>
		/// /// <param name = "level">等级</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLevelByPK(int levelID, int? level, TransactionManager tm_ = null)
		{
			RepairPutLevelByPKData(levelID, level, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLevelByPKAsync(int levelID, int? level, TransactionManager tm_ = null)
		{
			RepairPutLevelByPKData(levelID, level, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLevelByPKData(int levelID, int? level, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Level` = @Level  WHERE `LevelID` = @LevelID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Level", level.HasValue ? level.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@LevelID", levelID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "level">等级</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLevel(int? level, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Level` = @Level";
			var parameter_ = Database.CreateInParameter("@Level", level.HasValue ? level.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutLevelAsync(int? level, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Level` = @Level";
			var parameter_ = Database.CreateInParameter("@Level", level.HasValue ? level.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutLevel
		#region PutDays
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "levelID">编号</param>
		/// /// <param name = "days">连续天数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutDaysByPK(int levelID, int? days, TransactionManager tm_ = null)
		{
			RepairPutDaysByPKData(levelID, days, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutDaysByPKAsync(int levelID, int? days, TransactionManager tm_ = null)
		{
			RepairPutDaysByPKData(levelID, days, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutDaysByPKData(int levelID, int? days, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Days` = @Days  WHERE `LevelID` = @LevelID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Days", days.HasValue ? days.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@LevelID", levelID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "days">连续天数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutDays(int? days, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Days` = @Days";
			var parameter_ = Database.CreateInParameter("@Days", days.HasValue ? days.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutDaysAsync(int? days, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Days` = @Days";
			var parameter_ = Database.CreateInParameter("@Days", days.HasValue ? days.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutDays
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Sa_signin_levelEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.LevelID) == null)
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
		public async Task<bool> SetAsync(Sa_signin_levelEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.LevelID) == null)
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
		/// /// <param name = "levelID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Sa_signin_levelEO GetByPK(int levelID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(levelID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sa_signin_levelEO.MapDataReader);
		}
		public async Task<Sa_signin_levelEO> GetByPKAsync(int levelID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(levelID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sa_signin_levelEO.MapDataReader);
		}
		private void RepairGetByPKData(int levelID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`LevelID` = @LevelID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LevelID", levelID, MySqlDbType.Int32),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 PicPath（字段）
		/// </summary>
		/// /// <param name = "levelID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetPicPathByPK(int levelID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LevelID", levelID, MySqlDbType.Int32),
			};
			return (string)GetScalar("`PicPath`", "`LevelID` = @LevelID", paras_, tm_);
		}
		public async Task<string> GetPicPathByPKAsync(int levelID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LevelID", levelID, MySqlDbType.Int32),
			};
			return (string)await GetScalarAsync("`PicPath`", "`LevelID` = @LevelID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Name（字段）
		/// </summary>
		/// /// <param name = "levelID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetNameByPK(int levelID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LevelID", levelID, MySqlDbType.Int32),
			};
			return (string)GetScalar("`Name`", "`LevelID` = @LevelID", paras_, tm_);
		}
		public async Task<string> GetNameByPKAsync(int levelID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LevelID", levelID, MySqlDbType.Int32),
			};
			return (string)await GetScalarAsync("`Name`", "`LevelID` = @LevelID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 MinMoney（字段）
		/// </summary>
		/// /// <param name = "levelID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int? GetMinMoneyByPK(int levelID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LevelID", levelID, MySqlDbType.Int32),
			};
			return (int?)GetScalar("`MinMoney`", "`LevelID` = @LevelID", paras_, tm_);
		}
		public async Task<int?> GetMinMoneyByPKAsync(int levelID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LevelID", levelID, MySqlDbType.Int32),
			};
			return (int?)await GetScalarAsync("`MinMoney`", "`LevelID` = @LevelID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 MaxMoney（字段）
		/// </summary>
		/// /// <param name = "levelID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int? GetMaxMoneyByPK(int levelID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LevelID", levelID, MySqlDbType.Int32),
			};
			return (int?)GetScalar("`MaxMoney`", "`LevelID` = @LevelID", paras_, tm_);
		}
		public async Task<int?> GetMaxMoneyByPKAsync(int levelID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LevelID", levelID, MySqlDbType.Int32),
			};
			return (int?)await GetScalarAsync("`MaxMoney`", "`LevelID` = @LevelID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 PetMoney（字段）
		/// </summary>
		/// /// <param name = "levelID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int? GetPetMoneyByPK(int levelID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LevelID", levelID, MySqlDbType.Int32),
			};
			return (int?)GetScalar("`PetMoney`", "`LevelID` = @LevelID", paras_, tm_);
		}
		public async Task<int?> GetPetMoneyByPKAsync(int levelID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LevelID", levelID, MySqlDbType.Int32),
			};
			return (int?)await GetScalarAsync("`PetMoney`", "`LevelID` = @LevelID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Index（字段）
		/// </summary>
		/// /// <param name = "levelID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int? GetIndexByPK(int levelID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LevelID", levelID, MySqlDbType.Int32),
			};
			return (int?)GetScalar("`Index`", "`LevelID` = @LevelID", paras_, tm_);
		}
		public async Task<int?> GetIndexByPKAsync(int levelID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LevelID", levelID, MySqlDbType.Int32),
			};
			return (int?)await GetScalarAsync("`Index`", "`LevelID` = @LevelID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OperatorID（字段）
		/// </summary>
		/// /// <param name = "levelID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorIDByPK(int levelID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LevelID", levelID, MySqlDbType.Int32),
			};
			return (string)GetScalar("`OperatorID`", "`LevelID` = @LevelID", paras_, tm_);
		}
		public async Task<string> GetOperatorIDByPKAsync(int levelID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LevelID", levelID, MySqlDbType.Int32),
			};
			return (string)await GetScalarAsync("`OperatorID`", "`LevelID` = @LevelID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CurrencyId（字段）
		/// </summary>
		/// /// <param name = "levelID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCurrencyIdByPK(int levelID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LevelID", levelID, MySqlDbType.Int32),
			};
			return (string)GetScalar("`CurrencyId`", "`LevelID` = @LevelID", paras_, tm_);
		}
		public async Task<string> GetCurrencyIdByPKAsync(int levelID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LevelID", levelID, MySqlDbType.Int32),
			};
			return (string)await GetScalarAsync("`CurrencyId`", "`LevelID` = @LevelID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CountryID（字段）
		/// </summary>
		/// /// <param name = "levelID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCountryIDByPK(int levelID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LevelID", levelID, MySqlDbType.Int32),
			};
			return (string)GetScalar("`CountryID`", "`LevelID` = @LevelID", paras_, tm_);
		}
		public async Task<string> GetCountryIDByPKAsync(int levelID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LevelID", levelID, MySqlDbType.Int32),
			};
			return (string)await GetScalarAsync("`CountryID`", "`LevelID` = @LevelID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Level（字段）
		/// </summary>
		/// /// <param name = "levelID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int? GetLevelByPK(int levelID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LevelID", levelID, MySqlDbType.Int32),
			};
			return (int?)GetScalar("`Level`", "`LevelID` = @LevelID", paras_, tm_);
		}
		public async Task<int?> GetLevelByPKAsync(int levelID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LevelID", levelID, MySqlDbType.Int32),
			};
			return (int?)await GetScalarAsync("`Level`", "`LevelID` = @LevelID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Days（字段）
		/// </summary>
		/// /// <param name = "levelID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int? GetDaysByPK(int levelID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LevelID", levelID, MySqlDbType.Int32),
			};
			return (int?)GetScalar("`Days`", "`LevelID` = @LevelID", paras_, tm_);
		}
		public async Task<int?> GetDaysByPKAsync(int levelID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LevelID", levelID, MySqlDbType.Int32),
			};
			return (int?)await GetScalarAsync("`Days`", "`LevelID` = @LevelID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByPicPath
		
		/// <summary>
		/// 按 PicPath（字段） 查询
		/// </summary>
		/// /// <param name = "picPath">图片相对路径</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_levelEO> GetByPicPath(string picPath)
		{
			return GetByPicPath(picPath, 0, string.Empty, null);
		}
		public async Task<List<Sa_signin_levelEO>> GetByPicPathAsync(string picPath)
		{
			return await GetByPicPathAsync(picPath, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PicPath（字段） 查询
		/// </summary>
		/// /// <param name = "picPath">图片相对路径</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_levelEO> GetByPicPath(string picPath, TransactionManager tm_)
		{
			return GetByPicPath(picPath, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_signin_levelEO>> GetByPicPathAsync(string picPath, TransactionManager tm_)
		{
			return await GetByPicPathAsync(picPath, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PicPath（字段） 查询
		/// </summary>
		/// /// <param name = "picPath">图片相对路径</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_levelEO> GetByPicPath(string picPath, int top_)
		{
			return GetByPicPath(picPath, top_, string.Empty, null);
		}
		public async Task<List<Sa_signin_levelEO>> GetByPicPathAsync(string picPath, int top_)
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
		public List<Sa_signin_levelEO> GetByPicPath(string picPath, int top_, TransactionManager tm_)
		{
			return GetByPicPath(picPath, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_signin_levelEO>> GetByPicPathAsync(string picPath, int top_, TransactionManager tm_)
		{
			return await GetByPicPathAsync(picPath, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PicPath（字段） 查询
		/// </summary>
		/// /// <param name = "picPath">图片相对路径</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_levelEO> GetByPicPath(string picPath, string sort_)
		{
			return GetByPicPath(picPath, 0, sort_, null);
		}
		public async Task<List<Sa_signin_levelEO>> GetByPicPathAsync(string picPath, string sort_)
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
		public List<Sa_signin_levelEO> GetByPicPath(string picPath, string sort_, TransactionManager tm_)
		{
			return GetByPicPath(picPath, 0, sort_, tm_);
		}
		public async Task<List<Sa_signin_levelEO>> GetByPicPathAsync(string picPath, string sort_, TransactionManager tm_)
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
		public List<Sa_signin_levelEO> GetByPicPath(string picPath, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(picPath != null ? "`PicPath` = @PicPath" : "`PicPath` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (picPath != null)
				paras_.Add(Database.CreateInParameter("@PicPath", picPath, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_signin_levelEO.MapDataReader);
		}
		public async Task<List<Sa_signin_levelEO>> GetByPicPathAsync(string picPath, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(picPath != null ? "`PicPath` = @PicPath" : "`PicPath` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (picPath != null)
				paras_.Add(Database.CreateInParameter("@PicPath", picPath, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_signin_levelEO.MapDataReader);
		}
		#endregion // GetByPicPath
		#region GetByName
		
		/// <summary>
		/// 按 Name（字段） 查询
		/// </summary>
		/// /// <param name = "name">名称</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_levelEO> GetByName(string name)
		{
			return GetByName(name, 0, string.Empty, null);
		}
		public async Task<List<Sa_signin_levelEO>> GetByNameAsync(string name)
		{
			return await GetByNameAsync(name, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Name（字段） 查询
		/// </summary>
		/// /// <param name = "name">名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_levelEO> GetByName(string name, TransactionManager tm_)
		{
			return GetByName(name, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_signin_levelEO>> GetByNameAsync(string name, TransactionManager tm_)
		{
			return await GetByNameAsync(name, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Name（字段） 查询
		/// </summary>
		/// /// <param name = "name">名称</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_levelEO> GetByName(string name, int top_)
		{
			return GetByName(name, top_, string.Empty, null);
		}
		public async Task<List<Sa_signin_levelEO>> GetByNameAsync(string name, int top_)
		{
			return await GetByNameAsync(name, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Name（字段） 查询
		/// </summary>
		/// /// <param name = "name">名称</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_levelEO> GetByName(string name, int top_, TransactionManager tm_)
		{
			return GetByName(name, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_signin_levelEO>> GetByNameAsync(string name, int top_, TransactionManager tm_)
		{
			return await GetByNameAsync(name, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Name（字段） 查询
		/// </summary>
		/// /// <param name = "name">名称</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_levelEO> GetByName(string name, string sort_)
		{
			return GetByName(name, 0, sort_, null);
		}
		public async Task<List<Sa_signin_levelEO>> GetByNameAsync(string name, string sort_)
		{
			return await GetByNameAsync(name, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Name（字段） 查询
		/// </summary>
		/// /// <param name = "name">名称</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_levelEO> GetByName(string name, string sort_, TransactionManager tm_)
		{
			return GetByName(name, 0, sort_, tm_);
		}
		public async Task<List<Sa_signin_levelEO>> GetByNameAsync(string name, string sort_, TransactionManager tm_)
		{
			return await GetByNameAsync(name, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Name（字段） 查询
		/// </summary>
		/// /// <param name = "name">名称</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_levelEO> GetByName(string name, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(name != null ? "`Name` = @Name" : "`Name` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (name != null)
				paras_.Add(Database.CreateInParameter("@Name", name, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_signin_levelEO.MapDataReader);
		}
		public async Task<List<Sa_signin_levelEO>> GetByNameAsync(string name, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(name != null ? "`Name` = @Name" : "`Name` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (name != null)
				paras_.Add(Database.CreateInParameter("@Name", name, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_signin_levelEO.MapDataReader);
		}
		#endregion // GetByName
		#region GetByMinMoney
		
		/// <summary>
		/// 按 MinMoney（字段） 查询
		/// </summary>
		/// /// <param name = "minMoney">最小金额</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_levelEO> GetByMinMoney(int? minMoney)
		{
			return GetByMinMoney(minMoney, 0, string.Empty, null);
		}
		public async Task<List<Sa_signin_levelEO>> GetByMinMoneyAsync(int? minMoney)
		{
			return await GetByMinMoneyAsync(minMoney, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MinMoney（字段） 查询
		/// </summary>
		/// /// <param name = "minMoney">最小金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_levelEO> GetByMinMoney(int? minMoney, TransactionManager tm_)
		{
			return GetByMinMoney(minMoney, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_signin_levelEO>> GetByMinMoneyAsync(int? minMoney, TransactionManager tm_)
		{
			return await GetByMinMoneyAsync(minMoney, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MinMoney（字段） 查询
		/// </summary>
		/// /// <param name = "minMoney">最小金额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_levelEO> GetByMinMoney(int? minMoney, int top_)
		{
			return GetByMinMoney(minMoney, top_, string.Empty, null);
		}
		public async Task<List<Sa_signin_levelEO>> GetByMinMoneyAsync(int? minMoney, int top_)
		{
			return await GetByMinMoneyAsync(minMoney, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MinMoney（字段） 查询
		/// </summary>
		/// /// <param name = "minMoney">最小金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_levelEO> GetByMinMoney(int? minMoney, int top_, TransactionManager tm_)
		{
			return GetByMinMoney(minMoney, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_signin_levelEO>> GetByMinMoneyAsync(int? minMoney, int top_, TransactionManager tm_)
		{
			return await GetByMinMoneyAsync(minMoney, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MinMoney（字段） 查询
		/// </summary>
		/// /// <param name = "minMoney">最小金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_levelEO> GetByMinMoney(int? minMoney, string sort_)
		{
			return GetByMinMoney(minMoney, 0, sort_, null);
		}
		public async Task<List<Sa_signin_levelEO>> GetByMinMoneyAsync(int? minMoney, string sort_)
		{
			return await GetByMinMoneyAsync(minMoney, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 MinMoney（字段） 查询
		/// </summary>
		/// /// <param name = "minMoney">最小金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_levelEO> GetByMinMoney(int? minMoney, string sort_, TransactionManager tm_)
		{
			return GetByMinMoney(minMoney, 0, sort_, tm_);
		}
		public async Task<List<Sa_signin_levelEO>> GetByMinMoneyAsync(int? minMoney, string sort_, TransactionManager tm_)
		{
			return await GetByMinMoneyAsync(minMoney, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 MinMoney（字段） 查询
		/// </summary>
		/// /// <param name = "minMoney">最小金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_levelEO> GetByMinMoney(int? minMoney, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(minMoney.HasValue ? "`MinMoney` = @MinMoney" : "`MinMoney` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (minMoney.HasValue)
				paras_.Add(Database.CreateInParameter("@MinMoney", minMoney.Value, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_signin_levelEO.MapDataReader);
		}
		public async Task<List<Sa_signin_levelEO>> GetByMinMoneyAsync(int? minMoney, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(minMoney.HasValue ? "`MinMoney` = @MinMoney" : "`MinMoney` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (minMoney.HasValue)
				paras_.Add(Database.CreateInParameter("@MinMoney", minMoney.Value, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_signin_levelEO.MapDataReader);
		}
		#endregion // GetByMinMoney
		#region GetByMaxMoney
		
		/// <summary>
		/// 按 MaxMoney（字段） 查询
		/// </summary>
		/// /// <param name = "maxMoney">最大金额</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_levelEO> GetByMaxMoney(int? maxMoney)
		{
			return GetByMaxMoney(maxMoney, 0, string.Empty, null);
		}
		public async Task<List<Sa_signin_levelEO>> GetByMaxMoneyAsync(int? maxMoney)
		{
			return await GetByMaxMoneyAsync(maxMoney, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MaxMoney（字段） 查询
		/// </summary>
		/// /// <param name = "maxMoney">最大金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_levelEO> GetByMaxMoney(int? maxMoney, TransactionManager tm_)
		{
			return GetByMaxMoney(maxMoney, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_signin_levelEO>> GetByMaxMoneyAsync(int? maxMoney, TransactionManager tm_)
		{
			return await GetByMaxMoneyAsync(maxMoney, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MaxMoney（字段） 查询
		/// </summary>
		/// /// <param name = "maxMoney">最大金额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_levelEO> GetByMaxMoney(int? maxMoney, int top_)
		{
			return GetByMaxMoney(maxMoney, top_, string.Empty, null);
		}
		public async Task<List<Sa_signin_levelEO>> GetByMaxMoneyAsync(int? maxMoney, int top_)
		{
			return await GetByMaxMoneyAsync(maxMoney, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MaxMoney（字段） 查询
		/// </summary>
		/// /// <param name = "maxMoney">最大金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_levelEO> GetByMaxMoney(int? maxMoney, int top_, TransactionManager tm_)
		{
			return GetByMaxMoney(maxMoney, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_signin_levelEO>> GetByMaxMoneyAsync(int? maxMoney, int top_, TransactionManager tm_)
		{
			return await GetByMaxMoneyAsync(maxMoney, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MaxMoney（字段） 查询
		/// </summary>
		/// /// <param name = "maxMoney">最大金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_levelEO> GetByMaxMoney(int? maxMoney, string sort_)
		{
			return GetByMaxMoney(maxMoney, 0, sort_, null);
		}
		public async Task<List<Sa_signin_levelEO>> GetByMaxMoneyAsync(int? maxMoney, string sort_)
		{
			return await GetByMaxMoneyAsync(maxMoney, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 MaxMoney（字段） 查询
		/// </summary>
		/// /// <param name = "maxMoney">最大金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_levelEO> GetByMaxMoney(int? maxMoney, string sort_, TransactionManager tm_)
		{
			return GetByMaxMoney(maxMoney, 0, sort_, tm_);
		}
		public async Task<List<Sa_signin_levelEO>> GetByMaxMoneyAsync(int? maxMoney, string sort_, TransactionManager tm_)
		{
			return await GetByMaxMoneyAsync(maxMoney, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 MaxMoney（字段） 查询
		/// </summary>
		/// /// <param name = "maxMoney">最大金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_levelEO> GetByMaxMoney(int? maxMoney, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(maxMoney.HasValue ? "`MaxMoney` = @MaxMoney" : "`MaxMoney` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (maxMoney.HasValue)
				paras_.Add(Database.CreateInParameter("@MaxMoney", maxMoney.Value, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_signin_levelEO.MapDataReader);
		}
		public async Task<List<Sa_signin_levelEO>> GetByMaxMoneyAsync(int? maxMoney, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(maxMoney.HasValue ? "`MaxMoney` = @MaxMoney" : "`MaxMoney` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (maxMoney.HasValue)
				paras_.Add(Database.CreateInParameter("@MaxMoney", maxMoney.Value, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_signin_levelEO.MapDataReader);
		}
		#endregion // GetByMaxMoney
		#region GetByPetMoney
		
		/// <summary>
		/// 按 PetMoney（字段） 查询
		/// </summary>
		/// /// <param name = "petMoney">下注金额</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_levelEO> GetByPetMoney(int? petMoney)
		{
			return GetByPetMoney(petMoney, 0, string.Empty, null);
		}
		public async Task<List<Sa_signin_levelEO>> GetByPetMoneyAsync(int? petMoney)
		{
			return await GetByPetMoneyAsync(petMoney, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PetMoney（字段） 查询
		/// </summary>
		/// /// <param name = "petMoney">下注金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_levelEO> GetByPetMoney(int? petMoney, TransactionManager tm_)
		{
			return GetByPetMoney(petMoney, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_signin_levelEO>> GetByPetMoneyAsync(int? petMoney, TransactionManager tm_)
		{
			return await GetByPetMoneyAsync(petMoney, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PetMoney（字段） 查询
		/// </summary>
		/// /// <param name = "petMoney">下注金额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_levelEO> GetByPetMoney(int? petMoney, int top_)
		{
			return GetByPetMoney(petMoney, top_, string.Empty, null);
		}
		public async Task<List<Sa_signin_levelEO>> GetByPetMoneyAsync(int? petMoney, int top_)
		{
			return await GetByPetMoneyAsync(petMoney, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PetMoney（字段） 查询
		/// </summary>
		/// /// <param name = "petMoney">下注金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_levelEO> GetByPetMoney(int? petMoney, int top_, TransactionManager tm_)
		{
			return GetByPetMoney(petMoney, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_signin_levelEO>> GetByPetMoneyAsync(int? petMoney, int top_, TransactionManager tm_)
		{
			return await GetByPetMoneyAsync(petMoney, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PetMoney（字段） 查询
		/// </summary>
		/// /// <param name = "petMoney">下注金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_levelEO> GetByPetMoney(int? petMoney, string sort_)
		{
			return GetByPetMoney(petMoney, 0, sort_, null);
		}
		public async Task<List<Sa_signin_levelEO>> GetByPetMoneyAsync(int? petMoney, string sort_)
		{
			return await GetByPetMoneyAsync(petMoney, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PetMoney（字段） 查询
		/// </summary>
		/// /// <param name = "petMoney">下注金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_levelEO> GetByPetMoney(int? petMoney, string sort_, TransactionManager tm_)
		{
			return GetByPetMoney(petMoney, 0, sort_, tm_);
		}
		public async Task<List<Sa_signin_levelEO>> GetByPetMoneyAsync(int? petMoney, string sort_, TransactionManager tm_)
		{
			return await GetByPetMoneyAsync(petMoney, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PetMoney（字段） 查询
		/// </summary>
		/// /// <param name = "petMoney">下注金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_levelEO> GetByPetMoney(int? petMoney, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(petMoney.HasValue ? "`PetMoney` = @PetMoney" : "`PetMoney` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (petMoney.HasValue)
				paras_.Add(Database.CreateInParameter("@PetMoney", petMoney.Value, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_signin_levelEO.MapDataReader);
		}
		public async Task<List<Sa_signin_levelEO>> GetByPetMoneyAsync(int? petMoney, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(petMoney.HasValue ? "`PetMoney` = @PetMoney" : "`PetMoney` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (petMoney.HasValue)
				paras_.Add(Database.CreateInParameter("@PetMoney", petMoney.Value, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_signin_levelEO.MapDataReader);
		}
		#endregion // GetByPetMoney
		#region GetByIndex
		
		/// <summary>
		/// 按 Index（字段） 查询
		/// </summary>
		/// /// <param name = "index">排序</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_levelEO> GetByIndex(int? index)
		{
			return GetByIndex(index, 0, string.Empty, null);
		}
		public async Task<List<Sa_signin_levelEO>> GetByIndexAsync(int? index)
		{
			return await GetByIndexAsync(index, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Index（字段） 查询
		/// </summary>
		/// /// <param name = "index">排序</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_levelEO> GetByIndex(int? index, TransactionManager tm_)
		{
			return GetByIndex(index, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_signin_levelEO>> GetByIndexAsync(int? index, TransactionManager tm_)
		{
			return await GetByIndexAsync(index, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Index（字段） 查询
		/// </summary>
		/// /// <param name = "index">排序</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_levelEO> GetByIndex(int? index, int top_)
		{
			return GetByIndex(index, top_, string.Empty, null);
		}
		public async Task<List<Sa_signin_levelEO>> GetByIndexAsync(int? index, int top_)
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
		public List<Sa_signin_levelEO> GetByIndex(int? index, int top_, TransactionManager tm_)
		{
			return GetByIndex(index, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_signin_levelEO>> GetByIndexAsync(int? index, int top_, TransactionManager tm_)
		{
			return await GetByIndexAsync(index, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Index（字段） 查询
		/// </summary>
		/// /// <param name = "index">排序</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_levelEO> GetByIndex(int? index, string sort_)
		{
			return GetByIndex(index, 0, sort_, null);
		}
		public async Task<List<Sa_signin_levelEO>> GetByIndexAsync(int? index, string sort_)
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
		public List<Sa_signin_levelEO> GetByIndex(int? index, string sort_, TransactionManager tm_)
		{
			return GetByIndex(index, 0, sort_, tm_);
		}
		public async Task<List<Sa_signin_levelEO>> GetByIndexAsync(int? index, string sort_, TransactionManager tm_)
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
		public List<Sa_signin_levelEO> GetByIndex(int? index, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(index.HasValue ? "`Index` = @Index" : "`Index` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (index.HasValue)
				paras_.Add(Database.CreateInParameter("@Index", index.Value, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_signin_levelEO.MapDataReader);
		}
		public async Task<List<Sa_signin_levelEO>> GetByIndexAsync(int? index, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(index.HasValue ? "`Index` = @Index" : "`Index` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (index.HasValue)
				paras_.Add(Database.CreateInParameter("@Index", index.Value, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_signin_levelEO.MapDataReader);
		}
		#endregion // GetByIndex
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID"></param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_levelEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<Sa_signin_levelEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_levelEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_signin_levelEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_levelEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<Sa_signin_levelEO>> GetByOperatorIDAsync(string operatorID, int top_)
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
		public List<Sa_signin_levelEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_signin_levelEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_levelEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<Sa_signin_levelEO>> GetByOperatorIDAsync(string operatorID, string sort_)
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
		public List<Sa_signin_levelEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<Sa_signin_levelEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
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
		public List<Sa_signin_levelEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operatorID != null ? "`OperatorID` = @OperatorID" : "`OperatorID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operatorID != null)
				paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_signin_levelEO.MapDataReader);
		}
		public async Task<List<Sa_signin_levelEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operatorID != null ? "`OperatorID` = @OperatorID" : "`OperatorID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operatorID != null)
				paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_signin_levelEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByCurrencyId
		
		/// <summary>
		/// 按 CurrencyId（字段） 查询
		/// </summary>
		/// /// <param name = "currencyId"></param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_levelEO> GetByCurrencyId(string currencyId)
		{
			return GetByCurrencyId(currencyId, 0, string.Empty, null);
		}
		public async Task<List<Sa_signin_levelEO>> GetByCurrencyIdAsync(string currencyId)
		{
			return await GetByCurrencyIdAsync(currencyId, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyId（字段） 查询
		/// </summary>
		/// /// <param name = "currencyId"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_levelEO> GetByCurrencyId(string currencyId, TransactionManager tm_)
		{
			return GetByCurrencyId(currencyId, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_signin_levelEO>> GetByCurrencyIdAsync(string currencyId, TransactionManager tm_)
		{
			return await GetByCurrencyIdAsync(currencyId, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyId（字段） 查询
		/// </summary>
		/// /// <param name = "currencyId"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_levelEO> GetByCurrencyId(string currencyId, int top_)
		{
			return GetByCurrencyId(currencyId, top_, string.Empty, null);
		}
		public async Task<List<Sa_signin_levelEO>> GetByCurrencyIdAsync(string currencyId, int top_)
		{
			return await GetByCurrencyIdAsync(currencyId, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyId（字段） 查询
		/// </summary>
		/// /// <param name = "currencyId"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_levelEO> GetByCurrencyId(string currencyId, int top_, TransactionManager tm_)
		{
			return GetByCurrencyId(currencyId, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_signin_levelEO>> GetByCurrencyIdAsync(string currencyId, int top_, TransactionManager tm_)
		{
			return await GetByCurrencyIdAsync(currencyId, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyId（字段） 查询
		/// </summary>
		/// /// <param name = "currencyId"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_levelEO> GetByCurrencyId(string currencyId, string sort_)
		{
			return GetByCurrencyId(currencyId, 0, sort_, null);
		}
		public async Task<List<Sa_signin_levelEO>> GetByCurrencyIdAsync(string currencyId, string sort_)
		{
			return await GetByCurrencyIdAsync(currencyId, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CurrencyId（字段） 查询
		/// </summary>
		/// /// <param name = "currencyId"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_levelEO> GetByCurrencyId(string currencyId, string sort_, TransactionManager tm_)
		{
			return GetByCurrencyId(currencyId, 0, sort_, tm_);
		}
		public async Task<List<Sa_signin_levelEO>> GetByCurrencyIdAsync(string currencyId, string sort_, TransactionManager tm_)
		{
			return await GetByCurrencyIdAsync(currencyId, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyId（字段） 查询
		/// </summary>
		/// /// <param name = "currencyId"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_levelEO> GetByCurrencyId(string currencyId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(currencyId != null ? "`CurrencyId` = @CurrencyId" : "`CurrencyId` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (currencyId != null)
				paras_.Add(Database.CreateInParameter("@CurrencyId", currencyId, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_signin_levelEO.MapDataReader);
		}
		public async Task<List<Sa_signin_levelEO>> GetByCurrencyIdAsync(string currencyId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(currencyId != null ? "`CurrencyId` = @CurrencyId" : "`CurrencyId` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (currencyId != null)
				paras_.Add(Database.CreateInParameter("@CurrencyId", currencyId, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_signin_levelEO.MapDataReader);
		}
		#endregion // GetByCurrencyId
		#region GetByCountryID
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID"></param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_levelEO> GetByCountryID(string countryID)
		{
			return GetByCountryID(countryID, 0, string.Empty, null);
		}
		public async Task<List<Sa_signin_levelEO>> GetByCountryIDAsync(string countryID)
		{
			return await GetByCountryIDAsync(countryID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_levelEO> GetByCountryID(string countryID, TransactionManager tm_)
		{
			return GetByCountryID(countryID, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_signin_levelEO>> GetByCountryIDAsync(string countryID, TransactionManager tm_)
		{
			return await GetByCountryIDAsync(countryID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_levelEO> GetByCountryID(string countryID, int top_)
		{
			return GetByCountryID(countryID, top_, string.Empty, null);
		}
		public async Task<List<Sa_signin_levelEO>> GetByCountryIDAsync(string countryID, int top_)
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
		public List<Sa_signin_levelEO> GetByCountryID(string countryID, int top_, TransactionManager tm_)
		{
			return GetByCountryID(countryID, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_signin_levelEO>> GetByCountryIDAsync(string countryID, int top_, TransactionManager tm_)
		{
			return await GetByCountryIDAsync(countryID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_levelEO> GetByCountryID(string countryID, string sort_)
		{
			return GetByCountryID(countryID, 0, sort_, null);
		}
		public async Task<List<Sa_signin_levelEO>> GetByCountryIDAsync(string countryID, string sort_)
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
		public List<Sa_signin_levelEO> GetByCountryID(string countryID, string sort_, TransactionManager tm_)
		{
			return GetByCountryID(countryID, 0, sort_, tm_);
		}
		public async Task<List<Sa_signin_levelEO>> GetByCountryIDAsync(string countryID, string sort_, TransactionManager tm_)
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
		public List<Sa_signin_levelEO> GetByCountryID(string countryID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(countryID != null ? "`CountryID` = @CountryID" : "`CountryID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (countryID != null)
				paras_.Add(Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_signin_levelEO.MapDataReader);
		}
		public async Task<List<Sa_signin_levelEO>> GetByCountryIDAsync(string countryID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(countryID != null ? "`CountryID` = @CountryID" : "`CountryID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (countryID != null)
				paras_.Add(Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_signin_levelEO.MapDataReader);
		}
		#endregion // GetByCountryID
		#region GetByLevel
		
		/// <summary>
		/// 按 Level（字段） 查询
		/// </summary>
		/// /// <param name = "level">等级</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_levelEO> GetByLevel(int? level)
		{
			return GetByLevel(level, 0, string.Empty, null);
		}
		public async Task<List<Sa_signin_levelEO>> GetByLevelAsync(int? level)
		{
			return await GetByLevelAsync(level, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Level（字段） 查询
		/// </summary>
		/// /// <param name = "level">等级</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_levelEO> GetByLevel(int? level, TransactionManager tm_)
		{
			return GetByLevel(level, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_signin_levelEO>> GetByLevelAsync(int? level, TransactionManager tm_)
		{
			return await GetByLevelAsync(level, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Level（字段） 查询
		/// </summary>
		/// /// <param name = "level">等级</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_levelEO> GetByLevel(int? level, int top_)
		{
			return GetByLevel(level, top_, string.Empty, null);
		}
		public async Task<List<Sa_signin_levelEO>> GetByLevelAsync(int? level, int top_)
		{
			return await GetByLevelAsync(level, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Level（字段） 查询
		/// </summary>
		/// /// <param name = "level">等级</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_levelEO> GetByLevel(int? level, int top_, TransactionManager tm_)
		{
			return GetByLevel(level, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_signin_levelEO>> GetByLevelAsync(int? level, int top_, TransactionManager tm_)
		{
			return await GetByLevelAsync(level, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Level（字段） 查询
		/// </summary>
		/// /// <param name = "level">等级</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_levelEO> GetByLevel(int? level, string sort_)
		{
			return GetByLevel(level, 0, sort_, null);
		}
		public async Task<List<Sa_signin_levelEO>> GetByLevelAsync(int? level, string sort_)
		{
			return await GetByLevelAsync(level, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Level（字段） 查询
		/// </summary>
		/// /// <param name = "level">等级</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_levelEO> GetByLevel(int? level, string sort_, TransactionManager tm_)
		{
			return GetByLevel(level, 0, sort_, tm_);
		}
		public async Task<List<Sa_signin_levelEO>> GetByLevelAsync(int? level, string sort_, TransactionManager tm_)
		{
			return await GetByLevelAsync(level, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Level（字段） 查询
		/// </summary>
		/// /// <param name = "level">等级</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_levelEO> GetByLevel(int? level, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(level.HasValue ? "`Level` = @Level" : "`Level` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (level.HasValue)
				paras_.Add(Database.CreateInParameter("@Level", level.Value, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_signin_levelEO.MapDataReader);
		}
		public async Task<List<Sa_signin_levelEO>> GetByLevelAsync(int? level, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(level.HasValue ? "`Level` = @Level" : "`Level` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (level.HasValue)
				paras_.Add(Database.CreateInParameter("@Level", level.Value, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_signin_levelEO.MapDataReader);
		}
		#endregion // GetByLevel
		#region GetByDays
		
		/// <summary>
		/// 按 Days（字段） 查询
		/// </summary>
		/// /// <param name = "days">连续天数</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_levelEO> GetByDays(int? days)
		{
			return GetByDays(days, 0, string.Empty, null);
		}
		public async Task<List<Sa_signin_levelEO>> GetByDaysAsync(int? days)
		{
			return await GetByDaysAsync(days, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Days（字段） 查询
		/// </summary>
		/// /// <param name = "days">连续天数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_levelEO> GetByDays(int? days, TransactionManager tm_)
		{
			return GetByDays(days, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_signin_levelEO>> GetByDaysAsync(int? days, TransactionManager tm_)
		{
			return await GetByDaysAsync(days, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Days（字段） 查询
		/// </summary>
		/// /// <param name = "days">连续天数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_levelEO> GetByDays(int? days, int top_)
		{
			return GetByDays(days, top_, string.Empty, null);
		}
		public async Task<List<Sa_signin_levelEO>> GetByDaysAsync(int? days, int top_)
		{
			return await GetByDaysAsync(days, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Days（字段） 查询
		/// </summary>
		/// /// <param name = "days">连续天数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_levelEO> GetByDays(int? days, int top_, TransactionManager tm_)
		{
			return GetByDays(days, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_signin_levelEO>> GetByDaysAsync(int? days, int top_, TransactionManager tm_)
		{
			return await GetByDaysAsync(days, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Days（字段） 查询
		/// </summary>
		/// /// <param name = "days">连续天数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_levelEO> GetByDays(int? days, string sort_)
		{
			return GetByDays(days, 0, sort_, null);
		}
		public async Task<List<Sa_signin_levelEO>> GetByDaysAsync(int? days, string sort_)
		{
			return await GetByDaysAsync(days, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Days（字段） 查询
		/// </summary>
		/// /// <param name = "days">连续天数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_levelEO> GetByDays(int? days, string sort_, TransactionManager tm_)
		{
			return GetByDays(days, 0, sort_, tm_);
		}
		public async Task<List<Sa_signin_levelEO>> GetByDaysAsync(int? days, string sort_, TransactionManager tm_)
		{
			return await GetByDaysAsync(days, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Days（字段） 查询
		/// </summary>
		/// /// <param name = "days">连续天数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_signin_levelEO> GetByDays(int? days, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(days.HasValue ? "`Days` = @Days" : "`Days` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (days.HasValue)
				paras_.Add(Database.CreateInParameter("@Days", days.Value, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_signin_levelEO.MapDataReader);
		}
		public async Task<List<Sa_signin_levelEO>> GetByDaysAsync(int? days, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(days.HasValue ? "`Days` = @Days" : "`Days` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (days.HasValue)
				paras_.Add(Database.CreateInParameter("@Days", days.Value, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_signin_levelEO.MapDataReader);
		}
		#endregion // GetByDays
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
