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
	/// 关键字分类
	/// 【表 l_keyword_category 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class L_keyword_categoryEO : IRowMapper<L_keyword_categoryEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public L_keyword_categoryEO()
		{
			this.OrderNum = 0;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private long _originalKCID;
		/// <summary>
		/// 【数据库中的原始主键 KCID 值的副本，用于主键值更新】
		/// </summary>
		public long OriginalKCID
		{
			get { return _originalKCID; }
			set { HasOriginal = true; _originalKCID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "KCID", KCID }, };
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
		public long KCID { get; set; }
		/// <summary>
		/// 名称
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 2)]
		public string KCName { get; set; }
		/// <summary>
		/// 排序
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 3)]
		public int OrderNum { get; set; }
		/// <summary>
		/// 运营商编码
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 4)]
		public string OperatorId { get; set; }
		/// <summary>
		/// 语言编码
		/// 【字段 varchar(10)】
		/// </summary>
		[DataMember(Order = 5)]
		public string LangID { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public L_keyword_categoryEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static L_keyword_categoryEO MapDataReader(IDataReader reader)
		{
		    L_keyword_categoryEO ret = new L_keyword_categoryEO();
			ret.KCID = reader.ToInt64("KCID");
			ret.OriginalKCID = ret.KCID;
			ret.KCName = reader.ToString("KCName");
			ret.OrderNum = reader.ToInt32("OrderNum");
			ret.OperatorId = reader.ToString("OperatorId");
			ret.LangID = reader.ToString("LangID");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 关键字分类
	/// 【表 l_keyword_category 的操作类】
	/// </summary>
	[Obsolete]
	public class L_keyword_categoryMO : MySqlTableMO<L_keyword_categoryEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`l_keyword_category`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public L_keyword_categoryMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public L_keyword_categoryMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public L_keyword_categoryMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(L_keyword_categoryEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			item.KCID = Database.ExecSqlScalar<long>(sql_, paras_, tm_); 
			return 1;
		}
		public override async Task<int> AddAsync(L_keyword_categoryEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			item.KCID = await Database.ExecSqlScalarAsync<long>(sql_, paras_, tm_); 
	        return 1;
		}
	    private void RepairAddData(L_keyword_categoryEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`KCName`, `OrderNum`, `OperatorId`, `LangID`) VALUE (@KCName, @OrderNum, @OperatorId, @LangID);SELECT LAST_INSERT_ID();";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@KCName", item.KCName != null ? item.KCName : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OrderNum", item.OrderNum, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorId", item.OperatorId, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", item.LangID, MySqlDbType.VarChar),
			};
		}
		public int AddByBatch(IEnumerable<L_keyword_categoryEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<L_keyword_categoryEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<L_keyword_categoryEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`KCID`, `KCName`, `OrderNum`, `OperatorId`, `LangID`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"({item.KCID},'{item.KCName}',{item.OrderNum},'{item.OperatorId}','{item.LangID}'),");
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
		/// /// <param name = "kCID"></param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(long kCID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(kCID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(long kCID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(kCID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(long kCID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `KCID` = @KCID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@KCID", kCID, MySqlDbType.Int64),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(L_keyword_categoryEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.KCID, tm_);
		}
		public async Task<int> RemoveAsync(L_keyword_categoryEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.KCID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByKCName
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "kCName">名称</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByKCName(string kCName, TransactionManager tm_ = null)
		{
			RepairRemoveByKCNameData(kCName, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByKCNameAsync(string kCName, TransactionManager tm_ = null)
		{
			RepairRemoveByKCNameData(kCName, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByKCNameData(string kCName, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (kCName != null ? "`KCName` = @KCName" : "`KCName` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (kCName != null)
				paras_.Add(Database.CreateInParameter("@KCName", kCName, MySqlDbType.VarChar));
		}
		#endregion // RemoveByKCName
		#region RemoveByOrderNum
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "orderNum">排序</param>
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
		#region RemoveByOperatorId
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "operatorId">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByOperatorId(string operatorId, TransactionManager tm_ = null)
		{
			RepairRemoveByOperatorIdData(operatorId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByOperatorIdAsync(string operatorId, TransactionManager tm_ = null)
		{
			RepairRemoveByOperatorIdData(operatorId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByOperatorIdData(string operatorId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `OperatorId` = @OperatorId";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorId", operatorId, MySqlDbType.VarChar));
		}
		#endregion // RemoveByOperatorId
		#region RemoveByLangID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "langID">语言编码</param>
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
		public int Put(L_keyword_categoryEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(L_keyword_categoryEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(L_keyword_categoryEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `KCName` = @KCName, `OrderNum` = @OrderNum, `OperatorId` = @OperatorId, `LangID` = @LangID WHERE `KCID` = @KCID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@KCName", item.KCName != null ? item.KCName : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OrderNum", item.OrderNum, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorId", item.OperatorId, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", item.LangID, MySqlDbType.VarChar),
				Database.CreateInParameter("@KCID_Original", item.HasOriginal ? item.OriginalKCID : item.KCID, MySqlDbType.Int64),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<L_keyword_categoryEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<L_keyword_categoryEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "kCID"></param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(long kCID, string set_, params object[] values_)
		{
			return Put(set_, "`KCID` = @KCID", ConcatValues(values_, kCID));
		}
		public async Task<int> PutByPKAsync(long kCID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`KCID` = @KCID", ConcatValues(values_, kCID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "kCID"></param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(long kCID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`KCID` = @KCID", tm_, ConcatValues(values_, kCID));
		}
		public async Task<int> PutByPKAsync(long kCID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`KCID` = @KCID", tm_, ConcatValues(values_, kCID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "kCID"></param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(long kCID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@KCID", kCID, MySqlDbType.Int64),
	        };
			return Put(set_, "`KCID` = @KCID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(long kCID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@KCID", kCID, MySqlDbType.Int64),
	        };
			return await PutAsync(set_, "`KCID` = @KCID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutKCName
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "kCID"></param>
		/// /// <param name = "kCName">名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutKCNameByPK(long kCID, string kCName, TransactionManager tm_ = null)
		{
			RepairPutKCNameByPKData(kCID, kCName, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutKCNameByPKAsync(long kCID, string kCName, TransactionManager tm_ = null)
		{
			RepairPutKCNameByPKData(kCID, kCName, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutKCNameByPKData(long kCID, string kCName, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `KCName` = @KCName  WHERE `KCID` = @KCID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@KCName", kCName != null ? kCName : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@KCID", kCID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "kCName">名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutKCName(string kCName, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `KCName` = @KCName";
			var parameter_ = Database.CreateInParameter("@KCName", kCName != null ? kCName : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutKCNameAsync(string kCName, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `KCName` = @KCName";
			var parameter_ = Database.CreateInParameter("@KCName", kCName != null ? kCName : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutKCName
		#region PutOrderNum
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "kCID"></param>
		/// /// <param name = "orderNum">排序</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOrderNumByPK(long kCID, int orderNum, TransactionManager tm_ = null)
		{
			RepairPutOrderNumByPKData(kCID, orderNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOrderNumByPKAsync(long kCID, int orderNum, TransactionManager tm_ = null)
		{
			RepairPutOrderNumByPKData(kCID, orderNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOrderNumByPKData(long kCID, int orderNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OrderNum` = @OrderNum  WHERE `KCID` = @KCID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderNum", orderNum, MySqlDbType.Int32),
				Database.CreateInParameter("@KCID", kCID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "orderNum">排序</param>
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
		#region PutOperatorId
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "kCID"></param>
		/// /// <param name = "operatorId">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorIdByPK(long kCID, string operatorId, TransactionManager tm_ = null)
		{
			RepairPutOperatorIdByPKData(kCID, operatorId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOperatorIdByPKAsync(long kCID, string operatorId, TransactionManager tm_ = null)
		{
			RepairPutOperatorIdByPKData(kCID, operatorId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOperatorIdByPKData(long kCID, string operatorId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorId` = @OperatorId  WHERE `KCID` = @KCID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorId", operatorId, MySqlDbType.VarChar),
				Database.CreateInParameter("@KCID", kCID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "operatorId">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorId(string operatorId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OperatorId` = @OperatorId";
			var parameter_ = Database.CreateInParameter("@OperatorId", operatorId, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutOperatorIdAsync(string operatorId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OperatorId` = @OperatorId";
			var parameter_ = Database.CreateInParameter("@OperatorId", operatorId, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutOperatorId
		#region PutLangID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "kCID"></param>
		/// /// <param name = "langID">语言编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLangIDByPK(long kCID, string langID, TransactionManager tm_ = null)
		{
			RepairPutLangIDByPKData(kCID, langID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLangIDByPKAsync(long kCID, string langID, TransactionManager tm_ = null)
		{
			RepairPutLangIDByPKData(kCID, langID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLangIDByPKData(long kCID, string langID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `LangID` = @LangID  WHERE `KCID` = @KCID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
				Database.CreateInParameter("@KCID", kCID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "langID">语言编码</param>
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
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(L_keyword_categoryEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.KCID) == null)
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
		public async Task<bool> SetAsync(L_keyword_categoryEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.KCID) == null)
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
		/// /// <param name = "kCID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public L_keyword_categoryEO GetByPK(long kCID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(kCID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, L_keyword_categoryEO.MapDataReader);
		}
		public async Task<L_keyword_categoryEO> GetByPKAsync(long kCID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(kCID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, L_keyword_categoryEO.MapDataReader);
		}
		private void RepairGetByPKData(long kCID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`KCID` = @KCID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@KCID", kCID, MySqlDbType.Int64),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 KCName（字段）
		/// </summary>
		/// /// <param name = "kCID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetKCNameByPK(long kCID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@KCID", kCID, MySqlDbType.Int64),
			};
			return (string)GetScalar("`KCName`", "`KCID` = @KCID", paras_, tm_);
		}
		public async Task<string> GetKCNameByPKAsync(long kCID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@KCID", kCID, MySqlDbType.Int64),
			};
			return (string)await GetScalarAsync("`KCName`", "`KCID` = @KCID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OrderNum（字段）
		/// </summary>
		/// /// <param name = "kCID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetOrderNumByPK(long kCID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@KCID", kCID, MySqlDbType.Int64),
			};
			return (int)GetScalar("`OrderNum`", "`KCID` = @KCID", paras_, tm_);
		}
		public async Task<int> GetOrderNumByPKAsync(long kCID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@KCID", kCID, MySqlDbType.Int64),
			};
			return (int)await GetScalarAsync("`OrderNum`", "`KCID` = @KCID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OperatorId（字段）
		/// </summary>
		/// /// <param name = "kCID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorIdByPK(long kCID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@KCID", kCID, MySqlDbType.Int64),
			};
			return (string)GetScalar("`OperatorId`", "`KCID` = @KCID", paras_, tm_);
		}
		public async Task<string> GetOperatorIdByPKAsync(long kCID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@KCID", kCID, MySqlDbType.Int64),
			};
			return (string)await GetScalarAsync("`OperatorId`", "`KCID` = @KCID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 LangID（字段）
		/// </summary>
		/// /// <param name = "kCID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetLangIDByPK(long kCID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@KCID", kCID, MySqlDbType.Int64),
			};
			return (string)GetScalar("`LangID`", "`KCID` = @KCID", paras_, tm_);
		}
		public async Task<string> GetLangIDByPKAsync(long kCID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@KCID", kCID, MySqlDbType.Int64),
			};
			return (string)await GetScalarAsync("`LangID`", "`KCID` = @KCID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByKCName
		
		/// <summary>
		/// 按 KCName（字段） 查询
		/// </summary>
		/// /// <param name = "kCName">名称</param>
		/// <return>实体对象集合</return>
		public List<L_keyword_categoryEO> GetByKCName(string kCName)
		{
			return GetByKCName(kCName, 0, string.Empty, null);
		}
		public async Task<List<L_keyword_categoryEO>> GetByKCNameAsync(string kCName)
		{
			return await GetByKCNameAsync(kCName, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 KCName（字段） 查询
		/// </summary>
		/// /// <param name = "kCName">名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_keyword_categoryEO> GetByKCName(string kCName, TransactionManager tm_)
		{
			return GetByKCName(kCName, 0, string.Empty, tm_);
		}
		public async Task<List<L_keyword_categoryEO>> GetByKCNameAsync(string kCName, TransactionManager tm_)
		{
			return await GetByKCNameAsync(kCName, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 KCName（字段） 查询
		/// </summary>
		/// /// <param name = "kCName">名称</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_keyword_categoryEO> GetByKCName(string kCName, int top_)
		{
			return GetByKCName(kCName, top_, string.Empty, null);
		}
		public async Task<List<L_keyword_categoryEO>> GetByKCNameAsync(string kCName, int top_)
		{
			return await GetByKCNameAsync(kCName, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 KCName（字段） 查询
		/// </summary>
		/// /// <param name = "kCName">名称</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_keyword_categoryEO> GetByKCName(string kCName, int top_, TransactionManager tm_)
		{
			return GetByKCName(kCName, top_, string.Empty, tm_);
		}
		public async Task<List<L_keyword_categoryEO>> GetByKCNameAsync(string kCName, int top_, TransactionManager tm_)
		{
			return await GetByKCNameAsync(kCName, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 KCName（字段） 查询
		/// </summary>
		/// /// <param name = "kCName">名称</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_keyword_categoryEO> GetByKCName(string kCName, string sort_)
		{
			return GetByKCName(kCName, 0, sort_, null);
		}
		public async Task<List<L_keyword_categoryEO>> GetByKCNameAsync(string kCName, string sort_)
		{
			return await GetByKCNameAsync(kCName, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 KCName（字段） 查询
		/// </summary>
		/// /// <param name = "kCName">名称</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_keyword_categoryEO> GetByKCName(string kCName, string sort_, TransactionManager tm_)
		{
			return GetByKCName(kCName, 0, sort_, tm_);
		}
		public async Task<List<L_keyword_categoryEO>> GetByKCNameAsync(string kCName, string sort_, TransactionManager tm_)
		{
			return await GetByKCNameAsync(kCName, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 KCName（字段） 查询
		/// </summary>
		/// /// <param name = "kCName">名称</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_keyword_categoryEO> GetByKCName(string kCName, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(kCName != null ? "`KCName` = @KCName" : "`KCName` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (kCName != null)
				paras_.Add(Database.CreateInParameter("@KCName", kCName, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_keyword_categoryEO.MapDataReader);
		}
		public async Task<List<L_keyword_categoryEO>> GetByKCNameAsync(string kCName, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(kCName != null ? "`KCName` = @KCName" : "`KCName` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (kCName != null)
				paras_.Add(Database.CreateInParameter("@KCName", kCName, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_keyword_categoryEO.MapDataReader);
		}
		#endregion // GetByKCName
		#region GetByOrderNum
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序</param>
		/// <return>实体对象集合</return>
		public List<L_keyword_categoryEO> GetByOrderNum(int orderNum)
		{
			return GetByOrderNum(orderNum, 0, string.Empty, null);
		}
		public async Task<List<L_keyword_categoryEO>> GetByOrderNumAsync(int orderNum)
		{
			return await GetByOrderNumAsync(orderNum, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_keyword_categoryEO> GetByOrderNum(int orderNum, TransactionManager tm_)
		{
			return GetByOrderNum(orderNum, 0, string.Empty, tm_);
		}
		public async Task<List<L_keyword_categoryEO>> GetByOrderNumAsync(int orderNum, TransactionManager tm_)
		{
			return await GetByOrderNumAsync(orderNum, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_keyword_categoryEO> GetByOrderNum(int orderNum, int top_)
		{
			return GetByOrderNum(orderNum, top_, string.Empty, null);
		}
		public async Task<List<L_keyword_categoryEO>> GetByOrderNumAsync(int orderNum, int top_)
		{
			return await GetByOrderNumAsync(orderNum, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_keyword_categoryEO> GetByOrderNum(int orderNum, int top_, TransactionManager tm_)
		{
			return GetByOrderNum(orderNum, top_, string.Empty, tm_);
		}
		public async Task<List<L_keyword_categoryEO>> GetByOrderNumAsync(int orderNum, int top_, TransactionManager tm_)
		{
			return await GetByOrderNumAsync(orderNum, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_keyword_categoryEO> GetByOrderNum(int orderNum, string sort_)
		{
			return GetByOrderNum(orderNum, 0, sort_, null);
		}
		public async Task<List<L_keyword_categoryEO>> GetByOrderNumAsync(int orderNum, string sort_)
		{
			return await GetByOrderNumAsync(orderNum, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_keyword_categoryEO> GetByOrderNum(int orderNum, string sort_, TransactionManager tm_)
		{
			return GetByOrderNum(orderNum, 0, sort_, tm_);
		}
		public async Task<List<L_keyword_categoryEO>> GetByOrderNumAsync(int orderNum, string sort_, TransactionManager tm_)
		{
			return await GetByOrderNumAsync(orderNum, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_keyword_categoryEO> GetByOrderNum(int orderNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OrderNum` = @OrderNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OrderNum", orderNum, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, L_keyword_categoryEO.MapDataReader);
		}
		public async Task<List<L_keyword_categoryEO>> GetByOrderNumAsync(int orderNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OrderNum` = @OrderNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OrderNum", orderNum, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_keyword_categoryEO.MapDataReader);
		}
		#endregion // GetByOrderNum
		#region GetByOperatorId
		
		/// <summary>
		/// 按 OperatorId（字段） 查询
		/// </summary>
		/// /// <param name = "operatorId">运营商编码</param>
		/// <return>实体对象集合</return>
		public List<L_keyword_categoryEO> GetByOperatorId(string operatorId)
		{
			return GetByOperatorId(operatorId, 0, string.Empty, null);
		}
		public async Task<List<L_keyword_categoryEO>> GetByOperatorIdAsync(string operatorId)
		{
			return await GetByOperatorIdAsync(operatorId, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorId（字段） 查询
		/// </summary>
		/// /// <param name = "operatorId">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_keyword_categoryEO> GetByOperatorId(string operatorId, TransactionManager tm_)
		{
			return GetByOperatorId(operatorId, 0, string.Empty, tm_);
		}
		public async Task<List<L_keyword_categoryEO>> GetByOperatorIdAsync(string operatorId, TransactionManager tm_)
		{
			return await GetByOperatorIdAsync(operatorId, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorId（字段） 查询
		/// </summary>
		/// /// <param name = "operatorId">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_keyword_categoryEO> GetByOperatorId(string operatorId, int top_)
		{
			return GetByOperatorId(operatorId, top_, string.Empty, null);
		}
		public async Task<List<L_keyword_categoryEO>> GetByOperatorIdAsync(string operatorId, int top_)
		{
			return await GetByOperatorIdAsync(operatorId, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorId（字段） 查询
		/// </summary>
		/// /// <param name = "operatorId">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_keyword_categoryEO> GetByOperatorId(string operatorId, int top_, TransactionManager tm_)
		{
			return GetByOperatorId(operatorId, top_, string.Empty, tm_);
		}
		public async Task<List<L_keyword_categoryEO>> GetByOperatorIdAsync(string operatorId, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIdAsync(operatorId, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorId（字段） 查询
		/// </summary>
		/// /// <param name = "operatorId">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_keyword_categoryEO> GetByOperatorId(string operatorId, string sort_)
		{
			return GetByOperatorId(operatorId, 0, sort_, null);
		}
		public async Task<List<L_keyword_categoryEO>> GetByOperatorIdAsync(string operatorId, string sort_)
		{
			return await GetByOperatorIdAsync(operatorId, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OperatorId（字段） 查询
		/// </summary>
		/// /// <param name = "operatorId">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_keyword_categoryEO> GetByOperatorId(string operatorId, string sort_, TransactionManager tm_)
		{
			return GetByOperatorId(operatorId, 0, sort_, tm_);
		}
		public async Task<List<L_keyword_categoryEO>> GetByOperatorIdAsync(string operatorId, string sort_, TransactionManager tm_)
		{
			return await GetByOperatorIdAsync(operatorId, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OperatorId（字段） 查询
		/// </summary>
		/// /// <param name = "operatorId">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_keyword_categoryEO> GetByOperatorId(string operatorId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorId` = @OperatorId", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorId", operatorId, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_keyword_categoryEO.MapDataReader);
		}
		public async Task<List<L_keyword_categoryEO>> GetByOperatorIdAsync(string operatorId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorId` = @OperatorId", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorId", operatorId, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_keyword_categoryEO.MapDataReader);
		}
		#endregion // GetByOperatorId
		#region GetByLangID
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言编码</param>
		/// <return>实体对象集合</return>
		public List<L_keyword_categoryEO> GetByLangID(string langID)
		{
			return GetByLangID(langID, 0, string.Empty, null);
		}
		public async Task<List<L_keyword_categoryEO>> GetByLangIDAsync(string langID)
		{
			return await GetByLangIDAsync(langID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_keyword_categoryEO> GetByLangID(string langID, TransactionManager tm_)
		{
			return GetByLangID(langID, 0, string.Empty, tm_);
		}
		public async Task<List<L_keyword_categoryEO>> GetByLangIDAsync(string langID, TransactionManager tm_)
		{
			return await GetByLangIDAsync(langID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_keyword_categoryEO> GetByLangID(string langID, int top_)
		{
			return GetByLangID(langID, top_, string.Empty, null);
		}
		public async Task<List<L_keyword_categoryEO>> GetByLangIDAsync(string langID, int top_)
		{
			return await GetByLangIDAsync(langID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_keyword_categoryEO> GetByLangID(string langID, int top_, TransactionManager tm_)
		{
			return GetByLangID(langID, top_, string.Empty, tm_);
		}
		public async Task<List<L_keyword_categoryEO>> GetByLangIDAsync(string langID, int top_, TransactionManager tm_)
		{
			return await GetByLangIDAsync(langID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_keyword_categoryEO> GetByLangID(string langID, string sort_)
		{
			return GetByLangID(langID, 0, sort_, null);
		}
		public async Task<List<L_keyword_categoryEO>> GetByLangIDAsync(string langID, string sort_)
		{
			return await GetByLangIDAsync(langID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_keyword_categoryEO> GetByLangID(string langID, string sort_, TransactionManager tm_)
		{
			return GetByLangID(langID, 0, sort_, tm_);
		}
		public async Task<List<L_keyword_categoryEO>> GetByLangIDAsync(string langID, string sort_, TransactionManager tm_)
		{
			return await GetByLangIDAsync(langID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_keyword_categoryEO> GetByLangID(string langID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LangID` = @LangID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_keyword_categoryEO.MapDataReader);
		}
		public async Task<List<L_keyword_categoryEO>> GetByLangIDAsync(string langID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LangID` = @LangID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_keyword_categoryEO.MapDataReader);
		}
		#endregion // GetByLangID
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
