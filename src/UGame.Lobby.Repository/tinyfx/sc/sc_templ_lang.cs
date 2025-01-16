/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * AiUo代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/AiUo
 * 文档生成时间：2023-10-24 18: 04:57
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
	/// 通用多语言模板
	/// 【表 sc_templ_lang 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Sc_templ_langEO : IRowMapper<Sc_templ_langEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Sc_templ_langEO()
		{
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private int _originalSCTemplateID;
		/// <summary>
		/// 【数据库中的原始主键 SCTemplateID 值的副本，用于主键值更新】
		/// </summary>
		public int OriginalSCTemplateID
		{
			get { return _originalSCTemplateID; }
			set { HasOriginal = true; _originalSCTemplateID = value; }
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
	        return new Dictionary<string, object>() { { "SCTemplateID", SCTemplateID },  { "LangID", LangID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 模板编码
		/// 【主键 int】
		/// </summary>
		[DataMember(Order = 1)]
		public int SCTemplateID { get; set; }
		/// <summary>
		/// 语言代码
		/// 【主键 varchar(20)】
		/// </summary>
		[DataMember(Order = 2)]
		public string LangID { get; set; }
		/// <summary>
		/// 内容，如:恭喜{userId}你获得{amount}金额
		/// 【字段 text】
		/// </summary>
		[DataMember(Order = 3)]
		public string Content { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Sc_templ_langEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Sc_templ_langEO MapDataReader(IDataReader reader)
		{
		    Sc_templ_langEO ret = new Sc_templ_langEO();
			ret.SCTemplateID = reader.ToInt32("SCTemplateID");
			ret.OriginalSCTemplateID = ret.SCTemplateID;
			ret.LangID = reader.ToString("LangID");
			ret.OriginalLangID = ret.LangID;
			ret.Content = reader.ToString("Content");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 通用多语言模板
	/// 【表 sc_templ_lang 的操作类】
	/// </summary>
	[Obsolete]
	public class Sc_templ_langMO : MySqlTableMO<Sc_templ_langEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`sc_templ_lang`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Sc_templ_langMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Sc_templ_langMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Sc_templ_langMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Sc_templ_langEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Sc_templ_langEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Sc_templ_langEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`SCTemplateID`, `LangID`, `Content`) VALUE (@SCTemplateID, @LangID, @Content);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SCTemplateID", item.SCTemplateID, MySqlDbType.Int32),
				Database.CreateInParameter("@LangID", item.LangID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Content", item.Content != null ? item.Content : (object)DBNull.Value, MySqlDbType.Text),
			};
		}
		public int AddByBatch(IEnumerable<Sc_templ_langEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Sc_templ_langEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sc_templ_langEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`SCTemplateID`, `LangID`, `Content`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"({item.SCTemplateID},'{item.LangID}','{item.Content}'),");
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
		/// /// <param name = "sCTemplateID">模板编码</param>
		/// /// <param name = "langID">语言代码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(int sCTemplateID, string langID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(sCTemplateID, langID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(int sCTemplateID, string langID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(sCTemplateID, langID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(int sCTemplateID, string langID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `SCTemplateID` = @SCTemplateID AND `LangID` = @LangID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SCTemplateID", sCTemplateID, MySqlDbType.Int32),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Sc_templ_langEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.SCTemplateID, item.LangID, tm_);
		}
		public async Task<int> RemoveAsync(Sc_templ_langEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.SCTemplateID, item.LangID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveBySCTemplateID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "sCTemplateID">模板编码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveBySCTemplateID(int sCTemplateID, TransactionManager tm_ = null)
		{
			RepairRemoveBySCTemplateIDData(sCTemplateID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveBySCTemplateIDAsync(int sCTemplateID, TransactionManager tm_ = null)
		{
			RepairRemoveBySCTemplateIDData(sCTemplateID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveBySCTemplateIDData(int sCTemplateID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `SCTemplateID` = @SCTemplateID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SCTemplateID", sCTemplateID, MySqlDbType.Int32));
		}
		#endregion // RemoveBySCTemplateID
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
			sql_ = $"DELETE FROM {TableName} WHERE `LangID` = @LangID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByLangID
		#region RemoveByContent
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "content">内容，如:恭喜{userId}你获得{amount}金额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByContent(string content, TransactionManager tm_ = null)
		{
			RepairRemoveByContentData(content, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByContentAsync(string content, TransactionManager tm_ = null)
		{
			RepairRemoveByContentData(content, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByContentData(string content, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (content != null ? "`Content` = @Content" : "`Content` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (content != null)
				paras_.Add(Database.CreateInParameter("@Content", content, MySqlDbType.Text));
		}
		#endregion // RemoveByContent
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
		public int Put(Sc_templ_langEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Sc_templ_langEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Sc_templ_langEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `SCTemplateID` = @SCTemplateID, `LangID` = @LangID, `Content` = @Content WHERE `SCTemplateID` = @SCTemplateID_Original AND `LangID` = @LangID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SCTemplateID", item.SCTemplateID, MySqlDbType.Int32),
				Database.CreateInParameter("@LangID", item.LangID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Content", item.Content != null ? item.Content : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@SCTemplateID_Original", item.HasOriginal ? item.OriginalSCTemplateID : item.SCTemplateID, MySqlDbType.Int32),
				Database.CreateInParameter("@LangID_Original", item.HasOriginal ? item.OriginalLangID : item.LangID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Sc_templ_langEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Sc_templ_langEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "sCTemplateID">模板编码</param>
		/// /// <param name = "langID">语言代码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int sCTemplateID, string langID, string set_, params object[] values_)
		{
			return Put(set_, "`SCTemplateID` = @SCTemplateID AND `LangID` = @LangID", ConcatValues(values_, sCTemplateID, langID));
		}
		public async Task<int> PutByPKAsync(int sCTemplateID, string langID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`SCTemplateID` = @SCTemplateID AND `LangID` = @LangID", ConcatValues(values_, sCTemplateID, langID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "sCTemplateID">模板编码</param>
		/// /// <param name = "langID">语言代码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int sCTemplateID, string langID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`SCTemplateID` = @SCTemplateID AND `LangID` = @LangID", tm_, ConcatValues(values_, sCTemplateID, langID));
		}
		public async Task<int> PutByPKAsync(int sCTemplateID, string langID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`SCTemplateID` = @SCTemplateID AND `LangID` = @LangID", tm_, ConcatValues(values_, sCTemplateID, langID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "sCTemplateID">模板编码</param>
		/// /// <param name = "langID">语言代码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int sCTemplateID, string langID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@SCTemplateID", sCTemplateID, MySqlDbType.Int32),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`SCTemplateID` = @SCTemplateID AND `LangID` = @LangID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(int sCTemplateID, string langID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@SCTemplateID", sCTemplateID, MySqlDbType.Int32),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`SCTemplateID` = @SCTemplateID AND `LangID` = @LangID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutSCTemplateID
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "sCTemplateID">模板编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSCTemplateID(int sCTemplateID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SCTemplateID` = @SCTemplateID";
			var parameter_ = Database.CreateInParameter("@SCTemplateID", sCTemplateID, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutSCTemplateIDAsync(int sCTemplateID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SCTemplateID` = @SCTemplateID";
			var parameter_ = Database.CreateInParameter("@SCTemplateID", sCTemplateID, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutSCTemplateID
		#region PutLangID
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "langID">语言代码</param>
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
		#region PutContent
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "sCTemplateID">模板编码</param>
		/// /// <param name = "langID">语言代码</param>
		/// /// <param name = "content">内容，如:恭喜{userId}你获得{amount}金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutContentByPK(int sCTemplateID, string langID, string content, TransactionManager tm_ = null)
		{
			RepairPutContentByPKData(sCTemplateID, langID, content, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutContentByPKAsync(int sCTemplateID, string langID, string content, TransactionManager tm_ = null)
		{
			RepairPutContentByPKData(sCTemplateID, langID, content, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutContentByPKData(int sCTemplateID, string langID, string content, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Content` = @Content  WHERE `SCTemplateID` = @SCTemplateID AND `LangID` = @LangID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Content", content != null ? content : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@SCTemplateID", sCTemplateID, MySqlDbType.Int32),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "content">内容，如:恭喜{userId}你获得{amount}金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutContent(string content, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Content` = @Content";
			var parameter_ = Database.CreateInParameter("@Content", content != null ? content : (object)DBNull.Value, MySqlDbType.Text);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutContentAsync(string content, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Content` = @Content";
			var parameter_ = Database.CreateInParameter("@Content", content != null ? content : (object)DBNull.Value, MySqlDbType.Text);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutContent
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Sc_templ_langEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.SCTemplateID, item.LangID) == null)
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
		public async Task<bool> SetAsync(Sc_templ_langEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.SCTemplateID, item.LangID) == null)
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
		/// /// <param name = "sCTemplateID">模板编码</param>
		/// /// <param name = "langID">语言代码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Sc_templ_langEO GetByPK(int sCTemplateID, string langID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(sCTemplateID, langID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sc_templ_langEO.MapDataReader);
		}
		public async Task<Sc_templ_langEO> GetByPKAsync(int sCTemplateID, string langID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(sCTemplateID, langID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sc_templ_langEO.MapDataReader);
		}
		private void RepairGetByPKData(int sCTemplateID, string langID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`SCTemplateID` = @SCTemplateID AND `LangID` = @LangID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SCTemplateID", sCTemplateID, MySqlDbType.Int32),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 SCTemplateID（字段）
		/// </summary>
		/// /// <param name = "sCTemplateID">模板编码</param>
		/// /// <param name = "langID">语言代码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetSCTemplateIDByPK(int sCTemplateID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SCTemplateID", sCTemplateID, MySqlDbType.Int32),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`SCTemplateID`", "`SCTemplateID` = @SCTemplateID AND `LangID` = @LangID", paras_, tm_);
		}
		public async Task<int> GetSCTemplateIDByPKAsync(int sCTemplateID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SCTemplateID", sCTemplateID, MySqlDbType.Int32),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`SCTemplateID`", "`SCTemplateID` = @SCTemplateID AND `LangID` = @LangID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 LangID（字段）
		/// </summary>
		/// /// <param name = "sCTemplateID">模板编码</param>
		/// /// <param name = "langID">语言代码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetLangIDByPK(int sCTemplateID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SCTemplateID", sCTemplateID, MySqlDbType.Int32),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`LangID`", "`SCTemplateID` = @SCTemplateID AND `LangID` = @LangID", paras_, tm_);
		}
		public async Task<string> GetLangIDByPKAsync(int sCTemplateID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SCTemplateID", sCTemplateID, MySqlDbType.Int32),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`LangID`", "`SCTemplateID` = @SCTemplateID AND `LangID` = @LangID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Content（字段）
		/// </summary>
		/// /// <param name = "sCTemplateID">模板编码</param>
		/// /// <param name = "langID">语言代码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetContentByPK(int sCTemplateID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SCTemplateID", sCTemplateID, MySqlDbType.Int32),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Content`", "`SCTemplateID` = @SCTemplateID AND `LangID` = @LangID", paras_, tm_);
		}
		public async Task<string> GetContentByPKAsync(int sCTemplateID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SCTemplateID", sCTemplateID, MySqlDbType.Int32),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Content`", "`SCTemplateID` = @SCTemplateID AND `LangID` = @LangID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetBySCTemplateID
		
		/// <summary>
		/// 按 SCTemplateID（字段） 查询
		/// </summary>
		/// /// <param name = "sCTemplateID">模板编码</param>
		/// <return>实体对象集合</return>
		public List<Sc_templ_langEO> GetBySCTemplateID(int sCTemplateID)
		{
			return GetBySCTemplateID(sCTemplateID, 0, string.Empty, null);
		}
		public async Task<List<Sc_templ_langEO>> GetBySCTemplateIDAsync(int sCTemplateID)
		{
			return await GetBySCTemplateIDAsync(sCTemplateID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SCTemplateID（字段） 查询
		/// </summary>
		/// /// <param name = "sCTemplateID">模板编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_templ_langEO> GetBySCTemplateID(int sCTemplateID, TransactionManager tm_)
		{
			return GetBySCTemplateID(sCTemplateID, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_templ_langEO>> GetBySCTemplateIDAsync(int sCTemplateID, TransactionManager tm_)
		{
			return await GetBySCTemplateIDAsync(sCTemplateID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SCTemplateID（字段） 查询
		/// </summary>
		/// /// <param name = "sCTemplateID">模板编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_templ_langEO> GetBySCTemplateID(int sCTemplateID, int top_)
		{
			return GetBySCTemplateID(sCTemplateID, top_, string.Empty, null);
		}
		public async Task<List<Sc_templ_langEO>> GetBySCTemplateIDAsync(int sCTemplateID, int top_)
		{
			return await GetBySCTemplateIDAsync(sCTemplateID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SCTemplateID（字段） 查询
		/// </summary>
		/// /// <param name = "sCTemplateID">模板编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_templ_langEO> GetBySCTemplateID(int sCTemplateID, int top_, TransactionManager tm_)
		{
			return GetBySCTemplateID(sCTemplateID, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_templ_langEO>> GetBySCTemplateIDAsync(int sCTemplateID, int top_, TransactionManager tm_)
		{
			return await GetBySCTemplateIDAsync(sCTemplateID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SCTemplateID（字段） 查询
		/// </summary>
		/// /// <param name = "sCTemplateID">模板编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_templ_langEO> GetBySCTemplateID(int sCTemplateID, string sort_)
		{
			return GetBySCTemplateID(sCTemplateID, 0, sort_, null);
		}
		public async Task<List<Sc_templ_langEO>> GetBySCTemplateIDAsync(int sCTemplateID, string sort_)
		{
			return await GetBySCTemplateIDAsync(sCTemplateID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 SCTemplateID（字段） 查询
		/// </summary>
		/// /// <param name = "sCTemplateID">模板编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_templ_langEO> GetBySCTemplateID(int sCTemplateID, string sort_, TransactionManager tm_)
		{
			return GetBySCTemplateID(sCTemplateID, 0, sort_, tm_);
		}
		public async Task<List<Sc_templ_langEO>> GetBySCTemplateIDAsync(int sCTemplateID, string sort_, TransactionManager tm_)
		{
			return await GetBySCTemplateIDAsync(sCTemplateID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 SCTemplateID（字段） 查询
		/// </summary>
		/// /// <param name = "sCTemplateID">模板编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_templ_langEO> GetBySCTemplateID(int sCTemplateID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SCTemplateID` = @SCTemplateID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SCTemplateID", sCTemplateID, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_templ_langEO.MapDataReader);
		}
		public async Task<List<Sc_templ_langEO>> GetBySCTemplateIDAsync(int sCTemplateID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SCTemplateID` = @SCTemplateID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SCTemplateID", sCTemplateID, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_templ_langEO.MapDataReader);
		}
		#endregion // GetBySCTemplateID
		#region GetByLangID
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言代码</param>
		/// <return>实体对象集合</return>
		public List<Sc_templ_langEO> GetByLangID(string langID)
		{
			return GetByLangID(langID, 0, string.Empty, null);
		}
		public async Task<List<Sc_templ_langEO>> GetByLangIDAsync(string langID)
		{
			return await GetByLangIDAsync(langID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言代码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_templ_langEO> GetByLangID(string langID, TransactionManager tm_)
		{
			return GetByLangID(langID, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_templ_langEO>> GetByLangIDAsync(string langID, TransactionManager tm_)
		{
			return await GetByLangIDAsync(langID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言代码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_templ_langEO> GetByLangID(string langID, int top_)
		{
			return GetByLangID(langID, top_, string.Empty, null);
		}
		public async Task<List<Sc_templ_langEO>> GetByLangIDAsync(string langID, int top_)
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
		public List<Sc_templ_langEO> GetByLangID(string langID, int top_, TransactionManager tm_)
		{
			return GetByLangID(langID, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_templ_langEO>> GetByLangIDAsync(string langID, int top_, TransactionManager tm_)
		{
			return await GetByLangIDAsync(langID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言代码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_templ_langEO> GetByLangID(string langID, string sort_)
		{
			return GetByLangID(langID, 0, sort_, null);
		}
		public async Task<List<Sc_templ_langEO>> GetByLangIDAsync(string langID, string sort_)
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
		public List<Sc_templ_langEO> GetByLangID(string langID, string sort_, TransactionManager tm_)
		{
			return GetByLangID(langID, 0, sort_, tm_);
		}
		public async Task<List<Sc_templ_langEO>> GetByLangIDAsync(string langID, string sort_, TransactionManager tm_)
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
		public List<Sc_templ_langEO> GetByLangID(string langID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LangID` = @LangID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_templ_langEO.MapDataReader);
		}
		public async Task<List<Sc_templ_langEO>> GetByLangIDAsync(string langID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LangID` = @LangID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_templ_langEO.MapDataReader);
		}
		#endregion // GetByLangID
		#region GetByContent
		
		/// <summary>
		/// 按 Content（字段） 查询
		/// </summary>
		/// /// <param name = "content">内容，如:恭喜{userId}你获得{amount}金额</param>
		/// <return>实体对象集合</return>
		public List<Sc_templ_langEO> GetByContent(string content)
		{
			return GetByContent(content, 0, string.Empty, null);
		}
		public async Task<List<Sc_templ_langEO>> GetByContentAsync(string content)
		{
			return await GetByContentAsync(content, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Content（字段） 查询
		/// </summary>
		/// /// <param name = "content">内容，如:恭喜{userId}你获得{amount}金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_templ_langEO> GetByContent(string content, TransactionManager tm_)
		{
			return GetByContent(content, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_templ_langEO>> GetByContentAsync(string content, TransactionManager tm_)
		{
			return await GetByContentAsync(content, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Content（字段） 查询
		/// </summary>
		/// /// <param name = "content">内容，如:恭喜{userId}你获得{amount}金额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_templ_langEO> GetByContent(string content, int top_)
		{
			return GetByContent(content, top_, string.Empty, null);
		}
		public async Task<List<Sc_templ_langEO>> GetByContentAsync(string content, int top_)
		{
			return await GetByContentAsync(content, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Content（字段） 查询
		/// </summary>
		/// /// <param name = "content">内容，如:恭喜{userId}你获得{amount}金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_templ_langEO> GetByContent(string content, int top_, TransactionManager tm_)
		{
			return GetByContent(content, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_templ_langEO>> GetByContentAsync(string content, int top_, TransactionManager tm_)
		{
			return await GetByContentAsync(content, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Content（字段） 查询
		/// </summary>
		/// /// <param name = "content">内容，如:恭喜{userId}你获得{amount}金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_templ_langEO> GetByContent(string content, string sort_)
		{
			return GetByContent(content, 0, sort_, null);
		}
		public async Task<List<Sc_templ_langEO>> GetByContentAsync(string content, string sort_)
		{
			return await GetByContentAsync(content, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Content（字段） 查询
		/// </summary>
		/// /// <param name = "content">内容，如:恭喜{userId}你获得{amount}金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_templ_langEO> GetByContent(string content, string sort_, TransactionManager tm_)
		{
			return GetByContent(content, 0, sort_, tm_);
		}
		public async Task<List<Sc_templ_langEO>> GetByContentAsync(string content, string sort_, TransactionManager tm_)
		{
			return await GetByContentAsync(content, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Content（字段） 查询
		/// </summary>
		/// /// <param name = "content">内容，如:恭喜{userId}你获得{amount}金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_templ_langEO> GetByContent(string content, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(content != null ? "`Content` = @Content" : "`Content` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (content != null)
				paras_.Add(Database.CreateInParameter("@Content", content, MySqlDbType.Text));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_templ_langEO.MapDataReader);
		}
		public async Task<List<Sc_templ_langEO>> GetByContentAsync(string content, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(content != null ? "`Content` = @Content" : "`Content` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (content != null)
				paras_.Add(Database.CreateInParameter("@Content", content, MySqlDbType.Text));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_templ_langEO.MapDataReader);
		}
		#endregion // GetByContent
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
