/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * AiUo代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/AiUo
 * 文档生成时间：2023-10-24 18: 05:06
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
	/// 通用模板定义
	/// 【表 sc_templ 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Sc_templEO : IRowMapper<Sc_templEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Sc_templEO()
		{
			this.TemplateType = 0;
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
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "SCTemplateID", SCTemplateID }, };
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
		/// 模板类型0-文字marquee，1图片marquee
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 2)]
		public int TemplateType { get; set; }
		/// <summary>
		/// 标题
		/// 【字段 varchar(200)】
		/// </summary>
		[DataMember(Order = 3)]
		public string Title { get; set; }
		/// <summary>
		/// 参数对应的实体类
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 4)]
		public string ParamsTypeName { get; set; }
		/// <summary>
		/// 应用程序集
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 5)]
		public string ParamsNameSpace { get; set; }
		/// <summary>
		/// 描述
		/// 【字段 text】
		/// </summary>
		[DataMember(Order = 6)]
		public string Note { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Sc_templEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Sc_templEO MapDataReader(IDataReader reader)
		{
		    Sc_templEO ret = new Sc_templEO();
			ret.SCTemplateID = reader.ToInt32("SCTemplateID");
			ret.OriginalSCTemplateID = ret.SCTemplateID;
			ret.TemplateType = reader.ToInt32("TemplateType");
			ret.Title = reader.ToString("Title");
			ret.ParamsTypeName = reader.ToString("ParamsTypeName");
			ret.ParamsNameSpace = reader.ToString("ParamsNameSpace");
			ret.Note = reader.ToString("Note");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 通用模板定义
	/// 【表 sc_templ 的操作类】
	/// </summary>
	[Obsolete]
	public class Sc_templMO : MySqlTableMO<Sc_templEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`sc_templ`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Sc_templMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Sc_templMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Sc_templMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Sc_templEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Sc_templEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Sc_templEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`SCTemplateID`, `TemplateType`, `Title`, `ParamsTypeName`, `ParamsNameSpace`, `Note`) VALUE (@SCTemplateID, @TemplateType, @Title, @ParamsTypeName, @ParamsNameSpace, @Note);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SCTemplateID", item.SCTemplateID, MySqlDbType.Int32),
				Database.CreateInParameter("@TemplateType", item.TemplateType, MySqlDbType.Int32),
				Database.CreateInParameter("@Title", item.Title != null ? item.Title : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ParamsTypeName", item.ParamsTypeName != null ? item.ParamsTypeName : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ParamsNameSpace", item.ParamsNameSpace != null ? item.ParamsNameSpace : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Note", item.Note != null ? item.Note : (object)DBNull.Value, MySqlDbType.Text),
			};
		}
		public int AddByBatch(IEnumerable<Sc_templEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Sc_templEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sc_templEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`SCTemplateID`, `TemplateType`, `Title`, `ParamsTypeName`, `ParamsNameSpace`, `Note`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"({item.SCTemplateID},{item.TemplateType},'{item.Title}','{item.ParamsTypeName}','{item.ParamsNameSpace}','{item.Note}'),");
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
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(int sCTemplateID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(sCTemplateID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(int sCTemplateID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(sCTemplateID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(int sCTemplateID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `SCTemplateID` = @SCTemplateID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SCTemplateID", sCTemplateID, MySqlDbType.Int32),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Sc_templEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.SCTemplateID, tm_);
		}
		public async Task<int> RemoveAsync(Sc_templEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.SCTemplateID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByTemplateType
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "templateType">模板类型0-文字marquee，1图片marquee</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTemplateType(int templateType, TransactionManager tm_ = null)
		{
			RepairRemoveByTemplateTypeData(templateType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTemplateTypeAsync(int templateType, TransactionManager tm_ = null)
		{
			RepairRemoveByTemplateTypeData(templateType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTemplateTypeData(int templateType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `TemplateType` = @TemplateType";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TemplateType", templateType, MySqlDbType.Int32));
		}
		#endregion // RemoveByTemplateType
		#region RemoveByTitle
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "title">标题</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTitle(string title, TransactionManager tm_ = null)
		{
			RepairRemoveByTitleData(title, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTitleAsync(string title, TransactionManager tm_ = null)
		{
			RepairRemoveByTitleData(title, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTitleData(string title, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (title != null ? "`Title` = @Title" : "`Title` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (title != null)
				paras_.Add(Database.CreateInParameter("@Title", title, MySqlDbType.VarChar));
		}
		#endregion // RemoveByTitle
		#region RemoveByParamsTypeName
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "paramsTypeName">参数对应的实体类</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByParamsTypeName(string paramsTypeName, TransactionManager tm_ = null)
		{
			RepairRemoveByParamsTypeNameData(paramsTypeName, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByParamsTypeNameAsync(string paramsTypeName, TransactionManager tm_ = null)
		{
			RepairRemoveByParamsTypeNameData(paramsTypeName, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByParamsTypeNameData(string paramsTypeName, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (paramsTypeName != null ? "`ParamsTypeName` = @ParamsTypeName" : "`ParamsTypeName` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (paramsTypeName != null)
				paras_.Add(Database.CreateInParameter("@ParamsTypeName", paramsTypeName, MySqlDbType.VarChar));
		}
		#endregion // RemoveByParamsTypeName
		#region RemoveByParamsNameSpace
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "paramsNameSpace">应用程序集</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByParamsNameSpace(string paramsNameSpace, TransactionManager tm_ = null)
		{
			RepairRemoveByParamsNameSpaceData(paramsNameSpace, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByParamsNameSpaceAsync(string paramsNameSpace, TransactionManager tm_ = null)
		{
			RepairRemoveByParamsNameSpaceData(paramsNameSpace, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByParamsNameSpaceData(string paramsNameSpace, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (paramsNameSpace != null ? "`ParamsNameSpace` = @ParamsNameSpace" : "`ParamsNameSpace` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (paramsNameSpace != null)
				paras_.Add(Database.CreateInParameter("@ParamsNameSpace", paramsNameSpace, MySqlDbType.VarChar));
		}
		#endregion // RemoveByParamsNameSpace
		#region RemoveByNote
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "note">描述</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByNote(string note, TransactionManager tm_ = null)
		{
			RepairRemoveByNoteData(note, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByNoteAsync(string note, TransactionManager tm_ = null)
		{
			RepairRemoveByNoteData(note, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByNoteData(string note, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (note != null ? "`Note` = @Note" : "`Note` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (note != null)
				paras_.Add(Database.CreateInParameter("@Note", note, MySqlDbType.Text));
		}
		#endregion // RemoveByNote
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
		public int Put(Sc_templEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Sc_templEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Sc_templEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `SCTemplateID` = @SCTemplateID, `TemplateType` = @TemplateType, `Title` = @Title, `ParamsTypeName` = @ParamsTypeName, `ParamsNameSpace` = @ParamsNameSpace, `Note` = @Note WHERE `SCTemplateID` = @SCTemplateID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SCTemplateID", item.SCTemplateID, MySqlDbType.Int32),
				Database.CreateInParameter("@TemplateType", item.TemplateType, MySqlDbType.Int32),
				Database.CreateInParameter("@Title", item.Title != null ? item.Title : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ParamsTypeName", item.ParamsTypeName != null ? item.ParamsTypeName : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ParamsNameSpace", item.ParamsNameSpace != null ? item.ParamsNameSpace : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Note", item.Note != null ? item.Note : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@SCTemplateID_Original", item.HasOriginal ? item.OriginalSCTemplateID : item.SCTemplateID, MySqlDbType.Int32),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Sc_templEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Sc_templEO> items, TransactionManager tm_ = null)
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
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int sCTemplateID, string set_, params object[] values_)
		{
			return Put(set_, "`SCTemplateID` = @SCTemplateID", ConcatValues(values_, sCTemplateID));
		}
		public async Task<int> PutByPKAsync(int sCTemplateID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`SCTemplateID` = @SCTemplateID", ConcatValues(values_, sCTemplateID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "sCTemplateID">模板编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int sCTemplateID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`SCTemplateID` = @SCTemplateID", tm_, ConcatValues(values_, sCTemplateID));
		}
		public async Task<int> PutByPKAsync(int sCTemplateID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`SCTemplateID` = @SCTemplateID", tm_, ConcatValues(values_, sCTemplateID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "sCTemplateID">模板编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int sCTemplateID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@SCTemplateID", sCTemplateID, MySqlDbType.Int32),
	        };
			return Put(set_, "`SCTemplateID` = @SCTemplateID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(int sCTemplateID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@SCTemplateID", sCTemplateID, MySqlDbType.Int32),
	        };
			return await PutAsync(set_, "`SCTemplateID` = @SCTemplateID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutTemplateType
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "sCTemplateID">模板编码</param>
		/// /// <param name = "templateType">模板类型0-文字marquee，1图片marquee</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTemplateTypeByPK(int sCTemplateID, int templateType, TransactionManager tm_ = null)
		{
			RepairPutTemplateTypeByPKData(sCTemplateID, templateType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTemplateTypeByPKAsync(int sCTemplateID, int templateType, TransactionManager tm_ = null)
		{
			RepairPutTemplateTypeByPKData(sCTemplateID, templateType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTemplateTypeByPKData(int sCTemplateID, int templateType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `TemplateType` = @TemplateType  WHERE `SCTemplateID` = @SCTemplateID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TemplateType", templateType, MySqlDbType.Int32),
				Database.CreateInParameter("@SCTemplateID", sCTemplateID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "templateType">模板类型0-文字marquee，1图片marquee</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTemplateType(int templateType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TemplateType` = @TemplateType";
			var parameter_ = Database.CreateInParameter("@TemplateType", templateType, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTemplateTypeAsync(int templateType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TemplateType` = @TemplateType";
			var parameter_ = Database.CreateInParameter("@TemplateType", templateType, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTemplateType
		#region PutTitle
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "sCTemplateID">模板编码</param>
		/// /// <param name = "title">标题</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTitleByPK(int sCTemplateID, string title, TransactionManager tm_ = null)
		{
			RepairPutTitleByPKData(sCTemplateID, title, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTitleByPKAsync(int sCTemplateID, string title, TransactionManager tm_ = null)
		{
			RepairPutTitleByPKData(sCTemplateID, title, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTitleByPKData(int sCTemplateID, string title, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Title` = @Title  WHERE `SCTemplateID` = @SCTemplateID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Title", title != null ? title : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@SCTemplateID", sCTemplateID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "title">标题</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTitle(string title, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Title` = @Title";
			var parameter_ = Database.CreateInParameter("@Title", title != null ? title : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTitleAsync(string title, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Title` = @Title";
			var parameter_ = Database.CreateInParameter("@Title", title != null ? title : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTitle
		#region PutParamsTypeName
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "sCTemplateID">模板编码</param>
		/// /// <param name = "paramsTypeName">参数对应的实体类</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutParamsTypeNameByPK(int sCTemplateID, string paramsTypeName, TransactionManager tm_ = null)
		{
			RepairPutParamsTypeNameByPKData(sCTemplateID, paramsTypeName, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutParamsTypeNameByPKAsync(int sCTemplateID, string paramsTypeName, TransactionManager tm_ = null)
		{
			RepairPutParamsTypeNameByPKData(sCTemplateID, paramsTypeName, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutParamsTypeNameByPKData(int sCTemplateID, string paramsTypeName, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ParamsTypeName` = @ParamsTypeName  WHERE `SCTemplateID` = @SCTemplateID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ParamsTypeName", paramsTypeName != null ? paramsTypeName : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@SCTemplateID", sCTemplateID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "paramsTypeName">参数对应的实体类</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutParamsTypeName(string paramsTypeName, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ParamsTypeName` = @ParamsTypeName";
			var parameter_ = Database.CreateInParameter("@ParamsTypeName", paramsTypeName != null ? paramsTypeName : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutParamsTypeNameAsync(string paramsTypeName, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ParamsTypeName` = @ParamsTypeName";
			var parameter_ = Database.CreateInParameter("@ParamsTypeName", paramsTypeName != null ? paramsTypeName : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutParamsTypeName
		#region PutParamsNameSpace
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "sCTemplateID">模板编码</param>
		/// /// <param name = "paramsNameSpace">应用程序集</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutParamsNameSpaceByPK(int sCTemplateID, string paramsNameSpace, TransactionManager tm_ = null)
		{
			RepairPutParamsNameSpaceByPKData(sCTemplateID, paramsNameSpace, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutParamsNameSpaceByPKAsync(int sCTemplateID, string paramsNameSpace, TransactionManager tm_ = null)
		{
			RepairPutParamsNameSpaceByPKData(sCTemplateID, paramsNameSpace, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutParamsNameSpaceByPKData(int sCTemplateID, string paramsNameSpace, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ParamsNameSpace` = @ParamsNameSpace  WHERE `SCTemplateID` = @SCTemplateID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ParamsNameSpace", paramsNameSpace != null ? paramsNameSpace : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@SCTemplateID", sCTemplateID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "paramsNameSpace">应用程序集</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutParamsNameSpace(string paramsNameSpace, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ParamsNameSpace` = @ParamsNameSpace";
			var parameter_ = Database.CreateInParameter("@ParamsNameSpace", paramsNameSpace != null ? paramsNameSpace : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutParamsNameSpaceAsync(string paramsNameSpace, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ParamsNameSpace` = @ParamsNameSpace";
			var parameter_ = Database.CreateInParameter("@ParamsNameSpace", paramsNameSpace != null ? paramsNameSpace : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutParamsNameSpace
		#region PutNote
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "sCTemplateID">模板编码</param>
		/// /// <param name = "note">描述</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutNoteByPK(int sCTemplateID, string note, TransactionManager tm_ = null)
		{
			RepairPutNoteByPKData(sCTemplateID, note, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutNoteByPKAsync(int sCTemplateID, string note, TransactionManager tm_ = null)
		{
			RepairPutNoteByPKData(sCTemplateID, note, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutNoteByPKData(int sCTemplateID, string note, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Note` = @Note  WHERE `SCTemplateID` = @SCTemplateID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Note", note != null ? note : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@SCTemplateID", sCTemplateID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "note">描述</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutNote(string note, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Note` = @Note";
			var parameter_ = Database.CreateInParameter("@Note", note != null ? note : (object)DBNull.Value, MySqlDbType.Text);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutNoteAsync(string note, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Note` = @Note";
			var parameter_ = Database.CreateInParameter("@Note", note != null ? note : (object)DBNull.Value, MySqlDbType.Text);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutNote
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Sc_templEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.SCTemplateID) == null)
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
		public async Task<bool> SetAsync(Sc_templEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.SCTemplateID) == null)
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
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Sc_templEO GetByPK(int sCTemplateID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(sCTemplateID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sc_templEO.MapDataReader);
		}
		public async Task<Sc_templEO> GetByPKAsync(int sCTemplateID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(sCTemplateID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sc_templEO.MapDataReader);
		}
		private void RepairGetByPKData(int sCTemplateID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`SCTemplateID` = @SCTemplateID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SCTemplateID", sCTemplateID, MySqlDbType.Int32),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 TemplateType（字段）
		/// </summary>
		/// /// <param name = "sCTemplateID">模板编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetTemplateTypeByPK(int sCTemplateID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SCTemplateID", sCTemplateID, MySqlDbType.Int32),
			};
			return (int)GetScalar("`TemplateType`", "`SCTemplateID` = @SCTemplateID", paras_, tm_);
		}
		public async Task<int> GetTemplateTypeByPKAsync(int sCTemplateID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SCTemplateID", sCTemplateID, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`TemplateType`", "`SCTemplateID` = @SCTemplateID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Title（字段）
		/// </summary>
		/// /// <param name = "sCTemplateID">模板编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetTitleByPK(int sCTemplateID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SCTemplateID", sCTemplateID, MySqlDbType.Int32),
			};
			return (string)GetScalar("`Title`", "`SCTemplateID` = @SCTemplateID", paras_, tm_);
		}
		public async Task<string> GetTitleByPKAsync(int sCTemplateID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SCTemplateID", sCTemplateID, MySqlDbType.Int32),
			};
			return (string)await GetScalarAsync("`Title`", "`SCTemplateID` = @SCTemplateID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ParamsTypeName（字段）
		/// </summary>
		/// /// <param name = "sCTemplateID">模板编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetParamsTypeNameByPK(int sCTemplateID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SCTemplateID", sCTemplateID, MySqlDbType.Int32),
			};
			return (string)GetScalar("`ParamsTypeName`", "`SCTemplateID` = @SCTemplateID", paras_, tm_);
		}
		public async Task<string> GetParamsTypeNameByPKAsync(int sCTemplateID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SCTemplateID", sCTemplateID, MySqlDbType.Int32),
			};
			return (string)await GetScalarAsync("`ParamsTypeName`", "`SCTemplateID` = @SCTemplateID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ParamsNameSpace（字段）
		/// </summary>
		/// /// <param name = "sCTemplateID">模板编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetParamsNameSpaceByPK(int sCTemplateID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SCTemplateID", sCTemplateID, MySqlDbType.Int32),
			};
			return (string)GetScalar("`ParamsNameSpace`", "`SCTemplateID` = @SCTemplateID", paras_, tm_);
		}
		public async Task<string> GetParamsNameSpaceByPKAsync(int sCTemplateID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SCTemplateID", sCTemplateID, MySqlDbType.Int32),
			};
			return (string)await GetScalarAsync("`ParamsNameSpace`", "`SCTemplateID` = @SCTemplateID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Note（字段）
		/// </summary>
		/// /// <param name = "sCTemplateID">模板编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetNoteByPK(int sCTemplateID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SCTemplateID", sCTemplateID, MySqlDbType.Int32),
			};
			return (string)GetScalar("`Note`", "`SCTemplateID` = @SCTemplateID", paras_, tm_);
		}
		public async Task<string> GetNoteByPKAsync(int sCTemplateID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SCTemplateID", sCTemplateID, MySqlDbType.Int32),
			};
			return (string)await GetScalarAsync("`Note`", "`SCTemplateID` = @SCTemplateID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByTemplateType
		
		/// <summary>
		/// 按 TemplateType（字段） 查询
		/// </summary>
		/// /// <param name = "templateType">模板类型0-文字marquee，1图片marquee</param>
		/// <return>实体对象集合</return>
		public List<Sc_templEO> GetByTemplateType(int templateType)
		{
			return GetByTemplateType(templateType, 0, string.Empty, null);
		}
		public async Task<List<Sc_templEO>> GetByTemplateTypeAsync(int templateType)
		{
			return await GetByTemplateTypeAsync(templateType, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TemplateType（字段） 查询
		/// </summary>
		/// /// <param name = "templateType">模板类型0-文字marquee，1图片marquee</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_templEO> GetByTemplateType(int templateType, TransactionManager tm_)
		{
			return GetByTemplateType(templateType, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_templEO>> GetByTemplateTypeAsync(int templateType, TransactionManager tm_)
		{
			return await GetByTemplateTypeAsync(templateType, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TemplateType（字段） 查询
		/// </summary>
		/// /// <param name = "templateType">模板类型0-文字marquee，1图片marquee</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_templEO> GetByTemplateType(int templateType, int top_)
		{
			return GetByTemplateType(templateType, top_, string.Empty, null);
		}
		public async Task<List<Sc_templEO>> GetByTemplateTypeAsync(int templateType, int top_)
		{
			return await GetByTemplateTypeAsync(templateType, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TemplateType（字段） 查询
		/// </summary>
		/// /// <param name = "templateType">模板类型0-文字marquee，1图片marquee</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_templEO> GetByTemplateType(int templateType, int top_, TransactionManager tm_)
		{
			return GetByTemplateType(templateType, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_templEO>> GetByTemplateTypeAsync(int templateType, int top_, TransactionManager tm_)
		{
			return await GetByTemplateTypeAsync(templateType, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TemplateType（字段） 查询
		/// </summary>
		/// /// <param name = "templateType">模板类型0-文字marquee，1图片marquee</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_templEO> GetByTemplateType(int templateType, string sort_)
		{
			return GetByTemplateType(templateType, 0, sort_, null);
		}
		public async Task<List<Sc_templEO>> GetByTemplateTypeAsync(int templateType, string sort_)
		{
			return await GetByTemplateTypeAsync(templateType, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 TemplateType（字段） 查询
		/// </summary>
		/// /// <param name = "templateType">模板类型0-文字marquee，1图片marquee</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_templEO> GetByTemplateType(int templateType, string sort_, TransactionManager tm_)
		{
			return GetByTemplateType(templateType, 0, sort_, tm_);
		}
		public async Task<List<Sc_templEO>> GetByTemplateTypeAsync(int templateType, string sort_, TransactionManager tm_)
		{
			return await GetByTemplateTypeAsync(templateType, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 TemplateType（字段） 查询
		/// </summary>
		/// /// <param name = "templateType">模板类型0-文字marquee，1图片marquee</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_templEO> GetByTemplateType(int templateType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TemplateType` = @TemplateType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TemplateType", templateType, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_templEO.MapDataReader);
		}
		public async Task<List<Sc_templEO>> GetByTemplateTypeAsync(int templateType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TemplateType` = @TemplateType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TemplateType", templateType, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_templEO.MapDataReader);
		}
		#endregion // GetByTemplateType
		#region GetByTitle
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">标题</param>
		/// <return>实体对象集合</return>
		public List<Sc_templEO> GetByTitle(string title)
		{
			return GetByTitle(title, 0, string.Empty, null);
		}
		public async Task<List<Sc_templEO>> GetByTitleAsync(string title)
		{
			return await GetByTitleAsync(title, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">标题</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_templEO> GetByTitle(string title, TransactionManager tm_)
		{
			return GetByTitle(title, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_templEO>> GetByTitleAsync(string title, TransactionManager tm_)
		{
			return await GetByTitleAsync(title, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">标题</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_templEO> GetByTitle(string title, int top_)
		{
			return GetByTitle(title, top_, string.Empty, null);
		}
		public async Task<List<Sc_templEO>> GetByTitleAsync(string title, int top_)
		{
			return await GetByTitleAsync(title, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">标题</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_templEO> GetByTitle(string title, int top_, TransactionManager tm_)
		{
			return GetByTitle(title, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_templEO>> GetByTitleAsync(string title, int top_, TransactionManager tm_)
		{
			return await GetByTitleAsync(title, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">标题</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_templEO> GetByTitle(string title, string sort_)
		{
			return GetByTitle(title, 0, sort_, null);
		}
		public async Task<List<Sc_templEO>> GetByTitleAsync(string title, string sort_)
		{
			return await GetByTitleAsync(title, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">标题</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_templEO> GetByTitle(string title, string sort_, TransactionManager tm_)
		{
			return GetByTitle(title, 0, sort_, tm_);
		}
		public async Task<List<Sc_templEO>> GetByTitleAsync(string title, string sort_, TransactionManager tm_)
		{
			return await GetByTitleAsync(title, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">标题</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_templEO> GetByTitle(string title, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(title != null ? "`Title` = @Title" : "`Title` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (title != null)
				paras_.Add(Database.CreateInParameter("@Title", title, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_templEO.MapDataReader);
		}
		public async Task<List<Sc_templEO>> GetByTitleAsync(string title, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(title != null ? "`Title` = @Title" : "`Title` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (title != null)
				paras_.Add(Database.CreateInParameter("@Title", title, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_templEO.MapDataReader);
		}
		#endregion // GetByTitle
		#region GetByParamsTypeName
		
		/// <summary>
		/// 按 ParamsTypeName（字段） 查询
		/// </summary>
		/// /// <param name = "paramsTypeName">参数对应的实体类</param>
		/// <return>实体对象集合</return>
		public List<Sc_templEO> GetByParamsTypeName(string paramsTypeName)
		{
			return GetByParamsTypeName(paramsTypeName, 0, string.Empty, null);
		}
		public async Task<List<Sc_templEO>> GetByParamsTypeNameAsync(string paramsTypeName)
		{
			return await GetByParamsTypeNameAsync(paramsTypeName, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ParamsTypeName（字段） 查询
		/// </summary>
		/// /// <param name = "paramsTypeName">参数对应的实体类</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_templEO> GetByParamsTypeName(string paramsTypeName, TransactionManager tm_)
		{
			return GetByParamsTypeName(paramsTypeName, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_templEO>> GetByParamsTypeNameAsync(string paramsTypeName, TransactionManager tm_)
		{
			return await GetByParamsTypeNameAsync(paramsTypeName, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ParamsTypeName（字段） 查询
		/// </summary>
		/// /// <param name = "paramsTypeName">参数对应的实体类</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_templEO> GetByParamsTypeName(string paramsTypeName, int top_)
		{
			return GetByParamsTypeName(paramsTypeName, top_, string.Empty, null);
		}
		public async Task<List<Sc_templEO>> GetByParamsTypeNameAsync(string paramsTypeName, int top_)
		{
			return await GetByParamsTypeNameAsync(paramsTypeName, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ParamsTypeName（字段） 查询
		/// </summary>
		/// /// <param name = "paramsTypeName">参数对应的实体类</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_templEO> GetByParamsTypeName(string paramsTypeName, int top_, TransactionManager tm_)
		{
			return GetByParamsTypeName(paramsTypeName, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_templEO>> GetByParamsTypeNameAsync(string paramsTypeName, int top_, TransactionManager tm_)
		{
			return await GetByParamsTypeNameAsync(paramsTypeName, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ParamsTypeName（字段） 查询
		/// </summary>
		/// /// <param name = "paramsTypeName">参数对应的实体类</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_templEO> GetByParamsTypeName(string paramsTypeName, string sort_)
		{
			return GetByParamsTypeName(paramsTypeName, 0, sort_, null);
		}
		public async Task<List<Sc_templEO>> GetByParamsTypeNameAsync(string paramsTypeName, string sort_)
		{
			return await GetByParamsTypeNameAsync(paramsTypeName, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ParamsTypeName（字段） 查询
		/// </summary>
		/// /// <param name = "paramsTypeName">参数对应的实体类</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_templEO> GetByParamsTypeName(string paramsTypeName, string sort_, TransactionManager tm_)
		{
			return GetByParamsTypeName(paramsTypeName, 0, sort_, tm_);
		}
		public async Task<List<Sc_templEO>> GetByParamsTypeNameAsync(string paramsTypeName, string sort_, TransactionManager tm_)
		{
			return await GetByParamsTypeNameAsync(paramsTypeName, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ParamsTypeName（字段） 查询
		/// </summary>
		/// /// <param name = "paramsTypeName">参数对应的实体类</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_templEO> GetByParamsTypeName(string paramsTypeName, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(paramsTypeName != null ? "`ParamsTypeName` = @ParamsTypeName" : "`ParamsTypeName` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (paramsTypeName != null)
				paras_.Add(Database.CreateInParameter("@ParamsTypeName", paramsTypeName, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_templEO.MapDataReader);
		}
		public async Task<List<Sc_templEO>> GetByParamsTypeNameAsync(string paramsTypeName, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(paramsTypeName != null ? "`ParamsTypeName` = @ParamsTypeName" : "`ParamsTypeName` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (paramsTypeName != null)
				paras_.Add(Database.CreateInParameter("@ParamsTypeName", paramsTypeName, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_templEO.MapDataReader);
		}
		#endregion // GetByParamsTypeName
		#region GetByParamsNameSpace
		
		/// <summary>
		/// 按 ParamsNameSpace（字段） 查询
		/// </summary>
		/// /// <param name = "paramsNameSpace">应用程序集</param>
		/// <return>实体对象集合</return>
		public List<Sc_templEO> GetByParamsNameSpace(string paramsNameSpace)
		{
			return GetByParamsNameSpace(paramsNameSpace, 0, string.Empty, null);
		}
		public async Task<List<Sc_templEO>> GetByParamsNameSpaceAsync(string paramsNameSpace)
		{
			return await GetByParamsNameSpaceAsync(paramsNameSpace, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ParamsNameSpace（字段） 查询
		/// </summary>
		/// /// <param name = "paramsNameSpace">应用程序集</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_templEO> GetByParamsNameSpace(string paramsNameSpace, TransactionManager tm_)
		{
			return GetByParamsNameSpace(paramsNameSpace, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_templEO>> GetByParamsNameSpaceAsync(string paramsNameSpace, TransactionManager tm_)
		{
			return await GetByParamsNameSpaceAsync(paramsNameSpace, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ParamsNameSpace（字段） 查询
		/// </summary>
		/// /// <param name = "paramsNameSpace">应用程序集</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_templEO> GetByParamsNameSpace(string paramsNameSpace, int top_)
		{
			return GetByParamsNameSpace(paramsNameSpace, top_, string.Empty, null);
		}
		public async Task<List<Sc_templEO>> GetByParamsNameSpaceAsync(string paramsNameSpace, int top_)
		{
			return await GetByParamsNameSpaceAsync(paramsNameSpace, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ParamsNameSpace（字段） 查询
		/// </summary>
		/// /// <param name = "paramsNameSpace">应用程序集</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_templEO> GetByParamsNameSpace(string paramsNameSpace, int top_, TransactionManager tm_)
		{
			return GetByParamsNameSpace(paramsNameSpace, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_templEO>> GetByParamsNameSpaceAsync(string paramsNameSpace, int top_, TransactionManager tm_)
		{
			return await GetByParamsNameSpaceAsync(paramsNameSpace, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ParamsNameSpace（字段） 查询
		/// </summary>
		/// /// <param name = "paramsNameSpace">应用程序集</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_templEO> GetByParamsNameSpace(string paramsNameSpace, string sort_)
		{
			return GetByParamsNameSpace(paramsNameSpace, 0, sort_, null);
		}
		public async Task<List<Sc_templEO>> GetByParamsNameSpaceAsync(string paramsNameSpace, string sort_)
		{
			return await GetByParamsNameSpaceAsync(paramsNameSpace, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ParamsNameSpace（字段） 查询
		/// </summary>
		/// /// <param name = "paramsNameSpace">应用程序集</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_templEO> GetByParamsNameSpace(string paramsNameSpace, string sort_, TransactionManager tm_)
		{
			return GetByParamsNameSpace(paramsNameSpace, 0, sort_, tm_);
		}
		public async Task<List<Sc_templEO>> GetByParamsNameSpaceAsync(string paramsNameSpace, string sort_, TransactionManager tm_)
		{
			return await GetByParamsNameSpaceAsync(paramsNameSpace, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ParamsNameSpace（字段） 查询
		/// </summary>
		/// /// <param name = "paramsNameSpace">应用程序集</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_templEO> GetByParamsNameSpace(string paramsNameSpace, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(paramsNameSpace != null ? "`ParamsNameSpace` = @ParamsNameSpace" : "`ParamsNameSpace` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (paramsNameSpace != null)
				paras_.Add(Database.CreateInParameter("@ParamsNameSpace", paramsNameSpace, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_templEO.MapDataReader);
		}
		public async Task<List<Sc_templEO>> GetByParamsNameSpaceAsync(string paramsNameSpace, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(paramsNameSpace != null ? "`ParamsNameSpace` = @ParamsNameSpace" : "`ParamsNameSpace` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (paramsNameSpace != null)
				paras_.Add(Database.CreateInParameter("@ParamsNameSpace", paramsNameSpace, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_templEO.MapDataReader);
		}
		#endregion // GetByParamsNameSpace
		#region GetByNote
		
		/// <summary>
		/// 按 Note（字段） 查询
		/// </summary>
		/// /// <param name = "note">描述</param>
		/// <return>实体对象集合</return>
		public List<Sc_templEO> GetByNote(string note)
		{
			return GetByNote(note, 0, string.Empty, null);
		}
		public async Task<List<Sc_templEO>> GetByNoteAsync(string note)
		{
			return await GetByNoteAsync(note, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Note（字段） 查询
		/// </summary>
		/// /// <param name = "note">描述</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_templEO> GetByNote(string note, TransactionManager tm_)
		{
			return GetByNote(note, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_templEO>> GetByNoteAsync(string note, TransactionManager tm_)
		{
			return await GetByNoteAsync(note, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Note（字段） 查询
		/// </summary>
		/// /// <param name = "note">描述</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_templEO> GetByNote(string note, int top_)
		{
			return GetByNote(note, top_, string.Empty, null);
		}
		public async Task<List<Sc_templEO>> GetByNoteAsync(string note, int top_)
		{
			return await GetByNoteAsync(note, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Note（字段） 查询
		/// </summary>
		/// /// <param name = "note">描述</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_templEO> GetByNote(string note, int top_, TransactionManager tm_)
		{
			return GetByNote(note, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_templEO>> GetByNoteAsync(string note, int top_, TransactionManager tm_)
		{
			return await GetByNoteAsync(note, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Note（字段） 查询
		/// </summary>
		/// /// <param name = "note">描述</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_templEO> GetByNote(string note, string sort_)
		{
			return GetByNote(note, 0, sort_, null);
		}
		public async Task<List<Sc_templEO>> GetByNoteAsync(string note, string sort_)
		{
			return await GetByNoteAsync(note, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Note（字段） 查询
		/// </summary>
		/// /// <param name = "note">描述</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_templEO> GetByNote(string note, string sort_, TransactionManager tm_)
		{
			return GetByNote(note, 0, sort_, tm_);
		}
		public async Task<List<Sc_templEO>> GetByNoteAsync(string note, string sort_, TransactionManager tm_)
		{
			return await GetByNoteAsync(note, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Note（字段） 查询
		/// </summary>
		/// /// <param name = "note">描述</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_templEO> GetByNote(string note, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(note != null ? "`Note` = @Note" : "`Note` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (note != null)
				paras_.Add(Database.CreateInParameter("@Note", note, MySqlDbType.Text));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_templEO.MapDataReader);
		}
		public async Task<List<Sc_templEO>> GetByNoteAsync(string note, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(note != null ? "`Note` = @Note" : "`Note` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (note != null)
				paras_.Add(Database.CreateInParameter("@Note", note, MySqlDbType.Text));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_templEO.MapDataReader);
		}
		#endregion // GetByNote
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
