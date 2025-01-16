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
	/// 【表 sm_message 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Sm_messageEO : IRowMapper<Sm_messageEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Sm_messageEO()
		{
			this.MessageID = "0";
			this.Type = 0;
			this.State = 0;
			this.RecDate = DateTime.Now;
			this.UpdateTime = DateTime.Now;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private string _originalMessageID;
		/// <summary>
		/// 【数据库中的原始主键 MessageID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalMessageID
		{
			get { return _originalMessageID; }
			set { HasOriginal = true; _originalMessageID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "MessageID", MessageID }, };
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
		public string MessageID { get; set; }
		/// <summary>
		/// 发件人
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 2)]
		public string SenderID { get; set; }
		/// <summary>
		/// 邮件类型0系统消息1最新动态2奖励邮件3私信
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 3)]
		public int Type { get; set; }
		/// <summary>
		/// 是否删除0未删除1已删除
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 4)]
		public int State { get; set; }
		/// <summary>
		/// 创建日期
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 5)]
		public DateTime RecDate { get; set; }
		/// <summary>
		/// 修改时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 6)]
		public DateTime UpdateTime { get; set; }
		/// <summary>
		/// 奖励编号
		/// 【字段 varchar(36)】
		/// </summary>
		[DataMember(Order = 7)]
		public string RewardID { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Sm_messageEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Sm_messageEO MapDataReader(IDataReader reader)
		{
		    Sm_messageEO ret = new Sm_messageEO();
			ret.MessageID = reader.ToString("MessageID");
			ret.OriginalMessageID = ret.MessageID;
			ret.SenderID = reader.ToString("SenderID");
			ret.Type = reader.ToInt32("Type");
			ret.State = reader.ToInt32("State");
			ret.RecDate = reader.ToDateTime("RecDate");
			ret.UpdateTime = reader.ToDateTime("UpdateTime");
			ret.RewardID = reader.ToString("RewardID");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 
	/// 【表 sm_message 的操作类】
	/// </summary>
	[Obsolete]
	public class Sm_messageMO : MySqlTableMO<Sm_messageEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`sm_message`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Sm_messageMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Sm_messageMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Sm_messageMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Sm_messageEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Sm_messageEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Sm_messageEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`MessageID`, `SenderID`, `Type`, `State`, `RecDate`, `UpdateTime`, `RewardID`) VALUE (@MessageID, @SenderID, @Type, @State, @RecDate, @UpdateTime, @RewardID);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", item.MessageID, MySqlDbType.VarChar),
				Database.CreateInParameter("@SenderID", item.SenderID != null ? item.SenderID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Type", item.Type, MySqlDbType.Int32),
				Database.CreateInParameter("@State", item.State, MySqlDbType.Int32),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@UpdateTime", item.UpdateTime, MySqlDbType.DateTime),
				Database.CreateInParameter("@RewardID", item.RewardID != null ? item.RewardID : (object)DBNull.Value, MySqlDbType.VarChar),
			};
		}
		public int AddByBatch(IEnumerable<Sm_messageEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Sm_messageEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sm_messageEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`MessageID`, `SenderID`, `Type`, `State`, `RecDate`, `UpdateTime`, `RewardID`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.MessageID}','{item.SenderID}',{item.Type},{item.State},'{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}','{item.UpdateTime.ToString("yyyy-MM-dd HH:mm:ss")}','{item.RewardID}'),");
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
		/// /// <param name = "messageID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string messageID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(messageID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string messageID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(messageID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string messageID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `MessageID` = @MessageID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Sm_messageEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.MessageID, tm_);
		}
		public async Task<int> RemoveAsync(Sm_messageEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.MessageID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveBySenderID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "senderID">发件人</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveBySenderID(string senderID, TransactionManager tm_ = null)
		{
			RepairRemoveBySenderIDData(senderID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveBySenderIDAsync(string senderID, TransactionManager tm_ = null)
		{
			RepairRemoveBySenderIDData(senderID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveBySenderIDData(string senderID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (senderID != null ? "`SenderID` = @SenderID" : "`SenderID` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (senderID != null)
				paras_.Add(Database.CreateInParameter("@SenderID", senderID, MySqlDbType.VarChar));
		}
		#endregion // RemoveBySenderID
		#region RemoveByType
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "type">邮件类型0系统消息1最新动态2奖励邮件3私信</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByType(int type, TransactionManager tm_ = null)
		{
			RepairRemoveByTypeData(type, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTypeAsync(int type, TransactionManager tm_ = null)
		{
			RepairRemoveByTypeData(type, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTypeData(int type, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Type` = @Type";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Type", type, MySqlDbType.Int32));
		}
		#endregion // RemoveByType
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
		#region RemoveByRecDate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "recDate">创建日期</param>
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
		#region RemoveByUpdateTime
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "updateTime">修改时间</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByUpdateTime(DateTime updateTime, TransactionManager tm_ = null)
		{
			RepairRemoveByUpdateTimeData(updateTime, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByUpdateTimeAsync(DateTime updateTime, TransactionManager tm_ = null)
		{
			RepairRemoveByUpdateTimeData(updateTime, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByUpdateTimeData(DateTime updateTime, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `UpdateTime` = @UpdateTime";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UpdateTime", updateTime, MySqlDbType.DateTime));
		}
		#endregion // RemoveByUpdateTime
		#region RemoveByRewardID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "rewardID">奖励编号</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByRewardID(string rewardID, TransactionManager tm_ = null)
		{
			RepairRemoveByRewardIDData(rewardID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByRewardIDAsync(string rewardID, TransactionManager tm_ = null)
		{
			RepairRemoveByRewardIDData(rewardID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByRewardIDData(string rewardID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (rewardID != null ? "`RewardID` = @RewardID" : "`RewardID` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (rewardID != null)
				paras_.Add(Database.CreateInParameter("@RewardID", rewardID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByRewardID
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
		public int Put(Sm_messageEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Sm_messageEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Sm_messageEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `MessageID` = @MessageID, `SenderID` = @SenderID, `Type` = @Type, `State` = @State, `RewardID` = @RewardID WHERE `MessageID` = @MessageID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", item.MessageID, MySqlDbType.VarChar),
				Database.CreateInParameter("@SenderID", item.SenderID != null ? item.SenderID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Type", item.Type, MySqlDbType.Int32),
				Database.CreateInParameter("@State", item.State, MySqlDbType.Int32),
				Database.CreateInParameter("@RewardID", item.RewardID != null ? item.RewardID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@MessageID_Original", item.HasOriginal ? item.OriginalMessageID : item.MessageID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Sm_messageEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Sm_messageEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "messageID">编号</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string messageID, string set_, params object[] values_)
		{
			return Put(set_, "`MessageID` = @MessageID", ConcatValues(values_, messageID));
		}
		public async Task<int> PutByPKAsync(string messageID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`MessageID` = @MessageID", ConcatValues(values_, messageID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "messageID">编号</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string messageID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`MessageID` = @MessageID", tm_, ConcatValues(values_, messageID));
		}
		public async Task<int> PutByPKAsync(string messageID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`MessageID` = @MessageID", tm_, ConcatValues(values_, messageID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "messageID">编号</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string messageID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`MessageID` = @MessageID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string messageID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`MessageID` = @MessageID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutSenderID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "messageID">编号</param>
		/// /// <param name = "senderID">发件人</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSenderIDByPK(string messageID, string senderID, TransactionManager tm_ = null)
		{
			RepairPutSenderIDByPKData(messageID, senderID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutSenderIDByPKAsync(string messageID, string senderID, TransactionManager tm_ = null)
		{
			RepairPutSenderIDByPKData(messageID, senderID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutSenderIDByPKData(string messageID, string senderID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `SenderID` = @SenderID  WHERE `MessageID` = @MessageID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SenderID", senderID != null ? senderID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "senderID">发件人</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSenderID(string senderID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SenderID` = @SenderID";
			var parameter_ = Database.CreateInParameter("@SenderID", senderID != null ? senderID : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutSenderIDAsync(string senderID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SenderID` = @SenderID";
			var parameter_ = Database.CreateInParameter("@SenderID", senderID != null ? senderID : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutSenderID
		#region PutType
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "messageID">编号</param>
		/// /// <param name = "type">邮件类型0系统消息1最新动态2奖励邮件3私信</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTypeByPK(string messageID, int type, TransactionManager tm_ = null)
		{
			RepairPutTypeByPKData(messageID, type, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTypeByPKAsync(string messageID, int type, TransactionManager tm_ = null)
		{
			RepairPutTypeByPKData(messageID, type, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTypeByPKData(string messageID, int type, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Type` = @Type  WHERE `MessageID` = @MessageID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Type", type, MySqlDbType.Int32),
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "type">邮件类型0系统消息1最新动态2奖励邮件3私信</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutType(int type, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Type` = @Type";
			var parameter_ = Database.CreateInParameter("@Type", type, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTypeAsync(int type, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Type` = @Type";
			var parameter_ = Database.CreateInParameter("@Type", type, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutType
		#region PutState
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "messageID">编号</param>
		/// /// <param name = "state">是否删除0未删除1已删除</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutStateByPK(string messageID, int state, TransactionManager tm_ = null)
		{
			RepairPutStateByPKData(messageID, state, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutStateByPKAsync(string messageID, int state, TransactionManager tm_ = null)
		{
			RepairPutStateByPKData(messageID, state, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutStateByPKData(string messageID, int state, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `State` = @State  WHERE `MessageID` = @MessageID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@State", state, MySqlDbType.Int32),
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
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
		#region PutRecDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "messageID">编号</param>
		/// /// <param name = "recDate">创建日期</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(string messageID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(messageID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(string messageID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(messageID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(string messageID, DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `MessageID` = @MessageID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "recDate">创建日期</param>
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
		#region PutUpdateTime
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "messageID">编号</param>
		/// /// <param name = "updateTime">修改时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUpdateTimeByPK(string messageID, DateTime updateTime, TransactionManager tm_ = null)
		{
			RepairPutUpdateTimeByPKData(messageID, updateTime, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutUpdateTimeByPKAsync(string messageID, DateTime updateTime, TransactionManager tm_ = null)
		{
			RepairPutUpdateTimeByPKData(messageID, updateTime, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutUpdateTimeByPKData(string messageID, DateTime updateTime, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UpdateTime` = @UpdateTime  WHERE `MessageID` = @MessageID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UpdateTime", updateTime, MySqlDbType.DateTime),
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "updateTime">修改时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUpdateTime(DateTime updateTime, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UpdateTime` = @UpdateTime";
			var parameter_ = Database.CreateInParameter("@UpdateTime", updateTime, MySqlDbType.DateTime);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutUpdateTimeAsync(DateTime updateTime, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UpdateTime` = @UpdateTime";
			var parameter_ = Database.CreateInParameter("@UpdateTime", updateTime, MySqlDbType.DateTime);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutUpdateTime
		#region PutRewardID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "messageID">编号</param>
		/// /// <param name = "rewardID">奖励编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRewardIDByPK(string messageID, string rewardID, TransactionManager tm_ = null)
		{
			RepairPutRewardIDByPKData(messageID, rewardID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRewardIDByPKAsync(string messageID, string rewardID, TransactionManager tm_ = null)
		{
			RepairPutRewardIDByPKData(messageID, rewardID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRewardIDByPKData(string messageID, string rewardID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RewardID` = @RewardID  WHERE `MessageID` = @MessageID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RewardID", rewardID != null ? rewardID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "rewardID">奖励编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRewardID(string rewardID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RewardID` = @RewardID";
			var parameter_ = Database.CreateInParameter("@RewardID", rewardID != null ? rewardID : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutRewardIDAsync(string rewardID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RewardID` = @RewardID";
			var parameter_ = Database.CreateInParameter("@RewardID", rewardID != null ? rewardID : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutRewardID
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Sm_messageEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.MessageID) == null)
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
		public async Task<bool> SetAsync(Sm_messageEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.MessageID) == null)
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
		/// /// <param name = "messageID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Sm_messageEO GetByPK(string messageID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(messageID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sm_messageEO.MapDataReader);
		}
		public async Task<Sm_messageEO> GetByPKAsync(string messageID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(messageID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sm_messageEO.MapDataReader);
		}
		private void RepairGetByPKData(string messageID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`MessageID` = @MessageID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 SenderID（字段）
		/// </summary>
		/// /// <param name = "messageID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetSenderIDByPK(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`SenderID`", "`MessageID` = @MessageID", paras_, tm_);
		}
		public async Task<string> GetSenderIDByPKAsync(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`SenderID`", "`MessageID` = @MessageID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Type（字段）
		/// </summary>
		/// /// <param name = "messageID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetTypeByPK(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`Type`", "`MessageID` = @MessageID", paras_, tm_);
		}
		public async Task<int> GetTypeByPKAsync(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`Type`", "`MessageID` = @MessageID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 State（字段）
		/// </summary>
		/// /// <param name = "messageID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetStateByPK(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`State`", "`MessageID` = @MessageID", paras_, tm_);
		}
		public async Task<int> GetStateByPKAsync(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`State`", "`MessageID` = @MessageID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "messageID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetRecDateByPK(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`RecDate`", "`MessageID` = @MessageID", paras_, tm_);
		}
		public async Task<DateTime> GetRecDateByPKAsync(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`RecDate`", "`MessageID` = @MessageID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 UpdateTime（字段）
		/// </summary>
		/// /// <param name = "messageID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetUpdateTimeByPK(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`UpdateTime`", "`MessageID` = @MessageID", paras_, tm_);
		}
		public async Task<DateTime> GetUpdateTimeByPKAsync(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`UpdateTime`", "`MessageID` = @MessageID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RewardID（字段）
		/// </summary>
		/// /// <param name = "messageID">编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetRewardIDByPK(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`RewardID`", "`MessageID` = @MessageID", paras_, tm_);
		}
		public async Task<string> GetRewardIDByPKAsync(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`RewardID`", "`MessageID` = @MessageID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetBySenderID
		
		/// <summary>
		/// 按 SenderID（字段） 查询
		/// </summary>
		/// /// <param name = "senderID">发件人</param>
		/// <return>实体对象集合</return>
		public List<Sm_messageEO> GetBySenderID(string senderID)
		{
			return GetBySenderID(senderID, 0, string.Empty, null);
		}
		public async Task<List<Sm_messageEO>> GetBySenderIDAsync(string senderID)
		{
			return await GetBySenderIDAsync(senderID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SenderID（字段） 查询
		/// </summary>
		/// /// <param name = "senderID">发件人</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_messageEO> GetBySenderID(string senderID, TransactionManager tm_)
		{
			return GetBySenderID(senderID, 0, string.Empty, tm_);
		}
		public async Task<List<Sm_messageEO>> GetBySenderIDAsync(string senderID, TransactionManager tm_)
		{
			return await GetBySenderIDAsync(senderID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SenderID（字段） 查询
		/// </summary>
		/// /// <param name = "senderID">发件人</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sm_messageEO> GetBySenderID(string senderID, int top_)
		{
			return GetBySenderID(senderID, top_, string.Empty, null);
		}
		public async Task<List<Sm_messageEO>> GetBySenderIDAsync(string senderID, int top_)
		{
			return await GetBySenderIDAsync(senderID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SenderID（字段） 查询
		/// </summary>
		/// /// <param name = "senderID">发件人</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_messageEO> GetBySenderID(string senderID, int top_, TransactionManager tm_)
		{
			return GetBySenderID(senderID, top_, string.Empty, tm_);
		}
		public async Task<List<Sm_messageEO>> GetBySenderIDAsync(string senderID, int top_, TransactionManager tm_)
		{
			return await GetBySenderIDAsync(senderID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SenderID（字段） 查询
		/// </summary>
		/// /// <param name = "senderID">发件人</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sm_messageEO> GetBySenderID(string senderID, string sort_)
		{
			return GetBySenderID(senderID, 0, sort_, null);
		}
		public async Task<List<Sm_messageEO>> GetBySenderIDAsync(string senderID, string sort_)
		{
			return await GetBySenderIDAsync(senderID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 SenderID（字段） 查询
		/// </summary>
		/// /// <param name = "senderID">发件人</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_messageEO> GetBySenderID(string senderID, string sort_, TransactionManager tm_)
		{
			return GetBySenderID(senderID, 0, sort_, tm_);
		}
		public async Task<List<Sm_messageEO>> GetBySenderIDAsync(string senderID, string sort_, TransactionManager tm_)
		{
			return await GetBySenderIDAsync(senderID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 SenderID（字段） 查询
		/// </summary>
		/// /// <param name = "senderID">发件人</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_messageEO> GetBySenderID(string senderID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(senderID != null ? "`SenderID` = @SenderID" : "`SenderID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (senderID != null)
				paras_.Add(Database.CreateInParameter("@SenderID", senderID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sm_messageEO.MapDataReader);
		}
		public async Task<List<Sm_messageEO>> GetBySenderIDAsync(string senderID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(senderID != null ? "`SenderID` = @SenderID" : "`SenderID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (senderID != null)
				paras_.Add(Database.CreateInParameter("@SenderID", senderID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sm_messageEO.MapDataReader);
		}
		#endregion // GetBySenderID
		#region GetByType
		
		/// <summary>
		/// 按 Type（字段） 查询
		/// </summary>
		/// /// <param name = "type">邮件类型0系统消息1最新动态2奖励邮件3私信</param>
		/// <return>实体对象集合</return>
		public List<Sm_messageEO> GetByType(int type)
		{
			return GetByType(type, 0, string.Empty, null);
		}
		public async Task<List<Sm_messageEO>> GetByTypeAsync(int type)
		{
			return await GetByTypeAsync(type, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Type（字段） 查询
		/// </summary>
		/// /// <param name = "type">邮件类型0系统消息1最新动态2奖励邮件3私信</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_messageEO> GetByType(int type, TransactionManager tm_)
		{
			return GetByType(type, 0, string.Empty, tm_);
		}
		public async Task<List<Sm_messageEO>> GetByTypeAsync(int type, TransactionManager tm_)
		{
			return await GetByTypeAsync(type, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Type（字段） 查询
		/// </summary>
		/// /// <param name = "type">邮件类型0系统消息1最新动态2奖励邮件3私信</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sm_messageEO> GetByType(int type, int top_)
		{
			return GetByType(type, top_, string.Empty, null);
		}
		public async Task<List<Sm_messageEO>> GetByTypeAsync(int type, int top_)
		{
			return await GetByTypeAsync(type, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Type（字段） 查询
		/// </summary>
		/// /// <param name = "type">邮件类型0系统消息1最新动态2奖励邮件3私信</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_messageEO> GetByType(int type, int top_, TransactionManager tm_)
		{
			return GetByType(type, top_, string.Empty, tm_);
		}
		public async Task<List<Sm_messageEO>> GetByTypeAsync(int type, int top_, TransactionManager tm_)
		{
			return await GetByTypeAsync(type, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Type（字段） 查询
		/// </summary>
		/// /// <param name = "type">邮件类型0系统消息1最新动态2奖励邮件3私信</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sm_messageEO> GetByType(int type, string sort_)
		{
			return GetByType(type, 0, sort_, null);
		}
		public async Task<List<Sm_messageEO>> GetByTypeAsync(int type, string sort_)
		{
			return await GetByTypeAsync(type, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Type（字段） 查询
		/// </summary>
		/// /// <param name = "type">邮件类型0系统消息1最新动态2奖励邮件3私信</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_messageEO> GetByType(int type, string sort_, TransactionManager tm_)
		{
			return GetByType(type, 0, sort_, tm_);
		}
		public async Task<List<Sm_messageEO>> GetByTypeAsync(int type, string sort_, TransactionManager tm_)
		{
			return await GetByTypeAsync(type, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Type（字段） 查询
		/// </summary>
		/// /// <param name = "type">邮件类型0系统消息1最新动态2奖励邮件3私信</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_messageEO> GetByType(int type, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Type` = @Type", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Type", type, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sm_messageEO.MapDataReader);
		}
		public async Task<List<Sm_messageEO>> GetByTypeAsync(int type, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Type` = @Type", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Type", type, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sm_messageEO.MapDataReader);
		}
		#endregion // GetByType
		#region GetByState
		
		/// <summary>
		/// 按 State（字段） 查询
		/// </summary>
		/// /// <param name = "state">是否删除0未删除1已删除</param>
		/// <return>实体对象集合</return>
		public List<Sm_messageEO> GetByState(int state)
		{
			return GetByState(state, 0, string.Empty, null);
		}
		public async Task<List<Sm_messageEO>> GetByStateAsync(int state)
		{
			return await GetByStateAsync(state, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 State（字段） 查询
		/// </summary>
		/// /// <param name = "state">是否删除0未删除1已删除</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_messageEO> GetByState(int state, TransactionManager tm_)
		{
			return GetByState(state, 0, string.Empty, tm_);
		}
		public async Task<List<Sm_messageEO>> GetByStateAsync(int state, TransactionManager tm_)
		{
			return await GetByStateAsync(state, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 State（字段） 查询
		/// </summary>
		/// /// <param name = "state">是否删除0未删除1已删除</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sm_messageEO> GetByState(int state, int top_)
		{
			return GetByState(state, top_, string.Empty, null);
		}
		public async Task<List<Sm_messageEO>> GetByStateAsync(int state, int top_)
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
		public List<Sm_messageEO> GetByState(int state, int top_, TransactionManager tm_)
		{
			return GetByState(state, top_, string.Empty, tm_);
		}
		public async Task<List<Sm_messageEO>> GetByStateAsync(int state, int top_, TransactionManager tm_)
		{
			return await GetByStateAsync(state, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 State（字段） 查询
		/// </summary>
		/// /// <param name = "state">是否删除0未删除1已删除</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sm_messageEO> GetByState(int state, string sort_)
		{
			return GetByState(state, 0, sort_, null);
		}
		public async Task<List<Sm_messageEO>> GetByStateAsync(int state, string sort_)
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
		public List<Sm_messageEO> GetByState(int state, string sort_, TransactionManager tm_)
		{
			return GetByState(state, 0, sort_, tm_);
		}
		public async Task<List<Sm_messageEO>> GetByStateAsync(int state, string sort_, TransactionManager tm_)
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
		public List<Sm_messageEO> GetByState(int state, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`State` = @State", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@State", state, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sm_messageEO.MapDataReader);
		}
		public async Task<List<Sm_messageEO>> GetByStateAsync(int state, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`State` = @State", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@State", state, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sm_messageEO.MapDataReader);
		}
		#endregion // GetByState
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">创建日期</param>
		/// <return>实体对象集合</return>
		public List<Sm_messageEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<Sm_messageEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">创建日期</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_messageEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<Sm_messageEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">创建日期</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sm_messageEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<Sm_messageEO>> GetByRecDateAsync(DateTime recDate, int top_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">创建日期</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_messageEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<Sm_messageEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">创建日期</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sm_messageEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<Sm_messageEO>> GetByRecDateAsync(DateTime recDate, string sort_)
		{
			return await GetByRecDateAsync(recDate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">创建日期</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_messageEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<Sm_messageEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">创建日期</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_messageEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sm_messageEO.MapDataReader);
		}
		public async Task<List<Sm_messageEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sm_messageEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#region GetByUpdateTime
		
		/// <summary>
		/// 按 UpdateTime（字段） 查询
		/// </summary>
		/// /// <param name = "updateTime">修改时间</param>
		/// <return>实体对象集合</return>
		public List<Sm_messageEO> GetByUpdateTime(DateTime updateTime)
		{
			return GetByUpdateTime(updateTime, 0, string.Empty, null);
		}
		public async Task<List<Sm_messageEO>> GetByUpdateTimeAsync(DateTime updateTime)
		{
			return await GetByUpdateTimeAsync(updateTime, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UpdateTime（字段） 查询
		/// </summary>
		/// /// <param name = "updateTime">修改时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_messageEO> GetByUpdateTime(DateTime updateTime, TransactionManager tm_)
		{
			return GetByUpdateTime(updateTime, 0, string.Empty, tm_);
		}
		public async Task<List<Sm_messageEO>> GetByUpdateTimeAsync(DateTime updateTime, TransactionManager tm_)
		{
			return await GetByUpdateTimeAsync(updateTime, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UpdateTime（字段） 查询
		/// </summary>
		/// /// <param name = "updateTime">修改时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sm_messageEO> GetByUpdateTime(DateTime updateTime, int top_)
		{
			return GetByUpdateTime(updateTime, top_, string.Empty, null);
		}
		public async Task<List<Sm_messageEO>> GetByUpdateTimeAsync(DateTime updateTime, int top_)
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
		public List<Sm_messageEO> GetByUpdateTime(DateTime updateTime, int top_, TransactionManager tm_)
		{
			return GetByUpdateTime(updateTime, top_, string.Empty, tm_);
		}
		public async Task<List<Sm_messageEO>> GetByUpdateTimeAsync(DateTime updateTime, int top_, TransactionManager tm_)
		{
			return await GetByUpdateTimeAsync(updateTime, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UpdateTime（字段） 查询
		/// </summary>
		/// /// <param name = "updateTime">修改时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sm_messageEO> GetByUpdateTime(DateTime updateTime, string sort_)
		{
			return GetByUpdateTime(updateTime, 0, sort_, null);
		}
		public async Task<List<Sm_messageEO>> GetByUpdateTimeAsync(DateTime updateTime, string sort_)
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
		public List<Sm_messageEO> GetByUpdateTime(DateTime updateTime, string sort_, TransactionManager tm_)
		{
			return GetByUpdateTime(updateTime, 0, sort_, tm_);
		}
		public async Task<List<Sm_messageEO>> GetByUpdateTimeAsync(DateTime updateTime, string sort_, TransactionManager tm_)
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
		public List<Sm_messageEO> GetByUpdateTime(DateTime updateTime, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UpdateTime` = @UpdateTime", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UpdateTime", updateTime, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sm_messageEO.MapDataReader);
		}
		public async Task<List<Sm_messageEO>> GetByUpdateTimeAsync(DateTime updateTime, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UpdateTime` = @UpdateTime", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UpdateTime", updateTime, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sm_messageEO.MapDataReader);
		}
		#endregion // GetByUpdateTime
		#region GetByRewardID
		
		/// <summary>
		/// 按 RewardID（字段） 查询
		/// </summary>
		/// /// <param name = "rewardID">奖励编号</param>
		/// <return>实体对象集合</return>
		public List<Sm_messageEO> GetByRewardID(string rewardID)
		{
			return GetByRewardID(rewardID, 0, string.Empty, null);
		}
		public async Task<List<Sm_messageEO>> GetByRewardIDAsync(string rewardID)
		{
			return await GetByRewardIDAsync(rewardID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RewardID（字段） 查询
		/// </summary>
		/// /// <param name = "rewardID">奖励编号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_messageEO> GetByRewardID(string rewardID, TransactionManager tm_)
		{
			return GetByRewardID(rewardID, 0, string.Empty, tm_);
		}
		public async Task<List<Sm_messageEO>> GetByRewardIDAsync(string rewardID, TransactionManager tm_)
		{
			return await GetByRewardIDAsync(rewardID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RewardID（字段） 查询
		/// </summary>
		/// /// <param name = "rewardID">奖励编号</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sm_messageEO> GetByRewardID(string rewardID, int top_)
		{
			return GetByRewardID(rewardID, top_, string.Empty, null);
		}
		public async Task<List<Sm_messageEO>> GetByRewardIDAsync(string rewardID, int top_)
		{
			return await GetByRewardIDAsync(rewardID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RewardID（字段） 查询
		/// </summary>
		/// /// <param name = "rewardID">奖励编号</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_messageEO> GetByRewardID(string rewardID, int top_, TransactionManager tm_)
		{
			return GetByRewardID(rewardID, top_, string.Empty, tm_);
		}
		public async Task<List<Sm_messageEO>> GetByRewardIDAsync(string rewardID, int top_, TransactionManager tm_)
		{
			return await GetByRewardIDAsync(rewardID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RewardID（字段） 查询
		/// </summary>
		/// /// <param name = "rewardID">奖励编号</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sm_messageEO> GetByRewardID(string rewardID, string sort_)
		{
			return GetByRewardID(rewardID, 0, sort_, null);
		}
		public async Task<List<Sm_messageEO>> GetByRewardIDAsync(string rewardID, string sort_)
		{
			return await GetByRewardIDAsync(rewardID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RewardID（字段） 查询
		/// </summary>
		/// /// <param name = "rewardID">奖励编号</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_messageEO> GetByRewardID(string rewardID, string sort_, TransactionManager tm_)
		{
			return GetByRewardID(rewardID, 0, sort_, tm_);
		}
		public async Task<List<Sm_messageEO>> GetByRewardIDAsync(string rewardID, string sort_, TransactionManager tm_)
		{
			return await GetByRewardIDAsync(rewardID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RewardID（字段） 查询
		/// </summary>
		/// /// <param name = "rewardID">奖励编号</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sm_messageEO> GetByRewardID(string rewardID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(rewardID != null ? "`RewardID` = @RewardID" : "`RewardID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (rewardID != null)
				paras_.Add(Database.CreateInParameter("@RewardID", rewardID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sm_messageEO.MapDataReader);
		}
		public async Task<List<Sm_messageEO>> GetByRewardIDAsync(string rewardID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(rewardID != null ? "`RewardID` = @RewardID" : "`RewardID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (rewardID != null)
				paras_.Add(Database.CreateInParameter("@RewardID", rewardID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sm_messageEO.MapDataReader);
		}
		#endregion // GetByRewardID
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
