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
	/// 
	/// 【表 l_app 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class L_appEO : IRowMapper<L_appEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public L_appEO()
		{
			this.Flag = 0;
			this.MarqueeStatus = 0;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private string _originalPrimaryKeyID;
		/// <summary>
		/// 【数据库中的原始主键 PrimaryKeyID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalPrimaryKeyID
		{
			get { return _originalPrimaryKeyID; }
			set { HasOriginal = true; _originalPrimaryKeyID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "PrimaryKeyID", PrimaryKeyID }, };
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
		/// 【主键 varchar(255)】
		/// </summary>
		[DataMember(Order = 1)]
		public string PrimaryKeyID { get; set; }
		/// <summary>
		/// 运营商编码
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 2)]
		public string OperatorID { get; set; }
		/// <summary>
		/// 
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 3)]
		public string AppID { get; set; }
		/// <summary>
		/// 应用标志 0-默认1-Hot2-New
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 4)]
		public int Flag { get; set; }
		/// <summary>
		/// 
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 5)]
		public string SmallIcon { get; set; }
		/// <summary>
		/// 
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 6)]
		public string MiddleIcon { get; set; }
		/// <summary>
		/// 
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 7)]
		public string BigIcon { get; set; }
		/// <summary>
		/// 
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 8)]
		public string RouletteIcon { get; set; }
		/// <summary>
		/// 是否在跑马灯展示：0不展示，1展示
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 9)]
		public int MarqueeStatus { get; set; }
		/// <summary>
		/// 跑马灯展示的游戏图标
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 10)]
		public string MarqueeIcon { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public L_appEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static L_appEO MapDataReader(IDataReader reader)
		{
		    L_appEO ret = new L_appEO();
			ret.PrimaryKeyID = reader.ToString("PrimaryKeyID");
			ret.OriginalPrimaryKeyID = ret.PrimaryKeyID;
			ret.OperatorID = reader.ToString("OperatorID");
			ret.AppID = reader.ToString("AppID");
			ret.Flag = reader.ToInt32("Flag");
			ret.SmallIcon = reader.ToString("SmallIcon");
			ret.MiddleIcon = reader.ToString("MiddleIcon");
			ret.BigIcon = reader.ToString("BigIcon");
			ret.RouletteIcon = reader.ToString("RouletteIcon");
			ret.MarqueeStatus = reader.ToInt32("MarqueeStatus");
			ret.MarqueeIcon = reader.ToString("MarqueeIcon");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 
	/// 【表 l_app 的操作类】
	/// </summary>
	[Obsolete]
	public class L_appMO : MySqlTableMO<L_appEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`l_app`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public L_appMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public L_appMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public L_appMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(L_appEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(L_appEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(L_appEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`PrimaryKeyID`, `OperatorID`, `AppID`, `Flag`, `SmallIcon`, `MiddleIcon`, `BigIcon`, `RouletteIcon`, `MarqueeStatus`, `MarqueeIcon`) VALUE (@PrimaryKeyID, @OperatorID, @AppID, @Flag, @SmallIcon, @MiddleIcon, @BigIcon, @RouletteIcon, @MarqueeStatus, @MarqueeIcon);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PrimaryKeyID", item.PrimaryKeyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID != null ? item.OperatorID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", item.AppID != null ? item.AppID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Flag", item.Flag, MySqlDbType.Int32),
				Database.CreateInParameter("@SmallIcon", item.SmallIcon != null ? item.SmallIcon : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@MiddleIcon", item.MiddleIcon != null ? item.MiddleIcon : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@BigIcon", item.BigIcon != null ? item.BigIcon : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@RouletteIcon", item.RouletteIcon != null ? item.RouletteIcon : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@MarqueeStatus", item.MarqueeStatus, MySqlDbType.Int32),
				Database.CreateInParameter("@MarqueeIcon", item.MarqueeIcon != null ? item.MarqueeIcon : (object)DBNull.Value, MySqlDbType.VarChar),
			};
		}
		public int AddByBatch(IEnumerable<L_appEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<L_appEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<L_appEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`PrimaryKeyID`, `OperatorID`, `AppID`, `Flag`, `SmallIcon`, `MiddleIcon`, `BigIcon`, `RouletteIcon`, `MarqueeStatus`, `MarqueeIcon`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.PrimaryKeyID}','{item.OperatorID}','{item.AppID}',{item.Flag},'{item.SmallIcon}','{item.MiddleIcon}','{item.BigIcon}','{item.RouletteIcon}',{item.MarqueeStatus},'{item.MarqueeIcon}'),");
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
		/// /// <param name = "primaryKeyID"></param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string primaryKeyID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(primaryKeyID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string primaryKeyID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(primaryKeyID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string primaryKeyID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `PrimaryKeyID` = @PrimaryKeyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PrimaryKeyID", primaryKeyID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(L_appEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.PrimaryKeyID, tm_);
		}
		public async Task<int> RemoveAsync(L_appEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.PrimaryKeyID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByOperatorID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
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
		#region RemoveByAppID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "appID"></param>
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
		#region RemoveByFlag
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "flag">应用标志 0-默认1-Hot2-New</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByFlag(int flag, TransactionManager tm_ = null)
		{
			RepairRemoveByFlagData(flag, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByFlagAsync(int flag, TransactionManager tm_ = null)
		{
			RepairRemoveByFlagData(flag, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByFlagData(int flag, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Flag` = @Flag";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Flag", flag, MySqlDbType.Int32));
		}
		#endregion // RemoveByFlag
		#region RemoveBySmallIcon
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "smallIcon"></param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveBySmallIcon(string smallIcon, TransactionManager tm_ = null)
		{
			RepairRemoveBySmallIconData(smallIcon, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveBySmallIconAsync(string smallIcon, TransactionManager tm_ = null)
		{
			RepairRemoveBySmallIconData(smallIcon, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveBySmallIconData(string smallIcon, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (smallIcon != null ? "`SmallIcon` = @SmallIcon" : "`SmallIcon` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (smallIcon != null)
				paras_.Add(Database.CreateInParameter("@SmallIcon", smallIcon, MySqlDbType.VarChar));
		}
		#endregion // RemoveBySmallIcon
		#region RemoveByMiddleIcon
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "middleIcon"></param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByMiddleIcon(string middleIcon, TransactionManager tm_ = null)
		{
			RepairRemoveByMiddleIconData(middleIcon, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByMiddleIconAsync(string middleIcon, TransactionManager tm_ = null)
		{
			RepairRemoveByMiddleIconData(middleIcon, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByMiddleIconData(string middleIcon, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (middleIcon != null ? "`MiddleIcon` = @MiddleIcon" : "`MiddleIcon` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (middleIcon != null)
				paras_.Add(Database.CreateInParameter("@MiddleIcon", middleIcon, MySqlDbType.VarChar));
		}
		#endregion // RemoveByMiddleIcon
		#region RemoveByBigIcon
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "bigIcon"></param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByBigIcon(string bigIcon, TransactionManager tm_ = null)
		{
			RepairRemoveByBigIconData(bigIcon, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByBigIconAsync(string bigIcon, TransactionManager tm_ = null)
		{
			RepairRemoveByBigIconData(bigIcon, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByBigIconData(string bigIcon, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (bigIcon != null ? "`BigIcon` = @BigIcon" : "`BigIcon` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (bigIcon != null)
				paras_.Add(Database.CreateInParameter("@BigIcon", bigIcon, MySqlDbType.VarChar));
		}
		#endregion // RemoveByBigIcon
		#region RemoveByRouletteIcon
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "rouletteIcon"></param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByRouletteIcon(string rouletteIcon, TransactionManager tm_ = null)
		{
			RepairRemoveByRouletteIconData(rouletteIcon, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByRouletteIconAsync(string rouletteIcon, TransactionManager tm_ = null)
		{
			RepairRemoveByRouletteIconData(rouletteIcon, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByRouletteIconData(string rouletteIcon, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (rouletteIcon != null ? "`RouletteIcon` = @RouletteIcon" : "`RouletteIcon` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (rouletteIcon != null)
				paras_.Add(Database.CreateInParameter("@RouletteIcon", rouletteIcon, MySqlDbType.VarChar));
		}
		#endregion // RemoveByRouletteIcon
		#region RemoveByMarqueeStatus
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "marqueeStatus">是否在跑马灯展示：0不展示，1展示</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByMarqueeStatus(int marqueeStatus, TransactionManager tm_ = null)
		{
			RepairRemoveByMarqueeStatusData(marqueeStatus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByMarqueeStatusAsync(int marqueeStatus, TransactionManager tm_ = null)
		{
			RepairRemoveByMarqueeStatusData(marqueeStatus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByMarqueeStatusData(int marqueeStatus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `MarqueeStatus` = @MarqueeStatus";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MarqueeStatus", marqueeStatus, MySqlDbType.Int32));
		}
		#endregion // RemoveByMarqueeStatus
		#region RemoveByMarqueeIcon
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "marqueeIcon">跑马灯展示的游戏图标</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByMarqueeIcon(string marqueeIcon, TransactionManager tm_ = null)
		{
			RepairRemoveByMarqueeIconData(marqueeIcon, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByMarqueeIconAsync(string marqueeIcon, TransactionManager tm_ = null)
		{
			RepairRemoveByMarqueeIconData(marqueeIcon, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByMarqueeIconData(string marqueeIcon, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (marqueeIcon != null ? "`MarqueeIcon` = @MarqueeIcon" : "`MarqueeIcon` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (marqueeIcon != null)
				paras_.Add(Database.CreateInParameter("@MarqueeIcon", marqueeIcon, MySqlDbType.VarChar));
		}
		#endregion // RemoveByMarqueeIcon
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
		public int Put(L_appEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(L_appEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(L_appEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `PrimaryKeyID` = @PrimaryKeyID, `OperatorID` = @OperatorID, `AppID` = @AppID, `Flag` = @Flag, `SmallIcon` = @SmallIcon, `MiddleIcon` = @MiddleIcon, `BigIcon` = @BigIcon, `RouletteIcon` = @RouletteIcon, `MarqueeStatus` = @MarqueeStatus, `MarqueeIcon` = @MarqueeIcon WHERE `PrimaryKeyID` = @PrimaryKeyID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PrimaryKeyID", item.PrimaryKeyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID != null ? item.OperatorID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", item.AppID != null ? item.AppID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Flag", item.Flag, MySqlDbType.Int32),
				Database.CreateInParameter("@SmallIcon", item.SmallIcon != null ? item.SmallIcon : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@MiddleIcon", item.MiddleIcon != null ? item.MiddleIcon : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@BigIcon", item.BigIcon != null ? item.BigIcon : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@RouletteIcon", item.RouletteIcon != null ? item.RouletteIcon : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@MarqueeStatus", item.MarqueeStatus, MySqlDbType.Int32),
				Database.CreateInParameter("@MarqueeIcon", item.MarqueeIcon != null ? item.MarqueeIcon : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@PrimaryKeyID_Original", item.HasOriginal ? item.OriginalPrimaryKeyID : item.PrimaryKeyID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<L_appEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<L_appEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "primaryKeyID"></param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string primaryKeyID, string set_, params object[] values_)
		{
			return Put(set_, "`PrimaryKeyID` = @PrimaryKeyID", ConcatValues(values_, primaryKeyID));
		}
		public async Task<int> PutByPKAsync(string primaryKeyID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`PrimaryKeyID` = @PrimaryKeyID", ConcatValues(values_, primaryKeyID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "primaryKeyID"></param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string primaryKeyID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`PrimaryKeyID` = @PrimaryKeyID", tm_, ConcatValues(values_, primaryKeyID));
		}
		public async Task<int> PutByPKAsync(string primaryKeyID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`PrimaryKeyID` = @PrimaryKeyID", tm_, ConcatValues(values_, primaryKeyID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "primaryKeyID"></param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string primaryKeyID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@PrimaryKeyID", primaryKeyID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`PrimaryKeyID` = @PrimaryKeyID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string primaryKeyID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@PrimaryKeyID", primaryKeyID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`PrimaryKeyID` = @PrimaryKeyID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutOperatorID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "primaryKeyID"></param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorIDByPK(string primaryKeyID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(primaryKeyID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOperatorIDByPKAsync(string primaryKeyID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(primaryKeyID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOperatorIDByPKData(string primaryKeyID, string operatorID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID  WHERE `PrimaryKeyID` = @PrimaryKeyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID != null ? operatorID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@PrimaryKeyID", primaryKeyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
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
		#region PutAppID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "primaryKeyID"></param>
		/// /// <param name = "appID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAppIDByPK(string primaryKeyID, string appID, TransactionManager tm_ = null)
		{
			RepairPutAppIDByPKData(primaryKeyID, appID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAppIDByPKAsync(string primaryKeyID, string appID, TransactionManager tm_ = null)
		{
			RepairPutAppIDByPKData(primaryKeyID, appID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutAppIDByPKData(string primaryKeyID, string appID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `AppID` = @AppID  WHERE `PrimaryKeyID` = @PrimaryKeyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID != null ? appID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@PrimaryKeyID", primaryKeyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "appID"></param>
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
		#region PutFlag
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "primaryKeyID"></param>
		/// /// <param name = "flag">应用标志 0-默认1-Hot2-New</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFlagByPK(string primaryKeyID, int flag, TransactionManager tm_ = null)
		{
			RepairPutFlagByPKData(primaryKeyID, flag, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFlagByPKAsync(string primaryKeyID, int flag, TransactionManager tm_ = null)
		{
			RepairPutFlagByPKData(primaryKeyID, flag, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFlagByPKData(string primaryKeyID, int flag, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Flag` = @Flag  WHERE `PrimaryKeyID` = @PrimaryKeyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Flag", flag, MySqlDbType.Int32),
				Database.CreateInParameter("@PrimaryKeyID", primaryKeyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "flag">应用标志 0-默认1-Hot2-New</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFlag(int flag, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Flag` = @Flag";
			var parameter_ = Database.CreateInParameter("@Flag", flag, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutFlagAsync(int flag, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Flag` = @Flag";
			var parameter_ = Database.CreateInParameter("@Flag", flag, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutFlag
		#region PutSmallIcon
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "primaryKeyID"></param>
		/// /// <param name = "smallIcon"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSmallIconByPK(string primaryKeyID, string smallIcon, TransactionManager tm_ = null)
		{
			RepairPutSmallIconByPKData(primaryKeyID, smallIcon, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutSmallIconByPKAsync(string primaryKeyID, string smallIcon, TransactionManager tm_ = null)
		{
			RepairPutSmallIconByPKData(primaryKeyID, smallIcon, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutSmallIconByPKData(string primaryKeyID, string smallIcon, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `SmallIcon` = @SmallIcon  WHERE `PrimaryKeyID` = @PrimaryKeyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SmallIcon", smallIcon != null ? smallIcon : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@PrimaryKeyID", primaryKeyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "smallIcon"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSmallIcon(string smallIcon, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SmallIcon` = @SmallIcon";
			var parameter_ = Database.CreateInParameter("@SmallIcon", smallIcon != null ? smallIcon : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutSmallIconAsync(string smallIcon, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SmallIcon` = @SmallIcon";
			var parameter_ = Database.CreateInParameter("@SmallIcon", smallIcon != null ? smallIcon : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutSmallIcon
		#region PutMiddleIcon
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "primaryKeyID"></param>
		/// /// <param name = "middleIcon"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMiddleIconByPK(string primaryKeyID, string middleIcon, TransactionManager tm_ = null)
		{
			RepairPutMiddleIconByPKData(primaryKeyID, middleIcon, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutMiddleIconByPKAsync(string primaryKeyID, string middleIcon, TransactionManager tm_ = null)
		{
			RepairPutMiddleIconByPKData(primaryKeyID, middleIcon, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutMiddleIconByPKData(string primaryKeyID, string middleIcon, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `MiddleIcon` = @MiddleIcon  WHERE `PrimaryKeyID` = @PrimaryKeyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MiddleIcon", middleIcon != null ? middleIcon : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@PrimaryKeyID", primaryKeyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "middleIcon"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMiddleIcon(string middleIcon, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MiddleIcon` = @MiddleIcon";
			var parameter_ = Database.CreateInParameter("@MiddleIcon", middleIcon != null ? middleIcon : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutMiddleIconAsync(string middleIcon, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MiddleIcon` = @MiddleIcon";
			var parameter_ = Database.CreateInParameter("@MiddleIcon", middleIcon != null ? middleIcon : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutMiddleIcon
		#region PutBigIcon
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "primaryKeyID"></param>
		/// /// <param name = "bigIcon"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBigIconByPK(string primaryKeyID, string bigIcon, TransactionManager tm_ = null)
		{
			RepairPutBigIconByPKData(primaryKeyID, bigIcon, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBigIconByPKAsync(string primaryKeyID, string bigIcon, TransactionManager tm_ = null)
		{
			RepairPutBigIconByPKData(primaryKeyID, bigIcon, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBigIconByPKData(string primaryKeyID, string bigIcon, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BigIcon` = @BigIcon  WHERE `PrimaryKeyID` = @PrimaryKeyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BigIcon", bigIcon != null ? bigIcon : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@PrimaryKeyID", primaryKeyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "bigIcon"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBigIcon(string bigIcon, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BigIcon` = @BigIcon";
			var parameter_ = Database.CreateInParameter("@BigIcon", bigIcon != null ? bigIcon : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutBigIconAsync(string bigIcon, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BigIcon` = @BigIcon";
			var parameter_ = Database.CreateInParameter("@BigIcon", bigIcon != null ? bigIcon : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutBigIcon
		#region PutRouletteIcon
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "primaryKeyID"></param>
		/// /// <param name = "rouletteIcon"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRouletteIconByPK(string primaryKeyID, string rouletteIcon, TransactionManager tm_ = null)
		{
			RepairPutRouletteIconByPKData(primaryKeyID, rouletteIcon, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRouletteIconByPKAsync(string primaryKeyID, string rouletteIcon, TransactionManager tm_ = null)
		{
			RepairPutRouletteIconByPKData(primaryKeyID, rouletteIcon, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRouletteIconByPKData(string primaryKeyID, string rouletteIcon, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RouletteIcon` = @RouletteIcon  WHERE `PrimaryKeyID` = @PrimaryKeyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RouletteIcon", rouletteIcon != null ? rouletteIcon : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@PrimaryKeyID", primaryKeyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "rouletteIcon"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRouletteIcon(string rouletteIcon, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RouletteIcon` = @RouletteIcon";
			var parameter_ = Database.CreateInParameter("@RouletteIcon", rouletteIcon != null ? rouletteIcon : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutRouletteIconAsync(string rouletteIcon, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RouletteIcon` = @RouletteIcon";
			var parameter_ = Database.CreateInParameter("@RouletteIcon", rouletteIcon != null ? rouletteIcon : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutRouletteIcon
		#region PutMarqueeStatus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "primaryKeyID"></param>
		/// /// <param name = "marqueeStatus">是否在跑马灯展示：0不展示，1展示</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMarqueeStatusByPK(string primaryKeyID, int marqueeStatus, TransactionManager tm_ = null)
		{
			RepairPutMarqueeStatusByPKData(primaryKeyID, marqueeStatus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutMarqueeStatusByPKAsync(string primaryKeyID, int marqueeStatus, TransactionManager tm_ = null)
		{
			RepairPutMarqueeStatusByPKData(primaryKeyID, marqueeStatus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutMarqueeStatusByPKData(string primaryKeyID, int marqueeStatus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `MarqueeStatus` = @MarqueeStatus  WHERE `PrimaryKeyID` = @PrimaryKeyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MarqueeStatus", marqueeStatus, MySqlDbType.Int32),
				Database.CreateInParameter("@PrimaryKeyID", primaryKeyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "marqueeStatus">是否在跑马灯展示：0不展示，1展示</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMarqueeStatus(int marqueeStatus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MarqueeStatus` = @MarqueeStatus";
			var parameter_ = Database.CreateInParameter("@MarqueeStatus", marqueeStatus, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutMarqueeStatusAsync(int marqueeStatus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MarqueeStatus` = @MarqueeStatus";
			var parameter_ = Database.CreateInParameter("@MarqueeStatus", marqueeStatus, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutMarqueeStatus
		#region PutMarqueeIcon
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "primaryKeyID"></param>
		/// /// <param name = "marqueeIcon">跑马灯展示的游戏图标</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMarqueeIconByPK(string primaryKeyID, string marqueeIcon, TransactionManager tm_ = null)
		{
			RepairPutMarqueeIconByPKData(primaryKeyID, marqueeIcon, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutMarqueeIconByPKAsync(string primaryKeyID, string marqueeIcon, TransactionManager tm_ = null)
		{
			RepairPutMarqueeIconByPKData(primaryKeyID, marqueeIcon, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutMarqueeIconByPKData(string primaryKeyID, string marqueeIcon, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `MarqueeIcon` = @MarqueeIcon  WHERE `PrimaryKeyID` = @PrimaryKeyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MarqueeIcon", marqueeIcon != null ? marqueeIcon : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@PrimaryKeyID", primaryKeyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "marqueeIcon">跑马灯展示的游戏图标</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMarqueeIcon(string marqueeIcon, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MarqueeIcon` = @MarqueeIcon";
			var parameter_ = Database.CreateInParameter("@MarqueeIcon", marqueeIcon != null ? marqueeIcon : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutMarqueeIconAsync(string marqueeIcon, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MarqueeIcon` = @MarqueeIcon";
			var parameter_ = Database.CreateInParameter("@MarqueeIcon", marqueeIcon != null ? marqueeIcon : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutMarqueeIcon
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(L_appEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.PrimaryKeyID) == null)
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
		public async Task<bool> SetAsync(L_appEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.PrimaryKeyID) == null)
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
		/// /// <param name = "primaryKeyID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public L_appEO GetByPK(string primaryKeyID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(primaryKeyID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, L_appEO.MapDataReader);
		}
		public async Task<L_appEO> GetByPKAsync(string primaryKeyID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(primaryKeyID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, L_appEO.MapDataReader);
		}
		private void RepairGetByPKData(string primaryKeyID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`PrimaryKeyID` = @PrimaryKeyID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PrimaryKeyID", primaryKeyID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 OperatorID（字段）
		/// </summary>
		/// /// <param name = "primaryKeyID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorIDByPK(string primaryKeyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PrimaryKeyID", primaryKeyID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OperatorID`", "`PrimaryKeyID` = @PrimaryKeyID", paras_, tm_);
		}
		public async Task<string> GetOperatorIDByPKAsync(string primaryKeyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PrimaryKeyID", primaryKeyID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OperatorID`", "`PrimaryKeyID` = @PrimaryKeyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 AppID（字段）
		/// </summary>
		/// /// <param name = "primaryKeyID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetAppIDByPK(string primaryKeyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PrimaryKeyID", primaryKeyID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`AppID`", "`PrimaryKeyID` = @PrimaryKeyID", paras_, tm_);
		}
		public async Task<string> GetAppIDByPKAsync(string primaryKeyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PrimaryKeyID", primaryKeyID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`AppID`", "`PrimaryKeyID` = @PrimaryKeyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Flag（字段）
		/// </summary>
		/// /// <param name = "primaryKeyID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetFlagByPK(string primaryKeyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PrimaryKeyID", primaryKeyID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`Flag`", "`PrimaryKeyID` = @PrimaryKeyID", paras_, tm_);
		}
		public async Task<int> GetFlagByPKAsync(string primaryKeyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PrimaryKeyID", primaryKeyID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`Flag`", "`PrimaryKeyID` = @PrimaryKeyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 SmallIcon（字段）
		/// </summary>
		/// /// <param name = "primaryKeyID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetSmallIconByPK(string primaryKeyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PrimaryKeyID", primaryKeyID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`SmallIcon`", "`PrimaryKeyID` = @PrimaryKeyID", paras_, tm_);
		}
		public async Task<string> GetSmallIconByPKAsync(string primaryKeyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PrimaryKeyID", primaryKeyID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`SmallIcon`", "`PrimaryKeyID` = @PrimaryKeyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 MiddleIcon（字段）
		/// </summary>
		/// /// <param name = "primaryKeyID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetMiddleIconByPK(string primaryKeyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PrimaryKeyID", primaryKeyID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`MiddleIcon`", "`PrimaryKeyID` = @PrimaryKeyID", paras_, tm_);
		}
		public async Task<string> GetMiddleIconByPKAsync(string primaryKeyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PrimaryKeyID", primaryKeyID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`MiddleIcon`", "`PrimaryKeyID` = @PrimaryKeyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 BigIcon（字段）
		/// </summary>
		/// /// <param name = "primaryKeyID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetBigIconByPK(string primaryKeyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PrimaryKeyID", primaryKeyID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`BigIcon`", "`PrimaryKeyID` = @PrimaryKeyID", paras_, tm_);
		}
		public async Task<string> GetBigIconByPKAsync(string primaryKeyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PrimaryKeyID", primaryKeyID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`BigIcon`", "`PrimaryKeyID` = @PrimaryKeyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RouletteIcon（字段）
		/// </summary>
		/// /// <param name = "primaryKeyID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetRouletteIconByPK(string primaryKeyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PrimaryKeyID", primaryKeyID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`RouletteIcon`", "`PrimaryKeyID` = @PrimaryKeyID", paras_, tm_);
		}
		public async Task<string> GetRouletteIconByPKAsync(string primaryKeyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PrimaryKeyID", primaryKeyID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`RouletteIcon`", "`PrimaryKeyID` = @PrimaryKeyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 MarqueeStatus（字段）
		/// </summary>
		/// /// <param name = "primaryKeyID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetMarqueeStatusByPK(string primaryKeyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PrimaryKeyID", primaryKeyID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`MarqueeStatus`", "`PrimaryKeyID` = @PrimaryKeyID", paras_, tm_);
		}
		public async Task<int> GetMarqueeStatusByPKAsync(string primaryKeyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PrimaryKeyID", primaryKeyID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`MarqueeStatus`", "`PrimaryKeyID` = @PrimaryKeyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 MarqueeIcon（字段）
		/// </summary>
		/// /// <param name = "primaryKeyID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetMarqueeIconByPK(string primaryKeyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PrimaryKeyID", primaryKeyID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`MarqueeIcon`", "`PrimaryKeyID` = @PrimaryKeyID", paras_, tm_);
		}
		public async Task<string> GetMarqueeIconByPKAsync(string primaryKeyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PrimaryKeyID", primaryKeyID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`MarqueeIcon`", "`PrimaryKeyID` = @PrimaryKeyID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <return>实体对象集合</return>
		public List<L_appEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<L_appEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_appEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<L_appEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_appEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<L_appEO>> GetByOperatorIDAsync(string operatorID, int top_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_appEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<L_appEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_appEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<L_appEO>> GetByOperatorIDAsync(string operatorID, string sort_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_appEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<L_appEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_appEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operatorID != null ? "`OperatorID` = @OperatorID" : "`OperatorID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operatorID != null)
				paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_appEO.MapDataReader);
		}
		public async Task<List<L_appEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operatorID != null ? "`OperatorID` = @OperatorID" : "`OperatorID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operatorID != null)
				paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_appEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByAppID
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID"></param>
		/// <return>实体对象集合</return>
		public List<L_appEO> GetByAppID(string appID)
		{
			return GetByAppID(appID, 0, string.Empty, null);
		}
		public async Task<List<L_appEO>> GetByAppIDAsync(string appID)
		{
			return await GetByAppIDAsync(appID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_appEO> GetByAppID(string appID, TransactionManager tm_)
		{
			return GetByAppID(appID, 0, string.Empty, tm_);
		}
		public async Task<List<L_appEO>> GetByAppIDAsync(string appID, TransactionManager tm_)
		{
			return await GetByAppIDAsync(appID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_appEO> GetByAppID(string appID, int top_)
		{
			return GetByAppID(appID, top_, string.Empty, null);
		}
		public async Task<List<L_appEO>> GetByAppIDAsync(string appID, int top_)
		{
			return await GetByAppIDAsync(appID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_appEO> GetByAppID(string appID, int top_, TransactionManager tm_)
		{
			return GetByAppID(appID, top_, string.Empty, tm_);
		}
		public async Task<List<L_appEO>> GetByAppIDAsync(string appID, int top_, TransactionManager tm_)
		{
			return await GetByAppIDAsync(appID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_appEO> GetByAppID(string appID, string sort_)
		{
			return GetByAppID(appID, 0, sort_, null);
		}
		public async Task<List<L_appEO>> GetByAppIDAsync(string appID, string sort_)
		{
			return await GetByAppIDAsync(appID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_appEO> GetByAppID(string appID, string sort_, TransactionManager tm_)
		{
			return GetByAppID(appID, 0, sort_, tm_);
		}
		public async Task<List<L_appEO>> GetByAppIDAsync(string appID, string sort_, TransactionManager tm_)
		{
			return await GetByAppIDAsync(appID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_appEO> GetByAppID(string appID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(appID != null ? "`AppID` = @AppID" : "`AppID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (appID != null)
				paras_.Add(Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_appEO.MapDataReader);
		}
		public async Task<List<L_appEO>> GetByAppIDAsync(string appID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(appID != null ? "`AppID` = @AppID" : "`AppID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (appID != null)
				paras_.Add(Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_appEO.MapDataReader);
		}
		#endregion // GetByAppID
		#region GetByFlag
		
		/// <summary>
		/// 按 Flag（字段） 查询
		/// </summary>
		/// /// <param name = "flag">应用标志 0-默认1-Hot2-New</param>
		/// <return>实体对象集合</return>
		public List<L_appEO> GetByFlag(int flag)
		{
			return GetByFlag(flag, 0, string.Empty, null);
		}
		public async Task<List<L_appEO>> GetByFlagAsync(int flag)
		{
			return await GetByFlagAsync(flag, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Flag（字段） 查询
		/// </summary>
		/// /// <param name = "flag">应用标志 0-默认1-Hot2-New</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_appEO> GetByFlag(int flag, TransactionManager tm_)
		{
			return GetByFlag(flag, 0, string.Empty, tm_);
		}
		public async Task<List<L_appEO>> GetByFlagAsync(int flag, TransactionManager tm_)
		{
			return await GetByFlagAsync(flag, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Flag（字段） 查询
		/// </summary>
		/// /// <param name = "flag">应用标志 0-默认1-Hot2-New</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_appEO> GetByFlag(int flag, int top_)
		{
			return GetByFlag(flag, top_, string.Empty, null);
		}
		public async Task<List<L_appEO>> GetByFlagAsync(int flag, int top_)
		{
			return await GetByFlagAsync(flag, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Flag（字段） 查询
		/// </summary>
		/// /// <param name = "flag">应用标志 0-默认1-Hot2-New</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_appEO> GetByFlag(int flag, int top_, TransactionManager tm_)
		{
			return GetByFlag(flag, top_, string.Empty, tm_);
		}
		public async Task<List<L_appEO>> GetByFlagAsync(int flag, int top_, TransactionManager tm_)
		{
			return await GetByFlagAsync(flag, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Flag（字段） 查询
		/// </summary>
		/// /// <param name = "flag">应用标志 0-默认1-Hot2-New</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_appEO> GetByFlag(int flag, string sort_)
		{
			return GetByFlag(flag, 0, sort_, null);
		}
		public async Task<List<L_appEO>> GetByFlagAsync(int flag, string sort_)
		{
			return await GetByFlagAsync(flag, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Flag（字段） 查询
		/// </summary>
		/// /// <param name = "flag">应用标志 0-默认1-Hot2-New</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_appEO> GetByFlag(int flag, string sort_, TransactionManager tm_)
		{
			return GetByFlag(flag, 0, sort_, tm_);
		}
		public async Task<List<L_appEO>> GetByFlagAsync(int flag, string sort_, TransactionManager tm_)
		{
			return await GetByFlagAsync(flag, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Flag（字段） 查询
		/// </summary>
		/// /// <param name = "flag">应用标志 0-默认1-Hot2-New</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_appEO> GetByFlag(int flag, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Flag` = @Flag", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Flag", flag, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, L_appEO.MapDataReader);
		}
		public async Task<List<L_appEO>> GetByFlagAsync(int flag, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Flag` = @Flag", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Flag", flag, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_appEO.MapDataReader);
		}
		#endregion // GetByFlag
		#region GetBySmallIcon
		
		/// <summary>
		/// 按 SmallIcon（字段） 查询
		/// </summary>
		/// /// <param name = "smallIcon"></param>
		/// <return>实体对象集合</return>
		public List<L_appEO> GetBySmallIcon(string smallIcon)
		{
			return GetBySmallIcon(smallIcon, 0, string.Empty, null);
		}
		public async Task<List<L_appEO>> GetBySmallIconAsync(string smallIcon)
		{
			return await GetBySmallIconAsync(smallIcon, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SmallIcon（字段） 查询
		/// </summary>
		/// /// <param name = "smallIcon"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_appEO> GetBySmallIcon(string smallIcon, TransactionManager tm_)
		{
			return GetBySmallIcon(smallIcon, 0, string.Empty, tm_);
		}
		public async Task<List<L_appEO>> GetBySmallIconAsync(string smallIcon, TransactionManager tm_)
		{
			return await GetBySmallIconAsync(smallIcon, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SmallIcon（字段） 查询
		/// </summary>
		/// /// <param name = "smallIcon"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_appEO> GetBySmallIcon(string smallIcon, int top_)
		{
			return GetBySmallIcon(smallIcon, top_, string.Empty, null);
		}
		public async Task<List<L_appEO>> GetBySmallIconAsync(string smallIcon, int top_)
		{
			return await GetBySmallIconAsync(smallIcon, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SmallIcon（字段） 查询
		/// </summary>
		/// /// <param name = "smallIcon"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_appEO> GetBySmallIcon(string smallIcon, int top_, TransactionManager tm_)
		{
			return GetBySmallIcon(smallIcon, top_, string.Empty, tm_);
		}
		public async Task<List<L_appEO>> GetBySmallIconAsync(string smallIcon, int top_, TransactionManager tm_)
		{
			return await GetBySmallIconAsync(smallIcon, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SmallIcon（字段） 查询
		/// </summary>
		/// /// <param name = "smallIcon"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_appEO> GetBySmallIcon(string smallIcon, string sort_)
		{
			return GetBySmallIcon(smallIcon, 0, sort_, null);
		}
		public async Task<List<L_appEO>> GetBySmallIconAsync(string smallIcon, string sort_)
		{
			return await GetBySmallIconAsync(smallIcon, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 SmallIcon（字段） 查询
		/// </summary>
		/// /// <param name = "smallIcon"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_appEO> GetBySmallIcon(string smallIcon, string sort_, TransactionManager tm_)
		{
			return GetBySmallIcon(smallIcon, 0, sort_, tm_);
		}
		public async Task<List<L_appEO>> GetBySmallIconAsync(string smallIcon, string sort_, TransactionManager tm_)
		{
			return await GetBySmallIconAsync(smallIcon, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 SmallIcon（字段） 查询
		/// </summary>
		/// /// <param name = "smallIcon"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_appEO> GetBySmallIcon(string smallIcon, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(smallIcon != null ? "`SmallIcon` = @SmallIcon" : "`SmallIcon` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (smallIcon != null)
				paras_.Add(Database.CreateInParameter("@SmallIcon", smallIcon, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_appEO.MapDataReader);
		}
		public async Task<List<L_appEO>> GetBySmallIconAsync(string smallIcon, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(smallIcon != null ? "`SmallIcon` = @SmallIcon" : "`SmallIcon` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (smallIcon != null)
				paras_.Add(Database.CreateInParameter("@SmallIcon", smallIcon, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_appEO.MapDataReader);
		}
		#endregion // GetBySmallIcon
		#region GetByMiddleIcon
		
		/// <summary>
		/// 按 MiddleIcon（字段） 查询
		/// </summary>
		/// /// <param name = "middleIcon"></param>
		/// <return>实体对象集合</return>
		public List<L_appEO> GetByMiddleIcon(string middleIcon)
		{
			return GetByMiddleIcon(middleIcon, 0, string.Empty, null);
		}
		public async Task<List<L_appEO>> GetByMiddleIconAsync(string middleIcon)
		{
			return await GetByMiddleIconAsync(middleIcon, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MiddleIcon（字段） 查询
		/// </summary>
		/// /// <param name = "middleIcon"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_appEO> GetByMiddleIcon(string middleIcon, TransactionManager tm_)
		{
			return GetByMiddleIcon(middleIcon, 0, string.Empty, tm_);
		}
		public async Task<List<L_appEO>> GetByMiddleIconAsync(string middleIcon, TransactionManager tm_)
		{
			return await GetByMiddleIconAsync(middleIcon, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MiddleIcon（字段） 查询
		/// </summary>
		/// /// <param name = "middleIcon"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_appEO> GetByMiddleIcon(string middleIcon, int top_)
		{
			return GetByMiddleIcon(middleIcon, top_, string.Empty, null);
		}
		public async Task<List<L_appEO>> GetByMiddleIconAsync(string middleIcon, int top_)
		{
			return await GetByMiddleIconAsync(middleIcon, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MiddleIcon（字段） 查询
		/// </summary>
		/// /// <param name = "middleIcon"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_appEO> GetByMiddleIcon(string middleIcon, int top_, TransactionManager tm_)
		{
			return GetByMiddleIcon(middleIcon, top_, string.Empty, tm_);
		}
		public async Task<List<L_appEO>> GetByMiddleIconAsync(string middleIcon, int top_, TransactionManager tm_)
		{
			return await GetByMiddleIconAsync(middleIcon, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MiddleIcon（字段） 查询
		/// </summary>
		/// /// <param name = "middleIcon"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_appEO> GetByMiddleIcon(string middleIcon, string sort_)
		{
			return GetByMiddleIcon(middleIcon, 0, sort_, null);
		}
		public async Task<List<L_appEO>> GetByMiddleIconAsync(string middleIcon, string sort_)
		{
			return await GetByMiddleIconAsync(middleIcon, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 MiddleIcon（字段） 查询
		/// </summary>
		/// /// <param name = "middleIcon"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_appEO> GetByMiddleIcon(string middleIcon, string sort_, TransactionManager tm_)
		{
			return GetByMiddleIcon(middleIcon, 0, sort_, tm_);
		}
		public async Task<List<L_appEO>> GetByMiddleIconAsync(string middleIcon, string sort_, TransactionManager tm_)
		{
			return await GetByMiddleIconAsync(middleIcon, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 MiddleIcon（字段） 查询
		/// </summary>
		/// /// <param name = "middleIcon"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_appEO> GetByMiddleIcon(string middleIcon, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(middleIcon != null ? "`MiddleIcon` = @MiddleIcon" : "`MiddleIcon` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (middleIcon != null)
				paras_.Add(Database.CreateInParameter("@MiddleIcon", middleIcon, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_appEO.MapDataReader);
		}
		public async Task<List<L_appEO>> GetByMiddleIconAsync(string middleIcon, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(middleIcon != null ? "`MiddleIcon` = @MiddleIcon" : "`MiddleIcon` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (middleIcon != null)
				paras_.Add(Database.CreateInParameter("@MiddleIcon", middleIcon, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_appEO.MapDataReader);
		}
		#endregion // GetByMiddleIcon
		#region GetByBigIcon
		
		/// <summary>
		/// 按 BigIcon（字段） 查询
		/// </summary>
		/// /// <param name = "bigIcon"></param>
		/// <return>实体对象集合</return>
		public List<L_appEO> GetByBigIcon(string bigIcon)
		{
			return GetByBigIcon(bigIcon, 0, string.Empty, null);
		}
		public async Task<List<L_appEO>> GetByBigIconAsync(string bigIcon)
		{
			return await GetByBigIconAsync(bigIcon, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BigIcon（字段） 查询
		/// </summary>
		/// /// <param name = "bigIcon"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_appEO> GetByBigIcon(string bigIcon, TransactionManager tm_)
		{
			return GetByBigIcon(bigIcon, 0, string.Empty, tm_);
		}
		public async Task<List<L_appEO>> GetByBigIconAsync(string bigIcon, TransactionManager tm_)
		{
			return await GetByBigIconAsync(bigIcon, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BigIcon（字段） 查询
		/// </summary>
		/// /// <param name = "bigIcon"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_appEO> GetByBigIcon(string bigIcon, int top_)
		{
			return GetByBigIcon(bigIcon, top_, string.Empty, null);
		}
		public async Task<List<L_appEO>> GetByBigIconAsync(string bigIcon, int top_)
		{
			return await GetByBigIconAsync(bigIcon, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BigIcon（字段） 查询
		/// </summary>
		/// /// <param name = "bigIcon"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_appEO> GetByBigIcon(string bigIcon, int top_, TransactionManager tm_)
		{
			return GetByBigIcon(bigIcon, top_, string.Empty, tm_);
		}
		public async Task<List<L_appEO>> GetByBigIconAsync(string bigIcon, int top_, TransactionManager tm_)
		{
			return await GetByBigIconAsync(bigIcon, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BigIcon（字段） 查询
		/// </summary>
		/// /// <param name = "bigIcon"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_appEO> GetByBigIcon(string bigIcon, string sort_)
		{
			return GetByBigIcon(bigIcon, 0, sort_, null);
		}
		public async Task<List<L_appEO>> GetByBigIconAsync(string bigIcon, string sort_)
		{
			return await GetByBigIconAsync(bigIcon, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BigIcon（字段） 查询
		/// </summary>
		/// /// <param name = "bigIcon"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_appEO> GetByBigIcon(string bigIcon, string sort_, TransactionManager tm_)
		{
			return GetByBigIcon(bigIcon, 0, sort_, tm_);
		}
		public async Task<List<L_appEO>> GetByBigIconAsync(string bigIcon, string sort_, TransactionManager tm_)
		{
			return await GetByBigIconAsync(bigIcon, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BigIcon（字段） 查询
		/// </summary>
		/// /// <param name = "bigIcon"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_appEO> GetByBigIcon(string bigIcon, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(bigIcon != null ? "`BigIcon` = @BigIcon" : "`BigIcon` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (bigIcon != null)
				paras_.Add(Database.CreateInParameter("@BigIcon", bigIcon, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_appEO.MapDataReader);
		}
		public async Task<List<L_appEO>> GetByBigIconAsync(string bigIcon, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(bigIcon != null ? "`BigIcon` = @BigIcon" : "`BigIcon` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (bigIcon != null)
				paras_.Add(Database.CreateInParameter("@BigIcon", bigIcon, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_appEO.MapDataReader);
		}
		#endregion // GetByBigIcon
		#region GetByRouletteIcon
		
		/// <summary>
		/// 按 RouletteIcon（字段） 查询
		/// </summary>
		/// /// <param name = "rouletteIcon"></param>
		/// <return>实体对象集合</return>
		public List<L_appEO> GetByRouletteIcon(string rouletteIcon)
		{
			return GetByRouletteIcon(rouletteIcon, 0, string.Empty, null);
		}
		public async Task<List<L_appEO>> GetByRouletteIconAsync(string rouletteIcon)
		{
			return await GetByRouletteIconAsync(rouletteIcon, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RouletteIcon（字段） 查询
		/// </summary>
		/// /// <param name = "rouletteIcon"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_appEO> GetByRouletteIcon(string rouletteIcon, TransactionManager tm_)
		{
			return GetByRouletteIcon(rouletteIcon, 0, string.Empty, tm_);
		}
		public async Task<List<L_appEO>> GetByRouletteIconAsync(string rouletteIcon, TransactionManager tm_)
		{
			return await GetByRouletteIconAsync(rouletteIcon, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RouletteIcon（字段） 查询
		/// </summary>
		/// /// <param name = "rouletteIcon"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_appEO> GetByRouletteIcon(string rouletteIcon, int top_)
		{
			return GetByRouletteIcon(rouletteIcon, top_, string.Empty, null);
		}
		public async Task<List<L_appEO>> GetByRouletteIconAsync(string rouletteIcon, int top_)
		{
			return await GetByRouletteIconAsync(rouletteIcon, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RouletteIcon（字段） 查询
		/// </summary>
		/// /// <param name = "rouletteIcon"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_appEO> GetByRouletteIcon(string rouletteIcon, int top_, TransactionManager tm_)
		{
			return GetByRouletteIcon(rouletteIcon, top_, string.Empty, tm_);
		}
		public async Task<List<L_appEO>> GetByRouletteIconAsync(string rouletteIcon, int top_, TransactionManager tm_)
		{
			return await GetByRouletteIconAsync(rouletteIcon, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RouletteIcon（字段） 查询
		/// </summary>
		/// /// <param name = "rouletteIcon"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_appEO> GetByRouletteIcon(string rouletteIcon, string sort_)
		{
			return GetByRouletteIcon(rouletteIcon, 0, sort_, null);
		}
		public async Task<List<L_appEO>> GetByRouletteIconAsync(string rouletteIcon, string sort_)
		{
			return await GetByRouletteIconAsync(rouletteIcon, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RouletteIcon（字段） 查询
		/// </summary>
		/// /// <param name = "rouletteIcon"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_appEO> GetByRouletteIcon(string rouletteIcon, string sort_, TransactionManager tm_)
		{
			return GetByRouletteIcon(rouletteIcon, 0, sort_, tm_);
		}
		public async Task<List<L_appEO>> GetByRouletteIconAsync(string rouletteIcon, string sort_, TransactionManager tm_)
		{
			return await GetByRouletteIconAsync(rouletteIcon, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RouletteIcon（字段） 查询
		/// </summary>
		/// /// <param name = "rouletteIcon"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_appEO> GetByRouletteIcon(string rouletteIcon, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(rouletteIcon != null ? "`RouletteIcon` = @RouletteIcon" : "`RouletteIcon` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (rouletteIcon != null)
				paras_.Add(Database.CreateInParameter("@RouletteIcon", rouletteIcon, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_appEO.MapDataReader);
		}
		public async Task<List<L_appEO>> GetByRouletteIconAsync(string rouletteIcon, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(rouletteIcon != null ? "`RouletteIcon` = @RouletteIcon" : "`RouletteIcon` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (rouletteIcon != null)
				paras_.Add(Database.CreateInParameter("@RouletteIcon", rouletteIcon, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_appEO.MapDataReader);
		}
		#endregion // GetByRouletteIcon
		#region GetByMarqueeStatus
		
		/// <summary>
		/// 按 MarqueeStatus（字段） 查询
		/// </summary>
		/// /// <param name = "marqueeStatus">是否在跑马灯展示：0不展示，1展示</param>
		/// <return>实体对象集合</return>
		public List<L_appEO> GetByMarqueeStatus(int marqueeStatus)
		{
			return GetByMarqueeStatus(marqueeStatus, 0, string.Empty, null);
		}
		public async Task<List<L_appEO>> GetByMarqueeStatusAsync(int marqueeStatus)
		{
			return await GetByMarqueeStatusAsync(marqueeStatus, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MarqueeStatus（字段） 查询
		/// </summary>
		/// /// <param name = "marqueeStatus">是否在跑马灯展示：0不展示，1展示</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_appEO> GetByMarqueeStatus(int marqueeStatus, TransactionManager tm_)
		{
			return GetByMarqueeStatus(marqueeStatus, 0, string.Empty, tm_);
		}
		public async Task<List<L_appEO>> GetByMarqueeStatusAsync(int marqueeStatus, TransactionManager tm_)
		{
			return await GetByMarqueeStatusAsync(marqueeStatus, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MarqueeStatus（字段） 查询
		/// </summary>
		/// /// <param name = "marqueeStatus">是否在跑马灯展示：0不展示，1展示</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_appEO> GetByMarqueeStatus(int marqueeStatus, int top_)
		{
			return GetByMarqueeStatus(marqueeStatus, top_, string.Empty, null);
		}
		public async Task<List<L_appEO>> GetByMarqueeStatusAsync(int marqueeStatus, int top_)
		{
			return await GetByMarqueeStatusAsync(marqueeStatus, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MarqueeStatus（字段） 查询
		/// </summary>
		/// /// <param name = "marqueeStatus">是否在跑马灯展示：0不展示，1展示</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_appEO> GetByMarqueeStatus(int marqueeStatus, int top_, TransactionManager tm_)
		{
			return GetByMarqueeStatus(marqueeStatus, top_, string.Empty, tm_);
		}
		public async Task<List<L_appEO>> GetByMarqueeStatusAsync(int marqueeStatus, int top_, TransactionManager tm_)
		{
			return await GetByMarqueeStatusAsync(marqueeStatus, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MarqueeStatus（字段） 查询
		/// </summary>
		/// /// <param name = "marqueeStatus">是否在跑马灯展示：0不展示，1展示</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_appEO> GetByMarqueeStatus(int marqueeStatus, string sort_)
		{
			return GetByMarqueeStatus(marqueeStatus, 0, sort_, null);
		}
		public async Task<List<L_appEO>> GetByMarqueeStatusAsync(int marqueeStatus, string sort_)
		{
			return await GetByMarqueeStatusAsync(marqueeStatus, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 MarqueeStatus（字段） 查询
		/// </summary>
		/// /// <param name = "marqueeStatus">是否在跑马灯展示：0不展示，1展示</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_appEO> GetByMarqueeStatus(int marqueeStatus, string sort_, TransactionManager tm_)
		{
			return GetByMarqueeStatus(marqueeStatus, 0, sort_, tm_);
		}
		public async Task<List<L_appEO>> GetByMarqueeStatusAsync(int marqueeStatus, string sort_, TransactionManager tm_)
		{
			return await GetByMarqueeStatusAsync(marqueeStatus, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 MarqueeStatus（字段） 查询
		/// </summary>
		/// /// <param name = "marqueeStatus">是否在跑马灯展示：0不展示，1展示</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_appEO> GetByMarqueeStatus(int marqueeStatus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`MarqueeStatus` = @MarqueeStatus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MarqueeStatus", marqueeStatus, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, L_appEO.MapDataReader);
		}
		public async Task<List<L_appEO>> GetByMarqueeStatusAsync(int marqueeStatus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`MarqueeStatus` = @MarqueeStatus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MarqueeStatus", marqueeStatus, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_appEO.MapDataReader);
		}
		#endregion // GetByMarqueeStatus
		#region GetByMarqueeIcon
		
		/// <summary>
		/// 按 MarqueeIcon（字段） 查询
		/// </summary>
		/// /// <param name = "marqueeIcon">跑马灯展示的游戏图标</param>
		/// <return>实体对象集合</return>
		public List<L_appEO> GetByMarqueeIcon(string marqueeIcon)
		{
			return GetByMarqueeIcon(marqueeIcon, 0, string.Empty, null);
		}
		public async Task<List<L_appEO>> GetByMarqueeIconAsync(string marqueeIcon)
		{
			return await GetByMarqueeIconAsync(marqueeIcon, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MarqueeIcon（字段） 查询
		/// </summary>
		/// /// <param name = "marqueeIcon">跑马灯展示的游戏图标</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_appEO> GetByMarqueeIcon(string marqueeIcon, TransactionManager tm_)
		{
			return GetByMarqueeIcon(marqueeIcon, 0, string.Empty, tm_);
		}
		public async Task<List<L_appEO>> GetByMarqueeIconAsync(string marqueeIcon, TransactionManager tm_)
		{
			return await GetByMarqueeIconAsync(marqueeIcon, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MarqueeIcon（字段） 查询
		/// </summary>
		/// /// <param name = "marqueeIcon">跑马灯展示的游戏图标</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<L_appEO> GetByMarqueeIcon(string marqueeIcon, int top_)
		{
			return GetByMarqueeIcon(marqueeIcon, top_, string.Empty, null);
		}
		public async Task<List<L_appEO>> GetByMarqueeIconAsync(string marqueeIcon, int top_)
		{
			return await GetByMarqueeIconAsync(marqueeIcon, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MarqueeIcon（字段） 查询
		/// </summary>
		/// /// <param name = "marqueeIcon">跑马灯展示的游戏图标</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_appEO> GetByMarqueeIcon(string marqueeIcon, int top_, TransactionManager tm_)
		{
			return GetByMarqueeIcon(marqueeIcon, top_, string.Empty, tm_);
		}
		public async Task<List<L_appEO>> GetByMarqueeIconAsync(string marqueeIcon, int top_, TransactionManager tm_)
		{
			return await GetByMarqueeIconAsync(marqueeIcon, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MarqueeIcon（字段） 查询
		/// </summary>
		/// /// <param name = "marqueeIcon">跑马灯展示的游戏图标</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<L_appEO> GetByMarqueeIcon(string marqueeIcon, string sort_)
		{
			return GetByMarqueeIcon(marqueeIcon, 0, sort_, null);
		}
		public async Task<List<L_appEO>> GetByMarqueeIconAsync(string marqueeIcon, string sort_)
		{
			return await GetByMarqueeIconAsync(marqueeIcon, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 MarqueeIcon（字段） 查询
		/// </summary>
		/// /// <param name = "marqueeIcon">跑马灯展示的游戏图标</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_appEO> GetByMarqueeIcon(string marqueeIcon, string sort_, TransactionManager tm_)
		{
			return GetByMarqueeIcon(marqueeIcon, 0, sort_, tm_);
		}
		public async Task<List<L_appEO>> GetByMarqueeIconAsync(string marqueeIcon, string sort_, TransactionManager tm_)
		{
			return await GetByMarqueeIconAsync(marqueeIcon, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 MarqueeIcon（字段） 查询
		/// </summary>
		/// /// <param name = "marqueeIcon">跑马灯展示的游戏图标</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<L_appEO> GetByMarqueeIcon(string marqueeIcon, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(marqueeIcon != null ? "`MarqueeIcon` = @MarqueeIcon" : "`MarqueeIcon` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (marqueeIcon != null)
				paras_.Add(Database.CreateInParameter("@MarqueeIcon", marqueeIcon, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, L_appEO.MapDataReader);
		}
		public async Task<List<L_appEO>> GetByMarqueeIconAsync(string marqueeIcon, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(marqueeIcon != null ? "`MarqueeIcon` = @MarqueeIcon" : "`MarqueeIcon` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (marqueeIcon != null)
				paras_.Add(Database.CreateInParameter("@MarqueeIcon", marqueeIcon, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, L_appEO.MapDataReader);
		}
		#endregion // GetByMarqueeIcon
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
