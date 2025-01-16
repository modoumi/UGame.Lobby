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
	/// 任务提示定义表，前端进入指定地方触发任务提示，有进入游戏时，进入大厅时，进入存款页面时
	/// 【表 sat_tips 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Sat_tipsEO : IRowMapper<Sat_tipsEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Sat_tipsEO()
		{
			this.Status = 1;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private int _originalTipsID;
		/// <summary>
		/// 【数据库中的原始主键 TipsID 值的副本，用于主键值更新】
		/// </summary>
		public int OriginalTipsID
		{
			get { return _originalTipsID; }
			set { HasOriginal = true; _originalTipsID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "TipsID", TipsID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 提示ID
		/// 【主键 int】
		/// </summary>
		[DataMember(Order = 1)]
		public int TipsID { get; set; }
		/// <summary>
		/// 描述
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 2)]
		public string Description { get; set; }
		/// <summary>
		/// 状态(0-无效1-有效)
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 3)]
		public int Status { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Sat_tipsEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Sat_tipsEO MapDataReader(IDataReader reader)
		{
		    Sat_tipsEO ret = new Sat_tipsEO();
			ret.TipsID = reader.ToInt32("TipsID");
			ret.OriginalTipsID = ret.TipsID;
			ret.Description = reader.ToString("Description");
			ret.Status = reader.ToInt32("Status");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 任务提示定义表，前端进入指定地方触发任务提示，有进入游戏时，进入大厅时，进入存款页面时
	/// 【表 sat_tips 的操作类】
	/// </summary>
	[Obsolete]
	public class Sat_tipsMO : MySqlTableMO<Sat_tipsEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`sat_tips`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Sat_tipsMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Sat_tipsMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Sat_tipsMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Sat_tipsEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Sat_tipsEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Sat_tipsEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`TipsID`, `Description`, `Status`) VALUE (@TipsID, @Description, @Status);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TipsID", item.TipsID, MySqlDbType.Int32),
				Database.CreateInParameter("@Description", item.Description, MySqlDbType.VarChar),
				Database.CreateInParameter("@Status", item.Status, MySqlDbType.Int32),
			};
		}
		public int AddByBatch(IEnumerable<Sat_tipsEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Sat_tipsEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sat_tipsEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`TipsID`, `Description`, `Status`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"({item.TipsID},'{item.Description}',{item.Status}),");
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
		/// /// <param name = "tipsID">提示ID</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(int tipsID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(tipsID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(int tipsID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(tipsID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(int tipsID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `TipsID` = @TipsID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TipsID", tipsID, MySqlDbType.Int32),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Sat_tipsEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.TipsID, tm_);
		}
		public async Task<int> RemoveAsync(Sat_tipsEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.TipsID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByDescription
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "description">描述</param>
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
			sql_ = $"DELETE FROM {TableName} WHERE `Description` = @Description";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Description", description, MySqlDbType.VarChar));
		}
		#endregion // RemoveByDescription
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
		public int Put(Sat_tipsEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Sat_tipsEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Sat_tipsEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `TipsID` = @TipsID, `Description` = @Description, `Status` = @Status WHERE `TipsID` = @TipsID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TipsID", item.TipsID, MySqlDbType.Int32),
				Database.CreateInParameter("@Description", item.Description, MySqlDbType.VarChar),
				Database.CreateInParameter("@Status", item.Status, MySqlDbType.Int32),
				Database.CreateInParameter("@TipsID_Original", item.HasOriginal ? item.OriginalTipsID : item.TipsID, MySqlDbType.Int32),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Sat_tipsEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Sat_tipsEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "tipsID">提示ID</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int tipsID, string set_, params object[] values_)
		{
			return Put(set_, "`TipsID` = @TipsID", ConcatValues(values_, tipsID));
		}
		public async Task<int> PutByPKAsync(int tipsID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`TipsID` = @TipsID", ConcatValues(values_, tipsID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "tipsID">提示ID</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int tipsID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`TipsID` = @TipsID", tm_, ConcatValues(values_, tipsID));
		}
		public async Task<int> PutByPKAsync(int tipsID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`TipsID` = @TipsID", tm_, ConcatValues(values_, tipsID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "tipsID">提示ID</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int tipsID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@TipsID", tipsID, MySqlDbType.Int32),
	        };
			return Put(set_, "`TipsID` = @TipsID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(int tipsID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@TipsID", tipsID, MySqlDbType.Int32),
	        };
			return await PutAsync(set_, "`TipsID` = @TipsID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutDescription
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "tipsID">提示ID</param>
		/// /// <param name = "description">描述</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutDescriptionByPK(int tipsID, string description, TransactionManager tm_ = null)
		{
			RepairPutDescriptionByPKData(tipsID, description, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutDescriptionByPKAsync(int tipsID, string description, TransactionManager tm_ = null)
		{
			RepairPutDescriptionByPKData(tipsID, description, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutDescriptionByPKData(int tipsID, string description, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Description` = @Description  WHERE `TipsID` = @TipsID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Description", description, MySqlDbType.VarChar),
				Database.CreateInParameter("@TipsID", tipsID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "description">描述</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutDescription(string description, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Description` = @Description";
			var parameter_ = Database.CreateInParameter("@Description", description, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutDescriptionAsync(string description, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Description` = @Description";
			var parameter_ = Database.CreateInParameter("@Description", description, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutDescription
		#region PutStatus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "tipsID">提示ID</param>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutStatusByPK(int tipsID, int status, TransactionManager tm_ = null)
		{
			RepairPutStatusByPKData(tipsID, status, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutStatusByPKAsync(int tipsID, int status, TransactionManager tm_ = null)
		{
			RepairPutStatusByPKData(tipsID, status, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutStatusByPKData(int tipsID, int status, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Status` = @Status  WHERE `TipsID` = @TipsID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Status", status, MySqlDbType.Int32),
				Database.CreateInParameter("@TipsID", tipsID, MySqlDbType.Int32),
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
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Sat_tipsEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.TipsID) == null)
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
		public async Task<bool> SetAsync(Sat_tipsEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.TipsID) == null)
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
		/// /// <param name = "tipsID">提示ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Sat_tipsEO GetByPK(int tipsID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(tipsID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sat_tipsEO.MapDataReader);
		}
		public async Task<Sat_tipsEO> GetByPKAsync(int tipsID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(tipsID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sat_tipsEO.MapDataReader);
		}
		private void RepairGetByPKData(int tipsID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`TipsID` = @TipsID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TipsID", tipsID, MySqlDbType.Int32),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 Description（字段）
		/// </summary>
		/// /// <param name = "tipsID">提示ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetDescriptionByPK(int tipsID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TipsID", tipsID, MySqlDbType.Int32),
			};
			return (string)GetScalar("`Description`", "`TipsID` = @TipsID", paras_, tm_);
		}
		public async Task<string> GetDescriptionByPKAsync(int tipsID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TipsID", tipsID, MySqlDbType.Int32),
			};
			return (string)await GetScalarAsync("`Description`", "`TipsID` = @TipsID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Status（字段）
		/// </summary>
		/// /// <param name = "tipsID">提示ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetStatusByPK(int tipsID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TipsID", tipsID, MySqlDbType.Int32),
			};
			return (int)GetScalar("`Status`", "`TipsID` = @TipsID", paras_, tm_);
		}
		public async Task<int> GetStatusByPKAsync(int tipsID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TipsID", tipsID, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`Status`", "`TipsID` = @TipsID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByDescription
		
		/// <summary>
		/// 按 Description（字段） 查询
		/// </summary>
		/// /// <param name = "description">描述</param>
		/// <return>实体对象集合</return>
		public List<Sat_tipsEO> GetByDescription(string description)
		{
			return GetByDescription(description, 0, string.Empty, null);
		}
		public async Task<List<Sat_tipsEO>> GetByDescriptionAsync(string description)
		{
			return await GetByDescriptionAsync(description, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Description（字段） 查询
		/// </summary>
		/// /// <param name = "description">描述</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_tipsEO> GetByDescription(string description, TransactionManager tm_)
		{
			return GetByDescription(description, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_tipsEO>> GetByDescriptionAsync(string description, TransactionManager tm_)
		{
			return await GetByDescriptionAsync(description, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Description（字段） 查询
		/// </summary>
		/// /// <param name = "description">描述</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_tipsEO> GetByDescription(string description, int top_)
		{
			return GetByDescription(description, top_, string.Empty, null);
		}
		public async Task<List<Sat_tipsEO>> GetByDescriptionAsync(string description, int top_)
		{
			return await GetByDescriptionAsync(description, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Description（字段） 查询
		/// </summary>
		/// /// <param name = "description">描述</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_tipsEO> GetByDescription(string description, int top_, TransactionManager tm_)
		{
			return GetByDescription(description, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_tipsEO>> GetByDescriptionAsync(string description, int top_, TransactionManager tm_)
		{
			return await GetByDescriptionAsync(description, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Description（字段） 查询
		/// </summary>
		/// /// <param name = "description">描述</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_tipsEO> GetByDescription(string description, string sort_)
		{
			return GetByDescription(description, 0, sort_, null);
		}
		public async Task<List<Sat_tipsEO>> GetByDescriptionAsync(string description, string sort_)
		{
			return await GetByDescriptionAsync(description, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Description（字段） 查询
		/// </summary>
		/// /// <param name = "description">描述</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_tipsEO> GetByDescription(string description, string sort_, TransactionManager tm_)
		{
			return GetByDescription(description, 0, sort_, tm_);
		}
		public async Task<List<Sat_tipsEO>> GetByDescriptionAsync(string description, string sort_, TransactionManager tm_)
		{
			return await GetByDescriptionAsync(description, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Description（字段） 查询
		/// </summary>
		/// /// <param name = "description">描述</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_tipsEO> GetByDescription(string description, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Description` = @Description", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Description", description, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_tipsEO.MapDataReader);
		}
		public async Task<List<Sat_tipsEO>> GetByDescriptionAsync(string description, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Description` = @Description", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Description", description, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_tipsEO.MapDataReader);
		}
		#endregion // GetByDescription
		#region GetByStatus
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <return>实体对象集合</return>
		public List<Sat_tipsEO> GetByStatus(int status)
		{
			return GetByStatus(status, 0, string.Empty, null);
		}
		public async Task<List<Sat_tipsEO>> GetByStatusAsync(int status)
		{
			return await GetByStatusAsync(status, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_tipsEO> GetByStatus(int status, TransactionManager tm_)
		{
			return GetByStatus(status, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_tipsEO>> GetByStatusAsync(int status, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_tipsEO> GetByStatus(int status, int top_)
		{
			return GetByStatus(status, top_, string.Empty, null);
		}
		public async Task<List<Sat_tipsEO>> GetByStatusAsync(int status, int top_)
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
		public List<Sat_tipsEO> GetByStatus(int status, int top_, TransactionManager tm_)
		{
			return GetByStatus(status, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_tipsEO>> GetByStatusAsync(int status, int top_, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_tipsEO> GetByStatus(int status, string sort_)
		{
			return GetByStatus(status, 0, sort_, null);
		}
		public async Task<List<Sat_tipsEO>> GetByStatusAsync(int status, string sort_)
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
		public List<Sat_tipsEO> GetByStatus(int status, string sort_, TransactionManager tm_)
		{
			return GetByStatus(status, 0, sort_, tm_);
		}
		public async Task<List<Sat_tipsEO>> GetByStatusAsync(int status, string sort_, TransactionManager tm_)
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
		public List<Sat_tipsEO> GetByStatus(int status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_tipsEO.MapDataReader);
		}
		public async Task<List<Sat_tipsEO>> GetByStatusAsync(int status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_tipsEO.MapDataReader);
		}
		#endregion // GetByStatus
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
