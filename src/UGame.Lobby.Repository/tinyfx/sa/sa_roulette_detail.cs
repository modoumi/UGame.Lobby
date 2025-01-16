/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * AiUo代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/AiUo
 * 文档生成时间：2023-12-28 18: 27:39
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
	/// 幸运轮盘抽奖明细
	/// 【表 sa_roulette_detail 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Sa_roulette_detailEO : IRowMapper<Sa_roulette_detailEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Sa_roulette_detailEO()
		{
			this.DetailType = 0;
			this.PlanBet = 0;
			this.Amount = 0;
			this.Freespin = 0;
			this.IsFreespin = false;
			this.FreespinNum = 0;
			this.RaffleType = 0;
			this.UserType = 0;
			this.Level = 0;
			this.RewardType = 0;
			this.PreRewardType = 0;
			this.Position = 0;
			this.Multiple = 0f;
			this.Bonus = 0;
			this.Status = 0;
			this.RecDate = DateTime.Now;
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
		/// 主键GUID
		/// 【主键 varchar(36)】
		/// </summary>
		[DataMember(Order = 1)]
		public string DetailID { get; set; }
		/// <summary>
		/// 用户编码guid
		/// 【字段 varchar(36)】
		/// </summary>
		[DataMember(Order = 2)]
		public string UserID { get; set; }
		/// <summary>
		/// 手机号
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 3)]
		public string Mobile { get; set; }
		/// <summary>
		/// 运营商编码
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 4)]
		public string OperatorID { get; set; }
		/// <summary>
		/// 货币类型
		/// 【字段 varchar(5)】
		/// </summary>
		[DataMember(Order = 5)]
		public string CurrencyID { get; set; }
		/// <summary>
		/// 1-注册赠送2-首充赠送3-下注
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 6)]
		public int DetailType { get; set; }
		/// <summary>
		/// 计划下注数量
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 7)]
		public long PlanBet { get; set; }
		/// <summary>
		/// 实际账户变化数量（正负数）
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 8)]
		public long Amount { get; set; }
		/// <summary>
		/// 注册、首充赠送freespin次数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 9)]
		public int Freespin { get; set; }
		/// <summary>
		/// 是否为freespin
		/// 【字段 tinyint(1)】
		/// </summary>
		[DataMember(Order = 10)]
		public bool IsFreespin { get; set; }
		/// <summary>
		/// freespin剩余数量
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 11)]
		public int FreespinNum { get; set; }
		/// <summary>
		/// 抽奖类型1-freespin2-真金
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 12)]
		public int RaffleType { get; set; }
		/// <summary>
		/// 抽奖用户类型1-新用户2-盈利用户3-亏损用户
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 13)]
		public int UserType { get; set; }
		/// <summary>
		/// 抽奖等级1-基础奖励2-二级奖励
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 14)]
		public int Level { get; set; }
		/// <summary>
		/// 奖励类型1-无奖励2-真金3-二级抽奖A4-二级抽奖B
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 15)]
		public int RewardType { get; set; }
		/// <summary>
		/// 上一级奖励类型
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 16)]
		public int PreRewardType { get; set; }
		/// <summary>
		/// 位置
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 17)]
		public int Position { get; set; }
		/// <summary>
		/// 倍率
		/// 【字段 float】
		/// </summary>
		[DataMember(Order = 18)]
		public float Multiple { get; set; }
		/// <summary>
		/// 奖金
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 19)]
		public long Bonus { get; set; }
		/// <summary>
		/// 状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 20)]
		public int Status { get; set; }
		/// <summary>
		/// 记录时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 21)]
		public DateTime RecDate { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Sa_roulette_detailEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Sa_roulette_detailEO MapDataReader(IDataReader reader)
		{
		    Sa_roulette_detailEO ret = new Sa_roulette_detailEO();
			ret.DetailID = reader.ToString("DetailID");
			ret.OriginalDetailID = ret.DetailID;
			ret.UserID = reader.ToString("UserID");
			ret.Mobile = reader.ToString("Mobile");
			ret.OperatorID = reader.ToString("OperatorID");
			ret.CurrencyID = reader.ToString("CurrencyID");
			ret.DetailType = reader.ToInt32("DetailType");
			ret.PlanBet = reader.ToInt64("PlanBet");
			ret.Amount = reader.ToInt64("Amount");
			ret.Freespin = reader.ToInt32("Freespin");
			ret.IsFreespin = reader.ToBoolean("IsFreespin");
			ret.FreespinNum = reader.ToInt32("FreespinNum");
			ret.RaffleType = reader.ToInt32("RaffleType");
			ret.UserType = reader.ToInt32("UserType");
			ret.Level = reader.ToInt32("Level");
			ret.RewardType = reader.ToInt32("RewardType");
			ret.PreRewardType = reader.ToInt32("PreRewardType");
			ret.Position = reader.ToInt32("Position");
			ret.Multiple = reader.ToSingle("Multiple");
			ret.Bonus = reader.ToInt64("Bonus");
			ret.Status = reader.ToInt32("Status");
			ret.RecDate = reader.ToDateTime("RecDate");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 幸运轮盘抽奖明细
	/// 【表 sa_roulette_detail 的操作类】
	/// </summary>
	[Obsolete]
	public class Sa_roulette_detailMO : MySqlTableMO<Sa_roulette_detailEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`sa_roulette_detail`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Sa_roulette_detailMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Sa_roulette_detailMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Sa_roulette_detailMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Sa_roulette_detailEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Sa_roulette_detailEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Sa_roulette_detailEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`DetailID`, `UserID`, `Mobile`, `OperatorID`, `CurrencyID`, `DetailType`, `PlanBet`, `Amount`, `Freespin`, `IsFreespin`, `FreespinNum`, `RaffleType`, `UserType`, `Level`, `RewardType`, `PreRewardType`, `Position`, `Multiple`, `Bonus`, `Status`, `RecDate`) VALUE (@DetailID, @UserID, @Mobile, @OperatorID, @CurrencyID, @DetailType, @PlanBet, @Amount, @Freespin, @IsFreespin, @FreespinNum, @RaffleType, @UserType, @Level, @RewardType, @PreRewardType, @Position, @Multiple, @Bonus, @Status, @RecDate);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", item.DetailID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Mobile", item.Mobile != null ? item.Mobile : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@DetailType", item.DetailType, MySqlDbType.Int32),
				Database.CreateInParameter("@PlanBet", item.PlanBet, MySqlDbType.Int64),
				Database.CreateInParameter("@Amount", item.Amount, MySqlDbType.Int64),
				Database.CreateInParameter("@Freespin", item.Freespin, MySqlDbType.Int32),
				Database.CreateInParameter("@IsFreespin", item.IsFreespin, MySqlDbType.Byte),
				Database.CreateInParameter("@FreespinNum", item.FreespinNum, MySqlDbType.Int32),
				Database.CreateInParameter("@RaffleType", item.RaffleType, MySqlDbType.Int32),
				Database.CreateInParameter("@UserType", item.UserType, MySqlDbType.Int32),
				Database.CreateInParameter("@Level", item.Level, MySqlDbType.Int32),
				Database.CreateInParameter("@RewardType", item.RewardType, MySqlDbType.Int32),
				Database.CreateInParameter("@PreRewardType", item.PreRewardType, MySqlDbType.Int32),
				Database.CreateInParameter("@Position", item.Position, MySqlDbType.Int32),
				Database.CreateInParameter("@Multiple", item.Multiple, MySqlDbType.Float),
				Database.CreateInParameter("@Bonus", item.Bonus, MySqlDbType.Int64),
				Database.CreateInParameter("@Status", item.Status, MySqlDbType.Int32),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
			};
		}
		public int AddByBatch(IEnumerable<Sa_roulette_detailEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Sa_roulette_detailEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sa_roulette_detailEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`DetailID`, `UserID`, `Mobile`, `OperatorID`, `CurrencyID`, `DetailType`, `PlanBet`, `Amount`, `Freespin`, `IsFreespin`, `FreespinNum`, `RaffleType`, `UserType`, `Level`, `RewardType`, `PreRewardType`, `Position`, `Multiple`, `Bonus`, `Status`, `RecDate`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.DetailID}','{item.UserID}','{item.Mobile}','{item.OperatorID}','{item.CurrencyID}',{item.DetailType},{item.PlanBet},{item.Amount},{item.Freespin},{item.IsFreespin},{item.FreespinNum},{item.RaffleType},{item.UserType},{item.Level},{item.RewardType},{item.PreRewardType},{item.Position},{item.Multiple},{item.Bonus},{item.Status},'{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
		/// /// <param name = "detailID">主键GUID</param>
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
		public int Remove(Sa_roulette_detailEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.DetailID, tm_);
		}
		public async Task<int> RemoveAsync(Sa_roulette_detailEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.DetailID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByUserID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "userID">用户编码guid</param>
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
		#region RemoveByMobile
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "mobile">手机号</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByMobile(string mobile, TransactionManager tm_ = null)
		{
			RepairRemoveByMobileData(mobile, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByMobileAsync(string mobile, TransactionManager tm_ = null)
		{
			RepairRemoveByMobileData(mobile, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByMobileData(string mobile, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (mobile != null ? "`Mobile` = @Mobile" : "`Mobile` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (mobile != null)
				paras_.Add(Database.CreateInParameter("@Mobile", mobile, MySqlDbType.VarChar));
		}
		#endregion // RemoveByMobile
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
		#region RemoveByDetailType
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "detailType">1-注册赠送2-首充赠送3-下注</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByDetailType(int detailType, TransactionManager tm_ = null)
		{
			RepairRemoveByDetailTypeData(detailType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByDetailTypeAsync(int detailType, TransactionManager tm_ = null)
		{
			RepairRemoveByDetailTypeData(detailType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByDetailTypeData(int detailType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `DetailType` = @DetailType";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DetailType", detailType, MySqlDbType.Int32));
		}
		#endregion // RemoveByDetailType
		#region RemoveByPlanBet
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "planBet">计划下注数量</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPlanBet(long planBet, TransactionManager tm_ = null)
		{
			RepairRemoveByPlanBetData(planBet, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPlanBetAsync(long planBet, TransactionManager tm_ = null)
		{
			RepairRemoveByPlanBetData(planBet, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByPlanBetData(long planBet, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `PlanBet` = @PlanBet";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PlanBet", planBet, MySqlDbType.Int64));
		}
		#endregion // RemoveByPlanBet
		#region RemoveByAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "amount">实际账户变化数量（正负数）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByAmount(long amount, TransactionManager tm_ = null)
		{
			RepairRemoveByAmountData(amount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByAmountAsync(long amount, TransactionManager tm_ = null)
		{
			RepairRemoveByAmountData(amount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByAmountData(long amount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Amount` = @Amount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Amount", amount, MySqlDbType.Int64));
		}
		#endregion // RemoveByAmount
		#region RemoveByFreespin
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "freespin">注册、首充赠送freespin次数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByFreespin(int freespin, TransactionManager tm_ = null)
		{
			RepairRemoveByFreespinData(freespin, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByFreespinAsync(int freespin, TransactionManager tm_ = null)
		{
			RepairRemoveByFreespinData(freespin, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByFreespinData(int freespin, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Freespin` = @Freespin";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Freespin", freespin, MySqlDbType.Int32));
		}
		#endregion // RemoveByFreespin
		#region RemoveByIsFreespin
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "isFreespin">是否为freespin</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByIsFreespin(bool isFreespin, TransactionManager tm_ = null)
		{
			RepairRemoveByIsFreespinData(isFreespin, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByIsFreespinAsync(bool isFreespin, TransactionManager tm_ = null)
		{
			RepairRemoveByIsFreespinData(isFreespin, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByIsFreespinData(bool isFreespin, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `IsFreespin` = @IsFreespin";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsFreespin", isFreespin, MySqlDbType.Byte));
		}
		#endregion // RemoveByIsFreespin
		#region RemoveByFreespinNum
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "freespinNum">freespin剩余数量</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByFreespinNum(int freespinNum, TransactionManager tm_ = null)
		{
			RepairRemoveByFreespinNumData(freespinNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByFreespinNumAsync(int freespinNum, TransactionManager tm_ = null)
		{
			RepairRemoveByFreespinNumData(freespinNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByFreespinNumData(int freespinNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `FreespinNum` = @FreespinNum";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FreespinNum", freespinNum, MySqlDbType.Int32));
		}
		#endregion // RemoveByFreespinNum
		#region RemoveByRaffleType
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "raffleType">抽奖类型1-freespin2-真金</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByRaffleType(int raffleType, TransactionManager tm_ = null)
		{
			RepairRemoveByRaffleTypeData(raffleType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByRaffleTypeAsync(int raffleType, TransactionManager tm_ = null)
		{
			RepairRemoveByRaffleTypeData(raffleType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByRaffleTypeData(int raffleType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `RaffleType` = @RaffleType";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RaffleType", raffleType, MySqlDbType.Int32));
		}
		#endregion // RemoveByRaffleType
		#region RemoveByUserType
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "userType">抽奖用户类型1-新用户2-盈利用户3-亏损用户</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByUserType(int userType, TransactionManager tm_ = null)
		{
			RepairRemoveByUserTypeData(userType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByUserTypeAsync(int userType, TransactionManager tm_ = null)
		{
			RepairRemoveByUserTypeData(userType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByUserTypeData(int userType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `UserType` = @UserType";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserType", userType, MySqlDbType.Int32));
		}
		#endregion // RemoveByUserType
		#region RemoveByLevel
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "level">抽奖等级1-基础奖励2-二级奖励</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByLevel(int level, TransactionManager tm_ = null)
		{
			RepairRemoveByLevelData(level, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByLevelAsync(int level, TransactionManager tm_ = null)
		{
			RepairRemoveByLevelData(level, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByLevelData(int level, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Level` = @Level";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Level", level, MySqlDbType.Int32));
		}
		#endregion // RemoveByLevel
		#region RemoveByRewardType
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "rewardType">奖励类型1-无奖励2-真金3-二级抽奖A4-二级抽奖B</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByRewardType(int rewardType, TransactionManager tm_ = null)
		{
			RepairRemoveByRewardTypeData(rewardType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByRewardTypeAsync(int rewardType, TransactionManager tm_ = null)
		{
			RepairRemoveByRewardTypeData(rewardType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByRewardTypeData(int rewardType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `RewardType` = @RewardType";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RewardType", rewardType, MySqlDbType.Int32));
		}
		#endregion // RemoveByRewardType
		#region RemoveByPreRewardType
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "preRewardType">上一级奖励类型</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPreRewardType(int preRewardType, TransactionManager tm_ = null)
		{
			RepairRemoveByPreRewardTypeData(preRewardType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPreRewardTypeAsync(int preRewardType, TransactionManager tm_ = null)
		{
			RepairRemoveByPreRewardTypeData(preRewardType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByPreRewardTypeData(int preRewardType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `PreRewardType` = @PreRewardType";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PreRewardType", preRewardType, MySqlDbType.Int32));
		}
		#endregion // RemoveByPreRewardType
		#region RemoveByPosition
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "position">位置</param>
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
		#region RemoveByMultiple
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "multiple">倍率</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByMultiple(float multiple, TransactionManager tm_ = null)
		{
			RepairRemoveByMultipleData(multiple, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByMultipleAsync(float multiple, TransactionManager tm_ = null)
		{
			RepairRemoveByMultipleData(multiple, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByMultipleData(float multiple, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Multiple` = @Multiple";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Multiple", multiple, MySqlDbType.Float));
		}
		#endregion // RemoveByMultiple
		#region RemoveByBonus
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "bonus">奖金</param>
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
		#region RemoveByStatus
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "status">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
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
		public int Put(Sa_roulette_detailEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Sa_roulette_detailEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Sa_roulette_detailEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `DetailID` = @DetailID, `UserID` = @UserID, `Mobile` = @Mobile, `OperatorID` = @OperatorID, `CurrencyID` = @CurrencyID, `DetailType` = @DetailType, `PlanBet` = @PlanBet, `Amount` = @Amount, `Freespin` = @Freespin, `IsFreespin` = @IsFreespin, `FreespinNum` = @FreespinNum, `RaffleType` = @RaffleType, `UserType` = @UserType, `Level` = @Level, `RewardType` = @RewardType, `PreRewardType` = @PreRewardType, `Position` = @Position, `Multiple` = @Multiple, `Bonus` = @Bonus, `Status` = @Status WHERE `DetailID` = @DetailID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", item.DetailID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Mobile", item.Mobile != null ? item.Mobile : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@DetailType", item.DetailType, MySqlDbType.Int32),
				Database.CreateInParameter("@PlanBet", item.PlanBet, MySqlDbType.Int64),
				Database.CreateInParameter("@Amount", item.Amount, MySqlDbType.Int64),
				Database.CreateInParameter("@Freespin", item.Freespin, MySqlDbType.Int32),
				Database.CreateInParameter("@IsFreespin", item.IsFreespin, MySqlDbType.Byte),
				Database.CreateInParameter("@FreespinNum", item.FreespinNum, MySqlDbType.Int32),
				Database.CreateInParameter("@RaffleType", item.RaffleType, MySqlDbType.Int32),
				Database.CreateInParameter("@UserType", item.UserType, MySqlDbType.Int32),
				Database.CreateInParameter("@Level", item.Level, MySqlDbType.Int32),
				Database.CreateInParameter("@RewardType", item.RewardType, MySqlDbType.Int32),
				Database.CreateInParameter("@PreRewardType", item.PreRewardType, MySqlDbType.Int32),
				Database.CreateInParameter("@Position", item.Position, MySqlDbType.Int32),
				Database.CreateInParameter("@Multiple", item.Multiple, MySqlDbType.Float),
				Database.CreateInParameter("@Bonus", item.Bonus, MySqlDbType.Int64),
				Database.CreateInParameter("@Status", item.Status, MySqlDbType.Int32),
				Database.CreateInParameter("@DetailID_Original", item.HasOriginal ? item.OriginalDetailID : item.DetailID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Sa_roulette_detailEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Sa_roulette_detailEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "detailID">主键GUID</param>
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
		/// /// <param name = "detailID">主键GUID</param>
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
		/// /// <param name = "detailID">主键GUID</param>
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
		#region PutUserID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID">主键GUID</param>
		/// /// <param name = "userID">用户编码guid</param>
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
		/// /// <param name = "userID">用户编码guid</param>
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
		#region PutMobile
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID">主键GUID</param>
		/// /// <param name = "mobile">手机号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMobileByPK(string detailID, string mobile, TransactionManager tm_ = null)
		{
			RepairPutMobileByPKData(detailID, mobile, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutMobileByPKAsync(string detailID, string mobile, TransactionManager tm_ = null)
		{
			RepairPutMobileByPKData(detailID, mobile, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutMobileByPKData(string detailID, string mobile, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Mobile` = @Mobile  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Mobile", mobile != null ? mobile : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "mobile">手机号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMobile(string mobile, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Mobile` = @Mobile";
			var parameter_ = Database.CreateInParameter("@Mobile", mobile != null ? mobile : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutMobileAsync(string mobile, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Mobile` = @Mobile";
			var parameter_ = Database.CreateInParameter("@Mobile", mobile != null ? mobile : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutMobile
		#region PutOperatorID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID">主键GUID</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorIDByPK(string detailID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(detailID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOperatorIDByPKAsync(string detailID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(detailID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOperatorIDByPKData(string detailID, string operatorID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
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
		/// /// <param name = "detailID">主键GUID</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCurrencyIDByPK(string detailID, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(detailID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCurrencyIDByPKAsync(string detailID, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(detailID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCurrencyIDByPKData(string detailID, string currencyID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CurrencyID` = @CurrencyID  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
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
		#region PutDetailType
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID">主键GUID</param>
		/// /// <param name = "detailType">1-注册赠送2-首充赠送3-下注</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutDetailTypeByPK(string detailID, int detailType, TransactionManager tm_ = null)
		{
			RepairPutDetailTypeByPKData(detailID, detailType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutDetailTypeByPKAsync(string detailID, int detailType, TransactionManager tm_ = null)
		{
			RepairPutDetailTypeByPKData(detailID, detailType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutDetailTypeByPKData(string detailID, int detailType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `DetailType` = @DetailType  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailType", detailType, MySqlDbType.Int32),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "detailType">1-注册赠送2-首充赠送3-下注</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutDetailType(int detailType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `DetailType` = @DetailType";
			var parameter_ = Database.CreateInParameter("@DetailType", detailType, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutDetailTypeAsync(int detailType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `DetailType` = @DetailType";
			var parameter_ = Database.CreateInParameter("@DetailType", detailType, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutDetailType
		#region PutPlanBet
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID">主键GUID</param>
		/// /// <param name = "planBet">计划下注数量</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPlanBetByPK(string detailID, long planBet, TransactionManager tm_ = null)
		{
			RepairPutPlanBetByPKData(detailID, planBet, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutPlanBetByPKAsync(string detailID, long planBet, TransactionManager tm_ = null)
		{
			RepairPutPlanBetByPKData(detailID, planBet, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutPlanBetByPKData(string detailID, long planBet, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `PlanBet` = @PlanBet  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PlanBet", planBet, MySqlDbType.Int64),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "planBet">计划下注数量</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPlanBet(long planBet, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PlanBet` = @PlanBet";
			var parameter_ = Database.CreateInParameter("@PlanBet", planBet, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutPlanBetAsync(long planBet, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PlanBet` = @PlanBet";
			var parameter_ = Database.CreateInParameter("@PlanBet", planBet, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutPlanBet
		#region PutAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID">主键GUID</param>
		/// /// <param name = "amount">实际账户变化数量（正负数）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAmountByPK(string detailID, long amount, TransactionManager tm_ = null)
		{
			RepairPutAmountByPKData(detailID, amount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAmountByPKAsync(string detailID, long amount, TransactionManager tm_ = null)
		{
			RepairPutAmountByPKData(detailID, amount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutAmountByPKData(string detailID, long amount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Amount` = @Amount  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Amount", amount, MySqlDbType.Int64),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "amount">实际账户变化数量（正负数）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAmount(long amount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Amount` = @Amount";
			var parameter_ = Database.CreateInParameter("@Amount", amount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutAmountAsync(long amount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Amount` = @Amount";
			var parameter_ = Database.CreateInParameter("@Amount", amount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutAmount
		#region PutFreespin
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID">主键GUID</param>
		/// /// <param name = "freespin">注册、首充赠送freespin次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFreespinByPK(string detailID, int freespin, TransactionManager tm_ = null)
		{
			RepairPutFreespinByPKData(detailID, freespin, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFreespinByPKAsync(string detailID, int freespin, TransactionManager tm_ = null)
		{
			RepairPutFreespinByPKData(detailID, freespin, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFreespinByPKData(string detailID, int freespin, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Freespin` = @Freespin  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Freespin", freespin, MySqlDbType.Int32),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "freespin">注册、首充赠送freespin次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFreespin(int freespin, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Freespin` = @Freespin";
			var parameter_ = Database.CreateInParameter("@Freespin", freespin, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutFreespinAsync(int freespin, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Freespin` = @Freespin";
			var parameter_ = Database.CreateInParameter("@Freespin", freespin, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutFreespin
		#region PutIsFreespin
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID">主键GUID</param>
		/// /// <param name = "isFreespin">是否为freespin</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsFreespinByPK(string detailID, bool isFreespin, TransactionManager tm_ = null)
		{
			RepairPutIsFreespinByPKData(detailID, isFreespin, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutIsFreespinByPKAsync(string detailID, bool isFreespin, TransactionManager tm_ = null)
		{
			RepairPutIsFreespinByPKData(detailID, isFreespin, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutIsFreespinByPKData(string detailID, bool isFreespin, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `IsFreespin` = @IsFreespin  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@IsFreespin", isFreespin, MySqlDbType.Byte),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "isFreespin">是否为freespin</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsFreespin(bool isFreespin, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsFreespin` = @IsFreespin";
			var parameter_ = Database.CreateInParameter("@IsFreespin", isFreespin, MySqlDbType.Byte);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutIsFreespinAsync(bool isFreespin, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsFreespin` = @IsFreespin";
			var parameter_ = Database.CreateInParameter("@IsFreespin", isFreespin, MySqlDbType.Byte);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutIsFreespin
		#region PutFreespinNum
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID">主键GUID</param>
		/// /// <param name = "freespinNum">freespin剩余数量</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFreespinNumByPK(string detailID, int freespinNum, TransactionManager tm_ = null)
		{
			RepairPutFreespinNumByPKData(detailID, freespinNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFreespinNumByPKAsync(string detailID, int freespinNum, TransactionManager tm_ = null)
		{
			RepairPutFreespinNumByPKData(detailID, freespinNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFreespinNumByPKData(string detailID, int freespinNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `FreespinNum` = @FreespinNum  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@FreespinNum", freespinNum, MySqlDbType.Int32),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "freespinNum">freespin剩余数量</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFreespinNum(int freespinNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FreespinNum` = @FreespinNum";
			var parameter_ = Database.CreateInParameter("@FreespinNum", freespinNum, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutFreespinNumAsync(int freespinNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FreespinNum` = @FreespinNum";
			var parameter_ = Database.CreateInParameter("@FreespinNum", freespinNum, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutFreespinNum
		#region PutRaffleType
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID">主键GUID</param>
		/// /// <param name = "raffleType">抽奖类型1-freespin2-真金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRaffleTypeByPK(string detailID, int raffleType, TransactionManager tm_ = null)
		{
			RepairPutRaffleTypeByPKData(detailID, raffleType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRaffleTypeByPKAsync(string detailID, int raffleType, TransactionManager tm_ = null)
		{
			RepairPutRaffleTypeByPKData(detailID, raffleType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRaffleTypeByPKData(string detailID, int raffleType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RaffleType` = @RaffleType  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RaffleType", raffleType, MySqlDbType.Int32),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "raffleType">抽奖类型1-freespin2-真金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRaffleType(int raffleType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RaffleType` = @RaffleType";
			var parameter_ = Database.CreateInParameter("@RaffleType", raffleType, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutRaffleTypeAsync(int raffleType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RaffleType` = @RaffleType";
			var parameter_ = Database.CreateInParameter("@RaffleType", raffleType, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutRaffleType
		#region PutUserType
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID">主键GUID</param>
		/// /// <param name = "userType">抽奖用户类型1-新用户2-盈利用户3-亏损用户</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserTypeByPK(string detailID, int userType, TransactionManager tm_ = null)
		{
			RepairPutUserTypeByPKData(detailID, userType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutUserTypeByPKAsync(string detailID, int userType, TransactionManager tm_ = null)
		{
			RepairPutUserTypeByPKData(detailID, userType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutUserTypeByPKData(string detailID, int userType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UserType` = @UserType  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserType", userType, MySqlDbType.Int32),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "userType">抽奖用户类型1-新用户2-盈利用户3-亏损用户</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserType(int userType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserType` = @UserType";
			var parameter_ = Database.CreateInParameter("@UserType", userType, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutUserTypeAsync(int userType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserType` = @UserType";
			var parameter_ = Database.CreateInParameter("@UserType", userType, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutUserType
		#region PutLevel
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID">主键GUID</param>
		/// /// <param name = "level">抽奖等级1-基础奖励2-二级奖励</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLevelByPK(string detailID, int level, TransactionManager tm_ = null)
		{
			RepairPutLevelByPKData(detailID, level, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLevelByPKAsync(string detailID, int level, TransactionManager tm_ = null)
		{
			RepairPutLevelByPKData(detailID, level, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLevelByPKData(string detailID, int level, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Level` = @Level  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Level", level, MySqlDbType.Int32),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "level">抽奖等级1-基础奖励2-二级奖励</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLevel(int level, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Level` = @Level";
			var parameter_ = Database.CreateInParameter("@Level", level, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutLevelAsync(int level, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Level` = @Level";
			var parameter_ = Database.CreateInParameter("@Level", level, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutLevel
		#region PutRewardType
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID">主键GUID</param>
		/// /// <param name = "rewardType">奖励类型1-无奖励2-真金3-二级抽奖A4-二级抽奖B</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRewardTypeByPK(string detailID, int rewardType, TransactionManager tm_ = null)
		{
			RepairPutRewardTypeByPKData(detailID, rewardType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRewardTypeByPKAsync(string detailID, int rewardType, TransactionManager tm_ = null)
		{
			RepairPutRewardTypeByPKData(detailID, rewardType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRewardTypeByPKData(string detailID, int rewardType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RewardType` = @RewardType  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RewardType", rewardType, MySqlDbType.Int32),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "rewardType">奖励类型1-无奖励2-真金3-二级抽奖A4-二级抽奖B</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRewardType(int rewardType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RewardType` = @RewardType";
			var parameter_ = Database.CreateInParameter("@RewardType", rewardType, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutRewardTypeAsync(int rewardType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RewardType` = @RewardType";
			var parameter_ = Database.CreateInParameter("@RewardType", rewardType, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutRewardType
		#region PutPreRewardType
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID">主键GUID</param>
		/// /// <param name = "preRewardType">上一级奖励类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPreRewardTypeByPK(string detailID, int preRewardType, TransactionManager tm_ = null)
		{
			RepairPutPreRewardTypeByPKData(detailID, preRewardType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutPreRewardTypeByPKAsync(string detailID, int preRewardType, TransactionManager tm_ = null)
		{
			RepairPutPreRewardTypeByPKData(detailID, preRewardType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutPreRewardTypeByPKData(string detailID, int preRewardType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `PreRewardType` = @PreRewardType  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PreRewardType", preRewardType, MySqlDbType.Int32),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "preRewardType">上一级奖励类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPreRewardType(int preRewardType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PreRewardType` = @PreRewardType";
			var parameter_ = Database.CreateInParameter("@PreRewardType", preRewardType, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutPreRewardTypeAsync(int preRewardType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PreRewardType` = @PreRewardType";
			var parameter_ = Database.CreateInParameter("@PreRewardType", preRewardType, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutPreRewardType
		#region PutPosition
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID">主键GUID</param>
		/// /// <param name = "position">位置</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPositionByPK(string detailID, int position, TransactionManager tm_ = null)
		{
			RepairPutPositionByPKData(detailID, position, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutPositionByPKAsync(string detailID, int position, TransactionManager tm_ = null)
		{
			RepairPutPositionByPKData(detailID, position, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutPositionByPKData(string detailID, int position, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Position` = @Position  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Position", position, MySqlDbType.Int32),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "position">位置</param>
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
		#region PutMultiple
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID">主键GUID</param>
		/// /// <param name = "multiple">倍率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMultipleByPK(string detailID, float multiple, TransactionManager tm_ = null)
		{
			RepairPutMultipleByPKData(detailID, multiple, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutMultipleByPKAsync(string detailID, float multiple, TransactionManager tm_ = null)
		{
			RepairPutMultipleByPKData(detailID, multiple, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutMultipleByPKData(string detailID, float multiple, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Multiple` = @Multiple  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Multiple", multiple, MySqlDbType.Float),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "multiple">倍率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMultiple(float multiple, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Multiple` = @Multiple";
			var parameter_ = Database.CreateInParameter("@Multiple", multiple, MySqlDbType.Float);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutMultipleAsync(float multiple, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Multiple` = @Multiple";
			var parameter_ = Database.CreateInParameter("@Multiple", multiple, MySqlDbType.Float);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutMultiple
		#region PutBonus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID">主键GUID</param>
		/// /// <param name = "bonus">奖金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBonusByPK(string detailID, long bonus, TransactionManager tm_ = null)
		{
			RepairPutBonusByPKData(detailID, bonus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBonusByPKAsync(string detailID, long bonus, TransactionManager tm_ = null)
		{
			RepairPutBonusByPKData(detailID, bonus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBonusByPKData(string detailID, long bonus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Bonus` = @Bonus  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Bonus", bonus, MySqlDbType.Int64),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "bonus">奖金</param>
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
		#region PutStatus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID">主键GUID</param>
		/// /// <param name = "status">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutStatusByPK(string detailID, int status, TransactionManager tm_ = null)
		{
			RepairPutStatusByPKData(detailID, status, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutStatusByPKAsync(string detailID, int status, TransactionManager tm_ = null)
		{
			RepairPutStatusByPKData(detailID, status, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutStatusByPKData(string detailID, int status, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Status` = @Status  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Status", status, MySqlDbType.Int32),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "status">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
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
		#region PutRecDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID">主键GUID</param>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(string detailID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(detailID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(string detailID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(detailID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(string detailID, DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
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
		public bool Set(Sa_roulette_detailEO item, TransactionManager tm = null)
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
		public async Task<bool> SetAsync(Sa_roulette_detailEO item, TransactionManager tm = null)
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
		/// /// <param name = "detailID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Sa_roulette_detailEO GetByPK(string detailID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(detailID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sa_roulette_detailEO.MapDataReader);
		}
		public async Task<Sa_roulette_detailEO> GetByPKAsync(string detailID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(detailID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sa_roulette_detailEO.MapDataReader);
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
		/// 按主键查询 UserID（字段）
		/// </summary>
		/// /// <param name = "detailID">主键GUID</param>
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
		/// 按主键查询 Mobile（字段）
		/// </summary>
		/// /// <param name = "detailID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetMobileByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Mobile`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<string> GetMobileByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Mobile`", "`DetailID` = @DetailID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OperatorID（字段）
		/// </summary>
		/// /// <param name = "detailID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorIDByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OperatorID`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<string> GetOperatorIDByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OperatorID`", "`DetailID` = @DetailID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CurrencyID（字段）
		/// </summary>
		/// /// <param name = "detailID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCurrencyIDByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CurrencyID`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<string> GetCurrencyIDByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CurrencyID`", "`DetailID` = @DetailID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 DetailType（字段）
		/// </summary>
		/// /// <param name = "detailID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetDetailTypeByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`DetailType`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<int> GetDetailTypeByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`DetailType`", "`DetailID` = @DetailID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 PlanBet（字段）
		/// </summary>
		/// /// <param name = "detailID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetPlanBetByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`PlanBet`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<long> GetPlanBetByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`PlanBet`", "`DetailID` = @DetailID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Amount（字段）
		/// </summary>
		/// /// <param name = "detailID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetAmountByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`Amount`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<long> GetAmountByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`Amount`", "`DetailID` = @DetailID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Freespin（字段）
		/// </summary>
		/// /// <param name = "detailID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetFreespinByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`Freespin`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<int> GetFreespinByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`Freespin`", "`DetailID` = @DetailID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 IsFreespin（字段）
		/// </summary>
		/// /// <param name = "detailID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public bool GetIsFreespinByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (bool)GetScalar("`IsFreespin`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<bool> GetIsFreespinByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (bool)await GetScalarAsync("`IsFreespin`", "`DetailID` = @DetailID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 FreespinNum（字段）
		/// </summary>
		/// /// <param name = "detailID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetFreespinNumByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`FreespinNum`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<int> GetFreespinNumByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`FreespinNum`", "`DetailID` = @DetailID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RaffleType（字段）
		/// </summary>
		/// /// <param name = "detailID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetRaffleTypeByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`RaffleType`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<int> GetRaffleTypeByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`RaffleType`", "`DetailID` = @DetailID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 UserType（字段）
		/// </summary>
		/// /// <param name = "detailID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetUserTypeByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`UserType`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<int> GetUserTypeByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`UserType`", "`DetailID` = @DetailID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Level（字段）
		/// </summary>
		/// /// <param name = "detailID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetLevelByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`Level`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<int> GetLevelByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`Level`", "`DetailID` = @DetailID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RewardType（字段）
		/// </summary>
		/// /// <param name = "detailID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetRewardTypeByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`RewardType`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<int> GetRewardTypeByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`RewardType`", "`DetailID` = @DetailID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 PreRewardType（字段）
		/// </summary>
		/// /// <param name = "detailID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetPreRewardTypeByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`PreRewardType`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<int> GetPreRewardTypeByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`PreRewardType`", "`DetailID` = @DetailID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Position（字段）
		/// </summary>
		/// /// <param name = "detailID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetPositionByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`Position`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<int> GetPositionByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`Position`", "`DetailID` = @DetailID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Multiple（字段）
		/// </summary>
		/// /// <param name = "detailID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public float GetMultipleByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (float)GetScalar("`Multiple`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<float> GetMultipleByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (float)await GetScalarAsync("`Multiple`", "`DetailID` = @DetailID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Bonus（字段）
		/// </summary>
		/// /// <param name = "detailID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetBonusByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`Bonus`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<long> GetBonusByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`Bonus`", "`DetailID` = @DetailID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Status（字段）
		/// </summary>
		/// /// <param name = "detailID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetStatusByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`Status`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<int> GetStatusByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`Status`", "`DetailID` = @DetailID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "detailID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetRecDateByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`RecDate`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<DateTime> GetRecDateByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`RecDate`", "`DetailID` = @DetailID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByUserID
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码guid</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByUserID(string userID)
		{
			return GetByUserID(userID, 0, string.Empty, null);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByUserIDAsync(string userID)
		{
			return await GetByUserIDAsync(userID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码guid</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByUserID(string userID, TransactionManager tm_)
		{
			return GetByUserID(userID, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByUserIDAsync(string userID, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码guid</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByUserID(string userID, int top_)
		{
			return GetByUserID(userID, top_, string.Empty, null);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByUserIDAsync(string userID, int top_)
		{
			return await GetByUserIDAsync(userID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码guid</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByUserID(string userID, int top_, TransactionManager tm_)
		{
			return GetByUserID(userID, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByUserIDAsync(string userID, int top_, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码guid</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByUserID(string userID, string sort_)
		{
			return GetByUserID(userID, 0, sort_, null);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByUserIDAsync(string userID, string sort_)
		{
			return await GetByUserIDAsync(userID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码guid</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByUserID(string userID, string sort_, TransactionManager tm_)
		{
			return GetByUserID(userID, 0, sort_, tm_);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByUserIDAsync(string userID, string sort_, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码guid</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByUserID(string userID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserID` = @UserID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_roulette_detailEO.MapDataReader);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByUserIDAsync(string userID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserID` = @UserID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_roulette_detailEO.MapDataReader);
		}
		#endregion // GetByUserID
		#region GetByMobile
		
		/// <summary>
		/// 按 Mobile（字段） 查询
		/// </summary>
		/// /// <param name = "mobile">手机号</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByMobile(string mobile)
		{
			return GetByMobile(mobile, 0, string.Empty, null);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByMobileAsync(string mobile)
		{
			return await GetByMobileAsync(mobile, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Mobile（字段） 查询
		/// </summary>
		/// /// <param name = "mobile">手机号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByMobile(string mobile, TransactionManager tm_)
		{
			return GetByMobile(mobile, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByMobileAsync(string mobile, TransactionManager tm_)
		{
			return await GetByMobileAsync(mobile, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Mobile（字段） 查询
		/// </summary>
		/// /// <param name = "mobile">手机号</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByMobile(string mobile, int top_)
		{
			return GetByMobile(mobile, top_, string.Empty, null);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByMobileAsync(string mobile, int top_)
		{
			return await GetByMobileAsync(mobile, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Mobile（字段） 查询
		/// </summary>
		/// /// <param name = "mobile">手机号</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByMobile(string mobile, int top_, TransactionManager tm_)
		{
			return GetByMobile(mobile, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByMobileAsync(string mobile, int top_, TransactionManager tm_)
		{
			return await GetByMobileAsync(mobile, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Mobile（字段） 查询
		/// </summary>
		/// /// <param name = "mobile">手机号</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByMobile(string mobile, string sort_)
		{
			return GetByMobile(mobile, 0, sort_, null);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByMobileAsync(string mobile, string sort_)
		{
			return await GetByMobileAsync(mobile, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Mobile（字段） 查询
		/// </summary>
		/// /// <param name = "mobile">手机号</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByMobile(string mobile, string sort_, TransactionManager tm_)
		{
			return GetByMobile(mobile, 0, sort_, tm_);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByMobileAsync(string mobile, string sort_, TransactionManager tm_)
		{
			return await GetByMobileAsync(mobile, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Mobile（字段） 查询
		/// </summary>
		/// /// <param name = "mobile">手机号</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByMobile(string mobile, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(mobile != null ? "`Mobile` = @Mobile" : "`Mobile` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (mobile != null)
				paras_.Add(Database.CreateInParameter("@Mobile", mobile, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_roulette_detailEO.MapDataReader);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByMobileAsync(string mobile, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(mobile != null ? "`Mobile` = @Mobile" : "`Mobile` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (mobile != null)
				paras_.Add(Database.CreateInParameter("@Mobile", mobile, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_roulette_detailEO.MapDataReader);
		}
		#endregion // GetByMobile
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByOperatorIDAsync(string operatorID, int top_)
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
		public List<Sa_roulette_detailEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByOperatorIDAsync(string operatorID, string sort_)
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
		public List<Sa_roulette_detailEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
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
		public List<Sa_roulette_detailEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_roulette_detailEO.MapDataReader);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_roulette_detailEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByCurrencyID
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByCurrencyID(string currencyID)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, null);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByCurrencyIDAsync(string currencyID)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByCurrencyID(string currencyID, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByCurrencyIDAsync(string currencyID, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByCurrencyID(string currencyID, int top_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, null);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByCurrencyIDAsync(string currencyID, int top_)
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
		public List<Sa_roulette_detailEO> GetByCurrencyID(string currencyID, int top_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByCurrencyIDAsync(string currencyID, int top_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByCurrencyID(string currencyID, string sort_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, null);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByCurrencyIDAsync(string currencyID, string sort_)
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
		public List<Sa_roulette_detailEO> GetByCurrencyID(string currencyID, string sort_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, tm_);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByCurrencyIDAsync(string currencyID, string sort_, TransactionManager tm_)
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
		public List<Sa_roulette_detailEO> GetByCurrencyID(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_roulette_detailEO.MapDataReader);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByCurrencyIDAsync(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_roulette_detailEO.MapDataReader);
		}
		#endregion // GetByCurrencyID
		#region GetByDetailType
		
		/// <summary>
		/// 按 DetailType（字段） 查询
		/// </summary>
		/// /// <param name = "detailType">1-注册赠送2-首充赠送3-下注</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByDetailType(int detailType)
		{
			return GetByDetailType(detailType, 0, string.Empty, null);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByDetailTypeAsync(int detailType)
		{
			return await GetByDetailTypeAsync(detailType, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DetailType（字段） 查询
		/// </summary>
		/// /// <param name = "detailType">1-注册赠送2-首充赠送3-下注</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByDetailType(int detailType, TransactionManager tm_)
		{
			return GetByDetailType(detailType, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByDetailTypeAsync(int detailType, TransactionManager tm_)
		{
			return await GetByDetailTypeAsync(detailType, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DetailType（字段） 查询
		/// </summary>
		/// /// <param name = "detailType">1-注册赠送2-首充赠送3-下注</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByDetailType(int detailType, int top_)
		{
			return GetByDetailType(detailType, top_, string.Empty, null);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByDetailTypeAsync(int detailType, int top_)
		{
			return await GetByDetailTypeAsync(detailType, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DetailType（字段） 查询
		/// </summary>
		/// /// <param name = "detailType">1-注册赠送2-首充赠送3-下注</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByDetailType(int detailType, int top_, TransactionManager tm_)
		{
			return GetByDetailType(detailType, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByDetailTypeAsync(int detailType, int top_, TransactionManager tm_)
		{
			return await GetByDetailTypeAsync(detailType, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DetailType（字段） 查询
		/// </summary>
		/// /// <param name = "detailType">1-注册赠送2-首充赠送3-下注</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByDetailType(int detailType, string sort_)
		{
			return GetByDetailType(detailType, 0, sort_, null);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByDetailTypeAsync(int detailType, string sort_)
		{
			return await GetByDetailTypeAsync(detailType, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DetailType（字段） 查询
		/// </summary>
		/// /// <param name = "detailType">1-注册赠送2-首充赠送3-下注</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByDetailType(int detailType, string sort_, TransactionManager tm_)
		{
			return GetByDetailType(detailType, 0, sort_, tm_);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByDetailTypeAsync(int detailType, string sort_, TransactionManager tm_)
		{
			return await GetByDetailTypeAsync(detailType, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DetailType（字段） 查询
		/// </summary>
		/// /// <param name = "detailType">1-注册赠送2-首充赠送3-下注</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByDetailType(int detailType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DetailType` = @DetailType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DetailType", detailType, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_roulette_detailEO.MapDataReader);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByDetailTypeAsync(int detailType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DetailType` = @DetailType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DetailType", detailType, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_roulette_detailEO.MapDataReader);
		}
		#endregion // GetByDetailType
		#region GetByPlanBet
		
		/// <summary>
		/// 按 PlanBet（字段） 查询
		/// </summary>
		/// /// <param name = "planBet">计划下注数量</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByPlanBet(long planBet)
		{
			return GetByPlanBet(planBet, 0, string.Empty, null);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByPlanBetAsync(long planBet)
		{
			return await GetByPlanBetAsync(planBet, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PlanBet（字段） 查询
		/// </summary>
		/// /// <param name = "planBet">计划下注数量</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByPlanBet(long planBet, TransactionManager tm_)
		{
			return GetByPlanBet(planBet, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByPlanBetAsync(long planBet, TransactionManager tm_)
		{
			return await GetByPlanBetAsync(planBet, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PlanBet（字段） 查询
		/// </summary>
		/// /// <param name = "planBet">计划下注数量</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByPlanBet(long planBet, int top_)
		{
			return GetByPlanBet(planBet, top_, string.Empty, null);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByPlanBetAsync(long planBet, int top_)
		{
			return await GetByPlanBetAsync(planBet, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PlanBet（字段） 查询
		/// </summary>
		/// /// <param name = "planBet">计划下注数量</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByPlanBet(long planBet, int top_, TransactionManager tm_)
		{
			return GetByPlanBet(planBet, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByPlanBetAsync(long planBet, int top_, TransactionManager tm_)
		{
			return await GetByPlanBetAsync(planBet, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PlanBet（字段） 查询
		/// </summary>
		/// /// <param name = "planBet">计划下注数量</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByPlanBet(long planBet, string sort_)
		{
			return GetByPlanBet(planBet, 0, sort_, null);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByPlanBetAsync(long planBet, string sort_)
		{
			return await GetByPlanBetAsync(planBet, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PlanBet（字段） 查询
		/// </summary>
		/// /// <param name = "planBet">计划下注数量</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByPlanBet(long planBet, string sort_, TransactionManager tm_)
		{
			return GetByPlanBet(planBet, 0, sort_, tm_);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByPlanBetAsync(long planBet, string sort_, TransactionManager tm_)
		{
			return await GetByPlanBetAsync(planBet, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PlanBet（字段） 查询
		/// </summary>
		/// /// <param name = "planBet">计划下注数量</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByPlanBet(long planBet, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PlanBet` = @PlanBet", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PlanBet", planBet, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_roulette_detailEO.MapDataReader);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByPlanBetAsync(long planBet, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PlanBet` = @PlanBet", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PlanBet", planBet, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_roulette_detailEO.MapDataReader);
		}
		#endregion // GetByPlanBet
		#region GetByAmount
		
		/// <summary>
		/// 按 Amount（字段） 查询
		/// </summary>
		/// /// <param name = "amount">实际账户变化数量（正负数）</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByAmount(long amount)
		{
			return GetByAmount(amount, 0, string.Empty, null);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByAmountAsync(long amount)
		{
			return await GetByAmountAsync(amount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Amount（字段） 查询
		/// </summary>
		/// /// <param name = "amount">实际账户变化数量（正负数）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByAmount(long amount, TransactionManager tm_)
		{
			return GetByAmount(amount, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByAmountAsync(long amount, TransactionManager tm_)
		{
			return await GetByAmountAsync(amount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Amount（字段） 查询
		/// </summary>
		/// /// <param name = "amount">实际账户变化数量（正负数）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByAmount(long amount, int top_)
		{
			return GetByAmount(amount, top_, string.Empty, null);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByAmountAsync(long amount, int top_)
		{
			return await GetByAmountAsync(amount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Amount（字段） 查询
		/// </summary>
		/// /// <param name = "amount">实际账户变化数量（正负数）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByAmount(long amount, int top_, TransactionManager tm_)
		{
			return GetByAmount(amount, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByAmountAsync(long amount, int top_, TransactionManager tm_)
		{
			return await GetByAmountAsync(amount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Amount（字段） 查询
		/// </summary>
		/// /// <param name = "amount">实际账户变化数量（正负数）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByAmount(long amount, string sort_)
		{
			return GetByAmount(amount, 0, sort_, null);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByAmountAsync(long amount, string sort_)
		{
			return await GetByAmountAsync(amount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Amount（字段） 查询
		/// </summary>
		/// /// <param name = "amount">实际账户变化数量（正负数）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByAmount(long amount, string sort_, TransactionManager tm_)
		{
			return GetByAmount(amount, 0, sort_, tm_);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByAmountAsync(long amount, string sort_, TransactionManager tm_)
		{
			return await GetByAmountAsync(amount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Amount（字段） 查询
		/// </summary>
		/// /// <param name = "amount">实际账户变化数量（正负数）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByAmount(long amount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Amount` = @Amount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Amount", amount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_roulette_detailEO.MapDataReader);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByAmountAsync(long amount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Amount` = @Amount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Amount", amount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_roulette_detailEO.MapDataReader);
		}
		#endregion // GetByAmount
		#region GetByFreespin
		
		/// <summary>
		/// 按 Freespin（字段） 查询
		/// </summary>
		/// /// <param name = "freespin">注册、首充赠送freespin次数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByFreespin(int freespin)
		{
			return GetByFreespin(freespin, 0, string.Empty, null);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByFreespinAsync(int freespin)
		{
			return await GetByFreespinAsync(freespin, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Freespin（字段） 查询
		/// </summary>
		/// /// <param name = "freespin">注册、首充赠送freespin次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByFreespin(int freespin, TransactionManager tm_)
		{
			return GetByFreespin(freespin, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByFreespinAsync(int freespin, TransactionManager tm_)
		{
			return await GetByFreespinAsync(freespin, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Freespin（字段） 查询
		/// </summary>
		/// /// <param name = "freespin">注册、首充赠送freespin次数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByFreespin(int freespin, int top_)
		{
			return GetByFreespin(freespin, top_, string.Empty, null);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByFreespinAsync(int freespin, int top_)
		{
			return await GetByFreespinAsync(freespin, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Freespin（字段） 查询
		/// </summary>
		/// /// <param name = "freespin">注册、首充赠送freespin次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByFreespin(int freespin, int top_, TransactionManager tm_)
		{
			return GetByFreespin(freespin, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByFreespinAsync(int freespin, int top_, TransactionManager tm_)
		{
			return await GetByFreespinAsync(freespin, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Freespin（字段） 查询
		/// </summary>
		/// /// <param name = "freespin">注册、首充赠送freespin次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByFreespin(int freespin, string sort_)
		{
			return GetByFreespin(freespin, 0, sort_, null);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByFreespinAsync(int freespin, string sort_)
		{
			return await GetByFreespinAsync(freespin, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Freespin（字段） 查询
		/// </summary>
		/// /// <param name = "freespin">注册、首充赠送freespin次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByFreespin(int freespin, string sort_, TransactionManager tm_)
		{
			return GetByFreespin(freespin, 0, sort_, tm_);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByFreespinAsync(int freespin, string sort_, TransactionManager tm_)
		{
			return await GetByFreespinAsync(freespin, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Freespin（字段） 查询
		/// </summary>
		/// /// <param name = "freespin">注册、首充赠送freespin次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByFreespin(int freespin, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Freespin` = @Freespin", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Freespin", freespin, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_roulette_detailEO.MapDataReader);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByFreespinAsync(int freespin, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Freespin` = @Freespin", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Freespin", freespin, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_roulette_detailEO.MapDataReader);
		}
		#endregion // GetByFreespin
		#region GetByIsFreespin
		
		/// <summary>
		/// 按 IsFreespin（字段） 查询
		/// </summary>
		/// /// <param name = "isFreespin">是否为freespin</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByIsFreespin(bool isFreespin)
		{
			return GetByIsFreespin(isFreespin, 0, string.Empty, null);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByIsFreespinAsync(bool isFreespin)
		{
			return await GetByIsFreespinAsync(isFreespin, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsFreespin（字段） 查询
		/// </summary>
		/// /// <param name = "isFreespin">是否为freespin</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByIsFreespin(bool isFreespin, TransactionManager tm_)
		{
			return GetByIsFreespin(isFreespin, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByIsFreespinAsync(bool isFreespin, TransactionManager tm_)
		{
			return await GetByIsFreespinAsync(isFreespin, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsFreespin（字段） 查询
		/// </summary>
		/// /// <param name = "isFreespin">是否为freespin</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByIsFreespin(bool isFreespin, int top_)
		{
			return GetByIsFreespin(isFreespin, top_, string.Empty, null);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByIsFreespinAsync(bool isFreespin, int top_)
		{
			return await GetByIsFreespinAsync(isFreespin, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsFreespin（字段） 查询
		/// </summary>
		/// /// <param name = "isFreespin">是否为freespin</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByIsFreespin(bool isFreespin, int top_, TransactionManager tm_)
		{
			return GetByIsFreespin(isFreespin, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByIsFreespinAsync(bool isFreespin, int top_, TransactionManager tm_)
		{
			return await GetByIsFreespinAsync(isFreespin, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsFreespin（字段） 查询
		/// </summary>
		/// /// <param name = "isFreespin">是否为freespin</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByIsFreespin(bool isFreespin, string sort_)
		{
			return GetByIsFreespin(isFreespin, 0, sort_, null);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByIsFreespinAsync(bool isFreespin, string sort_)
		{
			return await GetByIsFreespinAsync(isFreespin, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 IsFreespin（字段） 查询
		/// </summary>
		/// /// <param name = "isFreespin">是否为freespin</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByIsFreespin(bool isFreespin, string sort_, TransactionManager tm_)
		{
			return GetByIsFreespin(isFreespin, 0, sort_, tm_);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByIsFreespinAsync(bool isFreespin, string sort_, TransactionManager tm_)
		{
			return await GetByIsFreespinAsync(isFreespin, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 IsFreespin（字段） 查询
		/// </summary>
		/// /// <param name = "isFreespin">是否为freespin</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByIsFreespin(bool isFreespin, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsFreespin` = @IsFreespin", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsFreespin", isFreespin, MySqlDbType.Byte));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_roulette_detailEO.MapDataReader);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByIsFreespinAsync(bool isFreespin, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsFreespin` = @IsFreespin", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsFreespin", isFreespin, MySqlDbType.Byte));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_roulette_detailEO.MapDataReader);
		}
		#endregion // GetByIsFreespin
		#region GetByFreespinNum
		
		/// <summary>
		/// 按 FreespinNum（字段） 查询
		/// </summary>
		/// /// <param name = "freespinNum">freespin剩余数量</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByFreespinNum(int freespinNum)
		{
			return GetByFreespinNum(freespinNum, 0, string.Empty, null);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByFreespinNumAsync(int freespinNum)
		{
			return await GetByFreespinNumAsync(freespinNum, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FreespinNum（字段） 查询
		/// </summary>
		/// /// <param name = "freespinNum">freespin剩余数量</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByFreespinNum(int freespinNum, TransactionManager tm_)
		{
			return GetByFreespinNum(freespinNum, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByFreespinNumAsync(int freespinNum, TransactionManager tm_)
		{
			return await GetByFreespinNumAsync(freespinNum, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FreespinNum（字段） 查询
		/// </summary>
		/// /// <param name = "freespinNum">freespin剩余数量</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByFreespinNum(int freespinNum, int top_)
		{
			return GetByFreespinNum(freespinNum, top_, string.Empty, null);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByFreespinNumAsync(int freespinNum, int top_)
		{
			return await GetByFreespinNumAsync(freespinNum, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FreespinNum（字段） 查询
		/// </summary>
		/// /// <param name = "freespinNum">freespin剩余数量</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByFreespinNum(int freespinNum, int top_, TransactionManager tm_)
		{
			return GetByFreespinNum(freespinNum, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByFreespinNumAsync(int freespinNum, int top_, TransactionManager tm_)
		{
			return await GetByFreespinNumAsync(freespinNum, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FreespinNum（字段） 查询
		/// </summary>
		/// /// <param name = "freespinNum">freespin剩余数量</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByFreespinNum(int freespinNum, string sort_)
		{
			return GetByFreespinNum(freespinNum, 0, sort_, null);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByFreespinNumAsync(int freespinNum, string sort_)
		{
			return await GetByFreespinNumAsync(freespinNum, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 FreespinNum（字段） 查询
		/// </summary>
		/// /// <param name = "freespinNum">freespin剩余数量</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByFreespinNum(int freespinNum, string sort_, TransactionManager tm_)
		{
			return GetByFreespinNum(freespinNum, 0, sort_, tm_);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByFreespinNumAsync(int freespinNum, string sort_, TransactionManager tm_)
		{
			return await GetByFreespinNumAsync(freespinNum, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 FreespinNum（字段） 查询
		/// </summary>
		/// /// <param name = "freespinNum">freespin剩余数量</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByFreespinNum(int freespinNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FreespinNum` = @FreespinNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FreespinNum", freespinNum, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_roulette_detailEO.MapDataReader);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByFreespinNumAsync(int freespinNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FreespinNum` = @FreespinNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FreespinNum", freespinNum, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_roulette_detailEO.MapDataReader);
		}
		#endregion // GetByFreespinNum
		#region GetByRaffleType
		
		/// <summary>
		/// 按 RaffleType（字段） 查询
		/// </summary>
		/// /// <param name = "raffleType">抽奖类型1-freespin2-真金</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByRaffleType(int raffleType)
		{
			return GetByRaffleType(raffleType, 0, string.Empty, null);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByRaffleTypeAsync(int raffleType)
		{
			return await GetByRaffleTypeAsync(raffleType, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RaffleType（字段） 查询
		/// </summary>
		/// /// <param name = "raffleType">抽奖类型1-freespin2-真金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByRaffleType(int raffleType, TransactionManager tm_)
		{
			return GetByRaffleType(raffleType, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByRaffleTypeAsync(int raffleType, TransactionManager tm_)
		{
			return await GetByRaffleTypeAsync(raffleType, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RaffleType（字段） 查询
		/// </summary>
		/// /// <param name = "raffleType">抽奖类型1-freespin2-真金</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByRaffleType(int raffleType, int top_)
		{
			return GetByRaffleType(raffleType, top_, string.Empty, null);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByRaffleTypeAsync(int raffleType, int top_)
		{
			return await GetByRaffleTypeAsync(raffleType, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RaffleType（字段） 查询
		/// </summary>
		/// /// <param name = "raffleType">抽奖类型1-freespin2-真金</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByRaffleType(int raffleType, int top_, TransactionManager tm_)
		{
			return GetByRaffleType(raffleType, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByRaffleTypeAsync(int raffleType, int top_, TransactionManager tm_)
		{
			return await GetByRaffleTypeAsync(raffleType, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RaffleType（字段） 查询
		/// </summary>
		/// /// <param name = "raffleType">抽奖类型1-freespin2-真金</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByRaffleType(int raffleType, string sort_)
		{
			return GetByRaffleType(raffleType, 0, sort_, null);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByRaffleTypeAsync(int raffleType, string sort_)
		{
			return await GetByRaffleTypeAsync(raffleType, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RaffleType（字段） 查询
		/// </summary>
		/// /// <param name = "raffleType">抽奖类型1-freespin2-真金</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByRaffleType(int raffleType, string sort_, TransactionManager tm_)
		{
			return GetByRaffleType(raffleType, 0, sort_, tm_);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByRaffleTypeAsync(int raffleType, string sort_, TransactionManager tm_)
		{
			return await GetByRaffleTypeAsync(raffleType, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RaffleType（字段） 查询
		/// </summary>
		/// /// <param name = "raffleType">抽奖类型1-freespin2-真金</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByRaffleType(int raffleType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RaffleType` = @RaffleType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RaffleType", raffleType, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_roulette_detailEO.MapDataReader);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByRaffleTypeAsync(int raffleType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RaffleType` = @RaffleType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RaffleType", raffleType, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_roulette_detailEO.MapDataReader);
		}
		#endregion // GetByRaffleType
		#region GetByUserType
		
		/// <summary>
		/// 按 UserType（字段） 查询
		/// </summary>
		/// /// <param name = "userType">抽奖用户类型1-新用户2-盈利用户3-亏损用户</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByUserType(int userType)
		{
			return GetByUserType(userType, 0, string.Empty, null);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByUserTypeAsync(int userType)
		{
			return await GetByUserTypeAsync(userType, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserType（字段） 查询
		/// </summary>
		/// /// <param name = "userType">抽奖用户类型1-新用户2-盈利用户3-亏损用户</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByUserType(int userType, TransactionManager tm_)
		{
			return GetByUserType(userType, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByUserTypeAsync(int userType, TransactionManager tm_)
		{
			return await GetByUserTypeAsync(userType, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserType（字段） 查询
		/// </summary>
		/// /// <param name = "userType">抽奖用户类型1-新用户2-盈利用户3-亏损用户</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByUserType(int userType, int top_)
		{
			return GetByUserType(userType, top_, string.Empty, null);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByUserTypeAsync(int userType, int top_)
		{
			return await GetByUserTypeAsync(userType, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserType（字段） 查询
		/// </summary>
		/// /// <param name = "userType">抽奖用户类型1-新用户2-盈利用户3-亏损用户</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByUserType(int userType, int top_, TransactionManager tm_)
		{
			return GetByUserType(userType, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByUserTypeAsync(int userType, int top_, TransactionManager tm_)
		{
			return await GetByUserTypeAsync(userType, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserType（字段） 查询
		/// </summary>
		/// /// <param name = "userType">抽奖用户类型1-新用户2-盈利用户3-亏损用户</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByUserType(int userType, string sort_)
		{
			return GetByUserType(userType, 0, sort_, null);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByUserTypeAsync(int userType, string sort_)
		{
			return await GetByUserTypeAsync(userType, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 UserType（字段） 查询
		/// </summary>
		/// /// <param name = "userType">抽奖用户类型1-新用户2-盈利用户3-亏损用户</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByUserType(int userType, string sort_, TransactionManager tm_)
		{
			return GetByUserType(userType, 0, sort_, tm_);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByUserTypeAsync(int userType, string sort_, TransactionManager tm_)
		{
			return await GetByUserTypeAsync(userType, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 UserType（字段） 查询
		/// </summary>
		/// /// <param name = "userType">抽奖用户类型1-新用户2-盈利用户3-亏损用户</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByUserType(int userType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserType` = @UserType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserType", userType, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_roulette_detailEO.MapDataReader);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByUserTypeAsync(int userType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserType` = @UserType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserType", userType, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_roulette_detailEO.MapDataReader);
		}
		#endregion // GetByUserType
		#region GetByLevel
		
		/// <summary>
		/// 按 Level（字段） 查询
		/// </summary>
		/// /// <param name = "level">抽奖等级1-基础奖励2-二级奖励</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByLevel(int level)
		{
			return GetByLevel(level, 0, string.Empty, null);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByLevelAsync(int level)
		{
			return await GetByLevelAsync(level, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Level（字段） 查询
		/// </summary>
		/// /// <param name = "level">抽奖等级1-基础奖励2-二级奖励</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByLevel(int level, TransactionManager tm_)
		{
			return GetByLevel(level, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByLevelAsync(int level, TransactionManager tm_)
		{
			return await GetByLevelAsync(level, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Level（字段） 查询
		/// </summary>
		/// /// <param name = "level">抽奖等级1-基础奖励2-二级奖励</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByLevel(int level, int top_)
		{
			return GetByLevel(level, top_, string.Empty, null);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByLevelAsync(int level, int top_)
		{
			return await GetByLevelAsync(level, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Level（字段） 查询
		/// </summary>
		/// /// <param name = "level">抽奖等级1-基础奖励2-二级奖励</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByLevel(int level, int top_, TransactionManager tm_)
		{
			return GetByLevel(level, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByLevelAsync(int level, int top_, TransactionManager tm_)
		{
			return await GetByLevelAsync(level, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Level（字段） 查询
		/// </summary>
		/// /// <param name = "level">抽奖等级1-基础奖励2-二级奖励</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByLevel(int level, string sort_)
		{
			return GetByLevel(level, 0, sort_, null);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByLevelAsync(int level, string sort_)
		{
			return await GetByLevelAsync(level, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Level（字段） 查询
		/// </summary>
		/// /// <param name = "level">抽奖等级1-基础奖励2-二级奖励</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByLevel(int level, string sort_, TransactionManager tm_)
		{
			return GetByLevel(level, 0, sort_, tm_);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByLevelAsync(int level, string sort_, TransactionManager tm_)
		{
			return await GetByLevelAsync(level, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Level（字段） 查询
		/// </summary>
		/// /// <param name = "level">抽奖等级1-基础奖励2-二级奖励</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByLevel(int level, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Level` = @Level", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Level", level, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_roulette_detailEO.MapDataReader);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByLevelAsync(int level, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Level` = @Level", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Level", level, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_roulette_detailEO.MapDataReader);
		}
		#endregion // GetByLevel
		#region GetByRewardType
		
		/// <summary>
		/// 按 RewardType（字段） 查询
		/// </summary>
		/// /// <param name = "rewardType">奖励类型1-无奖励2-真金3-二级抽奖A4-二级抽奖B</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByRewardType(int rewardType)
		{
			return GetByRewardType(rewardType, 0, string.Empty, null);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByRewardTypeAsync(int rewardType)
		{
			return await GetByRewardTypeAsync(rewardType, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RewardType（字段） 查询
		/// </summary>
		/// /// <param name = "rewardType">奖励类型1-无奖励2-真金3-二级抽奖A4-二级抽奖B</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByRewardType(int rewardType, TransactionManager tm_)
		{
			return GetByRewardType(rewardType, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByRewardTypeAsync(int rewardType, TransactionManager tm_)
		{
			return await GetByRewardTypeAsync(rewardType, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RewardType（字段） 查询
		/// </summary>
		/// /// <param name = "rewardType">奖励类型1-无奖励2-真金3-二级抽奖A4-二级抽奖B</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByRewardType(int rewardType, int top_)
		{
			return GetByRewardType(rewardType, top_, string.Empty, null);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByRewardTypeAsync(int rewardType, int top_)
		{
			return await GetByRewardTypeAsync(rewardType, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RewardType（字段） 查询
		/// </summary>
		/// /// <param name = "rewardType">奖励类型1-无奖励2-真金3-二级抽奖A4-二级抽奖B</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByRewardType(int rewardType, int top_, TransactionManager tm_)
		{
			return GetByRewardType(rewardType, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByRewardTypeAsync(int rewardType, int top_, TransactionManager tm_)
		{
			return await GetByRewardTypeAsync(rewardType, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RewardType（字段） 查询
		/// </summary>
		/// /// <param name = "rewardType">奖励类型1-无奖励2-真金3-二级抽奖A4-二级抽奖B</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByRewardType(int rewardType, string sort_)
		{
			return GetByRewardType(rewardType, 0, sort_, null);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByRewardTypeAsync(int rewardType, string sort_)
		{
			return await GetByRewardTypeAsync(rewardType, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RewardType（字段） 查询
		/// </summary>
		/// /// <param name = "rewardType">奖励类型1-无奖励2-真金3-二级抽奖A4-二级抽奖B</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByRewardType(int rewardType, string sort_, TransactionManager tm_)
		{
			return GetByRewardType(rewardType, 0, sort_, tm_);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByRewardTypeAsync(int rewardType, string sort_, TransactionManager tm_)
		{
			return await GetByRewardTypeAsync(rewardType, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RewardType（字段） 查询
		/// </summary>
		/// /// <param name = "rewardType">奖励类型1-无奖励2-真金3-二级抽奖A4-二级抽奖B</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByRewardType(int rewardType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RewardType` = @RewardType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RewardType", rewardType, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_roulette_detailEO.MapDataReader);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByRewardTypeAsync(int rewardType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RewardType` = @RewardType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RewardType", rewardType, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_roulette_detailEO.MapDataReader);
		}
		#endregion // GetByRewardType
		#region GetByPreRewardType
		
		/// <summary>
		/// 按 PreRewardType（字段） 查询
		/// </summary>
		/// /// <param name = "preRewardType">上一级奖励类型</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByPreRewardType(int preRewardType)
		{
			return GetByPreRewardType(preRewardType, 0, string.Empty, null);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByPreRewardTypeAsync(int preRewardType)
		{
			return await GetByPreRewardTypeAsync(preRewardType, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PreRewardType（字段） 查询
		/// </summary>
		/// /// <param name = "preRewardType">上一级奖励类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByPreRewardType(int preRewardType, TransactionManager tm_)
		{
			return GetByPreRewardType(preRewardType, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByPreRewardTypeAsync(int preRewardType, TransactionManager tm_)
		{
			return await GetByPreRewardTypeAsync(preRewardType, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PreRewardType（字段） 查询
		/// </summary>
		/// /// <param name = "preRewardType">上一级奖励类型</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByPreRewardType(int preRewardType, int top_)
		{
			return GetByPreRewardType(preRewardType, top_, string.Empty, null);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByPreRewardTypeAsync(int preRewardType, int top_)
		{
			return await GetByPreRewardTypeAsync(preRewardType, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PreRewardType（字段） 查询
		/// </summary>
		/// /// <param name = "preRewardType">上一级奖励类型</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByPreRewardType(int preRewardType, int top_, TransactionManager tm_)
		{
			return GetByPreRewardType(preRewardType, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByPreRewardTypeAsync(int preRewardType, int top_, TransactionManager tm_)
		{
			return await GetByPreRewardTypeAsync(preRewardType, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PreRewardType（字段） 查询
		/// </summary>
		/// /// <param name = "preRewardType">上一级奖励类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByPreRewardType(int preRewardType, string sort_)
		{
			return GetByPreRewardType(preRewardType, 0, sort_, null);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByPreRewardTypeAsync(int preRewardType, string sort_)
		{
			return await GetByPreRewardTypeAsync(preRewardType, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PreRewardType（字段） 查询
		/// </summary>
		/// /// <param name = "preRewardType">上一级奖励类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByPreRewardType(int preRewardType, string sort_, TransactionManager tm_)
		{
			return GetByPreRewardType(preRewardType, 0, sort_, tm_);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByPreRewardTypeAsync(int preRewardType, string sort_, TransactionManager tm_)
		{
			return await GetByPreRewardTypeAsync(preRewardType, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PreRewardType（字段） 查询
		/// </summary>
		/// /// <param name = "preRewardType">上一级奖励类型</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByPreRewardType(int preRewardType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PreRewardType` = @PreRewardType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PreRewardType", preRewardType, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_roulette_detailEO.MapDataReader);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByPreRewardTypeAsync(int preRewardType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PreRewardType` = @PreRewardType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PreRewardType", preRewardType, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_roulette_detailEO.MapDataReader);
		}
		#endregion // GetByPreRewardType
		#region GetByPosition
		
		/// <summary>
		/// 按 Position（字段） 查询
		/// </summary>
		/// /// <param name = "position">位置</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByPosition(int position)
		{
			return GetByPosition(position, 0, string.Empty, null);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByPositionAsync(int position)
		{
			return await GetByPositionAsync(position, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Position（字段） 查询
		/// </summary>
		/// /// <param name = "position">位置</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByPosition(int position, TransactionManager tm_)
		{
			return GetByPosition(position, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByPositionAsync(int position, TransactionManager tm_)
		{
			return await GetByPositionAsync(position, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Position（字段） 查询
		/// </summary>
		/// /// <param name = "position">位置</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByPosition(int position, int top_)
		{
			return GetByPosition(position, top_, string.Empty, null);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByPositionAsync(int position, int top_)
		{
			return await GetByPositionAsync(position, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Position（字段） 查询
		/// </summary>
		/// /// <param name = "position">位置</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByPosition(int position, int top_, TransactionManager tm_)
		{
			return GetByPosition(position, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByPositionAsync(int position, int top_, TransactionManager tm_)
		{
			return await GetByPositionAsync(position, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Position（字段） 查询
		/// </summary>
		/// /// <param name = "position">位置</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByPosition(int position, string sort_)
		{
			return GetByPosition(position, 0, sort_, null);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByPositionAsync(int position, string sort_)
		{
			return await GetByPositionAsync(position, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Position（字段） 查询
		/// </summary>
		/// /// <param name = "position">位置</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByPosition(int position, string sort_, TransactionManager tm_)
		{
			return GetByPosition(position, 0, sort_, tm_);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByPositionAsync(int position, string sort_, TransactionManager tm_)
		{
			return await GetByPositionAsync(position, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Position（字段） 查询
		/// </summary>
		/// /// <param name = "position">位置</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByPosition(int position, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Position` = @Position", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Position", position, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_roulette_detailEO.MapDataReader);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByPositionAsync(int position, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Position` = @Position", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Position", position, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_roulette_detailEO.MapDataReader);
		}
		#endregion // GetByPosition
		#region GetByMultiple
		
		/// <summary>
		/// 按 Multiple（字段） 查询
		/// </summary>
		/// /// <param name = "multiple">倍率</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByMultiple(float multiple)
		{
			return GetByMultiple(multiple, 0, string.Empty, null);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByMultipleAsync(float multiple)
		{
			return await GetByMultipleAsync(multiple, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Multiple（字段） 查询
		/// </summary>
		/// /// <param name = "multiple">倍率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByMultiple(float multiple, TransactionManager tm_)
		{
			return GetByMultiple(multiple, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByMultipleAsync(float multiple, TransactionManager tm_)
		{
			return await GetByMultipleAsync(multiple, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Multiple（字段） 查询
		/// </summary>
		/// /// <param name = "multiple">倍率</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByMultiple(float multiple, int top_)
		{
			return GetByMultiple(multiple, top_, string.Empty, null);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByMultipleAsync(float multiple, int top_)
		{
			return await GetByMultipleAsync(multiple, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Multiple（字段） 查询
		/// </summary>
		/// /// <param name = "multiple">倍率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByMultiple(float multiple, int top_, TransactionManager tm_)
		{
			return GetByMultiple(multiple, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByMultipleAsync(float multiple, int top_, TransactionManager tm_)
		{
			return await GetByMultipleAsync(multiple, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Multiple（字段） 查询
		/// </summary>
		/// /// <param name = "multiple">倍率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByMultiple(float multiple, string sort_)
		{
			return GetByMultiple(multiple, 0, sort_, null);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByMultipleAsync(float multiple, string sort_)
		{
			return await GetByMultipleAsync(multiple, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Multiple（字段） 查询
		/// </summary>
		/// /// <param name = "multiple">倍率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByMultiple(float multiple, string sort_, TransactionManager tm_)
		{
			return GetByMultiple(multiple, 0, sort_, tm_);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByMultipleAsync(float multiple, string sort_, TransactionManager tm_)
		{
			return await GetByMultipleAsync(multiple, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Multiple（字段） 查询
		/// </summary>
		/// /// <param name = "multiple">倍率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByMultiple(float multiple, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Multiple` = @Multiple", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Multiple", multiple, MySqlDbType.Float));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_roulette_detailEO.MapDataReader);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByMultipleAsync(float multiple, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Multiple` = @Multiple", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Multiple", multiple, MySqlDbType.Float));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_roulette_detailEO.MapDataReader);
		}
		#endregion // GetByMultiple
		#region GetByBonus
		
		/// <summary>
		/// 按 Bonus（字段） 查询
		/// </summary>
		/// /// <param name = "bonus">奖金</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByBonus(long bonus)
		{
			return GetByBonus(bonus, 0, string.Empty, null);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByBonusAsync(long bonus)
		{
			return await GetByBonusAsync(bonus, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Bonus（字段） 查询
		/// </summary>
		/// /// <param name = "bonus">奖金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByBonus(long bonus, TransactionManager tm_)
		{
			return GetByBonus(bonus, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByBonusAsync(long bonus, TransactionManager tm_)
		{
			return await GetByBonusAsync(bonus, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Bonus（字段） 查询
		/// </summary>
		/// /// <param name = "bonus">奖金</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByBonus(long bonus, int top_)
		{
			return GetByBonus(bonus, top_, string.Empty, null);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByBonusAsync(long bonus, int top_)
		{
			return await GetByBonusAsync(bonus, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Bonus（字段） 查询
		/// </summary>
		/// /// <param name = "bonus">奖金</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByBonus(long bonus, int top_, TransactionManager tm_)
		{
			return GetByBonus(bonus, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByBonusAsync(long bonus, int top_, TransactionManager tm_)
		{
			return await GetByBonusAsync(bonus, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Bonus（字段） 查询
		/// </summary>
		/// /// <param name = "bonus">奖金</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByBonus(long bonus, string sort_)
		{
			return GetByBonus(bonus, 0, sort_, null);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByBonusAsync(long bonus, string sort_)
		{
			return await GetByBonusAsync(bonus, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Bonus（字段） 查询
		/// </summary>
		/// /// <param name = "bonus">奖金</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByBonus(long bonus, string sort_, TransactionManager tm_)
		{
			return GetByBonus(bonus, 0, sort_, tm_);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByBonusAsync(long bonus, string sort_, TransactionManager tm_)
		{
			return await GetByBonusAsync(bonus, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Bonus（字段） 查询
		/// </summary>
		/// /// <param name = "bonus">奖金</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByBonus(long bonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Bonus` = @Bonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Bonus", bonus, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_roulette_detailEO.MapDataReader);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByBonusAsync(long bonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Bonus` = @Bonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Bonus", bonus, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_roulette_detailEO.MapDataReader);
		}
		#endregion // GetByBonus
		#region GetByStatus
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByStatus(int status)
		{
			return GetByStatus(status, 0, string.Empty, null);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByStatusAsync(int status)
		{
			return await GetByStatusAsync(status, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByStatus(int status, TransactionManager tm_)
		{
			return GetByStatus(status, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByStatusAsync(int status, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByStatus(int status, int top_)
		{
			return GetByStatus(status, top_, string.Empty, null);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByStatusAsync(int status, int top_)
		{
			return await GetByStatusAsync(status, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByStatus(int status, int top_, TransactionManager tm_)
		{
			return GetByStatus(status, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByStatusAsync(int status, int top_, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByStatus(int status, string sort_)
		{
			return GetByStatus(status, 0, sort_, null);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByStatusAsync(int status, string sort_)
		{
			return await GetByStatusAsync(status, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByStatus(int status, string sort_, TransactionManager tm_)
		{
			return GetByStatus(status, 0, sort_, tm_);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByStatusAsync(int status, string sort_, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByStatus(int status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_roulette_detailEO.MapDataReader);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByStatusAsync(int status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_roulette_detailEO.MapDataReader);
		}
		#endregion // GetByStatus
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByRecDateAsync(DateTime recDate, int top_)
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
		public List<Sa_roulette_detailEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_roulette_detailEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByRecDateAsync(DateTime recDate, string sort_)
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
		public List<Sa_roulette_detailEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
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
		public List<Sa_roulette_detailEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_roulette_detailEO.MapDataReader);
		}
		public async Task<List<Sa_roulette_detailEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_roulette_detailEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
