/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * AiUo代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/AiUo
 * 文档生成时间：2023-12-28 17: 18:51
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
	/// 1.7版周卡用户表
	/// 【表 sa_weeklycard_user 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Sa_weeklycard_userEO : IRowMapper<Sa_weeklycard_userEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Sa_weeklycard_userEO()
		{
			this.WeeklyCardType = 0;
			this.FlowMultip = 1.00f;
			this.CountDownStart = DateTime.Now;
			this.IsBuyWeeklyCard = false;
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
		/// 1-100档周卡2-50档周卡
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 4)]
		public int WeeklyCardType { get; set; }
		/// <summary>
		/// 对应的编码（根据FromMode变化）
		///                           FromMode=
		///                           0-运营商的新用户(s_operator)==> OperatorID
		///                           1-推广员获得的新用户（userid） ==> 邀请人的UserID
		///                           2-推广渠道通过url获得的新用户（s_channel_url) ==> CUrlID
		///                           3-推广渠道通过code获得的新用户（s_channel_code) ==> CCodeID
		/// 【字段 varchar(200)】
		/// </summary>
		[DataMember(Order = 5)]
		public string FromId { get; set; }
		/// <summary>
		/// 新用户来源方式
		///                           0-获得运营商的新用户(s_operator)
		///                           1-推广员获得的新用户（userid）
		///                           2-推广渠道通过url获得的新用户（s_channel_url)
		///                           3-推广渠道通过code获得的新用户（s_channel_code)
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 6)]
		public int FromMode { get; set; }
		/// <summary>
		/// 购买金额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 7)]
		public long PayAmount { get; set; }
		/// <summary>
		/// 流水倍数
		/// 【字段 float(10,2)】
		/// </summary>
		[DataMember(Order = 8)]
		public float FlowMultip { get; set; }
		/// <summary>
		/// 周卡起始日期
		/// 【字段 date】
		/// </summary>
		[DataMember(Order = 9)]
		public DateTime CycleStartDate { get; set; }
		/// <summary>
		/// 周卡截止日期
		/// 【字段 date】
		/// </summary>
		[DataMember(Order = 10)]
		public DateTime CycleEndDate { get; set; }
		/// <summary>
		/// 购买周卡倒计时开始时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 11)]
		public DateTime CountDownStart { get; set; }
		/// <summary>
		/// 是否购买周卡
		/// 【字段 tinyint(1)】
		/// </summary>
		[DataMember(Order = 12)]
		public bool IsBuyWeeklyCard { get; set; }
		/// <summary>
		/// 购买时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 13)]
		public DateTime RecDate { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Sa_weeklycard_userEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Sa_weeklycard_userEO MapDataReader(IDataReader reader)
		{
		    Sa_weeklycard_userEO ret = new Sa_weeklycard_userEO();
			ret.UserId = reader.ToString("UserId");
			ret.OriginalUserId = ret.UserId;
			ret.OperatorID = reader.ToString("OperatorID");
			ret.CurrencyID = reader.ToString("CurrencyID");
			ret.WeeklyCardType = reader.ToInt32("WeeklyCardType");
			ret.FromId = reader.ToString("FromId");
			ret.FromMode = reader.ToInt32("FromMode");
			ret.PayAmount = reader.ToInt64("PayAmount");
			ret.FlowMultip = reader.ToSingle("FlowMultip");
			ret.CycleStartDate = reader.ToDateTime("CycleStartDate");
			ret.CycleEndDate = reader.ToDateTime("CycleEndDate");
			ret.CountDownStart = reader.ToDateTime("CountDownStart");
			ret.IsBuyWeeklyCard = reader.ToBoolean("IsBuyWeeklyCard");
			ret.RecDate = reader.ToDateTime("RecDate");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 1.7版周卡用户表
	/// 【表 sa_weeklycard_user 的操作类】
	/// </summary>
	[Obsolete]
	public class Sa_weeklycard_userMO : MySqlTableMO<Sa_weeklycard_userEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`sa_weeklycard_user`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Sa_weeklycard_userMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Sa_weeklycard_userMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Sa_weeklycard_userMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Sa_weeklycard_userEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Sa_weeklycard_userEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Sa_weeklycard_userEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`UserId`, `OperatorID`, `CurrencyID`, `WeeklyCardType`, `FromId`, `FromMode`, `PayAmount`, `FlowMultip`, `CycleStartDate`, `CycleEndDate`, `CountDownStart`, `IsBuyWeeklyCard`, `RecDate`) VALUE (@UserId, @OperatorID, @CurrencyID, @WeeklyCardType, @FromId, @FromMode, @PayAmount, @FlowMultip, @CycleStartDate, @CycleEndDate, @CountDownStart, @IsBuyWeeklyCard, @RecDate);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserId", item.UserId, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@WeeklyCardType", item.WeeklyCardType, MySqlDbType.Int32),
				Database.CreateInParameter("@FromId", item.FromId, MySqlDbType.VarChar),
				Database.CreateInParameter("@FromMode", item.FromMode, MySqlDbType.Int32),
				Database.CreateInParameter("@PayAmount", item.PayAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@FlowMultip", item.FlowMultip, MySqlDbType.Float),
				Database.CreateInParameter("@CycleStartDate", item.CycleStartDate, MySqlDbType.Date),
				Database.CreateInParameter("@CycleEndDate", item.CycleEndDate, MySqlDbType.Date),
				Database.CreateInParameter("@CountDownStart", item.CountDownStart, MySqlDbType.DateTime),
				Database.CreateInParameter("@IsBuyWeeklyCard", item.IsBuyWeeklyCard, MySqlDbType.Byte),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
			};
		}
		public int AddByBatch(IEnumerable<Sa_weeklycard_userEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Sa_weeklycard_userEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sa_weeklycard_userEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`UserId`, `OperatorID`, `CurrencyID`, `WeeklyCardType`, `FromId`, `FromMode`, `PayAmount`, `FlowMultip`, `CycleStartDate`, `CycleEndDate`, `CountDownStart`, `IsBuyWeeklyCard`, `RecDate`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.UserId}','{item.OperatorID}','{item.CurrencyID}',{item.WeeklyCardType},'{item.FromId}',{item.FromMode},{item.PayAmount},{item.FlowMultip},'{item.CycleStartDate.ToString("yyyy-MM-dd HH:mm:ss")}','{item.CycleEndDate.ToString("yyyy-MM-dd HH:mm:ss")}','{item.CountDownStart.ToString("yyyy-MM-dd HH:mm:ss")}',{item.IsBuyWeeklyCard},'{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
		public int Remove(Sa_weeklycard_userEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.UserId, tm_);
		}
		public async Task<int> RemoveAsync(Sa_weeklycard_userEO item, TransactionManager tm_ = null)
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
		#region RemoveByWeeklyCardType
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "weeklyCardType">1-100档周卡2-50档周卡</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByWeeklyCardType(int weeklyCardType, TransactionManager tm_ = null)
		{
			RepairRemoveByWeeklyCardTypeData(weeklyCardType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByWeeklyCardTypeAsync(int weeklyCardType, TransactionManager tm_ = null)
		{
			RepairRemoveByWeeklyCardTypeData(weeklyCardType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByWeeklyCardTypeData(int weeklyCardType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `WeeklyCardType` = @WeeklyCardType";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WeeklyCardType", weeklyCardType, MySqlDbType.Int32));
		}
		#endregion // RemoveByWeeklyCardType
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
		#region RemoveByPayAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "payAmount">购买金额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPayAmount(long payAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByPayAmountData(payAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPayAmountAsync(long payAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByPayAmountData(payAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByPayAmountData(long payAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `PayAmount` = @PayAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PayAmount", payAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByPayAmount
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
		#region RemoveByCycleStartDate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "cycleStartDate">周卡起始日期</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCycleStartDate(DateTime cycleStartDate, TransactionManager tm_ = null)
		{
			RepairRemoveByCycleStartDateData(cycleStartDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCycleStartDateAsync(DateTime cycleStartDate, TransactionManager tm_ = null)
		{
			RepairRemoveByCycleStartDateData(cycleStartDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCycleStartDateData(DateTime cycleStartDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `CycleStartDate` = @CycleStartDate";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CycleStartDate", cycleStartDate, MySqlDbType.Date));
		}
		#endregion // RemoveByCycleStartDate
		#region RemoveByCycleEndDate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "cycleEndDate">周卡截止日期</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCycleEndDate(DateTime cycleEndDate, TransactionManager tm_ = null)
		{
			RepairRemoveByCycleEndDateData(cycleEndDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCycleEndDateAsync(DateTime cycleEndDate, TransactionManager tm_ = null)
		{
			RepairRemoveByCycleEndDateData(cycleEndDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCycleEndDateData(DateTime cycleEndDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `CycleEndDate` = @CycleEndDate";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CycleEndDate", cycleEndDate, MySqlDbType.Date));
		}
		#endregion // RemoveByCycleEndDate
		#region RemoveByCountDownStart
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "countDownStart">购买周卡倒计时开始时间</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCountDownStart(DateTime countDownStart, TransactionManager tm_ = null)
		{
			RepairRemoveByCountDownStartData(countDownStart, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCountDownStartAsync(DateTime countDownStart, TransactionManager tm_ = null)
		{
			RepairRemoveByCountDownStartData(countDownStart, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCountDownStartData(DateTime countDownStart, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `CountDownStart` = @CountDownStart";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CountDownStart", countDownStart, MySqlDbType.DateTime));
		}
		#endregion // RemoveByCountDownStart
		#region RemoveByIsBuyWeeklyCard
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "isBuyWeeklyCard">是否购买周卡</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByIsBuyWeeklyCard(bool isBuyWeeklyCard, TransactionManager tm_ = null)
		{
			RepairRemoveByIsBuyWeeklyCardData(isBuyWeeklyCard, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByIsBuyWeeklyCardAsync(bool isBuyWeeklyCard, TransactionManager tm_ = null)
		{
			RepairRemoveByIsBuyWeeklyCardData(isBuyWeeklyCard, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByIsBuyWeeklyCardData(bool isBuyWeeklyCard, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `IsBuyWeeklyCard` = @IsBuyWeeklyCard";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsBuyWeeklyCard", isBuyWeeklyCard, MySqlDbType.Byte));
		}
		#endregion // RemoveByIsBuyWeeklyCard
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
		public int Put(Sa_weeklycard_userEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Sa_weeklycard_userEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Sa_weeklycard_userEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UserId` = @UserId, `OperatorID` = @OperatorID, `CurrencyID` = @CurrencyID, `WeeklyCardType` = @WeeklyCardType, `FromId` = @FromId, `FromMode` = @FromMode, `PayAmount` = @PayAmount, `FlowMultip` = @FlowMultip, `CycleStartDate` = @CycleStartDate, `CycleEndDate` = @CycleEndDate, `IsBuyWeeklyCard` = @IsBuyWeeklyCard WHERE `UserId` = @UserId_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserId", item.UserId, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@WeeklyCardType", item.WeeklyCardType, MySqlDbType.Int32),
				Database.CreateInParameter("@FromId", item.FromId, MySqlDbType.VarChar),
				Database.CreateInParameter("@FromMode", item.FromMode, MySqlDbType.Int32),
				Database.CreateInParameter("@PayAmount", item.PayAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@FlowMultip", item.FlowMultip, MySqlDbType.Float),
				Database.CreateInParameter("@CycleStartDate", item.CycleStartDate, MySqlDbType.Date),
				Database.CreateInParameter("@CycleEndDate", item.CycleEndDate, MySqlDbType.Date),
				Database.CreateInParameter("@IsBuyWeeklyCard", item.IsBuyWeeklyCard, MySqlDbType.Byte),
				Database.CreateInParameter("@UserId_Original", item.HasOriginal ? item.OriginalUserId : item.UserId, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Sa_weeklycard_userEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Sa_weeklycard_userEO> items, TransactionManager tm_ = null)
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
		#region PutWeeklyCardType
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userId">用户编码</param>
		/// /// <param name = "weeklyCardType">1-100档周卡2-50档周卡</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWeeklyCardTypeByPK(string userId, int weeklyCardType, TransactionManager tm_ = null)
		{
			RepairPutWeeklyCardTypeByPKData(userId, weeklyCardType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutWeeklyCardTypeByPKAsync(string userId, int weeklyCardType, TransactionManager tm_ = null)
		{
			RepairPutWeeklyCardTypeByPKData(userId, weeklyCardType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutWeeklyCardTypeByPKData(string userId, int weeklyCardType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `WeeklyCardType` = @WeeklyCardType  WHERE `UserId` = @UserId";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@WeeklyCardType", weeklyCardType, MySqlDbType.Int32),
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "weeklyCardType">1-100档周卡2-50档周卡</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWeeklyCardType(int weeklyCardType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `WeeklyCardType` = @WeeklyCardType";
			var parameter_ = Database.CreateInParameter("@WeeklyCardType", weeklyCardType, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutWeeklyCardTypeAsync(int weeklyCardType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `WeeklyCardType` = @WeeklyCardType";
			var parameter_ = Database.CreateInParameter("@WeeklyCardType", weeklyCardType, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutWeeklyCardType
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
		#region PutPayAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userId">用户编码</param>
		/// /// <param name = "payAmount">购买金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPayAmountByPK(string userId, long payAmount, TransactionManager tm_ = null)
		{
			RepairPutPayAmountByPKData(userId, payAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutPayAmountByPKAsync(string userId, long payAmount, TransactionManager tm_ = null)
		{
			RepairPutPayAmountByPKData(userId, payAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutPayAmountByPKData(string userId, long payAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `PayAmount` = @PayAmount  WHERE `UserId` = @UserId";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PayAmount", payAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "payAmount">购买金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPayAmount(long payAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PayAmount` = @PayAmount";
			var parameter_ = Database.CreateInParameter("@PayAmount", payAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutPayAmountAsync(long payAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PayAmount` = @PayAmount";
			var parameter_ = Database.CreateInParameter("@PayAmount", payAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutPayAmount
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
		#region PutCycleStartDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userId">用户编码</param>
		/// /// <param name = "cycleStartDate">周卡起始日期</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCycleStartDateByPK(string userId, DateTime cycleStartDate, TransactionManager tm_ = null)
		{
			RepairPutCycleStartDateByPKData(userId, cycleStartDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCycleStartDateByPKAsync(string userId, DateTime cycleStartDate, TransactionManager tm_ = null)
		{
			RepairPutCycleStartDateByPKData(userId, cycleStartDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCycleStartDateByPKData(string userId, DateTime cycleStartDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CycleStartDate` = @CycleStartDate  WHERE `UserId` = @UserId";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CycleStartDate", cycleStartDate, MySqlDbType.Date),
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "cycleStartDate">周卡起始日期</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCycleStartDate(DateTime cycleStartDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CycleStartDate` = @CycleStartDate";
			var parameter_ = Database.CreateInParameter("@CycleStartDate", cycleStartDate, MySqlDbType.Date);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCycleStartDateAsync(DateTime cycleStartDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CycleStartDate` = @CycleStartDate";
			var parameter_ = Database.CreateInParameter("@CycleStartDate", cycleStartDate, MySqlDbType.Date);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCycleStartDate
		#region PutCycleEndDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userId">用户编码</param>
		/// /// <param name = "cycleEndDate">周卡截止日期</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCycleEndDateByPK(string userId, DateTime cycleEndDate, TransactionManager tm_ = null)
		{
			RepairPutCycleEndDateByPKData(userId, cycleEndDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCycleEndDateByPKAsync(string userId, DateTime cycleEndDate, TransactionManager tm_ = null)
		{
			RepairPutCycleEndDateByPKData(userId, cycleEndDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCycleEndDateByPKData(string userId, DateTime cycleEndDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CycleEndDate` = @CycleEndDate  WHERE `UserId` = @UserId";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CycleEndDate", cycleEndDate, MySqlDbType.Date),
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "cycleEndDate">周卡截止日期</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCycleEndDate(DateTime cycleEndDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CycleEndDate` = @CycleEndDate";
			var parameter_ = Database.CreateInParameter("@CycleEndDate", cycleEndDate, MySqlDbType.Date);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCycleEndDateAsync(DateTime cycleEndDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CycleEndDate` = @CycleEndDate";
			var parameter_ = Database.CreateInParameter("@CycleEndDate", cycleEndDate, MySqlDbType.Date);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCycleEndDate
		#region PutCountDownStart
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userId">用户编码</param>
		/// /// <param name = "countDownStart">购买周卡倒计时开始时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCountDownStartByPK(string userId, DateTime countDownStart, TransactionManager tm_ = null)
		{
			RepairPutCountDownStartByPKData(userId, countDownStart, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCountDownStartByPKAsync(string userId, DateTime countDownStart, TransactionManager tm_ = null)
		{
			RepairPutCountDownStartByPKData(userId, countDownStart, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCountDownStartByPKData(string userId, DateTime countDownStart, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CountDownStart` = @CountDownStart  WHERE `UserId` = @UserId";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountDownStart", countDownStart, MySqlDbType.DateTime),
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "countDownStart">购买周卡倒计时开始时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCountDownStart(DateTime countDownStart, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CountDownStart` = @CountDownStart";
			var parameter_ = Database.CreateInParameter("@CountDownStart", countDownStart, MySqlDbType.DateTime);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCountDownStartAsync(DateTime countDownStart, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CountDownStart` = @CountDownStart";
			var parameter_ = Database.CreateInParameter("@CountDownStart", countDownStart, MySqlDbType.DateTime);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCountDownStart
		#region PutIsBuyWeeklyCard
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userId">用户编码</param>
		/// /// <param name = "isBuyWeeklyCard">是否购买周卡</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsBuyWeeklyCardByPK(string userId, bool isBuyWeeklyCard, TransactionManager tm_ = null)
		{
			RepairPutIsBuyWeeklyCardByPKData(userId, isBuyWeeklyCard, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutIsBuyWeeklyCardByPKAsync(string userId, bool isBuyWeeklyCard, TransactionManager tm_ = null)
		{
			RepairPutIsBuyWeeklyCardByPKData(userId, isBuyWeeklyCard, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutIsBuyWeeklyCardByPKData(string userId, bool isBuyWeeklyCard, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `IsBuyWeeklyCard` = @IsBuyWeeklyCard  WHERE `UserId` = @UserId";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@IsBuyWeeklyCard", isBuyWeeklyCard, MySqlDbType.Byte),
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "isBuyWeeklyCard">是否购买周卡</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsBuyWeeklyCard(bool isBuyWeeklyCard, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsBuyWeeklyCard` = @IsBuyWeeklyCard";
			var parameter_ = Database.CreateInParameter("@IsBuyWeeklyCard", isBuyWeeklyCard, MySqlDbType.Byte);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutIsBuyWeeklyCardAsync(bool isBuyWeeklyCard, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsBuyWeeklyCard` = @IsBuyWeeklyCard";
			var parameter_ = Database.CreateInParameter("@IsBuyWeeklyCard", isBuyWeeklyCard, MySqlDbType.Byte);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutIsBuyWeeklyCard
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
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Sa_weeklycard_userEO item, TransactionManager tm = null)
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
		public async Task<bool> SetAsync(Sa_weeklycard_userEO item, TransactionManager tm = null)
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
		public Sa_weeklycard_userEO GetByPK(string userId, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(userId, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sa_weeklycard_userEO.MapDataReader);
		}
		public async Task<Sa_weeklycard_userEO> GetByPKAsync(string userId, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(userId, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sa_weeklycard_userEO.MapDataReader);
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
		/// 按主键查询 WeeklyCardType（字段）
		/// </summary>
		/// /// <param name = "userId">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetWeeklyCardTypeByPK(string userId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`WeeklyCardType`", "`UserId` = @UserId", paras_, tm_);
		}
		public async Task<int> GetWeeklyCardTypeByPKAsync(string userId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`WeeklyCardType`", "`UserId` = @UserId", paras_, tm_);
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
		/// 按主键查询 PayAmount（字段）
		/// </summary>
		/// /// <param name = "userId">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetPayAmountByPK(string userId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`PayAmount`", "`UserId` = @UserId", paras_, tm_);
		}
		public async Task<long> GetPayAmountByPKAsync(string userId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`PayAmount`", "`UserId` = @UserId", paras_, tm_);
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
		/// 按主键查询 CycleStartDate（字段）
		/// </summary>
		/// /// <param name = "userId">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetCycleStartDateByPK(string userId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`CycleStartDate`", "`UserId` = @UserId", paras_, tm_);
		}
		public async Task<DateTime> GetCycleStartDateByPKAsync(string userId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`CycleStartDate`", "`UserId` = @UserId", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CycleEndDate（字段）
		/// </summary>
		/// /// <param name = "userId">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetCycleEndDateByPK(string userId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`CycleEndDate`", "`UserId` = @UserId", paras_, tm_);
		}
		public async Task<DateTime> GetCycleEndDateByPKAsync(string userId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`CycleEndDate`", "`UserId` = @UserId", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CountDownStart（字段）
		/// </summary>
		/// /// <param name = "userId">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetCountDownStartByPK(string userId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`CountDownStart`", "`UserId` = @UserId", paras_, tm_);
		}
		public async Task<DateTime> GetCountDownStartByPKAsync(string userId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`CountDownStart`", "`UserId` = @UserId", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 IsBuyWeeklyCard（字段）
		/// </summary>
		/// /// <param name = "userId">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public bool GetIsBuyWeeklyCardByPK(string userId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
			return (bool)GetScalar("`IsBuyWeeklyCard`", "`UserId` = @UserId", paras_, tm_);
		}
		public async Task<bool> GetIsBuyWeeklyCardByPKAsync(string userId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
			return (bool)await GetScalarAsync("`IsBuyWeeklyCard`", "`UserId` = @UserId", paras_, tm_);
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
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_userEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_userEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_userEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByOperatorIDAsync(string operatorID, int top_)
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
		public List<Sa_weeklycard_userEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_userEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByOperatorIDAsync(string operatorID, string sort_)
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
		public List<Sa_weeklycard_userEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
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
		public List<Sa_weeklycard_userEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_weeklycard_userEO.MapDataReader);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_weeklycard_userEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByCurrencyID
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_userEO> GetByCurrencyID(string currencyID)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, null);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByCurrencyIDAsync(string currencyID)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_userEO> GetByCurrencyID(string currencyID, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByCurrencyIDAsync(string currencyID, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_userEO> GetByCurrencyID(string currencyID, int top_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, null);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByCurrencyIDAsync(string currencyID, int top_)
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
		public List<Sa_weeklycard_userEO> GetByCurrencyID(string currencyID, int top_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByCurrencyIDAsync(string currencyID, int top_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_userEO> GetByCurrencyID(string currencyID, string sort_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, null);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByCurrencyIDAsync(string currencyID, string sort_)
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
		public List<Sa_weeklycard_userEO> GetByCurrencyID(string currencyID, string sort_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, tm_);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByCurrencyIDAsync(string currencyID, string sort_, TransactionManager tm_)
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
		public List<Sa_weeklycard_userEO> GetByCurrencyID(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_weeklycard_userEO.MapDataReader);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByCurrencyIDAsync(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_weeklycard_userEO.MapDataReader);
		}
		#endregion // GetByCurrencyID
		#region GetByWeeklyCardType
		
		/// <summary>
		/// 按 WeeklyCardType（字段） 查询
		/// </summary>
		/// /// <param name = "weeklyCardType">1-100档周卡2-50档周卡</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_userEO> GetByWeeklyCardType(int weeklyCardType)
		{
			return GetByWeeklyCardType(weeklyCardType, 0, string.Empty, null);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByWeeklyCardTypeAsync(int weeklyCardType)
		{
			return await GetByWeeklyCardTypeAsync(weeklyCardType, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WeeklyCardType（字段） 查询
		/// </summary>
		/// /// <param name = "weeklyCardType">1-100档周卡2-50档周卡</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_userEO> GetByWeeklyCardType(int weeklyCardType, TransactionManager tm_)
		{
			return GetByWeeklyCardType(weeklyCardType, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByWeeklyCardTypeAsync(int weeklyCardType, TransactionManager tm_)
		{
			return await GetByWeeklyCardTypeAsync(weeklyCardType, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WeeklyCardType（字段） 查询
		/// </summary>
		/// /// <param name = "weeklyCardType">1-100档周卡2-50档周卡</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_userEO> GetByWeeklyCardType(int weeklyCardType, int top_)
		{
			return GetByWeeklyCardType(weeklyCardType, top_, string.Empty, null);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByWeeklyCardTypeAsync(int weeklyCardType, int top_)
		{
			return await GetByWeeklyCardTypeAsync(weeklyCardType, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WeeklyCardType（字段） 查询
		/// </summary>
		/// /// <param name = "weeklyCardType">1-100档周卡2-50档周卡</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_userEO> GetByWeeklyCardType(int weeklyCardType, int top_, TransactionManager tm_)
		{
			return GetByWeeklyCardType(weeklyCardType, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByWeeklyCardTypeAsync(int weeklyCardType, int top_, TransactionManager tm_)
		{
			return await GetByWeeklyCardTypeAsync(weeklyCardType, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WeeklyCardType（字段） 查询
		/// </summary>
		/// /// <param name = "weeklyCardType">1-100档周卡2-50档周卡</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_userEO> GetByWeeklyCardType(int weeklyCardType, string sort_)
		{
			return GetByWeeklyCardType(weeklyCardType, 0, sort_, null);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByWeeklyCardTypeAsync(int weeklyCardType, string sort_)
		{
			return await GetByWeeklyCardTypeAsync(weeklyCardType, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 WeeklyCardType（字段） 查询
		/// </summary>
		/// /// <param name = "weeklyCardType">1-100档周卡2-50档周卡</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_userEO> GetByWeeklyCardType(int weeklyCardType, string sort_, TransactionManager tm_)
		{
			return GetByWeeklyCardType(weeklyCardType, 0, sort_, tm_);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByWeeklyCardTypeAsync(int weeklyCardType, string sort_, TransactionManager tm_)
		{
			return await GetByWeeklyCardTypeAsync(weeklyCardType, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 WeeklyCardType（字段） 查询
		/// </summary>
		/// /// <param name = "weeklyCardType">1-100档周卡2-50档周卡</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_userEO> GetByWeeklyCardType(int weeklyCardType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WeeklyCardType` = @WeeklyCardType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WeeklyCardType", weeklyCardType, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_weeklycard_userEO.MapDataReader);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByWeeklyCardTypeAsync(int weeklyCardType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WeeklyCardType` = @WeeklyCardType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WeeklyCardType", weeklyCardType, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_weeklycard_userEO.MapDataReader);
		}
		#endregion // GetByWeeklyCardType
		#region GetByFromId
		
		/// <summary>
		/// 按 FromId（字段） 查询
		/// </summary>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_userEO> GetByFromId(string fromId)
		{
			return GetByFromId(fromId, 0, string.Empty, null);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByFromIdAsync(string fromId)
		{
			return await GetByFromIdAsync(fromId, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FromId（字段） 查询
		/// </summary>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_userEO> GetByFromId(string fromId, TransactionManager tm_)
		{
			return GetByFromId(fromId, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByFromIdAsync(string fromId, TransactionManager tm_)
		{
			return await GetByFromIdAsync(fromId, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FromId（字段） 查询
		/// </summary>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_userEO> GetByFromId(string fromId, int top_)
		{
			return GetByFromId(fromId, top_, string.Empty, null);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByFromIdAsync(string fromId, int top_)
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
		public List<Sa_weeklycard_userEO> GetByFromId(string fromId, int top_, TransactionManager tm_)
		{
			return GetByFromId(fromId, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByFromIdAsync(string fromId, int top_, TransactionManager tm_)
		{
			return await GetByFromIdAsync(fromId, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FromId（字段） 查询
		/// </summary>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_userEO> GetByFromId(string fromId, string sort_)
		{
			return GetByFromId(fromId, 0, sort_, null);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByFromIdAsync(string fromId, string sort_)
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
		public List<Sa_weeklycard_userEO> GetByFromId(string fromId, string sort_, TransactionManager tm_)
		{
			return GetByFromId(fromId, 0, sort_, tm_);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByFromIdAsync(string fromId, string sort_, TransactionManager tm_)
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
		public List<Sa_weeklycard_userEO> GetByFromId(string fromId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FromId` = @FromId", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FromId", fromId, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_weeklycard_userEO.MapDataReader);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByFromIdAsync(string fromId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FromId` = @FromId", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FromId", fromId, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_weeklycard_userEO.MapDataReader);
		}
		#endregion // GetByFromId
		#region GetByFromMode
		
		/// <summary>
		/// 按 FromMode（字段） 查询
		/// </summary>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_userEO> GetByFromMode(int fromMode)
		{
			return GetByFromMode(fromMode, 0, string.Empty, null);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByFromModeAsync(int fromMode)
		{
			return await GetByFromModeAsync(fromMode, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FromMode（字段） 查询
		/// </summary>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_userEO> GetByFromMode(int fromMode, TransactionManager tm_)
		{
			return GetByFromMode(fromMode, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByFromModeAsync(int fromMode, TransactionManager tm_)
		{
			return await GetByFromModeAsync(fromMode, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FromMode（字段） 查询
		/// </summary>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_userEO> GetByFromMode(int fromMode, int top_)
		{
			return GetByFromMode(fromMode, top_, string.Empty, null);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByFromModeAsync(int fromMode, int top_)
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
		public List<Sa_weeklycard_userEO> GetByFromMode(int fromMode, int top_, TransactionManager tm_)
		{
			return GetByFromMode(fromMode, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByFromModeAsync(int fromMode, int top_, TransactionManager tm_)
		{
			return await GetByFromModeAsync(fromMode, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FromMode（字段） 查询
		/// </summary>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_userEO> GetByFromMode(int fromMode, string sort_)
		{
			return GetByFromMode(fromMode, 0, sort_, null);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByFromModeAsync(int fromMode, string sort_)
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
		public List<Sa_weeklycard_userEO> GetByFromMode(int fromMode, string sort_, TransactionManager tm_)
		{
			return GetByFromMode(fromMode, 0, sort_, tm_);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByFromModeAsync(int fromMode, string sort_, TransactionManager tm_)
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
		public List<Sa_weeklycard_userEO> GetByFromMode(int fromMode, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FromMode` = @FromMode", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FromMode", fromMode, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_weeklycard_userEO.MapDataReader);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByFromModeAsync(int fromMode, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FromMode` = @FromMode", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FromMode", fromMode, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_weeklycard_userEO.MapDataReader);
		}
		#endregion // GetByFromMode
		#region GetByPayAmount
		
		/// <summary>
		/// 按 PayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "payAmount">购买金额</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_userEO> GetByPayAmount(long payAmount)
		{
			return GetByPayAmount(payAmount, 0, string.Empty, null);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByPayAmountAsync(long payAmount)
		{
			return await GetByPayAmountAsync(payAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "payAmount">购买金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_userEO> GetByPayAmount(long payAmount, TransactionManager tm_)
		{
			return GetByPayAmount(payAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByPayAmountAsync(long payAmount, TransactionManager tm_)
		{
			return await GetByPayAmountAsync(payAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "payAmount">购买金额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_userEO> GetByPayAmount(long payAmount, int top_)
		{
			return GetByPayAmount(payAmount, top_, string.Empty, null);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByPayAmountAsync(long payAmount, int top_)
		{
			return await GetByPayAmountAsync(payAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "payAmount">购买金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_userEO> GetByPayAmount(long payAmount, int top_, TransactionManager tm_)
		{
			return GetByPayAmount(payAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByPayAmountAsync(long payAmount, int top_, TransactionManager tm_)
		{
			return await GetByPayAmountAsync(payAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "payAmount">购买金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_userEO> GetByPayAmount(long payAmount, string sort_)
		{
			return GetByPayAmount(payAmount, 0, sort_, null);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByPayAmountAsync(long payAmount, string sort_)
		{
			return await GetByPayAmountAsync(payAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "payAmount">购买金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_userEO> GetByPayAmount(long payAmount, string sort_, TransactionManager tm_)
		{
			return GetByPayAmount(payAmount, 0, sort_, tm_);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByPayAmountAsync(long payAmount, string sort_, TransactionManager tm_)
		{
			return await GetByPayAmountAsync(payAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "payAmount">购买金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_userEO> GetByPayAmount(long payAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PayAmount` = @PayAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PayAmount", payAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_weeklycard_userEO.MapDataReader);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByPayAmountAsync(long payAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PayAmount` = @PayAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PayAmount", payAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_weeklycard_userEO.MapDataReader);
		}
		#endregion // GetByPayAmount
		#region GetByFlowMultip
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">流水倍数</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_userEO> GetByFlowMultip(float flowMultip)
		{
			return GetByFlowMultip(flowMultip, 0, string.Empty, null);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByFlowMultipAsync(float flowMultip)
		{
			return await GetByFlowMultipAsync(flowMultip, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">流水倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_userEO> GetByFlowMultip(float flowMultip, TransactionManager tm_)
		{
			return GetByFlowMultip(flowMultip, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByFlowMultipAsync(float flowMultip, TransactionManager tm_)
		{
			return await GetByFlowMultipAsync(flowMultip, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">流水倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_userEO> GetByFlowMultip(float flowMultip, int top_)
		{
			return GetByFlowMultip(flowMultip, top_, string.Empty, null);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByFlowMultipAsync(float flowMultip, int top_)
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
		public List<Sa_weeklycard_userEO> GetByFlowMultip(float flowMultip, int top_, TransactionManager tm_)
		{
			return GetByFlowMultip(flowMultip, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByFlowMultipAsync(float flowMultip, int top_, TransactionManager tm_)
		{
			return await GetByFlowMultipAsync(flowMultip, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">流水倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_userEO> GetByFlowMultip(float flowMultip, string sort_)
		{
			return GetByFlowMultip(flowMultip, 0, sort_, null);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByFlowMultipAsync(float flowMultip, string sort_)
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
		public List<Sa_weeklycard_userEO> GetByFlowMultip(float flowMultip, string sort_, TransactionManager tm_)
		{
			return GetByFlowMultip(flowMultip, 0, sort_, tm_);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByFlowMultipAsync(float flowMultip, string sort_, TransactionManager tm_)
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
		public List<Sa_weeklycard_userEO> GetByFlowMultip(float flowMultip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FlowMultip` = @FlowMultip", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FlowMultip", flowMultip, MySqlDbType.Float));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_weeklycard_userEO.MapDataReader);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByFlowMultipAsync(float flowMultip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FlowMultip` = @FlowMultip", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FlowMultip", flowMultip, MySqlDbType.Float));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_weeklycard_userEO.MapDataReader);
		}
		#endregion // GetByFlowMultip
		#region GetByCycleStartDate
		
		/// <summary>
		/// 按 CycleStartDate（字段） 查询
		/// </summary>
		/// /// <param name = "cycleStartDate">周卡起始日期</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_userEO> GetByCycleStartDate(DateTime cycleStartDate)
		{
			return GetByCycleStartDate(cycleStartDate, 0, string.Empty, null);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByCycleStartDateAsync(DateTime cycleStartDate)
		{
			return await GetByCycleStartDateAsync(cycleStartDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CycleStartDate（字段） 查询
		/// </summary>
		/// /// <param name = "cycleStartDate">周卡起始日期</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_userEO> GetByCycleStartDate(DateTime cycleStartDate, TransactionManager tm_)
		{
			return GetByCycleStartDate(cycleStartDate, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByCycleStartDateAsync(DateTime cycleStartDate, TransactionManager tm_)
		{
			return await GetByCycleStartDateAsync(cycleStartDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CycleStartDate（字段） 查询
		/// </summary>
		/// /// <param name = "cycleStartDate">周卡起始日期</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_userEO> GetByCycleStartDate(DateTime cycleStartDate, int top_)
		{
			return GetByCycleStartDate(cycleStartDate, top_, string.Empty, null);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByCycleStartDateAsync(DateTime cycleStartDate, int top_)
		{
			return await GetByCycleStartDateAsync(cycleStartDate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CycleStartDate（字段） 查询
		/// </summary>
		/// /// <param name = "cycleStartDate">周卡起始日期</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_userEO> GetByCycleStartDate(DateTime cycleStartDate, int top_, TransactionManager tm_)
		{
			return GetByCycleStartDate(cycleStartDate, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByCycleStartDateAsync(DateTime cycleStartDate, int top_, TransactionManager tm_)
		{
			return await GetByCycleStartDateAsync(cycleStartDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CycleStartDate（字段） 查询
		/// </summary>
		/// /// <param name = "cycleStartDate">周卡起始日期</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_userEO> GetByCycleStartDate(DateTime cycleStartDate, string sort_)
		{
			return GetByCycleStartDate(cycleStartDate, 0, sort_, null);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByCycleStartDateAsync(DateTime cycleStartDate, string sort_)
		{
			return await GetByCycleStartDateAsync(cycleStartDate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CycleStartDate（字段） 查询
		/// </summary>
		/// /// <param name = "cycleStartDate">周卡起始日期</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_userEO> GetByCycleStartDate(DateTime cycleStartDate, string sort_, TransactionManager tm_)
		{
			return GetByCycleStartDate(cycleStartDate, 0, sort_, tm_);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByCycleStartDateAsync(DateTime cycleStartDate, string sort_, TransactionManager tm_)
		{
			return await GetByCycleStartDateAsync(cycleStartDate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CycleStartDate（字段） 查询
		/// </summary>
		/// /// <param name = "cycleStartDate">周卡起始日期</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_userEO> GetByCycleStartDate(DateTime cycleStartDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CycleStartDate` = @CycleStartDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CycleStartDate", cycleStartDate, MySqlDbType.Date));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_weeklycard_userEO.MapDataReader);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByCycleStartDateAsync(DateTime cycleStartDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CycleStartDate` = @CycleStartDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CycleStartDate", cycleStartDate, MySqlDbType.Date));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_weeklycard_userEO.MapDataReader);
		}
		#endregion // GetByCycleStartDate
		#region GetByCycleEndDate
		
		/// <summary>
		/// 按 CycleEndDate（字段） 查询
		/// </summary>
		/// /// <param name = "cycleEndDate">周卡截止日期</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_userEO> GetByCycleEndDate(DateTime cycleEndDate)
		{
			return GetByCycleEndDate(cycleEndDate, 0, string.Empty, null);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByCycleEndDateAsync(DateTime cycleEndDate)
		{
			return await GetByCycleEndDateAsync(cycleEndDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CycleEndDate（字段） 查询
		/// </summary>
		/// /// <param name = "cycleEndDate">周卡截止日期</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_userEO> GetByCycleEndDate(DateTime cycleEndDate, TransactionManager tm_)
		{
			return GetByCycleEndDate(cycleEndDate, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByCycleEndDateAsync(DateTime cycleEndDate, TransactionManager tm_)
		{
			return await GetByCycleEndDateAsync(cycleEndDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CycleEndDate（字段） 查询
		/// </summary>
		/// /// <param name = "cycleEndDate">周卡截止日期</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_userEO> GetByCycleEndDate(DateTime cycleEndDate, int top_)
		{
			return GetByCycleEndDate(cycleEndDate, top_, string.Empty, null);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByCycleEndDateAsync(DateTime cycleEndDate, int top_)
		{
			return await GetByCycleEndDateAsync(cycleEndDate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CycleEndDate（字段） 查询
		/// </summary>
		/// /// <param name = "cycleEndDate">周卡截止日期</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_userEO> GetByCycleEndDate(DateTime cycleEndDate, int top_, TransactionManager tm_)
		{
			return GetByCycleEndDate(cycleEndDate, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByCycleEndDateAsync(DateTime cycleEndDate, int top_, TransactionManager tm_)
		{
			return await GetByCycleEndDateAsync(cycleEndDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CycleEndDate（字段） 查询
		/// </summary>
		/// /// <param name = "cycleEndDate">周卡截止日期</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_userEO> GetByCycleEndDate(DateTime cycleEndDate, string sort_)
		{
			return GetByCycleEndDate(cycleEndDate, 0, sort_, null);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByCycleEndDateAsync(DateTime cycleEndDate, string sort_)
		{
			return await GetByCycleEndDateAsync(cycleEndDate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CycleEndDate（字段） 查询
		/// </summary>
		/// /// <param name = "cycleEndDate">周卡截止日期</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_userEO> GetByCycleEndDate(DateTime cycleEndDate, string sort_, TransactionManager tm_)
		{
			return GetByCycleEndDate(cycleEndDate, 0, sort_, tm_);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByCycleEndDateAsync(DateTime cycleEndDate, string sort_, TransactionManager tm_)
		{
			return await GetByCycleEndDateAsync(cycleEndDate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CycleEndDate（字段） 查询
		/// </summary>
		/// /// <param name = "cycleEndDate">周卡截止日期</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_userEO> GetByCycleEndDate(DateTime cycleEndDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CycleEndDate` = @CycleEndDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CycleEndDate", cycleEndDate, MySqlDbType.Date));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_weeklycard_userEO.MapDataReader);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByCycleEndDateAsync(DateTime cycleEndDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CycleEndDate` = @CycleEndDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CycleEndDate", cycleEndDate, MySqlDbType.Date));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_weeklycard_userEO.MapDataReader);
		}
		#endregion // GetByCycleEndDate
		#region GetByCountDownStart
		
		/// <summary>
		/// 按 CountDownStart（字段） 查询
		/// </summary>
		/// /// <param name = "countDownStart">购买周卡倒计时开始时间</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_userEO> GetByCountDownStart(DateTime countDownStart)
		{
			return GetByCountDownStart(countDownStart, 0, string.Empty, null);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByCountDownStartAsync(DateTime countDownStart)
		{
			return await GetByCountDownStartAsync(countDownStart, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CountDownStart（字段） 查询
		/// </summary>
		/// /// <param name = "countDownStart">购买周卡倒计时开始时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_userEO> GetByCountDownStart(DateTime countDownStart, TransactionManager tm_)
		{
			return GetByCountDownStart(countDownStart, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByCountDownStartAsync(DateTime countDownStart, TransactionManager tm_)
		{
			return await GetByCountDownStartAsync(countDownStart, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountDownStart（字段） 查询
		/// </summary>
		/// /// <param name = "countDownStart">购买周卡倒计时开始时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_userEO> GetByCountDownStart(DateTime countDownStart, int top_)
		{
			return GetByCountDownStart(countDownStart, top_, string.Empty, null);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByCountDownStartAsync(DateTime countDownStart, int top_)
		{
			return await GetByCountDownStartAsync(countDownStart, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CountDownStart（字段） 查询
		/// </summary>
		/// /// <param name = "countDownStart">购买周卡倒计时开始时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_userEO> GetByCountDownStart(DateTime countDownStart, int top_, TransactionManager tm_)
		{
			return GetByCountDownStart(countDownStart, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByCountDownStartAsync(DateTime countDownStart, int top_, TransactionManager tm_)
		{
			return await GetByCountDownStartAsync(countDownStart, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountDownStart（字段） 查询
		/// </summary>
		/// /// <param name = "countDownStart">购买周卡倒计时开始时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_userEO> GetByCountDownStart(DateTime countDownStart, string sort_)
		{
			return GetByCountDownStart(countDownStart, 0, sort_, null);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByCountDownStartAsync(DateTime countDownStart, string sort_)
		{
			return await GetByCountDownStartAsync(countDownStart, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CountDownStart（字段） 查询
		/// </summary>
		/// /// <param name = "countDownStart">购买周卡倒计时开始时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_userEO> GetByCountDownStart(DateTime countDownStart, string sort_, TransactionManager tm_)
		{
			return GetByCountDownStart(countDownStart, 0, sort_, tm_);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByCountDownStartAsync(DateTime countDownStart, string sort_, TransactionManager tm_)
		{
			return await GetByCountDownStartAsync(countDownStart, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CountDownStart（字段） 查询
		/// </summary>
		/// /// <param name = "countDownStart">购买周卡倒计时开始时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_userEO> GetByCountDownStart(DateTime countDownStart, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CountDownStart` = @CountDownStart", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CountDownStart", countDownStart, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_weeklycard_userEO.MapDataReader);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByCountDownStartAsync(DateTime countDownStart, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CountDownStart` = @CountDownStart", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CountDownStart", countDownStart, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_weeklycard_userEO.MapDataReader);
		}
		#endregion // GetByCountDownStart
		#region GetByIsBuyWeeklyCard
		
		/// <summary>
		/// 按 IsBuyWeeklyCard（字段） 查询
		/// </summary>
		/// /// <param name = "isBuyWeeklyCard">是否购买周卡</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_userEO> GetByIsBuyWeeklyCard(bool isBuyWeeklyCard)
		{
			return GetByIsBuyWeeklyCard(isBuyWeeklyCard, 0, string.Empty, null);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByIsBuyWeeklyCardAsync(bool isBuyWeeklyCard)
		{
			return await GetByIsBuyWeeklyCardAsync(isBuyWeeklyCard, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsBuyWeeklyCard（字段） 查询
		/// </summary>
		/// /// <param name = "isBuyWeeklyCard">是否购买周卡</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_userEO> GetByIsBuyWeeklyCard(bool isBuyWeeklyCard, TransactionManager tm_)
		{
			return GetByIsBuyWeeklyCard(isBuyWeeklyCard, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByIsBuyWeeklyCardAsync(bool isBuyWeeklyCard, TransactionManager tm_)
		{
			return await GetByIsBuyWeeklyCardAsync(isBuyWeeklyCard, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsBuyWeeklyCard（字段） 查询
		/// </summary>
		/// /// <param name = "isBuyWeeklyCard">是否购买周卡</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_userEO> GetByIsBuyWeeklyCard(bool isBuyWeeklyCard, int top_)
		{
			return GetByIsBuyWeeklyCard(isBuyWeeklyCard, top_, string.Empty, null);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByIsBuyWeeklyCardAsync(bool isBuyWeeklyCard, int top_)
		{
			return await GetByIsBuyWeeklyCardAsync(isBuyWeeklyCard, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsBuyWeeklyCard（字段） 查询
		/// </summary>
		/// /// <param name = "isBuyWeeklyCard">是否购买周卡</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_userEO> GetByIsBuyWeeklyCard(bool isBuyWeeklyCard, int top_, TransactionManager tm_)
		{
			return GetByIsBuyWeeklyCard(isBuyWeeklyCard, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByIsBuyWeeklyCardAsync(bool isBuyWeeklyCard, int top_, TransactionManager tm_)
		{
			return await GetByIsBuyWeeklyCardAsync(isBuyWeeklyCard, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsBuyWeeklyCard（字段） 查询
		/// </summary>
		/// /// <param name = "isBuyWeeklyCard">是否购买周卡</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_userEO> GetByIsBuyWeeklyCard(bool isBuyWeeklyCard, string sort_)
		{
			return GetByIsBuyWeeklyCard(isBuyWeeklyCard, 0, sort_, null);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByIsBuyWeeklyCardAsync(bool isBuyWeeklyCard, string sort_)
		{
			return await GetByIsBuyWeeklyCardAsync(isBuyWeeklyCard, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 IsBuyWeeklyCard（字段） 查询
		/// </summary>
		/// /// <param name = "isBuyWeeklyCard">是否购买周卡</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_userEO> GetByIsBuyWeeklyCard(bool isBuyWeeklyCard, string sort_, TransactionManager tm_)
		{
			return GetByIsBuyWeeklyCard(isBuyWeeklyCard, 0, sort_, tm_);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByIsBuyWeeklyCardAsync(bool isBuyWeeklyCard, string sort_, TransactionManager tm_)
		{
			return await GetByIsBuyWeeklyCardAsync(isBuyWeeklyCard, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 IsBuyWeeklyCard（字段） 查询
		/// </summary>
		/// /// <param name = "isBuyWeeklyCard">是否购买周卡</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_userEO> GetByIsBuyWeeklyCard(bool isBuyWeeklyCard, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsBuyWeeklyCard` = @IsBuyWeeklyCard", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsBuyWeeklyCard", isBuyWeeklyCard, MySqlDbType.Byte));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_weeklycard_userEO.MapDataReader);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByIsBuyWeeklyCardAsync(bool isBuyWeeklyCard, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsBuyWeeklyCard` = @IsBuyWeeklyCard", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsBuyWeeklyCard", isBuyWeeklyCard, MySqlDbType.Byte));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_weeklycard_userEO.MapDataReader);
		}
		#endregion // GetByIsBuyWeeklyCard
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">购买时间</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_userEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">购买时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_userEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">购买时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_userEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByRecDateAsync(DateTime recDate, int top_)
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
		public List<Sa_weeklycard_userEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">购买时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_userEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByRecDateAsync(DateTime recDate, string sort_)
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
		public List<Sa_weeklycard_userEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
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
		public List<Sa_weeklycard_userEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_weeklycard_userEO.MapDataReader);
		}
		public async Task<List<Sa_weeklycard_userEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_weeklycard_userEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
