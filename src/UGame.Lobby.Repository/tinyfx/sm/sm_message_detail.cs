/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * AiUo代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/AiUo
 * 文档生成时间：2023-10-24 18: 05:07
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
	/// 【表 sm_message_detail 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Sm_message_detailEO : IRowMapper<Sm_message_detailEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Sm_message_detailEO()
		{
			this.Flag = 0;
			this.RecDate = DateTime.Now;
			this.UpdateTime = DateTime.Now;
			this.State = 0;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private string _originalDetailID;
		/// <summary>
		/// 【数据库中的原始主键 DetailID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalDetailID
		{
			get { return _originalDetailID; }
			set { HasOriginal = true; _originalDetailID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "DetailID", DetailID }, };
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
		/// 【主键 varchar(36)】
		/// </summary>
		[DataMember(Order = 1)]
		public string DetailID { get; set; }
		/// <summary>
		/// 邮件编号
		/// 【字段 varchar(36)】
		/// </summary>
		[DataMember(Order = 2)]
		public string MessageID { get; set; }
		/// <summary>
		/// 收件人
		/// 【字段 varchar(36)】
		/// </summary>
		[DataMember(Order = 3)]
		public string UserID { get; set; }
		/// <summary>
		/// 0初始状态1已读未领奖励2已读已领取奖励3已读领取奖励失败
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 4)]
		public int Flag { get; set; }
		/// <summary>
		/// 创建时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 5)]
		public DateTime? RecDate { get; set; }
		/// <summary>
		/// 修改时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 6)]
		public DateTime? UpdateTime { get; set; }
		/// <summary>
		/// 是否删除0未删除1已删除
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 7)]
		public int State { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Sm_message_detailEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Sm_message_detailEO MapDataReader(IDataReader reader)
		{
		    Sm_message_detailEO ret = new Sm_message_detailEO();
			ret.DetailID = reader.ToString("DetailID");
			ret.OriginalDetailID = ret.DetailID;
			ret.MessageID = reader.ToString("MessageID");
			ret.UserID = reader.ToString("UserID");
			ret.Flag = reader.ToInt32("Flag");
			ret.RecDate = reader.ToDateTimeN("RecDate");
			ret.UpdateTime = reader.ToDateTimeN("UpdateTime");
			ret.State = reader.ToInt32("State");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 
	/// 【表 sm_message_detail 的操作类】
	/// </summary>
	[Obsolete]
	public class Sm_message_detailMO : MySqlTableMO<Sm_message_detailEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`sm_message_detail`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Sm_message_detailMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Sm_message_detailMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Sm_message_detailMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Sm_message_detailEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Sm_message_detailEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Sm_message_detailEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`DetailID`, `MessageID`, `UserID`, `Flag`, `RecDate`, `UpdateTime`, `State`) VALUE (@DetailID, @MessageID, @UserID, @Flag, @RecDate, @UpdateTime, @State);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", item.DetailID, MySqlDbType.VarChar),
				Database.CreateInParameter("@MessageID", item.MessageID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Flag", item.Flag, MySqlDbType.Int32),
				Database.CreateInParameter("@RecDate", item.RecDate.HasValue ? item.RecDate.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@UpdateTime", item.UpdateTime.HasValue ? item.UpdateTime.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@State", item.State, MySqlDbType.Int32),
			};
		}
		public int AddByBatch(IEnumerable<Sm_message_detailEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Sm_message_detailEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sm_message_detailEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`DetailID`, `MessageID`, `UserID`, `Flag`, `RecDate`, `UpdateTime`, `State`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.DetailID}','{item.MessageID}','{item.UserID}',{item.Flag},'{item.RecDate?.ToString("yyyy-MM-dd HH:mm:ss")}','{item.UpdateTime?.ToString("yyyy-MM-dd HH:mm:ss")}',{item.State}),");
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
		/// /// <param name = "detailID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string detailID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(detailID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(detailID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string detailID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Sm_message_detailEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.DetailID, tm_);
		}
		public async Task<int> RemoveAsync(Sm_message_detailEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.DetailID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByMessageID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "messageID">邮件编号</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByMessageID(string messageID, TransactionManager tm_ = null)
		{
			RepairRemoveByMessageIDData(messageID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByMessageIDAsync(string messageID, TransactionManager tm_ = null)
		{
			RepairRemoveByMessageIDData(messageID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByMessageIDData(string messageID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `MessageID` = @MessageID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByMessageID
		#region RemoveByUserID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "userID">收件人</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByUserID(string userID, TransactionManager tm_ = null)
		{
			RepairRemoveByUserIDData(userID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByUserIDAsync(string userID, TransactionManager tm_ = null)
		{
			RepairRemoveByUserIDData(userID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByUserIDData(string userID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByUserID
		#region RemoveByFlag
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "flag">0初始状态1已读未领奖励2已读已领取奖励3已读领取奖励失败</param>
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
		#region RemoveByRecDate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "recDate">创建时间</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByRecDate(DateTime? recDate, TransactionManager tm_ = null)
		{
			RepairRemoveByRecDateData(recDate.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByRecDateAsync(DateTime? recDate, TransactionManager tm_ = null)
		{
			RepairRemoveByRecDateData(recDate.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByRecDateData(DateTime? recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (recDate.HasValue ? "`RecDate` = @RecDate" : "`RecDate` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (recDate.HasValue)
				paras_.Add(Database.CreateInParameter("@RecDate", recDate.Value, MySqlDbType.DateTime));
		}
		#endregion // RemoveByRecDate
		#region RemoveByUpdateTime
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "updateTime">修改时间</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByUpdateTime(DateTime? updateTime, TransactionManager tm_ = null)
		{
			RepairRemoveByUpdateTimeData(updateTime.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByUpdateTimeAsync(DateTime? updateTime, TransactionManager tm_ = null)
		{
			RepairRemoveByUpdateTimeData(updateTime.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByUpdateTimeData(DateTime? updateTime, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (updateTime.HasValue ? "`UpdateTime` = @UpdateTime" : "`UpdateTime` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (updateTime.HasValue)
				paras_.Add(Database.CreateInParameter("@UpdateTime", updateTime.Value, MySqlDbType.DateTime));
		}
		#endregion // RemoveByUpdateTime
		#region RemoveByState
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "state">是否删除0未删除1已删除</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByState(int state, TransactionManager tm_ = null)
		{
			RepairRemoveByStateData(state, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByStateAsync(int state, TransactionManager tm_ = null)
		{
			RepairRemoveByStateData(state, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByStateData(int state, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `State` = @State";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@State", state, MySqlDbType.Int32));
		}
		#endregion // RemoveByState
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
		public int Put(Sm_message_detailEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Sm_message_detailEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Sm_message_detailEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `DetailID` = @DetailID, `MessageID` = @MessageID, `UserID` = @UserID, `Flag` = @Flag, `State` = @State WHERE `DetailID` = @DetailID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", item.DetailID, MySqlDbType.VarChar),
				Database.CreateInParameter("@MessageID", item.MessageID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Flag", item.Flag, MySqlDbType.Int32),
				Database.CreateInParameter("@State", item.State, MySqlDbType.Int32),
				Database.CreateInParameter("@DetailID_Original", item.HasOriginal ? item.OriginalDetailID : item.DetailID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Sm_message_detailEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Sm_message_detailEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "detailID">编号</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string detailID, string set_, params object[] values_)
		{
			return Put(set_, "`DetailID` = @DetailID", ConcatValues(values_, detailID));
		}
		public async Task<int> PutByPKAsync(string detailID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`DetailID` = @DetailID", ConcatValues(values_, detailID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "detailID">编号</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string detailID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`DetailID` = @DetailID", tm_, ConcatValues(values_, detailID));
		}
		public async Task<int> PutByPKAsync(string detailID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`DetailID` = @DetailID", tm_, ConcatValues(values_, detailID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "detailID">编号</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string detailID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`DetailID` = @DetailID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string detailID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`DetailID` = @DetailID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutMessageID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID">编号</param>
		/// /// <param name = "messageID">邮件编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMessageIDByPK(string detailID, string messageID, TransactionManager tm_ = null)
		{
			RepairPutMessageIDByPKData(detailID, messageID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutMessageIDByPKAsync(string detailID, string messageID, TransactionManager tm_ = null)
		{
			RepairPutMessageIDByPKData(detailID, messageID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutMessageIDByPKData(string detailID, string messageID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `MessageID` = @MessageID  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "messageID">邮件编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMessageID(string messageID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MessageID` = @MessageID";
			var parameter_ = Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutMessageIDAsync(string messageID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MessageID` = @MessageID";
			var parameter_ = Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutMessageID
		#region PutUserID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID">编号</param>
		/// /// <param name = "userID">收件人</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserIDByPK(string detailID, string userID, TransactionManager tm_ = null)
		{
			RepairPutUserIDByPKData(detailID, userID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutUserIDByPKAsync(string detailID, string userID, TransactionManager tm_ = null)
		{
			RepairPutUserIDByPKData(detailID, userID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutUserIDByPKData(string detailID, string userID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UserID` = @UserID  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "userID">收件人</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserID(string userID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserID` = @UserID";
			var parameter_ = Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutUserIDAsync(string userID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserID` = @UserID";
			var parameter_ = Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutUserID
		#region PutFlag
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID">编号</param>
		/// /// <param name = "flag">0初始状态1已读未领奖励2已读已领取奖励3已读领取奖励失败</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFlagByPK(string detailID, int flag, TransactionManager tm_ = null)
		{
			RepairPutFlagByPKData(detailID, flag, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFlagByPKAsync(string detailID, int flag, TransactionManager tm_ = null)
		{
			RepairPutFlagByPKData(detailID, flag, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFlagByPKData(string detailID, int flag, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Flag` = @Flag  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Flag", flag, MySqlDbType.Int32),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "flag">0初始状态1已读未领奖励2已读已领取奖励3已读领取奖励失败</param>
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
		#region PutRecDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID">编号</param>
		/// /// <param name = "recDate">创建时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(string detailID, DateTime? recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(detailID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(string detailID, DateTime? recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(detailID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(string detailID, DateTime? recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate.HasValue ? recDate.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "recDate">创建时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDate(DateTime? recDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate";
			var parameter_ = Database.CreateInParameter("@RecDate", recDate.HasValue ? recDate.Value : (object)DBNull.Value, MySqlDbType.DateTime);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutRecDateAsync(DateTime? recDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate";
			var parameter_ = Database.CreateInParameter("@RecDate", recDate.HasValue ? recDate.Value : (object)DBNull.Value, MySqlDbType.DateTime);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutRecDate
		#region PutUpdateTime
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID">编号</param>
		/// /// <param name = "updateTime">修改时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUpdateTimeByPK(string detailID, DateTime? updateTime, TransactionManager tm_ = null)
		{
			RepairPutUpdateTimeByPKData(detailID, updateTime, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutUpdateTimeByPKAsync(string detailID, DateTime? updateTime, TransactionManager tm_ = null)
		{
			RepairPutUpdateTimeByPKData(detailID, updateTime, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutUpdateTimeByPKData(string detailID, DateTime? updateTime, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UpdateTime` = @UpdateTime  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UpdateTime", updateTime.HasValue ? updateTime.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "updateTime">修改时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUpdateTime(DateTime? updateTime, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UpdateTime` = @UpdateTime";
			var parameter_ = Database.CreateInParameter("@UpdateTime", updateTime.HasValue ? updateTime.Value : (object)DBNull.Value, MySqlDbType.DateTime);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutUpdateTimeAsync(DateTime? updateTime, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UpdateTime` = @UpdateTime";
			var parameter_ = Database.CreateInParameter("@UpdateTime", updateTime.HasValue ? updateTime.Value : (object)DBNull.Value, MySqlDbType.DateTime);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutUpdateTime
		#region PutState
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID">编号</param>
		/// /// <param name = "state">是否删除0未删除1已删除</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutStateByPK(string detailID, int state, TransactionManager tm_ = null)
		{
			RepairPutStateByPKData(detailID, state, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutStateByPKAsync(string detailID, int state, TransactionManager tm_ = null)
		{
			RepairPutStateByPKData(detailID, state, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutStateByPKData(string detailID, int state, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `State` = @State  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@State", state, MySqlDbType.Int32),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "state">是否删除0未删除1已删除</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutState(int state, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `State` = @State";
			var parameter_ = Database.CreateInParameter("@State", state, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutStateAsync(int state, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `State` = @State";
			var parameter_ = Database.CreateInParameter("@State", state, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutState
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Sm_message_detailEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.DetailID) == null)
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
		public async Task<bool> SetAsync(Sm_message_detailEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.DetailID) == null)
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
		/// /// <param name = "detailID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Sm_message_detailEO GetByPK(string detailID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(detailID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sm_message_detailEO.MapDataReader);
		}
		public async Task<Sm_message_detailEO> GetByPKAsync(string detailID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(detailID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sm_message_detailEO.MapDataReader);
		}
		private void RepairGetByPKData(string detailID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`DetailID` = @DetailID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 MessageID（字段）
		/// </summary>
		/// /// <param name = "detailID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetMessageIDByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`MessageID`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<string> GetMessageIDByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`MessageID`", "`DetailID` = @DetailID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 UserID（字段）
		/// </summary>
		/// /// <param name = "detailID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetUserIDByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`UserID`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<string> GetUserIDByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`UserID`", "`DetailID` = @DetailID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Flag（字段）
		/// </summary>
		/// /// <param name = "detailID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetFlagByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`Flag`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<int> GetFlagByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`Flag`", "`DetailID` = @DetailID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "detailID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime? GetRecDateByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (DateTime?)GetScalar("`RecDate`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<DateTime?> GetRecDateByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (DateTime?)await GetScalarAsync("`RecDate`", "`DetailID` = @DetailID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 UpdateTime（字段）
		/// </summary>
		/// /// <param name = "detailID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime? GetUpdateTimeByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (DateTime?)GetScalar("`UpdateTime`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<DateTime?> GetUpdateTimeByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (DateTime?)await GetScalarAsync("`UpdateTime`", "`DetailID` = @DetailID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 State（字段）
		/// </summary>
		/// /// <param name = "detailID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetStateByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`State`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<int> GetStateByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`State`", "`DetailID` = @DetailID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByMessageID
		
		/// <summary>
		/// 按 MessageID（字段） 查询
		/// </summary>
		/// /// <param name = "messageID">邮件编号</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_detailEO> GetByMessageID(string messageID)
		{
			return GetByMessageID(messageID, 0, string.Empty, null);
		}
		public async Task<List<Sm_message_detailEO>> GetByMessageIDAsync(string messageID)
		{
			return await GetByMessageIDAsync(messageID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MessageID（字段） 查询
		/// </summary>
		/// /// <param name = "messageID">邮件编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_detailEO> GetByMessageID(string messageID, TransactionManager tm_)
		{
			return GetByMessageID(messageID, 0, string.Empty, tm_);
		}
		public async Task<List<Sm_message_detailEO>> GetByMessageIDAsync(string messageID, TransactionManager tm_)
		{
			return await GetByMessageIDAsync(messageID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MessageID（字段） 查询
		/// </summary>
		/// /// <param name = "messageID">邮件编号</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_detailEO> GetByMessageID(string messageID, int top_)
		{
			return GetByMessageID(messageID, top_, string.Empty, null);
		}
		public async Task<List<Sm_message_detailEO>> GetByMessageIDAsync(string messageID, int top_)
		{
			return await GetByMessageIDAsync(messageID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MessageID（字段） 查询
		/// </summary>
		/// /// <param name = "messageID">邮件编号</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_detailEO> GetByMessageID(string messageID, int top_, TransactionManager tm_)
		{
			return GetByMessageID(messageID, top_, string.Empty, tm_);
		}
		public async Task<List<Sm_message_detailEO>> GetByMessageIDAsync(string messageID, int top_, TransactionManager tm_)
		{
			return await GetByMessageIDAsync(messageID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MessageID（字段） 查询
		/// </summary>
		/// /// <param name = "messageID">邮件编号</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_detailEO> GetByMessageID(string messageID, string sort_)
		{
			return GetByMessageID(messageID, 0, sort_, null);
		}
		public async Task<List<Sm_message_detailEO>> GetByMessageIDAsync(string messageID, string sort_)
		{
			return await GetByMessageIDAsync(messageID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 MessageID（字段） 查询
		/// </summary>
		/// /// <param name = "messageID">邮件编号</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_detailEO> GetByMessageID(string messageID, string sort_, TransactionManager tm_)
		{
			return GetByMessageID(messageID, 0, sort_, tm_);
		}
		public async Task<List<Sm_message_detailEO>> GetByMessageIDAsync(string messageID, string sort_, TransactionManager tm_)
		{
			return await GetByMessageIDAsync(messageID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 MessageID（字段） 查询
		/// </summary>
		/// /// <param name = "messageID">邮件编号</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_detailEO> GetByMessageID(string messageID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`MessageID` = @MessageID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sm_message_detailEO.MapDataReader);
		}
		public async Task<List<Sm_message_detailEO>> GetByMessageIDAsync(string messageID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`MessageID` = @MessageID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sm_message_detailEO.MapDataReader);
		}
		#endregion // GetByMessageID
		#region GetByUserID
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">收件人</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_detailEO> GetByUserID(string userID)
		{
			return GetByUserID(userID, 0, string.Empty, null);
		}
		public async Task<List<Sm_message_detailEO>> GetByUserIDAsync(string userID)
		{
			return await GetByUserIDAsync(userID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">收件人</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_detailEO> GetByUserID(string userID, TransactionManager tm_)
		{
			return GetByUserID(userID, 0, string.Empty, tm_);
		}
		public async Task<List<Sm_message_detailEO>> GetByUserIDAsync(string userID, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">收件人</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_detailEO> GetByUserID(string userID, int top_)
		{
			return GetByUserID(userID, top_, string.Empty, null);
		}
		public async Task<List<Sm_message_detailEO>> GetByUserIDAsync(string userID, int top_)
		{
			return await GetByUserIDAsync(userID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">收件人</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_detailEO> GetByUserID(string userID, int top_, TransactionManager tm_)
		{
			return GetByUserID(userID, top_, string.Empty, tm_);
		}
		public async Task<List<Sm_message_detailEO>> GetByUserIDAsync(string userID, int top_, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">收件人</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_detailEO> GetByUserID(string userID, string sort_)
		{
			return GetByUserID(userID, 0, sort_, null);
		}
		public async Task<List<Sm_message_detailEO>> GetByUserIDAsync(string userID, string sort_)
		{
			return await GetByUserIDAsync(userID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">收件人</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_detailEO> GetByUserID(string userID, string sort_, TransactionManager tm_)
		{
			return GetByUserID(userID, 0, sort_, tm_);
		}
		public async Task<List<Sm_message_detailEO>> GetByUserIDAsync(string userID, string sort_, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">收件人</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_detailEO> GetByUserID(string userID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserID` = @UserID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sm_message_detailEO.MapDataReader);
		}
		public async Task<List<Sm_message_detailEO>> GetByUserIDAsync(string userID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserID` = @UserID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sm_message_detailEO.MapDataReader);
		}
		#endregion // GetByUserID
		#region GetByFlag
		
		/// <summary>
		/// 按 Flag（字段） 查询
		/// </summary>
		/// /// <param name = "flag">0初始状态1已读未领奖励2已读已领取奖励3已读领取奖励失败</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_detailEO> GetByFlag(int flag)
		{
			return GetByFlag(flag, 0, string.Empty, null);
		}
		public async Task<List<Sm_message_detailEO>> GetByFlagAsync(int flag)
		{
			return await GetByFlagAsync(flag, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Flag（字段） 查询
		/// </summary>
		/// /// <param name = "flag">0初始状态1已读未领奖励2已读已领取奖励3已读领取奖励失败</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_detailEO> GetByFlag(int flag, TransactionManager tm_)
		{
			return GetByFlag(flag, 0, string.Empty, tm_);
		}
		public async Task<List<Sm_message_detailEO>> GetByFlagAsync(int flag, TransactionManager tm_)
		{
			return await GetByFlagAsync(flag, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Flag（字段） 查询
		/// </summary>
		/// /// <param name = "flag">0初始状态1已读未领奖励2已读已领取奖励3已读领取奖励失败</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_detailEO> GetByFlag(int flag, int top_)
		{
			return GetByFlag(flag, top_, string.Empty, null);
		}
		public async Task<List<Sm_message_detailEO>> GetByFlagAsync(int flag, int top_)
		{
			return await GetByFlagAsync(flag, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Flag（字段） 查询
		/// </summary>
		/// /// <param name = "flag">0初始状态1已读未领奖励2已读已领取奖励3已读领取奖励失败</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_detailEO> GetByFlag(int flag, int top_, TransactionManager tm_)
		{
			return GetByFlag(flag, top_, string.Empty, tm_);
		}
		public async Task<List<Sm_message_detailEO>> GetByFlagAsync(int flag, int top_, TransactionManager tm_)
		{
			return await GetByFlagAsync(flag, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Flag（字段） 查询
		/// </summary>
		/// /// <param name = "flag">0初始状态1已读未领奖励2已读已领取奖励3已读领取奖励失败</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_detailEO> GetByFlag(int flag, string sort_)
		{
			return GetByFlag(flag, 0, sort_, null);
		}
		public async Task<List<Sm_message_detailEO>> GetByFlagAsync(int flag, string sort_)
		{
			return await GetByFlagAsync(flag, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Flag（字段） 查询
		/// </summary>
		/// /// <param name = "flag">0初始状态1已读未领奖励2已读已领取奖励3已读领取奖励失败</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_detailEO> GetByFlag(int flag, string sort_, TransactionManager tm_)
		{
			return GetByFlag(flag, 0, sort_, tm_);
		}
		public async Task<List<Sm_message_detailEO>> GetByFlagAsync(int flag, string sort_, TransactionManager tm_)
		{
			return await GetByFlagAsync(flag, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Flag（字段） 查询
		/// </summary>
		/// /// <param name = "flag">0初始状态1已读未领奖励2已读已领取奖励3已读领取奖励失败</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_detailEO> GetByFlag(int flag, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Flag` = @Flag", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Flag", flag, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sm_message_detailEO.MapDataReader);
		}
		public async Task<List<Sm_message_detailEO>> GetByFlagAsync(int flag, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Flag` = @Flag", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Flag", flag, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sm_message_detailEO.MapDataReader);
		}
		#endregion // GetByFlag
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">创建时间</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_detailEO> GetByRecDate(DateTime? recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<Sm_message_detailEO>> GetByRecDateAsync(DateTime? recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">创建时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_detailEO> GetByRecDate(DateTime? recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<Sm_message_detailEO>> GetByRecDateAsync(DateTime? recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">创建时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_detailEO> GetByRecDate(DateTime? recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<Sm_message_detailEO>> GetByRecDateAsync(DateTime? recDate, int top_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">创建时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_detailEO> GetByRecDate(DateTime? recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<Sm_message_detailEO>> GetByRecDateAsync(DateTime? recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">创建时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_detailEO> GetByRecDate(DateTime? recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<Sm_message_detailEO>> GetByRecDateAsync(DateTime? recDate, string sort_)
		{
			return await GetByRecDateAsync(recDate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">创建时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_detailEO> GetByRecDate(DateTime? recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<Sm_message_detailEO>> GetByRecDateAsync(DateTime? recDate, string sort_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">创建时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_detailEO> GetByRecDate(DateTime? recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(recDate.HasValue ? "`RecDate` = @RecDate" : "`RecDate` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (recDate.HasValue)
				paras_.Add(Database.CreateInParameter("@RecDate", recDate.Value, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sm_message_detailEO.MapDataReader);
		}
		public async Task<List<Sm_message_detailEO>> GetByRecDateAsync(DateTime? recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(recDate.HasValue ? "`RecDate` = @RecDate" : "`RecDate` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (recDate.HasValue)
				paras_.Add(Database.CreateInParameter("@RecDate", recDate.Value, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sm_message_detailEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#region GetByUpdateTime
		
		/// <summary>
		/// 按 UpdateTime（字段） 查询
		/// </summary>
		/// /// <param name = "updateTime">修改时间</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_detailEO> GetByUpdateTime(DateTime? updateTime)
		{
			return GetByUpdateTime(updateTime, 0, string.Empty, null);
		}
		public async Task<List<Sm_message_detailEO>> GetByUpdateTimeAsync(DateTime? updateTime)
		{
			return await GetByUpdateTimeAsync(updateTime, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UpdateTime（字段） 查询
		/// </summary>
		/// /// <param name = "updateTime">修改时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_detailEO> GetByUpdateTime(DateTime? updateTime, TransactionManager tm_)
		{
			return GetByUpdateTime(updateTime, 0, string.Empty, tm_);
		}
		public async Task<List<Sm_message_detailEO>> GetByUpdateTimeAsync(DateTime? updateTime, TransactionManager tm_)
		{
			return await GetByUpdateTimeAsync(updateTime, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UpdateTime（字段） 查询
		/// </summary>
		/// /// <param name = "updateTime">修改时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_detailEO> GetByUpdateTime(DateTime? updateTime, int top_)
		{
			return GetByUpdateTime(updateTime, top_, string.Empty, null);
		}
		public async Task<List<Sm_message_detailEO>> GetByUpdateTimeAsync(DateTime? updateTime, int top_)
		{
			return await GetByUpdateTimeAsync(updateTime, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UpdateTime（字段） 查询
		/// </summary>
		/// /// <param name = "updateTime">修改时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_detailEO> GetByUpdateTime(DateTime? updateTime, int top_, TransactionManager tm_)
		{
			return GetByUpdateTime(updateTime, top_, string.Empty, tm_);
		}
		public async Task<List<Sm_message_detailEO>> GetByUpdateTimeAsync(DateTime? updateTime, int top_, TransactionManager tm_)
		{
			return await GetByUpdateTimeAsync(updateTime, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UpdateTime（字段） 查询
		/// </summary>
		/// /// <param name = "updateTime">修改时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_detailEO> GetByUpdateTime(DateTime? updateTime, string sort_)
		{
			return GetByUpdateTime(updateTime, 0, sort_, null);
		}
		public async Task<List<Sm_message_detailEO>> GetByUpdateTimeAsync(DateTime? updateTime, string sort_)
		{
			return await GetByUpdateTimeAsync(updateTime, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 UpdateTime（字段） 查询
		/// </summary>
		/// /// <param name = "updateTime">修改时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_detailEO> GetByUpdateTime(DateTime? updateTime, string sort_, TransactionManager tm_)
		{
			return GetByUpdateTime(updateTime, 0, sort_, tm_);
		}
		public async Task<List<Sm_message_detailEO>> GetByUpdateTimeAsync(DateTime? updateTime, string sort_, TransactionManager tm_)
		{
			return await GetByUpdateTimeAsync(updateTime, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 UpdateTime（字段） 查询
		/// </summary>
		/// /// <param name = "updateTime">修改时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_detailEO> GetByUpdateTime(DateTime? updateTime, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(updateTime.HasValue ? "`UpdateTime` = @UpdateTime" : "`UpdateTime` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (updateTime.HasValue)
				paras_.Add(Database.CreateInParameter("@UpdateTime", updateTime.Value, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sm_message_detailEO.MapDataReader);
		}
		public async Task<List<Sm_message_detailEO>> GetByUpdateTimeAsync(DateTime? updateTime, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(updateTime.HasValue ? "`UpdateTime` = @UpdateTime" : "`UpdateTime` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (updateTime.HasValue)
				paras_.Add(Database.CreateInParameter("@UpdateTime", updateTime.Value, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sm_message_detailEO.MapDataReader);
		}
		#endregion // GetByUpdateTime
		#region GetByState
		
		/// <summary>
		/// 按 State（字段） 查询
		/// </summary>
		/// /// <param name = "state">是否删除0未删除1已删除</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_detailEO> GetByState(int state)
		{
			return GetByState(state, 0, string.Empty, null);
		}
		public async Task<List<Sm_message_detailEO>> GetByStateAsync(int state)
		{
			return await GetByStateAsync(state, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 State（字段） 查询
		/// </summary>
		/// /// <param name = "state">是否删除0未删除1已删除</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_detailEO> GetByState(int state, TransactionManager tm_)
		{
			return GetByState(state, 0, string.Empty, tm_);
		}
		public async Task<List<Sm_message_detailEO>> GetByStateAsync(int state, TransactionManager tm_)
		{
			return await GetByStateAsync(state, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 State（字段） 查询
		/// </summary>
		/// /// <param name = "state">是否删除0未删除1已删除</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_detailEO> GetByState(int state, int top_)
		{
			return GetByState(state, top_, string.Empty, null);
		}
		public async Task<List<Sm_message_detailEO>> GetByStateAsync(int state, int top_)
		{
			return await GetByStateAsync(state, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 State（字段） 查询
		/// </summary>
		/// /// <param name = "state">是否删除0未删除1已删除</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_detailEO> GetByState(int state, int top_, TransactionManager tm_)
		{
			return GetByState(state, top_, string.Empty, tm_);
		}
		public async Task<List<Sm_message_detailEO>> GetByStateAsync(int state, int top_, TransactionManager tm_)
		{
			return await GetByStateAsync(state, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 State（字段） 查询
		/// </summary>
		/// /// <param name = "state">是否删除0未删除1已删除</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_detailEO> GetByState(int state, string sort_)
		{
			return GetByState(state, 0, sort_, null);
		}
		public async Task<List<Sm_message_detailEO>> GetByStateAsync(int state, string sort_)
		{
			return await GetByStateAsync(state, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 State（字段） 查询
		/// </summary>
		/// /// <param name = "state">是否删除0未删除1已删除</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_detailEO> GetByState(int state, string sort_, TransactionManager tm_)
		{
			return GetByState(state, 0, sort_, tm_);
		}
		public async Task<List<Sm_message_detailEO>> GetByStateAsync(int state, string sort_, TransactionManager tm_)
		{
			return await GetByStateAsync(state, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 State（字段） 查询
		/// </summary>
		/// /// <param name = "state">是否删除0未删除1已删除</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_message_detailEO> GetByState(int state, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`State` = @State", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@State", state, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sm_message_detailEO.MapDataReader);
		}
		public async Task<List<Sm_message_detailEO>> GetByStateAsync(int state, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`State` = @State", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@State", state, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sm_message_detailEO.MapDataReader);
		}
		#endregion // GetByState
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
