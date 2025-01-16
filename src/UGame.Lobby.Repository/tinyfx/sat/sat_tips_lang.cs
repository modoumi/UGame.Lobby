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
	/// 任务提示多语言表
	/// 【表 sat_tips_lang 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Sat_tips_langEO : IRowMapper<Sat_tips_langEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Sat_tips_langEO()
		{
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
		
		private string _originalLangID;
		/// <summary>
		/// 【数据库中的原始主键 LangID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalLangID
		{
			get { return _originalLangID; }
			set { HasOriginal = true; _originalLangID = value; }
		}
		
		private string _originalOperatorID;
		/// <summary>
		/// 【数据库中的原始主键 OperatorID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalOperatorID
		{
			get { return _originalOperatorID; }
			set { HasOriginal = true; _originalOperatorID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "TipsID", TipsID },  { "LangID", LangID },  { "OperatorID", OperatorID }, };
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
		/// 运营商ID
		/// 【主键 varchar(50)】
		/// </summary>
		[DataMember(Order = 2)]
		public string OperatorID { get; set; }
		/// <summary>
		/// 语言ID
		/// 【主键 varchar(20)】
		/// </summary>
		[DataMember(Order = 3)]
		public string LangID { get; set; }
		/// <summary>
		/// 提示模板
		/// 【字段 varchar(500)】
		/// </summary>
		[DataMember(Order = 4)]
		public string Template { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Sat_tips_langEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Sat_tips_langEO MapDataReader(IDataReader reader)
		{
		    Sat_tips_langEO ret = new Sat_tips_langEO();
			ret.TipsID = reader.ToInt32("TipsID");
			ret.OriginalTipsID = ret.TipsID;
			ret.OperatorID = reader.ToString("OperatorID");
			ret.OriginalOperatorID = ret.OperatorID;
			ret.LangID = reader.ToString("LangID");
			ret.OriginalLangID = ret.LangID;
			ret.Template = reader.ToString("Template");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 任务提示多语言表
	/// 【表 sat_tips_lang 的操作类】
	/// </summary>
	[Obsolete]
	public class Sat_tips_langMO : MySqlTableMO<Sat_tips_langEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`sat_tips_lang`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Sat_tips_langMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Sat_tips_langMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Sat_tips_langMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Sat_tips_langEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Sat_tips_langEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Sat_tips_langEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`TipsID`, `OperatorID`, `LangID`, `Template`) VALUE (@TipsID, @OperatorID, @LangID, @Template);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TipsID", item.TipsID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", item.LangID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Template", item.Template != null ? item.Template : (object)DBNull.Value, MySqlDbType.VarChar),
			};
		}
		public int AddByBatch(IEnumerable<Sat_tips_langEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Sat_tips_langEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sat_tips_langEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`TipsID`, `OperatorID`, `LangID`, `Template`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"({item.TipsID},'{item.OperatorID}','{item.LangID}','{item.Template}'),");
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
		/// /// <param name = "langID">语言ID</param>
		/// /// <param name = "operatorID">运营商ID</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(int tipsID, string langID, string operatorID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(tipsID, langID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(int tipsID, string langID, string operatorID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(tipsID, langID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(int tipsID, string langID, string operatorID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `TipsID` = @TipsID AND `LangID` = @LangID AND `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TipsID", tipsID, MySqlDbType.Int32),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Sat_tips_langEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.TipsID, item.LangID, item.OperatorID, tm_);
		}
		public async Task<int> RemoveAsync(Sat_tips_langEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.TipsID, item.LangID, item.OperatorID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByTipsID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "tipsID">提示ID</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTipsID(int tipsID, TransactionManager tm_ = null)
		{
			RepairRemoveByTipsIDData(tipsID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTipsIDAsync(int tipsID, TransactionManager tm_ = null)
		{
			RepairRemoveByTipsIDData(tipsID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTipsIDData(int tipsID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `TipsID` = @TipsID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TipsID", tipsID, MySqlDbType.Int32));
		}
		#endregion // RemoveByTipsID
		#region RemoveByOperatorID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "operatorID">运营商ID</param>
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
		#region RemoveByLangID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "langID">语言ID</param>
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
		#region RemoveByTemplate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "template">提示模板</param>
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
				paras_.Add(Database.CreateInParameter("@Template", template, MySqlDbType.VarChar));
		}
		#endregion // RemoveByTemplate
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
		public int Put(Sat_tips_langEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Sat_tips_langEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Sat_tips_langEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `TipsID` = @TipsID, `OperatorID` = @OperatorID, `LangID` = @LangID, `Template` = @Template WHERE `TipsID` = @TipsID_Original AND `LangID` = @LangID_Original AND `OperatorID` = @OperatorID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TipsID", item.TipsID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", item.LangID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Template", item.Template != null ? item.Template : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@TipsID_Original", item.HasOriginal ? item.OriginalTipsID : item.TipsID, MySqlDbType.Int32),
				Database.CreateInParameter("@LangID_Original", item.HasOriginal ? item.OriginalLangID : item.LangID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID_Original", item.HasOriginal ? item.OriginalOperatorID : item.OperatorID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Sat_tips_langEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Sat_tips_langEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "langID">语言ID</param>
		/// /// <param name = "operatorID">运营商ID</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int tipsID, string langID, string operatorID, string set_, params object[] values_)
		{
			return Put(set_, "`TipsID` = @TipsID AND `LangID` = @LangID AND `OperatorID` = @OperatorID", ConcatValues(values_, tipsID, langID, operatorID));
		}
		public async Task<int> PutByPKAsync(int tipsID, string langID, string operatorID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`TipsID` = @TipsID AND `LangID` = @LangID AND `OperatorID` = @OperatorID", ConcatValues(values_, tipsID, langID, operatorID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "tipsID">提示ID</param>
		/// /// <param name = "langID">语言ID</param>
		/// /// <param name = "operatorID">运营商ID</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int tipsID, string langID, string operatorID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`TipsID` = @TipsID AND `LangID` = @LangID AND `OperatorID` = @OperatorID", tm_, ConcatValues(values_, tipsID, langID, operatorID));
		}
		public async Task<int> PutByPKAsync(int tipsID, string langID, string operatorID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`TipsID` = @TipsID AND `LangID` = @LangID AND `OperatorID` = @OperatorID", tm_, ConcatValues(values_, tipsID, langID, operatorID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "tipsID">提示ID</param>
		/// /// <param name = "langID">语言ID</param>
		/// /// <param name = "operatorID">运营商ID</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int tipsID, string langID, string operatorID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@TipsID", tipsID, MySqlDbType.Int32),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`TipsID` = @TipsID AND `LangID` = @LangID AND `OperatorID` = @OperatorID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(int tipsID, string langID, string operatorID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@TipsID", tipsID, MySqlDbType.Int32),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`TipsID` = @TipsID AND `LangID` = @LangID AND `OperatorID` = @OperatorID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutTipsID
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "tipsID">提示ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTipsID(int tipsID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TipsID` = @TipsID";
			var parameter_ = Database.CreateInParameter("@TipsID", tipsID, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTipsIDAsync(int tipsID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TipsID` = @TipsID";
			var parameter_ = Database.CreateInParameter("@TipsID", tipsID, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTipsID
		#region PutOperatorID
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商ID</param>
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
		#region PutLangID
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "langID">语言ID</param>
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
		#region PutTemplate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "tipsID">提示ID</param>
		/// /// <param name = "langID">语言ID</param>
		/// /// <param name = "operatorID">运营商ID</param>
		/// /// <param name = "template">提示模板</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTemplateByPK(int tipsID, string langID, string operatorID, string template, TransactionManager tm_ = null)
		{
			RepairPutTemplateByPKData(tipsID, langID, operatorID, template, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTemplateByPKAsync(int tipsID, string langID, string operatorID, string template, TransactionManager tm_ = null)
		{
			RepairPutTemplateByPKData(tipsID, langID, operatorID, template, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTemplateByPKData(int tipsID, string langID, string operatorID, string template, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Template` = @Template  WHERE `TipsID` = @TipsID AND `LangID` = @LangID AND `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Template", template != null ? template : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@TipsID", tipsID, MySqlDbType.Int32),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "template">提示模板</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTemplate(string template, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Template` = @Template";
			var parameter_ = Database.CreateInParameter("@Template", template != null ? template : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTemplateAsync(string template, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Template` = @Template";
			var parameter_ = Database.CreateInParameter("@Template", template != null ? template : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTemplate
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Sat_tips_langEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.TipsID, item.LangID, item.OperatorID) == null)
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
		public async Task<bool> SetAsync(Sat_tips_langEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.TipsID, item.LangID, item.OperatorID) == null)
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
		/// /// <param name = "langID">语言ID</param>
		/// /// <param name = "operatorID">运营商ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Sat_tips_langEO GetByPK(int tipsID, string langID, string operatorID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(tipsID, langID, operatorID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sat_tips_langEO.MapDataReader);
		}
		public async Task<Sat_tips_langEO> GetByPKAsync(int tipsID, string langID, string operatorID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(tipsID, langID, operatorID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sat_tips_langEO.MapDataReader);
		}
		private void RepairGetByPKData(int tipsID, string langID, string operatorID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`TipsID` = @TipsID AND `LangID` = @LangID AND `OperatorID` = @OperatorID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TipsID", tipsID, MySqlDbType.Int32),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 TipsID（字段）
		/// </summary>
		/// /// <param name = "tipsID">提示ID</param>
		/// /// <param name = "langID">语言ID</param>
		/// /// <param name = "operatorID">运营商ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetTipsIDByPK(int tipsID, string langID, string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TipsID", tipsID, MySqlDbType.Int32),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`TipsID`", "`TipsID` = @TipsID AND `LangID` = @LangID AND `OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<int> GetTipsIDByPKAsync(int tipsID, string langID, string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TipsID", tipsID, MySqlDbType.Int32),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`TipsID`", "`TipsID` = @TipsID AND `LangID` = @LangID AND `OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OperatorID（字段）
		/// </summary>
		/// /// <param name = "tipsID">提示ID</param>
		/// /// <param name = "langID">语言ID</param>
		/// /// <param name = "operatorID">运营商ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorIDByPK(int tipsID, string langID, string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TipsID", tipsID, MySqlDbType.Int32),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OperatorID`", "`TipsID` = @TipsID AND `LangID` = @LangID AND `OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<string> GetOperatorIDByPKAsync(int tipsID, string langID, string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TipsID", tipsID, MySqlDbType.Int32),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OperatorID`", "`TipsID` = @TipsID AND `LangID` = @LangID AND `OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 LangID（字段）
		/// </summary>
		/// /// <param name = "tipsID">提示ID</param>
		/// /// <param name = "langID">语言ID</param>
		/// /// <param name = "operatorID">运营商ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetLangIDByPK(int tipsID, string langID, string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TipsID", tipsID, MySqlDbType.Int32),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`LangID`", "`TipsID` = @TipsID AND `LangID` = @LangID AND `OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<string> GetLangIDByPKAsync(int tipsID, string langID, string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TipsID", tipsID, MySqlDbType.Int32),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`LangID`", "`TipsID` = @TipsID AND `LangID` = @LangID AND `OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Template（字段）
		/// </summary>
		/// /// <param name = "tipsID">提示ID</param>
		/// /// <param name = "langID">语言ID</param>
		/// /// <param name = "operatorID">运营商ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetTemplateByPK(int tipsID, string langID, string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TipsID", tipsID, MySqlDbType.Int32),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Template`", "`TipsID` = @TipsID AND `LangID` = @LangID AND `OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<string> GetTemplateByPKAsync(int tipsID, string langID, string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TipsID", tipsID, MySqlDbType.Int32),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Template`", "`TipsID` = @TipsID AND `LangID` = @LangID AND `OperatorID` = @OperatorID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByTipsID
		
		/// <summary>
		/// 按 TipsID（字段） 查询
		/// </summary>
		/// /// <param name = "tipsID">提示ID</param>
		/// <return>实体对象集合</return>
		public List<Sat_tips_langEO> GetByTipsID(int tipsID)
		{
			return GetByTipsID(tipsID, 0, string.Empty, null);
		}
		public async Task<List<Sat_tips_langEO>> GetByTipsIDAsync(int tipsID)
		{
			return await GetByTipsIDAsync(tipsID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TipsID（字段） 查询
		/// </summary>
		/// /// <param name = "tipsID">提示ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_tips_langEO> GetByTipsID(int tipsID, TransactionManager tm_)
		{
			return GetByTipsID(tipsID, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_tips_langEO>> GetByTipsIDAsync(int tipsID, TransactionManager tm_)
		{
			return await GetByTipsIDAsync(tipsID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TipsID（字段） 查询
		/// </summary>
		/// /// <param name = "tipsID">提示ID</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_tips_langEO> GetByTipsID(int tipsID, int top_)
		{
			return GetByTipsID(tipsID, top_, string.Empty, null);
		}
		public async Task<List<Sat_tips_langEO>> GetByTipsIDAsync(int tipsID, int top_)
		{
			return await GetByTipsIDAsync(tipsID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TipsID（字段） 查询
		/// </summary>
		/// /// <param name = "tipsID">提示ID</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_tips_langEO> GetByTipsID(int tipsID, int top_, TransactionManager tm_)
		{
			return GetByTipsID(tipsID, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_tips_langEO>> GetByTipsIDAsync(int tipsID, int top_, TransactionManager tm_)
		{
			return await GetByTipsIDAsync(tipsID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TipsID（字段） 查询
		/// </summary>
		/// /// <param name = "tipsID">提示ID</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_tips_langEO> GetByTipsID(int tipsID, string sort_)
		{
			return GetByTipsID(tipsID, 0, sort_, null);
		}
		public async Task<List<Sat_tips_langEO>> GetByTipsIDAsync(int tipsID, string sort_)
		{
			return await GetByTipsIDAsync(tipsID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 TipsID（字段） 查询
		/// </summary>
		/// /// <param name = "tipsID">提示ID</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_tips_langEO> GetByTipsID(int tipsID, string sort_, TransactionManager tm_)
		{
			return GetByTipsID(tipsID, 0, sort_, tm_);
		}
		public async Task<List<Sat_tips_langEO>> GetByTipsIDAsync(int tipsID, string sort_, TransactionManager tm_)
		{
			return await GetByTipsIDAsync(tipsID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 TipsID（字段） 查询
		/// </summary>
		/// /// <param name = "tipsID">提示ID</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_tips_langEO> GetByTipsID(int tipsID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TipsID` = @TipsID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TipsID", tipsID, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_tips_langEO.MapDataReader);
		}
		public async Task<List<Sat_tips_langEO>> GetByTipsIDAsync(int tipsID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TipsID` = @TipsID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TipsID", tipsID, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_tips_langEO.MapDataReader);
		}
		#endregion // GetByTipsID
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商ID</param>
		/// <return>实体对象集合</return>
		public List<Sat_tips_langEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<Sat_tips_langEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_tips_langEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_tips_langEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商ID</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_tips_langEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<Sat_tips_langEO>> GetByOperatorIDAsync(string operatorID, int top_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商ID</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_tips_langEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_tips_langEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商ID</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_tips_langEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<Sat_tips_langEO>> GetByOperatorIDAsync(string operatorID, string sort_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商ID</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_tips_langEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<Sat_tips_langEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商ID</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_tips_langEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_tips_langEO.MapDataReader);
		}
		public async Task<List<Sat_tips_langEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_tips_langEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByLangID
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言ID</param>
		/// <return>实体对象集合</return>
		public List<Sat_tips_langEO> GetByLangID(string langID)
		{
			return GetByLangID(langID, 0, string.Empty, null);
		}
		public async Task<List<Sat_tips_langEO>> GetByLangIDAsync(string langID)
		{
			return await GetByLangIDAsync(langID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_tips_langEO> GetByLangID(string langID, TransactionManager tm_)
		{
			return GetByLangID(langID, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_tips_langEO>> GetByLangIDAsync(string langID, TransactionManager tm_)
		{
			return await GetByLangIDAsync(langID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言ID</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_tips_langEO> GetByLangID(string langID, int top_)
		{
			return GetByLangID(langID, top_, string.Empty, null);
		}
		public async Task<List<Sat_tips_langEO>> GetByLangIDAsync(string langID, int top_)
		{
			return await GetByLangIDAsync(langID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言ID</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_tips_langEO> GetByLangID(string langID, int top_, TransactionManager tm_)
		{
			return GetByLangID(langID, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_tips_langEO>> GetByLangIDAsync(string langID, int top_, TransactionManager tm_)
		{
			return await GetByLangIDAsync(langID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言ID</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_tips_langEO> GetByLangID(string langID, string sort_)
		{
			return GetByLangID(langID, 0, sort_, null);
		}
		public async Task<List<Sat_tips_langEO>> GetByLangIDAsync(string langID, string sort_)
		{
			return await GetByLangIDAsync(langID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言ID</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_tips_langEO> GetByLangID(string langID, string sort_, TransactionManager tm_)
		{
			return GetByLangID(langID, 0, sort_, tm_);
		}
		public async Task<List<Sat_tips_langEO>> GetByLangIDAsync(string langID, string sort_, TransactionManager tm_)
		{
			return await GetByLangIDAsync(langID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言ID</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_tips_langEO> GetByLangID(string langID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LangID` = @LangID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_tips_langEO.MapDataReader);
		}
		public async Task<List<Sat_tips_langEO>> GetByLangIDAsync(string langID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LangID` = @LangID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_tips_langEO.MapDataReader);
		}
		#endregion // GetByLangID
		#region GetByTemplate
		
		/// <summary>
		/// 按 Template（字段） 查询
		/// </summary>
		/// /// <param name = "template">提示模板</param>
		/// <return>实体对象集合</return>
		public List<Sat_tips_langEO> GetByTemplate(string template)
		{
			return GetByTemplate(template, 0, string.Empty, null);
		}
		public async Task<List<Sat_tips_langEO>> GetByTemplateAsync(string template)
		{
			return await GetByTemplateAsync(template, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Template（字段） 查询
		/// </summary>
		/// /// <param name = "template">提示模板</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_tips_langEO> GetByTemplate(string template, TransactionManager tm_)
		{
			return GetByTemplate(template, 0, string.Empty, tm_);
		}
		public async Task<List<Sat_tips_langEO>> GetByTemplateAsync(string template, TransactionManager tm_)
		{
			return await GetByTemplateAsync(template, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Template（字段） 查询
		/// </summary>
		/// /// <param name = "template">提示模板</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sat_tips_langEO> GetByTemplate(string template, int top_)
		{
			return GetByTemplate(template, top_, string.Empty, null);
		}
		public async Task<List<Sat_tips_langEO>> GetByTemplateAsync(string template, int top_)
		{
			return await GetByTemplateAsync(template, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Template（字段） 查询
		/// </summary>
		/// /// <param name = "template">提示模板</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_tips_langEO> GetByTemplate(string template, int top_, TransactionManager tm_)
		{
			return GetByTemplate(template, top_, string.Empty, tm_);
		}
		public async Task<List<Sat_tips_langEO>> GetByTemplateAsync(string template, int top_, TransactionManager tm_)
		{
			return await GetByTemplateAsync(template, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Template（字段） 查询
		/// </summary>
		/// /// <param name = "template">提示模板</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sat_tips_langEO> GetByTemplate(string template, string sort_)
		{
			return GetByTemplate(template, 0, sort_, null);
		}
		public async Task<List<Sat_tips_langEO>> GetByTemplateAsync(string template, string sort_)
		{
			return await GetByTemplateAsync(template, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Template（字段） 查询
		/// </summary>
		/// /// <param name = "template">提示模板</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_tips_langEO> GetByTemplate(string template, string sort_, TransactionManager tm_)
		{
			return GetByTemplate(template, 0, sort_, tm_);
		}
		public async Task<List<Sat_tips_langEO>> GetByTemplateAsync(string template, string sort_, TransactionManager tm_)
		{
			return await GetByTemplateAsync(template, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Template（字段） 查询
		/// </summary>
		/// /// <param name = "template">提示模板</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sat_tips_langEO> GetByTemplate(string template, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(template != null ? "`Template` = @Template" : "`Template` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (template != null)
				paras_.Add(Database.CreateInParameter("@Template", template, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sat_tips_langEO.MapDataReader);
		}
		public async Task<List<Sat_tips_langEO>> GetByTemplateAsync(string template, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(template != null ? "`Template` = @Template" : "`Template` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (template != null)
				paras_.Add(Database.CreateInParameter("@Template", template, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sat_tips_langEO.MapDataReader);
		}
		#endregion // GetByTemplate
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
