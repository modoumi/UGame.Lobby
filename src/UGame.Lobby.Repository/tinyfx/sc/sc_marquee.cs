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
	/// 系统跑马灯（只保存系统固定消息，其他放入redis）
	/// 【表 sc_marquee 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Sc_marqueeEO : IRowMapper<Sc_marqueeEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Sc_marqueeEO()
		{
			this.Position = 0;
			this.Status = 0;
			this.MarqueeType = 0;
			this.RecDate = DateTime.Now;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private string _originalMarqueeID;
		/// <summary>
		/// 【数据库中的原始主键 MarqueeID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalMarqueeID
		{
			get { return _originalMarqueeID; }
			set { HasOriginal = true; _originalMarqueeID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "MarqueeID", MarqueeID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 跑马灯编码GUID
		/// 【主键 varchar(38)】
		/// </summary>
		[DataMember(Order = 1)]
		public string MarqueeID { get; set; }
		/// <summary>
		/// 应用编码
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 2)]
		public string AppID { get; set; }
		/// <summary>
		/// 使用位置（app客户端分别自定义）
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 3)]
		public int Position { get; set; }
		/// <summary>
		/// 运营商编码（null意味着默认）
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 4)]
		public string OperatorID { get; set; }
		/// <summary>
		/// 模板编码
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 5)]
		public int SCTemplateID { get; set; }
		/// <summary>
		/// 模板参数值
		/// 【字段 text】
		/// </summary>
		[DataMember(Order = 6)]
		public string SCTemplateParams { get; set; }
		/// <summary>
		/// 跳转路径
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 7)]
		public string LinkUrl { get; set; }
		/// <summary>
		/// 状态(0-无效1-有效)
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 8)]
		public int Status { get; set; }
		/// <summary>
		/// 是否虚拟数据
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 9)]
		public int? Flag { get; set; }
		/// <summary>
		/// 滚动数据类型：0文字，1图片
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 10)]
		public int MarqueeType { get; set; }
		/// <summary>
		/// 记录时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 11)]
		public DateTime RecDate { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Sc_marqueeEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Sc_marqueeEO MapDataReader(IDataReader reader)
		{
		    Sc_marqueeEO ret = new Sc_marqueeEO();
			ret.MarqueeID = reader.ToString("MarqueeID");
			ret.OriginalMarqueeID = ret.MarqueeID;
			ret.AppID = reader.ToString("AppID");
			ret.Position = reader.ToInt32("Position");
			ret.OperatorID = reader.ToString("OperatorID");
			ret.SCTemplateID = reader.ToInt32("SCTemplateID");
			ret.SCTemplateParams = reader.ToString("SCTemplateParams");
			ret.LinkUrl = reader.ToString("LinkUrl");
			ret.Status = reader.ToInt32("Status");
			ret.Flag = reader.ToInt32N("Flag");
			ret.MarqueeType = reader.ToInt32("MarqueeType");
			ret.RecDate = reader.ToDateTime("RecDate");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 系统跑马灯（只保存系统固定消息，其他放入redis）
	/// 【表 sc_marquee 的操作类】
	/// </summary>
	[Obsolete]
	public class Sc_marqueeMO : MySqlTableMO<Sc_marqueeEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`sc_marquee`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Sc_marqueeMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Sc_marqueeMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Sc_marqueeMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Sc_marqueeEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Sc_marqueeEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Sc_marqueeEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`MarqueeID`, `AppID`, `Position`, `OperatorID`, `SCTemplateID`, `SCTemplateParams`, `LinkUrl`, `Status`, `Flag`, `MarqueeType`, `RecDate`) VALUE (@MarqueeID, @AppID, @Position, @OperatorID, @SCTemplateID, @SCTemplateParams, @LinkUrl, @Status, @Flag, @MarqueeType, @RecDate);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MarqueeID", item.MarqueeID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", item.AppID != null ? item.AppID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Position", item.Position, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", item.OperatorID != null ? item.OperatorID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@SCTemplateID", item.SCTemplateID, MySqlDbType.Int32),
				Database.CreateInParameter("@SCTemplateParams", item.SCTemplateParams != null ? item.SCTemplateParams : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@LinkUrl", item.LinkUrl != null ? item.LinkUrl : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Status", item.Status, MySqlDbType.Int32),
				Database.CreateInParameter("@Flag", item.Flag.HasValue ? item.Flag.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@MarqueeType", item.MarqueeType, MySqlDbType.Int32),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
			};
		}
		public int AddByBatch(IEnumerable<Sc_marqueeEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Sc_marqueeEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sc_marqueeEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`MarqueeID`, `AppID`, `Position`, `OperatorID`, `SCTemplateID`, `SCTemplateParams`, `LinkUrl`, `Status`, `Flag`, `MarqueeType`, `RecDate`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.MarqueeID}','{item.AppID}',{item.Position},'{item.OperatorID}',{item.SCTemplateID},'{item.SCTemplateParams}','{item.LinkUrl}',{item.Status},{item.Flag?.ToString()??null},{item.MarqueeType},'{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
		/// /// <param name = "marqueeID">跑马灯编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string marqueeID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(marqueeID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string marqueeID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(marqueeID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string marqueeID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `MarqueeID` = @MarqueeID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MarqueeID", marqueeID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Sc_marqueeEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.MarqueeID, tm_);
		}
		public async Task<int> RemoveAsync(Sc_marqueeEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.MarqueeID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByAppID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByAppID(string appID, TransactionManager tm_ = null)
		{
			RepairRemoveByAppIDData(appID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByAppIDAsync(string appID, TransactionManager tm_ = null)
		{
			RepairRemoveByAppIDData(appID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByAppIDData(string appID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (appID != null ? "`AppID` = @AppID" : "`AppID` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (appID != null)
				paras_.Add(Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByAppID
		#region RemoveByPosition
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "position">使用位置（app客户端分别自定义）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPosition(int position, TransactionManager tm_ = null)
		{
			RepairRemoveByPositionData(position, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPositionAsync(int position, TransactionManager tm_ = null)
		{
			RepairRemoveByPositionData(position, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByPositionData(int position, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Position` = @Position";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Position", position, MySqlDbType.Int32));
		}
		#endregion // RemoveByPosition
		#region RemoveByOperatorID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（null意味着默认）</param>
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
		#region RemoveBySCTemplateParams
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "sCTemplateParams">模板参数值</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveBySCTemplateParams(string sCTemplateParams, TransactionManager tm_ = null)
		{
			RepairRemoveBySCTemplateParamsData(sCTemplateParams, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveBySCTemplateParamsAsync(string sCTemplateParams, TransactionManager tm_ = null)
		{
			RepairRemoveBySCTemplateParamsData(sCTemplateParams, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveBySCTemplateParamsData(string sCTemplateParams, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (sCTemplateParams != null ? "`SCTemplateParams` = @SCTemplateParams" : "`SCTemplateParams` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (sCTemplateParams != null)
				paras_.Add(Database.CreateInParameter("@SCTemplateParams", sCTemplateParams, MySqlDbType.Text));
		}
		#endregion // RemoveBySCTemplateParams
		#region RemoveByLinkUrl
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "linkUrl">跳转路径</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByLinkUrl(string linkUrl, TransactionManager tm_ = null)
		{
			RepairRemoveByLinkUrlData(linkUrl, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByLinkUrlAsync(string linkUrl, TransactionManager tm_ = null)
		{
			RepairRemoveByLinkUrlData(linkUrl, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByLinkUrlData(string linkUrl, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (linkUrl != null ? "`LinkUrl` = @LinkUrl" : "`LinkUrl` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (linkUrl != null)
				paras_.Add(Database.CreateInParameter("@LinkUrl", linkUrl, MySqlDbType.VarChar));
		}
		#endregion // RemoveByLinkUrl
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
		#region RemoveByFlag
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "flag">是否虚拟数据</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByFlag(int? flag, TransactionManager tm_ = null)
		{
			RepairRemoveByFlagData(flag.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByFlagAsync(int? flag, TransactionManager tm_ = null)
		{
			RepairRemoveByFlagData(flag.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByFlagData(int? flag, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (flag.HasValue ? "`Flag` = @Flag" : "`Flag` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (flag.HasValue)
				paras_.Add(Database.CreateInParameter("@Flag", flag.Value, MySqlDbType.Int32));
		}
		#endregion // RemoveByFlag
		#region RemoveByMarqueeType
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "marqueeType">滚动数据类型：0文字，1图片</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByMarqueeType(int marqueeType, TransactionManager tm_ = null)
		{
			RepairRemoveByMarqueeTypeData(marqueeType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByMarqueeTypeAsync(int marqueeType, TransactionManager tm_ = null)
		{
			RepairRemoveByMarqueeTypeData(marqueeType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByMarqueeTypeData(int marqueeType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `MarqueeType` = @MarqueeType";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MarqueeType", marqueeType, MySqlDbType.Int32));
		}
		#endregion // RemoveByMarqueeType
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
		public int Put(Sc_marqueeEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Sc_marqueeEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Sc_marqueeEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `MarqueeID` = @MarqueeID, `AppID` = @AppID, `Position` = @Position, `OperatorID` = @OperatorID, `SCTemplateID` = @SCTemplateID, `SCTemplateParams` = @SCTemplateParams, `LinkUrl` = @LinkUrl, `Status` = @Status, `Flag` = @Flag, `MarqueeType` = @MarqueeType WHERE `MarqueeID` = @MarqueeID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MarqueeID", item.MarqueeID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", item.AppID != null ? item.AppID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Position", item.Position, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", item.OperatorID != null ? item.OperatorID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@SCTemplateID", item.SCTemplateID, MySqlDbType.Int32),
				Database.CreateInParameter("@SCTemplateParams", item.SCTemplateParams != null ? item.SCTemplateParams : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@LinkUrl", item.LinkUrl != null ? item.LinkUrl : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Status", item.Status, MySqlDbType.Int32),
				Database.CreateInParameter("@Flag", item.Flag.HasValue ? item.Flag.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@MarqueeType", item.MarqueeType, MySqlDbType.Int32),
				Database.CreateInParameter("@MarqueeID_Original", item.HasOriginal ? item.OriginalMarqueeID : item.MarqueeID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Sc_marqueeEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Sc_marqueeEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "marqueeID">跑马灯编码GUID</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string marqueeID, string set_, params object[] values_)
		{
			return Put(set_, "`MarqueeID` = @MarqueeID", ConcatValues(values_, marqueeID));
		}
		public async Task<int> PutByPKAsync(string marqueeID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`MarqueeID` = @MarqueeID", ConcatValues(values_, marqueeID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "marqueeID">跑马灯编码GUID</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string marqueeID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`MarqueeID` = @MarqueeID", tm_, ConcatValues(values_, marqueeID));
		}
		public async Task<int> PutByPKAsync(string marqueeID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`MarqueeID` = @MarqueeID", tm_, ConcatValues(values_, marqueeID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "marqueeID">跑马灯编码GUID</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string marqueeID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@MarqueeID", marqueeID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`MarqueeID` = @MarqueeID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string marqueeID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@MarqueeID", marqueeID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`MarqueeID` = @MarqueeID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutAppID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "marqueeID">跑马灯编码GUID</param>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAppIDByPK(string marqueeID, string appID, TransactionManager tm_ = null)
		{
			RepairPutAppIDByPKData(marqueeID, appID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAppIDByPKAsync(string marqueeID, string appID, TransactionManager tm_ = null)
		{
			RepairPutAppIDByPKData(marqueeID, appID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutAppIDByPKData(string marqueeID, string appID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `AppID` = @AppID  WHERE `MarqueeID` = @MarqueeID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID != null ? appID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@MarqueeID", marqueeID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAppID(string appID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `AppID` = @AppID";
			var parameter_ = Database.CreateInParameter("@AppID", appID != null ? appID : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutAppIDAsync(string appID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `AppID` = @AppID";
			var parameter_ = Database.CreateInParameter("@AppID", appID != null ? appID : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutAppID
		#region PutPosition
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "marqueeID">跑马灯编码GUID</param>
		/// /// <param name = "position">使用位置（app客户端分别自定义）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPositionByPK(string marqueeID, int position, TransactionManager tm_ = null)
		{
			RepairPutPositionByPKData(marqueeID, position, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutPositionByPKAsync(string marqueeID, int position, TransactionManager tm_ = null)
		{
			RepairPutPositionByPKData(marqueeID, position, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutPositionByPKData(string marqueeID, int position, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Position` = @Position  WHERE `MarqueeID` = @MarqueeID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Position", position, MySqlDbType.Int32),
				Database.CreateInParameter("@MarqueeID", marqueeID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "position">使用位置（app客户端分别自定义）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPosition(int position, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Position` = @Position";
			var parameter_ = Database.CreateInParameter("@Position", position, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutPositionAsync(int position, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Position` = @Position";
			var parameter_ = Database.CreateInParameter("@Position", position, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutPosition
		#region PutOperatorID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "marqueeID">跑马灯编码GUID</param>
		/// /// <param name = "operatorID">运营商编码（null意味着默认）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorIDByPK(string marqueeID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(marqueeID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOperatorIDByPKAsync(string marqueeID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(marqueeID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOperatorIDByPKData(string marqueeID, string operatorID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID  WHERE `MarqueeID` = @MarqueeID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID != null ? operatorID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@MarqueeID", marqueeID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（null意味着默认）</param>
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
		#region PutSCTemplateID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "marqueeID">跑马灯编码GUID</param>
		/// /// <param name = "sCTemplateID">模板编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSCTemplateIDByPK(string marqueeID, int sCTemplateID, TransactionManager tm_ = null)
		{
			RepairPutSCTemplateIDByPKData(marqueeID, sCTemplateID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutSCTemplateIDByPKAsync(string marqueeID, int sCTemplateID, TransactionManager tm_ = null)
		{
			RepairPutSCTemplateIDByPKData(marqueeID, sCTemplateID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutSCTemplateIDByPKData(string marqueeID, int sCTemplateID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `SCTemplateID` = @SCTemplateID  WHERE `MarqueeID` = @MarqueeID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SCTemplateID", sCTemplateID, MySqlDbType.Int32),
				Database.CreateInParameter("@MarqueeID", marqueeID, MySqlDbType.VarChar),
			};
		}
	 
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
		#region PutSCTemplateParams
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "marqueeID">跑马灯编码GUID</param>
		/// /// <param name = "sCTemplateParams">模板参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSCTemplateParamsByPK(string marqueeID, string sCTemplateParams, TransactionManager tm_ = null)
		{
			RepairPutSCTemplateParamsByPKData(marqueeID, sCTemplateParams, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutSCTemplateParamsByPKAsync(string marqueeID, string sCTemplateParams, TransactionManager tm_ = null)
		{
			RepairPutSCTemplateParamsByPKData(marqueeID, sCTemplateParams, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutSCTemplateParamsByPKData(string marqueeID, string sCTemplateParams, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `SCTemplateParams` = @SCTemplateParams  WHERE `MarqueeID` = @MarqueeID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SCTemplateParams", sCTemplateParams != null ? sCTemplateParams : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@MarqueeID", marqueeID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "sCTemplateParams">模板参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSCTemplateParams(string sCTemplateParams, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SCTemplateParams` = @SCTemplateParams";
			var parameter_ = Database.CreateInParameter("@SCTemplateParams", sCTemplateParams != null ? sCTemplateParams : (object)DBNull.Value, MySqlDbType.Text);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutSCTemplateParamsAsync(string sCTemplateParams, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SCTemplateParams` = @SCTemplateParams";
			var parameter_ = Database.CreateInParameter("@SCTemplateParams", sCTemplateParams != null ? sCTemplateParams : (object)DBNull.Value, MySqlDbType.Text);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutSCTemplateParams
		#region PutLinkUrl
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "marqueeID">跑马灯编码GUID</param>
		/// /// <param name = "linkUrl">跳转路径</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLinkUrlByPK(string marqueeID, string linkUrl, TransactionManager tm_ = null)
		{
			RepairPutLinkUrlByPKData(marqueeID, linkUrl, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLinkUrlByPKAsync(string marqueeID, string linkUrl, TransactionManager tm_ = null)
		{
			RepairPutLinkUrlByPKData(marqueeID, linkUrl, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLinkUrlByPKData(string marqueeID, string linkUrl, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `LinkUrl` = @LinkUrl  WHERE `MarqueeID` = @MarqueeID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LinkUrl", linkUrl != null ? linkUrl : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@MarqueeID", marqueeID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "linkUrl">跳转路径</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLinkUrl(string linkUrl, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LinkUrl` = @LinkUrl";
			var parameter_ = Database.CreateInParameter("@LinkUrl", linkUrl != null ? linkUrl : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutLinkUrlAsync(string linkUrl, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LinkUrl` = @LinkUrl";
			var parameter_ = Database.CreateInParameter("@LinkUrl", linkUrl != null ? linkUrl : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutLinkUrl
		#region PutStatus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "marqueeID">跑马灯编码GUID</param>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutStatusByPK(string marqueeID, int status, TransactionManager tm_ = null)
		{
			RepairPutStatusByPKData(marqueeID, status, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutStatusByPKAsync(string marqueeID, int status, TransactionManager tm_ = null)
		{
			RepairPutStatusByPKData(marqueeID, status, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutStatusByPKData(string marqueeID, int status, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Status` = @Status  WHERE `MarqueeID` = @MarqueeID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Status", status, MySqlDbType.Int32),
				Database.CreateInParameter("@MarqueeID", marqueeID, MySqlDbType.VarChar),
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
		#region PutFlag
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "marqueeID">跑马灯编码GUID</param>
		/// /// <param name = "flag">是否虚拟数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFlagByPK(string marqueeID, int? flag, TransactionManager tm_ = null)
		{
			RepairPutFlagByPKData(marqueeID, flag, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFlagByPKAsync(string marqueeID, int? flag, TransactionManager tm_ = null)
		{
			RepairPutFlagByPKData(marqueeID, flag, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFlagByPKData(string marqueeID, int? flag, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Flag` = @Flag  WHERE `MarqueeID` = @MarqueeID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Flag", flag.HasValue ? flag.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@MarqueeID", marqueeID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "flag">是否虚拟数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFlag(int? flag, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Flag` = @Flag";
			var parameter_ = Database.CreateInParameter("@Flag", flag.HasValue ? flag.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutFlagAsync(int? flag, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Flag` = @Flag";
			var parameter_ = Database.CreateInParameter("@Flag", flag.HasValue ? flag.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutFlag
		#region PutMarqueeType
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "marqueeID">跑马灯编码GUID</param>
		/// /// <param name = "marqueeType">滚动数据类型：0文字，1图片</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMarqueeTypeByPK(string marqueeID, int marqueeType, TransactionManager tm_ = null)
		{
			RepairPutMarqueeTypeByPKData(marqueeID, marqueeType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutMarqueeTypeByPKAsync(string marqueeID, int marqueeType, TransactionManager tm_ = null)
		{
			RepairPutMarqueeTypeByPKData(marqueeID, marqueeType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutMarqueeTypeByPKData(string marqueeID, int marqueeType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `MarqueeType` = @MarqueeType  WHERE `MarqueeID` = @MarqueeID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MarqueeType", marqueeType, MySqlDbType.Int32),
				Database.CreateInParameter("@MarqueeID", marqueeID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "marqueeType">滚动数据类型：0文字，1图片</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMarqueeType(int marqueeType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MarqueeType` = @MarqueeType";
			var parameter_ = Database.CreateInParameter("@MarqueeType", marqueeType, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutMarqueeTypeAsync(int marqueeType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MarqueeType` = @MarqueeType";
			var parameter_ = Database.CreateInParameter("@MarqueeType", marqueeType, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutMarqueeType
		#region PutRecDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "marqueeID">跑马灯编码GUID</param>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(string marqueeID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(marqueeID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(string marqueeID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(marqueeID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(string marqueeID, DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `MarqueeID` = @MarqueeID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@MarqueeID", marqueeID, MySqlDbType.VarChar),
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
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Sc_marqueeEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.MarqueeID) == null)
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
		public async Task<bool> SetAsync(Sc_marqueeEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.MarqueeID) == null)
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
		/// /// <param name = "marqueeID">跑马灯编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Sc_marqueeEO GetByPK(string marqueeID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(marqueeID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sc_marqueeEO.MapDataReader);
		}
		public async Task<Sc_marqueeEO> GetByPKAsync(string marqueeID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(marqueeID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sc_marqueeEO.MapDataReader);
		}
		private void RepairGetByPKData(string marqueeID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`MarqueeID` = @MarqueeID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MarqueeID", marqueeID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 AppID（字段）
		/// </summary>
		/// /// <param name = "marqueeID">跑马灯编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetAppIDByPK(string marqueeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MarqueeID", marqueeID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`AppID`", "`MarqueeID` = @MarqueeID", paras_, tm_);
		}
		public async Task<string> GetAppIDByPKAsync(string marqueeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MarqueeID", marqueeID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`AppID`", "`MarqueeID` = @MarqueeID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Position（字段）
		/// </summary>
		/// /// <param name = "marqueeID">跑马灯编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetPositionByPK(string marqueeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MarqueeID", marqueeID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`Position`", "`MarqueeID` = @MarqueeID", paras_, tm_);
		}
		public async Task<int> GetPositionByPKAsync(string marqueeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MarqueeID", marqueeID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`Position`", "`MarqueeID` = @MarqueeID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OperatorID（字段）
		/// </summary>
		/// /// <param name = "marqueeID">跑马灯编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorIDByPK(string marqueeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MarqueeID", marqueeID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OperatorID`", "`MarqueeID` = @MarqueeID", paras_, tm_);
		}
		public async Task<string> GetOperatorIDByPKAsync(string marqueeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MarqueeID", marqueeID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OperatorID`", "`MarqueeID` = @MarqueeID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 SCTemplateID（字段）
		/// </summary>
		/// /// <param name = "marqueeID">跑马灯编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetSCTemplateIDByPK(string marqueeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MarqueeID", marqueeID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`SCTemplateID`", "`MarqueeID` = @MarqueeID", paras_, tm_);
		}
		public async Task<int> GetSCTemplateIDByPKAsync(string marqueeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MarqueeID", marqueeID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`SCTemplateID`", "`MarqueeID` = @MarqueeID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 SCTemplateParams（字段）
		/// </summary>
		/// /// <param name = "marqueeID">跑马灯编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetSCTemplateParamsByPK(string marqueeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MarqueeID", marqueeID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`SCTemplateParams`", "`MarqueeID` = @MarqueeID", paras_, tm_);
		}
		public async Task<string> GetSCTemplateParamsByPKAsync(string marqueeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MarqueeID", marqueeID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`SCTemplateParams`", "`MarqueeID` = @MarqueeID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 LinkUrl（字段）
		/// </summary>
		/// /// <param name = "marqueeID">跑马灯编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetLinkUrlByPK(string marqueeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MarqueeID", marqueeID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`LinkUrl`", "`MarqueeID` = @MarqueeID", paras_, tm_);
		}
		public async Task<string> GetLinkUrlByPKAsync(string marqueeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MarqueeID", marqueeID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`LinkUrl`", "`MarqueeID` = @MarqueeID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Status（字段）
		/// </summary>
		/// /// <param name = "marqueeID">跑马灯编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetStatusByPK(string marqueeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MarqueeID", marqueeID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`Status`", "`MarqueeID` = @MarqueeID", paras_, tm_);
		}
		public async Task<int> GetStatusByPKAsync(string marqueeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MarqueeID", marqueeID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`Status`", "`MarqueeID` = @MarqueeID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Flag（字段）
		/// </summary>
		/// /// <param name = "marqueeID">跑马灯编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int? GetFlagByPK(string marqueeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MarqueeID", marqueeID, MySqlDbType.VarChar),
			};
			return (int?)GetScalar("`Flag`", "`MarqueeID` = @MarqueeID", paras_, tm_);
		}
		public async Task<int?> GetFlagByPKAsync(string marqueeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MarqueeID", marqueeID, MySqlDbType.VarChar),
			};
			return (int?)await GetScalarAsync("`Flag`", "`MarqueeID` = @MarqueeID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 MarqueeType（字段）
		/// </summary>
		/// /// <param name = "marqueeID">跑马灯编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetMarqueeTypeByPK(string marqueeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MarqueeID", marqueeID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`MarqueeType`", "`MarqueeID` = @MarqueeID", paras_, tm_);
		}
		public async Task<int> GetMarqueeTypeByPKAsync(string marqueeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MarqueeID", marqueeID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`MarqueeType`", "`MarqueeID` = @MarqueeID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "marqueeID">跑马灯编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetRecDateByPK(string marqueeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MarqueeID", marqueeID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`RecDate`", "`MarqueeID` = @MarqueeID", paras_, tm_);
		}
		public async Task<DateTime> GetRecDateByPKAsync(string marqueeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MarqueeID", marqueeID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`RecDate`", "`MarqueeID` = @MarqueeID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByAppID
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <return>实体对象集合</return>
		public List<Sc_marqueeEO> GetByAppID(string appID)
		{
			return GetByAppID(appID, 0, string.Empty, null);
		}
		public async Task<List<Sc_marqueeEO>> GetByAppIDAsync(string appID)
		{
			return await GetByAppIDAsync(appID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_marqueeEO> GetByAppID(string appID, TransactionManager tm_)
		{
			return GetByAppID(appID, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_marqueeEO>> GetByAppIDAsync(string appID, TransactionManager tm_)
		{
			return await GetByAppIDAsync(appID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_marqueeEO> GetByAppID(string appID, int top_)
		{
			return GetByAppID(appID, top_, string.Empty, null);
		}
		public async Task<List<Sc_marqueeEO>> GetByAppIDAsync(string appID, int top_)
		{
			return await GetByAppIDAsync(appID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_marqueeEO> GetByAppID(string appID, int top_, TransactionManager tm_)
		{
			return GetByAppID(appID, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_marqueeEO>> GetByAppIDAsync(string appID, int top_, TransactionManager tm_)
		{
			return await GetByAppIDAsync(appID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_marqueeEO> GetByAppID(string appID, string sort_)
		{
			return GetByAppID(appID, 0, sort_, null);
		}
		public async Task<List<Sc_marqueeEO>> GetByAppIDAsync(string appID, string sort_)
		{
			return await GetByAppIDAsync(appID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_marqueeEO> GetByAppID(string appID, string sort_, TransactionManager tm_)
		{
			return GetByAppID(appID, 0, sort_, tm_);
		}
		public async Task<List<Sc_marqueeEO>> GetByAppIDAsync(string appID, string sort_, TransactionManager tm_)
		{
			return await GetByAppIDAsync(appID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_marqueeEO> GetByAppID(string appID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(appID != null ? "`AppID` = @AppID" : "`AppID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (appID != null)
				paras_.Add(Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_marqueeEO.MapDataReader);
		}
		public async Task<List<Sc_marqueeEO>> GetByAppIDAsync(string appID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(appID != null ? "`AppID` = @AppID" : "`AppID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (appID != null)
				paras_.Add(Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_marqueeEO.MapDataReader);
		}
		#endregion // GetByAppID
		#region GetByPosition
		
		/// <summary>
		/// 按 Position（字段） 查询
		/// </summary>
		/// /// <param name = "position">使用位置（app客户端分别自定义）</param>
		/// <return>实体对象集合</return>
		public List<Sc_marqueeEO> GetByPosition(int position)
		{
			return GetByPosition(position, 0, string.Empty, null);
		}
		public async Task<List<Sc_marqueeEO>> GetByPositionAsync(int position)
		{
			return await GetByPositionAsync(position, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Position（字段） 查询
		/// </summary>
		/// /// <param name = "position">使用位置（app客户端分别自定义）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_marqueeEO> GetByPosition(int position, TransactionManager tm_)
		{
			return GetByPosition(position, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_marqueeEO>> GetByPositionAsync(int position, TransactionManager tm_)
		{
			return await GetByPositionAsync(position, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Position（字段） 查询
		/// </summary>
		/// /// <param name = "position">使用位置（app客户端分别自定义）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_marqueeEO> GetByPosition(int position, int top_)
		{
			return GetByPosition(position, top_, string.Empty, null);
		}
		public async Task<List<Sc_marqueeEO>> GetByPositionAsync(int position, int top_)
		{
			return await GetByPositionAsync(position, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Position（字段） 查询
		/// </summary>
		/// /// <param name = "position">使用位置（app客户端分别自定义）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_marqueeEO> GetByPosition(int position, int top_, TransactionManager tm_)
		{
			return GetByPosition(position, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_marqueeEO>> GetByPositionAsync(int position, int top_, TransactionManager tm_)
		{
			return await GetByPositionAsync(position, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Position（字段） 查询
		/// </summary>
		/// /// <param name = "position">使用位置（app客户端分别自定义）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_marqueeEO> GetByPosition(int position, string sort_)
		{
			return GetByPosition(position, 0, sort_, null);
		}
		public async Task<List<Sc_marqueeEO>> GetByPositionAsync(int position, string sort_)
		{
			return await GetByPositionAsync(position, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Position（字段） 查询
		/// </summary>
		/// /// <param name = "position">使用位置（app客户端分别自定义）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_marqueeEO> GetByPosition(int position, string sort_, TransactionManager tm_)
		{
			return GetByPosition(position, 0, sort_, tm_);
		}
		public async Task<List<Sc_marqueeEO>> GetByPositionAsync(int position, string sort_, TransactionManager tm_)
		{
			return await GetByPositionAsync(position, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Position（字段） 查询
		/// </summary>
		/// /// <param name = "position">使用位置（app客户端分别自定义）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_marqueeEO> GetByPosition(int position, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Position` = @Position", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Position", position, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_marqueeEO.MapDataReader);
		}
		public async Task<List<Sc_marqueeEO>> GetByPositionAsync(int position, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Position` = @Position", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Position", position, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_marqueeEO.MapDataReader);
		}
		#endregion // GetByPosition
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（null意味着默认）</param>
		/// <return>实体对象集合</return>
		public List<Sc_marqueeEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<Sc_marqueeEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（null意味着默认）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_marqueeEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_marqueeEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（null意味着默认）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_marqueeEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<Sc_marqueeEO>> GetByOperatorIDAsync(string operatorID, int top_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（null意味着默认）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_marqueeEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_marqueeEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（null意味着默认）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_marqueeEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<Sc_marqueeEO>> GetByOperatorIDAsync(string operatorID, string sort_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（null意味着默认）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_marqueeEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<Sc_marqueeEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（null意味着默认）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_marqueeEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operatorID != null ? "`OperatorID` = @OperatorID" : "`OperatorID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operatorID != null)
				paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_marqueeEO.MapDataReader);
		}
		public async Task<List<Sc_marqueeEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operatorID != null ? "`OperatorID` = @OperatorID" : "`OperatorID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operatorID != null)
				paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_marqueeEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetBySCTemplateID
		
		/// <summary>
		/// 按 SCTemplateID（字段） 查询
		/// </summary>
		/// /// <param name = "sCTemplateID">模板编码</param>
		/// <return>实体对象集合</return>
		public List<Sc_marqueeEO> GetBySCTemplateID(int sCTemplateID)
		{
			return GetBySCTemplateID(sCTemplateID, 0, string.Empty, null);
		}
		public async Task<List<Sc_marqueeEO>> GetBySCTemplateIDAsync(int sCTemplateID)
		{
			return await GetBySCTemplateIDAsync(sCTemplateID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SCTemplateID（字段） 查询
		/// </summary>
		/// /// <param name = "sCTemplateID">模板编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_marqueeEO> GetBySCTemplateID(int sCTemplateID, TransactionManager tm_)
		{
			return GetBySCTemplateID(sCTemplateID, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_marqueeEO>> GetBySCTemplateIDAsync(int sCTemplateID, TransactionManager tm_)
		{
			return await GetBySCTemplateIDAsync(sCTemplateID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SCTemplateID（字段） 查询
		/// </summary>
		/// /// <param name = "sCTemplateID">模板编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_marqueeEO> GetBySCTemplateID(int sCTemplateID, int top_)
		{
			return GetBySCTemplateID(sCTemplateID, top_, string.Empty, null);
		}
		public async Task<List<Sc_marqueeEO>> GetBySCTemplateIDAsync(int sCTemplateID, int top_)
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
		public List<Sc_marqueeEO> GetBySCTemplateID(int sCTemplateID, int top_, TransactionManager tm_)
		{
			return GetBySCTemplateID(sCTemplateID, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_marqueeEO>> GetBySCTemplateIDAsync(int sCTemplateID, int top_, TransactionManager tm_)
		{
			return await GetBySCTemplateIDAsync(sCTemplateID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SCTemplateID（字段） 查询
		/// </summary>
		/// /// <param name = "sCTemplateID">模板编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_marqueeEO> GetBySCTemplateID(int sCTemplateID, string sort_)
		{
			return GetBySCTemplateID(sCTemplateID, 0, sort_, null);
		}
		public async Task<List<Sc_marqueeEO>> GetBySCTemplateIDAsync(int sCTemplateID, string sort_)
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
		public List<Sc_marqueeEO> GetBySCTemplateID(int sCTemplateID, string sort_, TransactionManager tm_)
		{
			return GetBySCTemplateID(sCTemplateID, 0, sort_, tm_);
		}
		public async Task<List<Sc_marqueeEO>> GetBySCTemplateIDAsync(int sCTemplateID, string sort_, TransactionManager tm_)
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
		public List<Sc_marqueeEO> GetBySCTemplateID(int sCTemplateID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SCTemplateID` = @SCTemplateID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SCTemplateID", sCTemplateID, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_marqueeEO.MapDataReader);
		}
		public async Task<List<Sc_marqueeEO>> GetBySCTemplateIDAsync(int sCTemplateID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SCTemplateID` = @SCTemplateID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SCTemplateID", sCTemplateID, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_marqueeEO.MapDataReader);
		}
		#endregion // GetBySCTemplateID
		#region GetBySCTemplateParams
		
		/// <summary>
		/// 按 SCTemplateParams（字段） 查询
		/// </summary>
		/// /// <param name = "sCTemplateParams">模板参数值</param>
		/// <return>实体对象集合</return>
		public List<Sc_marqueeEO> GetBySCTemplateParams(string sCTemplateParams)
		{
			return GetBySCTemplateParams(sCTemplateParams, 0, string.Empty, null);
		}
		public async Task<List<Sc_marqueeEO>> GetBySCTemplateParamsAsync(string sCTemplateParams)
		{
			return await GetBySCTemplateParamsAsync(sCTemplateParams, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SCTemplateParams（字段） 查询
		/// </summary>
		/// /// <param name = "sCTemplateParams">模板参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_marqueeEO> GetBySCTemplateParams(string sCTemplateParams, TransactionManager tm_)
		{
			return GetBySCTemplateParams(sCTemplateParams, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_marqueeEO>> GetBySCTemplateParamsAsync(string sCTemplateParams, TransactionManager tm_)
		{
			return await GetBySCTemplateParamsAsync(sCTemplateParams, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SCTemplateParams（字段） 查询
		/// </summary>
		/// /// <param name = "sCTemplateParams">模板参数值</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_marqueeEO> GetBySCTemplateParams(string sCTemplateParams, int top_)
		{
			return GetBySCTemplateParams(sCTemplateParams, top_, string.Empty, null);
		}
		public async Task<List<Sc_marqueeEO>> GetBySCTemplateParamsAsync(string sCTemplateParams, int top_)
		{
			return await GetBySCTemplateParamsAsync(sCTemplateParams, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SCTemplateParams（字段） 查询
		/// </summary>
		/// /// <param name = "sCTemplateParams">模板参数值</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_marqueeEO> GetBySCTemplateParams(string sCTemplateParams, int top_, TransactionManager tm_)
		{
			return GetBySCTemplateParams(sCTemplateParams, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_marqueeEO>> GetBySCTemplateParamsAsync(string sCTemplateParams, int top_, TransactionManager tm_)
		{
			return await GetBySCTemplateParamsAsync(sCTemplateParams, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SCTemplateParams（字段） 查询
		/// </summary>
		/// /// <param name = "sCTemplateParams">模板参数值</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_marqueeEO> GetBySCTemplateParams(string sCTemplateParams, string sort_)
		{
			return GetBySCTemplateParams(sCTemplateParams, 0, sort_, null);
		}
		public async Task<List<Sc_marqueeEO>> GetBySCTemplateParamsAsync(string sCTemplateParams, string sort_)
		{
			return await GetBySCTemplateParamsAsync(sCTemplateParams, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 SCTemplateParams（字段） 查询
		/// </summary>
		/// /// <param name = "sCTemplateParams">模板参数值</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_marqueeEO> GetBySCTemplateParams(string sCTemplateParams, string sort_, TransactionManager tm_)
		{
			return GetBySCTemplateParams(sCTemplateParams, 0, sort_, tm_);
		}
		public async Task<List<Sc_marqueeEO>> GetBySCTemplateParamsAsync(string sCTemplateParams, string sort_, TransactionManager tm_)
		{
			return await GetBySCTemplateParamsAsync(sCTemplateParams, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 SCTemplateParams（字段） 查询
		/// </summary>
		/// /// <param name = "sCTemplateParams">模板参数值</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_marqueeEO> GetBySCTemplateParams(string sCTemplateParams, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(sCTemplateParams != null ? "`SCTemplateParams` = @SCTemplateParams" : "`SCTemplateParams` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (sCTemplateParams != null)
				paras_.Add(Database.CreateInParameter("@SCTemplateParams", sCTemplateParams, MySqlDbType.Text));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_marqueeEO.MapDataReader);
		}
		public async Task<List<Sc_marqueeEO>> GetBySCTemplateParamsAsync(string sCTemplateParams, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(sCTemplateParams != null ? "`SCTemplateParams` = @SCTemplateParams" : "`SCTemplateParams` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (sCTemplateParams != null)
				paras_.Add(Database.CreateInParameter("@SCTemplateParams", sCTemplateParams, MySqlDbType.Text));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_marqueeEO.MapDataReader);
		}
		#endregion // GetBySCTemplateParams
		#region GetByLinkUrl
		
		/// <summary>
		/// 按 LinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "linkUrl">跳转路径</param>
		/// <return>实体对象集合</return>
		public List<Sc_marqueeEO> GetByLinkUrl(string linkUrl)
		{
			return GetByLinkUrl(linkUrl, 0, string.Empty, null);
		}
		public async Task<List<Sc_marqueeEO>> GetByLinkUrlAsync(string linkUrl)
		{
			return await GetByLinkUrlAsync(linkUrl, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "linkUrl">跳转路径</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_marqueeEO> GetByLinkUrl(string linkUrl, TransactionManager tm_)
		{
			return GetByLinkUrl(linkUrl, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_marqueeEO>> GetByLinkUrlAsync(string linkUrl, TransactionManager tm_)
		{
			return await GetByLinkUrlAsync(linkUrl, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "linkUrl">跳转路径</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_marqueeEO> GetByLinkUrl(string linkUrl, int top_)
		{
			return GetByLinkUrl(linkUrl, top_, string.Empty, null);
		}
		public async Task<List<Sc_marqueeEO>> GetByLinkUrlAsync(string linkUrl, int top_)
		{
			return await GetByLinkUrlAsync(linkUrl, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "linkUrl">跳转路径</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_marqueeEO> GetByLinkUrl(string linkUrl, int top_, TransactionManager tm_)
		{
			return GetByLinkUrl(linkUrl, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_marqueeEO>> GetByLinkUrlAsync(string linkUrl, int top_, TransactionManager tm_)
		{
			return await GetByLinkUrlAsync(linkUrl, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "linkUrl">跳转路径</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_marqueeEO> GetByLinkUrl(string linkUrl, string sort_)
		{
			return GetByLinkUrl(linkUrl, 0, sort_, null);
		}
		public async Task<List<Sc_marqueeEO>> GetByLinkUrlAsync(string linkUrl, string sort_)
		{
			return await GetByLinkUrlAsync(linkUrl, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "linkUrl">跳转路径</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_marqueeEO> GetByLinkUrl(string linkUrl, string sort_, TransactionManager tm_)
		{
			return GetByLinkUrl(linkUrl, 0, sort_, tm_);
		}
		public async Task<List<Sc_marqueeEO>> GetByLinkUrlAsync(string linkUrl, string sort_, TransactionManager tm_)
		{
			return await GetByLinkUrlAsync(linkUrl, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "linkUrl">跳转路径</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_marqueeEO> GetByLinkUrl(string linkUrl, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(linkUrl != null ? "`LinkUrl` = @LinkUrl" : "`LinkUrl` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (linkUrl != null)
				paras_.Add(Database.CreateInParameter("@LinkUrl", linkUrl, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_marqueeEO.MapDataReader);
		}
		public async Task<List<Sc_marqueeEO>> GetByLinkUrlAsync(string linkUrl, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(linkUrl != null ? "`LinkUrl` = @LinkUrl" : "`LinkUrl` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (linkUrl != null)
				paras_.Add(Database.CreateInParameter("@LinkUrl", linkUrl, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_marqueeEO.MapDataReader);
		}
		#endregion // GetByLinkUrl
		#region GetByStatus
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <return>实体对象集合</return>
		public List<Sc_marqueeEO> GetByStatus(int status)
		{
			return GetByStatus(status, 0, string.Empty, null);
		}
		public async Task<List<Sc_marqueeEO>> GetByStatusAsync(int status)
		{
			return await GetByStatusAsync(status, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_marqueeEO> GetByStatus(int status, TransactionManager tm_)
		{
			return GetByStatus(status, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_marqueeEO>> GetByStatusAsync(int status, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_marqueeEO> GetByStatus(int status, int top_)
		{
			return GetByStatus(status, top_, string.Empty, null);
		}
		public async Task<List<Sc_marqueeEO>> GetByStatusAsync(int status, int top_)
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
		public List<Sc_marqueeEO> GetByStatus(int status, int top_, TransactionManager tm_)
		{
			return GetByStatus(status, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_marqueeEO>> GetByStatusAsync(int status, int top_, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_marqueeEO> GetByStatus(int status, string sort_)
		{
			return GetByStatus(status, 0, sort_, null);
		}
		public async Task<List<Sc_marqueeEO>> GetByStatusAsync(int status, string sort_)
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
		public List<Sc_marqueeEO> GetByStatus(int status, string sort_, TransactionManager tm_)
		{
			return GetByStatus(status, 0, sort_, tm_);
		}
		public async Task<List<Sc_marqueeEO>> GetByStatusAsync(int status, string sort_, TransactionManager tm_)
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
		public List<Sc_marqueeEO> GetByStatus(int status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_marqueeEO.MapDataReader);
		}
		public async Task<List<Sc_marqueeEO>> GetByStatusAsync(int status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_marqueeEO.MapDataReader);
		}
		#endregion // GetByStatus
		#region GetByFlag
		
		/// <summary>
		/// 按 Flag（字段） 查询
		/// </summary>
		/// /// <param name = "flag">是否虚拟数据</param>
		/// <return>实体对象集合</return>
		public List<Sc_marqueeEO> GetByFlag(int? flag)
		{
			return GetByFlag(flag, 0, string.Empty, null);
		}
		public async Task<List<Sc_marqueeEO>> GetByFlagAsync(int? flag)
		{
			return await GetByFlagAsync(flag, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Flag（字段） 查询
		/// </summary>
		/// /// <param name = "flag">是否虚拟数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_marqueeEO> GetByFlag(int? flag, TransactionManager tm_)
		{
			return GetByFlag(flag, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_marqueeEO>> GetByFlagAsync(int? flag, TransactionManager tm_)
		{
			return await GetByFlagAsync(flag, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Flag（字段） 查询
		/// </summary>
		/// /// <param name = "flag">是否虚拟数据</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_marqueeEO> GetByFlag(int? flag, int top_)
		{
			return GetByFlag(flag, top_, string.Empty, null);
		}
		public async Task<List<Sc_marqueeEO>> GetByFlagAsync(int? flag, int top_)
		{
			return await GetByFlagAsync(flag, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Flag（字段） 查询
		/// </summary>
		/// /// <param name = "flag">是否虚拟数据</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_marqueeEO> GetByFlag(int? flag, int top_, TransactionManager tm_)
		{
			return GetByFlag(flag, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_marqueeEO>> GetByFlagAsync(int? flag, int top_, TransactionManager tm_)
		{
			return await GetByFlagAsync(flag, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Flag（字段） 查询
		/// </summary>
		/// /// <param name = "flag">是否虚拟数据</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_marqueeEO> GetByFlag(int? flag, string sort_)
		{
			return GetByFlag(flag, 0, sort_, null);
		}
		public async Task<List<Sc_marqueeEO>> GetByFlagAsync(int? flag, string sort_)
		{
			return await GetByFlagAsync(flag, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Flag（字段） 查询
		/// </summary>
		/// /// <param name = "flag">是否虚拟数据</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_marqueeEO> GetByFlag(int? flag, string sort_, TransactionManager tm_)
		{
			return GetByFlag(flag, 0, sort_, tm_);
		}
		public async Task<List<Sc_marqueeEO>> GetByFlagAsync(int? flag, string sort_, TransactionManager tm_)
		{
			return await GetByFlagAsync(flag, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Flag（字段） 查询
		/// </summary>
		/// /// <param name = "flag">是否虚拟数据</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_marqueeEO> GetByFlag(int? flag, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(flag.HasValue ? "`Flag` = @Flag" : "`Flag` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (flag.HasValue)
				paras_.Add(Database.CreateInParameter("@Flag", flag.Value, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_marqueeEO.MapDataReader);
		}
		public async Task<List<Sc_marqueeEO>> GetByFlagAsync(int? flag, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(flag.HasValue ? "`Flag` = @Flag" : "`Flag` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (flag.HasValue)
				paras_.Add(Database.CreateInParameter("@Flag", flag.Value, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_marqueeEO.MapDataReader);
		}
		#endregion // GetByFlag
		#region GetByMarqueeType
		
		/// <summary>
		/// 按 MarqueeType（字段） 查询
		/// </summary>
		/// /// <param name = "marqueeType">滚动数据类型：0文字，1图片</param>
		/// <return>实体对象集合</return>
		public List<Sc_marqueeEO> GetByMarqueeType(int marqueeType)
		{
			return GetByMarqueeType(marqueeType, 0, string.Empty, null);
		}
		public async Task<List<Sc_marqueeEO>> GetByMarqueeTypeAsync(int marqueeType)
		{
			return await GetByMarqueeTypeAsync(marqueeType, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MarqueeType（字段） 查询
		/// </summary>
		/// /// <param name = "marqueeType">滚动数据类型：0文字，1图片</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_marqueeEO> GetByMarqueeType(int marqueeType, TransactionManager tm_)
		{
			return GetByMarqueeType(marqueeType, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_marqueeEO>> GetByMarqueeTypeAsync(int marqueeType, TransactionManager tm_)
		{
			return await GetByMarqueeTypeAsync(marqueeType, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MarqueeType（字段） 查询
		/// </summary>
		/// /// <param name = "marqueeType">滚动数据类型：0文字，1图片</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_marqueeEO> GetByMarqueeType(int marqueeType, int top_)
		{
			return GetByMarqueeType(marqueeType, top_, string.Empty, null);
		}
		public async Task<List<Sc_marqueeEO>> GetByMarqueeTypeAsync(int marqueeType, int top_)
		{
			return await GetByMarqueeTypeAsync(marqueeType, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MarqueeType（字段） 查询
		/// </summary>
		/// /// <param name = "marqueeType">滚动数据类型：0文字，1图片</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_marqueeEO> GetByMarqueeType(int marqueeType, int top_, TransactionManager tm_)
		{
			return GetByMarqueeType(marqueeType, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_marqueeEO>> GetByMarqueeTypeAsync(int marqueeType, int top_, TransactionManager tm_)
		{
			return await GetByMarqueeTypeAsync(marqueeType, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MarqueeType（字段） 查询
		/// </summary>
		/// /// <param name = "marqueeType">滚动数据类型：0文字，1图片</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_marqueeEO> GetByMarqueeType(int marqueeType, string sort_)
		{
			return GetByMarqueeType(marqueeType, 0, sort_, null);
		}
		public async Task<List<Sc_marqueeEO>> GetByMarqueeTypeAsync(int marqueeType, string sort_)
		{
			return await GetByMarqueeTypeAsync(marqueeType, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 MarqueeType（字段） 查询
		/// </summary>
		/// /// <param name = "marqueeType">滚动数据类型：0文字，1图片</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_marqueeEO> GetByMarqueeType(int marqueeType, string sort_, TransactionManager tm_)
		{
			return GetByMarqueeType(marqueeType, 0, sort_, tm_);
		}
		public async Task<List<Sc_marqueeEO>> GetByMarqueeTypeAsync(int marqueeType, string sort_, TransactionManager tm_)
		{
			return await GetByMarqueeTypeAsync(marqueeType, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 MarqueeType（字段） 查询
		/// </summary>
		/// /// <param name = "marqueeType">滚动数据类型：0文字，1图片</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_marqueeEO> GetByMarqueeType(int marqueeType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`MarqueeType` = @MarqueeType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MarqueeType", marqueeType, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_marqueeEO.MapDataReader);
		}
		public async Task<List<Sc_marqueeEO>> GetByMarqueeTypeAsync(int marqueeType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`MarqueeType` = @MarqueeType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MarqueeType", marqueeType, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_marqueeEO.MapDataReader);
		}
		#endregion // GetByMarqueeType
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <return>实体对象集合</return>
		public List<Sc_marqueeEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<Sc_marqueeEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_marqueeEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_marqueeEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_marqueeEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<Sc_marqueeEO>> GetByRecDateAsync(DateTime recDate, int top_)
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
		public List<Sc_marqueeEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_marqueeEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_marqueeEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<Sc_marqueeEO>> GetByRecDateAsync(DateTime recDate, string sort_)
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
		public List<Sc_marqueeEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<Sc_marqueeEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
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
		public List<Sc_marqueeEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_marqueeEO.MapDataReader);
		}
		public async Task<List<Sc_marqueeEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_marqueeEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
