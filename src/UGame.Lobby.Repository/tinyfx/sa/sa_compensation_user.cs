/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * AiUo代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/AiUo
 * 文档生成时间：2023-11-09 18: 54:24
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
	/// 1.8包赔用户表
	/// 【表 sa_compensation_user 的实体类】
	/// </summary>
	[DataContract]
	public class Sa_compensation_userEO : IRowMapper<Sa_compensation_userEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Sa_compensation_userEO()
		{
			this.FirstDayPayAmount = 0;
			this.FirstDayLoseCashAmount = 0;
			this.FlowMultip = 1.00f;
			this.ReceiveStatus = false;
			this.RecDate = DateTime.Now;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private string _originalUserId;
		/// <summary>
		/// 【数据库中的原始主键 UserId 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalUserId
		{
			get { return _originalUserId; }
			set { HasOriginal = true; _originalUserId = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "UserId", UserId }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 用户编码
		/// 【主键 varchar(36)】
		/// </summary>
		[DataMember(Order = 1)]
		public string UserId { get; set; }
		/// <summary>
		/// 运营商编码
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 2)]
		public string OperatorID { get; set; }
		/// <summary>
		/// 货币类型
		/// 【字段 varchar(5)】
		/// </summary>
		[DataMember(Order = 3)]
		public string CurrencyID { get; set; }
		/// <summary>
		/// 对应的编码（根据FromMode变化）
		///                           FromMode=
		///                           0-运营商的新用户(s_operator)==> OperatorID
		///                           1-推广员获得的新用户（userid） ==> 邀请人的UserID
		///                           2-推广渠道通过url获得的新用户（s_channel_url) ==> CUrlID
		///                           3-推广渠道通过code获得的新用户（s_channel_code) ==> CCodeID
		/// 【字段 varchar(200)】
		/// </summary>
		[DataMember(Order = 4)]
		public string FromId { get; set; }
		/// <summary>
		/// 新用户来源方式
		///                           0-获得运营商的新用户(s_operator)
		///                           1-推广员获得的新用户（userid）
		///                           2-推广渠道通过url获得的新用户（s_channel_url)
		///                           3-推广渠道通过code获得的新用户（s_channel_code)
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 5)]
		public int FromMode { get; set; }
		/// <summary>
		/// 首日存款金额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 6)]
		public long FirstDayPayAmount { get; set; }
		/// <summary>
		/// 首日亏损金额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 7)]
		public long FirstDayLoseCashAmount { get; set; }
		/// <summary>
		/// 可领取奖金
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 8)]
		public long Bonus { get; set; }
		/// <summary>
		/// 流水倍数
		/// 【字段 float(10,2)】
		/// </summary>
		[DataMember(Order = 9)]
		public float FlowMultip { get; set; }
		/// <summary>
		/// bonus领取状态0-未领取1-已领取
		/// 【字段 tinyint(1)】
		/// </summary>
		[DataMember(Order = 10)]
		public bool ReceiveStatus { get; set; }
		/// <summary>
		/// 购买时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 11)]
		public DateTime RecDate { get; set; }
		/// <summary>
		/// 领取时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 12)]
		public DateTime? ReceiveDate { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Sa_compensation_userEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Sa_compensation_userEO MapDataReader(IDataReader reader)
		{
		    Sa_compensation_userEO ret = new Sa_compensation_userEO();
			ret.UserId = reader.ToString("UserId");
			ret.OriginalUserId = ret.UserId;
			ret.OperatorID = reader.ToString("OperatorID");
			ret.CurrencyID = reader.ToString("CurrencyID");
			ret.FromId = reader.ToString("FromId");
			ret.FromMode = reader.ToInt32("FromMode");
			ret.FirstDayPayAmount = reader.ToInt64("FirstDayPayAmount");
			ret.FirstDayLoseCashAmount = reader.ToInt64("FirstDayLoseCashAmount");
			ret.Bonus = reader.ToInt64("Bonus");
			ret.FlowMultip = reader.ToSingle("FlowMultip");
			ret.ReceiveStatus = reader.ToBoolean("ReceiveStatus");
			ret.RecDate = reader.ToDateTime("RecDate");
			ret.ReceiveDate = reader.ToDateTimeN("ReceiveDate");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 1.8包赔用户表
	/// 【表 sa_compensation_user 的操作类】
	/// </summary>
	public class Sa_compensation_userMO : MySqlTableMO<Sa_compensation_userEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`sa_compensation_user`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Sa_compensation_userMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Sa_compensation_userMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Sa_compensation_userMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Sa_compensation_userEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Sa_compensation_userEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Sa_compensation_userEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`UserId`, `OperatorID`, `CurrencyID`, `FromId`, `FromMode`, `FirstDayPayAmount`, `FirstDayLoseCashAmount`, `Bonus`, `FlowMultip`, `ReceiveStatus`, `RecDate`, `ReceiveDate`) VALUE (@UserId, @OperatorID, @CurrencyID, @FromId, @FromMode, @FirstDayPayAmount, @FirstDayLoseCashAmount, @Bonus, @FlowMultip, @ReceiveStatus, @RecDate, @ReceiveDate);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserId", item.UserId, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@FromId", item.FromId, MySqlDbType.VarChar),
				Database.CreateInParameter("@FromMode", item.FromMode, MySqlDbType.Int32),
				Database.CreateInParameter("@FirstDayPayAmount", item.FirstDayPayAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@FirstDayLoseCashAmount", item.FirstDayLoseCashAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@Bonus", item.Bonus, MySqlDbType.Int64),
				Database.CreateInParameter("@FlowMultip", item.FlowMultip, MySqlDbType.Float),
				Database.CreateInParameter("@ReceiveStatus", item.ReceiveStatus, MySqlDbType.Byte),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@ReceiveDate", item.ReceiveDate.HasValue ? item.ReceiveDate.Value : (object)DBNull.Value, MySqlDbType.DateTime),
			};
		}
		public int AddByBatch(IEnumerable<Sa_compensation_userEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Sa_compensation_userEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sa_compensation_userEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`UserId`, `OperatorID`, `CurrencyID`, `FromId`, `FromMode`, `FirstDayPayAmount`, `FirstDayLoseCashAmount`, `Bonus`, `FlowMultip`, `ReceiveStatus`, `RecDate`, `ReceiveDate`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.UserId}','{item.OperatorID}','{item.CurrencyID}','{item.FromId}',{item.FromMode},{item.FirstDayPayAmount},{item.FirstDayLoseCashAmount},{item.Bonus},{item.FlowMultip},{item.ReceiveStatus},'{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}','{item.ReceiveDate?.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
		/// /// <param name = "userId">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string userId, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(userId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string userId, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(userId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string userId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `UserId` = @UserId";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Sa_compensation_userEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.UserId, tm_);
		}
		public async Task<int> RemoveAsync(Sa_compensation_userEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.UserId, tm_);
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
			sql_ = $"DELETE FROM {TableName} WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByOperatorID
		#region RemoveByCurrencyID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCurrencyID(string currencyID, TransactionManager tm_ = null)
		{
			RepairRemoveByCurrencyIDData(currencyID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCurrencyIDAsync(string currencyID, TransactionManager tm_ = null)
		{
			RepairRemoveByCurrencyIDData(currencyID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCurrencyIDData(string currencyID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByCurrencyID
		#region RemoveByFromId
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByFromId(string fromId, TransactionManager tm_ = null)
		{
			RepairRemoveByFromIdData(fromId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByFromIdAsync(string fromId, TransactionManager tm_ = null)
		{
			RepairRemoveByFromIdData(fromId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByFromIdData(string fromId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `FromId` = @FromId";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FromId", fromId, MySqlDbType.VarChar));
		}
		#endregion // RemoveByFromId
		#region RemoveByFromMode
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByFromMode(int fromMode, TransactionManager tm_ = null)
		{
			RepairRemoveByFromModeData(fromMode, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByFromModeAsync(int fromMode, TransactionManager tm_ = null)
		{
			RepairRemoveByFromModeData(fromMode, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByFromModeData(int fromMode, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `FromMode` = @FromMode";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FromMode", fromMode, MySqlDbType.Int32));
		}
		#endregion // RemoveByFromMode
		#region RemoveByFirstDayPayAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "firstDayPayAmount">首日存款金额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByFirstDayPayAmount(long firstDayPayAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByFirstDayPayAmountData(firstDayPayAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByFirstDayPayAmountAsync(long firstDayPayAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByFirstDayPayAmountData(firstDayPayAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByFirstDayPayAmountData(long firstDayPayAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `FirstDayPayAmount` = @FirstDayPayAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FirstDayPayAmount", firstDayPayAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByFirstDayPayAmount
		#region RemoveByFirstDayLoseCashAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "firstDayLoseCashAmount">首日亏损金额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByFirstDayLoseCashAmount(long firstDayLoseCashAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByFirstDayLoseCashAmountData(firstDayLoseCashAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByFirstDayLoseCashAmountAsync(long firstDayLoseCashAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByFirstDayLoseCashAmountData(firstDayLoseCashAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByFirstDayLoseCashAmountData(long firstDayLoseCashAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `FirstDayLoseCashAmount` = @FirstDayLoseCashAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FirstDayLoseCashAmount", firstDayLoseCashAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByFirstDayLoseCashAmount
		#region RemoveByBonus
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "bonus">可领取奖金</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByBonus(long bonus, TransactionManager tm_ = null)
		{
			RepairRemoveByBonusData(bonus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByBonusAsync(long bonus, TransactionManager tm_ = null)
		{
			RepairRemoveByBonusData(bonus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByBonusData(long bonus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Bonus` = @Bonus";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Bonus", bonus, MySqlDbType.Int64));
		}
		#endregion // RemoveByBonus
		#region RemoveByFlowMultip
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "flowMultip">流水倍数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByFlowMultip(float flowMultip, TransactionManager tm_ = null)
		{
			RepairRemoveByFlowMultipData(flowMultip, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByFlowMultipAsync(float flowMultip, TransactionManager tm_ = null)
		{
			RepairRemoveByFlowMultipData(flowMultip, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByFlowMultipData(float flowMultip, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `FlowMultip` = @FlowMultip";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FlowMultip", flowMultip, MySqlDbType.Float));
		}
		#endregion // RemoveByFlowMultip
		#region RemoveByReceiveStatus
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "receiveStatus">bonus领取状态0-未领取1-已领取</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByReceiveStatus(bool receiveStatus, TransactionManager tm_ = null)
		{
			RepairRemoveByReceiveStatusData(receiveStatus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByReceiveStatusAsync(bool receiveStatus, TransactionManager tm_ = null)
		{
			RepairRemoveByReceiveStatusData(receiveStatus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByReceiveStatusData(bool receiveStatus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `ReceiveStatus` = @ReceiveStatus";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ReceiveStatus", receiveStatus, MySqlDbType.Byte));
		}
		#endregion // RemoveByReceiveStatus
		#region RemoveByRecDate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "recDate">购买时间</param>
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
		#region RemoveByReceiveDate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "receiveDate">领取时间</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByReceiveDate(DateTime? receiveDate, TransactionManager tm_ = null)
		{
			RepairRemoveByReceiveDateData(receiveDate.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByReceiveDateAsync(DateTime? receiveDate, TransactionManager tm_ = null)
		{
			RepairRemoveByReceiveDateData(receiveDate.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByReceiveDateData(DateTime? receiveDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (receiveDate.HasValue ? "`ReceiveDate` = @ReceiveDate" : "`ReceiveDate` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (receiveDate.HasValue)
				paras_.Add(Database.CreateInParameter("@ReceiveDate", receiveDate.Value, MySqlDbType.DateTime));
		}
		#endregion // RemoveByReceiveDate
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
		public int Put(Sa_compensation_userEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Sa_compensation_userEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Sa_compensation_userEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UserId` = @UserId, `OperatorID` = @OperatorID, `CurrencyID` = @CurrencyID, `FromId` = @FromId, `FromMode` = @FromMode, `FirstDayPayAmount` = @FirstDayPayAmount, `FirstDayLoseCashAmount` = @FirstDayLoseCashAmount, `Bonus` = @Bonus, `FlowMultip` = @FlowMultip, `ReceiveStatus` = @ReceiveStatus, `ReceiveDate` = @ReceiveDate WHERE `UserId` = @UserId_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserId", item.UserId, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@FromId", item.FromId, MySqlDbType.VarChar),
				Database.CreateInParameter("@FromMode", item.FromMode, MySqlDbType.Int32),
				Database.CreateInParameter("@FirstDayPayAmount", item.FirstDayPayAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@FirstDayLoseCashAmount", item.FirstDayLoseCashAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@Bonus", item.Bonus, MySqlDbType.Int64),
				Database.CreateInParameter("@FlowMultip", item.FlowMultip, MySqlDbType.Float),
				Database.CreateInParameter("@ReceiveStatus", item.ReceiveStatus, MySqlDbType.Byte),
				Database.CreateInParameter("@ReceiveDate", item.ReceiveDate.HasValue ? item.ReceiveDate.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@UserId_Original", item.HasOriginal ? item.OriginalUserId : item.UserId, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Sa_compensation_userEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Sa_compensation_userEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "userId">用户编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string userId, string set_, params object[] values_)
		{
			return Put(set_, "`UserId` = @UserId", ConcatValues(values_, userId));
		}
		public async Task<int> PutByPKAsync(string userId, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`UserId` = @UserId", ConcatValues(values_, userId));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "userId">用户编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string userId, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`UserId` = @UserId", tm_, ConcatValues(values_, userId));
		}
		public async Task<int> PutByPKAsync(string userId, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`UserId` = @UserId", tm_, ConcatValues(values_, userId));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "userId">用户编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string userId, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
	        };
			return Put(set_, "`UserId` = @UserId", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string userId, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`UserId` = @UserId", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutOperatorID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userId">用户编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorIDByPK(string userId, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(userId, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOperatorIDByPKAsync(string userId, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(userId, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOperatorIDByPKData(string userId, string operatorID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID  WHERE `UserId` = @UserId";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
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
		#region PutCurrencyID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userId">用户编码</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCurrencyIDByPK(string userId, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(userId, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCurrencyIDByPKAsync(string userId, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(userId, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCurrencyIDByPKData(string userId, string currencyID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CurrencyID` = @CurrencyID  WHERE `UserId` = @UserId";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCurrencyID(string currencyID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CurrencyID` = @CurrencyID";
			var parameter_ = Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCurrencyIDAsync(string currencyID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CurrencyID` = @CurrencyID";
			var parameter_ = Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCurrencyID
		#region PutFromId
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userId">用户编码</param>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFromIdByPK(string userId, string fromId, TransactionManager tm_ = null)
		{
			RepairPutFromIdByPKData(userId, fromId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFromIdByPKAsync(string userId, string fromId, TransactionManager tm_ = null)
		{
			RepairPutFromIdByPKData(userId, fromId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFromIdByPKData(string userId, string fromId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `FromId` = @FromId  WHERE `UserId` = @UserId";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@FromId", fromId, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFromId(string fromId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FromId` = @FromId";
			var parameter_ = Database.CreateInParameter("@FromId", fromId, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutFromIdAsync(string fromId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FromId` = @FromId";
			var parameter_ = Database.CreateInParameter("@FromId", fromId, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutFromId
		#region PutFromMode
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userId">用户编码</param>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFromModeByPK(string userId, int fromMode, TransactionManager tm_ = null)
		{
			RepairPutFromModeByPKData(userId, fromMode, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFromModeByPKAsync(string userId, int fromMode, TransactionManager tm_ = null)
		{
			RepairPutFromModeByPKData(userId, fromMode, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFromModeByPKData(string userId, int fromMode, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `FromMode` = @FromMode  WHERE `UserId` = @UserId";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@FromMode", fromMode, MySqlDbType.Int32),
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFromMode(int fromMode, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FromMode` = @FromMode";
			var parameter_ = Database.CreateInParameter("@FromMode", fromMode, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutFromModeAsync(int fromMode, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FromMode` = @FromMode";
			var parameter_ = Database.CreateInParameter("@FromMode", fromMode, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutFromMode
		#region PutFirstDayPayAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userId">用户编码</param>
		/// /// <param name = "firstDayPayAmount">首日存款金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFirstDayPayAmountByPK(string userId, long firstDayPayAmount, TransactionManager tm_ = null)
		{
			RepairPutFirstDayPayAmountByPKData(userId, firstDayPayAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFirstDayPayAmountByPKAsync(string userId, long firstDayPayAmount, TransactionManager tm_ = null)
		{
			RepairPutFirstDayPayAmountByPKData(userId, firstDayPayAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFirstDayPayAmountByPKData(string userId, long firstDayPayAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `FirstDayPayAmount` = @FirstDayPayAmount  WHERE `UserId` = @UserId";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@FirstDayPayAmount", firstDayPayAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "firstDayPayAmount">首日存款金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFirstDayPayAmount(long firstDayPayAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FirstDayPayAmount` = @FirstDayPayAmount";
			var parameter_ = Database.CreateInParameter("@FirstDayPayAmount", firstDayPayAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutFirstDayPayAmountAsync(long firstDayPayAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FirstDayPayAmount` = @FirstDayPayAmount";
			var parameter_ = Database.CreateInParameter("@FirstDayPayAmount", firstDayPayAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutFirstDayPayAmount
		#region PutFirstDayLoseCashAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userId">用户编码</param>
		/// /// <param name = "firstDayLoseCashAmount">首日亏损金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFirstDayLoseCashAmountByPK(string userId, long firstDayLoseCashAmount, TransactionManager tm_ = null)
		{
			RepairPutFirstDayLoseCashAmountByPKData(userId, firstDayLoseCashAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFirstDayLoseCashAmountByPKAsync(string userId, long firstDayLoseCashAmount, TransactionManager tm_ = null)
		{
			RepairPutFirstDayLoseCashAmountByPKData(userId, firstDayLoseCashAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFirstDayLoseCashAmountByPKData(string userId, long firstDayLoseCashAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `FirstDayLoseCashAmount` = @FirstDayLoseCashAmount  WHERE `UserId` = @UserId";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@FirstDayLoseCashAmount", firstDayLoseCashAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "firstDayLoseCashAmount">首日亏损金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFirstDayLoseCashAmount(long firstDayLoseCashAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FirstDayLoseCashAmount` = @FirstDayLoseCashAmount";
			var parameter_ = Database.CreateInParameter("@FirstDayLoseCashAmount", firstDayLoseCashAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutFirstDayLoseCashAmountAsync(long firstDayLoseCashAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FirstDayLoseCashAmount` = @FirstDayLoseCashAmount";
			var parameter_ = Database.CreateInParameter("@FirstDayLoseCashAmount", firstDayLoseCashAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutFirstDayLoseCashAmount
		#region PutBonus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userId">用户编码</param>
		/// /// <param name = "bonus">可领取奖金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBonusByPK(string userId, long bonus, TransactionManager tm_ = null)
		{
			RepairPutBonusByPKData(userId, bonus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBonusByPKAsync(string userId, long bonus, TransactionManager tm_ = null)
		{
			RepairPutBonusByPKData(userId, bonus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBonusByPKData(string userId, long bonus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Bonus` = @Bonus  WHERE `UserId` = @UserId";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Bonus", bonus, MySqlDbType.Int64),
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "bonus">可领取奖金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBonus(long bonus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Bonus` = @Bonus";
			var parameter_ = Database.CreateInParameter("@Bonus", bonus, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutBonusAsync(long bonus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Bonus` = @Bonus";
			var parameter_ = Database.CreateInParameter("@Bonus", bonus, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutBonus
		#region PutFlowMultip
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userId">用户编码</param>
		/// /// <param name = "flowMultip">流水倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFlowMultipByPK(string userId, float flowMultip, TransactionManager tm_ = null)
		{
			RepairPutFlowMultipByPKData(userId, flowMultip, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFlowMultipByPKAsync(string userId, float flowMultip, TransactionManager tm_ = null)
		{
			RepairPutFlowMultipByPKData(userId, flowMultip, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFlowMultipByPKData(string userId, float flowMultip, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `FlowMultip` = @FlowMultip  WHERE `UserId` = @UserId";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@FlowMultip", flowMultip, MySqlDbType.Float),
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "flowMultip">流水倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFlowMultip(float flowMultip, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FlowMultip` = @FlowMultip";
			var parameter_ = Database.CreateInParameter("@FlowMultip", flowMultip, MySqlDbType.Float);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutFlowMultipAsync(float flowMultip, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FlowMultip` = @FlowMultip";
			var parameter_ = Database.CreateInParameter("@FlowMultip", flowMultip, MySqlDbType.Float);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutFlowMultip
		#region PutReceiveStatus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userId">用户编码</param>
		/// /// <param name = "receiveStatus">bonus领取状态0-未领取1-已领取</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutReceiveStatusByPK(string userId, bool receiveStatus, TransactionManager tm_ = null)
		{
			RepairPutReceiveStatusByPKData(userId, receiveStatus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutReceiveStatusByPKAsync(string userId, bool receiveStatus, TransactionManager tm_ = null)
		{
			RepairPutReceiveStatusByPKData(userId, receiveStatus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutReceiveStatusByPKData(string userId, bool receiveStatus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ReceiveStatus` = @ReceiveStatus  WHERE `UserId` = @UserId";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ReceiveStatus", receiveStatus, MySqlDbType.Byte),
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "receiveStatus">bonus领取状态0-未领取1-已领取</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutReceiveStatus(bool receiveStatus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ReceiveStatus` = @ReceiveStatus";
			var parameter_ = Database.CreateInParameter("@ReceiveStatus", receiveStatus, MySqlDbType.Byte);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutReceiveStatusAsync(bool receiveStatus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ReceiveStatus` = @ReceiveStatus";
			var parameter_ = Database.CreateInParameter("@ReceiveStatus", receiveStatus, MySqlDbType.Byte);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutReceiveStatus
		#region PutRecDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userId">用户编码</param>
		/// /// <param name = "recDate">购买时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(string userId, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(userId, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(string userId, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(userId, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(string userId, DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `UserId` = @UserId";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "recDate">购买时间</param>
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
		#region PutReceiveDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userId">用户编码</param>
		/// /// <param name = "receiveDate">领取时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutReceiveDateByPK(string userId, DateTime? receiveDate, TransactionManager tm_ = null)
		{
			RepairPutReceiveDateByPKData(userId, receiveDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutReceiveDateByPKAsync(string userId, DateTime? receiveDate, TransactionManager tm_ = null)
		{
			RepairPutReceiveDateByPKData(userId, receiveDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutReceiveDateByPKData(string userId, DateTime? receiveDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ReceiveDate` = @ReceiveDate  WHERE `UserId` = @UserId";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ReceiveDate", receiveDate.HasValue ? receiveDate.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "receiveDate">领取时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutReceiveDate(DateTime? receiveDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ReceiveDate` = @ReceiveDate";
			var parameter_ = Database.CreateInParameter("@ReceiveDate", receiveDate.HasValue ? receiveDate.Value : (object)DBNull.Value, MySqlDbType.DateTime);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutReceiveDateAsync(DateTime? receiveDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ReceiveDate` = @ReceiveDate";
			var parameter_ = Database.CreateInParameter("@ReceiveDate", receiveDate.HasValue ? receiveDate.Value : (object)DBNull.Value, MySqlDbType.DateTime);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutReceiveDate
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Sa_compensation_userEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.UserId) == null)
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
		public async Task<bool> SetAsync(Sa_compensation_userEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.UserId) == null)
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
		/// /// <param name = "userId">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Sa_compensation_userEO GetByPK(string userId, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(userId, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sa_compensation_userEO.MapDataReader);
		}
		public async Task<Sa_compensation_userEO> GetByPKAsync(string userId, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(userId, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sa_compensation_userEO.MapDataReader);
		}
		private void RepairGetByPKData(string userId, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`UserId` = @UserId", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 OperatorID（字段）
		/// </summary>
		/// /// <param name = "userId">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorIDByPK(string userId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OperatorID`", "`UserId` = @UserId", paras_, tm_);
		}
		public async Task<string> GetOperatorIDByPKAsync(string userId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OperatorID`", "`UserId` = @UserId", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CurrencyID（字段）
		/// </summary>
		/// /// <param name = "userId">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCurrencyIDByPK(string userId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CurrencyID`", "`UserId` = @UserId", paras_, tm_);
		}
		public async Task<string> GetCurrencyIDByPKAsync(string userId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CurrencyID`", "`UserId` = @UserId", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 FromId（字段）
		/// </summary>
		/// /// <param name = "userId">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetFromIdByPK(string userId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`FromId`", "`UserId` = @UserId", paras_, tm_);
		}
		public async Task<string> GetFromIdByPKAsync(string userId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`FromId`", "`UserId` = @UserId", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 FromMode（字段）
		/// </summary>
		/// /// <param name = "userId">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetFromModeByPK(string userId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`FromMode`", "`UserId` = @UserId", paras_, tm_);
		}
		public async Task<int> GetFromModeByPKAsync(string userId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`FromMode`", "`UserId` = @UserId", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 FirstDayPayAmount（字段）
		/// </summary>
		/// /// <param name = "userId">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetFirstDayPayAmountByPK(string userId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`FirstDayPayAmount`", "`UserId` = @UserId", paras_, tm_);
		}
		public async Task<long> GetFirstDayPayAmountByPKAsync(string userId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`FirstDayPayAmount`", "`UserId` = @UserId", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 FirstDayLoseCashAmount（字段）
		/// </summary>
		/// /// <param name = "userId">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetFirstDayLoseCashAmountByPK(string userId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`FirstDayLoseCashAmount`", "`UserId` = @UserId", paras_, tm_);
		}
		public async Task<long> GetFirstDayLoseCashAmountByPKAsync(string userId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`FirstDayLoseCashAmount`", "`UserId` = @UserId", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Bonus（字段）
		/// </summary>
		/// /// <param name = "userId">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetBonusByPK(string userId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`Bonus`", "`UserId` = @UserId", paras_, tm_);
		}
		public async Task<long> GetBonusByPKAsync(string userId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`Bonus`", "`UserId` = @UserId", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 FlowMultip（字段）
		/// </summary>
		/// /// <param name = "userId">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public float GetFlowMultipByPK(string userId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
			return (float)GetScalar("`FlowMultip`", "`UserId` = @UserId", paras_, tm_);
		}
		public async Task<float> GetFlowMultipByPKAsync(string userId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
			return (float)await GetScalarAsync("`FlowMultip`", "`UserId` = @UserId", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ReceiveStatus（字段）
		/// </summary>
		/// /// <param name = "userId">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public bool GetReceiveStatusByPK(string userId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
			return (bool)GetScalar("`ReceiveStatus`", "`UserId` = @UserId", paras_, tm_);
		}
		public async Task<bool> GetReceiveStatusByPKAsync(string userId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
			return (bool)await GetScalarAsync("`ReceiveStatus`", "`UserId` = @UserId", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "userId">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetRecDateByPK(string userId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`RecDate`", "`UserId` = @UserId", paras_, tm_);
		}
		public async Task<DateTime> GetRecDateByPKAsync(string userId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`RecDate`", "`UserId` = @UserId", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ReceiveDate（字段）
		/// </summary>
		/// /// <param name = "userId">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime? GetReceiveDateByPK(string userId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
			return (DateTime?)GetScalar("`ReceiveDate`", "`UserId` = @UserId", paras_, tm_);
		}
		public async Task<DateTime?> GetReceiveDateByPKAsync(string userId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
			return (DateTime?)await GetScalarAsync("`ReceiveDate`", "`UserId` = @UserId", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<Sa_compensation_userEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_compensation_userEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<Sa_compensation_userEO>> GetByOperatorIDAsync(string operatorID, int top_)
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
		public List<Sa_compensation_userEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_compensation_userEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<Sa_compensation_userEO>> GetByOperatorIDAsync(string operatorID, string sort_)
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
		public List<Sa_compensation_userEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<Sa_compensation_userEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
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
		public List<Sa_compensation_userEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_compensation_userEO.MapDataReader);
		}
		public async Task<List<Sa_compensation_userEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_compensation_userEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByCurrencyID
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByCurrencyID(string currencyID)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, null);
		}
		public async Task<List<Sa_compensation_userEO>> GetByCurrencyIDAsync(string currencyID)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByCurrencyID(string currencyID, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_compensation_userEO>> GetByCurrencyIDAsync(string currencyID, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByCurrencyID(string currencyID, int top_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, null);
		}
		public async Task<List<Sa_compensation_userEO>> GetByCurrencyIDAsync(string currencyID, int top_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByCurrencyID(string currencyID, int top_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_compensation_userEO>> GetByCurrencyIDAsync(string currencyID, int top_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByCurrencyID(string currencyID, string sort_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, null);
		}
		public async Task<List<Sa_compensation_userEO>> GetByCurrencyIDAsync(string currencyID, string sort_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByCurrencyID(string currencyID, string sort_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, tm_);
		}
		public async Task<List<Sa_compensation_userEO>> GetByCurrencyIDAsync(string currencyID, string sort_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByCurrencyID(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_compensation_userEO.MapDataReader);
		}
		public async Task<List<Sa_compensation_userEO>> GetByCurrencyIDAsync(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_compensation_userEO.MapDataReader);
		}
		#endregion // GetByCurrencyID
		#region GetByFromId
		
		/// <summary>
		/// 按 FromId（字段） 查询
		/// </summary>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByFromId(string fromId)
		{
			return GetByFromId(fromId, 0, string.Empty, null);
		}
		public async Task<List<Sa_compensation_userEO>> GetByFromIdAsync(string fromId)
		{
			return await GetByFromIdAsync(fromId, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FromId（字段） 查询
		/// </summary>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByFromId(string fromId, TransactionManager tm_)
		{
			return GetByFromId(fromId, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_compensation_userEO>> GetByFromIdAsync(string fromId, TransactionManager tm_)
		{
			return await GetByFromIdAsync(fromId, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FromId（字段） 查询
		/// </summary>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByFromId(string fromId, int top_)
		{
			return GetByFromId(fromId, top_, string.Empty, null);
		}
		public async Task<List<Sa_compensation_userEO>> GetByFromIdAsync(string fromId, int top_)
		{
			return await GetByFromIdAsync(fromId, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FromId（字段） 查询
		/// </summary>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByFromId(string fromId, int top_, TransactionManager tm_)
		{
			return GetByFromId(fromId, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_compensation_userEO>> GetByFromIdAsync(string fromId, int top_, TransactionManager tm_)
		{
			return await GetByFromIdAsync(fromId, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FromId（字段） 查询
		/// </summary>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByFromId(string fromId, string sort_)
		{
			return GetByFromId(fromId, 0, sort_, null);
		}
		public async Task<List<Sa_compensation_userEO>> GetByFromIdAsync(string fromId, string sort_)
		{
			return await GetByFromIdAsync(fromId, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 FromId（字段） 查询
		/// </summary>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByFromId(string fromId, string sort_, TransactionManager tm_)
		{
			return GetByFromId(fromId, 0, sort_, tm_);
		}
		public async Task<List<Sa_compensation_userEO>> GetByFromIdAsync(string fromId, string sort_, TransactionManager tm_)
		{
			return await GetByFromIdAsync(fromId, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 FromId（字段） 查询
		/// </summary>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByFromId(string fromId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FromId` = @FromId", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FromId", fromId, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_compensation_userEO.MapDataReader);
		}
		public async Task<List<Sa_compensation_userEO>> GetByFromIdAsync(string fromId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FromId` = @FromId", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FromId", fromId, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_compensation_userEO.MapDataReader);
		}
		#endregion // GetByFromId
		#region GetByFromMode
		
		/// <summary>
		/// 按 FromMode（字段） 查询
		/// </summary>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByFromMode(int fromMode)
		{
			return GetByFromMode(fromMode, 0, string.Empty, null);
		}
		public async Task<List<Sa_compensation_userEO>> GetByFromModeAsync(int fromMode)
		{
			return await GetByFromModeAsync(fromMode, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FromMode（字段） 查询
		/// </summary>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByFromMode(int fromMode, TransactionManager tm_)
		{
			return GetByFromMode(fromMode, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_compensation_userEO>> GetByFromModeAsync(int fromMode, TransactionManager tm_)
		{
			return await GetByFromModeAsync(fromMode, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FromMode（字段） 查询
		/// </summary>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByFromMode(int fromMode, int top_)
		{
			return GetByFromMode(fromMode, top_, string.Empty, null);
		}
		public async Task<List<Sa_compensation_userEO>> GetByFromModeAsync(int fromMode, int top_)
		{
			return await GetByFromModeAsync(fromMode, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FromMode（字段） 查询
		/// </summary>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByFromMode(int fromMode, int top_, TransactionManager tm_)
		{
			return GetByFromMode(fromMode, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_compensation_userEO>> GetByFromModeAsync(int fromMode, int top_, TransactionManager tm_)
		{
			return await GetByFromModeAsync(fromMode, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FromMode（字段） 查询
		/// </summary>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByFromMode(int fromMode, string sort_)
		{
			return GetByFromMode(fromMode, 0, sort_, null);
		}
		public async Task<List<Sa_compensation_userEO>> GetByFromModeAsync(int fromMode, string sort_)
		{
			return await GetByFromModeAsync(fromMode, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 FromMode（字段） 查询
		/// </summary>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByFromMode(int fromMode, string sort_, TransactionManager tm_)
		{
			return GetByFromMode(fromMode, 0, sort_, tm_);
		}
		public async Task<List<Sa_compensation_userEO>> GetByFromModeAsync(int fromMode, string sort_, TransactionManager tm_)
		{
			return await GetByFromModeAsync(fromMode, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 FromMode（字段） 查询
		/// </summary>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByFromMode(int fromMode, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FromMode` = @FromMode", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FromMode", fromMode, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_compensation_userEO.MapDataReader);
		}
		public async Task<List<Sa_compensation_userEO>> GetByFromModeAsync(int fromMode, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FromMode` = @FromMode", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FromMode", fromMode, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_compensation_userEO.MapDataReader);
		}
		#endregion // GetByFromMode
		#region GetByFirstDayPayAmount
		
		/// <summary>
		/// 按 FirstDayPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "firstDayPayAmount">首日存款金额</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByFirstDayPayAmount(long firstDayPayAmount)
		{
			return GetByFirstDayPayAmount(firstDayPayAmount, 0, string.Empty, null);
		}
		public async Task<List<Sa_compensation_userEO>> GetByFirstDayPayAmountAsync(long firstDayPayAmount)
		{
			return await GetByFirstDayPayAmountAsync(firstDayPayAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FirstDayPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "firstDayPayAmount">首日存款金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByFirstDayPayAmount(long firstDayPayAmount, TransactionManager tm_)
		{
			return GetByFirstDayPayAmount(firstDayPayAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_compensation_userEO>> GetByFirstDayPayAmountAsync(long firstDayPayAmount, TransactionManager tm_)
		{
			return await GetByFirstDayPayAmountAsync(firstDayPayAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FirstDayPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "firstDayPayAmount">首日存款金额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByFirstDayPayAmount(long firstDayPayAmount, int top_)
		{
			return GetByFirstDayPayAmount(firstDayPayAmount, top_, string.Empty, null);
		}
		public async Task<List<Sa_compensation_userEO>> GetByFirstDayPayAmountAsync(long firstDayPayAmount, int top_)
		{
			return await GetByFirstDayPayAmountAsync(firstDayPayAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FirstDayPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "firstDayPayAmount">首日存款金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByFirstDayPayAmount(long firstDayPayAmount, int top_, TransactionManager tm_)
		{
			return GetByFirstDayPayAmount(firstDayPayAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_compensation_userEO>> GetByFirstDayPayAmountAsync(long firstDayPayAmount, int top_, TransactionManager tm_)
		{
			return await GetByFirstDayPayAmountAsync(firstDayPayAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FirstDayPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "firstDayPayAmount">首日存款金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByFirstDayPayAmount(long firstDayPayAmount, string sort_)
		{
			return GetByFirstDayPayAmount(firstDayPayAmount, 0, sort_, null);
		}
		public async Task<List<Sa_compensation_userEO>> GetByFirstDayPayAmountAsync(long firstDayPayAmount, string sort_)
		{
			return await GetByFirstDayPayAmountAsync(firstDayPayAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 FirstDayPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "firstDayPayAmount">首日存款金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByFirstDayPayAmount(long firstDayPayAmount, string sort_, TransactionManager tm_)
		{
			return GetByFirstDayPayAmount(firstDayPayAmount, 0, sort_, tm_);
		}
		public async Task<List<Sa_compensation_userEO>> GetByFirstDayPayAmountAsync(long firstDayPayAmount, string sort_, TransactionManager tm_)
		{
			return await GetByFirstDayPayAmountAsync(firstDayPayAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 FirstDayPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "firstDayPayAmount">首日存款金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByFirstDayPayAmount(long firstDayPayAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FirstDayPayAmount` = @FirstDayPayAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FirstDayPayAmount", firstDayPayAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_compensation_userEO.MapDataReader);
		}
		public async Task<List<Sa_compensation_userEO>> GetByFirstDayPayAmountAsync(long firstDayPayAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FirstDayPayAmount` = @FirstDayPayAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FirstDayPayAmount", firstDayPayAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_compensation_userEO.MapDataReader);
		}
		#endregion // GetByFirstDayPayAmount
		#region GetByFirstDayLoseCashAmount
		
		/// <summary>
		/// 按 FirstDayLoseCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "firstDayLoseCashAmount">首日亏损金额</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByFirstDayLoseCashAmount(long firstDayLoseCashAmount)
		{
			return GetByFirstDayLoseCashAmount(firstDayLoseCashAmount, 0, string.Empty, null);
		}
		public async Task<List<Sa_compensation_userEO>> GetByFirstDayLoseCashAmountAsync(long firstDayLoseCashAmount)
		{
			return await GetByFirstDayLoseCashAmountAsync(firstDayLoseCashAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FirstDayLoseCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "firstDayLoseCashAmount">首日亏损金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByFirstDayLoseCashAmount(long firstDayLoseCashAmount, TransactionManager tm_)
		{
			return GetByFirstDayLoseCashAmount(firstDayLoseCashAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_compensation_userEO>> GetByFirstDayLoseCashAmountAsync(long firstDayLoseCashAmount, TransactionManager tm_)
		{
			return await GetByFirstDayLoseCashAmountAsync(firstDayLoseCashAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FirstDayLoseCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "firstDayLoseCashAmount">首日亏损金额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByFirstDayLoseCashAmount(long firstDayLoseCashAmount, int top_)
		{
			return GetByFirstDayLoseCashAmount(firstDayLoseCashAmount, top_, string.Empty, null);
		}
		public async Task<List<Sa_compensation_userEO>> GetByFirstDayLoseCashAmountAsync(long firstDayLoseCashAmount, int top_)
		{
			return await GetByFirstDayLoseCashAmountAsync(firstDayLoseCashAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FirstDayLoseCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "firstDayLoseCashAmount">首日亏损金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByFirstDayLoseCashAmount(long firstDayLoseCashAmount, int top_, TransactionManager tm_)
		{
			return GetByFirstDayLoseCashAmount(firstDayLoseCashAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_compensation_userEO>> GetByFirstDayLoseCashAmountAsync(long firstDayLoseCashAmount, int top_, TransactionManager tm_)
		{
			return await GetByFirstDayLoseCashAmountAsync(firstDayLoseCashAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FirstDayLoseCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "firstDayLoseCashAmount">首日亏损金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByFirstDayLoseCashAmount(long firstDayLoseCashAmount, string sort_)
		{
			return GetByFirstDayLoseCashAmount(firstDayLoseCashAmount, 0, sort_, null);
		}
		public async Task<List<Sa_compensation_userEO>> GetByFirstDayLoseCashAmountAsync(long firstDayLoseCashAmount, string sort_)
		{
			return await GetByFirstDayLoseCashAmountAsync(firstDayLoseCashAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 FirstDayLoseCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "firstDayLoseCashAmount">首日亏损金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByFirstDayLoseCashAmount(long firstDayLoseCashAmount, string sort_, TransactionManager tm_)
		{
			return GetByFirstDayLoseCashAmount(firstDayLoseCashAmount, 0, sort_, tm_);
		}
		public async Task<List<Sa_compensation_userEO>> GetByFirstDayLoseCashAmountAsync(long firstDayLoseCashAmount, string sort_, TransactionManager tm_)
		{
			return await GetByFirstDayLoseCashAmountAsync(firstDayLoseCashAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 FirstDayLoseCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "firstDayLoseCashAmount">首日亏损金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByFirstDayLoseCashAmount(long firstDayLoseCashAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FirstDayLoseCashAmount` = @FirstDayLoseCashAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FirstDayLoseCashAmount", firstDayLoseCashAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_compensation_userEO.MapDataReader);
		}
		public async Task<List<Sa_compensation_userEO>> GetByFirstDayLoseCashAmountAsync(long firstDayLoseCashAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FirstDayLoseCashAmount` = @FirstDayLoseCashAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FirstDayLoseCashAmount", firstDayLoseCashAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_compensation_userEO.MapDataReader);
		}
		#endregion // GetByFirstDayLoseCashAmount
		#region GetByBonus
		
		/// <summary>
		/// 按 Bonus（字段） 查询
		/// </summary>
		/// /// <param name = "bonus">可领取奖金</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByBonus(long bonus)
		{
			return GetByBonus(bonus, 0, string.Empty, null);
		}
		public async Task<List<Sa_compensation_userEO>> GetByBonusAsync(long bonus)
		{
			return await GetByBonusAsync(bonus, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Bonus（字段） 查询
		/// </summary>
		/// /// <param name = "bonus">可领取奖金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByBonus(long bonus, TransactionManager tm_)
		{
			return GetByBonus(bonus, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_compensation_userEO>> GetByBonusAsync(long bonus, TransactionManager tm_)
		{
			return await GetByBonusAsync(bonus, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Bonus（字段） 查询
		/// </summary>
		/// /// <param name = "bonus">可领取奖金</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByBonus(long bonus, int top_)
		{
			return GetByBonus(bonus, top_, string.Empty, null);
		}
		public async Task<List<Sa_compensation_userEO>> GetByBonusAsync(long bonus, int top_)
		{
			return await GetByBonusAsync(bonus, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Bonus（字段） 查询
		/// </summary>
		/// /// <param name = "bonus">可领取奖金</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByBonus(long bonus, int top_, TransactionManager tm_)
		{
			return GetByBonus(bonus, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_compensation_userEO>> GetByBonusAsync(long bonus, int top_, TransactionManager tm_)
		{
			return await GetByBonusAsync(bonus, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Bonus（字段） 查询
		/// </summary>
		/// /// <param name = "bonus">可领取奖金</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByBonus(long bonus, string sort_)
		{
			return GetByBonus(bonus, 0, sort_, null);
		}
		public async Task<List<Sa_compensation_userEO>> GetByBonusAsync(long bonus, string sort_)
		{
			return await GetByBonusAsync(bonus, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Bonus（字段） 查询
		/// </summary>
		/// /// <param name = "bonus">可领取奖金</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByBonus(long bonus, string sort_, TransactionManager tm_)
		{
			return GetByBonus(bonus, 0, sort_, tm_);
		}
		public async Task<List<Sa_compensation_userEO>> GetByBonusAsync(long bonus, string sort_, TransactionManager tm_)
		{
			return await GetByBonusAsync(bonus, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Bonus（字段） 查询
		/// </summary>
		/// /// <param name = "bonus">可领取奖金</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByBonus(long bonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Bonus` = @Bonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Bonus", bonus, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_compensation_userEO.MapDataReader);
		}
		public async Task<List<Sa_compensation_userEO>> GetByBonusAsync(long bonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Bonus` = @Bonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Bonus", bonus, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_compensation_userEO.MapDataReader);
		}
		#endregion // GetByBonus
		#region GetByFlowMultip
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">流水倍数</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByFlowMultip(float flowMultip)
		{
			return GetByFlowMultip(flowMultip, 0, string.Empty, null);
		}
		public async Task<List<Sa_compensation_userEO>> GetByFlowMultipAsync(float flowMultip)
		{
			return await GetByFlowMultipAsync(flowMultip, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">流水倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByFlowMultip(float flowMultip, TransactionManager tm_)
		{
			return GetByFlowMultip(flowMultip, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_compensation_userEO>> GetByFlowMultipAsync(float flowMultip, TransactionManager tm_)
		{
			return await GetByFlowMultipAsync(flowMultip, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">流水倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByFlowMultip(float flowMultip, int top_)
		{
			return GetByFlowMultip(flowMultip, top_, string.Empty, null);
		}
		public async Task<List<Sa_compensation_userEO>> GetByFlowMultipAsync(float flowMultip, int top_)
		{
			return await GetByFlowMultipAsync(flowMultip, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">流水倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByFlowMultip(float flowMultip, int top_, TransactionManager tm_)
		{
			return GetByFlowMultip(flowMultip, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_compensation_userEO>> GetByFlowMultipAsync(float flowMultip, int top_, TransactionManager tm_)
		{
			return await GetByFlowMultipAsync(flowMultip, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">流水倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByFlowMultip(float flowMultip, string sort_)
		{
			return GetByFlowMultip(flowMultip, 0, sort_, null);
		}
		public async Task<List<Sa_compensation_userEO>> GetByFlowMultipAsync(float flowMultip, string sort_)
		{
			return await GetByFlowMultipAsync(flowMultip, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">流水倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByFlowMultip(float flowMultip, string sort_, TransactionManager tm_)
		{
			return GetByFlowMultip(flowMultip, 0, sort_, tm_);
		}
		public async Task<List<Sa_compensation_userEO>> GetByFlowMultipAsync(float flowMultip, string sort_, TransactionManager tm_)
		{
			return await GetByFlowMultipAsync(flowMultip, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">流水倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByFlowMultip(float flowMultip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FlowMultip` = @FlowMultip", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FlowMultip", flowMultip, MySqlDbType.Float));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_compensation_userEO.MapDataReader);
		}
		public async Task<List<Sa_compensation_userEO>> GetByFlowMultipAsync(float flowMultip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FlowMultip` = @FlowMultip", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FlowMultip", flowMultip, MySqlDbType.Float));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_compensation_userEO.MapDataReader);
		}
		#endregion // GetByFlowMultip
		#region GetByReceiveStatus
		
		/// <summary>
		/// 按 ReceiveStatus（字段） 查询
		/// </summary>
		/// /// <param name = "receiveStatus">bonus领取状态0-未领取1-已领取</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByReceiveStatus(bool receiveStatus)
		{
			return GetByReceiveStatus(receiveStatus, 0, string.Empty, null);
		}
		public async Task<List<Sa_compensation_userEO>> GetByReceiveStatusAsync(bool receiveStatus)
		{
			return await GetByReceiveStatusAsync(receiveStatus, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ReceiveStatus（字段） 查询
		/// </summary>
		/// /// <param name = "receiveStatus">bonus领取状态0-未领取1-已领取</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByReceiveStatus(bool receiveStatus, TransactionManager tm_)
		{
			return GetByReceiveStatus(receiveStatus, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_compensation_userEO>> GetByReceiveStatusAsync(bool receiveStatus, TransactionManager tm_)
		{
			return await GetByReceiveStatusAsync(receiveStatus, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ReceiveStatus（字段） 查询
		/// </summary>
		/// /// <param name = "receiveStatus">bonus领取状态0-未领取1-已领取</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByReceiveStatus(bool receiveStatus, int top_)
		{
			return GetByReceiveStatus(receiveStatus, top_, string.Empty, null);
		}
		public async Task<List<Sa_compensation_userEO>> GetByReceiveStatusAsync(bool receiveStatus, int top_)
		{
			return await GetByReceiveStatusAsync(receiveStatus, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ReceiveStatus（字段） 查询
		/// </summary>
		/// /// <param name = "receiveStatus">bonus领取状态0-未领取1-已领取</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByReceiveStatus(bool receiveStatus, int top_, TransactionManager tm_)
		{
			return GetByReceiveStatus(receiveStatus, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_compensation_userEO>> GetByReceiveStatusAsync(bool receiveStatus, int top_, TransactionManager tm_)
		{
			return await GetByReceiveStatusAsync(receiveStatus, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ReceiveStatus（字段） 查询
		/// </summary>
		/// /// <param name = "receiveStatus">bonus领取状态0-未领取1-已领取</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByReceiveStatus(bool receiveStatus, string sort_)
		{
			return GetByReceiveStatus(receiveStatus, 0, sort_, null);
		}
		public async Task<List<Sa_compensation_userEO>> GetByReceiveStatusAsync(bool receiveStatus, string sort_)
		{
			return await GetByReceiveStatusAsync(receiveStatus, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ReceiveStatus（字段） 查询
		/// </summary>
		/// /// <param name = "receiveStatus">bonus领取状态0-未领取1-已领取</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByReceiveStatus(bool receiveStatus, string sort_, TransactionManager tm_)
		{
			return GetByReceiveStatus(receiveStatus, 0, sort_, tm_);
		}
		public async Task<List<Sa_compensation_userEO>> GetByReceiveStatusAsync(bool receiveStatus, string sort_, TransactionManager tm_)
		{
			return await GetByReceiveStatusAsync(receiveStatus, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ReceiveStatus（字段） 查询
		/// </summary>
		/// /// <param name = "receiveStatus">bonus领取状态0-未领取1-已领取</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByReceiveStatus(bool receiveStatus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ReceiveStatus` = @ReceiveStatus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ReceiveStatus", receiveStatus, MySqlDbType.Byte));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_compensation_userEO.MapDataReader);
		}
		public async Task<List<Sa_compensation_userEO>> GetByReceiveStatusAsync(bool receiveStatus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ReceiveStatus` = @ReceiveStatus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ReceiveStatus", receiveStatus, MySqlDbType.Byte));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_compensation_userEO.MapDataReader);
		}
		#endregion // GetByReceiveStatus
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">购买时间</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<Sa_compensation_userEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">购买时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_compensation_userEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">购买时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<Sa_compensation_userEO>> GetByRecDateAsync(DateTime recDate, int top_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">购买时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_compensation_userEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">购买时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<Sa_compensation_userEO>> GetByRecDateAsync(DateTime recDate, string sort_)
		{
			return await GetByRecDateAsync(recDate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">购买时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<Sa_compensation_userEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">购买时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_compensation_userEO.MapDataReader);
		}
		public async Task<List<Sa_compensation_userEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_compensation_userEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#region GetByReceiveDate
		
		/// <summary>
		/// 按 ReceiveDate（字段） 查询
		/// </summary>
		/// /// <param name = "receiveDate">领取时间</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByReceiveDate(DateTime? receiveDate)
		{
			return GetByReceiveDate(receiveDate, 0, string.Empty, null);
		}
		public async Task<List<Sa_compensation_userEO>> GetByReceiveDateAsync(DateTime? receiveDate)
		{
			return await GetByReceiveDateAsync(receiveDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ReceiveDate（字段） 查询
		/// </summary>
		/// /// <param name = "receiveDate">领取时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByReceiveDate(DateTime? receiveDate, TransactionManager tm_)
		{
			return GetByReceiveDate(receiveDate, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_compensation_userEO>> GetByReceiveDateAsync(DateTime? receiveDate, TransactionManager tm_)
		{
			return await GetByReceiveDateAsync(receiveDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ReceiveDate（字段） 查询
		/// </summary>
		/// /// <param name = "receiveDate">领取时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByReceiveDate(DateTime? receiveDate, int top_)
		{
			return GetByReceiveDate(receiveDate, top_, string.Empty, null);
		}
		public async Task<List<Sa_compensation_userEO>> GetByReceiveDateAsync(DateTime? receiveDate, int top_)
		{
			return await GetByReceiveDateAsync(receiveDate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ReceiveDate（字段） 查询
		/// </summary>
		/// /// <param name = "receiveDate">领取时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByReceiveDate(DateTime? receiveDate, int top_, TransactionManager tm_)
		{
			return GetByReceiveDate(receiveDate, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_compensation_userEO>> GetByReceiveDateAsync(DateTime? receiveDate, int top_, TransactionManager tm_)
		{
			return await GetByReceiveDateAsync(receiveDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ReceiveDate（字段） 查询
		/// </summary>
		/// /// <param name = "receiveDate">领取时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByReceiveDate(DateTime? receiveDate, string sort_)
		{
			return GetByReceiveDate(receiveDate, 0, sort_, null);
		}
		public async Task<List<Sa_compensation_userEO>> GetByReceiveDateAsync(DateTime? receiveDate, string sort_)
		{
			return await GetByReceiveDateAsync(receiveDate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ReceiveDate（字段） 查询
		/// </summary>
		/// /// <param name = "receiveDate">领取时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByReceiveDate(DateTime? receiveDate, string sort_, TransactionManager tm_)
		{
			return GetByReceiveDate(receiveDate, 0, sort_, tm_);
		}
		public async Task<List<Sa_compensation_userEO>> GetByReceiveDateAsync(DateTime? receiveDate, string sort_, TransactionManager tm_)
		{
			return await GetByReceiveDateAsync(receiveDate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ReceiveDate（字段） 查询
		/// </summary>
		/// /// <param name = "receiveDate">领取时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_compensation_userEO> GetByReceiveDate(DateTime? receiveDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(receiveDate.HasValue ? "`ReceiveDate` = @ReceiveDate" : "`ReceiveDate` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (receiveDate.HasValue)
				paras_.Add(Database.CreateInParameter("@ReceiveDate", receiveDate.Value, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_compensation_userEO.MapDataReader);
		}
		public async Task<List<Sa_compensation_userEO>> GetByReceiveDateAsync(DateTime? receiveDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(receiveDate.HasValue ? "`ReceiveDate` = @ReceiveDate" : "`ReceiveDate` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (receiveDate.HasValue)
				paras_.Add(Database.CreateInParameter("@ReceiveDate", receiveDate.Value, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_compensation_userEO.MapDataReader);
		}
		#endregion // GetByReceiveDate
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
