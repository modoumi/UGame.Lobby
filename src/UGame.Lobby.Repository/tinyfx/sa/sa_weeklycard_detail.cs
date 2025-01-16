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
	/// 1.7版周卡奖励明细
	/// 【表 sa_weeklycard_detail 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Sa_weeklycard_detailEO : IRowMapper<Sa_weeklycard_detailEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Sa_weeklycard_detailEO()
		{
			this.WeeklyCardType = 0;
			this.Bonus = 0;
			this.FlowMultip = 1.00f;
			this.CurrentCycleNumber = 0;
			this.RecDate = DateTime.Now;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private DateTime _originalDayId;
		/// <summary>
		/// 【数据库中的原始主键 DayId 值的副本，用于主键值更新】
		/// </summary>
		public DateTime OriginalDayId
		{
			get { return _originalDayId; }
			set { HasOriginal = true; _originalDayId = value; }
		}
		
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
	        return new Dictionary<string, object>() { { "DayId", DayId },  { "UserId", UserId }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 领取日期
		/// 【主键 date】
		/// </summary>
		[DataMember(Order = 1)]
		public DateTime DayId { get; set; }
		/// <summary>
		/// 用户编码
		/// 【主键 varchar(36)】
		/// </summary>
		[DataMember(Order = 2)]
		public string UserId { get; set; }
		/// <summary>
		/// 1-100档周卡2-50档周卡
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 3)]
		public int WeeklyCardType { get; set; }
		/// <summary>
		/// 奖励金额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 4)]
		public long Bonus { get; set; }
		/// <summary>
		/// 流水倍数
		/// 【字段 float(10,2)】
		/// </summary>
		[DataMember(Order = 5)]
		public float FlowMultip { get; set; }
		/// <summary>
		/// 当前第几天领奖
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 6)]
		public int CurrentCycleNumber { get; set; }
		/// <summary>
		/// 周卡起始日期
		/// 【字段 date】
		/// </summary>
		[DataMember(Order = 7)]
		public DateTime CycleStartDate { get; set; }
		/// <summary>
		/// 周卡截止日期
		/// 【字段 date】
		/// </summary>
		[DataMember(Order = 8)]
		public DateTime CycleEndDate { get; set; }
		/// <summary>
		/// 签到时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 9)]
		public DateTime RecDate { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Sa_weeklycard_detailEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Sa_weeklycard_detailEO MapDataReader(IDataReader reader)
		{
		    Sa_weeklycard_detailEO ret = new Sa_weeklycard_detailEO();
			ret.DayId = reader.ToDateTime("DayId");
			ret.OriginalDayId = ret.DayId;
			ret.UserId = reader.ToString("UserId");
			ret.OriginalUserId = ret.UserId;
			ret.WeeklyCardType = reader.ToInt32("WeeklyCardType");
			ret.Bonus = reader.ToInt64("Bonus");
			ret.FlowMultip = reader.ToSingle("FlowMultip");
			ret.CurrentCycleNumber = reader.ToInt32("CurrentCycleNumber");
			ret.CycleStartDate = reader.ToDateTime("CycleStartDate");
			ret.CycleEndDate = reader.ToDateTime("CycleEndDate");
			ret.RecDate = reader.ToDateTime("RecDate");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 1.7版周卡奖励明细
	/// 【表 sa_weeklycard_detail 的操作类】
	/// </summary>
	[Obsolete]
	public class Sa_weeklycard_detailMO : MySqlTableMO<Sa_weeklycard_detailEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`sa_weeklycard_detail`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Sa_weeklycard_detailMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Sa_weeklycard_detailMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Sa_weeklycard_detailMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Sa_weeklycard_detailEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Sa_weeklycard_detailEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Sa_weeklycard_detailEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`DayId`, `UserId`, `WeeklyCardType`, `Bonus`, `FlowMultip`, `CurrentCycleNumber`, `CycleStartDate`, `CycleEndDate`, `RecDate`) VALUE (@DayId, @UserId, @WeeklyCardType, @Bonus, @FlowMultip, @CurrentCycleNumber, @CycleStartDate, @CycleEndDate, @RecDate);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", item.DayId, MySqlDbType.Date),
				Database.CreateInParameter("@UserId", item.UserId, MySqlDbType.VarChar),
				Database.CreateInParameter("@WeeklyCardType", item.WeeklyCardType, MySqlDbType.Int32),
				Database.CreateInParameter("@Bonus", item.Bonus, MySqlDbType.Int64),
				Database.CreateInParameter("@FlowMultip", item.FlowMultip, MySqlDbType.Float),
				Database.CreateInParameter("@CurrentCycleNumber", item.CurrentCycleNumber, MySqlDbType.Int32),
				Database.CreateInParameter("@CycleStartDate", item.CycleStartDate, MySqlDbType.Date),
				Database.CreateInParameter("@CycleEndDate", item.CycleEndDate, MySqlDbType.Date),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
			};
		}
		public int AddByBatch(IEnumerable<Sa_weeklycard_detailEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Sa_weeklycard_detailEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sa_weeklycard_detailEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`DayId`, `UserId`, `WeeklyCardType`, `Bonus`, `FlowMultip`, `CurrentCycleNumber`, `CycleStartDate`, `CycleEndDate`, `RecDate`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.DayId.ToString("yyyy-MM-dd HH:mm:ss")}','{item.UserId}',{item.WeeklyCardType},{item.Bonus},{item.FlowMultip},{item.CurrentCycleNumber},'{item.CycleStartDate.ToString("yyyy-MM-dd HH:mm:ss")}','{item.CycleEndDate.ToString("yyyy-MM-dd HH:mm:ss")}','{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
		/// /// <param name = "dayId">领取日期</param>
		/// /// <param name = "userId">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(DateTime dayId, string userId, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(dayId, userId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(DateTime dayId, string userId, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(dayId, userId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(DateTime dayId, string userId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `DayId` = @DayId AND `UserId` = @UserId";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Sa_weeklycard_detailEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.DayId, item.UserId, tm_);
		}
		public async Task<int> RemoveAsync(Sa_weeklycard_detailEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.DayId, item.UserId, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByDayId
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "dayId">领取日期</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByDayId(DateTime dayId, TransactionManager tm_ = null)
		{
			RepairRemoveByDayIdData(dayId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByDayIdAsync(DateTime dayId, TransactionManager tm_ = null)
		{
			RepairRemoveByDayIdData(dayId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByDayIdData(DateTime dayId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `DayId` = @DayId";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date));
		}
		#endregion // RemoveByDayId
		#region RemoveByUserId
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "userId">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByUserId(string userId, TransactionManager tm_ = null)
		{
			RepairRemoveByUserIdData(userId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByUserIdAsync(string userId, TransactionManager tm_ = null)
		{
			RepairRemoveByUserIdData(userId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByUserIdData(string userId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `UserId` = @UserId";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar));
		}
		#endregion // RemoveByUserId
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
		#region RemoveByBonus
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "bonus">奖励金额</param>
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
		#region RemoveByCurrentCycleNumber
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "currentCycleNumber">当前第几天领奖</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCurrentCycleNumber(int currentCycleNumber, TransactionManager tm_ = null)
		{
			RepairRemoveByCurrentCycleNumberData(currentCycleNumber, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCurrentCycleNumberAsync(int currentCycleNumber, TransactionManager tm_ = null)
		{
			RepairRemoveByCurrentCycleNumberData(currentCycleNumber, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCurrentCycleNumberData(int currentCycleNumber, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `CurrentCycleNumber` = @CurrentCycleNumber";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrentCycleNumber", currentCycleNumber, MySqlDbType.Int32));
		}
		#endregion // RemoveByCurrentCycleNumber
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
		#region RemoveByRecDate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "recDate">签到时间</param>
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
		public int Put(Sa_weeklycard_detailEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Sa_weeklycard_detailEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Sa_weeklycard_detailEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `DayId` = @DayId, `UserId` = @UserId, `WeeklyCardType` = @WeeklyCardType, `Bonus` = @Bonus, `FlowMultip` = @FlowMultip, `CurrentCycleNumber` = @CurrentCycleNumber, `CycleStartDate` = @CycleStartDate, `CycleEndDate` = @CycleEndDate WHERE `DayId` = @DayId_Original AND `UserId` = @UserId_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", item.DayId, MySqlDbType.Date),
				Database.CreateInParameter("@UserId", item.UserId, MySqlDbType.VarChar),
				Database.CreateInParameter("@WeeklyCardType", item.WeeklyCardType, MySqlDbType.Int32),
				Database.CreateInParameter("@Bonus", item.Bonus, MySqlDbType.Int64),
				Database.CreateInParameter("@FlowMultip", item.FlowMultip, MySqlDbType.Float),
				Database.CreateInParameter("@CurrentCycleNumber", item.CurrentCycleNumber, MySqlDbType.Int32),
				Database.CreateInParameter("@CycleStartDate", item.CycleStartDate, MySqlDbType.Date),
				Database.CreateInParameter("@CycleEndDate", item.CycleEndDate, MySqlDbType.Date),
				Database.CreateInParameter("@DayId_Original", item.HasOriginal ? item.OriginalDayId : item.DayId, MySqlDbType.Date),
				Database.CreateInParameter("@UserId_Original", item.HasOriginal ? item.OriginalUserId : item.UserId, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Sa_weeklycard_detailEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Sa_weeklycard_detailEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "dayId">领取日期</param>
		/// /// <param name = "userId">用户编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(DateTime dayId, string userId, string set_, params object[] values_)
		{
			return Put(set_, "`DayId` = @DayId AND `UserId` = @UserId", ConcatValues(values_, dayId, userId));
		}
		public async Task<int> PutByPKAsync(DateTime dayId, string userId, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`DayId` = @DayId AND `UserId` = @UserId", ConcatValues(values_, dayId, userId));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "dayId">领取日期</param>
		/// /// <param name = "userId">用户编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(DateTime dayId, string userId, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`DayId` = @DayId AND `UserId` = @UserId", tm_, ConcatValues(values_, dayId, userId));
		}
		public async Task<int> PutByPKAsync(DateTime dayId, string userId, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`DayId` = @DayId AND `UserId` = @UserId", tm_, ConcatValues(values_, dayId, userId));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "dayId">领取日期</param>
		/// /// <param name = "userId">用户编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(DateTime dayId, string userId, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
	        };
			return Put(set_, "`DayId` = @DayId AND `UserId` = @UserId", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(DateTime dayId, string userId, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`DayId` = @DayId AND `UserId` = @UserId", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutDayId
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "dayId">领取日期</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutDayId(DateTime dayId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `DayId` = @DayId";
			var parameter_ = Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutDayIdAsync(DateTime dayId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `DayId` = @DayId";
			var parameter_ = Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutDayId
		#region PutUserId
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "userId">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserId(string userId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserId` = @UserId";
			var parameter_ = Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutUserIdAsync(string userId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserId` = @UserId";
			var parameter_ = Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutUserId
		#region PutWeeklyCardType
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayId">领取日期</param>
		/// /// <param name = "userId">用户编码</param>
		/// /// <param name = "weeklyCardType">1-100档周卡2-50档周卡</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWeeklyCardTypeByPK(DateTime dayId, string userId, int weeklyCardType, TransactionManager tm_ = null)
		{
			RepairPutWeeklyCardTypeByPKData(dayId, userId, weeklyCardType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutWeeklyCardTypeByPKAsync(DateTime dayId, string userId, int weeklyCardType, TransactionManager tm_ = null)
		{
			RepairPutWeeklyCardTypeByPKData(dayId, userId, weeklyCardType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutWeeklyCardTypeByPKData(DateTime dayId, string userId, int weeklyCardType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `WeeklyCardType` = @WeeklyCardType  WHERE `DayId` = @DayId AND `UserId` = @UserId";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@WeeklyCardType", weeklyCardType, MySqlDbType.Int32),
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
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
		#region PutBonus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayId">领取日期</param>
		/// /// <param name = "userId">用户编码</param>
		/// /// <param name = "bonus">奖励金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBonusByPK(DateTime dayId, string userId, long bonus, TransactionManager tm_ = null)
		{
			RepairPutBonusByPKData(dayId, userId, bonus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBonusByPKAsync(DateTime dayId, string userId, long bonus, TransactionManager tm_ = null)
		{
			RepairPutBonusByPKData(dayId, userId, bonus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBonusByPKData(DateTime dayId, string userId, long bonus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Bonus` = @Bonus  WHERE `DayId` = @DayId AND `UserId` = @UserId";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Bonus", bonus, MySqlDbType.Int64),
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "bonus">奖励金额</param>
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
		/// /// <param name = "dayId">领取日期</param>
		/// /// <param name = "userId">用户编码</param>
		/// /// <param name = "flowMultip">流水倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFlowMultipByPK(DateTime dayId, string userId, float flowMultip, TransactionManager tm_ = null)
		{
			RepairPutFlowMultipByPKData(dayId, userId, flowMultip, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFlowMultipByPKAsync(DateTime dayId, string userId, float flowMultip, TransactionManager tm_ = null)
		{
			RepairPutFlowMultipByPKData(dayId, userId, flowMultip, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFlowMultipByPKData(DateTime dayId, string userId, float flowMultip, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `FlowMultip` = @FlowMultip  WHERE `DayId` = @DayId AND `UserId` = @UserId";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@FlowMultip", flowMultip, MySqlDbType.Float),
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
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
		#region PutCurrentCycleNumber
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayId">领取日期</param>
		/// /// <param name = "userId">用户编码</param>
		/// /// <param name = "currentCycleNumber">当前第几天领奖</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCurrentCycleNumberByPK(DateTime dayId, string userId, int currentCycleNumber, TransactionManager tm_ = null)
		{
			RepairPutCurrentCycleNumberByPKData(dayId, userId, currentCycleNumber, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCurrentCycleNumberByPKAsync(DateTime dayId, string userId, int currentCycleNumber, TransactionManager tm_ = null)
		{
			RepairPutCurrentCycleNumberByPKData(dayId, userId, currentCycleNumber, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCurrentCycleNumberByPKData(DateTime dayId, string userId, int currentCycleNumber, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CurrentCycleNumber` = @CurrentCycleNumber  WHERE `DayId` = @DayId AND `UserId` = @UserId";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CurrentCycleNumber", currentCycleNumber, MySqlDbType.Int32),
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "currentCycleNumber">当前第几天领奖</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCurrentCycleNumber(int currentCycleNumber, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CurrentCycleNumber` = @CurrentCycleNumber";
			var parameter_ = Database.CreateInParameter("@CurrentCycleNumber", currentCycleNumber, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCurrentCycleNumberAsync(int currentCycleNumber, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CurrentCycleNumber` = @CurrentCycleNumber";
			var parameter_ = Database.CreateInParameter("@CurrentCycleNumber", currentCycleNumber, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCurrentCycleNumber
		#region PutCycleStartDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayId">领取日期</param>
		/// /// <param name = "userId">用户编码</param>
		/// /// <param name = "cycleStartDate">周卡起始日期</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCycleStartDateByPK(DateTime dayId, string userId, DateTime cycleStartDate, TransactionManager tm_ = null)
		{
			RepairPutCycleStartDateByPKData(dayId, userId, cycleStartDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCycleStartDateByPKAsync(DateTime dayId, string userId, DateTime cycleStartDate, TransactionManager tm_ = null)
		{
			RepairPutCycleStartDateByPKData(dayId, userId, cycleStartDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCycleStartDateByPKData(DateTime dayId, string userId, DateTime cycleStartDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CycleStartDate` = @CycleStartDate  WHERE `DayId` = @DayId AND `UserId` = @UserId";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CycleStartDate", cycleStartDate, MySqlDbType.Date),
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
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
		/// /// <param name = "dayId">领取日期</param>
		/// /// <param name = "userId">用户编码</param>
		/// /// <param name = "cycleEndDate">周卡截止日期</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCycleEndDateByPK(DateTime dayId, string userId, DateTime cycleEndDate, TransactionManager tm_ = null)
		{
			RepairPutCycleEndDateByPKData(dayId, userId, cycleEndDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCycleEndDateByPKAsync(DateTime dayId, string userId, DateTime cycleEndDate, TransactionManager tm_ = null)
		{
			RepairPutCycleEndDateByPKData(dayId, userId, cycleEndDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCycleEndDateByPKData(DateTime dayId, string userId, DateTime cycleEndDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CycleEndDate` = @CycleEndDate  WHERE `DayId` = @DayId AND `UserId` = @UserId";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CycleEndDate", cycleEndDate, MySqlDbType.Date),
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
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
		#region PutRecDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayId">领取日期</param>
		/// /// <param name = "userId">用户编码</param>
		/// /// <param name = "recDate">签到时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(DateTime dayId, string userId, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(dayId, userId, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(DateTime dayId, string userId, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(dayId, userId, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(DateTime dayId, string userId, DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `DayId` = @DayId AND `UserId` = @UserId";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "recDate">签到时间</param>
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
		public bool Set(Sa_weeklycard_detailEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.DayId, item.UserId) == null)
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
		public async Task<bool> SetAsync(Sa_weeklycard_detailEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.DayId, item.UserId) == null)
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
		/// /// <param name = "dayId">领取日期</param>
		/// /// <param name = "userId">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Sa_weeklycard_detailEO GetByPK(DateTime dayId, string userId, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(dayId, userId, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sa_weeklycard_detailEO.MapDataReader);
		}
		public async Task<Sa_weeklycard_detailEO> GetByPKAsync(DateTime dayId, string userId, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(dayId, userId, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sa_weeklycard_detailEO.MapDataReader);
		}
		private void RepairGetByPKData(DateTime dayId, string userId, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`DayId` = @DayId AND `UserId` = @UserId", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 DayId（字段）
		/// </summary>
		/// /// <param name = "dayId">领取日期</param>
		/// /// <param name = "userId">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetDayIdByPK(DateTime dayId, string userId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`DayId`", "`DayId` = @DayId AND `UserId` = @UserId", paras_, tm_);
		}
		public async Task<DateTime> GetDayIdByPKAsync(DateTime dayId, string userId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`DayId`", "`DayId` = @DayId AND `UserId` = @UserId", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 UserId（字段）
		/// </summary>
		/// /// <param name = "dayId">领取日期</param>
		/// /// <param name = "userId">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetUserIdByPK(DateTime dayId, string userId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`UserId`", "`DayId` = @DayId AND `UserId` = @UserId", paras_, tm_);
		}
		public async Task<string> GetUserIdByPKAsync(DateTime dayId, string userId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`UserId`", "`DayId` = @DayId AND `UserId` = @UserId", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 WeeklyCardType（字段）
		/// </summary>
		/// /// <param name = "dayId">领取日期</param>
		/// /// <param name = "userId">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetWeeklyCardTypeByPK(DateTime dayId, string userId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`WeeklyCardType`", "`DayId` = @DayId AND `UserId` = @UserId", paras_, tm_);
		}
		public async Task<int> GetWeeklyCardTypeByPKAsync(DateTime dayId, string userId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`WeeklyCardType`", "`DayId` = @DayId AND `UserId` = @UserId", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Bonus（字段）
		/// </summary>
		/// /// <param name = "dayId">领取日期</param>
		/// /// <param name = "userId">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetBonusByPK(DateTime dayId, string userId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`Bonus`", "`DayId` = @DayId AND `UserId` = @UserId", paras_, tm_);
		}
		public async Task<long> GetBonusByPKAsync(DateTime dayId, string userId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`Bonus`", "`DayId` = @DayId AND `UserId` = @UserId", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 FlowMultip（字段）
		/// </summary>
		/// /// <param name = "dayId">领取日期</param>
		/// /// <param name = "userId">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public float GetFlowMultipByPK(DateTime dayId, string userId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
			return (float)GetScalar("`FlowMultip`", "`DayId` = @DayId AND `UserId` = @UserId", paras_, tm_);
		}
		public async Task<float> GetFlowMultipByPKAsync(DateTime dayId, string userId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
			return (float)await GetScalarAsync("`FlowMultip`", "`DayId` = @DayId AND `UserId` = @UserId", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CurrentCycleNumber（字段）
		/// </summary>
		/// /// <param name = "dayId">领取日期</param>
		/// /// <param name = "userId">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetCurrentCycleNumberByPK(DateTime dayId, string userId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`CurrentCycleNumber`", "`DayId` = @DayId AND `UserId` = @UserId", paras_, tm_);
		}
		public async Task<int> GetCurrentCycleNumberByPKAsync(DateTime dayId, string userId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`CurrentCycleNumber`", "`DayId` = @DayId AND `UserId` = @UserId", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CycleStartDate（字段）
		/// </summary>
		/// /// <param name = "dayId">领取日期</param>
		/// /// <param name = "userId">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetCycleStartDateByPK(DateTime dayId, string userId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`CycleStartDate`", "`DayId` = @DayId AND `UserId` = @UserId", paras_, tm_);
		}
		public async Task<DateTime> GetCycleStartDateByPKAsync(DateTime dayId, string userId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`CycleStartDate`", "`DayId` = @DayId AND `UserId` = @UserId", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CycleEndDate（字段）
		/// </summary>
		/// /// <param name = "dayId">领取日期</param>
		/// /// <param name = "userId">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetCycleEndDateByPK(DateTime dayId, string userId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`CycleEndDate`", "`DayId` = @DayId AND `UserId` = @UserId", paras_, tm_);
		}
		public async Task<DateTime> GetCycleEndDateByPKAsync(DateTime dayId, string userId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`CycleEndDate`", "`DayId` = @DayId AND `UserId` = @UserId", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "dayId">领取日期</param>
		/// /// <param name = "userId">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetRecDateByPK(DateTime dayId, string userId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`RecDate`", "`DayId` = @DayId AND `UserId` = @UserId", paras_, tm_);
		}
		public async Task<DateTime> GetRecDateByPKAsync(DateTime dayId, string userId, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`RecDate`", "`DayId` = @DayId AND `UserId` = @UserId", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByDayId
		
		/// <summary>
		/// 按 DayId（字段） 查询
		/// </summary>
		/// /// <param name = "dayId">领取日期</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_detailEO> GetByDayId(DateTime dayId)
		{
			return GetByDayId(dayId, 0, string.Empty, null);
		}
		public async Task<List<Sa_weeklycard_detailEO>> GetByDayIdAsync(DateTime dayId)
		{
			return await GetByDayIdAsync(dayId, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DayId（字段） 查询
		/// </summary>
		/// /// <param name = "dayId">领取日期</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_detailEO> GetByDayId(DateTime dayId, TransactionManager tm_)
		{
			return GetByDayId(dayId, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_weeklycard_detailEO>> GetByDayIdAsync(DateTime dayId, TransactionManager tm_)
		{
			return await GetByDayIdAsync(dayId, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DayId（字段） 查询
		/// </summary>
		/// /// <param name = "dayId">领取日期</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_detailEO> GetByDayId(DateTime dayId, int top_)
		{
			return GetByDayId(dayId, top_, string.Empty, null);
		}
		public async Task<List<Sa_weeklycard_detailEO>> GetByDayIdAsync(DateTime dayId, int top_)
		{
			return await GetByDayIdAsync(dayId, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DayId（字段） 查询
		/// </summary>
		/// /// <param name = "dayId">领取日期</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_detailEO> GetByDayId(DateTime dayId, int top_, TransactionManager tm_)
		{
			return GetByDayId(dayId, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_weeklycard_detailEO>> GetByDayIdAsync(DateTime dayId, int top_, TransactionManager tm_)
		{
			return await GetByDayIdAsync(dayId, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DayId（字段） 查询
		/// </summary>
		/// /// <param name = "dayId">领取日期</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_detailEO> GetByDayId(DateTime dayId, string sort_)
		{
			return GetByDayId(dayId, 0, sort_, null);
		}
		public async Task<List<Sa_weeklycard_detailEO>> GetByDayIdAsync(DateTime dayId, string sort_)
		{
			return await GetByDayIdAsync(dayId, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DayId（字段） 查询
		/// </summary>
		/// /// <param name = "dayId">领取日期</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_detailEO> GetByDayId(DateTime dayId, string sort_, TransactionManager tm_)
		{
			return GetByDayId(dayId, 0, sort_, tm_);
		}
		public async Task<List<Sa_weeklycard_detailEO>> GetByDayIdAsync(DateTime dayId, string sort_, TransactionManager tm_)
		{
			return await GetByDayIdAsync(dayId, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DayId（字段） 查询
		/// </summary>
		/// /// <param name = "dayId">领取日期</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_detailEO> GetByDayId(DateTime dayId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DayId` = @DayId", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_weeklycard_detailEO.MapDataReader);
		}
		public async Task<List<Sa_weeklycard_detailEO>> GetByDayIdAsync(DateTime dayId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DayId` = @DayId", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_weeklycard_detailEO.MapDataReader);
		}
		#endregion // GetByDayId
		#region GetByUserId
		
		/// <summary>
		/// 按 UserId（字段） 查询
		/// </summary>
		/// /// <param name = "userId">用户编码</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_detailEO> GetByUserId(string userId)
		{
			return GetByUserId(userId, 0, string.Empty, null);
		}
		public async Task<List<Sa_weeklycard_detailEO>> GetByUserIdAsync(string userId)
		{
			return await GetByUserIdAsync(userId, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserId（字段） 查询
		/// </summary>
		/// /// <param name = "userId">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_detailEO> GetByUserId(string userId, TransactionManager tm_)
		{
			return GetByUserId(userId, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_weeklycard_detailEO>> GetByUserIdAsync(string userId, TransactionManager tm_)
		{
			return await GetByUserIdAsync(userId, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserId（字段） 查询
		/// </summary>
		/// /// <param name = "userId">用户编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_detailEO> GetByUserId(string userId, int top_)
		{
			return GetByUserId(userId, top_, string.Empty, null);
		}
		public async Task<List<Sa_weeklycard_detailEO>> GetByUserIdAsync(string userId, int top_)
		{
			return await GetByUserIdAsync(userId, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserId（字段） 查询
		/// </summary>
		/// /// <param name = "userId">用户编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_detailEO> GetByUserId(string userId, int top_, TransactionManager tm_)
		{
			return GetByUserId(userId, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_weeklycard_detailEO>> GetByUserIdAsync(string userId, int top_, TransactionManager tm_)
		{
			return await GetByUserIdAsync(userId, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserId（字段） 查询
		/// </summary>
		/// /// <param name = "userId">用户编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_detailEO> GetByUserId(string userId, string sort_)
		{
			return GetByUserId(userId, 0, sort_, null);
		}
		public async Task<List<Sa_weeklycard_detailEO>> GetByUserIdAsync(string userId, string sort_)
		{
			return await GetByUserIdAsync(userId, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 UserId（字段） 查询
		/// </summary>
		/// /// <param name = "userId">用户编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_detailEO> GetByUserId(string userId, string sort_, TransactionManager tm_)
		{
			return GetByUserId(userId, 0, sort_, tm_);
		}
		public async Task<List<Sa_weeklycard_detailEO>> GetByUserIdAsync(string userId, string sort_, TransactionManager tm_)
		{
			return await GetByUserIdAsync(userId, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 UserId（字段） 查询
		/// </summary>
		/// /// <param name = "userId">用户编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_detailEO> GetByUserId(string userId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserId` = @UserId", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_weeklycard_detailEO.MapDataReader);
		}
		public async Task<List<Sa_weeklycard_detailEO>> GetByUserIdAsync(string userId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserId` = @UserId", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserId", userId, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_weeklycard_detailEO.MapDataReader);
		}
		#endregion // GetByUserId
		#region GetByWeeklyCardType
		
		/// <summary>
		/// 按 WeeklyCardType（字段） 查询
		/// </summary>
		/// /// <param name = "weeklyCardType">1-100档周卡2-50档周卡</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_detailEO> GetByWeeklyCardType(int weeklyCardType)
		{
			return GetByWeeklyCardType(weeklyCardType, 0, string.Empty, null);
		}
		public async Task<List<Sa_weeklycard_detailEO>> GetByWeeklyCardTypeAsync(int weeklyCardType)
		{
			return await GetByWeeklyCardTypeAsync(weeklyCardType, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WeeklyCardType（字段） 查询
		/// </summary>
		/// /// <param name = "weeklyCardType">1-100档周卡2-50档周卡</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_detailEO> GetByWeeklyCardType(int weeklyCardType, TransactionManager tm_)
		{
			return GetByWeeklyCardType(weeklyCardType, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_weeklycard_detailEO>> GetByWeeklyCardTypeAsync(int weeklyCardType, TransactionManager tm_)
		{
			return await GetByWeeklyCardTypeAsync(weeklyCardType, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WeeklyCardType（字段） 查询
		/// </summary>
		/// /// <param name = "weeklyCardType">1-100档周卡2-50档周卡</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_detailEO> GetByWeeklyCardType(int weeklyCardType, int top_)
		{
			return GetByWeeklyCardType(weeklyCardType, top_, string.Empty, null);
		}
		public async Task<List<Sa_weeklycard_detailEO>> GetByWeeklyCardTypeAsync(int weeklyCardType, int top_)
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
		public List<Sa_weeklycard_detailEO> GetByWeeklyCardType(int weeklyCardType, int top_, TransactionManager tm_)
		{
			return GetByWeeklyCardType(weeklyCardType, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_weeklycard_detailEO>> GetByWeeklyCardTypeAsync(int weeklyCardType, int top_, TransactionManager tm_)
		{
			return await GetByWeeklyCardTypeAsync(weeklyCardType, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WeeklyCardType（字段） 查询
		/// </summary>
		/// /// <param name = "weeklyCardType">1-100档周卡2-50档周卡</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_detailEO> GetByWeeklyCardType(int weeklyCardType, string sort_)
		{
			return GetByWeeklyCardType(weeklyCardType, 0, sort_, null);
		}
		public async Task<List<Sa_weeklycard_detailEO>> GetByWeeklyCardTypeAsync(int weeklyCardType, string sort_)
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
		public List<Sa_weeklycard_detailEO> GetByWeeklyCardType(int weeklyCardType, string sort_, TransactionManager tm_)
		{
			return GetByWeeklyCardType(weeklyCardType, 0, sort_, tm_);
		}
		public async Task<List<Sa_weeklycard_detailEO>> GetByWeeklyCardTypeAsync(int weeklyCardType, string sort_, TransactionManager tm_)
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
		public List<Sa_weeklycard_detailEO> GetByWeeklyCardType(int weeklyCardType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WeeklyCardType` = @WeeklyCardType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WeeklyCardType", weeklyCardType, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_weeklycard_detailEO.MapDataReader);
		}
		public async Task<List<Sa_weeklycard_detailEO>> GetByWeeklyCardTypeAsync(int weeklyCardType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WeeklyCardType` = @WeeklyCardType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WeeklyCardType", weeklyCardType, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_weeklycard_detailEO.MapDataReader);
		}
		#endregion // GetByWeeklyCardType
		#region GetByBonus
		
		/// <summary>
		/// 按 Bonus（字段） 查询
		/// </summary>
		/// /// <param name = "bonus">奖励金额</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_detailEO> GetByBonus(long bonus)
		{
			return GetByBonus(bonus, 0, string.Empty, null);
		}
		public async Task<List<Sa_weeklycard_detailEO>> GetByBonusAsync(long bonus)
		{
			return await GetByBonusAsync(bonus, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Bonus（字段） 查询
		/// </summary>
		/// /// <param name = "bonus">奖励金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_detailEO> GetByBonus(long bonus, TransactionManager tm_)
		{
			return GetByBonus(bonus, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_weeklycard_detailEO>> GetByBonusAsync(long bonus, TransactionManager tm_)
		{
			return await GetByBonusAsync(bonus, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Bonus（字段） 查询
		/// </summary>
		/// /// <param name = "bonus">奖励金额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_detailEO> GetByBonus(long bonus, int top_)
		{
			return GetByBonus(bonus, top_, string.Empty, null);
		}
		public async Task<List<Sa_weeklycard_detailEO>> GetByBonusAsync(long bonus, int top_)
		{
			return await GetByBonusAsync(bonus, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Bonus（字段） 查询
		/// </summary>
		/// /// <param name = "bonus">奖励金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_detailEO> GetByBonus(long bonus, int top_, TransactionManager tm_)
		{
			return GetByBonus(bonus, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_weeklycard_detailEO>> GetByBonusAsync(long bonus, int top_, TransactionManager tm_)
		{
			return await GetByBonusAsync(bonus, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Bonus（字段） 查询
		/// </summary>
		/// /// <param name = "bonus">奖励金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_detailEO> GetByBonus(long bonus, string sort_)
		{
			return GetByBonus(bonus, 0, sort_, null);
		}
		public async Task<List<Sa_weeklycard_detailEO>> GetByBonusAsync(long bonus, string sort_)
		{
			return await GetByBonusAsync(bonus, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Bonus（字段） 查询
		/// </summary>
		/// /// <param name = "bonus">奖励金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_detailEO> GetByBonus(long bonus, string sort_, TransactionManager tm_)
		{
			return GetByBonus(bonus, 0, sort_, tm_);
		}
		public async Task<List<Sa_weeklycard_detailEO>> GetByBonusAsync(long bonus, string sort_, TransactionManager tm_)
		{
			return await GetByBonusAsync(bonus, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Bonus（字段） 查询
		/// </summary>
		/// /// <param name = "bonus">奖励金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_detailEO> GetByBonus(long bonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Bonus` = @Bonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Bonus", bonus, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_weeklycard_detailEO.MapDataReader);
		}
		public async Task<List<Sa_weeklycard_detailEO>> GetByBonusAsync(long bonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Bonus` = @Bonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Bonus", bonus, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_weeklycard_detailEO.MapDataReader);
		}
		#endregion // GetByBonus
		#region GetByFlowMultip
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">流水倍数</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_detailEO> GetByFlowMultip(float flowMultip)
		{
			return GetByFlowMultip(flowMultip, 0, string.Empty, null);
		}
		public async Task<List<Sa_weeklycard_detailEO>> GetByFlowMultipAsync(float flowMultip)
		{
			return await GetByFlowMultipAsync(flowMultip, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">流水倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_detailEO> GetByFlowMultip(float flowMultip, TransactionManager tm_)
		{
			return GetByFlowMultip(flowMultip, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_weeklycard_detailEO>> GetByFlowMultipAsync(float flowMultip, TransactionManager tm_)
		{
			return await GetByFlowMultipAsync(flowMultip, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">流水倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_detailEO> GetByFlowMultip(float flowMultip, int top_)
		{
			return GetByFlowMultip(flowMultip, top_, string.Empty, null);
		}
		public async Task<List<Sa_weeklycard_detailEO>> GetByFlowMultipAsync(float flowMultip, int top_)
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
		public List<Sa_weeklycard_detailEO> GetByFlowMultip(float flowMultip, int top_, TransactionManager tm_)
		{
			return GetByFlowMultip(flowMultip, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_weeklycard_detailEO>> GetByFlowMultipAsync(float flowMultip, int top_, TransactionManager tm_)
		{
			return await GetByFlowMultipAsync(flowMultip, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">流水倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_detailEO> GetByFlowMultip(float flowMultip, string sort_)
		{
			return GetByFlowMultip(flowMultip, 0, sort_, null);
		}
		public async Task<List<Sa_weeklycard_detailEO>> GetByFlowMultipAsync(float flowMultip, string sort_)
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
		public List<Sa_weeklycard_detailEO> GetByFlowMultip(float flowMultip, string sort_, TransactionManager tm_)
		{
			return GetByFlowMultip(flowMultip, 0, sort_, tm_);
		}
		public async Task<List<Sa_weeklycard_detailEO>> GetByFlowMultipAsync(float flowMultip, string sort_, TransactionManager tm_)
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
		public List<Sa_weeklycard_detailEO> GetByFlowMultip(float flowMultip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FlowMultip` = @FlowMultip", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FlowMultip", flowMultip, MySqlDbType.Float));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_weeklycard_detailEO.MapDataReader);
		}
		public async Task<List<Sa_weeklycard_detailEO>> GetByFlowMultipAsync(float flowMultip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FlowMultip` = @FlowMultip", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FlowMultip", flowMultip, MySqlDbType.Float));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_weeklycard_detailEO.MapDataReader);
		}
		#endregion // GetByFlowMultip
		#region GetByCurrentCycleNumber
		
		/// <summary>
		/// 按 CurrentCycleNumber（字段） 查询
		/// </summary>
		/// /// <param name = "currentCycleNumber">当前第几天领奖</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_detailEO> GetByCurrentCycleNumber(int currentCycleNumber)
		{
			return GetByCurrentCycleNumber(currentCycleNumber, 0, string.Empty, null);
		}
		public async Task<List<Sa_weeklycard_detailEO>> GetByCurrentCycleNumberAsync(int currentCycleNumber)
		{
			return await GetByCurrentCycleNumberAsync(currentCycleNumber, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrentCycleNumber（字段） 查询
		/// </summary>
		/// /// <param name = "currentCycleNumber">当前第几天领奖</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_detailEO> GetByCurrentCycleNumber(int currentCycleNumber, TransactionManager tm_)
		{
			return GetByCurrentCycleNumber(currentCycleNumber, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_weeklycard_detailEO>> GetByCurrentCycleNumberAsync(int currentCycleNumber, TransactionManager tm_)
		{
			return await GetByCurrentCycleNumberAsync(currentCycleNumber, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrentCycleNumber（字段） 查询
		/// </summary>
		/// /// <param name = "currentCycleNumber">当前第几天领奖</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_detailEO> GetByCurrentCycleNumber(int currentCycleNumber, int top_)
		{
			return GetByCurrentCycleNumber(currentCycleNumber, top_, string.Empty, null);
		}
		public async Task<List<Sa_weeklycard_detailEO>> GetByCurrentCycleNumberAsync(int currentCycleNumber, int top_)
		{
			return await GetByCurrentCycleNumberAsync(currentCycleNumber, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrentCycleNumber（字段） 查询
		/// </summary>
		/// /// <param name = "currentCycleNumber">当前第几天领奖</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_detailEO> GetByCurrentCycleNumber(int currentCycleNumber, int top_, TransactionManager tm_)
		{
			return GetByCurrentCycleNumber(currentCycleNumber, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_weeklycard_detailEO>> GetByCurrentCycleNumberAsync(int currentCycleNumber, int top_, TransactionManager tm_)
		{
			return await GetByCurrentCycleNumberAsync(currentCycleNumber, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrentCycleNumber（字段） 查询
		/// </summary>
		/// /// <param name = "currentCycleNumber">当前第几天领奖</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_detailEO> GetByCurrentCycleNumber(int currentCycleNumber, string sort_)
		{
			return GetByCurrentCycleNumber(currentCycleNumber, 0, sort_, null);
		}
		public async Task<List<Sa_weeklycard_detailEO>> GetByCurrentCycleNumberAsync(int currentCycleNumber, string sort_)
		{
			return await GetByCurrentCycleNumberAsync(currentCycleNumber, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CurrentCycleNumber（字段） 查询
		/// </summary>
		/// /// <param name = "currentCycleNumber">当前第几天领奖</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_detailEO> GetByCurrentCycleNumber(int currentCycleNumber, string sort_, TransactionManager tm_)
		{
			return GetByCurrentCycleNumber(currentCycleNumber, 0, sort_, tm_);
		}
		public async Task<List<Sa_weeklycard_detailEO>> GetByCurrentCycleNumberAsync(int currentCycleNumber, string sort_, TransactionManager tm_)
		{
			return await GetByCurrentCycleNumberAsync(currentCycleNumber, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CurrentCycleNumber（字段） 查询
		/// </summary>
		/// /// <param name = "currentCycleNumber">当前第几天领奖</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_detailEO> GetByCurrentCycleNumber(int currentCycleNumber, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrentCycleNumber` = @CurrentCycleNumber", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrentCycleNumber", currentCycleNumber, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_weeklycard_detailEO.MapDataReader);
		}
		public async Task<List<Sa_weeklycard_detailEO>> GetByCurrentCycleNumberAsync(int currentCycleNumber, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrentCycleNumber` = @CurrentCycleNumber", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrentCycleNumber", currentCycleNumber, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_weeklycard_detailEO.MapDataReader);
		}
		#endregion // GetByCurrentCycleNumber
		#region GetByCycleStartDate
		
		/// <summary>
		/// 按 CycleStartDate（字段） 查询
		/// </summary>
		/// /// <param name = "cycleStartDate">周卡起始日期</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_detailEO> GetByCycleStartDate(DateTime cycleStartDate)
		{
			return GetByCycleStartDate(cycleStartDate, 0, string.Empty, null);
		}
		public async Task<List<Sa_weeklycard_detailEO>> GetByCycleStartDateAsync(DateTime cycleStartDate)
		{
			return await GetByCycleStartDateAsync(cycleStartDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CycleStartDate（字段） 查询
		/// </summary>
		/// /// <param name = "cycleStartDate">周卡起始日期</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_detailEO> GetByCycleStartDate(DateTime cycleStartDate, TransactionManager tm_)
		{
			return GetByCycleStartDate(cycleStartDate, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_weeklycard_detailEO>> GetByCycleStartDateAsync(DateTime cycleStartDate, TransactionManager tm_)
		{
			return await GetByCycleStartDateAsync(cycleStartDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CycleStartDate（字段） 查询
		/// </summary>
		/// /// <param name = "cycleStartDate">周卡起始日期</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_detailEO> GetByCycleStartDate(DateTime cycleStartDate, int top_)
		{
			return GetByCycleStartDate(cycleStartDate, top_, string.Empty, null);
		}
		public async Task<List<Sa_weeklycard_detailEO>> GetByCycleStartDateAsync(DateTime cycleStartDate, int top_)
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
		public List<Sa_weeklycard_detailEO> GetByCycleStartDate(DateTime cycleStartDate, int top_, TransactionManager tm_)
		{
			return GetByCycleStartDate(cycleStartDate, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_weeklycard_detailEO>> GetByCycleStartDateAsync(DateTime cycleStartDate, int top_, TransactionManager tm_)
		{
			return await GetByCycleStartDateAsync(cycleStartDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CycleStartDate（字段） 查询
		/// </summary>
		/// /// <param name = "cycleStartDate">周卡起始日期</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_detailEO> GetByCycleStartDate(DateTime cycleStartDate, string sort_)
		{
			return GetByCycleStartDate(cycleStartDate, 0, sort_, null);
		}
		public async Task<List<Sa_weeklycard_detailEO>> GetByCycleStartDateAsync(DateTime cycleStartDate, string sort_)
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
		public List<Sa_weeklycard_detailEO> GetByCycleStartDate(DateTime cycleStartDate, string sort_, TransactionManager tm_)
		{
			return GetByCycleStartDate(cycleStartDate, 0, sort_, tm_);
		}
		public async Task<List<Sa_weeklycard_detailEO>> GetByCycleStartDateAsync(DateTime cycleStartDate, string sort_, TransactionManager tm_)
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
		public List<Sa_weeklycard_detailEO> GetByCycleStartDate(DateTime cycleStartDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CycleStartDate` = @CycleStartDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CycleStartDate", cycleStartDate, MySqlDbType.Date));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_weeklycard_detailEO.MapDataReader);
		}
		public async Task<List<Sa_weeklycard_detailEO>> GetByCycleStartDateAsync(DateTime cycleStartDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CycleStartDate` = @CycleStartDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CycleStartDate", cycleStartDate, MySqlDbType.Date));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_weeklycard_detailEO.MapDataReader);
		}
		#endregion // GetByCycleStartDate
		#region GetByCycleEndDate
		
		/// <summary>
		/// 按 CycleEndDate（字段） 查询
		/// </summary>
		/// /// <param name = "cycleEndDate">周卡截止日期</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_detailEO> GetByCycleEndDate(DateTime cycleEndDate)
		{
			return GetByCycleEndDate(cycleEndDate, 0, string.Empty, null);
		}
		public async Task<List<Sa_weeklycard_detailEO>> GetByCycleEndDateAsync(DateTime cycleEndDate)
		{
			return await GetByCycleEndDateAsync(cycleEndDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CycleEndDate（字段） 查询
		/// </summary>
		/// /// <param name = "cycleEndDate">周卡截止日期</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_detailEO> GetByCycleEndDate(DateTime cycleEndDate, TransactionManager tm_)
		{
			return GetByCycleEndDate(cycleEndDate, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_weeklycard_detailEO>> GetByCycleEndDateAsync(DateTime cycleEndDate, TransactionManager tm_)
		{
			return await GetByCycleEndDateAsync(cycleEndDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CycleEndDate（字段） 查询
		/// </summary>
		/// /// <param name = "cycleEndDate">周卡截止日期</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_detailEO> GetByCycleEndDate(DateTime cycleEndDate, int top_)
		{
			return GetByCycleEndDate(cycleEndDate, top_, string.Empty, null);
		}
		public async Task<List<Sa_weeklycard_detailEO>> GetByCycleEndDateAsync(DateTime cycleEndDate, int top_)
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
		public List<Sa_weeklycard_detailEO> GetByCycleEndDate(DateTime cycleEndDate, int top_, TransactionManager tm_)
		{
			return GetByCycleEndDate(cycleEndDate, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_weeklycard_detailEO>> GetByCycleEndDateAsync(DateTime cycleEndDate, int top_, TransactionManager tm_)
		{
			return await GetByCycleEndDateAsync(cycleEndDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CycleEndDate（字段） 查询
		/// </summary>
		/// /// <param name = "cycleEndDate">周卡截止日期</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_detailEO> GetByCycleEndDate(DateTime cycleEndDate, string sort_)
		{
			return GetByCycleEndDate(cycleEndDate, 0, sort_, null);
		}
		public async Task<List<Sa_weeklycard_detailEO>> GetByCycleEndDateAsync(DateTime cycleEndDate, string sort_)
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
		public List<Sa_weeklycard_detailEO> GetByCycleEndDate(DateTime cycleEndDate, string sort_, TransactionManager tm_)
		{
			return GetByCycleEndDate(cycleEndDate, 0, sort_, tm_);
		}
		public async Task<List<Sa_weeklycard_detailEO>> GetByCycleEndDateAsync(DateTime cycleEndDate, string sort_, TransactionManager tm_)
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
		public List<Sa_weeklycard_detailEO> GetByCycleEndDate(DateTime cycleEndDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CycleEndDate` = @CycleEndDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CycleEndDate", cycleEndDate, MySqlDbType.Date));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_weeklycard_detailEO.MapDataReader);
		}
		public async Task<List<Sa_weeklycard_detailEO>> GetByCycleEndDateAsync(DateTime cycleEndDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CycleEndDate` = @CycleEndDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CycleEndDate", cycleEndDate, MySqlDbType.Date));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_weeklycard_detailEO.MapDataReader);
		}
		#endregion // GetByCycleEndDate
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">签到时间</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_detailEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<Sa_weeklycard_detailEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">签到时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_detailEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_weeklycard_detailEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">签到时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_detailEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<Sa_weeklycard_detailEO>> GetByRecDateAsync(DateTime recDate, int top_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">签到时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_detailEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_weeklycard_detailEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">签到时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_detailEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<Sa_weeklycard_detailEO>> GetByRecDateAsync(DateTime recDate, string sort_)
		{
			return await GetByRecDateAsync(recDate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">签到时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_detailEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<Sa_weeklycard_detailEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">签到时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_weeklycard_detailEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_weeklycard_detailEO.MapDataReader);
		}
		public async Task<List<Sa_weeklycard_detailEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_weeklycard_detailEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
